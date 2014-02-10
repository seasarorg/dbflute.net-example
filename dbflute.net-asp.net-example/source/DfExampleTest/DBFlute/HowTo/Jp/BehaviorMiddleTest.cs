using System;
using System.Collections;
using System.Collections.Generic;
using DfExample.DBFlute.AllCommon.CBean;
using DfExample.DBFlute.AllCommon.CBean.COption;
using DfExample.DBFlute.AllCommon.Exp;
using DfExample.DBFlute.CBean;
using DfExample.DBFlute.ExBhv;
using DfExample.DBFlute.ExDao.PmBean;
using DfExample.DBFlute.ExEntity;
using DfExample.DBFlute.ExEntity.Customize;
using Seasar.Extension.Unit;
using Seasar.Quill.Unit;

namespace DfExample.DBFlute.HowTo.Jp {

    /// <summary>
    /// Behaviorの中級編Example実装。
    /// 
    /// ターゲットは以下の通り：
    ///   o DBFluteってどういう機能があるのかを探っている方
    ///   o DBFluteで実装を開始する方・実装している方
    ///   
    /// コンテンツは以下の通り：
    ///   o ページング検索: selectPage().
    ///   o one-to-many検索(LoadReferrer): loadXxxList().
    ///   o 一件登録もしくは排他制御ありの一件更新: insertOrUpdate().
    ///   o 一件登録もしくは排他制御なし一件更新: insertOrUpdateNonstrict().
    ///   o Queryを使った更新: queryUpdate().
    ///   o Queryを使った削除: queryDelete().
    ///   o 外だしSQLでカラム一つだけのリスト検索: outsideSql().selectList().
    ///   o 外だしSQLでエスケープ付き曖昧検索のリスト検索: outsideSql().selectList().
    ///   o 外だしSQLの自動ページング検索: OutsideSql().AutoPaging().SelectPage().
    ///   o 外だしSQLの手動ページング検索: outsideSql().manualPaging().selectPage().
    ///   o 外だしSQLで一件検索: outsideSql().entitnHandling().selectEntity().
    ///   o 外だしSQLでチェック付き一件検索: outsideSql().entitnHandling().selectEntityWithDeletedCheck().
    ///   o 外だしSQLでカラム一つだけの一件検索: outsideSql().entitnHandling().selectEntity().
    /// </summary>
    [MbUnit.Framework.TestFixture]
    public class BehaviorMiddleTest : ContainerTestCase {

        // ===============================================================================
        //                                                                       Attribute
        //                                                                       =========
        protected MemberBhv _memberBhv;

        // ===============================================================================
        //                                                                     Page Select
        //                                                                     ===========
        /**
         * ページング検索: selectPage().
         * 会員名称の昇順のリストを「１ページ４件」の「３ページ目」(９件目から１２件目)を検索。
         * <pre>
         * ConditionBean.paging(pageSize, pageNumber)にてページング条件を指定：
         *   o pageSize : ページサイズ(１ページあたりのレコード数)
         *   o pageNumber : ページ番号(検索する対象のページ)
         * 
         * selectPage()だけでページングの基本が全て実行される：
         *   1. ページングなし件数取得
         *   2. ページング実データ検索
         *   3. ページング結果計算処理
         * 
         * PagingResultBeanから様々な要素が取得可能：
         *   o ページングなし総件数
         *   o 現在ページ番号
         *   o 総ページ数
         *   o 前ページの有無判定
         *   o 次ページの有無判定
         *   o ページングナビゲーション要素 ※詳しくはBehaviorPlatinumTestにて
         *   o などなど
         * </pre>
         */
        [MbUnit.Framework.Test, Quill(Tx.Rollback)]
        public void SelectPage() {
            // ## Arrange ##
            MemberCB cb = new MemberCB();
            cb.Query().AddOrderBy_MemberName_Asc();
            cb.Paging(4, 3);// The page size is 4 records per 1 page, and The page number is 3.

            // ## Act ##
            PagingResultBean<Member> page3 = _memberBhv.SelectPage(cb);

            // ## Assert ##
            assertNotSame(0, page3.Count);
            foreach (Member member in page3) {
                log(member.ToString());
            }
            log("allRecordCount=" + page3.AllRecordCount);
            log("allPageCount=" + page3.AllPageCount);
            log("currentPageNumber=" + page3.CurrentPageNumber);
            log("currentStartRecordNumber=" + page3.CurrentStartRecordNumber);
            log("currentEndRecordNumber=" + page3.CurrentEndRecordNumber);
            log("isExistPrePage=" + page3.IsExistPrePage());
            log("isExistNextPage=" + page3.IsExistNextPage());

            // [Description]
            // A. paging()メソッドはDBFlute-0.7.3よりサポート。
            //    DBFlute-0.7.2までは以下の通り：
            //      fetchFirst(4);
            //      fetchPage(3);
            // 
            // B. paging()メソッド第一引数のpageSizeは、マイナス値や０が指定されると例外発生
            //    --> 基本的にシステムで固定で指定する値であるため
            // 
            // C. paging()メソッド第二引数のpageNumberは、マイナス値や０を指定されると「１ページ目」として扱われる。
            //    --> 基本的に画面リクエストの値で、予期せぬ数値が来る可能性があるため。
            // 
            //    ※関連して、総ページ数を超えるページ番号が指定された場合は「最後のページ」として扱われる。
            //     (但し、ここは厳密にはpaging()の機能ではなくselectPage()の機能である)
        }

        // ===============================================================================
        //                                                                   Load Referrer
        //                                                                   =============
        /**
         * one-to-many検索(LoadReferrer): loadXxxList().
         * 検索した会員リストに対して、会員毎の購入カウントが２件以上の購入リストを購入カウントの降順でロード。
         * 子テーブル(Referrer)を取得する「一発」のSQLを発行してマッピングをする(SubSelectフェッチ)。
         * DBFluteではこのone-to-manyをロードする機能を「LoadReferrer」と呼ぶ。
         */
        [MbUnit.Framework.Test, Quill(Tx.Rollback)]
        public void LoadReferrer() {
            // ## Arrange ##
            MemberCB cb = new MemberCB();

            // At first, it selects the list of Member.
            ListResultBean<Member> memberList = _memberBhv.SelectList(cb);

            // ## Act ##
            // And it loads the list of Purchase with its conditions.
            _memberBhv.LoadPurchaseList(memberList, delegate(PurchaseCB subCB) {
                subCB.Query().SetPurchaseCount_GreaterEqual(2);
                subCB.Query().AddOrderBy_PurchaseCount_Desc();
            });

            // ## Assert ##
            assertNotSame(0, memberList.Count);
            foreach (Member member in memberList) {
                log("[MEMBER]: " + member.MemberName);
                IList<Purchase> purchaseList = member.PurchaseList;// *Point!
                foreach (Purchase purchase in purchaseList) {
                    log("    [PURCHASE]: " + purchase.ToString());
                }
            }

            // [SQL]
            // {1}: memberBhv.selectList(cb);
            // select ... 
            //   from MEMBER dflocal
            // 
            // {2}: memberBhv.loadPurchaseList(memberList, ...); 
            // select ... 
            //   from PURCHASE dflocal 
            //  where dflocal.MEMBER_ID in (1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20)
            //    and dflocal.PURCHASE_COUNT >= 2 
            //  order by dflocal.MEMBER_ID asc, dflocal.PURCHASE_COUNT desc

            // [Description]
            // A. 基点テーブルが複合PKの場合はサポートされない。
            //    --> このExampleでは会員テーブル。もし複合PKならloadPurchaseList()メソッド自体が生成されない。
            // B. SubSelectフェッチなので「n+1問題」は発生しない。
            // C. 枝分かれの子テーブルを取得することも可能。
            // D. 子テーブルの親テーブルを取得することも可能。詳しくはBehaviorPlatinumTestにて
            // E. 子テーブルの子テーブル(孫テーブル)を取得することも可能。詳しくはBehaviorPlatinumTestにて
        }

        // ===================================================================================
        //                                                                       Entity Update
        //                                                                       =============
        // -----------------------------------------------------
        //                                        InsertOrUpdate
        //                                        --------------
        /// <summary>
        /// 一件登録もしくは排他制御ありの一件更新: insertOrUpdate().
        /// @since 0.8.0
        /// </summary>
        [MbUnit.Framework.Test, Quill(Tx.Rollback)]
        public void InsertOrUpdate() {
            // ## Arrange ##
            Member member = new Member();
            member.MemberName = "testName";
            member.MemberAccount = "testAccount";
            member.SetMemberStatusCode_Formalized();

            // ## Act ##
            _memberBhv.InsertOrUpdate(member);
            member.MemberName = "testName2";
            _memberBhv.InsertOrUpdate(member);

            // ## Assert ##
            MemberCB cb = new MemberCB();
            cb.Query().SetMemberId_Equal(member.MemberId);
            Member actual = _memberBhv.SelectEntityWithDeletedCheck(cb);
            log(actual);
            assertEquals("testName2", actual.MemberName);

            // [Description]
            // A. 登録処理はinsert()、更新処理はupdate()に委譲する。
            // B. PKの値が存在しない場合は、自動採番と判断し問答無用で登録処理となる。
            // C. PK値が存在する場合は、先に更新処理をしてから結果を判断して登録処理をする。
        }

        /// <summary>
        /// 一件登録もしくは排他制御なし一件更新: insertOrUpdateNonstrict().
        /// @since 0.8.0
        /// </summary>
        [MbUnit.Framework.Test, Quill(Tx.Rollback)]
        public void InsertOrUpdateNonstrict() {
            // ## Arrange ##
            Member member = new Member();
            member.MemberName = "testName";
            member.MemberAccount = "testAccount";
            member.SetMemberStatusCode_Formalized();

            // ## Act ##
            _memberBhv.InsertOrUpdateNonstrict(member);
            member.MemberName = "testName2";
            member.VersionNo = null; // *Point
            _memberBhv.InsertOrUpdateNonstrict(member);

            // ## Assert ##
            MemberCB cb = new MemberCB();
            cb.Query().SetMemberId_Equal(member.MemberId);
            Member actual = _memberBhv.SelectEntityWithDeletedCheck(cb);
            log(actual);
            assertEquals("testName2", actual.MemberName);

            // [Description]
            // A. 登録処理はinsert()、更新処理はupdateNonstrict()に委譲する。
            // B. PKの値が存在しない場合は、自動採番と判断し問答無用で登録処理となる。
            // C. PK値が存在する場合は、先に更新処理をしてから結果を判断して登録処理をする。
        }

        // ===============================================================================
        //                                                                    Query Update
        //                                                                    ============
        /// <summary>
        /// Queryを使った更新: queryUpdate().
        /// 会員ステータスが正式会員の会員を全て仮会員にする。
        /// ConditionBeanで設定した条件で一括削除が可能である。(排他制御はない)
        /// @since 0.7.9
        /// </summary>
        [MbUnit.Framework.Test, Quill(Tx.Rollback)]
        public void QueryUpdate() {
            // ## Arrange ##
            deleteMemberReferrers();// for Test

            Member member = new Member();
            member.SetMemberStatusCode_Provisional();// 会員ステータスを「仮会員」に
            member.FormalizedDatetime = null;// 正式会員日時を「null」に

            MemberCB cb = new MemberCB();
            cb.Query().SetMemberStatusCode_Equal_Formalized();// 正式会員

            // ## Act ##
            int updatedCount = _memberBhv.QueryUpdate(member, cb);

            // ## Assert ##
            assertNotSame(0, updatedCount);
            MemberCB actualCB = new MemberCB();
            actualCB.Query().SetMemberStatusCode_Equal_Provisional();
            actualCB.Query().SetFormalizedDatetime_IsNull();
            actualCB.Query().SetUpdateUser_Equal(_accessUser);// Common Column
            ListResultBean<Member> actualList = _memberBhv.SelectList(actualCB);
            assertEquals(actualList.Count, updatedCount);

            // [Description]
            // A. 条件として、結合先のカラムによる条件やexists句を使ったサブクエリーなども利用可能。
            // B. setupSelect_Xxx()やaddOrderBy_Xxx()を呼び出しても意味はない。
            // C. 排他制御はせずに問答無用で更新する。(バージョンNOは自動インクリメント)
            // D. 更新結果が0件でも特に例外は発生しない。
            // E. 共通カラム(CommonColumn)の自動設定は有効。
        }

        /// <summary>
        /// Queryを使った削除: queryDelete().
        /// 会員ステータスが正式会員の会員を全て削除する。
        /// ConditionBeanで設定した条件で一括削除が可能である。(排他制御はない)
        /// @since 0.7.9
        /// </summary>
        [MbUnit.Framework.Test, Quill(Tx.Rollback)]
        public void QueryDelete() {
            // ## Arrange ##
            deleteMemberReferrers();// for Test

            MemberCB cb = new MemberCB();
            cb.Query().SetMemberStatusCode_Equal_Formalized();// 正式会員

            // ## Act ##
            int deletedCount = _memberBhv.QueryDelete(cb);

            // ## Assert ##
            assertNotSame(0, deletedCount);
            assertEquals(0, _memberBhv.SelectCount(cb));

            // [Description]
            // A. 条件として、結合先のカラムによる条件やexists句を使ったサブクエリーなども利用可能。
            // B. setupSelect_Xxx()やaddOrderBy_Xxx()を呼び出しても意味はない。
            // C. 排他制御はせずに問答無用で削除する。
            // D. 削除結果が0件でも特に例外は発生しない。
        }

        // ===============================================================================
        //                                                                      OutsideSql
        //                                                                      ==========
        // -------------------------------------------------
        //                                              List
        //                                              ----
        // /- - - - - - - - - - - - - - - - - - - - - - - - - - -
        // 基本的なselectList()に関しては、BehaviorBasicTestにて
        // - - - - - - - - - -/
        /**
         * 外だしSQLでカラム一つだけのリスト検索: outsideSql().selectList().
         */
        [MbUnit.Framework.Test, Quill(Tx.Rollback)]
        public void OutsideSql_SelectList_selectMemberName() {
            // ## Arrange ##
            // SQLのパス
            String path = MemberBhv.PATH_selectMemberName;

            // 検索条件
            SimpleMemberPmb pmb = new SimpleMemberPmb();
            pmb.MemberName = "S";

            // ## Act ##
            // SQL実行！
            IList<String> memberNameList = _memberBhv.OutsideSql().SelectList<String>(path, pmb);

            // ## Assert ##
            assertNotSame(0, memberNameList.Count);
            log("{MemberName}");
            foreach (String memberName in memberNameList) {
                log("    " + memberName);
                assertNotNull(memberName);
                assertTrue(memberName.StartsWith("S"));
            }
        }

        // -------------------------------------------------
        //                                            Option
        //                                            ------
        /**
         * 外だしSQLでエスケープ付き曖昧検索のリスト検索: outsideSql().selectList().
         * <pre>
         * ParameterBeanの定義にて、以下のようにオプション「:like」を付与すると利用可能になる。
         * -- !OptionMemberPmb!
         * -- !!Integer memberId!!
         * -- !!String memberName:like!!
         * </pre>
         * @since 0.8.0
         */
        [MbUnit.Framework.Test, Quill(Tx.Rollback)]
        public void OutsideSql_SelectList_selectOptionMember_LikeSearchOption_Tx() {
            // ## Arrange ##
            // テストのためにワイルドカード含みのテスト会員を作成
            Member testMember1 = new Member();
            testMember1.MemberId = 1;
            testMember1.MemberName = "ストイコ100%ビッチ_その１";
            _memberBhv.UpdateNonstrict(testMember1);
            Member testMember4 = new Member();
            testMember4.MemberId = 4;
            testMember4.MemberName = "ストイコ100%ビッチ_その４";
            _memberBhv.UpdateNonstrict(testMember4);

            // SQLのパス
            String path = MemberBhv.PATH_selectOptionMember;

            // 検索条件
            OptionMemberPmb pmb = new OptionMemberPmb();
            pmb.SetMemberName("ストイコ100%ビッチ_その", new LikeSearchOption().LikePrefix().EscapeByPipeLine());

            // ## Act ##
            // SQL実行！
            IList<OptionMember> memberList = _memberBhv.OutsideSql().SelectList<OptionMember>(path, pmb);

            // ## Assert ##
            assertNotSame(0, memberList.Count);
            log("{OptionMember}");
            foreach (OptionMember member in memberList) {
                long? memberId = member.MemberId;
                String memberName = member.MemberName;
                String memberStatusName = member.MemberStatusName;
                log("    " + memberId + ", " + memberName + ", " + memberStatusName + " - Formalized=");
                // TODO: @jflute -- Sql2Entity's IsMemberStatusCodeFormalized!?
                //         + member.IsMemberStatusCodeFormalized);// Sql2EntityでもClassification機能が利用可能
                assertNotNull(memberId);
                assertNotNull(memberName);
                assertNotNull(memberStatusName);
                assertTrue(memberName.StartsWith("ストイコ100%ビッチ_その"));
            }

            // [Description]
            // A. 外だしSQLにおいては、LikeSearchOptionはlikeXxx()とescapeByXxx()のみ利用可能。
            // B. CustomizeEntity(Sql2Entityで生成したEntity)でも区分値機能は利用可能。
        }

        // -------------------------------------------------
        //                                            Paging
        //                                            ------
        /// <summary>
        /// 外だしSQLの自動ページング検索: OutsideSql().AutoPaging().SelectPage().
        /// ParameterBean.Paging(pageSize, pageNumber)にてページング条件を指定：
        ///   o pageSize : ページサイズ(１ページあたりのレコード数)
        ///   o pageNumber : ページ番号(検索する対象のページ)
        /// 
        ///   ※SQL上のParameterBeanの定義にて、以下のようにSimplePagingBeanを継承すること。
        ///      -- !XxxPmb extends SPB!
        /// 
        /// SelectPage()だけでページングの基本が全て実行される：
        ///   1. ページングなし件数取得
        ///   2. ページング実データ検索
        ///   3. ページング結果計算処理
        ///   
        /// PagingResultBeanから様々な要素が取得可能：
        ///   o ページングなし総件数
        ///   o 現在ページ番号
        ///   o 総ページ数
        ///   o 前ページの有無判定
        ///   o 次ページの有無判定
        ///   o ページングナビゲーション要素ページリスト
        ///   o などなど
        /// </summary>
        [MbUnit.Framework.Test, Quill(Tx.Rollback)]
        public void OutsideSql_AutoPaging_SelectPage() {
            // ## Arrange ##
            // SQLのパス
            String path = MemberBhv.PATH_selectUnpaidSummaryMember;

            // 検索条件
            UnpaidSummaryMemberPmb pmb = new UnpaidSummaryMemberPmb();
            pmb.SetMemberStatusCode_Formalized();// 正式会員

            // ## Act ##
            // SQL実行！
            int pageSize = 3;
            pmb.Paging(pageSize, 1);// 1st page
            PagingResultBean<UnpaidSummaryMember> page1 = _memberBhv.OutsideSql().AutoPaging().SelectPage<UnpaidSummaryMember>(path, pmb);

            pmb.Paging(pageSize, 2);// 2st page
            PagingResultBean<UnpaidSummaryMember> page2 = _memberBhv.OutsideSql().AutoPaging().SelectPage<UnpaidSummaryMember>(path, pmb);

            pmb.Paging(pageSize, 3);// 3st page
            PagingResultBean<UnpaidSummaryMember> page3 = _memberBhv.OutsideSql().AutoPaging().SelectPage<UnpaidSummaryMember>(path, pmb);

            pmb.Paging(pageSize, page1.AllPageCount);// latest page
            PagingResultBean<UnpaidSummaryMember> lastPage = _memberBhv.OutsideSql().AutoPaging().SelectPage<UnpaidSummaryMember>(path, pmb);

            // ## Assert ##
            //showPage(page1, page2, page3, lastPage);
            assertEquals(3, page1.Count);
            assertEquals(3, page2.Count);
            assertEquals(3, page3.Count);
            assertNotSame(page1[0].MemberId, page2[0].MemberId);
            assertNotSame(page2[0].MemberId, page3[0].MemberId);
            assertEquals(1, page1.CurrentPageNumber);
            assertEquals(2, page2.CurrentPageNumber);
            assertEquals(3, page3.CurrentPageNumber);
            assertEquals(page1.AllRecordCount, page2.AllRecordCount);
            assertEquals(page2.AllRecordCount, page3.AllRecordCount);
            assertEquals(page1.AllPageCount, page2.AllPageCount);
            assertEquals(page2.AllPageCount, page3.AllPageCount);
            assertFalse(page1.IsExistPrePage());
            assertTrue(page1.IsExistNextPage());
            assertTrue(lastPage.IsExistPrePage());
            assertFalse(lastPage.IsExistNextPage());

            // [Description]
            // A. Paging()メソッドはDBFlute-0.7.3よりサポート。
            //    DBFlute-0.7.2までは以下の通り：
            //      pmb.FetchFirst(3);
            //      pmb.FetchPage(1);
            // 
            // B. 手動ページングをしたい場合は以下の通り。
            //   1. SQL上でページング絞り条件を記述
            //      /*IF pmb.IsPaging*/
            //      limit /*$pmb.PageStartIndex*/80, /*$pmb.FetchSize*/20
            //      /*END*/
            // 
            //   2. AutoPaging()をManualPaging()に変更
            //      memberBhv.OutsideSql().ManualPaging().SelectPage(...);
            // 
            // C. ParameterBeanでも区分値機能は利用可能 {上級編}
            //    : member.isMemberStatusCodeFormalized()
            // 
            //    ParameterBeanにて
            //    -- !!String memberStatusCode:cls(MemberStatus)!!
            //    と指定
        }

        /**
         * 外だしSQLの手動ページング検索: outsideSql().manualPaging().selectPage().
         * 最大購入価格の会員一覧を検索。
         * <pre>
         * ParameterBean.paging(pageSize, pageNumber)にてページング条件を指定：
         *   o pageSize : ページサイズ(１ページあたりのレコード数)
         *   o pageNumber : ページ番号(検索する対象のページ)
         *   
         *   ※SQL上のParameterBeanの定義にて、以下のようにSimplePagingBeanを継承すること。
         *      -- !XxxPmb extends SPB!
         * 
         * selectPage()だけでページングの基本が全て実行される：
         *   1. ページングなし件数取得
         *   2. ページング実データ検索
         *   3. ページング結果計算処理
         * 
         * PagingResultBeanから様々な要素が取得可能：
         *   o ページングなし総件数
         *   o 現在ページ番号
         *   o 総ページ数
         *   o 前ページの有無判定
         *   o 次ページの有無判定
         *   o ページングナビゲーション要素ページリスト
         *   o などなど
         * </pre>
         */
        [MbUnit.Framework.Test, Quill(Tx.Rollback)]
        public void OutsideSql_ManualPaging_SelectPage() {
            // ## Arrange ##
            // SQLのパス
            String path = MemberBhv.PATH_selectPurchaseMaxPriceMember;

            // 検索条件(絞り込み条件は特になし)
            PurchaseMaxPriceMemberPmb pmb = new PurchaseMaxPriceMemberPmb();

            // ## Act ##
            // SQL実行！
            int pageSize = 3;
            pmb.Paging(pageSize, 1); // 1st page
            PagingResultBean<PurchaseMaxPriceMember> page1 =
                _memberBhv.OutsideSql().ManualPaging().SelectPage<PurchaseMaxPriceMember>(path, pmb);

            pmb.Paging(pageSize, 2); // 2st page
            PagingResultBean<PurchaseMaxPriceMember> page2 =
                _memberBhv.OutsideSql().ManualPaging().SelectPage<PurchaseMaxPriceMember>(path, pmb);

            pmb.Paging(pageSize, 3); // 3st page
            PagingResultBean<PurchaseMaxPriceMember> page3 =
                _memberBhv.OutsideSql().ManualPaging().SelectPage<PurchaseMaxPriceMember>(path, pmb);

            pmb.Paging(pageSize, page1.AllPageCount); // latest page
            PagingResultBean<PurchaseMaxPriceMember> lastPage =
                _memberBhv.OutsideSql().ManualPaging().SelectPage<PurchaseMaxPriceMember>(path, pmb);

            // ## Assert ##
            //showPage(page1, page2, page3, lastPage);
            assertEquals(3, page1.Count);
            assertEquals(3, page2.Count);
            assertEquals(3, page3.Count);
            assertNotSame(page1[0].MemberId, page2[0].MemberId);
            assertNotSame(page2[0].MemberId, page3[0].MemberId);
            assertEquals(1, page1.CurrentPageNumber);
            assertEquals(2, page2.CurrentPageNumber);
            assertEquals(3, page3.CurrentPageNumber);
            assertEquals(page1.AllRecordCount, page2.AllRecordCount);
            assertEquals(page2.AllRecordCount, page3.AllRecordCount);
            assertEquals(page1.AllPageCount, page2.AllPageCount);
            assertEquals(page2.AllPageCount, page3.AllPageCount);
            assertFalse(page1.IsExistPrePage());
            assertTrue(page1.IsExistNextPage());
            assertTrue(lastPage.IsExistPrePage());
            assertFalse(lastPage.IsExistNextPage());

            // [Description]
            // A. paging()メソッドはDBFlute-0.7.3よりサポート。
            //    DBFlute-0.7.2までは以下の通り：
            //      pmb.fetchFirst(3);
            //      pmb.fetchPage(1);
            // 
            // B. 自動ページングをしたい場合は以下の通り。
            //   1. SQL上でページング絞り条件を削除
            //   2. manualPaging()をautoPaging()に変更
            // 
            // X. ConditionBeanと外だしSQLの境目ポイント！ {上級編}
            //    o ページング絞りをSQLで行うのはConditionBeanで可能
            //      --> ConditionBeanのページングはSQLでのページング絞りを実現
            // 
            //    o Select句の相関サブクエリで子テーブルのmax()はConditionBeanで可能
            //      --> SpecifyDerivedReferrerを利用(詳しくはConditionBeanPlatinumTestにて)
            // 
            //    o Select句の相関サブクエリで導出した値で並び替えるのはConditionBeanで可能
            //      --> SpecifyDerivedReferrerで利用(詳しくはConditionBeanPlatinumTestにて)
            // 
            //        ※実はこの例題のSQLはConditionBeanで実装可能
            //        /- - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - 
            //        MemberCB cb = new MemberCB();
            //        cb.setupSelect_MemberStatus();
            //        cb.specify().derivedPurchaseList().max(new SubQuery<PurchaseCB>() {
            //            public void query(PurchaseCB subCB) {
            //                subCB.specify().columnPurchasePrice();
            //                subCB.query().setPaymentCompleteFlg_Equal_False();
            //            }
            //        }, "PURCHASE_MAX_PRICE");
            //        cb.query().setMemberId_Equal(3);
            //        cb.query().setMemberName_PrefixSearch("S");
            //        cb.query().addSpecifiedDerivedOrderBy_Desc("PURCHASE_MAX_PRICE");
            //        cb.query().addOrderBy_MemberId_Asc();
            //        cb.paging(3, 1);
            //        PagingResultBean<Member> page = memberBhv.selectPage(cb);
            //        - - - - - - - - - -/
        }

        // -------------------------------------------------
        //                                            Entity
        //                                            ------
        /**
         * 外だしSQLで一件検索: outsideSql().entitnHandling().selectEntity().
         */
        [MbUnit.Framework.Test, Quill(Tx.Rollback)]
        public void OutsideSql_SelectEntity_selectUnpaidSummaryMember() {
            // ## Arrange ##
            // SQLのパス
            String path = MemberBhv.PATH_selectUnpaidSummaryMember;

            // 検索条件
            UnpaidSummaryMemberPmb pmb = new UnpaidSummaryMemberPmb();
            pmb.MemberId = 3;

            // ## Act ##
            UnpaidSummaryMember member = _memberBhv.OutsideSql().EntityHandling().SelectEntity<UnpaidSummaryMember>(path, pmb);

            // ## Assert ##
            log("unpaidSummaryMember=" + member);
            assertNotNull(member);
            assertEquals(3L, member.MemberId);

            // [Description]
            // A. 存在しないIDを指定した場合はnullが戻る。
            // B. 結果が複数件の場合は例外発生。{EntityDuplicatedException}
        }

        /**
         * 外だしSQLでチェック付き一件検索: outsideSql().entitnHandling().selectEntityWithDeletedCheck().
         */
        [MbUnit.Framework.Test, Quill(Tx.Rollback)]
        public void test_outsideSql_selectEntityWithDeletedCheck_selectUnpaidSummaryMember_Tx() {
            // ## Arrange ##
            // SQLのパス
            String path = MemberBhv.PATH_selectUnpaidSummaryMember;

            // 検索条件
            UnpaidSummaryMemberPmb pmb = new UnpaidSummaryMemberPmb();
            pmb.MemberId = 99999;

            // ## Act & Assert ##
            try {
                _memberBhv.OutsideSql().EntityHandling().SelectEntityWithDeletedCheck<UnpaidSummaryMember>(path, pmb);
                fail();
            } catch (EntityAlreadyDeletedException e) {
                // OK
                log(e.Message);
            }

            // 【Description】
            // A. 存在しないIDを指定した場合は例外発生。{EntityAlreadyDeletedException}
            // B. 結果が複数件の場合は例外発生。{EntityDuplicatedException}
        }


        /**
         * 外だしSQLでカラム一つだけの一件検索: outsideSql().entitnHandling().selectEntity().
         */
        [MbUnit.Framework.Test, Quill(Tx.Rollback)]
        public void test_outsideSql_SelectEntityWithDeletedCheck_selectLatestFormalizedDatetime_Tx() {
            // ## Arrange ##
            // SQLのパス
            String path = MemberBhv.PATH_selectLatestFormalizedDatetime;

            // 検索条件
            Object pmb = null;

            // ## Act ##
            DateTime? maxValue = _memberBhv.OutsideSql().EntityHandling().SelectEntity<DateTime?>(path, pmb);

            // ## Assert ##
            log("maxValue=" + maxValue);
            assertNotNull(maxValue);
        }
    }
}
