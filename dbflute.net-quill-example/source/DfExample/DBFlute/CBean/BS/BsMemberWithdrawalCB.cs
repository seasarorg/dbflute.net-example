
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
    public class BsMemberWithdrawalCB : AbstractConditionBean {

        // ===============================================================================
        //                                                                       Attribute
        //                                                                       =========
        protected MemberWithdrawalCQ _conditionQuery;

        // ===============================================================================
        //                                                                      Table Name
        //                                                                      ==========
        public override String TableDbName { get { return "member_withdrawal"; } }

        // ===============================================================================
        //                                                             PrimaryKey Handling
        //                                                             ===================
        public void AcceptPrimaryKey(int? memberId) {
            assertObjectNotNull("memberId", memberId);
            BsMemberWithdrawalCB cb = this;
            cb.Query().SetMemberId_Equal(memberId);
        }

        public override ConditionBean AddOrderBy_PK_Asc() {
            Query().AddOrderBy_MemberId_Asc();
            return this;
        }

        public override ConditionBean AddOrderBy_PK_Desc() {
            Query().AddOrderBy_MemberId_Desc();
            return this;
        }

        // ===============================================================================
        //                                                                           Query
        //                                                                           =====
        public MemberWithdrawalCQ Query() {
            return this.ConditionQuery;
        }

        public MemberWithdrawalCQ ConditionQuery {
            get {
                if (_conditionQuery == null) {
                    _conditionQuery = CreateLocalCQ();
                }
                return _conditionQuery;
            }
        }

        protected virtual MemberWithdrawalCQ CreateLocalCQ() {
            return xcreateCQ(null, this.SqlClause, this.SqlClause.getBasePointAliasName(), 0);
        }

        protected virtual MemberWithdrawalCQ xcreateCQ(ConditionQuery childQuery, SqlClause sqlClause, String aliasName, int nestLevel) {
            return new MemberWithdrawalCQ(childQuery, sqlClause, aliasName, nestLevel);
        }

        public override ConditionQuery LocalCQ {
            get { return this.ConditionQuery; }
        }

        // ===============================================================================
        //                                                                           Union
        //                                                                           =====
	    public virtual void Union(UnionQuery<MemberWithdrawalCB> unionQuery) {
            MemberWithdrawalCB cb = new MemberWithdrawalCB();
            cb.xsetupForUnion(this); xsyncUQ(cb); unionQuery.Invoke(cb);
		    MemberWithdrawalCQ cq = cb.Query(); Query().xsetUnionQuery(cq);
        }

	    public virtual void UnionAll(UnionQuery<MemberWithdrawalCB> unionQuery) {
            MemberWithdrawalCB cb = new MemberWithdrawalCB();
            cb.xsetupForUnion(this); xsyncUQ(cb); unionQuery.Invoke(cb);
		    MemberWithdrawalCQ cq = cb.Query(); Query().xsetUnionAllQuery(cq);
	    }

        public override bool HasUnionQueryOrUnionAllQuery() {
            return Query().hasUnionQueryOrUnionAllQuery();
        }

        // ===============================================================================
        //                                                                    Setup Select
        //                                                                    ============
        protected MemberNss _nssMember;
        public MemberNss NssMember { get {
            if (_nssMember == null) { _nssMember = new MemberNss(null); }
            return _nssMember;
        }}
        public MemberNss SetupSelect_Member() {
            doSetupSelect(delegate { return Query().QueryMember(); });
            if (_nssMember == null || !_nssMember.HasConditionQuery)
            { _nssMember = new MemberNss(Query().QueryMember()); }
            return _nssMember;
        }
        protected WithdrawalReasonNss _nssWithdrawalReason;
        public WithdrawalReasonNss NssWithdrawalReason { get {
            if (_nssWithdrawalReason == null) { _nssWithdrawalReason = new WithdrawalReasonNss(null); }
            return _nssWithdrawalReason;
        }}
        public WithdrawalReasonNss SetupSelect_WithdrawalReason() {
            if (HasSpecifiedColumn) { // if reverse call
                Specify().ColumnWithdrawalReasonCode();
            }
            doSetupSelect(delegate { return Query().QueryWithdrawalReason(); });
            if (_nssWithdrawalReason == null || !_nssWithdrawalReason.HasConditionQuery)
            { _nssWithdrawalReason = new WithdrawalReasonNss(Query().QueryWithdrawalReason()); }
            return _nssWithdrawalReason;
        }

        // [DBFlute-0.7.4]
        // ===============================================================================
        //                                                                         Specify
        //                                                                         =======
        protected MemberWithdrawalCBSpecification _specification;
        public MemberWithdrawalCBSpecification Specify() {
            if (_specification == null) { _specification = new MemberWithdrawalCBSpecification(this, new MySpQyCall(this), _forDerivedReferrer, _forScalarSelect, _forScalarCondition, _forColumnQuery); }
            return _specification;
        }
        protected bool HasSpecifiedColumn { get {
            return _specification != null && _specification.IsAlreadySpecifiedRequiredColumn;
        }}
        protected class MySpQyCall : HpSpQyCall<MemberWithdrawalCQ> {
			protected BsMemberWithdrawalCB _myCB;
			public MySpQyCall(BsMemberWithdrawalCB myCB) { _myCB = myCB; }
    		public bool has() { return true; } public MemberWithdrawalCQ qy() { return _myCB.Query(); }
    	}

        // [DBFlute-0.8.9.18]
        // ===============================================================================
        //                                                                     ColumnQuery
        //                                                                     ===========
        public HpColQyOperand<MemberWithdrawalCB> ColumnQuery(SpecifyQuery<MemberWithdrawalCB> leftSpecifyQuery) {
            return new HpColQyOperand<MemberWithdrawalCB>(delegate(SpecifyQuery<MemberWithdrawalCB> rightSp, String operand) {
                xcolqy(xcreateColumnQueryCB(), xcreateColumnQueryCB(), leftSpecifyQuery, rightSp, operand);
            });
        }

        protected MemberWithdrawalCB xcreateColumnQueryCB() {
            MemberWithdrawalCB cb = new MemberWithdrawalCB();
            cb.xsetupForColumnQuery((MemberWithdrawalCB)this);
            return cb;
        }

        // [DBFlute-0.8.9.9]
        // ===============================================================================
        //                                                                    OrScopeQuery
        //                                                                    ============
        public void OrScopeQuery(OrQuery<MemberWithdrawalCB> orQuery) {
            xorQ((MemberWithdrawalCB)this, orQuery);
        }

        // ===============================================================================
        //                                                                    Purpose Type
        //                                                                    ============
        public void xsetupForColumnQuery(MemberWithdrawalCB mainCB) {
            xinheritSubQueryInfo(mainCB.LocalCQ);
            //xchangePurposeSqlClause(HpCBPurpose.COLUMN_QUERY);
            _forColumnQuery = true; // old style

            // inherits a parent query to synchronize real name
            // (and also for suppressing query check) 
            Specify().xsetSyncQyCall(new MemberWithdrawalCBColQySpQyCall(mainCB));
        }
    }

    public class MemberWithdrawalCBColQySpQyCall : HpSpQyCall<MemberWithdrawalCQ> {
        protected MemberWithdrawalCB _mainCB;
        public MemberWithdrawalCBColQySpQyCall(MemberWithdrawalCB mainCB) {
            _mainCB = mainCB;
        }
        public bool has() { return true; } 
        public MemberWithdrawalCQ qy() { return _mainCB.Query(); } 
    }

    public class MemberWithdrawalCBSpecification : AbstractSpecification<MemberWithdrawalCQ> {
        protected MemberCBSpecification _member;
        protected WithdrawalReasonCBSpecification _withdrawalReason;
        public MemberWithdrawalCBSpecification(ConditionBean baseCB, HpSpQyCall<MemberWithdrawalCQ> qyCall
                                                      , bool forDerivedReferrer, bool forScalarSelect, bool forScalarSubQuery, bool forColumnQuery)
        : base(baseCB, qyCall, forDerivedReferrer, forScalarSelect, forScalarSubQuery, forColumnQuery) { }
        public void ColumnMemberId() { doColumn("MEMBER_ID"); }
        public void ColumnWithdrawalReasonCode() { doColumn("WITHDRAWAL_REASON_CODE"); }
        public void ColumnWithdrawalReasonInputText() { doColumn("WITHDRAWAL_REASON_INPUT_TEXT"); }
        public void ColumnWithdrawalDatetime() { doColumn("WITHDRAWAL_DATETIME"); }
        public void ColumnRegisterDatetime() { doColumn("REGISTER_DATETIME"); }
        public void ColumnRegisterProcess() { doColumn("REGISTER_PROCESS"); }
        public void ColumnRegisterUser() { doColumn("REGISTER_USER"); }
        public void ColumnUpdateDatetime() { doColumn("UPDATE_DATETIME"); }
        public void ColumnUpdateProcess() { doColumn("UPDATE_PROCESS"); }
        public void ColumnUpdateUser() { doColumn("UPDATE_USER"); }
        public void ColumnVersionNo() { doColumn("VERSION_NO"); }
        protected override void doSpecifyRequiredColumn() {
            ColumnMemberId(); // PK
            if (qyCall().qy().hasConditionQueryWithdrawalReason()
                    || qyCall().qy().xgetReferrerQuery() is WithdrawalReasonCQ) {
                ColumnWithdrawalReasonCode(); // FK or one-to-one referrer
            }
        }
        protected override String getTableDbName() { return "member_withdrawal"; }
        public MemberCBSpecification SpecifyMember() {
            assertForeign("member");
            if (_member == null) {
                _member = new MemberCBSpecification(_baseCB, new MemberSpQyCall(_qyCall), _forDerivedReferrer, _forScalarSelect, _forScalarCondition, _forColumnQuery);
                if (xhasSyncQyCall()) // inherits it
                { _member.xsetSyncQyCall(new MemberSpQyCall(xsyncQyCall())); }
            }
            return _member;
        }
		public class MemberSpQyCall : HpSpQyCall<MemberCQ> {
		    protected HpSpQyCall<MemberWithdrawalCQ> _qyCall;
		    public MemberSpQyCall(HpSpQyCall<MemberWithdrawalCQ> myQyCall) { _qyCall = myQyCall; }
		    public bool has() { return _qyCall.has() && _qyCall.qy().hasConditionQueryMember(); }
			public MemberCQ qy() { return _qyCall.qy().QueryMember(); }
		}
        public WithdrawalReasonCBSpecification SpecifyWithdrawalReason() {
            assertForeign("withdrawalReason");
            if (_withdrawalReason == null) {
                _withdrawalReason = new WithdrawalReasonCBSpecification(_baseCB, new WithdrawalReasonSpQyCall(_qyCall), _forDerivedReferrer, _forScalarSelect, _forScalarCondition, _forColumnQuery);
                if (xhasSyncQyCall()) // inherits it
                { _withdrawalReason.xsetSyncQyCall(new WithdrawalReasonSpQyCall(xsyncQyCall())); }
            }
            return _withdrawalReason;
        }
		public class WithdrawalReasonSpQyCall : HpSpQyCall<WithdrawalReasonCQ> {
		    protected HpSpQyCall<MemberWithdrawalCQ> _qyCall;
		    public WithdrawalReasonSpQyCall(HpSpQyCall<MemberWithdrawalCQ> myQyCall) { _qyCall = myQyCall; }
		    public bool has() { return _qyCall.has() && _qyCall.qy().hasConditionQueryWithdrawalReason(); }
			public WithdrawalReasonCQ qy() { return _qyCall.qy().QueryWithdrawalReason(); }
		}
    }
}
