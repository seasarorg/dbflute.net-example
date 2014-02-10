
using System;

using DfExample.DBFlute.AllCommon.CBean;
using DfExample.DBFlute.AllCommon.CBean.CValue;
using DfExample.DBFlute.AllCommon.CBean.SClause;
using DfExample.DBFlute.AllCommon.JavaLike;
using DfExample.DBFlute.CBean.CQ;
using DfExample.DBFlute.CBean.CQ.Ciq;

namespace DfExample.DBFlute.CBean.CQ.BS {

    [System.Serializable]
    public class BsWhiteAllInOneClsRefCQ : AbstractBsWhiteAllInOneClsRefCQ {

        protected WhiteAllInOneClsRefCIQ _inlineQuery;

        public BsWhiteAllInOneClsRefCQ(ConditionQuery childQuery, SqlClause sqlClause, String aliasName, int nestLevel)
            : base(childQuery, sqlClause, aliasName, nestLevel) {}

        public WhiteAllInOneClsRefCIQ Inline() {
            if (_inlineQuery == null) {
                _inlineQuery = new WhiteAllInOneClsRefCIQ(xgetReferrerQuery(), xgetSqlClause(), xgetAliasName(), xgetNestLevel(), this);
            }
            _inlineQuery.xsetOnClause(false);
            return _inlineQuery;
        }
        
        public WhiteAllInOneClsRefCIQ On() {
            if (isBaseQuery()) { throw new UnsupportedOperationException("Unsupported onClause of Base Table!"); }
            WhiteAllInOneClsRefCIQ inlineQuery = Inline();
            inlineQuery.xsetOnClause(true);
            return inlineQuery;
        }


        protected ConditionValue _clsRefId;
        public ConditionValue ClsRefId {
            get { if (_clsRefId == null) { _clsRefId = new ConditionValue(); } return _clsRefId; }
        }
        protected override ConditionValue getCValueClsRefId() { return this.ClsRefId; }


        public BsWhiteAllInOneClsRefCQ AddOrderBy_ClsRefId_Asc() { regOBA("CLS_REF_ID");return this; }
        public BsWhiteAllInOneClsRefCQ AddOrderBy_ClsRefId_Desc() { regOBD("CLS_REF_ID");return this; }

        protected ConditionValue _fooCode;
        public ConditionValue FooCode {
            get { if (_fooCode == null) { _fooCode = new ConditionValue(); } return _fooCode; }
        }
        protected override ConditionValue getCValueFooCode() { return this.FooCode; }


        public BsWhiteAllInOneClsRefCQ AddOrderBy_FooCode_Asc() { regOBA("FOO_CODE");return this; }
        public BsWhiteAllInOneClsRefCQ AddOrderBy_FooCode_Desc() { regOBD("FOO_CODE");return this; }

        protected ConditionValue _barCode;
        public ConditionValue BarCode {
            get { if (_barCode == null) { _barCode = new ConditionValue(); } return _barCode; }
        }
        protected override ConditionValue getCValueBarCode() { return this.BarCode; }


        public BsWhiteAllInOneClsRefCQ AddOrderBy_BarCode_Asc() { regOBA("BAR_CODE");return this; }
        public BsWhiteAllInOneClsRefCQ AddOrderBy_BarCode_Desc() { regOBD("BAR_CODE");return this; }

        protected ConditionValue _quxCode;
        public ConditionValue QuxCode {
            get { if (_quxCode == null) { _quxCode = new ConditionValue(); } return _quxCode; }
        }
        protected override ConditionValue getCValueQuxCode() { return this.QuxCode; }


        public BsWhiteAllInOneClsRefCQ AddOrderBy_QuxCode_Asc() { regOBA("QUX_CODE");return this; }
        public BsWhiteAllInOneClsRefCQ AddOrderBy_QuxCode_Desc() { regOBD("QUX_CODE");return this; }

        public BsWhiteAllInOneClsRefCQ AddSpecifiedDerivedOrderBy_Asc(String aliasName) { registerSpecifiedDerivedOrderBy_Asc(aliasName); return this; }
        public BsWhiteAllInOneClsRefCQ AddSpecifiedDerivedOrderBy_Desc(String aliasName) { registerSpecifiedDerivedOrderBy_Desc(aliasName); return this; }

        public override void reflectRelationOnUnionQuery(ConditionQuery baseQueryAsSuper, ConditionQuery unionQueryAsSuper) {
            WhiteAllInOneClsRefCQ baseQuery = (WhiteAllInOneClsRefCQ)baseQueryAsSuper;
            WhiteAllInOneClsRefCQ unionQuery = (WhiteAllInOneClsRefCQ)unionQueryAsSuper;
            if (baseQuery.hasConditionQueryWhiteAllInOneClsAsFoo()) {
                unionQuery.QueryWhiteAllInOneClsAsFoo().reflectRelationOnUnionQuery(baseQuery.QueryWhiteAllInOneClsAsFoo(), unionQuery.QueryWhiteAllInOneClsAsFoo());
            }
            if (baseQuery.hasConditionQueryWhiteAllInOneClsAsBar()) {
                unionQuery.QueryWhiteAllInOneClsAsBar().reflectRelationOnUnionQuery(baseQuery.QueryWhiteAllInOneClsAsBar(), unionQuery.QueryWhiteAllInOneClsAsBar());
            }

        }
    
        protected WhiteAllInOneClsCQ _conditionQueryWhiteAllInOneClsAsFoo;
        public WhiteAllInOneClsCQ QueryWhiteAllInOneClsAsFoo() {
            return this.ConditionQueryWhiteAllInOneClsAsFoo;
        }
        public WhiteAllInOneClsCQ ConditionQueryWhiteAllInOneClsAsFoo {
            get {
                if (_conditionQueryWhiteAllInOneClsAsFoo == null) {
                    _conditionQueryWhiteAllInOneClsAsFoo = xcreateQueryWhiteAllInOneClsAsFoo();
                    xsetupOuterJoin_WhiteAllInOneClsAsFoo();
                }
                return _conditionQueryWhiteAllInOneClsAsFoo;
            }
        }
        protected WhiteAllInOneClsCQ xcreateQueryWhiteAllInOneClsAsFoo() {
            String nrp = resolveNextRelationPathWhiteAllInOneClsAsFoo();
            String jan = resolveJoinAliasName(nrp, xgetNextNestLevel());
            WhiteAllInOneClsCQ cq = new WhiteAllInOneClsCQ(this, xgetSqlClause(), jan, xgetNextNestLevel());
            cq.xsetForeignPropertyName("whiteAllInOneClsAsFoo"); cq.xsetRelationPath(nrp); return cq;
        }
        public void xsetupOuterJoin_WhiteAllInOneClsAsFoo() {
            WhiteAllInOneClsCQ cq = ConditionQueryWhiteAllInOneClsAsFoo;
            Map<String, String> joinOnMap = new LinkedHashMap<String, String>();
            joinOnMap.put("FOO_CODE", "CLS_ELEMENT_CODE");
            registerOuterJoin(cq, joinOnMap, "$$foreignAlias$$.CLS_CATEGORY_CODE = 'FOO'");
        }
        protected String resolveNextRelationPathWhiteAllInOneClsAsFoo() {
            return resolveNextRelationPath("white_all_in_one_cls_ref", "whiteAllInOneClsAsFoo");
        }
        public bool hasConditionQueryWhiteAllInOneClsAsFoo() {
            return _conditionQueryWhiteAllInOneClsAsFoo != null;
        }
        protected WhiteAllInOneClsCQ _conditionQueryWhiteAllInOneClsAsBar;
        public WhiteAllInOneClsCQ QueryWhiteAllInOneClsAsBar() {
            return this.ConditionQueryWhiteAllInOneClsAsBar;
        }
        public WhiteAllInOneClsCQ ConditionQueryWhiteAllInOneClsAsBar {
            get {
                if (_conditionQueryWhiteAllInOneClsAsBar == null) {
                    _conditionQueryWhiteAllInOneClsAsBar = xcreateQueryWhiteAllInOneClsAsBar();
                    xsetupOuterJoin_WhiteAllInOneClsAsBar();
                }
                return _conditionQueryWhiteAllInOneClsAsBar;
            }
        }
        protected WhiteAllInOneClsCQ xcreateQueryWhiteAllInOneClsAsBar() {
            String nrp = resolveNextRelationPathWhiteAllInOneClsAsBar();
            String jan = resolveJoinAliasName(nrp, xgetNextNestLevel());
            WhiteAllInOneClsCQ cq = new WhiteAllInOneClsCQ(this, xgetSqlClause(), jan, xgetNextNestLevel());
            cq.xsetForeignPropertyName("whiteAllInOneClsAsBar"); cq.xsetRelationPath(nrp); return cq;
        }
        public void xsetupOuterJoin_WhiteAllInOneClsAsBar() {
            WhiteAllInOneClsCQ cq = ConditionQueryWhiteAllInOneClsAsBar;
            Map<String, String> joinOnMap = new LinkedHashMap<String, String>();
            joinOnMap.put("BAR_CODE", "CLS_ELEMENT_CODE");
            registerOuterJoin(cq, joinOnMap, "$$foreignAlias$$.CLS_CATEGORY_CODE = 'BAR'");
        }
        protected String resolveNextRelationPathWhiteAllInOneClsAsBar() {
            return resolveNextRelationPath("white_all_in_one_cls_ref", "whiteAllInOneClsAsBar");
        }
        public bool hasConditionQueryWhiteAllInOneClsAsBar() {
            return _conditionQueryWhiteAllInOneClsAsBar != null;
        }


	    // ===============================================================================
	    //                                                                 Scalar SubQuery
	    //                                                                 ===============
	    protected Map<String, WhiteAllInOneClsRefCQ> _scalarSubQueryMap;
	    public Map<String, WhiteAllInOneClsRefCQ> ScalarSubQuery { get { return _scalarSubQueryMap; } }
	    public override String keepScalarSubQuery(WhiteAllInOneClsRefCQ subQuery) {
	        if (_scalarSubQueryMap == null) { _scalarSubQueryMap = new LinkedHashMap<String, WhiteAllInOneClsRefCQ>(); }
	        String key = "subQueryMapKey" + (_scalarSubQueryMap.size() + 1);
	        _scalarSubQueryMap.put(key, subQuery); return "ScalarSubQuery." + key;
	    }

        // ===============================================================================
        //                                                         Myself InScope SubQuery
        //                                                         =======================
        protected Map<String, WhiteAllInOneClsRefCQ> _myselfInScopeSubQueryMap;
        public Map<String, WhiteAllInOneClsRefCQ> MyselfInScopeSubQuery { get { return _myselfInScopeSubQueryMap; } }
        public override String keepMyselfInScopeSubQuery(WhiteAllInOneClsRefCQ subQuery) {
            if (_myselfInScopeSubQueryMap == null) { _myselfInScopeSubQueryMap = new LinkedHashMap<String, WhiteAllInOneClsRefCQ>(); }
            String key = "subQueryMapKey" + (_myselfInScopeSubQueryMap.size() + 1);
            _myselfInScopeSubQueryMap.put(key, subQuery); return "MyselfInScopeSubQuery." + key;
        }
    }
}
