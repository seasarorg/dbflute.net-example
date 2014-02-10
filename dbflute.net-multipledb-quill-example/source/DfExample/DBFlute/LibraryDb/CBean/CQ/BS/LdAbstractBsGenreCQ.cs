
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
    public abstract class LdAbstractBsGenreCQ : LdAbstractConditionQuery {

        public LdAbstractBsGenreCQ(LdConditionQuery childQuery, LdSqlClause sqlClause, String aliasName, int nestLevel)
            : base(childQuery, sqlClause, aliasName, nestLevel) {}

        public override String getTableDbName() { return "genre"; }
        public override String getTableSqlName() { return "genre"; }

        public void SetGenreCode_Equal(String v) { DoSetGenreCode_Equal(fRES(v)); }
        protected void DoSetGenreCode_Equal(String v) { regGenreCode(CK_EQ, v); }
        public void SetGenreCode_NotEqual(String v) { DoSetGenreCode_NotEqual(fRES(v)); }
        protected void DoSetGenreCode_NotEqual(String v) { regGenreCode(CK_NES, v); }
        public void SetGenreCode_GreaterThan(String v) { regGenreCode(CK_GT, fRES(v)); }
        public void SetGenreCode_LessThan(String v) { regGenreCode(CK_LT, fRES(v)); }
        public void SetGenreCode_GreaterEqual(String v) { regGenreCode(CK_GE, fRES(v)); }
        public void SetGenreCode_LessEqual(String v) { regGenreCode(CK_LE, fRES(v)); }
        public void SetGenreCode_InScope(IList<String> ls) { regINS<String>(CK_INS, cTL<String>(ls), getCValueGenreCode(), "GENRE_CODE"); }
        public void SetGenreCode_NotInScope(IList<String> ls) { regINS<String>(CK_NINS, cTL<String>(ls), getCValueGenreCode(), "GENRE_CODE"); }
        public void SetGenreCode_PrefixSearch(String v) { SetGenreCode_LikeSearch(v, cLSOP()); }
        public void SetGenreCode_LikeSearch(String v, LdLikeSearchOption option)
        { regLSQ(CK_LS, fRES(v), getCValueGenreCode(), "GENRE_CODE", option); }
        public void SetGenreCode_NotLikeSearch(String v, LdLikeSearchOption option)
        { regLSQ(CK_NLS, fRES(v), getCValueGenreCode(), "GENRE_CODE", option); }
        public void ExistsBookList(LdSubQuery<LdBookCB> subQuery) {
            assertObjectNotNull("subQuery<LdBookCB>", subQuery);
            LdBookCB cb = new LdBookCB(); cb.xsetupForExistsReferrer(this); subQuery.Invoke(cb);
            String subQueryPropertyName = keepGenreCode_ExistsSubQuery_BookList(cb.Query());
            registerExistsSubQuery(cb.Query(), "GENRE_CODE", "GENRE_CODE", subQueryPropertyName);
        }
        public abstract String keepGenreCode_ExistsSubQuery_BookList(LdBookCQ subQuery);
        public void ExistsGenreSelfList(LdSubQuery<LdGenreCB> subQuery) {
            assertObjectNotNull("subQuery<LdGenreCB>", subQuery);
            LdGenreCB cb = new LdGenreCB(); cb.xsetupForExistsReferrer(this); subQuery.Invoke(cb);
            String subQueryPropertyName = keepGenreCode_ExistsSubQuery_GenreSelfList(cb.Query());
            registerExistsSubQuery(cb.Query(), "GENRE_CODE", "PARENT_GENRE_CODE", subQueryPropertyName);
        }
        public abstract String keepGenreCode_ExistsSubQuery_GenreSelfList(LdGenreCQ subQuery);
        public void NotExistsBookList(LdSubQuery<LdBookCB> subQuery) {
            assertObjectNotNull("subQuery<LdBookCB>", subQuery);
            LdBookCB cb = new LdBookCB(); cb.xsetupForExistsReferrer(this); subQuery.Invoke(cb);
            String subQueryPropertyName = keepGenreCode_NotExistsSubQuery_BookList(cb.Query());
            registerNotExistsSubQuery(cb.Query(), "GENRE_CODE", "GENRE_CODE", subQueryPropertyName);
        }
        public abstract String keepGenreCode_NotExistsSubQuery_BookList(LdBookCQ subQuery);
        public void NotExistsGenreSelfList(LdSubQuery<LdGenreCB> subQuery) {
            assertObjectNotNull("subQuery<LdGenreCB>", subQuery);
            LdGenreCB cb = new LdGenreCB(); cb.xsetupForExistsReferrer(this); subQuery.Invoke(cb);
            String subQueryPropertyName = keepGenreCode_NotExistsSubQuery_GenreSelfList(cb.Query());
            registerNotExistsSubQuery(cb.Query(), "GENRE_CODE", "PARENT_GENRE_CODE", subQueryPropertyName);
        }
        public abstract String keepGenreCode_NotExistsSubQuery_GenreSelfList(LdGenreCQ subQuery);
        public void InScopeBookList(LdSubQuery<LdBookCB> subQuery) {
            assertObjectNotNull("subQuery<LdBookCB>", subQuery);
            LdBookCB cb = new LdBookCB(); cb.xsetupForInScopeRelation(this); subQuery.Invoke(cb);
            String subQueryPropertyName = keepGenreCode_InScopeSubQuery_BookList(cb.Query());
            registerInScopeSubQuery(cb.Query(), "GENRE_CODE", "GENRE_CODE", subQueryPropertyName);
        }
        public abstract String keepGenreCode_InScopeSubQuery_BookList(LdBookCQ subQuery);
        public void InScopeGenreSelfList(LdSubQuery<LdGenreCB> subQuery) {
            assertObjectNotNull("subQuery<LdGenreCB>", subQuery);
            LdGenreCB cb = new LdGenreCB(); cb.xsetupForInScopeRelation(this); subQuery.Invoke(cb);
            String subQueryPropertyName = keepGenreCode_InScopeSubQuery_GenreSelfList(cb.Query());
            registerInScopeSubQuery(cb.Query(), "GENRE_CODE", "PARENT_GENRE_CODE", subQueryPropertyName);
        }
        public abstract String keepGenreCode_InScopeSubQuery_GenreSelfList(LdGenreCQ subQuery);
        public void NotInScopeBookList(LdSubQuery<LdBookCB> subQuery) {
            assertObjectNotNull("subQuery<LdBookCB>", subQuery);
            LdBookCB cb = new LdBookCB(); cb.xsetupForInScopeRelation(this); subQuery.Invoke(cb);
            String subQueryPropertyName = keepGenreCode_NotInScopeSubQuery_BookList(cb.Query());
            registerNotInScopeSubQuery(cb.Query(), "GENRE_CODE", "GENRE_CODE", subQueryPropertyName);
        }
        public abstract String keepGenreCode_NotInScopeSubQuery_BookList(LdBookCQ subQuery);
        public void NotInScopeGenreSelfList(LdSubQuery<LdGenreCB> subQuery) {
            assertObjectNotNull("subQuery<LdGenreCB>", subQuery);
            LdGenreCB cb = new LdGenreCB(); cb.xsetupForInScopeRelation(this); subQuery.Invoke(cb);
            String subQueryPropertyName = keepGenreCode_NotInScopeSubQuery_GenreSelfList(cb.Query());
            registerNotInScopeSubQuery(cb.Query(), "GENRE_CODE", "PARENT_GENRE_CODE", subQueryPropertyName);
        }
        public abstract String keepGenreCode_NotInScopeSubQuery_GenreSelfList(LdGenreCQ subQuery);
        public void xsderiveBookList(String function, LdSubQuery<LdBookCB> subQuery, String aliasName) {
            assertObjectNotNull("subQuery<LdBookCB>", subQuery);
            LdBookCB cb = new LdBookCB(); cb.xsetupForDerivedReferrer(this); subQuery.Invoke(cb);
            String subQueryPropertyName = keepGenreCode_SpecifyDerivedReferrer_BookList(cb.Query());
            registerSpecifyDerivedReferrer(function, cb.Query(), "GENRE_CODE", "GENRE_CODE", subQueryPropertyName, aliasName);
        }
        abstract public String keepGenreCode_SpecifyDerivedReferrer_BookList(LdBookCQ subQuery);
        public void xsderiveGenreSelfList(String function, LdSubQuery<LdGenreCB> subQuery, String aliasName) {
            assertObjectNotNull("subQuery<LdGenreCB>", subQuery);
            LdGenreCB cb = new LdGenreCB(); cb.xsetupForDerivedReferrer(this); subQuery.Invoke(cb);
            String subQueryPropertyName = keepGenreCode_SpecifyDerivedReferrer_GenreSelfList(cb.Query());
            registerSpecifyDerivedReferrer(function, cb.Query(), "GENRE_CODE", "PARENT_GENRE_CODE", subQueryPropertyName, aliasName);
        }
        abstract public String keepGenreCode_SpecifyDerivedReferrer_GenreSelfList(LdGenreCQ subQuery);

        public QDRFunction<LdBookCB> DerivedBookList() {
            return xcreateQDRFunctionBookList();
        }
        protected QDRFunction<LdBookCB> xcreateQDRFunctionBookList() {
            return new QDRFunction<LdBookCB>(delegate(String function, LdSubQuery<LdBookCB> subQuery, String operand, Object value) {
                xqderiveBookList(function, subQuery, operand, value);
            });
        }
        public void xqderiveBookList(String function, LdSubQuery<LdBookCB> subQuery, String operand, Object value) {
            assertObjectNotNull("subQuery<LdBookCB>", subQuery);
            LdBookCB cb = new LdBookCB(); cb.xsetupForDerivedReferrer(this); subQuery.Invoke(cb);
            String subQueryPropertyName = keepGenreCode_QueryDerivedReferrer_BookList(cb.Query()); // for saving query-value.
            String parameterPropertyName = keepGenreCode_QueryDerivedReferrer_BookListParameter(value);
            registerQueryDerivedReferrer(function, cb.Query(), "GENRE_CODE", "GENRE_CODE", subQueryPropertyName, operand, value, parameterPropertyName);
        }
        public abstract String keepGenreCode_QueryDerivedReferrer_BookList(LdBookCQ subQuery);
        public abstract String keepGenreCode_QueryDerivedReferrer_BookListParameter(Object parameterValue);

        public QDRFunction<LdGenreCB> DerivedGenreSelfList() {
            return xcreateQDRFunctionGenreSelfList();
        }
        protected QDRFunction<LdGenreCB> xcreateQDRFunctionGenreSelfList() {
            return new QDRFunction<LdGenreCB>(delegate(String function, LdSubQuery<LdGenreCB> subQuery, String operand, Object value) {
                xqderiveGenreSelfList(function, subQuery, operand, value);
            });
        }
        public void xqderiveGenreSelfList(String function, LdSubQuery<LdGenreCB> subQuery, String operand, Object value) {
            assertObjectNotNull("subQuery<LdGenreCB>", subQuery);
            LdGenreCB cb = new LdGenreCB(); cb.xsetupForDerivedReferrer(this); subQuery.Invoke(cb);
            String subQueryPropertyName = keepGenreCode_QueryDerivedReferrer_GenreSelfList(cb.Query()); // for saving query-value.
            String parameterPropertyName = keepGenreCode_QueryDerivedReferrer_GenreSelfListParameter(value);
            registerQueryDerivedReferrer(function, cb.Query(), "GENRE_CODE", "PARENT_GENRE_CODE", subQueryPropertyName, operand, value, parameterPropertyName);
        }
        public abstract String keepGenreCode_QueryDerivedReferrer_GenreSelfList(LdGenreCQ subQuery);
        public abstract String keepGenreCode_QueryDerivedReferrer_GenreSelfListParameter(Object parameterValue);
        public void SetGenreCode_IsNull() { regGenreCode(CK_ISN, DUMMY_OBJECT); }
        public void SetGenreCode_IsNotNull() { regGenreCode(CK_ISNN, DUMMY_OBJECT); }
        protected void regGenreCode(LdConditionKey k, Object v) { regQ(k, v, getCValueGenreCode(), "GENRE_CODE"); }
        protected abstract LdConditionValue getCValueGenreCode();

        public void SetGenreName_Equal(String v) { DoSetGenreName_Equal(fRES(v)); }
        protected void DoSetGenreName_Equal(String v) { regGenreName(CK_EQ, v); }
        public void SetGenreName_NotEqual(String v) { DoSetGenreName_NotEqual(fRES(v)); }
        protected void DoSetGenreName_NotEqual(String v) { regGenreName(CK_NES, v); }
        public void SetGenreName_GreaterThan(String v) { regGenreName(CK_GT, fRES(v)); }
        public void SetGenreName_LessThan(String v) { regGenreName(CK_LT, fRES(v)); }
        public void SetGenreName_GreaterEqual(String v) { regGenreName(CK_GE, fRES(v)); }
        public void SetGenreName_LessEqual(String v) { regGenreName(CK_LE, fRES(v)); }
        public void SetGenreName_InScope(IList<String> ls) { regINS<String>(CK_INS, cTL<String>(ls), getCValueGenreName(), "GENRE_NAME"); }
        public void SetGenreName_NotInScope(IList<String> ls) { regINS<String>(CK_NINS, cTL<String>(ls), getCValueGenreName(), "GENRE_NAME"); }
        public void SetGenreName_PrefixSearch(String v) { SetGenreName_LikeSearch(v, cLSOP()); }
        public void SetGenreName_LikeSearch(String v, LdLikeSearchOption option)
        { regLSQ(CK_LS, fRES(v), getCValueGenreName(), "GENRE_NAME", option); }
        public void SetGenreName_NotLikeSearch(String v, LdLikeSearchOption option)
        { regLSQ(CK_NLS, fRES(v), getCValueGenreName(), "GENRE_NAME", option); }
        protected void regGenreName(LdConditionKey k, Object v) { regQ(k, v, getCValueGenreName(), "GENRE_NAME"); }
        protected abstract LdConditionValue getCValueGenreName();

        public void SetHierarchyLevel_Equal(decimal? v) { regHierarchyLevel(CK_EQ, v); }
        public void SetHierarchyLevel_NotEqual(decimal? v) { regHierarchyLevel(CK_NES, v); }
        public void SetHierarchyLevel_GreaterThan(decimal? v) { regHierarchyLevel(CK_GT, v); }
        public void SetHierarchyLevel_LessThan(decimal? v) { regHierarchyLevel(CK_LT, v); }
        public void SetHierarchyLevel_GreaterEqual(decimal? v) { regHierarchyLevel(CK_GE, v); }
        public void SetHierarchyLevel_LessEqual(decimal? v) { regHierarchyLevel(CK_LE, v); }
        public void SetHierarchyLevel_InScope(IList<decimal?> ls) { regINS<decimal?>(CK_INS, cTL<decimal?>(ls), getCValueHierarchyLevel(), "HIERARCHY_LEVEL"); }
        public void SetHierarchyLevel_NotInScope(IList<decimal?> ls) { regINS<decimal?>(CK_NINS, cTL<decimal?>(ls), getCValueHierarchyLevel(), "HIERARCHY_LEVEL"); }
        protected void regHierarchyLevel(LdConditionKey k, Object v) { regQ(k, v, getCValueHierarchyLevel(), "HIERARCHY_LEVEL"); }
        protected abstract LdConditionValue getCValueHierarchyLevel();

        public void SetHierarchyOrder_Equal(decimal? v) { regHierarchyOrder(CK_EQ, v); }
        public void SetHierarchyOrder_NotEqual(decimal? v) { regHierarchyOrder(CK_NES, v); }
        public void SetHierarchyOrder_GreaterThan(decimal? v) { regHierarchyOrder(CK_GT, v); }
        public void SetHierarchyOrder_LessThan(decimal? v) { regHierarchyOrder(CK_LT, v); }
        public void SetHierarchyOrder_GreaterEqual(decimal? v) { regHierarchyOrder(CK_GE, v); }
        public void SetHierarchyOrder_LessEqual(decimal? v) { regHierarchyOrder(CK_LE, v); }
        public void SetHierarchyOrder_InScope(IList<decimal?> ls) { regINS<decimal?>(CK_INS, cTL<decimal?>(ls), getCValueHierarchyOrder(), "HIERARCHY_ORDER"); }
        public void SetHierarchyOrder_NotInScope(IList<decimal?> ls) { regINS<decimal?>(CK_NINS, cTL<decimal?>(ls), getCValueHierarchyOrder(), "HIERARCHY_ORDER"); }
        protected void regHierarchyOrder(LdConditionKey k, Object v) { regQ(k, v, getCValueHierarchyOrder(), "HIERARCHY_ORDER"); }
        protected abstract LdConditionValue getCValueHierarchyOrder();

        public void SetParentGenreCode_Equal(String v) { DoSetParentGenreCode_Equal(fRES(v)); }
        protected void DoSetParentGenreCode_Equal(String v) { regParentGenreCode(CK_EQ, v); }
        public void SetParentGenreCode_NotEqual(String v) { DoSetParentGenreCode_NotEqual(fRES(v)); }
        protected void DoSetParentGenreCode_NotEqual(String v) { regParentGenreCode(CK_NES, v); }
        public void SetParentGenreCode_GreaterThan(String v) { regParentGenreCode(CK_GT, fRES(v)); }
        public void SetParentGenreCode_LessThan(String v) { regParentGenreCode(CK_LT, fRES(v)); }
        public void SetParentGenreCode_GreaterEqual(String v) { regParentGenreCode(CK_GE, fRES(v)); }
        public void SetParentGenreCode_LessEqual(String v) { regParentGenreCode(CK_LE, fRES(v)); }
        public void SetParentGenreCode_InScope(IList<String> ls) { regINS<String>(CK_INS, cTL<String>(ls), getCValueParentGenreCode(), "PARENT_GENRE_CODE"); }
        public void SetParentGenreCode_NotInScope(IList<String> ls) { regINS<String>(CK_NINS, cTL<String>(ls), getCValueParentGenreCode(), "PARENT_GENRE_CODE"); }
        public void SetParentGenreCode_PrefixSearch(String v) { SetParentGenreCode_LikeSearch(v, cLSOP()); }
        public void SetParentGenreCode_LikeSearch(String v, LdLikeSearchOption option)
        { regLSQ(CK_LS, fRES(v), getCValueParentGenreCode(), "PARENT_GENRE_CODE", option); }
        public void SetParentGenreCode_NotLikeSearch(String v, LdLikeSearchOption option)
        { regLSQ(CK_NLS, fRES(v), getCValueParentGenreCode(), "PARENT_GENRE_CODE", option); }
        public void InScopeGenreSelf(LdSubQuery<LdGenreCB> subQuery) {
            assertObjectNotNull("subQuery<LdGenreCB>", subQuery);
            LdGenreCB cb = new LdGenreCB(); cb.xsetupForInScopeRelation(this); subQuery.Invoke(cb);
            String subQueryPropertyName = keepParentGenreCode_InScopeSubQuery_GenreSelf(cb.Query());
            registerInScopeSubQuery(cb.Query(), "PARENT_GENRE_CODE", "GENRE_CODE", subQueryPropertyName);
        }
        public abstract String keepParentGenreCode_InScopeSubQuery_GenreSelf(LdGenreCQ subQuery);
        public void NotInScopeGenreSelf(LdSubQuery<LdGenreCB> subQuery) {
            assertObjectNotNull("subQuery<LdGenreCB>", subQuery);
            LdGenreCB cb = new LdGenreCB(); cb.xsetupForInScopeRelation(this); subQuery.Invoke(cb);
            String subQueryPropertyName = keepParentGenreCode_NotInScopeSubQuery_GenreSelf(cb.Query());
            registerNotInScopeSubQuery(cb.Query(), "PARENT_GENRE_CODE", "GENRE_CODE", subQueryPropertyName);
        }
        public abstract String keepParentGenreCode_NotInScopeSubQuery_GenreSelf(LdGenreCQ subQuery);
        public void SetParentGenreCode_IsNull() { regParentGenreCode(CK_ISN, DUMMY_OBJECT); }
        public void SetParentGenreCode_IsNotNull() { regParentGenreCode(CK_ISNN, DUMMY_OBJECT); }
        protected void regParentGenreCode(LdConditionKey k, Object v) { regQ(k, v, getCValueParentGenreCode(), "PARENT_GENRE_CODE"); }
        protected abstract LdConditionValue getCValueParentGenreCode();

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
        public SSQFunction<LdGenreCB> Scalar_Equal() {
            return xcreateSSQFunction("=");
        }

        public SSQFunction<LdGenreCB> Scalar_NotEqual() {
            return xcreateSSQFunction("<>");
        }

        public SSQFunction<LdGenreCB> Scalar_GreaterEqual() {
            return xcreateSSQFunction(">=");
        }

        public SSQFunction<LdGenreCB> Scalar_GreaterThan() {
            return xcreateSSQFunction(">");
        }

        public SSQFunction<LdGenreCB> Scalar_LessEqual() {
            return xcreateSSQFunction("<=");
        }

        public SSQFunction<LdGenreCB> Scalar_LessThan() {
            return xcreateSSQFunction("<");
        }

        protected SSQFunction<LdGenreCB> xcreateSSQFunction(String operand) {
            return new SSQFunction<LdGenreCB>(delegate(String function, LdSubQuery<LdGenreCB> subQuery) {
                xscalarSubQuery(function, subQuery, operand);
            });
        }

        protected void xscalarSubQuery(String function, LdSubQuery<LdGenreCB> subQuery, String operand) {
            assertObjectNotNull("subQuery<LdGenreCB>", subQuery);
            LdGenreCB cb = new LdGenreCB(); cb.xsetupForScalarCondition(this); subQuery.Invoke(cb);
            String subQueryPropertyName = keepScalarSubQuery(cb.Query()); // for saving query-value.
            registerScalarSubQuery(function, cb.Query(), subQueryPropertyName, operand);
        }
        public abstract String keepScalarSubQuery(LdGenreCQ subQuery);

        // ===============================================================================
        //                                                                  MySelf InScope
        //                                                                  ==============
        public void MyselfInScope(LdSubQuery<LdGenreCB> subQuery) {
            assertObjectNotNull("subQuery<LdGenreCB>", subQuery);
            LdGenreCB cb = new LdGenreCB(); cb.xsetupForInScopeRelation(this); subQuery.Invoke(cb);
            String subQueryPropertyName = keepMyselfInScopeSubQuery(cb.Query()); // for saving query-value.
            registerInScopeSubQuery(cb.Query(), "GENRE_CODE", "GENRE_CODE", subQueryPropertyName);
        }
        public abstract String keepMyselfInScopeSubQuery(LdGenreCQ subQuery);

        public override String ToString() { return xgetSqlClause().getClause(); }
    }
}
