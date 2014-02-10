
using System;

namespace DfExample.DBFlute.LibraryDb.AllCommon.Exp {

    /// <summary>
    /// The exception of when the value of embedded value is null.
    /// </summary>
    public class LdEmbeddedValueParameterNullValueException : SystemException {

        public LdEmbeddedValueParameterNullValueException(String msg)
        : base(msg) {}
    }
}
