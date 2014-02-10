
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
    public class MbProductCIQ : MbAbstractBsProductCQ {

        // ===============================================================================
        //                                                                       Attribute
        //                                                                       =========
        protected MbBsProductCQ _myCQ;

        // ===============================================================================
        //                                                                     Constructor
        //                                                                     ===========
        public MbProductCIQ(MbConditionQuery childQuery, MbSqlClause sqlClause, String aliasName, int nestLevel, MbBsProductCQ myCQ)
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


        protected override MbConditionValue getCValueProductId() {
            return _myCQ.ProductId;
        }


        public override String keepProductId_ExistsSubQuery_PurchaseList(MbPurchaseCQ subQuery) {
            throw new SystemException("ExistsSubQuery at inline() is unsupported! Sorry!");
            // _myCQ.keepProductId_ExistsSubQuery_PurchaseList(subQuery);
        }

        public override String keepProductId_NotExistsSubQuery_PurchaseList(MbPurchaseCQ subQuery) {
            throw new SystemException("NotExistsSubQuery at inline() is unsupported! Sorry!");
            // _myCQ.keepProductId_NotExistsSubQuery_PurchaseList(subQuery);
        }

        public override String keepProductId_InScopeSubQuery_PurchaseList(MbPurchaseCQ subQuery) {
            return _myCQ.keepProductId_InScopeSubQuery_PurchaseList(subQuery);
        }

        public override String keepProductId_NotInScopeSubQuery_PurchaseList(MbPurchaseCQ subQuery) {
            return _myCQ.keepProductId_NotInScopeSubQuery_PurchaseList(subQuery);
        }
        public override String keepProductId_SpecifyDerivedReferrer_PurchaseList(MbPurchaseCQ subQuery) {
            throw new UnsupportedOperationException("(Specify)DerivedReferrer at inline() is unsupported! Sorry!");
        }
        public override String keepProductId_QueryDerivedReferrer_PurchaseList(MbPurchaseCQ subQuery) {
            throw new UnsupportedOperationException("(Query)DerivedReferrer at inline() is unsupported! Sorry!");
        }
        public override String keepProductId_QueryDerivedReferrer_PurchaseListParameter(Object parameterValue) {
            throw new UnsupportedOperationException("(Query)DerivedReferrer at inline() is unsupported! Sorry!");
        }

        protected override MbConditionValue getCValueProductName() {
            return _myCQ.ProductName;
        }


        protected override MbConditionValue getCValueProductHandleCode() {
            return _myCQ.ProductHandleCode;
        }


        protected override MbConditionValue getCValueProductStatusCode() {
            return _myCQ.ProductStatusCode;
        }


        public override String keepProductStatusCode_InScopeSubQuery_ProductStatus(MbProductStatusCQ subQuery) {
            return _myCQ.keepProductStatusCode_InScopeSubQuery_ProductStatus(subQuery);
        }

        public override String keepProductStatusCode_NotInScopeSubQuery_ProductStatus(MbProductStatusCQ subQuery) {
            return _myCQ.keepProductStatusCode_NotInScopeSubQuery_ProductStatus(subQuery);
        }

        protected override MbConditionValue getCValueRegisterDatetime() {
            return _myCQ.RegisterDatetime;
        }


        protected override MbConditionValue getCValueRegisterUser() {
            return _myCQ.RegisterUser;
        }


        protected override MbConditionValue getCValueRegisterProcess() {
            return _myCQ.RegisterProcess;
        }


        protected override MbConditionValue getCValueUpdateDatetime() {
            return _myCQ.UpdateDatetime;
        }


        protected override MbConditionValue getCValueUpdateUser() {
            return _myCQ.UpdateUser;
        }


        protected override MbConditionValue getCValueUpdateProcess() {
            return _myCQ.UpdateProcess;
        }


        protected override MbConditionValue getCValueVersionNo() {
            return _myCQ.VersionNo;
        }


        // ===================================================================================
        //                                                                     Scalar SubQuery
        //                                                                     ===============
        public override String keepScalarSubQuery(MbProductCQ subQuery) {
            throw new UnsupportedOperationException("ScalarSubQuery at inline() is unsupported! Sorry!");
        }

        // ===============================================================================
        //                                                         Myself InScope SubQuery
        //                                                         =======================
        public override String keepMyselfInScopeSubQuery(MbProductCQ subQuery) {
            throw new UnsupportedOperationException("MyselfInScopeSubQuery at inline() is unsupported! Sorry!");
        }
    }
}
