
using System;
using System.Collections.Generic;
using System.Text;

using DfExample.DBFlute.MemberDb.AllCommon;
using DfExample.DBFlute.MemberDb.AllCommon.CBean.OutsideSql;
using DfExample.DBFlute.MemberDb.AllCommon.CBean.COption;

namespace DfExample.DBFlute.MemberDb.ExDao.PmBean {

    /// <summary>
    /// The parametaer-bean of SpReturnResultSetPmb.
    /// Author: DBFlute(AutoGenerator)
    /// </summary>
    [System.Serializable]
    public partial class MbSpReturnResultSetPmb : MbProcedurePmb {

        // ===============================================================================
        //                                                                      Definition
        //                                                                      ==========
        // -------------------------------------------------
        //                               Procedure Parameter
        //                               -------------------

        // ===============================================================================
        //                                                                       Attribute
        //                                                                       =========
    
        // ===============================================================================
        //                                                        Procedure Implementation
        //                                                        ========================
        public virtual String ProcedureName { get {
            return "SP_RETURN_RESULT_SET";
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
            sb.Append("MbSpReturnResultSetPmb:");
            sb.Append(xbuildColumnString());
            return sb.ToString();
        }
        private String xbuildColumnString() {
            String c = ", ";
            StringBuilder sb = new StringBuilder();
            if (sb.Length > 0) { sb.Remove(0, c.Length); }
            sb.Insert(0, "{").Append("}");
            return sb.ToString();
        }

        // ===============================================================================
        //                                                                        Accessor
        //                                                                        ========
    }
}
