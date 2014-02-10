
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
    public class BsVdSynonymVendorTargetCB : AbstractConditionBean {

        // ===============================================================================
        //                                                                       Attribute
        //                                                                       =========
        protected VdSynonymVendorTargetCQ _conditionQuery;

        // ===============================================================================
        //                                                                      Table Name
        //                                                                      ==========
        public override String TableDbName { get { return "VD_SYNONYM_VENDOR_TARGET"; } }

        // ===============================================================================
        //                                                             PrimaryKey Handling
        //                                                             ===================
        public void AcceptPrimaryKey(long? vendorTargetId) {
            assertObjectNotNull("vendorTargetId", vendorTargetId);
            BsVdSynonymVendorTargetCB cb = this;
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
        public VdSynonymVendorTargetCQ Query() {
            return this.ConditionQuery;
        }

        public VdSynonymVendorTargetCQ ConditionQuery {
            get {
                if (_conditionQuery == null) {
                    _conditionQuery = CreateLocalCQ();
                }
                return _conditionQuery;
            }
        }

        protected virtual VdSynonymVendorTargetCQ CreateLocalCQ() {
            return xcreateCQ(null, this.SqlClause, this.SqlClause.getBasePointAliasName(), 0);
        }

        protected virtual VdSynonymVendorTargetCQ xcreateCQ(ConditionQuery childQuery, SqlClause sqlClause, String aliasName, int nestLevel) {
            return new VdSynonymVendorTargetCQ(childQuery, sqlClause, aliasName, nestLevel);
        }

        public override ConditionQuery LocalCQ {
            get { return this.ConditionQuery; }
        }

        // ===============================================================================
        //                                                                           Union
        //                                                                           =====
	    public virtual void Union(UnionQuery<VdSynonymVendorTargetCB> unionQuery) {
            VdSynonymVendorTargetCB cb = new VdSynonymVendorTargetCB();
            cb.xsetupForUnion(this); xsyncUQ(cb); unionQuery.Invoke(cb);
		    VdSynonymVendorTargetCQ cq = cb.Query(); Query().xsetUnionQuery(cq);
        }

	    public virtual void UnionAll(UnionQuery<VdSynonymVendorTargetCB> unionQuery) {
            VdSynonymVendorTargetCB cb = new VdSynonymVendorTargetCB();
            cb.xsetupForUnion(this); xsyncUQ(cb); unionQuery.Invoke(cb);
		    VdSynonymVendorTargetCQ cq = cb.Query(); Query().xsetUnionAllQuery(cq);
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
        protected VdSynonymVendorTargetCBSpecification _specification;
        public VdSynonymVendorTargetCBSpecification Specify() {
            if (_specification == null) { _specification = new VdSynonymVendorTargetCBSpecification(this, new MySpQyCall(this), _forDerivedReferrer, _forScalarSelect, _forScalarCondition, _forColumnQuery); }
            return _specification;
        }
        protected bool HasSpecifiedColumn { get {
            return _specification != null && _specification.IsAlreadySpecifiedRequiredColumn;
        }}
        protected class MySpQyCall : HpSpQyCall<VdSynonymVendorTargetCQ> {
			protected BsVdSynonymVendorTargetCB _myCB;
			public MySpQyCall(BsVdSynonymVendorTargetCB myCB) { _myCB = myCB; }
    		public bool has() { return true; } public VdSynonymVendorTargetCQ qy() { return _myCB.Query(); }
    	}

        // [DBFlute-0.8.9.18]
        // ===============================================================================
        //                                                                     ColumnQuery
        //                                                                     ===========
        public HpColQyOperand<VdSynonymVendorTargetCB> ColumnQuery(SpecifyQuery<VdSynonymVendorTargetCB> leftSpecifyQuery) {
            return new HpColQyOperand<VdSynonymVendorTargetCB>(delegate(SpecifyQuery<VdSynonymVendorTargetCB> rightSp, String operand) {
                xcolqy(xcreateColumnQueryCB(), xcreateColumnQueryCB(), leftSpecifyQuery, rightSp, operand);
            });
        }

        protected VdSynonymVendorTargetCB xcreateColumnQueryCB() {
            VdSynonymVendorTargetCB cb = new VdSynonymVendorTargetCB();
            cb.xsetupForColumnQuery((VdSynonymVendorTargetCB)this);
            return cb;
        }

        // [DBFlute-0.8.9.9]
        // ===============================================================================
        //                                                                    OrScopeQuery
        //                                                                    ============
        public void OrScopeQuery(OrQuery<VdSynonymVendorTargetCB> orQuery) {
            xorQ((VdSynonymVendorTargetCB)this, orQuery);
        }

        // ===============================================================================
        //                                                                    Purpose Type
        //                                                                    ============
        public void xsetupForColumnQuery(VdSynonymVendorTargetCB mainCB) {
            xinheritSubQueryInfo(mainCB.LocalCQ);
            //xchangePurposeSqlClause(HpCBPurpose.COLUMN_QUERY);
            _forColumnQuery = true; // old style

            // inherits a parent query to synchronize real name
            // (and also for suppressing query check) 
            Specify().xsetSyncQyCall(new VdSynonymVendorTargetCBColQySpQyCall(mainCB));
        }
    }

    public class VdSynonymVendorTargetCBColQySpQyCall : HpSpQyCall<VdSynonymVendorTargetCQ> {
        protected VdSynonymVendorTargetCB _mainCB;
        public VdSynonymVendorTargetCBColQySpQyCall(VdSynonymVendorTargetCB mainCB) {
            _mainCB = mainCB;
        }
        public bool has() { return true; } 
        public VdSynonymVendorTargetCQ qy() { return _mainCB.Query(); } 
    }

    public class VdSynonymVendorTargetCBSpecification : AbstractSpecification<VdSynonymVendorTargetCQ> {
        public VdSynonymVendorTargetCBSpecification(ConditionBean baseCB, HpSpQyCall<VdSynonymVendorTargetCQ> qyCall
                                                      , bool forDerivedReferrer, bool forScalarSelect, bool forScalarSubQuery, bool forColumnQuery)
        : base(baseCB, qyCall, forDerivedReferrer, forScalarSelect, forScalarSubQuery, forColumnQuery) { }
        public void ColumnVendorTargetId() { doColumn("VENDOR_TARGET_ID"); }
        public void ColumnVandorTargetName() { doColumn("VANDOR_TARGET_NAME"); }
        protected override void doSpecifyRequiredColumn() {
            ColumnVendorTargetId(); // PK
        }
        protected override String getTableDbName() { return "VD_SYNONYM_VENDOR_TARGET"; }
        public RAFunction<VdSynonymVendorRefTargetCB, VdSynonymVendorTargetCQ> DerivedVdSynonymVendorRefTargetList() {
            if (xhasSyncQyCall()) { xsyncQyCall().qy(); } // for sync (for example, this in ColumnQuery)
            return new RAFunction<VdSynonymVendorRefTargetCB, VdSynonymVendorTargetCQ>(_baseCB, _qyCall.qy(), delegate(String function, SubQuery<VdSynonymVendorRefTargetCB> subQuery, VdSynonymVendorTargetCQ cq, String aliasName)
                { cq.xsderiveVdSynonymVendorRefTargetList(function, subQuery, aliasName); });
        }
    }
}
