
using System;
using System.Collections.Generic;

using DfExample.DBFlute.MemberDb.AllCommon;
using DfExample.DBFlute.MemberDb.AllCommon.CBean;
using DfExample.DBFlute.MemberDb.AllCommon.CBean.CKey;
using DfExample.DBFlute.MemberDb.AllCommon.CBean.COption;
using DfExample.DBFlute.MemberDb.AllCommon.CBean.CValue;
using DfExample.DBFlute.MemberDb.AllCommon.CBean.SClause;

namespace DfExample.DBFlute.MemberDb.CBean.CQ.BS {

    [System.Serializable]
    public abstract class MbAbstractBsMemberAddressCQ : MbAbstractConditionQuery {

        public MbAbstractBsMemberAddressCQ(MbConditionQuery childQuery, MbSqlClause sqlClause, String aliasName, int nestLevel)
            : base(childQuery, sqlClause, aliasName, nestLevel) {}

        public override String getTableDbName() { return "member_address"; }
        public override String getTableSqlName() { return "member_address"; }

        public void SetMemberAddressId_Equal(int? v) { regMemberAddressId(CK_EQ, v); }
        public void SetMemberAddressId_GreaterThan(int? v) { regMemberAddressId(CK_GT, v); }
        public void SetMemberAddressId_LessThan(int? v) { regMemberAddressId(CK_LT, v); }
        public void SetMemberAddressId_GreaterEqual(int? v) { regMemberAddressId(CK_GE, v); }
        public void SetMemberAddressId_LessEqual(int? v) { regMemberAddressId(CK_LE, v); }
        public void SetMemberAddressId_InScope(IList<int?> ls) { regINS<int?>(CK_INS, cTL<int?>(ls), getCValueMemberAddressId(), "MEMBER_ADDRESS_ID"); }
        public void SetMemberAddressId_NotInScope(IList<int?> ls) { regINS<int?>(CK_NINS, cTL<int?>(ls), getCValueMemberAddressId(), "MEMBER_ADDRESS_ID"); }
        public void SetMemberAddressId_IsNull() { regMemberAddressId(CK_ISN, DUMMY_OBJECT); }
        public void SetMemberAddressId_IsNotNull() { regMemberAddressId(CK_ISNN, DUMMY_OBJECT); }
        protected void regMemberAddressId(MbConditionKey k, Object v) { regQ(k, v, getCValueMemberAddressId(), "MEMBER_ADDRESS_ID"); }
        protected abstract MbConditionValue getCValueMemberAddressId();

        public void SetMemberId_Equal(int? v) { regMemberId(CK_EQ, v); }
        public void SetMemberId_GreaterThan(int? v) { regMemberId(CK_GT, v); }
        public void SetMemberId_LessThan(int? v) { regMemberId(CK_LT, v); }
        public void SetMemberId_GreaterEqual(int? v) { regMemberId(CK_GE, v); }
        public void SetMemberId_LessEqual(int? v) { regMemberId(CK_LE, v); }
        public void SetMemberId_InScope(IList<int?> ls) { regINS<int?>(CK_INS, cTL<int?>(ls), getCValueMemberId(), "MEMBER_ID"); }
        public void SetMemberId_NotInScope(IList<int?> ls) { regINS<int?>(CK_NINS, cTL<int?>(ls), getCValueMemberId(), "MEMBER_ID"); }
        public void InScopeMember(MbSubQuery<MbMemberCB> subQuery) {
            assertObjectNotNull("subQuery<MbMemberCB>", subQuery);
            MbMemberCB cb = new MbMemberCB(); cb.xsetupForInScopeRelation(this); subQuery.Invoke(cb);
            String subQueryPropertyName = keepMemberId_InScopeSubQuery_Member(cb.Query());
            registerInScopeSubQuery(cb.Query(), "MEMBER_ID", "MEMBER_ID", subQueryPropertyName);
        }
        public abstract String keepMemberId_InScopeSubQuery_Member(MbMemberCQ subQuery);
        public void NotInScopeMember(MbSubQuery<MbMemberCB> subQuery) {
            assertObjectNotNull("subQuery<MbMemberCB>", subQuery);
            MbMemberCB cb = new MbMemberCB(); cb.xsetupForInScopeRelation(this); subQuery.Invoke(cb);
            String subQueryPropertyName = keepMemberId_NotInScopeSubQuery_Member(cb.Query());
            registerNotInScopeSubQuery(cb.Query(), "MEMBER_ID", "MEMBER_ID", subQueryPropertyName);
        }
        public abstract String keepMemberId_NotInScopeSubQuery_Member(MbMemberCQ subQuery);
        protected void regMemberId(MbConditionKey k, Object v) { regQ(k, v, getCValueMemberId(), "MEMBER_ID"); }
        protected abstract MbConditionValue getCValueMemberId();

        public void SetValidBeginDate_Equal(DateTime? v) { regValidBeginDate(CK_EQ, v); }
        public void SetValidBeginDate_GreaterThan(DateTime? v) { regValidBeginDate(CK_GT, v); }
        public void SetValidBeginDate_LessThan(DateTime? v) { regValidBeginDate(CK_LT, v); }
        public void SetValidBeginDate_GreaterEqual(DateTime? v) { regValidBeginDate(CK_GE, v); }
        public void SetValidBeginDate_LessEqual(DateTime? v) { regValidBeginDate(CK_LE, v); }
        public void SetValidBeginDate_FromTo(DateTime? from, DateTime? to, MbFromToOption option)
        { regFTQ(from, to, getCValueValidBeginDate(), "VALID_BEGIN_DATE", option); }
        public void SetValidBeginDate_DateFromTo(DateTime? from, DateTime? to) { SetValidBeginDate_FromTo(from, to, new MbDateFromToOption()); }
        public void SetValidBeginDate_InScope(IList<DateTime?> ls) { regINS<DateTime?>(CK_INS, cTL<DateTime?>(ls), getCValueValidBeginDate(), "VALID_BEGIN_DATE"); }
        public void SetValidBeginDate_NotInScope(IList<DateTime?> ls) { regINS<DateTime?>(CK_NINS, cTL<DateTime?>(ls), getCValueValidBeginDate(), "VALID_BEGIN_DATE"); }
        protected void regValidBeginDate(MbConditionKey k, Object v) { regQ(k, v, getCValueValidBeginDate(), "VALID_BEGIN_DATE"); }
        protected abstract MbConditionValue getCValueValidBeginDate();

        public void SetValidEndDate_Equal(DateTime? v) { regValidEndDate(CK_EQ, v); }
        public void SetValidEndDate_GreaterThan(DateTime? v) { regValidEndDate(CK_GT, v); }
        public void SetValidEndDate_LessThan(DateTime? v) { regValidEndDate(CK_LT, v); }
        public void SetValidEndDate_GreaterEqual(DateTime? v) { regValidEndDate(CK_GE, v); }
        public void SetValidEndDate_LessEqual(DateTime? v) { regValidEndDate(CK_LE, v); }
        public void SetValidEndDate_FromTo(DateTime? from, DateTime? to, MbFromToOption option)
        { regFTQ(from, to, getCValueValidEndDate(), "VALID_END_DATE", option); }
        public void SetValidEndDate_DateFromTo(DateTime? from, DateTime? to) { SetValidEndDate_FromTo(from, to, new MbDateFromToOption()); }
        public void SetValidEndDate_InScope(IList<DateTime?> ls) { regINS<DateTime?>(CK_INS, cTL<DateTime?>(ls), getCValueValidEndDate(), "VALID_END_DATE"); }
        public void SetValidEndDate_NotInScope(IList<DateTime?> ls) { regINS<DateTime?>(CK_NINS, cTL<DateTime?>(ls), getCValueValidEndDate(), "VALID_END_DATE"); }
        protected void regValidEndDate(MbConditionKey k, Object v) { regQ(k, v, getCValueValidEndDate(), "VALID_END_DATE"); }
        protected abstract MbConditionValue getCValueValidEndDate();

        public void SetAddress_Equal(String v) { DoSetAddress_Equal(fRES(v)); }
        protected void DoSetAddress_Equal(String v) { regAddress(CK_EQ, v); }
        public void SetAddress_NotEqual(String v) { DoSetAddress_NotEqual(fRES(v)); }
        protected void DoSetAddress_NotEqual(String v) { regAddress(CK_NES, v); }
        public void SetAddress_InScope(IList<String> ls) { regINS<String>(CK_INS, cTL<String>(ls), getCValueAddress(), "ADDRESS"); }
        public void SetAddress_NotInScope(IList<String> ls) { regINS<String>(CK_NINS, cTL<String>(ls), getCValueAddress(), "ADDRESS"); }
        public void SetAddress_PrefixSearch(String v) { SetAddress_LikeSearch(v, cLSOP()); }
        public void SetAddress_LikeSearch(String v, MbLikeSearchOption option)
        { regLSQ(CK_LS, fRES(v), getCValueAddress(), "ADDRESS", option); }
        public void SetAddress_NotLikeSearch(String v, MbLikeSearchOption option)
        { regLSQ(CK_NLS, fRES(v), getCValueAddress(), "ADDRESS", option); }
        protected void regAddress(MbConditionKey k, Object v) { regQ(k, v, getCValueAddress(), "ADDRESS"); }
        protected abstract MbConditionValue getCValueAddress();

        public void SetRegisterDatetime_Equal(DateTime? v) { regRegisterDatetime(CK_EQ, v); }
        public void SetRegisterDatetime_GreaterThan(DateTime? v) { regRegisterDatetime(CK_GT, v); }
        public void SetRegisterDatetime_LessThan(DateTime? v) { regRegisterDatetime(CK_LT, v); }
        public void SetRegisterDatetime_GreaterEqual(DateTime? v) { regRegisterDatetime(CK_GE, v); }
        public void SetRegisterDatetime_LessEqual(DateTime? v) { regRegisterDatetime(CK_LE, v); }
        public void SetRegisterDatetime_FromTo(DateTime? from, DateTime? to, MbFromToOption option)
        { regFTQ(from, to, getCValueRegisterDatetime(), "REGISTER_DATETIME", option); }
        public void SetRegisterDatetime_DateFromTo(DateTime? from, DateTime? to) { SetRegisterDatetime_FromTo(from, to, new MbDateFromToOption()); }
        public void SetRegisterDatetime_InScope(IList<DateTime?> ls) { regINS<DateTime?>(CK_INS, cTL<DateTime?>(ls), getCValueRegisterDatetime(), "REGISTER_DATETIME"); }
        public void SetRegisterDatetime_NotInScope(IList<DateTime?> ls) { regINS<DateTime?>(CK_NINS, cTL<DateTime?>(ls), getCValueRegisterDatetime(), "REGISTER_DATETIME"); }
        protected void regRegisterDatetime(MbConditionKey k, Object v) { regQ(k, v, getCValueRegisterDatetime(), "REGISTER_DATETIME"); }
        protected abstract MbConditionValue getCValueRegisterDatetime();

        public void SetRegisterProcess_Equal(String v) { DoSetRegisterProcess_Equal(fRES(v)); }
        protected void DoSetRegisterProcess_Equal(String v) { regRegisterProcess(CK_EQ, v); }
        public void SetRegisterProcess_NotEqual(String v) { DoSetRegisterProcess_NotEqual(fRES(v)); }
        protected void DoSetRegisterProcess_NotEqual(String v) { regRegisterProcess(CK_NES, v); }
        public void SetRegisterProcess_InScope(IList<String> ls) { regINS<String>(CK_INS, cTL<String>(ls), getCValueRegisterProcess(), "REGISTER_PROCESS"); }
        public void SetRegisterProcess_NotInScope(IList<String> ls) { regINS<String>(CK_NINS, cTL<String>(ls), getCValueRegisterProcess(), "REGISTER_PROCESS"); }
        public void SetRegisterProcess_PrefixSearch(String v) { SetRegisterProcess_LikeSearch(v, cLSOP()); }
        public void SetRegisterProcess_LikeSearch(String v, MbLikeSearchOption option)
        { regLSQ(CK_LS, fRES(v), getCValueRegisterProcess(), "REGISTER_PROCESS", option); }
        public void SetRegisterProcess_NotLikeSearch(String v, MbLikeSearchOption option)
        { regLSQ(CK_NLS, fRES(v), getCValueRegisterProcess(), "REGISTER_PROCESS", option); }
        protected void regRegisterProcess(MbConditionKey k, Object v) { regQ(k, v, getCValueRegisterProcess(), "REGISTER_PROCESS"); }
        protected abstract MbConditionValue getCValueRegisterProcess();

        public void SetRegisterUser_Equal(String v) { DoSetRegisterUser_Equal(fRES(v)); }
        protected void DoSetRegisterUser_Equal(String v) { regRegisterUser(CK_EQ, v); }
        public void SetRegisterUser_NotEqual(String v) { DoSetRegisterUser_NotEqual(fRES(v)); }
        protected void DoSetRegisterUser_NotEqual(String v) { regRegisterUser(CK_NES, v); }
        public void SetRegisterUser_InScope(IList<String> ls) { regINS<String>(CK_INS, cTL<String>(ls), getCValueRegisterUser(), "REGISTER_USER"); }
        public void SetRegisterUser_NotInScope(IList<String> ls) { regINS<String>(CK_NINS, cTL<String>(ls), getCValueRegisterUser(), "REGISTER_USER"); }
        public void SetRegisterUser_PrefixSearch(String v) { SetRegisterUser_LikeSearch(v, cLSOP()); }
        public void SetRegisterUser_LikeSearch(String v, MbLikeSearchOption option)
        { regLSQ(CK_LS, fRES(v), getCValueRegisterUser(), "REGISTER_USER", option); }
        public void SetRegisterUser_NotLikeSearch(String v, MbLikeSearchOption option)
        { regLSQ(CK_NLS, fRES(v), getCValueRegisterUser(), "REGISTER_USER", option); }
        protected void regRegisterUser(MbConditionKey k, Object v) { regQ(k, v, getCValueRegisterUser(), "REGISTER_USER"); }
        protected abstract MbConditionValue getCValueRegisterUser();

        public void SetUpdateDatetime_Equal(DateTime? v) { regUpdateDatetime(CK_EQ, v); }
        public void SetUpdateDatetime_GreaterThan(DateTime? v) { regUpdateDatetime(CK_GT, v); }
        public void SetUpdateDatetime_LessThan(DateTime? v) { regUpdateDatetime(CK_LT, v); }
        public void SetUpdateDatetime_GreaterEqual(DateTime? v) { regUpdateDatetime(CK_GE, v); }
        public void SetUpdateDatetime_LessEqual(DateTime? v) { regUpdateDatetime(CK_LE, v); }
        public void SetUpdateDatetime_FromTo(DateTime? from, DateTime? to, MbFromToOption option)
        { regFTQ(from, to, getCValueUpdateDatetime(), "UPDATE_DATETIME", option); }
        public void SetUpdateDatetime_DateFromTo(DateTime? from, DateTime? to) { SetUpdateDatetime_FromTo(from, to, new MbDateFromToOption()); }
        public void SetUpdateDatetime_InScope(IList<DateTime?> ls) { regINS<DateTime?>(CK_INS, cTL<DateTime?>(ls), getCValueUpdateDatetime(), "UPDATE_DATETIME"); }
        public void SetUpdateDatetime_NotInScope(IList<DateTime?> ls) { regINS<DateTime?>(CK_NINS, cTL<DateTime?>(ls), getCValueUpdateDatetime(), "UPDATE_DATETIME"); }
        protected void regUpdateDatetime(MbConditionKey k, Object v) { regQ(k, v, getCValueUpdateDatetime(), "UPDATE_DATETIME"); }
        protected abstract MbConditionValue getCValueUpdateDatetime();

        public void SetUpdateProcess_Equal(String v) { DoSetUpdateProcess_Equal(fRES(v)); }
        protected void DoSetUpdateProcess_Equal(String v) { regUpdateProcess(CK_EQ, v); }
        public void SetUpdateProcess_NotEqual(String v) { DoSetUpdateProcess_NotEqual(fRES(v)); }
        protected void DoSetUpdateProcess_NotEqual(String v) { regUpdateProcess(CK_NES, v); }
        public void SetUpdateProcess_InScope(IList<String> ls) { regINS<String>(CK_INS, cTL<String>(ls), getCValueUpdateProcess(), "UPDATE_PROCESS"); }
        public void SetUpdateProcess_NotInScope(IList<String> ls) { regINS<String>(CK_NINS, cTL<String>(ls), getCValueUpdateProcess(), "UPDATE_PROCESS"); }
        public void SetUpdateProcess_PrefixSearch(String v) { SetUpdateProcess_LikeSearch(v, cLSOP()); }
        public void SetUpdateProcess_LikeSearch(String v, MbLikeSearchOption option)
        { regLSQ(CK_LS, fRES(v), getCValueUpdateProcess(), "UPDATE_PROCESS", option); }
        public void SetUpdateProcess_NotLikeSearch(String v, MbLikeSearchOption option)
        { regLSQ(CK_NLS, fRES(v), getCValueUpdateProcess(), "UPDATE_PROCESS", option); }
        protected void regUpdateProcess(MbConditionKey k, Object v) { regQ(k, v, getCValueUpdateProcess(), "UPDATE_PROCESS"); }
        protected abstract MbConditionValue getCValueUpdateProcess();

        public void SetUpdateUser_Equal(String v) { DoSetUpdateUser_Equal(fRES(v)); }
        protected void DoSetUpdateUser_Equal(String v) { regUpdateUser(CK_EQ, v); }
        public void SetUpdateUser_NotEqual(String v) { DoSetUpdateUser_NotEqual(fRES(v)); }
        protected void DoSetUpdateUser_NotEqual(String v) { regUpdateUser(CK_NES, v); }
        public void SetUpdateUser_InScope(IList<String> ls) { regINS<String>(CK_INS, cTL<String>(ls), getCValueUpdateUser(), "UPDATE_USER"); }
        public void SetUpdateUser_NotInScope(IList<String> ls) { regINS<String>(CK_NINS, cTL<String>(ls), getCValueUpdateUser(), "UPDATE_USER"); }
        public void SetUpdateUser_PrefixSearch(String v) { SetUpdateUser_LikeSearch(v, cLSOP()); }
        public void SetUpdateUser_LikeSearch(String v, MbLikeSearchOption option)
        { regLSQ(CK_LS, fRES(v), getCValueUpdateUser(), "UPDATE_USER", option); }
        public void SetUpdateUser_NotLikeSearch(String v, MbLikeSearchOption option)
        { regLSQ(CK_NLS, fRES(v), getCValueUpdateUser(), "UPDATE_USER", option); }
        protected void regUpdateUser(MbConditionKey k, Object v) { regQ(k, v, getCValueUpdateUser(), "UPDATE_USER"); }
        protected abstract MbConditionValue getCValueUpdateUser();

        public void SetVersionNo_Equal(long? v) { regVersionNo(CK_EQ, v); }
        public void SetVersionNo_GreaterThan(long? v) { regVersionNo(CK_GT, v); }
        public void SetVersionNo_LessThan(long? v) { regVersionNo(CK_LT, v); }
        public void SetVersionNo_GreaterEqual(long? v) { regVersionNo(CK_GE, v); }
        public void SetVersionNo_LessEqual(long? v) { regVersionNo(CK_LE, v); }
        public void SetVersionNo_InScope(IList<long?> ls) { regINS<long?>(CK_INS, cTL<long?>(ls), getCValueVersionNo(), "VERSION_NO"); }
        public void SetVersionNo_NotInScope(IList<long?> ls) { regINS<long?>(CK_NINS, cTL<long?>(ls), getCValueVersionNo(), "VERSION_NO"); }
        protected void regVersionNo(MbConditionKey k, Object v) { regQ(k, v, getCValueVersionNo(), "VERSION_NO"); }
        protected abstract MbConditionValue getCValueVersionNo();

        // ===================================================================================
        //                                                                    Scalar Condition
        //                                                                    ================
        public SSQFunction<MbMemberAddressCB> Scalar_Equal() {
            return xcreateSSQFunction("=");
        }

        public SSQFunction<MbMemberAddressCB> Scalar_NotEqual() {
            return xcreateSSQFunction("<>");
        }

        public SSQFunction<MbMemberAddressCB> Scalar_GreaterEqual() {
            return xcreateSSQFunction(">=");
        }

        public SSQFunction<MbMemberAddressCB> Scalar_GreaterThan() {
            return xcreateSSQFunction(">");
        }

        public SSQFunction<MbMemberAddressCB> Scalar_LessEqual() {
            return xcreateSSQFunction("<=");
        }

        public SSQFunction<MbMemberAddressCB> Scalar_LessThan() {
            return xcreateSSQFunction("<");
        }

        protected SSQFunction<MbMemberAddressCB> xcreateSSQFunction(String operand) {
            return new SSQFunction<MbMemberAddressCB>(delegate(String function, MbSubQuery<MbMemberAddressCB> subQuery) {
                xscalarSubQuery(function, subQuery, operand);
            });
        }

        protected void xscalarSubQuery(String function, MbSubQuery<MbMemberAddressCB> subQuery, String operand) {
            assertObjectNotNull("subQuery<MbMemberAddressCB>", subQuery);
            MbMemberAddressCB cb = new MbMemberAddressCB(); cb.xsetupForScalarCondition(this); subQuery.Invoke(cb);
            String subQueryPropertyName = keepScalarSubQuery(cb.Query()); // for saving query-value.
            registerScalarSubQuery(function, cb.Query(), subQueryPropertyName, operand);
        }
        public abstract String keepScalarSubQuery(MbMemberAddressCQ subQuery);

        // ===============================================================================
        //                                                                  MySelf InScope
        //                                                                  ==============
        public void MyselfInScope(MbSubQuery<MbMemberAddressCB> subQuery) {
            assertObjectNotNull("subQuery<MbMemberAddressCB>", subQuery);
            MbMemberAddressCB cb = new MbMemberAddressCB(); cb.xsetupForInScopeRelation(this); subQuery.Invoke(cb);
            String subQueryPropertyName = keepMyselfInScopeSubQuery(cb.Query()); // for saving query-value.
            registerInScopeSubQuery(cb.Query(), "MEMBER_ADDRESS_ID", "MEMBER_ADDRESS_ID", subQueryPropertyName);
        }
        public abstract String keepMyselfInScopeSubQuery(MbMemberAddressCQ subQuery);

        public override String ToString() { return xgetSqlClause().getClause(); }
    }
}
