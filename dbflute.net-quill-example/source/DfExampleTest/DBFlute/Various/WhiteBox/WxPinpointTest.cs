using System;
using System.Collections.Generic;
using System.Reflection;
using DfExample.DBFlute.AllCommon;
using DfExample.DBFlute.AllCommon.CBean;
using DfExample.DBFlute.AllCommon.Util;
using DfExample.DBFlute.CBean;
using DfExample.DBFlute.ExBhv;
using DfExample.DBFlute.ExEntity;
using Seasar.Framework.Util;
using Seasar.Quill.Unit;
using Seasar.Extension.Unit;

namespace DfExample.DBFlute.Various.WhiteBox {

    [MbUnit.Framework.TestFixture]
    public class TxPinpointTest : ContainerTestCase {

        // ===============================================================================
        //                                                                       Attribute
        //                                                                       =========
        protected MemberBhv _memberBhv;

        // ===============================================================================
        //                                                                   Load Referrer
        //                                                                   =============
        [MbUnit.Framework.Test, Quill(Tx.Rollback)]
        public void LoadReferrer_One_Entity() {
            // ## Arrange ##
            MemberCB cb = new MemberCB();
            cb.Query().SetMemberId_Equal(3);

            // At first, it selects the list of Member.
            Member member = _memberBhv.SelectEntity(cb);

            // ## Act ##
            // And it loads the list of Purchase with its conditions.
            _memberBhv.LoadPurchaseList(member, delegate(PurchaseCB subCB) {
                subCB.Query().SetPurchaseCount_GreaterEqual(2);
                subCB.Query().AddOrderBy_PurchaseCount_Desc();
            });

            // ## Assert ##
            log("[MEMBER]: " + member.MemberName);
            IList<Purchase> purchaseList = member.PurchaseList;// *Point!
            foreach (Purchase purchase in purchaseList) {
                log("    [PURCHASE]: " + purchase.ToString());
            }
        }

        // ===============================================================================
        //                                                        (Specify)DerivedReferrer
        //                                                        ========================
        [MbUnit.Framework.Test, Quill(Tx.Rollback)]
        public void DerivedReferrer_SepcifidDerivedOrderBy_other_Union() {
            // ## Arrange ##
            MemberCB cb = new MemberCB();
            cb.Specify().DerivedMemberLoginList().Count(delegate(MemberLoginCB subCB) {
                subCB.Specify().ColumnMemberLoginId(); // *Point!
                subCB.Query().SetMobileLoginFlg_Equal_False(); // Except Mobile
            }, Member.PROP_LoginCount);
            cb.Union(delegate(MemberCB unionCB) {
                unionCB.Query().SetMemberStatusCode_Equal_Withdrawal();
            });
            cb.Query().AddSpecifiedDerivedOrderBy_Desc(Member.PROP_LoginCount);
            cb.Query().AddOrderBy_MemberId_Asc();

            // ## Act ##
            ListResultBean<Member> memberList = _memberBhv.SelectList(cb);

            // ## Assert ##
            assertNotSame(0, memberList.Count);
            foreach (Member member in memberList) {
                String memberName = member.MemberName;
                int? loginCount = member.LoginCount;
                assertNotNull(loginCount); // count()Ç»ÇÃÇ≈0åèÇÃèÍçáÇÕ0Ç…Ç»ÇÈ(DBéüëÊÇ©Ç‡...)
                log("memberName=" + memberName + ", loginCount=" + loginCount);
            }
        }

        // ===============================================================================
        //                                                                    Query Update
        //                                                                    ============
        [MbUnit.Framework.Test, Quill(Tx.Rollback)]
        public void QueryUpdate_no_condition() {
            // ## Arrange ##
            Member member = new Member();
            member.SetMemberStatusCode_Provisional();
            member.FormalizedDatetime = null;

            MemberCB cb = new MemberCB();

            // ## Act ##
            int updatedCount = _memberBhv.QueryUpdate(member, cb);

            // ## Assert ##
            assertNotSame(0, updatedCount);
            MemberCB actualCB = new MemberCB();
            ListResultBean<Member> actualList = _memberBhv.SelectList(actualCB);
            assertNotSame(0, actualList.Count);
            foreach (Member actual in actualList)
            {
                assertTrue(actual.IsMemberStatusCodeProvisional);
                assertNull(actual.FormalizedDatetime);
            }
        }

        // ===============================================================================
        //                                                                      OutsideSql
        //                                                                      ==========
        [MbUnit.Framework.Test, Quill(Tx.Rollback)]
        public void DotDotDirectory() {
            Assembly asm = typeof(Entity).Assembly;
            {
                String path = "DfExample.DBFlute.TestDir.NonDot.testfile.sql";
                assertTrue(IsExistResource(path, asm));
            }
            {
                String path = "DfExample.DBFlute.TestDir.Dot.Dot.testfile.sql";
                assertTrue(IsExistResource(path, asm));
            }
        }

        protected virtual bool IsExistResource(String path, Assembly asm) {
            return ResourceUtil.IsExist(path, asm);
        }

        // ===============================================================================
        //                                                                  Classification
        //                                                                  ==============
        [MbUnit.Framework.Test, Quill(Tx.Rollback)]
        public void FindClassificationName() {
            // ## Arrange ##
            Member member = new Member();
            member.SetMemberStatusCode_Formalized();

            // ## Act ##
            String name = member.MemberStatusCodeName;

            // ## Assert ##
            Log("name = " + name);
            assertNotNull(name);
        }
        [MbUnit.Framework.Test, Quill(Tx.Rollback)]
        public void FindClassificationAlias() {
            // ## Arrange ##
            Member member = new Member();
            member.SetMemberStatusCode_Formalized();

            // ## Act ##
            String alias = member.MemberStatusCodeAlias;

            // ## Assert ##
            Log("alias = " + alias);
            assertNotNull(alias);
        }

        // ===============================================================================
        //                                                         Myself InScope SubQuery
        //                                                         =======================
        [MbUnit.Framework.Test, Quill(Tx.Rollback)]
        public void MyselfInScopeSubQuery_basic() {
            // ## Arrange ##
            MemberCB cb = new MemberCB();
            cb.Query().MyselfInScope(delegate(MemberCB subCB) {
                 subCB.Query().SetMemberName_PrefixSearch("S");
                 subCB.Union(delegate(MemberCB unionCB) {
                     unionCB.Query().SetMemberStatusCode_Equal_Formalized();
                 });
            });
            cb.Query().AddOrderBy_Birthdate_Desc();

            // ## Act ##
            ListResultBean<Member> memberList = _memberBhv.SelectList(cb);

            // ## Assert ##
            assertNotSame(0, memberList.Count);
            bool existsStartsWithS = false;
            bool existsFormalized = false;
            foreach (Member member in memberList) {
                String memberName = member.MemberName;
                if (memberName.StartsWith("S")) {
                    existsStartsWithS = true;
                    continue;
                }
                if (member.IsMemberStatusCodeFormalized) {
                    existsFormalized = true;
                    continue;
                }
                fail("The member was not expected: " + member);
            }
            assertTrue(existsStartsWithS);
            assertTrue(existsFormalized);
        }

        [MbUnit.Framework.Test, Quill(Tx.Rollback)]
        public void MyselfInScopeSubQuery_foreign() {
            // ## Arrange ##
            MemberCB cb = new MemberCB();
            cb.Query().QueryMemberStatus().MyselfInScope(delegate(MemberStatusCB subCB) {
                subCB.Query().SetMemberStatusCode_Equal_Formalized();
                subCB.Union(delegate(MemberStatusCB unionCB) {
                    unionCB.Query().SetMemberStatusCode_Equal_Provisional();
                });
                subCB.Query().ExistsMemberList(delegate(MemberCB subSubCB) {
                    subSubCB.Query().SetMemberStatusCode_NotEqual_Withdrawal();
                });
            });
            cb.Query().AddOrderBy_Birthdate_Desc();
            
            // ## Act ##
            ListResultBean<Member> memberList = _memberBhv.SelectList(cb);
            
            // ## Assert ##
            assertNotSame(0, memberList.Count);
            bool existsFormalized = false;
            bool existsProvisional = false;
            foreach (Member member in memberList) {
                if (member.IsMemberStatusCodeFormalized) {
                    existsFormalized = true;
                    continue;
                }
                if (member.IsMemberStatusCodeProvisional) {
                    existsProvisional = true;
                    continue;
                }
                fail("The member was not expected: " + member);
            }
            assertTrue(existsFormalized);
            assertTrue(existsProvisional);
        }
    }
}
