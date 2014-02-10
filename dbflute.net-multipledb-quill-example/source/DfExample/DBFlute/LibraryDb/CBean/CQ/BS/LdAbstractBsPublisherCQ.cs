
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
    public abstract class LdAbstractBsPublisherCQ : LdAbstractConditionQuery {

        public LdAbstractBsPublisherCQ(LdConditionQuery childQuery, LdSqlClause sqlClause, String aliasName, int nestLevel)
            : base(childQuery, sqlClause, aliasName, nestLevel) {}

        public override String getTableDbName() { return "publisher"; }
        public override String getTableSqlName() { return "publisher"; }

        public void SetPublisherId_Equal(int? v) { regPublisherId(CK_EQ, v); }
        public void SetPublisherId_NotEqual(int? v) { regPublisherId(CK_NES, v); }
        public void SetPublisherId_GreaterThan(int? v) { regPublisherId(CK_GT, v); }
        public void SetPublisherId_LessThan(int? v) { regPublisherId(CK_LT, v); }
        public void SetPublisherId_GreaterEqual(int? v) { regPublisherId(CK_GE, v); }
        public void SetPublisherId_LessEqual(int? v) { regPublisherId(CK_LE, v); }
        public void SetPublisherId_InScope(IList<int?> ls) { regINS<int?>(CK_INS, cTL<int?>(ls), getCValuePublisherId(), "PUBLISHER_ID"); }
        public void SetPublisherId_NotInScope(IList<int?> ls) { regINS<int?>(CK_NINS, cTL<int?>(ls), getCValuePublisherId(), "PUBLISHER_ID"); }
        public void ExistsBookList(LdSubQuery<LdBookCB> subQuery) {
            assertObjectNotNull("subQuery<LdBookCB>", subQuery);
            LdBookCB cb = new LdBookCB(); cb.xsetupForExistsReferrer(this); subQuery.Invoke(cb);
            String subQueryPropertyName = keepPublisherId_ExistsSubQuery_BookList(cb.Query());
            registerExistsSubQuery(cb.Query(), "PUBLISHER_ID", "PUBLISHER_ID", subQueryPropertyName);
        }
        public abstract String keepPublisherId_ExistsSubQuery_BookList(LdBookCQ subQuery);
        public void NotExistsBookList(LdSubQuery<LdBookCB> subQuery) {
            assertObjectNotNull("subQuery<LdBookCB>", subQuery);
            LdBookCB cb = new LdBookCB(); cb.xsetupForExistsReferrer(this); subQuery.Invoke(cb);
            String subQueryPropertyName = keepPublisherId_NotExistsSubQuery_BookList(cb.Query());
            registerNotExistsSubQuery(cb.Query(), "PUBLISHER_ID", "PUBLISHER_ID", subQueryPropertyName);
        }
        public abstract String keepPublisherId_NotExistsSubQuery_BookList(LdBookCQ subQuery);
        public void InScopeBookList(LdSubQuery<LdBookCB> subQuery) {
            assertObjectNotNull("subQuery<LdBookCB>", subQuery);
            LdBookCB cb = new LdBookCB(); cb.xsetupForInScopeRelation(this); subQuery.Invoke(cb);
            String subQueryPropertyName = keepPublisherId_InScopeSubQuery_BookList(cb.Query());
            registerInScopeSubQuery(cb.Query(), "PUBLISHER_ID", "PUBLISHER_ID", subQueryPropertyName);
        }
        public abstract String keepPublisherId_InScopeSubQuery_BookList(LdBookCQ subQuery);
        public void NotInScopeBookList(LdSubQuery<LdBookCB> subQuery) {
            assertObjectNotNull("subQuery<LdBookCB>", subQuery);
            LdBookCB cb = new LdBookCB(); cb.xsetupForInScopeRelation(this); subQuery.Invoke(cb);
            String subQueryPropertyName = keepPublisherId_NotInScopeSubQuery_BookList(cb.Query());
            registerNotInScopeSubQuery(cb.Query(), "PUBLISHER_ID", "PUBLISHER_ID", subQueryPropertyName);
        }
        public abstract String keepPublisherId_NotInScopeSubQuery_BookList(LdBookCQ subQuery);
        public void xsderiveBookList(String function, LdSubQuery<LdBookCB> subQuery, String aliasName) {
            assertObjectNotNull("subQuery<LdBookCB>", subQuery);
            LdBookCB cb = new LdBookCB(); cb.xsetupForDerivedReferrer(this); subQuery.Invoke(cb);
            String subQueryPropertyName = keepPublisherId_SpecifyDerivedReferrer_BookList(cb.Query());
            registerSpecifyDerivedReferrer(function, cb.Query(), "PUBLISHER_ID", "PUBLISHER_ID", subQueryPropertyName, aliasName);
        }
        abstract public String keepPublisherId_SpecifyDerivedReferrer_BookList(LdBookCQ subQuery);

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
            String subQueryPropertyName = keepPublisherId_QueryDerivedReferrer_BookList(cb.Query()); // for saving query-value.
            String parameterPropertyName = keepPublisherId_QueryDerivedReferrer_BookListParameter(value);
            registerQueryDerivedReferrer(function, cb.Query(), "PUBLISHER_ID", "PUBLISHER_ID", subQueryPropertyName, operand, value, parameterPropertyName);
        }
        public abstract String keepPublisherId_QueryDerivedReferrer_BookList(LdBookCQ subQuery);
        public abstract String keepPublisherId_QueryDerivedReferrer_BookListParameter(Object parameterValue);
        public void SetPublisherId_IsNull() { regPublisherId(CK_ISN, DUMMY_OBJECT); }
        public void SetPublisherId_IsNotNull() { regPublisherId(CK_ISNN, DUMMY_OBJECT); }
        protected void regPublisherId(LdConditionKey k, Object v) { regQ(k, v, getCValuePublisherId(), "PUBLISHER_ID"); }
        protected abstract LdConditionValue getCValuePublisherId();

        public void SetPublisherName_Equal(String v) { DoSetPublisherName_Equal(fRES(v)); }
        protected void DoSetPublisherName_Equal(String v) { regPublisherName(CK_EQ, v); }
        public void SetPublisherName_NotEqual(String v) { DoSetPublisherName_NotEqual(fRES(v)); }
        protected void DoSetPublisherName_NotEqual(String v) { regPublisherName(CK_NES, v); }
        public void SetPublisherName_GreaterThan(String v) { regPublisherName(CK_GT, fRES(v)); }
        public void SetPublisherName_LessThan(String v) { regPublisherName(CK_LT, fRES(v)); }
        public void SetPublisherName_GreaterEqual(String v) { regPublisherName(CK_GE, fRES(v)); }
        public void SetPublisherName_LessEqual(String v) { regPublisherName(CK_LE, fRES(v)); }
        public void SetPublisherName_InScope(IList<String> ls) { regINS<String>(CK_INS, cTL<String>(ls), getCValuePublisherName(), "PUBLISHER_NAME"); }
        public void SetPublisherName_NotInScope(IList<String> ls) { regINS<String>(CK_NINS, cTL<String>(ls), getCValuePublisherName(), "PUBLISHER_NAME"); }
        public void SetPublisherName_PrefixSearch(String v) { SetPublisherName_LikeSearch(v, cLSOP()); }
        public void SetPublisherName_LikeSearch(String v, LdLikeSearchOption option)
        { regLSQ(CK_LS, fRES(v), getCValuePublisherName(), "PUBLISHER_NAME", option); }
        public void SetPublisherName_NotLikeSearch(String v, LdLikeSearchOption option)
        { regLSQ(CK_NLS, fRES(v), getCValuePublisherName(), "PUBLISHER_NAME", option); }
        protected void regPublisherName(LdConditionKey k, Object v) { regQ(k, v, getCValuePublisherName(), "PUBLISHER_NAME"); }
        protected abstract LdConditionValue getCValuePublisherName();

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
        public SSQFunction<LdPublisherCB> Scalar_Equal() {
            return xcreateSSQFunction("=");
        }

        public SSQFunction<LdPublisherCB> Scalar_NotEqual() {
            return xcreateSSQFunction("<>");
        }

        public SSQFunction<LdPublisherCB> Scalar_GreaterEqual() {
            return xcreateSSQFunction(">=");
        }

        public SSQFunction<LdPublisherCB> Scalar_GreaterThan() {
            return xcreateSSQFunction(">");
        }

        public SSQFunction<LdPublisherCB> Scalar_LessEqual() {
            return xcreateSSQFunction("<=");
        }

        public SSQFunction<LdPublisherCB> Scalar_LessThan() {
            return xcreateSSQFunction("<");
        }

        protected SSQFunction<LdPublisherCB> xcreateSSQFunction(String operand) {
            return new SSQFunction<LdPublisherCB>(delegate(String function, LdSubQuery<LdPublisherCB> subQuery) {
                xscalarSubQuery(function, subQuery, operand);
            });
        }

        protected void xscalarSubQuery(String function, LdSubQuery<LdPublisherCB> subQuery, String operand) {
            assertObjectNotNull("subQuery<LdPublisherCB>", subQuery);
            LdPublisherCB cb = new LdPublisherCB(); cb.xsetupForScalarCondition(this); subQuery.Invoke(cb);
            String subQueryPropertyName = keepScalarSubQuery(cb.Query()); // for saving query-value.
            registerScalarSubQuery(function, cb.Query(), subQueryPropertyName, operand);
        }
        public abstract String keepScalarSubQuery(LdPublisherCQ subQuery);

        // ===============================================================================
        //                                                                  MySelf InScope
        //                                                                  ==============
        public void MyselfInScope(LdSubQuery<LdPublisherCB> subQuery) {
            assertObjectNotNull("subQuery<LdPublisherCB>", subQuery);
            LdPublisherCB cb = new LdPublisherCB(); cb.xsetupForInScopeRelation(this); subQuery.Invoke(cb);
            String subQueryPropertyName = keepMyselfInScopeSubQuery(cb.Query()); // for saving query-value.
            registerInScopeSubQuery(cb.Query(), "PUBLISHER_ID", "PUBLISHER_ID", subQueryPropertyName);
        }
        public abstract String keepMyselfInScopeSubQuery(LdPublisherCQ subQuery);

        public override String ToString() { return xgetSqlClause().getClause(); }
    }
}
