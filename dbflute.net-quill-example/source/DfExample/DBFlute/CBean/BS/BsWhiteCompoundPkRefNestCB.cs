
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
    public class BsWhiteCompoundPkRefNestCB : AbstractConditionBean {

        // ===============================================================================
        //                                                                       Attribute
        //                                                                       =========
        protected WhiteCompoundPkRefNestCQ _conditionQuery;

        // ===============================================================================
        //                                                                      Table Name
        //                                                                      ==========
        public override String TableDbName { get { return "white_compound_pk_ref_nest"; } }

        // ===============================================================================
        //                                                             PrimaryKey Handling
        //                                                             ===================
        public void AcceptPrimaryKey(int? compoundPkRefNestId) {
            assertObjectNotNull("compoundPkRefNestId", compoundPkRefNestId);
            BsWhiteCompoundPkRefNestCB cb = this;
            cb.Query().SetCompoundPkRefNestId_Equal(compoundPkRefNestId);
        }

        public override ConditionBean AddOrderBy_PK_Asc() {
            Query().AddOrderBy_CompoundPkRefNestId_Asc();
            return this;
        }

        public override ConditionBean AddOrderBy_PK_Desc() {
            Query().AddOrderBy_CompoundPkRefNestId_Desc();
            return this;
        }

        // ===============================================================================
        //                                                                           Query
        //                                                                           =====
        public WhiteCompoundPkRefNestCQ Query() {
            return this.ConditionQuery;
        }

        public WhiteCompoundPkRefNestCQ ConditionQuery {
            get {
                if (_conditionQuery == null) {
                    _conditionQuery = CreateLocalCQ();
                }
                return _conditionQuery;
            }
        }

        protected virtual WhiteCompoundPkRefNestCQ CreateLocalCQ() {
            return xcreateCQ(null, this.SqlClause, this.SqlClause.getBasePointAliasName(), 0);
        }

        protected virtual WhiteCompoundPkRefNestCQ xcreateCQ(ConditionQuery childQuery, SqlClause sqlClause, String aliasName, int nestLevel) {
            return new WhiteCompoundPkRefNestCQ(childQuery, sqlClause, aliasName, nestLevel);
        }

        public override ConditionQuery LocalCQ {
            get { return this.ConditionQuery; }
        }

        // ===============================================================================
        //                                                                           Union
        //                                                                           =====
	    public virtual void Union(UnionQuery<WhiteCompoundPkRefNestCB> unionQuery) {
            WhiteCompoundPkRefNestCB cb = new WhiteCompoundPkRefNestCB();
            cb.xsetupForUnion(this); xsyncUQ(cb); unionQuery.Invoke(cb);
		    WhiteCompoundPkRefNestCQ cq = cb.Query(); Query().xsetUnionQuery(cq);
        }

	    public virtual void UnionAll(UnionQuery<WhiteCompoundPkRefNestCB> unionQuery) {
            WhiteCompoundPkRefNestCB cb = new WhiteCompoundPkRefNestCB();
            cb.xsetupForUnion(this); xsyncUQ(cb); unionQuery.Invoke(cb);
		    WhiteCompoundPkRefNestCQ cq = cb.Query(); Query().xsetUnionAllQuery(cq);
	    }

        public override bool HasUnionQueryOrUnionAllQuery() {
            return Query().hasUnionQueryOrUnionAllQuery();
        }

        // ===============================================================================
        //                                                                    Setup Select
        //                                                                    ============
        protected WhiteCompoundPkRefNss _nssWhiteCompoundPkRefByQuxMultipleId;
        public WhiteCompoundPkRefNss NssWhiteCompoundPkRefByQuxMultipleId { get {
            if (_nssWhiteCompoundPkRefByQuxMultipleId == null) { _nssWhiteCompoundPkRefByQuxMultipleId = new WhiteCompoundPkRefNss(null); }
            return _nssWhiteCompoundPkRefByQuxMultipleId;
        }}
        public WhiteCompoundPkRefNss SetupSelect_WhiteCompoundPkRefByQuxMultipleId() {
            if (HasSpecifiedColumn) { // if reverse call
                Specify().ColumnBarMultipleId();
                Specify().ColumnQuxMultipleId();
            }
            doSetupSelect(delegate { return Query().QueryWhiteCompoundPkRefByQuxMultipleId(); });
            if (_nssWhiteCompoundPkRefByQuxMultipleId == null || !_nssWhiteCompoundPkRefByQuxMultipleId.HasConditionQuery)
            { _nssWhiteCompoundPkRefByQuxMultipleId = new WhiteCompoundPkRefNss(Query().QueryWhiteCompoundPkRefByQuxMultipleId()); }
            return _nssWhiteCompoundPkRefByQuxMultipleId;
        }
        protected WhiteCompoundPkRefNss _nssWhiteCompoundPkRefByFooMultipleId;
        public WhiteCompoundPkRefNss NssWhiteCompoundPkRefByFooMultipleId { get {
            if (_nssWhiteCompoundPkRefByFooMultipleId == null) { _nssWhiteCompoundPkRefByFooMultipleId = new WhiteCompoundPkRefNss(null); }
            return _nssWhiteCompoundPkRefByFooMultipleId;
        }}
        public WhiteCompoundPkRefNss SetupSelect_WhiteCompoundPkRefByFooMultipleId() {
            if (HasSpecifiedColumn) { // if reverse call
                Specify().ColumnFooMultipleId();
                Specify().ColumnBarMultipleId();
            }
            doSetupSelect(delegate { return Query().QueryWhiteCompoundPkRefByFooMultipleId(); });
            if (_nssWhiteCompoundPkRefByFooMultipleId == null || !_nssWhiteCompoundPkRefByFooMultipleId.HasConditionQuery)
            { _nssWhiteCompoundPkRefByFooMultipleId = new WhiteCompoundPkRefNss(Query().QueryWhiteCompoundPkRefByFooMultipleId()); }
            return _nssWhiteCompoundPkRefByFooMultipleId;
        }

        // [DBFlute-0.7.4]
        // ===============================================================================
        //                                                                         Specify
        //                                                                         =======
        protected WhiteCompoundPkRefNestCBSpecification _specification;
        public WhiteCompoundPkRefNestCBSpecification Specify() {
            if (_specification == null) { _specification = new WhiteCompoundPkRefNestCBSpecification(this, new MySpQyCall(this), _forDerivedReferrer, _forScalarSelect, _forScalarCondition, _forColumnQuery); }
            return _specification;
        }
        protected bool HasSpecifiedColumn { get {
            return _specification != null && _specification.IsAlreadySpecifiedRequiredColumn;
        }}
        protected class MySpQyCall : HpSpQyCall<WhiteCompoundPkRefNestCQ> {
			protected BsWhiteCompoundPkRefNestCB _myCB;
			public MySpQyCall(BsWhiteCompoundPkRefNestCB myCB) { _myCB = myCB; }
    		public bool has() { return true; } public WhiteCompoundPkRefNestCQ qy() { return _myCB.Query(); }
    	}

        // [DBFlute-0.8.9.18]
        // ===============================================================================
        //                                                                     ColumnQuery
        //                                                                     ===========
        public HpColQyOperand<WhiteCompoundPkRefNestCB> ColumnQuery(SpecifyQuery<WhiteCompoundPkRefNestCB> leftSpecifyQuery) {
            return new HpColQyOperand<WhiteCompoundPkRefNestCB>(delegate(SpecifyQuery<WhiteCompoundPkRefNestCB> rightSp, String operand) {
                xcolqy(xcreateColumnQueryCB(), xcreateColumnQueryCB(), leftSpecifyQuery, rightSp, operand);
            });
        }

        protected WhiteCompoundPkRefNestCB xcreateColumnQueryCB() {
            WhiteCompoundPkRefNestCB cb = new WhiteCompoundPkRefNestCB();
            cb.xsetupForColumnQuery((WhiteCompoundPkRefNestCB)this);
            return cb;
        }

        // [DBFlute-0.8.9.9]
        // ===============================================================================
        //                                                                    OrScopeQuery
        //                                                                    ============
        public void OrScopeQuery(OrQuery<WhiteCompoundPkRefNestCB> orQuery) {
            xorQ((WhiteCompoundPkRefNestCB)this, orQuery);
        }

        // ===============================================================================
        //                                                                    Purpose Type
        //                                                                    ============
        public void xsetupForColumnQuery(WhiteCompoundPkRefNestCB mainCB) {
            xinheritSubQueryInfo(mainCB.LocalCQ);
            //xchangePurposeSqlClause(HpCBPurpose.COLUMN_QUERY);
            _forColumnQuery = true; // old style

            // inherits a parent query to synchronize real name
            // (and also for suppressing query check) 
            Specify().xsetSyncQyCall(new WhiteCompoundPkRefNestCBColQySpQyCall(mainCB));
        }
    }

    public class WhiteCompoundPkRefNestCBColQySpQyCall : HpSpQyCall<WhiteCompoundPkRefNestCQ> {
        protected WhiteCompoundPkRefNestCB _mainCB;
        public WhiteCompoundPkRefNestCBColQySpQyCall(WhiteCompoundPkRefNestCB mainCB) {
            _mainCB = mainCB;
        }
        public bool has() { return true; } 
        public WhiteCompoundPkRefNestCQ qy() { return _mainCB.Query(); } 
    }

    public class WhiteCompoundPkRefNestCBSpecification : AbstractSpecification<WhiteCompoundPkRefNestCQ> {
        protected WhiteCompoundPkRefCBSpecification _whiteCompoundPkRefByQuxMultipleId;
        protected WhiteCompoundPkRefCBSpecification _whiteCompoundPkRefByFooMultipleId;
        public WhiteCompoundPkRefNestCBSpecification(ConditionBean baseCB, HpSpQyCall<WhiteCompoundPkRefNestCQ> qyCall
                                                      , bool forDerivedReferrer, bool forScalarSelect, bool forScalarSubQuery, bool forColumnQuery)
        : base(baseCB, qyCall, forDerivedReferrer, forScalarSelect, forScalarSubQuery, forColumnQuery) { }
        public void ColumnCompoundPkRefNestId() { doColumn("COMPOUND_PK_REF_NEST_ID"); }
        public void ColumnFooMultipleId() { doColumn("FOO_MULTIPLE_ID"); }
        public void ColumnBarMultipleId() { doColumn("BAR_MULTIPLE_ID"); }
        public void ColumnQuxMultipleId() { doColumn("QUX_MULTIPLE_ID"); }
        protected override void doSpecifyRequiredColumn() {
            ColumnCompoundPkRefNestId(); // PK
            if (qyCall().qy().hasConditionQueryWhiteCompoundPkRefByQuxMultipleId()
                    || qyCall().qy().xgetReferrerQuery() is WhiteCompoundPkRefCQ) {
                ColumnBarMultipleId(); // FK or one-to-one referrer
                ColumnQuxMultipleId(); // FK or one-to-one referrer
            }
            if (qyCall().qy().hasConditionQueryWhiteCompoundPkRefByFooMultipleId()
                    || qyCall().qy().xgetReferrerQuery() is WhiteCompoundPkRefCQ) {
                ColumnFooMultipleId(); // FK or one-to-one referrer
                ColumnBarMultipleId(); // FK or one-to-one referrer
            }
        }
        protected override String getTableDbName() { return "white_compound_pk_ref_nest"; }
        public WhiteCompoundPkRefCBSpecification SpecifyWhiteCompoundPkRefByQuxMultipleId() {
            assertForeign("whiteCompoundPkRefByQuxMultipleId");
            if (_whiteCompoundPkRefByQuxMultipleId == null) {
                _whiteCompoundPkRefByQuxMultipleId = new WhiteCompoundPkRefCBSpecification(_baseCB, new WhiteCompoundPkRefByQuxMultipleIdSpQyCall(_qyCall), _forDerivedReferrer, _forScalarSelect, _forScalarCondition, _forColumnQuery);
                if (xhasSyncQyCall()) // inherits it
                { _whiteCompoundPkRefByQuxMultipleId.xsetSyncQyCall(new WhiteCompoundPkRefByQuxMultipleIdSpQyCall(xsyncQyCall())); }
            }
            return _whiteCompoundPkRefByQuxMultipleId;
        }
		public class WhiteCompoundPkRefByQuxMultipleIdSpQyCall : HpSpQyCall<WhiteCompoundPkRefCQ> {
		    protected HpSpQyCall<WhiteCompoundPkRefNestCQ> _qyCall;
		    public WhiteCompoundPkRefByQuxMultipleIdSpQyCall(HpSpQyCall<WhiteCompoundPkRefNestCQ> myQyCall) { _qyCall = myQyCall; }
		    public bool has() { return _qyCall.has() && _qyCall.qy().hasConditionQueryWhiteCompoundPkRefByQuxMultipleId(); }
			public WhiteCompoundPkRefCQ qy() { return _qyCall.qy().QueryWhiteCompoundPkRefByQuxMultipleId(); }
		}
        public WhiteCompoundPkRefCBSpecification SpecifyWhiteCompoundPkRefByFooMultipleId() {
            assertForeign("whiteCompoundPkRefByFooMultipleId");
            if (_whiteCompoundPkRefByFooMultipleId == null) {
                _whiteCompoundPkRefByFooMultipleId = new WhiteCompoundPkRefCBSpecification(_baseCB, new WhiteCompoundPkRefByFooMultipleIdSpQyCall(_qyCall), _forDerivedReferrer, _forScalarSelect, _forScalarCondition, _forColumnQuery);
                if (xhasSyncQyCall()) // inherits it
                { _whiteCompoundPkRefByFooMultipleId.xsetSyncQyCall(new WhiteCompoundPkRefByFooMultipleIdSpQyCall(xsyncQyCall())); }
            }
            return _whiteCompoundPkRefByFooMultipleId;
        }
		public class WhiteCompoundPkRefByFooMultipleIdSpQyCall : HpSpQyCall<WhiteCompoundPkRefCQ> {
		    protected HpSpQyCall<WhiteCompoundPkRefNestCQ> _qyCall;
		    public WhiteCompoundPkRefByFooMultipleIdSpQyCall(HpSpQyCall<WhiteCompoundPkRefNestCQ> myQyCall) { _qyCall = myQyCall; }
		    public bool has() { return _qyCall.has() && _qyCall.qy().hasConditionQueryWhiteCompoundPkRefByFooMultipleId(); }
			public WhiteCompoundPkRefCQ qy() { return _qyCall.qy().QueryWhiteCompoundPkRefByFooMultipleId(); }
		}
    }
}
