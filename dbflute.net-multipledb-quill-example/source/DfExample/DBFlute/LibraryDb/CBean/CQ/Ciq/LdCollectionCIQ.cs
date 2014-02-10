
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
    public class LdCollectionCIQ : LdAbstractBsCollectionCQ {

        // ===============================================================================
        //                                                                       Attribute
        //                                                                       =========
        protected LdBsCollectionCQ _myCQ;

        // ===============================================================================
        //                                                                     Constructor
        //                                                                     ===========
        public LdCollectionCIQ(LdConditionQuery childQuery, LdSqlClause sqlClause, String aliasName, int nestLevel, LdBsCollectionCQ myCQ)
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


        protected override LdConditionValue getCValueCollectionId() {
            return _myCQ.CollectionId;
        }


        public override String keepCollectionId_ExistsSubQuery_CollectionStatusAsOne(LdCollectionStatusCQ subQuery) {
            throw new SystemException("ExistsSubQuery at inline() is unsupported! Sorry!");
            // _myCQ.keepCollectionId_ExistsSubQuery_CollectionStatusAsOne(subQuery);
        }

        public override String keepCollectionId_ExistsSubQuery_LendingCollectionList(LdLendingCollectionCQ subQuery) {
            throw new SystemException("ExistsSubQuery at inline() is unsupported! Sorry!");
            // _myCQ.keepCollectionId_ExistsSubQuery_LendingCollectionList(subQuery);
        }

        public override String keepCollectionId_NotExistsSubQuery_CollectionStatusAsOne(LdCollectionStatusCQ subQuery) {
            throw new SystemException("NotExistsSubQuery at inline() is unsupported! Sorry!");
            // _myCQ.keepCollectionId_NotExistsSubQuery_CollectionStatusAsOne(subQuery);
        }

        public override String keepCollectionId_NotExistsSubQuery_LendingCollectionList(LdLendingCollectionCQ subQuery) {
            throw new SystemException("NotExistsSubQuery at inline() is unsupported! Sorry!");
            // _myCQ.keepCollectionId_NotExistsSubQuery_LendingCollectionList(subQuery);
        }

        public override String keepCollectionId_InScopeSubQuery_CollectionStatusAsOne(LdCollectionStatusCQ subQuery) {
            return _myCQ.keepCollectionId_InScopeSubQuery_CollectionStatusAsOne(subQuery);
        }

        public override String keepCollectionId_InScopeSubQuery_LendingCollectionList(LdLendingCollectionCQ subQuery) {
            return _myCQ.keepCollectionId_InScopeSubQuery_LendingCollectionList(subQuery);
        }

        public override String keepCollectionId_NotInScopeSubQuery_CollectionStatusAsOne(LdCollectionStatusCQ subQuery) {
            return _myCQ.keepCollectionId_NotInScopeSubQuery_CollectionStatusAsOne(subQuery);
        }

        public override String keepCollectionId_NotInScopeSubQuery_LendingCollectionList(LdLendingCollectionCQ subQuery) {
            return _myCQ.keepCollectionId_NotInScopeSubQuery_LendingCollectionList(subQuery);
        }
        public override String keepCollectionId_SpecifyDerivedReferrer_LendingCollectionList(LdLendingCollectionCQ subQuery) {
            throw new UnsupportedOperationException("(Specify)DerivedReferrer at inline() is unsupported! Sorry!");
        }
        public override String keepCollectionId_QueryDerivedReferrer_LendingCollectionList(LdLendingCollectionCQ subQuery) {
            throw new UnsupportedOperationException("(Query)DerivedReferrer at inline() is unsupported! Sorry!");
        }
        public override String keepCollectionId_QueryDerivedReferrer_LendingCollectionListParameter(Object parameterValue) {
            throw new UnsupportedOperationException("(Query)DerivedReferrer at inline() is unsupported! Sorry!");
        }

        protected override LdConditionValue getCValueLibraryId() {
            return _myCQ.LibraryId;
        }


        public override String keepLibraryId_InScopeSubQuery_Library(LdLibraryCQ subQuery) {
            return _myCQ.keepLibraryId_InScopeSubQuery_Library(subQuery);
        }

        public override String keepLibraryId_NotInScopeSubQuery_Library(LdLibraryCQ subQuery) {
            return _myCQ.keepLibraryId_NotInScopeSubQuery_Library(subQuery);
        }

        protected override LdConditionValue getCValueBookId() {
            return _myCQ.BookId;
        }


        public override String keepBookId_InScopeSubQuery_Book(LdBookCQ subQuery) {
            return _myCQ.keepBookId_InScopeSubQuery_Book(subQuery);
        }

        public override String keepBookId_NotInScopeSubQuery_Book(LdBookCQ subQuery) {
            return _myCQ.keepBookId_NotInScopeSubQuery_Book(subQuery);
        }

        protected override LdConditionValue getCValueArrivalDate() {
            return _myCQ.ArrivalDate;
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
        public override String keepScalarSubQuery(LdCollectionCQ subQuery) {
            throw new UnsupportedOperationException("ScalarSubQuery at inline() is unsupported! Sorry!");
        }

        // ===============================================================================
        //                                                         Myself InScope SubQuery
        //                                                         =======================
        public override String keepMyselfInScopeSubQuery(LdCollectionCQ subQuery) {
            throw new UnsupportedOperationException("MyselfInScopeSubQuery at inline() is unsupported! Sorry!");
        }
    }
}
