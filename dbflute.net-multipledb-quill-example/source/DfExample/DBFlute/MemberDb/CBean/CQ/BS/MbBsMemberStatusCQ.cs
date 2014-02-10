
using System;

using DfExample.DBFlute.MemberDb.AllCommon.CBean;
using DfExample.DBFlute.MemberDb.AllCommon.CBean.CValue;
using DfExample.DBFlute.MemberDb.AllCommon.CBean.SClause;
using DfExample.DBFlute.MemberDb.AllCommon.JavaLike;
using DfExample.DBFlute.MemberDb.CBean.CQ;
using DfExample.DBFlute.MemberDb.CBean.CQ.Ciq;

namespace DfExample.DBFlute.MemberDb.CBean.CQ.BS {

    [System.Serializable]
    public class MbBsMemberStatusCQ : MbAbstractBsMemberStatusCQ {

        protected MbMemberStatusCIQ _inlineQuery;

        public MbBsMemberStatusCQ(MbConditionQuery childQuery, MbSqlClause sqlClause, String aliasName, int nestLevel)
            : base(childQuery, sqlClause, aliasName, nestLevel) {}

        public MbMemberStatusCIQ Inline() {
            if (_inlineQuery == null) {
                _inlineQuery = new MbMemberStatusCIQ(xgetReferrerQuery(), xgetSqlClause(), xgetAliasName(), xgetNestLevel(), this);
            }
            _inlineQuery.xsetOnClause(false);
            return _inlineQuery;
        }
        
        public MbMemberStatusCIQ On() {
            if (isBaseQuery()) { throw new UnsupportedOperationException("Unsupported onClause of Base Table!"); }
            MbMemberStatusCIQ inlineQuery = Inline();
            inlineQuery.xsetOnClause(true);
            return inlineQuery;
        }


        protected MbConditionValue _memberStatusCode;
        public MbConditionValue MemberStatusCode {
            get { if (_memberStatusCode == null) { _memberStatusCode = new MbConditionValue(); } return _memberStatusCode; }
        }
        protected override MbConditionValue getCValueMemberStatusCode() { return this.MemberStatusCode; }


        protected Map<String, MbMemberCQ> _memberStatusCode_ExistsSubQuery_MemberListMap;
        public Map<String, MbMemberCQ> MemberStatusCode_ExistsSubQuery_MemberList { get { return _memberStatusCode_ExistsSubQuery_MemberListMap; }}
        public override String keepMemberStatusCode_ExistsSubQuery_MemberList(MbMemberCQ subQuery) {
            if (_memberStatusCode_ExistsSubQuery_MemberListMap == null) { _memberStatusCode_ExistsSubQuery_MemberListMap = new LinkedHashMap<String, MbMemberCQ>(); }
            String key = "subQueryMapKey" + (_memberStatusCode_ExistsSubQuery_MemberListMap.size() + 1);
            _memberStatusCode_ExistsSubQuery_MemberListMap.put(key, subQuery); return "MemberStatusCode_ExistsSubQuery_MemberList." + key;
        }

        protected Map<String, MbMemberLoginCQ> _memberStatusCode_ExistsSubQuery_MemberLoginListMap;
        public Map<String, MbMemberLoginCQ> MemberStatusCode_ExistsSubQuery_MemberLoginList { get { return _memberStatusCode_ExistsSubQuery_MemberLoginListMap; }}
        public override String keepMemberStatusCode_ExistsSubQuery_MemberLoginList(MbMemberLoginCQ subQuery) {
            if (_memberStatusCode_ExistsSubQuery_MemberLoginListMap == null) { _memberStatusCode_ExistsSubQuery_MemberLoginListMap = new LinkedHashMap<String, MbMemberLoginCQ>(); }
            String key = "subQueryMapKey" + (_memberStatusCode_ExistsSubQuery_MemberLoginListMap.size() + 1);
            _memberStatusCode_ExistsSubQuery_MemberLoginListMap.put(key, subQuery); return "MemberStatusCode_ExistsSubQuery_MemberLoginList." + key;
        }

        protected Map<String, MbMemberCQ> _memberStatusCode_NotExistsSubQuery_MemberListMap;
        public Map<String, MbMemberCQ> MemberStatusCode_NotExistsSubQuery_MemberList { get { return _memberStatusCode_NotExistsSubQuery_MemberListMap; }}
        public override String keepMemberStatusCode_NotExistsSubQuery_MemberList(MbMemberCQ subQuery) {
            if (_memberStatusCode_NotExistsSubQuery_MemberListMap == null) { _memberStatusCode_NotExistsSubQuery_MemberListMap = new LinkedHashMap<String, MbMemberCQ>(); }
            String key = "subQueryMapKey" + (_memberStatusCode_NotExistsSubQuery_MemberListMap.size() + 1);
            _memberStatusCode_NotExistsSubQuery_MemberListMap.put(key, subQuery); return "MemberStatusCode_NotExistsSubQuery_MemberList." + key;
        }

        protected Map<String, MbMemberLoginCQ> _memberStatusCode_NotExistsSubQuery_MemberLoginListMap;
        public Map<String, MbMemberLoginCQ> MemberStatusCode_NotExistsSubQuery_MemberLoginList { get { return _memberStatusCode_NotExistsSubQuery_MemberLoginListMap; }}
        public override String keepMemberStatusCode_NotExistsSubQuery_MemberLoginList(MbMemberLoginCQ subQuery) {
            if (_memberStatusCode_NotExistsSubQuery_MemberLoginListMap == null) { _memberStatusCode_NotExistsSubQuery_MemberLoginListMap = new LinkedHashMap<String, MbMemberLoginCQ>(); }
            String key = "subQueryMapKey" + (_memberStatusCode_NotExistsSubQuery_MemberLoginListMap.size() + 1);
            _memberStatusCode_NotExistsSubQuery_MemberLoginListMap.put(key, subQuery); return "MemberStatusCode_NotExistsSubQuery_MemberLoginList." + key;
        }

        protected Map<String, MbMemberCQ> _memberStatusCode_InScopeSubQuery_MemberListMap;
        public Map<String, MbMemberCQ> MemberStatusCode_InScopeSubQuery_MemberList { get { return _memberStatusCode_InScopeSubQuery_MemberListMap; }}
        public override String keepMemberStatusCode_InScopeSubQuery_MemberList(MbMemberCQ subQuery) {
            if (_memberStatusCode_InScopeSubQuery_MemberListMap == null) { _memberStatusCode_InScopeSubQuery_MemberListMap = new LinkedHashMap<String, MbMemberCQ>(); }
            String key = "subQueryMapKey" + (_memberStatusCode_InScopeSubQuery_MemberListMap.size() + 1);
            _memberStatusCode_InScopeSubQuery_MemberListMap.put(key, subQuery); return "MemberStatusCode_InScopeSubQuery_MemberList." + key;
        }

        protected Map<String, MbMemberLoginCQ> _memberStatusCode_InScopeSubQuery_MemberLoginListMap;
        public Map<String, MbMemberLoginCQ> MemberStatusCode_InScopeSubQuery_MemberLoginList { get { return _memberStatusCode_InScopeSubQuery_MemberLoginListMap; }}
        public override String keepMemberStatusCode_InScopeSubQuery_MemberLoginList(MbMemberLoginCQ subQuery) {
            if (_memberStatusCode_InScopeSubQuery_MemberLoginListMap == null) { _memberStatusCode_InScopeSubQuery_MemberLoginListMap = new LinkedHashMap<String, MbMemberLoginCQ>(); }
            String key = "subQueryMapKey" + (_memberStatusCode_InScopeSubQuery_MemberLoginListMap.size() + 1);
            _memberStatusCode_InScopeSubQuery_MemberLoginListMap.put(key, subQuery); return "MemberStatusCode_InScopeSubQuery_MemberLoginList." + key;
        }

        protected Map<String, MbMemberCQ> _memberStatusCode_NotInScopeSubQuery_MemberListMap;
        public Map<String, MbMemberCQ> MemberStatusCode_NotInScopeSubQuery_MemberList { get { return _memberStatusCode_NotInScopeSubQuery_MemberListMap; }}
        public override String keepMemberStatusCode_NotInScopeSubQuery_MemberList(MbMemberCQ subQuery) {
            if (_memberStatusCode_NotInScopeSubQuery_MemberListMap == null) { _memberStatusCode_NotInScopeSubQuery_MemberListMap = new LinkedHashMap<String, MbMemberCQ>(); }
            String key = "subQueryMapKey" + (_memberStatusCode_NotInScopeSubQuery_MemberListMap.size() + 1);
            _memberStatusCode_NotInScopeSubQuery_MemberListMap.put(key, subQuery); return "MemberStatusCode_NotInScopeSubQuery_MemberList." + key;
        }

        protected Map<String, MbMemberLoginCQ> _memberStatusCode_NotInScopeSubQuery_MemberLoginListMap;
        public Map<String, MbMemberLoginCQ> MemberStatusCode_NotInScopeSubQuery_MemberLoginList { get { return _memberStatusCode_NotInScopeSubQuery_MemberLoginListMap; }}
        public override String keepMemberStatusCode_NotInScopeSubQuery_MemberLoginList(MbMemberLoginCQ subQuery) {
            if (_memberStatusCode_NotInScopeSubQuery_MemberLoginListMap == null) { _memberStatusCode_NotInScopeSubQuery_MemberLoginListMap = new LinkedHashMap<String, MbMemberLoginCQ>(); }
            String key = "subQueryMapKey" + (_memberStatusCode_NotInScopeSubQuery_MemberLoginListMap.size() + 1);
            _memberStatusCode_NotInScopeSubQuery_MemberLoginListMap.put(key, subQuery); return "MemberStatusCode_NotInScopeSubQuery_MemberLoginList." + key;
        }

        protected Map<String, MbMemberCQ> _memberStatusCode_SpecifyDerivedReferrer_MemberListMap;
        public Map<String, MbMemberCQ> MemberStatusCode_SpecifyDerivedReferrer_MemberList { get { return _memberStatusCode_SpecifyDerivedReferrer_MemberListMap; }}
        public override String keepMemberStatusCode_SpecifyDerivedReferrer_MemberList(MbMemberCQ subQuery) {
            if (_memberStatusCode_SpecifyDerivedReferrer_MemberListMap == null) { _memberStatusCode_SpecifyDerivedReferrer_MemberListMap = new LinkedHashMap<String, MbMemberCQ>(); }
            String key = "subQueryMapKey" + (_memberStatusCode_SpecifyDerivedReferrer_MemberListMap.size() + 1);
           _memberStatusCode_SpecifyDerivedReferrer_MemberListMap.put(key, subQuery); return "MemberStatusCode_SpecifyDerivedReferrer_MemberList." + key;
        }

        protected Map<String, MbMemberLoginCQ> _memberStatusCode_SpecifyDerivedReferrer_MemberLoginListMap;
        public Map<String, MbMemberLoginCQ> MemberStatusCode_SpecifyDerivedReferrer_MemberLoginList { get { return _memberStatusCode_SpecifyDerivedReferrer_MemberLoginListMap; }}
        public override String keepMemberStatusCode_SpecifyDerivedReferrer_MemberLoginList(MbMemberLoginCQ subQuery) {
            if (_memberStatusCode_SpecifyDerivedReferrer_MemberLoginListMap == null) { _memberStatusCode_SpecifyDerivedReferrer_MemberLoginListMap = new LinkedHashMap<String, MbMemberLoginCQ>(); }
            String key = "subQueryMapKey" + (_memberStatusCode_SpecifyDerivedReferrer_MemberLoginListMap.size() + 1);
           _memberStatusCode_SpecifyDerivedReferrer_MemberLoginListMap.put(key, subQuery); return "MemberStatusCode_SpecifyDerivedReferrer_MemberLoginList." + key;
        }

        protected Map<String, MbMemberCQ> _memberStatusCode_QueryDerivedReferrer_MemberListMap;
        public Map<String, MbMemberCQ> MemberStatusCode_QueryDerivedReferrer_MemberList { get { return _memberStatusCode_QueryDerivedReferrer_MemberListMap; } }
        public override String keepMemberStatusCode_QueryDerivedReferrer_MemberList(MbMemberCQ subQuery) {
            if (_memberStatusCode_QueryDerivedReferrer_MemberListMap == null) { _memberStatusCode_QueryDerivedReferrer_MemberListMap = new LinkedHashMap<String, MbMemberCQ>(); }
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

        protected Map<String, MbMemberLoginCQ> _memberStatusCode_QueryDerivedReferrer_MemberLoginListMap;
        public Map<String, MbMemberLoginCQ> MemberStatusCode_QueryDerivedReferrer_MemberLoginList { get { return _memberStatusCode_QueryDerivedReferrer_MemberLoginListMap; } }
        public override String keepMemberStatusCode_QueryDerivedReferrer_MemberLoginList(MbMemberLoginCQ subQuery) {
            if (_memberStatusCode_QueryDerivedReferrer_MemberLoginListMap == null) { _memberStatusCode_QueryDerivedReferrer_MemberLoginListMap = new LinkedHashMap<String, MbMemberLoginCQ>(); }
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

        public MbBsMemberStatusCQ AddOrderBy_MemberStatusCode_Asc() { regOBA("MEMBER_STATUS_CODE");return this; }
        public MbBsMemberStatusCQ AddOrderBy_MemberStatusCode_Desc() { regOBD("MEMBER_STATUS_CODE");return this; }

        protected MbConditionValue _memberStatusName;
        public MbConditionValue MemberStatusName {
            get { if (_memberStatusName == null) { _memberStatusName = new MbConditionValue(); } return _memberStatusName; }
        }
        protected override MbConditionValue getCValueMemberStatusName() { return this.MemberStatusName; }


        public MbBsMemberStatusCQ AddOrderBy_MemberStatusName_Asc() { regOBA("MEMBER_STATUS_NAME");return this; }
        public MbBsMemberStatusCQ AddOrderBy_MemberStatusName_Desc() { regOBD("MEMBER_STATUS_NAME");return this; }

        protected MbConditionValue _displayOrder;
        public MbConditionValue DisplayOrder {
            get { if (_displayOrder == null) { _displayOrder = new MbConditionValue(); } return _displayOrder; }
        }
        protected override MbConditionValue getCValueDisplayOrder() { return this.DisplayOrder; }


        public MbBsMemberStatusCQ AddOrderBy_DisplayOrder_Asc() { regOBA("DISPLAY_ORDER");return this; }
        public MbBsMemberStatusCQ AddOrderBy_DisplayOrder_Desc() { regOBD("DISPLAY_ORDER");return this; }

        public MbBsMemberStatusCQ AddSpecifiedDerivedOrderBy_Asc(String aliasName) { registerSpecifiedDerivedOrderBy_Asc(aliasName); return this; }
        public MbBsMemberStatusCQ AddSpecifiedDerivedOrderBy_Desc(String aliasName) { registerSpecifiedDerivedOrderBy_Desc(aliasName); return this; }

        public override void reflectRelationOnUnionQuery(MbConditionQuery baseQueryAsSuper, MbConditionQuery unionQueryAsSuper) {

        }
    


	    // ===============================================================================
	    //                                                                 Scalar SubQuery
	    //                                                                 ===============
	    protected Map<String, MbMemberStatusCQ> _scalarSubQueryMap;
	    public Map<String, MbMemberStatusCQ> ScalarSubQuery { get { return _scalarSubQueryMap; } }
	    public override String keepScalarSubQuery(MbMemberStatusCQ subQuery) {
	        if (_scalarSubQueryMap == null) { _scalarSubQueryMap = new LinkedHashMap<String, MbMemberStatusCQ>(); }
	        String key = "subQueryMapKey" + (_scalarSubQueryMap.size() + 1);
	        _scalarSubQueryMap.put(key, subQuery); return "ScalarSubQuery." + key;
	    }

        // ===============================================================================
        //                                                         Myself InScope SubQuery
        //                                                         =======================
        protected Map<String, MbMemberStatusCQ> _myselfInScopeSubQueryMap;
        public Map<String, MbMemberStatusCQ> MyselfInScopeSubQuery { get { return _myselfInScopeSubQueryMap; } }
        public override String keepMyselfInScopeSubQuery(MbMemberStatusCQ subQuery) {
            if (_myselfInScopeSubQueryMap == null) { _myselfInScopeSubQueryMap = new LinkedHashMap<String, MbMemberStatusCQ>(); }
            String key = "subQueryMapKey" + (_myselfInScopeSubQueryMap.size() + 1);
            _myselfInScopeSubQueryMap.put(key, subQuery); return "MyselfInScopeSubQuery." + key;
        }
    }
}
