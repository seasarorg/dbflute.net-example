
using System;
using System.Collections;
using DfExample.DBFlute.MemberDb.AllCommon.CBean.SClause;

namespace DfExample.DBFlute.MemberDb.AllCommon.CBean {

    /// <summary>
    /// The bean of fetch narrowing.
    /// Author: DBFlute(AutoGenerator)
    /// </summary>
    public interface MbFetchNarrowingBean {

        int FetchNarrowingSkipStartIndex { get; }
        int FetchNarrowingLoopCount { get; }
        bool IsFetchNarrowingSkipStartIndexEffective { get; }
        bool IsFetchNarrowingLoopCountEffective { get; }
        bool IsFetchNarrowingEffective { get; }

        /// <summary>
        /// Ignore fetch narrowing. Only checking safety result size is valid. {INTERNAL METHOD}
        /// </summary>
        void IgnoreFetchNarrowing();

        /// <summary>
        /// Restore ignored fetch narrowing. {INTERNAL METHOD}
        /// </summary>
        void RestoreIgnoredFetchNarrowing();

        void CheckSafetyResult(int safetyMaxResultSize);
        int SafetyMaxResultSize { get; }
    }
}
