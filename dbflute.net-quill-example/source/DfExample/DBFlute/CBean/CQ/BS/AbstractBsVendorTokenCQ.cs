
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
    public abstract class AbstractBsVendorTokenCQ : AbstractConditionQuery {

        public AbstractBsVendorTokenCQ(ConditionQuery childQuery, SqlClause sqlClause, String aliasName, int nestLevel)
            : base(childQuery, sqlClause, aliasName, nestLevel) {}

        public override String getTableDbName() { return "vendor_token"; }
        public override String getTableSqlName() { return "vendor_token"; }

        public void SetVendorTokenId_Equal(long? v) { regVendorTokenId(CK_EQ, v); }
        public void SetVendorTokenId_NotEqual(long? v) { regVendorTokenId(CK_NES, v); }
        public void SetVendorTokenId_GreaterThan(long? v) { regVendorTokenId(CK_GT, v); }
        public void SetVendorTokenId_LessThan(long? v) { regVendorTokenId(CK_LT, v); }
        public void SetVendorTokenId_GreaterEqual(long? v) { regVendorTokenId(CK_GE, v); }
        public void SetVendorTokenId_LessEqual(long? v) { regVendorTokenId(CK_LE, v); }
        public void SetVendorTokenId_InScope(IList<long?> ls) { regINS<long?>(CK_INS, cTL<long?>(ls), getCValueVendorTokenId(), "VENDOR_TOKEN_ID"); }
        public void SetVendorTokenId_NotInScope(IList<long?> ls) { regINS<long?>(CK_NINS, cTL<long?>(ls), getCValueVendorTokenId(), "VENDOR_TOKEN_ID"); }
        public void SetVendorTokenId_IsNull() { regVendorTokenId(CK_ISN, DUMMY_OBJECT); }
        public void SetVendorTokenId_IsNotNull() { regVendorTokenId(CK_ISNN, DUMMY_OBJECT); }
        protected void regVendorTokenId(ConditionKey k, Object v) { regQ(k, v, getCValueVendorTokenId(), "VENDOR_TOKEN_ID"); }
        protected abstract ConditionValue getCValueVendorTokenId();

        public void SetTokenNumber_Equal(int? v) { regTokenNumber(CK_EQ, v); }
        public void SetTokenNumber_NotEqual(int? v) { regTokenNumber(CK_NES, v); }
        public void SetTokenNumber_GreaterThan(int? v) { regTokenNumber(CK_GT, v); }
        public void SetTokenNumber_LessThan(int? v) { regTokenNumber(CK_LT, v); }
        public void SetTokenNumber_GreaterEqual(int? v) { regTokenNumber(CK_GE, v); }
        public void SetTokenNumber_LessEqual(int? v) { regTokenNumber(CK_LE, v); }
        public void SetTokenNumber_InScope(IList<int?> ls) { regINS<int?>(CK_INS, cTL<int?>(ls), getCValueTokenNumber(), "TOKEN_NUMBER"); }
        public void SetTokenNumber_NotInScope(IList<int?> ls) { regINS<int?>(CK_NINS, cTL<int?>(ls), getCValueTokenNumber(), "TOKEN_NUMBER"); }
        public void SetTokenNumber_IsNull() { regTokenNumber(CK_ISN, DUMMY_OBJECT); }
        public void SetTokenNumber_IsNotNull() { regTokenNumber(CK_ISNN, DUMMY_OBJECT); }
        protected void regTokenNumber(ConditionKey k, Object v) { regQ(k, v, getCValueTokenNumber(), "TOKEN_NUMBER"); }
        protected abstract ConditionValue getCValueTokenNumber();

        public void SetTokenName_Equal(String v) { DoSetTokenName_Equal(fRES(v)); }
        protected void DoSetTokenName_Equal(String v) { regTokenName(CK_EQ, v); }
        public void SetTokenName_NotEqual(String v) { DoSetTokenName_NotEqual(fRES(v)); }
        protected void DoSetTokenName_NotEqual(String v) { regTokenName(CK_NES, v); }
        public void SetTokenName_InScope(IList<String> ls) { regINS<String>(CK_INS, cTL<String>(ls), getCValueTokenName(), "TOKEN_NAME"); }
        public void SetTokenName_NotInScope(IList<String> ls) { regINS<String>(CK_NINS, cTL<String>(ls), getCValueTokenName(), "TOKEN_NAME"); }
        public void SetTokenName_PrefixSearch(String v) { SetTokenName_LikeSearch(v, cLSOP()); }
        public void SetTokenName_LikeSearch(String v, LikeSearchOption option)
        { regLSQ(CK_LS, fRES(v), getCValueTokenName(), "TOKEN_NAME", option); }
        public void SetTokenName_NotLikeSearch(String v, LikeSearchOption option)
        { regLSQ(CK_NLS, fRES(v), getCValueTokenName(), "TOKEN_NAME", option); }
        public void SetTokenName_IsNull() { regTokenName(CK_ISN, DUMMY_OBJECT); }
        public void SetTokenName_IsNotNull() { regTokenName(CK_ISNN, DUMMY_OBJECT); }
        protected void regTokenName(ConditionKey k, Object v) { regQ(k, v, getCValueTokenName(), "TOKEN_NAME"); }
        protected abstract ConditionValue getCValueTokenName();

        // ===================================================================================
        //                                                                    Scalar Condition
        //                                                                    ================
        public SSQFunction<VendorTokenCB> Scalar_Equal() {
            return xcreateSSQFunction("=");
        }

        public SSQFunction<VendorTokenCB> Scalar_NotEqual() {
            return xcreateSSQFunction("<>");
        }

        public SSQFunction<VendorTokenCB> Scalar_GreaterEqual() {
            return xcreateSSQFunction(">=");
        }

        public SSQFunction<VendorTokenCB> Scalar_GreaterThan() {
            return xcreateSSQFunction(">");
        }

        public SSQFunction<VendorTokenCB> Scalar_LessEqual() {
            return xcreateSSQFunction("<=");
        }

        public SSQFunction<VendorTokenCB> Scalar_LessThan() {
            return xcreateSSQFunction("<");
        }

        protected SSQFunction<VendorTokenCB> xcreateSSQFunction(String operand) {
            return new SSQFunction<VendorTokenCB>(delegate(String function, SubQuery<VendorTokenCB> subQuery) {
                xscalarSubQuery(function, subQuery, operand);
            });
        }

        protected void xscalarSubQuery(String function, SubQuery<VendorTokenCB> subQuery, String operand) {
            assertObjectNotNull("subQuery<VendorTokenCB>", subQuery);
            VendorTokenCB cb = new VendorTokenCB(); cb.xsetupForScalarCondition(this); subQuery.Invoke(cb);
            String subQueryPropertyName = keepScalarSubQuery(cb.Query()); // for saving query-value.
            registerScalarSubQuery(function, cb.Query(), subQueryPropertyName, operand);
        }
        public abstract String keepScalarSubQuery(VendorTokenCQ subQuery);

        // ===============================================================================
        //                                                                  MySelf InScope
        //                                                                  ==============
        public void MyselfInScope(SubQuery<VendorTokenCB> subQuery) {
            assertObjectNotNull("subQuery<VendorTokenCB>", subQuery);
            VendorTokenCB cb = new VendorTokenCB(); cb.xsetupForInScopeRelation(this); subQuery.Invoke(cb);
            String subQueryPropertyName = keepMyselfInScopeSubQuery(cb.Query()); // for saving query-value.
            registerInScopeSubQuery(cb.Query(), "VENDOR_TOKEN_ID", "VENDOR_TOKEN_ID", subQueryPropertyName);
        }
        public abstract String keepMyselfInScopeSubQuery(VendorTokenCQ subQuery);

        public override String ToString() { return xgetSqlClause().getClause(); }
    }
}
