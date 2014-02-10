
using System;
using DfExample.DBFlute.LibraryDb.CBean.CQ;

namespace DfExample.DBFlute.LibraryDb.CBean.Nss {

    public class LdCollectionStatusNss {

        protected LdCollectionStatusCQ _query;
        public LdCollectionStatusNss(LdCollectionStatusCQ query) { _query = query; }
        public bool HasConditionQuery { get { return _query != null; } }

        // ===============================================================================
        //                                                       With Nested Foreign Table
        //                                                       =========================
        public LdCollectionNss WithCollection() {
            _query.doNss(delegate() { return _query.QueryCollection(); });
            return new LdCollectionNss(_query.QueryCollection());
        }

        public LdCollectionStatusLookupNss WithCollectionStatusLookup() {
            _query.doNss(delegate() { return _query.QueryCollectionStatusLookup(); });
            return new LdCollectionStatusLookupNss(_query.QueryCollectionStatusLookup());
        }


        // ===============================================================================
        //                                                      With Nested Referrer Table
        //                                                      ==========================
    }
}
