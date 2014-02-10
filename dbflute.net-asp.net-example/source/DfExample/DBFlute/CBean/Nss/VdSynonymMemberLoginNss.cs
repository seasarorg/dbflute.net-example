
using System;
using DfExample.DBFlute.CBean.CQ;

namespace DfExample.DBFlute.CBean.Nss {

    public class VdSynonymMemberLoginNss {

        protected VdSynonymMemberLoginCQ _query;
        public VdSynonymMemberLoginNss(VdSynonymMemberLoginCQ query) { _query = query; }
        public bool HasConditionQuery { get { return _query != null; } }

        // ===============================================================================
        //                                                       With Nested Foreign Table
        //                                                       =========================
        public MemberVendorSynonymNss WithMemberVendorSynonym() {
            _query.doNss(delegate() { return _query.QueryMemberVendorSynonym(); });
            return new MemberVendorSynonymNss(_query.QueryMemberVendorSynonym());
        }

        public MemberStatusNss WithMemberStatus() {
            _query.doNss(delegate() { return _query.QueryMemberStatus(); });
            return new MemberStatusNss(_query.QueryMemberStatus());
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
