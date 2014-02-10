
using System;

using DfExample.DBFlute.LibraryDb.AllCommon.CBean;
using DfExample.DBFlute.LibraryDb.AllCommon.CBean.CValue;
using DfExample.DBFlute.LibraryDb.AllCommon.CBean.SClause;
using DfExample.DBFlute.LibraryDb.AllCommon.JavaLike;
using DfExample.DBFlute.LibraryDb.CBean.CQ;
using DfExample.DBFlute.LibraryDb.CBean.CQ.Ciq;

namespace DfExample.DBFlute.LibraryDb.CBean.CQ.BS {

    [System.Serializable]
    public class LdBsGenreCQ : LdAbstractBsGenreCQ {

        protected LdGenreCIQ _inlineQuery;

        public LdBsGenreCQ(LdConditionQuery childQuery, LdSqlClause sqlClause, String aliasName, int nestLevel)
            : base(childQuery, sqlClause, aliasName, nestLevel) {}

        public LdGenreCIQ Inline() {
            if (_inlineQuery == null) {
                _inlineQuery = new LdGenreCIQ(xgetReferrerQuery(), xgetSqlClause(), xgetAliasName(), xgetNestLevel(), this);
            }
            _inlineQuery.xsetOnClause(false);
            return _inlineQuery;
        }
        
        public LdGenreCIQ On() {
            if (isBaseQuery()) { throw new UnsupportedOperationException("Unsupported onClause of Base Table!"); }
            LdGenreCIQ inlineQuery = Inline();
            inlineQuery.xsetOnClause(true);
            return inlineQuery;
        }


        protected LdConditionValue _genreCode;
        public LdConditionValue GenreCode {
            get { if (_genreCode == null) { _genreCode = new LdConditionValue(); } return _genreCode; }
        }
        protected override LdConditionValue getCValueGenreCode() { return this.GenreCode; }


        protected Map<String, LdBookCQ> _genreCode_ExistsSubQuery_BookListMap;
        public Map<String, LdBookCQ> GenreCode_ExistsSubQuery_BookList { get { return _genreCode_ExistsSubQuery_BookListMap; }}
        public override String keepGenreCode_ExistsSubQuery_BookList(LdBookCQ subQuery) {
            if (_genreCode_ExistsSubQuery_BookListMap == null) { _genreCode_ExistsSubQuery_BookListMap = new LinkedHashMap<String, LdBookCQ>(); }
            String key = "subQueryMapKey" + (_genreCode_ExistsSubQuery_BookListMap.size() + 1);
            _genreCode_ExistsSubQuery_BookListMap.put(key, subQuery); return "GenreCode_ExistsSubQuery_BookList." + key;
        }

        protected Map<String, LdGenreCQ> _genreCode_ExistsSubQuery_GenreSelfListMap;
        public Map<String, LdGenreCQ> GenreCode_ExistsSubQuery_GenreSelfList { get { return _genreCode_ExistsSubQuery_GenreSelfListMap; }}
        public override String keepGenreCode_ExistsSubQuery_GenreSelfList(LdGenreCQ subQuery) {
            if (_genreCode_ExistsSubQuery_GenreSelfListMap == null) { _genreCode_ExistsSubQuery_GenreSelfListMap = new LinkedHashMap<String, LdGenreCQ>(); }
            String key = "subQueryMapKey" + (_genreCode_ExistsSubQuery_GenreSelfListMap.size() + 1);
            _genreCode_ExistsSubQuery_GenreSelfListMap.put(key, subQuery); return "GenreCode_ExistsSubQuery_GenreSelfList." + key;
        }

        protected Map<String, LdBookCQ> _genreCode_NotExistsSubQuery_BookListMap;
        public Map<String, LdBookCQ> GenreCode_NotExistsSubQuery_BookList { get { return _genreCode_NotExistsSubQuery_BookListMap; }}
        public override String keepGenreCode_NotExistsSubQuery_BookList(LdBookCQ subQuery) {
            if (_genreCode_NotExistsSubQuery_BookListMap == null) { _genreCode_NotExistsSubQuery_BookListMap = new LinkedHashMap<String, LdBookCQ>(); }
            String key = "subQueryMapKey" + (_genreCode_NotExistsSubQuery_BookListMap.size() + 1);
            _genreCode_NotExistsSubQuery_BookListMap.put(key, subQuery); return "GenreCode_NotExistsSubQuery_BookList." + key;
        }

        protected Map<String, LdGenreCQ> _genreCode_NotExistsSubQuery_GenreSelfListMap;
        public Map<String, LdGenreCQ> GenreCode_NotExistsSubQuery_GenreSelfList { get { return _genreCode_NotExistsSubQuery_GenreSelfListMap; }}
        public override String keepGenreCode_NotExistsSubQuery_GenreSelfList(LdGenreCQ subQuery) {
            if (_genreCode_NotExistsSubQuery_GenreSelfListMap == null) { _genreCode_NotExistsSubQuery_GenreSelfListMap = new LinkedHashMap<String, LdGenreCQ>(); }
            String key = "subQueryMapKey" + (_genreCode_NotExistsSubQuery_GenreSelfListMap.size() + 1);
            _genreCode_NotExistsSubQuery_GenreSelfListMap.put(key, subQuery); return "GenreCode_NotExistsSubQuery_GenreSelfList." + key;
        }

        protected Map<String, LdBookCQ> _genreCode_InScopeSubQuery_BookListMap;
        public Map<String, LdBookCQ> GenreCode_InScopeSubQuery_BookList { get { return _genreCode_InScopeSubQuery_BookListMap; }}
        public override String keepGenreCode_InScopeSubQuery_BookList(LdBookCQ subQuery) {
            if (_genreCode_InScopeSubQuery_BookListMap == null) { _genreCode_InScopeSubQuery_BookListMap = new LinkedHashMap<String, LdBookCQ>(); }
            String key = "subQueryMapKey" + (_genreCode_InScopeSubQuery_BookListMap.size() + 1);
            _genreCode_InScopeSubQuery_BookListMap.put(key, subQuery); return "GenreCode_InScopeSubQuery_BookList." + key;
        }

        protected Map<String, LdGenreCQ> _genreCode_InScopeSubQuery_GenreSelfListMap;
        public Map<String, LdGenreCQ> GenreCode_InScopeSubQuery_GenreSelfList { get { return _genreCode_InScopeSubQuery_GenreSelfListMap; }}
        public override String keepGenreCode_InScopeSubQuery_GenreSelfList(LdGenreCQ subQuery) {
            if (_genreCode_InScopeSubQuery_GenreSelfListMap == null) { _genreCode_InScopeSubQuery_GenreSelfListMap = new LinkedHashMap<String, LdGenreCQ>(); }
            String key = "subQueryMapKey" + (_genreCode_InScopeSubQuery_GenreSelfListMap.size() + 1);
            _genreCode_InScopeSubQuery_GenreSelfListMap.put(key, subQuery); return "GenreCode_InScopeSubQuery_GenreSelfList." + key;
        }

        protected Map<String, LdBookCQ> _genreCode_NotInScopeSubQuery_BookListMap;
        public Map<String, LdBookCQ> GenreCode_NotInScopeSubQuery_BookList { get { return _genreCode_NotInScopeSubQuery_BookListMap; }}
        public override String keepGenreCode_NotInScopeSubQuery_BookList(LdBookCQ subQuery) {
            if (_genreCode_NotInScopeSubQuery_BookListMap == null) { _genreCode_NotInScopeSubQuery_BookListMap = new LinkedHashMap<String, LdBookCQ>(); }
            String key = "subQueryMapKey" + (_genreCode_NotInScopeSubQuery_BookListMap.size() + 1);
            _genreCode_NotInScopeSubQuery_BookListMap.put(key, subQuery); return "GenreCode_NotInScopeSubQuery_BookList." + key;
        }

        protected Map<String, LdGenreCQ> _genreCode_NotInScopeSubQuery_GenreSelfListMap;
        public Map<String, LdGenreCQ> GenreCode_NotInScopeSubQuery_GenreSelfList { get { return _genreCode_NotInScopeSubQuery_GenreSelfListMap; }}
        public override String keepGenreCode_NotInScopeSubQuery_GenreSelfList(LdGenreCQ subQuery) {
            if (_genreCode_NotInScopeSubQuery_GenreSelfListMap == null) { _genreCode_NotInScopeSubQuery_GenreSelfListMap = new LinkedHashMap<String, LdGenreCQ>(); }
            String key = "subQueryMapKey" + (_genreCode_NotInScopeSubQuery_GenreSelfListMap.size() + 1);
            _genreCode_NotInScopeSubQuery_GenreSelfListMap.put(key, subQuery); return "GenreCode_NotInScopeSubQuery_GenreSelfList." + key;
        }

        protected Map<String, LdBookCQ> _genreCode_SpecifyDerivedReferrer_BookListMap;
        public Map<String, LdBookCQ> GenreCode_SpecifyDerivedReferrer_BookList { get { return _genreCode_SpecifyDerivedReferrer_BookListMap; }}
        public override String keepGenreCode_SpecifyDerivedReferrer_BookList(LdBookCQ subQuery) {
            if (_genreCode_SpecifyDerivedReferrer_BookListMap == null) { _genreCode_SpecifyDerivedReferrer_BookListMap = new LinkedHashMap<String, LdBookCQ>(); }
            String key = "subQueryMapKey" + (_genreCode_SpecifyDerivedReferrer_BookListMap.size() + 1);
           _genreCode_SpecifyDerivedReferrer_BookListMap.put(key, subQuery); return "GenreCode_SpecifyDerivedReferrer_BookList." + key;
        }

        protected Map<String, LdGenreCQ> _genreCode_SpecifyDerivedReferrer_GenreSelfListMap;
        public Map<String, LdGenreCQ> GenreCode_SpecifyDerivedReferrer_GenreSelfList { get { return _genreCode_SpecifyDerivedReferrer_GenreSelfListMap; }}
        public override String keepGenreCode_SpecifyDerivedReferrer_GenreSelfList(LdGenreCQ subQuery) {
            if (_genreCode_SpecifyDerivedReferrer_GenreSelfListMap == null) { _genreCode_SpecifyDerivedReferrer_GenreSelfListMap = new LinkedHashMap<String, LdGenreCQ>(); }
            String key = "subQueryMapKey" + (_genreCode_SpecifyDerivedReferrer_GenreSelfListMap.size() + 1);
           _genreCode_SpecifyDerivedReferrer_GenreSelfListMap.put(key, subQuery); return "GenreCode_SpecifyDerivedReferrer_GenreSelfList." + key;
        }

        protected Map<String, LdBookCQ> _genreCode_QueryDerivedReferrer_BookListMap;
        public Map<String, LdBookCQ> GenreCode_QueryDerivedReferrer_BookList { get { return _genreCode_QueryDerivedReferrer_BookListMap; } }
        public override String keepGenreCode_QueryDerivedReferrer_BookList(LdBookCQ subQuery) {
            if (_genreCode_QueryDerivedReferrer_BookListMap == null) { _genreCode_QueryDerivedReferrer_BookListMap = new LinkedHashMap<String, LdBookCQ>(); }
            String key = "subQueryMapKey" + (_genreCode_QueryDerivedReferrer_BookListMap.size() + 1);
            _genreCode_QueryDerivedReferrer_BookListMap.put(key, subQuery); return "GenreCode_QueryDerivedReferrer_BookList." + key;
        }
        protected Map<String, Object> _genreCode_QueryDerivedReferrer_BookListParameterMap;
        public Map<String, Object> GenreCode_QueryDerivedReferrer_BookListParameter { get { return _genreCode_QueryDerivedReferrer_BookListParameterMap; } }
        public override String keepGenreCode_QueryDerivedReferrer_BookListParameter(Object parameterValue) {
            if (_genreCode_QueryDerivedReferrer_BookListParameterMap == null) { _genreCode_QueryDerivedReferrer_BookListParameterMap = new LinkedHashMap<String, Object>(); }
            String key = "subQueryParameterKey" + (_genreCode_QueryDerivedReferrer_BookListParameterMap.size() + 1);
            _genreCode_QueryDerivedReferrer_BookListParameterMap.put(key, parameterValue); return "GenreCode_QueryDerivedReferrer_BookListParameter." + key;
        }

        protected Map<String, LdGenreCQ> _genreCode_QueryDerivedReferrer_GenreSelfListMap;
        public Map<String, LdGenreCQ> GenreCode_QueryDerivedReferrer_GenreSelfList { get { return _genreCode_QueryDerivedReferrer_GenreSelfListMap; } }
        public override String keepGenreCode_QueryDerivedReferrer_GenreSelfList(LdGenreCQ subQuery) {
            if (_genreCode_QueryDerivedReferrer_GenreSelfListMap == null) { _genreCode_QueryDerivedReferrer_GenreSelfListMap = new LinkedHashMap<String, LdGenreCQ>(); }
            String key = "subQueryMapKey" + (_genreCode_QueryDerivedReferrer_GenreSelfListMap.size() + 1);
            _genreCode_QueryDerivedReferrer_GenreSelfListMap.put(key, subQuery); return "GenreCode_QueryDerivedReferrer_GenreSelfList." + key;
        }
        protected Map<String, Object> _genreCode_QueryDerivedReferrer_GenreSelfListParameterMap;
        public Map<String, Object> GenreCode_QueryDerivedReferrer_GenreSelfListParameter { get { return _genreCode_QueryDerivedReferrer_GenreSelfListParameterMap; } }
        public override String keepGenreCode_QueryDerivedReferrer_GenreSelfListParameter(Object parameterValue) {
            if (_genreCode_QueryDerivedReferrer_GenreSelfListParameterMap == null) { _genreCode_QueryDerivedReferrer_GenreSelfListParameterMap = new LinkedHashMap<String, Object>(); }
            String key = "subQueryParameterKey" + (_genreCode_QueryDerivedReferrer_GenreSelfListParameterMap.size() + 1);
            _genreCode_QueryDerivedReferrer_GenreSelfListParameterMap.put(key, parameterValue); return "GenreCode_QueryDerivedReferrer_GenreSelfListParameter." + key;
        }

        public LdBsGenreCQ AddOrderBy_GenreCode_Asc() { regOBA("GENRE_CODE");return this; }
        public LdBsGenreCQ AddOrderBy_GenreCode_Desc() { regOBD("GENRE_CODE");return this; }

        protected LdConditionValue _genreName;
        public LdConditionValue GenreName {
            get { if (_genreName == null) { _genreName = new LdConditionValue(); } return _genreName; }
        }
        protected override LdConditionValue getCValueGenreName() { return this.GenreName; }


        public LdBsGenreCQ AddOrderBy_GenreName_Asc() { regOBA("GENRE_NAME");return this; }
        public LdBsGenreCQ AddOrderBy_GenreName_Desc() { regOBD("GENRE_NAME");return this; }

        protected LdConditionValue _hierarchyLevel;
        public LdConditionValue HierarchyLevel {
            get { if (_hierarchyLevel == null) { _hierarchyLevel = new LdConditionValue(); } return _hierarchyLevel; }
        }
        protected override LdConditionValue getCValueHierarchyLevel() { return this.HierarchyLevel; }


        public LdBsGenreCQ AddOrderBy_HierarchyLevel_Asc() { regOBA("HIERARCHY_LEVEL");return this; }
        public LdBsGenreCQ AddOrderBy_HierarchyLevel_Desc() { regOBD("HIERARCHY_LEVEL");return this; }

        protected LdConditionValue _hierarchyOrder;
        public LdConditionValue HierarchyOrder {
            get { if (_hierarchyOrder == null) { _hierarchyOrder = new LdConditionValue(); } return _hierarchyOrder; }
        }
        protected override LdConditionValue getCValueHierarchyOrder() { return this.HierarchyOrder; }


        public LdBsGenreCQ AddOrderBy_HierarchyOrder_Asc() { regOBA("HIERARCHY_ORDER");return this; }
        public LdBsGenreCQ AddOrderBy_HierarchyOrder_Desc() { regOBD("HIERARCHY_ORDER");return this; }

        protected LdConditionValue _parentGenreCode;
        public LdConditionValue ParentGenreCode {
            get { if (_parentGenreCode == null) { _parentGenreCode = new LdConditionValue(); } return _parentGenreCode; }
        }
        protected override LdConditionValue getCValueParentGenreCode() { return this.ParentGenreCode; }


        protected Map<String, LdGenreCQ> _parentGenreCode_InScopeSubQuery_GenreSelfMap;
        public Map<String, LdGenreCQ> ParentGenreCode_InScopeSubQuery_GenreSelf { get { return _parentGenreCode_InScopeSubQuery_GenreSelfMap; }}
        public override String keepParentGenreCode_InScopeSubQuery_GenreSelf(LdGenreCQ subQuery) {
            if (_parentGenreCode_InScopeSubQuery_GenreSelfMap == null) { _parentGenreCode_InScopeSubQuery_GenreSelfMap = new LinkedHashMap<String, LdGenreCQ>(); }
            String key = "subQueryMapKey" + (_parentGenreCode_InScopeSubQuery_GenreSelfMap.size() + 1);
            _parentGenreCode_InScopeSubQuery_GenreSelfMap.put(key, subQuery); return "ParentGenreCode_InScopeSubQuery_GenreSelf." + key;
        }

        protected Map<String, LdGenreCQ> _parentGenreCode_NotInScopeSubQuery_GenreSelfMap;
        public Map<String, LdGenreCQ> ParentGenreCode_NotInScopeSubQuery_GenreSelf { get { return _parentGenreCode_NotInScopeSubQuery_GenreSelfMap; }}
        public override String keepParentGenreCode_NotInScopeSubQuery_GenreSelf(LdGenreCQ subQuery) {
            if (_parentGenreCode_NotInScopeSubQuery_GenreSelfMap == null) { _parentGenreCode_NotInScopeSubQuery_GenreSelfMap = new LinkedHashMap<String, LdGenreCQ>(); }
            String key = "subQueryMapKey" + (_parentGenreCode_NotInScopeSubQuery_GenreSelfMap.size() + 1);
            _parentGenreCode_NotInScopeSubQuery_GenreSelfMap.put(key, subQuery); return "ParentGenreCode_NotInScopeSubQuery_GenreSelf." + key;
        }

        public LdBsGenreCQ AddOrderBy_ParentGenreCode_Asc() { regOBA("PARENT_GENRE_CODE");return this; }
        public LdBsGenreCQ AddOrderBy_ParentGenreCode_Desc() { regOBD("PARENT_GENRE_CODE");return this; }

        protected LdConditionValue _rUser;
        public LdConditionValue RUser {
            get { if (_rUser == null) { _rUser = new LdConditionValue(); } return _rUser; }
        }
        protected override LdConditionValue getCValueRUser() { return this.RUser; }


        public LdBsGenreCQ AddOrderBy_RUser_Asc() { regOBA("R_USER");return this; }
        public LdBsGenreCQ AddOrderBy_RUser_Desc() { regOBD("R_USER");return this; }

        protected LdConditionValue _rModule;
        public LdConditionValue RModule {
            get { if (_rModule == null) { _rModule = new LdConditionValue(); } return _rModule; }
        }
        protected override LdConditionValue getCValueRModule() { return this.RModule; }


        public LdBsGenreCQ AddOrderBy_RModule_Asc() { regOBA("R_MODULE");return this; }
        public LdBsGenreCQ AddOrderBy_RModule_Desc() { regOBD("R_MODULE");return this; }

        protected LdConditionValue _rTimestamp;
        public LdConditionValue RTimestamp {
            get { if (_rTimestamp == null) { _rTimestamp = new LdConditionValue(); } return _rTimestamp; }
        }
        protected override LdConditionValue getCValueRTimestamp() { return this.RTimestamp; }


        public LdBsGenreCQ AddOrderBy_RTimestamp_Asc() { regOBA("R_TIMESTAMP");return this; }
        public LdBsGenreCQ AddOrderBy_RTimestamp_Desc() { regOBD("R_TIMESTAMP");return this; }

        protected LdConditionValue _uUser;
        public LdConditionValue UUser {
            get { if (_uUser == null) { _uUser = new LdConditionValue(); } return _uUser; }
        }
        protected override LdConditionValue getCValueUUser() { return this.UUser; }


        public LdBsGenreCQ AddOrderBy_UUser_Asc() { regOBA("U_USER");return this; }
        public LdBsGenreCQ AddOrderBy_UUser_Desc() { regOBD("U_USER");return this; }

        protected LdConditionValue _uModule;
        public LdConditionValue UModule {
            get { if (_uModule == null) { _uModule = new LdConditionValue(); } return _uModule; }
        }
        protected override LdConditionValue getCValueUModule() { return this.UModule; }


        public LdBsGenreCQ AddOrderBy_UModule_Asc() { regOBA("U_MODULE");return this; }
        public LdBsGenreCQ AddOrderBy_UModule_Desc() { regOBD("U_MODULE");return this; }

        protected LdConditionValue _uTimestamp;
        public LdConditionValue UTimestamp {
            get { if (_uTimestamp == null) { _uTimestamp = new LdConditionValue(); } return _uTimestamp; }
        }
        protected override LdConditionValue getCValueUTimestamp() { return this.UTimestamp; }


        public LdBsGenreCQ AddOrderBy_UTimestamp_Asc() { regOBA("U_TIMESTAMP");return this; }
        public LdBsGenreCQ AddOrderBy_UTimestamp_Desc() { regOBD("U_TIMESTAMP");return this; }

        public LdBsGenreCQ AddSpecifiedDerivedOrderBy_Asc(String aliasName) { registerSpecifiedDerivedOrderBy_Asc(aliasName); return this; }
        public LdBsGenreCQ AddSpecifiedDerivedOrderBy_Desc(String aliasName) { registerSpecifiedDerivedOrderBy_Desc(aliasName); return this; }

        public override void reflectRelationOnUnionQuery(LdConditionQuery baseQueryAsSuper, LdConditionQuery unionQueryAsSuper) {
            LdGenreCQ baseQuery = (LdGenreCQ)baseQueryAsSuper;
            LdGenreCQ unionQuery = (LdGenreCQ)unionQueryAsSuper;
            if (baseQuery.hasConditionQueryGenreSelf()) {
                unionQuery.QueryGenreSelf().reflectRelationOnUnionQuery(baseQuery.QueryGenreSelf(), unionQuery.QueryGenreSelf());
            }

        }
    
        protected LdGenreCQ _conditionQueryGenreSelf;
        public LdGenreCQ QueryGenreSelf() {
            return this.ConditionQueryGenreSelf;
        }
        public LdGenreCQ ConditionQueryGenreSelf {
            get {
                if (_conditionQueryGenreSelf == null) {
                    _conditionQueryGenreSelf = xcreateQueryGenreSelf();
                    xsetupOuterJoin_GenreSelf();
                }
                return _conditionQueryGenreSelf;
            }
        }
        protected LdGenreCQ xcreateQueryGenreSelf() {
            String nrp = resolveNextRelationPathGenreSelf();
            String jan = resolveJoinAliasName(nrp, xgetNextNestLevel());
            LdGenreCQ cq = new LdGenreCQ(this, xgetSqlClause(), jan, xgetNextNestLevel());
            cq.xsetForeignPropertyName("genreSelf"); cq.xsetRelationPath(nrp); return cq;
        }
        public void xsetupOuterJoin_GenreSelf() {
            LdGenreCQ cq = ConditionQueryGenreSelf;
            Map<String, String> joinOnMap = new LinkedHashMap<String, String>();
            joinOnMap.put("PARENT_GENRE_CODE", "GENRE_CODE");
            registerOuterJoin(cq, joinOnMap);
        }
        protected String resolveNextRelationPathGenreSelf() {
            return resolveNextRelationPath("genre", "genreSelf");
        }
        public bool hasConditionQueryGenreSelf() {
            return _conditionQueryGenreSelf != null;
        }


	    // ===============================================================================
	    //                                                                 Scalar SubQuery
	    //                                                                 ===============
	    protected Map<String, LdGenreCQ> _scalarSubQueryMap;
	    public Map<String, LdGenreCQ> ScalarSubQuery { get { return _scalarSubQueryMap; } }
	    public override String keepScalarSubQuery(LdGenreCQ subQuery) {
	        if (_scalarSubQueryMap == null) { _scalarSubQueryMap = new LinkedHashMap<String, LdGenreCQ>(); }
	        String key = "subQueryMapKey" + (_scalarSubQueryMap.size() + 1);
	        _scalarSubQueryMap.put(key, subQuery); return "ScalarSubQuery." + key;
	    }

        // ===============================================================================
        //                                                         Myself InScope SubQuery
        //                                                         =======================
        protected Map<String, LdGenreCQ> _myselfInScopeSubQueryMap;
        public Map<String, LdGenreCQ> MyselfInScopeSubQuery { get { return _myselfInScopeSubQueryMap; } }
        public override String keepMyselfInScopeSubQuery(LdGenreCQ subQuery) {
            if (_myselfInScopeSubQueryMap == null) { _myselfInScopeSubQueryMap = new LinkedHashMap<String, LdGenreCQ>(); }
            String key = "subQueryMapKey" + (_myselfInScopeSubQueryMap.size() + 1);
            _myselfInScopeSubQueryMap.put(key, subQuery); return "MyselfInScopeSubQuery." + key;
        }
    }
}
