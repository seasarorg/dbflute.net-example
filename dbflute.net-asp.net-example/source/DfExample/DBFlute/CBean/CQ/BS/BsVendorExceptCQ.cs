
using System;

using DfExample.DBFlute.AllCommon.CBean;
using DfExample.DBFlute.AllCommon.CBean.CValue;
using DfExample.DBFlute.AllCommon.CBean.SClause;
using DfExample.DBFlute.AllCommon.JavaLike;
using DfExample.DBFlute.CBean.CQ;
using DfExample.DBFlute.CBean.CQ.Ciq;

namespace DfExample.DBFlute.CBean.CQ.BS {

    [System.Serializable]
    public class BsVendorExceptCQ : AbstractBsVendorExceptCQ {

        protected VendorExceptCIQ _inlineQuery;

        public BsVendorExceptCQ(ConditionQuery childQuery, SqlClause sqlClause, String aliasName, int nestLevel)
            : base(childQuery, sqlClause, aliasName, nestLevel) {}

        public VendorExceptCIQ Inline() {
            if (_inlineQuery == null) {
                _inlineQuery = new VendorExceptCIQ(xgetReferrerQuery(), xgetSqlClause(), xgetAliasName(), xgetNestLevel(), this);
            }
            _inlineQuery.xsetOnClause(false);
            return _inlineQuery;
        }
        
        public VendorExceptCIQ On() {
            if (isBaseQuery()) { throw new UnsupportedOperationException("Unsupported onClause of Base Table!"); }
            VendorExceptCIQ inlineQuery = Inline();
            inlineQuery.xsetOnClause(true);
            return inlineQuery;
        }


        protected ConditionValue _vendorExceptId;
        public ConditionValue VendorExceptId {
            get { if (_vendorExceptId == null) { _vendorExceptId = new ConditionValue(); } return _vendorExceptId; }
        }
        protected override ConditionValue getCValueVendorExceptId() { return this.VendorExceptId; }


        protected Map<String, VendorRefExceptCQ> _vendorExceptId_ExistsSubQuery_VendorRefExceptListMap;
        public Map<String, VendorRefExceptCQ> VendorExceptId_ExistsSubQuery_VendorRefExceptList { get { return _vendorExceptId_ExistsSubQuery_VendorRefExceptListMap; }}
        public override String keepVendorExceptId_ExistsSubQuery_VendorRefExceptList(VendorRefExceptCQ subQuery) {
            if (_vendorExceptId_ExistsSubQuery_VendorRefExceptListMap == null) { _vendorExceptId_ExistsSubQuery_VendorRefExceptListMap = new LinkedHashMap<String, VendorRefExceptCQ>(); }
            String key = "subQueryMapKey" + (_vendorExceptId_ExistsSubQuery_VendorRefExceptListMap.size() + 1);
            _vendorExceptId_ExistsSubQuery_VendorRefExceptListMap.put(key, subQuery); return "VendorExceptId_ExistsSubQuery_VendorRefExceptList." + key;
        }

        protected Map<String, VendorRefExceptCQ> _vendorExceptId_NotExistsSubQuery_VendorRefExceptListMap;
        public Map<String, VendorRefExceptCQ> VendorExceptId_NotExistsSubQuery_VendorRefExceptList { get { return _vendorExceptId_NotExistsSubQuery_VendorRefExceptListMap; }}
        public override String keepVendorExceptId_NotExistsSubQuery_VendorRefExceptList(VendorRefExceptCQ subQuery) {
            if (_vendorExceptId_NotExistsSubQuery_VendorRefExceptListMap == null) { _vendorExceptId_NotExistsSubQuery_VendorRefExceptListMap = new LinkedHashMap<String, VendorRefExceptCQ>(); }
            String key = "subQueryMapKey" + (_vendorExceptId_NotExistsSubQuery_VendorRefExceptListMap.size() + 1);
            _vendorExceptId_NotExistsSubQuery_VendorRefExceptListMap.put(key, subQuery); return "VendorExceptId_NotExistsSubQuery_VendorRefExceptList." + key;
        }

        protected Map<String, VendorRefExceptCQ> _vendorExceptId_InScopeSubQuery_VendorRefExceptListMap;
        public Map<String, VendorRefExceptCQ> VendorExceptId_InScopeSubQuery_VendorRefExceptList { get { return _vendorExceptId_InScopeSubQuery_VendorRefExceptListMap; }}
        public override String keepVendorExceptId_InScopeSubQuery_VendorRefExceptList(VendorRefExceptCQ subQuery) {
            if (_vendorExceptId_InScopeSubQuery_VendorRefExceptListMap == null) { _vendorExceptId_InScopeSubQuery_VendorRefExceptListMap = new LinkedHashMap<String, VendorRefExceptCQ>(); }
            String key = "subQueryMapKey" + (_vendorExceptId_InScopeSubQuery_VendorRefExceptListMap.size() + 1);
            _vendorExceptId_InScopeSubQuery_VendorRefExceptListMap.put(key, subQuery); return "VendorExceptId_InScopeSubQuery_VendorRefExceptList." + key;
        }

        protected Map<String, VendorRefExceptCQ> _vendorExceptId_NotInScopeSubQuery_VendorRefExceptListMap;
        public Map<String, VendorRefExceptCQ> VendorExceptId_NotInScopeSubQuery_VendorRefExceptList { get { return _vendorExceptId_NotInScopeSubQuery_VendorRefExceptListMap; }}
        public override String keepVendorExceptId_NotInScopeSubQuery_VendorRefExceptList(VendorRefExceptCQ subQuery) {
            if (_vendorExceptId_NotInScopeSubQuery_VendorRefExceptListMap == null) { _vendorExceptId_NotInScopeSubQuery_VendorRefExceptListMap = new LinkedHashMap<String, VendorRefExceptCQ>(); }
            String key = "subQueryMapKey" + (_vendorExceptId_NotInScopeSubQuery_VendorRefExceptListMap.size() + 1);
            _vendorExceptId_NotInScopeSubQuery_VendorRefExceptListMap.put(key, subQuery); return "VendorExceptId_NotInScopeSubQuery_VendorRefExceptList." + key;
        }

        protected Map<String, VendorRefExceptCQ> _vendorExceptId_SpecifyDerivedReferrer_VendorRefExceptListMap;
        public Map<String, VendorRefExceptCQ> VendorExceptId_SpecifyDerivedReferrer_VendorRefExceptList { get { return _vendorExceptId_SpecifyDerivedReferrer_VendorRefExceptListMap; }}
        public override String keepVendorExceptId_SpecifyDerivedReferrer_VendorRefExceptList(VendorRefExceptCQ subQuery) {
            if (_vendorExceptId_SpecifyDerivedReferrer_VendorRefExceptListMap == null) { _vendorExceptId_SpecifyDerivedReferrer_VendorRefExceptListMap = new LinkedHashMap<String, VendorRefExceptCQ>(); }
            String key = "subQueryMapKey" + (_vendorExceptId_SpecifyDerivedReferrer_VendorRefExceptListMap.size() + 1);
            _vendorExceptId_SpecifyDerivedReferrer_VendorRefExceptListMap.put(key, subQuery); return "VendorExceptId_SpecifyDerivedReferrer_VendorRefExceptList." + key;
        }

        protected Map<String, VendorRefExceptCQ> _vendorExceptId_QueryDerivedReferrer_VendorRefExceptListMap;
        public Map<String, VendorRefExceptCQ> VendorExceptId_QueryDerivedReferrer_VendorRefExceptList { get { return _vendorExceptId_QueryDerivedReferrer_VendorRefExceptListMap; } }
        public override String keepVendorExceptId_QueryDerivedReferrer_VendorRefExceptList(VendorRefExceptCQ subQuery) {
            if (_vendorExceptId_QueryDerivedReferrer_VendorRefExceptListMap == null) { _vendorExceptId_QueryDerivedReferrer_VendorRefExceptListMap = new LinkedHashMap<String, VendorRefExceptCQ>(); }
            String key = "subQueryMapKey" + (_vendorExceptId_QueryDerivedReferrer_VendorRefExceptListMap.size() + 1);
            _vendorExceptId_QueryDerivedReferrer_VendorRefExceptListMap.put(key, subQuery); return "VendorExceptId_QueryDerivedReferrer_VendorRefExceptList." + key;
        }
        protected Map<String, Object> _vendorExceptId_QueryDerivedReferrer_VendorRefExceptListParameterMap;
        public Map<String, Object> VendorExceptId_QueryDerivedReferrer_VendorRefExceptListParameter { get { return _vendorExceptId_QueryDerivedReferrer_VendorRefExceptListParameterMap; } }
        public override String keepVendorExceptId_QueryDerivedReferrer_VendorRefExceptListParameter(Object parameterValue) {
            if (_vendorExceptId_QueryDerivedReferrer_VendorRefExceptListParameterMap == null) { _vendorExceptId_QueryDerivedReferrer_VendorRefExceptListParameterMap = new LinkedHashMap<String, Object>(); }
            String key = "subQueryParameterKey" + (_vendorExceptId_QueryDerivedReferrer_VendorRefExceptListParameterMap.size() + 1);
            _vendorExceptId_QueryDerivedReferrer_VendorRefExceptListParameterMap.put(key, parameterValue); return "VendorExceptId_QueryDerivedReferrer_VendorRefExceptListParameter." + key;
        }

        public BsVendorExceptCQ AddOrderBy_VendorExceptId_Asc() { regOBA("VENDOR_EXCEPT_ID");return this; }
        public BsVendorExceptCQ AddOrderBy_VendorExceptId_Desc() { regOBD("VENDOR_EXCEPT_ID");return this; }

        protected ConditionValue _vandorExceptName;
        public ConditionValue VandorExceptName {
            get { if (_vandorExceptName == null) { _vandorExceptName = new ConditionValue(); } return _vandorExceptName; }
        }
        protected override ConditionValue getCValueVandorExceptName() { return this.VandorExceptName; }


        public BsVendorExceptCQ AddOrderBy_VandorExceptName_Asc() { regOBA("VANDOR_EXCEPT_NAME");return this; }
        public BsVendorExceptCQ AddOrderBy_VandorExceptName_Desc() { regOBD("VANDOR_EXCEPT_NAME");return this; }

        public BsVendorExceptCQ AddSpecifiedDerivedOrderBy_Asc(String aliasName) { registerSpecifiedDerivedOrderBy_Asc(aliasName); return this; }
        public BsVendorExceptCQ AddSpecifiedDerivedOrderBy_Desc(String aliasName) { registerSpecifiedDerivedOrderBy_Desc(aliasName); return this; }

        public override void reflectRelationOnUnionQuery(ConditionQuery baseQueryAsSuper, ConditionQuery unionQueryAsSuper) {

        }
    


	    // ===============================================================================
	    //                                                                 Scalar SubQuery
	    //                                                                 ===============
	    protected Map<String, VendorExceptCQ> _scalarSubQueryMap;
	    public Map<String, VendorExceptCQ> ScalarSubQuery { get { return _scalarSubQueryMap; } }
	    public override String keepScalarSubQuery(VendorExceptCQ subQuery) {
	        if (_scalarSubQueryMap == null) { _scalarSubQueryMap = new LinkedHashMap<String, VendorExceptCQ>(); }
	        String key = "subQueryMapKey" + (_scalarSubQueryMap.size() + 1);
	        _scalarSubQueryMap.put(key, subQuery); return "ScalarSubQuery." + key;
	    }

        // ===============================================================================
        //                                                         Myself InScope SubQuery
        //                                                         =======================
        protected Map<String, VendorExceptCQ> _myselfInScopeSubQueryMap;
        public Map<String, VendorExceptCQ> MyselfInScopeSubQuery { get { return _myselfInScopeSubQueryMap; } }
        public override String keepMyselfInScopeSubQuery(VendorExceptCQ subQuery) {
            if (_myselfInScopeSubQueryMap == null) { _myselfInScopeSubQueryMap = new LinkedHashMap<String, VendorExceptCQ>(); }
            String key = "subQueryMapKey" + (_myselfInScopeSubQueryMap.size() + 1);
            _myselfInScopeSubQueryMap.put(key, subQuery); return "MyselfInScopeSubQuery." + key;
        }
    }
}
