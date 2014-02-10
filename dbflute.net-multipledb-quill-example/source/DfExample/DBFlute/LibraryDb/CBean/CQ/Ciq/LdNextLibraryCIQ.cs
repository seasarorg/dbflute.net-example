
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
    public class LdNextLibraryCIQ : LdAbstractBsNextLibraryCQ {

        // ===============================================================================
        //                                                                       Attribute
        //                                                                       =========
        protected LdBsNextLibraryCQ _myCQ;

        // ===============================================================================
        //                                                                     Constructor
        //                                                                     ===========
        public LdNextLibraryCIQ(LdConditionQuery childQuery, LdSqlClause sqlClause, String aliasName, int nestLevel, LdBsNextLibraryCQ myCQ)
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


        public override String keepLibraryId_InScopeSubQuery_LibraryByLibraryId(LdLibraryCQ subQuery) {
            return _myCQ.keepLibraryId_InScopeSubQuery_LibraryByLibraryId(subQuery);
        }

        public override String keepLibraryId_NotInScopeSubQuery_LibraryByLibraryId(LdLibraryCQ subQuery) {
            return _myCQ.keepLibraryId_NotInScopeSubQuery_LibraryByLibraryId(subQuery);
        }

        protected override LdConditionValue getCValueNextLibraryId() {
            return _myCQ.NextLibraryId;
        }


        public override String keepNextLibraryId_InScopeSubQuery_LibraryByNextLibraryId(LdLibraryCQ subQuery) {
            return _myCQ.keepNextLibraryId_InScopeSubQuery_LibraryByNextLibraryId(subQuery);
        }

        public override String keepNextLibraryId_NotInScopeSubQuery_LibraryByNextLibraryId(LdLibraryCQ subQuery) {
            return _myCQ.keepNextLibraryId_NotInScopeSubQuery_LibraryByNextLibraryId(subQuery);
        }

        protected override LdConditionValue getCValueDistanceKm() {
            return _myCQ.DistanceKm;
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
