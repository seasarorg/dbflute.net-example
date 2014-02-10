
using System;

using DfExample.DBFlute.AllCommon.CBean;
using DfExample.DBFlute.AllCommon.CBean.CValue;
using DfExample.DBFlute.AllCommon.CBean.SClause;
using DfExample.DBFlute.AllCommon.JavaLike;
using DfExample.DBFlute.CBean.CQ;
using DfExample.DBFlute.CBean.CQ.Ciq;

namespace DfExample.DBFlute.CBean.CQ.BS {

    [System.Serializable]
    public class BsWhitePgReservRefCQ : AbstractBsWhitePgReservRefCQ {

        protected WhitePgReservRefCIQ _inlineQuery;

        public BsWhitePgReservRefCQ(ConditionQuery childQuery, SqlClause sqlClause, String aliasName, int nestLevel)
            : base(childQuery, sqlClause, aliasName, nestLevel) {}

        public WhitePgReservRefCIQ Inline() {
            if (_inlineQuery == null) {
                _inlineQuery = new WhitePgReservRefCIQ(xgetReferrerQuery(), xgetSqlClause(), xgetAliasName(), xgetNestLevel(), this);
            }
            _inlineQuery.xsetOnClause(false);
            return _inlineQuery;
        }
        
        public WhitePgReservRefCIQ On() {
            if (isBaseQuery()) { throw new UnsupportedOperationException("Unsupported onClause of Base Table!"); }
            WhitePgReservRefCIQ inlineQuery = Inline();
            inlineQuery.xsetOnClause(true);
            return inlineQuery;
        }


        protected ConditionValue _refId;
        public ConditionValue RefId {
            get { if (_refId == null) { _refId = new ConditionValue(); } return _refId; }
        }
        protected override ConditionValue getCValueRefId() { return this.RefId; }


        public BsWhitePgReservRefCQ AddOrderBy_RefId_Asc() { regOBA("REF_ID");return this; }
        public BsWhitePgReservRefCQ AddOrderBy_RefId_Desc() { regOBD("REF_ID");return this; }

        protected ConditionValue _classSynonym;
        public ConditionValue ClassSynonym {
            get { if (_classSynonym == null) { _classSynonym = new ConditionValue(); } return _classSynonym; }
        }
        protected override ConditionValue getCValueClassSynonym() { return this.ClassSynonym; }


        protected Map<String, WhitePgReservCQ> _classSynonym_InScopeSubQuery_WhitePgReservMap;
        public Map<String, WhitePgReservCQ> ClassSynonym_InScopeSubQuery_WhitePgReserv { get { return _classSynonym_InScopeSubQuery_WhitePgReservMap; }}
        public override String keepClassSynonym_InScopeSubQuery_WhitePgReserv(WhitePgReservCQ subQuery) {
            if (_classSynonym_InScopeSubQuery_WhitePgReservMap == null) { _classSynonym_InScopeSubQuery_WhitePgReservMap = new LinkedHashMap<String, WhitePgReservCQ>(); }
            String key = "subQueryMapKey" + (_classSynonym_InScopeSubQuery_WhitePgReservMap.size() + 1);
            _classSynonym_InScopeSubQuery_WhitePgReservMap.put(key, subQuery); return "ClassSynonym_InScopeSubQuery_WhitePgReserv." + key;
        }

        protected Map<String, WhitePgReservCQ> _classSynonym_NotInScopeSubQuery_WhitePgReservMap;
        public Map<String, WhitePgReservCQ> ClassSynonym_NotInScopeSubQuery_WhitePgReserv { get { return _classSynonym_NotInScopeSubQuery_WhitePgReservMap; }}
        public override String keepClassSynonym_NotInScopeSubQuery_WhitePgReserv(WhitePgReservCQ subQuery) {
            if (_classSynonym_NotInScopeSubQuery_WhitePgReservMap == null) { _classSynonym_NotInScopeSubQuery_WhitePgReservMap = new LinkedHashMap<String, WhitePgReservCQ>(); }
            String key = "subQueryMapKey" + (_classSynonym_NotInScopeSubQuery_WhitePgReservMap.size() + 1);
            _classSynonym_NotInScopeSubQuery_WhitePgReservMap.put(key, subQuery); return "ClassSynonym_NotInScopeSubQuery_WhitePgReserv." + key;
        }

        public BsWhitePgReservRefCQ AddOrderBy_ClassSynonym_Asc() { regOBA("CLASS");return this; }
        public BsWhitePgReservRefCQ AddOrderBy_ClassSynonym_Desc() { regOBD("CLASS");return this; }

        public BsWhitePgReservRefCQ AddSpecifiedDerivedOrderBy_Asc(String aliasName) { registerSpecifiedDerivedOrderBy_Asc(aliasName); return this; }
        public BsWhitePgReservRefCQ AddSpecifiedDerivedOrderBy_Desc(String aliasName) { registerSpecifiedDerivedOrderBy_Desc(aliasName); return this; }

        public override void reflectRelationOnUnionQuery(ConditionQuery baseQueryAsSuper, ConditionQuery unionQueryAsSuper) {
            WhitePgReservRefCQ baseQuery = (WhitePgReservRefCQ)baseQueryAsSuper;
            WhitePgReservRefCQ unionQuery = (WhitePgReservRefCQ)unionQueryAsSuper;
            if (baseQuery.hasConditionQueryWhitePgReserv()) {
                unionQuery.QueryWhitePgReserv().reflectRelationOnUnionQuery(baseQuery.QueryWhitePgReserv(), unionQuery.QueryWhitePgReserv());
            }

        }
    
        protected WhitePgReservCQ _conditionQueryWhitePgReserv;
        public WhitePgReservCQ QueryWhitePgReserv() {
            return this.ConditionQueryWhitePgReserv;
        }
        public WhitePgReservCQ ConditionQueryWhitePgReserv {
            get {
                if (_conditionQueryWhitePgReserv == null) {
                    _conditionQueryWhitePgReserv = xcreateQueryWhitePgReserv();
                    xsetupOuterJoin_WhitePgReserv();
                }
                return _conditionQueryWhitePgReserv;
            }
        }
        protected WhitePgReservCQ xcreateQueryWhitePgReserv() {
            String nrp = resolveNextRelationPathWhitePgReserv();
            String jan = resolveJoinAliasName(nrp, xgetNextNestLevel());
            WhitePgReservCQ cq = new WhitePgReservCQ(this, xgetSqlClause(), jan, xgetNextNestLevel());
            cq.xsetForeignPropertyName("whitePgReserv"); cq.xsetRelationPath(nrp); return cq;
        }
        public void xsetupOuterJoin_WhitePgReserv() {
            WhitePgReservCQ cq = ConditionQueryWhitePgReserv;
            Map<String, String> joinOnMap = new LinkedHashMap<String, String>();
            joinOnMap.put("CLASS", "CLASS");
            registerOuterJoin(cq, joinOnMap);
        }
        protected String resolveNextRelationPathWhitePgReserv() {
            return resolveNextRelationPath("white_pg_reserv_ref", "whitePgReserv");
        }
        public bool hasConditionQueryWhitePgReserv() {
            return _conditionQueryWhitePgReserv != null;
        }


	    // ===============================================================================
	    //                                                                 Scalar SubQuery
	    //                                                                 ===============
	    protected Map<String, WhitePgReservRefCQ> _scalarSubQueryMap;
	    public Map<String, WhitePgReservRefCQ> ScalarSubQuery { get { return _scalarSubQueryMap; } }
	    public override String keepScalarSubQuery(WhitePgReservRefCQ subQuery) {
	        if (_scalarSubQueryMap == null) { _scalarSubQueryMap = new LinkedHashMap<String, WhitePgReservRefCQ>(); }
	        String key = "subQueryMapKey" + (_scalarSubQueryMap.size() + 1);
	        _scalarSubQueryMap.put(key, subQuery); return "ScalarSubQuery." + key;
	    }

        // ===============================================================================
        //                                                         Myself InScope SubQuery
        //                                                         =======================
        protected Map<String, WhitePgReservRefCQ> _myselfInScopeSubQueryMap;
        public Map<String, WhitePgReservRefCQ> MyselfInScopeSubQuery { get { return _myselfInScopeSubQueryMap; } }
        public override String keepMyselfInScopeSubQuery(WhitePgReservRefCQ subQuery) {
            if (_myselfInScopeSubQueryMap == null) { _myselfInScopeSubQueryMap = new LinkedHashMap<String, WhitePgReservRefCQ>(); }
            String key = "subQueryMapKey" + (_myselfInScopeSubQueryMap.size() + 1);
            _myselfInScopeSubQueryMap.put(key, subQuery); return "MyselfInScopeSubQuery." + key;
        }
    }
}
