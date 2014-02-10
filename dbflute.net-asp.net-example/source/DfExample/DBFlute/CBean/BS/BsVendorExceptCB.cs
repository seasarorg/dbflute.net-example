
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
    public class BsVendorExceptCB : AbstractConditionBean {

        // ===============================================================================
        //                                                                       Attribute
        //                                                                       =========
        protected VendorExceptCQ _conditionQuery;

        // ===============================================================================
        //                                                                      Table Name
        //                                                                      ==========
        public override String TableDbName { get { return "VENDOR_EXCEPT"; } }

        // ===============================================================================
        //                                                             PrimaryKey Handling
        //                                                             ===================
        public void AcceptPrimaryKey(long? vendorExceptId) {
            assertObjectNotNull("vendorExceptId", vendorExceptId);
            BsVendorExceptCB cb = this;
            cb.Query().SetVendorExceptId_Equal(vendorExceptId);
        }

        public override ConditionBean AddOrderBy_PK_Asc() {
            Query().AddOrderBy_VendorExceptId_Asc();
            return this;
        }

        public override ConditionBean AddOrderBy_PK_Desc() {
            Query().AddOrderBy_VendorExceptId_Desc();
            return this;
        }

        // ===============================================================================
        //                                                                           Query
        //                                                                           =====
        public VendorExceptCQ Query() {
            return this.ConditionQuery;
        }

        public VendorExceptCQ ConditionQuery {
            get {
                if (_conditionQuery == null) {
                    _conditionQuery = CreateLocalCQ();
                }
                return _conditionQuery;
            }
        }

        protected virtual VendorExceptCQ CreateLocalCQ() {
            return xcreateCQ(null, this.SqlClause, this.SqlClause.getBasePointAliasName(), 0);
        }

        protected virtual VendorExceptCQ xcreateCQ(ConditionQuery childQuery, SqlClause sqlClause, String aliasName, int nestLevel) {
            return new VendorExceptCQ(childQuery, sqlClause, aliasName, nestLevel);
        }

        public override ConditionQuery LocalCQ {
            get { return this.ConditionQuery; }
        }

        // ===============================================================================
        //                                                                           Union
        //                                                                           =====
	    public virtual void Union(UnionQuery<VendorExceptCB> unionQuery) {
            VendorExceptCB cb = new VendorExceptCB();
            cb.xsetupForUnion(this); xsyncUQ(cb); unionQuery.Invoke(cb);
		    VendorExceptCQ cq = cb.Query(); Query().xsetUnionQuery(cq);
        }

	    public virtual void UnionAll(UnionQuery<VendorExceptCB> unionQuery) {
            VendorExceptCB cb = new VendorExceptCB();
            cb.xsetupForUnion(this); xsyncUQ(cb); unionQuery.Invoke(cb);
		    VendorExceptCQ cq = cb.Query(); Query().xsetUnionAllQuery(cq);
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
        protected VendorExceptCBSpecification _specification;
        public VendorExceptCBSpecification Specify() {
            if (_specification == null) { _specification = new VendorExceptCBSpecification(this, new MySpQyCall(this), _forDerivedReferrer, _forScalarSelect, _forScalarCondition, _forColumnQuery); }
            return _specification;
        }
        protected bool HasSpecifiedColumn { get {
            return _specification != null && _specification.IsAlreadySpecifiedRequiredColumn;
        }}
        protected class MySpQyCall : HpSpQyCall<VendorExceptCQ> {
			protected BsVendorExceptCB _myCB;
			public MySpQyCall(BsVendorExceptCB myCB) { _myCB = myCB; }
    		public bool has() { return true; } public VendorExceptCQ qy() { return _myCB.Query(); }
    	}

        // [DBFlute-0.8.9.18]
        // ===============================================================================
        //                                                                     ColumnQuery
        //                                                                     ===========
        public HpColQyOperand<VendorExceptCB> ColumnQuery(SpecifyQuery<VendorExceptCB> leftSpecifyQuery) {
            return new HpColQyOperand<VendorExceptCB>(delegate(SpecifyQuery<VendorExceptCB> rightSp, String operand) {
                xcolqy(xcreateColumnQueryCB(), xcreateColumnQueryCB(), leftSpecifyQuery, rightSp, operand);
            });
        }

        protected VendorExceptCB xcreateColumnQueryCB() {
            VendorExceptCB cb = new VendorExceptCB();
            cb.xsetupForColumnQuery((VendorExceptCB)this);
            return cb;
        }

        // [DBFlute-0.8.9.9]
        // ===============================================================================
        //                                                                    OrScopeQuery
        //                                                                    ============
        public void OrScopeQuery(OrQuery<VendorExceptCB> orQuery) {
            xorQ((VendorExceptCB)this, orQuery);
        }

        // ===============================================================================
        //                                                                    Purpose Type
        //                                                                    ============
        public void xsetupForColumnQuery(VendorExceptCB mainCB) {
            xinheritSubQueryInfo(mainCB.LocalCQ);
            //xchangePurposeSqlClause(HpCBPurpose.COLUMN_QUERY);
            _forColumnQuery = true; // old style

            // inherits a parent query to synchronize real name
            // (and also for suppressing query check) 
            Specify().xsetSyncQyCall(new VendorExceptCBColQySpQyCall(mainCB));
        }
    }

    public class VendorExceptCBColQySpQyCall : HpSpQyCall<VendorExceptCQ> {
        protected VendorExceptCB _mainCB;
        public VendorExceptCBColQySpQyCall(VendorExceptCB mainCB) {
            _mainCB = mainCB;
        }
        public bool has() { return true; } 
        public VendorExceptCQ qy() { return _mainCB.Query(); } 
    }

    public class VendorExceptCBSpecification : AbstractSpecification<VendorExceptCQ> {
        public VendorExceptCBSpecification(ConditionBean baseCB, HpSpQyCall<VendorExceptCQ> qyCall
                                                      , bool forDerivedReferrer, bool forScalarSelect, bool forScalarSubQuery, bool forColumnQuery)
        : base(baseCB, qyCall, forDerivedReferrer, forScalarSelect, forScalarSubQuery, forColumnQuery) { }
        public void ColumnVendorExceptId() { doColumn("VENDOR_EXCEPT_ID"); }
        public void ColumnVandorExceptName() { doColumn("VANDOR_EXCEPT_NAME"); }
        protected override void doSpecifyRequiredColumn() {
            ColumnVendorExceptId(); // PK
        }
        protected override String getTableDbName() { return "VENDOR_EXCEPT"; }
        public RAFunction<VendorRefExceptCB, VendorExceptCQ> DerivedVendorRefExceptList() {
            if (xhasSyncQyCall()) { xsyncQyCall().qy(); } // for sync (for example, this in ColumnQuery)
            return new RAFunction<VendorRefExceptCB, VendorExceptCQ>(_baseCB, _qyCall.qy(), delegate(String function, SubQuery<VendorRefExceptCB> subQuery, VendorExceptCQ cq, String aliasName)
                { cq.xsderiveVendorRefExceptList(function, subQuery, aliasName); });
        }
    }
}
