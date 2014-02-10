
using System;
using DfExample.DBFlute.LibraryDb.CBean.CQ;

namespace DfExample.DBFlute.LibraryDb.CBean.Nss {

    public class LdCollectionNss {

        protected LdCollectionCQ _query;
        public LdCollectionNss(LdCollectionCQ query) { _query = query; }
        public bool HasConditionQuery { get { return _query != null; } }

        // ===============================================================================
        //                                                       With Nested Foreign Table
        //                                                       =========================
        public LdBookNss WithBook() {
            _query.doNss(delegate() { return _query.QueryBook(); });
            return new LdBookNss(_query.QueryBook());
        }

        public LdLibraryNss WithLibrary() {
            _query.doNss(delegate() { return _query.QueryLibrary(); });
            return new LdLibraryNss(_query.QueryLibrary());
        }


        // ===============================================================================
        //                                                      With Nested Referrer Table
        //                                                      ==========================
        public LdCollectionStatusNss WithCollectionStatusAsOne() {
            _query.doNss(delegate() { return _query.QueryCollectionStatusAsOne(); });
            return new LdCollectionStatusNss(_query.QueryCollectionStatusAsOne());
        }

    }
}
