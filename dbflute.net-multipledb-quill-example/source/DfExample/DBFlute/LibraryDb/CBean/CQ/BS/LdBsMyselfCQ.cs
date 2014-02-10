
using System;

using DfExample.DBFlute.LibraryDb.AllCommon.CBean;
using DfExample.DBFlute.LibraryDb.AllCommon.CBean.CValue;
using DfExample.DBFlute.LibraryDb.AllCommon.CBean.SClause;
using DfExample.DBFlute.LibraryDb.AllCommon.JavaLike;
using DfExample.DBFlute.LibraryDb.CBean.CQ;
using DfExample.DBFlute.LibraryDb.CBean.CQ.Ciq;

namespace DfExample.DBFlute.LibraryDb.CBean.CQ.BS {

    [System.Serializable]
    public class LdBsMyselfCQ : LdAbstractBsMyselfCQ {

        protected LdMyselfCIQ _inlineQuery;

        public LdBsMyselfCQ(LdConditionQuery childQuery, LdSqlClause sqlClause, String aliasName, int nestLevel)
            : base(childQuery, sqlClause, aliasName, nestLevel) {}

        public LdMyselfCIQ Inline() {
            if (_inlineQuery == null) {
                _inlineQuery = new LdMyselfCIQ(xgetReferrerQuery(), xgetSqlClause(), xgetAliasName(), xgetNestLevel(), this);
            }
            _inlineQuery.xsetOnClause(false);
            return _inlineQuery;
        }
        
        public LdMyselfCIQ On() {
            if (isBaseQuery()) { throw new UnsupportedOperationException("Unsupported onClause of Base Table!"); }
            LdMyselfCIQ inlineQuery = Inline();
            inlineQuery.xsetOnClause(true);
            return inlineQuery;
        }


        protected LdConditionValue _myselfId;
        public LdConditionValue MyselfId {
            get { if (_myselfId == null) { _myselfId = new LdConditionValue(); } return _myselfId; }
        }
        protected override LdConditionValue getCValueMyselfId() { return this.MyselfId; }


        protected Map<String, LdMyselfCheckCQ> _myselfId_ExistsSubQuery_MyselfCheckListMap;
        public Map<String, LdMyselfCheckCQ> MyselfId_ExistsSubQuery_MyselfCheckList { get { return _myselfId_ExistsSubQuery_MyselfCheckListMap; }}
        public override String keepMyselfId_ExistsSubQuery_MyselfCheckList(LdMyselfCheckCQ subQuery) {
            if (_myselfId_ExistsSubQuery_MyselfCheckListMap == null) { _myselfId_ExistsSubQuery_MyselfCheckListMap = new LinkedHashMap<String, LdMyselfCheckCQ>(); }
            String key = "subQueryMapKey" + (_myselfId_ExistsSubQuery_MyselfCheckListMap.size() + 1);
            _myselfId_ExistsSubQuery_MyselfCheckListMap.put(key, subQuery); return "MyselfId_ExistsSubQuery_MyselfCheckList." + key;
        }

        protected Map<String, LdMyselfCheckCQ> _myselfId_NotExistsSubQuery_MyselfCheckListMap;
        public Map<String, LdMyselfCheckCQ> MyselfId_NotExistsSubQuery_MyselfCheckList { get { return _myselfId_NotExistsSubQuery_MyselfCheckListMap; }}
        public override String keepMyselfId_NotExistsSubQuery_MyselfCheckList(LdMyselfCheckCQ subQuery) {
            if (_myselfId_NotExistsSubQuery_MyselfCheckListMap == null) { _myselfId_NotExistsSubQuery_MyselfCheckListMap = new LinkedHashMap<String, LdMyselfCheckCQ>(); }
            String key = "subQueryMapKey" + (_myselfId_NotExistsSubQuery_MyselfCheckListMap.size() + 1);
            _myselfId_NotExistsSubQuery_MyselfCheckListMap.put(key, subQuery); return "MyselfId_NotExistsSubQuery_MyselfCheckList." + key;
        }

        protected Map<String, LdMyselfCheckCQ> _myselfId_InScopeSubQuery_MyselfCheckListMap;
        public Map<String, LdMyselfCheckCQ> MyselfId_InScopeSubQuery_MyselfCheckList { get { return _myselfId_InScopeSubQuery_MyselfCheckListMap; }}
        public override String keepMyselfId_InScopeSubQuery_MyselfCheckList(LdMyselfCheckCQ subQuery) {
            if (_myselfId_InScopeSubQuery_MyselfCheckListMap == null) { _myselfId_InScopeSubQuery_MyselfCheckListMap = new LinkedHashMap<String, LdMyselfCheckCQ>(); }
            String key = "subQueryMapKey" + (_myselfId_InScopeSubQuery_MyselfCheckListMap.size() + 1);
            _myselfId_InScopeSubQuery_MyselfCheckListMap.put(key, subQuery); return "MyselfId_InScopeSubQuery_MyselfCheckList." + key;
        }

        protected Map<String, LdMyselfCheckCQ> _myselfId_NotInScopeSubQuery_MyselfCheckListMap;
        public Map<String, LdMyselfCheckCQ> MyselfId_NotInScopeSubQuery_MyselfCheckList { get { return _myselfId_NotInScopeSubQuery_MyselfCheckListMap; }}
        public override String keepMyselfId_NotInScopeSubQuery_MyselfCheckList(LdMyselfCheckCQ subQuery) {
            if (_myselfId_NotInScopeSubQuery_MyselfCheckListMap == null) { _myselfId_NotInScopeSubQuery_MyselfCheckListMap = new LinkedHashMap<String, LdMyselfCheckCQ>(); }
            String key = "subQueryMapKey" + (_myselfId_NotInScopeSubQuery_MyselfCheckListMap.size() + 1);
            _myselfId_NotInScopeSubQuery_MyselfCheckListMap.put(key, subQuery); return "MyselfId_NotInScopeSubQuery_MyselfCheckList." + key;
        }

        protected Map<String, LdMyselfCheckCQ> _myselfId_SpecifyDerivedReferrer_MyselfCheckListMap;
        public Map<String, LdMyselfCheckCQ> MyselfId_SpecifyDerivedReferrer_MyselfCheckList { get { return _myselfId_SpecifyDerivedReferrer_MyselfCheckListMap; }}
        public override String keepMyselfId_SpecifyDerivedReferrer_MyselfCheckList(LdMyselfCheckCQ subQuery) {
            if (_myselfId_SpecifyDerivedReferrer_MyselfCheckListMap == null) { _myselfId_SpecifyDerivedReferrer_MyselfCheckListMap = new LinkedHashMap<String, LdMyselfCheckCQ>(); }
            String key = "subQueryMapKey" + (_myselfId_SpecifyDerivedReferrer_MyselfCheckListMap.size() + 1);
            _myselfId_SpecifyDerivedReferrer_MyselfCheckListMap.put(key, subQuery); return "MyselfId_SpecifyDerivedReferrer_MyselfCheckList." + key;
        }

        protected Map<String, LdMyselfCheckCQ> _myselfId_QueryDerivedReferrer_MyselfCheckListMap;
        public Map<String, LdMyselfCheckCQ> MyselfId_QueryDerivedReferrer_MyselfCheckList { get { return _myselfId_QueryDerivedReferrer_MyselfCheckListMap; } }
        public override String keepMyselfId_QueryDerivedReferrer_MyselfCheckList(LdMyselfCheckCQ subQuery) {
            if (_myselfId_QueryDerivedReferrer_MyselfCheckListMap == null) { _myselfId_QueryDerivedReferrer_MyselfCheckListMap = new LinkedHashMap<String, LdMyselfCheckCQ>(); }
            String key = "subQueryMapKey" + (_myselfId_QueryDerivedReferrer_MyselfCheckListMap.size() + 1);
            _myselfId_QueryDerivedReferrer_MyselfCheckListMap.put(key, subQuery); return "MyselfId_QueryDerivedReferrer_MyselfCheckList." + key;
        }
        protected Map<String, Object> _myselfId_QueryDerivedReferrer_MyselfCheckListParameterMap;
        public Map<String, Object> MyselfId_QueryDerivedReferrer_MyselfCheckListParameter { get { return _myselfId_QueryDerivedReferrer_MyselfCheckListParameterMap; } }
        public override String keepMyselfId_QueryDerivedReferrer_MyselfCheckListParameter(Object parameterValue) {
            if (_myselfId_QueryDerivedReferrer_MyselfCheckListParameterMap == null) { _myselfId_QueryDerivedReferrer_MyselfCheckListParameterMap = new LinkedHashMap<String, Object>(); }
            String key = "subQueryParameterKey" + (_myselfId_QueryDerivedReferrer_MyselfCheckListParameterMap.size() + 1);
            _myselfId_QueryDerivedReferrer_MyselfCheckListParameterMap.put(key, parameterValue); return "MyselfId_QueryDerivedReferrer_MyselfCheckListParameter." + key;
        }

        public LdBsMyselfCQ AddOrderBy_MyselfId_Asc() { regOBA("MYSELF_ID");return this; }
        public LdBsMyselfCQ AddOrderBy_MyselfId_Desc() { regOBD("MYSELF_ID");return this; }

        protected LdConditionValue _myselfName;
        public LdConditionValue MyselfName {
            get { if (_myselfName == null) { _myselfName = new LdConditionValue(); } return _myselfName; }
        }
        protected override LdConditionValue getCValueMyselfName() { return this.MyselfName; }


        public LdBsMyselfCQ AddOrderBy_MyselfName_Asc() { regOBA("MYSELF_NAME");return this; }
        public LdBsMyselfCQ AddOrderBy_MyselfName_Desc() { regOBD("MYSELF_NAME");return this; }

        public LdBsMyselfCQ AddSpecifiedDerivedOrderBy_Asc(String aliasName) { registerSpecifiedDerivedOrderBy_Asc(aliasName); return this; }
        public LdBsMyselfCQ AddSpecifiedDerivedOrderBy_Desc(String aliasName) { registerSpecifiedDerivedOrderBy_Desc(aliasName); return this; }

        public override void reflectRelationOnUnionQuery(LdConditionQuery baseQueryAsSuper, LdConditionQuery unionQueryAsSuper) {

        }
    


	    // ===============================================================================
	    //                                                                 Scalar SubQuery
	    //                                                                 ===============
	    protected Map<String, LdMyselfCQ> _scalarSubQueryMap;
	    public Map<String, LdMyselfCQ> ScalarSubQuery { get { return _scalarSubQueryMap; } }
	    public override String keepScalarSubQuery(LdMyselfCQ subQuery) {
	        if (_scalarSubQueryMap == null) { _scalarSubQueryMap = new LinkedHashMap<String, LdMyselfCQ>(); }
	        String key = "subQueryMapKey" + (_scalarSubQueryMap.size() + 1);
	        _scalarSubQueryMap.put(key, subQuery); return "ScalarSubQuery." + key;
	    }

        // ===============================================================================
        //                                                         Myself InScope SubQuery
        //                                                         =======================
        protected Map<String, LdMyselfCQ> _myselfInScopeSubQueryMap;
        public Map<String, LdMyselfCQ> MyselfInScopeSubQuery { get { return _myselfInScopeSubQueryMap; } }
        public override String keepMyselfInScopeSubQuery(LdMyselfCQ subQuery) {
            if (_myselfInScopeSubQueryMap == null) { _myselfInScopeSubQueryMap = new LinkedHashMap<String, LdMyselfCQ>(); }
            String key = "subQueryMapKey" + (_myselfInScopeSubQueryMap.size() + 1);
            _myselfInScopeSubQueryMap.put(key, subQuery); return "MyselfInScopeSubQuery." + key;
        }
    }
}
