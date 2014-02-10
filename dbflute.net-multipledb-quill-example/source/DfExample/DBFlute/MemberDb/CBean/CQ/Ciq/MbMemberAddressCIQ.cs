
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
    public class MbMemberAddressCIQ : MbAbstractBsMemberAddressCQ {

        // ===============================================================================
        //                                                                       Attribute
        //                                                                       =========
        protected MbBsMemberAddressCQ _myCQ;

        // ===============================================================================
        //                                                                     Constructor
        //                                                                     ===========
        public MbMemberAddressCIQ(MbConditionQuery childQuery, MbSqlClause sqlClause, String aliasName, int nestLevel, MbBsMemberAddressCQ myCQ)
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


        protected override MbConditionValue getCValueMemberAddressId() {
            return _myCQ.MemberAddressId;
        }


        protected override MbConditionValue getCValueMemberId() {
            return _myCQ.MemberId;
        }


        public override String keepMemberId_InScopeSubQuery_Member(MbMemberCQ subQuery) {
            return _myCQ.keepMemberId_InScopeSubQuery_Member(subQuery);
        }

        public override String keepMemberId_NotInScopeSubQuery_Member(MbMemberCQ subQuery) {
            return _myCQ.keepMemberId_NotInScopeSubQuery_Member(subQuery);
        }

        protected override MbConditionValue getCValueValidBeginDate() {
            return _myCQ.ValidBeginDate;
        }


        protected override MbConditionValue getCValueValidEndDate() {
            return _myCQ.ValidEndDate;
        }


        protected override MbConditionValue getCValueAddress() {
            return _myCQ.Address;
        }


        protected override MbConditionValue getCValueRegisterDatetime() {
            return _myCQ.RegisterDatetime;
        }


        protected override MbConditionValue getCValueRegisterProcess() {
            return _myCQ.RegisterProcess;
        }


        protected override MbConditionValue getCValueRegisterUser() {
            return _myCQ.RegisterUser;
        }


        protected override MbConditionValue getCValueUpdateDatetime() {
            return _myCQ.UpdateDatetime;
        }


        protected override MbConditionValue getCValueUpdateProcess() {
            return _myCQ.UpdateProcess;
        }


        protected override MbConditionValue getCValueUpdateUser() {
            return _myCQ.UpdateUser;
        }


        protected override MbConditionValue getCValueVersionNo() {
            return _myCQ.VersionNo;
        }


        // ===================================================================================
        //                                                                     Scalar SubQuery
        //                                                                     ===============
        public override String keepScalarSubQuery(MbMemberAddressCQ subQuery) {
            throw new UnsupportedOperationException("ScalarSubQuery at inline() is unsupported! Sorry!");
        }

        // ===============================================================================
        //                                                         Myself InScope SubQuery
        //                                                         =======================
        public override String keepMyselfInScopeSubQuery(MbMemberAddressCQ subQuery) {
            throw new UnsupportedOperationException("MyselfInScopeSubQuery at inline() is unsupported! Sorry!");
        }
    }
}
