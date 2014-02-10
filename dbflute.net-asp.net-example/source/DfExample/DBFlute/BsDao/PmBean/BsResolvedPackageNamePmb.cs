
using System;
using System.Collections.Generic;
using System.Text;

using DfExample.DBFlute.AllCommon;
using DfExample.DBFlute.AllCommon.CBean.COption;

namespace DfExample.DBFlute.ExDao.PmBean {

    /// <summary>
    /// The parametaer-bean of ResolvedPackageNamePmb.
    /// Author: DBFlute(AutoGenerator)
    /// </summary>
    [System.Serializable]
    public partial class ResolvedPackageNamePmb {

        // ===============================================================================
        //                                                                       Attribute
        //                                                                       =========
        protected String _string1;
        protected int? _integer1;
        protected DateTime? _date1;
        protected System.Collections.Generic.IList<String> _list1;
        protected System.Collections.Generic.IList<String> _list2;
    
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
            sb.Append("ResolvedPackageNamePmb:");
            sb.Append(xbuildColumnString());
            return sb.ToString();
        }
        private String xbuildColumnString() {
            String c = ", ";
            StringBuilder sb = new StringBuilder();
            sb.Append(c).Append(_string1);
            sb.Append(c).Append(_integer1);
            sb.Append(c).Append(_date1);
            sb.Append(c).Append(_list1);
            sb.Append(c).Append(_list2);
            if (sb.Length > 0) { sb.Remove(0, c.Length); }
            sb.Insert(0, "{").Append("}");
            return sb.ToString();
        }

        // ===============================================================================
        //                                                                        Accessor
        //                                                                        ========
        public String String1 {
            get { return (String)ConvertEmptyToNullIfString(_string1); }
            set { _string1 = value; }
        }

        public int? Integer1 {
            get { return _integer1; }
            set { _integer1 = value; }
        }

        public DateTime? Date1 {
            get { return _date1; }
            set { _date1 = value; }
        }

        public System.Collections.Generic.IList<String> List1 {
            get { return _list1; }
            set { _list1 = value; }
        }

        public System.Collections.Generic.IList<String> List2 {
            get { return _list2; }
            set { _list2 = value; }
        }

    }
}
