
using System;

namespace DfExample.DBFlute.MemberDb.AllCommon.Exp {

    /// <summary>
    /// The exception of when the condition for selecting an entity is not found.
    /// </summary>
    public class MbSelectEntityConditionNotFoundException : SystemException {

        public MbSelectEntityConditionNotFoundException(String msg)
        : base(msg) {}
    }
}
