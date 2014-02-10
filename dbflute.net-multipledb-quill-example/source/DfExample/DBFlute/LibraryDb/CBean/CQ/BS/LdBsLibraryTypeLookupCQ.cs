
using System;

using DfExample.DBFlute.LibraryDb.AllCommon.CBean;
using DfExample.DBFlute.LibraryDb.AllCommon.CBean.CValue;
using DfExample.DBFlute.LibraryDb.AllCommon.CBean.SClause;
using DfExample.DBFlute.LibraryDb.AllCommon.JavaLike;
using DfExample.DBFlute.LibraryDb.CBean.CQ;
using DfExample.DBFlute.LibraryDb.CBean.CQ.Ciq;

namespace DfExample.DBFlute.LibraryDb.CBean.CQ.BS {

    [System.Serializable]
    public class LdBsLibraryTypeLookupCQ : LdAbstractBsLibraryTypeLookupCQ {

        protected LdLibraryTypeLookupCIQ _inlineQuery;

        public LdBsLibraryTypeLookupCQ(LdConditionQuery childQuery, LdSqlClause sqlClause, String aliasName, int nestLevel)
            : base(childQuery, sqlClause, aliasName, nestLevel) {}

        public LdLibraryTypeLookupCIQ Inline() {
            if (_inlineQuery == null) {
                _inlineQuery = new LdLibraryTypeLookupCIQ(xgetReferrerQuery(), xgetSqlClause(), xgetAliasName(), xgetNestLevel(), this);
            }
            _inlineQuery.xsetOnClause(false);
            return _inlineQuery;
        }
        
        public LdLibraryTypeLookupCIQ On() {
            if (isBaseQuery()) { throw new UnsupportedOperationException("Unsupported onClause of Base Table!"); }
            LdLibraryTypeLookupCIQ inlineQuery = Inline();
            inlineQuery.xsetOnClause(true);
            return inlineQuery;
        }


        protected LdConditionValue _libraryTypeCode;
        public LdConditionValue LibraryTypeCode {
            get { if (_libraryTypeCode == null) { _libraryTypeCode = new LdConditionValue(); } return _libraryTypeCode; }
        }
        protected override LdConditionValue getCValueLibraryTypeCode() { return this.LibraryTypeCode; }


        protected Map<String, LdLibraryCQ> _libraryTypeCode_ExistsSubQuery_LibraryListMap;
        public Map<String, LdLibraryCQ> LibraryTypeCode_ExistsSubQuery_LibraryList { get { return _libraryTypeCode_ExistsSubQuery_LibraryListMap; }}
        public override String keepLibraryTypeCode_ExistsSubQuery_LibraryList(LdLibraryCQ subQuery) {
            if (_libraryTypeCode_ExistsSubQuery_LibraryListMap == null) { _libraryTypeCode_ExistsSubQuery_LibraryListMap = new LinkedHashMap<String, LdLibraryCQ>(); }
            String key = "subQueryMapKey" + (_libraryTypeCode_ExistsSubQuery_LibraryListMap.size() + 1);
            _libraryTypeCode_ExistsSubQuery_LibraryListMap.put(key, subQuery); return "LibraryTypeCode_ExistsSubQuery_LibraryList." + key;
        }

        protected Map<String, LdLibraryCQ> _libraryTypeCode_NotExistsSubQuery_LibraryListMap;
        public Map<String, LdLibraryCQ> LibraryTypeCode_NotExistsSubQuery_LibraryList { get { return _libraryTypeCode_NotExistsSubQuery_LibraryListMap; }}
        public override String keepLibraryTypeCode_NotExistsSubQuery_LibraryList(LdLibraryCQ subQuery) {
            if (_libraryTypeCode_NotExistsSubQuery_LibraryListMap == null) { _libraryTypeCode_NotExistsSubQuery_LibraryListMap = new LinkedHashMap<String, LdLibraryCQ>(); }
            String key = "subQueryMapKey" + (_libraryTypeCode_NotExistsSubQuery_LibraryListMap.size() + 1);
            _libraryTypeCode_NotExistsSubQuery_LibraryListMap.put(key, subQuery); return "LibraryTypeCode_NotExistsSubQuery_LibraryList." + key;
        }

        protected Map<String, LdLibraryCQ> _libraryTypeCode_InScopeSubQuery_LibraryListMap;
        public Map<String, LdLibraryCQ> LibraryTypeCode_InScopeSubQuery_LibraryList { get { return _libraryTypeCode_InScopeSubQuery_LibraryListMap; }}
        public override String keepLibraryTypeCode_InScopeSubQuery_LibraryList(LdLibraryCQ subQuery) {
            if (_libraryTypeCode_InScopeSubQuery_LibraryListMap == null) { _libraryTypeCode_InScopeSubQuery_LibraryListMap = new LinkedHashMap<String, LdLibraryCQ>(); }
            String key = "subQueryMapKey" + (_libraryTypeCode_InScopeSubQuery_LibraryListMap.size() + 1);
            _libraryTypeCode_InScopeSubQuery_LibraryListMap.put(key, subQuery); return "LibraryTypeCode_InScopeSubQuery_LibraryList." + key;
        }

        protected Map<String, LdLibraryCQ> _libraryTypeCode_NotInScopeSubQuery_LibraryListMap;
        public Map<String, LdLibraryCQ> LibraryTypeCode_NotInScopeSubQuery_LibraryList { get { return _libraryTypeCode_NotInScopeSubQuery_LibraryListMap; }}
        public override String keepLibraryTypeCode_NotInScopeSubQuery_LibraryList(LdLibraryCQ subQuery) {
            if (_libraryTypeCode_NotInScopeSubQuery_LibraryListMap == null) { _libraryTypeCode_NotInScopeSubQuery_LibraryListMap = new LinkedHashMap<String, LdLibraryCQ>(); }
            String key = "subQueryMapKey" + (_libraryTypeCode_NotInScopeSubQuery_LibraryListMap.size() + 1);
            _libraryTypeCode_NotInScopeSubQuery_LibraryListMap.put(key, subQuery); return "LibraryTypeCode_NotInScopeSubQuery_LibraryList." + key;
        }

        protected Map<String, LdLibraryCQ> _libraryTypeCode_SpecifyDerivedReferrer_LibraryListMap;
        public Map<String, LdLibraryCQ> LibraryTypeCode_SpecifyDerivedReferrer_LibraryList { get { return _libraryTypeCode_SpecifyDerivedReferrer_LibraryListMap; }}
        public override String keepLibraryTypeCode_SpecifyDerivedReferrer_LibraryList(LdLibraryCQ subQuery) {
            if (_libraryTypeCode_SpecifyDerivedReferrer_LibraryListMap == null) { _libraryTypeCode_SpecifyDerivedReferrer_LibraryListMap = new LinkedHashMap<String, LdLibraryCQ>(); }
            String key = "subQueryMapKey" + (_libraryTypeCode_SpecifyDerivedReferrer_LibraryListMap.size() + 1);
           _libraryTypeCode_SpecifyDerivedReferrer_LibraryListMap.put(key, subQuery); return "LibraryTypeCode_SpecifyDerivedReferrer_LibraryList." + key;
        }

        protected Map<String, LdLibraryCQ> _libraryTypeCode_QueryDerivedReferrer_LibraryListMap;
        public Map<String, LdLibraryCQ> LibraryTypeCode_QueryDerivedReferrer_LibraryList { get { return _libraryTypeCode_QueryDerivedReferrer_LibraryListMap; } }
        public override String keepLibraryTypeCode_QueryDerivedReferrer_LibraryList(LdLibraryCQ subQuery) {
            if (_libraryTypeCode_QueryDerivedReferrer_LibraryListMap == null) { _libraryTypeCode_QueryDerivedReferrer_LibraryListMap = new LinkedHashMap<String, LdLibraryCQ>(); }
            String key = "subQueryMapKey" + (_libraryTypeCode_QueryDerivedReferrer_LibraryListMap.size() + 1);
            _libraryTypeCode_QueryDerivedReferrer_LibraryListMap.put(key, subQuery); return "LibraryTypeCode_QueryDerivedReferrer_LibraryList." + key;
        }
        protected Map<String, Object> _libraryTypeCode_QueryDerivedReferrer_LibraryListParameterMap;
        public Map<String, Object> LibraryTypeCode_QueryDerivedReferrer_LibraryListParameter { get { return _libraryTypeCode_QueryDerivedReferrer_LibraryListParameterMap; } }
        public override String keepLibraryTypeCode_QueryDerivedReferrer_LibraryListParameter(Object parameterValue) {
            if (_libraryTypeCode_QueryDerivedReferrer_LibraryListParameterMap == null) { _libraryTypeCode_QueryDerivedReferrer_LibraryListParameterMap = new LinkedHashMap<String, Object>(); }
            String key = "subQueryParameterKey" + (_libraryTypeCode_QueryDerivedReferrer_LibraryListParameterMap.size() + 1);
            _libraryTypeCode_QueryDerivedReferrer_LibraryListParameterMap.put(key, parameterValue); return "LibraryTypeCode_QueryDerivedReferrer_LibraryListParameter." + key;
        }

        public LdBsLibraryTypeLookupCQ AddOrderBy_LibraryTypeCode_Asc() { regOBA("LIBRARY_TYPE_CODE");return this; }
        public LdBsLibraryTypeLookupCQ AddOrderBy_LibraryTypeCode_Desc() { regOBD("LIBRARY_TYPE_CODE");return this; }

        protected LdConditionValue _libraryTypeName;
        public LdConditionValue LibraryTypeName {
            get { if (_libraryTypeName == null) { _libraryTypeName = new LdConditionValue(); } return _libraryTypeName; }
        }
        protected override LdConditionValue getCValueLibraryTypeName() { return this.LibraryTypeName; }


        public LdBsLibraryTypeLookupCQ AddOrderBy_LibraryTypeName_Asc() { regOBA("LIBRARY_TYPE_NAME");return this; }
        public LdBsLibraryTypeLookupCQ AddOrderBy_LibraryTypeName_Desc() { regOBD("LIBRARY_TYPE_NAME");return this; }

        protected LdConditionValue _rUser;
        public LdConditionValue RUser {
            get { if (_rUser == null) { _rUser = new LdConditionValue(); } return _rUser; }
        }
        protected override LdConditionValue getCValueRUser() { return this.RUser; }


        public LdBsLibraryTypeLookupCQ AddOrderBy_RUser_Asc() { regOBA("R_USER");return this; }
        public LdBsLibraryTypeLookupCQ AddOrderBy_RUser_Desc() { regOBD("R_USER");return this; }

        protected LdConditionValue _rModule;
        public LdConditionValue RModule {
            get { if (_rModule == null) { _rModule = new LdConditionValue(); } return _rModule; }
        }
        protected override LdConditionValue getCValueRModule() { return this.RModule; }


        public LdBsLibraryTypeLookupCQ AddOrderBy_RModule_Asc() { regOBA("R_MODULE");return this; }
        public LdBsLibraryTypeLookupCQ AddOrderBy_RModule_Desc() { regOBD("R_MODULE");return this; }

        protected LdConditionValue _rTimestamp;
        public LdConditionValue RTimestamp {
            get { if (_rTimestamp == null) { _rTimestamp = new LdConditionValue(); } return _rTimestamp; }
        }
        protected override LdConditionValue getCValueRTimestamp() { return this.RTimestamp; }


        public LdBsLibraryTypeLookupCQ AddOrderBy_RTimestamp_Asc() { regOBA("R_TIMESTAMP");return this; }
        public LdBsLibraryTypeLookupCQ AddOrderBy_RTimestamp_Desc() { regOBD("R_TIMESTAMP");return this; }

        protected LdConditionValue _uUser;
        public LdConditionValue UUser {
            get { if (_uUser == null) { _uUser = new LdConditionValue(); } return _uUser; }
        }
        protected override LdConditionValue getCValueUUser() { return this.UUser; }


        public LdBsLibraryTypeLookupCQ AddOrderBy_UUser_Asc() { regOBA("U_USER");return this; }
        public LdBsLibraryTypeLookupCQ AddOrderBy_UUser_Desc() { regOBD("U_USER");return this; }

        protected LdConditionValue _uModule;
        public LdConditionValue UModule {
            get { if (_uModule == null) { _uModule = new LdConditionValue(); } return _uModule; }
        }
        protected override LdConditionValue getCValueUModule() { return this.UModule; }


        public LdBsLibraryTypeLookupCQ AddOrderBy_UModule_Asc() { regOBA("U_MODULE");return this; }
        public LdBsLibraryTypeLookupCQ AddOrderBy_UModule_Desc() { regOBD("U_MODULE");return this; }

        protected LdConditionValue _uTimestamp;
        public LdConditionValue UTimestamp {
            get { if (_uTimestamp == null) { _uTimestamp = new LdConditionValue(); } return _uTimestamp; }
        }
        protected override LdConditionValue getCValueUTimestamp() { return this.UTimestamp; }


        public LdBsLibraryTypeLookupCQ AddOrderBy_UTimestamp_Asc() { regOBA("U_TIMESTAMP");return this; }
        public LdBsLibraryTypeLookupCQ AddOrderBy_UTimestamp_Desc() { regOBD("U_TIMESTAMP");return this; }

        public LdBsLibraryTypeLookupCQ AddSpecifiedDerivedOrderBy_Asc(String aliasName) { registerSpecifiedDerivedOrderBy_Asc(aliasName); return this; }
        public LdBsLibraryTypeLookupCQ AddSpecifiedDerivedOrderBy_Desc(String aliasName) { registerSpecifiedDerivedOrderBy_Desc(aliasName); return this; }

        public override void reflectRelationOnUnionQuery(LdConditionQuery baseQueryAsSuper, LdConditionQuery unionQueryAsSuper) {

        }
    


	    // ===============================================================================
	    //                                                                 Scalar SubQuery
	    //                                                                 ===============
	    protected Map<String, LdLibraryTypeLookupCQ> _scalarSubQueryMap;
	    public Map<String, LdLibraryTypeLookupCQ> ScalarSubQuery { get { return _scalarSubQueryMap; } }
	    public override String keepScalarSubQuery(LdLibraryTypeLookupCQ subQuery) {
	        if (_scalarSubQueryMap == null) { _scalarSubQueryMap = new LinkedHashMap<String, LdLibraryTypeLookupCQ>(); }
	        String key = "subQueryMapKey" + (_scalarSubQueryMap.size() + 1);
	        _scalarSubQueryMap.put(key, subQuery); return "ScalarSubQuery." + key;
	    }

        // ===============================================================================
        //                                                         Myself InScope SubQuery
        //                                                         =======================
        protected Map<String, LdLibraryTypeLookupCQ> _myselfInScopeSubQueryMap;
        public Map<String, LdLibraryTypeLookupCQ> MyselfInScopeSubQuery { get { return _myselfInScopeSubQueryMap; } }
        public override String keepMyselfInScopeSubQuery(LdLibraryTypeLookupCQ subQuery) {
            if (_myselfInScopeSubQueryMap == null) { _myselfInScopeSubQueryMap = new LinkedHashMap<String, LdLibraryTypeLookupCQ>(); }
            String key = "subQueryMapKey" + (_myselfInScopeSubQueryMap.size() + 1);
            _myselfInScopeSubQueryMap.put(key, subQuery); return "MyselfInScopeSubQuery." + key;
        }
    }
}
