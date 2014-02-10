
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
    public class MbBsMemberStatusCB : MbAbstractConditionBean {

        // ===============================================================================
        //                                                                       Attribute
        //                                                                       =========
        protected MbMemberStatusCQ _conditionQuery;

        // ===============================================================================
        //                                                                      Table Name
        //                                                                      ==========
        public override String TableDbName { get { return "member_status"; } }

        // ===============================================================================
        //                                                             PrimaryKey Handling
        //                                                             ===================
        public void AcceptPrimaryKey(String memberStatusCode) {
            assertObjectNotNull("memberStatusCode", memberStatusCode);
            MbBsMemberStatusCB cb = this;
            cb.Query().SetMemberStatusCode_Equal(memberStatusCode);
        }

        public override MbConditionBean AddOrderBy_PK_Asc() {
            Query().AddOrderBy_MemberStatusCode_Asc();
            return this;
        }

        public override MbConditionBean AddOrderBy_PK_Desc() {
            Query().AddOrderBy_MemberStatusCode_Desc();
            return this;
        }

        // ===============================================================================
        //                                                                           Query
        //                                                                           =====
        public MbMemberStatusCQ Query() {
            return this.ConditionQuery;
        }

        public MbMemberStatusCQ ConditionQuery {
            get {
                if (_conditionQuery == null) {
                    _conditionQuery = CreateLocalCQ();
                }
                return _conditionQuery;
            }
        }

        protected virtual MbMemberStatusCQ CreateLocalCQ() {
            return xcreateCQ(null, this.SqlClause, this.SqlClause.getBasePointAliasName(), 0);
        }

        protected virtual MbMemberStatusCQ xcreateCQ(MbConditionQuery childQuery, MbSqlClause sqlClause, String aliasName, int nestLevel) {
            return new MbMemberStatusCQ(childQuery, sqlClause, aliasName, nestLevel);
        }

        public override MbConditionQuery LocalCQ {
            get { return this.ConditionQuery; }
        }

        // ===============================================================================
        //                                                                           Union
        //                                                                           =====
	    public virtual void Union(MbUnionQuery<MbMemberStatusCB> unionQuery) {
            MbMemberStatusCB cb = new MbMemberStatusCB();
            cb.xsetupForUnion(this); xsyncUQ(cb); unionQuery.Invoke(cb);
		    MbMemberStatusCQ cq = cb.Query(); Query().xsetUnionQuery(cq);
        }

	    public virtual void UnionAll(MbUnionQuery<MbMemberStatusCB> unionQuery) {
            MbMemberStatusCB cb = new MbMemberStatusCB();
            cb.xsetupForUnion(this); xsyncUQ(cb); unionQuery.Invoke(cb);
		    MbMemberStatusCQ cq = cb.Query(); Query().xsetUnionAllQuery(cq);
	    }

        public override bool HasUnionQueryOrUnionAllQuery() {
            return Query().hasUnionQueryOrUnionAllQuery();
        }

        // ===============================================================================
        //                                                                    Setup Select
        //                                                                    ============

        // [DBFlute-0.7.4]
        // ===============================================================================
        //                                                                         Specify
        //                                                                         =======
        protected MbMemberStatusCBSpecification _specification;
        public MbMemberStatusCBSpecification Specify() {
            if (_specification == null) { _specification = new MbMemberStatusCBSpecification(this, new MySpQyCall(this), _forDerivedReferrer, _forScalarSelect, _forScalarCondition, _forColumnQuery); }
            return _specification;
        }
        protected bool HasSpecifiedColumn { get {
            return _specification != null && _specification.IsAlreadySpecifiedRequiredColumn;
        }}
        protected class MySpQyCall : HpSpQyCall<MbMemberStatusCQ> {
			protected MbBsMemberStatusCB _myCB;
			public MySpQyCall(MbBsMemberStatusCB myCB) { _myCB = myCB; }
    		public bool has() { return true; } public MbMemberStatusCQ qy() { return _myCB.Query(); }
    	}

        // [DBFlute-0.8.9.18]
        // ===============================================================================
        //                                                                     ColumnQuery
        //                                                                     ===========
        public HpColQyOperand<MbMemberStatusCB> ColumnQuery(MbSpecifyQuery<MbMemberStatusCB> leftSpecifyQuery) {
            return new HpColQyOperand<MbMemberStatusCB>(delegate(MbSpecifyQuery<MbMemberStatusCB> rightSp, String operand) {
                xcolqy(xcreateColumnQueryCB(), xcreateColumnQueryCB(), leftSpecifyQuery, rightSp, operand);
            });
        }

        protected MbMemberStatusCB xcreateColumnQueryCB() {
            MbMemberStatusCB cb = new MbMemberStatusCB();
            cb.xsetupForColumnQuery((MbMemberStatusCB)this);
            return cb;
        }

        // [DBFlute-0.8.9.9]
        // ===============================================================================
        //                                                                    OrScopeQuery
        //                                                                    ============
        public void OrScopeQuery(MbOrQuery<MbMemberStatusCB> orQuery) {
            xorQ((MbMemberStatusCB)this, orQuery);
        }

        // ===============================================================================
        //                                                                    Purpose Type
        //                                                                    ============
        public void xsetupForColumnQuery(MbMemberStatusCB mainCB) {
            xinheritSubQueryInfo(mainCB.LocalCQ);
            //xchangePurposeSqlClause(HpCBPurpose.COLUMN_QUERY);
            _forColumnQuery = true; // old style

            // inherits a parent query to synchronize real name
            // (and also for suppressing query check) 
            Specify().xsetSyncQyCall(new MbMemberStatusCBColQySpQyCall(mainCB));
        }
    }

    public class MbMemberStatusCBColQySpQyCall : HpSpQyCall<MbMemberStatusCQ> {
        protected MbMemberStatusCB _mainCB;
        public MbMemberStatusCBColQySpQyCall(MbMemberStatusCB mainCB) {
            _mainCB = mainCB;
        }
        public bool has() { return true; } 
        public MbMemberStatusCQ qy() { return _mainCB.Query(); } 
    }

    public class MbMemberStatusCBSpecification : AbstractSpecification<MbMemberStatusCQ> {
        public MbMemberStatusCBSpecification(MbConditionBean baseCB, HpSpQyCall<MbMemberStatusCQ> qyCall
                                                      , bool forDerivedReferrer, bool forScalarSelect, bool forScalarSubQuery, bool forColumnQuery)
        : base(baseCB, qyCall, forDerivedReferrer, forScalarSelect, forScalarSubQuery, forColumnQuery) { }
        public void ColumnMemberStatusCode() { doColumn("MEMBER_STATUS_CODE"); }
        public void ColumnMemberStatusName() { doColumn("MEMBER_STATUS_NAME"); }
        public void ColumnDisplayOrder() { doColumn("DISPLAY_ORDER"); }
        protected override void doSpecifyRequiredColumn() {
            ColumnMemberStatusCode(); // PK
        }
        protected override String getTableDbName() { return "member_status"; }
        public RAFunction<MbMemberCB, MbMemberStatusCQ> DerivedMemberList() {
            if (xhasSyncQyCall()) { xsyncQyCall().qy(); } // for sync (for example, this in ColumnQuery)
            return new RAFunction<MbMemberCB, MbMemberStatusCQ>(_baseCB, _qyCall.qy(), delegate(String function, MbSubQuery<MbMemberCB> subQuery, MbMemberStatusCQ cq, String aliasName)
                { cq.xsderiveMemberList(function, subQuery, aliasName); });
        }
        public RAFunction<MbMemberLoginCB, MbMemberStatusCQ> DerivedMemberLoginList() {
            if (xhasSyncQyCall()) { xsyncQyCall().qy(); } // for sync (for example, this in ColumnQuery)
            return new RAFunction<MbMemberLoginCB, MbMemberStatusCQ>(_baseCB, _qyCall.qy(), delegate(String function, MbSubQuery<MbMemberLoginCB> subQuery, MbMemberStatusCQ cq, String aliasName)
                { cq.xsderiveMemberLoginList(function, subQuery, aliasName); });
        }
    }
}
