
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
    public class BsMemberVendorSynonymCB : AbstractConditionBean {

        // ===============================================================================
        //                                                                       Attribute
        //                                                                       =========
        protected MemberVendorSynonymCQ _conditionQuery;

        // ===============================================================================
        //                                                                      Table Name
        //                                                                      ==========
        public override String TableDbName { get { return "MEMBER_VENDOR_SYNONYM"; } }

        // ===============================================================================
        //                                                             PrimaryKey Handling
        //                                                             ===================
        public void AcceptPrimaryKey(long? memberId) {
            assertObjectNotNull("memberId", memberId);
            BsMemberVendorSynonymCB cb = this;
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
        public MemberVendorSynonymCQ Query() {
            return this.ConditionQuery;
        }

        public MemberVendorSynonymCQ ConditionQuery {
            get {
                if (_conditionQuery == null) {
                    _conditionQuery = CreateLocalCQ();
                }
                return _conditionQuery;
            }
        }

        protected virtual MemberVendorSynonymCQ CreateLocalCQ() {
            return xcreateCQ(null, this.SqlClause, this.SqlClause.getBasePointAliasName(), 0);
        }

        protected virtual MemberVendorSynonymCQ xcreateCQ(ConditionQuery childQuery, SqlClause sqlClause, String aliasName, int nestLevel) {
            return new MemberVendorSynonymCQ(childQuery, sqlClause, aliasName, nestLevel);
        }

        public override ConditionQuery LocalCQ {
            get { return this.ConditionQuery; }
        }

        // ===============================================================================
        //                                                                           Union
        //                                                                           =====
	    public virtual void Union(UnionQuery<MemberVendorSynonymCB> unionQuery) {
            MemberVendorSynonymCB cb = new MemberVendorSynonymCB();
            cb.xsetupForUnion(this); xsyncUQ(cb); unionQuery.Invoke(cb);
		    MemberVendorSynonymCQ cq = cb.Query(); Query().xsetUnionQuery(cq);
        }

	    public virtual void UnionAll(UnionQuery<MemberVendorSynonymCB> unionQuery) {
            MemberVendorSynonymCB cb = new MemberVendorSynonymCB();
            cb.xsetupForUnion(this); xsyncUQ(cb); unionQuery.Invoke(cb);
		    MemberVendorSynonymCQ cq = cb.Query(); Query().xsetUnionAllQuery(cq);
	    }

        public override bool HasUnionQueryOrUnionAllQuery() {
            return Query().hasUnionQueryOrUnionAllQuery();
        }

        // ===============================================================================
        //                                                                    Setup Select
        //                                                                    ============
        protected MemberStatusNss _nssMemberStatus;
        public MemberStatusNss NssMemberStatus { get {
            if (_nssMemberStatus == null) { _nssMemberStatus = new MemberStatusNss(null); }
            return _nssMemberStatus;
        }}
        public MemberStatusNss SetupSelect_MemberStatus() {
            if (HasSpecifiedColumn) { // if reverse call
                Specify().ColumnMemberStatusCode();
            }
            doSetupSelect(delegate { return Query().QueryMemberStatus(); });
            if (_nssMemberStatus == null || !_nssMemberStatus.HasConditionQuery)
            { _nssMemberStatus = new MemberStatusNss(Query().QueryMemberStatus()); }
            return _nssMemberStatus;
        }

        protected VdSynonymMemberWithdrawalNss _nssVdSynonymMemberWithdrawalAsOne;
        public VdSynonymMemberWithdrawalNss NssVdSynonymMemberWithdrawalAsOne { get {
            if (_nssVdSynonymMemberWithdrawalAsOne == null) { _nssVdSynonymMemberWithdrawalAsOne = new VdSynonymMemberWithdrawalNss(null); }
            return _nssVdSynonymMemberWithdrawalAsOne;
        }}
        public VdSynonymMemberWithdrawalNss SetupSelect_VdSynonymMemberWithdrawalAsOne() {
            doSetupSelect(delegate { return Query().QueryVdSynonymMemberWithdrawalAsOne(); });
            if (_nssVdSynonymMemberWithdrawalAsOne == null || !_nssVdSynonymMemberWithdrawalAsOne.HasConditionQuery)
            { _nssVdSynonymMemberWithdrawalAsOne = new VdSynonymMemberWithdrawalNss(Query().QueryVdSynonymMemberWithdrawalAsOne()); }
            return _nssVdSynonymMemberWithdrawalAsOne;
        }

        // [DBFlute-0.7.4]
        // ===============================================================================
        //                                                                         Specify
        //                                                                         =======
        protected MemberVendorSynonymCBSpecification _specification;
        public MemberVendorSynonymCBSpecification Specify() {
            if (_specification == null) { _specification = new MemberVendorSynonymCBSpecification(this, new MySpQyCall(this), _forDerivedReferrer, _forScalarSelect, _forScalarCondition, _forColumnQuery); }
            return _specification;
        }
        protected bool HasSpecifiedColumn { get {
            return _specification != null && _specification.IsAlreadySpecifiedRequiredColumn;
        }}
        protected class MySpQyCall : HpSpQyCall<MemberVendorSynonymCQ> {
			protected BsMemberVendorSynonymCB _myCB;
			public MySpQyCall(BsMemberVendorSynonymCB myCB) { _myCB = myCB; }
    		public bool has() { return true; } public MemberVendorSynonymCQ qy() { return _myCB.Query(); }
    	}

        // [DBFlute-0.8.9.18]
        // ===============================================================================
        //                                                                     ColumnQuery
        //                                                                     ===========
        public HpColQyOperand<MemberVendorSynonymCB> ColumnQuery(SpecifyQuery<MemberVendorSynonymCB> leftSpecifyQuery) {
            return new HpColQyOperand<MemberVendorSynonymCB>(delegate(SpecifyQuery<MemberVendorSynonymCB> rightSp, String operand) {
                xcolqy(xcreateColumnQueryCB(), xcreateColumnQueryCB(), leftSpecifyQuery, rightSp, operand);
            });
        }

        protected MemberVendorSynonymCB xcreateColumnQueryCB() {
            MemberVendorSynonymCB cb = new MemberVendorSynonymCB();
            cb.xsetupForColumnQuery((MemberVendorSynonymCB)this);
            return cb;
        }

        // [DBFlute-0.8.9.9]
        // ===============================================================================
        //                                                                    OrScopeQuery
        //                                                                    ============
        public void OrScopeQuery(OrQuery<MemberVendorSynonymCB> orQuery) {
            xorQ((MemberVendorSynonymCB)this, orQuery);
        }

        // ===============================================================================
        //                                                                    Purpose Type
        //                                                                    ============
        public void xsetupForColumnQuery(MemberVendorSynonymCB mainCB) {
            xinheritSubQueryInfo(mainCB.LocalCQ);
            //xchangePurposeSqlClause(HpCBPurpose.COLUMN_QUERY);
            _forColumnQuery = true; // old style

            // inherits a parent query to synchronize real name
            // (and also for suppressing query check) 
            Specify().xsetSyncQyCall(new MemberVendorSynonymCBColQySpQyCall(mainCB));
        }
    }

    public class MemberVendorSynonymCBColQySpQyCall : HpSpQyCall<MemberVendorSynonymCQ> {
        protected MemberVendorSynonymCB _mainCB;
        public MemberVendorSynonymCBColQySpQyCall(MemberVendorSynonymCB mainCB) {
            _mainCB = mainCB;
        }
        public bool has() { return true; } 
        public MemberVendorSynonymCQ qy() { return _mainCB.Query(); } 
    }

    public class MemberVendorSynonymCBSpecification : AbstractSpecification<MemberVendorSynonymCQ> {
        protected MemberStatusCBSpecification _memberStatus;
        protected VdSynonymMemberWithdrawalCBSpecification _vdSynonymMemberWithdrawalAsOne;
        public MemberVendorSynonymCBSpecification(ConditionBean baseCB, HpSpQyCall<MemberVendorSynonymCQ> qyCall
                                                      , bool forDerivedReferrer, bool forScalarSelect, bool forScalarSubQuery, bool forColumnQuery)
        : base(baseCB, qyCall, forDerivedReferrer, forScalarSelect, forScalarSubQuery, forColumnQuery) { }
        public void ColumnMemberId() { doColumn("MEMBER_ID"); }
        public void ColumnMemberName() { doColumn("MEMBER_NAME"); }
        public void ColumnMemberAccount() { doColumn("MEMBER_ACCOUNT"); }
        public void ColumnMemberStatusCode() { doColumn("MEMBER_STATUS_CODE"); }
        public void ColumnFormalizedDatetime() { doColumn("FORMALIZED_DATETIME"); }
        public void ColumnBirthdate() { doColumn("BIRTHDATE"); }
        public void ColumnRegisterDatetime() { doColumn("REGISTER_DATETIME"); }
        public void ColumnRegisterUser() { doColumn("REGISTER_USER"); }
        public void ColumnRegisterProcess() { doColumn("REGISTER_PROCESS"); }
        public void ColumnUpdateDatetime() { doColumn("UPDATE_DATETIME"); }
        public void ColumnUpdateUser() { doColumn("UPDATE_USER"); }
        public void ColumnUpdateProcess() { doColumn("UPDATE_PROCESS"); }
        public void ColumnVersionNo() { doColumn("VERSION_NO"); }
        protected override void doSpecifyRequiredColumn() {
            ColumnMemberId(); // PK
            if (qyCall().qy().hasConditionQueryMemberStatus()
                    || qyCall().qy().xgetReferrerQuery() is MemberStatusCQ) {
                ColumnMemberStatusCode(); // FK or one-to-one referrer
            }
        }
        protected override String getTableDbName() { return "MEMBER_VENDOR_SYNONYM"; }
        public MemberStatusCBSpecification SpecifyMemberStatus() {
            assertForeign("memberStatus");
            if (_memberStatus == null) {
                _memberStatus = new MemberStatusCBSpecification(_baseCB, new MemberStatusSpQyCall(_qyCall), _forDerivedReferrer, _forScalarSelect, _forScalarCondition, _forColumnQuery);
                if (xhasSyncQyCall()) // inherits it
                { _memberStatus.xsetSyncQyCall(new MemberStatusSpQyCall(xsyncQyCall())); }
            }
            return _memberStatus;
        }
		public class MemberStatusSpQyCall : HpSpQyCall<MemberStatusCQ> {
		    protected HpSpQyCall<MemberVendorSynonymCQ> _qyCall;
		    public MemberStatusSpQyCall(HpSpQyCall<MemberVendorSynonymCQ> myQyCall) { _qyCall = myQyCall; }
		    public bool has() { return _qyCall.has() && _qyCall.qy().hasConditionQueryMemberStatus(); }
			public MemberStatusCQ qy() { return _qyCall.qy().QueryMemberStatus(); }
		}
        public VdSynonymMemberWithdrawalCBSpecification SpecifyVdSynonymMemberWithdrawalAsOne() {
            assertForeign("vdSynonymMemberWithdrawalAsOne");
            if (_vdSynonymMemberWithdrawalAsOne == null) {
                _vdSynonymMemberWithdrawalAsOne = new VdSynonymMemberWithdrawalCBSpecification(_baseCB, new VdSynonymMemberWithdrawalAsOneSpQyCall(_qyCall), _forDerivedReferrer, _forScalarSelect, _forScalarCondition, _forColumnQuery);
                if (xhasSyncQyCall()) // inherits it
                { _vdSynonymMemberWithdrawalAsOne.xsetSyncQyCall(new VdSynonymMemberWithdrawalAsOneSpQyCall(xsyncQyCall())); }
            }
            return _vdSynonymMemberWithdrawalAsOne;
        }
		public class VdSynonymMemberWithdrawalAsOneSpQyCall : HpSpQyCall<VdSynonymMemberWithdrawalCQ> {
		    protected HpSpQyCall<MemberVendorSynonymCQ> _qyCall;
		    public VdSynonymMemberWithdrawalAsOneSpQyCall(HpSpQyCall<MemberVendorSynonymCQ> myQyCall) { _qyCall = myQyCall; }
		    public bool has() { return _qyCall.has() && _qyCall.qy().hasConditionQueryVdSynonymMemberWithdrawalAsOne(); }
			public VdSynonymMemberWithdrawalCQ qy() { return _qyCall.qy().QueryVdSynonymMemberWithdrawalAsOne(); }
		}
        public RAFunction<VdSynonymMemberLoginCB, MemberVendorSynonymCQ> DerivedVdSynonymMemberLoginList() {
            if (xhasSyncQyCall()) { xsyncQyCall().qy(); } // for sync (for example, this in ColumnQuery)
            return new RAFunction<VdSynonymMemberLoginCB, MemberVendorSynonymCQ>(_baseCB, _qyCall.qy(), delegate(String function, SubQuery<VdSynonymMemberLoginCB> subQuery, MemberVendorSynonymCQ cq, String aliasName)
                { cq.xsderiveVdSynonymMemberLoginList(function, subQuery, aliasName); });
        }
    }
}
