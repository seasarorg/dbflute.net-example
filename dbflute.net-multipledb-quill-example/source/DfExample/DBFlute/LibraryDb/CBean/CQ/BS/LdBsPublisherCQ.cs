
using System;

using DfExample.DBFlute.LibraryDb.AllCommon.CBean;
using DfExample.DBFlute.LibraryDb.AllCommon.CBean.CValue;
using DfExample.DBFlute.LibraryDb.AllCommon.CBean.SClause;
using DfExample.DBFlute.LibraryDb.AllCommon.JavaLike;
using DfExample.DBFlute.LibraryDb.CBean.CQ;
using DfExample.DBFlute.LibraryDb.CBean.CQ.Ciq;

namespace DfExample.DBFlute.LibraryDb.CBean.CQ.BS {

    [System.Serializable]
    public class LdBsPublisherCQ : LdAbstractBsPublisherCQ {

        protected LdPublisherCIQ _inlineQuery;

        public LdBsPublisherCQ(LdConditionQuery childQuery, LdSqlClause sqlClause, String aliasName, int nestLevel)
            : base(childQuery, sqlClause, aliasName, nestLevel) {}

        public LdPublisherCIQ Inline() {
            if (_inlineQuery == null) {
                _inlineQuery = new LdPublisherCIQ(xgetReferrerQuery(), xgetSqlClause(), xgetAliasName(), xgetNestLevel(), this);
            }
            _inlineQuery.xsetOnClause(false);
            return _inlineQuery;
        }
        
        public LdPublisherCIQ On() {
            if (isBaseQuery()) { throw new UnsupportedOperationException("Unsupported onClause of Base Table!"); }
            LdPublisherCIQ inlineQuery = Inline();
            inlineQuery.xsetOnClause(true);
            return inlineQuery;
        }


        protected LdConditionValue _publisherId;
        public LdConditionValue PublisherId {
            get { if (_publisherId == null) { _publisherId = new LdConditionValue(); } return _publisherId; }
        }
        protected override LdConditionValue getCValuePublisherId() { return this.PublisherId; }


        protected Map<String, LdBookCQ> _publisherId_ExistsSubQuery_BookListMap;
        public Map<String, LdBookCQ> PublisherId_ExistsSubQuery_BookList { get { return _publisherId_ExistsSubQuery_BookListMap; }}
        public override String keepPublisherId_ExistsSubQuery_BookList(LdBookCQ subQuery) {
            if (_publisherId_ExistsSubQuery_BookListMap == null) { _publisherId_ExistsSubQuery_BookListMap = new LinkedHashMap<String, LdBookCQ>(); }
            String key = "subQueryMapKey" + (_publisherId_ExistsSubQuery_BookListMap.size() + 1);
            _publisherId_ExistsSubQuery_BookListMap.put(key, subQuery); return "PublisherId_ExistsSubQuery_BookList." + key;
        }

        protected Map<String, LdBookCQ> _publisherId_NotExistsSubQuery_BookListMap;
        public Map<String, LdBookCQ> PublisherId_NotExistsSubQuery_BookList { get { return _publisherId_NotExistsSubQuery_BookListMap; }}
        public override String keepPublisherId_NotExistsSubQuery_BookList(LdBookCQ subQuery) {
            if (_publisherId_NotExistsSubQuery_BookListMap == null) { _publisherId_NotExistsSubQuery_BookListMap = new LinkedHashMap<String, LdBookCQ>(); }
            String key = "subQueryMapKey" + (_publisherId_NotExistsSubQuery_BookListMap.size() + 1);
            _publisherId_NotExistsSubQuery_BookListMap.put(key, subQuery); return "PublisherId_NotExistsSubQuery_BookList." + key;
        }

        protected Map<String, LdBookCQ> _publisherId_InScopeSubQuery_BookListMap;
        public Map<String, LdBookCQ> PublisherId_InScopeSubQuery_BookList { get { return _publisherId_InScopeSubQuery_BookListMap; }}
        public override String keepPublisherId_InScopeSubQuery_BookList(LdBookCQ subQuery) {
            if (_publisherId_InScopeSubQuery_BookListMap == null) { _publisherId_InScopeSubQuery_BookListMap = new LinkedHashMap<String, LdBookCQ>(); }
            String key = "subQueryMapKey" + (_publisherId_InScopeSubQuery_BookListMap.size() + 1);
            _publisherId_InScopeSubQuery_BookListMap.put(key, subQuery); return "PublisherId_InScopeSubQuery_BookList." + key;
        }

        protected Map<String, LdBookCQ> _publisherId_NotInScopeSubQuery_BookListMap;
        public Map<String, LdBookCQ> PublisherId_NotInScopeSubQuery_BookList { get { return _publisherId_NotInScopeSubQuery_BookListMap; }}
        public override String keepPublisherId_NotInScopeSubQuery_BookList(LdBookCQ subQuery) {
            if (_publisherId_NotInScopeSubQuery_BookListMap == null) { _publisherId_NotInScopeSubQuery_BookListMap = new LinkedHashMap<String, LdBookCQ>(); }
            String key = "subQueryMapKey" + (_publisherId_NotInScopeSubQuery_BookListMap.size() + 1);
            _publisherId_NotInScopeSubQuery_BookListMap.put(key, subQuery); return "PublisherId_NotInScopeSubQuery_BookList." + key;
        }

        protected Map<String, LdBookCQ> _publisherId_SpecifyDerivedReferrer_BookListMap;
        public Map<String, LdBookCQ> PublisherId_SpecifyDerivedReferrer_BookList { get { return _publisherId_SpecifyDerivedReferrer_BookListMap; }}
        public override String keepPublisherId_SpecifyDerivedReferrer_BookList(LdBookCQ subQuery) {
            if (_publisherId_SpecifyDerivedReferrer_BookListMap == null) { _publisherId_SpecifyDerivedReferrer_BookListMap = new LinkedHashMap<String, LdBookCQ>(); }
            String key = "subQueryMapKey" + (_publisherId_SpecifyDerivedReferrer_BookListMap.size() + 1);
            _publisherId_SpecifyDerivedReferrer_BookListMap.put(key, subQuery); return "PublisherId_SpecifyDerivedReferrer_BookList." + key;
        }

        protected Map<String, LdBookCQ> _publisherId_QueryDerivedReferrer_BookListMap;
        public Map<String, LdBookCQ> PublisherId_QueryDerivedReferrer_BookList { get { return _publisherId_QueryDerivedReferrer_BookListMap; } }
        public override String keepPublisherId_QueryDerivedReferrer_BookList(LdBookCQ subQuery) {
            if (_publisherId_QueryDerivedReferrer_BookListMap == null) { _publisherId_QueryDerivedReferrer_BookListMap = new LinkedHashMap<String, LdBookCQ>(); }
            String key = "subQueryMapKey" + (_publisherId_QueryDerivedReferrer_BookListMap.size() + 1);
            _publisherId_QueryDerivedReferrer_BookListMap.put(key, subQuery); return "PublisherId_QueryDerivedReferrer_BookList." + key;
        }
        protected Map<String, Object> _publisherId_QueryDerivedReferrer_BookListParameterMap;
        public Map<String, Object> PublisherId_QueryDerivedReferrer_BookListParameter { get { return _publisherId_QueryDerivedReferrer_BookListParameterMap; } }
        public override String keepPublisherId_QueryDerivedReferrer_BookListParameter(Object parameterValue) {
            if (_publisherId_QueryDerivedReferrer_BookListParameterMap == null) { _publisherId_QueryDerivedReferrer_BookListParameterMap = new LinkedHashMap<String, Object>(); }
            String key = "subQueryParameterKey" + (_publisherId_QueryDerivedReferrer_BookListParameterMap.size() + 1);
            _publisherId_QueryDerivedReferrer_BookListParameterMap.put(key, parameterValue); return "PublisherId_QueryDerivedReferrer_BookListParameter." + key;
        }

        public LdBsPublisherCQ AddOrderBy_PublisherId_Asc() { regOBA("PUBLISHER_ID");return this; }
        public LdBsPublisherCQ AddOrderBy_PublisherId_Desc() { regOBD("PUBLISHER_ID");return this; }

        protected LdConditionValue _publisherName;
        public LdConditionValue PublisherName {
            get { if (_publisherName == null) { _publisherName = new LdConditionValue(); } return _publisherName; }
        }
        protected override LdConditionValue getCValuePublisherName() { return this.PublisherName; }


        public LdBsPublisherCQ AddOrderBy_PublisherName_Asc() { regOBA("PUBLISHER_NAME");return this; }
        public LdBsPublisherCQ AddOrderBy_PublisherName_Desc() { regOBD("PUBLISHER_NAME");return this; }

        protected LdConditionValue _rUser;
        public LdConditionValue RUser {
            get { if (_rUser == null) { _rUser = new LdConditionValue(); } return _rUser; }
        }
        protected override LdConditionValue getCValueRUser() { return this.RUser; }


        public LdBsPublisherCQ AddOrderBy_RUser_Asc() { regOBA("R_USER");return this; }
        public LdBsPublisherCQ AddOrderBy_RUser_Desc() { regOBD("R_USER");return this; }

        protected LdConditionValue _rModule;
        public LdConditionValue RModule {
            get { if (_rModule == null) { _rModule = new LdConditionValue(); } return _rModule; }
        }
        protected override LdConditionValue getCValueRModule() { return this.RModule; }


        public LdBsPublisherCQ AddOrderBy_RModule_Asc() { regOBA("R_MODULE");return this; }
        public LdBsPublisherCQ AddOrderBy_RModule_Desc() { regOBD("R_MODULE");return this; }

        protected LdConditionValue _rTimestamp;
        public LdConditionValue RTimestamp {
            get { if (_rTimestamp == null) { _rTimestamp = new LdConditionValue(); } return _rTimestamp; }
        }
        protected override LdConditionValue getCValueRTimestamp() { return this.RTimestamp; }


        public LdBsPublisherCQ AddOrderBy_RTimestamp_Asc() { regOBA("R_TIMESTAMP");return this; }
        public LdBsPublisherCQ AddOrderBy_RTimestamp_Desc() { regOBD("R_TIMESTAMP");return this; }

        protected LdConditionValue _uUser;
        public LdConditionValue UUser {
            get { if (_uUser == null) { _uUser = new LdConditionValue(); } return _uUser; }
        }
        protected override LdConditionValue getCValueUUser() { return this.UUser; }


        public LdBsPublisherCQ AddOrderBy_UUser_Asc() { regOBA("U_USER");return this; }
        public LdBsPublisherCQ AddOrderBy_UUser_Desc() { regOBD("U_USER");return this; }

        protected LdConditionValue _uModule;
        public LdConditionValue UModule {
            get { if (_uModule == null) { _uModule = new LdConditionValue(); } return _uModule; }
        }
        protected override LdConditionValue getCValueUModule() { return this.UModule; }


        public LdBsPublisherCQ AddOrderBy_UModule_Asc() { regOBA("U_MODULE");return this; }
        public LdBsPublisherCQ AddOrderBy_UModule_Desc() { regOBD("U_MODULE");return this; }

        protected LdConditionValue _uTimestamp;
        public LdConditionValue UTimestamp {
            get { if (_uTimestamp == null) { _uTimestamp = new LdConditionValue(); } return _uTimestamp; }
        }
        protected override LdConditionValue getCValueUTimestamp() { return this.UTimestamp; }


        public LdBsPublisherCQ AddOrderBy_UTimestamp_Asc() { regOBA("U_TIMESTAMP");return this; }
        public LdBsPublisherCQ AddOrderBy_UTimestamp_Desc() { regOBD("U_TIMESTAMP");return this; }

        public LdBsPublisherCQ AddSpecifiedDerivedOrderBy_Asc(String aliasName) { registerSpecifiedDerivedOrderBy_Asc(aliasName); return this; }
        public LdBsPublisherCQ AddSpecifiedDerivedOrderBy_Desc(String aliasName) { registerSpecifiedDerivedOrderBy_Desc(aliasName); return this; }

        public override void reflectRelationOnUnionQuery(LdConditionQuery baseQueryAsSuper, LdConditionQuery unionQueryAsSuper) {

        }
    


	    // ===============================================================================
	    //                                                                 Scalar SubQuery
	    //                                                                 ===============
	    protected Map<String, LdPublisherCQ> _scalarSubQueryMap;
	    public Map<String, LdPublisherCQ> ScalarSubQuery { get { return _scalarSubQueryMap; } }
	    public override String keepScalarSubQuery(LdPublisherCQ subQuery) {
	        if (_scalarSubQueryMap == null) { _scalarSubQueryMap = new LinkedHashMap<String, LdPublisherCQ>(); }
	        String key = "subQueryMapKey" + (_scalarSubQueryMap.size() + 1);
	        _scalarSubQueryMap.put(key, subQuery); return "ScalarSubQuery." + key;
	    }

        // ===============================================================================
        //                                                         Myself InScope SubQuery
        //                                                         =======================
        protected Map<String, LdPublisherCQ> _myselfInScopeSubQueryMap;
        public Map<String, LdPublisherCQ> MyselfInScopeSubQuery { get { return _myselfInScopeSubQueryMap; } }
        public override String keepMyselfInScopeSubQuery(LdPublisherCQ subQuery) {
            if (_myselfInScopeSubQueryMap == null) { _myselfInScopeSubQueryMap = new LinkedHashMap<String, LdPublisherCQ>(); }
            String key = "subQueryMapKey" + (_myselfInScopeSubQueryMap.size() + 1);
            _myselfInScopeSubQueryMap.put(key, subQuery); return "MyselfInScopeSubQuery." + key;
        }
    }
}
