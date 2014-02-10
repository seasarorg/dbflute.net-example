
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
    public class LdBsCollectionStatusCB : LdAbstractConditionBean {

        // ===============================================================================
        //                                                                       Attribute
        //                                                                       =========
        protected LdCollectionStatusCQ _conditionQuery;

        // ===============================================================================
        //                                                                      Table Name
        //                                                                      ==========
        public override String TableDbName { get { return "collection_status"; } }

        // ===============================================================================
        //                                                             PrimaryKey Handling
        //                                                             ===================
        public void AcceptPrimaryKey(int? collectionId) {
            assertObjectNotNull("collectionId", collectionId);
            LdBsCollectionStatusCB cb = this;
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
        public LdCollectionStatusCQ Query() {
            return this.ConditionQuery;
        }

        public LdCollectionStatusCQ ConditionQuery {
            get {
                if (_conditionQuery == null) {
                    _conditionQuery = CreateLocalCQ();
                }
                return _conditionQuery;
            }
        }

        protected virtual LdCollectionStatusCQ CreateLocalCQ() {
            return xcreateCQ(null, this.SqlClause, this.SqlClause.getBasePointAliasName(), 0);
        }

        protected virtual LdCollectionStatusCQ xcreateCQ(LdConditionQuery childQuery, LdSqlClause sqlClause, String aliasName, int nestLevel) {
            return new LdCollectionStatusCQ(childQuery, sqlClause, aliasName, nestLevel);
        }

        public override LdConditionQuery LocalCQ {
            get { return this.ConditionQuery; }
        }

        // ===============================================================================
        //                                                                           Union
        //                                                                           =====
	    public virtual void Union(LdUnionQuery<LdCollectionStatusCB> unionQuery) {
            LdCollectionStatusCB cb = new LdCollectionStatusCB();
            cb.xsetupForUnion(this); xsyncUQ(cb); unionQuery.Invoke(cb);
		    LdCollectionStatusCQ cq = cb.Query(); Query().xsetUnionQuery(cq);
        }

	    public virtual void UnionAll(LdUnionQuery<LdCollectionStatusCB> unionQuery) {
            LdCollectionStatusCB cb = new LdCollectionStatusCB();
            cb.xsetupForUnion(this); xsyncUQ(cb); unionQuery.Invoke(cb);
		    LdCollectionStatusCQ cq = cb.Query(); Query().xsetUnionAllQuery(cq);
	    }

        public override bool HasUnionQueryOrUnionAllQuery() {
            return Query().hasUnionQueryOrUnionAllQuery();
        }

        // ===============================================================================
        //                                                                    Setup Select
        //                                                                    ============
        protected LdCollectionNss _nssCollection;
        public LdCollectionNss NssCollection { get {
            if (_nssCollection == null) { _nssCollection = new LdCollectionNss(null); }
            return _nssCollection;
        }}
        public LdCollectionNss SetupSelect_Collection() {
            doSetupSelect(delegate { return Query().QueryCollection(); });
            if (_nssCollection == null || !_nssCollection.HasConditionQuery)
            { _nssCollection = new LdCollectionNss(Query().QueryCollection()); }
            return _nssCollection;
        }
        protected LdCollectionStatusLookupNss _nssCollectionStatusLookup;
        public LdCollectionStatusLookupNss NssCollectionStatusLookup { get {
            if (_nssCollectionStatusLookup == null) { _nssCollectionStatusLookup = new LdCollectionStatusLookupNss(null); }
            return _nssCollectionStatusLookup;
        }}
        public LdCollectionStatusLookupNss SetupSelect_CollectionStatusLookup() {
            if (HasSpecifiedColumn) { // if reverse call
                Specify().ColumnCollectionStatusCode();
            }
            doSetupSelect(delegate { return Query().QueryCollectionStatusLookup(); });
            if (_nssCollectionStatusLookup == null || !_nssCollectionStatusLookup.HasConditionQuery)
            { _nssCollectionStatusLookup = new LdCollectionStatusLookupNss(Query().QueryCollectionStatusLookup()); }
            return _nssCollectionStatusLookup;
        }

        // [DBFlute-0.7.4]
        // ===============================================================================
        //                                                                         Specify
        //                                                                         =======
        protected LdCollectionStatusCBSpecification _specification;
        public LdCollectionStatusCBSpecification Specify() {
            if (_specification == null) { _specification = new LdCollectionStatusCBSpecification(this, new MySpQyCall(this), _forDerivedReferrer, _forScalarSelect, _forScalarCondition, _forColumnQuery); }
            return _specification;
        }
        protected bool HasSpecifiedColumn { get {
            return _specification != null && _specification.IsAlreadySpecifiedRequiredColumn;
        }}
        protected class MySpQyCall : HpSpQyCall<LdCollectionStatusCQ> {
			protected LdBsCollectionStatusCB _myCB;
			public MySpQyCall(LdBsCollectionStatusCB myCB) { _myCB = myCB; }
    		public bool has() { return true; } public LdCollectionStatusCQ qy() { return _myCB.Query(); }
    	}

        // [DBFlute-0.8.9.18]
        // ===============================================================================
        //                                                                     ColumnQuery
        //                                                                     ===========
        public HpColQyOperand<LdCollectionStatusCB> ColumnQuery(LdSpecifyQuery<LdCollectionStatusCB> leftSpecifyQuery) {
            return new HpColQyOperand<LdCollectionStatusCB>(delegate(LdSpecifyQuery<LdCollectionStatusCB> rightSp, String operand) {
                xcolqy(xcreateColumnQueryCB(), xcreateColumnQueryCB(), leftSpecifyQuery, rightSp, operand);
            });
        }

        protected LdCollectionStatusCB xcreateColumnQueryCB() {
            LdCollectionStatusCB cb = new LdCollectionStatusCB();
            cb.xsetupForColumnQuery((LdCollectionStatusCB)this);
            return cb;
        }

        // [DBFlute-0.8.9.9]
        // ===============================================================================
        //                                                                    OrScopeQuery
        //                                                                    ============
        public void OrScopeQuery(LdOrQuery<LdCollectionStatusCB> orQuery) {
            xorQ((LdCollectionStatusCB)this, orQuery);
        }

        // ===============================================================================
        //                                                                    Purpose Type
        //                                                                    ============
        public void xsetupForColumnQuery(LdCollectionStatusCB mainCB) {
            xinheritSubQueryInfo(mainCB.LocalCQ);
            //xchangePurposeSqlClause(HpCBPurpose.COLUMN_QUERY);
            _forColumnQuery = true; // old style

            // inherits a parent query to synchronize real name
            // (and also for suppressing query check) 
            Specify().xsetSyncQyCall(new LdCollectionStatusCBColQySpQyCall(mainCB));
        }
    }

    public class LdCollectionStatusCBColQySpQyCall : HpSpQyCall<LdCollectionStatusCQ> {
        protected LdCollectionStatusCB _mainCB;
        public LdCollectionStatusCBColQySpQyCall(LdCollectionStatusCB mainCB) {
            _mainCB = mainCB;
        }
        public bool has() { return true; } 
        public LdCollectionStatusCQ qy() { return _mainCB.Query(); } 
    }

    public class LdCollectionStatusCBSpecification : AbstractSpecification<LdCollectionStatusCQ> {
        protected LdCollectionCBSpecification _collection;
        protected LdCollectionStatusLookupCBSpecification _collectionStatusLookup;
        public LdCollectionStatusCBSpecification(LdConditionBean baseCB, HpSpQyCall<LdCollectionStatusCQ> qyCall
                                                      , bool forDerivedReferrer, bool forScalarSelect, bool forScalarSubQuery, bool forColumnQuery)
        : base(baseCB, qyCall, forDerivedReferrer, forScalarSelect, forScalarSubQuery, forColumnQuery) { }
        public void ColumnCollectionId() { doColumn("COLLECTION_ID"); }
        public void ColumnCollectionStatusCode() { doColumn("COLLECTION_STATUS_CODE"); }
        public void ColumnRUser() { doColumn("R_USER"); }
        public void ColumnRModule() { doColumn("R_MODULE"); }
        public void ColumnRTimestamp() { doColumn("R_TIMESTAMP"); }
        public void ColumnUUser() { doColumn("U_USER"); }
        public void ColumnUModule() { doColumn("U_MODULE"); }
        public void ColumnUTimestamp() { doColumn("U_TIMESTAMP"); }
        protected override void doSpecifyRequiredColumn() {
            ColumnCollectionId(); // PK
            if (qyCall().qy().hasConditionQueryCollectionStatusLookup()
                    || qyCall().qy().xgetReferrerQuery() is LdCollectionStatusLookupCQ) {
                ColumnCollectionStatusCode(); // FK or one-to-one referrer
            }
        }
        protected override String getTableDbName() { return "collection_status"; }
        public LdCollectionCBSpecification SpecifyCollection() {
            assertForeign("collection");
            if (_collection == null) {
                _collection = new LdCollectionCBSpecification(_baseCB, new CollectionSpQyCall(_qyCall), _forDerivedReferrer, _forScalarSelect, _forScalarCondition, _forColumnQuery);
                if (xhasSyncQyCall()) // inherits it
                { _collection.xsetSyncQyCall(new CollectionSpQyCall(xsyncQyCall())); }
            }
            return _collection;
        }
		public class CollectionSpQyCall : HpSpQyCall<LdCollectionCQ> {
		    protected HpSpQyCall<LdCollectionStatusCQ> _qyCall;
		    public CollectionSpQyCall(HpSpQyCall<LdCollectionStatusCQ> myQyCall) { _qyCall = myQyCall; }
		    public bool has() { return _qyCall.has() && _qyCall.qy().hasConditionQueryCollection(); }
			public LdCollectionCQ qy() { return _qyCall.qy().QueryCollection(); }
		}
        public LdCollectionStatusLookupCBSpecification SpecifyCollectionStatusLookup() {
            assertForeign("collectionStatusLookup");
            if (_collectionStatusLookup == null) {
                _collectionStatusLookup = new LdCollectionStatusLookupCBSpecification(_baseCB, new CollectionStatusLookupSpQyCall(_qyCall), _forDerivedReferrer, _forScalarSelect, _forScalarCondition, _forColumnQuery);
                if (xhasSyncQyCall()) // inherits it
                { _collectionStatusLookup.xsetSyncQyCall(new CollectionStatusLookupSpQyCall(xsyncQyCall())); }
            }
            return _collectionStatusLookup;
        }
		public class CollectionStatusLookupSpQyCall : HpSpQyCall<LdCollectionStatusLookupCQ> {
		    protected HpSpQyCall<LdCollectionStatusCQ> _qyCall;
		    public CollectionStatusLookupSpQyCall(HpSpQyCall<LdCollectionStatusCQ> myQyCall) { _qyCall = myQyCall; }
		    public bool has() { return _qyCall.has() && _qyCall.qy().hasConditionQueryCollectionStatusLookup(); }
			public LdCollectionStatusLookupCQ qy() { return _qyCall.qy().QueryCollectionStatusLookup(); }
		}
    }
}
