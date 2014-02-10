
using System;
using System.Collections.Generic;
using System.Text;

using DfExample.DBFlute.AllCommon;
using DfExample.DBFlute.AllCommon.CBean.OutsideSql;
using DfExample.DBFlute.AllCommon.CBean.COption;

namespace DfExample.DBFlute.ExDao.PmBean {

    /// <summary>
    /// The parametaer-bean of SpResultSetParameterWithPmb.
    /// Author: DBFlute(AutoGenerator)
    /// </summary>
    [System.Serializable]
    public partial class SpResultSetParameterWithPmb : ProcedurePmb {

        // ===============================================================================
        //                                                                      Definition
        //                                                                      ==========
        // -------------------------------------------------
        //                               Procedure Parameter
        //                               -------------------
        public static readonly String curMember_PROCEDURE_PARAMETER = "CUR_MEMBER, out";
        public static readonly String curMemberStatus_PROCEDURE_PARAMETER = "CUR_MEMBER_STATUS, out";
        public static readonly String vInChar_PROCEDURE_PARAMETER = "V_IN_CHAR, in";
        public static readonly String vOutVarchar_PROCEDURE_PARAMETER = "V_OUT_VARCHAR, out";
        public static readonly String vInoutVarchar_PROCEDURE_PARAMETER = "V_INOUT_VARCHAR, inout";
        public static readonly String vInNumber_PROCEDURE_PARAMETER = "V_IN_NUMBER, in";
        public static readonly String vInDate_PROCEDURE_PARAMETER = "V_IN_DATE, in";
        public static readonly String vInTimestamp_PROCEDURE_PARAMETER = "V_IN_TIMESTAMP, in";

        // ===============================================================================
        //                                                                       Attribute
        //                                                                       =========
        protected IList<IDictionary<String, Object>> _curMember;
        protected IList<IDictionary<String, Object>> _curMemberStatus;
        protected String _vInChar;
        protected String _vOutVarchar;
        protected String _vInoutVarchar;
        protected decimal? _vInNumber;
        protected DateTime? _vInDate;
        protected DateTime? _vInTimestamp;
    
        // ===============================================================================
        //                                                        Procedure Implementation
        //                                                        ========================
        public virtual String ProcedureName { get {
            return "SP_RESULT_SET_PARAMETER_WITH";
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
            sb.Append("SpResultSetParameterWithPmb:");
            sb.Append(xbuildColumnString());
            return sb.ToString();
        }
        private String xbuildColumnString() {
            String c = ", ";
            StringBuilder sb = new StringBuilder();
            sb.Append(c).Append(_curMember);
            sb.Append(c).Append(_curMemberStatus);
            sb.Append(c).Append(_vInChar);
            sb.Append(c).Append(_vOutVarchar);
            sb.Append(c).Append(_vInoutVarchar);
            sb.Append(c).Append(_vInNumber);
            sb.Append(c).Append(_vInDate);
            sb.Append(c).Append(_vInTimestamp);
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

        public decimal? VInNumber {
            get { return _vInNumber; }
            set { _vInNumber = value; }
        }

        public DateTime? VInDate {
            get { return _vInDate; }
            set { _vInDate = value; }
        }

        public DateTime? VInTimestamp {
            get { return _vInTimestamp; }
            set { _vInTimestamp = value; }
        }

    }
}
