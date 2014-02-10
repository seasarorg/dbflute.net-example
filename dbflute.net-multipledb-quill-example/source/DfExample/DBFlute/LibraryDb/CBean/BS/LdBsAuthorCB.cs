
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
    public class LdBsAuthorCB : LdAbstractConditionBean {

        // ===============================================================================
        //                                                                       Attribute
        //                                                                       =========
        protected LdAuthorCQ _conditionQuery;

        // ===============================================================================
        //                                                                      Table Name
        //                                                                      ==========
        public override String TableDbName { get { return "author"; } }

        // ===============================================================================
        //                                                             PrimaryKey Handling
        //                                                             ===================
        public void AcceptPrimaryKey(int? authorId) {
            assertObjectNotNull("authorId", authorId);
            LdBsAuthorCB cb = this;
            cb.Query().SetAuthorId_Equal(authorId);
        }

        public override LdConditionBean AddOrderBy_PK_Asc() {
            Query().AddOrderBy_AuthorId_Asc();
            return this;
        }

        public override LdConditionBean AddOrderBy_PK_Desc() {
            Query().AddOrderBy_AuthorId_Desc();
            return this;
        }

        // ===============================================================================
        //                                                                           Query
        //                                                                           =====
        public LdAuthorCQ Query() {
            return this.ConditionQuery;
        }

        public LdAuthorCQ ConditionQuery {
            get {
                if (_conditionQuery == null) {
                    _conditionQuery = CreateLocalCQ();
                }
                return _conditionQuery;
            }
        }

        protected virtual LdAuthorCQ CreateLocalCQ() {
            return xcreateCQ(null, this.SqlClause, this.SqlClause.getBasePointAliasName(), 0);
        }

        protected virtual LdAuthorCQ xcreateCQ(LdConditionQuery childQuery, LdSqlClause sqlClause, String aliasName, int nestLevel) {
            return new LdAuthorCQ(childQuery, sqlClause, aliasName, nestLevel);
        }

        public override LdConditionQuery LocalCQ {
            get { return this.ConditionQuery; }
        }

        // ===============================================================================
        //                                                                           Union
        //                                                                           =====
	    public virtual void Union(LdUnionQuery<LdAuthorCB> unionQuery) {
            LdAuthorCB cb = new LdAuthorCB();
            cb.xsetupForUnion(this); xsyncUQ(cb); unionQuery.Invoke(cb);
		    LdAuthorCQ cq = cb.Query(); Query().xsetUnionQuery(cq);
        }

	    public virtual void UnionAll(LdUnionQuery<LdAuthorCB> unionQuery) {
            LdAuthorCB cb = new LdAuthorCB();
            cb.xsetupForUnion(this); xsyncUQ(cb); unionQuery.Invoke(cb);
		    LdAuthorCQ cq = cb.Query(); Query().xsetUnionAllQuery(cq);
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
        protected LdAuthorCBSpecification _specification;
        public LdAuthorCBSpecification Specify() {
            if (_specification == null) { _specification = new LdAuthorCBSpecification(this, new MySpQyCall(this), _forDerivedReferrer, _forScalarSelect, _forScalarCondition, _forColumnQuery); }
            return _specification;
        }
        protected bool HasSpecifiedColumn { get {
            return _specification != null && _specification.IsAlreadySpecifiedRequiredColumn;
        }}
        protected class MySpQyCall : HpSpQyCall<LdAuthorCQ> {
			protected LdBsAuthorCB _myCB;
			public MySpQyCall(LdBsAuthorCB myCB) { _myCB = myCB; }
    		public bool has() { return true; } public LdAuthorCQ qy() { return _myCB.Query(); }
    	}

        // [DBFlute-0.8.9.18]
        // ===============================================================================
        //                                                                     ColumnQuery
        //                                                                     ===========
        public HpColQyOperand<LdAuthorCB> ColumnQuery(LdSpecifyQuery<LdAuthorCB> leftSpecifyQuery) {
            return new HpColQyOperand<LdAuthorCB>(delegate(LdSpecifyQuery<LdAuthorCB> rightSp, String operand) {
                xcolqy(xcreateColumnQueryCB(), xcreateColumnQueryCB(), leftSpecifyQuery, rightSp, operand);
            });
        }

        protected LdAuthorCB xcreateColumnQueryCB() {
            LdAuthorCB cb = new LdAuthorCB();
            cb.xsetupForColumnQuery((LdAuthorCB)this);
            return cb;
        }

        // [DBFlute-0.8.9.9]
        // ===============================================================================
        //                                                                    OrScopeQuery
        //                                                                    ============
        public void OrScopeQuery(LdOrQuery<LdAuthorCB> orQuery) {
            xorQ((LdAuthorCB)this, orQuery);
        }

        // ===============================================================================
        //                                                                    Purpose Type
        //                                                                    ============
        public void xsetupForColumnQuery(LdAuthorCB mainCB) {
            xinheritSubQueryInfo(mainCB.LocalCQ);
            //xchangePurposeSqlClause(HpCBPurpose.COLUMN_QUERY);
            _forColumnQuery = true; // old style

            // inherits a parent query to synchronize real name
            // (and also for suppressing query check) 
            Specify().xsetSyncQyCall(new LdAuthorCBColQySpQyCall(mainCB));
        }
    }

    public class LdAuthorCBColQySpQyCall : HpSpQyCall<LdAuthorCQ> {
        protected LdAuthorCB _mainCB;
        public LdAuthorCBColQySpQyCall(LdAuthorCB mainCB) {
            _mainCB = mainCB;
        }
        public bool has() { return true; } 
        public LdAuthorCQ qy() { return _mainCB.Query(); } 
    }

    public class LdAuthorCBSpecification : AbstractSpecification<LdAuthorCQ> {
        public LdAuthorCBSpecification(LdConditionBean baseCB, HpSpQyCall<LdAuthorCQ> qyCall
                                                      , bool forDerivedReferrer, bool forScalarSelect, bool forScalarSubQuery, bool forColumnQuery)
        : base(baseCB, qyCall, forDerivedReferrer, forScalarSelect, forScalarSubQuery, forColumnQuery) { }
        public void ColumnAuthorId() { doColumn("AUTHOR_ID"); }
        public void ColumnAuthorName() { doColumn("AUTHOR_NAME"); }
        public void ColumnAuthorAge() { doColumn("AUTHOR_AGE"); }
        public void ColumnRUser() { doColumn("R_USER"); }
        public void ColumnRModule() { doColumn("R_MODULE"); }
        public void ColumnRTimestamp() { doColumn("R_TIMESTAMP"); }
        public void ColumnUUser() { doColumn("U_USER"); }
        public void ColumnUModule() { doColumn("U_MODULE"); }
        public void ColumnUTimestamp() { doColumn("U_TIMESTAMP"); }
        protected override void doSpecifyRequiredColumn() {
            ColumnAuthorId(); // PK
        }
        protected override String getTableDbName() { return "author"; }
        public RAFunction<LdBookCB, LdAuthorCQ> DerivedBookList() {
            if (xhasSyncQyCall()) { xsyncQyCall().qy(); } // for sync (for example, this in ColumnQuery)
            return new RAFunction<LdBookCB, LdAuthorCQ>(_baseCB, _qyCall.qy(), delegate(String function, LdSubQuery<LdBookCB> subQuery, LdAuthorCQ cq, String aliasName)
                { cq.xsderiveBookList(function, subQuery, aliasName); });
        }
    }
}
