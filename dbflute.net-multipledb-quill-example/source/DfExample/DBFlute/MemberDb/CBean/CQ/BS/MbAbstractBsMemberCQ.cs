
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
    public abstract class MbAbstractBsMemberCQ : MbAbstractConditionQuery {

        public MbAbstractBsMemberCQ(MbConditionQuery childQuery, MbSqlClause sqlClause, String aliasName, int nestLevel)
            : base(childQuery, sqlClause, aliasName, nestLevel) {}

        public override String getTableDbName() { return "member"; }
        public override String getTableSqlName() { return "member"; }

        public void SetMemberId_Equal(int? v) { regMemberId(CK_EQ, v); }
        public void SetMemberId_GreaterThan(int? v) { regMemberId(CK_GT, v); }
        public void SetMemberId_LessThan(int? v) { regMemberId(CK_LT, v); }
        public void SetMemberId_GreaterEqual(int? v) { regMemberId(CK_GE, v); }
        public void SetMemberId_LessEqual(int? v) { regMemberId(CK_LE, v); }
        public void SetMemberId_InScope(IList<int?> ls) { regINS<int?>(CK_INS, cTL<int?>(ls), getCValueMemberId(), "MEMBER_ID"); }
        public void SetMemberId_NotInScope(IList<int?> ls) { regINS<int?>(CK_NINS, cTL<int?>(ls), getCValueMemberId(), "MEMBER_ID"); }
        public void ExistsMemberAddressList(MbSubQuery<MbMemberAddressCB> subQuery) {
            assertObjectNotNull("subQuery<MbMemberAddressCB>", subQuery);
            MbMemberAddressCB cb = new MbMemberAddressCB(); cb.xsetupForExistsReferrer(this); subQuery.Invoke(cb);
            String subQueryPropertyName = keepMemberId_ExistsSubQuery_MemberAddressList(cb.Query());
            registerExistsSubQuery(cb.Query(), "MEMBER_ID", "MEMBER_ID", subQueryPropertyName);
        }
        public abstract String keepMemberId_ExistsSubQuery_MemberAddressList(MbMemberAddressCQ subQuery);
        public void ExistsMemberLoginList(MbSubQuery<MbMemberLoginCB> subQuery) {
            assertObjectNotNull("subQuery<MbMemberLoginCB>", subQuery);
            MbMemberLoginCB cb = new MbMemberLoginCB(); cb.xsetupForExistsReferrer(this); subQuery.Invoke(cb);
            String subQueryPropertyName = keepMemberId_ExistsSubQuery_MemberLoginList(cb.Query());
            registerExistsSubQuery(cb.Query(), "MEMBER_ID", "MEMBER_ID", subQueryPropertyName);
        }
        public abstract String keepMemberId_ExistsSubQuery_MemberLoginList(MbMemberLoginCQ subQuery);
        public void ExistsMemberSecurityAsOne(MbSubQuery<MbMemberSecurityCB> subQuery) {
            assertObjectNotNull("subQuery<MbMemberSecurityCB>", subQuery);
            MbMemberSecurityCB cb = new MbMemberSecurityCB(); cb.xsetupForExistsReferrer(this); subQuery.Invoke(cb);
            String subQueryPropertyName = keepMemberId_ExistsSubQuery_MemberSecurityAsOne(cb.Query());
            registerExistsSubQuery(cb.Query(), "MEMBER_ID", "MEMBER_ID", subQueryPropertyName);
        }
        public abstract String keepMemberId_ExistsSubQuery_MemberSecurityAsOne(MbMemberSecurityCQ subQuery);
        public void ExistsMemberWithdrawalAsOne(MbSubQuery<MbMemberWithdrawalCB> subQuery) {
            assertObjectNotNull("subQuery<MbMemberWithdrawalCB>", subQuery);
            MbMemberWithdrawalCB cb = new MbMemberWithdrawalCB(); cb.xsetupForExistsReferrer(this); subQuery.Invoke(cb);
            String subQueryPropertyName = keepMemberId_ExistsSubQuery_MemberWithdrawalAsOne(cb.Query());
            registerExistsSubQuery(cb.Query(), "MEMBER_ID", "MEMBER_ID", subQueryPropertyName);
        }
        public abstract String keepMemberId_ExistsSubQuery_MemberWithdrawalAsOne(MbMemberWithdrawalCQ subQuery);
        public void ExistsPurchaseList(MbSubQuery<MbPurchaseCB> subQuery) {
            assertObjectNotNull("subQuery<MbPurchaseCB>", subQuery);
            MbPurchaseCB cb = new MbPurchaseCB(); cb.xsetupForExistsReferrer(this); subQuery.Invoke(cb);
            String subQueryPropertyName = keepMemberId_ExistsSubQuery_PurchaseList(cb.Query());
            registerExistsSubQuery(cb.Query(), "MEMBER_ID", "MEMBER_ID", subQueryPropertyName);
        }
        public abstract String keepMemberId_ExistsSubQuery_PurchaseList(MbPurchaseCQ subQuery);
        public void NotExistsMemberAddressList(MbSubQuery<MbMemberAddressCB> subQuery) {
            assertObjectNotNull("subQuery<MbMemberAddressCB>", subQuery);
            MbMemberAddressCB cb = new MbMemberAddressCB(); cb.xsetupForExistsReferrer(this); subQuery.Invoke(cb);
            String subQueryPropertyName = keepMemberId_NotExistsSubQuery_MemberAddressList(cb.Query());
            registerNotExistsSubQuery(cb.Query(), "MEMBER_ID", "MEMBER_ID", subQueryPropertyName);
        }
        public abstract String keepMemberId_NotExistsSubQuery_MemberAddressList(MbMemberAddressCQ subQuery);
        public void NotExistsMemberLoginList(MbSubQuery<MbMemberLoginCB> subQuery) {
            assertObjectNotNull("subQuery<MbMemberLoginCB>", subQuery);
            MbMemberLoginCB cb = new MbMemberLoginCB(); cb.xsetupForExistsReferrer(this); subQuery.Invoke(cb);
            String subQueryPropertyName = keepMemberId_NotExistsSubQuery_MemberLoginList(cb.Query());
            registerNotExistsSubQuery(cb.Query(), "MEMBER_ID", "MEMBER_ID", subQueryPropertyName);
        }
        public abstract String keepMemberId_NotExistsSubQuery_MemberLoginList(MbMemberLoginCQ subQuery);
        public void NotExistsMemberSecurityAsOne(MbSubQuery<MbMemberSecurityCB> subQuery) {
            assertObjectNotNull("subQuery<MbMemberSecurityCB>", subQuery);
            MbMemberSecurityCB cb = new MbMemberSecurityCB(); cb.xsetupForExistsReferrer(this); subQuery.Invoke(cb);
            String subQueryPropertyName = keepMemberId_NotExistsSubQuery_MemberSecurityAsOne(cb.Query());
            registerNotExistsSubQuery(cb.Query(), "MEMBER_ID", "MEMBER_ID", subQueryPropertyName);
        }
        public abstract String keepMemberId_NotExistsSubQuery_MemberSecurityAsOne(MbMemberSecurityCQ subQuery);
        public void NotExistsMemberWithdrawalAsOne(MbSubQuery<MbMemberWithdrawalCB> subQuery) {
            assertObjectNotNull("subQuery<MbMemberWithdrawalCB>", subQuery);
            MbMemberWithdrawalCB cb = new MbMemberWithdrawalCB(); cb.xsetupForExistsReferrer(this); subQuery.Invoke(cb);
            String subQueryPropertyName = keepMemberId_NotExistsSubQuery_MemberWithdrawalAsOne(cb.Query());
            registerNotExistsSubQuery(cb.Query(), "MEMBER_ID", "MEMBER_ID", subQueryPropertyName);
        }
        public abstract String keepMemberId_NotExistsSubQuery_MemberWithdrawalAsOne(MbMemberWithdrawalCQ subQuery);
        public void NotExistsPurchaseList(MbSubQuery<MbPurchaseCB> subQuery) {
            assertObjectNotNull("subQuery<MbPurchaseCB>", subQuery);
            MbPurchaseCB cb = new MbPurchaseCB(); cb.xsetupForExistsReferrer(this); subQuery.Invoke(cb);
            String subQueryPropertyName = keepMemberId_NotExistsSubQuery_PurchaseList(cb.Query());
            registerNotExistsSubQuery(cb.Query(), "MEMBER_ID", "MEMBER_ID", subQueryPropertyName);
        }
        public abstract String keepMemberId_NotExistsSubQuery_PurchaseList(MbPurchaseCQ subQuery);
        public void InScopeMemberAddressList(MbSubQuery<MbMemberAddressCB> subQuery) {
            assertObjectNotNull("subQuery<MbMemberAddressCB>", subQuery);
            MbMemberAddressCB cb = new MbMemberAddressCB(); cb.xsetupForInScopeRelation(this); subQuery.Invoke(cb);
            String subQueryPropertyName = keepMemberId_InScopeSubQuery_MemberAddressList(cb.Query());
            registerInScopeSubQuery(cb.Query(), "MEMBER_ID", "MEMBER_ID", subQueryPropertyName);
        }
        public abstract String keepMemberId_InScopeSubQuery_MemberAddressList(MbMemberAddressCQ subQuery);
        public void InScopeMemberLoginList(MbSubQuery<MbMemberLoginCB> subQuery) {
            assertObjectNotNull("subQuery<MbMemberLoginCB>", subQuery);
            MbMemberLoginCB cb = new MbMemberLoginCB(); cb.xsetupForInScopeRelation(this); subQuery.Invoke(cb);
            String subQueryPropertyName = keepMemberId_InScopeSubQuery_MemberLoginList(cb.Query());
            registerInScopeSubQuery(cb.Query(), "MEMBER_ID", "MEMBER_ID", subQueryPropertyName);
        }
        public abstract String keepMemberId_InScopeSubQuery_MemberLoginList(MbMemberLoginCQ subQuery);
        public void InScopeMemberSecurityAsOne(MbSubQuery<MbMemberSecurityCB> subQuery) {
            assertObjectNotNull("subQuery<MbMemberSecurityCB>", subQuery);
            MbMemberSecurityCB cb = new MbMemberSecurityCB(); cb.xsetupForInScopeRelation(this); subQuery.Invoke(cb);
            String subQueryPropertyName = keepMemberId_InScopeSubQuery_MemberSecurityAsOne(cb.Query());
            registerInScopeSubQuery(cb.Query(), "MEMBER_ID", "MEMBER_ID", subQueryPropertyName);
        }
        public abstract String keepMemberId_InScopeSubQuery_MemberSecurityAsOne(MbMemberSecurityCQ subQuery);
        public void InScopeMemberWithdrawalAsOne(MbSubQuery<MbMemberWithdrawalCB> subQuery) {
            assertObjectNotNull("subQuery<MbMemberWithdrawalCB>", subQuery);
            MbMemberWithdrawalCB cb = new MbMemberWithdrawalCB(); cb.xsetupForInScopeRelation(this); subQuery.Invoke(cb);
            String subQueryPropertyName = keepMemberId_InScopeSubQuery_MemberWithdrawalAsOne(cb.Query());
            registerInScopeSubQuery(cb.Query(), "MEMBER_ID", "MEMBER_ID", subQueryPropertyName);
        }
        public abstract String keepMemberId_InScopeSubQuery_MemberWithdrawalAsOne(MbMemberWithdrawalCQ subQuery);
        public void InScopePurchaseList(MbSubQuery<MbPurchaseCB> subQuery) {
            assertObjectNotNull("subQuery<MbPurchaseCB>", subQuery);
            MbPurchaseCB cb = new MbPurchaseCB(); cb.xsetupForInScopeRelation(this); subQuery.Invoke(cb);
            String subQueryPropertyName = keepMemberId_InScopeSubQuery_PurchaseList(cb.Query());
            registerInScopeSubQuery(cb.Query(), "MEMBER_ID", "MEMBER_ID", subQueryPropertyName);
        }
        public abstract String keepMemberId_InScopeSubQuery_PurchaseList(MbPurchaseCQ subQuery);
        public void NotInScopeMemberAddressList(MbSubQuery<MbMemberAddressCB> subQuery) {
            assertObjectNotNull("subQuery<MbMemberAddressCB>", subQuery);
            MbMemberAddressCB cb = new MbMemberAddressCB(); cb.xsetupForInScopeRelation(this); subQuery.Invoke(cb);
            String subQueryPropertyName = keepMemberId_NotInScopeSubQuery_MemberAddressList(cb.Query());
            registerNotInScopeSubQuery(cb.Query(), "MEMBER_ID", "MEMBER_ID", subQueryPropertyName);
        }
        public abstract String keepMemberId_NotInScopeSubQuery_MemberAddressList(MbMemberAddressCQ subQuery);
        public void NotInScopeMemberLoginList(MbSubQuery<MbMemberLoginCB> subQuery) {
            assertObjectNotNull("subQuery<MbMemberLoginCB>", subQuery);
            MbMemberLoginCB cb = new MbMemberLoginCB(); cb.xsetupForInScopeRelation(this); subQuery.Invoke(cb);
            String subQueryPropertyName = keepMemberId_NotInScopeSubQuery_MemberLoginList(cb.Query());
            registerNotInScopeSubQuery(cb.Query(), "MEMBER_ID", "MEMBER_ID", subQueryPropertyName);
        }
        public abstract String keepMemberId_NotInScopeSubQuery_MemberLoginList(MbMemberLoginCQ subQuery);
        public void NotInScopeMemberSecurityAsOne(MbSubQuery<MbMemberSecurityCB> subQuery) {
            assertObjectNotNull("subQuery<MbMemberSecurityCB>", subQuery);
            MbMemberSecurityCB cb = new MbMemberSecurityCB(); cb.xsetupForInScopeRelation(this); subQuery.Invoke(cb);
            String subQueryPropertyName = keepMemberId_NotInScopeSubQuery_MemberSecurityAsOne(cb.Query());
            registerNotInScopeSubQuery(cb.Query(), "MEMBER_ID", "MEMBER_ID", subQueryPropertyName);
        }
        public abstract String keepMemberId_NotInScopeSubQuery_MemberSecurityAsOne(MbMemberSecurityCQ subQuery);
        public void NotInScopeMemberWithdrawalAsOne(MbSubQuery<MbMemberWithdrawalCB> subQuery) {
            assertObjectNotNull("subQuery<MbMemberWithdrawalCB>", subQuery);
            MbMemberWithdrawalCB cb = new MbMemberWithdrawalCB(); cb.xsetupForInScopeRelation(this); subQuery.Invoke(cb);
            String subQueryPropertyName = keepMemberId_NotInScopeSubQuery_MemberWithdrawalAsOne(cb.Query());
            registerNotInScopeSubQuery(cb.Query(), "MEMBER_ID", "MEMBER_ID", subQueryPropertyName);
        }
        public abstract String keepMemberId_NotInScopeSubQuery_MemberWithdrawalAsOne(MbMemberWithdrawalCQ subQuery);
        public void NotInScopePurchaseList(MbSubQuery<MbPurchaseCB> subQuery) {
            assertObjectNotNull("subQuery<MbPurchaseCB>", subQuery);
            MbPurchaseCB cb = new MbPurchaseCB(); cb.xsetupForInScopeRelation(this); subQuery.Invoke(cb);
            String subQueryPropertyName = keepMemberId_NotInScopeSubQuery_PurchaseList(cb.Query());
            registerNotInScopeSubQuery(cb.Query(), "MEMBER_ID", "MEMBER_ID", subQueryPropertyName);
        }
        public abstract String keepMemberId_NotInScopeSubQuery_PurchaseList(MbPurchaseCQ subQuery);
        public void xsderiveMemberAddressList(String function, MbSubQuery<MbMemberAddressCB> subQuery, String aliasName) {
            assertObjectNotNull("subQuery<MbMemberAddressCB>", subQuery);
            MbMemberAddressCB cb = new MbMemberAddressCB(); cb.xsetupForDerivedReferrer(this); subQuery.Invoke(cb);
            String subQueryPropertyName = keepMemberId_SpecifyDerivedReferrer_MemberAddressList(cb.Query());
            registerSpecifyDerivedReferrer(function, cb.Query(), "MEMBER_ID", "MEMBER_ID", subQueryPropertyName, aliasName);
        }
        abstract public String keepMemberId_SpecifyDerivedReferrer_MemberAddressList(MbMemberAddressCQ subQuery);
        public void xsderiveMemberLoginList(String function, MbSubQuery<MbMemberLoginCB> subQuery, String aliasName) {
            assertObjectNotNull("subQuery<MbMemberLoginCB>", subQuery);
            MbMemberLoginCB cb = new MbMemberLoginCB(); cb.xsetupForDerivedReferrer(this); subQuery.Invoke(cb);
            String subQueryPropertyName = keepMemberId_SpecifyDerivedReferrer_MemberLoginList(cb.Query());
            registerSpecifyDerivedReferrer(function, cb.Query(), "MEMBER_ID", "MEMBER_ID", subQueryPropertyName, aliasName);
        }
        abstract public String keepMemberId_SpecifyDerivedReferrer_MemberLoginList(MbMemberLoginCQ subQuery);
        public void xsderivePurchaseList(String function, MbSubQuery<MbPurchaseCB> subQuery, String aliasName) {
            assertObjectNotNull("subQuery<MbPurchaseCB>", subQuery);
            MbPurchaseCB cb = new MbPurchaseCB(); cb.xsetupForDerivedReferrer(this); subQuery.Invoke(cb);
            String subQueryPropertyName = keepMemberId_SpecifyDerivedReferrer_PurchaseList(cb.Query());
            registerSpecifyDerivedReferrer(function, cb.Query(), "MEMBER_ID", "MEMBER_ID", subQueryPropertyName, aliasName);
        }
        abstract public String keepMemberId_SpecifyDerivedReferrer_PurchaseList(MbPurchaseCQ subQuery);

        public QDRFunction<MbMemberAddressCB> DerivedMemberAddressList() {
            return xcreateQDRFunctionMemberAddressList();
        }
        protected QDRFunction<MbMemberAddressCB> xcreateQDRFunctionMemberAddressList() {
            return new QDRFunction<MbMemberAddressCB>(delegate(String function, MbSubQuery<MbMemberAddressCB> subQuery, String operand, Object value) {
                xqderiveMemberAddressList(function, subQuery, operand, value);
            });
        }
        public void xqderiveMemberAddressList(String function, MbSubQuery<MbMemberAddressCB> subQuery, String operand, Object value) {
            assertObjectNotNull("subQuery<MbMemberAddressCB>", subQuery);
            MbMemberAddressCB cb = new MbMemberAddressCB(); cb.xsetupForDerivedReferrer(this); subQuery.Invoke(cb);
            String subQueryPropertyName = keepMemberId_QueryDerivedReferrer_MemberAddressList(cb.Query()); // for saving query-value.
            String parameterPropertyName = keepMemberId_QueryDerivedReferrer_MemberAddressListParameter(value);
            registerQueryDerivedReferrer(function, cb.Query(), "MEMBER_ID", "MEMBER_ID", subQueryPropertyName, operand, value, parameterPropertyName);
        }
        public abstract String keepMemberId_QueryDerivedReferrer_MemberAddressList(MbMemberAddressCQ subQuery);
        public abstract String keepMemberId_QueryDerivedReferrer_MemberAddressListParameter(Object parameterValue);

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
            String subQueryPropertyName = keepMemberId_QueryDerivedReferrer_MemberLoginList(cb.Query()); // for saving query-value.
            String parameterPropertyName = keepMemberId_QueryDerivedReferrer_MemberLoginListParameter(value);
            registerQueryDerivedReferrer(function, cb.Query(), "MEMBER_ID", "MEMBER_ID", subQueryPropertyName, operand, value, parameterPropertyName);
        }
        public abstract String keepMemberId_QueryDerivedReferrer_MemberLoginList(MbMemberLoginCQ subQuery);
        public abstract String keepMemberId_QueryDerivedReferrer_MemberLoginListParameter(Object parameterValue);

        public QDRFunction<MbPurchaseCB> DerivedPurchaseList() {
            return xcreateQDRFunctionPurchaseList();
        }
        protected QDRFunction<MbPurchaseCB> xcreateQDRFunctionPurchaseList() {
            return new QDRFunction<MbPurchaseCB>(delegate(String function, MbSubQuery<MbPurchaseCB> subQuery, String operand, Object value) {
                xqderivePurchaseList(function, subQuery, operand, value);
            });
        }
        public void xqderivePurchaseList(String function, MbSubQuery<MbPurchaseCB> subQuery, String operand, Object value) {
            assertObjectNotNull("subQuery<MbPurchaseCB>", subQuery);
            MbPurchaseCB cb = new MbPurchaseCB(); cb.xsetupForDerivedReferrer(this); subQuery.Invoke(cb);
            String subQueryPropertyName = keepMemberId_QueryDerivedReferrer_PurchaseList(cb.Query()); // for saving query-value.
            String parameterPropertyName = keepMemberId_QueryDerivedReferrer_PurchaseListParameter(value);
            registerQueryDerivedReferrer(function, cb.Query(), "MEMBER_ID", "MEMBER_ID", subQueryPropertyName, operand, value, parameterPropertyName);
        }
        public abstract String keepMemberId_QueryDerivedReferrer_PurchaseList(MbPurchaseCQ subQuery);
        public abstract String keepMemberId_QueryDerivedReferrer_PurchaseListParameter(Object parameterValue);
        public void SetMemberId_IsNull() { regMemberId(CK_ISN, DUMMY_OBJECT); }
        public void SetMemberId_IsNotNull() { regMemberId(CK_ISNN, DUMMY_OBJECT); }
        protected void regMemberId(MbConditionKey k, Object v) { regQ(k, v, getCValueMemberId(), "MEMBER_ID"); }
        protected abstract MbConditionValue getCValueMemberId();

        public void SetMemberName_Equal(String v) { DoSetMemberName_Equal(fRES(v)); }
        protected void DoSetMemberName_Equal(String v) { regMemberName(CK_EQ, v); }
        public void SetMemberName_NotEqual(String v) { DoSetMemberName_NotEqual(fRES(v)); }
        protected void DoSetMemberName_NotEqual(String v) { regMemberName(CK_NES, v); }
        public void SetMemberName_InScope(IList<String> ls) { regINS<String>(CK_INS, cTL<String>(ls), getCValueMemberName(), "MEMBER_NAME"); }
        public void SetMemberName_NotInScope(IList<String> ls) { regINS<String>(CK_NINS, cTL<String>(ls), getCValueMemberName(), "MEMBER_NAME"); }
        public void SetMemberName_PrefixSearch(String v) { SetMemberName_LikeSearch(v, cLSOP()); }
        public void SetMemberName_LikeSearch(String v, MbLikeSearchOption option)
        { regLSQ(CK_LS, fRES(v), getCValueMemberName(), "MEMBER_NAME", option); }
        public void SetMemberName_NotLikeSearch(String v, MbLikeSearchOption option)
        { regLSQ(CK_NLS, fRES(v), getCValueMemberName(), "MEMBER_NAME", option); }
        protected void regMemberName(MbConditionKey k, Object v) { regQ(k, v, getCValueMemberName(), "MEMBER_NAME"); }
        protected abstract MbConditionValue getCValueMemberName();

        public void SetMemberAccount_Equal(String v) { DoSetMemberAccount_Equal(fRES(v)); }
        protected void DoSetMemberAccount_Equal(String v) { regMemberAccount(CK_EQ, v); }
        public void SetMemberAccount_NotEqual(String v) { DoSetMemberAccount_NotEqual(fRES(v)); }
        protected void DoSetMemberAccount_NotEqual(String v) { regMemberAccount(CK_NES, v); }
        public void SetMemberAccount_InScope(IList<String> ls) { regINS<String>(CK_INS, cTL<String>(ls), getCValueMemberAccount(), "MEMBER_ACCOUNT"); }
        public void SetMemberAccount_NotInScope(IList<String> ls) { regINS<String>(CK_NINS, cTL<String>(ls), getCValueMemberAccount(), "MEMBER_ACCOUNT"); }
        public void SetMemberAccount_PrefixSearch(String v) { SetMemberAccount_LikeSearch(v, cLSOP()); }
        public void SetMemberAccount_LikeSearch(String v, MbLikeSearchOption option)
        { regLSQ(CK_LS, fRES(v), getCValueMemberAccount(), "MEMBER_ACCOUNT", option); }
        public void SetMemberAccount_NotLikeSearch(String v, MbLikeSearchOption option)
        { regLSQ(CK_NLS, fRES(v), getCValueMemberAccount(), "MEMBER_ACCOUNT", option); }
        protected void regMemberAccount(MbConditionKey k, Object v) { regQ(k, v, getCValueMemberAccount(), "MEMBER_ACCOUNT"); }
        protected abstract MbConditionValue getCValueMemberAccount();

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
        public void InScopeMemberStatus(MbSubQuery<MbMemberStatusCB> subQuery) {
            assertObjectNotNull("subQuery<MbMemberStatusCB>", subQuery);
            MbMemberStatusCB cb = new MbMemberStatusCB(); cb.xsetupForInScopeRelation(this); subQuery.Invoke(cb);
            String subQueryPropertyName = keepMemberStatusCode_InScopeSubQuery_MemberStatus(cb.Query());
            registerInScopeSubQuery(cb.Query(), "MEMBER_STATUS_CODE", "MEMBER_STATUS_CODE", subQueryPropertyName);
        }
        public abstract String keepMemberStatusCode_InScopeSubQuery_MemberStatus(MbMemberStatusCQ subQuery);
        public void NotInScopeMemberStatus(MbSubQuery<MbMemberStatusCB> subQuery) {
            assertObjectNotNull("subQuery<MbMemberStatusCB>", subQuery);
            MbMemberStatusCB cb = new MbMemberStatusCB(); cb.xsetupForInScopeRelation(this); subQuery.Invoke(cb);
            String subQueryPropertyName = keepMemberStatusCode_NotInScopeSubQuery_MemberStatus(cb.Query());
            registerNotInScopeSubQuery(cb.Query(), "MEMBER_STATUS_CODE", "MEMBER_STATUS_CODE", subQueryPropertyName);
        }
        public abstract String keepMemberStatusCode_NotInScopeSubQuery_MemberStatus(MbMemberStatusCQ subQuery);
        protected void regMemberStatusCode(MbConditionKey k, Object v) { regQ(k, v, getCValueMemberStatusCode(), "MEMBER_STATUS_CODE"); }
        protected abstract MbConditionValue getCValueMemberStatusCode();

        public void SetFormalizedDatetime_Equal(DateTime? v) { regFormalizedDatetime(CK_EQ, v); }
        public void SetFormalizedDatetime_GreaterThan(DateTime? v) { regFormalizedDatetime(CK_GT, v); }
        public void SetFormalizedDatetime_LessThan(DateTime? v) { regFormalizedDatetime(CK_LT, v); }
        public void SetFormalizedDatetime_GreaterEqual(DateTime? v) { regFormalizedDatetime(CK_GE, v); }
        public void SetFormalizedDatetime_LessEqual(DateTime? v) { regFormalizedDatetime(CK_LE, v); }
        public void SetFormalizedDatetime_FromTo(DateTime? from, DateTime? to, MbFromToOption option)
        { regFTQ(from, to, getCValueFormalizedDatetime(), "FORMALIZED_DATETIME", option); }
        public void SetFormalizedDatetime_DateFromTo(DateTime? from, DateTime? to) { SetFormalizedDatetime_FromTo(from, to, new MbDateFromToOption()); }
        public void SetFormalizedDatetime_InScope(IList<DateTime?> ls) { regINS<DateTime?>(CK_INS, cTL<DateTime?>(ls), getCValueFormalizedDatetime(), "FORMALIZED_DATETIME"); }
        public void SetFormalizedDatetime_NotInScope(IList<DateTime?> ls) { regINS<DateTime?>(CK_NINS, cTL<DateTime?>(ls), getCValueFormalizedDatetime(), "FORMALIZED_DATETIME"); }
        public void SetFormalizedDatetime_IsNull() { regFormalizedDatetime(CK_ISN, DUMMY_OBJECT); }
        public void SetFormalizedDatetime_IsNotNull() { regFormalizedDatetime(CK_ISNN, DUMMY_OBJECT); }
        protected void regFormalizedDatetime(MbConditionKey k, Object v) { regQ(k, v, getCValueFormalizedDatetime(), "FORMALIZED_DATETIME"); }
        protected abstract MbConditionValue getCValueFormalizedDatetime();

        public void SetBirthdate_Equal(DateTime? v) { regBirthdate(CK_EQ, v); }
        public void SetBirthdate_GreaterThan(DateTime? v) { regBirthdate(CK_GT, v); }
        public void SetBirthdate_LessThan(DateTime? v) { regBirthdate(CK_LT, v); }
        public void SetBirthdate_GreaterEqual(DateTime? v) { regBirthdate(CK_GE, v); }
        public void SetBirthdate_LessEqual(DateTime? v) { regBirthdate(CK_LE, v); }
        public void SetBirthdate_FromTo(DateTime? from, DateTime? to, MbFromToOption option)
        { regFTQ(from, to, getCValueBirthdate(), "BIRTHDATE", option); }
        public void SetBirthdate_DateFromTo(DateTime? from, DateTime? to) { SetBirthdate_FromTo(from, to, new MbDateFromToOption()); }
        public void SetBirthdate_InScope(IList<DateTime?> ls) { regINS<DateTime?>(CK_INS, cTL<DateTime?>(ls), getCValueBirthdate(), "BIRTHDATE"); }
        public void SetBirthdate_NotInScope(IList<DateTime?> ls) { regINS<DateTime?>(CK_NINS, cTL<DateTime?>(ls), getCValueBirthdate(), "BIRTHDATE"); }
        public void SetBirthdate_IsNull() { regBirthdate(CK_ISN, DUMMY_OBJECT); }
        public void SetBirthdate_IsNotNull() { regBirthdate(CK_ISNN, DUMMY_OBJECT); }
        protected void regBirthdate(MbConditionKey k, Object v) { regQ(k, v, getCValueBirthdate(), "BIRTHDATE"); }
        protected abstract MbConditionValue getCValueBirthdate();

        public void SetRegisterDatetime_Equal(DateTime? v) { regRegisterDatetime(CK_EQ, v); }
        public void SetRegisterDatetime_GreaterThan(DateTime? v) { regRegisterDatetime(CK_GT, v); }
        public void SetRegisterDatetime_LessThan(DateTime? v) { regRegisterDatetime(CK_LT, v); }
        public void SetRegisterDatetime_GreaterEqual(DateTime? v) { regRegisterDatetime(CK_GE, v); }
        public void SetRegisterDatetime_LessEqual(DateTime? v) { regRegisterDatetime(CK_LE, v); }
        public void SetRegisterDatetime_FromTo(DateTime? from, DateTime? to, MbFromToOption option)
        { regFTQ(from, to, getCValueRegisterDatetime(), "REGISTER_DATETIME", option); }
        public void SetRegisterDatetime_DateFromTo(DateTime? from, DateTime? to) { SetRegisterDatetime_FromTo(from, to, new MbDateFromToOption()); }
        public void SetRegisterDatetime_InScope(IList<DateTime?> ls) { regINS<DateTime?>(CK_INS, cTL<DateTime?>(ls), getCValueRegisterDatetime(), "REGISTER_DATETIME"); }
        public void SetRegisterDatetime_NotInScope(IList<DateTime?> ls) { regINS<DateTime?>(CK_NINS, cTL<DateTime?>(ls), getCValueRegisterDatetime(), "REGISTER_DATETIME"); }
        protected void regRegisterDatetime(MbConditionKey k, Object v) { regQ(k, v, getCValueRegisterDatetime(), "REGISTER_DATETIME"); }
        protected abstract MbConditionValue getCValueRegisterDatetime();

        public void SetRegisterUser_Equal(String v) { DoSetRegisterUser_Equal(fRES(v)); }
        protected void DoSetRegisterUser_Equal(String v) { regRegisterUser(CK_EQ, v); }
        public void SetRegisterUser_NotEqual(String v) { DoSetRegisterUser_NotEqual(fRES(v)); }
        protected void DoSetRegisterUser_NotEqual(String v) { regRegisterUser(CK_NES, v); }
        public void SetRegisterUser_InScope(IList<String> ls) { regINS<String>(CK_INS, cTL<String>(ls), getCValueRegisterUser(), "REGISTER_USER"); }
        public void SetRegisterUser_NotInScope(IList<String> ls) { regINS<String>(CK_NINS, cTL<String>(ls), getCValueRegisterUser(), "REGISTER_USER"); }
        public void SetRegisterUser_PrefixSearch(String v) { SetRegisterUser_LikeSearch(v, cLSOP()); }
        public void SetRegisterUser_LikeSearch(String v, MbLikeSearchOption option)
        { regLSQ(CK_LS, fRES(v), getCValueRegisterUser(), "REGISTER_USER", option); }
        public void SetRegisterUser_NotLikeSearch(String v, MbLikeSearchOption option)
        { regLSQ(CK_NLS, fRES(v), getCValueRegisterUser(), "REGISTER_USER", option); }
        protected void regRegisterUser(MbConditionKey k, Object v) { regQ(k, v, getCValueRegisterUser(), "REGISTER_USER"); }
        protected abstract MbConditionValue getCValueRegisterUser();

        public void SetRegisterProcess_Equal(String v) { DoSetRegisterProcess_Equal(fRES(v)); }
        protected void DoSetRegisterProcess_Equal(String v) { regRegisterProcess(CK_EQ, v); }
        public void SetRegisterProcess_NotEqual(String v) { DoSetRegisterProcess_NotEqual(fRES(v)); }
        protected void DoSetRegisterProcess_NotEqual(String v) { regRegisterProcess(CK_NES, v); }
        public void SetRegisterProcess_InScope(IList<String> ls) { regINS<String>(CK_INS, cTL<String>(ls), getCValueRegisterProcess(), "REGISTER_PROCESS"); }
        public void SetRegisterProcess_NotInScope(IList<String> ls) { regINS<String>(CK_NINS, cTL<String>(ls), getCValueRegisterProcess(), "REGISTER_PROCESS"); }
        public void SetRegisterProcess_PrefixSearch(String v) { SetRegisterProcess_LikeSearch(v, cLSOP()); }
        public void SetRegisterProcess_LikeSearch(String v, MbLikeSearchOption option)
        { regLSQ(CK_LS, fRES(v), getCValueRegisterProcess(), "REGISTER_PROCESS", option); }
        public void SetRegisterProcess_NotLikeSearch(String v, MbLikeSearchOption option)
        { regLSQ(CK_NLS, fRES(v), getCValueRegisterProcess(), "REGISTER_PROCESS", option); }
        protected void regRegisterProcess(MbConditionKey k, Object v) { regQ(k, v, getCValueRegisterProcess(), "REGISTER_PROCESS"); }
        protected abstract MbConditionValue getCValueRegisterProcess();

        public void SetUpdateDatetime_Equal(DateTime? v) { regUpdateDatetime(CK_EQ, v); }
        public void SetUpdateDatetime_GreaterThan(DateTime? v) { regUpdateDatetime(CK_GT, v); }
        public void SetUpdateDatetime_LessThan(DateTime? v) { regUpdateDatetime(CK_LT, v); }
        public void SetUpdateDatetime_GreaterEqual(DateTime? v) { regUpdateDatetime(CK_GE, v); }
        public void SetUpdateDatetime_LessEqual(DateTime? v) { regUpdateDatetime(CK_LE, v); }
        public void SetUpdateDatetime_FromTo(DateTime? from, DateTime? to, MbFromToOption option)
        { regFTQ(from, to, getCValueUpdateDatetime(), "UPDATE_DATETIME", option); }
        public void SetUpdateDatetime_DateFromTo(DateTime? from, DateTime? to) { SetUpdateDatetime_FromTo(from, to, new MbDateFromToOption()); }
        public void SetUpdateDatetime_InScope(IList<DateTime?> ls) { regINS<DateTime?>(CK_INS, cTL<DateTime?>(ls), getCValueUpdateDatetime(), "UPDATE_DATETIME"); }
        public void SetUpdateDatetime_NotInScope(IList<DateTime?> ls) { regINS<DateTime?>(CK_NINS, cTL<DateTime?>(ls), getCValueUpdateDatetime(), "UPDATE_DATETIME"); }
        protected void regUpdateDatetime(MbConditionKey k, Object v) { regQ(k, v, getCValueUpdateDatetime(), "UPDATE_DATETIME"); }
        protected abstract MbConditionValue getCValueUpdateDatetime();

        public void SetUpdateUser_Equal(String v) { DoSetUpdateUser_Equal(fRES(v)); }
        protected void DoSetUpdateUser_Equal(String v) { regUpdateUser(CK_EQ, v); }
        public void SetUpdateUser_NotEqual(String v) { DoSetUpdateUser_NotEqual(fRES(v)); }
        protected void DoSetUpdateUser_NotEqual(String v) { regUpdateUser(CK_NES, v); }
        public void SetUpdateUser_InScope(IList<String> ls) { regINS<String>(CK_INS, cTL<String>(ls), getCValueUpdateUser(), "UPDATE_USER"); }
        public void SetUpdateUser_NotInScope(IList<String> ls) { regINS<String>(CK_NINS, cTL<String>(ls), getCValueUpdateUser(), "UPDATE_USER"); }
        public void SetUpdateUser_PrefixSearch(String v) { SetUpdateUser_LikeSearch(v, cLSOP()); }
        public void SetUpdateUser_LikeSearch(String v, MbLikeSearchOption option)
        { regLSQ(CK_LS, fRES(v), getCValueUpdateUser(), "UPDATE_USER", option); }
        public void SetUpdateUser_NotLikeSearch(String v, MbLikeSearchOption option)
        { regLSQ(CK_NLS, fRES(v), getCValueUpdateUser(), "UPDATE_USER", option); }
        protected void regUpdateUser(MbConditionKey k, Object v) { regQ(k, v, getCValueUpdateUser(), "UPDATE_USER"); }
        protected abstract MbConditionValue getCValueUpdateUser();

        public void SetUpdateProcess_Equal(String v) { DoSetUpdateProcess_Equal(fRES(v)); }
        protected void DoSetUpdateProcess_Equal(String v) { regUpdateProcess(CK_EQ, v); }
        public void SetUpdateProcess_NotEqual(String v) { DoSetUpdateProcess_NotEqual(fRES(v)); }
        protected void DoSetUpdateProcess_NotEqual(String v) { regUpdateProcess(CK_NES, v); }
        public void SetUpdateProcess_InScope(IList<String> ls) { regINS<String>(CK_INS, cTL<String>(ls), getCValueUpdateProcess(), "UPDATE_PROCESS"); }
        public void SetUpdateProcess_NotInScope(IList<String> ls) { regINS<String>(CK_NINS, cTL<String>(ls), getCValueUpdateProcess(), "UPDATE_PROCESS"); }
        public void SetUpdateProcess_PrefixSearch(String v) { SetUpdateProcess_LikeSearch(v, cLSOP()); }
        public void SetUpdateProcess_LikeSearch(String v, MbLikeSearchOption option)
        { regLSQ(CK_LS, fRES(v), getCValueUpdateProcess(), "UPDATE_PROCESS", option); }
        public void SetUpdateProcess_NotLikeSearch(String v, MbLikeSearchOption option)
        { regLSQ(CK_NLS, fRES(v), getCValueUpdateProcess(), "UPDATE_PROCESS", option); }
        protected void regUpdateProcess(MbConditionKey k, Object v) { regQ(k, v, getCValueUpdateProcess(), "UPDATE_PROCESS"); }
        protected abstract MbConditionValue getCValueUpdateProcess();

        public void SetVersionNo_Equal(long? v) { regVersionNo(CK_EQ, v); }
        public void SetVersionNo_GreaterThan(long? v) { regVersionNo(CK_GT, v); }
        public void SetVersionNo_LessThan(long? v) { regVersionNo(CK_LT, v); }
        public void SetVersionNo_GreaterEqual(long? v) { regVersionNo(CK_GE, v); }
        public void SetVersionNo_LessEqual(long? v) { regVersionNo(CK_LE, v); }
        public void SetVersionNo_InScope(IList<long?> ls) { regINS<long?>(CK_INS, cTL<long?>(ls), getCValueVersionNo(), "VERSION_NO"); }
        public void SetVersionNo_NotInScope(IList<long?> ls) { regINS<long?>(CK_NINS, cTL<long?>(ls), getCValueVersionNo(), "VERSION_NO"); }
        protected void regVersionNo(MbConditionKey k, Object v) { regQ(k, v, getCValueVersionNo(), "VERSION_NO"); }
        protected abstract MbConditionValue getCValueVersionNo();

        // ===================================================================================
        //                                                                    Scalar Condition
        //                                                                    ================
        public SSQFunction<MbMemberCB> Scalar_Equal() {
            return xcreateSSQFunction("=");
        }

        public SSQFunction<MbMemberCB> Scalar_NotEqual() {
            return xcreateSSQFunction("<>");
        }

        public SSQFunction<MbMemberCB> Scalar_GreaterEqual() {
            return xcreateSSQFunction(">=");
        }

        public SSQFunction<MbMemberCB> Scalar_GreaterThan() {
            return xcreateSSQFunction(">");
        }

        public SSQFunction<MbMemberCB> Scalar_LessEqual() {
            return xcreateSSQFunction("<=");
        }

        public SSQFunction<MbMemberCB> Scalar_LessThan() {
            return xcreateSSQFunction("<");
        }

        protected SSQFunction<MbMemberCB> xcreateSSQFunction(String operand) {
            return new SSQFunction<MbMemberCB>(delegate(String function, MbSubQuery<MbMemberCB> subQuery) {
                xscalarSubQuery(function, subQuery, operand);
            });
        }

        protected void xscalarSubQuery(String function, MbSubQuery<MbMemberCB> subQuery, String operand) {
            assertObjectNotNull("subQuery<MbMemberCB>", subQuery);
            MbMemberCB cb = new MbMemberCB(); cb.xsetupForScalarCondition(this); subQuery.Invoke(cb);
            String subQueryPropertyName = keepScalarSubQuery(cb.Query()); // for saving query-value.
            registerScalarSubQuery(function, cb.Query(), subQueryPropertyName, operand);
        }
        public abstract String keepScalarSubQuery(MbMemberCQ subQuery);

        // ===============================================================================
        //                                                                  MySelf InScope
        //                                                                  ==============
        public void MyselfInScope(MbSubQuery<MbMemberCB> subQuery) {
            assertObjectNotNull("subQuery<MbMemberCB>", subQuery);
            MbMemberCB cb = new MbMemberCB(); cb.xsetupForInScopeRelation(this); subQuery.Invoke(cb);
            String subQueryPropertyName = keepMyselfInScopeSubQuery(cb.Query()); // for saving query-value.
            registerInScopeSubQuery(cb.Query(), "MEMBER_ID", "MEMBER_ID", subQueryPropertyName);
        }
        public abstract String keepMyselfInScopeSubQuery(MbMemberCQ subQuery);

        public override String ToString() { return xgetSqlClause().getClause(); }
    }
}
