
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
    public abstract class AbstractBsMemberLoginCQ : AbstractConditionQuery {

        public AbstractBsMemberLoginCQ(ConditionQuery childQuery, SqlClause sqlClause, String aliasName, int nestLevel)
            : base(childQuery, sqlClause, aliasName, nestLevel) {}

        public override String getTableDbName() { return "MEMBER_LOGIN"; }
        public override String getTableSqlName() { return "MEMBER_LOGIN"; }

        public void SetMemberLoginId_Equal(long? v) { regMemberLoginId(CK_EQ, v); }
        public void SetMemberLoginId_GreaterThan(long? v) { regMemberLoginId(CK_GT, v); }
        public void SetMemberLoginId_LessThan(long? v) { regMemberLoginId(CK_LT, v); }
        public void SetMemberLoginId_GreaterEqual(long? v) { regMemberLoginId(CK_GE, v); }
        public void SetMemberLoginId_LessEqual(long? v) { regMemberLoginId(CK_LE, v); }
        public void SetMemberLoginId_InScope(IList<long?> ls) { regINS<long?>(CK_INS, cTL<long?>(ls), getCValueMemberLoginId(), "MEMBER_LOGIN_ID"); }
        public void SetMemberLoginId_NotInScope(IList<long?> ls) { regINS<long?>(CK_NINS, cTL<long?>(ls), getCValueMemberLoginId(), "MEMBER_LOGIN_ID"); }
        public void SetMemberLoginId_IsNull() { regMemberLoginId(CK_ISN, DUMMY_OBJECT); }
        public void SetMemberLoginId_IsNotNull() { regMemberLoginId(CK_ISNN, DUMMY_OBJECT); }
        protected void regMemberLoginId(ConditionKey k, Object v) { regQ(k, v, getCValueMemberLoginId(), "MEMBER_LOGIN_ID"); }
        protected abstract ConditionValue getCValueMemberLoginId();

        public void SetMemberId_Equal(long? v) { regMemberId(CK_EQ, v); }
        public void SetMemberId_GreaterThan(long? v) { regMemberId(CK_GT, v); }
        public void SetMemberId_LessThan(long? v) { regMemberId(CK_LT, v); }
        public void SetMemberId_GreaterEqual(long? v) { regMemberId(CK_GE, v); }
        public void SetMemberId_LessEqual(long? v) { regMemberId(CK_LE, v); }
        public void SetMemberId_InScope(IList<long?> ls) { regINS<long?>(CK_INS, cTL<long?>(ls), getCValueMemberId(), "MEMBER_ID"); }
        public void SetMemberId_NotInScope(IList<long?> ls) { regINS<long?>(CK_NINS, cTL<long?>(ls), getCValueMemberId(), "MEMBER_ID"); }
        public void InScopeMember(SubQuery<MemberCB> subQuery) {
            assertObjectNotNull("subQuery<MemberCB>", subQuery);
            MemberCB cb = new MemberCB(); cb.xsetupForInScopeRelation(this); subQuery.Invoke(cb);
            String subQueryPropertyName = keepMemberId_InScopeSubQuery_Member(cb.Query());
            registerInScopeSubQuery(cb.Query(), "MEMBER_ID", "MEMBER_ID", subQueryPropertyName);
        }
        public abstract String keepMemberId_InScopeSubQuery_Member(MemberCQ subQuery);
        public void NotInScopeMember(SubQuery<MemberCB> subQuery) {
            assertObjectNotNull("subQuery<MemberCB>", subQuery);
            MemberCB cb = new MemberCB(); cb.xsetupForInScopeRelation(this); subQuery.Invoke(cb);
            String subQueryPropertyName = keepMemberId_NotInScopeSubQuery_Member(cb.Query());
            registerNotInScopeSubQuery(cb.Query(), "MEMBER_ID", "MEMBER_ID", subQueryPropertyName);
        }
        public abstract String keepMemberId_NotInScopeSubQuery_Member(MemberCQ subQuery);
        protected void regMemberId(ConditionKey k, Object v) { regQ(k, v, getCValueMemberId(), "MEMBER_ID"); }
        protected abstract ConditionValue getCValueMemberId();

        public void SetLoginDatetime_Equal(DateTime? v) { regLoginDatetime(CK_EQ, v); }
        public void SetLoginDatetime_GreaterThan(DateTime? v) { regLoginDatetime(CK_GT, v); }
        public void SetLoginDatetime_LessThan(DateTime? v) { regLoginDatetime(CK_LT, v); }
        public void SetLoginDatetime_GreaterEqual(DateTime? v) { regLoginDatetime(CK_GE, v); }
        public void SetLoginDatetime_LessEqual(DateTime? v) { regLoginDatetime(CK_LE, v); }
        public void SetLoginDatetime_FromTo(DateTime? from, DateTime? to, FromToOption option)
        { regFTQ(from, to, getCValueLoginDatetime(), "LOGIN_DATETIME", option); }
        public void SetLoginDatetime_DateFromTo(DateTime? from, DateTime? to) { SetLoginDatetime_FromTo(from, to, new DateFromToOption()); }
        public void SetLoginDatetime_InScope(IList<DateTime?> ls) { regINS<DateTime?>(CK_INS, cTL<DateTime?>(ls), getCValueLoginDatetime(), "LOGIN_DATETIME"); }
        public void SetLoginDatetime_NotInScope(IList<DateTime?> ls) { regINS<DateTime?>(CK_NINS, cTL<DateTime?>(ls), getCValueLoginDatetime(), "LOGIN_DATETIME"); }
        protected void regLoginDatetime(ConditionKey k, Object v) { regQ(k, v, getCValueLoginDatetime(), "LOGIN_DATETIME"); }
        protected abstract ConditionValue getCValueLoginDatetime();

        public void SetMobileLoginFlg_Equal(int? v) { regMobileLoginFlg(CK_EQ, v); }
        /// <summary>
        /// Set the value of True of mobileLoginFlg as equal. { = }
        /// True: 有効を示す
        /// </summary>
        public void SetMobileLoginFlg_Equal_True() {
            String code = CDef.Flg.True.Code;
            regMobileLoginFlg(CK_EQ, int.Parse(code));
        }
        /// <summary>
        /// Set the value of False of mobileLoginFlg as equal. { = }
        /// False: 無効を示す
        /// </summary>
        public void SetMobileLoginFlg_Equal_False() {
            String code = CDef.Flg.False.Code;
            regMobileLoginFlg(CK_EQ, int.Parse(code));
        }
        /// <summary>
        /// Set the value of True of mobileLoginFlg as notEqual. { &lt;&gt; }
        /// True: 有効を示す
        /// </summary>
        public void SetMobileLoginFlg_NotEqual_True() {
            String code = CDef.Flg.True.Code;
            regMobileLoginFlg(CK_NES, int.Parse(code));
        }
        /// <summary>
        /// Set the value of False of mobileLoginFlg as notEqual. { &lt;&gt; }
        /// False: 無効を示す
        /// </summary>
        public void SetMobileLoginFlg_NotEqual_False() {
            String code = CDef.Flg.False.Code;
            regMobileLoginFlg(CK_NES, int.Parse(code));
        }
        public void SetMobileLoginFlg_InScope(IList<int?> ls) { regINS<int?>(CK_INS, cTL<int?>(ls), getCValueMobileLoginFlg(), "MOBILE_LOGIN_FLG"); }
        public void SetMobileLoginFlg_NotInScope(IList<int?> ls) { regINS<int?>(CK_NINS, cTL<int?>(ls), getCValueMobileLoginFlg(), "MOBILE_LOGIN_FLG"); }
        protected void regMobileLoginFlg(ConditionKey k, Object v) { regQ(k, v, getCValueMobileLoginFlg(), "MOBILE_LOGIN_FLG"); }
        protected abstract ConditionValue getCValueMobileLoginFlg();

        public void SetLoginMemberStatusCode_Equal(String v) { DoSetLoginMemberStatusCode_Equal(fRES(v)); }
        protected void DoSetLoginMemberStatusCode_Equal(String v) { regLoginMemberStatusCode(CK_EQ, v); }
        public void SetLoginMemberStatusCode_NotEqual(String v) { DoSetLoginMemberStatusCode_NotEqual(fRES(v)); }
        protected void DoSetLoginMemberStatusCode_NotEqual(String v) { regLoginMemberStatusCode(CK_NES, v); }
        public void SetLoginMemberStatusCode_InScope(IList<String> ls) { regINS<String>(CK_INS, cTL<String>(ls), getCValueLoginMemberStatusCode(), "LOGIN_MEMBER_STATUS_CODE"); }
        public void SetLoginMemberStatusCode_NotInScope(IList<String> ls) { regINS<String>(CK_NINS, cTL<String>(ls), getCValueLoginMemberStatusCode(), "LOGIN_MEMBER_STATUS_CODE"); }
        public void SetLoginMemberStatusCode_PrefixSearch(String v) { SetLoginMemberStatusCode_LikeSearch(v, cLSOP()); }
        public void SetLoginMemberStatusCode_LikeSearch(String v, LikeSearchOption option)
        { regLSQ(CK_LS, fRES(v), getCValueLoginMemberStatusCode(), "LOGIN_MEMBER_STATUS_CODE", option); }
        public void SetLoginMemberStatusCode_NotLikeSearch(String v, LikeSearchOption option)
        { regLSQ(CK_NLS, fRES(v), getCValueLoginMemberStatusCode(), "LOGIN_MEMBER_STATUS_CODE", option); }
        public void InScopeMemberStatus(SubQuery<MemberStatusCB> subQuery) {
            assertObjectNotNull("subQuery<MemberStatusCB>", subQuery);
            MemberStatusCB cb = new MemberStatusCB(); cb.xsetupForInScopeRelation(this); subQuery.Invoke(cb);
            String subQueryPropertyName = keepLoginMemberStatusCode_InScopeSubQuery_MemberStatus(cb.Query());
            registerInScopeSubQuery(cb.Query(), "LOGIN_MEMBER_STATUS_CODE", "MEMBER_STATUS_CODE", subQueryPropertyName);
        }
        public abstract String keepLoginMemberStatusCode_InScopeSubQuery_MemberStatus(MemberStatusCQ subQuery);
        public void NotInScopeMemberStatus(SubQuery<MemberStatusCB> subQuery) {
            assertObjectNotNull("subQuery<MemberStatusCB>", subQuery);
            MemberStatusCB cb = new MemberStatusCB(); cb.xsetupForInScopeRelation(this); subQuery.Invoke(cb);
            String subQueryPropertyName = keepLoginMemberStatusCode_NotInScopeSubQuery_MemberStatus(cb.Query());
            registerNotInScopeSubQuery(cb.Query(), "LOGIN_MEMBER_STATUS_CODE", "MEMBER_STATUS_CODE", subQueryPropertyName);
        }
        public abstract String keepLoginMemberStatusCode_NotInScopeSubQuery_MemberStatus(MemberStatusCQ subQuery);
        protected void regLoginMemberStatusCode(ConditionKey k, Object v) { regQ(k, v, getCValueLoginMemberStatusCode(), "LOGIN_MEMBER_STATUS_CODE"); }
        protected abstract ConditionValue getCValueLoginMemberStatusCode();

        // ===================================================================================
        //                                                                    Scalar Condition
        //                                                                    ================
        public SSQFunction<MemberLoginCB> Scalar_Equal() {
            return xcreateSSQFunction("=");
        }

        public SSQFunction<MemberLoginCB> Scalar_NotEqual() {
            return xcreateSSQFunction("<>");
        }

        public SSQFunction<MemberLoginCB> Scalar_GreaterEqual() {
            return xcreateSSQFunction(">=");
        }

        public SSQFunction<MemberLoginCB> Scalar_GreaterThan() {
            return xcreateSSQFunction(">");
        }

        public SSQFunction<MemberLoginCB> Scalar_LessEqual() {
            return xcreateSSQFunction("<=");
        }

        public SSQFunction<MemberLoginCB> Scalar_LessThan() {
            return xcreateSSQFunction("<");
        }

        protected SSQFunction<MemberLoginCB> xcreateSSQFunction(String operand) {
            return new SSQFunction<MemberLoginCB>(delegate(String function, SubQuery<MemberLoginCB> subQuery) {
                xscalarSubQuery(function, subQuery, operand);
            });
        }

        protected void xscalarSubQuery(String function, SubQuery<MemberLoginCB> subQuery, String operand) {
            assertObjectNotNull("subQuery<MemberLoginCB>", subQuery);
            MemberLoginCB cb = new MemberLoginCB(); cb.xsetupForScalarCondition(this); subQuery.Invoke(cb);
            String subQueryPropertyName = keepScalarSubQuery(cb.Query()); // for saving query-value.
            registerScalarSubQuery(function, cb.Query(), subQueryPropertyName, operand);
        }
        public abstract String keepScalarSubQuery(MemberLoginCQ subQuery);

        // ===============================================================================
        //                                                                  MySelf InScope
        //                                                                  ==============
        public void MyselfInScope(SubQuery<MemberLoginCB> subQuery) {
            assertObjectNotNull("subQuery<MemberLoginCB>", subQuery);
            MemberLoginCB cb = new MemberLoginCB(); cb.xsetupForInScopeRelation(this); subQuery.Invoke(cb);
            String subQueryPropertyName = keepMyselfInScopeSubQuery(cb.Query()); // for saving query-value.
            registerInScopeSubQuery(cb.Query(), "MEMBER_LOGIN_ID", "MEMBER_LOGIN_ID", subQueryPropertyName);
        }
        public abstract String keepMyselfInScopeSubQuery(MemberLoginCQ subQuery);

        public override String ToString() { return xgetSqlClause().getClause(); }
    }
}
