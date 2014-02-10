
using System;
using System.Collections;

namespace DfExample.DBFlute.LibraryDb.AllCommon.Exp {

    /// <summary>
    /// The exception of when the required option is not found.
    /// Author: DBFlute(AutoGenerator)
    /// </summary>
    public class LdRequiredOptionNotFoundException : SystemException {

        /// <summary>
        /// Constructor.
        /// </summary>
        /// <param="msg">Exception message.</param>
        public LdRequiredOptionNotFoundException(String msg)
        : base(msg) {}
    }
}
