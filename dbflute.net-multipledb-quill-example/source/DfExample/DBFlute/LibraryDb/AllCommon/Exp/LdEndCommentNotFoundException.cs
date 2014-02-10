
using System;

namespace DfExample.DBFlute.LibraryDb.AllCommon.Exp {

    /// <summary>
    /// The exception of when the end comment is not found about outsideSql.
    /// </summary>
    public class LdEndCommentNotFoundException : SystemException {

        public LdEndCommentNotFoundException(String msg)
        : base(msg) {}
    }
}
