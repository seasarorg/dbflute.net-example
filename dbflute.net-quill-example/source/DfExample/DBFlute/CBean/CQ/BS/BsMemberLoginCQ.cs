
using System;

using DfExample.DBFlute.AllCommon.CBean;
using DfExample.DBFlute.AllCommon.CBean.CValue;
using DfExample.DBFlute.AllCommon.CBean.SClause;
using DfExample.DBFlute.AllCommon.JavaLike;
using DfExample.DBFlute.CBean.CQ;
using DfExample.DBFlute.CBean.CQ.Ciq;

namespace DfExample.DBFlute.CBean.CQ.BS {

    [System.Serializable]
    public class BsMemberLoginCQ : AbstractBsMemberLoginCQ {

        protected MemberLoginCIQ _inlineQuery;

        public BsMemberLoginCQ(ConditionQuery childQuery, SqlClause sqlClause, String aliasName, int nestLevel)
            : base(childQuery, sqlClause, aliasName, nestLevel) {}

        public MemberLoginCIQ Inline() {
            if (_inlineQuery == null) {
                _inlineQuery = new MemberLoginCIQ(xgetReferrerQuery(), xgetSqlClause(), xgetAliasName(), xgetNestLevel(), this);
            }
            _inlineQuery.xsetOnClause(false);
            return _inlineQuery;
        }
        
        public MemberLoginCIQ On() {
            if (isBaseQuery()) { throw new UnsupportedOperationException("Unsupported onClause of Base Table!"); }
            MemberLoginCIQ inlineQuery = Inline();
            inlineQuery.xsetOnClause(true);
            return inlineQuery;
        }


        protected ConditionValue _memberLoginId;
        public ConditionValue MemberLoginId {
            get { if (_memberLoginId == null) { _memberLoginId = new ConditionValue(); } return _memberLoginId; }
        }
        protected override ConditionValue getCValueMemberLoginId() { return this.MemberLoginId; }


        public BsMemberLoginCQ AddOrderBy_MemberLoginId_Asc() { regOBA("MEMBER_LOGIN_ID");return this; }
        public BsMemberLoginCQ AddOrderBy_MemberLoginId_Desc() { regOBD("MEMBER_LOGIN_ID");return this; }

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

        public BsMemberLoginCQ AddOrderBy_MemberId_Asc() { regOBA("MEMBER_ID");return this; }
        public BsMemberLoginCQ AddOrderBy_MemberId_Desc() { regOBD("MEMBER_ID");return this; }

        protected ConditionValue _loginDatetime;
        public ConditionValue LoginDatetime {
            get { if (_loginDatetime == null) { _loginDatetime = new ConditionValue(); } return _loginDatetime; }
        }
        protected override ConditionValue getCValueLoginDatetime() { return this.LoginDatetime; }


        public BsMemberLoginCQ AddOrderBy_LoginDatetime_Asc() { regOBA("LOGIN_DATETIME");return this; }
        public BsMemberLoginCQ AddOrderBy_LoginDatetime_Desc() { regOBD("LOGIN_DATETIME");return this; }

        protected ConditionValue _mobileLoginFlg;
        public ConditionValue MobileLoginFlg {
            get { if (_mobileLoginFlg == null) { _mobileLoginFlg = new ConditionValue(); } return _mobileLoginFlg; }
        }
        protected override ConditionValue getCValueMobileLoginFlg() { return this.MobileLoginFlg; }


        public BsMemberLoginCQ AddOrderBy_MobileLoginFlg_Asc() { regOBA("MOBILE_LOGIN_FLG");return this; }
        public BsMemberLoginCQ AddOrderBy_MobileLoginFlg_Desc() { regOBD("MOBILE_LOGIN_FLG");return this; }

        protected ConditionValue _loginMemberStatusCode;
        public ConditionValue LoginMemberStatusCode {
            get { if (_loginMemberStatusCode == null) { _loginMemberStatusCode = new ConditionValue(); } return _loginMemberStatusCode; }
        }
        protected override ConditionValue getCValueLoginMemberStatusCode() { return this.LoginMemberStatusCode; }


        protected Map<String, MemberStatusCQ> _loginMemberStatusCode_InScopeSubQuery_MemberStatusMap;
        public Map<String, MemberStatusCQ> LoginMemberStatusCode_InScopeSubQuery_MemberStatus { get { return _loginMemberStatusCode_InScopeSubQuery_MemberStatusMap; }}
        public override String keepLoginMemberStatusCode_InScopeSubQuery_MemberStatus(MemberStatusCQ subQuery) {
            if (_loginMemberStatusCode_InScopeSubQuery_MemberStatusMap == null) { _loginMemberStatusCode_InScopeSubQuery_MemberStatusMap = new LinkedHashMap<String, MemberStatusCQ>(); }
            String key = "subQueryMapKey" + (_loginMemberStatusCode_InScopeSubQuery_MemberStatusMap.size() + 1);
            _loginMemberStatusCode_InScopeSubQuery_MemberStatusMap.put(key, subQuery); return "LoginMemberStatusCode_InScopeSubQuery_MemberStatus." + key;
        }

        protected Map<String, MemberStatusCQ> _loginMemberStatusCode_NotInScopeSubQuery_MemberStatusMap;
        public Map<String, MemberStatusCQ> LoginMemberStatusCode_NotInScopeSubQuery_MemberStatus { get { return _loginMemberStatusCode_NotInScopeSubQuery_MemberStatusMap; }}
        public override String keepLoginMemberStatusCode_NotInScopeSubQuery_MemberStatus(MemberStatusCQ subQuery) {
            if (_loginMemberStatusCode_NotInScopeSubQuery_MemberStatusMap == null) { _loginMemberStatusCode_NotInScopeSubQuery_MemberStatusMap = new LinkedHashMap<String, MemberStatusCQ>(); }
            String key = "subQueryMapKey" + (_loginMemberStatusCode_NotInScopeSubQuery_MemberStatusMap.size() + 1);
            _loginMemberStatusCode_NotInScopeSubQuery_MemberStatusMap.put(key, subQuery); return "LoginMemberStatusCode_NotInScopeSubQuery_MemberStatus." + key;
        }

        public BsMemberLoginCQ AddOrderBy_LoginMemberStatusCode_Asc() { regOBA("LOGIN_MEMBER_STATUS_CODE");return this; }
        public BsMemberLoginCQ AddOrderBy_LoginMemberStatusCode_Desc() { regOBD("LOGIN_MEMBER_STATUS_CODE");return this; }

        public BsMemberLoginCQ AddSpecifiedDerivedOrderBy_Asc(String aliasName) { registerSpecifiedDerivedOrderBy_Asc(aliasName); return this; }
        public BsMemberLoginCQ AddSpecifiedDerivedOrderBy_Desc(String aliasName) { registerSpecifiedDerivedOrderBy_Desc(aliasName); return this; }

        public override void reflectRelationOnUnionQuery(ConditionQuery baseQueryAsSuper, ConditionQuery unionQueryAsSuper) {
            MemberLoginCQ baseQuery = (MemberLoginCQ)baseQueryAsSuper;
            MemberLoginCQ unionQuery = (MemberLoginCQ)unionQueryAsSuper;
            if (baseQuery.hasConditionQueryMember()) {
                unionQuery.QueryMember().reflectRelationOnUnionQuery(baseQuery.QueryMember(), unionQuery.QueryMember());
            }
            if (baseQuery.hasConditionQueryMemberStatus()) {
                unionQuery.QueryMemberStatus().reflectRelationOnUnionQuery(baseQuery.QueryMemberStatus(), unionQuery.QueryMemberStatus());
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
            return resolveNextRelationPath("member_login", "member");
        }
        public bool hasConditionQueryMember() {
            return _conditionQueryMember != null;
        }
        protected MemberStatusCQ _conditionQueryMemberStatus;
        public MemberStatusCQ QueryMemberStatus() {
            return this.ConditionQueryMemberStatus;
        }
        public MemberStatusCQ ConditionQueryMemberStatus {
            get {
                if (_conditionQueryMemberStatus == null) {
                    _conditionQueryMemberStatus = xcreateQueryMemberStatus();
                    xsetupOuterJoin_MemberStatus();
                }
                return _conditionQueryMemberStatus;
            }
        }
        protected MemberStatusCQ xcreateQueryMemberStatus() {
            String nrp = resolveNextRelationPathMemberStatus();
            String jan = resolveJoinAliasName(nrp, xgetNextNestLevel());
            MemberStatusCQ cq = new MemberStatusCQ(this, xgetSqlClause(), jan, xgetNextNestLevel());
            cq.xsetForeignPropertyName("memberStatus"); cq.xsetRelationPath(nrp); return cq;
        }
        public void xsetupOuterJoin_MemberStatus() {
            MemberStatusCQ cq = ConditionQueryMemberStatus;
            Map<String, String> joinOnMap = new LinkedHashMap<String, String>();
            joinOnMap.put("LOGIN_MEMBER_STATUS_CODE", "MEMBER_STATUS_CODE");
            registerOuterJoin(cq, joinOnMap);
        }
        protected String resolveNextRelationPathMemberStatus() {
            return resolveNextRelationPath("member_login", "memberStatus");
        }
        public bool hasConditionQueryMemberStatus() {
            return _conditionQueryMemberStatus != null;
        }


	    // ===============================================================================
	    //                                                                 Scalar SubQuery
	    //                                                                 ===============
	    protected Map<String, MemberLoginCQ> _scalarSubQueryMap;
	    public Map<String, MemberLoginCQ> ScalarSubQuery { get { return _scalarSubQueryMap; } }
	    public override String keepScalarSubQuery(MemberLoginCQ subQuery) {
	        if (_scalarSubQueryMap == null) { _scalarSubQueryMap = new LinkedHashMap<String, MemberLoginCQ>(); }
	        String key = "subQueryMapKey" + (_scalarSubQueryMap.size() + 1);
	        _scalarSubQueryMap.put(key, subQuery); return "ScalarSubQuery." + key;
	    }

        // ===============================================================================
        //                                                         Myself InScope SubQuery
        //                                                         =======================
        protected Map<String, MemberLoginCQ> _myselfInScopeSubQueryMap;
        public Map<String, MemberLoginCQ> MyselfInScopeSubQuery { get { return _myselfInScopeSubQueryMap; } }
        public override String keepMyselfInScopeSubQuery(MemberLoginCQ subQuery) {
            if (_myselfInScopeSubQueryMap == null) { _myselfInScopeSubQueryMap = new LinkedHashMap<String, MemberLoginCQ>(); }
            String key = "subQueryMapKey" + (_myselfInScopeSubQueryMap.size() + 1);
            _myselfInScopeSubQueryMap.put(key, subQuery); return "MyselfInScopeSubQuery." + key;
        }
    }
}
