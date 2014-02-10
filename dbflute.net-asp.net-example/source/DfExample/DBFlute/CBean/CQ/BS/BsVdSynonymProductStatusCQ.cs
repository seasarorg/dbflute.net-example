
using System;

using DfExample.DBFlute.AllCommon.CBean;
using DfExample.DBFlute.AllCommon.CBean.CValue;
using DfExample.DBFlute.AllCommon.CBean.SClause;
using DfExample.DBFlute.AllCommon.JavaLike;
using DfExample.DBFlute.CBean.CQ;
using DfExample.DBFlute.CBean.CQ.Ciq;

namespace DfExample.DBFlute.CBean.CQ.BS {

    [System.Serializable]
    public class BsVdSynonymProductStatusCQ : AbstractBsVdSynonymProductStatusCQ {

        protected VdSynonymProductStatusCIQ _inlineQuery;

        public BsVdSynonymProductStatusCQ(ConditionQuery childQuery, SqlClause sqlClause, String aliasName, int nestLevel)
            : base(childQuery, sqlClause, aliasName, nestLevel) {}

        public VdSynonymProductStatusCIQ Inline() {
            if (_inlineQuery == null) {
                _inlineQuery = new VdSynonymProductStatusCIQ(xgetReferrerQuery(), xgetSqlClause(), xgetAliasName(), xgetNestLevel(), this);
            }
            _inlineQuery.xsetOnClause(false);
            return _inlineQuery;
        }
        
        public VdSynonymProductStatusCIQ On() {
            if (isBaseQuery()) { throw new UnsupportedOperationException("Unsupported onClause of Base Table!"); }
            VdSynonymProductStatusCIQ inlineQuery = Inline();
            inlineQuery.xsetOnClause(true);
            return inlineQuery;
        }


        protected ConditionValue _productStatusCode;
        public ConditionValue ProductStatusCode {
            get { if (_productStatusCode == null) { _productStatusCode = new ConditionValue(); } return _productStatusCode; }
        }
        protected override ConditionValue getCValueProductStatusCode() { return this.ProductStatusCode; }


        protected Map<String, VdSynonymProductCQ> _productStatusCode_ExistsSubQuery_VdSynonymProductListMap;
        public Map<String, VdSynonymProductCQ> ProductStatusCode_ExistsSubQuery_VdSynonymProductList { get { return _productStatusCode_ExistsSubQuery_VdSynonymProductListMap; }}
        public override String keepProductStatusCode_ExistsSubQuery_VdSynonymProductList(VdSynonymProductCQ subQuery) {
            if (_productStatusCode_ExistsSubQuery_VdSynonymProductListMap == null) { _productStatusCode_ExistsSubQuery_VdSynonymProductListMap = new LinkedHashMap<String, VdSynonymProductCQ>(); }
            String key = "subQueryMapKey" + (_productStatusCode_ExistsSubQuery_VdSynonymProductListMap.size() + 1);
            _productStatusCode_ExistsSubQuery_VdSynonymProductListMap.put(key, subQuery); return "ProductStatusCode_ExistsSubQuery_VdSynonymProductList." + key;
        }

        protected Map<String, VdSynonymProductCQ> _productStatusCode_NotExistsSubQuery_VdSynonymProductListMap;
        public Map<String, VdSynonymProductCQ> ProductStatusCode_NotExistsSubQuery_VdSynonymProductList { get { return _productStatusCode_NotExistsSubQuery_VdSynonymProductListMap; }}
        public override String keepProductStatusCode_NotExistsSubQuery_VdSynonymProductList(VdSynonymProductCQ subQuery) {
            if (_productStatusCode_NotExistsSubQuery_VdSynonymProductListMap == null) { _productStatusCode_NotExistsSubQuery_VdSynonymProductListMap = new LinkedHashMap<String, VdSynonymProductCQ>(); }
            String key = "subQueryMapKey" + (_productStatusCode_NotExistsSubQuery_VdSynonymProductListMap.size() + 1);
            _productStatusCode_NotExistsSubQuery_VdSynonymProductListMap.put(key, subQuery); return "ProductStatusCode_NotExistsSubQuery_VdSynonymProductList." + key;
        }

        protected Map<String, VdSynonymProductCQ> _productStatusCode_InScopeSubQuery_VdSynonymProductListMap;
        public Map<String, VdSynonymProductCQ> ProductStatusCode_InScopeSubQuery_VdSynonymProductList { get { return _productStatusCode_InScopeSubQuery_VdSynonymProductListMap; }}
        public override String keepProductStatusCode_InScopeSubQuery_VdSynonymProductList(VdSynonymProductCQ subQuery) {
            if (_productStatusCode_InScopeSubQuery_VdSynonymProductListMap == null) { _productStatusCode_InScopeSubQuery_VdSynonymProductListMap = new LinkedHashMap<String, VdSynonymProductCQ>(); }
            String key = "subQueryMapKey" + (_productStatusCode_InScopeSubQuery_VdSynonymProductListMap.size() + 1);
            _productStatusCode_InScopeSubQuery_VdSynonymProductListMap.put(key, subQuery); return "ProductStatusCode_InScopeSubQuery_VdSynonymProductList." + key;
        }

        protected Map<String, VdSynonymProductCQ> _productStatusCode_NotInScopeSubQuery_VdSynonymProductListMap;
        public Map<String, VdSynonymProductCQ> ProductStatusCode_NotInScopeSubQuery_VdSynonymProductList { get { return _productStatusCode_NotInScopeSubQuery_VdSynonymProductListMap; }}
        public override String keepProductStatusCode_NotInScopeSubQuery_VdSynonymProductList(VdSynonymProductCQ subQuery) {
            if (_productStatusCode_NotInScopeSubQuery_VdSynonymProductListMap == null) { _productStatusCode_NotInScopeSubQuery_VdSynonymProductListMap = new LinkedHashMap<String, VdSynonymProductCQ>(); }
            String key = "subQueryMapKey" + (_productStatusCode_NotInScopeSubQuery_VdSynonymProductListMap.size() + 1);
            _productStatusCode_NotInScopeSubQuery_VdSynonymProductListMap.put(key, subQuery); return "ProductStatusCode_NotInScopeSubQuery_VdSynonymProductList." + key;
        }

        protected Map<String, VdSynonymProductCQ> _productStatusCode_SpecifyDerivedReferrer_VdSynonymProductListMap;
        public Map<String, VdSynonymProductCQ> ProductStatusCode_SpecifyDerivedReferrer_VdSynonymProductList { get { return _productStatusCode_SpecifyDerivedReferrer_VdSynonymProductListMap; }}
        public override String keepProductStatusCode_SpecifyDerivedReferrer_VdSynonymProductList(VdSynonymProductCQ subQuery) {
            if (_productStatusCode_SpecifyDerivedReferrer_VdSynonymProductListMap == null) { _productStatusCode_SpecifyDerivedReferrer_VdSynonymProductListMap = new LinkedHashMap<String, VdSynonymProductCQ>(); }
            String key = "subQueryMapKey" + (_productStatusCode_SpecifyDerivedReferrer_VdSynonymProductListMap.size() + 1);
           _productStatusCode_SpecifyDerivedReferrer_VdSynonymProductListMap.put(key, subQuery); return "ProductStatusCode_SpecifyDerivedReferrer_VdSynonymProductList." + key;
        }

        protected Map<String, VdSynonymProductCQ> _productStatusCode_QueryDerivedReferrer_VdSynonymProductListMap;
        public Map<String, VdSynonymProductCQ> ProductStatusCode_QueryDerivedReferrer_VdSynonymProductList { get { return _productStatusCode_QueryDerivedReferrer_VdSynonymProductListMap; } }
        public override String keepProductStatusCode_QueryDerivedReferrer_VdSynonymProductList(VdSynonymProductCQ subQuery) {
            if (_productStatusCode_QueryDerivedReferrer_VdSynonymProductListMap == null) { _productStatusCode_QueryDerivedReferrer_VdSynonymProductListMap = new LinkedHashMap<String, VdSynonymProductCQ>(); }
            String key = "subQueryMapKey" + (_productStatusCode_QueryDerivedReferrer_VdSynonymProductListMap.size() + 1);
            _productStatusCode_QueryDerivedReferrer_VdSynonymProductListMap.put(key, subQuery); return "ProductStatusCode_QueryDerivedReferrer_VdSynonymProductList." + key;
        }
        protected Map<String, Object> _productStatusCode_QueryDerivedReferrer_VdSynonymProductListParameterMap;
        public Map<String, Object> ProductStatusCode_QueryDerivedReferrer_VdSynonymProductListParameter { get { return _productStatusCode_QueryDerivedReferrer_VdSynonymProductListParameterMap; } }
        public override String keepProductStatusCode_QueryDerivedReferrer_VdSynonymProductListParameter(Object parameterValue) {
            if (_productStatusCode_QueryDerivedReferrer_VdSynonymProductListParameterMap == null) { _productStatusCode_QueryDerivedReferrer_VdSynonymProductListParameterMap = new LinkedHashMap<String, Object>(); }
            String key = "subQueryParameterKey" + (_productStatusCode_QueryDerivedReferrer_VdSynonymProductListParameterMap.size() + 1);
            _productStatusCode_QueryDerivedReferrer_VdSynonymProductListParameterMap.put(key, parameterValue); return "ProductStatusCode_QueryDerivedReferrer_VdSynonymProductListParameter." + key;
        }

        public BsVdSynonymProductStatusCQ AddOrderBy_ProductStatusCode_Asc() { regOBA("PRODUCT_STATUS_CODE");return this; }
        public BsVdSynonymProductStatusCQ AddOrderBy_ProductStatusCode_Desc() { regOBD("PRODUCT_STATUS_CODE");return this; }

        protected ConditionValue _productStatusName;
        public ConditionValue ProductStatusName {
            get { if (_productStatusName == null) { _productStatusName = new ConditionValue(); } return _productStatusName; }
        }
        protected override ConditionValue getCValueProductStatusName() { return this.ProductStatusName; }


        public BsVdSynonymProductStatusCQ AddOrderBy_ProductStatusName_Asc() { regOBA("PRODUCT_STATUS_NAME");return this; }
        public BsVdSynonymProductStatusCQ AddOrderBy_ProductStatusName_Desc() { regOBD("PRODUCT_STATUS_NAME");return this; }

        public BsVdSynonymProductStatusCQ AddSpecifiedDerivedOrderBy_Asc(String aliasName) { registerSpecifiedDerivedOrderBy_Asc(aliasName); return this; }
        public BsVdSynonymProductStatusCQ AddSpecifiedDerivedOrderBy_Desc(String aliasName) { registerSpecifiedDerivedOrderBy_Desc(aliasName); return this; }

        public override void reflectRelationOnUnionQuery(ConditionQuery baseQueryAsSuper, ConditionQuery unionQueryAsSuper) {

        }
    


	    // ===============================================================================
	    //                                                                 Scalar SubQuery
	    //                                                                 ===============
	    protected Map<String, VdSynonymProductStatusCQ> _scalarSubQueryMap;
	    public Map<String, VdSynonymProductStatusCQ> ScalarSubQuery { get { return _scalarSubQueryMap; } }
	    public override String keepScalarSubQuery(VdSynonymProductStatusCQ subQuery) {
	        if (_scalarSubQueryMap == null) { _scalarSubQueryMap = new LinkedHashMap<String, VdSynonymProductStatusCQ>(); }
	        String key = "subQueryMapKey" + (_scalarSubQueryMap.size() + 1);
	        _scalarSubQueryMap.put(key, subQuery); return "ScalarSubQuery." + key;
	    }

        // ===============================================================================
        //                                                         Myself InScope SubQuery
        //                                                         =======================
        protected Map<String, VdSynonymProductStatusCQ> _myselfInScopeSubQueryMap;
        public Map<String, VdSynonymProductStatusCQ> MyselfInScopeSubQuery { get { return _myselfInScopeSubQueryMap; } }
        public override String keepMyselfInScopeSubQuery(VdSynonymProductStatusCQ subQuery) {
            if (_myselfInScopeSubQueryMap == null) { _myselfInScopeSubQueryMap = new LinkedHashMap<String, VdSynonymProductStatusCQ>(); }
            String key = "subQueryMapKey" + (_myselfInScopeSubQueryMap.size() + 1);
            _myselfInScopeSubQueryMap.put(key, subQuery); return "MyselfInScopeSubQuery." + key;
        }
    }
}
