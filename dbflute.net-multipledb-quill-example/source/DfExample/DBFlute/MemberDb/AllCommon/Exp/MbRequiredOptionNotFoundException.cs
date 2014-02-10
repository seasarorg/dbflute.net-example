
using System;
using System.Collections;

namespace DfExample.DBFlute.MemberDb.AllCommon.Exp {

    /// <summary>
    /// The exception of when the required option is not found.
    /// Author: DBFlute(AutoGenerator)
    /// </summary>
    public class MbRequiredOptionNotFoundException : SystemException {

        /// <summary>
        /// Constructor.
        /// </summary>
        /// <param="msg">Exception message.</param>
        public MbRequiredOptionNotFoundException(String msg)
        : base(msg) {}
    }
}
