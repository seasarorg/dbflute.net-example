
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
    public abstract class AbstractBsWhiteCompoundPkRefNestCQ : AbstractConditionQuery {

        public AbstractBsWhiteCompoundPkRefNestCQ(ConditionQuery childQuery, SqlClause sqlClause, String aliasName, int nestLevel)
            : base(childQuery, sqlClause, aliasName, nestLevel) {}

        public override String getTableDbName() { return "white_compound_pk_ref_nest"; }
        public override String getTableSqlName() { return "white_compound_pk_ref_nest"; }

        public void SetCompoundPkRefNestId_Equal(int? v) { regCompoundPkRefNestId(CK_EQ, v); }
        public void SetCompoundPkRefNestId_NotEqual(int? v) { regCompoundPkRefNestId(CK_NES, v); }
        public void SetCompoundPkRefNestId_GreaterThan(int? v) { regCompoundPkRefNestId(CK_GT, v); }
        public void SetCompoundPkRefNestId_LessThan(int? v) { regCompoundPkRefNestId(CK_LT, v); }
        public void SetCompoundPkRefNestId_GreaterEqual(int? v) { regCompoundPkRefNestId(CK_GE, v); }
        public void SetCompoundPkRefNestId_LessEqual(int? v) { regCompoundPkRefNestId(CK_LE, v); }
        public void SetCompoundPkRefNestId_InScope(IList<int?> ls) { regINS<int?>(CK_INS, cTL<int?>(ls), getCValueCompoundPkRefNestId(), "COMPOUND_PK_REF_NEST_ID"); }
        public void SetCompoundPkRefNestId_NotInScope(IList<int?> ls) { regINS<int?>(CK_NINS, cTL<int?>(ls), getCValueCompoundPkRefNestId(), "COMPOUND_PK_REF_NEST_ID"); }
        public void SetCompoundPkRefNestId_IsNull() { regCompoundPkRefNestId(CK_ISN, DUMMY_OBJECT); }
        public void SetCompoundPkRefNestId_IsNotNull() { regCompoundPkRefNestId(CK_ISNN, DUMMY_OBJECT); }
        protected void regCompoundPkRefNestId(ConditionKey k, Object v) { regQ(k, v, getCValueCompoundPkRefNestId(), "COMPOUND_PK_REF_NEST_ID"); }
        protected abstract ConditionValue getCValueCompoundPkRefNestId();

        public void SetFooMultipleId_Equal(int? v) { regFooMultipleId(CK_EQ, v); }
        public void SetFooMultipleId_NotEqual(int? v) { regFooMultipleId(CK_NES, v); }
        public void SetFooMultipleId_GreaterThan(int? v) { regFooMultipleId(CK_GT, v); }
        public void SetFooMultipleId_LessThan(int? v) { regFooMultipleId(CK_LT, v); }
        public void SetFooMultipleId_GreaterEqual(int? v) { regFooMultipleId(CK_GE, v); }
        public void SetFooMultipleId_LessEqual(int? v) { regFooMultipleId(CK_LE, v); }
        public void SetFooMultipleId_InScope(IList<int?> ls) { regINS<int?>(CK_INS, cTL<int?>(ls), getCValueFooMultipleId(), "FOO_MULTIPLE_ID"); }
        public void SetFooMultipleId_NotInScope(IList<int?> ls) { regINS<int?>(CK_NINS, cTL<int?>(ls), getCValueFooMultipleId(), "FOO_MULTIPLE_ID"); }
        protected void regFooMultipleId(ConditionKey k, Object v) { regQ(k, v, getCValueFooMultipleId(), "FOO_MULTIPLE_ID"); }
        protected abstract ConditionValue getCValueFooMultipleId();

        public void SetBarMultipleId_Equal(int? v) { regBarMultipleId(CK_EQ, v); }
        public void SetBarMultipleId_NotEqual(int? v) { regBarMultipleId(CK_NES, v); }
        public void SetBarMultipleId_GreaterThan(int? v) { regBarMultipleId(CK_GT, v); }
        public void SetBarMultipleId_LessThan(int? v) { regBarMultipleId(CK_LT, v); }
        public void SetBarMultipleId_GreaterEqual(int? v) { regBarMultipleId(CK_GE, v); }
        public void SetBarMultipleId_LessEqual(int? v) { regBarMultipleId(CK_LE, v); }
        public void SetBarMultipleId_InScope(IList<int?> ls) { regINS<int?>(CK_INS, cTL<int?>(ls), getCValueBarMultipleId(), "BAR_MULTIPLE_ID"); }
        public void SetBarMultipleId_NotInScope(IList<int?> ls) { regINS<int?>(CK_NINS, cTL<int?>(ls), getCValueBarMultipleId(), "BAR_MULTIPLE_ID"); }
        protected void regBarMultipleId(ConditionKey k, Object v) { regQ(k, v, getCValueBarMultipleId(), "BAR_MULTIPLE_ID"); }
        protected abstract ConditionValue getCValueBarMultipleId();

        public void SetQuxMultipleId_Equal(int? v) { regQuxMultipleId(CK_EQ, v); }
        public void SetQuxMultipleId_NotEqual(int? v) { regQuxMultipleId(CK_NES, v); }
        public void SetQuxMultipleId_GreaterThan(int? v) { regQuxMultipleId(CK_GT, v); }
        public void SetQuxMultipleId_LessThan(int? v) { regQuxMultipleId(CK_LT, v); }
        public void SetQuxMultipleId_GreaterEqual(int? v) { regQuxMultipleId(CK_GE, v); }
        public void SetQuxMultipleId_LessEqual(int? v) { regQuxMultipleId(CK_LE, v); }
        public void SetQuxMultipleId_InScope(IList<int?> ls) { regINS<int?>(CK_INS, cTL<int?>(ls), getCValueQuxMultipleId(), "QUX_MULTIPLE_ID"); }
        public void SetQuxMultipleId_NotInScope(IList<int?> ls) { regINS<int?>(CK_NINS, cTL<int?>(ls), getCValueQuxMultipleId(), "QUX_MULTIPLE_ID"); }
        protected void regQuxMultipleId(ConditionKey k, Object v) { regQ(k, v, getCValueQuxMultipleId(), "QUX_MULTIPLE_ID"); }
        protected abstract ConditionValue getCValueQuxMultipleId();

        // ===================================================================================
        //                                                                    Scalar Condition
        //                                                                    ================
        public SSQFunction<WhiteCompoundPkRefNestCB> Scalar_Equal() {
            return xcreateSSQFunction("=");
        }

        public SSQFunction<WhiteCompoundPkRefNestCB> Scalar_NotEqual() {
            return xcreateSSQFunction("<>");
        }

        public SSQFunction<WhiteCompoundPkRefNestCB> Scalar_GreaterEqual() {
            return xcreateSSQFunction(">=");
        }

        public SSQFunction<WhiteCompoundPkRefNestCB> Scalar_GreaterThan() {
            return xcreateSSQFunction(">");
        }

        public SSQFunction<WhiteCompoundPkRefNestCB> Scalar_LessEqual() {
            return xcreateSSQFunction("<=");
        }

        public SSQFunction<WhiteCompoundPkRefNestCB> Scalar_LessThan() {
            return xcreateSSQFunction("<");
        }

        protected SSQFunction<WhiteCompoundPkRefNestCB> xcreateSSQFunction(String operand) {
            return new SSQFunction<WhiteCompoundPkRefNestCB>(delegate(String function, SubQuery<WhiteCompoundPkRefNestCB> subQuery) {
                xscalarSubQuery(function, subQuery, operand);
            });
        }

        protected void xscalarSubQuery(String function, SubQuery<WhiteCompoundPkRefNestCB> subQuery, String operand) {
            assertObjectNotNull("subQuery<WhiteCompoundPkRefNestCB>", subQuery);
            WhiteCompoundPkRefNestCB cb = new WhiteCompoundPkRefNestCB(); cb.xsetupForScalarCondition(this); subQuery.Invoke(cb);
            String subQueryPropertyName = keepScalarSubQuery(cb.Query()); // for saving query-value.
            registerScalarSubQuery(function, cb.Query(), subQueryPropertyName, operand);
        }
        public abstract String keepScalarSubQuery(WhiteCompoundPkRefNestCQ subQuery);

        // ===============================================================================
        //                                                                  MySelf InScope
        //                                                                  ==============
        public void MyselfInScope(SubQuery<WhiteCompoundPkRefNestCB> subQuery) {
            assertObjectNotNull("subQuery<WhiteCompoundPkRefNestCB>", subQuery);
            WhiteCompoundPkRefNestCB cb = new WhiteCompoundPkRefNestCB(); cb.xsetupForInScopeRelation(this); subQuery.Invoke(cb);
            String subQueryPropertyName = keepMyselfInScopeSubQuery(cb.Query()); // for saving query-value.
            registerInScopeSubQuery(cb.Query(), "COMPOUND_PK_REF_NEST_ID", "COMPOUND_PK_REF_NEST_ID", subQueryPropertyName);
        }
        public abstract String keepMyselfInScopeSubQuery(WhiteCompoundPkRefNestCQ subQuery);

        public override String ToString() { return xgetSqlClause().getClause(); }
    }
}
