using System;
using System.Collections.Generic;
using System.Text;
using DfExample.DBFlute.AllCommon.CBean;
using DfExample.DBFlute.AllCommon.CBean.COption;
using DfExample.DBFlute.CBean;
using DfExample.DBFlute.ExBhv;
using DfExample.DBFlute.ExEntity;
using Seasar.Extension.Unit;
using Seasar.Quill.Unit;

namespace DfExample.DBFlute.HowTo.Jp {

    /// <summary>
    ///  ConditionBeanの中級編Example実装。
    ///  <pre>
    ///  ターゲットは以下の通り：
    ///    o DBFluteってどういう機能があるのかを探っている方
    ///    o DBFluteで実装を開始する方・実装している方
    ///  
    ///  コンテンツは以下の通り：
    ///    o many(one)-to-one-to-one(親の親)を結合して取得する検索: setupSelect_Xxx().withXxx().
    ///    o many(one)-to-one-to-one-to-one(親の親の親)を結合して取得する検索: setupSelect_Xxx().withXxx().withXxx().
    ///    o Query-Equal条件で区分値機能を使ってタイプセーフに区分値を指定: setXxx_Equal_Xxx().
    ///    o Query-NotEqual条件: setXxx_NotEqual().
    ///    o Query-NotEqual条件で区分値機能を使ってタイプセーフに区分値を指定: setXxx_NotEqual_Xxx().
    ///    o Query-GreaterThan条件: setXxx_GreaterThan().
    ///    o Query-GreaterEqual条件: setXxx_GreaterEqual().
    ///    o Query-LessThan条件: setXxx_LessThan().
    ///    o Query-LessEqual条件: setXxx_LessEqual().
    ///    o Query-PrefixSearch条件(前方一致): setXxx_PrefixSearch().
    ///    o Query-InScope条件(in ('a', 'b')): setXxx_InScope().
    ///    o Query-NotInScope条件(not in ('a', 'b')): setXxx_NotInScope().
    ///    o Query-LikeSearch条件の前方一致: setXxx_LikeSearch(), option.likePrefix().
    ///    o Query-LikeSearch条件の中間一致: setXxx_LikeSearch(), option.likeContain().
    ///    o Query-LikeSearch条件の後方一致: setXxx_LikeSearch(), option.likeSuffix().
    ///    o Query-LikeSearch条件のエスケープ付き曖昧検索: setXxx_LikeSearch(), option.escapeByXxx().
    ///    o Query-NotLikeSearch条件の前方一致: setXxx_NotLikeSearch(), option.likePrefix().
    ///    o Query-ExistsSubQueryで子テーブル(Referrer)の条件で絞り込み: cb.query().existsXxxList().
    ///    o Query-ExistsSubQueryでmany-to-manyの関係のテーブルの条件で絞り込み: cb.query().existsXxxList().
    ///    o Query-NotExistsSubQueryで子テーブル(Referrer)の条件で絞り込み: cb.query().notExistsXxxList().
    ///    o Query-InScopeSubQueryで子テーブル(Referrer)の条件で絞り込み: cb.query().inScopeXxxList().
    ///    o Query-InScopeSubQueryでmany-to-manyの関係のテーブルの条件で絞り込み: cb.query().inScopeXxxList().
    ///    o Query-NotInScopeSubQueryで子テーブル(Referrer)の条件で絞り込み: cb.query().notInScopeXxxList().
    ///    o Query-DateFromTo(日付の範囲検索): query().setXxx_DateFromTo().
    ///    o Union(Or条件の代替): union().
    ///    o UnionAll(Or条件の代替): unionAll().
    ///    o ページング検索: cb.paging(pageSize, pageNumber).
    ///    o 先頭のn件を検索: cb.fetchFirst(fetchSize).
    ///    o 更新ロックを取得: cb.lockForUpdate().
    ///    o ConditionBeanで組み立てたSQLをログに表示: toDisplaySql().
    ///    o ConditionBeanで組み立てたSQLをログに表示(SubQuery含み): toDisplaySql().
    ///  </pre>
    ///  @author jflute
    ///  @since 0.7.3 (2008/06/01 Sunday)
    /// </summary>
    [MbUnit.Framework.TestFixture]
    public class ConditionBeanMiddleTest : ContainerTestCase {
        // ===================================================================================
        //                                                                           Attribute
        //                                                                           =========
        /** The behavior of Member. (Injection Object) */
        protected MemberBhv memberBhv;

        /** The behavior of Purchase. (Injection Object) */
        protected PurchaseBhv purchaseBhv;

        // ===============================================================================
        //                                                                     SetupSelect
        //                                                                     ===========
        /// <summary>
        /// many(one)-to-one-to-one(親の親)を結合して取得する検索: setupSelect_Xxx().withXxx().
        /// 「会員ステータス」と「会員退会情報」ならびに「退会理由」をSetupSelectして検索。
        /// </summary>
        [MbUnit.Framework.Test, Quill(Tx.Rollback)]
        public void test_setupSelect_Tx() {
            // ## Arrange ##
            MemberCB cb = new MemberCB();
            cb.SetupSelect_MemberWithdrawalAsOne().WithWithdrawalReason();

            // ## Act ##
            ListResultBean<Member> memberList = memberBhv.SelectList(cb);

            // ## Assert ##
            assertNotSame(0, memberList.Count);
            bool existsWithdrawalReason = false;
            foreach (Member member in memberList) {
                log("[MEMBER]: " + member.MemberName);
                MemberWithdrawal memberWithdrawalAsOne = member.MemberWithdrawalAsOne;
                if (memberWithdrawalAsOne != null) {// {1 : 0...1}の関連なのでnullチェック
                    WithdrawalReason withdrawalReason = memberWithdrawalAsOne.WithdrawalReason;
                    if (withdrawalReason != null) {// NullableなFKなのでnullチェック
                        String withdrawalReasonCode = memberWithdrawalAsOne.WithdrawalReasonCode;
                        String withdrawalReasonText = withdrawalReason.WithdrawalReasonText;
                        log("    [WITHDRAWAL]" + withdrawalReasonCode + " - " + withdrawalReasonText);
                        existsWithdrawalReason = true;
                    } else {
                        log("    [WITHDRAWAL]" + memberWithdrawalAsOne);
                    }
                }
            }
            assertTrue(existsWithdrawalReason);

            // [Description]
            // A. setupSelect_Xxx()した後に続いてwithXxx()と指定することでさらに上の階層を指定できる。
            // B. 指定できる階層は無限階層である。(withXxx().withXxx().withXxx()...)
        }

        // /* * * * * * * * * * * * * * * * * * * * *
        // Oracle30文字問題でこのテストは動かない
        // (Exampleにたまたま長いカラム名が存在した)
        // * * * * * * * * * */
        /// <summary>
        /// many(one)-to-one-to-one-to-one(親の親の親)を結合して取得する検索: setupSelect_Xxx().withXxx().withXxx().
        /// 購入から会員、会員から会員退会情報、会員退会情報から退会理由までの３階層を結合して取得。
        /// 実務ではあまりこういった検索はないと思われるが、説明材料のExampleとして実装している。
        /// </summary>
        //[MbUnit.Framework.Test, Quill(Tx.Rollback)]
        //public void test_setupSelect_withForeign_withForeign_Tx() {
        //    // ## Arrange ##
        //    PurchaseCB cb = new PurchaseCB();
        //    cb.SetupSelect_Member().WithMemberWithdrawalAsOne().WithWithdrawalReason();// *Point!
        //    cb.SetupSelect_Member().WithMemberStatus();
        //    cb.SetupSelect_Product().WithProductStatus();
        //    cb.Query().AddOrderBy_PurchaseDatetime_Desc().AddOrderBy_PurchaseId_Asc();

        //    // ## Act ##
        //    ListResultBean<Purchase> purchaseList = purchaseBhv.SelectList(cb);

        //    // ## Assert ##
        //    assertNotSame(0, purchaseList.Count);
        //    bool existsWithdrawal = false;
        //    foreach (Purchase purchase in purchaseList) {
        //        Product product = purchase.Product;
        //        ProductStatus productStatus = product.ProductStatus;
        //        assertNotNull(product);
        //        assertNotNull(productStatus);
        //        log("[PURCHASE]: " + purchase.PurchaseId + ", " + product.ProductName + ", " + productStatus);
        //        Member member = purchase.Member;
        //        assertNotNull(member);
        //        assertNotNull(member.MemberStatus);

        //        MemberWithdrawal memberWithdrawalAsOne = member.MemberWithdrawalAsOne;
        //        if (memberWithdrawalAsOne != null) {
        //            WithdrawalReason withdrawalReason = memberWithdrawalAsOne.WithdrawalReason;
        //            if (withdrawalReason != null) {
        //                String reasonText = withdrawalReason.WithdrawalReasonText;
        //                log("    [MEMBER]: " + member.MemberId + ", " + member.MemberName + ", " + reasonText);
        //                assertNotNull(reasonText);
        //                existsWithdrawal = true;
        //            }
        //        }
        //    }
        //    assertTrue("退会者が少なくとも一人以上は存在してないとテストにならない", existsWithdrawal);
        //}

        // /- - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -
        // 子テーブル(Referrer)の取得に関しては、BehaviorMiddleTestのLoadReferrerにて
        // - - - - - - - - - -/

        // ===============================================================================
        //                                                                           Query
        //                                                                           =====
        // -------------------------------------------------
        //                                             Equal
        //                                             -----
        // /- - - - - - - - - - - - - - - - - - - - - - - - - - -
        // Equalの基本的な利用に関しては、ConditionBeanBasicTestにて
        // - - - - - - - - - -/
        /// <summary>
        /// Query-Equal条件で区分値機能を使ってタイプセーフに区分値を指定: setXxx_Equal_Xxx().
        /// 正式会員の会員を検索。
        /// </summary>
        [MbUnit.Framework.Test, Quill(Tx.Rollback)]
        public void test_query_setMemberStatusCode_Equal_Classification_Tx() {
            // ## Arrange ##
            MemberCB cb = new MemberCB();
            cb.Query().SetMemberStatusCode_Equal_Formalized();// *Point!

            // ## Act ##
            ListResultBean<Member> memberList = memberBhv.SelectList(cb);

            // ## Assert ##
            assertNotSame(0, memberList.Count);
            foreach (Member member in memberList) {
                assertTrue(member.IsMemberStatusCodeFormalized);
            }
        }

        // -----------------------------------------------------
        //                                              NotEqual
        //                                              --------
        /// <summary>
        /// Query-NotEqual条件: setXxx_NotEqual().
        /// 会員アカウントが「Pixy」でない会員を検索。
        /// </summary>
        [MbUnit.Framework.Test, Quill(Tx.Rollback)]
        public void test_query_NotEqual_Tx() {
            // ## Arrange ##
            int countAll = memberBhv.SelectCount(new MemberCB());
            MemberCB cb = new MemberCB();
            cb.Query().SetMemberAccount_NotEqual("Pixy"); // *Point!

            // ## Act ##
            ListResultBean<Member> memberList = memberBhv.SelectList(cb);

            // ## Assert ##
            assertNotNull(memberList);
            assertNotSame(0, memberList.Count);
            assertEquals(countAll - 1, memberList.Count);
            foreach (Member member in memberList) {
                assertNotSame("Pixy", member.MemberAccount);
            }

            // [SQL]
            // where MEMBER_ACCOUNT != 'Pixy'

            // [Description]
            // A. 別の値で二回呼び出しても上書きになるだけなので注意。
            //    --> その場合NotInScopeを利用
            // 
            // B. 数値型と日付型に関しては、EMechaやDBFluteClientテンプレートにおいて、
            //    利用頻度の少なさからデフォルトで生成されないような設定になっている。
            //    --> {DBFluteClient}/dfprop/includeQueryMap.dfprop
        }

        /// <summary>
        /// Query-NotEqual条件で区分値機能でタイプセーフに区分値を指定: setXxx_NotEqual_Xxx().
        /// 正式会員でない会員を検索。 
        /// </summary>
        [MbUnit.Framework.Test, Quill(Tx.Rollback)]
        public void test_query_NotEqual_Classification_Tx() {
            // ## Arrange ##
            MemberCB cb = new MemberCB();
            cb.Query().SetMemberStatusCode_NotEqual_Formalized();// *Point!

            // ## Act ##
            ListResultBean<Member> memberList = memberBhv.SelectList(cb);

            // ## Assert ##
            assertNotNull(memberList);
            assertNotSame(0, memberList.Count);
            foreach (Member member in memberList) {
                assertFalse(member.IsMemberStatusCodeFormalized);
            }

            // [SQL]
            // where MEMBER_STATUS_CODE != 'FML'
        }

        // -----------------------------------------------------
        //                                           GreaterThan
        //                                           -----------
        /// <summary>
        /// Query-GreaterThan条件: setXxx_GreaterThan().
        /// 会員ID「3」より大きい会員IDを持った会員を検索。 
        /// </summary>        
        public void test_query_GreaterThan_Tx() {
            // ## Arrange ##
            MemberCB cb = new MemberCB();
            cb.Query().SetMemberId_GreaterThan(3);// *Point!

            // ## Act ##
            ListResultBean<Member> memberList = memberBhv.SelectList(cb);

            // ## Assert ##
            assertNotNull(memberList);
            assertNotSame(0, memberList.Count);
            foreach (Member member in memberList) {
                assertTrue(member.MemberId > 3);
            }

            // [SQL]
            // where MEMBER_ID > 3
        }

        // -----------------------------------------------------
        //                                          GreaterEqual
        //                                          ------------
        /// <summary>
        /// Query-GreaterEqual条件: setXxx_GreaterEqual().
        /// 会員ID「3」以上の会員IDを持った会員を検索。
        /// </summary>
        [MbUnit.Framework.Test, Quill(Tx.Rollback)]
        public void test_query_GreaterEqual_Tx() {
            // ## Arrange ##
            MemberCB cb = new MemberCB();
            cb.Query().SetMemberId_GreaterEqual(3);// *Point!

            // ## Act ##
            ListResultBean<Member> memberList = memberBhv.SelectList(cb);

            // ## Assert ##
            assertNotNull(memberList);
            assertNotSame(0, memberList.Count);
            foreach (Member member in memberList) {
                assertTrue(member.MemberId >= 3);
            }

            // [SQL]
            // where MEMBER_ID >= 3
        }

        // -----------------------------------------------------
        //                                              LessThan
        //                                              --------
        /**
         * Query-LessThan条件: setXxx_LessThan().
         * 会員ID「3」より小さい会員IDを持った会員を検索。
         */
        [MbUnit.Framework.Test, Quill(Tx.Rollback)]
        public void test_query_LessThan_Tx() {
            // ## Arrange ##
            MemberCB cb = new MemberCB();
            cb.Query().SetMemberId_LessThan(3);// *Point!

            // ## Act ##
            ListResultBean<Member> memberList = memberBhv.SelectList(cb);

            // ## Assert ##
            assertNotNull(memberList);
            assertNotSame(0, memberList.Count);
            foreach (Member member in memberList) {
                assertTrue(member.MemberId < 3);
            }

            // [SQL]
            // where MEMBER_ID < 3
        }

        // -----------------------------------------------------
        //                                             LessEqual
        //                                             ---------
        /**
         * Query-LessEqual条件: setXxx_LessEqual().
         * 会員ID「3」以下の会員IDを持った会員を検索。
         */
        [MbUnit.Framework.Test, Quill(Tx.Rollback)]
        public void test_query_LessEqual_Tx() {
            // ## Arrange ##
            MemberCB cb = new MemberCB();
            cb.Query().SetMemberId_LessEqual(3);// *Point!

            // ## Act ##
            ListResultBean<Member> memberList = memberBhv.SelectList(cb);

            // ## Assert ##
            assertNotNull(memberList);
            assertNotSame(0, memberList.Count);
            foreach (Member member in memberList) {
                assertTrue(member.MemberId <= 3);
            }

            // [SQL]
            // where MEMBER_ID <= 3
        }

        // -----------------------------------------------------
        //                                          PrefixSearch
        //                                          ------------
        /**
         * Query-PrefixSearch条件(前方一致): setXxx_PrefixSearch().
         * 会員名称が'S'で始まる会員を検索。
         */
        public void test_query_PrefixSearch_Tx() {
            // ## Arrange ##
            MemberCB cb = new MemberCB();
            cb.Query().SetMemberName_PrefixSearch("S");// *Point!

            // ## Act ##
            ListResultBean<Member> memberList = memberBhv.SelectList(cb);

            // ## Assert ##
            assertNotNull(memberList);
            assertNotSame(0, memberList.Count);
            foreach (Member member in memberList) {
                log("memberName=" + member.MemberName);
                assertTrue(member.MemberName.StartsWith("S"));
            }

            // [SQL]
            // where MEMBER_NAME like 'S%'

            // [Description]
            // A. ワイルドカード'%'は内部的に自動付与される。
            // B. エスケープ処理はされない。
            //    --> エスケープ処理はLikeSearchを利用
        }

        // -----------------------------------------------------
        //                                               InScope
        //                                               -------
        /**
         * Query-InScope条件(in ('a', 'b')): setXxx_InScope().
         * 会員ID「3」・「6」・「7」の会員を検索。
         */
        [MbUnit.Framework.Test, Quill(Tx.Rollback)]
        public void test_query_InScope_Tx() {
            // ## Arrange ##
            MemberCB cb = new MemberCB();
            IList<long?> expectedMemberIdList = new System.Collections.Generic.List<long?>();
            expectedMemberIdList.Add(3);
            expectedMemberIdList.Add(6);
            expectedMemberIdList.Add(7);
            cb.Query().SetMemberId_InScope(expectedMemberIdList);// *Point!
            // ## Act ##
            ListResultBean<Member> memberList = memberBhv.SelectList(cb);

            // ## Assert ##
            assertNotNull(memberList);
            assertNotSame(0, memberList.Count);
            foreach (Member member in memberList) {
                log("memberId=" + member.MemberId);
                assertTrue(expectedMemberIdList.Contains(member.MemberId));
            }

            // [Description]
            // A. 空のリストが指定された場合は、その条件は無効になる。
            //    --> nullが指定された場合と同じ
            // 
            // B. リストの中に同じ値が格納されている場合は、そのまま処理される。
            //    --> 例えば、'6'が二つ格納されていたら: in (3, 6, 6, 7)
            // 
            // C. リストの中にnullや空文字が登録されている場合は、それら値だけ無視される。
            //    --> リストの中が全てnullや空文字なら「A」と同じ
        }

        //// -----------------------------------------------------
        ////                                            NotInScope
        ////                                            ----------
        /**
         * Query-NotInScope条件(not in ('a', 'b')): setXxx_NotInScope().
         * 会員ID「3」・「6」・「7」でない会員を検索
         */
        [MbUnit.Framework.Test, Quill(Tx.Rollback)]
        public void test_query_NotInScope_Tx() {
            // ## Arrange ##
            MemberCB cb = new MemberCB();
            System.Collections.Generic.List<long?> expectedMemberIdList = new System.Collections.Generic.List<long?>();
            expectedMemberIdList.Add(3);
            expectedMemberIdList.Add(6);
            expectedMemberIdList.Add(7);
            cb.Query().SetMemberId_NotInScope(expectedMemberIdList);// *Point!

            // ## Act ##
            ListResultBean<Member> memberList = memberBhv.SelectList(cb);

            // ## Assert ##
            assertNotNull(memberList);
            assertNotSame(0, memberList.Count);
            foreach (Member member in memberList) {
                log("memberId=" + member.MemberId);
                if (expectedMemberIdList.Contains(member.MemberId)) {
                    fail();
                }
            }

            // [Description]
            // A. 空のリストが指定された場合は、その条件は無効になる。
            //    --> nullが指定された場合と同じ
            // 
            // B. リストの中に同じ値が格納されている場合は、そのまま処理される。
            //    --> 例えば、'6'が二つ格納されていたら: in (3, 6, 6, 7)
            // 
            // C. リストの中にnullや空文字が登録されている場合は、それら値だけ無視される。
            //    --> リストの中が全てnullや空文字なら「A」と同じ
        }

        // -----------------------------------------------------
        //                                            LikeSearch
        //                                            ----------
        /**
         * Query-LikeSearch条件の前方一致: setXxx_LikeSearch(), option.likePrefix().
         * 会員名称が'S'で始まる会員を検索。
         */
        [MbUnit.Framework.Test, Quill(Tx.Rollback)]
        public void test_query_LikeSearch_likePrefix_Tx() {
            // ## Arrange ##
            MemberCB cb = new MemberCB();

            // *Point!
            LikeSearchOption option = new LikeSearchOption().LikePrefix();
            cb.Query().SetMemberName_LikeSearch("S", option);

            // ## Act ##
            ListResultBean<Member> memberList = memberBhv.SelectList(cb);

            // ## Assert ##
            assertNotNull(memberList);
            assertNotSame(0, memberList.Count);
            foreach (Member member in memberList) {
                log("memberName=" + member.MemberName);
                assertTrue(member.MemberName.StartsWith("S"));
            }

            // [Description]
            // A. LikeSearchOptionの指定は必須。(nullは例外)
        }

        /**
         * Query-LikeSearch条件の中間一致: setXxx_LikeSearch(), option.likeContain().
         * 会員名称に'v'が含まれる会員を検索。
         */
        [MbUnit.Framework.Test, Quill(Tx.Rollback)]
        public void test_query_LikeSearch_likeContain_Tx() {
            // ## Arrange ##
            MemberCB cb = new MemberCB();

            // *Point!
            LikeSearchOption option = new LikeSearchOption().LikeContain();
            cb.Query().SetMemberName_LikeSearch("v", option);

            // ## Act ##
            ListResultBean<Member> memberList = memberBhv.SelectList(cb);

            // ## Assert ##
            assertNotNull(memberList);
            assertNotSame(0, memberList.Count);
            foreach (Member member in memberList) {
                log("memberName=" + member.MemberName);
                assertTrue(member.MemberName.Contains("v"));
            }

            // [Description]
            // A. LikeSearchOptionの指定は必須。(nullは例外)
        }

        /**
         * Query-LikeSearch条件の後方一致: setXxx_LikeSearch(), option.likeSuffix().
         * 会員名称が'r'で終わる会員を検索。
         */
        [MbUnit.Framework.Test, Quill(Tx.Rollback)]
        public void test_query_LikeSearch_likeSuffix_Tx() {
            // ## Arrange ##
            MemberCB cb = new MemberCB();

            // *Point!
            LikeSearchOption option = new LikeSearchOption().LikeSuffix();
            cb.Query().SetMemberName_LikeSearch("r", option);

            // ## Act ##
            ListResultBean<Member> memberList = memberBhv.SelectList(cb);

            // ## Assert ##
            assertNotNull(memberList);
            assertNotSame(0, memberList.Count);
            foreach (Member member in memberList) {
                log("memberName=" + member.MemberName);
                assertTrue(member.MemberName.EndsWith("r"));
            }

            // [Description]
            // A. LikeSearchOptionの指定は必須。(nullは例外)
        }

        [MbUnit.Framework.Test, Quill(Tx.Rollback)]
        public void test_query_LikeSearch_likeContain_escapeByPipeline_AllEscape_Tx() {
            // ## Arrange ##
            String keyword = "100%ジュース|和歌山_テ";
            String expectedMemberName = "果汁" + keyword + "スト";
            String dummyMemberName = "果汁100パーセントジュース|和歌山Aテスト";

            // escape処理の必要な会員がいなかったので、ここで一時的に登録
            Member escapeMember = new Member();
            escapeMember.MemberName = expectedMemberName;
            escapeMember.MemberAccount = "temporaryAccount";
            escapeMember.SetMemberStatusCode_Formalized();
            memberBhv.Insert(escapeMember);

            // escape処理をしない場合にHITする会員も登録
            Member nonEscapeOnlyMember = new Member();
            nonEscapeOnlyMember.MemberName = dummyMemberName;
            nonEscapeOnlyMember.MemberAccount = "temporaryAccount2";
            nonEscapeOnlyMember.SetMemberStatusCode_Formalized();
            memberBhv.Insert(nonEscapeOnlyMember);

            // 一時的に登録した会員が想定しているものかどうかをチェック
            MemberCB checkCB = new MemberCB();

            // *Point!
            checkCB.Query().SetMemberName_LikeSearch(keyword, new LikeSearchOption().LikeContain().NotEscape());
            assertEquals("escapeなしで2件ともHITすること", 2, memberBhv.SelectList(checkCB).Count);

            // /- - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - 
            MemberCB cb = new MemberCB();
            LikeSearchOption option = new LikeSearchOption().LikeContain().EscapeByPipeLine(); // *Point!
            cb.Query().SetMemberName_LikeSearch(keyword, option);
            // - - - - - - - - - -/

            // ## Act ##
            ListResultBean<Member> memberList = memberBhv.SelectList(cb);

            // ## Assert ##
            assertNotNull(memberList);
            assertEquals(1, memberList.Count); // このキーワードにHITする人は１人しかいない
            Member actualMember = memberList[0];
            log(actualMember);
            assertEquals(expectedMemberName, actualMember.MemberName);

            // [SQL]
            // select ...
            //   from MEMBER 
            //  where MEMBER_NAME like '%100|%ジュース||和歌山|_テ%' escape '|'
        }

        // /= = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = 
        // [Tips]: そもそもエスケープ付き曖昧検索とは？
        //
        //    曖昧検索は、条件値に含まれているワイルドカード(%や_)を使って、
        //    前方一致・中間一致等を実現する。例えば、条件値が'ス%'であれば
        //    「スで始まるもの」、'%ス%'であれば「スを含むもの」という検索になる
        //    しかし、もしデータベース上に「100%ジュースの飲み物」という文字が
        //    格納されていて、「'100%ジュース'を含むもの」という検索をしたい場合に、
        //    条件値が'%100%ジュース%'では正確な検索をすることができない。
        //
        //        [曖昧検索-'100%ジュース'を含むもの]
        //        =============================================================
        //        -- 「'100%ジュース'を含むもの」
        //        where xxx like '%100%ジュース%'
        //        =============================================================
        //
        //    なにがまずいかというと、もしデータベース上に「100回回ってから飲むジュース」
        //    というデータが入ってたら、このデータも検索対象になってしまうのである。
        //    「'100%ジュース'を含むもの」という条件からは外れたデータである。
        //    つまりは、ワイルドカード(%や_)も通常の文字として扱いたいこともあるということ。
        //
        //    SQLでは、文字として扱いたい'%'や'_'がある場合に、それらを条件値の中でエスケープする。
        //    そのときエスケープ文字を明示的に指定する。
        // 
        //        [エスケープ付き曖昧検索-ワイルドカード文字をエスケープ]
        //        =============================================================
        //        -- 「'100%ジュース'を含むもの」
        //        where xxx like '%100|%ジュース%' escape '|'
        //        =============================================================
        // 
        //    こうすることで、エスケープ文字でエスケープされた'%'や'_'はワイルドカードではなく、
        //    通常の文字として扱われる。エスケープ文字をエスケープすることも可能。
        //             
        //        [エスケープ付き曖昧検索-エスケープ文字をエスケープ]
        //        =============================================================
        //        -- 「'aaa|bbb'を含むもの」
        //        where xxx like '%aaa||bbb%' escape '|'
        //        =============================================================
        // = = = = = = = = = =/

        // -----------------------------------------------------
        //                                         NotLikeSearch
        //                                         -------------
        /**
         * Query-NotLikeSearch条件の前方一致: setXxx_NotLikeSearch(), option.likePrefix().
         * 会員名称が'S'で始まらない会員を検索。
         */
        [MbUnit.Framework.Test, Quill(Tx.Rollback)]
        public void test_query_NotLikeSearch_likePrefix_Tx() {
            // ## Arrange ##
            MemberCB cb = new MemberCB();

            // *Point!
            LikeSearchOption option = new LikeSearchOption().LikePrefix();
            cb.Query().SetMemberName_NotLikeSearch("S", option);

            // ## Act ##
            ListResultBean<Member> memberList = memberBhv.SelectList(cb);

            // ## Assert ##
            assertNotNull(memberList);
            assertNotSame(0, memberList.Count);
            foreach (Member member in memberList) {
                log("memberName=" + member.MemberName);
                assertFalse(member.MemberName.StartsWith("S"));
            }

            // [Description]
            // A. LikeSearchOptionの指定は必須。(nullは例外)
        }

        // -----------------------------------------------------
        //                                        ExistsSubQuery
        //                                        --------------
        /**
         * Query-ExistsSubQueryで子テーブル(Referrer)の条件で絞り込み: cb.query().existsXxxList().
         * 一回の購入で二点以上の購入をしたことのある会員を検索。
         * Existsの相関サブクエリを使って子テーブルの条件で絞り込む。
         */
        [MbUnit.Framework.Test, Quill(Tx.Rollback)]
        public void test_query_exists_ReferrerCondition_Tx() {
            // ## Arrange ##
            MemberCB cb = new MemberCB();

            // *Point!
            cb.Query().ExistsPurchaseList(delegate(PurchaseCB subCB) {
                subCB.Query().SetPurchaseCount_GreaterThan(2);
            });

            // ## Act ##
            ListResultBean<Member> memberList = memberBhv.SelectList(cb);

            // ## Assert ##
            memberBhv.LoadPurchaseList(memberList, delegate(PurchaseCB subCB) {
                subCB.SetupSelect_Product();
            });

            foreach (Member member in memberList) {
                log("[MEMBER] " + member.MemberId + ", " + member.MemberName);
                IList<Purchase> purchaseList = member.PurchaseList;
                bool existsPurchase = false;
                foreach (Purchase purchase in purchaseList) {
                    Product product = purchase.Product;
                    long? purchaseCount = purchase.PurchaseCount;
                    String productName = product.ProductName;
                    log("    [PURCHASE] " + purchase.PurchaseId + ", " + purchaseCount + ", " + productName);
                    if (purchaseCount.HasValue && purchaseCount > 2) {
                        existsPurchase = true;
                    }
                }
                assertTrue(existsPurchase);
            }
        }

        /**
         * Query-ExistsSubQueryでmany-to-manyの関係のテーブルの条件で絞り込み: cb.query().existsXxxList().
         * 商品名称が'Storm'で始まる商品を購入したことのある会員を検索。
         * Existsの相関サブクエリを使って子テーブルを経由してその親テーブルの条件で絞り込む。
         */
        [MbUnit.Framework.Test, Quill(Tx.Rollback)]
        public void test_query_exists_ManyToManyCondition_Tx() {
            // ## Arrange ##
            MemberCB cb = new MemberCB();

            // *Point!
            cb.Query().ExistsPurchaseList(delegate(PurchaseCB subCB) {
                subCB.Query().QueryProduct().SetProductName_PrefixSearch("Storm");
            });

            // ## Act ##
            ListResultBean<Member> memberList = memberBhv.SelectList(cb);

            // ## Assert ##
            memberBhv.LoadPurchaseList(memberList, delegate(PurchaseCB subCB) {
                subCB.SetupSelect_Product();
            });

            foreach (Member member in memberList) {
                log("[MEMBER] " + member.MemberId + ", " + member.MemberName);
                IList<Purchase> purchaseList = member.PurchaseList;
                bool existsProduct = false;
                foreach (Purchase purchase in purchaseList) {
                    Product product = purchase.Product;
                    long? purchaseCount = purchase.PurchaseCount;
                    String productName = product.ProductName;
                    log("    [PURCHASE] " + purchase.PurchaseId + ", " + purchaseCount + ", " + productName);
                    if (productName.StartsWith("Storm")) {
                        existsProduct = true;
                    }
                }
                assertTrue(existsProduct);
            }
        }

        /**
         * Query-NotExistsSubQueryで子テーブル(Referrer)の条件で絞り込み: cb.query().notExistsXxxList().
         * 一回の購入で二点以上の購入をしたこと「ない」会員を検索。
         * NotExistsの相関サブクエリを使って子テーブルの条件で絞り込む。
         * @since 0.7.5
         */
        [MbUnit.Framework.Test, Quill(Tx.Rollback)]
        public void test_query_notExists_ReferrerCondition_Tx() {
            // ## Arrange ##
            MemberCB cb = new MemberCB();

            // *Point!
            cb.Query().NotExistsPurchaseList(delegate(PurchaseCB subCB) {
                subCB.Query().SetPurchaseCount_GreaterThan(2);
            });

            // ## Act ##
            ListResultBean<Member> memberList = memberBhv.SelectList(cb);

            // ## Assert ##
            memberBhv.LoadPurchaseList(memberList, delegate(PurchaseCB subCB) {
                subCB.SetupSelect_Product();
            });
            foreach (Member member in memberList) {
                log("[MEMBER] " + member.MemberId + ", " + member.MemberName);
                System.Collections.Generic.IList<Purchase> purchaseList = member.PurchaseList;
                bool existsPurchase = false;
                foreach (Purchase purchase in purchaseList) {
                    Product product = purchase.Product;
                    long? purchaseCount = purchase.PurchaseCount;
                    String productName = product.ProductName;
                    log("    [PURCHASE] " + purchase.PurchaseId + ", " + purchaseCount + ", " + productName);
                    if (purchaseCount > 2) {
                        existsPurchase = true;
                    }
                }
                assertFalse(existsPurchase);
            }
        }

        // -----------------------------------------------------
        //                                       InScopeSubQuery
        //                                       ---------------
        /**
         * Query-InScopeSubQueryで子テーブル(Referrer)の条件で絞り込み: cb.query().inScopeXxxList().
         * 一回の購入で二点以上の購入をしたことのある会員を検索。
         * InScopeのサブクエリを使って子テーブルの条件で絞り込む。
         */
        [MbUnit.Framework.Test, Quill(Tx.Rollback)]
        public void test_query_inScope_ReferrerCondition_Tx() {
            // ## Arrange ##
            MemberCB cb = new MemberCB();

            // *Point!
            cb.Query().InScopePurchaseList(delegate(PurchaseCB subCB) {
                subCB.Query().SetPurchaseCount_GreaterThan(2);
            });

            // ## Act ##
            ListResultBean<Member> memberList = memberBhv.SelectList(cb);

            // ## Assert ##
            memberBhv.LoadPurchaseList(memberList, delegate(PurchaseCB subCB) {
                subCB.SetupSelect_Product();
            });

            foreach (Member member in memberList) {
                log("[MEMBER] " + member.MemberId + ", " + member.MemberName);
                IList<Purchase> purchaseList = member.PurchaseList;
                bool existsPurchase = false;
                foreach (Purchase purchase in purchaseList) {
                    Product product = purchase.Product;
                    long? purchaseCount = purchase.PurchaseCount;
                    String productName = product.ProductName;
                    log("    [PURCHASE] " + purchase.PurchaseId + ", " + purchaseCount + ", " + productName);
                    if (purchaseCount.HasValue && purchaseCount > 2) {
                        existsPurchase = true;
                    }
                }
                assertTrue(existsPurchase);
            }

            // [Description]
            // A. ExistsSubQueryと結果は全く同じになる。
            //    --> 実行計画が変わる可能性あり
        }

        /**
         * Query-InScopeSubQueryでmany-to-manyの関係のテーブルの条件で絞り込み: cb.query().inScopeXxxList().
         * 商品名称が'Storm'で始まる商品を購入したことのある会員を検索。
         * InScopeのサブクエリを使って子テーブルを経由してその親テーブルの条件で絞り込む。
         */
        [MbUnit.Framework.Test, Quill(Tx.Rollback)]
        public void test_query_inScope_ManyToManyCondition_Tx() {
            // ## Arrange ##
            MemberCB cb = new MemberCB();

            // *Point!
            cb.Query().InScopePurchaseList(delegate(PurchaseCB subCB) {
                subCB.Query().QueryProduct().SetProductName_PrefixSearch("Storm");
            });

            // ## Act ##
            ListResultBean<Member> memberList = memberBhv.SelectList(cb);

            // ## Assert ##
            memberBhv.LoadPurchaseList(memberList, delegate(PurchaseCB subCB) {
                subCB.SetupSelect_Product();
            });

            foreach (Member member in memberList) {
                log("[MEMBER] " + member.MemberId + ", " + member.MemberName);
                IList<Purchase> purchaseList = member.PurchaseList;
                bool existsProduct = false;
                foreach (Purchase purchase in purchaseList) {
                    Product product = purchase.Product;
                    long? purchaseCount = purchase.PurchaseCount;
                    String productName = product.ProductName;
                    log("    [PURCHASE] " + purchase.PurchaseId + ", " + purchaseCount + ", " + productName);
                    if (productName.StartsWith("Storm")) {
                        existsProduct = true;
                    }
                }
                assertTrue(existsProduct);
            }

            // [Description]
            // A. ExistsSubQueryと結果は全く同じになる。
            //    --> 実行計画が変わる可能性あり
        }

        /**
         * Query-NotInScopeSubQueryで子テーブル(Referrer)の条件で絞り込み: cb.query().notInScopeXxxList().
         * 一回の購入で二点以上の購入をしたこと「ない」会員を検索。
         * NotInScopeのサブクエリを使って子テーブルの条件で絞り込む。
         * @since 0.7.5
         */
        [MbUnit.Framework.Test, Quill(Tx.Rollback)]
        public void test_query_notInScope_ReferrerCondition_Tx() {
            // ## Arrange ##
            MemberCB cb = new MemberCB();

            // *Point!
            cb.Query().NotInScopePurchaseList(delegate(PurchaseCB subCB) {
                subCB.Query().SetPurchaseCount_GreaterThan(2);
            });

            // ## Act ##
            ListResultBean<Member> memberList = memberBhv.SelectList(cb);

            // ## Assert ##
            memberBhv.LoadPurchaseList(memberList, delegate(PurchaseCB subCB) {
                subCB.SetupSelect_Product();
            });
            foreach (Member member in memberList) {
                log("[MEMBER] " + member.MemberId + ", " + member.MemberName);
                System.Collections.Generic.IList<Purchase> purchaseList = member.PurchaseList;
                bool existsPurchase = false;
                foreach (Purchase purchase in purchaseList) {
                    Product product = purchase.Product;
                    long? purchaseCount = purchase.PurchaseCount;
                    String productName = product.ProductName;
                    log("    [PURCHASE] " + purchase.PurchaseId + ", " + purchaseCount + ", " + productName);
                    if (purchaseCount > 2) {
                        existsPurchase = true;
                    }
                }
                assertFalse(existsPurchase);
            }

            // [Description]
            // A. NotExistsSubQueryと結果は全く同じになる。
            //    --> 実行計画が変わる可能性あり
        }

        // -----------------------------------------------------
        //                                            DateFromTo
        //                                            ----------
        /**
         * Query-DateFromTo(日付の範囲検索): query().setXxx_DateFromTo().
         * '2007/11/26'から'2007/12/01'の期間正式会員になった会員を検索。
         * '2007/12/01'の日に正式会員になった人もちゃんと対象になること。
         * <p>
         * 例えば、日付で範囲検索する画面から条件を入力する場合、終了日に'2007/12/01'と
         * 入れられたら、'2007/12/01 14:23:43'のデータも対象になって欲しいことが多い。
         * しかし、入力された日付でそのままSQLの条件に組み込むと、「less equal '2007/12/01 00:00:00'」
         * となって、'2007/12/01'から一秒でも過ぎたデータが対象にならなくなってしまう。
         * そのため、入力された終了日を加工して、'2007/12/01 23:59:59'とするか、
         * 一日進めて「less than '2007/12/02 00:00:00'」とするかで対応することが多いが、
         * これを都度都度各ディベロッパーが実装すると、実装方法がバラバラになってしまうだけでなく、
         * 細かい日付操作や演算子の調整というところでバグの温床となってしまう。
         * (テストで見つけにくいバグでもあり、とてもやっかいである)
         * このDateFromToを使えば、その細かい日付操作や演算子の調整を安全に実装することができる。
         * </p>
         * <p>
         * DB側では時刻も含めた上で正確な日時として管理しておいて、画面からの検索は時刻無し日付で
         * 範囲検索をするというような状況でとても有効である。特にイベント系の日時ではそういうことが多い。
         * 運用時のいざって時のために時刻を保持しておきたいが、画面からの範囲検索は日付で絞れれば良いという場合である。
         * </p>
         * @since 0.7.6
         */
        [MbUnit.Framework.Test, Quill(Tx.Rollback)]
        public void test_query_DateFromTo_Tx() {
            // ## Arrange ##
            MemberCB cb = new MemberCB();
            DateTime fromDate = new DateTime(2007, 11, 26);
            DateTime toDate = new DateTime(2007, 12, 1);
            cb.Query().SetFormalizedDatetime_DateFromTo(fromDate, toDate);// *Point!

            // ## Act ##
            ListResultBean<Member> memberList = memberBhv.SelectList(cb);

            // ## Assert ##
            assertNotSame(0, memberList.Count);
            foreach (Member member in memberList) {
                log(member.MemberName + ", " + member.FormalizedDatetime);
            }
        }

        // ===============================================================================
        //                                                                           Union
        //                                                                           =====
        /**
         * Union(Or条件の代替): union().
         * 「仮会員」もしくは「会員名称が'St'で始まる」会員を「会員名称の降順」で検索。
         * 関連テーブルとして会員ステータスを取得。
         */
        [MbUnit.Framework.Test, Quill(Tx.Rollback)]
        public void test_union_Tx() {
            MemberCB cb = new MemberCB();
            cb.SetupSelect_MemberStatus();
            cb.Query().SetMemberStatusCode_Equal_Provisional();
            cb.Union(delegate(MemberCB unionCB) {
                unionCB.Query().SetMemberName_PrefixSearch("St");
            });
            cb.Query().AddOrderBy_MemberName_Desc();

            // ## Act ##
            ListResultBean<Member> memberList = memberBhv.SelectList(cb);

            // ## Assert ##
            foreach (Member member in memberList) {
                String memberName = member.MemberName;
                String memberStatusName = member.MemberStatus.MemberStatusName;
                if (!memberName.StartsWith("St")) {
                    log("[Provisional]: " + memberName + ", " + memberStatusName);
                    assertTrue(member.IsMemberStatusCodeProvisional);
                } else if (!member.IsMemberStatusCodeProvisional) {
                    log("[Starts with St]: " + memberName + ", " + memberStatusName);
                    assertTrue(memberName.StartsWith("St"));
                } else {
                    log("[Both]: " + memberName + ", " + memberStatusName);
                }
            }

            // [SQL]
            // select ... 
            //   from MEMBER dflocal 
            //  where dflocal.MEMBER_STATUS_CODE = 'PRV'
            //  union 
            // select ... 
            //   from MEMBER dflocal 
            //  where dflocal.MEMBER_NAME like 'S%'
            //  order by MEMBER_NAME desc

            // [Description]
            // A. ConditionBeanでは自テーブル同士のUnionが可能である。
            // 
            // B. Unionが指定できる回数は無限である。
            // 
            // C. Or条件の代替として利用される。
            //    --> パフォーマンス考慮
            // 
            // D. 条件的に取得するデータがかぶらないのであればunionAll()の方が良い。
            //    --> パフォーマンス考慮
            // 
            // E. Union側のConditionBeanではsetupSelectとaddOrderByを呼び出す必要はない。
            //    --> 絞り込み条件のみ設定すること
            //    --> setupSelectは必ずunion()を呼び出す前に指定すること(フレームワークの都合)
            //    --> addOrderByは必ずunion()を呼び出した後に指定すること(フレームワークの都合)
        }

        /**
         * UnionAll(Or条件の代替): unionAll().
         * 「生年月日が1967/01/01より昔」もしくは「生年月日がnull」の会員を「生年月日の降順、会員名称の昇順」で検索。
         * 互いの条件でデータがかぶらないので、UnionAllを利用。
         */
        [MbUnit.Framework.Test, Quill(Tx.Rollback)]
        public void test_unionAll_Tx() {
            MemberCB cb = new MemberCB();
            cb.Query().SetBirthdate_LessThan(new DateTime(1967, 1, 1));
            cb.UnionAll(delegate(MemberCB unionCB) {
                unionCB.Query().SetBirthdate_IsNull();
            });
            cb.Query().AddOrderBy_Birthdate_Desc();
            cb.Query().AddOrderBy_MemberName_Asc();

            // ## Act ##
            ListResultBean<Member> memberList = memberBhv.SelectList(cb);

            // ## Assert ##
            foreach (Member member in memberList) {
                log("[MEMBER]: " + member.MemberName + ", " + member.Birthdate);
            }

            // [SQL]
            // select ... 
            //   from MEMBER dflocal 
            //  where dflocal.MEMBER_BIRTHDAY < '1967-01-01'
            //  union all
            // select ... 
            //   from MEMBER dflocal 
            //  where dflocal.MEMBER_BIRTHDAY is null 
            //  order by MEMBER_BIRTHDAY desc, MEMBER_NAME asc

            // [Description]
            // A. ConditionBeanでは自テーブル同士のUnionAllが可能である。
            // 
            // B. UnionAllが指定できる回数は無限である。
            // 
            // C. Or条件の代替として利用される。
            //    --> パフォーマンス考慮
            // 
            // D. Union側のConditionBeanではsetupSelectとaddOrderByを呼び出す必要はない。
            //    --> 絞り込み条件のみ設定すること
            //    --> setupSelectは必ずunion()を呼び出す前に指定すること(フレームワークの都合)
            //    --> addOrderByは必ずunion()を呼び出した後に指定すること(フレームワークの都合)
        }

        // ===============================================================================
        //                                                                          Paging
        //                                                                          ======
        /**
         * ページング検索: cb.paging(pageSize, pageNumber).
         * 会員名称の昇順のリストを「１ページ４件」の「３ページ目」(９件目から１２件目)を検索。
         * ※詳しくはBehaviorMiddleTestの「ページング検索: selectPage().」を参照。
         */
        [MbUnit.Framework.Test, Quill(Tx.Rollback)]
        public void test_paging_Tx() {
            // ## Arrange ##
            MemberCB cb = new MemberCB();
            cb.Query().AddOrderBy_MemberName_Asc();
            cb.Paging(4, 3);// The page size is 4 records per 1 page, and The page number is 3.

            // ## Act ##
            PagingResultBean<Member> page3 = memberBhv.SelectPage(cb);

            // ## Assert ##
            assertNotSame(0, page3.Count);
            assertEquals(4, page3.Count);
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
        }

        // ===================================================================================
        //                                                                       Fetch Setting
        //                                                                       =============
        /**
         * 先頭のn件を検索: cb.fetchFirst(fetchSize).
         * 生年月日の降順で先頭の会員を検索。
         */
        [MbUnit.Framework.Test, Quill(Tx.Rollback)]
        public void test_fetchFirst_Tx() {
            // ## Arrange ##
            MemberCB cb = new MemberCB();
            cb.Query().AddOrderBy_Birthdate_Desc().WithNullsLast();
            cb.FetchFirst(1);// *Point!

            // ## Act ##
            Member member = memberBhv.SelectEntityWithDeletedCheck(cb);

            // ## Assert ##
            log(member.MemberName + ", " + member.Birthdate);

            // [Description]
            // A. DBFlute-0.7.3よりサポートされたpaging()メソッドでも同様のことが可能。
            //      paging(1, 1);
            // 
            // B. 引数のfetchSizeは、マイナス値や０が指定されると例外発生
        }

        // ===================================================================================
        //                                                                        Lock Setting
        //                                                                        ============
        /**
         * 更新ロックを取得: cb.lockForUpdate().
         */
        [MbUnit.Framework.Test, Quill(Tx.Rollback)]
        public void test_lockForUpdate_Tx() {
            // ## Arrange ##
            MemberCB cb = new MemberCB();
            cb.Query().SetMemberId_Equal(3);
            cb.LockForUpdate();

            // ## Act ##
            Member member = memberBhv.SelectEntityWithDeletedCheck(cb);

            // ## Assert ##
            assertNotNull(member);
        }

        // ===================================================================================
        //                                                                         Display SQL
        //                                                                         ===========
        /**
         * ConditionBeanで組み立てたSQLをログに表示: toDisplaySql().
         * ConditionBeanで実装していて、途中で外だしSQLで書かなければならないことがわかったときに、
         * その途中まで書いたConditionBeanをベースにSQLを書くことができる。
         * (スムーズに外だしへの移行が可能であり、かつ、SQLも安全に実装できる)
         */
        [MbUnit.Framework.Test, Quill(Tx.Rollback)]
        public void test_toDisplaySql_Tx() {
            // ## Arrange ##
            MemberCB cb = new MemberCB();
            cb.SetupSelect_MemberStatus();
            cb.Query().SetMemberName_LikeSearch("S", new LikeSearchOption().LikePrefix().EscapeByAtMark());
            cb.Query().AddOrderBy_Birthdate_Desc().AddOrderBy_MemberId_Asc();
            cb.LockForUpdate();
            cb.FetchFirst(2);
            cb.FetchPage(3);

            // ## Act ##
            String displaySql = cb.ToDisplaySql();// *Point!

            // ## Assert ##
            StringBuilder sb = new StringBuilder();
            sb.Append("{SQL}" + getLineSeparator());
            sb.Append("***************************************************************");
            sb.Append(getLineSeparator());
            sb.Append(displaySql);
            sb.Append(getLineSeparator());
            sb.Append("**************************************************************");
            log(sb);
            assertTrue(displaySql.Contains("'S%'"));
            assertTrue(displaySql.Contains(" escape '@'"));
            assertTrue(displaySql.Contains("for update"));
            assertTrue(displaySql.Contains(" order by "));
            assertTrue(displaySql.Contains(" rownum "));
        }

        /**
         * ConditionBeanで組み立てたSQLをログに表示(SubQuery含み): toDisplaySql().
         * SubQueryはSQLとしてバグリやすい部分なため、最初から外だしSQLだとわかっていても、
         * ConditionBeanで一度組み立ててからSQLのベースとなる文字列をログから取得するのも良い。
         * SubQueryを含んだSQLも見やすい形でフォーマットされる。
         */
        [MbUnit.Framework.Test, Quill(Tx.Rollback)]
        public void test_toDisplaySql_SubQuery_Tx() {
            MemberCB cb = new MemberCB();
            cb.SetupSelect_MemberStatus();
            cb.Query().ExistsPurchaseList(delegate(PurchaseCB subCB) {
                subCB.Query().SetPurchaseDatetime_LessThan(currentTimestamp());
                subCB.Query().SetPurchaseCount_GreaterEqual(2);
            });

            // ## Act ##
            String displaySql = cb.ToDisplaySql();

            // ## Assert ##
            StringBuilder sb = new StringBuilder();
            sb.Append("{SQL}" + getLineSeparator());
            sb.Append("*******************************************").Append(getLineSeparator());
            sb.Append(displaySql + getLineSeparator());
            sb.Append("*******************************************");
            log(sb);
            assertTrue(displaySql.Contains(">= 2"));
            assertTrue(displaySql.Contains(" exists "));

            // [SQL]
            // select ...
            //   from MEMBER dflocal
            //     left outer join MEMBER_STATUS dfrelation_0 on dflocal.MEMBER_STATUS_CODE = dfrelation_0.MEMBER_STATUS_CODE 
            //  where exists (select dfsublocal_0.MEMBER_ID
            //                  from PURCHASE dfsublocal_0 
            //                 where dfsublocal_0.MEMBER_ID = dflocal.MEMBER_ID
            //                   and dfsublocal_0.PURCHASE_DATETIME < '2008-06-01 05.09.24'
            //                   and dfsublocal_0.PURCHASE_COUNT >= 2
            //        )
        }
    }
}
