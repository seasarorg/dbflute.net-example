
using System;

using DfExample.DBFlute.LibraryDb.AllCommon.CBean;
using DfExample.DBFlute.LibraryDb.AllCommon.CBean.CValue;
using DfExample.DBFlute.LibraryDb.AllCommon.CBean.SClause;
using DfExample.DBFlute.LibraryDb.AllCommon.JavaLike;
using DfExample.DBFlute.LibraryDb.CBean.CQ;
using DfExample.DBFlute.LibraryDb.CBean.CQ.Ciq;

namespace DfExample.DBFlute.LibraryDb.CBean.CQ.BS {

    [System.Serializable]
    public class LdBsCollectionStatusCQ : LdAbstractBsCollectionStatusCQ {

        protected LdCollectionStatusCIQ _inlineQuery;

        public LdBsCollectionStatusCQ(LdConditionQuery childQuery, LdSqlClause sqlClause, String aliasName, int nestLevel)
            : base(childQuery, sqlClause, aliasName, nestLevel) {}

        public LdCollectionStatusCIQ Inline() {
            if (_inlineQuery == null) {
                _inlineQuery = new LdCollectionStatusCIQ(xgetReferrerQuery(), xgetSqlClause(), xgetAliasName(), xgetNestLevel(), this);
            }
            _inlineQuery.xsetOnClause(false);
            return _inlineQuery;
        }
        
        public LdCollectionStatusCIQ On() {
            if (isBaseQuery()) { throw new UnsupportedOperationException("Unsupported onClause of Base Table!"); }
            LdCollectionStatusCIQ inlineQuery = Inline();
            inlineQuery.xsetOnClause(true);
            return inlineQuery;
        }


        protected LdConditionValue _collectionId;
        public LdConditionValue CollectionId {
            get { if (_collectionId == null) { _collectionId = new LdConditionValue(); } return _collectionId; }
        }
        protected override LdConditionValue getCValueCollectionId() { return this.CollectionId; }


        protected Map<String, LdCollectionCQ> _collectionId_InScopeSubQuery_CollectionMap;
        public Map<String, LdCollectionCQ> CollectionId_InScopeSubQuery_Collection { get { return _collectionId_InScopeSubQuery_CollectionMap; }}
        public override String keepCollectionId_InScopeSubQuery_Collection(LdCollectionCQ subQuery) {
            if (_collectionId_InScopeSubQuery_CollectionMap == null) { _collectionId_InScopeSubQuery_CollectionMap = new LinkedHashMap<String, LdCollectionCQ>(); }
            String key = "subQueryMapKey" + (_collectionId_InScopeSubQuery_CollectionMap.size() + 1);
            _collectionId_InScopeSubQuery_CollectionMap.put(key, subQuery); return "CollectionId_InScopeSubQuery_Collection." + key;
        }

        protected Map<String, LdCollectionCQ> _collectionId_NotInScopeSubQuery_CollectionMap;
        public Map<String, LdCollectionCQ> CollectionId_NotInScopeSubQuery_Collection { get { return _collectionId_NotInScopeSubQuery_CollectionMap; }}
        public override String keepCollectionId_NotInScopeSubQuery_Collection(LdCollectionCQ subQuery) {
            if (_collectionId_NotInScopeSubQuery_CollectionMap == null) { _collectionId_NotInScopeSubQuery_CollectionMap = new LinkedHashMap<String, LdCollectionCQ>(); }
            String key = "subQueryMapKey" + (_collectionId_NotInScopeSubQuery_CollectionMap.size() + 1);
            _collectionId_NotInScopeSubQuery_CollectionMap.put(key, subQuery); return "CollectionId_NotInScopeSubQuery_Collection." + key;
        }

        public LdBsCollectionStatusCQ AddOrderBy_CollectionId_Asc() { regOBA("COLLECTION_ID");return this; }
        public LdBsCollectionStatusCQ AddOrderBy_CollectionId_Desc() { regOBD("COLLECTION_ID");return this; }

        protected LdConditionValue _collectionStatusCode;
        public LdConditionValue CollectionStatusCode {
            get { if (_collectionStatusCode == null) { _collectionStatusCode = new LdConditionValue(); } return _collectionStatusCode; }
        }
        protected override LdConditionValue getCValueCollectionStatusCode() { return this.CollectionStatusCode; }


        protected Map<String, LdCollectionStatusLookupCQ> _collectionStatusCode_InScopeSubQuery_CollectionStatusLookupMap;
        public Map<String, LdCollectionStatusLookupCQ> CollectionStatusCode_InScopeSubQuery_CollectionStatusLookup { get { return _collectionStatusCode_InScopeSubQuery_CollectionStatusLookupMap; }}
        public override String keepCollectionStatusCode_InScopeSubQuery_CollectionStatusLookup(LdCollectionStatusLookupCQ subQuery) {
            if (_collectionStatusCode_InScopeSubQuery_CollectionStatusLookupMap == null) { _collectionStatusCode_InScopeSubQuery_CollectionStatusLookupMap = new LinkedHashMap<String, LdCollectionStatusLookupCQ>(); }
            String key = "subQueryMapKey" + (_collectionStatusCode_InScopeSubQuery_CollectionStatusLookupMap.size() + 1);
            _collectionStatusCode_InScopeSubQuery_CollectionStatusLookupMap.put(key, subQuery); return "CollectionStatusCode_InScopeSubQuery_CollectionStatusLookup." + key;
        }

        protected Map<String, LdCollectionStatusLookupCQ> _collectionStatusCode_NotInScopeSubQuery_CollectionStatusLookupMap;
        public Map<String, LdCollectionStatusLookupCQ> CollectionStatusCode_NotInScopeSubQuery_CollectionStatusLookup { get { return _collectionStatusCode_NotInScopeSubQuery_CollectionStatusLookupMap; }}
        public override String keepCollectionStatusCode_NotInScopeSubQuery_CollectionStatusLookup(LdCollectionStatusLookupCQ subQuery) {
            if (_collectionStatusCode_NotInScopeSubQuery_CollectionStatusLookupMap == null) { _collectionStatusCode_NotInScopeSubQuery_CollectionStatusLookupMap = new LinkedHashMap<String, LdCollectionStatusLookupCQ>(); }
            String key = "subQueryMapKey" + (_collectionStatusCode_NotInScopeSubQuery_CollectionStatusLookupMap.size() + 1);
            _collectionStatusCode_NotInScopeSubQuery_CollectionStatusLookupMap.put(key, subQuery); return "CollectionStatusCode_NotInScopeSubQuery_CollectionStatusLookup." + key;
        }

        public LdBsCollectionStatusCQ AddOrderBy_CollectionStatusCode_Asc() { regOBA("COLLECTION_STATUS_CODE");return this; }
        public LdBsCollectionStatusCQ AddOrderBy_CollectionStatusCode_Desc() { regOBD("COLLECTION_STATUS_CODE");return this; }

        protected LdConditionValue _rUser;
        public LdConditionValue RUser {
            get { if (_rUser == null) { _rUser = new LdConditionValue(); } return _rUser; }
        }
        protected override LdConditionValue getCValueRUser() { return this.RUser; }


        public LdBsCollectionStatusCQ AddOrderBy_RUser_Asc() { regOBA("R_USER");return this; }
        public LdBsCollectionStatusCQ AddOrderBy_RUser_Desc() { regOBD("R_USER");return this; }

        protected LdConditionValue _rModule;
        public LdConditionValue RModule {
            get { if (_rModule == null) { _rModule = new LdConditionValue(); } return _rModule; }
        }
        protected override LdConditionValue getCValueRModule() { return this.RModule; }


        public LdBsCollectionStatusCQ AddOrderBy_RModule_Asc() { regOBA("R_MODULE");return this; }
        public LdBsCollectionStatusCQ AddOrderBy_RModule_Desc() { regOBD("R_MODULE");return this; }

        protected LdConditionValue _rTimestamp;
        public LdConditionValue RTimestamp {
            get { if (_rTimestamp == null) { _rTimestamp = new LdConditionValue(); } return _rTimestamp; }
        }
        protected override LdConditionValue getCValueRTimestamp() { return this.RTimestamp; }


        public LdBsCollectionStatusCQ AddOrderBy_RTimestamp_Asc() { regOBA("R_TIMESTAMP");return this; }
        public LdBsCollectionStatusCQ AddOrderBy_RTimestamp_Desc() { regOBD("R_TIMESTAMP");return this; }

        protected LdConditionValue _uUser;
        public LdConditionValue UUser {
            get { if (_uUser == null) { _uUser = new LdConditionValue(); } return _uUser; }
        }
        protected override LdConditionValue getCValueUUser() { return this.UUser; }


        public LdBsCollectionStatusCQ AddOrderBy_UUser_Asc() { regOBA("U_USER");return this; }
        public LdBsCollectionStatusCQ AddOrderBy_UUser_Desc() { regOBD("U_USER");return this; }

        protected LdConditionValue _uModule;
        public LdConditionValue UModule {
            get { if (_uModule == null) { _uModule = new LdConditionValue(); } return _uModule; }
        }
        protected override LdConditionValue getCValueUModule() { return this.UModule; }


        public LdBsCollectionStatusCQ AddOrderBy_UModule_Asc() { regOBA("U_MODULE");return this; }
        public LdBsCollectionStatusCQ AddOrderBy_UModule_Desc() { regOBD("U_MODULE");return this; }

        protected LdConditionValue _uTimestamp;
        public LdConditionValue UTimestamp {
            get { if (_uTimestamp == null) { _uTimestamp = new LdConditionValue(); } return _uTimestamp; }
        }
        protected override LdConditionValue getCValueUTimestamp() { return this.UTimestamp; }


        public LdBsCollectionStatusCQ AddOrderBy_UTimestamp_Asc() { regOBA("U_TIMESTAMP");return this; }
        public LdBsCollectionStatusCQ AddOrderBy_UTimestamp_Desc() { regOBD("U_TIMESTAMP");return this; }

        public LdBsCollectionStatusCQ AddSpecifiedDerivedOrderBy_Asc(String aliasName) { registerSpecifiedDerivedOrderBy_Asc(aliasName); return this; }
        public LdBsCollectionStatusCQ AddSpecifiedDerivedOrderBy_Desc(String aliasName) { registerSpecifiedDerivedOrderBy_Desc(aliasName); return this; }

        public override void reflectRelationOnUnionQuery(LdConditionQuery baseQueryAsSuper, LdConditionQuery unionQueryAsSuper) {
            LdCollectionStatusCQ baseQuery = (LdCollectionStatusCQ)baseQueryAsSuper;
            LdCollectionStatusCQ unionQuery = (LdCollectionStatusCQ)unionQueryAsSuper;
            if (baseQuery.hasConditionQueryCollection()) {
                unionQuery.QueryCollection().reflectRelationOnUnionQuery(baseQuery.QueryCollection(), unionQuery.QueryCollection());
            }
            if (baseQuery.hasConditionQueryCollectionStatusLookup()) {
                unionQuery.QueryCollectionStatusLookup().reflectRelationOnUnionQuery(baseQuery.QueryCollectionStatusLookup(), unionQuery.QueryCollectionStatusLookup());
            }

        }
    
        protected LdCollectionCQ _conditionQueryCollection;
        public LdCollectionCQ QueryCollection() {
            return this.ConditionQueryCollection;
        }
        public LdCollectionCQ ConditionQueryCollection {
            get {
                if (_conditionQueryCollection == null) {
                    _conditionQueryCollection = xcreateQueryCollection();
                    xsetupOuterJoin_Collection();
                }
                return _conditionQueryCollection;
            }
        }
        protected LdCollectionCQ xcreateQueryCollection() {
            String nrp = resolveNextRelationPathCollection();
            String jan = resolveJoinAliasName(nrp, xgetNextNestLevel());
            LdCollectionCQ cq = new LdCollectionCQ(this, xgetSqlClause(), jan, xgetNextNestLevel());
            cq.xsetForeignPropertyName("collection"); cq.xsetRelationPath(nrp); return cq;
        }
        public void xsetupOuterJoin_Collection() {
            LdCollectionCQ cq = ConditionQueryCollection;
            Map<String, String> joinOnMap = new LinkedHashMap<String, String>();
            joinOnMap.put("COLLECTION_ID", "COLLECTION_ID");
            registerOuterJoin(cq, joinOnMap);
        }
        protected String resolveNextRelationPathCollection() {
            return resolveNextRelationPath("collection_status", "collection");
        }
        public bool hasConditionQueryCollection() {
            return _conditionQueryCollection != null;
        }
        protected LdCollectionStatusLookupCQ _conditionQueryCollectionStatusLookup;
        public LdCollectionStatusLookupCQ QueryCollectionStatusLookup() {
            return this.ConditionQueryCollectionStatusLookup;
        }
        public LdCollectionStatusLookupCQ ConditionQueryCollectionStatusLookup {
            get {
                if (_conditionQueryCollectionStatusLookup == null) {
                    _conditionQueryCollectionStatusLookup = xcreateQueryCollectionStatusLookup();
                    xsetupOuterJoin_CollectionStatusLookup();
                }
                return _conditionQueryCollectionStatusLookup;
            }
        }
        protected LdCollectionStatusLookupCQ xcreateQueryCollectionStatusLookup() {
            String nrp = resolveNextRelationPathCollectionStatusLookup();
            String jan = resolveJoinAliasName(nrp, xgetNextNestLevel());
            LdCollectionStatusLookupCQ cq = new LdCollectionStatusLookupCQ(this, xgetSqlClause(), jan, xgetNextNestLevel());
            cq.xsetForeignPropertyName("collectionStatusLookup"); cq.xsetRelationPath(nrp); return cq;
        }
        public void xsetupOuterJoin_CollectionStatusLookup() {
            LdCollectionStatusLookupCQ cq = ConditionQueryCollectionStatusLookup;
            Map<String, String> joinOnMap = new LinkedHashMap<String, String>();
            joinOnMap.put("COLLECTION_STATUS_CODE", "COLLECTION_STATUS_CODE");
            registerOuterJoin(cq, joinOnMap);
        }
        protected String resolveNextRelationPathCollectionStatusLookup() {
            return resolveNextRelationPath("collection_status", "collectionStatusLookup");
        }
        public bool hasConditionQueryCollectionStatusLookup() {
            return _conditionQueryCollectionStatusLookup != null;
        }


	    // ===============================================================================
	    //                                                                 Scalar SubQuery
	    //                                                                 ===============
	    protected Map<String, LdCollectionStatusCQ> _scalarSubQueryMap;
	    public Map<String, LdCollectionStatusCQ> ScalarSubQuery { get { return _scalarSubQueryMap; } }
	    public override String keepScalarSubQuery(LdCollectionStatusCQ subQuery) {
	        if (_scalarSubQueryMap == null) { _scalarSubQueryMap = new LinkedHashMap<String, LdCollectionStatusCQ>(); }
	        String key = "subQueryMapKey" + (_scalarSubQueryMap.size() + 1);
	        _scalarSubQueryMap.put(key, subQuery); return "ScalarSubQuery." + key;
	    }

        // ===============================================================================
        //                                                         Myself InScope SubQuery
        //                                                         =======================
        protected Map<String, LdCollectionStatusCQ> _myselfInScopeSubQueryMap;
        public Map<String, LdCollectionStatusCQ> MyselfInScopeSubQuery { get { return _myselfInScopeSubQueryMap; } }
        public override String keepMyselfInScopeSubQuery(LdCollectionStatusCQ subQuery) {
            if (_myselfInScopeSubQueryMap == null) { _myselfInScopeSubQueryMap = new LinkedHashMap<String, LdCollectionStatusCQ>(); }
            String key = "subQueryMapKey" + (_myselfInScopeSubQueryMap.size() + 1);
            _myselfInScopeSubQueryMap.put(key, subQuery); return "MyselfInScopeSubQuery." + key;
        }
    }
}
