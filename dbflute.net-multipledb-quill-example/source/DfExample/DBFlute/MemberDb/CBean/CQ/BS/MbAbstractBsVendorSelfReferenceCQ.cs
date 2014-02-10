
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
    public abstract class MbAbstractBsVendorSelfReferenceCQ : MbAbstractConditionQuery {

        public MbAbstractBsVendorSelfReferenceCQ(MbConditionQuery childQuery, MbSqlClause sqlClause, String aliasName, int nestLevel)
            : base(childQuery, sqlClause, aliasName, nestLevel) {}

        public override String getTableDbName() { return "vendor_self_reference"; }
        public override String getTableSqlName() { return "vendor_self_reference"; }

        public void SetSelfReferenceId_Equal(long? v) { regSelfReferenceId(CK_EQ, v); }
        public void SetSelfReferenceId_GreaterThan(long? v) { regSelfReferenceId(CK_GT, v); }
        public void SetSelfReferenceId_LessThan(long? v) { regSelfReferenceId(CK_LT, v); }
        public void SetSelfReferenceId_GreaterEqual(long? v) { regSelfReferenceId(CK_GE, v); }
        public void SetSelfReferenceId_LessEqual(long? v) { regSelfReferenceId(CK_LE, v); }
        public void SetSelfReferenceId_InScope(IList<long?> ls) { regINS<long?>(CK_INS, cTL<long?>(ls), getCValueSelfReferenceId(), "SELF_REFERENCE_ID"); }
        public void SetSelfReferenceId_NotInScope(IList<long?> ls) { regINS<long?>(CK_NINS, cTL<long?>(ls), getCValueSelfReferenceId(), "SELF_REFERENCE_ID"); }
        public void ExistsVendorSelfReferenceSelfList(MbSubQuery<MbVendorSelfReferenceCB> subQuery) {
            assertObjectNotNull("subQuery<MbVendorSelfReferenceCB>", subQuery);
            MbVendorSelfReferenceCB cb = new MbVendorSelfReferenceCB(); cb.xsetupForExistsReferrer(this); subQuery.Invoke(cb);
            String subQueryPropertyName = keepSelfReferenceId_ExistsSubQuery_VendorSelfReferenceSelfList(cb.Query());
            registerExistsSubQuery(cb.Query(), "SELF_REFERENCE_ID", "PARENT_ID", subQueryPropertyName);
        }
        public abstract String keepSelfReferenceId_ExistsSubQuery_VendorSelfReferenceSelfList(MbVendorSelfReferenceCQ subQuery);
        public void NotExistsVendorSelfReferenceSelfList(MbSubQuery<MbVendorSelfReferenceCB> subQuery) {
            assertObjectNotNull("subQuery<MbVendorSelfReferenceCB>", subQuery);
            MbVendorSelfReferenceCB cb = new MbVendorSelfReferenceCB(); cb.xsetupForExistsReferrer(this); subQuery.Invoke(cb);
            String subQueryPropertyName = keepSelfReferenceId_NotExistsSubQuery_VendorSelfReferenceSelfList(cb.Query());
            registerNotExistsSubQuery(cb.Query(), "SELF_REFERENCE_ID", "PARENT_ID", subQueryPropertyName);
        }
        public abstract String keepSelfReferenceId_NotExistsSubQuery_VendorSelfReferenceSelfList(MbVendorSelfReferenceCQ subQuery);
        public void InScopeVendorSelfReferenceSelfList(MbSubQuery<MbVendorSelfReferenceCB> subQuery) {
            assertObjectNotNull("subQuery<MbVendorSelfReferenceCB>", subQuery);
            MbVendorSelfReferenceCB cb = new MbVendorSelfReferenceCB(); cb.xsetupForInScopeRelation(this); subQuery.Invoke(cb);
            String subQueryPropertyName = keepSelfReferenceId_InScopeSubQuery_VendorSelfReferenceSelfList(cb.Query());
            registerInScopeSubQuery(cb.Query(), "SELF_REFERENCE_ID", "PARENT_ID", subQueryPropertyName);
        }
        public abstract String keepSelfReferenceId_InScopeSubQuery_VendorSelfReferenceSelfList(MbVendorSelfReferenceCQ subQuery);
        public void NotInScopeVendorSelfReferenceSelfList(MbSubQuery<MbVendorSelfReferenceCB> subQuery) {
            assertObjectNotNull("subQuery<MbVendorSelfReferenceCB>", subQuery);
            MbVendorSelfReferenceCB cb = new MbVendorSelfReferenceCB(); cb.xsetupForInScopeRelation(this); subQuery.Invoke(cb);
            String subQueryPropertyName = keepSelfReferenceId_NotInScopeSubQuery_VendorSelfReferenceSelfList(cb.Query());
            registerNotInScopeSubQuery(cb.Query(), "SELF_REFERENCE_ID", "PARENT_ID", subQueryPropertyName);
        }
        public abstract String keepSelfReferenceId_NotInScopeSubQuery_VendorSelfReferenceSelfList(MbVendorSelfReferenceCQ subQuery);
        public void xsderiveVendorSelfReferenceSelfList(String function, MbSubQuery<MbVendorSelfReferenceCB> subQuery, String aliasName) {
            assertObjectNotNull("subQuery<MbVendorSelfReferenceCB>", subQuery);
            MbVendorSelfReferenceCB cb = new MbVendorSelfReferenceCB(); cb.xsetupForDerivedReferrer(this); subQuery.Invoke(cb);
            String subQueryPropertyName = keepSelfReferenceId_SpecifyDerivedReferrer_VendorSelfReferenceSelfList(cb.Query());
            registerSpecifyDerivedReferrer(function, cb.Query(), "SELF_REFERENCE_ID", "PARENT_ID", subQueryPropertyName, aliasName);
        }
        abstract public String keepSelfReferenceId_SpecifyDerivedReferrer_VendorSelfReferenceSelfList(MbVendorSelfReferenceCQ subQuery);

        public QDRFunction<MbVendorSelfReferenceCB> DerivedVendorSelfReferenceSelfList() {
            return xcreateQDRFunctionVendorSelfReferenceSelfList();
        }
        protected QDRFunction<MbVendorSelfReferenceCB> xcreateQDRFunctionVendorSelfReferenceSelfList() {
            return new QDRFunction<MbVendorSelfReferenceCB>(delegate(String function, MbSubQuery<MbVendorSelfReferenceCB> subQuery, String operand, Object value) {
                xqderiveVendorSelfReferenceSelfList(function, subQuery, operand, value);
            });
        }
        public void xqderiveVendorSelfReferenceSelfList(String function, MbSubQuery<MbVendorSelfReferenceCB> subQuery, String operand, Object value) {
            assertObjectNotNull("subQuery<MbVendorSelfReferenceCB>", subQuery);
            MbVendorSelfReferenceCB cb = new MbVendorSelfReferenceCB(); cb.xsetupForDerivedReferrer(this); subQuery.Invoke(cb);
            String subQueryPropertyName = keepSelfReferenceId_QueryDerivedReferrer_VendorSelfReferenceSelfList(cb.Query()); // for saving query-value.
            String parameterPropertyName = keepSelfReferenceId_QueryDerivedReferrer_VendorSelfReferenceSelfListParameter(value);
            registerQueryDerivedReferrer(function, cb.Query(), "SELF_REFERENCE_ID", "PARENT_ID", subQueryPropertyName, operand, value, parameterPropertyName);
        }
        public abstract String keepSelfReferenceId_QueryDerivedReferrer_VendorSelfReferenceSelfList(MbVendorSelfReferenceCQ subQuery);
        public abstract String keepSelfReferenceId_QueryDerivedReferrer_VendorSelfReferenceSelfListParameter(Object parameterValue);
        public void SetSelfReferenceId_IsNull() { regSelfReferenceId(CK_ISN, DUMMY_OBJECT); }
        public void SetSelfReferenceId_IsNotNull() { regSelfReferenceId(CK_ISNN, DUMMY_OBJECT); }
        protected void regSelfReferenceId(MbConditionKey k, Object v) { regQ(k, v, getCValueSelfReferenceId(), "SELF_REFERENCE_ID"); }
        protected abstract MbConditionValue getCValueSelfReferenceId();

        public void SetSelfReferenceName_Equal(String v) { DoSetSelfReferenceName_Equal(fRES(v)); }
        protected void DoSetSelfReferenceName_Equal(String v) { regSelfReferenceName(CK_EQ, v); }
        public void SetSelfReferenceName_NotEqual(String v) { DoSetSelfReferenceName_NotEqual(fRES(v)); }
        protected void DoSetSelfReferenceName_NotEqual(String v) { regSelfReferenceName(CK_NES, v); }
        public void SetSelfReferenceName_InScope(IList<String> ls) { regINS<String>(CK_INS, cTL<String>(ls), getCValueSelfReferenceName(), "SELF_REFERENCE_NAME"); }
        public void SetSelfReferenceName_NotInScope(IList<String> ls) { regINS<String>(CK_NINS, cTL<String>(ls), getCValueSelfReferenceName(), "SELF_REFERENCE_NAME"); }
        public void SetSelfReferenceName_PrefixSearch(String v) { SetSelfReferenceName_LikeSearch(v, cLSOP()); }
        public void SetSelfReferenceName_LikeSearch(String v, MbLikeSearchOption option)
        { regLSQ(CK_LS, fRES(v), getCValueSelfReferenceName(), "SELF_REFERENCE_NAME", option); }
        public void SetSelfReferenceName_NotLikeSearch(String v, MbLikeSearchOption option)
        { regLSQ(CK_NLS, fRES(v), getCValueSelfReferenceName(), "SELF_REFERENCE_NAME", option); }
        protected void regSelfReferenceName(MbConditionKey k, Object v) { regQ(k, v, getCValueSelfReferenceName(), "SELF_REFERENCE_NAME"); }
        protected abstract MbConditionValue getCValueSelfReferenceName();

        public void SetParentId_Equal(long? v) { regParentId(CK_EQ, v); }
        public void SetParentId_GreaterThan(long? v) { regParentId(CK_GT, v); }
        public void SetParentId_LessThan(long? v) { regParentId(CK_LT, v); }
        public void SetParentId_GreaterEqual(long? v) { regParentId(CK_GE, v); }
        public void SetParentId_LessEqual(long? v) { regParentId(CK_LE, v); }
        public void SetParentId_InScope(IList<long?> ls) { regINS<long?>(CK_INS, cTL<long?>(ls), getCValueParentId(), "PARENT_ID"); }
        public void SetParentId_NotInScope(IList<long?> ls) { regINS<long?>(CK_NINS, cTL<long?>(ls), getCValueParentId(), "PARENT_ID"); }
        public void InScopeVendorSelfReferenceSelf(MbSubQuery<MbVendorSelfReferenceCB> subQuery) {
            assertObjectNotNull("subQuery<MbVendorSelfReferenceCB>", subQuery);
            MbVendorSelfReferenceCB cb = new MbVendorSelfReferenceCB(); cb.xsetupForInScopeRelation(this); subQuery.Invoke(cb);
            String subQueryPropertyName = keepParentId_InScopeSubQuery_VendorSelfReferenceSelf(cb.Query());
            registerInScopeSubQuery(cb.Query(), "PARENT_ID", "SELF_REFERENCE_ID", subQueryPropertyName);
        }
        public abstract String keepParentId_InScopeSubQuery_VendorSelfReferenceSelf(MbVendorSelfReferenceCQ subQuery);
        public void NotInScopeVendorSelfReferenceSelf(MbSubQuery<MbVendorSelfReferenceCB> subQuery) {
            assertObjectNotNull("subQuery<MbVendorSelfReferenceCB>", subQuery);
            MbVendorSelfReferenceCB cb = new MbVendorSelfReferenceCB(); cb.xsetupForInScopeRelation(this); subQuery.Invoke(cb);
            String subQueryPropertyName = keepParentId_NotInScopeSubQuery_VendorSelfReferenceSelf(cb.Query());
            registerNotInScopeSubQuery(cb.Query(), "PARENT_ID", "SELF_REFERENCE_ID", subQueryPropertyName);
        }
        public abstract String keepParentId_NotInScopeSubQuery_VendorSelfReferenceSelf(MbVendorSelfReferenceCQ subQuery);
        public void SetParentId_IsNull() { regParentId(CK_ISN, DUMMY_OBJECT); }
        public void SetParentId_IsNotNull() { regParentId(CK_ISNN, DUMMY_OBJECT); }
        protected void regParentId(MbConditionKey k, Object v) { regQ(k, v, getCValueParentId(), "PARENT_ID"); }
        protected abstract MbConditionValue getCValueParentId();

        // ===================================================================================
        //                                                                    Scalar Condition
        //                                                                    ================
        public SSQFunction<MbVendorSelfReferenceCB> Scalar_Equal() {
            return xcreateSSQFunction("=");
        }

        public SSQFunction<MbVendorSelfReferenceCB> Scalar_NotEqual() {
            return xcreateSSQFunction("<>");
        }

        public SSQFunction<MbVendorSelfReferenceCB> Scalar_GreaterEqual() {
            return xcreateSSQFunction(">=");
        }

        public SSQFunction<MbVendorSelfReferenceCB> Scalar_GreaterThan() {
            return xcreateSSQFunction(">");
        }

        public SSQFunction<MbVendorSelfReferenceCB> Scalar_LessEqual() {
            return xcreateSSQFunction("<=");
        }

        public SSQFunction<MbVendorSelfReferenceCB> Scalar_LessThan() {
            return xcreateSSQFunction("<");
        }

        protected SSQFunction<MbVendorSelfReferenceCB> xcreateSSQFunction(String operand) {
            return new SSQFunction<MbVendorSelfReferenceCB>(delegate(String function, MbSubQuery<MbVendorSelfReferenceCB> subQuery) {
                xscalarSubQuery(function, subQuery, operand);
            });
        }

        protected void xscalarSubQuery(String function, MbSubQuery<MbVendorSelfReferenceCB> subQuery, String operand) {
            assertObjectNotNull("subQuery<MbVendorSelfReferenceCB>", subQuery);
            MbVendorSelfReferenceCB cb = new MbVendorSelfReferenceCB(); cb.xsetupForScalarCondition(this); subQuery.Invoke(cb);
            String subQueryPropertyName = keepScalarSubQuery(cb.Query()); // for saving query-value.
            registerScalarSubQuery(function, cb.Query(), subQueryPropertyName, operand);
        }
        public abstract String keepScalarSubQuery(MbVendorSelfReferenceCQ subQuery);

        // ===============================================================================
        //                                                                  MySelf InScope
        //                                                                  ==============
        public void MyselfInScope(MbSubQuery<MbVendorSelfReferenceCB> subQuery) {
            assertObjectNotNull("subQuery<MbVendorSelfReferenceCB>", subQuery);
            MbVendorSelfReferenceCB cb = new MbVendorSelfReferenceCB(); cb.xsetupForInScopeRelation(this); subQuery.Invoke(cb);
            String subQueryPropertyName = keepMyselfInScopeSubQuery(cb.Query()); // for saving query-value.
            registerInScopeSubQuery(cb.Query(), "SELF_REFERENCE_ID", "SELF_REFERENCE_ID", subQueryPropertyName);
        }
        public abstract String keepMyselfInScopeSubQuery(MbVendorSelfReferenceCQ subQuery);

        public override String ToString() { return xgetSqlClause().getClause(); }
    }
}
