
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
    public class BsVendorRefExceptCB : AbstractConditionBean {

        // ===============================================================================
        //                                                                       Attribute
        //                                                                       =========
        protected VendorRefExceptCQ _conditionQuery;

        // ===============================================================================
        //                                                                      Table Name
        //                                                                      ==========
        public override String TableDbName { get { return "VENDOR_REF_EXCEPT"; } }

        // ===============================================================================
        //                                                             PrimaryKey Handling
        //                                                             ===================
        public void AcceptPrimaryKey(long? vendorRefExceptId) {
            assertObjectNotNull("vendorRefExceptId", vendorRefExceptId);
            BsVendorRefExceptCB cb = this;
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
        public VendorRefExceptCQ Query() {
            return this.ConditionQuery;
        }

        public VendorRefExceptCQ ConditionQuery {
            get {
                if (_conditionQuery == null) {
                    _conditionQuery = CreateLocalCQ();
                }
                return _conditionQuery;
            }
        }

        protected virtual VendorRefExceptCQ CreateLocalCQ() {
            return xcreateCQ(null, this.SqlClause, this.SqlClause.getBasePointAliasName(), 0);
        }

        protected virtual VendorRefExceptCQ xcreateCQ(ConditionQuery childQuery, SqlClause sqlClause, String aliasName, int nestLevel) {
            return new VendorRefExceptCQ(childQuery, sqlClause, aliasName, nestLevel);
        }

        public override ConditionQuery LocalCQ {
            get { return this.ConditionQuery; }
        }

        // ===============================================================================
        //                                                                           Union
        //                                                                           =====
	    public virtual void Union(UnionQuery<VendorRefExceptCB> unionQuery) {
            VendorRefExceptCB cb = new VendorRefExceptCB();
            cb.xsetupForUnion(this); xsyncUQ(cb); unionQuery.Invoke(cb);
		    VendorRefExceptCQ cq = cb.Query(); Query().xsetUnionQuery(cq);
        }

	    public virtual void UnionAll(UnionQuery<VendorRefExceptCB> unionQuery) {
            VendorRefExceptCB cb = new VendorRefExceptCB();
            cb.xsetupForUnion(this); xsyncUQ(cb); unionQuery.Invoke(cb);
		    VendorRefExceptCQ cq = cb.Query(); Query().xsetUnionAllQuery(cq);
	    }

        public override bool HasUnionQueryOrUnionAllQuery() {
            return Query().hasUnionQueryOrUnionAllQuery();
        }

        // ===============================================================================
        //                                                                    Setup Select
        //                                                                    ============
        protected VendorExceptNss _nssVendorExcept;
        public VendorExceptNss NssVendorExcept { get {
            if (_nssVendorExcept == null) { _nssVendorExcept = new VendorExceptNss(null); }
            return _nssVendorExcept;
        }}
        public VendorExceptNss SetupSelect_VendorExcept() {
            if (HasSpecifiedColumn) { // if reverse call
                Specify().ColumnVendorExceptId();
            }
            doSetupSelect(delegate { return Query().QueryVendorExcept(); });
            if (_nssVendorExcept == null || !_nssVendorExcept.HasConditionQuery)
            { _nssVendorExcept = new VendorExceptNss(Query().QueryVendorExcept()); }
            return _nssVendorExcept;
        }

        // [DBFlute-0.7.4]
        // ===============================================================================
        //                                                                         Specify
        //                                                                         =======
        protected VendorRefExceptCBSpecification _specification;
        public VendorRefExceptCBSpecification Specify() {
            if (_specification == null) { _specification = new VendorRefExceptCBSpecification(this, new MySpQyCall(this), _forDerivedReferrer, _forScalarSelect, _forScalarCondition, _forColumnQuery); }
            return _specification;
        }
        protected bool HasSpecifiedColumn { get {
            return _specification != null && _specification.IsAlreadySpecifiedRequiredColumn;
        }}
        protected class MySpQyCall : HpSpQyCall<VendorRefExceptCQ> {
			protected BsVendorRefExceptCB _myCB;
			public MySpQyCall(BsVendorRefExceptCB myCB) { _myCB = myCB; }
    		public bool has() { return true; } public VendorRefExceptCQ qy() { return _myCB.Query(); }
    	}

        // [DBFlute-0.8.9.18]
        // ===============================================================================
        //                                                                     ColumnQuery
        //                                                                     ===========
        public HpColQyOperand<VendorRefExceptCB> ColumnQuery(SpecifyQuery<VendorRefExceptCB> leftSpecifyQuery) {
            return new HpColQyOperand<VendorRefExceptCB>(delegate(SpecifyQuery<VendorRefExceptCB> rightSp, String operand) {
                xcolqy(xcreateColumnQueryCB(), xcreateColumnQueryCB(), leftSpecifyQuery, rightSp, operand);
            });
        }

        protected VendorRefExceptCB xcreateColumnQueryCB() {
            VendorRefExceptCB cb = new VendorRefExceptCB();
            cb.xsetupForColumnQuery((VendorRefExceptCB)this);
            return cb;
        }

        // [DBFlute-0.8.9.9]
        // ===============================================================================
        //                                                                    OrScopeQuery
        //                                                                    ============
        public void OrScopeQuery(OrQuery<VendorRefExceptCB> orQuery) {
            xorQ((VendorRefExceptCB)this, orQuery);
        }

        // ===============================================================================
        //                                                                    Purpose Type
        //                                                                    ============
        public void xsetupForColumnQuery(VendorRefExceptCB mainCB) {
            xinheritSubQueryInfo(mainCB.LocalCQ);
            //xchangePurposeSqlClause(HpCBPurpose.COLUMN_QUERY);
            _forColumnQuery = true; // old style

            // inherits a parent query to synchronize real name
            // (and also for suppressing query check) 
            Specify().xsetSyncQyCall(new VendorRefExceptCBColQySpQyCall(mainCB));
        }
    }

    public class VendorRefExceptCBColQySpQyCall : HpSpQyCall<VendorRefExceptCQ> {
        protected VendorRefExceptCB _mainCB;
        public VendorRefExceptCBColQySpQyCall(VendorRefExceptCB mainCB) {
            _mainCB = mainCB;
        }
        public bool has() { return true; } 
        public VendorRefExceptCQ qy() { return _mainCB.Query(); } 
    }

    public class VendorRefExceptCBSpecification : AbstractSpecification<VendorRefExceptCQ> {
        protected VendorExceptCBSpecification _vendorExcept;
        public VendorRefExceptCBSpecification(ConditionBean baseCB, HpSpQyCall<VendorRefExceptCQ> qyCall
                                                      , bool forDerivedReferrer, bool forScalarSelect, bool forScalarSubQuery, bool forColumnQuery)
        : base(baseCB, qyCall, forDerivedReferrer, forScalarSelect, forScalarSubQuery, forColumnQuery) { }
        public void ColumnVendorRefExceptId() { doColumn("VENDOR_REF_EXCEPT_ID"); }
        public void ColumnVendorExceptId() { doColumn("VENDOR_EXCEPT_ID"); }
        protected override void doSpecifyRequiredColumn() {
            ColumnVendorRefExceptId(); // PK
            if (qyCall().qy().hasConditionQueryVendorExcept()
                    || qyCall().qy().xgetReferrerQuery() is VendorExceptCQ) {
                ColumnVendorExceptId(); // FK or one-to-one referrer
            }
        }
        protected override String getTableDbName() { return "VENDOR_REF_EXCEPT"; }
        public VendorExceptCBSpecification SpecifyVendorExcept() {
            assertForeign("vendorExcept");
            if (_vendorExcept == null) {
                _vendorExcept = new VendorExceptCBSpecification(_baseCB, new VendorExceptSpQyCall(_qyCall), _forDerivedReferrer, _forScalarSelect, _forScalarCondition, _forColumnQuery);
                if (xhasSyncQyCall()) // inherits it
                { _vendorExcept.xsetSyncQyCall(new VendorExceptSpQyCall(xsyncQyCall())); }
            }
            return _vendorExcept;
        }
		public class VendorExceptSpQyCall : HpSpQyCall<VendorExceptCQ> {
		    protected HpSpQyCall<VendorRefExceptCQ> _qyCall;
		    public VendorExceptSpQyCall(HpSpQyCall<VendorRefExceptCQ> myQyCall) { _qyCall = myQyCall; }
		    public bool has() { return _qyCall.has() && _qyCall.qy().hasConditionQueryVendorExcept(); }
			public VendorExceptCQ qy() { return _qyCall.qy().QueryVendorExcept(); }
		}
    }
}
