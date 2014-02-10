
using System;

using DfExample.DBFlute.AllCommon.CBean;
using DfExample.DBFlute.AllCommon.CBean.CValue;
using DfExample.DBFlute.AllCommon.CBean.SClause;
using DfExample.DBFlute.AllCommon.JavaLike;
using DfExample.DBFlute.CBean.CQ;
using DfExample.DBFlute.CBean.CQ.Ciq;

namespace DfExample.DBFlute.CBean.CQ.BS {

    [System.Serializable]
    public class BsMemberSecurityCQ : AbstractBsMemberSecurityCQ {

        protected MemberSecurityCIQ _inlineQuery;

        public BsMemberSecurityCQ(ConditionQuery childQuery, SqlClause sqlClause, String aliasName, int nestLevel)
            : base(childQuery, sqlClause, aliasName, nestLevel) {}

        public MemberSecurityCIQ Inline() {
            if (_inlineQuery == null) {
                _inlineQuery = new MemberSecurityCIQ(xgetReferrerQuery(), xgetSqlClause(), xgetAliasName(), xgetNestLevel(), this);
            }
            _inlineQuery.xsetOnClause(false);
            return _inlineQuery;
        }
        
        public MemberSecurityCIQ On() {
            if (isBaseQuery()) { throw new UnsupportedOperationException("Unsupported onClause of Base Table!"); }
            MemberSecurityCIQ inlineQuery = Inline();
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

        public BsMemberSecurityCQ AddOrderBy_MemberId_Asc() { regOBA("MEMBER_ID");return this; }
        public BsMemberSecurityCQ AddOrderBy_MemberId_Desc() { regOBD("MEMBER_ID");return this; }

        protected ConditionValue _loginPassword;
        public ConditionValue LoginPassword {
            get { if (_loginPassword == null) { _loginPassword = new ConditionValue(); } return _loginPassword; }
        }
        protected override ConditionValue getCValueLoginPassword() { return this.LoginPassword; }


        public BsMemberSecurityCQ AddOrderBy_LoginPassword_Asc() { regOBA("LOGIN_PASSWORD");return this; }
        public BsMemberSecurityCQ AddOrderBy_LoginPassword_Desc() { regOBD("LOGIN_PASSWORD");return this; }

        protected ConditionValue _reminderQuestion;
        public ConditionValue ReminderQuestion {
            get { if (_reminderQuestion == null) { _reminderQuestion = new ConditionValue(); } return _reminderQuestion; }
        }
        protected override ConditionValue getCValueReminderQuestion() { return this.ReminderQuestion; }


        public BsMemberSecurityCQ AddOrderBy_ReminderQuestion_Asc() { regOBA("REMINDER_QUESTION");return this; }
        public BsMemberSecurityCQ AddOrderBy_ReminderQuestion_Desc() { regOBD("REMINDER_QUESTION");return this; }

        protected ConditionValue _reminderAnswer;
        public ConditionValue ReminderAnswer {
            get { if (_reminderAnswer == null) { _reminderAnswer = new ConditionValue(); } return _reminderAnswer; }
        }
        protected override ConditionValue getCValueReminderAnswer() { return this.ReminderAnswer; }


        public BsMemberSecurityCQ AddOrderBy_ReminderAnswer_Asc() { regOBA("REMINDER_ANSWER");return this; }
        public BsMemberSecurityCQ AddOrderBy_ReminderAnswer_Desc() { regOBD("REMINDER_ANSWER");return this; }

        protected ConditionValue _registerDatetime;
        public ConditionValue RegisterDatetime {
            get { if (_registerDatetime == null) { _registerDatetime = new ConditionValue(); } return _registerDatetime; }
        }
        protected override ConditionValue getCValueRegisterDatetime() { return this.RegisterDatetime; }


        public BsMemberSecurityCQ AddOrderBy_RegisterDatetime_Asc() { regOBA("REGISTER_DATETIME");return this; }
        public BsMemberSecurityCQ AddOrderBy_RegisterDatetime_Desc() { regOBD("REGISTER_DATETIME");return this; }

        protected ConditionValue _registerProcess;
        public ConditionValue RegisterProcess {
            get { if (_registerProcess == null) { _registerProcess = new ConditionValue(); } return _registerProcess; }
        }
        protected override ConditionValue getCValueRegisterProcess() { return this.RegisterProcess; }


        public BsMemberSecurityCQ AddOrderBy_RegisterProcess_Asc() { regOBA("REGISTER_PROCESS");return this; }
        public BsMemberSecurityCQ AddOrderBy_RegisterProcess_Desc() { regOBD("REGISTER_PROCESS");return this; }

        protected ConditionValue _registerUser;
        public ConditionValue RegisterUser {
            get { if (_registerUser == null) { _registerUser = new ConditionValue(); } return _registerUser; }
        }
        protected override ConditionValue getCValueRegisterUser() { return this.RegisterUser; }


        public BsMemberSecurityCQ AddOrderBy_RegisterUser_Asc() { regOBA("REGISTER_USER");return this; }
        public BsMemberSecurityCQ AddOrderBy_RegisterUser_Desc() { regOBD("REGISTER_USER");return this; }

        protected ConditionValue _updateDatetime;
        public ConditionValue UpdateDatetime {
            get { if (_updateDatetime == null) { _updateDatetime = new ConditionValue(); } return _updateDatetime; }
        }
        protected override ConditionValue getCValueUpdateDatetime() { return this.UpdateDatetime; }


        public BsMemberSecurityCQ AddOrderBy_UpdateDatetime_Asc() { regOBA("UPDATE_DATETIME");return this; }
        public BsMemberSecurityCQ AddOrderBy_UpdateDatetime_Desc() { regOBD("UPDATE_DATETIME");return this; }

        protected ConditionValue _updateProcess;
        public ConditionValue UpdateProcess {
            get { if (_updateProcess == null) { _updateProcess = new ConditionValue(); } return _updateProcess; }
        }
        protected override ConditionValue getCValueUpdateProcess() { return this.UpdateProcess; }


        public BsMemberSecurityCQ AddOrderBy_UpdateProcess_Asc() { regOBA("UPDATE_PROCESS");return this; }
        public BsMemberSecurityCQ AddOrderBy_UpdateProcess_Desc() { regOBD("UPDATE_PROCESS");return this; }

        protected ConditionValue _updateUser;
        public ConditionValue UpdateUser {
            get { if (_updateUser == null) { _updateUser = new ConditionValue(); } return _updateUser; }
        }
        protected override ConditionValue getCValueUpdateUser() { return this.UpdateUser; }


        public BsMemberSecurityCQ AddOrderBy_UpdateUser_Asc() { regOBA("UPDATE_USER");return this; }
        public BsMemberSecurityCQ AddOrderBy_UpdateUser_Desc() { regOBD("UPDATE_USER");return this; }

        protected ConditionValue _versionNo;
        public ConditionValue VersionNo {
            get { if (_versionNo == null) { _versionNo = new ConditionValue(); } return _versionNo; }
        }
        protected override ConditionValue getCValueVersionNo() { return this.VersionNo; }


        public BsMemberSecurityCQ AddOrderBy_VersionNo_Asc() { regOBA("VERSION_NO");return this; }
        public BsMemberSecurityCQ AddOrderBy_VersionNo_Desc() { regOBD("VERSION_NO");return this; }

        public BsMemberSecurityCQ AddSpecifiedDerivedOrderBy_Asc(String aliasName) { registerSpecifiedDerivedOrderBy_Asc(aliasName); return this; }
        public BsMemberSecurityCQ AddSpecifiedDerivedOrderBy_Desc(String aliasName) { registerSpecifiedDerivedOrderBy_Desc(aliasName); return this; }

        public override void reflectRelationOnUnionQuery(ConditionQuery baseQueryAsSuper, ConditionQuery unionQueryAsSuper) {
            MemberSecurityCQ baseQuery = (MemberSecurityCQ)baseQueryAsSuper;
            MemberSecurityCQ unionQuery = (MemberSecurityCQ)unionQueryAsSuper;
            if (baseQuery.hasConditionQueryMember()) {
                unionQuery.QueryMember().reflectRelationOnUnionQuery(baseQuery.QueryMember(), unionQuery.QueryMember());
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
            return resolveNextRelationPath("member_security", "member");
        }
        public bool hasConditionQueryMember() {
            return _conditionQueryMember != null;
        }


	    // ===============================================================================
	    //                                                                 Scalar SubQuery
	    //                                                                 ===============
	    protected Map<String, MemberSecurityCQ> _scalarSubQueryMap;
	    public Map<String, MemberSecurityCQ> ScalarSubQuery { get { return _scalarSubQueryMap; } }
	    public override String keepScalarSubQuery(MemberSecurityCQ subQuery) {
	        if (_scalarSubQueryMap == null) { _scalarSubQueryMap = new LinkedHashMap<String, MemberSecurityCQ>(); }
	        String key = "subQueryMapKey" + (_scalarSubQueryMap.size() + 1);
	        _scalarSubQueryMap.put(key, subQuery); return "ScalarSubQuery." + key;
	    }

        // ===============================================================================
        //                                                         Myself InScope SubQuery
        //                                                         =======================
        protected Map<String, MemberSecurityCQ> _myselfInScopeSubQueryMap;
        public Map<String, MemberSecurityCQ> MyselfInScopeSubQuery { get { return _myselfInScopeSubQueryMap; } }
        public override String keepMyselfInScopeSubQuery(MemberSecurityCQ subQuery) {
            if (_myselfInScopeSubQueryMap == null) { _myselfInScopeSubQueryMap = new LinkedHashMap<String, MemberSecurityCQ>(); }
            String key = "subQueryMapKey" + (_myselfInScopeSubQueryMap.size() + 1);
            _myselfInScopeSubQueryMap.put(key, subQuery); return "MyselfInScopeSubQuery." + key;
        }
    }
}
