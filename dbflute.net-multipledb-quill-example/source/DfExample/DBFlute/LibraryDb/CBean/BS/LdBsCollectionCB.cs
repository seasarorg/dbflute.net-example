
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
    public class LdBsCollectionCB : LdAbstractConditionBean {

        // ===============================================================================
        //                                                                       Attribute
        //                                                                       =========
        protected LdCollectionCQ _conditionQuery;

        // ===============================================================================
        //                                                                      Table Name
        //                                                                      ==========
        public override String TableDbName { get { return "collection"; } }

        // ===============================================================================
        //                                                             PrimaryKey Handling
        //                                                             ===================
        public void AcceptPrimaryKey(int? collectionId) {
            assertObjectNotNull("collectionId", collectionId);
            LdBsCollectionCB cb = this;
            cb.Query().SetCollectionId_Equal(collectionId);
        }

        public override LdConditionBean AddOrderBy_PK_Asc() {
            Query().AddOrderBy_CollectionId_Asc();
            return this;
        }

        public override LdConditionBean AddOrderBy_PK_Desc() {
            Query().AddOrderBy_CollectionId_Desc();
            return this;
        }

        // ===============================================================================
        //                                                                           Query
        //                                                                           =====
        public LdCollectionCQ Query() {
            return this.ConditionQuery;
        }

        public LdCollectionCQ ConditionQuery {
            get {
                if (_conditionQuery == null) {
                    _conditionQuery = CreateLocalCQ();
                }
                return _conditionQuery;
            }
        }

        protected virtual LdCollectionCQ CreateLocalCQ() {
            return xcreateCQ(null, this.SqlClause, this.SqlClause.getBasePointAliasName(), 0);
        }

        protected virtual LdCollectionCQ xcreateCQ(LdConditionQuery childQuery, LdSqlClause sqlClause, String aliasName, int nestLevel) {
            return new LdCollectionCQ(childQuery, sqlClause, aliasName, nestLevel);
        }

        public override LdConditionQuery LocalCQ {
            get { return this.ConditionQuery; }
        }

        // ===============================================================================
        //                                                                           Union
        //                                                                           =====
	    public virtual void Union(LdUnionQuery<LdCollectionCB> unionQuery) {
            LdCollectionCB cb = new LdCollectionCB();
            cb.xsetupForUnion(this); xsyncUQ(cb); unionQuery.Invoke(cb);
		    LdCollectionCQ cq = cb.Query(); Query().xsetUnionQuery(cq);
        }

	    public virtual void UnionAll(LdUnionQuery<LdCollectionCB> unionQuery) {
            LdCollectionCB cb = new LdCollectionCB();
            cb.xsetupForUnion(this); xsyncUQ(cb); unionQuery.Invoke(cb);
		    LdCollectionCQ cq = cb.Query(); Query().xsetUnionAllQuery(cq);
	    }

        public override bool HasUnionQueryOrUnionAllQuery() {
            return Query().hasUnionQueryOrUnionAllQuery();
        }

        // ===============================================================================
        //                                                                    Setup Select
        //                                                                    ============
        protected LdBookNss _nssBook;
        public LdBookNss NssBook { get {
            if (_nssBook == null) { _nssBook = new LdBookNss(null); }
            return _nssBook;
        }}
        public LdBookNss SetupSelect_Book() {
            if (HasSpecifiedColumn) { // if reverse call
                Specify().ColumnBookId();
            }
            doSetupSelect(delegate { return Query().QueryBook(); });
            if (_nssBook == null || !_nssBook.HasConditionQuery)
            { _nssBook = new LdBookNss(Query().QueryBook()); }
            return _nssBook;
        }
        protected LdLibraryNss _nssLibrary;
        public LdLibraryNss NssLibrary { get {
            if (_nssLibrary == null) { _nssLibrary = new LdLibraryNss(null); }
            return _nssLibrary;
        }}
        public LdLibraryNss SetupSelect_Library() {
            if (HasSpecifiedColumn) { // if reverse call
                Specify().ColumnLibraryId();
            }
            doSetupSelect(delegate { return Query().QueryLibrary(); });
            if (_nssLibrary == null || !_nssLibrary.HasConditionQuery)
            { _nssLibrary = new LdLibraryNss(Query().QueryLibrary()); }
            return _nssLibrary;
        }

        protected LdCollectionStatusNss _nssCollectionStatusAsOne;
        public LdCollectionStatusNss NssCollectionStatusAsOne { get {
            if (_nssCollectionStatusAsOne == null) { _nssCollectionStatusAsOne = new LdCollectionStatusNss(null); }
            return _nssCollectionStatusAsOne;
        }}
        public LdCollectionStatusNss SetupSelect_CollectionStatusAsOne() {
            doSetupSelect(delegate { return Query().QueryCollectionStatusAsOne(); });
            if (_nssCollectionStatusAsOne == null || !_nssCollectionStatusAsOne.HasConditionQuery)
            { _nssCollectionStatusAsOne = new LdCollectionStatusNss(Query().QueryCollectionStatusAsOne()); }
            return _nssCollectionStatusAsOne;
        }

        // [DBFlute-0.7.4]
        // ===============================================================================
        //                                                                         Specify
        //                                                                         =======
        protected LdCollectionCBSpecification _specification;
        public LdCollectionCBSpecification Specify() {
            if (_specification == null) { _specification = new LdCollectionCBSpecification(this, new MySpQyCall(this), _forDerivedReferrer, _forScalarSelect, _forScalarCondition, _forColumnQuery); }
            return _specification;
        }
        protected bool HasSpecifiedColumn { get {
            return _specification != null && _specification.IsAlreadySpecifiedRequiredColumn;
        }}
        protected class MySpQyCall : HpSpQyCall<LdCollectionCQ> {
			protected LdBsCollectionCB _myCB;
			public MySpQyCall(LdBsCollectionCB myCB) { _myCB = myCB; }
    		public bool has() { return true; } public LdCollectionCQ qy() { return _myCB.Query(); }
    	}

        // [DBFlute-0.8.9.18]
        // ===============================================================================
        //                                                                     ColumnQuery
        //                                                                     ===========
        public HpColQyOperand<LdCollectionCB> ColumnQuery(LdSpecifyQuery<LdCollectionCB> leftSpecifyQuery) {
            return new HpColQyOperand<LdCollectionCB>(delegate(LdSpecifyQuery<LdCollectionCB> rightSp, String operand) {
                xcolqy(xcreateColumnQueryCB(), xcreateColumnQueryCB(), leftSpecifyQuery, rightSp, operand);
            });
        }

        protected LdCollectionCB xcreateColumnQueryCB() {
            LdCollectionCB cb = new LdCollectionCB();
            cb.xsetupForColumnQuery((LdCollectionCB)this);
            return cb;
        }

        // [DBFlute-0.8.9.9]
        // ===============================================================================
        //                                                                    OrScopeQuery
        //                                                                    ============
        public void OrScopeQuery(LdOrQuery<LdCollectionCB> orQuery) {
            xorQ((LdCollectionCB)this, orQuery);
        }

        // ===============================================================================
        //                                                                    Purpose Type
        //                                                                    ============
        public void xsetupForColumnQuery(LdCollectionCB mainCB) {
            xinheritSubQueryInfo(mainCB.LocalCQ);
            //xchangePurposeSqlClause(HpCBPurpose.COLUMN_QUERY);
            _forColumnQuery = true; // old style

            // inherits a parent query to synchronize real name
            // (and also for suppressing query check) 
            Specify().xsetSyncQyCall(new LdCollectionCBColQySpQyCall(mainCB));
        }
    }

    public class LdCollectionCBColQySpQyCall : HpSpQyCall<LdCollectionCQ> {
        protected LdCollectionCB _mainCB;
        public LdCollectionCBColQySpQyCall(LdCollectionCB mainCB) {
            _mainCB = mainCB;
        }
        public bool has() { return true; } 
        public LdCollectionCQ qy() { return _mainCB.Query(); } 
    }

    public class LdCollectionCBSpecification : AbstractSpecification<LdCollectionCQ> {
        protected LdBookCBSpecification _book;
        protected LdLibraryCBSpecification _library;
        protected LdCollectionStatusCBSpecification _collectionStatusAsOne;
        public LdCollectionCBSpecification(LdConditionBean baseCB, HpSpQyCall<LdCollectionCQ> qyCall
                                                      , bool forDerivedReferrer, bool forScalarSelect, bool forScalarSubQuery, bool forColumnQuery)
        : base(baseCB, qyCall, forDerivedReferrer, forScalarSelect, forScalarSubQuery, forColumnQuery) { }
        public void ColumnCollectionId() { doColumn("COLLECTION_ID"); }
        public void ColumnLibraryId() { doColumn("LIBRARY_ID"); }
        public void ColumnBookId() { doColumn("BOOK_ID"); }
        public void ColumnArrivalDate() { doColumn("ARRIVAL_DATE"); }
        public void ColumnRUser() { doColumn("R_USER"); }
        public void ColumnRModule() { doColumn("R_MODULE"); }
        public void ColumnRTimestamp() { doColumn("R_TIMESTAMP"); }
        public void ColumnUUser() { doColumn("U_USER"); }
        public void ColumnUModule() { doColumn("U_MODULE"); }
        public void ColumnUTimestamp() { doColumn("U_TIMESTAMP"); }
        protected override void doSpecifyRequiredColumn() {
            ColumnCollectionId(); // PK
            if (qyCall().qy().hasConditionQueryBook()
                    || qyCall().qy().xgetReferrerQuery() is LdBookCQ) {
                ColumnBookId(); // FK or one-to-one referrer
            }
            if (qyCall().qy().hasConditionQueryLibrary()
                    || qyCall().qy().xgetReferrerQuery() is LdLibraryCQ) {
                ColumnLibraryId(); // FK or one-to-one referrer
            }
        }
        protected override String getTableDbName() { return "collection"; }
        public LdBookCBSpecification SpecifyBook() {
            assertForeign("book");
            if (_book == null) {
                _book = new LdBookCBSpecification(_baseCB, new BookSpQyCall(_qyCall), _forDerivedReferrer, _forScalarSelect, _forScalarCondition, _forColumnQuery);
                if (xhasSyncQyCall()) // inherits it
                { _book.xsetSyncQyCall(new BookSpQyCall(xsyncQyCall())); }
            }
            return _book;
        }
		public class BookSpQyCall : HpSpQyCall<LdBookCQ> {
		    protected HpSpQyCall<LdCollectionCQ> _qyCall;
		    public BookSpQyCall(HpSpQyCall<LdCollectionCQ> myQyCall) { _qyCall = myQyCall; }
		    public bool has() { return _qyCall.has() && _qyCall.qy().hasConditionQueryBook(); }
			public LdBookCQ qy() { return _qyCall.qy().QueryBook(); }
		}
        public LdLibraryCBSpecification SpecifyLibrary() {
            assertForeign("library");
            if (_library == null) {
                _library = new LdLibraryCBSpecification(_baseCB, new LibrarySpQyCall(_qyCall), _forDerivedReferrer, _forScalarSelect, _forScalarCondition, _forColumnQuery);
                if (xhasSyncQyCall()) // inherits it
                { _library.xsetSyncQyCall(new LibrarySpQyCall(xsyncQyCall())); }
            }
            return _library;
        }
		public class LibrarySpQyCall : HpSpQyCall<LdLibraryCQ> {
		    protected HpSpQyCall<LdCollectionCQ> _qyCall;
		    public LibrarySpQyCall(HpSpQyCall<LdCollectionCQ> myQyCall) { _qyCall = myQyCall; }
		    public bool has() { return _qyCall.has() && _qyCall.qy().hasConditionQueryLibrary(); }
			public LdLibraryCQ qy() { return _qyCall.qy().QueryLibrary(); }
		}
        public LdCollectionStatusCBSpecification SpecifyCollectionStatusAsOne() {
            assertForeign("collectionStatusAsOne");
            if (_collectionStatusAsOne == null) {
                _collectionStatusAsOne = new LdCollectionStatusCBSpecification(_baseCB, new CollectionStatusAsOneSpQyCall(_qyCall), _forDerivedReferrer, _forScalarSelect, _forScalarCondition, _forColumnQuery);
                if (xhasSyncQyCall()) // inherits it
                { _collectionStatusAsOne.xsetSyncQyCall(new CollectionStatusAsOneSpQyCall(xsyncQyCall())); }
            }
            return _collectionStatusAsOne;
        }
		public class CollectionStatusAsOneSpQyCall : HpSpQyCall<LdCollectionStatusCQ> {
		    protected HpSpQyCall<LdCollectionCQ> _qyCall;
		    public CollectionStatusAsOneSpQyCall(HpSpQyCall<LdCollectionCQ> myQyCall) { _qyCall = myQyCall; }
		    public bool has() { return _qyCall.has() && _qyCall.qy().hasConditionQueryCollectionStatusAsOne(); }
			public LdCollectionStatusCQ qy() { return _qyCall.qy().QueryCollectionStatusAsOne(); }
		}
        public RAFunction<LdLendingCollectionCB, LdCollectionCQ> DerivedLendingCollectionList() {
            if (xhasSyncQyCall()) { xsyncQyCall().qy(); } // for sync (for example, this in ColumnQuery)
            return new RAFunction<LdLendingCollectionCB, LdCollectionCQ>(_baseCB, _qyCall.qy(), delegate(String function, LdSubQuery<LdLendingCollectionCB> subQuery, LdCollectionCQ cq, String aliasName)
                { cq.xsderiveLendingCollectionList(function, subQuery, aliasName); });
        }
    }
}
