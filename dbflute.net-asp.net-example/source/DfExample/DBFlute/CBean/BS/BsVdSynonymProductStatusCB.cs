
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
    public class BsVdSynonymProductStatusCB : AbstractConditionBean {

        // ===============================================================================
        //                                                                       Attribute
        //                                                                       =========
        protected VdSynonymProductStatusCQ _conditionQuery;

        // ===============================================================================
        //                                                                      Table Name
        //                                                                      ==========
        public override String TableDbName { get { return "VD_SYNONYM_PRODUCT_STATUS"; } }

        // ===============================================================================
        //                                                             PrimaryKey Handling
        //                                                             ===================
        public void AcceptPrimaryKey(String productStatusCode) {
            assertObjectNotNull("productStatusCode", productStatusCode);
            BsVdSynonymProductStatusCB cb = this;
            cb.Query().SetProductStatusCode_Equal(productStatusCode);
        }

        public override ConditionBean AddOrderBy_PK_Asc() {
            Query().AddOrderBy_ProductStatusCode_Asc();
            return this;
        }

        public override ConditionBean AddOrderBy_PK_Desc() {
            Query().AddOrderBy_ProductStatusCode_Desc();
            return this;
        }

        // ===============================================================================
        //                                                                           Query
        //                                                                           =====
        public VdSynonymProductStatusCQ Query() {
            return this.ConditionQuery;
        }

        public VdSynonymProductStatusCQ ConditionQuery {
            get {
                if (_conditionQuery == null) {
                    _conditionQuery = CreateLocalCQ();
                }
                return _conditionQuery;
            }
        }

        protected virtual VdSynonymProductStatusCQ CreateLocalCQ() {
            return xcreateCQ(null, this.SqlClause, this.SqlClause.getBasePointAliasName(), 0);
        }

        protected virtual VdSynonymProductStatusCQ xcreateCQ(ConditionQuery childQuery, SqlClause sqlClause, String aliasName, int nestLevel) {
            return new VdSynonymProductStatusCQ(childQuery, sqlClause, aliasName, nestLevel);
        }

        public override ConditionQuery LocalCQ {
            get { return this.ConditionQuery; }
        }

        // ===============================================================================
        //                                                                           Union
        //                                                                           =====
	    public virtual void Union(UnionQuery<VdSynonymProductStatusCB> unionQuery) {
            VdSynonymProductStatusCB cb = new VdSynonymProductStatusCB();
            cb.xsetupForUnion(this); xsyncUQ(cb); unionQuery.Invoke(cb);
		    VdSynonymProductStatusCQ cq = cb.Query(); Query().xsetUnionQuery(cq);
        }

	    public virtual void UnionAll(UnionQuery<VdSynonymProductStatusCB> unionQuery) {
            VdSynonymProductStatusCB cb = new VdSynonymProductStatusCB();
            cb.xsetupForUnion(this); xsyncUQ(cb); unionQuery.Invoke(cb);
		    VdSynonymProductStatusCQ cq = cb.Query(); Query().xsetUnionAllQuery(cq);
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
        protected VdSynonymProductStatusCBSpecification _specification;
        public VdSynonymProductStatusCBSpecification Specify() {
            if (_specification == null) { _specification = new VdSynonymProductStatusCBSpecification(this, new MySpQyCall(this), _forDerivedReferrer, _forScalarSelect, _forScalarCondition, _forColumnQuery); }
            return _specification;
        }
        protected bool HasSpecifiedColumn { get {
            return _specification != null && _specification.IsAlreadySpecifiedRequiredColumn;
        }}
        protected class MySpQyCall : HpSpQyCall<VdSynonymProductStatusCQ> {
			protected BsVdSynonymProductStatusCB _myCB;
			public MySpQyCall(BsVdSynonymProductStatusCB myCB) { _myCB = myCB; }
    		public bool has() { return true; } public VdSynonymProductStatusCQ qy() { return _myCB.Query(); }
    	}

        // [DBFlute-0.8.9.18]
        // ===============================================================================
        //                                                                     ColumnQuery
        //                                                                     ===========
        public HpColQyOperand<VdSynonymProductStatusCB> ColumnQuery(SpecifyQuery<VdSynonymProductStatusCB> leftSpecifyQuery) {
            return new HpColQyOperand<VdSynonymProductStatusCB>(delegate(SpecifyQuery<VdSynonymProductStatusCB> rightSp, String operand) {
                xcolqy(xcreateColumnQueryCB(), xcreateColumnQueryCB(), leftSpecifyQuery, rightSp, operand);
            });
        }

        protected VdSynonymProductStatusCB xcreateColumnQueryCB() {
            VdSynonymProductStatusCB cb = new VdSynonymProductStatusCB();
            cb.xsetupForColumnQuery((VdSynonymProductStatusCB)this);
            return cb;
        }

        // [DBFlute-0.8.9.9]
        // ===============================================================================
        //                                                                    OrScopeQuery
        //                                                                    ============
        public void OrScopeQuery(OrQuery<VdSynonymProductStatusCB> orQuery) {
            xorQ((VdSynonymProductStatusCB)this, orQuery);
        }

        // ===============================================================================
        //                                                                    Purpose Type
        //                                                                    ============
        public void xsetupForColumnQuery(VdSynonymProductStatusCB mainCB) {
            xinheritSubQueryInfo(mainCB.LocalCQ);
            //xchangePurposeSqlClause(HpCBPurpose.COLUMN_QUERY);
            _forColumnQuery = true; // old style

            // inherits a parent query to synchronize real name
            // (and also for suppressing query check) 
            Specify().xsetSyncQyCall(new VdSynonymProductStatusCBColQySpQyCall(mainCB));
        }
    }

    public class VdSynonymProductStatusCBColQySpQyCall : HpSpQyCall<VdSynonymProductStatusCQ> {
        protected VdSynonymProductStatusCB _mainCB;
        public VdSynonymProductStatusCBColQySpQyCall(VdSynonymProductStatusCB mainCB) {
            _mainCB = mainCB;
        }
        public bool has() { return true; } 
        public VdSynonymProductStatusCQ qy() { return _mainCB.Query(); } 
    }

    public class VdSynonymProductStatusCBSpecification : AbstractSpecification<VdSynonymProductStatusCQ> {
        public VdSynonymProductStatusCBSpecification(ConditionBean baseCB, HpSpQyCall<VdSynonymProductStatusCQ> qyCall
                                                      , bool forDerivedReferrer, bool forScalarSelect, bool forScalarSubQuery, bool forColumnQuery)
        : base(baseCB, qyCall, forDerivedReferrer, forScalarSelect, forScalarSubQuery, forColumnQuery) { }
        public void ColumnProductStatusCode() { doColumn("PRODUCT_STATUS_CODE"); }
        public void ColumnProductStatusName() { doColumn("PRODUCT_STATUS_NAME"); }
        protected override void doSpecifyRequiredColumn() {
            ColumnProductStatusCode(); // PK
        }
        protected override String getTableDbName() { return "VD_SYNONYM_PRODUCT_STATUS"; }
        public RAFunction<VdSynonymProductCB, VdSynonymProductStatusCQ> DerivedVdSynonymProductList() {
            if (xhasSyncQyCall()) { xsyncQyCall().qy(); } // for sync (for example, this in ColumnQuery)
            return new RAFunction<VdSynonymProductCB, VdSynonymProductStatusCQ>(_baseCB, _qyCall.qy(), delegate(String function, SubQuery<VdSynonymProductCB> subQuery, VdSynonymProductStatusCQ cq, String aliasName)
                { cq.xsderiveVdSynonymProductList(function, subQuery, aliasName); });
        }
    }
}
