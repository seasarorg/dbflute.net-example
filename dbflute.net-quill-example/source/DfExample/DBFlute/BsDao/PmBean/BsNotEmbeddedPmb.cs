
using System;
using System.Collections.Generic;
using System.Text;

using DfExample.DBFlute.AllCommon;
using DfExample.DBFlute.AllCommon.CBean.COption;

namespace DfExample.DBFlute.ExDao.PmBean {

    /// <summary>
    /// The parametaer-bean of NotEmbeddedPmb.
    /// Author: DBFlute(AutoGenerator)
    /// </summary>
    [System.Serializable]
    public partial class NotEmbeddedPmb {

        // ===============================================================================
        //                                                                       Attribute
        //                                                                       =========
        protected int? _memberId;
        protected String _memberName;
    
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
            sb.Append("NotEmbeddedPmb:");
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
            set { _memberName = value; }
        }

    }
}
