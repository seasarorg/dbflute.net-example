
using System;

using DfExample.DBFlute.LibraryDb.AllCommon.CBean;
using DfExample.DBFlute.LibraryDb.AllCommon.CBean.CValue;
using DfExample.DBFlute.LibraryDb.AllCommon.CBean.SClause;
using DfExample.DBFlute.LibraryDb.AllCommon.JavaLike;
using DfExample.DBFlute.LibraryDb.CBean.CQ;
using DfExample.DBFlute.LibraryDb.CBean.CQ.Ciq;

namespace DfExample.DBFlute.LibraryDb.CBean.CQ.BS {

    [System.Serializable]
    public class LdBsLendingCollectionCQ : LdAbstractBsLendingCollectionCQ {

        protected LdLendingCollectionCIQ _inlineQuery;

        public LdBsLendingCollectionCQ(LdConditionQuery childQuery, LdSqlClause sqlClause, String aliasName, int nestLevel)
            : base(childQuery, sqlClause, aliasName, nestLevel) {}

        public LdLendingCollectionCIQ Inline() {
            if (_inlineQuery == null) {
                _inlineQuery = new LdLendingCollectionCIQ(xgetReferrerQuery(), xgetSqlClause(), xgetAliasName(), xgetNestLevel(), this);
            }
            _inlineQuery.xsetOnClause(false);
            return _inlineQuery;
        }
        
        public LdLendingCollectionCIQ On() {
            if (isBaseQuery()) { throw new UnsupportedOperationException("Unsupported onClause of Base Table!"); }
            LdLendingCollectionCIQ inlineQuery = Inline();
            inlineQuery.xsetOnClause(true);
            return inlineQuery;
        }


        protected LdConditionValue _libraryId;
        public LdConditionValue LibraryId {
            get { if (_libraryId == null) { _libraryId = new LdConditionValue(); } return _libraryId; }
        }
        protected override LdConditionValue getCValueLibraryId() { return this.LibraryId; }


        public LdBsLendingCollectionCQ AddOrderBy_LibraryId_Asc() { regOBA("LIBRARY_ID");return this; }
        public LdBsLendingCollectionCQ AddOrderBy_LibraryId_Desc() { regOBD("LIBRARY_ID");return this; }

        protected LdConditionValue _lbUserId;
        public LdConditionValue LbUserId {
            get { if (_lbUserId == null) { _lbUserId = new LdConditionValue(); } return _lbUserId; }
        }
        protected override LdConditionValue getCValueLbUserId() { return this.LbUserId; }


        public LdBsLendingCollectionCQ AddOrderBy_LbUserId_Asc() { regOBA("LB_USER_ID");return this; }
        public LdBsLendingCollectionCQ AddOrderBy_LbUserId_Desc() { regOBD("LB_USER_ID");return this; }

        protected LdConditionValue _lendingDate;
        public LdConditionValue LendingDate {
            get { if (_lendingDate == null) { _lendingDate = new LdConditionValue(); } return _lendingDate; }
        }
        protected override LdConditionValue getCValueLendingDate() { return this.LendingDate; }


        public LdBsLendingCollectionCQ AddOrderBy_LendingDate_Asc() { regOBA("LENDING_DATE");return this; }
        public LdBsLendingCollectionCQ AddOrderBy_LendingDate_Desc() { regOBD("LENDING_DATE");return this; }

        protected LdConditionValue _collectionId;
        public LdConditionValue CollectionId {
            get { if (_collectionId == null) { _collectionId = new LdConditionValue(); } return _collectionId; }
        }
        protected override LdConditionValue getCValueCollectionId() { return this.CollectionId; }


        protected Map<String, LdCollectionCQ> _collectionId_InScopeSubQuery_CollectionMap;
        public Map<String, LdCollectionCQ> CollectionId_InScopeSubQuery_Collection { get { return _collectionId_InScopeSubQuery_CollectionMap; }}
        public override String keepCollectionId_InScopeSubQuery_Collection(LdCollectionCQ subQuery) {
            if (_collectionId_InScopeSubQuery_CollectionMap == null) { _collectionId_InScopeSubQuery_CollectionMap = new LinkedHashMap<String, LdCollectionCQ>(); }
            String key = "subQueryMapKey" + (_collectionId_InScopeSubQuery_CollectionMap.size() + 1);
            _collectionId_InScopeSubQuery_CollectionMap.put(key, subQuery); return "CollectionId_InScopeSubQuery_Collection." + key;
        }

        protected Map<String, LdCollectionCQ> _collectionId_NotInScopeSubQuery_CollectionMap;
        public Map<String, LdCollectionCQ> CollectionId_NotInScopeSubQuery_Collection { get { return _collectionId_NotInScopeSubQuery_CollectionMap; }}
        public override String keepCollectionId_NotInScopeSubQuery_Collection(LdCollectionCQ subQuery) {
            if (_collectionId_NotInScopeSubQuery_CollectionMap == null) { _collectionId_NotInScopeSubQuery_CollectionMap = new LinkedHashMap<String, LdCollectionCQ>(); }
            String key = "subQueryMapKey" + (_collectionId_NotInScopeSubQuery_CollectionMap.size() + 1);
            _collectionId_NotInScopeSubQuery_CollectionMap.put(key, subQuery); return "CollectionId_NotInScopeSubQuery_Collection." + key;
        }

        public LdBsLendingCollectionCQ AddOrderBy_CollectionId_Asc() { regOBA("COLLECTION_ID");return this; }
        public LdBsLendingCollectionCQ AddOrderBy_CollectionId_Desc() { regOBD("COLLECTION_ID");return this; }

        protected LdConditionValue _returnLimitDate;
        public LdConditionValue ReturnLimitDate {
            get { if (_returnLimitDate == null) { _returnLimitDate = new LdConditionValue(); } return _returnLimitDate; }
        }
        protected override LdConditionValue getCValueReturnLimitDate() { return this.ReturnLimitDate; }


        public LdBsLendingCollectionCQ AddOrderBy_ReturnLimitDate_Asc() { regOBA("RETURN_LIMIT_DATE");return this; }
        public LdBsLendingCollectionCQ AddOrderBy_ReturnLimitDate_Desc() { regOBD("RETURN_LIMIT_DATE");return this; }

        protected LdConditionValue _rUser;
        public LdConditionValue RUser {
            get { if (_rUser == null) { _rUser = new LdConditionValue(); } return _rUser; }
        }
        protected override LdConditionValue getCValueRUser() { return this.RUser; }


        public LdBsLendingCollectionCQ AddOrderBy_RUser_Asc() { regOBA("R_USER");return this; }
        public LdBsLendingCollectionCQ AddOrderBy_RUser_Desc() { regOBD("R_USER");return this; }

        protected LdConditionValue _rModule;
        public LdConditionValue RModule {
            get { if (_rModule == null) { _rModule = new LdConditionValue(); } return _rModule; }
        }
        protected override LdConditionValue getCValueRModule() { return this.RModule; }


        public LdBsLendingCollectionCQ AddOrderBy_RModule_Asc() { regOBA("R_MODULE");return this; }
        public LdBsLendingCollectionCQ AddOrderBy_RModule_Desc() { regOBD("R_MODULE");return this; }

        protected LdConditionValue _rTimestamp;
        public LdConditionValue RTimestamp {
            get { if (_rTimestamp == null) { _rTimestamp = new LdConditionValue(); } return _rTimestamp; }
        }
        protected override LdConditionValue getCValueRTimestamp() { return this.RTimestamp; }


        public LdBsLendingCollectionCQ AddOrderBy_RTimestamp_Asc() { regOBA("R_TIMESTAMP");return this; }
        public LdBsLendingCollectionCQ AddOrderBy_RTimestamp_Desc() { regOBD("R_TIMESTAMP");return this; }

        protected LdConditionValue _uUser;
        public LdConditionValue UUser {
            get { if (_uUser == null) { _uUser = new LdConditionValue(); } return _uUser; }
        }
        protected override LdConditionValue getCValueUUser() { return this.UUser; }


        public LdBsLendingCollectionCQ AddOrderBy_UUser_Asc() { regOBA("U_USER");return this; }
        public LdBsLendingCollectionCQ AddOrderBy_UUser_Desc() { regOBD("U_USER");return this; }

        protected LdConditionValue _uModule;
        public LdConditionValue UModule {
            get { if (_uModule == null) { _uModule = new LdConditionValue(); } return _uModule; }
        }
        protected override LdConditionValue getCValueUModule() { return this.UModule; }


        public LdBsLendingCollectionCQ AddOrderBy_UModule_Asc() { regOBA("U_MODULE");return this; }
        public LdBsLendingCollectionCQ AddOrderBy_UModule_Desc() { regOBD("U_MODULE");return this; }

        protected LdConditionValue _uTimestamp;
        public LdConditionValue UTimestamp {
            get { if (_uTimestamp == null) { _uTimestamp = new LdConditionValue(); } return _uTimestamp; }
        }
        protected override LdConditionValue getCValueUTimestamp() { return this.UTimestamp; }


        public LdBsLendingCollectionCQ AddOrderBy_UTimestamp_Asc() { regOBA("U_TIMESTAMP");return this; }
        public LdBsLendingCollectionCQ AddOrderBy_UTimestamp_Desc() { regOBD("U_TIMESTAMP");return this; }

        public LdBsLendingCollectionCQ AddSpecifiedDerivedOrderBy_Asc(String aliasName) { registerSpecifiedDerivedOrderBy_Asc(aliasName); return this; }
        public LdBsLendingCollectionCQ AddSpecifiedDerivedOrderBy_Desc(String aliasName) { registerSpecifiedDerivedOrderBy_Desc(aliasName); return this; }

        public override void reflectRelationOnUnionQuery(LdConditionQuery baseQueryAsSuper, LdConditionQuery unionQueryAsSuper) {
            LdLendingCollectionCQ baseQuery = (LdLendingCollectionCQ)baseQueryAsSuper;
            LdLendingCollectionCQ unionQuery = (LdLendingCollectionCQ)unionQueryAsSuper;
            if (baseQuery.hasConditionQueryCollection()) {
                unionQuery.QueryCollection().reflectRelationOnUnionQuery(baseQuery.QueryCollection(), unionQuery.QueryCollection());
            }
            if (baseQuery.hasConditionQueryLending()) {
                unionQuery.QueryLending().reflectRelationOnUnionQuery(baseQuery.QueryLending(), unionQuery.QueryLending());
            }
            if (baseQuery.hasConditionQueryLibraryUser()) {
                unionQuery.QueryLibraryUser().reflectRelationOnUnionQuery(baseQuery.QueryLibraryUser(), unionQuery.QueryLibraryUser());
            }

        }
    
        protected LdCollectionCQ _conditionQueryCollection;
        public LdCollectionCQ QueryCollection() {
            return this.ConditionQueryCollection;
        }
        public LdCollectionCQ ConditionQueryCollection {
            get {
                if (_conditionQueryCollection == null) {
                    _conditionQueryCollection = xcreateQueryCollection();
                    xsetupOuterJoin_Collection();
                }
                return _conditionQueryCollection;
            }
        }
        protected LdCollectionCQ xcreateQueryCollection() {
            String nrp = resolveNextRelationPathCollection();
            String jan = resolveJoinAliasName(nrp, xgetNextNestLevel());
            LdCollectionCQ cq = new LdCollectionCQ(this, xgetSqlClause(), jan, xgetNextNestLevel());
            cq.xsetForeignPropertyName("collection"); cq.xsetRelationPath(nrp); return cq;
        }
        public void xsetupOuterJoin_Collection() {
            LdCollectionCQ cq = ConditionQueryCollection;
            Map<String, String> joinOnMap = new LinkedHashMap<String, String>();
            joinOnMap.put("COLLECTION_ID", "COLLECTION_ID");
            registerOuterJoin(cq, joinOnMap);
        }
        protected String resolveNextRelationPathCollection() {
            return resolveNextRelationPath("lending_collection", "collection");
        }
        public bool hasConditionQueryCollection() {
            return _conditionQueryCollection != null;
        }
        protected LdLendingCQ _conditionQueryLending;
        public LdLendingCQ QueryLending() {
            return this.ConditionQueryLending;
        }
        public LdLendingCQ ConditionQueryLending {
            get {
                if (_conditionQueryLending == null) {
                    _conditionQueryLending = xcreateQueryLending();
                    xsetupOuterJoin_Lending();
                }
                return _conditionQueryLending;
            }
        }
        protected LdLendingCQ xcreateQueryLending() {
            String nrp = resolveNextRelationPathLending();
            String jan = resolveJoinAliasName(nrp, xgetNextNestLevel());
            LdLendingCQ cq = new LdLendingCQ(this, xgetSqlClause(), jan, xgetNextNestLevel());
            cq.xsetForeignPropertyName("lending"); cq.xsetRelationPath(nrp); return cq;
        }
        public void xsetupOuterJoin_Lending() {
            LdLendingCQ cq = ConditionQueryLending;
            Map<String, String> joinOnMap = new LinkedHashMap<String, String>();
            joinOnMap.put("LIBRARY_ID", "LIBRARY_ID");
            joinOnMap.put("LB_USER_ID", "LB_USER_ID");
            joinOnMap.put("LENDING_DATE", "LENDING_DATE");
            registerOuterJoin(cq, joinOnMap);
        }
        protected String resolveNextRelationPathLending() {
            return resolveNextRelationPath("lending_collection", "lending");
        }
        public bool hasConditionQueryLending() {
            return _conditionQueryLending != null;
        }
        protected LdLibraryUserCQ _conditionQueryLibraryUser;
        public LdLibraryUserCQ QueryLibraryUser() {
            return this.ConditionQueryLibraryUser;
        }
        public LdLibraryUserCQ ConditionQueryLibraryUser {
            get {
                if (_conditionQueryLibraryUser == null) {
                    _conditionQueryLibraryUser = xcreateQueryLibraryUser();
                    xsetupOuterJoin_LibraryUser();
                }
                return _conditionQueryLibraryUser;
            }
        }
        protected LdLibraryUserCQ xcreateQueryLibraryUser() {
            String nrp = resolveNextRelationPathLibraryUser();
            String jan = resolveJoinAliasName(nrp, xgetNextNestLevel());
            LdLibraryUserCQ cq = new LdLibraryUserCQ(this, xgetSqlClause(), jan, xgetNextNestLevel());
            cq.xsetForeignPropertyName("libraryUser"); cq.xsetRelationPath(nrp); return cq;
        }
        public void xsetupOuterJoin_LibraryUser() {
            LdLibraryUserCQ cq = ConditionQueryLibraryUser;
            Map<String, String> joinOnMap = new LinkedHashMap<String, String>();
            joinOnMap.put("LIBRARY_ID", "LIBRARY_ID");
            joinOnMap.put("LB_USER_ID", "LB_USER_ID");
            registerOuterJoin(cq, joinOnMap);
        }
        protected String resolveNextRelationPathLibraryUser() {
            return resolveNextRelationPath("lending_collection", "libraryUser");
        }
        public bool hasConditionQueryLibraryUser() {
            return _conditionQueryLibraryUser != null;
        }

    }
}
