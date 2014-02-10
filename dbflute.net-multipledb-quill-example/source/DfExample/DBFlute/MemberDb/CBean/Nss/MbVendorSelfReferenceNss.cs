
using System;
using DfExample.DBFlute.MemberDb.CBean.CQ;

namespace DfExample.DBFlute.MemberDb.CBean.Nss {

    public class MbVendorSelfReferenceNss {

        protected MbVendorSelfReferenceCQ _query;
        public MbVendorSelfReferenceNss(MbVendorSelfReferenceCQ query) { _query = query; }
        public bool HasConditionQuery { get { return _query != null; } }

        // ===============================================================================
        //                                                       With Nested Foreign Table
        //                                                       =========================
        public MbVendorSelfReferenceNss WithVendorSelfReferenceSelf() {
            _query.doNss(delegate() { return _query.QueryVendorSelfReferenceSelf(); });
            return new MbVendorSelfReferenceNss(_query.QueryVendorSelfReferenceSelf());
        }


        // ===============================================================================
        //                                                      With Nested Referrer Table
        //                                                      ==========================
    }
}
