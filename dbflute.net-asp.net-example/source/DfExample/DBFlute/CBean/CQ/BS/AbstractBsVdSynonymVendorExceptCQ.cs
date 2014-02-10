
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
    public abstract class AbstractBsVdSynonymVendorExceptCQ : AbstractConditionQuery {

        public AbstractBsVdSynonymVendorExceptCQ(ConditionQuery childQuery, SqlClause sqlClause, String aliasName, int nestLevel)
            : base(childQuery, sqlClause, aliasName, nestLevel) {}

        public override String getTableDbName() { return "VD_SYNONYM_VENDOR_EXCEPT"; }
        public override String getTableSqlName() { return "VD_SYNONYM_VENDOR_EXCEPT"; }

        public void SetVendorExceptId_Equal(long? v) { regVendorExceptId(CK_EQ, v); }
        public void SetVendorExceptId_GreaterThan(long? v) { regVendorExceptId(CK_GT, v); }
        public void SetVendorExceptId_LessThan(long? v) { regVendorExceptId(CK_LT, v); }
        public void SetVendorExceptId_GreaterEqual(long? v) { regVendorExceptId(CK_GE, v); }
        public void SetVendorExceptId_LessEqual(long? v) { regVendorExceptId(CK_LE, v); }
        public void SetVendorExceptId_InScope(IList<long?> ls) { regINS<long?>(CK_INS, cTL<long?>(ls), getCValueVendorExceptId(), "VENDOR_EXCEPT_ID"); }
        public void SetVendorExceptId_NotInScope(IList<long?> ls) { regINS<long?>(CK_NINS, cTL<long?>(ls), getCValueVendorExceptId(), "VENDOR_EXCEPT_ID"); }
        public void ExistsVdSynonymVendorRefExceptList(SubQuery<VdSynonymVendorRefExceptCB> subQuery) {
            assertObjectNotNull("subQuery<VdSynonymVendorRefExceptCB>", subQuery);
            VdSynonymVendorRefExceptCB cb = new VdSynonymVendorRefExceptCB(); cb.xsetupForExistsReferrer(this); subQuery.Invoke(cb);
            String subQueryPropertyName = keepVendorExceptId_ExistsSubQuery_VdSynonymVendorRefExceptList(cb.Query());
            registerExistsSubQuery(cb.Query(), "VENDOR_EXCEPT_ID", "VENDOR_EXCEPT_ID", subQueryPropertyName);
        }
        public abstract String keepVendorExceptId_ExistsSubQuery_VdSynonymVendorRefExceptList(VdSynonymVendorRefExceptCQ subQuery);
        public void NotExistsVdSynonymVendorRefExceptList(SubQuery<VdSynonymVendorRefExceptCB> subQuery) {
            assertObjectNotNull("subQuery<VdSynonymVendorRefExceptCB>", subQuery);
            VdSynonymVendorRefExceptCB cb = new VdSynonymVendorRefExceptCB(); cb.xsetupForExistsReferrer(this); subQuery.Invoke(cb);
            String subQueryPropertyName = keepVendorExceptId_NotExistsSubQuery_VdSynonymVendorRefExceptList(cb.Query());
            registerNotExistsSubQuery(cb.Query(), "VENDOR_EXCEPT_ID", "VENDOR_EXCEPT_ID", subQueryPropertyName);
        }
        public abstract String keepVendorExceptId_NotExistsSubQuery_VdSynonymVendorRefExceptList(VdSynonymVendorRefExceptCQ subQuery);
        public void InScopeVdSynonymVendorRefExceptList(SubQuery<VdSynonymVendorRefExceptCB> subQuery) {
            assertObjectNotNull("subQuery<VdSynonymVendorRefExceptCB>", subQuery);
            VdSynonymVendorRefExceptCB cb = new VdSynonymVendorRefExceptCB(); cb.xsetupForInScopeRelation(this); subQuery.Invoke(cb);
            String subQueryPropertyName = keepVendorExceptId_InScopeSubQuery_VdSynonymVendorRefExceptList(cb.Query());
            registerInScopeSubQuery(cb.Query(), "VENDOR_EXCEPT_ID", "VENDOR_EXCEPT_ID", subQueryPropertyName);
        }
        public abstract String keepVendorExceptId_InScopeSubQuery_VdSynonymVendorRefExceptList(VdSynonymVendorRefExceptCQ subQuery);
        public void NotInScopeVdSynonymVendorRefExceptList(SubQuery<VdSynonymVendorRefExceptCB> subQuery) {
            assertObjectNotNull("subQuery<VdSynonymVendorRefExceptCB>", subQuery);
            VdSynonymVendorRefExceptCB cb = new VdSynonymVendorRefExceptCB(); cb.xsetupForInScopeRelation(this); subQuery.Invoke(cb);
            String subQueryPropertyName = keepVendorExceptId_NotInScopeSubQuery_VdSynonymVendorRefExceptList(cb.Query());
            registerNotInScopeSubQuery(cb.Query(), "VENDOR_EXCEPT_ID", "VENDOR_EXCEPT_ID", subQueryPropertyName);
        }
        public abstract String keepVendorExceptId_NotInScopeSubQuery_VdSynonymVendorRefExceptList(VdSynonymVendorRefExceptCQ subQuery);
        public void xsderiveVdSynonymVendorRefExceptList(String function, SubQuery<VdSynonymVendorRefExceptCB> subQuery, String aliasName) {
            assertObjectNotNull("subQuery<VdSynonymVendorRefExceptCB>", subQuery);
            VdSynonymVendorRefExceptCB cb = new VdSynonymVendorRefExceptCB(); cb.xsetupForDerivedReferrer(this); subQuery.Invoke(cb);
            String subQueryPropertyName = keepVendorExceptId_SpecifyDerivedReferrer_VdSynonymVendorRefExceptList(cb.Query());
            registerSpecifyDerivedReferrer(function, cb.Query(), "VENDOR_EXCEPT_ID", "VENDOR_EXCEPT_ID", subQueryPropertyName, aliasName);
        }
        abstract public String keepVendorExceptId_SpecifyDerivedReferrer_VdSynonymVendorRefExceptList(VdSynonymVendorRefExceptCQ subQuery);

        public QDRFunction<VdSynonymVendorRefExceptCB> DerivedVdSynonymVendorRefExceptList() {
            return xcreateQDRFunctionVdSynonymVendorRefExceptList();
        }
        protected QDRFunction<VdSynonymVendorRefExceptCB> xcreateQDRFunctionVdSynonymVendorRefExceptList() {
            return new QDRFunction<VdSynonymVendorRefExceptCB>(delegate(String function, SubQuery<VdSynonymVendorRefExceptCB> subQuery, String operand, Object value) {
                xqderiveVdSynonymVendorRefExceptList(function, subQuery, operand, value);
            });
        }
        public void xqderiveVdSynonymVendorRefExceptList(String function, SubQuery<VdSynonymVendorRefExceptCB> subQuery, String operand, Object value) {
            assertObjectNotNull("subQuery<VdSynonymVendorRefExceptCB>", subQuery);
            VdSynonymVendorRefExceptCB cb = new VdSynonymVendorRefExceptCB(); cb.xsetupForDerivedReferrer(this); subQuery.Invoke(cb);
            String subQueryPropertyName = keepVendorExceptId_QueryDerivedReferrer_VdSynonymVendorRefExceptList(cb.Query()); // for saving query-value.
            String parameterPropertyName = keepVendorExceptId_QueryDerivedReferrer_VdSynonymVendorRefExceptListParameter(value);
            registerQueryDerivedReferrer(function, cb.Query(), "VENDOR_EXCEPT_ID", "VENDOR_EXCEPT_ID", subQueryPropertyName, operand, value, parameterPropertyName);
        }
        public abstract String keepVendorExceptId_QueryDerivedReferrer_VdSynonymVendorRefExceptList(VdSynonymVendorRefExceptCQ subQuery);
        public abstract String keepVendorExceptId_QueryDerivedReferrer_VdSynonymVendorRefExceptListParameter(Object parameterValue);
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
        public SSQFunction<VdSynonymVendorExceptCB> Scalar_Equal() {
            return xcreateSSQFunction("=");
        }

        public SSQFunction<VdSynonymVendorExceptCB> Scalar_NotEqual() {
            return xcreateSSQFunction("<>");
        }

        public SSQFunction<VdSynonymVendorExceptCB> Scalar_GreaterEqual() {
            return xcreateSSQFunction(">=");
        }

        public SSQFunction<VdSynonymVendorExceptCB> Scalar_GreaterThan() {
            return xcreateSSQFunction(">");
        }

        public SSQFunction<VdSynonymVendorExceptCB> Scalar_LessEqual() {
            return xcreateSSQFunction("<=");
        }

        public SSQFunction<VdSynonymVendorExceptCB> Scalar_LessThan() {
            return xcreateSSQFunction("<");
        }

        protected SSQFunction<VdSynonymVendorExceptCB> xcreateSSQFunction(String operand) {
            return new SSQFunction<VdSynonymVendorExceptCB>(delegate(String function, SubQuery<VdSynonymVendorExceptCB> subQuery) {
                xscalarSubQuery(function, subQuery, operand);
            });
        }

        protected void xscalarSubQuery(String function, SubQuery<VdSynonymVendorExceptCB> subQuery, String operand) {
            assertObjectNotNull("subQuery<VdSynonymVendorExceptCB>", subQuery);
            VdSynonymVendorExceptCB cb = new VdSynonymVendorExceptCB(); cb.xsetupForScalarCondition(this); subQuery.Invoke(cb);
            String subQueryPropertyName = keepScalarSubQuery(cb.Query()); // for saving query-value.
            registerScalarSubQuery(function, cb.Query(), subQueryPropertyName, operand);
        }
        public abstract String keepScalarSubQuery(VdSynonymVendorExceptCQ subQuery);

        // ===============================================================================
        //                                                                  MySelf InScope
        //                                                                  ==============
        public void MyselfInScope(SubQuery<VdSynonymVendorExceptCB> subQuery) {
            assertObjectNotNull("subQuery<VdSynonymVendorExceptCB>", subQuery);
            VdSynonymVendorExceptCB cb = new VdSynonymVendorExceptCB(); cb.xsetupForInScopeRelation(this); subQuery.Invoke(cb);
            String subQueryPropertyName = keepMyselfInScopeSubQuery(cb.Query()); // for saving query-value.
            registerInScopeSubQuery(cb.Query(), "VENDOR_EXCEPT_ID", "VENDOR_EXCEPT_ID", subQueryPropertyName);
        }
        public abstract String keepMyselfInScopeSubQuery(VdSynonymVendorExceptCQ subQuery);

        public override String ToString() { return xgetSqlClause().getClause(); }
    }
}
