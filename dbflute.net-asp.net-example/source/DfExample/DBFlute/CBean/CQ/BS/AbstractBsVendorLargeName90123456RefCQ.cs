
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
    public abstract class AbstractBsVendorLargeName90123456RefCQ : AbstractConditionQuery {

        public AbstractBsVendorLargeName90123456RefCQ(ConditionQuery childQuery, SqlClause sqlClause, String aliasName, int nestLevel)
            : base(childQuery, sqlClause, aliasName, nestLevel) {}

        public override String getTableDbName() { return "VENDOR_LARGE_NAME_90123456_REF"; }
        public override String getTableSqlName() { return "VENDOR_LARGE_NAME_90123456_REF"; }

        public void SetVendorLargeName90123RefId_Equal(long? v) { regVendorLargeName90123RefId(CK_EQ, v); }
        public void SetVendorLargeName90123RefId_GreaterThan(long? v) { regVendorLargeName90123RefId(CK_GT, v); }
        public void SetVendorLargeName90123RefId_LessThan(long? v) { regVendorLargeName90123RefId(CK_LT, v); }
        public void SetVendorLargeName90123RefId_GreaterEqual(long? v) { regVendorLargeName90123RefId(CK_GE, v); }
        public void SetVendorLargeName90123RefId_LessEqual(long? v) { regVendorLargeName90123RefId(CK_LE, v); }
        public void SetVendorLargeName90123RefId_InScope(IList<long?> ls) { regINS<long?>(CK_INS, cTL<long?>(ls), getCValueVendorLargeName90123RefId(), "VENDOR_LARGE_NAME_90123_REF_ID"); }
        public void SetVendorLargeName90123RefId_NotInScope(IList<long?> ls) { regINS<long?>(CK_NINS, cTL<long?>(ls), getCValueVendorLargeName90123RefId(), "VENDOR_LARGE_NAME_90123_REF_ID"); }
        public void SetVendorLargeName90123RefId_IsNull() { regVendorLargeName90123RefId(CK_ISN, DUMMY_OBJECT); }
        public void SetVendorLargeName90123RefId_IsNotNull() { regVendorLargeName90123RefId(CK_ISNN, DUMMY_OBJECT); }
        protected void regVendorLargeName90123RefId(ConditionKey k, Object v) { regQ(k, v, getCValueVendorLargeName90123RefId(), "VENDOR_LARGE_NAME_90123_REF_ID"); }
        protected abstract ConditionValue getCValueVendorLargeName90123RefId();

        public void SetVendorLargeName901RefName_Equal(String v) { DoSetVendorLargeName901RefName_Equal(fRES(v)); }
        protected void DoSetVendorLargeName901RefName_Equal(String v) { regVendorLargeName901RefName(CK_EQ, v); }
        public void SetVendorLargeName901RefName_NotEqual(String v) { DoSetVendorLargeName901RefName_NotEqual(fRES(v)); }
        protected void DoSetVendorLargeName901RefName_NotEqual(String v) { regVendorLargeName901RefName(CK_NES, v); }
        public void SetVendorLargeName901RefName_InScope(IList<String> ls) { regINS<String>(CK_INS, cTL<String>(ls), getCValueVendorLargeName901RefName(), "VENDOR_LARGE_NAME_901_REF_NAME"); }
        public void SetVendorLargeName901RefName_NotInScope(IList<String> ls) { regINS<String>(CK_NINS, cTL<String>(ls), getCValueVendorLargeName901RefName(), "VENDOR_LARGE_NAME_901_REF_NAME"); }
        public void SetVendorLargeName901RefName_PrefixSearch(String v) { SetVendorLargeName901RefName_LikeSearch(v, cLSOP()); }
        public void SetVendorLargeName901RefName_LikeSearch(String v, LikeSearchOption option)
        { regLSQ(CK_LS, fRES(v), getCValueVendorLargeName901RefName(), "VENDOR_LARGE_NAME_901_REF_NAME", option); }
        public void SetVendorLargeName901RefName_NotLikeSearch(String v, LikeSearchOption option)
        { regLSQ(CK_NLS, fRES(v), getCValueVendorLargeName901RefName(), "VENDOR_LARGE_NAME_901_REF_NAME", option); }
        protected void regVendorLargeName901RefName(ConditionKey k, Object v) { regQ(k, v, getCValueVendorLargeName901RefName(), "VENDOR_LARGE_NAME_901_REF_NAME"); }
        protected abstract ConditionValue getCValueVendorLargeName901RefName();

        public void SetVendorLargeName901234567Id_Equal(long? v) { regVendorLargeName901234567Id(CK_EQ, v); }
        public void SetVendorLargeName901234567Id_GreaterThan(long? v) { regVendorLargeName901234567Id(CK_GT, v); }
        public void SetVendorLargeName901234567Id_LessThan(long? v) { regVendorLargeName901234567Id(CK_LT, v); }
        public void SetVendorLargeName901234567Id_GreaterEqual(long? v) { regVendorLargeName901234567Id(CK_GE, v); }
        public void SetVendorLargeName901234567Id_LessEqual(long? v) { regVendorLargeName901234567Id(CK_LE, v); }
        public void SetVendorLargeName901234567Id_InScope(IList<long?> ls) { regINS<long?>(CK_INS, cTL<long?>(ls), getCValueVendorLargeName901234567Id(), "VENDOR_LARGE_NAME_901234567_ID"); }
        public void SetVendorLargeName901234567Id_NotInScope(IList<long?> ls) { regINS<long?>(CK_NINS, cTL<long?>(ls), getCValueVendorLargeName901234567Id(), "VENDOR_LARGE_NAME_901234567_ID"); }
        public void InScopeVendorLargeName901234567890(SubQuery<VendorLargeName901234567890CB> subQuery) {
            assertObjectNotNull("subQuery<VendorLargeName901234567890CB>", subQuery);
            VendorLargeName901234567890CB cb = new VendorLargeName901234567890CB(); cb.xsetupForInScopeRelation(this); subQuery.Invoke(cb);
            String subQueryPropertyName = keepVendorLargeName901234567Id_InScopeSubQuery_VendorLargeName901234567890(cb.Query());
            registerInScopeSubQuery(cb.Query(), "VENDOR_LARGE_NAME_901234567_ID", "VENDOR_LARGE_NAME_901234567_ID", subQueryPropertyName);
        }
        public abstract String keepVendorLargeName901234567Id_InScopeSubQuery_VendorLargeName901234567890(VendorLargeName901234567890CQ subQuery);
        public void NotInScopeVendorLargeName901234567890(SubQuery<VendorLargeName901234567890CB> subQuery) {
            assertObjectNotNull("subQuery<VendorLargeName901234567890CB>", subQuery);
            VendorLargeName901234567890CB cb = new VendorLargeName901234567890CB(); cb.xsetupForInScopeRelation(this); subQuery.Invoke(cb);
            String subQueryPropertyName = keepVendorLargeName901234567Id_NotInScopeSubQuery_VendorLargeName901234567890(cb.Query());
            registerNotInScopeSubQuery(cb.Query(), "VENDOR_LARGE_NAME_901234567_ID", "VENDOR_LARGE_NAME_901234567_ID", subQueryPropertyName);
        }
        public abstract String keepVendorLargeName901234567Id_NotInScopeSubQuery_VendorLargeName901234567890(VendorLargeName901234567890CQ subQuery);
        public void SetVendorLargeName901234567Id_IsNull() { regVendorLargeName901234567Id(CK_ISN, DUMMY_OBJECT); }
        public void SetVendorLargeName901234567Id_IsNotNull() { regVendorLargeName901234567Id(CK_ISNN, DUMMY_OBJECT); }
        protected void regVendorLargeName901234567Id(ConditionKey k, Object v) { regQ(k, v, getCValueVendorLargeName901234567Id(), "VENDOR_LARGE_NAME_901234567_ID"); }
        protected abstract ConditionValue getCValueVendorLargeName901234567Id();

        // ===================================================================================
        //                                                                    Scalar Condition
        //                                                                    ================
        public SSQFunction<VendorLargeName90123456RefCB> Scalar_Equal() {
            return xcreateSSQFunction("=");
        }

        public SSQFunction<VendorLargeName90123456RefCB> Scalar_NotEqual() {
            return xcreateSSQFunction("<>");
        }

        public SSQFunction<VendorLargeName90123456RefCB> Scalar_GreaterEqual() {
            return xcreateSSQFunction(">=");
        }

        public SSQFunction<VendorLargeName90123456RefCB> Scalar_GreaterThan() {
            return xcreateSSQFunction(">");
        }

        public SSQFunction<VendorLargeName90123456RefCB> Scalar_LessEqual() {
            return xcreateSSQFunction("<=");
        }

        public SSQFunction<VendorLargeName90123456RefCB> Scalar_LessThan() {
            return xcreateSSQFunction("<");
        }

        protected SSQFunction<VendorLargeName90123456RefCB> xcreateSSQFunction(String operand) {
            return new SSQFunction<VendorLargeName90123456RefCB>(delegate(String function, SubQuery<VendorLargeName90123456RefCB> subQuery) {
                xscalarSubQuery(function, subQuery, operand);
            });
        }

        protected void xscalarSubQuery(String function, SubQuery<VendorLargeName90123456RefCB> subQuery, String operand) {
            assertObjectNotNull("subQuery<VendorLargeName90123456RefCB>", subQuery);
            VendorLargeName90123456RefCB cb = new VendorLargeName90123456RefCB(); cb.xsetupForScalarCondition(this); subQuery.Invoke(cb);
            String subQueryPropertyName = keepScalarSubQuery(cb.Query()); // for saving query-value.
            registerScalarSubQuery(function, cb.Query(), subQueryPropertyName, operand);
        }
        public abstract String keepScalarSubQuery(VendorLargeName90123456RefCQ subQuery);

        // ===============================================================================
        //                                                                  MySelf InScope
        //                                                                  ==============
        public void MyselfInScope(SubQuery<VendorLargeName90123456RefCB> subQuery) {
            assertObjectNotNull("subQuery<VendorLargeName90123456RefCB>", subQuery);
            VendorLargeName90123456RefCB cb = new VendorLargeName90123456RefCB(); cb.xsetupForInScopeRelation(this); subQuery.Invoke(cb);
            String subQueryPropertyName = keepMyselfInScopeSubQuery(cb.Query()); // for saving query-value.
            registerInScopeSubQuery(cb.Query(), "VENDOR_LARGE_NAME_90123_REF_ID", "VENDOR_LARGE_NAME_90123_REF_ID", subQueryPropertyName);
        }
        public abstract String keepMyselfInScopeSubQuery(VendorLargeName90123456RefCQ subQuery);

        public override String ToString() { return xgetSqlClause().getClause(); }
    }
}
