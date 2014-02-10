
using System;
using DfExample.DBFlute.LibraryDb.CBean.CQ;

namespace DfExample.DBFlute.LibraryDb.CBean.Nss {

    public class LdMyselfCheckNss {

        protected LdMyselfCheckCQ _query;
        public LdMyselfCheckNss(LdMyselfCheckCQ query) { _query = query; }
        public bool HasConditionQuery { get { return _query != null; } }

        // ===============================================================================
        //                                                       With Nested Foreign Table
        //                                                       =========================
        public LdMyselfNss WithMyself() {
            _query.doNss(delegate() { return _query.QueryMyself(); });
            return new LdMyselfNss(_query.QueryMyself());
        }


        // ===============================================================================
        //                                                      With Nested Referrer Table
        //                                                      ==========================
    }
}
