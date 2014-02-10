
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
    public class LdBsLibraryCB : LdAbstractConditionBean {

        // ===============================================================================
        //                                                                       Attribute
        //                                                                       =========
        protected LdLibraryCQ _conditionQuery;

        // ===============================================================================
        //                                                                      Table Name
        //                                                                      ==========
        public override String TableDbName { get { return "library"; } }

        // ===============================================================================
        //                                                             PrimaryKey Handling
        //                                                             ===================
        public void AcceptPrimaryKey(int? libraryId) {
            assertObjectNotNull("libraryId", libraryId);
            LdBsLibraryCB cb = this;
            cb.Query().SetLibraryId_Equal(libraryId);
        }

        public override LdConditionBean AddOrderBy_PK_Asc() {
            Query().AddOrderBy_LibraryId_Asc();
            return this;
        }

        public override LdConditionBean AddOrderBy_PK_Desc() {
            Query().AddOrderBy_LibraryId_Desc();
            return this;
        }

        // ===============================================================================
        //                                                                           Query
        //                                                                           =====
        public LdLibraryCQ Query() {
            return this.ConditionQuery;
        }

        public LdLibraryCQ ConditionQuery {
            get {
                if (_conditionQuery == null) {
                    _conditionQuery = CreateLocalCQ();
                }
                return _conditionQuery;
            }
        }

        protected virtual LdLibraryCQ CreateLocalCQ() {
            return xcreateCQ(null, this.SqlClause, this.SqlClause.getBasePointAliasName(), 0);
        }

        protected virtual LdLibraryCQ xcreateCQ(LdConditionQuery childQuery, LdSqlClause sqlClause, String aliasName, int nestLevel) {
            return new LdLibraryCQ(childQuery, sqlClause, aliasName, nestLevel);
        }

        public override LdConditionQuery LocalCQ {
            get { return this.ConditionQuery; }
        }

        // ===============================================================================
        //                                                                           Union
        //                                                                           =====
	    public virtual void Union(LdUnionQuery<LdLibraryCB> unionQuery) {
            LdLibraryCB cb = new LdLibraryCB();
            cb.xsetupForUnion(this); xsyncUQ(cb); unionQuery.Invoke(cb);
		    LdLibraryCQ cq = cb.Query(); Query().xsetUnionQuery(cq);
        }

	    public virtual void UnionAll(LdUnionQuery<LdLibraryCB> unionQuery) {
            LdLibraryCB cb = new LdLibraryCB();
            cb.xsetupForUnion(this); xsyncUQ(cb); unionQuery.Invoke(cb);
		    LdLibraryCQ cq = cb.Query(); Query().xsetUnionAllQuery(cq);
	    }

        public override bool HasUnionQueryOrUnionAllQuery() {
            return Query().hasUnionQueryOrUnionAllQuery();
        }

        // ===============================================================================
        //                                                                    Setup Select
        //                                                                    ============
        protected LdLibraryTypeLookupNss _nssLibraryTypeLookup;
        public LdLibraryTypeLookupNss NssLibraryTypeLookup { get {
            if (_nssLibraryTypeLookup == null) { _nssLibraryTypeLookup = new LdLibraryTypeLookupNss(null); }
            return _nssLibraryTypeLookup;
        }}
        public LdLibraryTypeLookupNss SetupSelect_LibraryTypeLookup() {
            if (HasSpecifiedColumn) { // if reverse call
                Specify().ColumnLibraryTypeCode();
            }
            doSetupSelect(delegate { return Query().QueryLibraryTypeLookup(); });
            if (_nssLibraryTypeLookup == null || !_nssLibraryTypeLookup.HasConditionQuery)
            { _nssLibraryTypeLookup = new LdLibraryTypeLookupNss(Query().QueryLibraryTypeLookup()); }
            return _nssLibraryTypeLookup;
        }

        // [DBFlute-0.7.4]
        // ===============================================================================
        //                                                                         Specify
        //                                                                         =======
        protected LdLibraryCBSpecification _specification;
        public LdLibraryCBSpecification Specify() {
            if (_specification == null) { _specification = new LdLibraryCBSpecification(this, new MySpQyCall(this), _forDerivedReferrer, _forScalarSelect, _forScalarCondition, _forColumnQuery); }
            return _specification;
        }
        protected bool HasSpecifiedColumn { get {
            return _specification != null && _specification.IsAlreadySpecifiedRequiredColumn;
        }}
        protected class MySpQyCall : HpSpQyCall<LdLibraryCQ> {
			protected LdBsLibraryCB _myCB;
			public MySpQyCall(LdBsLibraryCB myCB) { _myCB = myCB; }
    		public bool has() { return true; } public LdLibraryCQ qy() { return _myCB.Query(); }
    	}

        // [DBFlute-0.8.9.18]
        // ===============================================================================
        //                                                                     ColumnQuery
        //                                                                     ===========
        public HpColQyOperand<LdLibraryCB> ColumnQuery(LdSpecifyQuery<LdLibraryCB> leftSpecifyQuery) {
            return new HpColQyOperand<LdLibraryCB>(delegate(LdSpecifyQuery<LdLibraryCB> rightSp, String operand) {
                xcolqy(xcreateColumnQueryCB(), xcreateColumnQueryCB(), leftSpecifyQuery, rightSp, operand);
            });
        }

        protected LdLibraryCB xcreateColumnQueryCB() {
            LdLibraryCB cb = new LdLibraryCB();
            cb.xsetupForColumnQuery((LdLibraryCB)this);
            return cb;
        }

        // [DBFlute-0.8.9.9]
        // ===============================================================================
        //                                                                    OrScopeQuery
        //                                                                    ============
        public void OrScopeQuery(LdOrQuery<LdLibraryCB> orQuery) {
            xorQ((LdLibraryCB)this, orQuery);
        }

        // ===============================================================================
        //                                                                    Purpose Type
        //                                                                    ============
        public void xsetupForColumnQuery(LdLibraryCB mainCB) {
            xinheritSubQueryInfo(mainCB.LocalCQ);
            //xchangePurposeSqlClause(HpCBPurpose.COLUMN_QUERY);
            _forColumnQuery = true; // old style

            // inherits a parent query to synchronize real name
            // (and also for suppressing query check) 
            Specify().xsetSyncQyCall(new LdLibraryCBColQySpQyCall(mainCB));
        }
    }

    public class LdLibraryCBColQySpQyCall : HpSpQyCall<LdLibraryCQ> {
        protected LdLibraryCB _mainCB;
        public LdLibraryCBColQySpQyCall(LdLibraryCB mainCB) {
            _mainCB = mainCB;
        }
        public bool has() { return true; } 
        public LdLibraryCQ qy() { return _mainCB.Query(); } 
    }

    public class LdLibraryCBSpecification : AbstractSpecification<LdLibraryCQ> {
        protected LdLibraryTypeLookupCBSpecification _libraryTypeLookup;
        public LdLibraryCBSpecification(LdConditionBean baseCB, HpSpQyCall<LdLibraryCQ> qyCall
                                                      , bool forDerivedReferrer, bool forScalarSelect, bool forScalarSubQuery, bool forColumnQuery)
        : base(baseCB, qyCall, forDerivedReferrer, forScalarSelect, forScalarSubQuery, forColumnQuery) { }
        public void ColumnLibraryId() { doColumn("LIBRARY_ID"); }
        public void ColumnLibraryName() { doColumn("LIBRARY_NAME"); }
        public void ColumnLibraryTypeCode() { doColumn("LIBRARY_TYPE_CODE"); }
        public void ColumnRUser() { doColumn("R_USER"); }
        public void ColumnRModule() { doColumn("R_MODULE"); }
        public void ColumnRTimestamp() { doColumn("R_TIMESTAMP"); }
        public void ColumnUUser() { doColumn("U_USER"); }
        public void ColumnUModule() { doColumn("U_MODULE"); }
        public void ColumnUTimestamp() { doColumn("U_TIMESTAMP"); }
        protected override void doSpecifyRequiredColumn() {
            ColumnLibraryId(); // PK
            if (qyCall().qy().hasConditionQueryLibraryTypeLookup()
                    || qyCall().qy().xgetReferrerQuery() is LdLibraryTypeLookupCQ) {
                ColumnLibraryTypeCode(); // FK or one-to-one referrer
            }
        }
        protected override String getTableDbName() { return "library"; }
        public LdLibraryTypeLookupCBSpecification SpecifyLibraryTypeLookup() {
            assertForeign("libraryTypeLookup");
            if (_libraryTypeLookup == null) {
                _libraryTypeLookup = new LdLibraryTypeLookupCBSpecification(_baseCB, new LibraryTypeLookupSpQyCall(_qyCall), _forDerivedReferrer, _forScalarSelect, _forScalarCondition, _forColumnQuery);
                if (xhasSyncQyCall()) // inherits it
                { _libraryTypeLookup.xsetSyncQyCall(new LibraryTypeLookupSpQyCall(xsyncQyCall())); }
            }
            return _libraryTypeLookup;
        }
		public class LibraryTypeLookupSpQyCall : HpSpQyCall<LdLibraryTypeLookupCQ> {
		    protected HpSpQyCall<LdLibraryCQ> _qyCall;
		    public LibraryTypeLookupSpQyCall(HpSpQyCall<LdLibraryCQ> myQyCall) { _qyCall = myQyCall; }
		    public bool has() { return _qyCall.has() && _qyCall.qy().hasConditionQueryLibraryTypeLookup(); }
			public LdLibraryTypeLookupCQ qy() { return _qyCall.qy().QueryLibraryTypeLookup(); }
		}
        public RAFunction<LdCollectionCB, LdLibraryCQ> DerivedCollectionList() {
            if (xhasSyncQyCall()) { xsyncQyCall().qy(); } // for sync (for example, this in ColumnQuery)
            return new RAFunction<LdCollectionCB, LdLibraryCQ>(_baseCB, _qyCall.qy(), delegate(String function, LdSubQuery<LdCollectionCB> subQuery, LdLibraryCQ cq, String aliasName)
                { cq.xsderiveCollectionList(function, subQuery, aliasName); });
        }
        public RAFunction<LdLibraryUserCB, LdLibraryCQ> DerivedLibraryUserList() {
            if (xhasSyncQyCall()) { xsyncQyCall().qy(); } // for sync (for example, this in ColumnQuery)
            return new RAFunction<LdLibraryUserCB, LdLibraryCQ>(_baseCB, _qyCall.qy(), delegate(String function, LdSubQuery<LdLibraryUserCB> subQuery, LdLibraryCQ cq, String aliasName)
                { cq.xsderiveLibraryUserList(function, subQuery, aliasName); });
        }
        public RAFunction<LdNextLibraryCB, LdLibraryCQ> DerivedNextLibraryByLibraryIdList() {
            if (xhasSyncQyCall()) { xsyncQyCall().qy(); } // for sync (for example, this in ColumnQuery)
            return new RAFunction<LdNextLibraryCB, LdLibraryCQ>(_baseCB, _qyCall.qy(), delegate(String function, LdSubQuery<LdNextLibraryCB> subQuery, LdLibraryCQ cq, String aliasName)
                { cq.xsderiveNextLibraryByLibraryIdList(function, subQuery, aliasName); });
        }
        public RAFunction<LdNextLibraryCB, LdLibraryCQ> DerivedNextLibraryByNextLibraryIdList() {
            if (xhasSyncQyCall()) { xsyncQyCall().qy(); } // for sync (for example, this in ColumnQuery)
            return new RAFunction<LdNextLibraryCB, LdLibraryCQ>(_baseCB, _qyCall.qy(), delegate(String function, LdSubQuery<LdNextLibraryCB> subQuery, LdLibraryCQ cq, String aliasName)
                { cq.xsderiveNextLibraryByNextLibraryIdList(function, subQuery, aliasName); });
        }
    }
}
