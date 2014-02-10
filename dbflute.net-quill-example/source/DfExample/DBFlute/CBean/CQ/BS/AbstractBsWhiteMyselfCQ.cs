
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
    public abstract class AbstractBsWhiteMyselfCQ : AbstractConditionQuery {

        public AbstractBsWhiteMyselfCQ(ConditionQuery childQuery, SqlClause sqlClause, String aliasName, int nestLevel)
            : base(childQuery, sqlClause, aliasName, nestLevel) {}

        public override String getTableDbName() { return "white_myself"; }
        public override String getTableSqlName() { return "white_myself"; }

        public void SetMyselfId_Equal(int? v) { regMyselfId(CK_EQ, v); }
        public void SetMyselfId_NotEqual(int? v) { regMyselfId(CK_NES, v); }
        public void SetMyselfId_GreaterThan(int? v) { regMyselfId(CK_GT, v); }
        public void SetMyselfId_LessThan(int? v) { regMyselfId(CK_LT, v); }
        public void SetMyselfId_GreaterEqual(int? v) { regMyselfId(CK_GE, v); }
        public void SetMyselfId_LessEqual(int? v) { regMyselfId(CK_LE, v); }
        public void SetMyselfId_InScope(IList<int?> ls) { regINS<int?>(CK_INS, cTL<int?>(ls), getCValueMyselfId(), "MYSELF_ID"); }
        public void SetMyselfId_NotInScope(IList<int?> ls) { regINS<int?>(CK_NINS, cTL<int?>(ls), getCValueMyselfId(), "MYSELF_ID"); }
        public void ExistsWhiteMyselfCheckList(SubQuery<WhiteMyselfCheckCB> subQuery) {
            assertObjectNotNull("subQuery<WhiteMyselfCheckCB>", subQuery);
            WhiteMyselfCheckCB cb = new WhiteMyselfCheckCB(); cb.xsetupForExistsReferrer(this); subQuery.Invoke(cb);
            String subQueryPropertyName = keepMyselfId_ExistsSubQuery_WhiteMyselfCheckList(cb.Query());
            registerExistsSubQuery(cb.Query(), "MYSELF_ID", "MYSELF_ID", subQueryPropertyName);
        }
        public abstract String keepMyselfId_ExistsSubQuery_WhiteMyselfCheckList(WhiteMyselfCheckCQ subQuery);
        public void NotExistsWhiteMyselfCheckList(SubQuery<WhiteMyselfCheckCB> subQuery) {
            assertObjectNotNull("subQuery<WhiteMyselfCheckCB>", subQuery);
            WhiteMyselfCheckCB cb = new WhiteMyselfCheckCB(); cb.xsetupForExistsReferrer(this); subQuery.Invoke(cb);
            String subQueryPropertyName = keepMyselfId_NotExistsSubQuery_WhiteMyselfCheckList(cb.Query());
            registerNotExistsSubQuery(cb.Query(), "MYSELF_ID", "MYSELF_ID", subQueryPropertyName);
        }
        public abstract String keepMyselfId_NotExistsSubQuery_WhiteMyselfCheckList(WhiteMyselfCheckCQ subQuery);
        public void InScopeWhiteMyselfCheckList(SubQuery<WhiteMyselfCheckCB> subQuery) {
            assertObjectNotNull("subQuery<WhiteMyselfCheckCB>", subQuery);
            WhiteMyselfCheckCB cb = new WhiteMyselfCheckCB(); cb.xsetupForInScopeRelation(this); subQuery.Invoke(cb);
            String subQueryPropertyName = keepMyselfId_InScopeSubQuery_WhiteMyselfCheckList(cb.Query());
            registerInScopeSubQuery(cb.Query(), "MYSELF_ID", "MYSELF_ID", subQueryPropertyName);
        }
        public abstract String keepMyselfId_InScopeSubQuery_WhiteMyselfCheckList(WhiteMyselfCheckCQ subQuery);
        public void NotInScopeWhiteMyselfCheckList(SubQuery<WhiteMyselfCheckCB> subQuery) {
            assertObjectNotNull("subQuery<WhiteMyselfCheckCB>", subQuery);
            WhiteMyselfCheckCB cb = new WhiteMyselfCheckCB(); cb.xsetupForInScopeRelation(this); subQuery.Invoke(cb);
            String subQueryPropertyName = keepMyselfId_NotInScopeSubQuery_WhiteMyselfCheckList(cb.Query());
            registerNotInScopeSubQuery(cb.Query(), "MYSELF_ID", "MYSELF_ID", subQueryPropertyName);
        }
        public abstract String keepMyselfId_NotInScopeSubQuery_WhiteMyselfCheckList(WhiteMyselfCheckCQ subQuery);
        public void xsderiveWhiteMyselfCheckList(String function, SubQuery<WhiteMyselfCheckCB> subQuery, String aliasName) {
            assertObjectNotNull("subQuery<WhiteMyselfCheckCB>", subQuery);
            WhiteMyselfCheckCB cb = new WhiteMyselfCheckCB(); cb.xsetupForDerivedReferrer(this); subQuery.Invoke(cb);
            String subQueryPropertyName = keepMyselfId_SpecifyDerivedReferrer_WhiteMyselfCheckList(cb.Query());
            registerSpecifyDerivedReferrer(function, cb.Query(), "MYSELF_ID", "MYSELF_ID", subQueryPropertyName, aliasName);
        }
        abstract public String keepMyselfId_SpecifyDerivedReferrer_WhiteMyselfCheckList(WhiteMyselfCheckCQ subQuery);

        public QDRFunction<WhiteMyselfCheckCB> DerivedWhiteMyselfCheckList() {
            return xcreateQDRFunctionWhiteMyselfCheckList();
        }
        protected QDRFunction<WhiteMyselfCheckCB> xcreateQDRFunctionWhiteMyselfCheckList() {
            return new QDRFunction<WhiteMyselfCheckCB>(delegate(String function, SubQuery<WhiteMyselfCheckCB> subQuery, String operand, Object value) {
                xqderiveWhiteMyselfCheckList(function, subQuery, operand, value);
            });
        }
        public void xqderiveWhiteMyselfCheckList(String function, SubQuery<WhiteMyselfCheckCB> subQuery, String operand, Object value) {
            assertObjectNotNull("subQuery<WhiteMyselfCheckCB>", subQuery);
            WhiteMyselfCheckCB cb = new WhiteMyselfCheckCB(); cb.xsetupForDerivedReferrer(this); subQuery.Invoke(cb);
            String subQueryPropertyName = keepMyselfId_QueryDerivedReferrer_WhiteMyselfCheckList(cb.Query()); // for saving query-value.
            String parameterPropertyName = keepMyselfId_QueryDerivedReferrer_WhiteMyselfCheckListParameter(value);
            registerQueryDerivedReferrer(function, cb.Query(), "MYSELF_ID", "MYSELF_ID", subQueryPropertyName, operand, value, parameterPropertyName);
        }
        public abstract String keepMyselfId_QueryDerivedReferrer_WhiteMyselfCheckList(WhiteMyselfCheckCQ subQuery);
        public abstract String keepMyselfId_QueryDerivedReferrer_WhiteMyselfCheckListParameter(Object parameterValue);
        public void SetMyselfId_IsNull() { regMyselfId(CK_ISN, DUMMY_OBJECT); }
        public void SetMyselfId_IsNotNull() { regMyselfId(CK_ISNN, DUMMY_OBJECT); }
        protected void regMyselfId(ConditionKey k, Object v) { regQ(k, v, getCValueMyselfId(), "MYSELF_ID"); }
        protected abstract ConditionValue getCValueMyselfId();

        public void SetMyselfName_Equal(String v) { DoSetMyselfName_Equal(fRES(v)); }
        protected void DoSetMyselfName_Equal(String v) { regMyselfName(CK_EQ, v); }
        public void SetMyselfName_NotEqual(String v) { DoSetMyselfName_NotEqual(fRES(v)); }
        protected void DoSetMyselfName_NotEqual(String v) { regMyselfName(CK_NES, v); }
        public void SetMyselfName_InScope(IList<String> ls) { regINS<String>(CK_INS, cTL<String>(ls), getCValueMyselfName(), "MYSELF_NAME"); }
        public void SetMyselfName_NotInScope(IList<String> ls) { regINS<String>(CK_NINS, cTL<String>(ls), getCValueMyselfName(), "MYSELF_NAME"); }
        public void SetMyselfName_PrefixSearch(String v) { SetMyselfName_LikeSearch(v, cLSOP()); }
        public void SetMyselfName_LikeSearch(String v, LikeSearchOption option)
        { regLSQ(CK_LS, fRES(v), getCValueMyselfName(), "MYSELF_NAME", option); }
        public void SetMyselfName_NotLikeSearch(String v, LikeSearchOption option)
        { regLSQ(CK_NLS, fRES(v), getCValueMyselfName(), "MYSELF_NAME", option); }
        protected void regMyselfName(ConditionKey k, Object v) { regQ(k, v, getCValueMyselfName(), "MYSELF_NAME"); }
        protected abstract ConditionValue getCValueMyselfName();

        // ===================================================================================
        //                                                                    Scalar Condition
        //                                                                    ================
        public SSQFunction<WhiteMyselfCB> Scalar_Equal() {
            return xcreateSSQFunction("=");
        }

        public SSQFunction<WhiteMyselfCB> Scalar_NotEqual() {
            return xcreateSSQFunction("<>");
        }

        public SSQFunction<WhiteMyselfCB> Scalar_GreaterEqual() {
            return xcreateSSQFunction(">=");
        }

        public SSQFunction<WhiteMyselfCB> Scalar_GreaterThan() {
            return xcreateSSQFunction(">");
        }

        public SSQFunction<WhiteMyselfCB> Scalar_LessEqual() {
            return xcreateSSQFunction("<=");
        }

        public SSQFunction<WhiteMyselfCB> Scalar_LessThan() {
            return xcreateSSQFunction("<");
        }

        protected SSQFunction<WhiteMyselfCB> xcreateSSQFunction(String operand) {
            return new SSQFunction<WhiteMyselfCB>(delegate(String function, SubQuery<WhiteMyselfCB> subQuery) {
                xscalarSubQuery(function, subQuery, operand);
            });
        }

        protected void xscalarSubQuery(String function, SubQuery<WhiteMyselfCB> subQuery, String operand) {
            assertObjectNotNull("subQuery<WhiteMyselfCB>", subQuery);
            WhiteMyselfCB cb = new WhiteMyselfCB(); cb.xsetupForScalarCondition(this); subQuery.Invoke(cb);
            String subQueryPropertyName = keepScalarSubQuery(cb.Query()); // for saving query-value.
            registerScalarSubQuery(function, cb.Query(), subQueryPropertyName, operand);
        }
        public abstract String keepScalarSubQuery(WhiteMyselfCQ subQuery);

        // ===============================================================================
        //                                                                  MySelf InScope
        //                                                                  ==============
        public void MyselfInScope(SubQuery<WhiteMyselfCB> subQuery) {
            assertObjectNotNull("subQuery<WhiteMyselfCB>", subQuery);
            WhiteMyselfCB cb = new WhiteMyselfCB(); cb.xsetupForInScopeRelation(this); subQuery.Invoke(cb);
            String subQueryPropertyName = keepMyselfInScopeSubQuery(cb.Query()); // for saving query-value.
            registerInScopeSubQuery(cb.Query(), "MYSELF_ID", "MYSELF_ID", subQueryPropertyName);
        }
        public abstract String keepMyselfInScopeSubQuery(WhiteMyselfCQ subQuery);

        public override String ToString() { return xgetSqlClause().getClause(); }
    }
}
