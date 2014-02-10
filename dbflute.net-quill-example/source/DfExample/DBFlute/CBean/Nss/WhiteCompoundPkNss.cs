
using System;
using DfExample.DBFlute.CBean.CQ;

namespace DfExample.DBFlute.CBean.Nss {

    public class WhiteCompoundPkNss {

        protected WhiteCompoundPkCQ _query;
        public WhiteCompoundPkNss(WhiteCompoundPkCQ query) { _query = query; }
        public bool HasConditionQuery { get { return _query != null; } }

        // ===============================================================================
        //                                                       With Nested Foreign Table
        //                                                       =========================

        // ===============================================================================
        //                                                      With Nested Referrer Table
        //                                                      ==========================
    }
}
