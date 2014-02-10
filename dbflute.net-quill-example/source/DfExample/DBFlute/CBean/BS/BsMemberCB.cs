
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
        public override String TableDbName { get { return "member"; } }

        // ===============================================================================
        //                                                             PrimaryKey Handling
        //                                                             ===================
        public void AcceptPrimaryKey(int? memberId) {
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
        protected MemberAddressNss _nssMemberAddressAsValid;
        public MemberAddressNss NssMemberAddressAsValid { get {
            if (_nssMemberAddressAsValid == null) { _nssMemberAddressAsValid = new MemberAddressNss(null); }
            return _nssMemberAddressAsValid;
        }}
        public MemberAddressNss SetupSelect_MemberAddressAsValid(DateTime targetDate) {
            doSetupSelect(delegate { return Query().QueryMemberAddressAsValid(targetDate); });
            if (_nssMemberAddressAsValid == null || !_nssMemberAddressAsValid.HasConditionQuery)
            { _nssMemberAddressAsValid = new MemberAddressNss(Query().QueryMemberAddressAsValid(targetDate)); }
            return _nssMemberAddressAsValid;
        }
        protected MemberLoginNss _nssMemberLoginAsLocalForeignOverTest;
        public MemberLoginNss NssMemberLoginAsLocalForeignOverTest { get {
            if (_nssMemberLoginAsLocalForeignOverTest == null) { _nssMemberLoginAsLocalForeignOverTest = new MemberLoginNss(null); }
            return _nssMemberLoginAsLocalForeignOverTest;
        }}
        public MemberLoginNss SetupSelect_MemberLoginAsLocalForeignOverTest() {
            doSetupSelect(delegate { return Query().QueryMemberLoginAsLocalForeignOverTest(); });
            if (_nssMemberLoginAsLocalForeignOverTest == null || !_nssMemberLoginAsLocalForeignOverTest.HasConditionQuery)
            { _nssMemberLoginAsLocalForeignOverTest = new MemberLoginNss(Query().QueryMemberLoginAsLocalForeignOverTest()); }
            return _nssMemberLoginAsLocalForeignOverTest;
        }
        protected MemberLoginNss _nssMemberLoginAsForeignForeignOverTest;
        public MemberLoginNss NssMemberLoginAsForeignForeignOverTest { get {
            if (_nssMemberLoginAsForeignForeignOverTest == null) { _nssMemberLoginAsForeignForeignOverTest = new MemberLoginNss(null); }
            return _nssMemberLoginAsForeignForeignOverTest;
        }}
        public MemberLoginNss SetupSelect_MemberLoginAsForeignForeignOverTest() {
            doSetupSelect(delegate { return Query().QueryMemberLoginAsForeignForeignOverTest(); });
            if (_nssMemberLoginAsForeignForeignOverTest == null || !_nssMemberLoginAsForeignForeignOverTest.HasConditionQuery)
            { _nssMemberLoginAsForeignForeignOverTest = new MemberLoginNss(Query().QueryMemberLoginAsForeignForeignOverTest()); }
            return _nssMemberLoginAsForeignForeignOverTest;
        }
        protected MemberLoginNss _nssMemberLoginAsForeignForeignParameterOverTest;
        public MemberLoginNss NssMemberLoginAsForeignForeignParameterOverTest { get {
            if (_nssMemberLoginAsForeignForeignParameterOverTest == null) { _nssMemberLoginAsForeignForeignParameterOverTest = new MemberLoginNss(null); }
            return _nssMemberLoginAsForeignForeignParameterOverTest;
        }}
        public MemberLoginNss SetupSelect_MemberLoginAsForeignForeignParameterOverTest(DateTime targetDate) {
            doSetupSelect(delegate { return Query().QueryMemberLoginAsForeignForeignParameterOverTest(targetDate); });
            if (_nssMemberLoginAsForeignForeignParameterOverTest == null || !_nssMemberLoginAsForeignForeignParameterOverTest.HasConditionQuery)
            { _nssMemberLoginAsForeignForeignParameterOverTest = new MemberLoginNss(Query().QueryMemberLoginAsForeignForeignParameterOverTest(targetDate)); }
            return _nssMemberLoginAsForeignForeignParameterOverTest;
        }
        protected MemberLoginNss _nssMemberLoginAsForeignForeignVariousOverTest;
        public MemberLoginNss NssMemberLoginAsForeignForeignVariousOverTest { get {
            if (_nssMemberLoginAsForeignForeignVariousOverTest == null) { _nssMemberLoginAsForeignForeignVariousOverTest = new MemberLoginNss(null); }
            return _nssMemberLoginAsForeignForeignVariousOverTest;
        }}
        public MemberLoginNss SetupSelect_MemberLoginAsForeignForeignVariousOverTest() {
            doSetupSelect(delegate { return Query().QueryMemberLoginAsForeignForeignVariousOverTest(); });
            if (_nssMemberLoginAsForeignForeignVariousOverTest == null || !_nssMemberLoginAsForeignForeignVariousOverTest.HasConditionQuery)
            { _nssMemberLoginAsForeignForeignVariousOverTest = new MemberLoginNss(Query().QueryMemberLoginAsForeignForeignVariousOverTest()); }
            return _nssMemberLoginAsForeignForeignVariousOverTest;
        }
        protected MemberLoginNss _nssMemberLoginAsReferrerOverTest;
        public MemberLoginNss NssMemberLoginAsReferrerOverTest { get {
            if (_nssMemberLoginAsReferrerOverTest == null) { _nssMemberLoginAsReferrerOverTest = new MemberLoginNss(null); }
            return _nssMemberLoginAsReferrerOverTest;
        }}
        public MemberLoginNss SetupSelect_MemberLoginAsReferrerOverTest() {
            doSetupSelect(delegate { return Query().QueryMemberLoginAsReferrerOverTest(); });
            if (_nssMemberLoginAsReferrerOverTest == null || !_nssMemberLoginAsReferrerOverTest.HasConditionQuery)
            { _nssMemberLoginAsReferrerOverTest = new MemberLoginNss(Query().QueryMemberLoginAsReferrerOverTest()); }
            return _nssMemberLoginAsReferrerOverTest;
        }
        protected MemberLoginNss _nssMemberLoginAsReferrerForeignOverTest;
        public MemberLoginNss NssMemberLoginAsReferrerForeignOverTest { get {
            if (_nssMemberLoginAsReferrerForeignOverTest == null) { _nssMemberLoginAsReferrerForeignOverTest = new MemberLoginNss(null); }
            return _nssMemberLoginAsReferrerForeignOverTest;
        }}
        public MemberLoginNss SetupSelect_MemberLoginAsReferrerForeignOverTest() {
            doSetupSelect(delegate { return Query().QueryMemberLoginAsReferrerForeignOverTest(); });
            if (_nssMemberLoginAsReferrerForeignOverTest == null || !_nssMemberLoginAsReferrerForeignOverTest.HasConditionQuery)
            { _nssMemberLoginAsReferrerForeignOverTest = new MemberLoginNss(Query().QueryMemberLoginAsReferrerForeignOverTest()); }
            return _nssMemberLoginAsReferrerForeignOverTest;
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
        protected MemberAddressCBSpecification _memberAddressAsValid;
        protected MemberLoginCBSpecification _memberLoginAsLocalForeignOverTest;
        protected MemberLoginCBSpecification _memberLoginAsForeignForeignOverTest;
        protected MemberLoginCBSpecification _memberLoginAsForeignForeignParameterOverTest;
        protected MemberLoginCBSpecification _memberLoginAsForeignForeignVariousOverTest;
        protected MemberLoginCBSpecification _memberLoginAsReferrerOverTest;
        protected MemberLoginCBSpecification _memberLoginAsReferrerForeignOverTest;
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
        protected override String getTableDbName() { return "member"; }
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
        public MemberAddressCBSpecification SpecifyMemberAddressAsValid() {
            assertForeign("memberAddressAsValid");
            if (_memberAddressAsValid == null) {
                _memberAddressAsValid = new MemberAddressCBSpecification(_baseCB, new MemberAddressAsValidSpQyCall(_qyCall), _forDerivedReferrer, _forScalarSelect, _forScalarCondition, _forColumnQuery);
                if (xhasSyncQyCall()) // inherits it
                { _memberAddressAsValid.xsetSyncQyCall(new MemberAddressAsValidSpQyCall(xsyncQyCall())); }
            }
            return _memberAddressAsValid;
        }
		public class MemberAddressAsValidSpQyCall : HpSpQyCall<MemberAddressCQ> {
		    protected HpSpQyCall<MemberCQ> _qyCall;
		    public MemberAddressAsValidSpQyCall(HpSpQyCall<MemberCQ> myQyCall) { _qyCall = myQyCall; }
		    public bool has() { return _qyCall.has() && _qyCall.qy().hasConditionQueryMemberAddressAsValid(); }
			public MemberAddressCQ qy() { return _qyCall.qy().ConditionQueryMemberAddressAsValid; }
		}
        public MemberLoginCBSpecification SpecifyMemberLoginAsLocalForeignOverTest() {
            assertForeign("memberLoginAsLocalForeignOverTest");
            if (_memberLoginAsLocalForeignOverTest == null) {
                _memberLoginAsLocalForeignOverTest = new MemberLoginCBSpecification(_baseCB, new MemberLoginAsLocalForeignOverTestSpQyCall(_qyCall), _forDerivedReferrer, _forScalarSelect, _forScalarCondition, _forColumnQuery);
                if (xhasSyncQyCall()) // inherits it
                { _memberLoginAsLocalForeignOverTest.xsetSyncQyCall(new MemberLoginAsLocalForeignOverTestSpQyCall(xsyncQyCall())); }
            }
            return _memberLoginAsLocalForeignOverTest;
        }
		public class MemberLoginAsLocalForeignOverTestSpQyCall : HpSpQyCall<MemberLoginCQ> {
		    protected HpSpQyCall<MemberCQ> _qyCall;
		    public MemberLoginAsLocalForeignOverTestSpQyCall(HpSpQyCall<MemberCQ> myQyCall) { _qyCall = myQyCall; }
		    public bool has() { return _qyCall.has() && _qyCall.qy().hasConditionQueryMemberLoginAsLocalForeignOverTest(); }
			public MemberLoginCQ qy() { return _qyCall.qy().QueryMemberLoginAsLocalForeignOverTest(); }
		}
        public MemberLoginCBSpecification SpecifyMemberLoginAsForeignForeignOverTest() {
            assertForeign("memberLoginAsForeignForeignOverTest");
            if (_memberLoginAsForeignForeignOverTest == null) {
                _memberLoginAsForeignForeignOverTest = new MemberLoginCBSpecification(_baseCB, new MemberLoginAsForeignForeignOverTestSpQyCall(_qyCall), _forDerivedReferrer, _forScalarSelect, _forScalarCondition, _forColumnQuery);
                if (xhasSyncQyCall()) // inherits it
                { _memberLoginAsForeignForeignOverTest.xsetSyncQyCall(new MemberLoginAsForeignForeignOverTestSpQyCall(xsyncQyCall())); }
            }
            return _memberLoginAsForeignForeignOverTest;
        }
		public class MemberLoginAsForeignForeignOverTestSpQyCall : HpSpQyCall<MemberLoginCQ> {
		    protected HpSpQyCall<MemberCQ> _qyCall;
		    public MemberLoginAsForeignForeignOverTestSpQyCall(HpSpQyCall<MemberCQ> myQyCall) { _qyCall = myQyCall; }
		    public bool has() { return _qyCall.has() && _qyCall.qy().hasConditionQueryMemberLoginAsForeignForeignOverTest(); }
			public MemberLoginCQ qy() { return _qyCall.qy().QueryMemberLoginAsForeignForeignOverTest(); }
		}
        public MemberLoginCBSpecification SpecifyMemberLoginAsForeignForeignParameterOverTest() {
            assertForeign("memberLoginAsForeignForeignParameterOverTest");
            if (_memberLoginAsForeignForeignParameterOverTest == null) {
                _memberLoginAsForeignForeignParameterOverTest = new MemberLoginCBSpecification(_baseCB, new MemberLoginAsForeignForeignParameterOverTestSpQyCall(_qyCall), _forDerivedReferrer, _forScalarSelect, _forScalarCondition, _forColumnQuery);
                if (xhasSyncQyCall()) // inherits it
                { _memberLoginAsForeignForeignParameterOverTest.xsetSyncQyCall(new MemberLoginAsForeignForeignParameterOverTestSpQyCall(xsyncQyCall())); }
            }
            return _memberLoginAsForeignForeignParameterOverTest;
        }
		public class MemberLoginAsForeignForeignParameterOverTestSpQyCall : HpSpQyCall<MemberLoginCQ> {
		    protected HpSpQyCall<MemberCQ> _qyCall;
		    public MemberLoginAsForeignForeignParameterOverTestSpQyCall(HpSpQyCall<MemberCQ> myQyCall) { _qyCall = myQyCall; }
		    public bool has() { return _qyCall.has() && _qyCall.qy().hasConditionQueryMemberLoginAsForeignForeignParameterOverTest(); }
			public MemberLoginCQ qy() { return _qyCall.qy().ConditionQueryMemberLoginAsForeignForeignParameterOverTest; }
		}
        public MemberLoginCBSpecification SpecifyMemberLoginAsForeignForeignVariousOverTest() {
            assertForeign("memberLoginAsForeignForeignVariousOverTest");
            if (_memberLoginAsForeignForeignVariousOverTest == null) {
                _memberLoginAsForeignForeignVariousOverTest = new MemberLoginCBSpecification(_baseCB, new MemberLoginAsForeignForeignVariousOverTestSpQyCall(_qyCall), _forDerivedReferrer, _forScalarSelect, _forScalarCondition, _forColumnQuery);
                if (xhasSyncQyCall()) // inherits it
                { _memberLoginAsForeignForeignVariousOverTest.xsetSyncQyCall(new MemberLoginAsForeignForeignVariousOverTestSpQyCall(xsyncQyCall())); }
            }
            return _memberLoginAsForeignForeignVariousOverTest;
        }
		public class MemberLoginAsForeignForeignVariousOverTestSpQyCall : HpSpQyCall<MemberLoginCQ> {
		    protected HpSpQyCall<MemberCQ> _qyCall;
		    public MemberLoginAsForeignForeignVariousOverTestSpQyCall(HpSpQyCall<MemberCQ> myQyCall) { _qyCall = myQyCall; }
		    public bool has() { return _qyCall.has() && _qyCall.qy().hasConditionQueryMemberLoginAsForeignForeignVariousOverTest(); }
			public MemberLoginCQ qy() { return _qyCall.qy().QueryMemberLoginAsForeignForeignVariousOverTest(); }
		}
        public MemberLoginCBSpecification SpecifyMemberLoginAsReferrerOverTest() {
            assertForeign("memberLoginAsReferrerOverTest");
            if (_memberLoginAsReferrerOverTest == null) {
                _memberLoginAsReferrerOverTest = new MemberLoginCBSpecification(_baseCB, new MemberLoginAsReferrerOverTestSpQyCall(_qyCall), _forDerivedReferrer, _forScalarSelect, _forScalarCondition, _forColumnQuery);
                if (xhasSyncQyCall()) // inherits it
                { _memberLoginAsReferrerOverTest.xsetSyncQyCall(new MemberLoginAsReferrerOverTestSpQyCall(xsyncQyCall())); }
            }
            return _memberLoginAsReferrerOverTest;
        }
		public class MemberLoginAsReferrerOverTestSpQyCall : HpSpQyCall<MemberLoginCQ> {
		    protected HpSpQyCall<MemberCQ> _qyCall;
		    public MemberLoginAsReferrerOverTestSpQyCall(HpSpQyCall<MemberCQ> myQyCall) { _qyCall = myQyCall; }
		    public bool has() { return _qyCall.has() && _qyCall.qy().hasConditionQueryMemberLoginAsReferrerOverTest(); }
			public MemberLoginCQ qy() { return _qyCall.qy().QueryMemberLoginAsReferrerOverTest(); }
		}
        public MemberLoginCBSpecification SpecifyMemberLoginAsReferrerForeignOverTest() {
            assertForeign("memberLoginAsReferrerForeignOverTest");
            if (_memberLoginAsReferrerForeignOverTest == null) {
                _memberLoginAsReferrerForeignOverTest = new MemberLoginCBSpecification(_baseCB, new MemberLoginAsReferrerForeignOverTestSpQyCall(_qyCall), _forDerivedReferrer, _forScalarSelect, _forScalarCondition, _forColumnQuery);
                if (xhasSyncQyCall()) // inherits it
                { _memberLoginAsReferrerForeignOverTest.xsetSyncQyCall(new MemberLoginAsReferrerForeignOverTestSpQyCall(xsyncQyCall())); }
            }
            return _memberLoginAsReferrerForeignOverTest;
        }
		public class MemberLoginAsReferrerForeignOverTestSpQyCall : HpSpQyCall<MemberLoginCQ> {
		    protected HpSpQyCall<MemberCQ> _qyCall;
		    public MemberLoginAsReferrerForeignOverTestSpQyCall(HpSpQyCall<MemberCQ> myQyCall) { _qyCall = myQyCall; }
		    public bool has() { return _qyCall.has() && _qyCall.qy().hasConditionQueryMemberLoginAsReferrerForeignOverTest(); }
			public MemberLoginCQ qy() { return _qyCall.qy().QueryMemberLoginAsReferrerForeignOverTest(); }
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
