
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
    public class MbBsMemberLoginCB : MbAbstractConditionBean {

        // ===============================================================================
        //                                                                       Attribute
        //                                                                       =========
        protected MbMemberLoginCQ _conditionQuery;

        // ===============================================================================
        //                                                                      Table Name
        //                                                                      ==========
        public override String TableDbName { get { return "member_login"; } }

        // ===============================================================================
        //                                                             PrimaryKey Handling
        //                                                             ===================
        public void AcceptPrimaryKey(long? memberLoginId) {
            assertObjectNotNull("memberLoginId", memberLoginId);
            MbBsMemberLoginCB cb = this;
            cb.Query().SetMemberLoginId_Equal(memberLoginId);
        }

        public override MbConditionBean AddOrderBy_PK_Asc() {
            Query().AddOrderBy_MemberLoginId_Asc();
            return this;
        }

        public override MbConditionBean AddOrderBy_PK_Desc() {
            Query().AddOrderBy_MemberLoginId_Desc();
            return this;
        }

        // ===============================================================================
        //                                                                           Query
        //                                                                           =====
        public MbMemberLoginCQ Query() {
            return this.ConditionQuery;
        }

        public MbMemberLoginCQ ConditionQuery {
            get {
                if (_conditionQuery == null) {
                    _conditionQuery = CreateLocalCQ();
                }
                return _conditionQuery;
            }
        }

        protected virtual MbMemberLoginCQ CreateLocalCQ() {
            return xcreateCQ(null, this.SqlClause, this.SqlClause.getBasePointAliasName(), 0);
        }

        protected virtual MbMemberLoginCQ xcreateCQ(MbConditionQuery childQuery, MbSqlClause sqlClause, String aliasName, int nestLevel) {
            return new MbMemberLoginCQ(childQuery, sqlClause, aliasName, nestLevel);
        }

        public override MbConditionQuery LocalCQ {
            get { return this.ConditionQuery; }
        }

        // ===============================================================================
        //                                                                           Union
        //                                                                           =====
	    public virtual void Union(MbUnionQuery<MbMemberLoginCB> unionQuery) {
            MbMemberLoginCB cb = new MbMemberLoginCB();
            cb.xsetupForUnion(this); xsyncUQ(cb); unionQuery.Invoke(cb);
		    MbMemberLoginCQ cq = cb.Query(); Query().xsetUnionQuery(cq);
        }

	    public virtual void UnionAll(MbUnionQuery<MbMemberLoginCB> unionQuery) {
            MbMemberLoginCB cb = new MbMemberLoginCB();
            cb.xsetupForUnion(this); xsyncUQ(cb); unionQuery.Invoke(cb);
		    MbMemberLoginCQ cq = cb.Query(); Query().xsetUnionAllQuery(cq);
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
            if (HasSpecifiedColumn) { // if reverse call
                Specify().ColumnMemberId();
            }
            doSetupSelect(delegate { return Query().QueryMember(); });
            if (_nssMember == null || !_nssMember.HasConditionQuery)
            { _nssMember = new MbMemberNss(Query().QueryMember()); }
            return _nssMember;
        }
        protected MbMemberStatusNss _nssMemberStatus;
        public MbMemberStatusNss NssMemberStatus { get {
            if (_nssMemberStatus == null) { _nssMemberStatus = new MbMemberStatusNss(null); }
            return _nssMemberStatus;
        }}
        public MbMemberStatusNss SetupSelect_MemberStatus() {
            if (HasSpecifiedColumn) { // if reverse call
                Specify().ColumnLoginMemberStatusCode();
            }
            doSetupSelect(delegate { return Query().QueryMemberStatus(); });
            if (_nssMemberStatus == null || !_nssMemberStatus.HasConditionQuery)
            { _nssMemberStatus = new MbMemberStatusNss(Query().QueryMemberStatus()); }
            return _nssMemberStatus;
        }

        // [DBFlute-0.7.4]
        // ===============================================================================
        //                                                                         Specify
        //                                                                         =======
        protected MbMemberLoginCBSpecification _specification;
        public MbMemberLoginCBSpecification Specify() {
            if (_specification == null) { _specification = new MbMemberLoginCBSpecification(this, new MySpQyCall(this), _forDerivedReferrer, _forScalarSelect, _forScalarCondition, _forColumnQuery); }
            return _specification;
        }
        protected bool HasSpecifiedColumn { get {
            return _specification != null && _specification.IsAlreadySpecifiedRequiredColumn;
        }}
        protected class MySpQyCall : HpSpQyCall<MbMemberLoginCQ> {
			protected MbBsMemberLoginCB _myCB;
			public MySpQyCall(MbBsMemberLoginCB myCB) { _myCB = myCB; }
    		public bool has() { return true; } public MbMemberLoginCQ qy() { return _myCB.Query(); }
    	}

        // [DBFlute-0.8.9.18]
        // ===============================================================================
        //                                                                     ColumnQuery
        //                                                                     ===========
        public HpColQyOperand<MbMemberLoginCB> ColumnQuery(MbSpecifyQuery<MbMemberLoginCB> leftSpecifyQuery) {
            return new HpColQyOperand<MbMemberLoginCB>(delegate(MbSpecifyQuery<MbMemberLoginCB> rightSp, String operand) {
                xcolqy(xcreateColumnQueryCB(), xcreateColumnQueryCB(), leftSpecifyQuery, rightSp, operand);
            });
        }

        protected MbMemberLoginCB xcreateColumnQueryCB() {
            MbMemberLoginCB cb = new MbMemberLoginCB();
            cb.xsetupForColumnQuery((MbMemberLoginCB)this);
            return cb;
        }

        // [DBFlute-0.8.9.9]
        // ===============================================================================
        //                                                                    OrScopeQuery
        //                                                                    ============
        public void OrScopeQuery(MbOrQuery<MbMemberLoginCB> orQuery) {
            xorQ((MbMemberLoginCB)this, orQuery);
        }

        // ===============================================================================
        //                                                                    Purpose Type
        //                                                                    ============
        public void xsetupForColumnQuery(MbMemberLoginCB mainCB) {
            xinheritSubQueryInfo(mainCB.LocalCQ);
            //xchangePurposeSqlClause(HpCBPurpose.COLUMN_QUERY);
            _forColumnQuery = true; // old style

            // inherits a parent query to synchronize real name
            // (and also for suppressing query check) 
            Specify().xsetSyncQyCall(new MbMemberLoginCBColQySpQyCall(mainCB));
        }
    }

    public class MbMemberLoginCBColQySpQyCall : HpSpQyCall<MbMemberLoginCQ> {
        protected MbMemberLoginCB _mainCB;
        public MbMemberLoginCBColQySpQyCall(MbMemberLoginCB mainCB) {
            _mainCB = mainCB;
        }
        public bool has() { return true; } 
        public MbMemberLoginCQ qy() { return _mainCB.Query(); } 
    }

    public class MbMemberLoginCBSpecification : AbstractSpecification<MbMemberLoginCQ> {
        protected MbMemberCBSpecification _member;
        protected MbMemberStatusCBSpecification _memberStatus;
        public MbMemberLoginCBSpecification(MbConditionBean baseCB, HpSpQyCall<MbMemberLoginCQ> qyCall
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
                    || qyCall().qy().xgetReferrerQuery() is MbMemberCQ) {
                ColumnMemberId(); // FK or one-to-one referrer
            }
            if (qyCall().qy().hasConditionQueryMemberStatus()
                    || qyCall().qy().xgetReferrerQuery() is MbMemberStatusCQ) {
                ColumnLoginMemberStatusCode(); // FK or one-to-one referrer
            }
        }
        protected override String getTableDbName() { return "member_login"; }
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
		    protected HpSpQyCall<MbMemberLoginCQ> _qyCall;
		    public MemberSpQyCall(HpSpQyCall<MbMemberLoginCQ> myQyCall) { _qyCall = myQyCall; }
		    public bool has() { return _qyCall.has() && _qyCall.qy().hasConditionQueryMember(); }
			public MbMemberCQ qy() { return _qyCall.qy().QueryMember(); }
		}
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
		    protected HpSpQyCall<MbMemberLoginCQ> _qyCall;
		    public MemberStatusSpQyCall(HpSpQyCall<MbMemberLoginCQ> myQyCall) { _qyCall = myQyCall; }
		    public bool has() { return _qyCall.has() && _qyCall.qy().hasConditionQueryMemberStatus(); }
			public MbMemberStatusCQ qy() { return _qyCall.qy().QueryMemberStatus(); }
		}
    }
}
