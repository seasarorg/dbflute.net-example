
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
    public class LdLibraryUserCIQ : LdAbstractBsLibraryUserCQ {

        // ===============================================================================
        //                                                                       Attribute
        //                                                                       =========
        protected LdBsLibraryUserCQ _myCQ;

        // ===============================================================================
        //                                                                     Constructor
        //                                                                     ===========
        public LdLibraryUserCIQ(LdConditionQuery childQuery, LdSqlClause sqlClause, String aliasName, int nestLevel, LdBsLibraryUserCQ myCQ)
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


        protected override LdConditionValue getCValueLibraryId() {
            return _myCQ.LibraryId;
        }


        public override String keepLibraryId_InScopeSubQuery_Library(LdLibraryCQ subQuery) {
            return _myCQ.keepLibraryId_InScopeSubQuery_Library(subQuery);
        }

        public override String keepLibraryId_NotInScopeSubQuery_Library(LdLibraryCQ subQuery) {
            return _myCQ.keepLibraryId_NotInScopeSubQuery_Library(subQuery);
        }

        protected override LdConditionValue getCValueLbUserId() {
            return _myCQ.LbUserId;
        }


        public override String keepLbUserId_InScopeSubQuery_LbUser(LdLbUserCQ subQuery) {
            return _myCQ.keepLbUserId_InScopeSubQuery_LbUser(subQuery);
        }

        public override String keepLbUserId_NotInScopeSubQuery_LbUser(LdLbUserCQ subQuery) {
            return _myCQ.keepLbUserId_NotInScopeSubQuery_LbUser(subQuery);
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

    }
}
