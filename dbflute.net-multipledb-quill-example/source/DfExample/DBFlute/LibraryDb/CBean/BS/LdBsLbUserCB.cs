
using System;
using System.Collections;

using DfExample.DBFlute.LibraryDb.AllCommon;
using DfExample.DBFlute.LibraryDb.AllCommon.CBean;
using DfExample.DBFlute.LibraryDb.AllCommon.CBean.SClause;
using DfExample.DBFlute.LibraryDb.AllCommon.Helper;

using DfExample.DBFlute.LibraryDb.CBean;
using DfExample.DBFlute.LibraryDb.CBean.CQ;
using DfExample.DBFlute.LibraryDb.CBean.Nss;

namespace DfExample.DBFlute.LibraryDb.CBean.BS {

    [System.Serializable]
    public class LdBsLbUserCB : LdAbstractConditionBean {

        // ===============================================================================
        //                                                                       Attribute
        //                                                                       =========
        protected LdLbUserCQ _conditionQuery;

        // ===============================================================================
        //                                                                      Table Name
        //                                                                      ==========
        public override String TableDbName { get { return "lb_user"; } }

        // ===============================================================================
        //                                                             PrimaryKey Handling
        //                                                             ===================
        public void AcceptPrimaryKey(int? lbUserId) {
            assertObjectNotNull("lbUserId", lbUserId);
            LdBsLbUserCB cb = this;
            cb.Query().SetLbUserId_Equal(lbUserId);
        }

        public override LdConditionBean AddOrderBy_PK_Asc() {
            Query().AddOrderBy_LbUserId_Asc();
            return this;
        }

        public override LdConditionBean AddOrderBy_PK_Desc() {
            Query().AddOrderBy_LbUserId_Desc();
            return this;
        }

        // ===============================================================================
        //                                                                           Query
        //                                                                           =====
        public LdLbUserCQ Query() {
            return this.ConditionQuery;
        }

        public LdLbUserCQ ConditionQuery {
            get {
                if (_conditionQuery == null) {
                    _conditionQuery = CreateLocalCQ();
                }
                return _conditionQuery;
            }
        }

        protected virtual LdLbUserCQ CreateLocalCQ() {
            return xcreateCQ(null, this.SqlClause, this.SqlClause.getBasePointAliasName(), 0);
        }

        protected virtual LdLbUserCQ xcreateCQ(LdConditionQuery childQuery, LdSqlClause sqlClause, String aliasName, int nestLevel) {
            return new LdLbUserCQ(childQuery, sqlClause, aliasName, nestLevel);
        }

        public override LdConditionQuery LocalCQ {
            get { return this.ConditionQuery; }
        }

        // ===============================================================================
        //                                                                           Union
        //                                                                           =====
	    public virtual void Union(LdUnionQuery<LdLbUserCB> unionQuery) {
            LdLbUserCB cb = new LdLbUserCB();
            cb.xsetupForUnion(this); xsyncUQ(cb); unionQuery.Invoke(cb);
		    LdLbUserCQ cq = cb.Query(); Query().xsetUnionQuery(cq);
        }

	    public virtual void UnionAll(LdUnionQuery<LdLbUserCB> unionQuery) {
            LdLbUserCB cb = new LdLbUserCB();
            cb.xsetupForUnion(this); xsyncUQ(cb); unionQuery.Invoke(cb);
		    LdLbUserCQ cq = cb.Query(); Query().xsetUnionAllQuery(cq);
	    }

        public override bool HasUnionQueryOrUnionAllQuery() {
            return Query().hasUnionQueryOrUnionAllQuery();
        }

        // ===============================================================================
        //                                                                    Setup Select
        //                                                                    ============

        protected LdBlackListNss _nssBlackListAsOne;
        public LdBlackListNss NssBlackListAsOne { get {
            if (_nssBlackListAsOne == null) { _nssBlackListAsOne = new LdBlackListNss(null); }
            return _nssBlackListAsOne;
        }}
        public LdBlackListNss SetupSelect_BlackListAsOne() {
            doSetupSelect(delegate { return Query().QueryBlackListAsOne(); });
            if (_nssBlackListAsOne == null || !_nssBlackListAsOne.HasConditionQuery)
            { _nssBlackListAsOne = new LdBlackListNss(Query().QueryBlackListAsOne()); }
            return _nssBlackListAsOne;
        }

        // [DBFlute-0.7.4]
        // ===============================================================================
        //                                                                         Specify
        //                                                                         =======
        protected LdLbUserCBSpecification _specification;
        public LdLbUserCBSpecification Specify() {
            if (_specification == null) { _specification = new LdLbUserCBSpecification(this, new MySpQyCall(this), _forDerivedReferrer, _forScalarSelect, _forScalarCondition, _forColumnQuery); }
            return _specification;
        }
        protected bool HasSpecifiedColumn { get {
            return _specification != null && _specification.IsAlreadySpecifiedRequiredColumn;
        }}
        protected class MySpQyCall : HpSpQyCall<LdLbUserCQ> {
			protected LdBsLbUserCB _myCB;
			public MySpQyCall(LdBsLbUserCB myCB) { _myCB = myCB; }
    		public bool has() { return true; } public LdLbUserCQ qy() { return _myCB.Query(); }
    	}

        // [DBFlute-0.8.9.18]
        // ===============================================================================
        //                                                                     ColumnQuery
        //                                                                     ===========
        public HpColQyOperand<LdLbUserCB> ColumnQuery(LdSpecifyQuery<LdLbUserCB> leftSpecifyQuery) {
            return new HpColQyOperand<LdLbUserCB>(delegate(LdSpecifyQuery<LdLbUserCB> rightSp, String operand) {
                xcolqy(xcreateColumnQueryCB(), xcreateColumnQueryCB(), leftSpecifyQuery, rightSp, operand);
            });
        }

        protected LdLbUserCB xcreateColumnQueryCB() {
            LdLbUserCB cb = new LdLbUserCB();
            cb.xsetupForColumnQuery((LdLbUserCB)this);
            return cb;
        }

        // [DBFlute-0.8.9.9]
        // ===============================================================================
        //                                                                    OrScopeQuery
        //                                                                    ============
        public void OrScopeQuery(LdOrQuery<LdLbUserCB> orQuery) {
            xorQ((LdLbUserCB)this, orQuery);
        }

        // ===============================================================================
        //                                                                    Purpose Type
        //                                                                    ============
        public void xsetupForColumnQuery(LdLbUserCB mainCB) {
            xinheritSubQueryInfo(mainCB.LocalCQ);
            //xchangePurposeSqlClause(HpCBPurpose.COLUMN_QUERY);
            _forColumnQuery = true; // old style

            // inherits a parent query to synchronize real name
            // (and also for suppressing query check) 
            Specify().xsetSyncQyCall(new LdLbUserCBColQySpQyCall(mainCB));
        }
    }

    public class LdLbUserCBColQySpQyCall : HpSpQyCall<LdLbUserCQ> {
        protected LdLbUserCB _mainCB;
        public LdLbUserCBColQySpQyCall(LdLbUserCB mainCB) {
            _mainCB = mainCB;
        }
        public bool has() { return true; } 
        public LdLbUserCQ qy() { return _mainCB.Query(); } 
    }

    public class LdLbUserCBSpecification : AbstractSpecification<LdLbUserCQ> {
        protected LdBlackListCBSpecification _blackListAsOne;
        public LdLbUserCBSpecification(LdConditionBean baseCB, HpSpQyCall<LdLbUserCQ> qyCall
                                                      , bool forDerivedReferrer, bool forScalarSelect, bool forScalarSubQuery, bool forColumnQuery)
        : base(baseCB, qyCall, forDerivedReferrer, forScalarSelect, forScalarSubQuery, forColumnQuery) { }
        public void ColumnLbUserId() { doColumn("LB_USER_ID"); }
        public void ColumnLbUserName() { doColumn("LB_USER_NAME"); }
        public void ColumnUserPassword() { doColumn("USER_PASSWORD"); }
        public void ColumnRUser() { doColumn("R_USER"); }
        public void ColumnRModule() { doColumn("R_MODULE"); }
        public void ColumnRTimestamp() { doColumn("R_TIMESTAMP"); }
        public void ColumnUUser() { doColumn("U_USER"); }
        public void ColumnUModule() { doColumn("U_MODULE"); }
        public void ColumnUTimestamp() { doColumn("U_TIMESTAMP"); }
        protected override void doSpecifyRequiredColumn() {
            ColumnLbUserId(); // PK
        }
        protected override String getTableDbName() { return "lb_user"; }
        public LdBlackListCBSpecification SpecifyBlackListAsOne() {
            assertForeign("blackListAsOne");
            if (_blackListAsOne == null) {
                _blackListAsOne = new LdBlackListCBSpecification(_baseCB, new BlackListAsOneSpQyCall(_qyCall), _forDerivedReferrer, _forScalarSelect, _forScalarCondition, _forColumnQuery);
                if (xhasSyncQyCall()) // inherits it
                { _blackListAsOne.xsetSyncQyCall(new BlackListAsOneSpQyCall(xsyncQyCall())); }
            }
            return _blackListAsOne;
        }
		public class BlackListAsOneSpQyCall : HpSpQyCall<LdBlackListCQ> {
		    protected HpSpQyCall<LdLbUserCQ> _qyCall;
		    public BlackListAsOneSpQyCall(HpSpQyCall<LdLbUserCQ> myQyCall) { _qyCall = myQyCall; }
		    public bool has() { return _qyCall.has() && _qyCall.qy().hasConditionQueryBlackListAsOne(); }
			public LdBlackListCQ qy() { return _qyCall.qy().QueryBlackListAsOne(); }
		}
        public RAFunction<LdLibraryUserCB, LdLbUserCQ> DerivedLibraryUserList() {
            if (xhasSyncQyCall()) { xsyncQyCall().qy(); } // for sync (for example, this in ColumnQuery)
            return new RAFunction<LdLibraryUserCB, LdLbUserCQ>(_baseCB, _qyCall.qy(), delegate(String function, LdSubQuery<LdLibraryUserCB> subQuery, LdLbUserCQ cq, String aliasName)
                { cq.xsderiveLibraryUserList(function, subQuery, aliasName); });
        }
    }
}
