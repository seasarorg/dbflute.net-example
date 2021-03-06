
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
    public class BsVendorTargetCB : AbstractConditionBean {

        // ===============================================================================
        //                                                                       Attribute
        //                                                                       =========
        protected VendorTargetCQ _conditionQuery;

        // ===============================================================================
        //                                                                      Table Name
        //                                                                      ==========
        public override String TableDbName { get { return "VENDOR_TARGET"; } }

        // ===============================================================================
        //                                                             PrimaryKey Handling
        //                                                             ===================
        public void AcceptPrimaryKey(long? vendorTargetId) {
            assertObjectNotNull("vendorTargetId", vendorTargetId);
            BsVendorTargetCB cb = this;
            cb.Query().SetVendorTargetId_Equal(vendorTargetId);
        }

        public override ConditionBean AddOrderBy_PK_Asc() {
            Query().AddOrderBy_VendorTargetId_Asc();
            return this;
        }

        public override ConditionBean AddOrderBy_PK_Desc() {
            Query().AddOrderBy_VendorTargetId_Desc();
            return this;
        }

        // ===============================================================================
        //                                                                           Query
        //                                                                           =====
        public VendorTargetCQ Query() {
            return this.ConditionQuery;
        }

        public VendorTargetCQ ConditionQuery {
            get {
                if (_conditionQuery == null) {
                    _conditionQuery = CreateLocalCQ();
                }
                return _conditionQuery;
            }
        }

        protected virtual VendorTargetCQ CreateLocalCQ() {
            return xcreateCQ(null, this.SqlClause, this.SqlClause.getBasePointAliasName(), 0);
        }

        protected virtual VendorTargetCQ xcreateCQ(ConditionQuery childQuery, SqlClause sqlClause, String aliasName, int nestLevel) {
            return new VendorTargetCQ(childQuery, sqlClause, aliasName, nestLevel);
        }

        public override ConditionQuery LocalCQ {
            get { return this.ConditionQuery; }
        }

        // ===============================================================================
        //                                                                           Union
        //                                                                           =====
	    public virtual void Union(UnionQuery<VendorTargetCB> unionQuery) {
            VendorTargetCB cb = new VendorTargetCB();
            cb.xsetupForUnion(this); xsyncUQ(cb); unionQuery.Invoke(cb);
		    VendorTargetCQ cq = cb.Query(); Query().xsetUnionQuery(cq);
        }

	    public virtual void UnionAll(UnionQuery<VendorTargetCB> unionQuery) {
            VendorTargetCB cb = new VendorTargetCB();
            cb.xsetupForUnion(this); xsyncUQ(cb); unionQuery.Invoke(cb);
		    VendorTargetCQ cq = cb.Query(); Query().xsetUnionAllQuery(cq);
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
        protected VendorTargetCBSpecification _specification;
        public VendorTargetCBSpecification Specify() {
            if (_specification == null) { _specification = new VendorTargetCBSpecification(this, new MySpQyCall(this), _forDerivedReferrer, _forScalarSelect, _forScalarCondition, _forColumnQuery); }
            return _specification;
        }
        protected bool HasSpecifiedColumn { get {
            return _specification != null && _specification.IsAlreadySpecifiedRequiredColumn;
        }}
        protected class MySpQyCall : HpSpQyCall<VendorTargetCQ> {
			protected BsVendorTargetCB _myCB;
			public MySpQyCall(BsVendorTargetCB myCB) { _myCB = myCB; }
    		public bool has() { return true; } public VendorTargetCQ qy() { return _myCB.Query(); }
    	}

        // [DBFlute-0.8.9.18]
        // ===============================================================================
        //                                                                     ColumnQuery
        //                                                                     ===========
        public HpColQyOperand<VendorTargetCB> ColumnQuery(SpecifyQuery<VendorTargetCB> leftSpecifyQuery) {
            return new HpColQyOperand<VendorTargetCB>(delegate(SpecifyQuery<VendorTargetCB> rightSp, String operand) {
                xcolqy(xcreateColumnQueryCB(), xcreateColumnQueryCB(), leftSpecifyQuery, rightSp, operand);
            });
        }

        protected VendorTargetCB xcreateColumnQueryCB() {
            VendorTargetCB cb = new VendorTargetCB();
            cb.xsetupForColumnQuery((VendorTargetCB)this);
            return cb;
        }

        // [DBFlute-0.8.9.9]
        // ===============================================================================
        //                                                                    OrScopeQuery
        //                                                                    ============
        public void OrScopeQuery(OrQuery<VendorTargetCB> orQuery) {
            xorQ((VendorTargetCB)this, orQuery);
        }

        // ===============================================================================
        //                                                                    Purpose Type
        //                                                                    ============
        public void xsetupForColumnQuery(VendorTargetCB mainCB) {
            xinheritSubQueryInfo(mainCB.LocalCQ);
            //xchangePurposeSqlClause(HpCBPurpose.COLUMN_QUERY);
            _forColumnQuery = true; // old style

            // inherits a parent query to synchronize real name
            // (and also for suppressing query check) 
            Specify().xsetSyncQyCall(new VendorTargetCBColQySpQyCall(mainCB));
        }
    }

    public class VendorTargetCBColQySpQyCall : HpSpQyCall<VendorTargetCQ> {
        protected VendorTargetCB _mainCB;
        public VendorTargetCBColQySpQyCall(VendorTargetCB mainCB) {
            _mainCB = mainCB;
        }
        public bool has() { return true; } 
        public VendorTargetCQ qy() { return _mainCB.Query(); } 
    }

    public class VendorTargetCBSpecification : AbstractSpecification<VendorTargetCQ> {
        public VendorTargetCBSpecification(ConditionBean baseCB, HpSpQyCall<VendorTargetCQ> qyCall
                                                      , bool forDerivedReferrer, bool forScalarSelect, bool forScalarSubQuery, bool forColumnQuery)
        : base(baseCB, qyCall, forDerivedReferrer, forScalarSelect, forScalarSubQuery, forColumnQuery) { }
        public void ColumnVendorTargetId() { doColumn("VENDOR_TARGET_ID"); }
        public void ColumnVandorTargetName() { doColumn("VANDOR_TARGET_NAME"); }
        protected override void doSpecifyRequiredColumn() {
            ColumnVendorTargetId(); // PK
        }
        protected override String getTableDbName() { return "VENDOR_TARGET"; }
        public RAFunction<VendorRefTargetCB, VendorTargetCQ> DerivedVendorRefTargetList() {
            if (xhasSyncQyCall()) { xsyncQyCall().qy(); } // for sync (for example, this in ColumnQuery)
            return new RAFunction<VendorRefTargetCB, VendorTargetCQ>(_baseCB, _qyCall.qy(), delegate(String function, SubQuery<VendorRefTargetCB> subQuery, VendorTargetCQ cq, String aliasName)
                { cq.xsderiveVendorRefTargetList(function, subQuery, aliasName); });
        }
    }
}
