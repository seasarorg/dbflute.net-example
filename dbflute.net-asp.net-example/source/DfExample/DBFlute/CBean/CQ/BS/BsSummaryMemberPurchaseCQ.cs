
using System;

using DfExample.DBFlute.AllCommon.CBean;
using DfExample.DBFlute.AllCommon.CBean.CValue;
using DfExample.DBFlute.AllCommon.CBean.SClause;
using DfExample.DBFlute.AllCommon.JavaLike;
using DfExample.DBFlute.CBean.CQ;
using DfExample.DBFlute.CBean.CQ.Ciq;

namespace DfExample.DBFlute.CBean.CQ.BS {

    [System.Serializable]
    public class BsSummaryMemberPurchaseCQ : AbstractBsSummaryMemberPurchaseCQ {

        protected SummaryMemberPurchaseCIQ _inlineQuery;

        public BsSummaryMemberPurchaseCQ(ConditionQuery childQuery, SqlClause sqlClause, String aliasName, int nestLevel)
            : base(childQuery, sqlClause, aliasName, nestLevel) {}

        public SummaryMemberPurchaseCIQ Inline() {
            if (_inlineQuery == null) {
                _inlineQuery = new SummaryMemberPurchaseCIQ(xgetReferrerQuery(), xgetSqlClause(), xgetAliasName(), xgetNestLevel(), this);
            }
            _inlineQuery.xsetOnClause(false);
            return _inlineQuery;
        }
        
        public SummaryMemberPurchaseCIQ On() {
            if (isBaseQuery()) { throw new UnsupportedOperationException("Unsupported onClause of Base Table!"); }
            SummaryMemberPurchaseCIQ inlineQuery = Inline();
            inlineQuery.xsetOnClause(true);
            return inlineQuery;
        }


        protected ConditionValue _memberId;
        public ConditionValue MemberId {
            get { if (_memberId == null) { _memberId = new ConditionValue(); } return _memberId; }
        }
        protected override ConditionValue getCValueMemberId() { return this.MemberId; }


        public BsSummaryMemberPurchaseCQ AddOrderBy_MemberId_Asc() { regOBA("MEMBER_ID");return this; }
        public BsSummaryMemberPurchaseCQ AddOrderBy_MemberId_Desc() { regOBD("MEMBER_ID");return this; }

        protected ConditionValue _allsumPurchasePrice;
        public ConditionValue AllsumPurchasePrice {
            get { if (_allsumPurchasePrice == null) { _allsumPurchasePrice = new ConditionValue(); } return _allsumPurchasePrice; }
        }
        protected override ConditionValue getCValueAllsumPurchasePrice() { return this.AllsumPurchasePrice; }


        public BsSummaryMemberPurchaseCQ AddOrderBy_AllsumPurchasePrice_Asc() { regOBA("ALLSUM_PURCHASE_PRICE");return this; }
        public BsSummaryMemberPurchaseCQ AddOrderBy_AllsumPurchasePrice_Desc() { regOBD("ALLSUM_PURCHASE_PRICE");return this; }

        protected ConditionValue _latestPurchaseDatetime;
        public ConditionValue LatestPurchaseDatetime {
            get { if (_latestPurchaseDatetime == null) { _latestPurchaseDatetime = new ConditionValue(); } return _latestPurchaseDatetime; }
        }
        protected override ConditionValue getCValueLatestPurchaseDatetime() { return this.LatestPurchaseDatetime; }


        public BsSummaryMemberPurchaseCQ AddOrderBy_LatestPurchaseDatetime_Asc() { regOBA("LATEST_PURCHASE_DATETIME");return this; }
        public BsSummaryMemberPurchaseCQ AddOrderBy_LatestPurchaseDatetime_Desc() { regOBD("LATEST_PURCHASE_DATETIME");return this; }

        public BsSummaryMemberPurchaseCQ AddSpecifiedDerivedOrderBy_Asc(String aliasName) { registerSpecifiedDerivedOrderBy_Asc(aliasName); return this; }
        public BsSummaryMemberPurchaseCQ AddSpecifiedDerivedOrderBy_Desc(String aliasName) { registerSpecifiedDerivedOrderBy_Desc(aliasName); return this; }

        public override void reflectRelationOnUnionQuery(ConditionQuery baseQueryAsSuper, ConditionQuery unionQueryAsSuper) {

        }
    

    }
}
