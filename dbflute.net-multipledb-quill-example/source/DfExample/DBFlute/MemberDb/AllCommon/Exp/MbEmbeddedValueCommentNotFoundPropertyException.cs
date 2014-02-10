
using System;

namespace DfExample.DBFlute.MemberDb.AllCommon.Exp {

    /// <summary>
    /// The exception of when the property on embedded value comment is not found  about outsideSql.
    /// </summary>
    public class MbEmbeddedValueCommentNotFoundPropertyException : SystemException {

        public MbEmbeddedValueCommentNotFoundPropertyException(String msg)
        : base(msg) {}
    }
}
