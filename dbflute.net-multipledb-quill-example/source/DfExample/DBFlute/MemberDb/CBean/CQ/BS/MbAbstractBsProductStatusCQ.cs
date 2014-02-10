
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
    public abstract class MbAbstractBsProductStatusCQ : MbAbstractConditionQuery {

        public MbAbstractBsProductStatusCQ(MbConditionQuery childQuery, MbSqlClause sqlClause, String aliasName, int nestLevel)
            : base(childQuery, sqlClause, aliasName, nestLevel) {}

        public override String getTableDbName() { return "product_status"; }
        public override String getTableSqlName() { return "product_status"; }

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
        public void ExistsProductList(MbSubQuery<MbProductCB> subQuery) {
            assertObjectNotNull("subQuery<MbProductCB>", subQuery);
            MbProductCB cb = new MbProductCB(); cb.xsetupForExistsReferrer(this); subQuery.Invoke(cb);
            String subQueryPropertyName = keepProductStatusCode_ExistsSubQuery_ProductList(cb.Query());
            registerExistsSubQuery(cb.Query(), "PRODUCT_STATUS_CODE", "PRODUCT_STATUS_CODE", subQueryPropertyName);
        }
        public abstract String keepProductStatusCode_ExistsSubQuery_ProductList(MbProductCQ subQuery);
        public void NotExistsProductList(MbSubQuery<MbProductCB> subQuery) {
            assertObjectNotNull("subQuery<MbProductCB>", subQuery);
            MbProductCB cb = new MbProductCB(); cb.xsetupForExistsReferrer(this); subQuery.Invoke(cb);
            String subQueryPropertyName = keepProductStatusCode_NotExistsSubQuery_ProductList(cb.Query());
            registerNotExistsSubQuery(cb.Query(), "PRODUCT_STATUS_CODE", "PRODUCT_STATUS_CODE", subQueryPropertyName);
        }
        public abstract String keepProductStatusCode_NotExistsSubQuery_ProductList(MbProductCQ subQuery);
        public void InScopeProductList(MbSubQuery<MbProductCB> subQuery) {
            assertObjectNotNull("subQuery<MbProductCB>", subQuery);
            MbProductCB cb = new MbProductCB(); cb.xsetupForInScopeRelation(this); subQuery.Invoke(cb);
            String subQueryPropertyName = keepProductStatusCode_InScopeSubQuery_ProductList(cb.Query());
            registerInScopeSubQuery(cb.Query(), "PRODUCT_STATUS_CODE", "PRODUCT_STATUS_CODE", subQueryPropertyName);
        }
        public abstract String keepProductStatusCode_InScopeSubQuery_ProductList(MbProductCQ subQuery);
        public void NotInScopeProductList(MbSubQuery<MbProductCB> subQuery) {
            assertObjectNotNull("subQuery<MbProductCB>", subQuery);
            MbProductCB cb = new MbProductCB(); cb.xsetupForInScopeRelation(this); subQuery.Invoke(cb);
            String subQueryPropertyName = keepProductStatusCode_NotInScopeSubQuery_ProductList(cb.Query());
            registerNotInScopeSubQuery(cb.Query(), "PRODUCT_STATUS_CODE", "PRODUCT_STATUS_CODE", subQueryPropertyName);
        }
        public abstract String keepProductStatusCode_NotInScopeSubQuery_ProductList(MbProductCQ subQuery);
        public void xsderiveProductList(String function, MbSubQuery<MbProductCB> subQuery, String aliasName) {
            assertObjectNotNull("subQuery<MbProductCB>", subQuery);
            MbProductCB cb = new MbProductCB(); cb.xsetupForDerivedReferrer(this); subQuery.Invoke(cb);
            String subQueryPropertyName = keepProductStatusCode_SpecifyDerivedReferrer_ProductList(cb.Query());
            registerSpecifyDerivedReferrer(function, cb.Query(), "PRODUCT_STATUS_CODE", "PRODUCT_STATUS_CODE", subQueryPropertyName, aliasName);
        }
        abstract public String keepProductStatusCode_SpecifyDerivedReferrer_ProductList(MbProductCQ subQuery);

        public QDRFunction<MbProductCB> DerivedProductList() {
            return xcreateQDRFunctionProductList();
        }
        protected QDRFunction<MbProductCB> xcreateQDRFunctionProductList() {
            return new QDRFunction<MbProductCB>(delegate(String function, MbSubQuery<MbProductCB> subQuery, String operand, Object value) {
                xqderiveProductList(function, subQuery, operand, value);
            });
        }
        public void xqderiveProductList(String function, MbSubQuery<MbProductCB> subQuery, String operand, Object value) {
            assertObjectNotNull("subQuery<MbProductCB>", subQuery);
            MbProductCB cb = new MbProductCB(); cb.xsetupForDerivedReferrer(this); subQuery.Invoke(cb);
            String subQueryPropertyName = keepProductStatusCode_QueryDerivedReferrer_ProductList(cb.Query()); // for saving query-value.
            String parameterPropertyName = keepProductStatusCode_QueryDerivedReferrer_ProductListParameter(value);
            registerQueryDerivedReferrer(function, cb.Query(), "PRODUCT_STATUS_CODE", "PRODUCT_STATUS_CODE", subQueryPropertyName, operand, value, parameterPropertyName);
        }
        public abstract String keepProductStatusCode_QueryDerivedReferrer_ProductList(MbProductCQ subQuery);
        public abstract String keepProductStatusCode_QueryDerivedReferrer_ProductListParameter(Object parameterValue);
        public void SetProductStatusCode_IsNull() { regProductStatusCode(CK_ISN, DUMMY_OBJECT); }
        public void SetProductStatusCode_IsNotNull() { regProductStatusCode(CK_ISNN, DUMMY_OBJECT); }
        protected void regProductStatusCode(MbConditionKey k, Object v) { regQ(k, v, getCValueProductStatusCode(), "PRODUCT_STATUS_CODE"); }
        protected abstract MbConditionValue getCValueProductStatusCode();

        public void SetProductStatusName_Equal(String v) { DoSetProductStatusName_Equal(fRES(v)); }
        protected void DoSetProductStatusName_Equal(String v) { regProductStatusName(CK_EQ, v); }
        public void SetProductStatusName_NotEqual(String v) { DoSetProductStatusName_NotEqual(fRES(v)); }
        protected void DoSetProductStatusName_NotEqual(String v) { regProductStatusName(CK_NES, v); }
        public void SetProductStatusName_InScope(IList<String> ls) { regINS<String>(CK_INS, cTL<String>(ls), getCValueProductStatusName(), "PRODUCT_STATUS_NAME"); }
        public void SetProductStatusName_NotInScope(IList<String> ls) { regINS<String>(CK_NINS, cTL<String>(ls), getCValueProductStatusName(), "PRODUCT_STATUS_NAME"); }
        public void SetProductStatusName_PrefixSearch(String v) { SetProductStatusName_LikeSearch(v, cLSOP()); }
        public void SetProductStatusName_LikeSearch(String v, MbLikeSearchOption option)
        { regLSQ(CK_LS, fRES(v), getCValueProductStatusName(), "PRODUCT_STATUS_NAME", option); }
        public void SetProductStatusName_NotLikeSearch(String v, MbLikeSearchOption option)
        { regLSQ(CK_NLS, fRES(v), getCValueProductStatusName(), "PRODUCT_STATUS_NAME", option); }
        protected void regProductStatusName(MbConditionKey k, Object v) { regQ(k, v, getCValueProductStatusName(), "PRODUCT_STATUS_NAME"); }
        protected abstract MbConditionValue getCValueProductStatusName();

        // ===================================================================================
        //                                                                    Scalar Condition
        //                                                                    ================
        public SSQFunction<MbProductStatusCB> Scalar_Equal() {
            return xcreateSSQFunction("=");
        }

        public SSQFunction<MbProductStatusCB> Scalar_NotEqual() {
            return xcreateSSQFunction("<>");
        }

        public SSQFunction<MbProductStatusCB> Scalar_GreaterEqual() {
            return xcreateSSQFunction(">=");
        }

        public SSQFunction<MbProductStatusCB> Scalar_GreaterThan() {
            return xcreateSSQFunction(">");
        }

        public SSQFunction<MbProductStatusCB> Scalar_LessEqual() {
            return xcreateSSQFunction("<=");
        }

        public SSQFunction<MbProductStatusCB> Scalar_LessThan() {
            return xcreateSSQFunction("<");
        }

        protected SSQFunction<MbProductStatusCB> xcreateSSQFunction(String operand) {
            return new SSQFunction<MbProductStatusCB>(delegate(String function, MbSubQuery<MbProductStatusCB> subQuery) {
                xscalarSubQuery(function, subQuery, operand);
            });
        }

        protected void xscalarSubQuery(String function, MbSubQuery<MbProductStatusCB> subQuery, String operand) {
            assertObjectNotNull("subQuery<MbProductStatusCB>", subQuery);
            MbProductStatusCB cb = new MbProductStatusCB(); cb.xsetupForScalarCondition(this); subQuery.Invoke(cb);
            String subQueryPropertyName = keepScalarSubQuery(cb.Query()); // for saving query-value.
            registerScalarSubQuery(function, cb.Query(), subQueryPropertyName, operand);
        }
        public abstract String keepScalarSubQuery(MbProductStatusCQ subQuery);

        // ===============================================================================
        //                                                                  MySelf InScope
        //                                                                  ==============
        public void MyselfInScope(MbSubQuery<MbProductStatusCB> subQuery) {
            assertObjectNotNull("subQuery<MbProductStatusCB>", subQuery);
            MbProductStatusCB cb = new MbProductStatusCB(); cb.xsetupForInScopeRelation(this); subQuery.Invoke(cb);
            String subQueryPropertyName = keepMyselfInScopeSubQuery(cb.Query()); // for saving query-value.
            registerInScopeSubQuery(cb.Query(), "PRODUCT_STATUS_CODE", "PRODUCT_STATUS_CODE", subQueryPropertyName);
        }
        public abstract String keepMyselfInScopeSubQuery(MbProductStatusCQ subQuery);

        public override String ToString() { return xgetSqlClause().getClause(); }
    }
}
