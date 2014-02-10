
using System;
using DfExample.DBFlute.CBean.CQ;

namespace DfExample.DBFlute.CBean.Nss {

    public class MyselfCheckNss {

        protected MyselfCheckCQ _query;
        public MyselfCheckNss(MyselfCheckCQ query) { _query = query; }
        public bool HasConditionQuery { get { return _query != null; } }

        // ===============================================================================
        //                                                       With Nested Foreign Table
        //                                                       =========================
        public MyselfNss WithMyself() {
            _query.doNss(delegate() { return _query.QueryMyself(); });
            return new MyselfNss(_query.QueryMyself());
        }


        // ===============================================================================
        //                                                      With Nested Referrer Table
        //                                                      ==========================
    }
}
