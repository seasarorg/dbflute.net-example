
using System;

using DfExample.DBFlute.LibraryDb.AllCommon.CBean;
using DfExample.DBFlute.LibraryDb.AllCommon.CBean.CValue;
using DfExample.DBFlute.LibraryDb.AllCommon.CBean.SClause;
using DfExample.DBFlute.LibraryDb.AllCommon.JavaLike;
using DfExample.DBFlute.LibraryDb.CBean.CQ;
using DfExample.DBFlute.LibraryDb.CBean.CQ.Ciq;

namespace DfExample.DBFlute.LibraryDb.CBean.CQ.BS {

    [System.Serializable]
    public class LdBsBlackActionLookupCQ : LdAbstractBsBlackActionLookupCQ {

        protected LdBlackActionLookupCIQ _inlineQuery;

        public LdBsBlackActionLookupCQ(LdConditionQuery childQuery, LdSqlClause sqlClause, String aliasName, int nestLevel)
            : base(childQuery, sqlClause, aliasName, nestLevel) {}

        public LdBlackActionLookupCIQ Inline() {
            if (_inlineQuery == null) {
                _inlineQuery = new LdBlackActionLookupCIQ(xgetReferrerQuery(), xgetSqlClause(), xgetAliasName(), xgetNestLevel(), this);
            }
            _inlineQuery.xsetOnClause(false);
            return _inlineQuery;
        }
        
        public LdBlackActionLookupCIQ On() {
            if (isBaseQuery()) { throw new UnsupportedOperationException("Unsupported onClause of Base Table!"); }
            LdBlackActionLookupCIQ inlineQuery = Inline();
            inlineQuery.xsetOnClause(true);
            return inlineQuery;
        }


        protected LdConditionValue _blackActionCode;
        public LdConditionValue BlackActionCode {
            get { if (_blackActionCode == null) { _blackActionCode = new LdConditionValue(); } return _blackActionCode; }
        }
        protected override LdConditionValue getCValueBlackActionCode() { return this.BlackActionCode; }


        protected Map<String, LdBlackActionCQ> _blackActionCode_ExistsSubQuery_BlackActionListMap;
        public Map<String, LdBlackActionCQ> BlackActionCode_ExistsSubQuery_BlackActionList { get { return _blackActionCode_ExistsSubQuery_BlackActionListMap; }}
        public override String keepBlackActionCode_ExistsSubQuery_BlackActionList(LdBlackActionCQ subQuery) {
            if (_blackActionCode_ExistsSubQuery_BlackActionListMap == null) { _blackActionCode_ExistsSubQuery_BlackActionListMap = new LinkedHashMap<String, LdBlackActionCQ>(); }
            String key = "subQueryMapKey" + (_blackActionCode_ExistsSubQuery_BlackActionListMap.size() + 1);
            _blackActionCode_ExistsSubQuery_BlackActionListMap.put(key, subQuery); return "BlackActionCode_ExistsSubQuery_BlackActionList." + key;
        }

        protected Map<String, LdBlackActionCQ> _blackActionCode_NotExistsSubQuery_BlackActionListMap;
        public Map<String, LdBlackActionCQ> BlackActionCode_NotExistsSubQuery_BlackActionList { get { return _blackActionCode_NotExistsSubQuery_BlackActionListMap; }}
        public override String keepBlackActionCode_NotExistsSubQuery_BlackActionList(LdBlackActionCQ subQuery) {
            if (_blackActionCode_NotExistsSubQuery_BlackActionListMap == null) { _blackActionCode_NotExistsSubQuery_BlackActionListMap = new LinkedHashMap<String, LdBlackActionCQ>(); }
            String key = "subQueryMapKey" + (_blackActionCode_NotExistsSubQuery_BlackActionListMap.size() + 1);
            _blackActionCode_NotExistsSubQuery_BlackActionListMap.put(key, subQuery); return "BlackActionCode_NotExistsSubQuery_BlackActionList." + key;
        }

        protected Map<String, LdBlackActionCQ> _blackActionCode_InScopeSubQuery_BlackActionListMap;
        public Map<String, LdBlackActionCQ> BlackActionCode_InScopeSubQuery_BlackActionList { get { return _blackActionCode_InScopeSubQuery_BlackActionListMap; }}
        public override String keepBlackActionCode_InScopeSubQuery_BlackActionList(LdBlackActionCQ subQuery) {
            if (_blackActionCode_InScopeSubQuery_BlackActionListMap == null) { _blackActionCode_InScopeSubQuery_BlackActionListMap = new LinkedHashMap<String, LdBlackActionCQ>(); }
            String key = "subQueryMapKey" + (_blackActionCode_InScopeSubQuery_BlackActionListMap.size() + 1);
            _blackActionCode_InScopeSubQuery_BlackActionListMap.put(key, subQuery); return "BlackActionCode_InScopeSubQuery_BlackActionList." + key;
        }

        protected Map<String, LdBlackActionCQ> _blackActionCode_NotInScopeSubQuery_BlackActionListMap;
        public Map<String, LdBlackActionCQ> BlackActionCode_NotInScopeSubQuery_BlackActionList { get { return _blackActionCode_NotInScopeSubQuery_BlackActionListMap; }}
        public override String keepBlackActionCode_NotInScopeSubQuery_BlackActionList(LdBlackActionCQ subQuery) {
            if (_blackActionCode_NotInScopeSubQuery_BlackActionListMap == null) { _blackActionCode_NotInScopeSubQuery_BlackActionListMap = new LinkedHashMap<String, LdBlackActionCQ>(); }
            String key = "subQueryMapKey" + (_blackActionCode_NotInScopeSubQuery_BlackActionListMap.size() + 1);
            _blackActionCode_NotInScopeSubQuery_BlackActionListMap.put(key, subQuery); return "BlackActionCode_NotInScopeSubQuery_BlackActionList." + key;
        }

        protected Map<String, LdBlackActionCQ> _blackActionCode_SpecifyDerivedReferrer_BlackActionListMap;
        public Map<String, LdBlackActionCQ> BlackActionCode_SpecifyDerivedReferrer_BlackActionList { get { return _blackActionCode_SpecifyDerivedReferrer_BlackActionListMap; }}
        public override String keepBlackActionCode_SpecifyDerivedReferrer_BlackActionList(LdBlackActionCQ subQuery) {
            if (_blackActionCode_SpecifyDerivedReferrer_BlackActionListMap == null) { _blackActionCode_SpecifyDerivedReferrer_BlackActionListMap = new LinkedHashMap<String, LdBlackActionCQ>(); }
            String key = "subQueryMapKey" + (_blackActionCode_SpecifyDerivedReferrer_BlackActionListMap.size() + 1);
           _blackActionCode_SpecifyDerivedReferrer_BlackActionListMap.put(key, subQuery); return "BlackActionCode_SpecifyDerivedReferrer_BlackActionList." + key;
        }

        protected Map<String, LdBlackActionCQ> _blackActionCode_QueryDerivedReferrer_BlackActionListMap;
        public Map<String, LdBlackActionCQ> BlackActionCode_QueryDerivedReferrer_BlackActionList { get { return _blackActionCode_QueryDerivedReferrer_BlackActionListMap; } }
        public override String keepBlackActionCode_QueryDerivedReferrer_BlackActionList(LdBlackActionCQ subQuery) {
            if (_blackActionCode_QueryDerivedReferrer_BlackActionListMap == null) { _blackActionCode_QueryDerivedReferrer_BlackActionListMap = new LinkedHashMap<String, LdBlackActionCQ>(); }
            String key = "subQueryMapKey" + (_blackActionCode_QueryDerivedReferrer_BlackActionListMap.size() + 1);
            _blackActionCode_QueryDerivedReferrer_BlackActionListMap.put(key, subQuery); return "BlackActionCode_QueryDerivedReferrer_BlackActionList." + key;
        }
        protected Map<String, Object> _blackActionCode_QueryDerivedReferrer_BlackActionListParameterMap;
        public Map<String, Object> BlackActionCode_QueryDerivedReferrer_BlackActionListParameter { get { return _blackActionCode_QueryDerivedReferrer_BlackActionListParameterMap; } }
        public override String keepBlackActionCode_QueryDerivedReferrer_BlackActionListParameter(Object parameterValue) {
            if (_blackActionCode_QueryDerivedReferrer_BlackActionListParameterMap == null) { _blackActionCode_QueryDerivedReferrer_BlackActionListParameterMap = new LinkedHashMap<String, Object>(); }
            String key = "subQueryParameterKey" + (_blackActionCode_QueryDerivedReferrer_BlackActionListParameterMap.size() + 1);
            _blackActionCode_QueryDerivedReferrer_BlackActionListParameterMap.put(key, parameterValue); return "BlackActionCode_QueryDerivedReferrer_BlackActionListParameter." + key;
        }

        public LdBsBlackActionLookupCQ AddOrderBy_BlackActionCode_Asc() { regOBA("BLACK_ACTION_CODE");return this; }
        public LdBsBlackActionLookupCQ AddOrderBy_BlackActionCode_Desc() { regOBD("BLACK_ACTION_CODE");return this; }

        protected LdConditionValue _blackActionName;
        public LdConditionValue BlackActionName {
            get { if (_blackActionName == null) { _blackActionName = new LdConditionValue(); } return _blackActionName; }
        }
        protected override LdConditionValue getCValueBlackActionName() { return this.BlackActionName; }


        public LdBsBlackActionLookupCQ AddOrderBy_BlackActionName_Asc() { regOBA("BLACK_ACTION_NAME");return this; }
        public LdBsBlackActionLookupCQ AddOrderBy_BlackActionName_Desc() { regOBD("BLACK_ACTION_NAME");return this; }

        protected LdConditionValue _rUser;
        public LdConditionValue RUser {
            get { if (_rUser == null) { _rUser = new LdConditionValue(); } return _rUser; }
        }
        protected override LdConditionValue getCValueRUser() { return this.RUser; }


        public LdBsBlackActionLookupCQ AddOrderBy_RUser_Asc() { regOBA("R_USER");return this; }
        public LdBsBlackActionLookupCQ AddOrderBy_RUser_Desc() { regOBD("R_USER");return this; }

        protected LdConditionValue _rModule;
        public LdConditionValue RModule {
            get { if (_rModule == null) { _rModule = new LdConditionValue(); } return _rModule; }
        }
        protected override LdConditionValue getCValueRModule() { return this.RModule; }


        public LdBsBlackActionLookupCQ AddOrderBy_RModule_Asc() { regOBA("R_MODULE");return this; }
        public LdBsBlackActionLookupCQ AddOrderBy_RModule_Desc() { regOBD("R_MODULE");return this; }

        protected LdConditionValue _rTimestamp;
        public LdConditionValue RTimestamp {
            get { if (_rTimestamp == null) { _rTimestamp = new LdConditionValue(); } return _rTimestamp; }
        }
        protected override LdConditionValue getCValueRTimestamp() { return this.RTimestamp; }


        public LdBsBlackActionLookupCQ AddOrderBy_RTimestamp_Asc() { regOBA("R_TIMESTAMP");return this; }
        public LdBsBlackActionLookupCQ AddOrderBy_RTimestamp_Desc() { regOBD("R_TIMESTAMP");return this; }

        protected LdConditionValue _uUser;
        public LdConditionValue UUser {
            get { if (_uUser == null) { _uUser = new LdConditionValue(); } return _uUser; }
        }
        protected override LdConditionValue getCValueUUser() { return this.UUser; }


        public LdBsBlackActionLookupCQ AddOrderBy_UUser_Asc() { regOBA("U_USER");return this; }
        public LdBsBlackActionLookupCQ AddOrderBy_UUser_Desc() { regOBD("U_USER");return this; }

        protected LdConditionValue _uModule;
        public LdConditionValue UModule {
            get { if (_uModule == null) { _uModule = new LdConditionValue(); } return _uModule; }
        }
        protected override LdConditionValue getCValueUModule() { return this.UModule; }


        public LdBsBlackActionLookupCQ AddOrderBy_UModule_Asc() { regOBA("U_MODULE");return this; }
        public LdBsBlackActionLookupCQ AddOrderBy_UModule_Desc() { regOBD("U_MODULE");return this; }

        protected LdConditionValue _uTimestamp;
        public LdConditionValue UTimestamp {
            get { if (_uTimestamp == null) { _uTimestamp = new LdConditionValue(); } return _uTimestamp; }
        }
        protected override LdConditionValue getCValueUTimestamp() { return this.UTimestamp; }


        public LdBsBlackActionLookupCQ AddOrderBy_UTimestamp_Asc() { regOBA("U_TIMESTAMP");return this; }
        public LdBsBlackActionLookupCQ AddOrderBy_UTimestamp_Desc() { regOBD("U_TIMESTAMP");return this; }

        public LdBsBlackActionLookupCQ AddSpecifiedDerivedOrderBy_Asc(String aliasName) { registerSpecifiedDerivedOrderBy_Asc(aliasName); return this; }
        public LdBsBlackActionLookupCQ AddSpecifiedDerivedOrderBy_Desc(String aliasName) { registerSpecifiedDerivedOrderBy_Desc(aliasName); return this; }

        public override void reflectRelationOnUnionQuery(LdConditionQuery baseQueryAsSuper, LdConditionQuery unionQueryAsSuper) {

        }
    


	    // ===============================================================================
	    //                                                                 Scalar SubQuery
	    //                                                                 ===============
	    protected Map<String, LdBlackActionLookupCQ> _scalarSubQueryMap;
	    public Map<String, LdBlackActionLookupCQ> ScalarSubQuery { get { return _scalarSubQueryMap; } }
	    public override String keepScalarSubQuery(LdBlackActionLookupCQ subQuery) {
	        if (_scalarSubQueryMap == null) { _scalarSubQueryMap = new LinkedHashMap<String, LdBlackActionLookupCQ>(); }
	        String key = "subQueryMapKey" + (_scalarSubQueryMap.size() + 1);
	        _scalarSubQueryMap.put(key, subQuery); return "ScalarSubQuery." + key;
	    }

        // ===============================================================================
        //                                                         Myself InScope SubQuery
        //                                                         =======================
        protected Map<String, LdBlackActionLookupCQ> _myselfInScopeSubQueryMap;
        public Map<String, LdBlackActionLookupCQ> MyselfInScopeSubQuery { get { return _myselfInScopeSubQueryMap; } }
        public override String keepMyselfInScopeSubQuery(LdBlackActionLookupCQ subQuery) {
            if (_myselfInScopeSubQueryMap == null) { _myselfInScopeSubQueryMap = new LinkedHashMap<String, LdBlackActionLookupCQ>(); }
            String key = "subQueryMapKey" + (_myselfInScopeSubQueryMap.size() + 1);
            _myselfInScopeSubQueryMap.put(key, subQuery); return "MyselfInScopeSubQuery." + key;
        }
    }
}
