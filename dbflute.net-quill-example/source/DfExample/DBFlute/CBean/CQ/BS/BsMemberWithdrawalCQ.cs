
using System;

using DfExample.DBFlute.AllCommon.CBean;
using DfExample.DBFlute.AllCommon.CBean.CValue;
using DfExample.DBFlute.AllCommon.CBean.SClause;
using DfExample.DBFlute.AllCommon.JavaLike;
using DfExample.DBFlute.CBean.CQ;
using DfExample.DBFlute.CBean.CQ.Ciq;

namespace DfExample.DBFlute.CBean.CQ.BS {

    [System.Serializable]
    public class BsMemberWithdrawalCQ : AbstractBsMemberWithdrawalCQ {

        protected MemberWithdrawalCIQ _inlineQuery;

        public BsMemberWithdrawalCQ(ConditionQuery childQuery, SqlClause sqlClause, String aliasName, int nestLevel)
            : base(childQuery, sqlClause, aliasName, nestLevel) {}

        public MemberWithdrawalCIQ Inline() {
            if (_inlineQuery == null) {
                _inlineQuery = new MemberWithdrawalCIQ(xgetReferrerQuery(), xgetSqlClause(), xgetAliasName(), xgetNestLevel(), this);
            }
            _inlineQuery.xsetOnClause(false);
            return _inlineQuery;
        }
        
        public MemberWithdrawalCIQ On() {
            if (isBaseQuery()) { throw new UnsupportedOperationException("Unsupported onClause of Base Table!"); }
            MemberWithdrawalCIQ inlineQuery = Inline();
            inlineQuery.xsetOnClause(true);
            return inlineQuery;
        }


        protected ConditionValue _memberId;
        public ConditionValue MemberId {
            get { if (_memberId == null) { _memberId = new ConditionValue(); } return _memberId; }
        }
        protected override ConditionValue getCValueMemberId() { return this.MemberId; }


        protected Map<String, MemberCQ> _memberId_InScopeSubQuery_MemberMap;
        public Map<String, MemberCQ> MemberId_InScopeSubQuery_Member { get { return _memberId_InScopeSubQuery_MemberMap; }}
        public override String keepMemberId_InScopeSubQuery_Member(MemberCQ subQuery) {
            if (_memberId_InScopeSubQuery_MemberMap == null) { _memberId_InScopeSubQuery_MemberMap = new LinkedHashMap<String, MemberCQ>(); }
            String key = "subQueryMapKey" + (_memberId_InScopeSubQuery_MemberMap.size() + 1);
            _memberId_InScopeSubQuery_MemberMap.put(key, subQuery); return "MemberId_InScopeSubQuery_Member." + key;
        }

        protected Map<String, MemberCQ> _memberId_NotInScopeSubQuery_MemberMap;
        public Map<String, MemberCQ> MemberId_NotInScopeSubQuery_Member { get { return _memberId_NotInScopeSubQuery_MemberMap; }}
        public override String keepMemberId_NotInScopeSubQuery_Member(MemberCQ subQuery) {
            if (_memberId_NotInScopeSubQuery_MemberMap == null) { _memberId_NotInScopeSubQuery_MemberMap = new LinkedHashMap<String, MemberCQ>(); }
            String key = "subQueryMapKey" + (_memberId_NotInScopeSubQuery_MemberMap.size() + 1);
            _memberId_NotInScopeSubQuery_MemberMap.put(key, subQuery); return "MemberId_NotInScopeSubQuery_Member." + key;
        }

        public BsMemberWithdrawalCQ AddOrderBy_MemberId_Asc() { regOBA("MEMBER_ID");return this; }
        public BsMemberWithdrawalCQ AddOrderBy_MemberId_Desc() { regOBD("MEMBER_ID");return this; }

        protected ConditionValue _withdrawalReasonCode;
        public ConditionValue WithdrawalReasonCode {
            get { if (_withdrawalReasonCode == null) { _withdrawalReasonCode = new ConditionValue(); } return _withdrawalReasonCode; }
        }
        protected override ConditionValue getCValueWithdrawalReasonCode() { return this.WithdrawalReasonCode; }


        protected Map<String, WithdrawalReasonCQ> _withdrawalReasonCode_InScopeSubQuery_WithdrawalReasonMap;
        public Map<String, WithdrawalReasonCQ> WithdrawalReasonCode_InScopeSubQuery_WithdrawalReason { get { return _withdrawalReasonCode_InScopeSubQuery_WithdrawalReasonMap; }}
        public override String keepWithdrawalReasonCode_InScopeSubQuery_WithdrawalReason(WithdrawalReasonCQ subQuery) {
            if (_withdrawalReasonCode_InScopeSubQuery_WithdrawalReasonMap == null) { _withdrawalReasonCode_InScopeSubQuery_WithdrawalReasonMap = new LinkedHashMap<String, WithdrawalReasonCQ>(); }
            String key = "subQueryMapKey" + (_withdrawalReasonCode_InScopeSubQuery_WithdrawalReasonMap.size() + 1);
            _withdrawalReasonCode_InScopeSubQuery_WithdrawalReasonMap.put(key, subQuery); return "WithdrawalReasonCode_InScopeSubQuery_WithdrawalReason." + key;
        }

        protected Map<String, WithdrawalReasonCQ> _withdrawalReasonCode_NotInScopeSubQuery_WithdrawalReasonMap;
        public Map<String, WithdrawalReasonCQ> WithdrawalReasonCode_NotInScopeSubQuery_WithdrawalReason { get { return _withdrawalReasonCode_NotInScopeSubQuery_WithdrawalReasonMap; }}
        public override String keepWithdrawalReasonCode_NotInScopeSubQuery_WithdrawalReason(WithdrawalReasonCQ subQuery) {
            if (_withdrawalReasonCode_NotInScopeSubQuery_WithdrawalReasonMap == null) { _withdrawalReasonCode_NotInScopeSubQuery_WithdrawalReasonMap = new LinkedHashMap<String, WithdrawalReasonCQ>(); }
            String key = "subQueryMapKey" + (_withdrawalReasonCode_NotInScopeSubQuery_WithdrawalReasonMap.size() + 1);
            _withdrawalReasonCode_NotInScopeSubQuery_WithdrawalReasonMap.put(key, subQuery); return "WithdrawalReasonCode_NotInScopeSubQuery_WithdrawalReason." + key;
        }

        public BsMemberWithdrawalCQ AddOrderBy_WithdrawalReasonCode_Asc() { regOBA("WITHDRAWAL_REASON_CODE");return this; }
        public BsMemberWithdrawalCQ AddOrderBy_WithdrawalReasonCode_Desc() { regOBD("WITHDRAWAL_REASON_CODE");return this; }

        protected ConditionValue _withdrawalReasonInputText;
        public ConditionValue WithdrawalReasonInputText {
            get { if (_withdrawalReasonInputText == null) { _withdrawalReasonInputText = new ConditionValue(); } return _withdrawalReasonInputText; }
        }
        protected override ConditionValue getCValueWithdrawalReasonInputText() { return this.WithdrawalReasonInputText; }


        public BsMemberWithdrawalCQ AddOrderBy_WithdrawalReasonInputText_Asc() { regOBA("WITHDRAWAL_REASON_INPUT_TEXT");return this; }
        public BsMemberWithdrawalCQ AddOrderBy_WithdrawalReasonInputText_Desc() { regOBD("WITHDRAWAL_REASON_INPUT_TEXT");return this; }

        protected ConditionValue _withdrawalDatetime;
        public ConditionValue WithdrawalDatetime {
            get { if (_withdrawalDatetime == null) { _withdrawalDatetime = new ConditionValue(); } return _withdrawalDatetime; }
        }
        protected override ConditionValue getCValueWithdrawalDatetime() { return this.WithdrawalDatetime; }


        public BsMemberWithdrawalCQ AddOrderBy_WithdrawalDatetime_Asc() { regOBA("WITHDRAWAL_DATETIME");return this; }
        public BsMemberWithdrawalCQ AddOrderBy_WithdrawalDatetime_Desc() { regOBD("WITHDRAWAL_DATETIME");return this; }

        protected ConditionValue _registerDatetime;
        public ConditionValue RegisterDatetime {
            get { if (_registerDatetime == null) { _registerDatetime = new ConditionValue(); } return _registerDatetime; }
        }
        protected override ConditionValue getCValueRegisterDatetime() { return this.RegisterDatetime; }


        public BsMemberWithdrawalCQ AddOrderBy_RegisterDatetime_Asc() { regOBA("REGISTER_DATETIME");return this; }
        public BsMemberWithdrawalCQ AddOrderBy_RegisterDatetime_Desc() { regOBD("REGISTER_DATETIME");return this; }

        protected ConditionValue _registerProcess;
        public ConditionValue RegisterProcess {
            get { if (_registerProcess == null) { _registerProcess = new ConditionValue(); } return _registerProcess; }
        }
        protected override ConditionValue getCValueRegisterProcess() { return this.RegisterProcess; }


        public BsMemberWithdrawalCQ AddOrderBy_RegisterProcess_Asc() { regOBA("REGISTER_PROCESS");return this; }
        public BsMemberWithdrawalCQ AddOrderBy_RegisterProcess_Desc() { regOBD("REGISTER_PROCESS");return this; }

        protected ConditionValue _registerUser;
        public ConditionValue RegisterUser {
            get { if (_registerUser == null) { _registerUser = new ConditionValue(); } return _registerUser; }
        }
        protected override ConditionValue getCValueRegisterUser() { return this.RegisterUser; }


        public BsMemberWithdrawalCQ AddOrderBy_RegisterUser_Asc() { regOBA("REGISTER_USER");return this; }
        public BsMemberWithdrawalCQ AddOrderBy_RegisterUser_Desc() { regOBD("REGISTER_USER");return this; }

        protected ConditionValue _updateDatetime;
        public ConditionValue UpdateDatetime {
            get { if (_updateDatetime == null) { _updateDatetime = new ConditionValue(); } return _updateDatetime; }
        }
        protected override ConditionValue getCValueUpdateDatetime() { return this.UpdateDatetime; }


        public BsMemberWithdrawalCQ AddOrderBy_UpdateDatetime_Asc() { regOBA("UPDATE_DATETIME");return this; }
        public BsMemberWithdrawalCQ AddOrderBy_UpdateDatetime_Desc() { regOBD("UPDATE_DATETIME");return this; }

        protected ConditionValue _updateProcess;
        public ConditionValue UpdateProcess {
            get { if (_updateProcess == null) { _updateProcess = new ConditionValue(); } return _updateProcess; }
        }
        protected override ConditionValue getCValueUpdateProcess() { return this.UpdateProcess; }


        public BsMemberWithdrawalCQ AddOrderBy_UpdateProcess_Asc() { regOBA("UPDATE_PROCESS");return this; }
        public BsMemberWithdrawalCQ AddOrderBy_UpdateProcess_Desc() { regOBD("UPDATE_PROCESS");return this; }

        protected ConditionValue _updateUser;
        public ConditionValue UpdateUser {
            get { if (_updateUser == null) { _updateUser = new ConditionValue(); } return _updateUser; }
        }
        protected override ConditionValue getCValueUpdateUser() { return this.UpdateUser; }


        public BsMemberWithdrawalCQ AddOrderBy_UpdateUser_Asc() { regOBA("UPDATE_USER");return this; }
        public BsMemberWithdrawalCQ AddOrderBy_UpdateUser_Desc() { regOBD("UPDATE_USER");return this; }

        protected ConditionValue _versionNo;
        public ConditionValue VersionNo {
            get { if (_versionNo == null) { _versionNo = new ConditionValue(); } return _versionNo; }
        }
        protected override ConditionValue getCValueVersionNo() { return this.VersionNo; }


        public BsMemberWithdrawalCQ AddOrderBy_VersionNo_Asc() { regOBA("VERSION_NO");return this; }
        public BsMemberWithdrawalCQ AddOrderBy_VersionNo_Desc() { regOBD("VERSION_NO");return this; }

        public BsMemberWithdrawalCQ AddSpecifiedDerivedOrderBy_Asc(String aliasName) { registerSpecifiedDerivedOrderBy_Asc(aliasName); return this; }
        public BsMemberWithdrawalCQ AddSpecifiedDerivedOrderBy_Desc(String aliasName) { registerSpecifiedDerivedOrderBy_Desc(aliasName); return this; }

        public override void reflectRelationOnUnionQuery(ConditionQuery baseQueryAsSuper, ConditionQuery unionQueryAsSuper) {
            MemberWithdrawalCQ baseQuery = (MemberWithdrawalCQ)baseQueryAsSuper;
            MemberWithdrawalCQ unionQuery = (MemberWithdrawalCQ)unionQueryAsSuper;
            if (baseQuery.hasConditionQueryMember()) {
                unionQuery.QueryMember().reflectRelationOnUnionQuery(baseQuery.QueryMember(), unionQuery.QueryMember());
            }
            if (baseQuery.hasConditionQueryWithdrawalReason()) {
                unionQuery.QueryWithdrawalReason().reflectRelationOnUnionQuery(baseQuery.QueryWithdrawalReason(), unionQuery.QueryWithdrawalReason());
            }

        }
    
        protected MemberCQ _conditionQueryMember;
        public MemberCQ QueryMember() {
            return this.ConditionQueryMember;
        }
        public MemberCQ ConditionQueryMember {
            get {
                if (_conditionQueryMember == null) {
                    _conditionQueryMember = xcreateQueryMember();
                    xsetupOuterJoin_Member();
                }
                return _conditionQueryMember;
            }
        }
        protected MemberCQ xcreateQueryMember() {
            String nrp = resolveNextRelationPathMember();
            String jan = resolveJoinAliasName(nrp, xgetNextNestLevel());
            MemberCQ cq = new MemberCQ(this, xgetSqlClause(), jan, xgetNextNestLevel());
            cq.xsetForeignPropertyName("member"); cq.xsetRelationPath(nrp); return cq;
        }
        public void xsetupOuterJoin_Member() {
            MemberCQ cq = ConditionQueryMember;
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
        protected WithdrawalReasonCQ _conditionQueryWithdrawalReason;
        public WithdrawalReasonCQ QueryWithdrawalReason() {
            return this.ConditionQueryWithdrawalReason;
        }
        public WithdrawalReasonCQ ConditionQueryWithdrawalReason {
            get {
                if (_conditionQueryWithdrawalReason == null) {
                    _conditionQueryWithdrawalReason = xcreateQueryWithdrawalReason();
                    xsetupOuterJoin_WithdrawalReason();
                }
                return _conditionQueryWithdrawalReason;
            }
        }
        protected WithdrawalReasonCQ xcreateQueryWithdrawalReason() {
            String nrp = resolveNextRelationPathWithdrawalReason();
            String jan = resolveJoinAliasName(nrp, xgetNextNestLevel());
            WithdrawalReasonCQ cq = new WithdrawalReasonCQ(this, xgetSqlClause(), jan, xgetNextNestLevel());
            cq.xsetForeignPropertyName("withdrawalReason"); cq.xsetRelationPath(nrp); return cq;
        }
        public void xsetupOuterJoin_WithdrawalReason() {
            WithdrawalReasonCQ cq = ConditionQueryWithdrawalReason;
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
	    protected Map<String, MemberWithdrawalCQ> _scalarSubQueryMap;
	    public Map<String, MemberWithdrawalCQ> ScalarSubQuery { get { return _scalarSubQueryMap; } }
	    public override String keepScalarSubQuery(MemberWithdrawalCQ subQuery) {
	        if (_scalarSubQueryMap == null) { _scalarSubQueryMap = new LinkedHashMap<String, MemberWithdrawalCQ>(); }
	        String key = "subQueryMapKey" + (_scalarSubQueryMap.size() + 1);
	        _scalarSubQueryMap.put(key, subQuery); return "ScalarSubQuery." + key;
	    }

        // ===============================================================================
        //                                                         Myself InScope SubQuery
        //                                                         =======================
        protected Map<String, MemberWithdrawalCQ> _myselfInScopeSubQueryMap;
        public Map<String, MemberWithdrawalCQ> MyselfInScopeSubQuery { get { return _myselfInScopeSubQueryMap; } }
        public override String keepMyselfInScopeSubQuery(MemberWithdrawalCQ subQuery) {
            if (_myselfInScopeSubQueryMap == null) { _myselfInScopeSubQueryMap = new LinkedHashMap<String, MemberWithdrawalCQ>(); }
            String key = "subQueryMapKey" + (_myselfInScopeSubQueryMap.size() + 1);
            _myselfInScopeSubQueryMap.put(key, subQuery); return "MyselfInScopeSubQuery." + key;
        }
    }
}
