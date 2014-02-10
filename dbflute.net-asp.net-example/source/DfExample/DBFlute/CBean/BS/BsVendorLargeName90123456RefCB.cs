
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
    public class BsVendorLargeName90123456RefCB : AbstractConditionBean {

        // ===============================================================================
        //                                                                       Attribute
        //                                                                       =========
        protected VendorLargeName90123456RefCQ _conditionQuery;

        // ===============================================================================
        //                                                                      Table Name
        //                                                                      ==========
        public override String TableDbName { get { return "VENDOR_LARGE_NAME_90123456_REF"; } }

        // ===============================================================================
        //                                                             PrimaryKey Handling
        //                                                             ===================
        public void AcceptPrimaryKey(long? vendorLargeName90123RefId) {
            assertObjectNotNull("vendorLargeName90123RefId", vendorLargeName90123RefId);
            BsVendorLargeName90123456RefCB cb = this;
            cb.Query().SetVendorLargeName90123RefId_Equal(vendorLargeName90123RefId);
        }

        public override ConditionBean AddOrderBy_PK_Asc() {
            Query().AddOrderBy_VendorLargeName90123RefId_Asc();
            return this;
        }

        public override ConditionBean AddOrderBy_PK_Desc() {
            Query().AddOrderBy_VendorLargeName90123RefId_Desc();
            return this;
        }

        // ===============================================================================
        //                                                                           Query
        //                                                                           =====
        public VendorLargeName90123456RefCQ Query() {
            return this.ConditionQuery;
        }

        public VendorLargeName90123456RefCQ ConditionQuery {
            get {
                if (_conditionQuery == null) {
                    _conditionQuery = CreateLocalCQ();
                }
                return _conditionQuery;
            }
        }

        protected virtual VendorLargeName90123456RefCQ CreateLocalCQ() {
            return xcreateCQ(null, this.SqlClause, this.SqlClause.getBasePointAliasName(), 0);
        }

        protected virtual VendorLargeName90123456RefCQ xcreateCQ(ConditionQuery childQuery, SqlClause sqlClause, String aliasName, int nestLevel) {
            return new VendorLargeName90123456RefCQ(childQuery, sqlClause, aliasName, nestLevel);
        }

        public override ConditionQuery LocalCQ {
            get { return this.ConditionQuery; }
        }

        // ===============================================================================
        //                                                                           Union
        //                                                                           =====
	    public virtual void Union(UnionQuery<VendorLargeName90123456RefCB> unionQuery) {
            VendorLargeName90123456RefCB cb = new VendorLargeName90123456RefCB();
            cb.xsetupForUnion(this); xsyncUQ(cb); unionQuery.Invoke(cb);
		    VendorLargeName90123456RefCQ cq = cb.Query(); Query().xsetUnionQuery(cq);
        }

	    public virtual void UnionAll(UnionQuery<VendorLargeName90123456RefCB> unionQuery) {
            VendorLargeName90123456RefCB cb = new VendorLargeName90123456RefCB();
            cb.xsetupForUnion(this); xsyncUQ(cb); unionQuery.Invoke(cb);
		    VendorLargeName90123456RefCQ cq = cb.Query(); Query().xsetUnionAllQuery(cq);
	    }

        public override bool HasUnionQueryOrUnionAllQuery() {
            return Query().hasUnionQueryOrUnionAllQuery();
        }

        // ===============================================================================
        //                                                                    Setup Select
        //                                                                    ============
        protected VendorLargeName901234567890Nss _nssVendorLargeName901234567890;
        public VendorLargeName901234567890Nss NssVendorLargeName901234567890 { get {
            if (_nssVendorLargeName901234567890 == null) { _nssVendorLargeName901234567890 = new VendorLargeName901234567890Nss(null); }
            return _nssVendorLargeName901234567890;
        }}
        public VendorLargeName901234567890Nss SetupSelect_VendorLargeName901234567890() {
            if (HasSpecifiedColumn) { // if reverse call
                Specify().ColumnVendorLargeName901234567Id();
            }
            doSetupSelect(delegate { return Query().QueryVendorLargeName901234567890(); });
            if (_nssVendorLargeName901234567890 == null || !_nssVendorLargeName901234567890.HasConditionQuery)
            { _nssVendorLargeName901234567890 = new VendorLargeName901234567890Nss(Query().QueryVendorLargeName901234567890()); }
            return _nssVendorLargeName901234567890;
        }

        // [DBFlute-0.7.4]
        // ===============================================================================
        //                                                                         Specify
        //                                                                         =======
        protected VendorLargeName90123456RefCBSpecification _specification;
        public VendorLargeName90123456RefCBSpecification Specify() {
            if (_specification == null) { _specification = new VendorLargeName90123456RefCBSpecification(this, new MySpQyCall(this), _forDerivedReferrer, _forScalarSelect, _forScalarCondition, _forColumnQuery); }
            return _specification;
        }
        protected bool HasSpecifiedColumn { get {
            return _specification != null && _specification.IsAlreadySpecifiedRequiredColumn;
        }}
        protected class MySpQyCall : HpSpQyCall<VendorLargeName90123456RefCQ> {
			protected BsVendorLargeName90123456RefCB _myCB;
			public MySpQyCall(BsVendorLargeName90123456RefCB myCB) { _myCB = myCB; }
    		public bool has() { return true; } public VendorLargeName90123456RefCQ qy() { return _myCB.Query(); }
    	}

        // [DBFlute-0.8.9.18]
        // ===============================================================================
        //                                                                     ColumnQuery
        //                                                                     ===========
        public HpColQyOperand<VendorLargeName90123456RefCB> ColumnQuery(SpecifyQuery<VendorLargeName90123456RefCB> leftSpecifyQuery) {
            return new HpColQyOperand<VendorLargeName90123456RefCB>(delegate(SpecifyQuery<VendorLargeName90123456RefCB> rightSp, String operand) {
                xcolqy(xcreateColumnQueryCB(), xcreateColumnQueryCB(), leftSpecifyQuery, rightSp, operand);
            });
        }

        protected VendorLargeName90123456RefCB xcreateColumnQueryCB() {
            VendorLargeName90123456RefCB cb = new VendorLargeName90123456RefCB();
            cb.xsetupForColumnQuery((VendorLargeName90123456RefCB)this);
            return cb;
        }

        // [DBFlute-0.8.9.9]
        // ===============================================================================
        //                                                                    OrScopeQuery
        //                                                                    ============
        public void OrScopeQuery(OrQuery<VendorLargeName90123456RefCB> orQuery) {
            xorQ((VendorLargeName90123456RefCB)this, orQuery);
        }

        // ===============================================================================
        //                                                                    Purpose Type
        //                                                                    ============
        public void xsetupForColumnQuery(VendorLargeName90123456RefCB mainCB) {
            xinheritSubQueryInfo(mainCB.LocalCQ);
            //xchangePurposeSqlClause(HpCBPurpose.COLUMN_QUERY);
            _forColumnQuery = true; // old style

            // inherits a parent query to synchronize real name
            // (and also for suppressing query check) 
            Specify().xsetSyncQyCall(new VendorLargeName90123456RefCBColQySpQyCall(mainCB));
        }
    }

    public class VendorLargeName90123456RefCBColQySpQyCall : HpSpQyCall<VendorLargeName90123456RefCQ> {
        protected VendorLargeName90123456RefCB _mainCB;
        public VendorLargeName90123456RefCBColQySpQyCall(VendorLargeName90123456RefCB mainCB) {
            _mainCB = mainCB;
        }
        public bool has() { return true; } 
        public VendorLargeName90123456RefCQ qy() { return _mainCB.Query(); } 
    }

    public class VendorLargeName90123456RefCBSpecification : AbstractSpecification<VendorLargeName90123456RefCQ> {
        protected VendorLargeName901234567890CBSpecification _vendorLargeName901234567890;
        public VendorLargeName90123456RefCBSpecification(ConditionBean baseCB, HpSpQyCall<VendorLargeName90123456RefCQ> qyCall
                                                      , bool forDerivedReferrer, bool forScalarSelect, bool forScalarSubQuery, bool forColumnQuery)
        : base(baseCB, qyCall, forDerivedReferrer, forScalarSelect, forScalarSubQuery, forColumnQuery) { }
        public void ColumnVendorLargeName90123RefId() { doColumn("VENDOR_LARGE_NAME_90123_REF_ID"); }
        public void ColumnVendorLargeName901RefName() { doColumn("VENDOR_LARGE_NAME_901_REF_NAME"); }
        public void ColumnVendorLargeName901234567Id() { doColumn("VENDOR_LARGE_NAME_901234567_ID"); }
        protected override void doSpecifyRequiredColumn() {
            ColumnVendorLargeName90123RefId(); // PK
            if (qyCall().qy().hasConditionQueryVendorLargeName901234567890()
                    || qyCall().qy().xgetReferrerQuery() is VendorLargeName901234567890CQ) {
                ColumnVendorLargeName901234567Id(); // FK or one-to-one referrer
            }
        }
        protected override String getTableDbName() { return "VENDOR_LARGE_NAME_90123456_REF"; }
        public VendorLargeName901234567890CBSpecification SpecifyVendorLargeName901234567890() {
            assertForeign("vendorLargeName901234567890");
            if (_vendorLargeName901234567890 == null) {
                _vendorLargeName901234567890 = new VendorLargeName901234567890CBSpecification(_baseCB, new VendorLargeName901234567890SpQyCall(_qyCall), _forDerivedReferrer, _forScalarSelect, _forScalarCondition, _forColumnQuery);
                if (xhasSyncQyCall()) // inherits it
                { _vendorLargeName901234567890.xsetSyncQyCall(new VendorLargeName901234567890SpQyCall(xsyncQyCall())); }
            }
            return _vendorLargeName901234567890;
        }
		public class VendorLargeName901234567890SpQyCall : HpSpQyCall<VendorLargeName901234567890CQ> {
		    protected HpSpQyCall<VendorLargeName90123456RefCQ> _qyCall;
		    public VendorLargeName901234567890SpQyCall(HpSpQyCall<VendorLargeName90123456RefCQ> myQyCall) { _qyCall = myQyCall; }
		    public bool has() { return _qyCall.has() && _qyCall.qy().hasConditionQueryVendorLargeName901234567890(); }
			public VendorLargeName901234567890CQ qy() { return _qyCall.qy().QueryVendorLargeName901234567890(); }
		}
    }
}
