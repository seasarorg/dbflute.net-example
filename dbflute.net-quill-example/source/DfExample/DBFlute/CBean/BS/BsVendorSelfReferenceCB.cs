
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
    public class BsVendorSelfReferenceCB : AbstractConditionBean {

        // ===============================================================================
        //                                                                       Attribute
        //                                                                       =========
        protected VendorSelfReferenceCQ _conditionQuery;

        // ===============================================================================
        //                                                                      Table Name
        //                                                                      ==========
        public override String TableDbName { get { return "vendor_self_reference"; } }

        // ===============================================================================
        //                                                             PrimaryKey Handling
        //                                                             ===================
        public void AcceptPrimaryKey(long? selfReferenceId) {
            assertObjectNotNull("selfReferenceId", selfReferenceId);
            BsVendorSelfReferenceCB cb = this;
            cb.Query().SetSelfReferenceId_Equal(selfReferenceId);
        }

        public override ConditionBean AddOrderBy_PK_Asc() {
            Query().AddOrderBy_SelfReferenceId_Asc();
            return this;
        }

        public override ConditionBean AddOrderBy_PK_Desc() {
            Query().AddOrderBy_SelfReferenceId_Desc();
            return this;
        }

        // ===============================================================================
        //                                                                           Query
        //                                                                           =====
        public VendorSelfReferenceCQ Query() {
            return this.ConditionQuery;
        }

        public VendorSelfReferenceCQ ConditionQuery {
            get {
                if (_conditionQuery == null) {
                    _conditionQuery = CreateLocalCQ();
                }
                return _conditionQuery;
            }
        }

        protected virtual VendorSelfReferenceCQ CreateLocalCQ() {
            return xcreateCQ(null, this.SqlClause, this.SqlClause.getBasePointAliasName(), 0);
        }

        protected virtual VendorSelfReferenceCQ xcreateCQ(ConditionQuery childQuery, SqlClause sqlClause, String aliasName, int nestLevel) {
            return new VendorSelfReferenceCQ(childQuery, sqlClause, aliasName, nestLevel);
        }

        public override ConditionQuery LocalCQ {
            get { return this.ConditionQuery; }
        }

        // ===============================================================================
        //                                                                           Union
        //                                                                           =====
	    public virtual void Union(UnionQuery<VendorSelfReferenceCB> unionQuery) {
            VendorSelfReferenceCB cb = new VendorSelfReferenceCB();
            cb.xsetupForUnion(this); xsyncUQ(cb); unionQuery.Invoke(cb);
		    VendorSelfReferenceCQ cq = cb.Query(); Query().xsetUnionQuery(cq);
        }

	    public virtual void UnionAll(UnionQuery<VendorSelfReferenceCB> unionQuery) {
            VendorSelfReferenceCB cb = new VendorSelfReferenceCB();
            cb.xsetupForUnion(this); xsyncUQ(cb); unionQuery.Invoke(cb);
		    VendorSelfReferenceCQ cq = cb.Query(); Query().xsetUnionAllQuery(cq);
	    }

        public override bool HasUnionQueryOrUnionAllQuery() {
            return Query().hasUnionQueryOrUnionAllQuery();
        }

        // ===============================================================================
        //                                                                    Setup Select
        //                                                                    ============
        protected VendorSelfReferenceNss _nssVendorSelfReferenceSelf;
        public VendorSelfReferenceNss NssVendorSelfReferenceSelf { get {
            if (_nssVendorSelfReferenceSelf == null) { _nssVendorSelfReferenceSelf = new VendorSelfReferenceNss(null); }
            return _nssVendorSelfReferenceSelf;
        }}
        public VendorSelfReferenceNss SetupSelect_VendorSelfReferenceSelf() {
            if (HasSpecifiedColumn) { // if reverse call
                Specify().ColumnParentId();
            }
            doSetupSelect(delegate { return Query().QueryVendorSelfReferenceSelf(); });
            if (_nssVendorSelfReferenceSelf == null || !_nssVendorSelfReferenceSelf.HasConditionQuery)
            { _nssVendorSelfReferenceSelf = new VendorSelfReferenceNss(Query().QueryVendorSelfReferenceSelf()); }
            return _nssVendorSelfReferenceSelf;
        }

        // [DBFlute-0.7.4]
        // ===============================================================================
        //                                                                         Specify
        //                                                                         =======
        protected VendorSelfReferenceCBSpecification _specification;
        public VendorSelfReferenceCBSpecification Specify() {
            if (_specification == null) { _specification = new VendorSelfReferenceCBSpecification(this, new MySpQyCall(this), _forDerivedReferrer, _forScalarSelect, _forScalarCondition, _forColumnQuery); }
            return _specification;
        }
        protected bool HasSpecifiedColumn { get {
            return _specification != null && _specification.IsAlreadySpecifiedRequiredColumn;
        }}
        protected class MySpQyCall : HpSpQyCall<VendorSelfReferenceCQ> {
			protected BsVendorSelfReferenceCB _myCB;
			public MySpQyCall(BsVendorSelfReferenceCB myCB) { _myCB = myCB; }
    		public bool has() { return true; } public VendorSelfReferenceCQ qy() { return _myCB.Query(); }
    	}

        // [DBFlute-0.8.9.18]
        // ===============================================================================
        //                                                                     ColumnQuery
        //                                                                     ===========
        public HpColQyOperand<VendorSelfReferenceCB> ColumnQuery(SpecifyQuery<VendorSelfReferenceCB> leftSpecifyQuery) {
            return new HpColQyOperand<VendorSelfReferenceCB>(delegate(SpecifyQuery<VendorSelfReferenceCB> rightSp, String operand) {
                xcolqy(xcreateColumnQueryCB(), xcreateColumnQueryCB(), leftSpecifyQuery, rightSp, operand);
            });
        }

        protected VendorSelfReferenceCB xcreateColumnQueryCB() {
            VendorSelfReferenceCB cb = new VendorSelfReferenceCB();
            cb.xsetupForColumnQuery((VendorSelfReferenceCB)this);
            return cb;
        }

        // [DBFlute-0.8.9.9]
        // ===============================================================================
        //                                                                    OrScopeQuery
        //                                                                    ============
        public void OrScopeQuery(OrQuery<VendorSelfReferenceCB> orQuery) {
            xorQ((VendorSelfReferenceCB)this, orQuery);
        }

        // ===============================================================================
        //                                                                    Purpose Type
        //                                                                    ============
        public void xsetupForColumnQuery(VendorSelfReferenceCB mainCB) {
            xinheritSubQueryInfo(mainCB.LocalCQ);
            //xchangePurposeSqlClause(HpCBPurpose.COLUMN_QUERY);
            _forColumnQuery = true; // old style

            // inherits a parent query to synchronize real name
            // (and also for suppressing query check) 
            Specify().xsetSyncQyCall(new VendorSelfReferenceCBColQySpQyCall(mainCB));
        }
    }

    public class VendorSelfReferenceCBColQySpQyCall : HpSpQyCall<VendorSelfReferenceCQ> {
        protected VendorSelfReferenceCB _mainCB;
        public VendorSelfReferenceCBColQySpQyCall(VendorSelfReferenceCB mainCB) {
            _mainCB = mainCB;
        }
        public bool has() { return true; } 
        public VendorSelfReferenceCQ qy() { return _mainCB.Query(); } 
    }

    public class VendorSelfReferenceCBSpecification : AbstractSpecification<VendorSelfReferenceCQ> {
        protected VendorSelfReferenceCBSpecification _vendorSelfReferenceSelf;
        public VendorSelfReferenceCBSpecification(ConditionBean baseCB, HpSpQyCall<VendorSelfReferenceCQ> qyCall
                                                      , bool forDerivedReferrer, bool forScalarSelect, bool forScalarSubQuery, bool forColumnQuery)
        : base(baseCB, qyCall, forDerivedReferrer, forScalarSelect, forScalarSubQuery, forColumnQuery) { }
        public void ColumnSelfReferenceId() { doColumn("SELF_REFERENCE_ID"); }
        public void ColumnSelfReferenceName() { doColumn("SELF_REFERENCE_NAME"); }
        public void ColumnParentId() { doColumn("PARENT_ID"); }
        protected override void doSpecifyRequiredColumn() {
            ColumnSelfReferenceId(); // PK
            if (qyCall().qy().hasConditionQueryVendorSelfReferenceSelf()
                    || qyCall().qy().xgetReferrerQuery() is VendorSelfReferenceCQ) {
                ColumnParentId(); // FK or one-to-one referrer
            }
        }
        protected override String getTableDbName() { return "vendor_self_reference"; }
        public VendorSelfReferenceCBSpecification SpecifyVendorSelfReferenceSelf() {
            assertForeign("vendorSelfReferenceSelf");
            if (_vendorSelfReferenceSelf == null) {
                _vendorSelfReferenceSelf = new VendorSelfReferenceCBSpecification(_baseCB, new VendorSelfReferenceSelfSpQyCall(_qyCall), _forDerivedReferrer, _forScalarSelect, _forScalarCondition, _forColumnQuery);
                if (xhasSyncQyCall()) // inherits it
                { _vendorSelfReferenceSelf.xsetSyncQyCall(new VendorSelfReferenceSelfSpQyCall(xsyncQyCall())); }
            }
            return _vendorSelfReferenceSelf;
        }
		public class VendorSelfReferenceSelfSpQyCall : HpSpQyCall<VendorSelfReferenceCQ> {
		    protected HpSpQyCall<VendorSelfReferenceCQ> _qyCall;
		    public VendorSelfReferenceSelfSpQyCall(HpSpQyCall<VendorSelfReferenceCQ> myQyCall) { _qyCall = myQyCall; }
		    public bool has() { return _qyCall.has() && _qyCall.qy().hasConditionQueryVendorSelfReferenceSelf(); }
			public VendorSelfReferenceCQ qy() { return _qyCall.qy().QueryVendorSelfReferenceSelf(); }
		}
        public RAFunction<VendorSelfReferenceCB, VendorSelfReferenceCQ> DerivedVendorSelfReferenceSelfList() {
            if (xhasSyncQyCall()) { xsyncQyCall().qy(); } // for sync (for example, this in ColumnQuery)
            return new RAFunction<VendorSelfReferenceCB, VendorSelfReferenceCQ>(_baseCB, _qyCall.qy(), delegate(String function, SubQuery<VendorSelfReferenceCB> subQuery, VendorSelfReferenceCQ cq, String aliasName)
                { cq.xsderiveVendorSelfReferenceSelfList(function, subQuery, aliasName); });
        }
    }
}
