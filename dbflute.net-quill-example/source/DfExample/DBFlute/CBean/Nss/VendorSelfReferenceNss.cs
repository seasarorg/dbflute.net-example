
using System;
using DfExample.DBFlute.CBean.CQ;

namespace DfExample.DBFlute.CBean.Nss {

    public class VendorSelfReferenceNss {

        protected VendorSelfReferenceCQ _query;
        public VendorSelfReferenceNss(VendorSelfReferenceCQ query) { _query = query; }
        public bool HasConditionQuery { get { return _query != null; } }

        // ===============================================================================
        //                                                       With Nested Foreign Table
        //                                                       =========================
        public VendorSelfReferenceNss WithVendorSelfReferenceSelf() {
            _query.doNss(delegate() { return _query.QueryVendorSelfReferenceSelf(); });
            return new VendorSelfReferenceNss(_query.QueryVendorSelfReferenceSelf());
        }


        // ===============================================================================
        //                                                      With Nested Referrer Table
        //                                                      ==========================
    }
}
