
using System;
using System.Collections;

namespace DfExample.DBFlute.MemberDb.AllCommon.Exp {

    /// <summary>
    /// The exception of when the IF comment has a wrong expression about outsideSql.
    /// Author: DBFlute(AutoGenerator)
    /// </summary>
    public class MbIfCommentWrongExpressionException : SystemException {

        /// <summary>
        /// Constructor.
        /// </summary>
        /// <param="msg">Exception message. (NotNull)</param>
        public MbIfCommentWrongExpressionException(String msg)
        : base(msg) {}

        /// <summary>
        /// Constructor.
        /// </summary>
        /// <param="msg">Exception message. (NotNull)</param>
        /// <param="cause">Exception. (NotNull)</param>
        public MbIfCommentWrongExpressionException(String msg, Exception cause)
        : base(msg, cause) {}
    }
}
