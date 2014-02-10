
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
    public class MbBsPurchaseCB : MbAbstractConditionBean {

        // ===============================================================================
        //                                                                       Attribute
        //                                                                       =========
        protected MbPurchaseCQ _conditionQuery;

        // ===============================================================================
        //                                                                      Table Name
        //                                                                      ==========
        public override String TableDbName { get { return "purchase"; } }

        // ===============================================================================
        //                                                             PrimaryKey Handling
        //                                                             ===================
        public void AcceptPrimaryKey(long? purchaseId) {
            assertObjectNotNull("purchaseId", purchaseId);
            MbBsPurchaseCB cb = this;
            cb.Query().SetPurchaseId_Equal(purchaseId);
        }

        public override MbConditionBean AddOrderBy_PK_Asc() {
            Query().AddOrderBy_PurchaseId_Asc();
            return this;
        }

        public override MbConditionBean AddOrderBy_PK_Desc() {
            Query().AddOrderBy_PurchaseId_Desc();
            return this;
        }

        // ===============================================================================
        //                                                                           Query
        //                                                                           =====
        public MbPurchaseCQ Query() {
            return this.ConditionQuery;
        }

        public MbPurchaseCQ ConditionQuery {
            get {
                if (_conditionQuery == null) {
                    _conditionQuery = CreateLocalCQ();
                }
                return _conditionQuery;
            }
        }

        protected virtual MbPurchaseCQ CreateLocalCQ() {
            return xcreateCQ(null, this.SqlClause, this.SqlClause.getBasePointAliasName(), 0);
        }

        protected virtual MbPurchaseCQ xcreateCQ(MbConditionQuery childQuery, MbSqlClause sqlClause, String aliasName, int nestLevel) {
            return new MbPurchaseCQ(childQuery, sqlClause, aliasName, nestLevel);
        }

        public override MbConditionQuery LocalCQ {
            get { return this.ConditionQuery; }
        }

        // ===============================================================================
        //                                                                           Union
        //                                                                           =====
	    public virtual void Union(MbUnionQuery<MbPurchaseCB> unionQuery) {
            MbPurchaseCB cb = new MbPurchaseCB();
            cb.xsetupForUnion(this); xsyncUQ(cb); unionQuery.Invoke(cb);
		    MbPurchaseCQ cq = cb.Query(); Query().xsetUnionQuery(cq);
        }

	    public virtual void UnionAll(MbUnionQuery<MbPurchaseCB> unionQuery) {
            MbPurchaseCB cb = new MbPurchaseCB();
            cb.xsetupForUnion(this); xsyncUQ(cb); unionQuery.Invoke(cb);
		    MbPurchaseCQ cq = cb.Query(); Query().xsetUnionAllQuery(cq);
	    }

        public override bool HasUnionQueryOrUnionAllQuery() {
            return Query().hasUnionQueryOrUnionAllQuery();
        }

        // ===============================================================================
        //                                                                    Setup Select
        //                                                                    ============
        protected MbMemberNss _nssMember;
        public MbMemberNss NssMember { get {
            if (_nssMember == null) { _nssMember = new MbMemberNss(null); }
            return _nssMember;
        }}
        public MbMemberNss SetupSelect_Member() {
            if (HasSpecifiedColumn) { // if reverse call
                Specify().ColumnMemberId();
            }
            doSetupSelect(delegate { return Query().QueryMember(); });
            if (_nssMember == null || !_nssMember.HasConditionQuery)
            { _nssMember = new MbMemberNss(Query().QueryMember()); }
            return _nssMember;
        }
        protected MbProductNss _nssProduct;
        public MbProductNss NssProduct { get {
            if (_nssProduct == null) { _nssProduct = new MbProductNss(null); }
            return _nssProduct;
        }}
        public MbProductNss SetupSelect_Product() {
            if (HasSpecifiedColumn) { // if reverse call
                Specify().ColumnProductId();
            }
            doSetupSelect(delegate { return Query().QueryProduct(); });
            if (_nssProduct == null || !_nssProduct.HasConditionQuery)
            { _nssProduct = new MbProductNss(Query().QueryProduct()); }
            return _nssProduct;
        }

        // [DBFlute-0.7.4]
        // ===============================================================================
        //                                                                         Specify
        //                                                                         =======
        protected MbPurchaseCBSpecification _specification;
        public MbPurchaseCBSpecification Specify() {
            if (_specification == null) { _specification = new MbPurchaseCBSpecification(this, new MySpQyCall(this), _forDerivedReferrer, _forScalarSelect, _forScalarCondition, _forColumnQuery); }
            return _specification;
        }
        protected bool HasSpecifiedColumn { get {
            return _specification != null && _specification.IsAlreadySpecifiedRequiredColumn;
        }}
        protected class MySpQyCall : HpSpQyCall<MbPurchaseCQ> {
			protected MbBsPurchaseCB _myCB;
			public MySpQyCall(MbBsPurchaseCB myCB) { _myCB = myCB; }
    		public bool has() { return true; } public MbPurchaseCQ qy() { return _myCB.Query(); }
    	}

        // [DBFlute-0.8.9.18]
        // ===============================================================================
        //                                                                     ColumnQuery
        //                                                                     ===========
        public HpColQyOperand<MbPurchaseCB> ColumnQuery(MbSpecifyQuery<MbPurchaseCB> leftSpecifyQuery) {
            return new HpColQyOperand<MbPurchaseCB>(delegate(MbSpecifyQuery<MbPurchaseCB> rightSp, String operand) {
                xcolqy(xcreateColumnQueryCB(), xcreateColumnQueryCB(), leftSpecifyQuery, rightSp, operand);
            });
        }

        protected MbPurchaseCB xcreateColumnQueryCB() {
            MbPurchaseCB cb = new MbPurchaseCB();
            cb.xsetupForColumnQuery((MbPurchaseCB)this);
            return cb;
        }

        // [DBFlute-0.8.9.9]
        // ===============================================================================
        //                                                                    OrScopeQuery
        //                                                                    ============
        public void OrScopeQuery(MbOrQuery<MbPurchaseCB> orQuery) {
            xorQ((MbPurchaseCB)this, orQuery);
        }

        // ===============================================================================
        //                                                                    Purpose Type
        //                                                                    ============
        public void xsetupForColumnQuery(MbPurchaseCB mainCB) {
            xinheritSubQueryInfo(mainCB.LocalCQ);
            //xchangePurposeSqlClause(HpCBPurpose.COLUMN_QUERY);
            _forColumnQuery = true; // old style

            // inherits a parent query to synchronize real name
            // (and also for suppressing query check) 
            Specify().xsetSyncQyCall(new MbPurchaseCBColQySpQyCall(mainCB));
        }
    }

    public class MbPurchaseCBColQySpQyCall : HpSpQyCall<MbPurchaseCQ> {
        protected MbPurchaseCB _mainCB;
        public MbPurchaseCBColQySpQyCall(MbPurchaseCB mainCB) {
            _mainCB = mainCB;
        }
        public bool has() { return true; } 
        public MbPurchaseCQ qy() { return _mainCB.Query(); } 
    }

    public class MbPurchaseCBSpecification : AbstractSpecification<MbPurchaseCQ> {
        protected MbMemberCBSpecification _member;
        protected MbProductCBSpecification _product;
        public MbPurchaseCBSpecification(MbConditionBean baseCB, HpSpQyCall<MbPurchaseCQ> qyCall
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
                    || qyCall().qy().xgetReferrerQuery() is MbMemberCQ) {
                ColumnMemberId(); // FK or one-to-one referrer
            }
            if (qyCall().qy().hasConditionQueryProduct()
                    || qyCall().qy().xgetReferrerQuery() is MbProductCQ) {
                ColumnProductId(); // FK or one-to-one referrer
            }
        }
        protected override String getTableDbName() { return "purchase"; }
        public MbMemberCBSpecification SpecifyMember() {
            assertForeign("member");
            if (_member == null) {
                _member = new MbMemberCBSpecification(_baseCB, new MemberSpQyCall(_qyCall), _forDerivedReferrer, _forScalarSelect, _forScalarCondition, _forColumnQuery);
                if (xhasSyncQyCall()) // inherits it
                { _member.xsetSyncQyCall(new MemberSpQyCall(xsyncQyCall())); }
            }
            return _member;
        }
		public class MemberSpQyCall : HpSpQyCall<MbMemberCQ> {
		    protected HpSpQyCall<MbPurchaseCQ> _qyCall;
		    public MemberSpQyCall(HpSpQyCall<MbPurchaseCQ> myQyCall) { _qyCall = myQyCall; }
		    public bool has() { return _qyCall.has() && _qyCall.qy().hasConditionQueryMember(); }
			public MbMemberCQ qy() { return _qyCall.qy().QueryMember(); }
		}
        public MbProductCBSpecification SpecifyProduct() {
            assertForeign("product");
            if (_product == null) {
                _product = new MbProductCBSpecification(_baseCB, new ProductSpQyCall(_qyCall), _forDerivedReferrer, _forScalarSelect, _forScalarCondition, _forColumnQuery);
                if (xhasSyncQyCall()) // inherits it
                { _product.xsetSyncQyCall(new ProductSpQyCall(xsyncQyCall())); }
            }
            return _product;
        }
		public class ProductSpQyCall : HpSpQyCall<MbProductCQ> {
		    protected HpSpQyCall<MbPurchaseCQ> _qyCall;
		    public ProductSpQyCall(HpSpQyCall<MbPurchaseCQ> myQyCall) { _qyCall = myQyCall; }
		    public bool has() { return _qyCall.has() && _qyCall.qy().hasConditionQueryProduct(); }
			public MbProductCQ qy() { return _qyCall.qy().QueryProduct(); }
		}
    }
}
