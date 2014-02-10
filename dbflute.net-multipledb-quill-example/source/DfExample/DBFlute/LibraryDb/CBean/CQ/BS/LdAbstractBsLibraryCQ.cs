
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
    public abstract class LdAbstractBsLibraryCQ : LdAbstractConditionQuery {

        public LdAbstractBsLibraryCQ(LdConditionQuery childQuery, LdSqlClause sqlClause, String aliasName, int nestLevel)
            : base(childQuery, sqlClause, aliasName, nestLevel) {}

        public override String getTableDbName() { return "library"; }
        public override String getTableSqlName() { return "library"; }

        public void SetLibraryId_Equal(int? v) { regLibraryId(CK_EQ, v); }
        public void SetLibraryId_NotEqual(int? v) { regLibraryId(CK_NES, v); }
        public void SetLibraryId_GreaterThan(int? v) { regLibraryId(CK_GT, v); }
        public void SetLibraryId_LessThan(int? v) { regLibraryId(CK_LT, v); }
        public void SetLibraryId_GreaterEqual(int? v) { regLibraryId(CK_GE, v); }
        public void SetLibraryId_LessEqual(int? v) { regLibraryId(CK_LE, v); }
        public void SetLibraryId_InScope(IList<int?> ls) { regINS<int?>(CK_INS, cTL<int?>(ls), getCValueLibraryId(), "LIBRARY_ID"); }
        public void SetLibraryId_NotInScope(IList<int?> ls) { regINS<int?>(CK_NINS, cTL<int?>(ls), getCValueLibraryId(), "LIBRARY_ID"); }
        public void ExistsCollectionList(LdSubQuery<LdCollectionCB> subQuery) {
            assertObjectNotNull("subQuery<LdCollectionCB>", subQuery);
            LdCollectionCB cb = new LdCollectionCB(); cb.xsetupForExistsReferrer(this); subQuery.Invoke(cb);
            String subQueryPropertyName = keepLibraryId_ExistsSubQuery_CollectionList(cb.Query());
            registerExistsSubQuery(cb.Query(), "LIBRARY_ID", "LIBRARY_ID", subQueryPropertyName);
        }
        public abstract String keepLibraryId_ExistsSubQuery_CollectionList(LdCollectionCQ subQuery);
        public void ExistsLibraryUserList(LdSubQuery<LdLibraryUserCB> subQuery) {
            assertObjectNotNull("subQuery<LdLibraryUserCB>", subQuery);
            LdLibraryUserCB cb = new LdLibraryUserCB(); cb.xsetupForExistsReferrer(this); subQuery.Invoke(cb);
            String subQueryPropertyName = keepLibraryId_ExistsSubQuery_LibraryUserList(cb.Query());
            registerExistsSubQuery(cb.Query(), "LIBRARY_ID", "LIBRARY_ID", subQueryPropertyName);
        }
        public abstract String keepLibraryId_ExistsSubQuery_LibraryUserList(LdLibraryUserCQ subQuery);
        public void ExistsNextLibraryByLibraryIdList(LdSubQuery<LdNextLibraryCB> subQuery) {
            assertObjectNotNull("subQuery<LdNextLibraryCB>", subQuery);
            LdNextLibraryCB cb = new LdNextLibraryCB(); cb.xsetupForExistsReferrer(this); subQuery.Invoke(cb);
            String subQueryPropertyName = keepLibraryId_ExistsSubQuery_NextLibraryByLibraryIdList(cb.Query());
            registerExistsSubQuery(cb.Query(), "LIBRARY_ID", "LIBRARY_ID", subQueryPropertyName);
        }
        public abstract String keepLibraryId_ExistsSubQuery_NextLibraryByLibraryIdList(LdNextLibraryCQ subQuery);
        public void ExistsNextLibraryByNextLibraryIdList(LdSubQuery<LdNextLibraryCB> subQuery) {
            assertObjectNotNull("subQuery<LdNextLibraryCB>", subQuery);
            LdNextLibraryCB cb = new LdNextLibraryCB(); cb.xsetupForExistsReferrer(this); subQuery.Invoke(cb);
            String subQueryPropertyName = keepLibraryId_ExistsSubQuery_NextLibraryByNextLibraryIdList(cb.Query());
            registerExistsSubQuery(cb.Query(), "LIBRARY_ID", "NEXT_LIBRARY_ID", subQueryPropertyName);
        }
        public abstract String keepLibraryId_ExistsSubQuery_NextLibraryByNextLibraryIdList(LdNextLibraryCQ subQuery);
        public void NotExistsCollectionList(LdSubQuery<LdCollectionCB> subQuery) {
            assertObjectNotNull("subQuery<LdCollectionCB>", subQuery);
            LdCollectionCB cb = new LdCollectionCB(); cb.xsetupForExistsReferrer(this); subQuery.Invoke(cb);
            String subQueryPropertyName = keepLibraryId_NotExistsSubQuery_CollectionList(cb.Query());
            registerNotExistsSubQuery(cb.Query(), "LIBRARY_ID", "LIBRARY_ID", subQueryPropertyName);
        }
        public abstract String keepLibraryId_NotExistsSubQuery_CollectionList(LdCollectionCQ subQuery);
        public void NotExistsLibraryUserList(LdSubQuery<LdLibraryUserCB> subQuery) {
            assertObjectNotNull("subQuery<LdLibraryUserCB>", subQuery);
            LdLibraryUserCB cb = new LdLibraryUserCB(); cb.xsetupForExistsReferrer(this); subQuery.Invoke(cb);
            String subQueryPropertyName = keepLibraryId_NotExistsSubQuery_LibraryUserList(cb.Query());
            registerNotExistsSubQuery(cb.Query(), "LIBRARY_ID", "LIBRARY_ID", subQueryPropertyName);
        }
        public abstract String keepLibraryId_NotExistsSubQuery_LibraryUserList(LdLibraryUserCQ subQuery);
        public void NotExistsNextLibraryByLibraryIdList(LdSubQuery<LdNextLibraryCB> subQuery) {
            assertObjectNotNull("subQuery<LdNextLibraryCB>", subQuery);
            LdNextLibraryCB cb = new LdNextLibraryCB(); cb.xsetupForExistsReferrer(this); subQuery.Invoke(cb);
            String subQueryPropertyName = keepLibraryId_NotExistsSubQuery_NextLibraryByLibraryIdList(cb.Query());
            registerNotExistsSubQuery(cb.Query(), "LIBRARY_ID", "LIBRARY_ID", subQueryPropertyName);
        }
        public abstract String keepLibraryId_NotExistsSubQuery_NextLibraryByLibraryIdList(LdNextLibraryCQ subQuery);
        public void NotExistsNextLibraryByNextLibraryIdList(LdSubQuery<LdNextLibraryCB> subQuery) {
            assertObjectNotNull("subQuery<LdNextLibraryCB>", subQuery);
            LdNextLibraryCB cb = new LdNextLibraryCB(); cb.xsetupForExistsReferrer(this); subQuery.Invoke(cb);
            String subQueryPropertyName = keepLibraryId_NotExistsSubQuery_NextLibraryByNextLibraryIdList(cb.Query());
            registerNotExistsSubQuery(cb.Query(), "LIBRARY_ID", "NEXT_LIBRARY_ID", subQueryPropertyName);
        }
        public abstract String keepLibraryId_NotExistsSubQuery_NextLibraryByNextLibraryIdList(LdNextLibraryCQ subQuery);
        public void InScopeCollectionList(LdSubQuery<LdCollectionCB> subQuery) {
            assertObjectNotNull("subQuery<LdCollectionCB>", subQuery);
            LdCollectionCB cb = new LdCollectionCB(); cb.xsetupForInScopeRelation(this); subQuery.Invoke(cb);
            String subQueryPropertyName = keepLibraryId_InScopeSubQuery_CollectionList(cb.Query());
            registerInScopeSubQuery(cb.Query(), "LIBRARY_ID", "LIBRARY_ID", subQueryPropertyName);
        }
        public abstract String keepLibraryId_InScopeSubQuery_CollectionList(LdCollectionCQ subQuery);
        public void InScopeLibraryUserList(LdSubQuery<LdLibraryUserCB> subQuery) {
            assertObjectNotNull("subQuery<LdLibraryUserCB>", subQuery);
            LdLibraryUserCB cb = new LdLibraryUserCB(); cb.xsetupForInScopeRelation(this); subQuery.Invoke(cb);
            String subQueryPropertyName = keepLibraryId_InScopeSubQuery_LibraryUserList(cb.Query());
            registerInScopeSubQuery(cb.Query(), "LIBRARY_ID", "LIBRARY_ID", subQueryPropertyName);
        }
        public abstract String keepLibraryId_InScopeSubQuery_LibraryUserList(LdLibraryUserCQ subQuery);
        public void InScopeNextLibraryByLibraryIdList(LdSubQuery<LdNextLibraryCB> subQuery) {
            assertObjectNotNull("subQuery<LdNextLibraryCB>", subQuery);
            LdNextLibraryCB cb = new LdNextLibraryCB(); cb.xsetupForInScopeRelation(this); subQuery.Invoke(cb);
            String subQueryPropertyName = keepLibraryId_InScopeSubQuery_NextLibraryByLibraryIdList(cb.Query());
            registerInScopeSubQuery(cb.Query(), "LIBRARY_ID", "LIBRARY_ID", subQueryPropertyName);
        }
        public abstract String keepLibraryId_InScopeSubQuery_NextLibraryByLibraryIdList(LdNextLibraryCQ subQuery);
        public void InScopeNextLibraryByNextLibraryIdList(LdSubQuery<LdNextLibraryCB> subQuery) {
            assertObjectNotNull("subQuery<LdNextLibraryCB>", subQuery);
            LdNextLibraryCB cb = new LdNextLibraryCB(); cb.xsetupForInScopeRelation(this); subQuery.Invoke(cb);
            String subQueryPropertyName = keepLibraryId_InScopeSubQuery_NextLibraryByNextLibraryIdList(cb.Query());
            registerInScopeSubQuery(cb.Query(), "LIBRARY_ID", "NEXT_LIBRARY_ID", subQueryPropertyName);
        }
        public abstract String keepLibraryId_InScopeSubQuery_NextLibraryByNextLibraryIdList(LdNextLibraryCQ subQuery);
        public void NotInScopeCollectionList(LdSubQuery<LdCollectionCB> subQuery) {
            assertObjectNotNull("subQuery<LdCollectionCB>", subQuery);
            LdCollectionCB cb = new LdCollectionCB(); cb.xsetupForInScopeRelation(this); subQuery.Invoke(cb);
            String subQueryPropertyName = keepLibraryId_NotInScopeSubQuery_CollectionList(cb.Query());
            registerNotInScopeSubQuery(cb.Query(), "LIBRARY_ID", "LIBRARY_ID", subQueryPropertyName);
        }
        public abstract String keepLibraryId_NotInScopeSubQuery_CollectionList(LdCollectionCQ subQuery);
        public void NotInScopeLibraryUserList(LdSubQuery<LdLibraryUserCB> subQuery) {
            assertObjectNotNull("subQuery<LdLibraryUserCB>", subQuery);
            LdLibraryUserCB cb = new LdLibraryUserCB(); cb.xsetupForInScopeRelation(this); subQuery.Invoke(cb);
            String subQueryPropertyName = keepLibraryId_NotInScopeSubQuery_LibraryUserList(cb.Query());
            registerNotInScopeSubQuery(cb.Query(), "LIBRARY_ID", "LIBRARY_ID", subQueryPropertyName);
        }
        public abstract String keepLibraryId_NotInScopeSubQuery_LibraryUserList(LdLibraryUserCQ subQuery);
        public void NotInScopeNextLibraryByLibraryIdList(LdSubQuery<LdNextLibraryCB> subQuery) {
            assertObjectNotNull("subQuery<LdNextLibraryCB>", subQuery);
            LdNextLibraryCB cb = new LdNextLibraryCB(); cb.xsetupForInScopeRelation(this); subQuery.Invoke(cb);
            String subQueryPropertyName = keepLibraryId_NotInScopeSubQuery_NextLibraryByLibraryIdList(cb.Query());
            registerNotInScopeSubQuery(cb.Query(), "LIBRARY_ID", "LIBRARY_ID", subQueryPropertyName);
        }
        public abstract String keepLibraryId_NotInScopeSubQuery_NextLibraryByLibraryIdList(LdNextLibraryCQ subQuery);
        public void NotInScopeNextLibraryByNextLibraryIdList(LdSubQuery<LdNextLibraryCB> subQuery) {
            assertObjectNotNull("subQuery<LdNextLibraryCB>", subQuery);
            LdNextLibraryCB cb = new LdNextLibraryCB(); cb.xsetupForInScopeRelation(this); subQuery.Invoke(cb);
            String subQueryPropertyName = keepLibraryId_NotInScopeSubQuery_NextLibraryByNextLibraryIdList(cb.Query());
            registerNotInScopeSubQuery(cb.Query(), "LIBRARY_ID", "NEXT_LIBRARY_ID", subQueryPropertyName);
        }
        public abstract String keepLibraryId_NotInScopeSubQuery_NextLibraryByNextLibraryIdList(LdNextLibraryCQ subQuery);
        public void xsderiveCollectionList(String function, LdSubQuery<LdCollectionCB> subQuery, String aliasName) {
            assertObjectNotNull("subQuery<LdCollectionCB>", subQuery);
            LdCollectionCB cb = new LdCollectionCB(); cb.xsetupForDerivedReferrer(this); subQuery.Invoke(cb);
            String subQueryPropertyName = keepLibraryId_SpecifyDerivedReferrer_CollectionList(cb.Query());
            registerSpecifyDerivedReferrer(function, cb.Query(), "LIBRARY_ID", "LIBRARY_ID", subQueryPropertyName, aliasName);
        }
        abstract public String keepLibraryId_SpecifyDerivedReferrer_CollectionList(LdCollectionCQ subQuery);
        public void xsderiveLibraryUserList(String function, LdSubQuery<LdLibraryUserCB> subQuery, String aliasName) {
            assertObjectNotNull("subQuery<LdLibraryUserCB>", subQuery);
            LdLibraryUserCB cb = new LdLibraryUserCB(); cb.xsetupForDerivedReferrer(this); subQuery.Invoke(cb);
            String subQueryPropertyName = keepLibraryId_SpecifyDerivedReferrer_LibraryUserList(cb.Query());
            registerSpecifyDerivedReferrer(function, cb.Query(), "LIBRARY_ID", "LIBRARY_ID", subQueryPropertyName, aliasName);
        }
        abstract public String keepLibraryId_SpecifyDerivedReferrer_LibraryUserList(LdLibraryUserCQ subQuery);
        public void xsderiveNextLibraryByLibraryIdList(String function, LdSubQuery<LdNextLibraryCB> subQuery, String aliasName) {
            assertObjectNotNull("subQuery<LdNextLibraryCB>", subQuery);
            LdNextLibraryCB cb = new LdNextLibraryCB(); cb.xsetupForDerivedReferrer(this); subQuery.Invoke(cb);
            String subQueryPropertyName = keepLibraryId_SpecifyDerivedReferrer_NextLibraryByLibraryIdList(cb.Query());
            registerSpecifyDerivedReferrer(function, cb.Query(), "LIBRARY_ID", "LIBRARY_ID", subQueryPropertyName, aliasName);
        }
        abstract public String keepLibraryId_SpecifyDerivedReferrer_NextLibraryByLibraryIdList(LdNextLibraryCQ subQuery);
        public void xsderiveNextLibraryByNextLibraryIdList(String function, LdSubQuery<LdNextLibraryCB> subQuery, String aliasName) {
            assertObjectNotNull("subQuery<LdNextLibraryCB>", subQuery);
            LdNextLibraryCB cb = new LdNextLibraryCB(); cb.xsetupForDerivedReferrer(this); subQuery.Invoke(cb);
            String subQueryPropertyName = keepLibraryId_SpecifyDerivedReferrer_NextLibraryByNextLibraryIdList(cb.Query());
            registerSpecifyDerivedReferrer(function, cb.Query(), "LIBRARY_ID", "NEXT_LIBRARY_ID", subQueryPropertyName, aliasName);
        }
        abstract public String keepLibraryId_SpecifyDerivedReferrer_NextLibraryByNextLibraryIdList(LdNextLibraryCQ subQuery);

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
            String subQueryPropertyName = keepLibraryId_QueryDerivedReferrer_CollectionList(cb.Query()); // for saving query-value.
            String parameterPropertyName = keepLibraryId_QueryDerivedReferrer_CollectionListParameter(value);
            registerQueryDerivedReferrer(function, cb.Query(), "LIBRARY_ID", "LIBRARY_ID", subQueryPropertyName, operand, value, parameterPropertyName);
        }
        public abstract String keepLibraryId_QueryDerivedReferrer_CollectionList(LdCollectionCQ subQuery);
        public abstract String keepLibraryId_QueryDerivedReferrer_CollectionListParameter(Object parameterValue);

        public QDRFunction<LdLibraryUserCB> DerivedLibraryUserList() {
            return xcreateQDRFunctionLibraryUserList();
        }
        protected QDRFunction<LdLibraryUserCB> xcreateQDRFunctionLibraryUserList() {
            return new QDRFunction<LdLibraryUserCB>(delegate(String function, LdSubQuery<LdLibraryUserCB> subQuery, String operand, Object value) {
                xqderiveLibraryUserList(function, subQuery, operand, value);
            });
        }
        public void xqderiveLibraryUserList(String function, LdSubQuery<LdLibraryUserCB> subQuery, String operand, Object value) {
            assertObjectNotNull("subQuery<LdLibraryUserCB>", subQuery);
            LdLibraryUserCB cb = new LdLibraryUserCB(); cb.xsetupForDerivedReferrer(this); subQuery.Invoke(cb);
            String subQueryPropertyName = keepLibraryId_QueryDerivedReferrer_LibraryUserList(cb.Query()); // for saving query-value.
            String parameterPropertyName = keepLibraryId_QueryDerivedReferrer_LibraryUserListParameter(value);
            registerQueryDerivedReferrer(function, cb.Query(), "LIBRARY_ID", "LIBRARY_ID", subQueryPropertyName, operand, value, parameterPropertyName);
        }
        public abstract String keepLibraryId_QueryDerivedReferrer_LibraryUserList(LdLibraryUserCQ subQuery);
        public abstract String keepLibraryId_QueryDerivedReferrer_LibraryUserListParameter(Object parameterValue);

        public QDRFunction<LdNextLibraryCB> DerivedNextLibraryByLibraryIdList() {
            return xcreateQDRFunctionNextLibraryByLibraryIdList();
        }
        protected QDRFunction<LdNextLibraryCB> xcreateQDRFunctionNextLibraryByLibraryIdList() {
            return new QDRFunction<LdNextLibraryCB>(delegate(String function, LdSubQuery<LdNextLibraryCB> subQuery, String operand, Object value) {
                xqderiveNextLibraryByLibraryIdList(function, subQuery, operand, value);
            });
        }
        public void xqderiveNextLibraryByLibraryIdList(String function, LdSubQuery<LdNextLibraryCB> subQuery, String operand, Object value) {
            assertObjectNotNull("subQuery<LdNextLibraryCB>", subQuery);
            LdNextLibraryCB cb = new LdNextLibraryCB(); cb.xsetupForDerivedReferrer(this); subQuery.Invoke(cb);
            String subQueryPropertyName = keepLibraryId_QueryDerivedReferrer_NextLibraryByLibraryIdList(cb.Query()); // for saving query-value.
            String parameterPropertyName = keepLibraryId_QueryDerivedReferrer_NextLibraryByLibraryIdListParameter(value);
            registerQueryDerivedReferrer(function, cb.Query(), "LIBRARY_ID", "LIBRARY_ID", subQueryPropertyName, operand, value, parameterPropertyName);
        }
        public abstract String keepLibraryId_QueryDerivedReferrer_NextLibraryByLibraryIdList(LdNextLibraryCQ subQuery);
        public abstract String keepLibraryId_QueryDerivedReferrer_NextLibraryByLibraryIdListParameter(Object parameterValue);

        public QDRFunction<LdNextLibraryCB> DerivedNextLibraryByNextLibraryIdList() {
            return xcreateQDRFunctionNextLibraryByNextLibraryIdList();
        }
        protected QDRFunction<LdNextLibraryCB> xcreateQDRFunctionNextLibraryByNextLibraryIdList() {
            return new QDRFunction<LdNextLibraryCB>(delegate(String function, LdSubQuery<LdNextLibraryCB> subQuery, String operand, Object value) {
                xqderiveNextLibraryByNextLibraryIdList(function, subQuery, operand, value);
            });
        }
        public void xqderiveNextLibraryByNextLibraryIdList(String function, LdSubQuery<LdNextLibraryCB> subQuery, String operand, Object value) {
            assertObjectNotNull("subQuery<LdNextLibraryCB>", subQuery);
            LdNextLibraryCB cb = new LdNextLibraryCB(); cb.xsetupForDerivedReferrer(this); subQuery.Invoke(cb);
            String subQueryPropertyName = keepLibraryId_QueryDerivedReferrer_NextLibraryByNextLibraryIdList(cb.Query()); // for saving query-value.
            String parameterPropertyName = keepLibraryId_QueryDerivedReferrer_NextLibraryByNextLibraryIdListParameter(value);
            registerQueryDerivedReferrer(function, cb.Query(), "LIBRARY_ID", "NEXT_LIBRARY_ID", subQueryPropertyName, operand, value, parameterPropertyName);
        }
        public abstract String keepLibraryId_QueryDerivedReferrer_NextLibraryByNextLibraryIdList(LdNextLibraryCQ subQuery);
        public abstract String keepLibraryId_QueryDerivedReferrer_NextLibraryByNextLibraryIdListParameter(Object parameterValue);
        public void SetLibraryId_IsNull() { regLibraryId(CK_ISN, DUMMY_OBJECT); }
        public void SetLibraryId_IsNotNull() { regLibraryId(CK_ISNN, DUMMY_OBJECT); }
        protected void regLibraryId(LdConditionKey k, Object v) { regQ(k, v, getCValueLibraryId(), "LIBRARY_ID"); }
        protected abstract LdConditionValue getCValueLibraryId();

        public void SetLibraryName_Equal(String v) { DoSetLibraryName_Equal(fRES(v)); }
        protected void DoSetLibraryName_Equal(String v) { regLibraryName(CK_EQ, v); }
        public void SetLibraryName_NotEqual(String v) { DoSetLibraryName_NotEqual(fRES(v)); }
        protected void DoSetLibraryName_NotEqual(String v) { regLibraryName(CK_NES, v); }
        public void SetLibraryName_GreaterThan(String v) { regLibraryName(CK_GT, fRES(v)); }
        public void SetLibraryName_LessThan(String v) { regLibraryName(CK_LT, fRES(v)); }
        public void SetLibraryName_GreaterEqual(String v) { regLibraryName(CK_GE, fRES(v)); }
        public void SetLibraryName_LessEqual(String v) { regLibraryName(CK_LE, fRES(v)); }
        public void SetLibraryName_InScope(IList<String> ls) { regINS<String>(CK_INS, cTL<String>(ls), getCValueLibraryName(), "LIBRARY_NAME"); }
        public void SetLibraryName_NotInScope(IList<String> ls) { regINS<String>(CK_NINS, cTL<String>(ls), getCValueLibraryName(), "LIBRARY_NAME"); }
        public void SetLibraryName_PrefixSearch(String v) { SetLibraryName_LikeSearch(v, cLSOP()); }
        public void SetLibraryName_LikeSearch(String v, LdLikeSearchOption option)
        { regLSQ(CK_LS, fRES(v), getCValueLibraryName(), "LIBRARY_NAME", option); }
        public void SetLibraryName_NotLikeSearch(String v, LdLikeSearchOption option)
        { regLSQ(CK_NLS, fRES(v), getCValueLibraryName(), "LIBRARY_NAME", option); }
        protected void regLibraryName(LdConditionKey k, Object v) { regQ(k, v, getCValueLibraryName(), "LIBRARY_NAME"); }
        protected abstract LdConditionValue getCValueLibraryName();

        public void SetLibraryTypeCode_Equal(String v) { DoSetLibraryTypeCode_Equal(fRES(v)); }
        protected void DoSetLibraryTypeCode_Equal(String v) { regLibraryTypeCode(CK_EQ, v); }
        public void SetLibraryTypeCode_NotEqual(String v) { DoSetLibraryTypeCode_NotEqual(fRES(v)); }
        protected void DoSetLibraryTypeCode_NotEqual(String v) { regLibraryTypeCode(CK_NES, v); }
        public void SetLibraryTypeCode_GreaterThan(String v) { regLibraryTypeCode(CK_GT, fRES(v)); }
        public void SetLibraryTypeCode_LessThan(String v) { regLibraryTypeCode(CK_LT, fRES(v)); }
        public void SetLibraryTypeCode_GreaterEqual(String v) { regLibraryTypeCode(CK_GE, fRES(v)); }
        public void SetLibraryTypeCode_LessEqual(String v) { regLibraryTypeCode(CK_LE, fRES(v)); }
        public void SetLibraryTypeCode_InScope(IList<String> ls) { regINS<String>(CK_INS, cTL<String>(ls), getCValueLibraryTypeCode(), "LIBRARY_TYPE_CODE"); }
        public void SetLibraryTypeCode_NotInScope(IList<String> ls) { regINS<String>(CK_NINS, cTL<String>(ls), getCValueLibraryTypeCode(), "LIBRARY_TYPE_CODE"); }
        public void SetLibraryTypeCode_PrefixSearch(String v) { SetLibraryTypeCode_LikeSearch(v, cLSOP()); }
        public void SetLibraryTypeCode_LikeSearch(String v, LdLikeSearchOption option)
        { regLSQ(CK_LS, fRES(v), getCValueLibraryTypeCode(), "LIBRARY_TYPE_CODE", option); }
        public void SetLibraryTypeCode_NotLikeSearch(String v, LdLikeSearchOption option)
        { regLSQ(CK_NLS, fRES(v), getCValueLibraryTypeCode(), "LIBRARY_TYPE_CODE", option); }
        public void InScopeLibraryTypeLookup(LdSubQuery<LdLibraryTypeLookupCB> subQuery) {
            assertObjectNotNull("subQuery<LdLibraryTypeLookupCB>", subQuery);
            LdLibraryTypeLookupCB cb = new LdLibraryTypeLookupCB(); cb.xsetupForInScopeRelation(this); subQuery.Invoke(cb);
            String subQueryPropertyName = keepLibraryTypeCode_InScopeSubQuery_LibraryTypeLookup(cb.Query());
            registerInScopeSubQuery(cb.Query(), "LIBRARY_TYPE_CODE", "LIBRARY_TYPE_CODE", subQueryPropertyName);
        }
        public abstract String keepLibraryTypeCode_InScopeSubQuery_LibraryTypeLookup(LdLibraryTypeLookupCQ subQuery);
        public void NotInScopeLibraryTypeLookup(LdSubQuery<LdLibraryTypeLookupCB> subQuery) {
            assertObjectNotNull("subQuery<LdLibraryTypeLookupCB>", subQuery);
            LdLibraryTypeLookupCB cb = new LdLibraryTypeLookupCB(); cb.xsetupForInScopeRelation(this); subQuery.Invoke(cb);
            String subQueryPropertyName = keepLibraryTypeCode_NotInScopeSubQuery_LibraryTypeLookup(cb.Query());
            registerNotInScopeSubQuery(cb.Query(), "LIBRARY_TYPE_CODE", "LIBRARY_TYPE_CODE", subQueryPropertyName);
        }
        public abstract String keepLibraryTypeCode_NotInScopeSubQuery_LibraryTypeLookup(LdLibraryTypeLookupCQ subQuery);
        protected void regLibraryTypeCode(LdConditionKey k, Object v) { regQ(k, v, getCValueLibraryTypeCode(), "LIBRARY_TYPE_CODE"); }
        protected abstract LdConditionValue getCValueLibraryTypeCode();

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
        public SSQFunction<LdLibraryCB> Scalar_Equal() {
            return xcreateSSQFunction("=");
        }

        public SSQFunction<LdLibraryCB> Scalar_NotEqual() {
            return xcreateSSQFunction("<>");
        }

        public SSQFunction<LdLibraryCB> Scalar_GreaterEqual() {
            return xcreateSSQFunction(">=");
        }

        public SSQFunction<LdLibraryCB> Scalar_GreaterThan() {
            return xcreateSSQFunction(">");
        }

        public SSQFunction<LdLibraryCB> Scalar_LessEqual() {
            return xcreateSSQFunction("<=");
        }

        public SSQFunction<LdLibraryCB> Scalar_LessThan() {
            return xcreateSSQFunction("<");
        }

        protected SSQFunction<LdLibraryCB> xcreateSSQFunction(String operand) {
            return new SSQFunction<LdLibraryCB>(delegate(String function, LdSubQuery<LdLibraryCB> subQuery) {
                xscalarSubQuery(function, subQuery, operand);
            });
        }

        protected void xscalarSubQuery(String function, LdSubQuery<LdLibraryCB> subQuery, String operand) {
            assertObjectNotNull("subQuery<LdLibraryCB>", subQuery);
            LdLibraryCB cb = new LdLibraryCB(); cb.xsetupForScalarCondition(this); subQuery.Invoke(cb);
            String subQueryPropertyName = keepScalarSubQuery(cb.Query()); // for saving query-value.
            registerScalarSubQuery(function, cb.Query(), subQueryPropertyName, operand);
        }
        public abstract String keepScalarSubQuery(LdLibraryCQ subQuery);

        // ===============================================================================
        //                                                                  MySelf InScope
        //                                                                  ==============
        public void MyselfInScope(LdSubQuery<LdLibraryCB> subQuery) {
            assertObjectNotNull("subQuery<LdLibraryCB>", subQuery);
            LdLibraryCB cb = new LdLibraryCB(); cb.xsetupForInScopeRelation(this); subQuery.Invoke(cb);
            String subQueryPropertyName = keepMyselfInScopeSubQuery(cb.Query()); // for saving query-value.
            registerInScopeSubQuery(cb.Query(), "LIBRARY_ID", "LIBRARY_ID", subQueryPropertyName);
        }
        public abstract String keepMyselfInScopeSubQuery(LdLibraryCQ subQuery);

        public override String ToString() { return xgetSqlClause().getClause(); }
    }
}
