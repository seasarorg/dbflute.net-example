
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

        public override String getTableDbName() { return "VENDOR_CHECK"; }
        public override String getTableSqlName() { return "VENDOR_CHECK"; }

        public void SetVendorCheckId_Equal(long? v) { regVendorCheckId(CK_EQ, v); }
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

        public void SetDecimalDigit_Equal(decimal? v) { regDecimalDigit(CK_EQ, v); }
        public void SetDecimalDigit_GreaterThan(decimal? v) { regDecimalDigit(CK_GT, v); }
        public void SetDecimalDigit_LessThan(decimal? v) { regDecimalDigit(CK_LT, v); }
        public void SetDecimalDigit_GreaterEqual(decimal? v) { regDecimalDigit(CK_GE, v); }
        public void SetDecimalDigit_LessEqual(decimal? v) { regDecimalDigit(CK_LE, v); }
        public void SetDecimalDigit_InScope(IList<decimal?> ls) { regINS<decimal?>(CK_INS, cTL<decimal?>(ls), getCValueDecimalDigit(), "DECIMAL_DIGIT"); }
        public void SetDecimalDigit_NotInScope(IList<decimal?> ls) { regINS<decimal?>(CK_NINS, cTL<decimal?>(ls), getCValueDecimalDigit(), "DECIMAL_DIGIT"); }
        protected void regDecimalDigit(ConditionKey k, Object v) { regQ(k, v, getCValueDecimalDigit(), "DECIMAL_DIGIT"); }
        protected abstract ConditionValue getCValueDecimalDigit();

        public void SetIntegerNonDigit_Equal(int? v) { regIntegerNonDigit(CK_EQ, v); }
        public void SetIntegerNonDigit_GreaterThan(int? v) { regIntegerNonDigit(CK_GT, v); }
        public void SetIntegerNonDigit_LessThan(int? v) { regIntegerNonDigit(CK_LT, v); }
        public void SetIntegerNonDigit_GreaterEqual(int? v) { regIntegerNonDigit(CK_GE, v); }
        public void SetIntegerNonDigit_LessEqual(int? v) { regIntegerNonDigit(CK_LE, v); }
        public void SetIntegerNonDigit_InScope(IList<int?> ls) { regINS<int?>(CK_INS, cTL<int?>(ls), getCValueIntegerNonDigit(), "INTEGER_NON_DIGIT"); }
        public void SetIntegerNonDigit_NotInScope(IList<int?> ls) { regINS<int?>(CK_NINS, cTL<int?>(ls), getCValueIntegerNonDigit(), "INTEGER_NON_DIGIT"); }
        protected void regIntegerNonDigit(ConditionKey k, Object v) { regQ(k, v, getCValueIntegerNonDigit(), "INTEGER_NON_DIGIT"); }
        protected abstract ConditionValue getCValueIntegerNonDigit();

        public void SetLargeCharacter_Equal(String v) { DoSetLargeCharacter_Equal(fRES(v)); }
        protected void DoSetLargeCharacter_Equal(String v) { regLargeCharacter(CK_EQ, v); }
        public void SetLargeCharacter_NotEqual(String v) { DoSetLargeCharacter_NotEqual(fRES(v)); }
        protected void DoSetLargeCharacter_NotEqual(String v) { regLargeCharacter(CK_NES, v); }
        public void SetLargeCharacter_InScope(IList<String> ls) { regINS<String>(CK_INS, cTL<String>(ls), getCValueLargeCharacter(), "LARGE_CHARACTER"); }
        public void SetLargeCharacter_NotInScope(IList<String> ls) { regINS<String>(CK_NINS, cTL<String>(ls), getCValueLargeCharacter(), "LARGE_CHARACTER"); }
        public void SetLargeCharacter_PrefixSearch(String v) { SetLargeCharacter_LikeSearch(v, cLSOP()); }
        public void SetLargeCharacter_LikeSearch(String v, LikeSearchOption option)
        { regLSQ(CK_LS, fRES(v), getCValueLargeCharacter(), "LARGE_CHARACTER", option); }
        public void SetLargeCharacter_NotLikeSearch(String v, LikeSearchOption option)
        { regLSQ(CK_NLS, fRES(v), getCValueLargeCharacter(), "LARGE_CHARACTER", option); }
        public void SetLargeCharacter_IsNull() { regLargeCharacter(CK_ISN, DUMMY_OBJECT); }
        public void SetLargeCharacter_IsNotNull() { regLargeCharacter(CK_ISNN, DUMMY_OBJECT); }
        protected void regLargeCharacter(ConditionKey k, Object v) { regQ(k, v, getCValueLargeCharacter(), "LARGE_CHARACTER"); }
        protected abstract ConditionValue getCValueLargeCharacter();

        public void SetTypeOfChar_Equal(String v) { DoSetTypeOfChar_Equal(fRES(v)); }
        protected void DoSetTypeOfChar_Equal(String v) { regTypeOfChar(CK_EQ, v); }
        public void SetTypeOfChar_NotEqual(String v) { DoSetTypeOfChar_NotEqual(fRES(v)); }
        protected void DoSetTypeOfChar_NotEqual(String v) { regTypeOfChar(CK_NES, v); }
        public void SetTypeOfChar_InScope(IList<String> ls) { regINS<String>(CK_INS, cTL<String>(ls), getCValueTypeOfChar(), "TYPE_OF_CHAR"); }
        public void SetTypeOfChar_NotInScope(IList<String> ls) { regINS<String>(CK_NINS, cTL<String>(ls), getCValueTypeOfChar(), "TYPE_OF_CHAR"); }
        public void SetTypeOfChar_PrefixSearch(String v) { SetTypeOfChar_LikeSearch(v, cLSOP()); }
        public void SetTypeOfChar_LikeSearch(String v, LikeSearchOption option)
        { regLSQ(CK_LS, fRES(v), getCValueTypeOfChar(), "TYPE_OF_CHAR", option); }
        public void SetTypeOfChar_NotLikeSearch(String v, LikeSearchOption option)
        { regLSQ(CK_NLS, fRES(v), getCValueTypeOfChar(), "TYPE_OF_CHAR", option); }
        public void SetTypeOfChar_IsNull() { regTypeOfChar(CK_ISN, DUMMY_OBJECT); }
        public void SetTypeOfChar_IsNotNull() { regTypeOfChar(CK_ISNN, DUMMY_OBJECT); }
        protected void regTypeOfChar(ConditionKey k, Object v) { regQ(k, v, getCValueTypeOfChar(), "TYPE_OF_CHAR"); }
        protected abstract ConditionValue getCValueTypeOfChar();

        public void SetTypeOfNchar_Equal(String v) { DoSetTypeOfNchar_Equal(fRES(v)); }
        protected void DoSetTypeOfNchar_Equal(String v) { regTypeOfNchar(CK_EQ, v); }
        public void SetTypeOfNchar_NotEqual(String v) { DoSetTypeOfNchar_NotEqual(fRES(v)); }
        protected void DoSetTypeOfNchar_NotEqual(String v) { regTypeOfNchar(CK_NES, v); }
        public void SetTypeOfNchar_InScope(IList<String> ls) { regINS<String>(CK_INS, cTL<String>(ls), getCValueTypeOfNchar(), "TYPE_OF_NCHAR"); }
        public void SetTypeOfNchar_NotInScope(IList<String> ls) { regINS<String>(CK_NINS, cTL<String>(ls), getCValueTypeOfNchar(), "TYPE_OF_NCHAR"); }
        public void SetTypeOfNchar_PrefixSearch(String v) { SetTypeOfNchar_LikeSearch(v, cLSOP()); }
        public void SetTypeOfNchar_LikeSearch(String v, LikeSearchOption option)
        { regLSQ(CK_LS, fRES(v), getCValueTypeOfNchar(), "TYPE_OF_NCHAR", option); }
        public void SetTypeOfNchar_NotLikeSearch(String v, LikeSearchOption option)
        { regLSQ(CK_NLS, fRES(v), getCValueTypeOfNchar(), "TYPE_OF_NCHAR", option); }
        public void SetTypeOfNchar_IsNull() { regTypeOfNchar(CK_ISN, DUMMY_OBJECT); }
        public void SetTypeOfNchar_IsNotNull() { regTypeOfNchar(CK_ISNN, DUMMY_OBJECT); }
        protected void regTypeOfNchar(ConditionKey k, Object v) { regQ(k, v, getCValueTypeOfNchar(), "TYPE_OF_NCHAR"); }
        protected abstract ConditionValue getCValueTypeOfNchar();

        public void SetTypeOfVarchar2_Equal(String v) { DoSetTypeOfVarchar2_Equal(fRES(v)); }
        protected void DoSetTypeOfVarchar2_Equal(String v) { regTypeOfVarchar2(CK_EQ, v); }
        public void SetTypeOfVarchar2_NotEqual(String v) { DoSetTypeOfVarchar2_NotEqual(fRES(v)); }
        protected void DoSetTypeOfVarchar2_NotEqual(String v) { regTypeOfVarchar2(CK_NES, v); }
        public void SetTypeOfVarchar2_InScope(IList<String> ls) { regINS<String>(CK_INS, cTL<String>(ls), getCValueTypeOfVarchar2(), "TYPE_OF_VARCHAR2"); }
        public void SetTypeOfVarchar2_NotInScope(IList<String> ls) { regINS<String>(CK_NINS, cTL<String>(ls), getCValueTypeOfVarchar2(), "TYPE_OF_VARCHAR2"); }
        public void SetTypeOfVarchar2_PrefixSearch(String v) { SetTypeOfVarchar2_LikeSearch(v, cLSOP()); }
        public void SetTypeOfVarchar2_LikeSearch(String v, LikeSearchOption option)
        { regLSQ(CK_LS, fRES(v), getCValueTypeOfVarchar2(), "TYPE_OF_VARCHAR2", option); }
        public void SetTypeOfVarchar2_NotLikeSearch(String v, LikeSearchOption option)
        { regLSQ(CK_NLS, fRES(v), getCValueTypeOfVarchar2(), "TYPE_OF_VARCHAR2", option); }
        public void SetTypeOfVarchar2_IsNull() { regTypeOfVarchar2(CK_ISN, DUMMY_OBJECT); }
        public void SetTypeOfVarchar2_IsNotNull() { regTypeOfVarchar2(CK_ISNN, DUMMY_OBJECT); }
        protected void regTypeOfVarchar2(ConditionKey k, Object v) { regQ(k, v, getCValueTypeOfVarchar2(), "TYPE_OF_VARCHAR2"); }
        protected abstract ConditionValue getCValueTypeOfVarchar2();

        public void SetTypeOfVarchar2Max_Equal(String v) { DoSetTypeOfVarchar2Max_Equal(fRES(v)); }
        protected void DoSetTypeOfVarchar2Max_Equal(String v) { regTypeOfVarchar2Max(CK_EQ, v); }
        public void SetTypeOfVarchar2Max_NotEqual(String v) { DoSetTypeOfVarchar2Max_NotEqual(fRES(v)); }
        protected void DoSetTypeOfVarchar2Max_NotEqual(String v) { regTypeOfVarchar2Max(CK_NES, v); }
        public void SetTypeOfVarchar2Max_InScope(IList<String> ls) { regINS<String>(CK_INS, cTL<String>(ls), getCValueTypeOfVarchar2Max(), "TYPE_OF_VARCHAR2_MAX"); }
        public void SetTypeOfVarchar2Max_NotInScope(IList<String> ls) { regINS<String>(CK_NINS, cTL<String>(ls), getCValueTypeOfVarchar2Max(), "TYPE_OF_VARCHAR2_MAX"); }
        public void SetTypeOfVarchar2Max_PrefixSearch(String v) { SetTypeOfVarchar2Max_LikeSearch(v, cLSOP()); }
        public void SetTypeOfVarchar2Max_LikeSearch(String v, LikeSearchOption option)
        { regLSQ(CK_LS, fRES(v), getCValueTypeOfVarchar2Max(), "TYPE_OF_VARCHAR2_MAX", option); }
        public void SetTypeOfVarchar2Max_NotLikeSearch(String v, LikeSearchOption option)
        { regLSQ(CK_NLS, fRES(v), getCValueTypeOfVarchar2Max(), "TYPE_OF_VARCHAR2_MAX", option); }
        public void SetTypeOfVarchar2Max_IsNull() { regTypeOfVarchar2Max(CK_ISN, DUMMY_OBJECT); }
        public void SetTypeOfVarchar2Max_IsNotNull() { regTypeOfVarchar2Max(CK_ISNN, DUMMY_OBJECT); }
        protected void regTypeOfVarchar2Max(ConditionKey k, Object v) { regQ(k, v, getCValueTypeOfVarchar2Max(), "TYPE_OF_VARCHAR2_MAX"); }
        protected abstract ConditionValue getCValueTypeOfVarchar2Max();

        public void SetTypeOfNvarchar2_Equal(String v) { DoSetTypeOfNvarchar2_Equal(fRES(v)); }
        protected void DoSetTypeOfNvarchar2_Equal(String v) { regTypeOfNvarchar2(CK_EQ, v); }
        public void SetTypeOfNvarchar2_NotEqual(String v) { DoSetTypeOfNvarchar2_NotEqual(fRES(v)); }
        protected void DoSetTypeOfNvarchar2_NotEqual(String v) { regTypeOfNvarchar2(CK_NES, v); }
        public void SetTypeOfNvarchar2_InScope(IList<String> ls) { regINS<String>(CK_INS, cTL<String>(ls), getCValueTypeOfNvarchar2(), "TYPE_OF_NVARCHAR2"); }
        public void SetTypeOfNvarchar2_NotInScope(IList<String> ls) { regINS<String>(CK_NINS, cTL<String>(ls), getCValueTypeOfNvarchar2(), "TYPE_OF_NVARCHAR2"); }
        public void SetTypeOfNvarchar2_PrefixSearch(String v) { SetTypeOfNvarchar2_LikeSearch(v, cLSOP()); }
        public void SetTypeOfNvarchar2_LikeSearch(String v, LikeSearchOption option)
        { regLSQ(CK_LS, fRES(v), getCValueTypeOfNvarchar2(), "TYPE_OF_NVARCHAR2", option); }
        public void SetTypeOfNvarchar2_NotLikeSearch(String v, LikeSearchOption option)
        { regLSQ(CK_NLS, fRES(v), getCValueTypeOfNvarchar2(), "TYPE_OF_NVARCHAR2", option); }
        public void SetTypeOfNvarchar2_IsNull() { regTypeOfNvarchar2(CK_ISN, DUMMY_OBJECT); }
        public void SetTypeOfNvarchar2_IsNotNull() { regTypeOfNvarchar2(CK_ISNN, DUMMY_OBJECT); }
        protected void regTypeOfNvarchar2(ConditionKey k, Object v) { regQ(k, v, getCValueTypeOfNvarchar2(), "TYPE_OF_NVARCHAR2"); }
        protected abstract ConditionValue getCValueTypeOfNvarchar2();

        public void SetTypeOfClob_Equal(String v) { DoSetTypeOfClob_Equal(fRES(v)); }
        protected void DoSetTypeOfClob_Equal(String v) { regTypeOfClob(CK_EQ, v); }
        public void SetTypeOfClob_NotEqual(String v) { DoSetTypeOfClob_NotEqual(fRES(v)); }
        protected void DoSetTypeOfClob_NotEqual(String v) { regTypeOfClob(CK_NES, v); }
        public void SetTypeOfClob_InScope(IList<String> ls) { regINS<String>(CK_INS, cTL<String>(ls), getCValueTypeOfClob(), "TYPE_OF_CLOB"); }
        public void SetTypeOfClob_NotInScope(IList<String> ls) { regINS<String>(CK_NINS, cTL<String>(ls), getCValueTypeOfClob(), "TYPE_OF_CLOB"); }
        public void SetTypeOfClob_PrefixSearch(String v) { SetTypeOfClob_LikeSearch(v, cLSOP()); }
        public void SetTypeOfClob_LikeSearch(String v, LikeSearchOption option)
        { regLSQ(CK_LS, fRES(v), getCValueTypeOfClob(), "TYPE_OF_CLOB", option); }
        public void SetTypeOfClob_NotLikeSearch(String v, LikeSearchOption option)
        { regLSQ(CK_NLS, fRES(v), getCValueTypeOfClob(), "TYPE_OF_CLOB", option); }
        public void SetTypeOfClob_IsNull() { regTypeOfClob(CK_ISN, DUMMY_OBJECT); }
        public void SetTypeOfClob_IsNotNull() { regTypeOfClob(CK_ISNN, DUMMY_OBJECT); }
        protected void regTypeOfClob(ConditionKey k, Object v) { regQ(k, v, getCValueTypeOfClob(), "TYPE_OF_CLOB"); }
        protected abstract ConditionValue getCValueTypeOfClob();

        public void SetTypeOfNclob_Equal(String v) { DoSetTypeOfNclob_Equal(fRES(v)); }
        protected void DoSetTypeOfNclob_Equal(String v) { regTypeOfNclob(CK_EQ, v); }
        public void SetTypeOfNclob_NotEqual(String v) { DoSetTypeOfNclob_NotEqual(fRES(v)); }
        protected void DoSetTypeOfNclob_NotEqual(String v) { regTypeOfNclob(CK_NES, v); }
        public void SetTypeOfNclob_InScope(IList<String> ls) { regINS<String>(CK_INS, cTL<String>(ls), getCValueTypeOfNclob(), "TYPE_OF_NCLOB"); }
        public void SetTypeOfNclob_NotInScope(IList<String> ls) { regINS<String>(CK_NINS, cTL<String>(ls), getCValueTypeOfNclob(), "TYPE_OF_NCLOB"); }
        public void SetTypeOfNclob_PrefixSearch(String v) { SetTypeOfNclob_LikeSearch(v, cLSOP()); }
        public void SetTypeOfNclob_LikeSearch(String v, LikeSearchOption option)
        { regLSQ(CK_LS, fRES(v), getCValueTypeOfNclob(), "TYPE_OF_NCLOB", option); }
        public void SetTypeOfNclob_NotLikeSearch(String v, LikeSearchOption option)
        { regLSQ(CK_NLS, fRES(v), getCValueTypeOfNclob(), "TYPE_OF_NCLOB", option); }
        public void SetTypeOfNclob_IsNull() { regTypeOfNclob(CK_ISN, DUMMY_OBJECT); }
        public void SetTypeOfNclob_IsNotNull() { regTypeOfNclob(CK_ISNN, DUMMY_OBJECT); }
        protected void regTypeOfNclob(ConditionKey k, Object v) { regQ(k, v, getCValueTypeOfNclob(), "TYPE_OF_NCLOB"); }
        protected abstract ConditionValue getCValueTypeOfNclob();

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
        public void SetTypeOfTimestamp_IsNull() { regTypeOfTimestamp(CK_ISN, DUMMY_OBJECT); }
        public void SetTypeOfTimestamp_IsNotNull() { regTypeOfTimestamp(CK_ISNN, DUMMY_OBJECT); }
        protected void regTypeOfTimestamp(ConditionKey k, Object v) { regQ(k, v, getCValueTypeOfTimestamp(), "TYPE_OF_TIMESTAMP"); }
        protected abstract ConditionValue getCValueTypeOfTimestamp();
        public void SetTypeOfBlob_IsNull() { regTypeOfBlob(CK_ISN, DUMMY_OBJECT); }
        public void SetTypeOfBlob_IsNotNull() { regTypeOfBlob(CK_ISNN, DUMMY_OBJECT); }
        protected void regTypeOfBlob(ConditionKey k, Object v) { regQ(k, v, getCValueTypeOfBlob(), "TYPE_OF_BLOB"); }
        protected abstract ConditionValue getCValueTypeOfBlob();
        public void SetTypeOfRaw_IsNull() { regTypeOfRaw(CK_ISN, DUMMY_OBJECT); }
        public void SetTypeOfRaw_IsNotNull() { regTypeOfRaw(CK_ISNN, DUMMY_OBJECT); }
        protected void regTypeOfRaw(ConditionKey k, Object v) { regQ(k, v, getCValueTypeOfRaw(), "TYPE_OF_RAW"); }
        protected abstract ConditionValue getCValueTypeOfRaw();

        public void SetTypeOfBfile_Equal(String v) { DoSetTypeOfBfile_Equal(fRES(v)); }
        protected void DoSetTypeOfBfile_Equal(String v) { regTypeOfBfile(CK_EQ, v); }
        public void SetTypeOfBfile_NotEqual(String v) { DoSetTypeOfBfile_NotEqual(fRES(v)); }
        protected void DoSetTypeOfBfile_NotEqual(String v) { regTypeOfBfile(CK_NES, v); }
        public void SetTypeOfBfile_InScope(IList<String> ls) { regINS<String>(CK_INS, cTL<String>(ls), getCValueTypeOfBfile(), "TYPE_OF_BFILE"); }
        public void SetTypeOfBfile_NotInScope(IList<String> ls) { regINS<String>(CK_NINS, cTL<String>(ls), getCValueTypeOfBfile(), "TYPE_OF_BFILE"); }
        public void SetTypeOfBfile_PrefixSearch(String v) { SetTypeOfBfile_LikeSearch(v, cLSOP()); }
        public void SetTypeOfBfile_LikeSearch(String v, LikeSearchOption option)
        { regLSQ(CK_LS, fRES(v), getCValueTypeOfBfile(), "TYPE_OF_BFILE", option); }
        public void SetTypeOfBfile_NotLikeSearch(String v, LikeSearchOption option)
        { regLSQ(CK_NLS, fRES(v), getCValueTypeOfBfile(), "TYPE_OF_BFILE", option); }
        public void SetTypeOfBfile_IsNull() { regTypeOfBfile(CK_ISN, DUMMY_OBJECT); }
        public void SetTypeOfBfile_IsNotNull() { regTypeOfBfile(CK_ISNN, DUMMY_OBJECT); }
        protected void regTypeOfBfile(ConditionKey k, Object v) { regQ(k, v, getCValueTypeOfBfile(), "TYPE_OF_BFILE"); }
        protected abstract ConditionValue getCValueTypeOfBfile();

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
