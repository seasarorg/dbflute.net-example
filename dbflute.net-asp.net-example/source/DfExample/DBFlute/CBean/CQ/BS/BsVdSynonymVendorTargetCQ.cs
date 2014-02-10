
using System;

using DfExample.DBFlute.AllCommon.CBean;
using DfExample.DBFlute.AllCommon.CBean.CValue;
using DfExample.DBFlute.AllCommon.CBean.SClause;
using DfExample.DBFlute.AllCommon.JavaLike;
using DfExample.DBFlute.CBean.CQ;
using DfExample.DBFlute.CBean.CQ.Ciq;

namespace DfExample.DBFlute.CBean.CQ.BS {

    [System.Serializable]
    public class BsVdSynonymVendorTargetCQ : AbstractBsVdSynonymVendorTargetCQ {

        protected VdSynonymVendorTargetCIQ _inlineQuery;

        public BsVdSynonymVendorTargetCQ(ConditionQuery childQuery, SqlClause sqlClause, String aliasName, int nestLevel)
            : base(childQuery, sqlClause, aliasName, nestLevel) {}

        public VdSynonymVendorTargetCIQ Inline() {
            if (_inlineQuery == null) {
                _inlineQuery = new VdSynonymVendorTargetCIQ(xgetReferrerQuery(), xgetSqlClause(), xgetAliasName(), xgetNestLevel(), this);
            }
            _inlineQuery.xsetOnClause(false);
            return _inlineQuery;
        }
        
        public VdSynonymVendorTargetCIQ On() {
            if (isBaseQuery()) { throw new UnsupportedOperationException("Unsupported onClause of Base Table!"); }
            VdSynonymVendorTargetCIQ inlineQuery = Inline();
            inlineQuery.xsetOnClause(true);
            return inlineQuery;
        }


        protected ConditionValue _vendorTargetId;
        public ConditionValue VendorTargetId {
            get { if (_vendorTargetId == null) { _vendorTargetId = new ConditionValue(); } return _vendorTargetId; }
        }
        protected override ConditionValue getCValueVendorTargetId() { return this.VendorTargetId; }


        protected Map<String, VdSynonymVendorRefTargetCQ> _vendorTargetId_ExistsSubQuery_VdSynonymVendorRefTargetListMap;
        public Map<String, VdSynonymVendorRefTargetCQ> VendorTargetId_ExistsSubQuery_VdSynonymVendorRefTargetList { get { return _vendorTargetId_ExistsSubQuery_VdSynonymVendorRefTargetListMap; }}
        public override String keepVendorTargetId_ExistsSubQuery_VdSynonymVendorRefTargetList(VdSynonymVendorRefTargetCQ subQuery) {
            if (_vendorTargetId_ExistsSubQuery_VdSynonymVendorRefTargetListMap == null) { _vendorTargetId_ExistsSubQuery_VdSynonymVendorRefTargetListMap = new LinkedHashMap<String, VdSynonymVendorRefTargetCQ>(); }
            String key = "subQueryMapKey" + (_vendorTargetId_ExistsSubQuery_VdSynonymVendorRefTargetListMap.size() + 1);
            _vendorTargetId_ExistsSubQuery_VdSynonymVendorRefTargetListMap.put(key, subQuery); return "VendorTargetId_ExistsSubQuery_VdSynonymVendorRefTargetList." + key;
        }

        protected Map<String, VdSynonymVendorRefTargetCQ> _vendorTargetId_NotExistsSubQuery_VdSynonymVendorRefTargetListMap;
        public Map<String, VdSynonymVendorRefTargetCQ> VendorTargetId_NotExistsSubQuery_VdSynonymVendorRefTargetList { get { return _vendorTargetId_NotExistsSubQuery_VdSynonymVendorRefTargetListMap; }}
        public override String keepVendorTargetId_NotExistsSubQuery_VdSynonymVendorRefTargetList(VdSynonymVendorRefTargetCQ subQuery) {
            if (_vendorTargetId_NotExistsSubQuery_VdSynonymVendorRefTargetListMap == null) { _vendorTargetId_NotExistsSubQuery_VdSynonymVendorRefTargetListMap = new LinkedHashMap<String, VdSynonymVendorRefTargetCQ>(); }
            String key = "subQueryMapKey" + (_vendorTargetId_NotExistsSubQuery_VdSynonymVendorRefTargetListMap.size() + 1);
            _vendorTargetId_NotExistsSubQuery_VdSynonymVendorRefTargetListMap.put(key, subQuery); return "VendorTargetId_NotExistsSubQuery_VdSynonymVendorRefTargetList." + key;
        }

        protected Map<String, VdSynonymVendorRefTargetCQ> _vendorTargetId_InScopeSubQuery_VdSynonymVendorRefTargetListMap;
        public Map<String, VdSynonymVendorRefTargetCQ> VendorTargetId_InScopeSubQuery_VdSynonymVendorRefTargetList { get { return _vendorTargetId_InScopeSubQuery_VdSynonymVendorRefTargetListMap; }}
        public override String keepVendorTargetId_InScopeSubQuery_VdSynonymVendorRefTargetList(VdSynonymVendorRefTargetCQ subQuery) {
            if (_vendorTargetId_InScopeSubQuery_VdSynonymVendorRefTargetListMap == null) { _vendorTargetId_InScopeSubQuery_VdSynonymVendorRefTargetListMap = new LinkedHashMap<String, VdSynonymVendorRefTargetCQ>(); }
            String key = "subQueryMapKey" + (_vendorTargetId_InScopeSubQuery_VdSynonymVendorRefTargetListMap.size() + 1);
            _vendorTargetId_InScopeSubQuery_VdSynonymVendorRefTargetListMap.put(key, subQuery); return "VendorTargetId_InScopeSubQuery_VdSynonymVendorRefTargetList." + key;
        }

        protected Map<String, VdSynonymVendorRefTargetCQ> _vendorTargetId_NotInScopeSubQuery_VdSynonymVendorRefTargetListMap;
        public Map<String, VdSynonymVendorRefTargetCQ> VendorTargetId_NotInScopeSubQuery_VdSynonymVendorRefTargetList { get { return _vendorTargetId_NotInScopeSubQuery_VdSynonymVendorRefTargetListMap; }}
        public override String keepVendorTargetId_NotInScopeSubQuery_VdSynonymVendorRefTargetList(VdSynonymVendorRefTargetCQ subQuery) {
            if (_vendorTargetId_NotInScopeSubQuery_VdSynonymVendorRefTargetListMap == null) { _vendorTargetId_NotInScopeSubQuery_VdSynonymVendorRefTargetListMap = new LinkedHashMap<String, VdSynonymVendorRefTargetCQ>(); }
            String key = "subQueryMapKey" + (_vendorTargetId_NotInScopeSubQuery_VdSynonymVendorRefTargetListMap.size() + 1);
            _vendorTargetId_NotInScopeSubQuery_VdSynonymVendorRefTargetListMap.put(key, subQuery); return "VendorTargetId_NotInScopeSubQuery_VdSynonymVendorRefTargetList." + key;
        }

        protected Map<String, VdSynonymVendorRefTargetCQ> _vendorTargetId_SpecifyDerivedReferrer_VdSynonymVendorRefTargetListMap;
        public Map<String, VdSynonymVendorRefTargetCQ> VendorTargetId_SpecifyDerivedReferrer_VdSynonymVendorRefTargetList { get { return _vendorTargetId_SpecifyDerivedReferrer_VdSynonymVendorRefTargetListMap; }}
        public override String keepVendorTargetId_SpecifyDerivedReferrer_VdSynonymVendorRefTargetList(VdSynonymVendorRefTargetCQ subQuery) {
            if (_vendorTargetId_SpecifyDerivedReferrer_VdSynonymVendorRefTargetListMap == null) { _vendorTargetId_SpecifyDerivedReferrer_VdSynonymVendorRefTargetListMap = new LinkedHashMap<String, VdSynonymVendorRefTargetCQ>(); }
            String key = "subQueryMapKey" + (_vendorTargetId_SpecifyDerivedReferrer_VdSynonymVendorRefTargetListMap.size() + 1);
            _vendorTargetId_SpecifyDerivedReferrer_VdSynonymVendorRefTargetListMap.put(key, subQuery); return "VendorTargetId_SpecifyDerivedReferrer_VdSynonymVendorRefTargetList." + key;
        }

        protected Map<String, VdSynonymVendorRefTargetCQ> _vendorTargetId_QueryDerivedReferrer_VdSynonymVendorRefTargetListMap;
        public Map<String, VdSynonymVendorRefTargetCQ> VendorTargetId_QueryDerivedReferrer_VdSynonymVendorRefTargetList { get { return _vendorTargetId_QueryDerivedReferrer_VdSynonymVendorRefTargetListMap; } }
        public override String keepVendorTargetId_QueryDerivedReferrer_VdSynonymVendorRefTargetList(VdSynonymVendorRefTargetCQ subQuery) {
            if (_vendorTargetId_QueryDerivedReferrer_VdSynonymVendorRefTargetListMap == null) { _vendorTargetId_QueryDerivedReferrer_VdSynonymVendorRefTargetListMap = new LinkedHashMap<String, VdSynonymVendorRefTargetCQ>(); }
            String key = "subQueryMapKey" + (_vendorTargetId_QueryDerivedReferrer_VdSynonymVendorRefTargetListMap.size() + 1);
            _vendorTargetId_QueryDerivedReferrer_VdSynonymVendorRefTargetListMap.put(key, subQuery); return "VendorTargetId_QueryDerivedReferrer_VdSynonymVendorRefTargetList." + key;
        }
        protected Map<String, Object> _vendorTargetId_QueryDerivedReferrer_VdSynonymVendorRefTargetListParameterMap;
        public Map<String, Object> VendorTargetId_QueryDerivedReferrer_VdSynonymVendorRefTargetListParameter { get { return _vendorTargetId_QueryDerivedReferrer_VdSynonymVendorRefTargetListParameterMap; } }
        public override String keepVendorTargetId_QueryDerivedReferrer_VdSynonymVendorRefTargetListParameter(Object parameterValue) {
            if (_vendorTargetId_QueryDerivedReferrer_VdSynonymVendorRefTargetListParameterMap == null) { _vendorTargetId_QueryDerivedReferrer_VdSynonymVendorRefTargetListParameterMap = new LinkedHashMap<String, Object>(); }
            String key = "subQueryParameterKey" + (_vendorTargetId_QueryDerivedReferrer_VdSynonymVendorRefTargetListParameterMap.size() + 1);
            _vendorTargetId_QueryDerivedReferrer_VdSynonymVendorRefTargetListParameterMap.put(key, parameterValue); return "VendorTargetId_QueryDerivedReferrer_VdSynonymVendorRefTargetListParameter." + key;
        }

        public BsVdSynonymVendorTargetCQ AddOrderBy_VendorTargetId_Asc() { regOBA("VENDOR_TARGET_ID");return this; }
        public BsVdSynonymVendorTargetCQ AddOrderBy_VendorTargetId_Desc() { regOBD("VENDOR_TARGET_ID");return this; }

        protected ConditionValue _vandorTargetName;
        public ConditionValue VandorTargetName {
            get { if (_vandorTargetName == null) { _vandorTargetName = new ConditionValue(); } return _vandorTargetName; }
        }
        protected override ConditionValue getCValueVandorTargetName() { return this.VandorTargetName; }


        public BsVdSynonymVendorTargetCQ AddOrderBy_VandorTargetName_Asc() { regOBA("VANDOR_TARGET_NAME");return this; }
        public BsVdSynonymVendorTargetCQ AddOrderBy_VandorTargetName_Desc() { regOBD("VANDOR_TARGET_NAME");return this; }

        public BsVdSynonymVendorTargetCQ AddSpecifiedDerivedOrderBy_Asc(String aliasName) { registerSpecifiedDerivedOrderBy_Asc(aliasName); return this; }
        public BsVdSynonymVendorTargetCQ AddSpecifiedDerivedOrderBy_Desc(String aliasName) { registerSpecifiedDerivedOrderBy_Desc(aliasName); return this; }

        public override void reflectRelationOnUnionQuery(ConditionQuery baseQueryAsSuper, ConditionQuery unionQueryAsSuper) {

        }
    


	    // ===============================================================================
	    //                                                                 Scalar SubQuery
	    //                                                                 ===============
	    protected Map<String, VdSynonymVendorTargetCQ> _scalarSubQueryMap;
	    public Map<String, VdSynonymVendorTargetCQ> ScalarSubQuery { get { return _scalarSubQueryMap; } }
	    public override String keepScalarSubQuery(VdSynonymVendorTargetCQ subQuery) {
	        if (_scalarSubQueryMap == null) { _scalarSubQueryMap = new LinkedHashMap<String, VdSynonymVendorTargetCQ>(); }
	        String key = "subQueryMapKey" + (_scalarSubQueryMap.size() + 1);
	        _scalarSubQueryMap.put(key, subQuery); return "ScalarSubQuery." + key;
	    }

        // ===============================================================================
        //                                                         Myself InScope SubQuery
        //                                                         =======================
        protected Map<String, VdSynonymVendorTargetCQ> _myselfInScopeSubQueryMap;
        public Map<String, VdSynonymVendorTargetCQ> MyselfInScopeSubQuery { get { return _myselfInScopeSubQueryMap; } }
        public override String keepMyselfInScopeSubQuery(VdSynonymVendorTargetCQ subQuery) {
            if (_myselfInScopeSubQueryMap == null) { _myselfInScopeSubQueryMap = new LinkedHashMap<String, VdSynonymVendorTargetCQ>(); }
            String key = "subQueryMapKey" + (_myselfInScopeSubQueryMap.size() + 1);
            _myselfInScopeSubQueryMap.put(key, subQuery); return "MyselfInScopeSubQuery." + key;
        }
    }
}
