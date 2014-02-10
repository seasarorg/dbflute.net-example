
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

        public MemberAddressNss WithMemberAddressAsValid(DateTime targetDate) {
            _query.doNss(delegate() { return _query.QueryMemberAddressAsValid(targetDate); });
            return new MemberAddressNss(_query.QueryMemberAddressAsValid(targetDate));
        }

        public MemberLoginNss WithMemberLoginAsLocalForeignOverTest() {
            _query.doNss(delegate() { return _query.QueryMemberLoginAsLocalForeignOverTest(); });
            return new MemberLoginNss(_query.QueryMemberLoginAsLocalForeignOverTest());
        }

        public MemberLoginNss WithMemberLoginAsForeignForeignOverTest() {
            _query.doNss(delegate() { return _query.QueryMemberLoginAsForeignForeignOverTest(); });
            return new MemberLoginNss(_query.QueryMemberLoginAsForeignForeignOverTest());
        }

        public MemberLoginNss WithMemberLoginAsForeignForeignParameterOverTest(DateTime targetDate) {
            _query.doNss(delegate() { return _query.QueryMemberLoginAsForeignForeignParameterOverTest(targetDate); });
            return new MemberLoginNss(_query.QueryMemberLoginAsForeignForeignParameterOverTest(targetDate));
        }

        public MemberLoginNss WithMemberLoginAsForeignForeignVariousOverTest() {
            _query.doNss(delegate() { return _query.QueryMemberLoginAsForeignForeignVariousOverTest(); });
            return new MemberLoginNss(_query.QueryMemberLoginAsForeignForeignVariousOverTest());
        }

        public MemberLoginNss WithMemberLoginAsReferrerOverTest() {
            _query.doNss(delegate() { return _query.QueryMemberLoginAsReferrerOverTest(); });
            return new MemberLoginNss(_query.QueryMemberLoginAsReferrerOverTest());
        }

        public MemberLoginNss WithMemberLoginAsReferrerForeignOverTest() {
            _query.doNss(delegate() { return _query.QueryMemberLoginAsReferrerForeignOverTest(); });
            return new MemberLoginNss(_query.QueryMemberLoginAsReferrerForeignOverTest());
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
