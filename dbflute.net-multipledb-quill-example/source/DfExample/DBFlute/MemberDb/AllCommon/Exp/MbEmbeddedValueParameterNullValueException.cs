
using System;

namespace DfExample.DBFlute.MemberDb.AllCommon.Exp {

    /// <summary>
    /// The exception of when the value of embedded value is null.
    /// </summary>
    public class MbEmbeddedValueParameterNullValueException : SystemException {

        public MbEmbeddedValueParameterNullValueException(String msg)
        : base(msg) {}
    }
}
