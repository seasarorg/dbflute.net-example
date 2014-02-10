
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
    public abstract class LdAbstractBsCollectionCQ : LdAbstractConditionQuery {

        public LdAbstractBsCollectionCQ(LdConditionQuery childQuery, LdSqlClause sqlClause, String aliasName, int nestLevel)
            : base(childQuery, sqlClause, aliasName, nestLevel) {}

        public override String getTableDbName() { return "collection"; }
        public override String getTableSqlName() { return "collection"; }

        public void SetCollectionId_Equal(int? v) { regCollectionId(CK_EQ, v); }
        public void SetCollectionId_NotEqual(int? v) { regCollectionId(CK_NES, v); }
        public void SetCollectionId_GreaterThan(int? v) { regCollectionId(CK_GT, v); }
        public void SetCollectionId_LessThan(int? v) { regCollectionId(CK_LT, v); }
        public void SetCollectionId_GreaterEqual(int? v) { regCollectionId(CK_GE, v); }
        public void SetCollectionId_LessEqual(int? v) { regCollectionId(CK_LE, v); }
        public void SetCollectionId_InScope(IList<int?> ls) { regINS<int?>(CK_INS, cTL<int?>(ls), getCValueCollectionId(), "COLLECTION_ID"); }
        public void SetCollectionId_NotInScope(IList<int?> ls) { regINS<int?>(CK_NINS, cTL<int?>(ls), getCValueCollectionId(), "COLLECTION_ID"); }
        public void ExistsCollectionStatusAsOne(LdSubQuery<LdCollectionStatusCB> subQuery) {
            assertObjectNotNull("subQuery<LdCollectionStatusCB>", subQuery);
            LdCollectionStatusCB cb = new LdCollectionStatusCB(); cb.xsetupForExistsReferrer(this); subQuery.Invoke(cb);
            String subQueryPropertyName = keepCollectionId_ExistsSubQuery_CollectionStatusAsOne(cb.Query());
            registerExistsSubQuery(cb.Query(), "COLLECTION_ID", "COLLECTION_ID", subQueryPropertyName);
        }
        public abstract String keepCollectionId_ExistsSubQuery_CollectionStatusAsOne(LdCollectionStatusCQ subQuery);
        public void ExistsLendingCollectionList(LdSubQuery<LdLendingCollectionCB> subQuery) {
            assertObjectNotNull("subQuery<LdLendingCollectionCB>", subQuery);
            LdLendingCollectionCB cb = new LdLendingCollectionCB(); cb.xsetupForExistsReferrer(this); subQuery.Invoke(cb);
            String subQueryPropertyName = keepCollectionId_ExistsSubQuery_LendingCollectionList(cb.Query());
            registerExistsSubQuery(cb.Query(), "COLLECTION_ID", "COLLECTION_ID", subQueryPropertyName);
        }
        public abstract String keepCollectionId_ExistsSubQuery_LendingCollectionList(LdLendingCollectionCQ subQuery);
        public void NotExistsCollectionStatusAsOne(LdSubQuery<LdCollectionStatusCB> subQuery) {
            assertObjectNotNull("subQuery<LdCollectionStatusCB>", subQuery);
            LdCollectionStatusCB cb = new LdCollectionStatusCB(); cb.xsetupForExistsReferrer(this); subQuery.Invoke(cb);
            String subQueryPropertyName = keepCollectionId_NotExistsSubQuery_CollectionStatusAsOne(cb.Query());
            registerNotExistsSubQuery(cb.Query(), "COLLECTION_ID", "COLLECTION_ID", subQueryPropertyName);
        }
        public abstract String keepCollectionId_NotExistsSubQuery_CollectionStatusAsOne(LdCollectionStatusCQ subQuery);
        public void NotExistsLendingCollectionList(LdSubQuery<LdLendingCollectionCB> subQuery) {
            assertObjectNotNull("subQuery<LdLendingCollectionCB>", subQuery);
            LdLendingCollectionCB cb = new LdLendingCollectionCB(); cb.xsetupForExistsReferrer(this); subQuery.Invoke(cb);
            String subQueryPropertyName = keepCollectionId_NotExistsSubQuery_LendingCollectionList(cb.Query());
            registerNotExistsSubQuery(cb.Query(), "COLLECTION_ID", "COLLECTION_ID", subQueryPropertyName);
        }
        public abstract String keepCollectionId_NotExistsSubQuery_LendingCollectionList(LdLendingCollectionCQ subQuery);
        public void InScopeCollectionStatusAsOne(LdSubQuery<LdCollectionStatusCB> subQuery) {
            assertObjectNotNull("subQuery<LdCollectionStatusCB>", subQuery);
            LdCollectionStatusCB cb = new LdCollectionStatusCB(); cb.xsetupForInScopeRelation(this); subQuery.Invoke(cb);
            String subQueryPropertyName = keepCollectionId_InScopeSubQuery_CollectionStatusAsOne(cb.Query());
            registerInScopeSubQuery(cb.Query(), "COLLECTION_ID", "COLLECTION_ID", subQueryPropertyName);
        }
        public abstract String keepCollectionId_InScopeSubQuery_CollectionStatusAsOne(LdCollectionStatusCQ subQuery);
        public void InScopeLendingCollectionList(LdSubQuery<LdLendingCollectionCB> subQuery) {
            assertObjectNotNull("subQuery<LdLendingCollectionCB>", subQuery);
            LdLendingCollectionCB cb = new LdLendingCollectionCB(); cb.xsetupForInScopeRelation(this); subQuery.Invoke(cb);
            String subQueryPropertyName = keepCollectionId_InScopeSubQuery_LendingCollectionList(cb.Query());
            registerInScopeSubQuery(cb.Query(), "COLLECTION_ID", "COLLECTION_ID", subQueryPropertyName);
        }
        public abstract String keepCollectionId_InScopeSubQuery_LendingCollectionList(LdLendingCollectionCQ subQuery);
        public void NotInScopeCollectionStatusAsOne(LdSubQuery<LdCollectionStatusCB> subQuery) {
            assertObjectNotNull("subQuery<LdCollectionStatusCB>", subQuery);
            LdCollectionStatusCB cb = new LdCollectionStatusCB(); cb.xsetupForInScopeRelation(this); subQuery.Invoke(cb);
            String subQueryPropertyName = keepCollectionId_NotInScopeSubQuery_CollectionStatusAsOne(cb.Query());
            registerNotInScopeSubQuery(cb.Query(), "COLLECTION_ID", "COLLECTION_ID", subQueryPropertyName);
        }
        public abstract String keepCollectionId_NotInScopeSubQuery_CollectionStatusAsOne(LdCollectionStatusCQ subQuery);
        public void NotInScopeLendingCollectionList(LdSubQuery<LdLendingCollectionCB> subQuery) {
            assertObjectNotNull("subQuery<LdLendingCollectionCB>", subQuery);
            LdLendingCollectionCB cb = new LdLendingCollectionCB(); cb.xsetupForInScopeRelation(this); subQuery.Invoke(cb);
            String subQueryPropertyName = keepCollectionId_NotInScopeSubQuery_LendingCollectionList(cb.Query());
            registerNotInScopeSubQuery(cb.Query(), "COLLECTION_ID", "COLLECTION_ID", subQueryPropertyName);
        }
        public abstract String keepCollectionId_NotInScopeSubQuery_LendingCollectionList(LdLendingCollectionCQ subQuery);
        public void xsderiveLendingCollectionList(String function, LdSubQuery<LdLendingCollectionCB> subQuery, String aliasName) {
            assertObjectNotNull("subQuery<LdLendingCollectionCB>", subQuery);
            LdLendingCollectionCB cb = new LdLendingCollectionCB(); cb.xsetupForDerivedReferrer(this); subQuery.Invoke(cb);
            String subQueryPropertyName = keepCollectionId_SpecifyDerivedReferrer_LendingCollectionList(cb.Query());
            registerSpecifyDerivedReferrer(function, cb.Query(), "COLLECTION_ID", "COLLECTION_ID", subQueryPropertyName, aliasName);
        }
        abstract public String keepCollectionId_SpecifyDerivedReferrer_LendingCollectionList(LdLendingCollectionCQ subQuery);

        public QDRFunction<LdLendingCollectionCB> DerivedLendingCollectionList() {
            return xcreateQDRFunctionLendingCollectionList();
        }
        protected QDRFunction<LdLendingCollectionCB> xcreateQDRFunctionLendingCollectionList() {
            return new QDRFunction<LdLendingCollectionCB>(delegate(String function, LdSubQuery<LdLendingCollectionCB> subQuery, String operand, Object value) {
                xqderiveLendingCollectionList(function, subQuery, operand, value);
            });
        }
        public void xqderiveLendingCollectionList(String function, LdSubQuery<LdLendingCollectionCB> subQuery, String operand, Object value) {
            assertObjectNotNull("subQuery<LdLendingCollectionCB>", subQuery);
            LdLendingCollectionCB cb = new LdLendingCollectionCB(); cb.xsetupForDerivedReferrer(this); subQuery.Invoke(cb);
            String subQueryPropertyName = keepCollectionId_QueryDerivedReferrer_LendingCollectionList(cb.Query()); // for saving query-value.
            String parameterPropertyName = keepCollectionId_QueryDerivedReferrer_LendingCollectionListParameter(value);
            registerQueryDerivedReferrer(function, cb.Query(), "COLLECTION_ID", "COLLECTION_ID", subQueryPropertyName, operand, value, parameterPropertyName);
        }
        public abstract String keepCollectionId_QueryDerivedReferrer_LendingCollectionList(LdLendingCollectionCQ subQuery);
        public abstract String keepCollectionId_QueryDerivedReferrer_LendingCollectionListParameter(Object parameterValue);
        public void SetCollectionId_IsNull() { regCollectionId(CK_ISN, DUMMY_OBJECT); }
        public void SetCollectionId_IsNotNull() { regCollectionId(CK_ISNN, DUMMY_OBJECT); }
        protected void regCollectionId(LdConditionKey k, Object v) { regQ(k, v, getCValueCollectionId(), "COLLECTION_ID"); }
        protected abstract LdConditionValue getCValueCollectionId();

        public void SetLibraryId_Equal(int? v) { regLibraryId(CK_EQ, v); }
        public void SetLibraryId_NotEqual(int? v) { regLibraryId(CK_NES, v); }
        public void SetLibraryId_GreaterThan(int? v) { regLibraryId(CK_GT, v); }
        public void SetLibraryId_LessThan(int? v) { regLibraryId(CK_LT, v); }
        public void SetLibraryId_GreaterEqual(int? v) { regLibraryId(CK_GE, v); }
        public void SetLibraryId_LessEqual(int? v) { regLibraryId(CK_LE, v); }
        public void SetLibraryId_InScope(IList<int?> ls) { regINS<int?>(CK_INS, cTL<int?>(ls), getCValueLibraryId(), "LIBRARY_ID"); }
        public void SetLibraryId_NotInScope(IList<int?> ls) { regINS<int?>(CK_NINS, cTL<int?>(ls), getCValueLibraryId(), "LIBRARY_ID"); }
        public void InScopeLibrary(LdSubQuery<LdLibraryCB> subQuery) {
            assertObjectNotNull("subQuery<LdLibraryCB>", subQuery);
            LdLibraryCB cb = new LdLibraryCB(); cb.xsetupForInScopeRelation(this); subQuery.Invoke(cb);
            String subQueryPropertyName = keepLibraryId_InScopeSubQuery_Library(cb.Query());
            registerInScopeSubQuery(cb.Query(), "LIBRARY_ID", "LIBRARY_ID", subQueryPropertyName);
        }
        public abstract String keepLibraryId_InScopeSubQuery_Library(LdLibraryCQ subQuery);
        public void NotInScopeLibrary(LdSubQuery<LdLibraryCB> subQuery) {
            assertObjectNotNull("subQuery<LdLibraryCB>", subQuery);
            LdLibraryCB cb = new LdLibraryCB(); cb.xsetupForInScopeRelation(this); subQuery.Invoke(cb);
            String subQueryPropertyName = keepLibraryId_NotInScopeSubQuery_Library(cb.Query());
            registerNotInScopeSubQuery(cb.Query(), "LIBRARY_ID", "LIBRARY_ID", subQueryPropertyName);
        }
        public abstract String keepLibraryId_NotInScopeSubQuery_Library(LdLibraryCQ subQuery);
        protected void regLibraryId(LdConditionKey k, Object v) { regQ(k, v, getCValueLibraryId(), "LIBRARY_ID"); }
        protected abstract LdConditionValue getCValueLibraryId();

        public void SetBookId_Equal(int? v) { regBookId(CK_EQ, v); }
        public void SetBookId_NotEqual(int? v) { regBookId(CK_NES, v); }
        public void SetBookId_GreaterThan(int? v) { regBookId(CK_GT, v); }
        public void SetBookId_LessThan(int? v) { regBookId(CK_LT, v); }
        public void SetBookId_GreaterEqual(int? v) { regBookId(CK_GE, v); }
        public void SetBookId_LessEqual(int? v) { regBookId(CK_LE, v); }
        public void SetBookId_InScope(IList<int?> ls) { regINS<int?>(CK_INS, cTL<int?>(ls), getCValueBookId(), "BOOK_ID"); }
        public void SetBookId_NotInScope(IList<int?> ls) { regINS<int?>(CK_NINS, cTL<int?>(ls), getCValueBookId(), "BOOK_ID"); }
        public void InScopeBook(LdSubQuery<LdBookCB> subQuery) {
            assertObjectNotNull("subQuery<LdBookCB>", subQuery);
            LdBookCB cb = new LdBookCB(); cb.xsetupForInScopeRelation(this); subQuery.Invoke(cb);
            String subQueryPropertyName = keepBookId_InScopeSubQuery_Book(cb.Query());
            registerInScopeSubQuery(cb.Query(), "BOOK_ID", "BOOK_ID", subQueryPropertyName);
        }
        public abstract String keepBookId_InScopeSubQuery_Book(LdBookCQ subQuery);
        public void NotInScopeBook(LdSubQuery<LdBookCB> subQuery) {
            assertObjectNotNull("subQuery<LdBookCB>", subQuery);
            LdBookCB cb = new LdBookCB(); cb.xsetupForInScopeRelation(this); subQuery.Invoke(cb);
            String subQueryPropertyName = keepBookId_NotInScopeSubQuery_Book(cb.Query());
            registerNotInScopeSubQuery(cb.Query(), "BOOK_ID", "BOOK_ID", subQueryPropertyName);
        }
        public abstract String keepBookId_NotInScopeSubQuery_Book(LdBookCQ subQuery);
        protected void regBookId(LdConditionKey k, Object v) { regQ(k, v, getCValueBookId(), "BOOK_ID"); }
        protected abstract LdConditionValue getCValueBookId();

        public void SetArrivalDate_Equal(DateTime? v) { regArrivalDate(CK_EQ, v); }
        public void SetArrivalDate_NotEqual(DateTime? v) { regArrivalDate(CK_NES, v); }
        public void SetArrivalDate_GreaterThan(DateTime? v) { regArrivalDate(CK_GT, v); }
        public void SetArrivalDate_LessThan(DateTime? v) { regArrivalDate(CK_LT, v); }
        public void SetArrivalDate_GreaterEqual(DateTime? v) { regArrivalDate(CK_GE, v); }
        public void SetArrivalDate_LessEqual(DateTime? v) { regArrivalDate(CK_LE, v); }
        public void SetArrivalDate_FromTo(DateTime? from, DateTime? to, LdFromToOption option)
        { regFTQ(from, to, getCValueArrivalDate(), "ARRIVAL_DATE", option); }
        public void SetArrivalDate_DateFromTo(DateTime? from, DateTime? to) { SetArrivalDate_FromTo(from, to, new LdDateFromToOption()); }
        public void SetArrivalDate_InScope(IList<DateTime?> ls) { regINS<DateTime?>(CK_INS, cTL<DateTime?>(ls), getCValueArrivalDate(), "ARRIVAL_DATE"); }
        public void SetArrivalDate_NotInScope(IList<DateTime?> ls) { regINS<DateTime?>(CK_NINS, cTL<DateTime?>(ls), getCValueArrivalDate(), "ARRIVAL_DATE"); }
        protected void regArrivalDate(LdConditionKey k, Object v) { regQ(k, v, getCValueArrivalDate(), "ARRIVAL_DATE"); }
        protected abstract LdConditionValue getCValueArrivalDate();

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
        public SSQFunction<LdCollectionCB> Scalar_Equal() {
            return xcreateSSQFunction("=");
        }

        public SSQFunction<LdCollectionCB> Scalar_NotEqual() {
            return xcreateSSQFunction("<>");
        }

        public SSQFunction<LdCollectionCB> Scalar_GreaterEqual() {
            return xcreateSSQFunction(">=");
        }

        public SSQFunction<LdCollectionCB> Scalar_GreaterThan() {
            return xcreateSSQFunction(">");
        }

        public SSQFunction<LdCollectionCB> Scalar_LessEqual() {
            return xcreateSSQFunction("<=");
        }

        public SSQFunction<LdCollectionCB> Scalar_LessThan() {
            return xcreateSSQFunction("<");
        }

        protected SSQFunction<LdCollectionCB> xcreateSSQFunction(String operand) {
            return new SSQFunction<LdCollectionCB>(delegate(String function, LdSubQuery<LdCollectionCB> subQuery) {
                xscalarSubQuery(function, subQuery, operand);
            });
        }

        protected void xscalarSubQuery(String function, LdSubQuery<LdCollectionCB> subQuery, String operand) {
            assertObjectNotNull("subQuery<LdCollectionCB>", subQuery);
            LdCollectionCB cb = new LdCollectionCB(); cb.xsetupForScalarCondition(this); subQuery.Invoke(cb);
            String subQueryPropertyName = keepScalarSubQuery(cb.Query()); // for saving query-value.
            registerScalarSubQuery(function, cb.Query(), subQueryPropertyName, operand);
        }
        public abstract String keepScalarSubQuery(LdCollectionCQ subQuery);

        // ===============================================================================
        //                                                                  MySelf InScope
        //                                                                  ==============
        public void MyselfInScope(LdSubQuery<LdCollectionCB> subQuery) {
            assertObjectNotNull("subQuery<LdCollectionCB>", subQuery);
            LdCollectionCB cb = new LdCollectionCB(); cb.xsetupForInScopeRelation(this); subQuery.Invoke(cb);
            String subQueryPropertyName = keepMyselfInScopeSubQuery(cb.Query()); // for saving query-value.
            registerInScopeSubQuery(cb.Query(), "COLLECTION_ID", "COLLECTION_ID", subQueryPropertyName);
        }
        public abstract String keepMyselfInScopeSubQuery(LdCollectionCQ subQuery);

        public override String ToString() { return xgetSqlClause().getClause(); }
    }
}
