
using System;

namespace DfExample.DBFlute.ExEntity {

    partial class Member {

        // ===============================================================================
        //                                                                       Attribute
        //                                                                       =========
        protected DateTime? _latestLoginDatetime;
        protected int? _loginCount;

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
    }
}
