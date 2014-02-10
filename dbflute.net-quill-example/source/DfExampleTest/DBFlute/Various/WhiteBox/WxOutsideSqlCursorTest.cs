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
using DfExample.DBFlute.ExDao.Cursor;
using DfExample.DBFlute.ExDao.PmBean;
using DfExample.DBFlute.ExEntity;
using Seasar.Framework.Util;
using Seasar.Quill.Unit;
using Seasar.Extension.Unit;

namespace DfExample.DBFlute.Various.WhiteBox {

    [MbUnit.Framework.TestFixture]
    public class WxOutsideSqlCursorTest : ContainerTestCase {

        // ===============================================================================
        //                                                                       Attribute
        //                                                                       =========
        protected MemberBhv _memberBhv;
        protected PurchaseBhv _purchaseBhv;

        // ===============================================================================
        //                                                                   Entity Update
        //                                                                   =============
        [MbUnit.Framework.Test, Quill(Tx.Rollback)]
        public void SelectCursor_InsertInLoop() {
            // ## Arrange ##
            String path = MemberBhv.PATH_selectPurchaseSummaryMember;
            PurchaseSummaryMemberPmb pmb = new PurchaseSummaryMemberPmb();
            pmb.SetMemberStatusCode_Formalized();
            Set<int?> markSet = new DfExample.DBFlute.AllCommon.JavaLike.HashSet<int?>();
            _memberBhv.OutsideSql().CursorHandling().SelectCursor(path, pmb, new PurchaseSummaryMemberCursorHandler(
                delegate(PurchaseSummaryMemberCursor cursor) {
                    while (cursor.Next()) {
                        int? memberId = cursor.MemberId;
                        markSet.add(memberId);
                        
                        // ## Act ##
                        try {
                            Purchase purchase = new Purchase();
                            purchase.MemberId = memberId;
                            purchase.PurchaseDatetime = currentTimestamp();
                            purchase.PurchaseCount = 3;
                            purchase.PurchasePrice = 2000;
                            purchase.SetPaymentCompleteFlg_True();
                            _purchaseBhv.Insert(purchase);

                            // ## Arrange ##
                            _purchaseBhv.SelectByPKValueWithDeletedCheck(purchase.PurchaseId);

                            fail();
                        } catch (SQLFailureException e) { // unsupported on MySQL
                            // OK
                            log(e.Message);
                        }
                    }
                    return null;
                }));
            assertFalse(markSet.isEmpty());
        }
    }
}
