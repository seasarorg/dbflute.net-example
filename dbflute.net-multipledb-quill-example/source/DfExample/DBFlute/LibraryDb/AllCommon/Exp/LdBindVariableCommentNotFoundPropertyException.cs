
using System;
using System.Collections;

namespace DfExample.DBFlute.LibraryDb.AllCommon.Exp {

    /// <summary>
    /// The exception of when the property on bind variable comment is not found about outsideSql.
    /// </summary>
    public class LdBindVariableCommentNotFoundPropertyException : SystemException {

        public LdBindVariableCommentNotFoundPropertyException(String msg)
        : base(msg) {}
    }
}
