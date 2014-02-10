
using System;
using System.Collections.Generic;

using DfExample.DBFlute.AllCommon;
using DfExample.DBFlute.AllCommon.CBean;
using DfExample.DBFlute.AllCommon.CBean.CKey;
using DfExample.DBFlute.AllCommon.CBean.COption;
using DfExample.DBFlute.AllCommon.CBean.CValue;
using DfExample.DBFlute.AllCommon.CBean.SClause;

namespace DfExample.DBFlute.CBean.CQ.BS {

    [System.Serializable]
    public abstract class AbstractBsVendorRefExceptCQ : AbstractConditionQuery {

        public AbstractBsVendorRefExceptCQ(ConditionQuery childQuery, SqlClause sqlClause, String aliasName, int nestLevel)
            : base(childQuery, sqlClause, aliasName, nestLevel) {}

        public override String getTableDbName() { return "VENDOR_REF_EXCEPT"; }
        public override String getTableSqlName() { return "VENDOR_REF_EXCEPT"; }

        public void SetVendorRefExceptId_Equal(long? v) { regVendorRefExceptId(CK_EQ, v); }
        public void SetVendorRefExceptId_GreaterThan(long? v) { regVendorRefExceptId(CK_GT, v); }
        public void SetVendorRefExceptId_LessThan(long? v) { regVendorRefExceptId(CK_LT, v); }
        public void SetVendorRefExceptId_GreaterEqual(long? v) { regVendorRefExceptId(CK_GE, v); }
        public void SetVendorRefExceptId_LessEqual(long? v) { regVendorRefExceptId(CK_LE, v); }
        public void SetVendorRefExceptId_InScope(IList<long?> ls) { regINS<long?>(CK_INS, cTL<long?>(ls), getCValueVendorRefExceptId(), "VENDOR_REF_EXCEPT_ID"); }
        public void SetVendorRefExceptId_NotInScope(IList<long?> ls) { regINS<long?>(CK_NINS, cTL<long?>(ls), getCValueVendorRefExceptId(), "VENDOR_REF_EXCEPT_ID"); }
        public void SetVendorRefExceptId_IsNull() { regVendorRefExceptId(CK_ISN, DUMMY_OBJECT); }
        public void SetVendorRefExceptId_IsNotNull() { regVendorRefExceptId(CK_ISNN, DUMMY_OBJECT); }
        protected void regVendorRefExceptId(ConditionKey k, Object v) { regQ(k, v, getCValueVendorRefExceptId(), "VENDOR_REF_EXCEPT_ID"); }
        protected abstract ConditionValue getCValueVendorRefExceptId();

        public void SetVendorExceptId_Equal(long? v) { regVendorExceptId(CK_EQ, v); }
        public void SetVendorExceptId_GreaterThan(long? v) { regVendorExceptId(CK_GT, v); }
        public void SetVendorExceptId_LessThan(long? v) { regVendorExceptId(CK_LT, v); }
        public void SetVendorExceptId_GreaterEqual(long? v) { regVendorExceptId(CK_GE, v); }
        public void SetVendorExceptId_LessEqual(long? v) { regVendorExceptId(CK_LE, v); }
        public void SetVendorExceptId_InScope(IList<long?> ls) { regINS<long?>(CK_INS, cTL<long?>(ls), getCValueVendorExceptId(), "VENDOR_EXCEPT_ID"); }
        public void SetVendorExceptId_NotInScope(IList<long?> ls) { regINS<long?>(CK_NINS, cTL<long?>(ls), getCValueVendorExceptId(), "VENDOR_EXCEPT_ID"); }
        public void InScopeVendorExcept(SubQuery<VendorExceptCB> subQuery) {
            assertObjectNotNull("subQuery<VendorExceptCB>", subQuery);
            VendorExceptCB cb = new VendorExceptCB(); cb.xsetupForInScopeRelation(this); subQuery.Invoke(cb);
            String subQueryPropertyName = keepVendorExceptId_InScopeSubQuery_VendorExcept(cb.Query());
            registerInScopeSubQuery(cb.Query(), "VENDOR_EXCEPT_ID", "VENDOR_EXCEPT_ID", subQueryPropertyName);
        }
        public abstract String keepVendorExceptId_InScopeSubQuery_VendorExcept(VendorExceptCQ subQuery);
        public void NotInScopeVendorExcept(SubQuery<VendorExceptCB> subQuery) {
            assertObjectNotNull("subQuery<VendorExceptCB>", subQuery);
            VendorExceptCB cb = new VendorExceptCB(); cb.xsetupForInScopeRelation(this); subQuery.Invoke(cb);
            String subQueryPropertyName = keepVendorExceptId_NotInScopeSubQuery_VendorExcept(cb.Query());
            registerNotInScopeSubQuery(cb.Query(), "VENDOR_EXCEPT_ID", "VENDOR_EXCEPT_ID", subQueryPropertyName);
        }
        public abstract String keepVendorExceptId_NotInScopeSubQuery_VendorExcept(VendorExceptCQ subQuery);
        protected void regVendorExceptId(ConditionKey k, Object v) { regQ(k, v, getCValueVendorExceptId(), "VENDOR_EXCEPT_ID"); }
        protected abstract ConditionValue getCValueVendorExceptId();

        // ===================================================================================
        //                                                                    Scalar Condition
        //                                                                    ================
        public SSQFunction<VendorRefExceptCB> Scalar_Equal() {
            return xcreateSSQFunction("=");
        }

        public SSQFunction<VendorRefExceptCB> Scalar_NotEqual() {
            return xcreateSSQFunction("<>");
        }

        public SSQFunction<VendorRefExceptCB> Scalar_GreaterEqual() {
            return xcreateSSQFunction(">=");
        }

        public SSQFunction<VendorRefExceptCB> Scalar_GreaterThan() {
            return xcreateSSQFunction(">");
        }

        public SSQFunction<VendorRefExceptCB> Scalar_LessEqual() {
            return xcreateSSQFunction("<=");
        }

        public SSQFunction<VendorRefExceptCB> Scalar_LessThan() {
            return xcreateSSQFunction("<");
        }

        protected SSQFunction<VendorRefExceptCB> xcreateSSQFunction(String operand) {
            return new SSQFunction<VendorRefExceptCB>(delegate(String function, SubQuery<VendorRefExceptCB> subQuery) {
                xscalarSubQuery(function, subQuery, operand);
            });
        }

        protected void xscalarSubQuery(String function, SubQuery<VendorRefExceptCB> subQuery, String operand) {
            assertObjectNotNull("subQuery<VendorRefExceptCB>", subQuery);
            VendorRefExceptCB cb = new VendorRefExceptCB(); cb.xsetupForScalarCondition(this); subQuery.Invoke(cb);
            String subQueryPropertyName = keepScalarSubQuery(cb.Query()); // for saving query-value.
            registerScalarSubQuery(function, cb.Query(), subQueryPropertyName, operand);
        }
        public abstract String keepScalarSubQuery(VendorRefExceptCQ subQuery);

        // ===============================================================================
        //                                                                  MySelf InScope
        //                                                                  ==============
        public void MyselfInScope(SubQuery<VendorRefExceptCB> subQuery) {
            assertObjectNotNull("subQuery<VendorRefExceptCB>", subQuery);
            VendorRefExceptCB cb = new VendorRefExceptCB(); cb.xsetupForInScopeRelation(this); subQuery.Invoke(cb);
            String subQueryPropertyName = keepMyselfInScopeSubQuery(cb.Query()); // for saving query-value.
            registerInScopeSubQuery(cb.Query(), "VENDOR_REF_EXCEPT_ID", "VENDOR_REF_EXCEPT_ID", subQueryPropertyName);
        }
        public abstract String keepMyselfInScopeSubQuery(VendorRefExceptCQ subQuery);

        public override String ToString() { return xgetSqlClause().getClause(); }
    }
}
