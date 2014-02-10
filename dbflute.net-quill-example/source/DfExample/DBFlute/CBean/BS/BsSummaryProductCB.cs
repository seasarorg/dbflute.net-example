
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
    public class BsSummaryProductCB : AbstractConditionBean {

        // ===============================================================================
        //                                                                       Attribute
        //                                                                       =========
        protected SummaryProductCQ _conditionQuery;

        // ===============================================================================
        //                                                                      Table Name
        //                                                                      ==========
        public override String TableDbName { get { return "summary_product"; } }

        // ===============================================================================
        //                                                             PrimaryKey Handling
        //                                                             ===================
        public void AcceptPrimaryKey(int? productId) {
            assertObjectNotNull("productId", productId);
            BsSummaryProductCB cb = this;
            cb.Query().SetProductId_Equal(productId);
        }

        public override ConditionBean AddOrderBy_PK_Asc() {
            Query().AddOrderBy_ProductId_Asc();
            return this;
        }

        public override ConditionBean AddOrderBy_PK_Desc() {
            Query().AddOrderBy_ProductId_Desc();
            return this;
        }

        // ===============================================================================
        //                                                                           Query
        //                                                                           =====
        public SummaryProductCQ Query() {
            return this.ConditionQuery;
        }

        public SummaryProductCQ ConditionQuery {
            get {
                if (_conditionQuery == null) {
                    _conditionQuery = CreateLocalCQ();
                }
                return _conditionQuery;
            }
        }

        protected virtual SummaryProductCQ CreateLocalCQ() {
            return xcreateCQ(null, this.SqlClause, this.SqlClause.getBasePointAliasName(), 0);
        }

        protected virtual SummaryProductCQ xcreateCQ(ConditionQuery childQuery, SqlClause sqlClause, String aliasName, int nestLevel) {
            return new SummaryProductCQ(childQuery, sqlClause, aliasName, nestLevel);
        }

        public override ConditionQuery LocalCQ {
            get { return this.ConditionQuery; }
        }

        // ===============================================================================
        //                                                                           Union
        //                                                                           =====
	    public virtual void Union(UnionQuery<SummaryProductCB> unionQuery) {
            SummaryProductCB cb = new SummaryProductCB();
            cb.xsetupForUnion(this); xsyncUQ(cb); unionQuery.Invoke(cb);
		    SummaryProductCQ cq = cb.Query(); Query().xsetUnionQuery(cq);
        }

	    public virtual void UnionAll(UnionQuery<SummaryProductCB> unionQuery) {
            SummaryProductCB cb = new SummaryProductCB();
            cb.xsetupForUnion(this); xsyncUQ(cb); unionQuery.Invoke(cb);
		    SummaryProductCQ cq = cb.Query(); Query().xsetUnionAllQuery(cq);
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
        protected SummaryProductCBSpecification _specification;
        public SummaryProductCBSpecification Specify() {
            if (_specification == null) { _specification = new SummaryProductCBSpecification(this, new MySpQyCall(this), _forDerivedReferrer, _forScalarSelect, _forScalarCondition, _forColumnQuery); }
            return _specification;
        }
        protected bool HasSpecifiedColumn { get {
            return _specification != null && _specification.IsAlreadySpecifiedRequiredColumn;
        }}
        protected class MySpQyCall : HpSpQyCall<SummaryProductCQ> {
			protected BsSummaryProductCB _myCB;
			public MySpQyCall(BsSummaryProductCB myCB) { _myCB = myCB; }
    		public bool has() { return true; } public SummaryProductCQ qy() { return _myCB.Query(); }
    	}

        // [DBFlute-0.8.9.18]
        // ===============================================================================
        //                                                                     ColumnQuery
        //                                                                     ===========
        public HpColQyOperand<SummaryProductCB> ColumnQuery(SpecifyQuery<SummaryProductCB> leftSpecifyQuery) {
            return new HpColQyOperand<SummaryProductCB>(delegate(SpecifyQuery<SummaryProductCB> rightSp, String operand) {
                xcolqy(xcreateColumnQueryCB(), xcreateColumnQueryCB(), leftSpecifyQuery, rightSp, operand);
            });
        }

        protected SummaryProductCB xcreateColumnQueryCB() {
            SummaryProductCB cb = new SummaryProductCB();
            cb.xsetupForColumnQuery((SummaryProductCB)this);
            return cb;
        }

        // [DBFlute-0.8.9.9]
        // ===============================================================================
        //                                                                    OrScopeQuery
        //                                                                    ============
        public void OrScopeQuery(OrQuery<SummaryProductCB> orQuery) {
            xorQ((SummaryProductCB)this, orQuery);
        }

        // ===============================================================================
        //                                                                    Purpose Type
        //                                                                    ============
        public void xsetupForColumnQuery(SummaryProductCB mainCB) {
            xinheritSubQueryInfo(mainCB.LocalCQ);
            //xchangePurposeSqlClause(HpCBPurpose.COLUMN_QUERY);
            _forColumnQuery = true; // old style

            // inherits a parent query to synchronize real name
            // (and also for suppressing query check) 
            Specify().xsetSyncQyCall(new SummaryProductCBColQySpQyCall(mainCB));
        }
    }

    public class SummaryProductCBColQySpQyCall : HpSpQyCall<SummaryProductCQ> {
        protected SummaryProductCB _mainCB;
        public SummaryProductCBColQySpQyCall(SummaryProductCB mainCB) {
            _mainCB = mainCB;
        }
        public bool has() { return true; } 
        public SummaryProductCQ qy() { return _mainCB.Query(); } 
    }

    public class SummaryProductCBSpecification : AbstractSpecification<SummaryProductCQ> {
        public SummaryProductCBSpecification(ConditionBean baseCB, HpSpQyCall<SummaryProductCQ> qyCall
                                                      , bool forDerivedReferrer, bool forScalarSelect, bool forScalarSubQuery, bool forColumnQuery)
        : base(baseCB, qyCall, forDerivedReferrer, forScalarSelect, forScalarSubQuery, forColumnQuery) { }
        public void ColumnProductId() { doColumn("PRODUCT_ID"); }
        public void ColumnProductName() { doColumn("PRODUCT_NAME"); }
        public void ColumnProductHandleCode() { doColumn("PRODUCT_HANDLE_CODE"); }
        public void ColumnProductStatusCode() { doColumn("PRODUCT_STATUS_CODE"); }
        public void ColumnLatestPurchaseDatetime() { doColumn("LATEST_PURCHASE_DATETIME"); }
        protected override void doSpecifyRequiredColumn() {
            ColumnProductId(); // PK
        }
        protected override String getTableDbName() { return "summary_product"; }
    }
}
