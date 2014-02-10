
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
    public class BsVdSynonymVendorRefExceptCB : AbstractConditionBean {

        // ===============================================================================
        //                                                                       Attribute
        //                                                                       =========
        protected VdSynonymVendorRefExceptCQ _conditionQuery;

        // ===============================================================================
        //                                                                      Table Name
        //                                                                      ==========
        public override String TableDbName { get { return "VD_SYNONYM_VENDOR_REF_EXCEPT"; } }

        // ===============================================================================
        //                                                             PrimaryKey Handling
        //                                                             ===================
        public void AcceptPrimaryKey(long? vendorRefExceptId) {
            assertObjectNotNull("vendorRefExceptId", vendorRefExceptId);
            BsVdSynonymVendorRefExceptCB cb = this;
            cb.Query().SetVendorRefExceptId_Equal(vendorRefExceptId);
        }

        public override ConditionBean AddOrderBy_PK_Asc() {
            Query().AddOrderBy_VendorRefExceptId_Asc();
            return this;
        }

        public override ConditionBean AddOrderBy_PK_Desc() {
            Query().AddOrderBy_VendorRefExceptId_Desc();
            return this;
        }

        // ===============================================================================
        //                                                                           Query
        //                                                                           =====
        public VdSynonymVendorRefExceptCQ Query() {
            return this.ConditionQuery;
        }

        public VdSynonymVendorRefExceptCQ ConditionQuery {
            get {
                if (_conditionQuery == null) {
                    _conditionQuery = CreateLocalCQ();
                }
                return _conditionQuery;
            }
        }

        protected virtual VdSynonymVendorRefExceptCQ CreateLocalCQ() {
            return xcreateCQ(null, this.SqlClause, this.SqlClause.getBasePointAliasName(), 0);
        }

        protected virtual VdSynonymVendorRefExceptCQ xcreateCQ(ConditionQuery childQuery, SqlClause sqlClause, String aliasName, int nestLevel) {
            return new VdSynonymVendorRefExceptCQ(childQuery, sqlClause, aliasName, nestLevel);
        }

        public override ConditionQuery LocalCQ {
            get { return this.ConditionQuery; }
        }

        // ===============================================================================
        //                                                                           Union
        //                                                                           =====
	    public virtual void Union(UnionQuery<VdSynonymVendorRefExceptCB> unionQuery) {
            VdSynonymVendorRefExceptCB cb = new VdSynonymVendorRefExceptCB();
            cb.xsetupForUnion(this); xsyncUQ(cb); unionQuery.Invoke(cb);
		    VdSynonymVendorRefExceptCQ cq = cb.Query(); Query().xsetUnionQuery(cq);
        }

	    public virtual void UnionAll(UnionQuery<VdSynonymVendorRefExceptCB> unionQuery) {
            VdSynonymVendorRefExceptCB cb = new VdSynonymVendorRefExceptCB();
            cb.xsetupForUnion(this); xsyncUQ(cb); unionQuery.Invoke(cb);
		    VdSynonymVendorRefExceptCQ cq = cb.Query(); Query().xsetUnionAllQuery(cq);
	    }

        public override bool HasUnionQueryOrUnionAllQuery() {
            return Query().hasUnionQueryOrUnionAllQuery();
        }

        // ===============================================================================
        //                                                                    Setup Select
        //                                                                    ============
        protected VdSynonymVendorExceptNss _nssVdSynonymVendorExcept;
        public VdSynonymVendorExceptNss NssVdSynonymVendorExcept { get {
            if (_nssVdSynonymVendorExcept == null) { _nssVdSynonymVendorExcept = new VdSynonymVendorExceptNss(null); }
            return _nssVdSynonymVendorExcept;
        }}
        public VdSynonymVendorExceptNss SetupSelect_VdSynonymVendorExcept() {
            if (HasSpecifiedColumn) { // if reverse call
                Specify().ColumnVendorExceptId();
            }
            doSetupSelect(delegate { return Query().QueryVdSynonymVendorExcept(); });
            if (_nssVdSynonymVendorExcept == null || !_nssVdSynonymVendorExcept.HasConditionQuery)
            { _nssVdSynonymVendorExcept = new VdSynonymVendorExceptNss(Query().QueryVdSynonymVendorExcept()); }
            return _nssVdSynonymVendorExcept;
        }

        // [DBFlute-0.7.4]
        // ===============================================================================
        //                                                                         Specify
        //                                                                         =======
        protected VdSynonymVendorRefExceptCBSpecification _specification;
        public VdSynonymVendorRefExceptCBSpecification Specify() {
            if (_specification == null) { _specification = new VdSynonymVendorRefExceptCBSpecification(this, new MySpQyCall(this), _forDerivedReferrer, _forScalarSelect, _forScalarCondition, _forColumnQuery); }
            return _specification;
        }
        protected bool HasSpecifiedColumn { get {
            return _specification != null && _specification.IsAlreadySpecifiedRequiredColumn;
        }}
        protected class MySpQyCall : HpSpQyCall<VdSynonymVendorRefExceptCQ> {
			protected BsVdSynonymVendorRefExceptCB _myCB;
			public MySpQyCall(BsVdSynonymVendorRefExceptCB myCB) { _myCB = myCB; }
    		public bool has() { return true; } public VdSynonymVendorRefExceptCQ qy() { return _myCB.Query(); }
    	}

        // [DBFlute-0.8.9.18]
        // ===============================================================================
        //                                                                     ColumnQuery
        //                                                                     ===========
        public HpColQyOperand<VdSynonymVendorRefExceptCB> ColumnQuery(SpecifyQuery<VdSynonymVendorRefExceptCB> leftSpecifyQuery) {
            return new HpColQyOperand<VdSynonymVendorRefExceptCB>(delegate(SpecifyQuery<VdSynonymVendorRefExceptCB> rightSp, String operand) {
                xcolqy(xcreateColumnQueryCB(), xcreateColumnQueryCB(), leftSpecifyQuery, rightSp, operand);
            });
        }

        protected VdSynonymVendorRefExceptCB xcreateColumnQueryCB() {
            VdSynonymVendorRefExceptCB cb = new VdSynonymVendorRefExceptCB();
            cb.xsetupForColumnQuery((VdSynonymVendorRefExceptCB)this);
            return cb;
        }

        // [DBFlute-0.8.9.9]
        // ===============================================================================
        //                                                                    OrScopeQuery
        //                                                                    ============
        public void OrScopeQuery(OrQuery<VdSynonymVendorRefExceptCB> orQuery) {
            xorQ((VdSynonymVendorRefExceptCB)this, orQuery);
        }

        // ===============================================================================
        //                                                                    Purpose Type
        //                                                                    ============
        public void xsetupForColumnQuery(VdSynonymVendorRefExceptCB mainCB) {
            xinheritSubQueryInfo(mainCB.LocalCQ);
            //xchangePurposeSqlClause(HpCBPurpose.COLUMN_QUERY);
            _forColumnQuery = true; // old style

            // inherits a parent query to synchronize real name
            // (and also for suppressing query check) 
            Specify().xsetSyncQyCall(new VdSynonymVendorRefExceptCBColQySpQyCall(mainCB));
        }
    }

    public class VdSynonymVendorRefExceptCBColQySpQyCall : HpSpQyCall<VdSynonymVendorRefExceptCQ> {
        protected VdSynonymVendorRefExceptCB _mainCB;
        public VdSynonymVendorRefExceptCBColQySpQyCall(VdSynonymVendorRefExceptCB mainCB) {
            _mainCB = mainCB;
        }
        public bool has() { return true; } 
        public VdSynonymVendorRefExceptCQ qy() { return _mainCB.Query(); } 
    }

    public class VdSynonymVendorRefExceptCBSpecification : AbstractSpecification<VdSynonymVendorRefExceptCQ> {
        protected VdSynonymVendorExceptCBSpecification _vdSynonymVendorExcept;
        public VdSynonymVendorRefExceptCBSpecification(ConditionBean baseCB, HpSpQyCall<VdSynonymVendorRefExceptCQ> qyCall
                                                      , bool forDerivedReferrer, bool forScalarSelect, bool forScalarSubQuery, bool forColumnQuery)
        : base(baseCB, qyCall, forDerivedReferrer, forScalarSelect, forScalarSubQuery, forColumnQuery) { }
        public void ColumnVendorRefExceptId() { doColumn("VENDOR_REF_EXCEPT_ID"); }
        public void ColumnVendorExceptId() { doColumn("VENDOR_EXCEPT_ID"); }
        protected override void doSpecifyRequiredColumn() {
            ColumnVendorRefExceptId(); // PK
            if (qyCall().qy().hasConditionQueryVdSynonymVendorExcept()
                    || qyCall().qy().xgetReferrerQuery() is VdSynonymVendorExceptCQ) {
                ColumnVendorExceptId(); // FK or one-to-one referrer
            }
        }
        protected override String getTableDbName() { return "VD_SYNONYM_VENDOR_REF_EXCEPT"; }
        public VdSynonymVendorExceptCBSpecification SpecifyVdSynonymVendorExcept() {
            assertForeign("vdSynonymVendorExcept");
            if (_vdSynonymVendorExcept == null) {
                _vdSynonymVendorExcept = new VdSynonymVendorExceptCBSpecification(_baseCB, new VdSynonymVendorExceptSpQyCall(_qyCall), _forDerivedReferrer, _forScalarSelect, _forScalarCondition, _forColumnQuery);
                if (xhasSyncQyCall()) // inherits it
                { _vdSynonymVendorExcept.xsetSyncQyCall(new VdSynonymVendorExceptSpQyCall(xsyncQyCall())); }
            }
            return _vdSynonymVendorExcept;
        }
		public class VdSynonymVendorExceptSpQyCall : HpSpQyCall<VdSynonymVendorExceptCQ> {
		    protected HpSpQyCall<VdSynonymVendorRefExceptCQ> _qyCall;
		    public VdSynonymVendorExceptSpQyCall(HpSpQyCall<VdSynonymVendorRefExceptCQ> myQyCall) { _qyCall = myQyCall; }
		    public bool has() { return _qyCall.has() && _qyCall.qy().hasConditionQueryVdSynonymVendorExcept(); }
			public VdSynonymVendorExceptCQ qy() { return _qyCall.qy().QueryVdSynonymVendorExcept(); }
		}
    }
}
