
using System;

using DfExample.DBFlute.AllCommon.CBean;
using DfExample.DBFlute.AllCommon.CBean.CValue;
using DfExample.DBFlute.AllCommon.CBean.SClause;
using DfExample.DBFlute.AllCommon.JavaLike;
using DfExample.DBFlute.CBean.CQ;
using DfExample.DBFlute.CBean.CQ.Ciq;

namespace DfExample.DBFlute.CBean.CQ.BS {

    [System.Serializable]
    public class BsWhiteColumnExceptCQ : AbstractBsWhiteColumnExceptCQ {

        protected WhiteColumnExceptCIQ _inlineQuery;

        public BsWhiteColumnExceptCQ(ConditionQuery childQuery, SqlClause sqlClause, String aliasName, int nestLevel)
            : base(childQuery, sqlClause, aliasName, nestLevel) {}

        public WhiteColumnExceptCIQ Inline() {
            if (_inlineQuery == null) {
                _inlineQuery = new WhiteColumnExceptCIQ(xgetReferrerQuery(), xgetSqlClause(), xgetAliasName(), xgetNestLevel(), this);
            }
            _inlineQuery.xsetOnClause(false);
            return _inlineQuery;
        }
        
        public WhiteColumnExceptCIQ On() {
            if (isBaseQuery()) { throw new UnsupportedOperationException("Unsupported onClause of Base Table!"); }
            WhiteColumnExceptCIQ inlineQuery = Inline();
            inlineQuery.xsetOnClause(true);
            return inlineQuery;
        }


        protected ConditionValue _exceptColumnId;
        public ConditionValue ExceptColumnId {
            get { if (_exceptColumnId == null) { _exceptColumnId = new ConditionValue(); } return _exceptColumnId; }
        }
        protected override ConditionValue getCValueExceptColumnId() { return this.ExceptColumnId; }


        public BsWhiteColumnExceptCQ AddOrderBy_ExceptColumnId_Asc() { regOBA("EXCEPT_COLUMN_ID");return this; }
        public BsWhiteColumnExceptCQ AddOrderBy_ExceptColumnId_Desc() { regOBD("EXCEPT_COLUMN_ID");return this; }

        protected ConditionValue _columnExceptTest;
        public ConditionValue ColumnExceptTest {
            get { if (_columnExceptTest == null) { _columnExceptTest = new ConditionValue(); } return _columnExceptTest; }
        }
        protected override ConditionValue getCValueColumnExceptTest() { return this.ColumnExceptTest; }


        public BsWhiteColumnExceptCQ AddOrderBy_ColumnExceptTest_Asc() { regOBA("COLUMN_EXCEPT_TEST");return this; }
        public BsWhiteColumnExceptCQ AddOrderBy_ColumnExceptTest_Desc() { regOBD("COLUMN_EXCEPT_TEST");return this; }

        public BsWhiteColumnExceptCQ AddSpecifiedDerivedOrderBy_Asc(String aliasName) { registerSpecifiedDerivedOrderBy_Asc(aliasName); return this; }
        public BsWhiteColumnExceptCQ AddSpecifiedDerivedOrderBy_Desc(String aliasName) { registerSpecifiedDerivedOrderBy_Desc(aliasName); return this; }

        public override void reflectRelationOnUnionQuery(ConditionQuery baseQueryAsSuper, ConditionQuery unionQueryAsSuper) {

        }
    


	    // ===============================================================================
	    //                                                                 Scalar SubQuery
	    //                                                                 ===============
	    protected Map<String, WhiteColumnExceptCQ> _scalarSubQueryMap;
	    public Map<String, WhiteColumnExceptCQ> ScalarSubQuery { get { return _scalarSubQueryMap; } }
	    public override String keepScalarSubQuery(WhiteColumnExceptCQ subQuery) {
	        if (_scalarSubQueryMap == null) { _scalarSubQueryMap = new LinkedHashMap<String, WhiteColumnExceptCQ>(); }
	        String key = "subQueryMapKey" + (_scalarSubQueryMap.size() + 1);
	        _scalarSubQueryMap.put(key, subQuery); return "ScalarSubQuery." + key;
	    }

        // ===============================================================================
        //                                                         Myself InScope SubQuery
        //                                                         =======================
        protected Map<String, WhiteColumnExceptCQ> _myselfInScopeSubQueryMap;
        public Map<String, WhiteColumnExceptCQ> MyselfInScopeSubQuery { get { return _myselfInScopeSubQueryMap; } }
        public override String keepMyselfInScopeSubQuery(WhiteColumnExceptCQ subQuery) {
            if (_myselfInScopeSubQueryMap == null) { _myselfInScopeSubQueryMap = new LinkedHashMap<String, WhiteColumnExceptCQ>(); }
            String key = "subQueryMapKey" + (_myselfInScopeSubQueryMap.size() + 1);
            _myselfInScopeSubQueryMap.put(key, subQuery); return "MyselfInScopeSubQuery." + key;
        }
    }
}
