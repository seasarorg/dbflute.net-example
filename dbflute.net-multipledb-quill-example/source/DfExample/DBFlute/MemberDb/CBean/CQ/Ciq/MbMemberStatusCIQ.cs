
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
    public class MbMemberStatusCIQ : MbAbstractBsMemberStatusCQ {

        // ===============================================================================
        //                                                                       Attribute
        //                                                                       =========
        protected MbBsMemberStatusCQ _myCQ;

        // ===============================================================================
        //                                                                     Constructor
        //                                                                     ===========
        public MbMemberStatusCIQ(MbConditionQuery childQuery, MbSqlClause sqlClause, String aliasName, int nestLevel, MbBsMemberStatusCQ myCQ)
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


        protected override MbConditionValue getCValueMemberStatusCode() {
            return _myCQ.MemberStatusCode;
        }


        public override String keepMemberStatusCode_ExistsSubQuery_MemberList(MbMemberCQ subQuery) {
            throw new SystemException("ExistsSubQuery at inline() is unsupported! Sorry!");
            // _myCQ.keepMemberStatusCode_ExistsSubQuery_MemberList(subQuery);
        }

        public override String keepMemberStatusCode_ExistsSubQuery_MemberLoginList(MbMemberLoginCQ subQuery) {
            throw new SystemException("ExistsSubQuery at inline() is unsupported! Sorry!");
            // _myCQ.keepMemberStatusCode_ExistsSubQuery_MemberLoginList(subQuery);
        }

        public override String keepMemberStatusCode_NotExistsSubQuery_MemberList(MbMemberCQ subQuery) {
            throw new SystemException("NotExistsSubQuery at inline() is unsupported! Sorry!");
            // _myCQ.keepMemberStatusCode_NotExistsSubQuery_MemberList(subQuery);
        }

        public override String keepMemberStatusCode_NotExistsSubQuery_MemberLoginList(MbMemberLoginCQ subQuery) {
            throw new SystemException("NotExistsSubQuery at inline() is unsupported! Sorry!");
            // _myCQ.keepMemberStatusCode_NotExistsSubQuery_MemberLoginList(subQuery);
        }

        public override String keepMemberStatusCode_InScopeSubQuery_MemberList(MbMemberCQ subQuery) {
            return _myCQ.keepMemberStatusCode_InScopeSubQuery_MemberList(subQuery);
        }

        public override String keepMemberStatusCode_InScopeSubQuery_MemberLoginList(MbMemberLoginCQ subQuery) {
            return _myCQ.keepMemberStatusCode_InScopeSubQuery_MemberLoginList(subQuery);
        }

        public override String keepMemberStatusCode_NotInScopeSubQuery_MemberList(MbMemberCQ subQuery) {
            return _myCQ.keepMemberStatusCode_NotInScopeSubQuery_MemberList(subQuery);
        }

        public override String keepMemberStatusCode_NotInScopeSubQuery_MemberLoginList(MbMemberLoginCQ subQuery) {
            return _myCQ.keepMemberStatusCode_NotInScopeSubQuery_MemberLoginList(subQuery);
        }
        public override String keepMemberStatusCode_SpecifyDerivedReferrer_MemberList(MbMemberCQ subQuery) {
            throw new UnsupportedOperationException("(Specify)DerivedReferrer at inline() is unsupported! Sorry!");
        }
        public override String keepMemberStatusCode_SpecifyDerivedReferrer_MemberLoginList(MbMemberLoginCQ subQuery) {
            throw new UnsupportedOperationException("(Specify)DerivedReferrer at inline() is unsupported! Sorry!");
        }
        public override String keepMemberStatusCode_QueryDerivedReferrer_MemberList(MbMemberCQ subQuery) {
            throw new UnsupportedOperationException("(Query)DerivedReferrer at inline() is unsupported! Sorry!");
        }
        public override String keepMemberStatusCode_QueryDerivedReferrer_MemberListParameter(Object parameterValue) {
            throw new UnsupportedOperationException("(Query)DerivedReferrer at inline() is unsupported! Sorry!");
        }
        public override String keepMemberStatusCode_QueryDerivedReferrer_MemberLoginList(MbMemberLoginCQ subQuery) {
            throw new UnsupportedOperationException("(Query)DerivedReferrer at inline() is unsupported! Sorry!");
        }
        public override String keepMemberStatusCode_QueryDerivedReferrer_MemberLoginListParameter(Object parameterValue) {
            throw new UnsupportedOperationException("(Query)DerivedReferrer at inline() is unsupported! Sorry!");
        }

        protected override MbConditionValue getCValueMemberStatusName() {
            return _myCQ.MemberStatusName;
        }


        protected override MbConditionValue getCValueDisplayOrder() {
            return _myCQ.DisplayOrder;
        }


        // ===================================================================================
        //                                                                     Scalar SubQuery
        //                                                                     ===============
        public override String keepScalarSubQuery(MbMemberStatusCQ subQuery) {
            throw new UnsupportedOperationException("ScalarSubQuery at inline() is unsupported! Sorry!");
        }

        // ===============================================================================
        //                                                         Myself InScope SubQuery
        //                                                         =======================
        public override String keepMyselfInScopeSubQuery(MbMemberStatusCQ subQuery) {
            throw new UnsupportedOperationException("MyselfInScopeSubQuery at inline() is unsupported! Sorry!");
        }
    }
}
