
using System;
using DfExample.DBFlute.MemberDb.CBean.CQ;

namespace DfExample.DBFlute.MemberDb.CBean.Nss {

    public class MbProductNss {

        protected MbProductCQ _query;
        public MbProductNss(MbProductCQ query) { _query = query; }
        public bool HasConditionQuery { get { return _query != null; } }

        // ===============================================================================
        //                                                       With Nested Foreign Table
        //                                                       =========================
        public MbProductStatusNss WithProductStatus() {
            _query.doNss(delegate() { return _query.QueryProductStatus(); });
            return new MbProductStatusNss(_query.QueryProductStatus());
        }


        // ===============================================================================
        //                                                      With Nested Referrer Table
        //                                                      ==========================
    }
}
