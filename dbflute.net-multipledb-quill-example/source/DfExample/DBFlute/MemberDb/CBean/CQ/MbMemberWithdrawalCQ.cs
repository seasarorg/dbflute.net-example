
using System;
using System.Collections;

using DfExample.DBFlute.MemberDb.AllCommon;
using DfExample.DBFlute.MemberDb.AllCommon.CBean;
using DfExample.DBFlute.MemberDb.AllCommon.CBean.SClause;
using DfExample.DBFlute.MemberDb.CBean.CQ.BS;

namespace DfExample.DBFlute.MemberDb.CBean.CQ {

    [System.Serializable]
    public class MbMemberWithdrawalCQ : MbBsMemberWithdrawalCQ {

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
        public MbMemberWithdrawalCQ(MbConditionQuery childQuery, MbSqlClause sqlClause, String aliasName, int nestLevel)
            : base(childQuery, sqlClause, aliasName, nestLevel) {}

        // ===============================================================================
        //                                                                    Your Orignal
        //                                                                    ============
    }
}
