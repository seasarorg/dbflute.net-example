
using System;

using DfExample.DBFlute.MemberDb.AllCommon.CBean;
using DfExample.DBFlute.MemberDb.AllCommon.CBean.CValue;
using DfExample.DBFlute.MemberDb.AllCommon.CBean.SClause;
using DfExample.DBFlute.MemberDb.AllCommon.JavaLike;
using DfExample.DBFlute.MemberDb.CBean.CQ;
using DfExample.DBFlute.MemberDb.CBean.CQ.Ciq;

namespace DfExample.DBFlute.MemberDb.CBean.CQ.BS {

    [System.Serializable]
    public class MbBsProductStatusCQ : MbAbstractBsProductStatusCQ {

        protected MbProductStatusCIQ _inlineQuery;

        public MbBsProductStatusCQ(MbConditionQuery childQuery, MbSqlClause sqlClause, String aliasName, int nestLevel)
            : base(childQuery, sqlClause, aliasName, nestLevel) {}

        public MbProductStatusCIQ Inline() {
            if (_inlineQuery == null) {
                _inlineQuery = new MbProductStatusCIQ(xgetReferrerQuery(), xgetSqlClause(), xgetAliasName(), xgetNestLevel(), this);
            }
            _inlineQuery.xsetOnClause(false);
            return _inlineQuery;
        }
        
        public MbProductStatusCIQ On() {
            if (isBaseQuery()) { throw new UnsupportedOperationException("Unsupported onClause of Base Table!"); }
            MbProductStatusCIQ inlineQuery = Inline();
            inlineQuery.xsetOnClause(true);
            return inlineQuery;
        }


        protected MbConditionValue _productStatusCode;
        public MbConditionValue ProductStatusCode {
            get { if (_productStatusCode == null) { _productStatusCode = new MbConditionValue(); } return _productStatusCode; }
        }
        protected override MbConditionValue getCValueProductStatusCode() { return this.ProductStatusCode; }


        protected Map<String, MbProductCQ> _productStatusCode_ExistsSubQuery_ProductListMap;
        public Map<String, MbProductCQ> ProductStatusCode_ExistsSubQuery_ProductList { get { return _productStatusCode_ExistsSubQuery_ProductListMap; }}
        public override String keepProductStatusCode_ExistsSubQuery_ProductList(MbProductCQ subQuery) {
            if (_productStatusCode_ExistsSubQuery_ProductListMap == null) { _productStatusCode_ExistsSubQuery_ProductListMap = new LinkedHashMap<String, MbProductCQ>(); }
            String key = "subQueryMapKey" + (_productStatusCode_ExistsSubQuery_ProductListMap.size() + 1);
            _productStatusCode_ExistsSubQuery_ProductListMap.put(key, subQuery); return "ProductStatusCode_ExistsSubQuery_ProductList." + key;
        }

        protected Map<String, MbProductCQ> _productStatusCode_NotExistsSubQuery_ProductListMap;
        public Map<String, MbProductCQ> ProductStatusCode_NotExistsSubQuery_ProductList { get { return _productStatusCode_NotExistsSubQuery_ProductListMap; }}
        public override String keepProductStatusCode_NotExistsSubQuery_ProductList(MbProductCQ subQuery) {
            if (_productStatusCode_NotExistsSubQuery_ProductListMap == null) { _productStatusCode_NotExistsSubQuery_ProductListMap = new LinkedHashMap<String, MbProductCQ>(); }
            String key = "subQueryMapKey" + (_productStatusCode_NotExistsSubQuery_ProductListMap.size() + 1);
            _productStatusCode_NotExistsSubQuery_ProductListMap.put(key, subQuery); return "ProductStatusCode_NotExistsSubQuery_ProductList." + key;
        }

        protected Map<String, MbProductCQ> _productStatusCode_InScopeSubQuery_ProductListMap;
        public Map<String, MbProductCQ> ProductStatusCode_InScopeSubQuery_ProductList { get { return _productStatusCode_InScopeSubQuery_ProductListMap; }}
        public override String keepProductStatusCode_InScopeSubQuery_ProductList(MbProductCQ subQuery) {
            if (_productStatusCode_InScopeSubQuery_ProductListMap == null) { _productStatusCode_InScopeSubQuery_ProductListMap = new LinkedHashMap<String, MbProductCQ>(); }
            String key = "subQueryMapKey" + (_productStatusCode_InScopeSubQuery_ProductListMap.size() + 1);
            _productStatusCode_InScopeSubQuery_ProductListMap.put(key, subQuery); return "ProductStatusCode_InScopeSubQuery_ProductList." + key;
        }

        protected Map<String, MbProductCQ> _productStatusCode_NotInScopeSubQuery_ProductListMap;
        public Map<String, MbProductCQ> ProductStatusCode_NotInScopeSubQuery_ProductList { get { return _productStatusCode_NotInScopeSubQuery_ProductListMap; }}
        public override String keepProductStatusCode_NotInScopeSubQuery_ProductList(MbProductCQ subQuery) {
            if (_productStatusCode_NotInScopeSubQuery_ProductListMap == null) { _productStatusCode_NotInScopeSubQuery_ProductListMap = new LinkedHashMap<String, MbProductCQ>(); }
            String key = "subQueryMapKey" + (_productStatusCode_NotInScopeSubQuery_ProductListMap.size() + 1);
            _productStatusCode_NotInScopeSubQuery_ProductListMap.put(key, subQuery); return "ProductStatusCode_NotInScopeSubQuery_ProductList." + key;
        }

        protected Map<String, MbProductCQ> _productStatusCode_SpecifyDerivedReferrer_ProductListMap;
        public Map<String, MbProductCQ> ProductStatusCode_SpecifyDerivedReferrer_ProductList { get { return _productStatusCode_SpecifyDerivedReferrer_ProductListMap; }}
        public override String keepProductStatusCode_SpecifyDerivedReferrer_ProductList(MbProductCQ subQuery) {
            if (_productStatusCode_SpecifyDerivedReferrer_ProductListMap == null) { _productStatusCode_SpecifyDerivedReferrer_ProductListMap = new LinkedHashMap<String, MbProductCQ>(); }
            String key = "subQueryMapKey" + (_productStatusCode_SpecifyDerivedReferrer_ProductListMap.size() + 1);
           _productStatusCode_SpecifyDerivedReferrer_ProductListMap.put(key, subQuery); return "ProductStatusCode_SpecifyDerivedReferrer_ProductList." + key;
        }

        protected Map<String, MbProductCQ> _productStatusCode_QueryDerivedReferrer_ProductListMap;
        public Map<String, MbProductCQ> ProductStatusCode_QueryDerivedReferrer_ProductList { get { return _productStatusCode_QueryDerivedReferrer_ProductListMap; } }
        public override String keepProductStatusCode_QueryDerivedReferrer_ProductList(MbProductCQ subQuery) {
            if (_productStatusCode_QueryDerivedReferrer_ProductListMap == null) { _productStatusCode_QueryDerivedReferrer_ProductListMap = new LinkedHashMap<String, MbProductCQ>(); }
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

        public MbBsProductStatusCQ AddOrderBy_ProductStatusCode_Asc() { regOBA("PRODUCT_STATUS_CODE");return this; }
        public MbBsProductStatusCQ AddOrderBy_ProductStatusCode_Desc() { regOBD("PRODUCT_STATUS_CODE");return this; }

        protected MbConditionValue _productStatusName;
        public MbConditionValue ProductStatusName {
            get { if (_productStatusName == null) { _productStatusName = new MbConditionValue(); } return _productStatusName; }
        }
        protected override MbConditionValue getCValueProductStatusName() { return this.ProductStatusName; }


        public MbBsProductStatusCQ AddOrderBy_ProductStatusName_Asc() { regOBA("PRODUCT_STATUS_NAME");return this; }
        public MbBsProductStatusCQ AddOrderBy_ProductStatusName_Desc() { regOBD("PRODUCT_STATUS_NAME");return this; }

        public MbBsProductStatusCQ AddSpecifiedDerivedOrderBy_Asc(String aliasName) { registerSpecifiedDerivedOrderBy_Asc(aliasName); return this; }
        public MbBsProductStatusCQ AddSpecifiedDerivedOrderBy_Desc(String aliasName) { registerSpecifiedDerivedOrderBy_Desc(aliasName); return this; }

        public override void reflectRelationOnUnionQuery(MbConditionQuery baseQueryAsSuper, MbConditionQuery unionQueryAsSuper) {

        }
    


	    // ===============================================================================
	    //                                                                 Scalar SubQuery
	    //                                                                 ===============
	    protected Map<String, MbProductStatusCQ> _scalarSubQueryMap;
	    public Map<String, MbProductStatusCQ> ScalarSubQuery { get { return _scalarSubQueryMap; } }
	    public override String keepScalarSubQuery(MbProductStatusCQ subQuery) {
	        if (_scalarSubQueryMap == null) { _scalarSubQueryMap = new LinkedHashMap<String, MbProductStatusCQ>(); }
	        String key = "subQueryMapKey" + (_scalarSubQueryMap.size() + 1);
	        _scalarSubQueryMap.put(key, subQuery); return "ScalarSubQuery." + key;
	    }

        // ===============================================================================
        //                                                         Myself InScope SubQuery
        //                                                         =======================
        protected Map<String, MbProductStatusCQ> _myselfInScopeSubQueryMap;
        public Map<String, MbProductStatusCQ> MyselfInScopeSubQuery { get { return _myselfInScopeSubQueryMap; } }
        public override String keepMyselfInScopeSubQuery(MbProductStatusCQ subQuery) {
            if (_myselfInScopeSubQueryMap == null) { _myselfInScopeSubQueryMap = new LinkedHashMap<String, MbProductStatusCQ>(); }
            String key = "subQueryMapKey" + (_myselfInScopeSubQueryMap.size() + 1);
            _myselfInScopeSubQueryMap.put(key, subQuery); return "MyselfInScopeSubQuery." + key;
        }
    }
}
