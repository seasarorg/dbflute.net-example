
using System;
using DfExample.DBFlute.LibraryDb.CBean.CQ;

namespace DfExample.DBFlute.LibraryDb.CBean.Nss {

    public class LdBlackListNss {

        protected LdBlackListCQ _query;
        public LdBlackListNss(LdBlackListCQ query) { _query = query; }
        public bool HasConditionQuery { get { return _query != null; } }

        // ===============================================================================
        //                                                       With Nested Foreign Table
        //                                                       =========================
        public LdLbUserNss WithLbUser() {
            _query.doNss(delegate() { return _query.QueryLbUser(); });
            return new LdLbUserNss(_query.QueryLbUser());
        }


        // ===============================================================================
        //                                                      With Nested Referrer Table
        //                                                      ==========================
    }
}
