
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
    public abstract class LdAbstractBsLibraryTypeLookupCQ : LdAbstractConditionQuery {

        public LdAbstractBsLibraryTypeLookupCQ(LdConditionQuery childQuery, LdSqlClause sqlClause, String aliasName, int nestLevel)
            : base(childQuery, sqlClause, aliasName, nestLevel) {}

        public override String getTableDbName() { return "library_type_lookup"; }
        public override String getTableSqlName() { return "library_type_lookup"; }

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
        public void ExistsLibraryList(LdSubQuery<LdLibraryCB> subQuery) {
            assertObjectNotNull("subQuery<LdLibraryCB>", subQuery);
            LdLibraryCB cb = new LdLibraryCB(); cb.xsetupForExistsReferrer(this); subQuery.Invoke(cb);
            String subQueryPropertyName = keepLibraryTypeCode_ExistsSubQuery_LibraryList(cb.Query());
            registerExistsSubQuery(cb.Query(), "LIBRARY_TYPE_CODE", "LIBRARY_TYPE_CODE", subQueryPropertyName);
        }
        public abstract String keepLibraryTypeCode_ExistsSubQuery_LibraryList(LdLibraryCQ subQuery);
        public void NotExistsLibraryList(LdSubQuery<LdLibraryCB> subQuery) {
            assertObjectNotNull("subQuery<LdLibraryCB>", subQuery);
            LdLibraryCB cb = new LdLibraryCB(); cb.xsetupForExistsReferrer(this); subQuery.Invoke(cb);
            String subQueryPropertyName = keepLibraryTypeCode_NotExistsSubQuery_LibraryList(cb.Query());
            registerNotExistsSubQuery(cb.Query(), "LIBRARY_TYPE_CODE", "LIBRARY_TYPE_CODE", subQueryPropertyName);
        }
        public abstract String keepLibraryTypeCode_NotExistsSubQuery_LibraryList(LdLibraryCQ subQuery);
        public void InScopeLibraryList(LdSubQuery<LdLibraryCB> subQuery) {
            assertObjectNotNull("subQuery<LdLibraryCB>", subQuery);
            LdLibraryCB cb = new LdLibraryCB(); cb.xsetupForInScopeRelation(this); subQuery.Invoke(cb);
            String subQueryPropertyName = keepLibraryTypeCode_InScopeSubQuery_LibraryList(cb.Query());
            registerInScopeSubQuery(cb.Query(), "LIBRARY_TYPE_CODE", "LIBRARY_TYPE_CODE", subQueryPropertyName);
        }
        public abstract String keepLibraryTypeCode_InScopeSubQuery_LibraryList(LdLibraryCQ subQuery);
        public void NotInScopeLibraryList(LdSubQuery<LdLibraryCB> subQuery) {
            assertObjectNotNull("subQuery<LdLibraryCB>", subQuery);
            LdLibraryCB cb = new LdLibraryCB(); cb.xsetupForInScopeRelation(this); subQuery.Invoke(cb);
            String subQueryPropertyName = keepLibraryTypeCode_NotInScopeSubQuery_LibraryList(cb.Query());
            registerNotInScopeSubQuery(cb.Query(), "LIBRARY_TYPE_CODE", "LIBRARY_TYPE_CODE", subQueryPropertyName);
        }
        public abstract String keepLibraryTypeCode_NotInScopeSubQuery_LibraryList(LdLibraryCQ subQuery);
        public void xsderiveLibraryList(String function, LdSubQuery<LdLibraryCB> subQuery, String aliasName) {
            assertObjectNotNull("subQuery<LdLibraryCB>", subQuery);
            LdLibraryCB cb = new LdLibraryCB(); cb.xsetupForDerivedReferrer(this); subQuery.Invoke(cb);
            String subQueryPropertyName = keepLibraryTypeCode_SpecifyDerivedReferrer_LibraryList(cb.Query());
            registerSpecifyDerivedReferrer(function, cb.Query(), "LIBRARY_TYPE_CODE", "LIBRARY_TYPE_CODE", subQueryPropertyName, aliasName);
        }
        abstract public String keepLibraryTypeCode_SpecifyDerivedReferrer_LibraryList(LdLibraryCQ subQuery);

        public QDRFunction<LdLibraryCB> DerivedLibraryList() {
            return xcreateQDRFunctionLibraryList();
        }
        protected QDRFunction<LdLibraryCB> xcreateQDRFunctionLibraryList() {
            return new QDRFunction<LdLibraryCB>(delegate(String function, LdSubQuery<LdLibraryCB> subQuery, String operand, Object value) {
                xqderiveLibraryList(function, subQuery, operand, value);
            });
        }
        public void xqderiveLibraryList(String function, LdSubQuery<LdLibraryCB> subQuery, String operand, Object value) {
            assertObjectNotNull("subQuery<LdLibraryCB>", subQuery);
            LdLibraryCB cb = new LdLibraryCB(); cb.xsetupForDerivedReferrer(this); subQuery.Invoke(cb);
            String subQueryPropertyName = keepLibraryTypeCode_QueryDerivedReferrer_LibraryList(cb.Query()); // for saving query-value.
            String parameterPropertyName = keepLibraryTypeCode_QueryDerivedReferrer_LibraryListParameter(value);
            registerQueryDerivedReferrer(function, cb.Query(), "LIBRARY_TYPE_CODE", "LIBRARY_TYPE_CODE", subQueryPropertyName, operand, value, parameterPropertyName);
        }
        public abstract String keepLibraryTypeCode_QueryDerivedReferrer_LibraryList(LdLibraryCQ subQuery);
        public abstract String keepLibraryTypeCode_QueryDerivedReferrer_LibraryListParameter(Object parameterValue);
        public void SetLibraryTypeCode_IsNull() { regLibraryTypeCode(CK_ISN, DUMMY_OBJECT); }
        public void SetLibraryTypeCode_IsNotNull() { regLibraryTypeCode(CK_ISNN, DUMMY_OBJECT); }
        protected void regLibraryTypeCode(LdConditionKey k, Object v) { regQ(k, v, getCValueLibraryTypeCode(), "LIBRARY_TYPE_CODE"); }
        protected abstract LdConditionValue getCValueLibraryTypeCode();

        public void SetLibraryTypeName_Equal(String v) { DoSetLibraryTypeName_Equal(fRES(v)); }
        protected void DoSetLibraryTypeName_Equal(String v) { regLibraryTypeName(CK_EQ, v); }
        public void SetLibraryTypeName_NotEqual(String v) { DoSetLibraryTypeName_NotEqual(fRES(v)); }
        protected void DoSetLibraryTypeName_NotEqual(String v) { regLibraryTypeName(CK_NES, v); }
        public void SetLibraryTypeName_GreaterThan(String v) { regLibraryTypeName(CK_GT, fRES(v)); }
        public void SetLibraryTypeName_LessThan(String v) { regLibraryTypeName(CK_LT, fRES(v)); }
        public void SetLibraryTypeName_GreaterEqual(String v) { regLibraryTypeName(CK_GE, fRES(v)); }
        public void SetLibraryTypeName_LessEqual(String v) { regLibraryTypeName(CK_LE, fRES(v)); }
        public void SetLibraryTypeName_InScope(IList<String> ls) { regINS<String>(CK_INS, cTL<String>(ls), getCValueLibraryTypeName(), "LIBRARY_TYPE_NAME"); }
        public void SetLibraryTypeName_NotInScope(IList<String> ls) { regINS<String>(CK_NINS, cTL<String>(ls), getCValueLibraryTypeName(), "LIBRARY_TYPE_NAME"); }
        public void SetLibraryTypeName_PrefixSearch(String v) { SetLibraryTypeName_LikeSearch(v, cLSOP()); }
        public void SetLibraryTypeName_LikeSearch(String v, LdLikeSearchOption option)
        { regLSQ(CK_LS, fRES(v), getCValueLibraryTypeName(), "LIBRARY_TYPE_NAME", option); }
        public void SetLibraryTypeName_NotLikeSearch(String v, LdLikeSearchOption option)
        { regLSQ(CK_NLS, fRES(v), getCValueLibraryTypeName(), "LIBRARY_TYPE_NAME", option); }
        protected void regLibraryTypeName(LdConditionKey k, Object v) { regQ(k, v, getCValueLibraryTypeName(), "LIBRARY_TYPE_NAME"); }
        protected abstract LdConditionValue getCValueLibraryTypeName();

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
        public SSQFunction<LdLibraryTypeLookupCB> Scalar_Equal() {
            return xcreateSSQFunction("=");
        }

        public SSQFunction<LdLibraryTypeLookupCB> Scalar_NotEqual() {
            return xcreateSSQFunction("<>");
        }

        public SSQFunction<LdLibraryTypeLookupCB> Scalar_GreaterEqual() {
            return xcreateSSQFunction(">=");
        }

        public SSQFunction<LdLibraryTypeLookupCB> Scalar_GreaterThan() {
            return xcreateSSQFunction(">");
        }

        public SSQFunction<LdLibraryTypeLookupCB> Scalar_LessEqual() {
            return xcreateSSQFunction("<=");
        }

        public SSQFunction<LdLibraryTypeLookupCB> Scalar_LessThan() {
            return xcreateSSQFunction("<");
        }

        protected SSQFunction<LdLibraryTypeLookupCB> xcreateSSQFunction(String operand) {
            return new SSQFunction<LdLibraryTypeLookupCB>(delegate(String function, LdSubQuery<LdLibraryTypeLookupCB> subQuery) {
                xscalarSubQuery(function, subQuery, operand);
            });
        }

        protected void xscalarSubQuery(String function, LdSubQuery<LdLibraryTypeLookupCB> subQuery, String operand) {
            assertObjectNotNull("subQuery<LdLibraryTypeLookupCB>", subQuery);
            LdLibraryTypeLookupCB cb = new LdLibraryTypeLookupCB(); cb.xsetupForScalarCondition(this); subQuery.Invoke(cb);
            String subQueryPropertyName = keepScalarSubQuery(cb.Query()); // for saving query-value.
            registerScalarSubQuery(function, cb.Query(), subQueryPropertyName, operand);
        }
        public abstract String keepScalarSubQuery(LdLibraryTypeLookupCQ subQuery);

        // ===============================================================================
        //                                                                  MySelf InScope
        //                                                                  ==============
        public void MyselfInScope(LdSubQuery<LdLibraryTypeLookupCB> subQuery) {
            assertObjectNotNull("subQuery<LdLibraryTypeLookupCB>", subQuery);
            LdLibraryTypeLookupCB cb = new LdLibraryTypeLookupCB(); cb.xsetupForInScopeRelation(this); subQuery.Invoke(cb);
            String subQueryPropertyName = keepMyselfInScopeSubQuery(cb.Query()); // for saving query-value.
            registerInScopeSubQuery(cb.Query(), "LIBRARY_TYPE_CODE", "LIBRARY_TYPE_CODE", subQueryPropertyName);
        }
        public abstract String keepMyselfInScopeSubQuery(LdLibraryTypeLookupCQ subQuery);

        public override String ToString() { return xgetSqlClause().getClause(); }
    }
}
