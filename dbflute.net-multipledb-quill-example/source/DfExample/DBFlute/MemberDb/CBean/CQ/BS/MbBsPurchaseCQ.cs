
using System;

using DfExample.DBFlute.MemberDb.AllCommon.CBean;
using DfExample.DBFlute.MemberDb.AllCommon.CBean.CValue;
using DfExample.DBFlute.MemberDb.AllCommon.CBean.SClause;
using DfExample.DBFlute.MemberDb.AllCommon.JavaLike;
using DfExample.DBFlute.MemberDb.CBean.CQ;
using DfExample.DBFlute.MemberDb.CBean.CQ.Ciq;

namespace DfExample.DBFlute.MemberDb.CBean.CQ.BS {

    [System.Serializable]
    public class MbBsPurchaseCQ : MbAbstractBsPurchaseCQ {

        protected MbPurchaseCIQ _inlineQuery;

        public MbBsPurchaseCQ(MbConditionQuery childQuery, MbSqlClause sqlClause, String aliasName, int nestLevel)
            : base(childQuery, sqlClause, aliasName, nestLevel) {}

        public MbPurchaseCIQ Inline() {
            if (_inlineQuery == null) {
                _inlineQuery = new MbPurchaseCIQ(xgetReferrerQuery(), xgetSqlClause(), xgetAliasName(), xgetNestLevel(), this);
            }
            _inlineQuery.xsetOnClause(false);
            return _inlineQuery;
        }
        
        public MbPurchaseCIQ On() {
            if (isBaseQuery()) { throw new UnsupportedOperationException("Unsupported onClause of Base Table!"); }
            MbPurchaseCIQ inlineQuery = Inline();
            inlineQuery.xsetOnClause(true);
            return inlineQuery;
        }


        protected MbConditionValue _purchaseId;
        public MbConditionValue PurchaseId {
            get { if (_purchaseId == null) { _purchaseId = new MbConditionValue(); } return _purchaseId; }
        }
        protected override MbConditionValue getCValuePurchaseId() { return this.PurchaseId; }


        public MbBsPurchaseCQ AddOrderBy_PurchaseId_Asc() { regOBA("PURCHASE_ID");return this; }
        public MbBsPurchaseCQ AddOrderBy_PurchaseId_Desc() { regOBD("PURCHASE_ID");return this; }

        protected MbConditionValue _memberId;
        public MbConditionValue MemberId {
            get { if (_memberId == null) { _memberId = new MbConditionValue(); } return _memberId; }
        }
        protected override MbConditionValue getCValueMemberId() { return this.MemberId; }


        protected Map<String, MbMemberCQ> _memberId_InScopeSubQuery_MemberMap;
        public Map<String, MbMemberCQ> MemberId_InScopeSubQuery_Member { get { return _memberId_InScopeSubQuery_MemberMap; }}
        public override String keepMemberId_InScopeSubQuery_Member(MbMemberCQ subQuery) {
            if (_memberId_InScopeSubQuery_MemberMap == null) { _memberId_InScopeSubQuery_MemberMap = new LinkedHashMap<String, MbMemberCQ>(); }
            String key = "subQueryMapKey" + (_memberId_InScopeSubQuery_MemberMap.size() + 1);
            _memberId_InScopeSubQuery_MemberMap.put(key, subQuery); return "MemberId_InScopeSubQuery_Member." + key;
        }

        protected Map<String, MbMemberCQ> _memberId_NotInScopeSubQuery_MemberMap;
        public Map<String, MbMemberCQ> MemberId_NotInScopeSubQuery_Member { get { return _memberId_NotInScopeSubQuery_MemberMap; }}
        public override String keepMemberId_NotInScopeSubQuery_Member(MbMemberCQ subQuery) {
            if (_memberId_NotInScopeSubQuery_MemberMap == null) { _memberId_NotInScopeSubQuery_MemberMap = new LinkedHashMap<String, MbMemberCQ>(); }
            String key = "subQueryMapKey" + (_memberId_NotInScopeSubQuery_MemberMap.size() + 1);
            _memberId_NotInScopeSubQuery_MemberMap.put(key, subQuery); return "MemberId_NotInScopeSubQuery_Member." + key;
        }

        public MbBsPurchaseCQ AddOrderBy_MemberId_Asc() { regOBA("MEMBER_ID");return this; }
        public MbBsPurchaseCQ AddOrderBy_MemberId_Desc() { regOBD("MEMBER_ID");return this; }

        protected MbConditionValue _productId;
        public MbConditionValue ProductId {
            get { if (_productId == null) { _productId = new MbConditionValue(); } return _productId; }
        }
        protected override MbConditionValue getCValueProductId() { return this.ProductId; }


        protected Map<String, MbProductCQ> _productId_InScopeSubQuery_ProductMap;
        public Map<String, MbProductCQ> ProductId_InScopeSubQuery_Product { get { return _productId_InScopeSubQuery_ProductMap; }}
        public override String keepProductId_InScopeSubQuery_Product(MbProductCQ subQuery) {
            if (_productId_InScopeSubQuery_ProductMap == null) { _productId_InScopeSubQuery_ProductMap = new LinkedHashMap<String, MbProductCQ>(); }
            String key = "subQueryMapKey" + (_productId_InScopeSubQuery_ProductMap.size() + 1);
            _productId_InScopeSubQuery_ProductMap.put(key, subQuery); return "ProductId_InScopeSubQuery_Product." + key;
        }

        protected Map<String, MbProductCQ> _productId_NotInScopeSubQuery_ProductMap;
        public Map<String, MbProductCQ> ProductId_NotInScopeSubQuery_Product { get { return _productId_NotInScopeSubQuery_ProductMap; }}
        public override String keepProductId_NotInScopeSubQuery_Product(MbProductCQ subQuery) {
            if (_productId_NotInScopeSubQuery_ProductMap == null) { _productId_NotInScopeSubQuery_ProductMap = new LinkedHashMap<String, MbProductCQ>(); }
            String key = "subQueryMapKey" + (_productId_NotInScopeSubQuery_ProductMap.size() + 1);
            _productId_NotInScopeSubQuery_ProductMap.put(key, subQuery); return "ProductId_NotInScopeSubQuery_Product." + key;
        }

        public MbBsPurchaseCQ AddOrderBy_ProductId_Asc() { regOBA("PRODUCT_ID");return this; }
        public MbBsPurchaseCQ AddOrderBy_ProductId_Desc() { regOBD("PRODUCT_ID");return this; }

        protected MbConditionValue _purchaseDatetime;
        public MbConditionValue PurchaseDatetime {
            get { if (_purchaseDatetime == null) { _purchaseDatetime = new MbConditionValue(); } return _purchaseDatetime; }
        }
        protected override MbConditionValue getCValuePurchaseDatetime() { return this.PurchaseDatetime; }


        public MbBsPurchaseCQ AddOrderBy_PurchaseDatetime_Asc() { regOBA("PURCHASE_DATETIME");return this; }
        public MbBsPurchaseCQ AddOrderBy_PurchaseDatetime_Desc() { regOBD("PURCHASE_DATETIME");return this; }

        protected MbConditionValue _purchaseCount;
        public MbConditionValue PurchaseCount {
            get { if (_purchaseCount == null) { _purchaseCount = new MbConditionValue(); } return _purchaseCount; }
        }
        protected override MbConditionValue getCValuePurchaseCount() { return this.PurchaseCount; }


        public MbBsPurchaseCQ AddOrderBy_PurchaseCount_Asc() { regOBA("PURCHASE_COUNT");return this; }
        public MbBsPurchaseCQ AddOrderBy_PurchaseCount_Desc() { regOBD("PURCHASE_COUNT");return this; }

        protected MbConditionValue _purchasePrice;
        public MbConditionValue PurchasePrice {
            get { if (_purchasePrice == null) { _purchasePrice = new MbConditionValue(); } return _purchasePrice; }
        }
        protected override MbConditionValue getCValuePurchasePrice() { return this.PurchasePrice; }


        public MbBsPurchaseCQ AddOrderBy_PurchasePrice_Asc() { regOBA("PURCHASE_PRICE");return this; }
        public MbBsPurchaseCQ AddOrderBy_PurchasePrice_Desc() { regOBD("PURCHASE_PRICE");return this; }

        protected MbConditionValue _paymentCompleteFlg;
        public MbConditionValue PaymentCompleteFlg {
            get { if (_paymentCompleteFlg == null) { _paymentCompleteFlg = new MbConditionValue(); } return _paymentCompleteFlg; }
        }
        protected override MbConditionValue getCValuePaymentCompleteFlg() { return this.PaymentCompleteFlg; }


        public MbBsPurchaseCQ AddOrderBy_PaymentCompleteFlg_Asc() { regOBA("PAYMENT_COMPLETE_FLG");return this; }
        public MbBsPurchaseCQ AddOrderBy_PaymentCompleteFlg_Desc() { regOBD("PAYMENT_COMPLETE_FLG");return this; }

        protected MbConditionValue _registerDatetime;
        public MbConditionValue RegisterDatetime {
            get { if (_registerDatetime == null) { _registerDatetime = new MbConditionValue(); } return _registerDatetime; }
        }
        protected override MbConditionValue getCValueRegisterDatetime() { return this.RegisterDatetime; }


        public MbBsPurchaseCQ AddOrderBy_RegisterDatetime_Asc() { regOBA("REGISTER_DATETIME");return this; }
        public MbBsPurchaseCQ AddOrderBy_RegisterDatetime_Desc() { regOBD("REGISTER_DATETIME");return this; }

        protected MbConditionValue _registerUser;
        public MbConditionValue RegisterUser {
            get { if (_registerUser == null) { _registerUser = new MbConditionValue(); } return _registerUser; }
        }
        protected override MbConditionValue getCValueRegisterUser() { return this.RegisterUser; }


        public MbBsPurchaseCQ AddOrderBy_RegisterUser_Asc() { regOBA("REGISTER_USER");return this; }
        public MbBsPurchaseCQ AddOrderBy_RegisterUser_Desc() { regOBD("REGISTER_USER");return this; }

        protected MbConditionValue _registerProcess;
        public MbConditionValue RegisterProcess {
            get { if (_registerProcess == null) { _registerProcess = new MbConditionValue(); } return _registerProcess; }
        }
        protected override MbConditionValue getCValueRegisterProcess() { return this.RegisterProcess; }


        public MbBsPurchaseCQ AddOrderBy_RegisterProcess_Asc() { regOBA("REGISTER_PROCESS");return this; }
        public MbBsPurchaseCQ AddOrderBy_RegisterProcess_Desc() { regOBD("REGISTER_PROCESS");return this; }

        protected MbConditionValue _updateDatetime;
        public MbConditionValue UpdateDatetime {
            get { if (_updateDatetime == null) { _updateDatetime = new MbConditionValue(); } return _updateDatetime; }
        }
        protected override MbConditionValue getCValueUpdateDatetime() { return this.UpdateDatetime; }


        public MbBsPurchaseCQ AddOrderBy_UpdateDatetime_Asc() { regOBA("UPDATE_DATETIME");return this; }
        public MbBsPurchaseCQ AddOrderBy_UpdateDatetime_Desc() { regOBD("UPDATE_DATETIME");return this; }

        protected MbConditionValue _updateUser;
        public MbConditionValue UpdateUser {
            get { if (_updateUser == null) { _updateUser = new MbConditionValue(); } return _updateUser; }
        }
        protected override MbConditionValue getCValueUpdateUser() { return this.UpdateUser; }


        public MbBsPurchaseCQ AddOrderBy_UpdateUser_Asc() { regOBA("UPDATE_USER");return this; }
        public MbBsPurchaseCQ AddOrderBy_UpdateUser_Desc() { regOBD("UPDATE_USER");return this; }

        protected MbConditionValue _updateProcess;
        public MbConditionValue UpdateProcess {
            get { if (_updateProcess == null) { _updateProcess = new MbConditionValue(); } return _updateProcess; }
        }
        protected override MbConditionValue getCValueUpdateProcess() { return this.UpdateProcess; }


        public MbBsPurchaseCQ AddOrderBy_UpdateProcess_Asc() { regOBA("UPDATE_PROCESS");return this; }
        public MbBsPurchaseCQ AddOrderBy_UpdateProcess_Desc() { regOBD("UPDATE_PROCESS");return this; }

        protected MbConditionValue _versionNo;
        public MbConditionValue VersionNo {
            get { if (_versionNo == null) { _versionNo = new MbConditionValue(); } return _versionNo; }
        }
        protected override MbConditionValue getCValueVersionNo() { return this.VersionNo; }


        public MbBsPurchaseCQ AddOrderBy_VersionNo_Asc() { regOBA("VERSION_NO");return this; }
        public MbBsPurchaseCQ AddOrderBy_VersionNo_Desc() { regOBD("VERSION_NO");return this; }

        public MbBsPurchaseCQ AddSpecifiedDerivedOrderBy_Asc(String aliasName) { registerSpecifiedDerivedOrderBy_Asc(aliasName); return this; }
        public MbBsPurchaseCQ AddSpecifiedDerivedOrderBy_Desc(String aliasName) { registerSpecifiedDerivedOrderBy_Desc(aliasName); return this; }

        public override void reflectRelationOnUnionQuery(MbConditionQuery baseQueryAsSuper, MbConditionQuery unionQueryAsSuper) {
            MbPurchaseCQ baseQuery = (MbPurchaseCQ)baseQueryAsSuper;
            MbPurchaseCQ unionQuery = (MbPurchaseCQ)unionQueryAsSuper;
            if (baseQuery.hasConditionQueryMember()) {
                unionQuery.QueryMember().reflectRelationOnUnionQuery(baseQuery.QueryMember(), unionQuery.QueryMember());
            }
            if (baseQuery.hasConditionQueryProduct()) {
                unionQuery.QueryProduct().reflectRelationOnUnionQuery(baseQuery.QueryProduct(), unionQuery.QueryProduct());
            }

        }
    
        protected MbMemberCQ _conditionQueryMember;
        public MbMemberCQ QueryMember() {
            return this.ConditionQueryMember;
        }
        public MbMemberCQ ConditionQueryMember {
            get {
                if (_conditionQueryMember == null) {
                    _conditionQueryMember = xcreateQueryMember();
                    xsetupOuterJoin_Member();
                }
                return _conditionQueryMember;
            }
        }
        protected MbMemberCQ xcreateQueryMember() {
            String nrp = resolveNextRelationPathMember();
            String jan = resolveJoinAliasName(nrp, xgetNextNestLevel());
            MbMemberCQ cq = new MbMemberCQ(this, xgetSqlClause(), jan, xgetNextNestLevel());
            cq.xsetForeignPropertyName("member"); cq.xsetRelationPath(nrp); return cq;
        }
        public void xsetupOuterJoin_Member() {
            MbMemberCQ cq = ConditionQueryMember;
            Map<String, String> joinOnMap = new LinkedHashMap<String, String>();
            joinOnMap.put("MEMBER_ID", "MEMBER_ID");
            registerOuterJoin(cq, joinOnMap);
        }
        protected String resolveNextRelationPathMember() {
            return resolveNextRelationPath("purchase", "member");
        }
        public bool hasConditionQueryMember() {
            return _conditionQueryMember != null;
        }
        protected MbProductCQ _conditionQueryProduct;
        public MbProductCQ QueryProduct() {
            return this.ConditionQueryProduct;
        }
        public MbProductCQ ConditionQueryProduct {
            get {
                if (_conditionQueryProduct == null) {
                    _conditionQueryProduct = xcreateQueryProduct();
                    xsetupOuterJoin_Product();
                }
                return _conditionQueryProduct;
            }
        }
        protected MbProductCQ xcreateQueryProduct() {
            String nrp = resolveNextRelationPathProduct();
            String jan = resolveJoinAliasName(nrp, xgetNextNestLevel());
            MbProductCQ cq = new MbProductCQ(this, xgetSqlClause(), jan, xgetNextNestLevel());
            cq.xsetForeignPropertyName("product"); cq.xsetRelationPath(nrp); return cq;
        }
        public void xsetupOuterJoin_Product() {
            MbProductCQ cq = ConditionQueryProduct;
            Map<String, String> joinOnMap = new LinkedHashMap<String, String>();
            joinOnMap.put("PRODUCT_ID", "PRODUCT_ID");
            registerOuterJoin(cq, joinOnMap);
        }
        protected String resolveNextRelationPathProduct() {
            return resolveNextRelationPath("purchase", "product");
        }
        public bool hasConditionQueryProduct() {
            return _conditionQueryProduct != null;
        }


	    // ===============================================================================
	    //                                                                 Scalar SubQuery
	    //                                                                 ===============
	    protected Map<String, MbPurchaseCQ> _scalarSubQueryMap;
	    public Map<String, MbPurchaseCQ> ScalarSubQuery { get { return _scalarSubQueryMap; } }
	    public override String keepScalarSubQuery(MbPurchaseCQ subQuery) {
	        if (_scalarSubQueryMap == null) { _scalarSubQueryMap = new LinkedHashMap<String, MbPurchaseCQ>(); }
	        String key = "subQueryMapKey" + (_scalarSubQueryMap.size() + 1);
	        _scalarSubQueryMap.put(key, subQuery); return "ScalarSubQuery." + key;
	    }

        // ===============================================================================
        //                                                         Myself InScope SubQuery
        //                                                         =======================
        protected Map<String, MbPurchaseCQ> _myselfInScopeSubQueryMap;
        public Map<String, MbPurchaseCQ> MyselfInScopeSubQuery { get { return _myselfInScopeSubQueryMap; } }
        public override String keepMyselfInScopeSubQuery(MbPurchaseCQ subQuery) {
            if (_myselfInScopeSubQueryMap == null) { _myselfInScopeSubQueryMap = new LinkedHashMap<String, MbPurchaseCQ>(); }
            String key = "subQueryMapKey" + (_myselfInScopeSubQueryMap.size() + 1);
            _myselfInScopeSubQueryMap.put(key, subQuery); return "MyselfInScopeSubQuery." + key;
        }
    }
}
