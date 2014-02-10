
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
    public abstract class AbstractBsMemberStatusCQ : AbstractConditionQuery {

        public AbstractBsMemberStatusCQ(ConditionQuery childQuery, SqlClause sqlClause, String aliasName, int nestLevel)
            : base(childQuery, sqlClause, aliasName, nestLevel) {}

        public override String getTableDbName() { return "MEMBER_STATUS"; }
        public override String getTableSqlName() { return "MEMBER_STATUS"; }

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
        public void ExistsMemberVendorSynonymList(SubQuery<MemberVendorSynonymCB> subQuery) {
            assertObjectNotNull("subQuery<MemberVendorSynonymCB>", subQuery);
            MemberVendorSynonymCB cb = new MemberVendorSynonymCB(); cb.xsetupForExistsReferrer(this); subQuery.Invoke(cb);
            String subQueryPropertyName = keepMemberStatusCode_ExistsSubQuery_MemberVendorSynonymList(cb.Query());
            registerExistsSubQuery(cb.Query(), "MEMBER_STATUS_CODE", "MEMBER_STATUS_CODE", subQueryPropertyName);
        }
        public abstract String keepMemberStatusCode_ExistsSubQuery_MemberVendorSynonymList(MemberVendorSynonymCQ subQuery);
        public void ExistsVdSynonymMemberList(SubQuery<VdSynonymMemberCB> subQuery) {
            assertObjectNotNull("subQuery<VdSynonymMemberCB>", subQuery);
            VdSynonymMemberCB cb = new VdSynonymMemberCB(); cb.xsetupForExistsReferrer(this); subQuery.Invoke(cb);
            String subQueryPropertyName = keepMemberStatusCode_ExistsSubQuery_VdSynonymMemberList(cb.Query());
            registerExistsSubQuery(cb.Query(), "MEMBER_STATUS_CODE", "MEMBER_STATUS_CODE", subQueryPropertyName);
        }
        public abstract String keepMemberStatusCode_ExistsSubQuery_VdSynonymMemberList(VdSynonymMemberCQ subQuery);
        public void ExistsVdSynonymMemberLoginList(SubQuery<VdSynonymMemberLoginCB> subQuery) {
            assertObjectNotNull("subQuery<VdSynonymMemberLoginCB>", subQuery);
            VdSynonymMemberLoginCB cb = new VdSynonymMemberLoginCB(); cb.xsetupForExistsReferrer(this); subQuery.Invoke(cb);
            String subQueryPropertyName = keepMemberStatusCode_ExistsSubQuery_VdSynonymMemberLoginList(cb.Query());
            registerExistsSubQuery(cb.Query(), "MEMBER_STATUS_CODE", "LOGIN_MEMBER_STATUS_CODE", subQueryPropertyName);
        }
        public abstract String keepMemberStatusCode_ExistsSubQuery_VdSynonymMemberLoginList(VdSynonymMemberLoginCQ subQuery);
        public void ExistsVendorSynonymMemberList(SubQuery<VendorSynonymMemberCB> subQuery) {
            assertObjectNotNull("subQuery<VendorSynonymMemberCB>", subQuery);
            VendorSynonymMemberCB cb = new VendorSynonymMemberCB(); cb.xsetupForExistsReferrer(this); subQuery.Invoke(cb);
            String subQueryPropertyName = keepMemberStatusCode_ExistsSubQuery_VendorSynonymMemberList(cb.Query());
            registerExistsSubQuery(cb.Query(), "MEMBER_STATUS_CODE", "MEMBER_STATUS_CODE", subQueryPropertyName);
        }
        public abstract String keepMemberStatusCode_ExistsSubQuery_VendorSynonymMemberList(VendorSynonymMemberCQ subQuery);
        public void ExistsMemberList(SubQuery<MemberCB> subQuery) {
            assertObjectNotNull("subQuery<MemberCB>", subQuery);
            MemberCB cb = new MemberCB(); cb.xsetupForExistsReferrer(this); subQuery.Invoke(cb);
            String subQueryPropertyName = keepMemberStatusCode_ExistsSubQuery_MemberList(cb.Query());
            registerExistsSubQuery(cb.Query(), "MEMBER_STATUS_CODE", "MEMBER_STATUS_CODE", subQueryPropertyName);
        }
        public abstract String keepMemberStatusCode_ExistsSubQuery_MemberList(MemberCQ subQuery);
        public void ExistsMemberLoginList(SubQuery<MemberLoginCB> subQuery) {
            assertObjectNotNull("subQuery<MemberLoginCB>", subQuery);
            MemberLoginCB cb = new MemberLoginCB(); cb.xsetupForExistsReferrer(this); subQuery.Invoke(cb);
            String subQueryPropertyName = keepMemberStatusCode_ExistsSubQuery_MemberLoginList(cb.Query());
            registerExistsSubQuery(cb.Query(), "MEMBER_STATUS_CODE", "LOGIN_MEMBER_STATUS_CODE", subQueryPropertyName);
        }
        public abstract String keepMemberStatusCode_ExistsSubQuery_MemberLoginList(MemberLoginCQ subQuery);
        public void NotExistsMemberVendorSynonymList(SubQuery<MemberVendorSynonymCB> subQuery) {
            assertObjectNotNull("subQuery<MemberVendorSynonymCB>", subQuery);
            MemberVendorSynonymCB cb = new MemberVendorSynonymCB(); cb.xsetupForExistsReferrer(this); subQuery.Invoke(cb);
            String subQueryPropertyName = keepMemberStatusCode_NotExistsSubQuery_MemberVendorSynonymList(cb.Query());
            registerNotExistsSubQuery(cb.Query(), "MEMBER_STATUS_CODE", "MEMBER_STATUS_CODE", subQueryPropertyName);
        }
        public abstract String keepMemberStatusCode_NotExistsSubQuery_MemberVendorSynonymList(MemberVendorSynonymCQ subQuery);
        public void NotExistsVdSynonymMemberList(SubQuery<VdSynonymMemberCB> subQuery) {
            assertObjectNotNull("subQuery<VdSynonymMemberCB>", subQuery);
            VdSynonymMemberCB cb = new VdSynonymMemberCB(); cb.xsetupForExistsReferrer(this); subQuery.Invoke(cb);
            String subQueryPropertyName = keepMemberStatusCode_NotExistsSubQuery_VdSynonymMemberList(cb.Query());
            registerNotExistsSubQuery(cb.Query(), "MEMBER_STATUS_CODE", "MEMBER_STATUS_CODE", subQueryPropertyName);
        }
        public abstract String keepMemberStatusCode_NotExistsSubQuery_VdSynonymMemberList(VdSynonymMemberCQ subQuery);
        public void NotExistsVdSynonymMemberLoginList(SubQuery<VdSynonymMemberLoginCB> subQuery) {
            assertObjectNotNull("subQuery<VdSynonymMemberLoginCB>", subQuery);
            VdSynonymMemberLoginCB cb = new VdSynonymMemberLoginCB(); cb.xsetupForExistsReferrer(this); subQuery.Invoke(cb);
            String subQueryPropertyName = keepMemberStatusCode_NotExistsSubQuery_VdSynonymMemberLoginList(cb.Query());
            registerNotExistsSubQuery(cb.Query(), "MEMBER_STATUS_CODE", "LOGIN_MEMBER_STATUS_CODE", subQueryPropertyName);
        }
        public abstract String keepMemberStatusCode_NotExistsSubQuery_VdSynonymMemberLoginList(VdSynonymMemberLoginCQ subQuery);
        public void NotExistsVendorSynonymMemberList(SubQuery<VendorSynonymMemberCB> subQuery) {
            assertObjectNotNull("subQuery<VendorSynonymMemberCB>", subQuery);
            VendorSynonymMemberCB cb = new VendorSynonymMemberCB(); cb.xsetupForExistsReferrer(this); subQuery.Invoke(cb);
            String subQueryPropertyName = keepMemberStatusCode_NotExistsSubQuery_VendorSynonymMemberList(cb.Query());
            registerNotExistsSubQuery(cb.Query(), "MEMBER_STATUS_CODE", "MEMBER_STATUS_CODE", subQueryPropertyName);
        }
        public abstract String keepMemberStatusCode_NotExistsSubQuery_VendorSynonymMemberList(VendorSynonymMemberCQ subQuery);
        public void NotExistsMemberList(SubQuery<MemberCB> subQuery) {
            assertObjectNotNull("subQuery<MemberCB>", subQuery);
            MemberCB cb = new MemberCB(); cb.xsetupForExistsReferrer(this); subQuery.Invoke(cb);
            String subQueryPropertyName = keepMemberStatusCode_NotExistsSubQuery_MemberList(cb.Query());
            registerNotExistsSubQuery(cb.Query(), "MEMBER_STATUS_CODE", "MEMBER_STATUS_CODE", subQueryPropertyName);
        }
        public abstract String keepMemberStatusCode_NotExistsSubQuery_MemberList(MemberCQ subQuery);
        public void NotExistsMemberLoginList(SubQuery<MemberLoginCB> subQuery) {
            assertObjectNotNull("subQuery<MemberLoginCB>", subQuery);
            MemberLoginCB cb = new MemberLoginCB(); cb.xsetupForExistsReferrer(this); subQuery.Invoke(cb);
            String subQueryPropertyName = keepMemberStatusCode_NotExistsSubQuery_MemberLoginList(cb.Query());
            registerNotExistsSubQuery(cb.Query(), "MEMBER_STATUS_CODE", "LOGIN_MEMBER_STATUS_CODE", subQueryPropertyName);
        }
        public abstract String keepMemberStatusCode_NotExistsSubQuery_MemberLoginList(MemberLoginCQ subQuery);
        public void InScopeMemberVendorSynonymList(SubQuery<MemberVendorSynonymCB> subQuery) {
            assertObjectNotNull("subQuery<MemberVendorSynonymCB>", subQuery);
            MemberVendorSynonymCB cb = new MemberVendorSynonymCB(); cb.xsetupForInScopeRelation(this); subQuery.Invoke(cb);
            String subQueryPropertyName = keepMemberStatusCode_InScopeSubQuery_MemberVendorSynonymList(cb.Query());
            registerInScopeSubQuery(cb.Query(), "MEMBER_STATUS_CODE", "MEMBER_STATUS_CODE", subQueryPropertyName);
        }
        public abstract String keepMemberStatusCode_InScopeSubQuery_MemberVendorSynonymList(MemberVendorSynonymCQ subQuery);
        public void InScopeVdSynonymMemberList(SubQuery<VdSynonymMemberCB> subQuery) {
            assertObjectNotNull("subQuery<VdSynonymMemberCB>", subQuery);
            VdSynonymMemberCB cb = new VdSynonymMemberCB(); cb.xsetupForInScopeRelation(this); subQuery.Invoke(cb);
            String subQueryPropertyName = keepMemberStatusCode_InScopeSubQuery_VdSynonymMemberList(cb.Query());
            registerInScopeSubQuery(cb.Query(), "MEMBER_STATUS_CODE", "MEMBER_STATUS_CODE", subQueryPropertyName);
        }
        public abstract String keepMemberStatusCode_InScopeSubQuery_VdSynonymMemberList(VdSynonymMemberCQ subQuery);
        public void InScopeVdSynonymMemberLoginList(SubQuery<VdSynonymMemberLoginCB> subQuery) {
            assertObjectNotNull("subQuery<VdSynonymMemberLoginCB>", subQuery);
            VdSynonymMemberLoginCB cb = new VdSynonymMemberLoginCB(); cb.xsetupForInScopeRelation(this); subQuery.Invoke(cb);
            String subQueryPropertyName = keepMemberStatusCode_InScopeSubQuery_VdSynonymMemberLoginList(cb.Query());
            registerInScopeSubQuery(cb.Query(), "MEMBER_STATUS_CODE", "LOGIN_MEMBER_STATUS_CODE", subQueryPropertyName);
        }
        public abstract String keepMemberStatusCode_InScopeSubQuery_VdSynonymMemberLoginList(VdSynonymMemberLoginCQ subQuery);
        public void InScopeVendorSynonymMemberList(SubQuery<VendorSynonymMemberCB> subQuery) {
            assertObjectNotNull("subQuery<VendorSynonymMemberCB>", subQuery);
            VendorSynonymMemberCB cb = new VendorSynonymMemberCB(); cb.xsetupForInScopeRelation(this); subQuery.Invoke(cb);
            String subQueryPropertyName = keepMemberStatusCode_InScopeSubQuery_VendorSynonymMemberList(cb.Query());
            registerInScopeSubQuery(cb.Query(), "MEMBER_STATUS_CODE", "MEMBER_STATUS_CODE", subQueryPropertyName);
        }
        public abstract String keepMemberStatusCode_InScopeSubQuery_VendorSynonymMemberList(VendorSynonymMemberCQ subQuery);
        public void InScopeMemberList(SubQuery<MemberCB> subQuery) {
            assertObjectNotNull("subQuery<MemberCB>", subQuery);
            MemberCB cb = new MemberCB(); cb.xsetupForInScopeRelation(this); subQuery.Invoke(cb);
            String subQueryPropertyName = keepMemberStatusCode_InScopeSubQuery_MemberList(cb.Query());
            registerInScopeSubQuery(cb.Query(), "MEMBER_STATUS_CODE", "MEMBER_STATUS_CODE", subQueryPropertyName);
        }
        public abstract String keepMemberStatusCode_InScopeSubQuery_MemberList(MemberCQ subQuery);
        public void InScopeMemberLoginList(SubQuery<MemberLoginCB> subQuery) {
            assertObjectNotNull("subQuery<MemberLoginCB>", subQuery);
            MemberLoginCB cb = new MemberLoginCB(); cb.xsetupForInScopeRelation(this); subQuery.Invoke(cb);
            String subQueryPropertyName = keepMemberStatusCode_InScopeSubQuery_MemberLoginList(cb.Query());
            registerInScopeSubQuery(cb.Query(), "MEMBER_STATUS_CODE", "LOGIN_MEMBER_STATUS_CODE", subQueryPropertyName);
        }
        public abstract String keepMemberStatusCode_InScopeSubQuery_MemberLoginList(MemberLoginCQ subQuery);
        public void NotInScopeMemberVendorSynonymList(SubQuery<MemberVendorSynonymCB> subQuery) {
            assertObjectNotNull("subQuery<MemberVendorSynonymCB>", subQuery);
            MemberVendorSynonymCB cb = new MemberVendorSynonymCB(); cb.xsetupForInScopeRelation(this); subQuery.Invoke(cb);
            String subQueryPropertyName = keepMemberStatusCode_NotInScopeSubQuery_MemberVendorSynonymList(cb.Query());
            registerNotInScopeSubQuery(cb.Query(), "MEMBER_STATUS_CODE", "MEMBER_STATUS_CODE", subQueryPropertyName);
        }
        public abstract String keepMemberStatusCode_NotInScopeSubQuery_MemberVendorSynonymList(MemberVendorSynonymCQ subQuery);
        public void NotInScopeVdSynonymMemberList(SubQuery<VdSynonymMemberCB> subQuery) {
            assertObjectNotNull("subQuery<VdSynonymMemberCB>", subQuery);
            VdSynonymMemberCB cb = new VdSynonymMemberCB(); cb.xsetupForInScopeRelation(this); subQuery.Invoke(cb);
            String subQueryPropertyName = keepMemberStatusCode_NotInScopeSubQuery_VdSynonymMemberList(cb.Query());
            registerNotInScopeSubQuery(cb.Query(), "MEMBER_STATUS_CODE", "MEMBER_STATUS_CODE", subQueryPropertyName);
        }
        public abstract String keepMemberStatusCode_NotInScopeSubQuery_VdSynonymMemberList(VdSynonymMemberCQ subQuery);
        public void NotInScopeVdSynonymMemberLoginList(SubQuery<VdSynonymMemberLoginCB> subQuery) {
            assertObjectNotNull("subQuery<VdSynonymMemberLoginCB>", subQuery);
            VdSynonymMemberLoginCB cb = new VdSynonymMemberLoginCB(); cb.xsetupForInScopeRelation(this); subQuery.Invoke(cb);
            String subQueryPropertyName = keepMemberStatusCode_NotInScopeSubQuery_VdSynonymMemberLoginList(cb.Query());
            registerNotInScopeSubQuery(cb.Query(), "MEMBER_STATUS_CODE", "LOGIN_MEMBER_STATUS_CODE", subQueryPropertyName);
        }
        public abstract String keepMemberStatusCode_NotInScopeSubQuery_VdSynonymMemberLoginList(VdSynonymMemberLoginCQ subQuery);
        public void NotInScopeVendorSynonymMemberList(SubQuery<VendorSynonymMemberCB> subQuery) {
            assertObjectNotNull("subQuery<VendorSynonymMemberCB>", subQuery);
            VendorSynonymMemberCB cb = new VendorSynonymMemberCB(); cb.xsetupForInScopeRelation(this); subQuery.Invoke(cb);
            String subQueryPropertyName = keepMemberStatusCode_NotInScopeSubQuery_VendorSynonymMemberList(cb.Query());
            registerNotInScopeSubQuery(cb.Query(), "MEMBER_STATUS_CODE", "MEMBER_STATUS_CODE", subQueryPropertyName);
        }
        public abstract String keepMemberStatusCode_NotInScopeSubQuery_VendorSynonymMemberList(VendorSynonymMemberCQ subQuery);
        public void NotInScopeMemberList(SubQuery<MemberCB> subQuery) {
            assertObjectNotNull("subQuery<MemberCB>", subQuery);
            MemberCB cb = new MemberCB(); cb.xsetupForInScopeRelation(this); subQuery.Invoke(cb);
            String subQueryPropertyName = keepMemberStatusCode_NotInScopeSubQuery_MemberList(cb.Query());
            registerNotInScopeSubQuery(cb.Query(), "MEMBER_STATUS_CODE", "MEMBER_STATUS_CODE", subQueryPropertyName);
        }
        public abstract String keepMemberStatusCode_NotInScopeSubQuery_MemberList(MemberCQ subQuery);
        public void NotInScopeMemberLoginList(SubQuery<MemberLoginCB> subQuery) {
            assertObjectNotNull("subQuery<MemberLoginCB>", subQuery);
            MemberLoginCB cb = new MemberLoginCB(); cb.xsetupForInScopeRelation(this); subQuery.Invoke(cb);
            String subQueryPropertyName = keepMemberStatusCode_NotInScopeSubQuery_MemberLoginList(cb.Query());
            registerNotInScopeSubQuery(cb.Query(), "MEMBER_STATUS_CODE", "LOGIN_MEMBER_STATUS_CODE", subQueryPropertyName);
        }
        public abstract String keepMemberStatusCode_NotInScopeSubQuery_MemberLoginList(MemberLoginCQ subQuery);
        public void xsderiveMemberVendorSynonymList(String function, SubQuery<MemberVendorSynonymCB> subQuery, String aliasName) {
            assertObjectNotNull("subQuery<MemberVendorSynonymCB>", subQuery);
            MemberVendorSynonymCB cb = new MemberVendorSynonymCB(); cb.xsetupForDerivedReferrer(this); subQuery.Invoke(cb);
            String subQueryPropertyName = keepMemberStatusCode_SpecifyDerivedReferrer_MemberVendorSynonymList(cb.Query());
            registerSpecifyDerivedReferrer(function, cb.Query(), "MEMBER_STATUS_CODE", "MEMBER_STATUS_CODE", subQueryPropertyName, aliasName);
        }
        abstract public String keepMemberStatusCode_SpecifyDerivedReferrer_MemberVendorSynonymList(MemberVendorSynonymCQ subQuery);
        public void xsderiveVdSynonymMemberList(String function, SubQuery<VdSynonymMemberCB> subQuery, String aliasName) {
            assertObjectNotNull("subQuery<VdSynonymMemberCB>", subQuery);
            VdSynonymMemberCB cb = new VdSynonymMemberCB(); cb.xsetupForDerivedReferrer(this); subQuery.Invoke(cb);
            String subQueryPropertyName = keepMemberStatusCode_SpecifyDerivedReferrer_VdSynonymMemberList(cb.Query());
            registerSpecifyDerivedReferrer(function, cb.Query(), "MEMBER_STATUS_CODE", "MEMBER_STATUS_CODE", subQueryPropertyName, aliasName);
        }
        abstract public String keepMemberStatusCode_SpecifyDerivedReferrer_VdSynonymMemberList(VdSynonymMemberCQ subQuery);
        public void xsderiveVdSynonymMemberLoginList(String function, SubQuery<VdSynonymMemberLoginCB> subQuery, String aliasName) {
            assertObjectNotNull("subQuery<VdSynonymMemberLoginCB>", subQuery);
            VdSynonymMemberLoginCB cb = new VdSynonymMemberLoginCB(); cb.xsetupForDerivedReferrer(this); subQuery.Invoke(cb);
            String subQueryPropertyName = keepMemberStatusCode_SpecifyDerivedReferrer_VdSynonymMemberLoginList(cb.Query());
            registerSpecifyDerivedReferrer(function, cb.Query(), "MEMBER_STATUS_CODE", "LOGIN_MEMBER_STATUS_CODE", subQueryPropertyName, aliasName);
        }
        abstract public String keepMemberStatusCode_SpecifyDerivedReferrer_VdSynonymMemberLoginList(VdSynonymMemberLoginCQ subQuery);
        public void xsderiveVendorSynonymMemberList(String function, SubQuery<VendorSynonymMemberCB> subQuery, String aliasName) {
            assertObjectNotNull("subQuery<VendorSynonymMemberCB>", subQuery);
            VendorSynonymMemberCB cb = new VendorSynonymMemberCB(); cb.xsetupForDerivedReferrer(this); subQuery.Invoke(cb);
            String subQueryPropertyName = keepMemberStatusCode_SpecifyDerivedReferrer_VendorSynonymMemberList(cb.Query());
            registerSpecifyDerivedReferrer(function, cb.Query(), "MEMBER_STATUS_CODE", "MEMBER_STATUS_CODE", subQueryPropertyName, aliasName);
        }
        abstract public String keepMemberStatusCode_SpecifyDerivedReferrer_VendorSynonymMemberList(VendorSynonymMemberCQ subQuery);
        public void xsderiveMemberList(String function, SubQuery<MemberCB> subQuery, String aliasName) {
            assertObjectNotNull("subQuery<MemberCB>", subQuery);
            MemberCB cb = new MemberCB(); cb.xsetupForDerivedReferrer(this); subQuery.Invoke(cb);
            String subQueryPropertyName = keepMemberStatusCode_SpecifyDerivedReferrer_MemberList(cb.Query());
            registerSpecifyDerivedReferrer(function, cb.Query(), "MEMBER_STATUS_CODE", "MEMBER_STATUS_CODE", subQueryPropertyName, aliasName);
        }
        abstract public String keepMemberStatusCode_SpecifyDerivedReferrer_MemberList(MemberCQ subQuery);
        public void xsderiveMemberLoginList(String function, SubQuery<MemberLoginCB> subQuery, String aliasName) {
            assertObjectNotNull("subQuery<MemberLoginCB>", subQuery);
            MemberLoginCB cb = new MemberLoginCB(); cb.xsetupForDerivedReferrer(this); subQuery.Invoke(cb);
            String subQueryPropertyName = keepMemberStatusCode_SpecifyDerivedReferrer_MemberLoginList(cb.Query());
            registerSpecifyDerivedReferrer(function, cb.Query(), "MEMBER_STATUS_CODE", "LOGIN_MEMBER_STATUS_CODE", subQueryPropertyName, aliasName);
        }
        abstract public String keepMemberStatusCode_SpecifyDerivedReferrer_MemberLoginList(MemberLoginCQ subQuery);

        public QDRFunction<MemberVendorSynonymCB> DerivedMemberVendorSynonymList() {
            return xcreateQDRFunctionMemberVendorSynonymList();
        }
        protected QDRFunction<MemberVendorSynonymCB> xcreateQDRFunctionMemberVendorSynonymList() {
            return new QDRFunction<MemberVendorSynonymCB>(delegate(String function, SubQuery<MemberVendorSynonymCB> subQuery, String operand, Object value) {
                xqderiveMemberVendorSynonymList(function, subQuery, operand, value);
            });
        }
        public void xqderiveMemberVendorSynonymList(String function, SubQuery<MemberVendorSynonymCB> subQuery, String operand, Object value) {
            assertObjectNotNull("subQuery<MemberVendorSynonymCB>", subQuery);
            MemberVendorSynonymCB cb = new MemberVendorSynonymCB(); cb.xsetupForDerivedReferrer(this); subQuery.Invoke(cb);
            String subQueryPropertyName = keepMemberStatusCode_QueryDerivedReferrer_MemberVendorSynonymList(cb.Query()); // for saving query-value.
            String parameterPropertyName = keepMemberStatusCode_QueryDerivedReferrer_MemberVendorSynonymListParameter(value);
            registerQueryDerivedReferrer(function, cb.Query(), "MEMBER_STATUS_CODE", "MEMBER_STATUS_CODE", subQueryPropertyName, operand, value, parameterPropertyName);
        }
        public abstract String keepMemberStatusCode_QueryDerivedReferrer_MemberVendorSynonymList(MemberVendorSynonymCQ subQuery);
        public abstract String keepMemberStatusCode_QueryDerivedReferrer_MemberVendorSynonymListParameter(Object parameterValue);

        public QDRFunction<VdSynonymMemberCB> DerivedVdSynonymMemberList() {
            return xcreateQDRFunctionVdSynonymMemberList();
        }
        protected QDRFunction<VdSynonymMemberCB> xcreateQDRFunctionVdSynonymMemberList() {
            return new QDRFunction<VdSynonymMemberCB>(delegate(String function, SubQuery<VdSynonymMemberCB> subQuery, String operand, Object value) {
                xqderiveVdSynonymMemberList(function, subQuery, operand, value);
            });
        }
        public void xqderiveVdSynonymMemberList(String function, SubQuery<VdSynonymMemberCB> subQuery, String operand, Object value) {
            assertObjectNotNull("subQuery<VdSynonymMemberCB>", subQuery);
            VdSynonymMemberCB cb = new VdSynonymMemberCB(); cb.xsetupForDerivedReferrer(this); subQuery.Invoke(cb);
            String subQueryPropertyName = keepMemberStatusCode_QueryDerivedReferrer_VdSynonymMemberList(cb.Query()); // for saving query-value.
            String parameterPropertyName = keepMemberStatusCode_QueryDerivedReferrer_VdSynonymMemberListParameter(value);
            registerQueryDerivedReferrer(function, cb.Query(), "MEMBER_STATUS_CODE", "MEMBER_STATUS_CODE", subQueryPropertyName, operand, value, parameterPropertyName);
        }
        public abstract String keepMemberStatusCode_QueryDerivedReferrer_VdSynonymMemberList(VdSynonymMemberCQ subQuery);
        public abstract String keepMemberStatusCode_QueryDerivedReferrer_VdSynonymMemberListParameter(Object parameterValue);

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
            String subQueryPropertyName = keepMemberStatusCode_QueryDerivedReferrer_VdSynonymMemberLoginList(cb.Query()); // for saving query-value.
            String parameterPropertyName = keepMemberStatusCode_QueryDerivedReferrer_VdSynonymMemberLoginListParameter(value);
            registerQueryDerivedReferrer(function, cb.Query(), "MEMBER_STATUS_CODE", "LOGIN_MEMBER_STATUS_CODE", subQueryPropertyName, operand, value, parameterPropertyName);
        }
        public abstract String keepMemberStatusCode_QueryDerivedReferrer_VdSynonymMemberLoginList(VdSynonymMemberLoginCQ subQuery);
        public abstract String keepMemberStatusCode_QueryDerivedReferrer_VdSynonymMemberLoginListParameter(Object parameterValue);

        public QDRFunction<VendorSynonymMemberCB> DerivedVendorSynonymMemberList() {
            return xcreateQDRFunctionVendorSynonymMemberList();
        }
        protected QDRFunction<VendorSynonymMemberCB> xcreateQDRFunctionVendorSynonymMemberList() {
            return new QDRFunction<VendorSynonymMemberCB>(delegate(String function, SubQuery<VendorSynonymMemberCB> subQuery, String operand, Object value) {
                xqderiveVendorSynonymMemberList(function, subQuery, operand, value);
            });
        }
        public void xqderiveVendorSynonymMemberList(String function, SubQuery<VendorSynonymMemberCB> subQuery, String operand, Object value) {
            assertObjectNotNull("subQuery<VendorSynonymMemberCB>", subQuery);
            VendorSynonymMemberCB cb = new VendorSynonymMemberCB(); cb.xsetupForDerivedReferrer(this); subQuery.Invoke(cb);
            String subQueryPropertyName = keepMemberStatusCode_QueryDerivedReferrer_VendorSynonymMemberList(cb.Query()); // for saving query-value.
            String parameterPropertyName = keepMemberStatusCode_QueryDerivedReferrer_VendorSynonymMemberListParameter(value);
            registerQueryDerivedReferrer(function, cb.Query(), "MEMBER_STATUS_CODE", "MEMBER_STATUS_CODE", subQueryPropertyName, operand, value, parameterPropertyName);
        }
        public abstract String keepMemberStatusCode_QueryDerivedReferrer_VendorSynonymMemberList(VendorSynonymMemberCQ subQuery);
        public abstract String keepMemberStatusCode_QueryDerivedReferrer_VendorSynonymMemberListParameter(Object parameterValue);

        public QDRFunction<MemberCB> DerivedMemberList() {
            return xcreateQDRFunctionMemberList();
        }
        protected QDRFunction<MemberCB> xcreateQDRFunctionMemberList() {
            return new QDRFunction<MemberCB>(delegate(String function, SubQuery<MemberCB> subQuery, String operand, Object value) {
                xqderiveMemberList(function, subQuery, operand, value);
            });
        }
        public void xqderiveMemberList(String function, SubQuery<MemberCB> subQuery, String operand, Object value) {
            assertObjectNotNull("subQuery<MemberCB>", subQuery);
            MemberCB cb = new MemberCB(); cb.xsetupForDerivedReferrer(this); subQuery.Invoke(cb);
            String subQueryPropertyName = keepMemberStatusCode_QueryDerivedReferrer_MemberList(cb.Query()); // for saving query-value.
            String parameterPropertyName = keepMemberStatusCode_QueryDerivedReferrer_MemberListParameter(value);
            registerQueryDerivedReferrer(function, cb.Query(), "MEMBER_STATUS_CODE", "MEMBER_STATUS_CODE", subQueryPropertyName, operand, value, parameterPropertyName);
        }
        public abstract String keepMemberStatusCode_QueryDerivedReferrer_MemberList(MemberCQ subQuery);
        public abstract String keepMemberStatusCode_QueryDerivedReferrer_MemberListParameter(Object parameterValue);

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
            String subQueryPropertyName = keepMemberStatusCode_QueryDerivedReferrer_MemberLoginList(cb.Query()); // for saving query-value.
            String parameterPropertyName = keepMemberStatusCode_QueryDerivedReferrer_MemberLoginListParameter(value);
            registerQueryDerivedReferrer(function, cb.Query(), "MEMBER_STATUS_CODE", "LOGIN_MEMBER_STATUS_CODE", subQueryPropertyName, operand, value, parameterPropertyName);
        }
        public abstract String keepMemberStatusCode_QueryDerivedReferrer_MemberLoginList(MemberLoginCQ subQuery);
        public abstract String keepMemberStatusCode_QueryDerivedReferrer_MemberLoginListParameter(Object parameterValue);
        public void SetMemberStatusCode_IsNull() { regMemberStatusCode(CK_ISN, DUMMY_OBJECT); }
        public void SetMemberStatusCode_IsNotNull() { regMemberStatusCode(CK_ISNN, DUMMY_OBJECT); }
        protected void regMemberStatusCode(ConditionKey k, Object v) { regQ(k, v, getCValueMemberStatusCode(), "MEMBER_STATUS_CODE"); }
        protected abstract ConditionValue getCValueMemberStatusCode();

        public void SetMemberStatusName_Equal(String v) { DoSetMemberStatusName_Equal(fRES(v)); }
        protected void DoSetMemberStatusName_Equal(String v) { regMemberStatusName(CK_EQ, v); }
        public void SetMemberStatusName_NotEqual(String v) { DoSetMemberStatusName_NotEqual(fRES(v)); }
        protected void DoSetMemberStatusName_NotEqual(String v) { regMemberStatusName(CK_NES, v); }
        public void SetMemberStatusName_InScope(IList<String> ls) { regINS<String>(CK_INS, cTL<String>(ls), getCValueMemberStatusName(), "MEMBER_STATUS_NAME"); }
        public void SetMemberStatusName_NotInScope(IList<String> ls) { regINS<String>(CK_NINS, cTL<String>(ls), getCValueMemberStatusName(), "MEMBER_STATUS_NAME"); }
        public void SetMemberStatusName_PrefixSearch(String v) { SetMemberStatusName_LikeSearch(v, cLSOP()); }
        public void SetMemberStatusName_LikeSearch(String v, LikeSearchOption option)
        { regLSQ(CK_LS, fRES(v), getCValueMemberStatusName(), "MEMBER_STATUS_NAME", option); }
        public void SetMemberStatusName_NotLikeSearch(String v, LikeSearchOption option)
        { regLSQ(CK_NLS, fRES(v), getCValueMemberStatusName(), "MEMBER_STATUS_NAME", option); }
        protected void regMemberStatusName(ConditionKey k, Object v) { regQ(k, v, getCValueMemberStatusName(), "MEMBER_STATUS_NAME"); }
        protected abstract ConditionValue getCValueMemberStatusName();

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
        public SSQFunction<MemberStatusCB> Scalar_Equal() {
            return xcreateSSQFunction("=");
        }

        public SSQFunction<MemberStatusCB> Scalar_NotEqual() {
            return xcreateSSQFunction("<>");
        }

        public SSQFunction<MemberStatusCB> Scalar_GreaterEqual() {
            return xcreateSSQFunction(">=");
        }

        public SSQFunction<MemberStatusCB> Scalar_GreaterThan() {
            return xcreateSSQFunction(">");
        }

        public SSQFunction<MemberStatusCB> Scalar_LessEqual() {
            return xcreateSSQFunction("<=");
        }

        public SSQFunction<MemberStatusCB> Scalar_LessThan() {
            return xcreateSSQFunction("<");
        }

        protected SSQFunction<MemberStatusCB> xcreateSSQFunction(String operand) {
            return new SSQFunction<MemberStatusCB>(delegate(String function, SubQuery<MemberStatusCB> subQuery) {
                xscalarSubQuery(function, subQuery, operand);
            });
        }

        protected void xscalarSubQuery(String function, SubQuery<MemberStatusCB> subQuery, String operand) {
            assertObjectNotNull("subQuery<MemberStatusCB>", subQuery);
            MemberStatusCB cb = new MemberStatusCB(); cb.xsetupForScalarCondition(this); subQuery.Invoke(cb);
            String subQueryPropertyName = keepScalarSubQuery(cb.Query()); // for saving query-value.
            registerScalarSubQuery(function, cb.Query(), subQueryPropertyName, operand);
        }
        public abstract String keepScalarSubQuery(MemberStatusCQ subQuery);

        // ===============================================================================
        //                                                                  MySelf InScope
        //                                                                  ==============
        public void MyselfInScope(SubQuery<MemberStatusCB> subQuery) {
            assertObjectNotNull("subQuery<MemberStatusCB>", subQuery);
            MemberStatusCB cb = new MemberStatusCB(); cb.xsetupForInScopeRelation(this); subQuery.Invoke(cb);
            String subQueryPropertyName = keepMyselfInScopeSubQuery(cb.Query()); // for saving query-value.
            registerInScopeSubQuery(cb.Query(), "MEMBER_STATUS_CODE", "MEMBER_STATUS_CODE", subQueryPropertyName);
        }
        public abstract String keepMyselfInScopeSubQuery(MemberStatusCQ subQuery);

        public override String ToString() { return xgetSqlClause().getClause(); }
    }
}
