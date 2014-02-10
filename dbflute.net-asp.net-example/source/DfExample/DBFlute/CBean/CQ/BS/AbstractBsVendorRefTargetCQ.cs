
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
    public abstract class AbstractBsVendorRefTargetCQ : AbstractConditionQuery {

        public AbstractBsVendorRefTargetCQ(ConditionQuery childQuery, SqlClause sqlClause, String aliasName, int nestLevel)
            : base(childQuery, sqlClause, aliasName, nestLevel) {}

        public override String getTableDbName() { return "VENDOR_REF_TARGET"; }
        public override String getTableSqlName() { return "VENDOR_REF_TARGET"; }

        public void SetVendorRefTargetId_Equal(long? v) { regVendorRefTargetId(CK_EQ, v); }
        public void SetVendorRefTargetId_GreaterThan(long? v) { regVendorRefTargetId(CK_GT, v); }
        public void SetVendorRefTargetId_LessThan(long? v) { regVendorRefTargetId(CK_LT, v); }
        public void SetVendorRefTargetId_GreaterEqual(long? v) { regVendorRefTargetId(CK_GE, v); }
        public void SetVendorRefTargetId_LessEqual(long? v) { regVendorRefTargetId(CK_LE, v); }
        public void SetVendorRefTargetId_InScope(IList<long?> ls) { regINS<long?>(CK_INS, cTL<long?>(ls), getCValueVendorRefTargetId(), "VENDOR_REF_TARGET_ID"); }
        public void SetVendorRefTargetId_NotInScope(IList<long?> ls) { regINS<long?>(CK_NINS, cTL<long?>(ls), getCValueVendorRefTargetId(), "VENDOR_REF_TARGET_ID"); }
        public void SetVendorRefTargetId_IsNull() { regVendorRefTargetId(CK_ISN, DUMMY_OBJECT); }
        public void SetVendorRefTargetId_IsNotNull() { regVendorRefTargetId(CK_ISNN, DUMMY_OBJECT); }
        protected void regVendorRefTargetId(ConditionKey k, Object v) { regQ(k, v, getCValueVendorRefTargetId(), "VENDOR_REF_TARGET_ID"); }
        protected abstract ConditionValue getCValueVendorRefTargetId();

        public void SetVendorTargetId_Equal(long? v) { regVendorTargetId(CK_EQ, v); }
        public void SetVendorTargetId_GreaterThan(long? v) { regVendorTargetId(CK_GT, v); }
        public void SetVendorTargetId_LessThan(long? v) { regVendorTargetId(CK_LT, v); }
        public void SetVendorTargetId_GreaterEqual(long? v) { regVendorTargetId(CK_GE, v); }
        public void SetVendorTargetId_LessEqual(long? v) { regVendorTargetId(CK_LE, v); }
        public void SetVendorTargetId_InScope(IList<long?> ls) { regINS<long?>(CK_INS, cTL<long?>(ls), getCValueVendorTargetId(), "VENDOR_TARGET_ID"); }
        public void SetVendorTargetId_NotInScope(IList<long?> ls) { regINS<long?>(CK_NINS, cTL<long?>(ls), getCValueVendorTargetId(), "VENDOR_TARGET_ID"); }
        public void InScopeVendorTarget(SubQuery<VendorTargetCB> subQuery) {
            assertObjectNotNull("subQuery<VendorTargetCB>", subQuery);
            VendorTargetCB cb = new VendorTargetCB(); cb.xsetupForInScopeRelation(this); subQuery.Invoke(cb);
            String subQueryPropertyName = keepVendorTargetId_InScopeSubQuery_VendorTarget(cb.Query());
            registerInScopeSubQuery(cb.Query(), "VENDOR_TARGET_ID", "VENDOR_TARGET_ID", subQueryPropertyName);
        }
        public abstract String keepVendorTargetId_InScopeSubQuery_VendorTarget(VendorTargetCQ subQuery);
        public void NotInScopeVendorTarget(SubQuery<VendorTargetCB> subQuery) {
            assertObjectNotNull("subQuery<VendorTargetCB>", subQuery);
            VendorTargetCB cb = new VendorTargetCB(); cb.xsetupForInScopeRelation(this); subQuery.Invoke(cb);
            String subQueryPropertyName = keepVendorTargetId_NotInScopeSubQuery_VendorTarget(cb.Query());
            registerNotInScopeSubQuery(cb.Query(), "VENDOR_TARGET_ID", "VENDOR_TARGET_ID", subQueryPropertyName);
        }
        public abstract String keepVendorTargetId_NotInScopeSubQuery_VendorTarget(VendorTargetCQ subQuery);
        protected void regVendorTargetId(ConditionKey k, Object v) { regQ(k, v, getCValueVendorTargetId(), "VENDOR_TARGET_ID"); }
        protected abstract ConditionValue getCValueVendorTargetId();

        // ===================================================================================
        //                                                                    Scalar Condition
        //                                                                    ================
        public SSQFunction<VendorRefTargetCB> Scalar_Equal() {
            return xcreateSSQFunction("=");
        }

        public SSQFunction<VendorRefTargetCB> Scalar_NotEqual() {
            return xcreateSSQFunction("<>");
        }

        public SSQFunction<VendorRefTargetCB> Scalar_GreaterEqual() {
            return xcreateSSQFunction(">=");
        }

        public SSQFunction<VendorRefTargetCB> Scalar_GreaterThan() {
            return xcreateSSQFunction(">");
        }

        public SSQFunction<VendorRefTargetCB> Scalar_LessEqual() {
            return xcreateSSQFunction("<=");
        }

        public SSQFunction<VendorRefTargetCB> Scalar_LessThan() {
            return xcreateSSQFunction("<");
        }

        protected SSQFunction<VendorRefTargetCB> xcreateSSQFunction(String operand) {
            return new SSQFunction<VendorRefTargetCB>(delegate(String function, SubQuery<VendorRefTargetCB> subQuery) {
                xscalarSubQuery(function, subQuery, operand);
            });
        }

        protected void xscalarSubQuery(String function, SubQuery<VendorRefTargetCB> subQuery, String operand) {
            assertObjectNotNull("subQuery<VendorRefTargetCB>", subQuery);
            VendorRefTargetCB cb = new VendorRefTargetCB(); cb.xsetupForScalarCondition(this); subQuery.Invoke(cb);
            String subQueryPropertyName = keepScalarSubQuery(cb.Query()); // for saving query-value.
            registerScalarSubQuery(function, cb.Query(), subQueryPropertyName, operand);
        }
        public abstract String keepScalarSubQuery(VendorRefTargetCQ subQuery);

        // ===============================================================================
        //                                                                  MySelf InScope
        //                                                                  ==============
        public void MyselfInScope(SubQuery<VendorRefTargetCB> subQuery) {
            assertObjectNotNull("subQuery<VendorRefTargetCB>", subQuery);
            VendorRefTargetCB cb = new VendorRefTargetCB(); cb.xsetupForInScopeRelation(this); subQuery.Invoke(cb);
            String subQueryPropertyName = keepMyselfInScopeSubQuery(cb.Query()); // for saving query-value.
            registerInScopeSubQuery(cb.Query(), "VENDOR_REF_TARGET_ID", "VENDOR_REF_TARGET_ID", subQueryPropertyName);
        }
        public abstract String keepMyselfInScopeSubQuery(VendorRefTargetCQ subQuery);

        public override String ToString() { return xgetSqlClause().getClause(); }
    }
}
