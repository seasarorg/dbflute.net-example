
using System;
using DfExample.DBFlute.CBean.CQ;

namespace DfExample.DBFlute.CBean.Nss {

    public class MemberWithdrawalNss {

        protected MemberWithdrawalCQ _query;
        public MemberWithdrawalNss(MemberWithdrawalCQ query) { _query = query; }
        public bool HasConditionQuery { get { return _query != null; } }

        // ===============================================================================
        //                                                       With Nested Foreign Table
        //                                                       =========================
        public MemberNss WithMember() {
            _query.doNss(delegate() { return _query.QueryMember(); });
            return new MemberNss(_query.QueryMember());
        }

        public WithdrawalReasonNss WithWithdrawalReason() {
            _query.doNss(delegate() { return _query.QueryWithdrawalReason(); });
            return new WithdrawalReasonNss(_query.QueryWithdrawalReason());
        }


        // ===============================================================================
        //                                                      With Nested Referrer Table
        //                                                      ==========================
    }
}
