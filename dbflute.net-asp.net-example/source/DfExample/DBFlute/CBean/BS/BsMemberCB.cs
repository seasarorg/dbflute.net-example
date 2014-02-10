
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
    public class BsMemberCB : AbstractConditionBean {

        // ===============================================================================
        //                                                                       Attribute
        //                                                                       =========
        protected MemberCQ _conditionQuery;

        // ===============================================================================
        //                                                                      Table Name
        //                                                                      ==========
        public override String TableDbName { get { return "MEMBER"; } }

        // ===============================================================================
        //                                                             PrimaryKey Handling
        //                                                             ===================
        public void AcceptPrimaryKey(long? memberId) {
            assertObjectNotNull("memberId", memberId);
            BsMemberCB cb = this;
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
        public MemberCQ Query() {
            return this.ConditionQuery;
        }

        public MemberCQ ConditionQuery {
            get {
                if (_conditionQuery == null) {
                    _conditionQuery = CreateLocalCQ();
                }
                return _conditionQuery;
            }
        }

        protected virtual MemberCQ CreateLocalCQ() {
            return xcreateCQ(null, this.SqlClause, this.SqlClause.getBasePointAliasName(), 0);
        }

        protected virtual MemberCQ xcreateCQ(ConditionQuery childQuery, SqlClause sqlClause, String aliasName, int nestLevel) {
            return new MemberCQ(childQuery, sqlClause, aliasName, nestLevel);
        }

        public override ConditionQuery LocalCQ {
            get { return this.ConditionQuery; }
        }

        // ===============================================================================
        //                                                                           Union
        //                                                                           =====
	    public virtual void Union(UnionQuery<MemberCB> unionQuery) {
            MemberCB cb = new MemberCB();
            cb.xsetupForUnion(this); xsyncUQ(cb); unionQuery.Invoke(cb);
		    MemberCQ cq = cb.Query(); Query().xsetUnionQuery(cq);
        }

	    public virtual void UnionAll(UnionQuery<MemberCB> unionQuery) {
            MemberCB cb = new MemberCB();
            cb.xsetupForUnion(this); xsyncUQ(cb); unionQuery.Invoke(cb);
		    MemberCQ cq = cb.Query(); Query().xsetUnionAllQuery(cq);
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
        protected MemberLoginNss _nssMemberLoginAsLatest;
        public MemberLoginNss NssMemberLoginAsLatest { get {
            if (_nssMemberLoginAsLatest == null) { _nssMemberLoginAsLatest = new MemberLoginNss(null); }
            return _nssMemberLoginAsLatest;
        }}
        public MemberLoginNss SetupSelect_MemberLoginAsLatest() {
            doSetupSelect(delegate { return Query().QueryMemberLoginAsLatest(); });
            if (_nssMemberLoginAsLatest == null || !_nssMemberLoginAsLatest.HasConditionQuery)
            { _nssMemberLoginAsLatest = new MemberLoginNss(Query().QueryMemberLoginAsLatest()); }
            return _nssMemberLoginAsLatest;
        }

        protected MemberSecurityNss _nssMemberSecurityAsOne;
        public MemberSecurityNss NssMemberSecurityAsOne { get {
            if (_nssMemberSecurityAsOne == null) { _nssMemberSecurityAsOne = new MemberSecurityNss(null); }
            return _nssMemberSecurityAsOne;
        }}
        public MemberSecurityNss SetupSelect_MemberSecurityAsOne() {
            doSetupSelect(delegate { return Query().QueryMemberSecurityAsOne(); });
            if (_nssMemberSecurityAsOne == null || !_nssMemberSecurityAsOne.HasConditionQuery)
            { _nssMemberSecurityAsOne = new MemberSecurityNss(Query().QueryMemberSecurityAsOne()); }
            return _nssMemberSecurityAsOne;
        }

        protected MemberWithdrawalNss _nssMemberWithdrawalAsOne;
        public MemberWithdrawalNss NssMemberWithdrawalAsOne { get {
            if (_nssMemberWithdrawalAsOne == null) { _nssMemberWithdrawalAsOne = new MemberWithdrawalNss(null); }
            return _nssMemberWithdrawalAsOne;
        }}
        public MemberWithdrawalNss SetupSelect_MemberWithdrawalAsOne() {
            doSetupSelect(delegate { return Query().QueryMemberWithdrawalAsOne(); });
            if (_nssMemberWithdrawalAsOne == null || !_nssMemberWithdrawalAsOne.HasConditionQuery)
            { _nssMemberWithdrawalAsOne = new MemberWithdrawalNss(Query().QueryMemberWithdrawalAsOne()); }
            return _nssMemberWithdrawalAsOne;
        }

        // [DBFlute-0.7.4]
        // ===============================================================================
        //                                                                         Specify
        //                                                                         =======
        protected MemberCBSpecification _specification;
        public MemberCBSpecification Specify() {
            if (_specification == null) { _specification = new MemberCBSpecification(this, new MySpQyCall(this), _forDerivedReferrer, _forScalarSelect, _forScalarCondition, _forColumnQuery); }
            return _specification;
        }
        protected bool HasSpecifiedColumn { get {
            return _specification != null && _specification.IsAlreadySpecifiedRequiredColumn;
        }}
        protected class MySpQyCall : HpSpQyCall<MemberCQ> {
			protected BsMemberCB _myCB;
			public MySpQyCall(BsMemberCB myCB) { _myCB = myCB; }
    		public bool has() { return true; } public MemberCQ qy() { return _myCB.Query(); }
    	}

        // [DBFlute-0.8.9.18]
        // ===============================================================================
        //                                                                     ColumnQuery
        //                                                                     ===========
        public HpColQyOperand<MemberCB> ColumnQuery(SpecifyQuery<MemberCB> leftSpecifyQuery) {
            return new HpColQyOperand<MemberCB>(delegate(SpecifyQuery<MemberCB> rightSp, String operand) {
                xcolqy(xcreateColumnQueryCB(), xcreateColumnQueryCB(), leftSpecifyQuery, rightSp, operand);
            });
        }

        protected MemberCB xcreateColumnQueryCB() {
            MemberCB cb = new MemberCB();
            cb.xsetupForColumnQuery((MemberCB)this);
            return cb;
        }

        // [DBFlute-0.8.9.9]
        // ===============================================================================
        //                                                                    OrScopeQuery
        //                                                                    ============
        public void OrScopeQuery(OrQuery<MemberCB> orQuery) {
            xorQ((MemberCB)this, orQuery);
        }

        // ===============================================================================
        //                                                                    Purpose Type
        //                                                                    ============
        public void xsetupForColumnQuery(MemberCB mainCB) {
            xinheritSubQueryInfo(mainCB.LocalCQ);
            //xchangePurposeSqlClause(HpCBPurpose.COLUMN_QUERY);
            _forColumnQuery = true; // old style

            // inherits a parent query to synchronize real name
            // (and also for suppressing query check) 
            Specify().xsetSyncQyCall(new MemberCBColQySpQyCall(mainCB));
        }
    }

    public class MemberCBColQySpQyCall : HpSpQyCall<MemberCQ> {
        protected MemberCB _mainCB;
        public MemberCBColQySpQyCall(MemberCB mainCB) {
            _mainCB = mainCB;
        }
        public bool has() { return true; } 
        public MemberCQ qy() { return _mainCB.Query(); } 
    }

    public class MemberCBSpecification : AbstractSpecification<MemberCQ> {
        protected MemberStatusCBSpecification _memberStatus;
        protected MemberLoginCBSpecification _memberLoginAsLatest;
        protected MemberSecurityCBSpecification _memberSecurityAsOne;
        protected MemberWithdrawalCBSpecification _memberWithdrawalAsOne;
        public MemberCBSpecification(ConditionBean baseCB, HpSpQyCall<MemberCQ> qyCall
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
        protected override String getTableDbName() { return "MEMBER"; }
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
		    protected HpSpQyCall<MemberCQ> _qyCall;
		    public MemberStatusSpQyCall(HpSpQyCall<MemberCQ> myQyCall) { _qyCall = myQyCall; }
		    public bool has() { return _qyCall.has() && _qyCall.qy().hasConditionQueryMemberStatus(); }
			public MemberStatusCQ qy() { return _qyCall.qy().QueryMemberStatus(); }
		}
        public MemberLoginCBSpecification SpecifyMemberLoginAsLatest() {
            assertForeign("memberLoginAsLatest");
            if (_memberLoginAsLatest == null) {
                _memberLoginAsLatest = new MemberLoginCBSpecification(_baseCB, new MemberLoginAsLatestSpQyCall(_qyCall), _forDerivedReferrer, _forScalarSelect, _forScalarCondition, _forColumnQuery);
                if (xhasSyncQyCall()) // inherits it
                { _memberLoginAsLatest.xsetSyncQyCall(new MemberLoginAsLatestSpQyCall(xsyncQyCall())); }
            }
            return _memberLoginAsLatest;
        }
		public class MemberLoginAsLatestSpQyCall : HpSpQyCall<MemberLoginCQ> {
		    protected HpSpQyCall<MemberCQ> _qyCall;
		    public MemberLoginAsLatestSpQyCall(HpSpQyCall<MemberCQ> myQyCall) { _qyCall = myQyCall; }
		    public bool has() { return _qyCall.has() && _qyCall.qy().hasConditionQueryMemberLoginAsLatest(); }
			public MemberLoginCQ qy() { return _qyCall.qy().QueryMemberLoginAsLatest(); }
		}
        public MemberSecurityCBSpecification SpecifyMemberSecurityAsOne() {
            assertForeign("memberSecurityAsOne");
            if (_memberSecurityAsOne == null) {
                _memberSecurityAsOne = new MemberSecurityCBSpecification(_baseCB, new MemberSecurityAsOneSpQyCall(_qyCall), _forDerivedReferrer, _forScalarSelect, _forScalarCondition, _forColumnQuery);
                if (xhasSyncQyCall()) // inherits it
                { _memberSecurityAsOne.xsetSyncQyCall(new MemberSecurityAsOneSpQyCall(xsyncQyCall())); }
            }
            return _memberSecurityAsOne;
        }
		public class MemberSecurityAsOneSpQyCall : HpSpQyCall<MemberSecurityCQ> {
		    protected HpSpQyCall<MemberCQ> _qyCall;
		    public MemberSecurityAsOneSpQyCall(HpSpQyCall<MemberCQ> myQyCall) { _qyCall = myQyCall; }
		    public bool has() { return _qyCall.has() && _qyCall.qy().hasConditionQueryMemberSecurityAsOne(); }
			public MemberSecurityCQ qy() { return _qyCall.qy().QueryMemberSecurityAsOne(); }
		}
        public MemberWithdrawalCBSpecification SpecifyMemberWithdrawalAsOne() {
            assertForeign("memberWithdrawalAsOne");
            if (_memberWithdrawalAsOne == null) {
                _memberWithdrawalAsOne = new MemberWithdrawalCBSpecification(_baseCB, new MemberWithdrawalAsOneSpQyCall(_qyCall), _forDerivedReferrer, _forScalarSelect, _forScalarCondition, _forColumnQuery);
                if (xhasSyncQyCall()) // inherits it
                { _memberWithdrawalAsOne.xsetSyncQyCall(new MemberWithdrawalAsOneSpQyCall(xsyncQyCall())); }
            }
            return _memberWithdrawalAsOne;
        }
		public class MemberWithdrawalAsOneSpQyCall : HpSpQyCall<MemberWithdrawalCQ> {
		    protected HpSpQyCall<MemberCQ> _qyCall;
		    public MemberWithdrawalAsOneSpQyCall(HpSpQyCall<MemberCQ> myQyCall) { _qyCall = myQyCall; }
		    public bool has() { return _qyCall.has() && _qyCall.qy().hasConditionQueryMemberWithdrawalAsOne(); }
			public MemberWithdrawalCQ qy() { return _qyCall.qy().QueryMemberWithdrawalAsOne(); }
		}
        public RAFunction<MemberAddressCB, MemberCQ> DerivedMemberAddressList() {
            if (xhasSyncQyCall()) { xsyncQyCall().qy(); } // for sync (for example, this in ColumnQuery)
            return new RAFunction<MemberAddressCB, MemberCQ>(_baseCB, _qyCall.qy(), delegate(String function, SubQuery<MemberAddressCB> subQuery, MemberCQ cq, String aliasName)
                { cq.xsderiveMemberAddressList(function, subQuery, aliasName); });
        }
        public RAFunction<MemberLoginCB, MemberCQ> DerivedMemberLoginList() {
            if (xhasSyncQyCall()) { xsyncQyCall().qy(); } // for sync (for example, this in ColumnQuery)
            return new RAFunction<MemberLoginCB, MemberCQ>(_baseCB, _qyCall.qy(), delegate(String function, SubQuery<MemberLoginCB> subQuery, MemberCQ cq, String aliasName)
                { cq.xsderiveMemberLoginList(function, subQuery, aliasName); });
        }
        public RAFunction<PurchaseCB, MemberCQ> DerivedPurchaseList() {
            if (xhasSyncQyCall()) { xsyncQyCall().qy(); } // for sync (for example, this in ColumnQuery)
            return new RAFunction<PurchaseCB, MemberCQ>(_baseCB, _qyCall.qy(), delegate(String function, SubQuery<PurchaseCB> subQuery, MemberCQ cq, String aliasName)
                { cq.xsderivePurchaseList(function, subQuery, aliasName); });
        }
    }
}
