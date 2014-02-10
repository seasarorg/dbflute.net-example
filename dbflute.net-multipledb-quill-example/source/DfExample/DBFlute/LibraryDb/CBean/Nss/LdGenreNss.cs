
using System;
using DfExample.DBFlute.LibraryDb.CBean.CQ;

namespace DfExample.DBFlute.LibraryDb.CBean.Nss {

    public class LdGenreNss {

        protected LdGenreCQ _query;
        public LdGenreNss(LdGenreCQ query) { _query = query; }
        public bool HasConditionQuery { get { return _query != null; } }

        // ===============================================================================
        //                                                       With Nested Foreign Table
        //                                                       =========================
        public LdGenreNss WithGenreSelf() {
            _query.doNss(delegate() { return _query.QueryGenreSelf(); });
            return new LdGenreNss(_query.QueryGenreSelf());
        }


        // ===============================================================================
        //                                                      With Nested Referrer Table
        //                                                      ==========================
    }
}
