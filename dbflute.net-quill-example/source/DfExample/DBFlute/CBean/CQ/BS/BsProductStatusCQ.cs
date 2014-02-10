
using System;

using DfExample.DBFlute.AllCommon.CBean;
using DfExample.DBFlute.AllCommon.CBean.CValue;
using DfExample.DBFlute.AllCommon.CBean.SClause;
using DfExample.DBFlute.AllCommon.JavaLike;
using DfExample.DBFlute.CBean.CQ;
using DfExample.DBFlute.CBean.CQ.Ciq;

namespace DfExample.DBFlute.CBean.CQ.BS {

    [System.Serializable]
    public class BsProductStatusCQ : AbstractBsProductStatusCQ {

        protected ProductStatusCIQ _inlineQuery;

        public BsProductStatusCQ(ConditionQuery childQuery, SqlClause sqlClause, String aliasName, int nestLevel)
            : base(childQuery, sqlClause, aliasName, nestLevel) {}

        public ProductStatusCIQ Inline() {
            if (_inlineQuery == null) {
                _inlineQuery = new ProductStatusCIQ(xgetReferrerQuery(), xgetSqlClause(), xgetAliasName(), xgetNestLevel(), this);
            }
            _inlineQuery.xsetOnClause(false);
            return _inlineQuery;
        }
        
        public ProductStatusCIQ On() {
            if (isBaseQuery()) { throw new UnsupportedOperationException("Unsupported onClause of Base Table!"); }
            ProductStatusCIQ inlineQuery = Inline();
            inlineQuery.xsetOnClause(true);
            return inlineQuery;
        }


        protected ConditionValue _productStatusCode;
        public ConditionValue ProductStatusCode {
            get { if (_productStatusCode == null) { _productStatusCode = new ConditionValue(); } return _productStatusCode; }
        }
        protected override ConditionValue getCValueProductStatusCode() { return this.ProductStatusCode; }


        protected Map<String, ProductCQ> _productStatusCode_ExistsSubQuery_ProductListMap;
        public Map<String, ProductCQ> ProductStatusCode_ExistsSubQuery_ProductList { get { return _productStatusCode_ExistsSubQuery_ProductListMap; }}
        public override String keepProductStatusCode_ExistsSubQuery_ProductList(ProductCQ subQuery) {
            if (_productStatusCode_ExistsSubQuery_ProductListMap == null) { _productStatusCode_ExistsSubQuery_ProductListMap = new LinkedHashMap<String, ProductCQ>(); }
            String key = "subQueryMapKey" + (_productStatusCode_ExistsSubQuery_ProductListMap.size() + 1);
            _productStatusCode_ExistsSubQuery_ProductListMap.put(key, subQuery); return "ProductStatusCode_ExistsSubQuery_ProductList." + key;
        }

        protected Map<String, ProductCQ> _productStatusCode_NotExistsSubQuery_ProductListMap;
        public Map<String, ProductCQ> ProductStatusCode_NotExistsSubQuery_ProductList { get { return _productStatusCode_NotExistsSubQuery_ProductListMap; }}
        public override String keepProductStatusCode_NotExistsSubQuery_ProductList(ProductCQ subQuery) {
            if (_productStatusCode_NotExistsSubQuery_ProductListMap == null) { _productStatusCode_NotExistsSubQuery_ProductListMap = new LinkedHashMap<String, ProductCQ>(); }
            String key = "subQueryMapKey" + (_productStatusCode_NotExistsSubQuery_ProductListMap.size() + 1);
            _productStatusCode_NotExistsSubQuery_ProductListMap.put(key, subQuery); return "ProductStatusCode_NotExistsSubQuery_ProductList." + key;
        }

        protected Map<String, ProductCQ> _productStatusCode_InScopeSubQuery_ProductListMap;
        public Map<String, ProductCQ> ProductStatusCode_InScopeSubQuery_ProductList { get { return _productStatusCode_InScopeSubQuery_ProductListMap; }}
        public override String keepProductStatusCode_InScopeSubQuery_ProductList(ProductCQ subQuery) {
            if (_productStatusCode_InScopeSubQuery_ProductListMap == null) { _productStatusCode_InScopeSubQuery_ProductListMap = new LinkedHashMap<String, ProductCQ>(); }
            String key = "subQueryMapKey" + (_productStatusCode_InScopeSubQuery_ProductListMap.size() + 1);
            _productStatusCode_InScopeSubQuery_ProductListMap.put(key, subQuery); return "ProductStatusCode_InScopeSubQuery_ProductList." + key;
        }

        protected Map<String, ProductCQ> _productStatusCode_NotInScopeSubQuery_ProductListMap;
        public Map<String, ProductCQ> ProductStatusCode_NotInScopeSubQuery_ProductList { get { return _productStatusCode_NotInScopeSubQuery_ProductListMap; }}
        public override String keepProductStatusCode_NotInScopeSubQuery_ProductList(ProductCQ subQuery) {
            if (_productStatusCode_NotInScopeSubQuery_ProductListMap == null) { _productStatusCode_NotInScopeSubQuery_ProductListMap = new LinkedHashMap<String, ProductCQ>(); }
            String key = "subQueryMapKey" + (_productStatusCode_NotInScopeSubQuery_ProductListMap.size() + 1);
            _productStatusCode_NotInScopeSubQuery_ProductListMap.put(key, subQuery); return "ProductStatusCode_NotInScopeSubQuery_ProductList." + key;
        }

        protected Map<String, ProductCQ> _productStatusCode_SpecifyDerivedReferrer_ProductListMap;
        public Map<String, ProductCQ> ProductStatusCode_SpecifyDerivedReferrer_ProductList { get { return _productStatusCode_SpecifyDerivedReferrer_ProductListMap; }}
        public override String keepProductStatusCode_SpecifyDerivedReferrer_ProductList(ProductCQ subQuery) {
            if (_productStatusCode_SpecifyDerivedReferrer_ProductListMap == null) { _productStatusCode_SpecifyDerivedReferrer_ProductListMap = new LinkedHashMap<String, ProductCQ>(); }
            String key = "subQueryMapKey" + (_productStatusCode_SpecifyDerivedReferrer_ProductListMap.size() + 1);
           _productStatusCode_SpecifyDerivedReferrer_ProductListMap.put(key, subQuery); return "ProductStatusCode_SpecifyDerivedReferrer_ProductList." + key;
        }

        protected Map<String, ProductCQ> _productStatusCode_QueryDerivedReferrer_ProductListMap;
        public Map<String, ProductCQ> ProductStatusCode_QueryDerivedReferrer_ProductList { get { return _productStatusCode_QueryDerivedReferrer_ProductListMap; } }
        public override String keepProductStatusCode_QueryDerivedReferrer_ProductList(ProductCQ subQuery) {
            if (_productStatusCode_QueryDerivedReferrer_ProductListMap == null) { _productStatusCode_QueryDerivedReferrer_ProductListMap = new LinkedHashMap<String, ProductCQ>(); }
            String key = "subQueryMapKey" + (_productStatusCode_QueryDerivedReferrer_ProductListMap.size() + 1);
            _productStatusCode_QueryDerivedReferrer_ProductListMap.put(key, subQuery); return "ProductStatusCode_QueryDerivedReferrer_ProductList." + key;
        }
        protected Map<String, Object> _productStatusCode_QueryDerivedReferrer_ProductListParameterMap;
        public Map<String, Object> ProductStatusCode_QueryDerivedReferrer_ProductListParameter { get { return _productStatusCode_QueryDerivedReferrer_ProductListParameterMap; } }
        public override String keepProductStatusCode_QueryDerivedReferrer_ProductListParameter(Object parameterValue) {
            if (_productStatusCode_QueryDerivedReferrer_ProductListParameterMap == null) { _productStatusCode_QueryDerivedReferrer_ProductListParameterMap = new LinkedHashMap<String, Object>(); }
            String key = "subQueryParameterKey" + (_productStatusCode_QueryDerivedReferrer_ProductListParameterMap.size() + 1);
            _productStatusCode_QueryDerivedReferrer_ProductListParameterMap.put(key, parameterValue); return "ProductStatusCode_QueryDerivedReferrer_ProductListParameter." + key;
        }

        public BsProductStatusCQ AddOrderBy_ProductStatusCode_Asc() { regOBA("PRODUCT_STATUS_CODE");return this; }
        public BsProductStatusCQ AddOrderBy_ProductStatusCode_Desc() { regOBD("PRODUCT_STATUS_CODE");return this; }

        protected ConditionValue _productStatusName;
        public ConditionValue ProductStatusName {
            get { if (_productStatusName == null) { _productStatusName = new ConditionValue(); } return _productStatusName; }
        }
        protected override ConditionValue getCValueProductStatusName() { return this.ProductStatusName; }


        public BsProductStatusCQ AddOrderBy_ProductStatusName_Asc() { regOBA("PRODUCT_STATUS_NAME");return this; }
        public BsProductStatusCQ AddOrderBy_ProductStatusName_Desc() { regOBD("PRODUCT_STATUS_NAME");return this; }

        public BsProductStatusCQ AddSpecifiedDerivedOrderBy_Asc(String aliasName) { registerSpecifiedDerivedOrderBy_Asc(aliasName); return this; }
        public BsProductStatusCQ AddSpecifiedDerivedOrderBy_Desc(String aliasName) { registerSpecifiedDerivedOrderBy_Desc(aliasName); return this; }

        public override void reflectRelationOnUnionQuery(ConditionQuery baseQueryAsSuper, ConditionQuery unionQueryAsSuper) {

        }
    


	    // ===============================================================================
	    //                                                                 Scalar SubQuery
	    //                                                                 ===============
	    protected Map<String, ProductStatusCQ> _scalarSubQueryMap;
	    public Map<String, ProductStatusCQ> ScalarSubQuery { get { return _scalarSubQueryMap; } }
	    public override String keepScalarSubQuery(ProductStatusCQ subQuery) {
	        if (_scalarSubQueryMap == null) { _scalarSubQueryMap = new LinkedHashMap<String, ProductStatusCQ>(); }
	        String key = "subQueryMapKey" + (_scalarSubQueryMap.size() + 1);
	        _scalarSubQueryMap.put(key, subQuery); return "ScalarSubQuery." + key;
	    }

        // ===============================================================================
        //                                                         Myself InScope SubQuery
        //                                                         =======================
        protected Map<String, ProductStatusCQ> _myselfInScopeSubQueryMap;
        public Map<String, ProductStatusCQ> MyselfInScopeSubQuery { get { return _myselfInScopeSubQueryMap; } }
        public override String keepMyselfInScopeSubQuery(ProductStatusCQ subQuery) {
            if (_myselfInScopeSubQueryMap == null) { _myselfInScopeSubQueryMap = new LinkedHashMap<String, ProductStatusCQ>(); }
            String key = "subQueryMapKey" + (_myselfInScopeSubQueryMap.size() + 1);
            _myselfInScopeSubQueryMap.put(key, subQuery); return "MyselfInScopeSubQuery." + key;
        }
    }
}
