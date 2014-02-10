
using System;

using DfExample.DBFlute.AllCommon.CBean;
using DfExample.DBFlute.AllCommon.CBean.CValue;
using DfExample.DBFlute.AllCommon.CBean.SClause;
using DfExample.DBFlute.AllCommon.JavaLike;
using DfExample.DBFlute.CBean.CQ;
using DfExample.DBFlute.CBean.CQ.Ciq;

namespace DfExample.DBFlute.CBean.CQ.BS {

    [System.Serializable]
    public class BsMyselfCQ : AbstractBsMyselfCQ {

        protected MyselfCIQ _inlineQuery;

        public BsMyselfCQ(ConditionQuery childQuery, SqlClause sqlClause, String aliasName, int nestLevel)
            : base(childQuery, sqlClause, aliasName, nestLevel) {}

        public MyselfCIQ Inline() {
            if (_inlineQuery == null) {
                _inlineQuery = new MyselfCIQ(xgetReferrerQuery(), xgetSqlClause(), xgetAliasName(), xgetNestLevel(), this);
            }
            _inlineQuery.xsetOnClause(false);
            return _inlineQuery;
        }
        
        public MyselfCIQ On() {
            if (isBaseQuery()) { throw new UnsupportedOperationException("Unsupported onClause of Base Table!"); }
            MyselfCIQ inlineQuery = Inline();
            inlineQuery.xsetOnClause(true);
            return inlineQuery;
        }


        protected ConditionValue _myselfId;
        public ConditionValue MyselfId {
            get { if (_myselfId == null) { _myselfId = new ConditionValue(); } return _myselfId; }
        }
        protected override ConditionValue getCValueMyselfId() { return this.MyselfId; }


        protected Map<String, MyselfCheckCQ> _myselfId_ExistsSubQuery_MyselfCheckListMap;
        public Map<String, MyselfCheckCQ> MyselfId_ExistsSubQuery_MyselfCheckList { get { return _myselfId_ExistsSubQuery_MyselfCheckListMap; }}
        public override String keepMyselfId_ExistsSubQuery_MyselfCheckList(MyselfCheckCQ subQuery) {
            if (_myselfId_ExistsSubQuery_MyselfCheckListMap == null) { _myselfId_ExistsSubQuery_MyselfCheckListMap = new LinkedHashMap<String, MyselfCheckCQ>(); }
            String key = "subQueryMapKey" + (_myselfId_ExistsSubQuery_MyselfCheckListMap.size() + 1);
            _myselfId_ExistsSubQuery_MyselfCheckListMap.put(key, subQuery); return "MyselfId_ExistsSubQuery_MyselfCheckList." + key;
        }

        protected Map<String, MyselfCheckCQ> _myselfId_NotExistsSubQuery_MyselfCheckListMap;
        public Map<String, MyselfCheckCQ> MyselfId_NotExistsSubQuery_MyselfCheckList { get { return _myselfId_NotExistsSubQuery_MyselfCheckListMap; }}
        public override String keepMyselfId_NotExistsSubQuery_MyselfCheckList(MyselfCheckCQ subQuery) {
            if (_myselfId_NotExistsSubQuery_MyselfCheckListMap == null) { _myselfId_NotExistsSubQuery_MyselfCheckListMap = new LinkedHashMap<String, MyselfCheckCQ>(); }
            String key = "subQueryMapKey" + (_myselfId_NotExistsSubQuery_MyselfCheckListMap.size() + 1);
            _myselfId_NotExistsSubQuery_MyselfCheckListMap.put(key, subQuery); return "MyselfId_NotExistsSubQuery_MyselfCheckList." + key;
        }

        protected Map<String, MyselfCheckCQ> _myselfId_InScopeSubQuery_MyselfCheckListMap;
        public Map<String, MyselfCheckCQ> MyselfId_InScopeSubQuery_MyselfCheckList { get { return _myselfId_InScopeSubQuery_MyselfCheckListMap; }}
        public override String keepMyselfId_InScopeSubQuery_MyselfCheckList(MyselfCheckCQ subQuery) {
            if (_myselfId_InScopeSubQuery_MyselfCheckListMap == null) { _myselfId_InScopeSubQuery_MyselfCheckListMap = new LinkedHashMap<String, MyselfCheckCQ>(); }
            String key = "subQueryMapKey" + (_myselfId_InScopeSubQuery_MyselfCheckListMap.size() + 1);
            _myselfId_InScopeSubQuery_MyselfCheckListMap.put(key, subQuery); return "MyselfId_InScopeSubQuery_MyselfCheckList." + key;
        }

        protected Map<String, MyselfCheckCQ> _myselfId_NotInScopeSubQuery_MyselfCheckListMap;
        public Map<String, MyselfCheckCQ> MyselfId_NotInScopeSubQuery_MyselfCheckList { get { return _myselfId_NotInScopeSubQuery_MyselfCheckListMap; }}
        public override String keepMyselfId_NotInScopeSubQuery_MyselfCheckList(MyselfCheckCQ subQuery) {
            if (_myselfId_NotInScopeSubQuery_MyselfCheckListMap == null) { _myselfId_NotInScopeSubQuery_MyselfCheckListMap = new LinkedHashMap<String, MyselfCheckCQ>(); }
            String key = "subQueryMapKey" + (_myselfId_NotInScopeSubQuery_MyselfCheckListMap.size() + 1);
            _myselfId_NotInScopeSubQuery_MyselfCheckListMap.put(key, subQuery); return "MyselfId_NotInScopeSubQuery_MyselfCheckList." + key;
        }

        protected Map<String, MyselfCheckCQ> _myselfId_SpecifyDerivedReferrer_MyselfCheckListMap;
        public Map<String, MyselfCheckCQ> MyselfId_SpecifyDerivedReferrer_MyselfCheckList { get { return _myselfId_SpecifyDerivedReferrer_MyselfCheckListMap; }}
        public override String keepMyselfId_SpecifyDerivedReferrer_MyselfCheckList(MyselfCheckCQ subQuery) {
            if (_myselfId_SpecifyDerivedReferrer_MyselfCheckListMap == null) { _myselfId_SpecifyDerivedReferrer_MyselfCheckListMap = new LinkedHashMap<String, MyselfCheckCQ>(); }
            String key = "subQueryMapKey" + (_myselfId_SpecifyDerivedReferrer_MyselfCheckListMap.size() + 1);
            _myselfId_SpecifyDerivedReferrer_MyselfCheckListMap.put(key, subQuery); return "MyselfId_SpecifyDerivedReferrer_MyselfCheckList." + key;
        }

        protected Map<String, MyselfCheckCQ> _myselfId_QueryDerivedReferrer_MyselfCheckListMap;
        public Map<String, MyselfCheckCQ> MyselfId_QueryDerivedReferrer_MyselfCheckList { get { return _myselfId_QueryDerivedReferrer_MyselfCheckListMap; } }
        public override String keepMyselfId_QueryDerivedReferrer_MyselfCheckList(MyselfCheckCQ subQuery) {
            if (_myselfId_QueryDerivedReferrer_MyselfCheckListMap == null) { _myselfId_QueryDerivedReferrer_MyselfCheckListMap = new LinkedHashMap<String, MyselfCheckCQ>(); }
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

        public BsMyselfCQ AddOrderBy_MyselfId_Asc() { regOBA("MYSELF_ID");return this; }
        public BsMyselfCQ AddOrderBy_MyselfId_Desc() { regOBD("MYSELF_ID");return this; }

        protected ConditionValue _myselfName;
        public ConditionValue MyselfName {
            get { if (_myselfName == null) { _myselfName = new ConditionValue(); } return _myselfName; }
        }
        protected override ConditionValue getCValueMyselfName() { return this.MyselfName; }


        public BsMyselfCQ AddOrderBy_MyselfName_Asc() { regOBA("MYSELF_NAME");return this; }
        public BsMyselfCQ AddOrderBy_MyselfName_Desc() { regOBD("MYSELF_NAME");return this; }

        public BsMyselfCQ AddSpecifiedDerivedOrderBy_Asc(String aliasName) { registerSpecifiedDerivedOrderBy_Asc(aliasName); return this; }
        public BsMyselfCQ AddSpecifiedDerivedOrderBy_Desc(String aliasName) { registerSpecifiedDerivedOrderBy_Desc(aliasName); return this; }

        public override void reflectRelationOnUnionQuery(ConditionQuery baseQueryAsSuper, ConditionQuery unionQueryAsSuper) {

        }
    


	    // ===============================================================================
	    //                                                                 Scalar SubQuery
	    //                                                                 ===============
	    protected Map<String, MyselfCQ> _scalarSubQueryMap;
	    public Map<String, MyselfCQ> ScalarSubQuery { get { return _scalarSubQueryMap; } }
	    public override String keepScalarSubQuery(MyselfCQ subQuery) {
	        if (_scalarSubQueryMap == null) { _scalarSubQueryMap = new LinkedHashMap<String, MyselfCQ>(); }
	        String key = "subQueryMapKey" + (_scalarSubQueryMap.size() + 1);
	        _scalarSubQueryMap.put(key, subQuery); return "ScalarSubQuery." + key;
	    }

        // ===============================================================================
        //                                                         Myself InScope SubQuery
        //                                                         =======================
        protected Map<String, MyselfCQ> _myselfInScopeSubQueryMap;
        public Map<String, MyselfCQ> MyselfInScopeSubQuery { get { return _myselfInScopeSubQueryMap; } }
        public override String keepMyselfInScopeSubQuery(MyselfCQ subQuery) {
            if (_myselfInScopeSubQueryMap == null) { _myselfInScopeSubQueryMap = new LinkedHashMap<String, MyselfCQ>(); }
            String key = "subQueryMapKey" + (_myselfInScopeSubQueryMap.size() + 1);
            _myselfInScopeSubQueryMap.put(key, subQuery); return "MyselfInScopeSubQuery." + key;
        }
    }
}
