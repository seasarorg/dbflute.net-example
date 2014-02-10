
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
    public abstract class AbstractBsWhiteAllInOneClsRefCQ : AbstractConditionQuery {

        public AbstractBsWhiteAllInOneClsRefCQ(ConditionQuery childQuery, SqlClause sqlClause, String aliasName, int nestLevel)
            : base(childQuery, sqlClause, aliasName, nestLevel) {}

        public override String getTableDbName() { return "white_all_in_one_cls_ref"; }
        public override String getTableSqlName() { return "white_all_in_one_cls_ref"; }

        public void SetClsRefId_Equal(int? v) { regClsRefId(CK_EQ, v); }
        public void SetClsRefId_NotEqual(int? v) { regClsRefId(CK_NES, v); }
        public void SetClsRefId_GreaterThan(int? v) { regClsRefId(CK_GT, v); }
        public void SetClsRefId_LessThan(int? v) { regClsRefId(CK_LT, v); }
        public void SetClsRefId_GreaterEqual(int? v) { regClsRefId(CK_GE, v); }
        public void SetClsRefId_LessEqual(int? v) { regClsRefId(CK_LE, v); }
        public void SetClsRefId_InScope(IList<int?> ls) { regINS<int?>(CK_INS, cTL<int?>(ls), getCValueClsRefId(), "CLS_REF_ID"); }
        public void SetClsRefId_NotInScope(IList<int?> ls) { regINS<int?>(CK_NINS, cTL<int?>(ls), getCValueClsRefId(), "CLS_REF_ID"); }
        public void SetClsRefId_IsNull() { regClsRefId(CK_ISN, DUMMY_OBJECT); }
        public void SetClsRefId_IsNotNull() { regClsRefId(CK_ISNN, DUMMY_OBJECT); }
        protected void regClsRefId(ConditionKey k, Object v) { regQ(k, v, getCValueClsRefId(), "CLS_REF_ID"); }
        protected abstract ConditionValue getCValueClsRefId();

        public void SetFooCode_Equal(String v) { DoSetFooCode_Equal(fRES(v)); }
        protected void DoSetFooCode_Equal(String v) { regFooCode(CK_EQ, v); }
        public void SetFooCode_NotEqual(String v) { DoSetFooCode_NotEqual(fRES(v)); }
        protected void DoSetFooCode_NotEqual(String v) { regFooCode(CK_NES, v); }
        public void SetFooCode_InScope(IList<String> ls) { regINS<String>(CK_INS, cTL<String>(ls), getCValueFooCode(), "FOO_CODE"); }
        public void SetFooCode_NotInScope(IList<String> ls) { regINS<String>(CK_NINS, cTL<String>(ls), getCValueFooCode(), "FOO_CODE"); }
        public void SetFooCode_PrefixSearch(String v) { SetFooCode_LikeSearch(v, cLSOP()); }
        public void SetFooCode_LikeSearch(String v, LikeSearchOption option)
        { regLSQ(CK_LS, fRES(v), getCValueFooCode(), "FOO_CODE", option); }
        public void SetFooCode_NotLikeSearch(String v, LikeSearchOption option)
        { regLSQ(CK_NLS, fRES(v), getCValueFooCode(), "FOO_CODE", option); }
        protected void regFooCode(ConditionKey k, Object v) { regQ(k, v, getCValueFooCode(), "FOO_CODE"); }
        protected abstract ConditionValue getCValueFooCode();

        public void SetBarCode_Equal(String v) { DoSetBarCode_Equal(fRES(v)); }
        protected void DoSetBarCode_Equal(String v) { regBarCode(CK_EQ, v); }
        public void SetBarCode_NotEqual(String v) { DoSetBarCode_NotEqual(fRES(v)); }
        protected void DoSetBarCode_NotEqual(String v) { regBarCode(CK_NES, v); }
        public void SetBarCode_InScope(IList<String> ls) { regINS<String>(CK_INS, cTL<String>(ls), getCValueBarCode(), "BAR_CODE"); }
        public void SetBarCode_NotInScope(IList<String> ls) { regINS<String>(CK_NINS, cTL<String>(ls), getCValueBarCode(), "BAR_CODE"); }
        public void SetBarCode_PrefixSearch(String v) { SetBarCode_LikeSearch(v, cLSOP()); }
        public void SetBarCode_LikeSearch(String v, LikeSearchOption option)
        { regLSQ(CK_LS, fRES(v), getCValueBarCode(), "BAR_CODE", option); }
        public void SetBarCode_NotLikeSearch(String v, LikeSearchOption option)
        { regLSQ(CK_NLS, fRES(v), getCValueBarCode(), "BAR_CODE", option); }
        protected void regBarCode(ConditionKey k, Object v) { regQ(k, v, getCValueBarCode(), "BAR_CODE"); }
        protected abstract ConditionValue getCValueBarCode();

        public void SetQuxCode_Equal(String v) { DoSetQuxCode_Equal(fRES(v)); }
        protected void DoSetQuxCode_Equal(String v) { regQuxCode(CK_EQ, v); }
        public void SetQuxCode_NotEqual(String v) { DoSetQuxCode_NotEqual(fRES(v)); }
        protected void DoSetQuxCode_NotEqual(String v) { regQuxCode(CK_NES, v); }
        public void SetQuxCode_InScope(IList<String> ls) { regINS<String>(CK_INS, cTL<String>(ls), getCValueQuxCode(), "QUX_CODE"); }
        public void SetQuxCode_NotInScope(IList<String> ls) { regINS<String>(CK_NINS, cTL<String>(ls), getCValueQuxCode(), "QUX_CODE"); }
        public void SetQuxCode_PrefixSearch(String v) { SetQuxCode_LikeSearch(v, cLSOP()); }
        public void SetQuxCode_LikeSearch(String v, LikeSearchOption option)
        { regLSQ(CK_LS, fRES(v), getCValueQuxCode(), "QUX_CODE", option); }
        public void SetQuxCode_NotLikeSearch(String v, LikeSearchOption option)
        { regLSQ(CK_NLS, fRES(v), getCValueQuxCode(), "QUX_CODE", option); }
        protected void regQuxCode(ConditionKey k, Object v) { regQ(k, v, getCValueQuxCode(), "QUX_CODE"); }
        protected abstract ConditionValue getCValueQuxCode();

        // ===================================================================================
        //                                                                    Scalar Condition
        //                                                                    ================
        public SSQFunction<WhiteAllInOneClsRefCB> Scalar_Equal() {
            return xcreateSSQFunction("=");
        }

        public SSQFunction<WhiteAllInOneClsRefCB> Scalar_NotEqual() {
            return xcreateSSQFunction("<>");
        }

        public SSQFunction<WhiteAllInOneClsRefCB> Scalar_GreaterEqual() {
            return xcreateSSQFunction(">=");
        }

        public SSQFunction<WhiteAllInOneClsRefCB> Scalar_GreaterThan() {
            return xcreateSSQFunction(">");
        }

        public SSQFunction<WhiteAllInOneClsRefCB> Scalar_LessEqual() {
            return xcreateSSQFunction("<=");
        }

        public SSQFunction<WhiteAllInOneClsRefCB> Scalar_LessThan() {
            return xcreateSSQFunction("<");
        }

        protected SSQFunction<WhiteAllInOneClsRefCB> xcreateSSQFunction(String operand) {
            return new SSQFunction<WhiteAllInOneClsRefCB>(delegate(String function, SubQuery<WhiteAllInOneClsRefCB> subQuery) {
                xscalarSubQuery(function, subQuery, operand);
            });
        }

        protected void xscalarSubQuery(String function, SubQuery<WhiteAllInOneClsRefCB> subQuery, String operand) {
            assertObjectNotNull("subQuery<WhiteAllInOneClsRefCB>", subQuery);
            WhiteAllInOneClsRefCB cb = new WhiteAllInOneClsRefCB(); cb.xsetupForScalarCondition(this); subQuery.Invoke(cb);
            String subQueryPropertyName = keepScalarSubQuery(cb.Query()); // for saving query-value.
            registerScalarSubQuery(function, cb.Query(), subQueryPropertyName, operand);
        }
        public abstract String keepScalarSubQuery(WhiteAllInOneClsRefCQ subQuery);

        // ===============================================================================
        //                                                                  MySelf InScope
        //                                                                  ==============
        public void MyselfInScope(SubQuery<WhiteAllInOneClsRefCB> subQuery) {
            assertObjectNotNull("subQuery<WhiteAllInOneClsRefCB>", subQuery);
            WhiteAllInOneClsRefCB cb = new WhiteAllInOneClsRefCB(); cb.xsetupForInScopeRelation(this); subQuery.Invoke(cb);
            String subQueryPropertyName = keepMyselfInScopeSubQuery(cb.Query()); // for saving query-value.
            registerInScopeSubQuery(cb.Query(), "CLS_REF_ID", "CLS_REF_ID", subQueryPropertyName);
        }
        public abstract String keepMyselfInScopeSubQuery(WhiteAllInOneClsRefCQ subQuery);

        public override String ToString() { return xgetSqlClause().getClause(); }
    }
}
