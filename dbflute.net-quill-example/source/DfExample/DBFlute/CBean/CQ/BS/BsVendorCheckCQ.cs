
using System;

using DfExample.DBFlute.AllCommon.CBean;
using DfExample.DBFlute.AllCommon.CBean.CValue;
using DfExample.DBFlute.AllCommon.CBean.SClause;
using DfExample.DBFlute.AllCommon.JavaLike;
using DfExample.DBFlute.CBean.CQ;
using DfExample.DBFlute.CBean.CQ.Ciq;

namespace DfExample.DBFlute.CBean.CQ.BS {

    [System.Serializable]
    public class BsVendorCheckCQ : AbstractBsVendorCheckCQ {

        protected VendorCheckCIQ _inlineQuery;

        public BsVendorCheckCQ(ConditionQuery childQuery, SqlClause sqlClause, String aliasName, int nestLevel)
            : base(childQuery, sqlClause, aliasName, nestLevel) {}

        public VendorCheckCIQ Inline() {
            if (_inlineQuery == null) {
                _inlineQuery = new VendorCheckCIQ(xgetReferrerQuery(), xgetSqlClause(), xgetAliasName(), xgetNestLevel(), this);
            }
            _inlineQuery.xsetOnClause(false);
            return _inlineQuery;
        }
        
        public VendorCheckCIQ On() {
            if (isBaseQuery()) { throw new UnsupportedOperationException("Unsupported onClause of Base Table!"); }
            VendorCheckCIQ inlineQuery = Inline();
            inlineQuery.xsetOnClause(true);
            return inlineQuery;
        }


        protected ConditionValue _vendorCheckId;
        public ConditionValue VendorCheckId {
            get { if (_vendorCheckId == null) { _vendorCheckId = new ConditionValue(); } return _vendorCheckId; }
        }
        protected override ConditionValue getCValueVendorCheckId() { return this.VendorCheckId; }


        public BsVendorCheckCQ AddOrderBy_VendorCheckId_Asc() { regOBA("VENDOR_CHECK_ID");return this; }
        public BsVendorCheckCQ AddOrderBy_VendorCheckId_Desc() { regOBD("VENDOR_CHECK_ID");return this; }

        protected ConditionValue _typeOfBoolean;
        public ConditionValue TypeOfBoolean {
            get { if (_typeOfBoolean == null) { _typeOfBoolean = new ConditionValue(); } return _typeOfBoolean; }
        }
        protected override ConditionValue getCValueTypeOfBoolean() { return this.TypeOfBoolean; }


        public BsVendorCheckCQ AddOrderBy_TypeOfBoolean_Asc() { regOBA("TYPE_OF_BOOLEAN");return this; }
        public BsVendorCheckCQ AddOrderBy_TypeOfBoolean_Desc() { regOBD("TYPE_OF_BOOLEAN");return this; }

        protected ConditionValue _typeOfInteger;
        public ConditionValue TypeOfInteger {
            get { if (_typeOfInteger == null) { _typeOfInteger = new ConditionValue(); } return _typeOfInteger; }
        }
        protected override ConditionValue getCValueTypeOfInteger() { return this.TypeOfInteger; }


        public BsVendorCheckCQ AddOrderBy_TypeOfInteger_Asc() { regOBA("TYPE_OF_INTEGER");return this; }
        public BsVendorCheckCQ AddOrderBy_TypeOfInteger_Desc() { regOBD("TYPE_OF_INTEGER");return this; }

        protected ConditionValue _typeOfBigint;
        public ConditionValue TypeOfBigint {
            get { if (_typeOfBigint == null) { _typeOfBigint = new ConditionValue(); } return _typeOfBigint; }
        }
        protected override ConditionValue getCValueTypeOfBigint() { return this.TypeOfBigint; }


        public BsVendorCheckCQ AddOrderBy_TypeOfBigint_Asc() { regOBA("TYPE_OF_BIGINT");return this; }
        public BsVendorCheckCQ AddOrderBy_TypeOfBigint_Desc() { regOBD("TYPE_OF_BIGINT");return this; }

        protected ConditionValue _typeOfFloat;
        public ConditionValue TypeOfFloat {
            get { if (_typeOfFloat == null) { _typeOfFloat = new ConditionValue(); } return _typeOfFloat; }
        }
        protected override ConditionValue getCValueTypeOfFloat() { return this.TypeOfFloat; }


        public BsVendorCheckCQ AddOrderBy_TypeOfFloat_Asc() { regOBA("TYPE_OF_FLOAT");return this; }
        public BsVendorCheckCQ AddOrderBy_TypeOfFloat_Desc() { regOBD("TYPE_OF_FLOAT");return this; }

        protected ConditionValue _typeOfDouble;
        public ConditionValue TypeOfDouble {
            get { if (_typeOfDouble == null) { _typeOfDouble = new ConditionValue(); } return _typeOfDouble; }
        }
        protected override ConditionValue getCValueTypeOfDouble() { return this.TypeOfDouble; }


        public BsVendorCheckCQ AddOrderBy_TypeOfDouble_Asc() { regOBA("TYPE_OF_DOUBLE");return this; }
        public BsVendorCheckCQ AddOrderBy_TypeOfDouble_Desc() { regOBD("TYPE_OF_DOUBLE");return this; }

        protected ConditionValue _typeOfDecimalDecimal;
        public ConditionValue TypeOfDecimalDecimal {
            get { if (_typeOfDecimalDecimal == null) { _typeOfDecimalDecimal = new ConditionValue(); } return _typeOfDecimalDecimal; }
        }
        protected override ConditionValue getCValueTypeOfDecimalDecimal() { return this.TypeOfDecimalDecimal; }


        public BsVendorCheckCQ AddOrderBy_TypeOfDecimalDecimal_Asc() { regOBA("TYPE_OF_DECIMAL_DECIMAL");return this; }
        public BsVendorCheckCQ AddOrderBy_TypeOfDecimalDecimal_Desc() { regOBD("TYPE_OF_DECIMAL_DECIMAL");return this; }

        protected ConditionValue _typeOfDecimalInteger;
        public ConditionValue TypeOfDecimalInteger {
            get { if (_typeOfDecimalInteger == null) { _typeOfDecimalInteger = new ConditionValue(); } return _typeOfDecimalInteger; }
        }
        protected override ConditionValue getCValueTypeOfDecimalInteger() { return this.TypeOfDecimalInteger; }


        public BsVendorCheckCQ AddOrderBy_TypeOfDecimalInteger_Asc() { regOBA("TYPE_OF_DECIMAL_INTEGER");return this; }
        public BsVendorCheckCQ AddOrderBy_TypeOfDecimalInteger_Desc() { regOBD("TYPE_OF_DECIMAL_INTEGER");return this; }

        protected ConditionValue _typeOfDecimalBigint;
        public ConditionValue TypeOfDecimalBigint {
            get { if (_typeOfDecimalBigint == null) { _typeOfDecimalBigint = new ConditionValue(); } return _typeOfDecimalBigint; }
        }
        protected override ConditionValue getCValueTypeOfDecimalBigint() { return this.TypeOfDecimalBigint; }


        public BsVendorCheckCQ AddOrderBy_TypeOfDecimalBigint_Asc() { regOBA("TYPE_OF_DECIMAL_BIGINT");return this; }
        public BsVendorCheckCQ AddOrderBy_TypeOfDecimalBigint_Desc() { regOBD("TYPE_OF_DECIMAL_BIGINT");return this; }

        protected ConditionValue _typeOfNumericDecimal;
        public ConditionValue TypeOfNumericDecimal {
            get { if (_typeOfNumericDecimal == null) { _typeOfNumericDecimal = new ConditionValue(); } return _typeOfNumericDecimal; }
        }
        protected override ConditionValue getCValueTypeOfNumericDecimal() { return this.TypeOfNumericDecimal; }


        public BsVendorCheckCQ AddOrderBy_TypeOfNumericDecimal_Asc() { regOBA("TYPE_OF_NUMERIC_DECIMAL");return this; }
        public BsVendorCheckCQ AddOrderBy_TypeOfNumericDecimal_Desc() { regOBD("TYPE_OF_NUMERIC_DECIMAL");return this; }

        protected ConditionValue _typeOfNumericInteger;
        public ConditionValue TypeOfNumericInteger {
            get { if (_typeOfNumericInteger == null) { _typeOfNumericInteger = new ConditionValue(); } return _typeOfNumericInteger; }
        }
        protected override ConditionValue getCValueTypeOfNumericInteger() { return this.TypeOfNumericInteger; }


        public BsVendorCheckCQ AddOrderBy_TypeOfNumericInteger_Asc() { regOBA("TYPE_OF_NUMERIC_INTEGER");return this; }
        public BsVendorCheckCQ AddOrderBy_TypeOfNumericInteger_Desc() { regOBD("TYPE_OF_NUMERIC_INTEGER");return this; }

        protected ConditionValue _typeOfNumericBigint;
        public ConditionValue TypeOfNumericBigint {
            get { if (_typeOfNumericBigint == null) { _typeOfNumericBigint = new ConditionValue(); } return _typeOfNumericBigint; }
        }
        protected override ConditionValue getCValueTypeOfNumericBigint() { return this.TypeOfNumericBigint; }


        public BsVendorCheckCQ AddOrderBy_TypeOfNumericBigint_Asc() { regOBA("TYPE_OF_NUMERIC_BIGINT");return this; }
        public BsVendorCheckCQ AddOrderBy_TypeOfNumericBigint_Desc() { regOBD("TYPE_OF_NUMERIC_BIGINT");return this; }

        protected ConditionValue _typeOfText;
        public ConditionValue TypeOfText {
            get { if (_typeOfText == null) { _typeOfText = new ConditionValue(); } return _typeOfText; }
        }
        protected override ConditionValue getCValueTypeOfText() { return this.TypeOfText; }


        public BsVendorCheckCQ AddOrderBy_TypeOfText_Asc() { regOBA("TYPE_OF_TEXT");return this; }
        public BsVendorCheckCQ AddOrderBy_TypeOfText_Desc() { regOBD("TYPE_OF_TEXT");return this; }

        protected ConditionValue _typeOfTinytext;
        public ConditionValue TypeOfTinytext {
            get { if (_typeOfTinytext == null) { _typeOfTinytext = new ConditionValue(); } return _typeOfTinytext; }
        }
        protected override ConditionValue getCValueTypeOfTinytext() { return this.TypeOfTinytext; }


        public BsVendorCheckCQ AddOrderBy_TypeOfTinytext_Asc() { regOBA("TYPE_OF_TINYTEXT");return this; }
        public BsVendorCheckCQ AddOrderBy_TypeOfTinytext_Desc() { regOBD("TYPE_OF_TINYTEXT");return this; }

        protected ConditionValue _typeOfMediumtext;
        public ConditionValue TypeOfMediumtext {
            get { if (_typeOfMediumtext == null) { _typeOfMediumtext = new ConditionValue(); } return _typeOfMediumtext; }
        }
        protected override ConditionValue getCValueTypeOfMediumtext() { return this.TypeOfMediumtext; }


        public BsVendorCheckCQ AddOrderBy_TypeOfMediumtext_Asc() { regOBA("TYPE_OF_MEDIUMTEXT");return this; }
        public BsVendorCheckCQ AddOrderBy_TypeOfMediumtext_Desc() { regOBD("TYPE_OF_MEDIUMTEXT");return this; }

        protected ConditionValue _typeOfLongtext;
        public ConditionValue TypeOfLongtext {
            get { if (_typeOfLongtext == null) { _typeOfLongtext = new ConditionValue(); } return _typeOfLongtext; }
        }
        protected override ConditionValue getCValueTypeOfLongtext() { return this.TypeOfLongtext; }


        public BsVendorCheckCQ AddOrderBy_TypeOfLongtext_Asc() { regOBA("TYPE_OF_LONGTEXT");return this; }
        public BsVendorCheckCQ AddOrderBy_TypeOfLongtext_Desc() { regOBD("TYPE_OF_LONGTEXT");return this; }

        protected ConditionValue _typeOfDate;
        public ConditionValue TypeOfDate {
            get { if (_typeOfDate == null) { _typeOfDate = new ConditionValue(); } return _typeOfDate; }
        }
        protected override ConditionValue getCValueTypeOfDate() { return this.TypeOfDate; }


        public BsVendorCheckCQ AddOrderBy_TypeOfDate_Asc() { regOBA("TYPE_OF_DATE");return this; }
        public BsVendorCheckCQ AddOrderBy_TypeOfDate_Desc() { regOBD("TYPE_OF_DATE");return this; }

        protected ConditionValue _typeOfDatetime;
        public ConditionValue TypeOfDatetime {
            get { if (_typeOfDatetime == null) { _typeOfDatetime = new ConditionValue(); } return _typeOfDatetime; }
        }
        protected override ConditionValue getCValueTypeOfDatetime() { return this.TypeOfDatetime; }


        public BsVendorCheckCQ AddOrderBy_TypeOfDatetime_Asc() { regOBA("TYPE_OF_DATETIME");return this; }
        public BsVendorCheckCQ AddOrderBy_TypeOfDatetime_Desc() { regOBD("TYPE_OF_DATETIME");return this; }

        protected ConditionValue _typeOfTimestamp;
        public ConditionValue TypeOfTimestamp {
            get { if (_typeOfTimestamp == null) { _typeOfTimestamp = new ConditionValue(); } return _typeOfTimestamp; }
        }
        protected override ConditionValue getCValueTypeOfTimestamp() { return this.TypeOfTimestamp; }


        public BsVendorCheckCQ AddOrderBy_TypeOfTimestamp_Asc() { regOBA("TYPE_OF_TIMESTAMP");return this; }
        public BsVendorCheckCQ AddOrderBy_TypeOfTimestamp_Desc() { regOBD("TYPE_OF_TIMESTAMP");return this; }

        protected ConditionValue _typeOfTime;
        public ConditionValue TypeOfTime {
            get { if (_typeOfTime == null) { _typeOfTime = new ConditionValue(); } return _typeOfTime; }
        }
        protected override ConditionValue getCValueTypeOfTime() { return this.TypeOfTime; }


        public BsVendorCheckCQ AddOrderBy_TypeOfTime_Asc() { regOBA("TYPE_OF_TIME");return this; }
        public BsVendorCheckCQ AddOrderBy_TypeOfTime_Desc() { regOBD("TYPE_OF_TIME");return this; }

        protected ConditionValue _typeOfYear;
        public ConditionValue TypeOfYear {
            get { if (_typeOfYear == null) { _typeOfYear = new ConditionValue(); } return _typeOfYear; }
        }
        protected override ConditionValue getCValueTypeOfYear() { return this.TypeOfYear; }


        public BsVendorCheckCQ AddOrderBy_TypeOfYear_Asc() { regOBA("TYPE_OF_YEAR");return this; }
        public BsVendorCheckCQ AddOrderBy_TypeOfYear_Desc() { regOBD("TYPE_OF_YEAR");return this; }

        protected ConditionValue _typeOfBlob;
        public ConditionValue TypeOfBlob {
            get { if (_typeOfBlob == null) { _typeOfBlob = new ConditionValue(); } return _typeOfBlob; }
        }
        protected override ConditionValue getCValueTypeOfBlob() { return this.TypeOfBlob; }


        public BsVendorCheckCQ AddOrderBy_TypeOfBlob_Asc() { regOBA("TYPE_OF_BLOB");return this; }
        public BsVendorCheckCQ AddOrderBy_TypeOfBlob_Desc() { regOBD("TYPE_OF_BLOB");return this; }

        protected ConditionValue _typeOfTinyblob;
        public ConditionValue TypeOfTinyblob {
            get { if (_typeOfTinyblob == null) { _typeOfTinyblob = new ConditionValue(); } return _typeOfTinyblob; }
        }
        protected override ConditionValue getCValueTypeOfTinyblob() { return this.TypeOfTinyblob; }


        public BsVendorCheckCQ AddOrderBy_TypeOfTinyblob_Asc() { regOBA("TYPE_OF_TINYBLOB");return this; }
        public BsVendorCheckCQ AddOrderBy_TypeOfTinyblob_Desc() { regOBD("TYPE_OF_TINYBLOB");return this; }

        protected ConditionValue _typeOfMediumblob;
        public ConditionValue TypeOfMediumblob {
            get { if (_typeOfMediumblob == null) { _typeOfMediumblob = new ConditionValue(); } return _typeOfMediumblob; }
        }
        protected override ConditionValue getCValueTypeOfMediumblob() { return this.TypeOfMediumblob; }


        public BsVendorCheckCQ AddOrderBy_TypeOfMediumblob_Asc() { regOBA("TYPE_OF_MEDIUMBLOB");return this; }
        public BsVendorCheckCQ AddOrderBy_TypeOfMediumblob_Desc() { regOBD("TYPE_OF_MEDIUMBLOB");return this; }

        protected ConditionValue _typeOfLongblob;
        public ConditionValue TypeOfLongblob {
            get { if (_typeOfLongblob == null) { _typeOfLongblob = new ConditionValue(); } return _typeOfLongblob; }
        }
        protected override ConditionValue getCValueTypeOfLongblob() { return this.TypeOfLongblob; }


        public BsVendorCheckCQ AddOrderBy_TypeOfLongblob_Asc() { regOBA("TYPE_OF_LONGBLOB");return this; }
        public BsVendorCheckCQ AddOrderBy_TypeOfLongblob_Desc() { regOBD("TYPE_OF_LONGBLOB");return this; }

        protected ConditionValue _typeOfBinary;
        public ConditionValue TypeOfBinary {
            get { if (_typeOfBinary == null) { _typeOfBinary = new ConditionValue(); } return _typeOfBinary; }
        }
        protected override ConditionValue getCValueTypeOfBinary() { return this.TypeOfBinary; }


        public BsVendorCheckCQ AddOrderBy_TypeOfBinary_Asc() { regOBA("TYPE_OF_BINARY");return this; }
        public BsVendorCheckCQ AddOrderBy_TypeOfBinary_Desc() { regOBD("TYPE_OF_BINARY");return this; }

        protected ConditionValue _typeOfVarbinary;
        public ConditionValue TypeOfVarbinary {
            get { if (_typeOfVarbinary == null) { _typeOfVarbinary = new ConditionValue(); } return _typeOfVarbinary; }
        }
        protected override ConditionValue getCValueTypeOfVarbinary() { return this.TypeOfVarbinary; }


        public BsVendorCheckCQ AddOrderBy_TypeOfVarbinary_Asc() { regOBA("TYPE_OF_VARBINARY");return this; }
        public BsVendorCheckCQ AddOrderBy_TypeOfVarbinary_Desc() { regOBD("TYPE_OF_VARBINARY");return this; }

        protected ConditionValue _typeOfEnum;
        public ConditionValue TypeOfEnum {
            get { if (_typeOfEnum == null) { _typeOfEnum = new ConditionValue(); } return _typeOfEnum; }
        }
        protected override ConditionValue getCValueTypeOfEnum() { return this.TypeOfEnum; }


        public BsVendorCheckCQ AddOrderBy_TypeOfEnum_Asc() { regOBA("TYPE_OF_ENUM");return this; }
        public BsVendorCheckCQ AddOrderBy_TypeOfEnum_Desc() { regOBD("TYPE_OF_ENUM");return this; }

        protected ConditionValue _typeOfSet;
        public ConditionValue TypeOfSet {
            get { if (_typeOfSet == null) { _typeOfSet = new ConditionValue(); } return _typeOfSet; }
        }
        protected override ConditionValue getCValueTypeOfSet() { return this.TypeOfSet; }


        public BsVendorCheckCQ AddOrderBy_TypeOfSet_Asc() { regOBA("TYPE_OF_SET");return this; }
        public BsVendorCheckCQ AddOrderBy_TypeOfSet_Desc() { regOBD("TYPE_OF_SET");return this; }

        public BsVendorCheckCQ AddSpecifiedDerivedOrderBy_Asc(String aliasName) { registerSpecifiedDerivedOrderBy_Asc(aliasName); return this; }
        public BsVendorCheckCQ AddSpecifiedDerivedOrderBy_Desc(String aliasName) { registerSpecifiedDerivedOrderBy_Desc(aliasName); return this; }

        public override void reflectRelationOnUnionQuery(ConditionQuery baseQueryAsSuper, ConditionQuery unionQueryAsSuper) {

        }
    


	    // ===============================================================================
	    //                                                                 Scalar SubQuery
	    //                                                                 ===============
	    protected Map<String, VendorCheckCQ> _scalarSubQueryMap;
	    public Map<String, VendorCheckCQ> ScalarSubQuery { get { return _scalarSubQueryMap; } }
	    public override String keepScalarSubQuery(VendorCheckCQ subQuery) {
	        if (_scalarSubQueryMap == null) { _scalarSubQueryMap = new LinkedHashMap<String, VendorCheckCQ>(); }
	        String key = "subQueryMapKey" + (_scalarSubQueryMap.size() + 1);
	        _scalarSubQueryMap.put(key, subQuery); return "ScalarSubQuery." + key;
	    }

        // ===============================================================================
        //                                                         Myself InScope SubQuery
        //                                                         =======================
        protected Map<String, VendorCheckCQ> _myselfInScopeSubQueryMap;
        public Map<String, VendorCheckCQ> MyselfInScopeSubQuery { get { return _myselfInScopeSubQueryMap; } }
        public override String keepMyselfInScopeSubQuery(VendorCheckCQ subQuery) {
            if (_myselfInScopeSubQueryMap == null) { _myselfInScopeSubQueryMap = new LinkedHashMap<String, VendorCheckCQ>(); }
            String key = "subQueryMapKey" + (_myselfInScopeSubQueryMap.size() + 1);
            _myselfInScopeSubQueryMap.put(key, subQuery); return "MyselfInScopeSubQuery." + key;
        }
    }
}
