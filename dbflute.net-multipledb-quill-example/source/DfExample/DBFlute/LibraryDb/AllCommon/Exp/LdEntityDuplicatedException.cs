
using System;
using System.Collections;

namespace DfExample.DBFlute.LibraryDb.AllCommon.Exp {

    /// <summary>
    /// The exception when the entity has been duplicated.
    /// Author: DBFlute(AutoGenerator)
    /// </summary>
    public class LdEntityDuplicatedException : SystemException {

        /// <summary>
        /// Constructor.
        /// </summary>
        /// <param="msg">Exception message.</param>
        public LdEntityDuplicatedException(String msg)
        : base(msg) {}

        public LdEntityDuplicatedException(String msg, Exception e)
        : base(msg, e) {}
    }
}
