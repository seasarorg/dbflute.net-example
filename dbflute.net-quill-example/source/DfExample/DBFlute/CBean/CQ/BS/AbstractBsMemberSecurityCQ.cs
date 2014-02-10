
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
    public abstract class AbstractBsMemberSecurityCQ : AbstractConditionQuery {

        public AbstractBsMemberSecurityCQ(ConditionQuery childQuery, SqlClause sqlClause, String aliasName, int nestLevel)
            : base(childQuery, sqlClause, aliasName, nestLevel) {}

        public override String getTableDbName() { return "member_security"; }
        public override String getTableSqlName() { return "member_security"; }

        public void SetMemberId_Equal(int? v) { regMemberId(CK_EQ, v); }
        public void SetMemberId_NotEqual(int? v) { regMemberId(CK_NES, v); }
        public void SetMemberId_GreaterThan(int? v) { regMemberId(CK_GT, v); }
        public void SetMemberId_LessThan(int? v) { regMemberId(CK_LT, v); }
        public void SetMemberId_GreaterEqual(int? v) { regMemberId(CK_GE, v); }
        public void SetMemberId_LessEqual(int? v) { regMemberId(CK_LE, v); }
        public void SetMemberId_InScope(IList<int?> ls) { regINS<int?>(CK_INS, cTL<int?>(ls), getCValueMemberId(), "MEMBER_ID"); }
        public void SetMemberId_NotInScope(IList<int?> ls) { regINS<int?>(CK_NINS, cTL<int?>(ls), getCValueMemberId(), "MEMBER_ID"); }
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
        public void SetMemberId_IsNull() { regMemberId(CK_ISN, DUMMY_OBJECT); }
        public void SetMemberId_IsNotNull() { regMemberId(CK_ISNN, DUMMY_OBJECT); }
        protected void regMemberId(ConditionKey k, Object v) { regQ(k, v, getCValueMemberId(), "MEMBER_ID"); }
        protected abstract ConditionValue getCValueMemberId();

        public void SetLoginPassword_Equal(String v) { DoSetLoginPassword_Equal(fRES(v)); }
        protected void DoSetLoginPassword_Equal(String v) { regLoginPassword(CK_EQ, v); }
        public void SetLoginPassword_NotEqual(String v) { DoSetLoginPassword_NotEqual(fRES(v)); }
        protected void DoSetLoginPassword_NotEqual(String v) { regLoginPassword(CK_NES, v); }
        public void SetLoginPassword_InScope(IList<String> ls) { regINS<String>(CK_INS, cTL<String>(ls), getCValueLoginPassword(), "LOGIN_PASSWORD"); }
        public void SetLoginPassword_NotInScope(IList<String> ls) { regINS<String>(CK_NINS, cTL<String>(ls), getCValueLoginPassword(), "LOGIN_PASSWORD"); }
        public void SetLoginPassword_PrefixSearch(String v) { SetLoginPassword_LikeSearch(v, cLSOP()); }
        public void SetLoginPassword_LikeSearch(String v, LikeSearchOption option)
        { regLSQ(CK_LS, fRES(v), getCValueLoginPassword(), "LOGIN_PASSWORD", option); }
        public void SetLoginPassword_NotLikeSearch(String v, LikeSearchOption option)
        { regLSQ(CK_NLS, fRES(v), getCValueLoginPassword(), "LOGIN_PASSWORD", option); }
        protected void regLoginPassword(ConditionKey k, Object v) { regQ(k, v, getCValueLoginPassword(), "LOGIN_PASSWORD"); }
        protected abstract ConditionValue getCValueLoginPassword();

        public void SetReminderQuestion_Equal(String v) { DoSetReminderQuestion_Equal(fRES(v)); }
        protected void DoSetReminderQuestion_Equal(String v) { regReminderQuestion(CK_EQ, v); }
        public void SetReminderQuestion_NotEqual(String v) { DoSetReminderQuestion_NotEqual(fRES(v)); }
        protected void DoSetReminderQuestion_NotEqual(String v) { regReminderQuestion(CK_NES, v); }
        public void SetReminderQuestion_InScope(IList<String> ls) { regINS<String>(CK_INS, cTL<String>(ls), getCValueReminderQuestion(), "REMINDER_QUESTION"); }
        public void SetReminderQuestion_NotInScope(IList<String> ls) { regINS<String>(CK_NINS, cTL<String>(ls), getCValueReminderQuestion(), "REMINDER_QUESTION"); }
        public void SetReminderQuestion_PrefixSearch(String v) { SetReminderQuestion_LikeSearch(v, cLSOP()); }
        public void SetReminderQuestion_LikeSearch(String v, LikeSearchOption option)
        { regLSQ(CK_LS, fRES(v), getCValueReminderQuestion(), "REMINDER_QUESTION", option); }
        public void SetReminderQuestion_NotLikeSearch(String v, LikeSearchOption option)
        { regLSQ(CK_NLS, fRES(v), getCValueReminderQuestion(), "REMINDER_QUESTION", option); }
        protected void regReminderQuestion(ConditionKey k, Object v) { regQ(k, v, getCValueReminderQuestion(), "REMINDER_QUESTION"); }
        protected abstract ConditionValue getCValueReminderQuestion();

        public void SetReminderAnswer_Equal(String v) { DoSetReminderAnswer_Equal(fRES(v)); }
        protected void DoSetReminderAnswer_Equal(String v) { regReminderAnswer(CK_EQ, v); }
        public void SetReminderAnswer_NotEqual(String v) { DoSetReminderAnswer_NotEqual(fRES(v)); }
        protected void DoSetReminderAnswer_NotEqual(String v) { regReminderAnswer(CK_NES, v); }
        public void SetReminderAnswer_InScope(IList<String> ls) { regINS<String>(CK_INS, cTL<String>(ls), getCValueReminderAnswer(), "REMINDER_ANSWER"); }
        public void SetReminderAnswer_NotInScope(IList<String> ls) { regINS<String>(CK_NINS, cTL<String>(ls), getCValueReminderAnswer(), "REMINDER_ANSWER"); }
        public void SetReminderAnswer_PrefixSearch(String v) { SetReminderAnswer_LikeSearch(v, cLSOP()); }
        public void SetReminderAnswer_LikeSearch(String v, LikeSearchOption option)
        { regLSQ(CK_LS, fRES(v), getCValueReminderAnswer(), "REMINDER_ANSWER", option); }
        public void SetReminderAnswer_NotLikeSearch(String v, LikeSearchOption option)
        { regLSQ(CK_NLS, fRES(v), getCValueReminderAnswer(), "REMINDER_ANSWER", option); }
        protected void regReminderAnswer(ConditionKey k, Object v) { regQ(k, v, getCValueReminderAnswer(), "REMINDER_ANSWER"); }
        protected abstract ConditionValue getCValueReminderAnswer();

        public void SetRegisterDatetime_Equal(DateTime? v) { regRegisterDatetime(CK_EQ, v); }
        public void SetRegisterDatetime_GreaterThan(DateTime? v) { regRegisterDatetime(CK_GT, v); }
        public void SetRegisterDatetime_LessThan(DateTime? v) { regRegisterDatetime(CK_LT, v); }
        public void SetRegisterDatetime_GreaterEqual(DateTime? v) { regRegisterDatetime(CK_GE, v); }
        public void SetRegisterDatetime_LessEqual(DateTime? v) { regRegisterDatetime(CK_LE, v); }
        public void SetRegisterDatetime_FromTo(DateTime? from, DateTime? to, FromToOption option)
        { regFTQ(from, to, getCValueRegisterDatetime(), "REGISTER_DATETIME", option); }
        public void SetRegisterDatetime_DateFromTo(DateTime? from, DateTime? to) { SetRegisterDatetime_FromTo(from, to, new DateFromToOption()); }
        public void SetRegisterDatetime_InScope(IList<DateTime?> ls) { regINS<DateTime?>(CK_INS, cTL<DateTime?>(ls), getCValueRegisterDatetime(), "REGISTER_DATETIME"); }
        public void SetRegisterDatetime_NotInScope(IList<DateTime?> ls) { regINS<DateTime?>(CK_NINS, cTL<DateTime?>(ls), getCValueRegisterDatetime(), "REGISTER_DATETIME"); }
        protected void regRegisterDatetime(ConditionKey k, Object v) { regQ(k, v, getCValueRegisterDatetime(), "REGISTER_DATETIME"); }
        protected abstract ConditionValue getCValueRegisterDatetime();

        public void SetRegisterProcess_Equal(String v) { DoSetRegisterProcess_Equal(fRES(v)); }
        protected void DoSetRegisterProcess_Equal(String v) { regRegisterProcess(CK_EQ, v); }
        public void SetRegisterProcess_NotEqual(String v) { DoSetRegisterProcess_NotEqual(fRES(v)); }
        protected void DoSetRegisterProcess_NotEqual(String v) { regRegisterProcess(CK_NES, v); }
        public void SetRegisterProcess_InScope(IList<String> ls) { regINS<String>(CK_INS, cTL<String>(ls), getCValueRegisterProcess(), "REGISTER_PROCESS"); }
        public void SetRegisterProcess_NotInScope(IList<String> ls) { regINS<String>(CK_NINS, cTL<String>(ls), getCValueRegisterProcess(), "REGISTER_PROCESS"); }
        public void SetRegisterProcess_PrefixSearch(String v) { SetRegisterProcess_LikeSearch(v, cLSOP()); }
        public void SetRegisterProcess_LikeSearch(String v, LikeSearchOption option)
        { regLSQ(CK_LS, fRES(v), getCValueRegisterProcess(), "REGISTER_PROCESS", option); }
        public void SetRegisterProcess_NotLikeSearch(String v, LikeSearchOption option)
        { regLSQ(CK_NLS, fRES(v), getCValueRegisterProcess(), "REGISTER_PROCESS", option); }
        protected void regRegisterProcess(ConditionKey k, Object v) { regQ(k, v, getCValueRegisterProcess(), "REGISTER_PROCESS"); }
        protected abstract ConditionValue getCValueRegisterProcess();

        public void SetRegisterUser_Equal(String v) { DoSetRegisterUser_Equal(fRES(v)); }
        protected void DoSetRegisterUser_Equal(String v) { regRegisterUser(CK_EQ, v); }
        public void SetRegisterUser_NotEqual(String v) { DoSetRegisterUser_NotEqual(fRES(v)); }
        protected void DoSetRegisterUser_NotEqual(String v) { regRegisterUser(CK_NES, v); }
        public void SetRegisterUser_InScope(IList<String> ls) { regINS<String>(CK_INS, cTL<String>(ls), getCValueRegisterUser(), "REGISTER_USER"); }
        public void SetRegisterUser_NotInScope(IList<String> ls) { regINS<String>(CK_NINS, cTL<String>(ls), getCValueRegisterUser(), "REGISTER_USER"); }
        public void SetRegisterUser_PrefixSearch(String v) { SetRegisterUser_LikeSearch(v, cLSOP()); }
        public void SetRegisterUser_LikeSearch(String v, LikeSearchOption option)
        { regLSQ(CK_LS, fRES(v), getCValueRegisterUser(), "REGISTER_USER", option); }
        public void SetRegisterUser_NotLikeSearch(String v, LikeSearchOption option)
        { regLSQ(CK_NLS, fRES(v), getCValueRegisterUser(), "REGISTER_USER", option); }
        protected void regRegisterUser(ConditionKey k, Object v) { regQ(k, v, getCValueRegisterUser(), "REGISTER_USER"); }
        protected abstract ConditionValue getCValueRegisterUser();

        public void SetUpdateDatetime_Equal(DateTime? v) { regUpdateDatetime(CK_EQ, v); }
        public void SetUpdateDatetime_GreaterThan(DateTime? v) { regUpdateDatetime(CK_GT, v); }
        public void SetUpdateDatetime_LessThan(DateTime? v) { regUpdateDatetime(CK_LT, v); }
        public void SetUpdateDatetime_GreaterEqual(DateTime? v) { regUpdateDatetime(CK_GE, v); }
        public void SetUpdateDatetime_LessEqual(DateTime? v) { regUpdateDatetime(CK_LE, v); }
        public void SetUpdateDatetime_FromTo(DateTime? from, DateTime? to, FromToOption option)
        { regFTQ(from, to, getCValueUpdateDatetime(), "UPDATE_DATETIME", option); }
        public void SetUpdateDatetime_DateFromTo(DateTime? from, DateTime? to) { SetUpdateDatetime_FromTo(from, to, new DateFromToOption()); }
        public void SetUpdateDatetime_InScope(IList<DateTime?> ls) { regINS<DateTime?>(CK_INS, cTL<DateTime?>(ls), getCValueUpdateDatetime(), "UPDATE_DATETIME"); }
        public void SetUpdateDatetime_NotInScope(IList<DateTime?> ls) { regINS<DateTime?>(CK_NINS, cTL<DateTime?>(ls), getCValueUpdateDatetime(), "UPDATE_DATETIME"); }
        protected void regUpdateDatetime(ConditionKey k, Object v) { regQ(k, v, getCValueUpdateDatetime(), "UPDATE_DATETIME"); }
        protected abstract ConditionValue getCValueUpdateDatetime();

        public void SetUpdateProcess_Equal(String v) { DoSetUpdateProcess_Equal(fRES(v)); }
        protected void DoSetUpdateProcess_Equal(String v) { regUpdateProcess(CK_EQ, v); }
        public void SetUpdateProcess_NotEqual(String v) { DoSetUpdateProcess_NotEqual(fRES(v)); }
        protected void DoSetUpdateProcess_NotEqual(String v) { regUpdateProcess(CK_NES, v); }
        public void SetUpdateProcess_InScope(IList<String> ls) { regINS<String>(CK_INS, cTL<String>(ls), getCValueUpdateProcess(), "UPDATE_PROCESS"); }
        public void SetUpdateProcess_NotInScope(IList<String> ls) { regINS<String>(CK_NINS, cTL<String>(ls), getCValueUpdateProcess(), "UPDATE_PROCESS"); }
        public void SetUpdateProcess_PrefixSearch(String v) { SetUpdateProcess_LikeSearch(v, cLSOP()); }
        public void SetUpdateProcess_LikeSearch(String v, LikeSearchOption option)
        { regLSQ(CK_LS, fRES(v), getCValueUpdateProcess(), "UPDATE_PROCESS", option); }
        public void SetUpdateProcess_NotLikeSearch(String v, LikeSearchOption option)
        { regLSQ(CK_NLS, fRES(v), getCValueUpdateProcess(), "UPDATE_PROCESS", option); }
        protected void regUpdateProcess(ConditionKey k, Object v) { regQ(k, v, getCValueUpdateProcess(), "UPDATE_PROCESS"); }
        protected abstract ConditionValue getCValueUpdateProcess();

        public void SetUpdateUser_Equal(String v) { DoSetUpdateUser_Equal(fRES(v)); }
        protected void DoSetUpdateUser_Equal(String v) { regUpdateUser(CK_EQ, v); }
        public void SetUpdateUser_NotEqual(String v) { DoSetUpdateUser_NotEqual(fRES(v)); }
        protected void DoSetUpdateUser_NotEqual(String v) { regUpdateUser(CK_NES, v); }
        public void SetUpdateUser_InScope(IList<String> ls) { regINS<String>(CK_INS, cTL<String>(ls), getCValueUpdateUser(), "UPDATE_USER"); }
        public void SetUpdateUser_NotInScope(IList<String> ls) { regINS<String>(CK_NINS, cTL<String>(ls), getCValueUpdateUser(), "UPDATE_USER"); }
        public void SetUpdateUser_PrefixSearch(String v) { SetUpdateUser_LikeSearch(v, cLSOP()); }
        public void SetUpdateUser_LikeSearch(String v, LikeSearchOption option)
        { regLSQ(CK_LS, fRES(v), getCValueUpdateUser(), "UPDATE_USER", option); }
        public void SetUpdateUser_NotLikeSearch(String v, LikeSearchOption option)
        { regLSQ(CK_NLS, fRES(v), getCValueUpdateUser(), "UPDATE_USER", option); }
        protected void regUpdateUser(ConditionKey k, Object v) { regQ(k, v, getCValueUpdateUser(), "UPDATE_USER"); }
        protected abstract ConditionValue getCValueUpdateUser();

        public void SetVersionNo_Equal(long? v) { regVersionNo(CK_EQ, v); }
        public void SetVersionNo_NotEqual(long? v) { regVersionNo(CK_NES, v); }
        public void SetVersionNo_GreaterThan(long? v) { regVersionNo(CK_GT, v); }
        public void SetVersionNo_LessThan(long? v) { regVersionNo(CK_LT, v); }
        public void SetVersionNo_GreaterEqual(long? v) { regVersionNo(CK_GE, v); }
        public void SetVersionNo_LessEqual(long? v) { regVersionNo(CK_LE, v); }
        public void SetVersionNo_InScope(IList<long?> ls) { regINS<long?>(CK_INS, cTL<long?>(ls), getCValueVersionNo(), "VERSION_NO"); }
        public void SetVersionNo_NotInScope(IList<long?> ls) { regINS<long?>(CK_NINS, cTL<long?>(ls), getCValueVersionNo(), "VERSION_NO"); }
        protected void regVersionNo(ConditionKey k, Object v) { regQ(k, v, getCValueVersionNo(), "VERSION_NO"); }
        protected abstract ConditionValue getCValueVersionNo();

        // ===================================================================================
        //                                                                    Scalar Condition
        //                                                                    ================
        public SSQFunction<MemberSecurityCB> Scalar_Equal() {
            return xcreateSSQFunction("=");
        }

        public SSQFunction<MemberSecurityCB> Scalar_NotEqual() {
            return xcreateSSQFunction("<>");
        }

        public SSQFunction<MemberSecurityCB> Scalar_GreaterEqual() {
            return xcreateSSQFunction(">=");
        }

        public SSQFunction<MemberSecurityCB> Scalar_GreaterThan() {
            return xcreateSSQFunction(">");
        }

        public SSQFunction<MemberSecurityCB> Scalar_LessEqual() {
            return xcreateSSQFunction("<=");
        }

        public SSQFunction<MemberSecurityCB> Scalar_LessThan() {
            return xcreateSSQFunction("<");
        }

        protected SSQFunction<MemberSecurityCB> xcreateSSQFunction(String operand) {
            return new SSQFunction<MemberSecurityCB>(delegate(String function, SubQuery<MemberSecurityCB> subQuery) {
                xscalarSubQuery(function, subQuery, operand);
            });
        }

        protected void xscalarSubQuery(String function, SubQuery<MemberSecurityCB> subQuery, String operand) {
            assertObjectNotNull("subQuery<MemberSecurityCB>", subQuery);
            MemberSecurityCB cb = new MemberSecurityCB(); cb.xsetupForScalarCondition(this); subQuery.Invoke(cb);
            String subQueryPropertyName = keepScalarSubQuery(cb.Query()); // for saving query-value.
            registerScalarSubQuery(function, cb.Query(), subQueryPropertyName, operand);
        }
        public abstract String keepScalarSubQuery(MemberSecurityCQ subQuery);

        // ===============================================================================
        //                                                                  MySelf InScope
        //                                                                  ==============
        public void MyselfInScope(SubQuery<MemberSecurityCB> subQuery) {
            assertObjectNotNull("subQuery<MemberSecurityCB>", subQuery);
            MemberSecurityCB cb = new MemberSecurityCB(); cb.xsetupForInScopeRelation(this); subQuery.Invoke(cb);
            String subQueryPropertyName = keepMyselfInScopeSubQuery(cb.Query()); // for saving query-value.
            registerInScopeSubQuery(cb.Query(), "MEMBER_ID", "MEMBER_ID", subQueryPropertyName);
        }
        public abstract String keepMyselfInScopeSubQuery(MemberSecurityCQ subQuery);

        public override String ToString() { return xgetSqlClause().getClause(); }
    }
}
