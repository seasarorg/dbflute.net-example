
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
    public class BsWhiteQuotedCB : AbstractConditionBean {

        // ===============================================================================
        //                                                                       Attribute
        //                                                                       =========
        protected WhiteQuotedCQ _conditionQuery;

        // ===============================================================================
        //                                                                      Table Name
        //                                                                      ==========
        public override String TableDbName { get { return "white_quoted"; } }

        // ===============================================================================
        //                                                             PrimaryKey Handling
        //                                                             ===================
        public void AcceptPrimaryKey(int? select) {
            assertObjectNotNull("select", select);
            BsWhiteQuotedCB cb = this;
            cb.Query().SetSelect_Equal(select);
        }

        public override ConditionBean AddOrderBy_PK_Asc() {
            Query().AddOrderBy_Select_Asc();
            return this;
        }

        public override ConditionBean AddOrderBy_PK_Desc() {
            Query().AddOrderBy_Select_Desc();
            return this;
        }

        // ===============================================================================
        //                                                                           Query
        //                                                                           =====
        public WhiteQuotedCQ Query() {
            return this.ConditionQuery;
        }

        public WhiteQuotedCQ ConditionQuery {
            get {
                if (_conditionQuery == null) {
                    _conditionQuery = CreateLocalCQ();
                }
                return _conditionQuery;
            }
        }

        protected virtual WhiteQuotedCQ CreateLocalCQ() {
            return xcreateCQ(null, this.SqlClause, this.SqlClause.getBasePointAliasName(), 0);
        }

        protected virtual WhiteQuotedCQ xcreateCQ(ConditionQuery childQuery, SqlClause sqlClause, String aliasName, int nestLevel) {
            return new WhiteQuotedCQ(childQuery, sqlClause, aliasName, nestLevel);
        }

        public override ConditionQuery LocalCQ {
            get { return this.ConditionQuery; }
        }

        // ===============================================================================
        //                                                                           Union
        //                                                                           =====
	    public virtual void Union(UnionQuery<WhiteQuotedCB> unionQuery) {
            WhiteQuotedCB cb = new WhiteQuotedCB();
            cb.xsetupForUnion(this); xsyncUQ(cb); unionQuery.Invoke(cb);
		    WhiteQuotedCQ cq = cb.Query(); Query().xsetUnionQuery(cq);
        }

	    public virtual void UnionAll(UnionQuery<WhiteQuotedCB> unionQuery) {
            WhiteQuotedCB cb = new WhiteQuotedCB();
            cb.xsetupForUnion(this); xsyncUQ(cb); unionQuery.Invoke(cb);
		    WhiteQuotedCQ cq = cb.Query(); Query().xsetUnionAllQuery(cq);
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
        protected WhiteQuotedCBSpecification _specification;
        public WhiteQuotedCBSpecification Specify() {
            if (_specification == null) { _specification = new WhiteQuotedCBSpecification(this, new MySpQyCall(this), _forDerivedReferrer, _forScalarSelect, _forScalarCondition, _forColumnQuery); }
            return _specification;
        }
        protected bool HasSpecifiedColumn { get {
            return _specification != null && _specification.IsAlreadySpecifiedRequiredColumn;
        }}
        protected class MySpQyCall : HpSpQyCall<WhiteQuotedCQ> {
			protected BsWhiteQuotedCB _myCB;
			public MySpQyCall(BsWhiteQuotedCB myCB) { _myCB = myCB; }
    		public bool has() { return true; } public WhiteQuotedCQ qy() { return _myCB.Query(); }
    	}

        // [DBFlute-0.8.9.18]
        // ===============================================================================
        //                                                                     ColumnQuery
        //                                                                     ===========
        public HpColQyOperand<WhiteQuotedCB> ColumnQuery(SpecifyQuery<WhiteQuotedCB> leftSpecifyQuery) {
            return new HpColQyOperand<WhiteQuotedCB>(delegate(SpecifyQuery<WhiteQuotedCB> rightSp, String operand) {
                xcolqy(xcreateColumnQueryCB(), xcreateColumnQueryCB(), leftSpecifyQuery, rightSp, operand);
            });
        }

        protected WhiteQuotedCB xcreateColumnQueryCB() {
            WhiteQuotedCB cb = new WhiteQuotedCB();
            cb.xsetupForColumnQuery((WhiteQuotedCB)this);
            return cb;
        }

        // [DBFlute-0.8.9.9]
        // ===============================================================================
        //                                                                    OrScopeQuery
        //                                                                    ============
        public void OrScopeQuery(OrQuery<WhiteQuotedCB> orQuery) {
            xorQ((WhiteQuotedCB)this, orQuery);
        }

        // ===============================================================================
        //                                                                    Purpose Type
        //                                                                    ============
        public void xsetupForColumnQuery(WhiteQuotedCB mainCB) {
            xinheritSubQueryInfo(mainCB.LocalCQ);
            //xchangePurposeSqlClause(HpCBPurpose.COLUMN_QUERY);
            _forColumnQuery = true; // old style

            // inherits a parent query to synchronize real name
            // (and also for suppressing query check) 
            Specify().xsetSyncQyCall(new WhiteQuotedCBColQySpQyCall(mainCB));
        }
    }

    public class WhiteQuotedCBColQySpQyCall : HpSpQyCall<WhiteQuotedCQ> {
        protected WhiteQuotedCB _mainCB;
        public WhiteQuotedCBColQySpQyCall(WhiteQuotedCB mainCB) {
            _mainCB = mainCB;
        }
        public bool has() { return true; } 
        public WhiteQuotedCQ qy() { return _mainCB.Query(); } 
    }

    public class WhiteQuotedCBSpecification : AbstractSpecification<WhiteQuotedCQ> {
        public WhiteQuotedCBSpecification(ConditionBean baseCB, HpSpQyCall<WhiteQuotedCQ> qyCall
                                                      , bool forDerivedReferrer, bool forScalarSelect, bool forScalarSubQuery, bool forColumnQuery)
        : base(baseCB, qyCall, forDerivedReferrer, forScalarSelect, forScalarSubQuery, forColumnQuery) { }
        public void ColumnSelect() { doColumn("SELECT"); }
        public void ColumnFrom() { doColumn("FROM"); }
        protected override void doSpecifyRequiredColumn() {
            ColumnSelect(); // PK
        }
        protected override String getTableDbName() { return "white_quoted"; }
    }
}
