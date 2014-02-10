
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
    public class BsWhitePgReservRefCB : AbstractConditionBean {

        // ===============================================================================
        //                                                                       Attribute
        //                                                                       =========
        protected WhitePgReservRefCQ _conditionQuery;

        // ===============================================================================
        //                                                                      Table Name
        //                                                                      ==========
        public override String TableDbName { get { return "white_pg_reserv_ref"; } }

        // ===============================================================================
        //                                                             PrimaryKey Handling
        //                                                             ===================
        public void AcceptPrimaryKey(int? refId) {
            assertObjectNotNull("refId", refId);
            BsWhitePgReservRefCB cb = this;
            cb.Query().SetRefId_Equal(refId);
        }

        public override ConditionBean AddOrderBy_PK_Asc() {
            Query().AddOrderBy_RefId_Asc();
            return this;
        }

        public override ConditionBean AddOrderBy_PK_Desc() {
            Query().AddOrderBy_RefId_Desc();
            return this;
        }

        // ===============================================================================
        //                                                                           Query
        //                                                                           =====
        public WhitePgReservRefCQ Query() {
            return this.ConditionQuery;
        }

        public WhitePgReservRefCQ ConditionQuery {
            get {
                if (_conditionQuery == null) {
                    _conditionQuery = CreateLocalCQ();
                }
                return _conditionQuery;
            }
        }

        protected virtual WhitePgReservRefCQ CreateLocalCQ() {
            return xcreateCQ(null, this.SqlClause, this.SqlClause.getBasePointAliasName(), 0);
        }

        protected virtual WhitePgReservRefCQ xcreateCQ(ConditionQuery childQuery, SqlClause sqlClause, String aliasName, int nestLevel) {
            return new WhitePgReservRefCQ(childQuery, sqlClause, aliasName, nestLevel);
        }

        public override ConditionQuery LocalCQ {
            get { return this.ConditionQuery; }
        }

        // ===============================================================================
        //                                                                           Union
        //                                                                           =====
	    public virtual void Union(UnionQuery<WhitePgReservRefCB> unionQuery) {
            WhitePgReservRefCB cb = new WhitePgReservRefCB();
            cb.xsetupForUnion(this); xsyncUQ(cb); unionQuery.Invoke(cb);
		    WhitePgReservRefCQ cq = cb.Query(); Query().xsetUnionQuery(cq);
        }

	    public virtual void UnionAll(UnionQuery<WhitePgReservRefCB> unionQuery) {
            WhitePgReservRefCB cb = new WhitePgReservRefCB();
            cb.xsetupForUnion(this); xsyncUQ(cb); unionQuery.Invoke(cb);
		    WhitePgReservRefCQ cq = cb.Query(); Query().xsetUnionAllQuery(cq);
	    }

        public override bool HasUnionQueryOrUnionAllQuery() {
            return Query().hasUnionQueryOrUnionAllQuery();
        }

        // ===============================================================================
        //                                                                    Setup Select
        //                                                                    ============
        protected WhitePgReservNss _nssWhitePgReserv;
        public WhitePgReservNss NssWhitePgReserv { get {
            if (_nssWhitePgReserv == null) { _nssWhitePgReserv = new WhitePgReservNss(null); }
            return _nssWhitePgReserv;
        }}
        public WhitePgReservNss SetupSelect_WhitePgReserv() {
            if (HasSpecifiedColumn) { // if reverse call
                Specify().ColumnClassSynonym();
            }
            doSetupSelect(delegate { return Query().QueryWhitePgReserv(); });
            if (_nssWhitePgReserv == null || !_nssWhitePgReserv.HasConditionQuery)
            { _nssWhitePgReserv = new WhitePgReservNss(Query().QueryWhitePgReserv()); }
            return _nssWhitePgReserv;
        }

        // [DBFlute-0.7.4]
        // ===============================================================================
        //                                                                         Specify
        //                                                                         =======
        protected WhitePgReservRefCBSpecification _specification;
        public WhitePgReservRefCBSpecification Specify() {
            if (_specification == null) { _specification = new WhitePgReservRefCBSpecification(this, new MySpQyCall(this), _forDerivedReferrer, _forScalarSelect, _forScalarCondition, _forColumnQuery); }
            return _specification;
        }
        protected bool HasSpecifiedColumn { get {
            return _specification != null && _specification.IsAlreadySpecifiedRequiredColumn;
        }}
        protected class MySpQyCall : HpSpQyCall<WhitePgReservRefCQ> {
			protected BsWhitePgReservRefCB _myCB;
			public MySpQyCall(BsWhitePgReservRefCB myCB) { _myCB = myCB; }
    		public bool has() { return true; } public WhitePgReservRefCQ qy() { return _myCB.Query(); }
    	}

        // [DBFlute-0.8.9.18]
        // ===============================================================================
        //                                                                     ColumnQuery
        //                                                                     ===========
        public HpColQyOperand<WhitePgReservRefCB> ColumnQuery(SpecifyQuery<WhitePgReservRefCB> leftSpecifyQuery) {
            return new HpColQyOperand<WhitePgReservRefCB>(delegate(SpecifyQuery<WhitePgReservRefCB> rightSp, String operand) {
                xcolqy(xcreateColumnQueryCB(), xcreateColumnQueryCB(), leftSpecifyQuery, rightSp, operand);
            });
        }

        protected WhitePgReservRefCB xcreateColumnQueryCB() {
            WhitePgReservRefCB cb = new WhitePgReservRefCB();
            cb.xsetupForColumnQuery((WhitePgReservRefCB)this);
            return cb;
        }

        // [DBFlute-0.8.9.9]
        // ===============================================================================
        //                                                                    OrScopeQuery
        //                                                                    ============
        public void OrScopeQuery(OrQuery<WhitePgReservRefCB> orQuery) {
            xorQ((WhitePgReservRefCB)this, orQuery);
        }

        // ===============================================================================
        //                                                                    Purpose Type
        //                                                                    ============
        public void xsetupForColumnQuery(WhitePgReservRefCB mainCB) {
            xinheritSubQueryInfo(mainCB.LocalCQ);
            //xchangePurposeSqlClause(HpCBPurpose.COLUMN_QUERY);
            _forColumnQuery = true; // old style

            // inherits a parent query to synchronize real name
            // (and also for suppressing query check) 
            Specify().xsetSyncQyCall(new WhitePgReservRefCBColQySpQyCall(mainCB));
        }
    }

    public class WhitePgReservRefCBColQySpQyCall : HpSpQyCall<WhitePgReservRefCQ> {
        protected WhitePgReservRefCB _mainCB;
        public WhitePgReservRefCBColQySpQyCall(WhitePgReservRefCB mainCB) {
            _mainCB = mainCB;
        }
        public bool has() { return true; } 
        public WhitePgReservRefCQ qy() { return _mainCB.Query(); } 
    }

    public class WhitePgReservRefCBSpecification : AbstractSpecification<WhitePgReservRefCQ> {
        protected WhitePgReservCBSpecification _whitePgReserv;
        public WhitePgReservRefCBSpecification(ConditionBean baseCB, HpSpQyCall<WhitePgReservRefCQ> qyCall
                                                      , bool forDerivedReferrer, bool forScalarSelect, bool forScalarSubQuery, bool forColumnQuery)
        : base(baseCB, qyCall, forDerivedReferrer, forScalarSelect, forScalarSubQuery, forColumnQuery) { }
        public void ColumnRefId() { doColumn("REF_ID"); }
        public void ColumnClassSynonym() { doColumn("CLASS"); }
        protected override void doSpecifyRequiredColumn() {
            ColumnRefId(); // PK
            if (qyCall().qy().hasConditionQueryWhitePgReserv()
                    || qyCall().qy().xgetReferrerQuery() is WhitePgReservCQ) {
                ColumnClassSynonym(); // FK or one-to-one referrer
            }
        }
        protected override String getTableDbName() { return "white_pg_reserv_ref"; }
        public WhitePgReservCBSpecification SpecifyWhitePgReserv() {
            assertForeign("whitePgReserv");
            if (_whitePgReserv == null) {
                _whitePgReserv = new WhitePgReservCBSpecification(_baseCB, new WhitePgReservSpQyCall(_qyCall), _forDerivedReferrer, _forScalarSelect, _forScalarCondition, _forColumnQuery);
                if (xhasSyncQyCall()) // inherits it
                { _whitePgReserv.xsetSyncQyCall(new WhitePgReservSpQyCall(xsyncQyCall())); }
            }
            return _whitePgReserv;
        }
		public class WhitePgReservSpQyCall : HpSpQyCall<WhitePgReservCQ> {
		    protected HpSpQyCall<WhitePgReservRefCQ> _qyCall;
		    public WhitePgReservSpQyCall(HpSpQyCall<WhitePgReservRefCQ> myQyCall) { _qyCall = myQyCall; }
		    public bool has() { return _qyCall.has() && _qyCall.qy().hasConditionQueryWhitePgReserv(); }
			public WhitePgReservCQ qy() { return _qyCall.qy().QueryWhitePgReserv(); }
		}
    }
}
