
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
    public abstract class LdAbstractBsBookCQ : LdAbstractConditionQuery {

        public LdAbstractBsBookCQ(LdConditionQuery childQuery, LdSqlClause sqlClause, String aliasName, int nestLevel)
            : base(childQuery, sqlClause, aliasName, nestLevel) {}

        public override String getTableDbName() { return "book"; }
        public override String getTableSqlName() { return "book"; }

        public void SetBookId_Equal(int? v) { regBookId(CK_EQ, v); }
        public void SetBookId_NotEqual(int? v) { regBookId(CK_NES, v); }
        public void SetBookId_GreaterThan(int? v) { regBookId(CK_GT, v); }
        public void SetBookId_LessThan(int? v) { regBookId(CK_LT, v); }
        public void SetBookId_GreaterEqual(int? v) { regBookId(CK_GE, v); }
        public void SetBookId_LessEqual(int? v) { regBookId(CK_LE, v); }
        public void SetBookId_InScope(IList<int?> ls) { regINS<int?>(CK_INS, cTL<int?>(ls), getCValueBookId(), "BOOK_ID"); }
        public void SetBookId_NotInScope(IList<int?> ls) { regINS<int?>(CK_NINS, cTL<int?>(ls), getCValueBookId(), "BOOK_ID"); }
        public void ExistsCollectionList(LdSubQuery<LdCollectionCB> subQuery) {
            assertObjectNotNull("subQuery<LdCollectionCB>", subQuery);
            LdCollectionCB cb = new LdCollectionCB(); cb.xsetupForExistsReferrer(this); subQuery.Invoke(cb);
            String subQueryPropertyName = keepBookId_ExistsSubQuery_CollectionList(cb.Query());
            registerExistsSubQuery(cb.Query(), "BOOK_ID", "BOOK_ID", subQueryPropertyName);
        }
        public abstract String keepBookId_ExistsSubQuery_CollectionList(LdCollectionCQ subQuery);
        public void NotExistsCollectionList(LdSubQuery<LdCollectionCB> subQuery) {
            assertObjectNotNull("subQuery<LdCollectionCB>", subQuery);
            LdCollectionCB cb = new LdCollectionCB(); cb.xsetupForExistsReferrer(this); subQuery.Invoke(cb);
            String subQueryPropertyName = keepBookId_NotExistsSubQuery_CollectionList(cb.Query());
            registerNotExistsSubQuery(cb.Query(), "BOOK_ID", "BOOK_ID", subQueryPropertyName);
        }
        public abstract String keepBookId_NotExistsSubQuery_CollectionList(LdCollectionCQ subQuery);
        public void InScopeCollectionList(LdSubQuery<LdCollectionCB> subQuery) {
            assertObjectNotNull("subQuery<LdCollectionCB>", subQuery);
            LdCollectionCB cb = new LdCollectionCB(); cb.xsetupForInScopeRelation(this); subQuery.Invoke(cb);
            String subQueryPropertyName = keepBookId_InScopeSubQuery_CollectionList(cb.Query());
            registerInScopeSubQuery(cb.Query(), "BOOK_ID", "BOOK_ID", subQueryPropertyName);
        }
        public abstract String keepBookId_InScopeSubQuery_CollectionList(LdCollectionCQ subQuery);
        public void NotInScopeCollectionList(LdSubQuery<LdCollectionCB> subQuery) {
            assertObjectNotNull("subQuery<LdCollectionCB>", subQuery);
            LdCollectionCB cb = new LdCollectionCB(); cb.xsetupForInScopeRelation(this); subQuery.Invoke(cb);
            String subQueryPropertyName = keepBookId_NotInScopeSubQuery_CollectionList(cb.Query());
            registerNotInScopeSubQuery(cb.Query(), "BOOK_ID", "BOOK_ID", subQueryPropertyName);
        }
        public abstract String keepBookId_NotInScopeSubQuery_CollectionList(LdCollectionCQ subQuery);
        public void xsderiveCollectionList(String function, LdSubQuery<LdCollectionCB> subQuery, String aliasName) {
            assertObjectNotNull("subQuery<LdCollectionCB>", subQuery);
            LdCollectionCB cb = new LdCollectionCB(); cb.xsetupForDerivedReferrer(this); subQuery.Invoke(cb);
            String subQueryPropertyName = keepBookId_SpecifyDerivedReferrer_CollectionList(cb.Query());
            registerSpecifyDerivedReferrer(function, cb.Query(), "BOOK_ID", "BOOK_ID", subQueryPropertyName, aliasName);
        }
        abstract public String keepBookId_SpecifyDerivedReferrer_CollectionList(LdCollectionCQ subQuery);

        public QDRFunction<LdCollectionCB> DerivedCollectionList() {
            return xcreateQDRFunctionCollectionList();
        }
        protected QDRFunction<LdCollectionCB> xcreateQDRFunctionCollectionList() {
            return new QDRFunction<LdCollectionCB>(delegate(String function, LdSubQuery<LdCollectionCB> subQuery, String operand, Object value) {
                xqderiveCollectionList(function, subQuery, operand, value);
            });
        }
        public void xqderiveCollectionList(String function, LdSubQuery<LdCollectionCB> subQuery, String operand, Object value) {
            assertObjectNotNull("subQuery<LdCollectionCB>", subQuery);
            LdCollectionCB cb = new LdCollectionCB(); cb.xsetupForDerivedReferrer(this); subQuery.Invoke(cb);
            String subQueryPropertyName = keepBookId_QueryDerivedReferrer_CollectionList(cb.Query()); // for saving query-value.
            String parameterPropertyName = keepBookId_QueryDerivedReferrer_CollectionListParameter(value);
            registerQueryDerivedReferrer(function, cb.Query(), "BOOK_ID", "BOOK_ID", subQueryPropertyName, operand, value, parameterPropertyName);
        }
        public abstract String keepBookId_QueryDerivedReferrer_CollectionList(LdCollectionCQ subQuery);
        public abstract String keepBookId_QueryDerivedReferrer_CollectionListParameter(Object parameterValue);
        public void SetBookId_IsNull() { regBookId(CK_ISN, DUMMY_OBJECT); }
        public void SetBookId_IsNotNull() { regBookId(CK_ISNN, DUMMY_OBJECT); }
        protected void regBookId(LdConditionKey k, Object v) { regQ(k, v, getCValueBookId(), "BOOK_ID"); }
        protected abstract LdConditionValue getCValueBookId();

        public void SetIsbn_Equal(String v) { DoSetIsbn_Equal(fRES(v)); }
        protected void DoSetIsbn_Equal(String v) { regIsbn(CK_EQ, v); }
        public void SetIsbn_NotEqual(String v) { DoSetIsbn_NotEqual(fRES(v)); }
        protected void DoSetIsbn_NotEqual(String v) { regIsbn(CK_NES, v); }
        public void SetIsbn_GreaterThan(String v) { regIsbn(CK_GT, fRES(v)); }
        public void SetIsbn_LessThan(String v) { regIsbn(CK_LT, fRES(v)); }
        public void SetIsbn_GreaterEqual(String v) { regIsbn(CK_GE, fRES(v)); }
        public void SetIsbn_LessEqual(String v) { regIsbn(CK_LE, fRES(v)); }
        public void SetIsbn_InScope(IList<String> ls) { regINS<String>(CK_INS, cTL<String>(ls), getCValueIsbn(), "ISBN"); }
        public void SetIsbn_NotInScope(IList<String> ls) { regINS<String>(CK_NINS, cTL<String>(ls), getCValueIsbn(), "ISBN"); }
        public void SetIsbn_PrefixSearch(String v) { SetIsbn_LikeSearch(v, cLSOP()); }
        public void SetIsbn_LikeSearch(String v, LdLikeSearchOption option)
        { regLSQ(CK_LS, fRES(v), getCValueIsbn(), "ISBN", option); }
        public void SetIsbn_NotLikeSearch(String v, LdLikeSearchOption option)
        { regLSQ(CK_NLS, fRES(v), getCValueIsbn(), "ISBN", option); }
        protected void regIsbn(LdConditionKey k, Object v) { regQ(k, v, getCValueIsbn(), "ISBN"); }
        protected abstract LdConditionValue getCValueIsbn();

        public void SetBookName_Equal(String v) { DoSetBookName_Equal(fRES(v)); }
        protected void DoSetBookName_Equal(String v) { regBookName(CK_EQ, v); }
        public void SetBookName_NotEqual(String v) { DoSetBookName_NotEqual(fRES(v)); }
        protected void DoSetBookName_NotEqual(String v) { regBookName(CK_NES, v); }
        public void SetBookName_GreaterThan(String v) { regBookName(CK_GT, fRES(v)); }
        public void SetBookName_LessThan(String v) { regBookName(CK_LT, fRES(v)); }
        public void SetBookName_GreaterEqual(String v) { regBookName(CK_GE, fRES(v)); }
        public void SetBookName_LessEqual(String v) { regBookName(CK_LE, fRES(v)); }
        public void SetBookName_InScope(IList<String> ls) { regINS<String>(CK_INS, cTL<String>(ls), getCValueBookName(), "BOOK_NAME"); }
        public void SetBookName_NotInScope(IList<String> ls) { regINS<String>(CK_NINS, cTL<String>(ls), getCValueBookName(), "BOOK_NAME"); }
        public void SetBookName_PrefixSearch(String v) { SetBookName_LikeSearch(v, cLSOP()); }
        public void SetBookName_LikeSearch(String v, LdLikeSearchOption option)
        { regLSQ(CK_LS, fRES(v), getCValueBookName(), "BOOK_NAME", option); }
        public void SetBookName_NotLikeSearch(String v, LdLikeSearchOption option)
        { regLSQ(CK_NLS, fRES(v), getCValueBookName(), "BOOK_NAME", option); }
        protected void regBookName(LdConditionKey k, Object v) { regQ(k, v, getCValueBookName(), "BOOK_NAME"); }
        protected abstract LdConditionValue getCValueBookName();

        public void SetAuthorId_Equal(int? v) { regAuthorId(CK_EQ, v); }
        public void SetAuthorId_NotEqual(int? v) { regAuthorId(CK_NES, v); }
        public void SetAuthorId_GreaterThan(int? v) { regAuthorId(CK_GT, v); }
        public void SetAuthorId_LessThan(int? v) { regAuthorId(CK_LT, v); }
        public void SetAuthorId_GreaterEqual(int? v) { regAuthorId(CK_GE, v); }
        public void SetAuthorId_LessEqual(int? v) { regAuthorId(CK_LE, v); }
        public void SetAuthorId_InScope(IList<int?> ls) { regINS<int?>(CK_INS, cTL<int?>(ls), getCValueAuthorId(), "AUTHOR_ID"); }
        public void SetAuthorId_NotInScope(IList<int?> ls) { regINS<int?>(CK_NINS, cTL<int?>(ls), getCValueAuthorId(), "AUTHOR_ID"); }
        public void InScopeAuthor(LdSubQuery<LdAuthorCB> subQuery) {
            assertObjectNotNull("subQuery<LdAuthorCB>", subQuery);
            LdAuthorCB cb = new LdAuthorCB(); cb.xsetupForInScopeRelation(this); subQuery.Invoke(cb);
            String subQueryPropertyName = keepAuthorId_InScopeSubQuery_Author(cb.Query());
            registerInScopeSubQuery(cb.Query(), "AUTHOR_ID", "AUTHOR_ID", subQueryPropertyName);
        }
        public abstract String keepAuthorId_InScopeSubQuery_Author(LdAuthorCQ subQuery);
        public void NotInScopeAuthor(LdSubQuery<LdAuthorCB> subQuery) {
            assertObjectNotNull("subQuery<LdAuthorCB>", subQuery);
            LdAuthorCB cb = new LdAuthorCB(); cb.xsetupForInScopeRelation(this); subQuery.Invoke(cb);
            String subQueryPropertyName = keepAuthorId_NotInScopeSubQuery_Author(cb.Query());
            registerNotInScopeSubQuery(cb.Query(), "AUTHOR_ID", "AUTHOR_ID", subQueryPropertyName);
        }
        public abstract String keepAuthorId_NotInScopeSubQuery_Author(LdAuthorCQ subQuery);
        protected void regAuthorId(LdConditionKey k, Object v) { regQ(k, v, getCValueAuthorId(), "AUTHOR_ID"); }
        protected abstract LdConditionValue getCValueAuthorId();

        public void SetPublisherId_Equal(int? v) { regPublisherId(CK_EQ, v); }
        public void SetPublisherId_NotEqual(int? v) { regPublisherId(CK_NES, v); }
        public void SetPublisherId_GreaterThan(int? v) { regPublisherId(CK_GT, v); }
        public void SetPublisherId_LessThan(int? v) { regPublisherId(CK_LT, v); }
        public void SetPublisherId_GreaterEqual(int? v) { regPublisherId(CK_GE, v); }
        public void SetPublisherId_LessEqual(int? v) { regPublisherId(CK_LE, v); }
        public void SetPublisherId_InScope(IList<int?> ls) { regINS<int?>(CK_INS, cTL<int?>(ls), getCValuePublisherId(), "PUBLISHER_ID"); }
        public void SetPublisherId_NotInScope(IList<int?> ls) { regINS<int?>(CK_NINS, cTL<int?>(ls), getCValuePublisherId(), "PUBLISHER_ID"); }
        public void InScopePublisher(LdSubQuery<LdPublisherCB> subQuery) {
            assertObjectNotNull("subQuery<LdPublisherCB>", subQuery);
            LdPublisherCB cb = new LdPublisherCB(); cb.xsetupForInScopeRelation(this); subQuery.Invoke(cb);
            String subQueryPropertyName = keepPublisherId_InScopeSubQuery_Publisher(cb.Query());
            registerInScopeSubQuery(cb.Query(), "PUBLISHER_ID", "PUBLISHER_ID", subQueryPropertyName);
        }
        public abstract String keepPublisherId_InScopeSubQuery_Publisher(LdPublisherCQ subQuery);
        public void NotInScopePublisher(LdSubQuery<LdPublisherCB> subQuery) {
            assertObjectNotNull("subQuery<LdPublisherCB>", subQuery);
            LdPublisherCB cb = new LdPublisherCB(); cb.xsetupForInScopeRelation(this); subQuery.Invoke(cb);
            String subQueryPropertyName = keepPublisherId_NotInScopeSubQuery_Publisher(cb.Query());
            registerNotInScopeSubQuery(cb.Query(), "PUBLISHER_ID", "PUBLISHER_ID", subQueryPropertyName);
        }
        public abstract String keepPublisherId_NotInScopeSubQuery_Publisher(LdPublisherCQ subQuery);
        protected void regPublisherId(LdConditionKey k, Object v) { regQ(k, v, getCValuePublisherId(), "PUBLISHER_ID"); }
        protected abstract LdConditionValue getCValuePublisherId();

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
        public void InScopeGenre(LdSubQuery<LdGenreCB> subQuery) {
            assertObjectNotNull("subQuery<LdGenreCB>", subQuery);
            LdGenreCB cb = new LdGenreCB(); cb.xsetupForInScopeRelation(this); subQuery.Invoke(cb);
            String subQueryPropertyName = keepGenreCode_InScopeSubQuery_Genre(cb.Query());
            registerInScopeSubQuery(cb.Query(), "GENRE_CODE", "GENRE_CODE", subQueryPropertyName);
        }
        public abstract String keepGenreCode_InScopeSubQuery_Genre(LdGenreCQ subQuery);
        public void NotInScopeGenre(LdSubQuery<LdGenreCB> subQuery) {
            assertObjectNotNull("subQuery<LdGenreCB>", subQuery);
            LdGenreCB cb = new LdGenreCB(); cb.xsetupForInScopeRelation(this); subQuery.Invoke(cb);
            String subQueryPropertyName = keepGenreCode_NotInScopeSubQuery_Genre(cb.Query());
            registerNotInScopeSubQuery(cb.Query(), "GENRE_CODE", "GENRE_CODE", subQueryPropertyName);
        }
        public abstract String keepGenreCode_NotInScopeSubQuery_Genre(LdGenreCQ subQuery);
        public void SetGenreCode_IsNull() { regGenreCode(CK_ISN, DUMMY_OBJECT); }
        public void SetGenreCode_IsNotNull() { regGenreCode(CK_ISNN, DUMMY_OBJECT); }
        protected void regGenreCode(LdConditionKey k, Object v) { regQ(k, v, getCValueGenreCode(), "GENRE_CODE"); }
        protected abstract LdConditionValue getCValueGenreCode();

        public void SetOpeningPart_Equal(String v) { DoSetOpeningPart_Equal(fRES(v)); }
        protected void DoSetOpeningPart_Equal(String v) { regOpeningPart(CK_EQ, v); }
        public void SetOpeningPart_NotEqual(String v) { DoSetOpeningPart_NotEqual(fRES(v)); }
        protected void DoSetOpeningPart_NotEqual(String v) { regOpeningPart(CK_NES, v); }
        public void SetOpeningPart_GreaterThan(String v) { regOpeningPart(CK_GT, fRES(v)); }
        public void SetOpeningPart_LessThan(String v) { regOpeningPart(CK_LT, fRES(v)); }
        public void SetOpeningPart_GreaterEqual(String v) { regOpeningPart(CK_GE, fRES(v)); }
        public void SetOpeningPart_LessEqual(String v) { regOpeningPart(CK_LE, fRES(v)); }
        public void SetOpeningPart_InScope(IList<String> ls) { regINS<String>(CK_INS, cTL<String>(ls), getCValueOpeningPart(), "OPENING_PART"); }
        public void SetOpeningPart_NotInScope(IList<String> ls) { regINS<String>(CK_NINS, cTL<String>(ls), getCValueOpeningPart(), "OPENING_PART"); }
        public void SetOpeningPart_PrefixSearch(String v) { SetOpeningPart_LikeSearch(v, cLSOP()); }
        public void SetOpeningPart_LikeSearch(String v, LdLikeSearchOption option)
        { regLSQ(CK_LS, fRES(v), getCValueOpeningPart(), "OPENING_PART", option); }
        public void SetOpeningPart_NotLikeSearch(String v, LdLikeSearchOption option)
        { regLSQ(CK_NLS, fRES(v), getCValueOpeningPart(), "OPENING_PART", option); }
        public void SetOpeningPart_IsNull() { regOpeningPart(CK_ISN, DUMMY_OBJECT); }
        public void SetOpeningPart_IsNotNull() { regOpeningPart(CK_ISNN, DUMMY_OBJECT); }
        protected void regOpeningPart(LdConditionKey k, Object v) { regQ(k, v, getCValueOpeningPart(), "OPENING_PART"); }
        protected abstract LdConditionValue getCValueOpeningPart();

        public void SetMaxLendingDateCount_Equal(int? v) { regMaxLendingDateCount(CK_EQ, v); }
        public void SetMaxLendingDateCount_NotEqual(int? v) { regMaxLendingDateCount(CK_NES, v); }
        public void SetMaxLendingDateCount_GreaterThan(int? v) { regMaxLendingDateCount(CK_GT, v); }
        public void SetMaxLendingDateCount_LessThan(int? v) { regMaxLendingDateCount(CK_LT, v); }
        public void SetMaxLendingDateCount_GreaterEqual(int? v) { regMaxLendingDateCount(CK_GE, v); }
        public void SetMaxLendingDateCount_LessEqual(int? v) { regMaxLendingDateCount(CK_LE, v); }
        public void SetMaxLendingDateCount_InScope(IList<int?> ls) { regINS<int?>(CK_INS, cTL<int?>(ls), getCValueMaxLendingDateCount(), "MAX_LENDING_DATE_COUNT"); }
        public void SetMaxLendingDateCount_NotInScope(IList<int?> ls) { regINS<int?>(CK_NINS, cTL<int?>(ls), getCValueMaxLendingDateCount(), "MAX_LENDING_DATE_COUNT"); }
        protected void regMaxLendingDateCount(LdConditionKey k, Object v) { regQ(k, v, getCValueMaxLendingDateCount(), "MAX_LENDING_DATE_COUNT"); }
        protected abstract LdConditionValue getCValueMaxLendingDateCount();

        public void SetOutOfUserSelectYn_Equal(String v) { DoSetOutOfUserSelectYn_Equal(fRES(v)); }
        /// <summary>
        /// Set the value of Yes of outOfUserSelectYn as equal. { = }
        /// はい
        /// </summary>
        public void SetOutOfUserSelectYn_Equal_Yes() {
            DoSetOutOfUserSelectYn_Equal(LdCDef.YesNo.Yes.Code);
        }
        /// <summary>
        /// Set the value of No of outOfUserSelectYn as equal. { = }
        /// いいえ
        /// </summary>
        public void SetOutOfUserSelectYn_Equal_No() {
            DoSetOutOfUserSelectYn_Equal(LdCDef.YesNo.No.Code);
        }
        protected void DoSetOutOfUserSelectYn_Equal(String v) { regOutOfUserSelectYn(CK_EQ, v); }
        public void SetOutOfUserSelectYn_NotEqual(String v) { DoSetOutOfUserSelectYn_NotEqual(fRES(v)); }
        /// <summary>
        /// Set the value of Yes of outOfUserSelectYn as notEqual. { &lt;&gt; }
        /// はい
        /// </summary>
        public void SetOutOfUserSelectYn_NotEqual_Yes() {
            DoSetOutOfUserSelectYn_NotEqual(LdCDef.YesNo.Yes.Code);
        }
        /// <summary>
        /// Set the value of No of outOfUserSelectYn as notEqual. { &lt;&gt; }
        /// いいえ
        /// </summary>
        public void SetOutOfUserSelectYn_NotEqual_No() {
            DoSetOutOfUserSelectYn_NotEqual(LdCDef.YesNo.No.Code);
        }
        protected void DoSetOutOfUserSelectYn_NotEqual(String v) { regOutOfUserSelectYn(CK_NES, v); }
        public void SetOutOfUserSelectYn_InScope(IList<String> ls) { regINS<String>(CK_INS, cTL<String>(ls), getCValueOutOfUserSelectYn(), "OUT_OF_USER_SELECT_YN"); }
        public void SetOutOfUserSelectYn_NotInScope(IList<String> ls) { regINS<String>(CK_NINS, cTL<String>(ls), getCValueOutOfUserSelectYn(), "OUT_OF_USER_SELECT_YN"); }
        protected void regOutOfUserSelectYn(LdConditionKey k, Object v) { regQ(k, v, getCValueOutOfUserSelectYn(), "OUT_OF_USER_SELECT_YN"); }
        protected abstract LdConditionValue getCValueOutOfUserSelectYn();

        public void SetOutOfUserSelectReason_Equal(String v) { DoSetOutOfUserSelectReason_Equal(fRES(v)); }
        protected void DoSetOutOfUserSelectReason_Equal(String v) { regOutOfUserSelectReason(CK_EQ, v); }
        public void SetOutOfUserSelectReason_NotEqual(String v) { DoSetOutOfUserSelectReason_NotEqual(fRES(v)); }
        protected void DoSetOutOfUserSelectReason_NotEqual(String v) { regOutOfUserSelectReason(CK_NES, v); }
        public void SetOutOfUserSelectReason_GreaterThan(String v) { regOutOfUserSelectReason(CK_GT, fRES(v)); }
        public void SetOutOfUserSelectReason_LessThan(String v) { regOutOfUserSelectReason(CK_LT, fRES(v)); }
        public void SetOutOfUserSelectReason_GreaterEqual(String v) { regOutOfUserSelectReason(CK_GE, fRES(v)); }
        public void SetOutOfUserSelectReason_LessEqual(String v) { regOutOfUserSelectReason(CK_LE, fRES(v)); }
        public void SetOutOfUserSelectReason_InScope(IList<String> ls) { regINS<String>(CK_INS, cTL<String>(ls), getCValueOutOfUserSelectReason(), "OUT_OF_USER_SELECT_REASON"); }
        public void SetOutOfUserSelectReason_NotInScope(IList<String> ls) { regINS<String>(CK_NINS, cTL<String>(ls), getCValueOutOfUserSelectReason(), "OUT_OF_USER_SELECT_REASON"); }
        public void SetOutOfUserSelectReason_PrefixSearch(String v) { SetOutOfUserSelectReason_LikeSearch(v, cLSOP()); }
        public void SetOutOfUserSelectReason_LikeSearch(String v, LdLikeSearchOption option)
        { regLSQ(CK_LS, fRES(v), getCValueOutOfUserSelectReason(), "OUT_OF_USER_SELECT_REASON", option); }
        public void SetOutOfUserSelectReason_NotLikeSearch(String v, LdLikeSearchOption option)
        { regLSQ(CK_NLS, fRES(v), getCValueOutOfUserSelectReason(), "OUT_OF_USER_SELECT_REASON", option); }
        public void SetOutOfUserSelectReason_IsNull() { regOutOfUserSelectReason(CK_ISN, DUMMY_OBJECT); }
        public void SetOutOfUserSelectReason_IsNotNull() { regOutOfUserSelectReason(CK_ISNN, DUMMY_OBJECT); }
        protected void regOutOfUserSelectReason(LdConditionKey k, Object v) { regQ(k, v, getCValueOutOfUserSelectReason(), "OUT_OF_USER_SELECT_REASON"); }
        protected abstract LdConditionValue getCValueOutOfUserSelectReason();

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
        public SSQFunction<LdBookCB> Scalar_Equal() {
            return xcreateSSQFunction("=");
        }

        public SSQFunction<LdBookCB> Scalar_NotEqual() {
            return xcreateSSQFunction("<>");
        }

        public SSQFunction<LdBookCB> Scalar_GreaterEqual() {
            return xcreateSSQFunction(">=");
        }

        public SSQFunction<LdBookCB> Scalar_GreaterThan() {
            return xcreateSSQFunction(">");
        }

        public SSQFunction<LdBookCB> Scalar_LessEqual() {
            return xcreateSSQFunction("<=");
        }

        public SSQFunction<LdBookCB> Scalar_LessThan() {
            return xcreateSSQFunction("<");
        }

        protected SSQFunction<LdBookCB> xcreateSSQFunction(String operand) {
            return new SSQFunction<LdBookCB>(delegate(String function, LdSubQuery<LdBookCB> subQuery) {
                xscalarSubQuery(function, subQuery, operand);
            });
        }

        protected void xscalarSubQuery(String function, LdSubQuery<LdBookCB> subQuery, String operand) {
            assertObjectNotNull("subQuery<LdBookCB>", subQuery);
            LdBookCB cb = new LdBookCB(); cb.xsetupForScalarCondition(this); subQuery.Invoke(cb);
            String subQueryPropertyName = keepScalarSubQuery(cb.Query()); // for saving query-value.
            registerScalarSubQuery(function, cb.Query(), subQueryPropertyName, operand);
        }
        public abstract String keepScalarSubQuery(LdBookCQ subQuery);

        // ===============================================================================
        //                                                                  MySelf InScope
        //                                                                  ==============
        public void MyselfInScope(LdSubQuery<LdBookCB> subQuery) {
            assertObjectNotNull("subQuery<LdBookCB>", subQuery);
            LdBookCB cb = new LdBookCB(); cb.xsetupForInScopeRelation(this); subQuery.Invoke(cb);
            String subQueryPropertyName = keepMyselfInScopeSubQuery(cb.Query()); // for saving query-value.
            registerInScopeSubQuery(cb.Query(), "BOOK_ID", "BOOK_ID", subQueryPropertyName);
        }
        public abstract String keepMyselfInScopeSubQuery(LdBookCQ subQuery);

        public override String ToString() { return xgetSqlClause().getClause(); }
    }
}
