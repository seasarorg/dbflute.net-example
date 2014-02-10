
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
    public abstract class LdAbstractBsCollectionStatusLookupCQ : LdAbstractConditionQuery {

        public LdAbstractBsCollectionStatusLookupCQ(LdConditionQuery childQuery, LdSqlClause sqlClause, String aliasName, int nestLevel)
            : base(childQuery, sqlClause, aliasName, nestLevel) {}

        public override String getTableDbName() { return "collection_status_lookup"; }
        public override String getTableSqlName() { return "collection_status_lookup"; }

        public void SetCollectionStatusCode_Equal(String v) { DoSetCollectionStatusCode_Equal(fRES(v)); }
        /// <summary>
        /// Set the value of NOR of collectionStatusCode as equal. { = }
        /// NOR: 通常状態を示す
        /// </summary>
        public void SetCollectionStatusCode_Equal_NOR() {
            DoSetCollectionStatusCode_Equal(LdCDef.CollectionStatus.NOR.Code);
        }
        /// <summary>
        /// Set the value of WAT of collectionStatusCode as equal. { = }
        /// WAT: 待ち状態を示す
        /// </summary>
        public void SetCollectionStatusCode_Equal_WAT() {
            DoSetCollectionStatusCode_Equal(LdCDef.CollectionStatus.WAT.Code);
        }
        /// <summary>
        /// Set the value of OUT of collectionStatusCode as equal. { = }
        /// OUT: 貸し出し中を示す
        /// </summary>
        public void SetCollectionStatusCode_Equal_OUT() {
            DoSetCollectionStatusCode_Equal(LdCDef.CollectionStatus.OUT.Code);
        }
        protected void DoSetCollectionStatusCode_Equal(String v) { regCollectionStatusCode(CK_EQ, v); }
        public void SetCollectionStatusCode_NotEqual(String v) { DoSetCollectionStatusCode_NotEqual(fRES(v)); }
        /// <summary>
        /// Set the value of NOR of collectionStatusCode as notEqual. { &lt;&gt; }
        /// NOR: 通常状態を示す
        /// </summary>
        public void SetCollectionStatusCode_NotEqual_NOR() {
            DoSetCollectionStatusCode_NotEqual(LdCDef.CollectionStatus.NOR.Code);
        }
        /// <summary>
        /// Set the value of WAT of collectionStatusCode as notEqual. { &lt;&gt; }
        /// WAT: 待ち状態を示す
        /// </summary>
        public void SetCollectionStatusCode_NotEqual_WAT() {
            DoSetCollectionStatusCode_NotEqual(LdCDef.CollectionStatus.WAT.Code);
        }
        /// <summary>
        /// Set the value of OUT of collectionStatusCode as notEqual. { &lt;&gt; }
        /// OUT: 貸し出し中を示す
        /// </summary>
        public void SetCollectionStatusCode_NotEqual_OUT() {
            DoSetCollectionStatusCode_NotEqual(LdCDef.CollectionStatus.OUT.Code);
        }
        protected void DoSetCollectionStatusCode_NotEqual(String v) { regCollectionStatusCode(CK_NES, v); }
        public void SetCollectionStatusCode_InScope(IList<String> ls) { regINS<String>(CK_INS, cTL<String>(ls), getCValueCollectionStatusCode(), "COLLECTION_STATUS_CODE"); }
        public void SetCollectionStatusCode_NotInScope(IList<String> ls) { regINS<String>(CK_NINS, cTL<String>(ls), getCValueCollectionStatusCode(), "COLLECTION_STATUS_CODE"); }
        public void ExistsCollectionStatusList(LdSubQuery<LdCollectionStatusCB> subQuery) {
            assertObjectNotNull("subQuery<LdCollectionStatusCB>", subQuery);
            LdCollectionStatusCB cb = new LdCollectionStatusCB(); cb.xsetupForExistsReferrer(this); subQuery.Invoke(cb);
            String subQueryPropertyName = keepCollectionStatusCode_ExistsSubQuery_CollectionStatusList(cb.Query());
            registerExistsSubQuery(cb.Query(), "COLLECTION_STATUS_CODE", "COLLECTION_STATUS_CODE", subQueryPropertyName);
        }
        public abstract String keepCollectionStatusCode_ExistsSubQuery_CollectionStatusList(LdCollectionStatusCQ subQuery);
        public void NotExistsCollectionStatusList(LdSubQuery<LdCollectionStatusCB> subQuery) {
            assertObjectNotNull("subQuery<LdCollectionStatusCB>", subQuery);
            LdCollectionStatusCB cb = new LdCollectionStatusCB(); cb.xsetupForExistsReferrer(this); subQuery.Invoke(cb);
            String subQueryPropertyName = keepCollectionStatusCode_NotExistsSubQuery_CollectionStatusList(cb.Query());
            registerNotExistsSubQuery(cb.Query(), "COLLECTION_STATUS_CODE", "COLLECTION_STATUS_CODE", subQueryPropertyName);
        }
        public abstract String keepCollectionStatusCode_NotExistsSubQuery_CollectionStatusList(LdCollectionStatusCQ subQuery);
        public void InScopeCollectionStatusList(LdSubQuery<LdCollectionStatusCB> subQuery) {
            assertObjectNotNull("subQuery<LdCollectionStatusCB>", subQuery);
            LdCollectionStatusCB cb = new LdCollectionStatusCB(); cb.xsetupForInScopeRelation(this); subQuery.Invoke(cb);
            String subQueryPropertyName = keepCollectionStatusCode_InScopeSubQuery_CollectionStatusList(cb.Query());
            registerInScopeSubQuery(cb.Query(), "COLLECTION_STATUS_CODE", "COLLECTION_STATUS_CODE", subQueryPropertyName);
        }
        public abstract String keepCollectionStatusCode_InScopeSubQuery_CollectionStatusList(LdCollectionStatusCQ subQuery);
        public void NotInScopeCollectionStatusList(LdSubQuery<LdCollectionStatusCB> subQuery) {
            assertObjectNotNull("subQuery<LdCollectionStatusCB>", subQuery);
            LdCollectionStatusCB cb = new LdCollectionStatusCB(); cb.xsetupForInScopeRelation(this); subQuery.Invoke(cb);
            String subQueryPropertyName = keepCollectionStatusCode_NotInScopeSubQuery_CollectionStatusList(cb.Query());
            registerNotInScopeSubQuery(cb.Query(), "COLLECTION_STATUS_CODE", "COLLECTION_STATUS_CODE", subQueryPropertyName);
        }
        public abstract String keepCollectionStatusCode_NotInScopeSubQuery_CollectionStatusList(LdCollectionStatusCQ subQuery);
        public void xsderiveCollectionStatusList(String function, LdSubQuery<LdCollectionStatusCB> subQuery, String aliasName) {
            assertObjectNotNull("subQuery<LdCollectionStatusCB>", subQuery);
            LdCollectionStatusCB cb = new LdCollectionStatusCB(); cb.xsetupForDerivedReferrer(this); subQuery.Invoke(cb);
            String subQueryPropertyName = keepCollectionStatusCode_SpecifyDerivedReferrer_CollectionStatusList(cb.Query());
            registerSpecifyDerivedReferrer(function, cb.Query(), "COLLECTION_STATUS_CODE", "COLLECTION_STATUS_CODE", subQueryPropertyName, aliasName);
        }
        abstract public String keepCollectionStatusCode_SpecifyDerivedReferrer_CollectionStatusList(LdCollectionStatusCQ subQuery);

        public QDRFunction<LdCollectionStatusCB> DerivedCollectionStatusList() {
            return xcreateQDRFunctionCollectionStatusList();
        }
        protected QDRFunction<LdCollectionStatusCB> xcreateQDRFunctionCollectionStatusList() {
            return new QDRFunction<LdCollectionStatusCB>(delegate(String function, LdSubQuery<LdCollectionStatusCB> subQuery, String operand, Object value) {
                xqderiveCollectionStatusList(function, subQuery, operand, value);
            });
        }
        public void xqderiveCollectionStatusList(String function, LdSubQuery<LdCollectionStatusCB> subQuery, String operand, Object value) {
            assertObjectNotNull("subQuery<LdCollectionStatusCB>", subQuery);
            LdCollectionStatusCB cb = new LdCollectionStatusCB(); cb.xsetupForDerivedReferrer(this); subQuery.Invoke(cb);
            String subQueryPropertyName = keepCollectionStatusCode_QueryDerivedReferrer_CollectionStatusList(cb.Query()); // for saving query-value.
            String parameterPropertyName = keepCollectionStatusCode_QueryDerivedReferrer_CollectionStatusListParameter(value);
            registerQueryDerivedReferrer(function, cb.Query(), "COLLECTION_STATUS_CODE", "COLLECTION_STATUS_CODE", subQueryPropertyName, operand, value, parameterPropertyName);
        }
        public abstract String keepCollectionStatusCode_QueryDerivedReferrer_CollectionStatusList(LdCollectionStatusCQ subQuery);
        public abstract String keepCollectionStatusCode_QueryDerivedReferrer_CollectionStatusListParameter(Object parameterValue);
        public void SetCollectionStatusCode_IsNull() { regCollectionStatusCode(CK_ISN, DUMMY_OBJECT); }
        public void SetCollectionStatusCode_IsNotNull() { regCollectionStatusCode(CK_ISNN, DUMMY_OBJECT); }
        protected void regCollectionStatusCode(LdConditionKey k, Object v) { regQ(k, v, getCValueCollectionStatusCode(), "COLLECTION_STATUS_CODE"); }
        protected abstract LdConditionValue getCValueCollectionStatusCode();

        public void SetCollectionStatusName_Equal(String v) { DoSetCollectionStatusName_Equal(fRES(v)); }
        protected void DoSetCollectionStatusName_Equal(String v) { regCollectionStatusName(CK_EQ, v); }
        public void SetCollectionStatusName_NotEqual(String v) { DoSetCollectionStatusName_NotEqual(fRES(v)); }
        protected void DoSetCollectionStatusName_NotEqual(String v) { regCollectionStatusName(CK_NES, v); }
        public void SetCollectionStatusName_GreaterThan(String v) { regCollectionStatusName(CK_GT, fRES(v)); }
        public void SetCollectionStatusName_LessThan(String v) { regCollectionStatusName(CK_LT, fRES(v)); }
        public void SetCollectionStatusName_GreaterEqual(String v) { regCollectionStatusName(CK_GE, fRES(v)); }
        public void SetCollectionStatusName_LessEqual(String v) { regCollectionStatusName(CK_LE, fRES(v)); }
        public void SetCollectionStatusName_InScope(IList<String> ls) { regINS<String>(CK_INS, cTL<String>(ls), getCValueCollectionStatusName(), "COLLECTION_STATUS_NAME"); }
        public void SetCollectionStatusName_NotInScope(IList<String> ls) { regINS<String>(CK_NINS, cTL<String>(ls), getCValueCollectionStatusName(), "COLLECTION_STATUS_NAME"); }
        public void SetCollectionStatusName_PrefixSearch(String v) { SetCollectionStatusName_LikeSearch(v, cLSOP()); }
        public void SetCollectionStatusName_LikeSearch(String v, LdLikeSearchOption option)
        { regLSQ(CK_LS, fRES(v), getCValueCollectionStatusName(), "COLLECTION_STATUS_NAME", option); }
        public void SetCollectionStatusName_NotLikeSearch(String v, LdLikeSearchOption option)
        { regLSQ(CK_NLS, fRES(v), getCValueCollectionStatusName(), "COLLECTION_STATUS_NAME", option); }
        protected void regCollectionStatusName(LdConditionKey k, Object v) { regQ(k, v, getCValueCollectionStatusName(), "COLLECTION_STATUS_NAME"); }
        protected abstract LdConditionValue getCValueCollectionStatusName();

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
        public SSQFunction<LdCollectionStatusLookupCB> Scalar_Equal() {
            return xcreateSSQFunction("=");
        }

        public SSQFunction<LdCollectionStatusLookupCB> Scalar_NotEqual() {
            return xcreateSSQFunction("<>");
        }

        public SSQFunction<LdCollectionStatusLookupCB> Scalar_GreaterEqual() {
            return xcreateSSQFunction(">=");
        }

        public SSQFunction<LdCollectionStatusLookupCB> Scalar_GreaterThan() {
            return xcreateSSQFunction(">");
        }

        public SSQFunction<LdCollectionStatusLookupCB> Scalar_LessEqual() {
            return xcreateSSQFunction("<=");
        }

        public SSQFunction<LdCollectionStatusLookupCB> Scalar_LessThan() {
            return xcreateSSQFunction("<");
        }

        protected SSQFunction<LdCollectionStatusLookupCB> xcreateSSQFunction(String operand) {
            return new SSQFunction<LdCollectionStatusLookupCB>(delegate(String function, LdSubQuery<LdCollectionStatusLookupCB> subQuery) {
                xscalarSubQuery(function, subQuery, operand);
            });
        }

        protected void xscalarSubQuery(String function, LdSubQuery<LdCollectionStatusLookupCB> subQuery, String operand) {
            assertObjectNotNull("subQuery<LdCollectionStatusLookupCB>", subQuery);
            LdCollectionStatusLookupCB cb = new LdCollectionStatusLookupCB(); cb.xsetupForScalarCondition(this); subQuery.Invoke(cb);
            String subQueryPropertyName = keepScalarSubQuery(cb.Query()); // for saving query-value.
            registerScalarSubQuery(function, cb.Query(), subQueryPropertyName, operand);
        }
        public abstract String keepScalarSubQuery(LdCollectionStatusLookupCQ subQuery);

        // ===============================================================================
        //                                                                  MySelf InScope
        //                                                                  ==============
        public void MyselfInScope(LdSubQuery<LdCollectionStatusLookupCB> subQuery) {
            assertObjectNotNull("subQuery<LdCollectionStatusLookupCB>", subQuery);
            LdCollectionStatusLookupCB cb = new LdCollectionStatusLookupCB(); cb.xsetupForInScopeRelation(this); subQuery.Invoke(cb);
            String subQueryPropertyName = keepMyselfInScopeSubQuery(cb.Query()); // for saving query-value.
            registerInScopeSubQuery(cb.Query(), "COLLECTION_STATUS_CODE", "COLLECTION_STATUS_CODE", subQueryPropertyName);
        }
        public abstract String keepMyselfInScopeSubQuery(LdCollectionStatusLookupCQ subQuery);

        public override String ToString() { return xgetSqlClause().getClause(); }
    }
}
