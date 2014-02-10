
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
    public abstract class AbstractBsMyselfCQ : AbstractConditionQuery {

        public AbstractBsMyselfCQ(ConditionQuery childQuery, SqlClause sqlClause, String aliasName, int nestLevel)
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
        public void ExistsMyselfCheckList(SubQuery<MyselfCheckCB> subQuery) {
            assertObjectNotNull("subQuery<MyselfCheckCB>", subQuery);
            MyselfCheckCB cb = new MyselfCheckCB(); cb.xsetupForExistsReferrer(this); subQuery.Invoke(cb);
            String subQueryPropertyName = keepMyselfId_ExistsSubQuery_MyselfCheckList(cb.Query());
            registerExistsSubQuery(cb.Query(), "MYSELF_ID", "MYSELF_ID", subQueryPropertyName);
        }
        public abstract String keepMyselfId_ExistsSubQuery_MyselfCheckList(MyselfCheckCQ subQuery);
        public void NotExistsMyselfCheckList(SubQuery<MyselfCheckCB> subQuery) {
            assertObjectNotNull("subQuery<MyselfCheckCB>", subQuery);
            MyselfCheckCB cb = new MyselfCheckCB(); cb.xsetupForExistsReferrer(this); subQuery.Invoke(cb);
            String subQueryPropertyName = keepMyselfId_NotExistsSubQuery_MyselfCheckList(cb.Query());
            registerNotExistsSubQuery(cb.Query(), "MYSELF_ID", "MYSELF_ID", subQueryPropertyName);
        }
        public abstract String keepMyselfId_NotExistsSubQuery_MyselfCheckList(MyselfCheckCQ subQuery);
        public void InScopeMyselfCheckList(SubQuery<MyselfCheckCB> subQuery) {
            assertObjectNotNull("subQuery<MyselfCheckCB>", subQuery);
            MyselfCheckCB cb = new MyselfCheckCB(); cb.xsetupForInScopeRelation(this); subQuery.Invoke(cb);
            String subQueryPropertyName = keepMyselfId_InScopeSubQuery_MyselfCheckList(cb.Query());
            registerInScopeSubQuery(cb.Query(), "MYSELF_ID", "MYSELF_ID", subQueryPropertyName);
        }
        public abstract String keepMyselfId_InScopeSubQuery_MyselfCheckList(MyselfCheckCQ subQuery);
        public void NotInScopeMyselfCheckList(SubQuery<MyselfCheckCB> subQuery) {
            assertObjectNotNull("subQuery<MyselfCheckCB>", subQuery);
            MyselfCheckCB cb = new MyselfCheckCB(); cb.xsetupForInScopeRelation(this); subQuery.Invoke(cb);
            String subQueryPropertyName = keepMyselfId_NotInScopeSubQuery_MyselfCheckList(cb.Query());
            registerNotInScopeSubQuery(cb.Query(), "MYSELF_ID", "MYSELF_ID", subQueryPropertyName);
        }
        public abstract String keepMyselfId_NotInScopeSubQuery_MyselfCheckList(MyselfCheckCQ subQuery);
        public void xsderiveMyselfCheckList(String function, SubQuery<MyselfCheckCB> subQuery, String aliasName) {
            assertObjectNotNull("subQuery<MyselfCheckCB>", subQuery);
            MyselfCheckCB cb = new MyselfCheckCB(); cb.xsetupForDerivedReferrer(this); subQuery.Invoke(cb);
            String subQueryPropertyName = keepMyselfId_SpecifyDerivedReferrer_MyselfCheckList(cb.Query());
            registerSpecifyDerivedReferrer(function, cb.Query(), "MYSELF_ID", "MYSELF_ID", subQueryPropertyName, aliasName);
        }
        abstract public String keepMyselfId_SpecifyDerivedReferrer_MyselfCheckList(MyselfCheckCQ subQuery);

        public QDRFunction<MyselfCheckCB> DerivedMyselfCheckList() {
            return xcreateQDRFunctionMyselfCheckList();
        }
        protected QDRFunction<MyselfCheckCB> xcreateQDRFunctionMyselfCheckList() {
            return new QDRFunction<MyselfCheckCB>(delegate(String function, SubQuery<MyselfCheckCB> subQuery, String operand, Object value) {
                xqderiveMyselfCheckList(function, subQuery, operand, value);
            });
        }
        public void xqderiveMyselfCheckList(String function, SubQuery<MyselfCheckCB> subQuery, String operand, Object value) {
            assertObjectNotNull("subQuery<MyselfCheckCB>", subQuery);
            MyselfCheckCB cb = new MyselfCheckCB(); cb.xsetupForDerivedReferrer(this); subQuery.Invoke(cb);
            String subQueryPropertyName = keepMyselfId_QueryDerivedReferrer_MyselfCheckList(cb.Query()); // for saving query-value.
            String parameterPropertyName = keepMyselfId_QueryDerivedReferrer_MyselfCheckListParameter(value);
            registerQueryDerivedReferrer(function, cb.Query(), "MYSELF_ID", "MYSELF_ID", subQueryPropertyName, operand, value, parameterPropertyName);
        }
        public abstract String keepMyselfId_QueryDerivedReferrer_MyselfCheckList(MyselfCheckCQ subQuery);
        public abstract String keepMyselfId_QueryDerivedReferrer_MyselfCheckListParameter(Object parameterValue);
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
        public SSQFunction<MyselfCB> Scalar_Equal() {
            return xcreateSSQFunction("=");
        }

        public SSQFunction<MyselfCB> Scalar_NotEqual() {
            return xcreateSSQFunction("<>");
        }

        public SSQFunction<MyselfCB> Scalar_GreaterEqual() {
            return xcreateSSQFunction(">=");
        }

        public SSQFunction<MyselfCB> Scalar_GreaterThan() {
            return xcreateSSQFunction(">");
        }

        public SSQFunction<MyselfCB> Scalar_LessEqual() {
            return xcreateSSQFunction("<=");
        }

        public SSQFunction<MyselfCB> Scalar_LessThan() {
            return xcreateSSQFunction("<");
        }

        protected SSQFunction<MyselfCB> xcreateSSQFunction(String operand) {
            return new SSQFunction<MyselfCB>(delegate(String function, SubQuery<MyselfCB> subQuery) {
                xscalarSubQuery(function, subQuery, operand);
            });
        }

        protected void xscalarSubQuery(String function, SubQuery<MyselfCB> subQuery, String operand) {
            assertObjectNotNull("subQuery<MyselfCB>", subQuery);
            MyselfCB cb = new MyselfCB(); cb.xsetupForScalarCondition(this); subQuery.Invoke(cb);
            String subQueryPropertyName = keepScalarSubQuery(cb.Query()); // for saving query-value.
            registerScalarSubQuery(function, cb.Query(), subQueryPropertyName, operand);
        }
        public abstract String keepScalarSubQuery(MyselfCQ subQuery);

        // ===============================================================================
        //                                                                  MySelf InScope
        //                                                                  ==============
        public void MyselfInScope(SubQuery<MyselfCB> subQuery) {
            assertObjectNotNull("subQuery<MyselfCB>", subQuery);
            MyselfCB cb = new MyselfCB(); cb.xsetupForInScopeRelation(this); subQuery.Invoke(cb);
            String subQueryPropertyName = keepMyselfInScopeSubQuery(cb.Query()); // for saving query-value.
            registerInScopeSubQuery(cb.Query(), "MYSELF_ID", "MYSELF_ID", subQueryPropertyName);
        }
        public abstract String keepMyselfInScopeSubQuery(MyselfCQ subQuery);

        public override String ToString() { return xgetSqlClause().getClause(); }
    }
}
