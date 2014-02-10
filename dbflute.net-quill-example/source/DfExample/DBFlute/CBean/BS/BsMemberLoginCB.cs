
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
    public class BsMemberLoginCB : AbstractConditionBean {

        // ===============================================================================
        //                                                                       Attribute
        //                                                                       =========
        protected MemberLoginCQ _conditionQuery;

        // ===============================================================================
        //                                                                      Table Name
        //                                                                      ==========
        public override String TableDbName { get { return "member_login"; } }

        // ===============================================================================
        //                                                             PrimaryKey Handling
        //                                                             ===================
        public void AcceptPrimaryKey(long? memberLoginId) {
            assertObjectNotNull("memberLoginId", memberLoginId);
            BsMemberLoginCB cb = this;
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
        public MemberLoginCQ Query() {
            return this.ConditionQuery;
        }

        public MemberLoginCQ ConditionQuery {
            get {
                if (_conditionQuery == null) {
                    _conditionQuery = CreateLocalCQ();
                }
                return _conditionQuery;
            }
        }

        protected virtual MemberLoginCQ CreateLocalCQ() {
            return xcreateCQ(null, this.SqlClause, this.SqlClause.getBasePointAliasName(), 0);
        }

        protected virtual MemberLoginCQ xcreateCQ(ConditionQuery childQuery, SqlClause sqlClause, String aliasName, int nestLevel) {
            return new MemberLoginCQ(childQuery, sqlClause, aliasName, nestLevel);
        }

        public override ConditionQuery LocalCQ {
            get { return this.ConditionQuery; }
        }

        // ===============================================================================
        //                                                                           Union
        //                                                                           =====
	    public virtual void Union(UnionQuery<MemberLoginCB> unionQuery) {
            MemberLoginCB cb = new MemberLoginCB();
            cb.xsetupForUnion(this); xsyncUQ(cb); unionQuery.Invoke(cb);
		    MemberLoginCQ cq = cb.Query(); Query().xsetUnionQuery(cq);
        }

	    public virtual void UnionAll(UnionQuery<MemberLoginCB> unionQuery) {
            MemberLoginCB cb = new MemberLoginCB();
            cb.xsetupForUnion(this); xsyncUQ(cb); unionQuery.Invoke(cb);
		    MemberLoginCQ cq = cb.Query(); Query().xsetUnionAllQuery(cq);
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
            if (HasSpecifiedColumn) { // if reverse call
                Specify().ColumnMemberId();
            }
            doSetupSelect(delegate { return Query().QueryMember(); });
            if (_nssMember == null || !_nssMember.HasConditionQuery)
            { _nssMember = new MemberNss(Query().QueryMember()); }
            return _nssMember;
        }
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

        // [DBFlute-0.7.4]
        // ===============================================================================
        //                                                                         Specify
        //                                                                         =======
        protected MemberLoginCBSpecification _specification;
        public MemberLoginCBSpecification Specify() {
            if (_specification == null) { _specification = new MemberLoginCBSpecification(this, new MySpQyCall(this), _forDerivedReferrer, _forScalarSelect, _forScalarCondition, _forColumnQuery); }
            return _specification;
        }
        protected bool HasSpecifiedColumn { get {
            return _specification != null && _specification.IsAlreadySpecifiedRequiredColumn;
        }}
        protected class MySpQyCall : HpSpQyCall<MemberLoginCQ> {
			protected BsMemberLoginCB _myCB;
			public MySpQyCall(BsMemberLoginCB myCB) { _myCB = myCB; }
    		public bool has() { return true; } public MemberLoginCQ qy() { return _myCB.Query(); }
    	}

        // [DBFlute-0.8.9.18]
        // ===============================================================================
        //                                                                     ColumnQuery
        //                                                                     ===========
        public HpColQyOperand<MemberLoginCB> ColumnQuery(SpecifyQuery<MemberLoginCB> leftSpecifyQuery) {
            return new HpColQyOperand<MemberLoginCB>(delegate(SpecifyQuery<MemberLoginCB> rightSp, String operand) {
                xcolqy(xcreateColumnQueryCB(), xcreateColumnQueryCB(), leftSpecifyQuery, rightSp, operand);
            });
        }

        protected MemberLoginCB xcreateColumnQueryCB() {
            MemberLoginCB cb = new MemberLoginCB();
            cb.xsetupForColumnQuery((MemberLoginCB)this);
            return cb;
        }

        // [DBFlute-0.8.9.9]
        // ===============================================================================
        //                                                                    OrScopeQuery
        //                                                                    ============
        public void OrScopeQuery(OrQuery<MemberLoginCB> orQuery) {
            xorQ((MemberLoginCB)this, orQuery);
        }

        // ===============================================================================
        //                                                                    Purpose Type
        //                                                                    ============
        public void xsetupForColumnQuery(MemberLoginCB mainCB) {
            xinheritSubQueryInfo(mainCB.LocalCQ);
            //xchangePurposeSqlClause(HpCBPurpose.COLUMN_QUERY);
            _forColumnQuery = true; // old style

            // inherits a parent query to synchronize real name
            // (and also for suppressing query check) 
            Specify().xsetSyncQyCall(new MemberLoginCBColQySpQyCall(mainCB));
        }
    }

    public class MemberLoginCBColQySpQyCall : HpSpQyCall<MemberLoginCQ> {
        protected MemberLoginCB _mainCB;
        public MemberLoginCBColQySpQyCall(MemberLoginCB mainCB) {
            _mainCB = mainCB;
        }
        public bool has() { return true; } 
        public MemberLoginCQ qy() { return _mainCB.Query(); } 
    }

    public class MemberLoginCBSpecification : AbstractSpecification<MemberLoginCQ> {
        protected MemberCBSpecification _member;
        protected MemberStatusCBSpecification _memberStatus;
        public MemberLoginCBSpecification(ConditionBean baseCB, HpSpQyCall<MemberLoginCQ> qyCall
                                                      , bool forDerivedReferrer, bool forScalarSelect, bool forScalarSubQuery, bool forColumnQuery)
        : base(baseCB, qyCall, forDerivedReferrer, forScalarSelect, forScalarSubQuery, forColumnQuery) { }
        public void ColumnMemberLoginId() { doColumn("MEMBER_LOGIN_ID"); }
        public void ColumnMemberId() { doColumn("MEMBER_ID"); }
        public void ColumnLoginDatetime() { doColumn("LOGIN_DATETIME"); }
        public void ColumnMobileLoginFlg() { doColumn("MOBILE_LOGIN_FLG"); }
        public void ColumnLoginMemberStatusCode() { doColumn("LOGIN_MEMBER_STATUS_CODE"); }
        protected override void doSpecifyRequiredColumn() {
            ColumnMemberLoginId(); // PK
            if (qyCall().qy().hasConditionQueryMember()
                    || qyCall().qy().xgetReferrerQuery() is MemberCQ) {
                ColumnMemberId(); // FK or one-to-one referrer
            }
            if (qyCall().qy().hasConditionQueryMemberStatus()
                    || qyCall().qy().xgetReferrerQuery() is MemberStatusCQ) {
                ColumnLoginMemberStatusCode(); // FK or one-to-one referrer
            }
        }
        protected override String getTableDbName() { return "member_login"; }
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
		    protected HpSpQyCall<MemberLoginCQ> _qyCall;
		    public MemberSpQyCall(HpSpQyCall<MemberLoginCQ> myQyCall) { _qyCall = myQyCall; }
		    public bool has() { return _qyCall.has() && _qyCall.qy().hasConditionQueryMember(); }
			public MemberCQ qy() { return _qyCall.qy().QueryMember(); }
		}
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
		    protected HpSpQyCall<MemberLoginCQ> _qyCall;
		    public MemberStatusSpQyCall(HpSpQyCall<MemberLoginCQ> myQyCall) { _qyCall = myQyCall; }
		    public bool has() { return _qyCall.has() && _qyCall.qy().hasConditionQueryMemberStatus(); }
			public MemberStatusCQ qy() { return _qyCall.qy().QueryMemberStatus(); }
		}
    }
}
