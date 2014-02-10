
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
    public abstract class AbstractBsSummaryMemberPurchaseCQ : AbstractConditionQuery {

        public AbstractBsSummaryMemberPurchaseCQ(ConditionQuery childQuery, SqlClause sqlClause, String aliasName, int nestLevel)
            : base(childQuery, sqlClause, aliasName, nestLevel) {}

        public override String getTableDbName() { return "SUMMARY_MEMBER_PURCHASE"; }
        public override String getTableSqlName() { return "SUMMARY_MEMBER_PURCHASE"; }

        public void SetMemberId_Equal(long? v) { regMemberId(CK_EQ, v); }
        public void SetMemberId_GreaterThan(long? v) { regMemberId(CK_GT, v); }
        public void SetMemberId_LessThan(long? v) { regMemberId(CK_LT, v); }
        public void SetMemberId_GreaterEqual(long? v) { regMemberId(CK_GE, v); }
        public void SetMemberId_LessEqual(long? v) { regMemberId(CK_LE, v); }
        public void SetMemberId_InScope(IList<long?> ls) { regINS<long?>(CK_INS, cTL<long?>(ls), getCValueMemberId(), "MEMBER_ID"); }
        public void SetMemberId_NotInScope(IList<long?> ls) { regINS<long?>(CK_NINS, cTL<long?>(ls), getCValueMemberId(), "MEMBER_ID"); }
        protected void regMemberId(ConditionKey k, Object v) { regQ(k, v, getCValueMemberId(), "MEMBER_ID"); }
        protected abstract ConditionValue getCValueMemberId();

        public void SetAllsumPurchasePrice_Equal(decimal? v) { regAllsumPurchasePrice(CK_EQ, v); }
        public void SetAllsumPurchasePrice_GreaterThan(decimal? v) { regAllsumPurchasePrice(CK_GT, v); }
        public void SetAllsumPurchasePrice_LessThan(decimal? v) { regAllsumPurchasePrice(CK_LT, v); }
        public void SetAllsumPurchasePrice_GreaterEqual(decimal? v) { regAllsumPurchasePrice(CK_GE, v); }
        public void SetAllsumPurchasePrice_LessEqual(decimal? v) { regAllsumPurchasePrice(CK_LE, v); }
        public void SetAllsumPurchasePrice_InScope(IList<decimal?> ls) { regINS<decimal?>(CK_INS, cTL<decimal?>(ls), getCValueAllsumPurchasePrice(), "ALLSUM_PURCHASE_PRICE"); }
        public void SetAllsumPurchasePrice_NotInScope(IList<decimal?> ls) { regINS<decimal?>(CK_NINS, cTL<decimal?>(ls), getCValueAllsumPurchasePrice(), "ALLSUM_PURCHASE_PRICE"); }
        public void SetAllsumPurchasePrice_IsNull() { regAllsumPurchasePrice(CK_ISN, DUMMY_OBJECT); }
        public void SetAllsumPurchasePrice_IsNotNull() { regAllsumPurchasePrice(CK_ISNN, DUMMY_OBJECT); }
        protected void regAllsumPurchasePrice(ConditionKey k, Object v) { regQ(k, v, getCValueAllsumPurchasePrice(), "ALLSUM_PURCHASE_PRICE"); }
        protected abstract ConditionValue getCValueAllsumPurchasePrice();

        public void SetLatestPurchaseDatetime_Equal(DateTime? v) { regLatestPurchaseDatetime(CK_EQ, v); }
        public void SetLatestPurchaseDatetime_GreaterThan(DateTime? v) { regLatestPurchaseDatetime(CK_GT, v); }
        public void SetLatestPurchaseDatetime_LessThan(DateTime? v) { regLatestPurchaseDatetime(CK_LT, v); }
        public void SetLatestPurchaseDatetime_GreaterEqual(DateTime? v) { regLatestPurchaseDatetime(CK_GE, v); }
        public void SetLatestPurchaseDatetime_LessEqual(DateTime? v) { regLatestPurchaseDatetime(CK_LE, v); }
        public void SetLatestPurchaseDatetime_FromTo(DateTime? from, DateTime? to, FromToOption option)
        { regFTQ(from, to, getCValueLatestPurchaseDatetime(), "LATEST_PURCHASE_DATETIME", option); }
        public void SetLatestPurchaseDatetime_DateFromTo(DateTime? from, DateTime? to) { SetLatestPurchaseDatetime_FromTo(from, to, new DateFromToOption()); }
        public void SetLatestPurchaseDatetime_InScope(IList<DateTime?> ls) { regINS<DateTime?>(CK_INS, cTL<DateTime?>(ls), getCValueLatestPurchaseDatetime(), "LATEST_PURCHASE_DATETIME"); }
        public void SetLatestPurchaseDatetime_NotInScope(IList<DateTime?> ls) { regINS<DateTime?>(CK_NINS, cTL<DateTime?>(ls), getCValueLatestPurchaseDatetime(), "LATEST_PURCHASE_DATETIME"); }
        public void SetLatestPurchaseDatetime_IsNull() { regLatestPurchaseDatetime(CK_ISN, DUMMY_OBJECT); }
        public void SetLatestPurchaseDatetime_IsNotNull() { regLatestPurchaseDatetime(CK_ISNN, DUMMY_OBJECT); }
        protected void regLatestPurchaseDatetime(ConditionKey k, Object v) { regQ(k, v, getCValueLatestPurchaseDatetime(), "LATEST_PURCHASE_DATETIME"); }
        protected abstract ConditionValue getCValueLatestPurchaseDatetime();

        public override String ToString() { return xgetSqlClause().getClause(); }
    }
}
