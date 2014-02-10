
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
    public class BsVdSynonymProductCB : AbstractConditionBean {

        // ===============================================================================
        //                                                                       Attribute
        //                                                                       =========
        protected VdSynonymProductCQ _conditionQuery;

        // ===============================================================================
        //                                                                      Table Name
        //                                                                      ==========
        public override String TableDbName { get { return "VD_SYNONYM_PRODUCT"; } }

        // ===============================================================================
        //                                                             PrimaryKey Handling
        //                                                             ===================
        public void AcceptPrimaryKey(long? productId) {
            assertObjectNotNull("productId", productId);
            BsVdSynonymProductCB cb = this;
            cb.Query().SetProductId_Equal(productId);
        }

        public override ConditionBean AddOrderBy_PK_Asc() {
            Query().AddOrderBy_ProductId_Asc();
            return this;
        }

        public override ConditionBean AddOrderBy_PK_Desc() {
            Query().AddOrderBy_ProductId_Desc();
            return this;
        }

        // ===============================================================================
        //                                                                           Query
        //                                                                           =====
        public VdSynonymProductCQ Query() {
            return this.ConditionQuery;
        }

        public VdSynonymProductCQ ConditionQuery {
            get {
                if (_conditionQuery == null) {
                    _conditionQuery = CreateLocalCQ();
                }
                return _conditionQuery;
            }
        }

        protected virtual VdSynonymProductCQ CreateLocalCQ() {
            return xcreateCQ(null, this.SqlClause, this.SqlClause.getBasePointAliasName(), 0);
        }

        protected virtual VdSynonymProductCQ xcreateCQ(ConditionQuery childQuery, SqlClause sqlClause, String aliasName, int nestLevel) {
            return new VdSynonymProductCQ(childQuery, sqlClause, aliasName, nestLevel);
        }

        public override ConditionQuery LocalCQ {
            get { return this.ConditionQuery; }
        }

        // ===============================================================================
        //                                                                           Union
        //                                                                           =====
	    public virtual void Union(UnionQuery<VdSynonymProductCB> unionQuery) {
            VdSynonymProductCB cb = new VdSynonymProductCB();
            cb.xsetupForUnion(this); xsyncUQ(cb); unionQuery.Invoke(cb);
		    VdSynonymProductCQ cq = cb.Query(); Query().xsetUnionQuery(cq);
        }

	    public virtual void UnionAll(UnionQuery<VdSynonymProductCB> unionQuery) {
            VdSynonymProductCB cb = new VdSynonymProductCB();
            cb.xsetupForUnion(this); xsyncUQ(cb); unionQuery.Invoke(cb);
		    VdSynonymProductCQ cq = cb.Query(); Query().xsetUnionAllQuery(cq);
	    }

        public override bool HasUnionQueryOrUnionAllQuery() {
            return Query().hasUnionQueryOrUnionAllQuery();
        }

        // ===============================================================================
        //                                                                    Setup Select
        //                                                                    ============
        protected VdSynonymProductStatusNss _nssVdSynonymProductStatus;
        public VdSynonymProductStatusNss NssVdSynonymProductStatus { get {
            if (_nssVdSynonymProductStatus == null) { _nssVdSynonymProductStatus = new VdSynonymProductStatusNss(null); }
            return _nssVdSynonymProductStatus;
        }}
        public VdSynonymProductStatusNss SetupSelect_VdSynonymProductStatus() {
            if (HasSpecifiedColumn) { // if reverse call
                Specify().ColumnProductStatusCode();
            }
            doSetupSelect(delegate { return Query().QueryVdSynonymProductStatus(); });
            if (_nssVdSynonymProductStatus == null || !_nssVdSynonymProductStatus.HasConditionQuery)
            { _nssVdSynonymProductStatus = new VdSynonymProductStatusNss(Query().QueryVdSynonymProductStatus()); }
            return _nssVdSynonymProductStatus;
        }

        // [DBFlute-0.7.4]
        // ===============================================================================
        //                                                                         Specify
        //                                                                         =======
        protected VdSynonymProductCBSpecification _specification;
        public VdSynonymProductCBSpecification Specify() {
            if (_specification == null) { _specification = new VdSynonymProductCBSpecification(this, new MySpQyCall(this), _forDerivedReferrer, _forScalarSelect, _forScalarCondition, _forColumnQuery); }
            return _specification;
        }
        protected bool HasSpecifiedColumn { get {
            return _specification != null && _specification.IsAlreadySpecifiedRequiredColumn;
        }}
        protected class MySpQyCall : HpSpQyCall<VdSynonymProductCQ> {
			protected BsVdSynonymProductCB _myCB;
			public MySpQyCall(BsVdSynonymProductCB myCB) { _myCB = myCB; }
    		public bool has() { return true; } public VdSynonymProductCQ qy() { return _myCB.Query(); }
    	}

        // [DBFlute-0.8.9.18]
        // ===============================================================================
        //                                                                     ColumnQuery
        //                                                                     ===========
        public HpColQyOperand<VdSynonymProductCB> ColumnQuery(SpecifyQuery<VdSynonymProductCB> leftSpecifyQuery) {
            return new HpColQyOperand<VdSynonymProductCB>(delegate(SpecifyQuery<VdSynonymProductCB> rightSp, String operand) {
                xcolqy(xcreateColumnQueryCB(), xcreateColumnQueryCB(), leftSpecifyQuery, rightSp, operand);
            });
        }

        protected VdSynonymProductCB xcreateColumnQueryCB() {
            VdSynonymProductCB cb = new VdSynonymProductCB();
            cb.xsetupForColumnQuery((VdSynonymProductCB)this);
            return cb;
        }

        // [DBFlute-0.8.9.9]
        // ===============================================================================
        //                                                                    OrScopeQuery
        //                                                                    ============
        public void OrScopeQuery(OrQuery<VdSynonymProductCB> orQuery) {
            xorQ((VdSynonymProductCB)this, orQuery);
        }

        // ===============================================================================
        //                                                                    Purpose Type
        //                                                                    ============
        public void xsetupForColumnQuery(VdSynonymProductCB mainCB) {
            xinheritSubQueryInfo(mainCB.LocalCQ);
            //xchangePurposeSqlClause(HpCBPurpose.COLUMN_QUERY);
            _forColumnQuery = true; // old style

            // inherits a parent query to synchronize real name
            // (and also for suppressing query check) 
            Specify().xsetSyncQyCall(new VdSynonymProductCBColQySpQyCall(mainCB));
        }
    }

    public class VdSynonymProductCBColQySpQyCall : HpSpQyCall<VdSynonymProductCQ> {
        protected VdSynonymProductCB _mainCB;
        public VdSynonymProductCBColQySpQyCall(VdSynonymProductCB mainCB) {
            _mainCB = mainCB;
        }
        public bool has() { return true; } 
        public VdSynonymProductCQ qy() { return _mainCB.Query(); } 
    }

    public class VdSynonymProductCBSpecification : AbstractSpecification<VdSynonymProductCQ> {
        protected VdSynonymProductStatusCBSpecification _vdSynonymProductStatus;
        public VdSynonymProductCBSpecification(ConditionBean baseCB, HpSpQyCall<VdSynonymProductCQ> qyCall
                                                      , bool forDerivedReferrer, bool forScalarSelect, bool forScalarSubQuery, bool forColumnQuery)
        : base(baseCB, qyCall, forDerivedReferrer, forScalarSelect, forScalarSubQuery, forColumnQuery) { }
        public void ColumnProductId() { doColumn("PRODUCT_ID"); }
        public void ColumnProductName() { doColumn("PRODUCT_NAME"); }
        public void ColumnProductHandleCode() { doColumn("PRODUCT_HANDLE_CODE"); }
        public void ColumnProductStatusCode() { doColumn("PRODUCT_STATUS_CODE"); }
        public void ColumnRegisterDatetime() { doColumn("REGISTER_DATETIME"); }
        public void ColumnRegisterUser() { doColumn("REGISTER_USER"); }
        public void ColumnRegisterProcess() { doColumn("REGISTER_PROCESS"); }
        public void ColumnUpdateDatetime() { doColumn("UPDATE_DATETIME"); }
        public void ColumnUpdateUser() { doColumn("UPDATE_USER"); }
        public void ColumnUpdateProcess() { doColumn("UPDATE_PROCESS"); }
        public void ColumnVersionNo() { doColumn("VERSION_NO"); }
        protected override void doSpecifyRequiredColumn() {
            ColumnProductId(); // PK
            if (qyCall().qy().hasConditionQueryVdSynonymProductStatus()
                    || qyCall().qy().xgetReferrerQuery() is VdSynonymProductStatusCQ) {
                ColumnProductStatusCode(); // FK or one-to-one referrer
            }
        }
        protected override String getTableDbName() { return "VD_SYNONYM_PRODUCT"; }
        public VdSynonymProductStatusCBSpecification SpecifyVdSynonymProductStatus() {
            assertForeign("vdSynonymProductStatus");
            if (_vdSynonymProductStatus == null) {
                _vdSynonymProductStatus = new VdSynonymProductStatusCBSpecification(_baseCB, new VdSynonymProductStatusSpQyCall(_qyCall), _forDerivedReferrer, _forScalarSelect, _forScalarCondition, _forColumnQuery);
                if (xhasSyncQyCall()) // inherits it
                { _vdSynonymProductStatus.xsetSyncQyCall(new VdSynonymProductStatusSpQyCall(xsyncQyCall())); }
            }
            return _vdSynonymProductStatus;
        }
		public class VdSynonymProductStatusSpQyCall : HpSpQyCall<VdSynonymProductStatusCQ> {
		    protected HpSpQyCall<VdSynonymProductCQ> _qyCall;
		    public VdSynonymProductStatusSpQyCall(HpSpQyCall<VdSynonymProductCQ> myQyCall) { _qyCall = myQyCall; }
		    public bool has() { return _qyCall.has() && _qyCall.qy().hasConditionQueryVdSynonymProductStatus(); }
			public VdSynonymProductStatusCQ qy() { return _qyCall.qy().QueryVdSynonymProductStatus(); }
		}
    }
}
