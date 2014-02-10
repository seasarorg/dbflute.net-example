
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
    public class BsWhiteCompoundPkCB : AbstractConditionBean {

        // ===============================================================================
        //                                                                       Attribute
        //                                                                       =========
        protected WhiteCompoundPkCQ _conditionQuery;

        // ===============================================================================
        //                                                                      Table Name
        //                                                                      ==========
        public override String TableDbName { get { return "white_compound_pk"; } }

        // ===============================================================================
        //                                                             PrimaryKey Handling
        //                                                             ===================
        public void AcceptPrimaryKey(int? pkFirstId, int? pkSecondId) {
            assertObjectNotNull("pkFirstId", pkFirstId);assertObjectNotNull("pkSecondId", pkSecondId);
            BsWhiteCompoundPkCB cb = this;
            cb.Query().SetPkFirstId_Equal(pkFirstId);cb.Query().SetPkSecondId_Equal(pkSecondId);
        }

        public override ConditionBean AddOrderBy_PK_Asc() {
            Query().AddOrderBy_PkFirstId_Asc();
            Query().AddOrderBy_PkSecondId_Asc();
            return this;
        }

        public override ConditionBean AddOrderBy_PK_Desc() {
            Query().AddOrderBy_PkFirstId_Desc();
            Query().AddOrderBy_PkSecondId_Desc();
            return this;
        }

        // ===============================================================================
        //                                                                           Query
        //                                                                           =====
        public WhiteCompoundPkCQ Query() {
            return this.ConditionQuery;
        }

        public WhiteCompoundPkCQ ConditionQuery {
            get {
                if (_conditionQuery == null) {
                    _conditionQuery = CreateLocalCQ();
                }
                return _conditionQuery;
            }
        }

        protected virtual WhiteCompoundPkCQ CreateLocalCQ() {
            return xcreateCQ(null, this.SqlClause, this.SqlClause.getBasePointAliasName(), 0);
        }

        protected virtual WhiteCompoundPkCQ xcreateCQ(ConditionQuery childQuery, SqlClause sqlClause, String aliasName, int nestLevel) {
            return new WhiteCompoundPkCQ(childQuery, sqlClause, aliasName, nestLevel);
        }

        public override ConditionQuery LocalCQ {
            get { return this.ConditionQuery; }
        }

        // ===============================================================================
        //                                                                           Union
        //                                                                           =====
	    public virtual void Union(UnionQuery<WhiteCompoundPkCB> unionQuery) {
            WhiteCompoundPkCB cb = new WhiteCompoundPkCB();
            cb.xsetupForUnion(this); xsyncUQ(cb); unionQuery.Invoke(cb);
		    WhiteCompoundPkCQ cq = cb.Query(); Query().xsetUnionQuery(cq);
        }

	    public virtual void UnionAll(UnionQuery<WhiteCompoundPkCB> unionQuery) {
            WhiteCompoundPkCB cb = new WhiteCompoundPkCB();
            cb.xsetupForUnion(this); xsyncUQ(cb); unionQuery.Invoke(cb);
		    WhiteCompoundPkCQ cq = cb.Query(); Query().xsetUnionAllQuery(cq);
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
        protected WhiteCompoundPkCBSpecification _specification;
        public WhiteCompoundPkCBSpecification Specify() {
            if (_specification == null) { _specification = new WhiteCompoundPkCBSpecification(this, new MySpQyCall(this), _forDerivedReferrer, _forScalarSelect, _forScalarCondition, _forColumnQuery); }
            return _specification;
        }
        protected bool HasSpecifiedColumn { get {
            return _specification != null && _specification.IsAlreadySpecifiedRequiredColumn;
        }}
        protected class MySpQyCall : HpSpQyCall<WhiteCompoundPkCQ> {
			protected BsWhiteCompoundPkCB _myCB;
			public MySpQyCall(BsWhiteCompoundPkCB myCB) { _myCB = myCB; }
    		public bool has() { return true; } public WhiteCompoundPkCQ qy() { return _myCB.Query(); }
    	}

        // [DBFlute-0.8.9.18]
        // ===============================================================================
        //                                                                     ColumnQuery
        //                                                                     ===========
        public HpColQyOperand<WhiteCompoundPkCB> ColumnQuery(SpecifyQuery<WhiteCompoundPkCB> leftSpecifyQuery) {
            return new HpColQyOperand<WhiteCompoundPkCB>(delegate(SpecifyQuery<WhiteCompoundPkCB> rightSp, String operand) {
                xcolqy(xcreateColumnQueryCB(), xcreateColumnQueryCB(), leftSpecifyQuery, rightSp, operand);
            });
        }

        protected WhiteCompoundPkCB xcreateColumnQueryCB() {
            WhiteCompoundPkCB cb = new WhiteCompoundPkCB();
            cb.xsetupForColumnQuery((WhiteCompoundPkCB)this);
            return cb;
        }

        // [DBFlute-0.8.9.9]
        // ===============================================================================
        //                                                                    OrScopeQuery
        //                                                                    ============
        public void OrScopeQuery(OrQuery<WhiteCompoundPkCB> orQuery) {
            xorQ((WhiteCompoundPkCB)this, orQuery);
        }

        // ===============================================================================
        //                                                                    Purpose Type
        //                                                                    ============
        public void xsetupForColumnQuery(WhiteCompoundPkCB mainCB) {
            xinheritSubQueryInfo(mainCB.LocalCQ);
            //xchangePurposeSqlClause(HpCBPurpose.COLUMN_QUERY);
            _forColumnQuery = true; // old style

            // inherits a parent query to synchronize real name
            // (and also for suppressing query check) 
            Specify().xsetSyncQyCall(new WhiteCompoundPkCBColQySpQyCall(mainCB));
        }
    }

    public class WhiteCompoundPkCBColQySpQyCall : HpSpQyCall<WhiteCompoundPkCQ> {
        protected WhiteCompoundPkCB _mainCB;
        public WhiteCompoundPkCBColQySpQyCall(WhiteCompoundPkCB mainCB) {
            _mainCB = mainCB;
        }
        public bool has() { return true; } 
        public WhiteCompoundPkCQ qy() { return _mainCB.Query(); } 
    }

    public class WhiteCompoundPkCBSpecification : AbstractSpecification<WhiteCompoundPkCQ> {
        public WhiteCompoundPkCBSpecification(ConditionBean baseCB, HpSpQyCall<WhiteCompoundPkCQ> qyCall
                                                      , bool forDerivedReferrer, bool forScalarSelect, bool forScalarSubQuery, bool forColumnQuery)
        : base(baseCB, qyCall, forDerivedReferrer, forScalarSelect, forScalarSubQuery, forColumnQuery) { }
        public void ColumnPkFirstId() { doColumn("PK_FIRST_ID"); }
        public void ColumnPkSecondId() { doColumn("PK_SECOND_ID"); }
        public void ColumnPkName() { doColumn("PK_NAME"); }
        protected override void doSpecifyRequiredColumn() {
            ColumnPkFirstId(); // PK
            ColumnPkSecondId(); // PK
        }
        protected override String getTableDbName() { return "white_compound_pk"; }
    }
}
