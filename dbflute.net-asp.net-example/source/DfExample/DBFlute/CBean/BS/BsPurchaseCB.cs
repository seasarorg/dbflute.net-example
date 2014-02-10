
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
    public class BsPurchaseCB : AbstractConditionBean {

        // ===============================================================================
        //                                                                       Attribute
        //                                                                       =========
        protected PurchaseCQ _conditionQuery;

        // ===============================================================================
        //                                                                      Table Name
        //                                                                      ==========
        public override String TableDbName { get { return "PURCHASE"; } }

        // ===============================================================================
        //                                                             PrimaryKey Handling
        //                                                             ===================
        public void AcceptPrimaryKey(long? purchaseId) {
            assertObjectNotNull("purchaseId", purchaseId);
            BsPurchaseCB cb = this;
            cb.Query().SetPurchaseId_Equal(purchaseId);
        }

        public override ConditionBean AddOrderBy_PK_Asc() {
            Query().AddOrderBy_PurchaseId_Asc();
            return this;
        }

        public override ConditionBean AddOrderBy_PK_Desc() {
            Query().AddOrderBy_PurchaseId_Desc();
            return this;
        }

        // ===============================================================================
        //                                                                           Query
        //                                                                           =====
        public PurchaseCQ Query() {
            return this.ConditionQuery;
        }

        public PurchaseCQ ConditionQuery {
            get {
                if (_conditionQuery == null) {
                    _conditionQuery = CreateLocalCQ();
                }
                return _conditionQuery;
            }
        }

        protected virtual PurchaseCQ CreateLocalCQ() {
            return xcreateCQ(null, this.SqlClause, this.SqlClause.getBasePointAliasName(), 0);
        }

        protected virtual PurchaseCQ xcreateCQ(ConditionQuery childQuery, SqlClause sqlClause, String aliasName, int nestLevel) {
            return new PurchaseCQ(childQuery, sqlClause, aliasName, nestLevel);
        }

        public override ConditionQuery LocalCQ {
            get { return this.ConditionQuery; }
        }

        // ===============================================================================
        //                                                                           Union
        //                                                                           =====
	    public virtual void Union(UnionQuery<PurchaseCB> unionQuery) {
            PurchaseCB cb = new PurchaseCB();
            cb.xsetupForUnion(this); xsyncUQ(cb); unionQuery.Invoke(cb);
		    PurchaseCQ cq = cb.Query(); Query().xsetUnionQuery(cq);
        }

	    public virtual void UnionAll(UnionQuery<PurchaseCB> unionQuery) {
            PurchaseCB cb = new PurchaseCB();
            cb.xsetupForUnion(this); xsyncUQ(cb); unionQuery.Invoke(cb);
		    PurchaseCQ cq = cb.Query(); Query().xsetUnionAllQuery(cq);
	    }

        public override bool HasUnionQueryOrUnionAllQuery() {
            return Query().hasUnionQueryOrUnionAllQuery();
        }

        // ===============================================================================
        //                                                                    Setup Select
        //                                                                    ============
        protected MemberNss _nssMember;
        public MemberNss NssMember { get {
            if (_nssMember == null) { _nssMember = new MemberNss(null); }
            return _nssMember;
        }}
        public MemberNss SetupSelect_Member() {
            if (HasSpecifiedColumn) { // if reverse call
                Specify().ColumnMemberId();
            }
            doSetupSelect(delegate { return Query().QueryMember(); });
            if (_nssMember == null || !_nssMember.HasConditionQuery)
            { _nssMember = new MemberNss(Query().QueryMember()); }
            return _nssMember;
        }
        protected ProductNss _nssProduct;
        public ProductNss NssProduct { get {
            if (_nssProduct == null) { _nssProduct = new ProductNss(null); }
            return _nssProduct;
        }}
        public ProductNss SetupSelect_Product() {
            if (HasSpecifiedColumn) { // if reverse call
                Specify().ColumnProductId();
            }
            doSetupSelect(delegate { return Query().QueryProduct(); });
            if (_nssProduct == null || !_nssProduct.HasConditionQuery)
            { _nssProduct = new ProductNss(Query().QueryProduct()); }
            return _nssProduct;
        }

        // [DBFlute-0.7.4]
        // ===============================================================================
        //                                                                         Specify
        //                                                                         =======
        protected PurchaseCBSpecification _specification;
        public PurchaseCBSpecification Specify() {
            if (_specification == null) { _specification = new PurchaseCBSpecification(this, new MySpQyCall(this), _forDerivedReferrer, _forScalarSelect, _forScalarCondition, _forColumnQuery); }
            return _specification;
        }
        protected bool HasSpecifiedColumn { get {
            return _specification != null && _specification.IsAlreadySpecifiedRequiredColumn;
        }}
        protected class MySpQyCall : HpSpQyCall<PurchaseCQ> {
			protected BsPurchaseCB _myCB;
			public MySpQyCall(BsPurchaseCB myCB) { _myCB = myCB; }
    		public bool has() { return true; } public PurchaseCQ qy() { return _myCB.Query(); }
    	}

        // [DBFlute-0.8.9.18]
        // ===============================================================================
        //                                                                     ColumnQuery
        //                                                                     ===========
        public HpColQyOperand<PurchaseCB> ColumnQuery(SpecifyQuery<PurchaseCB> leftSpecifyQuery) {
            return new HpColQyOperand<PurchaseCB>(delegate(SpecifyQuery<PurchaseCB> rightSp, String operand) {
                xcolqy(xcreateColumnQueryCB(), xcreateColumnQueryCB(), leftSpecifyQuery, rightSp, operand);
            });
        }

        protected PurchaseCB xcreateColumnQueryCB() {
            PurchaseCB cb = new PurchaseCB();
            cb.xsetupForColumnQuery((PurchaseCB)this);
            return cb;
        }

        // [DBFlute-0.8.9.9]
        // ===============================================================================
        //                                                                    OrScopeQuery
        //                                                                    ============
        public void OrScopeQuery(OrQuery<PurchaseCB> orQuery) {
            xorQ((PurchaseCB)this, orQuery);
        }

        // ===============================================================================
        //                                                                    Purpose Type
        //                                                                    ============
        public void xsetupForColumnQuery(PurchaseCB mainCB) {
            xinheritSubQueryInfo(mainCB.LocalCQ);
            //xchangePurposeSqlClause(HpCBPurpose.COLUMN_QUERY);
            _forColumnQuery = true; // old style

            // inherits a parent query to synchronize real name
            // (and also for suppressing query check) 
            Specify().xsetSyncQyCall(new PurchaseCBColQySpQyCall(mainCB));
        }
    }

    public class PurchaseCBColQySpQyCall : HpSpQyCall<PurchaseCQ> {
        protected PurchaseCB _mainCB;
        public PurchaseCBColQySpQyCall(PurchaseCB mainCB) {
            _mainCB = mainCB;
        }
        public bool has() { return true; } 
        public PurchaseCQ qy() { return _mainCB.Query(); } 
    }

    public class PurchaseCBSpecification : AbstractSpecification<PurchaseCQ> {
        protected MemberCBSpecification _member;
        protected ProductCBSpecification _product;
        public PurchaseCBSpecification(ConditionBean baseCB, HpSpQyCall<PurchaseCQ> qyCall
                                                      , bool forDerivedReferrer, bool forScalarSelect, bool forScalarSubQuery, bool forColumnQuery)
        : base(baseCB, qyCall, forDerivedReferrer, forScalarSelect, forScalarSubQuery, forColumnQuery) { }
        public void ColumnPurchaseId() { doColumn("PURCHASE_ID"); }
        public void ColumnMemberId() { doColumn("MEMBER_ID"); }
        public void ColumnProductId() { doColumn("PRODUCT_ID"); }
        public void ColumnPurchaseDatetime() { doColumn("PURCHASE_DATETIME"); }
        public void ColumnPurchaseCount() { doColumn("PURCHASE_COUNT"); }
        public void ColumnPurchasePrice() { doColumn("PURCHASE_PRICE"); }
        public void ColumnPaymentCompleteFlg() { doColumn("PAYMENT_COMPLETE_FLG"); }
        public void ColumnRegisterDatetime() { doColumn("REGISTER_DATETIME"); }
        public void ColumnRegisterUser() { doColumn("REGISTER_USER"); }
        public void ColumnRegisterProcess() { doColumn("REGISTER_PROCESS"); }
        public void ColumnUpdateDatetime() { doColumn("UPDATE_DATETIME"); }
        public void ColumnUpdateUser() { doColumn("UPDATE_USER"); }
        public void ColumnUpdateProcess() { doColumn("UPDATE_PROCESS"); }
        public void ColumnVersionNo() { doColumn("VERSION_NO"); }
        protected override void doSpecifyRequiredColumn() {
            ColumnPurchaseId(); // PK
            if (qyCall().qy().hasConditionQueryMember()
                    || qyCall().qy().xgetReferrerQuery() is MemberCQ) {
                ColumnMemberId(); // FK or one-to-one referrer
            }
            if (qyCall().qy().hasConditionQueryProduct()
                    || qyCall().qy().xgetReferrerQuery() is ProductCQ) {
                ColumnProductId(); // FK or one-to-one referrer
            }
        }
        protected override String getTableDbName() { return "PURCHASE"; }
        public MemberCBSpecification SpecifyMember() {
            assertForeign("member");
            if (_member == null) {
                _member = new MemberCBSpecification(_baseCB, new MemberSpQyCall(_qyCall), _forDerivedReferrer, _forScalarSelect, _forScalarCondition, _forColumnQuery);
                if (xhasSyncQyCall()) // inherits it
                { _member.xsetSyncQyCall(new MemberSpQyCall(xsyncQyCall())); }
            }
            return _member;
        }
		public class MemberSpQyCall : HpSpQyCall<MemberCQ> {
		    protected HpSpQyCall<PurchaseCQ> _qyCall;
		    public MemberSpQyCall(HpSpQyCall<PurchaseCQ> myQyCall) { _qyCall = myQyCall; }
		    public bool has() { return _qyCall.has() && _qyCall.qy().hasConditionQueryMember(); }
			public MemberCQ qy() { return _qyCall.qy().QueryMember(); }
		}
        public ProductCBSpecification SpecifyProduct() {
            assertForeign("product");
            if (_product == null) {
                _product = new ProductCBSpecification(_baseCB, new ProductSpQyCall(_qyCall), _forDerivedReferrer, _forScalarSelect, _forScalarCondition, _forColumnQuery);
                if (xhasSyncQyCall()) // inherits it
                { _product.xsetSyncQyCall(new ProductSpQyCall(xsyncQyCall())); }
            }
            return _product;
        }
		public class ProductSpQyCall : HpSpQyCall<ProductCQ> {
		    protected HpSpQyCall<PurchaseCQ> _qyCall;
		    public ProductSpQyCall(HpSpQyCall<PurchaseCQ> myQyCall) { _qyCall = myQyCall; }
		    public bool has() { return _qyCall.has() && _qyCall.qy().hasConditionQueryProduct(); }
			public ProductCQ qy() { return _qyCall.qy().QueryProduct(); }
		}
    }
}
