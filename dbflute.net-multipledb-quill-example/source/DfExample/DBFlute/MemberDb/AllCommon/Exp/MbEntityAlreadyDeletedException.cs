
using System;

namespace DfExample.DBFlute.MemberDb.AllCommon.Exp {

    /// <summary>
    /// The exception of when the entity has already been deleted (by other thread).
    /// Author: DBFlute(AutoGenerator)
    /// </summary>
    public class MbEntityAlreadyDeletedException : SystemException {

        /// <summary>
        /// Constructor.
        /// </summary>
        /// <param="msg">Exception message. (NotNull)</param>
        public MbEntityAlreadyDeletedException(String msg)
        : base(msg) {}
    }
}
