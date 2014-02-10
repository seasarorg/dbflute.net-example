
using System;
using DfExample.DBFlute.CBean.CQ;

namespace DfExample.DBFlute.CBean.Nss {

    public class WhiteSelfReferenceNss {

        protected WhiteSelfReferenceCQ _query;
        public WhiteSelfReferenceNss(WhiteSelfReferenceCQ query) { _query = query; }
        public bool HasConditionQuery { get { return _query != null; } }

        // ===============================================================================
        //                                                       With Nested Foreign Table
        //                                                       =========================
        public WhiteSelfReferenceNss WithWhiteSelfReferenceSelf() {
            _query.doNss(delegate() { return _query.QueryWhiteSelfReferenceSelf(); });
            return new WhiteSelfReferenceNss(_query.QueryWhiteSelfReferenceSelf());
        }


        // ===============================================================================
        //                                                      With Nested Referrer Table
        //                                                      ==========================
    }
}
