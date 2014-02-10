
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
    public class PurchaseCIQ : AbstractBsPurchaseCQ {

        // ===============================================================================
        //                                                                       Attribute
        //                                                                       =========
        protected BsPurchaseCQ _myCQ;

        // ===============================================================================
        //                                                                     Constructor
        //                                                                     ===========
        public PurchaseCIQ(ConditionQuery childQuery, SqlClause sqlClause, String aliasName, int nestLevel, BsPurchaseCQ myCQ)
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


        protected override ConditionValue getCValuePurchaseId() {
            return _myCQ.PurchaseId;
        }


        protected override ConditionValue getCValueMemberId() {
            return _myCQ.MemberId;
        }


        public override String keepMemberId_InScopeSubQuery_Member(MemberCQ subQuery) {
            return _myCQ.keepMemberId_InScopeSubQuery_Member(subQuery);
        }

        public override String keepMemberId_NotInScopeSubQuery_Member(MemberCQ subQuery) {
            return _myCQ.keepMemberId_NotInScopeSubQuery_Member(subQuery);
        }

        protected override ConditionValue getCValueProductId() {
            return _myCQ.ProductId;
        }


        public override String keepProductId_InScopeSubQuery_Product(ProductCQ subQuery) {
            return _myCQ.keepProductId_InScopeSubQuery_Product(subQuery);
        }

        public override String keepProductId_NotInScopeSubQuery_Product(ProductCQ subQuery) {
            return _myCQ.keepProductId_NotInScopeSubQuery_Product(subQuery);
        }

        protected override ConditionValue getCValuePurchaseDatetime() {
            return _myCQ.PurchaseDatetime;
        }


        protected override ConditionValue getCValuePurchaseCount() {
            return _myCQ.PurchaseCount;
        }


        protected override ConditionValue getCValuePurchasePrice() {
            return _myCQ.PurchasePrice;
        }


        protected override ConditionValue getCValuePaymentCompleteFlg() {
            return _myCQ.PaymentCompleteFlg;
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
        public override String keepScalarSubQuery(PurchaseCQ subQuery) {
            throw new UnsupportedOperationException("ScalarSubQuery at inline() is unsupported! Sorry!");
        }

        // ===============================================================================
        //                                                         Myself InScope SubQuery
        //                                                         =======================
        public override String keepMyselfInScopeSubQuery(PurchaseCQ subQuery) {
            throw new UnsupportedOperationException("MyselfInScopeSubQuery at inline() is unsupported! Sorry!");
        }
    }
}
