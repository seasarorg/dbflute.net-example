
using System;
using System.Collections;

using DfExample.DBFlute.AllCommon;
using DfExample.DBFlute.AllCommon.CBean;
using DfExample.DBFlute.AllCommon.CBean.SClause;
using DfExample.DBFlute.CBean.CQ.BS;

namespace DfExample.DBFlute.CBean.CQ {

    [System.Serializable]
    public class PurchaseCQ : BsPurchaseCQ {

        // ===============================================================================
        //                                                                     Constructor
        //                                                                     ===========
        /// <summary>
        /// Constructor.
        /// </summary>
        /// <param name="childQuery">Child query as interface. (Nullable: If null, this is base instance.)</param>
        /// <param name="sqlClause">SQL clause instance. (NotNull)</param>
        /// <param name="aliasName">My alias name. (NotNull)</param>
        /// <param name="nestLevel">Nest level.</param>
        public PurchaseCQ(ConditionQuery childQuery, SqlClause sqlClause, String aliasName, int nestLevel)
            : base(childQuery, sqlClause, aliasName, nestLevel) {}

        // ===============================================================================
        //                                                                    Your Orignal
        //                                                                    ============
    }
}
