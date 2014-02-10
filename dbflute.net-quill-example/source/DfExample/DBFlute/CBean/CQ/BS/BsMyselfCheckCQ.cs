
using System;

using DfExample.DBFlute.AllCommon.CBean;
using DfExample.DBFlute.AllCommon.CBean.CValue;
using DfExample.DBFlute.AllCommon.CBean.SClause;
using DfExample.DBFlute.AllCommon.JavaLike;
using DfExample.DBFlute.CBean.CQ;
using DfExample.DBFlute.CBean.CQ.Ciq;

namespace DfExample.DBFlute.CBean.CQ.BS {

    [System.Serializable]
    public class BsMyselfCheckCQ : AbstractBsMyselfCheckCQ {

        protected MyselfCheckCIQ _inlineQuery;

        public BsMyselfCheckCQ(ConditionQuery childQuery, SqlClause sqlClause, String aliasName, int nestLevel)
            : base(childQuery, sqlClause, aliasName, nestLevel) {}

        public MyselfCheckCIQ Inline() {
            if (_inlineQuery == null) {
                _inlineQuery = new MyselfCheckCIQ(xgetReferrerQuery(), xgetSqlClause(), xgetAliasName(), xgetNestLevel(), this);
            }
            _inlineQuery.xsetOnClause(false);
            return _inlineQuery;
        }
        
        public MyselfCheckCIQ On() {
            if (isBaseQuery()) { throw new UnsupportedOperationException("Unsupported onClause of Base Table!"); }
            MyselfCheckCIQ inlineQuery = Inline();
            inlineQuery.xsetOnClause(true);
            return inlineQuery;
        }


        protected ConditionValue _myselfCheckId;
        public ConditionValue MyselfCheckId {
            get { if (_myselfCheckId == null) { _myselfCheckId = new ConditionValue(); } return _myselfCheckId; }
        }
        protected override ConditionValue getCValueMyselfCheckId() { return this.MyselfCheckId; }


        public BsMyselfCheckCQ AddOrderBy_MyselfCheckId_Asc() { regOBA("MYSELF_CHECK_ID");return this; }
        public BsMyselfCheckCQ AddOrderBy_MyselfCheckId_Desc() { regOBD("MYSELF_CHECK_ID");return this; }

        protected ConditionValue _myselfCheckName;
        public ConditionValue MyselfCheckName {
            get { if (_myselfCheckName == null) { _myselfCheckName = new ConditionValue(); } return _myselfCheckName; }
        }
        protected override ConditionValue getCValueMyselfCheckName() { return this.MyselfCheckName; }


        public BsMyselfCheckCQ AddOrderBy_MyselfCheckName_Asc() { regOBA("MYSELF_CHECK_NAME");return this; }
        public BsMyselfCheckCQ AddOrderBy_MyselfCheckName_Desc() { regOBD("MYSELF_CHECK_NAME");return this; }

        protected ConditionValue _myselfId;
        public ConditionValue MyselfId {
            get { if (_myselfId == null) { _myselfId = new ConditionValue(); } return _myselfId; }
        }
        protected override ConditionValue getCValueMyselfId() { return this.MyselfId; }


        protected Map<String, MyselfCQ> _myselfId_InScopeSubQuery_MyselfMap;
        public Map<String, MyselfCQ> MyselfId_InScopeSubQuery_Myself { get { return _myselfId_InScopeSubQuery_MyselfMap; }}
        public override String keepMyselfId_InScopeSubQuery_Myself(MyselfCQ subQuery) {
            if (_myselfId_InScopeSubQuery_MyselfMap == null) { _myselfId_InScopeSubQuery_MyselfMap = new LinkedHashMap<String, MyselfCQ>(); }
            String key = "subQueryMapKey" + (_myselfId_InScopeSubQuery_MyselfMap.size() + 1);
            _myselfId_InScopeSubQuery_MyselfMap.put(key, subQuery); return "MyselfId_InScopeSubQuery_Myself." + key;
        }

        protected Map<String, MyselfCQ> _myselfId_NotInScopeSubQuery_MyselfMap;
        public Map<String, MyselfCQ> MyselfId_NotInScopeSubQuery_Myself { get { return _myselfId_NotInScopeSubQuery_MyselfMap; }}
        public override String keepMyselfId_NotInScopeSubQuery_Myself(MyselfCQ subQuery) {
            if (_myselfId_NotInScopeSubQuery_MyselfMap == null) { _myselfId_NotInScopeSubQuery_MyselfMap = new LinkedHashMap<String, MyselfCQ>(); }
            String key = "subQueryMapKey" + (_myselfId_NotInScopeSubQuery_MyselfMap.size() + 1);
            _myselfId_NotInScopeSubQuery_MyselfMap.put(key, subQuery); return "MyselfId_NotInScopeSubQuery_Myself." + key;
        }

        public BsMyselfCheckCQ AddOrderBy_MyselfId_Asc() { regOBA("MYSELF_ID");return this; }
        public BsMyselfCheckCQ AddOrderBy_MyselfId_Desc() { regOBD("MYSELF_ID");return this; }

        public BsMyselfCheckCQ AddSpecifiedDerivedOrderBy_Asc(String aliasName) { registerSpecifiedDerivedOrderBy_Asc(aliasName); return this; }
        public BsMyselfCheckCQ AddSpecifiedDerivedOrderBy_Desc(String aliasName) { registerSpecifiedDerivedOrderBy_Desc(aliasName); return this; }

        public override void reflectRelationOnUnionQuery(ConditionQuery baseQueryAsSuper, ConditionQuery unionQueryAsSuper) {
            MyselfCheckCQ baseQuery = (MyselfCheckCQ)baseQueryAsSuper;
            MyselfCheckCQ unionQuery = (MyselfCheckCQ)unionQueryAsSuper;
            if (baseQuery.hasConditionQueryMyself()) {
                unionQuery.QueryMyself().reflectRelationOnUnionQuery(baseQuery.QueryMyself(), unionQuery.QueryMyself());
            }

        }
    
        protected MyselfCQ _conditionQueryMyself;
        public MyselfCQ QueryMyself() {
            return this.ConditionQueryMyself;
        }
        public MyselfCQ ConditionQueryMyself {
            get {
                if (_conditionQueryMyself == null) {
                    _conditionQueryMyself = xcreateQueryMyself();
                    xsetupOuterJoin_Myself();
                }
                return _conditionQueryMyself;
            }
        }
        protected MyselfCQ xcreateQueryMyself() {
            String nrp = resolveNextRelationPathMyself();
            String jan = resolveJoinAliasName(nrp, xgetNextNestLevel());
            MyselfCQ cq = new MyselfCQ(this, xgetSqlClause(), jan, xgetNextNestLevel());
            cq.xsetForeignPropertyName("myself"); cq.xsetRelationPath(nrp); return cq;
        }
        public void xsetupOuterJoin_Myself() {
            MyselfCQ cq = ConditionQueryMyself;
            Map<String, String> joinOnMap = new LinkedHashMap<String, String>();
            joinOnMap.put("MYSELF_ID", "MYSELF_ID");
            registerOuterJoin(cq, joinOnMap);
        }
        protected String resolveNextRelationPathMyself() {
            return resolveNextRelationPath("myself_check", "myself");
        }
        public bool hasConditionQueryMyself() {
            return _conditionQueryMyself != null;
        }


	    // ===============================================================================
	    //                                                                 Scalar SubQuery
	    //                                                                 ===============
	    protected Map<String, MyselfCheckCQ> _scalarSubQueryMap;
	    public Map<String, MyselfCheckCQ> ScalarSubQuery { get { return _scalarSubQueryMap; } }
	    public override String keepScalarSubQuery(MyselfCheckCQ subQuery) {
	        if (_scalarSubQueryMap == null) { _scalarSubQueryMap = new LinkedHashMap<String, MyselfCheckCQ>(); }
	        String key = "subQueryMapKey" + (_scalarSubQueryMap.size() + 1);
	        _scalarSubQueryMap.put(key, subQuery); return "ScalarSubQuery." + key;
	    }

        // ===============================================================================
        //                                                         Myself InScope SubQuery
        //                                                         =======================
        protected Map<String, MyselfCheckCQ> _myselfInScopeSubQueryMap;
        public Map<String, MyselfCheckCQ> MyselfInScopeSubQuery { get { return _myselfInScopeSubQueryMap; } }
        public override String keepMyselfInScopeSubQuery(MyselfCheckCQ subQuery) {
            if (_myselfInScopeSubQueryMap == null) { _myselfInScopeSubQueryMap = new LinkedHashMap<String, MyselfCheckCQ>(); }
            String key = "subQueryMapKey" + (_myselfInScopeSubQueryMap.size() + 1);
            _myselfInScopeSubQueryMap.put(key, subQuery); return "MyselfInScopeSubQuery." + key;
        }
    }
}
