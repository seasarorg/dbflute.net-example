
using System;

namespace DfExample.DBFlute.MemberDb.AllCommon.Exp {

    /// <summary>
    /// The exception of when the result size is dangerous.
    /// </summary>
    public class MbDangerousResultSizeException : SystemException {

        protected int _safetyMaxResultSize;

        public MbDangerousResultSizeException(String msg, int safetyMaxResultSize)
        : base(msg) { _safetyMaxResultSize = safetyMaxResultSize; }

        public int SafetyMaxResultSize {
            get { return _safetyMaxResultSize; }
        }
    }
}
