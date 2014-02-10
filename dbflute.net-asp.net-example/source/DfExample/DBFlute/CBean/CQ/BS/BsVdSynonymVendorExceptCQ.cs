
using System;

using DfExample.DBFlute.AllCommon.CBean;
using DfExample.DBFlute.AllCommon.CBean.CValue;
using DfExample.DBFlute.AllCommon.CBean.SClause;
using DfExample.DBFlute.AllCommon.JavaLike;
using DfExample.DBFlute.CBean.CQ;
using DfExample.DBFlute.CBean.CQ.Ciq;

namespace DfExample.DBFlute.CBean.CQ.BS {

    [System.Serializable]
    public class BsVdSynonymVendorExceptCQ : AbstractBsVdSynonymVendorExceptCQ {

        protected VdSynonymVendorExceptCIQ _inlineQuery;

        public BsVdSynonymVendorExceptCQ(ConditionQuery childQuery, SqlClause sqlClause, String aliasName, int nestLevel)
            : base(childQuery, sqlClause, aliasName, nestLevel) {}

        public VdSynonymVendorExceptCIQ Inline() {
            if (_inlineQuery == null) {
                _inlineQuery = new VdSynonymVendorExceptCIQ(xgetReferrerQuery(), xgetSqlClause(), xgetAliasName(), xgetNestLevel(), this);
            }
            _inlineQuery.xsetOnClause(false);
            return _inlineQuery;
        }
        
        public VdSynonymVendorExceptCIQ On() {
            if (isBaseQuery()) { throw new UnsupportedOperationException("Unsupported onClause of Base Table!"); }
            VdSynonymVendorExceptCIQ inlineQuery = Inline();
            inlineQuery.xsetOnClause(true);
            return inlineQuery;
        }


        protected ConditionValue _vendorExceptId;
        public ConditionValue VendorExceptId {
            get { if (_vendorExceptId == null) { _vendorExceptId = new ConditionValue(); } return _vendorExceptId; }
        }
        protected override ConditionValue getCValueVendorExceptId() { return this.VendorExceptId; }


        protected Map<String, VdSynonymVendorRefExceptCQ> _vendorExceptId_ExistsSubQuery_VdSynonymVendorRefExceptListMap;
        public Map<String, VdSynonymVendorRefExceptCQ> VendorExceptId_ExistsSubQuery_VdSynonymVendorRefExceptList { get { return _vendorExceptId_ExistsSubQuery_VdSynonymVendorRefExceptListMap; }}
        public override String keepVendorExceptId_ExistsSubQuery_VdSynonymVendorRefExceptList(VdSynonymVendorRefExceptCQ subQuery) {
            if (_vendorExceptId_ExistsSubQuery_VdSynonymVendorRefExceptListMap == null) { _vendorExceptId_ExistsSubQuery_VdSynonymVendorRefExceptListMap = new LinkedHashMap<String, VdSynonymVendorRefExceptCQ>(); }
            String key = "subQueryMapKey" + (_vendorExceptId_ExistsSubQuery_VdSynonymVendorRefExceptListMap.size() + 1);
            _vendorExceptId_ExistsSubQuery_VdSynonymVendorRefExceptListMap.put(key, subQuery); return "VendorExceptId_ExistsSubQuery_VdSynonymVendorRefExceptList." + key;
        }

        protected Map<String, VdSynonymVendorRefExceptCQ> _vendorExceptId_NotExistsSubQuery_VdSynonymVendorRefExceptListMap;
        public Map<String, VdSynonymVendorRefExceptCQ> VendorExceptId_NotExistsSubQuery_VdSynonymVendorRefExceptList { get { return _vendorExceptId_NotExistsSubQuery_VdSynonymVendorRefExceptListMap; }}
        public override String keepVendorExceptId_NotExistsSubQuery_VdSynonymVendorRefExceptList(VdSynonymVendorRefExceptCQ subQuery) {
            if (_vendorExceptId_NotExistsSubQuery_VdSynonymVendorRefExceptListMap == null) { _vendorExceptId_NotExistsSubQuery_VdSynonymVendorRefExceptListMap = new LinkedHashMap<String, VdSynonymVendorRefExceptCQ>(); }
            String key = "subQueryMapKey" + (_vendorExceptId_NotExistsSubQuery_VdSynonymVendorRefExceptListMap.size() + 1);
            _vendorExceptId_NotExistsSubQuery_VdSynonymVendorRefExceptListMap.put(key, subQuery); return "VendorExceptId_NotExistsSubQuery_VdSynonymVendorRefExceptList." + key;
        }

        protected Map<String, VdSynonymVendorRefExceptCQ> _vendorExceptId_InScopeSubQuery_VdSynonymVendorRefExceptListMap;
        public Map<String, VdSynonymVendorRefExceptCQ> VendorExceptId_InScopeSubQuery_VdSynonymVendorRefExceptList { get { return _vendorExceptId_InScopeSubQuery_VdSynonymVendorRefExceptListMap; }}
        public override String keepVendorExceptId_InScopeSubQuery_VdSynonymVendorRefExceptList(VdSynonymVendorRefExceptCQ subQuery) {
            if (_vendorExceptId_InScopeSubQuery_VdSynonymVendorRefExceptListMap == null) { _vendorExceptId_InScopeSubQuery_VdSynonymVendorRefExceptListMap = new LinkedHashMap<String, VdSynonymVendorRefExceptCQ>(); }
            String key = "subQueryMapKey" + (_vendorExceptId_InScopeSubQuery_VdSynonymVendorRefExceptListMap.size() + 1);
            _vendorExceptId_InScopeSubQuery_VdSynonymVendorRefExceptListMap.put(key, subQuery); return "VendorExceptId_InScopeSubQuery_VdSynonymVendorRefExceptList." + key;
        }

        protected Map<String, VdSynonymVendorRefExceptCQ> _vendorExceptId_NotInScopeSubQuery_VdSynonymVendorRefExceptListMap;
        public Map<String, VdSynonymVendorRefExceptCQ> VendorExceptId_NotInScopeSubQuery_VdSynonymVendorRefExceptList { get { return _vendorExceptId_NotInScopeSubQuery_VdSynonymVendorRefExceptListMap; }}
        public override String keepVendorExceptId_NotInScopeSubQuery_VdSynonymVendorRefExceptList(VdSynonymVendorRefExceptCQ subQuery) {
            if (_vendorExceptId_NotInScopeSubQuery_VdSynonymVendorRefExceptListMap == null) { _vendorExceptId_NotInScopeSubQuery_VdSynonymVendorRefExceptListMap = new LinkedHashMap<String, VdSynonymVendorRefExceptCQ>(); }
            String key = "subQueryMapKey" + (_vendorExceptId_NotInScopeSubQuery_VdSynonymVendorRefExceptListMap.size() + 1);
            _vendorExceptId_NotInScopeSubQuery_VdSynonymVendorRefExceptListMap.put(key, subQuery); return "VendorExceptId_NotInScopeSubQuery_VdSynonymVendorRefExceptList." + key;
        }

        protected Map<String, VdSynonymVendorRefExceptCQ> _vendorExceptId_SpecifyDerivedReferrer_VdSynonymVendorRefExceptListMap;
        public Map<String, VdSynonymVendorRefExceptCQ> VendorExceptId_SpecifyDerivedReferrer_VdSynonymVendorRefExceptList { get { return _vendorExceptId_SpecifyDerivedReferrer_VdSynonymVendorRefExceptListMap; }}
        public override String keepVendorExceptId_SpecifyDerivedReferrer_VdSynonymVendorRefExceptList(VdSynonymVendorRefExceptCQ subQuery) {
            if (_vendorExceptId_SpecifyDerivedReferrer_VdSynonymVendorRefExceptListMap == null) { _vendorExceptId_SpecifyDerivedReferrer_VdSynonymVendorRefExceptListMap = new LinkedHashMap<String, VdSynonymVendorRefExceptCQ>(); }
            String key = "subQueryMapKey" + (_vendorExceptId_SpecifyDerivedReferrer_VdSynonymVendorRefExceptListMap.size() + 1);
            _vendorExceptId_SpecifyDerivedReferrer_VdSynonymVendorRefExceptListMap.put(key, subQuery); return "VendorExceptId_SpecifyDerivedReferrer_VdSynonymVendorRefExceptList." + key;
        }

        protected Map<String, VdSynonymVendorRefExceptCQ> _vendorExceptId_QueryDerivedReferrer_VdSynonymVendorRefExceptListMap;
        public Map<String, VdSynonymVendorRefExceptCQ> VendorExceptId_QueryDerivedReferrer_VdSynonymVendorRefExceptList { get { return _vendorExceptId_QueryDerivedReferrer_VdSynonymVendorRefExceptListMap; } }
        public override String keepVendorExceptId_QueryDerivedReferrer_VdSynonymVendorRefExceptList(VdSynonymVendorRefExceptCQ subQuery) {
            if (_vendorExceptId_QueryDerivedReferrer_VdSynonymVendorRefExceptListMap == null) { _vendorExceptId_QueryDerivedReferrer_VdSynonymVendorRefExceptListMap = new LinkedHashMap<String, VdSynonymVendorRefExceptCQ>(); }
            String key = "subQueryMapKey" + (_vendorExceptId_QueryDerivedReferrer_VdSynonymVendorRefExceptListMap.size() + 1);
            _vendorExceptId_QueryDerivedReferrer_VdSynonymVendorRefExceptListMap.put(key, subQuery); return "VendorExceptId_QueryDerivedReferrer_VdSynonymVendorRefExceptList." + key;
        }
        protected Map<String, Object> _vendorExceptId_QueryDerivedReferrer_VdSynonymVendorRefExceptListParameterMap;
        public Map<String, Object> VendorExceptId_QueryDerivedReferrer_VdSynonymVendorRefExceptListParameter { get { return _vendorExceptId_QueryDerivedReferrer_VdSynonymVendorRefExceptListParameterMap; } }
        public override String keepVendorExceptId_QueryDerivedReferrer_VdSynonymVendorRefExceptListParameter(Object parameterValue) {
            if (_vendorExceptId_QueryDerivedReferrer_VdSynonymVendorRefExceptListParameterMap == null) { _vendorExceptId_QueryDerivedReferrer_VdSynonymVendorRefExceptListParameterMap = new LinkedHashMap<String, Object>(); }
            String key = "subQueryParameterKey" + (_vendorExceptId_QueryDerivedReferrer_VdSynonymVendorRefExceptListParameterMap.size() + 1);
            _vendorExceptId_QueryDerivedReferrer_VdSynonymVendorRefExceptListParameterMap.put(key, parameterValue); return "VendorExceptId_QueryDerivedReferrer_VdSynonymVendorRefExceptListParameter." + key;
        }

        public BsVdSynonymVendorExceptCQ AddOrderBy_VendorExceptId_Asc() { regOBA("VENDOR_EXCEPT_ID");return this; }
        public BsVdSynonymVendorExceptCQ AddOrderBy_VendorExceptId_Desc() { regOBD("VENDOR_EXCEPT_ID");return this; }

        protected ConditionValue _vandorExceptName;
        public ConditionValue VandorExceptName {
            get { if (_vandorExceptName == null) { _vandorExceptName = new ConditionValue(); } return _vandorExceptName; }
        }
        protected override ConditionValue getCValueVandorExceptName() { return this.VandorExceptName; }


        public BsVdSynonymVendorExceptCQ AddOrderBy_VandorExceptName_Asc() { regOBA("VANDOR_EXCEPT_NAME");return this; }
        public BsVdSynonymVendorExceptCQ AddOrderBy_VandorExceptName_Desc() { regOBD("VANDOR_EXCEPT_NAME");return this; }

        public BsVdSynonymVendorExceptCQ AddSpecifiedDerivedOrderBy_Asc(String aliasName) { registerSpecifiedDerivedOrderBy_Asc(aliasName); return this; }
        public BsVdSynonymVendorExceptCQ AddSpecifiedDerivedOrderBy_Desc(String aliasName) { registerSpecifiedDerivedOrderBy_Desc(aliasName); return this; }

        public override void reflectRelationOnUnionQuery(ConditionQuery baseQueryAsSuper, ConditionQuery unionQueryAsSuper) {

        }
    


	    // ===============================================================================
	    //                                                                 Scalar SubQuery
	    //                                                                 ===============
	    protected Map<String, VdSynonymVendorExceptCQ> _scalarSubQueryMap;
	    public Map<String, VdSynonymVendorExceptCQ> ScalarSubQuery { get { return _scalarSubQueryMap; } }
	    public override String keepScalarSubQuery(VdSynonymVendorExceptCQ subQuery) {
	        if (_scalarSubQueryMap == null) { _scalarSubQueryMap = new LinkedHashMap<String, VdSynonymVendorExceptCQ>(); }
	        String key = "subQueryMapKey" + (_scalarSubQueryMap.size() + 1);
	        _scalarSubQueryMap.put(key, subQuery); return "ScalarSubQuery." + key;
	    }

        // ===============================================================================
        //                                                         Myself InScope SubQuery
        //                                                         =======================
        protected Map<String, VdSynonymVendorExceptCQ> _myselfInScopeSubQueryMap;
        public Map<String, VdSynonymVendorExceptCQ> MyselfInScopeSubQuery { get { return _myselfInScopeSubQueryMap; } }
        public override String keepMyselfInScopeSubQuery(VdSynonymVendorExceptCQ subQuery) {
            if (_myselfInScopeSubQueryMap == null) { _myselfInScopeSubQueryMap = new LinkedHashMap<String, VdSynonymVendorExceptCQ>(); }
            String key = "subQueryMapKey" + (_myselfInScopeSubQueryMap.size() + 1);
            _myselfInScopeSubQueryMap.put(key, subQuery); return "MyselfInScopeSubQuery." + key;
        }
    }
}
