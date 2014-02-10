
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
    public class LdBsLendingCB : LdAbstractConditionBean {

        // ===============================================================================
        //                                                                       Attribute
        //                                                                       =========
        protected LdLendingCQ _conditionQuery;

        // ===============================================================================
        //                                                                      Table Name
        //                                                                      ==========
        public override String TableDbName { get { return "lending"; } }

        // ===============================================================================
        //                                                             PrimaryKey Handling
        //                                                             ===================
        public void AcceptPrimaryKey(int? libraryId, int? lbUserId, DateTime? lendingDate) {
            assertObjectNotNull("libraryId", libraryId);assertObjectNotNull("lbUserId", lbUserId);assertObjectNotNull("lendingDate", lendingDate);
            LdBsLendingCB cb = this;
            cb.Query().SetLibraryId_Equal(libraryId);cb.Query().SetLbUserId_Equal(lbUserId);cb.Query().SetLendingDate_Equal(lendingDate);
        }

        public override LdConditionBean AddOrderBy_PK_Asc() {
            Query().AddOrderBy_LibraryId_Asc();
            Query().AddOrderBy_LbUserId_Asc();
            Query().AddOrderBy_LendingDate_Asc();
            return this;
        }

        public override LdConditionBean AddOrderBy_PK_Desc() {
            Query().AddOrderBy_LibraryId_Desc();
            Query().AddOrderBy_LbUserId_Desc();
            Query().AddOrderBy_LendingDate_Desc();
            return this;
        }

        // ===============================================================================
        //                                                                           Query
        //                                                                           =====
        public LdLendingCQ Query() {
            return this.ConditionQuery;
        }

        public LdLendingCQ ConditionQuery {
            get {
                if (_conditionQuery == null) {
                    _conditionQuery = CreateLocalCQ();
                }
                return _conditionQuery;
            }
        }

        protected virtual LdLendingCQ CreateLocalCQ() {
            return xcreateCQ(null, this.SqlClause, this.SqlClause.getBasePointAliasName(), 0);
        }

        protected virtual LdLendingCQ xcreateCQ(LdConditionQuery childQuery, LdSqlClause sqlClause, String aliasName, int nestLevel) {
            return new LdLendingCQ(childQuery, sqlClause, aliasName, nestLevel);
        }

        public override LdConditionQuery LocalCQ {
            get { return this.ConditionQuery; }
        }

        // ===============================================================================
        //                                                                           Union
        //                                                                           =====
	    public virtual void Union(LdUnionQuery<LdLendingCB> unionQuery) {
            LdLendingCB cb = new LdLendingCB();
            cb.xsetupForUnion(this); xsyncUQ(cb); unionQuery.Invoke(cb);
		    LdLendingCQ cq = cb.Query(); Query().xsetUnionQuery(cq);
        }

	    public virtual void UnionAll(LdUnionQuery<LdLendingCB> unionQuery) {
            LdLendingCB cb = new LdLendingCB();
            cb.xsetupForUnion(this); xsyncUQ(cb); unionQuery.Invoke(cb);
		    LdLendingCQ cq = cb.Query(); Query().xsetUnionAllQuery(cq);
	    }

        public override bool HasUnionQueryOrUnionAllQuery() {
            return Query().hasUnionQueryOrUnionAllQuery();
        }

        // ===============================================================================
        //                                                                    Setup Select
        //                                                                    ============
        protected LdLibraryUserNss _nssLibraryUser;
        public LdLibraryUserNss NssLibraryUser { get {
            if (_nssLibraryUser == null) { _nssLibraryUser = new LdLibraryUserNss(null); }
            return _nssLibraryUser;
        }}
        public LdLibraryUserNss SetupSelect_LibraryUser() {
            doSetupSelect(delegate { return Query().QueryLibraryUser(); });
            if (_nssLibraryUser == null || !_nssLibraryUser.HasConditionQuery)
            { _nssLibraryUser = new LdLibraryUserNss(Query().QueryLibraryUser()); }
            return _nssLibraryUser;
        }

        // [DBFlute-0.7.4]
        // ===============================================================================
        //                                                                         Specify
        //                                                                         =======
        protected LdLendingCBSpecification _specification;
        public LdLendingCBSpecification Specify() {
            if (_specification == null) { _specification = new LdLendingCBSpecification(this, new MySpQyCall(this), _forDerivedReferrer, _forScalarSelect, _forScalarCondition, _forColumnQuery); }
            return _specification;
        }
        protected bool HasSpecifiedColumn { get {
            return _specification != null && _specification.IsAlreadySpecifiedRequiredColumn;
        }}
        protected class MySpQyCall : HpSpQyCall<LdLendingCQ> {
			protected LdBsLendingCB _myCB;
			public MySpQyCall(LdBsLendingCB myCB) { _myCB = myCB; }
    		public bool has() { return true; } public LdLendingCQ qy() { return _myCB.Query(); }
    	}

        // [DBFlute-0.8.9.18]
        // ===============================================================================
        //                                                                     ColumnQuery
        //                                                                     ===========
        public HpColQyOperand<LdLendingCB> ColumnQuery(LdSpecifyQuery<LdLendingCB> leftSpecifyQuery) {
            return new HpColQyOperand<LdLendingCB>(delegate(LdSpecifyQuery<LdLendingCB> rightSp, String operand) {
                xcolqy(xcreateColumnQueryCB(), xcreateColumnQueryCB(), leftSpecifyQuery, rightSp, operand);
            });
        }

        protected LdLendingCB xcreateColumnQueryCB() {
            LdLendingCB cb = new LdLendingCB();
            cb.xsetupForColumnQuery((LdLendingCB)this);
            return cb;
        }

        // [DBFlute-0.8.9.9]
        // ===============================================================================
        //                                                                    OrScopeQuery
        //                                                                    ============
        public void OrScopeQuery(LdOrQuery<LdLendingCB> orQuery) {
            xorQ((LdLendingCB)this, orQuery);
        }

        // ===============================================================================
        //                                                                    Purpose Type
        //                                                                    ============
        public void xsetupForColumnQuery(LdLendingCB mainCB) {
            xinheritSubQueryInfo(mainCB.LocalCQ);
            //xchangePurposeSqlClause(HpCBPurpose.COLUMN_QUERY);
            _forColumnQuery = true; // old style

            // inherits a parent query to synchronize real name
            // (and also for suppressing query check) 
            Specify().xsetSyncQyCall(new LdLendingCBColQySpQyCall(mainCB));
        }
    }

    public class LdLendingCBColQySpQyCall : HpSpQyCall<LdLendingCQ> {
        protected LdLendingCB _mainCB;
        public LdLendingCBColQySpQyCall(LdLendingCB mainCB) {
            _mainCB = mainCB;
        }
        public bool has() { return true; } 
        public LdLendingCQ qy() { return _mainCB.Query(); } 
    }

    public class LdLendingCBSpecification : AbstractSpecification<LdLendingCQ> {
        protected LdLibraryUserCBSpecification _libraryUser;
        public LdLendingCBSpecification(LdConditionBean baseCB, HpSpQyCall<LdLendingCQ> qyCall
                                                      , bool forDerivedReferrer, bool forScalarSelect, bool forScalarSubQuery, bool forColumnQuery)
        : base(baseCB, qyCall, forDerivedReferrer, forScalarSelect, forScalarSubQuery, forColumnQuery) { }
        public void ColumnLibraryId() { doColumn("LIBRARY_ID"); }
        public void ColumnLbUserId() { doColumn("LB_USER_ID"); }
        public void ColumnLendingDate() { doColumn("LENDING_DATE"); }
        public void ColumnRUser() { doColumn("R_USER"); }
        public void ColumnRModule() { doColumn("R_MODULE"); }
        public void ColumnRTimestamp() { doColumn("R_TIMESTAMP"); }
        public void ColumnUUser() { doColumn("U_USER"); }
        public void ColumnUModule() { doColumn("U_MODULE"); }
        public void ColumnUTimestamp() { doColumn("U_TIMESTAMP"); }
        protected override void doSpecifyRequiredColumn() {
            ColumnLibraryId(); // PK
            ColumnLbUserId(); // PK
            ColumnLendingDate(); // PK
        }
        protected override String getTableDbName() { return "lending"; }
        public LdLibraryUserCBSpecification SpecifyLibraryUser() {
            assertForeign("libraryUser");
            if (_libraryUser == null) {
                _libraryUser = new LdLibraryUserCBSpecification(_baseCB, new LibraryUserSpQyCall(_qyCall), _forDerivedReferrer, _forScalarSelect, _forScalarCondition, _forColumnQuery);
                if (xhasSyncQyCall()) // inherits it
                { _libraryUser.xsetSyncQyCall(new LibraryUserSpQyCall(xsyncQyCall())); }
            }
            return _libraryUser;
        }
		public class LibraryUserSpQyCall : HpSpQyCall<LdLibraryUserCQ> {
		    protected HpSpQyCall<LdLendingCQ> _qyCall;
		    public LibraryUserSpQyCall(HpSpQyCall<LdLendingCQ> myQyCall) { _qyCall = myQyCall; }
		    public bool has() { return _qyCall.has() && _qyCall.qy().hasConditionQueryLibraryUser(); }
			public LdLibraryUserCQ qy() { return _qyCall.qy().QueryLibraryUser(); }
		}
    }
}
