
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
    public class BsWhiteColumnExceptCB : AbstractConditionBean {

        // ===============================================================================
        //                                                                       Attribute
        //                                                                       =========
        protected WhiteColumnExceptCQ _conditionQuery;

        // ===============================================================================
        //                                                                      Table Name
        //                                                                      ==========
        public override String TableDbName { get { return "white_column_except"; } }

        // ===============================================================================
        //                                                             PrimaryKey Handling
        //                                                             ===================
        public void AcceptPrimaryKey(long? exceptColumnId) {
            assertObjectNotNull("exceptColumnId", exceptColumnId);
            BsWhiteColumnExceptCB cb = this;
            cb.Query().SetExceptColumnId_Equal(exceptColumnId);
        }

        public override ConditionBean AddOrderBy_PK_Asc() {
            Query().AddOrderBy_ExceptColumnId_Asc();
            return this;
        }

        public override ConditionBean AddOrderBy_PK_Desc() {
            Query().AddOrderBy_ExceptColumnId_Desc();
            return this;
        }

        // ===============================================================================
        //                                                                           Query
        //                                                                           =====
        public WhiteColumnExceptCQ Query() {
            return this.ConditionQuery;
        }

        public WhiteColumnExceptCQ ConditionQuery {
            get {
                if (_conditionQuery == null) {
                    _conditionQuery = CreateLocalCQ();
                }
                return _conditionQuery;
            }
        }

        protected virtual WhiteColumnExceptCQ CreateLocalCQ() {
            return xcreateCQ(null, this.SqlClause, this.SqlClause.getBasePointAliasName(), 0);
        }

        protected virtual WhiteColumnExceptCQ xcreateCQ(ConditionQuery childQuery, SqlClause sqlClause, String aliasName, int nestLevel) {
            return new WhiteColumnExceptCQ(childQuery, sqlClause, aliasName, nestLevel);
        }

        public override ConditionQuery LocalCQ {
            get { return this.ConditionQuery; }
        }

        // ===============================================================================
        //                                                                           Union
        //                                                                           =====
	    public virtual void Union(UnionQuery<WhiteColumnExceptCB> unionQuery) {
            WhiteColumnExceptCB cb = new WhiteColumnExceptCB();
            cb.xsetupForUnion(this); xsyncUQ(cb); unionQuery.Invoke(cb);
		    WhiteColumnExceptCQ cq = cb.Query(); Query().xsetUnionQuery(cq);
        }

	    public virtual void UnionAll(UnionQuery<WhiteColumnExceptCB> unionQuery) {
            WhiteColumnExceptCB cb = new WhiteColumnExceptCB();
            cb.xsetupForUnion(this); xsyncUQ(cb); unionQuery.Invoke(cb);
		    WhiteColumnExceptCQ cq = cb.Query(); Query().xsetUnionAllQuery(cq);
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
        protected WhiteColumnExceptCBSpecification _specification;
        public WhiteColumnExceptCBSpecification Specify() {
            if (_specification == null) { _specification = new WhiteColumnExceptCBSpecification(this, new MySpQyCall(this), _forDerivedReferrer, _forScalarSelect, _forScalarCondition, _forColumnQuery); }
            return _specification;
        }
        protected bool HasSpecifiedColumn { get {
            return _specification != null && _specification.IsAlreadySpecifiedRequiredColumn;
        }}
        protected class MySpQyCall : HpSpQyCall<WhiteColumnExceptCQ> {
			protected BsWhiteColumnExceptCB _myCB;
			public MySpQyCall(BsWhiteColumnExceptCB myCB) { _myCB = myCB; }
    		public bool has() { return true; } public WhiteColumnExceptCQ qy() { return _myCB.Query(); }
    	}

        // [DBFlute-0.8.9.18]
        // ===============================================================================
        //                                                                     ColumnQuery
        //                                                                     ===========
        public HpColQyOperand<WhiteColumnExceptCB> ColumnQuery(SpecifyQuery<WhiteColumnExceptCB> leftSpecifyQuery) {
            return new HpColQyOperand<WhiteColumnExceptCB>(delegate(SpecifyQuery<WhiteColumnExceptCB> rightSp, String operand) {
                xcolqy(xcreateColumnQueryCB(), xcreateColumnQueryCB(), leftSpecifyQuery, rightSp, operand);
            });
        }

        protected WhiteColumnExceptCB xcreateColumnQueryCB() {
            WhiteColumnExceptCB cb = new WhiteColumnExceptCB();
            cb.xsetupForColumnQuery((WhiteColumnExceptCB)this);
            return cb;
        }

        // [DBFlute-0.8.9.9]
        // ===============================================================================
        //                                                                    OrScopeQuery
        //                                                                    ============
        public void OrScopeQuery(OrQuery<WhiteColumnExceptCB> orQuery) {
            xorQ((WhiteColumnExceptCB)this, orQuery);
        }

        // ===============================================================================
        //                                                                    Purpose Type
        //                                                                    ============
        public void xsetupForColumnQuery(WhiteColumnExceptCB mainCB) {
            xinheritSubQueryInfo(mainCB.LocalCQ);
            //xchangePurposeSqlClause(HpCBPurpose.COLUMN_QUERY);
            _forColumnQuery = true; // old style

            // inherits a parent query to synchronize real name
            // (and also for suppressing query check) 
            Specify().xsetSyncQyCall(new WhiteColumnExceptCBColQySpQyCall(mainCB));
        }
    }

    public class WhiteColumnExceptCBColQySpQyCall : HpSpQyCall<WhiteColumnExceptCQ> {
        protected WhiteColumnExceptCB _mainCB;
        public WhiteColumnExceptCBColQySpQyCall(WhiteColumnExceptCB mainCB) {
            _mainCB = mainCB;
        }
        public bool has() { return true; } 
        public WhiteColumnExceptCQ qy() { return _mainCB.Query(); } 
    }

    public class WhiteColumnExceptCBSpecification : AbstractSpecification<WhiteColumnExceptCQ> {
        public WhiteColumnExceptCBSpecification(ConditionBean baseCB, HpSpQyCall<WhiteColumnExceptCQ> qyCall
                                                      , bool forDerivedReferrer, bool forScalarSelect, bool forScalarSubQuery, bool forColumnQuery)
        : base(baseCB, qyCall, forDerivedReferrer, forScalarSelect, forScalarSubQuery, forColumnQuery) { }
        public void ColumnExceptColumnId() { doColumn("EXCEPT_COLUMN_ID"); }
        public void ColumnColumnExceptTest() { doColumn("COLUMN_EXCEPT_TEST"); }
        protected override void doSpecifyRequiredColumn() {
            ColumnExceptColumnId(); // PK
        }
        protected override String getTableDbName() { return "white_column_except"; }
    }
}
