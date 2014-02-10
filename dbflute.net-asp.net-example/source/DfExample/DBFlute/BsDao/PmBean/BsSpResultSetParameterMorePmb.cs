
using System;
using System.Collections.Generic;
using System.Text;

using DfExample.DBFlute.AllCommon;
using DfExample.DBFlute.AllCommon.CBean.OutsideSql;
using DfExample.DBFlute.AllCommon.CBean.COption;

namespace DfExample.DBFlute.ExDao.PmBean {

    /// <summary>
    /// The parametaer-bean of SpResultSetParameterMorePmb.
    /// Author: DBFlute(AutoGenerator)
    /// </summary>
    [System.Serializable]
    public partial class SpResultSetParameterMorePmb : ProcedurePmb {

        // ===============================================================================
        //                                                                      Definition
        //                                                                      ==========
        // -------------------------------------------------
        //                               Procedure Parameter
        //                               -------------------
        public static readonly String curMember_PROCEDURE_PARAMETER = "CUR_MEMBER, out";
        public static readonly String curMemberStatus_PROCEDURE_PARAMETER = "CUR_MEMBER_STATUS, out";

        // ===============================================================================
        //                                                                       Attribute
        //                                                                       =========
        protected IList<IDictionary<String, Object>> _curMember;
        protected IList<IDictionary<String, Object>> _curMemberStatus;
    
        // ===============================================================================
        //                                                        Procedure Implementation
        //                                                        ========================
        public virtual String ProcedureName { get {
            return "SP_RESULT_SET_PARAMETER_MORE";
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
            sb.Append("SpResultSetParameterMorePmb:");
            sb.Append(xbuildColumnString());
            return sb.ToString();
        }
        private String xbuildColumnString() {
            String c = ", ";
            StringBuilder sb = new StringBuilder();
            sb.Append(c).Append(_curMember);
            sb.Append(c).Append(_curMemberStatus);
            if (sb.Length > 0) { sb.Remove(0, c.Length); }
            sb.Insert(0, "{").Append("}");
            return sb.ToString();
        }

        // ===============================================================================
        //                                                                        Accessor
        //                                                                        ========
        public IList<IDictionary<String, Object>> CurMember {
            get { return _curMember; }
            set { _curMember = value; }
        }

        public IList<IDictionary<String, Object>> CurMemberStatus {
            get { return _curMemberStatus; }
            set { _curMemberStatus = value; }
        }

    }
}
