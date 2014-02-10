
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
    public class MbBsMemberWithdrawalCB : MbAbstractConditionBean {

        // ===============================================================================
        //                                                                       Attribute
        //                                                                       =========
        protected MbMemberWithdrawalCQ _conditionQuery;

        // ===============================================================================
        //                                                                      Table Name
        //                                                                      ==========
        public override String TableDbName { get { return "member_withdrawal"; } }

        // ===============================================================================
        //                                                             PrimaryKey Handling
        //                                                             ===================
        public void AcceptPrimaryKey(int? memberId) {
            assertObjectNotNull("memberId", memberId);
            MbBsMemberWithdrawalCB cb = this;
            cb.Query().SetMemberId_Equal(memberId);
        }

        public override MbConditionBean AddOrderBy_PK_Asc() {
            Query().AddOrderBy_MemberId_Asc();
            return this;
        }

        public override MbConditionBean AddOrderBy_PK_Desc() {
            Query().AddOrderBy_MemberId_Desc();
            return this;
        }

        // ===============================================================================
        //                                                                           Query
        //                                                                           =====
        public MbMemberWithdrawalCQ Query() {
            return this.ConditionQuery;
        }

        public MbMemberWithdrawalCQ ConditionQuery {
            get {
                if (_conditionQuery == null) {
                    _conditionQuery = CreateLocalCQ();
                }
                return _conditionQuery;
            }
        }

        protected virtual MbMemberWithdrawalCQ CreateLocalCQ() {
            return xcreateCQ(null, this.SqlClause, this.SqlClause.getBasePointAliasName(), 0);
        }

        protected virtual MbMemberWithdrawalCQ xcreateCQ(MbConditionQuery childQuery, MbSqlClause sqlClause, String aliasName, int nestLevel) {
            return new MbMemberWithdrawalCQ(childQuery, sqlClause, aliasName, nestLevel);
        }

        public override MbConditionQuery LocalCQ {
            get { return this.ConditionQuery; }
        }

        // ===============================================================================
        //                                                                           Union
        //                                                                           =====
	    public virtual void Union(MbUnionQuery<MbMemberWithdrawalCB> unionQuery) {
            MbMemberWithdrawalCB cb = new MbMemberWithdrawalCB();
            cb.xsetupForUnion(this); xsyncUQ(cb); unionQuery.Invoke(cb);
		    MbMemberWithdrawalCQ cq = cb.Query(); Query().xsetUnionQuery(cq);
        }

	    public virtual void UnionAll(MbUnionQuery<MbMemberWithdrawalCB> unionQuery) {
            MbMemberWithdrawalCB cb = new MbMemberWithdrawalCB();
            cb.xsetupForUnion(this); xsyncUQ(cb); unionQuery.Invoke(cb);
		    MbMemberWithdrawalCQ cq = cb.Query(); Query().xsetUnionAllQuery(cq);
	    }

        public override bool HasUnionQueryOrUnionAllQuery() {
            return Query().hasUnionQueryOrUnionAllQuery();
        }

        // ===============================================================================
        //                                                                    Setup Select
        //                                                                    ============
        protected MbMemberNss _nssMember;
        public MbMemberNss NssMember { get {
            if (_nssMember == null) { _nssMember = new MbMemberNss(null); }
            return _nssMember;
        }}
        public MbMemberNss SetupSelect_Member() {
            doSetupSelect(delegate { return Query().QueryMember(); });
            if (_nssMember == null || !_nssMember.HasConditionQuery)
            { _nssMember = new MbMemberNss(Query().QueryMember()); }
            return _nssMember;
        }
        protected MbWithdrawalReasonNss _nssWithdrawalReason;
        public MbWithdrawalReasonNss NssWithdrawalReason { get {
            if (_nssWithdrawalReason == null) { _nssWithdrawalReason = new MbWithdrawalReasonNss(null); }
            return _nssWithdrawalReason;
        }}
        public MbWithdrawalReasonNss SetupSelect_WithdrawalReason() {
            if (HasSpecifiedColumn) { // if reverse call
                Specify().ColumnWithdrawalReasonCode();
            }
            doSetupSelect(delegate { return Query().QueryWithdrawalReason(); });
            if (_nssWithdrawalReason == null || !_nssWithdrawalReason.HasConditionQuery)
            { _nssWithdrawalReason = new MbWithdrawalReasonNss(Query().QueryWithdrawalReason()); }
            return _nssWithdrawalReason;
        }

        // [DBFlute-0.7.4]
        // ===============================================================================
        //                                                                         Specify
        //                                                                         =======
        protected MbMemberWithdrawalCBSpecification _specification;
        public MbMemberWithdrawalCBSpecification Specify() {
            if (_specification == null) { _specification = new MbMemberWithdrawalCBSpecification(this, new MySpQyCall(this), _forDerivedReferrer, _forScalarSelect, _forScalarCondition, _forColumnQuery); }
            return _specification;
        }
        protected bool HasSpecifiedColumn { get {
            return _specification != null && _specification.IsAlreadySpecifiedRequiredColumn;
        }}
        protected class MySpQyCall : HpSpQyCall<MbMemberWithdrawalCQ> {
			protected MbBsMemberWithdrawalCB _myCB;
			public MySpQyCall(MbBsMemberWithdrawalCB myCB) { _myCB = myCB; }
    		public bool has() { return true; } public MbMemberWithdrawalCQ qy() { return _myCB.Query(); }
    	}

        // [DBFlute-0.8.9.18]
        // ===============================================================================
        //                                                                     ColumnQuery
        //                                                                     ===========
        public HpColQyOperand<MbMemberWithdrawalCB> ColumnQuery(MbSpecifyQuery<MbMemberWithdrawalCB> leftSpecifyQuery) {
            return new HpColQyOperand<MbMemberWithdrawalCB>(delegate(MbSpecifyQuery<MbMemberWithdrawalCB> rightSp, String operand) {
                xcolqy(xcreateColumnQueryCB(), xcreateColumnQueryCB(), leftSpecifyQuery, rightSp, operand);
            });
        }

        protected MbMemberWithdrawalCB xcreateColumnQueryCB() {
            MbMemberWithdrawalCB cb = new MbMemberWithdrawalCB();
            cb.xsetupForColumnQuery((MbMemberWithdrawalCB)this);
            return cb;
        }

        // [DBFlute-0.8.9.9]
        // ===============================================================================
        //                                                                    OrScopeQuery
        //                                                                    ============
        public void OrScopeQuery(MbOrQuery<MbMemberWithdrawalCB> orQuery) {
            xorQ((MbMemberWithdrawalCB)this, orQuery);
        }

        // ===============================================================================
        //                                                                    Purpose Type
        //                                                                    ============
        public void xsetupForColumnQuery(MbMemberWithdrawalCB mainCB) {
            xinheritSubQueryInfo(mainCB.LocalCQ);
            //xchangePurposeSqlClause(HpCBPurpose.COLUMN_QUERY);
            _forColumnQuery = true; // old style

            // inherits a parent query to synchronize real name
            // (and also for suppressing query check) 
            Specify().xsetSyncQyCall(new MbMemberWithdrawalCBColQySpQyCall(mainCB));
        }
    }

    public class MbMemberWithdrawalCBColQySpQyCall : HpSpQyCall<MbMemberWithdrawalCQ> {
        protected MbMemberWithdrawalCB _mainCB;
        public MbMemberWithdrawalCBColQySpQyCall(MbMemberWithdrawalCB mainCB) {
            _mainCB = mainCB;
        }
        public bool has() { return true; } 
        public MbMemberWithdrawalCQ qy() { return _mainCB.Query(); } 
    }

    public class MbMemberWithdrawalCBSpecification : AbstractSpecification<MbMemberWithdrawalCQ> {
        protected MbMemberCBSpecification _member;
        protected MbWithdrawalReasonCBSpecification _withdrawalReason;
        public MbMemberWithdrawalCBSpecification(MbConditionBean baseCB, HpSpQyCall<MbMemberWithdrawalCQ> qyCall
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
                    || qyCall().qy().xgetReferrerQuery() is MbWithdrawalReasonCQ) {
                ColumnWithdrawalReasonCode(); // FK or one-to-one referrer
            }
        }
        protected override String getTableDbName() { return "member_withdrawal"; }
        public MbMemberCBSpecification SpecifyMember() {
            assertForeign("member");
            if (_member == null) {
                _member = new MbMemberCBSpecification(_baseCB, new MemberSpQyCall(_qyCall), _forDerivedReferrer, _forScalarSelect, _forScalarCondition, _forColumnQuery);
                if (xhasSyncQyCall()) // inherits it
                { _member.xsetSyncQyCall(new MemberSpQyCall(xsyncQyCall())); }
            }
            return _member;
        }
		public class MemberSpQyCall : HpSpQyCall<MbMemberCQ> {
		    protected HpSpQyCall<MbMemberWithdrawalCQ> _qyCall;
		    public MemberSpQyCall(HpSpQyCall<MbMemberWithdrawalCQ> myQyCall) { _qyCall = myQyCall; }
		    public bool has() { return _qyCall.has() && _qyCall.qy().hasConditionQueryMember(); }
			public MbMemberCQ qy() { return _qyCall.qy().QueryMember(); }
		}
        public MbWithdrawalReasonCBSpecification SpecifyWithdrawalReason() {
            assertForeign("withdrawalReason");
            if (_withdrawalReason == null) {
                _withdrawalReason = new MbWithdrawalReasonCBSpecification(_baseCB, new WithdrawalReasonSpQyCall(_qyCall), _forDerivedReferrer, _forScalarSelect, _forScalarCondition, _forColumnQuery);
                if (xhasSyncQyCall()) // inherits it
                { _withdrawalReason.xsetSyncQyCall(new WithdrawalReasonSpQyCall(xsyncQyCall())); }
            }
            return _withdrawalReason;
        }
		public class WithdrawalReasonSpQyCall : HpSpQyCall<MbWithdrawalReasonCQ> {
		    protected HpSpQyCall<MbMemberWithdrawalCQ> _qyCall;
		    public WithdrawalReasonSpQyCall(HpSpQyCall<MbMemberWithdrawalCQ> myQyCall) { _qyCall = myQyCall; }
		    public bool has() { return _qyCall.has() && _qyCall.qy().hasConditionQueryWithdrawalReason(); }
			public MbWithdrawalReasonCQ qy() { return _qyCall.qy().QueryWithdrawalReason(); }
		}
    }
}
