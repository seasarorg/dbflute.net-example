
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
    public class LdGenreCIQ : LdAbstractBsGenreCQ {

        // ===============================================================================
        //                                                                       Attribute
        //                                                                       =========
        protected LdBsGenreCQ _myCQ;

        // ===============================================================================
        //                                                                     Constructor
        //                                                                     ===========
        public LdGenreCIQ(LdConditionQuery childQuery, LdSqlClause sqlClause, String aliasName, int nestLevel, LdBsGenreCQ myCQ)
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


        protected override LdConditionValue getCValueGenreCode() {
            return _myCQ.GenreCode;
        }


        public override String keepGenreCode_ExistsSubQuery_BookList(LdBookCQ subQuery) {
            throw new SystemException("ExistsSubQuery at inline() is unsupported! Sorry!");
            // _myCQ.keepGenreCode_ExistsSubQuery_BookList(subQuery);
        }

        public override String keepGenreCode_ExistsSubQuery_GenreSelfList(LdGenreCQ subQuery) {
            throw new SystemException("ExistsSubQuery at inline() is unsupported! Sorry!");
            // _myCQ.keepGenreCode_ExistsSubQuery_GenreSelfList(subQuery);
        }

        public override String keepGenreCode_NotExistsSubQuery_BookList(LdBookCQ subQuery) {
            throw new SystemException("NotExistsSubQuery at inline() is unsupported! Sorry!");
            // _myCQ.keepGenreCode_NotExistsSubQuery_BookList(subQuery);
        }

        public override String keepGenreCode_NotExistsSubQuery_GenreSelfList(LdGenreCQ subQuery) {
            throw new SystemException("NotExistsSubQuery at inline() is unsupported! Sorry!");
            // _myCQ.keepGenreCode_NotExistsSubQuery_GenreSelfList(subQuery);
        }

        public override String keepGenreCode_InScopeSubQuery_BookList(LdBookCQ subQuery) {
            return _myCQ.keepGenreCode_InScopeSubQuery_BookList(subQuery);
        }

        public override String keepGenreCode_InScopeSubQuery_GenreSelfList(LdGenreCQ subQuery) {
            return _myCQ.keepGenreCode_InScopeSubQuery_GenreSelfList(subQuery);
        }

        public override String keepGenreCode_NotInScopeSubQuery_BookList(LdBookCQ subQuery) {
            return _myCQ.keepGenreCode_NotInScopeSubQuery_BookList(subQuery);
        }

        public override String keepGenreCode_NotInScopeSubQuery_GenreSelfList(LdGenreCQ subQuery) {
            return _myCQ.keepGenreCode_NotInScopeSubQuery_GenreSelfList(subQuery);
        }
        public override String keepGenreCode_SpecifyDerivedReferrer_BookList(LdBookCQ subQuery) {
            throw new UnsupportedOperationException("(Specify)DerivedReferrer at inline() is unsupported! Sorry!");
        }
        public override String keepGenreCode_SpecifyDerivedReferrer_GenreSelfList(LdGenreCQ subQuery) {
            throw new UnsupportedOperationException("(Specify)DerivedReferrer at inline() is unsupported! Sorry!");
        }
        public override String keepGenreCode_QueryDerivedReferrer_BookList(LdBookCQ subQuery) {
            throw new UnsupportedOperationException("(Query)DerivedReferrer at inline() is unsupported! Sorry!");
        }
        public override String keepGenreCode_QueryDerivedReferrer_BookListParameter(Object parameterValue) {
            throw new UnsupportedOperationException("(Query)DerivedReferrer at inline() is unsupported! Sorry!");
        }
        public override String keepGenreCode_QueryDerivedReferrer_GenreSelfList(LdGenreCQ subQuery) {
            throw new UnsupportedOperationException("(Query)DerivedReferrer at inline() is unsupported! Sorry!");
        }
        public override String keepGenreCode_QueryDerivedReferrer_GenreSelfListParameter(Object parameterValue) {
            throw new UnsupportedOperationException("(Query)DerivedReferrer at inline() is unsupported! Sorry!");
        }

        protected override LdConditionValue getCValueGenreName() {
            return _myCQ.GenreName;
        }


        protected override LdConditionValue getCValueHierarchyLevel() {
            return _myCQ.HierarchyLevel;
        }


        protected override LdConditionValue getCValueHierarchyOrder() {
            return _myCQ.HierarchyOrder;
        }


        protected override LdConditionValue getCValueParentGenreCode() {
            return _myCQ.ParentGenreCode;
        }


        public override String keepParentGenreCode_InScopeSubQuery_GenreSelf(LdGenreCQ subQuery) {
            return _myCQ.keepParentGenreCode_InScopeSubQuery_GenreSelf(subQuery);
        }

        public override String keepParentGenreCode_NotInScopeSubQuery_GenreSelf(LdGenreCQ subQuery) {
            return _myCQ.keepParentGenreCode_NotInScopeSubQuery_GenreSelf(subQuery);
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
        public override String keepScalarSubQuery(LdGenreCQ subQuery) {
            throw new UnsupportedOperationException("ScalarSubQuery at inline() is unsupported! Sorry!");
        }

        // ===============================================================================
        //                                                         Myself InScope SubQuery
        //                                                         =======================
        public override String keepMyselfInScopeSubQuery(LdGenreCQ subQuery) {
            throw new UnsupportedOperationException("MyselfInScopeSubQuery at inline() is unsupported! Sorry!");
        }
    }
}
