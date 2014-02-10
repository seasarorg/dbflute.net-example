
using System;

namespace DfExample.DBFlute.LibraryDb.AllCommon.Exp {

    /// <summary>
    /// The exception of when the entity has already been deleted (by other thread).
    /// Author: DBFlute(AutoGenerator)
    /// </summary>
    public class LdEntityAlreadyDeletedException : SystemException {

        /// <summary>
        /// Constructor.
        /// </summary>
        /// <param="msg">Exception message. (NotNull)</param>
        public LdEntityAlreadyDeletedException(String msg)
        : base(msg) {}
    }
}
