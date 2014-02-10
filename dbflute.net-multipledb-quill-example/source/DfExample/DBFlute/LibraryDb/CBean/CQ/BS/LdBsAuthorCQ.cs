
using System;

using DfExample.DBFlute.LibraryDb.AllCommon.CBean;
using DfExample.DBFlute.LibraryDb.AllCommon.CBean.CValue;
using DfExample.DBFlute.LibraryDb.AllCommon.CBean.SClause;
using DfExample.DBFlute.LibraryDb.AllCommon.JavaLike;
using DfExample.DBFlute.LibraryDb.CBean.CQ;
using DfExample.DBFlute.LibraryDb.CBean.CQ.Ciq;

namespace DfExample.DBFlute.LibraryDb.CBean.CQ.BS {

    [System.Serializable]
    public class LdBsAuthorCQ : LdAbstractBsAuthorCQ {

        protected LdAuthorCIQ _inlineQuery;

        public LdBsAuthorCQ(LdConditionQuery childQuery, LdSqlClause sqlClause, String aliasName, int nestLevel)
            : base(childQuery, sqlClause, aliasName, nestLevel) {}

        public LdAuthorCIQ Inline() {
            if (_inlineQuery == null) {
                _inlineQuery = new LdAuthorCIQ(xgetReferrerQuery(), xgetSqlClause(), xgetAliasName(), xgetNestLevel(), this);
            }
            _inlineQuery.xsetOnClause(false);
            return _inlineQuery;
        }
        
        public LdAuthorCIQ On() {
            if (isBaseQuery()) { throw new UnsupportedOperationException("Unsupported onClause of Base Table!"); }
            LdAuthorCIQ inlineQuery = Inline();
            inlineQuery.xsetOnClause(true);
            return inlineQuery;
        }


        protected LdConditionValue _authorId;
        public LdConditionValue AuthorId {
            get { if (_authorId == null) { _authorId = new LdConditionValue(); } return _authorId; }
        }
        protected override LdConditionValue getCValueAuthorId() { return this.AuthorId; }


        protected Map<String, LdBookCQ> _authorId_ExistsSubQuery_BookListMap;
        public Map<String, LdBookCQ> AuthorId_ExistsSubQuery_BookList { get { return _authorId_ExistsSubQuery_BookListMap; }}
        public override String keepAuthorId_ExistsSubQuery_BookList(LdBookCQ subQuery) {
            if (_authorId_ExistsSubQuery_BookListMap == null) { _authorId_ExistsSubQuery_BookListMap = new LinkedHashMap<String, LdBookCQ>(); }
            String key = "subQueryMapKey" + (_authorId_ExistsSubQuery_BookListMap.size() + 1);
            _authorId_ExistsSubQuery_BookListMap.put(key, subQuery); return "AuthorId_ExistsSubQuery_BookList." + key;
        }

        protected Map<String, LdBookCQ> _authorId_NotExistsSubQuery_BookListMap;
        public Map<String, LdBookCQ> AuthorId_NotExistsSubQuery_BookList { get { return _authorId_NotExistsSubQuery_BookListMap; }}
        public override String keepAuthorId_NotExistsSubQuery_BookList(LdBookCQ subQuery) {
            if (_authorId_NotExistsSubQuery_BookListMap == null) { _authorId_NotExistsSubQuery_BookListMap = new LinkedHashMap<String, LdBookCQ>(); }
            String key = "subQueryMapKey" + (_authorId_NotExistsSubQuery_BookListMap.size() + 1);
            _authorId_NotExistsSubQuery_BookListMap.put(key, subQuery); return "AuthorId_NotExistsSubQuery_BookList." + key;
        }

        protected Map<String, LdBookCQ> _authorId_InScopeSubQuery_BookListMap;
        public Map<String, LdBookCQ> AuthorId_InScopeSubQuery_BookList { get { return _authorId_InScopeSubQuery_BookListMap; }}
        public override String keepAuthorId_InScopeSubQuery_BookList(LdBookCQ subQuery) {
            if (_authorId_InScopeSubQuery_BookListMap == null) { _authorId_InScopeSubQuery_BookListMap = new LinkedHashMap<String, LdBookCQ>(); }
            String key = "subQueryMapKey" + (_authorId_InScopeSubQuery_BookListMap.size() + 1);
            _authorId_InScopeSubQuery_BookListMap.put(key, subQuery); return "AuthorId_InScopeSubQuery_BookList." + key;
        }

        protected Map<String, LdBookCQ> _authorId_NotInScopeSubQuery_BookListMap;
        public Map<String, LdBookCQ> AuthorId_NotInScopeSubQuery_BookList { get { return _authorId_NotInScopeSubQuery_BookListMap; }}
        public override String keepAuthorId_NotInScopeSubQuery_BookList(LdBookCQ subQuery) {
            if (_authorId_NotInScopeSubQuery_BookListMap == null) { _authorId_NotInScopeSubQuery_BookListMap = new LinkedHashMap<String, LdBookCQ>(); }
            String key = "subQueryMapKey" + (_authorId_NotInScopeSubQuery_BookListMap.size() + 1);
            _authorId_NotInScopeSubQuery_BookListMap.put(key, subQuery); return "AuthorId_NotInScopeSubQuery_BookList." + key;
        }

        protected Map<String, LdBookCQ> _authorId_SpecifyDerivedReferrer_BookListMap;
        public Map<String, LdBookCQ> AuthorId_SpecifyDerivedReferrer_BookList { get { return _authorId_SpecifyDerivedReferrer_BookListMap; }}
        public override String keepAuthorId_SpecifyDerivedReferrer_BookList(LdBookCQ subQuery) {
            if (_authorId_SpecifyDerivedReferrer_BookListMap == null) { _authorId_SpecifyDerivedReferrer_BookListMap = new LinkedHashMap<String, LdBookCQ>(); }
            String key = "subQueryMapKey" + (_authorId_SpecifyDerivedReferrer_BookListMap.size() + 1);
            _authorId_SpecifyDerivedReferrer_BookListMap.put(key, subQuery); return "AuthorId_SpecifyDerivedReferrer_BookList." + key;
        }

        protected Map<String, LdBookCQ> _authorId_QueryDerivedReferrer_BookListMap;
        public Map<String, LdBookCQ> AuthorId_QueryDerivedReferrer_BookList { get { return _authorId_QueryDerivedReferrer_BookListMap; } }
        public override String keepAuthorId_QueryDerivedReferrer_BookList(LdBookCQ subQuery) {
            if (_authorId_QueryDerivedReferrer_BookListMap == null) { _authorId_QueryDerivedReferrer_BookListMap = new LinkedHashMap<String, LdBookCQ>(); }
            String key = "subQueryMapKey" + (_authorId_QueryDerivedReferrer_BookListMap.size() + 1);
            _authorId_QueryDerivedReferrer_BookListMap.put(key, subQuery); return "AuthorId_QueryDerivedReferrer_BookList." + key;
        }
        protected Map<String, Object> _authorId_QueryDerivedReferrer_BookListParameterMap;
        public Map<String, Object> AuthorId_QueryDerivedReferrer_BookListParameter { get { return _authorId_QueryDerivedReferrer_BookListParameterMap; } }
        public override String keepAuthorId_QueryDerivedReferrer_BookListParameter(Object parameterValue) {
            if (_authorId_QueryDerivedReferrer_BookListParameterMap == null) { _authorId_QueryDerivedReferrer_BookListParameterMap = new LinkedHashMap<String, Object>(); }
            String key = "subQueryParameterKey" + (_authorId_QueryDerivedReferrer_BookListParameterMap.size() + 1);
            _authorId_QueryDerivedReferrer_BookListParameterMap.put(key, parameterValue); return "AuthorId_QueryDerivedReferrer_BookListParameter." + key;
        }

        public LdBsAuthorCQ AddOrderBy_AuthorId_Asc() { regOBA("AUTHOR_ID");return this; }
        public LdBsAuthorCQ AddOrderBy_AuthorId_Desc() { regOBD("AUTHOR_ID");return this; }

        protected LdConditionValue _authorName;
        public LdConditionValue AuthorName {
            get { if (_authorName == null) { _authorName = new LdConditionValue(); } return _authorName; }
        }
        protected override LdConditionValue getCValueAuthorName() { return this.AuthorName; }


        public LdBsAuthorCQ AddOrderBy_AuthorName_Asc() { regOBA("AUTHOR_NAME");return this; }
        public LdBsAuthorCQ AddOrderBy_AuthorName_Desc() { regOBD("AUTHOR_NAME");return this; }

        protected LdConditionValue _authorAge;
        public LdConditionValue AuthorAge {
            get { if (_authorAge == null) { _authorAge = new LdConditionValue(); } return _authorAge; }
        }
        protected override LdConditionValue getCValueAuthorAge() { return this.AuthorAge; }


        public LdBsAuthorCQ AddOrderBy_AuthorAge_Asc() { regOBA("AUTHOR_AGE");return this; }
        public LdBsAuthorCQ AddOrderBy_AuthorAge_Desc() { regOBD("AUTHOR_AGE");return this; }

        protected LdConditionValue _rUser;
        public LdConditionValue RUser {
            get { if (_rUser == null) { _rUser = new LdConditionValue(); } return _rUser; }
        }
        protected override LdConditionValue getCValueRUser() { return this.RUser; }


        public LdBsAuthorCQ AddOrderBy_RUser_Asc() { regOBA("R_USER");return this; }
        public LdBsAuthorCQ AddOrderBy_RUser_Desc() { regOBD("R_USER");return this; }

        protected LdConditionValue _rModule;
        public LdConditionValue RModule {
            get { if (_rModule == null) { _rModule = new LdConditionValue(); } return _rModule; }
        }
        protected override LdConditionValue getCValueRModule() { return this.RModule; }


        public LdBsAuthorCQ AddOrderBy_RModule_Asc() { regOBA("R_MODULE");return this; }
        public LdBsAuthorCQ AddOrderBy_RModule_Desc() { regOBD("R_MODULE");return this; }

        protected LdConditionValue _rTimestamp;
        public LdConditionValue RTimestamp {
            get { if (_rTimestamp == null) { _rTimestamp = new LdConditionValue(); } return _rTimestamp; }
        }
        protected override LdConditionValue getCValueRTimestamp() { return this.RTimestamp; }


        public LdBsAuthorCQ AddOrderBy_RTimestamp_Asc() { regOBA("R_TIMESTAMP");return this; }
        public LdBsAuthorCQ AddOrderBy_RTimestamp_Desc() { regOBD("R_TIMESTAMP");return this; }

        protected LdConditionValue _uUser;
        public LdConditionValue UUser {
            get { if (_uUser == null) { _uUser = new LdConditionValue(); } return _uUser; }
        }
        protected override LdConditionValue getCValueUUser() { return this.UUser; }


        public LdBsAuthorCQ AddOrderBy_UUser_Asc() { regOBA("U_USER");return this; }
        public LdBsAuthorCQ AddOrderBy_UUser_Desc() { regOBD("U_USER");return this; }

        protected LdConditionValue _uModule;
        public LdConditionValue UModule {
            get { if (_uModule == null) { _uModule = new LdConditionValue(); } return _uModule; }
        }
        protected override LdConditionValue getCValueUModule() { return this.UModule; }


        public LdBsAuthorCQ AddOrderBy_UModule_Asc() { regOBA("U_MODULE");return this; }
        public LdBsAuthorCQ AddOrderBy_UModule_Desc() { regOBD("U_MODULE");return this; }

        protected LdConditionValue _uTimestamp;
        public LdConditionValue UTimestamp {
            get { if (_uTimestamp == null) { _uTimestamp = new LdConditionValue(); } return _uTimestamp; }
        }
        protected override LdConditionValue getCValueUTimestamp() { return this.UTimestamp; }


        public LdBsAuthorCQ AddOrderBy_UTimestamp_Asc() { regOBA("U_TIMESTAMP");return this; }
        public LdBsAuthorCQ AddOrderBy_UTimestamp_Desc() { regOBD("U_TIMESTAMP");return this; }

        public LdBsAuthorCQ AddSpecifiedDerivedOrderBy_Asc(String aliasName) { registerSpecifiedDerivedOrderBy_Asc(aliasName); return this; }
        public LdBsAuthorCQ AddSpecifiedDerivedOrderBy_Desc(String aliasName) { registerSpecifiedDerivedOrderBy_Desc(aliasName); return this; }

        public override void reflectRelationOnUnionQuery(LdConditionQuery baseQueryAsSuper, LdConditionQuery unionQueryAsSuper) {

        }
    


	    // ===============================================================================
	    //                                                                 Scalar SubQuery
	    //                                                                 ===============
	    protected Map<String, LdAuthorCQ> _scalarSubQueryMap;
	    public Map<String, LdAuthorCQ> ScalarSubQuery { get { return _scalarSubQueryMap; } }
	    public override String keepScalarSubQuery(LdAuthorCQ subQuery) {
	        if (_scalarSubQueryMap == null) { _scalarSubQueryMap = new LinkedHashMap<String, LdAuthorCQ>(); }
	        String key = "subQueryMapKey" + (_scalarSubQueryMap.size() + 1);
	        _scalarSubQueryMap.put(key, subQuery); return "ScalarSubQuery." + key;
	    }

        // ===============================================================================
        //                                                         Myself InScope SubQuery
        //                                                         =======================
        protected Map<String, LdAuthorCQ> _myselfInScopeSubQueryMap;
        public Map<String, LdAuthorCQ> MyselfInScopeSubQuery { get { return _myselfInScopeSubQueryMap; } }
        public override String keepMyselfInScopeSubQuery(LdAuthorCQ subQuery) {
            if (_myselfInScopeSubQueryMap == null) { _myselfInScopeSubQueryMap = new LinkedHashMap<String, LdAuthorCQ>(); }
            String key = "subQueryMapKey" + (_myselfInScopeSubQueryMap.size() + 1);
            _myselfInScopeSubQueryMap.put(key, subQuery); return "MyselfInScopeSubQuery." + key;
        }
    }
}
