
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
    public class WhitePgReservCIQ : AbstractBsWhitePgReservCQ {

        // ===============================================================================
        //                                                                       Attribute
        //                                                                       =========
        protected BsWhitePgReservCQ _myCQ;

        // ===============================================================================
        //                                                                     Constructor
        //                                                                     ===========
        public WhitePgReservCIQ(ConditionQuery childQuery, SqlClause sqlClause, String aliasName, int nestLevel, BsWhitePgReservCQ myCQ)
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


        protected override ConditionValue getCValueClassSynonym() {
            return _myCQ.ClassSynonym;
        }


        public override String keepClassSynonym_ExistsSubQuery_WhitePgReservRefList(WhitePgReservRefCQ subQuery) {
            throw new SystemException("ExistsSubQuery at inline() is unsupported! Sorry!");
            // _myCQ.keepClassSynonym_ExistsSubQuery_WhitePgReservRefList(subQuery);
        }

        public override String keepClassSynonym_NotExistsSubQuery_WhitePgReservRefList(WhitePgReservRefCQ subQuery) {
            throw new SystemException("NotExistsSubQuery at inline() is unsupported! Sorry!");
            // _myCQ.keepClassSynonym_NotExistsSubQuery_WhitePgReservRefList(subQuery);
        }

        public override String keepClassSynonym_InScopeSubQuery_WhitePgReservRefList(WhitePgReservRefCQ subQuery) {
            return _myCQ.keepClassSynonym_InScopeSubQuery_WhitePgReservRefList(subQuery);
        }

        public override String keepClassSynonym_NotInScopeSubQuery_WhitePgReservRefList(WhitePgReservRefCQ subQuery) {
            return _myCQ.keepClassSynonym_NotInScopeSubQuery_WhitePgReservRefList(subQuery);
        }
        public override String keepClassSynonym_SpecifyDerivedReferrer_WhitePgReservRefList(WhitePgReservRefCQ subQuery) {
            throw new UnsupportedOperationException("(Specify)DerivedReferrer at inline() is unsupported! Sorry!");
        }
        public override String keepClassSynonym_QueryDerivedReferrer_WhitePgReservRefList(WhitePgReservRefCQ subQuery) {
            throw new UnsupportedOperationException("(Query)DerivedReferrer at inline() is unsupported! Sorry!");
        }
        public override String keepClassSynonym_QueryDerivedReferrer_WhitePgReservRefListParameter(Object parameterValue) {
            throw new UnsupportedOperationException("(Query)DerivedReferrer at inline() is unsupported! Sorry!");
        }

        protected override ConditionValue getCValueCase() {
            return _myCQ.Case;
        }


        protected override ConditionValue getCValuePackage() {
            return _myCQ.Package;
        }


        protected override ConditionValue getCValueDefault() {
            return _myCQ.Default;
        }


        protected override ConditionValue getCValueNew() {
            return _myCQ.New;
        }


        protected override ConditionValue getCValueNative() {
            return _myCQ.Native;
        }


        protected override ConditionValue getCValueVoid() {
            return _myCQ.Void;
        }


        protected override ConditionValue getCValuePublic() {
            return _myCQ.Public;
        }


        protected override ConditionValue getCValueProtected() {
            return _myCQ.Protected;
        }


        protected override ConditionValue getCValuePrivate() {
            return _myCQ.Private;
        }


        protected override ConditionValue getCValueInterface() {
            return _myCQ.Interface;
        }


        protected override ConditionValue getCValueAbstract() {
            return _myCQ.Abstract;
        }


        protected override ConditionValue getCValueFinal() {
            return _myCQ.Final;
        }


        protected override ConditionValue getCValueFinally() {
            return _myCQ.Finally;
        }


        protected override ConditionValue getCValueReturn() {
            return _myCQ.Return;
        }


        protected override ConditionValue getCValueDouble() {
            return _myCQ.Double;
        }


        protected override ConditionValue getCValueFloat() {
            return _myCQ.Float;
        }


        protected override ConditionValue getCValueShort() {
            return _myCQ.Short;
        }


        protected override ConditionValue getCValueType() {
            return _myCQ.Type;
        }


        protected override ConditionValue getCValueReservName() {
            return _myCQ.ReservName;
        }


        // ===================================================================================
        //                                                                     Scalar SubQuery
        //                                                                     ===============
        public override String keepScalarSubQuery(WhitePgReservCQ subQuery) {
            throw new UnsupportedOperationException("ScalarSubQuery at inline() is unsupported! Sorry!");
        }

        // ===============================================================================
        //                                                         Myself InScope SubQuery
        //                                                         =======================
        public override String keepMyselfInScopeSubQuery(WhitePgReservCQ subQuery) {
            throw new UnsupportedOperationException("MyselfInScopeSubQuery at inline() is unsupported! Sorry!");
        }
    }
}
