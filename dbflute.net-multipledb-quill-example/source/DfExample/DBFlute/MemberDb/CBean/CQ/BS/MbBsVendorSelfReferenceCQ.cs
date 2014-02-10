
using System;

using DfExample.DBFlute.MemberDb.AllCommon.CBean;
using DfExample.DBFlute.MemberDb.AllCommon.CBean.CValue;
using DfExample.DBFlute.MemberDb.AllCommon.CBean.SClause;
using DfExample.DBFlute.MemberDb.AllCommon.JavaLike;
using DfExample.DBFlute.MemberDb.CBean.CQ;
using DfExample.DBFlute.MemberDb.CBean.CQ.Ciq;

namespace DfExample.DBFlute.MemberDb.CBean.CQ.BS {

    [System.Serializable]
    public class MbBsVendorSelfReferenceCQ : MbAbstractBsVendorSelfReferenceCQ {

        protected MbVendorSelfReferenceCIQ _inlineQuery;

        public MbBsVendorSelfReferenceCQ(MbConditionQuery childQuery, MbSqlClause sqlClause, String aliasName, int nestLevel)
            : base(childQuery, sqlClause, aliasName, nestLevel) {}

        public MbVendorSelfReferenceCIQ Inline() {
            if (_inlineQuery == null) {
                _inlineQuery = new MbVendorSelfReferenceCIQ(xgetReferrerQuery(), xgetSqlClause(), xgetAliasName(), xgetNestLevel(), this);
            }
            _inlineQuery.xsetOnClause(false);
            return _inlineQuery;
        }
        
        public MbVendorSelfReferenceCIQ On() {
            if (isBaseQuery()) { throw new UnsupportedOperationException("Unsupported onClause of Base Table!"); }
            MbVendorSelfReferenceCIQ inlineQuery = Inline();
            inlineQuery.xsetOnClause(true);
            return inlineQuery;
        }


        protected MbConditionValue _selfReferenceId;
        public MbConditionValue SelfReferenceId {
            get { if (_selfReferenceId == null) { _selfReferenceId = new MbConditionValue(); } return _selfReferenceId; }
        }
        protected override MbConditionValue getCValueSelfReferenceId() { return this.SelfReferenceId; }


        protected Map<String, MbVendorSelfReferenceCQ> _selfReferenceId_ExistsSubQuery_VendorSelfReferenceSelfListMap;
        public Map<String, MbVendorSelfReferenceCQ> SelfReferenceId_ExistsSubQuery_VendorSelfReferenceSelfList { get { return _selfReferenceId_ExistsSubQuery_VendorSelfReferenceSelfListMap; }}
        public override String keepSelfReferenceId_ExistsSubQuery_VendorSelfReferenceSelfList(MbVendorSelfReferenceCQ subQuery) {
            if (_selfReferenceId_ExistsSubQuery_VendorSelfReferenceSelfListMap == null) { _selfReferenceId_ExistsSubQuery_VendorSelfReferenceSelfListMap = new LinkedHashMap<String, MbVendorSelfReferenceCQ>(); }
            String key = "subQueryMapKey" + (_selfReferenceId_ExistsSubQuery_VendorSelfReferenceSelfListMap.size() + 1);
            _selfReferenceId_ExistsSubQuery_VendorSelfReferenceSelfListMap.put(key, subQuery); return "SelfReferenceId_ExistsSubQuery_VendorSelfReferenceSelfList." + key;
        }

        protected Map<String, MbVendorSelfReferenceCQ> _selfReferenceId_NotExistsSubQuery_VendorSelfReferenceSelfListMap;
        public Map<String, MbVendorSelfReferenceCQ> SelfReferenceId_NotExistsSubQuery_VendorSelfReferenceSelfList { get { return _selfReferenceId_NotExistsSubQuery_VendorSelfReferenceSelfListMap; }}
        public override String keepSelfReferenceId_NotExistsSubQuery_VendorSelfReferenceSelfList(MbVendorSelfReferenceCQ subQuery) {
            if (_selfReferenceId_NotExistsSubQuery_VendorSelfReferenceSelfListMap == null) { _selfReferenceId_NotExistsSubQuery_VendorSelfReferenceSelfListMap = new LinkedHashMap<String, MbVendorSelfReferenceCQ>(); }
            String key = "subQueryMapKey" + (_selfReferenceId_NotExistsSubQuery_VendorSelfReferenceSelfListMap.size() + 1);
            _selfReferenceId_NotExistsSubQuery_VendorSelfReferenceSelfListMap.put(key, subQuery); return "SelfReferenceId_NotExistsSubQuery_VendorSelfReferenceSelfList." + key;
        }

        protected Map<String, MbVendorSelfReferenceCQ> _selfReferenceId_InScopeSubQuery_VendorSelfReferenceSelfListMap;
        public Map<String, MbVendorSelfReferenceCQ> SelfReferenceId_InScopeSubQuery_VendorSelfReferenceSelfList { get { return _selfReferenceId_InScopeSubQuery_VendorSelfReferenceSelfListMap; }}
        public override String keepSelfReferenceId_InScopeSubQuery_VendorSelfReferenceSelfList(MbVendorSelfReferenceCQ subQuery) {
            if (_selfReferenceId_InScopeSubQuery_VendorSelfReferenceSelfListMap == null) { _selfReferenceId_InScopeSubQuery_VendorSelfReferenceSelfListMap = new LinkedHashMap<String, MbVendorSelfReferenceCQ>(); }
            String key = "subQueryMapKey" + (_selfReferenceId_InScopeSubQuery_VendorSelfReferenceSelfListMap.size() + 1);
            _selfReferenceId_InScopeSubQuery_VendorSelfReferenceSelfListMap.put(key, subQuery); return "SelfReferenceId_InScopeSubQuery_VendorSelfReferenceSelfList." + key;
        }

        protected Map<String, MbVendorSelfReferenceCQ> _selfReferenceId_NotInScopeSubQuery_VendorSelfReferenceSelfListMap;
        public Map<String, MbVendorSelfReferenceCQ> SelfReferenceId_NotInScopeSubQuery_VendorSelfReferenceSelfList { get { return _selfReferenceId_NotInScopeSubQuery_VendorSelfReferenceSelfListMap; }}
        public override String keepSelfReferenceId_NotInScopeSubQuery_VendorSelfReferenceSelfList(MbVendorSelfReferenceCQ subQuery) {
            if (_selfReferenceId_NotInScopeSubQuery_VendorSelfReferenceSelfListMap == null) { _selfReferenceId_NotInScopeSubQuery_VendorSelfReferenceSelfListMap = new LinkedHashMap<String, MbVendorSelfReferenceCQ>(); }
            String key = "subQueryMapKey" + (_selfReferenceId_NotInScopeSubQuery_VendorSelfReferenceSelfListMap.size() + 1);
            _selfReferenceId_NotInScopeSubQuery_VendorSelfReferenceSelfListMap.put(key, subQuery); return "SelfReferenceId_NotInScopeSubQuery_VendorSelfReferenceSelfList." + key;
        }

        protected Map<String, MbVendorSelfReferenceCQ> _selfReferenceId_SpecifyDerivedReferrer_VendorSelfReferenceSelfListMap;
        public Map<String, MbVendorSelfReferenceCQ> SelfReferenceId_SpecifyDerivedReferrer_VendorSelfReferenceSelfList { get { return _selfReferenceId_SpecifyDerivedReferrer_VendorSelfReferenceSelfListMap; }}
        public override String keepSelfReferenceId_SpecifyDerivedReferrer_VendorSelfReferenceSelfList(MbVendorSelfReferenceCQ subQuery) {
            if (_selfReferenceId_SpecifyDerivedReferrer_VendorSelfReferenceSelfListMap == null) { _selfReferenceId_SpecifyDerivedReferrer_VendorSelfReferenceSelfListMap = new LinkedHashMap<String, MbVendorSelfReferenceCQ>(); }
            String key = "subQueryMapKey" + (_selfReferenceId_SpecifyDerivedReferrer_VendorSelfReferenceSelfListMap.size() + 1);
            _selfReferenceId_SpecifyDerivedReferrer_VendorSelfReferenceSelfListMap.put(key, subQuery); return "SelfReferenceId_SpecifyDerivedReferrer_VendorSelfReferenceSelfList." + key;
        }

        protected Map<String, MbVendorSelfReferenceCQ> _selfReferenceId_QueryDerivedReferrer_VendorSelfReferenceSelfListMap;
        public Map<String, MbVendorSelfReferenceCQ> SelfReferenceId_QueryDerivedReferrer_VendorSelfReferenceSelfList { get { return _selfReferenceId_QueryDerivedReferrer_VendorSelfReferenceSelfListMap; } }
        public override String keepSelfReferenceId_QueryDerivedReferrer_VendorSelfReferenceSelfList(MbVendorSelfReferenceCQ subQuery) {
            if (_selfReferenceId_QueryDerivedReferrer_VendorSelfReferenceSelfListMap == null) { _selfReferenceId_QueryDerivedReferrer_VendorSelfReferenceSelfListMap = new LinkedHashMap<String, MbVendorSelfReferenceCQ>(); }
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

        public MbBsVendorSelfReferenceCQ AddOrderBy_SelfReferenceId_Asc() { regOBA("SELF_REFERENCE_ID");return this; }
        public MbBsVendorSelfReferenceCQ AddOrderBy_SelfReferenceId_Desc() { regOBD("SELF_REFERENCE_ID");return this; }

        protected MbConditionValue _selfReferenceName;
        public MbConditionValue SelfReferenceName {
            get { if (_selfReferenceName == null) { _selfReferenceName = new MbConditionValue(); } return _selfReferenceName; }
        }
        protected override MbConditionValue getCValueSelfReferenceName() { return this.SelfReferenceName; }


        public MbBsVendorSelfReferenceCQ AddOrderBy_SelfReferenceName_Asc() { regOBA("SELF_REFERENCE_NAME");return this; }
        public MbBsVendorSelfReferenceCQ AddOrderBy_SelfReferenceName_Desc() { regOBD("SELF_REFERENCE_NAME");return this; }

        protected MbConditionValue _parentId;
        public MbConditionValue ParentId {
            get { if (_parentId == null) { _parentId = new MbConditionValue(); } return _parentId; }
        }
        protected override MbConditionValue getCValueParentId() { return this.ParentId; }


        protected Map<String, MbVendorSelfReferenceCQ> _parentId_InScopeSubQuery_VendorSelfReferenceSelfMap;
        public Map<String, MbVendorSelfReferenceCQ> ParentId_InScopeSubQuery_VendorSelfReferenceSelf { get { return _parentId_InScopeSubQuery_VendorSelfReferenceSelfMap; }}
        public override String keepParentId_InScopeSubQuery_VendorSelfReferenceSelf(MbVendorSelfReferenceCQ subQuery) {
            if (_parentId_InScopeSubQuery_VendorSelfReferenceSelfMap == null) { _parentId_InScopeSubQuery_VendorSelfReferenceSelfMap = new LinkedHashMap<String, MbVendorSelfReferenceCQ>(); }
            String key = "subQueryMapKey" + (_parentId_InScopeSubQuery_VendorSelfReferenceSelfMap.size() + 1);
            _parentId_InScopeSubQuery_VendorSelfReferenceSelfMap.put(key, subQuery); return "ParentId_InScopeSubQuery_VendorSelfReferenceSelf." + key;
        }

        protected Map<String, MbVendorSelfReferenceCQ> _parentId_NotInScopeSubQuery_VendorSelfReferenceSelfMap;
        public Map<String, MbVendorSelfReferenceCQ> ParentId_NotInScopeSubQuery_VendorSelfReferenceSelf { get { return _parentId_NotInScopeSubQuery_VendorSelfReferenceSelfMap; }}
        public override String keepParentId_NotInScopeSubQuery_VendorSelfReferenceSelf(MbVendorSelfReferenceCQ subQuery) {
            if (_parentId_NotInScopeSubQuery_VendorSelfReferenceSelfMap == null) { _parentId_NotInScopeSubQuery_VendorSelfReferenceSelfMap = new LinkedHashMap<String, MbVendorSelfReferenceCQ>(); }
            String key = "subQueryMapKey" + (_parentId_NotInScopeSubQuery_VendorSelfReferenceSelfMap.size() + 1);
            _parentId_NotInScopeSubQuery_VendorSelfReferenceSelfMap.put(key, subQuery); return "ParentId_NotInScopeSubQuery_VendorSelfReferenceSelf." + key;
        }

        public MbBsVendorSelfReferenceCQ AddOrderBy_ParentId_Asc() { regOBA("PARENT_ID");return this; }
        public MbBsVendorSelfReferenceCQ AddOrderBy_ParentId_Desc() { regOBD("PARENT_ID");return this; }

        public MbBsVendorSelfReferenceCQ AddSpecifiedDerivedOrderBy_Asc(String aliasName) { registerSpecifiedDerivedOrderBy_Asc(aliasName); return this; }
        public MbBsVendorSelfReferenceCQ AddSpecifiedDerivedOrderBy_Desc(String aliasName) { registerSpecifiedDerivedOrderBy_Desc(aliasName); return this; }

        public override void reflectRelationOnUnionQuery(MbConditionQuery baseQueryAsSuper, MbConditionQuery unionQueryAsSuper) {
            MbVendorSelfReferenceCQ baseQuery = (MbVendorSelfReferenceCQ)baseQueryAsSuper;
            MbVendorSelfReferenceCQ unionQuery = (MbVendorSelfReferenceCQ)unionQueryAsSuper;
            if (baseQuery.hasConditionQueryVendorSelfReferenceSelf()) {
                unionQuery.QueryVendorSelfReferenceSelf().reflectRelationOnUnionQuery(baseQuery.QueryVendorSelfReferenceSelf(), unionQuery.QueryVendorSelfReferenceSelf());
            }

        }
    
        protected MbVendorSelfReferenceCQ _conditionQueryVendorSelfReferenceSelf;
        public MbVendorSelfReferenceCQ QueryVendorSelfReferenceSelf() {
            return this.ConditionQueryVendorSelfReferenceSelf;
        }
        public MbVendorSelfReferenceCQ ConditionQueryVendorSelfReferenceSelf {
            get {
                if (_conditionQueryVendorSelfReferenceSelf == null) {
                    _conditionQueryVendorSelfReferenceSelf = xcreateQueryVendorSelfReferenceSelf();
                    xsetupOuterJoin_VendorSelfReferenceSelf();
                }
                return _conditionQueryVendorSelfReferenceSelf;
            }
        }
        protected MbVendorSelfReferenceCQ xcreateQueryVendorSelfReferenceSelf() {
            String nrp = resolveNextRelationPathVendorSelfReferenceSelf();
            String jan = resolveJoinAliasName(nrp, xgetNextNestLevel());
            MbVendorSelfReferenceCQ cq = new MbVendorSelfReferenceCQ(this, xgetSqlClause(), jan, xgetNextNestLevel());
            cq.xsetForeignPropertyName("vendorSelfReferenceSelf"); cq.xsetRelationPath(nrp); return cq;
        }
        public void xsetupOuterJoin_VendorSelfReferenceSelf() {
            MbVendorSelfReferenceCQ cq = ConditionQueryVendorSelfReferenceSelf;
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
	    protected Map<String, MbVendorSelfReferenceCQ> _scalarSubQueryMap;
	    public Map<String, MbVendorSelfReferenceCQ> ScalarSubQuery { get { return _scalarSubQueryMap; } }
	    public override String keepScalarSubQuery(MbVendorSelfReferenceCQ subQuery) {
	        if (_scalarSubQueryMap == null) { _scalarSubQueryMap = new LinkedHashMap<String, MbVendorSelfReferenceCQ>(); }
	        String key = "subQueryMapKey" + (_scalarSubQueryMap.size() + 1);
	        _scalarSubQueryMap.put(key, subQuery); return "ScalarSubQuery." + key;
	    }

        // ===============================================================================
        //                                                         Myself InScope SubQuery
        //                                                         =======================
        protected Map<String, MbVendorSelfReferenceCQ> _myselfInScopeSubQueryMap;
        public Map<String, MbVendorSelfReferenceCQ> MyselfInScopeSubQuery { get { return _myselfInScopeSubQueryMap; } }
        public override String keepMyselfInScopeSubQuery(MbVendorSelfReferenceCQ subQuery) {
            if (_myselfInScopeSubQueryMap == null) { _myselfInScopeSubQueryMap = new LinkedHashMap<String, MbVendorSelfReferenceCQ>(); }
            String key = "subQueryMapKey" + (_myselfInScopeSubQueryMap.size() + 1);
            _myselfInScopeSubQueryMap.put(key, subQuery); return "MyselfInScopeSubQuery." + key;
        }
    }
}
