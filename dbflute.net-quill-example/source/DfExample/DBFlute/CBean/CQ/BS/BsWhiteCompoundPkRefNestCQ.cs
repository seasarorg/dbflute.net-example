
using System;

using DfExample.DBFlute.AllCommon.CBean;
using DfExample.DBFlute.AllCommon.CBean.CValue;
using DfExample.DBFlute.AllCommon.CBean.SClause;
using DfExample.DBFlute.AllCommon.JavaLike;
using DfExample.DBFlute.CBean.CQ;
using DfExample.DBFlute.CBean.CQ.Ciq;

namespace DfExample.DBFlute.CBean.CQ.BS {

    [System.Serializable]
    public class BsWhiteCompoundPkRefNestCQ : AbstractBsWhiteCompoundPkRefNestCQ {

        protected WhiteCompoundPkRefNestCIQ _inlineQuery;

        public BsWhiteCompoundPkRefNestCQ(ConditionQuery childQuery, SqlClause sqlClause, String aliasName, int nestLevel)
            : base(childQuery, sqlClause, aliasName, nestLevel) {}

        public WhiteCompoundPkRefNestCIQ Inline() {
            if (_inlineQuery == null) {
                _inlineQuery = new WhiteCompoundPkRefNestCIQ(xgetReferrerQuery(), xgetSqlClause(), xgetAliasName(), xgetNestLevel(), this);
            }
            _inlineQuery.xsetOnClause(false);
            return _inlineQuery;
        }
        
        public WhiteCompoundPkRefNestCIQ On() {
            if (isBaseQuery()) { throw new UnsupportedOperationException("Unsupported onClause of Base Table!"); }
            WhiteCompoundPkRefNestCIQ inlineQuery = Inline();
            inlineQuery.xsetOnClause(true);
            return inlineQuery;
        }


        protected ConditionValue _compoundPkRefNestId;
        public ConditionValue CompoundPkRefNestId {
            get { if (_compoundPkRefNestId == null) { _compoundPkRefNestId = new ConditionValue(); } return _compoundPkRefNestId; }
        }
        protected override ConditionValue getCValueCompoundPkRefNestId() { return this.CompoundPkRefNestId; }


        public BsWhiteCompoundPkRefNestCQ AddOrderBy_CompoundPkRefNestId_Asc() { regOBA("COMPOUND_PK_REF_NEST_ID");return this; }
        public BsWhiteCompoundPkRefNestCQ AddOrderBy_CompoundPkRefNestId_Desc() { regOBD("COMPOUND_PK_REF_NEST_ID");return this; }

        protected ConditionValue _fooMultipleId;
        public ConditionValue FooMultipleId {
            get { if (_fooMultipleId == null) { _fooMultipleId = new ConditionValue(); } return _fooMultipleId; }
        }
        protected override ConditionValue getCValueFooMultipleId() { return this.FooMultipleId; }


        public BsWhiteCompoundPkRefNestCQ AddOrderBy_FooMultipleId_Asc() { regOBA("FOO_MULTIPLE_ID");return this; }
        public BsWhiteCompoundPkRefNestCQ AddOrderBy_FooMultipleId_Desc() { regOBD("FOO_MULTIPLE_ID");return this; }

        protected ConditionValue _barMultipleId;
        public ConditionValue BarMultipleId {
            get { if (_barMultipleId == null) { _barMultipleId = new ConditionValue(); } return _barMultipleId; }
        }
        protected override ConditionValue getCValueBarMultipleId() { return this.BarMultipleId; }


        public BsWhiteCompoundPkRefNestCQ AddOrderBy_BarMultipleId_Asc() { regOBA("BAR_MULTIPLE_ID");return this; }
        public BsWhiteCompoundPkRefNestCQ AddOrderBy_BarMultipleId_Desc() { regOBD("BAR_MULTIPLE_ID");return this; }

        protected ConditionValue _quxMultipleId;
        public ConditionValue QuxMultipleId {
            get { if (_quxMultipleId == null) { _quxMultipleId = new ConditionValue(); } return _quxMultipleId; }
        }
        protected override ConditionValue getCValueQuxMultipleId() { return this.QuxMultipleId; }


        public BsWhiteCompoundPkRefNestCQ AddOrderBy_QuxMultipleId_Asc() { regOBA("QUX_MULTIPLE_ID");return this; }
        public BsWhiteCompoundPkRefNestCQ AddOrderBy_QuxMultipleId_Desc() { regOBD("QUX_MULTIPLE_ID");return this; }

        public BsWhiteCompoundPkRefNestCQ AddSpecifiedDerivedOrderBy_Asc(String aliasName) { registerSpecifiedDerivedOrderBy_Asc(aliasName); return this; }
        public BsWhiteCompoundPkRefNestCQ AddSpecifiedDerivedOrderBy_Desc(String aliasName) { registerSpecifiedDerivedOrderBy_Desc(aliasName); return this; }

        public override void reflectRelationOnUnionQuery(ConditionQuery baseQueryAsSuper, ConditionQuery unionQueryAsSuper) {
            WhiteCompoundPkRefNestCQ baseQuery = (WhiteCompoundPkRefNestCQ)baseQueryAsSuper;
            WhiteCompoundPkRefNestCQ unionQuery = (WhiteCompoundPkRefNestCQ)unionQueryAsSuper;
            if (baseQuery.hasConditionQueryWhiteCompoundPkRefByQuxMultipleId()) {
                unionQuery.QueryWhiteCompoundPkRefByQuxMultipleId().reflectRelationOnUnionQuery(baseQuery.QueryWhiteCompoundPkRefByQuxMultipleId(), unionQuery.QueryWhiteCompoundPkRefByQuxMultipleId());
            }
            if (baseQuery.hasConditionQueryWhiteCompoundPkRefByFooMultipleId()) {
                unionQuery.QueryWhiteCompoundPkRefByFooMultipleId().reflectRelationOnUnionQuery(baseQuery.QueryWhiteCompoundPkRefByFooMultipleId(), unionQuery.QueryWhiteCompoundPkRefByFooMultipleId());
            }

        }
    
        protected WhiteCompoundPkRefCQ _conditionQueryWhiteCompoundPkRefByQuxMultipleId;
        public WhiteCompoundPkRefCQ QueryWhiteCompoundPkRefByQuxMultipleId() {
            return this.ConditionQueryWhiteCompoundPkRefByQuxMultipleId;
        }
        public WhiteCompoundPkRefCQ ConditionQueryWhiteCompoundPkRefByQuxMultipleId {
            get {
                if (_conditionQueryWhiteCompoundPkRefByQuxMultipleId == null) {
                    _conditionQueryWhiteCompoundPkRefByQuxMultipleId = xcreateQueryWhiteCompoundPkRefByQuxMultipleId();
                    xsetupOuterJoin_WhiteCompoundPkRefByQuxMultipleId();
                }
                return _conditionQueryWhiteCompoundPkRefByQuxMultipleId;
            }
        }
        protected WhiteCompoundPkRefCQ xcreateQueryWhiteCompoundPkRefByQuxMultipleId() {
            String nrp = resolveNextRelationPathWhiteCompoundPkRefByQuxMultipleId();
            String jan = resolveJoinAliasName(nrp, xgetNextNestLevel());
            WhiteCompoundPkRefCQ cq = new WhiteCompoundPkRefCQ(this, xgetSqlClause(), jan, xgetNextNestLevel());
            cq.xsetForeignPropertyName("whiteCompoundPkRefByQuxMultipleId"); cq.xsetRelationPath(nrp); return cq;
        }
        public void xsetupOuterJoin_WhiteCompoundPkRefByQuxMultipleId() {
            WhiteCompoundPkRefCQ cq = ConditionQueryWhiteCompoundPkRefByQuxMultipleId;
            Map<String, String> joinOnMap = new LinkedHashMap<String, String>();
            joinOnMap.put("BAR_MULTIPLE_ID", "MULTIPLE_FIRST_ID");
            joinOnMap.put("QUX_MULTIPLE_ID", "MULTIPLE_SECOND_ID");
            registerOuterJoin(cq, joinOnMap);
        }
        protected String resolveNextRelationPathWhiteCompoundPkRefByQuxMultipleId() {
            return resolveNextRelationPath("white_compound_pk_ref_nest", "whiteCompoundPkRefByQuxMultipleId");
        }
        public bool hasConditionQueryWhiteCompoundPkRefByQuxMultipleId() {
            return _conditionQueryWhiteCompoundPkRefByQuxMultipleId != null;
        }
        protected WhiteCompoundPkRefCQ _conditionQueryWhiteCompoundPkRefByFooMultipleId;
        public WhiteCompoundPkRefCQ QueryWhiteCompoundPkRefByFooMultipleId() {
            return this.ConditionQueryWhiteCompoundPkRefByFooMultipleId;
        }
        public WhiteCompoundPkRefCQ ConditionQueryWhiteCompoundPkRefByFooMultipleId {
            get {
                if (_conditionQueryWhiteCompoundPkRefByFooMultipleId == null) {
                    _conditionQueryWhiteCompoundPkRefByFooMultipleId = xcreateQueryWhiteCompoundPkRefByFooMultipleId();
                    xsetupOuterJoin_WhiteCompoundPkRefByFooMultipleId();
                }
                return _conditionQueryWhiteCompoundPkRefByFooMultipleId;
            }
        }
        protected WhiteCompoundPkRefCQ xcreateQueryWhiteCompoundPkRefByFooMultipleId() {
            String nrp = resolveNextRelationPathWhiteCompoundPkRefByFooMultipleId();
            String jan = resolveJoinAliasName(nrp, xgetNextNestLevel());
            WhiteCompoundPkRefCQ cq = new WhiteCompoundPkRefCQ(this, xgetSqlClause(), jan, xgetNextNestLevel());
            cq.xsetForeignPropertyName("whiteCompoundPkRefByFooMultipleId"); cq.xsetRelationPath(nrp); return cq;
        }
        public void xsetupOuterJoin_WhiteCompoundPkRefByFooMultipleId() {
            WhiteCompoundPkRefCQ cq = ConditionQueryWhiteCompoundPkRefByFooMultipleId;
            Map<String, String> joinOnMap = new LinkedHashMap<String, String>();
            joinOnMap.put("FOO_MULTIPLE_ID", "MULTIPLE_FIRST_ID");
            joinOnMap.put("BAR_MULTIPLE_ID", "MULTIPLE_SECOND_ID");
            registerOuterJoin(cq, joinOnMap);
        }
        protected String resolveNextRelationPathWhiteCompoundPkRefByFooMultipleId() {
            return resolveNextRelationPath("white_compound_pk_ref_nest", "whiteCompoundPkRefByFooMultipleId");
        }
        public bool hasConditionQueryWhiteCompoundPkRefByFooMultipleId() {
            return _conditionQueryWhiteCompoundPkRefByFooMultipleId != null;
        }


	    // ===============================================================================
	    //                                                                 Scalar SubQuery
	    //                                                                 ===============
	    protected Map<String, WhiteCompoundPkRefNestCQ> _scalarSubQueryMap;
	    public Map<String, WhiteCompoundPkRefNestCQ> ScalarSubQuery { get { return _scalarSubQueryMap; } }
	    public override String keepScalarSubQuery(WhiteCompoundPkRefNestCQ subQuery) {
	        if (_scalarSubQueryMap == null) { _scalarSubQueryMap = new LinkedHashMap<String, WhiteCompoundPkRefNestCQ>(); }
	        String key = "subQueryMapKey" + (_scalarSubQueryMap.size() + 1);
	        _scalarSubQueryMap.put(key, subQuery); return "ScalarSubQuery." + key;
	    }

        // ===============================================================================
        //                                                         Myself InScope SubQuery
        //                                                         =======================
        protected Map<String, WhiteCompoundPkRefNestCQ> _myselfInScopeSubQueryMap;
        public Map<String, WhiteCompoundPkRefNestCQ> MyselfInScopeSubQuery { get { return _myselfInScopeSubQueryMap; } }
        public override String keepMyselfInScopeSubQuery(WhiteCompoundPkRefNestCQ subQuery) {
            if (_myselfInScopeSubQueryMap == null) { _myselfInScopeSubQueryMap = new LinkedHashMap<String, WhiteCompoundPkRefNestCQ>(); }
            String key = "subQueryMapKey" + (_myselfInScopeSubQueryMap.size() + 1);
            _myselfInScopeSubQueryMap.put(key, subQuery); return "MyselfInScopeSubQuery." + key;
        }
    }
}
