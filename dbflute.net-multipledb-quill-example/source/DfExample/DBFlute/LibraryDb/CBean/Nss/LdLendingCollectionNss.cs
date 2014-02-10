
using System;
using DfExample.DBFlute.LibraryDb.CBean.CQ;

namespace DfExample.DBFlute.LibraryDb.CBean.Nss {

    public class LdLendingCollectionNss {

        protected LdLendingCollectionCQ _query;
        public LdLendingCollectionNss(LdLendingCollectionCQ query) { _query = query; }
        public bool HasConditionQuery { get { return _query != null; } }

        // ===============================================================================
        //                                                       With Nested Foreign Table
        //                                                       =========================
        public LdCollectionNss WithCollection() {
            _query.doNss(delegate() { return _query.QueryCollection(); });
            return new LdCollectionNss(_query.QueryCollection());
        }

        public LdLendingNss WithLending() {
            _query.doNss(delegate() { return _query.QueryLending(); });
            return new LdLendingNss(_query.QueryLending());
        }

        public LdLibraryUserNss WithLibraryUser() {
            _query.doNss(delegate() { return _query.QueryLibraryUser(); });
            return new LdLibraryUserNss(_query.QueryLibraryUser());
        }


        // ===============================================================================
        //                                                      With Nested Referrer Table
        //                                                      ==========================
    }
}
