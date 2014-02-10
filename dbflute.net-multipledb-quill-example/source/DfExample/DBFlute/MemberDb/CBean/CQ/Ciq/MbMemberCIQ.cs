
using System;

using DfExample.DBFlute.MemberDb.AllCommon.CBean;
using DfExample.DBFlute.MemberDb.AllCommon.CBean.CKey;
using DfExample.DBFlute.MemberDb.AllCommon.CBean.COption;
using DfExample.DBFlute.MemberDb.AllCommon.CBean.CValue;
using DfExample.DBFlute.MemberDb.AllCommon.CBean.SClause;
using DfExample.DBFlute.MemberDb.AllCommon.JavaLike;
using DfExample.DBFlute.MemberDb.CBean.CQ.BS;
using DfExample.DBFlute.MemberDb.CBean.CQ;

namespace DfExample.DBFlute.MemberDb.CBean.CQ.Ciq {

    [System.Serializable]
    public class MbMemberCIQ : MbAbstractBsMemberCQ {

        // ===============================================================================
        //                                                                       Attribute
        //                                                                       =========
        protected MbBsMemberCQ _myCQ;

        // ===============================================================================
        //                                                                     Constructor
        //                                                                     ===========
        public MbMemberCIQ(MbConditionQuery childQuery, MbSqlClause sqlClause, String aliasName, int nestLevel, MbBsMemberCQ myCQ)
            : base(childQuery, sqlClause, aliasName, nestLevel) {
            _myCQ = myCQ;
            _foreignPropertyName = _myCQ.xgetForeignPropertyName();// Accept foreign property name.
            _relationPath = _myCQ.xgetRelationPath();// Accept relation path.
        }

        // ===================================================================================
        //                                                             Override about Register
        //                                                             =======================
        public override void reflectRelationOnUnionQuery(MbConditionQuery baseQueryAsSuper, MbConditionQuery unionQueryAsSuper) {
            throw new UnsupportedOperationException("InlineQuery must not need UNION method: " + baseQueryAsSuper + " : " + unionQueryAsSuper);
        }
    
        protected override void setupConditionValueAndRegisterWhereClause(MbConditionKey key, Object value, MbConditionValue cvalue, String colName) {
            regIQ(key, value, cvalue, colName);
        }
    
        protected override void setupConditionValueAndRegisterWhereClause(MbConditionKey key, Object value, MbConditionValue cvalue
                                                                        , String colName, MbConditionOption option) {
            regIQ(key, value, cvalue, colName, option);
        }
    
        protected override void registerWhereClause(String whereClause) {
            registerInlineWhereClause(whereClause);
        }
    
        protected override String getInScopeSubQueryRealColumnName(String columnName) {
            if (_onClause) {
                throw new UnsupportedOperationException("InScopeSubQuery of on-clause is unsupported");
            }
            return _onClause ? xgetAliasName() + "." + columnName : columnName;
        }
    
        protected override void registerExistsSubQuery(MbConditionQuery subQuery
                                     , String columnName, String relatedColumnName, String propertyName) {
            throw new UnsupportedOperationException("Sorry! ExistsSubQuery at inline view is unsupported. So please use InScopeSubQyery.");
        }


        protected override MbConditionValue getCValueMemberId() {
            return _myCQ.MemberId;
        }


        public override String keepMemberId_ExistsSubQuery_MemberAddressList(MbMemberAddressCQ subQuery) {
            throw new SystemException("ExistsSubQuery at inline() is unsupported! Sorry!");
            // _myCQ.keepMemberId_ExistsSubQuery_MemberAddressList(subQuery);
        }

        public override String keepMemberId_ExistsSubQuery_MemberLoginList(MbMemberLoginCQ subQuery) {
            throw new SystemException("ExistsSubQuery at inline() is unsupported! Sorry!");
            // _myCQ.keepMemberId_ExistsSubQuery_MemberLoginList(subQuery);
        }

        public override String keepMemberId_ExistsSubQuery_MemberSecurityAsOne(MbMemberSecurityCQ subQuery) {
            throw new SystemException("ExistsSubQuery at inline() is unsupported! Sorry!");
            // _myCQ.keepMemberId_ExistsSubQuery_MemberSecurityAsOne(subQuery);
        }

        public override String keepMemberId_ExistsSubQuery_MemberWithdrawalAsOne(MbMemberWithdrawalCQ subQuery) {
            throw new SystemException("ExistsSubQuery at inline() is unsupported! Sorry!");
            // _myCQ.keepMemberId_ExistsSubQuery_MemberWithdrawalAsOne(subQuery);
        }

        public override String keepMemberId_ExistsSubQuery_PurchaseList(MbPurchaseCQ subQuery) {
            throw new SystemException("ExistsSubQuery at inline() is unsupported! Sorry!");
            // _myCQ.keepMemberId_ExistsSubQuery_PurchaseList(subQuery);
        }

        public override String keepMemberId_NotExistsSubQuery_MemberAddressList(MbMemberAddressCQ subQuery) {
            throw new SystemException("NotExistsSubQuery at inline() is unsupported! Sorry!");
            // _myCQ.keepMemberId_NotExistsSubQuery_MemberAddressList(subQuery);
        }

        public override String keepMemberId_NotExistsSubQuery_MemberLoginList(MbMemberLoginCQ subQuery) {
            throw new SystemException("NotExistsSubQuery at inline() is unsupported! Sorry!");
            // _myCQ.keepMemberId_NotExistsSubQuery_MemberLoginList(subQuery);
        }

        public override String keepMemberId_NotExistsSubQuery_MemberSecurityAsOne(MbMemberSecurityCQ subQuery) {
            throw new SystemException("NotExistsSubQuery at inline() is unsupported! Sorry!");
            // _myCQ.keepMemberId_NotExistsSubQuery_MemberSecurityAsOne(subQuery);
        }

        public override String keepMemberId_NotExistsSubQuery_MemberWithdrawalAsOne(MbMemberWithdrawalCQ subQuery) {
            throw new SystemException("NotExistsSubQuery at inline() is unsupported! Sorry!");
            // _myCQ.keepMemberId_NotExistsSubQuery_MemberWithdrawalAsOne(subQuery);
        }

        public override String keepMemberId_NotExistsSubQuery_PurchaseList(MbPurchaseCQ subQuery) {
            throw new SystemException("NotExistsSubQuery at inline() is unsupported! Sorry!");
            // _myCQ.keepMemberId_NotExistsSubQuery_PurchaseList(subQuery);
        }

        public override String keepMemberId_InScopeSubQuery_MemberAddressList(MbMemberAddressCQ subQuery) {
            return _myCQ.keepMemberId_InScopeSubQuery_MemberAddressList(subQuery);
        }

        public override String keepMemberId_InScopeSubQuery_MemberLoginList(MbMemberLoginCQ subQuery) {
            return _myCQ.keepMemberId_InScopeSubQuery_MemberLoginList(subQuery);
        }

        public override String keepMemberId_InScopeSubQuery_MemberSecurityAsOne(MbMemberSecurityCQ subQuery) {
            return _myCQ.keepMemberId_InScopeSubQuery_MemberSecurityAsOne(subQuery);
        }

        public override String keepMemberId_InScopeSubQuery_MemberWithdrawalAsOne(MbMemberWithdrawalCQ subQuery) {
            return _myCQ.keepMemberId_InScopeSubQuery_MemberWithdrawalAsOne(subQuery);
        }

        public override String keepMemberId_InScopeSubQuery_PurchaseList(MbPurchaseCQ subQuery) {
            return _myCQ.keepMemberId_InScopeSubQuery_PurchaseList(subQuery);
        }

        public override String keepMemberId_NotInScopeSubQuery_MemberAddressList(MbMemberAddressCQ subQuery) {
            return _myCQ.keepMemberId_NotInScopeSubQuery_MemberAddressList(subQuery);
        }

        public override String keepMemberId_NotInScopeSubQuery_MemberLoginList(MbMemberLoginCQ subQuery) {
            return _myCQ.keepMemberId_NotInScopeSubQuery_MemberLoginList(subQuery);
        }

        public override String keepMemberId_NotInScopeSubQuery_MemberSecurityAsOne(MbMemberSecurityCQ subQuery) {
            return _myCQ.keepMemberId_NotInScopeSubQuery_MemberSecurityAsOne(subQuery);
        }

        public override String keepMemberId_NotInScopeSubQuery_MemberWithdrawalAsOne(MbMemberWithdrawalCQ subQuery) {
            return _myCQ.keepMemberId_NotInScopeSubQuery_MemberWithdrawalAsOne(subQuery);
        }

        public override String keepMemberId_NotInScopeSubQuery_PurchaseList(MbPurchaseCQ subQuery) {
            return _myCQ.keepMemberId_NotInScopeSubQuery_PurchaseList(subQuery);
        }
        public override String keepMemberId_SpecifyDerivedReferrer_MemberAddressList(MbMemberAddressCQ subQuery) {
            throw new UnsupportedOperationException("(Specify)DerivedReferrer at inline() is unsupported! Sorry!");
        }
        public override String keepMemberId_SpecifyDerivedReferrer_MemberLoginList(MbMemberLoginCQ subQuery) {
            throw new UnsupportedOperationException("(Specify)DerivedReferrer at inline() is unsupported! Sorry!");
        }
        public override String keepMemberId_SpecifyDerivedReferrer_PurchaseList(MbPurchaseCQ subQuery) {
            throw new UnsupportedOperationException("(Specify)DerivedReferrer at inline() is unsupported! Sorry!");
        }
        public override String keepMemberId_QueryDerivedReferrer_MemberAddressList(MbMemberAddressCQ subQuery) {
            throw new UnsupportedOperationException("(Query)DerivedReferrer at inline() is unsupported! Sorry!");
        }
        public override String keepMemberId_QueryDerivedReferrer_MemberAddressListParameter(Object parameterValue) {
            throw new UnsupportedOperationException("(Query)DerivedReferrer at inline() is unsupported! Sorry!");
        }
        public override String keepMemberId_QueryDerivedReferrer_MemberLoginList(MbMemberLoginCQ subQuery) {
            throw new UnsupportedOperationException("(Query)DerivedReferrer at inline() is unsupported! Sorry!");
        }
        public override String keepMemberId_QueryDerivedReferrer_MemberLoginListParameter(Object parameterValue) {
            throw new UnsupportedOperationException("(Query)DerivedReferrer at inline() is unsupported! Sorry!");
        }
        public override String keepMemberId_QueryDerivedReferrer_PurchaseList(MbPurchaseCQ subQuery) {
            throw new UnsupportedOperationException("(Query)DerivedReferrer at inline() is unsupported! Sorry!");
        }
        public override String keepMemberId_QueryDerivedReferrer_PurchaseListParameter(Object parameterValue) {
            throw new UnsupportedOperationException("(Query)DerivedReferrer at inline() is unsupported! Sorry!");
        }

        protected override MbConditionValue getCValueMemberName() {
            return _myCQ.MemberName;
        }


        protected override MbConditionValue getCValueMemberAccount() {
            return _myCQ.MemberAccount;
        }


        protected override MbConditionValue getCValueMemberStatusCode() {
            return _myCQ.MemberStatusCode;
        }


        public override String keepMemberStatusCode_InScopeSubQuery_MemberStatus(MbMemberStatusCQ subQuery) {
            return _myCQ.keepMemberStatusCode_InScopeSubQuery_MemberStatus(subQuery);
        }

        public override String keepMemberStatusCode_NotInScopeSubQuery_MemberStatus(MbMemberStatusCQ subQuery) {
            return _myCQ.keepMemberStatusCode_NotInScopeSubQuery_MemberStatus(subQuery);
        }

        protected override MbConditionValue getCValueFormalizedDatetime() {
            return _myCQ.FormalizedDatetime;
        }


        protected override MbConditionValue getCValueBirthdate() {
            return _myCQ.Birthdate;
        }


        protected override MbConditionValue getCValueRegisterDatetime() {
            return _myCQ.RegisterDatetime;
        }


        protected override MbConditionValue getCValueRegisterUser() {
            return _myCQ.RegisterUser;
        }


        protected override MbConditionValue getCValueRegisterProcess() {
            return _myCQ.RegisterProcess;
        }


        protected override MbConditionValue getCValueUpdateDatetime() {
            return _myCQ.UpdateDatetime;
        }


        protected override MbConditionValue getCValueUpdateUser() {
            return _myCQ.UpdateUser;
        }


        protected override MbConditionValue getCValueUpdateProcess() {
            return _myCQ.UpdateProcess;
        }


        protected override MbConditionValue getCValueVersionNo() {
            return _myCQ.VersionNo;
        }


        // ===================================================================================
        //                                                                     Scalar SubQuery
        //                                                                     ===============
        public override String keepScalarSubQuery(MbMemberCQ subQuery) {
            throw new UnsupportedOperationException("ScalarSubQuery at inline() is unsupported! Sorry!");
        }

        // ===============================================================================
        //                                                         Myself InScope SubQuery
        //                                                         =======================
        public override String keepMyselfInScopeSubQuery(MbMemberCQ subQuery) {
            throw new UnsupportedOperationException("MyselfInScopeSubQuery at inline() is unsupported! Sorry!");
        }
    }
}
