
using System;
using DfExample.DBFlute.CBean.CQ;

namespace DfExample.DBFlute.CBean.Nss {

    public class WhitePgReservNss {

        protected WhitePgReservCQ _query;
        public WhitePgReservNss(WhitePgReservCQ query) { _query = query; }
        public bool HasConditionQuery { get { return _query != null; } }

        // ===============================================================================
        //                                                       With Nested Foreign Table
        //                                                       =========================

        // ===============================================================================
        //                                                      With Nested Referrer Table
        //                                                      ==========================
    }
}
