
using System;
using DfExample.DBFlute.CBean.CQ;

namespace DfExample.DBFlute.CBean.Nss {

    public class MemberLoginNss {

        protected MemberLoginCQ _query;
        public MemberLoginNss(MemberLoginCQ query) { _query = query; }
        public bool HasConditionQuery { get { return _query != null; } }

        // ===============================================================================
        //                                                       With Nested Foreign Table
        //                                                       =========================
        public MemberNss WithMember() {
            _query.doNss(delegate() { return _query.QueryMember(); });
            return new MemberNss(_query.QueryMember());
        }

        public MemberStatusNss WithMemberStatus() {
            _query.doNss(delegate() { return _query.QueryMemberStatus(); });
            return new MemberStatusNss(_query.QueryMemberStatus());
        }


        // ===============================================================================
        //                                                      With Nested Referrer Table
        //                                                      ==========================
    }
}
