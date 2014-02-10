
using System;
using System.Collections;

using DfExample.DBFlute.MemberDb.AllCommon;
using DfExample.DBFlute.MemberDb.AllCommon.CBean;
using DfExample.DBFlute.MemberDb.AllCommon.CBean.SClause;
using DfExample.DBFlute.MemberDb.AllCommon.Helper;

using DfExample.DBFlute.MemberDb.CBean;
using DfExample.DBFlute.MemberDb.CBean.CQ;
using DfExample.DBFlute.MemberDb.CBean.Nss;

namespace DfExample.DBFlute.MemberDb.CBean.BS {

    [System.Serializable]
    public class MbBsVendorSelfReferenceCB : MbAbstractConditionBean {

        // ===============================================================================
        //                                                                       Attribute
        //                                                                       =========
        protected MbVendorSelfReferenceCQ _conditionQuery;

        // ===============================================================================
        //                                                                      Table Name
        //                                                                      ==========
        public override String TableDbName { get { return "vendor_self_reference"; } }

        // ===============================================================================
        //                                                             PrimaryKey Handling
        //                                                             ===================
        public void AcceptPrimaryKey(long? selfReferenceId) {
            assertObjectNotNull("selfReferenceId", selfReferenceId);
            MbBsVendorSelfReferenceCB cb = this;
            cb.Query().SetSelfReferenceId_Equal(selfReferenceId);
        }

        public override MbConditionBean AddOrderBy_PK_Asc() {
            Query().AddOrderBy_SelfReferenceId_Asc();
            return this;
        }

        public override MbConditionBean AddOrderBy_PK_Desc() {
            Query().AddOrderBy_SelfReferenceId_Desc();
            return this;
        }

        // ===============================================================================
        //                                                                           Query
        //                                                                           =====
        public MbVendorSelfReferenceCQ Query() {
            return this.ConditionQuery;
        }

        public MbVendorSelfReferenceCQ ConditionQuery {
            get {
                if (_conditionQuery == null) {
                    _conditionQuery = CreateLocalCQ();
                }
                return _conditionQuery;
            }
        }

        protected virtual MbVendorSelfReferenceCQ CreateLocalCQ() {
            return xcreateCQ(null, this.SqlClause, this.SqlClause.getBasePointAliasName(), 0);
        }

        protected virtual MbVendorSelfReferenceCQ xcreateCQ(MbConditionQuery childQuery, MbSqlClause sqlClause, String aliasName, int nestLevel) {
            return new MbVendorSelfReferenceCQ(childQuery, sqlClause, aliasName, nestLevel);
        }

        public override MbConditionQuery LocalCQ {
            get { return this.ConditionQuery; }
        }

        // ===============================================================================
        //                                                                           Union
        //                                                                           =====
	    public virtual void Union(MbUnionQuery<MbVendorSelfReferenceCB> unionQuery) {
            MbVendorSelfReferenceCB cb = new MbVendorSelfReferenceCB();
            cb.xsetupForUnion(this); xsyncUQ(cb); unionQuery.Invoke(cb);
		    MbVendorSelfReferenceCQ cq = cb.Query(); Query().xsetUnionQuery(cq);
        }

	    public virtual void UnionAll(MbUnionQuery<MbVendorSelfReferenceCB> unionQuery) {
            MbVendorSelfReferenceCB cb = new MbVendorSelfReferenceCB();
            cb.xsetupForUnion(this); xsyncUQ(cb); unionQuery.Invoke(cb);
		    MbVendorSelfReferenceCQ cq = cb.Query(); Query().xsetUnionAllQuery(cq);
	    }

        public override bool HasUnionQueryOrUnionAllQuery() {
            return Query().hasUnionQueryOrUnionAllQuery();
        }

        // ===============================================================================
        //                                                                    Setup Select
        //                                                                    ============
        protected MbVendorSelfReferenceNss _nssVendorSelfReferenceSelf;
        public MbVendorSelfReferenceNss NssVendorSelfReferenceSelf { get {
            if (_nssVendorSelfReferenceSelf == null) { _nssVendorSelfReferenceSelf = new MbVendorSelfReferenceNss(null); }
            return _nssVendorSelfReferenceSelf;
        }}
        public MbVendorSelfReferenceNss SetupSelect_VendorSelfReferenceSelf() {
            if (HasSpecifiedColumn) { // if reverse call
                Specify().ColumnParentId();
            }
            doSetupSelect(delegate { return Query().QueryVendorSelfReferenceSelf(); });
            if (_nssVendorSelfReferenceSelf == null || !_nssVendorSelfReferenceSelf.HasConditionQuery)
            { _nssVendorSelfReferenceSelf = new MbVendorSelfReferenceNss(Query().QueryVendorSelfReferenceSelf()); }
            return _nssVendorSelfReferenceSelf;
        }

        // [DBFlute-0.7.4]
        // ===============================================================================
        //                                                                         Specify
        //                                                                         =======
        protected MbVendorSelfReferenceCBSpecification _specification;
        public MbVendorSelfReferenceCBSpecification Specify() {
            if (_specification == null) { _specification = new MbVendorSelfReferenceCBSpecification(this, new MySpQyCall(this), _forDerivedReferrer, _forScalarSelect, _forScalarCondition, _forColumnQuery); }
            return _specification;
        }
        protected bool HasSpecifiedColumn { get {
            return _specification != null && _specification.IsAlreadySpecifiedRequiredColumn;
        }}
        protected class MySpQyCall : HpSpQyCall<MbVendorSelfReferenceCQ> {
			protected MbBsVendorSelfReferenceCB _myCB;
			public MySpQyCall(MbBsVendorSelfReferenceCB myCB) { _myCB = myCB; }
    		public bool has() { return true; } public MbVendorSelfReferenceCQ qy() { return _myCB.Query(); }
    	}

        // [DBFlute-0.8.9.18]
        // ===============================================================================
        //                                                                     ColumnQuery
        //                                                                     ===========
        public HpColQyOperand<MbVendorSelfReferenceCB> ColumnQuery(MbSpecifyQuery<MbVendorSelfReferenceCB> leftSpecifyQuery) {
            return new HpColQyOperand<MbVendorSelfReferenceCB>(delegate(MbSpecifyQuery<MbVendorSelfReferenceCB> rightSp, String operand) {
                xcolqy(xcreateColumnQueryCB(), xcreateColumnQueryCB(), leftSpecifyQuery, rightSp, operand);
            });
        }

        protected MbVendorSelfReferenceCB xcreateColumnQueryCB() {
            MbVendorSelfReferenceCB cb = new MbVendorSelfReferenceCB();
            cb.xsetupForColumnQuery((MbVendorSelfReferenceCB)this);
            return cb;
        }

        // [DBFlute-0.8.9.9]
        // ===============================================================================
        //                                                                    OrScopeQuery
        //                                                                    ============
        public void OrScopeQuery(MbOrQuery<MbVendorSelfReferenceCB> orQuery) {
            xorQ((MbVendorSelfReferenceCB)this, orQuery);
        }

        // ===============================================================================
        //                                                                    Purpose Type
        //                                                                    ============
        public void xsetupForColumnQuery(MbVendorSelfReferenceCB mainCB) {
            xinheritSubQueryInfo(mainCB.LocalCQ);
            //xchangePurposeSqlClause(HpCBPurpose.COLUMN_QUERY);
            _forColumnQuery = true; // old style

            // inherits a parent query to synchronize real name
            // (and also for suppressing query check) 
            Specify().xsetSyncQyCall(new MbVendorSelfReferenceCBColQySpQyCall(mainCB));
        }
    }

    public class MbVendorSelfReferenceCBColQySpQyCall : HpSpQyCall<MbVendorSelfReferenceCQ> {
        protected MbVendorSelfReferenceCB _mainCB;
        public MbVendorSelfReferenceCBColQySpQyCall(MbVendorSelfReferenceCB mainCB) {
            _mainCB = mainCB;
        }
        public bool has() { return true; } 
        public MbVendorSelfReferenceCQ qy() { return _mainCB.Query(); } 
    }

    public class MbVendorSelfReferenceCBSpecification : AbstractSpecification<MbVendorSelfReferenceCQ> {
        protected MbVendorSelfReferenceCBSpecification _vendorSelfReferenceSelf;
        public MbVendorSelfReferenceCBSpecification(MbConditionBean baseCB, HpSpQyCall<MbVendorSelfReferenceCQ> qyCall
                                                      , bool forDerivedReferrer, bool forScalarSelect, bool forScalarSubQuery, bool forColumnQuery)
        : base(baseCB, qyCall, forDerivedReferrer, forScalarSelect, forScalarSubQuery, forColumnQuery) { }
        public void ColumnSelfReferenceId() { doColumn("SELF_REFERENCE_ID"); }
        public void ColumnSelfReferenceName() { doColumn("SELF_REFERENCE_NAME"); }
        public void ColumnParentId() { doColumn("PARENT_ID"); }
        protected override void doSpecifyRequiredColumn() {
            ColumnSelfReferenceId(); // PK
            if (qyCall().qy().hasConditionQueryVendorSelfReferenceSelf()
                    || qyCall().qy().xgetReferrerQuery() is MbVendorSelfReferenceCQ) {
                ColumnParentId(); // FK or one-to-one referrer
            }
        }
        protected override String getTableDbName() { return "vendor_self_reference"; }
        public MbVendorSelfReferenceCBSpecification SpecifyVendorSelfReferenceSelf() {
            assertForeign("vendorSelfReferenceSelf");
            if (_vendorSelfReferenceSelf == null) {
                _vendorSelfReferenceSelf = new MbVendorSelfReferenceCBSpecification(_baseCB, new VendorSelfReferenceSelfSpQyCall(_qyCall), _forDerivedReferrer, _forScalarSelect, _forScalarCondition, _forColumnQuery);
                if (xhasSyncQyCall()) // inherits it
                { _vendorSelfReferenceSelf.xsetSyncQyCall(new VendorSelfReferenceSelfSpQyCall(xsyncQyCall())); }
            }
            return _vendorSelfReferenceSelf;
        }
		public class VendorSelfReferenceSelfSpQyCall : HpSpQyCall<MbVendorSelfReferenceCQ> {
		    protected HpSpQyCall<MbVendorSelfReferenceCQ> _qyCall;
		    public VendorSelfReferenceSelfSpQyCall(HpSpQyCall<MbVendorSelfReferenceCQ> myQyCall) { _qyCall = myQyCall; }
		    public bool has() { return _qyCall.has() && _qyCall.qy().hasConditionQueryVendorSelfReferenceSelf(); }
			public MbVendorSelfReferenceCQ qy() { return _qyCall.qy().QueryVendorSelfReferenceSelf(); }
		}
        public RAFunction<MbVendorSelfReferenceCB, MbVendorSelfReferenceCQ> DerivedVendorSelfReferenceSelfList() {
            if (xhasSyncQyCall()) { xsyncQyCall().qy(); } // for sync (for example, this in ColumnQuery)
            return new RAFunction<MbVendorSelfReferenceCB, MbVendorSelfReferenceCQ>(_baseCB, _qyCall.qy(), delegate(String function, MbSubQuery<MbVendorSelfReferenceCB> subQuery, MbVendorSelfReferenceCQ cq, String aliasName)
                { cq.xsderiveVendorSelfReferenceSelfList(function, subQuery, aliasName); });
        }
    }
}
