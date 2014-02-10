
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


        protected override ConditionValue getCValueDecimalDigit() {
            return _myCQ.DecimalDigit;
        }


        protected override ConditionValue getCValueIntegerNonDigit() {
            return _myCQ.IntegerNonDigit;
        }


        protected override ConditionValue getCValueLargeCharacter() {
            return _myCQ.LargeCharacter;
        }


        protected override ConditionValue getCValueTypeOfChar() {
            return _myCQ.TypeOfChar;
        }


        protected override ConditionValue getCValueTypeOfNchar() {
            return _myCQ.TypeOfNchar;
        }


        protected override ConditionValue getCValueTypeOfVarchar2() {
            return _myCQ.TypeOfVarchar2;
        }


        protected override ConditionValue getCValueTypeOfVarchar2Max() {
            return _myCQ.TypeOfVarchar2Max;
        }


        protected override ConditionValue getCValueTypeOfNvarchar2() {
            return _myCQ.TypeOfNvarchar2;
        }


        protected override ConditionValue getCValueTypeOfClob() {
            return _myCQ.TypeOfClob;
        }


        protected override ConditionValue getCValueTypeOfNclob() {
            return _myCQ.TypeOfNclob;
        }


        protected override ConditionValue getCValueTypeOfDate() {
            return _myCQ.TypeOfDate;
        }


        protected override ConditionValue getCValueTypeOfTimestamp() {
            return _myCQ.TypeOfTimestamp;
        }


        protected override ConditionValue getCValueTypeOfBlob() {
            return _myCQ.TypeOfBlob;
        }


        protected override ConditionValue getCValueTypeOfRaw() {
            return _myCQ.TypeOfRaw;
        }


        protected override ConditionValue getCValueTypeOfBfile() {
            return _myCQ.TypeOfBfile;
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
