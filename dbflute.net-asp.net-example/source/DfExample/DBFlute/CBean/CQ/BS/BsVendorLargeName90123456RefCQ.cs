
using System;

using DfExample.DBFlute.AllCommon.CBean;
using DfExample.DBFlute.AllCommon.CBean.CValue;
using DfExample.DBFlute.AllCommon.CBean.SClause;
using DfExample.DBFlute.AllCommon.JavaLike;
using DfExample.DBFlute.CBean.CQ;
using DfExample.DBFlute.CBean.CQ.Ciq;

namespace DfExample.DBFlute.CBean.CQ.BS {

    [System.Serializable]
    public class BsVendorLargeName90123456RefCQ : AbstractBsVendorLargeName90123456RefCQ {

        protected VendorLargeName90123456RefCIQ _inlineQuery;

        public BsVendorLargeName90123456RefCQ(ConditionQuery childQuery, SqlClause sqlClause, String aliasName, int nestLevel)
            : base(childQuery, sqlClause, aliasName, nestLevel) {}

        public VendorLargeName90123456RefCIQ Inline() {
            if (_inlineQuery == null) {
                _inlineQuery = new VendorLargeName90123456RefCIQ(xgetReferrerQuery(), xgetSqlClause(), xgetAliasName(), xgetNestLevel(), this);
            }
            _inlineQuery.xsetOnClause(false);
            return _inlineQuery;
        }
        
        public VendorLargeName90123456RefCIQ On() {
            if (isBaseQuery()) { throw new UnsupportedOperationException("Unsupported onClause of Base Table!"); }
            VendorLargeName90123456RefCIQ inlineQuery = Inline();
            inlineQuery.xsetOnClause(true);
            return inlineQuery;
        }


        protected ConditionValue _vendorLargeName90123RefId;
        public ConditionValue VendorLargeName90123RefId {
            get { if (_vendorLargeName90123RefId == null) { _vendorLargeName90123RefId = new ConditionValue(); } return _vendorLargeName90123RefId; }
        }
        protected override ConditionValue getCValueVendorLargeName90123RefId() { return this.VendorLargeName90123RefId; }


        public BsVendorLargeName90123456RefCQ AddOrderBy_VendorLargeName90123RefId_Asc() { regOBA("VENDOR_LARGE_NAME_90123_REF_ID");return this; }
        public BsVendorLargeName90123456RefCQ AddOrderBy_VendorLargeName90123RefId_Desc() { regOBD("VENDOR_LARGE_NAME_90123_REF_ID");return this; }

        protected ConditionValue _vendorLargeName901RefName;
        public ConditionValue VendorLargeName901RefName {
            get { if (_vendorLargeName901RefName == null) { _vendorLargeName901RefName = new ConditionValue(); } return _vendorLargeName901RefName; }
        }
        protected override ConditionValue getCValueVendorLargeName901RefName() { return this.VendorLargeName901RefName; }


        public BsVendorLargeName90123456RefCQ AddOrderBy_VendorLargeName901RefName_Asc() { regOBA("VENDOR_LARGE_NAME_901_REF_NAME");return this; }
        public BsVendorLargeName90123456RefCQ AddOrderBy_VendorLargeName901RefName_Desc() { regOBD("VENDOR_LARGE_NAME_901_REF_NAME");return this; }

        protected ConditionValue _vendorLargeName901234567Id;
        public ConditionValue VendorLargeName901234567Id {
            get { if (_vendorLargeName901234567Id == null) { _vendorLargeName901234567Id = new ConditionValue(); } return _vendorLargeName901234567Id; }
        }
        protected override ConditionValue getCValueVendorLargeName901234567Id() { return this.VendorLargeName901234567Id; }


        protected Map<String, VendorLargeName901234567890CQ> _vendorLargeName901234567Id_InScopeSubQuery_VendorLargeName901234567890Map;
        public Map<String, VendorLargeName901234567890CQ> VendorLargeName901234567Id_InScopeSubQuery_VendorLargeName901234567890 { get { return _vendorLargeName901234567Id_InScopeSubQuery_VendorLargeName901234567890Map; }}
        public override String keepVendorLargeName901234567Id_InScopeSubQuery_VendorLargeName901234567890(VendorLargeName901234567890CQ subQuery) {
            if (_vendorLargeName901234567Id_InScopeSubQuery_VendorLargeName901234567890Map == null) { _vendorLargeName901234567Id_InScopeSubQuery_VendorLargeName901234567890Map = new LinkedHashMap<String, VendorLargeName901234567890CQ>(); }
            String key = "subQueryMapKey" + (_vendorLargeName901234567Id_InScopeSubQuery_VendorLargeName901234567890Map.size() + 1);
            _vendorLargeName901234567Id_InScopeSubQuery_VendorLargeName901234567890Map.put(key, subQuery); return "VendorLargeName901234567Id_InScopeSubQuery_VendorLargeName901234567890." + key;
        }

        protected Map<String, VendorLargeName901234567890CQ> _vendorLargeName901234567Id_NotInScopeSubQuery_VendorLargeName901234567890Map;
        public Map<String, VendorLargeName901234567890CQ> VendorLargeName901234567Id_NotInScopeSubQuery_VendorLargeName901234567890 { get { return _vendorLargeName901234567Id_NotInScopeSubQuery_VendorLargeName901234567890Map; }}
        public override String keepVendorLargeName901234567Id_NotInScopeSubQuery_VendorLargeName901234567890(VendorLargeName901234567890CQ subQuery) {
            if (_vendorLargeName901234567Id_NotInScopeSubQuery_VendorLargeName901234567890Map == null) { _vendorLargeName901234567Id_NotInScopeSubQuery_VendorLargeName901234567890Map = new LinkedHashMap<String, VendorLargeName901234567890CQ>(); }
            String key = "subQueryMapKey" + (_vendorLargeName901234567Id_NotInScopeSubQuery_VendorLargeName901234567890Map.size() + 1);
            _vendorLargeName901234567Id_NotInScopeSubQuery_VendorLargeName901234567890Map.put(key, subQuery); return "VendorLargeName901234567Id_NotInScopeSubQuery_VendorLargeName901234567890." + key;
        }

        public BsVendorLargeName90123456RefCQ AddOrderBy_VendorLargeName901234567Id_Asc() { regOBA("VENDOR_LARGE_NAME_901234567_ID");return this; }
        public BsVendorLargeName90123456RefCQ AddOrderBy_VendorLargeName901234567Id_Desc() { regOBD("VENDOR_LARGE_NAME_901234567_ID");return this; }

        public BsVendorLargeName90123456RefCQ AddSpecifiedDerivedOrderBy_Asc(String aliasName) { registerSpecifiedDerivedOrderBy_Asc(aliasName); return this; }
        public BsVendorLargeName90123456RefCQ AddSpecifiedDerivedOrderBy_Desc(String aliasName) { registerSpecifiedDerivedOrderBy_Desc(aliasName); return this; }

        public override void reflectRelationOnUnionQuery(ConditionQuery baseQueryAsSuper, ConditionQuery unionQueryAsSuper) {
            VendorLargeName90123456RefCQ baseQuery = (VendorLargeName90123456RefCQ)baseQueryAsSuper;
            VendorLargeName90123456RefCQ unionQuery = (VendorLargeName90123456RefCQ)unionQueryAsSuper;
            if (baseQuery.hasConditionQueryVendorLargeName901234567890()) {
                unionQuery.QueryVendorLargeName901234567890().reflectRelationOnUnionQuery(baseQuery.QueryVendorLargeName901234567890(), unionQuery.QueryVendorLargeName901234567890());
            }

        }
    
        protected VendorLargeName901234567890CQ _conditionQueryVendorLargeName901234567890;
        public VendorLargeName901234567890CQ QueryVendorLargeName901234567890() {
            return this.ConditionQueryVendorLargeName901234567890;
        }
        public VendorLargeName901234567890CQ ConditionQueryVendorLargeName901234567890 {
            get {
                if (_conditionQueryVendorLargeName901234567890 == null) {
                    _conditionQueryVendorLargeName901234567890 = xcreateQueryVendorLargeName901234567890();
                    xsetupOuterJoin_VendorLargeName901234567890();
                }
                return _conditionQueryVendorLargeName901234567890;
            }
        }
        protected VendorLargeName901234567890CQ xcreateQueryVendorLargeName901234567890() {
            String nrp = resolveNextRelationPathVendorLargeName901234567890();
            String jan = resolveJoinAliasName(nrp, xgetNextNestLevel());
            VendorLargeName901234567890CQ cq = new VendorLargeName901234567890CQ(this, xgetSqlClause(), jan, xgetNextNestLevel());
            cq.xsetForeignPropertyName("vendorLargeName901234567890"); cq.xsetRelationPath(nrp); return cq;
        }
        public void xsetupOuterJoin_VendorLargeName901234567890() {
            VendorLargeName901234567890CQ cq = ConditionQueryVendorLargeName901234567890;
            Map<String, String> joinOnMap = new LinkedHashMap<String, String>();
            joinOnMap.put("VENDOR_LARGE_NAME_901234567_ID", "VENDOR_LARGE_NAME_901234567_ID");
            registerOuterJoin(cq, joinOnMap);
        }
        protected String resolveNextRelationPathVendorLargeName901234567890() {
            return resolveNextRelationPath("VENDOR_LARGE_NAME_90123456_REF", "vendorLargeName901234567890");
        }
        public bool hasConditionQueryVendorLargeName901234567890() {
            return _conditionQueryVendorLargeName901234567890 != null;
        }


	    // ===============================================================================
	    //                                                                 Scalar SubQuery
	    //                                                                 ===============
	    protected Map<String, VendorLargeName90123456RefCQ> _scalarSubQueryMap;
	    public Map<String, VendorLargeName90123456RefCQ> ScalarSubQuery { get { return _scalarSubQueryMap; } }
	    public override String keepScalarSubQuery(VendorLargeName90123456RefCQ subQuery) {
	        if (_scalarSubQueryMap == null) { _scalarSubQueryMap = new LinkedHashMap<String, VendorLargeName90123456RefCQ>(); }
	        String key = "subQueryMapKey" + (_scalarSubQueryMap.size() + 1);
	        _scalarSubQueryMap.put(key, subQuery); return "ScalarSubQuery." + key;
	    }

        // ===============================================================================
        //                                                         Myself InScope SubQuery
        //                                                         =======================
        protected Map<String, VendorLargeName90123456RefCQ> _myselfInScopeSubQueryMap;
        public Map<String, VendorLargeName90123456RefCQ> MyselfInScopeSubQuery { get { return _myselfInScopeSubQueryMap; } }
        public override String keepMyselfInScopeSubQuery(VendorLargeName90123456RefCQ subQuery) {
            if (_myselfInScopeSubQueryMap == null) { _myselfInScopeSubQueryMap = new LinkedHashMap<String, VendorLargeName90123456RefCQ>(); }
            String key = "subQueryMapKey" + (_myselfInScopeSubQueryMap.size() + 1);
            _myselfInScopeSubQueryMap.put(key, subQuery); return "MyselfInScopeSubQuery." + key;
        }
    }
}
