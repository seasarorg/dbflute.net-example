
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
    public class BsWhitePgReservCB : AbstractConditionBean {

        // ===============================================================================
        //                                                                       Attribute
        //                                                                       =========
        protected WhitePgReservCQ _conditionQuery;

        // ===============================================================================
        //                                                                      Table Name
        //                                                                      ==========
        public override String TableDbName { get { return "white_pg_reserv"; } }

        // ===============================================================================
        //                                                             PrimaryKey Handling
        //                                                             ===================
        public void AcceptPrimaryKey(int? classSynonym) {
            assertObjectNotNull("classSynonym", classSynonym);
            BsWhitePgReservCB cb = this;
            cb.Query().SetClassSynonym_Equal(classSynonym);
        }

        public override ConditionBean AddOrderBy_PK_Asc() {
            Query().AddOrderBy_ClassSynonym_Asc();
            return this;
        }

        public override ConditionBean AddOrderBy_PK_Desc() {
            Query().AddOrderBy_ClassSynonym_Desc();
            return this;
        }

        // ===============================================================================
        //                                                                           Query
        //                                                                           =====
        public WhitePgReservCQ Query() {
            return this.ConditionQuery;
        }

        public WhitePgReservCQ ConditionQuery {
            get {
                if (_conditionQuery == null) {
                    _conditionQuery = CreateLocalCQ();
                }
                return _conditionQuery;
            }
        }

        protected virtual WhitePgReservCQ CreateLocalCQ() {
            return xcreateCQ(null, this.SqlClause, this.SqlClause.getBasePointAliasName(), 0);
        }

        protected virtual WhitePgReservCQ xcreateCQ(ConditionQuery childQuery, SqlClause sqlClause, String aliasName, int nestLevel) {
            return new WhitePgReservCQ(childQuery, sqlClause, aliasName, nestLevel);
        }

        public override ConditionQuery LocalCQ {
            get { return this.ConditionQuery; }
        }

        // ===============================================================================
        //                                                                           Union
        //                                                                           =====
	    public virtual void Union(UnionQuery<WhitePgReservCB> unionQuery) {
            WhitePgReservCB cb = new WhitePgReservCB();
            cb.xsetupForUnion(this); xsyncUQ(cb); unionQuery.Invoke(cb);
		    WhitePgReservCQ cq = cb.Query(); Query().xsetUnionQuery(cq);
        }

	    public virtual void UnionAll(UnionQuery<WhitePgReservCB> unionQuery) {
            WhitePgReservCB cb = new WhitePgReservCB();
            cb.xsetupForUnion(this); xsyncUQ(cb); unionQuery.Invoke(cb);
		    WhitePgReservCQ cq = cb.Query(); Query().xsetUnionAllQuery(cq);
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
        protected WhitePgReservCBSpecification _specification;
        public WhitePgReservCBSpecification Specify() {
            if (_specification == null) { _specification = new WhitePgReservCBSpecification(this, new MySpQyCall(this), _forDerivedReferrer, _forScalarSelect, _forScalarCondition, _forColumnQuery); }
            return _specification;
        }
        protected bool HasSpecifiedColumn { get {
            return _specification != null && _specification.IsAlreadySpecifiedRequiredColumn;
        }}
        protected class MySpQyCall : HpSpQyCall<WhitePgReservCQ> {
			protected BsWhitePgReservCB _myCB;
			public MySpQyCall(BsWhitePgReservCB myCB) { _myCB = myCB; }
    		public bool has() { return true; } public WhitePgReservCQ qy() { return _myCB.Query(); }
    	}

        // [DBFlute-0.8.9.18]
        // ===============================================================================
        //                                                                     ColumnQuery
        //                                                                     ===========
        public HpColQyOperand<WhitePgReservCB> ColumnQuery(SpecifyQuery<WhitePgReservCB> leftSpecifyQuery) {
            return new HpColQyOperand<WhitePgReservCB>(delegate(SpecifyQuery<WhitePgReservCB> rightSp, String operand) {
                xcolqy(xcreateColumnQueryCB(), xcreateColumnQueryCB(), leftSpecifyQuery, rightSp, operand);
            });
        }

        protected WhitePgReservCB xcreateColumnQueryCB() {
            WhitePgReservCB cb = new WhitePgReservCB();
            cb.xsetupForColumnQuery((WhitePgReservCB)this);
            return cb;
        }

        // [DBFlute-0.8.9.9]
        // ===============================================================================
        //                                                                    OrScopeQuery
        //                                                                    ============
        public void OrScopeQuery(OrQuery<WhitePgReservCB> orQuery) {
            xorQ((WhitePgReservCB)this, orQuery);
        }

        // ===============================================================================
        //                                                                    Purpose Type
        //                                                                    ============
        public void xsetupForColumnQuery(WhitePgReservCB mainCB) {
            xinheritSubQueryInfo(mainCB.LocalCQ);
            //xchangePurposeSqlClause(HpCBPurpose.COLUMN_QUERY);
            _forColumnQuery = true; // old style

            // inherits a parent query to synchronize real name
            // (and also for suppressing query check) 
            Specify().xsetSyncQyCall(new WhitePgReservCBColQySpQyCall(mainCB));
        }
    }

    public class WhitePgReservCBColQySpQyCall : HpSpQyCall<WhitePgReservCQ> {
        protected WhitePgReservCB _mainCB;
        public WhitePgReservCBColQySpQyCall(WhitePgReservCB mainCB) {
            _mainCB = mainCB;
        }
        public bool has() { return true; } 
        public WhitePgReservCQ qy() { return _mainCB.Query(); } 
    }

    public class WhitePgReservCBSpecification : AbstractSpecification<WhitePgReservCQ> {
        public WhitePgReservCBSpecification(ConditionBean baseCB, HpSpQyCall<WhitePgReservCQ> qyCall
                                                      , bool forDerivedReferrer, bool forScalarSelect, bool forScalarSubQuery, bool forColumnQuery)
        : base(baseCB, qyCall, forDerivedReferrer, forScalarSelect, forScalarSubQuery, forColumnQuery) { }
        public void ColumnClassSynonym() { doColumn("CLASS"); }
        public void ColumnCase() { doColumn("CASE"); }
        public void ColumnPackage() { doColumn("PACKAGE"); }
        public void ColumnDefault() { doColumn("DEFAULT"); }
        public void ColumnNew() { doColumn("NEW"); }
        public void ColumnNative() { doColumn("NATIVE"); }
        public void ColumnVoid() { doColumn("VOID"); }
        public void ColumnPublic() { doColumn("PUBLIC"); }
        public void ColumnProtected() { doColumn("PROTECTED"); }
        public void ColumnPrivate() { doColumn("PRIVATE"); }
        public void ColumnInterface() { doColumn("INTERFACE"); }
        public void ColumnAbstract() { doColumn("ABSTRACT"); }
        public void ColumnFinal() { doColumn("FINAL"); }
        public void ColumnFinally() { doColumn("FINALLY"); }
        public void ColumnReturn() { doColumn("RETURN"); }
        public void ColumnDouble() { doColumn("DOUBLE"); }
        public void ColumnFloat() { doColumn("FLOAT"); }
        public void ColumnShort() { doColumn("SHORT"); }
        public void ColumnType() { doColumn("TYPE"); }
        public void ColumnReservName() { doColumn("RESERV_NAME"); }
        protected override void doSpecifyRequiredColumn() {
            ColumnClassSynonym(); // PK
        }
        protected override String getTableDbName() { return "white_pg_reserv"; }
        public RAFunction<WhitePgReservRefCB, WhitePgReservCQ> DerivedWhitePgReservRefList() {
            if (xhasSyncQyCall()) { xsyncQyCall().qy(); } // for sync (for example, this in ColumnQuery)
            return new RAFunction<WhitePgReservRefCB, WhitePgReservCQ>(_baseCB, _qyCall.qy(), delegate(String function, SubQuery<WhitePgReservRefCB> subQuery, WhitePgReservCQ cq, String aliasName)
                { cq.xsderiveWhitePgReservRefList(function, subQuery, aliasName); });
        }
    }
}
