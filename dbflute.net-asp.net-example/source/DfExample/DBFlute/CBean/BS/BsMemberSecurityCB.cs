
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
    public class BsMemberSecurityCB : AbstractConditionBean {

        // ===============================================================================
        //                                                                       Attribute
        //                                                                       =========
        protected MemberSecurityCQ _conditionQuery;

        // ===============================================================================
        //                                                                      Table Name
        //                                                                      ==========
        public override String TableDbName { get { return "MEMBER_SECURITY"; } }

        // ===============================================================================
        //                                                             PrimaryKey Handling
        //                                                             ===================
        public void AcceptPrimaryKey(long? memberId) {
            assertObjectNotNull("memberId", memberId);
            BsMemberSecurityCB cb = this;
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
        public MemberSecurityCQ Query() {
            return this.ConditionQuery;
        }

        public MemberSecurityCQ ConditionQuery {
            get {
                if (_conditionQuery == null) {
                    _conditionQuery = CreateLocalCQ();
                }
                return _conditionQuery;
            }
        }

        protected virtual MemberSecurityCQ CreateLocalCQ() {
            return xcreateCQ(null, this.SqlClause, this.SqlClause.getBasePointAliasName(), 0);
        }

        protected virtual MemberSecurityCQ xcreateCQ(ConditionQuery childQuery, SqlClause sqlClause, String aliasName, int nestLevel) {
            return new MemberSecurityCQ(childQuery, sqlClause, aliasName, nestLevel);
        }

        public override ConditionQuery LocalCQ {
            get { return this.ConditionQuery; }
        }

        // ===============================================================================
        //                                                                           Union
        //                                                                           =====
	    public virtual void Union(UnionQuery<MemberSecurityCB> unionQuery) {
            MemberSecurityCB cb = new MemberSecurityCB();
            cb.xsetupForUnion(this); xsyncUQ(cb); unionQuery.Invoke(cb);
		    MemberSecurityCQ cq = cb.Query(); Query().xsetUnionQuery(cq);
        }

	    public virtual void UnionAll(UnionQuery<MemberSecurityCB> unionQuery) {
            MemberSecurityCB cb = new MemberSecurityCB();
            cb.xsetupForUnion(this); xsyncUQ(cb); unionQuery.Invoke(cb);
		    MemberSecurityCQ cq = cb.Query(); Query().xsetUnionAllQuery(cq);
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

        // [DBFlute-0.7.4]
        // ===============================================================================
        //                                                                         Specify
        //                                                                         =======
        protected MemberSecurityCBSpecification _specification;
        public MemberSecurityCBSpecification Specify() {
            if (_specification == null) { _specification = new MemberSecurityCBSpecification(this, new MySpQyCall(this), _forDerivedReferrer, _forScalarSelect, _forScalarCondition, _forColumnQuery); }
            return _specification;
        }
        protected bool HasSpecifiedColumn { get {
            return _specification != null && _specification.IsAlreadySpecifiedRequiredColumn;
        }}
        protected class MySpQyCall : HpSpQyCall<MemberSecurityCQ> {
			protected BsMemberSecurityCB _myCB;
			public MySpQyCall(BsMemberSecurityCB myCB) { _myCB = myCB; }
    		public bool has() { return true; } public MemberSecurityCQ qy() { return _myCB.Query(); }
    	}

        // [DBFlute-0.8.9.18]
        // ===============================================================================
        //                                                                     ColumnQuery
        //                                                                     ===========
        public HpColQyOperand<MemberSecurityCB> ColumnQuery(SpecifyQuery<MemberSecurityCB> leftSpecifyQuery) {
            return new HpColQyOperand<MemberSecurityCB>(delegate(SpecifyQuery<MemberSecurityCB> rightSp, String operand) {
                xcolqy(xcreateColumnQueryCB(), xcreateColumnQueryCB(), leftSpecifyQuery, rightSp, operand);
            });
        }

        protected MemberSecurityCB xcreateColumnQueryCB() {
            MemberSecurityCB cb = new MemberSecurityCB();
            cb.xsetupForColumnQuery((MemberSecurityCB)this);
            return cb;
        }

        // [DBFlute-0.8.9.9]
        // ===============================================================================
        //                                                                    OrScopeQuery
        //                                                                    ============
        public void OrScopeQuery(OrQuery<MemberSecurityCB> orQuery) {
            xorQ((MemberSecurityCB)this, orQuery);
        }

        // ===============================================================================
        //                                                                    Purpose Type
        //                                                                    ============
        public void xsetupForColumnQuery(MemberSecurityCB mainCB) {
            xinheritSubQueryInfo(mainCB.LocalCQ);
            //xchangePurposeSqlClause(HpCBPurpose.COLUMN_QUERY);
            _forColumnQuery = true; // old style

            // inherits a parent query to synchronize real name
            // (and also for suppressing query check) 
            Specify().xsetSyncQyCall(new MemberSecurityCBColQySpQyCall(mainCB));
        }
    }

    public class MemberSecurityCBColQySpQyCall : HpSpQyCall<MemberSecurityCQ> {
        protected MemberSecurityCB _mainCB;
        public MemberSecurityCBColQySpQyCall(MemberSecurityCB mainCB) {
            _mainCB = mainCB;
        }
        public bool has() { return true; } 
        public MemberSecurityCQ qy() { return _mainCB.Query(); } 
    }

    public class MemberSecurityCBSpecification : AbstractSpecification<MemberSecurityCQ> {
        protected MemberCBSpecification _member;
        public MemberSecurityCBSpecification(ConditionBean baseCB, HpSpQyCall<MemberSecurityCQ> qyCall
                                                      , bool forDerivedReferrer, bool forScalarSelect, bool forScalarSubQuery, bool forColumnQuery)
        : base(baseCB, qyCall, forDerivedReferrer, forScalarSelect, forScalarSubQuery, forColumnQuery) { }
        public void ColumnMemberId() { doColumn("MEMBER_ID"); }
        public void ColumnLoginPassword() { doColumn("LOGIN_PASSWORD"); }
        public void ColumnReminderQuestion() { doColumn("REMINDER_QUESTION"); }
        public void ColumnReminderAnswer() { doColumn("REMINDER_ANSWER"); }
        public void ColumnRegisterDatetime() { doColumn("REGISTER_DATETIME"); }
        public void ColumnRegisterProcess() { doColumn("REGISTER_PROCESS"); }
        public void ColumnRegisterUser() { doColumn("REGISTER_USER"); }
        public void ColumnUpdateDatetime() { doColumn("UPDATE_DATETIME"); }
        public void ColumnUpdateProcess() { doColumn("UPDATE_PROCESS"); }
        public void ColumnUpdateUser() { doColumn("UPDATE_USER"); }
        public void ColumnVersionNo() { doColumn("VERSION_NO"); }
        protected override void doSpecifyRequiredColumn() {
            ColumnMemberId(); // PK
        }
        protected override String getTableDbName() { return "MEMBER_SECURITY"; }
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
		    protected HpSpQyCall<MemberSecurityCQ> _qyCall;
		    public MemberSpQyCall(HpSpQyCall<MemberSecurityCQ> myQyCall) { _qyCall = myQyCall; }
		    public bool has() { return _qyCall.has() && _qyCall.qy().hasConditionQueryMember(); }
			public MemberCQ qy() { return _qyCall.qy().QueryMember(); }
		}
    }
}
