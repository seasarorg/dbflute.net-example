using System;
using System.Collections.Generic;
using System.Reflection;
using DfExample.DBFlute.AllCommon;
using DfExample.DBFlute.AllCommon.Exp;
using DfExample.DBFlute.CBean;
using DfExample.DBFlute.ExBhv;
using DfExample.DBFlute.ExDao.PmBean;
using DfExample.DBFlute.ExEntity;
using DfExample.DBFlute.ExEntity.Customize;
using Seasar.Framework.Util;
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
            pmb.VInVarchar = "aaa";
            pmb.VOutVarchar = "bbb";
            pmb.VInoutVarchar = "ccc";

            // ## Act ##
            _vendorCheckBhv.OutsideSql().Call(pmb);

            log("/**********************************************************");
            log("Failed to out parameter reflection! I don't know why it is.");
            log("**********/");

            // ## Assert ##
            log("in=" + pmb.VInVarchar + ", out=" + pmb.VOutVarchar + ", inout=" + pmb.VInoutVarchar);
            assertEquals("ddd", pmb.VOutVarchar);
            assertEquals("eee", pmb.VInoutVarchar);
        }

        [MbUnit.Framework.Test, Quill(Tx.Rollback)]
        public void Call_Procedure_VariousTypeParameter() {
            // ## Arrange ##
            SpVariousTypeParameterPmb pmb = new SpVariousTypeParameterPmb();
            pmb.VInInteger = 3;
            pmb.VInDate = new DateTime(2007, 12, 31);
            pmb.VInDatetime = new DateTime(2007, 12, 31, 11, 32, 53);

            // ## Act ##
            _vendorCheckBhv.OutsideSql().Call(pmb);

            log("/**********************************************************");
            log("Failed to out parameter reflection! I don't know why it is.");
            log("**********/");

            // ## Assert ##
            log("integer=" + pmb.VInInteger + ", date=" + pmb.VInDate + ", datetime=" + pmb.VInDatetime);
        }
    }
}
