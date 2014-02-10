
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
    public class LdBsLibraryUserCB : LdAbstractConditionBean {

        // ===============================================================================
        //                                                                       Attribute
        //                                                                       =========
        protected LdLibraryUserCQ _conditionQuery;

        // ===============================================================================
        //                                                                      Table Name
        //                                                                      ==========
        public override String TableDbName { get { return "library_user"; } }

        // ===============================================================================
        //                                                             PrimaryKey Handling
        //                                                             ===================
        public void AcceptPrimaryKey(int? libraryId, int? lbUserId) {
            assertObjectNotNull("libraryId", libraryId);assertObjectNotNull("lbUserId", lbUserId);
            LdBsLibraryUserCB cb = this;
            cb.Query().SetLibraryId_Equal(libraryId);cb.Query().SetLbUserId_Equal(lbUserId);
        }

        public override LdConditionBean AddOrderBy_PK_Asc() {
            Query().AddOrderBy_LibraryId_Asc();
            Query().AddOrderBy_LbUserId_Asc();
            return this;
        }

        public override LdConditionBean AddOrderBy_PK_Desc() {
            Query().AddOrderBy_LibraryId_Desc();
            Query().AddOrderBy_LbUserId_Desc();
            return this;
        }

        // ===============================================================================
        //                                                                           Query
        //                                                                           =====
        public LdLibraryUserCQ Query() {
            return this.ConditionQuery;
        }

        public LdLibraryUserCQ ConditionQuery {
            get {
                if (_conditionQuery == null) {
                    _conditionQuery = CreateLocalCQ();
                }
                return _conditionQuery;
            }
        }

        protected virtual LdLibraryUserCQ CreateLocalCQ() {
            return xcreateCQ(null, this.SqlClause, this.SqlClause.getBasePointAliasName(), 0);
        }

        protected virtual LdLibraryUserCQ xcreateCQ(LdConditionQuery childQuery, LdSqlClause sqlClause, String aliasName, int nestLevel) {
            return new LdLibraryUserCQ(childQuery, sqlClause, aliasName, nestLevel);
        }

        public override LdConditionQuery LocalCQ {
            get { return this.ConditionQuery; }
        }

        // ===============================================================================
        //                                                                           Union
        //                                                                           =====
	    public virtual void Union(LdUnionQuery<LdLibraryUserCB> unionQuery) {
            LdLibraryUserCB cb = new LdLibraryUserCB();
            cb.xsetupForUnion(this); xsyncUQ(cb); unionQuery.Invoke(cb);
		    LdLibraryUserCQ cq = cb.Query(); Query().xsetUnionQuery(cq);
        }

	    public virtual void UnionAll(LdUnionQuery<LdLibraryUserCB> unionQuery) {
            LdLibraryUserCB cb = new LdLibraryUserCB();
            cb.xsetupForUnion(this); xsyncUQ(cb); unionQuery.Invoke(cb);
		    LdLibraryUserCQ cq = cb.Query(); Query().xsetUnionAllQuery(cq);
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
            doSetupSelect(delegate { return Query().QueryLbUser(); });
            if (_nssLbUser == null || !_nssLbUser.HasConditionQuery)
            { _nssLbUser = new LdLbUserNss(Query().QueryLbUser()); }
            return _nssLbUser;
        }
        protected LdLibraryNss _nssLibrary;
        public LdLibraryNss NssLibrary { get {
            if (_nssLibrary == null) { _nssLibrary = new LdLibraryNss(null); }
            return _nssLibrary;
        }}
        public LdLibraryNss SetupSelect_Library() {
            doSetupSelect(delegate { return Query().QueryLibrary(); });
            if (_nssLibrary == null || !_nssLibrary.HasConditionQuery)
            { _nssLibrary = new LdLibraryNss(Query().QueryLibrary()); }
            return _nssLibrary;
        }

        // [DBFlute-0.7.4]
        // ===============================================================================
        //                                                                         Specify
        //                                                                         =======
        protected LdLibraryUserCBSpecification _specification;
        public LdLibraryUserCBSpecification Specify() {
            if (_specification == null) { _specification = new LdLibraryUserCBSpecification(this, new MySpQyCall(this), _forDerivedReferrer, _forScalarSelect, _forScalarCondition, _forColumnQuery); }
            return _specification;
        }
        protected bool HasSpecifiedColumn { get {
            return _specification != null && _specification.IsAlreadySpecifiedRequiredColumn;
        }}
        protected class MySpQyCall : HpSpQyCall<LdLibraryUserCQ> {
			protected LdBsLibraryUserCB _myCB;
			public MySpQyCall(LdBsLibraryUserCB myCB) { _myCB = myCB; }
    		public bool has() { return true; } public LdLibraryUserCQ qy() { return _myCB.Query(); }
    	}

        // [DBFlute-0.8.9.18]
        // ===============================================================================
        //                                                                     ColumnQuery
        //                                                                     ===========
        public HpColQyOperand<LdLibraryUserCB> ColumnQuery(LdSpecifyQuery<LdLibraryUserCB> leftSpecifyQuery) {
            return new HpColQyOperand<LdLibraryUserCB>(delegate(LdSpecifyQuery<LdLibraryUserCB> rightSp, String operand) {
                xcolqy(xcreateColumnQueryCB(), xcreateColumnQueryCB(), leftSpecifyQuery, rightSp, operand);
            });
        }

        protected LdLibraryUserCB xcreateColumnQueryCB() {
            LdLibraryUserCB cb = new LdLibraryUserCB();
            cb.xsetupForColumnQuery((LdLibraryUserCB)this);
            return cb;
        }

        // [DBFlute-0.8.9.9]
        // ===============================================================================
        //                                                                    OrScopeQuery
        //                                                                    ============
        public void OrScopeQuery(LdOrQuery<LdLibraryUserCB> orQuery) {
            xorQ((LdLibraryUserCB)this, orQuery);
        }

        // ===============================================================================
        //                                                                    Purpose Type
        //                                                                    ============
        public void xsetupForColumnQuery(LdLibraryUserCB mainCB) {
            xinheritSubQueryInfo(mainCB.LocalCQ);
            //xchangePurposeSqlClause(HpCBPurpose.COLUMN_QUERY);
            _forColumnQuery = true; // old style

            // inherits a parent query to synchronize real name
            // (and also for suppressing query check) 
            Specify().xsetSyncQyCall(new LdLibraryUserCBColQySpQyCall(mainCB));
        }
    }

    public class LdLibraryUserCBColQySpQyCall : HpSpQyCall<LdLibraryUserCQ> {
        protected LdLibraryUserCB _mainCB;
        public LdLibraryUserCBColQySpQyCall(LdLibraryUserCB mainCB) {
            _mainCB = mainCB;
        }
        public bool has() { return true; } 
        public LdLibraryUserCQ qy() { return _mainCB.Query(); } 
    }

    public class LdLibraryUserCBSpecification : AbstractSpecification<LdLibraryUserCQ> {
        protected LdLbUserCBSpecification _lbUser;
        protected LdLibraryCBSpecification _library;
        public LdLibraryUserCBSpecification(LdConditionBean baseCB, HpSpQyCall<LdLibraryUserCQ> qyCall
                                                      , bool forDerivedReferrer, bool forScalarSelect, bool forScalarSubQuery, bool forColumnQuery)
        : base(baseCB, qyCall, forDerivedReferrer, forScalarSelect, forScalarSubQuery, forColumnQuery) { }
        public void ColumnLibraryId() { doColumn("LIBRARY_ID"); }
        public void ColumnLbUserId() { doColumn("LB_USER_ID"); }
        public void ColumnRUser() { doColumn("R_USER"); }
        public void ColumnRModule() { doColumn("R_MODULE"); }
        public void ColumnRTimestamp() { doColumn("R_TIMESTAMP"); }
        public void ColumnUUser() { doColumn("U_USER"); }
        public void ColumnUModule() { doColumn("U_MODULE"); }
        public void ColumnUTimestamp() { doColumn("U_TIMESTAMP"); }
        protected override void doSpecifyRequiredColumn() {
            ColumnLibraryId(); // PK
            ColumnLbUserId(); // PK
        }
        protected override String getTableDbName() { return "library_user"; }
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
		    protected HpSpQyCall<LdLibraryUserCQ> _qyCall;
		    public LbUserSpQyCall(HpSpQyCall<LdLibraryUserCQ> myQyCall) { _qyCall = myQyCall; }
		    public bool has() { return _qyCall.has() && _qyCall.qy().hasConditionQueryLbUser(); }
			public LdLbUserCQ qy() { return _qyCall.qy().QueryLbUser(); }
		}
        public LdLibraryCBSpecification SpecifyLibrary() {
            assertForeign("library");
            if (_library == null) {
                _library = new LdLibraryCBSpecification(_baseCB, new LibrarySpQyCall(_qyCall), _forDerivedReferrer, _forScalarSelect, _forScalarCondition, _forColumnQuery);
                if (xhasSyncQyCall()) // inherits it
                { _library.xsetSyncQyCall(new LibrarySpQyCall(xsyncQyCall())); }
            }
            return _library;
        }
		public class LibrarySpQyCall : HpSpQyCall<LdLibraryCQ> {
		    protected HpSpQyCall<LdLibraryUserCQ> _qyCall;
		    public LibrarySpQyCall(HpSpQyCall<LdLibraryUserCQ> myQyCall) { _qyCall = myQyCall; }
		    public bool has() { return _qyCall.has() && _qyCall.qy().hasConditionQueryLibrary(); }
			public LdLibraryCQ qy() { return _qyCall.qy().QueryLibrary(); }
		}
    }
}
