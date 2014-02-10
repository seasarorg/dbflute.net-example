
using System;

using DfExample.DBFlute.AllCommon.CBean;
using DfExample.DBFlute.AllCommon.CBean.CValue;
using DfExample.DBFlute.AllCommon.CBean.SClause;
using DfExample.DBFlute.AllCommon.JavaLike;
using DfExample.DBFlute.CBean.CQ;
using DfExample.DBFlute.CBean.CQ.Ciq;

namespace DfExample.DBFlute.CBean.CQ.BS {

    [System.Serializable]
    public class BsWhiteQuotedCQ : AbstractBsWhiteQuotedCQ {

        protected WhiteQuotedCIQ _inlineQuery;

        public BsWhiteQuotedCQ(ConditionQuery childQuery, SqlClause sqlClause, String aliasName, int nestLevel)
            : base(childQuery, sqlClause, aliasName, nestLevel) {}

        public WhiteQuotedCIQ Inline() {
            if (_inlineQuery == null) {
                _inlineQuery = new WhiteQuotedCIQ(xgetReferrerQuery(), xgetSqlClause(), xgetAliasName(), xgetNestLevel(), this);
            }
            _inlineQuery.xsetOnClause(false);
            return _inlineQuery;
        }
        
        public WhiteQuotedCIQ On() {
            if (isBaseQuery()) { throw new UnsupportedOperationException("Unsupported onClause of Base Table!"); }
            WhiteQuotedCIQ inlineQuery = Inline();
            inlineQuery.xsetOnClause(true);
            return inlineQuery;
        }


        protected ConditionValue _select;
        public ConditionValue Select {
            get { if (_select == null) { _select = new ConditionValue(); } return _select; }
        }
        protected override ConditionValue getCValueSelect() { return this.Select; }


        public BsWhiteQuotedCQ AddOrderBy_Select_Asc() { regOBA("SELECT");return this; }
        public BsWhiteQuotedCQ AddOrderBy_Select_Desc() { regOBD("SELECT");return this; }

        protected ConditionValue _from;
        public ConditionValue From {
            get { if (_from == null) { _from = new ConditionValue(); } return _from; }
        }
        protected override ConditionValue getCValueFrom() { return this.From; }


        public BsWhiteQuotedCQ AddOrderBy_From_Asc() { regOBA("FROM");return this; }
        public BsWhiteQuotedCQ AddOrderBy_From_Desc() { regOBD("FROM");return this; }

        public BsWhiteQuotedCQ AddSpecifiedDerivedOrderBy_Asc(String aliasName) { registerSpecifiedDerivedOrderBy_Asc(aliasName); return this; }
        public BsWhiteQuotedCQ AddSpecifiedDerivedOrderBy_Desc(String aliasName) { registerSpecifiedDerivedOrderBy_Desc(aliasName); return this; }

        public override void reflectRelationOnUnionQuery(ConditionQuery baseQueryAsSuper, ConditionQuery unionQueryAsSuper) {

        }
    


	    // ===============================================================================
	    //                                                                 Scalar SubQuery
	    //                                                                 ===============
	    protected Map<String, WhiteQuotedCQ> _scalarSubQueryMap;
	    public Map<String, WhiteQuotedCQ> ScalarSubQuery { get { return _scalarSubQueryMap; } }
	    public override String keepScalarSubQuery(WhiteQuotedCQ subQuery) {
	        if (_scalarSubQueryMap == null) { _scalarSubQueryMap = new LinkedHashMap<String, WhiteQuotedCQ>(); }
	        String key = "subQueryMapKey" + (_scalarSubQueryMap.size() + 1);
	        _scalarSubQueryMap.put(key, subQuery); return "ScalarSubQuery." + key;
	    }

        // ===============================================================================
        //                                                         Myself InScope SubQuery
        //                                                         =======================
        protected Map<String, WhiteQuotedCQ> _myselfInScopeSubQueryMap;
        public Map<String, WhiteQuotedCQ> MyselfInScopeSubQuery { get { return _myselfInScopeSubQueryMap; } }
        public override String keepMyselfInScopeSubQuery(WhiteQuotedCQ subQuery) {
            if (_myselfInScopeSubQueryMap == null) { _myselfInScopeSubQueryMap = new LinkedHashMap<String, WhiteQuotedCQ>(); }
            String key = "subQueryMapKey" + (_myselfInScopeSubQueryMap.size() + 1);
            _myselfInScopeSubQueryMap.put(key, subQuery); return "MyselfInScopeSubQuery." + key;
        }
    }
}
