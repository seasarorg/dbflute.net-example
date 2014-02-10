using System;
using System.Collections.Generic;
using System.Text;
using DfExample.DBFlute.CBean;
using DfExample.DBFlute.ExBhv;
using DfExample.DBFlute.ExDao.PmBean;
using DfExample.DBFlute.ExEntity;
using DfExample.DBFlute.ExEntity.Customize;
using Seasar.Quill.Unit;
using Seasar.Extension.Unit;

namespace DfExample.DBFlute.Various
{
    [MbUnit.Framework.TestFixture]
    public class VendorTypeTest : ContainerTestCase {

        // ===============================================================================
        //                                                                       Attribute
        //                                                                       =========
        protected VendorCheckBhv _vendorCheckBhv;
        protected MemberBhv _memberBhv;
        protected MemberWithdrawalBhv _memberWithdrawalBhv;

        // ===============================================================================
        //                                                                     String Type
        //                                                                     ===========
        // -------------------------------------------------
        //                                              CLOB
        //                                              ----
        [MbUnit.Framework.Test, Quill(Tx.Rollback)]
        public void Select_Update_CLOB_largeSize() {
            // ## Arrange ##
            MemberWithdrawal withdrawal = new MemberWithdrawal();
            withdrawal.MemberId = 3L;
            withdrawal.WithdrawalDatetime = currentTimestamp();
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < 1000; i++) {
                sb.Append("1234567890");
            }
            withdrawal.WithdrawalReasonInputText = sb.ToString();
            _memberWithdrawalBhv.InsertOrUpdateNonstrict(withdrawal);

            MemberWithdrawalCB cb = new MemberWithdrawalCB();
            cb.Specify().ColumnWithdrawalReasonInputText();
            cb.Query().SetMemberId_Equal(3L);

            // ## Act ##
            MemberWithdrawal actualWithdrawal = _memberWithdrawalBhv.SelectEntity(cb);

            // ## Assert ##
            assertNotNull(actualWithdrawal);
            String actualText = actualWithdrawal.WithdrawalReasonInputText;
            assertNotNull(actualText);
            assertEquals(sb.ToString().Length, actualText.Length);
        }
    }
}
