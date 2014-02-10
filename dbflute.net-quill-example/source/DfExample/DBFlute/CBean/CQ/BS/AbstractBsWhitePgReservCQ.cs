
using System;
using System.Collections.Generic;

using DfExample.DBFlute.AllCommon;
using DfExample.DBFlute.AllCommon.CBean;
using DfExample.DBFlute.AllCommon.CBean.CKey;
using DfExample.DBFlute.AllCommon.CBean.COption;
using DfExample.DBFlute.AllCommon.CBean.CValue;
using DfExample.DBFlute.AllCommon.CBean.SClause;

namespace DfExample.DBFlute.CBean.CQ.BS {

    [System.Serializable]
    public abstract class AbstractBsWhitePgReservCQ : AbstractConditionQuery {

        public AbstractBsWhitePgReservCQ(ConditionQuery childQuery, SqlClause sqlClause, String aliasName, int nestLevel)
            : base(childQuery, sqlClause, aliasName, nestLevel) {}

        public override String getTableDbName() { return "white_pg_reserv"; }
        public override String getTableSqlName() { return "white_pg_reserv"; }

        public void SetClassSynonym_Equal(int? v) { regClassSynonym(CK_EQ, v); }
        public void SetClassSynonym_NotEqual(int? v) { regClassSynonym(CK_NES, v); }
        public void SetClassSynonym_GreaterThan(int? v) { regClassSynonym(CK_GT, v); }
        public void SetClassSynonym_LessThan(int? v) { regClassSynonym(CK_LT, v); }
        public void SetClassSynonym_GreaterEqual(int? v) { regClassSynonym(CK_GE, v); }
        public void SetClassSynonym_LessEqual(int? v) { regClassSynonym(CK_LE, v); }
        public void SetClassSynonym_InScope(IList<int?> ls) { regINS<int?>(CK_INS, cTL<int?>(ls), getCValueClassSynonym(), "CLASS"); }
        public void SetClassSynonym_NotInScope(IList<int?> ls) { regINS<int?>(CK_NINS, cTL<int?>(ls), getCValueClassSynonym(), "CLASS"); }
        public void ExistsWhitePgReservRefList(SubQuery<WhitePgReservRefCB> subQuery) {
            assertObjectNotNull("subQuery<WhitePgReservRefCB>", subQuery);
            WhitePgReservRefCB cb = new WhitePgReservRefCB(); cb.xsetupForExistsReferrer(this); subQuery.Invoke(cb);
            String subQueryPropertyName = keepClassSynonym_ExistsSubQuery_WhitePgReservRefList(cb.Query());
            registerExistsSubQuery(cb.Query(), "CLASS", "CLASS", subQueryPropertyName);
        }
        public abstract String keepClassSynonym_ExistsSubQuery_WhitePgReservRefList(WhitePgReservRefCQ subQuery);
        public void NotExistsWhitePgReservRefList(SubQuery<WhitePgReservRefCB> subQuery) {
            assertObjectNotNull("subQuery<WhitePgReservRefCB>", subQuery);
            WhitePgReservRefCB cb = new WhitePgReservRefCB(); cb.xsetupForExistsReferrer(this); subQuery.Invoke(cb);
            String subQueryPropertyName = keepClassSynonym_NotExistsSubQuery_WhitePgReservRefList(cb.Query());
            registerNotExistsSubQuery(cb.Query(), "CLASS", "CLASS", subQueryPropertyName);
        }
        public abstract String keepClassSynonym_NotExistsSubQuery_WhitePgReservRefList(WhitePgReservRefCQ subQuery);
        public void InScopeWhitePgReservRefList(SubQuery<WhitePgReservRefCB> subQuery) {
            assertObjectNotNull("subQuery<WhitePgReservRefCB>", subQuery);
            WhitePgReservRefCB cb = new WhitePgReservRefCB(); cb.xsetupForInScopeRelation(this); subQuery.Invoke(cb);
            String subQueryPropertyName = keepClassSynonym_InScopeSubQuery_WhitePgReservRefList(cb.Query());
            registerInScopeSubQuery(cb.Query(), "CLASS", "CLASS", subQueryPropertyName);
        }
        public abstract String keepClassSynonym_InScopeSubQuery_WhitePgReservRefList(WhitePgReservRefCQ subQuery);
        public void NotInScopeWhitePgReservRefList(SubQuery<WhitePgReservRefCB> subQuery) {
            assertObjectNotNull("subQuery<WhitePgReservRefCB>", subQuery);
            WhitePgReservRefCB cb = new WhitePgReservRefCB(); cb.xsetupForInScopeRelation(this); subQuery.Invoke(cb);
            String subQueryPropertyName = keepClassSynonym_NotInScopeSubQuery_WhitePgReservRefList(cb.Query());
            registerNotInScopeSubQuery(cb.Query(), "CLASS", "CLASS", subQueryPropertyName);
        }
        public abstract String keepClassSynonym_NotInScopeSubQuery_WhitePgReservRefList(WhitePgReservRefCQ subQuery);
        public void xsderiveWhitePgReservRefList(String function, SubQuery<WhitePgReservRefCB> subQuery, String aliasName) {
            assertObjectNotNull("subQuery<WhitePgReservRefCB>", subQuery);
            WhitePgReservRefCB cb = new WhitePgReservRefCB(); cb.xsetupForDerivedReferrer(this); subQuery.Invoke(cb);
            String subQueryPropertyName = keepClassSynonym_SpecifyDerivedReferrer_WhitePgReservRefList(cb.Query());
            registerSpecifyDerivedReferrer(function, cb.Query(), "CLASS", "CLASS", subQueryPropertyName, aliasName);
        }
        abstract public String keepClassSynonym_SpecifyDerivedReferrer_WhitePgReservRefList(WhitePgReservRefCQ subQuery);

        public QDRFunction<WhitePgReservRefCB> DerivedWhitePgReservRefList() {
            return xcreateQDRFunctionWhitePgReservRefList();
        }
        protected QDRFunction<WhitePgReservRefCB> xcreateQDRFunctionWhitePgReservRefList() {
            return new QDRFunction<WhitePgReservRefCB>(delegate(String function, SubQuery<WhitePgReservRefCB> subQuery, String operand, Object value) {
                xqderiveWhitePgReservRefList(function, subQuery, operand, value);
            });
        }
        public void xqderiveWhitePgReservRefList(String function, SubQuery<WhitePgReservRefCB> subQuery, String operand, Object value) {
            assertObjectNotNull("subQuery<WhitePgReservRefCB>", subQuery);
            WhitePgReservRefCB cb = new WhitePgReservRefCB(); cb.xsetupForDerivedReferrer(this); subQuery.Invoke(cb);
            String subQueryPropertyName = keepClassSynonym_QueryDerivedReferrer_WhitePgReservRefList(cb.Query()); // for saving query-value.
            String parameterPropertyName = keepClassSynonym_QueryDerivedReferrer_WhitePgReservRefListParameter(value);
            registerQueryDerivedReferrer(function, cb.Query(), "CLASS", "CLASS", subQueryPropertyName, operand, value, parameterPropertyName);
        }
        public abstract String keepClassSynonym_QueryDerivedReferrer_WhitePgReservRefList(WhitePgReservRefCQ subQuery);
        public abstract String keepClassSynonym_QueryDerivedReferrer_WhitePgReservRefListParameter(Object parameterValue);
        public void SetClassSynonym_IsNull() { regClassSynonym(CK_ISN, DUMMY_OBJECT); }
        public void SetClassSynonym_IsNotNull() { regClassSynonym(CK_ISNN, DUMMY_OBJECT); }
        protected void regClassSynonym(ConditionKey k, Object v) { regQ(k, v, getCValueClassSynonym(), "CLASS"); }
        protected abstract ConditionValue getCValueClassSynonym();

        public void SetCase_Equal(int? v) { regCase(CK_EQ, v); }
        public void SetCase_NotEqual(int? v) { regCase(CK_NES, v); }
        public void SetCase_GreaterThan(int? v) { regCase(CK_GT, v); }
        public void SetCase_LessThan(int? v) { regCase(CK_LT, v); }
        public void SetCase_GreaterEqual(int? v) { regCase(CK_GE, v); }
        public void SetCase_LessEqual(int? v) { regCase(CK_LE, v); }
        public void SetCase_InScope(IList<int?> ls) { regINS<int?>(CK_INS, cTL<int?>(ls), getCValueCase(), "CASE"); }
        public void SetCase_NotInScope(IList<int?> ls) { regINS<int?>(CK_NINS, cTL<int?>(ls), getCValueCase(), "CASE"); }
        public void SetCase_IsNull() { regCase(CK_ISN, DUMMY_OBJECT); }
        public void SetCase_IsNotNull() { regCase(CK_ISNN, DUMMY_OBJECT); }
        protected void regCase(ConditionKey k, Object v) { regQ(k, v, getCValueCase(), "CASE"); }
        protected abstract ConditionValue getCValueCase();

        public void SetPackage_Equal(int? v) { regPackage(CK_EQ, v); }
        public void SetPackage_NotEqual(int? v) { regPackage(CK_NES, v); }
        public void SetPackage_GreaterThan(int? v) { regPackage(CK_GT, v); }
        public void SetPackage_LessThan(int? v) { regPackage(CK_LT, v); }
        public void SetPackage_GreaterEqual(int? v) { regPackage(CK_GE, v); }
        public void SetPackage_LessEqual(int? v) { regPackage(CK_LE, v); }
        public void SetPackage_InScope(IList<int?> ls) { regINS<int?>(CK_INS, cTL<int?>(ls), getCValuePackage(), "PACKAGE"); }
        public void SetPackage_NotInScope(IList<int?> ls) { regINS<int?>(CK_NINS, cTL<int?>(ls), getCValuePackage(), "PACKAGE"); }
        public void SetPackage_IsNull() { regPackage(CK_ISN, DUMMY_OBJECT); }
        public void SetPackage_IsNotNull() { regPackage(CK_ISNN, DUMMY_OBJECT); }
        protected void regPackage(ConditionKey k, Object v) { regQ(k, v, getCValuePackage(), "PACKAGE"); }
        protected abstract ConditionValue getCValuePackage();

        public void SetDefault_Equal(int? v) { regDefault(CK_EQ, v); }
        public void SetDefault_NotEqual(int? v) { regDefault(CK_NES, v); }
        public void SetDefault_GreaterThan(int? v) { regDefault(CK_GT, v); }
        public void SetDefault_LessThan(int? v) { regDefault(CK_LT, v); }
        public void SetDefault_GreaterEqual(int? v) { regDefault(CK_GE, v); }
        public void SetDefault_LessEqual(int? v) { regDefault(CK_LE, v); }
        public void SetDefault_InScope(IList<int?> ls) { regINS<int?>(CK_INS, cTL<int?>(ls), getCValueDefault(), "DEFAULT"); }
        public void SetDefault_NotInScope(IList<int?> ls) { regINS<int?>(CK_NINS, cTL<int?>(ls), getCValueDefault(), "DEFAULT"); }
        public void SetDefault_IsNull() { regDefault(CK_ISN, DUMMY_OBJECT); }
        public void SetDefault_IsNotNull() { regDefault(CK_ISNN, DUMMY_OBJECT); }
        protected void regDefault(ConditionKey k, Object v) { regQ(k, v, getCValueDefault(), "DEFAULT"); }
        protected abstract ConditionValue getCValueDefault();

        public void SetNew_Equal(int? v) { regNew(CK_EQ, v); }
        public void SetNew_NotEqual(int? v) { regNew(CK_NES, v); }
        public void SetNew_GreaterThan(int? v) { regNew(CK_GT, v); }
        public void SetNew_LessThan(int? v) { regNew(CK_LT, v); }
        public void SetNew_GreaterEqual(int? v) { regNew(CK_GE, v); }
        public void SetNew_LessEqual(int? v) { regNew(CK_LE, v); }
        public void SetNew_InScope(IList<int?> ls) { regINS<int?>(CK_INS, cTL<int?>(ls), getCValueNew(), "NEW"); }
        public void SetNew_NotInScope(IList<int?> ls) { regINS<int?>(CK_NINS, cTL<int?>(ls), getCValueNew(), "NEW"); }
        public void SetNew_IsNull() { regNew(CK_ISN, DUMMY_OBJECT); }
        public void SetNew_IsNotNull() { regNew(CK_ISNN, DUMMY_OBJECT); }
        protected void regNew(ConditionKey k, Object v) { regQ(k, v, getCValueNew(), "NEW"); }
        protected abstract ConditionValue getCValueNew();

        public void SetNative_Equal(int? v) { regNative(CK_EQ, v); }
        public void SetNative_NotEqual(int? v) { regNative(CK_NES, v); }
        public void SetNative_GreaterThan(int? v) { regNative(CK_GT, v); }
        public void SetNative_LessThan(int? v) { regNative(CK_LT, v); }
        public void SetNative_GreaterEqual(int? v) { regNative(CK_GE, v); }
        public void SetNative_LessEqual(int? v) { regNative(CK_LE, v); }
        public void SetNative_InScope(IList<int?> ls) { regINS<int?>(CK_INS, cTL<int?>(ls), getCValueNative(), "NATIVE"); }
        public void SetNative_NotInScope(IList<int?> ls) { regINS<int?>(CK_NINS, cTL<int?>(ls), getCValueNative(), "NATIVE"); }
        public void SetNative_IsNull() { regNative(CK_ISN, DUMMY_OBJECT); }
        public void SetNative_IsNotNull() { regNative(CK_ISNN, DUMMY_OBJECT); }
        protected void regNative(ConditionKey k, Object v) { regQ(k, v, getCValueNative(), "NATIVE"); }
        protected abstract ConditionValue getCValueNative();

        public void SetVoid_Equal(int? v) { regVoid(CK_EQ, v); }
        public void SetVoid_NotEqual(int? v) { regVoid(CK_NES, v); }
        public void SetVoid_GreaterThan(int? v) { regVoid(CK_GT, v); }
        public void SetVoid_LessThan(int? v) { regVoid(CK_LT, v); }
        public void SetVoid_GreaterEqual(int? v) { regVoid(CK_GE, v); }
        public void SetVoid_LessEqual(int? v) { regVoid(CK_LE, v); }
        public void SetVoid_InScope(IList<int?> ls) { regINS<int?>(CK_INS, cTL<int?>(ls), getCValueVoid(), "VOID"); }
        public void SetVoid_NotInScope(IList<int?> ls) { regINS<int?>(CK_NINS, cTL<int?>(ls), getCValueVoid(), "VOID"); }
        public void SetVoid_IsNull() { regVoid(CK_ISN, DUMMY_OBJECT); }
        public void SetVoid_IsNotNull() { regVoid(CK_ISNN, DUMMY_OBJECT); }
        protected void regVoid(ConditionKey k, Object v) { regQ(k, v, getCValueVoid(), "VOID"); }
        protected abstract ConditionValue getCValueVoid();

        public void SetPublic_Equal(int? v) { regPublic(CK_EQ, v); }
        public void SetPublic_NotEqual(int? v) { regPublic(CK_NES, v); }
        public void SetPublic_GreaterThan(int? v) { regPublic(CK_GT, v); }
        public void SetPublic_LessThan(int? v) { regPublic(CK_LT, v); }
        public void SetPublic_GreaterEqual(int? v) { regPublic(CK_GE, v); }
        public void SetPublic_LessEqual(int? v) { regPublic(CK_LE, v); }
        public void SetPublic_InScope(IList<int?> ls) { regINS<int?>(CK_INS, cTL<int?>(ls), getCValuePublic(), "PUBLIC"); }
        public void SetPublic_NotInScope(IList<int?> ls) { regINS<int?>(CK_NINS, cTL<int?>(ls), getCValuePublic(), "PUBLIC"); }
        public void SetPublic_IsNull() { regPublic(CK_ISN, DUMMY_OBJECT); }
        public void SetPublic_IsNotNull() { regPublic(CK_ISNN, DUMMY_OBJECT); }
        protected void regPublic(ConditionKey k, Object v) { regQ(k, v, getCValuePublic(), "PUBLIC"); }
        protected abstract ConditionValue getCValuePublic();

        public void SetProtected_Equal(int? v) { regProtected(CK_EQ, v); }
        public void SetProtected_NotEqual(int? v) { regProtected(CK_NES, v); }
        public void SetProtected_GreaterThan(int? v) { regProtected(CK_GT, v); }
        public void SetProtected_LessThan(int? v) { regProtected(CK_LT, v); }
        public void SetProtected_GreaterEqual(int? v) { regProtected(CK_GE, v); }
        public void SetProtected_LessEqual(int? v) { regProtected(CK_LE, v); }
        public void SetProtected_InScope(IList<int?> ls) { regINS<int?>(CK_INS, cTL<int?>(ls), getCValueProtected(), "PROTECTED"); }
        public void SetProtected_NotInScope(IList<int?> ls) { regINS<int?>(CK_NINS, cTL<int?>(ls), getCValueProtected(), "PROTECTED"); }
        public void SetProtected_IsNull() { regProtected(CK_ISN, DUMMY_OBJECT); }
        public void SetProtected_IsNotNull() { regProtected(CK_ISNN, DUMMY_OBJECT); }
        protected void regProtected(ConditionKey k, Object v) { regQ(k, v, getCValueProtected(), "PROTECTED"); }
        protected abstract ConditionValue getCValueProtected();

        public void SetPrivate_Equal(int? v) { regPrivate(CK_EQ, v); }
        public void SetPrivate_NotEqual(int? v) { regPrivate(CK_NES, v); }
        public void SetPrivate_GreaterThan(int? v) { regPrivate(CK_GT, v); }
        public void SetPrivate_LessThan(int? v) { regPrivate(CK_LT, v); }
        public void SetPrivate_GreaterEqual(int? v) { regPrivate(CK_GE, v); }
        public void SetPrivate_LessEqual(int? v) { regPrivate(CK_LE, v); }
        public void SetPrivate_InScope(IList<int?> ls) { regINS<int?>(CK_INS, cTL<int?>(ls), getCValuePrivate(), "PRIVATE"); }
        public void SetPrivate_NotInScope(IList<int?> ls) { regINS<int?>(CK_NINS, cTL<int?>(ls), getCValuePrivate(), "PRIVATE"); }
        public void SetPrivate_IsNull() { regPrivate(CK_ISN, DUMMY_OBJECT); }
        public void SetPrivate_IsNotNull() { regPrivate(CK_ISNN, DUMMY_OBJECT); }
        protected void regPrivate(ConditionKey k, Object v) { regQ(k, v, getCValuePrivate(), "PRIVATE"); }
        protected abstract ConditionValue getCValuePrivate();

        public void SetInterface_Equal(int? v) { regInterface(CK_EQ, v); }
        public void SetInterface_NotEqual(int? v) { regInterface(CK_NES, v); }
        public void SetInterface_GreaterThan(int? v) { regInterface(CK_GT, v); }
        public void SetInterface_LessThan(int? v) { regInterface(CK_LT, v); }
        public void SetInterface_GreaterEqual(int? v) { regInterface(CK_GE, v); }
        public void SetInterface_LessEqual(int? v) { regInterface(CK_LE, v); }
        public void SetInterface_InScope(IList<int?> ls) { regINS<int?>(CK_INS, cTL<int?>(ls), getCValueInterface(), "INTERFACE"); }
        public void SetInterface_NotInScope(IList<int?> ls) { regINS<int?>(CK_NINS, cTL<int?>(ls), getCValueInterface(), "INTERFACE"); }
        public void SetInterface_IsNull() { regInterface(CK_ISN, DUMMY_OBJECT); }
        public void SetInterface_IsNotNull() { regInterface(CK_ISNN, DUMMY_OBJECT); }
        protected void regInterface(ConditionKey k, Object v) { regQ(k, v, getCValueInterface(), "INTERFACE"); }
        protected abstract ConditionValue getCValueInterface();

        public void SetAbstract_Equal(int? v) { regAbstract(CK_EQ, v); }
        public void SetAbstract_NotEqual(int? v) { regAbstract(CK_NES, v); }
        public void SetAbstract_GreaterThan(int? v) { regAbstract(CK_GT, v); }
        public void SetAbstract_LessThan(int? v) { regAbstract(CK_LT, v); }
        public void SetAbstract_GreaterEqual(int? v) { regAbstract(CK_GE, v); }
        public void SetAbstract_LessEqual(int? v) { regAbstract(CK_LE, v); }
        public void SetAbstract_InScope(IList<int?> ls) { regINS<int?>(CK_INS, cTL<int?>(ls), getCValueAbstract(), "ABSTRACT"); }
        public void SetAbstract_NotInScope(IList<int?> ls) { regINS<int?>(CK_NINS, cTL<int?>(ls), getCValueAbstract(), "ABSTRACT"); }
        public void SetAbstract_IsNull() { regAbstract(CK_ISN, DUMMY_OBJECT); }
        public void SetAbstract_IsNotNull() { regAbstract(CK_ISNN, DUMMY_OBJECT); }
        protected void regAbstract(ConditionKey k, Object v) { regQ(k, v, getCValueAbstract(), "ABSTRACT"); }
        protected abstract ConditionValue getCValueAbstract();

        public void SetFinal_Equal(int? v) { regFinal(CK_EQ, v); }
        public void SetFinal_NotEqual(int? v) { regFinal(CK_NES, v); }
        public void SetFinal_GreaterThan(int? v) { regFinal(CK_GT, v); }
        public void SetFinal_LessThan(int? v) { regFinal(CK_LT, v); }
        public void SetFinal_GreaterEqual(int? v) { regFinal(CK_GE, v); }
        public void SetFinal_LessEqual(int? v) { regFinal(CK_LE, v); }
        public void SetFinal_InScope(IList<int?> ls) { regINS<int?>(CK_INS, cTL<int?>(ls), getCValueFinal(), "FINAL"); }
        public void SetFinal_NotInScope(IList<int?> ls) { regINS<int?>(CK_NINS, cTL<int?>(ls), getCValueFinal(), "FINAL"); }
        public void SetFinal_IsNull() { regFinal(CK_ISN, DUMMY_OBJECT); }
        public void SetFinal_IsNotNull() { regFinal(CK_ISNN, DUMMY_OBJECT); }
        protected void regFinal(ConditionKey k, Object v) { regQ(k, v, getCValueFinal(), "FINAL"); }
        protected abstract ConditionValue getCValueFinal();

        public void SetFinally_Equal(int? v) { regFinally(CK_EQ, v); }
        public void SetFinally_NotEqual(int? v) { regFinally(CK_NES, v); }
        public void SetFinally_GreaterThan(int? v) { regFinally(CK_GT, v); }
        public void SetFinally_LessThan(int? v) { regFinally(CK_LT, v); }
        public void SetFinally_GreaterEqual(int? v) { regFinally(CK_GE, v); }
        public void SetFinally_LessEqual(int? v) { regFinally(CK_LE, v); }
        public void SetFinally_InScope(IList<int?> ls) { regINS<int?>(CK_INS, cTL<int?>(ls), getCValueFinally(), "FINALLY"); }
        public void SetFinally_NotInScope(IList<int?> ls) { regINS<int?>(CK_NINS, cTL<int?>(ls), getCValueFinally(), "FINALLY"); }
        public void SetFinally_IsNull() { regFinally(CK_ISN, DUMMY_OBJECT); }
        public void SetFinally_IsNotNull() { regFinally(CK_ISNN, DUMMY_OBJECT); }
        protected void regFinally(ConditionKey k, Object v) { regQ(k, v, getCValueFinally(), "FINALLY"); }
        protected abstract ConditionValue getCValueFinally();

        public void SetReturn_Equal(int? v) { regReturn(CK_EQ, v); }
        public void SetReturn_NotEqual(int? v) { regReturn(CK_NES, v); }
        public void SetReturn_GreaterThan(int? v) { regReturn(CK_GT, v); }
        public void SetReturn_LessThan(int? v) { regReturn(CK_LT, v); }
        public void SetReturn_GreaterEqual(int? v) { regReturn(CK_GE, v); }
        public void SetReturn_LessEqual(int? v) { regReturn(CK_LE, v); }
        public void SetReturn_InScope(IList<int?> ls) { regINS<int?>(CK_INS, cTL<int?>(ls), getCValueReturn(), "RETURN"); }
        public void SetReturn_NotInScope(IList<int?> ls) { regINS<int?>(CK_NINS, cTL<int?>(ls), getCValueReturn(), "RETURN"); }
        public void SetReturn_IsNull() { regReturn(CK_ISN, DUMMY_OBJECT); }
        public void SetReturn_IsNotNull() { regReturn(CK_ISNN, DUMMY_OBJECT); }
        protected void regReturn(ConditionKey k, Object v) { regQ(k, v, getCValueReturn(), "RETURN"); }
        protected abstract ConditionValue getCValueReturn();

        public void SetDouble_Equal(int? v) { regDouble(CK_EQ, v); }
        public void SetDouble_NotEqual(int? v) { regDouble(CK_NES, v); }
        public void SetDouble_GreaterThan(int? v) { regDouble(CK_GT, v); }
        public void SetDouble_LessThan(int? v) { regDouble(CK_LT, v); }
        public void SetDouble_GreaterEqual(int? v) { regDouble(CK_GE, v); }
        public void SetDouble_LessEqual(int? v) { regDouble(CK_LE, v); }
        public void SetDouble_InScope(IList<int?> ls) { regINS<int?>(CK_INS, cTL<int?>(ls), getCValueDouble(), "DOUBLE"); }
        public void SetDouble_NotInScope(IList<int?> ls) { regINS<int?>(CK_NINS, cTL<int?>(ls), getCValueDouble(), "DOUBLE"); }
        public void SetDouble_IsNull() { regDouble(CK_ISN, DUMMY_OBJECT); }
        public void SetDouble_IsNotNull() { regDouble(CK_ISNN, DUMMY_OBJECT); }
        protected void regDouble(ConditionKey k, Object v) { regQ(k, v, getCValueDouble(), "DOUBLE"); }
        protected abstract ConditionValue getCValueDouble();

        public void SetFloat_Equal(int? v) { regFloat(CK_EQ, v); }
        public void SetFloat_NotEqual(int? v) { regFloat(CK_NES, v); }
        public void SetFloat_GreaterThan(int? v) { regFloat(CK_GT, v); }
        public void SetFloat_LessThan(int? v) { regFloat(CK_LT, v); }
        public void SetFloat_GreaterEqual(int? v) { regFloat(CK_GE, v); }
        public void SetFloat_LessEqual(int? v) { regFloat(CK_LE, v); }
        public void SetFloat_InScope(IList<int?> ls) { regINS<int?>(CK_INS, cTL<int?>(ls), getCValueFloat(), "FLOAT"); }
        public void SetFloat_NotInScope(IList<int?> ls) { regINS<int?>(CK_NINS, cTL<int?>(ls), getCValueFloat(), "FLOAT"); }
        public void SetFloat_IsNull() { regFloat(CK_ISN, DUMMY_OBJECT); }
        public void SetFloat_IsNotNull() { regFloat(CK_ISNN, DUMMY_OBJECT); }
        protected void regFloat(ConditionKey k, Object v) { regQ(k, v, getCValueFloat(), "FLOAT"); }
        protected abstract ConditionValue getCValueFloat();

        public void SetShort_Equal(int? v) { regShort(CK_EQ, v); }
        public void SetShort_NotEqual(int? v) { regShort(CK_NES, v); }
        public void SetShort_GreaterThan(int? v) { regShort(CK_GT, v); }
        public void SetShort_LessThan(int? v) { regShort(CK_LT, v); }
        public void SetShort_GreaterEqual(int? v) { regShort(CK_GE, v); }
        public void SetShort_LessEqual(int? v) { regShort(CK_LE, v); }
        public void SetShort_InScope(IList<int?> ls) { regINS<int?>(CK_INS, cTL<int?>(ls), getCValueShort(), "SHORT"); }
        public void SetShort_NotInScope(IList<int?> ls) { regINS<int?>(CK_NINS, cTL<int?>(ls), getCValueShort(), "SHORT"); }
        public void SetShort_IsNull() { regShort(CK_ISN, DUMMY_OBJECT); }
        public void SetShort_IsNotNull() { regShort(CK_ISNN, DUMMY_OBJECT); }
        protected void regShort(ConditionKey k, Object v) { regQ(k, v, getCValueShort(), "SHORT"); }
        protected abstract ConditionValue getCValueShort();

        public void SetType_Equal(String v) { DoSetType_Equal(fRES(v)); }
        protected void DoSetType_Equal(String v) { regType(CK_EQ, v); }
        public void SetType_NotEqual(String v) { DoSetType_NotEqual(fRES(v)); }
        protected void DoSetType_NotEqual(String v) { regType(CK_NES, v); }
        public void SetType_InScope(IList<String> ls) { regINS<String>(CK_INS, cTL<String>(ls), getCValueType(), "TYPE"); }
        public void SetType_NotInScope(IList<String> ls) { regINS<String>(CK_NINS, cTL<String>(ls), getCValueType(), "TYPE"); }
        public void SetType_PrefixSearch(String v) { SetType_LikeSearch(v, cLSOP()); }
        public void SetType_LikeSearch(String v, LikeSearchOption option)
        { regLSQ(CK_LS, fRES(v), getCValueType(), "TYPE", option); }
        public void SetType_NotLikeSearch(String v, LikeSearchOption option)
        { regLSQ(CK_NLS, fRES(v), getCValueType(), "TYPE", option); }
        public void SetType_IsNull() { regType(CK_ISN, DUMMY_OBJECT); }
        public void SetType_IsNotNull() { regType(CK_ISNN, DUMMY_OBJECT); }
        protected void regType(ConditionKey k, Object v) { regQ(k, v, getCValueType(), "TYPE"); }
        protected abstract ConditionValue getCValueType();

        public void SetReservName_Equal(String v) { DoSetReservName_Equal(fRES(v)); }
        protected void DoSetReservName_Equal(String v) { regReservName(CK_EQ, v); }
        public void SetReservName_NotEqual(String v) { DoSetReservName_NotEqual(fRES(v)); }
        protected void DoSetReservName_NotEqual(String v) { regReservName(CK_NES, v); }
        public void SetReservName_InScope(IList<String> ls) { regINS<String>(CK_INS, cTL<String>(ls), getCValueReservName(), "RESERV_NAME"); }
        public void SetReservName_NotInScope(IList<String> ls) { regINS<String>(CK_NINS, cTL<String>(ls), getCValueReservName(), "RESERV_NAME"); }
        public void SetReservName_PrefixSearch(String v) { SetReservName_LikeSearch(v, cLSOP()); }
        public void SetReservName_LikeSearch(String v, LikeSearchOption option)
        { regLSQ(CK_LS, fRES(v), getCValueReservName(), "RESERV_NAME", option); }
        public void SetReservName_NotLikeSearch(String v, LikeSearchOption option)
        { regLSQ(CK_NLS, fRES(v), getCValueReservName(), "RESERV_NAME", option); }
        protected void regReservName(ConditionKey k, Object v) { regQ(k, v, getCValueReservName(), "RESERV_NAME"); }
        protected abstract ConditionValue getCValueReservName();

        // ===================================================================================
        //                                                                    Scalar Condition
        //                                                                    ================
        public SSQFunction<WhitePgReservCB> Scalar_Equal() {
            return xcreateSSQFunction("=");
        }

        public SSQFunction<WhitePgReservCB> Scalar_NotEqual() {
            return xcreateSSQFunction("<>");
        }

        public SSQFunction<WhitePgReservCB> Scalar_GreaterEqual() {
            return xcreateSSQFunction(">=");
        }

        public SSQFunction<WhitePgReservCB> Scalar_GreaterThan() {
            return xcreateSSQFunction(">");
        }

        public SSQFunction<WhitePgReservCB> Scalar_LessEqual() {
            return xcreateSSQFunction("<=");
        }

        public SSQFunction<WhitePgReservCB> Scalar_LessThan() {
            return xcreateSSQFunction("<");
        }

        protected SSQFunction<WhitePgReservCB> xcreateSSQFunction(String operand) {
            return new SSQFunction<WhitePgReservCB>(delegate(String function, SubQuery<WhitePgReservCB> subQuery) {
                xscalarSubQuery(function, subQuery, operand);
            });
        }

        protected void xscalarSubQuery(String function, SubQuery<WhitePgReservCB> subQuery, String operand) {
            assertObjectNotNull("subQuery<WhitePgReservCB>", subQuery);
            WhitePgReservCB cb = new WhitePgReservCB(); cb.xsetupForScalarCondition(this); subQuery.Invoke(cb);
            String subQueryPropertyName = keepScalarSubQuery(cb.Query()); // for saving query-value.
            registerScalarSubQuery(function, cb.Query(), subQueryPropertyName, operand);
        }
        public abstract String keepScalarSubQuery(WhitePgReservCQ subQuery);

        // ===============================================================================
        //                                                                  MySelf InScope
        //                                                                  ==============
        public void MyselfInScope(SubQuery<WhitePgReservCB> subQuery) {
            assertObjectNotNull("subQuery<WhitePgReservCB>", subQuery);
            WhitePgReservCB cb = new WhitePgReservCB(); cb.xsetupForInScopeRelation(this); subQuery.Invoke(cb);
            String subQueryPropertyName = keepMyselfInScopeSubQuery(cb.Query()); // for saving query-value.
            registerInScopeSubQuery(cb.Query(), "CLASS", "CLASS", subQueryPropertyName);
        }
        public abstract String keepMyselfInScopeSubQuery(WhitePgReservCQ subQuery);

        public override String ToString() { return xgetSqlClause().getClause(); }
    }
}
