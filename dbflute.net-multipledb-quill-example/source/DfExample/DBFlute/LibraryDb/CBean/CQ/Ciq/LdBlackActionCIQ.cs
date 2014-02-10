
using System;

using DfExample.DBFlute.LibraryDb.AllCommon.CBean;
using DfExample.DBFlute.LibraryDb.AllCommon.CBean.CKey;
using DfExample.DBFlute.LibraryDb.AllCommon.CBean.COption;
using DfExample.DBFlute.LibraryDb.AllCommon.CBean.CValue;
using DfExample.DBFlute.LibraryDb.AllCommon.CBean.SClause;
using DfExample.DBFlute.LibraryDb.AllCommon.JavaLike;
using DfExample.DBFlute.LibraryDb.CBean.CQ.BS;
using DfExample.DBFlute.LibraryDb.CBean.CQ;

namespace DfExample.DBFlute.LibraryDb.CBean.CQ.Ciq {

    [System.Serializable]
    public class LdBlackActionCIQ : LdAbstractBsBlackActionCQ {

        // ===============================================================================
        //                                                                       Attribute
        //                                                                       =========
        protected LdBsBlackActionCQ _myCQ;

        // ===============================================================================
        //                                                                     Constructor
        //                                                                     ===========
        public LdBlackActionCIQ(LdConditionQuery childQuery, LdSqlClause sqlClause, String aliasName, int nestLevel, LdBsBlackActionCQ myCQ)
            : base(childQuery, sqlClause, aliasName, nestLevel) {
            _myCQ = myCQ;
            _foreignPropertyName = _myCQ.xgetForeignPropertyName();// Accept foreign property name.
            _relationPath = _myCQ.xgetRelationPath();// Accept relation path.
        }

        // ===================================================================================
        //                                                             Override about Register
        //                                                             =======================
        public override void reflectRelationOnUnionQuery(LdConditionQuery baseQueryAsSuper, LdConditionQuery unionQueryAsSuper) {
            throw new UnsupportedOperationException("InlineQuery must not need UNION method: " + baseQueryAsSuper + " : " + unionQueryAsSuper);
        }
    
        protected override void setupConditionValueAndRegisterWhereClause(LdConditionKey key, Object value, LdConditionValue cvalue, String colName) {
            regIQ(key, value, cvalue, colName);
        }
    
        protected override void setupConditionValueAndRegisterWhereClause(LdConditionKey key, Object value, LdConditionValue cvalue
                                                                        , String colName, LdConditionOption option) {
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
    
        protected override void registerExistsSubQuery(LdConditionQuery subQuery
                                     , String columnName, String relatedColumnName, String propertyName) {
            throw new UnsupportedOperationException("Sorry! ExistsSubQuery at inline view is unsupported. So please use InScopeSubQyery.");
        }


        protected override LdConditionValue getCValueBlackActionId() {
            return _myCQ.BlackActionId;
        }


        protected override LdConditionValue getCValueBlackListId() {
            return _myCQ.BlackListId;
        }


        public override String keepBlackListId_InScopeSubQuery_BlackList(LdBlackListCQ subQuery) {
            return _myCQ.keepBlackListId_InScopeSubQuery_BlackList(subQuery);
        }

        public override String keepBlackListId_NotInScopeSubQuery_BlackList(LdBlackListCQ subQuery) {
            return _myCQ.keepBlackListId_NotInScopeSubQuery_BlackList(subQuery);
        }

        protected override LdConditionValue getCValueBlackActionCode() {
            return _myCQ.BlackActionCode;
        }


        public override String keepBlackActionCode_InScopeSubQuery_BlackActionLookup(LdBlackActionLookupCQ subQuery) {
            return _myCQ.keepBlackActionCode_InScopeSubQuery_BlackActionLookup(subQuery);
        }

        public override String keepBlackActionCode_NotInScopeSubQuery_BlackActionLookup(LdBlackActionLookupCQ subQuery) {
            return _myCQ.keepBlackActionCode_NotInScopeSubQuery_BlackActionLookup(subQuery);
        }

        protected override LdConditionValue getCValueBlackLevel() {
            return _myCQ.BlackLevel;
        }


        protected override LdConditionValue getCValueActionDate() {
            return _myCQ.ActionDate;
        }


        protected override LdConditionValue getCValueEvidencePhotograph() {
            return _myCQ.EvidencePhotograph;
        }


        protected override LdConditionValue getCValueRUser() {
            return _myCQ.RUser;
        }


        protected override LdConditionValue getCValueRModule() {
            return _myCQ.RModule;
        }


        protected override LdConditionValue getCValueRTimestamp() {
            return _myCQ.RTimestamp;
        }


        protected override LdConditionValue getCValueUUser() {
            return _myCQ.UUser;
        }


        protected override LdConditionValue getCValueUModule() {
            return _myCQ.UModule;
        }


        protected override LdConditionValue getCValueUTimestamp() {
            return _myCQ.UTimestamp;
        }


        // ===================================================================================
        //                                                                     Scalar SubQuery
        //                                                                     ===============
        public override String keepScalarSubQuery(LdBlackActionCQ subQuery) {
            throw new UnsupportedOperationException("ScalarSubQuery at inline() is unsupported! Sorry!");
        }

        // ===============================================================================
        //                                                         Myself InScope SubQuery
        //                                                         =======================
        public override String keepMyselfInScopeSubQuery(LdBlackActionCQ subQuery) {
            throw new UnsupportedOperationException("MyselfInScopeSubQuery at inline() is unsupported! Sorry!");
        }
    }
}
