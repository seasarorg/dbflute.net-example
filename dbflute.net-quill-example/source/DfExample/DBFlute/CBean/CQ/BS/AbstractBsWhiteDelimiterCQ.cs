
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
    public abstract class AbstractBsWhiteDelimiterCQ : AbstractConditionQuery {

        public AbstractBsWhiteDelimiterCQ(ConditionQuery childQuery, SqlClause sqlClause, String aliasName, int nestLevel)
            : base(childQuery, sqlClause, aliasName, nestLevel) {}

        public override String getTableDbName() { return "white_delimiter"; }
        public override String getTableSqlName() { return "white_delimiter"; }

        public void SetDelimiterId_Equal(long? v) { regDelimiterId(CK_EQ, v); }
        public void SetDelimiterId_NotEqual(long? v) { regDelimiterId(CK_NES, v); }
        public void SetDelimiterId_GreaterThan(long? v) { regDelimiterId(CK_GT, v); }
        public void SetDelimiterId_LessThan(long? v) { regDelimiterId(CK_LT, v); }
        public void SetDelimiterId_GreaterEqual(long? v) { regDelimiterId(CK_GE, v); }
        public void SetDelimiterId_LessEqual(long? v) { regDelimiterId(CK_LE, v); }
        public void SetDelimiterId_InScope(IList<long?> ls) { regINS<long?>(CK_INS, cTL<long?>(ls), getCValueDelimiterId(), "DELIMITER_ID"); }
        public void SetDelimiterId_NotInScope(IList<long?> ls) { regINS<long?>(CK_NINS, cTL<long?>(ls), getCValueDelimiterId(), "DELIMITER_ID"); }
        public void SetDelimiterId_IsNull() { regDelimiterId(CK_ISN, DUMMY_OBJECT); }
        public void SetDelimiterId_IsNotNull() { regDelimiterId(CK_ISNN, DUMMY_OBJECT); }
        protected void regDelimiterId(ConditionKey k, Object v) { regQ(k, v, getCValueDelimiterId(), "DELIMITER_ID"); }
        protected abstract ConditionValue getCValueDelimiterId();

        public void SetNumberNullable_Equal(int? v) { regNumberNullable(CK_EQ, v); }
        public void SetNumberNullable_NotEqual(int? v) { regNumberNullable(CK_NES, v); }
        public void SetNumberNullable_GreaterThan(int? v) { regNumberNullable(CK_GT, v); }
        public void SetNumberNullable_LessThan(int? v) { regNumberNullable(CK_LT, v); }
        public void SetNumberNullable_GreaterEqual(int? v) { regNumberNullable(CK_GE, v); }
        public void SetNumberNullable_LessEqual(int? v) { regNumberNullable(CK_LE, v); }
        public void SetNumberNullable_InScope(IList<int?> ls) { regINS<int?>(CK_INS, cTL<int?>(ls), getCValueNumberNullable(), "NUMBER_NULLABLE"); }
        public void SetNumberNullable_NotInScope(IList<int?> ls) { regINS<int?>(CK_NINS, cTL<int?>(ls), getCValueNumberNullable(), "NUMBER_NULLABLE"); }
        public void SetNumberNullable_IsNull() { regNumberNullable(CK_ISN, DUMMY_OBJECT); }
        public void SetNumberNullable_IsNotNull() { regNumberNullable(CK_ISNN, DUMMY_OBJECT); }
        protected void regNumberNullable(ConditionKey k, Object v) { regQ(k, v, getCValueNumberNullable(), "NUMBER_NULLABLE"); }
        protected abstract ConditionValue getCValueNumberNullable();

        public void SetStringConverted_Equal(String v) { DoSetStringConverted_Equal(fRES(v)); }
        protected void DoSetStringConverted_Equal(String v) { regStringConverted(CK_EQ, v); }
        public void SetStringConverted_NotEqual(String v) { DoSetStringConverted_NotEqual(fRES(v)); }
        protected void DoSetStringConverted_NotEqual(String v) { regStringConverted(CK_NES, v); }
        public void SetStringConverted_InScope(IList<String> ls) { regINS<String>(CK_INS, cTL<String>(ls), getCValueStringConverted(), "STRING_CONVERTED"); }
        public void SetStringConverted_NotInScope(IList<String> ls) { regINS<String>(CK_NINS, cTL<String>(ls), getCValueStringConverted(), "STRING_CONVERTED"); }
        public void SetStringConverted_PrefixSearch(String v) { SetStringConverted_LikeSearch(v, cLSOP()); }
        public void SetStringConverted_LikeSearch(String v, LikeSearchOption option)
        { regLSQ(CK_LS, fRES(v), getCValueStringConverted(), "STRING_CONVERTED", option); }
        public void SetStringConverted_NotLikeSearch(String v, LikeSearchOption option)
        { regLSQ(CK_NLS, fRES(v), getCValueStringConverted(), "STRING_CONVERTED", option); }
        protected void regStringConverted(ConditionKey k, Object v) { regQ(k, v, getCValueStringConverted(), "STRING_CONVERTED"); }
        protected abstract ConditionValue getCValueStringConverted();

        public void SetStringNonConverted_Equal(String v) { DoSetStringNonConverted_Equal(fRES(v)); }
        protected void DoSetStringNonConverted_Equal(String v) { regStringNonConverted(CK_EQ, v); }
        public void SetStringNonConverted_NotEqual(String v) { DoSetStringNonConverted_NotEqual(fRES(v)); }
        protected void DoSetStringNonConverted_NotEqual(String v) { regStringNonConverted(CK_NES, v); }
        public void SetStringNonConverted_InScope(IList<String> ls) { regINS<String>(CK_INS, cTL<String>(ls), getCValueStringNonConverted(), "STRING_NON_CONVERTED"); }
        public void SetStringNonConverted_NotInScope(IList<String> ls) { regINS<String>(CK_NINS, cTL<String>(ls), getCValueStringNonConverted(), "STRING_NON_CONVERTED"); }
        public void SetStringNonConverted_PrefixSearch(String v) { SetStringNonConverted_LikeSearch(v, cLSOP()); }
        public void SetStringNonConverted_LikeSearch(String v, LikeSearchOption option)
        { regLSQ(CK_LS, fRES(v), getCValueStringNonConverted(), "STRING_NON_CONVERTED", option); }
        public void SetStringNonConverted_NotLikeSearch(String v, LikeSearchOption option)
        { regLSQ(CK_NLS, fRES(v), getCValueStringNonConverted(), "STRING_NON_CONVERTED", option); }
        public void SetStringNonConverted_IsNull() { regStringNonConverted(CK_ISN, DUMMY_OBJECT); }
        public void SetStringNonConverted_IsNotNull() { regStringNonConverted(CK_ISNN, DUMMY_OBJECT); }
        protected void regStringNonConverted(ConditionKey k, Object v) { regQ(k, v, getCValueStringNonConverted(), "STRING_NON_CONVERTED"); }
        protected abstract ConditionValue getCValueStringNonConverted();

        public void SetDateDefault_Equal(DateTime? v) { regDateDefault(CK_EQ, v); }
        public void SetDateDefault_GreaterThan(DateTime? v) { regDateDefault(CK_GT, v); }
        public void SetDateDefault_LessThan(DateTime? v) { regDateDefault(CK_LT, v); }
        public void SetDateDefault_GreaterEqual(DateTime? v) { regDateDefault(CK_GE, v); }
        public void SetDateDefault_LessEqual(DateTime? v) { regDateDefault(CK_LE, v); }
        public void SetDateDefault_FromTo(DateTime? from, DateTime? to, FromToOption option)
        { regFTQ(from, to, getCValueDateDefault(), "DATE_DEFAULT", option); }
        public void SetDateDefault_DateFromTo(DateTime? from, DateTime? to) { SetDateDefault_FromTo(from, to, new DateFromToOption()); }
        public void SetDateDefault_InScope(IList<DateTime?> ls) { regINS<DateTime?>(CK_INS, cTL<DateTime?>(ls), getCValueDateDefault(), "DATE_DEFAULT"); }
        public void SetDateDefault_NotInScope(IList<DateTime?> ls) { regINS<DateTime?>(CK_NINS, cTL<DateTime?>(ls), getCValueDateDefault(), "DATE_DEFAULT"); }
        protected void regDateDefault(ConditionKey k, Object v) { regQ(k, v, getCValueDateDefault(), "DATE_DEFAULT"); }
        protected abstract ConditionValue getCValueDateDefault();

        // ===================================================================================
        //                                                                    Scalar Condition
        //                                                                    ================
        public SSQFunction<WhiteDelimiterCB> Scalar_Equal() {
            return xcreateSSQFunction("=");
        }

        public SSQFunction<WhiteDelimiterCB> Scalar_NotEqual() {
            return xcreateSSQFunction("<>");
        }

        public SSQFunction<WhiteDelimiterCB> Scalar_GreaterEqual() {
            return xcreateSSQFunction(">=");
        }

        public SSQFunction<WhiteDelimiterCB> Scalar_GreaterThan() {
            return xcreateSSQFunction(">");
        }

        public SSQFunction<WhiteDelimiterCB> Scalar_LessEqual() {
            return xcreateSSQFunction("<=");
        }

        public SSQFunction<WhiteDelimiterCB> Scalar_LessThan() {
            return xcreateSSQFunction("<");
        }

        protected SSQFunction<WhiteDelimiterCB> xcreateSSQFunction(String operand) {
            return new SSQFunction<WhiteDelimiterCB>(delegate(String function, SubQuery<WhiteDelimiterCB> subQuery) {
                xscalarSubQuery(function, subQuery, operand);
            });
        }

        protected void xscalarSubQuery(String function, SubQuery<WhiteDelimiterCB> subQuery, String operand) {
            assertObjectNotNull("subQuery<WhiteDelimiterCB>", subQuery);
            WhiteDelimiterCB cb = new WhiteDelimiterCB(); cb.xsetupForScalarCondition(this); subQuery.Invoke(cb);
            String subQueryPropertyName = keepScalarSubQuery(cb.Query()); // for saving query-value.
            registerScalarSubQuery(function, cb.Query(), subQueryPropertyName, operand);
        }
        public abstract String keepScalarSubQuery(WhiteDelimiterCQ subQuery);

        // ===============================================================================
        //                                                                  MySelf InScope
        //                                                                  ==============
        public void MyselfInScope(SubQuery<WhiteDelimiterCB> subQuery) {
            assertObjectNotNull("subQuery<WhiteDelimiterCB>", subQuery);
            WhiteDelimiterCB cb = new WhiteDelimiterCB(); cb.xsetupForInScopeRelation(this); subQuery.Invoke(cb);
            String subQueryPropertyName = keepMyselfInScopeSubQuery(cb.Query()); // for saving query-value.
            registerInScopeSubQuery(cb.Query(), "DELIMITER_ID", "DELIMITER_ID", subQueryPropertyName);
        }
        public abstract String keepMyselfInScopeSubQuery(WhiteDelimiterCQ subQuery);

        public override String ToString() { return xgetSqlClause().getClause(); }
    }
}
