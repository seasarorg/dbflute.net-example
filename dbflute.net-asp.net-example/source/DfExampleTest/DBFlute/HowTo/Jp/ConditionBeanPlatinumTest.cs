using System;
using System.Collections.Generic;
using DfExample.DBFlute.AllCommon.Ado;
using DfExample.DBFlute.AllCommon.Bhv.Setup;
using DfExample.DBFlute.AllCommon.CBean.COption;
using DfExample.DBFlute.AllCommon.Exp;
using DfExample.DBFlute.AllCommon.Util;
using DfExample.DBFlute.ExBhv;
using DfExample.DBFlute.CBean;
using DfExample.DBFlute.ExEntity;
using DfExample.DBFlute.AllCommon.CBean;
using Seasar.Quill.Unit;
using Seasar.Extension.Unit;

namespace DfExample.DBFlute.HowTo.Jp {

    /// <summary>
    /// ConditionBeanの上級編Example実装。
    /// 
    /// ターゲットは以下の通り：
    ///   o DBFluteってどういう機能があるのかを探っている方
    ///   o DBFluteで実装を開始する方・実装している方
    ///   
    /// コンテンツは以下の通り：
    ///   x 空白区切りの連結曖昧検索(And条件): option.likeContain().splitBySpace().
    ///   x 空白区切りの連結曖昧検索(Or条件): option.likeContain().splitBySpace().asOrSplit().
    ///   o Exists句の中でUnion: existsXxxList(), union().
    ///   o nullを最初に並べる: addOrderBy_Xxx_Asc().withNullsFirst().
    ///   o nullを最後に並べる: addOrderBy_Xxx_Asc().withNullsLast().
    ///   o nullを最後に並べる(Unionと共演): addOrderBy_Xxx_Asc().withNullsLast(), union().
    ///   o Unionのループによる不定数設定: for { cb.union() }.
    ///   o Unionを使ったページング検索: union(), selectPage().
    ///   o OnClause(On句)に条件を追加: queryXxx().on().
    ///   o 取得カラムの指定(SpecifyColumn): Specify().ColumnXxx().
    ///   o 子テーブル導出カラムの指定(SpecifyDerivedReferrer)-Max: specify().derivedXxxList().max().
    ///   o 子テーブル導出カラムで並び替え(SpecifiedDerivedOrderBy)-Count: addSpecifiedDerivedOrderBy_Desc().
    ///   o Statementのコンフィグを設定: cb.configure(statementConfig).
    ///   o どんなにSubQueryやUnionの連打をしてもSQLが綺麗にフォーマット: toDisplaySql().
    /// </summary>
    [MbUnit.Framework.TestFixture]
    public class ConditionBeanPlatinumTest : ContainerTestCase {

        // ===============================================================================
        //                                                                       Attribute
        //                                                                       =========
        protected MemberBhv _memberBhv;
        protected MemberWithdrawalBhv _memberWithdrawalBhv;

        // ===============================================================================
        //                                                                           Query
        //                                                                           =====
        // -------------------------------------------------
        //                                        LikeSearch
        //                                        ----------

        // -------------------------------------------------
        //                                    ExistsSubQuery
        //                                    --------------
        /**
         * Exists句の中でUnion: existsXxxList(), union().
         * 商品名称に's'もしくは'a'が含まれる商品を購入したことのある会員を検索。
         */
        [MbUnit.Framework.Test, Quill(Tx.Rollback)]
        public void Query_Exists_Union() {
            MemberCB cb = new MemberCB();
            LikeSearchOption option = new LikeSearchOption().LikeContain();
            cb.Query().ExistsPurchaseList(delegate(PurchaseCB purchaseCB) {
                purchaseCB.Query().SetPurchaseCount_GreaterThan(2);
                purchaseCB.Union(delegate(PurchaseCB purchaseUnionCB) {
                    purchaseUnionCB.Query().QueryProduct().SetProductName_LikeSearch("s", option);
                });
                purchaseCB.Union(delegate(PurchaseCB purchaseUnionCB) {
                    purchaseUnionCB.Query().QueryProduct().SetProductName_LikeSearch("a", option);
                });
            });

            // ## Act ##
            ListResultBean<Member> memberList = _memberBhv.SelectList(cb);

            // ## Assert ##
            ConditionBeanSetupper<PurchaseCB> setuppper = delegate(PurchaseCB subCB) {
                subCB.SetupSelect_Product();
            };
            _memberBhv.LoadPurchaseList(memberList, setuppper);
            foreach (Member member in memberList) {
                log("[member] " + member.MemberId + ", " + member.MemberName);
                IList<Purchase> purchaseList = member.PurchaseList;
                bool existsPurchase = false;
                foreach (Purchase purchase in purchaseList) {
                    Product product = purchase.Product;
                    long? purchaseCount = purchase.PurchaseCount;
                    String productName = product.ProductName;
                    log("  [purchase] " + purchase.PurchaseId + ", " + purchaseCount + ", " + productName);
                    if (purchaseCount > 2 || productName.Contains("s") || productName.Contains("a")) {
                        existsPurchase = true;
                    }
                }
                assertTrue(existsPurchase);
            }
        }

        // -------------------------------------------------
        //                                  Nulls First/Last
        //                                  ----------------
        /**
         * nullを最初に並べる: addOrderBy_Xxx_Asc().withNullsFirst().
         * 生年月日の昇順でnullのものは最初に並べる。
         */
        [MbUnit.Framework.Test, Quill(Tx.Rollback)]
        public void Query_AddOrderBy_WithNullsFirst() {
            // ## Arrange ##
            MemberCB cb = new MemberCB();
            cb.Query().AddOrderBy_Birthdate_Asc().WithNullsFirst();

            // ## Act ##
            ListResultBean<Member> memberList = _memberBhv.SelectList(cb);

            // ## Assert ##
            bool nulls = true;
            bool border = false;
            foreach (Member member in memberList) {
                DateTime? birthday = member.Birthdate;
                log(member.MemberId + ", " + member.MemberName + ", " + birthday);
                if (nulls) {
                    if (birthday != null && !border) {
                        nulls = false;
                        border = true;
                        continue;
                    }
                    assertNull(birthday);
                } else {
                    assertNotNull(birthday);
                }
            }
            assertTrue(border);
        }


        /**
         * nullを最後に並べる: addOrderBy_Xxx_Asc().withNullsLast().
         * 生年月日の昇順でnullのものは最後に並べる。
         */
        [MbUnit.Framework.Test, Quill(Tx.Rollback)]
        public void Query_AddOrderBy_WithNullsLast() {
            // ## Arrange ##
            MemberCB cb = new MemberCB();
            cb.Query().AddOrderBy_Birthdate_Asc().WithNullsLast();

            // ## Act ##
            ListResultBean<Member> memberList = _memberBhv.SelectList(cb);

            // ## Assert ##
            bool nulls = false;
            bool border = false;
            foreach (Member member in memberList) {
                DateTime? birthday = member.Birthdate;
                log(member.MemberId + ", " + member.MemberName + ", " + birthday);
                if (nulls) {
                    assertNull(birthday);
                } else {
                    if (birthday == null && !border) {
                        nulls = true;
                        border = true;
                        continue;
                    }
                    assertNotNull(birthday);
                }
            }
            assertTrue(border);
        }

        /**
         * nullを最後に並べる(Unionと共演): addOrderBy_Xxx_Asc().withNullsLast(), union().
         * 生年月日のあるなしでUnionでがっちゃんこして、生年月日の昇順でnullのものは最後に並べる。
         */
        public void Query_AddOrderBy_WithNullsLast_and_Union() {
            // ## Arrange ##
            MemberCB cb = new MemberCB();
            cb.Query().SetBirthdate_IsNull();
            cb.Union(delegate(MemberCB unionCB) {
                unionCB.Query().SetBirthdate_IsNotNull();
            });
            cb.Query().AddOrderBy_Birthdate_Asc().WithNullsLast();

            // ## Act ##
            ListResultBean<Member> memberList = _memberBhv.SelectList(cb);

            // ## Assert ##
            bool nulls = false;
            bool border = false;
            foreach (Member member in memberList) {
                DateTime? birthday = member.Birthdate;
                log(member.MemberId + ", " + member.MemberName + ", " + birthday);
                if (nulls) {
                    assertNull(birthday);
                } else {
                    if (birthday == null && !border) {
                        nulls = true;
                        border = true;
                        continue;
                    }
                    assertNotNull(birthday);
                }
            }
            assertTrue(border);
        }

        // ===============================================================================
        //                                                                           Union
        //                                                                           =====
        /**
         * Unionのループによる不定数設定: for { cb.union() }.
         */
        [MbUnit.Framework.Test, Quill(Tx.Rollback)]
        public void SelectList_Union_LoopIndefiniteSetting() {
            // ## Arrange ##
            String keywordDelimiterString = "S M D";
            String[] keywordList = keywordDelimiterString.Split(' ');

            MemberCB cb = new MemberCB();
            cb.SetupSelect_MemberStatus();

            LikeSearchOption prefixOption = new LikeSearchOption().LikePrefix();
            bool first = true;
            foreach (String keyword in keywordList) {
                if (first) {
                    cb.Query().SetMemberAccount_LikeSearch(keyword, prefixOption);
                    first = false;
                    continue;
                }
                cb.Union(delegate(MemberCB unionCB) {
                    unionCB.Query().SetMemberAccount_LikeSearch(keyword, prefixOption);
                });
            }

            // ## Act ##
            ListResultBean<Member> memberList = _memberBhv.SelectList(cb);

            // ## Assert ##
            log("/* * * * * * * * * * * * * * * * * * * * * * * * * * * * * * ");
            assertTrue(memberList.Count > 0);
            foreach (Member member in memberList) {
                String memberName = member.MemberName;
                String memberAccount = member.MemberAccount;
                log(memberName + "(" + memberAccount + ")");
                assertTrue("Unexpected memberAccount = " + memberAccount, memberAccount.StartsWith("S")
                        || memberAccount.StartsWith("M") || memberAccount.StartsWith("D"));
            }
            log("* * * * * * * * * */");
        }

        /**
         * Unionを使ったページング検索: union(), selectPage().
         * 絞り込み条件は「退会会員であること」もしくは「１５００円以上の購入をしたことがある」。
         * 「誕生日の降順＆会員IDの昇順」で並べて、１ページを３件としてページング検索。
         * <pre>
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
        public void SelectPage_Union_ExistsSubQuery() {
            // ## Arrange ##
            int fetchSize = 3;
            MemberCB cb = new MemberCB();
            cb.Query().SetMemberStatusCode_Equal_Withdrawal();
            cb.Union(delegate(MemberCB unionCB) {
                unionCB.Query().ExistsPurchaseList(delegate(PurchaseCB subCB) {
                    subCB.Query().SetPurchasePrice_GreaterEqual(1500);
                });
            });
            cb.Query().AddOrderBy_Birthdate_Desc().AddOrderBy_MemberId_Asc();

            // ## Act ##
            cb.Paging(fetchSize, 1);
            PagingResultBean<Member> page1 = _memberBhv.SelectPage(cb);
            cb.Paging(fetchSize, 2);
            PagingResultBean<Member> page2 = _memberBhv.SelectPage(cb);
            cb.Paging(fetchSize, 3);
            PagingResultBean<Member> page3 = _memberBhv.SelectPage(cb);
            cb.Paging(fetchSize, page1.AllPageCount);// Last Page
            PagingResultBean<Member> lastPage = _memberBhv.SelectPage(cb);

            // ## Assert ##
            assertEquals(fetchSize, page1.Count);
            assertEquals(fetchSize, page2.Count);
            assertEquals(fetchSize, page3.Count);
            assertNotSame(page1[0].MemberId, page2[0].MemberId);
            assertNotSame(page2[0].MemberId, page3[0].MemberId);
            assertNotSame(page3[0].MemberId, lastPage[0].MemberId);
            assertEquals(1, page1.CurrentPageNumber);
            assertEquals(2, page2.CurrentPageNumber);
            assertEquals(3, page3.CurrentPageNumber);
            assertEquals(page1.AllPageCount, lastPage.CurrentPageNumber);
            assertEquals(page1.AllRecordCount, page2.AllRecordCount);
            assertEquals(page2.AllRecordCount, page3.AllRecordCount);
            assertEquals(page3.AllRecordCount, lastPage.AllRecordCount);
            assertEquals(page1.AllPageCount, page2.AllPageCount);
            assertEquals(page2.AllPageCount, page3.AllPageCount);
            assertEquals(page3.AllPageCount, lastPage.AllPageCount);
            assertFalse(page1.IsExistPrePage());
            assertTrue(page1.IsExistNextPage());
            assertTrue(lastPage.IsExistPrePage());
            assertFalse(lastPage.IsExistNextPage());

            ConditionBeanSetupper<PurchaseCB> setupper = delegate(PurchaseCB subCB) {
                subCB.Query().SetPurchasePrice_GreaterEqual(1500);
            };
            _memberBhv.LoadPurchaseList(page1, setupper);
            _memberBhv.LoadPurchaseList(page2, setupper);
            _memberBhv.LoadPurchaseList(page3, setupper);
            _memberBhv.LoadPurchaseList(lastPage, setupper);
            SelectPageUnionExistsSbuQueryAssertBoolean bl = new SelectPageUnionExistsSbuQueryAssertBoolean();
            findTarget_of_selectPage_union_existsSubQuery(page1, bl);
            findTarget_of_selectPage_union_existsSubQuery(page2, bl);
            findTarget_of_selectPage_union_existsSubQuery(page3, bl);
            findTarget_of_selectPage_union_existsSubQuery(lastPage, bl);
            assertTrue(bl.isExistsWithdrawalOnly());
            assertTrue(bl.isExistsPurchasePriceOnly());

            // 最後に目で確認するためにSQLをログへ
            log("/* * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * ");
            String displaySql = cb.ToDisplaySql();
            String newLine = getLineSeparator();
            log(newLine + SimpleStringUtil.Replace(displaySql, " union ", newLine + " union "));
            log("* * * * * * * * * */");
        }

        protected void findTarget_of_selectPage_union_existsSubQuery(PagingResultBean<Member> memberPage,
                SelectPageUnionExistsSbuQueryAssertBoolean bl) {
            foreach (Member member in memberPage) {
                IList<Purchase> purchaseList = member.PurchaseList;
                bool existsPurchaseTarget = false;
                foreach (Purchase purchase in purchaseList) {
                    if (purchase.PurchasePrice >= 1500) {
                        existsPurchaseTarget = true;
                    }
                }
                if (!existsPurchaseTarget && member.IsMemberStatusCodeWithdrawal) {
                    bl.setExistsWithdrawalOnly(true);
                } else if (existsPurchaseTarget && !member.IsMemberStatusCodeWithdrawal) {
                    bl.setExistsPurchasePriceOnly(true);
                }
            }
        }

        protected class SelectPageUnionExistsSbuQueryAssertBoolean {
            protected bool existsWithdrawalOnly = false;
            protected bool existsPurchasePriceOnly = false;

            public bool isExistsWithdrawalOnly() {
                return existsWithdrawalOnly;
            }

            public void setExistsWithdrawalOnly(bool existsWithdrawalOnly) {
                this.existsWithdrawalOnly = existsWithdrawalOnly;
            }

            public bool isExistsPurchasePriceOnly() {
                return existsPurchasePriceOnly;
            }

            public void setExistsPurchasePriceOnly(bool existsPurchasePriceOnly) {
                this.existsPurchasePriceOnly = existsPurchasePriceOnly;
            }
        }

        // ===============================================================================
        //                                                                  Specify Column
        //                                                                  ==============
        /// <summary>
        /// 取得カラムの指定(SpecifyColumn): Specify().ColumnXxx().
        /// 会員名称と会員ステータス名称だけの一覧を検索する。
        /// パフォーマンス上の考慮で１ミリ秒でも速くしたいシビアな検索処理の場合のために、
        /// 取得カラムを指定することができる。１テーブルのカラム数がやたら多いときに有効。
        /// </summary>
        [MbUnit.Framework.Test, Quill(Tx.Rollback)]
        public void SpecifyColumn() {
            // ## Arrange ##
            MemberCB cb = new MemberCB();
            cb.SetupSelect_MemberStatus();
            cb.Specify().ColumnMemberName();
            cb.Specify().SpecifyMemberStatus().ColumnMemberStatusName();

            // ## Act ##
            IList<Member> memberList = _memberBhv.SelectList(cb);

            // ## Assert ##
            assertNotSame(0, memberList.Count);
            foreach (Member member in memberList) {
                assertNotNull(member.MemberId); // PK
                assertNotNull(member.MemberName); // Specified
                assertNull(member.MemberAccount);
                assertNull(member.Birthdate);
                assertNull(member.FormalizedDatetime);
                assertNull(member.RegisterDatetime);
                assertNull(member.RegisterProcess);
                assertNull(member.RegisterUser);
                assertNull(member.UpdateDatetime);
                assertNull(member.UpdateProcess);
                assertNull(member.UpdateUser);
                assertNull(member.VersionNo);
                assertNotNull(member.MemberStatusCode); // SetupSelect FK
                assertNotNull(member.MemberStatus.MemberStatusCode); // PK
                assertNotNull(member.MemberStatus.MemberStatusName); // Specified
                assertNull(member.MemberStatus.DisplayOrder);
            }

            // [Description]
            // A. 結合先テーブルに関しては、setupSelect_Xxx()を呼び出すことに変わりはなく、
            //    setupSelectしたテーブルの中から取得するカラムを指定する。
            //    --> setupSelectしてないテーブルのカラムを指定すると例外となる。
            // 
            // B. カラムが指定されたテーブルのみカラムが絞り込まれ、カラムが指定されないテーブルは
            //    通常通り全てのカラムが取得される。
            //    --> 例えば、ある一つの結合先テーブルだけカラム指定にすることも可能
            // 
            // C. PKは、カラムが指定されなくても必ず取得される。(暗黙の指定カラム)
            // D. SetupSelectされたFKは、カラムが指定されなくても必ず取得される。(暗黙の指定カラム)
        }

        // ===============================================================================
        //                                                                        OnClause
        //                                                                        ========
        /**
         * OnClause(On句)に条件を追加: queryXxx().on().
         * <code>{left outer join xxx on xxx = xxx and [column] = ?}</code>
         * <p>
         * 「会員退会情報が存在している会員一覧」に対して、「退会理由コードがnullでない会員退会情報」を結合して取得。
         * 会員退会情報が存在していても退会理由コードがnullの会員は、会員退会情報が取得されないようにする。
         * </p>
         * <p>
         * OnClauseに条件を追加すると「条件に合致しない結合先レコードは結合しない」という感じになる。
         * よく使われるのは「従属しない関係の結合先テーブルで論理削除されたものは結合しない」というような場合。
         * </p>
         * <p>
         * OnClauseを使わないでWhere句に条件を入れると、条件に合致しない結合先レコードを
         * 参照している基点レコードが検索対象外になってしまう。<br />
         * <code>{left outer join xxx on xxx = xxx where [column] = ?}</code>
         * </p>
         * <pre>
         * 例えば、会員{1,2,3,4,5}に対して会員退会情報{A,B,C}があり、それぞれ{1-A, 2-B, 3-C, 4-null, 5-null}
         * というような関係で、「B」が退会理由コードを持っていない会員退会情報であった場合：
         * 
         * 素直に「会員 left outer join 会員退会情報 on ...」すると結果は以下のようになる。
         * 
         * 　　検索結果：{1-A, 2-B, 3-C, 4-null, 5-null}
         * 
         * これを「会員 left outer join 会員退会情報 on ... and 会員退会情報.退会理由コード is not null」
         * というようにOn句の中で「退会理由コードが存在すること」という条件を付与すると以下のようになる。
         * 
         * 　　検索結果：{1-A, 2-null, 3-C, 4-null, 5-null}
         * 
         * 退会理由コードを持っていない「B」が弾かれて結合されないのである。
         * だからといって「2」の会員自体が検索結果から外れることはない。
         * 
         * これを「会員 left outer join 会員退会情報 on ... where 会員退会情報.退会理由コード is not null」
         * というようにWhere句にて「退会理由コードが存在すること」という条件を付与すると以下のようになる。
         * 
         * 　　検索結果：{1-A, 3-C}
         * 
         * これは今回やりたい検索とは全く違うものである。
         * </pre>
         * <p>
         * OnClauseでなくInlineViewを使っても同じ動きを実現することは可能である。
         * しかし、条件によってはInlineViewの中でフルスキャンが走ってしまう可能性もあるので、
         * パフォーマンスの観点からOnClauseの方が良いかと思われる。(実行計画が異なる)
         * 但し、これはオプティマイザ次第なので、気になったらどちらかに調整するのが良いと思われる。<br />
         * <code>{left outer join (select * from xxx where [column] = ?) xxx on xxx = xxx}</code>
         * </p>
         */
        [MbUnit.Framework.Test, Quill(Tx.Rollback)]
        public void SelectList_Query_QueryForeign_On() {
            // ## Arrange ##
            MemberCB cb = new MemberCB();
            cb.SetupSelect_MemberWithdrawalAsOne();

            // 「退会理由コードがnullでない会員退会情報」のレコードは結合されてないようにする
            // left outer join xxx on xxx = xxx and WithdrawalReasonCode is not null
            cb.Query().QueryMemberWithdrawalAsOne().On().SetWithdrawalReasonCode_IsNotNull();

            // left outer join (select * from xxx where WithdrawalReasonCode is not null) xxx on xxx = xxx
            // cb.query().queryMemberWithdrawalAsOne().inline().setWithdrawalReasonCode_IsNotNull();

            // 会員退会情報が存在する会員だけを取得するようにする
            cb.Query().InScopeMemberWithdrawalAsOne(delegate(MemberWithdrawalCB subCB) {
            });
            cb.Query().QueryMemberWithdrawalAsOne().AddOrderBy_WithdrawalDatetime_Desc();

            // ## Act ##
            ListResultBean<Member> memberList = _memberBhv.SelectList(cb);

            // ## Assert ##
            assertNotSame(0, memberList.Count);
            bool existsMemberWithdrawal = false;// 会員退会情報があってWithdrawalReasonCodeも存在する会員がいるか否か
            bool notExistsMemberWithdrawal = false;// 会員退会情報はあるけどWithdrawalReasonCodeがない会員がいるか否か
            IList<long?> notExistsMemberIdList = new List<long?>();
            foreach (Member member in memberList) {
                MemberWithdrawal memberWithdrawal = member.MemberWithdrawalAsOne;
                if (memberWithdrawal != null) {
                    log(member.MemberName + " -- " + memberWithdrawal.WithdrawalReasonCode + ", "
                            + memberWithdrawal.WithdrawalDatetime);
                    String withdrawalReasonCode = memberWithdrawal.WithdrawalReasonCode;
                    assertNotNull(withdrawalReasonCode);
                    existsMemberWithdrawal = true;
                } else {
                    // 会員退会情報は存在するけどWithdrawalReasonCodeが存在しない会員も取得できていること
                    log(member.MemberName + " -- " + memberWithdrawal);
                    notExistsMemberWithdrawal = true;
                    notExistsMemberIdList.Add(member.MemberId);
                }
            }
            // 両方のパターンのデータがないとテストにならないので確認
            assertTrue(existsMemberWithdrawal);
            assertTrue(notExistsMemberWithdrawal);
            // MemberWithdrawalを取得できなかった会員の会員退会情報がちゃんとあるかどうか確認
            foreach (int? memberId in notExistsMemberIdList) {
                MemberWithdrawalCB pkCB = new MemberWithdrawalCB();
                pkCB.Query().SetMemberId_Equal(memberId);
                _memberWithdrawalBhv.SelectEntityWithDeletedCheck(pkCB);// Expected no exception
            }
        }

        // ===============================================================================
        //                                                         Specify DerivedReferrer
        //                                                         =======================
        /**
         * 子テーブル導出カラムの指定(SpecifyDerivedReferrer)-Max: specify().derivedXxxList().max().
         * 会員の最終ログイン日時を取得。但し、モバイル端末からのログインは除く。
         * <p>
         * 子テーブルの導出カラムを指定することができる。
         * 例えば、子テーブルのとあるカラムの合計値や最大値などを取得することが可能である。
         * 例題のSQL文のイメージは以下の通り：
         * </p>
         * <pre>
         * ex) 最終ログイン日時を取得するSQL
         * select member.*
         *      , (select max(LOGIN_DATETIME)
         *           from MEMBER_LOGIN
         *          where MEMBER_ID = member.MEMBER_ID
         *            and LOGIN_MOBILE_FLG = 0
         *        ) as LATEST_LOGIN_DATETIME
         *   from MEMBER member
         * </pre>
         * @since 0.8.0
         */
        [MbUnit.Framework.Test, Quill(Tx.Rollback)]
        public void SepcifyDerivedReferrer_Max() {
            // ## Arrange ##
            MemberCB cb = new MemberCB();
            cb.Specify().DerivedMemberLoginList().Max(delegate(MemberLoginCB subCB) {
                subCB.Specify().ColumnLoginDatetime(); // *Point!
                subCB.Query().SetMobileLoginFlg_Equal_False(); // Except Mobile
            }, "LATEST_LOGIN_DATETIME");

            // ## Act ##
            ListResultBean<Member> memberList = _memberBhv.SelectList(cb);

            // ## Assert ##
            assertNotSame(0, memberList.Count);
            bool existsLoginDatetime = false;
            bool existsNullLoginDatetime = false;
            foreach (Member member in memberList) {
                String memberName = member.MemberName;
                DateTime? latestLoginDatetime = member.LatestLoginDatetime;
                if (latestLoginDatetime != null) {
                    existsLoginDatetime = true;
                } else {
                    // ログインを一度もしていない会員、もしくは、モバイルでしかログイン
                    // したことのない会員の最終ログイン日時はnullになる。
                    existsNullLoginDatetime = true;
                }
                log("memberName=" + memberName + ", latestLoginDatetime=" + latestLoginDatetime);
            }
            assertTrue(existsLoginDatetime);
            assertTrue(existsNullLoginDatetime);

            // [Description]
            // A. 実装前に導出カラムを受け取るためのプロパティをEntityに定義する必要がある。
            // 
            //    ex) ExtendedのEntity(ExEntity)に最終ログイン日時のプロパティを手動で実装
            //    protected Date _latestLoginDatetime;
            //    public Date getLatestLoginDatetime() {
            //        return _latestLoginDatetime;
            //    }
            //    public void setLatestLoginDatetime(Date latestLoginDatetime) {
            //        _latestLoginDatetime = latestLoginDatetime;
            //    }
            // 
            // B. 関数には、{max, min, sum, avg, count}が利用可能である。
            //    --> sumとavgは数値型のみ利用可能
            //    --> countの場合は子テーブルのPKを導出カラムとすることが基本
            // 
            // C. 必ずSubQueryの中で導出カラムを「一つ」指定すること。
            //    --> 何も指定しない、もしくは、二つ以上の指定で例外発生
            // 
            // D. 導出カラムは子テーブルのカラムのみサポートされる。
            //    --> 子テーブルの別の親テーブル(もしくはone-to-one)のカラムを導出カラムにはできない。
            // 
            // E. 基点テーブルが複合主キーの場合はサポートされない。
            // 
            // F. one-to-oneの子テーブルの場合はサポートされない。(そもそも不要である)
            // 
            // G. SubQueryの中でsetupSelectやaddOrderByを指定しても無意味である。
            // 
            // H. SpecifyColumnやUnionとも組み合わせて利用することが可能である。
        }

        /**
         * 子テーブル導出カラムで並び替え(SpecifiedDerivedOrderBy)-Count: addSpecifiedDerivedOrderBy_Desc().
         * 会員のログイン回数を取得する際に、ログイン回数の多い順そして会員IDの昇順で並べる。但し、モバイル端末からのログインは除く。
         * <p>
         * 子テーブルの導出カラムで並び替えをすることができる。
         * SQL文のイメージは以下の通り：
         * </p>
         * <pre>
         * ex) ログイン回数を取得するSQL
         * select member.*
         *      , (select count(MEMBER_LOGIN_ID)
         *           from MEMBER_LOGIN
         *          where MEMBER_ID = member.MEMBER_ID
         *        ) as LOGIN_COUNT
         *   from MEMBER member
         *  order by LOGIN_COUNT desc, member.MEMBER_ID asc
         * </pre>
         * @since 0.8.0
         */
        [MbUnit.Framework.Test, Quill(Tx.Rollback)]
        public void AddSepcifidDerivedOrderBy_Count() {
            // ## Arrange ##
            MemberCB cb = new MemberCB();
            cb.Specify().DerivedMemberLoginList().Count(delegate(MemberLoginCB subCB) {
                subCB.Specify().ColumnMemberLoginId(); // *Point!
                subCB.Query().SetMobileLoginFlg_Equal_False(); // Except Mobile
            }, "LOGIN_COUNT");
            cb.Query().AddSpecifiedDerivedOrderBy_Desc("LOGIN_COUNT");
            cb.Query().AddOrderBy_MemberId_Asc();

            // ## Act ##
            ListResultBean<Member> memberList = _memberBhv.SelectList(cb);

            // ## Assert ##
            assertNotSame(0, memberList.Count);
            foreach (Member member in memberList) {
                String memberName = member.MemberName;
                int? loginCount = member.LoginCount;
                assertNotNull(loginCount); // count()なので0件の場合は0になる(DB次第かも...)
                log("memberName=" + memberName + ", loginCount=" + loginCount);
            }
            // [Description]
            // A. SpecifyDerivedReferrerで指定されていないAliasNameを指定すると例外発生。
            // 
            // B. withNullsFirst/Last()と組み合わせることも可能
        }

        // ===============================================================================
        //                                                                Statement Config
        //                                                                ================
        /// <summary>
        /// Statementのコンフィグを設定: cb.configure(statementConfig).
        /// </summary>
        [MbUnit.Framework.Test, Quill(Tx.Rollback)]
        public void Configure_StatementConfig() {
            // ## Arrange ##
            MemberCB cb = new MemberCB();
            cb.Configure(new StatementConfig().QueryTimeout(7));

            // ## Act & Assert ##
            _memberBhv.SelectList(cb);
        }

        // ===============================================================================
        //                                                                     Display SQL
        //                                                                     ===========
        /**
         * どんなにSubQueryやUnionの連打をしてもSQLが綺麗にフォーマット: toDisplaySql().
         * ログでSQLが綺麗にフォーマットされていることを確認するだけ。
         * <p>
         * デバッグのし易さの徹底と、ConditionBeanから外だしSQLへの移行時にスムーズにできるように
         * ログのフォーマットを重視している。相関サブクエリなどはConditionBeanで書いてから出力された
         * SQLをベースに実装した方が外だしSQLでありがちなケアレスバグも無くなる。
         * </p>
         */
        [MbUnit.Framework.Test, Quill(Tx.Rollback)]
        public void ToDisplaySql_Check_FormattedSQL() {
            // - - - - - - - - - - - - - - - - - - - - - - - - - - - - -
            // 単にフォーマットされていることがみたいだけなので条件はかなり無茶苦茶
            // - - - - - - - - - - - - - - - - - - - - - - - - - - - - -
            MemberStatusCB cb = new MemberStatusCB();
            cb.Query().SetDisplayOrder_Equal(3);
            cb.Query().ExistsMemberList(delegate(MemberCB memberCB) {
                memberCB.Query().SetBirthdate_LessEqual(DateTime.Now);
                memberCB.Query().ExistsPurchaseList(delegate(PurchaseCB purchaseCB) {
                    purchaseCB.Query().SetPurchaseCount_GreaterEqual(2);
                });
                memberCB.Query().ExistsMemberWithdrawalAsOne(delegate(MemberWithdrawalCB subCB) {
                    LikeSearchOption option = new LikeSearchOption().LikeContain().EscapeByPipeLine();
                    subCB.Query().QueryWithdrawalReason().SetWithdrawalReasonCode_LikeSearch("xxx", option);
                    subCB.Union(delegate(MemberWithdrawalCB unionCB) {
                        unionCB.Query().SetWithdrawalReasonInputText_IsNotNull();
                    });
                });
            });
            cb.Query().SetMemberStatusCode_Equal_Formalized();
            cb.Query().ExistsMemberLoginList(delegate(MemberLoginCB subCB) {
                subCB.Query().InScopeMember(delegate(MemberCB subSubCB) {
                    subSubCB.Query().SetBirthdate_GreaterEqual(DateTime.Now);
                });
            });
            cb.Query().AddOrderBy_DisplayOrder_Asc().AddOrderBy_MemberStatusCode_Desc();
            log(getLineSeparator() + cb.ToDisplaySql());
        }
    }
}
