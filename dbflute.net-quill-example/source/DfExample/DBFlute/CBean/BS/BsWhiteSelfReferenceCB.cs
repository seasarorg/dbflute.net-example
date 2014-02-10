
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
    public class BsWhiteSelfReferenceCB : AbstractConditionBean {

        // ===============================================================================
        //                                                                       Attribute
        //                                                                       =========
        protected WhiteSelfReferenceCQ _conditionQuery;

        // ===============================================================================
        //                                                                      Table Name
        //                                                                      ==========
        public override String TableDbName { get { return "white_self_reference"; } }

        // ===============================================================================
        //                                                             PrimaryKey Handling
        //                                                             ===================
        public void AcceptPrimaryKey(long? selfReferenceId) {
            assertObjectNotNull("selfReferenceId", selfReferenceId);
            BsWhiteSelfReferenceCB cb = this;
            cb.Query().SetSelfReferenceId_Equal(selfReferenceId);
        }

        public override ConditionBean AddOrderBy_PK_Asc() {
            Query().AddOrderBy_SelfReferenceId_Asc();
            return this;
        }

        public override ConditionBean AddOrderBy_PK_Desc() {
            Query().AddOrderBy_SelfReferenceId_Desc();
            return this;
        }

        // ===============================================================================
        //                                                                           Query
        //                                                                           =====
        public WhiteSelfReferenceCQ Query() {
            return this.ConditionQuery;
        }

        public WhiteSelfReferenceCQ ConditionQuery {
            get {
                if (_conditionQuery == null) {
                    _conditionQuery = CreateLocalCQ();
                }
                return _conditionQuery;
            }
        }

        protected virtual WhiteSelfReferenceCQ CreateLocalCQ() {
            return xcreateCQ(null, this.SqlClause, this.SqlClause.getBasePointAliasName(), 0);
        }

        protected virtual WhiteSelfReferenceCQ xcreateCQ(ConditionQuery childQuery, SqlClause sqlClause, String aliasName, int nestLevel) {
            return new WhiteSelfReferenceCQ(childQuery, sqlClause, aliasName, nestLevel);
        }

        public override ConditionQuery LocalCQ {
            get { return this.ConditionQuery; }
        }

        // ===============================================================================
        //                                                                           Union
        //                                                                           =====
	    public virtual void Union(UnionQuery<WhiteSelfReferenceCB> unionQuery) {
            WhiteSelfReferenceCB cb = new WhiteSelfReferenceCB();
            cb.xsetupForUnion(this); xsyncUQ(cb); unionQuery.Invoke(cb);
		    WhiteSelfReferenceCQ cq = cb.Query(); Query().xsetUnionQuery(cq);
        }

	    public virtual void UnionAll(UnionQuery<WhiteSelfReferenceCB> unionQuery) {
            WhiteSelfReferenceCB cb = new WhiteSelfReferenceCB();
            cb.xsetupForUnion(this); xsyncUQ(cb); unionQuery.Invoke(cb);
		    WhiteSelfReferenceCQ cq = cb.Query(); Query().xsetUnionAllQuery(cq);
	    }

        public override bool HasUnionQueryOrUnionAllQuery() {
            return Query().hasUnionQueryOrUnionAllQuery();
        }

        // ===============================================================================
        //                                                                    Setup Select
        //                                                                    ============
        protected WhiteSelfReferenceNss _nssWhiteSelfReferenceSelf;
        public WhiteSelfReferenceNss NssWhiteSelfReferenceSelf { get {
            if (_nssWhiteSelfReferenceSelf == null) { _nssWhiteSelfReferenceSelf = new WhiteSelfReferenceNss(null); }
            return _nssWhiteSelfReferenceSelf;
        }}
        public WhiteSelfReferenceNss SetupSelect_WhiteSelfReferenceSelf() {
            if (HasSpecifiedColumn) { // if reverse call
                Specify().ColumnParentId();
            }
            doSetupSelect(delegate { return Query().QueryWhiteSelfReferenceSelf(); });
            if (_nssWhiteSelfReferenceSelf == null || !_nssWhiteSelfReferenceSelf.HasConditionQuery)
            { _nssWhiteSelfReferenceSelf = new WhiteSelfReferenceNss(Query().QueryWhiteSelfReferenceSelf()); }
            return _nssWhiteSelfReferenceSelf;
        }

        // [DBFlute-0.7.4]
        // ===============================================================================
        //                                                                         Specify
        //                                                                         =======
        protected WhiteSelfReferenceCBSpecification _specification;
        public WhiteSelfReferenceCBSpecification Specify() {
            if (_specification == null) { _specification = new WhiteSelfReferenceCBSpecification(this, new MySpQyCall(this), _forDerivedReferrer, _forScalarSelect, _forScalarCondition, _forColumnQuery); }
            return _specification;
        }
        protected bool HasSpecifiedColumn { get {
            return _specification != null && _specification.IsAlreadySpecifiedRequiredColumn;
        }}
        protected class MySpQyCall : HpSpQyCall<WhiteSelfReferenceCQ> {
			protected BsWhiteSelfReferenceCB _myCB;
			public MySpQyCall(BsWhiteSelfReferenceCB myCB) { _myCB = myCB; }
    		public bool has() { return true; } public WhiteSelfReferenceCQ qy() { return _myCB.Query(); }
    	}

        // [DBFlute-0.8.9.18]
        // ===============================================================================
        //                                                                     ColumnQuery
        //                                                                     ===========
        public HpColQyOperand<WhiteSelfReferenceCB> ColumnQuery(SpecifyQuery<WhiteSelfReferenceCB> leftSpecifyQuery) {
            return new HpColQyOperand<WhiteSelfReferenceCB>(delegate(SpecifyQuery<WhiteSelfReferenceCB> rightSp, String operand) {
                xcolqy(xcreateColumnQueryCB(), xcreateColumnQueryCB(), leftSpecifyQuery, rightSp, operand);
            });
        }

        protected WhiteSelfReferenceCB xcreateColumnQueryCB() {
            WhiteSelfReferenceCB cb = new WhiteSelfReferenceCB();
            cb.xsetupForColumnQuery((WhiteSelfReferenceCB)this);
            return cb;
        }

        // [DBFlute-0.8.9.9]
        // ===============================================================================
        //                                                                    OrScopeQuery
        //                                                                    ============
        public void OrScopeQuery(OrQuery<WhiteSelfReferenceCB> orQuery) {
            xorQ((WhiteSelfReferenceCB)this, orQuery);
        }

        // ===============================================================================
        //                                                                    Purpose Type
        //                                                                    ============
        public void xsetupForColumnQuery(WhiteSelfReferenceCB mainCB) {
            xinheritSubQueryInfo(mainCB.LocalCQ);
            //xchangePurposeSqlClause(HpCBPurpose.COLUMN_QUERY);
            _forColumnQuery = true; // old style

            // inherits a parent query to synchronize real name
            // (and also for suppressing query check) 
            Specify().xsetSyncQyCall(new WhiteSelfReferenceCBColQySpQyCall(mainCB));
        }
    }

    public class WhiteSelfReferenceCBColQySpQyCall : HpSpQyCall<WhiteSelfReferenceCQ> {
        protected WhiteSelfReferenceCB _mainCB;
        public WhiteSelfReferenceCBColQySpQyCall(WhiteSelfReferenceCB mainCB) {
            _mainCB = mainCB;
        }
        public bool has() { return true; } 
        public WhiteSelfReferenceCQ qy() { return _mainCB.Query(); } 
    }

    public class WhiteSelfReferenceCBSpecification : AbstractSpecification<WhiteSelfReferenceCQ> {
        protected WhiteSelfReferenceCBSpecification _whiteSelfReferenceSelf;
        public WhiteSelfReferenceCBSpecification(ConditionBean baseCB, HpSpQyCall<WhiteSelfReferenceCQ> qyCall
                                                      , bool forDerivedReferrer, bool forScalarSelect, bool forScalarSubQuery, bool forColumnQuery)
        : base(baseCB, qyCall, forDerivedReferrer, forScalarSelect, forScalarSubQuery, forColumnQuery) { }
        public void ColumnSelfReferenceId() { doColumn("SELF_REFERENCE_ID"); }
        public void ColumnSelfReferenceName() { doColumn("SELF_REFERENCE_NAME"); }
        public void ColumnParentId() { doColumn("PARENT_ID"); }
        protected override void doSpecifyRequiredColumn() {
            ColumnSelfReferenceId(); // PK
            if (qyCall().qy().hasConditionQueryWhiteSelfReferenceSelf()
                    || qyCall().qy().xgetReferrerQuery() is WhiteSelfReferenceCQ) {
                ColumnParentId(); // FK or one-to-one referrer
            }
        }
        protected override String getTableDbName() { return "white_self_reference"; }
        public WhiteSelfReferenceCBSpecification SpecifyWhiteSelfReferenceSelf() {
            assertForeign("whiteSelfReferenceSelf");
            if (_whiteSelfReferenceSelf == null) {
                _whiteSelfReferenceSelf = new WhiteSelfReferenceCBSpecification(_baseCB, new WhiteSelfReferenceSelfSpQyCall(_qyCall), _forDerivedReferrer, _forScalarSelect, _forScalarCondition, _forColumnQuery);
                if (xhasSyncQyCall()) // inherits it
                { _whiteSelfReferenceSelf.xsetSyncQyCall(new WhiteSelfReferenceSelfSpQyCall(xsyncQyCall())); }
            }
            return _whiteSelfReferenceSelf;
        }
		public class WhiteSelfReferenceSelfSpQyCall : HpSpQyCall<WhiteSelfReferenceCQ> {
		    protected HpSpQyCall<WhiteSelfReferenceCQ> _qyCall;
		    public WhiteSelfReferenceSelfSpQyCall(HpSpQyCall<WhiteSelfReferenceCQ> myQyCall) { _qyCall = myQyCall; }
		    public bool has() { return _qyCall.has() && _qyCall.qy().hasConditionQueryWhiteSelfReferenceSelf(); }
			public WhiteSelfReferenceCQ qy() { return _qyCall.qy().QueryWhiteSelfReferenceSelf(); }
		}
        public RAFunction<WhiteSelfReferenceCB, WhiteSelfReferenceCQ> DerivedWhiteSelfReferenceSelfList() {
            if (xhasSyncQyCall()) { xsyncQyCall().qy(); } // for sync (for example, this in ColumnQuery)
            return new RAFunction<WhiteSelfReferenceCB, WhiteSelfReferenceCQ>(_baseCB, _qyCall.qy(), delegate(String function, SubQuery<WhiteSelfReferenceCB> subQuery, WhiteSelfReferenceCQ cq, String aliasName)
                { cq.xsderiveWhiteSelfReferenceSelfList(function, subQuery, aliasName); });
        }
    }
}
