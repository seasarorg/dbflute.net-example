
using System;

using DfExample.DBFlute.AllCommon.CBean;
using DfExample.DBFlute.AllCommon.CBean.CValue;
using DfExample.DBFlute.AllCommon.CBean.SClause;
using DfExample.DBFlute.AllCommon.JavaLike;
using DfExample.DBFlute.CBean.CQ;
using DfExample.DBFlute.CBean.CQ.Ciq;

namespace DfExample.DBFlute.CBean.CQ.BS {

    [System.Serializable]
    public class BsWhiteDelimiterCQ : AbstractBsWhiteDelimiterCQ {

        protected WhiteDelimiterCIQ _inlineQuery;

        public BsWhiteDelimiterCQ(ConditionQuery childQuery, SqlClause sqlClause, String aliasName, int nestLevel)
            : base(childQuery, sqlClause, aliasName, nestLevel) {}

        public WhiteDelimiterCIQ Inline() {
            if (_inlineQuery == null) {
                _inlineQuery = new WhiteDelimiterCIQ(xgetReferrerQuery(), xgetSqlClause(), xgetAliasName(), xgetNestLevel(), this);
            }
            _inlineQuery.xsetOnClause(false);
            return _inlineQuery;
        }
        
        public WhiteDelimiterCIQ On() {
            if (isBaseQuery()) { throw new UnsupportedOperationException("Unsupported onClause of Base Table!"); }
            WhiteDelimiterCIQ inlineQuery = Inline();
            inlineQuery.xsetOnClause(true);
            return inlineQuery;
        }


        protected ConditionValue _delimiterId;
        public ConditionValue DelimiterId {
            get { if (_delimiterId == null) { _delimiterId = new ConditionValue(); } return _delimiterId; }
        }
        protected override ConditionValue getCValueDelimiterId() { return this.DelimiterId; }


        public BsWhiteDelimiterCQ AddOrderBy_DelimiterId_Asc() { regOBA("DELIMITER_ID");return this; }
        public BsWhiteDelimiterCQ AddOrderBy_DelimiterId_Desc() { regOBD("DELIMITER_ID");return this; }

        protected ConditionValue _numberNullable;
        public ConditionValue NumberNullable {
            get { if (_numberNullable == null) { _numberNullable = new ConditionValue(); } return _numberNullable; }
        }
        protected override ConditionValue getCValueNumberNullable() { return this.NumberNullable; }


        public BsWhiteDelimiterCQ AddOrderBy_NumberNullable_Asc() { regOBA("NUMBER_NULLABLE");return this; }
        public BsWhiteDelimiterCQ AddOrderBy_NumberNullable_Desc() { regOBD("NUMBER_NULLABLE");return this; }

        protected ConditionValue _stringConverted;
        public ConditionValue StringConverted {
            get { if (_stringConverted == null) { _stringConverted = new ConditionValue(); } return _stringConverted; }
        }
        protected override ConditionValue getCValueStringConverted() { return this.StringConverted; }


        public BsWhiteDelimiterCQ AddOrderBy_StringConverted_Asc() { regOBA("STRING_CONVERTED");return this; }
        public BsWhiteDelimiterCQ AddOrderBy_StringConverted_Desc() { regOBD("STRING_CONVERTED");return this; }

        protected ConditionValue _stringNonConverted;
        public ConditionValue StringNonConverted {
            get { if (_stringNonConverted == null) { _stringNonConverted = new ConditionValue(); } return _stringNonConverted; }
        }
        protected override ConditionValue getCValueStringNonConverted() { return this.StringNonConverted; }


        public BsWhiteDelimiterCQ AddOrderBy_StringNonConverted_Asc() { regOBA("STRING_NON_CONVERTED");return this; }
        public BsWhiteDelimiterCQ AddOrderBy_StringNonConverted_Desc() { regOBD("STRING_NON_CONVERTED");return this; }

        protected ConditionValue _dateDefault;
        public ConditionValue DateDefault {
            get { if (_dateDefault == null) { _dateDefault = new ConditionValue(); } return _dateDefault; }
        }
        protected override ConditionValue getCValueDateDefault() { return this.DateDefault; }


        public BsWhiteDelimiterCQ AddOrderBy_DateDefault_Asc() { regOBA("DATE_DEFAULT");return this; }
        public BsWhiteDelimiterCQ AddOrderBy_DateDefault_Desc() { regOBD("DATE_DEFAULT");return this; }

        public BsWhiteDelimiterCQ AddSpecifiedDerivedOrderBy_Asc(String aliasName) { registerSpecifiedDerivedOrderBy_Asc(aliasName); return this; }
        public BsWhiteDelimiterCQ AddSpecifiedDerivedOrderBy_Desc(String aliasName) { registerSpecifiedDerivedOrderBy_Desc(aliasName); return this; }

        public override void reflectRelationOnUnionQuery(ConditionQuery baseQueryAsSuper, ConditionQuery unionQueryAsSuper) {

        }
    


	    // ===============================================================================
	    //                                                                 Scalar SubQuery
	    //                                                                 ===============
	    protected Map<String, WhiteDelimiterCQ> _scalarSubQueryMap;
	    public Map<String, WhiteDelimiterCQ> ScalarSubQuery { get { return _scalarSubQueryMap; } }
	    public override String keepScalarSubQuery(WhiteDelimiterCQ subQuery) {
	        if (_scalarSubQueryMap == null) { _scalarSubQueryMap = new LinkedHashMap<String, WhiteDelimiterCQ>(); }
	        String key = "subQueryMapKey" + (_scalarSubQueryMap.size() + 1);
	        _scalarSubQueryMap.put(key, subQuery); return "ScalarSubQuery." + key;
	    }

        // ===============================================================================
        //                                                         Myself InScope SubQuery
        //                                                         =======================
        protected Map<String, WhiteDelimiterCQ> _myselfInScopeSubQueryMap;
        public Map<String, WhiteDelimiterCQ> MyselfInScopeSubQuery { get { return _myselfInScopeSubQueryMap; } }
        public override String keepMyselfInScopeSubQuery(WhiteDelimiterCQ subQuery) {
            if (_myselfInScopeSubQueryMap == null) { _myselfInScopeSubQueryMap = new LinkedHashMap<String, WhiteDelimiterCQ>(); }
            String key = "subQueryMapKey" + (_myselfInScopeSubQueryMap.size() + 1);
            _myselfInScopeSubQueryMap.put(key, subQuery); return "MyselfInScopeSubQuery." + key;
        }
    }
}
