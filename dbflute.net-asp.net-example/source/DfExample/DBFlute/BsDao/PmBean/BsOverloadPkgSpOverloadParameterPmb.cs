
using System;
using System.Collections.Generic;
using System.Text;

using DfExample.DBFlute.AllCommon;
using DfExample.DBFlute.AllCommon.CBean.OutsideSql;
using DfExample.DBFlute.AllCommon.CBean.COption;

namespace DfExample.DBFlute.ExDao.PmBean {

    /// <summary>
    /// The parametaer-bean of OverloadPkgSpOverloadParameterPmb.
    /// Author: DBFlute(AutoGenerator)
    /// </summary>
    [System.Serializable]
    public partial class OverloadPkgSpOverloadParameterPmb : ProcedurePmb {

        // ===============================================================================
        //                                                                      Definition
        //                                                                      ==========
        // -------------------------------------------------
        //                               Procedure Parameter
        //                               -------------------
        public static readonly String vInVarchar_PROCEDURE_PARAMETER = "V_IN_VARCHAR, in";
        public static readonly String vOutVarchar_PROCEDURE_PARAMETER = "V_OUT_VARCHAR, out";
        public static readonly String vInoutVarchar_PROCEDURE_PARAMETER = "V_INOUT_VARCHAR, inout";
        public static readonly String vInNumber_PROCEDURE_PARAMETER = "V_IN_NUMBER, in";
        public static readonly String vOutNumber_PROCEDURE_PARAMETER = "V_OUT_NUMBER, out";

        // ===============================================================================
        //                                                                       Attribute
        //                                                                       =========
        protected String _vInVarchar;
        protected String _vOutVarchar;
        protected String _vInoutVarchar;
        protected decimal? _vInNumber;
        protected decimal? _vOutNumber;
    
        // ===============================================================================
        //                                                        Procedure Implementation
        //                                                        ========================
        public virtual String ProcedureName { get {
            return "OVERLOAD_PKG.SP_OVERLOAD_PARAMETER";
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
            sb.Append("OverloadPkgSpOverloadParameterPmb:");
            sb.Append(xbuildColumnString());
            return sb.ToString();
        }
        private String xbuildColumnString() {
            String c = ", ";
            StringBuilder sb = new StringBuilder();
            sb.Append(c).Append(_vInVarchar);
            sb.Append(c).Append(_vOutVarchar);
            sb.Append(c).Append(_vInoutVarchar);
            sb.Append(c).Append(_vInNumber);
            sb.Append(c).Append(_vOutNumber);
            if (sb.Length > 0) { sb.Remove(0, c.Length); }
            sb.Insert(0, "{").Append("}");
            return sb.ToString();
        }

        // ===============================================================================
        //                                                                        Accessor
        //                                                                        ========
        public String VInVarchar {
            get { return (String)ConvertEmptyToNullIfString(_vInVarchar); }
            set { _vInVarchar = value; }
        }

        public String VOutVarchar {
            get { return (String)ConvertEmptyToNullIfString(_vOutVarchar); }
            set { _vOutVarchar = value; }
        }

        public String VInoutVarchar {
            get { return (String)ConvertEmptyToNullIfString(_vInoutVarchar); }
            set { _vInoutVarchar = value; }
        }

        public decimal? VInNumber {
            get { return _vInNumber; }
            set { _vInNumber = value; }
        }

        public decimal? VOutNumber {
            get { return _vOutNumber; }
            set { _vOutNumber = value; }
        }

    }
}
