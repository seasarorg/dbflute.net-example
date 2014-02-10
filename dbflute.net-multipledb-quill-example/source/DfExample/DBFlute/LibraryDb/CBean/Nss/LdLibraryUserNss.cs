
using System;
using DfExample.DBFlute.LibraryDb.CBean.CQ;

namespace DfExample.DBFlute.LibraryDb.CBean.Nss {

    public class LdLibraryUserNss {

        protected LdLibraryUserCQ _query;
        public LdLibraryUserNss(LdLibraryUserCQ query) { _query = query; }
        public bool HasConditionQuery { get { return _query != null; } }

        // ===============================================================================
        //                                                       With Nested Foreign Table
        //                                                       =========================
        public LdLbUserNss WithLbUser() {
            _query.doNss(delegate() { return _query.QueryLbUser(); });
            return new LdLbUserNss(_query.QueryLbUser());
        }

        public LdLibraryNss WithLibrary() {
            _query.doNss(delegate() { return _query.QueryLibrary(); });
            return new LdLibraryNss(_query.QueryLibrary());
        }


        // ===============================================================================
        //                                                      With Nested Referrer Table
        //                                                      ==========================
    }
}
