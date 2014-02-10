
using System;
using System.Collections.Generic;

using DfExample.DBFlute.MemberDb.AllCommon;
using DfExample.DBFlute.MemberDb.AllCommon.CBean;
using DfExample.DBFlute.MemberDb.AllCommon.CBean.CKey;
using DfExample.DBFlute.MemberDb.AllCommon.CBean.COption;
using DfExample.DBFlute.MemberDb.AllCommon.CBean.CValue;
using DfExample.DBFlute.MemberDb.AllCommon.CBean.SClause;

namespace DfExample.DBFlute.MemberDb.CBean.CQ.BS {

    [System.Serializable]
    public abstract class MbAbstractBsPurchaseCQ : MbAbstractConditionQuery {

        public MbAbstractBsPurchaseCQ(MbConditionQuery childQuery, MbSqlClause sqlClause, String aliasName, int nestLevel)
            : base(childQuery, sqlClause, aliasName, nestLevel) {}

        public override String getTableDbName() { return "purchase"; }
        public override String getTableSqlName() { return "purchase"; }

        public void SetPurchaseId_Equal(long? v) { regPurchaseId(CK_EQ, v); }
        public void SetPurchaseId_GreaterThan(long? v) { regPurchaseId(CK_GT, v); }
        public void SetPurchaseId_LessThan(long? v) { regPurchaseId(CK_LT, v); }
        public void SetPurchaseId_GreaterEqual(long? v) { regPurchaseId(CK_GE, v); }
        public void SetPurchaseId_LessEqual(long? v) { regPurchaseId(CK_LE, v); }
        public void SetPurchaseId_InScope(IList<long?> ls) { regINS<long?>(CK_INS, cTL<long?>(ls), getCValuePurchaseId(), "PURCHASE_ID"); }
        public void SetPurchaseId_NotInScope(IList<long?> ls) { regINS<long?>(CK_NINS, cTL<long?>(ls), getCValuePurchaseId(), "PURCHASE_ID"); }
        public void SetPurchaseId_IsNull() { regPurchaseId(CK_ISN, DUMMY_OBJECT); }
        public void SetPurchaseId_IsNotNull() { regPurchaseId(CK_ISNN, DUMMY_OBJECT); }
        protected void regPurchaseId(MbConditionKey k, Object v) { regQ(k, v, getCValuePurchaseId(), "PURCHASE_ID"); }
        protected abstract MbConditionValue getCValuePurchaseId();

        public void SetMemberId_Equal(int? v) { regMemberId(CK_EQ, v); }
        public void SetMemberId_GreaterThan(int? v) { regMemberId(CK_GT, v); }
        public void SetMemberId_LessThan(int? v) { regMemberId(CK_LT, v); }
        public void SetMemberId_GreaterEqual(int? v) { regMemberId(CK_GE, v); }
        public void SetMemberId_LessEqual(int? v) { regMemberId(CK_LE, v); }
        public void SetMemberId_InScope(IList<int?> ls) { regINS<int?>(CK_INS, cTL<int?>(ls), getCValueMemberId(), "MEMBER_ID"); }
        public void SetMemberId_NotInScope(IList<int?> ls) { regINS<int?>(CK_NINS, cTL<int?>(ls), getCValueMemberId(), "MEMBER_ID"); }
        public void InScopeMember(MbSubQuery<MbMemberCB> subQuery) {
            assertObjectNotNull("subQuery<MbMemberCB>", subQuery);
            MbMemberCB cb = new MbMemberCB(); cb.xsetupForInScopeRelation(this); subQuery.Invoke(cb);
            String subQueryPropertyName = keepMemberId_InScopeSubQuery_Member(cb.Query());
            registerInScopeSubQuery(cb.Query(), "MEMBER_ID", "MEMBER_ID", subQueryPropertyName);
        }
        public abstract String keepMemberId_InScopeSubQuery_Member(MbMemberCQ subQuery);
        public void NotInScopeMember(MbSubQuery<MbMemberCB> subQuery) {
            assertObjectNotNull("subQuery<MbMemberCB>", subQuery);
            MbMemberCB cb = new MbMemberCB(); cb.xsetupForInScopeRelation(this); subQuery.Invoke(cb);
            String subQueryPropertyName = keepMemberId_NotInScopeSubQuery_Member(cb.Query());
            registerNotInScopeSubQuery(cb.Query(), "MEMBER_ID", "MEMBER_ID", subQueryPropertyName);
        }
        public abstract String keepMemberId_NotInScopeSubQuery_Member(MbMemberCQ subQuery);
        protected void regMemberId(MbConditionKey k, Object v) { regQ(k, v, getCValueMemberId(), "MEMBER_ID"); }
        protected abstract MbConditionValue getCValueMemberId();

        public void SetProductId_Equal(int? v) { regProductId(CK_EQ, v); }
        public void SetProductId_GreaterThan(int? v) { regProductId(CK_GT, v); }
        public void SetProductId_LessThan(int? v) { regProductId(CK_LT, v); }
        public void SetProductId_GreaterEqual(int? v) { regProductId(CK_GE, v); }
        public void SetProductId_LessEqual(int? v) { regProductId(CK_LE, v); }
        public void SetProductId_InScope(IList<int?> ls) { regINS<int?>(CK_INS, cTL<int?>(ls), getCValueProductId(), "PRODUCT_ID"); }
        public void SetProductId_NotInScope(IList<int?> ls) { regINS<int?>(CK_NINS, cTL<int?>(ls), getCValueProductId(), "PRODUCT_ID"); }
        public void InScopeProduct(MbSubQuery<MbProductCB> subQuery) {
            assertObjectNotNull("subQuery<MbProductCB>", subQuery);
            MbProductCB cb = new MbProductCB(); cb.xsetupForInScopeRelation(this); subQuery.Invoke(cb);
            String subQueryPropertyName = keepProductId_InScopeSubQuery_Product(cb.Query());
            registerInScopeSubQuery(cb.Query(), "PRODUCT_ID", "PRODUCT_ID", subQueryPropertyName);
        }
        public abstract String keepProductId_InScopeSubQuery_Product(MbProductCQ subQuery);
        public void NotInScopeProduct(MbSubQuery<MbProductCB> subQuery) {
            assertObjectNotNull("subQuery<MbProductCB>", subQuery);
            MbProductCB cb = new MbProductCB(); cb.xsetupForInScopeRelation(this); subQuery.Invoke(cb);
            String subQueryPropertyName = keepProductId_NotInScopeSubQuery_Product(cb.Query());
            registerNotInScopeSubQuery(cb.Query(), "PRODUCT_ID", "PRODUCT_ID", subQueryPropertyName);
        }
        public abstract String keepProductId_NotInScopeSubQuery_Product(MbProductCQ subQuery);
        protected void regProductId(MbConditionKey k, Object v) { regQ(k, v, getCValueProductId(), "PRODUCT_ID"); }
        protected abstract MbConditionValue getCValueProductId();

        public void SetPurchaseDatetime_Equal(DateTime? v) { regPurchaseDatetime(CK_EQ, v); }
        public void SetPurchaseDatetime_GreaterThan(DateTime? v) { regPurchaseDatetime(CK_GT, v); }
        public void SetPurchaseDatetime_LessThan(DateTime? v) { regPurchaseDatetime(CK_LT, v); }
        public void SetPurchaseDatetime_GreaterEqual(DateTime? v) { regPurchaseDatetime(CK_GE, v); }
        public void SetPurchaseDatetime_LessEqual(DateTime? v) { regPurchaseDatetime(CK_LE, v); }
        public void SetPurchaseDatetime_FromTo(DateTime? from, DateTime? to, MbFromToOption option)
        { regFTQ(from, to, getCValuePurchaseDatetime(), "PURCHASE_DATETIME", option); }
        public void SetPurchaseDatetime_DateFromTo(DateTime? from, DateTime? to) { SetPurchaseDatetime_FromTo(from, to, new MbDateFromToOption()); }
        public void SetPurchaseDatetime_InScope(IList<DateTime?> ls) { regINS<DateTime?>(CK_INS, cTL<DateTime?>(ls), getCValuePurchaseDatetime(), "PURCHASE_DATETIME"); }
        public void SetPurchaseDatetime_NotInScope(IList<DateTime?> ls) { regINS<DateTime?>(CK_NINS, cTL<DateTime?>(ls), getCValuePurchaseDatetime(), "PURCHASE_DATETIME"); }
        protected void regPurchaseDatetime(MbConditionKey k, Object v) { regQ(k, v, getCValuePurchaseDatetime(), "PURCHASE_DATETIME"); }
        protected abstract MbConditionValue getCValuePurchaseDatetime();

        public void SetPurchaseCount_Equal(int? v) { regPurchaseCount(CK_EQ, v); }
        public void SetPurchaseCount_GreaterThan(int? v) { regPurchaseCount(CK_GT, v); }
        public void SetPurchaseCount_LessThan(int? v) { regPurchaseCount(CK_LT, v); }
        public void SetPurchaseCount_GreaterEqual(int? v) { regPurchaseCount(CK_GE, v); }
        public void SetPurchaseCount_LessEqual(int? v) { regPurchaseCount(CK_LE, v); }
        public void SetPurchaseCount_InScope(IList<int?> ls) { regINS<int?>(CK_INS, cTL<int?>(ls), getCValuePurchaseCount(), "PURCHASE_COUNT"); }
        public void SetPurchaseCount_NotInScope(IList<int?> ls) { regINS<int?>(CK_NINS, cTL<int?>(ls), getCValuePurchaseCount(), "PURCHASE_COUNT"); }
        protected void regPurchaseCount(MbConditionKey k, Object v) { regQ(k, v, getCValuePurchaseCount(), "PURCHASE_COUNT"); }
        protected abstract MbConditionValue getCValuePurchaseCount();

        public void SetPurchasePrice_Equal(int? v) { regPurchasePrice(CK_EQ, v); }
        public void SetPurchasePrice_GreaterThan(int? v) { regPurchasePrice(CK_GT, v); }
        public void SetPurchasePrice_LessThan(int? v) { regPurchasePrice(CK_LT, v); }
        public void SetPurchasePrice_GreaterEqual(int? v) { regPurchasePrice(CK_GE, v); }
        public void SetPurchasePrice_LessEqual(int? v) { regPurchasePrice(CK_LE, v); }
        public void SetPurchasePrice_InScope(IList<int?> ls) { regINS<int?>(CK_INS, cTL<int?>(ls), getCValuePurchasePrice(), "PURCHASE_PRICE"); }
        public void SetPurchasePrice_NotInScope(IList<int?> ls) { regINS<int?>(CK_NINS, cTL<int?>(ls), getCValuePurchasePrice(), "PURCHASE_PRICE"); }
        protected void regPurchasePrice(MbConditionKey k, Object v) { regQ(k, v, getCValuePurchasePrice(), "PURCHASE_PRICE"); }
        protected abstract MbConditionValue getCValuePurchasePrice();

        public void SetPaymentCompleteFlg_Equal(int? v) { regPaymentCompleteFlg(CK_EQ, v); }
        /// <summary>
        /// Set the value of True of paymentCompleteFlg as equal. { = }
        /// はい: 有効を示す
        /// </summary>
        public void SetPaymentCompleteFlg_Equal_True() {
            String code = MbCDef.Flg.True.Code;
            regPaymentCompleteFlg(CK_EQ, int.Parse(code));
        }
        /// <summary>
        /// Set the value of False of paymentCompleteFlg as equal. { = }
        /// いいえ: 無効を示す
        /// </summary>
        public void SetPaymentCompleteFlg_Equal_False() {
            String code = MbCDef.Flg.False.Code;
            regPaymentCompleteFlg(CK_EQ, int.Parse(code));
        }
        /// <summary>
        /// Set the value of True of paymentCompleteFlg as notEqual. { &lt;&gt; }
        /// はい: 有効を示す
        /// </summary>
        public void SetPaymentCompleteFlg_NotEqual_True() {
            String code = MbCDef.Flg.True.Code;
            regPaymentCompleteFlg(CK_NES, int.Parse(code));
        }
        /// <summary>
        /// Set the value of False of paymentCompleteFlg as notEqual. { &lt;&gt; }
        /// いいえ: 無効を示す
        /// </summary>
        public void SetPaymentCompleteFlg_NotEqual_False() {
            String code = MbCDef.Flg.False.Code;
            regPaymentCompleteFlg(CK_NES, int.Parse(code));
        }
        public void SetPaymentCompleteFlg_InScope(IList<int?> ls) { regINS<int?>(CK_INS, cTL<int?>(ls), getCValuePaymentCompleteFlg(), "PAYMENT_COMPLETE_FLG"); }
        public void SetPaymentCompleteFlg_NotInScope(IList<int?> ls) { regINS<int?>(CK_NINS, cTL<int?>(ls), getCValuePaymentCompleteFlg(), "PAYMENT_COMPLETE_FLG"); }
        protected void regPaymentCompleteFlg(MbConditionKey k, Object v) { regQ(k, v, getCValuePaymentCompleteFlg(), "PAYMENT_COMPLETE_FLG"); }
        protected abstract MbConditionValue getCValuePaymentCompleteFlg();

        public void SetRegisterDatetime_Equal(DateTime? v) { regRegisterDatetime(CK_EQ, v); }
        public void SetRegisterDatetime_GreaterThan(DateTime? v) { regRegisterDatetime(CK_GT, v); }
        public void SetRegisterDatetime_LessThan(DateTime? v) { regRegisterDatetime(CK_LT, v); }
        public void SetRegisterDatetime_GreaterEqual(DateTime? v) { regRegisterDatetime(CK_GE, v); }
        public void SetRegisterDatetime_LessEqual(DateTime? v) { regRegisterDatetime(CK_LE, v); }
        public void SetRegisterDatetime_FromTo(DateTime? from, DateTime? to, MbFromToOption option)
        { regFTQ(from, to, getCValueRegisterDatetime(), "REGISTER_DATETIME", option); }
        public void SetRegisterDatetime_DateFromTo(DateTime? from, DateTime? to) { SetRegisterDatetime_FromTo(from, to, new MbDateFromToOption()); }
        public void SetRegisterDatetime_InScope(IList<DateTime?> ls) { regINS<DateTime?>(CK_INS, cTL<DateTime?>(ls), getCValueRegisterDatetime(), "REGISTER_DATETIME"); }
        public void SetRegisterDatetime_NotInScope(IList<DateTime?> ls) { regINS<DateTime?>(CK_NINS, cTL<DateTime?>(ls), getCValueRegisterDatetime(), "REGISTER_DATETIME"); }
        protected void regRegisterDatetime(MbConditionKey k, Object v) { regQ(k, v, getCValueRegisterDatetime(), "REGISTER_DATETIME"); }
        protected abstract MbConditionValue getCValueRegisterDatetime();

        public void SetRegisterUser_Equal(String v) { DoSetRegisterUser_Equal(fRES(v)); }
        protected void DoSetRegisterUser_Equal(String v) { regRegisterUser(CK_EQ, v); }
        public void SetRegisterUser_NotEqual(String v) { DoSetRegisterUser_NotEqual(fRES(v)); }
        protected void DoSetRegisterUser_NotEqual(String v) { regRegisterUser(CK_NES, v); }
        public void SetRegisterUser_InScope(IList<String> ls) { regINS<String>(CK_INS, cTL<String>(ls), getCValueRegisterUser(), "REGISTER_USER"); }
        public void SetRegisterUser_NotInScope(IList<String> ls) { regINS<String>(CK_NINS, cTL<String>(ls), getCValueRegisterUser(), "REGISTER_USER"); }
        public void SetRegisterUser_PrefixSearch(String v) { SetRegisterUser_LikeSearch(v, cLSOP()); }
        public void SetRegisterUser_LikeSearch(String v, MbLikeSearchOption option)
        { regLSQ(CK_LS, fRES(v), getCValueRegisterUser(), "REGISTER_USER", option); }
        public void SetRegisterUser_NotLikeSearch(String v, MbLikeSearchOption option)
        { regLSQ(CK_NLS, fRES(v), getCValueRegisterUser(), "REGISTER_USER", option); }
        protected void regRegisterUser(MbConditionKey k, Object v) { regQ(k, v, getCValueRegisterUser(), "REGISTER_USER"); }
        protected abstract MbConditionValue getCValueRegisterUser();

        public void SetRegisterProcess_Equal(String v) { DoSetRegisterProcess_Equal(fRES(v)); }
        protected void DoSetRegisterProcess_Equal(String v) { regRegisterProcess(CK_EQ, v); }
        public void SetRegisterProcess_NotEqual(String v) { DoSetRegisterProcess_NotEqual(fRES(v)); }
        protected void DoSetRegisterProcess_NotEqual(String v) { regRegisterProcess(CK_NES, v); }
        public void SetRegisterProcess_InScope(IList<String> ls) { regINS<String>(CK_INS, cTL<String>(ls), getCValueRegisterProcess(), "REGISTER_PROCESS"); }
        public void SetRegisterProcess_NotInScope(IList<String> ls) { regINS<String>(CK_NINS, cTL<String>(ls), getCValueRegisterProcess(), "REGISTER_PROCESS"); }
        public void SetRegisterProcess_PrefixSearch(String v) { SetRegisterProcess_LikeSearch(v, cLSOP()); }
        public void SetRegisterProcess_LikeSearch(String v, MbLikeSearchOption option)
        { regLSQ(CK_LS, fRES(v), getCValueRegisterProcess(), "REGISTER_PROCESS", option); }
        public void SetRegisterProcess_NotLikeSearch(String v, MbLikeSearchOption option)
        { regLSQ(CK_NLS, fRES(v), getCValueRegisterProcess(), "REGISTER_PROCESS", option); }
        protected void regRegisterProcess(MbConditionKey k, Object v) { regQ(k, v, getCValueRegisterProcess(), "REGISTER_PROCESS"); }
        protected abstract MbConditionValue getCValueRegisterProcess();

        public void SetUpdateDatetime_Equal(DateTime? v) { regUpdateDatetime(CK_EQ, v); }
        public void SetUpdateDatetime_GreaterThan(DateTime? v) { regUpdateDatetime(CK_GT, v); }
        public void SetUpdateDatetime_LessThan(DateTime? v) { regUpdateDatetime(CK_LT, v); }
        public void SetUpdateDatetime_GreaterEqual(DateTime? v) { regUpdateDatetime(CK_GE, v); }
        public void SetUpdateDatetime_LessEqual(DateTime? v) { regUpdateDatetime(CK_LE, v); }
        public void SetUpdateDatetime_FromTo(DateTime? from, DateTime? to, MbFromToOption option)
        { regFTQ(from, to, getCValueUpdateDatetime(), "UPDATE_DATETIME", option); }
        public void SetUpdateDatetime_DateFromTo(DateTime? from, DateTime? to) { SetUpdateDatetime_FromTo(from, to, new MbDateFromToOption()); }
        public void SetUpdateDatetime_InScope(IList<DateTime?> ls) { regINS<DateTime?>(CK_INS, cTL<DateTime?>(ls), getCValueUpdateDatetime(), "UPDATE_DATETIME"); }
        public void SetUpdateDatetime_NotInScope(IList<DateTime?> ls) { regINS<DateTime?>(CK_NINS, cTL<DateTime?>(ls), getCValueUpdateDatetime(), "UPDATE_DATETIME"); }
        protected void regUpdateDatetime(MbConditionKey k, Object v) { regQ(k, v, getCValueUpdateDatetime(), "UPDATE_DATETIME"); }
        protected abstract MbConditionValue getCValueUpdateDatetime();

        public void SetUpdateUser_Equal(String v) { DoSetUpdateUser_Equal(fRES(v)); }
        protected void DoSetUpdateUser_Equal(String v) { regUpdateUser(CK_EQ, v); }
        public void SetUpdateUser_NotEqual(String v) { DoSetUpdateUser_NotEqual(fRES(v)); }
        protected void DoSetUpdateUser_NotEqual(String v) { regUpdateUser(CK_NES, v); }
        public void SetUpdateUser_InScope(IList<String> ls) { regINS<String>(CK_INS, cTL<String>(ls), getCValueUpdateUser(), "UPDATE_USER"); }
        public void SetUpdateUser_NotInScope(IList<String> ls) { regINS<String>(CK_NINS, cTL<String>(ls), getCValueUpdateUser(), "UPDATE_USER"); }
        public void SetUpdateUser_PrefixSearch(String v) { SetUpdateUser_LikeSearch(v, cLSOP()); }
        public void SetUpdateUser_LikeSearch(String v, MbLikeSearchOption option)
        { regLSQ(CK_LS, fRES(v), getCValueUpdateUser(), "UPDATE_USER", option); }
        public void SetUpdateUser_NotLikeSearch(String v, MbLikeSearchOption option)
        { regLSQ(CK_NLS, fRES(v), getCValueUpdateUser(), "UPDATE_USER", option); }
        protected void regUpdateUser(MbConditionKey k, Object v) { regQ(k, v, getCValueUpdateUser(), "UPDATE_USER"); }
        protected abstract MbConditionValue getCValueUpdateUser();

        public void SetUpdateProcess_Equal(String v) { DoSetUpdateProcess_Equal(fRES(v)); }
        protected void DoSetUpdateProcess_Equal(String v) { regUpdateProcess(CK_EQ, v); }
        public void SetUpdateProcess_NotEqual(String v) { DoSetUpdateProcess_NotEqual(fRES(v)); }
        protected void DoSetUpdateProcess_NotEqual(String v) { regUpdateProcess(CK_NES, v); }
        public void SetUpdateProcess_InScope(IList<String> ls) { regINS<String>(CK_INS, cTL<String>(ls), getCValueUpdateProcess(), "UPDATE_PROCESS"); }
        public void SetUpdateProcess_NotInScope(IList<String> ls) { regINS<String>(CK_NINS, cTL<String>(ls), getCValueUpdateProcess(), "UPDATE_PROCESS"); }
        public void SetUpdateProcess_PrefixSearch(String v) { SetUpdateProcess_LikeSearch(v, cLSOP()); }
        public void SetUpdateProcess_LikeSearch(String v, MbLikeSearchOption option)
        { regLSQ(CK_LS, fRES(v), getCValueUpdateProcess(), "UPDATE_PROCESS", option); }
        public void SetUpdateProcess_NotLikeSearch(String v, MbLikeSearchOption option)
        { regLSQ(CK_NLS, fRES(v), getCValueUpdateProcess(), "UPDATE_PROCESS", option); }
        protected void regUpdateProcess(MbConditionKey k, Object v) { regQ(k, v, getCValueUpdateProcess(), "UPDATE_PROCESS"); }
        protected abstract MbConditionValue getCValueUpdateProcess();

        public void SetVersionNo_Equal(long? v) { regVersionNo(CK_EQ, v); }
        public void SetVersionNo_GreaterThan(long? v) { regVersionNo(CK_GT, v); }
        public void SetVersionNo_LessThan(long? v) { regVersionNo(CK_LT, v); }
        public void SetVersionNo_GreaterEqual(long? v) { regVersionNo(CK_GE, v); }
        public void SetVersionNo_LessEqual(long? v) { regVersionNo(CK_LE, v); }
        public void SetVersionNo_InScope(IList<long?> ls) { regINS<long?>(CK_INS, cTL<long?>(ls), getCValueVersionNo(), "VERSION_NO"); }
        public void SetVersionNo_NotInScope(IList<long?> ls) { regINS<long?>(CK_NINS, cTL<long?>(ls), getCValueVersionNo(), "VERSION_NO"); }
        protected void regVersionNo(MbConditionKey k, Object v) { regQ(k, v, getCValueVersionNo(), "VERSION_NO"); }
        protected abstract MbConditionValue getCValueVersionNo();

        // ===================================================================================
        //                                                                    Scalar Condition
        //                                                                    ================
        public SSQFunction<MbPurchaseCB> Scalar_Equal() {
            return xcreateSSQFunction("=");
        }

        public SSQFunction<MbPurchaseCB> Scalar_NotEqual() {
            return xcreateSSQFunction("<>");
        }

        public SSQFunction<MbPurchaseCB> Scalar_GreaterEqual() {
            return xcreateSSQFunction(">=");
        }

        public SSQFunction<MbPurchaseCB> Scalar_GreaterThan() {
            return xcreateSSQFunction(">");
        }

        public SSQFunction<MbPurchaseCB> Scalar_LessEqual() {
            return xcreateSSQFunction("<=");
        }

        public SSQFunction<MbPurchaseCB> Scalar_LessThan() {
            return xcreateSSQFunction("<");
        }

        protected SSQFunction<MbPurchaseCB> xcreateSSQFunction(String operand) {
            return new SSQFunction<MbPurchaseCB>(delegate(String function, MbSubQuery<MbPurchaseCB> subQuery) {
                xscalarSubQuery(function, subQuery, operand);
            });
        }

        protected void xscalarSubQuery(String function, MbSubQuery<MbPurchaseCB> subQuery, String operand) {
            assertObjectNotNull("subQuery<MbPurchaseCB>", subQuery);
            MbPurchaseCB cb = new MbPurchaseCB(); cb.xsetupForScalarCondition(this); subQuery.Invoke(cb);
            String subQueryPropertyName = keepScalarSubQuery(cb.Query()); // for saving query-value.
            registerScalarSubQuery(function, cb.Query(), subQueryPropertyName, operand);
        }
        public abstract String keepScalarSubQuery(MbPurchaseCQ subQuery);

        // ===============================================================================
        //                                                                  MySelf InScope
        //                                                                  ==============
        public void MyselfInScope(MbSubQuery<MbPurchaseCB> subQuery) {
            assertObjectNotNull("subQuery<MbPurchaseCB>", subQuery);
            MbPurchaseCB cb = new MbPurchaseCB(); cb.xsetupForInScopeRelation(this); subQuery.Invoke(cb);
            String subQueryPropertyName = keepMyselfInScopeSubQuery(cb.Query()); // for saving query-value.
            registerInScopeSubQuery(cb.Query(), "PURCHASE_ID", "PURCHASE_ID", subQueryPropertyName);
        }
        public abstract String keepMyselfInScopeSubQuery(MbPurchaseCQ subQuery);

        public override String ToString() { return xgetSqlClause().getClause(); }
    }
}
