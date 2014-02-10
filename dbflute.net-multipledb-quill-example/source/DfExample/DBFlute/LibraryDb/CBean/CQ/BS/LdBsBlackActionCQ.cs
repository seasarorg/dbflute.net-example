
using System;

using DfExample.DBFlute.LibraryDb.AllCommon.CBean;
using DfExample.DBFlute.LibraryDb.AllCommon.CBean.CValue;
using DfExample.DBFlute.LibraryDb.AllCommon.CBean.SClause;
using DfExample.DBFlute.LibraryDb.AllCommon.JavaLike;
using DfExample.DBFlute.LibraryDb.CBean.CQ;
using DfExample.DBFlute.LibraryDb.CBean.CQ.Ciq;

namespace DfExample.DBFlute.LibraryDb.CBean.CQ.BS {

    [System.Serializable]
    public class LdBsBlackActionCQ : LdAbstractBsBlackActionCQ {

        protected LdBlackActionCIQ _inlineQuery;

        public LdBsBlackActionCQ(LdConditionQuery childQuery, LdSqlClause sqlClause, String aliasName, int nestLevel)
            : base(childQuery, sqlClause, aliasName, nestLevel) {}

        public LdBlackActionCIQ Inline() {
            if (_inlineQuery == null) {
                _inlineQuery = new LdBlackActionCIQ(xgetReferrerQuery(), xgetSqlClause(), xgetAliasName(), xgetNestLevel(), this);
            }
            _inlineQuery.xsetOnClause(false);
            return _inlineQuery;
        }
        
        public LdBlackActionCIQ On() {
            if (isBaseQuery()) { throw new UnsupportedOperationException("Unsupported onClause of Base Table!"); }
            LdBlackActionCIQ inlineQuery = Inline();
            inlineQuery.xsetOnClause(true);
            return inlineQuery;
        }


        protected LdConditionValue _blackActionId;
        public LdConditionValue BlackActionId {
            get { if (_blackActionId == null) { _blackActionId = new LdConditionValue(); } return _blackActionId; }
        }
        protected override LdConditionValue getCValueBlackActionId() { return this.BlackActionId; }


        public LdBsBlackActionCQ AddOrderBy_BlackActionId_Asc() { regOBA("BLACK_ACTION_ID");return this; }
        public LdBsBlackActionCQ AddOrderBy_BlackActionId_Desc() { regOBD("BLACK_ACTION_ID");return this; }

        protected LdConditionValue _blackListId;
        public LdConditionValue BlackListId {
            get { if (_blackListId == null) { _blackListId = new LdConditionValue(); } return _blackListId; }
        }
        protected override LdConditionValue getCValueBlackListId() { return this.BlackListId; }


        protected Map<String, LdBlackListCQ> _blackListId_InScopeSubQuery_BlackListMap;
        public Map<String, LdBlackListCQ> BlackListId_InScopeSubQuery_BlackList { get { return _blackListId_InScopeSubQuery_BlackListMap; }}
        public override String keepBlackListId_InScopeSubQuery_BlackList(LdBlackListCQ subQuery) {
            if (_blackListId_InScopeSubQuery_BlackListMap == null) { _blackListId_InScopeSubQuery_BlackListMap = new LinkedHashMap<String, LdBlackListCQ>(); }
            String key = "subQueryMapKey" + (_blackListId_InScopeSubQuery_BlackListMap.size() + 1);
            _blackListId_InScopeSubQuery_BlackListMap.put(key, subQuery); return "BlackListId_InScopeSubQuery_BlackList." + key;
        }

        protected Map<String, LdBlackListCQ> _blackListId_NotInScopeSubQuery_BlackListMap;
        public Map<String, LdBlackListCQ> BlackListId_NotInScopeSubQuery_BlackList { get { return _blackListId_NotInScopeSubQuery_BlackListMap; }}
        public override String keepBlackListId_NotInScopeSubQuery_BlackList(LdBlackListCQ subQuery) {
            if (_blackListId_NotInScopeSubQuery_BlackListMap == null) { _blackListId_NotInScopeSubQuery_BlackListMap = new LinkedHashMap<String, LdBlackListCQ>(); }
            String key = "subQueryMapKey" + (_blackListId_NotInScopeSubQuery_BlackListMap.size() + 1);
            _blackListId_NotInScopeSubQuery_BlackListMap.put(key, subQuery); return "BlackListId_NotInScopeSubQuery_BlackList." + key;
        }

        public LdBsBlackActionCQ AddOrderBy_BlackListId_Asc() { regOBA("BLACK_LIST_ID");return this; }
        public LdBsBlackActionCQ AddOrderBy_BlackListId_Desc() { regOBD("BLACK_LIST_ID");return this; }

        protected LdConditionValue _blackActionCode;
        public LdConditionValue BlackActionCode {
            get { if (_blackActionCode == null) { _blackActionCode = new LdConditionValue(); } return _blackActionCode; }
        }
        protected override LdConditionValue getCValueBlackActionCode() { return this.BlackActionCode; }


        protected Map<String, LdBlackActionLookupCQ> _blackActionCode_InScopeSubQuery_BlackActionLookupMap;
        public Map<String, LdBlackActionLookupCQ> BlackActionCode_InScopeSubQuery_BlackActionLookup { get { return _blackActionCode_InScopeSubQuery_BlackActionLookupMap; }}
        public override String keepBlackActionCode_InScopeSubQuery_BlackActionLookup(LdBlackActionLookupCQ subQuery) {
            if (_blackActionCode_InScopeSubQuery_BlackActionLookupMap == null) { _blackActionCode_InScopeSubQuery_BlackActionLookupMap = new LinkedHashMap<String, LdBlackActionLookupCQ>(); }
            String key = "subQueryMapKey" + (_blackActionCode_InScopeSubQuery_BlackActionLookupMap.size() + 1);
            _blackActionCode_InScopeSubQuery_BlackActionLookupMap.put(key, subQuery); return "BlackActionCode_InScopeSubQuery_BlackActionLookup." + key;
        }

        protected Map<String, LdBlackActionLookupCQ> _blackActionCode_NotInScopeSubQuery_BlackActionLookupMap;
        public Map<String, LdBlackActionLookupCQ> BlackActionCode_NotInScopeSubQuery_BlackActionLookup { get { return _blackActionCode_NotInScopeSubQuery_BlackActionLookupMap; }}
        public override String keepBlackActionCode_NotInScopeSubQuery_BlackActionLookup(LdBlackActionLookupCQ subQuery) {
            if (_blackActionCode_NotInScopeSubQuery_BlackActionLookupMap == null) { _blackActionCode_NotInScopeSubQuery_BlackActionLookupMap = new LinkedHashMap<String, LdBlackActionLookupCQ>(); }
            String key = "subQueryMapKey" + (_blackActionCode_NotInScopeSubQuery_BlackActionLookupMap.size() + 1);
            _blackActionCode_NotInScopeSubQuery_BlackActionLookupMap.put(key, subQuery); return "BlackActionCode_NotInScopeSubQuery_BlackActionLookup." + key;
        }

        public LdBsBlackActionCQ AddOrderBy_BlackActionCode_Asc() { regOBA("BLACK_ACTION_CODE");return this; }
        public LdBsBlackActionCQ AddOrderBy_BlackActionCode_Desc() { regOBD("BLACK_ACTION_CODE");return this; }

        protected LdConditionValue _blackLevel;
        public LdConditionValue BlackLevel {
            get { if (_blackLevel == null) { _blackLevel = new LdConditionValue(); } return _blackLevel; }
        }
        protected override LdConditionValue getCValueBlackLevel() { return this.BlackLevel; }


        public LdBsBlackActionCQ AddOrderBy_BlackLevel_Asc() { regOBA("BLACK_LEVEL");return this; }
        public LdBsBlackActionCQ AddOrderBy_BlackLevel_Desc() { regOBD("BLACK_LEVEL");return this; }

        protected LdConditionValue _actionDate;
        public LdConditionValue ActionDate {
            get { if (_actionDate == null) { _actionDate = new LdConditionValue(); } return _actionDate; }
        }
        protected override LdConditionValue getCValueActionDate() { return this.ActionDate; }


        public LdBsBlackActionCQ AddOrderBy_ActionDate_Asc() { regOBA("ACTION_DATE");return this; }
        public LdBsBlackActionCQ AddOrderBy_ActionDate_Desc() { regOBD("ACTION_DATE");return this; }

        protected LdConditionValue _evidencePhotograph;
        public LdConditionValue EvidencePhotograph {
            get { if (_evidencePhotograph == null) { _evidencePhotograph = new LdConditionValue(); } return _evidencePhotograph; }
        }
        protected override LdConditionValue getCValueEvidencePhotograph() { return this.EvidencePhotograph; }


        public LdBsBlackActionCQ AddOrderBy_EvidencePhotograph_Asc() { regOBA("EVIDENCE_PHOTOGRAPH");return this; }
        public LdBsBlackActionCQ AddOrderBy_EvidencePhotograph_Desc() { regOBD("EVIDENCE_PHOTOGRAPH");return this; }

        protected LdConditionValue _rUser;
        public LdConditionValue RUser {
            get { if (_rUser == null) { _rUser = new LdConditionValue(); } return _rUser; }
        }
        protected override LdConditionValue getCValueRUser() { return this.RUser; }


        public LdBsBlackActionCQ AddOrderBy_RUser_Asc() { regOBA("R_USER");return this; }
        public LdBsBlackActionCQ AddOrderBy_RUser_Desc() { regOBD("R_USER");return this; }

        protected LdConditionValue _rModule;
        public LdConditionValue RModule {
            get { if (_rModule == null) { _rModule = new LdConditionValue(); } return _rModule; }
        }
        protected override LdConditionValue getCValueRModule() { return this.RModule; }


        public LdBsBlackActionCQ AddOrderBy_RModule_Asc() { regOBA("R_MODULE");return this; }
        public LdBsBlackActionCQ AddOrderBy_RModule_Desc() { regOBD("R_MODULE");return this; }

        protected LdConditionValue _rTimestamp;
        public LdConditionValue RTimestamp {
            get { if (_rTimestamp == null) { _rTimestamp = new LdConditionValue(); } return _rTimestamp; }
        }
        protected override LdConditionValue getCValueRTimestamp() { return this.RTimestamp; }


        public LdBsBlackActionCQ AddOrderBy_RTimestamp_Asc() { regOBA("R_TIMESTAMP");return this; }
        public LdBsBlackActionCQ AddOrderBy_RTimestamp_Desc() { regOBD("R_TIMESTAMP");return this; }

        protected LdConditionValue _uUser;
        public LdConditionValue UUser {
            get { if (_uUser == null) { _uUser = new LdConditionValue(); } return _uUser; }
        }
        protected override LdConditionValue getCValueUUser() { return this.UUser; }


        public LdBsBlackActionCQ AddOrderBy_UUser_Asc() { regOBA("U_USER");return this; }
        public LdBsBlackActionCQ AddOrderBy_UUser_Desc() { regOBD("U_USER");return this; }

        protected LdConditionValue _uModule;
        public LdConditionValue UModule {
            get { if (_uModule == null) { _uModule = new LdConditionValue(); } return _uModule; }
        }
        protected override LdConditionValue getCValueUModule() { return this.UModule; }


        public LdBsBlackActionCQ AddOrderBy_UModule_Asc() { regOBA("U_MODULE");return this; }
        public LdBsBlackActionCQ AddOrderBy_UModule_Desc() { regOBD("U_MODULE");return this; }

        protected LdConditionValue _uTimestamp;
        public LdConditionValue UTimestamp {
            get { if (_uTimestamp == null) { _uTimestamp = new LdConditionValue(); } return _uTimestamp; }
        }
        protected override LdConditionValue getCValueUTimestamp() { return this.UTimestamp; }


        public LdBsBlackActionCQ AddOrderBy_UTimestamp_Asc() { regOBA("U_TIMESTAMP");return this; }
        public LdBsBlackActionCQ AddOrderBy_UTimestamp_Desc() { regOBD("U_TIMESTAMP");return this; }

        public LdBsBlackActionCQ AddSpecifiedDerivedOrderBy_Asc(String aliasName) { registerSpecifiedDerivedOrderBy_Asc(aliasName); return this; }
        public LdBsBlackActionCQ AddSpecifiedDerivedOrderBy_Desc(String aliasName) { registerSpecifiedDerivedOrderBy_Desc(aliasName); return this; }

        public override void reflectRelationOnUnionQuery(LdConditionQuery baseQueryAsSuper, LdConditionQuery unionQueryAsSuper) {
            LdBlackActionCQ baseQuery = (LdBlackActionCQ)baseQueryAsSuper;
            LdBlackActionCQ unionQuery = (LdBlackActionCQ)unionQueryAsSuper;
            if (baseQuery.hasConditionQueryBlackList()) {
                unionQuery.QueryBlackList().reflectRelationOnUnionQuery(baseQuery.QueryBlackList(), unionQuery.QueryBlackList());
            }
            if (baseQuery.hasConditionQueryBlackActionLookup()) {
                unionQuery.QueryBlackActionLookup().reflectRelationOnUnionQuery(baseQuery.QueryBlackActionLookup(), unionQuery.QueryBlackActionLookup());
            }

        }
    
        protected LdBlackListCQ _conditionQueryBlackList;
        public LdBlackListCQ QueryBlackList() {
            return this.ConditionQueryBlackList;
        }
        public LdBlackListCQ ConditionQueryBlackList {
            get {
                if (_conditionQueryBlackList == null) {
                    _conditionQueryBlackList = xcreateQueryBlackList();
                    xsetupOuterJoin_BlackList();
                }
                return _conditionQueryBlackList;
            }
        }
        protected LdBlackListCQ xcreateQueryBlackList() {
            String nrp = resolveNextRelationPathBlackList();
            String jan = resolveJoinAliasName(nrp, xgetNextNestLevel());
            LdBlackListCQ cq = new LdBlackListCQ(this, xgetSqlClause(), jan, xgetNextNestLevel());
            cq.xsetForeignPropertyName("blackList"); cq.xsetRelationPath(nrp); return cq;
        }
        public void xsetupOuterJoin_BlackList() {
            LdBlackListCQ cq = ConditionQueryBlackList;
            Map<String, String> joinOnMap = new LinkedHashMap<String, String>();
            joinOnMap.put("BLACK_LIST_ID", "BLACK_LIST_ID");
            registerOuterJoin(cq, joinOnMap);
        }
        protected String resolveNextRelationPathBlackList() {
            return resolveNextRelationPath("black_action", "blackList");
        }
        public bool hasConditionQueryBlackList() {
            return _conditionQueryBlackList != null;
        }
        protected LdBlackActionLookupCQ _conditionQueryBlackActionLookup;
        public LdBlackActionLookupCQ QueryBlackActionLookup() {
            return this.ConditionQueryBlackActionLookup;
        }
        public LdBlackActionLookupCQ ConditionQueryBlackActionLookup {
            get {
                if (_conditionQueryBlackActionLookup == null) {
                    _conditionQueryBlackActionLookup = xcreateQueryBlackActionLookup();
                    xsetupOuterJoin_BlackActionLookup();
                }
                return _conditionQueryBlackActionLookup;
            }
        }
        protected LdBlackActionLookupCQ xcreateQueryBlackActionLookup() {
            String nrp = resolveNextRelationPathBlackActionLookup();
            String jan = resolveJoinAliasName(nrp, xgetNextNestLevel());
            LdBlackActionLookupCQ cq = new LdBlackActionLookupCQ(this, xgetSqlClause(), jan, xgetNextNestLevel());
            cq.xsetForeignPropertyName("blackActionLookup"); cq.xsetRelationPath(nrp); return cq;
        }
        public void xsetupOuterJoin_BlackActionLookup() {
            LdBlackActionLookupCQ cq = ConditionQueryBlackActionLookup;
            Map<String, String> joinOnMap = new LinkedHashMap<String, String>();
            joinOnMap.put("BLACK_ACTION_CODE", "BLACK_ACTION_CODE");
            registerOuterJoin(cq, joinOnMap);
        }
        protected String resolveNextRelationPathBlackActionLookup() {
            return resolveNextRelationPath("black_action", "blackActionLookup");
        }
        public bool hasConditionQueryBlackActionLookup() {
            return _conditionQueryBlackActionLookup != null;
        }


	    // ===============================================================================
	    //                                                                 Scalar SubQuery
	    //                                                                 ===============
	    protected Map<String, LdBlackActionCQ> _scalarSubQueryMap;
	    public Map<String, LdBlackActionCQ> ScalarSubQuery { get { return _scalarSubQueryMap; } }
	    public override String keepScalarSubQuery(LdBlackActionCQ subQuery) {
	        if (_scalarSubQueryMap == null) { _scalarSubQueryMap = new LinkedHashMap<String, LdBlackActionCQ>(); }
	        String key = "subQueryMapKey" + (_scalarSubQueryMap.size() + 1);
	        _scalarSubQueryMap.put(key, subQuery); return "ScalarSubQuery." + key;
	    }

        // ===============================================================================
        //                                                         Myself InScope SubQuery
        //                                                         =======================
        protected Map<String, LdBlackActionCQ> _myselfInScopeSubQueryMap;
        public Map<String, LdBlackActionCQ> MyselfInScopeSubQuery { get { return _myselfInScopeSubQueryMap; } }
        public override String keepMyselfInScopeSubQuery(LdBlackActionCQ subQuery) {
            if (_myselfInScopeSubQueryMap == null) { _myselfInScopeSubQueryMap = new LinkedHashMap<String, LdBlackActionCQ>(); }
            String key = "subQueryMapKey" + (_myselfInScopeSubQueryMap.size() + 1);
            _myselfInScopeSubQueryMap.put(key, subQuery); return "MyselfInScopeSubQuery." + key;
        }
    }
}
