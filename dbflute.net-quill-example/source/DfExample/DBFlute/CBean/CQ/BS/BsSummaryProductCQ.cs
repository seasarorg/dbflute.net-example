
using System;

using DfExample.DBFlute.AllCommon.CBean;
using DfExample.DBFlute.AllCommon.CBean.CValue;
using DfExample.DBFlute.AllCommon.CBean.SClause;
using DfExample.DBFlute.AllCommon.JavaLike;
using DfExample.DBFlute.CBean.CQ;
using DfExample.DBFlute.CBean.CQ.Ciq;

namespace DfExample.DBFlute.CBean.CQ.BS {

    [System.Serializable]
    public class BsSummaryProductCQ : AbstractBsSummaryProductCQ {

        protected SummaryProductCIQ _inlineQuery;

        public BsSummaryProductCQ(ConditionQuery childQuery, SqlClause sqlClause, String aliasName, int nestLevel)
            : base(childQuery, sqlClause, aliasName, nestLevel) {}

        public SummaryProductCIQ Inline() {
            if (_inlineQuery == null) {
                _inlineQuery = new SummaryProductCIQ(xgetReferrerQuery(), xgetSqlClause(), xgetAliasName(), xgetNestLevel(), this);
            }
            _inlineQuery.xsetOnClause(false);
            return _inlineQuery;
        }
        
        public SummaryProductCIQ On() {
            if (isBaseQuery()) { throw new UnsupportedOperationException("Unsupported onClause of Base Table!"); }
            SummaryProductCIQ inlineQuery = Inline();
            inlineQuery.xsetOnClause(true);
            return inlineQuery;
        }


        protected ConditionValue _productId;
        public ConditionValue ProductId {
            get { if (_productId == null) { _productId = new ConditionValue(); } return _productId; }
        }
        protected override ConditionValue getCValueProductId() { return this.ProductId; }


        public BsSummaryProductCQ AddOrderBy_ProductId_Asc() { regOBA("PRODUCT_ID");return this; }
        public BsSummaryProductCQ AddOrderBy_ProductId_Desc() { regOBD("PRODUCT_ID");return this; }

        protected ConditionValue _productName;
        public ConditionValue ProductName {
            get { if (_productName == null) { _productName = new ConditionValue(); } return _productName; }
        }
        protected override ConditionValue getCValueProductName() { return this.ProductName; }


        public BsSummaryProductCQ AddOrderBy_ProductName_Asc() { regOBA("PRODUCT_NAME");return this; }
        public BsSummaryProductCQ AddOrderBy_ProductName_Desc() { regOBD("PRODUCT_NAME");return this; }

        protected ConditionValue _productHandleCode;
        public ConditionValue ProductHandleCode {
            get { if (_productHandleCode == null) { _productHandleCode = new ConditionValue(); } return _productHandleCode; }
        }
        protected override ConditionValue getCValueProductHandleCode() { return this.ProductHandleCode; }


        public BsSummaryProductCQ AddOrderBy_ProductHandleCode_Asc() { regOBA("PRODUCT_HANDLE_CODE");return this; }
        public BsSummaryProductCQ AddOrderBy_ProductHandleCode_Desc() { regOBD("PRODUCT_HANDLE_CODE");return this; }

        protected ConditionValue _productStatusCode;
        public ConditionValue ProductStatusCode {
            get { if (_productStatusCode == null) { _productStatusCode = new ConditionValue(); } return _productStatusCode; }
        }
        protected override ConditionValue getCValueProductStatusCode() { return this.ProductStatusCode; }


        public BsSummaryProductCQ AddOrderBy_ProductStatusCode_Asc() { regOBA("PRODUCT_STATUS_CODE");return this; }
        public BsSummaryProductCQ AddOrderBy_ProductStatusCode_Desc() { regOBD("PRODUCT_STATUS_CODE");return this; }

        protected ConditionValue _latestPurchaseDatetime;
        public ConditionValue LatestPurchaseDatetime {
            get { if (_latestPurchaseDatetime == null) { _latestPurchaseDatetime = new ConditionValue(); } return _latestPurchaseDatetime; }
        }
        protected override ConditionValue getCValueLatestPurchaseDatetime() { return this.LatestPurchaseDatetime; }


        public BsSummaryProductCQ AddOrderBy_LatestPurchaseDatetime_Asc() { regOBA("LATEST_PURCHASE_DATETIME");return this; }
        public BsSummaryProductCQ AddOrderBy_LatestPurchaseDatetime_Desc() { regOBD("LATEST_PURCHASE_DATETIME");return this; }

        public BsSummaryProductCQ AddSpecifiedDerivedOrderBy_Asc(String aliasName) { registerSpecifiedDerivedOrderBy_Asc(aliasName); return this; }
        public BsSummaryProductCQ AddSpecifiedDerivedOrderBy_Desc(String aliasName) { registerSpecifiedDerivedOrderBy_Desc(aliasName); return this; }

        public override void reflectRelationOnUnionQuery(ConditionQuery baseQueryAsSuper, ConditionQuery unionQueryAsSuper) {

        }
    


	    // ===============================================================================
	    //                                                                 Scalar SubQuery
	    //                                                                 ===============
	    protected Map<String, SummaryProductCQ> _scalarSubQueryMap;
	    public Map<String, SummaryProductCQ> ScalarSubQuery { get { return _scalarSubQueryMap; } }
	    public override String keepScalarSubQuery(SummaryProductCQ subQuery) {
	        if (_scalarSubQueryMap == null) { _scalarSubQueryMap = new LinkedHashMap<String, SummaryProductCQ>(); }
	        String key = "subQueryMapKey" + (_scalarSubQueryMap.size() + 1);
	        _scalarSubQueryMap.put(key, subQuery); return "ScalarSubQuery." + key;
	    }

        // ===============================================================================
        //                                                         Myself InScope SubQuery
        //                                                         =======================
        protected Map<String, SummaryProductCQ> _myselfInScopeSubQueryMap;
        public Map<String, SummaryProductCQ> MyselfInScopeSubQuery { get { return _myselfInScopeSubQueryMap; } }
        public override String keepMyselfInScopeSubQuery(SummaryProductCQ subQuery) {
            if (_myselfInScopeSubQueryMap == null) { _myselfInScopeSubQueryMap = new LinkedHashMap<String, SummaryProductCQ>(); }
            String key = "subQueryMapKey" + (_myselfInScopeSubQueryMap.size() + 1);
            _myselfInScopeSubQueryMap.put(key, subQuery); return "MyselfInScopeSubQuery." + key;
        }
    }
}
