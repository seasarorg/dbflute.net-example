
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
    public class BsWhiteMyselfCheckCB : AbstractConditionBean {

        // ===============================================================================
        //                                                                       Attribute
        //                                                                       =========
        protected WhiteMyselfCheckCQ _conditionQuery;

        // ===============================================================================
        //                                                                      Table Name
        //                                                                      ==========
        public override String TableDbName { get { return "white_myself_check"; } }

        // ===============================================================================
        //                                                             PrimaryKey Handling
        //                                                             ===================
        public void AcceptPrimaryKey(int? myselfCheckId) {
            assertObjectNotNull("myselfCheckId", myselfCheckId);
            BsWhiteMyselfCheckCB cb = this;
            cb.Query().SetMyselfCheckId_Equal(myselfCheckId);
        }

        public override ConditionBean AddOrderBy_PK_Asc() {
            Query().AddOrderBy_MyselfCheckId_Asc();
            return this;
        }

        public override ConditionBean AddOrderBy_PK_Desc() {
            Query().AddOrderBy_MyselfCheckId_Desc();
            return this;
        }

        // ===============================================================================
        //                                                                           Query
        //                                                                           =====
        public WhiteMyselfCheckCQ Query() {
            return this.ConditionQuery;
        }

        public WhiteMyselfCheckCQ ConditionQuery {
            get {
                if (_conditionQuery == null) {
                    _conditionQuery = CreateLocalCQ();
                }
                return _conditionQuery;
            }
        }

        protected virtual WhiteMyselfCheckCQ CreateLocalCQ() {
            return xcreateCQ(null, this.SqlClause, this.SqlClause.getBasePointAliasName(), 0);
        }

        protected virtual WhiteMyselfCheckCQ xcreateCQ(ConditionQuery childQuery, SqlClause sqlClause, String aliasName, int nestLevel) {
            return new WhiteMyselfCheckCQ(childQuery, sqlClause, aliasName, nestLevel);
        }

        public override ConditionQuery LocalCQ {
            get { return this.ConditionQuery; }
        }

        // ===============================================================================
        //                                                                           Union
        //                                                                           =====
	    public virtual void Union(UnionQuery<WhiteMyselfCheckCB> unionQuery) {
            WhiteMyselfCheckCB cb = new WhiteMyselfCheckCB();
            cb.xsetupForUnion(this); xsyncUQ(cb); unionQuery.Invoke(cb);
		    WhiteMyselfCheckCQ cq = cb.Query(); Query().xsetUnionQuery(cq);
        }

	    public virtual void UnionAll(UnionQuery<WhiteMyselfCheckCB> unionQuery) {
            WhiteMyselfCheckCB cb = new WhiteMyselfCheckCB();
            cb.xsetupForUnion(this); xsyncUQ(cb); unionQuery.Invoke(cb);
		    WhiteMyselfCheckCQ cq = cb.Query(); Query().xsetUnionAllQuery(cq);
	    }

        public override bool HasUnionQueryOrUnionAllQuery() {
            return Query().hasUnionQueryOrUnionAllQuery();
        }

        // ===============================================================================
        //                                                                    Setup Select
        //                                                                    ============
        protected WhiteMyselfNss _nssWhiteMyself;
        public WhiteMyselfNss NssWhiteMyself { get {
            if (_nssWhiteMyself == null) { _nssWhiteMyself = new WhiteMyselfNss(null); }
            return _nssWhiteMyself;
        }}
        public WhiteMyselfNss SetupSelect_WhiteMyself() {
            if (HasSpecifiedColumn) { // if reverse call
                Specify().ColumnMyselfId();
            }
            doSetupSelect(delegate { return Query().QueryWhiteMyself(); });
            if (_nssWhiteMyself == null || !_nssWhiteMyself.HasConditionQuery)
            { _nssWhiteMyself = new WhiteMyselfNss(Query().QueryWhiteMyself()); }
            return _nssWhiteMyself;
        }

        // [DBFlute-0.7.4]
        // ===============================================================================
        //                                                                         Specify
        //                                                                         =======
        protected WhiteMyselfCheckCBSpecification _specification;
        public WhiteMyselfCheckCBSpecification Specify() {
            if (_specification == null) { _specification = new WhiteMyselfCheckCBSpecification(this, new MySpQyCall(this), _forDerivedReferrer, _forScalarSelect, _forScalarCondition, _forColumnQuery); }
            return _specification;
        }
        protected bool HasSpecifiedColumn { get {
            return _specification != null && _specification.IsAlreadySpecifiedRequiredColumn;
        }}
        protected class MySpQyCall : HpSpQyCall<WhiteMyselfCheckCQ> {
			protected BsWhiteMyselfCheckCB _myCB;
			public MySpQyCall(BsWhiteMyselfCheckCB myCB) { _myCB = myCB; }
    		public bool has() { return true; } public WhiteMyselfCheckCQ qy() { return _myCB.Query(); }
    	}

        // [DBFlute-0.8.9.18]
        // ===============================================================================
        //                                                                     ColumnQuery
        //                                                                     ===========
        public HpColQyOperand<WhiteMyselfCheckCB> ColumnQuery(SpecifyQuery<WhiteMyselfCheckCB> leftSpecifyQuery) {
            return new HpColQyOperand<WhiteMyselfCheckCB>(delegate(SpecifyQuery<WhiteMyselfCheckCB> rightSp, String operand) {
                xcolqy(xcreateColumnQueryCB(), xcreateColumnQueryCB(), leftSpecifyQuery, rightSp, operand);
            });
        }

        protected WhiteMyselfCheckCB xcreateColumnQueryCB() {
            WhiteMyselfCheckCB cb = new WhiteMyselfCheckCB();
            cb.xsetupForColumnQuery((WhiteMyselfCheckCB)this);
            return cb;
        }

        // [DBFlute-0.8.9.9]
        // ===============================================================================
        //                                                                    OrScopeQuery
        //                                                                    ============
        public void OrScopeQuery(OrQuery<WhiteMyselfCheckCB> orQuery) {
            xorQ((WhiteMyselfCheckCB)this, orQuery);
        }

        // ===============================================================================
        //                                                                    Purpose Type
        //                                                                    ============
        public void xsetupForColumnQuery(WhiteMyselfCheckCB mainCB) {
            xinheritSubQueryInfo(mainCB.LocalCQ);
            //xchangePurposeSqlClause(HpCBPurpose.COLUMN_QUERY);
            _forColumnQuery = true; // old style

            // inherits a parent query to synchronize real name
            // (and also for suppressing query check) 
            Specify().xsetSyncQyCall(new WhiteMyselfCheckCBColQySpQyCall(mainCB));
        }
    }

    public class WhiteMyselfCheckCBColQySpQyCall : HpSpQyCall<WhiteMyselfCheckCQ> {
        protected WhiteMyselfCheckCB _mainCB;
        public WhiteMyselfCheckCBColQySpQyCall(WhiteMyselfCheckCB mainCB) {
            _mainCB = mainCB;
        }
        public bool has() { return true; } 
        public WhiteMyselfCheckCQ qy() { return _mainCB.Query(); } 
    }

    public class WhiteMyselfCheckCBSpecification : AbstractSpecification<WhiteMyselfCheckCQ> {
        protected WhiteMyselfCBSpecification _whiteMyself;
        public WhiteMyselfCheckCBSpecification(ConditionBean baseCB, HpSpQyCall<WhiteMyselfCheckCQ> qyCall
                                                      , bool forDerivedReferrer, bool forScalarSelect, bool forScalarSubQuery, bool forColumnQuery)
        : base(baseCB, qyCall, forDerivedReferrer, forScalarSelect, forScalarSubQuery, forColumnQuery) { }
        public void ColumnMyselfCheckId() { doColumn("MYSELF_CHECK_ID"); }
        public void ColumnMyselfCheckName() { doColumn("MYSELF_CHECK_NAME"); }
        public void ColumnMyselfId() { doColumn("MYSELF_ID"); }
        protected override void doSpecifyRequiredColumn() {
            ColumnMyselfCheckId(); // PK
            if (qyCall().qy().hasConditionQueryWhiteMyself()
                    || qyCall().qy().xgetReferrerQuery() is WhiteMyselfCQ) {
                ColumnMyselfId(); // FK or one-to-one referrer
            }
        }
        protected override String getTableDbName() { return "white_myself_check"; }
        public WhiteMyselfCBSpecification SpecifyWhiteMyself() {
            assertForeign("whiteMyself");
            if (_whiteMyself == null) {
                _whiteMyself = new WhiteMyselfCBSpecification(_baseCB, new WhiteMyselfSpQyCall(_qyCall), _forDerivedReferrer, _forScalarSelect, _forScalarCondition, _forColumnQuery);
                if (xhasSyncQyCall()) // inherits it
                { _whiteMyself.xsetSyncQyCall(new WhiteMyselfSpQyCall(xsyncQyCall())); }
            }
            return _whiteMyself;
        }
		public class WhiteMyselfSpQyCall : HpSpQyCall<WhiteMyselfCQ> {
		    protected HpSpQyCall<WhiteMyselfCheckCQ> _qyCall;
		    public WhiteMyselfSpQyCall(HpSpQyCall<WhiteMyselfCheckCQ> myQyCall) { _qyCall = myQyCall; }
		    public bool has() { return _qyCall.has() && _qyCall.qy().hasConditionQueryWhiteMyself(); }
			public WhiteMyselfCQ qy() { return _qyCall.qy().QueryWhiteMyself(); }
		}
    }
}
