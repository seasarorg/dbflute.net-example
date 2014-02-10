
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
    public class VdSynonymVendorExceptCIQ : AbstractBsVdSynonymVendorExceptCQ {

        // ===============================================================================
        //                                                                       Attribute
        //                                                                       =========
        protected BsVdSynonymVendorExceptCQ _myCQ;

        // ===============================================================================
        //                                                                     Constructor
        //                                                                     ===========
        public VdSynonymVendorExceptCIQ(ConditionQuery childQuery, SqlClause sqlClause, String aliasName, int nestLevel, BsVdSynonymVendorExceptCQ myCQ)
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


        protected override ConditionValue getCValueVendorExceptId() {
            return _myCQ.VendorExceptId;
        }


        public override String keepVendorExceptId_ExistsSubQuery_VdSynonymVendorRefExceptList(VdSynonymVendorRefExceptCQ subQuery) {
            throw new SystemException("ExistsSubQuery at inline() is unsupported! Sorry!");
            // _myCQ.keepVendorExceptId_ExistsSubQuery_VdSynonymVendorRefExceptList(subQuery);
        }

        public override String keepVendorExceptId_NotExistsSubQuery_VdSynonymVendorRefExceptList(VdSynonymVendorRefExceptCQ subQuery) {
            throw new SystemException("NotExistsSubQuery at inline() is unsupported! Sorry!");
            // _myCQ.keepVendorExceptId_NotExistsSubQuery_VdSynonymVendorRefExceptList(subQuery);
        }

        public override String keepVendorExceptId_InScopeSubQuery_VdSynonymVendorRefExceptList(VdSynonymVendorRefExceptCQ subQuery) {
            return _myCQ.keepVendorExceptId_InScopeSubQuery_VdSynonymVendorRefExceptList(subQuery);
        }

        public override String keepVendorExceptId_NotInScopeSubQuery_VdSynonymVendorRefExceptList(VdSynonymVendorRefExceptCQ subQuery) {
            return _myCQ.keepVendorExceptId_NotInScopeSubQuery_VdSynonymVendorRefExceptList(subQuery);
        }
        public override String keepVendorExceptId_SpecifyDerivedReferrer_VdSynonymVendorRefExceptList(VdSynonymVendorRefExceptCQ subQuery) {
            throw new UnsupportedOperationException("(Specify)DerivedReferrer at inline() is unsupported! Sorry!");
        }
        public override String keepVendorExceptId_QueryDerivedReferrer_VdSynonymVendorRefExceptList(VdSynonymVendorRefExceptCQ subQuery) {
            throw new UnsupportedOperationException("(Query)DerivedReferrer at inline() is unsupported! Sorry!");
        }
        public override String keepVendorExceptId_QueryDerivedReferrer_VdSynonymVendorRefExceptListParameter(Object parameterValue) {
            throw new UnsupportedOperationException("(Query)DerivedReferrer at inline() is unsupported! Sorry!");
        }

        protected override ConditionValue getCValueVandorExceptName() {
            return _myCQ.VandorExceptName;
        }


        // ===================================================================================
        //                                                                     Scalar SubQuery
        //                                                                     ===============
        public override String keepScalarSubQuery(VdSynonymVendorExceptCQ subQuery) {
            throw new UnsupportedOperationException("ScalarSubQuery at inline() is unsupported! Sorry!");
        }

        // ===============================================================================
        //                                                         Myself InScope SubQuery
        //                                                         =======================
        public override String keepMyselfInScopeSubQuery(VdSynonymVendorExceptCQ subQuery) {
            throw new UnsupportedOperationException("MyselfInScopeSubQuery at inline() is unsupported! Sorry!");
        }
    }
}
