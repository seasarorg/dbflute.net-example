
using System;
using DfExample.DBFlute.MemberDb.CBean.CQ;

namespace DfExample.DBFlute.MemberDb.CBean.Nss {

    public class MbPurchaseNss {

        protected MbPurchaseCQ _query;
        public MbPurchaseNss(MbPurchaseCQ query) { _query = query; }
        public bool HasConditionQuery { get { return _query != null; } }

        // ===============================================================================
        //                                                       With Nested Foreign Table
        //                                                       =========================
        public MbMemberNss WithMember() {
            _query.doNss(delegate() { return _query.QueryMember(); });
            return new MbMemberNss(_query.QueryMember());
        }

        public MbProductNss WithProduct() {
            _query.doNss(delegate() { return _query.QueryProduct(); });
            return new MbProductNss(_query.QueryProduct());
        }


        // ===============================================================================
        //                                                      With Nested Referrer Table
        //                                                      ==========================
    }
}
