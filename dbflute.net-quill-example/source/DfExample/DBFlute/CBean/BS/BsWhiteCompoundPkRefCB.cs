
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
    public class BsWhiteCompoundPkRefCB : AbstractConditionBean {

        // ===============================================================================
        //                                                                       Attribute
        //                                                                       =========
        protected WhiteCompoundPkRefCQ _conditionQuery;

        // ===============================================================================
        //                                                                      Table Name
        //                                                                      ==========
        public override String TableDbName { get { return "white_compound_pk_ref"; } }

        // ===============================================================================
        //                                                             PrimaryKey Handling
        //                                                             ===================
        public void AcceptPrimaryKey(int? multipleFirstId, int? multipleSecondId) {
            assertObjectNotNull("multipleFirstId", multipleFirstId);assertObjectNotNull("multipleSecondId", multipleSecondId);
            BsWhiteCompoundPkRefCB cb = this;
            cb.Query().SetMultipleFirstId_Equal(multipleFirstId);cb.Query().SetMultipleSecondId_Equal(multipleSecondId);
        }

        public override ConditionBean AddOrderBy_PK_Asc() {
            Query().AddOrderBy_MultipleFirstId_Asc();
            Query().AddOrderBy_MultipleSecondId_Asc();
            return this;
        }

        public override ConditionBean AddOrderBy_PK_Desc() {
            Query().AddOrderBy_MultipleFirstId_Desc();
            Query().AddOrderBy_MultipleSecondId_Desc();
            return this;
        }

        // ===============================================================================
        //                                                                           Query
        //                                                                           =====
        public WhiteCompoundPkRefCQ Query() {
            return this.ConditionQuery;
        }

        public WhiteCompoundPkRefCQ ConditionQuery {
            get {
                if (_conditionQuery == null) {
                    _conditionQuery = CreateLocalCQ();
                }
                return _conditionQuery;
            }
        }

        protected virtual WhiteCompoundPkRefCQ CreateLocalCQ() {
            return xcreateCQ(null, this.SqlClause, this.SqlClause.getBasePointAliasName(), 0);
        }

        protected virtual WhiteCompoundPkRefCQ xcreateCQ(ConditionQuery childQuery, SqlClause sqlClause, String aliasName, int nestLevel) {
            return new WhiteCompoundPkRefCQ(childQuery, sqlClause, aliasName, nestLevel);
        }

        public override ConditionQuery LocalCQ {
            get { return this.ConditionQuery; }
        }

        // ===============================================================================
        //                                                                           Union
        //                                                                           =====
	    public virtual void Union(UnionQuery<WhiteCompoundPkRefCB> unionQuery) {
            WhiteCompoundPkRefCB cb = new WhiteCompoundPkRefCB();
            cb.xsetupForUnion(this); xsyncUQ(cb); unionQuery.Invoke(cb);
		    WhiteCompoundPkRefCQ cq = cb.Query(); Query().xsetUnionQuery(cq);
        }

	    public virtual void UnionAll(UnionQuery<WhiteCompoundPkRefCB> unionQuery) {
            WhiteCompoundPkRefCB cb = new WhiteCompoundPkRefCB();
            cb.xsetupForUnion(this); xsyncUQ(cb); unionQuery.Invoke(cb);
		    WhiteCompoundPkRefCQ cq = cb.Query(); Query().xsetUnionAllQuery(cq);
	    }

        public override bool HasUnionQueryOrUnionAllQuery() {
            return Query().hasUnionQueryOrUnionAllQuery();
        }

        // ===============================================================================
        //                                                                    Setup Select
        //                                                                    ============
        protected WhiteCompoundPkNss _nssWhiteCompoundPk;
        public WhiteCompoundPkNss NssWhiteCompoundPk { get {
            if (_nssWhiteCompoundPk == null) { _nssWhiteCompoundPk = new WhiteCompoundPkNss(null); }
            return _nssWhiteCompoundPk;
        }}
        public WhiteCompoundPkNss SetupSelect_WhiteCompoundPk() {
            if (HasSpecifiedColumn) { // if reverse call
                Specify().ColumnRefFirstId();
                Specify().ColumnRefSecondId();
            }
            doSetupSelect(delegate { return Query().QueryWhiteCompoundPk(); });
            if (_nssWhiteCompoundPk == null || !_nssWhiteCompoundPk.HasConditionQuery)
            { _nssWhiteCompoundPk = new WhiteCompoundPkNss(Query().QueryWhiteCompoundPk()); }
            return _nssWhiteCompoundPk;
        }

        // [DBFlute-0.7.4]
        // ===============================================================================
        //                                                                         Specify
        //                                                                         =======
        protected WhiteCompoundPkRefCBSpecification _specification;
        public WhiteCompoundPkRefCBSpecification Specify() {
            if (_specification == null) { _specification = new WhiteCompoundPkRefCBSpecification(this, new MySpQyCall(this), _forDerivedReferrer, _forScalarSelect, _forScalarCondition, _forColumnQuery); }
            return _specification;
        }
        protected bool HasSpecifiedColumn { get {
            return _specification != null && _specification.IsAlreadySpecifiedRequiredColumn;
        }}
        protected class MySpQyCall : HpSpQyCall<WhiteCompoundPkRefCQ> {
			protected BsWhiteCompoundPkRefCB _myCB;
			public MySpQyCall(BsWhiteCompoundPkRefCB myCB) { _myCB = myCB; }
    		public bool has() { return true; } public WhiteCompoundPkRefCQ qy() { return _myCB.Query(); }
    	}

        // [DBFlute-0.8.9.18]
        // ===============================================================================
        //                                                                     ColumnQuery
        //                                                                     ===========
        public HpColQyOperand<WhiteCompoundPkRefCB> ColumnQuery(SpecifyQuery<WhiteCompoundPkRefCB> leftSpecifyQuery) {
            return new HpColQyOperand<WhiteCompoundPkRefCB>(delegate(SpecifyQuery<WhiteCompoundPkRefCB> rightSp, String operand) {
                xcolqy(xcreateColumnQueryCB(), xcreateColumnQueryCB(), leftSpecifyQuery, rightSp, operand);
            });
        }

        protected WhiteCompoundPkRefCB xcreateColumnQueryCB() {
            WhiteCompoundPkRefCB cb = new WhiteCompoundPkRefCB();
            cb.xsetupForColumnQuery((WhiteCompoundPkRefCB)this);
            return cb;
        }

        // [DBFlute-0.8.9.9]
        // ===============================================================================
        //                                                                    OrScopeQuery
        //                                                                    ============
        public void OrScopeQuery(OrQuery<WhiteCompoundPkRefCB> orQuery) {
            xorQ((WhiteCompoundPkRefCB)this, orQuery);
        }

        // ===============================================================================
        //                                                                    Purpose Type
        //                                                                    ============
        public void xsetupForColumnQuery(WhiteCompoundPkRefCB mainCB) {
            xinheritSubQueryInfo(mainCB.LocalCQ);
            //xchangePurposeSqlClause(HpCBPurpose.COLUMN_QUERY);
            _forColumnQuery = true; // old style

            // inherits a parent query to synchronize real name
            // (and also for suppressing query check) 
            Specify().xsetSyncQyCall(new WhiteCompoundPkRefCBColQySpQyCall(mainCB));
        }
    }

    public class WhiteCompoundPkRefCBColQySpQyCall : HpSpQyCall<WhiteCompoundPkRefCQ> {
        protected WhiteCompoundPkRefCB _mainCB;
        public WhiteCompoundPkRefCBColQySpQyCall(WhiteCompoundPkRefCB mainCB) {
            _mainCB = mainCB;
        }
        public bool has() { return true; } 
        public WhiteCompoundPkRefCQ qy() { return _mainCB.Query(); } 
    }

    public class WhiteCompoundPkRefCBSpecification : AbstractSpecification<WhiteCompoundPkRefCQ> {
        protected WhiteCompoundPkCBSpecification _whiteCompoundPk;
        public WhiteCompoundPkRefCBSpecification(ConditionBean baseCB, HpSpQyCall<WhiteCompoundPkRefCQ> qyCall
                                                      , bool forDerivedReferrer, bool forScalarSelect, bool forScalarSubQuery, bool forColumnQuery)
        : base(baseCB, qyCall, forDerivedReferrer, forScalarSelect, forScalarSubQuery, forColumnQuery) { }
        public void ColumnMultipleFirstId() { doColumn("MULTIPLE_FIRST_ID"); }
        public void ColumnMultipleSecondId() { doColumn("MULTIPLE_SECOND_ID"); }
        public void ColumnRefFirstId() { doColumn("REF_FIRST_ID"); }
        public void ColumnRefSecondId() { doColumn("REF_SECOND_ID"); }
        protected override void doSpecifyRequiredColumn() {
            ColumnMultipleFirstId(); // PK
            ColumnMultipleSecondId(); // PK
            if (qyCall().qy().hasConditionQueryWhiteCompoundPk()
                    || qyCall().qy().xgetReferrerQuery() is WhiteCompoundPkCQ) {
                ColumnRefFirstId(); // FK or one-to-one referrer
                ColumnRefSecondId(); // FK or one-to-one referrer
            }
        }
        protected override String getTableDbName() { return "white_compound_pk_ref"; }
        public WhiteCompoundPkCBSpecification SpecifyWhiteCompoundPk() {
            assertForeign("whiteCompoundPk");
            if (_whiteCompoundPk == null) {
                _whiteCompoundPk = new WhiteCompoundPkCBSpecification(_baseCB, new WhiteCompoundPkSpQyCall(_qyCall), _forDerivedReferrer, _forScalarSelect, _forScalarCondition, _forColumnQuery);
                if (xhasSyncQyCall()) // inherits it
                { _whiteCompoundPk.xsetSyncQyCall(new WhiteCompoundPkSpQyCall(xsyncQyCall())); }
            }
            return _whiteCompoundPk;
        }
		public class WhiteCompoundPkSpQyCall : HpSpQyCall<WhiteCompoundPkCQ> {
		    protected HpSpQyCall<WhiteCompoundPkRefCQ> _qyCall;
		    public WhiteCompoundPkSpQyCall(HpSpQyCall<WhiteCompoundPkRefCQ> myQyCall) { _qyCall = myQyCall; }
		    public bool has() { return _qyCall.has() && _qyCall.qy().hasConditionQueryWhiteCompoundPk(); }
			public WhiteCompoundPkCQ qy() { return _qyCall.qy().QueryWhiteCompoundPk(); }
		}
    }
}
