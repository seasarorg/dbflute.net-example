
using System;
using DfExample.DBFlute.CBean.CQ;

namespace DfExample.DBFlute.CBean.Nss {

    public class WhiteMyselfCheckNss {

        protected WhiteMyselfCheckCQ _query;
        public WhiteMyselfCheckNss(WhiteMyselfCheckCQ query) { _query = query; }
        public bool HasConditionQuery { get { return _query != null; } }

        // ===============================================================================
        //                                                       With Nested Foreign Table
        //                                                       =========================
        public WhiteMyselfNss WithWhiteMyself() {
            _query.doNss(delegate() { return _query.QueryWhiteMyself(); });
            return new WhiteMyselfNss(_query.QueryWhiteMyself());
        }


        // ===============================================================================
        //                                                      With Nested Referrer Table
        //                                                      ==========================
    }
}
