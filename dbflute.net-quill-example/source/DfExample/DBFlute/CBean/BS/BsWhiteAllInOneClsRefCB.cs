
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
    public class BsWhiteAllInOneClsRefCB : AbstractConditionBean {

        // ===============================================================================
        //                                                                       Attribute
        //                                                                       =========
        protected WhiteAllInOneClsRefCQ _conditionQuery;

        // ===============================================================================
        //                                                                      Table Name
        //                                                                      ==========
        public override String TableDbName { get { return "white_all_in_one_cls_ref"; } }

        // ===============================================================================
        //                                                             PrimaryKey Handling
        //                                                             ===================
        public void AcceptPrimaryKey(int? clsRefId) {
            assertObjectNotNull("clsRefId", clsRefId);
            BsWhiteAllInOneClsRefCB cb = this;
            cb.Query().SetClsRefId_Equal(clsRefId);
        }

        public override ConditionBean AddOrderBy_PK_Asc() {
            Query().AddOrderBy_ClsRefId_Asc();
            return this;
        }

        public override ConditionBean AddOrderBy_PK_Desc() {
            Query().AddOrderBy_ClsRefId_Desc();
            return this;
        }

        // ===============================================================================
        //                                                                           Query
        //                                                                           =====
        public WhiteAllInOneClsRefCQ Query() {
            return this.ConditionQuery;
        }

        public WhiteAllInOneClsRefCQ ConditionQuery {
            get {
                if (_conditionQuery == null) {
                    _conditionQuery = CreateLocalCQ();
                }
                return _conditionQuery;
            }
        }

        protected virtual WhiteAllInOneClsRefCQ CreateLocalCQ() {
            return xcreateCQ(null, this.SqlClause, this.SqlClause.getBasePointAliasName(), 0);
        }

        protected virtual WhiteAllInOneClsRefCQ xcreateCQ(ConditionQuery childQuery, SqlClause sqlClause, String aliasName, int nestLevel) {
            return new WhiteAllInOneClsRefCQ(childQuery, sqlClause, aliasName, nestLevel);
        }

        public override ConditionQuery LocalCQ {
            get { return this.ConditionQuery; }
        }

        // ===============================================================================
        //                                                                           Union
        //                                                                           =====
	    public virtual void Union(UnionQuery<WhiteAllInOneClsRefCB> unionQuery) {
            WhiteAllInOneClsRefCB cb = new WhiteAllInOneClsRefCB();
            cb.xsetupForUnion(this); xsyncUQ(cb); unionQuery.Invoke(cb);
		    WhiteAllInOneClsRefCQ cq = cb.Query(); Query().xsetUnionQuery(cq);
        }

	    public virtual void UnionAll(UnionQuery<WhiteAllInOneClsRefCB> unionQuery) {
            WhiteAllInOneClsRefCB cb = new WhiteAllInOneClsRefCB();
            cb.xsetupForUnion(this); xsyncUQ(cb); unionQuery.Invoke(cb);
		    WhiteAllInOneClsRefCQ cq = cb.Query(); Query().xsetUnionAllQuery(cq);
	    }

        public override bool HasUnionQueryOrUnionAllQuery() {
            return Query().hasUnionQueryOrUnionAllQuery();
        }

        // ===============================================================================
        //                                                                    Setup Select
        //                                                                    ============
        protected WhiteAllInOneClsNss _nssWhiteAllInOneClsAsFoo;
        public WhiteAllInOneClsNss NssWhiteAllInOneClsAsFoo { get {
            if (_nssWhiteAllInOneClsAsFoo == null) { _nssWhiteAllInOneClsAsFoo = new WhiteAllInOneClsNss(null); }
            return _nssWhiteAllInOneClsAsFoo;
        }}
        public WhiteAllInOneClsNss SetupSelect_WhiteAllInOneClsAsFoo() {
            if (HasSpecifiedColumn) { // if reverse call
                Specify().ColumnFooCode();
            }
            doSetupSelect(delegate { return Query().QueryWhiteAllInOneClsAsFoo(); });
            if (_nssWhiteAllInOneClsAsFoo == null || !_nssWhiteAllInOneClsAsFoo.HasConditionQuery)
            { _nssWhiteAllInOneClsAsFoo = new WhiteAllInOneClsNss(Query().QueryWhiteAllInOneClsAsFoo()); }
            return _nssWhiteAllInOneClsAsFoo;
        }
        protected WhiteAllInOneClsNss _nssWhiteAllInOneClsAsBar;
        public WhiteAllInOneClsNss NssWhiteAllInOneClsAsBar { get {
            if (_nssWhiteAllInOneClsAsBar == null) { _nssWhiteAllInOneClsAsBar = new WhiteAllInOneClsNss(null); }
            return _nssWhiteAllInOneClsAsBar;
        }}
        public WhiteAllInOneClsNss SetupSelect_WhiteAllInOneClsAsBar() {
            if (HasSpecifiedColumn) { // if reverse call
                Specify().ColumnBarCode();
            }
            doSetupSelect(delegate { return Query().QueryWhiteAllInOneClsAsBar(); });
            if (_nssWhiteAllInOneClsAsBar == null || !_nssWhiteAllInOneClsAsBar.HasConditionQuery)
            { _nssWhiteAllInOneClsAsBar = new WhiteAllInOneClsNss(Query().QueryWhiteAllInOneClsAsBar()); }
            return _nssWhiteAllInOneClsAsBar;
        }

        // [DBFlute-0.7.4]
        // ===============================================================================
        //                                                                         Specify
        //                                                                         =======
        protected WhiteAllInOneClsRefCBSpecification _specification;
        public WhiteAllInOneClsRefCBSpecification Specify() {
            if (_specification == null) { _specification = new WhiteAllInOneClsRefCBSpecification(this, new MySpQyCall(this), _forDerivedReferrer, _forScalarSelect, _forScalarCondition, _forColumnQuery); }
            return _specification;
        }
        protected bool HasSpecifiedColumn { get {
            return _specification != null && _specification.IsAlreadySpecifiedRequiredColumn;
        }}
        protected class MySpQyCall : HpSpQyCall<WhiteAllInOneClsRefCQ> {
			protected BsWhiteAllInOneClsRefCB _myCB;
			public MySpQyCall(BsWhiteAllInOneClsRefCB myCB) { _myCB = myCB; }
    		public bool has() { return true; } public WhiteAllInOneClsRefCQ qy() { return _myCB.Query(); }
    	}

        // [DBFlute-0.8.9.18]
        // ===============================================================================
        //                                                                     ColumnQuery
        //                                                                     ===========
        public HpColQyOperand<WhiteAllInOneClsRefCB> ColumnQuery(SpecifyQuery<WhiteAllInOneClsRefCB> leftSpecifyQuery) {
            return new HpColQyOperand<WhiteAllInOneClsRefCB>(delegate(SpecifyQuery<WhiteAllInOneClsRefCB> rightSp, String operand) {
                xcolqy(xcreateColumnQueryCB(), xcreateColumnQueryCB(), leftSpecifyQuery, rightSp, operand);
            });
        }

        protected WhiteAllInOneClsRefCB xcreateColumnQueryCB() {
            WhiteAllInOneClsRefCB cb = new WhiteAllInOneClsRefCB();
            cb.xsetupForColumnQuery((WhiteAllInOneClsRefCB)this);
            return cb;
        }

        // [DBFlute-0.8.9.9]
        // ===============================================================================
        //                                                                    OrScopeQuery
        //                                                                    ============
        public void OrScopeQuery(OrQuery<WhiteAllInOneClsRefCB> orQuery) {
            xorQ((WhiteAllInOneClsRefCB)this, orQuery);
        }

        // ===============================================================================
        //                                                                    Purpose Type
        //                                                                    ============
        public void xsetupForColumnQuery(WhiteAllInOneClsRefCB mainCB) {
            xinheritSubQueryInfo(mainCB.LocalCQ);
            //xchangePurposeSqlClause(HpCBPurpose.COLUMN_QUERY);
            _forColumnQuery = true; // old style

            // inherits a parent query to synchronize real name
            // (and also for suppressing query check) 
            Specify().xsetSyncQyCall(new WhiteAllInOneClsRefCBColQySpQyCall(mainCB));
        }
    }

    public class WhiteAllInOneClsRefCBColQySpQyCall : HpSpQyCall<WhiteAllInOneClsRefCQ> {
        protected WhiteAllInOneClsRefCB _mainCB;
        public WhiteAllInOneClsRefCBColQySpQyCall(WhiteAllInOneClsRefCB mainCB) {
            _mainCB = mainCB;
        }
        public bool has() { return true; } 
        public WhiteAllInOneClsRefCQ qy() { return _mainCB.Query(); } 
    }

    public class WhiteAllInOneClsRefCBSpecification : AbstractSpecification<WhiteAllInOneClsRefCQ> {
        protected WhiteAllInOneClsCBSpecification _whiteAllInOneClsAsFoo;
        protected WhiteAllInOneClsCBSpecification _whiteAllInOneClsAsBar;
        public WhiteAllInOneClsRefCBSpecification(ConditionBean baseCB, HpSpQyCall<WhiteAllInOneClsRefCQ> qyCall
                                                      , bool forDerivedReferrer, bool forScalarSelect, bool forScalarSubQuery, bool forColumnQuery)
        : base(baseCB, qyCall, forDerivedReferrer, forScalarSelect, forScalarSubQuery, forColumnQuery) { }
        public void ColumnClsRefId() { doColumn("CLS_REF_ID"); }
        public void ColumnFooCode() { doColumn("FOO_CODE"); }
        public void ColumnBarCode() { doColumn("BAR_CODE"); }
        public void ColumnQuxCode() { doColumn("QUX_CODE"); }
        protected override void doSpecifyRequiredColumn() {
            ColumnClsRefId(); // PK
            if (qyCall().qy().hasConditionQueryWhiteAllInOneClsAsFoo()
                    || qyCall().qy().xgetReferrerQuery() is WhiteAllInOneClsCQ) {
                ColumnFooCode(); // FK or one-to-one referrer
            }
            if (qyCall().qy().hasConditionQueryWhiteAllInOneClsAsBar()
                    || qyCall().qy().xgetReferrerQuery() is WhiteAllInOneClsCQ) {
                ColumnBarCode(); // FK or one-to-one referrer
            }
        }
        protected override String getTableDbName() { return "white_all_in_one_cls_ref"; }
        public WhiteAllInOneClsCBSpecification SpecifyWhiteAllInOneClsAsFoo() {
            assertForeign("whiteAllInOneClsAsFoo");
            if (_whiteAllInOneClsAsFoo == null) {
                _whiteAllInOneClsAsFoo = new WhiteAllInOneClsCBSpecification(_baseCB, new WhiteAllInOneClsAsFooSpQyCall(_qyCall), _forDerivedReferrer, _forScalarSelect, _forScalarCondition, _forColumnQuery);
                if (xhasSyncQyCall()) // inherits it
                { _whiteAllInOneClsAsFoo.xsetSyncQyCall(new WhiteAllInOneClsAsFooSpQyCall(xsyncQyCall())); }
            }
            return _whiteAllInOneClsAsFoo;
        }
		public class WhiteAllInOneClsAsFooSpQyCall : HpSpQyCall<WhiteAllInOneClsCQ> {
		    protected HpSpQyCall<WhiteAllInOneClsRefCQ> _qyCall;
		    public WhiteAllInOneClsAsFooSpQyCall(HpSpQyCall<WhiteAllInOneClsRefCQ> myQyCall) { _qyCall = myQyCall; }
		    public bool has() { return _qyCall.has() && _qyCall.qy().hasConditionQueryWhiteAllInOneClsAsFoo(); }
			public WhiteAllInOneClsCQ qy() { return _qyCall.qy().QueryWhiteAllInOneClsAsFoo(); }
		}
        public WhiteAllInOneClsCBSpecification SpecifyWhiteAllInOneClsAsBar() {
            assertForeign("whiteAllInOneClsAsBar");
            if (_whiteAllInOneClsAsBar == null) {
                _whiteAllInOneClsAsBar = new WhiteAllInOneClsCBSpecification(_baseCB, new WhiteAllInOneClsAsBarSpQyCall(_qyCall), _forDerivedReferrer, _forScalarSelect, _forScalarCondition, _forColumnQuery);
                if (xhasSyncQyCall()) // inherits it
                { _whiteAllInOneClsAsBar.xsetSyncQyCall(new WhiteAllInOneClsAsBarSpQyCall(xsyncQyCall())); }
            }
            return _whiteAllInOneClsAsBar;
        }
		public class WhiteAllInOneClsAsBarSpQyCall : HpSpQyCall<WhiteAllInOneClsCQ> {
		    protected HpSpQyCall<WhiteAllInOneClsRefCQ> _qyCall;
		    public WhiteAllInOneClsAsBarSpQyCall(HpSpQyCall<WhiteAllInOneClsRefCQ> myQyCall) { _qyCall = myQyCall; }
		    public bool has() { return _qyCall.has() && _qyCall.qy().hasConditionQueryWhiteAllInOneClsAsBar(); }
			public WhiteAllInOneClsCQ qy() { return _qyCall.qy().QueryWhiteAllInOneClsAsBar(); }
		}
    }
}
