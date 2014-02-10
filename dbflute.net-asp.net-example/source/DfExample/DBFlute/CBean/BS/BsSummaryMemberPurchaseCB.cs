
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
    public class BsSummaryMemberPurchaseCB : AbstractConditionBean {

        // ===============================================================================
        //                                                                       Attribute
        //                                                                       =========
        protected SummaryMemberPurchaseCQ _conditionQuery;

        // ===============================================================================
        //                                                                      Table Name
        //                                                                      ==========
        public override String TableDbName { get { return "SUMMARY_MEMBER_PURCHASE"; } }

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
        public SummaryMemberPurchaseCQ Query() {
            return this.ConditionQuery;
        }

        public SummaryMemberPurchaseCQ ConditionQuery {
            get {
                if (_conditionQuery == null) {
                    _conditionQuery = CreateLocalCQ();
                }
                return _conditionQuery;
            }
        }

        protected virtual SummaryMemberPurchaseCQ CreateLocalCQ() {
            return xcreateCQ(null, this.SqlClause, this.SqlClause.getBasePointAliasName(), 0);
        }

        protected virtual SummaryMemberPurchaseCQ xcreateCQ(ConditionQuery childQuery, SqlClause sqlClause, String aliasName, int nestLevel) {
            return new SummaryMemberPurchaseCQ(childQuery, sqlClause, aliasName, nestLevel);
        }

        public override ConditionQuery LocalCQ {
            get { return this.ConditionQuery; }
        }

        // ===============================================================================
        //                                                                           Union
        //                                                                           =====
	    public virtual void Union(UnionQuery<SummaryMemberPurchaseCB> unionQuery) {
            SummaryMemberPurchaseCB cb = new SummaryMemberPurchaseCB();
            cb.xsetupForUnion(this); xsyncUQ(cb); unionQuery.Invoke(cb);
		    SummaryMemberPurchaseCQ cq = cb.Query(); Query().xsetUnionQuery(cq);
        }

	    public virtual void UnionAll(UnionQuery<SummaryMemberPurchaseCB> unionQuery) {
            SummaryMemberPurchaseCB cb = new SummaryMemberPurchaseCB();
            cb.xsetupForUnion(this); xsyncUQ(cb); unionQuery.Invoke(cb);
		    SummaryMemberPurchaseCQ cq = cb.Query(); Query().xsetUnionAllQuery(cq);
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
        protected SummaryMemberPurchaseCBSpecification _specification;
        public SummaryMemberPurchaseCBSpecification Specify() {
            if (_specification == null) { _specification = new SummaryMemberPurchaseCBSpecification(this, new MySpQyCall(this), _forDerivedReferrer, _forScalarSelect, _forScalarCondition, _forColumnQuery); }
            return _specification;
        }
        protected bool HasSpecifiedColumn { get {
            return _specification != null && _specification.IsAlreadySpecifiedRequiredColumn;
        }}
        protected class MySpQyCall : HpSpQyCall<SummaryMemberPurchaseCQ> {
			protected BsSummaryMemberPurchaseCB _myCB;
			public MySpQyCall(BsSummaryMemberPurchaseCB myCB) { _myCB = myCB; }
    		public bool has() { return true; } public SummaryMemberPurchaseCQ qy() { return _myCB.Query(); }
    	}

        // [DBFlute-0.8.9.18]
        // ===============================================================================
        //                                                                     ColumnQuery
        //                                                                     ===========
        public HpColQyOperand<SummaryMemberPurchaseCB> ColumnQuery(SpecifyQuery<SummaryMemberPurchaseCB> leftSpecifyQuery) {
            return new HpColQyOperand<SummaryMemberPurchaseCB>(delegate(SpecifyQuery<SummaryMemberPurchaseCB> rightSp, String operand) {
                xcolqy(xcreateColumnQueryCB(), xcreateColumnQueryCB(), leftSpecifyQuery, rightSp, operand);
            });
        }

        protected SummaryMemberPurchaseCB xcreateColumnQueryCB() {
            SummaryMemberPurchaseCB cb = new SummaryMemberPurchaseCB();
            cb.xsetupForColumnQuery((SummaryMemberPurchaseCB)this);
            return cb;
        }

        // [DBFlute-0.8.9.9]
        // ===============================================================================
        //                                                                    OrScopeQuery
        //                                                                    ============
        public void OrScopeQuery(OrQuery<SummaryMemberPurchaseCB> orQuery) {
            xorQ((SummaryMemberPurchaseCB)this, orQuery);
        }

        // ===============================================================================
        //                                                                    Purpose Type
        //                                                                    ============
        public void xsetupForColumnQuery(SummaryMemberPurchaseCB mainCB) {
            xinheritSubQueryInfo(mainCB.LocalCQ);
            //xchangePurposeSqlClause(HpCBPurpose.COLUMN_QUERY);
            _forColumnQuery = true; // old style

            // inherits a parent query to synchronize real name
            // (and also for suppressing query check) 
            Specify().xsetSyncQyCall(new SummaryMemberPurchaseCBColQySpQyCall(mainCB));
        }
    }

    public class SummaryMemberPurchaseCBColQySpQyCall : HpSpQyCall<SummaryMemberPurchaseCQ> {
        protected SummaryMemberPurchaseCB _mainCB;
        public SummaryMemberPurchaseCBColQySpQyCall(SummaryMemberPurchaseCB mainCB) {
            _mainCB = mainCB;
        }
        public bool has() { return true; } 
        public SummaryMemberPurchaseCQ qy() { return _mainCB.Query(); } 
    }

    public class SummaryMemberPurchaseCBSpecification : AbstractSpecification<SummaryMemberPurchaseCQ> {
        public SummaryMemberPurchaseCBSpecification(ConditionBean baseCB, HpSpQyCall<SummaryMemberPurchaseCQ> qyCall
                                                      , bool forDerivedReferrer, bool forScalarSelect, bool forScalarSubQuery, bool forColumnQuery)
        : base(baseCB, qyCall, forDerivedReferrer, forScalarSelect, forScalarSubQuery, forColumnQuery) { }
        public void ColumnMemberId() { doColumn("MEMBER_ID"); }
        public void ColumnAllsumPurchasePrice() { doColumn("ALLSUM_PURCHASE_PRICE"); }
        public void ColumnLatestPurchaseDatetime() { doColumn("LATEST_PURCHASE_DATETIME"); }
        protected override void doSpecifyRequiredColumn() {
        }
        protected override String getTableDbName() { return "SUMMARY_MEMBER_PURCHASE"; }
    }
}
