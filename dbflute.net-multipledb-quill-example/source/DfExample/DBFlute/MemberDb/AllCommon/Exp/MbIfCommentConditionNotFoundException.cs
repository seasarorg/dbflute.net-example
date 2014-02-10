
using System;

namespace DfExample.DBFlute.MemberDb.AllCommon.Exp {

    /// <summary>
    /// The exception of when the condition of IF comment is not found about outsideSql.
    /// </summary>
    public class MbIfCommentConditionNotFoundException : SystemException {

        public MbIfCommentConditionNotFoundException(String msg)
        : base(msg) {}
    }
}
