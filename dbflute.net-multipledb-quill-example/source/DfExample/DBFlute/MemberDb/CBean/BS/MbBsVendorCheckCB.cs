
using System;
using System.Collections;

using DfExample.DBFlute.MemberDb.AllCommon;
using DfExample.DBFlute.MemberDb.AllCommon.CBean;
using DfExample.DBFlute.MemberDb.AllCommon.CBean.SClause;
using DfExample.DBFlute.MemberDb.AllCommon.Helper;

using DfExample.DBFlute.MemberDb.CBean;
using DfExample.DBFlute.MemberDb.CBean.CQ;
using DfExample.DBFlute.MemberDb.CBean.Nss;

namespace DfExample.DBFlute.MemberDb.CBean.BS {

    [System.Serializable]
    public class MbBsVendorCheckCB : MbAbstractConditionBean {

        // ===============================================================================
        //                                                                       Attribute
        //                                                                       =========
        protected MbVendorCheckCQ _conditionQuery;

        // ===============================================================================
        //                                                                      Table Name
        //                                                                      ==========
        public override String TableDbName { get { return "vendor_check"; } }

        // ===============================================================================
        //                                                             PrimaryKey Handling
        //                                                             ===================
        public void AcceptPrimaryKey(long? vendorCheckId) {
            assertObjectNotNull("vendorCheckId", vendorCheckId);
            MbBsVendorCheckCB cb = this;
            cb.Query().SetVendorCheckId_Equal(vendorCheckId);
        }

        public override MbConditionBean AddOrderBy_PK_Asc() {
            Query().AddOrderBy_VendorCheckId_Asc();
            return this;
        }

        public override MbConditionBean AddOrderBy_PK_Desc() {
            Query().AddOrderBy_VendorCheckId_Desc();
            return this;
        }

        // ===============================================================================
        //                                                                           Query
        //                                                                           =====
        public MbVendorCheckCQ Query() {
            return this.ConditionQuery;
        }

        public MbVendorCheckCQ ConditionQuery {
            get {
                if (_conditionQuery == null) {
                    _conditionQuery = CreateLocalCQ();
                }
                return _conditionQuery;
            }
        }

        protected virtual MbVendorCheckCQ CreateLocalCQ() {
            return xcreateCQ(null, this.SqlClause, this.SqlClause.getBasePointAliasName(), 0);
        }

        protected virtual MbVendorCheckCQ xcreateCQ(MbConditionQuery childQuery, MbSqlClause sqlClause, String aliasName, int nestLevel) {
            return new MbVendorCheckCQ(childQuery, sqlClause, aliasName, nestLevel);
        }

        public override MbConditionQuery LocalCQ {
            get { return this.ConditionQuery; }
        }

        // ===============================================================================
        //                                                                           Union
        //                                                                           =====
	    public virtual void Union(MbUnionQuery<MbVendorCheckCB> unionQuery) {
            MbVendorCheckCB cb = new MbVendorCheckCB();
            cb.xsetupForUnion(this); xsyncUQ(cb); unionQuery.Invoke(cb);
		    MbVendorCheckCQ cq = cb.Query(); Query().xsetUnionQuery(cq);
        }

	    public virtual void UnionAll(MbUnionQuery<MbVendorCheckCB> unionQuery) {
            MbVendorCheckCB cb = new MbVendorCheckCB();
            cb.xsetupForUnion(this); xsyncUQ(cb); unionQuery.Invoke(cb);
		    MbVendorCheckCQ cq = cb.Query(); Query().xsetUnionAllQuery(cq);
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
        protected MbVendorCheckCBSpecification _specification;
        public MbVendorCheckCBSpecification Specify() {
            if (_specification == null) { _specification = new MbVendorCheckCBSpecification(this, new MySpQyCall(this), _forDerivedReferrer, _forScalarSelect, _forScalarCondition, _forColumnQuery); }
            return _specification;
        }
        protected bool HasSpecifiedColumn { get {
            return _specification != null && _specification.IsAlreadySpecifiedRequiredColumn;
        }}
        protected class MySpQyCall : HpSpQyCall<MbVendorCheckCQ> {
			protected MbBsVendorCheckCB _myCB;
			public MySpQyCall(MbBsVendorCheckCB myCB) { _myCB = myCB; }
    		public bool has() { return true; } public MbVendorCheckCQ qy() { return _myCB.Query(); }
    	}

        // [DBFlute-0.8.9.18]
        // ===============================================================================
        //                                                                     ColumnQuery
        //                                                                     ===========
        public HpColQyOperand<MbVendorCheckCB> ColumnQuery(MbSpecifyQuery<MbVendorCheckCB> leftSpecifyQuery) {
            return new HpColQyOperand<MbVendorCheckCB>(delegate(MbSpecifyQuery<MbVendorCheckCB> rightSp, String operand) {
                xcolqy(xcreateColumnQueryCB(), xcreateColumnQueryCB(), leftSpecifyQuery, rightSp, operand);
            });
        }

        protected MbVendorCheckCB xcreateColumnQueryCB() {
            MbVendorCheckCB cb = new MbVendorCheckCB();
            cb.xsetupForColumnQuery((MbVendorCheckCB)this);
            return cb;
        }

        // [DBFlute-0.8.9.9]
        // ===============================================================================
        //                                                                    OrScopeQuery
        //                                                                    ============
        public void OrScopeQuery(MbOrQuery<MbVendorCheckCB> orQuery) {
            xorQ((MbVendorCheckCB)this, orQuery);
        }

        // ===============================================================================
        //                                                                    Purpose Type
        //                                                                    ============
        public void xsetupForColumnQuery(MbVendorCheckCB mainCB) {
            xinheritSubQueryInfo(mainCB.LocalCQ);
            //xchangePurposeSqlClause(HpCBPurpose.COLUMN_QUERY);
            _forColumnQuery = true; // old style

            // inherits a parent query to synchronize real name
            // (and also for suppressing query check) 
            Specify().xsetSyncQyCall(new MbVendorCheckCBColQySpQyCall(mainCB));
        }
    }

    public class MbVendorCheckCBColQySpQyCall : HpSpQyCall<MbVendorCheckCQ> {
        protected MbVendorCheckCB _mainCB;
        public MbVendorCheckCBColQySpQyCall(MbVendorCheckCB mainCB) {
            _mainCB = mainCB;
        }
        public bool has() { return true; } 
        public MbVendorCheckCQ qy() { return _mainCB.Query(); } 
    }

    public class MbVendorCheckCBSpecification : AbstractSpecification<MbVendorCheckCQ> {
        public MbVendorCheckCBSpecification(MbConditionBean baseCB, HpSpQyCall<MbVendorCheckCQ> qyCall
                                                      , bool forDerivedReferrer, bool forScalarSelect, bool forScalarSubQuery, bool forColumnQuery)
        : base(baseCB, qyCall, forDerivedReferrer, forScalarSelect, forScalarSubQuery, forColumnQuery) { }
        public void ColumnVendorCheckId() { doColumn("VENDOR_CHECK_ID"); }
        public void ColumnDecimalDigit() { doColumn("DECIMAL_DIGIT"); }
        public void ColumnIntegerNonDigit() { doColumn("INTEGER_NON_DIGIT"); }
        public void ColumnTypeOfBoolean() { doColumn("TYPE_OF_BOOLEAN"); }
        public void ColumnTypeOfText() { doColumn("TYPE_OF_TEXT"); }
        protected override void doSpecifyRequiredColumn() {
            ColumnVendorCheckId(); // PK
        }
        protected override String getTableDbName() { return "vendor_check"; }
    }
}
