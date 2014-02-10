
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
    public abstract class AbstractBsVendorCheckCQ : AbstractConditionQuery {

        public AbstractBsVendorCheckCQ(ConditionQuery childQuery, SqlClause sqlClause, String aliasName, int nestLevel)
            : base(childQuery, sqlClause, aliasName, nestLevel) {}

        public override String getTableDbName() { return "vendor_check"; }
        public override String getTableSqlName() { return "vendor_check"; }

        public void SetVendorCheckId_Equal(long? v) { regVendorCheckId(CK_EQ, v); }
        public void SetVendorCheckId_NotEqual(long? v) { regVendorCheckId(CK_NES, v); }
        public void SetVendorCheckId_GreaterThan(long? v) { regVendorCheckId(CK_GT, v); }
        public void SetVendorCheckId_LessThan(long? v) { regVendorCheckId(CK_LT, v); }
        public void SetVendorCheckId_GreaterEqual(long? v) { regVendorCheckId(CK_GE, v); }
        public void SetVendorCheckId_LessEqual(long? v) { regVendorCheckId(CK_LE, v); }
        public void SetVendorCheckId_InScope(IList<long?> ls) { regINS<long?>(CK_INS, cTL<long?>(ls), getCValueVendorCheckId(), "VENDOR_CHECK_ID"); }
        public void SetVendorCheckId_NotInScope(IList<long?> ls) { regINS<long?>(CK_NINS, cTL<long?>(ls), getCValueVendorCheckId(), "VENDOR_CHECK_ID"); }
        public void SetVendorCheckId_IsNull() { regVendorCheckId(CK_ISN, DUMMY_OBJECT); }
        public void SetVendorCheckId_IsNotNull() { regVendorCheckId(CK_ISNN, DUMMY_OBJECT); }
        protected void regVendorCheckId(ConditionKey k, Object v) { regQ(k, v, getCValueVendorCheckId(), "VENDOR_CHECK_ID"); }
        protected abstract ConditionValue getCValueVendorCheckId();

        public void SetTypeOfBoolean_Equal(bool? v) { regTypeOfBoolean(CK_EQ, v); }
        protected void regTypeOfBoolean(ConditionKey k, Object v) { regQ(k, v, getCValueTypeOfBoolean(), "TYPE_OF_BOOLEAN"); }
        protected abstract ConditionValue getCValueTypeOfBoolean();

        public void SetTypeOfInteger_Equal(int? v) { regTypeOfInteger(CK_EQ, v); }
        public void SetTypeOfInteger_NotEqual(int? v) { regTypeOfInteger(CK_NES, v); }
        public void SetTypeOfInteger_GreaterThan(int? v) { regTypeOfInteger(CK_GT, v); }
        public void SetTypeOfInteger_LessThan(int? v) { regTypeOfInteger(CK_LT, v); }
        public void SetTypeOfInteger_GreaterEqual(int? v) { regTypeOfInteger(CK_GE, v); }
        public void SetTypeOfInteger_LessEqual(int? v) { regTypeOfInteger(CK_LE, v); }
        public void SetTypeOfInteger_InScope(IList<int?> ls) { regINS<int?>(CK_INS, cTL<int?>(ls), getCValueTypeOfInteger(), "TYPE_OF_INTEGER"); }
        public void SetTypeOfInteger_NotInScope(IList<int?> ls) { regINS<int?>(CK_NINS, cTL<int?>(ls), getCValueTypeOfInteger(), "TYPE_OF_INTEGER"); }
        public void SetTypeOfInteger_IsNull() { regTypeOfInteger(CK_ISN, DUMMY_OBJECT); }
        public void SetTypeOfInteger_IsNotNull() { regTypeOfInteger(CK_ISNN, DUMMY_OBJECT); }
        protected void regTypeOfInteger(ConditionKey k, Object v) { regQ(k, v, getCValueTypeOfInteger(), "TYPE_OF_INTEGER"); }
        protected abstract ConditionValue getCValueTypeOfInteger();

        public void SetTypeOfBigint_Equal(long? v) { regTypeOfBigint(CK_EQ, v); }
        public void SetTypeOfBigint_NotEqual(long? v) { regTypeOfBigint(CK_NES, v); }
        public void SetTypeOfBigint_GreaterThan(long? v) { regTypeOfBigint(CK_GT, v); }
        public void SetTypeOfBigint_LessThan(long? v) { regTypeOfBigint(CK_LT, v); }
        public void SetTypeOfBigint_GreaterEqual(long? v) { regTypeOfBigint(CK_GE, v); }
        public void SetTypeOfBigint_LessEqual(long? v) { regTypeOfBigint(CK_LE, v); }
        public void SetTypeOfBigint_InScope(IList<long?> ls) { regINS<long?>(CK_INS, cTL<long?>(ls), getCValueTypeOfBigint(), "TYPE_OF_BIGINT"); }
        public void SetTypeOfBigint_NotInScope(IList<long?> ls) { regINS<long?>(CK_NINS, cTL<long?>(ls), getCValueTypeOfBigint(), "TYPE_OF_BIGINT"); }
        public void SetTypeOfBigint_IsNull() { regTypeOfBigint(CK_ISN, DUMMY_OBJECT); }
        public void SetTypeOfBigint_IsNotNull() { regTypeOfBigint(CK_ISNN, DUMMY_OBJECT); }
        protected void regTypeOfBigint(ConditionKey k, Object v) { regQ(k, v, getCValueTypeOfBigint(), "TYPE_OF_BIGINT"); }
        protected abstract ConditionValue getCValueTypeOfBigint();

        public void SetTypeOfFloat_Equal(decimal? v) { regTypeOfFloat(CK_EQ, v); }
        public void SetTypeOfFloat_NotEqual(decimal? v) { regTypeOfFloat(CK_NES, v); }
        public void SetTypeOfFloat_GreaterThan(decimal? v) { regTypeOfFloat(CK_GT, v); }
        public void SetTypeOfFloat_LessThan(decimal? v) { regTypeOfFloat(CK_LT, v); }
        public void SetTypeOfFloat_GreaterEqual(decimal? v) { regTypeOfFloat(CK_GE, v); }
        public void SetTypeOfFloat_LessEqual(decimal? v) { regTypeOfFloat(CK_LE, v); }
        public void SetTypeOfFloat_InScope(IList<decimal?> ls) { regINS<decimal?>(CK_INS, cTL<decimal?>(ls), getCValueTypeOfFloat(), "TYPE_OF_FLOAT"); }
        public void SetTypeOfFloat_NotInScope(IList<decimal?> ls) { regINS<decimal?>(CK_NINS, cTL<decimal?>(ls), getCValueTypeOfFloat(), "TYPE_OF_FLOAT"); }
        public void SetTypeOfFloat_IsNull() { regTypeOfFloat(CK_ISN, DUMMY_OBJECT); }
        public void SetTypeOfFloat_IsNotNull() { regTypeOfFloat(CK_ISNN, DUMMY_OBJECT); }
        protected void regTypeOfFloat(ConditionKey k, Object v) { regQ(k, v, getCValueTypeOfFloat(), "TYPE_OF_FLOAT"); }
        protected abstract ConditionValue getCValueTypeOfFloat();

        public void SetTypeOfDouble_Equal(decimal? v) { regTypeOfDouble(CK_EQ, v); }
        public void SetTypeOfDouble_NotEqual(decimal? v) { regTypeOfDouble(CK_NES, v); }
        public void SetTypeOfDouble_GreaterThan(decimal? v) { regTypeOfDouble(CK_GT, v); }
        public void SetTypeOfDouble_LessThan(decimal? v) { regTypeOfDouble(CK_LT, v); }
        public void SetTypeOfDouble_GreaterEqual(decimal? v) { regTypeOfDouble(CK_GE, v); }
        public void SetTypeOfDouble_LessEqual(decimal? v) { regTypeOfDouble(CK_LE, v); }
        public void SetTypeOfDouble_InScope(IList<decimal?> ls) { regINS<decimal?>(CK_INS, cTL<decimal?>(ls), getCValueTypeOfDouble(), "TYPE_OF_DOUBLE"); }
        public void SetTypeOfDouble_NotInScope(IList<decimal?> ls) { regINS<decimal?>(CK_NINS, cTL<decimal?>(ls), getCValueTypeOfDouble(), "TYPE_OF_DOUBLE"); }
        public void SetTypeOfDouble_IsNull() { regTypeOfDouble(CK_ISN, DUMMY_OBJECT); }
        public void SetTypeOfDouble_IsNotNull() { regTypeOfDouble(CK_ISNN, DUMMY_OBJECT); }
        protected void regTypeOfDouble(ConditionKey k, Object v) { regQ(k, v, getCValueTypeOfDouble(), "TYPE_OF_DOUBLE"); }
        protected abstract ConditionValue getCValueTypeOfDouble();

        public void SetTypeOfDecimalDecimal_Equal(decimal? v) { regTypeOfDecimalDecimal(CK_EQ, v); }
        public void SetTypeOfDecimalDecimal_NotEqual(decimal? v) { regTypeOfDecimalDecimal(CK_NES, v); }
        public void SetTypeOfDecimalDecimal_GreaterThan(decimal? v) { regTypeOfDecimalDecimal(CK_GT, v); }
        public void SetTypeOfDecimalDecimal_LessThan(decimal? v) { regTypeOfDecimalDecimal(CK_LT, v); }
        public void SetTypeOfDecimalDecimal_GreaterEqual(decimal? v) { regTypeOfDecimalDecimal(CK_GE, v); }
        public void SetTypeOfDecimalDecimal_LessEqual(decimal? v) { regTypeOfDecimalDecimal(CK_LE, v); }
        public void SetTypeOfDecimalDecimal_InScope(IList<decimal?> ls) { regINS<decimal?>(CK_INS, cTL<decimal?>(ls), getCValueTypeOfDecimalDecimal(), "TYPE_OF_DECIMAL_DECIMAL"); }
        public void SetTypeOfDecimalDecimal_NotInScope(IList<decimal?> ls) { regINS<decimal?>(CK_NINS, cTL<decimal?>(ls), getCValueTypeOfDecimalDecimal(), "TYPE_OF_DECIMAL_DECIMAL"); }
        public void SetTypeOfDecimalDecimal_IsNull() { regTypeOfDecimalDecimal(CK_ISN, DUMMY_OBJECT); }
        public void SetTypeOfDecimalDecimal_IsNotNull() { regTypeOfDecimalDecimal(CK_ISNN, DUMMY_OBJECT); }
        protected void regTypeOfDecimalDecimal(ConditionKey k, Object v) { regQ(k, v, getCValueTypeOfDecimalDecimal(), "TYPE_OF_DECIMAL_DECIMAL"); }
        protected abstract ConditionValue getCValueTypeOfDecimalDecimal();

        public void SetTypeOfDecimalInteger_Equal(int? v) { regTypeOfDecimalInteger(CK_EQ, v); }
        public void SetTypeOfDecimalInteger_NotEqual(int? v) { regTypeOfDecimalInteger(CK_NES, v); }
        public void SetTypeOfDecimalInteger_GreaterThan(int? v) { regTypeOfDecimalInteger(CK_GT, v); }
        public void SetTypeOfDecimalInteger_LessThan(int? v) { regTypeOfDecimalInteger(CK_LT, v); }
        public void SetTypeOfDecimalInteger_GreaterEqual(int? v) { regTypeOfDecimalInteger(CK_GE, v); }
        public void SetTypeOfDecimalInteger_LessEqual(int? v) { regTypeOfDecimalInteger(CK_LE, v); }
        public void SetTypeOfDecimalInteger_InScope(IList<int?> ls) { regINS<int?>(CK_INS, cTL<int?>(ls), getCValueTypeOfDecimalInteger(), "TYPE_OF_DECIMAL_INTEGER"); }
        public void SetTypeOfDecimalInteger_NotInScope(IList<int?> ls) { regINS<int?>(CK_NINS, cTL<int?>(ls), getCValueTypeOfDecimalInteger(), "TYPE_OF_DECIMAL_INTEGER"); }
        public void SetTypeOfDecimalInteger_IsNull() { regTypeOfDecimalInteger(CK_ISN, DUMMY_OBJECT); }
        public void SetTypeOfDecimalInteger_IsNotNull() { regTypeOfDecimalInteger(CK_ISNN, DUMMY_OBJECT); }
        protected void regTypeOfDecimalInteger(ConditionKey k, Object v) { regQ(k, v, getCValueTypeOfDecimalInteger(), "TYPE_OF_DECIMAL_INTEGER"); }
        protected abstract ConditionValue getCValueTypeOfDecimalInteger();

        public void SetTypeOfDecimalBigint_Equal(long? v) { regTypeOfDecimalBigint(CK_EQ, v); }
        public void SetTypeOfDecimalBigint_NotEqual(long? v) { regTypeOfDecimalBigint(CK_NES, v); }
        public void SetTypeOfDecimalBigint_GreaterThan(long? v) { regTypeOfDecimalBigint(CK_GT, v); }
        public void SetTypeOfDecimalBigint_LessThan(long? v) { regTypeOfDecimalBigint(CK_LT, v); }
        public void SetTypeOfDecimalBigint_GreaterEqual(long? v) { regTypeOfDecimalBigint(CK_GE, v); }
        public void SetTypeOfDecimalBigint_LessEqual(long? v) { regTypeOfDecimalBigint(CK_LE, v); }
        public void SetTypeOfDecimalBigint_InScope(IList<long?> ls) { regINS<long?>(CK_INS, cTL<long?>(ls), getCValueTypeOfDecimalBigint(), "TYPE_OF_DECIMAL_BIGINT"); }
        public void SetTypeOfDecimalBigint_NotInScope(IList<long?> ls) { regINS<long?>(CK_NINS, cTL<long?>(ls), getCValueTypeOfDecimalBigint(), "TYPE_OF_DECIMAL_BIGINT"); }
        public void SetTypeOfDecimalBigint_IsNull() { regTypeOfDecimalBigint(CK_ISN, DUMMY_OBJECT); }
        public void SetTypeOfDecimalBigint_IsNotNull() { regTypeOfDecimalBigint(CK_ISNN, DUMMY_OBJECT); }
        protected void regTypeOfDecimalBigint(ConditionKey k, Object v) { regQ(k, v, getCValueTypeOfDecimalBigint(), "TYPE_OF_DECIMAL_BIGINT"); }
        protected abstract ConditionValue getCValueTypeOfDecimalBigint();

        public void SetTypeOfNumericDecimal_Equal(decimal? v) { regTypeOfNumericDecimal(CK_EQ, v); }
        public void SetTypeOfNumericDecimal_NotEqual(decimal? v) { regTypeOfNumericDecimal(CK_NES, v); }
        public void SetTypeOfNumericDecimal_GreaterThan(decimal? v) { regTypeOfNumericDecimal(CK_GT, v); }
        public void SetTypeOfNumericDecimal_LessThan(decimal? v) { regTypeOfNumericDecimal(CK_LT, v); }
        public void SetTypeOfNumericDecimal_GreaterEqual(decimal? v) { regTypeOfNumericDecimal(CK_GE, v); }
        public void SetTypeOfNumericDecimal_LessEqual(decimal? v) { regTypeOfNumericDecimal(CK_LE, v); }
        public void SetTypeOfNumericDecimal_InScope(IList<decimal?> ls) { regINS<decimal?>(CK_INS, cTL<decimal?>(ls), getCValueTypeOfNumericDecimal(), "TYPE_OF_NUMERIC_DECIMAL"); }
        public void SetTypeOfNumericDecimal_NotInScope(IList<decimal?> ls) { regINS<decimal?>(CK_NINS, cTL<decimal?>(ls), getCValueTypeOfNumericDecimal(), "TYPE_OF_NUMERIC_DECIMAL"); }
        public void SetTypeOfNumericDecimal_IsNull() { regTypeOfNumericDecimal(CK_ISN, DUMMY_OBJECT); }
        public void SetTypeOfNumericDecimal_IsNotNull() { regTypeOfNumericDecimal(CK_ISNN, DUMMY_OBJECT); }
        protected void regTypeOfNumericDecimal(ConditionKey k, Object v) { regQ(k, v, getCValueTypeOfNumericDecimal(), "TYPE_OF_NUMERIC_DECIMAL"); }
        protected abstract ConditionValue getCValueTypeOfNumericDecimal();

        public void SetTypeOfNumericInteger_Equal(int? v) { regTypeOfNumericInteger(CK_EQ, v); }
        public void SetTypeOfNumericInteger_NotEqual(int? v) { regTypeOfNumericInteger(CK_NES, v); }
        public void SetTypeOfNumericInteger_GreaterThan(int? v) { regTypeOfNumericInteger(CK_GT, v); }
        public void SetTypeOfNumericInteger_LessThan(int? v) { regTypeOfNumericInteger(CK_LT, v); }
        public void SetTypeOfNumericInteger_GreaterEqual(int? v) { regTypeOfNumericInteger(CK_GE, v); }
        public void SetTypeOfNumericInteger_LessEqual(int? v) { regTypeOfNumericInteger(CK_LE, v); }
        public void SetTypeOfNumericInteger_InScope(IList<int?> ls) { regINS<int?>(CK_INS, cTL<int?>(ls), getCValueTypeOfNumericInteger(), "TYPE_OF_NUMERIC_INTEGER"); }
        public void SetTypeOfNumericInteger_NotInScope(IList<int?> ls) { regINS<int?>(CK_NINS, cTL<int?>(ls), getCValueTypeOfNumericInteger(), "TYPE_OF_NUMERIC_INTEGER"); }
        public void SetTypeOfNumericInteger_IsNull() { regTypeOfNumericInteger(CK_ISN, DUMMY_OBJECT); }
        public void SetTypeOfNumericInteger_IsNotNull() { regTypeOfNumericInteger(CK_ISNN, DUMMY_OBJECT); }
        protected void regTypeOfNumericInteger(ConditionKey k, Object v) { regQ(k, v, getCValueTypeOfNumericInteger(), "TYPE_OF_NUMERIC_INTEGER"); }
        protected abstract ConditionValue getCValueTypeOfNumericInteger();

        public void SetTypeOfNumericBigint_Equal(long? v) { regTypeOfNumericBigint(CK_EQ, v); }
        public void SetTypeOfNumericBigint_NotEqual(long? v) { regTypeOfNumericBigint(CK_NES, v); }
        public void SetTypeOfNumericBigint_GreaterThan(long? v) { regTypeOfNumericBigint(CK_GT, v); }
        public void SetTypeOfNumericBigint_LessThan(long? v) { regTypeOfNumericBigint(CK_LT, v); }
        public void SetTypeOfNumericBigint_GreaterEqual(long? v) { regTypeOfNumericBigint(CK_GE, v); }
        public void SetTypeOfNumericBigint_LessEqual(long? v) { regTypeOfNumericBigint(CK_LE, v); }
        public void SetTypeOfNumericBigint_InScope(IList<long?> ls) { regINS<long?>(CK_INS, cTL<long?>(ls), getCValueTypeOfNumericBigint(), "TYPE_OF_NUMERIC_BIGINT"); }
        public void SetTypeOfNumericBigint_NotInScope(IList<long?> ls) { regINS<long?>(CK_NINS, cTL<long?>(ls), getCValueTypeOfNumericBigint(), "TYPE_OF_NUMERIC_BIGINT"); }
        public void SetTypeOfNumericBigint_IsNull() { regTypeOfNumericBigint(CK_ISN, DUMMY_OBJECT); }
        public void SetTypeOfNumericBigint_IsNotNull() { regTypeOfNumericBigint(CK_ISNN, DUMMY_OBJECT); }
        protected void regTypeOfNumericBigint(ConditionKey k, Object v) { regQ(k, v, getCValueTypeOfNumericBigint(), "TYPE_OF_NUMERIC_BIGINT"); }
        protected abstract ConditionValue getCValueTypeOfNumericBigint();

        public void SetTypeOfText_Equal(String v) { DoSetTypeOfText_Equal(fRES(v)); }
        protected void DoSetTypeOfText_Equal(String v) { regTypeOfText(CK_EQ, v); }
        public void SetTypeOfText_NotEqual(String v) { DoSetTypeOfText_NotEqual(fRES(v)); }
        protected void DoSetTypeOfText_NotEqual(String v) { regTypeOfText(CK_NES, v); }
        public void SetTypeOfText_InScope(IList<String> ls) { regINS<String>(CK_INS, cTL<String>(ls), getCValueTypeOfText(), "TYPE_OF_TEXT"); }
        public void SetTypeOfText_NotInScope(IList<String> ls) { regINS<String>(CK_NINS, cTL<String>(ls), getCValueTypeOfText(), "TYPE_OF_TEXT"); }
        public void SetTypeOfText_PrefixSearch(String v) { SetTypeOfText_LikeSearch(v, cLSOP()); }
        public void SetTypeOfText_LikeSearch(String v, LikeSearchOption option)
        { regLSQ(CK_LS, fRES(v), getCValueTypeOfText(), "TYPE_OF_TEXT", option); }
        public void SetTypeOfText_NotLikeSearch(String v, LikeSearchOption option)
        { regLSQ(CK_NLS, fRES(v), getCValueTypeOfText(), "TYPE_OF_TEXT", option); }
        public void SetTypeOfText_IsNull() { regTypeOfText(CK_ISN, DUMMY_OBJECT); }
        public void SetTypeOfText_IsNotNull() { regTypeOfText(CK_ISNN, DUMMY_OBJECT); }
        protected void regTypeOfText(ConditionKey k, Object v) { regQ(k, v, getCValueTypeOfText(), "TYPE_OF_TEXT"); }
        protected abstract ConditionValue getCValueTypeOfText();

        public void SetTypeOfTinytext_Equal(String v) { DoSetTypeOfTinytext_Equal(fRES(v)); }
        protected void DoSetTypeOfTinytext_Equal(String v) { regTypeOfTinytext(CK_EQ, v); }
        public void SetTypeOfTinytext_NotEqual(String v) { DoSetTypeOfTinytext_NotEqual(fRES(v)); }
        protected void DoSetTypeOfTinytext_NotEqual(String v) { regTypeOfTinytext(CK_NES, v); }
        public void SetTypeOfTinytext_InScope(IList<String> ls) { regINS<String>(CK_INS, cTL<String>(ls), getCValueTypeOfTinytext(), "TYPE_OF_TINYTEXT"); }
        public void SetTypeOfTinytext_NotInScope(IList<String> ls) { regINS<String>(CK_NINS, cTL<String>(ls), getCValueTypeOfTinytext(), "TYPE_OF_TINYTEXT"); }
        public void SetTypeOfTinytext_PrefixSearch(String v) { SetTypeOfTinytext_LikeSearch(v, cLSOP()); }
        public void SetTypeOfTinytext_LikeSearch(String v, LikeSearchOption option)
        { regLSQ(CK_LS, fRES(v), getCValueTypeOfTinytext(), "TYPE_OF_TINYTEXT", option); }
        public void SetTypeOfTinytext_NotLikeSearch(String v, LikeSearchOption option)
        { regLSQ(CK_NLS, fRES(v), getCValueTypeOfTinytext(), "TYPE_OF_TINYTEXT", option); }
        public void SetTypeOfTinytext_IsNull() { regTypeOfTinytext(CK_ISN, DUMMY_OBJECT); }
        public void SetTypeOfTinytext_IsNotNull() { regTypeOfTinytext(CK_ISNN, DUMMY_OBJECT); }
        protected void regTypeOfTinytext(ConditionKey k, Object v) { regQ(k, v, getCValueTypeOfTinytext(), "TYPE_OF_TINYTEXT"); }
        protected abstract ConditionValue getCValueTypeOfTinytext();

        public void SetTypeOfMediumtext_Equal(String v) { DoSetTypeOfMediumtext_Equal(fRES(v)); }
        protected void DoSetTypeOfMediumtext_Equal(String v) { regTypeOfMediumtext(CK_EQ, v); }
        public void SetTypeOfMediumtext_NotEqual(String v) { DoSetTypeOfMediumtext_NotEqual(fRES(v)); }
        protected void DoSetTypeOfMediumtext_NotEqual(String v) { regTypeOfMediumtext(CK_NES, v); }
        public void SetTypeOfMediumtext_InScope(IList<String> ls) { regINS<String>(CK_INS, cTL<String>(ls), getCValueTypeOfMediumtext(), "TYPE_OF_MEDIUMTEXT"); }
        public void SetTypeOfMediumtext_NotInScope(IList<String> ls) { regINS<String>(CK_NINS, cTL<String>(ls), getCValueTypeOfMediumtext(), "TYPE_OF_MEDIUMTEXT"); }
        public void SetTypeOfMediumtext_PrefixSearch(String v) { SetTypeOfMediumtext_LikeSearch(v, cLSOP()); }
        public void SetTypeOfMediumtext_LikeSearch(String v, LikeSearchOption option)
        { regLSQ(CK_LS, fRES(v), getCValueTypeOfMediumtext(), "TYPE_OF_MEDIUMTEXT", option); }
        public void SetTypeOfMediumtext_NotLikeSearch(String v, LikeSearchOption option)
        { regLSQ(CK_NLS, fRES(v), getCValueTypeOfMediumtext(), "TYPE_OF_MEDIUMTEXT", option); }
        public void SetTypeOfMediumtext_IsNull() { regTypeOfMediumtext(CK_ISN, DUMMY_OBJECT); }
        public void SetTypeOfMediumtext_IsNotNull() { regTypeOfMediumtext(CK_ISNN, DUMMY_OBJECT); }
        protected void regTypeOfMediumtext(ConditionKey k, Object v) { regQ(k, v, getCValueTypeOfMediumtext(), "TYPE_OF_MEDIUMTEXT"); }
        protected abstract ConditionValue getCValueTypeOfMediumtext();

        public void SetTypeOfLongtext_Equal(String v) { DoSetTypeOfLongtext_Equal(fRES(v)); }
        protected void DoSetTypeOfLongtext_Equal(String v) { regTypeOfLongtext(CK_EQ, v); }
        public void SetTypeOfLongtext_NotEqual(String v) { DoSetTypeOfLongtext_NotEqual(fRES(v)); }
        protected void DoSetTypeOfLongtext_NotEqual(String v) { regTypeOfLongtext(CK_NES, v); }
        public void SetTypeOfLongtext_InScope(IList<String> ls) { regINS<String>(CK_INS, cTL<String>(ls), getCValueTypeOfLongtext(), "TYPE_OF_LONGTEXT"); }
        public void SetTypeOfLongtext_NotInScope(IList<String> ls) { regINS<String>(CK_NINS, cTL<String>(ls), getCValueTypeOfLongtext(), "TYPE_OF_LONGTEXT"); }
        public void SetTypeOfLongtext_PrefixSearch(String v) { SetTypeOfLongtext_LikeSearch(v, cLSOP()); }
        public void SetTypeOfLongtext_LikeSearch(String v, LikeSearchOption option)
        { regLSQ(CK_LS, fRES(v), getCValueTypeOfLongtext(), "TYPE_OF_LONGTEXT", option); }
        public void SetTypeOfLongtext_NotLikeSearch(String v, LikeSearchOption option)
        { regLSQ(CK_NLS, fRES(v), getCValueTypeOfLongtext(), "TYPE_OF_LONGTEXT", option); }
        public void SetTypeOfLongtext_IsNull() { regTypeOfLongtext(CK_ISN, DUMMY_OBJECT); }
        public void SetTypeOfLongtext_IsNotNull() { regTypeOfLongtext(CK_ISNN, DUMMY_OBJECT); }
        protected void regTypeOfLongtext(ConditionKey k, Object v) { regQ(k, v, getCValueTypeOfLongtext(), "TYPE_OF_LONGTEXT"); }
        protected abstract ConditionValue getCValueTypeOfLongtext();

        public void SetTypeOfDate_Equal(DateTime? v) { regTypeOfDate(CK_EQ, v); }
        public void SetTypeOfDate_GreaterThan(DateTime? v) { regTypeOfDate(CK_GT, v); }
        public void SetTypeOfDate_LessThan(DateTime? v) { regTypeOfDate(CK_LT, v); }
        public void SetTypeOfDate_GreaterEqual(DateTime? v) { regTypeOfDate(CK_GE, v); }
        public void SetTypeOfDate_LessEqual(DateTime? v) { regTypeOfDate(CK_LE, v); }
        public void SetTypeOfDate_FromTo(DateTime? from, DateTime? to, FromToOption option)
        { regFTQ(from, to, getCValueTypeOfDate(), "TYPE_OF_DATE", option); }
        public void SetTypeOfDate_DateFromTo(DateTime? from, DateTime? to) { SetTypeOfDate_FromTo(from, to, new DateFromToOption()); }
        public void SetTypeOfDate_InScope(IList<DateTime?> ls) { regINS<DateTime?>(CK_INS, cTL<DateTime?>(ls), getCValueTypeOfDate(), "TYPE_OF_DATE"); }
        public void SetTypeOfDate_NotInScope(IList<DateTime?> ls) { regINS<DateTime?>(CK_NINS, cTL<DateTime?>(ls), getCValueTypeOfDate(), "TYPE_OF_DATE"); }
        public void SetTypeOfDate_IsNull() { regTypeOfDate(CK_ISN, DUMMY_OBJECT); }
        public void SetTypeOfDate_IsNotNull() { regTypeOfDate(CK_ISNN, DUMMY_OBJECT); }
        protected void regTypeOfDate(ConditionKey k, Object v) { regQ(k, v, getCValueTypeOfDate(), "TYPE_OF_DATE"); }
        protected abstract ConditionValue getCValueTypeOfDate();

        public void SetTypeOfDatetime_Equal(DateTime? v) { regTypeOfDatetime(CK_EQ, v); }
        public void SetTypeOfDatetime_GreaterThan(DateTime? v) { regTypeOfDatetime(CK_GT, v); }
        public void SetTypeOfDatetime_LessThan(DateTime? v) { regTypeOfDatetime(CK_LT, v); }
        public void SetTypeOfDatetime_GreaterEqual(DateTime? v) { regTypeOfDatetime(CK_GE, v); }
        public void SetTypeOfDatetime_LessEqual(DateTime? v) { regTypeOfDatetime(CK_LE, v); }
        public void SetTypeOfDatetime_FromTo(DateTime? from, DateTime? to, FromToOption option)
        { regFTQ(from, to, getCValueTypeOfDatetime(), "TYPE_OF_DATETIME", option); }
        public void SetTypeOfDatetime_DateFromTo(DateTime? from, DateTime? to) { SetTypeOfDatetime_FromTo(from, to, new DateFromToOption()); }
        public void SetTypeOfDatetime_InScope(IList<DateTime?> ls) { regINS<DateTime?>(CK_INS, cTL<DateTime?>(ls), getCValueTypeOfDatetime(), "TYPE_OF_DATETIME"); }
        public void SetTypeOfDatetime_NotInScope(IList<DateTime?> ls) { regINS<DateTime?>(CK_NINS, cTL<DateTime?>(ls), getCValueTypeOfDatetime(), "TYPE_OF_DATETIME"); }
        public void SetTypeOfDatetime_IsNull() { regTypeOfDatetime(CK_ISN, DUMMY_OBJECT); }
        public void SetTypeOfDatetime_IsNotNull() { regTypeOfDatetime(CK_ISNN, DUMMY_OBJECT); }
        protected void regTypeOfDatetime(ConditionKey k, Object v) { regQ(k, v, getCValueTypeOfDatetime(), "TYPE_OF_DATETIME"); }
        protected abstract ConditionValue getCValueTypeOfDatetime();

        public void SetTypeOfTimestamp_Equal(DateTime? v) { regTypeOfTimestamp(CK_EQ, v); }
        public void SetTypeOfTimestamp_GreaterThan(DateTime? v) { regTypeOfTimestamp(CK_GT, v); }
        public void SetTypeOfTimestamp_LessThan(DateTime? v) { regTypeOfTimestamp(CK_LT, v); }
        public void SetTypeOfTimestamp_GreaterEqual(DateTime? v) { regTypeOfTimestamp(CK_GE, v); }
        public void SetTypeOfTimestamp_LessEqual(DateTime? v) { regTypeOfTimestamp(CK_LE, v); }
        public void SetTypeOfTimestamp_FromTo(DateTime? from, DateTime? to, FromToOption option)
        { regFTQ(from, to, getCValueTypeOfTimestamp(), "TYPE_OF_TIMESTAMP", option); }
        public void SetTypeOfTimestamp_DateFromTo(DateTime? from, DateTime? to) { SetTypeOfTimestamp_FromTo(from, to, new DateFromToOption()); }
        public void SetTypeOfTimestamp_InScope(IList<DateTime?> ls) { regINS<DateTime?>(CK_INS, cTL<DateTime?>(ls), getCValueTypeOfTimestamp(), "TYPE_OF_TIMESTAMP"); }
        public void SetTypeOfTimestamp_NotInScope(IList<DateTime?> ls) { regINS<DateTime?>(CK_NINS, cTL<DateTime?>(ls), getCValueTypeOfTimestamp(), "TYPE_OF_TIMESTAMP"); }
        protected void regTypeOfTimestamp(ConditionKey k, Object v) { regQ(k, v, getCValueTypeOfTimestamp(), "TYPE_OF_TIMESTAMP"); }
        protected abstract ConditionValue getCValueTypeOfTimestamp();

        public void SetTypeOfTime_Equal(DateTime? v) { regTypeOfTime(CK_EQ, v); }
        public void SetTypeOfTime_GreaterThan(DateTime? v) { regTypeOfTime(CK_GT, v); }
        public void SetTypeOfTime_LessThan(DateTime? v) { regTypeOfTime(CK_LT, v); }
        public void SetTypeOfTime_GreaterEqual(DateTime? v) { regTypeOfTime(CK_GE, v); }
        public void SetTypeOfTime_LessEqual(DateTime? v) { regTypeOfTime(CK_LE, v); }
        public void SetTypeOfTime_InScope(IList<DateTime?> ls) { regINS<DateTime?>(CK_INS, cTL<DateTime?>(ls), getCValueTypeOfTime(), "TYPE_OF_TIME"); }
        public void SetTypeOfTime_NotInScope(IList<DateTime?> ls) { regINS<DateTime?>(CK_NINS, cTL<DateTime?>(ls), getCValueTypeOfTime(), "TYPE_OF_TIME"); }
        public void SetTypeOfTime_IsNull() { regTypeOfTime(CK_ISN, DUMMY_OBJECT); }
        public void SetTypeOfTime_IsNotNull() { regTypeOfTime(CK_ISNN, DUMMY_OBJECT); }
        protected void regTypeOfTime(ConditionKey k, Object v) { regQ(k, v, getCValueTypeOfTime(), "TYPE_OF_TIME"); }
        protected abstract ConditionValue getCValueTypeOfTime();

        public void SetTypeOfYear_Equal(DateTime? v) { regTypeOfYear(CK_EQ, v); }
        public void SetTypeOfYear_GreaterThan(DateTime? v) { regTypeOfYear(CK_GT, v); }
        public void SetTypeOfYear_LessThan(DateTime? v) { regTypeOfYear(CK_LT, v); }
        public void SetTypeOfYear_GreaterEqual(DateTime? v) { regTypeOfYear(CK_GE, v); }
        public void SetTypeOfYear_LessEqual(DateTime? v) { regTypeOfYear(CK_LE, v); }
        public void SetTypeOfYear_FromTo(DateTime? from, DateTime? to, FromToOption option)
        { regFTQ(from, to, getCValueTypeOfYear(), "TYPE_OF_YEAR", option); }
        public void SetTypeOfYear_DateFromTo(DateTime? from, DateTime? to) { SetTypeOfYear_FromTo(from, to, new DateFromToOption()); }
        public void SetTypeOfYear_InScope(IList<DateTime?> ls) { regINS<DateTime?>(CK_INS, cTL<DateTime?>(ls), getCValueTypeOfYear(), "TYPE_OF_YEAR"); }
        public void SetTypeOfYear_NotInScope(IList<DateTime?> ls) { regINS<DateTime?>(CK_NINS, cTL<DateTime?>(ls), getCValueTypeOfYear(), "TYPE_OF_YEAR"); }
        public void SetTypeOfYear_IsNull() { regTypeOfYear(CK_ISN, DUMMY_OBJECT); }
        public void SetTypeOfYear_IsNotNull() { regTypeOfYear(CK_ISNN, DUMMY_OBJECT); }
        protected void regTypeOfYear(ConditionKey k, Object v) { regQ(k, v, getCValueTypeOfYear(), "TYPE_OF_YEAR"); }
        protected abstract ConditionValue getCValueTypeOfYear();
        public void SetTypeOfBlob_IsNull() { regTypeOfBlob(CK_ISN, DUMMY_OBJECT); }
        public void SetTypeOfBlob_IsNotNull() { regTypeOfBlob(CK_ISNN, DUMMY_OBJECT); }
        protected void regTypeOfBlob(ConditionKey k, Object v) { regQ(k, v, getCValueTypeOfBlob(), "TYPE_OF_BLOB"); }
        protected abstract ConditionValue getCValueTypeOfBlob();
        public void SetTypeOfTinyblob_IsNull() { regTypeOfTinyblob(CK_ISN, DUMMY_OBJECT); }
        public void SetTypeOfTinyblob_IsNotNull() { regTypeOfTinyblob(CK_ISNN, DUMMY_OBJECT); }
        protected void regTypeOfTinyblob(ConditionKey k, Object v) { regQ(k, v, getCValueTypeOfTinyblob(), "TYPE_OF_TINYBLOB"); }
        protected abstract ConditionValue getCValueTypeOfTinyblob();
        public void SetTypeOfMediumblob_IsNull() { regTypeOfMediumblob(CK_ISN, DUMMY_OBJECT); }
        public void SetTypeOfMediumblob_IsNotNull() { regTypeOfMediumblob(CK_ISNN, DUMMY_OBJECT); }
        protected void regTypeOfMediumblob(ConditionKey k, Object v) { regQ(k, v, getCValueTypeOfMediumblob(), "TYPE_OF_MEDIUMBLOB"); }
        protected abstract ConditionValue getCValueTypeOfMediumblob();
        public void SetTypeOfLongblob_IsNull() { regTypeOfLongblob(CK_ISN, DUMMY_OBJECT); }
        public void SetTypeOfLongblob_IsNotNull() { regTypeOfLongblob(CK_ISNN, DUMMY_OBJECT); }
        protected void regTypeOfLongblob(ConditionKey k, Object v) { regQ(k, v, getCValueTypeOfLongblob(), "TYPE_OF_LONGBLOB"); }
        protected abstract ConditionValue getCValueTypeOfLongblob();
        public void SetTypeOfBinary_IsNull() { regTypeOfBinary(CK_ISN, DUMMY_OBJECT); }
        public void SetTypeOfBinary_IsNotNull() { regTypeOfBinary(CK_ISNN, DUMMY_OBJECT); }
        protected void regTypeOfBinary(ConditionKey k, Object v) { regQ(k, v, getCValueTypeOfBinary(), "TYPE_OF_BINARY"); }
        protected abstract ConditionValue getCValueTypeOfBinary();
        public void SetTypeOfVarbinary_IsNull() { regTypeOfVarbinary(CK_ISN, DUMMY_OBJECT); }
        public void SetTypeOfVarbinary_IsNotNull() { regTypeOfVarbinary(CK_ISNN, DUMMY_OBJECT); }
        protected void regTypeOfVarbinary(ConditionKey k, Object v) { regQ(k, v, getCValueTypeOfVarbinary(), "TYPE_OF_VARBINARY"); }
        protected abstract ConditionValue getCValueTypeOfVarbinary();

        public void SetTypeOfEnum_Equal(String v) { DoSetTypeOfEnum_Equal(fRES(v)); }
        protected void DoSetTypeOfEnum_Equal(String v) { regTypeOfEnum(CK_EQ, v); }
        public void SetTypeOfEnum_NotEqual(String v) { DoSetTypeOfEnum_NotEqual(fRES(v)); }
        protected void DoSetTypeOfEnum_NotEqual(String v) { regTypeOfEnum(CK_NES, v); }
        public void SetTypeOfEnum_InScope(IList<String> ls) { regINS<String>(CK_INS, cTL<String>(ls), getCValueTypeOfEnum(), "TYPE_OF_ENUM"); }
        public void SetTypeOfEnum_NotInScope(IList<String> ls) { regINS<String>(CK_NINS, cTL<String>(ls), getCValueTypeOfEnum(), "TYPE_OF_ENUM"); }
        public void SetTypeOfEnum_PrefixSearch(String v) { SetTypeOfEnum_LikeSearch(v, cLSOP()); }
        public void SetTypeOfEnum_LikeSearch(String v, LikeSearchOption option)
        { regLSQ(CK_LS, fRES(v), getCValueTypeOfEnum(), "TYPE_OF_ENUM", option); }
        public void SetTypeOfEnum_NotLikeSearch(String v, LikeSearchOption option)
        { regLSQ(CK_NLS, fRES(v), getCValueTypeOfEnum(), "TYPE_OF_ENUM", option); }
        public void SetTypeOfEnum_IsNull() { regTypeOfEnum(CK_ISN, DUMMY_OBJECT); }
        public void SetTypeOfEnum_IsNotNull() { regTypeOfEnum(CK_ISNN, DUMMY_OBJECT); }
        protected void regTypeOfEnum(ConditionKey k, Object v) { regQ(k, v, getCValueTypeOfEnum(), "TYPE_OF_ENUM"); }
        protected abstract ConditionValue getCValueTypeOfEnum();

        public void SetTypeOfSet_Equal(String v) { DoSetTypeOfSet_Equal(fRES(v)); }
        protected void DoSetTypeOfSet_Equal(String v) { regTypeOfSet(CK_EQ, v); }
        public void SetTypeOfSet_NotEqual(String v) { DoSetTypeOfSet_NotEqual(fRES(v)); }
        protected void DoSetTypeOfSet_NotEqual(String v) { regTypeOfSet(CK_NES, v); }
        public void SetTypeOfSet_InScope(IList<String> ls) { regINS<String>(CK_INS, cTL<String>(ls), getCValueTypeOfSet(), "TYPE_OF_SET"); }
        public void SetTypeOfSet_NotInScope(IList<String> ls) { regINS<String>(CK_NINS, cTL<String>(ls), getCValueTypeOfSet(), "TYPE_OF_SET"); }
        public void SetTypeOfSet_PrefixSearch(String v) { SetTypeOfSet_LikeSearch(v, cLSOP()); }
        public void SetTypeOfSet_LikeSearch(String v, LikeSearchOption option)
        { regLSQ(CK_LS, fRES(v), getCValueTypeOfSet(), "TYPE_OF_SET", option); }
        public void SetTypeOfSet_NotLikeSearch(String v, LikeSearchOption option)
        { regLSQ(CK_NLS, fRES(v), getCValueTypeOfSet(), "TYPE_OF_SET", option); }
        public void SetTypeOfSet_IsNull() { regTypeOfSet(CK_ISN, DUMMY_OBJECT); }
        public void SetTypeOfSet_IsNotNull() { regTypeOfSet(CK_ISNN, DUMMY_OBJECT); }
        protected void regTypeOfSet(ConditionKey k, Object v) { regQ(k, v, getCValueTypeOfSet(), "TYPE_OF_SET"); }
        protected abstract ConditionValue getCValueTypeOfSet();

        // ===================================================================================
        //                                                                    Scalar Condition
        //                                                                    ================
        public SSQFunction<VendorCheckCB> Scalar_Equal() {
            return xcreateSSQFunction("=");
        }

        public SSQFunction<VendorCheckCB> Scalar_NotEqual() {
            return xcreateSSQFunction("<>");
        }

        public SSQFunction<VendorCheckCB> Scalar_GreaterEqual() {
            return xcreateSSQFunction(">=");
        }

        public SSQFunction<VendorCheckCB> Scalar_GreaterThan() {
            return xcreateSSQFunction(">");
        }

        public SSQFunction<VendorCheckCB> Scalar_LessEqual() {
            return xcreateSSQFunction("<=");
        }

        public SSQFunction<VendorCheckCB> Scalar_LessThan() {
            return xcreateSSQFunction("<");
        }

        protected SSQFunction<VendorCheckCB> xcreateSSQFunction(String operand) {
            return new SSQFunction<VendorCheckCB>(delegate(String function, SubQuery<VendorCheckCB> subQuery) {
                xscalarSubQuery(function, subQuery, operand);
            });
        }

        protected void xscalarSubQuery(String function, SubQuery<VendorCheckCB> subQuery, String operand) {
            assertObjectNotNull("subQuery<VendorCheckCB>", subQuery);
            VendorCheckCB cb = new VendorCheckCB(); cb.xsetupForScalarCondition(this); subQuery.Invoke(cb);
            String subQueryPropertyName = keepScalarSubQuery(cb.Query()); // for saving query-value.
            registerScalarSubQuery(function, cb.Query(), subQueryPropertyName, operand);
        }
        public abstract String keepScalarSubQuery(VendorCheckCQ subQuery);

        // ===============================================================================
        //                                                                  MySelf InScope
        //                                                                  ==============
        public void MyselfInScope(SubQuery<VendorCheckCB> subQuery) {
            assertObjectNotNull("subQuery<VendorCheckCB>", subQuery);
            VendorCheckCB cb = new VendorCheckCB(); cb.xsetupForInScopeRelation(this); subQuery.Invoke(cb);
            String subQueryPropertyName = keepMyselfInScopeSubQuery(cb.Query()); // for saving query-value.
            registerInScopeSubQuery(cb.Query(), "VENDOR_CHECK_ID", "VENDOR_CHECK_ID", subQueryPropertyName);
        }
        public abstract String keepMyselfInScopeSubQuery(VendorCheckCQ subQuery);

        public override String ToString() { return xgetSqlClause().getClause(); }
    }
}
