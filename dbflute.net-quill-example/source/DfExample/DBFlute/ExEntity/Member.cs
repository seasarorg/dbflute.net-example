
using System;

namespace DfExample.DBFlute.ExEntity {

    partial class Member {

        // ===============================================================================
        //                                                                      Definition
        //                                                                      ==========
        public static readonly String PROP_LatestLoginDatetime = "LatestLoginDatetime";
        public static readonly String PROP_LoginCount = "LoginCount";
        public static readonly String PROP_ProductKindCount = "productKindCount";

        // ===============================================================================
        //                                                                       Attribute
        //                                                                       =========
        protected DateTime? _latestLoginDatetime;
        protected int? _loginCount;
        protected int? _productKindCount;

        // ===============================================================================
        //                                                                        Accessor
        //                                                                        ========
        public DateTime? LatestLoginDatetime {
            get {
                return _latestLoginDatetime;
            }
            set {
                _latestLoginDatetime = value;
            }
        }
        public int? LoginCount {
            get {
                return _loginCount;
            }
            set {
                _loginCount = value;
            }
        }
        public int? ProductKindCount {
            get {
                return _productKindCount;
            }
            set {
                _productKindCount = value;
            }
        }
    }
}
