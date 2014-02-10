
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
    public class BsVdSynonymVendorRefTargetCB : AbstractConditionBean {

        // ===============================================================================
        //                                                                       Attribute
        //                                                                       =========
        protected VdSynonymVendorRefTargetCQ _conditionQuery;

        // ===============================================================================
        //                                                                      Table Name
        //                                                                      ==========
        public override String TableDbName { get { return "VD_SYNONYM_VENDOR_REF_TARGET"; } }

        // ===============================================================================
        //                                                             PrimaryKey Handling
        //                                                             ===================
        public void AcceptPrimaryKey(long? vendorRefTargetId) {
            assertObjectNotNull("vendorRefTargetId", vendorRefTargetId);
            BsVdSynonymVendorRefTargetCB cb = this;
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
        public VdSynonymVendorRefTargetCQ Query() {
            return this.ConditionQuery;
        }

        public VdSynonymVendorRefTargetCQ ConditionQuery {
            get {
                if (_conditionQuery == null) {
                    _conditionQuery = CreateLocalCQ();
                }
                return _conditionQuery;
            }
        }

        protected virtual VdSynonymVendorRefTargetCQ CreateLocalCQ() {
            return xcreateCQ(null, this.SqlClause, this.SqlClause.getBasePointAliasName(), 0);
        }

        protected virtual VdSynonymVendorRefTargetCQ xcreateCQ(ConditionQuery childQuery, SqlClause sqlClause, String aliasName, int nestLevel) {
            return new VdSynonymVendorRefTargetCQ(childQuery, sqlClause, aliasName, nestLevel);
        }

        public override ConditionQuery LocalCQ {
            get { return this.ConditionQuery; }
        }

        // ===============================================================================
        //                                                                           Union
        //                                                                           =====
	    public virtual void Union(UnionQuery<VdSynonymVendorRefTargetCB> unionQuery) {
            VdSynonymVendorRefTargetCB cb = new VdSynonymVendorRefTargetCB();
            cb.xsetupForUnion(this); xsyncUQ(cb); unionQuery.Invoke(cb);
		    VdSynonymVendorRefTargetCQ cq = cb.Query(); Query().xsetUnionQuery(cq);
        }

	    public virtual void UnionAll(UnionQuery<VdSynonymVendorRefTargetCB> unionQuery) {
            VdSynonymVendorRefTargetCB cb = new VdSynonymVendorRefTargetCB();
            cb.xsetupForUnion(this); xsyncUQ(cb); unionQuery.Invoke(cb);
		    VdSynonymVendorRefTargetCQ cq = cb.Query(); Query().xsetUnionAllQuery(cq);
	    }

        public override bool HasUnionQueryOrUnionAllQuery() {
            return Query().hasUnionQueryOrUnionAllQuery();
        }

        // ===============================================================================
        //                                                                    Setup Select
        //                                                                    ============
        protected VdSynonymVendorTargetNss _nssVdSynonymVendorTarget;
        public VdSynonymVendorTargetNss NssVdSynonymVendorTarget { get {
            if (_nssVdSynonymVendorTarget == null) { _nssVdSynonymVendorTarget = new VdSynonymVendorTargetNss(null); }
            return _nssVdSynonymVendorTarget;
        }}
        public VdSynonymVendorTargetNss SetupSelect_VdSynonymVendorTarget() {
            if (HasSpecifiedColumn) { // if reverse call
                Specify().ColumnVendorTargetId();
            }
            doSetupSelect(delegate { return Query().QueryVdSynonymVendorTarget(); });
            if (_nssVdSynonymVendorTarget == null || !_nssVdSynonymVendorTarget.HasConditionQuery)
            { _nssVdSynonymVendorTarget = new VdSynonymVendorTargetNss(Query().QueryVdSynonymVendorTarget()); }
            return _nssVdSynonymVendorTarget;
        }

        // [DBFlute-0.7.4]
        // ===============================================================================
        //                                                                         Specify
        //                                                                         =======
        protected VdSynonymVendorRefTargetCBSpecification _specification;
        public VdSynonymVendorRefTargetCBSpecification Specify() {
            if (_specification == null) { _specification = new VdSynonymVendorRefTargetCBSpecification(this, new MySpQyCall(this), _forDerivedReferrer, _forScalarSelect, _forScalarCondition, _forColumnQuery); }
            return _specification;
        }
        protected bool HasSpecifiedColumn { get {
            return _specification != null && _specification.IsAlreadySpecifiedRequiredColumn;
        }}
        protected class MySpQyCall : HpSpQyCall<VdSynonymVendorRefTargetCQ> {
			protected BsVdSynonymVendorRefTargetCB _myCB;
			public MySpQyCall(BsVdSynonymVendorRefTargetCB myCB) { _myCB = myCB; }
    		public bool has() { return true; } public VdSynonymVendorRefTargetCQ qy() { return _myCB.Query(); }
    	}

        // [DBFlute-0.8.9.18]
        // ===============================================================================
        //                                                                     ColumnQuery
        //                                                                     ===========
        public HpColQyOperand<VdSynonymVendorRefTargetCB> ColumnQuery(SpecifyQuery<VdSynonymVendorRefTargetCB> leftSpecifyQuery) {
            return new HpColQyOperand<VdSynonymVendorRefTargetCB>(delegate(SpecifyQuery<VdSynonymVendorRefTargetCB> rightSp, String operand) {
                xcolqy(xcreateColumnQueryCB(), xcreateColumnQueryCB(), leftSpecifyQuery, rightSp, operand);
            });
        }

        protected VdSynonymVendorRefTargetCB xcreateColumnQueryCB() {
            VdSynonymVendorRefTargetCB cb = new VdSynonymVendorRefTargetCB();
            cb.xsetupForColumnQuery((VdSynonymVendorRefTargetCB)this);
            return cb;
        }

        // [DBFlute-0.8.9.9]
        // ===============================================================================
        //                                                                    OrScopeQuery
        //                                                                    ============
        public void OrScopeQuery(OrQuery<VdSynonymVendorRefTargetCB> orQuery) {
            xorQ((VdSynonymVendorRefTargetCB)this, orQuery);
        }

        // ===============================================================================
        //                                                                    Purpose Type
        //                                                                    ============
        public void xsetupForColumnQuery(VdSynonymVendorRefTargetCB mainCB) {
            xinheritSubQueryInfo(mainCB.LocalCQ);
            //xchangePurposeSqlClause(HpCBPurpose.COLUMN_QUERY);
            _forColumnQuery = true; // old style

            // inherits a parent query to synchronize real name
            // (and also for suppressing query check) 
            Specify().xsetSyncQyCall(new VdSynonymVendorRefTargetCBColQySpQyCall(mainCB));
        }
    }

    public class VdSynonymVendorRefTargetCBColQySpQyCall : HpSpQyCall<VdSynonymVendorRefTargetCQ> {
        protected VdSynonymVendorRefTargetCB _mainCB;
        public VdSynonymVendorRefTargetCBColQySpQyCall(VdSynonymVendorRefTargetCB mainCB) {
            _mainCB = mainCB;
        }
        public bool has() { return true; } 
        public VdSynonymVendorRefTargetCQ qy() { return _mainCB.Query(); } 
    }

    public class VdSynonymVendorRefTargetCBSpecification : AbstractSpecification<VdSynonymVendorRefTargetCQ> {
        protected VdSynonymVendorTargetCBSpecification _vdSynonymVendorTarget;
        public VdSynonymVendorRefTargetCBSpecification(ConditionBean baseCB, HpSpQyCall<VdSynonymVendorRefTargetCQ> qyCall
                                                      , bool forDerivedReferrer, bool forScalarSelect, bool forScalarSubQuery, bool forColumnQuery)
        : base(baseCB, qyCall, forDerivedReferrer, forScalarSelect, forScalarSubQuery, forColumnQuery) { }
        public void ColumnVendorRefTargetId() { doColumn("VENDOR_REF_TARGET_ID"); }
        public void ColumnVendorTargetId() { doColumn("VENDOR_TARGET_ID"); }
        protected override void doSpecifyRequiredColumn() {
            ColumnVendorRefTargetId(); // PK
            if (qyCall().qy().hasConditionQueryVdSynonymVendorTarget()
                    || qyCall().qy().xgetReferrerQuery() is VdSynonymVendorTargetCQ) {
                ColumnVendorTargetId(); // FK or one-to-one referrer
            }
        }
        protected override String getTableDbName() { return "VD_SYNONYM_VENDOR_REF_TARGET"; }
        public VdSynonymVendorTargetCBSpecification SpecifyVdSynonymVendorTarget() {
            assertForeign("vdSynonymVendorTarget");
            if (_vdSynonymVendorTarget == null) {
                _vdSynonymVendorTarget = new VdSynonymVendorTargetCBSpecification(_baseCB, new VdSynonymVendorTargetSpQyCall(_qyCall), _forDerivedReferrer, _forScalarSelect, _forScalarCondition, _forColumnQuery);
                if (xhasSyncQyCall()) // inherits it
                { _vdSynonymVendorTarget.xsetSyncQyCall(new VdSynonymVendorTargetSpQyCall(xsyncQyCall())); }
            }
            return _vdSynonymVendorTarget;
        }
		public class VdSynonymVendorTargetSpQyCall : HpSpQyCall<VdSynonymVendorTargetCQ> {
		    protected HpSpQyCall<VdSynonymVendorRefTargetCQ> _qyCall;
		    public VdSynonymVendorTargetSpQyCall(HpSpQyCall<VdSynonymVendorRefTargetCQ> myQyCall) { _qyCall = myQyCall; }
		    public bool has() { return _qyCall.has() && _qyCall.qy().hasConditionQueryVdSynonymVendorTarget(); }
			public VdSynonymVendorTargetCQ qy() { return _qyCall.qy().QueryVdSynonymVendorTarget(); }
		}
    }
}
