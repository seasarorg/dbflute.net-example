
using System;
using DfExample.DBFlute.CBean.CQ;

namespace DfExample.DBFlute.CBean.Nss {

    public class VdSynonymMemberWithdrawalNss {

        protected VdSynonymMemberWithdrawalCQ _query;
        public VdSynonymMemberWithdrawalNss(VdSynonymMemberWithdrawalCQ query) { _query = query; }
        public bool HasConditionQuery { get { return _query != null; } }

        // ===============================================================================
        //                                                       With Nested Foreign Table
        //                                                       =========================
        public MemberVendorSynonymNss WithMemberVendorSynonym() {
            _query.doNss(delegate() { return _query.QueryMemberVendorSynonym(); });
            return new MemberVendorSynonymNss(_query.QueryMemberVendorSynonym());
        }

        public WithdrawalReasonNss WithWithdrawalReason() {
            _query.doNss(delegate() { return _query.QueryWithdrawalReason(); });
            return new WithdrawalReasonNss(_query.QueryWithdrawalReason());
        }

        public VdSynonymMemberNss WithVdSynonymMember() {
            _query.doNss(delegate() { return _query.QueryVdSynonymMember(); });
            return new VdSynonymMemberNss(_query.QueryVdSynonymMember());
        }

        public VendorSynonymMemberNss WithVendorSynonymMember() {
            _query.doNss(delegate() { return _query.QueryVendorSynonymMember(); });
            return new VendorSynonymMemberNss(_query.QueryVendorSynonymMember());
        }


        // ===============================================================================
        //                                                      With Nested Referrer Table
        //                                                      ==========================
    }
}
