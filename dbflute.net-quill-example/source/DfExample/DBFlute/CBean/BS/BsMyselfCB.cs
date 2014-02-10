
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
    public class BsMyselfCB : AbstractConditionBean {

        // ===============================================================================
        //                                                                       Attribute
        //                                                                       =========
        protected MyselfCQ _conditionQuery;

        // ===============================================================================
        //                                                                      Table Name
        //                                                                      ==========
        public override String TableDbName { get { return "myself"; } }

        // ===============================================================================
        //                                                             PrimaryKey Handling
        //                                                             ===================
        public void AcceptPrimaryKey(int? myselfId) {
            assertObjectNotNull("myselfId", myselfId);
            BsMyselfCB cb = this;
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
        public MyselfCQ Query() {
            return this.ConditionQuery;
        }

        public MyselfCQ ConditionQuery {
            get {
                if (_conditionQuery == null) {
                    _conditionQuery = CreateLocalCQ();
                }
                return _conditionQuery;
            }
        }

        protected virtual MyselfCQ CreateLocalCQ() {
            return xcreateCQ(null, this.SqlClause, this.SqlClause.getBasePointAliasName(), 0);
        }

        protected virtual MyselfCQ xcreateCQ(ConditionQuery childQuery, SqlClause sqlClause, String aliasName, int nestLevel) {
            return new MyselfCQ(childQuery, sqlClause, aliasName, nestLevel);
        }

        public override ConditionQuery LocalCQ {
            get { return this.ConditionQuery; }
        }

        // ===============================================================================
        //                                                                           Union
        //                                                                           =====
	    public virtual void Union(UnionQuery<MyselfCB> unionQuery) {
            MyselfCB cb = new MyselfCB();
            cb.xsetupForUnion(this); xsyncUQ(cb); unionQuery.Invoke(cb);
		    MyselfCQ cq = cb.Query(); Query().xsetUnionQuery(cq);
        }

	    public virtual void UnionAll(UnionQuery<MyselfCB> unionQuery) {
            MyselfCB cb = new MyselfCB();
            cb.xsetupForUnion(this); xsyncUQ(cb); unionQuery.Invoke(cb);
		    MyselfCQ cq = cb.Query(); Query().xsetUnionAllQuery(cq);
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
        protected MyselfCBSpecification _specification;
        public MyselfCBSpecification Specify() {
            if (_specification == null) { _specification = new MyselfCBSpecification(this, new MySpQyCall(this), _forDerivedReferrer, _forScalarSelect, _forScalarCondition, _forColumnQuery); }
            return _specification;
        }
        protected bool HasSpecifiedColumn { get {
            return _specification != null && _specification.IsAlreadySpecifiedRequiredColumn;
        }}
        protected class MySpQyCall : HpSpQyCall<MyselfCQ> {
			protected BsMyselfCB _myCB;
			public MySpQyCall(BsMyselfCB myCB) { _myCB = myCB; }
    		public bool has() { return true; } public MyselfCQ qy() { return _myCB.Query(); }
    	}

        // [DBFlute-0.8.9.18]
        // ===============================================================================
        //                                                                     ColumnQuery
        //                                                                     ===========
        public HpColQyOperand<MyselfCB> ColumnQuery(SpecifyQuery<MyselfCB> leftSpecifyQuery) {
            return new HpColQyOperand<MyselfCB>(delegate(SpecifyQuery<MyselfCB> rightSp, String operand) {
                xcolqy(xcreateColumnQueryCB(), xcreateColumnQueryCB(), leftSpecifyQuery, rightSp, operand);
            });
        }

        protected MyselfCB xcreateColumnQueryCB() {
            MyselfCB cb = new MyselfCB();
            cb.xsetupForColumnQuery((MyselfCB)this);
            return cb;
        }

        // [DBFlute-0.8.9.9]
        // ===============================================================================
        //                                                                    OrScopeQuery
        //                                                                    ============
        public void OrScopeQuery(OrQuery<MyselfCB> orQuery) {
            xorQ((MyselfCB)this, orQuery);
        }

        // ===============================================================================
        //                                                                    Purpose Type
        //                                                                    ============
        public void xsetupForColumnQuery(MyselfCB mainCB) {
            xinheritSubQueryInfo(mainCB.LocalCQ);
            //xchangePurposeSqlClause(HpCBPurpose.COLUMN_QUERY);
            _forColumnQuery = true; // old style

            // inherits a parent query to synchronize real name
            // (and also for suppressing query check) 
            Specify().xsetSyncQyCall(new MyselfCBColQySpQyCall(mainCB));
        }
    }

    public class MyselfCBColQySpQyCall : HpSpQyCall<MyselfCQ> {
        protected MyselfCB _mainCB;
        public MyselfCBColQySpQyCall(MyselfCB mainCB) {
            _mainCB = mainCB;
        }
        public bool has() { return true; } 
        public MyselfCQ qy() { return _mainCB.Query(); } 
    }

    public class MyselfCBSpecification : AbstractSpecification<MyselfCQ> {
        public MyselfCBSpecification(ConditionBean baseCB, HpSpQyCall<MyselfCQ> qyCall
                                                      , bool forDerivedReferrer, bool forScalarSelect, bool forScalarSubQuery, bool forColumnQuery)
        : base(baseCB, qyCall, forDerivedReferrer, forScalarSelect, forScalarSubQuery, forColumnQuery) { }
        public void ColumnMyselfId() { doColumn("MYSELF_ID"); }
        public void ColumnMyselfName() { doColumn("MYSELF_NAME"); }
        protected override void doSpecifyRequiredColumn() {
            ColumnMyselfId(); // PK
        }
        protected override String getTableDbName() { return "myself"; }
        public RAFunction<MyselfCheckCB, MyselfCQ> DerivedMyselfCheckList() {
            if (xhasSyncQyCall()) { xsyncQyCall().qy(); } // for sync (for example, this in ColumnQuery)
            return new RAFunction<MyselfCheckCB, MyselfCQ>(_baseCB, _qyCall.qy(), delegate(String function, SubQuery<MyselfCheckCB> subQuery, MyselfCQ cq, String aliasName)
                { cq.xsderiveMyselfCheckList(function, subQuery, aliasName); });
        }
    }
}
