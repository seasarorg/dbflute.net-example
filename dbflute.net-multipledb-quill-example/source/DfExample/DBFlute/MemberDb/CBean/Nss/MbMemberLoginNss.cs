
using System;
using DfExample.DBFlute.MemberDb.CBean.CQ;

namespace DfExample.DBFlute.MemberDb.CBean.Nss {

    public class MbMemberLoginNss {

        protected MbMemberLoginCQ _query;
        public MbMemberLoginNss(MbMemberLoginCQ query) { _query = query; }
        public bool HasConditionQuery { get { return _query != null; } }

        // ===============================================================================
        //                                                       With Nested Foreign Table
        //                                                       =========================
        public MbMemberNss WithMember() {
            _query.doNss(delegate() { return _query.QueryMember(); });
            return new MbMemberNss(_query.QueryMember());
        }

        public MbMemberStatusNss WithMemberStatus() {
            _query.doNss(delegate() { return _query.QueryMemberStatus(); });
            return new MbMemberStatusNss(_query.QueryMemberStatus());
        }


        // ===============================================================================
        //                                                      With Nested Referrer Table
        //                                                      ==========================
    }
}
