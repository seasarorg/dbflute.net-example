
using System;

using DfExample.DBFlute.LibraryDb.AllCommon.CBean;
using DfExample.DBFlute.LibraryDb.AllCommon.CBean.CValue;
using DfExample.DBFlute.LibraryDb.AllCommon.CBean.SClause;
using DfExample.DBFlute.LibraryDb.AllCommon.JavaLike;
using DfExample.DBFlute.LibraryDb.CBean.CQ;
using DfExample.DBFlute.LibraryDb.CBean.CQ.Ciq;

namespace DfExample.DBFlute.LibraryDb.CBean.CQ.BS {

    [System.Serializable]
    public class LdBsBookCQ : LdAbstractBsBookCQ {

        protected LdBookCIQ _inlineQuery;

        public LdBsBookCQ(LdConditionQuery childQuery, LdSqlClause sqlClause, String aliasName, int nestLevel)
            : base(childQuery, sqlClause, aliasName, nestLevel) {}

        public LdBookCIQ Inline() {
            if (_inlineQuery == null) {
                _inlineQuery = new LdBookCIQ(xgetReferrerQuery(), xgetSqlClause(), xgetAliasName(), xgetNestLevel(), this);
            }
            _inlineQuery.xsetOnClause(false);
            return _inlineQuery;
        }
        
        public LdBookCIQ On() {
            if (isBaseQuery()) { throw new UnsupportedOperationException("Unsupported onClause of Base Table!"); }
            LdBookCIQ inlineQuery = Inline();
            inlineQuery.xsetOnClause(true);
            return inlineQuery;
        }


        protected LdConditionValue _bookId;
        public LdConditionValue BookId {
            get { if (_bookId == null) { _bookId = new LdConditionValue(); } return _bookId; }
        }
        protected override LdConditionValue getCValueBookId() { return this.BookId; }


        protected Map<String, LdCollectionCQ> _bookId_ExistsSubQuery_CollectionListMap;
        public Map<String, LdCollectionCQ> BookId_ExistsSubQuery_CollectionList { get { return _bookId_ExistsSubQuery_CollectionListMap; }}
        public override String keepBookId_ExistsSubQuery_CollectionList(LdCollectionCQ subQuery) {
            if (_bookId_ExistsSubQuery_CollectionListMap == null) { _bookId_ExistsSubQuery_CollectionListMap = new LinkedHashMap<String, LdCollectionCQ>(); }
            String key = "subQueryMapKey" + (_bookId_ExistsSubQuery_CollectionListMap.size() + 1);
            _bookId_ExistsSubQuery_CollectionListMap.put(key, subQuery); return "BookId_ExistsSubQuery_CollectionList." + key;
        }

        protected Map<String, LdCollectionCQ> _bookId_NotExistsSubQuery_CollectionListMap;
        public Map<String, LdCollectionCQ> BookId_NotExistsSubQuery_CollectionList { get { return _bookId_NotExistsSubQuery_CollectionListMap; }}
        public override String keepBookId_NotExistsSubQuery_CollectionList(LdCollectionCQ subQuery) {
            if (_bookId_NotExistsSubQuery_CollectionListMap == null) { _bookId_NotExistsSubQuery_CollectionListMap = new LinkedHashMap<String, LdCollectionCQ>(); }
            String key = "subQueryMapKey" + (_bookId_NotExistsSubQuery_CollectionListMap.size() + 1);
            _bookId_NotExistsSubQuery_CollectionListMap.put(key, subQuery); return "BookId_NotExistsSubQuery_CollectionList." + key;
        }

        protected Map<String, LdCollectionCQ> _bookId_InScopeSubQuery_CollectionListMap;
        public Map<String, LdCollectionCQ> BookId_InScopeSubQuery_CollectionList { get { return _bookId_InScopeSubQuery_CollectionListMap; }}
        public override String keepBookId_InScopeSubQuery_CollectionList(LdCollectionCQ subQuery) {
            if (_bookId_InScopeSubQuery_CollectionListMap == null) { _bookId_InScopeSubQuery_CollectionListMap = new LinkedHashMap<String, LdCollectionCQ>(); }
            String key = "subQueryMapKey" + (_bookId_InScopeSubQuery_CollectionListMap.size() + 1);
            _bookId_InScopeSubQuery_CollectionListMap.put(key, subQuery); return "BookId_InScopeSubQuery_CollectionList." + key;
        }

        protected Map<String, LdCollectionCQ> _bookId_NotInScopeSubQuery_CollectionListMap;
        public Map<String, LdCollectionCQ> BookId_NotInScopeSubQuery_CollectionList { get { return _bookId_NotInScopeSubQuery_CollectionListMap; }}
        public override String keepBookId_NotInScopeSubQuery_CollectionList(LdCollectionCQ subQuery) {
            if (_bookId_NotInScopeSubQuery_CollectionListMap == null) { _bookId_NotInScopeSubQuery_CollectionListMap = new LinkedHashMap<String, LdCollectionCQ>(); }
            String key = "subQueryMapKey" + (_bookId_NotInScopeSubQuery_CollectionListMap.size() + 1);
            _bookId_NotInScopeSubQuery_CollectionListMap.put(key, subQuery); return "BookId_NotInScopeSubQuery_CollectionList." + key;
        }

        protected Map<String, LdCollectionCQ> _bookId_SpecifyDerivedReferrer_CollectionListMap;
        public Map<String, LdCollectionCQ> BookId_SpecifyDerivedReferrer_CollectionList { get { return _bookId_SpecifyDerivedReferrer_CollectionListMap; }}
        public override String keepBookId_SpecifyDerivedReferrer_CollectionList(LdCollectionCQ subQuery) {
            if (_bookId_SpecifyDerivedReferrer_CollectionListMap == null) { _bookId_SpecifyDerivedReferrer_CollectionListMap = new LinkedHashMap<String, LdCollectionCQ>(); }
            String key = "subQueryMapKey" + (_bookId_SpecifyDerivedReferrer_CollectionListMap.size() + 1);
            _bookId_SpecifyDerivedReferrer_CollectionListMap.put(key, subQuery); return "BookId_SpecifyDerivedReferrer_CollectionList." + key;
        }

        protected Map<String, LdCollectionCQ> _bookId_QueryDerivedReferrer_CollectionListMap;
        public Map<String, LdCollectionCQ> BookId_QueryDerivedReferrer_CollectionList { get { return _bookId_QueryDerivedReferrer_CollectionListMap; } }
        public override String keepBookId_QueryDerivedReferrer_CollectionList(LdCollectionCQ subQuery) {
            if (_bookId_QueryDerivedReferrer_CollectionListMap == null) { _bookId_QueryDerivedReferrer_CollectionListMap = new LinkedHashMap<String, LdCollectionCQ>(); }
            String key = "subQueryMapKey" + (_bookId_QueryDerivedReferrer_CollectionListMap.size() + 1);
            _bookId_QueryDerivedReferrer_CollectionListMap.put(key, subQuery); return "BookId_QueryDerivedReferrer_CollectionList." + key;
        }
        protected Map<String, Object> _bookId_QueryDerivedReferrer_CollectionListParameterMap;
        public Map<String, Object> BookId_QueryDerivedReferrer_CollectionListParameter { get { return _bookId_QueryDerivedReferrer_CollectionListParameterMap; } }
        public override String keepBookId_QueryDerivedReferrer_CollectionListParameter(Object parameterValue) {
            if (_bookId_QueryDerivedReferrer_CollectionListParameterMap == null) { _bookId_QueryDerivedReferrer_CollectionListParameterMap = new LinkedHashMap<String, Object>(); }
            String key = "subQueryParameterKey" + (_bookId_QueryDerivedReferrer_CollectionListParameterMap.size() + 1);
            _bookId_QueryDerivedReferrer_CollectionListParameterMap.put(key, parameterValue); return "BookId_QueryDerivedReferrer_CollectionListParameter." + key;
        }

        public LdBsBookCQ AddOrderBy_BookId_Asc() { regOBA("BOOK_ID");return this; }
        public LdBsBookCQ AddOrderBy_BookId_Desc() { regOBD("BOOK_ID");return this; }

        protected LdConditionValue _isbn;
        public LdConditionValue Isbn {
            get { if (_isbn == null) { _isbn = new LdConditionValue(); } return _isbn; }
        }
        protected override LdConditionValue getCValueIsbn() { return this.Isbn; }


        public LdBsBookCQ AddOrderBy_Isbn_Asc() { regOBA("ISBN");return this; }
        public LdBsBookCQ AddOrderBy_Isbn_Desc() { regOBD("ISBN");return this; }

        protected LdConditionValue _bookName;
        public LdConditionValue BookName {
            get { if (_bookName == null) { _bookName = new LdConditionValue(); } return _bookName; }
        }
        protected override LdConditionValue getCValueBookName() { return this.BookName; }


        public LdBsBookCQ AddOrderBy_BookName_Asc() { regOBA("BOOK_NAME");return this; }
        public LdBsBookCQ AddOrderBy_BookName_Desc() { regOBD("BOOK_NAME");return this; }

        protected LdConditionValue _authorId;
        public LdConditionValue AuthorId {
            get { if (_authorId == null) { _authorId = new LdConditionValue(); } return _authorId; }
        }
        protected override LdConditionValue getCValueAuthorId() { return this.AuthorId; }


        protected Map<String, LdAuthorCQ> _authorId_InScopeSubQuery_AuthorMap;
        public Map<String, LdAuthorCQ> AuthorId_InScopeSubQuery_Author { get { return _authorId_InScopeSubQuery_AuthorMap; }}
        public override String keepAuthorId_InScopeSubQuery_Author(LdAuthorCQ subQuery) {
            if (_authorId_InScopeSubQuery_AuthorMap == null) { _authorId_InScopeSubQuery_AuthorMap = new LinkedHashMap<String, LdAuthorCQ>(); }
            String key = "subQueryMapKey" + (_authorId_InScopeSubQuery_AuthorMap.size() + 1);
            _authorId_InScopeSubQuery_AuthorMap.put(key, subQuery); return "AuthorId_InScopeSubQuery_Author." + key;
        }

        protected Map<String, LdAuthorCQ> _authorId_NotInScopeSubQuery_AuthorMap;
        public Map<String, LdAuthorCQ> AuthorId_NotInScopeSubQuery_Author { get { return _authorId_NotInScopeSubQuery_AuthorMap; }}
        public override String keepAuthorId_NotInScopeSubQuery_Author(LdAuthorCQ subQuery) {
            if (_authorId_NotInScopeSubQuery_AuthorMap == null) { _authorId_NotInScopeSubQuery_AuthorMap = new LinkedHashMap<String, LdAuthorCQ>(); }
            String key = "subQueryMapKey" + (_authorId_NotInScopeSubQuery_AuthorMap.size() + 1);
            _authorId_NotInScopeSubQuery_AuthorMap.put(key, subQuery); return "AuthorId_NotInScopeSubQuery_Author." + key;
        }

        public LdBsBookCQ AddOrderBy_AuthorId_Asc() { regOBA("AUTHOR_ID");return this; }
        public LdBsBookCQ AddOrderBy_AuthorId_Desc() { regOBD("AUTHOR_ID");return this; }

        protected LdConditionValue _publisherId;
        public LdConditionValue PublisherId {
            get { if (_publisherId == null) { _publisherId = new LdConditionValue(); } return _publisherId; }
        }
        protected override LdConditionValue getCValuePublisherId() { return this.PublisherId; }


        protected Map<String, LdPublisherCQ> _publisherId_InScopeSubQuery_PublisherMap;
        public Map<String, LdPublisherCQ> PublisherId_InScopeSubQuery_Publisher { get { return _publisherId_InScopeSubQuery_PublisherMap; }}
        public override String keepPublisherId_InScopeSubQuery_Publisher(LdPublisherCQ subQuery) {
            if (_publisherId_InScopeSubQuery_PublisherMap == null) { _publisherId_InScopeSubQuery_PublisherMap = new LinkedHashMap<String, LdPublisherCQ>(); }
            String key = "subQueryMapKey" + (_publisherId_InScopeSubQuery_PublisherMap.size() + 1);
            _publisherId_InScopeSubQuery_PublisherMap.put(key, subQuery); return "PublisherId_InScopeSubQuery_Publisher." + key;
        }

        protected Map<String, LdPublisherCQ> _publisherId_NotInScopeSubQuery_PublisherMap;
        public Map<String, LdPublisherCQ> PublisherId_NotInScopeSubQuery_Publisher { get { return _publisherId_NotInScopeSubQuery_PublisherMap; }}
        public override String keepPublisherId_NotInScopeSubQuery_Publisher(LdPublisherCQ subQuery) {
            if (_publisherId_NotInScopeSubQuery_PublisherMap == null) { _publisherId_NotInScopeSubQuery_PublisherMap = new LinkedHashMap<String, LdPublisherCQ>(); }
            String key = "subQueryMapKey" + (_publisherId_NotInScopeSubQuery_PublisherMap.size() + 1);
            _publisherId_NotInScopeSubQuery_PublisherMap.put(key, subQuery); return "PublisherId_NotInScopeSubQuery_Publisher." + key;
        }

        public LdBsBookCQ AddOrderBy_PublisherId_Asc() { regOBA("PUBLISHER_ID");return this; }
        public LdBsBookCQ AddOrderBy_PublisherId_Desc() { regOBD("PUBLISHER_ID");return this; }

        protected LdConditionValue _genreCode;
        public LdConditionValue GenreCode {
            get { if (_genreCode == null) { _genreCode = new LdConditionValue(); } return _genreCode; }
        }
        protected override LdConditionValue getCValueGenreCode() { return this.GenreCode; }


        protected Map<String, LdGenreCQ> _genreCode_InScopeSubQuery_GenreMap;
        public Map<String, LdGenreCQ> GenreCode_InScopeSubQuery_Genre { get { return _genreCode_InScopeSubQuery_GenreMap; }}
        public override String keepGenreCode_InScopeSubQuery_Genre(LdGenreCQ subQuery) {
            if (_genreCode_InScopeSubQuery_GenreMap == null) { _genreCode_InScopeSubQuery_GenreMap = new LinkedHashMap<String, LdGenreCQ>(); }
            String key = "subQueryMapKey" + (_genreCode_InScopeSubQuery_GenreMap.size() + 1);
            _genreCode_InScopeSubQuery_GenreMap.put(key, subQuery); return "GenreCode_InScopeSubQuery_Genre." + key;
        }

        protected Map<String, LdGenreCQ> _genreCode_NotInScopeSubQuery_GenreMap;
        public Map<String, LdGenreCQ> GenreCode_NotInScopeSubQuery_Genre { get { return _genreCode_NotInScopeSubQuery_GenreMap; }}
        public override String keepGenreCode_NotInScopeSubQuery_Genre(LdGenreCQ subQuery) {
            if (_genreCode_NotInScopeSubQuery_GenreMap == null) { _genreCode_NotInScopeSubQuery_GenreMap = new LinkedHashMap<String, LdGenreCQ>(); }
            String key = "subQueryMapKey" + (_genreCode_NotInScopeSubQuery_GenreMap.size() + 1);
            _genreCode_NotInScopeSubQuery_GenreMap.put(key, subQuery); return "GenreCode_NotInScopeSubQuery_Genre." + key;
        }

        public LdBsBookCQ AddOrderBy_GenreCode_Asc() { regOBA("GENRE_CODE");return this; }
        public LdBsBookCQ AddOrderBy_GenreCode_Desc() { regOBD("GENRE_CODE");return this; }

        protected LdConditionValue _openingPart;
        public LdConditionValue OpeningPart {
            get { if (_openingPart == null) { _openingPart = new LdConditionValue(); } return _openingPart; }
        }
        protected override LdConditionValue getCValueOpeningPart() { return this.OpeningPart; }


        public LdBsBookCQ AddOrderBy_OpeningPart_Asc() { regOBA("OPENING_PART");return this; }
        public LdBsBookCQ AddOrderBy_OpeningPart_Desc() { regOBD("OPENING_PART");return this; }

        protected LdConditionValue _maxLendingDateCount;
        public LdConditionValue MaxLendingDateCount {
            get { if (_maxLendingDateCount == null) { _maxLendingDateCount = new LdConditionValue(); } return _maxLendingDateCount; }
        }
        protected override LdConditionValue getCValueMaxLendingDateCount() { return this.MaxLendingDateCount; }


        public LdBsBookCQ AddOrderBy_MaxLendingDateCount_Asc() { regOBA("MAX_LENDING_DATE_COUNT");return this; }
        public LdBsBookCQ AddOrderBy_MaxLendingDateCount_Desc() { regOBD("MAX_LENDING_DATE_COUNT");return this; }

        protected LdConditionValue _outOfUserSelectYn;
        public LdConditionValue OutOfUserSelectYn {
            get { if (_outOfUserSelectYn == null) { _outOfUserSelectYn = new LdConditionValue(); } return _outOfUserSelectYn; }
        }
        protected override LdConditionValue getCValueOutOfUserSelectYn() { return this.OutOfUserSelectYn; }


        public LdBsBookCQ AddOrderBy_OutOfUserSelectYn_Asc() { regOBA("OUT_OF_USER_SELECT_YN");return this; }
        public LdBsBookCQ AddOrderBy_OutOfUserSelectYn_Desc() { regOBD("OUT_OF_USER_SELECT_YN");return this; }

        protected LdConditionValue _outOfUserSelectReason;
        public LdConditionValue OutOfUserSelectReason {
            get { if (_outOfUserSelectReason == null) { _outOfUserSelectReason = new LdConditionValue(); } return _outOfUserSelectReason; }
        }
        protected override LdConditionValue getCValueOutOfUserSelectReason() { return this.OutOfUserSelectReason; }


        public LdBsBookCQ AddOrderBy_OutOfUserSelectReason_Asc() { regOBA("OUT_OF_USER_SELECT_REASON");return this; }
        public LdBsBookCQ AddOrderBy_OutOfUserSelectReason_Desc() { regOBD("OUT_OF_USER_SELECT_REASON");return this; }

        protected LdConditionValue _rUser;
        public LdConditionValue RUser {
            get { if (_rUser == null) { _rUser = new LdConditionValue(); } return _rUser; }
        }
        protected override LdConditionValue getCValueRUser() { return this.RUser; }


        public LdBsBookCQ AddOrderBy_RUser_Asc() { regOBA("R_USER");return this; }
        public LdBsBookCQ AddOrderBy_RUser_Desc() { regOBD("R_USER");return this; }

        protected LdConditionValue _rModule;
        public LdConditionValue RModule {
            get { if (_rModule == null) { _rModule = new LdConditionValue(); } return _rModule; }
        }
        protected override LdConditionValue getCValueRModule() { return this.RModule; }


        public LdBsBookCQ AddOrderBy_RModule_Asc() { regOBA("R_MODULE");return this; }
        public LdBsBookCQ AddOrderBy_RModule_Desc() { regOBD("R_MODULE");return this; }

        protected LdConditionValue _rTimestamp;
        public LdConditionValue RTimestamp {
            get { if (_rTimestamp == null) { _rTimestamp = new LdConditionValue(); } return _rTimestamp; }
        }
        protected override LdConditionValue getCValueRTimestamp() { return this.RTimestamp; }


        public LdBsBookCQ AddOrderBy_RTimestamp_Asc() { regOBA("R_TIMESTAMP");return this; }
        public LdBsBookCQ AddOrderBy_RTimestamp_Desc() { regOBD("R_TIMESTAMP");return this; }

        protected LdConditionValue _uUser;
        public LdConditionValue UUser {
            get { if (_uUser == null) { _uUser = new LdConditionValue(); } return _uUser; }
        }
        protected override LdConditionValue getCValueUUser() { return this.UUser; }


        public LdBsBookCQ AddOrderBy_UUser_Asc() { regOBA("U_USER");return this; }
        public LdBsBookCQ AddOrderBy_UUser_Desc() { regOBD("U_USER");return this; }

        protected LdConditionValue _uModule;
        public LdConditionValue UModule {
            get { if (_uModule == null) { _uModule = new LdConditionValue(); } return _uModule; }
        }
        protected override LdConditionValue getCValueUModule() { return this.UModule; }


        public LdBsBookCQ AddOrderBy_UModule_Asc() { regOBA("U_MODULE");return this; }
        public LdBsBookCQ AddOrderBy_UModule_Desc() { regOBD("U_MODULE");return this; }

        protected LdConditionValue _uTimestamp;
        public LdConditionValue UTimestamp {
            get { if (_uTimestamp == null) { _uTimestamp = new LdConditionValue(); } return _uTimestamp; }
        }
        protected override LdConditionValue getCValueUTimestamp() { return this.UTimestamp; }


        public LdBsBookCQ AddOrderBy_UTimestamp_Asc() { regOBA("U_TIMESTAMP");return this; }
        public LdBsBookCQ AddOrderBy_UTimestamp_Desc() { regOBD("U_TIMESTAMP");return this; }

        public LdBsBookCQ AddSpecifiedDerivedOrderBy_Asc(String aliasName) { registerSpecifiedDerivedOrderBy_Asc(aliasName); return this; }
        public LdBsBookCQ AddSpecifiedDerivedOrderBy_Desc(String aliasName) { registerSpecifiedDerivedOrderBy_Desc(aliasName); return this; }

        public override void reflectRelationOnUnionQuery(LdConditionQuery baseQueryAsSuper, LdConditionQuery unionQueryAsSuper) {
            LdBookCQ baseQuery = (LdBookCQ)baseQueryAsSuper;
            LdBookCQ unionQuery = (LdBookCQ)unionQueryAsSuper;
            if (baseQuery.hasConditionQueryAuthor()) {
                unionQuery.QueryAuthor().reflectRelationOnUnionQuery(baseQuery.QueryAuthor(), unionQuery.QueryAuthor());
            }
            if (baseQuery.hasConditionQueryGenre()) {
                unionQuery.QueryGenre().reflectRelationOnUnionQuery(baseQuery.QueryGenre(), unionQuery.QueryGenre());
            }
            if (baseQuery.hasConditionQueryPublisher()) {
                unionQuery.QueryPublisher().reflectRelationOnUnionQuery(baseQuery.QueryPublisher(), unionQuery.QueryPublisher());
            }
            if (baseQuery.hasConditionQueryCollectionStatusLookupAsNonExist()) {
                unionQuery.QueryCollectionStatusLookupAsNonExist().reflectRelationOnUnionQuery(baseQuery.QueryCollectionStatusLookupAsNonExist(), unionQuery.QueryCollectionStatusLookupAsNonExist());
            }

        }
    
        protected LdAuthorCQ _conditionQueryAuthor;
        public LdAuthorCQ QueryAuthor() {
            return this.ConditionQueryAuthor;
        }
        public LdAuthorCQ ConditionQueryAuthor {
            get {
                if (_conditionQueryAuthor == null) {
                    _conditionQueryAuthor = xcreateQueryAuthor();
                    xsetupOuterJoin_Author();
                }
                return _conditionQueryAuthor;
            }
        }
        protected LdAuthorCQ xcreateQueryAuthor() {
            String nrp = resolveNextRelationPathAuthor();
            String jan = resolveJoinAliasName(nrp, xgetNextNestLevel());
            LdAuthorCQ cq = new LdAuthorCQ(this, xgetSqlClause(), jan, xgetNextNestLevel());
            cq.xsetForeignPropertyName("author"); cq.xsetRelationPath(nrp); return cq;
        }
        public void xsetupOuterJoin_Author() {
            LdAuthorCQ cq = ConditionQueryAuthor;
            Map<String, String> joinOnMap = new LinkedHashMap<String, String>();
            joinOnMap.put("AUTHOR_ID", "AUTHOR_ID");
            registerOuterJoin(cq, joinOnMap);
        }
        protected String resolveNextRelationPathAuthor() {
            return resolveNextRelationPath("book", "author");
        }
        public bool hasConditionQueryAuthor() {
            return _conditionQueryAuthor != null;
        }
        protected LdGenreCQ _conditionQueryGenre;
        public LdGenreCQ QueryGenre() {
            return this.ConditionQueryGenre;
        }
        public LdGenreCQ ConditionQueryGenre {
            get {
                if (_conditionQueryGenre == null) {
                    _conditionQueryGenre = xcreateQueryGenre();
                    xsetupOuterJoin_Genre();
                }
                return _conditionQueryGenre;
            }
        }
        protected LdGenreCQ xcreateQueryGenre() {
            String nrp = resolveNextRelationPathGenre();
            String jan = resolveJoinAliasName(nrp, xgetNextNestLevel());
            LdGenreCQ cq = new LdGenreCQ(this, xgetSqlClause(), jan, xgetNextNestLevel());
            cq.xsetForeignPropertyName("genre"); cq.xsetRelationPath(nrp); return cq;
        }
        public void xsetupOuterJoin_Genre() {
            LdGenreCQ cq = ConditionQueryGenre;
            Map<String, String> joinOnMap = new LinkedHashMap<String, String>();
            joinOnMap.put("GENRE_CODE", "GENRE_CODE");
            registerOuterJoin(cq, joinOnMap);
        }
        protected String resolveNextRelationPathGenre() {
            return resolveNextRelationPath("book", "genre");
        }
        public bool hasConditionQueryGenre() {
            return _conditionQueryGenre != null;
        }
        protected LdPublisherCQ _conditionQueryPublisher;
        public LdPublisherCQ QueryPublisher() {
            return this.ConditionQueryPublisher;
        }
        public LdPublisherCQ ConditionQueryPublisher {
            get {
                if (_conditionQueryPublisher == null) {
                    _conditionQueryPublisher = xcreateQueryPublisher();
                    xsetupOuterJoin_Publisher();
                }
                return _conditionQueryPublisher;
            }
        }
        protected LdPublisherCQ xcreateQueryPublisher() {
            String nrp = resolveNextRelationPathPublisher();
            String jan = resolveJoinAliasName(nrp, xgetNextNestLevel());
            LdPublisherCQ cq = new LdPublisherCQ(this, xgetSqlClause(), jan, xgetNextNestLevel());
            cq.xsetForeignPropertyName("publisher"); cq.xsetRelationPath(nrp); return cq;
        }
        public void xsetupOuterJoin_Publisher() {
            LdPublisherCQ cq = ConditionQueryPublisher;
            Map<String, String> joinOnMap = new LinkedHashMap<String, String>();
            joinOnMap.put("PUBLISHER_ID", "PUBLISHER_ID");
            registerOuterJoin(cq, joinOnMap);
        }
        protected String resolveNextRelationPathPublisher() {
            return resolveNextRelationPath("book", "publisher");
        }
        public bool hasConditionQueryPublisher() {
            return _conditionQueryPublisher != null;
        }
        protected LdCollectionStatusLookupCQ _conditionQueryCollectionStatusLookupAsNonExist;
        public LdCollectionStatusLookupCQ QueryCollectionStatusLookupAsNonExist() {
            return this.ConditionQueryCollectionStatusLookupAsNonExist;
        }
        public LdCollectionStatusLookupCQ ConditionQueryCollectionStatusLookupAsNonExist {
            get {
                if (_conditionQueryCollectionStatusLookupAsNonExist == null) {
                    _conditionQueryCollectionStatusLookupAsNonExist = xcreateQueryCollectionStatusLookupAsNonExist();
                    xsetupOuterJoin_CollectionStatusLookupAsNonExist();
                }
                return _conditionQueryCollectionStatusLookupAsNonExist;
            }
        }
        protected LdCollectionStatusLookupCQ xcreateQueryCollectionStatusLookupAsNonExist() {
            String nrp = resolveNextRelationPathCollectionStatusLookupAsNonExist();
            String jan = resolveJoinAliasName(nrp, xgetNextNestLevel());
            LdCollectionStatusLookupCQ cq = new LdCollectionStatusLookupCQ(this, xgetSqlClause(), jan, xgetNextNestLevel());
            cq.xsetForeignPropertyName("collectionStatusLookupAsNonExist"); cq.xsetRelationPath(nrp); return cq;
        }
        public void xsetupOuterJoin_CollectionStatusLookupAsNonExist() {
            LdCollectionStatusLookupCQ cq = ConditionQueryCollectionStatusLookupAsNonExist;
            Map<String, String> joinOnMap = new LinkedHashMap<String, String>();
            joinOnMap.put("GENRE_CODE", "COLLECTION_STATUS_CODE");
            registerOuterJoin(cq, joinOnMap, "$$foreignAlias$$.COLLECTION_STATUS_NAME = 'nonexist'");
        }
        protected String resolveNextRelationPathCollectionStatusLookupAsNonExist() {
            return resolveNextRelationPath("book", "collectionStatusLookupAsNonExist");
        }
        public bool hasConditionQueryCollectionStatusLookupAsNonExist() {
            return _conditionQueryCollectionStatusLookupAsNonExist != null;
        }


	    // ===============================================================================
	    //                                                                 Scalar SubQuery
	    //                                                                 ===============
	    protected Map<String, LdBookCQ> _scalarSubQueryMap;
	    public Map<String, LdBookCQ> ScalarSubQuery { get { return _scalarSubQueryMap; } }
	    public override String keepScalarSubQuery(LdBookCQ subQuery) {
	        if (_scalarSubQueryMap == null) { _scalarSubQueryMap = new LinkedHashMap<String, LdBookCQ>(); }
	        String key = "subQueryMapKey" + (_scalarSubQueryMap.size() + 1);
	        _scalarSubQueryMap.put(key, subQuery); return "ScalarSubQuery." + key;
	    }

        // ===============================================================================
        //                                                         Myself InScope SubQuery
        //                                                         =======================
        protected Map<String, LdBookCQ> _myselfInScopeSubQueryMap;
        public Map<String, LdBookCQ> MyselfInScopeSubQuery { get { return _myselfInScopeSubQueryMap; } }
        public override String keepMyselfInScopeSubQuery(LdBookCQ subQuery) {
            if (_myselfInScopeSubQueryMap == null) { _myselfInScopeSubQueryMap = new LinkedHashMap<String, LdBookCQ>(); }
            String key = "subQueryMapKey" + (_myselfInScopeSubQueryMap.size() + 1);
            _myselfInScopeSubQueryMap.put(key, subQuery); return "MyselfInScopeSubQuery." + key;
        }
    }
}
