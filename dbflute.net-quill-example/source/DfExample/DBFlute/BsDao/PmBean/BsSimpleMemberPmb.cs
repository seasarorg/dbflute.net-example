
using System;
using System.Collections.Generic;
using System.Text;

using DfExample.DBFlute.AllCommon;
using DfExample.DBFlute.AllCommon.CBean.COption;

namespace DfExample.DBFlute.ExDao.PmBean {

    /// <summary>
    /// The parametaer-bean of SimpleMemberPmb.
    /// Author: DBFlute(AutoGenerator)
    /// </summary>
    [System.Serializable]
    public partial class SimpleMemberPmb {

        // ===============================================================================
        //                                                                       Attribute
        //                                                                       =========
        protected int? _memberId;
        protected String _memberName;
        protected LikeSearchOption _memberNameInternalLikeSearchOption;

    
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
            sb.Append("SimpleMemberPmb:");
            sb.Append(xbuildColumnString());
            return sb.ToString();
        }
        private String xbuildColumnString() {
            String c = ", ";
            StringBuilder sb = new StringBuilder();
            sb.Append(c).Append(_memberId);
            sb.Append(c).Append(_memberName);
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

    }
}
