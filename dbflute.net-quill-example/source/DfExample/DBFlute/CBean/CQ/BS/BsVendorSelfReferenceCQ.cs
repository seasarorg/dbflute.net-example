
using System;

using DfExample.DBFlute.AllCommon.CBean;
using DfExample.DBFlute.AllCommon.CBean.CValue;
using DfExample.DBFlute.AllCommon.CBean.SClause;
using DfExample.DBFlute.AllCommon.JavaLike;
using DfExample.DBFlute.CBean.CQ;
using DfExample.DBFlute.CBean.CQ.Ciq;

namespace DfExample.DBFlute.CBean.CQ.BS {

    [System.Serializable]
    public class BsVendorSelfReferenceCQ : AbstractBsVendorSelfReferenceCQ {

        protected VendorSelfReferenceCIQ _inlineQuery;

        public BsVendorSelfReferenceCQ(ConditionQuery childQuery, SqlClause sqlClause, String aliasName, int nestLevel)
            : base(childQuery, sqlClause, aliasName, nestLevel) {}

        public VendorSelfReferenceCIQ Inline() {
            if (_inlineQuery == null) {
                _inlineQuery = new VendorSelfReferenceCIQ(xgetReferrerQuery(), xgetSqlClause(), xgetAliasName(), xgetNestLevel(), this);
            }
            _inlineQuery.xsetOnClause(false);
            return _inlineQuery;
        }
        
        public VendorSelfReferenceCIQ On() {
            if (isBaseQuery()) { throw new UnsupportedOperationException("Unsupported onClause of Base Table!"); }
            VendorSelfReferenceCIQ inlineQuery = Inline();
            inlineQuery.xsetOnClause(true);
            return inlineQuery;
        }


        protected ConditionValue _selfReferenceId;
        public ConditionValue SelfReferenceId {
            get { if (_selfReferenceId == null) { _selfReferenceId = new ConditionValue(); } return _selfReferenceId; }
        }
        protected override ConditionValue getCValueSelfReferenceId() { return this.SelfReferenceId; }


        protected Map<String, VendorSelfReferenceCQ> _selfReferenceId_ExistsSubQuery_VendorSelfReferenceSelfListMap;
        public Map<String, VendorSelfReferenceCQ> SelfReferenceId_ExistsSubQuery_VendorSelfReferenceSelfList { get { return _selfReferenceId_ExistsSubQuery_VendorSelfReferenceSelfListMap; }}
        public override String keepSelfReferenceId_ExistsSubQuery_VendorSelfReferenceSelfList(VendorSelfReferenceCQ subQuery) {
            if (_selfReferenceId_ExistsSubQuery_VendorSelfReferenceSelfListMap == null) { _selfReferenceId_ExistsSubQuery_VendorSelfReferenceSelfListMap = new LinkedHashMap<String, VendorSelfReferenceCQ>(); }
            String key = "subQueryMapKey" + (_selfReferenceId_ExistsSubQuery_VendorSelfReferenceSelfListMap.size() + 1);
            _selfReferenceId_ExistsSubQuery_VendorSelfReferenceSelfListMap.put(key, subQuery); return "SelfReferenceId_ExistsSubQuery_VendorSelfReferenceSelfList." + key;
        }

        protected Map<String, VendorSelfReferenceCQ> _selfReferenceId_NotExistsSubQuery_VendorSelfReferenceSelfListMap;
        public Map<String, VendorSelfReferenceCQ> SelfReferenceId_NotExistsSubQuery_VendorSelfReferenceSelfList { get { return _selfReferenceId_NotExistsSubQuery_VendorSelfReferenceSelfListMap; }}
        public override String keepSelfReferenceId_NotExistsSubQuery_VendorSelfReferenceSelfList(VendorSelfReferenceCQ subQuery) {
            if (_selfReferenceId_NotExistsSubQuery_VendorSelfReferenceSelfListMap == null) { _selfReferenceId_NotExistsSubQuery_VendorSelfReferenceSelfListMap = new LinkedHashMap<String, VendorSelfReferenceCQ>(); }
            String key = "subQueryMapKey" + (_selfReferenceId_NotExistsSubQuery_VendorSelfReferenceSelfListMap.size() + 1);
            _selfReferenceId_NotExistsSubQuery_VendorSelfReferenceSelfListMap.put(key, subQuery); return "SelfReferenceId_NotExistsSubQuery_VendorSelfReferenceSelfList." + key;
        }

        protected Map<String, VendorSelfReferenceCQ> _selfReferenceId_InScopeSubQuery_VendorSelfReferenceSelfListMap;
        public Map<String, VendorSelfReferenceCQ> SelfReferenceId_InScopeSubQuery_VendorSelfReferenceSelfList { get { return _selfReferenceId_InScopeSubQuery_VendorSelfReferenceSelfListMap; }}
        public override String keepSelfReferenceId_InScopeSubQuery_VendorSelfReferenceSelfList(VendorSelfReferenceCQ subQuery) {
            if (_selfReferenceId_InScopeSubQuery_VendorSelfReferenceSelfListMap == null) { _selfReferenceId_InScopeSubQuery_VendorSelfReferenceSelfListMap = new LinkedHashMap<String, VendorSelfReferenceCQ>(); }
            String key = "subQueryMapKey" + (_selfReferenceId_InScopeSubQuery_VendorSelfReferenceSelfListMap.size() + 1);
            _selfReferenceId_InScopeSubQuery_VendorSelfReferenceSelfListMap.put(key, subQuery); return "SelfReferenceId_InScopeSubQuery_VendorSelfReferenceSelfList." + key;
        }

        protected Map<String, VendorSelfReferenceCQ> _selfReferenceId_NotInScopeSubQuery_VendorSelfReferenceSelfListMap;
        public Map<String, VendorSelfReferenceCQ> SelfReferenceId_NotInScopeSubQuery_VendorSelfReferenceSelfList { get { return _selfReferenceId_NotInScopeSubQuery_VendorSelfReferenceSelfListMap; }}
        public override String keepSelfReferenceId_NotInScopeSubQuery_VendorSelfReferenceSelfList(VendorSelfReferenceCQ subQuery) {
            if (_selfReferenceId_NotInScopeSubQuery_VendorSelfReferenceSelfListMap == null) { _selfReferenceId_NotInScopeSubQuery_VendorSelfReferenceSelfListMap = new LinkedHashMap<String, VendorSelfReferenceCQ>(); }
            String key = "subQueryMapKey" + (_selfReferenceId_NotInScopeSubQuery_VendorSelfReferenceSelfListMap.size() + 1);
            _selfReferenceId_NotInScopeSubQuery_VendorSelfReferenceSelfListMap.put(key, subQuery); return "SelfReferenceId_NotInScopeSubQuery_VendorSelfReferenceSelfList." + key;
        }

        protected Map<String, VendorSelfReferenceCQ> _selfReferenceId_SpecifyDerivedReferrer_VendorSelfReferenceSelfListMap;
        public Map<String, VendorSelfReferenceCQ> SelfReferenceId_SpecifyDerivedReferrer_VendorSelfReferenceSelfList { get { return _selfReferenceId_SpecifyDerivedReferrer_VendorSelfReferenceSelfListMap; }}
        public override String keepSelfReferenceId_SpecifyDerivedReferrer_VendorSelfReferenceSelfList(VendorSelfReferenceCQ subQuery) {
            if (_selfReferenceId_SpecifyDerivedReferrer_VendorSelfReferenceSelfListMap == null) { _selfReferenceId_SpecifyDerivedReferrer_VendorSelfReferenceSelfListMap = new LinkedHashMap<String, VendorSelfReferenceCQ>(); }
            String key = "subQueryMapKey" + (_selfReferenceId_SpecifyDerivedReferrer_VendorSelfReferenceSelfListMap.size() + 1);
            _selfReferenceId_SpecifyDerivedReferrer_VendorSelfReferenceSelfListMap.put(key, subQuery); return "SelfReferenceId_SpecifyDerivedReferrer_VendorSelfReferenceSelfList." + key;
        }

        protected Map<String, VendorSelfReferenceCQ> _selfReferenceId_QueryDerivedReferrer_VendorSelfReferenceSelfListMap;
        public Map<String, VendorSelfReferenceCQ> SelfReferenceId_QueryDerivedReferrer_VendorSelfReferenceSelfList { get { return _selfReferenceId_QueryDerivedReferrer_VendorSelfReferenceSelfListMap; } }
        public override String keepSelfReferenceId_QueryDerivedReferrer_VendorSelfReferenceSelfList(VendorSelfReferenceCQ subQuery) {
            if (_selfReferenceId_QueryDerivedReferrer_VendorSelfReferenceSelfListMap == null) { _selfReferenceId_QueryDerivedReferrer_VendorSelfReferenceSelfListMap = new LinkedHashMap<String, VendorSelfReferenceCQ>(); }
            String key = "subQueryMapKey" + (_selfReferenceId_QueryDerivedReferrer_VendorSelfReferenceSelfListMap.size() + 1);
            _selfReferenceId_QueryDerivedReferrer_VendorSelfReferenceSelfListMap.put(key, subQuery); return "SelfReferenceId_QueryDerivedReferrer_VendorSelfReferenceSelfList." + key;
        }
        protected Map<String, Object> _selfReferenceId_QueryDerivedReferrer_VendorSelfReferenceSelfListParameterMap;
        public Map<String, Object> SelfReferenceId_QueryDerivedReferrer_VendorSelfReferenceSelfListParameter { get { return _selfReferenceId_QueryDerivedReferrer_VendorSelfReferenceSelfListParameterMap; } }
        public override String keepSelfReferenceId_QueryDerivedReferrer_VendorSelfReferenceSelfListParameter(Object parameterValue) {
            if (_selfReferenceId_QueryDerivedReferrer_VendorSelfReferenceSelfListParameterMap == null) { _selfReferenceId_QueryDerivedReferrer_VendorSelfReferenceSelfListParameterMap = new LinkedHashMap<String, Object>(); }
            String key = "subQueryParameterKey" + (_selfReferenceId_QueryDerivedReferrer_VendorSelfReferenceSelfListParameterMap.size() + 1);
            _selfReferenceId_QueryDerivedReferrer_VendorSelfReferenceSelfListParameterMap.put(key, parameterValue); return "SelfReferenceId_QueryDerivedReferrer_VendorSelfReferenceSelfListParameter." + key;
        }

        public BsVendorSelfReferenceCQ AddOrderBy_SelfReferenceId_Asc() { regOBA("SELF_REFERENCE_ID");return this; }
        public BsVendorSelfReferenceCQ AddOrderBy_SelfReferenceId_Desc() { regOBD("SELF_REFERENCE_ID");return this; }

        protected ConditionValue _selfReferenceName;
        public ConditionValue SelfReferenceName {
            get { if (_selfReferenceName == null) { _selfReferenceName = new ConditionValue(); } return _selfReferenceName; }
        }
        protected override ConditionValue getCValueSelfReferenceName() { return this.SelfReferenceName; }


        public BsVendorSelfReferenceCQ AddOrderBy_SelfReferenceName_Asc() { regOBA("SELF_REFERENCE_NAME");return this; }
        public BsVendorSelfReferenceCQ AddOrderBy_SelfReferenceName_Desc() { regOBD("SELF_REFERENCE_NAME");return this; }

        protected ConditionValue _parentId;
        public ConditionValue ParentId {
            get { if (_parentId == null) { _parentId = new ConditionValue(); } return _parentId; }
        }
        protected override ConditionValue getCValueParentId() { return this.ParentId; }


        protected Map<String, VendorSelfReferenceCQ> _parentId_InScopeSubQuery_VendorSelfReferenceSelfMap;
        public Map<String, VendorSelfReferenceCQ> ParentId_InScopeSubQuery_VendorSelfReferenceSelf { get { return _parentId_InScopeSubQuery_VendorSelfReferenceSelfMap; }}
        public override String keepParentId_InScopeSubQuery_VendorSelfReferenceSelf(VendorSelfReferenceCQ subQuery) {
            if (_parentId_InScopeSubQuery_VendorSelfReferenceSelfMap == null) { _parentId_InScopeSubQuery_VendorSelfReferenceSelfMap = new LinkedHashMap<String, VendorSelfReferenceCQ>(); }
            String key = "subQueryMapKey" + (_parentId_InScopeSubQuery_VendorSelfReferenceSelfMap.size() + 1);
            _parentId_InScopeSubQuery_VendorSelfReferenceSelfMap.put(key, subQuery); return "ParentId_InScopeSubQuery_VendorSelfReferenceSelf." + key;
        }

        protected Map<String, VendorSelfReferenceCQ> _parentId_NotInScopeSubQuery_VendorSelfReferenceSelfMap;
        public Map<String, VendorSelfReferenceCQ> ParentId_NotInScopeSubQuery_VendorSelfReferenceSelf { get { return _parentId_NotInScopeSubQuery_VendorSelfReferenceSelfMap; }}
        public override String keepParentId_NotInScopeSubQuery_VendorSelfReferenceSelf(VendorSelfReferenceCQ subQuery) {
            if (_parentId_NotInScopeSubQuery_VendorSelfReferenceSelfMap == null) { _parentId_NotInScopeSubQuery_VendorSelfReferenceSelfMap = new LinkedHashMap<String, VendorSelfReferenceCQ>(); }
            String key = "subQueryMapKey" + (_parentId_NotInScopeSubQuery_VendorSelfReferenceSelfMap.size() + 1);
            _parentId_NotInScopeSubQuery_VendorSelfReferenceSelfMap.put(key, subQuery); return "ParentId_NotInScopeSubQuery_VendorSelfReferenceSelf." + key;
        }

        public BsVendorSelfReferenceCQ AddOrderBy_ParentId_Asc() { regOBA("PARENT_ID");return this; }
        public BsVendorSelfReferenceCQ AddOrderBy_ParentId_Desc() { regOBD("PARENT_ID");return this; }

        public BsVendorSelfReferenceCQ AddSpecifiedDerivedOrderBy_Asc(String aliasName) { registerSpecifiedDerivedOrderBy_Asc(aliasName); return this; }
        public BsVendorSelfReferenceCQ AddSpecifiedDerivedOrderBy_Desc(String aliasName) { registerSpecifiedDerivedOrderBy_Desc(aliasName); return this; }

        public override void reflectRelationOnUnionQuery(ConditionQuery baseQueryAsSuper, ConditionQuery unionQueryAsSuper) {
            VendorSelfReferenceCQ baseQuery = (VendorSelfReferenceCQ)baseQueryAsSuper;
            VendorSelfReferenceCQ unionQuery = (VendorSelfReferenceCQ)unionQueryAsSuper;
            if (baseQuery.hasConditionQueryVendorSelfReferenceSelf()) {
                unionQuery.QueryVendorSelfReferenceSelf().reflectRelationOnUnionQuery(baseQuery.QueryVendorSelfReferenceSelf(), unionQuery.QueryVendorSelfReferenceSelf());
            }

        }
    
        protected VendorSelfReferenceCQ _conditionQueryVendorSelfReferenceSelf;
        public VendorSelfReferenceCQ QueryVendorSelfReferenceSelf() {
            return this.ConditionQueryVendorSelfReferenceSelf;
        }
        public VendorSelfReferenceCQ ConditionQueryVendorSelfReferenceSelf {
            get {
                if (_conditionQueryVendorSelfReferenceSelf == null) {
                    _conditionQueryVendorSelfReferenceSelf = xcreateQueryVendorSelfReferenceSelf();
                    xsetupOuterJoin_VendorSelfReferenceSelf();
                }
                return _conditionQueryVendorSelfReferenceSelf;
            }
        }
        protected VendorSelfReferenceCQ xcreateQueryVendorSelfReferenceSelf() {
            String nrp = resolveNextRelationPathVendorSelfReferenceSelf();
            String jan = resolveJoinAliasName(nrp, xgetNextNestLevel());
            VendorSelfReferenceCQ cq = new VendorSelfReferenceCQ(this, xgetSqlClause(), jan, xgetNextNestLevel());
            cq.xsetForeignPropertyName("vendorSelfReferenceSelf"); cq.xsetRelationPath(nrp); return cq;
        }
        public void xsetupOuterJoin_VendorSelfReferenceSelf() {
            VendorSelfReferenceCQ cq = ConditionQueryVendorSelfReferenceSelf;
            Map<String, String> joinOnMap = new LinkedHashMap<String, String>();
            joinOnMap.put("PARENT_ID", "SELF_REFERENCE_ID");
            registerOuterJoin(cq, joinOnMap);
        }
        protected String resolveNextRelationPathVendorSelfReferenceSelf() {
            return resolveNextRelationPath("vendor_self_reference", "vendorSelfReferenceSelf");
        }
        public bool hasConditionQueryVendorSelfReferenceSelf() {
            return _conditionQueryVendorSelfReferenceSelf != null;
        }


	    // ===============================================================================
	    //                                                                 Scalar SubQuery
	    //                                                                 ===============
	    protected Map<String, VendorSelfReferenceCQ> _scalarSubQueryMap;
	    public Map<String, VendorSelfReferenceCQ> ScalarSubQuery { get { return _scalarSubQueryMap; } }
	    public override String keepScalarSubQuery(VendorSelfReferenceCQ subQuery) {
	        if (_scalarSubQueryMap == null) { _scalarSubQueryMap = new LinkedHashMap<String, VendorSelfReferenceCQ>(); }
	        String key = "subQueryMapKey" + (_scalarSubQueryMap.size() + 1);
	        _scalarSubQueryMap.put(key, subQuery); return "ScalarSubQuery." + key;
	    }

        // ===============================================================================
        //                                                         Myself InScope SubQuery
        //                                                         =======================
        protected Map<String, VendorSelfReferenceCQ> _myselfInScopeSubQueryMap;
        public Map<String, VendorSelfReferenceCQ> MyselfInScopeSubQuery { get { return _myselfInScopeSubQueryMap; } }
        public override String keepMyselfInScopeSubQuery(VendorSelfReferenceCQ subQuery) {
            if (_myselfInScopeSubQueryMap == null) { _myselfInScopeSubQueryMap = new LinkedHashMap<String, VendorSelfReferenceCQ>(); }
            String key = "subQueryMapKey" + (_myselfInScopeSubQueryMap.size() + 1);
            _myselfInScopeSubQueryMap.put(key, subQuery); return "MyselfInScopeSubQuery." + key;
        }
    }
}
