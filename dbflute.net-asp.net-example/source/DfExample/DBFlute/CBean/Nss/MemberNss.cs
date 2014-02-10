
using System;
using DfExample.DBFlute.CBean.CQ;

namespace DfExample.DBFlute.CBean.Nss {

    public class MemberNss {

        protected MemberCQ _query;
        public MemberNss(MemberCQ query) { _query = query; }
        public bool HasConditionQuery { get { return _query != null; } }

        // ===============================================================================
        //                                                       With Nested Foreign Table
        //                                                       =========================
        public MemberStatusNss WithMemberStatus() {
            _query.doNss(delegate() { return _query.QueryMemberStatus(); });
            return new MemberStatusNss(_query.QueryMemberStatus());
        }

        public MemberLoginNss WithMemberLoginAsLatest() {
            _query.doNss(delegate() { return _query.QueryMemberLoginAsLatest(); });
            return new MemberLoginNss(_query.QueryMemberLoginAsLatest());
        }


        // ===============================================================================
        //                                                      With Nested Referrer Table
        //                                                      ==========================
        public MemberSecurityNss WithMemberSecurityAsOne() {
            _query.doNss(delegate() { return _query.QueryMemberSecurityAsOne(); });
            return new MemberSecurityNss(_query.QueryMemberSecurityAsOne());
        }

        public MemberWithdrawalNss WithMemberWithdrawalAsOne() {
            _query.doNss(delegate() { return _query.QueryMemberWithdrawalAsOne(); });
            return new MemberWithdrawalNss(_query.QueryMemberWithdrawalAsOne());
        }

    }
}
