
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
    public abstract class MbAbstractBsWithdrawalReasonCQ : MbAbstractConditionQuery {

        public MbAbstractBsWithdrawalReasonCQ(MbConditionQuery childQuery, MbSqlClause sqlClause, String aliasName, int nestLevel)
            : base(childQuery, sqlClause, aliasName, nestLevel) {}

        public override String getTableDbName() { return "withdrawal_reason"; }
        public override String getTableSqlName() { return "withdrawal_reason"; }

        public void SetWithdrawalReasonCode_Equal(String v) { DoSetWithdrawalReasonCode_Equal(fRES(v)); }
        protected void DoSetWithdrawalReasonCode_Equal(String v) { regWithdrawalReasonCode(CK_EQ, v); }
        public void SetWithdrawalReasonCode_NotEqual(String v) { DoSetWithdrawalReasonCode_NotEqual(fRES(v)); }
        protected void DoSetWithdrawalReasonCode_NotEqual(String v) { regWithdrawalReasonCode(CK_NES, v); }
        public void SetWithdrawalReasonCode_InScope(IList<String> ls) { regINS<String>(CK_INS, cTL<String>(ls), getCValueWithdrawalReasonCode(), "WITHDRAWAL_REASON_CODE"); }
        public void SetWithdrawalReasonCode_NotInScope(IList<String> ls) { regINS<String>(CK_NINS, cTL<String>(ls), getCValueWithdrawalReasonCode(), "WITHDRAWAL_REASON_CODE"); }
        public void SetWithdrawalReasonCode_PrefixSearch(String v) { SetWithdrawalReasonCode_LikeSearch(v, cLSOP()); }
        public void SetWithdrawalReasonCode_LikeSearch(String v, MbLikeSearchOption option)
        { regLSQ(CK_LS, fRES(v), getCValueWithdrawalReasonCode(), "WITHDRAWAL_REASON_CODE", option); }
        public void SetWithdrawalReasonCode_NotLikeSearch(String v, MbLikeSearchOption option)
        { regLSQ(CK_NLS, fRES(v), getCValueWithdrawalReasonCode(), "WITHDRAWAL_REASON_CODE", option); }
        public void ExistsMemberWithdrawalList(MbSubQuery<MbMemberWithdrawalCB> subQuery) {
            assertObjectNotNull("subQuery<MbMemberWithdrawalCB>", subQuery);
            MbMemberWithdrawalCB cb = new MbMemberWithdrawalCB(); cb.xsetupForExistsReferrer(this); subQuery.Invoke(cb);
            String subQueryPropertyName = keepWithdrawalReasonCode_ExistsSubQuery_MemberWithdrawalList(cb.Query());
            registerExistsSubQuery(cb.Query(), "WITHDRAWAL_REASON_CODE", "WITHDRAWAL_REASON_CODE", subQueryPropertyName);
        }
        public abstract String keepWithdrawalReasonCode_ExistsSubQuery_MemberWithdrawalList(MbMemberWithdrawalCQ subQuery);
        public void NotExistsMemberWithdrawalList(MbSubQuery<MbMemberWithdrawalCB> subQuery) {
            assertObjectNotNull("subQuery<MbMemberWithdrawalCB>", subQuery);
            MbMemberWithdrawalCB cb = new MbMemberWithdrawalCB(); cb.xsetupForExistsReferrer(this); subQuery.Invoke(cb);
            String subQueryPropertyName = keepWithdrawalReasonCode_NotExistsSubQuery_MemberWithdrawalList(cb.Query());
            registerNotExistsSubQuery(cb.Query(), "WITHDRAWAL_REASON_CODE", "WITHDRAWAL_REASON_CODE", subQueryPropertyName);
        }
        public abstract String keepWithdrawalReasonCode_NotExistsSubQuery_MemberWithdrawalList(MbMemberWithdrawalCQ subQuery);
        public void InScopeMemberWithdrawalList(MbSubQuery<MbMemberWithdrawalCB> subQuery) {
            assertObjectNotNull("subQuery<MbMemberWithdrawalCB>", subQuery);
            MbMemberWithdrawalCB cb = new MbMemberWithdrawalCB(); cb.xsetupForInScopeRelation(this); subQuery.Invoke(cb);
            String subQueryPropertyName = keepWithdrawalReasonCode_InScopeSubQuery_MemberWithdrawalList(cb.Query());
            registerInScopeSubQuery(cb.Query(), "WITHDRAWAL_REASON_CODE", "WITHDRAWAL_REASON_CODE", subQueryPropertyName);
        }
        public abstract String keepWithdrawalReasonCode_InScopeSubQuery_MemberWithdrawalList(MbMemberWithdrawalCQ subQuery);
        public void NotInScopeMemberWithdrawalList(MbSubQuery<MbMemberWithdrawalCB> subQuery) {
            assertObjectNotNull("subQuery<MbMemberWithdrawalCB>", subQuery);
            MbMemberWithdrawalCB cb = new MbMemberWithdrawalCB(); cb.xsetupForInScopeRelation(this); subQuery.Invoke(cb);
            String subQueryPropertyName = keepWithdrawalReasonCode_NotInScopeSubQuery_MemberWithdrawalList(cb.Query());
            registerNotInScopeSubQuery(cb.Query(), "WITHDRAWAL_REASON_CODE", "WITHDRAWAL_REASON_CODE", subQueryPropertyName);
        }
        public abstract String keepWithdrawalReasonCode_NotInScopeSubQuery_MemberWithdrawalList(MbMemberWithdrawalCQ subQuery);
        public void xsderiveMemberWithdrawalList(String function, MbSubQuery<MbMemberWithdrawalCB> subQuery, String aliasName) {
            assertObjectNotNull("subQuery<MbMemberWithdrawalCB>", subQuery);
            MbMemberWithdrawalCB cb = new MbMemberWithdrawalCB(); cb.xsetupForDerivedReferrer(this); subQuery.Invoke(cb);
            String subQueryPropertyName = keepWithdrawalReasonCode_SpecifyDerivedReferrer_MemberWithdrawalList(cb.Query());
            registerSpecifyDerivedReferrer(function, cb.Query(), "WITHDRAWAL_REASON_CODE", "WITHDRAWAL_REASON_CODE", subQueryPropertyName, aliasName);
        }
        abstract public String keepWithdrawalReasonCode_SpecifyDerivedReferrer_MemberWithdrawalList(MbMemberWithdrawalCQ subQuery);

        public QDRFunction<MbMemberWithdrawalCB> DerivedMemberWithdrawalList() {
            return xcreateQDRFunctionMemberWithdrawalList();
        }
        protected QDRFunction<MbMemberWithdrawalCB> xcreateQDRFunctionMemberWithdrawalList() {
            return new QDRFunction<MbMemberWithdrawalCB>(delegate(String function, MbSubQuery<MbMemberWithdrawalCB> subQuery, String operand, Object value) {
                xqderiveMemberWithdrawalList(function, subQuery, operand, value);
            });
        }
        public void xqderiveMemberWithdrawalList(String function, MbSubQuery<MbMemberWithdrawalCB> subQuery, String operand, Object value) {
            assertObjectNotNull("subQuery<MbMemberWithdrawalCB>", subQuery);
            MbMemberWithdrawalCB cb = new MbMemberWithdrawalCB(); cb.xsetupForDerivedReferrer(this); subQuery.Invoke(cb);
            String subQueryPropertyName = keepWithdrawalReasonCode_QueryDerivedReferrer_MemberWithdrawalList(cb.Query()); // for saving query-value.
            String parameterPropertyName = keepWithdrawalReasonCode_QueryDerivedReferrer_MemberWithdrawalListParameter(value);
            registerQueryDerivedReferrer(function, cb.Query(), "WITHDRAWAL_REASON_CODE", "WITHDRAWAL_REASON_CODE", subQueryPropertyName, operand, value, parameterPropertyName);
        }
        public abstract String keepWithdrawalReasonCode_QueryDerivedReferrer_MemberWithdrawalList(MbMemberWithdrawalCQ subQuery);
        public abstract String keepWithdrawalReasonCode_QueryDerivedReferrer_MemberWithdrawalListParameter(Object parameterValue);
        public void SetWithdrawalReasonCode_IsNull() { regWithdrawalReasonCode(CK_ISN, DUMMY_OBJECT); }
        public void SetWithdrawalReasonCode_IsNotNull() { regWithdrawalReasonCode(CK_ISNN, DUMMY_OBJECT); }
        protected void regWithdrawalReasonCode(MbConditionKey k, Object v) { regQ(k, v, getCValueWithdrawalReasonCode(), "WITHDRAWAL_REASON_CODE"); }
        protected abstract MbConditionValue getCValueWithdrawalReasonCode();

        public void SetWithdrawalReasonText_Equal(String v) { DoSetWithdrawalReasonText_Equal(fRES(v)); }
        protected void DoSetWithdrawalReasonText_Equal(String v) { regWithdrawalReasonText(CK_EQ, v); }
        public void SetWithdrawalReasonText_NotEqual(String v) { DoSetWithdrawalReasonText_NotEqual(fRES(v)); }
        protected void DoSetWithdrawalReasonText_NotEqual(String v) { regWithdrawalReasonText(CK_NES, v); }
        public void SetWithdrawalReasonText_InScope(IList<String> ls) { regINS<String>(CK_INS, cTL<String>(ls), getCValueWithdrawalReasonText(), "WITHDRAWAL_REASON_TEXT"); }
        public void SetWithdrawalReasonText_NotInScope(IList<String> ls) { regINS<String>(CK_NINS, cTL<String>(ls), getCValueWithdrawalReasonText(), "WITHDRAWAL_REASON_TEXT"); }
        public void SetWithdrawalReasonText_PrefixSearch(String v) { SetWithdrawalReasonText_LikeSearch(v, cLSOP()); }
        public void SetWithdrawalReasonText_LikeSearch(String v, MbLikeSearchOption option)
        { regLSQ(CK_LS, fRES(v), getCValueWithdrawalReasonText(), "WITHDRAWAL_REASON_TEXT", option); }
        public void SetWithdrawalReasonText_NotLikeSearch(String v, MbLikeSearchOption option)
        { regLSQ(CK_NLS, fRES(v), getCValueWithdrawalReasonText(), "WITHDRAWAL_REASON_TEXT", option); }
        protected void regWithdrawalReasonText(MbConditionKey k, Object v) { regQ(k, v, getCValueWithdrawalReasonText(), "WITHDRAWAL_REASON_TEXT"); }
        protected abstract MbConditionValue getCValueWithdrawalReasonText();

        public void SetDisplayOrder_Equal(int? v) { regDisplayOrder(CK_EQ, v); }
        public void SetDisplayOrder_GreaterThan(int? v) { regDisplayOrder(CK_GT, v); }
        public void SetDisplayOrder_LessThan(int? v) { regDisplayOrder(CK_LT, v); }
        public void SetDisplayOrder_GreaterEqual(int? v) { regDisplayOrder(CK_GE, v); }
        public void SetDisplayOrder_LessEqual(int? v) { regDisplayOrder(CK_LE, v); }
        public void SetDisplayOrder_InScope(IList<int?> ls) { regINS<int?>(CK_INS, cTL<int?>(ls), getCValueDisplayOrder(), "DISPLAY_ORDER"); }
        public void SetDisplayOrder_NotInScope(IList<int?> ls) { regINS<int?>(CK_NINS, cTL<int?>(ls), getCValueDisplayOrder(), "DISPLAY_ORDER"); }
        protected void regDisplayOrder(MbConditionKey k, Object v) { regQ(k, v, getCValueDisplayOrder(), "DISPLAY_ORDER"); }
        protected abstract MbConditionValue getCValueDisplayOrder();

        // ===================================================================================
        //                                                                    Scalar Condition
        //                                                                    ================
        public SSQFunction<MbWithdrawalReasonCB> Scalar_Equal() {
            return xcreateSSQFunction("=");
        }

        public SSQFunction<MbWithdrawalReasonCB> Scalar_NotEqual() {
            return xcreateSSQFunction("<>");
        }

        public SSQFunction<MbWithdrawalReasonCB> Scalar_GreaterEqual() {
            return xcreateSSQFunction(">=");
        }

        public SSQFunction<MbWithdrawalReasonCB> Scalar_GreaterThan() {
            return xcreateSSQFunction(">");
        }

        public SSQFunction<MbWithdrawalReasonCB> Scalar_LessEqual() {
            return xcreateSSQFunction("<=");
        }

        public SSQFunction<MbWithdrawalReasonCB> Scalar_LessThan() {
            return xcreateSSQFunction("<");
        }

        protected SSQFunction<MbWithdrawalReasonCB> xcreateSSQFunction(String operand) {
            return new SSQFunction<MbWithdrawalReasonCB>(delegate(String function, MbSubQuery<MbWithdrawalReasonCB> subQuery) {
                xscalarSubQuery(function, subQuery, operand);
            });
        }

        protected void xscalarSubQuery(String function, MbSubQuery<MbWithdrawalReasonCB> subQuery, String operand) {
            assertObjectNotNull("subQuery<MbWithdrawalReasonCB>", subQuery);
            MbWithdrawalReasonCB cb = new MbWithdrawalReasonCB(); cb.xsetupForScalarCondition(this); subQuery.Invoke(cb);
            String subQueryPropertyName = keepScalarSubQuery(cb.Query()); // for saving query-value.
            registerScalarSubQuery(function, cb.Query(), subQueryPropertyName, operand);
        }
        public abstract String keepScalarSubQuery(MbWithdrawalReasonCQ subQuery);

        // ===============================================================================
        //                                                                  MySelf InScope
        //                                                                  ==============
        public void MyselfInScope(MbSubQuery<MbWithdrawalReasonCB> subQuery) {
            assertObjectNotNull("subQuery<MbWithdrawalReasonCB>", subQuery);
            MbWithdrawalReasonCB cb = new MbWithdrawalReasonCB(); cb.xsetupForInScopeRelation(this); subQuery.Invoke(cb);
            String subQueryPropertyName = keepMyselfInScopeSubQuery(cb.Query()); // for saving query-value.
            registerInScopeSubQuery(cb.Query(), "WITHDRAWAL_REASON_CODE", "WITHDRAWAL_REASON_CODE", subQueryPropertyName);
        }
        public abstract String keepMyselfInScopeSubQuery(MbWithdrawalReasonCQ subQuery);

        public override String ToString() { return xgetSqlClause().getClause(); }
    }
}
