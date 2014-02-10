
using System;

namespace DfExample.DBFlute.MemberDb.AllCommon.Exp {

    /// <summary>
    /// The exception of when the end comment is not found about outsideSql.
    /// </summary>
    public class MbEndCommentNotFoundException : SystemException {

        public MbEndCommentNotFoundException(String msg)
        : base(msg) {}
    }
}
