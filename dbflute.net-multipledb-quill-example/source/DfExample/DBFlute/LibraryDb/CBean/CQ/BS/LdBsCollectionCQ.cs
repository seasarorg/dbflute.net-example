
using System;

using DfExample.DBFlute.LibraryDb.AllCommon.CBean;
using DfExample.DBFlute.LibraryDb.AllCommon.CBean.CValue;
using DfExample.DBFlute.LibraryDb.AllCommon.CBean.SClause;
using DfExample.DBFlute.LibraryDb.AllCommon.JavaLike;
using DfExample.DBFlute.LibraryDb.CBean.CQ;
using DfExample.DBFlute.LibraryDb.CBean.CQ.Ciq;

namespace DfExample.DBFlute.LibraryDb.CBean.CQ.BS {

    [System.Serializable]
    public class LdBsCollectionCQ : LdAbstractBsCollectionCQ {

        protected LdCollectionCIQ _inlineQuery;

        public LdBsCollectionCQ(LdConditionQuery childQuery, LdSqlClause sqlClause, String aliasName, int nestLevel)
            : base(childQuery, sqlClause, aliasName, nestLevel) {}

        public LdCollectionCIQ Inline() {
            if (_inlineQuery == null) {
                _inlineQuery = new LdCollectionCIQ(xgetReferrerQuery(), xgetSqlClause(), xgetAliasName(), xgetNestLevel(), this);
            }
            _inlineQuery.xsetOnClause(false);
            return _inlineQuery;
        }
        
        public LdCollectionCIQ On() {
            if (isBaseQuery()) { throw new UnsupportedOperationException("Unsupported onClause of Base Table!"); }
            LdCollectionCIQ inlineQuery = Inline();
            inlineQuery.xsetOnClause(true);
            return inlineQuery;
        }


        protected LdConditionValue _collectionId;
        public LdConditionValue CollectionId {
            get { if (_collectionId == null) { _collectionId = new LdConditionValue(); } return _collectionId; }
        }
        protected override LdConditionValue getCValueCollectionId() { return this.CollectionId; }


        protected Map<String, LdCollectionStatusCQ> _collectionId_ExistsSubQuery_CollectionStatusAsOneMap;
        public Map<String, LdCollectionStatusCQ> CollectionId_ExistsSubQuery_CollectionStatusAsOne { get { return _collectionId_ExistsSubQuery_CollectionStatusAsOneMap; }}
        public override String keepCollectionId_ExistsSubQuery_CollectionStatusAsOne(LdCollectionStatusCQ subQuery) {
            if (_collectionId_ExistsSubQuery_CollectionStatusAsOneMap == null) { _collectionId_ExistsSubQuery_CollectionStatusAsOneMap = new LinkedHashMap<String, LdCollectionStatusCQ>(); }
            String key = "subQueryMapKey" + (_collectionId_ExistsSubQuery_CollectionStatusAsOneMap.size() + 1);
            _collectionId_ExistsSubQuery_CollectionStatusAsOneMap.put(key, subQuery); return "CollectionId_ExistsSubQuery_CollectionStatusAsOne." + key;
        }

        protected Map<String, LdLendingCollectionCQ> _collectionId_ExistsSubQuery_LendingCollectionListMap;
        public Map<String, LdLendingCollectionCQ> CollectionId_ExistsSubQuery_LendingCollectionList { get { return _collectionId_ExistsSubQuery_LendingCollectionListMap; }}
        public override String keepCollectionId_ExistsSubQuery_LendingCollectionList(LdLendingCollectionCQ subQuery) {
            if (_collectionId_ExistsSubQuery_LendingCollectionListMap == null) { _collectionId_ExistsSubQuery_LendingCollectionListMap = new LinkedHashMap<String, LdLendingCollectionCQ>(); }
            String key = "subQueryMapKey" + (_collectionId_ExistsSubQuery_LendingCollectionListMap.size() + 1);
            _collectionId_ExistsSubQuery_LendingCollectionListMap.put(key, subQuery); return "CollectionId_ExistsSubQuery_LendingCollectionList." + key;
        }

        protected Map<String, LdCollectionStatusCQ> _collectionId_NotExistsSubQuery_CollectionStatusAsOneMap;
        public Map<String, LdCollectionStatusCQ> CollectionId_NotExistsSubQuery_CollectionStatusAsOne { get { return _collectionId_NotExistsSubQuery_CollectionStatusAsOneMap; }}
        public override String keepCollectionId_NotExistsSubQuery_CollectionStatusAsOne(LdCollectionStatusCQ subQuery) {
            if (_collectionId_NotExistsSubQuery_CollectionStatusAsOneMap == null) { _collectionId_NotExistsSubQuery_CollectionStatusAsOneMap = new LinkedHashMap<String, LdCollectionStatusCQ>(); }
            String key = "subQueryMapKey" + (_collectionId_NotExistsSubQuery_CollectionStatusAsOneMap.size() + 1);
            _collectionId_NotExistsSubQuery_CollectionStatusAsOneMap.put(key, subQuery); return "CollectionId_NotExistsSubQuery_CollectionStatusAsOne." + key;
        }

        protected Map<String, LdLendingCollectionCQ> _collectionId_NotExistsSubQuery_LendingCollectionListMap;
        public Map<String, LdLendingCollectionCQ> CollectionId_NotExistsSubQuery_LendingCollectionList { get { return _collectionId_NotExistsSubQuery_LendingCollectionListMap; }}
        public override String keepCollectionId_NotExistsSubQuery_LendingCollectionList(LdLendingCollectionCQ subQuery) {
            if (_collectionId_NotExistsSubQuery_LendingCollectionListMap == null) { _collectionId_NotExistsSubQuery_LendingCollectionListMap = new LinkedHashMap<String, LdLendingCollectionCQ>(); }
            String key = "subQueryMapKey" + (_collectionId_NotExistsSubQuery_LendingCollectionListMap.size() + 1);
            _collectionId_NotExistsSubQuery_LendingCollectionListMap.put(key, subQuery); return "CollectionId_NotExistsSubQuery_LendingCollectionList." + key;
        }

        protected Map<String, LdCollectionStatusCQ> _collectionId_InScopeSubQuery_CollectionStatusAsOneMap;
        public Map<String, LdCollectionStatusCQ> CollectionId_InScopeSubQuery_CollectionStatusAsOne { get { return _collectionId_InScopeSubQuery_CollectionStatusAsOneMap; }}
        public override String keepCollectionId_InScopeSubQuery_CollectionStatusAsOne(LdCollectionStatusCQ subQuery) {
            if (_collectionId_InScopeSubQuery_CollectionStatusAsOneMap == null) { _collectionId_InScopeSubQuery_CollectionStatusAsOneMap = new LinkedHashMap<String, LdCollectionStatusCQ>(); }
            String key = "subQueryMapKey" + (_collectionId_InScopeSubQuery_CollectionStatusAsOneMap.size() + 1);
            _collectionId_InScopeSubQuery_CollectionStatusAsOneMap.put(key, subQuery); return "CollectionId_InScopeSubQuery_CollectionStatusAsOne." + key;
        }

        protected Map<String, LdLendingCollectionCQ> _collectionId_InScopeSubQuery_LendingCollectionListMap;
        public Map<String, LdLendingCollectionCQ> CollectionId_InScopeSubQuery_LendingCollectionList { get { return _collectionId_InScopeSubQuery_LendingCollectionListMap; }}
        public override String keepCollectionId_InScopeSubQuery_LendingCollectionList(LdLendingCollectionCQ subQuery) {
            if (_collectionId_InScopeSubQuery_LendingCollectionListMap == null) { _collectionId_InScopeSubQuery_LendingCollectionListMap = new LinkedHashMap<String, LdLendingCollectionCQ>(); }
            String key = "subQueryMapKey" + (_collectionId_InScopeSubQuery_LendingCollectionListMap.size() + 1);
            _collectionId_InScopeSubQuery_LendingCollectionListMap.put(key, subQuery); return "CollectionId_InScopeSubQuery_LendingCollectionList." + key;
        }

        protected Map<String, LdCollectionStatusCQ> _collectionId_NotInScopeSubQuery_CollectionStatusAsOneMap;
        public Map<String, LdCollectionStatusCQ> CollectionId_NotInScopeSubQuery_CollectionStatusAsOne { get { return _collectionId_NotInScopeSubQuery_CollectionStatusAsOneMap; }}
        public override String keepCollectionId_NotInScopeSubQuery_CollectionStatusAsOne(LdCollectionStatusCQ subQuery) {
            if (_collectionId_NotInScopeSubQuery_CollectionStatusAsOneMap == null) { _collectionId_NotInScopeSubQuery_CollectionStatusAsOneMap = new LinkedHashMap<String, LdCollectionStatusCQ>(); }
            String key = "subQueryMapKey" + (_collectionId_NotInScopeSubQuery_CollectionStatusAsOneMap.size() + 1);
            _collectionId_NotInScopeSubQuery_CollectionStatusAsOneMap.put(key, subQuery); return "CollectionId_NotInScopeSubQuery_CollectionStatusAsOne." + key;
        }

        protected Map<String, LdLendingCollectionCQ> _collectionId_NotInScopeSubQuery_LendingCollectionListMap;
        public Map<String, LdLendingCollectionCQ> CollectionId_NotInScopeSubQuery_LendingCollectionList { get { return _collectionId_NotInScopeSubQuery_LendingCollectionListMap; }}
        public override String keepCollectionId_NotInScopeSubQuery_LendingCollectionList(LdLendingCollectionCQ subQuery) {
            if (_collectionId_NotInScopeSubQuery_LendingCollectionListMap == null) { _collectionId_NotInScopeSubQuery_LendingCollectionListMap = new LinkedHashMap<String, LdLendingCollectionCQ>(); }
            String key = "subQueryMapKey" + (_collectionId_NotInScopeSubQuery_LendingCollectionListMap.size() + 1);
            _collectionId_NotInScopeSubQuery_LendingCollectionListMap.put(key, subQuery); return "CollectionId_NotInScopeSubQuery_LendingCollectionList." + key;
        }

        protected Map<String, LdLendingCollectionCQ> _collectionId_SpecifyDerivedReferrer_LendingCollectionListMap;
        public Map<String, LdLendingCollectionCQ> CollectionId_SpecifyDerivedReferrer_LendingCollectionList { get { return _collectionId_SpecifyDerivedReferrer_LendingCollectionListMap; }}
        public override String keepCollectionId_SpecifyDerivedReferrer_LendingCollectionList(LdLendingCollectionCQ subQuery) {
            if (_collectionId_SpecifyDerivedReferrer_LendingCollectionListMap == null) { _collectionId_SpecifyDerivedReferrer_LendingCollectionListMap = new LinkedHashMap<String, LdLendingCollectionCQ>(); }
            String key = "subQueryMapKey" + (_collectionId_SpecifyDerivedReferrer_LendingCollectionListMap.size() + 1);
            _collectionId_SpecifyDerivedReferrer_LendingCollectionListMap.put(key, subQuery); return "CollectionId_SpecifyDerivedReferrer_LendingCollectionList." + key;
        }

        protected Map<String, LdLendingCollectionCQ> _collectionId_QueryDerivedReferrer_LendingCollectionListMap;
        public Map<String, LdLendingCollectionCQ> CollectionId_QueryDerivedReferrer_LendingCollectionList { get { return _collectionId_QueryDerivedReferrer_LendingCollectionListMap; } }
        public override String keepCollectionId_QueryDerivedReferrer_LendingCollectionList(LdLendingCollectionCQ subQuery) {
            if (_collectionId_QueryDerivedReferrer_LendingCollectionListMap == null) { _collectionId_QueryDerivedReferrer_LendingCollectionListMap = new LinkedHashMap<String, LdLendingCollectionCQ>(); }
            String key = "subQueryMapKey" + (_collectionId_QueryDerivedReferrer_LendingCollectionListMap.size() + 1);
            _collectionId_QueryDerivedReferrer_LendingCollectionListMap.put(key, subQuery); return "CollectionId_QueryDerivedReferrer_LendingCollectionList." + key;
        }
        protected Map<String, Object> _collectionId_QueryDerivedReferrer_LendingCollectionListParameterMap;
        public Map<String, Object> CollectionId_QueryDerivedReferrer_LendingCollectionListParameter { get { return _collectionId_QueryDerivedReferrer_LendingCollectionListParameterMap; } }
        public override String keepCollectionId_QueryDerivedReferrer_LendingCollectionListParameter(Object parameterValue) {
            if (_collectionId_QueryDerivedReferrer_LendingCollectionListParameterMap == null) { _collectionId_QueryDerivedReferrer_LendingCollectionListParameterMap = new LinkedHashMap<String, Object>(); }
            String key = "subQueryParameterKey" + (_collectionId_QueryDerivedReferrer_LendingCollectionListParameterMap.size() + 1);
            _collectionId_QueryDerivedReferrer_LendingCollectionListParameterMap.put(key, parameterValue); return "CollectionId_QueryDerivedReferrer_LendingCollectionListParameter." + key;
        }

        public LdBsCollectionCQ AddOrderBy_CollectionId_Asc() { regOBA("COLLECTION_ID");return this; }
        public LdBsCollectionCQ AddOrderBy_CollectionId_Desc() { regOBD("COLLECTION_ID");return this; }

        protected LdConditionValue _libraryId;
        public LdConditionValue LibraryId {
            get { if (_libraryId == null) { _libraryId = new LdConditionValue(); } return _libraryId; }
        }
        protected override LdConditionValue getCValueLibraryId() { return this.LibraryId; }


        protected Map<String, LdLibraryCQ> _libraryId_InScopeSubQuery_LibraryMap;
        public Map<String, LdLibraryCQ> LibraryId_InScopeSubQuery_Library { get { return _libraryId_InScopeSubQuery_LibraryMap; }}
        public override String keepLibraryId_InScopeSubQuery_Library(LdLibraryCQ subQuery) {
            if (_libraryId_InScopeSubQuery_LibraryMap == null) { _libraryId_InScopeSubQuery_LibraryMap = new LinkedHashMap<String, LdLibraryCQ>(); }
            String key = "subQueryMapKey" + (_libraryId_InScopeSubQuery_LibraryMap.size() + 1);
            _libraryId_InScopeSubQuery_LibraryMap.put(key, subQuery); return "LibraryId_InScopeSubQuery_Library." + key;
        }

        protected Map<String, LdLibraryCQ> _libraryId_NotInScopeSubQuery_LibraryMap;
        public Map<String, LdLibraryCQ> LibraryId_NotInScopeSubQuery_Library { get { return _libraryId_NotInScopeSubQuery_LibraryMap; }}
        public override String keepLibraryId_NotInScopeSubQuery_Library(LdLibraryCQ subQuery) {
            if (_libraryId_NotInScopeSubQuery_LibraryMap == null) { _libraryId_NotInScopeSubQuery_LibraryMap = new LinkedHashMap<String, LdLibraryCQ>(); }
            String key = "subQueryMapKey" + (_libraryId_NotInScopeSubQuery_LibraryMap.size() + 1);
            _libraryId_NotInScopeSubQuery_LibraryMap.put(key, subQuery); return "LibraryId_NotInScopeSubQuery_Library." + key;
        }

        public LdBsCollectionCQ AddOrderBy_LibraryId_Asc() { regOBA("LIBRARY_ID");return this; }
        public LdBsCollectionCQ AddOrderBy_LibraryId_Desc() { regOBD("LIBRARY_ID");return this; }

        protected LdConditionValue _bookId;
        public LdConditionValue BookId {
            get { if (_bookId == null) { _bookId = new LdConditionValue(); } return _bookId; }
        }
        protected override LdConditionValue getCValueBookId() { return this.BookId; }


        protected Map<String, LdBookCQ> _bookId_InScopeSubQuery_BookMap;
        public Map<String, LdBookCQ> BookId_InScopeSubQuery_Book { get { return _bookId_InScopeSubQuery_BookMap; }}
        public override String keepBookId_InScopeSubQuery_Book(LdBookCQ subQuery) {
            if (_bookId_InScopeSubQuery_BookMap == null) { _bookId_InScopeSubQuery_BookMap = new LinkedHashMap<String, LdBookCQ>(); }
            String key = "subQueryMapKey" + (_bookId_InScopeSubQuery_BookMap.size() + 1);
            _bookId_InScopeSubQuery_BookMap.put(key, subQuery); return "BookId_InScopeSubQuery_Book." + key;
        }

        protected Map<String, LdBookCQ> _bookId_NotInScopeSubQuery_BookMap;
        public Map<String, LdBookCQ> BookId_NotInScopeSubQuery_Book { get { return _bookId_NotInScopeSubQuery_BookMap; }}
        public override String keepBookId_NotInScopeSubQuery_Book(LdBookCQ subQuery) {
            if (_bookId_NotInScopeSubQuery_BookMap == null) { _bookId_NotInScopeSubQuery_BookMap = new LinkedHashMap<String, LdBookCQ>(); }
            String key = "subQueryMapKey" + (_bookId_NotInScopeSubQuery_BookMap.size() + 1);
            _bookId_NotInScopeSubQuery_BookMap.put(key, subQuery); return "BookId_NotInScopeSubQuery_Book." + key;
        }

        public LdBsCollectionCQ AddOrderBy_BookId_Asc() { regOBA("BOOK_ID");return this; }
        public LdBsCollectionCQ AddOrderBy_BookId_Desc() { regOBD("BOOK_ID");return this; }

        protected LdConditionValue _arrivalDate;
        public LdConditionValue ArrivalDate {
            get { if (_arrivalDate == null) { _arrivalDate = new LdConditionValue(); } return _arrivalDate; }
        }
        protected override LdConditionValue getCValueArrivalDate() { return this.ArrivalDate; }


        public LdBsCollectionCQ AddOrderBy_ArrivalDate_Asc() { regOBA("ARRIVAL_DATE");return this; }
        public LdBsCollectionCQ AddOrderBy_ArrivalDate_Desc() { regOBD("ARRIVAL_DATE");return this; }

        protected LdConditionValue _rUser;
        public LdConditionValue RUser {
            get { if (_rUser == null) { _rUser = new LdConditionValue(); } return _rUser; }
        }
        protected override LdConditionValue getCValueRUser() { return this.RUser; }


        public LdBsCollectionCQ AddOrderBy_RUser_Asc() { regOBA("R_USER");return this; }
        public LdBsCollectionCQ AddOrderBy_RUser_Desc() { regOBD("R_USER");return this; }

        protected LdConditionValue _rModule;
        public LdConditionValue RModule {
            get { if (_rModule == null) { _rModule = new LdConditionValue(); } return _rModule; }
        }
        protected override LdConditionValue getCValueRModule() { return this.RModule; }


        public LdBsCollectionCQ AddOrderBy_RModule_Asc() { regOBA("R_MODULE");return this; }
        public LdBsCollectionCQ AddOrderBy_RModule_Desc() { regOBD("R_MODULE");return this; }

        protected LdConditionValue _rTimestamp;
        public LdConditionValue RTimestamp {
            get { if (_rTimestamp == null) { _rTimestamp = new LdConditionValue(); } return _rTimestamp; }
        }
        protected override LdConditionValue getCValueRTimestamp() { return this.RTimestamp; }


        public LdBsCollectionCQ AddOrderBy_RTimestamp_Asc() { regOBA("R_TIMESTAMP");return this; }
        public LdBsCollectionCQ AddOrderBy_RTimestamp_Desc() { regOBD("R_TIMESTAMP");return this; }

        protected LdConditionValue _uUser;
        public LdConditionValue UUser {
            get { if (_uUser == null) { _uUser = new LdConditionValue(); } return _uUser; }
        }
        protected override LdConditionValue getCValueUUser() { return this.UUser; }


        public LdBsCollectionCQ AddOrderBy_UUser_Asc() { regOBA("U_USER");return this; }
        public LdBsCollectionCQ AddOrderBy_UUser_Desc() { regOBD("U_USER");return this; }

        protected LdConditionValue _uModule;
        public LdConditionValue UModule {
            get { if (_uModule == null) { _uModule = new LdConditionValue(); } return _uModule; }
        }
        protected override LdConditionValue getCValueUModule() { return this.UModule; }


        public LdBsCollectionCQ AddOrderBy_UModule_Asc() { regOBA("U_MODULE");return this; }
        public LdBsCollectionCQ AddOrderBy_UModule_Desc() { regOBD("U_MODULE");return this; }

        protected LdConditionValue _uTimestamp;
        public LdConditionValue UTimestamp {
            get { if (_uTimestamp == null) { _uTimestamp = new LdConditionValue(); } return _uTimestamp; }
        }
        protected override LdConditionValue getCValueUTimestamp() { return this.UTimestamp; }


        public LdBsCollectionCQ AddOrderBy_UTimestamp_Asc() { regOBA("U_TIMESTAMP");return this; }
        public LdBsCollectionCQ AddOrderBy_UTimestamp_Desc() { regOBD("U_TIMESTAMP");return this; }

        public LdBsCollectionCQ AddSpecifiedDerivedOrderBy_Asc(String aliasName) { registerSpecifiedDerivedOrderBy_Asc(aliasName); return this; }
        public LdBsCollectionCQ AddSpecifiedDerivedOrderBy_Desc(String aliasName) { registerSpecifiedDerivedOrderBy_Desc(aliasName); return this; }

        public override void reflectRelationOnUnionQuery(LdConditionQuery baseQueryAsSuper, LdConditionQuery unionQueryAsSuper) {
            LdCollectionCQ baseQuery = (LdCollectionCQ)baseQueryAsSuper;
            LdCollectionCQ unionQuery = (LdCollectionCQ)unionQueryAsSuper;
            if (baseQuery.hasConditionQueryBook()) {
                unionQuery.QueryBook().reflectRelationOnUnionQuery(baseQuery.QueryBook(), unionQuery.QueryBook());
            }
            if (baseQuery.hasConditionQueryLibrary()) {
                unionQuery.QueryLibrary().reflectRelationOnUnionQuery(baseQuery.QueryLibrary(), unionQuery.QueryLibrary());
            }
            if (baseQuery.hasConditionQueryCollectionStatusAsOne()) {
                unionQuery.QueryCollectionStatusAsOne().reflectRelationOnUnionQuery(baseQuery.QueryCollectionStatusAsOne(), unionQuery.QueryCollectionStatusAsOne());
            }

        }
    
        protected LdBookCQ _conditionQueryBook;
        public LdBookCQ QueryBook() {
            return this.ConditionQueryBook;
        }
        public LdBookCQ ConditionQueryBook {
            get {
                if (_conditionQueryBook == null) {
                    _conditionQueryBook = xcreateQueryBook();
                    xsetupOuterJoin_Book();
                }
                return _conditionQueryBook;
            }
        }
        protected LdBookCQ xcreateQueryBook() {
            String nrp = resolveNextRelationPathBook();
            String jan = resolveJoinAliasName(nrp, xgetNextNestLevel());
            LdBookCQ cq = new LdBookCQ(this, xgetSqlClause(), jan, xgetNextNestLevel());
            cq.xsetForeignPropertyName("book"); cq.xsetRelationPath(nrp); return cq;
        }
        public void xsetupOuterJoin_Book() {
            LdBookCQ cq = ConditionQueryBook;
            Map<String, String> joinOnMap = new LinkedHashMap<String, String>();
            joinOnMap.put("BOOK_ID", "BOOK_ID");
            registerOuterJoin(cq, joinOnMap);
        }
        protected String resolveNextRelationPathBook() {
            return resolveNextRelationPath("collection", "book");
        }
        public bool hasConditionQueryBook() {
            return _conditionQueryBook != null;
        }
        protected LdLibraryCQ _conditionQueryLibrary;
        public LdLibraryCQ QueryLibrary() {
            return this.ConditionQueryLibrary;
        }
        public LdLibraryCQ ConditionQueryLibrary {
            get {
                if (_conditionQueryLibrary == null) {
                    _conditionQueryLibrary = xcreateQueryLibrary();
                    xsetupOuterJoin_Library();
                }
                return _conditionQueryLibrary;
            }
        }
        protected LdLibraryCQ xcreateQueryLibrary() {
            String nrp = resolveNextRelationPathLibrary();
            String jan = resolveJoinAliasName(nrp, xgetNextNestLevel());
            LdLibraryCQ cq = new LdLibraryCQ(this, xgetSqlClause(), jan, xgetNextNestLevel());
            cq.xsetForeignPropertyName("library"); cq.xsetRelationPath(nrp); return cq;
        }
        public void xsetupOuterJoin_Library() {
            LdLibraryCQ cq = ConditionQueryLibrary;
            Map<String, String> joinOnMap = new LinkedHashMap<String, String>();
            joinOnMap.put("LIBRARY_ID", "LIBRARY_ID");
            registerOuterJoin(cq, joinOnMap);
        }
        protected String resolveNextRelationPathLibrary() {
            return resolveNextRelationPath("collection", "library");
        }
        public bool hasConditionQueryLibrary() {
            return _conditionQueryLibrary != null;
        }


        protected LdCollectionStatusCQ _conditionQueryCollectionStatusAsOne;
        public LdCollectionStatusCQ ConditionQueryCollectionStatusAsOne {
            get {
                if (_conditionQueryCollectionStatusAsOne == null) {
                    _conditionQueryCollectionStatusAsOne = createQueryCollectionStatusAsOne();
                    xsetupOuterJoin_CollectionStatusAsOne();
                }
                return _conditionQueryCollectionStatusAsOne;
            }
        }
        public LdCollectionStatusCQ QueryCollectionStatusAsOne() { return this.ConditionQueryCollectionStatusAsOne; }
        protected LdCollectionStatusCQ createQueryCollectionStatusAsOne() {
            String nrp = resolveNextRelationPathCollectionStatusAsOne();
            String jan = resolveJoinAliasName(nrp, xgetNextNestLevel());
            LdCollectionStatusCQ cq = new LdCollectionStatusCQ(this, xgetSqlClause(), jan, xgetNextNestLevel());
            cq.xsetForeignPropertyName("collectionStatusAsOne"); cq.xsetRelationPath(nrp); return cq;
        }
        public void xsetupOuterJoin_CollectionStatusAsOne() {
            LdCollectionStatusCQ cq = ConditionQueryCollectionStatusAsOne;
            Map<String, String> joinOnMap = new LinkedHashMap<String, String>();
            joinOnMap.put("COLLECTION_ID", "COLLECTION_ID");
            registerOuterJoin(cq, joinOnMap);
        }
        protected String resolveNextRelationPathCollectionStatusAsOne() {
            return resolveNextRelationPath("collection", "collectionStatusAsOne");
        }
        public bool hasConditionQueryCollectionStatusAsOne() {
            return _conditionQueryCollectionStatusAsOne != null;
        }

	    // ===============================================================================
	    //                                                                 Scalar SubQuery
	    //                                                                 ===============
	    protected Map<String, LdCollectionCQ> _scalarSubQueryMap;
	    public Map<String, LdCollectionCQ> ScalarSubQuery { get { return _scalarSubQueryMap; } }
	    public override String keepScalarSubQuery(LdCollectionCQ subQuery) {
	        if (_scalarSubQueryMap == null) { _scalarSubQueryMap = new LinkedHashMap<String, LdCollectionCQ>(); }
	        String key = "subQueryMapKey" + (_scalarSubQueryMap.size() + 1);
	        _scalarSubQueryMap.put(key, subQuery); return "ScalarSubQuery." + key;
	    }

        // ===============================================================================
        //                                                         Myself InScope SubQuery
        //                                                         =======================
        protected Map<String, LdCollectionCQ> _myselfInScopeSubQueryMap;
        public Map<String, LdCollectionCQ> MyselfInScopeSubQuery { get { return _myselfInScopeSubQueryMap; } }
        public override String keepMyselfInScopeSubQuery(LdCollectionCQ subQuery) {
            if (_myselfInScopeSubQueryMap == null) { _myselfInScopeSubQueryMap = new LinkedHashMap<String, LdCollectionCQ>(); }
            String key = "subQueryMapKey" + (_myselfInScopeSubQueryMap.size() + 1);
            _myselfInScopeSubQueryMap.put(key, subQuery); return "MyselfInScopeSubQuery." + key;
        }
    }
}
