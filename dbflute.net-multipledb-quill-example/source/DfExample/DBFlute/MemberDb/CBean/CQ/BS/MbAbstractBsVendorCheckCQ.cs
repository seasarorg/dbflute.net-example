
using System;
using System.Collections.Generic;

using DfExample.DBFlute.MemberDb.AllCommon;
using DfExample.DBFlute.MemberDb.AllCommon.CBean;
using DfExample.DBFlute.MemberDb.AllCommon.CBean.CKey;
using DfExample.DBFlute.MemberDb.AllCommon.CBean.COption;
using DfExample.DBFlute.MemberDb.AllCommon.CBean.CValue;
using DfExample.DBFlute.MemberDb.AllCommon.CBean.SClause;

namespace DfExample.DBFlute.MemberDb.CBean.CQ.BS {

    [System.Serializable]
    public abstract class MbAbstractBsVendorCheckCQ : MbAbstractConditionQuery {

        public MbAbstractBsVendorCheckCQ(MbConditionQuery childQuery, MbSqlClause sqlClause, String aliasName, int nestLevel)
            : base(childQuery, sqlClause, aliasName, nestLevel) {}

        public override String getTableDbName() { return "vendor_check"; }
        public override String getTableSqlName() { return "vendor_check"; }

        public void SetVendorCheckId_Equal(long? v) { regVendorCheckId(CK_EQ, v); }
        public void SetVendorCheckId_GreaterThan(long? v) { regVendorCheckId(CK_GT, v); }
        public void SetVendorCheckId_LessThan(long? v) { regVendorCheckId(CK_LT, v); }
        public void SetVendorCheckId_GreaterEqual(long? v) { regVendorCheckId(CK_GE, v); }
        public void SetVendorCheckId_LessEqual(long? v) { regVendorCheckId(CK_LE, v); }
        public void SetVendorCheckId_InScope(IList<long?> ls) { regINS<long?>(CK_INS, cTL<long?>(ls), getCValueVendorCheckId(), "VENDOR_CHECK_ID"); }
        public void SetVendorCheckId_NotInScope(IList<long?> ls) { regINS<long?>(CK_NINS, cTL<long?>(ls), getCValueVendorCheckId(), "VENDOR_CHECK_ID"); }
        public void SetVendorCheckId_IsNull() { regVendorCheckId(CK_ISN, DUMMY_OBJECT); }
        public void SetVendorCheckId_IsNotNull() { regVendorCheckId(CK_ISNN, DUMMY_OBJECT); }
        protected void regVendorCheckId(MbConditionKey k, Object v) { regQ(k, v, getCValueVendorCheckId(), "VENDOR_CHECK_ID"); }
        protected abstract MbConditionValue getCValueVendorCheckId();

        public void SetDecimalDigit_Equal(decimal? v) { regDecimalDigit(CK_EQ, v); }
        public void SetDecimalDigit_GreaterThan(decimal? v) { regDecimalDigit(CK_GT, v); }
        public void SetDecimalDigit_LessThan(decimal? v) { regDecimalDigit(CK_LT, v); }
        public void SetDecimalDigit_GreaterEqual(decimal? v) { regDecimalDigit(CK_GE, v); }
        public void SetDecimalDigit_LessEqual(decimal? v) { regDecimalDigit(CK_LE, v); }
        public void SetDecimalDigit_InScope(IList<decimal?> ls) { regINS<decimal?>(CK_INS, cTL<decimal?>(ls), getCValueDecimalDigit(), "DECIMAL_DIGIT"); }
        public void SetDecimalDigit_NotInScope(IList<decimal?> ls) { regINS<decimal?>(CK_NINS, cTL<decimal?>(ls), getCValueDecimalDigit(), "DECIMAL_DIGIT"); }
        protected void regDecimalDigit(MbConditionKey k, Object v) { regQ(k, v, getCValueDecimalDigit(), "DECIMAL_DIGIT"); }
        protected abstract MbConditionValue getCValueDecimalDigit();

        public void SetIntegerNonDigit_Equal(int? v) { regIntegerNonDigit(CK_EQ, v); }
        public void SetIntegerNonDigit_GreaterThan(int? v) { regIntegerNonDigit(CK_GT, v); }
        public void SetIntegerNonDigit_LessThan(int? v) { regIntegerNonDigit(CK_LT, v); }
        public void SetIntegerNonDigit_GreaterEqual(int? v) { regIntegerNonDigit(CK_GE, v); }
        public void SetIntegerNonDigit_LessEqual(int? v) { regIntegerNonDigit(CK_LE, v); }
        public void SetIntegerNonDigit_InScope(IList<int?> ls) { regINS<int?>(CK_INS, cTL<int?>(ls), getCValueIntegerNonDigit(), "INTEGER_NON_DIGIT"); }
        public void SetIntegerNonDigit_NotInScope(IList<int?> ls) { regINS<int?>(CK_NINS, cTL<int?>(ls), getCValueIntegerNonDigit(), "INTEGER_NON_DIGIT"); }
        protected void regIntegerNonDigit(MbConditionKey k, Object v) { regQ(k, v, getCValueIntegerNonDigit(), "INTEGER_NON_DIGIT"); }
        protected abstract MbConditionValue getCValueIntegerNonDigit();

        public void SetTypeOfBoolean_Equal(bool? v) { regTypeOfBoolean(CK_EQ, v); }
        protected void regTypeOfBoolean(MbConditionKey k, Object v) { regQ(k, v, getCValueTypeOfBoolean(), "TYPE_OF_BOOLEAN"); }
        protected abstract MbConditionValue getCValueTypeOfBoolean();

        public void SetTypeOfText_Equal(String v) { DoSetTypeOfText_Equal(fRES(v)); }
        protected void DoSetTypeOfText_Equal(String v) { regTypeOfText(CK_EQ, v); }
        public void SetTypeOfText_NotEqual(String v) { DoSetTypeOfText_NotEqual(fRES(v)); }
        protected void DoSetTypeOfText_NotEqual(String v) { regTypeOfText(CK_NES, v); }
        public void SetTypeOfText_InScope(IList<String> ls) { regINS<String>(CK_INS, cTL<String>(ls), getCValueTypeOfText(), "TYPE_OF_TEXT"); }
        public void SetTypeOfText_NotInScope(IList<String> ls) { regINS<String>(CK_NINS, cTL<String>(ls), getCValueTypeOfText(), "TYPE_OF_TEXT"); }
        public void SetTypeOfText_PrefixSearch(String v) { SetTypeOfText_LikeSearch(v, cLSOP()); }
        public void SetTypeOfText_LikeSearch(String v, MbLikeSearchOption option)
        { regLSQ(CK_LS, fRES(v), getCValueTypeOfText(), "TYPE_OF_TEXT", option); }
        public void SetTypeOfText_NotLikeSearch(String v, MbLikeSearchOption option)
        { regLSQ(CK_NLS, fRES(v), getCValueTypeOfText(), "TYPE_OF_TEXT", option); }
        public void SetTypeOfText_IsNull() { regTypeOfText(CK_ISN, DUMMY_OBJECT); }
        public void SetTypeOfText_IsNotNull() { regTypeOfText(CK_ISNN, DUMMY_OBJECT); }
        protected void regTypeOfText(MbConditionKey k, Object v) { regQ(k, v, getCValueTypeOfText(), "TYPE_OF_TEXT"); }
        protected abstract MbConditionValue getCValueTypeOfText();

        // ===================================================================================
        //                                                                    Scalar Condition
        //                                                                    ================
        public SSQFunction<MbVendorCheckCB> Scalar_Equal() {
            return xcreateSSQFunction("=");
        }

        public SSQFunction<MbVendorCheckCB> Scalar_NotEqual() {
            return xcreateSSQFunction("<>");
        }

        public SSQFunction<MbVendorCheckCB> Scalar_GreaterEqual() {
            return xcreateSSQFunction(">=");
        }

        public SSQFunction<MbVendorCheckCB> Scalar_GreaterThan() {
            return xcreateSSQFunction(">");
        }

        public SSQFunction<MbVendorCheckCB> Scalar_LessEqual() {
            return xcreateSSQFunction("<=");
        }

        public SSQFunction<MbVendorCheckCB> Scalar_LessThan() {
            return xcreateSSQFunction("<");
        }

        protected SSQFunction<MbVendorCheckCB> xcreateSSQFunction(String operand) {
            return new SSQFunction<MbVendorCheckCB>(delegate(String function, MbSubQuery<MbVendorCheckCB> subQuery) {
                xscalarSubQuery(function, subQuery, operand);
            });
        }

        protected void xscalarSubQuery(String function, MbSubQuery<MbVendorCheckCB> subQuery, String operand) {
            assertObjectNotNull("subQuery<MbVendorCheckCB>", subQuery);
            MbVendorCheckCB cb = new MbVendorCheckCB(); cb.xsetupForScalarCondition(this); subQuery.Invoke(cb);
            String subQueryPropertyName = keepScalarSubQuery(cb.Query()); // for saving query-value.
            registerScalarSubQuery(function, cb.Query(), subQueryPropertyName, operand);
        }
        public abstract String keepScalarSubQuery(MbVendorCheckCQ subQuery);

        // ===============================================================================
        //                                                                  MySelf InScope
        //                                                                  ==============
        public void MyselfInScope(MbSubQuery<MbVendorCheckCB> subQuery) {
            assertObjectNotNull("subQuery<MbVendorCheckCB>", subQuery);
            MbVendorCheckCB cb = new MbVendorCheckCB(); cb.xsetupForInScopeRelation(this); subQuery.Invoke(cb);
            String subQueryPropertyName = keepMyselfInScopeSubQuery(cb.Query()); // for saving query-value.
            registerInScopeSubQuery(cb.Query(), "VENDOR_CHECK_ID", "VENDOR_CHECK_ID", subQueryPropertyName);
        }
        public abstract String keepMyselfInScopeSubQuery(MbVendorCheckCQ subQuery);

        public override String ToString() { return xgetSqlClause().getClause(); }
    }
}
