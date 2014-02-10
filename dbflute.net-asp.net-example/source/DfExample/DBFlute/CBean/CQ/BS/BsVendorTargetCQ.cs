
using System;

using DfExample.DBFlute.AllCommon.CBean;
using DfExample.DBFlute.AllCommon.CBean.CValue;
using DfExample.DBFlute.AllCommon.CBean.SClause;
using DfExample.DBFlute.AllCommon.JavaLike;
using DfExample.DBFlute.CBean.CQ;
using DfExample.DBFlute.CBean.CQ.Ciq;

namespace DfExample.DBFlute.CBean.CQ.BS {

    [System.Serializable]
    public class BsVendorTargetCQ : AbstractBsVendorTargetCQ {

        protected VendorTargetCIQ _inlineQuery;

        public BsVendorTargetCQ(ConditionQuery childQuery, SqlClause sqlClause, String aliasName, int nestLevel)
            : base(childQuery, sqlClause, aliasName, nestLevel) {}

        public VendorTargetCIQ Inline() {
            if (_inlineQuery == null) {
                _inlineQuery = new VendorTargetCIQ(xgetReferrerQuery(), xgetSqlClause(), xgetAliasName(), xgetNestLevel(), this);
            }
            _inlineQuery.xsetOnClause(false);
            return _inlineQuery;
        }
        
        public VendorTargetCIQ On() {
            if (isBaseQuery()) { throw new UnsupportedOperationException("Unsupported onClause of Base Table!"); }
            VendorTargetCIQ inlineQuery = Inline();
            inlineQuery.xsetOnClause(true);
            return inlineQuery;
        }


        protected ConditionValue _vendorTargetId;
        public ConditionValue VendorTargetId {
            get { if (_vendorTargetId == null) { _vendorTargetId = new ConditionValue(); } return _vendorTargetId; }
        }
        protected override ConditionValue getCValueVendorTargetId() { return this.VendorTargetId; }


        protected Map<String, VendorRefTargetCQ> _vendorTargetId_ExistsSubQuery_VendorRefTargetListMap;
        public Map<String, VendorRefTargetCQ> VendorTargetId_ExistsSubQuery_VendorRefTargetList { get { return _vendorTargetId_ExistsSubQuery_VendorRefTargetListMap; }}
        public override String keepVendorTargetId_ExistsSubQuery_VendorRefTargetList(VendorRefTargetCQ subQuery) {
            if (_vendorTargetId_ExistsSubQuery_VendorRefTargetListMap == null) { _vendorTargetId_ExistsSubQuery_VendorRefTargetListMap = new LinkedHashMap<String, VendorRefTargetCQ>(); }
            String key = "subQueryMapKey" + (_vendorTargetId_ExistsSubQuery_VendorRefTargetListMap.size() + 1);
            _vendorTargetId_ExistsSubQuery_VendorRefTargetListMap.put(key, subQuery); return "VendorTargetId_ExistsSubQuery_VendorRefTargetList." + key;
        }

        protected Map<String, VendorRefTargetCQ> _vendorTargetId_NotExistsSubQuery_VendorRefTargetListMap;
        public Map<String, VendorRefTargetCQ> VendorTargetId_NotExistsSubQuery_VendorRefTargetList { get { return _vendorTargetId_NotExistsSubQuery_VendorRefTargetListMap; }}
        public override String keepVendorTargetId_NotExistsSubQuery_VendorRefTargetList(VendorRefTargetCQ subQuery) {
            if (_vendorTargetId_NotExistsSubQuery_VendorRefTargetListMap == null) { _vendorTargetId_NotExistsSubQuery_VendorRefTargetListMap = new LinkedHashMap<String, VendorRefTargetCQ>(); }
            String key = "subQueryMapKey" + (_vendorTargetId_NotExistsSubQuery_VendorRefTargetListMap.size() + 1);
            _vendorTargetId_NotExistsSubQuery_VendorRefTargetListMap.put(key, subQuery); return "VendorTargetId_NotExistsSubQuery_VendorRefTargetList." + key;
        }

        protected Map<String, VendorRefTargetCQ> _vendorTargetId_InScopeSubQuery_VendorRefTargetListMap;
        public Map<String, VendorRefTargetCQ> VendorTargetId_InScopeSubQuery_VendorRefTargetList { get { return _vendorTargetId_InScopeSubQuery_VendorRefTargetListMap; }}
        public override String keepVendorTargetId_InScopeSubQuery_VendorRefTargetList(VendorRefTargetCQ subQuery) {
            if (_vendorTargetId_InScopeSubQuery_VendorRefTargetListMap == null) { _vendorTargetId_InScopeSubQuery_VendorRefTargetListMap = new LinkedHashMap<String, VendorRefTargetCQ>(); }
            String key = "subQueryMapKey" + (_vendorTargetId_InScopeSubQuery_VendorRefTargetListMap.size() + 1);
            _vendorTargetId_InScopeSubQuery_VendorRefTargetListMap.put(key, subQuery); return "VendorTargetId_InScopeSubQuery_VendorRefTargetList." + key;
        }

        protected Map<String, VendorRefTargetCQ> _vendorTargetId_NotInScopeSubQuery_VendorRefTargetListMap;
        public Map<String, VendorRefTargetCQ> VendorTargetId_NotInScopeSubQuery_VendorRefTargetList { get { return _vendorTargetId_NotInScopeSubQuery_VendorRefTargetListMap; }}
        public override String keepVendorTargetId_NotInScopeSubQuery_VendorRefTargetList(VendorRefTargetCQ subQuery) {
            if (_vendorTargetId_NotInScopeSubQuery_VendorRefTargetListMap == null) { _vendorTargetId_NotInScopeSubQuery_VendorRefTargetListMap = new LinkedHashMap<String, VendorRefTargetCQ>(); }
            String key = "subQueryMapKey" + (_vendorTargetId_NotInScopeSubQuery_VendorRefTargetListMap.size() + 1);
            _vendorTargetId_NotInScopeSubQuery_VendorRefTargetListMap.put(key, subQuery); return "VendorTargetId_NotInScopeSubQuery_VendorRefTargetList." + key;
        }

        protected Map<String, VendorRefTargetCQ> _vendorTargetId_SpecifyDerivedReferrer_VendorRefTargetListMap;
        public Map<String, VendorRefTargetCQ> VendorTargetId_SpecifyDerivedReferrer_VendorRefTargetList { get { return _vendorTargetId_SpecifyDerivedReferrer_VendorRefTargetListMap; }}
        public override String keepVendorTargetId_SpecifyDerivedReferrer_VendorRefTargetList(VendorRefTargetCQ subQuery) {
            if (_vendorTargetId_SpecifyDerivedReferrer_VendorRefTargetListMap == null) { _vendorTargetId_SpecifyDerivedReferrer_VendorRefTargetListMap = new LinkedHashMap<String, VendorRefTargetCQ>(); }
            String key = "subQueryMapKey" + (_vendorTargetId_SpecifyDerivedReferrer_VendorRefTargetListMap.size() + 1);
            _vendorTargetId_SpecifyDerivedReferrer_VendorRefTargetListMap.put(key, subQuery); return "VendorTargetId_SpecifyDerivedReferrer_VendorRefTargetList." + key;
        }

        protected Map<String, VendorRefTargetCQ> _vendorTargetId_QueryDerivedReferrer_VendorRefTargetListMap;
        public Map<String, VendorRefTargetCQ> VendorTargetId_QueryDerivedReferrer_VendorRefTargetList { get { return _vendorTargetId_QueryDerivedReferrer_VendorRefTargetListMap; } }
        public override String keepVendorTargetId_QueryDerivedReferrer_VendorRefTargetList(VendorRefTargetCQ subQuery) {
            if (_vendorTargetId_QueryDerivedReferrer_VendorRefTargetListMap == null) { _vendorTargetId_QueryDerivedReferrer_VendorRefTargetListMap = new LinkedHashMap<String, VendorRefTargetCQ>(); }
            String key = "subQueryMapKey" + (_vendorTargetId_QueryDerivedReferrer_VendorRefTargetListMap.size() + 1);
            _vendorTargetId_QueryDerivedReferrer_VendorRefTargetListMap.put(key, subQuery); return "VendorTargetId_QueryDerivedReferrer_VendorRefTargetList." + key;
        }
        protected Map<String, Object> _vendorTargetId_QueryDerivedReferrer_VendorRefTargetListParameterMap;
        public Map<String, Object> VendorTargetId_QueryDerivedReferrer_VendorRefTargetListParameter { get { return _vendorTargetId_QueryDerivedReferrer_VendorRefTargetListParameterMap; } }
        public override String keepVendorTargetId_QueryDerivedReferrer_VendorRefTargetListParameter(Object parameterValue) {
            if (_vendorTargetId_QueryDerivedReferrer_VendorRefTargetListParameterMap == null) { _vendorTargetId_QueryDerivedReferrer_VendorRefTargetListParameterMap = new LinkedHashMap<String, Object>(); }
            String key = "subQueryParameterKey" + (_vendorTargetId_QueryDerivedReferrer_VendorRefTargetListParameterMap.size() + 1);
            _vendorTargetId_QueryDerivedReferrer_VendorRefTargetListParameterMap.put(key, parameterValue); return "VendorTargetId_QueryDerivedReferrer_VendorRefTargetListParameter." + key;
        }

        public BsVendorTargetCQ AddOrderBy_VendorTargetId_Asc() { regOBA("VENDOR_TARGET_ID");return this; }
        public BsVendorTargetCQ AddOrderBy_VendorTargetId_Desc() { regOBD("VENDOR_TARGET_ID");return this; }

        protected ConditionValue _vandorTargetName;
        public ConditionValue VandorTargetName {
            get { if (_vandorTargetName == null) { _vandorTargetName = new ConditionValue(); } return _vandorTargetName; }
        }
        protected override ConditionValue getCValueVandorTargetName() { return this.VandorTargetName; }


        public BsVendorTargetCQ AddOrderBy_VandorTargetName_Asc() { regOBA("VANDOR_TARGET_NAME");return this; }
        public BsVendorTargetCQ AddOrderBy_VandorTargetName_Desc() { regOBD("VANDOR_TARGET_NAME");return this; }

        public BsVendorTargetCQ AddSpecifiedDerivedOrderBy_Asc(String aliasName) { registerSpecifiedDerivedOrderBy_Asc(aliasName); return this; }
        public BsVendorTargetCQ AddSpecifiedDerivedOrderBy_Desc(String aliasName) { registerSpecifiedDerivedOrderBy_Desc(aliasName); return this; }

        public override void reflectRelationOnUnionQuery(ConditionQuery baseQueryAsSuper, ConditionQuery unionQueryAsSuper) {

        }
    


	    // ===============================================================================
	    //                                                                 Scalar SubQuery
	    //                                                                 ===============
	    protected Map<String, VendorTargetCQ> _scalarSubQueryMap;
	    public Map<String, VendorTargetCQ> ScalarSubQuery { get { return _scalarSubQueryMap; } }
	    public override String keepScalarSubQuery(VendorTargetCQ subQuery) {
	        if (_scalarSubQueryMap == null) { _scalarSubQueryMap = new LinkedHashMap<String, VendorTargetCQ>(); }
	        String key = "subQueryMapKey" + (_scalarSubQueryMap.size() + 1);
	        _scalarSubQueryMap.put(key, subQuery); return "ScalarSubQuery." + key;
	    }

        // ===============================================================================
        //                                                         Myself InScope SubQuery
        //                                                         =======================
        protected Map<String, VendorTargetCQ> _myselfInScopeSubQueryMap;
        public Map<String, VendorTargetCQ> MyselfInScopeSubQuery { get { return _myselfInScopeSubQueryMap; } }
        public override String keepMyselfInScopeSubQuery(VendorTargetCQ subQuery) {
            if (_myselfInScopeSubQueryMap == null) { _myselfInScopeSubQueryMap = new LinkedHashMap<String, VendorTargetCQ>(); }
            String key = "subQueryMapKey" + (_myselfInScopeSubQueryMap.size() + 1);
            _myselfInScopeSubQueryMap.put(key, subQuery); return "MyselfInScopeSubQuery." + key;
        }
    }
}
