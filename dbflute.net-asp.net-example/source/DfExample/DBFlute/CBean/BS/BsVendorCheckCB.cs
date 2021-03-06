
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
    public class BsVendorCheckCB : AbstractConditionBean {

        // ===============================================================================
        //                                                                       Attribute
        //                                                                       =========
        protected VendorCheckCQ _conditionQuery;

        // ===============================================================================
        //                                                                      Table Name
        //                                                                      ==========
        public override String TableDbName { get { return "VENDOR_CHECK"; } }

        // ===============================================================================
        //                                                             PrimaryKey Handling
        //                                                             ===================
        public void AcceptPrimaryKey(long? vendorCheckId) {
            assertObjectNotNull("vendorCheckId", vendorCheckId);
            BsVendorCheckCB cb = this;
            cb.Query().SetVendorCheckId_Equal(vendorCheckId);
        }

        public override ConditionBean AddOrderBy_PK_Asc() {
            Query().AddOrderBy_VendorCheckId_Asc();
            return this;
        }

        public override ConditionBean AddOrderBy_PK_Desc() {
            Query().AddOrderBy_VendorCheckId_Desc();
            return this;
        }

        // ===============================================================================
        //                                                                           Query
        //                                                                           =====
        public VendorCheckCQ Query() {
            return this.ConditionQuery;
        }

        public VendorCheckCQ ConditionQuery {
            get {
                if (_conditionQuery == null) {
                    _conditionQuery = CreateLocalCQ();
                }
                return _conditionQuery;
            }
        }

        protected virtual VendorCheckCQ CreateLocalCQ() {
            return xcreateCQ(null, this.SqlClause, this.SqlClause.getBasePointAliasName(), 0);
        }

        protected virtual VendorCheckCQ xcreateCQ(ConditionQuery childQuery, SqlClause sqlClause, String aliasName, int nestLevel) {
            return new VendorCheckCQ(childQuery, sqlClause, aliasName, nestLevel);
        }

        public override ConditionQuery LocalCQ {
            get { return this.ConditionQuery; }
        }

        // ===============================================================================
        //                                                                           Union
        //                                                                           =====
	    public virtual void Union(UnionQuery<VendorCheckCB> unionQuery) {
            VendorCheckCB cb = new VendorCheckCB();
            cb.xsetupForUnion(this); xsyncUQ(cb); unionQuery.Invoke(cb);
		    VendorCheckCQ cq = cb.Query(); Query().xsetUnionQuery(cq);
        }

	    public virtual void UnionAll(UnionQuery<VendorCheckCB> unionQuery) {
            VendorCheckCB cb = new VendorCheckCB();
            cb.xsetupForUnion(this); xsyncUQ(cb); unionQuery.Invoke(cb);
		    VendorCheckCQ cq = cb.Query(); Query().xsetUnionAllQuery(cq);
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
        protected VendorCheckCBSpecification _specification;
        public VendorCheckCBSpecification Specify() {
            if (_specification == null) { _specification = new VendorCheckCBSpecification(this, new MySpQyCall(this), _forDerivedReferrer, _forScalarSelect, _forScalarCondition, _forColumnQuery); }
            return _specification;
        }
        protected bool HasSpecifiedColumn { get {
            return _specification != null && _specification.IsAlreadySpecifiedRequiredColumn;
        }}
        protected class MySpQyCall : HpSpQyCall<VendorCheckCQ> {
			protected BsVendorCheckCB _myCB;
			public MySpQyCall(BsVendorCheckCB myCB) { _myCB = myCB; }
    		public bool has() { return true; } public VendorCheckCQ qy() { return _myCB.Query(); }
    	}

        // [DBFlute-0.8.9.18]
        // ===============================================================================
        //                                                                     ColumnQuery
        //                                                                     ===========
        public HpColQyOperand<VendorCheckCB> ColumnQuery(SpecifyQuery<VendorCheckCB> leftSpecifyQuery) {
            return new HpColQyOperand<VendorCheckCB>(delegate(SpecifyQuery<VendorCheckCB> rightSp, String operand) {
                xcolqy(xcreateColumnQueryCB(), xcreateColumnQueryCB(), leftSpecifyQuery, rightSp, operand);
            });
        }

        protected VendorCheckCB xcreateColumnQueryCB() {
            VendorCheckCB cb = new VendorCheckCB();
            cb.xsetupForColumnQuery((VendorCheckCB)this);
            return cb;
        }

        // [DBFlute-0.8.9.9]
        // ===============================================================================
        //                                                                    OrScopeQuery
        //                                                                    ============
        public void OrScopeQuery(OrQuery<VendorCheckCB> orQuery) {
            xorQ((VendorCheckCB)this, orQuery);
        }

        // ===============================================================================
        //                                                                    Purpose Type
        //                                                                    ============
        public void xsetupForColumnQuery(VendorCheckCB mainCB) {
            xinheritSubQueryInfo(mainCB.LocalCQ);
            //xchangePurposeSqlClause(HpCBPurpose.COLUMN_QUERY);
            _forColumnQuery = true; // old style

            // inherits a parent query to synchronize real name
            // (and also for suppressing query check) 
            Specify().xsetSyncQyCall(new VendorCheckCBColQySpQyCall(mainCB));
        }
    }

    public class VendorCheckCBColQySpQyCall : HpSpQyCall<VendorCheckCQ> {
        protected VendorCheckCB _mainCB;
        public VendorCheckCBColQySpQyCall(VendorCheckCB mainCB) {
            _mainCB = mainCB;
        }
        public bool has() { return true; } 
        public VendorCheckCQ qy() { return _mainCB.Query(); } 
    }

    public class VendorCheckCBSpecification : AbstractSpecification<VendorCheckCQ> {
        public VendorCheckCBSpecification(ConditionBean baseCB, HpSpQyCall<VendorCheckCQ> qyCall
                                                      , bool forDerivedReferrer, bool forScalarSelect, bool forScalarSubQuery, bool forColumnQuery)
        : base(baseCB, qyCall, forDerivedReferrer, forScalarSelect, forScalarSubQuery, forColumnQuery) { }
        public void ColumnVendorCheckId() { doColumn("VENDOR_CHECK_ID"); }
        public void ColumnDecimalDigit() { doColumn("DECIMAL_DIGIT"); }
        public void ColumnIntegerNonDigit() { doColumn("INTEGER_NON_DIGIT"); }
        public void ColumnLargeCharacter() { doColumn("LARGE_CHARACTER"); }
        public void ColumnTypeOfChar() { doColumn("TYPE_OF_CHAR"); }
        public void ColumnTypeOfNchar() { doColumn("TYPE_OF_NCHAR"); }
        public void ColumnTypeOfVarchar2() { doColumn("TYPE_OF_VARCHAR2"); }
        public void ColumnTypeOfVarchar2Max() { doColumn("TYPE_OF_VARCHAR2_MAX"); }
        public void ColumnTypeOfNvarchar2() { doColumn("TYPE_OF_NVARCHAR2"); }
        public void ColumnTypeOfClob() { doColumn("TYPE_OF_CLOB"); }
        public void ColumnTypeOfNclob() { doColumn("TYPE_OF_NCLOB"); }
        public void ColumnTypeOfDate() { doColumn("TYPE_OF_DATE"); }
        public void ColumnTypeOfTimestamp() { doColumn("TYPE_OF_TIMESTAMP"); }
        public void ColumnTypeOfBlob() { doColumn("TYPE_OF_BLOB"); }
        public void ColumnTypeOfRaw() { doColumn("TYPE_OF_RAW"); }
        public void ColumnTypeOfBfile() { doColumn("TYPE_OF_BFILE"); }
        protected override void doSpecifyRequiredColumn() {
            ColumnVendorCheckId(); // PK
        }
        protected override String getTableDbName() { return "VENDOR_CHECK"; }
    }
}
