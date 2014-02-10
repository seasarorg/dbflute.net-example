
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
        public static readonly String vInInteger_PROCEDURE_PARAMETER = "v_in_integer, in";
        public static readonly String vInDeciaml_PROCEDURE_PARAMETER = "v_in_deciaml, in";
        public static readonly String vInDate_PROCEDURE_PARAMETER = "v_in_date, in";
        public static readonly String vInDatetime_PROCEDURE_PARAMETER = "v_in_datetime, in";

        // ===============================================================================
        //                                                                       Attribute
        //                                                                       =========
        protected int? _vInInteger;
        protected decimal? _vInDeciaml;
        protected DateTime? _vInDate;
        protected DateTime? _vInDatetime;
    
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
            sb.Append(c).Append(_vInInteger);
            sb.Append(c).Append(_vInDeciaml);
            sb.Append(c).Append(_vInDate);
            sb.Append(c).Append(_vInDatetime);
            if (sb.Length > 0) { sb.Remove(0, c.Length); }
            sb.Insert(0, "{").Append("}");
            return sb.ToString();
        }

        // ===============================================================================
        //                                                                        Accessor
        //                                                                        ========
        public int? VInInteger {
            get { return _vInInteger; }
            set { _vInInteger = value; }
        }

        public decimal? VInDeciaml {
            get { return _vInDeciaml; }
            set { _vInDeciaml = value; }
        }

        public DateTime? VInDate {
            get { return _vInDate; }
            set { _vInDate = value; }
        }

        public DateTime? VInDatetime {
            get { return _vInDatetime; }
            set { _vInDatetime = value; }
        }

    }
}
