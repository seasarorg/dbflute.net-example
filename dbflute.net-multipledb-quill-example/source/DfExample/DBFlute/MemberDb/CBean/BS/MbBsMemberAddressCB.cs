
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
    public class MbBsMemberAddressCB : MbAbstractConditionBean {

        // ===============================================================================
        //                                                                       Attribute
        //                                                                       =========
        protected MbMemberAddressCQ _conditionQuery;

        // ===============================================================================
        //                                                                      Table Name
        //                                                                      ==========
        public override String TableDbName { get { return "member_address"; } }

        // ===============================================================================
        //                                                             PrimaryKey Handling
        //                                                             ===================
        public void AcceptPrimaryKey(int? memberAddressId) {
            assertObjectNotNull("memberAddressId", memberAddressId);
            MbBsMemberAddressCB cb = this;
            cb.Query().SetMemberAddressId_Equal(memberAddressId);
        }

        public override MbConditionBean AddOrderBy_PK_Asc() {
            Query().AddOrderBy_MemberAddressId_Asc();
            return this;
        }

        public override MbConditionBean AddOrderBy_PK_Desc() {
            Query().AddOrderBy_MemberAddressId_Desc();
            return this;
        }

        // ===============================================================================
        //                                                                           Query
        //                                                                           =====
        public MbMemberAddressCQ Query() {
            return this.ConditionQuery;
        }

        public MbMemberAddressCQ ConditionQuery {
            get {
                if (_conditionQuery == null) {
                    _conditionQuery = CreateLocalCQ();
                }
                return _conditionQuery;
            }
        }

        protected virtual MbMemberAddressCQ CreateLocalCQ() {
            return xcreateCQ(null, this.SqlClause, this.SqlClause.getBasePointAliasName(), 0);
        }

        protected virtual MbMemberAddressCQ xcreateCQ(MbConditionQuery childQuery, MbSqlClause sqlClause, String aliasName, int nestLevel) {
            return new MbMemberAddressCQ(childQuery, sqlClause, aliasName, nestLevel);
        }

        public override MbConditionQuery LocalCQ {
            get { return this.ConditionQuery; }
        }

        // ===============================================================================
        //                                                                           Union
        //                                                                           =====
	    public virtual void Union(MbUnionQuery<MbMemberAddressCB> unionQuery) {
            MbMemberAddressCB cb = new MbMemberAddressCB();
            cb.xsetupForUnion(this); xsyncUQ(cb); unionQuery.Invoke(cb);
		    MbMemberAddressCQ cq = cb.Query(); Query().xsetUnionQuery(cq);
        }

	    public virtual void UnionAll(MbUnionQuery<MbMemberAddressCB> unionQuery) {
            MbMemberAddressCB cb = new MbMemberAddressCB();
            cb.xsetupForUnion(this); xsyncUQ(cb); unionQuery.Invoke(cb);
		    MbMemberAddressCQ cq = cb.Query(); Query().xsetUnionAllQuery(cq);
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

        // [DBFlute-0.7.4]
        // ===============================================================================
        //                                                                         Specify
        //                                                                         =======
        protected MbMemberAddressCBSpecification _specification;
        public MbMemberAddressCBSpecification Specify() {
            if (_specification == null) { _specification = new MbMemberAddressCBSpecification(this, new MySpQyCall(this), _forDerivedReferrer, _forScalarSelect, _forScalarCondition, _forColumnQuery); }
            return _specification;
        }
        protected bool HasSpecifiedColumn { get {
            return _specification != null && _specification.IsAlreadySpecifiedRequiredColumn;
        }}
        protected class MySpQyCall : HpSpQyCall<MbMemberAddressCQ> {
			protected MbBsMemberAddressCB _myCB;
			public MySpQyCall(MbBsMemberAddressCB myCB) { _myCB = myCB; }
    		public bool has() { return true; } public MbMemberAddressCQ qy() { return _myCB.Query(); }
    	}

        // [DBFlute-0.8.9.18]
        // ===============================================================================
        //                                                                     ColumnQuery
        //                                                                     ===========
        public HpColQyOperand<MbMemberAddressCB> ColumnQuery(MbSpecifyQuery<MbMemberAddressCB> leftSpecifyQuery) {
            return new HpColQyOperand<MbMemberAddressCB>(delegate(MbSpecifyQuery<MbMemberAddressCB> rightSp, String operand) {
                xcolqy(xcreateColumnQueryCB(), xcreateColumnQueryCB(), leftSpecifyQuery, rightSp, operand);
            });
        }

        protected MbMemberAddressCB xcreateColumnQueryCB() {
            MbMemberAddressCB cb = new MbMemberAddressCB();
            cb.xsetupForColumnQuery((MbMemberAddressCB)this);
            return cb;
        }

        // [DBFlute-0.8.9.9]
        // ===============================================================================
        //                                                                    OrScopeQuery
        //                                                                    ============
        public void OrScopeQuery(MbOrQuery<MbMemberAddressCB> orQuery) {
            xorQ((MbMemberAddressCB)this, orQuery);
        }

        // ===============================================================================
        //                                                                    Purpose Type
        //                                                                    ============
        public void xsetupForColumnQuery(MbMemberAddressCB mainCB) {
            xinheritSubQueryInfo(mainCB.LocalCQ);
            //xchangePurposeSqlClause(HpCBPurpose.COLUMN_QUERY);
            _forColumnQuery = true; // old style

            // inherits a parent query to synchronize real name
            // (and also for suppressing query check) 
            Specify().xsetSyncQyCall(new MbMemberAddressCBColQySpQyCall(mainCB));
        }
    }

    public class MbMemberAddressCBColQySpQyCall : HpSpQyCall<MbMemberAddressCQ> {
        protected MbMemberAddressCB _mainCB;
        public MbMemberAddressCBColQySpQyCall(MbMemberAddressCB mainCB) {
            _mainCB = mainCB;
        }
        public bool has() { return true; } 
        public MbMemberAddressCQ qy() { return _mainCB.Query(); } 
    }

    public class MbMemberAddressCBSpecification : AbstractSpecification<MbMemberAddressCQ> {
        protected MbMemberCBSpecification _member;
        public MbMemberAddressCBSpecification(MbConditionBean baseCB, HpSpQyCall<MbMemberAddressCQ> qyCall
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
                    || qyCall().qy().xgetReferrerQuery() is MbMemberCQ) {
                ColumnMemberId(); // FK or one-to-one referrer
            }
        }
        protected override String getTableDbName() { return "member_address"; }
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
		    protected HpSpQyCall<MbMemberAddressCQ> _qyCall;
		    public MemberSpQyCall(HpSpQyCall<MbMemberAddressCQ> myQyCall) { _qyCall = myQyCall; }
		    public bool has() { return _qyCall.has() && _qyCall.qy().hasConditionQueryMember(); }
			public MbMemberCQ qy() { return _qyCall.qy().QueryMember(); }
		}
    }
}
