
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
    public class LdBsNextLibraryCB : LdAbstractConditionBean {

        // ===============================================================================
        //                                                                       Attribute
        //                                                                       =========
        protected LdNextLibraryCQ _conditionQuery;

        // ===============================================================================
        //                                                                      Table Name
        //                                                                      ==========
        public override String TableDbName { get { return "next_library"; } }

        // ===============================================================================
        //                                                             PrimaryKey Handling
        //                                                             ===================
        public void AcceptPrimaryKey(int? libraryId, int? nextLibraryId) {
            assertObjectNotNull("libraryId", libraryId);assertObjectNotNull("nextLibraryId", nextLibraryId);
            LdBsNextLibraryCB cb = this;
            cb.Query().SetLibraryId_Equal(libraryId);cb.Query().SetNextLibraryId_Equal(nextLibraryId);
        }

        public override LdConditionBean AddOrderBy_PK_Asc() {
            Query().AddOrderBy_LibraryId_Asc();
            Query().AddOrderBy_NextLibraryId_Asc();
            return this;
        }

        public override LdConditionBean AddOrderBy_PK_Desc() {
            Query().AddOrderBy_LibraryId_Desc();
            Query().AddOrderBy_NextLibraryId_Desc();
            return this;
        }

        // ===============================================================================
        //                                                                           Query
        //                                                                           =====
        public LdNextLibraryCQ Query() {
            return this.ConditionQuery;
        }

        public LdNextLibraryCQ ConditionQuery {
            get {
                if (_conditionQuery == null) {
                    _conditionQuery = CreateLocalCQ();
                }
                return _conditionQuery;
            }
        }

        protected virtual LdNextLibraryCQ CreateLocalCQ() {
            return xcreateCQ(null, this.SqlClause, this.SqlClause.getBasePointAliasName(), 0);
        }

        protected virtual LdNextLibraryCQ xcreateCQ(LdConditionQuery childQuery, LdSqlClause sqlClause, String aliasName, int nestLevel) {
            return new LdNextLibraryCQ(childQuery, sqlClause, aliasName, nestLevel);
        }

        public override LdConditionQuery LocalCQ {
            get { return this.ConditionQuery; }
        }

        // ===============================================================================
        //                                                                           Union
        //                                                                           =====
	    public virtual void Union(LdUnionQuery<LdNextLibraryCB> unionQuery) {
            LdNextLibraryCB cb = new LdNextLibraryCB();
            cb.xsetupForUnion(this); xsyncUQ(cb); unionQuery.Invoke(cb);
		    LdNextLibraryCQ cq = cb.Query(); Query().xsetUnionQuery(cq);
        }

	    public virtual void UnionAll(LdUnionQuery<LdNextLibraryCB> unionQuery) {
            LdNextLibraryCB cb = new LdNextLibraryCB();
            cb.xsetupForUnion(this); xsyncUQ(cb); unionQuery.Invoke(cb);
		    LdNextLibraryCQ cq = cb.Query(); Query().xsetUnionAllQuery(cq);
	    }

        public override bool HasUnionQueryOrUnionAllQuery() {
            return Query().hasUnionQueryOrUnionAllQuery();
        }

        // ===============================================================================
        //                                                                    Setup Select
        //                                                                    ============
        protected LdLibraryNss _nssLibraryByLibraryId;
        public LdLibraryNss NssLibraryByLibraryId { get {
            if (_nssLibraryByLibraryId == null) { _nssLibraryByLibraryId = new LdLibraryNss(null); }
            return _nssLibraryByLibraryId;
        }}
        public LdLibraryNss SetupSelect_LibraryByLibraryId() {
            doSetupSelect(delegate { return Query().QueryLibraryByLibraryId(); });
            if (_nssLibraryByLibraryId == null || !_nssLibraryByLibraryId.HasConditionQuery)
            { _nssLibraryByLibraryId = new LdLibraryNss(Query().QueryLibraryByLibraryId()); }
            return _nssLibraryByLibraryId;
        }
        protected LdLibraryNss _nssLibraryByNextLibraryId;
        public LdLibraryNss NssLibraryByNextLibraryId { get {
            if (_nssLibraryByNextLibraryId == null) { _nssLibraryByNextLibraryId = new LdLibraryNss(null); }
            return _nssLibraryByNextLibraryId;
        }}
        public LdLibraryNss SetupSelect_LibraryByNextLibraryId() {
            doSetupSelect(delegate { return Query().QueryLibraryByNextLibraryId(); });
            if (_nssLibraryByNextLibraryId == null || !_nssLibraryByNextLibraryId.HasConditionQuery)
            { _nssLibraryByNextLibraryId = new LdLibraryNss(Query().QueryLibraryByNextLibraryId()); }
            return _nssLibraryByNextLibraryId;
        }

        // [DBFlute-0.7.4]
        // ===============================================================================
        //                                                                         Specify
        //                                                                         =======
        protected LdNextLibraryCBSpecification _specification;
        public LdNextLibraryCBSpecification Specify() {
            if (_specification == null) { _specification = new LdNextLibraryCBSpecification(this, new MySpQyCall(this), _forDerivedReferrer, _forScalarSelect, _forScalarCondition, _forColumnQuery); }
            return _specification;
        }
        protected bool HasSpecifiedColumn { get {
            return _specification != null && _specification.IsAlreadySpecifiedRequiredColumn;
        }}
        protected class MySpQyCall : HpSpQyCall<LdNextLibraryCQ> {
			protected LdBsNextLibraryCB _myCB;
			public MySpQyCall(LdBsNextLibraryCB myCB) { _myCB = myCB; }
    		public bool has() { return true; } public LdNextLibraryCQ qy() { return _myCB.Query(); }
    	}

        // [DBFlute-0.8.9.18]
        // ===============================================================================
        //                                                                     ColumnQuery
        //                                                                     ===========
        public HpColQyOperand<LdNextLibraryCB> ColumnQuery(LdSpecifyQuery<LdNextLibraryCB> leftSpecifyQuery) {
            return new HpColQyOperand<LdNextLibraryCB>(delegate(LdSpecifyQuery<LdNextLibraryCB> rightSp, String operand) {
                xcolqy(xcreateColumnQueryCB(), xcreateColumnQueryCB(), leftSpecifyQuery, rightSp, operand);
            });
        }

        protected LdNextLibraryCB xcreateColumnQueryCB() {
            LdNextLibraryCB cb = new LdNextLibraryCB();
            cb.xsetupForColumnQuery((LdNextLibraryCB)this);
            return cb;
        }

        // [DBFlute-0.8.9.9]
        // ===============================================================================
        //                                                                    OrScopeQuery
        //                                                                    ============
        public void OrScopeQuery(LdOrQuery<LdNextLibraryCB> orQuery) {
            xorQ((LdNextLibraryCB)this, orQuery);
        }

        // ===============================================================================
        //                                                                    Purpose Type
        //                                                                    ============
        public void xsetupForColumnQuery(LdNextLibraryCB mainCB) {
            xinheritSubQueryInfo(mainCB.LocalCQ);
            //xchangePurposeSqlClause(HpCBPurpose.COLUMN_QUERY);
            _forColumnQuery = true; // old style

            // inherits a parent query to synchronize real name
            // (and also for suppressing query check) 
            Specify().xsetSyncQyCall(new LdNextLibraryCBColQySpQyCall(mainCB));
        }
    }

    public class LdNextLibraryCBColQySpQyCall : HpSpQyCall<LdNextLibraryCQ> {
        protected LdNextLibraryCB _mainCB;
        public LdNextLibraryCBColQySpQyCall(LdNextLibraryCB mainCB) {
            _mainCB = mainCB;
        }
        public bool has() { return true; } 
        public LdNextLibraryCQ qy() { return _mainCB.Query(); } 
    }

    public class LdNextLibraryCBSpecification : AbstractSpecification<LdNextLibraryCQ> {
        protected LdLibraryCBSpecification _libraryByLibraryId;
        protected LdLibraryCBSpecification _libraryByNextLibraryId;
        public LdNextLibraryCBSpecification(LdConditionBean baseCB, HpSpQyCall<LdNextLibraryCQ> qyCall
                                                      , bool forDerivedReferrer, bool forScalarSelect, bool forScalarSubQuery, bool forColumnQuery)
        : base(baseCB, qyCall, forDerivedReferrer, forScalarSelect, forScalarSubQuery, forColumnQuery) { }
        public void ColumnLibraryId() { doColumn("LIBRARY_ID"); }
        public void ColumnNextLibraryId() { doColumn("NEXT_LIBRARY_ID"); }
        public void ColumnDistanceKm() { doColumn("DISTANCE_KM"); }
        public void ColumnRUser() { doColumn("R_USER"); }
        public void ColumnRModule() { doColumn("R_MODULE"); }
        public void ColumnRTimestamp() { doColumn("R_TIMESTAMP"); }
        public void ColumnUUser() { doColumn("U_USER"); }
        public void ColumnUModule() { doColumn("U_MODULE"); }
        public void ColumnUTimestamp() { doColumn("U_TIMESTAMP"); }
        protected override void doSpecifyRequiredColumn() {
            ColumnLibraryId(); // PK
            ColumnNextLibraryId(); // PK
        }
        protected override String getTableDbName() { return "next_library"; }
        public LdLibraryCBSpecification SpecifyLibraryByLibraryId() {
            assertForeign("libraryByLibraryId");
            if (_libraryByLibraryId == null) {
                _libraryByLibraryId = new LdLibraryCBSpecification(_baseCB, new LibraryByLibraryIdSpQyCall(_qyCall), _forDerivedReferrer, _forScalarSelect, _forScalarCondition, _forColumnQuery);
                if (xhasSyncQyCall()) // inherits it
                { _libraryByLibraryId.xsetSyncQyCall(new LibraryByLibraryIdSpQyCall(xsyncQyCall())); }
            }
            return _libraryByLibraryId;
        }
		public class LibraryByLibraryIdSpQyCall : HpSpQyCall<LdLibraryCQ> {
		    protected HpSpQyCall<LdNextLibraryCQ> _qyCall;
		    public LibraryByLibraryIdSpQyCall(HpSpQyCall<LdNextLibraryCQ> myQyCall) { _qyCall = myQyCall; }
		    public bool has() { return _qyCall.has() && _qyCall.qy().hasConditionQueryLibraryByLibraryId(); }
			public LdLibraryCQ qy() { return _qyCall.qy().QueryLibraryByLibraryId(); }
		}
        public LdLibraryCBSpecification SpecifyLibraryByNextLibraryId() {
            assertForeign("libraryByNextLibraryId");
            if (_libraryByNextLibraryId == null) {
                _libraryByNextLibraryId = new LdLibraryCBSpecification(_baseCB, new LibraryByNextLibraryIdSpQyCall(_qyCall), _forDerivedReferrer, _forScalarSelect, _forScalarCondition, _forColumnQuery);
                if (xhasSyncQyCall()) // inherits it
                { _libraryByNextLibraryId.xsetSyncQyCall(new LibraryByNextLibraryIdSpQyCall(xsyncQyCall())); }
            }
            return _libraryByNextLibraryId;
        }
		public class LibraryByNextLibraryIdSpQyCall : HpSpQyCall<LdLibraryCQ> {
		    protected HpSpQyCall<LdNextLibraryCQ> _qyCall;
		    public LibraryByNextLibraryIdSpQyCall(HpSpQyCall<LdNextLibraryCQ> myQyCall) { _qyCall = myQyCall; }
		    public bool has() { return _qyCall.has() && _qyCall.qy().hasConditionQueryLibraryByNextLibraryId(); }
			public LdLibraryCQ qy() { return _qyCall.qy().QueryLibraryByNextLibraryId(); }
		}
    }
}
