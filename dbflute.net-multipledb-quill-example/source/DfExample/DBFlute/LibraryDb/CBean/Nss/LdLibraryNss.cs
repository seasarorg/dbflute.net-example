
using System;
using DfExample.DBFlute.LibraryDb.CBean.CQ;

namespace DfExample.DBFlute.LibraryDb.CBean.Nss {

    public class LdLibraryNss {

        protected LdLibraryCQ _query;
        public LdLibraryNss(LdLibraryCQ query) { _query = query; }
        public bool HasConditionQuery { get { return _query != null; } }

        // ===============================================================================
        //                                                       With Nested Foreign Table
        //                                                       =========================
        public LdLibraryTypeLookupNss WithLibraryTypeLookup() {
            _query.doNss(delegate() { return _query.QueryLibraryTypeLookup(); });
            return new LdLibraryTypeLookupNss(_query.QueryLibraryTypeLookup());
        }


        // ===============================================================================
        //                                                      With Nested Referrer Table
        //                                                      ==========================
    }
}
