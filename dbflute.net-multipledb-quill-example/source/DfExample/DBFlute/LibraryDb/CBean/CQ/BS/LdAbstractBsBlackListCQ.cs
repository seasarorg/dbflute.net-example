
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
    public abstract class LdAbstractBsBlackListCQ : LdAbstractConditionQuery {

        public LdAbstractBsBlackListCQ(LdConditionQuery childQuery, LdSqlClause sqlClause, String aliasName, int nestLevel)
            : base(childQuery, sqlClause, aliasName, nestLevel) {}

        public override String getTableDbName() { return "black_list"; }
        public override String getTableSqlName() { return "black_list"; }

        public void SetBlackListId_Equal(int? v) { regBlackListId(CK_EQ, v); }
        public void SetBlackListId_NotEqual(int? v) { regBlackListId(CK_NES, v); }
        public void SetBlackListId_GreaterThan(int? v) { regBlackListId(CK_GT, v); }
        public void SetBlackListId_LessThan(int? v) { regBlackListId(CK_LT, v); }
        public void SetBlackListId_GreaterEqual(int? v) { regBlackListId(CK_GE, v); }
        public void SetBlackListId_LessEqual(int? v) { regBlackListId(CK_LE, v); }
        public void SetBlackListId_InScope(IList<int?> ls) { regINS<int?>(CK_INS, cTL<int?>(ls), getCValueBlackListId(), "BLACK_LIST_ID"); }
        public void SetBlackListId_NotInScope(IList<int?> ls) { regINS<int?>(CK_NINS, cTL<int?>(ls), getCValueBlackListId(), "BLACK_LIST_ID"); }
        public void ExistsBlackActionList(LdSubQuery<LdBlackActionCB> subQuery) {
            assertObjectNotNull("subQuery<LdBlackActionCB>", subQuery);
            LdBlackActionCB cb = new LdBlackActionCB(); cb.xsetupForExistsReferrer(this); subQuery.Invoke(cb);
            String subQueryPropertyName = keepBlackListId_ExistsSubQuery_BlackActionList(cb.Query());
            registerExistsSubQuery(cb.Query(), "BLACK_LIST_ID", "BLACK_LIST_ID", subQueryPropertyName);
        }
        public abstract String keepBlackListId_ExistsSubQuery_BlackActionList(LdBlackActionCQ subQuery);
        public void NotExistsBlackActionList(LdSubQuery<LdBlackActionCB> subQuery) {
            assertObjectNotNull("subQuery<LdBlackActionCB>", subQuery);
            LdBlackActionCB cb = new LdBlackActionCB(); cb.xsetupForExistsReferrer(this); subQuery.Invoke(cb);
            String subQueryPropertyName = keepBlackListId_NotExistsSubQuery_BlackActionList(cb.Query());
            registerNotExistsSubQuery(cb.Query(), "BLACK_LIST_ID", "BLACK_LIST_ID", subQueryPropertyName);
        }
        public abstract String keepBlackListId_NotExistsSubQuery_BlackActionList(LdBlackActionCQ subQuery);
        public void InScopeBlackActionList(LdSubQuery<LdBlackActionCB> subQuery) {
            assertObjectNotNull("subQuery<LdBlackActionCB>", subQuery);
            LdBlackActionCB cb = new LdBlackActionCB(); cb.xsetupForInScopeRelation(this); subQuery.Invoke(cb);
            String subQueryPropertyName = keepBlackListId_InScopeSubQuery_BlackActionList(cb.Query());
            registerInScopeSubQuery(cb.Query(), "BLACK_LIST_ID", "BLACK_LIST_ID", subQueryPropertyName);
        }
        public abstract String keepBlackListId_InScopeSubQuery_BlackActionList(LdBlackActionCQ subQuery);
        public void NotInScopeBlackActionList(LdSubQuery<LdBlackActionCB> subQuery) {
            assertObjectNotNull("subQuery<LdBlackActionCB>", subQuery);
            LdBlackActionCB cb = new LdBlackActionCB(); cb.xsetupForInScopeRelation(this); subQuery.Invoke(cb);
            String subQueryPropertyName = keepBlackListId_NotInScopeSubQuery_BlackActionList(cb.Query());
            registerNotInScopeSubQuery(cb.Query(), "BLACK_LIST_ID", "BLACK_LIST_ID", subQueryPropertyName);
        }
        public abstract String keepBlackListId_NotInScopeSubQuery_BlackActionList(LdBlackActionCQ subQuery);
        public void xsderiveBlackActionList(String function, LdSubQuery<LdBlackActionCB> subQuery, String aliasName) {
            assertObjectNotNull("subQuery<LdBlackActionCB>", subQuery);
            LdBlackActionCB cb = new LdBlackActionCB(); cb.xsetupForDerivedReferrer(this); subQuery.Invoke(cb);
            String subQueryPropertyName = keepBlackListId_SpecifyDerivedReferrer_BlackActionList(cb.Query());
            registerSpecifyDerivedReferrer(function, cb.Query(), "BLACK_LIST_ID", "BLACK_LIST_ID", subQueryPropertyName, aliasName);
        }
        abstract public String keepBlackListId_SpecifyDerivedReferrer_BlackActionList(LdBlackActionCQ subQuery);

        public QDRFunction<LdBlackActionCB> DerivedBlackActionList() {
            return xcreateQDRFunctionBlackActionList();
        }
        protected QDRFunction<LdBlackActionCB> xcreateQDRFunctionBlackActionList() {
            return new QDRFunction<LdBlackActionCB>(delegate(String function, LdSubQuery<LdBlackActionCB> subQuery, String operand, Object value) {
                xqderiveBlackActionList(function, subQuery, operand, value);
            });
        }
        public void xqderiveBlackActionList(String function, LdSubQuery<LdBlackActionCB> subQuery, String operand, Object value) {
            assertObjectNotNull("subQuery<LdBlackActionCB>", subQuery);
            LdBlackActionCB cb = new LdBlackActionCB(); cb.xsetupForDerivedReferrer(this); subQuery.Invoke(cb);
            String subQueryPropertyName = keepBlackListId_QueryDerivedReferrer_BlackActionList(cb.Query()); // for saving query-value.
            String parameterPropertyName = keepBlackListId_QueryDerivedReferrer_BlackActionListParameter(value);
            registerQueryDerivedReferrer(function, cb.Query(), "BLACK_LIST_ID", "BLACK_LIST_ID", subQueryPropertyName, operand, value, parameterPropertyName);
        }
        public abstract String keepBlackListId_QueryDerivedReferrer_BlackActionList(LdBlackActionCQ subQuery);
        public abstract String keepBlackListId_QueryDerivedReferrer_BlackActionListParameter(Object parameterValue);
        public void SetBlackListId_IsNull() { regBlackListId(CK_ISN, DUMMY_OBJECT); }
        public void SetBlackListId_IsNotNull() { regBlackListId(CK_ISNN, DUMMY_OBJECT); }
        protected void regBlackListId(LdConditionKey k, Object v) { regQ(k, v, getCValueBlackListId(), "BLACK_LIST_ID"); }
        protected abstract LdConditionValue getCValueBlackListId();

        public void SetLbUserId_Equal(int? v) { regLbUserId(CK_EQ, v); }
        public void SetLbUserId_NotEqual(int? v) { regLbUserId(CK_NES, v); }
        public void SetLbUserId_GreaterThan(int? v) { regLbUserId(CK_GT, v); }
        public void SetLbUserId_LessThan(int? v) { regLbUserId(CK_LT, v); }
        public void SetLbUserId_GreaterEqual(int? v) { regLbUserId(CK_GE, v); }
        public void SetLbUserId_LessEqual(int? v) { regLbUserId(CK_LE, v); }
        public void SetLbUserId_InScope(IList<int?> ls) { regINS<int?>(CK_INS, cTL<int?>(ls), getCValueLbUserId(), "LB_USER_ID"); }
        public void SetLbUserId_NotInScope(IList<int?> ls) { regINS<int?>(CK_NINS, cTL<int?>(ls), getCValueLbUserId(), "LB_USER_ID"); }
        public void InScopeLbUser(LdSubQuery<LdLbUserCB> subQuery) {
            assertObjectNotNull("subQuery<LdLbUserCB>", subQuery);
            LdLbUserCB cb = new LdLbUserCB(); cb.xsetupForInScopeRelation(this); subQuery.Invoke(cb);
            String subQueryPropertyName = keepLbUserId_InScopeSubQuery_LbUser(cb.Query());
            registerInScopeSubQuery(cb.Query(), "LB_USER_ID", "LB_USER_ID", subQueryPropertyName);
        }
        public abstract String keepLbUserId_InScopeSubQuery_LbUser(LdLbUserCQ subQuery);
        public void NotInScopeLbUser(LdSubQuery<LdLbUserCB> subQuery) {
            assertObjectNotNull("subQuery<LdLbUserCB>", subQuery);
            LdLbUserCB cb = new LdLbUserCB(); cb.xsetupForInScopeRelation(this); subQuery.Invoke(cb);
            String subQueryPropertyName = keepLbUserId_NotInScopeSubQuery_LbUser(cb.Query());
            registerNotInScopeSubQuery(cb.Query(), "LB_USER_ID", "LB_USER_ID", subQueryPropertyName);
        }
        public abstract String keepLbUserId_NotInScopeSubQuery_LbUser(LdLbUserCQ subQuery);
        protected void regLbUserId(LdConditionKey k, Object v) { regQ(k, v, getCValueLbUserId(), "LB_USER_ID"); }
        protected abstract LdConditionValue getCValueLbUserId();

        public void SetBlackRank_Equal(String v) { DoSetBlackRank_Equal(fRES(v)); }
        protected void DoSetBlackRank_Equal(String v) { regBlackRank(CK_EQ, v); }
        public void SetBlackRank_NotEqual(String v) { DoSetBlackRank_NotEqual(fRES(v)); }
        protected void DoSetBlackRank_NotEqual(String v) { regBlackRank(CK_NES, v); }
        public void SetBlackRank_GreaterThan(String v) { regBlackRank(CK_GT, fRES(v)); }
        public void SetBlackRank_LessThan(String v) { regBlackRank(CK_LT, fRES(v)); }
        public void SetBlackRank_GreaterEqual(String v) { regBlackRank(CK_GE, fRES(v)); }
        public void SetBlackRank_LessEqual(String v) { regBlackRank(CK_LE, fRES(v)); }
        public void SetBlackRank_InScope(IList<String> ls) { regINS<String>(CK_INS, cTL<String>(ls), getCValueBlackRank(), "BLACK_RANK"); }
        public void SetBlackRank_NotInScope(IList<String> ls) { regINS<String>(CK_NINS, cTL<String>(ls), getCValueBlackRank(), "BLACK_RANK"); }
        public void SetBlackRank_PrefixSearch(String v) { SetBlackRank_LikeSearch(v, cLSOP()); }
        public void SetBlackRank_LikeSearch(String v, LdLikeSearchOption option)
        { regLSQ(CK_LS, fRES(v), getCValueBlackRank(), "BLACK_RANK", option); }
        public void SetBlackRank_NotLikeSearch(String v, LdLikeSearchOption option)
        { regLSQ(CK_NLS, fRES(v), getCValueBlackRank(), "BLACK_RANK", option); }
        protected void regBlackRank(LdConditionKey k, Object v) { regQ(k, v, getCValueBlackRank(), "BLACK_RANK"); }
        protected abstract LdConditionValue getCValueBlackRank();

        public void SetRUser_Equal(String v) { DoSetRUser_Equal(fRES(v)); }
        protected void DoSetRUser_Equal(String v) { regRUser(CK_EQ, v); }
        public void SetRUser_NotEqual(String v) { DoSetRUser_NotEqual(fRES(v)); }
        protected void DoSetRUser_NotEqual(String v) { regRUser(CK_NES, v); }
        public void SetRUser_GreaterThan(String v) { regRUser(CK_GT, fRES(v)); }
        public void SetRUser_LessThan(String v) { regRUser(CK_LT, fRES(v)); }
        public void SetRUser_GreaterEqual(String v) { regRUser(CK_GE, fRES(v)); }
        public void SetRUser_LessEqual(String v) { regRUser(CK_LE, fRES(v)); }
        public void SetRUser_InScope(IList<String> ls) { regINS<String>(CK_INS, cTL<String>(ls), getCValueRUser(), "R_USER"); }
        public void SetRUser_NotInScope(IList<String> ls) { regINS<String>(CK_NINS, cTL<String>(ls), getCValueRUser(), "R_USER"); }
        public void SetRUser_PrefixSearch(String v) { SetRUser_LikeSearch(v, cLSOP()); }
        public void SetRUser_LikeSearch(String v, LdLikeSearchOption option)
        { regLSQ(CK_LS, fRES(v), getCValueRUser(), "R_USER", option); }
        public void SetRUser_NotLikeSearch(String v, LdLikeSearchOption option)
        { regLSQ(CK_NLS, fRES(v), getCValueRUser(), "R_USER", option); }
        protected void regRUser(LdConditionKey k, Object v) { regQ(k, v, getCValueRUser(), "R_USER"); }
        protected abstract LdConditionValue getCValueRUser();

        public void SetRModule_Equal(String v) { DoSetRModule_Equal(fRES(v)); }
        protected void DoSetRModule_Equal(String v) { regRModule(CK_EQ, v); }
        public void SetRModule_NotEqual(String v) { DoSetRModule_NotEqual(fRES(v)); }
        protected void DoSetRModule_NotEqual(String v) { regRModule(CK_NES, v); }
        public void SetRModule_GreaterThan(String v) { regRModule(CK_GT, fRES(v)); }
        public void SetRModule_LessThan(String v) { regRModule(CK_LT, fRES(v)); }
        public void SetRModule_GreaterEqual(String v) { regRModule(CK_GE, fRES(v)); }
        public void SetRModule_LessEqual(String v) { regRModule(CK_LE, fRES(v)); }
        public void SetRModule_InScope(IList<String> ls) { regINS<String>(CK_INS, cTL<String>(ls), getCValueRModule(), "R_MODULE"); }
        public void SetRModule_NotInScope(IList<String> ls) { regINS<String>(CK_NINS, cTL<String>(ls), getCValueRModule(), "R_MODULE"); }
        public void SetRModule_PrefixSearch(String v) { SetRModule_LikeSearch(v, cLSOP()); }
        public void SetRModule_LikeSearch(String v, LdLikeSearchOption option)
        { regLSQ(CK_LS, fRES(v), getCValueRModule(), "R_MODULE", option); }
        public void SetRModule_NotLikeSearch(String v, LdLikeSearchOption option)
        { regLSQ(CK_NLS, fRES(v), getCValueRModule(), "R_MODULE", option); }
        protected void regRModule(LdConditionKey k, Object v) { regQ(k, v, getCValueRModule(), "R_MODULE"); }
        protected abstract LdConditionValue getCValueRModule();

        public void SetRTimestamp_Equal(DateTime? v) { regRTimestamp(CK_EQ, v); }
        public void SetRTimestamp_NotEqual(DateTime? v) { regRTimestamp(CK_NES, v); }
        public void SetRTimestamp_GreaterThan(DateTime? v) { regRTimestamp(CK_GT, v); }
        public void SetRTimestamp_LessThan(DateTime? v) { regRTimestamp(CK_LT, v); }
        public void SetRTimestamp_GreaterEqual(DateTime? v) { regRTimestamp(CK_GE, v); }
        public void SetRTimestamp_LessEqual(DateTime? v) { regRTimestamp(CK_LE, v); }
        public void SetRTimestamp_FromTo(DateTime? from, DateTime? to, LdFromToOption option)
        { regFTQ(from, to, getCValueRTimestamp(), "R_TIMESTAMP", option); }
        public void SetRTimestamp_DateFromTo(DateTime? from, DateTime? to) { SetRTimestamp_FromTo(from, to, new LdDateFromToOption()); }
        public void SetRTimestamp_InScope(IList<DateTime?> ls) { regINS<DateTime?>(CK_INS, cTL<DateTime?>(ls), getCValueRTimestamp(), "R_TIMESTAMP"); }
        public void SetRTimestamp_NotInScope(IList<DateTime?> ls) { regINS<DateTime?>(CK_NINS, cTL<DateTime?>(ls), getCValueRTimestamp(), "R_TIMESTAMP"); }
        protected void regRTimestamp(LdConditionKey k, Object v) { regQ(k, v, getCValueRTimestamp(), "R_TIMESTAMP"); }
        protected abstract LdConditionValue getCValueRTimestamp();

        public void SetUUser_Equal(String v) { DoSetUUser_Equal(fRES(v)); }
        protected void DoSetUUser_Equal(String v) { regUUser(CK_EQ, v); }
        public void SetUUser_NotEqual(String v) { DoSetUUser_NotEqual(fRES(v)); }
        protected void DoSetUUser_NotEqual(String v) { regUUser(CK_NES, v); }
        public void SetUUser_GreaterThan(String v) { regUUser(CK_GT, fRES(v)); }
        public void SetUUser_LessThan(String v) { regUUser(CK_LT, fRES(v)); }
        public void SetUUser_GreaterEqual(String v) { regUUser(CK_GE, fRES(v)); }
        public void SetUUser_LessEqual(String v) { regUUser(CK_LE, fRES(v)); }
        public void SetUUser_InScope(IList<String> ls) { regINS<String>(CK_INS, cTL<String>(ls), getCValueUUser(), "U_USER"); }
        public void SetUUser_NotInScope(IList<String> ls) { regINS<String>(CK_NINS, cTL<String>(ls), getCValueUUser(), "U_USER"); }
        public void SetUUser_PrefixSearch(String v) { SetUUser_LikeSearch(v, cLSOP()); }
        public void SetUUser_LikeSearch(String v, LdLikeSearchOption option)
        { regLSQ(CK_LS, fRES(v), getCValueUUser(), "U_USER", option); }
        public void SetUUser_NotLikeSearch(String v, LdLikeSearchOption option)
        { regLSQ(CK_NLS, fRES(v), getCValueUUser(), "U_USER", option); }
        protected void regUUser(LdConditionKey k, Object v) { regQ(k, v, getCValueUUser(), "U_USER"); }
        protected abstract LdConditionValue getCValueUUser();

        public void SetUModule_Equal(String v) { DoSetUModule_Equal(fRES(v)); }
        protected void DoSetUModule_Equal(String v) { regUModule(CK_EQ, v); }
        public void SetUModule_NotEqual(String v) { DoSetUModule_NotEqual(fRES(v)); }
        protected void DoSetUModule_NotEqual(String v) { regUModule(CK_NES, v); }
        public void SetUModule_GreaterThan(String v) { regUModule(CK_GT, fRES(v)); }
        public void SetUModule_LessThan(String v) { regUModule(CK_LT, fRES(v)); }
        public void SetUModule_GreaterEqual(String v) { regUModule(CK_GE, fRES(v)); }
        public void SetUModule_LessEqual(String v) { regUModule(CK_LE, fRES(v)); }
        public void SetUModule_InScope(IList<String> ls) { regINS<String>(CK_INS, cTL<String>(ls), getCValueUModule(), "U_MODULE"); }
        public void SetUModule_NotInScope(IList<String> ls) { regINS<String>(CK_NINS, cTL<String>(ls), getCValueUModule(), "U_MODULE"); }
        public void SetUModule_PrefixSearch(String v) { SetUModule_LikeSearch(v, cLSOP()); }
        public void SetUModule_LikeSearch(String v, LdLikeSearchOption option)
        { regLSQ(CK_LS, fRES(v), getCValueUModule(), "U_MODULE", option); }
        public void SetUModule_NotLikeSearch(String v, LdLikeSearchOption option)
        { regLSQ(CK_NLS, fRES(v), getCValueUModule(), "U_MODULE", option); }
        protected void regUModule(LdConditionKey k, Object v) { regQ(k, v, getCValueUModule(), "U_MODULE"); }
        protected abstract LdConditionValue getCValueUModule();

        public void SetUTimestamp_Equal(DateTime? v) { regUTimestamp(CK_EQ, v); }
        public void SetUTimestamp_NotEqual(DateTime? v) { regUTimestamp(CK_NES, v); }
        public void SetUTimestamp_GreaterThan(DateTime? v) { regUTimestamp(CK_GT, v); }
        public void SetUTimestamp_LessThan(DateTime? v) { regUTimestamp(CK_LT, v); }
        public void SetUTimestamp_GreaterEqual(DateTime? v) { regUTimestamp(CK_GE, v); }
        public void SetUTimestamp_LessEqual(DateTime? v) { regUTimestamp(CK_LE, v); }
        public void SetUTimestamp_FromTo(DateTime? from, DateTime? to, LdFromToOption option)
        { regFTQ(from, to, getCValueUTimestamp(), "U_TIMESTAMP", option); }
        public void SetUTimestamp_DateFromTo(DateTime? from, DateTime? to) { SetUTimestamp_FromTo(from, to, new LdDateFromToOption()); }
        public void SetUTimestamp_InScope(IList<DateTime?> ls) { regINS<DateTime?>(CK_INS, cTL<DateTime?>(ls), getCValueUTimestamp(), "U_TIMESTAMP"); }
        public void SetUTimestamp_NotInScope(IList<DateTime?> ls) { regINS<DateTime?>(CK_NINS, cTL<DateTime?>(ls), getCValueUTimestamp(), "U_TIMESTAMP"); }
        protected void regUTimestamp(LdConditionKey k, Object v) { regQ(k, v, getCValueUTimestamp(), "U_TIMESTAMP"); }
        protected abstract LdConditionValue getCValueUTimestamp();

        // ===================================================================================
        //                                                                    Scalar Condition
        //                                                                    ================
        public SSQFunction<LdBlackListCB> Scalar_Equal() {
            return xcreateSSQFunction("=");
        }

        public SSQFunction<LdBlackListCB> Scalar_NotEqual() {
            return xcreateSSQFunction("<>");
        }

        public SSQFunction<LdBlackListCB> Scalar_GreaterEqual() {
            return xcreateSSQFunction(">=");
        }

        public SSQFunction<LdBlackListCB> Scalar_GreaterThan() {
            return xcreateSSQFunction(">");
        }

        public SSQFunction<LdBlackListCB> Scalar_LessEqual() {
            return xcreateSSQFunction("<=");
        }

        public SSQFunction<LdBlackListCB> Scalar_LessThan() {
            return xcreateSSQFunction("<");
        }

        protected SSQFunction<LdBlackListCB> xcreateSSQFunction(String operand) {
            return new SSQFunction<LdBlackListCB>(delegate(String function, LdSubQuery<LdBlackListCB> subQuery) {
                xscalarSubQuery(function, subQuery, operand);
            });
        }

        protected void xscalarSubQuery(String function, LdSubQuery<LdBlackListCB> subQuery, String operand) {
            assertObjectNotNull("subQuery<LdBlackListCB>", subQuery);
            LdBlackListCB cb = new LdBlackListCB(); cb.xsetupForScalarCondition(this); subQuery.Invoke(cb);
            String subQueryPropertyName = keepScalarSubQuery(cb.Query()); // for saving query-value.
            registerScalarSubQuery(function, cb.Query(), subQueryPropertyName, operand);
        }
        public abstract String keepScalarSubQuery(LdBlackListCQ subQuery);

        // ===============================================================================
        //                                                                  MySelf InScope
        //                                                                  ==============
        public void MyselfInScope(LdSubQuery<LdBlackListCB> subQuery) {
            assertObjectNotNull("subQuery<LdBlackListCB>", subQuery);
            LdBlackListCB cb = new LdBlackListCB(); cb.xsetupForInScopeRelation(this); subQuery.Invoke(cb);
            String subQueryPropertyName = keepMyselfInScopeSubQuery(cb.Query()); // for saving query-value.
            registerInScopeSubQuery(cb.Query(), "BLACK_LIST_ID", "BLACK_LIST_ID", subQueryPropertyName);
        }
        public abstract String keepMyselfInScopeSubQuery(LdBlackListCQ subQuery);

        public override String ToString() { return xgetSqlClause().getClause(); }
    }
}
