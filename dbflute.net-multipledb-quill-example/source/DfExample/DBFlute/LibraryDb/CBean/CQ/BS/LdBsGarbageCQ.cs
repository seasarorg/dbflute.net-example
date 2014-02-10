
using System;

using DfExample.DBFlute.LibraryDb.AllCommon.CBean;
using DfExample.DBFlute.LibraryDb.AllCommon.CBean.CValue;
using DfExample.DBFlute.LibraryDb.AllCommon.CBean.SClause;
using DfExample.DBFlute.LibraryDb.AllCommon.JavaLike;
using DfExample.DBFlute.LibraryDb.CBean.CQ;
using DfExample.DBFlute.LibraryDb.CBean.CQ.Ciq;

namespace DfExample.DBFlute.LibraryDb.CBean.CQ.BS {

    [System.Serializable]
    public class LdBsGarbageCQ : LdAbstractBsGarbageCQ {

        protected LdGarbageCIQ _inlineQuery;

        public LdBsGarbageCQ(LdConditionQuery childQuery, LdSqlClause sqlClause, String aliasName, int nestLevel)
            : base(childQuery, sqlClause, aliasName, nestLevel) {}

        public LdGarbageCIQ Inline() {
            if (_inlineQuery == null) {
                _inlineQuery = new LdGarbageCIQ(xgetReferrerQuery(), xgetSqlClause(), xgetAliasName(), xgetNestLevel(), this);
            }
            _inlineQuery.xsetOnClause(false);
            return _inlineQuery;
        }
        
        public LdGarbageCIQ On() {
            if (isBaseQuery()) { throw new UnsupportedOperationException("Unsupported onClause of Base Table!"); }
            LdGarbageCIQ inlineQuery = Inline();
            inlineQuery.xsetOnClause(true);
            return inlineQuery;
        }


        protected LdConditionValue _garbageMemo;
        public LdConditionValue GarbageMemo {
            get { if (_garbageMemo == null) { _garbageMemo = new LdConditionValue(); } return _garbageMemo; }
        }
        protected override LdConditionValue getCValueGarbageMemo() { return this.GarbageMemo; }


        public LdBsGarbageCQ AddOrderBy_GarbageMemo_Asc() { regOBA("GARBAGE_MEMO");return this; }
        public LdBsGarbageCQ AddOrderBy_GarbageMemo_Desc() { regOBD("GARBAGE_MEMO");return this; }

        protected LdConditionValue _garbageTime;
        public LdConditionValue GarbageTime {
            get { if (_garbageTime == null) { _garbageTime = new LdConditionValue(); } return _garbageTime; }
        }
        protected override LdConditionValue getCValueGarbageTime() { return this.GarbageTime; }


        public LdBsGarbageCQ AddOrderBy_GarbageTime_Asc() { regOBA("GARBAGE_TIME");return this; }
        public LdBsGarbageCQ AddOrderBy_GarbageTime_Desc() { regOBD("GARBAGE_TIME");return this; }

        protected LdConditionValue _garbageCount;
        public LdConditionValue GarbageCount {
            get { if (_garbageCount == null) { _garbageCount = new LdConditionValue(); } return _garbageCount; }
        }
        protected override LdConditionValue getCValueGarbageCount() { return this.GarbageCount; }


        public LdBsGarbageCQ AddOrderBy_GarbageCount_Asc() { regOBA("GARBAGE_COUNT");return this; }
        public LdBsGarbageCQ AddOrderBy_GarbageCount_Desc() { regOBD("GARBAGE_COUNT");return this; }

        protected LdConditionValue _rUser;
        public LdConditionValue RUser {
            get { if (_rUser == null) { _rUser = new LdConditionValue(); } return _rUser; }
        }
        protected override LdConditionValue getCValueRUser() { return this.RUser; }


        public LdBsGarbageCQ AddOrderBy_RUser_Asc() { regOBA("R_USER");return this; }
        public LdBsGarbageCQ AddOrderBy_RUser_Desc() { regOBD("R_USER");return this; }

        protected LdConditionValue _rTimestamp;
        public LdConditionValue RTimestamp {
            get { if (_rTimestamp == null) { _rTimestamp = new LdConditionValue(); } return _rTimestamp; }
        }
        protected override LdConditionValue getCValueRTimestamp() { return this.RTimestamp; }


        public LdBsGarbageCQ AddOrderBy_RTimestamp_Asc() { regOBA("R_TIMESTAMP");return this; }
        public LdBsGarbageCQ AddOrderBy_RTimestamp_Desc() { regOBD("R_TIMESTAMP");return this; }

        protected LdConditionValue _uUser;
        public LdConditionValue UUser {
            get { if (_uUser == null) { _uUser = new LdConditionValue(); } return _uUser; }
        }
        protected override LdConditionValue getCValueUUser() { return this.UUser; }


        public LdBsGarbageCQ AddOrderBy_UUser_Asc() { regOBA("U_USER");return this; }
        public LdBsGarbageCQ AddOrderBy_UUser_Desc() { regOBD("U_USER");return this; }

        protected LdConditionValue _uTimestamp;
        public LdConditionValue UTimestamp {
            get { if (_uTimestamp == null) { _uTimestamp = new LdConditionValue(); } return _uTimestamp; }
        }
        protected override LdConditionValue getCValueUTimestamp() { return this.UTimestamp; }


        public LdBsGarbageCQ AddOrderBy_UTimestamp_Asc() { regOBA("U_TIMESTAMP");return this; }
        public LdBsGarbageCQ AddOrderBy_UTimestamp_Desc() { regOBD("U_TIMESTAMP");return this; }

        public LdBsGarbageCQ AddSpecifiedDerivedOrderBy_Asc(String aliasName) { registerSpecifiedDerivedOrderBy_Asc(aliasName); return this; }
        public LdBsGarbageCQ AddSpecifiedDerivedOrderBy_Desc(String aliasName) { registerSpecifiedDerivedOrderBy_Desc(aliasName); return this; }

        public override void reflectRelationOnUnionQuery(LdConditionQuery baseQueryAsSuper, LdConditionQuery unionQueryAsSuper) {

        }
    

    }
}
