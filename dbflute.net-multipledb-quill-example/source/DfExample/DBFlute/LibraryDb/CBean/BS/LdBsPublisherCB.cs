
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
    public class LdBsPublisherCB : LdAbstractConditionBean {

        // ===============================================================================
        //                                                                       Attribute
        //                                                                       =========
        protected LdPublisherCQ _conditionQuery;

        // ===============================================================================
        //                                                                      Table Name
        //                                                                      ==========
        public override String TableDbName { get { return "publisher"; } }

        // ===============================================================================
        //                                                             PrimaryKey Handling
        //                                                             ===================
        public void AcceptPrimaryKey(int? publisherId) {
            assertObjectNotNull("publisherId", publisherId);
            LdBsPublisherCB cb = this;
            cb.Query().SetPublisherId_Equal(publisherId);
        }

        public override LdConditionBean AddOrderBy_PK_Asc() {
            Query().AddOrderBy_PublisherId_Asc();
            return this;
        }

        public override LdConditionBean AddOrderBy_PK_Desc() {
            Query().AddOrderBy_PublisherId_Desc();
            return this;
        }

        // ===============================================================================
        //                                                                           Query
        //                                                                           =====
        public LdPublisherCQ Query() {
            return this.ConditionQuery;
        }

        public LdPublisherCQ ConditionQuery {
            get {
                if (_conditionQuery == null) {
                    _conditionQuery = CreateLocalCQ();
                }
                return _conditionQuery;
            }
        }

        protected virtual LdPublisherCQ CreateLocalCQ() {
            return xcreateCQ(null, this.SqlClause, this.SqlClause.getBasePointAliasName(), 0);
        }

        protected virtual LdPublisherCQ xcreateCQ(LdConditionQuery childQuery, LdSqlClause sqlClause, String aliasName, int nestLevel) {
            return new LdPublisherCQ(childQuery, sqlClause, aliasName, nestLevel);
        }

        public override LdConditionQuery LocalCQ {
            get { return this.ConditionQuery; }
        }

        // ===============================================================================
        //                                                                           Union
        //                                                                           =====
	    public virtual void Union(LdUnionQuery<LdPublisherCB> unionQuery) {
            LdPublisherCB cb = new LdPublisherCB();
            cb.xsetupForUnion(this); xsyncUQ(cb); unionQuery.Invoke(cb);
		    LdPublisherCQ cq = cb.Query(); Query().xsetUnionQuery(cq);
        }

	    public virtual void UnionAll(LdUnionQuery<LdPublisherCB> unionQuery) {
            LdPublisherCB cb = new LdPublisherCB();
            cb.xsetupForUnion(this); xsyncUQ(cb); unionQuery.Invoke(cb);
		    LdPublisherCQ cq = cb.Query(); Query().xsetUnionAllQuery(cq);
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
        protected LdPublisherCBSpecification _specification;
        public LdPublisherCBSpecification Specify() {
            if (_specification == null) { _specification = new LdPublisherCBSpecification(this, new MySpQyCall(this), _forDerivedReferrer, _forScalarSelect, _forScalarCondition, _forColumnQuery); }
            return _specification;
        }
        protected bool HasSpecifiedColumn { get {
            return _specification != null && _specification.IsAlreadySpecifiedRequiredColumn;
        }}
        protected class MySpQyCall : HpSpQyCall<LdPublisherCQ> {
			protected LdBsPublisherCB _myCB;
			public MySpQyCall(LdBsPublisherCB myCB) { _myCB = myCB; }
    		public bool has() { return true; } public LdPublisherCQ qy() { return _myCB.Query(); }
    	}

        // [DBFlute-0.8.9.18]
        // ===============================================================================
        //                                                                     ColumnQuery
        //                                                                     ===========
        public HpColQyOperand<LdPublisherCB> ColumnQuery(LdSpecifyQuery<LdPublisherCB> leftSpecifyQuery) {
            return new HpColQyOperand<LdPublisherCB>(delegate(LdSpecifyQuery<LdPublisherCB> rightSp, String operand) {
                xcolqy(xcreateColumnQueryCB(), xcreateColumnQueryCB(), leftSpecifyQuery, rightSp, operand);
            });
        }

        protected LdPublisherCB xcreateColumnQueryCB() {
            LdPublisherCB cb = new LdPublisherCB();
            cb.xsetupForColumnQuery((LdPublisherCB)this);
            return cb;
        }

        // [DBFlute-0.8.9.9]
        // ===============================================================================
        //                                                                    OrScopeQuery
        //                                                                    ============
        public void OrScopeQuery(LdOrQuery<LdPublisherCB> orQuery) {
            xorQ((LdPublisherCB)this, orQuery);
        }

        // ===============================================================================
        //                                                                    Purpose Type
        //                                                                    ============
        public void xsetupForColumnQuery(LdPublisherCB mainCB) {
            xinheritSubQueryInfo(mainCB.LocalCQ);
            //xchangePurposeSqlClause(HpCBPurpose.COLUMN_QUERY);
            _forColumnQuery = true; // old style

            // inherits a parent query to synchronize real name
            // (and also for suppressing query check) 
            Specify().xsetSyncQyCall(new LdPublisherCBColQySpQyCall(mainCB));
        }
    }

    public class LdPublisherCBColQySpQyCall : HpSpQyCall<LdPublisherCQ> {
        protected LdPublisherCB _mainCB;
        public LdPublisherCBColQySpQyCall(LdPublisherCB mainCB) {
            _mainCB = mainCB;
        }
        public bool has() { return true; } 
        public LdPublisherCQ qy() { return _mainCB.Query(); } 
    }

    public class LdPublisherCBSpecification : AbstractSpecification<LdPublisherCQ> {
        public LdPublisherCBSpecification(LdConditionBean baseCB, HpSpQyCall<LdPublisherCQ> qyCall
                                                      , bool forDerivedReferrer, bool forScalarSelect, bool forScalarSubQuery, bool forColumnQuery)
        : base(baseCB, qyCall, forDerivedReferrer, forScalarSelect, forScalarSubQuery, forColumnQuery) { }
        public void ColumnPublisherId() { doColumn("PUBLISHER_ID"); }
        public void ColumnPublisherName() { doColumn("PUBLISHER_NAME"); }
        public void ColumnRUser() { doColumn("R_USER"); }
        public void ColumnRModule() { doColumn("R_MODULE"); }
        public void ColumnRTimestamp() { doColumn("R_TIMESTAMP"); }
        public void ColumnUUser() { doColumn("U_USER"); }
        public void ColumnUModule() { doColumn("U_MODULE"); }
        public void ColumnUTimestamp() { doColumn("U_TIMESTAMP"); }
        protected override void doSpecifyRequiredColumn() {
            ColumnPublisherId(); // PK
        }
        protected override String getTableDbName() { return "publisher"; }
        public RAFunction<LdBookCB, LdPublisherCQ> DerivedBookList() {
            if (xhasSyncQyCall()) { xsyncQyCall().qy(); } // for sync (for example, this in ColumnQuery)
            return new RAFunction<LdBookCB, LdPublisherCQ>(_baseCB, _qyCall.qy(), delegate(String function, LdSubQuery<LdBookCB> subQuery, LdPublisherCQ cq, String aliasName)
                { cq.xsderiveBookList(function, subQuery, aliasName); });
        }
    }
}
