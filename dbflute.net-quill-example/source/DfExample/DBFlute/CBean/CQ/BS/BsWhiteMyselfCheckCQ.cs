
using System;

using DfExample.DBFlute.AllCommon.CBean;
using DfExample.DBFlute.AllCommon.CBean.CValue;
using DfExample.DBFlute.AllCommon.CBean.SClause;
using DfExample.DBFlute.AllCommon.JavaLike;
using DfExample.DBFlute.CBean.CQ;
using DfExample.DBFlute.CBean.CQ.Ciq;

namespace DfExample.DBFlute.CBean.CQ.BS {

    [System.Serializable]
    public class BsWhiteMyselfCheckCQ : AbstractBsWhiteMyselfCheckCQ {

        protected WhiteMyselfCheckCIQ _inlineQuery;

        public BsWhiteMyselfCheckCQ(ConditionQuery childQuery, SqlClause sqlClause, String aliasName, int nestLevel)
            : base(childQuery, sqlClause, aliasName, nestLevel) {}

        public WhiteMyselfCheckCIQ Inline() {
            if (_inlineQuery == null) {
                _inlineQuery = new WhiteMyselfCheckCIQ(xgetReferrerQuery(), xgetSqlClause(), xgetAliasName(), xgetNestLevel(), this);
            }
            _inlineQuery.xsetOnClause(false);
            return _inlineQuery;
        }
        
        public WhiteMyselfCheckCIQ On() {
            if (isBaseQuery()) { throw new UnsupportedOperationException("Unsupported onClause of Base Table!"); }
            WhiteMyselfCheckCIQ inlineQuery = Inline();
            inlineQuery.xsetOnClause(true);
            return inlineQuery;
        }


        protected ConditionValue _myselfCheckId;
        public ConditionValue MyselfCheckId {
            get { if (_myselfCheckId == null) { _myselfCheckId = new ConditionValue(); } return _myselfCheckId; }
        }
        protected override ConditionValue getCValueMyselfCheckId() { return this.MyselfCheckId; }


        public BsWhiteMyselfCheckCQ AddOrderBy_MyselfCheckId_Asc() { regOBA("MYSELF_CHECK_ID");return this; }
        public BsWhiteMyselfCheckCQ AddOrderBy_MyselfCheckId_Desc() { regOBD("MYSELF_CHECK_ID");return this; }

        protected ConditionValue _myselfCheckName;
        public ConditionValue MyselfCheckName {
            get { if (_myselfCheckName == null) { _myselfCheckName = new ConditionValue(); } return _myselfCheckName; }
        }
        protected override ConditionValue getCValueMyselfCheckName() { return this.MyselfCheckName; }


        public BsWhiteMyselfCheckCQ AddOrderBy_MyselfCheckName_Asc() { regOBA("MYSELF_CHECK_NAME");return this; }
        public BsWhiteMyselfCheckCQ AddOrderBy_MyselfCheckName_Desc() { regOBD("MYSELF_CHECK_NAME");return this; }

        protected ConditionValue _myselfId;
        public ConditionValue MyselfId {
            get { if (_myselfId == null) { _myselfId = new ConditionValue(); } return _myselfId; }
        }
        protected override ConditionValue getCValueMyselfId() { return this.MyselfId; }


        protected Map<String, WhiteMyselfCQ> _myselfId_InScopeSubQuery_WhiteMyselfMap;
        public Map<String, WhiteMyselfCQ> MyselfId_InScopeSubQuery_WhiteMyself { get { return _myselfId_InScopeSubQuery_WhiteMyselfMap; }}
        public override String keepMyselfId_InScopeSubQuery_WhiteMyself(WhiteMyselfCQ subQuery) {
            if (_myselfId_InScopeSubQuery_WhiteMyselfMap == null) { _myselfId_InScopeSubQuery_WhiteMyselfMap = new LinkedHashMap<String, WhiteMyselfCQ>(); }
            String key = "subQueryMapKey" + (_myselfId_InScopeSubQuery_WhiteMyselfMap.size() + 1);
            _myselfId_InScopeSubQuery_WhiteMyselfMap.put(key, subQuery); return "MyselfId_InScopeSubQuery_WhiteMyself." + key;
        }

        protected Map<String, WhiteMyselfCQ> _myselfId_NotInScopeSubQuery_WhiteMyselfMap;
        public Map<String, WhiteMyselfCQ> MyselfId_NotInScopeSubQuery_WhiteMyself { get { return _myselfId_NotInScopeSubQuery_WhiteMyselfMap; }}
        public override String keepMyselfId_NotInScopeSubQuery_WhiteMyself(WhiteMyselfCQ subQuery) {
            if (_myselfId_NotInScopeSubQuery_WhiteMyselfMap == null) { _myselfId_NotInScopeSubQuery_WhiteMyselfMap = new LinkedHashMap<String, WhiteMyselfCQ>(); }
            String key = "subQueryMapKey" + (_myselfId_NotInScopeSubQuery_WhiteMyselfMap.size() + 1);
            _myselfId_NotInScopeSubQuery_WhiteMyselfMap.put(key, subQuery); return "MyselfId_NotInScopeSubQuery_WhiteMyself." + key;
        }

        public BsWhiteMyselfCheckCQ AddOrderBy_MyselfId_Asc() { regOBA("MYSELF_ID");return this; }
        public BsWhiteMyselfCheckCQ AddOrderBy_MyselfId_Desc() { regOBD("MYSELF_ID");return this; }

        public BsWhiteMyselfCheckCQ AddSpecifiedDerivedOrderBy_Asc(String aliasName) { registerSpecifiedDerivedOrderBy_Asc(aliasName); return this; }
        public BsWhiteMyselfCheckCQ AddSpecifiedDerivedOrderBy_Desc(String aliasName) { registerSpecifiedDerivedOrderBy_Desc(aliasName); return this; }

        public override void reflectRelationOnUnionQuery(ConditionQuery baseQueryAsSuper, ConditionQuery unionQueryAsSuper) {
            WhiteMyselfCheckCQ baseQuery = (WhiteMyselfCheckCQ)baseQueryAsSuper;
            WhiteMyselfCheckCQ unionQuery = (WhiteMyselfCheckCQ)unionQueryAsSuper;
            if (baseQuery.hasConditionQueryWhiteMyself()) {
                unionQuery.QueryWhiteMyself().reflectRelationOnUnionQuery(baseQuery.QueryWhiteMyself(), unionQuery.QueryWhiteMyself());
            }

        }
    
        protected WhiteMyselfCQ _conditionQueryWhiteMyself;
        public WhiteMyselfCQ QueryWhiteMyself() {
            return this.ConditionQueryWhiteMyself;
        }
        public WhiteMyselfCQ ConditionQueryWhiteMyself {
            get {
                if (_conditionQueryWhiteMyself == null) {
                    _conditionQueryWhiteMyself = xcreateQueryWhiteMyself();
                    xsetupOuterJoin_WhiteMyself();
                }
                return _conditionQueryWhiteMyself;
            }
        }
        protected WhiteMyselfCQ xcreateQueryWhiteMyself() {
            String nrp = resolveNextRelationPathWhiteMyself();
            String jan = resolveJoinAliasName(nrp, xgetNextNestLevel());
            WhiteMyselfCQ cq = new WhiteMyselfCQ(this, xgetSqlClause(), jan, xgetNextNestLevel());
            cq.xsetForeignPropertyName("whiteMyself"); cq.xsetRelationPath(nrp); return cq;
        }
        public void xsetupOuterJoin_WhiteMyself() {
            WhiteMyselfCQ cq = ConditionQueryWhiteMyself;
            Map<String, String> joinOnMap = new LinkedHashMap<String, String>();
            joinOnMap.put("MYSELF_ID", "MYSELF_ID");
            registerOuterJoin(cq, joinOnMap);
        }
        protected String resolveNextRelationPathWhiteMyself() {
            return resolveNextRelationPath("white_myself_check", "whiteMyself");
        }
        public bool hasConditionQueryWhiteMyself() {
            return _conditionQueryWhiteMyself != null;
        }


	    // ===============================================================================
	    //                                                                 Scalar SubQuery
	    //                                                                 ===============
	    protected Map<String, WhiteMyselfCheckCQ> _scalarSubQueryMap;
	    public Map<String, WhiteMyselfCheckCQ> ScalarSubQuery { get { return _scalarSubQueryMap; } }
	    public override String keepScalarSubQuery(WhiteMyselfCheckCQ subQuery) {
	        if (_scalarSubQueryMap == null) { _scalarSubQueryMap = new LinkedHashMap<String, WhiteMyselfCheckCQ>(); }
	        String key = "subQueryMapKey" + (_scalarSubQueryMap.size() + 1);
	        _scalarSubQueryMap.put(key, subQuery); return "ScalarSubQuery." + key;
	    }

        // ===============================================================================
        //                                                         Myself InScope SubQuery
        //                                                         =======================
        protected Map<String, WhiteMyselfCheckCQ> _myselfInScopeSubQueryMap;
        public Map<String, WhiteMyselfCheckCQ> MyselfInScopeSubQuery { get { return _myselfInScopeSubQueryMap; } }
        public override String keepMyselfInScopeSubQuery(WhiteMyselfCheckCQ subQuery) {
            if (_myselfInScopeSubQueryMap == null) { _myselfInScopeSubQueryMap = new LinkedHashMap<String, WhiteMyselfCheckCQ>(); }
            String key = "subQueryMapKey" + (_myselfInScopeSubQueryMap.size() + 1);
            _myselfInScopeSubQueryMap.put(key, subQuery); return "MyselfInScopeSubQuery." + key;
        }
    }
}
