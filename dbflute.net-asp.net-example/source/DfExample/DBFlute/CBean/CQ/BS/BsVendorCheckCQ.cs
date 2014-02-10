
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

        protected ConditionValue _decimalDigit;
        public ConditionValue DecimalDigit {
            get { if (_decimalDigit == null) { _decimalDigit = new ConditionValue(); } return _decimalDigit; }
        }
        protected override ConditionValue getCValueDecimalDigit() { return this.DecimalDigit; }


        public BsVendorCheckCQ AddOrderBy_DecimalDigit_Asc() { regOBA("DECIMAL_DIGIT");return this; }
        public BsVendorCheckCQ AddOrderBy_DecimalDigit_Desc() { regOBD("DECIMAL_DIGIT");return this; }

        protected ConditionValue _integerNonDigit;
        public ConditionValue IntegerNonDigit {
            get { if (_integerNonDigit == null) { _integerNonDigit = new ConditionValue(); } return _integerNonDigit; }
        }
        protected override ConditionValue getCValueIntegerNonDigit() { return this.IntegerNonDigit; }


        public BsVendorCheckCQ AddOrderBy_IntegerNonDigit_Asc() { regOBA("INTEGER_NON_DIGIT");return this; }
        public BsVendorCheckCQ AddOrderBy_IntegerNonDigit_Desc() { regOBD("INTEGER_NON_DIGIT");return this; }

        protected ConditionValue _largeCharacter;
        public ConditionValue LargeCharacter {
            get { if (_largeCharacter == null) { _largeCharacter = new ConditionValue(); } return _largeCharacter; }
        }
        protected override ConditionValue getCValueLargeCharacter() { return this.LargeCharacter; }


        public BsVendorCheckCQ AddOrderBy_LargeCharacter_Asc() { regOBA("LARGE_CHARACTER");return this; }
        public BsVendorCheckCQ AddOrderBy_LargeCharacter_Desc() { regOBD("LARGE_CHARACTER");return this; }

        protected ConditionValue _typeOfChar;
        public ConditionValue TypeOfChar {
            get { if (_typeOfChar == null) { _typeOfChar = new ConditionValue(); } return _typeOfChar; }
        }
        protected override ConditionValue getCValueTypeOfChar() { return this.TypeOfChar; }


        public BsVendorCheckCQ AddOrderBy_TypeOfChar_Asc() { regOBA("TYPE_OF_CHAR");return this; }
        public BsVendorCheckCQ AddOrderBy_TypeOfChar_Desc() { regOBD("TYPE_OF_CHAR");return this; }

        protected ConditionValue _typeOfNchar;
        public ConditionValue TypeOfNchar {
            get { if (_typeOfNchar == null) { _typeOfNchar = new ConditionValue(); } return _typeOfNchar; }
        }
        protected override ConditionValue getCValueTypeOfNchar() { return this.TypeOfNchar; }


        public BsVendorCheckCQ AddOrderBy_TypeOfNchar_Asc() { regOBA("TYPE_OF_NCHAR");return this; }
        public BsVendorCheckCQ AddOrderBy_TypeOfNchar_Desc() { regOBD("TYPE_OF_NCHAR");return this; }

        protected ConditionValue _typeOfVarchar2;
        public ConditionValue TypeOfVarchar2 {
            get { if (_typeOfVarchar2 == null) { _typeOfVarchar2 = new ConditionValue(); } return _typeOfVarchar2; }
        }
        protected override ConditionValue getCValueTypeOfVarchar2() { return this.TypeOfVarchar2; }


        public BsVendorCheckCQ AddOrderBy_TypeOfVarchar2_Asc() { regOBA("TYPE_OF_VARCHAR2");return this; }
        public BsVendorCheckCQ AddOrderBy_TypeOfVarchar2_Desc() { regOBD("TYPE_OF_VARCHAR2");return this; }

        protected ConditionValue _typeOfVarchar2Max;
        public ConditionValue TypeOfVarchar2Max {
            get { if (_typeOfVarchar2Max == null) { _typeOfVarchar2Max = new ConditionValue(); } return _typeOfVarchar2Max; }
        }
        protected override ConditionValue getCValueTypeOfVarchar2Max() { return this.TypeOfVarchar2Max; }


        public BsVendorCheckCQ AddOrderBy_TypeOfVarchar2Max_Asc() { regOBA("TYPE_OF_VARCHAR2_MAX");return this; }
        public BsVendorCheckCQ AddOrderBy_TypeOfVarchar2Max_Desc() { regOBD("TYPE_OF_VARCHAR2_MAX");return this; }

        protected ConditionValue _typeOfNvarchar2;
        public ConditionValue TypeOfNvarchar2 {
            get { if (_typeOfNvarchar2 == null) { _typeOfNvarchar2 = new ConditionValue(); } return _typeOfNvarchar2; }
        }
        protected override ConditionValue getCValueTypeOfNvarchar2() { return this.TypeOfNvarchar2; }


        public BsVendorCheckCQ AddOrderBy_TypeOfNvarchar2_Asc() { regOBA("TYPE_OF_NVARCHAR2");return this; }
        public BsVendorCheckCQ AddOrderBy_TypeOfNvarchar2_Desc() { regOBD("TYPE_OF_NVARCHAR2");return this; }

        protected ConditionValue _typeOfClob;
        public ConditionValue TypeOfClob {
            get { if (_typeOfClob == null) { _typeOfClob = new ConditionValue(); } return _typeOfClob; }
        }
        protected override ConditionValue getCValueTypeOfClob() { return this.TypeOfClob; }


        public BsVendorCheckCQ AddOrderBy_TypeOfClob_Asc() { regOBA("TYPE_OF_CLOB");return this; }
        public BsVendorCheckCQ AddOrderBy_TypeOfClob_Desc() { regOBD("TYPE_OF_CLOB");return this; }

        protected ConditionValue _typeOfNclob;
        public ConditionValue TypeOfNclob {
            get { if (_typeOfNclob == null) { _typeOfNclob = new ConditionValue(); } return _typeOfNclob; }
        }
        protected override ConditionValue getCValueTypeOfNclob() { return this.TypeOfNclob; }


        public BsVendorCheckCQ AddOrderBy_TypeOfNclob_Asc() { regOBA("TYPE_OF_NCLOB");return this; }
        public BsVendorCheckCQ AddOrderBy_TypeOfNclob_Desc() { regOBD("TYPE_OF_NCLOB");return this; }

        protected ConditionValue _typeOfDate;
        public ConditionValue TypeOfDate {
            get { if (_typeOfDate == null) { _typeOfDate = new ConditionValue(); } return _typeOfDate; }
        }
        protected override ConditionValue getCValueTypeOfDate() { return this.TypeOfDate; }


        public BsVendorCheckCQ AddOrderBy_TypeOfDate_Asc() { regOBA("TYPE_OF_DATE");return this; }
        public BsVendorCheckCQ AddOrderBy_TypeOfDate_Desc() { regOBD("TYPE_OF_DATE");return this; }

        protected ConditionValue _typeOfTimestamp;
        public ConditionValue TypeOfTimestamp {
            get { if (_typeOfTimestamp == null) { _typeOfTimestamp = new ConditionValue(); } return _typeOfTimestamp; }
        }
        protected override ConditionValue getCValueTypeOfTimestamp() { return this.TypeOfTimestamp; }


        public BsVendorCheckCQ AddOrderBy_TypeOfTimestamp_Asc() { regOBA("TYPE_OF_TIMESTAMP");return this; }
        public BsVendorCheckCQ AddOrderBy_TypeOfTimestamp_Desc() { regOBD("TYPE_OF_TIMESTAMP");return this; }

        protected ConditionValue _typeOfBlob;
        public ConditionValue TypeOfBlob {
            get { if (_typeOfBlob == null) { _typeOfBlob = new ConditionValue(); } return _typeOfBlob; }
        }
        protected override ConditionValue getCValueTypeOfBlob() { return this.TypeOfBlob; }


        public BsVendorCheckCQ AddOrderBy_TypeOfBlob_Asc() { regOBA("TYPE_OF_BLOB");return this; }
        public BsVendorCheckCQ AddOrderBy_TypeOfBlob_Desc() { regOBD("TYPE_OF_BLOB");return this; }

        protected ConditionValue _typeOfRaw;
        public ConditionValue TypeOfRaw {
            get { if (_typeOfRaw == null) { _typeOfRaw = new ConditionValue(); } return _typeOfRaw; }
        }
        protected override ConditionValue getCValueTypeOfRaw() { return this.TypeOfRaw; }


        public BsVendorCheckCQ AddOrderBy_TypeOfRaw_Asc() { regOBA("TYPE_OF_RAW");return this; }
        public BsVendorCheckCQ AddOrderBy_TypeOfRaw_Desc() { regOBD("TYPE_OF_RAW");return this; }

        protected ConditionValue _typeOfBfile;
        public ConditionValue TypeOfBfile {
            get { if (_typeOfBfile == null) { _typeOfBfile = new ConditionValue(); } return _typeOfBfile; }
        }
        protected override ConditionValue getCValueTypeOfBfile() { return this.TypeOfBfile; }


        public BsVendorCheckCQ AddOrderBy_TypeOfBfile_Asc() { regOBA("TYPE_OF_BFILE");return this; }
        public BsVendorCheckCQ AddOrderBy_TypeOfBfile_Desc() { regOBD("TYPE_OF_BFILE");return this; }

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
