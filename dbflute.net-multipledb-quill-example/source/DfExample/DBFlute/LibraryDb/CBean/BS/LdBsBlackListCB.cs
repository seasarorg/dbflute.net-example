
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
    public class LdBsBlackListCB : LdAbstractConditionBean {

        // ===============================================================================
        //                                                                       Attribute
        //                                                                       =========
        protected LdBlackListCQ _conditionQuery;

        // ===============================================================================
        //                                                                      Table Name
        //                                                                      ==========
        public override String TableDbName { get { return "black_list"; } }

        // ===============================================================================
        //                                                             PrimaryKey Handling
        //                                                             ===================
        public void AcceptPrimaryKey(int? blackListId) {
            assertObjectNotNull("blackListId", blackListId);
            LdBsBlackListCB cb = this;
            cb.Query().SetBlackListId_Equal(blackListId);
        }

        public override LdConditionBean AddOrderBy_PK_Asc() {
            Query().AddOrderBy_BlackListId_Asc();
            return this;
        }

        public override LdConditionBean AddOrderBy_PK_Desc() {
            Query().AddOrderBy_BlackListId_Desc();
            return this;
        }

        // ===============================================================================
        //                                                                           Query
        //                                                                           =====
        public LdBlackListCQ Query() {
            return this.ConditionQuery;
        }

        public LdBlackListCQ ConditionQuery {
            get {
                if (_conditionQuery == null) {
                    _conditionQuery = CreateLocalCQ();
                }
                return _conditionQuery;
            }
        }

        protected virtual LdBlackListCQ CreateLocalCQ() {
            return xcreateCQ(null, this.SqlClause, this.SqlClause.getBasePointAliasName(), 0);
        }

        protected virtual LdBlackListCQ xcreateCQ(LdConditionQuery childQuery, LdSqlClause sqlClause, String aliasName, int nestLevel) {
            return new LdBlackListCQ(childQuery, sqlClause, aliasName, nestLevel);
        }

        public override LdConditionQuery LocalCQ {
            get { return this.ConditionQuery; }
        }

        // ===============================================================================
        //                                                                           Union
        //                                                                           =====
	    public virtual void Union(LdUnionQuery<LdBlackListCB> unionQuery) {
            LdBlackListCB cb = new LdBlackListCB();
            cb.xsetupForUnion(this); xsyncUQ(cb); unionQuery.Invoke(cb);
		    LdBlackListCQ cq = cb.Query(); Query().xsetUnionQuery(cq);
        }

	    public virtual void UnionAll(LdUnionQuery<LdBlackListCB> unionQuery) {
            LdBlackListCB cb = new LdBlackListCB();
            cb.xsetupForUnion(this); xsyncUQ(cb); unionQuery.Invoke(cb);
		    LdBlackListCQ cq = cb.Query(); Query().xsetUnionAllQuery(cq);
	    }

        public override bool HasUnionQueryOrUnionAllQuery() {
            return Query().hasUnionQueryOrUnionAllQuery();
        }

        // ===============================================================================
        //                                                                    Setup Select
        //                                                                    ============
        protected LdLbUserNss _nssLbUser;
        public LdLbUserNss NssLbUser { get {
            if (_nssLbUser == null) { _nssLbUser = new LdLbUserNss(null); }
            return _nssLbUser;
        }}
        public LdLbUserNss SetupSelect_LbUser() {
            if (HasSpecifiedColumn) { // if reverse call
                Specify().ColumnLbUserId();
            }
            doSetupSelect(delegate { return Query().QueryLbUser(); });
            if (_nssLbUser == null || !_nssLbUser.HasConditionQuery)
            { _nssLbUser = new LdLbUserNss(Query().QueryLbUser()); }
            return _nssLbUser;
        }

        // [DBFlute-0.7.4]
        // ===============================================================================
        //                                                                         Specify
        //                                                                         =======
        protected LdBlackListCBSpecification _specification;
        public LdBlackListCBSpecification Specify() {
            if (_specification == null) { _specification = new LdBlackListCBSpecification(this, new MySpQyCall(this), _forDerivedReferrer, _forScalarSelect, _forScalarCondition, _forColumnQuery); }
            return _specification;
        }
        protected bool HasSpecifiedColumn { get {
            return _specification != null && _specification.IsAlreadySpecifiedRequiredColumn;
        }}
        protected class MySpQyCall : HpSpQyCall<LdBlackListCQ> {
			protected LdBsBlackListCB _myCB;
			public MySpQyCall(LdBsBlackListCB myCB) { _myCB = myCB; }
    		public bool has() { return true; } public LdBlackListCQ qy() { return _myCB.Query(); }
    	}

        // [DBFlute-0.8.9.18]
        // ===============================================================================
        //                                                                     ColumnQuery
        //                                                                     ===========
        public HpColQyOperand<LdBlackListCB> ColumnQuery(LdSpecifyQuery<LdBlackListCB> leftSpecifyQuery) {
            return new HpColQyOperand<LdBlackListCB>(delegate(LdSpecifyQuery<LdBlackListCB> rightSp, String operand) {
                xcolqy(xcreateColumnQueryCB(), xcreateColumnQueryCB(), leftSpecifyQuery, rightSp, operand);
            });
        }

        protected LdBlackListCB xcreateColumnQueryCB() {
            LdBlackListCB cb = new LdBlackListCB();
            cb.xsetupForColumnQuery((LdBlackListCB)this);
            return cb;
        }

        // [DBFlute-0.8.9.9]
        // ===============================================================================
        //                                                                    OrScopeQuery
        //                                                                    ============
        public void OrScopeQuery(LdOrQuery<LdBlackListCB> orQuery) {
            xorQ((LdBlackListCB)this, orQuery);
        }

        // ===============================================================================
        //                                                                    Purpose Type
        //                                                                    ============
        public void xsetupForColumnQuery(LdBlackListCB mainCB) {
            xinheritSubQueryInfo(mainCB.LocalCQ);
            //xchangePurposeSqlClause(HpCBPurpose.COLUMN_QUERY);
            _forColumnQuery = true; // old style

            // inherits a parent query to synchronize real name
            // (and also for suppressing query check) 
            Specify().xsetSyncQyCall(new LdBlackListCBColQySpQyCall(mainCB));
        }
    }

    public class LdBlackListCBColQySpQyCall : HpSpQyCall<LdBlackListCQ> {
        protected LdBlackListCB _mainCB;
        public LdBlackListCBColQySpQyCall(LdBlackListCB mainCB) {
            _mainCB = mainCB;
        }
        public bool has() { return true; } 
        public LdBlackListCQ qy() { return _mainCB.Query(); } 
    }

    public class LdBlackListCBSpecification : AbstractSpecification<LdBlackListCQ> {
        protected LdLbUserCBSpecification _lbUser;
        public LdBlackListCBSpecification(LdConditionBean baseCB, HpSpQyCall<LdBlackListCQ> qyCall
                                                      , bool forDerivedReferrer, bool forScalarSelect, bool forScalarSubQuery, bool forColumnQuery)
        : base(baseCB, qyCall, forDerivedReferrer, forScalarSelect, forScalarSubQuery, forColumnQuery) { }
        public void ColumnBlackListId() { doColumn("BLACK_LIST_ID"); }
        public void ColumnLbUserId() { doColumn("LB_USER_ID"); }
        public void ColumnBlackRank() { doColumn("BLACK_RANK"); }
        public void ColumnRUser() { doColumn("R_USER"); }
        public void ColumnRModule() { doColumn("R_MODULE"); }
        public void ColumnRTimestamp() { doColumn("R_TIMESTAMP"); }
        public void ColumnUUser() { doColumn("U_USER"); }
        public void ColumnUModule() { doColumn("U_MODULE"); }
        public void ColumnUTimestamp() { doColumn("U_TIMESTAMP"); }
        protected override void doSpecifyRequiredColumn() {
            ColumnBlackListId(); // PK
            if (qyCall().qy().hasConditionQueryLbUser()
                    || qyCall().qy().xgetReferrerQuery() is LdLbUserCQ) {
                ColumnLbUserId(); // FK or one-to-one referrer
            }
        }
        protected override String getTableDbName() { return "black_list"; }
        public LdLbUserCBSpecification SpecifyLbUser() {
            assertForeign("lbUser");
            if (_lbUser == null) {
                _lbUser = new LdLbUserCBSpecification(_baseCB, new LbUserSpQyCall(_qyCall), _forDerivedReferrer, _forScalarSelect, _forScalarCondition, _forColumnQuery);
                if (xhasSyncQyCall()) // inherits it
                { _lbUser.xsetSyncQyCall(new LbUserSpQyCall(xsyncQyCall())); }
            }
            return _lbUser;
        }
		public class LbUserSpQyCall : HpSpQyCall<LdLbUserCQ> {
		    protected HpSpQyCall<LdBlackListCQ> _qyCall;
		    public LbUserSpQyCall(HpSpQyCall<LdBlackListCQ> myQyCall) { _qyCall = myQyCall; }
		    public bool has() { return _qyCall.has() && _qyCall.qy().hasConditionQueryLbUser(); }
			public LdLbUserCQ qy() { return _qyCall.qy().QueryLbUser(); }
		}
        public RAFunction<LdBlackActionCB, LdBlackListCQ> DerivedBlackActionList() {
            if (xhasSyncQyCall()) { xsyncQyCall().qy(); } // for sync (for example, this in ColumnQuery)
            return new RAFunction<LdBlackActionCB, LdBlackListCQ>(_baseCB, _qyCall.qy(), delegate(String function, LdSubQuery<LdBlackActionCB> subQuery, LdBlackListCQ cq, String aliasName)
                { cq.xsderiveBlackActionList(function, subQuery, aliasName); });
        }
    }
}
