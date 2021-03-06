using System;
using System.Collections.Generic;
using DfExample.DBFlute.AllCommon;
using DfExample.DBFlute.AllCommon.Ado;
using DfExample.DBFlute.AllCommon.Bhv.Load;
using DfExample.DBFlute.AllCommon.CBean.Grouping;
using DfExample.DBFlute.AllCommon.CBean.PageNavi.Group;
using DfExample.DBFlute.AllCommon.CBean.PageNavi.Range;
using DfExample.DBFlute.AllCommon.Exp;
using DfExample.DBFlute.ExBhv;
using DfExample.DBFlute.CBean;
using DfExample.DBFlute.ExDao.PmBean;
using DfExample.DBFlute.ExEntity;
using DfExample.DBFlute.AllCommon.CBean;
using DfExample.DBFlute.ExEntity.Customize;
using Seasar.Quill.Unit;
using Seasar.Extension.Unit;

namespace DfExample.DBFlute.HowTo.Jp {

    /// <summary>
    /// Behaviorの上級編Example実装。
    /// 
    /// ターゲットは以下の通り：
    ///   o DBFluteをとことん極めたい方
    ///   o 開発中で難しい要求が出てきて実現方法がわからなくて困っている方
    ///   
    /// コンテンツは以下の通り：
    ///   o ページング検索のページングナビゲーション要素: selectPage(), pageRange(), pageGroup().
    ///   o one-to-many-to-one(子テーブルの親テーブル)の取得: loadXxxList().
    ///   o one-to-many-to-many(子テーブルの子テーブル(孫テーブル))の取得: loadXxxList().
    ///   o many-to-one-to-many(親テーブルの子テーブル(兄弟テーブル))の取得: pulloutXxx(), loadXxxList().
    ///   x バッチ登録: batchInsert().
    ///   x 排他制御ありバッチ更新: batchUpdate().
    ///   x 排他制御なしバッチ更新: batchUpdateNonstrict().
    ///   x 排他制御ありバッチ削除: batchDelete().
    ///   x 排他制御なしバッチ削除: batchDeleteNonstrict().
    ///   o 外だしSQLでBehaviorQueryPathのSubDirectory機能を利用: PATH_xxx_selectXxx.
    ///   o 外だしSQLでカーソルの使った検索(大量件数対策): outsideSql().cursorHandling().selectCursor().
    ///   o 外だしSQLでStatementのコンフィグを設定: outsideSql().configure(statementConfig).
    ///   o 外だしSQLでParameterBeanプロパティのPackage解決: '-- !!Date xxx!!'.
    ///   o 外だしSQLでSQLファイルが見つからないときの挙動とメッセージ: OutsideSqlNotFoundException.
    ///   o 外だしSQLでBooleanでないIFコメントの場合の挙動と専用メッセージ: IfCommentNotBooleanResultException.
    ///   o 外だしSQLで間違ったIFコメントの場合の挙動と専用メッセージ: IfCommentWrongExpressionException.
    ///   o ページングの超過ページ番号での検索時の再検索を無効化(ConditionBean): disablePagingReSelect().
    ///   o ページングの超過ページ番号での検索時の再検索を無効化(OutsideSql): disablePagingReSelect().
    ///   o 共通カラムの自動設定を無視して明示的に登録(or 更新): disableCommonColumnAutoSetup().
    ///   o Entityリストの件数ごとのグルーピング: ListResultBean.groupingList().
    ///   o Entityリストのグルーピング(コントロールブレイク): ListResultBean.groupingList(), determine().
    /// </summary>
    [MbUnit.Framework.TestFixture]
    public class BehaviorPlatinumTest : ContainerTestCase {

        // ===============================================================================
        //                                                                       Attribute
        //                                                                       =========
        protected MemberBhv _memberBhv;
        protected MemberStatusBhv _memberStatusBhv;
        protected PurchaseBhv _purchaseBhv;

        // ===============================================================================
        //                                                                     Page Select
        //                                                                     ===========
        // -------------------------------------------------
        //                                            Paging
        //                                            ------
        /**
         * ページング検索のページングナビゲーション要素: selectPage(), pageRange(), pageGroup(). 
         * 会員名称の昇順のリストを「１ページ４件」の「２ページ目」と「３ページ目」を検索。
         * <pre>
         * もし総ページ数が膨大な場合に、画面にて全てのページ番号のLinkを表示するのはあまり格好良くない。
         * 
         * [1 2 3 4 5 6 7 8 9 10 11 12 13 14 15 16 17 18 19 20 21 22 23 24 25 26 27 28 29...]
         * 
         * その場合に「ある限られたページ番号のみ」を表示するためにDBFluteが幾つかの手法を提供している。
         * 
         * {PageRange}
         * 前後nページだけを表示する。
         *   ex) 総ページ数が「22」の場合で、前後「5」ページを表示
         *     [4]Page目を選択  - [1 2 3 '4' 5 6 7 8 9 次へ]
         *     [13]Page目を選択 - [前へ 8 9 10 11 12 '13' 14 15 16 17 18 次へ]
         *     [21]Page目を選択 - [前へ 16 17 18 19 20 '21' 22]
         * 
         * {PageRange-fillLimit}
         * 前後nページだけを表示するが、固定数表示とする。
         * 端の方のページが選択されている場合で表示していないページ数の分、反対側のページを表示する。
         * デザインが崩れにくいという特徴あり。
         *   ex) 総ページ数が「22」の場合で、前後「5」ページを表示で固定数表示
         *     [4]Page目を選択  - [1 2 3 '4' 5 6 7 8 9 10 11 次へ]
         *     [13]Page目を選択 - [前へ 8 9 10 11 12 '13' 14 15 16 17 18 次へ]
         *     [21]Page目を選択 - [前へ 12 13 14 15 16 17 18 19 20 '21' 22]
         * 
         * {PageGroup}
         * まとまったページ数で一つグループとみなして表示する。
         * そのグループ内のどのページが選択されても表示は変わらない。
         *   ex) 総ページ数が「22」の場合で、「10」ページで一つのグループ
         *     [4]Page目を選択  - [1 2 3 '4' 5 6 7 8 9 10 11 次へ]
         *     [13]Page目を選択 - [前へ 11 12 '13' 14 15 16 17 18 19 20 次へ]
         *     [21]Page目を選択 - [前へ '21' 22]
         * </pre>
         * @since 0.7.6
         */
        [MbUnit.Framework.Test, Quill(Tx.Rollback)]
        public void SelectPage_PageRangeOption_PageGroupOption() {
            // ## Arrange ##
            MemberCB cb = new MemberCB();
            cb.Query().AddOrderBy_MemberName_Asc();

            // ## Act ##
            cb.Paging(4, 2);
            PagingResultBean<Member> page2 = _memberBhv.SelectPage(cb);
            cb.Paging(4, 3);
            PagingResultBean<Member> page3 = _memberBhv.SelectPage(cb);

            // ## Assert ##
            assertNotSame(0, page3.Count);

            log("{PageRange}");
            {
                PageRangeOption pageRangeOption = new PageRangeOption();
                pageRangeOption.PageRangeSize = 2;
                page2.PageRangeOption = pageRangeOption;
                {
                    bool existsPre = page2.PageRange().IsExistPrePageRange();
                    bool existsNext = page2.PageRange().IsExistNextPageRange();
                    log("    page2: " + existsPre + " " + toString(page2.PageRange().CreatePageNumberList()) + " " + existsNext);
                }
                page3.PageRangeOption = pageRangeOption;
                {
                    bool existsPre = page3.PageRange().IsExistPrePageRange();
                    bool existsNext = page3.PageRange().IsExistNextPageRange();
                    log("    page3: " + existsPre + " " + toString(page3.PageRange().CreatePageNumberList()) + " " + existsNext);
                }
                log("PagingResultBean.toString():" + getLineSeparator() + " " + page2 + getLineSeparator() + " " + page3);
                log("");
            }
            log("{PageRange-fillLimit}");
            {
                PageRangeOption pageRangeOption = new PageRangeOption();
                pageRangeOption.PageRangeSize = 2;
                pageRangeOption.IsFillLimit = true;
                page2.PageRangeOption = pageRangeOption;
                {
                    bool existsPre = page2.PageRange().IsExistPrePageRange();
                    bool existsNext = page2.PageRange().IsExistNextPageRange();
                    log("    page2: " + existsPre + " " + toString(page2.PageRange().CreatePageNumberList()) + " " + existsNext);
                }
                page3.PageRangeOption = pageRangeOption;
                {
                    bool existsPre = page3.PageRange().IsExistPrePageRange();
                    bool existsNext = page3.PageRange().IsExistNextPageRange();
                    log("    page3: " + existsPre + " " + toString(page3.PageRange().CreatePageNumberList()) + " " + existsNext);
                }
                log("PagingResultBean.toString():" + getLineSeparator() + " " + page2 + getLineSeparator() + " " + page3);
                log("");
            }
            log("{PageGroup}");
            {
                PageGroupOption pageGroupOption = new PageGroupOption();
                pageGroupOption.PageGroupSize = 2;
                page2.PageGroupOption = pageGroupOption;
                {
                    bool existsPre = page2.PageGroup().IsExistPrePageGroup();
                    bool existsNext = page2.PageGroup().IsExistNextPageGroup();
                    log("    page2: " + existsPre + " " + toString(page2.PageGroup().CreatePageNumberList()) + " " + existsNext);
                }
                page3.PageGroupOption = pageGroupOption;
                {
                    bool existsPre = page3.PageGroup().IsExistPrePageGroup();
                    bool existsNext = page3.PageGroup().IsExistNextPageGroup();
                    log("    page3: " + existsPre + " " + toString(page3.PageGroup().CreatePageNumberList()) + " " + existsNext);
                }
                log("PagingResultBean.toString():" + getLineSeparator() + " " + page2 + getLineSeparator() + " " + page3);
                log("");
            }

            // [Description]
            // A. 必ずsetPageRangeOption()でOptionを設定してからpageRange()を呼び出すこと。
            //    設定する前にpageRange()を呼び出すと例外発生。
            //    (他のOption(PageGroupなど)も同様)
            // 
            // B. PageRangeとPageGroupは独立した機能である。
            //    --> Rangeを使っているときに間違ってGroupのメソッドを呼び出したりしないように注意
        }

        // ===============================================================================
        //                                                                   Load Referrer
        //                                                                   =============
        /**
         * one-to-many-to-one(子テーブルの親テーブル)の取得: loadXxxList().
         * 検索した会員リストに対して、会員毎の購入カウントが２件以上の購入リストを購入カウントの降順でロード。
         * その時、購入から辿って商品(子テーブルの親テーブル)も取得。
         */
        [MbUnit.Framework.Test, Quill(Tx.Rollback)]
        public void LoadReferrer_SetupSelect_Foreign() {
            // ## Arrange ##
            MemberCB cb = new MemberCB();
            ListResultBean<Member> memberList = _memberBhv.SelectList(cb);

            // ## Act ##
            _memberBhv.LoadPurchaseList(memberList, delegate(PurchaseCB subCB) {
                subCB.SetupSelect_Product();// *Point!
                subCB.Query().AddOrderBy_PurchaseCount_Desc();
            });

            // ## Assert ##
            assertNotSame(0, memberList.Count);
            foreach (Member member in memberList) {
                IList<Purchase> purchaseList = member.PurchaseList;
                log("[MEMBER]: " + member.MemberName);
                foreach (Purchase purchase in purchaseList) {
                    long? purchaseId = purchase.PurchaseId;
                    Product product = purchase.Product;// *Point!
                    log("    [PURCHASE]: purchaseId=" + purchaseId + ", product=" + product);
                    assertNotNull(product);
                }
            }
        }
        
        /**
         * one-to-many-to-many(子テーブルの子テーブル(孫テーブル))の取得: loadXxxList().
         * この例題は「会員ステータス」を基点テーブルとする。
         */
        [MbUnit.Framework.Test, Quill(Tx.Rollback)]
        public void LoadReferrer_LoadReferrerReferrer() {
            // ## Arrange ##
            // A base table is MemberStatus at this test case.
            MemberStatusCB cb = new MemberStatusCB();
            ListResultBean<MemberStatus> memberStatusList = _memberStatusBhv.SelectList(cb);

            LoadReferrerOption<MemberCB, Member> loadReferrerOption = new LoadReferrerOption<MemberCB, Member>();

            // Member
            loadReferrerOption.ConditionBeanSetupper = delegate(MemberCB subCB) {
                subCB.Query().AddOrderBy_FormalizedDatetime_Desc();
            };

            // Purchase
            loadReferrerOption.EntityListSetupper = delegate(IList<Member> entityList) {
                _memberBhv.LoadPurchaseList(entityList, delegate(PurchaseCB subCB) {
                    subCB.Query().AddOrderBy_PurchaseCount_Desc();
                    subCB.Query().AddOrderBy_ProductId_Desc();
                });
            };

            // ## Act ##
            _memberStatusBhv.LoadMemberList(memberStatusList, loadReferrerOption);

            // ## Assert ##
            bool existsPurchase = false;
            assertNotSame(0, memberStatusList.Count);
            foreach (MemberStatus memberStatus in memberStatusList) {
                IList<Member> memberList = memberStatus.MemberList;
                log("[MEMBER_STATUS]: " + memberStatus.MemberStatusName);
                foreach (Member member in memberList) {
                    IList<Purchase> purchaseList = member.PurchaseList;
                    log("    [MEMBER]: " + member.MemberName + ", " + member.FormalizedDatetime);
                    foreach (Purchase purchase in purchaseList) {
                        log("        [PURCHASE]: " + purchase.PurchaseId + ", " + purchase.PurchaseCount);
                        existsPurchase = true;
                    }
                }
                log("");
            }
            assertTrue(existsPurchase);
        }

        
        /**
         * many-to-one-to-many(親テーブルの子テーブル(兄弟テーブル))の取得: pulloutXxx(), loadXxxList().
         * この例題は「購入」を基点テーブルとする。
         * 「購入」の親テーブル「会員」の子テーブル「会員ログイン」を取得する。
         * 「会員ログイン」はモバイルフラグがtrueで絞り込んでログイン日時の降順で並べる。
         */
        [MbUnit.Framework.Test, Quill(Tx.Rollback)]
        public void LoadReferrer_PulloutMember_LoadMemberLoginList() {
            // ## Arrange ##
            PurchaseCB cb = new PurchaseCB();
            cb.SetupSelect_Member();// *Point!
            ListResultBean<Purchase> purchaseList = _purchaseBhv.SelectList(cb);

            // ## Act ##
            IList<Member> memberList = _purchaseBhv.PulloutMember(purchaseList);// *Point!
            _memberBhv.LoadMemberLoginList(memberList, delegate(MemberLoginCB subCB) {
                subCB.Query().SetMobileLoginFlg_Equal_True();
                subCB.Query().AddOrderBy_LoginDatetime_Desc();
            });

            // ## Assert ##
            foreach (Purchase purchase in purchaseList) {
                Member member = purchase.Member;
                log("[PURCHASE & MEMBER]: " + purchase.PurchaseId + ", " + member.MemberName);
                IList<MemberLogin> memberLoginList = member.MemberLoginList;
                foreach (MemberLogin memberLogin in memberLoginList) {
                    log("    [MEMBER_LOGIN]: " + memberLogin.ToString());
                }
            }

            // [Description]
            // A. pulloutMember()で関連づいてる親テーブルのリストを取得。
            //    - for文で回って取り出しているだけである。
            //    - setupSelect_Xxx()し忘れると空のリストが戻る。
        }

        [MbUnit.Framework.Test, Quill(Tx.Rollback)]
        public void LoadReferrer_ousdieSql_paging() {
            // ## Arrange ##
            String path = MemberBhv.PATH_selectUnpaidSummaryMember;
            UnpaidSummaryMemberPmb pmb = new UnpaidSummaryMemberPmb();
            pmb.Paging(8, 2);

            PagingResultBean<UnpaidSummaryMember> memberPage = _memberBhv.OutsideSql().AutoPaging().SelectPage<UnpaidSummaryMember>(path, pmb);
            IList<Member> domainList = new List<Member>();
            foreach (UnpaidSummaryMember member in memberPage) {
                domainList.Add(member.PrepareDomain());
            }

            // ## Act ##
            _memberBhv.LoadPurchaseList(domainList, delegate(PurchaseCB cb) {
                cb.SetupSelect_Product();
                cb.Query().SetPaymentCompleteFlg_Equal_True();
            });

            // ## Assert ##
            bool exists = false;
            foreach (UnpaidSummaryMember member in memberPage) {
                IList<Purchase> purchaseList = member.PurchaseList;
                if (purchaseList.Count > 0) {
                    exists = true;
                }
                log(member.UnpaidManName + ", " + member.StatusName);
                foreach (Purchase purchase in purchaseList) {
                    log("  " + purchase);
                }
                assertTrue(member.MemberLoginList.Count == 0);
            }
            assertTrue(exists);
        }

        // ===============================================================================
        //                                                                    Batch Update
        //                                                                    ============

        // ===============================================================================
        //                                                                      OutsideSql
        //                                                                      ==========
        // -------------------------------------------------
        //                                              List
        //                                              ----
        // /- - - - - - - - - - - - - - - - - - - - - - - - - - -
        // 基本的なselectList()に関しては、BehaviorBasicTestにて
        // - - - - - - - - - -/
        // /- - - - - - - - - - - - - - - - - - - - - - - - - - -
        // 中級的なselectList()に関しては、BehaviorMiddleTestにて
        // - - - - - - - - - -/

        /**
         * 外だしSQLでBehaviorQueryPathのSubDirectory機能を利用: PATH_xxx_selectXxx.
         * exbhv配下の任意のSubDirectory(SubPackage)にSQLファイルを配置して利用することが可能。
         * SQLファイルの数があまりに膨大になる場合は、テーブルのカテゴリ毎にDirectoryを作成して、
         * 適度にSQLファイルをカテゴリ分けすると良い。
         */
        [MbUnit.Framework.Test, Quill(Tx.Rollback)]
        public void OutsideSql_SelectList_selectSubDirectory() {
            // ## Arrange ##
            // SQLのパス
            String path = MemberBhv.PATH_SubDirectory_selectSubDirectoryCheck;

            // 検索条件
            SimpleMemberPmb pmb = new SimpleMemberPmb();
            pmb.SetMemberName_PrefixSearch("S");

            // ## Act ##
            // SQL実行！
            IList<SimpleMember> resultList = _memberBhv.OutsideSql().SelectList<SimpleMember>(path, pmb);

            // ## Assert ##
            assertNotSame(0, resultList.Count);
            log("{SimpleMember}");
            foreach (SimpleMember entity in resultList) {
                int? memberId = entity.MemberId;
                String memberName = entity.MemberName;
                String memberStatusName = entity.MemberStatusName;
                log("    " + memberId + ", " + memberName + ", " + memberStatusName);
                assertNotNull(memberId);
                assertNotNull(memberName);
                assertNotNull(memberStatusName);
                assertTrue(memberName.StartsWith("S"));
            }
        }

        // -------------------------------------------------
        //                                            Cursor
        //                                            ------
        /**
         * 外だしSQLでカーソルの使った検索(大量件数対策): outsideSql().cursorHandling().selectCursor().
         * 実処理は、MemberBhv#makeCsvPurchaseSummaryMember()にて実装しているのでそちらを参照。
         * 
         * Entity定義にて以下のようにオプション「+cursor+」を付けることにより、タイプセーフカーソルが利用可能。
         * -- #PurchaseSummaryMember#
         * -- +cursor+
         */
        [MbUnit.Framework.Test, Quill(Tx.Rollback)]
        public void OutsideSql_SelectCursor_MakeCsvSummaryMember_selectPurchaseSummaryMember() {
            // ## Arrange ##
            // 検索条件
            PurchaseSummaryMemberPmb pmb = new PurchaseSummaryMemberPmb();
            pmb.SetMemberStatusCode_Formalized(); // 正式会員

            // ## Act & Assert ##
            _memberBhv.MakeCsvPurchaseSummaryMember(pmb);
            _memberBhv.MakeCsvPurchaseSummaryMember(pmb);
        }

        // -------------------------------------------------
        //                                  Statement Config
        //                                  ----------------
        /**
         * 外だしSQLでStatementのコンフィグを設定: outsideSql().configure(statementConfig).
         */
        [MbUnit.Framework.Test, Quill(Tx.Rollback)]
        public void OutsideSql_Configure() {
            // ## Arrange ##
            // SQLのパス
            String path = MemberBhv.PATH_selectSimpleMember;

            // 検索条件
            SimpleMemberPmb pmb = new SimpleMemberPmb();
            pmb.SetMemberName_PrefixSearch("S");

            // コンフィグ
            StatementConfig statementConfig = new StatementConfig().QueryTimeout(7);

            // ## Act & Assert ##
            try {
                // SQL実行！
                _memberBhv.OutsideSql().Configure(statementConfig).SelectList<SimpleMember>(path, pmb);
                // Connector/NETは6.2からCommandTimeoutに対応しているので
                // NotSupportedExceptionは発生しない
#if NET_4_0
#else
                fail();
#endif
            } catch (SQLFailureException e) {
                // OK
                // MySQLのデータプロバイダがCommandTimeoutをサポートしていないようである。
                log("msg=" + e.Message);
                assertTrue(e.InnerException is NotSupportedException);
            }
        }

                
        // -------------------------------------------------
        //                      ParameterBean ResolvePackage
        //                      ----------------------------
        /**
         * 外だしSQLでParameterBeanプロパティのPackage解決: '-- !!Date xxx!!'.
         * MemberBhv_selectResolvedPackageName.sqlを参照。
         */
        [MbUnit.Framework.Test, Quill(Tx.Rollback)]
        public void OutsideSql_SelectResolvedPackageName() {
            // ## Arrange ##
            // SQLのパス
            String path = MemberBhv.PATH_Various_PmbCheck_selectResolvedPackageName;

            // 検索条件
            ResolvedPackageNamePmb pmb = new ResolvedPackageNamePmb();
            pmb.Date1 = DateTime.Now; // java.util.Dateで検索できることを確認
            IList<String> statusList = new System.Collections.Generic.List<String>();
            statusList.Add(CDef.MemberStatus.Formalized.Code);
            statusList.Add(CDef.MemberStatus.Withdrawal.Code);
            pmb.List1 = statusList; // java.util.Listで検索できることを確認

            // ## Act ##ß
            // SQL実行！
            IList<Member> memberList = _memberBhv.OutsideSql().SelectList<Member>(path, pmb);

            // ## Assert ##
            assertNotSame(0, memberList.Count);

            // [Description]
            // A. ListやDateなど良く利用されるクラスのPackageを自動で解決する。
            //    そのためParameterBeanの宣言でパッケージ名を記述する必要はない。
            //    -- !BigDecimal bigDecimal1! *java.math.BigDecimal
            //    -- !Date bigDecimal1! *java.util.Date
            //    -- !Time bigDecimal1! *java.sql.Time
            //    -- !Timestamp bigDecimal1! *java.sql.Timestamp
            //    -- !List<String> list1! * java.util.List<>
            //    -- !Map<String, String> map1! * java.util.Map<>
        }

        // -------------------------------------------------
        //                                          NotFound
        //                                          --------
        /**
         * 外だしSQLでSQLファイルが見つからないときの挙動とメッセージ: OutsideSqlNotFoundException.
         * 専用メッセージは開発者がデバッグしやすいように。
         */
        [MbUnit.Framework.Test, Quill(Tx.Rollback)]
        public void OutsideSql_NotFound() {
            try {
                _memberBhv.OutsideSql().SelectList<Member>("sql/noexist/selectByNoExistSql.sql", null);
                fail();
            } catch (OutsideSqlNotFoundException e) {
                log(e.Message);
            }
        }

        // -------------------------------------------------
        //                                     Wrong Comment
        //                                     -------------
        /**
         * 外だしSQLで間違ったバインド変数コメントの場合の挙動と専用メッセージ: BindVariableCommentNotFoundPropertyException.
         * 専用メッセージは開発者がデバッグしやすいように。
         */
        [MbUnit.Framework.Test, Quill(Tx.Rollback)]
        public void OutsideSql_BindVariableNotFoundProperty() {
            try {
                String path = MemberBhv.PATH_Various_WrongExample_selectBindVariableNotFoundProperty;
                UnpaidSummaryMemberPmb pmb = new UnpaidSummaryMemberPmb();
                pmb.MemberName = "S";
                _memberBhv.OutsideSql().SelectList<Member>(path, pmb);
                fail();
            } catch (BindVariableCommentNotFoundPropertyException e) {
                log(e.Message);
                assertTrue(e.Message.Contains("wrongMemberId"));
            }
        }
        
        /**
         * 外だしSQLでBooleanでないIFコメントの場合の挙動と専用メッセージ: IfCommentNotBooleanResultException.
         * 専用メッセージは極力開発者がデバッグしやすいように。
         */
        [MbUnit.Framework.Test, Quill(Tx.Rollback)]
        public void OutsideSql_IfCommentNotBooleanResult() {
            try {
                String path = MemberBhv.PATH_Various_WrongExample_selectIfCommentNotBooleanResult;
                UnpaidSummaryMemberPmb pmb = new UnpaidSummaryMemberPmb();
                pmb.MemberName = "S";
                _memberBhv.OutsideSql().SelectList<Member>(path, pmb);
                fail();
            } catch (IfCommentNotBooleanResultException e) {
                log(e.Message);
            }
        }

        /**
         * 外だしSQLで間違ったIFコメントの場合の挙動と専用メッセージ: IfCommentWrongExpressionException.
         * 専用メッセージは極力開発者がデバッグしやすいように。
         */
        [MbUnit.Framework.Test, Quill(Tx.Rollback)]
        public void OutsideSql_IfCommentWrongExpression() {
            try {
                String path = MemberBhv.PATH_Various_WrongExample_selectIfCommentWrongExpression;
                UnpaidSummaryMemberPmb pmb = new UnpaidSummaryMemberPmb();
                pmb.MemberName = "S";
                _memberBhv.OutsideSql().SelectList<Member>(path, pmb);

                // C#版の場合「/*IF pmb.wrongMemberId != null*/」というような
                // 存在しないプロパティが指定されていてもfalseとして正常動作してしまう。
                // 外だしSQLでパラメータコメントを利用する際には注意が必要がある。
                // これは「JavaのOGNL」と「C#のJScript」の処理の違いによるものである。
                // fail();
            } catch (IfCommentWrongExpressionException e) {
                log(e.Message);
                throw;
                // if (!e.Message.Contains("wrongMemberId")) {
                //     fail();
                // }
            }
        }

        // ===============================================================================
        //                                                                   Common Column
        //                                                                   =============
        /**
         * 共通カラムの自動設定を無視して明示的に登録(or 更新): disableCommonColumnAutoSetup().
         */
        [MbUnit.Framework.Test, Quill(Tx.Rollback)]
        public void Insert_DisableCommonColumnAutoSetup() {
            // ## Arrange ##
            DateTime expectedTimestamp = new DateTime(2008, 7, 5, 16, 18, 46);
            Member member = new Member();
            member.MemberName = "Billy Joel";
            member.MemberAccount = "martinjoel";
            member.Birthdate = currentTimestamp();
            member.FormalizedDatetime = currentTimestamp();
            member.SetMemberStatusCode_Formalized();
            member.RegisterDatetime = expectedTimestamp;
            member.RegisterUser = "suppressRegisterUser";
            member.RegisterProcess = "suppressRegisterProcess";
            member.UpdateDatetime = expectedTimestamp;
            member.UpdateUser = "suppressUpdateUser";
            member.UpdateProcess = "suppressUpdateProcess";
            member.DisableCommonColumnAutoSetup();// *Point!

            // ## Act ##
            _memberBhv.Insert(member);

            // ## Assert ##
            MemberCB cb = new MemberCB();
            cb.Query().SetMemberId_Equal(member.MemberId);
            Member actualMember = _memberBhv.SelectEntityWithDeletedCheck(cb);
            DateTime? registerDatetime = actualMember.RegisterDatetime;
            String registerUser = actualMember.RegisterUser;
            String registerProcess = actualMember.RegisterProcess;
            DateTime? updateDatetime = actualMember.UpdateDatetime;
            String updateUser = actualMember.UpdateUser;
            String updateProcess = actualMember.UpdateProcess;
            log("registerDatetime = " + registerDatetime);
            assertNotNull(registerDatetime);
            assertEquals(expectedTimestamp, registerDatetime);
            log("registerUser = " + registerUser);
            assertNotNull(registerUser);
            assertEquals("suppressRegisterUser", registerUser);
            log("registerProcess = " + registerProcess);
            assertNotNull(registerProcess);
            assertEquals("suppressRegisterProcess", registerProcess);
            log("updateDatetime = " + updateDatetime);
            assertNotNull(updateDatetime);
            assertEquals(expectedTimestamp, updateDatetime);
            log("updateUser = " + updateUser);
            assertNotNull(updateUser);
            assertEquals("suppressUpdateUser", updateUser);
            log("updateProcess = " + updateProcess);
            assertNotNull(updateProcess);
            assertEquals("suppressUpdateProcess", updateProcess);
        }
            
        // ===============================================================================
        //                                                                Paging Re-Select
        //                                                                ================
        /**
         * ページングの超過ページ番号での検索時の再検索を無効化(ConditionBean): disablePagingReSelect().
         */
        [MbUnit.Framework.Test, Quill(Tx.Rollback)]
        public void ConditionBean_Paging_DisablePagingReSelect() {
            // ## Arrange ##
            MemberCB cb = new MemberCB();
            cb.Query().AddOrderBy_MemberName_Asc();
            cb.Paging(4, 99999);
            cb.DisablePagingReSelect();

            // ## Act ##
            PagingResultBean<Member> page99999 = _memberBhv.SelectPage(cb);

            // ## Assert ##
            assertTrue(page99999.Count == 0);
        }
        
        /**
         * ページングの超過ページ番号での検索時の再検索を無効化(OutsideSql): disablePagingReSelect().
         */
        [MbUnit.Framework.Test, Quill(Tx.Rollback)]
        public void OutsideSql_Paging_DisablePagingReSelect() {
            // ## Arrange ##
            // SQLのパス
            String path = MemberBhv.PATH_selectUnpaidSummaryMember;

            // 検索条件
            UnpaidSummaryMemberPmb pmb = new UnpaidSummaryMemberPmb();
            pmb.SetMemberStatusCode_Formalized();// 正式会員
            pmb.DisablePagingReSelect();

            // ## Act ##
            // SQL実行！
            int pageSize = 3;
            pmb.Paging(pageSize, 99999);
            PagingResultBean<UnpaidSummaryMember> page99999 = _memberBhv.OutsideSql().AutoPaging().SelectPage<UnpaidSummaryMember>(path, pmb);

            // ## Assert ##
            assertTrue(page99999.Count == 0);
        }
    
        // ===============================================================================
        //                                                                List Result Bean
        //                                                                ================
        /**
         * Entityリストの件数ごとのグルーピング: ListResultBean.groupingList().
         * 会員リストを３件ずつのグループリストにする。
         */
        [MbUnit.Framework.Test, Quill(Tx.Rollback)]
        public void SelectList_ListResultBean_GroupingList_count() {
            // ## Arrange ##
            MemberCB cb = new MemberCB();
            cb.Query().AddOrderBy_MemberName_Asc();
            ListResultBean<Member> memberList = _memberBhv.SelectList(cb);
            log("ListResultBean.toString():" + getLineSeparator() + " " + memberList);
            
            // ## Act ##
            GroupingOption<Member> groupingOption = new GroupingOption<Member>(3);
            IList<IList<Member>> groupingList = memberList.GroupingList<IList<Member>>(delegate(GroupingRowResource<Member> groupingRowResource) {
                return (IList<Member>)new List<Member>(groupingRowResource.GroupingRowList);
            }, groupingOption);
            
            // ## Assert ##
            assertTrue(groupingList.Count > 0);
            int rowIndex = 0;
            foreach (IList<Member> elementList in groupingList) {
                assertTrue(elementList.Count <= 3);
                log("[" + rowIndex + "]");
                foreach (Member member in elementList) {
                    log("  " + member);
                }
                ++rowIndex;
            }
        }
            
        /**
         * Entityリストのグルーピング(コントロールブレイク): ListResultBean.groupingList(), determine().
         * 会員リストを会員名称の先頭文字ごとのグループリストにする。
         * @since 0.8.2
         */
        [MbUnit.Framework.Test, Quill(Tx.Rollback)]
        public void SelectList_ListResultBean_GroupingList_determine() {
            // ## Arrange ##
            MemberCB cb = new MemberCB();
            cb.Query().AddOrderBy_MemberName_Asc();
            ListResultBean<Member> memberList = _memberBhv.SelectList(cb);
            log("ListResultBean.toString():" + getLineSeparator() + " " + memberList);

            // ## Act ##
            GroupingOption<Member> groupingOption = new GroupingOption<Member>(); // The breakCount is unnecessary in this case.
            groupingOption.GroupingRowEndDeterminer = delegate(GroupingRowResource<Member> rowResource, Member nextEntity) {
                Member currentEntity = rowResource.CurrentEntity;
                String currentInitChar = currentEntity.MemberName.Substring(0, 1);
                String nextInitChar = nextEntity.MemberName.Substring(0, 1);
                return !currentInitChar.ToLower().Equals(nextInitChar.ToLower());
            };
            IList<IList<Member>> groupingList = memberList.GroupingList<IList<Member>>(delegate(GroupingRowResource<Member> groupingRowResource) {
                return (IList<Member>)new List<Member>(groupingRowResource.GroupingRowList);
            }, groupingOption);
            
            // ## Assert ##
            assertTrue(groupingList.Count > 0);
            int entityCount = 0;
            foreach (IList<Member> elementList in groupingList) {
                String currentInitChar = null;
                foreach (Member member in elementList) {
                    if (currentInitChar == null) {
                        currentInitChar = member.MemberName.Substring(0, 1);
                        log("[" + currentInitChar + "]");
                    }
                    log("  " + member.MemberName + ", " + member);
                    assertEquals(currentInitChar, member.MemberName.Substring(0, 1));
                    ++entityCount;
                }
            }
            assertEquals(memberList.Count, entityCount);
        }
    }
}
