
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
    public abstract class AbstractBsWhiteQuotedCQ : AbstractConditionQuery {

        public AbstractBsWhiteQuotedCQ(ConditionQuery childQuery, SqlClause sqlClause, String aliasName, int nestLevel)
            : base(childQuery, sqlClause, aliasName, nestLevel) {}

        public override String getTableDbName() { return "white_quoted"; }
        public override String getTableSqlName() { return "`white_quoted`"; }

        public void SetSelect_Equal(int? v) { regSelect(CK_EQ, v); }
        public void SetSelect_NotEqual(int? v) { regSelect(CK_NES, v); }
        public void SetSelect_GreaterThan(int? v) { regSelect(CK_GT, v); }
        public void SetSelect_LessThan(int? v) { regSelect(CK_LT, v); }
        public void SetSelect_GreaterEqual(int? v) { regSelect(CK_GE, v); }
        public void SetSelect_LessEqual(int? v) { regSelect(CK_LE, v); }
        public void SetSelect_InScope(IList<int?> ls) { regINS<int?>(CK_INS, cTL<int?>(ls), getCValueSelect(), "SELECT"); }
        public void SetSelect_NotInScope(IList<int?> ls) { regINS<int?>(CK_NINS, cTL<int?>(ls), getCValueSelect(), "SELECT"); }
        public void SetSelect_IsNull() { regSelect(CK_ISN, DUMMY_OBJECT); }
        public void SetSelect_IsNotNull() { regSelect(CK_ISNN, DUMMY_OBJECT); }
        protected void regSelect(ConditionKey k, Object v) { regQ(k, v, getCValueSelect(), "SELECT"); }
        protected abstract ConditionValue getCValueSelect();

        public void SetFrom_Equal(String v) { DoSetFrom_Equal(fRES(v)); }
        protected void DoSetFrom_Equal(String v) { regFrom(CK_EQ, v); }
        public void SetFrom_NotEqual(String v) { DoSetFrom_NotEqual(fRES(v)); }
        protected void DoSetFrom_NotEqual(String v) { regFrom(CK_NES, v); }
        public void SetFrom_InScope(IList<String> ls) { regINS<String>(CK_INS, cTL<String>(ls), getCValueFrom(), "FROM"); }
        public void SetFrom_NotInScope(IList<String> ls) { regINS<String>(CK_NINS, cTL<String>(ls), getCValueFrom(), "FROM"); }
        public void SetFrom_PrefixSearch(String v) { SetFrom_LikeSearch(v, cLSOP()); }
        public void SetFrom_LikeSearch(String v, LikeSearchOption option)
        { regLSQ(CK_LS, fRES(v), getCValueFrom(), "FROM", option); }
        public void SetFrom_NotLikeSearch(String v, LikeSearchOption option)
        { regLSQ(CK_NLS, fRES(v), getCValueFrom(), "FROM", option); }
        public void SetFrom_IsNull() { regFrom(CK_ISN, DUMMY_OBJECT); }
        public void SetFrom_IsNotNull() { regFrom(CK_ISNN, DUMMY_OBJECT); }
        protected void regFrom(ConditionKey k, Object v) { regQ(k, v, getCValueFrom(), "FROM"); }
        protected abstract ConditionValue getCValueFrom();

        // ===================================================================================
        //                                                                    Scalar Condition
        //                                                                    ================
        public SSQFunction<WhiteQuotedCB> Scalar_Equal() {
            return xcreateSSQFunction("=");
        }

        public SSQFunction<WhiteQuotedCB> Scalar_NotEqual() {
            return xcreateSSQFunction("<>");
        }

        public SSQFunction<WhiteQuotedCB> Scalar_GreaterEqual() {
            return xcreateSSQFunction(">=");
        }

        public SSQFunction<WhiteQuotedCB> Scalar_GreaterThan() {
            return xcreateSSQFunction(">");
        }

        public SSQFunction<WhiteQuotedCB> Scalar_LessEqual() {
            return xcreateSSQFunction("<=");
        }

        public SSQFunction<WhiteQuotedCB> Scalar_LessThan() {
            return xcreateSSQFunction("<");
        }

        protected SSQFunction<WhiteQuotedCB> xcreateSSQFunction(String operand) {
            return new SSQFunction<WhiteQuotedCB>(delegate(String function, SubQuery<WhiteQuotedCB> subQuery) {
                xscalarSubQuery(function, subQuery, operand);
            });
        }

        protected void xscalarSubQuery(String function, SubQuery<WhiteQuotedCB> subQuery, String operand) {
            assertObjectNotNull("subQuery<WhiteQuotedCB>", subQuery);
            WhiteQuotedCB cb = new WhiteQuotedCB(); cb.xsetupForScalarCondition(this); subQuery.Invoke(cb);
            String subQueryPropertyName = keepScalarSubQuery(cb.Query()); // for saving query-value.
            registerScalarSubQuery(function, cb.Query(), subQueryPropertyName, operand);
        }
        public abstract String keepScalarSubQuery(WhiteQuotedCQ subQuery);

        // ===============================================================================
        //                                                                  MySelf InScope
        //                                                                  ==============
        public void MyselfInScope(SubQuery<WhiteQuotedCB> subQuery) {
            assertObjectNotNull("subQuery<WhiteQuotedCB>", subQuery);
            WhiteQuotedCB cb = new WhiteQuotedCB(); cb.xsetupForInScopeRelation(this); subQuery.Invoke(cb);
            String subQueryPropertyName = keepMyselfInScopeSubQuery(cb.Query()); // for saving query-value.
            registerInScopeSubQuery(cb.Query(), "SELECT", "SELECT", subQueryPropertyName);
        }
        public abstract String keepMyselfInScopeSubQuery(WhiteQuotedCQ subQuery);

        public override String ToString() { return xgetSqlClause().getClause(); }
    }
}
