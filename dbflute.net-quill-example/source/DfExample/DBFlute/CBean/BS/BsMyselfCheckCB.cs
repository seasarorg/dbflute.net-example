
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
    public class BsMyselfCheckCB : AbstractConditionBean {

        // ===============================================================================
        //                                                                       Attribute
        //                                                                       =========
        protected MyselfCheckCQ _conditionQuery;

        // ===============================================================================
        //                                                                      Table Name
        //                                                                      ==========
        public override String TableDbName { get { return "myself_check"; } }

        // ===============================================================================
        //                                                             PrimaryKey Handling
        //                                                             ===================
        public void AcceptPrimaryKey(int? myselfCheckId) {
            assertObjectNotNull("myselfCheckId", myselfCheckId);
            BsMyselfCheckCB cb = this;
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
        public MyselfCheckCQ Query() {
            return this.ConditionQuery;
        }

        public MyselfCheckCQ ConditionQuery {
            get {
                if (_conditionQuery == null) {
                    _conditionQuery = CreateLocalCQ();
                }
                return _conditionQuery;
            }
        }

        protected virtual MyselfCheckCQ CreateLocalCQ() {
            return xcreateCQ(null, this.SqlClause, this.SqlClause.getBasePointAliasName(), 0);
        }

        protected virtual MyselfCheckCQ xcreateCQ(ConditionQuery childQuery, SqlClause sqlClause, String aliasName, int nestLevel) {
            return new MyselfCheckCQ(childQuery, sqlClause, aliasName, nestLevel);
        }

        public override ConditionQuery LocalCQ {
            get { return this.ConditionQuery; }
        }

        // ===============================================================================
        //                                                                           Union
        //                                                                           =====
	    public virtual void Union(UnionQuery<MyselfCheckCB> unionQuery) {
            MyselfCheckCB cb = new MyselfCheckCB();
            cb.xsetupForUnion(this); xsyncUQ(cb); unionQuery.Invoke(cb);
		    MyselfCheckCQ cq = cb.Query(); Query().xsetUnionQuery(cq);
        }

	    public virtual void UnionAll(UnionQuery<MyselfCheckCB> unionQuery) {
            MyselfCheckCB cb = new MyselfCheckCB();
            cb.xsetupForUnion(this); xsyncUQ(cb); unionQuery.Invoke(cb);
		    MyselfCheckCQ cq = cb.Query(); Query().xsetUnionAllQuery(cq);
	    }

        public override bool HasUnionQueryOrUnionAllQuery() {
            return Query().hasUnionQueryOrUnionAllQuery();
        }

        // ===============================================================================
        //                                                                    Setup Select
        //                                                                    ============
        protected MyselfNss _nssMyself;
        public MyselfNss NssMyself { get {
            if (_nssMyself == null) { _nssMyself = new MyselfNss(null); }
            return _nssMyself;
        }}
        public MyselfNss SetupSelect_Myself() {
            if (HasSpecifiedColumn) { // if reverse call
                Specify().ColumnMyselfId();
            }
            doSetupSelect(delegate { return Query().QueryMyself(); });
            if (_nssMyself == null || !_nssMyself.HasConditionQuery)
            { _nssMyself = new MyselfNss(Query().QueryMyself()); }
            return _nssMyself;
        }

        // [DBFlute-0.7.4]
        // ===============================================================================
        //                                                                         Specify
        //                                                                         =======
        protected MyselfCheckCBSpecification _specification;
        public MyselfCheckCBSpecification Specify() {
            if (_specification == null) { _specification = new MyselfCheckCBSpecification(this, new MySpQyCall(this), _forDerivedReferrer, _forScalarSelect, _forScalarCondition, _forColumnQuery); }
            return _specification;
        }
        protected bool HasSpecifiedColumn { get {
            return _specification != null && _specification.IsAlreadySpecifiedRequiredColumn;
        }}
        protected class MySpQyCall : HpSpQyCall<MyselfCheckCQ> {
			protected BsMyselfCheckCB _myCB;
			public MySpQyCall(BsMyselfCheckCB myCB) { _myCB = myCB; }
    		public bool has() { return true; } public MyselfCheckCQ qy() { return _myCB.Query(); }
    	}

        // [DBFlute-0.8.9.18]
        // ===============================================================================
        //                                                                     ColumnQuery
        //                                                                     ===========
        public HpColQyOperand<MyselfCheckCB> ColumnQuery(SpecifyQuery<MyselfCheckCB> leftSpecifyQuery) {
            return new HpColQyOperand<MyselfCheckCB>(delegate(SpecifyQuery<MyselfCheckCB> rightSp, String operand) {
                xcolqy(xcreateColumnQueryCB(), xcreateColumnQueryCB(), leftSpecifyQuery, rightSp, operand);
            });
        }

        protected MyselfCheckCB xcreateColumnQueryCB() {
            MyselfCheckCB cb = new MyselfCheckCB();
            cb.xsetupForColumnQuery((MyselfCheckCB)this);
            return cb;
        }

        // [DBFlute-0.8.9.9]
        // ===============================================================================
        //                                                                    OrScopeQuery
        //                                                                    ============
        public void OrScopeQuery(OrQuery<MyselfCheckCB> orQuery) {
            xorQ((MyselfCheckCB)this, orQuery);
        }

        // ===============================================================================
        //                                                                    Purpose Type
        //                                                                    ============
        public void xsetupForColumnQuery(MyselfCheckCB mainCB) {
            xinheritSubQueryInfo(mainCB.LocalCQ);
            //xchangePurposeSqlClause(HpCBPurpose.COLUMN_QUERY);
            _forColumnQuery = true; // old style

            // inherits a parent query to synchronize real name
            // (and also for suppressing query check) 
            Specify().xsetSyncQyCall(new MyselfCheckCBColQySpQyCall(mainCB));
        }
    }

    public class MyselfCheckCBColQySpQyCall : HpSpQyCall<MyselfCheckCQ> {
        protected MyselfCheckCB _mainCB;
        public MyselfCheckCBColQySpQyCall(MyselfCheckCB mainCB) {
            _mainCB = mainCB;
        }
        public bool has() { return true; } 
        public MyselfCheckCQ qy() { return _mainCB.Query(); } 
    }

    public class MyselfCheckCBSpecification : AbstractSpecification<MyselfCheckCQ> {
        protected MyselfCBSpecification _myself;
        public MyselfCheckCBSpecification(ConditionBean baseCB, HpSpQyCall<MyselfCheckCQ> qyCall
                                                      , bool forDerivedReferrer, bool forScalarSelect, bool forScalarSubQuery, bool forColumnQuery)
        : base(baseCB, qyCall, forDerivedReferrer, forScalarSelect, forScalarSubQuery, forColumnQuery) { }
        public void ColumnMyselfCheckId() { doColumn("MYSELF_CHECK_ID"); }
        public void ColumnMyselfCheckName() { doColumn("MYSELF_CHECK_NAME"); }
        public void ColumnMyselfId() { doColumn("MYSELF_ID"); }
        protected override void doSpecifyRequiredColumn() {
            ColumnMyselfCheckId(); // PK
            if (qyCall().qy().hasConditionQueryMyself()
                    || qyCall().qy().xgetReferrerQuery() is MyselfCQ) {
                ColumnMyselfId(); // FK or one-to-one referrer
            }
        }
        protected override String getTableDbName() { return "myself_check"; }
        public MyselfCBSpecification SpecifyMyself() {
            assertForeign("myself");
            if (_myself == null) {
                _myself = new MyselfCBSpecification(_baseCB, new MyselfSpQyCall(_qyCall), _forDerivedReferrer, _forScalarSelect, _forScalarCondition, _forColumnQuery);
                if (xhasSyncQyCall()) // inherits it
                { _myself.xsetSyncQyCall(new MyselfSpQyCall(xsyncQyCall())); }
            }
            return _myself;
        }
		public class MyselfSpQyCall : HpSpQyCall<MyselfCQ> {
		    protected HpSpQyCall<MyselfCheckCQ> _qyCall;
		    public MyselfSpQyCall(HpSpQyCall<MyselfCheckCQ> myQyCall) { _qyCall = myQyCall; }
		    public bool has() { return _qyCall.has() && _qyCall.qy().hasConditionQueryMyself(); }
			public MyselfCQ qy() { return _qyCall.qy().QueryMyself(); }
		}
    }
}
