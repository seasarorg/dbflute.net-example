
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
    public class LdBsGenreCB : LdAbstractConditionBean {

        // ===============================================================================
        //                                                                       Attribute
        //                                                                       =========
        protected LdGenreCQ _conditionQuery;

        // ===============================================================================
        //                                                                      Table Name
        //                                                                      ==========
        public override String TableDbName { get { return "genre"; } }

        // ===============================================================================
        //                                                             PrimaryKey Handling
        //                                                             ===================
        public void AcceptPrimaryKey(String genreCode) {
            assertObjectNotNull("genreCode", genreCode);
            LdBsGenreCB cb = this;
            cb.Query().SetGenreCode_Equal(genreCode);
        }

        public override LdConditionBean AddOrderBy_PK_Asc() {
            Query().AddOrderBy_GenreCode_Asc();
            return this;
        }

        public override LdConditionBean AddOrderBy_PK_Desc() {
            Query().AddOrderBy_GenreCode_Desc();
            return this;
        }

        // ===============================================================================
        //                                                                           Query
        //                                                                           =====
        public LdGenreCQ Query() {
            return this.ConditionQuery;
        }

        public LdGenreCQ ConditionQuery {
            get {
                if (_conditionQuery == null) {
                    _conditionQuery = CreateLocalCQ();
                }
                return _conditionQuery;
            }
        }

        protected virtual LdGenreCQ CreateLocalCQ() {
            return xcreateCQ(null, this.SqlClause, this.SqlClause.getBasePointAliasName(), 0);
        }

        protected virtual LdGenreCQ xcreateCQ(LdConditionQuery childQuery, LdSqlClause sqlClause, String aliasName, int nestLevel) {
            return new LdGenreCQ(childQuery, sqlClause, aliasName, nestLevel);
        }

        public override LdConditionQuery LocalCQ {
            get { return this.ConditionQuery; }
        }

        // ===============================================================================
        //                                                                           Union
        //                                                                           =====
	    public virtual void Union(LdUnionQuery<LdGenreCB> unionQuery) {
            LdGenreCB cb = new LdGenreCB();
            cb.xsetupForUnion(this); xsyncUQ(cb); unionQuery.Invoke(cb);
		    LdGenreCQ cq = cb.Query(); Query().xsetUnionQuery(cq);
        }

	    public virtual void UnionAll(LdUnionQuery<LdGenreCB> unionQuery) {
            LdGenreCB cb = new LdGenreCB();
            cb.xsetupForUnion(this); xsyncUQ(cb); unionQuery.Invoke(cb);
		    LdGenreCQ cq = cb.Query(); Query().xsetUnionAllQuery(cq);
	    }

        public override bool HasUnionQueryOrUnionAllQuery() {
            return Query().hasUnionQueryOrUnionAllQuery();
        }

        // ===============================================================================
        //                                                                    Setup Select
        //                                                                    ============
        protected LdGenreNss _nssGenreSelf;
        public LdGenreNss NssGenreSelf { get {
            if (_nssGenreSelf == null) { _nssGenreSelf = new LdGenreNss(null); }
            return _nssGenreSelf;
        }}
        public LdGenreNss SetupSelect_GenreSelf() {
            if (HasSpecifiedColumn) { // if reverse call
                Specify().ColumnParentGenreCode();
            }
            doSetupSelect(delegate { return Query().QueryGenreSelf(); });
            if (_nssGenreSelf == null || !_nssGenreSelf.HasConditionQuery)
            { _nssGenreSelf = new LdGenreNss(Query().QueryGenreSelf()); }
            return _nssGenreSelf;
        }

        // [DBFlute-0.7.4]
        // ===============================================================================
        //                                                                         Specify
        //                                                                         =======
        protected LdGenreCBSpecification _specification;
        public LdGenreCBSpecification Specify() {
            if (_specification == null) { _specification = new LdGenreCBSpecification(this, new MySpQyCall(this), _forDerivedReferrer, _forScalarSelect, _forScalarCondition, _forColumnQuery); }
            return _specification;
        }
        protected bool HasSpecifiedColumn { get {
            return _specification != null && _specification.IsAlreadySpecifiedRequiredColumn;
        }}
        protected class MySpQyCall : HpSpQyCall<LdGenreCQ> {
			protected LdBsGenreCB _myCB;
			public MySpQyCall(LdBsGenreCB myCB) { _myCB = myCB; }
    		public bool has() { return true; } public LdGenreCQ qy() { return _myCB.Query(); }
    	}

        // [DBFlute-0.8.9.18]
        // ===============================================================================
        //                                                                     ColumnQuery
        //                                                                     ===========
        public HpColQyOperand<LdGenreCB> ColumnQuery(LdSpecifyQuery<LdGenreCB> leftSpecifyQuery) {
            return new HpColQyOperand<LdGenreCB>(delegate(LdSpecifyQuery<LdGenreCB> rightSp, String operand) {
                xcolqy(xcreateColumnQueryCB(), xcreateColumnQueryCB(), leftSpecifyQuery, rightSp, operand);
            });
        }

        protected LdGenreCB xcreateColumnQueryCB() {
            LdGenreCB cb = new LdGenreCB();
            cb.xsetupForColumnQuery((LdGenreCB)this);
            return cb;
        }

        // [DBFlute-0.8.9.9]
        // ===============================================================================
        //                                                                    OrScopeQuery
        //                                                                    ============
        public void OrScopeQuery(LdOrQuery<LdGenreCB> orQuery) {
            xorQ((LdGenreCB)this, orQuery);
        }

        // ===============================================================================
        //                                                                    Purpose Type
        //                                                                    ============
        public void xsetupForColumnQuery(LdGenreCB mainCB) {
            xinheritSubQueryInfo(mainCB.LocalCQ);
            //xchangePurposeSqlClause(HpCBPurpose.COLUMN_QUERY);
            _forColumnQuery = true; // old style

            // inherits a parent query to synchronize real name
            // (and also for suppressing query check) 
            Specify().xsetSyncQyCall(new LdGenreCBColQySpQyCall(mainCB));
        }
    }

    public class LdGenreCBColQySpQyCall : HpSpQyCall<LdGenreCQ> {
        protected LdGenreCB _mainCB;
        public LdGenreCBColQySpQyCall(LdGenreCB mainCB) {
            _mainCB = mainCB;
        }
        public bool has() { return true; } 
        public LdGenreCQ qy() { return _mainCB.Query(); } 
    }

    public class LdGenreCBSpecification : AbstractSpecification<LdGenreCQ> {
        protected LdGenreCBSpecification _genreSelf;
        public LdGenreCBSpecification(LdConditionBean baseCB, HpSpQyCall<LdGenreCQ> qyCall
                                                      , bool forDerivedReferrer, bool forScalarSelect, bool forScalarSubQuery, bool forColumnQuery)
        : base(baseCB, qyCall, forDerivedReferrer, forScalarSelect, forScalarSubQuery, forColumnQuery) { }
        public void ColumnGenreCode() { doColumn("GENRE_CODE"); }
        public void ColumnGenreName() { doColumn("GENRE_NAME"); }
        public void ColumnHierarchyLevel() { doColumn("HIERARCHY_LEVEL"); }
        public void ColumnHierarchyOrder() { doColumn("HIERARCHY_ORDER"); }
        public void ColumnParentGenreCode() { doColumn("PARENT_GENRE_CODE"); }
        public void ColumnRUser() { doColumn("R_USER"); }
        public void ColumnRModule() { doColumn("R_MODULE"); }
        public void ColumnRTimestamp() { doColumn("R_TIMESTAMP"); }
        public void ColumnUUser() { doColumn("U_USER"); }
        public void ColumnUModule() { doColumn("U_MODULE"); }
        public void ColumnUTimestamp() { doColumn("U_TIMESTAMP"); }
        protected override void doSpecifyRequiredColumn() {
            ColumnGenreCode(); // PK
            if (qyCall().qy().hasConditionQueryGenreSelf()
                    || qyCall().qy().xgetReferrerQuery() is LdGenreCQ) {
                ColumnParentGenreCode(); // FK or one-to-one referrer
            }
        }
        protected override String getTableDbName() { return "genre"; }
        public LdGenreCBSpecification SpecifyGenreSelf() {
            assertForeign("genreSelf");
            if (_genreSelf == null) {
                _genreSelf = new LdGenreCBSpecification(_baseCB, new GenreSelfSpQyCall(_qyCall), _forDerivedReferrer, _forScalarSelect, _forScalarCondition, _forColumnQuery);
                if (xhasSyncQyCall()) // inherits it
                { _genreSelf.xsetSyncQyCall(new GenreSelfSpQyCall(xsyncQyCall())); }
            }
            return _genreSelf;
        }
		public class GenreSelfSpQyCall : HpSpQyCall<LdGenreCQ> {
		    protected HpSpQyCall<LdGenreCQ> _qyCall;
		    public GenreSelfSpQyCall(HpSpQyCall<LdGenreCQ> myQyCall) { _qyCall = myQyCall; }
		    public bool has() { return _qyCall.has() && _qyCall.qy().hasConditionQueryGenreSelf(); }
			public LdGenreCQ qy() { return _qyCall.qy().QueryGenreSelf(); }
		}
        public RAFunction<LdBookCB, LdGenreCQ> DerivedBookList() {
            if (xhasSyncQyCall()) { xsyncQyCall().qy(); } // for sync (for example, this in ColumnQuery)
            return new RAFunction<LdBookCB, LdGenreCQ>(_baseCB, _qyCall.qy(), delegate(String function, LdSubQuery<LdBookCB> subQuery, LdGenreCQ cq, String aliasName)
                { cq.xsderiveBookList(function, subQuery, aliasName); });
        }
        public RAFunction<LdGenreCB, LdGenreCQ> DerivedGenreSelfList() {
            if (xhasSyncQyCall()) { xsyncQyCall().qy(); } // for sync (for example, this in ColumnQuery)
            return new RAFunction<LdGenreCB, LdGenreCQ>(_baseCB, _qyCall.qy(), delegate(String function, LdSubQuery<LdGenreCB> subQuery, LdGenreCQ cq, String aliasName)
                { cq.xsderiveGenreSelfList(function, subQuery, aliasName); });
        }
    }
}
