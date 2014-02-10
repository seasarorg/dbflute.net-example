
using System;
using DfExample.DBFlute.MemberDb.CBean.CQ;

namespace DfExample.DBFlute.MemberDb.CBean.Nss {

    public class MbMemberWithdrawalNss {

        protected MbMemberWithdrawalCQ _query;
        public MbMemberWithdrawalNss(MbMemberWithdrawalCQ query) { _query = query; }
        public bool HasConditionQuery { get { return _query != null; } }

        // ===============================================================================
        //                                                       With Nested Foreign Table
        //                                                       =========================
        public MbMemberNss WithMember() {
            _query.doNss(delegate() { return _query.QueryMember(); });
            return new MbMemberNss(_query.QueryMember());
        }

        public MbWithdrawalReasonNss WithWithdrawalReason() {
            _query.doNss(delegate() { return _query.QueryWithdrawalReason(); });
            return new MbWithdrawalReasonNss(_query.QueryWithdrawalReason());
        }


        // ===============================================================================
        //                                                      With Nested Referrer Table
        //                                                      ==========================
    }
}
