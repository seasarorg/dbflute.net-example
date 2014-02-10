
using System;
using System.Collections.Generic;

using DfExample.DBFlute.AllCommon;
using DfExample.DBFlute.AllCommon.CBean;
using DfExample.DBFlute.AllCommon.CBean.CKey;
using DfExample.DBFlute.AllCommon.CBean.COption;
using DfExample.DBFlute.AllCommon.CBean.CValue;
using DfExample.DBFlute.AllCommon.CBean.SClause;

namespace DfExample.DBFlute.CBean.CQ.BS {

    [System.Serializable]
    public abstract class AbstractBsSummaryProductCQ : AbstractConditionQuery {

        public AbstractBsSummaryProductCQ(ConditionQuery childQuery, SqlClause sqlClause, String aliasName, int nestLevel)
            : base(childQuery, sqlClause, aliasName, nestLevel) {}

        public override String getTableDbName() { return "summary_product"; }
        public override String getTableSqlName() { return "summary_product"; }

        public void SetProductId_Equal(int? v) { regProductId(CK_EQ, v); }
        public void SetProductId_NotEqual(int? v) { regProductId(CK_NES, v); }
        public void SetProductId_GreaterThan(int? v) { regProductId(CK_GT, v); }
        public void SetProductId_LessThan(int? v) { regProductId(CK_LT, v); }
        public void SetProductId_GreaterEqual(int? v) { regProductId(CK_GE, v); }
        public void SetProductId_LessEqual(int? v) { regProductId(CK_LE, v); }
        public void SetProductId_InScope(IList<int?> ls) { regINS<int?>(CK_INS, cTL<int?>(ls), getCValueProductId(), "PRODUCT_ID"); }
        public void SetProductId_NotInScope(IList<int?> ls) { regINS<int?>(CK_NINS, cTL<int?>(ls), getCValueProductId(), "PRODUCT_ID"); }
        public void SetProductId_IsNull() { regProductId(CK_ISN, DUMMY_OBJECT); }
        public void SetProductId_IsNotNull() { regProductId(CK_ISNN, DUMMY_OBJECT); }
        protected void regProductId(ConditionKey k, Object v) { regQ(k, v, getCValueProductId(), "PRODUCT_ID"); }
        protected abstract ConditionValue getCValueProductId();

        public void SetProductName_Equal(String v) { DoSetProductName_Equal(fRES(v)); }
        protected void DoSetProductName_Equal(String v) { regProductName(CK_EQ, v); }
        public void SetProductName_NotEqual(String v) { DoSetProductName_NotEqual(fRES(v)); }
        protected void DoSetProductName_NotEqual(String v) { regProductName(CK_NES, v); }
        public void SetProductName_InScope(IList<String> ls) { regINS<String>(CK_INS, cTL<String>(ls), getCValueProductName(), "PRODUCT_NAME"); }
        public void SetProductName_NotInScope(IList<String> ls) { regINS<String>(CK_NINS, cTL<String>(ls), getCValueProductName(), "PRODUCT_NAME"); }
        public void SetProductName_PrefixSearch(String v) { SetProductName_LikeSearch(v, cLSOP()); }
        public void SetProductName_LikeSearch(String v, LikeSearchOption option)
        { regLSQ(CK_LS, fRES(v), getCValueProductName(), "PRODUCT_NAME", option); }
        public void SetProductName_NotLikeSearch(String v, LikeSearchOption option)
        { regLSQ(CK_NLS, fRES(v), getCValueProductName(), "PRODUCT_NAME", option); }
        protected void regProductName(ConditionKey k, Object v) { regQ(k, v, getCValueProductName(), "PRODUCT_NAME"); }
        protected abstract ConditionValue getCValueProductName();

        public void SetProductHandleCode_Equal(String v) { DoSetProductHandleCode_Equal(fRES(v)); }
        protected void DoSetProductHandleCode_Equal(String v) { regProductHandleCode(CK_EQ, v); }
        public void SetProductHandleCode_NotEqual(String v) { DoSetProductHandleCode_NotEqual(fRES(v)); }
        protected void DoSetProductHandleCode_NotEqual(String v) { regProductHandleCode(CK_NES, v); }
        public void SetProductHandleCode_InScope(IList<String> ls) { regINS<String>(CK_INS, cTL<String>(ls), getCValueProductHandleCode(), "PRODUCT_HANDLE_CODE"); }
        public void SetProductHandleCode_NotInScope(IList<String> ls) { regINS<String>(CK_NINS, cTL<String>(ls), getCValueProductHandleCode(), "PRODUCT_HANDLE_CODE"); }
        public void SetProductHandleCode_PrefixSearch(String v) { SetProductHandleCode_LikeSearch(v, cLSOP()); }
        public void SetProductHandleCode_LikeSearch(String v, LikeSearchOption option)
        { regLSQ(CK_LS, fRES(v), getCValueProductHandleCode(), "PRODUCT_HANDLE_CODE", option); }
        public void SetProductHandleCode_NotLikeSearch(String v, LikeSearchOption option)
        { regLSQ(CK_NLS, fRES(v), getCValueProductHandleCode(), "PRODUCT_HANDLE_CODE", option); }
        protected void regProductHandleCode(ConditionKey k, Object v) { regQ(k, v, getCValueProductHandleCode(), "PRODUCT_HANDLE_CODE"); }
        protected abstract ConditionValue getCValueProductHandleCode();

        public void SetProductStatusCode_Equal(String v) { DoSetProductStatusCode_Equal(fRES(v)); }
        protected void DoSetProductStatusCode_Equal(String v) { regProductStatusCode(CK_EQ, v); }
        public void SetProductStatusCode_NotEqual(String v) { DoSetProductStatusCode_NotEqual(fRES(v)); }
        protected void DoSetProductStatusCode_NotEqual(String v) { regProductStatusCode(CK_NES, v); }
        public void SetProductStatusCode_InScope(IList<String> ls) { regINS<String>(CK_INS, cTL<String>(ls), getCValueProductStatusCode(), "PRODUCT_STATUS_CODE"); }
        public void SetProductStatusCode_NotInScope(IList<String> ls) { regINS<String>(CK_NINS, cTL<String>(ls), getCValueProductStatusCode(), "PRODUCT_STATUS_CODE"); }
        public void SetProductStatusCode_PrefixSearch(String v) { SetProductStatusCode_LikeSearch(v, cLSOP()); }
        public void SetProductStatusCode_LikeSearch(String v, LikeSearchOption option)
        { regLSQ(CK_LS, fRES(v), getCValueProductStatusCode(), "PRODUCT_STATUS_CODE", option); }
        public void SetProductStatusCode_NotLikeSearch(String v, LikeSearchOption option)
        { regLSQ(CK_NLS, fRES(v), getCValueProductStatusCode(), "PRODUCT_STATUS_CODE", option); }
        protected void regProductStatusCode(ConditionKey k, Object v) { regQ(k, v, getCValueProductStatusCode(), "PRODUCT_STATUS_CODE"); }
        protected abstract ConditionValue getCValueProductStatusCode();

        public void SetLatestPurchaseDatetime_Equal(DateTime? v) { regLatestPurchaseDatetime(CK_EQ, v); }
        public void SetLatestPurchaseDatetime_GreaterThan(DateTime? v) { regLatestPurchaseDatetime(CK_GT, v); }
        public void SetLatestPurchaseDatetime_LessThan(DateTime? v) { regLatestPurchaseDatetime(CK_LT, v); }
        public void SetLatestPurchaseDatetime_GreaterEqual(DateTime? v) { regLatestPurchaseDatetime(CK_GE, v); }
        public void SetLatestPurchaseDatetime_LessEqual(DateTime? v) { regLatestPurchaseDatetime(CK_LE, v); }
        public void SetLatestPurchaseDatetime_FromTo(DateTime? from, DateTime? to, FromToOption option)
        { regFTQ(from, to, getCValueLatestPurchaseDatetime(), "LATEST_PURCHASE_DATETIME", option); }
        public void SetLatestPurchaseDatetime_DateFromTo(DateTime? from, DateTime? to) { SetLatestPurchaseDatetime_FromTo(from, to, new DateFromToOption()); }
        public void SetLatestPurchaseDatetime_InScope(IList<DateTime?> ls) { regINS<DateTime?>(CK_INS, cTL<DateTime?>(ls), getCValueLatestPurchaseDatetime(), "LATEST_PURCHASE_DATETIME"); }
        public void SetLatestPurchaseDatetime_NotInScope(IList<DateTime?> ls) { regINS<DateTime?>(CK_NINS, cTL<DateTime?>(ls), getCValueLatestPurchaseDatetime(), "LATEST_PURCHASE_DATETIME"); }
        public void SetLatestPurchaseDatetime_IsNull() { regLatestPurchaseDatetime(CK_ISN, DUMMY_OBJECT); }
        public void SetLatestPurchaseDatetime_IsNotNull() { regLatestPurchaseDatetime(CK_ISNN, DUMMY_OBJECT); }
        protected void regLatestPurchaseDatetime(ConditionKey k, Object v) { regQ(k, v, getCValueLatestPurchaseDatetime(), "LATEST_PURCHASE_DATETIME"); }
        protected abstract ConditionValue getCValueLatestPurchaseDatetime();

        // ===================================================================================
        //                                                                    Scalar Condition
        //                                                                    ================
        public SSQFunction<SummaryProductCB> Scalar_Equal() {
            return xcreateSSQFunction("=");
        }

        public SSQFunction<SummaryProductCB> Scalar_NotEqual() {
            return xcreateSSQFunction("<>");
        }

        public SSQFunction<SummaryProductCB> Scalar_GreaterEqual() {
            return xcreateSSQFunction(">=");
        }

        public SSQFunction<SummaryProductCB> Scalar_GreaterThan() {
            return xcreateSSQFunction(">");
        }

        public SSQFunction<SummaryProductCB> Scalar_LessEqual() {
            return xcreateSSQFunction("<=");
        }

        public SSQFunction<SummaryProductCB> Scalar_LessThan() {
            return xcreateSSQFunction("<");
        }

        protected SSQFunction<SummaryProductCB> xcreateSSQFunction(String operand) {
            return new SSQFunction<SummaryProductCB>(delegate(String function, SubQuery<SummaryProductCB> subQuery) {
                xscalarSubQuery(function, subQuery, operand);
            });
        }

        protected void xscalarSubQuery(String function, SubQuery<SummaryProductCB> subQuery, String operand) {
            assertObjectNotNull("subQuery<SummaryProductCB>", subQuery);
            SummaryProductCB cb = new SummaryProductCB(); cb.xsetupForScalarCondition(this); subQuery.Invoke(cb);
            String subQueryPropertyName = keepScalarSubQuery(cb.Query()); // for saving query-value.
            registerScalarSubQuery(function, cb.Query(), subQueryPropertyName, operand);
        }
        public abstract String keepScalarSubQuery(SummaryProductCQ subQuery);

        // ===============================================================================
        //                                                                  MySelf InScope
        //                                                                  ==============
        public void MyselfInScope(SubQuery<SummaryProductCB> subQuery) {
            assertObjectNotNull("subQuery<SummaryProductCB>", subQuery);
            SummaryProductCB cb = new SummaryProductCB(); cb.xsetupForInScopeRelation(this); subQuery.Invoke(cb);
            String subQueryPropertyName = keepMyselfInScopeSubQuery(cb.Query()); // for saving query-value.
            registerInScopeSubQuery(cb.Query(), "PRODUCT_ID", "PRODUCT_ID", subQueryPropertyName);
        }
        public abstract String keepMyselfInScopeSubQuery(SummaryProductCQ subQuery);

        public override String ToString() { return xgetSqlClause().getClause(); }
    }
}
