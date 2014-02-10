
using System;

namespace DfExample.DBFlute.LibraryDb.AllCommon.Exp {

    /// <summary>
    /// The exception of when an invalid query is registered.
    /// </summary>
    public class LdInvalidQueryRegisteredException : SystemException {

        public LdInvalidQueryRegisteredException(String msg)
        : base(msg) {}
    }
}
