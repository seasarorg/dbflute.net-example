
using System;
using DfExample.DBFlute.LibraryDb.CBean.CQ;

namespace DfExample.DBFlute.LibraryDb.CBean.Nss {

    public class LdLendingNss {

        protected LdLendingCQ _query;
        public LdLendingNss(LdLendingCQ query) { _query = query; }
        public bool HasConditionQuery { get { return _query != null; } }

        // ===============================================================================
        //                                                       With Nested Foreign Table
        //                                                       =========================
        public LdLibraryUserNss WithLibraryUser() {
            _query.doNss(delegate() { return _query.QueryLibraryUser(); });
            return new LdLibraryUserNss(_query.QueryLibraryUser());
        }


        // ===============================================================================
        //                                                      With Nested Referrer Table
        //                                                      ==========================
    }
}
