
using System;
using DfExample.DBFlute.CBean.CQ;

namespace DfExample.DBFlute.CBean.Nss {

    public class VdSynonymProductNss {

        protected VdSynonymProductCQ _query;
        public VdSynonymProductNss(VdSynonymProductCQ query) { _query = query; }
        public bool HasConditionQuery { get { return _query != null; } }

        // ===============================================================================
        //                                                       With Nested Foreign Table
        //                                                       =========================
        public VdSynonymProductStatusNss WithVdSynonymProductStatus() {
            _query.doNss(delegate() { return _query.QueryVdSynonymProductStatus(); });
            return new VdSynonymProductStatusNss(_query.QueryVdSynonymProductStatus());
        }


        // ===============================================================================
        //                                                      With Nested Referrer Table
        //                                                      ==========================
    }
}
