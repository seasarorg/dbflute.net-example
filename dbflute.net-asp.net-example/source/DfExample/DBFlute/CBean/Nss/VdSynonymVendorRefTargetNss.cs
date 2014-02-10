
using System;
using DfExample.DBFlute.CBean.CQ;

namespace DfExample.DBFlute.CBean.Nss {

    public class VdSynonymVendorRefTargetNss {

        protected VdSynonymVendorRefTargetCQ _query;
        public VdSynonymVendorRefTargetNss(VdSynonymVendorRefTargetCQ query) { _query = query; }
        public bool HasConditionQuery { get { return _query != null; } }

        // ===============================================================================
        //                                                       With Nested Foreign Table
        //                                                       =========================
        public VdSynonymVendorTargetNss WithVdSynonymVendorTarget() {
            _query.doNss(delegate() { return _query.QueryVdSynonymVendorTarget(); });
            return new VdSynonymVendorTargetNss(_query.QueryVdSynonymVendorTarget());
        }


        // ===============================================================================
        //                                                      With Nested Referrer Table
        //                                                      ==========================
    }
}
