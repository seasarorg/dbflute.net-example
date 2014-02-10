
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
    public class BsProductCB : AbstractConditionBean {

        // ===============================================================================
        //                                                                       Attribute
        //                                                                       =========
        protected ProductCQ _conditionQuery;

        // ===============================================================================
        //                                                                      Table Name
        //                                                                      ==========
        public override String TableDbName { get { return "PRODUCT"; } }

        // ===============================================================================
        //                                                             PrimaryKey Handling
        //                                                             ===================
        public void AcceptPrimaryKey(long? productId) {
            assertObjectNotNull("productId", productId);
            BsProductCB cb = this;
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
        public ProductCQ Query() {
            return this.ConditionQuery;
        }

        public ProductCQ ConditionQuery {
            get {
                if (_conditionQuery == null) {
                    _conditionQuery = CreateLocalCQ();
                }
                return _conditionQuery;
            }
        }

        protected virtual ProductCQ CreateLocalCQ() {
            return xcreateCQ(null, this.SqlClause, this.SqlClause.getBasePointAliasName(), 0);
        }

        protected virtual ProductCQ xcreateCQ(ConditionQuery childQuery, SqlClause sqlClause, String aliasName, int nestLevel) {
            return new ProductCQ(childQuery, sqlClause, aliasName, nestLevel);
        }

        public override ConditionQuery LocalCQ {
            get { return this.ConditionQuery; }
        }

        // ===============================================================================
        //                                                                           Union
        //                                                                           =====
	    public virtual void Union(UnionQuery<ProductCB> unionQuery) {
            ProductCB cb = new ProductCB();
            cb.xsetupForUnion(this); xsyncUQ(cb); unionQuery.Invoke(cb);
		    ProductCQ cq = cb.Query(); Query().xsetUnionQuery(cq);
        }

	    public virtual void UnionAll(UnionQuery<ProductCB> unionQuery) {
            ProductCB cb = new ProductCB();
            cb.xsetupForUnion(this); xsyncUQ(cb); unionQuery.Invoke(cb);
		    ProductCQ cq = cb.Query(); Query().xsetUnionAllQuery(cq);
	    }

        public override bool HasUnionQueryOrUnionAllQuery() {
            return Query().hasUnionQueryOrUnionAllQuery();
        }

        // ===============================================================================
        //                                                                    Setup Select
        //                                                                    ============
        protected ProductStatusNss _nssProductStatus;
        public ProductStatusNss NssProductStatus { get {
            if (_nssProductStatus == null) { _nssProductStatus = new ProductStatusNss(null); }
            return _nssProductStatus;
        }}
        public ProductStatusNss SetupSelect_ProductStatus() {
            if (HasSpecifiedColumn) { // if reverse call
                Specify().ColumnProductStatusCode();
            }
            doSetupSelect(delegate { return Query().QueryProductStatus(); });
            if (_nssProductStatus == null || !_nssProductStatus.HasConditionQuery)
            { _nssProductStatus = new ProductStatusNss(Query().QueryProductStatus()); }
            return _nssProductStatus;
        }

        // [DBFlute-0.7.4]
        // ===============================================================================
        //                                                                         Specify
        //                                                                         =======
        protected ProductCBSpecification _specification;
        public ProductCBSpecification Specify() {
            if (_specification == null) { _specification = new ProductCBSpecification(this, new MySpQyCall(this), _forDerivedReferrer, _forScalarSelect, _forScalarCondition, _forColumnQuery); }
            return _specification;
        }
        protected bool HasSpecifiedColumn { get {
            return _specification != null && _specification.IsAlreadySpecifiedRequiredColumn;
        }}
        protected class MySpQyCall : HpSpQyCall<ProductCQ> {
			protected BsProductCB _myCB;
			public MySpQyCall(BsProductCB myCB) { _myCB = myCB; }
    		public bool has() { return true; } public ProductCQ qy() { return _myCB.Query(); }
    	}

        // [DBFlute-0.8.9.18]
        // ===============================================================================
        //                                                                     ColumnQuery
        //                                                                     ===========
        public HpColQyOperand<ProductCB> ColumnQuery(SpecifyQuery<ProductCB> leftSpecifyQuery) {
            return new HpColQyOperand<ProductCB>(delegate(SpecifyQuery<ProductCB> rightSp, String operand) {
                xcolqy(xcreateColumnQueryCB(), xcreateColumnQueryCB(), leftSpecifyQuery, rightSp, operand);
            });
        }

        protected ProductCB xcreateColumnQueryCB() {
            ProductCB cb = new ProductCB();
            cb.xsetupForColumnQuery((ProductCB)this);
            return cb;
        }

        // [DBFlute-0.8.9.9]
        // ===============================================================================
        //                                                                    OrScopeQuery
        //                                                                    ============
        public void OrScopeQuery(OrQuery<ProductCB> orQuery) {
            xorQ((ProductCB)this, orQuery);
        }

        // ===============================================================================
        //                                                                    Purpose Type
        //                                                                    ============
        public void xsetupForColumnQuery(ProductCB mainCB) {
            xinheritSubQueryInfo(mainCB.LocalCQ);
            //xchangePurposeSqlClause(HpCBPurpose.COLUMN_QUERY);
            _forColumnQuery = true; // old style

            // inherits a parent query to synchronize real name
            // (and also for suppressing query check) 
            Specify().xsetSyncQyCall(new ProductCBColQySpQyCall(mainCB));
        }
    }

    public class ProductCBColQySpQyCall : HpSpQyCall<ProductCQ> {
        protected ProductCB _mainCB;
        public ProductCBColQySpQyCall(ProductCB mainCB) {
            _mainCB = mainCB;
        }
        public bool has() { return true; } 
        public ProductCQ qy() { return _mainCB.Query(); } 
    }

    public class ProductCBSpecification : AbstractSpecification<ProductCQ> {
        protected ProductStatusCBSpecification _productStatus;
        public ProductCBSpecification(ConditionBean baseCB, HpSpQyCall<ProductCQ> qyCall
                                                      , bool forDerivedReferrer, bool forScalarSelect, bool forScalarSubQuery, bool forColumnQuery)
        : base(baseCB, qyCall, forDerivedReferrer, forScalarSelect, forScalarSubQuery, forColumnQuery) { }
        public void ColumnProductId() { doColumn("PRODUCT_ID"); }
        public void ColumnProductName() { doColumn("PRODUCT_NAME"); }
        public void ColumnProductHandleCode() { doColumn("PRODUCT_HANDLE_CODE"); }
        public void ColumnProductStatusCode() { doColumn("PRODUCT_STATUS_CODE"); }
        public void ColumnRegisterDatetime() { doColumn("REGISTER_DATETIME"); }
        public void ColumnRegisterUser() { doColumn("REGISTER_USER"); }
        public void ColumnRegisterProcess() { doColumn("REGISTER_PROCESS"); }
        public void ColumnUpdateDatetime() { doColumn("UPDATE_DATETIME"); }
        public void ColumnUpdateUser() { doColumn("UPDATE_USER"); }
        public void ColumnUpdateProcess() { doColumn("UPDATE_PROCESS"); }
        public void ColumnVersionNo() { doColumn("VERSION_NO"); }
        protected override void doSpecifyRequiredColumn() {
            ColumnProductId(); // PK
            if (qyCall().qy().hasConditionQueryProductStatus()
                    || qyCall().qy().xgetReferrerQuery() is ProductStatusCQ) {
                ColumnProductStatusCode(); // FK or one-to-one referrer
            }
        }
        protected override String getTableDbName() { return "PRODUCT"; }
        public ProductStatusCBSpecification SpecifyProductStatus() {
            assertForeign("productStatus");
            if (_productStatus == null) {
                _productStatus = new ProductStatusCBSpecification(_baseCB, new ProductStatusSpQyCall(_qyCall), _forDerivedReferrer, _forScalarSelect, _forScalarCondition, _forColumnQuery);
                if (xhasSyncQyCall()) // inherits it
                { _productStatus.xsetSyncQyCall(new ProductStatusSpQyCall(xsyncQyCall())); }
            }
            return _productStatus;
        }
		public class ProductStatusSpQyCall : HpSpQyCall<ProductStatusCQ> {
		    protected HpSpQyCall<ProductCQ> _qyCall;
		    public ProductStatusSpQyCall(HpSpQyCall<ProductCQ> myQyCall) { _qyCall = myQyCall; }
		    public bool has() { return _qyCall.has() && _qyCall.qy().hasConditionQueryProductStatus(); }
			public ProductStatusCQ qy() { return _qyCall.qy().QueryProductStatus(); }
		}
        public RAFunction<PurchaseCB, ProductCQ> DerivedPurchaseList() {
            if (xhasSyncQyCall()) { xsyncQyCall().qy(); } // for sync (for example, this in ColumnQuery)
            return new RAFunction<PurchaseCB, ProductCQ>(_baseCB, _qyCall.qy(), delegate(String function, SubQuery<PurchaseCB> subQuery, ProductCQ cq, String aliasName)
                { cq.xsderivePurchaseList(function, subQuery, aliasName); });
        }
    }
}
