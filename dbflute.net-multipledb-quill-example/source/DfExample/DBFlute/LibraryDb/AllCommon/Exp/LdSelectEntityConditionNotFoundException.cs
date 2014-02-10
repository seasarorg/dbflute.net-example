
using System;

namespace DfExample.DBFlute.LibraryDb.AllCommon.Exp {

    /// <summary>
    /// The exception of when the condition for selecting an entity is not found.
    /// </summary>
    public class LdSelectEntityConditionNotFoundException : SystemException {

        public LdSelectEntityConditionNotFoundException(String msg)
        : base(msg) {}
    }
}
