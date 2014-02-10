
using System;

using DfExample.DBFlute.LibraryDb.AllCommon.CBean;
using DfExample.DBFlute.LibraryDb.AllCommon.CBean.CValue;
using DfExample.DBFlute.LibraryDb.AllCommon.CBean.SClause;
using DfExample.DBFlute.LibraryDb.AllCommon.JavaLike;
using DfExample.DBFlute.LibraryDb.CBean.CQ;
using DfExample.DBFlute.LibraryDb.CBean.CQ.Ciq;

namespace DfExample.DBFlute.LibraryDb.CBean.CQ.BS {

    [System.Serializable]
    public class LdBsLibraryUserCQ : LdAbstractBsLibraryUserCQ {

        protected LdLibraryUserCIQ _inlineQuery;

        public LdBsLibraryUserCQ(LdConditionQuery childQuery, LdSqlClause sqlClause, String aliasName, int nestLevel)
            : base(childQuery, sqlClause, aliasName, nestLevel) {}

        public LdLibraryUserCIQ Inline() {
            if (_inlineQuery == null) {
                _inlineQuery = new LdLibraryUserCIQ(xgetReferrerQuery(), xgetSqlClause(), xgetAliasName(), xgetNestLevel(), this);
            }
            _inlineQuery.xsetOnClause(false);
            return _inlineQuery;
        }
        
        public LdLibraryUserCIQ On() {
            if (isBaseQuery()) { throw new UnsupportedOperationException("Unsupported onClause of Base Table!"); }
            LdLibraryUserCIQ inlineQuery = Inline();
            inlineQuery.xsetOnClause(true);
            return inlineQuery;
        }


        protected LdConditionValue _libraryId;
        public LdConditionValue LibraryId {
            get { if (_libraryId == null) { _libraryId = new LdConditionValue(); } return _libraryId; }
        }
        protected override LdConditionValue getCValueLibraryId() { return this.LibraryId; }


        protected Map<String, LdLibraryCQ> _libraryId_InScopeSubQuery_LibraryMap;
        public Map<String, LdLibraryCQ> LibraryId_InScopeSubQuery_Library { get { return _libraryId_InScopeSubQuery_LibraryMap; }}
        public override String keepLibraryId_InScopeSubQuery_Library(LdLibraryCQ subQuery) {
            if (_libraryId_InScopeSubQuery_LibraryMap == null) { _libraryId_InScopeSubQuery_LibraryMap = new LinkedHashMap<String, LdLibraryCQ>(); }
            String key = "subQueryMapKey" + (_libraryId_InScopeSubQuery_LibraryMap.size() + 1);
            _libraryId_InScopeSubQuery_LibraryMap.put(key, subQuery); return "LibraryId_InScopeSubQuery_Library." + key;
        }

        protected Map<String, LdLibraryCQ> _libraryId_NotInScopeSubQuery_LibraryMap;
        public Map<String, LdLibraryCQ> LibraryId_NotInScopeSubQuery_Library { get { return _libraryId_NotInScopeSubQuery_LibraryMap; }}
        public override String keepLibraryId_NotInScopeSubQuery_Library(LdLibraryCQ subQuery) {
            if (_libraryId_NotInScopeSubQuery_LibraryMap == null) { _libraryId_NotInScopeSubQuery_LibraryMap = new LinkedHashMap<String, LdLibraryCQ>(); }
            String key = "subQueryMapKey" + (_libraryId_NotInScopeSubQuery_LibraryMap.size() + 1);
            _libraryId_NotInScopeSubQuery_LibraryMap.put(key, subQuery); return "LibraryId_NotInScopeSubQuery_Library." + key;
        }

        public LdBsLibraryUserCQ AddOrderBy_LibraryId_Asc() { regOBA("LIBRARY_ID");return this; }
        public LdBsLibraryUserCQ AddOrderBy_LibraryId_Desc() { regOBD("LIBRARY_ID");return this; }

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

        public LdBsLibraryUserCQ AddOrderBy_LbUserId_Asc() { regOBA("LB_USER_ID");return this; }
        public LdBsLibraryUserCQ AddOrderBy_LbUserId_Desc() { regOBD("LB_USER_ID");return this; }

        protected LdConditionValue _rUser;
        public LdConditionValue RUser {
            get { if (_rUser == null) { _rUser = new LdConditionValue(); } return _rUser; }
        }
        protected override LdConditionValue getCValueRUser() { return this.RUser; }


        public LdBsLibraryUserCQ AddOrderBy_RUser_Asc() { regOBA("R_USER");return this; }
        public LdBsLibraryUserCQ AddOrderBy_RUser_Desc() { regOBD("R_USER");return this; }

        protected LdConditionValue _rModule;
        public LdConditionValue RModule {
            get { if (_rModule == null) { _rModule = new LdConditionValue(); } return _rModule; }
        }
        protected override LdConditionValue getCValueRModule() { return this.RModule; }


        public LdBsLibraryUserCQ AddOrderBy_RModule_Asc() { regOBA("R_MODULE");return this; }
        public LdBsLibraryUserCQ AddOrderBy_RModule_Desc() { regOBD("R_MODULE");return this; }

        protected LdConditionValue _rTimestamp;
        public LdConditionValue RTimestamp {
            get { if (_rTimestamp == null) { _rTimestamp = new LdConditionValue(); } return _rTimestamp; }
        }
        protected override LdConditionValue getCValueRTimestamp() { return this.RTimestamp; }


        public LdBsLibraryUserCQ AddOrderBy_RTimestamp_Asc() { regOBA("R_TIMESTAMP");return this; }
        public LdBsLibraryUserCQ AddOrderBy_RTimestamp_Desc() { regOBD("R_TIMESTAMP");return this; }

        protected LdConditionValue _uUser;
        public LdConditionValue UUser {
            get { if (_uUser == null) { _uUser = new LdConditionValue(); } return _uUser; }
        }
        protected override LdConditionValue getCValueUUser() { return this.UUser; }


        public LdBsLibraryUserCQ AddOrderBy_UUser_Asc() { regOBA("U_USER");return this; }
        public LdBsLibraryUserCQ AddOrderBy_UUser_Desc() { regOBD("U_USER");return this; }

        protected LdConditionValue _uModule;
        public LdConditionValue UModule {
            get { if (_uModule == null) { _uModule = new LdConditionValue(); } return _uModule; }
        }
        protected override LdConditionValue getCValueUModule() { return this.UModule; }


        public LdBsLibraryUserCQ AddOrderBy_UModule_Asc() { regOBA("U_MODULE");return this; }
        public LdBsLibraryUserCQ AddOrderBy_UModule_Desc() { regOBD("U_MODULE");return this; }

        protected LdConditionValue _uTimestamp;
        public LdConditionValue UTimestamp {
            get { if (_uTimestamp == null) { _uTimestamp = new LdConditionValue(); } return _uTimestamp; }
        }
        protected override LdConditionValue getCValueUTimestamp() { return this.UTimestamp; }


        public LdBsLibraryUserCQ AddOrderBy_UTimestamp_Asc() { regOBA("U_TIMESTAMP");return this; }
        public LdBsLibraryUserCQ AddOrderBy_UTimestamp_Desc() { regOBD("U_TIMESTAMP");return this; }

        public LdBsLibraryUserCQ AddSpecifiedDerivedOrderBy_Asc(String aliasName) { registerSpecifiedDerivedOrderBy_Asc(aliasName); return this; }
        public LdBsLibraryUserCQ AddSpecifiedDerivedOrderBy_Desc(String aliasName) { registerSpecifiedDerivedOrderBy_Desc(aliasName); return this; }

        public override void reflectRelationOnUnionQuery(LdConditionQuery baseQueryAsSuper, LdConditionQuery unionQueryAsSuper) {
            LdLibraryUserCQ baseQuery = (LdLibraryUserCQ)baseQueryAsSuper;
            LdLibraryUserCQ unionQuery = (LdLibraryUserCQ)unionQueryAsSuper;
            if (baseQuery.hasConditionQueryLbUser()) {
                unionQuery.QueryLbUser().reflectRelationOnUnionQuery(baseQuery.QueryLbUser(), unionQuery.QueryLbUser());
            }
            if (baseQuery.hasConditionQueryLibrary()) {
                unionQuery.QueryLibrary().reflectRelationOnUnionQuery(baseQuery.QueryLibrary(), unionQuery.QueryLibrary());
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
            return resolveNextRelationPath("library_user", "lbUser");
        }
        public bool hasConditionQueryLbUser() {
            return _conditionQueryLbUser != null;
        }
        protected LdLibraryCQ _conditionQueryLibrary;
        public LdLibraryCQ QueryLibrary() {
            return this.ConditionQueryLibrary;
        }
        public LdLibraryCQ ConditionQueryLibrary {
            get {
                if (_conditionQueryLibrary == null) {
                    _conditionQueryLibrary = xcreateQueryLibrary();
                    xsetupOuterJoin_Library();
                }
                return _conditionQueryLibrary;
            }
        }
        protected LdLibraryCQ xcreateQueryLibrary() {
            String nrp = resolveNextRelationPathLibrary();
            String jan = resolveJoinAliasName(nrp, xgetNextNestLevel());
            LdLibraryCQ cq = new LdLibraryCQ(this, xgetSqlClause(), jan, xgetNextNestLevel());
            cq.xsetForeignPropertyName("library"); cq.xsetRelationPath(nrp); return cq;
        }
        public void xsetupOuterJoin_Library() {
            LdLibraryCQ cq = ConditionQueryLibrary;
            Map<String, String> joinOnMap = new LinkedHashMap<String, String>();
            joinOnMap.put("LIBRARY_ID", "LIBRARY_ID");
            registerOuterJoin(cq, joinOnMap);
        }
        protected String resolveNextRelationPathLibrary() {
            return resolveNextRelationPath("library_user", "library");
        }
        public bool hasConditionQueryLibrary() {
            return _conditionQueryLibrary != null;
        }

    }
}
