
using System;

using DfExample.DBFlute.LibraryDb.AllCommon.CBean;
using DfExample.DBFlute.LibraryDb.AllCommon.CBean.CValue;
using DfExample.DBFlute.LibraryDb.AllCommon.CBean.SClause;
using DfExample.DBFlute.LibraryDb.AllCommon.JavaLike;
using DfExample.DBFlute.LibraryDb.CBean.CQ;
using DfExample.DBFlute.LibraryDb.CBean.CQ.Ciq;

namespace DfExample.DBFlute.LibraryDb.CBean.CQ.BS {

    [System.Serializable]
    public class LdBsBlackListCQ : LdAbstractBsBlackListCQ {

        protected LdBlackListCIQ _inlineQuery;

        public LdBsBlackListCQ(LdConditionQuery childQuery, LdSqlClause sqlClause, String aliasName, int nestLevel)
            : base(childQuery, sqlClause, aliasName, nestLevel) {}

        public LdBlackListCIQ Inline() {
            if (_inlineQuery == null) {
                _inlineQuery = new LdBlackListCIQ(xgetReferrerQuery(), xgetSqlClause(), xgetAliasName(), xgetNestLevel(), this);
            }
            _inlineQuery.xsetOnClause(false);
            return _inlineQuery;
        }
        
        public LdBlackListCIQ On() {
            if (isBaseQuery()) { throw new UnsupportedOperationException("Unsupported onClause of Base Table!"); }
            LdBlackListCIQ inlineQuery = Inline();
            inlineQuery.xsetOnClause(true);
            return inlineQuery;
        }


        protected LdConditionValue _blackListId;
        public LdConditionValue BlackListId {
            get { if (_blackListId == null) { _blackListId = new LdConditionValue(); } return _blackListId; }
        }
        protected override LdConditionValue getCValueBlackListId() { return this.BlackListId; }


        protected Map<String, LdBlackActionCQ> _blackListId_ExistsSubQuery_BlackActionListMap;
        public Map<String, LdBlackActionCQ> BlackListId_ExistsSubQuery_BlackActionList { get { return _blackListId_ExistsSubQuery_BlackActionListMap; }}
        public override String keepBlackListId_ExistsSubQuery_BlackActionList(LdBlackActionCQ subQuery) {
            if (_blackListId_ExistsSubQuery_BlackActionListMap == null) { _blackListId_ExistsSubQuery_BlackActionListMap = new LinkedHashMap<String, LdBlackActionCQ>(); }
            String key = "subQueryMapKey" + (_blackListId_ExistsSubQuery_BlackActionListMap.size() + 1);
            _blackListId_ExistsSubQuery_BlackActionListMap.put(key, subQuery); return "BlackListId_ExistsSubQuery_BlackActionList." + key;
        }

        protected Map<String, LdBlackActionCQ> _blackListId_NotExistsSubQuery_BlackActionListMap;
        public Map<String, LdBlackActionCQ> BlackListId_NotExistsSubQuery_BlackActionList { get { return _blackListId_NotExistsSubQuery_BlackActionListMap; }}
        public override String keepBlackListId_NotExistsSubQuery_BlackActionList(LdBlackActionCQ subQuery) {
            if (_blackListId_NotExistsSubQuery_BlackActionListMap == null) { _blackListId_NotExistsSubQuery_BlackActionListMap = new LinkedHashMap<String, LdBlackActionCQ>(); }
            String key = "subQueryMapKey" + (_blackListId_NotExistsSubQuery_BlackActionListMap.size() + 1);
            _blackListId_NotExistsSubQuery_BlackActionListMap.put(key, subQuery); return "BlackListId_NotExistsSubQuery_BlackActionList." + key;
        }

        protected Map<String, LdBlackActionCQ> _blackListId_InScopeSubQuery_BlackActionListMap;
        public Map<String, LdBlackActionCQ> BlackListId_InScopeSubQuery_BlackActionList { get { return _blackListId_InScopeSubQuery_BlackActionListMap; }}
        public override String keepBlackListId_InScopeSubQuery_BlackActionList(LdBlackActionCQ subQuery) {
            if (_blackListId_InScopeSubQuery_BlackActionListMap == null) { _blackListId_InScopeSubQuery_BlackActionListMap = new LinkedHashMap<String, LdBlackActionCQ>(); }
            String key = "subQueryMapKey" + (_blackListId_InScopeSubQuery_BlackActionListMap.size() + 1);
            _blackListId_InScopeSubQuery_BlackActionListMap.put(key, subQuery); return "BlackListId_InScopeSubQuery_BlackActionList." + key;
        }

        protected Map<String, LdBlackActionCQ> _blackListId_NotInScopeSubQuery_BlackActionListMap;
        public Map<String, LdBlackActionCQ> BlackListId_NotInScopeSubQuery_BlackActionList { get { return _blackListId_NotInScopeSubQuery_BlackActionListMap; }}
        public override String keepBlackListId_NotInScopeSubQuery_BlackActionList(LdBlackActionCQ subQuery) {
            if (_blackListId_NotInScopeSubQuery_BlackActionListMap == null) { _blackListId_NotInScopeSubQuery_BlackActionListMap = new LinkedHashMap<String, LdBlackActionCQ>(); }
            String key = "subQueryMapKey" + (_blackListId_NotInScopeSubQuery_BlackActionListMap.size() + 1);
            _blackListId_NotInScopeSubQuery_BlackActionListMap.put(key, subQuery); return "BlackListId_NotInScopeSubQuery_BlackActionList." + key;
        }

        protected Map<String, LdBlackActionCQ> _blackListId_SpecifyDerivedReferrer_BlackActionListMap;
        public Map<String, LdBlackActionCQ> BlackListId_SpecifyDerivedReferrer_BlackActionList { get { return _blackListId_SpecifyDerivedReferrer_BlackActionListMap; }}
        public override String keepBlackListId_SpecifyDerivedReferrer_BlackActionList(LdBlackActionCQ subQuery) {
            if (_blackListId_SpecifyDerivedReferrer_BlackActionListMap == null) { _blackListId_SpecifyDerivedReferrer_BlackActionListMap = new LinkedHashMap<String, LdBlackActionCQ>(); }
            String key = "subQueryMapKey" + (_blackListId_SpecifyDerivedReferrer_BlackActionListMap.size() + 1);
            _blackListId_SpecifyDerivedReferrer_BlackActionListMap.put(key, subQuery); return "BlackListId_SpecifyDerivedReferrer_BlackActionList." + key;
        }

        protected Map<String, LdBlackActionCQ> _blackListId_QueryDerivedReferrer_BlackActionListMap;
        public Map<String, LdBlackActionCQ> BlackListId_QueryDerivedReferrer_BlackActionList { get { return _blackListId_QueryDerivedReferrer_BlackActionListMap; } }
        public override String keepBlackListId_QueryDerivedReferrer_BlackActionList(LdBlackActionCQ subQuery) {
            if (_blackListId_QueryDerivedReferrer_BlackActionListMap == null) { _blackListId_QueryDerivedReferrer_BlackActionListMap = new LinkedHashMap<String, LdBlackActionCQ>(); }
            String key = "subQueryMapKey" + (_blackListId_QueryDerivedReferrer_BlackActionListMap.size() + 1);
            _blackListId_QueryDerivedReferrer_BlackActionListMap.put(key, subQuery); return "BlackListId_QueryDerivedReferrer_BlackActionList." + key;
        }
        protected Map<String, Object> _blackListId_QueryDerivedReferrer_BlackActionListParameterMap;
        public Map<String, Object> BlackListId_QueryDerivedReferrer_BlackActionListParameter { get { return _blackListId_QueryDerivedReferrer_BlackActionListParameterMap; } }
        public override String keepBlackListId_QueryDerivedReferrer_BlackActionListParameter(Object parameterValue) {
            if (_blackListId_QueryDerivedReferrer_BlackActionListParameterMap == null) { _blackListId_QueryDerivedReferrer_BlackActionListParameterMap = new LinkedHashMap<String, Object>(); }
            String key = "subQueryParameterKey" + (_blackListId_QueryDerivedReferrer_BlackActionListParameterMap.size() + 1);
            _blackListId_QueryDerivedReferrer_BlackActionListParameterMap.put(key, parameterValue); return "BlackListId_QueryDerivedReferrer_BlackActionListParameter." + key;
        }

        public LdBsBlackListCQ AddOrderBy_BlackListId_Asc() { regOBA("BLACK_LIST_ID");return this; }
        public LdBsBlackListCQ AddOrderBy_BlackListId_Desc() { regOBD("BLACK_LIST_ID");return this; }

        protected LdConditionValue _lbUserId;
        public LdConditionValue LbUserId {
            get { if (_lbUserId == null) { _lbUserId = new LdConditionValue(); } return _lbUserId; }
        }
        protected override LdConditionValue getCValueLbUserId() { return this.LbUserId; }


        protected Map<String, LdLbUserCQ> _lbUserId_InScopeSubQuery_LbUserMap;
        public Map<String, LdLbUserCQ> LbUserId_InScopeSubQuery_LbUser { get { return _lbUserId_InScopeSubQuery_LbUserMap; }}
        public override String keepLbUserId_InScopeSubQuery_LbUser(LdLbUserCQ subQuery) {
            if (_lbUserId_InScopeSubQuery_LbUserMap == null) { _lbUserId_InScopeSubQuery_LbUserMap = new LinkedHashMap<String, LdLbUserCQ>(); }
            String key = "subQueryMapKey" + (_lbUserId_InScopeSubQuery_LbUserMap.size() + 1);
            _lbUserId_InScopeSubQuery_LbUserMap.put(key, subQuery); return "LbUserId_InScopeSubQuery_LbUser." + key;
        }

        protected Map<String, LdLbUserCQ> _lbUserId_NotInScopeSubQuery_LbUserMap;
        public Map<String, LdLbUserCQ> LbUserId_NotInScopeSubQuery_LbUser { get { return _lbUserId_NotInScopeSubQuery_LbUserMap; }}
        public override String keepLbUserId_NotInScopeSubQuery_LbUser(LdLbUserCQ subQuery) {
            if (_lbUserId_NotInScopeSubQuery_LbUserMap == null) { _lbUserId_NotInScopeSubQuery_LbUserMap = new LinkedHashMap<String, LdLbUserCQ>(); }
            String key = "subQueryMapKey" + (_lbUserId_NotInScopeSubQuery_LbUserMap.size() + 1);
            _lbUserId_NotInScopeSubQuery_LbUserMap.put(key, subQuery); return "LbUserId_NotInScopeSubQuery_LbUser." + key;
        }

        public LdBsBlackListCQ AddOrderBy_LbUserId_Asc() { regOBA("LB_USER_ID");return this; }
        public LdBsBlackListCQ AddOrderBy_LbUserId_Desc() { regOBD("LB_USER_ID");return this; }

        protected LdConditionValue _blackRank;
        public LdConditionValue BlackRank {
            get { if (_blackRank == null) { _blackRank = new LdConditionValue(); } return _blackRank; }
        }
        protected override LdConditionValue getCValueBlackRank() { return this.BlackRank; }


        public LdBsBlackListCQ AddOrderBy_BlackRank_Asc() { regOBA("BLACK_RANK");return this; }
        public LdBsBlackListCQ AddOrderBy_BlackRank_Desc() { regOBD("BLACK_RANK");return this; }

        protected LdConditionValue _rUser;
        public LdConditionValue RUser {
            get { if (_rUser == null) { _rUser = new LdConditionValue(); } return _rUser; }
        }
        protected override LdConditionValue getCValueRUser() { return this.RUser; }


        public LdBsBlackListCQ AddOrderBy_RUser_Asc() { regOBA("R_USER");return this; }
        public LdBsBlackListCQ AddOrderBy_RUser_Desc() { regOBD("R_USER");return this; }

        protected LdConditionValue _rModule;
        public LdConditionValue RModule {
            get { if (_rModule == null) { _rModule = new LdConditionValue(); } return _rModule; }
        }
        protected override LdConditionValue getCValueRModule() { return this.RModule; }


        public LdBsBlackListCQ AddOrderBy_RModule_Asc() { regOBA("R_MODULE");return this; }
        public LdBsBlackListCQ AddOrderBy_RModule_Desc() { regOBD("R_MODULE");return this; }

        protected LdConditionValue _rTimestamp;
        public LdConditionValue RTimestamp {
            get { if (_rTimestamp == null) { _rTimestamp = new LdConditionValue(); } return _rTimestamp; }
        }
        protected override LdConditionValue getCValueRTimestamp() { return this.RTimestamp; }


        public LdBsBlackListCQ AddOrderBy_RTimestamp_Asc() { regOBA("R_TIMESTAMP");return this; }
        public LdBsBlackListCQ AddOrderBy_RTimestamp_Desc() { regOBD("R_TIMESTAMP");return this; }

        protected LdConditionValue _uUser;
        public LdConditionValue UUser {
            get { if (_uUser == null) { _uUser = new LdConditionValue(); } return _uUser; }
        }
        protected override LdConditionValue getCValueUUser() { return this.UUser; }


        public LdBsBlackListCQ AddOrderBy_UUser_Asc() { regOBA("U_USER");return this; }
        public LdBsBlackListCQ AddOrderBy_UUser_Desc() { regOBD("U_USER");return this; }

        protected LdConditionValue _uModule;
        public LdConditionValue UModule {
            get { if (_uModule == null) { _uModule = new LdConditionValue(); } return _uModule; }
        }
        protected override LdConditionValue getCValueUModule() { return this.UModule; }


        public LdBsBlackListCQ AddOrderBy_UModule_Asc() { regOBA("U_MODULE");return this; }
        public LdBsBlackListCQ AddOrderBy_UModule_Desc() { regOBD("U_MODULE");return this; }

        protected LdConditionValue _uTimestamp;
        public LdConditionValue UTimestamp {
            get { if (_uTimestamp == null) { _uTimestamp = new LdConditionValue(); } return _uTimestamp; }
        }
        protected override LdConditionValue getCValueUTimestamp() { return this.UTimestamp; }


        public LdBsBlackListCQ AddOrderBy_UTimestamp_Asc() { regOBA("U_TIMESTAMP");return this; }
        public LdBsBlackListCQ AddOrderBy_UTimestamp_Desc() { regOBD("U_TIMESTAMP");return this; }

        public LdBsBlackListCQ AddSpecifiedDerivedOrderBy_Asc(String aliasName) { registerSpecifiedDerivedOrderBy_Asc(aliasName); return this; }
        public LdBsBlackListCQ AddSpecifiedDerivedOrderBy_Desc(String aliasName) { registerSpecifiedDerivedOrderBy_Desc(aliasName); return this; }

        public override void reflectRelationOnUnionQuery(LdConditionQuery baseQueryAsSuper, LdConditionQuery unionQueryAsSuper) {
            LdBlackListCQ baseQuery = (LdBlackListCQ)baseQueryAsSuper;
            LdBlackListCQ unionQuery = (LdBlackListCQ)unionQueryAsSuper;
            if (baseQuery.hasConditionQueryLbUser()) {
                unionQuery.QueryLbUser().reflectRelationOnUnionQuery(baseQuery.QueryLbUser(), unionQuery.QueryLbUser());
            }

        }
    
        protected LdLbUserCQ _conditionQueryLbUser;
        public LdLbUserCQ QueryLbUser() {
            return this.ConditionQueryLbUser;
        }
        public LdLbUserCQ ConditionQueryLbUser {
            get {
                if (_conditionQueryLbUser == null) {
                    _conditionQueryLbUser = xcreateQueryLbUser();
                    xsetupOuterJoin_LbUser();
                }
                return _conditionQueryLbUser;
            }
        }
        protected LdLbUserCQ xcreateQueryLbUser() {
            String nrp = resolveNextRelationPathLbUser();
            String jan = resolveJoinAliasName(nrp, xgetNextNestLevel());
            LdLbUserCQ cq = new LdLbUserCQ(this, xgetSqlClause(), jan, xgetNextNestLevel());
            cq.xsetForeignPropertyName("lbUser"); cq.xsetRelationPath(nrp); return cq;
        }
        public void xsetupOuterJoin_LbUser() {
            LdLbUserCQ cq = ConditionQueryLbUser;
            Map<String, String> joinOnMap = new LinkedHashMap<String, String>();
            joinOnMap.put("LB_USER_ID", "LB_USER_ID");
            registerOuterJoin(cq, joinOnMap);
        }
        protected String resolveNextRelationPathLbUser() {
            return resolveNextRelationPath("black_list", "lbUser");
        }
        public bool hasConditionQueryLbUser() {
            return _conditionQueryLbUser != null;
        }


	    // ===============================================================================
	    //                                                                 Scalar SubQuery
	    //                                                                 ===============
	    protected Map<String, LdBlackListCQ> _scalarSubQueryMap;
	    public Map<String, LdBlackListCQ> ScalarSubQuery { get { return _scalarSubQueryMap; } }
	    public override String keepScalarSubQuery(LdBlackListCQ subQuery) {
	        if (_scalarSubQueryMap == null) { _scalarSubQueryMap = new LinkedHashMap<String, LdBlackListCQ>(); }
	        String key = "subQueryMapKey" + (_scalarSubQueryMap.size() + 1);
	        _scalarSubQueryMap.put(key, subQuery); return "ScalarSubQuery." + key;
	    }

        // ===============================================================================
        //                                                         Myself InScope SubQuery
        //                                                         =======================
        protected Map<String, LdBlackListCQ> _myselfInScopeSubQueryMap;
        public Map<String, LdBlackListCQ> MyselfInScopeSubQuery { get { return _myselfInScopeSubQueryMap; } }
        public override String keepMyselfInScopeSubQuery(LdBlackListCQ subQuery) {
            if (_myselfInScopeSubQueryMap == null) { _myselfInScopeSubQueryMap = new LinkedHashMap<String, LdBlackListCQ>(); }
            String key = "subQueryMapKey" + (_myselfInScopeSubQueryMap.size() + 1);
            _myselfInScopeSubQueryMap.put(key, subQuery); return "MyselfInScopeSubQuery." + key;
        }
    }
}
