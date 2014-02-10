
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
    public abstract class MbAbstractBsMemberLoginCQ : MbAbstractConditionQuery {

        public MbAbstractBsMemberLoginCQ(MbConditionQuery childQuery, MbSqlClause sqlClause, String aliasName, int nestLevel)
            : base(childQuery, sqlClause, aliasName, nestLevel) {}

        public override String getTableDbName() { return "member_login"; }
        public override String getTableSqlName() { return "member_login"; }

        public void SetMemberLoginId_Equal(long? v) { regMemberLoginId(CK_EQ, v); }
        public void SetMemberLoginId_GreaterThan(long? v) { regMemberLoginId(CK_GT, v); }
        public void SetMemberLoginId_LessThan(long? v) { regMemberLoginId(CK_LT, v); }
        public void SetMemberLoginId_GreaterEqual(long? v) { regMemberLoginId(CK_GE, v); }
        public void SetMemberLoginId_LessEqual(long? v) { regMemberLoginId(CK_LE, v); }
        public void SetMemberLoginId_InScope(IList<long?> ls) { regINS<long?>(CK_INS, cTL<long?>(ls), getCValueMemberLoginId(), "MEMBER_LOGIN_ID"); }
        public void SetMemberLoginId_NotInScope(IList<long?> ls) { regINS<long?>(CK_NINS, cTL<long?>(ls), getCValueMemberLoginId(), "MEMBER_LOGIN_ID"); }
        public void SetMemberLoginId_IsNull() { regMemberLoginId(CK_ISN, DUMMY_OBJECT); }
        public void SetMemberLoginId_IsNotNull() { regMemberLoginId(CK_ISNN, DUMMY_OBJECT); }
        protected void regMemberLoginId(MbConditionKey k, Object v) { regQ(k, v, getCValueMemberLoginId(), "MEMBER_LOGIN_ID"); }
        protected abstract MbConditionValue getCValueMemberLoginId();

        public void SetMemberId_Equal(int? v) { regMemberId(CK_EQ, v); }
        public void SetMemberId_GreaterThan(int? v) { regMemberId(CK_GT, v); }
        public void SetMemberId_LessThan(int? v) { regMemberId(CK_LT, v); }
        public void SetMemberId_GreaterEqual(int? v) { regMemberId(CK_GE, v); }
        public void SetMemberId_LessEqual(int? v) { regMemberId(CK_LE, v); }
        public void SetMemberId_InScope(IList<int?> ls) { regINS<int?>(CK_INS, cTL<int?>(ls), getCValueMemberId(), "MEMBER_ID"); }
        public void SetMemberId_NotInScope(IList<int?> ls) { regINS<int?>(CK_NINS, cTL<int?>(ls), getCValueMemberId(), "MEMBER_ID"); }
        public void InScopeMember(MbSubQuery<MbMemberCB> subQuery) {
            assertObjectNotNull("subQuery<MbMemberCB>", subQuery);
            MbMemberCB cb = new MbMemberCB(); cb.xsetupForInScopeRelation(this); subQuery.Invoke(cb);
            String subQueryPropertyName = keepMemberId_InScopeSubQuery_Member(cb.Query());
            registerInScopeSubQuery(cb.Query(), "MEMBER_ID", "MEMBER_ID", subQueryPropertyName);
        }
        public abstract String keepMemberId_InScopeSubQuery_Member(MbMemberCQ subQuery);
        public void NotInScopeMember(MbSubQuery<MbMemberCB> subQuery) {
            assertObjectNotNull("subQuery<MbMemberCB>", subQuery);
            MbMemberCB cb = new MbMemberCB(); cb.xsetupForInScopeRelation(this); subQuery.Invoke(cb);
            String subQueryPropertyName = keepMemberId_NotInScopeSubQuery_Member(cb.Query());
            registerNotInScopeSubQuery(cb.Query(), "MEMBER_ID", "MEMBER_ID", subQueryPropertyName);
        }
        public abstract String keepMemberId_NotInScopeSubQuery_Member(MbMemberCQ subQuery);
        protected void regMemberId(MbConditionKey k, Object v) { regQ(k, v, getCValueMemberId(), "MEMBER_ID"); }
        protected abstract MbConditionValue getCValueMemberId();

        public void SetLoginDatetime_Equal(DateTime? v) { regLoginDatetime(CK_EQ, v); }
        public void SetLoginDatetime_GreaterThan(DateTime? v) { regLoginDatetime(CK_GT, v); }
        public void SetLoginDatetime_LessThan(DateTime? v) { regLoginDatetime(CK_LT, v); }
        public void SetLoginDatetime_GreaterEqual(DateTime? v) { regLoginDatetime(CK_GE, v); }
        public void SetLoginDatetime_LessEqual(DateTime? v) { regLoginDatetime(CK_LE, v); }
        public void SetLoginDatetime_FromTo(DateTime? from, DateTime? to, MbFromToOption option)
        { regFTQ(from, to, getCValueLoginDatetime(), "LOGIN_DATETIME", option); }
        public void SetLoginDatetime_DateFromTo(DateTime? from, DateTime? to) { SetLoginDatetime_FromTo(from, to, new MbDateFromToOption()); }
        public void SetLoginDatetime_InScope(IList<DateTime?> ls) { regINS<DateTime?>(CK_INS, cTL<DateTime?>(ls), getCValueLoginDatetime(), "LOGIN_DATETIME"); }
        public void SetLoginDatetime_NotInScope(IList<DateTime?> ls) { regINS<DateTime?>(CK_NINS, cTL<DateTime?>(ls), getCValueLoginDatetime(), "LOGIN_DATETIME"); }
        protected void regLoginDatetime(MbConditionKey k, Object v) { regQ(k, v, getCValueLoginDatetime(), "LOGIN_DATETIME"); }
        protected abstract MbConditionValue getCValueLoginDatetime();

        public void SetMobileLoginFlg_Equal(int? v) { regMobileLoginFlg(CK_EQ, v); }
        /// <summary>
        /// Set the value of True of mobileLoginFlg as equal. { = }
        /// はい: 有効を示す
        /// </summary>
        public void SetMobileLoginFlg_Equal_True() {
            String code = MbCDef.Flg.True.Code;
            regMobileLoginFlg(CK_EQ, int.Parse(code));
        }
        /// <summary>
        /// Set the value of False of mobileLoginFlg as equal. { = }
        /// いいえ: 無効を示す
        /// </summary>
        public void SetMobileLoginFlg_Equal_False() {
            String code = MbCDef.Flg.False.Code;
            regMobileLoginFlg(CK_EQ, int.Parse(code));
        }
        /// <summary>
        /// Set the value of True of mobileLoginFlg as notEqual. { &lt;&gt; }
        /// はい: 有効を示す
        /// </summary>
        public void SetMobileLoginFlg_NotEqual_True() {
            String code = MbCDef.Flg.True.Code;
            regMobileLoginFlg(CK_NES, int.Parse(code));
        }
        /// <summary>
        /// Set the value of False of mobileLoginFlg as notEqual. { &lt;&gt; }
        /// いいえ: 無効を示す
        /// </summary>
        public void SetMobileLoginFlg_NotEqual_False() {
            String code = MbCDef.Flg.False.Code;
            regMobileLoginFlg(CK_NES, int.Parse(code));
        }
        public void SetMobileLoginFlg_InScope(IList<int?> ls) { regINS<int?>(CK_INS, cTL<int?>(ls), getCValueMobileLoginFlg(), "MOBILE_LOGIN_FLG"); }
        public void SetMobileLoginFlg_NotInScope(IList<int?> ls) { regINS<int?>(CK_NINS, cTL<int?>(ls), getCValueMobileLoginFlg(), "MOBILE_LOGIN_FLG"); }
        protected void regMobileLoginFlg(MbConditionKey k, Object v) { regQ(k, v, getCValueMobileLoginFlg(), "MOBILE_LOGIN_FLG"); }
        protected abstract MbConditionValue getCValueMobileLoginFlg();

        public void SetLoginMemberStatusCode_Equal(String v) { DoSetLoginMemberStatusCode_Equal(fRES(v)); }
        protected void DoSetLoginMemberStatusCode_Equal(String v) { regLoginMemberStatusCode(CK_EQ, v); }
        public void SetLoginMemberStatusCode_NotEqual(String v) { DoSetLoginMemberStatusCode_NotEqual(fRES(v)); }
        protected void DoSetLoginMemberStatusCode_NotEqual(String v) { regLoginMemberStatusCode(CK_NES, v); }
        public void SetLoginMemberStatusCode_InScope(IList<String> ls) { regINS<String>(CK_INS, cTL<String>(ls), getCValueLoginMemberStatusCode(), "LOGIN_MEMBER_STATUS_CODE"); }
        public void SetLoginMemberStatusCode_NotInScope(IList<String> ls) { regINS<String>(CK_NINS, cTL<String>(ls), getCValueLoginMemberStatusCode(), "LOGIN_MEMBER_STATUS_CODE"); }
        public void SetLoginMemberStatusCode_PrefixSearch(String v) { SetLoginMemberStatusCode_LikeSearch(v, cLSOP()); }
        public void SetLoginMemberStatusCode_LikeSearch(String v, MbLikeSearchOption option)
        { regLSQ(CK_LS, fRES(v), getCValueLoginMemberStatusCode(), "LOGIN_MEMBER_STATUS_CODE", option); }
        public void SetLoginMemberStatusCode_NotLikeSearch(String v, MbLikeSearchOption option)
        { regLSQ(CK_NLS, fRES(v), getCValueLoginMemberStatusCode(), "LOGIN_MEMBER_STATUS_CODE", option); }
        public void InScopeMemberStatus(MbSubQuery<MbMemberStatusCB> subQuery) {
            assertObjectNotNull("subQuery<MbMemberStatusCB>", subQuery);
            MbMemberStatusCB cb = new MbMemberStatusCB(); cb.xsetupForInScopeRelation(this); subQuery.Invoke(cb);
            String subQueryPropertyName = keepLoginMemberStatusCode_InScopeSubQuery_MemberStatus(cb.Query());
            registerInScopeSubQuery(cb.Query(), "LOGIN_MEMBER_STATUS_CODE", "MEMBER_STATUS_CODE", subQueryPropertyName);
        }
        public abstract String keepLoginMemberStatusCode_InScopeSubQuery_MemberStatus(MbMemberStatusCQ subQuery);
        public void NotInScopeMemberStatus(MbSubQuery<MbMemberStatusCB> subQuery) {
            assertObjectNotNull("subQuery<MbMemberStatusCB>", subQuery);
            MbMemberStatusCB cb = new MbMemberStatusCB(); cb.xsetupForInScopeRelation(this); subQuery.Invoke(cb);
            String subQueryPropertyName = keepLoginMemberStatusCode_NotInScopeSubQuery_MemberStatus(cb.Query());
            registerNotInScopeSubQuery(cb.Query(), "LOGIN_MEMBER_STATUS_CODE", "MEMBER_STATUS_CODE", subQueryPropertyName);
        }
        public abstract String keepLoginMemberStatusCode_NotInScopeSubQuery_MemberStatus(MbMemberStatusCQ subQuery);
        protected void regLoginMemberStatusCode(MbConditionKey k, Object v) { regQ(k, v, getCValueLoginMemberStatusCode(), "LOGIN_MEMBER_STATUS_CODE"); }
        protected abstract MbConditionValue getCValueLoginMemberStatusCode();

        // ===================================================================================
        //                                                                    Scalar Condition
        //                                                                    ================
        public SSQFunction<MbMemberLoginCB> Scalar_Equal() {
            return xcreateSSQFunction("=");
        }

        public SSQFunction<MbMemberLoginCB> Scalar_NotEqual() {
            return xcreateSSQFunction("<>");
        }

        public SSQFunction<MbMemberLoginCB> Scalar_GreaterEqual() {
            return xcreateSSQFunction(">=");
        }

        public SSQFunction<MbMemberLoginCB> Scalar_GreaterThan() {
            return xcreateSSQFunction(">");
        }

        public SSQFunction<MbMemberLoginCB> Scalar_LessEqual() {
            return xcreateSSQFunction("<=");
        }

        public SSQFunction<MbMemberLoginCB> Scalar_LessThan() {
            return xcreateSSQFunction("<");
        }

        protected SSQFunction<MbMemberLoginCB> xcreateSSQFunction(String operand) {
            return new SSQFunction<MbMemberLoginCB>(delegate(String function, MbSubQuery<MbMemberLoginCB> subQuery) {
                xscalarSubQuery(function, subQuery, operand);
            });
        }

        protected void xscalarSubQuery(String function, MbSubQuery<MbMemberLoginCB> subQuery, String operand) {
            assertObjectNotNull("subQuery<MbMemberLoginCB>", subQuery);
            MbMemberLoginCB cb = new MbMemberLoginCB(); cb.xsetupForScalarCondition(this); subQuery.Invoke(cb);
            String subQueryPropertyName = keepScalarSubQuery(cb.Query()); // for saving query-value.
            registerScalarSubQuery(function, cb.Query(), subQueryPropertyName, operand);
        }
        public abstract String keepScalarSubQuery(MbMemberLoginCQ subQuery);

        // ===============================================================================
        //                                                                  MySelf InScope
        //                                                                  ==============
        public void MyselfInScope(MbSubQuery<MbMemberLoginCB> subQuery) {
            assertObjectNotNull("subQuery<MbMemberLoginCB>", subQuery);
            MbMemberLoginCB cb = new MbMemberLoginCB(); cb.xsetupForInScopeRelation(this); subQuery.Invoke(cb);
            String subQueryPropertyName = keepMyselfInScopeSubQuery(cb.Query()); // for saving query-value.
            registerInScopeSubQuery(cb.Query(), "MEMBER_LOGIN_ID", "MEMBER_LOGIN_ID", subQueryPropertyName);
        }
        public abstract String keepMyselfInScopeSubQuery(MbMemberLoginCQ subQuery);

        public override String ToString() { return xgetSqlClause().getClause(); }
    }
}
