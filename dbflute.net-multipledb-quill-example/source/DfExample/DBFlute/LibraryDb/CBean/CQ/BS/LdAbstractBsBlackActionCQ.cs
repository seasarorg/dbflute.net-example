
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
    public abstract class LdAbstractBsBlackActionCQ : LdAbstractConditionQuery {

        public LdAbstractBsBlackActionCQ(LdConditionQuery childQuery, LdSqlClause sqlClause, String aliasName, int nestLevel)
            : base(childQuery, sqlClause, aliasName, nestLevel) {}

        public override String getTableDbName() { return "black_action"; }
        public override String getTableSqlName() { return "black_action"; }

        public void SetBlackActionId_Equal(int? v) { regBlackActionId(CK_EQ, v); }
        public void SetBlackActionId_NotEqual(int? v) { regBlackActionId(CK_NES, v); }
        public void SetBlackActionId_GreaterThan(int? v) { regBlackActionId(CK_GT, v); }
        public void SetBlackActionId_LessThan(int? v) { regBlackActionId(CK_LT, v); }
        public void SetBlackActionId_GreaterEqual(int? v) { regBlackActionId(CK_GE, v); }
        public void SetBlackActionId_LessEqual(int? v) { regBlackActionId(CK_LE, v); }
        public void SetBlackActionId_InScope(IList<int?> ls) { regINS<int?>(CK_INS, cTL<int?>(ls), getCValueBlackActionId(), "BLACK_ACTION_ID"); }
        public void SetBlackActionId_NotInScope(IList<int?> ls) { regINS<int?>(CK_NINS, cTL<int?>(ls), getCValueBlackActionId(), "BLACK_ACTION_ID"); }
        public void SetBlackActionId_IsNull() { regBlackActionId(CK_ISN, DUMMY_OBJECT); }
        public void SetBlackActionId_IsNotNull() { regBlackActionId(CK_ISNN, DUMMY_OBJECT); }
        protected void regBlackActionId(LdConditionKey k, Object v) { regQ(k, v, getCValueBlackActionId(), "BLACK_ACTION_ID"); }
        protected abstract LdConditionValue getCValueBlackActionId();

        public void SetBlackListId_Equal(int? v) { regBlackListId(CK_EQ, v); }
        public void SetBlackListId_NotEqual(int? v) { regBlackListId(CK_NES, v); }
        public void SetBlackListId_GreaterThan(int? v) { regBlackListId(CK_GT, v); }
        public void SetBlackListId_LessThan(int? v) { regBlackListId(CK_LT, v); }
        public void SetBlackListId_GreaterEqual(int? v) { regBlackListId(CK_GE, v); }
        public void SetBlackListId_LessEqual(int? v) { regBlackListId(CK_LE, v); }
        public void SetBlackListId_InScope(IList<int?> ls) { regINS<int?>(CK_INS, cTL<int?>(ls), getCValueBlackListId(), "BLACK_LIST_ID"); }
        public void SetBlackListId_NotInScope(IList<int?> ls) { regINS<int?>(CK_NINS, cTL<int?>(ls), getCValueBlackListId(), "BLACK_LIST_ID"); }
        public void InScopeBlackList(LdSubQuery<LdBlackListCB> subQuery) {
            assertObjectNotNull("subQuery<LdBlackListCB>", subQuery);
            LdBlackListCB cb = new LdBlackListCB(); cb.xsetupForInScopeRelation(this); subQuery.Invoke(cb);
            String subQueryPropertyName = keepBlackListId_InScopeSubQuery_BlackList(cb.Query());
            registerInScopeSubQuery(cb.Query(), "BLACK_LIST_ID", "BLACK_LIST_ID", subQueryPropertyName);
        }
        public abstract String keepBlackListId_InScopeSubQuery_BlackList(LdBlackListCQ subQuery);
        public void NotInScopeBlackList(LdSubQuery<LdBlackListCB> subQuery) {
            assertObjectNotNull("subQuery<LdBlackListCB>", subQuery);
            LdBlackListCB cb = new LdBlackListCB(); cb.xsetupForInScopeRelation(this); subQuery.Invoke(cb);
            String subQueryPropertyName = keepBlackListId_NotInScopeSubQuery_BlackList(cb.Query());
            registerNotInScopeSubQuery(cb.Query(), "BLACK_LIST_ID", "BLACK_LIST_ID", subQueryPropertyName);
        }
        public abstract String keepBlackListId_NotInScopeSubQuery_BlackList(LdBlackListCQ subQuery);
        protected void regBlackListId(LdConditionKey k, Object v) { regQ(k, v, getCValueBlackListId(), "BLACK_LIST_ID"); }
        protected abstract LdConditionValue getCValueBlackListId();

        public void SetBlackActionCode_Equal(String v) { DoSetBlackActionCode_Equal(fRES(v)); }
        protected void DoSetBlackActionCode_Equal(String v) { regBlackActionCode(CK_EQ, v); }
        public void SetBlackActionCode_NotEqual(String v) { DoSetBlackActionCode_NotEqual(fRES(v)); }
        protected void DoSetBlackActionCode_NotEqual(String v) { regBlackActionCode(CK_NES, v); }
        public void SetBlackActionCode_GreaterThan(String v) { regBlackActionCode(CK_GT, fRES(v)); }
        public void SetBlackActionCode_LessThan(String v) { regBlackActionCode(CK_LT, fRES(v)); }
        public void SetBlackActionCode_GreaterEqual(String v) { regBlackActionCode(CK_GE, fRES(v)); }
        public void SetBlackActionCode_LessEqual(String v) { regBlackActionCode(CK_LE, fRES(v)); }
        public void SetBlackActionCode_InScope(IList<String> ls) { regINS<String>(CK_INS, cTL<String>(ls), getCValueBlackActionCode(), "BLACK_ACTION_CODE"); }
        public void SetBlackActionCode_NotInScope(IList<String> ls) { regINS<String>(CK_NINS, cTL<String>(ls), getCValueBlackActionCode(), "BLACK_ACTION_CODE"); }
        public void SetBlackActionCode_PrefixSearch(String v) { SetBlackActionCode_LikeSearch(v, cLSOP()); }
        public void SetBlackActionCode_LikeSearch(String v, LdLikeSearchOption option)
        { regLSQ(CK_LS, fRES(v), getCValueBlackActionCode(), "BLACK_ACTION_CODE", option); }
        public void SetBlackActionCode_NotLikeSearch(String v, LdLikeSearchOption option)
        { regLSQ(CK_NLS, fRES(v), getCValueBlackActionCode(), "BLACK_ACTION_CODE", option); }
        public void InScopeBlackActionLookup(LdSubQuery<LdBlackActionLookupCB> subQuery) {
            assertObjectNotNull("subQuery<LdBlackActionLookupCB>", subQuery);
            LdBlackActionLookupCB cb = new LdBlackActionLookupCB(); cb.xsetupForInScopeRelation(this); subQuery.Invoke(cb);
            String subQueryPropertyName = keepBlackActionCode_InScopeSubQuery_BlackActionLookup(cb.Query());
            registerInScopeSubQuery(cb.Query(), "BLACK_ACTION_CODE", "BLACK_ACTION_CODE", subQueryPropertyName);
        }
        public abstract String keepBlackActionCode_InScopeSubQuery_BlackActionLookup(LdBlackActionLookupCQ subQuery);
        public void NotInScopeBlackActionLookup(LdSubQuery<LdBlackActionLookupCB> subQuery) {
            assertObjectNotNull("subQuery<LdBlackActionLookupCB>", subQuery);
            LdBlackActionLookupCB cb = new LdBlackActionLookupCB(); cb.xsetupForInScopeRelation(this); subQuery.Invoke(cb);
            String subQueryPropertyName = keepBlackActionCode_NotInScopeSubQuery_BlackActionLookup(cb.Query());
            registerNotInScopeSubQuery(cb.Query(), "BLACK_ACTION_CODE", "BLACK_ACTION_CODE", subQueryPropertyName);
        }
        public abstract String keepBlackActionCode_NotInScopeSubQuery_BlackActionLookup(LdBlackActionLookupCQ subQuery);
        protected void regBlackActionCode(LdConditionKey k, Object v) { regQ(k, v, getCValueBlackActionCode(), "BLACK_ACTION_CODE"); }
        protected abstract LdConditionValue getCValueBlackActionCode();

        public void SetBlackLevel_Equal(int? v) { regBlackLevel(CK_EQ, v); }
        public void SetBlackLevel_NotEqual(int? v) { regBlackLevel(CK_NES, v); }
        public void SetBlackLevel_GreaterThan(int? v) { regBlackLevel(CK_GT, v); }
        public void SetBlackLevel_LessThan(int? v) { regBlackLevel(CK_LT, v); }
        public void SetBlackLevel_GreaterEqual(int? v) { regBlackLevel(CK_GE, v); }
        public void SetBlackLevel_LessEqual(int? v) { regBlackLevel(CK_LE, v); }
        public void SetBlackLevel_InScope(IList<int?> ls) { regINS<int?>(CK_INS, cTL<int?>(ls), getCValueBlackLevel(), "BLACK_LEVEL"); }
        public void SetBlackLevel_NotInScope(IList<int?> ls) { regINS<int?>(CK_NINS, cTL<int?>(ls), getCValueBlackLevel(), "BLACK_LEVEL"); }
        protected void regBlackLevel(LdConditionKey k, Object v) { regQ(k, v, getCValueBlackLevel(), "BLACK_LEVEL"); }
        protected abstract LdConditionValue getCValueBlackLevel();

        public void SetActionDate_Equal(DateTime? v) { regActionDate(CK_EQ, v); }
        public void SetActionDate_NotEqual(DateTime? v) { regActionDate(CK_NES, v); }
        public void SetActionDate_GreaterThan(DateTime? v) { regActionDate(CK_GT, v); }
        public void SetActionDate_LessThan(DateTime? v) { regActionDate(CK_LT, v); }
        public void SetActionDate_GreaterEqual(DateTime? v) { regActionDate(CK_GE, v); }
        public void SetActionDate_LessEqual(DateTime? v) { regActionDate(CK_LE, v); }
        public void SetActionDate_FromTo(DateTime? from, DateTime? to, LdFromToOption option)
        { regFTQ(from, to, getCValueActionDate(), "ACTION_DATE", option); }
        public void SetActionDate_DateFromTo(DateTime? from, DateTime? to) { SetActionDate_FromTo(from, to, new LdDateFromToOption()); }
        public void SetActionDate_InScope(IList<DateTime?> ls) { regINS<DateTime?>(CK_INS, cTL<DateTime?>(ls), getCValueActionDate(), "ACTION_DATE"); }
        public void SetActionDate_NotInScope(IList<DateTime?> ls) { regINS<DateTime?>(CK_NINS, cTL<DateTime?>(ls), getCValueActionDate(), "ACTION_DATE"); }
        public void SetActionDate_IsNull() { regActionDate(CK_ISN, DUMMY_OBJECT); }
        public void SetActionDate_IsNotNull() { regActionDate(CK_ISNN, DUMMY_OBJECT); }
        protected void regActionDate(LdConditionKey k, Object v) { regQ(k, v, getCValueActionDate(), "ACTION_DATE"); }
        protected abstract LdConditionValue getCValueActionDate();
        public void SetEvidencePhotograph_IsNull() { regEvidencePhotograph(CK_ISN, DUMMY_OBJECT); }
        public void SetEvidencePhotograph_IsNotNull() { regEvidencePhotograph(CK_ISNN, DUMMY_OBJECT); }
        protected void regEvidencePhotograph(LdConditionKey k, Object v) { regQ(k, v, getCValueEvidencePhotograph(), "EVIDENCE_PHOTOGRAPH"); }
        protected abstract LdConditionValue getCValueEvidencePhotograph();

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
        public SSQFunction<LdBlackActionCB> Scalar_Equal() {
            return xcreateSSQFunction("=");
        }

        public SSQFunction<LdBlackActionCB> Scalar_NotEqual() {
            return xcreateSSQFunction("<>");
        }

        public SSQFunction<LdBlackActionCB> Scalar_GreaterEqual() {
            return xcreateSSQFunction(">=");
        }

        public SSQFunction<LdBlackActionCB> Scalar_GreaterThan() {
            return xcreateSSQFunction(">");
        }

        public SSQFunction<LdBlackActionCB> Scalar_LessEqual() {
            return xcreateSSQFunction("<=");
        }

        public SSQFunction<LdBlackActionCB> Scalar_LessThan() {
            return xcreateSSQFunction("<");
        }

        protected SSQFunction<LdBlackActionCB> xcreateSSQFunction(String operand) {
            return new SSQFunction<LdBlackActionCB>(delegate(String function, LdSubQuery<LdBlackActionCB> subQuery) {
                xscalarSubQuery(function, subQuery, operand);
            });
        }

        protected void xscalarSubQuery(String function, LdSubQuery<LdBlackActionCB> subQuery, String operand) {
            assertObjectNotNull("subQuery<LdBlackActionCB>", subQuery);
            LdBlackActionCB cb = new LdBlackActionCB(); cb.xsetupForScalarCondition(this); subQuery.Invoke(cb);
            String subQueryPropertyName = keepScalarSubQuery(cb.Query()); // for saving query-value.
            registerScalarSubQuery(function, cb.Query(), subQueryPropertyName, operand);
        }
        public abstract String keepScalarSubQuery(LdBlackActionCQ subQuery);

        // ===============================================================================
        //                                                                  MySelf InScope
        //                                                                  ==============
        public void MyselfInScope(LdSubQuery<LdBlackActionCB> subQuery) {
            assertObjectNotNull("subQuery<LdBlackActionCB>", subQuery);
            LdBlackActionCB cb = new LdBlackActionCB(); cb.xsetupForInScopeRelation(this); subQuery.Invoke(cb);
            String subQueryPropertyName = keepMyselfInScopeSubQuery(cb.Query()); // for saving query-value.
            registerInScopeSubQuery(cb.Query(), "BLACK_ACTION_ID", "BLACK_ACTION_ID", subQueryPropertyName);
        }
        public abstract String keepMyselfInScopeSubQuery(LdBlackActionCQ subQuery);

        public override String ToString() { return xgetSqlClause().getClause(); }
    }
}
