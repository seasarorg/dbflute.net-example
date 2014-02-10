
using System;

namespace DfExample.DBFlute.LibraryDb.AllCommon.Exp {

    /// <summary>
    /// The exception of when the condition of IF comment is not found about outsideSql.
    /// </summary>
    public class LdIfCommentConditionNotFoundException : SystemException {

        public LdIfCommentConditionNotFoundException(String msg)
        : base(msg) {}
    }
}
