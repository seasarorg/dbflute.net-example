
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
    public abstract class AbstractBsMemberCQ : AbstractConditionQuery {

        public AbstractBsMemberCQ(ConditionQuery childQuery, SqlClause sqlClause, String aliasName, int nestLevel)
            : base(childQuery, sqlClause, aliasName, nestLevel) {}

        public override String getTableDbName() { return "MEMBER"; }
        public override String getTableSqlName() { return "MEMBER"; }

        public void SetMemberId_Equal(long? v) { regMemberId(CK_EQ, v); }
        public void SetMemberId_GreaterThan(long? v) { regMemberId(CK_GT, v); }
        public void SetMemberId_LessThan(long? v) { regMemberId(CK_LT, v); }
        public void SetMemberId_GreaterEqual(long? v) { regMemberId(CK_GE, v); }
        public void SetMemberId_LessEqual(long? v) { regMemberId(CK_LE, v); }
        public void SetMemberId_InScope(IList<long?> ls) { regINS<long?>(CK_INS, cTL<long?>(ls), getCValueMemberId(), "MEMBER_ID"); }
        public void SetMemberId_NotInScope(IList<long?> ls) { regINS<long?>(CK_NINS, cTL<long?>(ls), getCValueMemberId(), "MEMBER_ID"); }
        public void ExistsMemberAddressList(SubQuery<MemberAddressCB> subQuery) {
            assertObjectNotNull("subQuery<MemberAddressCB>", subQuery);
            MemberAddressCB cb = new MemberAddressCB(); cb.xsetupForExistsReferrer(this); subQuery.Invoke(cb);
            String subQueryPropertyName = keepMemberId_ExistsSubQuery_MemberAddressList(cb.Query());
            registerExistsSubQuery(cb.Query(), "MEMBER_ID", "MEMBER_ID", subQueryPropertyName);
        }
        public abstract String keepMemberId_ExistsSubQuery_MemberAddressList(MemberAddressCQ subQuery);
        public void ExistsMemberLoginList(SubQuery<MemberLoginCB> subQuery) {
            assertObjectNotNull("subQuery<MemberLoginCB>", subQuery);
            MemberLoginCB cb = new MemberLoginCB(); cb.xsetupForExistsReferrer(this); subQuery.Invoke(cb);
            String subQueryPropertyName = keepMemberId_ExistsSubQuery_MemberLoginList(cb.Query());
            registerExistsSubQuery(cb.Query(), "MEMBER_ID", "MEMBER_ID", subQueryPropertyName);
        }
        public abstract String keepMemberId_ExistsSubQuery_MemberLoginList(MemberLoginCQ subQuery);
        public void ExistsMemberSecurityAsOne(SubQuery<MemberSecurityCB> subQuery) {
            assertObjectNotNull("subQuery<MemberSecurityCB>", subQuery);
            MemberSecurityCB cb = new MemberSecurityCB(); cb.xsetupForExistsReferrer(this); subQuery.Invoke(cb);
            String subQueryPropertyName = keepMemberId_ExistsSubQuery_MemberSecurityAsOne(cb.Query());
            registerExistsSubQuery(cb.Query(), "MEMBER_ID", "MEMBER_ID", subQueryPropertyName);
        }
        public abstract String keepMemberId_ExistsSubQuery_MemberSecurityAsOne(MemberSecurityCQ subQuery);
        public void ExistsMemberWithdrawalAsOne(SubQuery<MemberWithdrawalCB> subQuery) {
            assertObjectNotNull("subQuery<MemberWithdrawalCB>", subQuery);
            MemberWithdrawalCB cb = new MemberWithdrawalCB(); cb.xsetupForExistsReferrer(this); subQuery.Invoke(cb);
            String subQueryPropertyName = keepMemberId_ExistsSubQuery_MemberWithdrawalAsOne(cb.Query());
            registerExistsSubQuery(cb.Query(), "MEMBER_ID", "MEMBER_ID", subQueryPropertyName);
        }
        public abstract String keepMemberId_ExistsSubQuery_MemberWithdrawalAsOne(MemberWithdrawalCQ subQuery);
        public void ExistsPurchaseList(SubQuery<PurchaseCB> subQuery) {
            assertObjectNotNull("subQuery<PurchaseCB>", subQuery);
            PurchaseCB cb = new PurchaseCB(); cb.xsetupForExistsReferrer(this); subQuery.Invoke(cb);
            String subQueryPropertyName = keepMemberId_ExistsSubQuery_PurchaseList(cb.Query());
            registerExistsSubQuery(cb.Query(), "MEMBER_ID", "MEMBER_ID", subQueryPropertyName);
        }
        public abstract String keepMemberId_ExistsSubQuery_PurchaseList(PurchaseCQ subQuery);
        public void NotExistsMemberAddressList(SubQuery<MemberAddressCB> subQuery) {
            assertObjectNotNull("subQuery<MemberAddressCB>", subQuery);
            MemberAddressCB cb = new MemberAddressCB(); cb.xsetupForExistsReferrer(this); subQuery.Invoke(cb);
            String subQueryPropertyName = keepMemberId_NotExistsSubQuery_MemberAddressList(cb.Query());
            registerNotExistsSubQuery(cb.Query(), "MEMBER_ID", "MEMBER_ID", subQueryPropertyName);
        }
        public abstract String keepMemberId_NotExistsSubQuery_MemberAddressList(MemberAddressCQ subQuery);
        public void NotExistsMemberLoginList(SubQuery<MemberLoginCB> subQuery) {
            assertObjectNotNull("subQuery<MemberLoginCB>", subQuery);
            MemberLoginCB cb = new MemberLoginCB(); cb.xsetupForExistsReferrer(this); subQuery.Invoke(cb);
            String subQueryPropertyName = keepMemberId_NotExistsSubQuery_MemberLoginList(cb.Query());
            registerNotExistsSubQuery(cb.Query(), "MEMBER_ID", "MEMBER_ID", subQueryPropertyName);
        }
        public abstract String keepMemberId_NotExistsSubQuery_MemberLoginList(MemberLoginCQ subQuery);
        public void NotExistsMemberSecurityAsOne(SubQuery<MemberSecurityCB> subQuery) {
            assertObjectNotNull("subQuery<MemberSecurityCB>", subQuery);
            MemberSecurityCB cb = new MemberSecurityCB(); cb.xsetupForExistsReferrer(this); subQuery.Invoke(cb);
            String subQueryPropertyName = keepMemberId_NotExistsSubQuery_MemberSecurityAsOne(cb.Query());
            registerNotExistsSubQuery(cb.Query(), "MEMBER_ID", "MEMBER_ID", subQueryPropertyName);
        }
        public abstract String keepMemberId_NotExistsSubQuery_MemberSecurityAsOne(MemberSecurityCQ subQuery);
        public void NotExistsMemberWithdrawalAsOne(SubQuery<MemberWithdrawalCB> subQuery) {
            assertObjectNotNull("subQuery<MemberWithdrawalCB>", subQuery);
            MemberWithdrawalCB cb = new MemberWithdrawalCB(); cb.xsetupForExistsReferrer(this); subQuery.Invoke(cb);
            String subQueryPropertyName = keepMemberId_NotExistsSubQuery_MemberWithdrawalAsOne(cb.Query());
            registerNotExistsSubQuery(cb.Query(), "MEMBER_ID", "MEMBER_ID", subQueryPropertyName);
        }
        public abstract String keepMemberId_NotExistsSubQuery_MemberWithdrawalAsOne(MemberWithdrawalCQ subQuery);
        public void NotExistsPurchaseList(SubQuery<PurchaseCB> subQuery) {
            assertObjectNotNull("subQuery<PurchaseCB>", subQuery);
            PurchaseCB cb = new PurchaseCB(); cb.xsetupForExistsReferrer(this); subQuery.Invoke(cb);
            String subQueryPropertyName = keepMemberId_NotExistsSubQuery_PurchaseList(cb.Query());
            registerNotExistsSubQuery(cb.Query(), "MEMBER_ID", "MEMBER_ID", subQueryPropertyName);
        }
        public abstract String keepMemberId_NotExistsSubQuery_PurchaseList(PurchaseCQ subQuery);
        public void InScopeMemberAddressList(SubQuery<MemberAddressCB> subQuery) {
            assertObjectNotNull("subQuery<MemberAddressCB>", subQuery);
            MemberAddressCB cb = new MemberAddressCB(); cb.xsetupForInScopeRelation(this); subQuery.Invoke(cb);
            String subQueryPropertyName = keepMemberId_InScopeSubQuery_MemberAddressList(cb.Query());
            registerInScopeSubQuery(cb.Query(), "MEMBER_ID", "MEMBER_ID", subQueryPropertyName);
        }
        public abstract String keepMemberId_InScopeSubQuery_MemberAddressList(MemberAddressCQ subQuery);
        public void InScopeMemberLoginList(SubQuery<MemberLoginCB> subQuery) {
            assertObjectNotNull("subQuery<MemberLoginCB>", subQuery);
            MemberLoginCB cb = new MemberLoginCB(); cb.xsetupForInScopeRelation(this); subQuery.Invoke(cb);
            String subQueryPropertyName = keepMemberId_InScopeSubQuery_MemberLoginList(cb.Query());
            registerInScopeSubQuery(cb.Query(), "MEMBER_ID", "MEMBER_ID", subQueryPropertyName);
        }
        public abstract String keepMemberId_InScopeSubQuery_MemberLoginList(MemberLoginCQ subQuery);
        public void InScopeMemberSecurityAsOne(SubQuery<MemberSecurityCB> subQuery) {
            assertObjectNotNull("subQuery<MemberSecurityCB>", subQuery);
            MemberSecurityCB cb = new MemberSecurityCB(); cb.xsetupForInScopeRelation(this); subQuery.Invoke(cb);
            String subQueryPropertyName = keepMemberId_InScopeSubQuery_MemberSecurityAsOne(cb.Query());
            registerInScopeSubQuery(cb.Query(), "MEMBER_ID", "MEMBER_ID", subQueryPropertyName);
        }
        public abstract String keepMemberId_InScopeSubQuery_MemberSecurityAsOne(MemberSecurityCQ subQuery);
        public void InScopeMemberWithdrawalAsOne(SubQuery<MemberWithdrawalCB> subQuery) {
            assertObjectNotNull("subQuery<MemberWithdrawalCB>", subQuery);
            MemberWithdrawalCB cb = new MemberWithdrawalCB(); cb.xsetupForInScopeRelation(this); subQuery.Invoke(cb);
            String subQueryPropertyName = keepMemberId_InScopeSubQuery_MemberWithdrawalAsOne(cb.Query());
            registerInScopeSubQuery(cb.Query(), "MEMBER_ID", "MEMBER_ID", subQueryPropertyName);
        }
        public abstract String keepMemberId_InScopeSubQuery_MemberWithdrawalAsOne(MemberWithdrawalCQ subQuery);
        public void InScopePurchaseList(SubQuery<PurchaseCB> subQuery) {
            assertObjectNotNull("subQuery<PurchaseCB>", subQuery);
            PurchaseCB cb = new PurchaseCB(); cb.xsetupForInScopeRelation(this); subQuery.Invoke(cb);
            String subQueryPropertyName = keepMemberId_InScopeSubQuery_PurchaseList(cb.Query());
            registerInScopeSubQuery(cb.Query(), "MEMBER_ID", "MEMBER_ID", subQueryPropertyName);
        }
        public abstract String keepMemberId_InScopeSubQuery_PurchaseList(PurchaseCQ subQuery);
        public void NotInScopeMemberAddressList(SubQuery<MemberAddressCB> subQuery) {
            assertObjectNotNull("subQuery<MemberAddressCB>", subQuery);
            MemberAddressCB cb = new MemberAddressCB(); cb.xsetupForInScopeRelation(this); subQuery.Invoke(cb);
            String subQueryPropertyName = keepMemberId_NotInScopeSubQuery_MemberAddressList(cb.Query());
            registerNotInScopeSubQuery(cb.Query(), "MEMBER_ID", "MEMBER_ID", subQueryPropertyName);
        }
        public abstract String keepMemberId_NotInScopeSubQuery_MemberAddressList(MemberAddressCQ subQuery);
        public void NotInScopeMemberLoginList(SubQuery<MemberLoginCB> subQuery) {
            assertObjectNotNull("subQuery<MemberLoginCB>", subQuery);
            MemberLoginCB cb = new MemberLoginCB(); cb.xsetupForInScopeRelation(this); subQuery.Invoke(cb);
            String subQueryPropertyName = keepMemberId_NotInScopeSubQuery_MemberLoginList(cb.Query());
            registerNotInScopeSubQuery(cb.Query(), "MEMBER_ID", "MEMBER_ID", subQueryPropertyName);
        }
        public abstract String keepMemberId_NotInScopeSubQuery_MemberLoginList(MemberLoginCQ subQuery);
        public void NotInScopeMemberSecurityAsOne(SubQuery<MemberSecurityCB> subQuery) {
            assertObjectNotNull("subQuery<MemberSecurityCB>", subQuery);
            MemberSecurityCB cb = new MemberSecurityCB(); cb.xsetupForInScopeRelation(this); subQuery.Invoke(cb);
            String subQueryPropertyName = keepMemberId_NotInScopeSubQuery_MemberSecurityAsOne(cb.Query());
            registerNotInScopeSubQuery(cb.Query(), "MEMBER_ID", "MEMBER_ID", subQueryPropertyName);
        }
        public abstract String keepMemberId_NotInScopeSubQuery_MemberSecurityAsOne(MemberSecurityCQ subQuery);
        public void NotInScopeMemberWithdrawalAsOne(SubQuery<MemberWithdrawalCB> subQuery) {
            assertObjectNotNull("subQuery<MemberWithdrawalCB>", subQuery);
            MemberWithdrawalCB cb = new MemberWithdrawalCB(); cb.xsetupForInScopeRelation(this); subQuery.Invoke(cb);
            String subQueryPropertyName = keepMemberId_NotInScopeSubQuery_MemberWithdrawalAsOne(cb.Query());
            registerNotInScopeSubQuery(cb.Query(), "MEMBER_ID", "MEMBER_ID", subQueryPropertyName);
        }
        public abstract String keepMemberId_NotInScopeSubQuery_MemberWithdrawalAsOne(MemberWithdrawalCQ subQuery);
        public void NotInScopePurchaseList(SubQuery<PurchaseCB> subQuery) {
            assertObjectNotNull("subQuery<PurchaseCB>", subQuery);
            PurchaseCB cb = new PurchaseCB(); cb.xsetupForInScopeRelation(this); subQuery.Invoke(cb);
            String subQueryPropertyName = keepMemberId_NotInScopeSubQuery_PurchaseList(cb.Query());
            registerNotInScopeSubQuery(cb.Query(), "MEMBER_ID", "MEMBER_ID", subQueryPropertyName);
        }
        public abstract String keepMemberId_NotInScopeSubQuery_PurchaseList(PurchaseCQ subQuery);
        public void xsderiveMemberAddressList(String function, SubQuery<MemberAddressCB> subQuery, String aliasName) {
            assertObjectNotNull("subQuery<MemberAddressCB>", subQuery);
            MemberAddressCB cb = new MemberAddressCB(); cb.xsetupForDerivedReferrer(this); subQuery.Invoke(cb);
            String subQueryPropertyName = keepMemberId_SpecifyDerivedReferrer_MemberAddressList(cb.Query());
            registerSpecifyDerivedReferrer(function, cb.Query(), "MEMBER_ID", "MEMBER_ID", subQueryPropertyName, aliasName);
        }
        abstract public String keepMemberId_SpecifyDerivedReferrer_MemberAddressList(MemberAddressCQ subQuery);
        public void xsderiveMemberLoginList(String function, SubQuery<MemberLoginCB> subQuery, String aliasName) {
            assertObjectNotNull("subQuery<MemberLoginCB>", subQuery);
            MemberLoginCB cb = new MemberLoginCB(); cb.xsetupForDerivedReferrer(this); subQuery.Invoke(cb);
            String subQueryPropertyName = keepMemberId_SpecifyDerivedReferrer_MemberLoginList(cb.Query());
            registerSpecifyDerivedReferrer(function, cb.Query(), "MEMBER_ID", "MEMBER_ID", subQueryPropertyName, aliasName);
        }
        abstract public String keepMemberId_SpecifyDerivedReferrer_MemberLoginList(MemberLoginCQ subQuery);
        public void xsderivePurchaseList(String function, SubQuery<PurchaseCB> subQuery, String aliasName) {
            assertObjectNotNull("subQuery<PurchaseCB>", subQuery);
            PurchaseCB cb = new PurchaseCB(); cb.xsetupForDerivedReferrer(this); subQuery.Invoke(cb);
            String subQueryPropertyName = keepMemberId_SpecifyDerivedReferrer_PurchaseList(cb.Query());
            registerSpecifyDerivedReferrer(function, cb.Query(), "MEMBER_ID", "MEMBER_ID", subQueryPropertyName, aliasName);
        }
        abstract public String keepMemberId_SpecifyDerivedReferrer_PurchaseList(PurchaseCQ subQuery);

        public QDRFunction<MemberAddressCB> DerivedMemberAddressList() {
            return xcreateQDRFunctionMemberAddressList();
        }
        protected QDRFunction<MemberAddressCB> xcreateQDRFunctionMemberAddressList() {
            return new QDRFunction<MemberAddressCB>(delegate(String function, SubQuery<MemberAddressCB> subQuery, String operand, Object value) {
                xqderiveMemberAddressList(function, subQuery, operand, value);
            });
        }
        public void xqderiveMemberAddressList(String function, SubQuery<MemberAddressCB> subQuery, String operand, Object value) {
            assertObjectNotNull("subQuery<MemberAddressCB>", subQuery);
            MemberAddressCB cb = new MemberAddressCB(); cb.xsetupForDerivedReferrer(this); subQuery.Invoke(cb);
            String subQueryPropertyName = keepMemberId_QueryDerivedReferrer_MemberAddressList(cb.Query()); // for saving query-value.
            String parameterPropertyName = keepMemberId_QueryDerivedReferrer_MemberAddressListParameter(value);
            registerQueryDerivedReferrer(function, cb.Query(), "MEMBER_ID", "MEMBER_ID", subQueryPropertyName, operand, value, parameterPropertyName);
        }
        public abstract String keepMemberId_QueryDerivedReferrer_MemberAddressList(MemberAddressCQ subQuery);
        public abstract String keepMemberId_QueryDerivedReferrer_MemberAddressListParameter(Object parameterValue);

        public QDRFunction<MemberLoginCB> DerivedMemberLoginList() {
            return xcreateQDRFunctionMemberLoginList();
        }
        protected QDRFunction<MemberLoginCB> xcreateQDRFunctionMemberLoginList() {
            return new QDRFunction<MemberLoginCB>(delegate(String function, SubQuery<MemberLoginCB> subQuery, String operand, Object value) {
                xqderiveMemberLoginList(function, subQuery, operand, value);
            });
        }
        public void xqderiveMemberLoginList(String function, SubQuery<MemberLoginCB> subQuery, String operand, Object value) {
            assertObjectNotNull("subQuery<MemberLoginCB>", subQuery);
            MemberLoginCB cb = new MemberLoginCB(); cb.xsetupForDerivedReferrer(this); subQuery.Invoke(cb);
            String subQueryPropertyName = keepMemberId_QueryDerivedReferrer_MemberLoginList(cb.Query()); // for saving query-value.
            String parameterPropertyName = keepMemberId_QueryDerivedReferrer_MemberLoginListParameter(value);
            registerQueryDerivedReferrer(function, cb.Query(), "MEMBER_ID", "MEMBER_ID", subQueryPropertyName, operand, value, parameterPropertyName);
        }
        public abstract String keepMemberId_QueryDerivedReferrer_MemberLoginList(MemberLoginCQ subQuery);
        public abstract String keepMemberId_QueryDerivedReferrer_MemberLoginListParameter(Object parameterValue);

        public QDRFunction<PurchaseCB> DerivedPurchaseList() {
            return xcreateQDRFunctionPurchaseList();
        }
        protected QDRFunction<PurchaseCB> xcreateQDRFunctionPurchaseList() {
            return new QDRFunction<PurchaseCB>(delegate(String function, SubQuery<PurchaseCB> subQuery, String operand, Object value) {
                xqderivePurchaseList(function, subQuery, operand, value);
            });
        }
        public void xqderivePurchaseList(String function, SubQuery<PurchaseCB> subQuery, String operand, Object value) {
            assertObjectNotNull("subQuery<PurchaseCB>", subQuery);
            PurchaseCB cb = new PurchaseCB(); cb.xsetupForDerivedReferrer(this); subQuery.Invoke(cb);
            String subQueryPropertyName = keepMemberId_QueryDerivedReferrer_PurchaseList(cb.Query()); // for saving query-value.
            String parameterPropertyName = keepMemberId_QueryDerivedReferrer_PurchaseListParameter(value);
            registerQueryDerivedReferrer(function, cb.Query(), "MEMBER_ID", "MEMBER_ID", subQueryPropertyName, operand, value, parameterPropertyName);
        }
        public abstract String keepMemberId_QueryDerivedReferrer_PurchaseList(PurchaseCQ subQuery);
        public abstract String keepMemberId_QueryDerivedReferrer_PurchaseListParameter(Object parameterValue);
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
        /// <summary>
        /// Set the value of Provisional of memberStatusCode as equal. { = }
        /// Provisional: 仮会員を示す
        /// </summary>
        public void SetMemberStatusCode_Equal_Provisional() {
            DoSetMemberStatusCode_Equal(CDef.MemberStatus.Provisional.Code);
        }
        /// <summary>
        /// Set the value of Formalized of memberStatusCode as equal. { = }
        /// Formalized: 正式会員を示す
        /// </summary>
        public void SetMemberStatusCode_Equal_Formalized() {
            DoSetMemberStatusCode_Equal(CDef.MemberStatus.Formalized.Code);
        }
        /// <summary>
        /// Set the value of Withdrawal of memberStatusCode as equal. { = }
        /// Withdrawal: 退会会員を示す
        /// </summary>
        public void SetMemberStatusCode_Equal_Withdrawal() {
            DoSetMemberStatusCode_Equal(CDef.MemberStatus.Withdrawal.Code);
        }
        protected void DoSetMemberStatusCode_Equal(String v) { regMemberStatusCode(CK_EQ, v); }
        public void SetMemberStatusCode_NotEqual(String v) { DoSetMemberStatusCode_NotEqual(fRES(v)); }
        /// <summary>
        /// Set the value of Provisional of memberStatusCode as notEqual. { &lt;&gt; }
        /// Provisional: 仮会員を示す
        /// </summary>
        public void SetMemberStatusCode_NotEqual_Provisional() {
            DoSetMemberStatusCode_NotEqual(CDef.MemberStatus.Provisional.Code);
        }
        /// <summary>
        /// Set the value of Formalized of memberStatusCode as notEqual. { &lt;&gt; }
        /// Formalized: 正式会員を示す
        /// </summary>
        public void SetMemberStatusCode_NotEqual_Formalized() {
            DoSetMemberStatusCode_NotEqual(CDef.MemberStatus.Formalized.Code);
        }
        /// <summary>
        /// Set the value of Withdrawal of memberStatusCode as notEqual. { &lt;&gt; }
        /// Withdrawal: 退会会員を示す
        /// </summary>
        public void SetMemberStatusCode_NotEqual_Withdrawal() {
            DoSetMemberStatusCode_NotEqual(CDef.MemberStatus.Withdrawal.Code);
        }
        protected void DoSetMemberStatusCode_NotEqual(String v) { regMemberStatusCode(CK_NES, v); }
        public void SetMemberStatusCode_InScope(IList<String> ls) { regINS<String>(CK_INS, cTL<String>(ls), getCValueMemberStatusCode(), "MEMBER_STATUS_CODE"); }
        public void SetMemberStatusCode_NotInScope(IList<String> ls) { regINS<String>(CK_NINS, cTL<String>(ls), getCValueMemberStatusCode(), "MEMBER_STATUS_CODE"); }
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
        public SSQFunction<MemberCB> Scalar_Equal() {
            return xcreateSSQFunction("=");
        }

        public SSQFunction<MemberCB> Scalar_NotEqual() {
            return xcreateSSQFunction("<>");
        }

        public SSQFunction<MemberCB> Scalar_GreaterEqual() {
            return xcreateSSQFunction(">=");
        }

        public SSQFunction<MemberCB> Scalar_GreaterThan() {
            return xcreateSSQFunction(">");
        }

        public SSQFunction<MemberCB> Scalar_LessEqual() {
            return xcreateSSQFunction("<=");
        }

        public SSQFunction<MemberCB> Scalar_LessThan() {
            return xcreateSSQFunction("<");
        }

        protected SSQFunction<MemberCB> xcreateSSQFunction(String operand) {
            return new SSQFunction<MemberCB>(delegate(String function, SubQuery<MemberCB> subQuery) {
                xscalarSubQuery(function, subQuery, operand);
            });
        }

        protected void xscalarSubQuery(String function, SubQuery<MemberCB> subQuery, String operand) {
            assertObjectNotNull("subQuery<MemberCB>", subQuery);
            MemberCB cb = new MemberCB(); cb.xsetupForScalarCondition(this); subQuery.Invoke(cb);
            String subQueryPropertyName = keepScalarSubQuery(cb.Query()); // for saving query-value.
            registerScalarSubQuery(function, cb.Query(), subQueryPropertyName, operand);
        }
        public abstract String keepScalarSubQuery(MemberCQ subQuery);

        // ===============================================================================
        //                                                                  MySelf InScope
        //                                                                  ==============
        public void MyselfInScope(SubQuery<MemberCB> subQuery) {
            assertObjectNotNull("subQuery<MemberCB>", subQuery);
            MemberCB cb = new MemberCB(); cb.xsetupForInScopeRelation(this); subQuery.Invoke(cb);
            String subQueryPropertyName = keepMyselfInScopeSubQuery(cb.Query()); // for saving query-value.
            registerInScopeSubQuery(cb.Query(), "MEMBER_ID", "MEMBER_ID", subQueryPropertyName);
        }
        public abstract String keepMyselfInScopeSubQuery(MemberCQ subQuery);

        public override String ToString() { return xgetSqlClause().getClause(); }
    }
}
