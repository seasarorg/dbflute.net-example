
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
    public class LdLibraryCIQ : LdAbstractBsLibraryCQ {

        // ===============================================================================
        //                                                                       Attribute
        //                                                                       =========
        protected LdBsLibraryCQ _myCQ;

        // ===============================================================================
        //                                                                     Constructor
        //                                                                     ===========
        public LdLibraryCIQ(LdConditionQuery childQuery, LdSqlClause sqlClause, String aliasName, int nestLevel, LdBsLibraryCQ myCQ)
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


        protected override LdConditionValue getCValueLibraryId() {
            return _myCQ.LibraryId;
        }


        public override String keepLibraryId_ExistsSubQuery_CollectionList(LdCollectionCQ subQuery) {
            throw new SystemException("ExistsSubQuery at inline() is unsupported! Sorry!");
            // _myCQ.keepLibraryId_ExistsSubQuery_CollectionList(subQuery);
        }

        public override String keepLibraryId_ExistsSubQuery_LibraryUserList(LdLibraryUserCQ subQuery) {
            throw new SystemException("ExistsSubQuery at inline() is unsupported! Sorry!");
            // _myCQ.keepLibraryId_ExistsSubQuery_LibraryUserList(subQuery);
        }

        public override String keepLibraryId_ExistsSubQuery_NextLibraryByLibraryIdList(LdNextLibraryCQ subQuery) {
            throw new SystemException("ExistsSubQuery at inline() is unsupported! Sorry!");
            // _myCQ.keepLibraryId_ExistsSubQuery_NextLibraryByLibraryIdList(subQuery);
        }

        public override String keepLibraryId_ExistsSubQuery_NextLibraryByNextLibraryIdList(LdNextLibraryCQ subQuery) {
            throw new SystemException("ExistsSubQuery at inline() is unsupported! Sorry!");
            // _myCQ.keepLibraryId_ExistsSubQuery_NextLibraryByNextLibraryIdList(subQuery);
        }

        public override String keepLibraryId_NotExistsSubQuery_CollectionList(LdCollectionCQ subQuery) {
            throw new SystemException("NotExistsSubQuery at inline() is unsupported! Sorry!");
            // _myCQ.keepLibraryId_NotExistsSubQuery_CollectionList(subQuery);
        }

        public override String keepLibraryId_NotExistsSubQuery_LibraryUserList(LdLibraryUserCQ subQuery) {
            throw new SystemException("NotExistsSubQuery at inline() is unsupported! Sorry!");
            // _myCQ.keepLibraryId_NotExistsSubQuery_LibraryUserList(subQuery);
        }

        public override String keepLibraryId_NotExistsSubQuery_NextLibraryByLibraryIdList(LdNextLibraryCQ subQuery) {
            throw new SystemException("NotExistsSubQuery at inline() is unsupported! Sorry!");
            // _myCQ.keepLibraryId_NotExistsSubQuery_NextLibraryByLibraryIdList(subQuery);
        }

        public override String keepLibraryId_NotExistsSubQuery_NextLibraryByNextLibraryIdList(LdNextLibraryCQ subQuery) {
            throw new SystemException("NotExistsSubQuery at inline() is unsupported! Sorry!");
            // _myCQ.keepLibraryId_NotExistsSubQuery_NextLibraryByNextLibraryIdList(subQuery);
        }

        public override String keepLibraryId_InScopeSubQuery_CollectionList(LdCollectionCQ subQuery) {
            return _myCQ.keepLibraryId_InScopeSubQuery_CollectionList(subQuery);
        }

        public override String keepLibraryId_InScopeSubQuery_LibraryUserList(LdLibraryUserCQ subQuery) {
            return _myCQ.keepLibraryId_InScopeSubQuery_LibraryUserList(subQuery);
        }

        public override String keepLibraryId_InScopeSubQuery_NextLibraryByLibraryIdList(LdNextLibraryCQ subQuery) {
            return _myCQ.keepLibraryId_InScopeSubQuery_NextLibraryByLibraryIdList(subQuery);
        }

        public override String keepLibraryId_InScopeSubQuery_NextLibraryByNextLibraryIdList(LdNextLibraryCQ subQuery) {
            return _myCQ.keepLibraryId_InScopeSubQuery_NextLibraryByNextLibraryIdList(subQuery);
        }

        public override String keepLibraryId_NotInScopeSubQuery_CollectionList(LdCollectionCQ subQuery) {
            return _myCQ.keepLibraryId_NotInScopeSubQuery_CollectionList(subQuery);
        }

        public override String keepLibraryId_NotInScopeSubQuery_LibraryUserList(LdLibraryUserCQ subQuery) {
            return _myCQ.keepLibraryId_NotInScopeSubQuery_LibraryUserList(subQuery);
        }

        public override String keepLibraryId_NotInScopeSubQuery_NextLibraryByLibraryIdList(LdNextLibraryCQ subQuery) {
            return _myCQ.keepLibraryId_NotInScopeSubQuery_NextLibraryByLibraryIdList(subQuery);
        }

        public override String keepLibraryId_NotInScopeSubQuery_NextLibraryByNextLibraryIdList(LdNextLibraryCQ subQuery) {
            return _myCQ.keepLibraryId_NotInScopeSubQuery_NextLibraryByNextLibraryIdList(subQuery);
        }
        public override String keepLibraryId_SpecifyDerivedReferrer_CollectionList(LdCollectionCQ subQuery) {
            throw new UnsupportedOperationException("(Specify)DerivedReferrer at inline() is unsupported! Sorry!");
        }
        public override String keepLibraryId_SpecifyDerivedReferrer_LibraryUserList(LdLibraryUserCQ subQuery) {
            throw new UnsupportedOperationException("(Specify)DerivedReferrer at inline() is unsupported! Sorry!");
        }
        public override String keepLibraryId_SpecifyDerivedReferrer_NextLibraryByLibraryIdList(LdNextLibraryCQ subQuery) {
            throw new UnsupportedOperationException("(Specify)DerivedReferrer at inline() is unsupported! Sorry!");
        }
        public override String keepLibraryId_SpecifyDerivedReferrer_NextLibraryByNextLibraryIdList(LdNextLibraryCQ subQuery) {
            throw new UnsupportedOperationException("(Specify)DerivedReferrer at inline() is unsupported! Sorry!");
        }
        public override String keepLibraryId_QueryDerivedReferrer_CollectionList(LdCollectionCQ subQuery) {
            throw new UnsupportedOperationException("(Query)DerivedReferrer at inline() is unsupported! Sorry!");
        }
        public override String keepLibraryId_QueryDerivedReferrer_CollectionListParameter(Object parameterValue) {
            throw new UnsupportedOperationException("(Query)DerivedReferrer at inline() is unsupported! Sorry!");
        }
        public override String keepLibraryId_QueryDerivedReferrer_LibraryUserList(LdLibraryUserCQ subQuery) {
            throw new UnsupportedOperationException("(Query)DerivedReferrer at inline() is unsupported! Sorry!");
        }
        public override String keepLibraryId_QueryDerivedReferrer_LibraryUserListParameter(Object parameterValue) {
            throw new UnsupportedOperationException("(Query)DerivedReferrer at inline() is unsupported! Sorry!");
        }
        public override String keepLibraryId_QueryDerivedReferrer_NextLibraryByLibraryIdList(LdNextLibraryCQ subQuery) {
            throw new UnsupportedOperationException("(Query)DerivedReferrer at inline() is unsupported! Sorry!");
        }
        public override String keepLibraryId_QueryDerivedReferrer_NextLibraryByLibraryIdListParameter(Object parameterValue) {
            throw new UnsupportedOperationException("(Query)DerivedReferrer at inline() is unsupported! Sorry!");
        }
        public override String keepLibraryId_QueryDerivedReferrer_NextLibraryByNextLibraryIdList(LdNextLibraryCQ subQuery) {
            throw new UnsupportedOperationException("(Query)DerivedReferrer at inline() is unsupported! Sorry!");
        }
        public override String keepLibraryId_QueryDerivedReferrer_NextLibraryByNextLibraryIdListParameter(Object parameterValue) {
            throw new UnsupportedOperationException("(Query)DerivedReferrer at inline() is unsupported! Sorry!");
        }

        protected override LdConditionValue getCValueLibraryName() {
            return _myCQ.LibraryName;
        }


        protected override LdConditionValue getCValueLibraryTypeCode() {
            return _myCQ.LibraryTypeCode;
        }


        public override String keepLibraryTypeCode_InScopeSubQuery_LibraryTypeLookup(LdLibraryTypeLookupCQ subQuery) {
            return _myCQ.keepLibraryTypeCode_InScopeSubQuery_LibraryTypeLookup(subQuery);
        }

        public override String keepLibraryTypeCode_NotInScopeSubQuery_LibraryTypeLookup(LdLibraryTypeLookupCQ subQuery) {
            return _myCQ.keepLibraryTypeCode_NotInScopeSubQuery_LibraryTypeLookup(subQuery);
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
        public override String keepScalarSubQuery(LdLibraryCQ subQuery) {
            throw new UnsupportedOperationException("ScalarSubQuery at inline() is unsupported! Sorry!");
        }

        // ===============================================================================
        //                                                         Myself InScope SubQuery
        //                                                         =======================
        public override String keepMyselfInScopeSubQuery(LdLibraryCQ subQuery) {
            throw new UnsupportedOperationException("MyselfInScopeSubQuery at inline() is unsupported! Sorry!");
        }
    }
}
