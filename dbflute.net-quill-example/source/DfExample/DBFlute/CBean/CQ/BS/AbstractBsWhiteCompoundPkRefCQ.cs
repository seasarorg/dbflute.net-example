
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
    public abstract class AbstractBsWhiteCompoundPkRefCQ : AbstractConditionQuery {

        public AbstractBsWhiteCompoundPkRefCQ(ConditionQuery childQuery, SqlClause sqlClause, String aliasName, int nestLevel)
            : base(childQuery, sqlClause, aliasName, nestLevel) {}

        public override String getTableDbName() { return "white_compound_pk_ref"; }
        public override String getTableSqlName() { return "white_compound_pk_ref"; }

        public void SetMultipleFirstId_Equal(int? v) { regMultipleFirstId(CK_EQ, v); }
        public void SetMultipleFirstId_NotEqual(int? v) { regMultipleFirstId(CK_NES, v); }
        public void SetMultipleFirstId_GreaterThan(int? v) { regMultipleFirstId(CK_GT, v); }
        public void SetMultipleFirstId_LessThan(int? v) { regMultipleFirstId(CK_LT, v); }
        public void SetMultipleFirstId_GreaterEqual(int? v) { regMultipleFirstId(CK_GE, v); }
        public void SetMultipleFirstId_LessEqual(int? v) { regMultipleFirstId(CK_LE, v); }
        public void SetMultipleFirstId_InScope(IList<int?> ls) { regINS<int?>(CK_INS, cTL<int?>(ls), getCValueMultipleFirstId(), "MULTIPLE_FIRST_ID"); }
        public void SetMultipleFirstId_NotInScope(IList<int?> ls) { regINS<int?>(CK_NINS, cTL<int?>(ls), getCValueMultipleFirstId(), "MULTIPLE_FIRST_ID"); }
        public void SetMultipleFirstId_IsNull() { regMultipleFirstId(CK_ISN, DUMMY_OBJECT); }
        public void SetMultipleFirstId_IsNotNull() { regMultipleFirstId(CK_ISNN, DUMMY_OBJECT); }
        protected void regMultipleFirstId(ConditionKey k, Object v) { regQ(k, v, getCValueMultipleFirstId(), "MULTIPLE_FIRST_ID"); }
        protected abstract ConditionValue getCValueMultipleFirstId();

        public void SetMultipleSecondId_Equal(int? v) { regMultipleSecondId(CK_EQ, v); }
        public void SetMultipleSecondId_NotEqual(int? v) { regMultipleSecondId(CK_NES, v); }
        public void SetMultipleSecondId_GreaterThan(int? v) { regMultipleSecondId(CK_GT, v); }
        public void SetMultipleSecondId_LessThan(int? v) { regMultipleSecondId(CK_LT, v); }
        public void SetMultipleSecondId_GreaterEqual(int? v) { regMultipleSecondId(CK_GE, v); }
        public void SetMultipleSecondId_LessEqual(int? v) { regMultipleSecondId(CK_LE, v); }
        public void SetMultipleSecondId_InScope(IList<int?> ls) { regINS<int?>(CK_INS, cTL<int?>(ls), getCValueMultipleSecondId(), "MULTIPLE_SECOND_ID"); }
        public void SetMultipleSecondId_NotInScope(IList<int?> ls) { regINS<int?>(CK_NINS, cTL<int?>(ls), getCValueMultipleSecondId(), "MULTIPLE_SECOND_ID"); }
        public void SetMultipleSecondId_IsNull() { regMultipleSecondId(CK_ISN, DUMMY_OBJECT); }
        public void SetMultipleSecondId_IsNotNull() { regMultipleSecondId(CK_ISNN, DUMMY_OBJECT); }
        protected void regMultipleSecondId(ConditionKey k, Object v) { regQ(k, v, getCValueMultipleSecondId(), "MULTIPLE_SECOND_ID"); }
        protected abstract ConditionValue getCValueMultipleSecondId();

        public void SetRefFirstId_Equal(int? v) { regRefFirstId(CK_EQ, v); }
        public void SetRefFirstId_NotEqual(int? v) { regRefFirstId(CK_NES, v); }
        public void SetRefFirstId_GreaterThan(int? v) { regRefFirstId(CK_GT, v); }
        public void SetRefFirstId_LessThan(int? v) { regRefFirstId(CK_LT, v); }
        public void SetRefFirstId_GreaterEqual(int? v) { regRefFirstId(CK_GE, v); }
        public void SetRefFirstId_LessEqual(int? v) { regRefFirstId(CK_LE, v); }
        public void SetRefFirstId_InScope(IList<int?> ls) { regINS<int?>(CK_INS, cTL<int?>(ls), getCValueRefFirstId(), "REF_FIRST_ID"); }
        public void SetRefFirstId_NotInScope(IList<int?> ls) { regINS<int?>(CK_NINS, cTL<int?>(ls), getCValueRefFirstId(), "REF_FIRST_ID"); }
        protected void regRefFirstId(ConditionKey k, Object v) { regQ(k, v, getCValueRefFirstId(), "REF_FIRST_ID"); }
        protected abstract ConditionValue getCValueRefFirstId();

        public void SetRefSecondId_Equal(int? v) { regRefSecondId(CK_EQ, v); }
        public void SetRefSecondId_NotEqual(int? v) { regRefSecondId(CK_NES, v); }
        public void SetRefSecondId_GreaterThan(int? v) { regRefSecondId(CK_GT, v); }
        public void SetRefSecondId_LessThan(int? v) { regRefSecondId(CK_LT, v); }
        public void SetRefSecondId_GreaterEqual(int? v) { regRefSecondId(CK_GE, v); }
        public void SetRefSecondId_LessEqual(int? v) { regRefSecondId(CK_LE, v); }
        public void SetRefSecondId_InScope(IList<int?> ls) { regINS<int?>(CK_INS, cTL<int?>(ls), getCValueRefSecondId(), "REF_SECOND_ID"); }
        public void SetRefSecondId_NotInScope(IList<int?> ls) { regINS<int?>(CK_NINS, cTL<int?>(ls), getCValueRefSecondId(), "REF_SECOND_ID"); }
        protected void regRefSecondId(ConditionKey k, Object v) { regQ(k, v, getCValueRefSecondId(), "REF_SECOND_ID"); }
        protected abstract ConditionValue getCValueRefSecondId();

        public override String ToString() { return xgetSqlClause().getClause(); }
    }
}
