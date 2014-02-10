
using System;
using DfExample.DBFlute.MemberDb.CBean.CQ;

namespace DfExample.DBFlute.MemberDb.CBean.Nss {

    public class MbMemberAddressNss {

        protected MbMemberAddressCQ _query;
        public MbMemberAddressNss(MbMemberAddressCQ query) { _query = query; }
        public bool HasConditionQuery { get { return _query != null; } }

        // ===============================================================================
        //                                                       With Nested Foreign Table
        //                                                       =========================
        public MbMemberNss WithMember() {
            _query.doNss(delegate() { return _query.QueryMember(); });
            return new MbMemberNss(_query.QueryMember());
        }


        // ===============================================================================
        //                                                      With Nested Referrer Table
        //                                                      ==========================
    }
}
