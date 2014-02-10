
using System;

namespace DfExample.DBFlute.MemberDb.AllCommon.Exp {

    /// <summary>
    /// The exception of when an invalid query is registered.
    /// </summary>
    public class MbInvalidQueryRegisteredException : SystemException {

        public MbInvalidQueryRegisteredException(String msg)
        : base(msg) {}
    }
}
