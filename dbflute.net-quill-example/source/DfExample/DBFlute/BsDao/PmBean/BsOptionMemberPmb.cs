
using System;
using System.Collections.Generic;
using System.Text;

using DfExample.DBFlute.AllCommon;
using DfExample.DBFlute.AllCommon.CBean.COption;

namespace DfExample.DBFlute.ExDao.PmBean {

    /// <summary>
    /// The parametaer-bean of OptionMemberPmb.
    /// Author: DBFlute(AutoGenerator)
    /// </summary>
    [System.Serializable]
    public partial class OptionMemberPmb {

        // ===============================================================================
        //                                                                       Attribute
        //                                                                       =========
        protected int? _memberId;
        protected String _memberName;
        protected LikeSearchOption _memberNameInternalLikeSearchOption;

        protected String _memberAccount;
        protected LikeSearchOption _memberAccountInternalLikeSearchOption;

        protected DateTime? _fromFormalizedDate;
        protected DateTime? _toFormalizedDate;
        protected String _memberStatusCode;
        protected int? _paymentCompleteFlg;
    
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

        protected void AssertLikeSearchOptionValid(String name, LikeSearchOption option) {
            if (option == null) {
                String msg = "The argument '" + name + "' should not be null!";
                throw new SystemException(msg);
            }
            if (option.isSplit()) {
                String msg = "The split of like-search is NOT available on parameter-bean.";
                msg = msg + " Don't use SplitByXxx(): " + option;
                throw new SystemException(msg);
            }
        }

        // ===============================================================================
        //                                                                  Basic Override
        //                                                                  ==============
        public override String ToString() {
            StringBuilder sb = new StringBuilder();
            sb.Append("OptionMemberPmb:");
            sb.Append(xbuildColumnString());
            return sb.ToString();
        }
        private String xbuildColumnString() {
            String c = ", ";
            StringBuilder sb = new StringBuilder();
            sb.Append(c).Append(_memberId);
            sb.Append(c).Append(_memberName);
            sb.Append(c).Append(_memberAccount);
            sb.Append(c).Append(_fromFormalizedDate);
            sb.Append(c).Append(_toFormalizedDate);
            sb.Append(c).Append(_memberStatusCode);
            sb.Append(c).Append(_paymentCompleteFlg);
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
        }

        public void SetMemberName_PrefixSearch(String memberName) {
            _memberName = memberName;
            _memberNameInternalLikeSearchOption = new LikeSearchOption().LikePrefix();
        }

        public LikeSearchOption MemberNameInternalLikeSearchOption { get {
            return _memberNameInternalLikeSearchOption;
        }}

        public String MemberAccount {
            get { return (String)ConvertEmptyToNullIfString(_memberAccount); }
        }

        public void SetMemberAccount(String memberAccount, LikeSearchOption memberAccountOption) {
            AssertLikeSearchOptionValid("memberAccountOption", memberAccountOption);
            _memberAccount = memberAccount;
            _memberAccountInternalLikeSearchOption = memberAccountOption;
        }

        public LikeSearchOption MemberAccountInternalLikeSearchOption { get {
            return _memberAccountInternalLikeSearchOption;
        }}

        public DateTime? FromFormalizedDate {
            get { return _fromFormalizedDate; }
        }

        public void SetFromFormalizedDate_FromDate(DateTime? fromFormalizedDate) {
            _fromFormalizedDate = new FromToOption().CompareAsDate().filterFromDate(fromFormalizedDate);
        }

        public DateTime? ToFormalizedDate {
            get { return _toFormalizedDate; }
        }

        public void SetToFormalizedDate_ToDate(DateTime? toFormalizedDate) {
            _toFormalizedDate = new FromToOption().CompareAsDate().filterToDate(toFormalizedDate);
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

        public int? PaymentCompleteFlg {
            get { return _paymentCompleteFlg; }
            set { _paymentCompleteFlg = value; }
        }

        public void SetPaymentCompleteFlg_True() {
            this.PaymentCompleteFlg = int.Parse(CDef.Flg.True.Code);
        }

        public void SetPaymentCompleteFlg_False() {
            this.PaymentCompleteFlg = int.Parse(CDef.Flg.False.Code);
        }

    }
}
