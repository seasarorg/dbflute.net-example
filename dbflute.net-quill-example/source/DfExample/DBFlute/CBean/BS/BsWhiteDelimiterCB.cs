
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
    public class BsWhiteDelimiterCB : AbstractConditionBean {

        // ===============================================================================
        //                                                                       Attribute
        //                                                                       =========
        protected WhiteDelimiterCQ _conditionQuery;

        // ===============================================================================
        //                                                                      Table Name
        //                                                                      ==========
        public override String TableDbName { get { return "white_delimiter"; } }

        // ===============================================================================
        //                                                             PrimaryKey Handling
        //                                                             ===================
        public void AcceptPrimaryKey(long? delimiterId) {
            assertObjectNotNull("delimiterId", delimiterId);
            BsWhiteDelimiterCB cb = this;
            cb.Query().SetDelimiterId_Equal(delimiterId);
        }

        public override ConditionBean AddOrderBy_PK_Asc() {
            Query().AddOrderBy_DelimiterId_Asc();
            return this;
        }

        public override ConditionBean AddOrderBy_PK_Desc() {
            Query().AddOrderBy_DelimiterId_Desc();
            return this;
        }

        // ===============================================================================
        //                                                                           Query
        //                                                                           =====
        public WhiteDelimiterCQ Query() {
            return this.ConditionQuery;
        }

        public WhiteDelimiterCQ ConditionQuery {
            get {
                if (_conditionQuery == null) {
                    _conditionQuery = CreateLocalCQ();
                }
                return _conditionQuery;
            }
        }

        protected virtual WhiteDelimiterCQ CreateLocalCQ() {
            return xcreateCQ(null, this.SqlClause, this.SqlClause.getBasePointAliasName(), 0);
        }

        protected virtual WhiteDelimiterCQ xcreateCQ(ConditionQuery childQuery, SqlClause sqlClause, String aliasName, int nestLevel) {
            return new WhiteDelimiterCQ(childQuery, sqlClause, aliasName, nestLevel);
        }

        public override ConditionQuery LocalCQ {
            get { return this.ConditionQuery; }
        }

        // ===============================================================================
        //                                                                           Union
        //                                                                           =====
	    public virtual void Union(UnionQuery<WhiteDelimiterCB> unionQuery) {
            WhiteDelimiterCB cb = new WhiteDelimiterCB();
            cb.xsetupForUnion(this); xsyncUQ(cb); unionQuery.Invoke(cb);
		    WhiteDelimiterCQ cq = cb.Query(); Query().xsetUnionQuery(cq);
        }

	    public virtual void UnionAll(UnionQuery<WhiteDelimiterCB> unionQuery) {
            WhiteDelimiterCB cb = new WhiteDelimiterCB();
            cb.xsetupForUnion(this); xsyncUQ(cb); unionQuery.Invoke(cb);
		    WhiteDelimiterCQ cq = cb.Query(); Query().xsetUnionAllQuery(cq);
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
        protected WhiteDelimiterCBSpecification _specification;
        public WhiteDelimiterCBSpecification Specify() {
            if (_specification == null) { _specification = new WhiteDelimiterCBSpecification(this, new MySpQyCall(this), _forDerivedReferrer, _forScalarSelect, _forScalarCondition, _forColumnQuery); }
            return _specification;
        }
        protected bool HasSpecifiedColumn { get {
            return _specification != null && _specification.IsAlreadySpecifiedRequiredColumn;
        }}
        protected class MySpQyCall : HpSpQyCall<WhiteDelimiterCQ> {
			protected BsWhiteDelimiterCB _myCB;
			public MySpQyCall(BsWhiteDelimiterCB myCB) { _myCB = myCB; }
    		public bool has() { return true; } public WhiteDelimiterCQ qy() { return _myCB.Query(); }
    	}

        // [DBFlute-0.8.9.18]
        // ===============================================================================
        //                                                                     ColumnQuery
        //                                                                     ===========
        public HpColQyOperand<WhiteDelimiterCB> ColumnQuery(SpecifyQuery<WhiteDelimiterCB> leftSpecifyQuery) {
            return new HpColQyOperand<WhiteDelimiterCB>(delegate(SpecifyQuery<WhiteDelimiterCB> rightSp, String operand) {
                xcolqy(xcreateColumnQueryCB(), xcreateColumnQueryCB(), leftSpecifyQuery, rightSp, operand);
            });
        }

        protected WhiteDelimiterCB xcreateColumnQueryCB() {
            WhiteDelimiterCB cb = new WhiteDelimiterCB();
            cb.xsetupForColumnQuery((WhiteDelimiterCB)this);
            return cb;
        }

        // [DBFlute-0.8.9.9]
        // ===============================================================================
        //                                                                    OrScopeQuery
        //                                                                    ============
        public void OrScopeQuery(OrQuery<WhiteDelimiterCB> orQuery) {
            xorQ((WhiteDelimiterCB)this, orQuery);
        }

        // ===============================================================================
        //                                                                    Purpose Type
        //                                                                    ============
        public void xsetupForColumnQuery(WhiteDelimiterCB mainCB) {
            xinheritSubQueryInfo(mainCB.LocalCQ);
            //xchangePurposeSqlClause(HpCBPurpose.COLUMN_QUERY);
            _forColumnQuery = true; // old style

            // inherits a parent query to synchronize real name
            // (and also for suppressing query check) 
            Specify().xsetSyncQyCall(new WhiteDelimiterCBColQySpQyCall(mainCB));
        }
    }

    public class WhiteDelimiterCBColQySpQyCall : HpSpQyCall<WhiteDelimiterCQ> {
        protected WhiteDelimiterCB _mainCB;
        public WhiteDelimiterCBColQySpQyCall(WhiteDelimiterCB mainCB) {
            _mainCB = mainCB;
        }
        public bool has() { return true; } 
        public WhiteDelimiterCQ qy() { return _mainCB.Query(); } 
    }

    public class WhiteDelimiterCBSpecification : AbstractSpecification<WhiteDelimiterCQ> {
        public WhiteDelimiterCBSpecification(ConditionBean baseCB, HpSpQyCall<WhiteDelimiterCQ> qyCall
                                                      , bool forDerivedReferrer, bool forScalarSelect, bool forScalarSubQuery, bool forColumnQuery)
        : base(baseCB, qyCall, forDerivedReferrer, forScalarSelect, forScalarSubQuery, forColumnQuery) { }
        public void ColumnDelimiterId() { doColumn("DELIMITER_ID"); }
        public void ColumnNumberNullable() { doColumn("NUMBER_NULLABLE"); }
        public void ColumnStringConverted() { doColumn("STRING_CONVERTED"); }
        public void ColumnStringNonConverted() { doColumn("STRING_NON_CONVERTED"); }
        public void ColumnDateDefault() { doColumn("DATE_DEFAULT"); }
        protected override void doSpecifyRequiredColumn() {
            ColumnDelimiterId(); // PK
        }
        protected override String getTableDbName() { return "white_delimiter"; }
    }
}
