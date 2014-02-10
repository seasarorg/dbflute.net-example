
using System;
using DfExample.DBFlute.LibraryDb.CBean.CQ;

namespace DfExample.DBFlute.LibraryDb.CBean.Nss {

    public class LdNextLibraryNss {

        protected LdNextLibraryCQ _query;
        public LdNextLibraryNss(LdNextLibraryCQ query) { _query = query; }
        public bool HasConditionQuery { get { return _query != null; } }

        // ===============================================================================
        //                                                       With Nested Foreign Table
        //                                                       =========================
        public LdLibraryNss WithLibraryByLibraryId() {
            _query.doNss(delegate() { return _query.QueryLibraryByLibraryId(); });
            return new LdLibraryNss(_query.QueryLibraryByLibraryId());
        }

        public LdLibraryNss WithLibraryByNextLibraryId() {
            _query.doNss(delegate() { return _query.QueryLibraryByNextLibraryId(); });
            return new LdLibraryNss(_query.QueryLibraryByNextLibraryId());
        }


        // ===============================================================================
        //                                                      With Nested Referrer Table
        //                                                      ==========================
    }
}
