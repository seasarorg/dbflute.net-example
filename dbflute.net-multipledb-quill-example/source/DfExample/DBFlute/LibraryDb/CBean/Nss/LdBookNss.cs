
using System;
using DfExample.DBFlute.LibraryDb.CBean.CQ;

namespace DfExample.DBFlute.LibraryDb.CBean.Nss {

    public class LdBookNss {

        protected LdBookCQ _query;
        public LdBookNss(LdBookCQ query) { _query = query; }
        public bool HasConditionQuery { get { return _query != null; } }

        // ===============================================================================
        //                                                       With Nested Foreign Table
        //                                                       =========================
        public LdAuthorNss WithAuthor() {
            _query.doNss(delegate() { return _query.QueryAuthor(); });
            return new LdAuthorNss(_query.QueryAuthor());
        }

        public LdGenreNss WithGenre() {
            _query.doNss(delegate() { return _query.QueryGenre(); });
            return new LdGenreNss(_query.QueryGenre());
        }

        public LdPublisherNss WithPublisher() {
            _query.doNss(delegate() { return _query.QueryPublisher(); });
            return new LdPublisherNss(_query.QueryPublisher());
        }

        public LdCollectionStatusLookupNss WithCollectionStatusLookupAsNonExist() {
            _query.doNss(delegate() { return _query.QueryCollectionStatusLookupAsNonExist(); });
            return new LdCollectionStatusLookupNss(_query.QueryCollectionStatusLookupAsNonExist());
        }


        // ===============================================================================
        //                                                      With Nested Referrer Table
        //                                                      ==========================
    }
}
