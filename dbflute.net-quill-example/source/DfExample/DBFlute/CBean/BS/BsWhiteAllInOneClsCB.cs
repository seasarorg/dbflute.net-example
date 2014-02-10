
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
    public class BsWhiteAllInOneClsCB : AbstractConditionBean {

        // ===============================================================================
        //                                                                       Attribute
        //                                                                       =========
        protected WhiteAllInOneClsCQ _conditionQuery;

        // ===============================================================================
        //                                                                      Table Name
        //                                                                      ==========
        public override String TableDbName { get { return "white_all_in_one_cls"; } }

        // ===============================================================================
        //                                                             PrimaryKey Handling
        //                                                             ===================
        public void AcceptPrimaryKey(String clsCategoryCode, String clsElementCode) {
            assertObjectNotNull("clsCategoryCode", clsCategoryCode);assertObjectNotNull("clsElementCode", clsElementCode);
            BsWhiteAllInOneClsCB cb = this;
            cb.Query().SetClsCategoryCode_Equal(clsCategoryCode);cb.Query().SetClsElementCode_Equal(clsElementCode);
        }

        public override ConditionBean AddOrderBy_PK_Asc() {
            Query().AddOrderBy_ClsCategoryCode_Asc();
            Query().AddOrderBy_ClsElementCode_Asc();
            return this;
        }

        public override ConditionBean AddOrderBy_PK_Desc() {
            Query().AddOrderBy_ClsCategoryCode_Desc();
            Query().AddOrderBy_ClsElementCode_Desc();
            return this;
        }

        // ===============================================================================
        //                                                                           Query
        //                                                                           =====
        public WhiteAllInOneClsCQ Query() {
            return this.ConditionQuery;
        }

        public WhiteAllInOneClsCQ ConditionQuery {
            get {
                if (_conditionQuery == null) {
                    _conditionQuery = CreateLocalCQ();
                }
                return _conditionQuery;
            }
        }

        protected virtual WhiteAllInOneClsCQ CreateLocalCQ() {
            return xcreateCQ(null, this.SqlClause, this.SqlClause.getBasePointAliasName(), 0);
        }

        protected virtual WhiteAllInOneClsCQ xcreateCQ(ConditionQuery childQuery, SqlClause sqlClause, String aliasName, int nestLevel) {
            return new WhiteAllInOneClsCQ(childQuery, sqlClause, aliasName, nestLevel);
        }

        public override ConditionQuery LocalCQ {
            get { return this.ConditionQuery; }
        }

        // ===============================================================================
        //                                                                           Union
        //                                                                           =====
	    public virtual void Union(UnionQuery<WhiteAllInOneClsCB> unionQuery) {
            WhiteAllInOneClsCB cb = new WhiteAllInOneClsCB();
            cb.xsetupForUnion(this); xsyncUQ(cb); unionQuery.Invoke(cb);
		    WhiteAllInOneClsCQ cq = cb.Query(); Query().xsetUnionQuery(cq);
        }

	    public virtual void UnionAll(UnionQuery<WhiteAllInOneClsCB> unionQuery) {
            WhiteAllInOneClsCB cb = new WhiteAllInOneClsCB();
            cb.xsetupForUnion(this); xsyncUQ(cb); unionQuery.Invoke(cb);
		    WhiteAllInOneClsCQ cq = cb.Query(); Query().xsetUnionAllQuery(cq);
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
        protected WhiteAllInOneClsCBSpecification _specification;
        public WhiteAllInOneClsCBSpecification Specify() {
            if (_specification == null) { _specification = new WhiteAllInOneClsCBSpecification(this, new MySpQyCall(this), _forDerivedReferrer, _forScalarSelect, _forScalarCondition, _forColumnQuery); }
            return _specification;
        }
        protected bool HasSpecifiedColumn { get {
            return _specification != null && _specification.IsAlreadySpecifiedRequiredColumn;
        }}
        protected class MySpQyCall : HpSpQyCall<WhiteAllInOneClsCQ> {
			protected BsWhiteAllInOneClsCB _myCB;
			public MySpQyCall(BsWhiteAllInOneClsCB myCB) { _myCB = myCB; }
    		public bool has() { return true; } public WhiteAllInOneClsCQ qy() { return _myCB.Query(); }
    	}

        // [DBFlute-0.8.9.18]
        // ===============================================================================
        //                                                                     ColumnQuery
        //                                                                     ===========
        public HpColQyOperand<WhiteAllInOneClsCB> ColumnQuery(SpecifyQuery<WhiteAllInOneClsCB> leftSpecifyQuery) {
            return new HpColQyOperand<WhiteAllInOneClsCB>(delegate(SpecifyQuery<WhiteAllInOneClsCB> rightSp, String operand) {
                xcolqy(xcreateColumnQueryCB(), xcreateColumnQueryCB(), leftSpecifyQuery, rightSp, operand);
            });
        }

        protected WhiteAllInOneClsCB xcreateColumnQueryCB() {
            WhiteAllInOneClsCB cb = new WhiteAllInOneClsCB();
            cb.xsetupForColumnQuery((WhiteAllInOneClsCB)this);
            return cb;
        }

        // [DBFlute-0.8.9.9]
        // ===============================================================================
        //                                                                    OrScopeQuery
        //                                                                    ============
        public void OrScopeQuery(OrQuery<WhiteAllInOneClsCB> orQuery) {
            xorQ((WhiteAllInOneClsCB)this, orQuery);
        }

        // ===============================================================================
        //                                                                    Purpose Type
        //                                                                    ============
        public void xsetupForColumnQuery(WhiteAllInOneClsCB mainCB) {
            xinheritSubQueryInfo(mainCB.LocalCQ);
            //xchangePurposeSqlClause(HpCBPurpose.COLUMN_QUERY);
            _forColumnQuery = true; // old style

            // inherits a parent query to synchronize real name
            // (and also for suppressing query check) 
            Specify().xsetSyncQyCall(new WhiteAllInOneClsCBColQySpQyCall(mainCB));
        }
    }

    public class WhiteAllInOneClsCBColQySpQyCall : HpSpQyCall<WhiteAllInOneClsCQ> {
        protected WhiteAllInOneClsCB _mainCB;
        public WhiteAllInOneClsCBColQySpQyCall(WhiteAllInOneClsCB mainCB) {
            _mainCB = mainCB;
        }
        public bool has() { return true; } 
        public WhiteAllInOneClsCQ qy() { return _mainCB.Query(); } 
    }

    public class WhiteAllInOneClsCBSpecification : AbstractSpecification<WhiteAllInOneClsCQ> {
        public WhiteAllInOneClsCBSpecification(ConditionBean baseCB, HpSpQyCall<WhiteAllInOneClsCQ> qyCall
                                                      , bool forDerivedReferrer, bool forScalarSelect, bool forScalarSubQuery, bool forColumnQuery)
        : base(baseCB, qyCall, forDerivedReferrer, forScalarSelect, forScalarSubQuery, forColumnQuery) { }
        public void ColumnClsCategoryCode() { doColumn("CLS_CATEGORY_CODE"); }
        public void ColumnClsElementCode() { doColumn("CLS_ELEMENT_CODE"); }
        public void ColumnAttributeExp() { doColumn("ATTRIBUTE_EXP"); }
        protected override void doSpecifyRequiredColumn() {
            ColumnClsCategoryCode(); // PK
            ColumnClsElementCode(); // PK
        }
        protected override String getTableDbName() { return "white_all_in_one_cls"; }
    }
}
