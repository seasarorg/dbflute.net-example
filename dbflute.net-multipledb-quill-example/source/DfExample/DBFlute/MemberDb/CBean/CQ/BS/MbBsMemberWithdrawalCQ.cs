
using System;

using DfExample.DBFlute.MemberDb.AllCommon.CBean;
using DfExample.DBFlute.MemberDb.AllCommon.CBean.CValue;
using DfExample.DBFlute.MemberDb.AllCommon.CBean.SClause;
using DfExample.DBFlute.MemberDb.AllCommon.JavaLike;
using DfExample.DBFlute.MemberDb.CBean.CQ;
using DfExample.DBFlute.MemberDb.CBean.CQ.Ciq;

namespace DfExample.DBFlute.MemberDb.CBean.CQ.BS {

    [System.Serializable]
    public class MbBsMemberWithdrawalCQ : MbAbstractBsMemberWithdrawalCQ {

        protected MbMemberWithdrawalCIQ _inlineQuery;

        public MbBsMemberWithdrawalCQ(MbConditionQuery childQuery, MbSqlClause sqlClause, String aliasName, int nestLevel)
            : base(childQuery, sqlClause, aliasName, nestLevel) {}

        public MbMemberWithdrawalCIQ Inline() {
            if (_inlineQuery == null) {
                _inlineQuery = new MbMemberWithdrawalCIQ(xgetReferrerQuery(), xgetSqlClause(), xgetAliasName(), xgetNestLevel(), this);
            }
            _inlineQuery.xsetOnClause(false);
            return _inlineQuery;
        }
        
        public MbMemberWithdrawalCIQ On() {
            if (isBaseQuery()) { throw new UnsupportedOperationException("Unsupported onClause of Base Table!"); }
            MbMemberWithdrawalCIQ inlineQuery = Inline();
            inlineQuery.xsetOnClause(true);
            return inlineQuery;
        }


        protected MbConditionValue _memberId;
        public MbConditionValue MemberId {
            get { if (_memberId == null) { _memberId = new MbConditionValue(); } return _memberId; }
        }
        protected override MbConditionValue getCValueMemberId() { return this.MemberId; }


        protected Map<String, MbMemberCQ> _memberId_InScopeSubQuery_MemberMap;
        public Map<String, MbMemberCQ> MemberId_InScopeSubQuery_Member { get { return _memberId_InScopeSubQuery_MemberMap; }}
        public override String keepMemberId_InScopeSubQuery_Member(MbMemberCQ subQuery) {
            if (_memberId_InScopeSubQuery_MemberMap == null) { _memberId_InScopeSubQuery_MemberMap = new LinkedHashMap<String, MbMemberCQ>(); }
            String key = "subQueryMapKey" + (_memberId_InScopeSubQuery_MemberMap.size() + 1);
            _memberId_InScopeSubQuery_MemberMap.put(key, subQuery); return "MemberId_InScopeSubQuery_Member." + key;
        }

        protected Map<String, MbMemberCQ> _memberId_NotInScopeSubQuery_MemberMap;
        public Map<String, MbMemberCQ> MemberId_NotInScopeSubQuery_Member { get { return _memberId_NotInScopeSubQuery_MemberMap; }}
        public override String keepMemberId_NotInScopeSubQuery_Member(MbMemberCQ subQuery) {
            if (_memberId_NotInScopeSubQuery_MemberMap == null) { _memberId_NotInScopeSubQuery_MemberMap = new LinkedHashMap<String, MbMemberCQ>(); }
            String key = "subQueryMapKey" + (_memberId_NotInScopeSubQuery_MemberMap.size() + 1);
            _memberId_NotInScopeSubQuery_MemberMap.put(key, subQuery); return "MemberId_NotInScopeSubQuery_Member." + key;
        }

        public MbBsMemberWithdrawalCQ AddOrderBy_MemberId_Asc() { regOBA("MEMBER_ID");return this; }
        public MbBsMemberWithdrawalCQ AddOrderBy_MemberId_Desc() { regOBD("MEMBER_ID");return this; }

        protected MbConditionValue _withdrawalReasonCode;
        public MbConditionValue WithdrawalReasonCode {
            get { if (_withdrawalReasonCode == null) { _withdrawalReasonCode = new MbConditionValue(); } return _withdrawalReasonCode; }
        }
        protected override MbConditionValue getCValueWithdrawalReasonCode() { return this.WithdrawalReasonCode; }


        protected Map<String, MbWithdrawalReasonCQ> _withdrawalReasonCode_InScopeSubQuery_WithdrawalReasonMap;
        public Map<String, MbWithdrawalReasonCQ> WithdrawalReasonCode_InScopeSubQuery_WithdrawalReason { get { return _withdrawalReasonCode_InScopeSubQuery_WithdrawalReasonMap; }}
        public override String keepWithdrawalReasonCode_InScopeSubQuery_WithdrawalReason(MbWithdrawalReasonCQ subQuery) {
            if (_withdrawalReasonCode_InScopeSubQuery_WithdrawalReasonMap == null) { _withdrawalReasonCode_InScopeSubQuery_WithdrawalReasonMap = new LinkedHashMap<String, MbWithdrawalReasonCQ>(); }
            String key = "subQueryMapKey" + (_withdrawalReasonCode_InScopeSubQuery_WithdrawalReasonMap.size() + 1);
            _withdrawalReasonCode_InScopeSubQuery_WithdrawalReasonMap.put(key, subQuery); return "WithdrawalReasonCode_InScopeSubQuery_WithdrawalReason." + key;
        }

        protected Map<String, MbWithdrawalReasonCQ> _withdrawalReasonCode_NotInScopeSubQuery_WithdrawalReasonMap;
        public Map<String, MbWithdrawalReasonCQ> WithdrawalReasonCode_NotInScopeSubQuery_WithdrawalReason { get { return _withdrawalReasonCode_NotInScopeSubQuery_WithdrawalReasonMap; }}
        public override String keepWithdrawalReasonCode_NotInScopeSubQuery_WithdrawalReason(MbWithdrawalReasonCQ subQuery) {
            if (_withdrawalReasonCode_NotInScopeSubQuery_WithdrawalReasonMap == null) { _withdrawalReasonCode_NotInScopeSubQuery_WithdrawalReasonMap = new LinkedHashMap<String, MbWithdrawalReasonCQ>(); }
            String key = "subQueryMapKey" + (_withdrawalReasonCode_NotInScopeSubQuery_WithdrawalReasonMap.size() + 1);
            _withdrawalReasonCode_NotInScopeSubQuery_WithdrawalReasonMap.put(key, subQuery); return "WithdrawalReasonCode_NotInScopeSubQuery_WithdrawalReason." + key;
        }

        public MbBsMemberWithdrawalCQ AddOrderBy_WithdrawalReasonCode_Asc() { regOBA("WITHDRAWAL_REASON_CODE");return this; }
        public MbBsMemberWithdrawalCQ AddOrderBy_WithdrawalReasonCode_Desc() { regOBD("WITHDRAWAL_REASON_CODE");return this; }

        protected MbConditionValue _withdrawalReasonInputText;
        public MbConditionValue WithdrawalReasonInputText {
            get { if (_withdrawalReasonInputText == null) { _withdrawalReasonInputText = new MbConditionValue(); } return _withdrawalReasonInputText; }
        }
        protected override MbConditionValue getCValueWithdrawalReasonInputText() { return this.WithdrawalReasonInputText; }


        public MbBsMemberWithdrawalCQ AddOrderBy_WithdrawalReasonInputText_Asc() { regOBA("WITHDRAWAL_REASON_INPUT_TEXT");return this; }
        public MbBsMemberWithdrawalCQ AddOrderBy_WithdrawalReasonInputText_Desc() { regOBD("WITHDRAWAL_REASON_INPUT_TEXT");return this; }

        protected MbConditionValue _withdrawalDatetime;
        public MbConditionValue WithdrawalDatetime {
            get { if (_withdrawalDatetime == null) { _withdrawalDatetime = new MbConditionValue(); } return _withdrawalDatetime; }
        }
        protected override MbConditionValue getCValueWithdrawalDatetime() { return this.WithdrawalDatetime; }


        public MbBsMemberWithdrawalCQ AddOrderBy_WithdrawalDatetime_Asc() { regOBA("WITHDRAWAL_DATETIME");return this; }
        public MbBsMemberWithdrawalCQ AddOrderBy_WithdrawalDatetime_Desc() { regOBD("WITHDRAWAL_DATETIME");return this; }

        protected MbConditionValue _registerDatetime;
        public MbConditionValue RegisterDatetime {
            get { if (_registerDatetime == null) { _registerDatetime = new MbConditionValue(); } return _registerDatetime; }
        }
        protected override MbConditionValue getCValueRegisterDatetime() { return this.RegisterDatetime; }


        public MbBsMemberWithdrawalCQ AddOrderBy_RegisterDatetime_Asc() { regOBA("REGISTER_DATETIME");return this; }
        public MbBsMemberWithdrawalCQ AddOrderBy_RegisterDatetime_Desc() { regOBD("REGISTER_DATETIME");return this; }

        protected MbConditionValue _registerProcess;
        public MbConditionValue RegisterProcess {
            get { if (_registerProcess == null) { _registerProcess = new MbConditionValue(); } return _registerProcess; }
        }
        protected override MbConditionValue getCValueRegisterProcess() { return this.RegisterProcess; }


        public MbBsMemberWithdrawalCQ AddOrderBy_RegisterProcess_Asc() { regOBA("REGISTER_PROCESS");return this; }
        public MbBsMemberWithdrawalCQ AddOrderBy_RegisterProcess_Desc() { regOBD("REGISTER_PROCESS");return this; }

        protected MbConditionValue _registerUser;
        public MbConditionValue RegisterUser {
            get { if (_registerUser == null) { _registerUser = new MbConditionValue(); } return _registerUser; }
        }
        protected override MbConditionValue getCValueRegisterUser() { return this.RegisterUser; }


        public MbBsMemberWithdrawalCQ AddOrderBy_RegisterUser_Asc() { regOBA("REGISTER_USER");return this; }
        public MbBsMemberWithdrawalCQ AddOrderBy_RegisterUser_Desc() { regOBD("REGISTER_USER");return this; }

        protected MbConditionValue _updateDatetime;
        public MbConditionValue UpdateDatetime {
            get { if (_updateDatetime == null) { _updateDatetime = new MbConditionValue(); } return _updateDatetime; }
        }
        protected override MbConditionValue getCValueUpdateDatetime() { return this.UpdateDatetime; }


        public MbBsMemberWithdrawalCQ AddOrderBy_UpdateDatetime_Asc() { regOBA("UPDATE_DATETIME");return this; }
        public MbBsMemberWithdrawalCQ AddOrderBy_UpdateDatetime_Desc() { regOBD("UPDATE_DATETIME");return this; }

        protected MbConditionValue _updateProcess;
        public MbConditionValue UpdateProcess {
            get { if (_updateProcess == null) { _updateProcess = new MbConditionValue(); } return _updateProcess; }
        }
        protected override MbConditionValue getCValueUpdateProcess() { return this.UpdateProcess; }


        public MbBsMemberWithdrawalCQ AddOrderBy_UpdateProcess_Asc() { regOBA("UPDATE_PROCESS");return this; }
        public MbBsMemberWithdrawalCQ AddOrderBy_UpdateProcess_Desc() { regOBD("UPDATE_PROCESS");return this; }

        protected MbConditionValue _updateUser;
        public MbConditionValue UpdateUser {
            get { if (_updateUser == null) { _updateUser = new MbConditionValue(); } return _updateUser; }
        }
        protected override MbConditionValue getCValueUpdateUser() { return this.UpdateUser; }


        public MbBsMemberWithdrawalCQ AddOrderBy_UpdateUser_Asc() { regOBA("UPDATE_USER");return this; }
        public MbBsMemberWithdrawalCQ AddOrderBy_UpdateUser_Desc() { regOBD("UPDATE_USER");return this; }

        protected MbConditionValue _versionNo;
        public MbConditionValue VersionNo {
            get { if (_versionNo == null) { _versionNo = new MbConditionValue(); } return _versionNo; }
        }
        protected override MbConditionValue getCValueVersionNo() { return this.VersionNo; }


        public MbBsMemberWithdrawalCQ AddOrderBy_VersionNo_Asc() { regOBA("VERSION_NO");return this; }
        public MbBsMemberWithdrawalCQ AddOrderBy_VersionNo_Desc() { regOBD("VERSION_NO");return this; }

        public MbBsMemberWithdrawalCQ AddSpecifiedDerivedOrderBy_Asc(String aliasName) { registerSpecifiedDerivedOrderBy_Asc(aliasName); return this; }
        public MbBsMemberWithdrawalCQ AddSpecifiedDerivedOrderBy_Desc(String aliasName) { registerSpecifiedDerivedOrderBy_Desc(aliasName); return this; }

        public override void reflectRelationOnUnionQuery(MbConditionQuery baseQueryAsSuper, MbConditionQuery unionQueryAsSuper) {
            MbMemberWithdrawalCQ baseQuery = (MbMemberWithdrawalCQ)baseQueryAsSuper;
            MbMemberWithdrawalCQ unionQuery = (MbMemberWithdrawalCQ)unionQueryAsSuper;
            if (baseQuery.hasConditionQueryMember()) {
                unionQuery.QueryMember().reflectRelationOnUnionQuery(baseQuery.QueryMember(), unionQuery.QueryMember());
            }
            if (baseQuery.hasConditionQueryWithdrawalReason()) {
                unionQuery.QueryWithdrawalReason().reflectRelationOnUnionQuery(baseQuery.QueryWithdrawalReason(), unionQuery.QueryWithdrawalReason());
            }

        }
    
        protected MbMemberCQ _conditionQueryMember;
        public MbMemberCQ QueryMember() {
            return this.ConditionQueryMember;
        }
        public MbMemberCQ ConditionQueryMember {
            get {
                if (_conditionQueryMember == null) {
                    _conditionQueryMember = xcreateQueryMember();
                    xsetupOuterJoin_Member();
                }
                return _conditionQueryMember;
            }
        }
        protected MbMemberCQ xcreateQueryMember() {
            String nrp = resolveNextRelationPathMember();
            String jan = resolveJoinAliasName(nrp, xgetNextNestLevel());
            MbMemberCQ cq = new MbMemberCQ(this, xgetSqlClause(), jan, xgetNextNestLevel());
            cq.xsetForeignPropertyName("member"); cq.xsetRelationPath(nrp); return cq;
        }
        public void xsetupOuterJoin_Member() {
            MbMemberCQ cq = ConditionQueryMember;
            Map<String, String> joinOnMap = new LinkedHashMap<String, String>();
            joinOnMap.put("MEMBER_ID", "MEMBER_ID");
            registerOuterJoin(cq, joinOnMap);
        }
        protected String resolveNextRelationPathMember() {
            return resolveNextRelationPath("member_withdrawal", "member");
        }
        public bool hasConditionQueryMember() {
            return _conditionQueryMember != null;
        }
        protected MbWithdrawalReasonCQ _conditionQueryWithdrawalReason;
        public MbWithdrawalReasonCQ QueryWithdrawalReason() {
            return this.ConditionQueryWithdrawalReason;
        }
        public MbWithdrawalReasonCQ ConditionQueryWithdrawalReason {
            get {
                if (_conditionQueryWithdrawalReason == null) {
                    _conditionQueryWithdrawalReason = xcreateQueryWithdrawalReason();
                    xsetupOuterJoin_WithdrawalReason();
                }
                return _conditionQueryWithdrawalReason;
            }
        }
        protected MbWithdrawalReasonCQ xcreateQueryWithdrawalReason() {
            String nrp = resolveNextRelationPathWithdrawalReason();
            String jan = resolveJoinAliasName(nrp, xgetNextNestLevel());
            MbWithdrawalReasonCQ cq = new MbWithdrawalReasonCQ(this, xgetSqlClause(), jan, xgetNextNestLevel());
            cq.xsetForeignPropertyName("withdrawalReason"); cq.xsetRelationPath(nrp); return cq;
        }
        public void xsetupOuterJoin_WithdrawalReason() {
            MbWithdrawalReasonCQ cq = ConditionQueryWithdrawalReason;
            Map<String, String> joinOnMap = new LinkedHashMap<String, String>();
            joinOnMap.put("WITHDRAWAL_REASON_CODE", "WITHDRAWAL_REASON_CODE");
            registerOuterJoin(cq, joinOnMap);
        }
        protected String resolveNextRelationPathWithdrawalReason() {
            return resolveNextRelationPath("member_withdrawal", "withdrawalReason");
        }
        public bool hasConditionQueryWithdrawalReason() {
            return _conditionQueryWithdrawalReason != null;
        }


	    // ===============================================================================
	    //                                                                 Scalar SubQuery
	    //                                                                 ===============
	    protected Map<String, MbMemberWithdrawalCQ> _scalarSubQueryMap;
	    public Map<String, MbMemberWithdrawalCQ> ScalarSubQuery { get { return _scalarSubQueryMap; } }
	    public override String keepScalarSubQuery(MbMemberWithdrawalCQ subQuery) {
	        if (_scalarSubQueryMap == null) { _scalarSubQueryMap = new LinkedHashMap<String, MbMemberWithdrawalCQ>(); }
	        String key = "subQueryMapKey" + (_scalarSubQueryMap.size() + 1);
	        _scalarSubQueryMap.put(key, subQuery); return "ScalarSubQuery." + key;
	    }

        // ===============================================================================
        //                                                         Myself InScope SubQuery
        //                                                         =======================
        protected Map<String, MbMemberWithdrawalCQ> _myselfInScopeSubQueryMap;
        public Map<String, MbMemberWithdrawalCQ> MyselfInScopeSubQuery { get { return _myselfInScopeSubQueryMap; } }
        public override String keepMyselfInScopeSubQuery(MbMemberWithdrawalCQ subQuery) {
            if (_myselfInScopeSubQueryMap == null) { _myselfInScopeSubQueryMap = new LinkedHashMap<String, MbMemberWithdrawalCQ>(); }
            String key = "subQueryMapKey" + (_myselfInScopeSubQueryMap.size() + 1);
            _myselfInScopeSubQueryMap.put(key, subQuery); return "MyselfInScopeSubQuery." + key;
        }
    }
}
