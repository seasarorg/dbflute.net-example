
using System;
using System.Collections;

namespace DfExample.DBFlute.LibraryDb.AllCommon.Exp {

    /// <summary>
    /// The exception of when the outside-sql is not found.
    /// Author: DBFlute(AutoGenerator)
    /// </summary>
    public class LdOutsideSqlNotFoundException : SystemException {

        /// <summary>
        /// Constructor.
        /// </summary>
        /// <param="msg">Exception message.</param>
        public LdOutsideSqlNotFoundException(String msg)
        : base(msg) {}
    }
}
