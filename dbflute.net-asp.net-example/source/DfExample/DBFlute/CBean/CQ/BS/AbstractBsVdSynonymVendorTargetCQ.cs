
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
    public abstract class AbstractBsVdSynonymVendorTargetCQ : AbstractConditionQuery {

        public AbstractBsVdSynonymVendorTargetCQ(ConditionQuery childQuery, SqlClause sqlClause, String aliasName, int nestLevel)
            : base(childQuery, sqlClause, aliasName, nestLevel) {}

        public override String getTableDbName() { return "VD_SYNONYM_VENDOR_TARGET"; }
        public override String getTableSqlName() { return "VD_SYNONYM_VENDOR_TARGET"; }

        public void SetVendorTargetId_Equal(long? v) { regVendorTargetId(CK_EQ, v); }
        public void SetVendorTargetId_GreaterThan(long? v) { regVendorTargetId(CK_GT, v); }
        public void SetVendorTargetId_LessThan(long? v) { regVendorTargetId(CK_LT, v); }
        public void SetVendorTargetId_GreaterEqual(long? v) { regVendorTargetId(CK_GE, v); }
        public void SetVendorTargetId_LessEqual(long? v) { regVendorTargetId(CK_LE, v); }
        public void SetVendorTargetId_InScope(IList<long?> ls) { regINS<long?>(CK_INS, cTL<long?>(ls), getCValueVendorTargetId(), "VENDOR_TARGET_ID"); }
        public void SetVendorTargetId_NotInScope(IList<long?> ls) { regINS<long?>(CK_NINS, cTL<long?>(ls), getCValueVendorTargetId(), "VENDOR_TARGET_ID"); }
        public void ExistsVdSynonymVendorRefTargetList(SubQuery<VdSynonymVendorRefTargetCB> subQuery) {
            assertObjectNotNull("subQuery<VdSynonymVendorRefTargetCB>", subQuery);
            VdSynonymVendorRefTargetCB cb = new VdSynonymVendorRefTargetCB(); cb.xsetupForExistsReferrer(this); subQuery.Invoke(cb);
            String subQueryPropertyName = keepVendorTargetId_ExistsSubQuery_VdSynonymVendorRefTargetList(cb.Query());
            registerExistsSubQuery(cb.Query(), "VENDOR_TARGET_ID", "VENDOR_TARGET_ID", subQueryPropertyName);
        }
        public abstract String keepVendorTargetId_ExistsSubQuery_VdSynonymVendorRefTargetList(VdSynonymVendorRefTargetCQ subQuery);
        public void NotExistsVdSynonymVendorRefTargetList(SubQuery<VdSynonymVendorRefTargetCB> subQuery) {
            assertObjectNotNull("subQuery<VdSynonymVendorRefTargetCB>", subQuery);
            VdSynonymVendorRefTargetCB cb = new VdSynonymVendorRefTargetCB(); cb.xsetupForExistsReferrer(this); subQuery.Invoke(cb);
            String subQueryPropertyName = keepVendorTargetId_NotExistsSubQuery_VdSynonymVendorRefTargetList(cb.Query());
            registerNotExistsSubQuery(cb.Query(), "VENDOR_TARGET_ID", "VENDOR_TARGET_ID", subQueryPropertyName);
        }
        public abstract String keepVendorTargetId_NotExistsSubQuery_VdSynonymVendorRefTargetList(VdSynonymVendorRefTargetCQ subQuery);
        public void InScopeVdSynonymVendorRefTargetList(SubQuery<VdSynonymVendorRefTargetCB> subQuery) {
            assertObjectNotNull("subQuery<VdSynonymVendorRefTargetCB>", subQuery);
            VdSynonymVendorRefTargetCB cb = new VdSynonymVendorRefTargetCB(); cb.xsetupForInScopeRelation(this); subQuery.Invoke(cb);
            String subQueryPropertyName = keepVendorTargetId_InScopeSubQuery_VdSynonymVendorRefTargetList(cb.Query());
            registerInScopeSubQuery(cb.Query(), "VENDOR_TARGET_ID", "VENDOR_TARGET_ID", subQueryPropertyName);
        }
        public abstract String keepVendorTargetId_InScopeSubQuery_VdSynonymVendorRefTargetList(VdSynonymVendorRefTargetCQ subQuery);
        public void NotInScopeVdSynonymVendorRefTargetList(SubQuery<VdSynonymVendorRefTargetCB> subQuery) {
            assertObjectNotNull("subQuery<VdSynonymVendorRefTargetCB>", subQuery);
            VdSynonymVendorRefTargetCB cb = new VdSynonymVendorRefTargetCB(); cb.xsetupForInScopeRelation(this); subQuery.Invoke(cb);
            String subQueryPropertyName = keepVendorTargetId_NotInScopeSubQuery_VdSynonymVendorRefTargetList(cb.Query());
            registerNotInScopeSubQuery(cb.Query(), "VENDOR_TARGET_ID", "VENDOR_TARGET_ID", subQueryPropertyName);
        }
        public abstract String keepVendorTargetId_NotInScopeSubQuery_VdSynonymVendorRefTargetList(VdSynonymVendorRefTargetCQ subQuery);
        public void xsderiveVdSynonymVendorRefTargetList(String function, SubQuery<VdSynonymVendorRefTargetCB> subQuery, String aliasName) {
            assertObjectNotNull("subQuery<VdSynonymVendorRefTargetCB>", subQuery);
            VdSynonymVendorRefTargetCB cb = new VdSynonymVendorRefTargetCB(); cb.xsetupForDerivedReferrer(this); subQuery.Invoke(cb);
            String subQueryPropertyName = keepVendorTargetId_SpecifyDerivedReferrer_VdSynonymVendorRefTargetList(cb.Query());
            registerSpecifyDerivedReferrer(function, cb.Query(), "VENDOR_TARGET_ID", "VENDOR_TARGET_ID", subQueryPropertyName, aliasName);
        }
        abstract public String keepVendorTargetId_SpecifyDerivedReferrer_VdSynonymVendorRefTargetList(VdSynonymVendorRefTargetCQ subQuery);

        public QDRFunction<VdSynonymVendorRefTargetCB> DerivedVdSynonymVendorRefTargetList() {
            return xcreateQDRFunctionVdSynonymVendorRefTargetList();
        }
        protected QDRFunction<VdSynonymVendorRefTargetCB> xcreateQDRFunctionVdSynonymVendorRefTargetList() {
            return new QDRFunction<VdSynonymVendorRefTargetCB>(delegate(String function, SubQuery<VdSynonymVendorRefTargetCB> subQuery, String operand, Object value) {
                xqderiveVdSynonymVendorRefTargetList(function, subQuery, operand, value);
            });
        }
        public void xqderiveVdSynonymVendorRefTargetList(String function, SubQuery<VdSynonymVendorRefTargetCB> subQuery, String operand, Object value) {
            assertObjectNotNull("subQuery<VdSynonymVendorRefTargetCB>", subQuery);
            VdSynonymVendorRefTargetCB cb = new VdSynonymVendorRefTargetCB(); cb.xsetupForDerivedReferrer(this); subQuery.Invoke(cb);
            String subQueryPropertyName = keepVendorTargetId_QueryDerivedReferrer_VdSynonymVendorRefTargetList(cb.Query()); // for saving query-value.
            String parameterPropertyName = keepVendorTargetId_QueryDerivedReferrer_VdSynonymVendorRefTargetListParameter(value);
            registerQueryDerivedReferrer(function, cb.Query(), "VENDOR_TARGET_ID", "VENDOR_TARGET_ID", subQueryPropertyName, operand, value, parameterPropertyName);
        }
        public abstract String keepVendorTargetId_QueryDerivedReferrer_VdSynonymVendorRefTargetList(VdSynonymVendorRefTargetCQ subQuery);
        public abstract String keepVendorTargetId_QueryDerivedReferrer_VdSynonymVendorRefTargetListParameter(Object parameterValue);
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
        public SSQFunction<VdSynonymVendorTargetCB> Scalar_Equal() {
            return xcreateSSQFunction("=");
        }

        public SSQFunction<VdSynonymVendorTargetCB> Scalar_NotEqual() {
            return xcreateSSQFunction("<>");
        }

        public SSQFunction<VdSynonymVendorTargetCB> Scalar_GreaterEqual() {
            return xcreateSSQFunction(">=");
        }

        public SSQFunction<VdSynonymVendorTargetCB> Scalar_GreaterThan() {
            return xcreateSSQFunction(">");
        }

        public SSQFunction<VdSynonymVendorTargetCB> Scalar_LessEqual() {
            return xcreateSSQFunction("<=");
        }

        public SSQFunction<VdSynonymVendorTargetCB> Scalar_LessThan() {
            return xcreateSSQFunction("<");
        }

        protected SSQFunction<VdSynonymVendorTargetCB> xcreateSSQFunction(String operand) {
            return new SSQFunction<VdSynonymVendorTargetCB>(delegate(String function, SubQuery<VdSynonymVendorTargetCB> subQuery) {
                xscalarSubQuery(function, subQuery, operand);
            });
        }

        protected void xscalarSubQuery(String function, SubQuery<VdSynonymVendorTargetCB> subQuery, String operand) {
            assertObjectNotNull("subQuery<VdSynonymVendorTargetCB>", subQuery);
            VdSynonymVendorTargetCB cb = new VdSynonymVendorTargetCB(); cb.xsetupForScalarCondition(this); subQuery.Invoke(cb);
            String subQueryPropertyName = keepScalarSubQuery(cb.Query()); // for saving query-value.
            registerScalarSubQuery(function, cb.Query(), subQueryPropertyName, operand);
        }
        public abstract String keepScalarSubQuery(VdSynonymVendorTargetCQ subQuery);

        // ===============================================================================
        //                                                                  MySelf InScope
        //                                                                  ==============
        public void MyselfInScope(SubQuery<VdSynonymVendorTargetCB> subQuery) {
            assertObjectNotNull("subQuery<VdSynonymVendorTargetCB>", subQuery);
            VdSynonymVendorTargetCB cb = new VdSynonymVendorTargetCB(); cb.xsetupForInScopeRelation(this); subQuery.Invoke(cb);
            String subQueryPropertyName = keepMyselfInScopeSubQuery(cb.Query()); // for saving query-value.
            registerInScopeSubQuery(cb.Query(), "VENDOR_TARGET_ID", "VENDOR_TARGET_ID", subQueryPropertyName);
        }
        public abstract String keepMyselfInScopeSubQuery(VdSynonymVendorTargetCQ subQuery);

        public override String ToString() { return xgetSqlClause().getClause(); }
    }
}
