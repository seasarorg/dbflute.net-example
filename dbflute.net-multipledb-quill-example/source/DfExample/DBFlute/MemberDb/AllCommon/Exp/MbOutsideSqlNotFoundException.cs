
using System;
using System.Collections;

namespace DfExample.DBFlute.MemberDb.AllCommon.Exp {

    /// <summary>
    /// The exception of when the outside-sql is not found.
    /// Author: DBFlute(AutoGenerator)
    /// </summary>
    public class MbOutsideSqlNotFoundException : SystemException {

        /// <summary>
        /// Constructor.
        /// </summary>
        /// <param="msg">Exception message.</param>
        public MbOutsideSqlNotFoundException(String msg)
        : base(msg) {}
    }
}
