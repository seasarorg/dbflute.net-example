
using System;

using DfExample.DBFlute.AllCommon.CBean;
using DfExample.DBFlute.AllCommon.CBean.CValue;
using DfExample.DBFlute.AllCommon.CBean.SClause;
using DfExample.DBFlute.AllCommon.JavaLike;
using DfExample.DBFlute.CBean.CQ;
using DfExample.DBFlute.CBean.CQ.Ciq;

namespace DfExample.DBFlute.CBean.CQ.BS {

    [System.Serializable]
    public class BsWhiteMyselfCQ : AbstractBsWhiteMyselfCQ {

        protected WhiteMyselfCIQ _inlineQuery;

        public BsWhiteMyselfCQ(ConditionQuery childQuery, SqlClause sqlClause, String aliasName, int nestLevel)
            : base(childQuery, sqlClause, aliasName, nestLevel) {}

        public WhiteMyselfCIQ Inline() {
            if (_inlineQuery == null) {
                _inlineQuery = new WhiteMyselfCIQ(xgetReferrerQuery(), xgetSqlClause(), xgetAliasName(), xgetNestLevel(), this);
            }
            _inlineQuery.xsetOnClause(false);
            return _inlineQuery;
        }
        
        public WhiteMyselfCIQ On() {
            if (isBaseQuery()) { throw new UnsupportedOperationException("Unsupported onClause of Base Table!"); }
            WhiteMyselfCIQ inlineQuery = Inline();
            inlineQuery.xsetOnClause(true);
            return inlineQuery;
        }


        protected ConditionValue _myselfId;
        public ConditionValue MyselfId {
            get { if (_myselfId == null) { _myselfId = new ConditionValue(); } return _myselfId; }
        }
        protected override ConditionValue getCValueMyselfId() { return this.MyselfId; }


        protected Map<String, WhiteMyselfCheckCQ> _myselfId_ExistsSubQuery_WhiteMyselfCheckListMap;
        public Map<String, WhiteMyselfCheckCQ> MyselfId_ExistsSubQuery_WhiteMyselfCheckList { get { return _myselfId_ExistsSubQuery_WhiteMyselfCheckListMap; }}
        public override String keepMyselfId_ExistsSubQuery_WhiteMyselfCheckList(WhiteMyselfCheckCQ subQuery) {
            if (_myselfId_ExistsSubQuery_WhiteMyselfCheckListMap == null) { _myselfId_ExistsSubQuery_WhiteMyselfCheckListMap = new LinkedHashMap<String, WhiteMyselfCheckCQ>(); }
            String key = "subQueryMapKey" + (_myselfId_ExistsSubQuery_WhiteMyselfCheckListMap.size() + 1);
            _myselfId_ExistsSubQuery_WhiteMyselfCheckListMap.put(key, subQuery); return "MyselfId_ExistsSubQuery_WhiteMyselfCheckList." + key;
        }

        protected Map<String, WhiteMyselfCheckCQ> _myselfId_NotExistsSubQuery_WhiteMyselfCheckListMap;
        public Map<String, WhiteMyselfCheckCQ> MyselfId_NotExistsSubQuery_WhiteMyselfCheckList { get { return _myselfId_NotExistsSubQuery_WhiteMyselfCheckListMap; }}
        public override String keepMyselfId_NotExistsSubQuery_WhiteMyselfCheckList(WhiteMyselfCheckCQ subQuery) {
            if (_myselfId_NotExistsSubQuery_WhiteMyselfCheckListMap == null) { _myselfId_NotExistsSubQuery_WhiteMyselfCheckListMap = new LinkedHashMap<String, WhiteMyselfCheckCQ>(); }
            String key = "subQueryMapKey" + (_myselfId_NotExistsSubQuery_WhiteMyselfCheckListMap.size() + 1);
            _myselfId_NotExistsSubQuery_WhiteMyselfCheckListMap.put(key, subQuery); return "MyselfId_NotExistsSubQuery_WhiteMyselfCheckList." + key;
        }

        protected Map<String, WhiteMyselfCheckCQ> _myselfId_InScopeSubQuery_WhiteMyselfCheckListMap;
        public Map<String, WhiteMyselfCheckCQ> MyselfId_InScopeSubQuery_WhiteMyselfCheckList { get { return _myselfId_InScopeSubQuery_WhiteMyselfCheckListMap; }}
        public override String keepMyselfId_InScopeSubQuery_WhiteMyselfCheckList(WhiteMyselfCheckCQ subQuery) {
            if (_myselfId_InScopeSubQuery_WhiteMyselfCheckListMap == null) { _myselfId_InScopeSubQuery_WhiteMyselfCheckListMap = new LinkedHashMap<String, WhiteMyselfCheckCQ>(); }
            String key = "subQueryMapKey" + (_myselfId_InScopeSubQuery_WhiteMyselfCheckListMap.size() + 1);
            _myselfId_InScopeSubQuery_WhiteMyselfCheckListMap.put(key, subQuery); return "MyselfId_InScopeSubQuery_WhiteMyselfCheckList." + key;
        }

        protected Map<String, WhiteMyselfCheckCQ> _myselfId_NotInScopeSubQuery_WhiteMyselfCheckListMap;
        public Map<String, WhiteMyselfCheckCQ> MyselfId_NotInScopeSubQuery_WhiteMyselfCheckList { get { return _myselfId_NotInScopeSubQuery_WhiteMyselfCheckListMap; }}
        public override String keepMyselfId_NotInScopeSubQuery_WhiteMyselfCheckList(WhiteMyselfCheckCQ subQuery) {
            if (_myselfId_NotInScopeSubQuery_WhiteMyselfCheckListMap == null) { _myselfId_NotInScopeSubQuery_WhiteMyselfCheckListMap = new LinkedHashMap<String, WhiteMyselfCheckCQ>(); }
            String key = "subQueryMapKey" + (_myselfId_NotInScopeSubQuery_WhiteMyselfCheckListMap.size() + 1);
            _myselfId_NotInScopeSubQuery_WhiteMyselfCheckListMap.put(key, subQuery); return "MyselfId_NotInScopeSubQuery_WhiteMyselfCheckList." + key;
        }

        protected Map<String, WhiteMyselfCheckCQ> _myselfId_SpecifyDerivedReferrer_WhiteMyselfCheckListMap;
        public Map<String, WhiteMyselfCheckCQ> MyselfId_SpecifyDerivedReferrer_WhiteMyselfCheckList { get { return _myselfId_SpecifyDerivedReferrer_WhiteMyselfCheckListMap; }}
        public override String keepMyselfId_SpecifyDerivedReferrer_WhiteMyselfCheckList(WhiteMyselfCheckCQ subQuery) {
            if (_myselfId_SpecifyDerivedReferrer_WhiteMyselfCheckListMap == null) { _myselfId_SpecifyDerivedReferrer_WhiteMyselfCheckListMap = new LinkedHashMap<String, WhiteMyselfCheckCQ>(); }
            String key = "subQueryMapKey" + (_myselfId_SpecifyDerivedReferrer_WhiteMyselfCheckListMap.size() + 1);
            _myselfId_SpecifyDerivedReferrer_WhiteMyselfCheckListMap.put(key, subQuery); return "MyselfId_SpecifyDerivedReferrer_WhiteMyselfCheckList." + key;
        }

        protected Map<String, WhiteMyselfCheckCQ> _myselfId_QueryDerivedReferrer_WhiteMyselfCheckListMap;
        public Map<String, WhiteMyselfCheckCQ> MyselfId_QueryDerivedReferrer_WhiteMyselfCheckList { get { return _myselfId_QueryDerivedReferrer_WhiteMyselfCheckListMap; } }
        public override String keepMyselfId_QueryDerivedReferrer_WhiteMyselfCheckList(WhiteMyselfCheckCQ subQuery) {
            if (_myselfId_QueryDerivedReferrer_WhiteMyselfCheckListMap == null) { _myselfId_QueryDerivedReferrer_WhiteMyselfCheckListMap = new LinkedHashMap<String, WhiteMyselfCheckCQ>(); }
            String key = "subQueryMapKey" + (_myselfId_QueryDerivedReferrer_WhiteMyselfCheckListMap.size() + 1);
            _myselfId_QueryDerivedReferrer_WhiteMyselfCheckListMap.put(key, subQuery); return "MyselfId_QueryDerivedReferrer_WhiteMyselfCheckList." + key;
        }
        protected Map<String, Object> _myselfId_QueryDerivedReferrer_WhiteMyselfCheckListParameterMap;
        public Map<String, Object> MyselfId_QueryDerivedReferrer_WhiteMyselfCheckListParameter { get { return _myselfId_QueryDerivedReferrer_WhiteMyselfCheckListParameterMap; } }
        public override String keepMyselfId_QueryDerivedReferrer_WhiteMyselfCheckListParameter(Object parameterValue) {
            if (_myselfId_QueryDerivedReferrer_WhiteMyselfCheckListParameterMap == null) { _myselfId_QueryDerivedReferrer_WhiteMyselfCheckListParameterMap = new LinkedHashMap<String, Object>(); }
            String key = "subQueryParameterKey" + (_myselfId_QueryDerivedReferrer_WhiteMyselfCheckListParameterMap.size() + 1);
            _myselfId_QueryDerivedReferrer_WhiteMyselfCheckListParameterMap.put(key, parameterValue); return "MyselfId_QueryDerivedReferrer_WhiteMyselfCheckListParameter." + key;
        }

        public BsWhiteMyselfCQ AddOrderBy_MyselfId_Asc() { regOBA("MYSELF_ID");return this; }
        public BsWhiteMyselfCQ AddOrderBy_MyselfId_Desc() { regOBD("MYSELF_ID");return this; }

        protected ConditionValue _myselfName;
        public ConditionValue MyselfName {
            get { if (_myselfName == null) { _myselfName = new ConditionValue(); } return _myselfName; }
        }
        protected override ConditionValue getCValueMyselfName() { return this.MyselfName; }


        public BsWhiteMyselfCQ AddOrderBy_MyselfName_Asc() { regOBA("MYSELF_NAME");return this; }
        public BsWhiteMyselfCQ AddOrderBy_MyselfName_Desc() { regOBD("MYSELF_NAME");return this; }

        public BsWhiteMyselfCQ AddSpecifiedDerivedOrderBy_Asc(String aliasName) { registerSpecifiedDerivedOrderBy_Asc(aliasName); return this; }
        public BsWhiteMyselfCQ AddSpecifiedDerivedOrderBy_Desc(String aliasName) { registerSpecifiedDerivedOrderBy_Desc(aliasName); return this; }

        public override void reflectRelationOnUnionQuery(ConditionQuery baseQueryAsSuper, ConditionQuery unionQueryAsSuper) {

        }
    


	    // ===============================================================================
	    //                                                                 Scalar SubQuery
	    //                                                                 ===============
	    protected Map<String, WhiteMyselfCQ> _scalarSubQueryMap;
	    public Map<String, WhiteMyselfCQ> ScalarSubQuery { get { return _scalarSubQueryMap; } }
	    public override String keepScalarSubQuery(WhiteMyselfCQ subQuery) {
	        if (_scalarSubQueryMap == null) { _scalarSubQueryMap = new LinkedHashMap<String, WhiteMyselfCQ>(); }
	        String key = "subQueryMapKey" + (_scalarSubQueryMap.size() + 1);
	        _scalarSubQueryMap.put(key, subQuery); return "ScalarSubQuery." + key;
	    }

        // ===============================================================================
        //                                                         Myself InScope SubQuery
        //                                                         =======================
        protected Map<String, WhiteMyselfCQ> _myselfInScopeSubQueryMap;
        public Map<String, WhiteMyselfCQ> MyselfInScopeSubQuery { get { return _myselfInScopeSubQueryMap; } }
        public override String keepMyselfInScopeSubQuery(WhiteMyselfCQ subQuery) {
            if (_myselfInScopeSubQueryMap == null) { _myselfInScopeSubQueryMap = new LinkedHashMap<String, WhiteMyselfCQ>(); }
            String key = "subQueryMapKey" + (_myselfInScopeSubQueryMap.size() + 1);
            _myselfInScopeSubQueryMap.put(key, subQuery); return "MyselfInScopeSubQuery." + key;
        }
    }
}
