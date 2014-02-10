
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
    public class MbBsWithdrawalReasonCB : MbAbstractConditionBean {

        // ===============================================================================
        //                                                                       Attribute
        //                                                                       =========
        protected MbWithdrawalReasonCQ _conditionQuery;

        // ===============================================================================
        //                                                                      Table Name
        //                                                                      ==========
        public override String TableDbName { get { return "withdrawal_reason"; } }

        // ===============================================================================
        //                                                             PrimaryKey Handling
        //                                                             ===================
        public void AcceptPrimaryKey(String withdrawalReasonCode) {
            assertObjectNotNull("withdrawalReasonCode", withdrawalReasonCode);
            MbBsWithdrawalReasonCB cb = this;
            cb.Query().SetWithdrawalReasonCode_Equal(withdrawalReasonCode);
        }

        public override MbConditionBean AddOrderBy_PK_Asc() {
            Query().AddOrderBy_WithdrawalReasonCode_Asc();
            return this;
        }

        public override MbConditionBean AddOrderBy_PK_Desc() {
            Query().AddOrderBy_WithdrawalReasonCode_Desc();
            return this;
        }

        // ===============================================================================
        //                                                                           Query
        //                                                                           =====
        public MbWithdrawalReasonCQ Query() {
            return this.ConditionQuery;
        }

        public MbWithdrawalReasonCQ ConditionQuery {
            get {
                if (_conditionQuery == null) {
                    _conditionQuery = CreateLocalCQ();
                }
                return _conditionQuery;
            }
        }

        protected virtual MbWithdrawalReasonCQ CreateLocalCQ() {
            return xcreateCQ(null, this.SqlClause, this.SqlClause.getBasePointAliasName(), 0);
        }

        protected virtual MbWithdrawalReasonCQ xcreateCQ(MbConditionQuery childQuery, MbSqlClause sqlClause, String aliasName, int nestLevel) {
            return new MbWithdrawalReasonCQ(childQuery, sqlClause, aliasName, nestLevel);
        }

        public override MbConditionQuery LocalCQ {
            get { return this.ConditionQuery; }
        }

        // ===============================================================================
        //                                                                           Union
        //                                                                           =====
	    public virtual void Union(MbUnionQuery<MbWithdrawalReasonCB> unionQuery) {
            MbWithdrawalReasonCB cb = new MbWithdrawalReasonCB();
            cb.xsetupForUnion(this); xsyncUQ(cb); unionQuery.Invoke(cb);
		    MbWithdrawalReasonCQ cq = cb.Query(); Query().xsetUnionQuery(cq);
        }

	    public virtual void UnionAll(MbUnionQuery<MbWithdrawalReasonCB> unionQuery) {
            MbWithdrawalReasonCB cb = new MbWithdrawalReasonCB();
            cb.xsetupForUnion(this); xsyncUQ(cb); unionQuery.Invoke(cb);
		    MbWithdrawalReasonCQ cq = cb.Query(); Query().xsetUnionAllQuery(cq);
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
        protected MbWithdrawalReasonCBSpecification _specification;
        public MbWithdrawalReasonCBSpecification Specify() {
            if (_specification == null) { _specification = new MbWithdrawalReasonCBSpecification(this, new MySpQyCall(this), _forDerivedReferrer, _forScalarSelect, _forScalarCondition, _forColumnQuery); }
            return _specification;
        }
        protected bool HasSpecifiedColumn { get {
            return _specification != null && _specification.IsAlreadySpecifiedRequiredColumn;
        }}
        protected class MySpQyCall : HpSpQyCall<MbWithdrawalReasonCQ> {
			protected MbBsWithdrawalReasonCB _myCB;
			public MySpQyCall(MbBsWithdrawalReasonCB myCB) { _myCB = myCB; }
    		public bool has() { return true; } public MbWithdrawalReasonCQ qy() { return _myCB.Query(); }
    	}

        // [DBFlute-0.8.9.18]
        // ===============================================================================
        //                                                                     ColumnQuery
        //                                                                     ===========
        public HpColQyOperand<MbWithdrawalReasonCB> ColumnQuery(MbSpecifyQuery<MbWithdrawalReasonCB> leftSpecifyQuery) {
            return new HpColQyOperand<MbWithdrawalReasonCB>(delegate(MbSpecifyQuery<MbWithdrawalReasonCB> rightSp, String operand) {
                xcolqy(xcreateColumnQueryCB(), xcreateColumnQueryCB(), leftSpecifyQuery, rightSp, operand);
            });
        }

        protected MbWithdrawalReasonCB xcreateColumnQueryCB() {
            MbWithdrawalReasonCB cb = new MbWithdrawalReasonCB();
            cb.xsetupForColumnQuery((MbWithdrawalReasonCB)this);
            return cb;
        }

        // [DBFlute-0.8.9.9]
        // ===============================================================================
        //                                                                    OrScopeQuery
        //                                                                    ============
        public void OrScopeQuery(MbOrQuery<MbWithdrawalReasonCB> orQuery) {
            xorQ((MbWithdrawalReasonCB)this, orQuery);
        }

        // ===============================================================================
        //                                                                    Purpose Type
        //                                                                    ============
        public void xsetupForColumnQuery(MbWithdrawalReasonCB mainCB) {
            xinheritSubQueryInfo(mainCB.LocalCQ);
            //xchangePurposeSqlClause(HpCBPurpose.COLUMN_QUERY);
            _forColumnQuery = true; // old style

            // inherits a parent query to synchronize real name
            // (and also for suppressing query check) 
            Specify().xsetSyncQyCall(new MbWithdrawalReasonCBColQySpQyCall(mainCB));
        }
    }

    public class MbWithdrawalReasonCBColQySpQyCall : HpSpQyCall<MbWithdrawalReasonCQ> {
        protected MbWithdrawalReasonCB _mainCB;
        public MbWithdrawalReasonCBColQySpQyCall(MbWithdrawalReasonCB mainCB) {
            _mainCB = mainCB;
        }
        public bool has() { return true; } 
        public MbWithdrawalReasonCQ qy() { return _mainCB.Query(); } 
    }

    public class MbWithdrawalReasonCBSpecification : AbstractSpecification<MbWithdrawalReasonCQ> {
        public MbWithdrawalReasonCBSpecification(MbConditionBean baseCB, HpSpQyCall<MbWithdrawalReasonCQ> qyCall
                                                      , bool forDerivedReferrer, bool forScalarSelect, bool forScalarSubQuery, bool forColumnQuery)
        : base(baseCB, qyCall, forDerivedReferrer, forScalarSelect, forScalarSubQuery, forColumnQuery) { }
        public void ColumnWithdrawalReasonCode() { doColumn("WITHDRAWAL_REASON_CODE"); }
        public void ColumnWithdrawalReasonText() { doColumn("WITHDRAWAL_REASON_TEXT"); }
        public void ColumnDisplayOrder() { doColumn("DISPLAY_ORDER"); }
        protected override void doSpecifyRequiredColumn() {
            ColumnWithdrawalReasonCode(); // PK
        }
        protected override String getTableDbName() { return "withdrawal_reason"; }
        public RAFunction<MbMemberWithdrawalCB, MbWithdrawalReasonCQ> DerivedMemberWithdrawalList() {
            if (xhasSyncQyCall()) { xsyncQyCall().qy(); } // for sync (for example, this in ColumnQuery)
            return new RAFunction<MbMemberWithdrawalCB, MbWithdrawalReasonCQ>(_baseCB, _qyCall.qy(), delegate(String function, MbSubQuery<MbMemberWithdrawalCB> subQuery, MbWithdrawalReasonCQ cq, String aliasName)
                { cq.xsderiveMemberWithdrawalList(function, subQuery, aliasName); });
        }
    }
}
