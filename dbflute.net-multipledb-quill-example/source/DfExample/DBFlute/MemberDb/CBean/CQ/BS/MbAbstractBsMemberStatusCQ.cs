
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
    public abstract class MbAbstractBsMemberStatusCQ : MbAbstractConditionQuery {

        public MbAbstractBsMemberStatusCQ(MbConditionQuery childQuery, MbSqlClause sqlClause, String aliasName, int nestLevel)
            : base(childQuery, sqlClause, aliasName, nestLevel) {}

        public override String getTableDbName() { return "member_status"; }
        public override String getTableSqlName() { return "member_status"; }

        public void SetMemberStatusCode_Equal(String v) { DoSetMemberStatusCode_Equal(fRES(v)); }
        /// <summary>
        /// Set the value of Provisional of memberStatusCode as equal. { = }
        /// 仮会員: 仮会員を示す
        /// </summary>
        public void SetMemberStatusCode_Equal_Provisional() {
            DoSetMemberStatusCode_Equal(MbCDef.MemberStatus.Provisional.Code);
        }
        /// <summary>
        /// Set the value of Formalized of memberStatusCode as equal. { = }
        /// 正式会員: 正式会員を示す
        /// </summary>
        public void SetMemberStatusCode_Equal_Formalized() {
            DoSetMemberStatusCode_Equal(MbCDef.MemberStatus.Formalized.Code);
        }
        /// <summary>
        /// Set the value of Withdrawal of memberStatusCode as equal. { = }
        /// 退会会員: 退会会員を示す
        /// </summary>
        public void SetMemberStatusCode_Equal_Withdrawal() {
            DoSetMemberStatusCode_Equal(MbCDef.MemberStatus.Withdrawal.Code);
        }
        protected void DoSetMemberStatusCode_Equal(String v) { regMemberStatusCode(CK_EQ, v); }
        public void SetMemberStatusCode_NotEqual(String v) { DoSetMemberStatusCode_NotEqual(fRES(v)); }
        /// <summary>
        /// Set the value of Provisional of memberStatusCode as notEqual. { &lt;&gt; }
        /// 仮会員: 仮会員を示す
        /// </summary>
        public void SetMemberStatusCode_NotEqual_Provisional() {
            DoSetMemberStatusCode_NotEqual(MbCDef.MemberStatus.Provisional.Code);
        }
        /// <summary>
        /// Set the value of Formalized of memberStatusCode as notEqual. { &lt;&gt; }
        /// 正式会員: 正式会員を示す
        /// </summary>
        public void SetMemberStatusCode_NotEqual_Formalized() {
            DoSetMemberStatusCode_NotEqual(MbCDef.MemberStatus.Formalized.Code);
        }
        /// <summary>
        /// Set the value of Withdrawal of memberStatusCode as notEqual. { &lt;&gt; }
        /// 退会会員: 退会会員を示す
        /// </summary>
        public void SetMemberStatusCode_NotEqual_Withdrawal() {
            DoSetMemberStatusCode_NotEqual(MbCDef.MemberStatus.Withdrawal.Code);
        }
        protected void DoSetMemberStatusCode_NotEqual(String v) { regMemberStatusCode(CK_NES, v); }
        public void SetMemberStatusCode_InScope(IList<String> ls) { regINS<String>(CK_INS, cTL<String>(ls), getCValueMemberStatusCode(), "MEMBER_STATUS_CODE"); }
        public void SetMemberStatusCode_NotInScope(IList<String> ls) { regINS<String>(CK_NINS, cTL<String>(ls), getCValueMemberStatusCode(), "MEMBER_STATUS_CODE"); }
        public void ExistsMemberList(MbSubQuery<MbMemberCB> subQuery) {
            assertObjectNotNull("subQuery<MbMemberCB>", subQuery);
            MbMemberCB cb = new MbMemberCB(); cb.xsetupForExistsReferrer(this); subQuery.Invoke(cb);
            String subQueryPropertyName = keepMemberStatusCode_ExistsSubQuery_MemberList(cb.Query());
            registerExistsSubQuery(cb.Query(), "MEMBER_STATUS_CODE", "MEMBER_STATUS_CODE", subQueryPropertyName);
        }
        public abstract String keepMemberStatusCode_ExistsSubQuery_MemberList(MbMemberCQ subQuery);
        public void ExistsMemberLoginList(MbSubQuery<MbMemberLoginCB> subQuery) {
            assertObjectNotNull("subQuery<MbMemberLoginCB>", subQuery);
            MbMemberLoginCB cb = new MbMemberLoginCB(); cb.xsetupForExistsReferrer(this); subQuery.Invoke(cb);
            String subQueryPropertyName = keepMemberStatusCode_ExistsSubQuery_MemberLoginList(cb.Query());
            registerExistsSubQuery(cb.Query(), "MEMBER_STATUS_CODE", "LOGIN_MEMBER_STATUS_CODE", subQueryPropertyName);
        }
        public abstract String keepMemberStatusCode_ExistsSubQuery_MemberLoginList(MbMemberLoginCQ subQuery);
        public void NotExistsMemberList(MbSubQuery<MbMemberCB> subQuery) {
            assertObjectNotNull("subQuery<MbMemberCB>", subQuery);
            MbMemberCB cb = new MbMemberCB(); cb.xsetupForExistsReferrer(this); subQuery.Invoke(cb);
            String subQueryPropertyName = keepMemberStatusCode_NotExistsSubQuery_MemberList(cb.Query());
            registerNotExistsSubQuery(cb.Query(), "MEMBER_STATUS_CODE", "MEMBER_STATUS_CODE", subQueryPropertyName);
        }
        public abstract String keepMemberStatusCode_NotExistsSubQuery_MemberList(MbMemberCQ subQuery);
        public void NotExistsMemberLoginList(MbSubQuery<MbMemberLoginCB> subQuery) {
            assertObjectNotNull("subQuery<MbMemberLoginCB>", subQuery);
            MbMemberLoginCB cb = new MbMemberLoginCB(); cb.xsetupForExistsReferrer(this); subQuery.Invoke(cb);
            String subQueryPropertyName = keepMemberStatusCode_NotExistsSubQuery_MemberLoginList(cb.Query());
            registerNotExistsSubQuery(cb.Query(), "MEMBER_STATUS_CODE", "LOGIN_MEMBER_STATUS_CODE", subQueryPropertyName);
        }
        public abstract String keepMemberStatusCode_NotExistsSubQuery_MemberLoginList(MbMemberLoginCQ subQuery);
        public void InScopeMemberList(MbSubQuery<MbMemberCB> subQuery) {
            assertObjectNotNull("subQuery<MbMemberCB>", subQuery);
            MbMemberCB cb = new MbMemberCB(); cb.xsetupForInScopeRelation(this); subQuery.Invoke(cb);
            String subQueryPropertyName = keepMemberStatusCode_InScopeSubQuery_MemberList(cb.Query());
            registerInScopeSubQuery(cb.Query(), "MEMBER_STATUS_CODE", "MEMBER_STATUS_CODE", subQueryPropertyName);
        }
        public abstract String keepMemberStatusCode_InScopeSubQuery_MemberList(MbMemberCQ subQuery);
        public void InScopeMemberLoginList(MbSubQuery<MbMemberLoginCB> subQuery) {
            assertObjectNotNull("subQuery<MbMemberLoginCB>", subQuery);
            MbMemberLoginCB cb = new MbMemberLoginCB(); cb.xsetupForInScopeRelation(this); subQuery.Invoke(cb);
            String subQueryPropertyName = keepMemberStatusCode_InScopeSubQuery_MemberLoginList(cb.Query());
            registerInScopeSubQuery(cb.Query(), "MEMBER_STATUS_CODE", "LOGIN_MEMBER_STATUS_CODE", subQueryPropertyName);
        }
        public abstract String keepMemberStatusCode_InScopeSubQuery_MemberLoginList(MbMemberLoginCQ subQuery);
        public void NotInScopeMemberList(MbSubQuery<MbMemberCB> subQuery) {
            assertObjectNotNull("subQuery<MbMemberCB>", subQuery);
            MbMemberCB cb = new MbMemberCB(); cb.xsetupForInScopeRelation(this); subQuery.Invoke(cb);
            String subQueryPropertyName = keepMemberStatusCode_NotInScopeSubQuery_MemberList(cb.Query());
            registerNotInScopeSubQuery(cb.Query(), "MEMBER_STATUS_CODE", "MEMBER_STATUS_CODE", subQueryPropertyName);
        }
        public abstract String keepMemberStatusCode_NotInScopeSubQuery_MemberList(MbMemberCQ subQuery);
        public void NotInScopeMemberLoginList(MbSubQuery<MbMemberLoginCB> subQuery) {
            assertObjectNotNull("subQuery<MbMemberLoginCB>", subQuery);
            MbMemberLoginCB cb = new MbMemberLoginCB(); cb.xsetupForInScopeRelation(this); subQuery.Invoke(cb);
            String subQueryPropertyName = keepMemberStatusCode_NotInScopeSubQuery_MemberLoginList(cb.Query());
            registerNotInScopeSubQuery(cb.Query(), "MEMBER_STATUS_CODE", "LOGIN_MEMBER_STATUS_CODE", subQueryPropertyName);
        }
        public abstract String keepMemberStatusCode_NotInScopeSubQuery_MemberLoginList(MbMemberLoginCQ subQuery);
        public void xsderiveMemberList(String function, MbSubQuery<MbMemberCB> subQuery, String aliasName) {
            assertObjectNotNull("subQuery<MbMemberCB>", subQuery);
            MbMemberCB cb = new MbMemberCB(); cb.xsetupForDerivedReferrer(this); subQuery.Invoke(cb);
            String subQueryPropertyName = keepMemberStatusCode_SpecifyDerivedReferrer_MemberList(cb.Query());
            registerSpecifyDerivedReferrer(function, cb.Query(), "MEMBER_STATUS_CODE", "MEMBER_STATUS_CODE", subQueryPropertyName, aliasName);
        }
        abstract public String keepMemberStatusCode_SpecifyDerivedReferrer_MemberList(MbMemberCQ subQuery);
        public void xsderiveMemberLoginList(String function, MbSubQuery<MbMemberLoginCB> subQuery, String aliasName) {
            assertObjectNotNull("subQuery<MbMemberLoginCB>", subQuery);
            MbMemberLoginCB cb = new MbMemberLoginCB(); cb.xsetupForDerivedReferrer(this); subQuery.Invoke(cb);
            String subQueryPropertyName = keepMemberStatusCode_SpecifyDerivedReferrer_MemberLoginList(cb.Query());
            registerSpecifyDerivedReferrer(function, cb.Query(), "MEMBER_STATUS_CODE", "LOGIN_MEMBER_STATUS_CODE", subQueryPropertyName, aliasName);
        }
        abstract public String keepMemberStatusCode_SpecifyDerivedReferrer_MemberLoginList(MbMemberLoginCQ subQuery);

        public QDRFunction<MbMemberCB> DerivedMemberList() {
            return xcreateQDRFunctionMemberList();
        }
        protected QDRFunction<MbMemberCB> xcreateQDRFunctionMemberList() {
            return new QDRFunction<MbMemberCB>(delegate(String function, MbSubQuery<MbMemberCB> subQuery, String operand, Object value) {
                xqderiveMemberList(function, subQuery, operand, value);
            });
        }
        public void xqderiveMemberList(String function, MbSubQuery<MbMemberCB> subQuery, String operand, Object value) {
            assertObjectNotNull("subQuery<MbMemberCB>", subQuery);
            MbMemberCB cb = new MbMemberCB(); cb.xsetupForDerivedReferrer(this); subQuery.Invoke(cb);
            String subQueryPropertyName = keepMemberStatusCode_QueryDerivedReferrer_MemberList(cb.Query()); // for saving query-value.
            String parameterPropertyName = keepMemberStatusCode_QueryDerivedReferrer_MemberListParameter(value);
            registerQueryDerivedReferrer(function, cb.Query(), "MEMBER_STATUS_CODE", "MEMBER_STATUS_CODE", subQueryPropertyName, operand, value, parameterPropertyName);
        }
        public abstract String keepMemberStatusCode_QueryDerivedReferrer_MemberList(MbMemberCQ subQuery);
        public abstract String keepMemberStatusCode_QueryDerivedReferrer_MemberListParameter(Object parameterValue);

        public QDRFunction<MbMemberLoginCB> DerivedMemberLoginList() {
            return xcreateQDRFunctionMemberLoginList();
        }
        protected QDRFunction<MbMemberLoginCB> xcreateQDRFunctionMemberLoginList() {
            return new QDRFunction<MbMemberLoginCB>(delegate(String function, MbSubQuery<MbMemberLoginCB> subQuery, String operand, Object value) {
                xqderiveMemberLoginList(function, subQuery, operand, value);
            });
        }
        public void xqderiveMemberLoginList(String function, MbSubQuery<MbMemberLoginCB> subQuery, String operand, Object value) {
            assertObjectNotNull("subQuery<MbMemberLoginCB>", subQuery);
            MbMemberLoginCB cb = new MbMemberLoginCB(); cb.xsetupForDerivedReferrer(this); subQuery.Invoke(cb);
            String subQueryPropertyName = keepMemberStatusCode_QueryDerivedReferrer_MemberLoginList(cb.Query()); // for saving query-value.
            String parameterPropertyName = keepMemberStatusCode_QueryDerivedReferrer_MemberLoginListParameter(value);
            registerQueryDerivedReferrer(function, cb.Query(), "MEMBER_STATUS_CODE", "LOGIN_MEMBER_STATUS_CODE", subQueryPropertyName, operand, value, parameterPropertyName);
        }
        public abstract String keepMemberStatusCode_QueryDerivedReferrer_MemberLoginList(MbMemberLoginCQ subQuery);
        public abstract String keepMemberStatusCode_QueryDerivedReferrer_MemberLoginListParameter(Object parameterValue);
        public void SetMemberStatusCode_IsNull() { regMemberStatusCode(CK_ISN, DUMMY_OBJECT); }
        public void SetMemberStatusCode_IsNotNull() { regMemberStatusCode(CK_ISNN, DUMMY_OBJECT); }
        protected void regMemberStatusCode(MbConditionKey k, Object v) { regQ(k, v, getCValueMemberStatusCode(), "MEMBER_STATUS_CODE"); }
        protected abstract MbConditionValue getCValueMemberStatusCode();

        public void SetMemberStatusName_Equal(String v) { DoSetMemberStatusName_Equal(fRES(v)); }
        protected void DoSetMemberStatusName_Equal(String v) { regMemberStatusName(CK_EQ, v); }
        public void SetMemberStatusName_NotEqual(String v) { DoSetMemberStatusName_NotEqual(fRES(v)); }
        protected void DoSetMemberStatusName_NotEqual(String v) { regMemberStatusName(CK_NES, v); }
        public void SetMemberStatusName_InScope(IList<String> ls) { regINS<String>(CK_INS, cTL<String>(ls), getCValueMemberStatusName(), "MEMBER_STATUS_NAME"); }
        public void SetMemberStatusName_NotInScope(IList<String> ls) { regINS<String>(CK_NINS, cTL<String>(ls), getCValueMemberStatusName(), "MEMBER_STATUS_NAME"); }
        public void SetMemberStatusName_PrefixSearch(String v) { SetMemberStatusName_LikeSearch(v, cLSOP()); }
        public void SetMemberStatusName_LikeSearch(String v, MbLikeSearchOption option)
        { regLSQ(CK_LS, fRES(v), getCValueMemberStatusName(), "MEMBER_STATUS_NAME", option); }
        public void SetMemberStatusName_NotLikeSearch(String v, MbLikeSearchOption option)
        { regLSQ(CK_NLS, fRES(v), getCValueMemberStatusName(), "MEMBER_STATUS_NAME", option); }
        protected void regMemberStatusName(MbConditionKey k, Object v) { regQ(k, v, getCValueMemberStatusName(), "MEMBER_STATUS_NAME"); }
        protected abstract MbConditionValue getCValueMemberStatusName();

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
        public SSQFunction<MbMemberStatusCB> Scalar_Equal() {
            return xcreateSSQFunction("=");
        }

        public SSQFunction<MbMemberStatusCB> Scalar_NotEqual() {
            return xcreateSSQFunction("<>");
        }

        public SSQFunction<MbMemberStatusCB> Scalar_GreaterEqual() {
            return xcreateSSQFunction(">=");
        }

        public SSQFunction<MbMemberStatusCB> Scalar_GreaterThan() {
            return xcreateSSQFunction(">");
        }

        public SSQFunction<MbMemberStatusCB> Scalar_LessEqual() {
            return xcreateSSQFunction("<=");
        }

        public SSQFunction<MbMemberStatusCB> Scalar_LessThan() {
            return xcreateSSQFunction("<");
        }

        protected SSQFunction<MbMemberStatusCB> xcreateSSQFunction(String operand) {
            return new SSQFunction<MbMemberStatusCB>(delegate(String function, MbSubQuery<MbMemberStatusCB> subQuery) {
                xscalarSubQuery(function, subQuery, operand);
            });
        }

        protected void xscalarSubQuery(String function, MbSubQuery<MbMemberStatusCB> subQuery, String operand) {
            assertObjectNotNull("subQuery<MbMemberStatusCB>", subQuery);
            MbMemberStatusCB cb = new MbMemberStatusCB(); cb.xsetupForScalarCondition(this); subQuery.Invoke(cb);
            String subQueryPropertyName = keepScalarSubQuery(cb.Query()); // for saving query-value.
            registerScalarSubQuery(function, cb.Query(), subQueryPropertyName, operand);
        }
        public abstract String keepScalarSubQuery(MbMemberStatusCQ subQuery);

        // ===============================================================================
        //                                                                  MySelf InScope
        //                                                                  ==============
        public void MyselfInScope(MbSubQuery<MbMemberStatusCB> subQuery) {
            assertObjectNotNull("subQuery<MbMemberStatusCB>", subQuery);
            MbMemberStatusCB cb = new MbMemberStatusCB(); cb.xsetupForInScopeRelation(this); subQuery.Invoke(cb);
            String subQueryPropertyName = keepMyselfInScopeSubQuery(cb.Query()); // for saving query-value.
            registerInScopeSubQuery(cb.Query(), "MEMBER_STATUS_CODE", "MEMBER_STATUS_CODE", subQueryPropertyName);
        }
        public abstract String keepMyselfInScopeSubQuery(MbMemberStatusCQ subQuery);

        public override String ToString() { return xgetSqlClause().getClause(); }
    }
}
