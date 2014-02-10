
using System;

using DfExample.DBFlute.AllCommon.CBean;
using DfExample.DBFlute.AllCommon.CBean.CValue;
using DfExample.DBFlute.AllCommon.CBean.SClause;
using DfExample.DBFlute.AllCommon.JavaLike;
using DfExample.DBFlute.CBean.CQ;
using DfExample.DBFlute.CBean.CQ.Ciq;

namespace DfExample.DBFlute.CBean.CQ.BS {

    [System.Serializable]
    public class BsPurchaseCQ : AbstractBsPurchaseCQ {

        protected PurchaseCIQ _inlineQuery;

        public BsPurchaseCQ(ConditionQuery childQuery, SqlClause sqlClause, String aliasName, int nestLevel)
            : base(childQuery, sqlClause, aliasName, nestLevel) {}

        public PurchaseCIQ Inline() {
            if (_inlineQuery == null) {
                _inlineQuery = new PurchaseCIQ(xgetReferrerQuery(), xgetSqlClause(), xgetAliasName(), xgetNestLevel(), this);
            }
            _inlineQuery.xsetOnClause(false);
            return _inlineQuery;
        }
        
        public PurchaseCIQ On() {
            if (isBaseQuery()) { throw new UnsupportedOperationException("Unsupported onClause of Base Table!"); }
            PurchaseCIQ inlineQuery = Inline();
            inlineQuery.xsetOnClause(true);
            return inlineQuery;
        }


        protected ConditionValue _purchaseId;
        public ConditionValue PurchaseId {
            get { if (_purchaseId == null) { _purchaseId = new ConditionValue(); } return _purchaseId; }
        }
        protected override ConditionValue getCValuePurchaseId() { return this.PurchaseId; }


        public BsPurchaseCQ AddOrderBy_PurchaseId_Asc() { regOBA("PURCHASE_ID");return this; }
        public BsPurchaseCQ AddOrderBy_PurchaseId_Desc() { regOBD("PURCHASE_ID");return this; }

        protected ConditionValue _memberId;
        public ConditionValue MemberId {
            get { if (_memberId == null) { _memberId = new ConditionValue(); } return _memberId; }
        }
        protected override ConditionValue getCValueMemberId() { return this.MemberId; }


        protected Map<String, MemberCQ> _memberId_InScopeSubQuery_MemberMap;
        public Map<String, MemberCQ> MemberId_InScopeSubQuery_Member { get { return _memberId_InScopeSubQuery_MemberMap; }}
        public override String keepMemberId_InScopeSubQuery_Member(MemberCQ subQuery) {
            if (_memberId_InScopeSubQuery_MemberMap == null) { _memberId_InScopeSubQuery_MemberMap = new LinkedHashMap<String, MemberCQ>(); }
            String key = "subQueryMapKey" + (_memberId_InScopeSubQuery_MemberMap.size() + 1);
            _memberId_InScopeSubQuery_MemberMap.put(key, subQuery); return "MemberId_InScopeSubQuery_Member." + key;
        }

        protected Map<String, MemberCQ> _memberId_NotInScopeSubQuery_MemberMap;
        public Map<String, MemberCQ> MemberId_NotInScopeSubQuery_Member { get { return _memberId_NotInScopeSubQuery_MemberMap; }}
        public override String keepMemberId_NotInScopeSubQuery_Member(MemberCQ subQuery) {
            if (_memberId_NotInScopeSubQuery_MemberMap == null) { _memberId_NotInScopeSubQuery_MemberMap = new LinkedHashMap<String, MemberCQ>(); }
            String key = "subQueryMapKey" + (_memberId_NotInScopeSubQuery_MemberMap.size() + 1);
            _memberId_NotInScopeSubQuery_MemberMap.put(key, subQuery); return "MemberId_NotInScopeSubQuery_Member." + key;
        }

        public BsPurchaseCQ AddOrderBy_MemberId_Asc() { regOBA("MEMBER_ID");return this; }
        public BsPurchaseCQ AddOrderBy_MemberId_Desc() { regOBD("MEMBER_ID");return this; }

        protected ConditionValue _productId;
        public ConditionValue ProductId {
            get { if (_productId == null) { _productId = new ConditionValue(); } return _productId; }
        }
        protected override ConditionValue getCValueProductId() { return this.ProductId; }


        protected Map<String, ProductCQ> _productId_InScopeSubQuery_ProductMap;
        public Map<String, ProductCQ> ProductId_InScopeSubQuery_Product { get { return _productId_InScopeSubQuery_ProductMap; }}
        public override String keepProductId_InScopeSubQuery_Product(ProductCQ subQuery) {
            if (_productId_InScopeSubQuery_ProductMap == null) { _productId_InScopeSubQuery_ProductMap = new LinkedHashMap<String, ProductCQ>(); }
            String key = "subQueryMapKey" + (_productId_InScopeSubQuery_ProductMap.size() + 1);
            _productId_InScopeSubQuery_ProductMap.put(key, subQuery); return "ProductId_InScopeSubQuery_Product." + key;
        }

        protected Map<String, ProductCQ> _productId_NotInScopeSubQuery_ProductMap;
        public Map<String, ProductCQ> ProductId_NotInScopeSubQuery_Product { get { return _productId_NotInScopeSubQuery_ProductMap; }}
        public override String keepProductId_NotInScopeSubQuery_Product(ProductCQ subQuery) {
            if (_productId_NotInScopeSubQuery_ProductMap == null) { _productId_NotInScopeSubQuery_ProductMap = new LinkedHashMap<String, ProductCQ>(); }
            String key = "subQueryMapKey" + (_productId_NotInScopeSubQuery_ProductMap.size() + 1);
            _productId_NotInScopeSubQuery_ProductMap.put(key, subQuery); return "ProductId_NotInScopeSubQuery_Product." + key;
        }

        public BsPurchaseCQ AddOrderBy_ProductId_Asc() { regOBA("PRODUCT_ID");return this; }
        public BsPurchaseCQ AddOrderBy_ProductId_Desc() { regOBD("PRODUCT_ID");return this; }

        protected ConditionValue _purchaseDatetime;
        public ConditionValue PurchaseDatetime {
            get { if (_purchaseDatetime == null) { _purchaseDatetime = new ConditionValue(); } return _purchaseDatetime; }
        }
        protected override ConditionValue getCValuePurchaseDatetime() { return this.PurchaseDatetime; }


        public BsPurchaseCQ AddOrderBy_PurchaseDatetime_Asc() { regOBA("PURCHASE_DATETIME");return this; }
        public BsPurchaseCQ AddOrderBy_PurchaseDatetime_Desc() { regOBD("PURCHASE_DATETIME");return this; }

        protected ConditionValue _purchaseCount;
        public ConditionValue PurchaseCount {
            get { if (_purchaseCount == null) { _purchaseCount = new ConditionValue(); } return _purchaseCount; }
        }
        protected override ConditionValue getCValuePurchaseCount() { return this.PurchaseCount; }


        public BsPurchaseCQ AddOrderBy_PurchaseCount_Asc() { regOBA("PURCHASE_COUNT");return this; }
        public BsPurchaseCQ AddOrderBy_PurchaseCount_Desc() { regOBD("PURCHASE_COUNT");return this; }

        protected ConditionValue _purchasePrice;
        public ConditionValue PurchasePrice {
            get { if (_purchasePrice == null) { _purchasePrice = new ConditionValue(); } return _purchasePrice; }
        }
        protected override ConditionValue getCValuePurchasePrice() { return this.PurchasePrice; }


        public BsPurchaseCQ AddOrderBy_PurchasePrice_Asc() { regOBA("PURCHASE_PRICE");return this; }
        public BsPurchaseCQ AddOrderBy_PurchasePrice_Desc() { regOBD("PURCHASE_PRICE");return this; }

        protected ConditionValue _paymentCompleteFlg;
        public ConditionValue PaymentCompleteFlg {
            get { if (_paymentCompleteFlg == null) { _paymentCompleteFlg = new ConditionValue(); } return _paymentCompleteFlg; }
        }
        protected override ConditionValue getCValuePaymentCompleteFlg() { return this.PaymentCompleteFlg; }


        public BsPurchaseCQ AddOrderBy_PaymentCompleteFlg_Asc() { regOBA("PAYMENT_COMPLETE_FLG");return this; }
        public BsPurchaseCQ AddOrderBy_PaymentCompleteFlg_Desc() { regOBD("PAYMENT_COMPLETE_FLG");return this; }

        protected ConditionValue _registerDatetime;
        public ConditionValue RegisterDatetime {
            get { if (_registerDatetime == null) { _registerDatetime = new ConditionValue(); } return _registerDatetime; }
        }
        protected override ConditionValue getCValueRegisterDatetime() { return this.RegisterDatetime; }


        public BsPurchaseCQ AddOrderBy_RegisterDatetime_Asc() { regOBA("REGISTER_DATETIME");return this; }
        public BsPurchaseCQ AddOrderBy_RegisterDatetime_Desc() { regOBD("REGISTER_DATETIME");return this; }

        protected ConditionValue _registerUser;
        public ConditionValue RegisterUser {
            get { if (_registerUser == null) { _registerUser = new ConditionValue(); } return _registerUser; }
        }
        protected override ConditionValue getCValueRegisterUser() { return this.RegisterUser; }


        public BsPurchaseCQ AddOrderBy_RegisterUser_Asc() { regOBA("REGISTER_USER");return this; }
        public BsPurchaseCQ AddOrderBy_RegisterUser_Desc() { regOBD("REGISTER_USER");return this; }

        protected ConditionValue _registerProcess;
        public ConditionValue RegisterProcess {
            get { if (_registerProcess == null) { _registerProcess = new ConditionValue(); } return _registerProcess; }
        }
        protected override ConditionValue getCValueRegisterProcess() { return this.RegisterProcess; }


        public BsPurchaseCQ AddOrderBy_RegisterProcess_Asc() { regOBA("REGISTER_PROCESS");return this; }
        public BsPurchaseCQ AddOrderBy_RegisterProcess_Desc() { regOBD("REGISTER_PROCESS");return this; }

        protected ConditionValue _updateDatetime;
        public ConditionValue UpdateDatetime {
            get { if (_updateDatetime == null) { _updateDatetime = new ConditionValue(); } return _updateDatetime; }
        }
        protected override ConditionValue getCValueUpdateDatetime() { return this.UpdateDatetime; }


        public BsPurchaseCQ AddOrderBy_UpdateDatetime_Asc() { regOBA("UPDATE_DATETIME");return this; }
        public BsPurchaseCQ AddOrderBy_UpdateDatetime_Desc() { regOBD("UPDATE_DATETIME");return this; }

        protected ConditionValue _updateUser;
        public ConditionValue UpdateUser {
            get { if (_updateUser == null) { _updateUser = new ConditionValue(); } return _updateUser; }
        }
        protected override ConditionValue getCValueUpdateUser() { return this.UpdateUser; }


        public BsPurchaseCQ AddOrderBy_UpdateUser_Asc() { regOBA("UPDATE_USER");return this; }
        public BsPurchaseCQ AddOrderBy_UpdateUser_Desc() { regOBD("UPDATE_USER");return this; }

        protected ConditionValue _updateProcess;
        public ConditionValue UpdateProcess {
            get { if (_updateProcess == null) { _updateProcess = new ConditionValue(); } return _updateProcess; }
        }
        protected override ConditionValue getCValueUpdateProcess() { return this.UpdateProcess; }


        public BsPurchaseCQ AddOrderBy_UpdateProcess_Asc() { regOBA("UPDATE_PROCESS");return this; }
        public BsPurchaseCQ AddOrderBy_UpdateProcess_Desc() { regOBD("UPDATE_PROCESS");return this; }

        protected ConditionValue _versionNo;
        public ConditionValue VersionNo {
            get { if (_versionNo == null) { _versionNo = new ConditionValue(); } return _versionNo; }
        }
        protected override ConditionValue getCValueVersionNo() { return this.VersionNo; }


        public BsPurchaseCQ AddOrderBy_VersionNo_Asc() { regOBA("VERSION_NO");return this; }
        public BsPurchaseCQ AddOrderBy_VersionNo_Desc() { regOBD("VERSION_NO");return this; }

        public BsPurchaseCQ AddSpecifiedDerivedOrderBy_Asc(String aliasName) { registerSpecifiedDerivedOrderBy_Asc(aliasName); return this; }
        public BsPurchaseCQ AddSpecifiedDerivedOrderBy_Desc(String aliasName) { registerSpecifiedDerivedOrderBy_Desc(aliasName); return this; }

        public override void reflectRelationOnUnionQuery(ConditionQuery baseQueryAsSuper, ConditionQuery unionQueryAsSuper) {
            PurchaseCQ baseQuery = (PurchaseCQ)baseQueryAsSuper;
            PurchaseCQ unionQuery = (PurchaseCQ)unionQueryAsSuper;
            if (baseQuery.hasConditionQueryMember()) {
                unionQuery.QueryMember().reflectRelationOnUnionQuery(baseQuery.QueryMember(), unionQuery.QueryMember());
            }
            if (baseQuery.hasConditionQueryProduct()) {
                unionQuery.QueryProduct().reflectRelationOnUnionQuery(baseQuery.QueryProduct(), unionQuery.QueryProduct());
            }

        }
    
        protected MemberCQ _conditionQueryMember;
        public MemberCQ QueryMember() {
            return this.ConditionQueryMember;
        }
        public MemberCQ ConditionQueryMember {
            get {
                if (_conditionQueryMember == null) {
                    _conditionQueryMember = xcreateQueryMember();
                    xsetupOuterJoin_Member();
                }
                return _conditionQueryMember;
            }
        }
        protected MemberCQ xcreateQueryMember() {
            String nrp = resolveNextRelationPathMember();
            String jan = resolveJoinAliasName(nrp, xgetNextNestLevel());
            MemberCQ cq = new MemberCQ(this, xgetSqlClause(), jan, xgetNextNestLevel());
            cq.xsetForeignPropertyName("member"); cq.xsetRelationPath(nrp); return cq;
        }
        public void xsetupOuterJoin_Member() {
            MemberCQ cq = ConditionQueryMember;
            Map<String, String> joinOnMap = new LinkedHashMap<String, String>();
            joinOnMap.put("MEMBER_ID", "MEMBER_ID");
            registerOuterJoin(cq, joinOnMap);
        }
        protected String resolveNextRelationPathMember() {
            return resolveNextRelationPath("PURCHASE", "member");
        }
        public bool hasConditionQueryMember() {
            return _conditionQueryMember != null;
        }
        protected ProductCQ _conditionQueryProduct;
        public ProductCQ QueryProduct() {
            return this.ConditionQueryProduct;
        }
        public ProductCQ ConditionQueryProduct {
            get {
                if (_conditionQueryProduct == null) {
                    _conditionQueryProduct = xcreateQueryProduct();
                    xsetupOuterJoin_Product();
                }
                return _conditionQueryProduct;
            }
        }
        protected ProductCQ xcreateQueryProduct() {
            String nrp = resolveNextRelationPathProduct();
            String jan = resolveJoinAliasName(nrp, xgetNextNestLevel());
            ProductCQ cq = new ProductCQ(this, xgetSqlClause(), jan, xgetNextNestLevel());
            cq.xsetForeignPropertyName("product"); cq.xsetRelationPath(nrp); return cq;
        }
        public void xsetupOuterJoin_Product() {
            ProductCQ cq = ConditionQueryProduct;
            Map<String, String> joinOnMap = new LinkedHashMap<String, String>();
            joinOnMap.put("PRODUCT_ID", "PRODUCT_ID");
            registerOuterJoin(cq, joinOnMap);
        }
        protected String resolveNextRelationPathProduct() {
            return resolveNextRelationPath("PURCHASE", "product");
        }
        public bool hasConditionQueryProduct() {
            return _conditionQueryProduct != null;
        }


	    // ===============================================================================
	    //                                                                 Scalar SubQuery
	    //                                                                 ===============
	    protected Map<String, PurchaseCQ> _scalarSubQueryMap;
	    public Map<String, PurchaseCQ> ScalarSubQuery { get { return _scalarSubQueryMap; } }
	    public override String keepScalarSubQuery(PurchaseCQ subQuery) {
	        if (_scalarSubQueryMap == null) { _scalarSubQueryMap = new LinkedHashMap<String, PurchaseCQ>(); }
	        String key = "subQueryMapKey" + (_scalarSubQueryMap.size() + 1);
	        _scalarSubQueryMap.put(key, subQuery); return "ScalarSubQuery." + key;
	    }

        // ===============================================================================
        //                                                         Myself InScope SubQuery
        //                                                         =======================
        protected Map<String, PurchaseCQ> _myselfInScopeSubQueryMap;
        public Map<String, PurchaseCQ> MyselfInScopeSubQuery { get { return _myselfInScopeSubQueryMap; } }
        public override String keepMyselfInScopeSubQuery(PurchaseCQ subQuery) {
            if (_myselfInScopeSubQueryMap == null) { _myselfInScopeSubQueryMap = new LinkedHashMap<String, PurchaseCQ>(); }
            String key = "subQueryMapKey" + (_myselfInScopeSubQueryMap.size() + 1);
            _myselfInScopeSubQueryMap.put(key, subQuery); return "MyselfInScopeSubQuery." + key;
        }
    }
}
