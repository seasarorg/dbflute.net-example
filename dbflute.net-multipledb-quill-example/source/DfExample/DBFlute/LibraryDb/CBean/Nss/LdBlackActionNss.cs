
using System;
using DfExample.DBFlute.LibraryDb.CBean.CQ;

namespace DfExample.DBFlute.LibraryDb.CBean.Nss {

    public class LdBlackActionNss {

        protected LdBlackActionCQ _query;
        public LdBlackActionNss(LdBlackActionCQ query) { _query = query; }
        public bool HasConditionQuery { get { return _query != null; } }

        // ===============================================================================
        //                                                       With Nested Foreign Table
        //                                                       =========================
        public LdBlackListNss WithBlackList() {
            _query.doNss(delegate() { return _query.QueryBlackList(); });
            return new LdBlackListNss(_query.QueryBlackList());
        }

        public LdBlackActionLookupNss WithBlackActionLookup() {
            _query.doNss(delegate() { return _query.QueryBlackActionLookup(); });
            return new LdBlackActionLookupNss(_query.QueryBlackActionLookup());
        }


        // ===============================================================================
        //                                                      With Nested Referrer Table
        //                                                      ==========================
    }
}
