
using System;

using DfExample.DBFlute.MemberDb.AllCommon.CBean;
using DfExample.DBFlute.MemberDb.AllCommon.CBean.CValue;
using DfExample.DBFlute.MemberDb.AllCommon.CBean.SClause;
using DfExample.DBFlute.MemberDb.AllCommon.JavaLike;
using DfExample.DBFlute.MemberDb.CBean.CQ;
using DfExample.DBFlute.MemberDb.CBean.CQ.Ciq;

namespace DfExample.DBFlute.MemberDb.CBean.CQ.BS {

    [System.Serializable]
    public class MbBsWithdrawalReasonCQ : MbAbstractBsWithdrawalReasonCQ {

        protected MbWithdrawalReasonCIQ _inlineQuery;

        public MbBsWithdrawalReasonCQ(MbConditionQuery childQuery, MbSqlClause sqlClause, String aliasName, int nestLevel)
            : base(childQuery, sqlClause, aliasName, nestLevel) {}

        public MbWithdrawalReasonCIQ Inline() {
            if (_inlineQuery == null) {
                _inlineQuery = new MbWithdrawalReasonCIQ(xgetReferrerQuery(), xgetSqlClause(), xgetAliasName(), xgetNestLevel(), this);
            }
            _inlineQuery.xsetOnClause(false);
            return _inlineQuery;
        }
        
        public MbWithdrawalReasonCIQ On() {
            if (isBaseQuery()) { throw new UnsupportedOperationException("Unsupported onClause of Base Table!"); }
            MbWithdrawalReasonCIQ inlineQuery = Inline();
            inlineQuery.xsetOnClause(true);
            return inlineQuery;
        }


        protected MbConditionValue _withdrawalReasonCode;
        public MbConditionValue WithdrawalReasonCode {
            get { if (_withdrawalReasonCode == null) { _withdrawalReasonCode = new MbConditionValue(); } return _withdrawalReasonCode; }
        }
        protected override MbConditionValue getCValueWithdrawalReasonCode() { return this.WithdrawalReasonCode; }


        protected Map<String, MbMemberWithdrawalCQ> _withdrawalReasonCode_ExistsSubQuery_MemberWithdrawalListMap;
        public Map<String, MbMemberWithdrawalCQ> WithdrawalReasonCode_ExistsSubQuery_MemberWithdrawalList { get { return _withdrawalReasonCode_ExistsSubQuery_MemberWithdrawalListMap; }}
        public override String keepWithdrawalReasonCode_ExistsSubQuery_MemberWithdrawalList(MbMemberWithdrawalCQ subQuery) {
            if (_withdrawalReasonCode_ExistsSubQuery_MemberWithdrawalListMap == null) { _withdrawalReasonCode_ExistsSubQuery_MemberWithdrawalListMap = new LinkedHashMap<String, MbMemberWithdrawalCQ>(); }
            String key = "subQueryMapKey" + (_withdrawalReasonCode_ExistsSubQuery_MemberWithdrawalListMap.size() + 1);
            _withdrawalReasonCode_ExistsSubQuery_MemberWithdrawalListMap.put(key, subQuery); return "WithdrawalReasonCode_ExistsSubQuery_MemberWithdrawalList." + key;
        }

        protected Map<String, MbMemberWithdrawalCQ> _withdrawalReasonCode_NotExistsSubQuery_MemberWithdrawalListMap;
        public Map<String, MbMemberWithdrawalCQ> WithdrawalReasonCode_NotExistsSubQuery_MemberWithdrawalList { get { return _withdrawalReasonCode_NotExistsSubQuery_MemberWithdrawalListMap; }}
        public override String keepWithdrawalReasonCode_NotExistsSubQuery_MemberWithdrawalList(MbMemberWithdrawalCQ subQuery) {
            if (_withdrawalReasonCode_NotExistsSubQuery_MemberWithdrawalListMap == null) { _withdrawalReasonCode_NotExistsSubQuery_MemberWithdrawalListMap = new LinkedHashMap<String, MbMemberWithdrawalCQ>(); }
            String key = "subQueryMapKey" + (_withdrawalReasonCode_NotExistsSubQuery_MemberWithdrawalListMap.size() + 1);
            _withdrawalReasonCode_NotExistsSubQuery_MemberWithdrawalListMap.put(key, subQuery); return "WithdrawalReasonCode_NotExistsSubQuery_MemberWithdrawalList." + key;
        }

        protected Map<String, MbMemberWithdrawalCQ> _withdrawalReasonCode_InScopeSubQuery_MemberWithdrawalListMap;
        public Map<String, MbMemberWithdrawalCQ> WithdrawalReasonCode_InScopeSubQuery_MemberWithdrawalList { get { return _withdrawalReasonCode_InScopeSubQuery_MemberWithdrawalListMap; }}
        public override String keepWithdrawalReasonCode_InScopeSubQuery_MemberWithdrawalList(MbMemberWithdrawalCQ subQuery) {
            if (_withdrawalReasonCode_InScopeSubQuery_MemberWithdrawalListMap == null) { _withdrawalReasonCode_InScopeSubQuery_MemberWithdrawalListMap = new LinkedHashMap<String, MbMemberWithdrawalCQ>(); }
            String key = "subQueryMapKey" + (_withdrawalReasonCode_InScopeSubQuery_MemberWithdrawalListMap.size() + 1);
            _withdrawalReasonCode_InScopeSubQuery_MemberWithdrawalListMap.put(key, subQuery); return "WithdrawalReasonCode_InScopeSubQuery_MemberWithdrawalList." + key;
        }

        protected Map<String, MbMemberWithdrawalCQ> _withdrawalReasonCode_NotInScopeSubQuery_MemberWithdrawalListMap;
        public Map<String, MbMemberWithdrawalCQ> WithdrawalReasonCode_NotInScopeSubQuery_MemberWithdrawalList { get { return _withdrawalReasonCode_NotInScopeSubQuery_MemberWithdrawalListMap; }}
        public override String keepWithdrawalReasonCode_NotInScopeSubQuery_MemberWithdrawalList(MbMemberWithdrawalCQ subQuery) {
            if (_withdrawalReasonCode_NotInScopeSubQuery_MemberWithdrawalListMap == null) { _withdrawalReasonCode_NotInScopeSubQuery_MemberWithdrawalListMap = new LinkedHashMap<String, MbMemberWithdrawalCQ>(); }
            String key = "subQueryMapKey" + (_withdrawalReasonCode_NotInScopeSubQuery_MemberWithdrawalListMap.size() + 1);
            _withdrawalReasonCode_NotInScopeSubQuery_MemberWithdrawalListMap.put(key, subQuery); return "WithdrawalReasonCode_NotInScopeSubQuery_MemberWithdrawalList." + key;
        }

        protected Map<String, MbMemberWithdrawalCQ> _withdrawalReasonCode_SpecifyDerivedReferrer_MemberWithdrawalListMap;
        public Map<String, MbMemberWithdrawalCQ> WithdrawalReasonCode_SpecifyDerivedReferrer_MemberWithdrawalList { get { return _withdrawalReasonCode_SpecifyDerivedReferrer_MemberWithdrawalListMap; }}
        public override String keepWithdrawalReasonCode_SpecifyDerivedReferrer_MemberWithdrawalList(MbMemberWithdrawalCQ subQuery) {
            if (_withdrawalReasonCode_SpecifyDerivedReferrer_MemberWithdrawalListMap == null) { _withdrawalReasonCode_SpecifyDerivedReferrer_MemberWithdrawalListMap = new LinkedHashMap<String, MbMemberWithdrawalCQ>(); }
            String key = "subQueryMapKey" + (_withdrawalReasonCode_SpecifyDerivedReferrer_MemberWithdrawalListMap.size() + 1);
           _withdrawalReasonCode_SpecifyDerivedReferrer_MemberWithdrawalListMap.put(key, subQuery); return "WithdrawalReasonCode_SpecifyDerivedReferrer_MemberWithdrawalList." + key;
        }

        protected Map<String, MbMemberWithdrawalCQ> _withdrawalReasonCode_QueryDerivedReferrer_MemberWithdrawalListMap;
        public Map<String, MbMemberWithdrawalCQ> WithdrawalReasonCode_QueryDerivedReferrer_MemberWithdrawalList { get { return _withdrawalReasonCode_QueryDerivedReferrer_MemberWithdrawalListMap; } }
        public override String keepWithdrawalReasonCode_QueryDerivedReferrer_MemberWithdrawalList(MbMemberWithdrawalCQ subQuery) {
            if (_withdrawalReasonCode_QueryDerivedReferrer_MemberWithdrawalListMap == null) { _withdrawalReasonCode_QueryDerivedReferrer_MemberWithdrawalListMap = new LinkedHashMap<String, MbMemberWithdrawalCQ>(); }
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

        public MbBsWithdrawalReasonCQ AddOrderBy_WithdrawalReasonCode_Asc() { regOBA("WITHDRAWAL_REASON_CODE");return this; }
        public MbBsWithdrawalReasonCQ AddOrderBy_WithdrawalReasonCode_Desc() { regOBD("WITHDRAWAL_REASON_CODE");return this; }

        protected MbConditionValue _withdrawalReasonText;
        public MbConditionValue WithdrawalReasonText {
            get { if (_withdrawalReasonText == null) { _withdrawalReasonText = new MbConditionValue(); } return _withdrawalReasonText; }
        }
        protected override MbConditionValue getCValueWithdrawalReasonText() { return this.WithdrawalReasonText; }


        public MbBsWithdrawalReasonCQ AddOrderBy_WithdrawalReasonText_Asc() { regOBA("WITHDRAWAL_REASON_TEXT");return this; }
        public MbBsWithdrawalReasonCQ AddOrderBy_WithdrawalReasonText_Desc() { regOBD("WITHDRAWAL_REASON_TEXT");return this; }

        protected MbConditionValue _displayOrder;
        public MbConditionValue DisplayOrder {
            get { if (_displayOrder == null) { _displayOrder = new MbConditionValue(); } return _displayOrder; }
        }
        protected override MbConditionValue getCValueDisplayOrder() { return this.DisplayOrder; }


        public MbBsWithdrawalReasonCQ AddOrderBy_DisplayOrder_Asc() { regOBA("DISPLAY_ORDER");return this; }
        public MbBsWithdrawalReasonCQ AddOrderBy_DisplayOrder_Desc() { regOBD("DISPLAY_ORDER");return this; }

        public MbBsWithdrawalReasonCQ AddSpecifiedDerivedOrderBy_Asc(String aliasName) { registerSpecifiedDerivedOrderBy_Asc(aliasName); return this; }
        public MbBsWithdrawalReasonCQ AddSpecifiedDerivedOrderBy_Desc(String aliasName) { registerSpecifiedDerivedOrderBy_Desc(aliasName); return this; }

        public override void reflectRelationOnUnionQuery(MbConditionQuery baseQueryAsSuper, MbConditionQuery unionQueryAsSuper) {

        }
    


	    // ===============================================================================
	    //                                                                 Scalar SubQuery
	    //                                                                 ===============
	    protected Map<String, MbWithdrawalReasonCQ> _scalarSubQueryMap;
	    public Map<String, MbWithdrawalReasonCQ> ScalarSubQuery { get { return _scalarSubQueryMap; } }
	    public override String keepScalarSubQuery(MbWithdrawalReasonCQ subQuery) {
	        if (_scalarSubQueryMap == null) { _scalarSubQueryMap = new LinkedHashMap<String, MbWithdrawalReasonCQ>(); }
	        String key = "subQueryMapKey" + (_scalarSubQueryMap.size() + 1);
	        _scalarSubQueryMap.put(key, subQuery); return "ScalarSubQuery." + key;
	    }

        // ===============================================================================
        //                                                         Myself InScope SubQuery
        //                                                         =======================
        protected Map<String, MbWithdrawalReasonCQ> _myselfInScopeSubQueryMap;
        public Map<String, MbWithdrawalReasonCQ> MyselfInScopeSubQuery { get { return _myselfInScopeSubQueryMap; } }
        public override String keepMyselfInScopeSubQuery(MbWithdrawalReasonCQ subQuery) {
            if (_myselfInScopeSubQueryMap == null) { _myselfInScopeSubQueryMap = new LinkedHashMap<String, MbWithdrawalReasonCQ>(); }
            String key = "subQueryMapKey" + (_myselfInScopeSubQueryMap.size() + 1);
            _myselfInScopeSubQueryMap.put(key, subQuery); return "MyselfInScopeSubQuery." + key;
        }
    }
}
