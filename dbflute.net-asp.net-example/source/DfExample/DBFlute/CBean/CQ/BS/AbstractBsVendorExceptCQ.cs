
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
    public abstract class AbstractBsVendorExceptCQ : AbstractConditionQuery {

        public AbstractBsVendorExceptCQ(ConditionQuery childQuery, SqlClause sqlClause, String aliasName, int nestLevel)
            : base(childQuery, sqlClause, aliasName, nestLevel) {}

        public override String getTableDbName() { return "VENDOR_EXCEPT"; }
        public override String getTableSqlName() { return "VENDOR_EXCEPT"; }

        public void SetVendorExceptId_Equal(long? v) { regVendorExceptId(CK_EQ, v); }
        public void SetVendorExceptId_GreaterThan(long? v) { regVendorExceptId(CK_GT, v); }
        public void SetVendorExceptId_LessThan(long? v) { regVendorExceptId(CK_LT, v); }
        public void SetVendorExceptId_GreaterEqual(long? v) { regVendorExceptId(CK_GE, v); }
        public void SetVendorExceptId_LessEqual(long? v) { regVendorExceptId(CK_LE, v); }
        public void SetVendorExceptId_InScope(IList<long?> ls) { regINS<long?>(CK_INS, cTL<long?>(ls), getCValueVendorExceptId(), "VENDOR_EXCEPT_ID"); }
        public void SetVendorExceptId_NotInScope(IList<long?> ls) { regINS<long?>(CK_NINS, cTL<long?>(ls), getCValueVendorExceptId(), "VENDOR_EXCEPT_ID"); }
        public void ExistsVendorRefExceptList(SubQuery<VendorRefExceptCB> subQuery) {
            assertObjectNotNull("subQuery<VendorRefExceptCB>", subQuery);
            VendorRefExceptCB cb = new VendorRefExceptCB(); cb.xsetupForExistsReferrer(this); subQuery.Invoke(cb);
            String subQueryPropertyName = keepVendorExceptId_ExistsSubQuery_VendorRefExceptList(cb.Query());
            registerExistsSubQuery(cb.Query(), "VENDOR_EXCEPT_ID", "VENDOR_EXCEPT_ID", subQueryPropertyName);
        }
        public abstract String keepVendorExceptId_ExistsSubQuery_VendorRefExceptList(VendorRefExceptCQ subQuery);
        public void NotExistsVendorRefExceptList(SubQuery<VendorRefExceptCB> subQuery) {
            assertObjectNotNull("subQuery<VendorRefExceptCB>", subQuery);
            VendorRefExceptCB cb = new VendorRefExceptCB(); cb.xsetupForExistsReferrer(this); subQuery.Invoke(cb);
            String subQueryPropertyName = keepVendorExceptId_NotExistsSubQuery_VendorRefExceptList(cb.Query());
            registerNotExistsSubQuery(cb.Query(), "VENDOR_EXCEPT_ID", "VENDOR_EXCEPT_ID", subQueryPropertyName);
        }
        public abstract String keepVendorExceptId_NotExistsSubQuery_VendorRefExceptList(VendorRefExceptCQ subQuery);
        public void InScopeVendorRefExceptList(SubQuery<VendorRefExceptCB> subQuery) {
            assertObjectNotNull("subQuery<VendorRefExceptCB>", subQuery);
            VendorRefExceptCB cb = new VendorRefExceptCB(); cb.xsetupForInScopeRelation(this); subQuery.Invoke(cb);
            String subQueryPropertyName = keepVendorExceptId_InScopeSubQuery_VendorRefExceptList(cb.Query());
            registerInScopeSubQuery(cb.Query(), "VENDOR_EXCEPT_ID", "VENDOR_EXCEPT_ID", subQueryPropertyName);
        }
        public abstract String keepVendorExceptId_InScopeSubQuery_VendorRefExceptList(VendorRefExceptCQ subQuery);
        public void NotInScopeVendorRefExceptList(SubQuery<VendorRefExceptCB> subQuery) {
            assertObjectNotNull("subQuery<VendorRefExceptCB>", subQuery);
            VendorRefExceptCB cb = new VendorRefExceptCB(); cb.xsetupForInScopeRelation(this); subQuery.Invoke(cb);
            String subQueryPropertyName = keepVendorExceptId_NotInScopeSubQuery_VendorRefExceptList(cb.Query());
            registerNotInScopeSubQuery(cb.Query(), "VENDOR_EXCEPT_ID", "VENDOR_EXCEPT_ID", subQueryPropertyName);
        }
        public abstract String keepVendorExceptId_NotInScopeSubQuery_VendorRefExceptList(VendorRefExceptCQ subQuery);
        public void xsderiveVendorRefExceptList(String function, SubQuery<VendorRefExceptCB> subQuery, String aliasName) {
            assertObjectNotNull("subQuery<VendorRefExceptCB>", subQuery);
            VendorRefExceptCB cb = new VendorRefExceptCB(); cb.xsetupForDerivedReferrer(this); subQuery.Invoke(cb);
            String subQueryPropertyName = keepVendorExceptId_SpecifyDerivedReferrer_VendorRefExceptList(cb.Query());
            registerSpecifyDerivedReferrer(function, cb.Query(), "VENDOR_EXCEPT_ID", "VENDOR_EXCEPT_ID", subQueryPropertyName, aliasName);
        }
        abstract public String keepVendorExceptId_SpecifyDerivedReferrer_VendorRefExceptList(VendorRefExceptCQ subQuery);

        public QDRFunction<VendorRefExceptCB> DerivedVendorRefExceptList() {
            return xcreateQDRFunctionVendorRefExceptList();
        }
        protected QDRFunction<VendorRefExceptCB> xcreateQDRFunctionVendorRefExceptList() {
            return new QDRFunction<VendorRefExceptCB>(delegate(String function, SubQuery<VendorRefExceptCB> subQuery, String operand, Object value) {
                xqderiveVendorRefExceptList(function, subQuery, operand, value);
            });
        }
        public void xqderiveVendorRefExceptList(String function, SubQuery<VendorRefExceptCB> subQuery, String operand, Object value) {
            assertObjectNotNull("subQuery<VendorRefExceptCB>", subQuery);
            VendorRefExceptCB cb = new VendorRefExceptCB(); cb.xsetupForDerivedReferrer(this); subQuery.Invoke(cb);
            String subQueryPropertyName = keepVendorExceptId_QueryDerivedReferrer_VendorRefExceptList(cb.Query()); // for saving query-value.
            String parameterPropertyName = keepVendorExceptId_QueryDerivedReferrer_VendorRefExceptListParameter(value);
            registerQueryDerivedReferrer(function, cb.Query(), "VENDOR_EXCEPT_ID", "VENDOR_EXCEPT_ID", subQueryPropertyName, operand, value, parameterPropertyName);
        }
        public abstract String keepVendorExceptId_QueryDerivedReferrer_VendorRefExceptList(VendorRefExceptCQ subQuery);
        public abstract String keepVendorExceptId_QueryDerivedReferrer_VendorRefExceptListParameter(Object parameterValue);
        public void SetVendorExceptId_IsNull() { regVendorExceptId(CK_ISN, DUMMY_OBJECT); }
        public void SetVendorExceptId_IsNotNull() { regVendorExceptId(CK_ISNN, DUMMY_OBJECT); }
        protected void regVendorExceptId(ConditionKey k, Object v) { regQ(k, v, getCValueVendorExceptId(), "VENDOR_EXCEPT_ID"); }
        protected abstract ConditionValue getCValueVendorExceptId();

        public void SetVandorExceptName_Equal(String v) { DoSetVandorExceptName_Equal(fRES(v)); }
        protected void DoSetVandorExceptName_Equal(String v) { regVandorExceptName(CK_EQ, v); }
        public void SetVandorExceptName_NotEqual(String v) { DoSetVandorExceptName_NotEqual(fRES(v)); }
        protected void DoSetVandorExceptName_NotEqual(String v) { regVandorExceptName(CK_NES, v); }
        public void SetVandorExceptName_InScope(IList<String> ls) { regINS<String>(CK_INS, cTL<String>(ls), getCValueVandorExceptName(), "VANDOR_EXCEPT_NAME"); }
        public void SetVandorExceptName_NotInScope(IList<String> ls) { regINS<String>(CK_NINS, cTL<String>(ls), getCValueVandorExceptName(), "VANDOR_EXCEPT_NAME"); }
        public void SetVandorExceptName_PrefixSearch(String v) { SetVandorExceptName_LikeSearch(v, cLSOP()); }
        public void SetVandorExceptName_LikeSearch(String v, LikeSearchOption option)
        { regLSQ(CK_LS, fRES(v), getCValueVandorExceptName(), "VANDOR_EXCEPT_NAME", option); }
        public void SetVandorExceptName_NotLikeSearch(String v, LikeSearchOption option)
        { regLSQ(CK_NLS, fRES(v), getCValueVandorExceptName(), "VANDOR_EXCEPT_NAME", option); }
        public void SetVandorExceptName_IsNull() { regVandorExceptName(CK_ISN, DUMMY_OBJECT); }
        public void SetVandorExceptName_IsNotNull() { regVandorExceptName(CK_ISNN, DUMMY_OBJECT); }
        protected void regVandorExceptName(ConditionKey k, Object v) { regQ(k, v, getCValueVandorExceptName(), "VANDOR_EXCEPT_NAME"); }
        protected abstract ConditionValue getCValueVandorExceptName();

        // ===================================================================================
        //                                                                    Scalar Condition
        //                                                                    ================
        public SSQFunction<VendorExceptCB> Scalar_Equal() {
            return xcreateSSQFunction("=");
        }

        public SSQFunction<VendorExceptCB> Scalar_NotEqual() {
            return xcreateSSQFunction("<>");
        }

        public SSQFunction<VendorExceptCB> Scalar_GreaterEqual() {
            return xcreateSSQFunction(">=");
        }

        public SSQFunction<VendorExceptCB> Scalar_GreaterThan() {
            return xcreateSSQFunction(">");
        }

        public SSQFunction<VendorExceptCB> Scalar_LessEqual() {
            return xcreateSSQFunction("<=");
        }

        public SSQFunction<VendorExceptCB> Scalar_LessThan() {
            return xcreateSSQFunction("<");
        }

        protected SSQFunction<VendorExceptCB> xcreateSSQFunction(String operand) {
            return new SSQFunction<VendorExceptCB>(delegate(String function, SubQuery<VendorExceptCB> subQuery) {
                xscalarSubQuery(function, subQuery, operand);
            });
        }

        protected void xscalarSubQuery(String function, SubQuery<VendorExceptCB> subQuery, String operand) {
            assertObjectNotNull("subQuery<VendorExceptCB>", subQuery);
            VendorExceptCB cb = new VendorExceptCB(); cb.xsetupForScalarCondition(this); subQuery.Invoke(cb);
            String subQueryPropertyName = keepScalarSubQuery(cb.Query()); // for saving query-value.
            registerScalarSubQuery(function, cb.Query(), subQueryPropertyName, operand);
        }
        public abstract String keepScalarSubQuery(VendorExceptCQ subQuery);

        // ===============================================================================
        //                                                                  MySelf InScope
        //                                                                  ==============
        public void MyselfInScope(SubQuery<VendorExceptCB> subQuery) {
            assertObjectNotNull("subQuery<VendorExceptCB>", subQuery);
            VendorExceptCB cb = new VendorExceptCB(); cb.xsetupForInScopeRelation(this); subQuery.Invoke(cb);
            String subQueryPropertyName = keepMyselfInScopeSubQuery(cb.Query()); // for saving query-value.
            registerInScopeSubQuery(cb.Query(), "VENDOR_EXCEPT_ID", "VENDOR_EXCEPT_ID", subQueryPropertyName);
        }
        public abstract String keepMyselfInScopeSubQuery(VendorExceptCQ subQuery);

        public override String ToString() { return xgetSqlClause().getClause(); }
    }
}
