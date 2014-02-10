
using System;

using DfExample.DBFlute.MemberDb.AllCommon.CBean;
using DfExample.DBFlute.MemberDb.AllCommon.CBean.CValue;
using DfExample.DBFlute.MemberDb.AllCommon.CBean.SClause;
using DfExample.DBFlute.MemberDb.AllCommon.JavaLike;
using DfExample.DBFlute.MemberDb.CBean.CQ;
using DfExample.DBFlute.MemberDb.CBean.CQ.Ciq;

namespace DfExample.DBFlute.MemberDb.CBean.CQ.BS {

    [System.Serializable]
    public class MbBsVendorCheckCQ : MbAbstractBsVendorCheckCQ {

        protected MbVendorCheckCIQ _inlineQuery;

        public MbBsVendorCheckCQ(MbConditionQuery childQuery, MbSqlClause sqlClause, String aliasName, int nestLevel)
            : base(childQuery, sqlClause, aliasName, nestLevel) {}

        public MbVendorCheckCIQ Inline() {
            if (_inlineQuery == null) {
                _inlineQuery = new MbVendorCheckCIQ(xgetReferrerQuery(), xgetSqlClause(), xgetAliasName(), xgetNestLevel(), this);
            }
            _inlineQuery.xsetOnClause(false);
            return _inlineQuery;
        }
        
        public MbVendorCheckCIQ On() {
            if (isBaseQuery()) { throw new UnsupportedOperationException("Unsupported onClause of Base Table!"); }
            MbVendorCheckCIQ inlineQuery = Inline();
            inlineQuery.xsetOnClause(true);
            return inlineQuery;
        }


        protected MbConditionValue _vendorCheckId;
        public MbConditionValue VendorCheckId {
            get { if (_vendorCheckId == null) { _vendorCheckId = new MbConditionValue(); } return _vendorCheckId; }
        }
        protected override MbConditionValue getCValueVendorCheckId() { return this.VendorCheckId; }


        public MbBsVendorCheckCQ AddOrderBy_VendorCheckId_Asc() { regOBA("VENDOR_CHECK_ID");return this; }
        public MbBsVendorCheckCQ AddOrderBy_VendorCheckId_Desc() { regOBD("VENDOR_CHECK_ID");return this; }

        protected MbConditionValue _decimalDigit;
        public MbConditionValue DecimalDigit {
            get { if (_decimalDigit == null) { _decimalDigit = new MbConditionValue(); } return _decimalDigit; }
        }
        protected override MbConditionValue getCValueDecimalDigit() { return this.DecimalDigit; }


        public MbBsVendorCheckCQ AddOrderBy_DecimalDigit_Asc() { regOBA("DECIMAL_DIGIT");return this; }
        public MbBsVendorCheckCQ AddOrderBy_DecimalDigit_Desc() { regOBD("DECIMAL_DIGIT");return this; }

        protected MbConditionValue _integerNonDigit;
        public MbConditionValue IntegerNonDigit {
            get { if (_integerNonDigit == null) { _integerNonDigit = new MbConditionValue(); } return _integerNonDigit; }
        }
        protected override MbConditionValue getCValueIntegerNonDigit() { return this.IntegerNonDigit; }


        public MbBsVendorCheckCQ AddOrderBy_IntegerNonDigit_Asc() { regOBA("INTEGER_NON_DIGIT");return this; }
        public MbBsVendorCheckCQ AddOrderBy_IntegerNonDigit_Desc() { regOBD("INTEGER_NON_DIGIT");return this; }

        protected MbConditionValue _typeOfBoolean;
        public MbConditionValue TypeOfBoolean {
            get { if (_typeOfBoolean == null) { _typeOfBoolean = new MbConditionValue(); } return _typeOfBoolean; }
        }
        protected override MbConditionValue getCValueTypeOfBoolean() { return this.TypeOfBoolean; }


        public MbBsVendorCheckCQ AddOrderBy_TypeOfBoolean_Asc() { regOBA("TYPE_OF_BOOLEAN");return this; }
        public MbBsVendorCheckCQ AddOrderBy_TypeOfBoolean_Desc() { regOBD("TYPE_OF_BOOLEAN");return this; }

        protected MbConditionValue _typeOfText;
        public MbConditionValue TypeOfText {
            get { if (_typeOfText == null) { _typeOfText = new MbConditionValue(); } return _typeOfText; }
        }
        protected override MbConditionValue getCValueTypeOfText() { return this.TypeOfText; }


        public MbBsVendorCheckCQ AddOrderBy_TypeOfText_Asc() { regOBA("TYPE_OF_TEXT");return this; }
        public MbBsVendorCheckCQ AddOrderBy_TypeOfText_Desc() { regOBD("TYPE_OF_TEXT");return this; }

        public MbBsVendorCheckCQ AddSpecifiedDerivedOrderBy_Asc(String aliasName) { registerSpecifiedDerivedOrderBy_Asc(aliasName); return this; }
        public MbBsVendorCheckCQ AddSpecifiedDerivedOrderBy_Desc(String aliasName) { registerSpecifiedDerivedOrderBy_Desc(aliasName); return this; }

        public override void reflectRelationOnUnionQuery(MbConditionQuery baseQueryAsSuper, MbConditionQuery unionQueryAsSuper) {

        }
    


	    // ===============================================================================
	    //                                                                 Scalar SubQuery
	    //                                                                 ===============
	    protected Map<String, MbVendorCheckCQ> _scalarSubQueryMap;
	    public Map<String, MbVendorCheckCQ> ScalarSubQuery { get { return _scalarSubQueryMap; } }
	    public override String keepScalarSubQuery(MbVendorCheckCQ subQuery) {
	        if (_scalarSubQueryMap == null) { _scalarSubQueryMap = new LinkedHashMap<String, MbVendorCheckCQ>(); }
	        String key = "subQueryMapKey" + (_scalarSubQueryMap.size() + 1);
	        _scalarSubQueryMap.put(key, subQuery); return "ScalarSubQuery." + key;
	    }

        // ===============================================================================
        //                                                         Myself InScope SubQuery
        //                                                         =======================
        protected Map<String, MbVendorCheckCQ> _myselfInScopeSubQueryMap;
        public Map<String, MbVendorCheckCQ> MyselfInScopeSubQuery { get { return _myselfInScopeSubQueryMap; } }
        public override String keepMyselfInScopeSubQuery(MbVendorCheckCQ subQuery) {
            if (_myselfInScopeSubQueryMap == null) { _myselfInScopeSubQueryMap = new LinkedHashMap<String, MbVendorCheckCQ>(); }
            String key = "subQueryMapKey" + (_myselfInScopeSubQueryMap.size() + 1);
            _myselfInScopeSubQueryMap.put(key, subQuery); return "MyselfInScopeSubQuery." + key;
        }
    }
}
