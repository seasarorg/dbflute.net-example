
using System;

using DfExample.DBFlute.LibraryDb.AllCommon.CBean;
using DfExample.DBFlute.LibraryDb.AllCommon.CBean.CValue;
using DfExample.DBFlute.LibraryDb.AllCommon.CBean.SClause;
using DfExample.DBFlute.LibraryDb.AllCommon.JavaLike;
using DfExample.DBFlute.LibraryDb.CBean.CQ;
using DfExample.DBFlute.LibraryDb.CBean.CQ.Ciq;

namespace DfExample.DBFlute.LibraryDb.CBean.CQ.BS {

    [System.Serializable]
    public class LdBsNextLibraryCQ : LdAbstractBsNextLibraryCQ {

        protected LdNextLibraryCIQ _inlineQuery;

        public LdBsNextLibraryCQ(LdConditionQuery childQuery, LdSqlClause sqlClause, String aliasName, int nestLevel)
            : base(childQuery, sqlClause, aliasName, nestLevel) {}

        public LdNextLibraryCIQ Inline() {
            if (_inlineQuery == null) {
                _inlineQuery = new LdNextLibraryCIQ(xgetReferrerQuery(), xgetSqlClause(), xgetAliasName(), xgetNestLevel(), this);
            }
            _inlineQuery.xsetOnClause(false);
            return _inlineQuery;
        }
        
        public LdNextLibraryCIQ On() {
            if (isBaseQuery()) { throw new UnsupportedOperationException("Unsupported onClause of Base Table!"); }
            LdNextLibraryCIQ inlineQuery = Inline();
            inlineQuery.xsetOnClause(true);
            return inlineQuery;
        }


        protected LdConditionValue _libraryId;
        public LdConditionValue LibraryId {
            get { if (_libraryId == null) { _libraryId = new LdConditionValue(); } return _libraryId; }
        }
        protected override LdConditionValue getCValueLibraryId() { return this.LibraryId; }


        protected Map<String, LdLibraryCQ> _libraryId_InScopeSubQuery_LibraryByLibraryIdMap;
        public Map<String, LdLibraryCQ> LibraryId_InScopeSubQuery_LibraryByLibraryId { get { return _libraryId_InScopeSubQuery_LibraryByLibraryIdMap; }}
        public override String keepLibraryId_InScopeSubQuery_LibraryByLibraryId(LdLibraryCQ subQuery) {
            if (_libraryId_InScopeSubQuery_LibraryByLibraryIdMap == null) { _libraryId_InScopeSubQuery_LibraryByLibraryIdMap = new LinkedHashMap<String, LdLibraryCQ>(); }
            String key = "subQueryMapKey" + (_libraryId_InScopeSubQuery_LibraryByLibraryIdMap.size() + 1);
            _libraryId_InScopeSubQuery_LibraryByLibraryIdMap.put(key, subQuery); return "LibraryId_InScopeSubQuery_LibraryByLibraryId." + key;
        }

        protected Map<String, LdLibraryCQ> _libraryId_NotInScopeSubQuery_LibraryByLibraryIdMap;
        public Map<String, LdLibraryCQ> LibraryId_NotInScopeSubQuery_LibraryByLibraryId { get { return _libraryId_NotInScopeSubQuery_LibraryByLibraryIdMap; }}
        public override String keepLibraryId_NotInScopeSubQuery_LibraryByLibraryId(LdLibraryCQ subQuery) {
            if (_libraryId_NotInScopeSubQuery_LibraryByLibraryIdMap == null) { _libraryId_NotInScopeSubQuery_LibraryByLibraryIdMap = new LinkedHashMap<String, LdLibraryCQ>(); }
            String key = "subQueryMapKey" + (_libraryId_NotInScopeSubQuery_LibraryByLibraryIdMap.size() + 1);
            _libraryId_NotInScopeSubQuery_LibraryByLibraryIdMap.put(key, subQuery); return "LibraryId_NotInScopeSubQuery_LibraryByLibraryId." + key;
        }

        public LdBsNextLibraryCQ AddOrderBy_LibraryId_Asc() { regOBA("LIBRARY_ID");return this; }
        public LdBsNextLibraryCQ AddOrderBy_LibraryId_Desc() { regOBD("LIBRARY_ID");return this; }

        protected LdConditionValue _nextLibraryId;
        public LdConditionValue NextLibraryId {
            get { if (_nextLibraryId == null) { _nextLibraryId = new LdConditionValue(); } return _nextLibraryId; }
        }
        protected override LdConditionValue getCValueNextLibraryId() { return this.NextLibraryId; }


        protected Map<String, LdLibraryCQ> _nextLibraryId_InScopeSubQuery_LibraryByNextLibraryIdMap;
        public Map<String, LdLibraryCQ> NextLibraryId_InScopeSubQuery_LibraryByNextLibraryId { get { return _nextLibraryId_InScopeSubQuery_LibraryByNextLibraryIdMap; }}
        public override String keepNextLibraryId_InScopeSubQuery_LibraryByNextLibraryId(LdLibraryCQ subQuery) {
            if (_nextLibraryId_InScopeSubQuery_LibraryByNextLibraryIdMap == null) { _nextLibraryId_InScopeSubQuery_LibraryByNextLibraryIdMap = new LinkedHashMap<String, LdLibraryCQ>(); }
            String key = "subQueryMapKey" + (_nextLibraryId_InScopeSubQuery_LibraryByNextLibraryIdMap.size() + 1);
            _nextLibraryId_InScopeSubQuery_LibraryByNextLibraryIdMap.put(key, subQuery); return "NextLibraryId_InScopeSubQuery_LibraryByNextLibraryId." + key;
        }

        protected Map<String, LdLibraryCQ> _nextLibraryId_NotInScopeSubQuery_LibraryByNextLibraryIdMap;
        public Map<String, LdLibraryCQ> NextLibraryId_NotInScopeSubQuery_LibraryByNextLibraryId { get { return _nextLibraryId_NotInScopeSubQuery_LibraryByNextLibraryIdMap; }}
        public override String keepNextLibraryId_NotInScopeSubQuery_LibraryByNextLibraryId(LdLibraryCQ subQuery) {
            if (_nextLibraryId_NotInScopeSubQuery_LibraryByNextLibraryIdMap == null) { _nextLibraryId_NotInScopeSubQuery_LibraryByNextLibraryIdMap = new LinkedHashMap<String, LdLibraryCQ>(); }
            String key = "subQueryMapKey" + (_nextLibraryId_NotInScopeSubQuery_LibraryByNextLibraryIdMap.size() + 1);
            _nextLibraryId_NotInScopeSubQuery_LibraryByNextLibraryIdMap.put(key, subQuery); return "NextLibraryId_NotInScopeSubQuery_LibraryByNextLibraryId." + key;
        }

        public LdBsNextLibraryCQ AddOrderBy_NextLibraryId_Asc() { regOBA("NEXT_LIBRARY_ID");return this; }
        public LdBsNextLibraryCQ AddOrderBy_NextLibraryId_Desc() { regOBD("NEXT_LIBRARY_ID");return this; }

        protected LdConditionValue _distanceKm;
        public LdConditionValue DistanceKm {
            get { if (_distanceKm == null) { _distanceKm = new LdConditionValue(); } return _distanceKm; }
        }
        protected override LdConditionValue getCValueDistanceKm() { return this.DistanceKm; }


        public LdBsNextLibraryCQ AddOrderBy_DistanceKm_Asc() { regOBA("DISTANCE_KM");return this; }
        public LdBsNextLibraryCQ AddOrderBy_DistanceKm_Desc() { regOBD("DISTANCE_KM");return this; }

        protected LdConditionValue _rUser;
        public LdConditionValue RUser {
            get { if (_rUser == null) { _rUser = new LdConditionValue(); } return _rUser; }
        }
        protected override LdConditionValue getCValueRUser() { return this.RUser; }


        public LdBsNextLibraryCQ AddOrderBy_RUser_Asc() { regOBA("R_USER");return this; }
        public LdBsNextLibraryCQ AddOrderBy_RUser_Desc() { regOBD("R_USER");return this; }

        protected LdConditionValue _rModule;
        public LdConditionValue RModule {
            get { if (_rModule == null) { _rModule = new LdConditionValue(); } return _rModule; }
        }
        protected override LdConditionValue getCValueRModule() { return this.RModule; }


        public LdBsNextLibraryCQ AddOrderBy_RModule_Asc() { regOBA("R_MODULE");return this; }
        public LdBsNextLibraryCQ AddOrderBy_RModule_Desc() { regOBD("R_MODULE");return this; }

        protected LdConditionValue _rTimestamp;
        public LdConditionValue RTimestamp {
            get { if (_rTimestamp == null) { _rTimestamp = new LdConditionValue(); } return _rTimestamp; }
        }
        protected override LdConditionValue getCValueRTimestamp() { return this.RTimestamp; }


        public LdBsNextLibraryCQ AddOrderBy_RTimestamp_Asc() { regOBA("R_TIMESTAMP");return this; }
        public LdBsNextLibraryCQ AddOrderBy_RTimestamp_Desc() { regOBD("R_TIMESTAMP");return this; }

        protected LdConditionValue _uUser;
        public LdConditionValue UUser {
            get { if (_uUser == null) { _uUser = new LdConditionValue(); } return _uUser; }
        }
        protected override LdConditionValue getCValueUUser() { return this.UUser; }


        public LdBsNextLibraryCQ AddOrderBy_UUser_Asc() { regOBA("U_USER");return this; }
        public LdBsNextLibraryCQ AddOrderBy_UUser_Desc() { regOBD("U_USER");return this; }

        protected LdConditionValue _uModule;
        public LdConditionValue UModule {
            get { if (_uModule == null) { _uModule = new LdConditionValue(); } return _uModule; }
        }
        protected override LdConditionValue getCValueUModule() { return this.UModule; }


        public LdBsNextLibraryCQ AddOrderBy_UModule_Asc() { regOBA("U_MODULE");return this; }
        public LdBsNextLibraryCQ AddOrderBy_UModule_Desc() { regOBD("U_MODULE");return this; }

        protected LdConditionValue _uTimestamp;
        public LdConditionValue UTimestamp {
            get { if (_uTimestamp == null) { _uTimestamp = new LdConditionValue(); } return _uTimestamp; }
        }
        protected override LdConditionValue getCValueUTimestamp() { return this.UTimestamp; }


        public LdBsNextLibraryCQ AddOrderBy_UTimestamp_Asc() { regOBA("U_TIMESTAMP");return this; }
        public LdBsNextLibraryCQ AddOrderBy_UTimestamp_Desc() { regOBD("U_TIMESTAMP");return this; }

        public LdBsNextLibraryCQ AddSpecifiedDerivedOrderBy_Asc(String aliasName) { registerSpecifiedDerivedOrderBy_Asc(aliasName); return this; }
        public LdBsNextLibraryCQ AddSpecifiedDerivedOrderBy_Desc(String aliasName) { registerSpecifiedDerivedOrderBy_Desc(aliasName); return this; }

        public override void reflectRelationOnUnionQuery(LdConditionQuery baseQueryAsSuper, LdConditionQuery unionQueryAsSuper) {
            LdNextLibraryCQ baseQuery = (LdNextLibraryCQ)baseQueryAsSuper;
            LdNextLibraryCQ unionQuery = (LdNextLibraryCQ)unionQueryAsSuper;
            if (baseQuery.hasConditionQueryLibraryByLibraryId()) {
                unionQuery.QueryLibraryByLibraryId().reflectRelationOnUnionQuery(baseQuery.QueryLibraryByLibraryId(), unionQuery.QueryLibraryByLibraryId());
            }
            if (baseQuery.hasConditionQueryLibraryByNextLibraryId()) {
                unionQuery.QueryLibraryByNextLibraryId().reflectRelationOnUnionQuery(baseQuery.QueryLibraryByNextLibraryId(), unionQuery.QueryLibraryByNextLibraryId());
            }

        }
    
        protected LdLibraryCQ _conditionQueryLibraryByLibraryId;
        public LdLibraryCQ QueryLibraryByLibraryId() {
            return this.ConditionQueryLibraryByLibraryId;
        }
        public LdLibraryCQ ConditionQueryLibraryByLibraryId {
            get {
                if (_conditionQueryLibraryByLibraryId == null) {
                    _conditionQueryLibraryByLibraryId = xcreateQueryLibraryByLibraryId();
                    xsetupOuterJoin_LibraryByLibraryId();
                }
                return _conditionQueryLibraryByLibraryId;
            }
        }
        protected LdLibraryCQ xcreateQueryLibraryByLibraryId() {
            String nrp = resolveNextRelationPathLibraryByLibraryId();
            String jan = resolveJoinAliasName(nrp, xgetNextNestLevel());
            LdLibraryCQ cq = new LdLibraryCQ(this, xgetSqlClause(), jan, xgetNextNestLevel());
            cq.xsetForeignPropertyName("libraryByLibraryId"); cq.xsetRelationPath(nrp); return cq;
        }
        public void xsetupOuterJoin_LibraryByLibraryId() {
            LdLibraryCQ cq = ConditionQueryLibraryByLibraryId;
            Map<String, String> joinOnMap = new LinkedHashMap<String, String>();
            joinOnMap.put("LIBRARY_ID", "LIBRARY_ID");
            registerOuterJoin(cq, joinOnMap);
        }
        protected String resolveNextRelationPathLibraryByLibraryId() {
            return resolveNextRelationPath("next_library", "libraryByLibraryId");
        }
        public bool hasConditionQueryLibraryByLibraryId() {
            return _conditionQueryLibraryByLibraryId != null;
        }
        protected LdLibraryCQ _conditionQueryLibraryByNextLibraryId;
        public LdLibraryCQ QueryLibraryByNextLibraryId() {
            return this.ConditionQueryLibraryByNextLibraryId;
        }
        public LdLibraryCQ ConditionQueryLibraryByNextLibraryId {
            get {
                if (_conditionQueryLibraryByNextLibraryId == null) {
                    _conditionQueryLibraryByNextLibraryId = xcreateQueryLibraryByNextLibraryId();
                    xsetupOuterJoin_LibraryByNextLibraryId();
                }
                return _conditionQueryLibraryByNextLibraryId;
            }
        }
        protected LdLibraryCQ xcreateQueryLibraryByNextLibraryId() {
            String nrp = resolveNextRelationPathLibraryByNextLibraryId();
            String jan = resolveJoinAliasName(nrp, xgetNextNestLevel());
            LdLibraryCQ cq = new LdLibraryCQ(this, xgetSqlClause(), jan, xgetNextNestLevel());
            cq.xsetForeignPropertyName("libraryByNextLibraryId"); cq.xsetRelationPath(nrp); return cq;
        }
        public void xsetupOuterJoin_LibraryByNextLibraryId() {
            LdLibraryCQ cq = ConditionQueryLibraryByNextLibraryId;
            Map<String, String> joinOnMap = new LinkedHashMap<String, String>();
            joinOnMap.put("NEXT_LIBRARY_ID", "LIBRARY_ID");
            registerOuterJoin(cq, joinOnMap);
        }
        protected String resolveNextRelationPathLibraryByNextLibraryId() {
            return resolveNextRelationPath("next_library", "libraryByNextLibraryId");
        }
        public bool hasConditionQueryLibraryByNextLibraryId() {
            return _conditionQueryLibraryByNextLibraryId != null;
        }

    }
}
