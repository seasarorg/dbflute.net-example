
using System;
using System.Collections;

using DfExample.DBFlute.LibraryDb.AllCommon;
using DfExample.DBFlute.LibraryDb.AllCommon.CBean;
using DfExample.DBFlute.LibraryDb.AllCommon.CBean.SClause;
using DfExample.DBFlute.LibraryDb.AllCommon.Helper;

using DfExample.DBFlute.LibraryDb.CBean;
using DfExample.DBFlute.LibraryDb.CBean.CQ;
using DfExample.DBFlute.LibraryDb.CBean.Nss;

namespace DfExample.DBFlute.LibraryDb.CBean.BS {

    [System.Serializable]
    public class LdBsMyselfCB : LdAbstractConditionBean {

        // ===============================================================================
        //                                                                       Attribute
        //                                                                       =========
        protected LdMyselfCQ _conditionQuery;

        // ===============================================================================
        //                                                                      Table Name
        //                                                                      ==========
        public override String TableDbName { get { return "myself"; } }

        // ===============================================================================
        //                                                             PrimaryKey Handling
        //                                                             ===================
        public void AcceptPrimaryKey(int? myselfId) {
            assertObjectNotNull("myselfId", myselfId);
            LdBsMyselfCB cb = this;
            cb.Query().SetMyselfId_Equal(myselfId);
        }

        public override LdConditionBean AddOrderBy_PK_Asc() {
            Query().AddOrderBy_MyselfId_Asc();
            return this;
        }

        public override LdConditionBean AddOrderBy_PK_Desc() {
            Query().AddOrderBy_MyselfId_Desc();
            return this;
        }

        // ===============================================================================
        //                                                                           Query
        //                                                                           =====
        public LdMyselfCQ Query() {
            return this.ConditionQuery;
        }

        public LdMyselfCQ ConditionQuery {
            get {
                if (_conditionQuery == null) {
                    _conditionQuery = CreateLocalCQ();
                }
                return _conditionQuery;
            }
        }

        protected virtual LdMyselfCQ CreateLocalCQ() {
            return xcreateCQ(null, this.SqlClause, this.SqlClause.getBasePointAliasName(), 0);
        }

        protected virtual LdMyselfCQ xcreateCQ(LdConditionQuery childQuery, LdSqlClause sqlClause, String aliasName, int nestLevel) {
            return new LdMyselfCQ(childQuery, sqlClause, aliasName, nestLevel);
        }

        public override LdConditionQuery LocalCQ {
            get { return this.ConditionQuery; }
        }

        // ===============================================================================
        //                                                                           Union
        //                                                                           =====
	    public virtual void Union(LdUnionQuery<LdMyselfCB> unionQuery) {
            LdMyselfCB cb = new LdMyselfCB();
            cb.xsetupForUnion(this); xsyncUQ(cb); unionQuery.Invoke(cb);
		    LdMyselfCQ cq = cb.Query(); Query().xsetUnionQuery(cq);
        }

	    public virtual void UnionAll(LdUnionQuery<LdMyselfCB> unionQuery) {
            LdMyselfCB cb = new LdMyselfCB();
            cb.xsetupForUnion(this); xsyncUQ(cb); unionQuery.Invoke(cb);
		    LdMyselfCQ cq = cb.Query(); Query().xsetUnionAllQuery(cq);
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
        protected LdMyselfCBSpecification _specification;
        public LdMyselfCBSpecification Specify() {
            if (_specification == null) { _specification = new LdMyselfCBSpecification(this, new MySpQyCall(this), _forDerivedReferrer, _forScalarSelect, _forScalarCondition, _forColumnQuery); }
            return _specification;
        }
        protected bool HasSpecifiedColumn { get {
            return _specification != null && _specification.IsAlreadySpecifiedRequiredColumn;
        }}
        protected class MySpQyCall : HpSpQyCall<LdMyselfCQ> {
			protected LdBsMyselfCB _myCB;
			public MySpQyCall(LdBsMyselfCB myCB) { _myCB = myCB; }
    		public bool has() { return true; } public LdMyselfCQ qy() { return _myCB.Query(); }
    	}

        // [DBFlute-0.8.9.18]
        // ===============================================================================
        //                                                                     ColumnQuery
        //                                                                     ===========
        public HpColQyOperand<LdMyselfCB> ColumnQuery(LdSpecifyQuery<LdMyselfCB> leftSpecifyQuery) {
            return new HpColQyOperand<LdMyselfCB>(delegate(LdSpecifyQuery<LdMyselfCB> rightSp, String operand) {
                xcolqy(xcreateColumnQueryCB(), xcreateColumnQueryCB(), leftSpecifyQuery, rightSp, operand);
            });
        }

        protected LdMyselfCB xcreateColumnQueryCB() {
            LdMyselfCB cb = new LdMyselfCB();
            cb.xsetupForColumnQuery((LdMyselfCB)this);
            return cb;
        }

        // [DBFlute-0.8.9.9]
        // ===============================================================================
        //                                                                    OrScopeQuery
        //                                                                    ============
        public void OrScopeQuery(LdOrQuery<LdMyselfCB> orQuery) {
            xorQ((LdMyselfCB)this, orQuery);
        }

        // ===============================================================================
        //                                                                    Purpose Type
        //                                                                    ============
        public void xsetupForColumnQuery(LdMyselfCB mainCB) {
            xinheritSubQueryInfo(mainCB.LocalCQ);
            //xchangePurposeSqlClause(HpCBPurpose.COLUMN_QUERY);
            _forColumnQuery = true; // old style

            // inherits a parent query to synchronize real name
            // (and also for suppressing query check) 
            Specify().xsetSyncQyCall(new LdMyselfCBColQySpQyCall(mainCB));
        }
    }

    public class LdMyselfCBColQySpQyCall : HpSpQyCall<LdMyselfCQ> {
        protected LdMyselfCB _mainCB;
        public LdMyselfCBColQySpQyCall(LdMyselfCB mainCB) {
            _mainCB = mainCB;
        }
        public bool has() { return true; } 
        public LdMyselfCQ qy() { return _mainCB.Query(); } 
    }

    public class LdMyselfCBSpecification : AbstractSpecification<LdMyselfCQ> {
        public LdMyselfCBSpecification(LdConditionBean baseCB, HpSpQyCall<LdMyselfCQ> qyCall
                                                      , bool forDerivedReferrer, bool forScalarSelect, bool forScalarSubQuery, bool forColumnQuery)
        : base(baseCB, qyCall, forDerivedReferrer, forScalarSelect, forScalarSubQuery, forColumnQuery) { }
        public void ColumnMyselfId() { doColumn("MYSELF_ID"); }
        public void ColumnMyselfName() { doColumn("MYSELF_NAME"); }
        protected override void doSpecifyRequiredColumn() {
            ColumnMyselfId(); // PK
        }
        protected override String getTableDbName() { return "myself"; }
        public RAFunction<LdMyselfCheckCB, LdMyselfCQ> DerivedMyselfCheckList() {
            if (xhasSyncQyCall()) { xsyncQyCall().qy(); } // for sync (for example, this in ColumnQuery)
            return new RAFunction<LdMyselfCheckCB, LdMyselfCQ>(_baseCB, _qyCall.qy(), delegate(String function, LdSubQuery<LdMyselfCheckCB> subQuery, LdMyselfCQ cq, String aliasName)
                { cq.xsderiveMyselfCheckList(function, subQuery, aliasName); });
        }
    }
}
