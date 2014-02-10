
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
    public class LdBsGarbageCB : LdAbstractConditionBean {

        // ===============================================================================
        //                                                                       Attribute
        //                                                                       =========
        protected LdGarbageCQ _conditionQuery;

        // ===============================================================================
        //                                                                      Table Name
        //                                                                      ==========
        public override String TableDbName { get { return "garbage"; } }

        // ===============================================================================
        //                                                             PrimaryKey Handling
        //                                                             ===================
        public override LdConditionBean AddOrderBy_PK_Asc() {
            String msg = "This method is unsupported in this table that doesn't have primary key: ";
            throw new NotSupportedException(msg + ToString());
        }

        public override LdConditionBean AddOrderBy_PK_Desc() {
            String msg = "This method is unsupported in this table that doesn't have primary key: ";
            throw new NotSupportedException(msg + ToString());
        }

        // ===============================================================================
        //                                                                           Query
        //                                                                           =====
        public LdGarbageCQ Query() {
            return this.ConditionQuery;
        }

        public LdGarbageCQ ConditionQuery {
            get {
                if (_conditionQuery == null) {
                    _conditionQuery = CreateLocalCQ();
                }
                return _conditionQuery;
            }
        }

        protected virtual LdGarbageCQ CreateLocalCQ() {
            return xcreateCQ(null, this.SqlClause, this.SqlClause.getBasePointAliasName(), 0);
        }

        protected virtual LdGarbageCQ xcreateCQ(LdConditionQuery childQuery, LdSqlClause sqlClause, String aliasName, int nestLevel) {
            return new LdGarbageCQ(childQuery, sqlClause, aliasName, nestLevel);
        }

        public override LdConditionQuery LocalCQ {
            get { return this.ConditionQuery; }
        }

        // ===============================================================================
        //                                                                           Union
        //                                                                           =====
	    public virtual void Union(LdUnionQuery<LdGarbageCB> unionQuery) {
            LdGarbageCB cb = new LdGarbageCB();
            cb.xsetupForUnion(this); xsyncUQ(cb); unionQuery.Invoke(cb);
		    LdGarbageCQ cq = cb.Query(); Query().xsetUnionQuery(cq);
        }

	    public virtual void UnionAll(LdUnionQuery<LdGarbageCB> unionQuery) {
            LdGarbageCB cb = new LdGarbageCB();
            cb.xsetupForUnion(this); xsyncUQ(cb); unionQuery.Invoke(cb);
		    LdGarbageCQ cq = cb.Query(); Query().xsetUnionAllQuery(cq);
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
        protected LdGarbageCBSpecification _specification;
        public LdGarbageCBSpecification Specify() {
            if (_specification == null) { _specification = new LdGarbageCBSpecification(this, new MySpQyCall(this), _forDerivedReferrer, _forScalarSelect, _forScalarCondition, _forColumnQuery); }
            return _specification;
        }
        protected bool HasSpecifiedColumn { get {
            return _specification != null && _specification.IsAlreadySpecifiedRequiredColumn;
        }}
        protected class MySpQyCall : HpSpQyCall<LdGarbageCQ> {
			protected LdBsGarbageCB _myCB;
			public MySpQyCall(LdBsGarbageCB myCB) { _myCB = myCB; }
    		public bool has() { return true; } public LdGarbageCQ qy() { return _myCB.Query(); }
    	}

        // [DBFlute-0.8.9.18]
        // ===============================================================================
        //                                                                     ColumnQuery
        //                                                                     ===========
        public HpColQyOperand<LdGarbageCB> ColumnQuery(LdSpecifyQuery<LdGarbageCB> leftSpecifyQuery) {
            return new HpColQyOperand<LdGarbageCB>(delegate(LdSpecifyQuery<LdGarbageCB> rightSp, String operand) {
                xcolqy(xcreateColumnQueryCB(), xcreateColumnQueryCB(), leftSpecifyQuery, rightSp, operand);
            });
        }

        protected LdGarbageCB xcreateColumnQueryCB() {
            LdGarbageCB cb = new LdGarbageCB();
            cb.xsetupForColumnQuery((LdGarbageCB)this);
            return cb;
        }

        // [DBFlute-0.8.9.9]
        // ===============================================================================
        //                                                                    OrScopeQuery
        //                                                                    ============
        public void OrScopeQuery(LdOrQuery<LdGarbageCB> orQuery) {
            xorQ((LdGarbageCB)this, orQuery);
        }

        // ===============================================================================
        //                                                                    Purpose Type
        //                                                                    ============
        public void xsetupForColumnQuery(LdGarbageCB mainCB) {
            xinheritSubQueryInfo(mainCB.LocalCQ);
            //xchangePurposeSqlClause(HpCBPurpose.COLUMN_QUERY);
            _forColumnQuery = true; // old style

            // inherits a parent query to synchronize real name
            // (and also for suppressing query check) 
            Specify().xsetSyncQyCall(new LdGarbageCBColQySpQyCall(mainCB));
        }
    }

    public class LdGarbageCBColQySpQyCall : HpSpQyCall<LdGarbageCQ> {
        protected LdGarbageCB _mainCB;
        public LdGarbageCBColQySpQyCall(LdGarbageCB mainCB) {
            _mainCB = mainCB;
        }
        public bool has() { return true; } 
        public LdGarbageCQ qy() { return _mainCB.Query(); } 
    }

    public class LdGarbageCBSpecification : AbstractSpecification<LdGarbageCQ> {
        public LdGarbageCBSpecification(LdConditionBean baseCB, HpSpQyCall<LdGarbageCQ> qyCall
                                                      , bool forDerivedReferrer, bool forScalarSelect, bool forScalarSubQuery, bool forColumnQuery)
        : base(baseCB, qyCall, forDerivedReferrer, forScalarSelect, forScalarSubQuery, forColumnQuery) { }
        public void ColumnGarbageMemo() { doColumn("GARBAGE_MEMO"); }
        public void ColumnGarbageTime() { doColumn("GARBAGE_TIME"); }
        public void ColumnGarbageCount() { doColumn("GARBAGE_COUNT"); }
        public void ColumnRUser() { doColumn("R_USER"); }
        public void ColumnRTimestamp() { doColumn("R_TIMESTAMP"); }
        public void ColumnUUser() { doColumn("U_USER"); }
        public void ColumnUTimestamp() { doColumn("U_TIMESTAMP"); }
        protected override void doSpecifyRequiredColumn() {
        }
        protected override String getTableDbName() { return "garbage"; }
    }
}
