
using System;

using DfExample.DBFlute.AllCommon.CBean;
using DfExample.DBFlute.AllCommon.CBean.CValue;
using DfExample.DBFlute.AllCommon.CBean.SClause;
using DfExample.DBFlute.AllCommon.JavaLike;
using DfExample.DBFlute.CBean.CQ;
using DfExample.DBFlute.CBean.CQ.Ciq;

namespace DfExample.DBFlute.CBean.CQ.BS {

    [System.Serializable]
    public class BsVdSynonymVendorRefExceptCQ : AbstractBsVdSynonymVendorRefExceptCQ {

        protected VdSynonymVendorRefExceptCIQ _inlineQuery;

        public BsVdSynonymVendorRefExceptCQ(ConditionQuery childQuery, SqlClause sqlClause, String aliasName, int nestLevel)
            : base(childQuery, sqlClause, aliasName, nestLevel) {}

        public VdSynonymVendorRefExceptCIQ Inline() {
            if (_inlineQuery == null) {
                _inlineQuery = new VdSynonymVendorRefExceptCIQ(xgetReferrerQuery(), xgetSqlClause(), xgetAliasName(), xgetNestLevel(), this);
            }
            _inlineQuery.xsetOnClause(false);
            return _inlineQuery;
        }
        
        public VdSynonymVendorRefExceptCIQ On() {
            if (isBaseQuery()) { throw new UnsupportedOperationException("Unsupported onClause of Base Table!"); }
            VdSynonymVendorRefExceptCIQ inlineQuery = Inline();
            inlineQuery.xsetOnClause(true);
            return inlineQuery;
        }


        protected ConditionValue _vendorRefExceptId;
        public ConditionValue VendorRefExceptId {
            get { if (_vendorRefExceptId == null) { _vendorRefExceptId = new ConditionValue(); } return _vendorRefExceptId; }
        }
        protected override ConditionValue getCValueVendorRefExceptId() { return this.VendorRefExceptId; }


        public BsVdSynonymVendorRefExceptCQ AddOrderBy_VendorRefExceptId_Asc() { regOBA("VENDOR_REF_EXCEPT_ID");return this; }
        public BsVdSynonymVendorRefExceptCQ AddOrderBy_VendorRefExceptId_Desc() { regOBD("VENDOR_REF_EXCEPT_ID");return this; }

        protected ConditionValue _vendorExceptId;
        public ConditionValue VendorExceptId {
            get { if (_vendorExceptId == null) { _vendorExceptId = new ConditionValue(); } return _vendorExceptId; }
        }
        protected override ConditionValue getCValueVendorExceptId() { return this.VendorExceptId; }


        protected Map<String, VdSynonymVendorExceptCQ> _vendorExceptId_InScopeSubQuery_VdSynonymVendorExceptMap;
        public Map<String, VdSynonymVendorExceptCQ> VendorExceptId_InScopeSubQuery_VdSynonymVendorExcept { get { return _vendorExceptId_InScopeSubQuery_VdSynonymVendorExceptMap; }}
        public override String keepVendorExceptId_InScopeSubQuery_VdSynonymVendorExcept(VdSynonymVendorExceptCQ subQuery) {
            if (_vendorExceptId_InScopeSubQuery_VdSynonymVendorExceptMap == null) { _vendorExceptId_InScopeSubQuery_VdSynonymVendorExceptMap = new LinkedHashMap<String, VdSynonymVendorExceptCQ>(); }
            String key = "subQueryMapKey" + (_vendorExceptId_InScopeSubQuery_VdSynonymVendorExceptMap.size() + 1);
            _vendorExceptId_InScopeSubQuery_VdSynonymVendorExceptMap.put(key, subQuery); return "VendorExceptId_InScopeSubQuery_VdSynonymVendorExcept." + key;
        }

        protected Map<String, VdSynonymVendorExceptCQ> _vendorExceptId_NotInScopeSubQuery_VdSynonymVendorExceptMap;
        public Map<String, VdSynonymVendorExceptCQ> VendorExceptId_NotInScopeSubQuery_VdSynonymVendorExcept { get { return _vendorExceptId_NotInScopeSubQuery_VdSynonymVendorExceptMap; }}
        public override String keepVendorExceptId_NotInScopeSubQuery_VdSynonymVendorExcept(VdSynonymVendorExceptCQ subQuery) {
            if (_vendorExceptId_NotInScopeSubQuery_VdSynonymVendorExceptMap == null) { _vendorExceptId_NotInScopeSubQuery_VdSynonymVendorExceptMap = new LinkedHashMap<String, VdSynonymVendorExceptCQ>(); }
            String key = "subQueryMapKey" + (_vendorExceptId_NotInScopeSubQuery_VdSynonymVendorExceptMap.size() + 1);
            _vendorExceptId_NotInScopeSubQuery_VdSynonymVendorExceptMap.put(key, subQuery); return "VendorExceptId_NotInScopeSubQuery_VdSynonymVendorExcept." + key;
        }

        public BsVdSynonymVendorRefExceptCQ AddOrderBy_VendorExceptId_Asc() { regOBA("VENDOR_EXCEPT_ID");return this; }
        public BsVdSynonymVendorRefExceptCQ AddOrderBy_VendorExceptId_Desc() { regOBD("VENDOR_EXCEPT_ID");return this; }

        public BsVdSynonymVendorRefExceptCQ AddSpecifiedDerivedOrderBy_Asc(String aliasName) { registerSpecifiedDerivedOrderBy_Asc(aliasName); return this; }
        public BsVdSynonymVendorRefExceptCQ AddSpecifiedDerivedOrderBy_Desc(String aliasName) { registerSpecifiedDerivedOrderBy_Desc(aliasName); return this; }

        public override void reflectRelationOnUnionQuery(ConditionQuery baseQueryAsSuper, ConditionQuery unionQueryAsSuper) {
            VdSynonymVendorRefExceptCQ baseQuery = (VdSynonymVendorRefExceptCQ)baseQueryAsSuper;
            VdSynonymVendorRefExceptCQ unionQuery = (VdSynonymVendorRefExceptCQ)unionQueryAsSuper;
            if (baseQuery.hasConditionQueryVdSynonymVendorExcept()) {
                unionQuery.QueryVdSynonymVendorExcept().reflectRelationOnUnionQuery(baseQuery.QueryVdSynonymVendorExcept(), unionQuery.QueryVdSynonymVendorExcept());
            }

        }
    
        protected VdSynonymVendorExceptCQ _conditionQueryVdSynonymVendorExcept;
        public VdSynonymVendorExceptCQ QueryVdSynonymVendorExcept() {
            return this.ConditionQueryVdSynonymVendorExcept;
        }
        public VdSynonymVendorExceptCQ ConditionQueryVdSynonymVendorExcept {
            get {
                if (_conditionQueryVdSynonymVendorExcept == null) {
                    _conditionQueryVdSynonymVendorExcept = xcreateQueryVdSynonymVendorExcept();
                    xsetupOuterJoin_VdSynonymVendorExcept();
                }
                return _conditionQueryVdSynonymVendorExcept;
            }
        }
        protected VdSynonymVendorExceptCQ xcreateQueryVdSynonymVendorExcept() {
            String nrp = resolveNextRelationPathVdSynonymVendorExcept();
            String jan = resolveJoinAliasName(nrp, xgetNextNestLevel());
            VdSynonymVendorExceptCQ cq = new VdSynonymVendorExceptCQ(this, xgetSqlClause(), jan, xgetNextNestLevel());
            cq.xsetForeignPropertyName("vdSynonymVendorExcept"); cq.xsetRelationPath(nrp); return cq;
        }
        public void xsetupOuterJoin_VdSynonymVendorExcept() {
            VdSynonymVendorExceptCQ cq = ConditionQueryVdSynonymVendorExcept;
            Map<String, String> joinOnMap = new LinkedHashMap<String, String>();
            joinOnMap.put("VENDOR_EXCEPT_ID", "VENDOR_EXCEPT_ID");
            registerOuterJoin(cq, joinOnMap);
        }
        protected String resolveNextRelationPathVdSynonymVendorExcept() {
            return resolveNextRelationPath("VD_SYNONYM_VENDOR_REF_EXCEPT", "vdSynonymVendorExcept");
        }
        public bool hasConditionQueryVdSynonymVendorExcept() {
            return _conditionQueryVdSynonymVendorExcept != null;
        }


	    // ===============================================================================
	    //                                                                 Scalar SubQuery
	    //                                                                 ===============
	    protected Map<String, VdSynonymVendorRefExceptCQ> _scalarSubQueryMap;
	    public Map<String, VdSynonymVendorRefExceptCQ> ScalarSubQuery { get { return _scalarSubQueryMap; } }
	    public override String keepScalarSubQuery(VdSynonymVendorRefExceptCQ subQuery) {
	        if (_scalarSubQueryMap == null) { _scalarSubQueryMap = new LinkedHashMap<String, VdSynonymVendorRefExceptCQ>(); }
	        String key = "subQueryMapKey" + (_scalarSubQueryMap.size() + 1);
	        _scalarSubQueryMap.put(key, subQuery); return "ScalarSubQuery." + key;
	    }

        // ===============================================================================
        //                                                         Myself InScope SubQuery
        //                                                         =======================
        protected Map<String, VdSynonymVendorRefExceptCQ> _myselfInScopeSubQueryMap;
        public Map<String, VdSynonymVendorRefExceptCQ> MyselfInScopeSubQuery { get { return _myselfInScopeSubQueryMap; } }
        public override String keepMyselfInScopeSubQuery(VdSynonymVendorRefExceptCQ subQuery) {
            if (_myselfInScopeSubQueryMap == null) { _myselfInScopeSubQueryMap = new LinkedHashMap<String, VdSynonymVendorRefExceptCQ>(); }
            String key = "subQueryMapKey" + (_myselfInScopeSubQueryMap.size() + 1);
            _myselfInScopeSubQueryMap.put(key, subQuery); return "MyselfInScopeSubQuery." + key;
        }
    }
}
