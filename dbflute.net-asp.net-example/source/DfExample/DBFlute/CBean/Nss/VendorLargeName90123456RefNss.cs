
using System;
using DfExample.DBFlute.CBean.CQ;

namespace DfExample.DBFlute.CBean.Nss {

    public class VendorLargeName90123456RefNss {

        protected VendorLargeName90123456RefCQ _query;
        public VendorLargeName90123456RefNss(VendorLargeName90123456RefCQ query) { _query = query; }
        public bool HasConditionQuery { get { return _query != null; } }

        // ===============================================================================
        //                                                       With Nested Foreign Table
        //                                                       =========================
        public VendorLargeName901234567890Nss WithVendorLargeName901234567890() {
            _query.doNss(delegate() { return _query.QueryVendorLargeName901234567890(); });
            return new VendorLargeName901234567890Nss(_query.QueryVendorLargeName901234567890());
        }


        // ===============================================================================
        //                                                      With Nested Referrer Table
        //                                                      ==========================
    }
}
