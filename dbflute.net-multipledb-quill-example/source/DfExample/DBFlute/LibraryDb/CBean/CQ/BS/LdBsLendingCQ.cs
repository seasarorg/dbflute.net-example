
using System;

using DfExample.DBFlute.LibraryDb.AllCommon.CBean;
using DfExample.DBFlute.LibraryDb.AllCommon.CBean.CValue;
using DfExample.DBFlute.LibraryDb.AllCommon.CBean.SClause;
using DfExample.DBFlute.LibraryDb.AllCommon.JavaLike;
using DfExample.DBFlute.LibraryDb.CBean.CQ;
using DfExample.DBFlute.LibraryDb.CBean.CQ.Ciq;

namespace DfExample.DBFlute.LibraryDb.CBean.CQ.BS {

    [System.Serializable]
    public class LdBsLendingCQ : LdAbstractBsLendingCQ {

        protected LdLendingCIQ _inlineQuery;

        public LdBsLendingCQ(LdConditionQuery childQuery, LdSqlClause sqlClause, String aliasName, int nestLevel)
            : base(childQuery, sqlClause, aliasName, nestLevel) {}

        public LdLendingCIQ Inline() {
            if (_inlineQuery == null) {
                _inlineQuery = new LdLendingCIQ(xgetReferrerQuery(), xgetSqlClause(), xgetAliasName(), xgetNestLevel(), this);
            }
            _inlineQuery.xsetOnClause(false);
            return _inlineQuery;
        }
        
        public LdLendingCIQ On() {
            if (isBaseQuery()) { throw new UnsupportedOperationException("Unsupported onClause of Base Table!"); }
            LdLendingCIQ inlineQuery = Inline();
            inlineQuery.xsetOnClause(true);
            return inlineQuery;
        }


        protected LdConditionValue _libraryId;
        public LdConditionValue LibraryId {
            get { if (_libraryId == null) { _libraryId = new LdConditionValue(); } return _libraryId; }
        }
        protected override LdConditionValue getCValueLibraryId() { return this.LibraryId; }


        public LdBsLendingCQ AddOrderBy_LibraryId_Asc() { regOBA("LIBRARY_ID");return this; }
        public LdBsLendingCQ AddOrderBy_LibraryId_Desc() { regOBD("LIBRARY_ID");return this; }

        protected LdConditionValue _lbUserId;
        public LdConditionValue LbUserId {
            get { if (_lbUserId == null) { _lbUserId = new LdConditionValue(); } return _lbUserId; }
        }
        protected override LdConditionValue getCValueLbUserId() { return this.LbUserId; }


        public LdBsLendingCQ AddOrderBy_LbUserId_Asc() { regOBA("LB_USER_ID");return this; }
        public LdBsLendingCQ AddOrderBy_LbUserId_Desc() { regOBD("LB_USER_ID");return this; }

        protected LdConditionValue _lendingDate;
        public LdConditionValue LendingDate {
            get { if (_lendingDate == null) { _lendingDate = new LdConditionValue(); } return _lendingDate; }
        }
        protected override LdConditionValue getCValueLendingDate() { return this.LendingDate; }


        public LdBsLendingCQ AddOrderBy_LendingDate_Asc() { regOBA("LENDING_DATE");return this; }
        public LdBsLendingCQ AddOrderBy_LendingDate_Desc() { regOBD("LENDING_DATE");return this; }

        protected LdConditionValue _rUser;
        public LdConditionValue RUser {
            get { if (_rUser == null) { _rUser = new LdConditionValue(); } return _rUser; }
        }
        protected override LdConditionValue getCValueRUser() { return this.RUser; }


        public LdBsLendingCQ AddOrderBy_RUser_Asc() { regOBA("R_USER");return this; }
        public LdBsLendingCQ AddOrderBy_RUser_Desc() { regOBD("R_USER");return this; }

        protected LdConditionValue _rModule;
        public LdConditionValue RModule {
            get { if (_rModule == null) { _rModule = new LdConditionValue(); } return _rModule; }
        }
        protected override LdConditionValue getCValueRModule() { return this.RModule; }


        public LdBsLendingCQ AddOrderBy_RModule_Asc() { regOBA("R_MODULE");return this; }
        public LdBsLendingCQ AddOrderBy_RModule_Desc() { regOBD("R_MODULE");return this; }

        protected LdConditionValue _rTimestamp;
        public LdConditionValue RTimestamp {
            get { if (_rTimestamp == null) { _rTimestamp = new LdConditionValue(); } return _rTimestamp; }
        }
        protected override LdConditionValue getCValueRTimestamp() { return this.RTimestamp; }


        public LdBsLendingCQ AddOrderBy_RTimestamp_Asc() { regOBA("R_TIMESTAMP");return this; }
        public LdBsLendingCQ AddOrderBy_RTimestamp_Desc() { regOBD("R_TIMESTAMP");return this; }

        protected LdConditionValue _uUser;
        public LdConditionValue UUser {
            get { if (_uUser == null) { _uUser = new LdConditionValue(); } return _uUser; }
        }
        protected override LdConditionValue getCValueUUser() { return this.UUser; }


        public LdBsLendingCQ AddOrderBy_UUser_Asc() { regOBA("U_USER");return this; }
        public LdBsLendingCQ AddOrderBy_UUser_Desc() { regOBD("U_USER");return this; }

        protected LdConditionValue _uModule;
        public LdConditionValue UModule {
            get { if (_uModule == null) { _uModule = new LdConditionValue(); } return _uModule; }
        }
        protected override LdConditionValue getCValueUModule() { return this.UModule; }


        public LdBsLendingCQ AddOrderBy_UModule_Asc() { regOBA("U_MODULE");return this; }
        public LdBsLendingCQ AddOrderBy_UModule_Desc() { regOBD("U_MODULE");return this; }

        protected LdConditionValue _uTimestamp;
        public LdConditionValue UTimestamp {
            get { if (_uTimestamp == null) { _uTimestamp = new LdConditionValue(); } return _uTimestamp; }
        }
        protected override LdConditionValue getCValueUTimestamp() { return this.UTimestamp; }


        public LdBsLendingCQ AddOrderBy_UTimestamp_Asc() { regOBA("U_TIMESTAMP");return this; }
        public LdBsLendingCQ AddOrderBy_UTimestamp_Desc() { regOBD("U_TIMESTAMP");return this; }

        public LdBsLendingCQ AddSpecifiedDerivedOrderBy_Asc(String aliasName) { registerSpecifiedDerivedOrderBy_Asc(aliasName); return this; }
        public LdBsLendingCQ AddSpecifiedDerivedOrderBy_Desc(String aliasName) { registerSpecifiedDerivedOrderBy_Desc(aliasName); return this; }

        public override void reflectRelationOnUnionQuery(LdConditionQuery baseQueryAsSuper, LdConditionQuery unionQueryAsSuper) {
            LdLendingCQ baseQuery = (LdLendingCQ)baseQueryAsSuper;
            LdLendingCQ unionQuery = (LdLendingCQ)unionQueryAsSuper;
            if (baseQuery.hasConditionQueryLibraryUser()) {
                unionQuery.QueryLibraryUser().reflectRelationOnUnionQuery(baseQuery.QueryLibraryUser(), unionQuery.QueryLibraryUser());
            }

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
            return resolveNextRelationPath("lending", "libraryUser");
        }
        public bool hasConditionQueryLibraryUser() {
            return _conditionQueryLibraryUser != null;
        }

    }
}
