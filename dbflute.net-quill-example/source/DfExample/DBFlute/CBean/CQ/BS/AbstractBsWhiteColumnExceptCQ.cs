
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
    public abstract class AbstractBsWhiteColumnExceptCQ : AbstractConditionQuery {

        public AbstractBsWhiteColumnExceptCQ(ConditionQuery childQuery, SqlClause sqlClause, String aliasName, int nestLevel)
            : base(childQuery, sqlClause, aliasName, nestLevel) {}

        public override String getTableDbName() { return "white_column_except"; }
        public override String getTableSqlName() { return "white_column_except"; }

        public void SetExceptColumnId_Equal(long? v) { regExceptColumnId(CK_EQ, v); }
        public void SetExceptColumnId_NotEqual(long? v) { regExceptColumnId(CK_NES, v); }
        public void SetExceptColumnId_GreaterThan(long? v) { regExceptColumnId(CK_GT, v); }
        public void SetExceptColumnId_LessThan(long? v) { regExceptColumnId(CK_LT, v); }
        public void SetExceptColumnId_GreaterEqual(long? v) { regExceptColumnId(CK_GE, v); }
        public void SetExceptColumnId_LessEqual(long? v) { regExceptColumnId(CK_LE, v); }
        public void SetExceptColumnId_InScope(IList<long?> ls) { regINS<long?>(CK_INS, cTL<long?>(ls), getCValueExceptColumnId(), "EXCEPT_COLUMN_ID"); }
        public void SetExceptColumnId_NotInScope(IList<long?> ls) { regINS<long?>(CK_NINS, cTL<long?>(ls), getCValueExceptColumnId(), "EXCEPT_COLUMN_ID"); }
        public void SetExceptColumnId_IsNull() { regExceptColumnId(CK_ISN, DUMMY_OBJECT); }
        public void SetExceptColumnId_IsNotNull() { regExceptColumnId(CK_ISNN, DUMMY_OBJECT); }
        protected void regExceptColumnId(ConditionKey k, Object v) { regQ(k, v, getCValueExceptColumnId(), "EXCEPT_COLUMN_ID"); }
        protected abstract ConditionValue getCValueExceptColumnId();

        public void SetColumnExceptTest_Equal(int? v) { regColumnExceptTest(CK_EQ, v); }
        public void SetColumnExceptTest_NotEqual(int? v) { regColumnExceptTest(CK_NES, v); }
        public void SetColumnExceptTest_GreaterThan(int? v) { regColumnExceptTest(CK_GT, v); }
        public void SetColumnExceptTest_LessThan(int? v) { regColumnExceptTest(CK_LT, v); }
        public void SetColumnExceptTest_GreaterEqual(int? v) { regColumnExceptTest(CK_GE, v); }
        public void SetColumnExceptTest_LessEqual(int? v) { regColumnExceptTest(CK_LE, v); }
        public void SetColumnExceptTest_InScope(IList<int?> ls) { regINS<int?>(CK_INS, cTL<int?>(ls), getCValueColumnExceptTest(), "COLUMN_EXCEPT_TEST"); }
        public void SetColumnExceptTest_NotInScope(IList<int?> ls) { regINS<int?>(CK_NINS, cTL<int?>(ls), getCValueColumnExceptTest(), "COLUMN_EXCEPT_TEST"); }
        public void SetColumnExceptTest_IsNull() { regColumnExceptTest(CK_ISN, DUMMY_OBJECT); }
        public void SetColumnExceptTest_IsNotNull() { regColumnExceptTest(CK_ISNN, DUMMY_OBJECT); }
        protected void regColumnExceptTest(ConditionKey k, Object v) { regQ(k, v, getCValueColumnExceptTest(), "COLUMN_EXCEPT_TEST"); }
        protected abstract ConditionValue getCValueColumnExceptTest();

        // ===================================================================================
        //                                                                    Scalar Condition
        //                                                                    ================
        public SSQFunction<WhiteColumnExceptCB> Scalar_Equal() {
            return xcreateSSQFunction("=");
        }

        public SSQFunction<WhiteColumnExceptCB> Scalar_NotEqual() {
            return xcreateSSQFunction("<>");
        }

        public SSQFunction<WhiteColumnExceptCB> Scalar_GreaterEqual() {
            return xcreateSSQFunction(">=");
        }

        public SSQFunction<WhiteColumnExceptCB> Scalar_GreaterThan() {
            return xcreateSSQFunction(">");
        }

        public SSQFunction<WhiteColumnExceptCB> Scalar_LessEqual() {
            return xcreateSSQFunction("<=");
        }

        public SSQFunction<WhiteColumnExceptCB> Scalar_LessThan() {
            return xcreateSSQFunction("<");
        }

        protected SSQFunction<WhiteColumnExceptCB> xcreateSSQFunction(String operand) {
            return new SSQFunction<WhiteColumnExceptCB>(delegate(String function, SubQuery<WhiteColumnExceptCB> subQuery) {
                xscalarSubQuery(function, subQuery, operand);
            });
        }

        protected void xscalarSubQuery(String function, SubQuery<WhiteColumnExceptCB> subQuery, String operand) {
            assertObjectNotNull("subQuery<WhiteColumnExceptCB>", subQuery);
            WhiteColumnExceptCB cb = new WhiteColumnExceptCB(); cb.xsetupForScalarCondition(this); subQuery.Invoke(cb);
            String subQueryPropertyName = keepScalarSubQuery(cb.Query()); // for saving query-value.
            registerScalarSubQuery(function, cb.Query(), subQueryPropertyName, operand);
        }
        public abstract String keepScalarSubQuery(WhiteColumnExceptCQ subQuery);

        // ===============================================================================
        //                                                                  MySelf InScope
        //                                                                  ==============
        public void MyselfInScope(SubQuery<WhiteColumnExceptCB> subQuery) {
            assertObjectNotNull("subQuery<WhiteColumnExceptCB>", subQuery);
            WhiteColumnExceptCB cb = new WhiteColumnExceptCB(); cb.xsetupForInScopeRelation(this); subQuery.Invoke(cb);
            String subQueryPropertyName = keepMyselfInScopeSubQuery(cb.Query()); // for saving query-value.
            registerInScopeSubQuery(cb.Query(), "EXCEPT_COLUMN_ID", "EXCEPT_COLUMN_ID", subQueryPropertyName);
        }
        public abstract String keepMyselfInScopeSubQuery(WhiteColumnExceptCQ subQuery);

        public override String ToString() { return xgetSqlClause().getClause(); }
    }
}
