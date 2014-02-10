
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
    public abstract class AbstractBsWhiteNoPkCQ : AbstractConditionQuery {

        public AbstractBsWhiteNoPkCQ(ConditionQuery childQuery, SqlClause sqlClause, String aliasName, int nestLevel)
            : base(childQuery, sqlClause, aliasName, nestLevel) {}

        public override String getTableDbName() { return "white_no_pk"; }
        public override String getTableSqlName() { return "white_no_pk"; }

        public void SetNoPkId_Equal(long? v) { regNoPkId(CK_EQ, v); }
        public void SetNoPkId_NotEqual(long? v) { regNoPkId(CK_NES, v); }
        public void SetNoPkId_GreaterThan(long? v) { regNoPkId(CK_GT, v); }
        public void SetNoPkId_LessThan(long? v) { regNoPkId(CK_LT, v); }
        public void SetNoPkId_GreaterEqual(long? v) { regNoPkId(CK_GE, v); }
        public void SetNoPkId_LessEqual(long? v) { regNoPkId(CK_LE, v); }
        public void SetNoPkId_InScope(IList<long?> ls) { regINS<long?>(CK_INS, cTL<long?>(ls), getCValueNoPkId(), "NO_PK_ID"); }
        public void SetNoPkId_NotInScope(IList<long?> ls) { regINS<long?>(CK_NINS, cTL<long?>(ls), getCValueNoPkId(), "NO_PK_ID"); }
        protected void regNoPkId(ConditionKey k, Object v) { regQ(k, v, getCValueNoPkId(), "NO_PK_ID"); }
        protected abstract ConditionValue getCValueNoPkId();

        public void SetNoPkName_Equal(String v) { DoSetNoPkName_Equal(fRES(v)); }
        protected void DoSetNoPkName_Equal(String v) { regNoPkName(CK_EQ, v); }
        public void SetNoPkName_NotEqual(String v) { DoSetNoPkName_NotEqual(fRES(v)); }
        protected void DoSetNoPkName_NotEqual(String v) { regNoPkName(CK_NES, v); }
        public void SetNoPkName_InScope(IList<String> ls) { regINS<String>(CK_INS, cTL<String>(ls), getCValueNoPkName(), "NO_PK_NAME"); }
        public void SetNoPkName_NotInScope(IList<String> ls) { regINS<String>(CK_NINS, cTL<String>(ls), getCValueNoPkName(), "NO_PK_NAME"); }
        public void SetNoPkName_PrefixSearch(String v) { SetNoPkName_LikeSearch(v, cLSOP()); }
        public void SetNoPkName_LikeSearch(String v, LikeSearchOption option)
        { regLSQ(CK_LS, fRES(v), getCValueNoPkName(), "NO_PK_NAME", option); }
        public void SetNoPkName_NotLikeSearch(String v, LikeSearchOption option)
        { regLSQ(CK_NLS, fRES(v), getCValueNoPkName(), "NO_PK_NAME", option); }
        public void SetNoPkName_IsNull() { regNoPkName(CK_ISN, DUMMY_OBJECT); }
        public void SetNoPkName_IsNotNull() { regNoPkName(CK_ISNN, DUMMY_OBJECT); }
        protected void regNoPkName(ConditionKey k, Object v) { regQ(k, v, getCValueNoPkName(), "NO_PK_NAME"); }
        protected abstract ConditionValue getCValueNoPkName();

        public void SetNoPkInteger_Equal(int? v) { regNoPkInteger(CK_EQ, v); }
        public void SetNoPkInteger_NotEqual(int? v) { regNoPkInteger(CK_NES, v); }
        public void SetNoPkInteger_GreaterThan(int? v) { regNoPkInteger(CK_GT, v); }
        public void SetNoPkInteger_LessThan(int? v) { regNoPkInteger(CK_LT, v); }
        public void SetNoPkInteger_GreaterEqual(int? v) { regNoPkInteger(CK_GE, v); }
        public void SetNoPkInteger_LessEqual(int? v) { regNoPkInteger(CK_LE, v); }
        public void SetNoPkInteger_InScope(IList<int?> ls) { regINS<int?>(CK_INS, cTL<int?>(ls), getCValueNoPkInteger(), "NO_PK_INTEGER"); }
        public void SetNoPkInteger_NotInScope(IList<int?> ls) { regINS<int?>(CK_NINS, cTL<int?>(ls), getCValueNoPkInteger(), "NO_PK_INTEGER"); }
        public void SetNoPkInteger_IsNull() { regNoPkInteger(CK_ISN, DUMMY_OBJECT); }
        public void SetNoPkInteger_IsNotNull() { regNoPkInteger(CK_ISNN, DUMMY_OBJECT); }
        protected void regNoPkInteger(ConditionKey k, Object v) { regQ(k, v, getCValueNoPkInteger(), "NO_PK_INTEGER"); }
        protected abstract ConditionValue getCValueNoPkInteger();

        public override String ToString() { return xgetSqlClause().getClause(); }
    }
}
