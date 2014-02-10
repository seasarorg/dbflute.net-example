
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
    public abstract class AbstractBsWhiteSelfReferenceCQ : AbstractConditionQuery {

        public AbstractBsWhiteSelfReferenceCQ(ConditionQuery childQuery, SqlClause sqlClause, String aliasName, int nestLevel)
            : base(childQuery, sqlClause, aliasName, nestLevel) {}

        public override String getTableDbName() { return "white_self_reference"; }
        public override String getTableSqlName() { return "white_self_reference"; }

        public void SetSelfReferenceId_Equal(long? v) { regSelfReferenceId(CK_EQ, v); }
        public void SetSelfReferenceId_NotEqual(long? v) { regSelfReferenceId(CK_NES, v); }
        public void SetSelfReferenceId_GreaterThan(long? v) { regSelfReferenceId(CK_GT, v); }
        public void SetSelfReferenceId_LessThan(long? v) { regSelfReferenceId(CK_LT, v); }
        public void SetSelfReferenceId_GreaterEqual(long? v) { regSelfReferenceId(CK_GE, v); }
        public void SetSelfReferenceId_LessEqual(long? v) { regSelfReferenceId(CK_LE, v); }
        public void SetSelfReferenceId_InScope(IList<long?> ls) { regINS<long?>(CK_INS, cTL<long?>(ls), getCValueSelfReferenceId(), "SELF_REFERENCE_ID"); }
        public void SetSelfReferenceId_NotInScope(IList<long?> ls) { regINS<long?>(CK_NINS, cTL<long?>(ls), getCValueSelfReferenceId(), "SELF_REFERENCE_ID"); }
        public void ExistsWhiteSelfReferenceSelfList(SubQuery<WhiteSelfReferenceCB> subQuery) {
            assertObjectNotNull("subQuery<WhiteSelfReferenceCB>", subQuery);
            WhiteSelfReferenceCB cb = new WhiteSelfReferenceCB(); cb.xsetupForExistsReferrer(this); subQuery.Invoke(cb);
            String subQueryPropertyName = keepSelfReferenceId_ExistsSubQuery_WhiteSelfReferenceSelfList(cb.Query());
            registerExistsSubQuery(cb.Query(), "SELF_REFERENCE_ID", "PARENT_ID", subQueryPropertyName);
        }
        public abstract String keepSelfReferenceId_ExistsSubQuery_WhiteSelfReferenceSelfList(WhiteSelfReferenceCQ subQuery);
        public void NotExistsWhiteSelfReferenceSelfList(SubQuery<WhiteSelfReferenceCB> subQuery) {
            assertObjectNotNull("subQuery<WhiteSelfReferenceCB>", subQuery);
            WhiteSelfReferenceCB cb = new WhiteSelfReferenceCB(); cb.xsetupForExistsReferrer(this); subQuery.Invoke(cb);
            String subQueryPropertyName = keepSelfReferenceId_NotExistsSubQuery_WhiteSelfReferenceSelfList(cb.Query());
            registerNotExistsSubQuery(cb.Query(), "SELF_REFERENCE_ID", "PARENT_ID", subQueryPropertyName);
        }
        public abstract String keepSelfReferenceId_NotExistsSubQuery_WhiteSelfReferenceSelfList(WhiteSelfReferenceCQ subQuery);
        public void InScopeWhiteSelfReferenceSelfList(SubQuery<WhiteSelfReferenceCB> subQuery) {
            assertObjectNotNull("subQuery<WhiteSelfReferenceCB>", subQuery);
            WhiteSelfReferenceCB cb = new WhiteSelfReferenceCB(); cb.xsetupForInScopeRelation(this); subQuery.Invoke(cb);
            String subQueryPropertyName = keepSelfReferenceId_InScopeSubQuery_WhiteSelfReferenceSelfList(cb.Query());
            registerInScopeSubQuery(cb.Query(), "SELF_REFERENCE_ID", "PARENT_ID", subQueryPropertyName);
        }
        public abstract String keepSelfReferenceId_InScopeSubQuery_WhiteSelfReferenceSelfList(WhiteSelfReferenceCQ subQuery);
        public void NotInScopeWhiteSelfReferenceSelfList(SubQuery<WhiteSelfReferenceCB> subQuery) {
            assertObjectNotNull("subQuery<WhiteSelfReferenceCB>", subQuery);
            WhiteSelfReferenceCB cb = new WhiteSelfReferenceCB(); cb.xsetupForInScopeRelation(this); subQuery.Invoke(cb);
            String subQueryPropertyName = keepSelfReferenceId_NotInScopeSubQuery_WhiteSelfReferenceSelfList(cb.Query());
            registerNotInScopeSubQuery(cb.Query(), "SELF_REFERENCE_ID", "PARENT_ID", subQueryPropertyName);
        }
        public abstract String keepSelfReferenceId_NotInScopeSubQuery_WhiteSelfReferenceSelfList(WhiteSelfReferenceCQ subQuery);
        public void xsderiveWhiteSelfReferenceSelfList(String function, SubQuery<WhiteSelfReferenceCB> subQuery, String aliasName) {
            assertObjectNotNull("subQuery<WhiteSelfReferenceCB>", subQuery);
            WhiteSelfReferenceCB cb = new WhiteSelfReferenceCB(); cb.xsetupForDerivedReferrer(this); subQuery.Invoke(cb);
            String subQueryPropertyName = keepSelfReferenceId_SpecifyDerivedReferrer_WhiteSelfReferenceSelfList(cb.Query());
            registerSpecifyDerivedReferrer(function, cb.Query(), "SELF_REFERENCE_ID", "PARENT_ID", subQueryPropertyName, aliasName);
        }
        abstract public String keepSelfReferenceId_SpecifyDerivedReferrer_WhiteSelfReferenceSelfList(WhiteSelfReferenceCQ subQuery);

        public QDRFunction<WhiteSelfReferenceCB> DerivedWhiteSelfReferenceSelfList() {
            return xcreateQDRFunctionWhiteSelfReferenceSelfList();
        }
        protected QDRFunction<WhiteSelfReferenceCB> xcreateQDRFunctionWhiteSelfReferenceSelfList() {
            return new QDRFunction<WhiteSelfReferenceCB>(delegate(String function, SubQuery<WhiteSelfReferenceCB> subQuery, String operand, Object value) {
                xqderiveWhiteSelfReferenceSelfList(function, subQuery, operand, value);
            });
        }
        public void xqderiveWhiteSelfReferenceSelfList(String function, SubQuery<WhiteSelfReferenceCB> subQuery, String operand, Object value) {
            assertObjectNotNull("subQuery<WhiteSelfReferenceCB>", subQuery);
            WhiteSelfReferenceCB cb = new WhiteSelfReferenceCB(); cb.xsetupForDerivedReferrer(this); subQuery.Invoke(cb);
            String subQueryPropertyName = keepSelfReferenceId_QueryDerivedReferrer_WhiteSelfReferenceSelfList(cb.Query()); // for saving query-value.
            String parameterPropertyName = keepSelfReferenceId_QueryDerivedReferrer_WhiteSelfReferenceSelfListParameter(value);
            registerQueryDerivedReferrer(function, cb.Query(), "SELF_REFERENCE_ID", "PARENT_ID", subQueryPropertyName, operand, value, parameterPropertyName);
        }
        public abstract String keepSelfReferenceId_QueryDerivedReferrer_WhiteSelfReferenceSelfList(WhiteSelfReferenceCQ subQuery);
        public abstract String keepSelfReferenceId_QueryDerivedReferrer_WhiteSelfReferenceSelfListParameter(Object parameterValue);
        public void SetSelfReferenceId_IsNull() { regSelfReferenceId(CK_ISN, DUMMY_OBJECT); }
        public void SetSelfReferenceId_IsNotNull() { regSelfReferenceId(CK_ISNN, DUMMY_OBJECT); }
        protected void regSelfReferenceId(ConditionKey k, Object v) { regQ(k, v, getCValueSelfReferenceId(), "SELF_REFERENCE_ID"); }
        protected abstract ConditionValue getCValueSelfReferenceId();

        public void SetSelfReferenceName_Equal(String v) { DoSetSelfReferenceName_Equal(fRES(v)); }
        protected void DoSetSelfReferenceName_Equal(String v) { regSelfReferenceName(CK_EQ, v); }
        public void SetSelfReferenceName_NotEqual(String v) { DoSetSelfReferenceName_NotEqual(fRES(v)); }
        protected void DoSetSelfReferenceName_NotEqual(String v) { regSelfReferenceName(CK_NES, v); }
        public void SetSelfReferenceName_InScope(IList<String> ls) { regINS<String>(CK_INS, cTL<String>(ls), getCValueSelfReferenceName(), "SELF_REFERENCE_NAME"); }
        public void SetSelfReferenceName_NotInScope(IList<String> ls) { regINS<String>(CK_NINS, cTL<String>(ls), getCValueSelfReferenceName(), "SELF_REFERENCE_NAME"); }
        public void SetSelfReferenceName_PrefixSearch(String v) { SetSelfReferenceName_LikeSearch(v, cLSOP()); }
        public void SetSelfReferenceName_LikeSearch(String v, LikeSearchOption option)
        { regLSQ(CK_LS, fRES(v), getCValueSelfReferenceName(), "SELF_REFERENCE_NAME", option); }
        public void SetSelfReferenceName_NotLikeSearch(String v, LikeSearchOption option)
        { regLSQ(CK_NLS, fRES(v), getCValueSelfReferenceName(), "SELF_REFERENCE_NAME", option); }
        protected void regSelfReferenceName(ConditionKey k, Object v) { regQ(k, v, getCValueSelfReferenceName(), "SELF_REFERENCE_NAME"); }
        protected abstract ConditionValue getCValueSelfReferenceName();

        public void SetParentId_Equal(long? v) { regParentId(CK_EQ, v); }
        public void SetParentId_NotEqual(long? v) { regParentId(CK_NES, v); }
        public void SetParentId_GreaterThan(long? v) { regParentId(CK_GT, v); }
        public void SetParentId_LessThan(long? v) { regParentId(CK_LT, v); }
        public void SetParentId_GreaterEqual(long? v) { regParentId(CK_GE, v); }
        public void SetParentId_LessEqual(long? v) { regParentId(CK_LE, v); }
        public void SetParentId_InScope(IList<long?> ls) { regINS<long?>(CK_INS, cTL<long?>(ls), getCValueParentId(), "PARENT_ID"); }
        public void SetParentId_NotInScope(IList<long?> ls) { regINS<long?>(CK_NINS, cTL<long?>(ls), getCValueParentId(), "PARENT_ID"); }
        public void InScopeWhiteSelfReferenceSelf(SubQuery<WhiteSelfReferenceCB> subQuery) {
            assertObjectNotNull("subQuery<WhiteSelfReferenceCB>", subQuery);
            WhiteSelfReferenceCB cb = new WhiteSelfReferenceCB(); cb.xsetupForInScopeRelation(this); subQuery.Invoke(cb);
            String subQueryPropertyName = keepParentId_InScopeSubQuery_WhiteSelfReferenceSelf(cb.Query());
            registerInScopeSubQuery(cb.Query(), "PARENT_ID", "SELF_REFERENCE_ID", subQueryPropertyName);
        }
        public abstract String keepParentId_InScopeSubQuery_WhiteSelfReferenceSelf(WhiteSelfReferenceCQ subQuery);
        public void NotInScopeWhiteSelfReferenceSelf(SubQuery<WhiteSelfReferenceCB> subQuery) {
            assertObjectNotNull("subQuery<WhiteSelfReferenceCB>", subQuery);
            WhiteSelfReferenceCB cb = new WhiteSelfReferenceCB(); cb.xsetupForInScopeRelation(this); subQuery.Invoke(cb);
            String subQueryPropertyName = keepParentId_NotInScopeSubQuery_WhiteSelfReferenceSelf(cb.Query());
            registerNotInScopeSubQuery(cb.Query(), "PARENT_ID", "SELF_REFERENCE_ID", subQueryPropertyName);
        }
        public abstract String keepParentId_NotInScopeSubQuery_WhiteSelfReferenceSelf(WhiteSelfReferenceCQ subQuery);
        public void SetParentId_IsNull() { regParentId(CK_ISN, DUMMY_OBJECT); }
        public void SetParentId_IsNotNull() { regParentId(CK_ISNN, DUMMY_OBJECT); }
        protected void regParentId(ConditionKey k, Object v) { regQ(k, v, getCValueParentId(), "PARENT_ID"); }
        protected abstract ConditionValue getCValueParentId();

        // ===================================================================================
        //                                                                    Scalar Condition
        //                                                                    ================
        public SSQFunction<WhiteSelfReferenceCB> Scalar_Equal() {
            return xcreateSSQFunction("=");
        }

        public SSQFunction<WhiteSelfReferenceCB> Scalar_NotEqual() {
            return xcreateSSQFunction("<>");
        }

        public SSQFunction<WhiteSelfReferenceCB> Scalar_GreaterEqual() {
            return xcreateSSQFunction(">=");
        }

        public SSQFunction<WhiteSelfReferenceCB> Scalar_GreaterThan() {
            return xcreateSSQFunction(">");
        }

        public SSQFunction<WhiteSelfReferenceCB> Scalar_LessEqual() {
            return xcreateSSQFunction("<=");
        }

        public SSQFunction<WhiteSelfReferenceCB> Scalar_LessThan() {
            return xcreateSSQFunction("<");
        }

        protected SSQFunction<WhiteSelfReferenceCB> xcreateSSQFunction(String operand) {
            return new SSQFunction<WhiteSelfReferenceCB>(delegate(String function, SubQuery<WhiteSelfReferenceCB> subQuery) {
                xscalarSubQuery(function, subQuery, operand);
            });
        }

        protected void xscalarSubQuery(String function, SubQuery<WhiteSelfReferenceCB> subQuery, String operand) {
            assertObjectNotNull("subQuery<WhiteSelfReferenceCB>", subQuery);
            WhiteSelfReferenceCB cb = new WhiteSelfReferenceCB(); cb.xsetupForScalarCondition(this); subQuery.Invoke(cb);
            String subQueryPropertyName = keepScalarSubQuery(cb.Query()); // for saving query-value.
            registerScalarSubQuery(function, cb.Query(), subQueryPropertyName, operand);
        }
        public abstract String keepScalarSubQuery(WhiteSelfReferenceCQ subQuery);

        // ===============================================================================
        //                                                                  MySelf InScope
        //                                                                  ==============
        public void MyselfInScope(SubQuery<WhiteSelfReferenceCB> subQuery) {
            assertObjectNotNull("subQuery<WhiteSelfReferenceCB>", subQuery);
            WhiteSelfReferenceCB cb = new WhiteSelfReferenceCB(); cb.xsetupForInScopeRelation(this); subQuery.Invoke(cb);
            String subQueryPropertyName = keepMyselfInScopeSubQuery(cb.Query()); // for saving query-value.
            registerInScopeSubQuery(cb.Query(), "SELF_REFERENCE_ID", "SELF_REFERENCE_ID", subQueryPropertyName);
        }
        public abstract String keepMyselfInScopeSubQuery(WhiteSelfReferenceCQ subQuery);

        public override String ToString() { return xgetSqlClause().getClause(); }
    }
}
