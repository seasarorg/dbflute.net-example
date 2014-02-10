
using System;
using System.Collections;

using DfExample.DBFlute.MemberDb.AllCommon;
using DfExample.DBFlute.MemberDb.AllCommon.CBean;
using DfExample.DBFlute.MemberDb.AllCommon.CBean.SClause;
using DfExample.DBFlute.MemberDb.AllCommon.Helper;

using DfExample.DBFlute.MemberDb.CBean;
using DfExample.DBFlute.MemberDb.CBean.CQ;
using DfExample.DBFlute.MemberDb.CBean.Nss;

namespace DfExample.DBFlute.MemberDb.CBean.BS {

    [System.Serializable]
    public class MbBsProductCB : MbAbstractConditionBean {

        // ===============================================================================
        //                                                                       Attribute
        //                                                                       =========
        protected MbProductCQ _conditionQuery;

        // ===============================================================================
        //                                                                      Table Name
        //                                                                      ==========
        public override String TableDbName { get { return "product"; } }

        // ===============================================================================
        //                                                             PrimaryKey Handling
        //                                                             ===================
        public void AcceptPrimaryKey(int? productId) {
            assertObjectNotNull("productId", productId);
            MbBsProductCB cb = this;
            cb.Query().SetProductId_Equal(productId);
        }

        public override MbConditionBean AddOrderBy_PK_Asc() {
            Query().AddOrderBy_ProductId_Asc();
            return this;
        }

        public override MbConditionBean AddOrderBy_PK_Desc() {
            Query().AddOrderBy_ProductId_Desc();
            return this;
        }

        // ===============================================================================
        //                                                                           Query
        //                                                                           =====
        public MbProductCQ Query() {
            return this.ConditionQuery;
        }

        public MbProductCQ ConditionQuery {
            get {
                if (_conditionQuery == null) {
                    _conditionQuery = CreateLocalCQ();
                }
                return _conditionQuery;
            }
        }

        protected virtual MbProductCQ CreateLocalCQ() {
            return xcreateCQ(null, this.SqlClause, this.SqlClause.getBasePointAliasName(), 0);
        }

        protected virtual MbProductCQ xcreateCQ(MbConditionQuery childQuery, MbSqlClause sqlClause, String aliasName, int nestLevel) {
            return new MbProductCQ(childQuery, sqlClause, aliasName, nestLevel);
        }

        public override MbConditionQuery LocalCQ {
            get { return this.ConditionQuery; }
        }

        // ===============================================================================
        //                                                                           Union
        //                                                                           =====
	    public virtual void Union(MbUnionQuery<MbProductCB> unionQuery) {
            MbProductCB cb = new MbProductCB();
            cb.xsetupForUnion(this); xsyncUQ(cb); unionQuery.Invoke(cb);
		    MbProductCQ cq = cb.Query(); Query().xsetUnionQuery(cq);
        }

	    public virtual void UnionAll(MbUnionQuery<MbProductCB> unionQuery) {
            MbProductCB cb = new MbProductCB();
            cb.xsetupForUnion(this); xsyncUQ(cb); unionQuery.Invoke(cb);
		    MbProductCQ cq = cb.Query(); Query().xsetUnionAllQuery(cq);
	    }

        public override bool HasUnionQueryOrUnionAllQuery() {
            return Query().hasUnionQueryOrUnionAllQuery();
        }

        // ===============================================================================
        //                                                                    Setup Select
        //                                                                    ============
        protected MbProductStatusNss _nssProductStatus;
        public MbProductStatusNss NssProductStatus { get {
            if (_nssProductStatus == null) { _nssProductStatus = new MbProductStatusNss(null); }
            return _nssProductStatus;
        }}
        public MbProductStatusNss SetupSelect_ProductStatus() {
            if (HasSpecifiedColumn) { // if reverse call
                Specify().ColumnProductStatusCode();
            }
            doSetupSelect(delegate { return Query().QueryProductStatus(); });
            if (_nssProductStatus == null || !_nssProductStatus.HasConditionQuery)
            { _nssProductStatus = new MbProductStatusNss(Query().QueryProductStatus()); }
            return _nssProductStatus;
        }

        // [DBFlute-0.7.4]
        // ===============================================================================
        //                                                                         Specify
        //                                                                         =======
        protected MbProductCBSpecification _specification;
        public MbProductCBSpecification Specify() {
            if (_specification == null) { _specification = new MbProductCBSpecification(this, new MySpQyCall(this), _forDerivedReferrer, _forScalarSelect, _forScalarCondition, _forColumnQuery); }
            return _specification;
        }
        protected bool HasSpecifiedColumn { get {
            return _specification != null && _specification.IsAlreadySpecifiedRequiredColumn;
        }}
        protected class MySpQyCall : HpSpQyCall<MbProductCQ> {
			protected MbBsProductCB _myCB;
			public MySpQyCall(MbBsProductCB myCB) { _myCB = myCB; }
    		public bool has() { return true; } public MbProductCQ qy() { return _myCB.Query(); }
    	}

        // [DBFlute-0.8.9.18]
        // ===============================================================================
        //                                                                     ColumnQuery
        //                                                                     ===========
        public HpColQyOperand<MbProductCB> ColumnQuery(MbSpecifyQuery<MbProductCB> leftSpecifyQuery) {
            return new HpColQyOperand<MbProductCB>(delegate(MbSpecifyQuery<MbProductCB> rightSp, String operand) {
                xcolqy(xcreateColumnQueryCB(), xcreateColumnQueryCB(), leftSpecifyQuery, rightSp, operand);
            });
        }

        protected MbProductCB xcreateColumnQueryCB() {
            MbProductCB cb = new MbProductCB();
            cb.xsetupForColumnQuery((MbProductCB)this);
            return cb;
        }

        // [DBFlute-0.8.9.9]
        // ===============================================================================
        //                                                                    OrScopeQuery
        //                                                                    ============
        public void OrScopeQuery(MbOrQuery<MbProductCB> orQuery) {
            xorQ((MbProductCB)this, orQuery);
        }

        // ===============================================================================
        //                                                                    Purpose Type
        //                                                                    ============
        public void xsetupForColumnQuery(MbProductCB mainCB) {
            xinheritSubQueryInfo(mainCB.LocalCQ);
            //xchangePurposeSqlClause(HpCBPurpose.COLUMN_QUERY);
            _forColumnQuery = true; // old style

            // inherits a parent query to synchronize real name
            // (and also for suppressing query check) 
            Specify().xsetSyncQyCall(new MbProductCBColQySpQyCall(mainCB));
        }
    }

    public class MbProductCBColQySpQyCall : HpSpQyCall<MbProductCQ> {
        protected MbProductCB _mainCB;
        public MbProductCBColQySpQyCall(MbProductCB mainCB) {
            _mainCB = mainCB;
        }
        public bool has() { return true; } 
        public MbProductCQ qy() { return _mainCB.Query(); } 
    }

    public class MbProductCBSpecification : AbstractSpecification<MbProductCQ> {
        protected MbProductStatusCBSpecification _productStatus;
        public MbProductCBSpecification(MbConditionBean baseCB, HpSpQyCall<MbProductCQ> qyCall
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
                    || qyCall().qy().xgetReferrerQuery() is MbProductStatusCQ) {
                ColumnProductStatusCode(); // FK or one-to-one referrer
            }
        }
        protected override String getTableDbName() { return "product"; }
        public MbProductStatusCBSpecification SpecifyProductStatus() {
            assertForeign("productStatus");
            if (_productStatus == null) {
                _productStatus = new MbProductStatusCBSpecification(_baseCB, new ProductStatusSpQyCall(_qyCall), _forDerivedReferrer, _forScalarSelect, _forScalarCondition, _forColumnQuery);
                if (xhasSyncQyCall()) // inherits it
                { _productStatus.xsetSyncQyCall(new ProductStatusSpQyCall(xsyncQyCall())); }
            }
            return _productStatus;
        }
		public class ProductStatusSpQyCall : HpSpQyCall<MbProductStatusCQ> {
		    protected HpSpQyCall<MbProductCQ> _qyCall;
		    public ProductStatusSpQyCall(HpSpQyCall<MbProductCQ> myQyCall) { _qyCall = myQyCall; }
		    public bool has() { return _qyCall.has() && _qyCall.qy().hasConditionQueryProductStatus(); }
			public MbProductStatusCQ qy() { return _qyCall.qy().QueryProductStatus(); }
		}
        public RAFunction<MbPurchaseCB, MbProductCQ> DerivedPurchaseList() {
            if (xhasSyncQyCall()) { xsyncQyCall().qy(); } // for sync (for example, this in ColumnQuery)
            return new RAFunction<MbPurchaseCB, MbProductCQ>(_baseCB, _qyCall.qy(), delegate(String function, MbSubQuery<MbPurchaseCB> subQuery, MbProductCQ cq, String aliasName)
                { cq.xsderivePurchaseList(function, subQuery, aliasName); });
        }
    }
}
