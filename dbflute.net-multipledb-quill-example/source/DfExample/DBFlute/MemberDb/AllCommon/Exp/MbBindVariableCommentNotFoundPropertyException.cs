
using System;
using System.Collections;

namespace DfExample.DBFlute.MemberDb.AllCommon.Exp {

    /// <summary>
    /// The exception of when the property on bind variable comment is not found about outsideSql.
    /// </summary>
    public class MbBindVariableCommentNotFoundPropertyException : SystemException {

        public MbBindVariableCommentNotFoundPropertyException(String msg)
        : base(msg) {}
    }
}
