
using System;
using DfExample.DBFlute.CBean.CQ;

namespace DfExample.DBFlute.CBean.Nss {

    public class WhitePgReservRefNss {

        protected WhitePgReservRefCQ _query;
        public WhitePgReservRefNss(WhitePgReservRefCQ query) { _query = query; }
        public bool HasConditionQuery { get { return _query != null; } }

        // ===============================================================================
        //                                                       With Nested Foreign Table
        //                                                       =========================
        public WhitePgReservNss WithWhitePgReserv() {
            _query.doNss(delegate() { return _query.QueryWhitePgReserv(); });
            return new WhitePgReservNss(_query.QueryWhitePgReserv());
        }


        // ===============================================================================
        //                                                      With Nested Referrer Table
        //                                                      ==========================
    }
}
