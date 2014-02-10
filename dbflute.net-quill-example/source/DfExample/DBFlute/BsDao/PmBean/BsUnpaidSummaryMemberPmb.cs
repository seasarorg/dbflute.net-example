
using System;
using System.Collections.Generic;
using System.Text;

using DfExample.DBFlute.AllCommon;
using DfExample.DBFlute.AllCommon.CBean;
using DfExample.DBFlute.AllCommon.CBean.COption;

namespace DfExample.DBFlute.ExDao.PmBean {

    /// <summary>
    /// The parametaer-bean of UnpaidSummaryMemberPmb.
    /// Author: DBFlute(AutoGenerator)
    /// </summary>
    [System.Serializable]
    public partial class UnpaidSummaryMemberPmb : SimplePagingBean {

        // ===============================================================================
        //                                                                       Attribute
        //                                                                       =========
        protected int? _memberId;
        protected String _memberName;
        protected String _memberStatusCode;
        protected bool _unpaidMemberOnly;
    
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
            sb.Append("UnpaidSummaryMemberPmb:");
            sb.Append(xbuildColumnString());
            return sb.ToString();
        }
        private String xbuildColumnString() {
            String c = ", ";
            StringBuilder sb = new StringBuilder();
            sb.Append(c).Append(_memberId);
            sb.Append(c).Append(_memberName);
            sb.Append(c).Append(_memberStatusCode);
            sb.Append(c).Append(_unpaidMemberOnly);
            if (sb.Length > 0) { sb.Remove(0, c.Length); }
            sb.Insert(0, "{").Append("}");
            return sb.ToString();
        }

        // ===============================================================================
        //                                                                        Accessor
        //                                                                        ========
        public int? MemberId {
            get { return _memberId; }
            set { _memberId = value; }
        }

        public String MemberName {
            get { return (String)ConvertEmptyToNullIfString(_memberName); }
            set { _memberName = value; }
        }

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

        public bool UnpaidMemberOnly {
            get { return _unpaidMemberOnly; }
            set { _unpaidMemberOnly = value; }
        }

    }
}
