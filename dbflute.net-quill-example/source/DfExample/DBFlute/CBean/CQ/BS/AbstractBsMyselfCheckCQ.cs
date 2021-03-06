
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
    public abstract class AbstractBsMyselfCheckCQ : AbstractConditionQuery {

        public AbstractBsMyselfCheckCQ(ConditionQuery childQuery, SqlClause sqlClause, String aliasName, int nestLevel)
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
        protected void regMyselfCheckId(ConditionKey k, Object v) { regQ(k, v, getCValueMyselfCheckId(), "MYSELF_CHECK_ID"); }
        protected abstract ConditionValue getCValueMyselfCheckId();

        public void SetMyselfCheckName_Equal(String v) { DoSetMyselfCheckName_Equal(fRES(v)); }
        protected void DoSetMyselfCheckName_Equal(String v) { regMyselfCheckName(CK_EQ, v); }
        public void SetMyselfCheckName_NotEqual(String v) { DoSetMyselfCheckName_NotEqual(fRES(v)); }
        protected void DoSetMyselfCheckName_NotEqual(String v) { regMyselfCheckName(CK_NES, v); }
        public void SetMyselfCheckName_InScope(IList<String> ls) { regINS<String>(CK_INS, cTL<String>(ls), getCValueMyselfCheckName(), "MYSELF_CHECK_NAME"); }
        public void SetMyselfCheckName_NotInScope(IList<String> ls) { regINS<String>(CK_NINS, cTL<String>(ls), getCValueMyselfCheckName(), "MYSELF_CHECK_NAME"); }
        public void SetMyselfCheckName_PrefixSearch(String v) { SetMyselfCheckName_LikeSearch(v, cLSOP()); }
        public void SetMyselfCheckName_LikeSearch(String v, LikeSearchOption option)
        { regLSQ(CK_LS, fRES(v), getCValueMyselfCheckName(), "MYSELF_CHECK_NAME", option); }
        public void SetMyselfCheckName_NotLikeSearch(String v, LikeSearchOption option)
        { regLSQ(CK_NLS, fRES(v), getCValueMyselfCheckName(), "MYSELF_CHECK_NAME", option); }
        protected void regMyselfCheckName(ConditionKey k, Object v) { regQ(k, v, getCValueMyselfCheckName(), "MYSELF_CHECK_NAME"); }
        protected abstract ConditionValue getCValueMyselfCheckName();

        public void SetMyselfId_Equal(int? v) { regMyselfId(CK_EQ, v); }
        public void SetMyselfId_NotEqual(int? v) { regMyselfId(CK_NES, v); }
        public void SetMyselfId_GreaterThan(int? v) { regMyselfId(CK_GT, v); }
        public void SetMyselfId_LessThan(int? v) { regMyselfId(CK_LT, v); }
        public void SetMyselfId_GreaterEqual(int? v) { regMyselfId(CK_GE, v); }
        public void SetMyselfId_LessEqual(int? v) { regMyselfId(CK_LE, v); }
        public void SetMyselfId_InScope(IList<int?> ls) { regINS<int?>(CK_INS, cTL<int?>(ls), getCValueMyselfId(), "MYSELF_ID"); }
        public void SetMyselfId_NotInScope(IList<int?> ls) { regINS<int?>(CK_NINS, cTL<int?>(ls), getCValueMyselfId(), "MYSELF_ID"); }
        public void InScopeMyself(SubQuery<MyselfCB> subQuery) {
            assertObjectNotNull("subQuery<MyselfCB>", subQuery);
            MyselfCB cb = new MyselfCB(); cb.xsetupForInScopeRelation(this); subQuery.Invoke(cb);
            String subQueryPropertyName = keepMyselfId_InScopeSubQuery_Myself(cb.Query());
            registerInScopeSubQuery(cb.Query(), "MYSELF_ID", "MYSELF_ID", subQueryPropertyName);
        }
        public abstract String keepMyselfId_InScopeSubQuery_Myself(MyselfCQ subQuery);
        public void NotInScopeMyself(SubQuery<MyselfCB> subQuery) {
            assertObjectNotNull("subQuery<MyselfCB>", subQuery);
            MyselfCB cb = new MyselfCB(); cb.xsetupForInScopeRelation(this); subQuery.Invoke(cb);
            String subQueryPropertyName = keepMyselfId_NotInScopeSubQuery_Myself(cb.Query());
            registerNotInScopeSubQuery(cb.Query(), "MYSELF_ID", "MYSELF_ID", subQueryPropertyName);
        }
        public abstract String keepMyselfId_NotInScopeSubQuery_Myself(MyselfCQ subQuery);
        public void SetMyselfId_IsNull() { regMyselfId(CK_ISN, DUMMY_OBJECT); }
        public void SetMyselfId_IsNotNull() { regMyselfId(CK_ISNN, DUMMY_OBJECT); }
        protected void regMyselfId(ConditionKey k, Object v) { regQ(k, v, getCValueMyselfId(), "MYSELF_ID"); }
        protected abstract ConditionValue getCValueMyselfId();

        // ===================================================================================
        //                                                                    Scalar Condition
        //                                                                    ================
        public SSQFunction<MyselfCheckCB> Scalar_Equal() {
            return xcreateSSQFunction("=");
        }

        public SSQFunction<MyselfCheckCB> Scalar_NotEqual() {
            return xcreateSSQFunction("<>");
        }

        public SSQFunction<MyselfCheckCB> Scalar_GreaterEqual() {
            return xcreateSSQFunction(">=");
        }

        public SSQFunction<MyselfCheckCB> Scalar_GreaterThan() {
            return xcreateSSQFunction(">");
        }

        public SSQFunction<MyselfCheckCB> Scalar_LessEqual() {
            return xcreateSSQFunction("<=");
        }

        public SSQFunction<MyselfCheckCB> Scalar_LessThan() {
            return xcreateSSQFunction("<");
        }

        protected SSQFunction<MyselfCheckCB> xcreateSSQFunction(String operand) {
            return new SSQFunction<MyselfCheckCB>(delegate(String function, SubQuery<MyselfCheckCB> subQuery) {
                xscalarSubQuery(function, subQuery, operand);
            });
        }

        protected void xscalarSubQuery(String function, SubQuery<MyselfCheckCB> subQuery, String operand) {
            assertObjectNotNull("subQuery<MyselfCheckCB>", subQuery);
            MyselfCheckCB cb = new MyselfCheckCB(); cb.xsetupForScalarCondition(this); subQuery.Invoke(cb);
            String subQueryPropertyName = keepScalarSubQuery(cb.Query()); // for saving query-value.
            registerScalarSubQuery(function, cb.Query(), subQueryPropertyName, operand);
        }
        public abstract String keepScalarSubQuery(MyselfCheckCQ subQuery);

        // ===============================================================================
        //                                                                  MySelf InScope
        //                                                                  ==============
        public void MyselfInScope(SubQuery<MyselfCheckCB> subQuery) {
            assertObjectNotNull("subQuery<MyselfCheckCB>", subQuery);
            MyselfCheckCB cb = new MyselfCheckCB(); cb.xsetupForInScopeRelation(this); subQuery.Invoke(cb);
            String subQueryPropertyName = keepMyselfInScopeSubQuery(cb.Query()); // for saving query-value.
            registerInScopeSubQuery(cb.Query(), "MYSELF_CHECK_ID", "MYSELF_CHECK_ID", subQueryPropertyName);
        }
        public abstract String keepMyselfInScopeSubQuery(MyselfCheckCQ subQuery);

        public override String ToString() { return xgetSqlClause().getClause(); }
    }
}
