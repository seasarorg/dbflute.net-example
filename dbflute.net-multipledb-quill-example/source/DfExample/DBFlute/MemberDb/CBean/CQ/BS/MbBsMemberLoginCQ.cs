
using System;

using DfExample.DBFlute.MemberDb.AllCommon.CBean;
using DfExample.DBFlute.MemberDb.AllCommon.CBean.CValue;
using DfExample.DBFlute.MemberDb.AllCommon.CBean.SClause;
using DfExample.DBFlute.MemberDb.AllCommon.JavaLike;
using DfExample.DBFlute.MemberDb.CBean.CQ;
using DfExample.DBFlute.MemberDb.CBean.CQ.Ciq;

namespace DfExample.DBFlute.MemberDb.CBean.CQ.BS {

    [System.Serializable]
    public class MbBsMemberLoginCQ : MbAbstractBsMemberLoginCQ {

        protected MbMemberLoginCIQ _inlineQuery;

        public MbBsMemberLoginCQ(MbConditionQuery childQuery, MbSqlClause sqlClause, String aliasName, int nestLevel)
            : base(childQuery, sqlClause, aliasName, nestLevel) {}

        public MbMemberLoginCIQ Inline() {
            if (_inlineQuery == null) {
                _inlineQuery = new MbMemberLoginCIQ(xgetReferrerQuery(), xgetSqlClause(), xgetAliasName(), xgetNestLevel(), this);
            }
            _inlineQuery.xsetOnClause(false);
            return _inlineQuery;
        }
        
        public MbMemberLoginCIQ On() {
            if (isBaseQuery()) { throw new UnsupportedOperationException("Unsupported onClause of Base Table!"); }
            MbMemberLoginCIQ inlineQuery = Inline();
            inlineQuery.xsetOnClause(true);
            return inlineQuery;
        }


        protected MbConditionValue _memberLoginId;
        public MbConditionValue MemberLoginId {
            get { if (_memberLoginId == null) { _memberLoginId = new MbConditionValue(); } return _memberLoginId; }
        }
        protected override MbConditionValue getCValueMemberLoginId() { return this.MemberLoginId; }


        public MbBsMemberLoginCQ AddOrderBy_MemberLoginId_Asc() { regOBA("MEMBER_LOGIN_ID");return this; }
        public MbBsMemberLoginCQ AddOrderBy_MemberLoginId_Desc() { regOBD("MEMBER_LOGIN_ID");return this; }

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

        public MbBsMemberLoginCQ AddOrderBy_MemberId_Asc() { regOBA("MEMBER_ID");return this; }
        public MbBsMemberLoginCQ AddOrderBy_MemberId_Desc() { regOBD("MEMBER_ID");return this; }

        protected MbConditionValue _loginDatetime;
        public MbConditionValue LoginDatetime {
            get { if (_loginDatetime == null) { _loginDatetime = new MbConditionValue(); } return _loginDatetime; }
        }
        protected override MbConditionValue getCValueLoginDatetime() { return this.LoginDatetime; }


        public MbBsMemberLoginCQ AddOrderBy_LoginDatetime_Asc() { regOBA("LOGIN_DATETIME");return this; }
        public MbBsMemberLoginCQ AddOrderBy_LoginDatetime_Desc() { regOBD("LOGIN_DATETIME");return this; }

        protected MbConditionValue _mobileLoginFlg;
        public MbConditionValue MobileLoginFlg {
            get { if (_mobileLoginFlg == null) { _mobileLoginFlg = new MbConditionValue(); } return _mobileLoginFlg; }
        }
        protected override MbConditionValue getCValueMobileLoginFlg() { return this.MobileLoginFlg; }


        public MbBsMemberLoginCQ AddOrderBy_MobileLoginFlg_Asc() { regOBA("MOBILE_LOGIN_FLG");return this; }
        public MbBsMemberLoginCQ AddOrderBy_MobileLoginFlg_Desc() { regOBD("MOBILE_LOGIN_FLG");return this; }

        protected MbConditionValue _loginMemberStatusCode;
        public MbConditionValue LoginMemberStatusCode {
            get { if (_loginMemberStatusCode == null) { _loginMemberStatusCode = new MbConditionValue(); } return _loginMemberStatusCode; }
        }
        protected override MbConditionValue getCValueLoginMemberStatusCode() { return this.LoginMemberStatusCode; }


        protected Map<String, MbMemberStatusCQ> _loginMemberStatusCode_InScopeSubQuery_MemberStatusMap;
        public Map<String, MbMemberStatusCQ> LoginMemberStatusCode_InScopeSubQuery_MemberStatus { get { return _loginMemberStatusCode_InScopeSubQuery_MemberStatusMap; }}
        public override String keepLoginMemberStatusCode_InScopeSubQuery_MemberStatus(MbMemberStatusCQ subQuery) {
            if (_loginMemberStatusCode_InScopeSubQuery_MemberStatusMap == null) { _loginMemberStatusCode_InScopeSubQuery_MemberStatusMap = new LinkedHashMap<String, MbMemberStatusCQ>(); }
            String key = "subQueryMapKey" + (_loginMemberStatusCode_InScopeSubQuery_MemberStatusMap.size() + 1);
            _loginMemberStatusCode_InScopeSubQuery_MemberStatusMap.put(key, subQuery); return "LoginMemberStatusCode_InScopeSubQuery_MemberStatus." + key;
        }

        protected Map<String, MbMemberStatusCQ> _loginMemberStatusCode_NotInScopeSubQuery_MemberStatusMap;
        public Map<String, MbMemberStatusCQ> LoginMemberStatusCode_NotInScopeSubQuery_MemberStatus { get { return _loginMemberStatusCode_NotInScopeSubQuery_MemberStatusMap; }}
        public override String keepLoginMemberStatusCode_NotInScopeSubQuery_MemberStatus(MbMemberStatusCQ subQuery) {
            if (_loginMemberStatusCode_NotInScopeSubQuery_MemberStatusMap == null) { _loginMemberStatusCode_NotInScopeSubQuery_MemberStatusMap = new LinkedHashMap<String, MbMemberStatusCQ>(); }
            String key = "subQueryMapKey" + (_loginMemberStatusCode_NotInScopeSubQuery_MemberStatusMap.size() + 1);
            _loginMemberStatusCode_NotInScopeSubQuery_MemberStatusMap.put(key, subQuery); return "LoginMemberStatusCode_NotInScopeSubQuery_MemberStatus." + key;
        }

        public MbBsMemberLoginCQ AddOrderBy_LoginMemberStatusCode_Asc() { regOBA("LOGIN_MEMBER_STATUS_CODE");return this; }
        public MbBsMemberLoginCQ AddOrderBy_LoginMemberStatusCode_Desc() { regOBD("LOGIN_MEMBER_STATUS_CODE");return this; }

        public MbBsMemberLoginCQ AddSpecifiedDerivedOrderBy_Asc(String aliasName) { registerSpecifiedDerivedOrderBy_Asc(aliasName); return this; }
        public MbBsMemberLoginCQ AddSpecifiedDerivedOrderBy_Desc(String aliasName) { registerSpecifiedDerivedOrderBy_Desc(aliasName); return this; }

        public override void reflectRelationOnUnionQuery(MbConditionQuery baseQueryAsSuper, MbConditionQuery unionQueryAsSuper) {
            MbMemberLoginCQ baseQuery = (MbMemberLoginCQ)baseQueryAsSuper;
            MbMemberLoginCQ unionQuery = (MbMemberLoginCQ)unionQueryAsSuper;
            if (baseQuery.hasConditionQueryMember()) {
                unionQuery.QueryMember().reflectRelationOnUnionQuery(baseQuery.QueryMember(), unionQuery.QueryMember());
            }
            if (baseQuery.hasConditionQueryMemberStatus()) {
                unionQuery.QueryMemberStatus().reflectRelationOnUnionQuery(baseQuery.QueryMemberStatus(), unionQuery.QueryMemberStatus());
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
            return resolveNextRelationPath("member_login", "member");
        }
        public bool hasConditionQueryMember() {
            return _conditionQueryMember != null;
        }
        protected MbMemberStatusCQ _conditionQueryMemberStatus;
        public MbMemberStatusCQ QueryMemberStatus() {
            return this.ConditionQueryMemberStatus;
        }
        public MbMemberStatusCQ ConditionQueryMemberStatus {
            get {
                if (_conditionQueryMemberStatus == null) {
                    _conditionQueryMemberStatus = xcreateQueryMemberStatus();
                    xsetupOuterJoin_MemberStatus();
                }
                return _conditionQueryMemberStatus;
            }
        }
        protected MbMemberStatusCQ xcreateQueryMemberStatus() {
            String nrp = resolveNextRelationPathMemberStatus();
            String jan = resolveJoinAliasName(nrp, xgetNextNestLevel());
            MbMemberStatusCQ cq = new MbMemberStatusCQ(this, xgetSqlClause(), jan, xgetNextNestLevel());
            cq.xsetForeignPropertyName("memberStatus"); cq.xsetRelationPath(nrp); return cq;
        }
        public void xsetupOuterJoin_MemberStatus() {
            MbMemberStatusCQ cq = ConditionQueryMemberStatus;
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
	    protected Map<String, MbMemberLoginCQ> _scalarSubQueryMap;
	    public Map<String, MbMemberLoginCQ> ScalarSubQuery { get { return _scalarSubQueryMap; } }
	    public override String keepScalarSubQuery(MbMemberLoginCQ subQuery) {
	        if (_scalarSubQueryMap == null) { _scalarSubQueryMap = new LinkedHashMap<String, MbMemberLoginCQ>(); }
	        String key = "subQueryMapKey" + (_scalarSubQueryMap.size() + 1);
	        _scalarSubQueryMap.put(key, subQuery); return "ScalarSubQuery." + key;
	    }

        // ===============================================================================
        //                                                         Myself InScope SubQuery
        //                                                         =======================
        protected Map<String, MbMemberLoginCQ> _myselfInScopeSubQueryMap;
        public Map<String, MbMemberLoginCQ> MyselfInScopeSubQuery { get { return _myselfInScopeSubQueryMap; } }
        public override String keepMyselfInScopeSubQuery(MbMemberLoginCQ subQuery) {
            if (_myselfInScopeSubQueryMap == null) { _myselfInScopeSubQueryMap = new LinkedHashMap<String, MbMemberLoginCQ>(); }
            String key = "subQueryMapKey" + (_myselfInScopeSubQueryMap.size() + 1);
            _myselfInScopeSubQueryMap.put(key, subQuery); return "MyselfInScopeSubQuery." + key;
        }
    }
}
