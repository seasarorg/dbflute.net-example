
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
    public class MbBsMemberCB : MbAbstractConditionBean {

        // ===============================================================================
        //                                                                       Attribute
        //                                                                       =========
        protected MbMemberCQ _conditionQuery;

        // ===============================================================================
        //                                                                      Table Name
        //                                                                      ==========
        public override String TableDbName { get { return "member"; } }

        // ===============================================================================
        //                                                             PrimaryKey Handling
        //                                                             ===================
        public void AcceptPrimaryKey(int? memberId) {
            assertObjectNotNull("memberId", memberId);
            MbBsMemberCB cb = this;
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
        public MbMemberCQ Query() {
            return this.ConditionQuery;
        }

        public MbMemberCQ ConditionQuery {
            get {
                if (_conditionQuery == null) {
                    _conditionQuery = CreateLocalCQ();
                }
                return _conditionQuery;
            }
        }

        protected virtual MbMemberCQ CreateLocalCQ() {
            return xcreateCQ(null, this.SqlClause, this.SqlClause.getBasePointAliasName(), 0);
        }

        protected virtual MbMemberCQ xcreateCQ(MbConditionQuery childQuery, MbSqlClause sqlClause, String aliasName, int nestLevel) {
            return new MbMemberCQ(childQuery, sqlClause, aliasName, nestLevel);
        }

        public override MbConditionQuery LocalCQ {
            get { return this.ConditionQuery; }
        }

        // ===============================================================================
        //                                                                           Union
        //                                                                           =====
	    public virtual void Union(MbUnionQuery<MbMemberCB> unionQuery) {
            MbMemberCB cb = new MbMemberCB();
            cb.xsetupForUnion(this); xsyncUQ(cb); unionQuery.Invoke(cb);
		    MbMemberCQ cq = cb.Query(); Query().xsetUnionQuery(cq);
        }

	    public virtual void UnionAll(MbUnionQuery<MbMemberCB> unionQuery) {
            MbMemberCB cb = new MbMemberCB();
            cb.xsetupForUnion(this); xsyncUQ(cb); unionQuery.Invoke(cb);
		    MbMemberCQ cq = cb.Query(); Query().xsetUnionAllQuery(cq);
	    }

        public override bool HasUnionQueryOrUnionAllQuery() {
            return Query().hasUnionQueryOrUnionAllQuery();
        }

        // ===============================================================================
        //                                                                    Setup Select
        //                                                                    ============
        protected MbMemberStatusNss _nssMemberStatus;
        public MbMemberStatusNss NssMemberStatus { get {
            if (_nssMemberStatus == null) { _nssMemberStatus = new MbMemberStatusNss(null); }
            return _nssMemberStatus;
        }}
        public MbMemberStatusNss SetupSelect_MemberStatus() {
            if (HasSpecifiedColumn) { // if reverse call
                Specify().ColumnMemberStatusCode();
            }
            doSetupSelect(delegate { return Query().QueryMemberStatus(); });
            if (_nssMemberStatus == null || !_nssMemberStatus.HasConditionQuery)
            { _nssMemberStatus = new MbMemberStatusNss(Query().QueryMemberStatus()); }
            return _nssMemberStatus;
        }
        protected MbMemberLoginNss _nssMemberLoginAsLatest;
        public MbMemberLoginNss NssMemberLoginAsLatest { get {
            if (_nssMemberLoginAsLatest == null) { _nssMemberLoginAsLatest = new MbMemberLoginNss(null); }
            return _nssMemberLoginAsLatest;
        }}
        public MbMemberLoginNss SetupSelect_MemberLoginAsLatest() {
            doSetupSelect(delegate { return Query().QueryMemberLoginAsLatest(); });
            if (_nssMemberLoginAsLatest == null || !_nssMemberLoginAsLatest.HasConditionQuery)
            { _nssMemberLoginAsLatest = new MbMemberLoginNss(Query().QueryMemberLoginAsLatest()); }
            return _nssMemberLoginAsLatest;
        }
        protected MbMemberAddressNss _nssMemberAddressAsValid;
        public MbMemberAddressNss NssMemberAddressAsValid { get {
            if (_nssMemberAddressAsValid == null) { _nssMemberAddressAsValid = new MbMemberAddressNss(null); }
            return _nssMemberAddressAsValid;
        }}
        public MbMemberAddressNss SetupSelect_MemberAddressAsValid(DateTime targetDate) {
            doSetupSelect(delegate { return Query().QueryMemberAddressAsValid(targetDate); });
            if (_nssMemberAddressAsValid == null || !_nssMemberAddressAsValid.HasConditionQuery)
            { _nssMemberAddressAsValid = new MbMemberAddressNss(Query().QueryMemberAddressAsValid(targetDate)); }
            return _nssMemberAddressAsValid;
        }

        protected MbMemberSecurityNss _nssMemberSecurityAsOne;
        public MbMemberSecurityNss NssMemberSecurityAsOne { get {
            if (_nssMemberSecurityAsOne == null) { _nssMemberSecurityAsOne = new MbMemberSecurityNss(null); }
            return _nssMemberSecurityAsOne;
        }}
        public MbMemberSecurityNss SetupSelect_MemberSecurityAsOne() {
            doSetupSelect(delegate { return Query().QueryMemberSecurityAsOne(); });
            if (_nssMemberSecurityAsOne == null || !_nssMemberSecurityAsOne.HasConditionQuery)
            { _nssMemberSecurityAsOne = new MbMemberSecurityNss(Query().QueryMemberSecurityAsOne()); }
            return _nssMemberSecurityAsOne;
        }

        protected MbMemberWithdrawalNss _nssMemberWithdrawalAsOne;
        public MbMemberWithdrawalNss NssMemberWithdrawalAsOne { get {
            if (_nssMemberWithdrawalAsOne == null) { _nssMemberWithdrawalAsOne = new MbMemberWithdrawalNss(null); }
            return _nssMemberWithdrawalAsOne;
        }}
        public MbMemberWithdrawalNss SetupSelect_MemberWithdrawalAsOne() {
            doSetupSelect(delegate { return Query().QueryMemberWithdrawalAsOne(); });
            if (_nssMemberWithdrawalAsOne == null || !_nssMemberWithdrawalAsOne.HasConditionQuery)
            { _nssMemberWithdrawalAsOne = new MbMemberWithdrawalNss(Query().QueryMemberWithdrawalAsOne()); }
            return _nssMemberWithdrawalAsOne;
        }

        // [DBFlute-0.7.4]
        // ===============================================================================
        //                                                                         Specify
        //                                                                         =======
        protected MbMemberCBSpecification _specification;
        public MbMemberCBSpecification Specify() {
            if (_specification == null) { _specification = new MbMemberCBSpecification(this, new MySpQyCall(this), _forDerivedReferrer, _forScalarSelect, _forScalarCondition, _forColumnQuery); }
            return _specification;
        }
        protected bool HasSpecifiedColumn { get {
            return _specification != null && _specification.IsAlreadySpecifiedRequiredColumn;
        }}
        protected class MySpQyCall : HpSpQyCall<MbMemberCQ> {
			protected MbBsMemberCB _myCB;
			public MySpQyCall(MbBsMemberCB myCB) { _myCB = myCB; }
    		public bool has() { return true; } public MbMemberCQ qy() { return _myCB.Query(); }
    	}

        // [DBFlute-0.8.9.18]
        // ===============================================================================
        //                                                                     ColumnQuery
        //                                                                     ===========
        public HpColQyOperand<MbMemberCB> ColumnQuery(MbSpecifyQuery<MbMemberCB> leftSpecifyQuery) {
            return new HpColQyOperand<MbMemberCB>(delegate(MbSpecifyQuery<MbMemberCB> rightSp, String operand) {
                xcolqy(xcreateColumnQueryCB(), xcreateColumnQueryCB(), leftSpecifyQuery, rightSp, operand);
            });
        }

        protected MbMemberCB xcreateColumnQueryCB() {
            MbMemberCB cb = new MbMemberCB();
            cb.xsetupForColumnQuery((MbMemberCB)this);
            return cb;
        }

        // [DBFlute-0.8.9.9]
        // ===============================================================================
        //                                                                    OrScopeQuery
        //                                                                    ============
        public void OrScopeQuery(MbOrQuery<MbMemberCB> orQuery) {
            xorQ((MbMemberCB)this, orQuery);
        }

        // ===============================================================================
        //                                                                    Purpose Type
        //                                                                    ============
        public void xsetupForColumnQuery(MbMemberCB mainCB) {
            xinheritSubQueryInfo(mainCB.LocalCQ);
            //xchangePurposeSqlClause(HpCBPurpose.COLUMN_QUERY);
            _forColumnQuery = true; // old style

            // inherits a parent query to synchronize real name
            // (and also for suppressing query check) 
            Specify().xsetSyncQyCall(new MbMemberCBColQySpQyCall(mainCB));
        }
    }

    public class MbMemberCBColQySpQyCall : HpSpQyCall<MbMemberCQ> {
        protected MbMemberCB _mainCB;
        public MbMemberCBColQySpQyCall(MbMemberCB mainCB) {
            _mainCB = mainCB;
        }
        public bool has() { return true; } 
        public MbMemberCQ qy() { return _mainCB.Query(); } 
    }

    public class MbMemberCBSpecification : AbstractSpecification<MbMemberCQ> {
        protected MbMemberStatusCBSpecification _memberStatus;
        protected MbMemberLoginCBSpecification _memberLoginAsLatest;
        protected MbMemberAddressCBSpecification _memberAddressAsValid;
        protected MbMemberSecurityCBSpecification _memberSecurityAsOne;
        protected MbMemberWithdrawalCBSpecification _memberWithdrawalAsOne;
        public MbMemberCBSpecification(MbConditionBean baseCB, HpSpQyCall<MbMemberCQ> qyCall
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
                    || qyCall().qy().xgetReferrerQuery() is MbMemberStatusCQ) {
                ColumnMemberStatusCode(); // FK or one-to-one referrer
            }
        }
        protected override String getTableDbName() { return "member"; }
        public MbMemberStatusCBSpecification SpecifyMemberStatus() {
            assertForeign("memberStatus");
            if (_memberStatus == null) {
                _memberStatus = new MbMemberStatusCBSpecification(_baseCB, new MemberStatusSpQyCall(_qyCall), _forDerivedReferrer, _forScalarSelect, _forScalarCondition, _forColumnQuery);
                if (xhasSyncQyCall()) // inherits it
                { _memberStatus.xsetSyncQyCall(new MemberStatusSpQyCall(xsyncQyCall())); }
            }
            return _memberStatus;
        }
		public class MemberStatusSpQyCall : HpSpQyCall<MbMemberStatusCQ> {
		    protected HpSpQyCall<MbMemberCQ> _qyCall;
		    public MemberStatusSpQyCall(HpSpQyCall<MbMemberCQ> myQyCall) { _qyCall = myQyCall; }
		    public bool has() { return _qyCall.has() && _qyCall.qy().hasConditionQueryMemberStatus(); }
			public MbMemberStatusCQ qy() { return _qyCall.qy().QueryMemberStatus(); }
		}
        public MbMemberLoginCBSpecification SpecifyMemberLoginAsLatest() {
            assertForeign("memberLoginAsLatest");
            if (_memberLoginAsLatest == null) {
                _memberLoginAsLatest = new MbMemberLoginCBSpecification(_baseCB, new MemberLoginAsLatestSpQyCall(_qyCall), _forDerivedReferrer, _forScalarSelect, _forScalarCondition, _forColumnQuery);
                if (xhasSyncQyCall()) // inherits it
                { _memberLoginAsLatest.xsetSyncQyCall(new MemberLoginAsLatestSpQyCall(xsyncQyCall())); }
            }
            return _memberLoginAsLatest;
        }
		public class MemberLoginAsLatestSpQyCall : HpSpQyCall<MbMemberLoginCQ> {
		    protected HpSpQyCall<MbMemberCQ> _qyCall;
		    public MemberLoginAsLatestSpQyCall(HpSpQyCall<MbMemberCQ> myQyCall) { _qyCall = myQyCall; }
		    public bool has() { return _qyCall.has() && _qyCall.qy().hasConditionQueryMemberLoginAsLatest(); }
			public MbMemberLoginCQ qy() { return _qyCall.qy().QueryMemberLoginAsLatest(); }
		}
        public MbMemberAddressCBSpecification SpecifyMemberAddressAsValid() {
            assertForeign("memberAddressAsValid");
            if (_memberAddressAsValid == null) {
                _memberAddressAsValid = new MbMemberAddressCBSpecification(_baseCB, new MemberAddressAsValidSpQyCall(_qyCall), _forDerivedReferrer, _forScalarSelect, _forScalarCondition, _forColumnQuery);
                if (xhasSyncQyCall()) // inherits it
                { _memberAddressAsValid.xsetSyncQyCall(new MemberAddressAsValidSpQyCall(xsyncQyCall())); }
            }
            return _memberAddressAsValid;
        }
		public class MemberAddressAsValidSpQyCall : HpSpQyCall<MbMemberAddressCQ> {
		    protected HpSpQyCall<MbMemberCQ> _qyCall;
		    public MemberAddressAsValidSpQyCall(HpSpQyCall<MbMemberCQ> myQyCall) { _qyCall = myQyCall; }
		    public bool has() { return _qyCall.has() && _qyCall.qy().hasConditionQueryMemberAddressAsValid(); }
			public MbMemberAddressCQ qy() { return _qyCall.qy().ConditionQueryMemberAddressAsValid; }
		}
        public MbMemberSecurityCBSpecification SpecifyMemberSecurityAsOne() {
            assertForeign("memberSecurityAsOne");
            if (_memberSecurityAsOne == null) {
                _memberSecurityAsOne = new MbMemberSecurityCBSpecification(_baseCB, new MemberSecurityAsOneSpQyCall(_qyCall), _forDerivedReferrer, _forScalarSelect, _forScalarCondition, _forColumnQuery);
                if (xhasSyncQyCall()) // inherits it
                { _memberSecurityAsOne.xsetSyncQyCall(new MemberSecurityAsOneSpQyCall(xsyncQyCall())); }
            }
            return _memberSecurityAsOne;
        }
		public class MemberSecurityAsOneSpQyCall : HpSpQyCall<MbMemberSecurityCQ> {
		    protected HpSpQyCall<MbMemberCQ> _qyCall;
		    public MemberSecurityAsOneSpQyCall(HpSpQyCall<MbMemberCQ> myQyCall) { _qyCall = myQyCall; }
		    public bool has() { return _qyCall.has() && _qyCall.qy().hasConditionQueryMemberSecurityAsOne(); }
			public MbMemberSecurityCQ qy() { return _qyCall.qy().QueryMemberSecurityAsOne(); }
		}
        public MbMemberWithdrawalCBSpecification SpecifyMemberWithdrawalAsOne() {
            assertForeign("memberWithdrawalAsOne");
            if (_memberWithdrawalAsOne == null) {
                _memberWithdrawalAsOne = new MbMemberWithdrawalCBSpecification(_baseCB, new MemberWithdrawalAsOneSpQyCall(_qyCall), _forDerivedReferrer, _forScalarSelect, _forScalarCondition, _forColumnQuery);
                if (xhasSyncQyCall()) // inherits it
                { _memberWithdrawalAsOne.xsetSyncQyCall(new MemberWithdrawalAsOneSpQyCall(xsyncQyCall())); }
            }
            return _memberWithdrawalAsOne;
        }
		public class MemberWithdrawalAsOneSpQyCall : HpSpQyCall<MbMemberWithdrawalCQ> {
		    protected HpSpQyCall<MbMemberCQ> _qyCall;
		    public MemberWithdrawalAsOneSpQyCall(HpSpQyCall<MbMemberCQ> myQyCall) { _qyCall = myQyCall; }
		    public bool has() { return _qyCall.has() && _qyCall.qy().hasConditionQueryMemberWithdrawalAsOne(); }
			public MbMemberWithdrawalCQ qy() { return _qyCall.qy().QueryMemberWithdrawalAsOne(); }
		}
        public RAFunction<MbMemberAddressCB, MbMemberCQ> DerivedMemberAddressList() {
            if (xhasSyncQyCall()) { xsyncQyCall().qy(); } // for sync (for example, this in ColumnQuery)
            return new RAFunction<MbMemberAddressCB, MbMemberCQ>(_baseCB, _qyCall.qy(), delegate(String function, MbSubQuery<MbMemberAddressCB> subQuery, MbMemberCQ cq, String aliasName)
                { cq.xsderiveMemberAddressList(function, subQuery, aliasName); });
        }
        public RAFunction<MbMemberLoginCB, MbMemberCQ> DerivedMemberLoginList() {
            if (xhasSyncQyCall()) { xsyncQyCall().qy(); } // for sync (for example, this in ColumnQuery)
            return new RAFunction<MbMemberLoginCB, MbMemberCQ>(_baseCB, _qyCall.qy(), delegate(String function, MbSubQuery<MbMemberLoginCB> subQuery, MbMemberCQ cq, String aliasName)
                { cq.xsderiveMemberLoginList(function, subQuery, aliasName); });
        }
        public RAFunction<MbPurchaseCB, MbMemberCQ> DerivedPurchaseList() {
            if (xhasSyncQyCall()) { xsyncQyCall().qy(); } // for sync (for example, this in ColumnQuery)
            return new RAFunction<MbPurchaseCB, MbMemberCQ>(_baseCB, _qyCall.qy(), delegate(String function, MbSubQuery<MbPurchaseCB> subQuery, MbMemberCQ cq, String aliasName)
                { cq.xsderivePurchaseList(function, subQuery, aliasName); });
        }
    }
}
