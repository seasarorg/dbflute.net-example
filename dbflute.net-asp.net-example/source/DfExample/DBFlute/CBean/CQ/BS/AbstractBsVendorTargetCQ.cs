
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
    public abstract class AbstractBsVendorTargetCQ : AbstractConditionQuery {

        public AbstractBsVendorTargetCQ(ConditionQuery childQuery, SqlClause sqlClause, String aliasName, int nestLevel)
            : base(childQuery, sqlClause, aliasName, nestLevel) {}

        public override String getTableDbName() { return "VENDOR_TARGET"; }
        public override String getTableSqlName() { return "VENDOR_TARGET"; }

        public void SetVendorTargetId_Equal(long? v) { regVendorTargetId(CK_EQ, v); }
        public void SetVendorTargetId_GreaterThan(long? v) { regVendorTargetId(CK_GT, v); }
        public void SetVendorTargetId_LessThan(long? v) { regVendorTargetId(CK_LT, v); }
        public void SetVendorTargetId_GreaterEqual(long? v) { regVendorTargetId(CK_GE, v); }
        public void SetVendorTargetId_LessEqual(long? v) { regVendorTargetId(CK_LE, v); }
        public void SetVendorTargetId_InScope(IList<long?> ls) { regINS<long?>(CK_INS, cTL<long?>(ls), getCValueVendorTargetId(), "VENDOR_TARGET_ID"); }
        public void SetVendorTargetId_NotInScope(IList<long?> ls) { regINS<long?>(CK_NINS, cTL<long?>(ls), getCValueVendorTargetId(), "VENDOR_TARGET_ID"); }
        public void ExistsVendorRefTargetList(SubQuery<VendorRefTargetCB> subQuery) {
            assertObjectNotNull("subQuery<VendorRefTargetCB>", subQuery);
            VendorRefTargetCB cb = new VendorRefTargetCB(); cb.xsetupForExistsReferrer(this); subQuery.Invoke(cb);
            String subQueryPropertyName = keepVendorTargetId_ExistsSubQuery_VendorRefTargetList(cb.Query());
            registerExistsSubQuery(cb.Query(), "VENDOR_TARGET_ID", "VENDOR_TARGET_ID", subQueryPropertyName);
        }
        public abstract String keepVendorTargetId_ExistsSubQuery_VendorRefTargetList(VendorRefTargetCQ subQuery);
        public void NotExistsVendorRefTargetList(SubQuery<VendorRefTargetCB> subQuery) {
            assertObjectNotNull("subQuery<VendorRefTargetCB>", subQuery);
            VendorRefTargetCB cb = new VendorRefTargetCB(); cb.xsetupForExistsReferrer(this); subQuery.Invoke(cb);
            String subQueryPropertyName = keepVendorTargetId_NotExistsSubQuery_VendorRefTargetList(cb.Query());
            registerNotExistsSubQuery(cb.Query(), "VENDOR_TARGET_ID", "VENDOR_TARGET_ID", subQueryPropertyName);
        }
        public abstract String keepVendorTargetId_NotExistsSubQuery_VendorRefTargetList(VendorRefTargetCQ subQuery);
        public void InScopeVendorRefTargetList(SubQuery<VendorRefTargetCB> subQuery) {
            assertObjectNotNull("subQuery<VendorRefTargetCB>", subQuery);
            VendorRefTargetCB cb = new VendorRefTargetCB(); cb.xsetupForInScopeRelation(this); subQuery.Invoke(cb);
            String subQueryPropertyName = keepVendorTargetId_InScopeSubQuery_VendorRefTargetList(cb.Query());
            registerInScopeSubQuery(cb.Query(), "VENDOR_TARGET_ID", "VENDOR_TARGET_ID", subQueryPropertyName);
        }
        public abstract String keepVendorTargetId_InScopeSubQuery_VendorRefTargetList(VendorRefTargetCQ subQuery);
        public void NotInScopeVendorRefTargetList(SubQuery<VendorRefTargetCB> subQuery) {
            assertObjectNotNull("subQuery<VendorRefTargetCB>", subQuery);
            VendorRefTargetCB cb = new VendorRefTargetCB(); cb.xsetupForInScopeRelation(this); subQuery.Invoke(cb);
            String subQueryPropertyName = keepVendorTargetId_NotInScopeSubQuery_VendorRefTargetList(cb.Query());
            registerNotInScopeSubQuery(cb.Query(), "VENDOR_TARGET_ID", "VENDOR_TARGET_ID", subQueryPropertyName);
        }
        public abstract String keepVendorTargetId_NotInScopeSubQuery_VendorRefTargetList(VendorRefTargetCQ subQuery);
        public void xsderiveVendorRefTargetList(String function, SubQuery<VendorRefTargetCB> subQuery, String aliasName) {
            assertObjectNotNull("subQuery<VendorRefTargetCB>", subQuery);
            VendorRefTargetCB cb = new VendorRefTargetCB(); cb.xsetupForDerivedReferrer(this); subQuery.Invoke(cb);
            String subQueryPropertyName = keepVendorTargetId_SpecifyDerivedReferrer_VendorRefTargetList(cb.Query());
            registerSpecifyDerivedReferrer(function, cb.Query(), "VENDOR_TARGET_ID", "VENDOR_TARGET_ID", subQueryPropertyName, aliasName);
        }
        abstract public String keepVendorTargetId_SpecifyDerivedReferrer_VendorRefTargetList(VendorRefTargetCQ subQuery);

        public QDRFunction<VendorRefTargetCB> DerivedVendorRefTargetList() {
            return xcreateQDRFunctionVendorRefTargetList();
        }
        protected QDRFunction<VendorRefTargetCB> xcreateQDRFunctionVendorRefTargetList() {
            return new QDRFunction<VendorRefTargetCB>(delegate(String function, SubQuery<VendorRefTargetCB> subQuery, String operand, Object value) {
                xqderiveVendorRefTargetList(function, subQuery, operand, value);
            });
        }
        public void xqderiveVendorRefTargetList(String function, SubQuery<VendorRefTargetCB> subQuery, String operand, Object value) {
            assertObjectNotNull("subQuery<VendorRefTargetCB>", subQuery);
            VendorRefTargetCB cb = new VendorRefTargetCB(); cb.xsetupForDerivedReferrer(this); subQuery.Invoke(cb);
            String subQueryPropertyName = keepVendorTargetId_QueryDerivedReferrer_VendorRefTargetList(cb.Query()); // for saving query-value.
            String parameterPropertyName = keepVendorTargetId_QueryDerivedReferrer_VendorRefTargetListParameter(value);
            registerQueryDerivedReferrer(function, cb.Query(), "VENDOR_TARGET_ID", "VENDOR_TARGET_ID", subQueryPropertyName, operand, value, parameterPropertyName);
        }
        public abstract String keepVendorTargetId_QueryDerivedReferrer_VendorRefTargetList(VendorRefTargetCQ subQuery);
        public abstract String keepVendorTargetId_QueryDerivedReferrer_VendorRefTargetListParameter(Object parameterValue);
        public void SetVendorTargetId_IsNull() { regVendorTargetId(CK_ISN, DUMMY_OBJECT); }
        public void SetVendorTargetId_IsNotNull() { regVendorTargetId(CK_ISNN, DUMMY_OBJECT); }
        protected void regVendorTargetId(ConditionKey k, Object v) { regQ(k, v, getCValueVendorTargetId(), "VENDOR_TARGET_ID"); }
        protected abstract ConditionValue getCValueVendorTargetId();

        public void SetVandorTargetName_Equal(String v) { DoSetVandorTargetName_Equal(fRES(v)); }
        protected void DoSetVandorTargetName_Equal(String v) { regVandorTargetName(CK_EQ, v); }
        public void SetVandorTargetName_NotEqual(String v) { DoSetVandorTargetName_NotEqual(fRES(v)); }
        protected void DoSetVandorTargetName_NotEqual(String v) { regVandorTargetName(CK_NES, v); }
        public void SetVandorTargetName_InScope(IList<String> ls) { regINS<String>(CK_INS, cTL<String>(ls), getCValueVandorTargetName(), "VANDOR_TARGET_NAME"); }
        public void SetVandorTargetName_NotInScope(IList<String> ls) { regINS<String>(CK_NINS, cTL<String>(ls), getCValueVandorTargetName(), "VANDOR_TARGET_NAME"); }
        public void SetVandorTargetName_PrefixSearch(String v) { SetVandorTargetName_LikeSearch(v, cLSOP()); }
        public void SetVandorTargetName_LikeSearch(String v, LikeSearchOption option)
        { regLSQ(CK_LS, fRES(v), getCValueVandorTargetName(), "VANDOR_TARGET_NAME", option); }
        public void SetVandorTargetName_NotLikeSearch(String v, LikeSearchOption option)
        { regLSQ(CK_NLS, fRES(v), getCValueVandorTargetName(), "VANDOR_TARGET_NAME", option); }
        public void SetVandorTargetName_IsNull() { regVandorTargetName(CK_ISN, DUMMY_OBJECT); }
        public void SetVandorTargetName_IsNotNull() { regVandorTargetName(CK_ISNN, DUMMY_OBJECT); }
        protected void regVandorTargetName(ConditionKey k, Object v) { regQ(k, v, getCValueVandorTargetName(), "VANDOR_TARGET_NAME"); }
        protected abstract ConditionValue getCValueVandorTargetName();

        // ===================================================================================
        //                                                                    Scalar Condition
        //                                                                    ================
        public SSQFunction<VendorTargetCB> Scalar_Equal() {
            return xcreateSSQFunction("=");
        }

        public SSQFunction<VendorTargetCB> Scalar_NotEqual() {
            return xcreateSSQFunction("<>");
        }

        public SSQFunction<VendorTargetCB> Scalar_GreaterEqual() {
            return xcreateSSQFunction(">=");
        }

        public SSQFunction<VendorTargetCB> Scalar_GreaterThan() {
            return xcreateSSQFunction(">");
        }

        public SSQFunction<VendorTargetCB> Scalar_LessEqual() {
            return xcreateSSQFunction("<=");
        }

        public SSQFunction<VendorTargetCB> Scalar_LessThan() {
            return xcreateSSQFunction("<");
        }

        protected SSQFunction<VendorTargetCB> xcreateSSQFunction(String operand) {
            return new SSQFunction<VendorTargetCB>(delegate(String function, SubQuery<VendorTargetCB> subQuery) {
                xscalarSubQuery(function, subQuery, operand);
            });
        }

        protected void xscalarSubQuery(String function, SubQuery<VendorTargetCB> subQuery, String operand) {
            assertObjectNotNull("subQuery<VendorTargetCB>", subQuery);
            VendorTargetCB cb = new VendorTargetCB(); cb.xsetupForScalarCondition(this); subQuery.Invoke(cb);
            String subQueryPropertyName = keepScalarSubQuery(cb.Query()); // for saving query-value.
            registerScalarSubQuery(function, cb.Query(), subQueryPropertyName, operand);
        }
        public abstract String keepScalarSubQuery(VendorTargetCQ subQuery);

        // ===============================================================================
        //                                                                  MySelf InScope
        //                                                                  ==============
        public void MyselfInScope(SubQuery<VendorTargetCB> subQuery) {
            assertObjectNotNull("subQuery<VendorTargetCB>", subQuery);
            VendorTargetCB cb = new VendorTargetCB(); cb.xsetupForInScopeRelation(this); subQuery.Invoke(cb);
            String subQueryPropertyName = keepMyselfInScopeSubQuery(cb.Query()); // for saving query-value.
            registerInScopeSubQuery(cb.Query(), "VENDOR_TARGET_ID", "VENDOR_TARGET_ID", subQueryPropertyName);
        }
        public abstract String keepMyselfInScopeSubQuery(VendorTargetCQ subQuery);

        public override String ToString() { return xgetSqlClause().getClause(); }
    }
}
