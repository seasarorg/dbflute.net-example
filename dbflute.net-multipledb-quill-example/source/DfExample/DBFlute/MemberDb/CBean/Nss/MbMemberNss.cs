
using System;
using DfExample.DBFlute.MemberDb.CBean.CQ;

namespace DfExample.DBFlute.MemberDb.CBean.Nss {

    public class MbMemberNss {

        protected MbMemberCQ _query;
        public MbMemberNss(MbMemberCQ query) { _query = query; }
        public bool HasConditionQuery { get { return _query != null; } }

        // ===============================================================================
        //                                                       With Nested Foreign Table
        //                                                       =========================
        public MbMemberStatusNss WithMemberStatus() {
            _query.doNss(delegate() { return _query.QueryMemberStatus(); });
            return new MbMemberStatusNss(_query.QueryMemberStatus());
        }

        public MbMemberLoginNss WithMemberLoginAsLatest() {
            _query.doNss(delegate() { return _query.QueryMemberLoginAsLatest(); });
            return new MbMemberLoginNss(_query.QueryMemberLoginAsLatest());
        }

        public MbMemberAddressNss WithMemberAddressAsValid(DateTime targetDate) {
            _query.doNss(delegate() { return _query.QueryMemberAddressAsValid(targetDate); });
            return new MbMemberAddressNss(_query.QueryMemberAddressAsValid(targetDate));
        }


        // ===============================================================================
        //                                                      With Nested Referrer Table
        //                                                      ==========================
        public MbMemberSecurityNss WithMemberSecurityAsOne() {
            _query.doNss(delegate() { return _query.QueryMemberSecurityAsOne(); });
            return new MbMemberSecurityNss(_query.QueryMemberSecurityAsOne());
        }

        public MbMemberWithdrawalNss WithMemberWithdrawalAsOne() {
            _query.doNss(delegate() { return _query.QueryMemberWithdrawalAsOne(); });
            return new MbMemberWithdrawalNss(_query.QueryMemberWithdrawalAsOne());
        }

    }
}
