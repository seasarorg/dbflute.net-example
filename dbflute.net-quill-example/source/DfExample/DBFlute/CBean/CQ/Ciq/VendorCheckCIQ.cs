
using System;

using DfExample.DBFlute.AllCommon.CBean;
using DfExample.DBFlute.AllCommon.CBean.CKey;
using DfExample.DBFlute.AllCommon.CBean.COption;
using DfExample.DBFlute.AllCommon.CBean.CValue;
using DfExample.DBFlute.AllCommon.CBean.SClause;
using DfExample.DBFlute.AllCommon.JavaLike;
using DfExample.DBFlute.CBean.CQ.BS;
using DfExample.DBFlute.CBean.CQ;

namespace DfExample.DBFlute.CBean.CQ.Ciq {

    [System.Serializable]
    public class VendorCheckCIQ : AbstractBsVendorCheckCQ {

        // ===============================================================================
        //                                                                       Attribute
        //                                                                       =========
        protected BsVendorCheckCQ _myCQ;

        // ===============================================================================
        //                                                                     Constructor
        //                                                                     ===========
        public VendorCheckCIQ(ConditionQuery childQuery, SqlClause sqlClause, String aliasName, int nestLevel, BsVendorCheckCQ myCQ)
            : base(childQuery, sqlClause, aliasName, nestLevel) {
            _myCQ = myCQ;
            _foreignPropertyName = _myCQ.xgetForeignPropertyName();// Accept foreign property name.
            _relationPath = _myCQ.xgetRelationPath();// Accept relation path.
        }

        // ===================================================================================
        //                                                             Override about Register
        //                                                             =======================
        public override void reflectRelationOnUnionQuery(ConditionQuery baseQueryAsSuper, ConditionQuery unionQueryAsSuper) {
            throw new UnsupportedOperationException("InlineQuery must not need UNION method: " + baseQueryAsSuper + " : " + unionQueryAsSuper);
        }
    
        protected override void setupConditionValueAndRegisterWhereClause(ConditionKey key, Object value, ConditionValue cvalue, String colName) {
            regIQ(key, value, cvalue, colName);
        }
    
        protected override void setupConditionValueAndRegisterWhereClause(ConditionKey key, Object value, ConditionValue cvalue
                                                                        , String colName, ConditionOption option) {
            regIQ(key, value, cvalue, colName, option);
        }
    
        protected override void registerWhereClause(String whereClause) {
            registerInlineWhereClause(whereClause);
        }
    
        protected override String getInScopeSubQueryRealColumnName(String columnName) {
            if (_onClause) {
                throw new UnsupportedOperationException("InScopeSubQuery of on-clause is unsupported");
            }
            return _onClause ? xgetAliasName() + "." + columnName : columnName;
        }
    
        protected override void registerExistsSubQuery(ConditionQuery subQuery
                                     , String columnName, String relatedColumnName, String propertyName) {
            throw new UnsupportedOperationException("Sorry! ExistsSubQuery at inline view is unsupported. So please use InScopeSubQyery.");
        }


        protected override ConditionValue getCValueVendorCheckId() {
            return _myCQ.VendorCheckId;
        }


        protected override ConditionValue getCValueTypeOfBoolean() {
            return _myCQ.TypeOfBoolean;
        }


        protected override ConditionValue getCValueTypeOfInteger() {
            return _myCQ.TypeOfInteger;
        }


        protected override ConditionValue getCValueTypeOfBigint() {
            return _myCQ.TypeOfBigint;
        }


        protected override ConditionValue getCValueTypeOfFloat() {
            return _myCQ.TypeOfFloat;
        }


        protected override ConditionValue getCValueTypeOfDouble() {
            return _myCQ.TypeOfDouble;
        }


        protected override ConditionValue getCValueTypeOfDecimalDecimal() {
            return _myCQ.TypeOfDecimalDecimal;
        }


        protected override ConditionValue getCValueTypeOfDecimalInteger() {
            return _myCQ.TypeOfDecimalInteger;
        }


        protected override ConditionValue getCValueTypeOfDecimalBigint() {
            return _myCQ.TypeOfDecimalBigint;
        }


        protected override ConditionValue getCValueTypeOfNumericDecimal() {
            return _myCQ.TypeOfNumericDecimal;
        }


        protected override ConditionValue getCValueTypeOfNumericInteger() {
            return _myCQ.TypeOfNumericInteger;
        }


        protected override ConditionValue getCValueTypeOfNumericBigint() {
            return _myCQ.TypeOfNumericBigint;
        }


        protected override ConditionValue getCValueTypeOfText() {
            return _myCQ.TypeOfText;
        }


        protected override ConditionValue getCValueTypeOfTinytext() {
            return _myCQ.TypeOfTinytext;
        }


        protected override ConditionValue getCValueTypeOfMediumtext() {
            return _myCQ.TypeOfMediumtext;
        }


        protected override ConditionValue getCValueTypeOfLongtext() {
            return _myCQ.TypeOfLongtext;
        }


        protected override ConditionValue getCValueTypeOfDate() {
            return _myCQ.TypeOfDate;
        }


        protected override ConditionValue getCValueTypeOfDatetime() {
            return _myCQ.TypeOfDatetime;
        }


        protected override ConditionValue getCValueTypeOfTimestamp() {
            return _myCQ.TypeOfTimestamp;
        }


        protected override ConditionValue getCValueTypeOfTime() {
            return _myCQ.TypeOfTime;
        }


        protected override ConditionValue getCValueTypeOfYear() {
            return _myCQ.TypeOfYear;
        }


        protected override ConditionValue getCValueTypeOfBlob() {
            return _myCQ.TypeOfBlob;
        }


        protected override ConditionValue getCValueTypeOfTinyblob() {
            return _myCQ.TypeOfTinyblob;
        }


        protected override ConditionValue getCValueTypeOfMediumblob() {
            return _myCQ.TypeOfMediumblob;
        }


        protected override ConditionValue getCValueTypeOfLongblob() {
            return _myCQ.TypeOfLongblob;
        }


        protected override ConditionValue getCValueTypeOfBinary() {
            return _myCQ.TypeOfBinary;
        }


        protected override ConditionValue getCValueTypeOfVarbinary() {
            return _myCQ.TypeOfVarbinary;
        }


        protected override ConditionValue getCValueTypeOfEnum() {
            return _myCQ.TypeOfEnum;
        }


        protected override ConditionValue getCValueTypeOfSet() {
            return _myCQ.TypeOfSet;
        }


        // ===================================================================================
        //                                                                     Scalar SubQuery
        //                                                                     ===============
        public override String keepScalarSubQuery(VendorCheckCQ subQuery) {
            throw new UnsupportedOperationException("ScalarSubQuery at inline() is unsupported! Sorry!");
        }

        // ===============================================================================
        //                                                         Myself InScope SubQuery
        //                                                         =======================
        public override String keepMyselfInScopeSubQuery(VendorCheckCQ subQuery) {
            throw new UnsupportedOperationException("MyselfInScopeSubQuery at inline() is unsupported! Sorry!");
        }
    }
}
