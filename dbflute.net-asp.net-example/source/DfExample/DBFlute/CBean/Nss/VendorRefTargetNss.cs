
using System;
using DfExample.DBFlute.CBean.CQ;

namespace DfExample.DBFlute.CBean.Nss {

    public class VendorRefTargetNss {

        protected VendorRefTargetCQ _query;
        public VendorRefTargetNss(VendorRefTargetCQ query) { _query = query; }
        public bool HasConditionQuery { get { return _query != null; } }

        // ===============================================================================
        //                                                       With Nested Foreign Table
        //                                                       =========================
        public VendorTargetNss WithVendorTarget() {
            _query.doNss(delegate() { return _query.QueryVendorTarget(); });
            return new VendorTargetNss(_query.QueryVendorTarget());
        }


        // ===============================================================================
        //                                                      With Nested Referrer Table
        //                                                      ==========================
    }
}
