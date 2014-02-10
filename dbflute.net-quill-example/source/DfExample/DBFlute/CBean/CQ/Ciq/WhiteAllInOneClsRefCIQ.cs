
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
    public class WhiteAllInOneClsRefCIQ : AbstractBsWhiteAllInOneClsRefCQ {

        // ===============================================================================
        //                                                                       Attribute
        //                                                                       =========
        protected BsWhiteAllInOneClsRefCQ _myCQ;

        // ===============================================================================
        //                                                                     Constructor
        //                                                                     ===========
        public WhiteAllInOneClsRefCIQ(ConditionQuery childQuery, SqlClause sqlClause, String aliasName, int nestLevel, BsWhiteAllInOneClsRefCQ myCQ)
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


        protected override ConditionValue getCValueClsRefId() {
            return _myCQ.ClsRefId;
        }


        protected override ConditionValue getCValueFooCode() {
            return _myCQ.FooCode;
        }


        protected override ConditionValue getCValueBarCode() {
            return _myCQ.BarCode;
        }


        protected override ConditionValue getCValueQuxCode() {
            return _myCQ.QuxCode;
        }


        // ===================================================================================
        //                                                                     Scalar SubQuery
        //                                                                     ===============
        public override String keepScalarSubQuery(WhiteAllInOneClsRefCQ subQuery) {
            throw new UnsupportedOperationException("ScalarSubQuery at inline() is unsupported! Sorry!");
        }

        // ===============================================================================
        //                                                         Myself InScope SubQuery
        //                                                         =======================
        public override String keepMyselfInScopeSubQuery(WhiteAllInOneClsRefCQ subQuery) {
            throw new UnsupportedOperationException("MyselfInScopeSubQuery at inline() is unsupported! Sorry!");
        }
    }
}
