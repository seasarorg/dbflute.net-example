
using System;

using DfExample.DBFlute.LibraryDb.AllCommon.CBean;
using DfExample.DBFlute.LibraryDb.AllCommon.CBean.CKey;
using DfExample.DBFlute.LibraryDb.AllCommon.CBean.COption;
using DfExample.DBFlute.LibraryDb.AllCommon.CBean.CValue;
using DfExample.DBFlute.LibraryDb.AllCommon.CBean.SClause;
using DfExample.DBFlute.LibraryDb.AllCommon.JavaLike;
using DfExample.DBFlute.LibraryDb.CBean.CQ.BS;
using DfExample.DBFlute.LibraryDb.CBean.CQ;

namespace DfExample.DBFlute.LibraryDb.CBean.CQ.Ciq {

    [System.Serializable]
    public class LdLbUserCIQ : LdAbstractBsLbUserCQ {

        // ===============================================================================
        //                                                                       Attribute
        //                                                                       =========
        protected LdBsLbUserCQ _myCQ;

        // ===============================================================================
        //                                                                     Constructor
        //                                                                     ===========
        public LdLbUserCIQ(LdConditionQuery childQuery, LdSqlClause sqlClause, String aliasName, int nestLevel, LdBsLbUserCQ myCQ)
            : base(childQuery, sqlClause, aliasName, nestLevel) {
            _myCQ = myCQ;
            _foreignPropertyName = _myCQ.xgetForeignPropertyName();// Accept foreign property name.
            _relationPath = _myCQ.xgetRelationPath();// Accept relation path.
        }

        // ===================================================================================
        //                                                             Override about Register
        //                                                             =======================
        public override void reflectRelationOnUnionQuery(LdConditionQuery baseQueryAsSuper, LdConditionQuery unionQueryAsSuper) {
            throw new UnsupportedOperationException("InlineQuery must not need UNION method: " + baseQueryAsSuper + " : " + unionQueryAsSuper);
        }
    
        protected override void setupConditionValueAndRegisterWhereClause(LdConditionKey key, Object value, LdConditionValue cvalue, String colName) {
            regIQ(key, value, cvalue, colName);
        }
    
        protected override void setupConditionValueAndRegisterWhereClause(LdConditionKey key, Object value, LdConditionValue cvalue
                                                                        , String colName, LdConditionOption option) {
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
    
        protected override void registerExistsSubQuery(LdConditionQuery subQuery
                                     , String columnName, String relatedColumnName, String propertyName) {
            throw new UnsupportedOperationException("Sorry! ExistsSubQuery at inline view is unsupported. So please use InScopeSubQyery.");
        }


        protected override LdConditionValue getCValueLbUserId() {
            return _myCQ.LbUserId;
        }


        public override String keepLbUserId_ExistsSubQuery_BlackListAsOne(LdBlackListCQ subQuery) {
            throw new SystemException("ExistsSubQuery at inline() is unsupported! Sorry!");
            // _myCQ.keepLbUserId_ExistsSubQuery_BlackListAsOne(subQuery);
        }

        public override String keepLbUserId_ExistsSubQuery_LibraryUserList(LdLibraryUserCQ subQuery) {
            throw new SystemException("ExistsSubQuery at inline() is unsupported! Sorry!");
            // _myCQ.keepLbUserId_ExistsSubQuery_LibraryUserList(subQuery);
        }

        public override String keepLbUserId_NotExistsSubQuery_BlackListAsOne(LdBlackListCQ subQuery) {
            throw new SystemException("NotExistsSubQuery at inline() is unsupported! Sorry!");
            // _myCQ.keepLbUserId_NotExistsSubQuery_BlackListAsOne(subQuery);
        }

        public override String keepLbUserId_NotExistsSubQuery_LibraryUserList(LdLibraryUserCQ subQuery) {
            throw new SystemException("NotExistsSubQuery at inline() is unsupported! Sorry!");
            // _myCQ.keepLbUserId_NotExistsSubQuery_LibraryUserList(subQuery);
        }

        public override String keepLbUserId_InScopeSubQuery_BlackListAsOne(LdBlackListCQ subQuery) {
            return _myCQ.keepLbUserId_InScopeSubQuery_BlackListAsOne(subQuery);
        }

        public override String keepLbUserId_InScopeSubQuery_LibraryUserList(LdLibraryUserCQ subQuery) {
            return _myCQ.keepLbUserId_InScopeSubQuery_LibraryUserList(subQuery);
        }

        public override String keepLbUserId_NotInScopeSubQuery_BlackListAsOne(LdBlackListCQ subQuery) {
            return _myCQ.keepLbUserId_NotInScopeSubQuery_BlackListAsOne(subQuery);
        }

        public override String keepLbUserId_NotInScopeSubQuery_LibraryUserList(LdLibraryUserCQ subQuery) {
            return _myCQ.keepLbUserId_NotInScopeSubQuery_LibraryUserList(subQuery);
        }
        public override String keepLbUserId_SpecifyDerivedReferrer_LibraryUserList(LdLibraryUserCQ subQuery) {
            throw new UnsupportedOperationException("(Specify)DerivedReferrer at inline() is unsupported! Sorry!");
        }
        public override String keepLbUserId_QueryDerivedReferrer_LibraryUserList(LdLibraryUserCQ subQuery) {
            throw new UnsupportedOperationException("(Query)DerivedReferrer at inline() is unsupported! Sorry!");
        }
        public override String keepLbUserId_QueryDerivedReferrer_LibraryUserListParameter(Object parameterValue) {
            throw new UnsupportedOperationException("(Query)DerivedReferrer at inline() is unsupported! Sorry!");
        }

        protected override LdConditionValue getCValueLbUserName() {
            return _myCQ.LbUserName;
        }


        protected override LdConditionValue getCValueUserPassword() {
            return _myCQ.UserPassword;
        }


        protected override LdConditionValue getCValueRUser() {
            return _myCQ.RUser;
        }


        protected override LdConditionValue getCValueRModule() {
            return _myCQ.RModule;
        }


        protected override LdConditionValue getCValueRTimestamp() {
            return _myCQ.RTimestamp;
        }


        protected override LdConditionValue getCValueUUser() {
            return _myCQ.UUser;
        }


        protected override LdConditionValue getCValueUModule() {
            return _myCQ.UModule;
        }


        protected override LdConditionValue getCValueUTimestamp() {
            return _myCQ.UTimestamp;
        }


        // ===================================================================================
        //                                                                     Scalar SubQuery
        //                                                                     ===============
        public override String keepScalarSubQuery(LdLbUserCQ subQuery) {
            throw new UnsupportedOperationException("ScalarSubQuery at inline() is unsupported! Sorry!");
        }

        // ===============================================================================
        //                                                         Myself InScope SubQuery
        //                                                         =======================
        public override String keepMyselfInScopeSubQuery(LdLbUserCQ subQuery) {
            throw new UnsupportedOperationException("MyselfInScopeSubQuery at inline() is unsupported! Sorry!");
        }
    }
}
