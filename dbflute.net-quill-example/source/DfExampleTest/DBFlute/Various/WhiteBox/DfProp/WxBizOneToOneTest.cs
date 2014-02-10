using System;
using System.Collections.Generic;
using System.Reflection;
using DfExample.DBFlute.AllCommon;
using DfExample.DBFlute.AllCommon.CBean;
using DfExample.DBFlute.AllCommon.Exp;
using DfExample.DBFlute.AllCommon.JavaLike;
using DfExample.DBFlute.AllCommon.Util;
using DfExample.DBFlute.BsEntity.Dbm;
using DfExample.DBFlute.CBean;
using DfExample.DBFlute.ExBhv;
using DfExample.DBFlute.ExEntity;
using Seasar.Framework.Util;
using Seasar.Quill.Unit;
using Seasar.Extension.Unit;

namespace DfExample.DBFlute.Various.WhiteBox.DfProp {

    [MbUnit.Framework.TestFixture]
    public class WxBizOneToOneTest : ContainerTestCase {

        // ===============================================================================
        //                                                                       Attribute
        //                                                                       =========
        protected MemberBhv _memberBhv;
        protected PurchaseBhv _purchaseBhv;

        // ===============================================================================
        //                                                                   Over Relation
        //                                                                   =============
        // -----------------------------------------------------
        //                                         Local Foreign
        //                                         -------------
        [MbUnit.Framework.Test, Quill(Tx.Rollback)]
        public void test_BizOneToOne_overRelation_LocalForeign_basic_Tx() {
            // ## Arrange ##
            MemberCB cb = new MemberCB();
            cb.SetupSelect_MemberLoginAsLocalForeignOverTest();

            // ## Act ##
            _memberBhv.SelectList(cb); // expect no exception

            // ## Assert ##
            String displaySql = cb.ToDisplaySql();
            assertTrue(displaySql.ToLower().Contains("left outer join member_status"));
            assertTrue(displaySql.Contains(".MEMBER_STATUS_NAME"));
            assertFalse(displaySql.Contains("$$"));
            assertFalse(displaySql.Contains("over("));
        }

        [MbUnit.Framework.Test, Quill(Tx.Rollback)]
        public void test_BizOneToOne_overRelation_LocalForeign_nest_Tx() {
            // ## Arrange ##
            PurchaseCB cb = new PurchaseCB();
            cb.SetupSelect_Member().WithMemberLoginAsLocalForeignOverTest();

            // ## Act ##
            _purchaseBhv.SelectList(cb); // expect no exception

            // ## Assert ##
            String displaySql = cb.ToDisplaySql();
            assertTrue(displaySql.ToLower().Contains("left outer join member_status"));
            assertTrue(displaySql.Contains(".MEMBER_STATUS_NAME"));
            assertFalse(displaySql.Contains("$$"));
            assertFalse(displaySql.Contains("over("));
        }

        [MbUnit.Framework.Test, Quill(Tx.Rollback)]
        public void test_BizOneToOne_overRelation_LocalForeign_setup_Tx() {
            // ## Arrange ##
            MemberCB cb = new MemberCB();
            cb.SetupSelect_MemberStatus();
            cb.SetupSelect_MemberLoginAsLocalForeignOverTest();

            // ## Act ##
            _memberBhv.SelectList(cb); // expect no exception

            // ## Assert ##
            String displaySql = cb.ToDisplaySql();
            assertTrue(displaySql.ToLower().Contains("left outer join member_status"));
            assertTrue(displaySql.Contains(".MEMBER_STATUS_NAME"));
            assertFalse(displaySql.Contains("$$"));
            assertFalse(displaySql.Contains("over("));
        }

        [MbUnit.Framework.Test, Quill(Tx.Rollback)]
        public void test_BizOneToOne_overRelation_LocalForeign_subQuery_Tx() {
            // ## Arrange ##
            MemberCB cb = new MemberCB();
            cb.Query().ExistsPurchaseList(delegate(PurchaseCB subCB) {
                subCB.Query().QueryMember().QueryMemberLoginAsLocalForeignOverTest().SetMobileLoginFlg_Equal_True();
            });

            // ## Act ##
            _memberBhv.SelectList(cb); // expect no exception

            // ## Assert ##
            String displaySql = cb.ToDisplaySql();
            assertTrue(displaySql.ToLower().Contains("left outer join member_status"));
            assertTrue(displaySql.Contains("exists (select"));
            assertTrue(displaySql.Contains(".MEMBER_STATUS_NAME"));
            assertFalse(displaySql.Contains("$$"));
            assertFalse(displaySql.Contains("over("));
        }

        [MbUnit.Framework.Test, Quill(Tx.Rollback)]
        public void test_BizOneToOne_overRelation_LocalForeign_with_otherOvers_Tx() {
            // ## Arrange ##
            PurchaseCB cb = new PurchaseCB();
            cb.SetupSelect_Member().WithMemberLoginAsLocalForeignOverTest();
            cb.SetupSelect_Member().WithMemberLoginAsReferrerForeignOverTest().WithMemberStatus();
            cb.SetupSelect_Product().WithProductStatus();
            cb.SetupSelect_Member().WithMemberLoginAsForeignForeignParameterOverTest(new DateTime(2010, 10, 12)).WithMemberStatus();

            // ## Act ##
            _purchaseBhv.SelectList(cb); // expect no exception

            // ## Assert ##
            String displaySql = cb.ToDisplaySql();
            assertTrue(displaySql.ToLower().Contains("left outer join member_status"));
            assertTrue(displaySql.Contains("BIRTHDATE > '2010-10-12'"));
            assertTrue(displaySql.Contains(".MEMBER_STATUS_NAME"));
            assertFalse(displaySql.Contains("$$"));
            assertFalse(displaySql.Contains("over("));
        }

        // -----------------------------------------------------
        //                                       Foreign Foreign
        //                                       ---------------
        [MbUnit.Framework.Test, Quill(Tx.Rollback)]
        public void test_BizOneToOne_overRelation_ForeignForeign_basic_Tx() {
            // ## Arrange ##
            MemberCB cb = new MemberCB();
            cb.SetupSelect_MemberLoginAsForeignForeignOverTest();

            // ## Act ##
            _memberBhv.SelectList(cb); // expect no exception

            // ## Assert ##
            String displaySql = cb.ToDisplaySql();
            assertTrue(displaySql.ToLower().Contains("left outer join member_status dfrel"));
            assertTrue(displaySql.ToLower().Contains("left outer join member_status dffixedjoin"));
            assertTrue(displaySql.Contains(".DISPLAY_ORDER = "));
            assertFalse(displaySql.Contains("$$"));
            assertFalse(displaySql.Contains("over("));
        }

        [MbUnit.Framework.Test, Quill(Tx.Rollback)]
        public void test_BizOneToOne_overRelation_ForeignForeign_withNormalInlineView_Tx() {
            // ## Arrange ##
            MemberCB cb = new MemberCB();
            cb.SetupSelect_MemberLoginAsForeignForeignOverTest();
            cb.Query().QueryMemberLoginAsForeignForeignOverTest().Inline().SetMobileLoginFlg_Equal_True();

            // ## Act ##
            _memberBhv.SelectList(cb); // expect no exception

            // ## Assert ##
            String displaySql = cb.ToDisplaySql();
            assertTrue(displaySql.ToLower().Contains("left outer join member_status dfrel_0"));
            assertTrue(displaySql.ToLower().Contains("left outer join member_status dffixedjoin"));
            assertTrue(displaySql.Contains(".DISPLAY_ORDER = "));
            assertTrue(displaySql.Contains("where MOBILE_LOGIN_FLG = 1"));
            assertFalse(displaySql.Contains("$$"));
            assertFalse(displaySql.Contains("over("));
        }

        [MbUnit.Framework.Test, Quill(Tx.Rollback)]
        public void test_BizOneToOne_overRelation_ForeignForeign_withNormalOnClause_Tx() {
            // ## Arrange ##
            MemberCB cb = new MemberCB();
            cb.SetupSelect_MemberLoginAsForeignForeignOverTest();
            cb.Query().QueryMemberLoginAsForeignForeignOverTest().On().SetMobileLoginFlg_Equal_True();

            // ## Act ##
            _memberBhv.SelectList(cb); // expect no exception

            // ## Assert ##
            String displaySql = cb.ToDisplaySql();
            assertTrue(displaySql.ToLower().Contains("left outer join member_status dfrel_0"));
            assertTrue(displaySql.ToLower().Contains("left outer join member_status dffixedjoin"));
            assertTrue(displaySql.Contains(".DISPLAY_ORDER = "));
            assertTrue(displaySql.Contains(".MOBILE_LOGIN_FLG = 1"));
            assertFalse(displaySql.Contains("$$"));
            assertFalse(displaySql.Contains("over("));
        }

        [MbUnit.Framework.Test, Quill(Tx.Rollback)]
        public void test_BizOneToOne_overRelation_ForeignForeignParameter_useSecondArg_Tx() {
            // ## Arrange ##
            MemberCB cb = new MemberCB();
            cb.SetupSelect_MemberLoginAsForeignForeignParameterOverTest(new DateTime(2010, 10, 12));

            // ## Act ##
            _memberBhv.SelectList(cb); // expect no exception

            // ## Assert ##
            String displaySql = cb.ToDisplaySql();
            assertTrue(displaySql.ToLower().Contains("left outer join member_status dfrel_0"));
            assertTrue(displaySql.ToLower().Contains("left outer join member_status dffixedjoin"));
            assertTrue(displaySql.Contains(".DISPLAY_ORDER = "));
            assertTrue(displaySql.Contains("as STATUS_ORDER"));
            assertTrue(displaySql.Contains(".STATUS_ORDER"));
            assertTrue(displaySql.Contains("and dfloc.BIRTHDATE > '2010-10-12'"));
            assertFalse(displaySql.Contains("$$"));
            assertFalse(displaySql.Contains("over("));
        }

        [MbUnit.Framework.Test, Quill(Tx.Rollback)]
        public void test_BizOneToOne_overRelation_ForeignForeignParameter_doubleOver_Tx() {
            // ## Arrange ##
            MemberCB cb = new MemberCB();
            cb.SetupSelect_MemberLoginAsForeignForeignOverTest();
            cb.SetupSelect_MemberLoginAsForeignForeignParameterOverTest(new DateTime(2010, 10, 12));

            // ## Act ##
            _memberBhv.SelectList(cb); // expect no exception

            // ## Assert ##
            String displaySql = cb.ToDisplaySql();
            assertTrue(displaySql.ToLower().Contains("left outer join member_status dfrel_0"));
            assertTrue(displaySql.ToLower().Contains("left outer join member_status dffixedjoin"));
            assertTrue(displaySql.Contains(".DISPLAY_ORDER = "));
            assertTrue(displaySql.Contains("as STATUS_ORDER"));
            assertTrue(displaySql.Contains(".STATUS_ORDER"));
            assertTrue(displaySql.Contains("and dfloc.BIRTHDATE > '2010-10-12'"));
            assertFalse(displaySql.Contains("$$"));
            assertFalse(displaySql.Contains("over("));
        }

        [MbUnit.Framework.Test, Quill(Tx.Rollback)]
        public void test_BizOneToOne_overRelation_ForeignForeignVarious_basic_Tx() {
            // ## Arrange ##
            PurchaseCB cb = new PurchaseCB();
            cb.SetupSelect_Member().WithMemberLoginAsForeignForeignVariousOverTest();

            // ## Act ##
            _purchaseBhv.SelectList(cb); // expect no exception

            // ## Assert ##
            String displaySql = cb.ToDisplaySql();
            IndexOfInfo inlineIndex = Srl.indexOfFirst(displaySql, "left outer join (");
            assertNotNull(inlineIndex);
            String front = inlineIndex.substringFront();
            String rear = inlineIndex.substringRear();
            assertEquals(1, Srl.countIgnoreCase(front, "left outer join product "));
            assertEquals(1, Srl.countIgnoreCase(front, "left outer join product_status "));
            assertEquals(1, Srl.countIgnoreCase(front, "left outer join member "));
            assertEquals(2, Srl.countIgnoreCase(rear, "left outer join member_status "));
            assertEquals(1, Srl.countIgnoreCase(rear, "left outer join member "));
            assertEquals(1, Srl.countIgnoreCase(rear, "left outer join member_withdrawal "));
            assertEquals(1, Srl.countIgnoreCase(rear, "left outer join withdrawal_reason "));
            assertTrue(rear.Contains(".STATUS_ORDER is not null"));
            assertTrue(rear.Contains(".MEMBER_STATUS_NAME is not null"));
            assertTrue(rear.Contains(".DISPLAY_ORDER is not null"));
            assertTrue(rear.Contains(".WITHDRAWAL_DATETIME is not null"));
            assertTrue(rear.Contains(".REASON_ORDER is not null"));
            assertTrue(rear.Contains(".PRODUCT_STATUS_NAME is not null"));
            assertFalse(displaySql.Contains("$$"));
            assertFalse(displaySql.Contains("over("));
        }

        // -----------------------------------------------------
        //                                              Referrer
        //                                              --------
        [MbUnit.Framework.Test, Quill(Tx.Rollback)]
        public void test_BizOneToOne_overRelation_Referrer_basic_Tx() {
            // ## Arrange ##
            PurchaseCB cb = new PurchaseCB();
            cb.SetupSelect_Member().WithMemberLoginAsReferrerOverTest();

            // ## Act ##
            _purchaseBhv.SelectList(cb); // expect no exception

            // ## Assert ##
            String displaySql = cb.ToDisplaySql();
            assertTrue(displaySql.ToLower().Contains("left outer join member"));
            assertTrue(displaySql.Contains(".PURCHASE_DATETIME"));
            assertFalse(displaySql.Contains("$$"));
            assertFalse(displaySql.Contains("over("));
        }

        [MbUnit.Framework.Test, Quill(Tx.Rollback)]
        public void test_BizOneToOne_overRelation_ReferrerForeign_basic_Tx() {
            // ## Arrange ##
            PurchaseCB cb = new PurchaseCB();
            cb.SetupSelect_Member().WithMemberLoginAsReferrerForeignOverTest();

            // ## Act ##
            _purchaseBhv.SelectList(cb); // expect no exception

            // ## Assert ##
            String displaySql = cb.ToDisplaySql();
            assertTrue(displaySql.ToLower().Contains("left outer join product_status"));
            assertTrue(displaySql.Contains(".PRODUCT_STATUS_NAME"));
            assertFalse(displaySql.Contains("$$"));
            assertFalse(displaySql.Contains("over("));
        }

        [MbUnit.Framework.Test, Quill(Tx.Rollback)]
        public void test_BizOneToOne_overRelation_ReferrerForeign_setup_Tx() {
            // ## Arrange ##
            PurchaseCB cb = new PurchaseCB();
            cb.SetupSelect_Product().WithProductStatus();
            cb.SetupSelect_Member().WithMemberLoginAsReferrerForeignOverTest();

            // ## Act ##
            _purchaseBhv.SelectList(cb); // expect no exception

            // ## Assert ##
            String displaySql = cb.ToDisplaySql();
            assertTrue(displaySql.ToLower().Contains("left outer join product_status"));
            assertTrue(displaySql.Contains(".PRODUCT_STATUS_NAME"));
            assertFalse(displaySql.Contains("$$"));
            assertFalse(displaySql.Contains("over("));
        }

        [MbUnit.Framework.Test, Quill(Tx.Rollback)]
        public void test_BizOneToOne_overRelation_Referrer_illegal_Tx() {
            // ## Arrange ##
            MemberCB cb = new MemberCB();

            // ## Act ##
            try {
                cb.SetupSelect_MemberLoginAsReferrerOverTest();

                // ## Assert ##
                fail();
            } catch (IllegalStateException e) {
                // OK
                log(e.Message);
            }
        }
    }
}
