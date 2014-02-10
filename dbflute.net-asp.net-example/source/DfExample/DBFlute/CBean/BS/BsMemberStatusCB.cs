
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
    public class BsMemberStatusCB : AbstractConditionBean {

        // ===============================================================================
        //                                                                       Attribute
        //                                                                       =========
        protected MemberStatusCQ _conditionQuery;

        // ===============================================================================
        //                                                                      Table Name
        //                                                                      ==========
        public override String TableDbName { get { return "MEMBER_STATUS"; } }

        // ===============================================================================
        //                                                             PrimaryKey Handling
        //                                                             ===================
        public void AcceptPrimaryKey(String memberStatusCode) {
            assertObjectNotNull("memberStatusCode", memberStatusCode);
            BsMemberStatusCB cb = this;
            cb.Query().SetMemberStatusCode_Equal(memberStatusCode);
        }

        public override ConditionBean AddOrderBy_PK_Asc() {
            Query().AddOrderBy_MemberStatusCode_Asc();
            return this;
        }

        public override ConditionBean AddOrderBy_PK_Desc() {
            Query().AddOrderBy_MemberStatusCode_Desc();
            return this;
        }

        // ===============================================================================
        //                                                                           Query
        //                                                                           =====
        public MemberStatusCQ Query() {
            return this.ConditionQuery;
        }

        public MemberStatusCQ ConditionQuery {
            get {
                if (_conditionQuery == null) {
                    _conditionQuery = CreateLocalCQ();
                }
                return _conditionQuery;
            }
        }

        protected virtual MemberStatusCQ CreateLocalCQ() {
            return xcreateCQ(null, this.SqlClause, this.SqlClause.getBasePointAliasName(), 0);
        }

        protected virtual MemberStatusCQ xcreateCQ(ConditionQuery childQuery, SqlClause sqlClause, String aliasName, int nestLevel) {
            return new MemberStatusCQ(childQuery, sqlClause, aliasName, nestLevel);
        }

        public override ConditionQuery LocalCQ {
            get { return this.ConditionQuery; }
        }

        // ===============================================================================
        //                                                                           Union
        //                                                                           =====
	    public virtual void Union(UnionQuery<MemberStatusCB> unionQuery) {
            MemberStatusCB cb = new MemberStatusCB();
            cb.xsetupForUnion(this); xsyncUQ(cb); unionQuery.Invoke(cb);
		    MemberStatusCQ cq = cb.Query(); Query().xsetUnionQuery(cq);
        }

	    public virtual void UnionAll(UnionQuery<MemberStatusCB> unionQuery) {
            MemberStatusCB cb = new MemberStatusCB();
            cb.xsetupForUnion(this); xsyncUQ(cb); unionQuery.Invoke(cb);
		    MemberStatusCQ cq = cb.Query(); Query().xsetUnionAllQuery(cq);
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
        protected MemberStatusCBSpecification _specification;
        public MemberStatusCBSpecification Specify() {
            if (_specification == null) { _specification = new MemberStatusCBSpecification(this, new MySpQyCall(this), _forDerivedReferrer, _forScalarSelect, _forScalarCondition, _forColumnQuery); }
            return _specification;
        }
        protected bool HasSpecifiedColumn { get {
            return _specification != null && _specification.IsAlreadySpecifiedRequiredColumn;
        }}
        protected class MySpQyCall : HpSpQyCall<MemberStatusCQ> {
			protected BsMemberStatusCB _myCB;
			public MySpQyCall(BsMemberStatusCB myCB) { _myCB = myCB; }
    		public bool has() { return true; } public MemberStatusCQ qy() { return _myCB.Query(); }
    	}

        // [DBFlute-0.8.9.18]
        // ===============================================================================
        //                                                                     ColumnQuery
        //                                                                     ===========
        public HpColQyOperand<MemberStatusCB> ColumnQuery(SpecifyQuery<MemberStatusCB> leftSpecifyQuery) {
            return new HpColQyOperand<MemberStatusCB>(delegate(SpecifyQuery<MemberStatusCB> rightSp, String operand) {
                xcolqy(xcreateColumnQueryCB(), xcreateColumnQueryCB(), leftSpecifyQuery, rightSp, operand);
            });
        }

        protected MemberStatusCB xcreateColumnQueryCB() {
            MemberStatusCB cb = new MemberStatusCB();
            cb.xsetupForColumnQuery((MemberStatusCB)this);
            return cb;
        }

        // [DBFlute-0.8.9.9]
        // ===============================================================================
        //                                                                    OrScopeQuery
        //                                                                    ============
        public void OrScopeQuery(OrQuery<MemberStatusCB> orQuery) {
            xorQ((MemberStatusCB)this, orQuery);
        }

        // ===============================================================================
        //                                                                    Purpose Type
        //                                                                    ============
        public void xsetupForColumnQuery(MemberStatusCB mainCB) {
            xinheritSubQueryInfo(mainCB.LocalCQ);
            //xchangePurposeSqlClause(HpCBPurpose.COLUMN_QUERY);
            _forColumnQuery = true; // old style

            // inherits a parent query to synchronize real name
            // (and also for suppressing query check) 
            Specify().xsetSyncQyCall(new MemberStatusCBColQySpQyCall(mainCB));
        }
    }

    public class MemberStatusCBColQySpQyCall : HpSpQyCall<MemberStatusCQ> {
        protected MemberStatusCB _mainCB;
        public MemberStatusCBColQySpQyCall(MemberStatusCB mainCB) {
            _mainCB = mainCB;
        }
        public bool has() { return true; } 
        public MemberStatusCQ qy() { return _mainCB.Query(); } 
    }

    public class MemberStatusCBSpecification : AbstractSpecification<MemberStatusCQ> {
        public MemberStatusCBSpecification(ConditionBean baseCB, HpSpQyCall<MemberStatusCQ> qyCall
                                                      , bool forDerivedReferrer, bool forScalarSelect, bool forScalarSubQuery, bool forColumnQuery)
        : base(baseCB, qyCall, forDerivedReferrer, forScalarSelect, forScalarSubQuery, forColumnQuery) { }
        public void ColumnMemberStatusCode() { doColumn("MEMBER_STATUS_CODE"); }
        public void ColumnMemberStatusName() { doColumn("MEMBER_STATUS_NAME"); }
        public void ColumnDisplayOrder() { doColumn("DISPLAY_ORDER"); }
        protected override void doSpecifyRequiredColumn() {
            ColumnMemberStatusCode(); // PK
        }
        protected override String getTableDbName() { return "MEMBER_STATUS"; }
        public RAFunction<MemberVendorSynonymCB, MemberStatusCQ> DerivedMemberVendorSynonymList() {
            if (xhasSyncQyCall()) { xsyncQyCall().qy(); } // for sync (for example, this in ColumnQuery)
            return new RAFunction<MemberVendorSynonymCB, MemberStatusCQ>(_baseCB, _qyCall.qy(), delegate(String function, SubQuery<MemberVendorSynonymCB> subQuery, MemberStatusCQ cq, String aliasName)
                { cq.xsderiveMemberVendorSynonymList(function, subQuery, aliasName); });
        }
        public RAFunction<VdSynonymMemberCB, MemberStatusCQ> DerivedVdSynonymMemberList() {
            if (xhasSyncQyCall()) { xsyncQyCall().qy(); } // for sync (for example, this in ColumnQuery)
            return new RAFunction<VdSynonymMemberCB, MemberStatusCQ>(_baseCB, _qyCall.qy(), delegate(String function, SubQuery<VdSynonymMemberCB> subQuery, MemberStatusCQ cq, String aliasName)
                { cq.xsderiveVdSynonymMemberList(function, subQuery, aliasName); });
        }
        public RAFunction<VdSynonymMemberLoginCB, MemberStatusCQ> DerivedVdSynonymMemberLoginList() {
            if (xhasSyncQyCall()) { xsyncQyCall().qy(); } // for sync (for example, this in ColumnQuery)
            return new RAFunction<VdSynonymMemberLoginCB, MemberStatusCQ>(_baseCB, _qyCall.qy(), delegate(String function, SubQuery<VdSynonymMemberLoginCB> subQuery, MemberStatusCQ cq, String aliasName)
                { cq.xsderiveVdSynonymMemberLoginList(function, subQuery, aliasName); });
        }
        public RAFunction<VendorSynonymMemberCB, MemberStatusCQ> DerivedVendorSynonymMemberList() {
            if (xhasSyncQyCall()) { xsyncQyCall().qy(); } // for sync (for example, this in ColumnQuery)
            return new RAFunction<VendorSynonymMemberCB, MemberStatusCQ>(_baseCB, _qyCall.qy(), delegate(String function, SubQuery<VendorSynonymMemberCB> subQuery, MemberStatusCQ cq, String aliasName)
                { cq.xsderiveVendorSynonymMemberList(function, subQuery, aliasName); });
        }
        public RAFunction<MemberCB, MemberStatusCQ> DerivedMemberList() {
            if (xhasSyncQyCall()) { xsyncQyCall().qy(); } // for sync (for example, this in ColumnQuery)
            return new RAFunction<MemberCB, MemberStatusCQ>(_baseCB, _qyCall.qy(), delegate(String function, SubQuery<MemberCB> subQuery, MemberStatusCQ cq, String aliasName)
                { cq.xsderiveMemberList(function, subQuery, aliasName); });
        }
        public RAFunction<MemberLoginCB, MemberStatusCQ> DerivedMemberLoginList() {
            if (xhasSyncQyCall()) { xsyncQyCall().qy(); } // for sync (for example, this in ColumnQuery)
            return new RAFunction<MemberLoginCB, MemberStatusCQ>(_baseCB, _qyCall.qy(), delegate(String function, SubQuery<MemberLoginCB> subQuery, MemberStatusCQ cq, String aliasName)
                { cq.xsderiveMemberLoginList(function, subQuery, aliasName); });
        }
    }
}
