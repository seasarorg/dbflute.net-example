
using System;
using DfExample.DBFlute.CBean.CQ;

namespace DfExample.DBFlute.CBean.Nss {

    public class WhiteAllInOneClsRefNss {

        protected WhiteAllInOneClsRefCQ _query;
        public WhiteAllInOneClsRefNss(WhiteAllInOneClsRefCQ query) { _query = query; }
        public bool HasConditionQuery { get { return _query != null; } }

        // ===============================================================================
        //                                                       With Nested Foreign Table
        //                                                       =========================
        public WhiteAllInOneClsNss WithWhiteAllInOneClsAsFoo() {
            _query.doNss(delegate() { return _query.QueryWhiteAllInOneClsAsFoo(); });
            return new WhiteAllInOneClsNss(_query.QueryWhiteAllInOneClsAsFoo());
        }

        public WhiteAllInOneClsNss WithWhiteAllInOneClsAsBar() {
            _query.doNss(delegate() { return _query.QueryWhiteAllInOneClsAsBar(); });
            return new WhiteAllInOneClsNss(_query.QueryWhiteAllInOneClsAsBar());
        }


        // ===============================================================================
        //                                                      With Nested Referrer Table
        //                                                      ==========================
    }
}
