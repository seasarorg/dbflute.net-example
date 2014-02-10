
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
    public abstract class LdAbstractBsMyselfCQ : LdAbstractConditionQuery {

        public LdAbstractBsMyselfCQ(LdConditionQuery childQuery, LdSqlClause sqlClause, String aliasName, int nestLevel)
            : base(childQuery, sqlClause, aliasName, nestLevel) {}

        public override String getTableDbName() { return "myself"; }
        public override String getTableSqlName() { return "myself"; }

        public void SetMyselfId_Equal(int? v) { regMyselfId(CK_EQ, v); }
        public void SetMyselfId_NotEqual(int? v) { regMyselfId(CK_NES, v); }
        public void SetMyselfId_GreaterThan(int? v) { regMyselfId(CK_GT, v); }
        public void SetMyselfId_LessThan(int? v) { regMyselfId(CK_LT, v); }
        public void SetMyselfId_GreaterEqual(int? v) { regMyselfId(CK_GE, v); }
        public void SetMyselfId_LessEqual(int? v) { regMyselfId(CK_LE, v); }
        public void SetMyselfId_InScope(IList<int?> ls) { regINS<int?>(CK_INS, cTL<int?>(ls), getCValueMyselfId(), "MYSELF_ID"); }
        public void SetMyselfId_NotInScope(IList<int?> ls) { regINS<int?>(CK_NINS, cTL<int?>(ls), getCValueMyselfId(), "MYSELF_ID"); }
        public void ExistsMyselfCheckList(LdSubQuery<LdMyselfCheckCB> subQuery) {
            assertObjectNotNull("subQuery<LdMyselfCheckCB>", subQuery);
            LdMyselfCheckCB cb = new LdMyselfCheckCB(); cb.xsetupForExistsReferrer(this); subQuery.Invoke(cb);
            String subQueryPropertyName = keepMyselfId_ExistsSubQuery_MyselfCheckList(cb.Query());
            registerExistsSubQuery(cb.Query(), "MYSELF_ID", "MYSELF_ID", subQueryPropertyName);
        }
        public abstract String keepMyselfId_ExistsSubQuery_MyselfCheckList(LdMyselfCheckCQ subQuery);
        public void NotExistsMyselfCheckList(LdSubQuery<LdMyselfCheckCB> subQuery) {
            assertObjectNotNull("subQuery<LdMyselfCheckCB>", subQuery);
            LdMyselfCheckCB cb = new LdMyselfCheckCB(); cb.xsetupForExistsReferrer(this); subQuery.Invoke(cb);
            String subQueryPropertyName = keepMyselfId_NotExistsSubQuery_MyselfCheckList(cb.Query());
            registerNotExistsSubQuery(cb.Query(), "MYSELF_ID", "MYSELF_ID", subQueryPropertyName);
        }
        public abstract String keepMyselfId_NotExistsSubQuery_MyselfCheckList(LdMyselfCheckCQ subQuery);
        public void InScopeMyselfCheckList(LdSubQuery<LdMyselfCheckCB> subQuery) {
            assertObjectNotNull("subQuery<LdMyselfCheckCB>", subQuery);
            LdMyselfCheckCB cb = new LdMyselfCheckCB(); cb.xsetupForInScopeRelation(this); subQuery.Invoke(cb);
            String subQueryPropertyName = keepMyselfId_InScopeSubQuery_MyselfCheckList(cb.Query());
            registerInScopeSubQuery(cb.Query(), "MYSELF_ID", "MYSELF_ID", subQueryPropertyName);
        }
        public abstract String keepMyselfId_InScopeSubQuery_MyselfCheckList(LdMyselfCheckCQ subQuery);
        public void NotInScopeMyselfCheckList(LdSubQuery<LdMyselfCheckCB> subQuery) {
            assertObjectNotNull("subQuery<LdMyselfCheckCB>", subQuery);
            LdMyselfCheckCB cb = new LdMyselfCheckCB(); cb.xsetupForInScopeRelation(this); subQuery.Invoke(cb);
            String subQueryPropertyName = keepMyselfId_NotInScopeSubQuery_MyselfCheckList(cb.Query());
            registerNotInScopeSubQuery(cb.Query(), "MYSELF_ID", "MYSELF_ID", subQueryPropertyName);
        }
        public abstract String keepMyselfId_NotInScopeSubQuery_MyselfCheckList(LdMyselfCheckCQ subQuery);
        public void xsderiveMyselfCheckList(String function, LdSubQuery<LdMyselfCheckCB> subQuery, String aliasName) {
            assertObjectNotNull("subQuery<LdMyselfCheckCB>", subQuery);
            LdMyselfCheckCB cb = new LdMyselfCheckCB(); cb.xsetupForDerivedReferrer(this); subQuery.Invoke(cb);
            String subQueryPropertyName = keepMyselfId_SpecifyDerivedReferrer_MyselfCheckList(cb.Query());
            registerSpecifyDerivedReferrer(function, cb.Query(), "MYSELF_ID", "MYSELF_ID", subQueryPropertyName, aliasName);
        }
        abstract public String keepMyselfId_SpecifyDerivedReferrer_MyselfCheckList(LdMyselfCheckCQ subQuery);

        public QDRFunction<LdMyselfCheckCB> DerivedMyselfCheckList() {
            return xcreateQDRFunctionMyselfCheckList();
        }
        protected QDRFunction<LdMyselfCheckCB> xcreateQDRFunctionMyselfCheckList() {
            return new QDRFunction<LdMyselfCheckCB>(delegate(String function, LdSubQuery<LdMyselfCheckCB> subQuery, String operand, Object value) {
                xqderiveMyselfCheckList(function, subQuery, operand, value);
            });
        }
        public void xqderiveMyselfCheckList(String function, LdSubQuery<LdMyselfCheckCB> subQuery, String operand, Object value) {
            assertObjectNotNull("subQuery<LdMyselfCheckCB>", subQuery);
            LdMyselfCheckCB cb = new LdMyselfCheckCB(); cb.xsetupForDerivedReferrer(this); subQuery.Invoke(cb);
            String subQueryPropertyName = keepMyselfId_QueryDerivedReferrer_MyselfCheckList(cb.Query()); // for saving query-value.
            String parameterPropertyName = keepMyselfId_QueryDerivedReferrer_MyselfCheckListParameter(value);
            registerQueryDerivedReferrer(function, cb.Query(), "MYSELF_ID", "MYSELF_ID", subQueryPropertyName, operand, value, parameterPropertyName);
        }
        public abstract String keepMyselfId_QueryDerivedReferrer_MyselfCheckList(LdMyselfCheckCQ subQuery);
        public abstract String keepMyselfId_QueryDerivedReferrer_MyselfCheckListParameter(Object parameterValue);
        public void SetMyselfId_IsNull() { regMyselfId(CK_ISN, DUMMY_OBJECT); }
        public void SetMyselfId_IsNotNull() { regMyselfId(CK_ISNN, DUMMY_OBJECT); }
        protected void regMyselfId(LdConditionKey k, Object v) { regQ(k, v, getCValueMyselfId(), "MYSELF_ID"); }
        protected abstract LdConditionValue getCValueMyselfId();

        public void SetMyselfName_Equal(String v) { DoSetMyselfName_Equal(fRES(v)); }
        protected void DoSetMyselfName_Equal(String v) { regMyselfName(CK_EQ, v); }
        public void SetMyselfName_NotEqual(String v) { DoSetMyselfName_NotEqual(fRES(v)); }
        protected void DoSetMyselfName_NotEqual(String v) { regMyselfName(CK_NES, v); }
        public void SetMyselfName_GreaterThan(String v) { regMyselfName(CK_GT, fRES(v)); }
        public void SetMyselfName_LessThan(String v) { regMyselfName(CK_LT, fRES(v)); }
        public void SetMyselfName_GreaterEqual(String v) { regMyselfName(CK_GE, fRES(v)); }
        public void SetMyselfName_LessEqual(String v) { regMyselfName(CK_LE, fRES(v)); }
        public void SetMyselfName_InScope(IList<String> ls) { regINS<String>(CK_INS, cTL<String>(ls), getCValueMyselfName(), "MYSELF_NAME"); }
        public void SetMyselfName_NotInScope(IList<String> ls) { regINS<String>(CK_NINS, cTL<String>(ls), getCValueMyselfName(), "MYSELF_NAME"); }
        public void SetMyselfName_PrefixSearch(String v) { SetMyselfName_LikeSearch(v, cLSOP()); }
        public void SetMyselfName_LikeSearch(String v, LdLikeSearchOption option)
        { regLSQ(CK_LS, fRES(v), getCValueMyselfName(), "MYSELF_NAME", option); }
        public void SetMyselfName_NotLikeSearch(String v, LdLikeSearchOption option)
        { regLSQ(CK_NLS, fRES(v), getCValueMyselfName(), "MYSELF_NAME", option); }
        protected void regMyselfName(LdConditionKey k, Object v) { regQ(k, v, getCValueMyselfName(), "MYSELF_NAME"); }
        protected abstract LdConditionValue getCValueMyselfName();

        // ===================================================================================
        //                                                                    Scalar Condition
        //                                                                    ================
        public SSQFunction<LdMyselfCB> Scalar_Equal() {
            return xcreateSSQFunction("=");
        }

        public SSQFunction<LdMyselfCB> Scalar_NotEqual() {
            return xcreateSSQFunction("<>");
        }

        public SSQFunction<LdMyselfCB> Scalar_GreaterEqual() {
            return xcreateSSQFunction(">=");
        }

        public SSQFunction<LdMyselfCB> Scalar_GreaterThan() {
            return xcreateSSQFunction(">");
        }

        public SSQFunction<LdMyselfCB> Scalar_LessEqual() {
            return xcreateSSQFunction("<=");
        }

        public SSQFunction<LdMyselfCB> Scalar_LessThan() {
            return xcreateSSQFunction("<");
        }

        protected SSQFunction<LdMyselfCB> xcreateSSQFunction(String operand) {
            return new SSQFunction<LdMyselfCB>(delegate(String function, LdSubQuery<LdMyselfCB> subQuery) {
                xscalarSubQuery(function, subQuery, operand);
            });
        }

        protected void xscalarSubQuery(String function, LdSubQuery<LdMyselfCB> subQuery, String operand) {
            assertObjectNotNull("subQuery<LdMyselfCB>", subQuery);
            LdMyselfCB cb = new LdMyselfCB(); cb.xsetupForScalarCondition(this); subQuery.Invoke(cb);
            String subQueryPropertyName = keepScalarSubQuery(cb.Query()); // for saving query-value.
            registerScalarSubQuery(function, cb.Query(), subQueryPropertyName, operand);
        }
        public abstract String keepScalarSubQuery(LdMyselfCQ subQuery);

        // ===============================================================================
        //                                                                  MySelf InScope
        //                                                                  ==============
        public void MyselfInScope(LdSubQuery<LdMyselfCB> subQuery) {
            assertObjectNotNull("subQuery<LdMyselfCB>", subQuery);
            LdMyselfCB cb = new LdMyselfCB(); cb.xsetupForInScopeRelation(this); subQuery.Invoke(cb);
            String subQueryPropertyName = keepMyselfInScopeSubQuery(cb.Query()); // for saving query-value.
            registerInScopeSubQuery(cb.Query(), "MYSELF_ID", "MYSELF_ID", subQueryPropertyName);
        }
        public abstract String keepMyselfInScopeSubQuery(LdMyselfCQ subQuery);

        public override String ToString() { return xgetSqlClause().getClause(); }
    }
}
