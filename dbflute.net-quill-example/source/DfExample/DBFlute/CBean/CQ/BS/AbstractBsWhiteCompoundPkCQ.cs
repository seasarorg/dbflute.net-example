
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
    public abstract class AbstractBsWhiteCompoundPkCQ : AbstractConditionQuery {

        public AbstractBsWhiteCompoundPkCQ(ConditionQuery childQuery, SqlClause sqlClause, String aliasName, int nestLevel)
            : base(childQuery, sqlClause, aliasName, nestLevel) {}

        public override String getTableDbName() { return "white_compound_pk"; }
        public override String getTableSqlName() { return "white_compound_pk"; }

        public void SetPkFirstId_Equal(int? v) { regPkFirstId(CK_EQ, v); }
        public void SetPkFirstId_NotEqual(int? v) { regPkFirstId(CK_NES, v); }
        public void SetPkFirstId_GreaterThan(int? v) { regPkFirstId(CK_GT, v); }
        public void SetPkFirstId_LessThan(int? v) { regPkFirstId(CK_LT, v); }
        public void SetPkFirstId_GreaterEqual(int? v) { regPkFirstId(CK_GE, v); }
        public void SetPkFirstId_LessEqual(int? v) { regPkFirstId(CK_LE, v); }
        public void SetPkFirstId_InScope(IList<int?> ls) { regINS<int?>(CK_INS, cTL<int?>(ls), getCValuePkFirstId(), "PK_FIRST_ID"); }
        public void SetPkFirstId_NotInScope(IList<int?> ls) { regINS<int?>(CK_NINS, cTL<int?>(ls), getCValuePkFirstId(), "PK_FIRST_ID"); }
        public void SetPkFirstId_IsNull() { regPkFirstId(CK_ISN, DUMMY_OBJECT); }
        public void SetPkFirstId_IsNotNull() { regPkFirstId(CK_ISNN, DUMMY_OBJECT); }
        protected void regPkFirstId(ConditionKey k, Object v) { regQ(k, v, getCValuePkFirstId(), "PK_FIRST_ID"); }
        protected abstract ConditionValue getCValuePkFirstId();

        public void SetPkSecondId_Equal(int? v) { regPkSecondId(CK_EQ, v); }
        public void SetPkSecondId_NotEqual(int? v) { regPkSecondId(CK_NES, v); }
        public void SetPkSecondId_GreaterThan(int? v) { regPkSecondId(CK_GT, v); }
        public void SetPkSecondId_LessThan(int? v) { regPkSecondId(CK_LT, v); }
        public void SetPkSecondId_GreaterEqual(int? v) { regPkSecondId(CK_GE, v); }
        public void SetPkSecondId_LessEqual(int? v) { regPkSecondId(CK_LE, v); }
        public void SetPkSecondId_InScope(IList<int?> ls) { regINS<int?>(CK_INS, cTL<int?>(ls), getCValuePkSecondId(), "PK_SECOND_ID"); }
        public void SetPkSecondId_NotInScope(IList<int?> ls) { regINS<int?>(CK_NINS, cTL<int?>(ls), getCValuePkSecondId(), "PK_SECOND_ID"); }
        public void SetPkSecondId_IsNull() { regPkSecondId(CK_ISN, DUMMY_OBJECT); }
        public void SetPkSecondId_IsNotNull() { regPkSecondId(CK_ISNN, DUMMY_OBJECT); }
        protected void regPkSecondId(ConditionKey k, Object v) { regQ(k, v, getCValuePkSecondId(), "PK_SECOND_ID"); }
        protected abstract ConditionValue getCValuePkSecondId();

        public void SetPkName_Equal(String v) { DoSetPkName_Equal(fRES(v)); }
        protected void DoSetPkName_Equal(String v) { regPkName(CK_EQ, v); }
        public void SetPkName_NotEqual(String v) { DoSetPkName_NotEqual(fRES(v)); }
        protected void DoSetPkName_NotEqual(String v) { regPkName(CK_NES, v); }
        public void SetPkName_InScope(IList<String> ls) { regINS<String>(CK_INS, cTL<String>(ls), getCValuePkName(), "PK_NAME"); }
        public void SetPkName_NotInScope(IList<String> ls) { regINS<String>(CK_NINS, cTL<String>(ls), getCValuePkName(), "PK_NAME"); }
        public void SetPkName_PrefixSearch(String v) { SetPkName_LikeSearch(v, cLSOP()); }
        public void SetPkName_LikeSearch(String v, LikeSearchOption option)
        { regLSQ(CK_LS, fRES(v), getCValuePkName(), "PK_NAME", option); }
        public void SetPkName_NotLikeSearch(String v, LikeSearchOption option)
        { regLSQ(CK_NLS, fRES(v), getCValuePkName(), "PK_NAME", option); }
        protected void regPkName(ConditionKey k, Object v) { regQ(k, v, getCValuePkName(), "PK_NAME"); }
        protected abstract ConditionValue getCValuePkName();

        public override String ToString() { return xgetSqlClause().getClause(); }
    }
}
