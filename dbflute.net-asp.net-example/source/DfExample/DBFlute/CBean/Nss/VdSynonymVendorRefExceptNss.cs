
using System;
using DfExample.DBFlute.CBean.CQ;

namespace DfExample.DBFlute.CBean.Nss {

    public class VdSynonymVendorRefExceptNss {

        protected VdSynonymVendorRefExceptCQ _query;
        public VdSynonymVendorRefExceptNss(VdSynonymVendorRefExceptCQ query) { _query = query; }
        public bool HasConditionQuery { get { return _query != null; } }

        // ===============================================================================
        //                                                       With Nested Foreign Table
        //                                                       =========================
        public VdSynonymVendorExceptNss WithVdSynonymVendorExcept() {
            _query.doNss(delegate() { return _query.QueryVdSynonymVendorExcept(); });
            return new VdSynonymVendorExceptNss(_query.QueryVdSynonymVendorExcept());
        }


        // ===============================================================================
        //                                                      With Nested Referrer Table
        //                                                      ==========================
    }
}
