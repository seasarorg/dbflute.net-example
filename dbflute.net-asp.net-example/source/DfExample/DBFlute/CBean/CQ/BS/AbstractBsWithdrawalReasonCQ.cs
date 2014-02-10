
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
    public abstract class AbstractBsWithdrawalReasonCQ : AbstractConditionQuery {

        public AbstractBsWithdrawalReasonCQ(ConditionQuery childQuery, SqlClause sqlClause, String aliasName, int nestLevel)
            : base(childQuery, sqlClause, aliasName, nestLevel) {}

        public override String getTableDbName() { return "WITHDRAWAL_REASON"; }
        public override String getTableSqlName() { return "WITHDRAWAL_REASON"; }

        public void SetWithdrawalReasonCode_Equal(String v) { DoSetWithdrawalReasonCode_Equal(fRES(v)); }
        protected void DoSetWithdrawalReasonCode_Equal(String v) { regWithdrawalReasonCode(CK_EQ, v); }
        public void SetWithdrawalReasonCode_NotEqual(String v) { DoSetWithdrawalReasonCode_NotEqual(fRES(v)); }
        protected void DoSetWithdrawalReasonCode_NotEqual(String v) { regWithdrawalReasonCode(CK_NES, v); }
        public void SetWithdrawalReasonCode_InScope(IList<String> ls) { regINS<String>(CK_INS, cTL<String>(ls), getCValueWithdrawalReasonCode(), "WITHDRAWAL_REASON_CODE"); }
        public void SetWithdrawalReasonCode_NotInScope(IList<String> ls) { regINS<String>(CK_NINS, cTL<String>(ls), getCValueWithdrawalReasonCode(), "WITHDRAWAL_REASON_CODE"); }
        public void SetWithdrawalReasonCode_PrefixSearch(String v) { SetWithdrawalReasonCode_LikeSearch(v, cLSOP()); }
        public void SetWithdrawalReasonCode_LikeSearch(String v, LikeSearchOption option)
        { regLSQ(CK_LS, fRES(v), getCValueWithdrawalReasonCode(), "WITHDRAWAL_REASON_CODE", option); }
        public void SetWithdrawalReasonCode_NotLikeSearch(String v, LikeSearchOption option)
        { regLSQ(CK_NLS, fRES(v), getCValueWithdrawalReasonCode(), "WITHDRAWAL_REASON_CODE", option); }
        public void ExistsVdSynonymMemberWithdrawalList(SubQuery<VdSynonymMemberWithdrawalCB> subQuery) {
            assertObjectNotNull("subQuery<VdSynonymMemberWithdrawalCB>", subQuery);
            VdSynonymMemberWithdrawalCB cb = new VdSynonymMemberWithdrawalCB(); cb.xsetupForExistsReferrer(this); subQuery.Invoke(cb);
            String subQueryPropertyName = keepWithdrawalReasonCode_ExistsSubQuery_VdSynonymMemberWithdrawalList(cb.Query());
            registerExistsSubQuery(cb.Query(), "WITHDRAWAL_REASON_CODE", "WITHDRAWAL_REASON_CODE", subQueryPropertyName);
        }
        public abstract String keepWithdrawalReasonCode_ExistsSubQuery_VdSynonymMemberWithdrawalList(VdSynonymMemberWithdrawalCQ subQuery);
        public void ExistsMemberWithdrawalList(SubQuery<MemberWithdrawalCB> subQuery) {
            assertObjectNotNull("subQuery<MemberWithdrawalCB>", subQuery);
            MemberWithdrawalCB cb = new MemberWithdrawalCB(); cb.xsetupForExistsReferrer(this); subQuery.Invoke(cb);
            String subQueryPropertyName = keepWithdrawalReasonCode_ExistsSubQuery_MemberWithdrawalList(cb.Query());
            registerExistsSubQuery(cb.Query(), "WITHDRAWAL_REASON_CODE", "WITHDRAWAL_REASON_CODE", subQueryPropertyName);
        }
        public abstract String keepWithdrawalReasonCode_ExistsSubQuery_MemberWithdrawalList(MemberWithdrawalCQ subQuery);
        public void NotExistsVdSynonymMemberWithdrawalList(SubQuery<VdSynonymMemberWithdrawalCB> subQuery) {
            assertObjectNotNull("subQuery<VdSynonymMemberWithdrawalCB>", subQuery);
            VdSynonymMemberWithdrawalCB cb = new VdSynonymMemberWithdrawalCB(); cb.xsetupForExistsReferrer(this); subQuery.Invoke(cb);
            String subQueryPropertyName = keepWithdrawalReasonCode_NotExistsSubQuery_VdSynonymMemberWithdrawalList(cb.Query());
            registerNotExistsSubQuery(cb.Query(), "WITHDRAWAL_REASON_CODE", "WITHDRAWAL_REASON_CODE", subQueryPropertyName);
        }
        public abstract String keepWithdrawalReasonCode_NotExistsSubQuery_VdSynonymMemberWithdrawalList(VdSynonymMemberWithdrawalCQ subQuery);
        public void NotExistsMemberWithdrawalList(SubQuery<MemberWithdrawalCB> subQuery) {
            assertObjectNotNull("subQuery<MemberWithdrawalCB>", subQuery);
            MemberWithdrawalCB cb = new MemberWithdrawalCB(); cb.xsetupForExistsReferrer(this); subQuery.Invoke(cb);
            String subQueryPropertyName = keepWithdrawalReasonCode_NotExistsSubQuery_MemberWithdrawalList(cb.Query());
            registerNotExistsSubQuery(cb.Query(), "WITHDRAWAL_REASON_CODE", "WITHDRAWAL_REASON_CODE", subQueryPropertyName);
        }
        public abstract String keepWithdrawalReasonCode_NotExistsSubQuery_MemberWithdrawalList(MemberWithdrawalCQ subQuery);
        public void InScopeVdSynonymMemberWithdrawalList(SubQuery<VdSynonymMemberWithdrawalCB> subQuery) {
            assertObjectNotNull("subQuery<VdSynonymMemberWithdrawalCB>", subQuery);
            VdSynonymMemberWithdrawalCB cb = new VdSynonymMemberWithdrawalCB(); cb.xsetupForInScopeRelation(this); subQuery.Invoke(cb);
            String subQueryPropertyName = keepWithdrawalReasonCode_InScopeSubQuery_VdSynonymMemberWithdrawalList(cb.Query());
            registerInScopeSubQuery(cb.Query(), "WITHDRAWAL_REASON_CODE", "WITHDRAWAL_REASON_CODE", subQueryPropertyName);
        }
        public abstract String keepWithdrawalReasonCode_InScopeSubQuery_VdSynonymMemberWithdrawalList(VdSynonymMemberWithdrawalCQ subQuery);
        public void InScopeMemberWithdrawalList(SubQuery<MemberWithdrawalCB> subQuery) {
            assertObjectNotNull("subQuery<MemberWithdrawalCB>", subQuery);
            MemberWithdrawalCB cb = new MemberWithdrawalCB(); cb.xsetupForInScopeRelation(this); subQuery.Invoke(cb);
            String subQueryPropertyName = keepWithdrawalReasonCode_InScopeSubQuery_MemberWithdrawalList(cb.Query());
            registerInScopeSubQuery(cb.Query(), "WITHDRAWAL_REASON_CODE", "WITHDRAWAL_REASON_CODE", subQueryPropertyName);
        }
        public abstract String keepWithdrawalReasonCode_InScopeSubQuery_MemberWithdrawalList(MemberWithdrawalCQ subQuery);
        public void NotInScopeVdSynonymMemberWithdrawalList(SubQuery<VdSynonymMemberWithdrawalCB> subQuery) {
            assertObjectNotNull("subQuery<VdSynonymMemberWithdrawalCB>", subQuery);
            VdSynonymMemberWithdrawalCB cb = new VdSynonymMemberWithdrawalCB(); cb.xsetupForInScopeRelation(this); subQuery.Invoke(cb);
            String subQueryPropertyName = keepWithdrawalReasonCode_NotInScopeSubQuery_VdSynonymMemberWithdrawalList(cb.Query());
            registerNotInScopeSubQuery(cb.Query(), "WITHDRAWAL_REASON_CODE", "WITHDRAWAL_REASON_CODE", subQueryPropertyName);
        }
        public abstract String keepWithdrawalReasonCode_NotInScopeSubQuery_VdSynonymMemberWithdrawalList(VdSynonymMemberWithdrawalCQ subQuery);
        public void NotInScopeMemberWithdrawalList(SubQuery<MemberWithdrawalCB> subQuery) {
            assertObjectNotNull("subQuery<MemberWithdrawalCB>", subQuery);
            MemberWithdrawalCB cb = new MemberWithdrawalCB(); cb.xsetupForInScopeRelation(this); subQuery.Invoke(cb);
            String subQueryPropertyName = keepWithdrawalReasonCode_NotInScopeSubQuery_MemberWithdrawalList(cb.Query());
            registerNotInScopeSubQuery(cb.Query(), "WITHDRAWAL_REASON_CODE", "WITHDRAWAL_REASON_CODE", subQueryPropertyName);
        }
        public abstract String keepWithdrawalReasonCode_NotInScopeSubQuery_MemberWithdrawalList(MemberWithdrawalCQ subQuery);
        public void xsderiveVdSynonymMemberWithdrawalList(String function, SubQuery<VdSynonymMemberWithdrawalCB> subQuery, String aliasName) {
            assertObjectNotNull("subQuery<VdSynonymMemberWithdrawalCB>", subQuery);
            VdSynonymMemberWithdrawalCB cb = new VdSynonymMemberWithdrawalCB(); cb.xsetupForDerivedReferrer(this); subQuery.Invoke(cb);
            String subQueryPropertyName = keepWithdrawalReasonCode_SpecifyDerivedReferrer_VdSynonymMemberWithdrawalList(cb.Query());
            registerSpecifyDerivedReferrer(function, cb.Query(), "WITHDRAWAL_REASON_CODE", "WITHDRAWAL_REASON_CODE", subQueryPropertyName, aliasName);
        }
        abstract public String keepWithdrawalReasonCode_SpecifyDerivedReferrer_VdSynonymMemberWithdrawalList(VdSynonymMemberWithdrawalCQ subQuery);
        public void xsderiveMemberWithdrawalList(String function, SubQuery<MemberWithdrawalCB> subQuery, String aliasName) {
            assertObjectNotNull("subQuery<MemberWithdrawalCB>", subQuery);
            MemberWithdrawalCB cb = new MemberWithdrawalCB(); cb.xsetupForDerivedReferrer(this); subQuery.Invoke(cb);
            String subQueryPropertyName = keepWithdrawalReasonCode_SpecifyDerivedReferrer_MemberWithdrawalList(cb.Query());
            registerSpecifyDerivedReferrer(function, cb.Query(), "WITHDRAWAL_REASON_CODE", "WITHDRAWAL_REASON_CODE", subQueryPropertyName, aliasName);
        }
        abstract public String keepWithdrawalReasonCode_SpecifyDerivedReferrer_MemberWithdrawalList(MemberWithdrawalCQ subQuery);

        public QDRFunction<VdSynonymMemberWithdrawalCB> DerivedVdSynonymMemberWithdrawalList() {
            return xcreateQDRFunctionVdSynonymMemberWithdrawalList();
        }
        protected QDRFunction<VdSynonymMemberWithdrawalCB> xcreateQDRFunctionVdSynonymMemberWithdrawalList() {
            return new QDRFunction<VdSynonymMemberWithdrawalCB>(delegate(String function, SubQuery<VdSynonymMemberWithdrawalCB> subQuery, String operand, Object value) {
                xqderiveVdSynonymMemberWithdrawalList(function, subQuery, operand, value);
            });
        }
        public void xqderiveVdSynonymMemberWithdrawalList(String function, SubQuery<VdSynonymMemberWithdrawalCB> subQuery, String operand, Object value) {
            assertObjectNotNull("subQuery<VdSynonymMemberWithdrawalCB>", subQuery);
            VdSynonymMemberWithdrawalCB cb = new VdSynonymMemberWithdrawalCB(); cb.xsetupForDerivedReferrer(this); subQuery.Invoke(cb);
            String subQueryPropertyName = keepWithdrawalReasonCode_QueryDerivedReferrer_VdSynonymMemberWithdrawalList(cb.Query()); // for saving query-value.
            String parameterPropertyName = keepWithdrawalReasonCode_QueryDerivedReferrer_VdSynonymMemberWithdrawalListParameter(value);
            registerQueryDerivedReferrer(function, cb.Query(), "WITHDRAWAL_REASON_CODE", "WITHDRAWAL_REASON_CODE", subQueryPropertyName, operand, value, parameterPropertyName);
        }
        public abstract String keepWithdrawalReasonCode_QueryDerivedReferrer_VdSynonymMemberWithdrawalList(VdSynonymMemberWithdrawalCQ subQuery);
        public abstract String keepWithdrawalReasonCode_QueryDerivedReferrer_VdSynonymMemberWithdrawalListParameter(Object parameterValue);

        public QDRFunction<MemberWithdrawalCB> DerivedMemberWithdrawalList() {
            return xcreateQDRFunctionMemberWithdrawalList();
        }
        protected QDRFunction<MemberWithdrawalCB> xcreateQDRFunctionMemberWithdrawalList() {
            return new QDRFunction<MemberWithdrawalCB>(delegate(String function, SubQuery<MemberWithdrawalCB> subQuery, String operand, Object value) {
                xqderiveMemberWithdrawalList(function, subQuery, operand, value);
            });
        }
        public void xqderiveMemberWithdrawalList(String function, SubQuery<MemberWithdrawalCB> subQuery, String operand, Object value) {
            assertObjectNotNull("subQuery<MemberWithdrawalCB>", subQuery);
            MemberWithdrawalCB cb = new MemberWithdrawalCB(); cb.xsetupForDerivedReferrer(this); subQuery.Invoke(cb);
            String subQueryPropertyName = keepWithdrawalReasonCode_QueryDerivedReferrer_MemberWithdrawalList(cb.Query()); // for saving query-value.
            String parameterPropertyName = keepWithdrawalReasonCode_QueryDerivedReferrer_MemberWithdrawalListParameter(value);
            registerQueryDerivedReferrer(function, cb.Query(), "WITHDRAWAL_REASON_CODE", "WITHDRAWAL_REASON_CODE", subQueryPropertyName, operand, value, parameterPropertyName);
        }
        public abstract String keepWithdrawalReasonCode_QueryDerivedReferrer_MemberWithdrawalList(MemberWithdrawalCQ subQuery);
        public abstract String keepWithdrawalReasonCode_QueryDerivedReferrer_MemberWithdrawalListParameter(Object parameterValue);
        public void SetWithdrawalReasonCode_IsNull() { regWithdrawalReasonCode(CK_ISN, DUMMY_OBJECT); }
        public void SetWithdrawalReasonCode_IsNotNull() { regWithdrawalReasonCode(CK_ISNN, DUMMY_OBJECT); }
        protected void regWithdrawalReasonCode(ConditionKey k, Object v) { regQ(k, v, getCValueWithdrawalReasonCode(), "WITHDRAWAL_REASON_CODE"); }
        protected abstract ConditionValue getCValueWithdrawalReasonCode();

        public void SetWithdrawalReasonText_Equal(String v) { DoSetWithdrawalReasonText_Equal(fRES(v)); }
        protected void DoSetWithdrawalReasonText_Equal(String v) { regWithdrawalReasonText(CK_EQ, v); }
        public void SetWithdrawalReasonText_NotEqual(String v) { DoSetWithdrawalReasonText_NotEqual(fRES(v)); }
        protected void DoSetWithdrawalReasonText_NotEqual(String v) { regWithdrawalReasonText(CK_NES, v); }
        public void SetWithdrawalReasonText_InScope(IList<String> ls) { regINS<String>(CK_INS, cTL<String>(ls), getCValueWithdrawalReasonText(), "WITHDRAWAL_REASON_TEXT"); }
        public void SetWithdrawalReasonText_NotInScope(IList<String> ls) { regINS<String>(CK_NINS, cTL<String>(ls), getCValueWithdrawalReasonText(), "WITHDRAWAL_REASON_TEXT"); }
        public void SetWithdrawalReasonText_PrefixSearch(String v) { SetWithdrawalReasonText_LikeSearch(v, cLSOP()); }
        public void SetWithdrawalReasonText_LikeSearch(String v, LikeSearchOption option)
        { regLSQ(CK_LS, fRES(v), getCValueWithdrawalReasonText(), "WITHDRAWAL_REASON_TEXT", option); }
        public void SetWithdrawalReasonText_NotLikeSearch(String v, LikeSearchOption option)
        { regLSQ(CK_NLS, fRES(v), getCValueWithdrawalReasonText(), "WITHDRAWAL_REASON_TEXT", option); }
        protected void regWithdrawalReasonText(ConditionKey k, Object v) { regQ(k, v, getCValueWithdrawalReasonText(), "WITHDRAWAL_REASON_TEXT"); }
        protected abstract ConditionValue getCValueWithdrawalReasonText();

        public void SetDisplayOrder_Equal(long? v) { regDisplayOrder(CK_EQ, v); }
        public void SetDisplayOrder_GreaterThan(long? v) { regDisplayOrder(CK_GT, v); }
        public void SetDisplayOrder_LessThan(long? v) { regDisplayOrder(CK_LT, v); }
        public void SetDisplayOrder_GreaterEqual(long? v) { regDisplayOrder(CK_GE, v); }
        public void SetDisplayOrder_LessEqual(long? v) { regDisplayOrder(CK_LE, v); }
        public void SetDisplayOrder_InScope(IList<long?> ls) { regINS<long?>(CK_INS, cTL<long?>(ls), getCValueDisplayOrder(), "DISPLAY_ORDER"); }
        public void SetDisplayOrder_NotInScope(IList<long?> ls) { regINS<long?>(CK_NINS, cTL<long?>(ls), getCValueDisplayOrder(), "DISPLAY_ORDER"); }
        protected void regDisplayOrder(ConditionKey k, Object v) { regQ(k, v, getCValueDisplayOrder(), "DISPLAY_ORDER"); }
        protected abstract ConditionValue getCValueDisplayOrder();

        // ===================================================================================
        //                                                                    Scalar Condition
        //                                                                    ================
        public SSQFunction<WithdrawalReasonCB> Scalar_Equal() {
            return xcreateSSQFunction("=");
        }

        public SSQFunction<WithdrawalReasonCB> Scalar_NotEqual() {
            return xcreateSSQFunction("<>");
        }

        public SSQFunction<WithdrawalReasonCB> Scalar_GreaterEqual() {
            return xcreateSSQFunction(">=");
        }

        public SSQFunction<WithdrawalReasonCB> Scalar_GreaterThan() {
            return xcreateSSQFunction(">");
        }

        public SSQFunction<WithdrawalReasonCB> Scalar_LessEqual() {
            return xcreateSSQFunction("<=");
        }

        public SSQFunction<WithdrawalReasonCB> Scalar_LessThan() {
            return xcreateSSQFunction("<");
        }

        protected SSQFunction<WithdrawalReasonCB> xcreateSSQFunction(String operand) {
            return new SSQFunction<WithdrawalReasonCB>(delegate(String function, SubQuery<WithdrawalReasonCB> subQuery) {
                xscalarSubQuery(function, subQuery, operand);
            });
        }

        protected void xscalarSubQuery(String function, SubQuery<WithdrawalReasonCB> subQuery, String operand) {
            assertObjectNotNull("subQuery<WithdrawalReasonCB>", subQuery);
            WithdrawalReasonCB cb = new WithdrawalReasonCB(); cb.xsetupForScalarCondition(this); subQuery.Invoke(cb);
            String subQueryPropertyName = keepScalarSubQuery(cb.Query()); // for saving query-value.
            registerScalarSubQuery(function, cb.Query(), subQueryPropertyName, operand);
        }
        public abstract String keepScalarSubQuery(WithdrawalReasonCQ subQuery);

        // ===============================================================================
        //                                                                  MySelf InScope
        //                                                                  ==============
        public void MyselfInScope(SubQuery<WithdrawalReasonCB> subQuery) {
            assertObjectNotNull("subQuery<WithdrawalReasonCB>", subQuery);
            WithdrawalReasonCB cb = new WithdrawalReasonCB(); cb.xsetupForInScopeRelation(this); subQuery.Invoke(cb);
            String subQueryPropertyName = keepMyselfInScopeSubQuery(cb.Query()); // for saving query-value.
            registerInScopeSubQuery(cb.Query(), "WITHDRAWAL_REASON_CODE", "WITHDRAWAL_REASON_CODE", subQueryPropertyName);
        }
        public abstract String keepMyselfInScopeSubQuery(WithdrawalReasonCQ subQuery);

        public override String ToString() { return xgetSqlClause().getClause(); }
    }
}
