
using System;
using System.Collections.Generic;

using DfExample.DBFlute.MemberDb.AllCommon;
using DfExample.DBFlute.MemberDb.AllCommon.CBean;
using DfExample.DBFlute.MemberDb.AllCommon.CBean.CKey;
using DfExample.DBFlute.MemberDb.AllCommon.CBean.COption;
using DfExample.DBFlute.MemberDb.AllCommon.CBean.CValue;
using DfExample.DBFlute.MemberDb.AllCommon.CBean.SClause;

namespace DfExample.DBFlute.MemberDb.CBean.CQ.BS {

    [System.Serializable]
    public abstract class MbAbstractBsProductCQ : MbAbstractConditionQuery {

        public MbAbstractBsProductCQ(MbConditionQuery childQuery, MbSqlClause sqlClause, String aliasName, int nestLevel)
            : base(childQuery, sqlClause, aliasName, nestLevel) {}

        public override String getTableDbName() { return "product"; }
        public override String getTableSqlName() { return "product"; }

        public void SetProductId_Equal(int? v) { regProductId(CK_EQ, v); }
        public void SetProductId_GreaterThan(int? v) { regProductId(CK_GT, v); }
        public void SetProductId_LessThan(int? v) { regProductId(CK_LT, v); }
        public void SetProductId_GreaterEqual(int? v) { regProductId(CK_GE, v); }
        public void SetProductId_LessEqual(int? v) { regProductId(CK_LE, v); }
        public void SetProductId_InScope(IList<int?> ls) { regINS<int?>(CK_INS, cTL<int?>(ls), getCValueProductId(), "PRODUCT_ID"); }
        public void SetProductId_NotInScope(IList<int?> ls) { regINS<int?>(CK_NINS, cTL<int?>(ls), getCValueProductId(), "PRODUCT_ID"); }
        public void ExistsPurchaseList(MbSubQuery<MbPurchaseCB> subQuery) {
            assertObjectNotNull("subQuery<MbPurchaseCB>", subQuery);
            MbPurchaseCB cb = new MbPurchaseCB(); cb.xsetupForExistsReferrer(this); subQuery.Invoke(cb);
            String subQueryPropertyName = keepProductId_ExistsSubQuery_PurchaseList(cb.Query());
            registerExistsSubQuery(cb.Query(), "PRODUCT_ID", "PRODUCT_ID", subQueryPropertyName);
        }
        public abstract String keepProductId_ExistsSubQuery_PurchaseList(MbPurchaseCQ subQuery);
        public void NotExistsPurchaseList(MbSubQuery<MbPurchaseCB> subQuery) {
            assertObjectNotNull("subQuery<MbPurchaseCB>", subQuery);
            MbPurchaseCB cb = new MbPurchaseCB(); cb.xsetupForExistsReferrer(this); subQuery.Invoke(cb);
            String subQueryPropertyName = keepProductId_NotExistsSubQuery_PurchaseList(cb.Query());
            registerNotExistsSubQuery(cb.Query(), "PRODUCT_ID", "PRODUCT_ID", subQueryPropertyName);
        }
        public abstract String keepProductId_NotExistsSubQuery_PurchaseList(MbPurchaseCQ subQuery);
        public void InScopePurchaseList(MbSubQuery<MbPurchaseCB> subQuery) {
            assertObjectNotNull("subQuery<MbPurchaseCB>", subQuery);
            MbPurchaseCB cb = new MbPurchaseCB(); cb.xsetupForInScopeRelation(this); subQuery.Invoke(cb);
            String subQueryPropertyName = keepProductId_InScopeSubQuery_PurchaseList(cb.Query());
            registerInScopeSubQuery(cb.Query(), "PRODUCT_ID", "PRODUCT_ID", subQueryPropertyName);
        }
        public abstract String keepProductId_InScopeSubQuery_PurchaseList(MbPurchaseCQ subQuery);
        public void NotInScopePurchaseList(MbSubQuery<MbPurchaseCB> subQuery) {
            assertObjectNotNull("subQuery<MbPurchaseCB>", subQuery);
            MbPurchaseCB cb = new MbPurchaseCB(); cb.xsetupForInScopeRelation(this); subQuery.Invoke(cb);
            String subQueryPropertyName = keepProductId_NotInScopeSubQuery_PurchaseList(cb.Query());
            registerNotInScopeSubQuery(cb.Query(), "PRODUCT_ID", "PRODUCT_ID", subQueryPropertyName);
        }
        public abstract String keepProductId_NotInScopeSubQuery_PurchaseList(MbPurchaseCQ subQuery);
        public void xsderivePurchaseList(String function, MbSubQuery<MbPurchaseCB> subQuery, String aliasName) {
            assertObjectNotNull("subQuery<MbPurchaseCB>", subQuery);
            MbPurchaseCB cb = new MbPurchaseCB(); cb.xsetupForDerivedReferrer(this); subQuery.Invoke(cb);
            String subQueryPropertyName = keepProductId_SpecifyDerivedReferrer_PurchaseList(cb.Query());
            registerSpecifyDerivedReferrer(function, cb.Query(), "PRODUCT_ID", "PRODUCT_ID", subQueryPropertyName, aliasName);
        }
        abstract public String keepProductId_SpecifyDerivedReferrer_PurchaseList(MbPurchaseCQ subQuery);

        public QDRFunction<MbPurchaseCB> DerivedPurchaseList() {
            return xcreateQDRFunctionPurchaseList();
        }
        protected QDRFunction<MbPurchaseCB> xcreateQDRFunctionPurchaseList() {
            return new QDRFunction<MbPurchaseCB>(delegate(String function, MbSubQuery<MbPurchaseCB> subQuery, String operand, Object value) {
                xqderivePurchaseList(function, subQuery, operand, value);
            });
        }
        public void xqderivePurchaseList(String function, MbSubQuery<MbPurchaseCB> subQuery, String operand, Object value) {
            assertObjectNotNull("subQuery<MbPurchaseCB>", subQuery);
            MbPurchaseCB cb = new MbPurchaseCB(); cb.xsetupForDerivedReferrer(this); subQuery.Invoke(cb);
            String subQueryPropertyName = keepProductId_QueryDerivedReferrer_PurchaseList(cb.Query()); // for saving query-value.
            String parameterPropertyName = keepProductId_QueryDerivedReferrer_PurchaseListParameter(value);
            registerQueryDerivedReferrer(function, cb.Query(), "PRODUCT_ID", "PRODUCT_ID", subQueryPropertyName, operand, value, parameterPropertyName);
        }
        public abstract String keepProductId_QueryDerivedReferrer_PurchaseList(MbPurchaseCQ subQuery);
        public abstract String keepProductId_QueryDerivedReferrer_PurchaseListParameter(Object parameterValue);
        public void SetProductId_IsNull() { regProductId(CK_ISN, DUMMY_OBJECT); }
        public void SetProductId_IsNotNull() { regProductId(CK_ISNN, DUMMY_OBJECT); }
        protected void regProductId(MbConditionKey k, Object v) { regQ(k, v, getCValueProductId(), "PRODUCT_ID"); }
        protected abstract MbConditionValue getCValueProductId();

        public void SetProductName_Equal(String v) { DoSetProductName_Equal(fRES(v)); }
        protected void DoSetProductName_Equal(String v) { regProductName(CK_EQ, v); }
        public void SetProductName_NotEqual(String v) { DoSetProductName_NotEqual(fRES(v)); }
        protected void DoSetProductName_NotEqual(String v) { regProductName(CK_NES, v); }
        public void SetProductName_InScope(IList<String> ls) { regINS<String>(CK_INS, cTL<String>(ls), getCValueProductName(), "PRODUCT_NAME"); }
        public void SetProductName_NotInScope(IList<String> ls) { regINS<String>(CK_NINS, cTL<String>(ls), getCValueProductName(), "PRODUCT_NAME"); }
        public void SetProductName_PrefixSearch(String v) { SetProductName_LikeSearch(v, cLSOP()); }
        public void SetProductName_LikeSearch(String v, MbLikeSearchOption option)
        { regLSQ(CK_LS, fRES(v), getCValueProductName(), "PRODUCT_NAME", option); }
        public void SetProductName_NotLikeSearch(String v, MbLikeSearchOption option)
        { regLSQ(CK_NLS, fRES(v), getCValueProductName(), "PRODUCT_NAME", option); }
        protected void regProductName(MbConditionKey k, Object v) { regQ(k, v, getCValueProductName(), "PRODUCT_NAME"); }
        protected abstract MbConditionValue getCValueProductName();

        public void SetProductHandleCode_Equal(String v) { DoSetProductHandleCode_Equal(fRES(v)); }
        protected void DoSetProductHandleCode_Equal(String v) { regProductHandleCode(CK_EQ, v); }
        public void SetProductHandleCode_NotEqual(String v) { DoSetProductHandleCode_NotEqual(fRES(v)); }
        protected void DoSetProductHandleCode_NotEqual(String v) { regProductHandleCode(CK_NES, v); }
        public void SetProductHandleCode_InScope(IList<String> ls) { regINS<String>(CK_INS, cTL<String>(ls), getCValueProductHandleCode(), "PRODUCT_HANDLE_CODE"); }
        public void SetProductHandleCode_NotInScope(IList<String> ls) { regINS<String>(CK_NINS, cTL<String>(ls), getCValueProductHandleCode(), "PRODUCT_HANDLE_CODE"); }
        public void SetProductHandleCode_PrefixSearch(String v) { SetProductHandleCode_LikeSearch(v, cLSOP()); }
        public void SetProductHandleCode_LikeSearch(String v, MbLikeSearchOption option)
        { regLSQ(CK_LS, fRES(v), getCValueProductHandleCode(), "PRODUCT_HANDLE_CODE", option); }
        public void SetProductHandleCode_NotLikeSearch(String v, MbLikeSearchOption option)
        { regLSQ(CK_NLS, fRES(v), getCValueProductHandleCode(), "PRODUCT_HANDLE_CODE", option); }
        protected void regProductHandleCode(MbConditionKey k, Object v) { regQ(k, v, getCValueProductHandleCode(), "PRODUCT_HANDLE_CODE"); }
        protected abstract MbConditionValue getCValueProductHandleCode();

        public void SetProductStatusCode_Equal(String v) { DoSetProductStatusCode_Equal(fRES(v)); }
        protected void DoSetProductStatusCode_Equal(String v) { regProductStatusCode(CK_EQ, v); }
        public void SetProductStatusCode_NotEqual(String v) { DoSetProductStatusCode_NotEqual(fRES(v)); }
        protected void DoSetProductStatusCode_NotEqual(String v) { regProductStatusCode(CK_NES, v); }
        public void SetProductStatusCode_InScope(IList<String> ls) { regINS<String>(CK_INS, cTL<String>(ls), getCValueProductStatusCode(), "PRODUCT_STATUS_CODE"); }
        public void SetProductStatusCode_NotInScope(IList<String> ls) { regINS<String>(CK_NINS, cTL<String>(ls), getCValueProductStatusCode(), "PRODUCT_STATUS_CODE"); }
        public void SetProductStatusCode_PrefixSearch(String v) { SetProductStatusCode_LikeSearch(v, cLSOP()); }
        public void SetProductStatusCode_LikeSearch(String v, MbLikeSearchOption option)
        { regLSQ(CK_LS, fRES(v), getCValueProductStatusCode(), "PRODUCT_STATUS_CODE", option); }
        public void SetProductStatusCode_NotLikeSearch(String v, MbLikeSearchOption option)
        { regLSQ(CK_NLS, fRES(v), getCValueProductStatusCode(), "PRODUCT_STATUS_CODE", option); }
        public void InScopeProductStatus(MbSubQuery<MbProductStatusCB> subQuery) {
            assertObjectNotNull("subQuery<MbProductStatusCB>", subQuery);
            MbProductStatusCB cb = new MbProductStatusCB(); cb.xsetupForInScopeRelation(this); subQuery.Invoke(cb);
            String subQueryPropertyName = keepProductStatusCode_InScopeSubQuery_ProductStatus(cb.Query());
            registerInScopeSubQuery(cb.Query(), "PRODUCT_STATUS_CODE", "PRODUCT_STATUS_CODE", subQueryPropertyName);
        }
        public abstract String keepProductStatusCode_InScopeSubQuery_ProductStatus(MbProductStatusCQ subQuery);
        public void NotInScopeProductStatus(MbSubQuery<MbProductStatusCB> subQuery) {
            assertObjectNotNull("subQuery<MbProductStatusCB>", subQuery);
            MbProductStatusCB cb = new MbProductStatusCB(); cb.xsetupForInScopeRelation(this); subQuery.Invoke(cb);
            String subQueryPropertyName = keepProductStatusCode_NotInScopeSubQuery_ProductStatus(cb.Query());
            registerNotInScopeSubQuery(cb.Query(), "PRODUCT_STATUS_CODE", "PRODUCT_STATUS_CODE", subQueryPropertyName);
        }
        public abstract String keepProductStatusCode_NotInScopeSubQuery_ProductStatus(MbProductStatusCQ subQuery);
        protected void regProductStatusCode(MbConditionKey k, Object v) { regQ(k, v, getCValueProductStatusCode(), "PRODUCT_STATUS_CODE"); }
        protected abstract MbConditionValue getCValueProductStatusCode();

        public void SetRegisterDatetime_Equal(DateTime? v) { regRegisterDatetime(CK_EQ, v); }
        public void SetRegisterDatetime_GreaterThan(DateTime? v) { regRegisterDatetime(CK_GT, v); }
        public void SetRegisterDatetime_LessThan(DateTime? v) { regRegisterDatetime(CK_LT, v); }
        public void SetRegisterDatetime_GreaterEqual(DateTime? v) { regRegisterDatetime(CK_GE, v); }
        public void SetRegisterDatetime_LessEqual(DateTime? v) { regRegisterDatetime(CK_LE, v); }
        public void SetRegisterDatetime_FromTo(DateTime? from, DateTime? to, MbFromToOption option)
        { regFTQ(from, to, getCValueRegisterDatetime(), "REGISTER_DATETIME", option); }
        public void SetRegisterDatetime_DateFromTo(DateTime? from, DateTime? to) { SetRegisterDatetime_FromTo(from, to, new MbDateFromToOption()); }
        public void SetRegisterDatetime_InScope(IList<DateTime?> ls) { regINS<DateTime?>(CK_INS, cTL<DateTime?>(ls), getCValueRegisterDatetime(), "REGISTER_DATETIME"); }
        public void SetRegisterDatetime_NotInScope(IList<DateTime?> ls) { regINS<DateTime?>(CK_NINS, cTL<DateTime?>(ls), getCValueRegisterDatetime(), "REGISTER_DATETIME"); }
        protected void regRegisterDatetime(MbConditionKey k, Object v) { regQ(k, v, getCValueRegisterDatetime(), "REGISTER_DATETIME"); }
        protected abstract MbConditionValue getCValueRegisterDatetime();

        public void SetRegisterUser_Equal(String v) { DoSetRegisterUser_Equal(fRES(v)); }
        protected void DoSetRegisterUser_Equal(String v) { regRegisterUser(CK_EQ, v); }
        public void SetRegisterUser_NotEqual(String v) { DoSetRegisterUser_NotEqual(fRES(v)); }
        protected void DoSetRegisterUser_NotEqual(String v) { regRegisterUser(CK_NES, v); }
        public void SetRegisterUser_InScope(IList<String> ls) { regINS<String>(CK_INS, cTL<String>(ls), getCValueRegisterUser(), "REGISTER_USER"); }
        public void SetRegisterUser_NotInScope(IList<String> ls) { regINS<String>(CK_NINS, cTL<String>(ls), getCValueRegisterUser(), "REGISTER_USER"); }
        public void SetRegisterUser_PrefixSearch(String v) { SetRegisterUser_LikeSearch(v, cLSOP()); }
        public void SetRegisterUser_LikeSearch(String v, MbLikeSearchOption option)
        { regLSQ(CK_LS, fRES(v), getCValueRegisterUser(), "REGISTER_USER", option); }
        public void SetRegisterUser_NotLikeSearch(String v, MbLikeSearchOption option)
        { regLSQ(CK_NLS, fRES(v), getCValueRegisterUser(), "REGISTER_USER", option); }
        protected void regRegisterUser(MbConditionKey k, Object v) { regQ(k, v, getCValueRegisterUser(), "REGISTER_USER"); }
        protected abstract MbConditionValue getCValueRegisterUser();

        public void SetRegisterProcess_Equal(String v) { DoSetRegisterProcess_Equal(fRES(v)); }
        protected void DoSetRegisterProcess_Equal(String v) { regRegisterProcess(CK_EQ, v); }
        public void SetRegisterProcess_NotEqual(String v) { DoSetRegisterProcess_NotEqual(fRES(v)); }
        protected void DoSetRegisterProcess_NotEqual(String v) { regRegisterProcess(CK_NES, v); }
        public void SetRegisterProcess_InScope(IList<String> ls) { regINS<String>(CK_INS, cTL<String>(ls), getCValueRegisterProcess(), "REGISTER_PROCESS"); }
        public void SetRegisterProcess_NotInScope(IList<String> ls) { regINS<String>(CK_NINS, cTL<String>(ls), getCValueRegisterProcess(), "REGISTER_PROCESS"); }
        public void SetRegisterProcess_PrefixSearch(String v) { SetRegisterProcess_LikeSearch(v, cLSOP()); }
        public void SetRegisterProcess_LikeSearch(String v, MbLikeSearchOption option)
        { regLSQ(CK_LS, fRES(v), getCValueRegisterProcess(), "REGISTER_PROCESS", option); }
        public void SetRegisterProcess_NotLikeSearch(String v, MbLikeSearchOption option)
        { regLSQ(CK_NLS, fRES(v), getCValueRegisterProcess(), "REGISTER_PROCESS", option); }
        protected void regRegisterProcess(MbConditionKey k, Object v) { regQ(k, v, getCValueRegisterProcess(), "REGISTER_PROCESS"); }
        protected abstract MbConditionValue getCValueRegisterProcess();

        public void SetUpdateDatetime_Equal(DateTime? v) { regUpdateDatetime(CK_EQ, v); }
        public void SetUpdateDatetime_GreaterThan(DateTime? v) { regUpdateDatetime(CK_GT, v); }
        public void SetUpdateDatetime_LessThan(DateTime? v) { regUpdateDatetime(CK_LT, v); }
        public void SetUpdateDatetime_GreaterEqual(DateTime? v) { regUpdateDatetime(CK_GE, v); }
        public void SetUpdateDatetime_LessEqual(DateTime? v) { regUpdateDatetime(CK_LE, v); }
        public void SetUpdateDatetime_FromTo(DateTime? from, DateTime? to, MbFromToOption option)
        { regFTQ(from, to, getCValueUpdateDatetime(), "UPDATE_DATETIME", option); }
        public void SetUpdateDatetime_DateFromTo(DateTime? from, DateTime? to) { SetUpdateDatetime_FromTo(from, to, new MbDateFromToOption()); }
        public void SetUpdateDatetime_InScope(IList<DateTime?> ls) { regINS<DateTime?>(CK_INS, cTL<DateTime?>(ls), getCValueUpdateDatetime(), "UPDATE_DATETIME"); }
        public void SetUpdateDatetime_NotInScope(IList<DateTime?> ls) { regINS<DateTime?>(CK_NINS, cTL<DateTime?>(ls), getCValueUpdateDatetime(), "UPDATE_DATETIME"); }
        protected void regUpdateDatetime(MbConditionKey k, Object v) { regQ(k, v, getCValueUpdateDatetime(), "UPDATE_DATETIME"); }
        protected abstract MbConditionValue getCValueUpdateDatetime();

        public void SetUpdateUser_Equal(String v) { DoSetUpdateUser_Equal(fRES(v)); }
        protected void DoSetUpdateUser_Equal(String v) { regUpdateUser(CK_EQ, v); }
        public void SetUpdateUser_NotEqual(String v) { DoSetUpdateUser_NotEqual(fRES(v)); }
        protected void DoSetUpdateUser_NotEqual(String v) { regUpdateUser(CK_NES, v); }
        public void SetUpdateUser_InScope(IList<String> ls) { regINS<String>(CK_INS, cTL<String>(ls), getCValueUpdateUser(), "UPDATE_USER"); }
        public void SetUpdateUser_NotInScope(IList<String> ls) { regINS<String>(CK_NINS, cTL<String>(ls), getCValueUpdateUser(), "UPDATE_USER"); }
        public void SetUpdateUser_PrefixSearch(String v) { SetUpdateUser_LikeSearch(v, cLSOP()); }
        public void SetUpdateUser_LikeSearch(String v, MbLikeSearchOption option)
        { regLSQ(CK_LS, fRES(v), getCValueUpdateUser(), "UPDATE_USER", option); }
        public void SetUpdateUser_NotLikeSearch(String v, MbLikeSearchOption option)
        { regLSQ(CK_NLS, fRES(v), getCValueUpdateUser(), "UPDATE_USER", option); }
        protected void regUpdateUser(MbConditionKey k, Object v) { regQ(k, v, getCValueUpdateUser(), "UPDATE_USER"); }
        protected abstract MbConditionValue getCValueUpdateUser();

        public void SetUpdateProcess_Equal(String v) { DoSetUpdateProcess_Equal(fRES(v)); }
        protected void DoSetUpdateProcess_Equal(String v) { regUpdateProcess(CK_EQ, v); }
        public void SetUpdateProcess_NotEqual(String v) { DoSetUpdateProcess_NotEqual(fRES(v)); }
        protected void DoSetUpdateProcess_NotEqual(String v) { regUpdateProcess(CK_NES, v); }
        public void SetUpdateProcess_InScope(IList<String> ls) { regINS<String>(CK_INS, cTL<String>(ls), getCValueUpdateProcess(), "UPDATE_PROCESS"); }
        public void SetUpdateProcess_NotInScope(IList<String> ls) { regINS<String>(CK_NINS, cTL<String>(ls), getCValueUpdateProcess(), "UPDATE_PROCESS"); }
        public void SetUpdateProcess_PrefixSearch(String v) { SetUpdateProcess_LikeSearch(v, cLSOP()); }
        public void SetUpdateProcess_LikeSearch(String v, MbLikeSearchOption option)
        { regLSQ(CK_LS, fRES(v), getCValueUpdateProcess(), "UPDATE_PROCESS", option); }
        public void SetUpdateProcess_NotLikeSearch(String v, MbLikeSearchOption option)
        { regLSQ(CK_NLS, fRES(v), getCValueUpdateProcess(), "UPDATE_PROCESS", option); }
        protected void regUpdateProcess(MbConditionKey k, Object v) { regQ(k, v, getCValueUpdateProcess(), "UPDATE_PROCESS"); }
        protected abstract MbConditionValue getCValueUpdateProcess();

        public void SetVersionNo_Equal(long? v) { regVersionNo(CK_EQ, v); }
        public void SetVersionNo_GreaterThan(long? v) { regVersionNo(CK_GT, v); }
        public void SetVersionNo_LessThan(long? v) { regVersionNo(CK_LT, v); }
        public void SetVersionNo_GreaterEqual(long? v) { regVersionNo(CK_GE, v); }
        public void SetVersionNo_LessEqual(long? v) { regVersionNo(CK_LE, v); }
        public void SetVersionNo_InScope(IList<long?> ls) { regINS<long?>(CK_INS, cTL<long?>(ls), getCValueVersionNo(), "VERSION_NO"); }
        public void SetVersionNo_NotInScope(IList<long?> ls) { regINS<long?>(CK_NINS, cTL<long?>(ls), getCValueVersionNo(), "VERSION_NO"); }
        protected void regVersionNo(MbConditionKey k, Object v) { regQ(k, v, getCValueVersionNo(), "VERSION_NO"); }
        protected abstract MbConditionValue getCValueVersionNo();

        // ===================================================================================
        //                                                                    Scalar Condition
        //                                                                    ================
        public SSQFunction<MbProductCB> Scalar_Equal() {
            return xcreateSSQFunction("=");
        }

        public SSQFunction<MbProductCB> Scalar_NotEqual() {
            return xcreateSSQFunction("<>");
        }

        public SSQFunction<MbProductCB> Scalar_GreaterEqual() {
            return xcreateSSQFunction(">=");
        }

        public SSQFunction<MbProductCB> Scalar_GreaterThan() {
            return xcreateSSQFunction(">");
        }

        public SSQFunction<MbProductCB> Scalar_LessEqual() {
            return xcreateSSQFunction("<=");
        }

        public SSQFunction<MbProductCB> Scalar_LessThan() {
            return xcreateSSQFunction("<");
        }

        protected SSQFunction<MbProductCB> xcreateSSQFunction(String operand) {
            return new SSQFunction<MbProductCB>(delegate(String function, MbSubQuery<MbProductCB> subQuery) {
                xscalarSubQuery(function, subQuery, operand);
            });
        }

        protected void xscalarSubQuery(String function, MbSubQuery<MbProductCB> subQuery, String operand) {
            assertObjectNotNull("subQuery<MbProductCB>", subQuery);
            MbProductCB cb = new MbProductCB(); cb.xsetupForScalarCondition(this); subQuery.Invoke(cb);
            String subQueryPropertyName = keepScalarSubQuery(cb.Query()); // for saving query-value.
            registerScalarSubQuery(function, cb.Query(), subQueryPropertyName, operand);
        }
        public abstract String keepScalarSubQuery(MbProductCQ subQuery);

        // ===============================================================================
        //                                                                  MySelf InScope
        //                                                                  ==============
        public void MyselfInScope(MbSubQuery<MbProductCB> subQuery) {
            assertObjectNotNull("subQuery<MbProductCB>", subQuery);
            MbProductCB cb = new MbProductCB(); cb.xsetupForInScopeRelation(this); subQuery.Invoke(cb);
            String subQueryPropertyName = keepMyselfInScopeSubQuery(cb.Query()); // for saving query-value.
            registerInScopeSubQuery(cb.Query(), "PRODUCT_ID", "PRODUCT_ID", subQueryPropertyName);
        }
        public abstract String keepMyselfInScopeSubQuery(MbProductCQ subQuery);

        public override String ToString() { return xgetSqlClause().getClause(); }
    }
}
