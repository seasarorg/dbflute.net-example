
using System;

using DfExample.DBFlute.AllCommon.CBean;
using DfExample.DBFlute.AllCommon.CBean.CValue;
using DfExample.DBFlute.AllCommon.CBean.SClause;
using DfExample.DBFlute.AllCommon.JavaLike;
using DfExample.DBFlute.CBean.CQ;
using DfExample.DBFlute.CBean.CQ.Ciq;

namespace DfExample.DBFlute.CBean.CQ.BS {

    [System.Serializable]
    public class BsMemberStatusCQ : AbstractBsMemberStatusCQ {

        protected MemberStatusCIQ _inlineQuery;

        public BsMemberStatusCQ(ConditionQuery childQuery, SqlClause sqlClause, String aliasName, int nestLevel)
            : base(childQuery, sqlClause, aliasName, nestLevel) {}

        public MemberStatusCIQ Inline() {
            if (_inlineQuery == null) {
                _inlineQuery = new MemberStatusCIQ(xgetReferrerQuery(), xgetSqlClause(), xgetAliasName(), xgetNestLevel(), this);
            }
            _inlineQuery.xsetOnClause(false);
            return _inlineQuery;
        }
        
        public MemberStatusCIQ On() {
            if (isBaseQuery()) { throw new UnsupportedOperationException("Unsupported onClause of Base Table!"); }
            MemberStatusCIQ inlineQuery = Inline();
            inlineQuery.xsetOnClause(true);
            return inlineQuery;
        }


        protected ConditionValue _memberStatusCode;
        public ConditionValue MemberStatusCode {
            get { if (_memberStatusCode == null) { _memberStatusCode = new ConditionValue(); } return _memberStatusCode; }
        }
        protected override ConditionValue getCValueMemberStatusCode() { return this.MemberStatusCode; }


        protected Map<String, MemberCQ> _memberStatusCode_ExistsSubQuery_MemberListMap;
        public Map<String, MemberCQ> MemberStatusCode_ExistsSubQuery_MemberList { get { return _memberStatusCode_ExistsSubQuery_MemberListMap; }}
        public override String keepMemberStatusCode_ExistsSubQuery_MemberList(MemberCQ subQuery) {
            if (_memberStatusCode_ExistsSubQuery_MemberListMap == null) { _memberStatusCode_ExistsSubQuery_MemberListMap = new LinkedHashMap<String, MemberCQ>(); }
            String key = "subQueryMapKey" + (_memberStatusCode_ExistsSubQuery_MemberListMap.size() + 1);
            _memberStatusCode_ExistsSubQuery_MemberListMap.put(key, subQuery); return "MemberStatusCode_ExistsSubQuery_MemberList." + key;
        }

        protected Map<String, MemberLoginCQ> _memberStatusCode_ExistsSubQuery_MemberLoginListMap;
        public Map<String, MemberLoginCQ> MemberStatusCode_ExistsSubQuery_MemberLoginList { get { return _memberStatusCode_ExistsSubQuery_MemberLoginListMap; }}
        public override String keepMemberStatusCode_ExistsSubQuery_MemberLoginList(MemberLoginCQ subQuery) {
            if (_memberStatusCode_ExistsSubQuery_MemberLoginListMap == null) { _memberStatusCode_ExistsSubQuery_MemberLoginListMap = new LinkedHashMap<String, MemberLoginCQ>(); }
            String key = "subQueryMapKey" + (_memberStatusCode_ExistsSubQuery_MemberLoginListMap.size() + 1);
            _memberStatusCode_ExistsSubQuery_MemberLoginListMap.put(key, subQuery); return "MemberStatusCode_ExistsSubQuery_MemberLoginList." + key;
        }

        protected Map<String, MemberCQ> _memberStatusCode_NotExistsSubQuery_MemberListMap;
        public Map<String, MemberCQ> MemberStatusCode_NotExistsSubQuery_MemberList { get { return _memberStatusCode_NotExistsSubQuery_MemberListMap; }}
        public override String keepMemberStatusCode_NotExistsSubQuery_MemberList(MemberCQ subQuery) {
            if (_memberStatusCode_NotExistsSubQuery_MemberListMap == null) { _memberStatusCode_NotExistsSubQuery_MemberListMap = new LinkedHashMap<String, MemberCQ>(); }
            String key = "subQueryMapKey" + (_memberStatusCode_NotExistsSubQuery_MemberListMap.size() + 1);
            _memberStatusCode_NotExistsSubQuery_MemberListMap.put(key, subQuery); return "MemberStatusCode_NotExistsSubQuery_MemberList." + key;
        }

        protected Map<String, MemberLoginCQ> _memberStatusCode_NotExistsSubQuery_MemberLoginListMap;
        public Map<String, MemberLoginCQ> MemberStatusCode_NotExistsSubQuery_MemberLoginList { get { return _memberStatusCode_NotExistsSubQuery_MemberLoginListMap; }}
        public override String keepMemberStatusCode_NotExistsSubQuery_MemberLoginList(MemberLoginCQ subQuery) {
            if (_memberStatusCode_NotExistsSubQuery_MemberLoginListMap == null) { _memberStatusCode_NotExistsSubQuery_MemberLoginListMap = new LinkedHashMap<String, MemberLoginCQ>(); }
            String key = "subQueryMapKey" + (_memberStatusCode_NotExistsSubQuery_MemberLoginListMap.size() + 1);
            _memberStatusCode_NotExistsSubQuery_MemberLoginListMap.put(key, subQuery); return "MemberStatusCode_NotExistsSubQuery_MemberLoginList." + key;
        }

        protected Map<String, MemberCQ> _memberStatusCode_InScopeSubQuery_MemberListMap;
        public Map<String, MemberCQ> MemberStatusCode_InScopeSubQuery_MemberList { get { return _memberStatusCode_InScopeSubQuery_MemberListMap; }}
        public override String keepMemberStatusCode_InScopeSubQuery_MemberList(MemberCQ subQuery) {
            if (_memberStatusCode_InScopeSubQuery_MemberListMap == null) { _memberStatusCode_InScopeSubQuery_MemberListMap = new LinkedHashMap<String, MemberCQ>(); }
            String key = "subQueryMapKey" + (_memberStatusCode_InScopeSubQuery_MemberListMap.size() + 1);
            _memberStatusCode_InScopeSubQuery_MemberListMap.put(key, subQuery); return "MemberStatusCode_InScopeSubQuery_MemberList." + key;
        }

        protected Map<String, MemberLoginCQ> _memberStatusCode_InScopeSubQuery_MemberLoginListMap;
        public Map<String, MemberLoginCQ> MemberStatusCode_InScopeSubQuery_MemberLoginList { get { return _memberStatusCode_InScopeSubQuery_MemberLoginListMap; }}
        public override String keepMemberStatusCode_InScopeSubQuery_MemberLoginList(MemberLoginCQ subQuery) {
            if (_memberStatusCode_InScopeSubQuery_MemberLoginListMap == null) { _memberStatusCode_InScopeSubQuery_MemberLoginListMap = new LinkedHashMap<String, MemberLoginCQ>(); }
            String key = "subQueryMapKey" + (_memberStatusCode_InScopeSubQuery_MemberLoginListMap.size() + 1);
            _memberStatusCode_InScopeSubQuery_MemberLoginListMap.put(key, subQuery); return "MemberStatusCode_InScopeSubQuery_MemberLoginList." + key;
        }

        protected Map<String, MemberCQ> _memberStatusCode_NotInScopeSubQuery_MemberListMap;
        public Map<String, MemberCQ> MemberStatusCode_NotInScopeSubQuery_MemberList { get { return _memberStatusCode_NotInScopeSubQuery_MemberListMap; }}
        public override String keepMemberStatusCode_NotInScopeSubQuery_MemberList(MemberCQ subQuery) {
            if (_memberStatusCode_NotInScopeSubQuery_MemberListMap == null) { _memberStatusCode_NotInScopeSubQuery_MemberListMap = new LinkedHashMap<String, MemberCQ>(); }
            String key = "subQueryMapKey" + (_memberStatusCode_NotInScopeSubQuery_MemberListMap.size() + 1);
            _memberStatusCode_NotInScopeSubQuery_MemberListMap.put(key, subQuery); return "MemberStatusCode_NotInScopeSubQuery_MemberList." + key;
        }

        protected Map<String, MemberLoginCQ> _memberStatusCode_NotInScopeSubQuery_MemberLoginListMap;
        public Map<String, MemberLoginCQ> MemberStatusCode_NotInScopeSubQuery_MemberLoginList { get { return _memberStatusCode_NotInScopeSubQuery_MemberLoginListMap; }}
        public override String keepMemberStatusCode_NotInScopeSubQuery_MemberLoginList(MemberLoginCQ subQuery) {
            if (_memberStatusCode_NotInScopeSubQuery_MemberLoginListMap == null) { _memberStatusCode_NotInScopeSubQuery_MemberLoginListMap = new LinkedHashMap<String, MemberLoginCQ>(); }
            String key = "subQueryMapKey" + (_memberStatusCode_NotInScopeSubQuery_MemberLoginListMap.size() + 1);
            _memberStatusCode_NotInScopeSubQuery_MemberLoginListMap.put(key, subQuery); return "MemberStatusCode_NotInScopeSubQuery_MemberLoginList." + key;
        }

        protected Map<String, MemberCQ> _memberStatusCode_SpecifyDerivedReferrer_MemberListMap;
        public Map<String, MemberCQ> MemberStatusCode_SpecifyDerivedReferrer_MemberList { get { return _memberStatusCode_SpecifyDerivedReferrer_MemberListMap; }}
        public override String keepMemberStatusCode_SpecifyDerivedReferrer_MemberList(MemberCQ subQuery) {
            if (_memberStatusCode_SpecifyDerivedReferrer_MemberListMap == null) { _memberStatusCode_SpecifyDerivedReferrer_MemberListMap = new LinkedHashMap<String, MemberCQ>(); }
            String key = "subQueryMapKey" + (_memberStatusCode_SpecifyDerivedReferrer_MemberListMap.size() + 1);
           _memberStatusCode_SpecifyDerivedReferrer_MemberListMap.put(key, subQuery); return "MemberStatusCode_SpecifyDerivedReferrer_MemberList." + key;
        }

        protected Map<String, MemberLoginCQ> _memberStatusCode_SpecifyDerivedReferrer_MemberLoginListMap;
        public Map<String, MemberLoginCQ> MemberStatusCode_SpecifyDerivedReferrer_MemberLoginList { get { return _memberStatusCode_SpecifyDerivedReferrer_MemberLoginListMap; }}
        public override String keepMemberStatusCode_SpecifyDerivedReferrer_MemberLoginList(MemberLoginCQ subQuery) {
            if (_memberStatusCode_SpecifyDerivedReferrer_MemberLoginListMap == null) { _memberStatusCode_SpecifyDerivedReferrer_MemberLoginListMap = new LinkedHashMap<String, MemberLoginCQ>(); }
            String key = "subQueryMapKey" + (_memberStatusCode_SpecifyDerivedReferrer_MemberLoginListMap.size() + 1);
           _memberStatusCode_SpecifyDerivedReferrer_MemberLoginListMap.put(key, subQuery); return "MemberStatusCode_SpecifyDerivedReferrer_MemberLoginList." + key;
        }

        protected Map<String, MemberCQ> _memberStatusCode_QueryDerivedReferrer_MemberListMap;
        public Map<String, MemberCQ> MemberStatusCode_QueryDerivedReferrer_MemberList { get { return _memberStatusCode_QueryDerivedReferrer_MemberListMap; } }
        public override String keepMemberStatusCode_QueryDerivedReferrer_MemberList(MemberCQ subQuery) {
            if (_memberStatusCode_QueryDerivedReferrer_MemberListMap == null) { _memberStatusCode_QueryDerivedReferrer_MemberListMap = new LinkedHashMap<String, MemberCQ>(); }
            String key = "subQueryMapKey" + (_memberStatusCode_QueryDerivedReferrer_MemberListMap.size() + 1);
            _memberStatusCode_QueryDerivedReferrer_MemberListMap.put(key, subQuery); return "MemberStatusCode_QueryDerivedReferrer_MemberList." + key;
        }
        protected Map<String, Object> _memberStatusCode_QueryDerivedReferrer_MemberListParameterMap;
        public Map<String, Object> MemberStatusCode_QueryDerivedReferrer_MemberListParameter { get { return _memberStatusCode_QueryDerivedReferrer_MemberListParameterMap; } }
        public override String keepMemberStatusCode_QueryDerivedReferrer_MemberListParameter(Object parameterValue) {
            if (_memberStatusCode_QueryDerivedReferrer_MemberListParameterMap == null) { _memberStatusCode_QueryDerivedReferrer_MemberListParameterMap = new LinkedHashMap<String, Object>(); }
            String key = "subQueryParameterKey" + (_memberStatusCode_QueryDerivedReferrer_MemberListParameterMap.size() + 1);
            _memberStatusCode_QueryDerivedReferrer_MemberListParameterMap.put(key, parameterValue); return "MemberStatusCode_QueryDerivedReferrer_MemberListParameter." + key;
        }

        protected Map<String, MemberLoginCQ> _memberStatusCode_QueryDerivedReferrer_MemberLoginListMap;
        public Map<String, MemberLoginCQ> MemberStatusCode_QueryDerivedReferrer_MemberLoginList { get { return _memberStatusCode_QueryDerivedReferrer_MemberLoginListMap; } }
        public override String keepMemberStatusCode_QueryDerivedReferrer_MemberLoginList(MemberLoginCQ subQuery) {
            if (_memberStatusCode_QueryDerivedReferrer_MemberLoginListMap == null) { _memberStatusCode_QueryDerivedReferrer_MemberLoginListMap = new LinkedHashMap<String, MemberLoginCQ>(); }
            String key = "subQueryMapKey" + (_memberStatusCode_QueryDerivedReferrer_MemberLoginListMap.size() + 1);
            _memberStatusCode_QueryDerivedReferrer_MemberLoginListMap.put(key, subQuery); return "MemberStatusCode_QueryDerivedReferrer_MemberLoginList." + key;
        }
        protected Map<String, Object> _memberStatusCode_QueryDerivedReferrer_MemberLoginListParameterMap;
        public Map<String, Object> MemberStatusCode_QueryDerivedReferrer_MemberLoginListParameter { get { return _memberStatusCode_QueryDerivedReferrer_MemberLoginListParameterMap; } }
        public override String keepMemberStatusCode_QueryDerivedReferrer_MemberLoginListParameter(Object parameterValue) {
            if (_memberStatusCode_QueryDerivedReferrer_MemberLoginListParameterMap == null) { _memberStatusCode_QueryDerivedReferrer_MemberLoginListParameterMap = new LinkedHashMap<String, Object>(); }
            String key = "subQueryParameterKey" + (_memberStatusCode_QueryDerivedReferrer_MemberLoginListParameterMap.size() + 1);
            _memberStatusCode_QueryDerivedReferrer_MemberLoginListParameterMap.put(key, parameterValue); return "MemberStatusCode_QueryDerivedReferrer_MemberLoginListParameter." + key;
        }

        public BsMemberStatusCQ AddOrderBy_MemberStatusCode_Asc() { regOBA("MEMBER_STATUS_CODE");return this; }
        public BsMemberStatusCQ AddOrderBy_MemberStatusCode_Desc() { regOBD("MEMBER_STATUS_CODE");return this; }

        protected ConditionValue _memberStatusName;
        public ConditionValue MemberStatusName {
            get { if (_memberStatusName == null) { _memberStatusName = new ConditionValue(); } return _memberStatusName; }
        }
        protected override ConditionValue getCValueMemberStatusName() { return this.MemberStatusName; }


        public BsMemberStatusCQ AddOrderBy_MemberStatusName_Asc() { regOBA("MEMBER_STATUS_NAME");return this; }
        public BsMemberStatusCQ AddOrderBy_MemberStatusName_Desc() { regOBD("MEMBER_STATUS_NAME");return this; }

        protected ConditionValue _displayOrder;
        public ConditionValue DisplayOrder {
            get { if (_displayOrder == null) { _displayOrder = new ConditionValue(); } return _displayOrder; }
        }
        protected override ConditionValue getCValueDisplayOrder() { return this.DisplayOrder; }


        public BsMemberStatusCQ AddOrderBy_DisplayOrder_Asc() { regOBA("DISPLAY_ORDER");return this; }
        public BsMemberStatusCQ AddOrderBy_DisplayOrder_Desc() { regOBD("DISPLAY_ORDER");return this; }

        public BsMemberStatusCQ AddSpecifiedDerivedOrderBy_Asc(String aliasName) { registerSpecifiedDerivedOrderBy_Asc(aliasName); return this; }
        public BsMemberStatusCQ AddSpecifiedDerivedOrderBy_Desc(String aliasName) { registerSpecifiedDerivedOrderBy_Desc(aliasName); return this; }

        public override void reflectRelationOnUnionQuery(ConditionQuery baseQueryAsSuper, ConditionQuery unionQueryAsSuper) {

        }
    


	    // ===============================================================================
	    //                                                                 Scalar SubQuery
	    //                                                                 ===============
	    protected Map<String, MemberStatusCQ> _scalarSubQueryMap;
	    public Map<String, MemberStatusCQ> ScalarSubQuery { get { return _scalarSubQueryMap; } }
	    public override String keepScalarSubQuery(MemberStatusCQ subQuery) {
	        if (_scalarSubQueryMap == null) { _scalarSubQueryMap = new LinkedHashMap<String, MemberStatusCQ>(); }
	        String key = "subQueryMapKey" + (_scalarSubQueryMap.size() + 1);
	        _scalarSubQueryMap.put(key, subQuery); return "ScalarSubQuery." + key;
	    }

        // ===============================================================================
        //                                                         Myself InScope SubQuery
        //                                                         =======================
        protected Map<String, MemberStatusCQ> _myselfInScopeSubQueryMap;
        public Map<String, MemberStatusCQ> MyselfInScopeSubQuery { get { return _myselfInScopeSubQueryMap; } }
        public override String keepMyselfInScopeSubQuery(MemberStatusCQ subQuery) {
            if (_myselfInScopeSubQueryMap == null) { _myselfInScopeSubQueryMap = new LinkedHashMap<String, MemberStatusCQ>(); }
            String key = "subQueryMapKey" + (_myselfInScopeSubQueryMap.size() + 1);
            _myselfInScopeSubQueryMap.put(key, subQuery); return "MyselfInScopeSubQuery." + key;
        }
    }
}
