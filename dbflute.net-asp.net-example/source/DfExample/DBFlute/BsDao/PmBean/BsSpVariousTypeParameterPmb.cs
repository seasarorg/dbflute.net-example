
using System;
using System.Collections.Generic;
using System.Text;

using DfExample.DBFlute.AllCommon;
using DfExample.DBFlute.AllCommon.CBean.OutsideSql;
using DfExample.DBFlute.AllCommon.CBean.COption;

namespace DfExample.DBFlute.ExDao.PmBean {

    /// <summary>
    /// The parametaer-bean of SpVariousTypeParameterPmb.
    /// Author: DBFlute(AutoGenerator)
    /// </summary>
    [System.Serializable]
    public partial class SpVariousTypeParameterPmb : ProcedurePmb {

        // ===============================================================================
        //                                                                      Definition
        //                                                                      ==========
        // -------------------------------------------------
        //                               Procedure Parameter
        //                               -------------------
        public static readonly String vInVarchar_PROCEDURE_PARAMETER = "V_IN_VARCHAR, in";
        public static readonly String vOutNvarchar_PROCEDURE_PARAMETER = "V_OUT_NVARCHAR, out";
        public static readonly String vOutChar_PROCEDURE_PARAMETER = "V_OUT_CHAR, out";
        public static readonly String vInClob_PROCEDURE_PARAMETER = "V_IN_CLOB, in";
        public static readonly String vOutClob_PROCEDURE_PARAMETER = "V_OUT_CLOB, out";
        public static readonly String vvInNumberInteger_PROCEDURE_PARAMETER = "VV_IN_NUMBER_INTEGER, in";
        public static readonly String vvInNumberBigint_PROCEDURE_PARAMETER = "VV_IN_NUMBER_BIGINT, in";
        public static readonly String vvInNumberDecimal_PROCEDURE_PARAMETER = "VV_IN_NUMBER_DECIMAL, in";
        public static readonly String vvOutDecimal_PROCEDURE_PARAMETER = "VV_OUT_DECIMAL, out";
        public static readonly String vvInoutInteger_PROCEDURE_PARAMETER = "VV_INOUT_INTEGER, inout";
        public static readonly String vvOutBigint_PROCEDURE_PARAMETER = "VV_OUT_BIGINT, out";
        public static readonly String vvvInDate_PROCEDURE_PARAMETER = "VVV_IN_DATE, in";
        public static readonly String vvvOutTimestamp_PROCEDURE_PARAMETER = "VVV_OUT_TIMESTAMP, out";

        // ===============================================================================
        //                                                                       Attribute
        //                                                                       =========
        protected String _vInVarchar;
        protected String _vOutNvarchar;
        protected String _vOutChar;
        protected String _vInClob;
        protected String _vOutClob;
        protected decimal? _vvInNumberInteger;
        protected decimal? _vvInNumberBigint;
        protected decimal? _vvInNumberDecimal;
        protected decimal? _vvOutDecimal;
        protected decimal? _vvInoutInteger;
        protected decimal? _vvOutBigint;
        protected DateTime? _vvvInDate;
        protected DateTime? _vvvOutTimestamp;
    
        // ===============================================================================
        //                                                        Procedure Implementation
        //                                                        ========================
        public virtual String ProcedureName { get {
            return "SP_VARIOUS_TYPE_PARAMETER";
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
            sb.Append("SpVariousTypeParameterPmb:");
            sb.Append(xbuildColumnString());
            return sb.ToString();
        }
        private String xbuildColumnString() {
            String c = ", ";
            StringBuilder sb = new StringBuilder();
            sb.Append(c).Append(_vInVarchar);
            sb.Append(c).Append(_vOutNvarchar);
            sb.Append(c).Append(_vOutChar);
            sb.Append(c).Append(_vInClob);
            sb.Append(c).Append(_vOutClob);
            sb.Append(c).Append(_vvInNumberInteger);
            sb.Append(c).Append(_vvInNumberBigint);
            sb.Append(c).Append(_vvInNumberDecimal);
            sb.Append(c).Append(_vvOutDecimal);
            sb.Append(c).Append(_vvInoutInteger);
            sb.Append(c).Append(_vvOutBigint);
            sb.Append(c).Append(_vvvInDate);
            sb.Append(c).Append(_vvvOutTimestamp);
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

        public String VOutNvarchar {
            get { return (String)ConvertEmptyToNullIfString(_vOutNvarchar); }
            set { _vOutNvarchar = value; }
        }

        public String VOutChar {
            get { return (String)ConvertEmptyToNullIfString(_vOutChar); }
            set { _vOutChar = value; }
        }

        public String VInClob {
            get { return (String)ConvertEmptyToNullIfString(_vInClob); }
            set { _vInClob = value; }
        }

        public String VOutClob {
            get { return (String)ConvertEmptyToNullIfString(_vOutClob); }
            set { _vOutClob = value; }
        }

        public decimal? VvInNumberInteger {
            get { return _vvInNumberInteger; }
            set { _vvInNumberInteger = value; }
        }

        public decimal? VvInNumberBigint {
            get { return _vvInNumberBigint; }
            set { _vvInNumberBigint = value; }
        }

        public decimal? VvInNumberDecimal {
            get { return _vvInNumberDecimal; }
            set { _vvInNumberDecimal = value; }
        }

        public decimal? VvOutDecimal {
            get { return _vvOutDecimal; }
            set { _vvOutDecimal = value; }
        }

        public decimal? VvInoutInteger {
            get { return _vvInoutInteger; }
            set { _vvInoutInteger = value; }
        }

        public decimal? VvOutBigint {
            get { return _vvOutBigint; }
            set { _vvOutBigint = value; }
        }

        public DateTime? VvvInDate {
            get { return _vvvInDate; }
            set { _vvvInDate = value; }
        }

        public DateTime? VvvOutTimestamp {
            get { return _vvvOutTimestamp; }
            set { _vvvOutTimestamp = value; }
        }

    }
}
