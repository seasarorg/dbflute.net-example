
using System;

using DfExample.DBFlute.LibraryDb.AllCommon.CBean;
using DfExample.DBFlute.LibraryDb.AllCommon.CBean.CValue;
using DfExample.DBFlute.LibraryDb.AllCommon.CBean.SClause;
using DfExample.DBFlute.LibraryDb.AllCommon.JavaLike;
using DfExample.DBFlute.LibraryDb.CBean.CQ;
using DfExample.DBFlute.LibraryDb.CBean.CQ.Ciq;

namespace DfExample.DBFlute.LibraryDb.CBean.CQ.BS {

    [System.Serializable]
    public class LdBsCollectionStatusLookupCQ : LdAbstractBsCollectionStatusLookupCQ {

        protected LdCollectionStatusLookupCIQ _inlineQuery;

        public LdBsCollectionStatusLookupCQ(LdConditionQuery childQuery, LdSqlClause sqlClause, String aliasName, int nestLevel)
            : base(childQuery, sqlClause, aliasName, nestLevel) {}

        public LdCollectionStatusLookupCIQ Inline() {
            if (_inlineQuery == null) {
                _inlineQuery = new LdCollectionStatusLookupCIQ(xgetReferrerQuery(), xgetSqlClause(), xgetAliasName(), xgetNestLevel(), this);
            }
            _inlineQuery.xsetOnClause(false);
            return _inlineQuery;
        }
        
        public LdCollectionStatusLookupCIQ On() {
            if (isBaseQuery()) { throw new UnsupportedOperationException("Unsupported onClause of Base Table!"); }
            LdCollectionStatusLookupCIQ inlineQuery = Inline();
            inlineQuery.xsetOnClause(true);
            return inlineQuery;
        }


        protected LdConditionValue _collectionStatusCode;
        public LdConditionValue CollectionStatusCode {
            get { if (_collectionStatusCode == null) { _collectionStatusCode = new LdConditionValue(); } return _collectionStatusCode; }
        }
        protected override LdConditionValue getCValueCollectionStatusCode() { return this.CollectionStatusCode; }


        protected Map<String, LdCollectionStatusCQ> _collectionStatusCode_ExistsSubQuery_CollectionStatusListMap;
        public Map<String, LdCollectionStatusCQ> CollectionStatusCode_ExistsSubQuery_CollectionStatusList { get { return _collectionStatusCode_ExistsSubQuery_CollectionStatusListMap; }}
        public override String keepCollectionStatusCode_ExistsSubQuery_CollectionStatusList(LdCollectionStatusCQ subQuery) {
            if (_collectionStatusCode_ExistsSubQuery_CollectionStatusListMap == null) { _collectionStatusCode_ExistsSubQuery_CollectionStatusListMap = new LinkedHashMap<String, LdCollectionStatusCQ>(); }
            String key = "subQueryMapKey" + (_collectionStatusCode_ExistsSubQuery_CollectionStatusListMap.size() + 1);
            _collectionStatusCode_ExistsSubQuery_CollectionStatusListMap.put(key, subQuery); return "CollectionStatusCode_ExistsSubQuery_CollectionStatusList." + key;
        }

        protected Map<String, LdCollectionStatusCQ> _collectionStatusCode_NotExistsSubQuery_CollectionStatusListMap;
        public Map<String, LdCollectionStatusCQ> CollectionStatusCode_NotExistsSubQuery_CollectionStatusList { get { return _collectionStatusCode_NotExistsSubQuery_CollectionStatusListMap; }}
        public override String keepCollectionStatusCode_NotExistsSubQuery_CollectionStatusList(LdCollectionStatusCQ subQuery) {
            if (_collectionStatusCode_NotExistsSubQuery_CollectionStatusListMap == null) { _collectionStatusCode_NotExistsSubQuery_CollectionStatusListMap = new LinkedHashMap<String, LdCollectionStatusCQ>(); }
            String key = "subQueryMapKey" + (_collectionStatusCode_NotExistsSubQuery_CollectionStatusListMap.size() + 1);
            _collectionStatusCode_NotExistsSubQuery_CollectionStatusListMap.put(key, subQuery); return "CollectionStatusCode_NotExistsSubQuery_CollectionStatusList." + key;
        }

        protected Map<String, LdCollectionStatusCQ> _collectionStatusCode_InScopeSubQuery_CollectionStatusListMap;
        public Map<String, LdCollectionStatusCQ> CollectionStatusCode_InScopeSubQuery_CollectionStatusList { get { return _collectionStatusCode_InScopeSubQuery_CollectionStatusListMap; }}
        public override String keepCollectionStatusCode_InScopeSubQuery_CollectionStatusList(LdCollectionStatusCQ subQuery) {
            if (_collectionStatusCode_InScopeSubQuery_CollectionStatusListMap == null) { _collectionStatusCode_InScopeSubQuery_CollectionStatusListMap = new LinkedHashMap<String, LdCollectionStatusCQ>(); }
            String key = "subQueryMapKey" + (_collectionStatusCode_InScopeSubQuery_CollectionStatusListMap.size() + 1);
            _collectionStatusCode_InScopeSubQuery_CollectionStatusListMap.put(key, subQuery); return "CollectionStatusCode_InScopeSubQuery_CollectionStatusList." + key;
        }

        protected Map<String, LdCollectionStatusCQ> _collectionStatusCode_NotInScopeSubQuery_CollectionStatusListMap;
        public Map<String, LdCollectionStatusCQ> CollectionStatusCode_NotInScopeSubQuery_CollectionStatusList { get { return _collectionStatusCode_NotInScopeSubQuery_CollectionStatusListMap; }}
        public override String keepCollectionStatusCode_NotInScopeSubQuery_CollectionStatusList(LdCollectionStatusCQ subQuery) {
            if (_collectionStatusCode_NotInScopeSubQuery_CollectionStatusListMap == null) { _collectionStatusCode_NotInScopeSubQuery_CollectionStatusListMap = new LinkedHashMap<String, LdCollectionStatusCQ>(); }
            String key = "subQueryMapKey" + (_collectionStatusCode_NotInScopeSubQuery_CollectionStatusListMap.size() + 1);
            _collectionStatusCode_NotInScopeSubQuery_CollectionStatusListMap.put(key, subQuery); return "CollectionStatusCode_NotInScopeSubQuery_CollectionStatusList." + key;
        }

        protected Map<String, LdCollectionStatusCQ> _collectionStatusCode_SpecifyDerivedReferrer_CollectionStatusListMap;
        public Map<String, LdCollectionStatusCQ> CollectionStatusCode_SpecifyDerivedReferrer_CollectionStatusList { get { return _collectionStatusCode_SpecifyDerivedReferrer_CollectionStatusListMap; }}
        public override String keepCollectionStatusCode_SpecifyDerivedReferrer_CollectionStatusList(LdCollectionStatusCQ subQuery) {
            if (_collectionStatusCode_SpecifyDerivedReferrer_CollectionStatusListMap == null) { _collectionStatusCode_SpecifyDerivedReferrer_CollectionStatusListMap = new LinkedHashMap<String, LdCollectionStatusCQ>(); }
            String key = "subQueryMapKey" + (_collectionStatusCode_SpecifyDerivedReferrer_CollectionStatusListMap.size() + 1);
           _collectionStatusCode_SpecifyDerivedReferrer_CollectionStatusListMap.put(key, subQuery); return "CollectionStatusCode_SpecifyDerivedReferrer_CollectionStatusList." + key;
        }

        protected Map<String, LdCollectionStatusCQ> _collectionStatusCode_QueryDerivedReferrer_CollectionStatusListMap;
        public Map<String, LdCollectionStatusCQ> CollectionStatusCode_QueryDerivedReferrer_CollectionStatusList { get { return _collectionStatusCode_QueryDerivedReferrer_CollectionStatusListMap; } }
        public override String keepCollectionStatusCode_QueryDerivedReferrer_CollectionStatusList(LdCollectionStatusCQ subQuery) {
            if (_collectionStatusCode_QueryDerivedReferrer_CollectionStatusListMap == null) { _collectionStatusCode_QueryDerivedReferrer_CollectionStatusListMap = new LinkedHashMap<String, LdCollectionStatusCQ>(); }
            String key = "subQueryMapKey" + (_collectionStatusCode_QueryDerivedReferrer_CollectionStatusListMap.size() + 1);
            _collectionStatusCode_QueryDerivedReferrer_CollectionStatusListMap.put(key, subQuery); return "CollectionStatusCode_QueryDerivedReferrer_CollectionStatusList." + key;
        }
        protected Map<String, Object> _collectionStatusCode_QueryDerivedReferrer_CollectionStatusListParameterMap;
        public Map<String, Object> CollectionStatusCode_QueryDerivedReferrer_CollectionStatusListParameter { get { return _collectionStatusCode_QueryDerivedReferrer_CollectionStatusListParameterMap; } }
        public override String keepCollectionStatusCode_QueryDerivedReferrer_CollectionStatusListParameter(Object parameterValue) {
            if (_collectionStatusCode_QueryDerivedReferrer_CollectionStatusListParameterMap == null) { _collectionStatusCode_QueryDerivedReferrer_CollectionStatusListParameterMap = new LinkedHashMap<String, Object>(); }
            String key = "subQueryParameterKey" + (_collectionStatusCode_QueryDerivedReferrer_CollectionStatusListParameterMap.size() + 1);
            _collectionStatusCode_QueryDerivedReferrer_CollectionStatusListParameterMap.put(key, parameterValue); return "CollectionStatusCode_QueryDerivedReferrer_CollectionStatusListParameter." + key;
        }

        public LdBsCollectionStatusLookupCQ AddOrderBy_CollectionStatusCode_Asc() { regOBA("COLLECTION_STATUS_CODE");return this; }
        public LdBsCollectionStatusLookupCQ AddOrderBy_CollectionStatusCode_Desc() { regOBD("COLLECTION_STATUS_CODE");return this; }

        protected LdConditionValue _collectionStatusName;
        public LdConditionValue CollectionStatusName {
            get { if (_collectionStatusName == null) { _collectionStatusName = new LdConditionValue(); } return _collectionStatusName; }
        }
        protected override LdConditionValue getCValueCollectionStatusName() { return this.CollectionStatusName; }


        public LdBsCollectionStatusLookupCQ AddOrderBy_CollectionStatusName_Asc() { regOBA("COLLECTION_STATUS_NAME");return this; }
        public LdBsCollectionStatusLookupCQ AddOrderBy_CollectionStatusName_Desc() { regOBD("COLLECTION_STATUS_NAME");return this; }

        protected LdConditionValue _rUser;
        public LdConditionValue RUser {
            get { if (_rUser == null) { _rUser = new LdConditionValue(); } return _rUser; }
        }
        protected override LdConditionValue getCValueRUser() { return this.RUser; }


        public LdBsCollectionStatusLookupCQ AddOrderBy_RUser_Asc() { regOBA("R_USER");return this; }
        public LdBsCollectionStatusLookupCQ AddOrderBy_RUser_Desc() { regOBD("R_USER");return this; }

        protected LdConditionValue _rModule;
        public LdConditionValue RModule {
            get { if (_rModule == null) { _rModule = new LdConditionValue(); } return _rModule; }
        }
        protected override LdConditionValue getCValueRModule() { return this.RModule; }


        public LdBsCollectionStatusLookupCQ AddOrderBy_RModule_Asc() { regOBA("R_MODULE");return this; }
        public LdBsCollectionStatusLookupCQ AddOrderBy_RModule_Desc() { regOBD("R_MODULE");return this; }

        protected LdConditionValue _rTimestamp;
        public LdConditionValue RTimestamp {
            get { if (_rTimestamp == null) { _rTimestamp = new LdConditionValue(); } return _rTimestamp; }
        }
        protected override LdConditionValue getCValueRTimestamp() { return this.RTimestamp; }


        public LdBsCollectionStatusLookupCQ AddOrderBy_RTimestamp_Asc() { regOBA("R_TIMESTAMP");return this; }
        public LdBsCollectionStatusLookupCQ AddOrderBy_RTimestamp_Desc() { regOBD("R_TIMESTAMP");return this; }

        protected LdConditionValue _uUser;
        public LdConditionValue UUser {
            get { if (_uUser == null) { _uUser = new LdConditionValue(); } return _uUser; }
        }
        protected override LdConditionValue getCValueUUser() { return this.UUser; }


        public LdBsCollectionStatusLookupCQ AddOrderBy_UUser_Asc() { regOBA("U_USER");return this; }
        public LdBsCollectionStatusLookupCQ AddOrderBy_UUser_Desc() { regOBD("U_USER");return this; }

        protected LdConditionValue _uModule;
        public LdConditionValue UModule {
            get { if (_uModule == null) { _uModule = new LdConditionValue(); } return _uModule; }
        }
        protected override LdConditionValue getCValueUModule() { return this.UModule; }


        public LdBsCollectionStatusLookupCQ AddOrderBy_UModule_Asc() { regOBA("U_MODULE");return this; }
        public LdBsCollectionStatusLookupCQ AddOrderBy_UModule_Desc() { regOBD("U_MODULE");return this; }

        protected LdConditionValue _uTimestamp;
        public LdConditionValue UTimestamp {
            get { if (_uTimestamp == null) { _uTimestamp = new LdConditionValue(); } return _uTimestamp; }
        }
        protected override LdConditionValue getCValueUTimestamp() { return this.UTimestamp; }


        public LdBsCollectionStatusLookupCQ AddOrderBy_UTimestamp_Asc() { regOBA("U_TIMESTAMP");return this; }
        public LdBsCollectionStatusLookupCQ AddOrderBy_UTimestamp_Desc() { regOBD("U_TIMESTAMP");return this; }

        public LdBsCollectionStatusLookupCQ AddSpecifiedDerivedOrderBy_Asc(String aliasName) { registerSpecifiedDerivedOrderBy_Asc(aliasName); return this; }
        public LdBsCollectionStatusLookupCQ AddSpecifiedDerivedOrderBy_Desc(String aliasName) { registerSpecifiedDerivedOrderBy_Desc(aliasName); return this; }

        public override void reflectRelationOnUnionQuery(LdConditionQuery baseQueryAsSuper, LdConditionQuery unionQueryAsSuper) {

        }
    


	    // ===============================================================================
	    //                                                                 Scalar SubQuery
	    //                                                                 ===============
	    protected Map<String, LdCollectionStatusLookupCQ> _scalarSubQueryMap;
	    public Map<String, LdCollectionStatusLookupCQ> ScalarSubQuery { get { return _scalarSubQueryMap; } }
	    public override String keepScalarSubQuery(LdCollectionStatusLookupCQ subQuery) {
	        if (_scalarSubQueryMap == null) { _scalarSubQueryMap = new LinkedHashMap<String, LdCollectionStatusLookupCQ>(); }
	        String key = "subQueryMapKey" + (_scalarSubQueryMap.size() + 1);
	        _scalarSubQueryMap.put(key, subQuery); return "ScalarSubQuery." + key;
	    }

        // ===============================================================================
        //                                                         Myself InScope SubQuery
        //                                                         =======================
        protected Map<String, LdCollectionStatusLookupCQ> _myselfInScopeSubQueryMap;
        public Map<String, LdCollectionStatusLookupCQ> MyselfInScopeSubQuery { get { return _myselfInScopeSubQueryMap; } }
        public override String keepMyselfInScopeSubQuery(LdCollectionStatusLookupCQ subQuery) {
            if (_myselfInScopeSubQueryMap == null) { _myselfInScopeSubQueryMap = new LinkedHashMap<String, LdCollectionStatusLookupCQ>(); }
            String key = "subQueryMapKey" + (_myselfInScopeSubQueryMap.size() + 1);
            _myselfInScopeSubQueryMap.put(key, subQuery); return "MyselfInScopeSubQuery." + key;
        }
    }
}
