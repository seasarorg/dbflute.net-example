
using System;
using DfExample.DBFlute.CBean.CQ;

namespace DfExample.DBFlute.CBean.Nss {

    public class VendorRefExceptNss {

        protected VendorRefExceptCQ _query;
        public VendorRefExceptNss(VendorRefExceptCQ query) { _query = query; }
        public bool HasConditionQuery { get { return _query != null; } }

        // ===============================================================================
        //                                                       With Nested Foreign Table
        //                                                       =========================
        public VendorExceptNss WithVendorExcept() {
            _query.doNss(delegate() { return _query.QueryVendorExcept(); });
            return new VendorExceptNss(_query.QueryVendorExcept());
        }


        // ===============================================================================
        //                                                      With Nested Referrer Table
        //                                                      ==========================
    }
}
