
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
    public class LdBsBlackActionLookupCB : LdAbstractConditionBean {

        // ===============================================================================
        //                                                                       Attribute
        //                                                                       =========
        protected LdBlackActionLookupCQ _conditionQuery;

        // ===============================================================================
        //                                                                      Table Name
        //                                                                      ==========
        public override String TableDbName { get { return "black_action_lookup"; } }

        // ===============================================================================
        //                                                             PrimaryKey Handling
        //                                                             ===================
        public void AcceptPrimaryKey(String blackActionCode) {
            assertObjectNotNull("blackActionCode", blackActionCode);
            LdBsBlackActionLookupCB cb = this;
            cb.Query().SetBlackActionCode_Equal(blackActionCode);
        }

        public override LdConditionBean AddOrderBy_PK_Asc() {
            Query().AddOrderBy_BlackActionCode_Asc();
            return this;
        }

        public override LdConditionBean AddOrderBy_PK_Desc() {
            Query().AddOrderBy_BlackActionCode_Desc();
            return this;
        }

        // ===============================================================================
        //                                                                           Query
        //                                                                           =====
        public LdBlackActionLookupCQ Query() {
            return this.ConditionQuery;
        }

        public LdBlackActionLookupCQ ConditionQuery {
            get {
                if (_conditionQuery == null) {
                    _conditionQuery = CreateLocalCQ();
                }
                return _conditionQuery;
            }
        }

        protected virtual LdBlackActionLookupCQ CreateLocalCQ() {
            return xcreateCQ(null, this.SqlClause, this.SqlClause.getBasePointAliasName(), 0);
        }

        protected virtual LdBlackActionLookupCQ xcreateCQ(LdConditionQuery childQuery, LdSqlClause sqlClause, String aliasName, int nestLevel) {
            return new LdBlackActionLookupCQ(childQuery, sqlClause, aliasName, nestLevel);
        }

        public override LdConditionQuery LocalCQ {
            get { return this.ConditionQuery; }
        }

        // ===============================================================================
        //                                                                           Union
        //                                                                           =====
	    public virtual void Union(LdUnionQuery<LdBlackActionLookupCB> unionQuery) {
            LdBlackActionLookupCB cb = new LdBlackActionLookupCB();
            cb.xsetupForUnion(this); xsyncUQ(cb); unionQuery.Invoke(cb);
		    LdBlackActionLookupCQ cq = cb.Query(); Query().xsetUnionQuery(cq);
        }

	    public virtual void UnionAll(LdUnionQuery<LdBlackActionLookupCB> unionQuery) {
            LdBlackActionLookupCB cb = new LdBlackActionLookupCB();
            cb.xsetupForUnion(this); xsyncUQ(cb); unionQuery.Invoke(cb);
		    LdBlackActionLookupCQ cq = cb.Query(); Query().xsetUnionAllQuery(cq);
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
        protected LdBlackActionLookupCBSpecification _specification;
        public LdBlackActionLookupCBSpecification Specify() {
            if (_specification == null) { _specification = new LdBlackActionLookupCBSpecification(this, new MySpQyCall(this), _forDerivedReferrer, _forScalarSelect, _forScalarCondition, _forColumnQuery); }
            return _specification;
        }
        protected bool HasSpecifiedColumn { get {
            return _specification != null && _specification.IsAlreadySpecifiedRequiredColumn;
        }}
        protected class MySpQyCall : HpSpQyCall<LdBlackActionLookupCQ> {
			protected LdBsBlackActionLookupCB _myCB;
			public MySpQyCall(LdBsBlackActionLookupCB myCB) { _myCB = myCB; }
    		public bool has() { return true; } public LdBlackActionLookupCQ qy() { return _myCB.Query(); }
    	}

        // [DBFlute-0.8.9.18]
        // ===============================================================================
        //                                                                     ColumnQuery
        //                                                                     ===========
        public HpColQyOperand<LdBlackActionLookupCB> ColumnQuery(LdSpecifyQuery<LdBlackActionLookupCB> leftSpecifyQuery) {
            return new HpColQyOperand<LdBlackActionLookupCB>(delegate(LdSpecifyQuery<LdBlackActionLookupCB> rightSp, String operand) {
                xcolqy(xcreateColumnQueryCB(), xcreateColumnQueryCB(), leftSpecifyQuery, rightSp, operand);
            });
        }

        protected LdBlackActionLookupCB xcreateColumnQueryCB() {
            LdBlackActionLookupCB cb = new LdBlackActionLookupCB();
            cb.xsetupForColumnQuery((LdBlackActionLookupCB)this);
            return cb;
        }

        // [DBFlute-0.8.9.9]
        // ===============================================================================
        //                                                                    OrScopeQuery
        //                                                                    ============
        public void OrScopeQuery(LdOrQuery<LdBlackActionLookupCB> orQuery) {
            xorQ((LdBlackActionLookupCB)this, orQuery);
        }

        // ===============================================================================
        //                                                                    Purpose Type
        //                                                                    ============
        public void xsetupForColumnQuery(LdBlackActionLookupCB mainCB) {
            xinheritSubQueryInfo(mainCB.LocalCQ);
            //xchangePurposeSqlClause(HpCBPurpose.COLUMN_QUERY);
            _forColumnQuery = true; // old style

            // inherits a parent query to synchronize real name
            // (and also for suppressing query check) 
            Specify().xsetSyncQyCall(new LdBlackActionLookupCBColQySpQyCall(mainCB));
        }
    }

    public class LdBlackActionLookupCBColQySpQyCall : HpSpQyCall<LdBlackActionLookupCQ> {
        protected LdBlackActionLookupCB _mainCB;
        public LdBlackActionLookupCBColQySpQyCall(LdBlackActionLookupCB mainCB) {
            _mainCB = mainCB;
        }
        public bool has() { return true; } 
        public LdBlackActionLookupCQ qy() { return _mainCB.Query(); } 
    }

    public class LdBlackActionLookupCBSpecification : AbstractSpecification<LdBlackActionLookupCQ> {
        public LdBlackActionLookupCBSpecification(LdConditionBean baseCB, HpSpQyCall<LdBlackActionLookupCQ> qyCall
                                                      , bool forDerivedReferrer, bool forScalarSelect, bool forScalarSubQuery, bool forColumnQuery)
        : base(baseCB, qyCall, forDerivedReferrer, forScalarSelect, forScalarSubQuery, forColumnQuery) { }
        public void ColumnBlackActionCode() { doColumn("BLACK_ACTION_CODE"); }
        public void ColumnBlackActionName() { doColumn("BLACK_ACTION_NAME"); }
        public void ColumnRUser() { doColumn("R_USER"); }
        public void ColumnRModule() { doColumn("R_MODULE"); }
        public void ColumnRTimestamp() { doColumn("R_TIMESTAMP"); }
        public void ColumnUUser() { doColumn("U_USER"); }
        public void ColumnUModule() { doColumn("U_MODULE"); }
        public void ColumnUTimestamp() { doColumn("U_TIMESTAMP"); }
        protected override void doSpecifyRequiredColumn() {
            ColumnBlackActionCode(); // PK
        }
        protected override String getTableDbName() { return "black_action_lookup"; }
        public RAFunction<LdBlackActionCB, LdBlackActionLookupCQ> DerivedBlackActionList() {
            if (xhasSyncQyCall()) { xsyncQyCall().qy(); } // for sync (for example, this in ColumnQuery)
            return new RAFunction<LdBlackActionCB, LdBlackActionLookupCQ>(_baseCB, _qyCall.qy(), delegate(String function, LdSubQuery<LdBlackActionCB> subQuery, LdBlackActionLookupCQ cq, String aliasName)
                { cq.xsderiveBlackActionList(function, subQuery, aliasName); });
        }
    }
}
