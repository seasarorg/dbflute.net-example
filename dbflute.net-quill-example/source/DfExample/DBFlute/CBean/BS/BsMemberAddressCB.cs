
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
    public class BsMemberAddressCB : AbstractConditionBean {

        // ===============================================================================
        //                                                                       Attribute
        //                                                                       =========
        protected MemberAddressCQ _conditionQuery;

        // ===============================================================================
        //                                                                      Table Name
        //                                                                      ==========
        public override String TableDbName { get { return "member_address"; } }

        // ===============================================================================
        //                                                             PrimaryKey Handling
        //                                                             ===================
        public void AcceptPrimaryKey(int? memberAddressId) {
            assertObjectNotNull("memberAddressId", memberAddressId);
            BsMemberAddressCB cb = this;
            cb.Query().SetMemberAddressId_Equal(memberAddressId);
        }

        public override ConditionBean AddOrderBy_PK_Asc() {
            Query().AddOrderBy_MemberAddressId_Asc();
            return this;
        }

        public override ConditionBean AddOrderBy_PK_Desc() {
            Query().AddOrderBy_MemberAddressId_Desc();
            return this;
        }

        // ===============================================================================
        //                                                                           Query
        //                                                                           =====
        public MemberAddressCQ Query() {
            return this.ConditionQuery;
        }

        public MemberAddressCQ ConditionQuery {
            get {
                if (_conditionQuery == null) {
                    _conditionQuery = CreateLocalCQ();
                }
                return _conditionQuery;
            }
        }

        protected virtual MemberAddressCQ CreateLocalCQ() {
            return xcreateCQ(null, this.SqlClause, this.SqlClause.getBasePointAliasName(), 0);
        }

        protected virtual MemberAddressCQ xcreateCQ(ConditionQuery childQuery, SqlClause sqlClause, String aliasName, int nestLevel) {
            return new MemberAddressCQ(childQuery, sqlClause, aliasName, nestLevel);
        }

        public override ConditionQuery LocalCQ {
            get { return this.ConditionQuery; }
        }

        // ===============================================================================
        //                                                                           Union
        //                                                                           =====
	    public virtual void Union(UnionQuery<MemberAddressCB> unionQuery) {
            MemberAddressCB cb = new MemberAddressCB();
            cb.xsetupForUnion(this); xsyncUQ(cb); unionQuery.Invoke(cb);
		    MemberAddressCQ cq = cb.Query(); Query().xsetUnionQuery(cq);
        }

	    public virtual void UnionAll(UnionQuery<MemberAddressCB> unionQuery) {
            MemberAddressCB cb = new MemberAddressCB();
            cb.xsetupForUnion(this); xsyncUQ(cb); unionQuery.Invoke(cb);
		    MemberAddressCQ cq = cb.Query(); Query().xsetUnionAllQuery(cq);
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

        // [DBFlute-0.7.4]
        // ===============================================================================
        //                                                                         Specify
        //                                                                         =======
        protected MemberAddressCBSpecification _specification;
        public MemberAddressCBSpecification Specify() {
            if (_specification == null) { _specification = new MemberAddressCBSpecification(this, new MySpQyCall(this), _forDerivedReferrer, _forScalarSelect, _forScalarCondition, _forColumnQuery); }
            return _specification;
        }
        protected bool HasSpecifiedColumn { get {
            return _specification != null && _specification.IsAlreadySpecifiedRequiredColumn;
        }}
        protected class MySpQyCall : HpSpQyCall<MemberAddressCQ> {
			protected BsMemberAddressCB _myCB;
			public MySpQyCall(BsMemberAddressCB myCB) { _myCB = myCB; }
    		public bool has() { return true; } public MemberAddressCQ qy() { return _myCB.Query(); }
    	}

        // [DBFlute-0.8.9.18]
        // ===============================================================================
        //                                                                     ColumnQuery
        //                                                                     ===========
        public HpColQyOperand<MemberAddressCB> ColumnQuery(SpecifyQuery<MemberAddressCB> leftSpecifyQuery) {
            return new HpColQyOperand<MemberAddressCB>(delegate(SpecifyQuery<MemberAddressCB> rightSp, String operand) {
                xcolqy(xcreateColumnQueryCB(), xcreateColumnQueryCB(), leftSpecifyQuery, rightSp, operand);
            });
        }

        protected MemberAddressCB xcreateColumnQueryCB() {
            MemberAddressCB cb = new MemberAddressCB();
            cb.xsetupForColumnQuery((MemberAddressCB)this);
            return cb;
        }

        // [DBFlute-0.8.9.9]
        // ===============================================================================
        //                                                                    OrScopeQuery
        //                                                                    ============
        public void OrScopeQuery(OrQuery<MemberAddressCB> orQuery) {
            xorQ((MemberAddressCB)this, orQuery);
        }

        // ===============================================================================
        //                                                                    Purpose Type
        //                                                                    ============
        public void xsetupForColumnQuery(MemberAddressCB mainCB) {
            xinheritSubQueryInfo(mainCB.LocalCQ);
            //xchangePurposeSqlClause(HpCBPurpose.COLUMN_QUERY);
            _forColumnQuery = true; // old style

            // inherits a parent query to synchronize real name
            // (and also for suppressing query check) 
            Specify().xsetSyncQyCall(new MemberAddressCBColQySpQyCall(mainCB));
        }
    }

    public class MemberAddressCBColQySpQyCall : HpSpQyCall<MemberAddressCQ> {
        protected MemberAddressCB _mainCB;
        public MemberAddressCBColQySpQyCall(MemberAddressCB mainCB) {
            _mainCB = mainCB;
        }
        public bool has() { return true; } 
        public MemberAddressCQ qy() { return _mainCB.Query(); } 
    }

    public class MemberAddressCBSpecification : AbstractSpecification<MemberAddressCQ> {
        protected MemberCBSpecification _member;
        public MemberAddressCBSpecification(ConditionBean baseCB, HpSpQyCall<MemberAddressCQ> qyCall
                                                      , bool forDerivedReferrer, bool forScalarSelect, bool forScalarSubQuery, bool forColumnQuery)
        : base(baseCB, qyCall, forDerivedReferrer, forScalarSelect, forScalarSubQuery, forColumnQuery) { }
        public void ColumnMemberAddressId() { doColumn("MEMBER_ADDRESS_ID"); }
        public void ColumnMemberId() { doColumn("MEMBER_ID"); }
        public void ColumnValidBeginDate() { doColumn("VALID_BEGIN_DATE"); }
        public void ColumnValidEndDate() { doColumn("VALID_END_DATE"); }
        public void ColumnAddress() { doColumn("ADDRESS"); }
        public void ColumnRegisterDatetime() { doColumn("REGISTER_DATETIME"); }
        public void ColumnRegisterProcess() { doColumn("REGISTER_PROCESS"); }
        public void ColumnRegisterUser() { doColumn("REGISTER_USER"); }
        public void ColumnUpdateDatetime() { doColumn("UPDATE_DATETIME"); }
        public void ColumnUpdateProcess() { doColumn("UPDATE_PROCESS"); }
        public void ColumnUpdateUser() { doColumn("UPDATE_USER"); }
        public void ColumnVersionNo() { doColumn("VERSION_NO"); }
        protected override void doSpecifyRequiredColumn() {
            ColumnMemberAddressId(); // PK
            if (qyCall().qy().hasConditionQueryMember()
                    || qyCall().qy().xgetReferrerQuery() is MemberCQ) {
                ColumnMemberId(); // FK or one-to-one referrer
            }
        }
        protected override String getTableDbName() { return "member_address"; }
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
		    protected HpSpQyCall<MemberAddressCQ> _qyCall;
		    public MemberSpQyCall(HpSpQyCall<MemberAddressCQ> myQyCall) { _qyCall = myQyCall; }
		    public bool has() { return _qyCall.has() && _qyCall.qy().hasConditionQueryMember(); }
			public MemberCQ qy() { return _qyCall.qy().QueryMember(); }
		}
    }
}
