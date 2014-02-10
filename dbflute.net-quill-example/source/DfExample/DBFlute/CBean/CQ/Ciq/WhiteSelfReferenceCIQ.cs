
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
    public class WhiteSelfReferenceCIQ : AbstractBsWhiteSelfReferenceCQ {

        // ===============================================================================
        //                                                                       Attribute
        //                                                                       =========
        protected BsWhiteSelfReferenceCQ _myCQ;

        // ===============================================================================
        //                                                                     Constructor
        //                                                                     ===========
        public WhiteSelfReferenceCIQ(ConditionQuery childQuery, SqlClause sqlClause, String aliasName, int nestLevel, BsWhiteSelfReferenceCQ myCQ)
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


        protected override ConditionValue getCValueSelfReferenceId() {
            return _myCQ.SelfReferenceId;
        }


        public override String keepSelfReferenceId_ExistsSubQuery_WhiteSelfReferenceSelfList(WhiteSelfReferenceCQ subQuery) {
            throw new SystemException("ExistsSubQuery at inline() is unsupported! Sorry!");
            // _myCQ.keepSelfReferenceId_ExistsSubQuery_WhiteSelfReferenceSelfList(subQuery);
        }

        public override String keepSelfReferenceId_NotExistsSubQuery_WhiteSelfReferenceSelfList(WhiteSelfReferenceCQ subQuery) {
            throw new SystemException("NotExistsSubQuery at inline() is unsupported! Sorry!");
            // _myCQ.keepSelfReferenceId_NotExistsSubQuery_WhiteSelfReferenceSelfList(subQuery);
        }

        public override String keepSelfReferenceId_InScopeSubQuery_WhiteSelfReferenceSelfList(WhiteSelfReferenceCQ subQuery) {
            return _myCQ.keepSelfReferenceId_InScopeSubQuery_WhiteSelfReferenceSelfList(subQuery);
        }

        public override String keepSelfReferenceId_NotInScopeSubQuery_WhiteSelfReferenceSelfList(WhiteSelfReferenceCQ subQuery) {
            return _myCQ.keepSelfReferenceId_NotInScopeSubQuery_WhiteSelfReferenceSelfList(subQuery);
        }
        public override String keepSelfReferenceId_SpecifyDerivedReferrer_WhiteSelfReferenceSelfList(WhiteSelfReferenceCQ subQuery) {
            throw new UnsupportedOperationException("(Specify)DerivedReferrer at inline() is unsupported! Sorry!");
        }
        public override String keepSelfReferenceId_QueryDerivedReferrer_WhiteSelfReferenceSelfList(WhiteSelfReferenceCQ subQuery) {
            throw new UnsupportedOperationException("(Query)DerivedReferrer at inline() is unsupported! Sorry!");
        }
        public override String keepSelfReferenceId_QueryDerivedReferrer_WhiteSelfReferenceSelfListParameter(Object parameterValue) {
            throw new UnsupportedOperationException("(Query)DerivedReferrer at inline() is unsupported! Sorry!");
        }

        protected override ConditionValue getCValueSelfReferenceName() {
            return _myCQ.SelfReferenceName;
        }


        protected override ConditionValue getCValueParentId() {
            return _myCQ.ParentId;
        }


        public override String keepParentId_InScopeSubQuery_WhiteSelfReferenceSelf(WhiteSelfReferenceCQ subQuery) {
            return _myCQ.keepParentId_InScopeSubQuery_WhiteSelfReferenceSelf(subQuery);
        }

        public override String keepParentId_NotInScopeSubQuery_WhiteSelfReferenceSelf(WhiteSelfReferenceCQ subQuery) {
            return _myCQ.keepParentId_NotInScopeSubQuery_WhiteSelfReferenceSelf(subQuery);
        }

        // ===================================================================================
        //                                                                     Scalar SubQuery
        //                                                                     ===============
        public override String keepScalarSubQuery(WhiteSelfReferenceCQ subQuery) {
            throw new UnsupportedOperationException("ScalarSubQuery at inline() is unsupported! Sorry!");
        }

        // ===============================================================================
        //                                                         Myself InScope SubQuery
        //                                                         =======================
        public override String keepMyselfInScopeSubQuery(WhiteSelfReferenceCQ subQuery) {
            throw new UnsupportedOperationException("MyselfInScopeSubQuery at inline() is unsupported! Sorry!");
        }
    }
}
