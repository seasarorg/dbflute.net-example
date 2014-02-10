
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
    public class LdBsBlackActionCB : LdAbstractConditionBean {

        // ===============================================================================
        //                                                                       Attribute
        //                                                                       =========
        protected LdBlackActionCQ _conditionQuery;

        // ===============================================================================
        //                                                                      Table Name
        //                                                                      ==========
        public override String TableDbName { get { return "black_action"; } }

        // ===============================================================================
        //                                                             PrimaryKey Handling
        //                                                             ===================
        public void AcceptPrimaryKey(int? blackActionId) {
            assertObjectNotNull("blackActionId", blackActionId);
            LdBsBlackActionCB cb = this;
            cb.Query().SetBlackActionId_Equal(blackActionId);
        }

        public override LdConditionBean AddOrderBy_PK_Asc() {
            Query().AddOrderBy_BlackActionId_Asc();
            return this;
        }

        public override LdConditionBean AddOrderBy_PK_Desc() {
            Query().AddOrderBy_BlackActionId_Desc();
            return this;
        }

        // ===============================================================================
        //                                                                           Query
        //                                                                           =====
        public LdBlackActionCQ Query() {
            return this.ConditionQuery;
        }

        public LdBlackActionCQ ConditionQuery {
            get {
                if (_conditionQuery == null) {
                    _conditionQuery = CreateLocalCQ();
                }
                return _conditionQuery;
            }
        }

        protected virtual LdBlackActionCQ CreateLocalCQ() {
            return xcreateCQ(null, this.SqlClause, this.SqlClause.getBasePointAliasName(), 0);
        }

        protected virtual LdBlackActionCQ xcreateCQ(LdConditionQuery childQuery, LdSqlClause sqlClause, String aliasName, int nestLevel) {
            return new LdBlackActionCQ(childQuery, sqlClause, aliasName, nestLevel);
        }

        public override LdConditionQuery LocalCQ {
            get { return this.ConditionQuery; }
        }

        // ===============================================================================
        //                                                                           Union
        //                                                                           =====
	    public virtual void Union(LdUnionQuery<LdBlackActionCB> unionQuery) {
            LdBlackActionCB cb = new LdBlackActionCB();
            cb.xsetupForUnion(this); xsyncUQ(cb); unionQuery.Invoke(cb);
		    LdBlackActionCQ cq = cb.Query(); Query().xsetUnionQuery(cq);
        }

	    public virtual void UnionAll(LdUnionQuery<LdBlackActionCB> unionQuery) {
            LdBlackActionCB cb = new LdBlackActionCB();
            cb.xsetupForUnion(this); xsyncUQ(cb); unionQuery.Invoke(cb);
		    LdBlackActionCQ cq = cb.Query(); Query().xsetUnionAllQuery(cq);
	    }

        public override bool HasUnionQueryOrUnionAllQuery() {
            return Query().hasUnionQueryOrUnionAllQuery();
        }

        // ===============================================================================
        //                                                                    Setup Select
        //                                                                    ============
        protected LdBlackListNss _nssBlackList;
        public LdBlackListNss NssBlackList { get {
            if (_nssBlackList == null) { _nssBlackList = new LdBlackListNss(null); }
            return _nssBlackList;
        }}
        public LdBlackListNss SetupSelect_BlackList() {
            if (HasSpecifiedColumn) { // if reverse call
                Specify().ColumnBlackListId();
            }
            doSetupSelect(delegate { return Query().QueryBlackList(); });
            if (_nssBlackList == null || !_nssBlackList.HasConditionQuery)
            { _nssBlackList = new LdBlackListNss(Query().QueryBlackList()); }
            return _nssBlackList;
        }
        protected LdBlackActionLookupNss _nssBlackActionLookup;
        public LdBlackActionLookupNss NssBlackActionLookup { get {
            if (_nssBlackActionLookup == null) { _nssBlackActionLookup = new LdBlackActionLookupNss(null); }
            return _nssBlackActionLookup;
        }}
        public LdBlackActionLookupNss SetupSelect_BlackActionLookup() {
            if (HasSpecifiedColumn) { // if reverse call
                Specify().ColumnBlackActionCode();
            }
            doSetupSelect(delegate { return Query().QueryBlackActionLookup(); });
            if (_nssBlackActionLookup == null || !_nssBlackActionLookup.HasConditionQuery)
            { _nssBlackActionLookup = new LdBlackActionLookupNss(Query().QueryBlackActionLookup()); }
            return _nssBlackActionLookup;
        }

        // [DBFlute-0.7.4]
        // ===============================================================================
        //                                                                         Specify
        //                                                                         =======
        protected LdBlackActionCBSpecification _specification;
        public LdBlackActionCBSpecification Specify() {
            if (_specification == null) { _specification = new LdBlackActionCBSpecification(this, new MySpQyCall(this), _forDerivedReferrer, _forScalarSelect, _forScalarCondition, _forColumnQuery); }
            return _specification;
        }
        protected bool HasSpecifiedColumn { get {
            return _specification != null && _specification.IsAlreadySpecifiedRequiredColumn;
        }}
        protected class MySpQyCall : HpSpQyCall<LdBlackActionCQ> {
			protected LdBsBlackActionCB _myCB;
			public MySpQyCall(LdBsBlackActionCB myCB) { _myCB = myCB; }
    		public bool has() { return true; } public LdBlackActionCQ qy() { return _myCB.Query(); }
    	}

        // [DBFlute-0.8.9.18]
        // ===============================================================================
        //                                                                     ColumnQuery
        //                                                                     ===========
        public HpColQyOperand<LdBlackActionCB> ColumnQuery(LdSpecifyQuery<LdBlackActionCB> leftSpecifyQuery) {
            return new HpColQyOperand<LdBlackActionCB>(delegate(LdSpecifyQuery<LdBlackActionCB> rightSp, String operand) {
                xcolqy(xcreateColumnQueryCB(), xcreateColumnQueryCB(), leftSpecifyQuery, rightSp, operand);
            });
        }

        protected LdBlackActionCB xcreateColumnQueryCB() {
            LdBlackActionCB cb = new LdBlackActionCB();
            cb.xsetupForColumnQuery((LdBlackActionCB)this);
            return cb;
        }

        // [DBFlute-0.8.9.9]
        // ===============================================================================
        //                                                                    OrScopeQuery
        //                                                                    ============
        public void OrScopeQuery(LdOrQuery<LdBlackActionCB> orQuery) {
            xorQ((LdBlackActionCB)this, orQuery);
        }

        // ===============================================================================
        //                                                                    Purpose Type
        //                                                                    ============
        public void xsetupForColumnQuery(LdBlackActionCB mainCB) {
            xinheritSubQueryInfo(mainCB.LocalCQ);
            //xchangePurposeSqlClause(HpCBPurpose.COLUMN_QUERY);
            _forColumnQuery = true; // old style

            // inherits a parent query to synchronize real name
            // (and also for suppressing query check) 
            Specify().xsetSyncQyCall(new LdBlackActionCBColQySpQyCall(mainCB));
        }
    }

    public class LdBlackActionCBColQySpQyCall : HpSpQyCall<LdBlackActionCQ> {
        protected LdBlackActionCB _mainCB;
        public LdBlackActionCBColQySpQyCall(LdBlackActionCB mainCB) {
            _mainCB = mainCB;
        }
        public bool has() { return true; } 
        public LdBlackActionCQ qy() { return _mainCB.Query(); } 
    }

    public class LdBlackActionCBSpecification : AbstractSpecification<LdBlackActionCQ> {
        protected LdBlackListCBSpecification _blackList;
        protected LdBlackActionLookupCBSpecification _blackActionLookup;
        public LdBlackActionCBSpecification(LdConditionBean baseCB, HpSpQyCall<LdBlackActionCQ> qyCall
                                                      , bool forDerivedReferrer, bool forScalarSelect, bool forScalarSubQuery, bool forColumnQuery)
        : base(baseCB, qyCall, forDerivedReferrer, forScalarSelect, forScalarSubQuery, forColumnQuery) { }
        public void ColumnBlackActionId() { doColumn("BLACK_ACTION_ID"); }
        public void ColumnBlackListId() { doColumn("BLACK_LIST_ID"); }
        public void ColumnBlackActionCode() { doColumn("BLACK_ACTION_CODE"); }
        public void ColumnBlackLevel() { doColumn("BLACK_LEVEL"); }
        public void ColumnActionDate() { doColumn("ACTION_DATE"); }
        public void ColumnEvidencePhotograph() { doColumn("EVIDENCE_PHOTOGRAPH"); }
        public void ColumnRUser() { doColumn("R_USER"); }
        public void ColumnRModule() { doColumn("R_MODULE"); }
        public void ColumnRTimestamp() { doColumn("R_TIMESTAMP"); }
        public void ColumnUUser() { doColumn("U_USER"); }
        public void ColumnUModule() { doColumn("U_MODULE"); }
        public void ColumnUTimestamp() { doColumn("U_TIMESTAMP"); }
        protected override void doSpecifyRequiredColumn() {
            ColumnBlackActionId(); // PK
            if (qyCall().qy().hasConditionQueryBlackList()
                    || qyCall().qy().xgetReferrerQuery() is LdBlackListCQ) {
                ColumnBlackListId(); // FK or one-to-one referrer
            }
            if (qyCall().qy().hasConditionQueryBlackActionLookup()
                    || qyCall().qy().xgetReferrerQuery() is LdBlackActionLookupCQ) {
                ColumnBlackActionCode(); // FK or one-to-one referrer
            }
        }
        protected override String getTableDbName() { return "black_action"; }
        public LdBlackListCBSpecification SpecifyBlackList() {
            assertForeign("blackList");
            if (_blackList == null) {
                _blackList = new LdBlackListCBSpecification(_baseCB, new BlackListSpQyCall(_qyCall), _forDerivedReferrer, _forScalarSelect, _forScalarCondition, _forColumnQuery);
                if (xhasSyncQyCall()) // inherits it
                { _blackList.xsetSyncQyCall(new BlackListSpQyCall(xsyncQyCall())); }
            }
            return _blackList;
        }
		public class BlackListSpQyCall : HpSpQyCall<LdBlackListCQ> {
		    protected HpSpQyCall<LdBlackActionCQ> _qyCall;
		    public BlackListSpQyCall(HpSpQyCall<LdBlackActionCQ> myQyCall) { _qyCall = myQyCall; }
		    public bool has() { return _qyCall.has() && _qyCall.qy().hasConditionQueryBlackList(); }
			public LdBlackListCQ qy() { return _qyCall.qy().QueryBlackList(); }
		}
        public LdBlackActionLookupCBSpecification SpecifyBlackActionLookup() {
            assertForeign("blackActionLookup");
            if (_blackActionLookup == null) {
                _blackActionLookup = new LdBlackActionLookupCBSpecification(_baseCB, new BlackActionLookupSpQyCall(_qyCall), _forDerivedReferrer, _forScalarSelect, _forScalarCondition, _forColumnQuery);
                if (xhasSyncQyCall()) // inherits it
                { _blackActionLookup.xsetSyncQyCall(new BlackActionLookupSpQyCall(xsyncQyCall())); }
            }
            return _blackActionLookup;
        }
		public class BlackActionLookupSpQyCall : HpSpQyCall<LdBlackActionLookupCQ> {
		    protected HpSpQyCall<LdBlackActionCQ> _qyCall;
		    public BlackActionLookupSpQyCall(HpSpQyCall<LdBlackActionCQ> myQyCall) { _qyCall = myQyCall; }
		    public bool has() { return _qyCall.has() && _qyCall.qy().hasConditionQueryBlackActionLookup(); }
			public LdBlackActionLookupCQ qy() { return _qyCall.qy().QueryBlackActionLookup(); }
		}
    }
}
