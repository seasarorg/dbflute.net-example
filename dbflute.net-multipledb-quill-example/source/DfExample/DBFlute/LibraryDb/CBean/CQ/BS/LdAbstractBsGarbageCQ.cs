
using System;
using System.Collections.Generic;

using DfExample.DBFlute.LibraryDb.AllCommon;
using DfExample.DBFlute.LibraryDb.AllCommon.CBean;
using DfExample.DBFlute.LibraryDb.AllCommon.CBean.CKey;
using DfExample.DBFlute.LibraryDb.AllCommon.CBean.COption;
using DfExample.DBFlute.LibraryDb.AllCommon.CBean.CValue;
using DfExample.DBFlute.LibraryDb.AllCommon.CBean.SClause;

namespace DfExample.DBFlute.LibraryDb.CBean.CQ.BS {

    [System.Serializable]
    public abstract class LdAbstractBsGarbageCQ : LdAbstractConditionQuery {

        public LdAbstractBsGarbageCQ(LdConditionQuery childQuery, LdSqlClause sqlClause, String aliasName, int nestLevel)
            : base(childQuery, sqlClause, aliasName, nestLevel) {}

        public override String getTableDbName() { return "garbage"; }
        public override String getTableSqlName() { return "garbage"; }

        public void SetGarbageMemo_Equal(String v) { DoSetGarbageMemo_Equal(fRES(v)); }
        protected void DoSetGarbageMemo_Equal(String v) { regGarbageMemo(CK_EQ, v); }
        public void SetGarbageMemo_NotEqual(String v) { DoSetGarbageMemo_NotEqual(fRES(v)); }
        protected void DoSetGarbageMemo_NotEqual(String v) { regGarbageMemo(CK_NES, v); }
        public void SetGarbageMemo_GreaterThan(String v) { regGarbageMemo(CK_GT, fRES(v)); }
        public void SetGarbageMemo_LessThan(String v) { regGarbageMemo(CK_LT, fRES(v)); }
        public void SetGarbageMemo_GreaterEqual(String v) { regGarbageMemo(CK_GE, fRES(v)); }
        public void SetGarbageMemo_LessEqual(String v) { regGarbageMemo(CK_LE, fRES(v)); }
        public void SetGarbageMemo_InScope(IList<String> ls) { regINS<String>(CK_INS, cTL<String>(ls), getCValueGarbageMemo(), "GARBAGE_MEMO"); }
        public void SetGarbageMemo_NotInScope(IList<String> ls) { regINS<String>(CK_NINS, cTL<String>(ls), getCValueGarbageMemo(), "GARBAGE_MEMO"); }
        public void SetGarbageMemo_PrefixSearch(String v) { SetGarbageMemo_LikeSearch(v, cLSOP()); }
        public void SetGarbageMemo_LikeSearch(String v, LdLikeSearchOption option)
        { regLSQ(CK_LS, fRES(v), getCValueGarbageMemo(), "GARBAGE_MEMO", option); }
        public void SetGarbageMemo_NotLikeSearch(String v, LdLikeSearchOption option)
        { regLSQ(CK_NLS, fRES(v), getCValueGarbageMemo(), "GARBAGE_MEMO", option); }
        public void SetGarbageMemo_IsNull() { regGarbageMemo(CK_ISN, DUMMY_OBJECT); }
        public void SetGarbageMemo_IsNotNull() { regGarbageMemo(CK_ISNN, DUMMY_OBJECT); }
        protected void regGarbageMemo(LdConditionKey k, Object v) { regQ(k, v, getCValueGarbageMemo(), "GARBAGE_MEMO"); }
        protected abstract LdConditionValue getCValueGarbageMemo();

        public void SetGarbageTime_Equal(DateTime? v) { regGarbageTime(CK_EQ, v); }
        public void SetGarbageTime_NotEqual(DateTime? v) { regGarbageTime(CK_NES, v); }
        public void SetGarbageTime_GreaterThan(DateTime? v) { regGarbageTime(CK_GT, v); }
        public void SetGarbageTime_LessThan(DateTime? v) { regGarbageTime(CK_LT, v); }
        public void SetGarbageTime_GreaterEqual(DateTime? v) { regGarbageTime(CK_GE, v); }
        public void SetGarbageTime_LessEqual(DateTime? v) { regGarbageTime(CK_LE, v); }
        public void SetGarbageTime_FromTo(DateTime? from, DateTime? to, LdFromToOption option)
        { regFTQ(from, to, getCValueGarbageTime(), "GARBAGE_TIME", option); }
        public void SetGarbageTime_DateFromTo(DateTime? from, DateTime? to) { SetGarbageTime_FromTo(from, to, new LdDateFromToOption()); }
        public void SetGarbageTime_InScope(IList<DateTime?> ls) { regINS<DateTime?>(CK_INS, cTL<DateTime?>(ls), getCValueGarbageTime(), "GARBAGE_TIME"); }
        public void SetGarbageTime_NotInScope(IList<DateTime?> ls) { regINS<DateTime?>(CK_NINS, cTL<DateTime?>(ls), getCValueGarbageTime(), "GARBAGE_TIME"); }
        public void SetGarbageTime_IsNull() { regGarbageTime(CK_ISN, DUMMY_OBJECT); }
        public void SetGarbageTime_IsNotNull() { regGarbageTime(CK_ISNN, DUMMY_OBJECT); }
        protected void regGarbageTime(LdConditionKey k, Object v) { regQ(k, v, getCValueGarbageTime(), "GARBAGE_TIME"); }
        protected abstract LdConditionValue getCValueGarbageTime();

        public void SetGarbageCount_Equal(int? v) { regGarbageCount(CK_EQ, v); }
        public void SetGarbageCount_NotEqual(int? v) { regGarbageCount(CK_NES, v); }
        public void SetGarbageCount_GreaterThan(int? v) { regGarbageCount(CK_GT, v); }
        public void SetGarbageCount_LessThan(int? v) { regGarbageCount(CK_LT, v); }
        public void SetGarbageCount_GreaterEqual(int? v) { regGarbageCount(CK_GE, v); }
        public void SetGarbageCount_LessEqual(int? v) { regGarbageCount(CK_LE, v); }
        public void SetGarbageCount_InScope(IList<int?> ls) { regINS<int?>(CK_INS, cTL<int?>(ls), getCValueGarbageCount(), "GARBAGE_COUNT"); }
        public void SetGarbageCount_NotInScope(IList<int?> ls) { regINS<int?>(CK_NINS, cTL<int?>(ls), getCValueGarbageCount(), "GARBAGE_COUNT"); }
        public void SetGarbageCount_IsNull() { regGarbageCount(CK_ISN, DUMMY_OBJECT); }
        public void SetGarbageCount_IsNotNull() { regGarbageCount(CK_ISNN, DUMMY_OBJECT); }
        protected void regGarbageCount(LdConditionKey k, Object v) { regQ(k, v, getCValueGarbageCount(), "GARBAGE_COUNT"); }
        protected abstract LdConditionValue getCValueGarbageCount();

        public void SetRUser_Equal(String v) { DoSetRUser_Equal(fRES(v)); }
        protected void DoSetRUser_Equal(String v) { regRUser(CK_EQ, v); }
        public void SetRUser_NotEqual(String v) { DoSetRUser_NotEqual(fRES(v)); }
        protected void DoSetRUser_NotEqual(String v) { regRUser(CK_NES, v); }
        public void SetRUser_GreaterThan(String v) { regRUser(CK_GT, fRES(v)); }
        public void SetRUser_LessThan(String v) { regRUser(CK_LT, fRES(v)); }
        public void SetRUser_GreaterEqual(String v) { regRUser(CK_GE, fRES(v)); }
        public void SetRUser_LessEqual(String v) { regRUser(CK_LE, fRES(v)); }
        public void SetRUser_InScope(IList<String> ls) { regINS<String>(CK_INS, cTL<String>(ls), getCValueRUser(), "R_USER"); }
        public void SetRUser_NotInScope(IList<String> ls) { regINS<String>(CK_NINS, cTL<String>(ls), getCValueRUser(), "R_USER"); }
        public void SetRUser_PrefixSearch(String v) { SetRUser_LikeSearch(v, cLSOP()); }
        public void SetRUser_LikeSearch(String v, LdLikeSearchOption option)
        { regLSQ(CK_LS, fRES(v), getCValueRUser(), "R_USER", option); }
        public void SetRUser_NotLikeSearch(String v, LdLikeSearchOption option)
        { regLSQ(CK_NLS, fRES(v), getCValueRUser(), "R_USER", option); }
        public void SetRUser_IsNull() { regRUser(CK_ISN, DUMMY_OBJECT); }
        public void SetRUser_IsNotNull() { regRUser(CK_ISNN, DUMMY_OBJECT); }
        protected void regRUser(LdConditionKey k, Object v) { regQ(k, v, getCValueRUser(), "R_USER"); }
        protected abstract LdConditionValue getCValueRUser();

        public void SetRTimestamp_Equal(DateTime? v) { regRTimestamp(CK_EQ, v); }
        public void SetRTimestamp_NotEqual(DateTime? v) { regRTimestamp(CK_NES, v); }
        public void SetRTimestamp_GreaterThan(DateTime? v) { regRTimestamp(CK_GT, v); }
        public void SetRTimestamp_LessThan(DateTime? v) { regRTimestamp(CK_LT, v); }
        public void SetRTimestamp_GreaterEqual(DateTime? v) { regRTimestamp(CK_GE, v); }
        public void SetRTimestamp_LessEqual(DateTime? v) { regRTimestamp(CK_LE, v); }
        public void SetRTimestamp_FromTo(DateTime? from, DateTime? to, LdFromToOption option)
        { regFTQ(from, to, getCValueRTimestamp(), "R_TIMESTAMP", option); }
        public void SetRTimestamp_DateFromTo(DateTime? from, DateTime? to) { SetRTimestamp_FromTo(from, to, new LdDateFromToOption()); }
        public void SetRTimestamp_InScope(IList<DateTime?> ls) { regINS<DateTime?>(CK_INS, cTL<DateTime?>(ls), getCValueRTimestamp(), "R_TIMESTAMP"); }
        public void SetRTimestamp_NotInScope(IList<DateTime?> ls) { regINS<DateTime?>(CK_NINS, cTL<DateTime?>(ls), getCValueRTimestamp(), "R_TIMESTAMP"); }
        public void SetRTimestamp_IsNull() { regRTimestamp(CK_ISN, DUMMY_OBJECT); }
        public void SetRTimestamp_IsNotNull() { regRTimestamp(CK_ISNN, DUMMY_OBJECT); }
        protected void regRTimestamp(LdConditionKey k, Object v) { regQ(k, v, getCValueRTimestamp(), "R_TIMESTAMP"); }
        protected abstract LdConditionValue getCValueRTimestamp();

        public void SetUUser_Equal(String v) { DoSetUUser_Equal(fRES(v)); }
        protected void DoSetUUser_Equal(String v) { regUUser(CK_EQ, v); }
        public void SetUUser_NotEqual(String v) { DoSetUUser_NotEqual(fRES(v)); }
        protected void DoSetUUser_NotEqual(String v) { regUUser(CK_NES, v); }
        public void SetUUser_GreaterThan(String v) { regUUser(CK_GT, fRES(v)); }
        public void SetUUser_LessThan(String v) { regUUser(CK_LT, fRES(v)); }
        public void SetUUser_GreaterEqual(String v) { regUUser(CK_GE, fRES(v)); }
        public void SetUUser_LessEqual(String v) { regUUser(CK_LE, fRES(v)); }
        public void SetUUser_InScope(IList<String> ls) { regINS<String>(CK_INS, cTL<String>(ls), getCValueUUser(), "U_USER"); }
        public void SetUUser_NotInScope(IList<String> ls) { regINS<String>(CK_NINS, cTL<String>(ls), getCValueUUser(), "U_USER"); }
        public void SetUUser_PrefixSearch(String v) { SetUUser_LikeSearch(v, cLSOP()); }
        public void SetUUser_LikeSearch(String v, LdLikeSearchOption option)
        { regLSQ(CK_LS, fRES(v), getCValueUUser(), "U_USER", option); }
        public void SetUUser_NotLikeSearch(String v, LdLikeSearchOption option)
        { regLSQ(CK_NLS, fRES(v), getCValueUUser(), "U_USER", option); }
        public void SetUUser_IsNull() { regUUser(CK_ISN, DUMMY_OBJECT); }
        public void SetUUser_IsNotNull() { regUUser(CK_ISNN, DUMMY_OBJECT); }
        protected void regUUser(LdConditionKey k, Object v) { regQ(k, v, getCValueUUser(), "U_USER"); }
        protected abstract LdConditionValue getCValueUUser();

        public void SetUTimestamp_Equal(DateTime? v) { regUTimestamp(CK_EQ, v); }
        public void SetUTimestamp_NotEqual(DateTime? v) { regUTimestamp(CK_NES, v); }
        public void SetUTimestamp_GreaterThan(DateTime? v) { regUTimestamp(CK_GT, v); }
        public void SetUTimestamp_LessThan(DateTime? v) { regUTimestamp(CK_LT, v); }
        public void SetUTimestamp_GreaterEqual(DateTime? v) { regUTimestamp(CK_GE, v); }
        public void SetUTimestamp_LessEqual(DateTime? v) { regUTimestamp(CK_LE, v); }
        public void SetUTimestamp_FromTo(DateTime? from, DateTime? to, LdFromToOption option)
        { regFTQ(from, to, getCValueUTimestamp(), "U_TIMESTAMP", option); }
        public void SetUTimestamp_DateFromTo(DateTime? from, DateTime? to) { SetUTimestamp_FromTo(from, to, new LdDateFromToOption()); }
        public void SetUTimestamp_InScope(IList<DateTime?> ls) { regINS<DateTime?>(CK_INS, cTL<DateTime?>(ls), getCValueUTimestamp(), "U_TIMESTAMP"); }
        public void SetUTimestamp_NotInScope(IList<DateTime?> ls) { regINS<DateTime?>(CK_NINS, cTL<DateTime?>(ls), getCValueUTimestamp(), "U_TIMESTAMP"); }
        public void SetUTimestamp_IsNull() { regUTimestamp(CK_ISN, DUMMY_OBJECT); }
        public void SetUTimestamp_IsNotNull() { regUTimestamp(CK_ISNN, DUMMY_OBJECT); }
        protected void regUTimestamp(LdConditionKey k, Object v) { regQ(k, v, getCValueUTimestamp(), "U_TIMESTAMP"); }
        protected abstract LdConditionValue getCValueUTimestamp();

        public override String ToString() { return xgetSqlClause().getClause(); }
    }
}
