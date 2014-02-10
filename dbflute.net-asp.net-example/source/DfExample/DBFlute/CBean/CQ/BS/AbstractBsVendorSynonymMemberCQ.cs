
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
    public abstract class AbstractBsVendorSynonymMemberCQ : AbstractConditionQuery {

        public AbstractBsVendorSynonymMemberCQ(ConditionQuery childQuery, SqlClause sqlClause, String aliasName, int nestLevel)
            : base(childQuery, sqlClause, aliasName, nestLevel) {}

        public override String getTableDbName() { return "VENDOR_SYNONYM_MEMBER"; }
        public override String getTableSqlName() { return "VENDOR_SYNONYM_MEMBER"; }

        public void SetMemberId_Equal(long? v) { regMemberId(CK_EQ, v); }
        public void SetMemberId_GreaterThan(long? v) { regMemberId(CK_GT, v); }
        public void SetMemberId_LessThan(long? v) { regMemberId(CK_LT, v); }
        public void SetMemberId_GreaterEqual(long? v) { regMemberId(CK_GE, v); }
        public void SetMemberId_LessEqual(long? v) { regMemberId(CK_LE, v); }
        public void SetMemberId_InScope(IList<long?> ls) { regINS<long?>(CK_INS, cTL<long?>(ls), getCValueMemberId(), "MEMBER_ID"); }
        public void SetMemberId_NotInScope(IList<long?> ls) { regINS<long?>(CK_NINS, cTL<long?>(ls), getCValueMemberId(), "MEMBER_ID"); }
        public void ExistsVdSynonymMemberLoginList(SubQuery<VdSynonymMemberLoginCB> subQuery) {
            assertObjectNotNull("subQuery<VdSynonymMemberLoginCB>", subQuery);
            VdSynonymMemberLoginCB cb = new VdSynonymMemberLoginCB(); cb.xsetupForExistsReferrer(this); subQuery.Invoke(cb);
            String subQueryPropertyName = keepMemberId_ExistsSubQuery_VdSynonymMemberLoginList(cb.Query());
            registerExistsSubQuery(cb.Query(), "MEMBER_ID", "MEMBER_ID", subQueryPropertyName);
        }
        public abstract String keepMemberId_ExistsSubQuery_VdSynonymMemberLoginList(VdSynonymMemberLoginCQ subQuery);
        public void ExistsVdSynonymMemberWithdrawalAsOne(SubQuery<VdSynonymMemberWithdrawalCB> subQuery) {
            assertObjectNotNull("subQuery<VdSynonymMemberWithdrawalCB>", subQuery);
            VdSynonymMemberWithdrawalCB cb = new VdSynonymMemberWithdrawalCB(); cb.xsetupForExistsReferrer(this); subQuery.Invoke(cb);
            String subQueryPropertyName = keepMemberId_ExistsSubQuery_VdSynonymMemberWithdrawalAsOne(cb.Query());
            registerExistsSubQuery(cb.Query(), "MEMBER_ID", "MEMBER_ID", subQueryPropertyName);
        }
        public abstract String keepMemberId_ExistsSubQuery_VdSynonymMemberWithdrawalAsOne(VdSynonymMemberWithdrawalCQ subQuery);
        public void NotExistsVdSynonymMemberLoginList(SubQuery<VdSynonymMemberLoginCB> subQuery) {
            assertObjectNotNull("subQuery<VdSynonymMemberLoginCB>", subQuery);
            VdSynonymMemberLoginCB cb = new VdSynonymMemberLoginCB(); cb.xsetupForExistsReferrer(this); subQuery.Invoke(cb);
            String subQueryPropertyName = keepMemberId_NotExistsSubQuery_VdSynonymMemberLoginList(cb.Query());
            registerNotExistsSubQuery(cb.Query(), "MEMBER_ID", "MEMBER_ID", subQueryPropertyName);
        }
        public abstract String keepMemberId_NotExistsSubQuery_VdSynonymMemberLoginList(VdSynonymMemberLoginCQ subQuery);
        public void NotExistsVdSynonymMemberWithdrawalAsOne(SubQuery<VdSynonymMemberWithdrawalCB> subQuery) {
            assertObjectNotNull("subQuery<VdSynonymMemberWithdrawalCB>", subQuery);
            VdSynonymMemberWithdrawalCB cb = new VdSynonymMemberWithdrawalCB(); cb.xsetupForExistsReferrer(this); subQuery.Invoke(cb);
            String subQueryPropertyName = keepMemberId_NotExistsSubQuery_VdSynonymMemberWithdrawalAsOne(cb.Query());
            registerNotExistsSubQuery(cb.Query(), "MEMBER_ID", "MEMBER_ID", subQueryPropertyName);
        }
        public abstract String keepMemberId_NotExistsSubQuery_VdSynonymMemberWithdrawalAsOne(VdSynonymMemberWithdrawalCQ subQuery);
        public void InScopeVdSynonymMemberLoginList(SubQuery<VdSynonymMemberLoginCB> subQuery) {
            assertObjectNotNull("subQuery<VdSynonymMemberLoginCB>", subQuery);
            VdSynonymMemberLoginCB cb = new VdSynonymMemberLoginCB(); cb.xsetupForInScopeRelation(this); subQuery.Invoke(cb);
            String subQueryPropertyName = keepMemberId_InScopeSubQuery_VdSynonymMemberLoginList(cb.Query());
            registerInScopeSubQuery(cb.Query(), "MEMBER_ID", "MEMBER_ID", subQueryPropertyName);
        }
        public abstract String keepMemberId_InScopeSubQuery_VdSynonymMemberLoginList(VdSynonymMemberLoginCQ subQuery);
        public void InScopeVdSynonymMemberWithdrawalAsOne(SubQuery<VdSynonymMemberWithdrawalCB> subQuery) {
            assertObjectNotNull("subQuery<VdSynonymMemberWithdrawalCB>", subQuery);
            VdSynonymMemberWithdrawalCB cb = new VdSynonymMemberWithdrawalCB(); cb.xsetupForInScopeRelation(this); subQuery.Invoke(cb);
            String subQueryPropertyName = keepMemberId_InScopeSubQuery_VdSynonymMemberWithdrawalAsOne(cb.Query());
            registerInScopeSubQuery(cb.Query(), "MEMBER_ID", "MEMBER_ID", subQueryPropertyName);
        }
        public abstract String keepMemberId_InScopeSubQuery_VdSynonymMemberWithdrawalAsOne(VdSynonymMemberWithdrawalCQ subQuery);
        public void NotInScopeVdSynonymMemberLoginList(SubQuery<VdSynonymMemberLoginCB> subQuery) {
            assertObjectNotNull("subQuery<VdSynonymMemberLoginCB>", subQuery);
            VdSynonymMemberLoginCB cb = new VdSynonymMemberLoginCB(); cb.xsetupForInScopeRelation(this); subQuery.Invoke(cb);
            String subQueryPropertyName = keepMemberId_NotInScopeSubQuery_VdSynonymMemberLoginList(cb.Query());
            registerNotInScopeSubQuery(cb.Query(), "MEMBER_ID", "MEMBER_ID", subQueryPropertyName);
        }
        public abstract String keepMemberId_NotInScopeSubQuery_VdSynonymMemberLoginList(VdSynonymMemberLoginCQ subQuery);
        public void NotInScopeVdSynonymMemberWithdrawalAsOne(SubQuery<VdSynonymMemberWithdrawalCB> subQuery) {
            assertObjectNotNull("subQuery<VdSynonymMemberWithdrawalCB>", subQuery);
            VdSynonymMemberWithdrawalCB cb = new VdSynonymMemberWithdrawalCB(); cb.xsetupForInScopeRelation(this); subQuery.Invoke(cb);
            String subQueryPropertyName = keepMemberId_NotInScopeSubQuery_VdSynonymMemberWithdrawalAsOne(cb.Query());
            registerNotInScopeSubQuery(cb.Query(), "MEMBER_ID", "MEMBER_ID", subQueryPropertyName);
        }
        public abstract String keepMemberId_NotInScopeSubQuery_VdSynonymMemberWithdrawalAsOne(VdSynonymMemberWithdrawalCQ subQuery);
        public void xsderiveVdSynonymMemberLoginList(String function, SubQuery<VdSynonymMemberLoginCB> subQuery, String aliasName) {
            assertObjectNotNull("subQuery<VdSynonymMemberLoginCB>", subQuery);
            VdSynonymMemberLoginCB cb = new VdSynonymMemberLoginCB(); cb.xsetupForDerivedReferrer(this); subQuery.Invoke(cb);
            String subQueryPropertyName = keepMemberId_SpecifyDerivedReferrer_VdSynonymMemberLoginList(cb.Query());
            registerSpecifyDerivedReferrer(function, cb.Query(), "MEMBER_ID", "MEMBER_ID", subQueryPropertyName, aliasName);
        }
        abstract public String keepMemberId_SpecifyDerivedReferrer_VdSynonymMemberLoginList(VdSynonymMemberLoginCQ subQuery);

        public QDRFunction<VdSynonymMemberLoginCB> DerivedVdSynonymMemberLoginList() {
            return xcreateQDRFunctionVdSynonymMemberLoginList();
        }
        protected QDRFunction<VdSynonymMemberLoginCB> xcreateQDRFunctionVdSynonymMemberLoginList() {
            return new QDRFunction<VdSynonymMemberLoginCB>(delegate(String function, SubQuery<VdSynonymMemberLoginCB> subQuery, String operand, Object value) {
                xqderiveVdSynonymMemberLoginList(function, subQuery, operand, value);
            });
        }
        public void xqderiveVdSynonymMemberLoginList(String function, SubQuery<VdSynonymMemberLoginCB> subQuery, String operand, Object value) {
            assertObjectNotNull("subQuery<VdSynonymMemberLoginCB>", subQuery);
            VdSynonymMemberLoginCB cb = new VdSynonymMemberLoginCB(); cb.xsetupForDerivedReferrer(this); subQuery.Invoke(cb);
            String subQueryPropertyName = keepMemberId_QueryDerivedReferrer_VdSynonymMemberLoginList(cb.Query()); // for saving query-value.
            String parameterPropertyName = keepMemberId_QueryDerivedReferrer_VdSynonymMemberLoginListParameter(value);
            registerQueryDerivedReferrer(function, cb.Query(), "MEMBER_ID", "MEMBER_ID", subQueryPropertyName, operand, value, parameterPropertyName);
        }
        public abstract String keepMemberId_QueryDerivedReferrer_VdSynonymMemberLoginList(VdSynonymMemberLoginCQ subQuery);
        public abstract String keepMemberId_QueryDerivedReferrer_VdSynonymMemberLoginListParameter(Object parameterValue);
        public void SetMemberId_IsNull() { regMemberId(CK_ISN, DUMMY_OBJECT); }
        public void SetMemberId_IsNotNull() { regMemberId(CK_ISNN, DUMMY_OBJECT); }
        protected void regMemberId(ConditionKey k, Object v) { regQ(k, v, getCValueMemberId(), "MEMBER_ID"); }
        protected abstract ConditionValue getCValueMemberId();

        public void SetMemberName_Equal(String v) { DoSetMemberName_Equal(fRES(v)); }
        protected void DoSetMemberName_Equal(String v) { regMemberName(CK_EQ, v); }
        public void SetMemberName_NotEqual(String v) { DoSetMemberName_NotEqual(fRES(v)); }
        protected void DoSetMemberName_NotEqual(String v) { regMemberName(CK_NES, v); }
        public void SetMemberName_InScope(IList<String> ls) { regINS<String>(CK_INS, cTL<String>(ls), getCValueMemberName(), "MEMBER_NAME"); }
        public void SetMemberName_NotInScope(IList<String> ls) { regINS<String>(CK_NINS, cTL<String>(ls), getCValueMemberName(), "MEMBER_NAME"); }
        public void SetMemberName_PrefixSearch(String v) { SetMemberName_LikeSearch(v, cLSOP()); }
        public void SetMemberName_LikeSearch(String v, LikeSearchOption option)
        { regLSQ(CK_LS, fRES(v), getCValueMemberName(), "MEMBER_NAME", option); }
        public void SetMemberName_NotLikeSearch(String v, LikeSearchOption option)
        { regLSQ(CK_NLS, fRES(v), getCValueMemberName(), "MEMBER_NAME", option); }
        protected void regMemberName(ConditionKey k, Object v) { regQ(k, v, getCValueMemberName(), "MEMBER_NAME"); }
        protected abstract ConditionValue getCValueMemberName();

        public void SetMemberAccount_Equal(String v) { DoSetMemberAccount_Equal(fRES(v)); }
        protected void DoSetMemberAccount_Equal(String v) { regMemberAccount(CK_EQ, v); }
        public void SetMemberAccount_NotEqual(String v) { DoSetMemberAccount_NotEqual(fRES(v)); }
        protected void DoSetMemberAccount_NotEqual(String v) { regMemberAccount(CK_NES, v); }
        public void SetMemberAccount_InScope(IList<String> ls) { regINS<String>(CK_INS, cTL<String>(ls), getCValueMemberAccount(), "MEMBER_ACCOUNT"); }
        public void SetMemberAccount_NotInScope(IList<String> ls) { regINS<String>(CK_NINS, cTL<String>(ls), getCValueMemberAccount(), "MEMBER_ACCOUNT"); }
        public void SetMemberAccount_PrefixSearch(String v) { SetMemberAccount_LikeSearch(v, cLSOP()); }
        public void SetMemberAccount_LikeSearch(String v, LikeSearchOption option)
        { regLSQ(CK_LS, fRES(v), getCValueMemberAccount(), "MEMBER_ACCOUNT", option); }
        public void SetMemberAccount_NotLikeSearch(String v, LikeSearchOption option)
        { regLSQ(CK_NLS, fRES(v), getCValueMemberAccount(), "MEMBER_ACCOUNT", option); }
        protected void regMemberAccount(ConditionKey k, Object v) { regQ(k, v, getCValueMemberAccount(), "MEMBER_ACCOUNT"); }
        protected abstract ConditionValue getCValueMemberAccount();

        public void SetMemberStatusCode_Equal(String v) { DoSetMemberStatusCode_Equal(fRES(v)); }
        protected void DoSetMemberStatusCode_Equal(String v) { regMemberStatusCode(CK_EQ, v); }
        public void SetMemberStatusCode_NotEqual(String v) { DoSetMemberStatusCode_NotEqual(fRES(v)); }
        protected void DoSetMemberStatusCode_NotEqual(String v) { regMemberStatusCode(CK_NES, v); }
        public void SetMemberStatusCode_InScope(IList<String> ls) { regINS<String>(CK_INS, cTL<String>(ls), getCValueMemberStatusCode(), "MEMBER_STATUS_CODE"); }
        public void SetMemberStatusCode_NotInScope(IList<String> ls) { regINS<String>(CK_NINS, cTL<String>(ls), getCValueMemberStatusCode(), "MEMBER_STATUS_CODE"); }
        public void SetMemberStatusCode_PrefixSearch(String v) { SetMemberStatusCode_LikeSearch(v, cLSOP()); }
        public void SetMemberStatusCode_LikeSearch(String v, LikeSearchOption option)
        { regLSQ(CK_LS, fRES(v), getCValueMemberStatusCode(), "MEMBER_STATUS_CODE", option); }
        public void SetMemberStatusCode_NotLikeSearch(String v, LikeSearchOption option)
        { regLSQ(CK_NLS, fRES(v), getCValueMemberStatusCode(), "MEMBER_STATUS_CODE", option); }
        public void InScopeMemberStatus(SubQuery<MemberStatusCB> subQuery) {
            assertObjectNotNull("subQuery<MemberStatusCB>", subQuery);
            MemberStatusCB cb = new MemberStatusCB(); cb.xsetupForInScopeRelation(this); subQuery.Invoke(cb);
            String subQueryPropertyName = keepMemberStatusCode_InScopeSubQuery_MemberStatus(cb.Query());
            registerInScopeSubQuery(cb.Query(), "MEMBER_STATUS_CODE", "MEMBER_STATUS_CODE", subQueryPropertyName);
        }
        public abstract String keepMemberStatusCode_InScopeSubQuery_MemberStatus(MemberStatusCQ subQuery);
        public void NotInScopeMemberStatus(SubQuery<MemberStatusCB> subQuery) {
            assertObjectNotNull("subQuery<MemberStatusCB>", subQuery);
            MemberStatusCB cb = new MemberStatusCB(); cb.xsetupForInScopeRelation(this); subQuery.Invoke(cb);
            String subQueryPropertyName = keepMemberStatusCode_NotInScopeSubQuery_MemberStatus(cb.Query());
            registerNotInScopeSubQuery(cb.Query(), "MEMBER_STATUS_CODE", "MEMBER_STATUS_CODE", subQueryPropertyName);
        }
        public abstract String keepMemberStatusCode_NotInScopeSubQuery_MemberStatus(MemberStatusCQ subQuery);
        protected void regMemberStatusCode(ConditionKey k, Object v) { regQ(k, v, getCValueMemberStatusCode(), "MEMBER_STATUS_CODE"); }
        protected abstract ConditionValue getCValueMemberStatusCode();

        public void SetFormalizedDatetime_Equal(DateTime? v) { regFormalizedDatetime(CK_EQ, v); }
        public void SetFormalizedDatetime_GreaterThan(DateTime? v) { regFormalizedDatetime(CK_GT, v); }
        public void SetFormalizedDatetime_LessThan(DateTime? v) { regFormalizedDatetime(CK_LT, v); }
        public void SetFormalizedDatetime_GreaterEqual(DateTime? v) { regFormalizedDatetime(CK_GE, v); }
        public void SetFormalizedDatetime_LessEqual(DateTime? v) { regFormalizedDatetime(CK_LE, v); }
        public void SetFormalizedDatetime_FromTo(DateTime? from, DateTime? to, FromToOption option)
        { regFTQ(from, to, getCValueFormalizedDatetime(), "FORMALIZED_DATETIME", option); }
        public void SetFormalizedDatetime_DateFromTo(DateTime? from, DateTime? to) { SetFormalizedDatetime_FromTo(from, to, new DateFromToOption()); }
        public void SetFormalizedDatetime_InScope(IList<DateTime?> ls) { regINS<DateTime?>(CK_INS, cTL<DateTime?>(ls), getCValueFormalizedDatetime(), "FORMALIZED_DATETIME"); }
        public void SetFormalizedDatetime_NotInScope(IList<DateTime?> ls) { regINS<DateTime?>(CK_NINS, cTL<DateTime?>(ls), getCValueFormalizedDatetime(), "FORMALIZED_DATETIME"); }
        public void SetFormalizedDatetime_IsNull() { regFormalizedDatetime(CK_ISN, DUMMY_OBJECT); }
        public void SetFormalizedDatetime_IsNotNull() { regFormalizedDatetime(CK_ISNN, DUMMY_OBJECT); }
        protected void regFormalizedDatetime(ConditionKey k, Object v) { regQ(k, v, getCValueFormalizedDatetime(), "FORMALIZED_DATETIME"); }
        protected abstract ConditionValue getCValueFormalizedDatetime();

        public void SetBirthdate_Equal(DateTime? v) { regBirthdate(CK_EQ, v); }
        public void SetBirthdate_GreaterThan(DateTime? v) { regBirthdate(CK_GT, v); }
        public void SetBirthdate_LessThan(DateTime? v) { regBirthdate(CK_LT, v); }
        public void SetBirthdate_GreaterEqual(DateTime? v) { regBirthdate(CK_GE, v); }
        public void SetBirthdate_LessEqual(DateTime? v) { regBirthdate(CK_LE, v); }
        public void SetBirthdate_FromTo(DateTime? from, DateTime? to, FromToOption option)
        { regFTQ(from, to, getCValueBirthdate(), "BIRTHDATE", option); }
        public void SetBirthdate_DateFromTo(DateTime? from, DateTime? to) { SetBirthdate_FromTo(from, to, new DateFromToOption()); }
        public void SetBirthdate_InScope(IList<DateTime?> ls) { regINS<DateTime?>(CK_INS, cTL<DateTime?>(ls), getCValueBirthdate(), "BIRTHDATE"); }
        public void SetBirthdate_NotInScope(IList<DateTime?> ls) { regINS<DateTime?>(CK_NINS, cTL<DateTime?>(ls), getCValueBirthdate(), "BIRTHDATE"); }
        public void SetBirthdate_IsNull() { regBirthdate(CK_ISN, DUMMY_OBJECT); }
        public void SetBirthdate_IsNotNull() { regBirthdate(CK_ISNN, DUMMY_OBJECT); }
        protected void regBirthdate(ConditionKey k, Object v) { regQ(k, v, getCValueBirthdate(), "BIRTHDATE"); }
        protected abstract ConditionValue getCValueBirthdate();

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

        public void SetVersionNo_Equal(long? v) { regVersionNo(CK_EQ, v); }
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
        public SSQFunction<VendorSynonymMemberCB> Scalar_Equal() {
            return xcreateSSQFunction("=");
        }

        public SSQFunction<VendorSynonymMemberCB> Scalar_NotEqual() {
            return xcreateSSQFunction("<>");
        }

        public SSQFunction<VendorSynonymMemberCB> Scalar_GreaterEqual() {
            return xcreateSSQFunction(">=");
        }

        public SSQFunction<VendorSynonymMemberCB> Scalar_GreaterThan() {
            return xcreateSSQFunction(">");
        }

        public SSQFunction<VendorSynonymMemberCB> Scalar_LessEqual() {
            return xcreateSSQFunction("<=");
        }

        public SSQFunction<VendorSynonymMemberCB> Scalar_LessThan() {
            return xcreateSSQFunction("<");
        }

        protected SSQFunction<VendorSynonymMemberCB> xcreateSSQFunction(String operand) {
            return new SSQFunction<VendorSynonymMemberCB>(delegate(String function, SubQuery<VendorSynonymMemberCB> subQuery) {
                xscalarSubQuery(function, subQuery, operand);
            });
        }

        protected void xscalarSubQuery(String function, SubQuery<VendorSynonymMemberCB> subQuery, String operand) {
            assertObjectNotNull("subQuery<VendorSynonymMemberCB>", subQuery);
            VendorSynonymMemberCB cb = new VendorSynonymMemberCB(); cb.xsetupForScalarCondition(this); subQuery.Invoke(cb);
            String subQueryPropertyName = keepScalarSubQuery(cb.Query()); // for saving query-value.
            registerScalarSubQuery(function, cb.Query(), subQueryPropertyName, operand);
        }
        public abstract String keepScalarSubQuery(VendorSynonymMemberCQ subQuery);

        // ===============================================================================
        //                                                                  MySelf InScope
        //                                                                  ==============
        public void MyselfInScope(SubQuery<VendorSynonymMemberCB> subQuery) {
            assertObjectNotNull("subQuery<VendorSynonymMemberCB>", subQuery);
            VendorSynonymMemberCB cb = new VendorSynonymMemberCB(); cb.xsetupForInScopeRelation(this); subQuery.Invoke(cb);
            String subQueryPropertyName = keepMyselfInScopeSubQuery(cb.Query()); // for saving query-value.
            registerInScopeSubQuery(cb.Query(), "MEMBER_ID", "MEMBER_ID", subQueryPropertyName);
        }
        public abstract String keepMyselfInScopeSubQuery(VendorSynonymMemberCQ subQuery);

        public override String ToString() { return xgetSqlClause().getClause(); }
    }
}
