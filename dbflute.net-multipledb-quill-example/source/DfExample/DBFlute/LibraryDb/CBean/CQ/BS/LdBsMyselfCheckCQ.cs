
using System;

using DfExample.DBFlute.LibraryDb.AllCommon.CBean;
using DfExample.DBFlute.LibraryDb.AllCommon.CBean.CValue;
using DfExample.DBFlute.LibraryDb.AllCommon.CBean.SClause;
using DfExample.DBFlute.LibraryDb.AllCommon.JavaLike;
using DfExample.DBFlute.LibraryDb.CBean.CQ;
using DfExample.DBFlute.LibraryDb.CBean.CQ.Ciq;

namespace DfExample.DBFlute.LibraryDb.CBean.CQ.BS {

    [System.Serializable]
    public class LdBsMyselfCheckCQ : LdAbstractBsMyselfCheckCQ {

        protected LdMyselfCheckCIQ _inlineQuery;

        public LdBsMyselfCheckCQ(LdConditionQuery childQuery, LdSqlClause sqlClause, String aliasName, int nestLevel)
            : base(childQuery, sqlClause, aliasName, nestLevel) {}

        public LdMyselfCheckCIQ Inline() {
            if (_inlineQuery == null) {
                _inlineQuery = new LdMyselfCheckCIQ(xgetReferrerQuery(), xgetSqlClause(), xgetAliasName(), xgetNestLevel(), this);
            }
            _inlineQuery.xsetOnClause(false);
            return _inlineQuery;
        }
        
        public LdMyselfCheckCIQ On() {
            if (isBaseQuery()) { throw new UnsupportedOperationException("Unsupported onClause of Base Table!"); }
            LdMyselfCheckCIQ inlineQuery = Inline();
            inlineQuery.xsetOnClause(true);
            return inlineQuery;
        }


        protected LdConditionValue _myselfCheckId;
        public LdConditionValue MyselfCheckId {
            get { if (_myselfCheckId == null) { _myselfCheckId = new LdConditionValue(); } return _myselfCheckId; }
        }
        protected override LdConditionValue getCValueMyselfCheckId() { return this.MyselfCheckId; }


        public LdBsMyselfCheckCQ AddOrderBy_MyselfCheckId_Asc() { regOBA("MYSELF_CHECK_ID");return this; }
        public LdBsMyselfCheckCQ AddOrderBy_MyselfCheckId_Desc() { regOBD("MYSELF_CHECK_ID");return this; }

        protected LdConditionValue _myselfCheckName;
        public LdConditionValue MyselfCheckName {
            get { if (_myselfCheckName == null) { _myselfCheckName = new LdConditionValue(); } return _myselfCheckName; }
        }
        protected override LdConditionValue getCValueMyselfCheckName() { return this.MyselfCheckName; }


        public LdBsMyselfCheckCQ AddOrderBy_MyselfCheckName_Asc() { regOBA("MYSELF_CHECK_NAME");return this; }
        public LdBsMyselfCheckCQ AddOrderBy_MyselfCheckName_Desc() { regOBD("MYSELF_CHECK_NAME");return this; }

        protected LdConditionValue _myselfId;
        public LdConditionValue MyselfId {
            get { if (_myselfId == null) { _myselfId = new LdConditionValue(); } return _myselfId; }
        }
        protected override LdConditionValue getCValueMyselfId() { return this.MyselfId; }


        protected Map<String, LdMyselfCQ> _myselfId_InScopeSubQuery_MyselfMap;
        public Map<String, LdMyselfCQ> MyselfId_InScopeSubQuery_Myself { get { return _myselfId_InScopeSubQuery_MyselfMap; }}
        public override String keepMyselfId_InScopeSubQuery_Myself(LdMyselfCQ subQuery) {
            if (_myselfId_InScopeSubQuery_MyselfMap == null) { _myselfId_InScopeSubQuery_MyselfMap = new LinkedHashMap<String, LdMyselfCQ>(); }
            String key = "subQueryMapKey" + (_myselfId_InScopeSubQuery_MyselfMap.size() + 1);
            _myselfId_InScopeSubQuery_MyselfMap.put(key, subQuery); return "MyselfId_InScopeSubQuery_Myself." + key;
        }

        protected Map<String, LdMyselfCQ> _myselfId_NotInScopeSubQuery_MyselfMap;
        public Map<String, LdMyselfCQ> MyselfId_NotInScopeSubQuery_Myself { get { return _myselfId_NotInScopeSubQuery_MyselfMap; }}
        public override String keepMyselfId_NotInScopeSubQuery_Myself(LdMyselfCQ subQuery) {
            if (_myselfId_NotInScopeSubQuery_MyselfMap == null) { _myselfId_NotInScopeSubQuery_MyselfMap = new LinkedHashMap<String, LdMyselfCQ>(); }
            String key = "subQueryMapKey" + (_myselfId_NotInScopeSubQuery_MyselfMap.size() + 1);
            _myselfId_NotInScopeSubQuery_MyselfMap.put(key, subQuery); return "MyselfId_NotInScopeSubQuery_Myself." + key;
        }

        public LdBsMyselfCheckCQ AddOrderBy_MyselfId_Asc() { regOBA("MYSELF_ID");return this; }
        public LdBsMyselfCheckCQ AddOrderBy_MyselfId_Desc() { regOBD("MYSELF_ID");return this; }

        public LdBsMyselfCheckCQ AddSpecifiedDerivedOrderBy_Asc(String aliasName) { registerSpecifiedDerivedOrderBy_Asc(aliasName); return this; }
        public LdBsMyselfCheckCQ AddSpecifiedDerivedOrderBy_Desc(String aliasName) { registerSpecifiedDerivedOrderBy_Desc(aliasName); return this; }

        public override void reflectRelationOnUnionQuery(LdConditionQuery baseQueryAsSuper, LdConditionQuery unionQueryAsSuper) {
            LdMyselfCheckCQ baseQuery = (LdMyselfCheckCQ)baseQueryAsSuper;
            LdMyselfCheckCQ unionQuery = (LdMyselfCheckCQ)unionQueryAsSuper;
            if (baseQuery.hasConditionQueryMyself()) {
                unionQuery.QueryMyself().reflectRelationOnUnionQuery(baseQuery.QueryMyself(), unionQuery.QueryMyself());
            }

        }
    
        protected LdMyselfCQ _conditionQueryMyself;
        public LdMyselfCQ QueryMyself() {
            return this.ConditionQueryMyself;
        }
        public LdMyselfCQ ConditionQueryMyself {
            get {
                if (_conditionQueryMyself == null) {
                    _conditionQueryMyself = xcreateQueryMyself();
                    xsetupOuterJoin_Myself();
                }
                return _conditionQueryMyself;
            }
        }
        protected LdMyselfCQ xcreateQueryMyself() {
            String nrp = resolveNextRelationPathMyself();
            String jan = resolveJoinAliasName(nrp, xgetNextNestLevel());
            LdMyselfCQ cq = new LdMyselfCQ(this, xgetSqlClause(), jan, xgetNextNestLevel());
            cq.xsetForeignPropertyName("myself"); cq.xsetRelationPath(nrp); return cq;
        }
        public void xsetupOuterJoin_Myself() {
            LdMyselfCQ cq = ConditionQueryMyself;
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
	    protected Map<String, LdMyselfCheckCQ> _scalarSubQueryMap;
	    public Map<String, LdMyselfCheckCQ> ScalarSubQuery { get { return _scalarSubQueryMap; } }
	    public override String keepScalarSubQuery(LdMyselfCheckCQ subQuery) {
	        if (_scalarSubQueryMap == null) { _scalarSubQueryMap = new LinkedHashMap<String, LdMyselfCheckCQ>(); }
	        String key = "subQueryMapKey" + (_scalarSubQueryMap.size() + 1);
	        _scalarSubQueryMap.put(key, subQuery); return "ScalarSubQuery." + key;
	    }

        // ===============================================================================
        //                                                         Myself InScope SubQuery
        //                                                         =======================
        protected Map<String, LdMyselfCheckCQ> _myselfInScopeSubQueryMap;
        public Map<String, LdMyselfCheckCQ> MyselfInScopeSubQuery { get { return _myselfInScopeSubQueryMap; } }
        public override String keepMyselfInScopeSubQuery(LdMyselfCheckCQ subQuery) {
            if (_myselfInScopeSubQueryMap == null) { _myselfInScopeSubQueryMap = new LinkedHashMap<String, LdMyselfCheckCQ>(); }
            String key = "subQueryMapKey" + (_myselfInScopeSubQueryMap.size() + 1);
            _myselfInScopeSubQueryMap.put(key, subQuery); return "MyselfInScopeSubQuery." + key;
        }
    }
}
