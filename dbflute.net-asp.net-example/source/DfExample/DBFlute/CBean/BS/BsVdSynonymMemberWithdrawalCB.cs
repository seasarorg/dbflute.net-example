
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
    public class BsVdSynonymMemberWithdrawalCB : AbstractConditionBean {

        // ===============================================================================
        //                                                                       Attribute
        //                                                                       =========
        protected VdSynonymMemberWithdrawalCQ _conditionQuery;

        // ===============================================================================
        //                                                                      Table Name
        //                                                                      ==========
        public override String TableDbName { get { return "VD_SYNONYM_MEMBER_WITHDRAWAL"; } }

        // ===============================================================================
        //                                                             PrimaryKey Handling
        //                                                             ===================
        public void AcceptPrimaryKey(long? memberId) {
            assertObjectNotNull("memberId", memberId);
            BsVdSynonymMemberWithdrawalCB cb = this;
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
        public VdSynonymMemberWithdrawalCQ Query() {
            return this.ConditionQuery;
        }

        public VdSynonymMemberWithdrawalCQ ConditionQuery {
            get {
                if (_conditionQuery == null) {
                    _conditionQuery = CreateLocalCQ();
                }
                return _conditionQuery;
            }
        }

        protected virtual VdSynonymMemberWithdrawalCQ CreateLocalCQ() {
            return xcreateCQ(null, this.SqlClause, this.SqlClause.getBasePointAliasName(), 0);
        }

        protected virtual VdSynonymMemberWithdrawalCQ xcreateCQ(ConditionQuery childQuery, SqlClause sqlClause, String aliasName, int nestLevel) {
            return new VdSynonymMemberWithdrawalCQ(childQuery, sqlClause, aliasName, nestLevel);
        }

        public override ConditionQuery LocalCQ {
            get { return this.ConditionQuery; }
        }

        // ===============================================================================
        //                                                                           Union
        //                                                                           =====
	    public virtual void Union(UnionQuery<VdSynonymMemberWithdrawalCB> unionQuery) {
            VdSynonymMemberWithdrawalCB cb = new VdSynonymMemberWithdrawalCB();
            cb.xsetupForUnion(this); xsyncUQ(cb); unionQuery.Invoke(cb);
		    VdSynonymMemberWithdrawalCQ cq = cb.Query(); Query().xsetUnionQuery(cq);
        }

	    public virtual void UnionAll(UnionQuery<VdSynonymMemberWithdrawalCB> unionQuery) {
            VdSynonymMemberWithdrawalCB cb = new VdSynonymMemberWithdrawalCB();
            cb.xsetupForUnion(this); xsyncUQ(cb); unionQuery.Invoke(cb);
		    VdSynonymMemberWithdrawalCQ cq = cb.Query(); Query().xsetUnionAllQuery(cq);
	    }

        public override bool HasUnionQueryOrUnionAllQuery() {
            return Query().hasUnionQueryOrUnionAllQuery();
        }

        // ===============================================================================
        //                                                                    Setup Select
        //                                                                    ============
        protected MemberVendorSynonymNss _nssMemberVendorSynonym;
        public MemberVendorSynonymNss NssMemberVendorSynonym { get {
            if (_nssMemberVendorSynonym == null) { _nssMemberVendorSynonym = new MemberVendorSynonymNss(null); }
            return _nssMemberVendorSynonym;
        }}
        public MemberVendorSynonymNss SetupSelect_MemberVendorSynonym() {
            doSetupSelect(delegate { return Query().QueryMemberVendorSynonym(); });
            if (_nssMemberVendorSynonym == null || !_nssMemberVendorSynonym.HasConditionQuery)
            { _nssMemberVendorSynonym = new MemberVendorSynonymNss(Query().QueryMemberVendorSynonym()); }
            return _nssMemberVendorSynonym;
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
        protected VdSynonymMemberNss _nssVdSynonymMember;
        public VdSynonymMemberNss NssVdSynonymMember { get {
            if (_nssVdSynonymMember == null) { _nssVdSynonymMember = new VdSynonymMemberNss(null); }
            return _nssVdSynonymMember;
        }}
        public VdSynonymMemberNss SetupSelect_VdSynonymMember() {
            doSetupSelect(delegate { return Query().QueryVdSynonymMember(); });
            if (_nssVdSynonymMember == null || !_nssVdSynonymMember.HasConditionQuery)
            { _nssVdSynonymMember = new VdSynonymMemberNss(Query().QueryVdSynonymMember()); }
            return _nssVdSynonymMember;
        }
        protected VendorSynonymMemberNss _nssVendorSynonymMember;
        public VendorSynonymMemberNss NssVendorSynonymMember { get {
            if (_nssVendorSynonymMember == null) { _nssVendorSynonymMember = new VendorSynonymMemberNss(null); }
            return _nssVendorSynonymMember;
        }}
        public VendorSynonymMemberNss SetupSelect_VendorSynonymMember() {
            doSetupSelect(delegate { return Query().QueryVendorSynonymMember(); });
            if (_nssVendorSynonymMember == null || !_nssVendorSynonymMember.HasConditionQuery)
            { _nssVendorSynonymMember = new VendorSynonymMemberNss(Query().QueryVendorSynonymMember()); }
            return _nssVendorSynonymMember;
        }

        // [DBFlute-0.7.4]
        // ===============================================================================
        //                                                                         Specify
        //                                                                         =======
        protected VdSynonymMemberWithdrawalCBSpecification _specification;
        public VdSynonymMemberWithdrawalCBSpecification Specify() {
            if (_specification == null) { _specification = new VdSynonymMemberWithdrawalCBSpecification(this, new MySpQyCall(this), _forDerivedReferrer, _forScalarSelect, _forScalarCondition, _forColumnQuery); }
            return _specification;
        }
        protected bool HasSpecifiedColumn { get {
            return _specification != null && _specification.IsAlreadySpecifiedRequiredColumn;
        }}
        protected class MySpQyCall : HpSpQyCall<VdSynonymMemberWithdrawalCQ> {
			protected BsVdSynonymMemberWithdrawalCB _myCB;
			public MySpQyCall(BsVdSynonymMemberWithdrawalCB myCB) { _myCB = myCB; }
    		public bool has() { return true; } public VdSynonymMemberWithdrawalCQ qy() { return _myCB.Query(); }
    	}

        // [DBFlute-0.8.9.18]
        // ===============================================================================
        //                                                                     ColumnQuery
        //                                                                     ===========
        public HpColQyOperand<VdSynonymMemberWithdrawalCB> ColumnQuery(SpecifyQuery<VdSynonymMemberWithdrawalCB> leftSpecifyQuery) {
            return new HpColQyOperand<VdSynonymMemberWithdrawalCB>(delegate(SpecifyQuery<VdSynonymMemberWithdrawalCB> rightSp, String operand) {
                xcolqy(xcreateColumnQueryCB(), xcreateColumnQueryCB(), leftSpecifyQuery, rightSp, operand);
            });
        }

        protected VdSynonymMemberWithdrawalCB xcreateColumnQueryCB() {
            VdSynonymMemberWithdrawalCB cb = new VdSynonymMemberWithdrawalCB();
            cb.xsetupForColumnQuery((VdSynonymMemberWithdrawalCB)this);
            return cb;
        }

        // [DBFlute-0.8.9.9]
        // ===============================================================================
        //                                                                    OrScopeQuery
        //                                                                    ============
        public void OrScopeQuery(OrQuery<VdSynonymMemberWithdrawalCB> orQuery) {
            xorQ((VdSynonymMemberWithdrawalCB)this, orQuery);
        }

        // ===============================================================================
        //                                                                    Purpose Type
        //                                                                    ============
        public void xsetupForColumnQuery(VdSynonymMemberWithdrawalCB mainCB) {
            xinheritSubQueryInfo(mainCB.LocalCQ);
            //xchangePurposeSqlClause(HpCBPurpose.COLUMN_QUERY);
            _forColumnQuery = true; // old style

            // inherits a parent query to synchronize real name
            // (and also for suppressing query check) 
            Specify().xsetSyncQyCall(new VdSynonymMemberWithdrawalCBColQySpQyCall(mainCB));
        }
    }

    public class VdSynonymMemberWithdrawalCBColQySpQyCall : HpSpQyCall<VdSynonymMemberWithdrawalCQ> {
        protected VdSynonymMemberWithdrawalCB _mainCB;
        public VdSynonymMemberWithdrawalCBColQySpQyCall(VdSynonymMemberWithdrawalCB mainCB) {
            _mainCB = mainCB;
        }
        public bool has() { return true; } 
        public VdSynonymMemberWithdrawalCQ qy() { return _mainCB.Query(); } 
    }

    public class VdSynonymMemberWithdrawalCBSpecification : AbstractSpecification<VdSynonymMemberWithdrawalCQ> {
        protected MemberVendorSynonymCBSpecification _memberVendorSynonym;
        protected WithdrawalReasonCBSpecification _withdrawalReason;
        protected VdSynonymMemberCBSpecification _vdSynonymMember;
        protected VendorSynonymMemberCBSpecification _vendorSynonymMember;
        public VdSynonymMemberWithdrawalCBSpecification(ConditionBean baseCB, HpSpQyCall<VdSynonymMemberWithdrawalCQ> qyCall
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
        protected override String getTableDbName() { return "VD_SYNONYM_MEMBER_WITHDRAWAL"; }
        public MemberVendorSynonymCBSpecification SpecifyMemberVendorSynonym() {
            assertForeign("memberVendorSynonym");
            if (_memberVendorSynonym == null) {
                _memberVendorSynonym = new MemberVendorSynonymCBSpecification(_baseCB, new MemberVendorSynonymSpQyCall(_qyCall), _forDerivedReferrer, _forScalarSelect, _forScalarCondition, _forColumnQuery);
                if (xhasSyncQyCall()) // inherits it
                { _memberVendorSynonym.xsetSyncQyCall(new MemberVendorSynonymSpQyCall(xsyncQyCall())); }
            }
            return _memberVendorSynonym;
        }
		public class MemberVendorSynonymSpQyCall : HpSpQyCall<MemberVendorSynonymCQ> {
		    protected HpSpQyCall<VdSynonymMemberWithdrawalCQ> _qyCall;
		    public MemberVendorSynonymSpQyCall(HpSpQyCall<VdSynonymMemberWithdrawalCQ> myQyCall) { _qyCall = myQyCall; }
		    public bool has() { return _qyCall.has() && _qyCall.qy().hasConditionQueryMemberVendorSynonym(); }
			public MemberVendorSynonymCQ qy() { return _qyCall.qy().QueryMemberVendorSynonym(); }
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
		    protected HpSpQyCall<VdSynonymMemberWithdrawalCQ> _qyCall;
		    public WithdrawalReasonSpQyCall(HpSpQyCall<VdSynonymMemberWithdrawalCQ> myQyCall) { _qyCall = myQyCall; }
		    public bool has() { return _qyCall.has() && _qyCall.qy().hasConditionQueryWithdrawalReason(); }
			public WithdrawalReasonCQ qy() { return _qyCall.qy().QueryWithdrawalReason(); }
		}
        public VdSynonymMemberCBSpecification SpecifyVdSynonymMember() {
            assertForeign("vdSynonymMember");
            if (_vdSynonymMember == null) {
                _vdSynonymMember = new VdSynonymMemberCBSpecification(_baseCB, new VdSynonymMemberSpQyCall(_qyCall), _forDerivedReferrer, _forScalarSelect, _forScalarCondition, _forColumnQuery);
                if (xhasSyncQyCall()) // inherits it
                { _vdSynonymMember.xsetSyncQyCall(new VdSynonymMemberSpQyCall(xsyncQyCall())); }
            }
            return _vdSynonymMember;
        }
		public class VdSynonymMemberSpQyCall : HpSpQyCall<VdSynonymMemberCQ> {
		    protected HpSpQyCall<VdSynonymMemberWithdrawalCQ> _qyCall;
		    public VdSynonymMemberSpQyCall(HpSpQyCall<VdSynonymMemberWithdrawalCQ> myQyCall) { _qyCall = myQyCall; }
		    public bool has() { return _qyCall.has() && _qyCall.qy().hasConditionQueryVdSynonymMember(); }
			public VdSynonymMemberCQ qy() { return _qyCall.qy().QueryVdSynonymMember(); }
		}
        public VendorSynonymMemberCBSpecification SpecifyVendorSynonymMember() {
            assertForeign("vendorSynonymMember");
            if (_vendorSynonymMember == null) {
                _vendorSynonymMember = new VendorSynonymMemberCBSpecification(_baseCB, new VendorSynonymMemberSpQyCall(_qyCall), _forDerivedReferrer, _forScalarSelect, _forScalarCondition, _forColumnQuery);
                if (xhasSyncQyCall()) // inherits it
                { _vendorSynonymMember.xsetSyncQyCall(new VendorSynonymMemberSpQyCall(xsyncQyCall())); }
            }
            return _vendorSynonymMember;
        }
		public class VendorSynonymMemberSpQyCall : HpSpQyCall<VendorSynonymMemberCQ> {
		    protected HpSpQyCall<VdSynonymMemberWithdrawalCQ> _qyCall;
		    public VendorSynonymMemberSpQyCall(HpSpQyCall<VdSynonymMemberWithdrawalCQ> myQyCall) { _qyCall = myQyCall; }
		    public bool has() { return _qyCall.has() && _qyCall.qy().hasConditionQueryVendorSynonymMember(); }
			public VendorSynonymMemberCQ qy() { return _qyCall.qy().QueryVendorSynonymMember(); }
		}
    }
}
