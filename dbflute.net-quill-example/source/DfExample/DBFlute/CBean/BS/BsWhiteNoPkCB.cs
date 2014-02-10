
using System;
using System.Collections;

using DfExample.DBFlute.AllCommon;
using DfExample.DBFlute.AllCommon.CBean;
using DfExample.DBFlute.AllCommon.CBean.SClause;
using DfExample.DBFlute.AllCommon.Helper;

using DfExample.DBFlute.CBean;
using DfExample.DBFlute.CBean.CQ;
using DfExample.DBFlute.CBean.Nss;

namespace DfExample.DBFlute.CBean.BS {

    [System.Serializable]
    public class BsWhiteNoPkCB : AbstractConditionBean {

        // ===============================================================================
        //                                                                       Attribute
        //                                                                       =========
        protected WhiteNoPkCQ _conditionQuery;

        // ===============================================================================
        //                                                                      Table Name
        //                                                                      ==========
        public override String TableDbName { get { return "white_no_pk"; } }

        // ===============================================================================
        //                                                             PrimaryKey Handling
        //                                                             ===================
        public override ConditionBean AddOrderBy_PK_Asc() {
            String msg = "This method is unsupported in this table that doesn't have primary key: ";
            throw new NotSupportedException(msg + ToString());
        }

        public override ConditionBean AddOrderBy_PK_Desc() {
            String msg = "This method is unsupported in this table that doesn't have primary key: ";
            throw new NotSupportedException(msg + ToString());
        }

        // ===============================================================================
        //                                                                           Query
        //                                                                           =====
        public WhiteNoPkCQ Query() {
            return this.ConditionQuery;
        }

        public WhiteNoPkCQ ConditionQuery {
            get {
                if (_conditionQuery == null) {
                    _conditionQuery = CreateLocalCQ();
                }
                return _conditionQuery;
            }
        }

        protected virtual WhiteNoPkCQ CreateLocalCQ() {
            return xcreateCQ(null, this.SqlClause, this.SqlClause.getBasePointAliasName(), 0);
        }

        protected virtual WhiteNoPkCQ xcreateCQ(ConditionQuery childQuery, SqlClause sqlClause, String aliasName, int nestLevel) {
            return new WhiteNoPkCQ(childQuery, sqlClause, aliasName, nestLevel);
        }

        public override ConditionQuery LocalCQ {
            get { return this.ConditionQuery; }
        }

        // ===============================================================================
        //                                                                           Union
        //                                                                           =====
	    public virtual void Union(UnionQuery<WhiteNoPkCB> unionQuery) {
            WhiteNoPkCB cb = new WhiteNoPkCB();
            cb.xsetupForUnion(this); xsyncUQ(cb); unionQuery.Invoke(cb);
		    WhiteNoPkCQ cq = cb.Query(); Query().xsetUnionQuery(cq);
        }

	    public virtual void UnionAll(UnionQuery<WhiteNoPkCB> unionQuery) {
            WhiteNoPkCB cb = new WhiteNoPkCB();
            cb.xsetupForUnion(this); xsyncUQ(cb); unionQuery.Invoke(cb);
		    WhiteNoPkCQ cq = cb.Query(); Query().xsetUnionAllQuery(cq);
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
        protected WhiteNoPkCBSpecification _specification;
        public WhiteNoPkCBSpecification Specify() {
            if (_specification == null) { _specification = new WhiteNoPkCBSpecification(this, new MySpQyCall(this), _forDerivedReferrer, _forScalarSelect, _forScalarCondition, _forColumnQuery); }
            return _specification;
        }
        protected bool HasSpecifiedColumn { get {
            return _specification != null && _specification.IsAlreadySpecifiedRequiredColumn;
        }}
        protected class MySpQyCall : HpSpQyCall<WhiteNoPkCQ> {
			protected BsWhiteNoPkCB _myCB;
			public MySpQyCall(BsWhiteNoPkCB myCB) { _myCB = myCB; }
    		public bool has() { return true; } public WhiteNoPkCQ qy() { return _myCB.Query(); }
    	}

        // [DBFlute-0.8.9.18]
        // ===============================================================================
        //                                                                     ColumnQuery
        //                                                                     ===========
        public HpColQyOperand<WhiteNoPkCB> ColumnQuery(SpecifyQuery<WhiteNoPkCB> leftSpecifyQuery) {
            return new HpColQyOperand<WhiteNoPkCB>(delegate(SpecifyQuery<WhiteNoPkCB> rightSp, String operand) {
                xcolqy(xcreateColumnQueryCB(), xcreateColumnQueryCB(), leftSpecifyQuery, rightSp, operand);
            });
        }

        protected WhiteNoPkCB xcreateColumnQueryCB() {
            WhiteNoPkCB cb = new WhiteNoPkCB();
            cb.xsetupForColumnQuery((WhiteNoPkCB)this);
            return cb;
        }

        // [DBFlute-0.8.9.9]
        // ===============================================================================
        //                                                                    OrScopeQuery
        //                                                                    ============
        public void OrScopeQuery(OrQuery<WhiteNoPkCB> orQuery) {
            xorQ((WhiteNoPkCB)this, orQuery);
        }

        // ===============================================================================
        //                                                                    Purpose Type
        //                                                                    ============
        public void xsetupForColumnQuery(WhiteNoPkCB mainCB) {
            xinheritSubQueryInfo(mainCB.LocalCQ);
            //xchangePurposeSqlClause(HpCBPurpose.COLUMN_QUERY);
            _forColumnQuery = true; // old style

            // inherits a parent query to synchronize real name
            // (and also for suppressing query check) 
            Specify().xsetSyncQyCall(new WhiteNoPkCBColQySpQyCall(mainCB));
        }
    }

    public class WhiteNoPkCBColQySpQyCall : HpSpQyCall<WhiteNoPkCQ> {
        protected WhiteNoPkCB _mainCB;
        public WhiteNoPkCBColQySpQyCall(WhiteNoPkCB mainCB) {
            _mainCB = mainCB;
        }
        public bool has() { return true; } 
        public WhiteNoPkCQ qy() { return _mainCB.Query(); } 
    }

    public class WhiteNoPkCBSpecification : AbstractSpecification<WhiteNoPkCQ> {
        public WhiteNoPkCBSpecification(ConditionBean baseCB, HpSpQyCall<WhiteNoPkCQ> qyCall
                                                      , bool forDerivedReferrer, bool forScalarSelect, bool forScalarSubQuery, bool forColumnQuery)
        : base(baseCB, qyCall, forDerivedReferrer, forScalarSelect, forScalarSubQuery, forColumnQuery) { }
        public void ColumnNoPkId() { doColumn("NO_PK_ID"); }
        public void ColumnNoPkName() { doColumn("NO_PK_NAME"); }
        public void ColumnNoPkInteger() { doColumn("NO_PK_INTEGER"); }
        protected override void doSpecifyRequiredColumn() {
        }
        protected override String getTableDbName() { return "white_no_pk"; }
    }
}
