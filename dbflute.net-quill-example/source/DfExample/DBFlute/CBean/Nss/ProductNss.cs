
using System;
using DfExample.DBFlute.CBean.CQ;

namespace DfExample.DBFlute.CBean.Nss {

    public class ProductNss {

        protected ProductCQ _query;
        public ProductNss(ProductCQ query) { _query = query; }
        public bool HasConditionQuery { get { return _query != null; } }

        // ===============================================================================
        //                                                       With Nested Foreign Table
        //                                                       =========================
        public ProductStatusNss WithProductStatus() {
            _query.doNss(delegate() { return _query.QueryProductStatus(); });
            return new ProductStatusNss(_query.QueryProductStatus());
        }


        // ===============================================================================
        //                                                      With Nested Referrer Table
        //                                                      ==========================
    }
}
