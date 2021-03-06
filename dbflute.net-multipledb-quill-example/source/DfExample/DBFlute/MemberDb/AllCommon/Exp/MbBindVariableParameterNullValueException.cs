
using System;
using System.Collections;

namespace DfExample.DBFlute.MemberDb.AllCommon.Exp {

    /// <summary>
    /// The exception of when the value of bind variable is null about outsideSql.
    /// </summary>
    public class MbBindVariableParameterNullValueException : SystemException {

        public MbBindVariableParameterNullValueException(String msg)
        : base(msg) {}
    }
}
