
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
    public class LdBookCIQ : LdAbstractBsBookCQ {

        // ===============================================================================
        //                                                                       Attribute
        //                                                                       =========
        protected LdBsBookCQ _myCQ;

        // ===============================================================================
        //                                                                     Constructor
        //                                                                     ===========
        public LdBookCIQ(LdConditionQuery childQuery, LdSqlClause sqlClause, String aliasName, int nestLevel, LdBsBookCQ myCQ)
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


        protected override LdConditionValue getCValueBookId() {
            return _myCQ.BookId;
        }


        public override String keepBookId_ExistsSubQuery_CollectionList(LdCollectionCQ subQuery) {
            throw new SystemException("ExistsSubQuery at inline() is unsupported! Sorry!");
            // _myCQ.keepBookId_ExistsSubQuery_CollectionList(subQuery);
        }

        public override String keepBookId_NotExistsSubQuery_CollectionList(LdCollectionCQ subQuery) {
            throw new SystemException("NotExistsSubQuery at inline() is unsupported! Sorry!");
            // _myCQ.keepBookId_NotExistsSubQuery_CollectionList(subQuery);
        }

        public override String keepBookId_InScopeSubQuery_CollectionList(LdCollectionCQ subQuery) {
            return _myCQ.keepBookId_InScopeSubQuery_CollectionList(subQuery);
        }

        public override String keepBookId_NotInScopeSubQuery_CollectionList(LdCollectionCQ subQuery) {
            return _myCQ.keepBookId_NotInScopeSubQuery_CollectionList(subQuery);
        }
        public override String keepBookId_SpecifyDerivedReferrer_CollectionList(LdCollectionCQ subQuery) {
            throw new UnsupportedOperationException("(Specify)DerivedReferrer at inline() is unsupported! Sorry!");
        }
        public override String keepBookId_QueryDerivedReferrer_CollectionList(LdCollectionCQ subQuery) {
            throw new UnsupportedOperationException("(Query)DerivedReferrer at inline() is unsupported! Sorry!");
        }
        public override String keepBookId_QueryDerivedReferrer_CollectionListParameter(Object parameterValue) {
            throw new UnsupportedOperationException("(Query)DerivedReferrer at inline() is unsupported! Sorry!");
        }

        protected override LdConditionValue getCValueIsbn() {
            return _myCQ.Isbn;
        }


        protected override LdConditionValue getCValueBookName() {
            return _myCQ.BookName;
        }


        protected override LdConditionValue getCValueAuthorId() {
            return _myCQ.AuthorId;
        }


        public override String keepAuthorId_InScopeSubQuery_Author(LdAuthorCQ subQuery) {
            return _myCQ.keepAuthorId_InScopeSubQuery_Author(subQuery);
        }

        public override String keepAuthorId_NotInScopeSubQuery_Author(LdAuthorCQ subQuery) {
            return _myCQ.keepAuthorId_NotInScopeSubQuery_Author(subQuery);
        }

        protected override LdConditionValue getCValuePublisherId() {
            return _myCQ.PublisherId;
        }


        public override String keepPublisherId_InScopeSubQuery_Publisher(LdPublisherCQ subQuery) {
            return _myCQ.keepPublisherId_InScopeSubQuery_Publisher(subQuery);
        }

        public override String keepPublisherId_NotInScopeSubQuery_Publisher(LdPublisherCQ subQuery) {
            return _myCQ.keepPublisherId_NotInScopeSubQuery_Publisher(subQuery);
        }

        protected override LdConditionValue getCValueGenreCode() {
            return _myCQ.GenreCode;
        }


        public override String keepGenreCode_InScopeSubQuery_Genre(LdGenreCQ subQuery) {
            return _myCQ.keepGenreCode_InScopeSubQuery_Genre(subQuery);
        }

        public override String keepGenreCode_NotInScopeSubQuery_Genre(LdGenreCQ subQuery) {
            return _myCQ.keepGenreCode_NotInScopeSubQuery_Genre(subQuery);
        }

        protected override LdConditionValue getCValueOpeningPart() {
            return _myCQ.OpeningPart;
        }


        protected override LdConditionValue getCValueMaxLendingDateCount() {
            return _myCQ.MaxLendingDateCount;
        }


        protected override LdConditionValue getCValueOutOfUserSelectYn() {
            return _myCQ.OutOfUserSelectYn;
        }


        protected override LdConditionValue getCValueOutOfUserSelectReason() {
            return _myCQ.OutOfUserSelectReason;
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
        public override String keepScalarSubQuery(LdBookCQ subQuery) {
            throw new UnsupportedOperationException("ScalarSubQuery at inline() is unsupported! Sorry!");
        }

        // ===============================================================================
        //                                                         Myself InScope SubQuery
        //                                                         =======================
        public override String keepMyselfInScopeSubQuery(LdBookCQ subQuery) {
            throw new UnsupportedOperationException("MyselfInScopeSubQuery at inline() is unsupported! Sorry!");
        }
    }
}
