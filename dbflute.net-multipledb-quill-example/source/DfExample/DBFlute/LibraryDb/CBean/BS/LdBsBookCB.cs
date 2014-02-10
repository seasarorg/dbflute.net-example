
using System;
using System.Collections;

using DfExample.DBFlute.LibraryDb.AllCommon;
using DfExample.DBFlute.LibraryDb.AllCommon.CBean;
using DfExample.DBFlute.LibraryDb.AllCommon.CBean.SClause;
using DfExample.DBFlute.LibraryDb.AllCommon.Helper;

using DfExample.DBFlute.LibraryDb.CBean;
using DfExample.DBFlute.LibraryDb.CBean.CQ;
using DfExample.DBFlute.LibraryDb.CBean.Nss;

namespace DfExample.DBFlute.LibraryDb.CBean.BS {

    [System.Serializable]
    public class LdBsBookCB : LdAbstractConditionBean {

        // ===============================================================================
        //                                                                       Attribute
        //                                                                       =========
        protected LdBookCQ _conditionQuery;

        // ===============================================================================
        //                                                                      Table Name
        //                                                                      ==========
        public override String TableDbName { get { return "book"; } }

        // ===============================================================================
        //                                                             PrimaryKey Handling
        //                                                             ===================
        public void AcceptPrimaryKey(int? bookId) {
            assertObjectNotNull("bookId", bookId);
            LdBsBookCB cb = this;
            cb.Query().SetBookId_Equal(bookId);
        }

        public override LdConditionBean AddOrderBy_PK_Asc() {
            Query().AddOrderBy_BookId_Asc();
            return this;
        }

        public override LdConditionBean AddOrderBy_PK_Desc() {
            Query().AddOrderBy_BookId_Desc();
            return this;
        }

        // ===============================================================================
        //                                                                           Query
        //                                                                           =====
        public LdBookCQ Query() {
            return this.ConditionQuery;
        }

        public LdBookCQ ConditionQuery {
            get {
                if (_conditionQuery == null) {
                    _conditionQuery = CreateLocalCQ();
                }
                return _conditionQuery;
            }
        }

        protected virtual LdBookCQ CreateLocalCQ() {
            return xcreateCQ(null, this.SqlClause, this.SqlClause.getBasePointAliasName(), 0);
        }

        protected virtual LdBookCQ xcreateCQ(LdConditionQuery childQuery, LdSqlClause sqlClause, String aliasName, int nestLevel) {
            return new LdBookCQ(childQuery, sqlClause, aliasName, nestLevel);
        }

        public override LdConditionQuery LocalCQ {
            get { return this.ConditionQuery; }
        }

        // ===============================================================================
        //                                                                           Union
        //                                                                           =====
	    public virtual void Union(LdUnionQuery<LdBookCB> unionQuery) {
            LdBookCB cb = new LdBookCB();
            cb.xsetupForUnion(this); xsyncUQ(cb); unionQuery.Invoke(cb);
		    LdBookCQ cq = cb.Query(); Query().xsetUnionQuery(cq);
        }

	    public virtual void UnionAll(LdUnionQuery<LdBookCB> unionQuery) {
            LdBookCB cb = new LdBookCB();
            cb.xsetupForUnion(this); xsyncUQ(cb); unionQuery.Invoke(cb);
		    LdBookCQ cq = cb.Query(); Query().xsetUnionAllQuery(cq);
	    }

        public override bool HasUnionQueryOrUnionAllQuery() {
            return Query().hasUnionQueryOrUnionAllQuery();
        }

        // ===============================================================================
        //                                                                    Setup Select
        //                                                                    ============
        protected LdAuthorNss _nssAuthor;
        public LdAuthorNss NssAuthor { get {
            if (_nssAuthor == null) { _nssAuthor = new LdAuthorNss(null); }
            return _nssAuthor;
        }}
        public LdAuthorNss SetupSelect_Author() {
            if (HasSpecifiedColumn) { // if reverse call
                Specify().ColumnAuthorId();
            }
            doSetupSelect(delegate { return Query().QueryAuthor(); });
            if (_nssAuthor == null || !_nssAuthor.HasConditionQuery)
            { _nssAuthor = new LdAuthorNss(Query().QueryAuthor()); }
            return _nssAuthor;
        }
        protected LdGenreNss _nssGenre;
        public LdGenreNss NssGenre { get {
            if (_nssGenre == null) { _nssGenre = new LdGenreNss(null); }
            return _nssGenre;
        }}
        public LdGenreNss SetupSelect_Genre() {
            if (HasSpecifiedColumn) { // if reverse call
                Specify().ColumnGenreCode();
            }
            doSetupSelect(delegate { return Query().QueryGenre(); });
            if (_nssGenre == null || !_nssGenre.HasConditionQuery)
            { _nssGenre = new LdGenreNss(Query().QueryGenre()); }
            return _nssGenre;
        }
        protected LdPublisherNss _nssPublisher;
        public LdPublisherNss NssPublisher { get {
            if (_nssPublisher == null) { _nssPublisher = new LdPublisherNss(null); }
            return _nssPublisher;
        }}
        public LdPublisherNss SetupSelect_Publisher() {
            if (HasSpecifiedColumn) { // if reverse call
                Specify().ColumnPublisherId();
            }
            doSetupSelect(delegate { return Query().QueryPublisher(); });
            if (_nssPublisher == null || !_nssPublisher.HasConditionQuery)
            { _nssPublisher = new LdPublisherNss(Query().QueryPublisher()); }
            return _nssPublisher;
        }
        protected LdCollectionStatusLookupNss _nssCollectionStatusLookupAsNonExist;
        public LdCollectionStatusLookupNss NssCollectionStatusLookupAsNonExist { get {
            if (_nssCollectionStatusLookupAsNonExist == null) { _nssCollectionStatusLookupAsNonExist = new LdCollectionStatusLookupNss(null); }
            return _nssCollectionStatusLookupAsNonExist;
        }}
        public LdCollectionStatusLookupNss SetupSelect_CollectionStatusLookupAsNonExist() {
            if (HasSpecifiedColumn) { // if reverse call
                Specify().ColumnGenreCode();
            }
            doSetupSelect(delegate { return Query().QueryCollectionStatusLookupAsNonExist(); });
            if (_nssCollectionStatusLookupAsNonExist == null || !_nssCollectionStatusLookupAsNonExist.HasConditionQuery)
            { _nssCollectionStatusLookupAsNonExist = new LdCollectionStatusLookupNss(Query().QueryCollectionStatusLookupAsNonExist()); }
            return _nssCollectionStatusLookupAsNonExist;
        }

        // [DBFlute-0.7.4]
        // ===============================================================================
        //                                                                         Specify
        //                                                                         =======
        protected LdBookCBSpecification _specification;
        public LdBookCBSpecification Specify() {
            if (_specification == null) { _specification = new LdBookCBSpecification(this, new MySpQyCall(this), _forDerivedReferrer, _forScalarSelect, _forScalarCondition, _forColumnQuery); }
            return _specification;
        }
        protected bool HasSpecifiedColumn { get {
            return _specification != null && _specification.IsAlreadySpecifiedRequiredColumn;
        }}
        protected class MySpQyCall : HpSpQyCall<LdBookCQ> {
			protected LdBsBookCB _myCB;
			public MySpQyCall(LdBsBookCB myCB) { _myCB = myCB; }
    		public bool has() { return true; } public LdBookCQ qy() { return _myCB.Query(); }
    	}

        // [DBFlute-0.8.9.18]
        // ===============================================================================
        //                                                                     ColumnQuery
        //                                                                     ===========
        public HpColQyOperand<LdBookCB> ColumnQuery(LdSpecifyQuery<LdBookCB> leftSpecifyQuery) {
            return new HpColQyOperand<LdBookCB>(delegate(LdSpecifyQuery<LdBookCB> rightSp, String operand) {
                xcolqy(xcreateColumnQueryCB(), xcreateColumnQueryCB(), leftSpecifyQuery, rightSp, operand);
            });
        }

        protected LdBookCB xcreateColumnQueryCB() {
            LdBookCB cb = new LdBookCB();
            cb.xsetupForColumnQuery((LdBookCB)this);
            return cb;
        }

        // [DBFlute-0.8.9.9]
        // ===============================================================================
        //                                                                    OrScopeQuery
        //                                                                    ============
        public void OrScopeQuery(LdOrQuery<LdBookCB> orQuery) {
            xorQ((LdBookCB)this, orQuery);
        }

        // ===============================================================================
        //                                                                    Purpose Type
        //                                                                    ============
        public void xsetupForColumnQuery(LdBookCB mainCB) {
            xinheritSubQueryInfo(mainCB.LocalCQ);
            //xchangePurposeSqlClause(HpCBPurpose.COLUMN_QUERY);
            _forColumnQuery = true; // old style

            // inherits a parent query to synchronize real name
            // (and also for suppressing query check) 
            Specify().xsetSyncQyCall(new LdBookCBColQySpQyCall(mainCB));
        }
    }

    public class LdBookCBColQySpQyCall : HpSpQyCall<LdBookCQ> {
        protected LdBookCB _mainCB;
        public LdBookCBColQySpQyCall(LdBookCB mainCB) {
            _mainCB = mainCB;
        }
        public bool has() { return true; } 
        public LdBookCQ qy() { return _mainCB.Query(); } 
    }

    public class LdBookCBSpecification : AbstractSpecification<LdBookCQ> {
        protected LdAuthorCBSpecification _author;
        protected LdGenreCBSpecification _genre;
        protected LdPublisherCBSpecification _publisher;
        protected LdCollectionStatusLookupCBSpecification _collectionStatusLookupAsNonExist;
        public LdBookCBSpecification(LdConditionBean baseCB, HpSpQyCall<LdBookCQ> qyCall
                                                      , bool forDerivedReferrer, bool forScalarSelect, bool forScalarSubQuery, bool forColumnQuery)
        : base(baseCB, qyCall, forDerivedReferrer, forScalarSelect, forScalarSubQuery, forColumnQuery) { }
        public void ColumnBookId() { doColumn("BOOK_ID"); }
        public void ColumnIsbn() { doColumn("ISBN"); }
        public void ColumnBookName() { doColumn("BOOK_NAME"); }
        public void ColumnAuthorId() { doColumn("AUTHOR_ID"); }
        public void ColumnPublisherId() { doColumn("PUBLISHER_ID"); }
        public void ColumnGenreCode() { doColumn("GENRE_CODE"); }
        public void ColumnOpeningPart() { doColumn("OPENING_PART"); }
        public void ColumnMaxLendingDateCount() { doColumn("MAX_LENDING_DATE_COUNT"); }
        public void ColumnOutOfUserSelectYn() { doColumn("OUT_OF_USER_SELECT_YN"); }
        public void ColumnOutOfUserSelectReason() { doColumn("OUT_OF_USER_SELECT_REASON"); }
        public void ColumnRUser() { doColumn("R_USER"); }
        public void ColumnRModule() { doColumn("R_MODULE"); }
        public void ColumnRTimestamp() { doColumn("R_TIMESTAMP"); }
        public void ColumnUUser() { doColumn("U_USER"); }
        public void ColumnUModule() { doColumn("U_MODULE"); }
        public void ColumnUTimestamp() { doColumn("U_TIMESTAMP"); }
        protected override void doSpecifyRequiredColumn() {
            ColumnBookId(); // PK
            if (qyCall().qy().hasConditionQueryAuthor()
                    || qyCall().qy().xgetReferrerQuery() is LdAuthorCQ) {
                ColumnAuthorId(); // FK or one-to-one referrer
            }
            if (qyCall().qy().hasConditionQueryGenre()
                    || qyCall().qy().xgetReferrerQuery() is LdGenreCQ) {
                ColumnGenreCode(); // FK or one-to-one referrer
            }
            if (qyCall().qy().hasConditionQueryPublisher()
                    || qyCall().qy().xgetReferrerQuery() is LdPublisherCQ) {
                ColumnPublisherId(); // FK or one-to-one referrer
            }
            if (qyCall().qy().hasConditionQueryCollectionStatusLookupAsNonExist()
                    || qyCall().qy().xgetReferrerQuery() is LdCollectionStatusLookupCQ) {
                ColumnGenreCode(); // FK or one-to-one referrer
            }
        }
        protected override String getTableDbName() { return "book"; }
        public LdAuthorCBSpecification SpecifyAuthor() {
            assertForeign("author");
            if (_author == null) {
                _author = new LdAuthorCBSpecification(_baseCB, new AuthorSpQyCall(_qyCall), _forDerivedReferrer, _forScalarSelect, _forScalarCondition, _forColumnQuery);
                if (xhasSyncQyCall()) // inherits it
                { _author.xsetSyncQyCall(new AuthorSpQyCall(xsyncQyCall())); }
            }
            return _author;
        }
		public class AuthorSpQyCall : HpSpQyCall<LdAuthorCQ> {
		    protected HpSpQyCall<LdBookCQ> _qyCall;
		    public AuthorSpQyCall(HpSpQyCall<LdBookCQ> myQyCall) { _qyCall = myQyCall; }
		    public bool has() { return _qyCall.has() && _qyCall.qy().hasConditionQueryAuthor(); }
			public LdAuthorCQ qy() { return _qyCall.qy().QueryAuthor(); }
		}
        public LdGenreCBSpecification SpecifyGenre() {
            assertForeign("genre");
            if (_genre == null) {
                _genre = new LdGenreCBSpecification(_baseCB, new GenreSpQyCall(_qyCall), _forDerivedReferrer, _forScalarSelect, _forScalarCondition, _forColumnQuery);
                if (xhasSyncQyCall()) // inherits it
                { _genre.xsetSyncQyCall(new GenreSpQyCall(xsyncQyCall())); }
            }
            return _genre;
        }
		public class GenreSpQyCall : HpSpQyCall<LdGenreCQ> {
		    protected HpSpQyCall<LdBookCQ> _qyCall;
		    public GenreSpQyCall(HpSpQyCall<LdBookCQ> myQyCall) { _qyCall = myQyCall; }
		    public bool has() { return _qyCall.has() && _qyCall.qy().hasConditionQueryGenre(); }
			public LdGenreCQ qy() { return _qyCall.qy().QueryGenre(); }
		}
        public LdPublisherCBSpecification SpecifyPublisher() {
            assertForeign("publisher");
            if (_publisher == null) {
                _publisher = new LdPublisherCBSpecification(_baseCB, new PublisherSpQyCall(_qyCall), _forDerivedReferrer, _forScalarSelect, _forScalarCondition, _forColumnQuery);
                if (xhasSyncQyCall()) // inherits it
                { _publisher.xsetSyncQyCall(new PublisherSpQyCall(xsyncQyCall())); }
            }
            return _publisher;
        }
		public class PublisherSpQyCall : HpSpQyCall<LdPublisherCQ> {
		    protected HpSpQyCall<LdBookCQ> _qyCall;
		    public PublisherSpQyCall(HpSpQyCall<LdBookCQ> myQyCall) { _qyCall = myQyCall; }
		    public bool has() { return _qyCall.has() && _qyCall.qy().hasConditionQueryPublisher(); }
			public LdPublisherCQ qy() { return _qyCall.qy().QueryPublisher(); }
		}
        public LdCollectionStatusLookupCBSpecification SpecifyCollectionStatusLookupAsNonExist() {
            assertForeign("collectionStatusLookupAsNonExist");
            if (_collectionStatusLookupAsNonExist == null) {
                _collectionStatusLookupAsNonExist = new LdCollectionStatusLookupCBSpecification(_baseCB, new CollectionStatusLookupAsNonExistSpQyCall(_qyCall), _forDerivedReferrer, _forScalarSelect, _forScalarCondition, _forColumnQuery);
                if (xhasSyncQyCall()) // inherits it
                { _collectionStatusLookupAsNonExist.xsetSyncQyCall(new CollectionStatusLookupAsNonExistSpQyCall(xsyncQyCall())); }
            }
            return _collectionStatusLookupAsNonExist;
        }
		public class CollectionStatusLookupAsNonExistSpQyCall : HpSpQyCall<LdCollectionStatusLookupCQ> {
		    protected HpSpQyCall<LdBookCQ> _qyCall;
		    public CollectionStatusLookupAsNonExistSpQyCall(HpSpQyCall<LdBookCQ> myQyCall) { _qyCall = myQyCall; }
		    public bool has() { return _qyCall.has() && _qyCall.qy().hasConditionQueryCollectionStatusLookupAsNonExist(); }
			public LdCollectionStatusLookupCQ qy() { return _qyCall.qy().QueryCollectionStatusLookupAsNonExist(); }
		}
        public RAFunction<LdCollectionCB, LdBookCQ> DerivedCollectionList() {
            if (xhasSyncQyCall()) { xsyncQyCall().qy(); } // for sync (for example, this in ColumnQuery)
            return new RAFunction<LdCollectionCB, LdBookCQ>(_baseCB, _qyCall.qy(), delegate(String function, LdSubQuery<LdCollectionCB> subQuery, LdBookCQ cq, String aliasName)
                { cq.xsderiveCollectionList(function, subQuery, aliasName); });
        }
    }
}
