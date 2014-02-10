
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
    public class LdBsMyselfCheckCB : LdAbstractConditionBean {

        // ===============================================================================
        //                                                                       Attribute
        //                                                                       =========
        protected LdMyselfCheckCQ _conditionQuery;

        // ===============================================================================
        //                                                                      Table Name
        //                                                                      ==========
        public override String TableDbName { get { return "myself_check"; } }

        // ===============================================================================
        //                                                             PrimaryKey Handling
        //                                                             ===================
        public void AcceptPrimaryKey(int? myselfCheckId) {
            assertObjectNotNull("myselfCheckId", myselfCheckId);
            LdBsMyselfCheckCB cb = this;
            cb.Query().SetMyselfCheckId_Equal(myselfCheckId);
        }

        public override LdConditionBean AddOrderBy_PK_Asc() {
            Query().AddOrderBy_MyselfCheckId_Asc();
            return this;
        }

        public override LdConditionBean AddOrderBy_PK_Desc() {
            Query().AddOrderBy_MyselfCheckId_Desc();
            return this;
        }

        // ===============================================================================
        //                                                                           Query
        //                                                                           =====
        public LdMyselfCheckCQ Query() {
            return this.ConditionQuery;
        }

        public LdMyselfCheckCQ ConditionQuery {
            get {
                if (_conditionQuery == null) {
                    _conditionQuery = CreateLocalCQ();
                }
                return _conditionQuery;
            }
        }

        protected virtual LdMyselfCheckCQ CreateLocalCQ() {
            return xcreateCQ(null, this.SqlClause, this.SqlClause.getBasePointAliasName(), 0);
        }

        protected virtual LdMyselfCheckCQ xcreateCQ(LdConditionQuery childQuery, LdSqlClause sqlClause, String aliasName, int nestLevel) {
            return new LdMyselfCheckCQ(childQuery, sqlClause, aliasName, nestLevel);
        }

        public override LdConditionQuery LocalCQ {
            get { return this.ConditionQuery; }
        }

        // ===============================================================================
        //                                                                           Union
        //                                                                           =====
	    public virtual void Union(LdUnionQuery<LdMyselfCheckCB> unionQuery) {
            LdMyselfCheckCB cb = new LdMyselfCheckCB();
            cb.xsetupForUnion(this); xsyncUQ(cb); unionQuery.Invoke(cb);
		    LdMyselfCheckCQ cq = cb.Query(); Query().xsetUnionQuery(cq);
        }

	    public virtual void UnionAll(LdUnionQuery<LdMyselfCheckCB> unionQuery) {
            LdMyselfCheckCB cb = new LdMyselfCheckCB();
            cb.xsetupForUnion(this); xsyncUQ(cb); unionQuery.Invoke(cb);
		    LdMyselfCheckCQ cq = cb.Query(); Query().xsetUnionAllQuery(cq);
	    }

        public override bool HasUnionQueryOrUnionAllQuery() {
            return Query().hasUnionQueryOrUnionAllQuery();
        }

        // ===============================================================================
        //                                                                    Setup Select
        //                                                                    ============
        protected LdMyselfNss _nssMyself;
        public LdMyselfNss NssMyself { get {
            if (_nssMyself == null) { _nssMyself = new LdMyselfNss(null); }
            return _nssMyself;
        }}
        public LdMyselfNss SetupSelect_Myself() {
            if (HasSpecifiedColumn) { // if reverse call
                Specify().ColumnMyselfId();
            }
            doSetupSelect(delegate { return Query().QueryMyself(); });
            if (_nssMyself == null || !_nssMyself.HasConditionQuery)
            { _nssMyself = new LdMyselfNss(Query().QueryMyself()); }
            return _nssMyself;
        }

        // [DBFlute-0.7.4]
        // ===============================================================================
        //                                                                         Specify
        //                                                                         =======
        protected LdMyselfCheckCBSpecification _specification;
        public LdMyselfCheckCBSpecification Specify() {
            if (_specification == null) { _specification = new LdMyselfCheckCBSpecification(this, new MySpQyCall(this), _forDerivedReferrer, _forScalarSelect, _forScalarCondition, _forColumnQuery); }
            return _specification;
        }
        protected bool HasSpecifiedColumn { get {
            return _specification != null && _specification.IsAlreadySpecifiedRequiredColumn;
        }}
        protected class MySpQyCall : HpSpQyCall<LdMyselfCheckCQ> {
			protected LdBsMyselfCheckCB _myCB;
			public MySpQyCall(LdBsMyselfCheckCB myCB) { _myCB = myCB; }
    		public bool has() { return true; } public LdMyselfCheckCQ qy() { return _myCB.Query(); }
    	}

        // [DBFlute-0.8.9.18]
        // ===============================================================================
        //                                                                     ColumnQuery
        //                                                                     ===========
        public HpColQyOperand<LdMyselfCheckCB> ColumnQuery(LdSpecifyQuery<LdMyselfCheckCB> leftSpecifyQuery) {
            return new HpColQyOperand<LdMyselfCheckCB>(delegate(LdSpecifyQuery<LdMyselfCheckCB> rightSp, String operand) {
                xcolqy(xcreateColumnQueryCB(), xcreateColumnQueryCB(), leftSpecifyQuery, rightSp, operand);
            });
        }

        protected LdMyselfCheckCB xcreateColumnQueryCB() {
            LdMyselfCheckCB cb = new LdMyselfCheckCB();
            cb.xsetupForColumnQuery((LdMyselfCheckCB)this);
            return cb;
        }

        // [DBFlute-0.8.9.9]
        // ===============================================================================
        //                                                                    OrScopeQuery
        //                                                                    ============
        public void OrScopeQuery(LdOrQuery<LdMyselfCheckCB> orQuery) {
            xorQ((LdMyselfCheckCB)this, orQuery);
        }

        // ===============================================================================
        //                                                                    Purpose Type
        //                                                                    ============
        public void xsetupForColumnQuery(LdMyselfCheckCB mainCB) {
            xinheritSubQueryInfo(mainCB.LocalCQ);
            //xchangePurposeSqlClause(HpCBPurpose.COLUMN_QUERY);
            _forColumnQuery = true; // old style

            // inherits a parent query to synchronize real name
            // (and also for suppressing query check) 
            Specify().xsetSyncQyCall(new LdMyselfCheckCBColQySpQyCall(mainCB));
        }
    }

    public class LdMyselfCheckCBColQySpQyCall : HpSpQyCall<LdMyselfCheckCQ> {
        protected LdMyselfCheckCB _mainCB;
        public LdMyselfCheckCBColQySpQyCall(LdMyselfCheckCB mainCB) {
            _mainCB = mainCB;
        }
        public bool has() { return true; } 
        public LdMyselfCheckCQ qy() { return _mainCB.Query(); } 
    }

    public class LdMyselfCheckCBSpecification : AbstractSpecification<LdMyselfCheckCQ> {
        protected LdMyselfCBSpecification _myself;
        public LdMyselfCheckCBSpecification(LdConditionBean baseCB, HpSpQyCall<LdMyselfCheckCQ> qyCall
                                                      , bool forDerivedReferrer, bool forScalarSelect, bool forScalarSubQuery, bool forColumnQuery)
        : base(baseCB, qyCall, forDerivedReferrer, forScalarSelect, forScalarSubQuery, forColumnQuery) { }
        public void ColumnMyselfCheckId() { doColumn("MYSELF_CHECK_ID"); }
        public void ColumnMyselfCheckName() { doColumn("MYSELF_CHECK_NAME"); }
        public void ColumnMyselfId() { doColumn("MYSELF_ID"); }
        protected override void doSpecifyRequiredColumn() {
            ColumnMyselfCheckId(); // PK
            if (qyCall().qy().hasConditionQueryMyself()
                    || qyCall().qy().xgetReferrerQuery() is LdMyselfCQ) {
                ColumnMyselfId(); // FK or one-to-one referrer
            }
        }
        protected override String getTableDbName() { return "myself_check"; }
        public LdMyselfCBSpecification SpecifyMyself() {
            assertForeign("myself");
            if (_myself == null) {
                _myself = new LdMyselfCBSpecification(_baseCB, new MyselfSpQyCall(_qyCall), _forDerivedReferrer, _forScalarSelect, _forScalarCondition, _forColumnQuery);
                if (xhasSyncQyCall()) // inherits it
                { _myself.xsetSyncQyCall(new MyselfSpQyCall(xsyncQyCall())); }
            }
            return _myself;
        }
		public class MyselfSpQyCall : HpSpQyCall<LdMyselfCQ> {
		    protected HpSpQyCall<LdMyselfCheckCQ> _qyCall;
		    public MyselfSpQyCall(HpSpQyCall<LdMyselfCheckCQ> myQyCall) { _qyCall = myQyCall; }
		    public bool has() { return _qyCall.has() && _qyCall.qy().hasConditionQueryMyself(); }
			public LdMyselfCQ qy() { return _qyCall.qy().QueryMyself(); }
		}
    }
}
