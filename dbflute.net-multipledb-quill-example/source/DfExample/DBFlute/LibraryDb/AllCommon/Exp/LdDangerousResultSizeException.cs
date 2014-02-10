
using System;

namespace DfExample.DBFlute.LibraryDb.AllCommon.Exp {

    /// <summary>
    /// The exception of when the result size is dangerous.
    /// </summary>
    public class LdDangerousResultSizeException : SystemException {

        protected int _safetyMaxResultSize;

        public LdDangerousResultSizeException(String msg, int safetyMaxResultSize)
        : base(msg) { _safetyMaxResultSize = safetyMaxResultSize; }

        public int SafetyMaxResultSize {
            get { return _safetyMaxResultSize; }
        }
    }
}
