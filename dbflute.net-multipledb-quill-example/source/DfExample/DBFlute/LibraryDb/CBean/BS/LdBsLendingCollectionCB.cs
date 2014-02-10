
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
    public class LdBsLendingCollectionCB : LdAbstractConditionBean {

        // ===============================================================================
        //                                                                       Attribute
        //                                                                       =========
        protected LdLendingCollectionCQ _conditionQuery;

        // ===============================================================================
        //                                                                      Table Name
        //                                                                      ==========
        public override String TableDbName { get { return "lending_collection"; } }

        // ===============================================================================
        //                                                             PrimaryKey Handling
        //                                                             ===================
        public void AcceptPrimaryKey(int? libraryId, int? lbUserId, DateTime? lendingDate, int? collectionId) {
            assertObjectNotNull("libraryId", libraryId);assertObjectNotNull("lbUserId", lbUserId);assertObjectNotNull("lendingDate", lendingDate);assertObjectNotNull("collectionId", collectionId);
            LdBsLendingCollectionCB cb = this;
            cb.Query().SetLibraryId_Equal(libraryId);cb.Query().SetLbUserId_Equal(lbUserId);cb.Query().SetLendingDate_Equal(lendingDate);cb.Query().SetCollectionId_Equal(collectionId);
        }

        public override LdConditionBean AddOrderBy_PK_Asc() {
            Query().AddOrderBy_LibraryId_Asc();
            Query().AddOrderBy_LbUserId_Asc();
            Query().AddOrderBy_LendingDate_Asc();
            Query().AddOrderBy_CollectionId_Asc();
            return this;
        }

        public override LdConditionBean AddOrderBy_PK_Desc() {
            Query().AddOrderBy_LibraryId_Desc();
            Query().AddOrderBy_LbUserId_Desc();
            Query().AddOrderBy_LendingDate_Desc();
            Query().AddOrderBy_CollectionId_Desc();
            return this;
        }

        // ===============================================================================
        //                                                                           Query
        //                                                                           =====
        public LdLendingCollectionCQ Query() {
            return this.ConditionQuery;
        }

        public LdLendingCollectionCQ ConditionQuery {
            get {
                if (_conditionQuery == null) {
                    _conditionQuery = CreateLocalCQ();
                }
                return _conditionQuery;
            }
        }

        protected virtual LdLendingCollectionCQ CreateLocalCQ() {
            return xcreateCQ(null, this.SqlClause, this.SqlClause.getBasePointAliasName(), 0);
        }

        protected virtual LdLendingCollectionCQ xcreateCQ(LdConditionQuery childQuery, LdSqlClause sqlClause, String aliasName, int nestLevel) {
            return new LdLendingCollectionCQ(childQuery, sqlClause, aliasName, nestLevel);
        }

        public override LdConditionQuery LocalCQ {
            get { return this.ConditionQuery; }
        }

        // ===============================================================================
        //                                                                           Union
        //                                                                           =====
	    public virtual void Union(LdUnionQuery<LdLendingCollectionCB> unionQuery) {
            LdLendingCollectionCB cb = new LdLendingCollectionCB();
            cb.xsetupForUnion(this); xsyncUQ(cb); unionQuery.Invoke(cb);
		    LdLendingCollectionCQ cq = cb.Query(); Query().xsetUnionQuery(cq);
        }

	    public virtual void UnionAll(LdUnionQuery<LdLendingCollectionCB> unionQuery) {
            LdLendingCollectionCB cb = new LdLendingCollectionCB();
            cb.xsetupForUnion(this); xsyncUQ(cb); unionQuery.Invoke(cb);
		    LdLendingCollectionCQ cq = cb.Query(); Query().xsetUnionAllQuery(cq);
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
        protected LdLendingNss _nssLending;
        public LdLendingNss NssLending { get {
            if (_nssLending == null) { _nssLending = new LdLendingNss(null); }
            return _nssLending;
        }}
        public LdLendingNss SetupSelect_Lending() {
            doSetupSelect(delegate { return Query().QueryLending(); });
            if (_nssLending == null || !_nssLending.HasConditionQuery)
            { _nssLending = new LdLendingNss(Query().QueryLending()); }
            return _nssLending;
        }
        protected LdLibraryUserNss _nssLibraryUser;
        public LdLibraryUserNss NssLibraryUser { get {
            if (_nssLibraryUser == null) { _nssLibraryUser = new LdLibraryUserNss(null); }
            return _nssLibraryUser;
        }}
        public LdLibraryUserNss SetupSelect_LibraryUser() {
            doSetupSelect(delegate { return Query().QueryLibraryUser(); });
            if (_nssLibraryUser == null || !_nssLibraryUser.HasConditionQuery)
            { _nssLibraryUser = new LdLibraryUserNss(Query().QueryLibraryUser()); }
            return _nssLibraryUser;
        }

        // [DBFlute-0.7.4]
        // ===============================================================================
        //                                                                         Specify
        //                                                                         =======
        protected LdLendingCollectionCBSpecification _specification;
        public LdLendingCollectionCBSpecification Specify() {
            if (_specification == null) { _specification = new LdLendingCollectionCBSpecification(this, new MySpQyCall(this), _forDerivedReferrer, _forScalarSelect, _forScalarCondition, _forColumnQuery); }
            return _specification;
        }
        protected bool HasSpecifiedColumn { get {
            return _specification != null && _specification.IsAlreadySpecifiedRequiredColumn;
        }}
        protected class MySpQyCall : HpSpQyCall<LdLendingCollectionCQ> {
			protected LdBsLendingCollectionCB _myCB;
			public MySpQyCall(LdBsLendingCollectionCB myCB) { _myCB = myCB; }
    		public bool has() { return true; } public LdLendingCollectionCQ qy() { return _myCB.Query(); }
    	}

        // [DBFlute-0.8.9.18]
        // ===============================================================================
        //                                                                     ColumnQuery
        //                                                                     ===========
        public HpColQyOperand<LdLendingCollectionCB> ColumnQuery(LdSpecifyQuery<LdLendingCollectionCB> leftSpecifyQuery) {
            return new HpColQyOperand<LdLendingCollectionCB>(delegate(LdSpecifyQuery<LdLendingCollectionCB> rightSp, String operand) {
                xcolqy(xcreateColumnQueryCB(), xcreateColumnQueryCB(), leftSpecifyQuery, rightSp, operand);
            });
        }

        protected LdLendingCollectionCB xcreateColumnQueryCB() {
            LdLendingCollectionCB cb = new LdLendingCollectionCB();
            cb.xsetupForColumnQuery((LdLendingCollectionCB)this);
            return cb;
        }

        // [DBFlute-0.8.9.9]
        // ===============================================================================
        //                                                                    OrScopeQuery
        //                                                                    ============
        public void OrScopeQuery(LdOrQuery<LdLendingCollectionCB> orQuery) {
            xorQ((LdLendingCollectionCB)this, orQuery);
        }

        // ===============================================================================
        //                                                                    Purpose Type
        //                                                                    ============
        public void xsetupForColumnQuery(LdLendingCollectionCB mainCB) {
            xinheritSubQueryInfo(mainCB.LocalCQ);
            //xchangePurposeSqlClause(HpCBPurpose.COLUMN_QUERY);
            _forColumnQuery = true; // old style

            // inherits a parent query to synchronize real name
            // (and also for suppressing query check) 
            Specify().xsetSyncQyCall(new LdLendingCollectionCBColQySpQyCall(mainCB));
        }
    }

    public class LdLendingCollectionCBColQySpQyCall : HpSpQyCall<LdLendingCollectionCQ> {
        protected LdLendingCollectionCB _mainCB;
        public LdLendingCollectionCBColQySpQyCall(LdLendingCollectionCB mainCB) {
            _mainCB = mainCB;
        }
        public bool has() { return true; } 
        public LdLendingCollectionCQ qy() { return _mainCB.Query(); } 
    }

    public class LdLendingCollectionCBSpecification : AbstractSpecification<LdLendingCollectionCQ> {
        protected LdCollectionCBSpecification _collection;
        protected LdLendingCBSpecification _lending;
        protected LdLibraryUserCBSpecification _libraryUser;
        public LdLendingCollectionCBSpecification(LdConditionBean baseCB, HpSpQyCall<LdLendingCollectionCQ> qyCall
                                                      , bool forDerivedReferrer, bool forScalarSelect, bool forScalarSubQuery, bool forColumnQuery)
        : base(baseCB, qyCall, forDerivedReferrer, forScalarSelect, forScalarSubQuery, forColumnQuery) { }
        public void ColumnLibraryId() { doColumn("LIBRARY_ID"); }
        public void ColumnLbUserId() { doColumn("LB_USER_ID"); }
        public void ColumnLendingDate() { doColumn("LENDING_DATE"); }
        public void ColumnCollectionId() { doColumn("COLLECTION_ID"); }
        public void ColumnReturnLimitDate() { doColumn("RETURN_LIMIT_DATE"); }
        public void ColumnRUser() { doColumn("R_USER"); }
        public void ColumnRModule() { doColumn("R_MODULE"); }
        public void ColumnRTimestamp() { doColumn("R_TIMESTAMP"); }
        public void ColumnUUser() { doColumn("U_USER"); }
        public void ColumnUModule() { doColumn("U_MODULE"); }
        public void ColumnUTimestamp() { doColumn("U_TIMESTAMP"); }
        protected override void doSpecifyRequiredColumn() {
            ColumnLibraryId(); // PK
            ColumnLbUserId(); // PK
            ColumnLendingDate(); // PK
            ColumnCollectionId(); // PK
        }
        protected override String getTableDbName() { return "lending_collection"; }
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
		    protected HpSpQyCall<LdLendingCollectionCQ> _qyCall;
		    public CollectionSpQyCall(HpSpQyCall<LdLendingCollectionCQ> myQyCall) { _qyCall = myQyCall; }
		    public bool has() { return _qyCall.has() && _qyCall.qy().hasConditionQueryCollection(); }
			public LdCollectionCQ qy() { return _qyCall.qy().QueryCollection(); }
		}
        public LdLendingCBSpecification SpecifyLending() {
            assertForeign("lending");
            if (_lending == null) {
                _lending = new LdLendingCBSpecification(_baseCB, new LendingSpQyCall(_qyCall), _forDerivedReferrer, _forScalarSelect, _forScalarCondition, _forColumnQuery);
                if (xhasSyncQyCall()) // inherits it
                { _lending.xsetSyncQyCall(new LendingSpQyCall(xsyncQyCall())); }
            }
            return _lending;
        }
		public class LendingSpQyCall : HpSpQyCall<LdLendingCQ> {
		    protected HpSpQyCall<LdLendingCollectionCQ> _qyCall;
		    public LendingSpQyCall(HpSpQyCall<LdLendingCollectionCQ> myQyCall) { _qyCall = myQyCall; }
		    public bool has() { return _qyCall.has() && _qyCall.qy().hasConditionQueryLending(); }
			public LdLendingCQ qy() { return _qyCall.qy().QueryLending(); }
		}
        public LdLibraryUserCBSpecification SpecifyLibraryUser() {
            assertForeign("libraryUser");
            if (_libraryUser == null) {
                _libraryUser = new LdLibraryUserCBSpecification(_baseCB, new LibraryUserSpQyCall(_qyCall), _forDerivedReferrer, _forScalarSelect, _forScalarCondition, _forColumnQuery);
                if (xhasSyncQyCall()) // inherits it
                { _libraryUser.xsetSyncQyCall(new LibraryUserSpQyCall(xsyncQyCall())); }
            }
            return _libraryUser;
        }
		public class LibraryUserSpQyCall : HpSpQyCall<LdLibraryUserCQ> {
		    protected HpSpQyCall<LdLendingCollectionCQ> _qyCall;
		    public LibraryUserSpQyCall(HpSpQyCall<LdLendingCollectionCQ> myQyCall) { _qyCall = myQyCall; }
		    public bool has() { return _qyCall.has() && _qyCall.qy().hasConditionQueryLibraryUser(); }
			public LdLibraryUserCQ qy() { return _qyCall.qy().QueryLibraryUser(); }
		}
    }
}
