
using System;

using DfExample.DBFlute.AllCommon.CBean;
using DfExample.DBFlute.AllCommon.CBean.CValue;
using DfExample.DBFlute.AllCommon.CBean.SClause;
using DfExample.DBFlute.AllCommon.JavaLike;
using DfExample.DBFlute.CBean.CQ;
using DfExample.DBFlute.CBean.CQ.Ciq;

namespace DfExample.DBFlute.CBean.CQ.BS {

    [System.Serializable]
    public class BsVendorRefTargetCQ : AbstractBsVendorRefTargetCQ {

        protected VendorRefTargetCIQ _inlineQuery;

        public BsVendorRefTargetCQ(ConditionQuery childQuery, SqlClause sqlClause, String aliasName, int nestLevel)
            : base(childQuery, sqlClause, aliasName, nestLevel) {}

        public VendorRefTargetCIQ Inline() {
            if (_inlineQuery == null) {
                _inlineQuery = new VendorRefTargetCIQ(xgetReferrerQuery(), xgetSqlClause(), xgetAliasName(), xgetNestLevel(), this);
            }
            _inlineQuery.xsetOnClause(false);
            return _inlineQuery;
        }
        
        public VendorRefTargetCIQ On() {
            if (isBaseQuery()) { throw new UnsupportedOperationException("Unsupported onClause of Base Table!"); }
            VendorRefTargetCIQ inlineQuery = Inline();
            inlineQuery.xsetOnClause(true);
            return inlineQuery;
        }


        protected ConditionValue _vendorRefTargetId;
        public ConditionValue VendorRefTargetId {
            get { if (_vendorRefTargetId == null) { _vendorRefTargetId = new ConditionValue(); } return _vendorRefTargetId; }
        }
        protected override ConditionValue getCValueVendorRefTargetId() { return this.VendorRefTargetId; }


        public BsVendorRefTargetCQ AddOrderBy_VendorRefTargetId_Asc() { regOBA("VENDOR_REF_TARGET_ID");return this; }
        public BsVendorRefTargetCQ AddOrderBy_VendorRefTargetId_Desc() { regOBD("VENDOR_REF_TARGET_ID");return this; }

        protected ConditionValue _vendorTargetId;
        public ConditionValue VendorTargetId {
            get { if (_vendorTargetId == null) { _vendorTargetId = new ConditionValue(); } return _vendorTargetId; }
        }
        protected override ConditionValue getCValueVendorTargetId() { return this.VendorTargetId; }


        protected Map<String, VendorTargetCQ> _vendorTargetId_InScopeSubQuery_VendorTargetMap;
        public Map<String, VendorTargetCQ> VendorTargetId_InScopeSubQuery_VendorTarget { get { return _vendorTargetId_InScopeSubQuery_VendorTargetMap; }}
        public override String keepVendorTargetId_InScopeSubQuery_VendorTarget(VendorTargetCQ subQuery) {
            if (_vendorTargetId_InScopeSubQuery_VendorTargetMap == null) { _vendorTargetId_InScopeSubQuery_VendorTargetMap = new LinkedHashMap<String, VendorTargetCQ>(); }
            String key = "subQueryMapKey" + (_vendorTargetId_InScopeSubQuery_VendorTargetMap.size() + 1);
            _vendorTargetId_InScopeSubQuery_VendorTargetMap.put(key, subQuery); return "VendorTargetId_InScopeSubQuery_VendorTarget." + key;
        }

        protected Map<String, VendorTargetCQ> _vendorTargetId_NotInScopeSubQuery_VendorTargetMap;
        public Map<String, VendorTargetCQ> VendorTargetId_NotInScopeSubQuery_VendorTarget { get { return _vendorTargetId_NotInScopeSubQuery_VendorTargetMap; }}
        public override String keepVendorTargetId_NotInScopeSubQuery_VendorTarget(VendorTargetCQ subQuery) {
            if (_vendorTargetId_NotInScopeSubQuery_VendorTargetMap == null) { _vendorTargetId_NotInScopeSubQuery_VendorTargetMap = new LinkedHashMap<String, VendorTargetCQ>(); }
            String key = "subQueryMapKey" + (_vendorTargetId_NotInScopeSubQuery_VendorTargetMap.size() + 1);
            _vendorTargetId_NotInScopeSubQuery_VendorTargetMap.put(key, subQuery); return "VendorTargetId_NotInScopeSubQuery_VendorTarget." + key;
        }

        public BsVendorRefTargetCQ AddOrderBy_VendorTargetId_Asc() { regOBA("VENDOR_TARGET_ID");return this; }
        public BsVendorRefTargetCQ AddOrderBy_VendorTargetId_Desc() { regOBD("VENDOR_TARGET_ID");return this; }

        public BsVendorRefTargetCQ AddSpecifiedDerivedOrderBy_Asc(String aliasName) { registerSpecifiedDerivedOrderBy_Asc(aliasName); return this; }
        public BsVendorRefTargetCQ AddSpecifiedDerivedOrderBy_Desc(String aliasName) { registerSpecifiedDerivedOrderBy_Desc(aliasName); return this; }

        public override void reflectRelationOnUnionQuery(ConditionQuery baseQueryAsSuper, ConditionQuery unionQueryAsSuper) {
            VendorRefTargetCQ baseQuery = (VendorRefTargetCQ)baseQueryAsSuper;
            VendorRefTargetCQ unionQuery = (VendorRefTargetCQ)unionQueryAsSuper;
            if (baseQuery.hasConditionQueryVendorTarget()) {
                unionQuery.QueryVendorTarget().reflectRelationOnUnionQuery(baseQuery.QueryVendorTarget(), unionQuery.QueryVendorTarget());
            }

        }
    
        protected VendorTargetCQ _conditionQueryVendorTarget;
        public VendorTargetCQ QueryVendorTarget() {
            return this.ConditionQueryVendorTarget;
        }
        public VendorTargetCQ ConditionQueryVendorTarget {
            get {
                if (_conditionQueryVendorTarget == null) {
                    _conditionQueryVendorTarget = xcreateQueryVendorTarget();
                    xsetupOuterJoin_VendorTarget();
                }
                return _conditionQueryVendorTarget;
            }
        }
        protected VendorTargetCQ xcreateQueryVendorTarget() {
            String nrp = resolveNextRelationPathVendorTarget();
            String jan = resolveJoinAliasName(nrp, xgetNextNestLevel());
            VendorTargetCQ cq = new VendorTargetCQ(this, xgetSqlClause(), jan, xgetNextNestLevel());
            cq.xsetForeignPropertyName("vendorTarget"); cq.xsetRelationPath(nrp); return cq;
        }
        public void xsetupOuterJoin_VendorTarget() {
            VendorTargetCQ cq = ConditionQueryVendorTarget;
            Map<String, String> joinOnMap = new LinkedHashMap<String, String>();
            joinOnMap.put("VENDOR_TARGET_ID", "VENDOR_TARGET_ID");
            registerOuterJoin(cq, joinOnMap);
        }
        protected String resolveNextRelationPathVendorTarget() {
            return resolveNextRelationPath("VENDOR_REF_TARGET", "vendorTarget");
        }
        public bool hasConditionQueryVendorTarget() {
            return _conditionQueryVendorTarget != null;
        }


	    // ===============================================================================
	    //                                                                 Scalar SubQuery
	    //                                                                 ===============
	    protected Map<String, VendorRefTargetCQ> _scalarSubQueryMap;
	    public Map<String, VendorRefTargetCQ> ScalarSubQuery { get { return _scalarSubQueryMap; } }
	    public override String keepScalarSubQuery(VendorRefTargetCQ subQuery) {
	        if (_scalarSubQueryMap == null) { _scalarSubQueryMap = new LinkedHashMap<String, VendorRefTargetCQ>(); }
	        String key = "subQueryMapKey" + (_scalarSubQueryMap.size() + 1);
	        _scalarSubQueryMap.put(key, subQuery); return "ScalarSubQuery." + key;
	    }

        // ===============================================================================
        //                                                         Myself InScope SubQuery
        //                                                         =======================
        protected Map<String, VendorRefTargetCQ> _myselfInScopeSubQueryMap;
        public Map<String, VendorRefTargetCQ> MyselfInScopeSubQuery { get { return _myselfInScopeSubQueryMap; } }
        public override String keepMyselfInScopeSubQuery(VendorRefTargetCQ subQuery) {
            if (_myselfInScopeSubQueryMap == null) { _myselfInScopeSubQueryMap = new LinkedHashMap<String, VendorRefTargetCQ>(); }
            String key = "subQueryMapKey" + (_myselfInScopeSubQueryMap.size() + 1);
            _myselfInScopeSubQueryMap.put(key, subQuery); return "MyselfInScopeSubQuery." + key;
        }
    }
}
