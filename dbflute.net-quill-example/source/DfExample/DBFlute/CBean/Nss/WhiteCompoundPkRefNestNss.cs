
using System;
using DfExample.DBFlute.CBean.CQ;

namespace DfExample.DBFlute.CBean.Nss {

    public class WhiteCompoundPkRefNestNss {

        protected WhiteCompoundPkRefNestCQ _query;
        public WhiteCompoundPkRefNestNss(WhiteCompoundPkRefNestCQ query) { _query = query; }
        public bool HasConditionQuery { get { return _query != null; } }

        // ===============================================================================
        //                                                       With Nested Foreign Table
        //                                                       =========================
        public WhiteCompoundPkRefNss WithWhiteCompoundPkRefByQuxMultipleId() {
            _query.doNss(delegate() { return _query.QueryWhiteCompoundPkRefByQuxMultipleId(); });
            return new WhiteCompoundPkRefNss(_query.QueryWhiteCompoundPkRefByQuxMultipleId());
        }

        public WhiteCompoundPkRefNss WithWhiteCompoundPkRefByFooMultipleId() {
            _query.doNss(delegate() { return _query.QueryWhiteCompoundPkRefByFooMultipleId(); });
            return new WhiteCompoundPkRefNss(_query.QueryWhiteCompoundPkRefByFooMultipleId());
        }


        // ===============================================================================
        //                                                      With Nested Referrer Table
        //                                                      ==========================
    }
}
