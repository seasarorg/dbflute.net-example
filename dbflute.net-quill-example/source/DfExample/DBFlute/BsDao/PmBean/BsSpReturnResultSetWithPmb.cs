
using System;
using System.Collections.Generic;
using System.Text;

using DfExample.DBFlute.AllCommon;
using DfExample.DBFlute.AllCommon.CBean.OutsideSql;
using DfExample.DBFlute.AllCommon.CBean.COption;

namespace DfExample.DBFlute.ExDao.PmBean {

    /// <summary>
    /// The parametaer-bean of SpReturnResultSetWithPmb.
    /// Author: DBFlute(AutoGenerator)
    /// </summary>
    [System.Serializable]
    public partial class SpReturnResultSetWithPmb : ProcedurePmb {

        // ===============================================================================
        //                                                                      Definition
        //                                                                      ==========
        // -------------------------------------------------
        //                               Procedure Parameter
        //                               -------------------
        public static readonly String vInChar_PROCEDURE_PARAMETER = "v_in_char, in";
        public static readonly String vOutVarchar_PROCEDURE_PARAMETER = "v_out_varchar, out";
        public static readonly String vInoutVarchar_PROCEDURE_PARAMETER = "v_inout_varchar, inout";

        // ===============================================================================
        //                                                                       Attribute
        //                                                                       =========
        protected String _vInChar;
        protected String _vOutVarchar;
        protected String _vInoutVarchar;
    
        // ===============================================================================
        //                                                        Procedure Implementation
        //                                                        ========================
        public virtual String ProcedureName { get {
            return "SP_RETURN_RESULT_SET_WITH";
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
            sb.Append("SpReturnResultSetWithPmb:");
            sb.Append(xbuildColumnString());
            return sb.ToString();
        }
        private String xbuildColumnString() {
            String c = ", ";
            StringBuilder sb = new StringBuilder();
            sb.Append(c).Append(_vInChar);
            sb.Append(c).Append(_vOutVarchar);
            sb.Append(c).Append(_vInoutVarchar);
            if (sb.Length > 0) { sb.Remove(0, c.Length); }
            sb.Insert(0, "{").Append("}");
            return sb.ToString();
        }

        // ===============================================================================
        //                                                                        Accessor
        //                                                                        ========
        public String VInChar {
            get { return (String)ConvertEmptyToNullIfString(_vInChar); }
            set { _vInChar = value; }
        }

        public String VOutVarchar {
            get { return (String)ConvertEmptyToNullIfString(_vOutVarchar); }
            set { _vOutVarchar = value; }
        }

        public String VInoutVarchar {
            get { return (String)ConvertEmptyToNullIfString(_vInoutVarchar); }
            set { _vInoutVarchar = value; }
        }

    }
}
