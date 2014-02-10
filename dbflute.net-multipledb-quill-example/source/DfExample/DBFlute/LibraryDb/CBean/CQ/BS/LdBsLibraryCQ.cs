
using System;

using DfExample.DBFlute.LibraryDb.AllCommon.CBean;
using DfExample.DBFlute.LibraryDb.AllCommon.CBean.CValue;
using DfExample.DBFlute.LibraryDb.AllCommon.CBean.SClause;
using DfExample.DBFlute.LibraryDb.AllCommon.JavaLike;
using DfExample.DBFlute.LibraryDb.CBean.CQ;
using DfExample.DBFlute.LibraryDb.CBean.CQ.Ciq;

namespace DfExample.DBFlute.LibraryDb.CBean.CQ.BS {

    [System.Serializable]
    public class LdBsLibraryCQ : LdAbstractBsLibraryCQ {

        protected LdLibraryCIQ _inlineQuery;

        public LdBsLibraryCQ(LdConditionQuery childQuery, LdSqlClause sqlClause, String aliasName, int nestLevel)
            : base(childQuery, sqlClause, aliasName, nestLevel) {}

        public LdLibraryCIQ Inline() {
            if (_inlineQuery == null) {
                _inlineQuery = new LdLibraryCIQ(xgetReferrerQuery(), xgetSqlClause(), xgetAliasName(), xgetNestLevel(), this);
            }
            _inlineQuery.xsetOnClause(false);
            return _inlineQuery;
        }
        
        public LdLibraryCIQ On() {
            if (isBaseQuery()) { throw new UnsupportedOperationException("Unsupported onClause of Base Table!"); }
            LdLibraryCIQ inlineQuery = Inline();
            inlineQuery.xsetOnClause(true);
            return inlineQuery;
        }


        protected LdConditionValue _libraryId;
        public LdConditionValue LibraryId {
            get { if (_libraryId == null) { _libraryId = new LdConditionValue(); } return _libraryId; }
        }
        protected override LdConditionValue getCValueLibraryId() { return this.LibraryId; }


        protected Map<String, LdCollectionCQ> _libraryId_ExistsSubQuery_CollectionListMap;
        public Map<String, LdCollectionCQ> LibraryId_ExistsSubQuery_CollectionList { get { return _libraryId_ExistsSubQuery_CollectionListMap; }}
        public override String keepLibraryId_ExistsSubQuery_CollectionList(LdCollectionCQ subQuery) {
            if (_libraryId_ExistsSubQuery_CollectionListMap == null) { _libraryId_ExistsSubQuery_CollectionListMap = new LinkedHashMap<String, LdCollectionCQ>(); }
            String key = "subQueryMapKey" + (_libraryId_ExistsSubQuery_CollectionListMap.size() + 1);
            _libraryId_ExistsSubQuery_CollectionListMap.put(key, subQuery); return "LibraryId_ExistsSubQuery_CollectionList." + key;
        }

        protected Map<String, LdLibraryUserCQ> _libraryId_ExistsSubQuery_LibraryUserListMap;
        public Map<String, LdLibraryUserCQ> LibraryId_ExistsSubQuery_LibraryUserList { get { return _libraryId_ExistsSubQuery_LibraryUserListMap; }}
        public override String keepLibraryId_ExistsSubQuery_LibraryUserList(LdLibraryUserCQ subQuery) {
            if (_libraryId_ExistsSubQuery_LibraryUserListMap == null) { _libraryId_ExistsSubQuery_LibraryUserListMap = new LinkedHashMap<String, LdLibraryUserCQ>(); }
            String key = "subQueryMapKey" + (_libraryId_ExistsSubQuery_LibraryUserListMap.size() + 1);
            _libraryId_ExistsSubQuery_LibraryUserListMap.put(key, subQuery); return "LibraryId_ExistsSubQuery_LibraryUserList." + key;
        }

        protected Map<String, LdNextLibraryCQ> _libraryId_ExistsSubQuery_NextLibraryByLibraryIdListMap;
        public Map<String, LdNextLibraryCQ> LibraryId_ExistsSubQuery_NextLibraryByLibraryIdList { get { return _libraryId_ExistsSubQuery_NextLibraryByLibraryIdListMap; }}
        public override String keepLibraryId_ExistsSubQuery_NextLibraryByLibraryIdList(LdNextLibraryCQ subQuery) {
            if (_libraryId_ExistsSubQuery_NextLibraryByLibraryIdListMap == null) { _libraryId_ExistsSubQuery_NextLibraryByLibraryIdListMap = new LinkedHashMap<String, LdNextLibraryCQ>(); }
            String key = "subQueryMapKey" + (_libraryId_ExistsSubQuery_NextLibraryByLibraryIdListMap.size() + 1);
            _libraryId_ExistsSubQuery_NextLibraryByLibraryIdListMap.put(key, subQuery); return "LibraryId_ExistsSubQuery_NextLibraryByLibraryIdList." + key;
        }

        protected Map<String, LdNextLibraryCQ> _libraryId_ExistsSubQuery_NextLibraryByNextLibraryIdListMap;
        public Map<String, LdNextLibraryCQ> LibraryId_ExistsSubQuery_NextLibraryByNextLibraryIdList { get { return _libraryId_ExistsSubQuery_NextLibraryByNextLibraryIdListMap; }}
        public override String keepLibraryId_ExistsSubQuery_NextLibraryByNextLibraryIdList(LdNextLibraryCQ subQuery) {
            if (_libraryId_ExistsSubQuery_NextLibraryByNextLibraryIdListMap == null) { _libraryId_ExistsSubQuery_NextLibraryByNextLibraryIdListMap = new LinkedHashMap<String, LdNextLibraryCQ>(); }
            String key = "subQueryMapKey" + (_libraryId_ExistsSubQuery_NextLibraryByNextLibraryIdListMap.size() + 1);
            _libraryId_ExistsSubQuery_NextLibraryByNextLibraryIdListMap.put(key, subQuery); return "LibraryId_ExistsSubQuery_NextLibraryByNextLibraryIdList." + key;
        }

        protected Map<String, LdCollectionCQ> _libraryId_NotExistsSubQuery_CollectionListMap;
        public Map<String, LdCollectionCQ> LibraryId_NotExistsSubQuery_CollectionList { get { return _libraryId_NotExistsSubQuery_CollectionListMap; }}
        public override String keepLibraryId_NotExistsSubQuery_CollectionList(LdCollectionCQ subQuery) {
            if (_libraryId_NotExistsSubQuery_CollectionListMap == null) { _libraryId_NotExistsSubQuery_CollectionListMap = new LinkedHashMap<String, LdCollectionCQ>(); }
            String key = "subQueryMapKey" + (_libraryId_NotExistsSubQuery_CollectionListMap.size() + 1);
            _libraryId_NotExistsSubQuery_CollectionListMap.put(key, subQuery); return "LibraryId_NotExistsSubQuery_CollectionList." + key;
        }

        protected Map<String, LdLibraryUserCQ> _libraryId_NotExistsSubQuery_LibraryUserListMap;
        public Map<String, LdLibraryUserCQ> LibraryId_NotExistsSubQuery_LibraryUserList { get { return _libraryId_NotExistsSubQuery_LibraryUserListMap; }}
        public override String keepLibraryId_NotExistsSubQuery_LibraryUserList(LdLibraryUserCQ subQuery) {
            if (_libraryId_NotExistsSubQuery_LibraryUserListMap == null) { _libraryId_NotExistsSubQuery_LibraryUserListMap = new LinkedHashMap<String, LdLibraryUserCQ>(); }
            String key = "subQueryMapKey" + (_libraryId_NotExistsSubQuery_LibraryUserListMap.size() + 1);
            _libraryId_NotExistsSubQuery_LibraryUserListMap.put(key, subQuery); return "LibraryId_NotExistsSubQuery_LibraryUserList." + key;
        }

        protected Map<String, LdNextLibraryCQ> _libraryId_NotExistsSubQuery_NextLibraryByLibraryIdListMap;
        public Map<String, LdNextLibraryCQ> LibraryId_NotExistsSubQuery_NextLibraryByLibraryIdList { get { return _libraryId_NotExistsSubQuery_NextLibraryByLibraryIdListMap; }}
        public override String keepLibraryId_NotExistsSubQuery_NextLibraryByLibraryIdList(LdNextLibraryCQ subQuery) {
            if (_libraryId_NotExistsSubQuery_NextLibraryByLibraryIdListMap == null) { _libraryId_NotExistsSubQuery_NextLibraryByLibraryIdListMap = new LinkedHashMap<String, LdNextLibraryCQ>(); }
            String key = "subQueryMapKey" + (_libraryId_NotExistsSubQuery_NextLibraryByLibraryIdListMap.size() + 1);
            _libraryId_NotExistsSubQuery_NextLibraryByLibraryIdListMap.put(key, subQuery); return "LibraryId_NotExistsSubQuery_NextLibraryByLibraryIdList." + key;
        }

        protected Map<String, LdNextLibraryCQ> _libraryId_NotExistsSubQuery_NextLibraryByNextLibraryIdListMap;
        public Map<String, LdNextLibraryCQ> LibraryId_NotExistsSubQuery_NextLibraryByNextLibraryIdList { get { return _libraryId_NotExistsSubQuery_NextLibraryByNextLibraryIdListMap; }}
        public override String keepLibraryId_NotExistsSubQuery_NextLibraryByNextLibraryIdList(LdNextLibraryCQ subQuery) {
            if (_libraryId_NotExistsSubQuery_NextLibraryByNextLibraryIdListMap == null) { _libraryId_NotExistsSubQuery_NextLibraryByNextLibraryIdListMap = new LinkedHashMap<String, LdNextLibraryCQ>(); }
            String key = "subQueryMapKey" + (_libraryId_NotExistsSubQuery_NextLibraryByNextLibraryIdListMap.size() + 1);
            _libraryId_NotExistsSubQuery_NextLibraryByNextLibraryIdListMap.put(key, subQuery); return "LibraryId_NotExistsSubQuery_NextLibraryByNextLibraryIdList." + key;
        }

        protected Map<String, LdCollectionCQ> _libraryId_InScopeSubQuery_CollectionListMap;
        public Map<String, LdCollectionCQ> LibraryId_InScopeSubQuery_CollectionList { get { return _libraryId_InScopeSubQuery_CollectionListMap; }}
        public override String keepLibraryId_InScopeSubQuery_CollectionList(LdCollectionCQ subQuery) {
            if (_libraryId_InScopeSubQuery_CollectionListMap == null) { _libraryId_InScopeSubQuery_CollectionListMap = new LinkedHashMap<String, LdCollectionCQ>(); }
            String key = "subQueryMapKey" + (_libraryId_InScopeSubQuery_CollectionListMap.size() + 1);
            _libraryId_InScopeSubQuery_CollectionListMap.put(key, subQuery); return "LibraryId_InScopeSubQuery_CollectionList." + key;
        }

        protected Map<String, LdLibraryUserCQ> _libraryId_InScopeSubQuery_LibraryUserListMap;
        public Map<String, LdLibraryUserCQ> LibraryId_InScopeSubQuery_LibraryUserList { get { return _libraryId_InScopeSubQuery_LibraryUserListMap; }}
        public override String keepLibraryId_InScopeSubQuery_LibraryUserList(LdLibraryUserCQ subQuery) {
            if (_libraryId_InScopeSubQuery_LibraryUserListMap == null) { _libraryId_InScopeSubQuery_LibraryUserListMap = new LinkedHashMap<String, LdLibraryUserCQ>(); }
            String key = "subQueryMapKey" + (_libraryId_InScopeSubQuery_LibraryUserListMap.size() + 1);
            _libraryId_InScopeSubQuery_LibraryUserListMap.put(key, subQuery); return "LibraryId_InScopeSubQuery_LibraryUserList." + key;
        }

        protected Map<String, LdNextLibraryCQ> _libraryId_InScopeSubQuery_NextLibraryByLibraryIdListMap;
        public Map<String, LdNextLibraryCQ> LibraryId_InScopeSubQuery_NextLibraryByLibraryIdList { get { return _libraryId_InScopeSubQuery_NextLibraryByLibraryIdListMap; }}
        public override String keepLibraryId_InScopeSubQuery_NextLibraryByLibraryIdList(LdNextLibraryCQ subQuery) {
            if (_libraryId_InScopeSubQuery_NextLibraryByLibraryIdListMap == null) { _libraryId_InScopeSubQuery_NextLibraryByLibraryIdListMap = new LinkedHashMap<String, LdNextLibraryCQ>(); }
            String key = "subQueryMapKey" + (_libraryId_InScopeSubQuery_NextLibraryByLibraryIdListMap.size() + 1);
            _libraryId_InScopeSubQuery_NextLibraryByLibraryIdListMap.put(key, subQuery); return "LibraryId_InScopeSubQuery_NextLibraryByLibraryIdList." + key;
        }

        protected Map<String, LdNextLibraryCQ> _libraryId_InScopeSubQuery_NextLibraryByNextLibraryIdListMap;
        public Map<String, LdNextLibraryCQ> LibraryId_InScopeSubQuery_NextLibraryByNextLibraryIdList { get { return _libraryId_InScopeSubQuery_NextLibraryByNextLibraryIdListMap; }}
        public override String keepLibraryId_InScopeSubQuery_NextLibraryByNextLibraryIdList(LdNextLibraryCQ subQuery) {
            if (_libraryId_InScopeSubQuery_NextLibraryByNextLibraryIdListMap == null) { _libraryId_InScopeSubQuery_NextLibraryByNextLibraryIdListMap = new LinkedHashMap<String, LdNextLibraryCQ>(); }
            String key = "subQueryMapKey" + (_libraryId_InScopeSubQuery_NextLibraryByNextLibraryIdListMap.size() + 1);
            _libraryId_InScopeSubQuery_NextLibraryByNextLibraryIdListMap.put(key, subQuery); return "LibraryId_InScopeSubQuery_NextLibraryByNextLibraryIdList." + key;
        }

        protected Map<String, LdCollectionCQ> _libraryId_NotInScopeSubQuery_CollectionListMap;
        public Map<String, LdCollectionCQ> LibraryId_NotInScopeSubQuery_CollectionList { get { return _libraryId_NotInScopeSubQuery_CollectionListMap; }}
        public override String keepLibraryId_NotInScopeSubQuery_CollectionList(LdCollectionCQ subQuery) {
            if (_libraryId_NotInScopeSubQuery_CollectionListMap == null) { _libraryId_NotInScopeSubQuery_CollectionListMap = new LinkedHashMap<String, LdCollectionCQ>(); }
            String key = "subQueryMapKey" + (_libraryId_NotInScopeSubQuery_CollectionListMap.size() + 1);
            _libraryId_NotInScopeSubQuery_CollectionListMap.put(key, subQuery); return "LibraryId_NotInScopeSubQuery_CollectionList." + key;
        }

        protected Map<String, LdLibraryUserCQ> _libraryId_NotInScopeSubQuery_LibraryUserListMap;
        public Map<String, LdLibraryUserCQ> LibraryId_NotInScopeSubQuery_LibraryUserList { get { return _libraryId_NotInScopeSubQuery_LibraryUserListMap; }}
        public override String keepLibraryId_NotInScopeSubQuery_LibraryUserList(LdLibraryUserCQ subQuery) {
            if (_libraryId_NotInScopeSubQuery_LibraryUserListMap == null) { _libraryId_NotInScopeSubQuery_LibraryUserListMap = new LinkedHashMap<String, LdLibraryUserCQ>(); }
            String key = "subQueryMapKey" + (_libraryId_NotInScopeSubQuery_LibraryUserListMap.size() + 1);
            _libraryId_NotInScopeSubQuery_LibraryUserListMap.put(key, subQuery); return "LibraryId_NotInScopeSubQuery_LibraryUserList." + key;
        }

        protected Map<String, LdNextLibraryCQ> _libraryId_NotInScopeSubQuery_NextLibraryByLibraryIdListMap;
        public Map<String, LdNextLibraryCQ> LibraryId_NotInScopeSubQuery_NextLibraryByLibraryIdList { get { return _libraryId_NotInScopeSubQuery_NextLibraryByLibraryIdListMap; }}
        public override String keepLibraryId_NotInScopeSubQuery_NextLibraryByLibraryIdList(LdNextLibraryCQ subQuery) {
            if (_libraryId_NotInScopeSubQuery_NextLibraryByLibraryIdListMap == null) { _libraryId_NotInScopeSubQuery_NextLibraryByLibraryIdListMap = new LinkedHashMap<String, LdNextLibraryCQ>(); }
            String key = "subQueryMapKey" + (_libraryId_NotInScopeSubQuery_NextLibraryByLibraryIdListMap.size() + 1);
            _libraryId_NotInScopeSubQuery_NextLibraryByLibraryIdListMap.put(key, subQuery); return "LibraryId_NotInScopeSubQuery_NextLibraryByLibraryIdList." + key;
        }

        protected Map<String, LdNextLibraryCQ> _libraryId_NotInScopeSubQuery_NextLibraryByNextLibraryIdListMap;
        public Map<String, LdNextLibraryCQ> LibraryId_NotInScopeSubQuery_NextLibraryByNextLibraryIdList { get { return _libraryId_NotInScopeSubQuery_NextLibraryByNextLibraryIdListMap; }}
        public override String keepLibraryId_NotInScopeSubQuery_NextLibraryByNextLibraryIdList(LdNextLibraryCQ subQuery) {
            if (_libraryId_NotInScopeSubQuery_NextLibraryByNextLibraryIdListMap == null) { _libraryId_NotInScopeSubQuery_NextLibraryByNextLibraryIdListMap = new LinkedHashMap<String, LdNextLibraryCQ>(); }
            String key = "subQueryMapKey" + (_libraryId_NotInScopeSubQuery_NextLibraryByNextLibraryIdListMap.size() + 1);
            _libraryId_NotInScopeSubQuery_NextLibraryByNextLibraryIdListMap.put(key, subQuery); return "LibraryId_NotInScopeSubQuery_NextLibraryByNextLibraryIdList." + key;
        }

        protected Map<String, LdCollectionCQ> _libraryId_SpecifyDerivedReferrer_CollectionListMap;
        public Map<String, LdCollectionCQ> LibraryId_SpecifyDerivedReferrer_CollectionList { get { return _libraryId_SpecifyDerivedReferrer_CollectionListMap; }}
        public override String keepLibraryId_SpecifyDerivedReferrer_CollectionList(LdCollectionCQ subQuery) {
            if (_libraryId_SpecifyDerivedReferrer_CollectionListMap == null) { _libraryId_SpecifyDerivedReferrer_CollectionListMap = new LinkedHashMap<String, LdCollectionCQ>(); }
            String key = "subQueryMapKey" + (_libraryId_SpecifyDerivedReferrer_CollectionListMap.size() + 1);
            _libraryId_SpecifyDerivedReferrer_CollectionListMap.put(key, subQuery); return "LibraryId_SpecifyDerivedReferrer_CollectionList." + key;
        }

        protected Map<String, LdLibraryUserCQ> _libraryId_SpecifyDerivedReferrer_LibraryUserListMap;
        public Map<String, LdLibraryUserCQ> LibraryId_SpecifyDerivedReferrer_LibraryUserList { get { return _libraryId_SpecifyDerivedReferrer_LibraryUserListMap; }}
        public override String keepLibraryId_SpecifyDerivedReferrer_LibraryUserList(LdLibraryUserCQ subQuery) {
            if (_libraryId_SpecifyDerivedReferrer_LibraryUserListMap == null) { _libraryId_SpecifyDerivedReferrer_LibraryUserListMap = new LinkedHashMap<String, LdLibraryUserCQ>(); }
            String key = "subQueryMapKey" + (_libraryId_SpecifyDerivedReferrer_LibraryUserListMap.size() + 1);
            _libraryId_SpecifyDerivedReferrer_LibraryUserListMap.put(key, subQuery); return "LibraryId_SpecifyDerivedReferrer_LibraryUserList." + key;
        }

        protected Map<String, LdNextLibraryCQ> _libraryId_SpecifyDerivedReferrer_NextLibraryByLibraryIdListMap;
        public Map<String, LdNextLibraryCQ> LibraryId_SpecifyDerivedReferrer_NextLibraryByLibraryIdList { get { return _libraryId_SpecifyDerivedReferrer_NextLibraryByLibraryIdListMap; }}
        public override String keepLibraryId_SpecifyDerivedReferrer_NextLibraryByLibraryIdList(LdNextLibraryCQ subQuery) {
            if (_libraryId_SpecifyDerivedReferrer_NextLibraryByLibraryIdListMap == null) { _libraryId_SpecifyDerivedReferrer_NextLibraryByLibraryIdListMap = new LinkedHashMap<String, LdNextLibraryCQ>(); }
            String key = "subQueryMapKey" + (_libraryId_SpecifyDerivedReferrer_NextLibraryByLibraryIdListMap.size() + 1);
            _libraryId_SpecifyDerivedReferrer_NextLibraryByLibraryIdListMap.put(key, subQuery); return "LibraryId_SpecifyDerivedReferrer_NextLibraryByLibraryIdList." + key;
        }

        protected Map<String, LdNextLibraryCQ> _libraryId_SpecifyDerivedReferrer_NextLibraryByNextLibraryIdListMap;
        public Map<String, LdNextLibraryCQ> LibraryId_SpecifyDerivedReferrer_NextLibraryByNextLibraryIdList { get { return _libraryId_SpecifyDerivedReferrer_NextLibraryByNextLibraryIdListMap; }}
        public override String keepLibraryId_SpecifyDerivedReferrer_NextLibraryByNextLibraryIdList(LdNextLibraryCQ subQuery) {
            if (_libraryId_SpecifyDerivedReferrer_NextLibraryByNextLibraryIdListMap == null) { _libraryId_SpecifyDerivedReferrer_NextLibraryByNextLibraryIdListMap = new LinkedHashMap<String, LdNextLibraryCQ>(); }
            String key = "subQueryMapKey" + (_libraryId_SpecifyDerivedReferrer_NextLibraryByNextLibraryIdListMap.size() + 1);
            _libraryId_SpecifyDerivedReferrer_NextLibraryByNextLibraryIdListMap.put(key, subQuery); return "LibraryId_SpecifyDerivedReferrer_NextLibraryByNextLibraryIdList." + key;
        }

        protected Map<String, LdCollectionCQ> _libraryId_QueryDerivedReferrer_CollectionListMap;
        public Map<String, LdCollectionCQ> LibraryId_QueryDerivedReferrer_CollectionList { get { return _libraryId_QueryDerivedReferrer_CollectionListMap; } }
        public override String keepLibraryId_QueryDerivedReferrer_CollectionList(LdCollectionCQ subQuery) {
            if (_libraryId_QueryDerivedReferrer_CollectionListMap == null) { _libraryId_QueryDerivedReferrer_CollectionListMap = new LinkedHashMap<String, LdCollectionCQ>(); }
            String key = "subQueryMapKey" + (_libraryId_QueryDerivedReferrer_CollectionListMap.size() + 1);
            _libraryId_QueryDerivedReferrer_CollectionListMap.put(key, subQuery); return "LibraryId_QueryDerivedReferrer_CollectionList." + key;
        }
        protected Map<String, Object> _libraryId_QueryDerivedReferrer_CollectionListParameterMap;
        public Map<String, Object> LibraryId_QueryDerivedReferrer_CollectionListParameter { get { return _libraryId_QueryDerivedReferrer_CollectionListParameterMap; } }
        public override String keepLibraryId_QueryDerivedReferrer_CollectionListParameter(Object parameterValue) {
            if (_libraryId_QueryDerivedReferrer_CollectionListParameterMap == null) { _libraryId_QueryDerivedReferrer_CollectionListParameterMap = new LinkedHashMap<String, Object>(); }
            String key = "subQueryParameterKey" + (_libraryId_QueryDerivedReferrer_CollectionListParameterMap.size() + 1);
            _libraryId_QueryDerivedReferrer_CollectionListParameterMap.put(key, parameterValue); return "LibraryId_QueryDerivedReferrer_CollectionListParameter." + key;
        }

        protected Map<String, LdLibraryUserCQ> _libraryId_QueryDerivedReferrer_LibraryUserListMap;
        public Map<String, LdLibraryUserCQ> LibraryId_QueryDerivedReferrer_LibraryUserList { get { return _libraryId_QueryDerivedReferrer_LibraryUserListMap; } }
        public override String keepLibraryId_QueryDerivedReferrer_LibraryUserList(LdLibraryUserCQ subQuery) {
            if (_libraryId_QueryDerivedReferrer_LibraryUserListMap == null) { _libraryId_QueryDerivedReferrer_LibraryUserListMap = new LinkedHashMap<String, LdLibraryUserCQ>(); }
            String key = "subQueryMapKey" + (_libraryId_QueryDerivedReferrer_LibraryUserListMap.size() + 1);
            _libraryId_QueryDerivedReferrer_LibraryUserListMap.put(key, subQuery); return "LibraryId_QueryDerivedReferrer_LibraryUserList." + key;
        }
        protected Map<String, Object> _libraryId_QueryDerivedReferrer_LibraryUserListParameterMap;
        public Map<String, Object> LibraryId_QueryDerivedReferrer_LibraryUserListParameter { get { return _libraryId_QueryDerivedReferrer_LibraryUserListParameterMap; } }
        public override String keepLibraryId_QueryDerivedReferrer_LibraryUserListParameter(Object parameterValue) {
            if (_libraryId_QueryDerivedReferrer_LibraryUserListParameterMap == null) { _libraryId_QueryDerivedReferrer_LibraryUserListParameterMap = new LinkedHashMap<String, Object>(); }
            String key = "subQueryParameterKey" + (_libraryId_QueryDerivedReferrer_LibraryUserListParameterMap.size() + 1);
            _libraryId_QueryDerivedReferrer_LibraryUserListParameterMap.put(key, parameterValue); return "LibraryId_QueryDerivedReferrer_LibraryUserListParameter." + key;
        }

        protected Map<String, LdNextLibraryCQ> _libraryId_QueryDerivedReferrer_NextLibraryByLibraryIdListMap;
        public Map<String, LdNextLibraryCQ> LibraryId_QueryDerivedReferrer_NextLibraryByLibraryIdList { get { return _libraryId_QueryDerivedReferrer_NextLibraryByLibraryIdListMap; } }
        public override String keepLibraryId_QueryDerivedReferrer_NextLibraryByLibraryIdList(LdNextLibraryCQ subQuery) {
            if (_libraryId_QueryDerivedReferrer_NextLibraryByLibraryIdListMap == null) { _libraryId_QueryDerivedReferrer_NextLibraryByLibraryIdListMap = new LinkedHashMap<String, LdNextLibraryCQ>(); }
            String key = "subQueryMapKey" + (_libraryId_QueryDerivedReferrer_NextLibraryByLibraryIdListMap.size() + 1);
            _libraryId_QueryDerivedReferrer_NextLibraryByLibraryIdListMap.put(key, subQuery); return "LibraryId_QueryDerivedReferrer_NextLibraryByLibraryIdList." + key;
        }
        protected Map<String, Object> _libraryId_QueryDerivedReferrer_NextLibraryByLibraryIdListParameterMap;
        public Map<String, Object> LibraryId_QueryDerivedReferrer_NextLibraryByLibraryIdListParameter { get { return _libraryId_QueryDerivedReferrer_NextLibraryByLibraryIdListParameterMap; } }
        public override String keepLibraryId_QueryDerivedReferrer_NextLibraryByLibraryIdListParameter(Object parameterValue) {
            if (_libraryId_QueryDerivedReferrer_NextLibraryByLibraryIdListParameterMap == null) { _libraryId_QueryDerivedReferrer_NextLibraryByLibraryIdListParameterMap = new LinkedHashMap<String, Object>(); }
            String key = "subQueryParameterKey" + (_libraryId_QueryDerivedReferrer_NextLibraryByLibraryIdListParameterMap.size() + 1);
            _libraryId_QueryDerivedReferrer_NextLibraryByLibraryIdListParameterMap.put(key, parameterValue); return "LibraryId_QueryDerivedReferrer_NextLibraryByLibraryIdListParameter." + key;
        }

        protected Map<String, LdNextLibraryCQ> _libraryId_QueryDerivedReferrer_NextLibraryByNextLibraryIdListMap;
        public Map<String, LdNextLibraryCQ> LibraryId_QueryDerivedReferrer_NextLibraryByNextLibraryIdList { get { return _libraryId_QueryDerivedReferrer_NextLibraryByNextLibraryIdListMap; } }
        public override String keepLibraryId_QueryDerivedReferrer_NextLibraryByNextLibraryIdList(LdNextLibraryCQ subQuery) {
            if (_libraryId_QueryDerivedReferrer_NextLibraryByNextLibraryIdListMap == null) { _libraryId_QueryDerivedReferrer_NextLibraryByNextLibraryIdListMap = new LinkedHashMap<String, LdNextLibraryCQ>(); }
            String key = "subQueryMapKey" + (_libraryId_QueryDerivedReferrer_NextLibraryByNextLibraryIdListMap.size() + 1);
            _libraryId_QueryDerivedReferrer_NextLibraryByNextLibraryIdListMap.put(key, subQuery); return "LibraryId_QueryDerivedReferrer_NextLibraryByNextLibraryIdList." + key;
        }
        protected Map<String, Object> _libraryId_QueryDerivedReferrer_NextLibraryByNextLibraryIdListParameterMap;
        public Map<String, Object> LibraryId_QueryDerivedReferrer_NextLibraryByNextLibraryIdListParameter { get { return _libraryId_QueryDerivedReferrer_NextLibraryByNextLibraryIdListParameterMap; } }
        public override String keepLibraryId_QueryDerivedReferrer_NextLibraryByNextLibraryIdListParameter(Object parameterValue) {
            if (_libraryId_QueryDerivedReferrer_NextLibraryByNextLibraryIdListParameterMap == null) { _libraryId_QueryDerivedReferrer_NextLibraryByNextLibraryIdListParameterMap = new LinkedHashMap<String, Object>(); }
            String key = "subQueryParameterKey" + (_libraryId_QueryDerivedReferrer_NextLibraryByNextLibraryIdListParameterMap.size() + 1);
            _libraryId_QueryDerivedReferrer_NextLibraryByNextLibraryIdListParameterMap.put(key, parameterValue); return "LibraryId_QueryDerivedReferrer_NextLibraryByNextLibraryIdListParameter." + key;
        }

        public LdBsLibraryCQ AddOrderBy_LibraryId_Asc() { regOBA("LIBRARY_ID");return this; }
        public LdBsLibraryCQ AddOrderBy_LibraryId_Desc() { regOBD("LIBRARY_ID");return this; }

        protected LdConditionValue _libraryName;
        public LdConditionValue LibraryName {
            get { if (_libraryName == null) { _libraryName = new LdConditionValue(); } return _libraryName; }
        }
        protected override LdConditionValue getCValueLibraryName() { return this.LibraryName; }


        public LdBsLibraryCQ AddOrderBy_LibraryName_Asc() { regOBA("LIBRARY_NAME");return this; }
        public LdBsLibraryCQ AddOrderBy_LibraryName_Desc() { regOBD("LIBRARY_NAME");return this; }

        protected LdConditionValue _libraryTypeCode;
        public LdConditionValue LibraryTypeCode {
            get { if (_libraryTypeCode == null) { _libraryTypeCode = new LdConditionValue(); } return _libraryTypeCode; }
        }
        protected override LdConditionValue getCValueLibraryTypeCode() { return this.LibraryTypeCode; }


        protected Map<String, LdLibraryTypeLookupCQ> _libraryTypeCode_InScopeSubQuery_LibraryTypeLookupMap;
        public Map<String, LdLibraryTypeLookupCQ> LibraryTypeCode_InScopeSubQuery_LibraryTypeLookup { get { return _libraryTypeCode_InScopeSubQuery_LibraryTypeLookupMap; }}
        public override String keepLibraryTypeCode_InScopeSubQuery_LibraryTypeLookup(LdLibraryTypeLookupCQ subQuery) {
            if (_libraryTypeCode_InScopeSubQuery_LibraryTypeLookupMap == null) { _libraryTypeCode_InScopeSubQuery_LibraryTypeLookupMap = new LinkedHashMap<String, LdLibraryTypeLookupCQ>(); }
            String key = "subQueryMapKey" + (_libraryTypeCode_InScopeSubQuery_LibraryTypeLookupMap.size() + 1);
            _libraryTypeCode_InScopeSubQuery_LibraryTypeLookupMap.put(key, subQuery); return "LibraryTypeCode_InScopeSubQuery_LibraryTypeLookup." + key;
        }

        protected Map<String, LdLibraryTypeLookupCQ> _libraryTypeCode_NotInScopeSubQuery_LibraryTypeLookupMap;
        public Map<String, LdLibraryTypeLookupCQ> LibraryTypeCode_NotInScopeSubQuery_LibraryTypeLookup { get { return _libraryTypeCode_NotInScopeSubQuery_LibraryTypeLookupMap; }}
        public override String keepLibraryTypeCode_NotInScopeSubQuery_LibraryTypeLookup(LdLibraryTypeLookupCQ subQuery) {
            if (_libraryTypeCode_NotInScopeSubQuery_LibraryTypeLookupMap == null) { _libraryTypeCode_NotInScopeSubQuery_LibraryTypeLookupMap = new LinkedHashMap<String, LdLibraryTypeLookupCQ>(); }
            String key = "subQueryMapKey" + (_libraryTypeCode_NotInScopeSubQuery_LibraryTypeLookupMap.size() + 1);
            _libraryTypeCode_NotInScopeSubQuery_LibraryTypeLookupMap.put(key, subQuery); return "LibraryTypeCode_NotInScopeSubQuery_LibraryTypeLookup." + key;
        }

        public LdBsLibraryCQ AddOrderBy_LibraryTypeCode_Asc() { regOBA("LIBRARY_TYPE_CODE");return this; }
        public LdBsLibraryCQ AddOrderBy_LibraryTypeCode_Desc() { regOBD("LIBRARY_TYPE_CODE");return this; }

        protected LdConditionValue _rUser;
        public LdConditionValue RUser {
            get { if (_rUser == null) { _rUser = new LdConditionValue(); } return _rUser; }
        }
        protected override LdConditionValue getCValueRUser() { return this.RUser; }


        public LdBsLibraryCQ AddOrderBy_RUser_Asc() { regOBA("R_USER");return this; }
        public LdBsLibraryCQ AddOrderBy_RUser_Desc() { regOBD("R_USER");return this; }

        protected LdConditionValue _rModule;
        public LdConditionValue RModule {
            get { if (_rModule == null) { _rModule = new LdConditionValue(); } return _rModule; }
        }
        protected override LdConditionValue getCValueRModule() { return this.RModule; }


        public LdBsLibraryCQ AddOrderBy_RModule_Asc() { regOBA("R_MODULE");return this; }
        public LdBsLibraryCQ AddOrderBy_RModule_Desc() { regOBD("R_MODULE");return this; }

        protected LdConditionValue _rTimestamp;
        public LdConditionValue RTimestamp {
            get { if (_rTimestamp == null) { _rTimestamp = new LdConditionValue(); } return _rTimestamp; }
        }
        protected override LdConditionValue getCValueRTimestamp() { return this.RTimestamp; }


        public LdBsLibraryCQ AddOrderBy_RTimestamp_Asc() { regOBA("R_TIMESTAMP");return this; }
        public LdBsLibraryCQ AddOrderBy_RTimestamp_Desc() { regOBD("R_TIMESTAMP");return this; }

        protected LdConditionValue _uUser;
        public LdConditionValue UUser {
            get { if (_uUser == null) { _uUser = new LdConditionValue(); } return _uUser; }
        }
        protected override LdConditionValue getCValueUUser() { return this.UUser; }


        public LdBsLibraryCQ AddOrderBy_UUser_Asc() { regOBA("U_USER");return this; }
        public LdBsLibraryCQ AddOrderBy_UUser_Desc() { regOBD("U_USER");return this; }

        protected LdConditionValue _uModule;
        public LdConditionValue UModule {
            get { if (_uModule == null) { _uModule = new LdConditionValue(); } return _uModule; }
        }
        protected override LdConditionValue getCValueUModule() { return this.UModule; }


        public LdBsLibraryCQ AddOrderBy_UModule_Asc() { regOBA("U_MODULE");return this; }
        public LdBsLibraryCQ AddOrderBy_UModule_Desc() { regOBD("U_MODULE");return this; }

        protected LdConditionValue _uTimestamp;
        public LdConditionValue UTimestamp {
            get { if (_uTimestamp == null) { _uTimestamp = new LdConditionValue(); } return _uTimestamp; }
        }
        protected override LdConditionValue getCValueUTimestamp() { return this.UTimestamp; }


        public LdBsLibraryCQ AddOrderBy_UTimestamp_Asc() { regOBA("U_TIMESTAMP");return this; }
        public LdBsLibraryCQ AddOrderBy_UTimestamp_Desc() { regOBD("U_TIMESTAMP");return this; }

        public LdBsLibraryCQ AddSpecifiedDerivedOrderBy_Asc(String aliasName) { registerSpecifiedDerivedOrderBy_Asc(aliasName); return this; }
        public LdBsLibraryCQ AddSpecifiedDerivedOrderBy_Desc(String aliasName) { registerSpecifiedDerivedOrderBy_Desc(aliasName); return this; }

        public override void reflectRelationOnUnionQuery(LdConditionQuery baseQueryAsSuper, LdConditionQuery unionQueryAsSuper) {
            LdLibraryCQ baseQuery = (LdLibraryCQ)baseQueryAsSuper;
            LdLibraryCQ unionQuery = (LdLibraryCQ)unionQueryAsSuper;
            if (baseQuery.hasConditionQueryLibraryTypeLookup()) {
                unionQuery.QueryLibraryTypeLookup().reflectRelationOnUnionQuery(baseQuery.QueryLibraryTypeLookup(), unionQuery.QueryLibraryTypeLookup());
            }

        }
    
        protected LdLibraryTypeLookupCQ _conditionQueryLibraryTypeLookup;
        public LdLibraryTypeLookupCQ QueryLibraryTypeLookup() {
            return this.ConditionQueryLibraryTypeLookup;
        }
        public LdLibraryTypeLookupCQ ConditionQueryLibraryTypeLookup {
            get {
                if (_conditionQueryLibraryTypeLookup == null) {
                    _conditionQueryLibraryTypeLookup = xcreateQueryLibraryTypeLookup();
                    xsetupOuterJoin_LibraryTypeLookup();
                }
                return _conditionQueryLibraryTypeLookup;
            }
        }
        protected LdLibraryTypeLookupCQ xcreateQueryLibraryTypeLookup() {
            String nrp = resolveNextRelationPathLibraryTypeLookup();
            String jan = resolveJoinAliasName(nrp, xgetNextNestLevel());
            LdLibraryTypeLookupCQ cq = new LdLibraryTypeLookupCQ(this, xgetSqlClause(), jan, xgetNextNestLevel());
            cq.xsetForeignPropertyName("libraryTypeLookup"); cq.xsetRelationPath(nrp); return cq;
        }
        public void xsetupOuterJoin_LibraryTypeLookup() {
            LdLibraryTypeLookupCQ cq = ConditionQueryLibraryTypeLookup;
            Map<String, String> joinOnMap = new LinkedHashMap<String, String>();
            joinOnMap.put("LIBRARY_TYPE_CODE", "LIBRARY_TYPE_CODE");
            registerOuterJoin(cq, joinOnMap);
        }
        protected String resolveNextRelationPathLibraryTypeLookup() {
            return resolveNextRelationPath("library", "libraryTypeLookup");
        }
        public bool hasConditionQueryLibraryTypeLookup() {
            return _conditionQueryLibraryTypeLookup != null;
        }


	    // ===============================================================================
	    //                                                                 Scalar SubQuery
	    //                                                                 ===============
	    protected Map<String, LdLibraryCQ> _scalarSubQueryMap;
	    public Map<String, LdLibraryCQ> ScalarSubQuery { get { return _scalarSubQueryMap; } }
	    public override String keepScalarSubQuery(LdLibraryCQ subQuery) {
	        if (_scalarSubQueryMap == null) { _scalarSubQueryMap = new LinkedHashMap<String, LdLibraryCQ>(); }
	        String key = "subQueryMapKey" + (_scalarSubQueryMap.size() + 1);
	        _scalarSubQueryMap.put(key, subQuery); return "ScalarSubQuery." + key;
	    }

        // ===============================================================================
        //                                                         Myself InScope SubQuery
        //                                                         =======================
        protected Map<String, LdLibraryCQ> _myselfInScopeSubQueryMap;
        public Map<String, LdLibraryCQ> MyselfInScopeSubQuery { get { return _myselfInScopeSubQueryMap; } }
        public override String keepMyselfInScopeSubQuery(LdLibraryCQ subQuery) {
            if (_myselfInScopeSubQueryMap == null) { _myselfInScopeSubQueryMap = new LinkedHashMap<String, LdLibraryCQ>(); }
            String key = "subQueryMapKey" + (_myselfInScopeSubQueryMap.size() + 1);
            _myselfInScopeSubQueryMap.put(key, subQuery); return "MyselfInScopeSubQuery." + key;
        }
    }
}
