
using System;
using DfExample.DBFlute.LibraryDb.CBean.CQ;

namespace DfExample.DBFlute.LibraryDb.CBean.Nss {

    public class LdLbUserNss {

        protected LdLbUserCQ _query;
        public LdLbUserNss(LdLbUserCQ query) { _query = query; }
        public bool HasConditionQuery { get { return _query != null; } }

        // ===============================================================================
        //                                                       With Nested Foreign Table
        //                                                       =========================

        // ===============================================================================
        //                                                      With Nested Referrer Table
        //                                                      ==========================
        public LdBlackListNss WithBlackListAsOne() {
            _query.doNss(delegate() { return _query.QueryBlackListAsOne(); });
            return new LdBlackListNss(_query.QueryBlackListAsOne());
        }

    }
}
