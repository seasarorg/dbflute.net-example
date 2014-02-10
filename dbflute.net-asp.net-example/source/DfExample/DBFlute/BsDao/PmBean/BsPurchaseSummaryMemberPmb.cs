
using System;
using System.Collections.Generic;
using System.Text;

using DfExample.DBFlute.AllCommon;
using DfExample.DBFlute.AllCommon.CBean.COption;

namespace DfExample.DBFlute.ExDao.PmBean {

    /// <summary>
    /// The parametaer-bean of PurchaseSummaryMemberPmb.
    /// Author: DBFlute(AutoGenerator)
    /// </summary>
    [System.Serializable]
    public partial class PurchaseSummaryMemberPmb {

        // ===============================================================================
        //                                                                       Attribute
        //                                                                       =========
        protected String _memberStatusCode;
    
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
            sb.Append("PurchaseSummaryMemberPmb:");
            sb.Append(xbuildColumnString());
            return sb.ToString();
        }
        private String xbuildColumnString() {
            String c = ", ";
            StringBuilder sb = new StringBuilder();
            sb.Append(c).Append(_memberStatusCode);
            if (sb.Length > 0) { sb.Remove(0, c.Length); }
            sb.Insert(0, "{").Append("}");
            return sb.ToString();
        }

        // ===============================================================================
        //                                                                        Accessor
        //                                                                        ========
        public String MemberStatusCode {
            get { return (String)ConvertEmptyToNullIfString(_memberStatusCode); }
            set { _memberStatusCode = value; }
        }

        public void SetMemberStatusCode_Provisional() {
            this.MemberStatusCode = CDef.MemberStatus.Provisional.Code;
        }

        public void SetMemberStatusCode_Formalized() {
            this.MemberStatusCode = CDef.MemberStatus.Formalized.Code;
        }

        public void SetMemberStatusCode_Withdrawal() {
            this.MemberStatusCode = CDef.MemberStatus.Withdrawal.Code;
        }

    }
}
