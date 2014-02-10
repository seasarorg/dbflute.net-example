
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
    public class BsWhiteMyselfCB : AbstractConditionBean {

        // ===============================================================================
        //                                                                       Attribute
        //                                                                       =========
        protected WhiteMyselfCQ _conditionQuery;

        // ===============================================================================
        //                                                                      Table Name
        //                                                                      ==========
        public override String TableDbName { get { return "white_myself"; } }

        // ===============================================================================
        //                                                             PrimaryKey Handling
        //                                                             ===================
        public void AcceptPrimaryKey(int? myselfId) {
            assertObjectNotNull("myselfId", myselfId);
            BsWhiteMyselfCB cb = this;
            cb.Query().SetMyselfId_Equal(myselfId);
        }

        public override ConditionBean AddOrderBy_PK_Asc() {
            Query().AddOrderBy_MyselfId_Asc();
            return this;
        }

        public override ConditionBean AddOrderBy_PK_Desc() {
            Query().AddOrderBy_MyselfId_Desc();
            return this;
        }

        // ===============================================================================
        //                                                                           Query
        //                                                                           =====
        public WhiteMyselfCQ Query() {
            return this.ConditionQuery;
        }

        public WhiteMyselfCQ ConditionQuery {
            get {
                if (_conditionQuery == null) {
                    _conditionQuery = CreateLocalCQ();
                }
                return _conditionQuery;
            }
        }

        protected virtual WhiteMyselfCQ CreateLocalCQ() {
            return xcreateCQ(null, this.SqlClause, this.SqlClause.getBasePointAliasName(), 0);
        }

        protected virtual WhiteMyselfCQ xcreateCQ(ConditionQuery childQuery, SqlClause sqlClause, String aliasName, int nestLevel) {
            return new WhiteMyselfCQ(childQuery, sqlClause, aliasName, nestLevel);
        }

        public override ConditionQuery LocalCQ {
            get { return this.ConditionQuery; }
        }

        // ===============================================================================
        //                                                                           Union
        //                                                                           =====
	    public virtual void Union(UnionQuery<WhiteMyselfCB> unionQuery) {
            WhiteMyselfCB cb = new WhiteMyselfCB();
            cb.xsetupForUnion(this); xsyncUQ(cb); unionQuery.Invoke(cb);
		    WhiteMyselfCQ cq = cb.Query(); Query().xsetUnionQuery(cq);
        }

	    public virtual void UnionAll(UnionQuery<WhiteMyselfCB> unionQuery) {
            WhiteMyselfCB cb = new WhiteMyselfCB();
            cb.xsetupForUnion(this); xsyncUQ(cb); unionQuery.Invoke(cb);
		    WhiteMyselfCQ cq = cb.Query(); Query().xsetUnionAllQuery(cq);
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
        protected WhiteMyselfCBSpecification _specification;
        public WhiteMyselfCBSpecification Specify() {
            if (_specification == null) { _specification = new WhiteMyselfCBSpecification(this, new MySpQyCall(this), _forDerivedReferrer, _forScalarSelect, _forScalarCondition, _forColumnQuery); }
            return _specification;
        }
        protected bool HasSpecifiedColumn { get {
            return _specification != null && _specification.IsAlreadySpecifiedRequiredColumn;
        }}
        protected class MySpQyCall : HpSpQyCall<WhiteMyselfCQ> {
			protected BsWhiteMyselfCB _myCB;
			public MySpQyCall(BsWhiteMyselfCB myCB) { _myCB = myCB; }
    		public bool has() { return true; } public WhiteMyselfCQ qy() { return _myCB.Query(); }
    	}

        // [DBFlute-0.8.9.18]
        // ===============================================================================
        //                                                                     ColumnQuery
        //                                                                     ===========
        public HpColQyOperand<WhiteMyselfCB> ColumnQuery(SpecifyQuery<WhiteMyselfCB> leftSpecifyQuery) {
            return new HpColQyOperand<WhiteMyselfCB>(delegate(SpecifyQuery<WhiteMyselfCB> rightSp, String operand) {
                xcolqy(xcreateColumnQueryCB(), xcreateColumnQueryCB(), leftSpecifyQuery, rightSp, operand);
            });
        }

        protected WhiteMyselfCB xcreateColumnQueryCB() {
            WhiteMyselfCB cb = new WhiteMyselfCB();
            cb.xsetupForColumnQuery((WhiteMyselfCB)this);
            return cb;
        }

        // [DBFlute-0.8.9.9]
        // ===============================================================================
        //                                                                    OrScopeQuery
        //                                                                    ============
        public void OrScopeQuery(OrQuery<WhiteMyselfCB> orQuery) {
            xorQ((WhiteMyselfCB)this, orQuery);
        }

        // ===============================================================================
        //                                                                    Purpose Type
        //                                                                    ============
        public void xsetupForColumnQuery(WhiteMyselfCB mainCB) {
            xinheritSubQueryInfo(mainCB.LocalCQ);
            //xchangePurposeSqlClause(HpCBPurpose.COLUMN_QUERY);
            _forColumnQuery = true; // old style

            // inherits a parent query to synchronize real name
            // (and also for suppressing query check) 
            Specify().xsetSyncQyCall(new WhiteMyselfCBColQySpQyCall(mainCB));
        }
    }

    public class WhiteMyselfCBColQySpQyCall : HpSpQyCall<WhiteMyselfCQ> {
        protected WhiteMyselfCB _mainCB;
        public WhiteMyselfCBColQySpQyCall(WhiteMyselfCB mainCB) {
            _mainCB = mainCB;
        }
        public bool has() { return true; } 
        public WhiteMyselfCQ qy() { return _mainCB.Query(); } 
    }

    public class WhiteMyselfCBSpecification : AbstractSpecification<WhiteMyselfCQ> {
        public WhiteMyselfCBSpecification(ConditionBean baseCB, HpSpQyCall<WhiteMyselfCQ> qyCall
                                                      , bool forDerivedReferrer, bool forScalarSelect, bool forScalarSubQuery, bool forColumnQuery)
        : base(baseCB, qyCall, forDerivedReferrer, forScalarSelect, forScalarSubQuery, forColumnQuery) { }
        public void ColumnMyselfId() { doColumn("MYSELF_ID"); }
        public void ColumnMyselfName() { doColumn("MYSELF_NAME"); }
        protected override void doSpecifyRequiredColumn() {
            ColumnMyselfId(); // PK
        }
        protected override String getTableDbName() { return "white_myself"; }
        public RAFunction<WhiteMyselfCheckCB, WhiteMyselfCQ> DerivedWhiteMyselfCheckList() {
            if (xhasSyncQyCall()) { xsyncQyCall().qy(); } // for sync (for example, this in ColumnQuery)
            return new RAFunction<WhiteMyselfCheckCB, WhiteMyselfCQ>(_baseCB, _qyCall.qy(), delegate(String function, SubQuery<WhiteMyselfCheckCB> subQuery, WhiteMyselfCQ cq, String aliasName)
                { cq.xsderiveWhiteMyselfCheckList(function, subQuery, aliasName); });
        }
    }
}
