
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
    public class BsProductStatusCB : AbstractConditionBean {

        // ===============================================================================
        //                                                                       Attribute
        //                                                                       =========
        protected ProductStatusCQ _conditionQuery;

        // ===============================================================================
        //                                                                      Table Name
        //                                                                      ==========
        public override String TableDbName { get { return "PRODUCT_STATUS"; } }

        // ===============================================================================
        //                                                             PrimaryKey Handling
        //                                                             ===================
        public void AcceptPrimaryKey(String productStatusCode) {
            assertObjectNotNull("productStatusCode", productStatusCode);
            BsProductStatusCB cb = this;
            cb.Query().SetProductStatusCode_Equal(productStatusCode);
        }

        public override ConditionBean AddOrderBy_PK_Asc() {
            Query().AddOrderBy_ProductStatusCode_Asc();
            return this;
        }

        public override ConditionBean AddOrderBy_PK_Desc() {
            Query().AddOrderBy_ProductStatusCode_Desc();
            return this;
        }

        // ===============================================================================
        //                                                                           Query
        //                                                                           =====
        public ProductStatusCQ Query() {
            return this.ConditionQuery;
        }

        public ProductStatusCQ ConditionQuery {
            get {
                if (_conditionQuery == null) {
                    _conditionQuery = CreateLocalCQ();
                }
                return _conditionQuery;
            }
        }

        protected virtual ProductStatusCQ CreateLocalCQ() {
            return xcreateCQ(null, this.SqlClause, this.SqlClause.getBasePointAliasName(), 0);
        }

        protected virtual ProductStatusCQ xcreateCQ(ConditionQuery childQuery, SqlClause sqlClause, String aliasName, int nestLevel) {
            return new ProductStatusCQ(childQuery, sqlClause, aliasName, nestLevel);
        }

        public override ConditionQuery LocalCQ {
            get { return this.ConditionQuery; }
        }

        // ===============================================================================
        //                                                                           Union
        //                                                                           =====
	    public virtual void Union(UnionQuery<ProductStatusCB> unionQuery) {
            ProductStatusCB cb = new ProductStatusCB();
            cb.xsetupForUnion(this); xsyncUQ(cb); unionQuery.Invoke(cb);
		    ProductStatusCQ cq = cb.Query(); Query().xsetUnionQuery(cq);
        }

	    public virtual void UnionAll(UnionQuery<ProductStatusCB> unionQuery) {
            ProductStatusCB cb = new ProductStatusCB();
            cb.xsetupForUnion(this); xsyncUQ(cb); unionQuery.Invoke(cb);
		    ProductStatusCQ cq = cb.Query(); Query().xsetUnionAllQuery(cq);
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
        protected ProductStatusCBSpecification _specification;
        public ProductStatusCBSpecification Specify() {
            if (_specification == null) { _specification = new ProductStatusCBSpecification(this, new MySpQyCall(this), _forDerivedReferrer, _forScalarSelect, _forScalarCondition, _forColumnQuery); }
            return _specification;
        }
        protected bool HasSpecifiedColumn { get {
            return _specification != null && _specification.IsAlreadySpecifiedRequiredColumn;
        }}
        protected class MySpQyCall : HpSpQyCall<ProductStatusCQ> {
			protected BsProductStatusCB _myCB;
			public MySpQyCall(BsProductStatusCB myCB) { _myCB = myCB; }
    		public bool has() { return true; } public ProductStatusCQ qy() { return _myCB.Query(); }
    	}

        // [DBFlute-0.8.9.18]
        // ===============================================================================
        //                                                                     ColumnQuery
        //                                                                     ===========
        public HpColQyOperand<ProductStatusCB> ColumnQuery(SpecifyQuery<ProductStatusCB> leftSpecifyQuery) {
            return new HpColQyOperand<ProductStatusCB>(delegate(SpecifyQuery<ProductStatusCB> rightSp, String operand) {
                xcolqy(xcreateColumnQueryCB(), xcreateColumnQueryCB(), leftSpecifyQuery, rightSp, operand);
            });
        }

        protected ProductStatusCB xcreateColumnQueryCB() {
            ProductStatusCB cb = new ProductStatusCB();
            cb.xsetupForColumnQuery((ProductStatusCB)this);
            return cb;
        }

        // [DBFlute-0.8.9.9]
        // ===============================================================================
        //                                                                    OrScopeQuery
        //                                                                    ============
        public void OrScopeQuery(OrQuery<ProductStatusCB> orQuery) {
            xorQ((ProductStatusCB)this, orQuery);
        }

        // ===============================================================================
        //                                                                    Purpose Type
        //                                                                    ============
        public void xsetupForColumnQuery(ProductStatusCB mainCB) {
            xinheritSubQueryInfo(mainCB.LocalCQ);
            //xchangePurposeSqlClause(HpCBPurpose.COLUMN_QUERY);
            _forColumnQuery = true; // old style

            // inherits a parent query to synchronize real name
            // (and also for suppressing query check) 
            Specify().xsetSyncQyCall(new ProductStatusCBColQySpQyCall(mainCB));
        }
    }

    public class ProductStatusCBColQySpQyCall : HpSpQyCall<ProductStatusCQ> {
        protected ProductStatusCB _mainCB;
        public ProductStatusCBColQySpQyCall(ProductStatusCB mainCB) {
            _mainCB = mainCB;
        }
        public bool has() { return true; } 
        public ProductStatusCQ qy() { return _mainCB.Query(); } 
    }

    public class ProductStatusCBSpecification : AbstractSpecification<ProductStatusCQ> {
        public ProductStatusCBSpecification(ConditionBean baseCB, HpSpQyCall<ProductStatusCQ> qyCall
                                                      , bool forDerivedReferrer, bool forScalarSelect, bool forScalarSubQuery, bool forColumnQuery)
        : base(baseCB, qyCall, forDerivedReferrer, forScalarSelect, forScalarSubQuery, forColumnQuery) { }
        public void ColumnProductStatusCode() { doColumn("PRODUCT_STATUS_CODE"); }
        public void ColumnProductStatusName() { doColumn("PRODUCT_STATUS_NAME"); }
        protected override void doSpecifyRequiredColumn() {
            ColumnProductStatusCode(); // PK
        }
        protected override String getTableDbName() { return "PRODUCT_STATUS"; }
        public RAFunction<ProductCB, ProductStatusCQ> DerivedProductList() {
            if (xhasSyncQyCall()) { xsyncQyCall().qy(); } // for sync (for example, this in ColumnQuery)
            return new RAFunction<ProductCB, ProductStatusCQ>(_baseCB, _qyCall.qy(), delegate(String function, SubQuery<ProductCB> subQuery, ProductStatusCQ cq, String aliasName)
                { cq.xsderiveProductList(function, subQuery, aliasName); });
        }
    }
}
