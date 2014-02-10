
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
    public class BsVendorRefTargetCB : AbstractConditionBean {

        // ===============================================================================
        //                                                                       Attribute
        //                                                                       =========
        protected VendorRefTargetCQ _conditionQuery;

        // ===============================================================================
        //                                                                      Table Name
        //                                                                      ==========
        public override String TableDbName { get { return "VENDOR_REF_TARGET"; } }

        // ===============================================================================
        //                                                             PrimaryKey Handling
        //                                                             ===================
        public void AcceptPrimaryKey(long? vendorRefTargetId) {
            assertObjectNotNull("vendorRefTargetId", vendorRefTargetId);
            BsVendorRefTargetCB cb = this;
            cb.Query().SetVendorRefTargetId_Equal(vendorRefTargetId);
        }

        public override ConditionBean AddOrderBy_PK_Asc() {
            Query().AddOrderBy_VendorRefTargetId_Asc();
            return this;
        }

        public override ConditionBean AddOrderBy_PK_Desc() {
            Query().AddOrderBy_VendorRefTargetId_Desc();
            return this;
        }

        // ===============================================================================
        //                                                                           Query
        //                                                                           =====
        public VendorRefTargetCQ Query() {
            return this.ConditionQuery;
        }

        public VendorRefTargetCQ ConditionQuery {
            get {
                if (_conditionQuery == null) {
                    _conditionQuery = CreateLocalCQ();
                }
                return _conditionQuery;
            }
        }

        protected virtual VendorRefTargetCQ CreateLocalCQ() {
            return xcreateCQ(null, this.SqlClause, this.SqlClause.getBasePointAliasName(), 0);
        }

        protected virtual VendorRefTargetCQ xcreateCQ(ConditionQuery childQuery, SqlClause sqlClause, String aliasName, int nestLevel) {
            return new VendorRefTargetCQ(childQuery, sqlClause, aliasName, nestLevel);
        }

        public override ConditionQuery LocalCQ {
            get { return this.ConditionQuery; }
        }

        // ===============================================================================
        //                                                                           Union
        //                                                                           =====
	    public virtual void Union(UnionQuery<VendorRefTargetCB> unionQuery) {
            VendorRefTargetCB cb = new VendorRefTargetCB();
            cb.xsetupForUnion(this); xsyncUQ(cb); unionQuery.Invoke(cb);
		    VendorRefTargetCQ cq = cb.Query(); Query().xsetUnionQuery(cq);
        }

	    public virtual void UnionAll(UnionQuery<VendorRefTargetCB> unionQuery) {
            VendorRefTargetCB cb = new VendorRefTargetCB();
            cb.xsetupForUnion(this); xsyncUQ(cb); unionQuery.Invoke(cb);
		    VendorRefTargetCQ cq = cb.Query(); Query().xsetUnionAllQuery(cq);
	    }

        public override bool HasUnionQueryOrUnionAllQuery() {
            return Query().hasUnionQueryOrUnionAllQuery();
        }

        // ===============================================================================
        //                                                                    Setup Select
        //                                                                    ============
        protected VendorTargetNss _nssVendorTarget;
        public VendorTargetNss NssVendorTarget { get {
            if (_nssVendorTarget == null) { _nssVendorTarget = new VendorTargetNss(null); }
            return _nssVendorTarget;
        }}
        public VendorTargetNss SetupSelect_VendorTarget() {
            if (HasSpecifiedColumn) { // if reverse call
                Specify().ColumnVendorTargetId();
            }
            doSetupSelect(delegate { return Query().QueryVendorTarget(); });
            if (_nssVendorTarget == null || !_nssVendorTarget.HasConditionQuery)
            { _nssVendorTarget = new VendorTargetNss(Query().QueryVendorTarget()); }
            return _nssVendorTarget;
        }

        // [DBFlute-0.7.4]
        // ===============================================================================
        //                                                                         Specify
        //                                                                         =======
        protected VendorRefTargetCBSpecification _specification;
        public VendorRefTargetCBSpecification Specify() {
            if (_specification == null) { _specification = new VendorRefTargetCBSpecification(this, new MySpQyCall(this), _forDerivedReferrer, _forScalarSelect, _forScalarCondition, _forColumnQuery); }
            return _specification;
        }
        protected bool HasSpecifiedColumn { get {
            return _specification != null && _specification.IsAlreadySpecifiedRequiredColumn;
        }}
        protected class MySpQyCall : HpSpQyCall<VendorRefTargetCQ> {
			protected BsVendorRefTargetCB _myCB;
			public MySpQyCall(BsVendorRefTargetCB myCB) { _myCB = myCB; }
    		public bool has() { return true; } public VendorRefTargetCQ qy() { return _myCB.Query(); }
    	}

        // [DBFlute-0.8.9.18]
        // ===============================================================================
        //                                                                     ColumnQuery
        //                                                                     ===========
        public HpColQyOperand<VendorRefTargetCB> ColumnQuery(SpecifyQuery<VendorRefTargetCB> leftSpecifyQuery) {
            return new HpColQyOperand<VendorRefTargetCB>(delegate(SpecifyQuery<VendorRefTargetCB> rightSp, String operand) {
                xcolqy(xcreateColumnQueryCB(), xcreateColumnQueryCB(), leftSpecifyQuery, rightSp, operand);
            });
        }

        protected VendorRefTargetCB xcreateColumnQueryCB() {
            VendorRefTargetCB cb = new VendorRefTargetCB();
            cb.xsetupForColumnQuery((VendorRefTargetCB)this);
            return cb;
        }

        // [DBFlute-0.8.9.9]
        // ===============================================================================
        //                                                                    OrScopeQuery
        //                                                                    ============
        public void OrScopeQuery(OrQuery<VendorRefTargetCB> orQuery) {
            xorQ((VendorRefTargetCB)this, orQuery);
        }

        // ===============================================================================
        //                                                                    Purpose Type
        //                                                                    ============
        public void xsetupForColumnQuery(VendorRefTargetCB mainCB) {
            xinheritSubQueryInfo(mainCB.LocalCQ);
            //xchangePurposeSqlClause(HpCBPurpose.COLUMN_QUERY);
            _forColumnQuery = true; // old style

            // inherits a parent query to synchronize real name
            // (and also for suppressing query check) 
            Specify().xsetSyncQyCall(new VendorRefTargetCBColQySpQyCall(mainCB));
        }
    }

    public class VendorRefTargetCBColQySpQyCall : HpSpQyCall<VendorRefTargetCQ> {
        protected VendorRefTargetCB _mainCB;
        public VendorRefTargetCBColQySpQyCall(VendorRefTargetCB mainCB) {
            _mainCB = mainCB;
        }
        public bool has() { return true; } 
        public VendorRefTargetCQ qy() { return _mainCB.Query(); } 
    }

    public class VendorRefTargetCBSpecification : AbstractSpecification<VendorRefTargetCQ> {
        protected VendorTargetCBSpecification _vendorTarget;
        public VendorRefTargetCBSpecification(ConditionBean baseCB, HpSpQyCall<VendorRefTargetCQ> qyCall
                                                      , bool forDerivedReferrer, bool forScalarSelect, bool forScalarSubQuery, bool forColumnQuery)
        : base(baseCB, qyCall, forDerivedReferrer, forScalarSelect, forScalarSubQuery, forColumnQuery) { }
        public void ColumnVendorRefTargetId() { doColumn("VENDOR_REF_TARGET_ID"); }
        public void ColumnVendorTargetId() { doColumn("VENDOR_TARGET_ID"); }
        protected override void doSpecifyRequiredColumn() {
            ColumnVendorRefTargetId(); // PK
            if (qyCall().qy().hasConditionQueryVendorTarget()
                    || qyCall().qy().xgetReferrerQuery() is VendorTargetCQ) {
                ColumnVendorTargetId(); // FK or one-to-one referrer
            }
        }
        protected override String getTableDbName() { return "VENDOR_REF_TARGET"; }
        public VendorTargetCBSpecification SpecifyVendorTarget() {
            assertForeign("vendorTarget");
            if (_vendorTarget == null) {
                _vendorTarget = new VendorTargetCBSpecification(_baseCB, new VendorTargetSpQyCall(_qyCall), _forDerivedReferrer, _forScalarSelect, _forScalarCondition, _forColumnQuery);
                if (xhasSyncQyCall()) // inherits it
                { _vendorTarget.xsetSyncQyCall(new VendorTargetSpQyCall(xsyncQyCall())); }
            }
            return _vendorTarget;
        }
		public class VendorTargetSpQyCall : HpSpQyCall<VendorTargetCQ> {
		    protected HpSpQyCall<VendorRefTargetCQ> _qyCall;
		    public VendorTargetSpQyCall(HpSpQyCall<VendorRefTargetCQ> myQyCall) { _qyCall = myQyCall; }
		    public bool has() { return _qyCall.has() && _qyCall.qy().hasConditionQueryVendorTarget(); }
			public VendorTargetCQ qy() { return _qyCall.qy().QueryVendorTarget(); }
		}
    }
}
