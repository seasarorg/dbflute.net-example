using System;
using System.Collections.Generic;
using System.Reflection;
using DfExample.DBFlute.AllCommon;
using DfExample.DBFlute.AllCommon.CBean;
using DfExample.DBFlute.AllCommon.Exp;
using DfExample.DBFlute.AllCommon.JavaLike;
using DfExample.DBFlute.BsEntity.Dbm;
using DfExample.DBFlute.CBean;
using DfExample.DBFlute.ExBhv;
using DfExample.DBFlute.ExEntity;
using Seasar.Framework.Util;
using Seasar.Quill.Unit;
using Seasar.Extension.Unit;

namespace DfExample.DBFlute.Various.WhiteBox {

    [MbUnit.Framework.TestFixture]
    public class WxBehaviorTest : ContainerTestCase {

        // ===============================================================================
        //                                                                       Attribute
        //                                                                       =========
        protected MemberBhv _memberBhv;
        protected MemberStatusBhv _memberStatusBhv;

        // ===============================================================================
        //                                                                   Entity Update
        //                                                                   =============
        [MbUnit.Framework.Test, Quill(Tx.Rollback)]
        public void Update_nonOptimisticLockTable_deleted() {
            // ## Arrange ##
            MemberStatus memberStatus = new MemberStatus();
            memberStatus.MemberStatusCode = "NON";
            memberStatus.DisplayOrder = 8;

            // ## Act ##
            try {
                _memberStatusBhv.Update(memberStatus);

                // ## Assert ##
                fail();
            } catch (EntityAlreadyDeletedException e) {
                // OK
                log(e.Message);
            }
        }

        [MbUnit.Framework.Test, Quill(Tx.Rollback)]
        public void Delete_nonOptimisticLockTable_deleted() {
            // ## Arrange ##
            MemberStatus memberStatus = new MemberStatus();
            memberStatus.MemberStatusCode = "NON";

            // ## Act ##
            try {
                _memberStatusBhv.Delete(memberStatus);

                // ## Assert ##
                fail();
            } catch (EntityAlreadyDeletedException e) {
                // OK
                log(e.Message);
            }
        }

        // ===============================================================================
        //                                                                   Load Referrer
        //                                                                   =============
        [MbUnit.Framework.Test, Quill(Tx.Rollback)]
        public void LoadReferrer_Union_QuerySynchronization() {
            // ## Arrange ##
            MemberCB cb = new MemberCB();
            cb.Query().SetMemberName_PrefixSearch("S");
            cb.Query().AddOrderBy_Birthdate_Desc().WithNullsLast();

            // ## Act ##
            ListResultBean<Member> memberList = _memberBhv.SelectList(cb);
            assertNotSame(0, memberList.Count);
            _memberBhv.LoadPurchaseList(memberList, delegate(PurchaseCB referrerCB) {
                referrerCB.Query().SetPurchasePrice_GreaterEqual(1800);
                referrerCB.Union(delegate(PurchaseCB unionCB) {
                    // ## Assert ##
                    String msgWhere = "The union CB should have FK inScope: " + unionCB;
                    assertTrue(msgWhere, unionCB.HasWhereClause());
                    String msgOrderBy = "The union CB should not have order-by clause: " + unionCB;
                    assertFalse(msgOrderBy, unionCB.HasOrderByClause());
                    assertTrue(unionCB.ToDisplaySql().Contains(" in ("));
                    unionCB.Query().SetPaymentCompleteFlg_Equal_False();
                });
                referrerCB.UnionAll(delegate(PurchaseCB unionCB) {
                    // ## Assert ##
                    String msgWhere = "The union CB should have FK inScope: " + unionCB;
                    assertTrue(msgWhere, unionCB.HasWhereClause());
                    String msgOrderBy = "The union CB should not have order-by clause: " + unionCB;
                    assertFalse(msgOrderBy, unionCB.HasOrderByClause());
                    assertTrue(unionCB.ToDisplaySql().Contains(" in ("));
                    unionCB.Query().SetPurchaseCount_GreaterEqual(2);
                });
                referrerCB.Query().AddOrderBy_PurchaseDatetime_Desc().AddOrderBy_ProductId_Asc();
            });
            bool exists = false;
            foreach (Member member in memberList) {
                log(member.ToStringWithRelation());
                IList<Purchase> purchaseList = member.PurchaseList;
                if (purchaseList.Count > 0) {
                    exists = true;
                }
            }
            assertTrue(exists);
        }
    }
}
