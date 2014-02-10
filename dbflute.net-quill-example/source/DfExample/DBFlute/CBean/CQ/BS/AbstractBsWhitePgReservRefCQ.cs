
using System;
using System.Collections.Generic;

using DfExample.DBFlute.AllCommon;
using DfExample.DBFlute.AllCommon.CBean;
using DfExample.DBFlute.AllCommon.CBean.CKey;
using DfExample.DBFlute.AllCommon.CBean.COption;
using DfExample.DBFlute.AllCommon.CBean.CValue;
using DfExample.DBFlute.AllCommon.CBean.SClause;

namespace DfExample.DBFlute.CBean.CQ.BS {

    [System.Serializable]
    public abstract class AbstractBsWhitePgReservRefCQ : AbstractConditionQuery {

        public AbstractBsWhitePgReservRefCQ(ConditionQuery childQuery, SqlClause sqlClause, String aliasName, int nestLevel)
            : base(childQuery, sqlClause, aliasName, nestLevel) {}

        public override String getTableDbName() { return "white_pg_reserv_ref"; }
        public override String getTableSqlName() { return "white_pg_reserv_ref"; }

        public void SetRefId_Equal(int? v) { regRefId(CK_EQ, v); }
        public void SetRefId_NotEqual(int? v) { regRefId(CK_NES, v); }
        public void SetRefId_GreaterThan(int? v) { regRefId(CK_GT, v); }
        public void SetRefId_LessThan(int? v) { regRefId(CK_LT, v); }
        public void SetRefId_GreaterEqual(int? v) { regRefId(CK_GE, v); }
        public void SetRefId_LessEqual(int? v) { regRefId(CK_LE, v); }
        public void SetRefId_InScope(IList<int?> ls) { regINS<int?>(CK_INS, cTL<int?>(ls), getCValueRefId(), "REF_ID"); }
        public void SetRefId_NotInScope(IList<int?> ls) { regINS<int?>(CK_NINS, cTL<int?>(ls), getCValueRefId(), "REF_ID"); }
        public void SetRefId_IsNull() { regRefId(CK_ISN, DUMMY_OBJECT); }
        public void SetRefId_IsNotNull() { regRefId(CK_ISNN, DUMMY_OBJECT); }
        protected void regRefId(ConditionKey k, Object v) { regQ(k, v, getCValueRefId(), "REF_ID"); }
        protected abstract ConditionValue getCValueRefId();

        public void SetClassSynonym_Equal(int? v) { regClassSynonym(CK_EQ, v); }
        public void SetClassSynonym_NotEqual(int? v) { regClassSynonym(CK_NES, v); }
        public void SetClassSynonym_GreaterThan(int? v) { regClassSynonym(CK_GT, v); }
        public void SetClassSynonym_LessThan(int? v) { regClassSynonym(CK_LT, v); }
        public void SetClassSynonym_GreaterEqual(int? v) { regClassSynonym(CK_GE, v); }
        public void SetClassSynonym_LessEqual(int? v) { regClassSynonym(CK_LE, v); }
        public void SetClassSynonym_InScope(IList<int?> ls) { regINS<int?>(CK_INS, cTL<int?>(ls), getCValueClassSynonym(), "CLASS"); }
        public void SetClassSynonym_NotInScope(IList<int?> ls) { regINS<int?>(CK_NINS, cTL<int?>(ls), getCValueClassSynonym(), "CLASS"); }
        public void InScopeWhitePgReserv(SubQuery<WhitePgReservCB> subQuery) {
            assertObjectNotNull("subQuery<WhitePgReservCB>", subQuery);
            WhitePgReservCB cb = new WhitePgReservCB(); cb.xsetupForInScopeRelation(this); subQuery.Invoke(cb);
            String subQueryPropertyName = keepClassSynonym_InScopeSubQuery_WhitePgReserv(cb.Query());
            registerInScopeSubQuery(cb.Query(), "CLASS", "CLASS", subQueryPropertyName);
        }
        public abstract String keepClassSynonym_InScopeSubQuery_WhitePgReserv(WhitePgReservCQ subQuery);
        public void NotInScopeWhitePgReserv(SubQuery<WhitePgReservCB> subQuery) {
            assertObjectNotNull("subQuery<WhitePgReservCB>", subQuery);
            WhitePgReservCB cb = new WhitePgReservCB(); cb.xsetupForInScopeRelation(this); subQuery.Invoke(cb);
            String subQueryPropertyName = keepClassSynonym_NotInScopeSubQuery_WhitePgReserv(cb.Query());
            registerNotInScopeSubQuery(cb.Query(), "CLASS", "CLASS", subQueryPropertyName);
        }
        public abstract String keepClassSynonym_NotInScopeSubQuery_WhitePgReserv(WhitePgReservCQ subQuery);
        public void SetClassSynonym_IsNull() { regClassSynonym(CK_ISN, DUMMY_OBJECT); }
        public void SetClassSynonym_IsNotNull() { regClassSynonym(CK_ISNN, DUMMY_OBJECT); }
        protected void regClassSynonym(ConditionKey k, Object v) { regQ(k, v, getCValueClassSynonym(), "CLASS"); }
        protected abstract ConditionValue getCValueClassSynonym();

        // ===================================================================================
        //                                                                    Scalar Condition
        //                                                                    ================
        public SSQFunction<WhitePgReservRefCB> Scalar_Equal() {
            return xcreateSSQFunction("=");
        }

        public SSQFunction<WhitePgReservRefCB> Scalar_NotEqual() {
            return xcreateSSQFunction("<>");
        }

        public SSQFunction<WhitePgReservRefCB> Scalar_GreaterEqual() {
            return xcreateSSQFunction(">=");
        }

        public SSQFunction<WhitePgReservRefCB> Scalar_GreaterThan() {
            return xcreateSSQFunction(">");
        }

        public SSQFunction<WhitePgReservRefCB> Scalar_LessEqual() {
            return xcreateSSQFunction("<=");
        }

        public SSQFunction<WhitePgReservRefCB> Scalar_LessThan() {
            return xcreateSSQFunction("<");
        }

        protected SSQFunction<WhitePgReservRefCB> xcreateSSQFunction(String operand) {
            return new SSQFunction<WhitePgReservRefCB>(delegate(String function, SubQuery<WhitePgReservRefCB> subQuery) {
                xscalarSubQuery(function, subQuery, operand);
            });
        }

        protected void xscalarSubQuery(String function, SubQuery<WhitePgReservRefCB> subQuery, String operand) {
            assertObjectNotNull("subQuery<WhitePgReservRefCB>", subQuery);
            WhitePgReservRefCB cb = new WhitePgReservRefCB(); cb.xsetupForScalarCondition(this); subQuery.Invoke(cb);
            String subQueryPropertyName = keepScalarSubQuery(cb.Query()); // for saving query-value.
            registerScalarSubQuery(function, cb.Query(), subQueryPropertyName, operand);
        }
        public abstract String keepScalarSubQuery(WhitePgReservRefCQ subQuery);

        // ===============================================================================
        //                                                                  MySelf InScope
        //                                                                  ==============
        public void MyselfInScope(SubQuery<WhitePgReservRefCB> subQuery) {
            assertObjectNotNull("subQuery<WhitePgReservRefCB>", subQuery);
            WhitePgReservRefCB cb = new WhitePgReservRefCB(); cb.xsetupForInScopeRelation(this); subQuery.Invoke(cb);
            String subQueryPropertyName = keepMyselfInScopeSubQuery(cb.Query()); // for saving query-value.
            registerInScopeSubQuery(cb.Query(), "REF_ID", "REF_ID", subQueryPropertyName);
        }
        public abstract String keepMyselfInScopeSubQuery(WhitePgReservRefCQ subQuery);

        public override String ToString() { return xgetSqlClause().getClause(); }
    }
}
