
using System;

using DfExample.DBFlute.MemberDb.AllCommon.CBean;
using DfExample.DBFlute.MemberDb.AllCommon.CBean.CKey;
using DfExample.DBFlute.MemberDb.AllCommon.CBean.COption;
using DfExample.DBFlute.MemberDb.AllCommon.CBean.CValue;
using DfExample.DBFlute.MemberDb.AllCommon.CBean.SClause;
using DfExample.DBFlute.MemberDb.AllCommon.JavaLike;
using DfExample.DBFlute.MemberDb.CBean.CQ.BS;
using DfExample.DBFlute.MemberDb.CBean.CQ;

namespace DfExample.DBFlute.MemberDb.CBean.CQ.Ciq {

    [System.Serializable]
    public class MbProductStatusCIQ : MbAbstractBsProductStatusCQ {

        // ===============================================================================
        //                                                                       Attribute
        //                                                                       =========
        protected MbBsProductStatusCQ _myCQ;

        // ===============================================================================
        //                                                                     Constructor
        //                                                                     ===========
        public MbProductStatusCIQ(MbConditionQuery childQuery, MbSqlClause sqlClause, String aliasName, int nestLevel, MbBsProductStatusCQ myCQ)
            : base(childQuery, sqlClause, aliasName, nestLevel) {
            _myCQ = myCQ;
            _foreignPropertyName = _myCQ.xgetForeignPropertyName();// Accept foreign property name.
            _relationPath = _myCQ.xgetRelationPath();// Accept relation path.
        }

        // ===================================================================================
        //                                                             Override about Register
        //                                                             =======================
        public override void reflectRelationOnUnionQuery(MbConditionQuery baseQueryAsSuper, MbConditionQuery unionQueryAsSuper) {
            throw new UnsupportedOperationException("InlineQuery must not need UNION method: " + baseQueryAsSuper + " : " + unionQueryAsSuper);
        }
    
        protected override void setupConditionValueAndRegisterWhereClause(MbConditionKey key, Object value, MbConditionValue cvalue, String colName) {
            regIQ(key, value, cvalue, colName);
        }
    
        protected override void setupConditionValueAndRegisterWhereClause(MbConditionKey key, Object value, MbConditionValue cvalue
                                                                        , String colName, MbConditionOption option) {
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
    
        protected override void registerExistsSubQuery(MbConditionQuery subQuery
                                     , String columnName, String relatedColumnName, String propertyName) {
            throw new UnsupportedOperationException("Sorry! ExistsSubQuery at inline view is unsupported. So please use InScopeSubQyery.");
        }


        protected override MbConditionValue getCValueProductStatusCode() {
            return _myCQ.ProductStatusCode;
        }


        public override String keepProductStatusCode_ExistsSubQuery_ProductList(MbProductCQ subQuery) {
            throw new SystemException("ExistsSubQuery at inline() is unsupported! Sorry!");
            // _myCQ.keepProductStatusCode_ExistsSubQuery_ProductList(subQuery);
        }

        public override String keepProductStatusCode_NotExistsSubQuery_ProductList(MbProductCQ subQuery) {
            throw new SystemException("NotExistsSubQuery at inline() is unsupported! Sorry!");
            // _myCQ.keepProductStatusCode_NotExistsSubQuery_ProductList(subQuery);
        }

        public override String keepProductStatusCode_InScopeSubQuery_ProductList(MbProductCQ subQuery) {
            return _myCQ.keepProductStatusCode_InScopeSubQuery_ProductList(subQuery);
        }

        public override String keepProductStatusCode_NotInScopeSubQuery_ProductList(MbProductCQ subQuery) {
            return _myCQ.keepProductStatusCode_NotInScopeSubQuery_ProductList(subQuery);
        }
        public override String keepProductStatusCode_SpecifyDerivedReferrer_ProductList(MbProductCQ subQuery) {
            throw new UnsupportedOperationException("(Specify)DerivedReferrer at inline() is unsupported! Sorry!");
        }
        public override String keepProductStatusCode_QueryDerivedReferrer_ProductList(MbProductCQ subQuery) {
            throw new UnsupportedOperationException("(Query)DerivedReferrer at inline() is unsupported! Sorry!");
        }
        public override String keepProductStatusCode_QueryDerivedReferrer_ProductListParameter(Object parameterValue) {
            throw new UnsupportedOperationException("(Query)DerivedReferrer at inline() is unsupported! Sorry!");
        }

        protected override MbConditionValue getCValueProductStatusName() {
            return _myCQ.ProductStatusName;
        }


        // ===================================================================================
        //                                                                     Scalar SubQuery
        //                                                                     ===============
        public override String keepScalarSubQuery(MbProductStatusCQ subQuery) {
            throw new UnsupportedOperationException("ScalarSubQuery at inline() is unsupported! Sorry!");
        }

        // ===============================================================================
        //                                                         Myself InScope SubQuery
        //                                                         =======================
        public override String keepMyselfInScopeSubQuery(MbProductStatusCQ subQuery) {
            throw new UnsupportedOperationException("MyselfInScopeSubQuery at inline() is unsupported! Sorry!");
        }
    }
}
