
using System;
using DfExample.DBFlute.CBean.CQ;

namespace DfExample.DBFlute.CBean.Nss {

    public class VdSynonymMemberNss {

        protected VdSynonymMemberCQ _query;
        public VdSynonymMemberNss(VdSynonymMemberCQ query) { _query = query; }
        public bool HasConditionQuery { get { return _query != null; } }

        // ===============================================================================
        //                                                       With Nested Foreign Table
        //                                                       =========================
        public MemberStatusNss WithMemberStatus() {
            _query.doNss(delegate() { return _query.QueryMemberStatus(); });
            return new MemberStatusNss(_query.QueryMemberStatus());
        }


        // ===============================================================================
        //                                                      With Nested Referrer Table
        //                                                      ==========================
        public VdSynonymMemberWithdrawalNss WithVdSynonymMemberWithdrawalAsOne() {
            _query.doNss(delegate() { return _query.QueryVdSynonymMemberWithdrawalAsOne(); });
            return new VdSynonymMemberWithdrawalNss(_query.QueryVdSynonymMemberWithdrawalAsOne());
        }

    }
}
