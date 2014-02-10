
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
    public class BsVendorLargeName901234567890CB : AbstractConditionBean {

        // ===============================================================================
        //                                                                       Attribute
        //                                                                       =========
        protected VendorLargeName901234567890CQ _conditionQuery;

        // ===============================================================================
        //                                                                      Table Name
        //                                                                      ==========
        public override String TableDbName { get { return "VENDOR_LARGE_NAME_901234567890"; } }

        // ===============================================================================
        //                                                             PrimaryKey Handling
        //                                                             ===================
        public void AcceptPrimaryKey(long? vendorLargeName901234567Id) {
            assertObjectNotNull("vendorLargeName901234567Id", vendorLargeName901234567Id);
            BsVendorLargeName901234567890CB cb = this;
            cb.Query().SetVendorLargeName901234567Id_Equal(vendorLargeName901234567Id);
        }

        public override ConditionBean AddOrderBy_PK_Asc() {
            Query().AddOrderBy_VendorLargeName901234567Id_Asc();
            return this;
        }

        public override ConditionBean AddOrderBy_PK_Desc() {
            Query().AddOrderBy_VendorLargeName901234567Id_Desc();
            return this;
        }

        // ===============================================================================
        //                                                                           Query
        //                                                                           =====
        public VendorLargeName901234567890CQ Query() {
            return this.ConditionQuery;
        }

        public VendorLargeName901234567890CQ ConditionQuery {
            get {
                if (_conditionQuery == null) {
                    _conditionQuery = CreateLocalCQ();
                }
                return _conditionQuery;
            }
        }

        protected virtual VendorLargeName901234567890CQ CreateLocalCQ() {
            return xcreateCQ(null, this.SqlClause, this.SqlClause.getBasePointAliasName(), 0);
        }

        protected virtual VendorLargeName901234567890CQ xcreateCQ(ConditionQuery childQuery, SqlClause sqlClause, String aliasName, int nestLevel) {
            return new VendorLargeName901234567890CQ(childQuery, sqlClause, aliasName, nestLevel);
        }

        public override ConditionQuery LocalCQ {
            get { return this.ConditionQuery; }
        }

        // ===============================================================================
        //                                                                           Union
        //                                                                           =====
	    public virtual void Union(UnionQuery<VendorLargeName901234567890CB> unionQuery) {
            VendorLargeName901234567890CB cb = new VendorLargeName901234567890CB();
            cb.xsetupForUnion(this); xsyncUQ(cb); unionQuery.Invoke(cb);
		    VendorLargeName901234567890CQ cq = cb.Query(); Query().xsetUnionQuery(cq);
        }

	    public virtual void UnionAll(UnionQuery<VendorLargeName901234567890CB> unionQuery) {
            VendorLargeName901234567890CB cb = new VendorLargeName901234567890CB();
            cb.xsetupForUnion(this); xsyncUQ(cb); unionQuery.Invoke(cb);
		    VendorLargeName901234567890CQ cq = cb.Query(); Query().xsetUnionAllQuery(cq);
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
        protected VendorLargeName901234567890CBSpecification _specification;
        public VendorLargeName901234567890CBSpecification Specify() {
            if (_specification == null) { _specification = new VendorLargeName901234567890CBSpecification(this, new MySpQyCall(this), _forDerivedReferrer, _forScalarSelect, _forScalarCondition, _forColumnQuery); }
            return _specification;
        }
        protected bool HasSpecifiedColumn { get {
            return _specification != null && _specification.IsAlreadySpecifiedRequiredColumn;
        }}
        protected class MySpQyCall : HpSpQyCall<VendorLargeName901234567890CQ> {
			protected BsVendorLargeName901234567890CB _myCB;
			public MySpQyCall(BsVendorLargeName901234567890CB myCB) { _myCB = myCB; }
    		public bool has() { return true; } public VendorLargeName901234567890CQ qy() { return _myCB.Query(); }
    	}

        // [DBFlute-0.8.9.18]
        // ===============================================================================
        //                                                                     ColumnQuery
        //                                                                     ===========
        public HpColQyOperand<VendorLargeName901234567890CB> ColumnQuery(SpecifyQuery<VendorLargeName901234567890CB> leftSpecifyQuery) {
            return new HpColQyOperand<VendorLargeName901234567890CB>(delegate(SpecifyQuery<VendorLargeName901234567890CB> rightSp, String operand) {
                xcolqy(xcreateColumnQueryCB(), xcreateColumnQueryCB(), leftSpecifyQuery, rightSp, operand);
            });
        }

        protected VendorLargeName901234567890CB xcreateColumnQueryCB() {
            VendorLargeName901234567890CB cb = new VendorLargeName901234567890CB();
            cb.xsetupForColumnQuery((VendorLargeName901234567890CB)this);
            return cb;
        }

        // [DBFlute-0.8.9.9]
        // ===============================================================================
        //                                                                    OrScopeQuery
        //                                                                    ============
        public void OrScopeQuery(OrQuery<VendorLargeName901234567890CB> orQuery) {
            xorQ((VendorLargeName901234567890CB)this, orQuery);
        }

        // ===============================================================================
        //                                                                    Purpose Type
        //                                                                    ============
        public void xsetupForColumnQuery(VendorLargeName901234567890CB mainCB) {
            xinheritSubQueryInfo(mainCB.LocalCQ);
            //xchangePurposeSqlClause(HpCBPurpose.COLUMN_QUERY);
            _forColumnQuery = true; // old style

            // inherits a parent query to synchronize real name
            // (and also for suppressing query check) 
            Specify().xsetSyncQyCall(new VendorLargeName901234567890CBColQySpQyCall(mainCB));
        }
    }

    public class VendorLargeName901234567890CBColQySpQyCall : HpSpQyCall<VendorLargeName901234567890CQ> {
        protected VendorLargeName901234567890CB _mainCB;
        public VendorLargeName901234567890CBColQySpQyCall(VendorLargeName901234567890CB mainCB) {
            _mainCB = mainCB;
        }
        public bool has() { return true; } 
        public VendorLargeName901234567890CQ qy() { return _mainCB.Query(); } 
    }

    public class VendorLargeName901234567890CBSpecification : AbstractSpecification<VendorLargeName901234567890CQ> {
        public VendorLargeName901234567890CBSpecification(ConditionBean baseCB, HpSpQyCall<VendorLargeName901234567890CQ> qyCall
                                                      , bool forDerivedReferrer, bool forScalarSelect, bool forScalarSubQuery, bool forColumnQuery)
        : base(baseCB, qyCall, forDerivedReferrer, forScalarSelect, forScalarSubQuery, forColumnQuery) { }
        public void ColumnVendorLargeName901234567Id() { doColumn("VENDOR_LARGE_NAME_901234567_ID"); }
        public void ColumnVendorLargeName9012345Name() { doColumn("VENDOR_LARGE_NAME_9012345_NAME"); }
        protected override void doSpecifyRequiredColumn() {
            ColumnVendorLargeName901234567Id(); // PK
        }
        protected override String getTableDbName() { return "VENDOR_LARGE_NAME_901234567890"; }
        public RAFunction<VendorLargeName90123456RefCB, VendorLargeName901234567890CQ> DerivedVendorLargeName90123456RefList() {
            if (xhasSyncQyCall()) { xsyncQyCall().qy(); } // for sync (for example, this in ColumnQuery)
            return new RAFunction<VendorLargeName90123456RefCB, VendorLargeName901234567890CQ>(_baseCB, _qyCall.qy(), delegate(String function, SubQuery<VendorLargeName90123456RefCB> subQuery, VendorLargeName901234567890CQ cq, String aliasName)
                { cq.xsderiveVendorLargeName90123456RefList(function, subQuery, aliasName); });
        }
    }
}
