
using System;
using System.Collections.Generic;
using System.Text;

using DfExample.DBFlute.AllCommon;
using DfExample.DBFlute.AllCommon.CBean.OutsideSql;
using DfExample.DBFlute.AllCommon.CBean.COption;

namespace DfExample.DBFlute.ExDao.PmBean {

    /// <summary>
    /// The parametaer-bean of SpTableNestedParameterPmb.
    /// Author: DBFlute(AutoGenerator)
    /// </summary>
    [System.Serializable]
    public partial class SpTableNestedParameterPmb : ProcedurePmb {

        // ===============================================================================
        //                                                                      Definition
        //                                                                      ==========
        // -------------------------------------------------
        //                               Procedure Parameter
        //                               -------------------
        public static readonly String vInVarcharArrayArray_PROCEDURE_PARAMETER = "V_IN_VARCHAR_ARRAY_ARRAY, in";
        public static readonly String vOutVarcharArrayArray_PROCEDURE_PARAMETER = "V_OUT_VARCHAR_ARRAY_ARRAY, out";

        // ===============================================================================
        //                                                                       Attribute
        //                                                                       =========
        protected Object _vInVarcharArrayArray;
        protected Object _vOutVarcharArrayArray;
    
        // ===============================================================================
        //                                                        Procedure Implementation
        //                                                        ========================
        public virtual String ProcedureName { get {
            return "SP_TABLE_NESTED_PARAMETER";
        }}

        // ===============================================================================
        //                                                                   Assist Helper
        //                                                                   =============
        protected String ConvertEmptyToNullIfString(String value) {
            return FilterRemoveEmptyString(value);
        }

        protected String FilterRemoveEmptyString(String value) {
            return ((value != null && !"".Equals(value)) ? value : null);
        }

        protected String FormatByteArray(byte[] bytes) {
            return "byte[" + (bytes != null ? bytes.Length.ToString() : "null") + "]";
        }

        // ===============================================================================
        //                                                                  Basic Override
        //                                                                  ==============
        public override String ToString() {
            StringBuilder sb = new StringBuilder();
            sb.Append("SpTableNestedParameterPmb:");
            sb.Append(xbuildColumnString());
            return sb.ToString();
        }
        private String xbuildColumnString() {
            String c = ", ";
            StringBuilder sb = new StringBuilder();
            sb.Append(c).Append(_vInVarcharArrayArray);
            sb.Append(c).Append(_vOutVarcharArrayArray);
            if (sb.Length > 0) { sb.Remove(0, c.Length); }
            sb.Insert(0, "{").Append("}");
            return sb.ToString();
        }

        // ===============================================================================
        //                                                                        Accessor
        //                                                                        ========
        public Object VInVarcharArrayArray {
            get { return _vInVarcharArrayArray; }
            set { _vInVarcharArrayArray = value; }
        }

        public Object VOutVarcharArrayArray {
            get { return _vOutVarcharArrayArray; }
            set { _vOutVarcharArrayArray = value; }
        }

    }
}
