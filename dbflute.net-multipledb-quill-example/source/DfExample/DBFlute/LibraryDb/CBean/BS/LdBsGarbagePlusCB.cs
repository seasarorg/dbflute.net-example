
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
    public class LdBsGarbagePlusCB : LdAbstractConditionBean {

        // ===============================================================================
        //                                                                       Attribute
        //                                                                       =========
        protected LdGarbagePlusCQ _conditionQuery;

        // ===============================================================================
        //                                                                      Table Name
        //                                                                      ==========
        public override String TableDbName { get { return "garbage_plus"; } }

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
        public LdGarbagePlusCQ Query() {
            return this.ConditionQuery;
        }

        public LdGarbagePlusCQ ConditionQuery {
            get {
                if (_conditionQuery == null) {
                    _conditionQuery = CreateLocalCQ();
                }
                return _conditionQuery;
            }
        }

        protected virtual LdGarbagePlusCQ CreateLocalCQ() {
            return xcreateCQ(null, this.SqlClause, this.SqlClause.getBasePointAliasName(), 0);
        }

        protected virtual LdGarbagePlusCQ xcreateCQ(LdConditionQuery childQuery, LdSqlClause sqlClause, String aliasName, int nestLevel) {
            return new LdGarbagePlusCQ(childQuery, sqlClause, aliasName, nestLevel);
        }

        public override LdConditionQuery LocalCQ {
            get { return this.ConditionQuery; }
        }

        // ===============================================================================
        //                                                                           Union
        //                                                                           =====
	    public virtual void Union(LdUnionQuery<LdGarbagePlusCB> unionQuery) {
            LdGarbagePlusCB cb = new LdGarbagePlusCB();
            cb.xsetupForUnion(this); xsyncUQ(cb); unionQuery.Invoke(cb);
		    LdGarbagePlusCQ cq = cb.Query(); Query().xsetUnionQuery(cq);
        }

	    public virtual void UnionAll(LdUnionQuery<LdGarbagePlusCB> unionQuery) {
            LdGarbagePlusCB cb = new LdGarbagePlusCB();
            cb.xsetupForUnion(this); xsyncUQ(cb); unionQuery.Invoke(cb);
		    LdGarbagePlusCQ cq = cb.Query(); Query().xsetUnionAllQuery(cq);
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
        protected LdGarbagePlusCBSpecification _specification;
        public LdGarbagePlusCBSpecification Specify() {
            if (_specification == null) { _specification = new LdGarbagePlusCBSpecification(this, new MySpQyCall(this), _forDerivedReferrer, _forScalarSelect, _forScalarCondition, _forColumnQuery); }
            return _specification;
        }
        protected bool HasSpecifiedColumn { get {
            return _specification != null && _specification.IsAlreadySpecifiedRequiredColumn;
        }}
        protected class MySpQyCall : HpSpQyCall<LdGarbagePlusCQ> {
			protected LdBsGarbagePlusCB _myCB;
			public MySpQyCall(LdBsGarbagePlusCB myCB) { _myCB = myCB; }
    		public bool has() { return true; } public LdGarbagePlusCQ qy() { return _myCB.Query(); }
    	}

        // [DBFlute-0.8.9.18]
        // ===============================================================================
        //                                                                     ColumnQuery
        //                                                                     ===========
        public HpColQyOperand<LdGarbagePlusCB> ColumnQuery(LdSpecifyQuery<LdGarbagePlusCB> leftSpecifyQuery) {
            return new HpColQyOperand<LdGarbagePlusCB>(delegate(LdSpecifyQuery<LdGarbagePlusCB> rightSp, String operand) {
                xcolqy(xcreateColumnQueryCB(), xcreateColumnQueryCB(), leftSpecifyQuery, rightSp, operand);
            });
        }

        protected LdGarbagePlusCB xcreateColumnQueryCB() {
            LdGarbagePlusCB cb = new LdGarbagePlusCB();
            cb.xsetupForColumnQuery((LdGarbagePlusCB)this);
            return cb;
        }

        // [DBFlute-0.8.9.9]
        // ===============================================================================
        //                                                                    OrScopeQuery
        //                                                                    ============
        public void OrScopeQuery(LdOrQuery<LdGarbagePlusCB> orQuery) {
            xorQ((LdGarbagePlusCB)this, orQuery);
        }

        // ===============================================================================
        //                                                                    Purpose Type
        //                                                                    ============
        public void xsetupForColumnQuery(LdGarbagePlusCB mainCB) {
            xinheritSubQueryInfo(mainCB.LocalCQ);
            //xchangePurposeSqlClause(HpCBPurpose.COLUMN_QUERY);
            _forColumnQuery = true; // old style

            // inherits a parent query to synchronize real name
            // (and also for suppressing query check) 
            Specify().xsetSyncQyCall(new LdGarbagePlusCBColQySpQyCall(mainCB));
        }
    }

    public class LdGarbagePlusCBColQySpQyCall : HpSpQyCall<LdGarbagePlusCQ> {
        protected LdGarbagePlusCB _mainCB;
        public LdGarbagePlusCBColQySpQyCall(LdGarbagePlusCB mainCB) {
            _mainCB = mainCB;
        }
        public bool has() { return true; } 
        public LdGarbagePlusCQ qy() { return _mainCB.Query(); } 
    }

    public class LdGarbagePlusCBSpecification : AbstractSpecification<LdGarbagePlusCQ> {
        public LdGarbagePlusCBSpecification(LdConditionBean baseCB, HpSpQyCall<LdGarbagePlusCQ> qyCall
                                                      , bool forDerivedReferrer, bool forScalarSelect, bool forScalarSubQuery, bool forColumnQuery)
        : base(baseCB, qyCall, forDerivedReferrer, forScalarSelect, forScalarSubQuery, forColumnQuery) { }
        public void ColumnGarbageMemo() { doColumn("GARBAGE_MEMO"); }
        public void ColumnGarbageTime() { doColumn("GARBAGE_TIME"); }
        public void ColumnGarbageCount() { doColumn("GARBAGE_COUNT"); }
        public void ColumnRUser() { doColumn("R_USER"); }
        public void ColumnRModule() { doColumn("R_MODULE"); }
        public void ColumnRTimestamp() { doColumn("R_TIMESTAMP"); }
        public void ColumnUUser() { doColumn("U_USER"); }
        public void ColumnUModule() { doColumn("U_MODULE"); }
        public void ColumnUTimestamp() { doColumn("U_TIMESTAMP"); }
        protected override void doSpecifyRequiredColumn() {
        }
        protected override String getTableDbName() { return "garbage_plus"; }
    }
}
