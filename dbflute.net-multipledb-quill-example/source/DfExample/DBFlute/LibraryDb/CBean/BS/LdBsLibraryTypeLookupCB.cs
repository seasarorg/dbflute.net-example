
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
    public class LdBsLibraryTypeLookupCB : LdAbstractConditionBean {

        // ===============================================================================
        //                                                                       Attribute
        //                                                                       =========
        protected LdLibraryTypeLookupCQ _conditionQuery;

        // ===============================================================================
        //                                                                      Table Name
        //                                                                      ==========
        public override String TableDbName { get { return "library_type_lookup"; } }

        // ===============================================================================
        //                                                             PrimaryKey Handling
        //                                                             ===================
        public void AcceptPrimaryKey(String libraryTypeCode) {
            assertObjectNotNull("libraryTypeCode", libraryTypeCode);
            LdBsLibraryTypeLookupCB cb = this;
            cb.Query().SetLibraryTypeCode_Equal(libraryTypeCode);
        }

        public override LdConditionBean AddOrderBy_PK_Asc() {
            Query().AddOrderBy_LibraryTypeCode_Asc();
            return this;
        }

        public override LdConditionBean AddOrderBy_PK_Desc() {
            Query().AddOrderBy_LibraryTypeCode_Desc();
            return this;
        }

        // ===============================================================================
        //                                                                           Query
        //                                                                           =====
        public LdLibraryTypeLookupCQ Query() {
            return this.ConditionQuery;
        }

        public LdLibraryTypeLookupCQ ConditionQuery {
            get {
                if (_conditionQuery == null) {
                    _conditionQuery = CreateLocalCQ();
                }
                return _conditionQuery;
            }
        }

        protected virtual LdLibraryTypeLookupCQ CreateLocalCQ() {
            return xcreateCQ(null, this.SqlClause, this.SqlClause.getBasePointAliasName(), 0);
        }

        protected virtual LdLibraryTypeLookupCQ xcreateCQ(LdConditionQuery childQuery, LdSqlClause sqlClause, String aliasName, int nestLevel) {
            return new LdLibraryTypeLookupCQ(childQuery, sqlClause, aliasName, nestLevel);
        }

        public override LdConditionQuery LocalCQ {
            get { return this.ConditionQuery; }
        }

        // ===============================================================================
        //                                                                           Union
        //                                                                           =====
	    public virtual void Union(LdUnionQuery<LdLibraryTypeLookupCB> unionQuery) {
            LdLibraryTypeLookupCB cb = new LdLibraryTypeLookupCB();
            cb.xsetupForUnion(this); xsyncUQ(cb); unionQuery.Invoke(cb);
		    LdLibraryTypeLookupCQ cq = cb.Query(); Query().xsetUnionQuery(cq);
        }

	    public virtual void UnionAll(LdUnionQuery<LdLibraryTypeLookupCB> unionQuery) {
            LdLibraryTypeLookupCB cb = new LdLibraryTypeLookupCB();
            cb.xsetupForUnion(this); xsyncUQ(cb); unionQuery.Invoke(cb);
		    LdLibraryTypeLookupCQ cq = cb.Query(); Query().xsetUnionAllQuery(cq);
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
        protected LdLibraryTypeLookupCBSpecification _specification;
        public LdLibraryTypeLookupCBSpecification Specify() {
            if (_specification == null) { _specification = new LdLibraryTypeLookupCBSpecification(this, new MySpQyCall(this), _forDerivedReferrer, _forScalarSelect, _forScalarCondition, _forColumnQuery); }
            return _specification;
        }
        protected bool HasSpecifiedColumn { get {
            return _specification != null && _specification.IsAlreadySpecifiedRequiredColumn;
        }}
        protected class MySpQyCall : HpSpQyCall<LdLibraryTypeLookupCQ> {
			protected LdBsLibraryTypeLookupCB _myCB;
			public MySpQyCall(LdBsLibraryTypeLookupCB myCB) { _myCB = myCB; }
    		public bool has() { return true; } public LdLibraryTypeLookupCQ qy() { return _myCB.Query(); }
    	}

        // [DBFlute-0.8.9.18]
        // ===============================================================================
        //                                                                     ColumnQuery
        //                                                                     ===========
        public HpColQyOperand<LdLibraryTypeLookupCB> ColumnQuery(LdSpecifyQuery<LdLibraryTypeLookupCB> leftSpecifyQuery) {
            return new HpColQyOperand<LdLibraryTypeLookupCB>(delegate(LdSpecifyQuery<LdLibraryTypeLookupCB> rightSp, String operand) {
                xcolqy(xcreateColumnQueryCB(), xcreateColumnQueryCB(), leftSpecifyQuery, rightSp, operand);
            });
        }

        protected LdLibraryTypeLookupCB xcreateColumnQueryCB() {
            LdLibraryTypeLookupCB cb = new LdLibraryTypeLookupCB();
            cb.xsetupForColumnQuery((LdLibraryTypeLookupCB)this);
            return cb;
        }

        // [DBFlute-0.8.9.9]
        // ===============================================================================
        //                                                                    OrScopeQuery
        //                                                                    ============
        public void OrScopeQuery(LdOrQuery<LdLibraryTypeLookupCB> orQuery) {
            xorQ((LdLibraryTypeLookupCB)this, orQuery);
        }

        // ===============================================================================
        //                                                                    Purpose Type
        //                                                                    ============
        public void xsetupForColumnQuery(LdLibraryTypeLookupCB mainCB) {
            xinheritSubQueryInfo(mainCB.LocalCQ);
            //xchangePurposeSqlClause(HpCBPurpose.COLUMN_QUERY);
            _forColumnQuery = true; // old style

            // inherits a parent query to synchronize real name
            // (and also for suppressing query check) 
            Specify().xsetSyncQyCall(new LdLibraryTypeLookupCBColQySpQyCall(mainCB));
        }
    }

    public class LdLibraryTypeLookupCBColQySpQyCall : HpSpQyCall<LdLibraryTypeLookupCQ> {
        protected LdLibraryTypeLookupCB _mainCB;
        public LdLibraryTypeLookupCBColQySpQyCall(LdLibraryTypeLookupCB mainCB) {
            _mainCB = mainCB;
        }
        public bool has() { return true; } 
        public LdLibraryTypeLookupCQ qy() { return _mainCB.Query(); } 
    }

    public class LdLibraryTypeLookupCBSpecification : AbstractSpecification<LdLibraryTypeLookupCQ> {
        public LdLibraryTypeLookupCBSpecification(LdConditionBean baseCB, HpSpQyCall<LdLibraryTypeLookupCQ> qyCall
                                                      , bool forDerivedReferrer, bool forScalarSelect, bool forScalarSubQuery, bool forColumnQuery)
        : base(baseCB, qyCall, forDerivedReferrer, forScalarSelect, forScalarSubQuery, forColumnQuery) { }
        public void ColumnLibraryTypeCode() { doColumn("LIBRARY_TYPE_CODE"); }
        public void ColumnLibraryTypeName() { doColumn("LIBRARY_TYPE_NAME"); }
        public void ColumnRUser() { doColumn("R_USER"); }
        public void ColumnRModule() { doColumn("R_MODULE"); }
        public void ColumnRTimestamp() { doColumn("R_TIMESTAMP"); }
        public void ColumnUUser() { doColumn("U_USER"); }
        public void ColumnUModule() { doColumn("U_MODULE"); }
        public void ColumnUTimestamp() { doColumn("U_TIMESTAMP"); }
        protected override void doSpecifyRequiredColumn() {
            ColumnLibraryTypeCode(); // PK
        }
        protected override String getTableDbName() { return "library_type_lookup"; }
        public RAFunction<LdLibraryCB, LdLibraryTypeLookupCQ> DerivedLibraryList() {
            if (xhasSyncQyCall()) { xsyncQyCall().qy(); } // for sync (for example, this in ColumnQuery)
            return new RAFunction<LdLibraryCB, LdLibraryTypeLookupCQ>(_baseCB, _qyCall.qy(), delegate(String function, LdSubQuery<LdLibraryCB> subQuery, LdLibraryTypeLookupCQ cq, String aliasName)
                { cq.xsderiveLibraryList(function, subQuery, aliasName); });
        }
    }
}
