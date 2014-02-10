
using System;
using DfExample.DBFlute.CBean.CQ;

namespace DfExample.DBFlute.CBean.Nss {

    public class MemberAddressNss {

        protected MemberAddressCQ _query;
        public MemberAddressNss(MemberAddressCQ query) { _query = query; }
        public bool HasConditionQuery { get { return _query != null; } }

        // ===============================================================================
        //                                                       With Nested Foreign Table
        //                                                       =========================
        public MemberNss WithMember() {
            _query.doNss(delegate() { return _query.QueryMember(); });
            return new MemberNss(_query.QueryMember());
        }


        // ===============================================================================
        //                                                      With Nested Referrer Table
        //                                                      ==========================
    }
}
