
using System;

using DfExample.DBFlute.AllCommon.CBean;
using DfExample.DBFlute.AllCommon.CBean.CValue;
using DfExample.DBFlute.AllCommon.CBean.SClause;
using DfExample.DBFlute.AllCommon.JavaLike;
using DfExample.DBFlute.CBean.CQ;
using DfExample.DBFlute.CBean.CQ.Ciq;

namespace DfExample.DBFlute.CBean.CQ.BS {

    [System.Serializable]
    public class BsVdSynonymProductCQ : AbstractBsVdSynonymProductCQ {

        protected VdSynonymProductCIQ _inlineQuery;

        public BsVdSynonymProductCQ(ConditionQuery childQuery, SqlClause sqlClause, String aliasName, int nestLevel)
            : base(childQuery, sqlClause, aliasName, nestLevel) {}

        public VdSynonymProductCIQ Inline() {
            if (_inlineQuery == null) {
                _inlineQuery = new VdSynonymProductCIQ(xgetReferrerQuery(), xgetSqlClause(), xgetAliasName(), xgetNestLevel(), this);
            }
            _inlineQuery.xsetOnClause(false);
            return _inlineQuery;
        }
        
        public VdSynonymProductCIQ On() {
            if (isBaseQuery()) { throw new UnsupportedOperationException("Unsupported onClause of Base Table!"); }
            VdSynonymProductCIQ inlineQuery = Inline();
            inlineQuery.xsetOnClause(true);
            return inlineQuery;
        }


        protected ConditionValue _productId;
        public ConditionValue ProductId {
            get { if (_productId == null) { _productId = new ConditionValue(); } return _productId; }
        }
        protected override ConditionValue getCValueProductId() { return this.ProductId; }


        public BsVdSynonymProductCQ AddOrderBy_ProductId_Asc() { regOBA("PRODUCT_ID");return this; }
        public BsVdSynonymProductCQ AddOrderBy_ProductId_Desc() { regOBD("PRODUCT_ID");return this; }

        protected ConditionValue _productName;
        public ConditionValue ProductName {
            get { if (_productName == null) { _productName = new ConditionValue(); } return _productName; }
        }
        protected override ConditionValue getCValueProductName() { return this.ProductName; }


        public BsVdSynonymProductCQ AddOrderBy_ProductName_Asc() { regOBA("PRODUCT_NAME");return this; }
        public BsVdSynonymProductCQ AddOrderBy_ProductName_Desc() { regOBD("PRODUCT_NAME");return this; }

        protected ConditionValue _productHandleCode;
        public ConditionValue ProductHandleCode {
            get { if (_productHandleCode == null) { _productHandleCode = new ConditionValue(); } return _productHandleCode; }
        }
        protected override ConditionValue getCValueProductHandleCode() { return this.ProductHandleCode; }


        public BsVdSynonymProductCQ AddOrderBy_ProductHandleCode_Asc() { regOBA("PRODUCT_HANDLE_CODE");return this; }
        public BsVdSynonymProductCQ AddOrderBy_ProductHandleCode_Desc() { regOBD("PRODUCT_HANDLE_CODE");return this; }

        protected ConditionValue _productStatusCode;
        public ConditionValue ProductStatusCode {
            get { if (_productStatusCode == null) { _productStatusCode = new ConditionValue(); } return _productStatusCode; }
        }
        protected override ConditionValue getCValueProductStatusCode() { return this.ProductStatusCode; }


        protected Map<String, VdSynonymProductStatusCQ> _productStatusCode_InScopeSubQuery_VdSynonymProductStatusMap;
        public Map<String, VdSynonymProductStatusCQ> ProductStatusCode_InScopeSubQuery_VdSynonymProductStatus { get { return _productStatusCode_InScopeSubQuery_VdSynonymProductStatusMap; }}
        public override String keepProductStatusCode_InScopeSubQuery_VdSynonymProductStatus(VdSynonymProductStatusCQ subQuery) {
            if (_productStatusCode_InScopeSubQuery_VdSynonymProductStatusMap == null) { _productStatusCode_InScopeSubQuery_VdSynonymProductStatusMap = new LinkedHashMap<String, VdSynonymProductStatusCQ>(); }
            String key = "subQueryMapKey" + (_productStatusCode_InScopeSubQuery_VdSynonymProductStatusMap.size() + 1);
            _productStatusCode_InScopeSubQuery_VdSynonymProductStatusMap.put(key, subQuery); return "ProductStatusCode_InScopeSubQuery_VdSynonymProductStatus." + key;
        }

        protected Map<String, VdSynonymProductStatusCQ> _productStatusCode_NotInScopeSubQuery_VdSynonymProductStatusMap;
        public Map<String, VdSynonymProductStatusCQ> ProductStatusCode_NotInScopeSubQuery_VdSynonymProductStatus { get { return _productStatusCode_NotInScopeSubQuery_VdSynonymProductStatusMap; }}
        public override String keepProductStatusCode_NotInScopeSubQuery_VdSynonymProductStatus(VdSynonymProductStatusCQ subQuery) {
            if (_productStatusCode_NotInScopeSubQuery_VdSynonymProductStatusMap == null) { _productStatusCode_NotInScopeSubQuery_VdSynonymProductStatusMap = new LinkedHashMap<String, VdSynonymProductStatusCQ>(); }
            String key = "subQueryMapKey" + (_productStatusCode_NotInScopeSubQuery_VdSynonymProductStatusMap.size() + 1);
            _productStatusCode_NotInScopeSubQuery_VdSynonymProductStatusMap.put(key, subQuery); return "ProductStatusCode_NotInScopeSubQuery_VdSynonymProductStatus." + key;
        }

        public BsVdSynonymProductCQ AddOrderBy_ProductStatusCode_Asc() { regOBA("PRODUCT_STATUS_CODE");return this; }
        public BsVdSynonymProductCQ AddOrderBy_ProductStatusCode_Desc() { regOBD("PRODUCT_STATUS_CODE");return this; }

        protected ConditionValue _registerDatetime;
        public ConditionValue RegisterDatetime {
            get { if (_registerDatetime == null) { _registerDatetime = new ConditionValue(); } return _registerDatetime; }
        }
        protected override ConditionValue getCValueRegisterDatetime() { return this.RegisterDatetime; }


        public BsVdSynonymProductCQ AddOrderBy_RegisterDatetime_Asc() { regOBA("REGISTER_DATETIME");return this; }
        public BsVdSynonymProductCQ AddOrderBy_RegisterDatetime_Desc() { regOBD("REGISTER_DATETIME");return this; }

        protected ConditionValue _registerUser;
        public ConditionValue RegisterUser {
            get { if (_registerUser == null) { _registerUser = new ConditionValue(); } return _registerUser; }
        }
        protected override ConditionValue getCValueRegisterUser() { return this.RegisterUser; }


        public BsVdSynonymProductCQ AddOrderBy_RegisterUser_Asc() { regOBA("REGISTER_USER");return this; }
        public BsVdSynonymProductCQ AddOrderBy_RegisterUser_Desc() { regOBD("REGISTER_USER");return this; }

        protected ConditionValue _registerProcess;
        public ConditionValue RegisterProcess {
            get { if (_registerProcess == null) { _registerProcess = new ConditionValue(); } return _registerProcess; }
        }
        protected override ConditionValue getCValueRegisterProcess() { return this.RegisterProcess; }


        public BsVdSynonymProductCQ AddOrderBy_RegisterProcess_Asc() { regOBA("REGISTER_PROCESS");return this; }
        public BsVdSynonymProductCQ AddOrderBy_RegisterProcess_Desc() { regOBD("REGISTER_PROCESS");return this; }

        protected ConditionValue _updateDatetime;
        public ConditionValue UpdateDatetime {
            get { if (_updateDatetime == null) { _updateDatetime = new ConditionValue(); } return _updateDatetime; }
        }
        protected override ConditionValue getCValueUpdateDatetime() { return this.UpdateDatetime; }


        public BsVdSynonymProductCQ AddOrderBy_UpdateDatetime_Asc() { regOBA("UPDATE_DATETIME");return this; }
        public BsVdSynonymProductCQ AddOrderBy_UpdateDatetime_Desc() { regOBD("UPDATE_DATETIME");return this; }

        protected ConditionValue _updateUser;
        public ConditionValue UpdateUser {
            get { if (_updateUser == null) { _updateUser = new ConditionValue(); } return _updateUser; }
        }
        protected override ConditionValue getCValueUpdateUser() { return this.UpdateUser; }


        public BsVdSynonymProductCQ AddOrderBy_UpdateUser_Asc() { regOBA("UPDATE_USER");return this; }
        public BsVdSynonymProductCQ AddOrderBy_UpdateUser_Desc() { regOBD("UPDATE_USER");return this; }

        protected ConditionValue _updateProcess;
        public ConditionValue UpdateProcess {
            get { if (_updateProcess == null) { _updateProcess = new ConditionValue(); } return _updateProcess; }
        }
        protected override ConditionValue getCValueUpdateProcess() { return this.UpdateProcess; }


        public BsVdSynonymProductCQ AddOrderBy_UpdateProcess_Asc() { regOBA("UPDATE_PROCESS");return this; }
        public BsVdSynonymProductCQ AddOrderBy_UpdateProcess_Desc() { regOBD("UPDATE_PROCESS");return this; }

        protected ConditionValue _versionNo;
        public ConditionValue VersionNo {
            get { if (_versionNo == null) { _versionNo = new ConditionValue(); } return _versionNo; }
        }
        protected override ConditionValue getCValueVersionNo() { return this.VersionNo; }


        public BsVdSynonymProductCQ AddOrderBy_VersionNo_Asc() { regOBA("VERSION_NO");return this; }
        public BsVdSynonymProductCQ AddOrderBy_VersionNo_Desc() { regOBD("VERSION_NO");return this; }

        public BsVdSynonymProductCQ AddSpecifiedDerivedOrderBy_Asc(String aliasName) { registerSpecifiedDerivedOrderBy_Asc(aliasName); return this; }
        public BsVdSynonymProductCQ AddSpecifiedDerivedOrderBy_Desc(String aliasName) { registerSpecifiedDerivedOrderBy_Desc(aliasName); return this; }

        public override void reflectRelationOnUnionQuery(ConditionQuery baseQueryAsSuper, ConditionQuery unionQueryAsSuper) {
            VdSynonymProductCQ baseQuery = (VdSynonymProductCQ)baseQueryAsSuper;
            VdSynonymProductCQ unionQuery = (VdSynonymProductCQ)unionQueryAsSuper;
            if (baseQuery.hasConditionQueryVdSynonymProductStatus()) {
                unionQuery.QueryVdSynonymProductStatus().reflectRelationOnUnionQuery(baseQuery.QueryVdSynonymProductStatus(), unionQuery.QueryVdSynonymProductStatus());
            }

        }
    
        protected VdSynonymProductStatusCQ _conditionQueryVdSynonymProductStatus;
        public VdSynonymProductStatusCQ QueryVdSynonymProductStatus() {
            return this.ConditionQueryVdSynonymProductStatus;
        }
        public VdSynonymProductStatusCQ ConditionQueryVdSynonymProductStatus {
            get {
                if (_conditionQueryVdSynonymProductStatus == null) {
                    _conditionQueryVdSynonymProductStatus = xcreateQueryVdSynonymProductStatus();
                    xsetupOuterJoin_VdSynonymProductStatus();
                }
                return _conditionQueryVdSynonymProductStatus;
            }
        }
        protected VdSynonymProductStatusCQ xcreateQueryVdSynonymProductStatus() {
            String nrp = resolveNextRelationPathVdSynonymProductStatus();
            String jan = resolveJoinAliasName(nrp, xgetNextNestLevel());
            VdSynonymProductStatusCQ cq = new VdSynonymProductStatusCQ(this, xgetSqlClause(), jan, xgetNextNestLevel());
            cq.xsetForeignPropertyName("vdSynonymProductStatus"); cq.xsetRelationPath(nrp); return cq;
        }
        public void xsetupOuterJoin_VdSynonymProductStatus() {
            VdSynonymProductStatusCQ cq = ConditionQueryVdSynonymProductStatus;
            Map<String, String> joinOnMap = new LinkedHashMap<String, String>();
            joinOnMap.put("PRODUCT_STATUS_CODE", "PRODUCT_STATUS_CODE");
            registerOuterJoin(cq, joinOnMap);
        }
        protected String resolveNextRelationPathVdSynonymProductStatus() {
            return resolveNextRelationPath("VD_SYNONYM_PRODUCT", "vdSynonymProductStatus");
        }
        public bool hasConditionQueryVdSynonymProductStatus() {
            return _conditionQueryVdSynonymProductStatus != null;
        }


	    // ===============================================================================
	    //                                                                 Scalar SubQuery
	    //                                                                 ===============
	    protected Map<String, VdSynonymProductCQ> _scalarSubQueryMap;
	    public Map<String, VdSynonymProductCQ> ScalarSubQuery { get { return _scalarSubQueryMap; } }
	    public override String keepScalarSubQuery(VdSynonymProductCQ subQuery) {
	        if (_scalarSubQueryMap == null) { _scalarSubQueryMap = new LinkedHashMap<String, VdSynonymProductCQ>(); }
	        String key = "subQueryMapKey" + (_scalarSubQueryMap.size() + 1);
	        _scalarSubQueryMap.put(key, subQuery); return "ScalarSubQuery." + key;
	    }

        // ===============================================================================
        //                                                         Myself InScope SubQuery
        //                                                         =======================
        protected Map<String, VdSynonymProductCQ> _myselfInScopeSubQueryMap;
        public Map<String, VdSynonymProductCQ> MyselfInScopeSubQuery { get { return _myselfInScopeSubQueryMap; } }
        public override String keepMyselfInScopeSubQuery(VdSynonymProductCQ subQuery) {
            if (_myselfInScopeSubQueryMap == null) { _myselfInScopeSubQueryMap = new LinkedHashMap<String, VdSynonymProductCQ>(); }
            String key = "subQueryMapKey" + (_myselfInScopeSubQueryMap.size() + 1);
            _myselfInScopeSubQueryMap.put(key, subQuery); return "MyselfInScopeSubQuery." + key;
        }
    }
}
