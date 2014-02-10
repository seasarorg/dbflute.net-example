
using System;
using System.Collections.Generic;

using DfExample.DBFlute.LibraryDb.AllCommon;
using DfExample.DBFlute.LibraryDb.AllCommon.CBean;
using DfExample.DBFlute.LibraryDb.AllCommon.CBean.CKey;
using DfExample.DBFlute.LibraryDb.AllCommon.CBean.COption;
using DfExample.DBFlute.LibraryDb.AllCommon.CBean.CValue;
using DfExample.DBFlute.LibraryDb.AllCommon.CBean.SClause;

namespace DfExample.DBFlute.LibraryDb.CBean.CQ.BS {

    [System.Serializable]
    public abstract class LdAbstractBsMyselfCheckCQ : LdAbstractConditionQuery {

        public LdAbstractBsMyselfCheckCQ(LdConditionQuery childQuery, LdSqlClause sqlClause, String aliasName, int nestLevel)
            : base(childQuery, sqlClause, aliasName, nestLevel) {}

        public override String getTableDbName() { return "myself_check"; }
        public override String getTableSqlName() { return "myself_check"; }

        public void SetMyselfCheckId_Equal(int? v) { regMyselfCheckId(CK_EQ, v); }
        public void SetMyselfCheckId_NotEqual(int? v) { regMyselfCheckId(CK_NES, v); }
        public void SetMyselfCheckId_GreaterThan(int? v) { regMyselfCheckId(CK_GT, v); }
        public void SetMyselfCheckId_LessThan(int? v) { regMyselfCheckId(CK_LT, v); }
        public void SetMyselfCheckId_GreaterEqual(int? v) { regMyselfCheckId(CK_GE, v); }
        public void SetMyselfCheckId_LessEqual(int? v) { regMyselfCheckId(CK_LE, v); }
        public void SetMyselfCheckId_InScope(IList<int?> ls) { regINS<int?>(CK_INS, cTL<int?>(ls), getCValueMyselfCheckId(), "MYSELF_CHECK_ID"); }
        public void SetMyselfCheckId_NotInScope(IList<int?> ls) { regINS<int?>(CK_NINS, cTL<int?>(ls), getCValueMyselfCheckId(), "MYSELF_CHECK_ID"); }
        public void SetMyselfCheckId_IsNull() { regMyselfCheckId(CK_ISN, DUMMY_OBJECT); }
        public void SetMyselfCheckId_IsNotNull() { regMyselfCheckId(CK_ISNN, DUMMY_OBJECT); }
        protected void regMyselfCheckId(LdConditionKey k, Object v) { regQ(k, v, getCValueMyselfCheckId(), "MYSELF_CHECK_ID"); }
        protected abstract LdConditionValue getCValueMyselfCheckId();

        public void SetMyselfCheckName_Equal(String v) { DoSetMyselfCheckName_Equal(fRES(v)); }
        protected void DoSetMyselfCheckName_Equal(String v) { regMyselfCheckName(CK_EQ, v); }
        public void SetMyselfCheckName_NotEqual(String v) { DoSetMyselfCheckName_NotEqual(fRES(v)); }
        protected void DoSetMyselfCheckName_NotEqual(String v) { regMyselfCheckName(CK_NES, v); }
        public void SetMyselfCheckName_GreaterThan(String v) { regMyselfCheckName(CK_GT, fRES(v)); }
        public void SetMyselfCheckName_LessThan(String v) { regMyselfCheckName(CK_LT, fRES(v)); }
        public void SetMyselfCheckName_GreaterEqual(String v) { regMyselfCheckName(CK_GE, fRES(v)); }
        public void SetMyselfCheckName_LessEqual(String v) { regMyselfCheckName(CK_LE, fRES(v)); }
        public void SetMyselfCheckName_InScope(IList<String> ls) { regINS<String>(CK_INS, cTL<String>(ls), getCValueMyselfCheckName(), "MYSELF_CHECK_NAME"); }
        public void SetMyselfCheckName_NotInScope(IList<String> ls) { regINS<String>(CK_NINS, cTL<String>(ls), getCValueMyselfCheckName(), "MYSELF_CHECK_NAME"); }
        public void SetMyselfCheckName_PrefixSearch(String v) { SetMyselfCheckName_LikeSearch(v, cLSOP()); }
        public void SetMyselfCheckName_LikeSearch(String v, LdLikeSearchOption option)
        { regLSQ(CK_LS, fRES(v), getCValueMyselfCheckName(), "MYSELF_CHECK_NAME", option); }
        public void SetMyselfCheckName_NotLikeSearch(String v, LdLikeSearchOption option)
        { regLSQ(CK_NLS, fRES(v), getCValueMyselfCheckName(), "MYSELF_CHECK_NAME", option); }
        protected void regMyselfCheckName(LdConditionKey k, Object v) { regQ(k, v, getCValueMyselfCheckName(), "MYSELF_CHECK_NAME"); }
        protected abstract LdConditionValue getCValueMyselfCheckName();

        public void SetMyselfId_Equal(int? v) { regMyselfId(CK_EQ, v); }
        public void SetMyselfId_NotEqual(int? v) { regMyselfId(CK_NES, v); }
        public void SetMyselfId_GreaterThan(int? v) { regMyselfId(CK_GT, v); }
        public void SetMyselfId_LessThan(int? v) { regMyselfId(CK_LT, v); }
        public void SetMyselfId_GreaterEqual(int? v) { regMyselfId(CK_GE, v); }
        public void SetMyselfId_LessEqual(int? v) { regMyselfId(CK_LE, v); }
        public void SetMyselfId_InScope(IList<int?> ls) { regINS<int?>(CK_INS, cTL<int?>(ls), getCValueMyselfId(), "MYSELF_ID"); }
        public void SetMyselfId_NotInScope(IList<int?> ls) { regINS<int?>(CK_NINS, cTL<int?>(ls), getCValueMyselfId(), "MYSELF_ID"); }
        public void InScopeMyself(LdSubQuery<LdMyselfCB> subQuery) {
            assertObjectNotNull("subQuery<LdMyselfCB>", subQuery);
            LdMyselfCB cb = new LdMyselfCB(); cb.xsetupForInScopeRelation(this); subQuery.Invoke(cb);
            String subQueryPropertyName = keepMyselfId_InScopeSubQuery_Myself(cb.Query());
            registerInScopeSubQuery(cb.Query(), "MYSELF_ID", "MYSELF_ID", subQueryPropertyName);
        }
        public abstract String keepMyselfId_InScopeSubQuery_Myself(LdMyselfCQ subQuery);
        public void NotInScopeMyself(LdSubQuery<LdMyselfCB> subQuery) {
            assertObjectNotNull("subQuery<LdMyselfCB>", subQuery);
            LdMyselfCB cb = new LdMyselfCB(); cb.xsetupForInScopeRelation(this); subQuery.Invoke(cb);
            String subQueryPropertyName = keepMyselfId_NotInScopeSubQuery_Myself(cb.Query());
            registerNotInScopeSubQuery(cb.Query(), "MYSELF_ID", "MYSELF_ID", subQueryPropertyName);
        }
        public abstract String keepMyselfId_NotInScopeSubQuery_Myself(LdMyselfCQ subQuery);
        public void SetMyselfId_IsNull() { regMyselfId(CK_ISN, DUMMY_OBJECT); }
        public void SetMyselfId_IsNotNull() { regMyselfId(CK_ISNN, DUMMY_OBJECT); }
        protected void regMyselfId(LdConditionKey k, Object v) { regQ(k, v, getCValueMyselfId(), "MYSELF_ID"); }
        protected abstract LdConditionValue getCValueMyselfId();

        // ===================================================================================
        //                                                                    Scalar Condition
        //                                                                    ================
        public SSQFunction<LdMyselfCheckCB> Scalar_Equal() {
            return xcreateSSQFunction("=");
        }

        public SSQFunction<LdMyselfCheckCB> Scalar_NotEqual() {
            return xcreateSSQFunction("<>");
        }

        public SSQFunction<LdMyselfCheckCB> Scalar_GreaterEqual() {
            return xcreateSSQFunction(">=");
        }

        public SSQFunction<LdMyselfCheckCB> Scalar_GreaterThan() {
            return xcreateSSQFunction(">");
        }

        public SSQFunction<LdMyselfCheckCB> Scalar_LessEqual() {
            return xcreateSSQFunction("<=");
        }

        public SSQFunction<LdMyselfCheckCB> Scalar_LessThan() {
            return xcreateSSQFunction("<");
        }

        protected SSQFunction<LdMyselfCheckCB> xcreateSSQFunction(String operand) {
            return new SSQFunction<LdMyselfCheckCB>(delegate(String function, LdSubQuery<LdMyselfCheckCB> subQuery) {
                xscalarSubQuery(function, subQuery, operand);
            });
        }

        protected void xscalarSubQuery(String function, LdSubQuery<LdMyselfCheckCB> subQuery, String operand) {
            assertObjectNotNull("subQuery<LdMyselfCheckCB>", subQuery);
            LdMyselfCheckCB cb = new LdMyselfCheckCB(); cb.xsetupForScalarCondition(this); subQuery.Invoke(cb);
            String subQueryPropertyName = keepScalarSubQuery(cb.Query()); // for saving query-value.
            registerScalarSubQuery(function, cb.Query(), subQueryPropertyName, operand);
        }
        public abstract String keepScalarSubQuery(LdMyselfCheckCQ subQuery);

        // ===============================================================================
        //                                                                  MySelf InScope
        //                                                                  ==============
        public void MyselfInScope(LdSubQuery<LdMyselfCheckCB> subQuery) {
            assertObjectNotNull("subQuery<LdMyselfCheckCB>", subQuery);
            LdMyselfCheckCB cb = new LdMyselfCheckCB(); cb.xsetupForInScopeRelation(this); subQuery.Invoke(cb);
            String subQueryPropertyName = keepMyselfInScopeSubQuery(cb.Query()); // for saving query-value.
            registerInScopeSubQuery(cb.Query(), "MYSELF_CHECK_ID", "MYSELF_CHECK_ID", subQueryPropertyName);
        }
        public abstract String keepMyselfInScopeSubQuery(LdMyselfCheckCQ subQuery);

        public override String ToString() { return xgetSqlClause().getClause(); }
    }
}
