
using System;
using System.Collections;

namespace DfExample.DBFlute.LibraryDb.AllCommon.Exp {

    /// <summary>
    /// The exception of when the value of bind variable is null about outsideSql.
    /// </summary>
    public class LdBindVariableParameterNullValueException : SystemException {

        public LdBindVariableParameterNullValueException(String msg)
        : base(msg) {}
    }
}
