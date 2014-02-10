
using System;

using DfExample.DBFlute.MemberDb.AllCommon.CBean;
using DfExample.DBFlute.MemberDb.AllCommon.CBean.CValue;
using DfExample.DBFlute.MemberDb.AllCommon.CBean.SClause;
using DfExample.DBFlute.MemberDb.AllCommon.JavaLike;
using DfExample.DBFlute.MemberDb.CBean.CQ;
using DfExample.DBFlute.MemberDb.CBean.CQ.Ciq;

namespace DfExample.DBFlute.MemberDb.CBean.CQ.BS {

    [System.Serializable]
    public class MbBsProductCQ : MbAbstractBsProductCQ {

        protected MbProductCIQ _inlineQuery;

        public MbBsProductCQ(MbConditionQuery childQuery, MbSqlClause sqlClause, String aliasName, int nestLevel)
            : base(childQuery, sqlClause, aliasName, nestLevel) {}

        public MbProductCIQ Inline() {
            if (_inlineQuery == null) {
                _inlineQuery = new MbProductCIQ(xgetReferrerQuery(), xgetSqlClause(), xgetAliasName(), xgetNestLevel(), this);
            }
            _inlineQuery.xsetOnClause(false);
            return _inlineQuery;
        }
        
        public MbProductCIQ On() {
            if (isBaseQuery()) { throw new UnsupportedOperationException("Unsupported onClause of Base Table!"); }
            MbProductCIQ inlineQuery = Inline();
            inlineQuery.xsetOnClause(true);
            return inlineQuery;
        }


        protected MbConditionValue _productId;
        public MbConditionValue ProductId {
            get { if (_productId == null) { _productId = new MbConditionValue(); } return _productId; }
        }
        protected override MbConditionValue getCValueProductId() { return this.ProductId; }


        protected Map<String, MbPurchaseCQ> _productId_ExistsSubQuery_PurchaseListMap;
        public Map<String, MbPurchaseCQ> ProductId_ExistsSubQuery_PurchaseList { get { return _productId_ExistsSubQuery_PurchaseListMap; }}
        public override String keepProductId_ExistsSubQuery_PurchaseList(MbPurchaseCQ subQuery) {
            if (_productId_ExistsSubQuery_PurchaseListMap == null) { _productId_ExistsSubQuery_PurchaseListMap = new LinkedHashMap<String, MbPurchaseCQ>(); }
            String key = "subQueryMapKey" + (_productId_ExistsSubQuery_PurchaseListMap.size() + 1);
            _productId_ExistsSubQuery_PurchaseListMap.put(key, subQuery); return "ProductId_ExistsSubQuery_PurchaseList." + key;
        }

        protected Map<String, MbPurchaseCQ> _productId_NotExistsSubQuery_PurchaseListMap;
        public Map<String, MbPurchaseCQ> ProductId_NotExistsSubQuery_PurchaseList { get { return _productId_NotExistsSubQuery_PurchaseListMap; }}
        public override String keepProductId_NotExistsSubQuery_PurchaseList(MbPurchaseCQ subQuery) {
            if (_productId_NotExistsSubQuery_PurchaseListMap == null) { _productId_NotExistsSubQuery_PurchaseListMap = new LinkedHashMap<String, MbPurchaseCQ>(); }
            String key = "subQueryMapKey" + (_productId_NotExistsSubQuery_PurchaseListMap.size() + 1);
            _productId_NotExistsSubQuery_PurchaseListMap.put(key, subQuery); return "ProductId_NotExistsSubQuery_PurchaseList." + key;
        }

        protected Map<String, MbPurchaseCQ> _productId_InScopeSubQuery_PurchaseListMap;
        public Map<String, MbPurchaseCQ> ProductId_InScopeSubQuery_PurchaseList { get { return _productId_InScopeSubQuery_PurchaseListMap; }}
        public override String keepProductId_InScopeSubQuery_PurchaseList(MbPurchaseCQ subQuery) {
            if (_productId_InScopeSubQuery_PurchaseListMap == null) { _productId_InScopeSubQuery_PurchaseListMap = new LinkedHashMap<String, MbPurchaseCQ>(); }
            String key = "subQueryMapKey" + (_productId_InScopeSubQuery_PurchaseListMap.size() + 1);
            _productId_InScopeSubQuery_PurchaseListMap.put(key, subQuery); return "ProductId_InScopeSubQuery_PurchaseList." + key;
        }

        protected Map<String, MbPurchaseCQ> _productId_NotInScopeSubQuery_PurchaseListMap;
        public Map<String, MbPurchaseCQ> ProductId_NotInScopeSubQuery_PurchaseList { get { return _productId_NotInScopeSubQuery_PurchaseListMap; }}
        public override String keepProductId_NotInScopeSubQuery_PurchaseList(MbPurchaseCQ subQuery) {
            if (_productId_NotInScopeSubQuery_PurchaseListMap == null) { _productId_NotInScopeSubQuery_PurchaseListMap = new LinkedHashMap<String, MbPurchaseCQ>(); }
            String key = "subQueryMapKey" + (_productId_NotInScopeSubQuery_PurchaseListMap.size() + 1);
            _productId_NotInScopeSubQuery_PurchaseListMap.put(key, subQuery); return "ProductId_NotInScopeSubQuery_PurchaseList." + key;
        }

        protected Map<String, MbPurchaseCQ> _productId_SpecifyDerivedReferrer_PurchaseListMap;
        public Map<String, MbPurchaseCQ> ProductId_SpecifyDerivedReferrer_PurchaseList { get { return _productId_SpecifyDerivedReferrer_PurchaseListMap; }}
        public override String keepProductId_SpecifyDerivedReferrer_PurchaseList(MbPurchaseCQ subQuery) {
            if (_productId_SpecifyDerivedReferrer_PurchaseListMap == null) { _productId_SpecifyDerivedReferrer_PurchaseListMap = new LinkedHashMap<String, MbPurchaseCQ>(); }
            String key = "subQueryMapKey" + (_productId_SpecifyDerivedReferrer_PurchaseListMap.size() + 1);
            _productId_SpecifyDerivedReferrer_PurchaseListMap.put(key, subQuery); return "ProductId_SpecifyDerivedReferrer_PurchaseList." + key;
        }

        protected Map<String, MbPurchaseCQ> _productId_QueryDerivedReferrer_PurchaseListMap;
        public Map<String, MbPurchaseCQ> ProductId_QueryDerivedReferrer_PurchaseList { get { return _productId_QueryDerivedReferrer_PurchaseListMap; } }
        public override String keepProductId_QueryDerivedReferrer_PurchaseList(MbPurchaseCQ subQuery) {
            if (_productId_QueryDerivedReferrer_PurchaseListMap == null) { _productId_QueryDerivedReferrer_PurchaseListMap = new LinkedHashMap<String, MbPurchaseCQ>(); }
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

        public MbBsProductCQ AddOrderBy_ProductId_Asc() { regOBA("PRODUCT_ID");return this; }
        public MbBsProductCQ AddOrderBy_ProductId_Desc() { regOBD("PRODUCT_ID");return this; }

        protected MbConditionValue _productName;
        public MbConditionValue ProductName {
            get { if (_productName == null) { _productName = new MbConditionValue(); } return _productName; }
        }
        protected override MbConditionValue getCValueProductName() { return this.ProductName; }


        public MbBsProductCQ AddOrderBy_ProductName_Asc() { regOBA("PRODUCT_NAME");return this; }
        public MbBsProductCQ AddOrderBy_ProductName_Desc() { regOBD("PRODUCT_NAME");return this; }

        protected MbConditionValue _productHandleCode;
        public MbConditionValue ProductHandleCode {
            get { if (_productHandleCode == null) { _productHandleCode = new MbConditionValue(); } return _productHandleCode; }
        }
        protected override MbConditionValue getCValueProductHandleCode() { return this.ProductHandleCode; }


        public MbBsProductCQ AddOrderBy_ProductHandleCode_Asc() { regOBA("PRODUCT_HANDLE_CODE");return this; }
        public MbBsProductCQ AddOrderBy_ProductHandleCode_Desc() { regOBD("PRODUCT_HANDLE_CODE");return this; }

        protected MbConditionValue _productStatusCode;
        public MbConditionValue ProductStatusCode {
            get { if (_productStatusCode == null) { _productStatusCode = new MbConditionValue(); } return _productStatusCode; }
        }
        protected override MbConditionValue getCValueProductStatusCode() { return this.ProductStatusCode; }


        protected Map<String, MbProductStatusCQ> _productStatusCode_InScopeSubQuery_ProductStatusMap;
        public Map<String, MbProductStatusCQ> ProductStatusCode_InScopeSubQuery_ProductStatus { get { return _productStatusCode_InScopeSubQuery_ProductStatusMap; }}
        public override String keepProductStatusCode_InScopeSubQuery_ProductStatus(MbProductStatusCQ subQuery) {
            if (_productStatusCode_InScopeSubQuery_ProductStatusMap == null) { _productStatusCode_InScopeSubQuery_ProductStatusMap = new LinkedHashMap<String, MbProductStatusCQ>(); }
            String key = "subQueryMapKey" + (_productStatusCode_InScopeSubQuery_ProductStatusMap.size() + 1);
            _productStatusCode_InScopeSubQuery_ProductStatusMap.put(key, subQuery); return "ProductStatusCode_InScopeSubQuery_ProductStatus." + key;
        }

        protected Map<String, MbProductStatusCQ> _productStatusCode_NotInScopeSubQuery_ProductStatusMap;
        public Map<String, MbProductStatusCQ> ProductStatusCode_NotInScopeSubQuery_ProductStatus { get { return _productStatusCode_NotInScopeSubQuery_ProductStatusMap; }}
        public override String keepProductStatusCode_NotInScopeSubQuery_ProductStatus(MbProductStatusCQ subQuery) {
            if (_productStatusCode_NotInScopeSubQuery_ProductStatusMap == null) { _productStatusCode_NotInScopeSubQuery_ProductStatusMap = new LinkedHashMap<String, MbProductStatusCQ>(); }
            String key = "subQueryMapKey" + (_productStatusCode_NotInScopeSubQuery_ProductStatusMap.size() + 1);
            _productStatusCode_NotInScopeSubQuery_ProductStatusMap.put(key, subQuery); return "ProductStatusCode_NotInScopeSubQuery_ProductStatus." + key;
        }

        public MbBsProductCQ AddOrderBy_ProductStatusCode_Asc() { regOBA("PRODUCT_STATUS_CODE");return this; }
        public MbBsProductCQ AddOrderBy_ProductStatusCode_Desc() { regOBD("PRODUCT_STATUS_CODE");return this; }

        protected MbConditionValue _registerDatetime;
        public MbConditionValue RegisterDatetime {
            get { if (_registerDatetime == null) { _registerDatetime = new MbConditionValue(); } return _registerDatetime; }
        }
        protected override MbConditionValue getCValueRegisterDatetime() { return this.RegisterDatetime; }


        public MbBsProductCQ AddOrderBy_RegisterDatetime_Asc() { regOBA("REGISTER_DATETIME");return this; }
        public MbBsProductCQ AddOrderBy_RegisterDatetime_Desc() { regOBD("REGISTER_DATETIME");return this; }

        protected MbConditionValue _registerUser;
        public MbConditionValue RegisterUser {
            get { if (_registerUser == null) { _registerUser = new MbConditionValue(); } return _registerUser; }
        }
        protected override MbConditionValue getCValueRegisterUser() { return this.RegisterUser; }


        public MbBsProductCQ AddOrderBy_RegisterUser_Asc() { regOBA("REGISTER_USER");return this; }
        public MbBsProductCQ AddOrderBy_RegisterUser_Desc() { regOBD("REGISTER_USER");return this; }

        protected MbConditionValue _registerProcess;
        public MbConditionValue RegisterProcess {
            get { if (_registerProcess == null) { _registerProcess = new MbConditionValue(); } return _registerProcess; }
        }
        protected override MbConditionValue getCValueRegisterProcess() { return this.RegisterProcess; }


        public MbBsProductCQ AddOrderBy_RegisterProcess_Asc() { regOBA("REGISTER_PROCESS");return this; }
        public MbBsProductCQ AddOrderBy_RegisterProcess_Desc() { regOBD("REGISTER_PROCESS");return this; }

        protected MbConditionValue _updateDatetime;
        public MbConditionValue UpdateDatetime {
            get { if (_updateDatetime == null) { _updateDatetime = new MbConditionValue(); } return _updateDatetime; }
        }
        protected override MbConditionValue getCValueUpdateDatetime() { return this.UpdateDatetime; }


        public MbBsProductCQ AddOrderBy_UpdateDatetime_Asc() { regOBA("UPDATE_DATETIME");return this; }
        public MbBsProductCQ AddOrderBy_UpdateDatetime_Desc() { regOBD("UPDATE_DATETIME");return this; }

        protected MbConditionValue _updateUser;
        public MbConditionValue UpdateUser {
            get { if (_updateUser == null) { _updateUser = new MbConditionValue(); } return _updateUser; }
        }
        protected override MbConditionValue getCValueUpdateUser() { return this.UpdateUser; }


        public MbBsProductCQ AddOrderBy_UpdateUser_Asc() { regOBA("UPDATE_USER");return this; }
        public MbBsProductCQ AddOrderBy_UpdateUser_Desc() { regOBD("UPDATE_USER");return this; }

        protected MbConditionValue _updateProcess;
        public MbConditionValue UpdateProcess {
            get { if (_updateProcess == null) { _updateProcess = new MbConditionValue(); } return _updateProcess; }
        }
        protected override MbConditionValue getCValueUpdateProcess() { return this.UpdateProcess; }


        public MbBsProductCQ AddOrderBy_UpdateProcess_Asc() { regOBA("UPDATE_PROCESS");return this; }
        public MbBsProductCQ AddOrderBy_UpdateProcess_Desc() { regOBD("UPDATE_PROCESS");return this; }

        protected MbConditionValue _versionNo;
        public MbConditionValue VersionNo {
            get { if (_versionNo == null) { _versionNo = new MbConditionValue(); } return _versionNo; }
        }
        protected override MbConditionValue getCValueVersionNo() { return this.VersionNo; }


        public MbBsProductCQ AddOrderBy_VersionNo_Asc() { regOBA("VERSION_NO");return this; }
        public MbBsProductCQ AddOrderBy_VersionNo_Desc() { regOBD("VERSION_NO");return this; }

        public MbBsProductCQ AddSpecifiedDerivedOrderBy_Asc(String aliasName) { registerSpecifiedDerivedOrderBy_Asc(aliasName); return this; }
        public MbBsProductCQ AddSpecifiedDerivedOrderBy_Desc(String aliasName) { registerSpecifiedDerivedOrderBy_Desc(aliasName); return this; }

        public override void reflectRelationOnUnionQuery(MbConditionQuery baseQueryAsSuper, MbConditionQuery unionQueryAsSuper) {
            MbProductCQ baseQuery = (MbProductCQ)baseQueryAsSuper;
            MbProductCQ unionQuery = (MbProductCQ)unionQueryAsSuper;
            if (baseQuery.hasConditionQueryProductStatus()) {
                unionQuery.QueryProductStatus().reflectRelationOnUnionQuery(baseQuery.QueryProductStatus(), unionQuery.QueryProductStatus());
            }

        }
    
        protected MbProductStatusCQ _conditionQueryProductStatus;
        public MbProductStatusCQ QueryProductStatus() {
            return this.ConditionQueryProductStatus;
        }
        public MbProductStatusCQ ConditionQueryProductStatus {
            get {
                if (_conditionQueryProductStatus == null) {
                    _conditionQueryProductStatus = xcreateQueryProductStatus();
                    xsetupOuterJoin_ProductStatus();
                }
                return _conditionQueryProductStatus;
            }
        }
        protected MbProductStatusCQ xcreateQueryProductStatus() {
            String nrp = resolveNextRelationPathProductStatus();
            String jan = resolveJoinAliasName(nrp, xgetNextNestLevel());
            MbProductStatusCQ cq = new MbProductStatusCQ(this, xgetSqlClause(), jan, xgetNextNestLevel());
            cq.xsetForeignPropertyName("productStatus"); cq.xsetRelationPath(nrp); return cq;
        }
        public void xsetupOuterJoin_ProductStatus() {
            MbProductStatusCQ cq = ConditionQueryProductStatus;
            Map<String, String> joinOnMap = new LinkedHashMap<String, String>();
            joinOnMap.put("PRODUCT_STATUS_CODE", "PRODUCT_STATUS_CODE");
            registerOuterJoin(cq, joinOnMap);
        }
        protected String resolveNextRelationPathProductStatus() {
            return resolveNextRelationPath("product", "productStatus");
        }
        public bool hasConditionQueryProductStatus() {
            return _conditionQueryProductStatus != null;
        }


	    // ===============================================================================
	    //                                                                 Scalar SubQuery
	    //                                                                 ===============
	    protected Map<String, MbProductCQ> _scalarSubQueryMap;
	    public Map<String, MbProductCQ> ScalarSubQuery { get { return _scalarSubQueryMap; } }
	    public override String keepScalarSubQuery(MbProductCQ subQuery) {
	        if (_scalarSubQueryMap == null) { _scalarSubQueryMap = new LinkedHashMap<String, MbProductCQ>(); }
	        String key = "subQueryMapKey" + (_scalarSubQueryMap.size() + 1);
	        _scalarSubQueryMap.put(key, subQuery); return "ScalarSubQuery." + key;
	    }

        // ===============================================================================
        //                                                         Myself InScope SubQuery
        //                                                         =======================
        protected Map<String, MbProductCQ> _myselfInScopeSubQueryMap;
        public Map<String, MbProductCQ> MyselfInScopeSubQuery { get { return _myselfInScopeSubQueryMap; } }
        public override String keepMyselfInScopeSubQuery(MbProductCQ subQuery) {
            if (_myselfInScopeSubQueryMap == null) { _myselfInScopeSubQueryMap = new LinkedHashMap<String, MbProductCQ>(); }
            String key = "subQueryMapKey" + (_myselfInScopeSubQueryMap.size() + 1);
            _myselfInScopeSubQueryMap.put(key, subQuery); return "MyselfInScopeSubQuery." + key;
        }
    }
}
