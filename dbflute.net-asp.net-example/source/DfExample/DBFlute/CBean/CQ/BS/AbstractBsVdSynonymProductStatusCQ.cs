
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
    public abstract class AbstractBsVdSynonymProductStatusCQ : AbstractConditionQuery {

        public AbstractBsVdSynonymProductStatusCQ(ConditionQuery childQuery, SqlClause sqlClause, String aliasName, int nestLevel)
            : base(childQuery, sqlClause, aliasName, nestLevel) {}

        public override String getTableDbName() { return "VD_SYNONYM_PRODUCT_STATUS"; }
        public override String getTableSqlName() { return "VD_SYNONYM_PRODUCT_STATUS"; }

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
        public void ExistsVdSynonymProductList(SubQuery<VdSynonymProductCB> subQuery) {
            assertObjectNotNull("subQuery<VdSynonymProductCB>", subQuery);
            VdSynonymProductCB cb = new VdSynonymProductCB(); cb.xsetupForExistsReferrer(this); subQuery.Invoke(cb);
            String subQueryPropertyName = keepProductStatusCode_ExistsSubQuery_VdSynonymProductList(cb.Query());
            registerExistsSubQuery(cb.Query(), "PRODUCT_STATUS_CODE", "PRODUCT_STATUS_CODE", subQueryPropertyName);
        }
        public abstract String keepProductStatusCode_ExistsSubQuery_VdSynonymProductList(VdSynonymProductCQ subQuery);
        public void NotExistsVdSynonymProductList(SubQuery<VdSynonymProductCB> subQuery) {
            assertObjectNotNull("subQuery<VdSynonymProductCB>", subQuery);
            VdSynonymProductCB cb = new VdSynonymProductCB(); cb.xsetupForExistsReferrer(this); subQuery.Invoke(cb);
            String subQueryPropertyName = keepProductStatusCode_NotExistsSubQuery_VdSynonymProductList(cb.Query());
            registerNotExistsSubQuery(cb.Query(), "PRODUCT_STATUS_CODE", "PRODUCT_STATUS_CODE", subQueryPropertyName);
        }
        public abstract String keepProductStatusCode_NotExistsSubQuery_VdSynonymProductList(VdSynonymProductCQ subQuery);
        public void InScopeVdSynonymProductList(SubQuery<VdSynonymProductCB> subQuery) {
            assertObjectNotNull("subQuery<VdSynonymProductCB>", subQuery);
            VdSynonymProductCB cb = new VdSynonymProductCB(); cb.xsetupForInScopeRelation(this); subQuery.Invoke(cb);
            String subQueryPropertyName = keepProductStatusCode_InScopeSubQuery_VdSynonymProductList(cb.Query());
            registerInScopeSubQuery(cb.Query(), "PRODUCT_STATUS_CODE", "PRODUCT_STATUS_CODE", subQueryPropertyName);
        }
        public abstract String keepProductStatusCode_InScopeSubQuery_VdSynonymProductList(VdSynonymProductCQ subQuery);
        public void NotInScopeVdSynonymProductList(SubQuery<VdSynonymProductCB> subQuery) {
            assertObjectNotNull("subQuery<VdSynonymProductCB>", subQuery);
            VdSynonymProductCB cb = new VdSynonymProductCB(); cb.xsetupForInScopeRelation(this); subQuery.Invoke(cb);
            String subQueryPropertyName = keepProductStatusCode_NotInScopeSubQuery_VdSynonymProductList(cb.Query());
            registerNotInScopeSubQuery(cb.Query(), "PRODUCT_STATUS_CODE", "PRODUCT_STATUS_CODE", subQueryPropertyName);
        }
        public abstract String keepProductStatusCode_NotInScopeSubQuery_VdSynonymProductList(VdSynonymProductCQ subQuery);
        public void xsderiveVdSynonymProductList(String function, SubQuery<VdSynonymProductCB> subQuery, String aliasName) {
            assertObjectNotNull("subQuery<VdSynonymProductCB>", subQuery);
            VdSynonymProductCB cb = new VdSynonymProductCB(); cb.xsetupForDerivedReferrer(this); subQuery.Invoke(cb);
            String subQueryPropertyName = keepProductStatusCode_SpecifyDerivedReferrer_VdSynonymProductList(cb.Query());
            registerSpecifyDerivedReferrer(function, cb.Query(), "PRODUCT_STATUS_CODE", "PRODUCT_STATUS_CODE", subQueryPropertyName, aliasName);
        }
        abstract public String keepProductStatusCode_SpecifyDerivedReferrer_VdSynonymProductList(VdSynonymProductCQ subQuery);

        public QDRFunction<VdSynonymProductCB> DerivedVdSynonymProductList() {
            return xcreateQDRFunctionVdSynonymProductList();
        }
        protected QDRFunction<VdSynonymProductCB> xcreateQDRFunctionVdSynonymProductList() {
            return new QDRFunction<VdSynonymProductCB>(delegate(String function, SubQuery<VdSynonymProductCB> subQuery, String operand, Object value) {
                xqderiveVdSynonymProductList(function, subQuery, operand, value);
            });
        }
        public void xqderiveVdSynonymProductList(String function, SubQuery<VdSynonymProductCB> subQuery, String operand, Object value) {
            assertObjectNotNull("subQuery<VdSynonymProductCB>", subQuery);
            VdSynonymProductCB cb = new VdSynonymProductCB(); cb.xsetupForDerivedReferrer(this); subQuery.Invoke(cb);
            String subQueryPropertyName = keepProductStatusCode_QueryDerivedReferrer_VdSynonymProductList(cb.Query()); // for saving query-value.
            String parameterPropertyName = keepProductStatusCode_QueryDerivedReferrer_VdSynonymProductListParameter(value);
            registerQueryDerivedReferrer(function, cb.Query(), "PRODUCT_STATUS_CODE", "PRODUCT_STATUS_CODE", subQueryPropertyName, operand, value, parameterPropertyName);
        }
        public abstract String keepProductStatusCode_QueryDerivedReferrer_VdSynonymProductList(VdSynonymProductCQ subQuery);
        public abstract String keepProductStatusCode_QueryDerivedReferrer_VdSynonymProductListParameter(Object parameterValue);
        public void SetProductStatusCode_IsNull() { regProductStatusCode(CK_ISN, DUMMY_OBJECT); }
        public void SetProductStatusCode_IsNotNull() { regProductStatusCode(CK_ISNN, DUMMY_OBJECT); }
        protected void regProductStatusCode(ConditionKey k, Object v) { regQ(k, v, getCValueProductStatusCode(), "PRODUCT_STATUS_CODE"); }
        protected abstract ConditionValue getCValueProductStatusCode();

        public void SetProductStatusName_Equal(String v) { DoSetProductStatusName_Equal(fRES(v)); }
        protected void DoSetProductStatusName_Equal(String v) { regProductStatusName(CK_EQ, v); }
        public void SetProductStatusName_NotEqual(String v) { DoSetProductStatusName_NotEqual(fRES(v)); }
        protected void DoSetProductStatusName_NotEqual(String v) { regProductStatusName(CK_NES, v); }
        public void SetProductStatusName_InScope(IList<String> ls) { regINS<String>(CK_INS, cTL<String>(ls), getCValueProductStatusName(), "PRODUCT_STATUS_NAME"); }
        public void SetProductStatusName_NotInScope(IList<String> ls) { regINS<String>(CK_NINS, cTL<String>(ls), getCValueProductStatusName(), "PRODUCT_STATUS_NAME"); }
        public void SetProductStatusName_PrefixSearch(String v) { SetProductStatusName_LikeSearch(v, cLSOP()); }
        public void SetProductStatusName_LikeSearch(String v, LikeSearchOption option)
        { regLSQ(CK_LS, fRES(v), getCValueProductStatusName(), "PRODUCT_STATUS_NAME", option); }
        public void SetProductStatusName_NotLikeSearch(String v, LikeSearchOption option)
        { regLSQ(CK_NLS, fRES(v), getCValueProductStatusName(), "PRODUCT_STATUS_NAME", option); }
        protected void regProductStatusName(ConditionKey k, Object v) { regQ(k, v, getCValueProductStatusName(), "PRODUCT_STATUS_NAME"); }
        protected abstract ConditionValue getCValueProductStatusName();

        // ===================================================================================
        //                                                                    Scalar Condition
        //                                                                    ================
        public SSQFunction<VdSynonymProductStatusCB> Scalar_Equal() {
            return xcreateSSQFunction("=");
        }

        public SSQFunction<VdSynonymProductStatusCB> Scalar_NotEqual() {
            return xcreateSSQFunction("<>");
        }

        public SSQFunction<VdSynonymProductStatusCB> Scalar_GreaterEqual() {
            return xcreateSSQFunction(">=");
        }

        public SSQFunction<VdSynonymProductStatusCB> Scalar_GreaterThan() {
            return xcreateSSQFunction(">");
        }

        public SSQFunction<VdSynonymProductStatusCB> Scalar_LessEqual() {
            return xcreateSSQFunction("<=");
        }

        public SSQFunction<VdSynonymProductStatusCB> Scalar_LessThan() {
            return xcreateSSQFunction("<");
        }

        protected SSQFunction<VdSynonymProductStatusCB> xcreateSSQFunction(String operand) {
            return new SSQFunction<VdSynonymProductStatusCB>(delegate(String function, SubQuery<VdSynonymProductStatusCB> subQuery) {
                xscalarSubQuery(function, subQuery, operand);
            });
        }

        protected void xscalarSubQuery(String function, SubQuery<VdSynonymProductStatusCB> subQuery, String operand) {
            assertObjectNotNull("subQuery<VdSynonymProductStatusCB>", subQuery);
            VdSynonymProductStatusCB cb = new VdSynonymProductStatusCB(); cb.xsetupForScalarCondition(this); subQuery.Invoke(cb);
            String subQueryPropertyName = keepScalarSubQuery(cb.Query()); // for saving query-value.
            registerScalarSubQuery(function, cb.Query(), subQueryPropertyName, operand);
        }
        public abstract String keepScalarSubQuery(VdSynonymProductStatusCQ subQuery);

        // ===============================================================================
        //                                                                  MySelf InScope
        //                                                                  ==============
        public void MyselfInScope(SubQuery<VdSynonymProductStatusCB> subQuery) {
            assertObjectNotNull("subQuery<VdSynonymProductStatusCB>", subQuery);
            VdSynonymProductStatusCB cb = new VdSynonymProductStatusCB(); cb.xsetupForInScopeRelation(this); subQuery.Invoke(cb);
            String subQueryPropertyName = keepMyselfInScopeSubQuery(cb.Query()); // for saving query-value.
            registerInScopeSubQuery(cb.Query(), "PRODUCT_STATUS_CODE", "PRODUCT_STATUS_CODE", subQueryPropertyName);
        }
        public abstract String keepMyselfInScopeSubQuery(VdSynonymProductStatusCQ subQuery);

        public override String ToString() { return xgetSqlClause().getClause(); }
    }
}
