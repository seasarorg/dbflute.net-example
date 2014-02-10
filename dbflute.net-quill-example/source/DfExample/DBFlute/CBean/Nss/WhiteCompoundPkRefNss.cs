
using System;
using DfExample.DBFlute.CBean.CQ;

namespace DfExample.DBFlute.CBean.Nss {

    public class WhiteCompoundPkRefNss {

        protected WhiteCompoundPkRefCQ _query;
        public WhiteCompoundPkRefNss(WhiteCompoundPkRefCQ query) { _query = query; }
        public bool HasConditionQuery { get { return _query != null; } }

        // ===============================================================================
        //                                                       With Nested Foreign Table
        //                                                       =========================
        public WhiteCompoundPkNss WithWhiteCompoundPk() {
            _query.doNss(delegate() { return _query.QueryWhiteCompoundPk(); });
            return new WhiteCompoundPkNss(_query.QueryWhiteCompoundPk());
        }


        // ===============================================================================
        //                                                      With Nested Referrer Table
        //                                                      ==========================
    }
}
