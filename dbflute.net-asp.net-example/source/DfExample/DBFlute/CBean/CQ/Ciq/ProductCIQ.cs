
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
    public class ProductCIQ : AbstractBsProductCQ {

        // ===============================================================================
        //                                                                       Attribute
        //                                                                       =========
        protected BsProductCQ _myCQ;

        // ===============================================================================
        //                                                                     Constructor
        //                                                                     ===========
        public ProductCIQ(ConditionQuery childQuery, SqlClause sqlClause, String aliasName, int nestLevel, BsProductCQ myCQ)
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


        protected override ConditionValue getCValueProductId() {
            return _myCQ.ProductId;
        }


        public override String keepProductId_ExistsSubQuery_PurchaseList(PurchaseCQ subQuery) {
            throw new SystemException("ExistsSubQuery at inline() is unsupported! Sorry!");
            // _myCQ.keepProductId_ExistsSubQuery_PurchaseList(subQuery);
        }

        public override String keepProductId_NotExistsSubQuery_PurchaseList(PurchaseCQ subQuery) {
            throw new SystemException("NotExistsSubQuery at inline() is unsupported! Sorry!");
            // _myCQ.keepProductId_NotExistsSubQuery_PurchaseList(subQuery);
        }

        public override String keepProductId_InScopeSubQuery_PurchaseList(PurchaseCQ subQuery) {
            return _myCQ.keepProductId_InScopeSubQuery_PurchaseList(subQuery);
        }

        public override String keepProductId_NotInScopeSubQuery_PurchaseList(PurchaseCQ subQuery) {
            return _myCQ.keepProductId_NotInScopeSubQuery_PurchaseList(subQuery);
        }
        public override String keepProductId_SpecifyDerivedReferrer_PurchaseList(PurchaseCQ subQuery) {
            throw new UnsupportedOperationException("(Specify)DerivedReferrer at inline() is unsupported! Sorry!");
        }
        public override String keepProductId_QueryDerivedReferrer_PurchaseList(PurchaseCQ subQuery) {
            throw new UnsupportedOperationException("(Query)DerivedReferrer at inline() is unsupported! Sorry!");
        }
        public override String keepProductId_QueryDerivedReferrer_PurchaseListParameter(Object parameterValue) {
            throw new UnsupportedOperationException("(Query)DerivedReferrer at inline() is unsupported! Sorry!");
        }

        protected override ConditionValue getCValueProductName() {
            return _myCQ.ProductName;
        }


        protected override ConditionValue getCValueProductHandleCode() {
            return _myCQ.ProductHandleCode;
        }


        protected override ConditionValue getCValueProductStatusCode() {
            return _myCQ.ProductStatusCode;
        }


        public override String keepProductStatusCode_InScopeSubQuery_ProductStatus(ProductStatusCQ subQuery) {
            return _myCQ.keepProductStatusCode_InScopeSubQuery_ProductStatus(subQuery);
        }

        public override String keepProductStatusCode_NotInScopeSubQuery_ProductStatus(ProductStatusCQ subQuery) {
            return _myCQ.keepProductStatusCode_NotInScopeSubQuery_ProductStatus(subQuery);
        }

        protected override ConditionValue getCValueRegisterDatetime() {
            return _myCQ.RegisterDatetime;
        }


        protected override ConditionValue getCValueRegisterUser() {
            return _myCQ.RegisterUser;
        }


        protected override ConditionValue getCValueRegisterProcess() {
            return _myCQ.RegisterProcess;
        }


        protected override ConditionValue getCValueUpdateDatetime() {
            return _myCQ.UpdateDatetime;
        }


        protected override ConditionValue getCValueUpdateUser() {
            return _myCQ.UpdateUser;
        }


        protected override ConditionValue getCValueUpdateProcess() {
            return _myCQ.UpdateProcess;
        }


        protected override ConditionValue getCValueVersionNo() {
            return _myCQ.VersionNo;
        }


        // ===================================================================================
        //                                                                     Scalar SubQuery
        //                                                                     ===============
        public override String keepScalarSubQuery(ProductCQ subQuery) {
            throw new UnsupportedOperationException("ScalarSubQuery at inline() is unsupported! Sorry!");
        }

        // ===============================================================================
        //                                                         Myself InScope SubQuery
        //                                                         =======================
        public override String keepMyselfInScopeSubQuery(ProductCQ subQuery) {
            throw new UnsupportedOperationException("MyselfInScopeSubQuery at inline() is unsupported! Sorry!");
        }
    }
}
