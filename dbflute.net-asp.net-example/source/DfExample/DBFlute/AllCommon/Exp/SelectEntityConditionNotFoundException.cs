
using System;

namespace DfExample.DBFlute.AllCommon.Exp {

    /// <summary>
    /// The exception of when the condition for selecting an entity is not found.
    /// </summary>
    public class SelectEntityConditionNotFoundException : SystemException {

        public SelectEntityConditionNotFoundException(String msg)
        : base(msg) {}
    }
}
