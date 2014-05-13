
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
    public class BsVdSynonymMemberLoginCB : AbstractConditionBean {

        // ===============================================================================
        //                                                                       Attribute
        //                                                                       =========
        protected VdSynonymMemberLoginCQ _conditionQuery;

        // ===============================================================================
        //                                                                      Table Name
        //                                                                      ==========
        public override String TableDbName { get { return "VD_SYNONYM_MEMBER_LOGIN"; } }

        // ===============================================================================
        //                                                             PrimaryKey Handling
        //                                                             ===================
        public void AcceptPrimaryKey(long? memberLoginId) {
            assertObjectNotNull("memberLoginId", memberLoginId);
            BsVdSynonymMemberLoginCB cb = this;
            cb.Query().SetMemberLoginId_Equal(memberLoginId);
        }

        public override ConditionBean AddOrderBy_PK_Asc() {
            Query().AddOrderBy_MemberLoginId_Asc();
            return this;
        }

        public override ConditionBean AddOrderBy_PK_Desc() {
            Query().AddOrderBy_MemberLoginId_Desc();
            return this;
        }

        // ===============================================================================
        //                                                                           Query
        //                                                                           =====
        public VdSynonymMemberLoginCQ Query() {
            return this.ConditionQuery;
        }

        public VdSynonymMemberLoginCQ ConditionQuery {
            get {
                if (_conditionQuery == null) {
                    _conditionQuery = CreateLocalCQ();
                }
                return _conditionQuery;
            }
        }

        protected virtual VdSynonymMemberLoginCQ CreateLocalCQ() {
            return xcreateCQ(null, this.SqlClause, this.SqlClause.getBasePointAliasName(), 0);
        }

        protected virtual VdSynonymMemberLoginCQ xcreateCQ(ConditionQuery childQuery, SqlClause sqlClause, String aliasName, int nestLevel) {
            return new VdSynonymMemberLoginCQ(childQuery, sqlClause, aliasName, nestLevel);
        }

        public override ConditionQuery LocalCQ {
            get { return this.ConditionQuery; }
        }

        // ===============================================================================
        //                                                                           Union
        //                                                                           =====
	    public virtual void Union(UnionQuery<VdSynonymMemberLoginCB> unionQuery) {
            VdSynonymMemberLoginCB cb = new VdSynonymMemberLoginCB();
            cb.xsetupForUnion(this); xsyncUQ(cb); unionQuery.Invoke(cb);
		    VdSynonymMemberLoginCQ cq = cb.Query(); Query().xsetUnionQuery(cq);
        }

	    public virtual void UnionAll(UnionQuery<VdSynonymMemberLoginCB> unionQuery) {
            VdSynonymMemberLoginCB cb = new VdSynonymMemberLoginCB();
            cb.xsetupForUnion(this); xsyncUQ(cb); unionQuery.Invoke(cb);
		    VdSynonymMemberLoginCQ cq = cb.Query(); Query().xsetUnionAllQuery(cq);
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
                Specify().ColumnLoginMemberStatusCode();
            }
            doSetupSelect(delegate { return Query().QueryMemberStatus(); });
            if (_nssMemberStatus == null || !_nssMemberStatus.HasConditionQuery)
            { _nssMemberStatus = new MemberStatusNss(Query().QueryMemberStatus()); }
            return _nssMemberStatus;
        }
        protected MemberVendorSynonymNss _nssMemberVendorSynonym;
        public MemberVendorSynonymNss NssMemberVendorSynonym { get {
            if (_nssMemberVendorSynonym == null) { _nssMemberVendorSynonym = new MemberVendorSynonymNss(null); }
            return _nssMemberVendorSynonym;
        }}
        public MemberVendorSynonymNss SetupSelect_MemberVendorSynonym() {
            if (HasSpecifiedColumn) { // if reverse call
                Specify().ColumnMemberId();
            }
            doSetupSelect(delegate { return Query().QueryMemberVendorSynonym(); });
            if (_nssMemberVendorSynonym == null || !_nssMemberVendorSynonym.HasConditionQuery)
            { _nssMemberVendorSynonym = new MemberVendorSynonymNss(Query().QueryMemberVendorSynonym()); }
            return _nssMemberVendorSynonym;
        }
        protected VdSynonymMemberNss _nssVdSynonymMember;
        public VdSynonymMemberNss NssVdSynonymMember { get {
            if (_nssVdSynonymMember == null) { _nssVdSynonymMember = new VdSynonymMemberNss(null); }
            return _nssVdSynonymMember;
        }}
        public VdSynonymMemberNss SetupSelect_VdSynonymMember() {
            if (HasSpecifiedColumn) { // if reverse call
                Specify().ColumnMemberId();
            }
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
            if (HasSpecifiedColumn) { // if reverse call
                Specify().ColumnMemberId();
            }
            doSetupSelect(delegate { return Query().QueryVendorSynonymMember(); });
            if (_nssVendorSynonymMember == null || !_nssVendorSynonymMember.HasConditionQuery)
            { _nssVendorSynonymMember = new VendorSynonymMemberNss(Query().QueryVendorSynonymMember()); }
            return _nssVendorSynonymMember;
        }

        // [DBFlute-0.7.4]
        // ===============================================================================
        //                                                                         Specify
        //                                                                         =======
        protected VdSynonymMemberLoginCBSpecification _specification;
        public VdSynonymMemberLoginCBSpecification Specify() {
            if (_specification == null) { _specification = new VdSynonymMemberLoginCBSpecification(this, new MySpQyCall(this), _forDerivedReferrer, _forScalarSelect, _forScalarCondition, _forColumnQuery); }
            return _specification;
        }
        protected bool HasSpecifiedColumn { get {
            return _specification != null && _specification.IsAlreadySpecifiedRequiredColumn;
        }}
        protected class MySpQyCall : HpSpQyCall<VdSynonymMemberLoginCQ> {
			protected BsVdSynonymMemberLoginCB _myCB;
			public MySpQyCall(BsVdSynonymMemberLoginCB myCB) { _myCB = myCB; }
    		public bool has() { return true; } public VdSynonymMemberLoginCQ qy() { return _myCB.Query(); }
    	}

        // [DBFlute-0.8.9.18]
        // ===============================================================================
        //                                                                     ColumnQuery
        //                                                                     ===========
        public HpColQyOperand<VdSynonymMemberLoginCB> ColumnQuery(SpecifyQuery<VdSynonymMemberLoginCB> leftSpecifyQuery) {
            return new HpColQyOperand<VdSynonymMemberLoginCB>(delegate(SpecifyQuery<VdSynonymMemberLoginCB> rightSp, String operand) {
                xcolqy(xcreateColumnQueryCB(), xcreateColumnQueryCB(), leftSpecifyQuery, rightSp, operand);
            });
        }

        protected VdSynonymMemberLoginCB xcreateColumnQueryCB() {
            VdSynonymMemberLoginCB cb = new VdSynonymMemberLoginCB();
            cb.xsetupForColumnQuery((VdSynonymMemberLoginCB)this);
            return cb;
        }

        // [DBFlute-0.8.9.9]
        // ===============================================================================
        //                                                                    OrScopeQuery
        //                                                                    ============
        public void OrScopeQuery(OrQuery<VdSynonymMemberLoginCB> orQuery) {
            xorQ((VdSynonymMemberLoginCB)this, orQuery);
        }

        // ===============================================================================
        //                                                                    Purpose Type
        //                                                                    ============
        public void xsetupForColumnQuery(VdSynonymMemberLoginCB mainCB) {
            xinheritSubQueryInfo(mainCB.LocalCQ);
            //xchangePurposeSqlClause(HpCBPurpose.COLUMN_QUERY);
            _forColumnQuery = true; // old style

            // inherits a parent query to synchronize real name
            // (and also for suppressing query check) 
            Specify().xsetSyncQyCall(new VdSynonymMemberLoginCBColQySpQyCall(mainCB));
        }
    }

    public class VdSynonymMemberLoginCBColQySpQyCall : HpSpQyCall<VdSynonymMemberLoginCQ> {
        protected VdSynonymMemberLoginCB _mainCB;
        public VdSynonymMemberLoginCBColQySpQyCall(VdSynonymMemberLoginCB mainCB) {
            _mainCB = mainCB;
        }
        public bool has() { return true; } 
        public VdSynonymMemberLoginCQ qy() { return _mainCB.Query(); } 
    }

    public class VdSynonymMemberLoginCBSpecification : AbstractSpecification<VdSynonymMemberLoginCQ> {
        protected MemberStatusCBSpecification _memberStatus;
        protected MemberVendorSynonymCBSpecification _memberVendorSynonym;
        protected VdSynonymMemberCBSpecification _vdSynonymMember;
        protected VendorSynonymMemberCBSpecification _vendorSynonymMember;
        public VdSynonymMemberLoginCBSpecification(ConditionBean baseCB, HpSpQyCall<VdSynonymMemberLoginCQ> qyCall
                                                      , bool forDerivedReferrer, bool forScalarSelect, bool forScalarSubQuery, bool forColumnQuery)
        : base(baseCB, qyCall, forDerivedReferrer, forScalarSelect, forScalarSubQuery, forColumnQuery) { }
        public void ColumnMemberLoginId() { doColumn("MEMBER_LOGIN_ID"); }
        public void ColumnMemberId() { doColumn("MEMBER_ID"); }
        public void ColumnLoginDatetime() { doColumn("LOGIN_DATETIME"); }
        public void ColumnMobileLoginFlg() { doColumn("MOBILE_LOGIN_FLG"); }
        public void ColumnLoginMemberStatusCode() { doColumn("LOGIN_MEMBER_STATUS_CODE"); }
        protected override void doSpecifyRequiredColumn() {
            ColumnMemberLoginId(); // PK
            if (qyCall().qy().hasConditionQueryMemberStatus()
                    || qyCall().qy().xgetReferrerQuery() is MemberStatusCQ) {
                ColumnLoginMemberStatusCode(); // FK or one-to-one referrer
            }
            if (qyCall().qy().hasConditionQueryMemberVendorSynonym()
                    || qyCall().qy().xgetReferrerQuery() is MemberVendorSynonymCQ) {
                ColumnMemberId(); // FK or one-to-one referrer
            }
            if (qyCall().qy().hasConditionQueryVdSynonymMember()
                    || qyCall().qy().xgetReferrerQuery() is VdSynonymMemberCQ) {
                ColumnMemberId(); // FK or one-to-one referrer
            }
            if (qyCall().qy().hasConditionQueryVendorSynonymMember()
                    || qyCall().qy().xgetReferrerQuery() is VendorSynonymMemberCQ) {
                ColumnMemberId(); // FK or one-to-one referrer
            }
        }
        protected override String getTableDbName() { return "VD_SYNONYM_MEMBER_LOGIN"; }
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
		    protected HpSpQyCall<VdSynonymMemberLoginCQ> _qyCall;
		    public MemberStatusSpQyCall(HpSpQyCall<VdSynonymMemberLoginCQ> myQyCall) { _qyCall = myQyCall; }
		    public bool has() { return _qyCall.has() && _qyCall.qy().hasConditionQueryMemberStatus(); }
			public MemberStatusCQ qy() { return _qyCall.qy().QueryMemberStatus(); }
		}
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
		    protected HpSpQyCall<VdSynonymMemberLoginCQ> _qyCall;
		    public MemberVendorSynonymSpQyCall(HpSpQyCall<VdSynonymMemberLoginCQ> myQyCall) { _qyCall = myQyCall; }
		    public bool has() { return _qyCall.has() && _qyCall.qy().hasConditionQueryMemberVendorSynonym(); }
			public MemberVendorSynonymCQ qy() { return _qyCall.qy().QueryMemberVendorSynonym(); }
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
		    protected HpSpQyCall<VdSynonymMemberLoginCQ> _qyCall;
		    public VdSynonymMemberSpQyCall(HpSpQyCall<VdSynonymMemberLoginCQ> myQyCall) { _qyCall = myQyCall; }
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
		    protected HpSpQyCall<VdSynonymMemberLoginCQ> _qyCall;
		    public VendorSynonymMemberSpQyCall(HpSpQyCall<VdSynonymMemberLoginCQ> myQyCall) { _qyCall = myQyCall; }
		    public bool has() { return _qyCall.has() && _qyCall.qy().hasConditionQueryVendorSynonymMember(); }
			public VendorSynonymMemberCQ qy() { return _qyCall.qy().QueryVendorSynonymMember(); }
		}
    }
}
