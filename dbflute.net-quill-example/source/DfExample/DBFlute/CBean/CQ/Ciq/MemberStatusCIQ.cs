
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
    public class MemberStatusCIQ : AbstractBsMemberStatusCQ {

        // ===============================================================================
        //                                                                       Attribute
        //                                                                       =========
        protected BsMemberStatusCQ _myCQ;

        // ===============================================================================
        //                                                                     Constructor
        //                                                                     ===========
        public MemberStatusCIQ(ConditionQuery childQuery, SqlClause sqlClause, String aliasName, int nestLevel, BsMemberStatusCQ myCQ)
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


        protected override ConditionValue getCValueMemberStatusCode() {
            return _myCQ.MemberStatusCode;
        }


        public override String keepMemberStatusCode_ExistsSubQuery_MemberList(MemberCQ subQuery) {
            throw new SystemException("ExistsSubQuery at inline() is unsupported! Sorry!");
            // _myCQ.keepMemberStatusCode_ExistsSubQuery_MemberList(subQuery);
        }

        public override String keepMemberStatusCode_ExistsSubQuery_MemberLoginList(MemberLoginCQ subQuery) {
            throw new SystemException("ExistsSubQuery at inline() is unsupported! Sorry!");
            // _myCQ.keepMemberStatusCode_ExistsSubQuery_MemberLoginList(subQuery);
        }

        public override String keepMemberStatusCode_NotExistsSubQuery_MemberList(MemberCQ subQuery) {
            throw new SystemException("NotExistsSubQuery at inline() is unsupported! Sorry!");
            // _myCQ.keepMemberStatusCode_NotExistsSubQuery_MemberList(subQuery);
        }

        public override String keepMemberStatusCode_NotExistsSubQuery_MemberLoginList(MemberLoginCQ subQuery) {
            throw new SystemException("NotExistsSubQuery at inline() is unsupported! Sorry!");
            // _myCQ.keepMemberStatusCode_NotExistsSubQuery_MemberLoginList(subQuery);
        }

        public override String keepMemberStatusCode_InScopeSubQuery_MemberList(MemberCQ subQuery) {
            return _myCQ.keepMemberStatusCode_InScopeSubQuery_MemberList(subQuery);
        }

        public override String keepMemberStatusCode_InScopeSubQuery_MemberLoginList(MemberLoginCQ subQuery) {
            return _myCQ.keepMemberStatusCode_InScopeSubQuery_MemberLoginList(subQuery);
        }

        public override String keepMemberStatusCode_NotInScopeSubQuery_MemberList(MemberCQ subQuery) {
            return _myCQ.keepMemberStatusCode_NotInScopeSubQuery_MemberList(subQuery);
        }

        public override String keepMemberStatusCode_NotInScopeSubQuery_MemberLoginList(MemberLoginCQ subQuery) {
            return _myCQ.keepMemberStatusCode_NotInScopeSubQuery_MemberLoginList(subQuery);
        }
        public override String keepMemberStatusCode_SpecifyDerivedReferrer_MemberList(MemberCQ subQuery) {
            throw new UnsupportedOperationException("(Specify)DerivedReferrer at inline() is unsupported! Sorry!");
        }
        public override String keepMemberStatusCode_SpecifyDerivedReferrer_MemberLoginList(MemberLoginCQ subQuery) {
            throw new UnsupportedOperationException("(Specify)DerivedReferrer at inline() is unsupported! Sorry!");
        }
        public override String keepMemberStatusCode_QueryDerivedReferrer_MemberList(MemberCQ subQuery) {
            throw new UnsupportedOperationException("(Query)DerivedReferrer at inline() is unsupported! Sorry!");
        }
        public override String keepMemberStatusCode_QueryDerivedReferrer_MemberListParameter(Object parameterValue) {
            throw new UnsupportedOperationException("(Query)DerivedReferrer at inline() is unsupported! Sorry!");
        }
        public override String keepMemberStatusCode_QueryDerivedReferrer_MemberLoginList(MemberLoginCQ subQuery) {
            throw new UnsupportedOperationException("(Query)DerivedReferrer at inline() is unsupported! Sorry!");
        }
        public override String keepMemberStatusCode_QueryDerivedReferrer_MemberLoginListParameter(Object parameterValue) {
            throw new UnsupportedOperationException("(Query)DerivedReferrer at inline() is unsupported! Sorry!");
        }

        protected override ConditionValue getCValueMemberStatusName() {
            return _myCQ.MemberStatusName;
        }


        protected override ConditionValue getCValueDisplayOrder() {
            return _myCQ.DisplayOrder;
        }


        // ===================================================================================
        //                                                                     Scalar SubQuery
        //                                                                     ===============
        public override String keepScalarSubQuery(MemberStatusCQ subQuery) {
            throw new UnsupportedOperationException("ScalarSubQuery at inline() is unsupported! Sorry!");
        }

        // ===============================================================================
        //                                                         Myself InScope SubQuery
        //                                                         =======================
        public override String keepMyselfInScopeSubQuery(MemberStatusCQ subQuery) {
            throw new UnsupportedOperationException("MyselfInScopeSubQuery at inline() is unsupported! Sorry!");
        }
    }
}
