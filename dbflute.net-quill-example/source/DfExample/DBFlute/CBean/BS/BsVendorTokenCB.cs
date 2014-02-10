
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
    public class BsVendorTokenCB : AbstractConditionBean {

        // ===============================================================================
        //                                                                       Attribute
        //                                                                       =========
        protected VendorTokenCQ _conditionQuery;

        // ===============================================================================
        //                                                                      Table Name
        //                                                                      ==========
        public override String TableDbName { get { return "vendor_token"; } }

        // ===============================================================================
        //                                                             PrimaryKey Handling
        //                                                             ===================
        public void AcceptPrimaryKey(long? vendorTokenId) {
            assertObjectNotNull("vendorTokenId", vendorTokenId);
            BsVendorTokenCB cb = this;
            cb.Query().SetVendorTokenId_Equal(vendorTokenId);
        }

        public override ConditionBean AddOrderBy_PK_Asc() {
            Query().AddOrderBy_VendorTokenId_Asc();
            return this;
        }

        public override ConditionBean AddOrderBy_PK_Desc() {
            Query().AddOrderBy_VendorTokenId_Desc();
            return this;
        }

        // ===============================================================================
        //                                                                           Query
        //                                                                           =====
        public VendorTokenCQ Query() {
            return this.ConditionQuery;
        }

        public VendorTokenCQ ConditionQuery {
            get {
                if (_conditionQuery == null) {
                    _conditionQuery = CreateLocalCQ();
                }
                return _conditionQuery;
            }
        }

        protected virtual VendorTokenCQ CreateLocalCQ() {
            return xcreateCQ(null, this.SqlClause, this.SqlClause.getBasePointAliasName(), 0);
        }

        protected virtual VendorTokenCQ xcreateCQ(ConditionQuery childQuery, SqlClause sqlClause, String aliasName, int nestLevel) {
            return new VendorTokenCQ(childQuery, sqlClause, aliasName, nestLevel);
        }

        public override ConditionQuery LocalCQ {
            get { return this.ConditionQuery; }
        }

        // ===============================================================================
        //                                                                           Union
        //                                                                           =====
	    public virtual void Union(UnionQuery<VendorTokenCB> unionQuery) {
            VendorTokenCB cb = new VendorTokenCB();
            cb.xsetupForUnion(this); xsyncUQ(cb); unionQuery.Invoke(cb);
		    VendorTokenCQ cq = cb.Query(); Query().xsetUnionQuery(cq);
        }

	    public virtual void UnionAll(UnionQuery<VendorTokenCB> unionQuery) {
            VendorTokenCB cb = new VendorTokenCB();
            cb.xsetupForUnion(this); xsyncUQ(cb); unionQuery.Invoke(cb);
		    VendorTokenCQ cq = cb.Query(); Query().xsetUnionAllQuery(cq);
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
        protected VendorTokenCBSpecification _specification;
        public VendorTokenCBSpecification Specify() {
            if (_specification == null) { _specification = new VendorTokenCBSpecification(this, new MySpQyCall(this), _forDerivedReferrer, _forScalarSelect, _forScalarCondition, _forColumnQuery); }
            return _specification;
        }
        protected bool HasSpecifiedColumn { get {
            return _specification != null && _specification.IsAlreadySpecifiedRequiredColumn;
        }}
        protected class MySpQyCall : HpSpQyCall<VendorTokenCQ> {
			protected BsVendorTokenCB _myCB;
			public MySpQyCall(BsVendorTokenCB myCB) { _myCB = myCB; }
    		public bool has() { return true; } public VendorTokenCQ qy() { return _myCB.Query(); }
    	}

        // [DBFlute-0.8.9.18]
        // ===============================================================================
        //                                                                     ColumnQuery
        //                                                                     ===========
        public HpColQyOperand<VendorTokenCB> ColumnQuery(SpecifyQuery<VendorTokenCB> leftSpecifyQuery) {
            return new HpColQyOperand<VendorTokenCB>(delegate(SpecifyQuery<VendorTokenCB> rightSp, String operand) {
                xcolqy(xcreateColumnQueryCB(), xcreateColumnQueryCB(), leftSpecifyQuery, rightSp, operand);
            });
        }

        protected VendorTokenCB xcreateColumnQueryCB() {
            VendorTokenCB cb = new VendorTokenCB();
            cb.xsetupForColumnQuery((VendorTokenCB)this);
            return cb;
        }

        // [DBFlute-0.8.9.9]
        // ===============================================================================
        //                                                                    OrScopeQuery
        //                                                                    ============
        public void OrScopeQuery(OrQuery<VendorTokenCB> orQuery) {
            xorQ((VendorTokenCB)this, orQuery);
        }

        // ===============================================================================
        //                                                                    Purpose Type
        //                                                                    ============
        public void xsetupForColumnQuery(VendorTokenCB mainCB) {
            xinheritSubQueryInfo(mainCB.LocalCQ);
            //xchangePurposeSqlClause(HpCBPurpose.COLUMN_QUERY);
            _forColumnQuery = true; // old style

            // inherits a parent query to synchronize real name
            // (and also for suppressing query check) 
            Specify().xsetSyncQyCall(new VendorTokenCBColQySpQyCall(mainCB));
        }
    }

    public class VendorTokenCBColQySpQyCall : HpSpQyCall<VendorTokenCQ> {
        protected VendorTokenCB _mainCB;
        public VendorTokenCBColQySpQyCall(VendorTokenCB mainCB) {
            _mainCB = mainCB;
        }
        public bool has() { return true; } 
        public VendorTokenCQ qy() { return _mainCB.Query(); } 
    }

    public class VendorTokenCBSpecification : AbstractSpecification<VendorTokenCQ> {
        public VendorTokenCBSpecification(ConditionBean baseCB, HpSpQyCall<VendorTokenCQ> qyCall
                                                      , bool forDerivedReferrer, bool forScalarSelect, bool forScalarSubQuery, bool forColumnQuery)
        : base(baseCB, qyCall, forDerivedReferrer, forScalarSelect, forScalarSubQuery, forColumnQuery) { }
        public void ColumnVendorTokenId() { doColumn("VENDOR_TOKEN_ID"); }
        public void ColumnTokenNumber() { doColumn("TOKEN_NUMBER"); }
        public void ColumnTokenName() { doColumn("TOKEN_NAME"); }
        protected override void doSpecifyRequiredColumn() {
            ColumnVendorTokenId(); // PK
        }
        protected override String getTableDbName() { return "vendor_token"; }
    }
}
