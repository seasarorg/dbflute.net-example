
using System;

using DfExample.DBFlute.LibraryDb.AllCommon.CBean;
using DfExample.DBFlute.LibraryDb.AllCommon.CBean.CValue;
using DfExample.DBFlute.LibraryDb.AllCommon.CBean.SClause;
using DfExample.DBFlute.LibraryDb.AllCommon.JavaLike;
using DfExample.DBFlute.LibraryDb.CBean.CQ;
using DfExample.DBFlute.LibraryDb.CBean.CQ.Ciq;

namespace DfExample.DBFlute.LibraryDb.CBean.CQ.BS {

    [System.Serializable]
    public class LdBsLbUserCQ : LdAbstractBsLbUserCQ {

        protected LdLbUserCIQ _inlineQuery;

        public LdBsLbUserCQ(LdConditionQuery childQuery, LdSqlClause sqlClause, String aliasName, int nestLevel)
            : base(childQuery, sqlClause, aliasName, nestLevel) {}

        public LdLbUserCIQ Inline() {
            if (_inlineQuery == null) {
                _inlineQuery = new LdLbUserCIQ(xgetReferrerQuery(), xgetSqlClause(), xgetAliasName(), xgetNestLevel(), this);
            }
            _inlineQuery.xsetOnClause(false);
            return _inlineQuery;
        }
        
        public LdLbUserCIQ On() {
            if (isBaseQuery()) { throw new UnsupportedOperationException("Unsupported onClause of Base Table!"); }
            LdLbUserCIQ inlineQuery = Inline();
            inlineQuery.xsetOnClause(true);
            return inlineQuery;
        }


        protected LdConditionValue _lbUserId;
        public LdConditionValue LbUserId {
            get { if (_lbUserId == null) { _lbUserId = new LdConditionValue(); } return _lbUserId; }
        }
        protected override LdConditionValue getCValueLbUserId() { return this.LbUserId; }


        protected Map<String, LdBlackListCQ> _lbUserId_ExistsSubQuery_BlackListAsOneMap;
        public Map<String, LdBlackListCQ> LbUserId_ExistsSubQuery_BlackListAsOne { get { return _lbUserId_ExistsSubQuery_BlackListAsOneMap; }}
        public override String keepLbUserId_ExistsSubQuery_BlackListAsOne(LdBlackListCQ subQuery) {
            if (_lbUserId_ExistsSubQuery_BlackListAsOneMap == null) { _lbUserId_ExistsSubQuery_BlackListAsOneMap = new LinkedHashMap<String, LdBlackListCQ>(); }
            String key = "subQueryMapKey" + (_lbUserId_ExistsSubQuery_BlackListAsOneMap.size() + 1);
            _lbUserId_ExistsSubQuery_BlackListAsOneMap.put(key, subQuery); return "LbUserId_ExistsSubQuery_BlackListAsOne." + key;
        }

        protected Map<String, LdLibraryUserCQ> _lbUserId_ExistsSubQuery_LibraryUserListMap;
        public Map<String, LdLibraryUserCQ> LbUserId_ExistsSubQuery_LibraryUserList { get { return _lbUserId_ExistsSubQuery_LibraryUserListMap; }}
        public override String keepLbUserId_ExistsSubQuery_LibraryUserList(LdLibraryUserCQ subQuery) {
            if (_lbUserId_ExistsSubQuery_LibraryUserListMap == null) { _lbUserId_ExistsSubQuery_LibraryUserListMap = new LinkedHashMap<String, LdLibraryUserCQ>(); }
            String key = "subQueryMapKey" + (_lbUserId_ExistsSubQuery_LibraryUserListMap.size() + 1);
            _lbUserId_ExistsSubQuery_LibraryUserListMap.put(key, subQuery); return "LbUserId_ExistsSubQuery_LibraryUserList." + key;
        }

        protected Map<String, LdBlackListCQ> _lbUserId_NotExistsSubQuery_BlackListAsOneMap;
        public Map<String, LdBlackListCQ> LbUserId_NotExistsSubQuery_BlackListAsOne { get { return _lbUserId_NotExistsSubQuery_BlackListAsOneMap; }}
        public override String keepLbUserId_NotExistsSubQuery_BlackListAsOne(LdBlackListCQ subQuery) {
            if (_lbUserId_NotExistsSubQuery_BlackListAsOneMap == null) { _lbUserId_NotExistsSubQuery_BlackListAsOneMap = new LinkedHashMap<String, LdBlackListCQ>(); }
            String key = "subQueryMapKey" + (_lbUserId_NotExistsSubQuery_BlackListAsOneMap.size() + 1);
            _lbUserId_NotExistsSubQuery_BlackListAsOneMap.put(key, subQuery); return "LbUserId_NotExistsSubQuery_BlackListAsOne." + key;
        }

        protected Map<String, LdLibraryUserCQ> _lbUserId_NotExistsSubQuery_LibraryUserListMap;
        public Map<String, LdLibraryUserCQ> LbUserId_NotExistsSubQuery_LibraryUserList { get { return _lbUserId_NotExistsSubQuery_LibraryUserListMap; }}
        public override String keepLbUserId_NotExistsSubQuery_LibraryUserList(LdLibraryUserCQ subQuery) {
            if (_lbUserId_NotExistsSubQuery_LibraryUserListMap == null) { _lbUserId_NotExistsSubQuery_LibraryUserListMap = new LinkedHashMap<String, LdLibraryUserCQ>(); }
            String key = "subQueryMapKey" + (_lbUserId_NotExistsSubQuery_LibraryUserListMap.size() + 1);
            _lbUserId_NotExistsSubQuery_LibraryUserListMap.put(key, subQuery); return "LbUserId_NotExistsSubQuery_LibraryUserList." + key;
        }

        protected Map<String, LdBlackListCQ> _lbUserId_InScopeSubQuery_BlackListAsOneMap;
        public Map<String, LdBlackListCQ> LbUserId_InScopeSubQuery_BlackListAsOne { get { return _lbUserId_InScopeSubQuery_BlackListAsOneMap; }}
        public override String keepLbUserId_InScopeSubQuery_BlackListAsOne(LdBlackListCQ subQuery) {
            if (_lbUserId_InScopeSubQuery_BlackListAsOneMap == null) { _lbUserId_InScopeSubQuery_BlackListAsOneMap = new LinkedHashMap<String, LdBlackListCQ>(); }
            String key = "subQueryMapKey" + (_lbUserId_InScopeSubQuery_BlackListAsOneMap.size() + 1);
            _lbUserId_InScopeSubQuery_BlackListAsOneMap.put(key, subQuery); return "LbUserId_InScopeSubQuery_BlackListAsOne." + key;
        }

        protected Map<String, LdLibraryUserCQ> _lbUserId_InScopeSubQuery_LibraryUserListMap;
        public Map<String, LdLibraryUserCQ> LbUserId_InScopeSubQuery_LibraryUserList { get { return _lbUserId_InScopeSubQuery_LibraryUserListMap; }}
        public override String keepLbUserId_InScopeSubQuery_LibraryUserList(LdLibraryUserCQ subQuery) {
            if (_lbUserId_InScopeSubQuery_LibraryUserListMap == null) { _lbUserId_InScopeSubQuery_LibraryUserListMap = new LinkedHashMap<String, LdLibraryUserCQ>(); }
            String key = "subQueryMapKey" + (_lbUserId_InScopeSubQuery_LibraryUserListMap.size() + 1);
            _lbUserId_InScopeSubQuery_LibraryUserListMap.put(key, subQuery); return "LbUserId_InScopeSubQuery_LibraryUserList." + key;
        }

        protected Map<String, LdBlackListCQ> _lbUserId_NotInScopeSubQuery_BlackListAsOneMap;
        public Map<String, LdBlackListCQ> LbUserId_NotInScopeSubQuery_BlackListAsOne { get { return _lbUserId_NotInScopeSubQuery_BlackListAsOneMap; }}
        public override String keepLbUserId_NotInScopeSubQuery_BlackListAsOne(LdBlackListCQ subQuery) {
            if (_lbUserId_NotInScopeSubQuery_BlackListAsOneMap == null) { _lbUserId_NotInScopeSubQuery_BlackListAsOneMap = new LinkedHashMap<String, LdBlackListCQ>(); }
            String key = "subQueryMapKey" + (_lbUserId_NotInScopeSubQuery_BlackListAsOneMap.size() + 1);
            _lbUserId_NotInScopeSubQuery_BlackListAsOneMap.put(key, subQuery); return "LbUserId_NotInScopeSubQuery_BlackListAsOne." + key;
        }

        protected Map<String, LdLibraryUserCQ> _lbUserId_NotInScopeSubQuery_LibraryUserListMap;
        public Map<String, LdLibraryUserCQ> LbUserId_NotInScopeSubQuery_LibraryUserList { get { return _lbUserId_NotInScopeSubQuery_LibraryUserListMap; }}
        public override String keepLbUserId_NotInScopeSubQuery_LibraryUserList(LdLibraryUserCQ subQuery) {
            if (_lbUserId_NotInScopeSubQuery_LibraryUserListMap == null) { _lbUserId_NotInScopeSubQuery_LibraryUserListMap = new LinkedHashMap<String, LdLibraryUserCQ>(); }
            String key = "subQueryMapKey" + (_lbUserId_NotInScopeSubQuery_LibraryUserListMap.size() + 1);
            _lbUserId_NotInScopeSubQuery_LibraryUserListMap.put(key, subQuery); return "LbUserId_NotInScopeSubQuery_LibraryUserList." + key;
        }

        protected Map<String, LdLibraryUserCQ> _lbUserId_SpecifyDerivedReferrer_LibraryUserListMap;
        public Map<String, LdLibraryUserCQ> LbUserId_SpecifyDerivedReferrer_LibraryUserList { get { return _lbUserId_SpecifyDerivedReferrer_LibraryUserListMap; }}
        public override String keepLbUserId_SpecifyDerivedReferrer_LibraryUserList(LdLibraryUserCQ subQuery) {
            if (_lbUserId_SpecifyDerivedReferrer_LibraryUserListMap == null) { _lbUserId_SpecifyDerivedReferrer_LibraryUserListMap = new LinkedHashMap<String, LdLibraryUserCQ>(); }
            String key = "subQueryMapKey" + (_lbUserId_SpecifyDerivedReferrer_LibraryUserListMap.size() + 1);
            _lbUserId_SpecifyDerivedReferrer_LibraryUserListMap.put(key, subQuery); return "LbUserId_SpecifyDerivedReferrer_LibraryUserList." + key;
        }

        protected Map<String, LdLibraryUserCQ> _lbUserId_QueryDerivedReferrer_LibraryUserListMap;
        public Map<String, LdLibraryUserCQ> LbUserId_QueryDerivedReferrer_LibraryUserList { get { return _lbUserId_QueryDerivedReferrer_LibraryUserListMap; } }
        public override String keepLbUserId_QueryDerivedReferrer_LibraryUserList(LdLibraryUserCQ subQuery) {
            if (_lbUserId_QueryDerivedReferrer_LibraryUserListMap == null) { _lbUserId_QueryDerivedReferrer_LibraryUserListMap = new LinkedHashMap<String, LdLibraryUserCQ>(); }
            String key = "subQueryMapKey" + (_lbUserId_QueryDerivedReferrer_LibraryUserListMap.size() + 1);
            _lbUserId_QueryDerivedReferrer_LibraryUserListMap.put(key, subQuery); return "LbUserId_QueryDerivedReferrer_LibraryUserList." + key;
        }
        protected Map<String, Object> _lbUserId_QueryDerivedReferrer_LibraryUserListParameterMap;
        public Map<String, Object> LbUserId_QueryDerivedReferrer_LibraryUserListParameter { get { return _lbUserId_QueryDerivedReferrer_LibraryUserListParameterMap; } }
        public override String keepLbUserId_QueryDerivedReferrer_LibraryUserListParameter(Object parameterValue) {
            if (_lbUserId_QueryDerivedReferrer_LibraryUserListParameterMap == null) { _lbUserId_QueryDerivedReferrer_LibraryUserListParameterMap = new LinkedHashMap<String, Object>(); }
            String key = "subQueryParameterKey" + (_lbUserId_QueryDerivedReferrer_LibraryUserListParameterMap.size() + 1);
            _lbUserId_QueryDerivedReferrer_LibraryUserListParameterMap.put(key, parameterValue); return "LbUserId_QueryDerivedReferrer_LibraryUserListParameter." + key;
        }

        public LdBsLbUserCQ AddOrderBy_LbUserId_Asc() { regOBA("LB_USER_ID");return this; }
        public LdBsLbUserCQ AddOrderBy_LbUserId_Desc() { regOBD("LB_USER_ID");return this; }

        protected LdConditionValue _lbUserName;
        public LdConditionValue LbUserName {
            get { if (_lbUserName == null) { _lbUserName = new LdConditionValue(); } return _lbUserName; }
        }
        protected override LdConditionValue getCValueLbUserName() { return this.LbUserName; }


        public LdBsLbUserCQ AddOrderBy_LbUserName_Asc() { regOBA("LB_USER_NAME");return this; }
        public LdBsLbUserCQ AddOrderBy_LbUserName_Desc() { regOBD("LB_USER_NAME");return this; }

        protected LdConditionValue _userPassword;
        public LdConditionValue UserPassword {
            get { if (_userPassword == null) { _userPassword = new LdConditionValue(); } return _userPassword; }
        }
        protected override LdConditionValue getCValueUserPassword() { return this.UserPassword; }


        public LdBsLbUserCQ AddOrderBy_UserPassword_Asc() { regOBA("USER_PASSWORD");return this; }
        public LdBsLbUserCQ AddOrderBy_UserPassword_Desc() { regOBD("USER_PASSWORD");return this; }

        protected LdConditionValue _rUser;
        public LdConditionValue RUser {
            get { if (_rUser == null) { _rUser = new LdConditionValue(); } return _rUser; }
        }
        protected override LdConditionValue getCValueRUser() { return this.RUser; }


        public LdBsLbUserCQ AddOrderBy_RUser_Asc() { regOBA("R_USER");return this; }
        public LdBsLbUserCQ AddOrderBy_RUser_Desc() { regOBD("R_USER");return this; }

        protected LdConditionValue _rModule;
        public LdConditionValue RModule {
            get { if (_rModule == null) { _rModule = new LdConditionValue(); } return _rModule; }
        }
        protected override LdConditionValue getCValueRModule() { return this.RModule; }


        public LdBsLbUserCQ AddOrderBy_RModule_Asc() { regOBA("R_MODULE");return this; }
        public LdBsLbUserCQ AddOrderBy_RModule_Desc() { regOBD("R_MODULE");return this; }

        protected LdConditionValue _rTimestamp;
        public LdConditionValue RTimestamp {
            get { if (_rTimestamp == null) { _rTimestamp = new LdConditionValue(); } return _rTimestamp; }
        }
        protected override LdConditionValue getCValueRTimestamp() { return this.RTimestamp; }


        public LdBsLbUserCQ AddOrderBy_RTimestamp_Asc() { regOBA("R_TIMESTAMP");return this; }
        public LdBsLbUserCQ AddOrderBy_RTimestamp_Desc() { regOBD("R_TIMESTAMP");return this; }

        protected LdConditionValue _uUser;
        public LdConditionValue UUser {
            get { if (_uUser == null) { _uUser = new LdConditionValue(); } return _uUser; }
        }
        protected override LdConditionValue getCValueUUser() { return this.UUser; }


        public LdBsLbUserCQ AddOrderBy_UUser_Asc() { regOBA("U_USER");return this; }
        public LdBsLbUserCQ AddOrderBy_UUser_Desc() { regOBD("U_USER");return this; }

        protected LdConditionValue _uModule;
        public LdConditionValue UModule {
            get { if (_uModule == null) { _uModule = new LdConditionValue(); } return _uModule; }
        }
        protected override LdConditionValue getCValueUModule() { return this.UModule; }


        public LdBsLbUserCQ AddOrderBy_UModule_Asc() { regOBA("U_MODULE");return this; }
        public LdBsLbUserCQ AddOrderBy_UModule_Desc() { regOBD("U_MODULE");return this; }

        protected LdConditionValue _uTimestamp;
        public LdConditionValue UTimestamp {
            get { if (_uTimestamp == null) { _uTimestamp = new LdConditionValue(); } return _uTimestamp; }
        }
        protected override LdConditionValue getCValueUTimestamp() { return this.UTimestamp; }


        public LdBsLbUserCQ AddOrderBy_UTimestamp_Asc() { regOBA("U_TIMESTAMP");return this; }
        public LdBsLbUserCQ AddOrderBy_UTimestamp_Desc() { regOBD("U_TIMESTAMP");return this; }

        public LdBsLbUserCQ AddSpecifiedDerivedOrderBy_Asc(String aliasName) { registerSpecifiedDerivedOrderBy_Asc(aliasName); return this; }
        public LdBsLbUserCQ AddSpecifiedDerivedOrderBy_Desc(String aliasName) { registerSpecifiedDerivedOrderBy_Desc(aliasName); return this; }

        public override void reflectRelationOnUnionQuery(LdConditionQuery baseQueryAsSuper, LdConditionQuery unionQueryAsSuper) {
            LdLbUserCQ baseQuery = (LdLbUserCQ)baseQueryAsSuper;
            LdLbUserCQ unionQuery = (LdLbUserCQ)unionQueryAsSuper;
            if (baseQuery.hasConditionQueryBlackListAsOne()) {
                unionQuery.QueryBlackListAsOne().reflectRelationOnUnionQuery(baseQuery.QueryBlackListAsOne(), unionQuery.QueryBlackListAsOne());
            }

        }
    


        protected LdBlackListCQ _conditionQueryBlackListAsOne;
        public LdBlackListCQ ConditionQueryBlackListAsOne {
            get {
                if (_conditionQueryBlackListAsOne == null) {
                    _conditionQueryBlackListAsOne = createQueryBlackListAsOne();
                    xsetupOuterJoin_BlackListAsOne();
                }
                return _conditionQueryBlackListAsOne;
            }
        }
        public LdBlackListCQ QueryBlackListAsOne() { return this.ConditionQueryBlackListAsOne; }
        protected LdBlackListCQ createQueryBlackListAsOne() {
            String nrp = resolveNextRelationPathBlackListAsOne();
            String jan = resolveJoinAliasName(nrp, xgetNextNestLevel());
            LdBlackListCQ cq = new LdBlackListCQ(this, xgetSqlClause(), jan, xgetNextNestLevel());
            cq.xsetForeignPropertyName("blackListAsOne"); cq.xsetRelationPath(nrp); return cq;
        }
        public void xsetupOuterJoin_BlackListAsOne() {
            LdBlackListCQ cq = ConditionQueryBlackListAsOne;
            Map<String, String> joinOnMap = new LinkedHashMap<String, String>();
            joinOnMap.put("LB_USER_ID", "LB_USER_ID");
            registerOuterJoin(cq, joinOnMap);
        }
        protected String resolveNextRelationPathBlackListAsOne() {
            return resolveNextRelationPath("lb_user", "blackListAsOne");
        }
        public bool hasConditionQueryBlackListAsOne() {
            return _conditionQueryBlackListAsOne != null;
        }

	    // ===============================================================================
	    //                                                                 Scalar SubQuery
	    //                                                                 ===============
	    protected Map<String, LdLbUserCQ> _scalarSubQueryMap;
	    public Map<String, LdLbUserCQ> ScalarSubQuery { get { return _scalarSubQueryMap; } }
	    public override String keepScalarSubQuery(LdLbUserCQ subQuery) {
	        if (_scalarSubQueryMap == null) { _scalarSubQueryMap = new LinkedHashMap<String, LdLbUserCQ>(); }
	        String key = "subQueryMapKey" + (_scalarSubQueryMap.size() + 1);
	        _scalarSubQueryMap.put(key, subQuery); return "ScalarSubQuery." + key;
	    }

        // ===============================================================================
        //                                                         Myself InScope SubQuery
        //                                                         =======================
        protected Map<String, LdLbUserCQ> _myselfInScopeSubQueryMap;
        public Map<String, LdLbUserCQ> MyselfInScopeSubQuery { get { return _myselfInScopeSubQueryMap; } }
        public override String keepMyselfInScopeSubQuery(LdLbUserCQ subQuery) {
            if (_myselfInScopeSubQueryMap == null) { _myselfInScopeSubQueryMap = new LinkedHashMap<String, LdLbUserCQ>(); }
            String key = "subQueryMapKey" + (_myselfInScopeSubQueryMap.size() + 1);
            _myselfInScopeSubQueryMap.put(key, subQuery); return "MyselfInScopeSubQuery." + key;
        }
    }
}
