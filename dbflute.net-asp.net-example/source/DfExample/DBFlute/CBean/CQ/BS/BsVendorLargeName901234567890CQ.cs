
using System;

using DfExample.DBFlute.AllCommon.CBean;
using DfExample.DBFlute.AllCommon.CBean.CValue;
using DfExample.DBFlute.AllCommon.CBean.SClause;
using DfExample.DBFlute.AllCommon.JavaLike;
using DfExample.DBFlute.CBean.CQ;
using DfExample.DBFlute.CBean.CQ.Ciq;

namespace DfExample.DBFlute.CBean.CQ.BS {

    [System.Serializable]
    public class BsVendorLargeName901234567890CQ : AbstractBsVendorLargeName901234567890CQ {

        protected VendorLargeName901234567890CIQ _inlineQuery;

        public BsVendorLargeName901234567890CQ(ConditionQuery childQuery, SqlClause sqlClause, String aliasName, int nestLevel)
            : base(childQuery, sqlClause, aliasName, nestLevel) {}

        public VendorLargeName901234567890CIQ Inline() {
            if (_inlineQuery == null) {
                _inlineQuery = new VendorLargeName901234567890CIQ(xgetReferrerQuery(), xgetSqlClause(), xgetAliasName(), xgetNestLevel(), this);
            }
            _inlineQuery.xsetOnClause(false);
            return _inlineQuery;
        }
        
        public VendorLargeName901234567890CIQ On() {
            if (isBaseQuery()) { throw new UnsupportedOperationException("Unsupported onClause of Base Table!"); }
            VendorLargeName901234567890CIQ inlineQuery = Inline();
            inlineQuery.xsetOnClause(true);
            return inlineQuery;
        }


        protected ConditionValue _vendorLargeName901234567Id;
        public ConditionValue VendorLargeName901234567Id {
            get { if (_vendorLargeName901234567Id == null) { _vendorLargeName901234567Id = new ConditionValue(); } return _vendorLargeName901234567Id; }
        }
        protected override ConditionValue getCValueVendorLargeName901234567Id() { return this.VendorLargeName901234567Id; }


        protected Map<String, VendorLargeName90123456RefCQ> _vendorLargeName901234567Id_ExistsSubQuery_VendorLargeName90123456RefListMap;
        public Map<String, VendorLargeName90123456RefCQ> VendorLargeName901234567Id_ExistsSubQuery_VendorLargeName90123456RefList { get { return _vendorLargeName901234567Id_ExistsSubQuery_VendorLargeName90123456RefListMap; }}
        public override String keepVendorLargeName901234567Id_ExistsSubQuery_VendorLargeName90123456RefList(VendorLargeName90123456RefCQ subQuery) {
            if (_vendorLargeName901234567Id_ExistsSubQuery_VendorLargeName90123456RefListMap == null) { _vendorLargeName901234567Id_ExistsSubQuery_VendorLargeName90123456RefListMap = new LinkedHashMap<String, VendorLargeName90123456RefCQ>(); }
            String key = "subQueryMapKey" + (_vendorLargeName901234567Id_ExistsSubQuery_VendorLargeName90123456RefListMap.size() + 1);
            _vendorLargeName901234567Id_ExistsSubQuery_VendorLargeName90123456RefListMap.put(key, subQuery); return "VendorLargeName901234567Id_ExistsSubQuery_VendorLargeName90123456RefList." + key;
        }

        protected Map<String, VendorLargeName90123456RefCQ> _vendorLargeName901234567Id_NotExistsSubQuery_VendorLargeName90123456RefListMap;
        public Map<String, VendorLargeName90123456RefCQ> VendorLargeName901234567Id_NotExistsSubQuery_VendorLargeName90123456RefList { get { return _vendorLargeName901234567Id_NotExistsSubQuery_VendorLargeName90123456RefListMap; }}
        public override String keepVendorLargeName901234567Id_NotExistsSubQuery_VendorLargeName90123456RefList(VendorLargeName90123456RefCQ subQuery) {
            if (_vendorLargeName901234567Id_NotExistsSubQuery_VendorLargeName90123456RefListMap == null) { _vendorLargeName901234567Id_NotExistsSubQuery_VendorLargeName90123456RefListMap = new LinkedHashMap<String, VendorLargeName90123456RefCQ>(); }
            String key = "subQueryMapKey" + (_vendorLargeName901234567Id_NotExistsSubQuery_VendorLargeName90123456RefListMap.size() + 1);
            _vendorLargeName901234567Id_NotExistsSubQuery_VendorLargeName90123456RefListMap.put(key, subQuery); return "VendorLargeName901234567Id_NotExistsSubQuery_VendorLargeName90123456RefList." + key;
        }

        protected Map<String, VendorLargeName90123456RefCQ> _vendorLargeName901234567Id_InScopeSubQuery_VendorLargeName90123456RefListMap;
        public Map<String, VendorLargeName90123456RefCQ> VendorLargeName901234567Id_InScopeSubQuery_VendorLargeName90123456RefList { get { return _vendorLargeName901234567Id_InScopeSubQuery_VendorLargeName90123456RefListMap; }}
        public override String keepVendorLargeName901234567Id_InScopeSubQuery_VendorLargeName90123456RefList(VendorLargeName90123456RefCQ subQuery) {
            if (_vendorLargeName901234567Id_InScopeSubQuery_VendorLargeName90123456RefListMap == null) { _vendorLargeName901234567Id_InScopeSubQuery_VendorLargeName90123456RefListMap = new LinkedHashMap<String, VendorLargeName90123456RefCQ>(); }
            String key = "subQueryMapKey" + (_vendorLargeName901234567Id_InScopeSubQuery_VendorLargeName90123456RefListMap.size() + 1);
            _vendorLargeName901234567Id_InScopeSubQuery_VendorLargeName90123456RefListMap.put(key, subQuery); return "VendorLargeName901234567Id_InScopeSubQuery_VendorLargeName90123456RefList." + key;
        }

        protected Map<String, VendorLargeName90123456RefCQ> _vendorLargeName901234567Id_NotInScopeSubQuery_VendorLargeName90123456RefListMap;
        public Map<String, VendorLargeName90123456RefCQ> VendorLargeName901234567Id_NotInScopeSubQuery_VendorLargeName90123456RefList { get { return _vendorLargeName901234567Id_NotInScopeSubQuery_VendorLargeName90123456RefListMap; }}
        public override String keepVendorLargeName901234567Id_NotInScopeSubQuery_VendorLargeName90123456RefList(VendorLargeName90123456RefCQ subQuery) {
            if (_vendorLargeName901234567Id_NotInScopeSubQuery_VendorLargeName90123456RefListMap == null) { _vendorLargeName901234567Id_NotInScopeSubQuery_VendorLargeName90123456RefListMap = new LinkedHashMap<String, VendorLargeName90123456RefCQ>(); }
            String key = "subQueryMapKey" + (_vendorLargeName901234567Id_NotInScopeSubQuery_VendorLargeName90123456RefListMap.size() + 1);
            _vendorLargeName901234567Id_NotInScopeSubQuery_VendorLargeName90123456RefListMap.put(key, subQuery); return "VendorLargeName901234567Id_NotInScopeSubQuery_VendorLargeName90123456RefList." + key;
        }

        protected Map<String, VendorLargeName90123456RefCQ> _vendorLargeName901234567Id_SpecifyDerivedReferrer_VendorLargeName90123456RefListMap;
        public Map<String, VendorLargeName90123456RefCQ> VendorLargeName901234567Id_SpecifyDerivedReferrer_VendorLargeName90123456RefList { get { return _vendorLargeName901234567Id_SpecifyDerivedReferrer_VendorLargeName90123456RefListMap; }}
        public override String keepVendorLargeName901234567Id_SpecifyDerivedReferrer_VendorLargeName90123456RefList(VendorLargeName90123456RefCQ subQuery) {
            if (_vendorLargeName901234567Id_SpecifyDerivedReferrer_VendorLargeName90123456RefListMap == null) { _vendorLargeName901234567Id_SpecifyDerivedReferrer_VendorLargeName90123456RefListMap = new LinkedHashMap<String, VendorLargeName90123456RefCQ>(); }
            String key = "subQueryMapKey" + (_vendorLargeName901234567Id_SpecifyDerivedReferrer_VendorLargeName90123456RefListMap.size() + 1);
            _vendorLargeName901234567Id_SpecifyDerivedReferrer_VendorLargeName90123456RefListMap.put(key, subQuery); return "VendorLargeName901234567Id_SpecifyDerivedReferrer_VendorLargeName90123456RefList." + key;
        }

        protected Map<String, VendorLargeName90123456RefCQ> _vendorLargeName901234567Id_QueryDerivedReferrer_VendorLargeName90123456RefListMap;
        public Map<String, VendorLargeName90123456RefCQ> VendorLargeName901234567Id_QueryDerivedReferrer_VendorLargeName90123456RefList { get { return _vendorLargeName901234567Id_QueryDerivedReferrer_VendorLargeName90123456RefListMap; } }
        public override String keepVendorLargeName901234567Id_QueryDerivedReferrer_VendorLargeName90123456RefList(VendorLargeName90123456RefCQ subQuery) {
            if (_vendorLargeName901234567Id_QueryDerivedReferrer_VendorLargeName90123456RefListMap == null) { _vendorLargeName901234567Id_QueryDerivedReferrer_VendorLargeName90123456RefListMap = new LinkedHashMap<String, VendorLargeName90123456RefCQ>(); }
            String key = "subQueryMapKey" + (_vendorLargeName901234567Id_QueryDerivedReferrer_VendorLargeName90123456RefListMap.size() + 1);
            _vendorLargeName901234567Id_QueryDerivedReferrer_VendorLargeName90123456RefListMap.put(key, subQuery); return "VendorLargeName901234567Id_QueryDerivedReferrer_VendorLargeName90123456RefList." + key;
        }
        protected Map<String, Object> _vendorLargeName901234567Id_QueryDerivedReferrer_VendorLargeName90123456RefListParameterMap;
        public Map<String, Object> VendorLargeName901234567Id_QueryDerivedReferrer_VendorLargeName90123456RefListParameter { get { return _vendorLargeName901234567Id_QueryDerivedReferrer_VendorLargeName90123456RefListParameterMap; } }
        public override String keepVendorLargeName901234567Id_QueryDerivedReferrer_VendorLargeName90123456RefListParameter(Object parameterValue) {
            if (_vendorLargeName901234567Id_QueryDerivedReferrer_VendorLargeName90123456RefListParameterMap == null) { _vendorLargeName901234567Id_QueryDerivedReferrer_VendorLargeName90123456RefListParameterMap = new LinkedHashMap<String, Object>(); }
            String key = "subQueryParameterKey" + (_vendorLargeName901234567Id_QueryDerivedReferrer_VendorLargeName90123456RefListParameterMap.size() + 1);
            _vendorLargeName901234567Id_QueryDerivedReferrer_VendorLargeName90123456RefListParameterMap.put(key, parameterValue); return "VendorLargeName901234567Id_QueryDerivedReferrer_VendorLargeName90123456RefListParameter." + key;
        }

        public BsVendorLargeName901234567890CQ AddOrderBy_VendorLargeName901234567Id_Asc() { regOBA("VENDOR_LARGE_NAME_901234567_ID");return this; }
        public BsVendorLargeName901234567890CQ AddOrderBy_VendorLargeName901234567Id_Desc() { regOBD("VENDOR_LARGE_NAME_901234567_ID");return this; }

        protected ConditionValue _vendorLargeName9012345Name;
        public ConditionValue VendorLargeName9012345Name {
            get { if (_vendorLargeName9012345Name == null) { _vendorLargeName9012345Name = new ConditionValue(); } return _vendorLargeName9012345Name; }
        }
        protected override ConditionValue getCValueVendorLargeName9012345Name() { return this.VendorLargeName9012345Name; }


        public BsVendorLargeName901234567890CQ AddOrderBy_VendorLargeName9012345Name_Asc() { regOBA("VENDOR_LARGE_NAME_9012345_NAME");return this; }
        public BsVendorLargeName901234567890CQ AddOrderBy_VendorLargeName9012345Name_Desc() { regOBD("VENDOR_LARGE_NAME_9012345_NAME");return this; }

        public BsVendorLargeName901234567890CQ AddSpecifiedDerivedOrderBy_Asc(String aliasName) { registerSpecifiedDerivedOrderBy_Asc(aliasName); return this; }
        public BsVendorLargeName901234567890CQ AddSpecifiedDerivedOrderBy_Desc(String aliasName) { registerSpecifiedDerivedOrderBy_Desc(aliasName); return this; }

        public override void reflectRelationOnUnionQuery(ConditionQuery baseQueryAsSuper, ConditionQuery unionQueryAsSuper) {

        }
    


	    // ===============================================================================
	    //                                                                 Scalar SubQuery
	    //                                                                 ===============
	    protected Map<String, VendorLargeName901234567890CQ> _scalarSubQueryMap;
	    public Map<String, VendorLargeName901234567890CQ> ScalarSubQuery { get { return _scalarSubQueryMap; } }
	    public override String keepScalarSubQuery(VendorLargeName901234567890CQ subQuery) {
	        if (_scalarSubQueryMap == null) { _scalarSubQueryMap = new LinkedHashMap<String, VendorLargeName901234567890CQ>(); }
	        String key = "subQueryMapKey" + (_scalarSubQueryMap.size() + 1);
	        _scalarSubQueryMap.put(key, subQuery); return "ScalarSubQuery." + key;
	    }

        // ===============================================================================
        //                                                         Myself InScope SubQuery
        //                                                         =======================
        protected Map<String, VendorLargeName901234567890CQ> _myselfInScopeSubQueryMap;
        public Map<String, VendorLargeName901234567890CQ> MyselfInScopeSubQuery { get { return _myselfInScopeSubQueryMap; } }
        public override String keepMyselfInScopeSubQuery(VendorLargeName901234567890CQ subQuery) {
            if (_myselfInScopeSubQueryMap == null) { _myselfInScopeSubQueryMap = new LinkedHashMap<String, VendorLargeName901234567890CQ>(); }
            String key = "subQueryMapKey" + (_myselfInScopeSubQueryMap.size() + 1);
            _myselfInScopeSubQueryMap.put(key, subQuery); return "MyselfInScopeSubQuery." + key;
        }
    }
}
