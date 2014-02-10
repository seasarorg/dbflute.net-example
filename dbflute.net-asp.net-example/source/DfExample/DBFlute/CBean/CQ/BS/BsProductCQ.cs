
using System;

using DfExample.DBFlute.AllCommon.CBean;
using DfExample.DBFlute.AllCommon.CBean.CValue;
using DfExample.DBFlute.AllCommon.CBean.SClause;
using DfExample.DBFlute.AllCommon.JavaLike;
using DfExample.DBFlute.CBean.CQ;
using DfExample.DBFlute.CBean.CQ.Ciq;

namespace DfExample.DBFlute.CBean.CQ.BS {

    [System.Serializable]
    public class BsProductCQ : AbstractBsProductCQ {

        protected ProductCIQ _inlineQuery;

        public BsProductCQ(ConditionQuery childQuery, SqlClause sqlClause, String aliasName, int nestLevel)
            : base(childQuery, sqlClause, aliasName, nestLevel) {}

        public ProductCIQ Inline() {
            if (_inlineQuery == null) {
                _inlineQuery = new ProductCIQ(xgetReferrerQuery(), xgetSqlClause(), xgetAliasName(), xgetNestLevel(), this);
            }
            _inlineQuery.xsetOnClause(false);
            return _inlineQuery;
        }
        
        public ProductCIQ On() {
            if (isBaseQuery()) { throw new UnsupportedOperationException("Unsupported onClause of Base Table!"); }
            ProductCIQ inlineQuery = Inline();
            inlineQuery.xsetOnClause(true);
            return inlineQuery;
        }


        protected ConditionValue _productId;
        public ConditionValue ProductId {
            get { if (_productId == null) { _productId = new ConditionValue(); } return _productId; }
        }
        protected override ConditionValue getCValueProductId() { return this.ProductId; }


        protected Map<String, PurchaseCQ> _productId_ExistsSubQuery_PurchaseListMap;
        public Map<String, PurchaseCQ> ProductId_ExistsSubQuery_PurchaseList { get { return _productId_ExistsSubQuery_PurchaseListMap; }}
        public override String keepProductId_ExistsSubQuery_PurchaseList(PurchaseCQ subQuery) {
            if (_productId_ExistsSubQuery_PurchaseListMap == null) { _productId_ExistsSubQuery_PurchaseListMap = new LinkedHashMap<String, PurchaseCQ>(); }
            String key = "subQueryMapKey" + (_productId_ExistsSubQuery_PurchaseListMap.size() + 1);
            _productId_ExistsSubQuery_PurchaseListMap.put(key, subQuery); return "ProductId_ExistsSubQuery_PurchaseList." + key;
        }

        protected Map<String, PurchaseCQ> _productId_NotExistsSubQuery_PurchaseListMap;
        public Map<String, PurchaseCQ> ProductId_NotExistsSubQuery_PurchaseList { get { return _productId_NotExistsSubQuery_PurchaseListMap; }}
        public override String keepProductId_NotExistsSubQuery_PurchaseList(PurchaseCQ subQuery) {
            if (_productId_NotExistsSubQuery_PurchaseListMap == null) { _productId_NotExistsSubQuery_PurchaseListMap = new LinkedHashMap<String, PurchaseCQ>(); }
            String key = "subQueryMapKey" + (_productId_NotExistsSubQuery_PurchaseListMap.size() + 1);
            _productId_NotExistsSubQuery_PurchaseListMap.put(key, subQuery); return "ProductId_NotExistsSubQuery_PurchaseList." + key;
        }

        protected Map<String, PurchaseCQ> _productId_InScopeSubQuery_PurchaseListMap;
        public Map<String, PurchaseCQ> ProductId_InScopeSubQuery_PurchaseList { get { return _productId_InScopeSubQuery_PurchaseListMap; }}
        public override String keepProductId_InScopeSubQuery_PurchaseList(PurchaseCQ subQuery) {
            if (_productId_InScopeSubQuery_PurchaseListMap == null) { _productId_InScopeSubQuery_PurchaseListMap = new LinkedHashMap<String, PurchaseCQ>(); }
            String key = "subQueryMapKey" + (_productId_InScopeSubQuery_PurchaseListMap.size() + 1);
            _productId_InScopeSubQuery_PurchaseListMap.put(key, subQuery); return "ProductId_InScopeSubQuery_PurchaseList." + key;
        }

        protected Map<String, PurchaseCQ> _productId_NotInScopeSubQuery_PurchaseListMap;
        public Map<String, PurchaseCQ> ProductId_NotInScopeSubQuery_PurchaseList { get { return _productId_NotInScopeSubQuery_PurchaseListMap; }}
        public override String keepProductId_NotInScopeSubQuery_PurchaseList(PurchaseCQ subQuery) {
            if (_productId_NotInScopeSubQuery_PurchaseListMap == null) { _productId_NotInScopeSubQuery_PurchaseListMap = new LinkedHashMap<String, PurchaseCQ>(); }
            String key = "subQueryMapKey" + (_productId_NotInScopeSubQuery_PurchaseListMap.size() + 1);
            _productId_NotInScopeSubQuery_PurchaseListMap.put(key, subQuery); return "ProductId_NotInScopeSubQuery_PurchaseList." + key;
        }

        protected Map<String, PurchaseCQ> _productId_SpecifyDerivedReferrer_PurchaseListMap;
        public Map<String, PurchaseCQ> ProductId_SpecifyDerivedReferrer_PurchaseList { get { return _productId_SpecifyDerivedReferrer_PurchaseListMap; }}
        public override String keepProductId_SpecifyDerivedReferrer_PurchaseList(PurchaseCQ subQuery) {
            if (_productId_SpecifyDerivedReferrer_PurchaseListMap == null) { _productId_SpecifyDerivedReferrer_PurchaseListMap = new LinkedHashMap<String, PurchaseCQ>(); }
            String key = "subQueryMapKey" + (_productId_SpecifyDerivedReferrer_PurchaseListMap.size() + 1);
            _productId_SpecifyDerivedReferrer_PurchaseListMap.put(key, subQuery); return "ProductId_SpecifyDerivedReferrer_PurchaseList." + key;
        }

        protected Map<String, PurchaseCQ> _productId_QueryDerivedReferrer_PurchaseListMap;
        public Map<String, PurchaseCQ> ProductId_QueryDerivedReferrer_PurchaseList { get { return _productId_QueryDerivedReferrer_PurchaseListMap; } }
        public override String keepProductId_QueryDerivedReferrer_PurchaseList(PurchaseCQ subQuery) {
            if (_productId_QueryDerivedReferrer_PurchaseListMap == null) { _productId_QueryDerivedReferrer_PurchaseListMap = new LinkedHashMap<String, PurchaseCQ>(); }
            String key = "subQueryMapKey" + (_productId_QueryDerivedReferrer_PurchaseListMap.size() + 1);
            _productId_QueryDerivedReferrer_PurchaseListMap.put(key, subQuery); return "ProductId_QueryDerivedReferrer_PurchaseList." + key;
        }
        protected Map<String, Object> _productId_QueryDerivedReferrer_PurchaseListParameterMap;
        public Map<String, Object> ProductId_QueryDerivedReferrer_PurchaseListParameter { get { return _productId_QueryDerivedReferrer_PurchaseListParameterMap; } }
        public override String keepProductId_QueryDerivedReferrer_PurchaseListParameter(Object parameterValue) {
            if (_productId_QueryDerivedReferrer_PurchaseListParameterMap == null) { _productId_QueryDerivedReferrer_PurchaseListParameterMap = new LinkedHashMap<String, Object>(); }
            String key = "subQueryParameterKey" + (_productId_QueryDerivedReferrer_PurchaseListParameterMap.size() + 1);
            _productId_QueryDerivedReferrer_PurchaseListParameterMap.put(key, parameterValue); return "ProductId_QueryDerivedReferrer_PurchaseListParameter." + key;
        }

        public BsProductCQ AddOrderBy_ProductId_Asc() { regOBA("PRODUCT_ID");return this; }
        public BsProductCQ AddOrderBy_ProductId_Desc() { regOBD("PRODUCT_ID");return this; }

        protected ConditionValue _productName;
        public ConditionValue ProductName {
            get { if (_productName == null) { _productName = new ConditionValue(); } return _productName; }
        }
        protected override ConditionValue getCValueProductName() { return this.ProductName; }


        public BsProductCQ AddOrderBy_ProductName_Asc() { regOBA("PRODUCT_NAME");return this; }
        public BsProductCQ AddOrderBy_ProductName_Desc() { regOBD("PRODUCT_NAME");return this; }

        protected ConditionValue _productHandleCode;
        public ConditionValue ProductHandleCode {
            get { if (_productHandleCode == null) { _productHandleCode = new ConditionValue(); } return _productHandleCode; }
        }
        protected override ConditionValue getCValueProductHandleCode() { return this.ProductHandleCode; }


        public BsProductCQ AddOrderBy_ProductHandleCode_Asc() { regOBA("PRODUCT_HANDLE_CODE");return this; }
        public BsProductCQ AddOrderBy_ProductHandleCode_Desc() { regOBD("PRODUCT_HANDLE_CODE");return this; }

        protected ConditionValue _productStatusCode;
        public ConditionValue ProductStatusCode {
            get { if (_productStatusCode == null) { _productStatusCode = new ConditionValue(); } return _productStatusCode; }
        }
        protected override ConditionValue getCValueProductStatusCode() { return this.ProductStatusCode; }


        protected Map<String, ProductStatusCQ> _productStatusCode_InScopeSubQuery_ProductStatusMap;
        public Map<String, ProductStatusCQ> ProductStatusCode_InScopeSubQuery_ProductStatus { get { return _productStatusCode_InScopeSubQuery_ProductStatusMap; }}
        public override String keepProductStatusCode_InScopeSubQuery_ProductStatus(ProductStatusCQ subQuery) {
            if (_productStatusCode_InScopeSubQuery_ProductStatusMap == null) { _productStatusCode_InScopeSubQuery_ProductStatusMap = new LinkedHashMap<String, ProductStatusCQ>(); }
            String key = "subQueryMapKey" + (_productStatusCode_InScopeSubQuery_ProductStatusMap.size() + 1);
            _productStatusCode_InScopeSubQuery_ProductStatusMap.put(key, subQuery); return "ProductStatusCode_InScopeSubQuery_ProductStatus." + key;
        }

        protected Map<String, ProductStatusCQ> _productStatusCode_NotInScopeSubQuery_ProductStatusMap;
        public Map<String, ProductStatusCQ> ProductStatusCode_NotInScopeSubQuery_ProductStatus { get { return _productStatusCode_NotInScopeSubQuery_ProductStatusMap; }}
        public override String keepProductStatusCode_NotInScopeSubQuery_ProductStatus(ProductStatusCQ subQuery) {
            if (_productStatusCode_NotInScopeSubQuery_ProductStatusMap == null) { _productStatusCode_NotInScopeSubQuery_ProductStatusMap = new LinkedHashMap<String, ProductStatusCQ>(); }
            String key = "subQueryMapKey" + (_productStatusCode_NotInScopeSubQuery_ProductStatusMap.size() + 1);
            _productStatusCode_NotInScopeSubQuery_ProductStatusMap.put(key, subQuery); return "ProductStatusCode_NotInScopeSubQuery_ProductStatus." + key;
        }

        public BsProductCQ AddOrderBy_ProductStatusCode_Asc() { regOBA("PRODUCT_STATUS_CODE");return this; }
        public BsProductCQ AddOrderBy_ProductStatusCode_Desc() { regOBD("PRODUCT_STATUS_CODE");return this; }

        protected ConditionValue _registerDatetime;
        public ConditionValue RegisterDatetime {
            get { if (_registerDatetime == null) { _registerDatetime = new ConditionValue(); } return _registerDatetime; }
        }
        protected override ConditionValue getCValueRegisterDatetime() { return this.RegisterDatetime; }


        public BsProductCQ AddOrderBy_RegisterDatetime_Asc() { regOBA("REGISTER_DATETIME");return this; }
        public BsProductCQ AddOrderBy_RegisterDatetime_Desc() { regOBD("REGISTER_DATETIME");return this; }

        protected ConditionValue _registerUser;
        public ConditionValue RegisterUser {
            get { if (_registerUser == null) { _registerUser = new ConditionValue(); } return _registerUser; }
        }
        protected override ConditionValue getCValueRegisterUser() { return this.RegisterUser; }


        public BsProductCQ AddOrderBy_RegisterUser_Asc() { regOBA("REGISTER_USER");return this; }
        public BsProductCQ AddOrderBy_RegisterUser_Desc() { regOBD("REGISTER_USER");return this; }

        protected ConditionValue _registerProcess;
        public ConditionValue RegisterProcess {
            get { if (_registerProcess == null) { _registerProcess = new ConditionValue(); } return _registerProcess; }
        }
        protected override ConditionValue getCValueRegisterProcess() { return this.RegisterProcess; }


        public BsProductCQ AddOrderBy_RegisterProcess_Asc() { regOBA("REGISTER_PROCESS");return this; }
        public BsProductCQ AddOrderBy_RegisterProcess_Desc() { regOBD("REGISTER_PROCESS");return this; }

        protected ConditionValue _updateDatetime;
        public ConditionValue UpdateDatetime {
            get { if (_updateDatetime == null) { _updateDatetime = new ConditionValue(); } return _updateDatetime; }
        }
        protected override ConditionValue getCValueUpdateDatetime() { return this.UpdateDatetime; }


        public BsProductCQ AddOrderBy_UpdateDatetime_Asc() { regOBA("UPDATE_DATETIME");return this; }
        public BsProductCQ AddOrderBy_UpdateDatetime_Desc() { regOBD("UPDATE_DATETIME");return this; }

        protected ConditionValue _updateUser;
        public ConditionValue UpdateUser {
            get { if (_updateUser == null) { _updateUser = new ConditionValue(); } return _updateUser; }
        }
        protected override ConditionValue getCValueUpdateUser() { return this.UpdateUser; }


        public BsProductCQ AddOrderBy_UpdateUser_Asc() { regOBA("UPDATE_USER");return this; }
        public BsProductCQ AddOrderBy_UpdateUser_Desc() { regOBD("UPDATE_USER");return this; }

        protected ConditionValue _updateProcess;
        public ConditionValue UpdateProcess {
            get { if (_updateProcess == null) { _updateProcess = new ConditionValue(); } return _updateProcess; }
        }
        protected override ConditionValue getCValueUpdateProcess() { return this.UpdateProcess; }


        public BsProductCQ AddOrderBy_UpdateProcess_Asc() { regOBA("UPDATE_PROCESS");return this; }
        public BsProductCQ AddOrderBy_UpdateProcess_Desc() { regOBD("UPDATE_PROCESS");return this; }

        protected ConditionValue _versionNo;
        public ConditionValue VersionNo {
            get { if (_versionNo == null) { _versionNo = new ConditionValue(); } return _versionNo; }
        }
        protected override ConditionValue getCValueVersionNo() { return this.VersionNo; }


        public BsProductCQ AddOrderBy_VersionNo_Asc() { regOBA("VERSION_NO");return this; }
        public BsProductCQ AddOrderBy_VersionNo_Desc() { regOBD("VERSION_NO");return this; }

        public BsProductCQ AddSpecifiedDerivedOrderBy_Asc(String aliasName) { registerSpecifiedDerivedOrderBy_Asc(aliasName); return this; }
        public BsProductCQ AddSpecifiedDerivedOrderBy_Desc(String aliasName) { registerSpecifiedDerivedOrderBy_Desc(aliasName); return this; }

        public override void reflectRelationOnUnionQuery(ConditionQuery baseQueryAsSuper, ConditionQuery unionQueryAsSuper) {
            ProductCQ baseQuery = (ProductCQ)baseQueryAsSuper;
            ProductCQ unionQuery = (ProductCQ)unionQueryAsSuper;
            if (baseQuery.hasConditionQueryProductStatus()) {
                unionQuery.QueryProductStatus().reflectRelationOnUnionQuery(baseQuery.QueryProductStatus(), unionQuery.QueryProductStatus());
            }

        }
    
        protected ProductStatusCQ _conditionQueryProductStatus;
        public ProductStatusCQ QueryProductStatus() {
            return this.ConditionQueryProductStatus;
        }
        public ProductStatusCQ ConditionQueryProductStatus {
            get {
                if (_conditionQueryProductStatus == null) {
                    _conditionQueryProductStatus = xcreateQueryProductStatus();
                    xsetupOuterJoin_ProductStatus();
                }
                return _conditionQueryProductStatus;
            }
        }
        protected ProductStatusCQ xcreateQueryProductStatus() {
            String nrp = resolveNextRelationPathProductStatus();
            String jan = resolveJoinAliasName(nrp, xgetNextNestLevel());
            ProductStatusCQ cq = new ProductStatusCQ(this, xgetSqlClause(), jan, xgetNextNestLevel());
            cq.xsetForeignPropertyName("productStatus"); cq.xsetRelationPath(nrp); return cq;
        }
        public void xsetupOuterJoin_ProductStatus() {
            ProductStatusCQ cq = ConditionQueryProductStatus;
            Map<String, String> joinOnMap = new LinkedHashMap<String, String>();
            joinOnMap.put("PRODUCT_STATUS_CODE", "PRODUCT_STATUS_CODE");
            registerOuterJoin(cq, joinOnMap);
        }
        protected String resolveNextRelationPathProductStatus() {
            return resolveNextRelationPath("PRODUCT", "productStatus");
        }
        public bool hasConditionQueryProductStatus() {
            return _conditionQueryProductStatus != null;
        }


	    // ===============================================================================
	    //                                                                 Scalar SubQuery
	    //                                                                 ===============
	    protected Map<String, ProductCQ> _scalarSubQueryMap;
	    public Map<String, ProductCQ> ScalarSubQuery { get { return _scalarSubQueryMap; } }
	    public override String keepScalarSubQuery(ProductCQ subQuery) {
	        if (_scalarSubQueryMap == null) { _scalarSubQueryMap = new LinkedHashMap<String, ProductCQ>(); }
	        String key = "subQueryMapKey" + (_scalarSubQueryMap.size() + 1);
	        _scalarSubQueryMap.put(key, subQuery); return "ScalarSubQuery." + key;
	    }

        // ===============================================================================
        //                                                         Myself InScope SubQuery
        //                                                         =======================
        protected Map<String, ProductCQ> _myselfInScopeSubQueryMap;
        public Map<String, ProductCQ> MyselfInScopeSubQuery { get { return _myselfInScopeSubQueryMap; } }
        public override String keepMyselfInScopeSubQuery(ProductCQ subQuery) {
            if (_myselfInScopeSubQueryMap == null) { _myselfInScopeSubQueryMap = new LinkedHashMap<String, ProductCQ>(); }
            String key = "subQueryMapKey" + (_myselfInScopeSubQueryMap.size() + 1);
            _myselfInScopeSubQueryMap.put(key, subQuery); return "MyselfInScopeSubQuery." + key;
        }
    }
}
