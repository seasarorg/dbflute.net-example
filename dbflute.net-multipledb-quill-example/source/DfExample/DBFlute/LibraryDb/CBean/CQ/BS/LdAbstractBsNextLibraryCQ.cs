
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
    public abstract class LdAbstractBsNextLibraryCQ : LdAbstractConditionQuery {

        public LdAbstractBsNextLibraryCQ(LdConditionQuery childQuery, LdSqlClause sqlClause, String aliasName, int nestLevel)
            : base(childQuery, sqlClause, aliasName, nestLevel) {}

        public override String getTableDbName() { return "next_library"; }
        public override String getTableSqlName() { return "next_library"; }

        public void SetLibraryId_Equal(int? v) { regLibraryId(CK_EQ, v); }
        public void SetLibraryId_NotEqual(int? v) { regLibraryId(CK_NES, v); }
        public void SetLibraryId_GreaterThan(int? v) { regLibraryId(CK_GT, v); }
        public void SetLibraryId_LessThan(int? v) { regLibraryId(CK_LT, v); }
        public void SetLibraryId_GreaterEqual(int? v) { regLibraryId(CK_GE, v); }
        public void SetLibraryId_LessEqual(int? v) { regLibraryId(CK_LE, v); }
        public void SetLibraryId_InScope(IList<int?> ls) { regINS<int?>(CK_INS, cTL<int?>(ls), getCValueLibraryId(), "LIBRARY_ID"); }
        public void SetLibraryId_NotInScope(IList<int?> ls) { regINS<int?>(CK_NINS, cTL<int?>(ls), getCValueLibraryId(), "LIBRARY_ID"); }
        public void InScopeLibraryByLibraryId(LdSubQuery<LdLibraryCB> subQuery) {
            assertObjectNotNull("subQuery<LdLibraryCB>", subQuery);
            LdLibraryCB cb = new LdLibraryCB(); cb.xsetupForInScopeRelation(this); subQuery.Invoke(cb);
            String subQueryPropertyName = keepLibraryId_InScopeSubQuery_LibraryByLibraryId(cb.Query());
            registerInScopeSubQuery(cb.Query(), "LIBRARY_ID", "LIBRARY_ID", subQueryPropertyName);
        }
        public abstract String keepLibraryId_InScopeSubQuery_LibraryByLibraryId(LdLibraryCQ subQuery);
        public void NotInScopeLibraryByLibraryId(LdSubQuery<LdLibraryCB> subQuery) {
            assertObjectNotNull("subQuery<LdLibraryCB>", subQuery);
            LdLibraryCB cb = new LdLibraryCB(); cb.xsetupForInScopeRelation(this); subQuery.Invoke(cb);
            String subQueryPropertyName = keepLibraryId_NotInScopeSubQuery_LibraryByLibraryId(cb.Query());
            registerNotInScopeSubQuery(cb.Query(), "LIBRARY_ID", "LIBRARY_ID", subQueryPropertyName);
        }
        public abstract String keepLibraryId_NotInScopeSubQuery_LibraryByLibraryId(LdLibraryCQ subQuery);
        public void SetLibraryId_IsNull() { regLibraryId(CK_ISN, DUMMY_OBJECT); }
        public void SetLibraryId_IsNotNull() { regLibraryId(CK_ISNN, DUMMY_OBJECT); }
        protected void regLibraryId(LdConditionKey k, Object v) { regQ(k, v, getCValueLibraryId(), "LIBRARY_ID"); }
        protected abstract LdConditionValue getCValueLibraryId();

        public void SetNextLibraryId_Equal(int? v) { regNextLibraryId(CK_EQ, v); }
        public void SetNextLibraryId_NotEqual(int? v) { regNextLibraryId(CK_NES, v); }
        public void SetNextLibraryId_GreaterThan(int? v) { regNextLibraryId(CK_GT, v); }
        public void SetNextLibraryId_LessThan(int? v) { regNextLibraryId(CK_LT, v); }
        public void SetNextLibraryId_GreaterEqual(int? v) { regNextLibraryId(CK_GE, v); }
        public void SetNextLibraryId_LessEqual(int? v) { regNextLibraryId(CK_LE, v); }
        public void SetNextLibraryId_InScope(IList<int?> ls) { regINS<int?>(CK_INS, cTL<int?>(ls), getCValueNextLibraryId(), "NEXT_LIBRARY_ID"); }
        public void SetNextLibraryId_NotInScope(IList<int?> ls) { regINS<int?>(CK_NINS, cTL<int?>(ls), getCValueNextLibraryId(), "NEXT_LIBRARY_ID"); }
        public void InScopeLibraryByNextLibraryId(LdSubQuery<LdLibraryCB> subQuery) {
            assertObjectNotNull("subQuery<LdLibraryCB>", subQuery);
            LdLibraryCB cb = new LdLibraryCB(); cb.xsetupForInScopeRelation(this); subQuery.Invoke(cb);
            String subQueryPropertyName = keepNextLibraryId_InScopeSubQuery_LibraryByNextLibraryId(cb.Query());
            registerInScopeSubQuery(cb.Query(), "NEXT_LIBRARY_ID", "LIBRARY_ID", subQueryPropertyName);
        }
        public abstract String keepNextLibraryId_InScopeSubQuery_LibraryByNextLibraryId(LdLibraryCQ subQuery);
        public void NotInScopeLibraryByNextLibraryId(LdSubQuery<LdLibraryCB> subQuery) {
            assertObjectNotNull("subQuery<LdLibraryCB>", subQuery);
            LdLibraryCB cb = new LdLibraryCB(); cb.xsetupForInScopeRelation(this); subQuery.Invoke(cb);
            String subQueryPropertyName = keepNextLibraryId_NotInScopeSubQuery_LibraryByNextLibraryId(cb.Query());
            registerNotInScopeSubQuery(cb.Query(), "NEXT_LIBRARY_ID", "LIBRARY_ID", subQueryPropertyName);
        }
        public abstract String keepNextLibraryId_NotInScopeSubQuery_LibraryByNextLibraryId(LdLibraryCQ subQuery);
        public void SetNextLibraryId_IsNull() { regNextLibraryId(CK_ISN, DUMMY_OBJECT); }
        public void SetNextLibraryId_IsNotNull() { regNextLibraryId(CK_ISNN, DUMMY_OBJECT); }
        protected void regNextLibraryId(LdConditionKey k, Object v) { regQ(k, v, getCValueNextLibraryId(), "NEXT_LIBRARY_ID"); }
        protected abstract LdConditionValue getCValueNextLibraryId();

        public void SetDistanceKm_Equal(decimal? v) { regDistanceKm(CK_EQ, v); }
        public void SetDistanceKm_NotEqual(decimal? v) { regDistanceKm(CK_NES, v); }
        public void SetDistanceKm_GreaterThan(decimal? v) { regDistanceKm(CK_GT, v); }
        public void SetDistanceKm_LessThan(decimal? v) { regDistanceKm(CK_LT, v); }
        public void SetDistanceKm_GreaterEqual(decimal? v) { regDistanceKm(CK_GE, v); }
        public void SetDistanceKm_LessEqual(decimal? v) { regDistanceKm(CK_LE, v); }
        public void SetDistanceKm_InScope(IList<decimal?> ls) { regINS<decimal?>(CK_INS, cTL<decimal?>(ls), getCValueDistanceKm(), "DISTANCE_KM"); }
        public void SetDistanceKm_NotInScope(IList<decimal?> ls) { regINS<decimal?>(CK_NINS, cTL<decimal?>(ls), getCValueDistanceKm(), "DISTANCE_KM"); }
        protected void regDistanceKm(LdConditionKey k, Object v) { regQ(k, v, getCValueDistanceKm(), "DISTANCE_KM"); }
        protected abstract LdConditionValue getCValueDistanceKm();

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

        public override String ToString() { return xgetSqlClause().getClause(); }
    }
}
