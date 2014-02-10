using System;
using System.Collections.Generic;
using System.Text;
using DfExample.DBFlute.AllCommon.Exp;
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
    public class ProcedureTest : ContainerTestCase {

        // ===============================================================================
        //                                                                       Attribute
        //                                                                       =========
        protected VendorCheckBhv _vendorCheckBhv;
        protected MemberBhv _memberBhv;
        protected MemberWithdrawalBhv _memberWithdrawalBhv;

        // ===============================================================================
        //                                                                       Procedure
        //                                                                       =========
        [MbUnit.Framework.Test, Quill(Tx.Rollback)]
        public void Call_Procedure_NoParameter() {
            // ## Arrange ##
            SpNoParameterPmb pmb = new SpNoParameterPmb();

            // ## Act & Assert ##
            _vendorCheckBhv.OutsideSql().Call(pmb);// Expect no exception
        }

        [MbUnit.Framework.Test, Quill(Tx.Rollback)]
        public void Call_Procedure_InOutParameter() {
            // ## Arrange ##
            SpInOutParameterPmb pmb = new SpInOutParameterPmb();
            pmb.VInVarchar = "foo";
            pmb.VOutVarchar = "bar";
            pmb.VInoutVarchar = "baz";

            // ## Act ##
            _vendorCheckBhv.OutsideSql().Call(pmb);

            // ## Assert ##
            log("in=" + pmb.VInVarchar + ", out=" + pmb.VOutVarchar + ", inout=" + pmb.VInoutVarchar);
            assertEquals("baz", pmb.VOutVarchar);
            assertEquals("foo", pmb.VInoutVarchar);
        }

        [MbUnit.Framework.Test, Quill(Tx.Rollback)]
        public void Call_Procedure_ResultSetParameter() {
            // ## Arrange ##
            SpResultSetParameterPmb pmb = new SpResultSetParameterPmb();

            // ## Act ##
            try {
                _vendorCheckBhv.OutsideSql().Call(pmb);

                fail("now implementing");
            } catch (SQLFailureException e) {
                // OK
                log(e.Message);
                log(e.StackTrace);
                log(e.InnerException.StackTrace);
            }

            //// ## Assert ##
            //IList<IDictionary<String, Object>> list = pmb.Cur;
            //foreach (IDictionary<String, Object> dic in list) {
            //    log(dic.ToString());
            //}
        }

        [MbUnit.Framework.Test, Quill(Tx.Rollback)]
        public void Call_Procedure_PkgNoParameter() {
            // ## Arrange ##
            MainPkgSpPkgNoParameterPmb pmb = new MainPkgSpPkgNoParameterPmb();

            // ## Act & Assert ##
            _vendorCheckBhv.OutsideSql().Call(pmb);// Expect no exception
        }

        [MbUnit.Framework.Test, Quill(Tx.Rollback)]
        public void Call_Procedure_PkgInOutParameter() {
            // ## Arrange ##
            MainPkgSpPkgInOutParameterPmb pmb = new MainPkgSpPkgInOutParameterPmb();
            pmb.VInVarchar = "foo";
            pmb.VOutVarchar = "bar";
            pmb.VInoutVarchar = "baz";

            // ## Act ##
            _vendorCheckBhv.OutsideSql().Call(pmb);

            // ## Assert ##
            log("in=" + pmb.VInVarchar + ", out=" + pmb.VOutVarchar + ", inout=" + pmb.VInoutVarchar);
            assertEquals("qux", pmb.VOutVarchar);
            assertEquals("quux", pmb.VInoutVarchar);
        }

        // ===============================================================================
        //                                                                        Function
        //                                                                        ========
        [MbUnit.Framework.Test, Quill(Tx.Rollback)]
        public void Call_Function_NoParameter() {
            // ## Arrange ##
            FnNoParameterPmb pmb = new FnNoParameterPmb();

            // ## Act ##
            _vendorCheckBhv.OutsideSql().Call(pmb); // Expect no exception

            // ## Assert ##
            assertEquals("FN_NO_PARAMETER", pmb.Arg1);
        }

        [MbUnit.Framework.Test, Quill(Tx.Rollback)]
        public void Call_Function_InOutParameter() {
            // ## Arrange ##
            FnInOutParameterPmb pmb = new FnInOutParameterPmb();
            pmb.VInVarchar = "foo";
            pmb.VOutVarchar = "bar";
            pmb.VInoutVarchar = "barz";

            // ## Act ##
            _vendorCheckBhv.OutsideSql().Call(pmb);

            // ## Assert ##
            assertEquals("FN_IN_OUT_PARAMETER", pmb.Arg1);
            log("in=" + pmb.VInVarchar + ", out=" + pmb.VOutVarchar + ", inout=" + pmb.VInoutVarchar);
            assertEquals("qux", pmb.VOutVarchar);
            assertEquals("quux", pmb.VInoutVarchar);
        }
    }
}
