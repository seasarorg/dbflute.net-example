
using System;

using DfExample.DBFlute.AllCommon.CBean;
using DfExample.DBFlute.AllCommon.CBean.CValue;
using DfExample.DBFlute.AllCommon.CBean.SClause;
using DfExample.DBFlute.AllCommon.JavaLike;
using DfExample.DBFlute.CBean.CQ;
using DfExample.DBFlute.CBean.CQ.Ciq;

namespace DfExample.DBFlute.CBean.CQ.BS {

    [System.Serializable]
    public class BsWithdrawalReasonCQ : AbstractBsWithdrawalReasonCQ {

        protected WithdrawalReasonCIQ _inlineQuery;

        public BsWithdrawalReasonCQ(ConditionQuery childQuery, SqlClause sqlClause, String aliasName, int nestLevel)
            : base(childQuery, sqlClause, aliasName, nestLevel) {}

        public WithdrawalReasonCIQ Inline() {
            if (_inlineQuery == null) {
                _inlineQuery = new WithdrawalReasonCIQ(xgetReferrerQuery(), xgetSqlClause(), xgetAliasName(), xgetNestLevel(), this);
            }
            _inlineQuery.xsetOnClause(false);
            return _inlineQuery;
        }
        
        public WithdrawalReasonCIQ On() {
            if (isBaseQuery()) { throw new UnsupportedOperationException("Unsupported onClause of Base Table!"); }
            WithdrawalReasonCIQ inlineQuery = Inline();
            inlineQuery.xsetOnClause(true);
            return inlineQuery;
        }


        protected ConditionValue _withdrawalReasonCode;
        public ConditionValue WithdrawalReasonCode {
            get { if (_withdrawalReasonCode == null) { _withdrawalReasonCode = new ConditionValue(); } return _withdrawalReasonCode; }
        }
        protected override ConditionValue getCValueWithdrawalReasonCode() { return this.WithdrawalReasonCode; }


        protected Map<String, MemberWithdrawalCQ> _withdrawalReasonCode_ExistsSubQuery_MemberWithdrawalListMap;
        public Map<String, MemberWithdrawalCQ> WithdrawalReasonCode_ExistsSubQuery_MemberWithdrawalList { get { return _withdrawalReasonCode_ExistsSubQuery_MemberWithdrawalListMap; }}
        public override String keepWithdrawalReasonCode_ExistsSubQuery_MemberWithdrawalList(MemberWithdrawalCQ subQuery) {
            if (_withdrawalReasonCode_ExistsSubQuery_MemberWithdrawalListMap == null) { _withdrawalReasonCode_ExistsSubQuery_MemberWithdrawalListMap = new LinkedHashMap<String, MemberWithdrawalCQ>(); }
            String key = "subQueryMapKey" + (_withdrawalReasonCode_ExistsSubQuery_MemberWithdrawalListMap.size() + 1);
            _withdrawalReasonCode_ExistsSubQuery_MemberWithdrawalListMap.put(key, subQuery); return "WithdrawalReasonCode_ExistsSubQuery_MemberWithdrawalList." + key;
        }

        protected Map<String, MemberWithdrawalCQ> _withdrawalReasonCode_NotExistsSubQuery_MemberWithdrawalListMap;
        public Map<String, MemberWithdrawalCQ> WithdrawalReasonCode_NotExistsSubQuery_MemberWithdrawalList { get { return _withdrawalReasonCode_NotExistsSubQuery_MemberWithdrawalListMap; }}
        public override String keepWithdrawalReasonCode_NotExistsSubQuery_MemberWithdrawalList(MemberWithdrawalCQ subQuery) {
            if (_withdrawalReasonCode_NotExistsSubQuery_MemberWithdrawalListMap == null) { _withdrawalReasonCode_NotExistsSubQuery_MemberWithdrawalListMap = new LinkedHashMap<String, MemberWithdrawalCQ>(); }
            String key = "subQueryMapKey" + (_withdrawalReasonCode_NotExistsSubQuery_MemberWithdrawalListMap.size() + 1);
            _withdrawalReasonCode_NotExistsSubQuery_MemberWithdrawalListMap.put(key, subQuery); return "WithdrawalReasonCode_NotExistsSubQuery_MemberWithdrawalList." + key;
        }

        protected Map<String, MemberWithdrawalCQ> _withdrawalReasonCode_InScopeSubQuery_MemberWithdrawalListMap;
        public Map<String, MemberWithdrawalCQ> WithdrawalReasonCode_InScopeSubQuery_MemberWithdrawalList { get { return _withdrawalReasonCode_InScopeSubQuery_MemberWithdrawalListMap; }}
        public override String keepWithdrawalReasonCode_InScopeSubQuery_MemberWithdrawalList(MemberWithdrawalCQ subQuery) {
            if (_withdrawalReasonCode_InScopeSubQuery_MemberWithdrawalListMap == null) { _withdrawalReasonCode_InScopeSubQuery_MemberWithdrawalListMap = new LinkedHashMap<String, MemberWithdrawalCQ>(); }
            String key = "subQueryMapKey" + (_withdrawalReasonCode_InScopeSubQuery_MemberWithdrawalListMap.size() + 1);
            _withdrawalReasonCode_InScopeSubQuery_MemberWithdrawalListMap.put(key, subQuery); return "WithdrawalReasonCode_InScopeSubQuery_MemberWithdrawalList." + key;
        }

        protected Map<String, MemberWithdrawalCQ> _withdrawalReasonCode_NotInScopeSubQuery_MemberWithdrawalListMap;
        public Map<String, MemberWithdrawalCQ> WithdrawalReasonCode_NotInScopeSubQuery_MemberWithdrawalList { get { return _withdrawalReasonCode_NotInScopeSubQuery_MemberWithdrawalListMap; }}
        public override String keepWithdrawalReasonCode_NotInScopeSubQuery_MemberWithdrawalList(MemberWithdrawalCQ subQuery) {
            if (_withdrawalReasonCode_NotInScopeSubQuery_MemberWithdrawalListMap == null) { _withdrawalReasonCode_NotInScopeSubQuery_MemberWithdrawalListMap = new LinkedHashMap<String, MemberWithdrawalCQ>(); }
            String key = "subQueryMapKey" + (_withdrawalReasonCode_NotInScopeSubQuery_MemberWithdrawalListMap.size() + 1);
            _withdrawalReasonCode_NotInScopeSubQuery_MemberWithdrawalListMap.put(key, subQuery); return "WithdrawalReasonCode_NotInScopeSubQuery_MemberWithdrawalList." + key;
        }

        protected Map<String, MemberWithdrawalCQ> _withdrawalReasonCode_SpecifyDerivedReferrer_MemberWithdrawalListMap;
        public Map<String, MemberWithdrawalCQ> WithdrawalReasonCode_SpecifyDerivedReferrer_MemberWithdrawalList { get { return _withdrawalReasonCode_SpecifyDerivedReferrer_MemberWithdrawalListMap; }}
        public override String keepWithdrawalReasonCode_SpecifyDerivedReferrer_MemberWithdrawalList(MemberWithdrawalCQ subQuery) {
            if (_withdrawalReasonCode_SpecifyDerivedReferrer_MemberWithdrawalListMap == null) { _withdrawalReasonCode_SpecifyDerivedReferrer_MemberWithdrawalListMap = new LinkedHashMap<String, MemberWithdrawalCQ>(); }
            String key = "subQueryMapKey" + (_withdrawalReasonCode_SpecifyDerivedReferrer_MemberWithdrawalListMap.size() + 1);
           _withdrawalReasonCode_SpecifyDerivedReferrer_MemberWithdrawalListMap.put(key, subQuery); return "WithdrawalReasonCode_SpecifyDerivedReferrer_MemberWithdrawalList." + key;
        }

        protected Map<String, MemberWithdrawalCQ> _withdrawalReasonCode_QueryDerivedReferrer_MemberWithdrawalListMap;
        public Map<String, MemberWithdrawalCQ> WithdrawalReasonCode_QueryDerivedReferrer_MemberWithdrawalList { get { return _withdrawalReasonCode_QueryDerivedReferrer_MemberWithdrawalListMap; } }
        public override String keepWithdrawalReasonCode_QueryDerivedReferrer_MemberWithdrawalList(MemberWithdrawalCQ subQuery) {
            if (_withdrawalReasonCode_QueryDerivedReferrer_MemberWithdrawalListMap == null) { _withdrawalReasonCode_QueryDerivedReferrer_MemberWithdrawalListMap = new LinkedHashMap<String, MemberWithdrawalCQ>(); }
            String key = "subQueryMapKey" + (_withdrawalReasonCode_QueryDerivedReferrer_MemberWithdrawalListMap.size() + 1);
            _withdrawalReasonCode_QueryDerivedReferrer_MemberWithdrawalListMap.put(key, subQuery); return "WithdrawalReasonCode_QueryDerivedReferrer_MemberWithdrawalList." + key;
        }
        protected Map<String, Object> _withdrawalReasonCode_QueryDerivedReferrer_MemberWithdrawalListParameterMap;
        public Map<String, Object> WithdrawalReasonCode_QueryDerivedReferrer_MemberWithdrawalListParameter { get { return _withdrawalReasonCode_QueryDerivedReferrer_MemberWithdrawalListParameterMap; } }
        public override String keepWithdrawalReasonCode_QueryDerivedReferrer_MemberWithdrawalListParameter(Object parameterValue) {
            if (_withdrawalReasonCode_QueryDerivedReferrer_MemberWithdrawalListParameterMap == null) { _withdrawalReasonCode_QueryDerivedReferrer_MemberWithdrawalListParameterMap = new LinkedHashMap<String, Object>(); }
            String key = "subQueryParameterKey" + (_withdrawalReasonCode_QueryDerivedReferrer_MemberWithdrawalListParameterMap.size() + 1);
            _withdrawalReasonCode_QueryDerivedReferrer_MemberWithdrawalListParameterMap.put(key, parameterValue); return "WithdrawalReasonCode_QueryDerivedReferrer_MemberWithdrawalListParameter." + key;
        }

        public BsWithdrawalReasonCQ AddOrderBy_WithdrawalReasonCode_Asc() { regOBA("WITHDRAWAL_REASON_CODE");return this; }
        public BsWithdrawalReasonCQ AddOrderBy_WithdrawalReasonCode_Desc() { regOBD("WITHDRAWAL_REASON_CODE");return this; }

        protected ConditionValue _withdrawalReasonText;
        public ConditionValue WithdrawalReasonText {
            get { if (_withdrawalReasonText == null) { _withdrawalReasonText = new ConditionValue(); } return _withdrawalReasonText; }
        }
        protected override ConditionValue getCValueWithdrawalReasonText() { return this.WithdrawalReasonText; }


        public BsWithdrawalReasonCQ AddOrderBy_WithdrawalReasonText_Asc() { regOBA("WITHDRAWAL_REASON_TEXT");return this; }
        public BsWithdrawalReasonCQ AddOrderBy_WithdrawalReasonText_Desc() { regOBD("WITHDRAWAL_REASON_TEXT");return this; }

        protected ConditionValue _displayOrder;
        public ConditionValue DisplayOrder {
            get { if (_displayOrder == null) { _displayOrder = new ConditionValue(); } return _displayOrder; }
        }
        protected override ConditionValue getCValueDisplayOrder() { return this.DisplayOrder; }


        public BsWithdrawalReasonCQ AddOrderBy_DisplayOrder_Asc() { regOBA("DISPLAY_ORDER");return this; }
        public BsWithdrawalReasonCQ AddOrderBy_DisplayOrder_Desc() { regOBD("DISPLAY_ORDER");return this; }

        public BsWithdrawalReasonCQ AddSpecifiedDerivedOrderBy_Asc(String aliasName) { registerSpecifiedDerivedOrderBy_Asc(aliasName); return this; }
        public BsWithdrawalReasonCQ AddSpecifiedDerivedOrderBy_Desc(String aliasName) { registerSpecifiedDerivedOrderBy_Desc(aliasName); return this; }

        public override void reflectRelationOnUnionQuery(ConditionQuery baseQueryAsSuper, ConditionQuery unionQueryAsSuper) {

        }
    


	    // ===============================================================================
	    //                                                                 Scalar SubQuery
	    //                                                                 ===============
	    protected Map<String, WithdrawalReasonCQ> _scalarSubQueryMap;
	    public Map<String, WithdrawalReasonCQ> ScalarSubQuery { get { return _scalarSubQueryMap; } }
	    public override String keepScalarSubQuery(WithdrawalReasonCQ subQuery) {
	        if (_scalarSubQueryMap == null) { _scalarSubQueryMap = new LinkedHashMap<String, WithdrawalReasonCQ>(); }
	        String key = "subQueryMapKey" + (_scalarSubQueryMap.size() + 1);
	        _scalarSubQueryMap.put(key, subQuery); return "ScalarSubQuery." + key;
	    }

        // ===============================================================================
        //                                                         Myself InScope SubQuery
        //                                                         =======================
        protected Map<String, WithdrawalReasonCQ> _myselfInScopeSubQueryMap;
        public Map<String, WithdrawalReasonCQ> MyselfInScopeSubQuery { get { return _myselfInScopeSubQueryMap; } }
        public override String keepMyselfInScopeSubQuery(WithdrawalReasonCQ subQuery) {
            if (_myselfInScopeSubQueryMap == null) { _myselfInScopeSubQueryMap = new LinkedHashMap<String, WithdrawalReasonCQ>(); }
            String key = "subQueryMapKey" + (_myselfInScopeSubQueryMap.size() + 1);
            _myselfInScopeSubQueryMap.put(key, subQuery); return "MyselfInScopeSubQuery." + key;
        }
    }
}
