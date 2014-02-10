
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
    public class LdBsCollectionStatusLookupCB : LdAbstractConditionBean {

        // ===============================================================================
        //                                                                       Attribute
        //                                                                       =========
        protected LdCollectionStatusLookupCQ _conditionQuery;

        // ===============================================================================
        //                                                                      Table Name
        //                                                                      ==========
        public override String TableDbName { get { return "collection_status_lookup"; } }

        // ===============================================================================
        //                                                             PrimaryKey Handling
        //                                                             ===================
        public void AcceptPrimaryKey(String collectionStatusCode) {
            assertObjectNotNull("collectionStatusCode", collectionStatusCode);
            LdBsCollectionStatusLookupCB cb = this;
            cb.Query().SetCollectionStatusCode_Equal(collectionStatusCode);
        }

        public override LdConditionBean AddOrderBy_PK_Asc() {
            Query().AddOrderBy_CollectionStatusCode_Asc();
            return this;
        }

        public override LdConditionBean AddOrderBy_PK_Desc() {
            Query().AddOrderBy_CollectionStatusCode_Desc();
            return this;
        }

        // ===============================================================================
        //                                                                           Query
        //                                                                           =====
        public LdCollectionStatusLookupCQ Query() {
            return this.ConditionQuery;
        }

        public LdCollectionStatusLookupCQ ConditionQuery {
            get {
                if (_conditionQuery == null) {
                    _conditionQuery = CreateLocalCQ();
                }
                return _conditionQuery;
            }
        }

        protected virtual LdCollectionStatusLookupCQ CreateLocalCQ() {
            return xcreateCQ(null, this.SqlClause, this.SqlClause.getBasePointAliasName(), 0);
        }

        protected virtual LdCollectionStatusLookupCQ xcreateCQ(LdConditionQuery childQuery, LdSqlClause sqlClause, String aliasName, int nestLevel) {
            return new LdCollectionStatusLookupCQ(childQuery, sqlClause, aliasName, nestLevel);
        }

        public override LdConditionQuery LocalCQ {
            get { return this.ConditionQuery; }
        }

        // ===============================================================================
        //                                                                           Union
        //                                                                           =====
	    public virtual void Union(LdUnionQuery<LdCollectionStatusLookupCB> unionQuery) {
            LdCollectionStatusLookupCB cb = new LdCollectionStatusLookupCB();
            cb.xsetupForUnion(this); xsyncUQ(cb); unionQuery.Invoke(cb);
		    LdCollectionStatusLookupCQ cq = cb.Query(); Query().xsetUnionQuery(cq);
        }

	    public virtual void UnionAll(LdUnionQuery<LdCollectionStatusLookupCB> unionQuery) {
            LdCollectionStatusLookupCB cb = new LdCollectionStatusLookupCB();
            cb.xsetupForUnion(this); xsyncUQ(cb); unionQuery.Invoke(cb);
		    LdCollectionStatusLookupCQ cq = cb.Query(); Query().xsetUnionAllQuery(cq);
	    }

        public override bool HasUnionQueryOrUnionAllQuery() {
            return Query().hasUnionQueryOrUnionAllQuery();
        }

        // ===============================================================================
        //                                                                    Setup Select
        //                                                                    ============

        // [DBFlute-0.7.4]
        // ===============================================================================
        //                                                                         Specify
        //                                                                         =======
        protected LdCollectionStatusLookupCBSpecification _specification;
        public LdCollectionStatusLookupCBSpecification Specify() {
            if (_specification == null) { _specification = new LdCollectionStatusLookupCBSpecification(this, new MySpQyCall(this), _forDerivedReferrer, _forScalarSelect, _forScalarCondition, _forColumnQuery); }
            return _specification;
        }
        protected bool HasSpecifiedColumn { get {
            return _specification != null && _specification.IsAlreadySpecifiedRequiredColumn;
        }}
        protected class MySpQyCall : HpSpQyCall<LdCollectionStatusLookupCQ> {
			protected LdBsCollectionStatusLookupCB _myCB;
			public MySpQyCall(LdBsCollectionStatusLookupCB myCB) { _myCB = myCB; }
    		public bool has() { return true; } public LdCollectionStatusLookupCQ qy() { return _myCB.Query(); }
    	}

        // [DBFlute-0.8.9.18]
        // ===============================================================================
        //                                                                     ColumnQuery
        //                                                                     ===========
        public HpColQyOperand<LdCollectionStatusLookupCB> ColumnQuery(LdSpecifyQuery<LdCollectionStatusLookupCB> leftSpecifyQuery) {
            return new HpColQyOperand<LdCollectionStatusLookupCB>(delegate(LdSpecifyQuery<LdCollectionStatusLookupCB> rightSp, String operand) {
                xcolqy(xcreateColumnQueryCB(), xcreateColumnQueryCB(), leftSpecifyQuery, rightSp, operand);
            });
        }

        protected LdCollectionStatusLookupCB xcreateColumnQueryCB() {
            LdCollectionStatusLookupCB cb = new LdCollectionStatusLookupCB();
            cb.xsetupForColumnQuery((LdCollectionStatusLookupCB)this);
            return cb;
        }

        // [DBFlute-0.8.9.9]
        // ===============================================================================
        //                                                                    OrScopeQuery
        //                                                                    ============
        public void OrScopeQuery(LdOrQuery<LdCollectionStatusLookupCB> orQuery) {
            xorQ((LdCollectionStatusLookupCB)this, orQuery);
        }

        // ===============================================================================
        //                                                                    Purpose Type
        //                                                                    ============
        public void xsetupForColumnQuery(LdCollectionStatusLookupCB mainCB) {
            xinheritSubQueryInfo(mainCB.LocalCQ);
            //xchangePurposeSqlClause(HpCBPurpose.COLUMN_QUERY);
            _forColumnQuery = true; // old style

            // inherits a parent query to synchronize real name
            // (and also for suppressing query check) 
            Specify().xsetSyncQyCall(new LdCollectionStatusLookupCBColQySpQyCall(mainCB));
        }
    }

    public class LdCollectionStatusLookupCBColQySpQyCall : HpSpQyCall<LdCollectionStatusLookupCQ> {
        protected LdCollectionStatusLookupCB _mainCB;
        public LdCollectionStatusLookupCBColQySpQyCall(LdCollectionStatusLookupCB mainCB) {
            _mainCB = mainCB;
        }
        public bool has() { return true; } 
        public LdCollectionStatusLookupCQ qy() { return _mainCB.Query(); } 
    }

    public class LdCollectionStatusLookupCBSpecification : AbstractSpecification<LdCollectionStatusLookupCQ> {
        public LdCollectionStatusLookupCBSpecification(LdConditionBean baseCB, HpSpQyCall<LdCollectionStatusLookupCQ> qyCall
                                                      , bool forDerivedReferrer, bool forScalarSelect, bool forScalarSubQuery, bool forColumnQuery)
        : base(baseCB, qyCall, forDerivedReferrer, forScalarSelect, forScalarSubQuery, forColumnQuery) { }
        public void ColumnCollectionStatusCode() { doColumn("COLLECTION_STATUS_CODE"); }
        public void ColumnCollectionStatusName() { doColumn("COLLECTION_STATUS_NAME"); }
        public void ColumnRUser() { doColumn("R_USER"); }
        public void ColumnRModule() { doColumn("R_MODULE"); }
        public void ColumnRTimestamp() { doColumn("R_TIMESTAMP"); }
        public void ColumnUUser() { doColumn("U_USER"); }
        public void ColumnUModule() { doColumn("U_MODULE"); }
        public void ColumnUTimestamp() { doColumn("U_TIMESTAMP"); }
        protected override void doSpecifyRequiredColumn() {
            ColumnCollectionStatusCode(); // PK
        }
        protected override String getTableDbName() { return "collection_status_lookup"; }
        public RAFunction<LdCollectionStatusCB, LdCollectionStatusLookupCQ> DerivedCollectionStatusList() {
            if (xhasSyncQyCall()) { xsyncQyCall().qy(); } // for sync (for example, this in ColumnQuery)
            return new RAFunction<LdCollectionStatusCB, LdCollectionStatusLookupCQ>(_baseCB, _qyCall.qy(), delegate(String function, LdSubQuery<LdCollectionStatusCB> subQuery, LdCollectionStatusLookupCQ cq, String aliasName)
                { cq.xsderiveCollectionStatusList(function, subQuery, aliasName); });
        }
    }
}
