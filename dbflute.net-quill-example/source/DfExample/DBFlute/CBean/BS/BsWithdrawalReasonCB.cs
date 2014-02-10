
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
    public class BsWithdrawalReasonCB : AbstractConditionBean {

        // ===============================================================================
        //                                                                       Attribute
        //                                                                       =========
        protected WithdrawalReasonCQ _conditionQuery;

        // ===============================================================================
        //                                                                      Table Name
        //                                                                      ==========
        public override String TableDbName { get { return "withdrawal_reason"; } }

        // ===============================================================================
        //                                                             PrimaryKey Handling
        //                                                             ===================
        public void AcceptPrimaryKey(String withdrawalReasonCode) {
            assertObjectNotNull("withdrawalReasonCode", withdrawalReasonCode);
            BsWithdrawalReasonCB cb = this;
            cb.Query().SetWithdrawalReasonCode_Equal(withdrawalReasonCode);
        }

        public override ConditionBean AddOrderBy_PK_Asc() {
            Query().AddOrderBy_WithdrawalReasonCode_Asc();
            return this;
        }

        public override ConditionBean AddOrderBy_PK_Desc() {
            Query().AddOrderBy_WithdrawalReasonCode_Desc();
            return this;
        }

        // ===============================================================================
        //                                                                           Query
        //                                                                           =====
        public WithdrawalReasonCQ Query() {
            return this.ConditionQuery;
        }

        public WithdrawalReasonCQ ConditionQuery {
            get {
                if (_conditionQuery == null) {
                    _conditionQuery = CreateLocalCQ();
                }
                return _conditionQuery;
            }
        }

        protected virtual WithdrawalReasonCQ CreateLocalCQ() {
            return xcreateCQ(null, this.SqlClause, this.SqlClause.getBasePointAliasName(), 0);
        }

        protected virtual WithdrawalReasonCQ xcreateCQ(ConditionQuery childQuery, SqlClause sqlClause, String aliasName, int nestLevel) {
            return new WithdrawalReasonCQ(childQuery, sqlClause, aliasName, nestLevel);
        }

        public override ConditionQuery LocalCQ {
            get { return this.ConditionQuery; }
        }

        // ===============================================================================
        //                                                                           Union
        //                                                                           =====
	    public virtual void Union(UnionQuery<WithdrawalReasonCB> unionQuery) {
            WithdrawalReasonCB cb = new WithdrawalReasonCB();
            cb.xsetupForUnion(this); xsyncUQ(cb); unionQuery.Invoke(cb);
		    WithdrawalReasonCQ cq = cb.Query(); Query().xsetUnionQuery(cq);
        }

	    public virtual void UnionAll(UnionQuery<WithdrawalReasonCB> unionQuery) {
            WithdrawalReasonCB cb = new WithdrawalReasonCB();
            cb.xsetupForUnion(this); xsyncUQ(cb); unionQuery.Invoke(cb);
		    WithdrawalReasonCQ cq = cb.Query(); Query().xsetUnionAllQuery(cq);
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
        protected WithdrawalReasonCBSpecification _specification;
        public WithdrawalReasonCBSpecification Specify() {
            if (_specification == null) { _specification = new WithdrawalReasonCBSpecification(this, new MySpQyCall(this), _forDerivedReferrer, _forScalarSelect, _forScalarCondition, _forColumnQuery); }
            return _specification;
        }
        protected bool HasSpecifiedColumn { get {
            return _specification != null && _specification.IsAlreadySpecifiedRequiredColumn;
        }}
        protected class MySpQyCall : HpSpQyCall<WithdrawalReasonCQ> {
			protected BsWithdrawalReasonCB _myCB;
			public MySpQyCall(BsWithdrawalReasonCB myCB) { _myCB = myCB; }
    		public bool has() { return true; } public WithdrawalReasonCQ qy() { return _myCB.Query(); }
    	}

        // [DBFlute-0.8.9.18]
        // ===============================================================================
        //                                                                     ColumnQuery
        //                                                                     ===========
        public HpColQyOperand<WithdrawalReasonCB> ColumnQuery(SpecifyQuery<WithdrawalReasonCB> leftSpecifyQuery) {
            return new HpColQyOperand<WithdrawalReasonCB>(delegate(SpecifyQuery<WithdrawalReasonCB> rightSp, String operand) {
                xcolqy(xcreateColumnQueryCB(), xcreateColumnQueryCB(), leftSpecifyQuery, rightSp, operand);
            });
        }

        protected WithdrawalReasonCB xcreateColumnQueryCB() {
            WithdrawalReasonCB cb = new WithdrawalReasonCB();
            cb.xsetupForColumnQuery((WithdrawalReasonCB)this);
            return cb;
        }

        // [DBFlute-0.8.9.9]
        // ===============================================================================
        //                                                                    OrScopeQuery
        //                                                                    ============
        public void OrScopeQuery(OrQuery<WithdrawalReasonCB> orQuery) {
            xorQ((WithdrawalReasonCB)this, orQuery);
        }

        // ===============================================================================
        //                                                                    Purpose Type
        //                                                                    ============
        public void xsetupForColumnQuery(WithdrawalReasonCB mainCB) {
            xinheritSubQueryInfo(mainCB.LocalCQ);
            //xchangePurposeSqlClause(HpCBPurpose.COLUMN_QUERY);
            _forColumnQuery = true; // old style

            // inherits a parent query to synchronize real name
            // (and also for suppressing query check) 
            Specify().xsetSyncQyCall(new WithdrawalReasonCBColQySpQyCall(mainCB));
        }
    }

    public class WithdrawalReasonCBColQySpQyCall : HpSpQyCall<WithdrawalReasonCQ> {
        protected WithdrawalReasonCB _mainCB;
        public WithdrawalReasonCBColQySpQyCall(WithdrawalReasonCB mainCB) {
            _mainCB = mainCB;
        }
        public bool has() { return true; } 
        public WithdrawalReasonCQ qy() { return _mainCB.Query(); } 
    }

    public class WithdrawalReasonCBSpecification : AbstractSpecification<WithdrawalReasonCQ> {
        public WithdrawalReasonCBSpecification(ConditionBean baseCB, HpSpQyCall<WithdrawalReasonCQ> qyCall
                                                      , bool forDerivedReferrer, bool forScalarSelect, bool forScalarSubQuery, bool forColumnQuery)
        : base(baseCB, qyCall, forDerivedReferrer, forScalarSelect, forScalarSubQuery, forColumnQuery) { }
        public void ColumnWithdrawalReasonCode() { doColumn("WITHDRAWAL_REASON_CODE"); }
        public void ColumnWithdrawalReasonText() { doColumn("WITHDRAWAL_REASON_TEXT"); }
        public void ColumnDisplayOrder() { doColumn("DISPLAY_ORDER"); }
        protected override void doSpecifyRequiredColumn() {
            ColumnWithdrawalReasonCode(); // PK
        }
        protected override String getTableDbName() { return "withdrawal_reason"; }
        public RAFunction<MemberWithdrawalCB, WithdrawalReasonCQ> DerivedMemberWithdrawalList() {
            if (xhasSyncQyCall()) { xsyncQyCall().qy(); } // for sync (for example, this in ColumnQuery)
            return new RAFunction<MemberWithdrawalCB, WithdrawalReasonCQ>(_baseCB, _qyCall.qy(), delegate(String function, SubQuery<MemberWithdrawalCB> subQuery, WithdrawalReasonCQ cq, String aliasName)
                { cq.xsderiveMemberWithdrawalList(function, subQuery, aliasName); });
        }
    }
}
