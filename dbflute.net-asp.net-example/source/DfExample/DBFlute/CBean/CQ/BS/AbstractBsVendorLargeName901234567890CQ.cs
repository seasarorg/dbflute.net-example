
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
    public abstract class AbstractBsVendorLargeName901234567890CQ : AbstractConditionQuery {

        public AbstractBsVendorLargeName901234567890CQ(ConditionQuery childQuery, SqlClause sqlClause, String aliasName, int nestLevel)
            : base(childQuery, sqlClause, aliasName, nestLevel) {}

        public override String getTableDbName() { return "VENDOR_LARGE_NAME_901234567890"; }
        public override String getTableSqlName() { return "VENDOR_LARGE_NAME_901234567890"; }

        public void SetVendorLargeName901234567Id_Equal(long? v) { regVendorLargeName901234567Id(CK_EQ, v); }
        public void SetVendorLargeName901234567Id_GreaterThan(long? v) { regVendorLargeName901234567Id(CK_GT, v); }
        public void SetVendorLargeName901234567Id_LessThan(long? v) { regVendorLargeName901234567Id(CK_LT, v); }
        public void SetVendorLargeName901234567Id_GreaterEqual(long? v) { regVendorLargeName901234567Id(CK_GE, v); }
        public void SetVendorLargeName901234567Id_LessEqual(long? v) { regVendorLargeName901234567Id(CK_LE, v); }
        public void SetVendorLargeName901234567Id_InScope(IList<long?> ls) { regINS<long?>(CK_INS, cTL<long?>(ls), getCValueVendorLargeName901234567Id(), "VENDOR_LARGE_NAME_901234567_ID"); }
        public void SetVendorLargeName901234567Id_NotInScope(IList<long?> ls) { regINS<long?>(CK_NINS, cTL<long?>(ls), getCValueVendorLargeName901234567Id(), "VENDOR_LARGE_NAME_901234567_ID"); }
        public void ExistsVendorLargeName90123456RefList(SubQuery<VendorLargeName90123456RefCB> subQuery) {
            assertObjectNotNull("subQuery<VendorLargeName90123456RefCB>", subQuery);
            VendorLargeName90123456RefCB cb = new VendorLargeName90123456RefCB(); cb.xsetupForExistsReferrer(this); subQuery.Invoke(cb);
            String subQueryPropertyName = keepVendorLargeName901234567Id_ExistsSubQuery_VendorLargeName90123456RefList(cb.Query());
            registerExistsSubQuery(cb.Query(), "VENDOR_LARGE_NAME_901234567_ID", "VENDOR_LARGE_NAME_901234567_ID", subQueryPropertyName);
        }
        public abstract String keepVendorLargeName901234567Id_ExistsSubQuery_VendorLargeName90123456RefList(VendorLargeName90123456RefCQ subQuery);
        public void NotExistsVendorLargeName90123456RefList(SubQuery<VendorLargeName90123456RefCB> subQuery) {
            assertObjectNotNull("subQuery<VendorLargeName90123456RefCB>", subQuery);
            VendorLargeName90123456RefCB cb = new VendorLargeName90123456RefCB(); cb.xsetupForExistsReferrer(this); subQuery.Invoke(cb);
            String subQueryPropertyName = keepVendorLargeName901234567Id_NotExistsSubQuery_VendorLargeName90123456RefList(cb.Query());
            registerNotExistsSubQuery(cb.Query(), "VENDOR_LARGE_NAME_901234567_ID", "VENDOR_LARGE_NAME_901234567_ID", subQueryPropertyName);
        }
        public abstract String keepVendorLargeName901234567Id_NotExistsSubQuery_VendorLargeName90123456RefList(VendorLargeName90123456RefCQ subQuery);
        public void InScopeVendorLargeName90123456RefList(SubQuery<VendorLargeName90123456RefCB> subQuery) {
            assertObjectNotNull("subQuery<VendorLargeName90123456RefCB>", subQuery);
            VendorLargeName90123456RefCB cb = new VendorLargeName90123456RefCB(); cb.xsetupForInScopeRelation(this); subQuery.Invoke(cb);
            String subQueryPropertyName = keepVendorLargeName901234567Id_InScopeSubQuery_VendorLargeName90123456RefList(cb.Query());
            registerInScopeSubQuery(cb.Query(), "VENDOR_LARGE_NAME_901234567_ID", "VENDOR_LARGE_NAME_901234567_ID", subQueryPropertyName);
        }
        public abstract String keepVendorLargeName901234567Id_InScopeSubQuery_VendorLargeName90123456RefList(VendorLargeName90123456RefCQ subQuery);
        public void NotInScopeVendorLargeName90123456RefList(SubQuery<VendorLargeName90123456RefCB> subQuery) {
            assertObjectNotNull("subQuery<VendorLargeName90123456RefCB>", subQuery);
            VendorLargeName90123456RefCB cb = new VendorLargeName90123456RefCB(); cb.xsetupForInScopeRelation(this); subQuery.Invoke(cb);
            String subQueryPropertyName = keepVendorLargeName901234567Id_NotInScopeSubQuery_VendorLargeName90123456RefList(cb.Query());
            registerNotInScopeSubQuery(cb.Query(), "VENDOR_LARGE_NAME_901234567_ID", "VENDOR_LARGE_NAME_901234567_ID", subQueryPropertyName);
        }
        public abstract String keepVendorLargeName901234567Id_NotInScopeSubQuery_VendorLargeName90123456RefList(VendorLargeName90123456RefCQ subQuery);
        public void xsderiveVendorLargeName90123456RefList(String function, SubQuery<VendorLargeName90123456RefCB> subQuery, String aliasName) {
            assertObjectNotNull("subQuery<VendorLargeName90123456RefCB>", subQuery);
            VendorLargeName90123456RefCB cb = new VendorLargeName90123456RefCB(); cb.xsetupForDerivedReferrer(this); subQuery.Invoke(cb);
            String subQueryPropertyName = keepVendorLargeName901234567Id_SpecifyDerivedReferrer_VendorLargeName90123456RefList(cb.Query());
            registerSpecifyDerivedReferrer(function, cb.Query(), "VENDOR_LARGE_NAME_901234567_ID", "VENDOR_LARGE_NAME_901234567_ID", subQueryPropertyName, aliasName);
        }
        abstract public String keepVendorLargeName901234567Id_SpecifyDerivedReferrer_VendorLargeName90123456RefList(VendorLargeName90123456RefCQ subQuery);

        public QDRFunction<VendorLargeName90123456RefCB> DerivedVendorLargeName90123456RefList() {
            return xcreateQDRFunctionVendorLargeName90123456RefList();
        }
        protected QDRFunction<VendorLargeName90123456RefCB> xcreateQDRFunctionVendorLargeName90123456RefList() {
            return new QDRFunction<VendorLargeName90123456RefCB>(delegate(String function, SubQuery<VendorLargeName90123456RefCB> subQuery, String operand, Object value) {
                xqderiveVendorLargeName90123456RefList(function, subQuery, operand, value);
            });
        }
        public void xqderiveVendorLargeName90123456RefList(String function, SubQuery<VendorLargeName90123456RefCB> subQuery, String operand, Object value) {
            assertObjectNotNull("subQuery<VendorLargeName90123456RefCB>", subQuery);
            VendorLargeName90123456RefCB cb = new VendorLargeName90123456RefCB(); cb.xsetupForDerivedReferrer(this); subQuery.Invoke(cb);
            String subQueryPropertyName = keepVendorLargeName901234567Id_QueryDerivedReferrer_VendorLargeName90123456RefList(cb.Query()); // for saving query-value.
            String parameterPropertyName = keepVendorLargeName901234567Id_QueryDerivedReferrer_VendorLargeName90123456RefListParameter(value);
            registerQueryDerivedReferrer(function, cb.Query(), "VENDOR_LARGE_NAME_901234567_ID", "VENDOR_LARGE_NAME_901234567_ID", subQueryPropertyName, operand, value, parameterPropertyName);
        }
        public abstract String keepVendorLargeName901234567Id_QueryDerivedReferrer_VendorLargeName90123456RefList(VendorLargeName90123456RefCQ subQuery);
        public abstract String keepVendorLargeName901234567Id_QueryDerivedReferrer_VendorLargeName90123456RefListParameter(Object parameterValue);
        public void SetVendorLargeName901234567Id_IsNull() { regVendorLargeName901234567Id(CK_ISN, DUMMY_OBJECT); }
        public void SetVendorLargeName901234567Id_IsNotNull() { regVendorLargeName901234567Id(CK_ISNN, DUMMY_OBJECT); }
        protected void regVendorLargeName901234567Id(ConditionKey k, Object v) { regQ(k, v, getCValueVendorLargeName901234567Id(), "VENDOR_LARGE_NAME_901234567_ID"); }
        protected abstract ConditionValue getCValueVendorLargeName901234567Id();

        public void SetVendorLargeName9012345Name_Equal(String v) { DoSetVendorLargeName9012345Name_Equal(fRES(v)); }
        protected void DoSetVendorLargeName9012345Name_Equal(String v) { regVendorLargeName9012345Name(CK_EQ, v); }
        public void SetVendorLargeName9012345Name_NotEqual(String v) { DoSetVendorLargeName9012345Name_NotEqual(fRES(v)); }
        protected void DoSetVendorLargeName9012345Name_NotEqual(String v) { regVendorLargeName9012345Name(CK_NES, v); }
        public void SetVendorLargeName9012345Name_InScope(IList<String> ls) { regINS<String>(CK_INS, cTL<String>(ls), getCValueVendorLargeName9012345Name(), "VENDOR_LARGE_NAME_9012345_NAME"); }
        public void SetVendorLargeName9012345Name_NotInScope(IList<String> ls) { regINS<String>(CK_NINS, cTL<String>(ls), getCValueVendorLargeName9012345Name(), "VENDOR_LARGE_NAME_9012345_NAME"); }
        public void SetVendorLargeName9012345Name_PrefixSearch(String v) { SetVendorLargeName9012345Name_LikeSearch(v, cLSOP()); }
        public void SetVendorLargeName9012345Name_LikeSearch(String v, LikeSearchOption option)
        { regLSQ(CK_LS, fRES(v), getCValueVendorLargeName9012345Name(), "VENDOR_LARGE_NAME_9012345_NAME", option); }
        public void SetVendorLargeName9012345Name_NotLikeSearch(String v, LikeSearchOption option)
        { regLSQ(CK_NLS, fRES(v), getCValueVendorLargeName9012345Name(), "VENDOR_LARGE_NAME_9012345_NAME", option); }
        protected void regVendorLargeName9012345Name(ConditionKey k, Object v) { regQ(k, v, getCValueVendorLargeName9012345Name(), "VENDOR_LARGE_NAME_9012345_NAME"); }
        protected abstract ConditionValue getCValueVendorLargeName9012345Name();

        // ===================================================================================
        //                                                                    Scalar Condition
        //                                                                    ================
        public SSQFunction<VendorLargeName901234567890CB> Scalar_Equal() {
            return xcreateSSQFunction("=");
        }

        public SSQFunction<VendorLargeName901234567890CB> Scalar_NotEqual() {
            return xcreateSSQFunction("<>");
        }

        public SSQFunction<VendorLargeName901234567890CB> Scalar_GreaterEqual() {
            return xcreateSSQFunction(">=");
        }

        public SSQFunction<VendorLargeName901234567890CB> Scalar_GreaterThan() {
            return xcreateSSQFunction(">");
        }

        public SSQFunction<VendorLargeName901234567890CB> Scalar_LessEqual() {
            return xcreateSSQFunction("<=");
        }

        public SSQFunction<VendorLargeName901234567890CB> Scalar_LessThan() {
            return xcreateSSQFunction("<");
        }

        protected SSQFunction<VendorLargeName901234567890CB> xcreateSSQFunction(String operand) {
            return new SSQFunction<VendorLargeName901234567890CB>(delegate(String function, SubQuery<VendorLargeName901234567890CB> subQuery) {
                xscalarSubQuery(function, subQuery, operand);
            });
        }

        protected void xscalarSubQuery(String function, SubQuery<VendorLargeName901234567890CB> subQuery, String operand) {
            assertObjectNotNull("subQuery<VendorLargeName901234567890CB>", subQuery);
            VendorLargeName901234567890CB cb = new VendorLargeName901234567890CB(); cb.xsetupForScalarCondition(this); subQuery.Invoke(cb);
            String subQueryPropertyName = keepScalarSubQuery(cb.Query()); // for saving query-value.
            registerScalarSubQuery(function, cb.Query(), subQueryPropertyName, operand);
        }
        public abstract String keepScalarSubQuery(VendorLargeName901234567890CQ subQuery);

        // ===============================================================================
        //                                                                  MySelf InScope
        //                                                                  ==============
        public void MyselfInScope(SubQuery<VendorLargeName901234567890CB> subQuery) {
            assertObjectNotNull("subQuery<VendorLargeName901234567890CB>", subQuery);
            VendorLargeName901234567890CB cb = new VendorLargeName901234567890CB(); cb.xsetupForInScopeRelation(this); subQuery.Invoke(cb);
            String subQueryPropertyName = keepMyselfInScopeSubQuery(cb.Query()); // for saving query-value.
            registerInScopeSubQuery(cb.Query(), "VENDOR_LARGE_NAME_901234567_ID", "VENDOR_LARGE_NAME_901234567_ID", subQueryPropertyName);
        }
        public abstract String keepMyselfInScopeSubQuery(VendorLargeName901234567890CQ subQuery);

        public override String ToString() { return xgetSqlClause().getClause(); }
    }
}
