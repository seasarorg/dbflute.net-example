
using System;

namespace DfExample.DBFlute.LibraryDb.AllCommon.Exp {

    /// <summary>
    /// The exception of when the property on embedded value comment is not found  about outsideSql.
    /// </summary>
    public class LdEmbeddedValueCommentNotFoundPropertyException : SystemException {

        public LdEmbeddedValueCommentNotFoundPropertyException(String msg)
        : base(msg) {}
    }
}
