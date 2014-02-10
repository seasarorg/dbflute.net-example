
using System;

using DfExample.DBFlute.AllCommon.CBean;
using DfExample.DBFlute.AllCommon.CBean.CValue;
using DfExample.DBFlute.AllCommon.CBean.SClause;
using DfExample.DBFlute.AllCommon.JavaLike;
using DfExample.DBFlute.CBean.CQ;
using DfExample.DBFlute.CBean.CQ.Ciq;

namespace DfExample.DBFlute.CBean.CQ.BS {

    [System.Serializable]
    public class BsVendorRefExceptCQ : AbstractBsVendorRefExceptCQ {

        protected VendorRefExceptCIQ _inlineQuery;

        public BsVendorRefExceptCQ(ConditionQuery childQuery, SqlClause sqlClause, String aliasName, int nestLevel)
            : base(childQuery, sqlClause, aliasName, nestLevel) {}

        public VendorRefExceptCIQ Inline() {
            if (_inlineQuery == null) {
                _inlineQuery = new VendorRefExceptCIQ(xgetReferrerQuery(), xgetSqlClause(), xgetAliasName(), xgetNestLevel(), this);
            }
            _inlineQuery.xsetOnClause(false);
            return _inlineQuery;
        }
        
        public VendorRefExceptCIQ On() {
            if (isBaseQuery()) { throw new UnsupportedOperationException("Unsupported onClause of Base Table!"); }
            VendorRefExceptCIQ inlineQuery = Inline();
            inlineQuery.xsetOnClause(true);
            return inlineQuery;
        }


        protected ConditionValue _vendorRefExceptId;
        public ConditionValue VendorRefExceptId {
            get { if (_vendorRefExceptId == null) { _vendorRefExceptId = new ConditionValue(); } return _vendorRefExceptId; }
        }
        protected override ConditionValue getCValueVendorRefExceptId() { return this.VendorRefExceptId; }


        public BsVendorRefExceptCQ AddOrderBy_VendorRefExceptId_Asc() { regOBA("VENDOR_REF_EXCEPT_ID");return this; }
        public BsVendorRefExceptCQ AddOrderBy_VendorRefExceptId_Desc() { regOBD("VENDOR_REF_EXCEPT_ID");return this; }

        protected ConditionValue _vendorExceptId;
        public ConditionValue VendorExceptId {
            get { if (_vendorExceptId == null) { _vendorExceptId = new ConditionValue(); } return _vendorExceptId; }
        }
        protected override ConditionValue getCValueVendorExceptId() { return this.VendorExceptId; }


        protected Map<String, VendorExceptCQ> _vendorExceptId_InScopeSubQuery_VendorExceptMap;
        public Map<String, VendorExceptCQ> VendorExceptId_InScopeSubQuery_VendorExcept { get { return _vendorExceptId_InScopeSubQuery_VendorExceptMap; }}
        public override String keepVendorExceptId_InScopeSubQuery_VendorExcept(VendorExceptCQ subQuery) {
            if (_vendorExceptId_InScopeSubQuery_VendorExceptMap == null) { _vendorExceptId_InScopeSubQuery_VendorExceptMap = new LinkedHashMap<String, VendorExceptCQ>(); }
            String key = "subQueryMapKey" + (_vendorExceptId_InScopeSubQuery_VendorExceptMap.size() + 1);
            _vendorExceptId_InScopeSubQuery_VendorExceptMap.put(key, subQuery); return "VendorExceptId_InScopeSubQuery_VendorExcept." + key;
        }

        protected Map<String, VendorExceptCQ> _vendorExceptId_NotInScopeSubQuery_VendorExceptMap;
        public Map<String, VendorExceptCQ> VendorExceptId_NotInScopeSubQuery_VendorExcept { get { return _vendorExceptId_NotInScopeSubQuery_VendorExceptMap; }}
        public override String keepVendorExceptId_NotInScopeSubQuery_VendorExcept(VendorExceptCQ subQuery) {
            if (_vendorExceptId_NotInScopeSubQuery_VendorExceptMap == null) { _vendorExceptId_NotInScopeSubQuery_VendorExceptMap = new LinkedHashMap<String, VendorExceptCQ>(); }
            String key = "subQueryMapKey" + (_vendorExceptId_NotInScopeSubQuery_VendorExceptMap.size() + 1);
            _vendorExceptId_NotInScopeSubQuery_VendorExceptMap.put(key, subQuery); return "VendorExceptId_NotInScopeSubQuery_VendorExcept." + key;
        }

        public BsVendorRefExceptCQ AddOrderBy_VendorExceptId_Asc() { regOBA("VENDOR_EXCEPT_ID");return this; }
        public BsVendorRefExceptCQ AddOrderBy_VendorExceptId_Desc() { regOBD("VENDOR_EXCEPT_ID");return this; }

        public BsVendorRefExceptCQ AddSpecifiedDerivedOrderBy_Asc(String aliasName) { registerSpecifiedDerivedOrderBy_Asc(aliasName); return this; }
        public BsVendorRefExceptCQ AddSpecifiedDerivedOrderBy_Desc(String aliasName) { registerSpecifiedDerivedOrderBy_Desc(aliasName); return this; }

        public override void reflectRelationOnUnionQuery(ConditionQuery baseQueryAsSuper, ConditionQuery unionQueryAsSuper) {
            VendorRefExceptCQ baseQuery = (VendorRefExceptCQ)baseQueryAsSuper;
            VendorRefExceptCQ unionQuery = (VendorRefExceptCQ)unionQueryAsSuper;
            if (baseQuery.hasConditionQueryVendorExcept()) {
                unionQuery.QueryVendorExcept().reflectRelationOnUnionQuery(baseQuery.QueryVendorExcept(), unionQuery.QueryVendorExcept());
            }

        }
    
        protected VendorExceptCQ _conditionQueryVendorExcept;
        public VendorExceptCQ QueryVendorExcept() {
            return this.ConditionQueryVendorExcept;
        }
        public VendorExceptCQ ConditionQueryVendorExcept {
            get {
                if (_conditionQueryVendorExcept == null) {
                    _conditionQueryVendorExcept = xcreateQueryVendorExcept();
                    xsetupOuterJoin_VendorExcept();
                }
                return _conditionQueryVendorExcept;
            }
        }
        protected VendorExceptCQ xcreateQueryVendorExcept() {
            String nrp = resolveNextRelationPathVendorExcept();
            String jan = resolveJoinAliasName(nrp, xgetNextNestLevel());
            VendorExceptCQ cq = new VendorExceptCQ(this, xgetSqlClause(), jan, xgetNextNestLevel());
            cq.xsetForeignPropertyName("vendorExcept"); cq.xsetRelationPath(nrp); return cq;
        }
        public void xsetupOuterJoin_VendorExcept() {
            VendorExceptCQ cq = ConditionQueryVendorExcept;
            Map<String, String> joinOnMap = new LinkedHashMap<String, String>();
            joinOnMap.put("VENDOR_EXCEPT_ID", "VENDOR_EXCEPT_ID");
            registerOuterJoin(cq, joinOnMap);
        }
        protected String resolveNextRelationPathVendorExcept() {
            return resolveNextRelationPath("VENDOR_REF_EXCEPT", "vendorExcept");
        }
        public bool hasConditionQueryVendorExcept() {
            return _conditionQueryVendorExcept != null;
        }


	    // ===============================================================================
	    //                                                                 Scalar SubQuery
	    //                                                                 ===============
	    protected Map<String, VendorRefExceptCQ> _scalarSubQueryMap;
	    public Map<String, VendorRefExceptCQ> ScalarSubQuery { get { return _scalarSubQueryMap; } }
	    public override String keepScalarSubQuery(VendorRefExceptCQ subQuery) {
	        if (_scalarSubQueryMap == null) { _scalarSubQueryMap = new LinkedHashMap<String, VendorRefExceptCQ>(); }
	        String key = "subQueryMapKey" + (_scalarSubQueryMap.size() + 1);
	        _scalarSubQueryMap.put(key, subQuery); return "ScalarSubQuery." + key;
	    }

        // ===============================================================================
        //                                                         Myself InScope SubQuery
        //                                                         =======================
        protected Map<String, VendorRefExceptCQ> _myselfInScopeSubQueryMap;
        public Map<String, VendorRefExceptCQ> MyselfInScopeSubQuery { get { return _myselfInScopeSubQueryMap; } }
        public override String keepMyselfInScopeSubQuery(VendorRefExceptCQ subQuery) {
            if (_myselfInScopeSubQueryMap == null) { _myselfInScopeSubQueryMap = new LinkedHashMap<String, VendorRefExceptCQ>(); }
            String key = "subQueryMapKey" + (_myselfInScopeSubQueryMap.size() + 1);
            _myselfInScopeSubQueryMap.put(key, subQuery); return "MyselfInScopeSubQuery." + key;
        }
    }
}
