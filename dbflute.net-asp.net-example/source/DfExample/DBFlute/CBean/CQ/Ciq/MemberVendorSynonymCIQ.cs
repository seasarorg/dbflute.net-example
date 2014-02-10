
using System;

using DfExample.DBFlute.AllCommon.CBean;
using DfExample.DBFlute.AllCommon.CBean.CKey;
using DfExample.DBFlute.AllCommon.CBean.COption;
using DfExample.DBFlute.AllCommon.CBean.CValue;
using DfExample.DBFlute.AllCommon.CBean.SClause;
using DfExample.DBFlute.AllCommon.JavaLike;
using DfExample.DBFlute.CBean.CQ.BS;
using DfExample.DBFlute.CBean.CQ;

namespace DfExample.DBFlute.CBean.CQ.Ciq {

    [System.Serializable]
    public class MemberVendorSynonymCIQ : AbstractBsMemberVendorSynonymCQ {

        // ===============================================================================
        //                                                                       Attribute
        //                                                                       =========
        protected BsMemberVendorSynonymCQ _myCQ;

        // ===============================================================================
        //                                                                     Constructor
        //                                                                     ===========
        public MemberVendorSynonymCIQ(ConditionQuery childQuery, SqlClause sqlClause, String aliasName, int nestLevel, BsMemberVendorSynonymCQ myCQ)
            : base(childQuery, sqlClause, aliasName, nestLevel) {
            _myCQ = myCQ;
            _foreignPropertyName = _myCQ.xgetForeignPropertyName();// Accept foreign property name.
            _relationPath = _myCQ.xgetRelationPath();// Accept relation path.
        }

        // ===================================================================================
        //                                                             Override about Register
        //                                                             =======================
        public override void reflectRelationOnUnionQuery(ConditionQuery baseQueryAsSuper, ConditionQuery unionQueryAsSuper) {
            throw new UnsupportedOperationException("InlineQuery must not need UNION method: " + baseQueryAsSuper + " : " + unionQueryAsSuper);
        }
    
        protected override void setupConditionValueAndRegisterWhereClause(ConditionKey key, Object value, ConditionValue cvalue, String colName) {
            regIQ(key, value, cvalue, colName);
        }
    
        protected override void setupConditionValueAndRegisterWhereClause(ConditionKey key, Object value, ConditionValue cvalue
                                                                        , String colName, ConditionOption option) {
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
    
        protected override void registerExistsSubQuery(ConditionQuery subQuery
                                     , String columnName, String relatedColumnName, String propertyName) {
            throw new UnsupportedOperationException("Sorry! ExistsSubQuery at inline view is unsupported. So please use InScopeSubQyery.");
        }


        protected override ConditionValue getCValueMemberId() {
            return _myCQ.MemberId;
        }


        public override String keepMemberId_ExistsSubQuery_VdSynonymMemberLoginList(VdSynonymMemberLoginCQ subQuery) {
            throw new SystemException("ExistsSubQuery at inline() is unsupported! Sorry!");
            // _myCQ.keepMemberId_ExistsSubQuery_VdSynonymMemberLoginList(subQuery);
        }

        public override String keepMemberId_ExistsSubQuery_VdSynonymMemberWithdrawalAsOne(VdSynonymMemberWithdrawalCQ subQuery) {
            throw new SystemException("ExistsSubQuery at inline() is unsupported! Sorry!");
            // _myCQ.keepMemberId_ExistsSubQuery_VdSynonymMemberWithdrawalAsOne(subQuery);
        }

        public override String keepMemberId_NotExistsSubQuery_VdSynonymMemberLoginList(VdSynonymMemberLoginCQ subQuery) {
            throw new SystemException("NotExistsSubQuery at inline() is unsupported! Sorry!");
            // _myCQ.keepMemberId_NotExistsSubQuery_VdSynonymMemberLoginList(subQuery);
        }

        public override String keepMemberId_NotExistsSubQuery_VdSynonymMemberWithdrawalAsOne(VdSynonymMemberWithdrawalCQ subQuery) {
            throw new SystemException("NotExistsSubQuery at inline() is unsupported! Sorry!");
            // _myCQ.keepMemberId_NotExistsSubQuery_VdSynonymMemberWithdrawalAsOne(subQuery);
        }

        public override String keepMemberId_InScopeSubQuery_VdSynonymMemberLoginList(VdSynonymMemberLoginCQ subQuery) {
            return _myCQ.keepMemberId_InScopeSubQuery_VdSynonymMemberLoginList(subQuery);
        }

        public override String keepMemberId_InScopeSubQuery_VdSynonymMemberWithdrawalAsOne(VdSynonymMemberWithdrawalCQ subQuery) {
            return _myCQ.keepMemberId_InScopeSubQuery_VdSynonymMemberWithdrawalAsOne(subQuery);
        }

        public override String keepMemberId_NotInScopeSubQuery_VdSynonymMemberLoginList(VdSynonymMemberLoginCQ subQuery) {
            return _myCQ.keepMemberId_NotInScopeSubQuery_VdSynonymMemberLoginList(subQuery);
        }

        public override String keepMemberId_NotInScopeSubQuery_VdSynonymMemberWithdrawalAsOne(VdSynonymMemberWithdrawalCQ subQuery) {
            return _myCQ.keepMemberId_NotInScopeSubQuery_VdSynonymMemberWithdrawalAsOne(subQuery);
        }
        public override String keepMemberId_SpecifyDerivedReferrer_VdSynonymMemberLoginList(VdSynonymMemberLoginCQ subQuery) {
            throw new UnsupportedOperationException("(Specify)DerivedReferrer at inline() is unsupported! Sorry!");
        }
        public override String keepMemberId_QueryDerivedReferrer_VdSynonymMemberLoginList(VdSynonymMemberLoginCQ subQuery) {
            throw new UnsupportedOperationException("(Query)DerivedReferrer at inline() is unsupported! Sorry!");
        }
        public override String keepMemberId_QueryDerivedReferrer_VdSynonymMemberLoginListParameter(Object parameterValue) {
            throw new UnsupportedOperationException("(Query)DerivedReferrer at inline() is unsupported! Sorry!");
        }

        protected override ConditionValue getCValueMemberName() {
            return _myCQ.MemberName;
        }


        protected override ConditionValue getCValueMemberAccount() {
            return _myCQ.MemberAccount;
        }


        protected override ConditionValue getCValueMemberStatusCode() {
            return _myCQ.MemberStatusCode;
        }


        public override String keepMemberStatusCode_InScopeSubQuery_MemberStatus(MemberStatusCQ subQuery) {
            return _myCQ.keepMemberStatusCode_InScopeSubQuery_MemberStatus(subQuery);
        }

        public override String keepMemberStatusCode_NotInScopeSubQuery_MemberStatus(MemberStatusCQ subQuery) {
            return _myCQ.keepMemberStatusCode_NotInScopeSubQuery_MemberStatus(subQuery);
        }

        protected override ConditionValue getCValueFormalizedDatetime() {
            return _myCQ.FormalizedDatetime;
        }


        protected override ConditionValue getCValueBirthdate() {
            return _myCQ.Birthdate;
        }


        protected override ConditionValue getCValueRegisterDatetime() {
            return _myCQ.RegisterDatetime;
        }


        protected override ConditionValue getCValueRegisterUser() {
            return _myCQ.RegisterUser;
        }


        protected override ConditionValue getCValueRegisterProcess() {
            return _myCQ.RegisterProcess;
        }


        protected override ConditionValue getCValueUpdateDatetime() {
            return _myCQ.UpdateDatetime;
        }


        protected override ConditionValue getCValueUpdateUser() {
            return _myCQ.UpdateUser;
        }


        protected override ConditionValue getCValueUpdateProcess() {
            return _myCQ.UpdateProcess;
        }


        protected override ConditionValue getCValueVersionNo() {
            return _myCQ.VersionNo;
        }


        // ===================================================================================
        //                                                                     Scalar SubQuery
        //                                                                     ===============
        public override String keepScalarSubQuery(MemberVendorSynonymCQ subQuery) {
            throw new UnsupportedOperationException("ScalarSubQuery at inline() is unsupported! Sorry!");
        }

        // ===============================================================================
        //                                                         Myself InScope SubQuery
        //                                                         =======================
        public override String keepMyselfInScopeSubQuery(MemberVendorSynonymCQ subQuery) {
            throw new UnsupportedOperationException("MyselfInScopeSubQuery at inline() is unsupported! Sorry!");
        }
    }
}
