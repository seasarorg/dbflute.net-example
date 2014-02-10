
using System;

using DfExample.DBFlute.AllCommon.CBean;
using DfExample.DBFlute.AllCommon.CBean.CValue;
using DfExample.DBFlute.AllCommon.CBean.SClause;
using DfExample.DBFlute.AllCommon.JavaLike;
using DfExample.DBFlute.CBean.CQ;
using DfExample.DBFlute.CBean.CQ.Ciq;

namespace DfExample.DBFlute.CBean.CQ.BS {

    [System.Serializable]
    public class BsWhiteSelfReferenceCQ : AbstractBsWhiteSelfReferenceCQ {

        protected WhiteSelfReferenceCIQ _inlineQuery;

        public BsWhiteSelfReferenceCQ(ConditionQuery childQuery, SqlClause sqlClause, String aliasName, int nestLevel)
            : base(childQuery, sqlClause, aliasName, nestLevel) {}

        public WhiteSelfReferenceCIQ Inline() {
            if (_inlineQuery == null) {
                _inlineQuery = new WhiteSelfReferenceCIQ(xgetReferrerQuery(), xgetSqlClause(), xgetAliasName(), xgetNestLevel(), this);
            }
            _inlineQuery.xsetOnClause(false);
            return _inlineQuery;
        }
        
        public WhiteSelfReferenceCIQ On() {
            if (isBaseQuery()) { throw new UnsupportedOperationException("Unsupported onClause of Base Table!"); }
            WhiteSelfReferenceCIQ inlineQuery = Inline();
            inlineQuery.xsetOnClause(true);
            return inlineQuery;
        }


        protected ConditionValue _selfReferenceId;
        public ConditionValue SelfReferenceId {
            get { if (_selfReferenceId == null) { _selfReferenceId = new ConditionValue(); } return _selfReferenceId; }
        }
        protected override ConditionValue getCValueSelfReferenceId() { return this.SelfReferenceId; }


        protected Map<String, WhiteSelfReferenceCQ> _selfReferenceId_ExistsSubQuery_WhiteSelfReferenceSelfListMap;
        public Map<String, WhiteSelfReferenceCQ> SelfReferenceId_ExistsSubQuery_WhiteSelfReferenceSelfList { get { return _selfReferenceId_ExistsSubQuery_WhiteSelfReferenceSelfListMap; }}
        public override String keepSelfReferenceId_ExistsSubQuery_WhiteSelfReferenceSelfList(WhiteSelfReferenceCQ subQuery) {
            if (_selfReferenceId_ExistsSubQuery_WhiteSelfReferenceSelfListMap == null) { _selfReferenceId_ExistsSubQuery_WhiteSelfReferenceSelfListMap = new LinkedHashMap<String, WhiteSelfReferenceCQ>(); }
            String key = "subQueryMapKey" + (_selfReferenceId_ExistsSubQuery_WhiteSelfReferenceSelfListMap.size() + 1);
            _selfReferenceId_ExistsSubQuery_WhiteSelfReferenceSelfListMap.put(key, subQuery); return "SelfReferenceId_ExistsSubQuery_WhiteSelfReferenceSelfList." + key;
        }

        protected Map<String, WhiteSelfReferenceCQ> _selfReferenceId_NotExistsSubQuery_WhiteSelfReferenceSelfListMap;
        public Map<String, WhiteSelfReferenceCQ> SelfReferenceId_NotExistsSubQuery_WhiteSelfReferenceSelfList { get { return _selfReferenceId_NotExistsSubQuery_WhiteSelfReferenceSelfListMap; }}
        public override String keepSelfReferenceId_NotExistsSubQuery_WhiteSelfReferenceSelfList(WhiteSelfReferenceCQ subQuery) {
            if (_selfReferenceId_NotExistsSubQuery_WhiteSelfReferenceSelfListMap == null) { _selfReferenceId_NotExistsSubQuery_WhiteSelfReferenceSelfListMap = new LinkedHashMap<String, WhiteSelfReferenceCQ>(); }
            String key = "subQueryMapKey" + (_selfReferenceId_NotExistsSubQuery_WhiteSelfReferenceSelfListMap.size() + 1);
            _selfReferenceId_NotExistsSubQuery_WhiteSelfReferenceSelfListMap.put(key, subQuery); return "SelfReferenceId_NotExistsSubQuery_WhiteSelfReferenceSelfList." + key;
        }

        protected Map<String, WhiteSelfReferenceCQ> _selfReferenceId_InScopeSubQuery_WhiteSelfReferenceSelfListMap;
        public Map<String, WhiteSelfReferenceCQ> SelfReferenceId_InScopeSubQuery_WhiteSelfReferenceSelfList { get { return _selfReferenceId_InScopeSubQuery_WhiteSelfReferenceSelfListMap; }}
        public override String keepSelfReferenceId_InScopeSubQuery_WhiteSelfReferenceSelfList(WhiteSelfReferenceCQ subQuery) {
            if (_selfReferenceId_InScopeSubQuery_WhiteSelfReferenceSelfListMap == null) { _selfReferenceId_InScopeSubQuery_WhiteSelfReferenceSelfListMap = new LinkedHashMap<String, WhiteSelfReferenceCQ>(); }
            String key = "subQueryMapKey" + (_selfReferenceId_InScopeSubQuery_WhiteSelfReferenceSelfListMap.size() + 1);
            _selfReferenceId_InScopeSubQuery_WhiteSelfReferenceSelfListMap.put(key, subQuery); return "SelfReferenceId_InScopeSubQuery_WhiteSelfReferenceSelfList." + key;
        }

        protected Map<String, WhiteSelfReferenceCQ> _selfReferenceId_NotInScopeSubQuery_WhiteSelfReferenceSelfListMap;
        public Map<String, WhiteSelfReferenceCQ> SelfReferenceId_NotInScopeSubQuery_WhiteSelfReferenceSelfList { get { return _selfReferenceId_NotInScopeSubQuery_WhiteSelfReferenceSelfListMap; }}
        public override String keepSelfReferenceId_NotInScopeSubQuery_WhiteSelfReferenceSelfList(WhiteSelfReferenceCQ subQuery) {
            if (_selfReferenceId_NotInScopeSubQuery_WhiteSelfReferenceSelfListMap == null) { _selfReferenceId_NotInScopeSubQuery_WhiteSelfReferenceSelfListMap = new LinkedHashMap<String, WhiteSelfReferenceCQ>(); }
            String key = "subQueryMapKey" + (_selfReferenceId_NotInScopeSubQuery_WhiteSelfReferenceSelfListMap.size() + 1);
            _selfReferenceId_NotInScopeSubQuery_WhiteSelfReferenceSelfListMap.put(key, subQuery); return "SelfReferenceId_NotInScopeSubQuery_WhiteSelfReferenceSelfList." + key;
        }

        protected Map<String, WhiteSelfReferenceCQ> _selfReferenceId_SpecifyDerivedReferrer_WhiteSelfReferenceSelfListMap;
        public Map<String, WhiteSelfReferenceCQ> SelfReferenceId_SpecifyDerivedReferrer_WhiteSelfReferenceSelfList { get { return _selfReferenceId_SpecifyDerivedReferrer_WhiteSelfReferenceSelfListMap; }}
        public override String keepSelfReferenceId_SpecifyDerivedReferrer_WhiteSelfReferenceSelfList(WhiteSelfReferenceCQ subQuery) {
            if (_selfReferenceId_SpecifyDerivedReferrer_WhiteSelfReferenceSelfListMap == null) { _selfReferenceId_SpecifyDerivedReferrer_WhiteSelfReferenceSelfListMap = new LinkedHashMap<String, WhiteSelfReferenceCQ>(); }
            String key = "subQueryMapKey" + (_selfReferenceId_SpecifyDerivedReferrer_WhiteSelfReferenceSelfListMap.size() + 1);
            _selfReferenceId_SpecifyDerivedReferrer_WhiteSelfReferenceSelfListMap.put(key, subQuery); return "SelfReferenceId_SpecifyDerivedReferrer_WhiteSelfReferenceSelfList." + key;
        }

        protected Map<String, WhiteSelfReferenceCQ> _selfReferenceId_QueryDerivedReferrer_WhiteSelfReferenceSelfListMap;
        public Map<String, WhiteSelfReferenceCQ> SelfReferenceId_QueryDerivedReferrer_WhiteSelfReferenceSelfList { get { return _selfReferenceId_QueryDerivedReferrer_WhiteSelfReferenceSelfListMap; } }
        public override String keepSelfReferenceId_QueryDerivedReferrer_WhiteSelfReferenceSelfList(WhiteSelfReferenceCQ subQuery) {
            if (_selfReferenceId_QueryDerivedReferrer_WhiteSelfReferenceSelfListMap == null) { _selfReferenceId_QueryDerivedReferrer_WhiteSelfReferenceSelfListMap = new LinkedHashMap<String, WhiteSelfReferenceCQ>(); }
            String key = "subQueryMapKey" + (_selfReferenceId_QueryDerivedReferrer_WhiteSelfReferenceSelfListMap.size() + 1);
            _selfReferenceId_QueryDerivedReferrer_WhiteSelfReferenceSelfListMap.put(key, subQuery); return "SelfReferenceId_QueryDerivedReferrer_WhiteSelfReferenceSelfList." + key;
        }
        protected Map<String, Object> _selfReferenceId_QueryDerivedReferrer_WhiteSelfReferenceSelfListParameterMap;
        public Map<String, Object> SelfReferenceId_QueryDerivedReferrer_WhiteSelfReferenceSelfListParameter { get { return _selfReferenceId_QueryDerivedReferrer_WhiteSelfReferenceSelfListParameterMap; } }
        public override String keepSelfReferenceId_QueryDerivedReferrer_WhiteSelfReferenceSelfListParameter(Object parameterValue) {
            if (_selfReferenceId_QueryDerivedReferrer_WhiteSelfReferenceSelfListParameterMap == null) { _selfReferenceId_QueryDerivedReferrer_WhiteSelfReferenceSelfListParameterMap = new LinkedHashMap<String, Object>(); }
            String key = "subQueryParameterKey" + (_selfReferenceId_QueryDerivedReferrer_WhiteSelfReferenceSelfListParameterMap.size() + 1);
            _selfReferenceId_QueryDerivedReferrer_WhiteSelfReferenceSelfListParameterMap.put(key, parameterValue); return "SelfReferenceId_QueryDerivedReferrer_WhiteSelfReferenceSelfListParameter." + key;
        }

        public BsWhiteSelfReferenceCQ AddOrderBy_SelfReferenceId_Asc() { regOBA("SELF_REFERENCE_ID");return this; }
        public BsWhiteSelfReferenceCQ AddOrderBy_SelfReferenceId_Desc() { regOBD("SELF_REFERENCE_ID");return this; }

        protected ConditionValue _selfReferenceName;
        public ConditionValue SelfReferenceName {
            get { if (_selfReferenceName == null) { _selfReferenceName = new ConditionValue(); } return _selfReferenceName; }
        }
        protected override ConditionValue getCValueSelfReferenceName() { return this.SelfReferenceName; }


        public BsWhiteSelfReferenceCQ AddOrderBy_SelfReferenceName_Asc() { regOBA("SELF_REFERENCE_NAME");return this; }
        public BsWhiteSelfReferenceCQ AddOrderBy_SelfReferenceName_Desc() { regOBD("SELF_REFERENCE_NAME");return this; }

        protected ConditionValue _parentId;
        public ConditionValue ParentId {
            get { if (_parentId == null) { _parentId = new ConditionValue(); } return _parentId; }
        }
        protected override ConditionValue getCValueParentId() { return this.ParentId; }


        protected Map<String, WhiteSelfReferenceCQ> _parentId_InScopeSubQuery_WhiteSelfReferenceSelfMap;
        public Map<String, WhiteSelfReferenceCQ> ParentId_InScopeSubQuery_WhiteSelfReferenceSelf { get { return _parentId_InScopeSubQuery_WhiteSelfReferenceSelfMap; }}
        public override String keepParentId_InScopeSubQuery_WhiteSelfReferenceSelf(WhiteSelfReferenceCQ subQuery) {
            if (_parentId_InScopeSubQuery_WhiteSelfReferenceSelfMap == null) { _parentId_InScopeSubQuery_WhiteSelfReferenceSelfMap = new LinkedHashMap<String, WhiteSelfReferenceCQ>(); }
            String key = "subQueryMapKey" + (_parentId_InScopeSubQuery_WhiteSelfReferenceSelfMap.size() + 1);
            _parentId_InScopeSubQuery_WhiteSelfReferenceSelfMap.put(key, subQuery); return "ParentId_InScopeSubQuery_WhiteSelfReferenceSelf." + key;
        }

        protected Map<String, WhiteSelfReferenceCQ> _parentId_NotInScopeSubQuery_WhiteSelfReferenceSelfMap;
        public Map<String, WhiteSelfReferenceCQ> ParentId_NotInScopeSubQuery_WhiteSelfReferenceSelf { get { return _parentId_NotInScopeSubQuery_WhiteSelfReferenceSelfMap; }}
        public override String keepParentId_NotInScopeSubQuery_WhiteSelfReferenceSelf(WhiteSelfReferenceCQ subQuery) {
            if (_parentId_NotInScopeSubQuery_WhiteSelfReferenceSelfMap == null) { _parentId_NotInScopeSubQuery_WhiteSelfReferenceSelfMap = new LinkedHashMap<String, WhiteSelfReferenceCQ>(); }
            String key = "subQueryMapKey" + (_parentId_NotInScopeSubQuery_WhiteSelfReferenceSelfMap.size() + 1);
            _parentId_NotInScopeSubQuery_WhiteSelfReferenceSelfMap.put(key, subQuery); return "ParentId_NotInScopeSubQuery_WhiteSelfReferenceSelf." + key;
        }

        public BsWhiteSelfReferenceCQ AddOrderBy_ParentId_Asc() { regOBA("PARENT_ID");return this; }
        public BsWhiteSelfReferenceCQ AddOrderBy_ParentId_Desc() { regOBD("PARENT_ID");return this; }

        public BsWhiteSelfReferenceCQ AddSpecifiedDerivedOrderBy_Asc(String aliasName) { registerSpecifiedDerivedOrderBy_Asc(aliasName); return this; }
        public BsWhiteSelfReferenceCQ AddSpecifiedDerivedOrderBy_Desc(String aliasName) { registerSpecifiedDerivedOrderBy_Desc(aliasName); return this; }

        public override void reflectRelationOnUnionQuery(ConditionQuery baseQueryAsSuper, ConditionQuery unionQueryAsSuper) {
            WhiteSelfReferenceCQ baseQuery = (WhiteSelfReferenceCQ)baseQueryAsSuper;
            WhiteSelfReferenceCQ unionQuery = (WhiteSelfReferenceCQ)unionQueryAsSuper;
            if (baseQuery.hasConditionQueryWhiteSelfReferenceSelf()) {
                unionQuery.QueryWhiteSelfReferenceSelf().reflectRelationOnUnionQuery(baseQuery.QueryWhiteSelfReferenceSelf(), unionQuery.QueryWhiteSelfReferenceSelf());
            }

        }
    
        protected WhiteSelfReferenceCQ _conditionQueryWhiteSelfReferenceSelf;
        public WhiteSelfReferenceCQ QueryWhiteSelfReferenceSelf() {
            return this.ConditionQueryWhiteSelfReferenceSelf;
        }
        public WhiteSelfReferenceCQ ConditionQueryWhiteSelfReferenceSelf {
            get {
                if (_conditionQueryWhiteSelfReferenceSelf == null) {
                    _conditionQueryWhiteSelfReferenceSelf = xcreateQueryWhiteSelfReferenceSelf();
                    xsetupOuterJoin_WhiteSelfReferenceSelf();
                }
                return _conditionQueryWhiteSelfReferenceSelf;
            }
        }
        protected WhiteSelfReferenceCQ xcreateQueryWhiteSelfReferenceSelf() {
            String nrp = resolveNextRelationPathWhiteSelfReferenceSelf();
            String jan = resolveJoinAliasName(nrp, xgetNextNestLevel());
            WhiteSelfReferenceCQ cq = new WhiteSelfReferenceCQ(this, xgetSqlClause(), jan, xgetNextNestLevel());
            cq.xsetForeignPropertyName("whiteSelfReferenceSelf"); cq.xsetRelationPath(nrp); return cq;
        }
        public void xsetupOuterJoin_WhiteSelfReferenceSelf() {
            WhiteSelfReferenceCQ cq = ConditionQueryWhiteSelfReferenceSelf;
            Map<String, String> joinOnMap = new LinkedHashMap<String, String>();
            joinOnMap.put("PARENT_ID", "SELF_REFERENCE_ID");
            registerOuterJoin(cq, joinOnMap);
        }
        protected String resolveNextRelationPathWhiteSelfReferenceSelf() {
            return resolveNextRelationPath("white_self_reference", "whiteSelfReferenceSelf");
        }
        public bool hasConditionQueryWhiteSelfReferenceSelf() {
            return _conditionQueryWhiteSelfReferenceSelf != null;
        }


	    // ===============================================================================
	    //                                                                 Scalar SubQuery
	    //                                                                 ===============
	    protected Map<String, WhiteSelfReferenceCQ> _scalarSubQueryMap;
	    public Map<String, WhiteSelfReferenceCQ> ScalarSubQuery { get { return _scalarSubQueryMap; } }
	    public override String keepScalarSubQuery(WhiteSelfReferenceCQ subQuery) {
	        if (_scalarSubQueryMap == null) { _scalarSubQueryMap = new LinkedHashMap<String, WhiteSelfReferenceCQ>(); }
	        String key = "subQueryMapKey" + (_scalarSubQueryMap.size() + 1);
	        _scalarSubQueryMap.put(key, subQuery); return "ScalarSubQuery." + key;
	    }

        // ===============================================================================
        //                                                         Myself InScope SubQuery
        //                                                         =======================
        protected Map<String, WhiteSelfReferenceCQ> _myselfInScopeSubQueryMap;
        public Map<String, WhiteSelfReferenceCQ> MyselfInScopeSubQuery { get { return _myselfInScopeSubQueryMap; } }
        public override String keepMyselfInScopeSubQuery(WhiteSelfReferenceCQ subQuery) {
            if (_myselfInScopeSubQueryMap == null) { _myselfInScopeSubQueryMap = new LinkedHashMap<String, WhiteSelfReferenceCQ>(); }
            String key = "subQueryMapKey" + (_myselfInScopeSubQueryMap.size() + 1);
            _myselfInScopeSubQueryMap.put(key, subQuery); return "MyselfInScopeSubQuery." + key;
        }
    }
}
