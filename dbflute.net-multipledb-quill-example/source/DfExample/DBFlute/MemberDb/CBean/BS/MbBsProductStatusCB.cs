
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
    public class MbBsProductStatusCB : MbAbstractConditionBean {

        // ===============================================================================
        //                                                                       Attribute
        //                                                                       =========
        protected MbProductStatusCQ _conditionQuery;

        // ===============================================================================
        //                                                                      Table Name
        //                                                                      ==========
        public override String TableDbName { get { return "product_status"; } }

        // ===============================================================================
        //                                                             PrimaryKey Handling
        //                                                             ===================
        public void AcceptPrimaryKey(String productStatusCode) {
            assertObjectNotNull("productStatusCode", productStatusCode);
            MbBsProductStatusCB cb = this;
            cb.Query().SetProductStatusCode_Equal(productStatusCode);
        }

        public override MbConditionBean AddOrderBy_PK_Asc() {
            Query().AddOrderBy_ProductStatusCode_Asc();
            return this;
        }

        public override MbConditionBean AddOrderBy_PK_Desc() {
            Query().AddOrderBy_ProductStatusCode_Desc();
            return this;
        }

        // ===============================================================================
        //                                                                           Query
        //                                                                           =====
        public MbProductStatusCQ Query() {
            return this.ConditionQuery;
        }

        public MbProductStatusCQ ConditionQuery {
            get {
                if (_conditionQuery == null) {
                    _conditionQuery = CreateLocalCQ();
                }
                return _conditionQuery;
            }
        }

        protected virtual MbProductStatusCQ CreateLocalCQ() {
            return xcreateCQ(null, this.SqlClause, this.SqlClause.getBasePointAliasName(), 0);
        }

        protected virtual MbProductStatusCQ xcreateCQ(MbConditionQuery childQuery, MbSqlClause sqlClause, String aliasName, int nestLevel) {
            return new MbProductStatusCQ(childQuery, sqlClause, aliasName, nestLevel);
        }

        public override MbConditionQuery LocalCQ {
            get { return this.ConditionQuery; }
        }

        // ===============================================================================
        //                                                                           Union
        //                                                                           =====
	    public virtual void Union(MbUnionQuery<MbProductStatusCB> unionQuery) {
            MbProductStatusCB cb = new MbProductStatusCB();
            cb.xsetupForUnion(this); xsyncUQ(cb); unionQuery.Invoke(cb);
		    MbProductStatusCQ cq = cb.Query(); Query().xsetUnionQuery(cq);
        }

	    public virtual void UnionAll(MbUnionQuery<MbProductStatusCB> unionQuery) {
            MbProductStatusCB cb = new MbProductStatusCB();
            cb.xsetupForUnion(this); xsyncUQ(cb); unionQuery.Invoke(cb);
		    MbProductStatusCQ cq = cb.Query(); Query().xsetUnionAllQuery(cq);
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
        protected MbProductStatusCBSpecification _specification;
        public MbProductStatusCBSpecification Specify() {
            if (_specification == null) { _specification = new MbProductStatusCBSpecification(this, new MySpQyCall(this), _forDerivedReferrer, _forScalarSelect, _forScalarCondition, _forColumnQuery); }
            return _specification;
        }
        protected bool HasSpecifiedColumn { get {
            return _specification != null && _specification.IsAlreadySpecifiedRequiredColumn;
        }}
        protected class MySpQyCall : HpSpQyCall<MbProductStatusCQ> {
			protected MbBsProductStatusCB _myCB;
			public MySpQyCall(MbBsProductStatusCB myCB) { _myCB = myCB; }
    		public bool has() { return true; } public MbProductStatusCQ qy() { return _myCB.Query(); }
    	}

        // [DBFlute-0.8.9.18]
        // ===============================================================================
        //                                                                     ColumnQuery
        //                                                                     ===========
        public HpColQyOperand<MbProductStatusCB> ColumnQuery(MbSpecifyQuery<MbProductStatusCB> leftSpecifyQuery) {
            return new HpColQyOperand<MbProductStatusCB>(delegate(MbSpecifyQuery<MbProductStatusCB> rightSp, String operand) {
                xcolqy(xcreateColumnQueryCB(), xcreateColumnQueryCB(), leftSpecifyQuery, rightSp, operand);
            });
        }

        protected MbProductStatusCB xcreateColumnQueryCB() {
            MbProductStatusCB cb = new MbProductStatusCB();
            cb.xsetupForColumnQuery((MbProductStatusCB)this);
            return cb;
        }

        // [DBFlute-0.8.9.9]
        // ===============================================================================
        //                                                                    OrScopeQuery
        //                                                                    ============
        public void OrScopeQuery(MbOrQuery<MbProductStatusCB> orQuery) {
            xorQ((MbProductStatusCB)this, orQuery);
        }

        // ===============================================================================
        //                                                                    Purpose Type
        //                                                                    ============
        public void xsetupForColumnQuery(MbProductStatusCB mainCB) {
            xinheritSubQueryInfo(mainCB.LocalCQ);
            //xchangePurposeSqlClause(HpCBPurpose.COLUMN_QUERY);
            _forColumnQuery = true; // old style

            // inherits a parent query to synchronize real name
            // (and also for suppressing query check) 
            Specify().xsetSyncQyCall(new MbProductStatusCBColQySpQyCall(mainCB));
        }
    }

    public class MbProductStatusCBColQySpQyCall : HpSpQyCall<MbProductStatusCQ> {
        protected MbProductStatusCB _mainCB;
        public MbProductStatusCBColQySpQyCall(MbProductStatusCB mainCB) {
            _mainCB = mainCB;
        }
        public bool has() { return true; } 
        public MbProductStatusCQ qy() { return _mainCB.Query(); } 
    }

    public class MbProductStatusCBSpecification : AbstractSpecification<MbProductStatusCQ> {
        public MbProductStatusCBSpecification(MbConditionBean baseCB, HpSpQyCall<MbProductStatusCQ> qyCall
                                                      , bool forDerivedReferrer, bool forScalarSelect, bool forScalarSubQuery, bool forColumnQuery)
        : base(baseCB, qyCall, forDerivedReferrer, forScalarSelect, forScalarSubQuery, forColumnQuery) { }
        public void ColumnProductStatusCode() { doColumn("PRODUCT_STATUS_CODE"); }
        public void ColumnProductStatusName() { doColumn("PRODUCT_STATUS_NAME"); }
        protected override void doSpecifyRequiredColumn() {
            ColumnProductStatusCode(); // PK
        }
        protected override String getTableDbName() { return "product_status"; }
        public RAFunction<MbProductCB, MbProductStatusCQ> DerivedProductList() {
            if (xhasSyncQyCall()) { xsyncQyCall().qy(); } // for sync (for example, this in ColumnQuery)
            return new RAFunction<MbProductCB, MbProductStatusCQ>(_baseCB, _qyCall.qy(), delegate(String function, MbSubQuery<MbProductCB> subQuery, MbProductStatusCQ cq, String aliasName)
                { cq.xsderiveProductList(function, subQuery, aliasName); });
        }
    }
}
