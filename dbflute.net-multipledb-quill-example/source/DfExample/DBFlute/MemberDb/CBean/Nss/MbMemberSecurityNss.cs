
using System;
using DfExample.DBFlute.MemberDb.CBean.CQ;

namespace DfExample.DBFlute.MemberDb.CBean.Nss {

    public class MbMemberSecurityNss {

        protected MbMemberSecurityCQ _query;
        public MbMemberSecurityNss(MbMemberSecurityCQ query) { _query = query; }
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
