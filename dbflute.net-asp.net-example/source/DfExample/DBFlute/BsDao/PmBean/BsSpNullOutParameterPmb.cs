
using System;
using System.Collections.Generic;
using System.Text;

using DfExample.DBFlute.AllCommon;
using DfExample.DBFlute.AllCommon.CBean.OutsideSql;
using DfExample.DBFlute.AllCommon.CBean.COption;

namespace DfExample.DBFlute.ExDao.PmBean {

    /// <summary>
    /// The parametaer-bean of SpNullOutParameterPmb.
    /// Author: DBFlute(AutoGenerator)
    /// </summary>
    [System.Serializable]
    public partial class SpNullOutParameterPmb : ProcedurePmb {

        // ===============================================================================
        //                                                                      Definition
        //                                                                      ==========
        // -------------------------------------------------
        //                               Procedure Parameter
        //                               -------------------
        public static readonly String vOutVarchar_PROCEDURE_PARAMETER = "V_OUT_VARCHAR, out";
        public static readonly String vOutInteger_PROCEDURE_PARAMETER = "V_OUT_INTEGER, out";
        public static readonly String vOutNumber_PROCEDURE_PARAMETER = "V_OUT_NUMBER, out";
        public static readonly String vOutDate_PROCEDURE_PARAMETER = "V_OUT_DATE, out";

        // ===============================================================================
        //                                                                       Attribute
        //                                                                       =========
        protected String _vOutVarchar;
        protected decimal? _vOutInteger;
        protected decimal? _vOutNumber;
        protected DateTime? _vOutDate;
    
        // ===============================================================================
        //                                                        Procedure Implementation
        //                                                        ========================
        public virtual String ProcedureName { get {
            return "SP_NULL_OUT_PARAMETER";
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
            sb.Append("SpNullOutParameterPmb:");
            sb.Append(xbuildColumnString());
            return sb.ToString();
        }
        private String xbuildColumnString() {
            String c = ", ";
            StringBuilder sb = new StringBuilder();
            sb.Append(c).Append(_vOutVarchar);
            sb.Append(c).Append(_vOutInteger);
            sb.Append(c).Append(_vOutNumber);
            sb.Append(c).Append(_vOutDate);
            if (sb.Length > 0) { sb.Remove(0, c.Length); }
            sb.Insert(0, "{").Append("}");
            return sb.ToString();
        }

        // ===============================================================================
        //                                                                        Accessor
        //                                                                        ========
        public String VOutVarchar {
            get { return (String)ConvertEmptyToNullIfString(_vOutVarchar); }
            set { _vOutVarchar = value; }
        }

        public decimal? VOutInteger {
            get { return _vOutInteger; }
            set { _vOutInteger = value; }
        }

        public decimal? VOutNumber {
            get { return _vOutNumber; }
            set { _vOutNumber = value; }
        }

        public DateTime? VOutDate {
            get { return _vOutDate; }
            set { _vOutDate = value; }
        }

    }
}
