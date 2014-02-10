
using System;
using DfExample.DBFlute.CBean.CQ;

namespace DfExample.DBFlute.CBean.Nss {

    public class PurchaseNss {

        protected PurchaseCQ _query;
        public PurchaseNss(PurchaseCQ query) { _query = query; }
        public bool HasConditionQuery { get { return _query != null; } }

        // ===============================================================================
        //                                                       With Nested Foreign Table
        //                                                       =========================
        public MemberNss WithMember() {
            _query.doNss(delegate() { return _query.QueryMember(); });
            return new MemberNss(_query.QueryMember());
        }

        public ProductNss WithProduct() {
            _query.doNss(delegate() { return _query.QueryProduct(); });
            return new ProductNss(_query.QueryProduct());
        }


        // ===============================================================================
        //                                                      With Nested Referrer Table
        //                                                      ==========================
    }
}
