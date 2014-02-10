
using System;

using DfExample.DBFlute.AllCommon.CBean;
using DfExample.DBFlute.AllCommon.CBean.CValue;
using DfExample.DBFlute.AllCommon.CBean.SClause;
using DfExample.DBFlute.AllCommon.JavaLike;
using DfExample.DBFlute.CBean.CQ;
using DfExample.DBFlute.CBean.CQ.Ciq;

namespace DfExample.DBFlute.CBean.CQ.BS {

    [System.Serializable]
    public class BsVdSynonymVendorRefTargetCQ : AbstractBsVdSynonymVendorRefTargetCQ {

        protected VdSynonymVendorRefTargetCIQ _inlineQuery;

        public BsVdSynonymVendorRefTargetCQ(ConditionQuery childQuery, SqlClause sqlClause, String aliasName, int nestLevel)
            : base(childQuery, sqlClause, aliasName, nestLevel) {}

        public VdSynonymVendorRefTargetCIQ Inline() {
            if (_inlineQuery == null) {
                _inlineQuery = new VdSynonymVendorRefTargetCIQ(xgetReferrerQuery(), xgetSqlClause(), xgetAliasName(), xgetNestLevel(), this);
            }
            _inlineQuery.xsetOnClause(false);
            return _inlineQuery;
        }
        
        public VdSynonymVendorRefTargetCIQ On() {
            if (isBaseQuery()) { throw new UnsupportedOperationException("Unsupported onClause of Base Table!"); }
            VdSynonymVendorRefTargetCIQ inlineQuery = Inline();
            inlineQuery.xsetOnClause(true);
            return inlineQuery;
        }


        protected ConditionValue _vendorRefTargetId;
        public ConditionValue VendorRefTargetId {
            get { if (_vendorRefTargetId == null) { _vendorRefTargetId = new ConditionValue(); } return _vendorRefTargetId; }
        }
        protected override ConditionValue getCValueVendorRefTargetId() { return this.VendorRefTargetId; }


        public BsVdSynonymVendorRefTargetCQ AddOrderBy_VendorRefTargetId_Asc() { regOBA("VENDOR_REF_TARGET_ID");return this; }
        public BsVdSynonymVendorRefTargetCQ AddOrderBy_VendorRefTargetId_Desc() { regOBD("VENDOR_REF_TARGET_ID");return this; }

        protected ConditionValue _vendorTargetId;
        public ConditionValue VendorTargetId {
            get { if (_vendorTargetId == null) { _vendorTargetId = new ConditionValue(); } return _vendorTargetId; }
        }
        protected override ConditionValue getCValueVendorTargetId() { return this.VendorTargetId; }


        protected Map<String, VdSynonymVendorTargetCQ> _vendorTargetId_InScopeSubQuery_VdSynonymVendorTargetMap;
        public Map<String, VdSynonymVendorTargetCQ> VendorTargetId_InScopeSubQuery_VdSynonymVendorTarget { get { return _vendorTargetId_InScopeSubQuery_VdSynonymVendorTargetMap; }}
        public override String keepVendorTargetId_InScopeSubQuery_VdSynonymVendorTarget(VdSynonymVendorTargetCQ subQuery) {
            if (_vendorTargetId_InScopeSubQuery_VdSynonymVendorTargetMap == null) { _vendorTargetId_InScopeSubQuery_VdSynonymVendorTargetMap = new LinkedHashMap<String, VdSynonymVendorTargetCQ>(); }
            String key = "subQueryMapKey" + (_vendorTargetId_InScopeSubQuery_VdSynonymVendorTargetMap.size() + 1);
            _vendorTargetId_InScopeSubQuery_VdSynonymVendorTargetMap.put(key, subQuery); return "VendorTargetId_InScopeSubQuery_VdSynonymVendorTarget." + key;
        }

        protected Map<String, VdSynonymVendorTargetCQ> _vendorTargetId_NotInScopeSubQuery_VdSynonymVendorTargetMap;
        public Map<String, VdSynonymVendorTargetCQ> VendorTargetId_NotInScopeSubQuery_VdSynonymVendorTarget { get { return _vendorTargetId_NotInScopeSubQuery_VdSynonymVendorTargetMap; }}
        public override String keepVendorTargetId_NotInScopeSubQuery_VdSynonymVendorTarget(VdSynonymVendorTargetCQ subQuery) {
            if (_vendorTargetId_NotInScopeSubQuery_VdSynonymVendorTargetMap == null) { _vendorTargetId_NotInScopeSubQuery_VdSynonymVendorTargetMap = new LinkedHashMap<String, VdSynonymVendorTargetCQ>(); }
            String key = "subQueryMapKey" + (_vendorTargetId_NotInScopeSubQuery_VdSynonymVendorTargetMap.size() + 1);
            _vendorTargetId_NotInScopeSubQuery_VdSynonymVendorTargetMap.put(key, subQuery); return "VendorTargetId_NotInScopeSubQuery_VdSynonymVendorTarget." + key;
        }

        public BsVdSynonymVendorRefTargetCQ AddOrderBy_VendorTargetId_Asc() { regOBA("VENDOR_TARGET_ID");return this; }
        public BsVdSynonymVendorRefTargetCQ AddOrderBy_VendorTargetId_Desc() { regOBD("VENDOR_TARGET_ID");return this; }

        public BsVdSynonymVendorRefTargetCQ AddSpecifiedDerivedOrderBy_Asc(String aliasName) { registerSpecifiedDerivedOrderBy_Asc(aliasName); return this; }
        public BsVdSynonymVendorRefTargetCQ AddSpecifiedDerivedOrderBy_Desc(String aliasName) { registerSpecifiedDerivedOrderBy_Desc(aliasName); return this; }

        public override void reflectRelationOnUnionQuery(ConditionQuery baseQueryAsSuper, ConditionQuery unionQueryAsSuper) {
            VdSynonymVendorRefTargetCQ baseQuery = (VdSynonymVendorRefTargetCQ)baseQueryAsSuper;
            VdSynonymVendorRefTargetCQ unionQuery = (VdSynonymVendorRefTargetCQ)unionQueryAsSuper;
            if (baseQuery.hasConditionQueryVdSynonymVendorTarget()) {
                unionQuery.QueryVdSynonymVendorTarget().reflectRelationOnUnionQuery(baseQuery.QueryVdSynonymVendorTarget(), unionQuery.QueryVdSynonymVendorTarget());
            }

        }
    
        protected VdSynonymVendorTargetCQ _conditionQueryVdSynonymVendorTarget;
        public VdSynonymVendorTargetCQ QueryVdSynonymVendorTarget() {
            return this.ConditionQueryVdSynonymVendorTarget;
        }
        public VdSynonymVendorTargetCQ ConditionQueryVdSynonymVendorTarget {
            get {
                if (_conditionQueryVdSynonymVendorTarget == null) {
                    _conditionQueryVdSynonymVendorTarget = xcreateQueryVdSynonymVendorTarget();
                    xsetupOuterJoin_VdSynonymVendorTarget();
                }
                return _conditionQueryVdSynonymVendorTarget;
            }
        }
        protected VdSynonymVendorTargetCQ xcreateQueryVdSynonymVendorTarget() {
            String nrp = resolveNextRelationPathVdSynonymVendorTarget();
            String jan = resolveJoinAliasName(nrp, xgetNextNestLevel());
            VdSynonymVendorTargetCQ cq = new VdSynonymVendorTargetCQ(this, xgetSqlClause(), jan, xgetNextNestLevel());
            cq.xsetForeignPropertyName("vdSynonymVendorTarget"); cq.xsetRelationPath(nrp); return cq;
        }
        public void xsetupOuterJoin_VdSynonymVendorTarget() {
            VdSynonymVendorTargetCQ cq = ConditionQueryVdSynonymVendorTarget;
            Map<String, String> joinOnMap = new LinkedHashMap<String, String>();
            joinOnMap.put("VENDOR_TARGET_ID", "VENDOR_TARGET_ID");
            registerOuterJoin(cq, joinOnMap);
        }
        protected String resolveNextRelationPathVdSynonymVendorTarget() {
            return resolveNextRelationPath("VD_SYNONYM_VENDOR_REF_TARGET", "vdSynonymVendorTarget");
        }
        public bool hasConditionQueryVdSynonymVendorTarget() {
            return _conditionQueryVdSynonymVendorTarget != null;
        }


	    // ===============================================================================
	    //                                                                 Scalar SubQuery
	    //                                                                 ===============
	    protected Map<String, VdSynonymVendorRefTargetCQ> _scalarSubQueryMap;
	    public Map<String, VdSynonymVendorRefTargetCQ> ScalarSubQuery { get { return _scalarSubQueryMap; } }
	    public override String keepScalarSubQuery(VdSynonymVendorRefTargetCQ subQuery) {
	        if (_scalarSubQueryMap == null) { _scalarSubQueryMap = new LinkedHashMap<String, VdSynonymVendorRefTargetCQ>(); }
	        String key = "subQueryMapKey" + (_scalarSubQueryMap.size() + 1);
	        _scalarSubQueryMap.put(key, subQuery); return "ScalarSubQuery." + key;
	    }

        // ===============================================================================
        //                                                         Myself InScope SubQuery
        //                                                         =======================
        protected Map<String, VdSynonymVendorRefTargetCQ> _myselfInScopeSubQueryMap;
        public Map<String, VdSynonymVendorRefTargetCQ> MyselfInScopeSubQuery { get { return _myselfInScopeSubQueryMap; } }
        public override String keepMyselfInScopeSubQuery(VdSynonymVendorRefTargetCQ subQuery) {
            if (_myselfInScopeSubQueryMap == null) { _myselfInScopeSubQueryMap = new LinkedHashMap<String, VdSynonymVendorRefTargetCQ>(); }
            String key = "subQueryMapKey" + (_myselfInScopeSubQueryMap.size() + 1);
            _myselfInScopeSubQueryMap.put(key, subQuery); return "MyselfInScopeSubQuery." + key;
        }
    }
}
