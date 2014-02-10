
using System;
using System.Collections;

namespace DfExample.DBFlute.MemberDb.AllCommon.Exp {

    /// <summary>
    /// The exception when the entity has been duplicated.
    /// Author: DBFlute(AutoGenerator)
    /// </summary>
    public class MbEntityDuplicatedException : SystemException {

        /// <summary>
        /// Constructor.
        /// </summary>
        /// <param="msg">Exception message.</param>
        public MbEntityDuplicatedException(String msg)
        : base(msg) {}

        public MbEntityDuplicatedException(String msg, Exception e)
        : base(msg, e) {}
    }
}
