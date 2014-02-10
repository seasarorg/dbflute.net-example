using System;
using System.Collections.Generic;
using System.Reflection;
using DfExample.DBFlute.AllCommon;
using DfExample.DBFlute.AllCommon.CBean;
using DfExample.DBFlute.AllCommon.CBean.COption;
using DfExample.DBFlute.AllCommon.Exp;
using DfExample.DBFlute.CBean;
using DfExample.DBFlute.ExBhv;
using DfExample.DBFlute.ExEntity;
using Seasar.Framework.Util;
using Seasar.Quill.Unit;
using Seasar.Extension.Unit;

namespace DfExample.DBFlute.Various.WhiteBox {

    [MbUnit.Framework.TestFixture]
    public class WxCBExistsReferrerTest : ContainerTestCase {

        // ===============================================================================
        //                                                                       Attribute
        //                                                                       =========
        protected MemberBhv _memberBhv;

        // ===============================================================================
        //                                                                           Basic
        //                                                                           =====
        [MbUnit.Framework.Test, Quill(Tx.Rollback)]
        public void ExistsReferrer_nested() {
            // ## Arrange ##
            MemberCB cb = new MemberCB();
            cb.Query().QueryMemberStatus().ExistsMemberLoginList(
                delegate(MemberLoginCB subCB) {
                    subCB.Query().QueryMember().ExistsPurchaseList(delegate(PurchaseCB subSubCB) {
                                                                       subSubCB.Query().QueryMember().SetMemberStatusCode_Equal_Formalized();
                                                                   });
                });

            // ## Act ##
            ListResultBean<Member> memberList = _memberBhv.SelectList(cb); // expect no exception

            // ## Assert ##
            assertNotSame(0, memberList.Count);
            foreach (Member member in memberList) {
                assertTrue(member.IsMemberStatusCodeFormalized);
            }
        }
    }
}
