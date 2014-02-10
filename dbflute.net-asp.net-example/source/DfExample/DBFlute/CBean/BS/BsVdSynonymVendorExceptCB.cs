
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
    public class BsVdSynonymVendorExceptCB : AbstractConditionBean {

        // ===============================================================================
        //                                                                       Attribute
        //                                                                       =========
        protected VdSynonymVendorExceptCQ _conditionQuery;

        // ===============================================================================
        //                                                                      Table Name
        //                                                                      ==========
        public override String TableDbName { get { return "VD_SYNONYM_VENDOR_EXCEPT"; } }

        // ===============================================================================
        //                                                             PrimaryKey Handling
        //                                                             ===================
        public void AcceptPrimaryKey(long? vendorExceptId) {
            assertObjectNotNull("vendorExceptId", vendorExceptId);
            BsVdSynonymVendorExceptCB cb = this;
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
        public VdSynonymVendorExceptCQ Query() {
            return this.ConditionQuery;
        }

        public VdSynonymVendorExceptCQ ConditionQuery {
            get {
                if (_conditionQuery == null) {
                    _conditionQuery = CreateLocalCQ();
                }
                return _conditionQuery;
            }
        }

        protected virtual VdSynonymVendorExceptCQ CreateLocalCQ() {
            return xcreateCQ(null, this.SqlClause, this.SqlClause.getBasePointAliasName(), 0);
        }

        protected virtual VdSynonymVendorExceptCQ xcreateCQ(ConditionQuery childQuery, SqlClause sqlClause, String aliasName, int nestLevel) {
            return new VdSynonymVendorExceptCQ(childQuery, sqlClause, aliasName, nestLevel);
        }

        public override ConditionQuery LocalCQ {
            get { return this.ConditionQuery; }
        }

        // ===============================================================================
        //                                                                           Union
        //                                                                           =====
	    public virtual void Union(UnionQuery<VdSynonymVendorExceptCB> unionQuery) {
            VdSynonymVendorExceptCB cb = new VdSynonymVendorExceptCB();
            cb.xsetupForUnion(this); xsyncUQ(cb); unionQuery.Invoke(cb);
		    VdSynonymVendorExceptCQ cq = cb.Query(); Query().xsetUnionQuery(cq);
        }

	    public virtual void UnionAll(UnionQuery<VdSynonymVendorExceptCB> unionQuery) {
            VdSynonymVendorExceptCB cb = new VdSynonymVendorExceptCB();
            cb.xsetupForUnion(this); xsyncUQ(cb); unionQuery.Invoke(cb);
		    VdSynonymVendorExceptCQ cq = cb.Query(); Query().xsetUnionAllQuery(cq);
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
        protected VdSynonymVendorExceptCBSpecification _specification;
        public VdSynonymVendorExceptCBSpecification Specify() {
            if (_specification == null) { _specification = new VdSynonymVendorExceptCBSpecification(this, new MySpQyCall(this), _forDerivedReferrer, _forScalarSelect, _forScalarCondition, _forColumnQuery); }
            return _specification;
        }
        protected bool HasSpecifiedColumn { get {
            return _specification != null && _specification.IsAlreadySpecifiedRequiredColumn;
        }}
        protected class MySpQyCall : HpSpQyCall<VdSynonymVendorExceptCQ> {
			protected BsVdSynonymVendorExceptCB _myCB;
			public MySpQyCall(BsVdSynonymVendorExceptCB myCB) { _myCB = myCB; }
    		public bool has() { return true; } public VdSynonymVendorExceptCQ qy() { return _myCB.Query(); }
    	}

        // [DBFlute-0.8.9.18]
        // ===============================================================================
        //                                                                     ColumnQuery
        //                                                                     ===========
        public HpColQyOperand<VdSynonymVendorExceptCB> ColumnQuery(SpecifyQuery<VdSynonymVendorExceptCB> leftSpecifyQuery) {
            return new HpColQyOperand<VdSynonymVendorExceptCB>(delegate(SpecifyQuery<VdSynonymVendorExceptCB> rightSp, String operand) {
                xcolqy(xcreateColumnQueryCB(), xcreateColumnQueryCB(), leftSpecifyQuery, rightSp, operand);
            });
        }

        protected VdSynonymVendorExceptCB xcreateColumnQueryCB() {
            VdSynonymVendorExceptCB cb = new VdSynonymVendorExceptCB();
            cb.xsetupForColumnQuery((VdSynonymVendorExceptCB)this);
            return cb;
        }

        // [DBFlute-0.8.9.9]
        // ===============================================================================
        //                                                                    OrScopeQuery
        //                                                                    ============
        public void OrScopeQuery(OrQuery<VdSynonymVendorExceptCB> orQuery) {
            xorQ((VdSynonymVendorExceptCB)this, orQuery);
        }

        // ===============================================================================
        //                                                                    Purpose Type
        //                                                                    ============
        public void xsetupForColumnQuery(VdSynonymVendorExceptCB mainCB) {
            xinheritSubQueryInfo(mainCB.LocalCQ);
            //xchangePurposeSqlClause(HpCBPurpose.COLUMN_QUERY);
            _forColumnQuery = true; // old style

            // inherits a parent query to synchronize real name
            // (and also for suppressing query check) 
            Specify().xsetSyncQyCall(new VdSynonymVendorExceptCBColQySpQyCall(mainCB));
        }
    }

    public class VdSynonymVendorExceptCBColQySpQyCall : HpSpQyCall<VdSynonymVendorExceptCQ> {
        protected VdSynonymVendorExceptCB _mainCB;
        public VdSynonymVendorExceptCBColQySpQyCall(VdSynonymVendorExceptCB mainCB) {
            _mainCB = mainCB;
        }
        public bool has() { return true; } 
        public VdSynonymVendorExceptCQ qy() { return _mainCB.Query(); } 
    }

    public class VdSynonymVendorExceptCBSpecification : AbstractSpecification<VdSynonymVendorExceptCQ> {
        public VdSynonymVendorExceptCBSpecification(ConditionBean baseCB, HpSpQyCall<VdSynonymVendorExceptCQ> qyCall
                                                      , bool forDerivedReferrer, bool forScalarSelect, bool forScalarSubQuery, bool forColumnQuery)
        : base(baseCB, qyCall, forDerivedReferrer, forScalarSelect, forScalarSubQuery, forColumnQuery) { }
        public void ColumnVendorExceptId() { doColumn("VENDOR_EXCEPT_ID"); }
        public void ColumnVandorExceptName() { doColumn("VANDOR_EXCEPT_NAME"); }
        protected override void doSpecifyRequiredColumn() {
            ColumnVendorExceptId(); // PK
        }
        protected override String getTableDbName() { return "VD_SYNONYM_VENDOR_EXCEPT"; }
        public RAFunction<VdSynonymVendorRefExceptCB, VdSynonymVendorExceptCQ> DerivedVdSynonymVendorRefExceptList() {
            if (xhasSyncQyCall()) { xsyncQyCall().qy(); } // for sync (for example, this in ColumnQuery)
            return new RAFunction<VdSynonymVendorRefExceptCB, VdSynonymVendorExceptCQ>(_baseCB, _qyCall.qy(), delegate(String function, SubQuery<VdSynonymVendorRefExceptCB> subQuery, VdSynonymVendorExceptCQ cq, String aliasName)
                { cq.xsderiveVdSynonymVendorRefExceptList(function, subQuery, aliasName); });
        }
    }
}
