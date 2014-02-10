
using System;

using DfExample.DBFlute.AllCommon.CBean;
using DfExample.DBFlute.AllCommon.CBean.CValue;
using DfExample.DBFlute.AllCommon.CBean.SClause;
using DfExample.DBFlute.AllCommon.JavaLike;
using DfExample.DBFlute.CBean.CQ;
using DfExample.DBFlute.CBean.CQ.Ciq;

namespace DfExample.DBFlute.CBean.CQ.BS {

    [System.Serializable]
    public class BsVdSynonymMemberLoginCQ : AbstractBsVdSynonymMemberLoginCQ {

        protected VdSynonymMemberLoginCIQ _inlineQuery;

        public BsVdSynonymMemberLoginCQ(ConditionQuery childQuery, SqlClause sqlClause, String aliasName, int nestLevel)
            : base(childQuery, sqlClause, aliasName, nestLevel) {}

        public VdSynonymMemberLoginCIQ Inline() {
            if (_inlineQuery == null) {
                _inlineQuery = new VdSynonymMemberLoginCIQ(xgetReferrerQuery(), xgetSqlClause(), xgetAliasName(), xgetNestLevel(), this);
            }
            _inlineQuery.xsetOnClause(false);
            return _inlineQuery;
        }
        
        public VdSynonymMemberLoginCIQ On() {
            if (isBaseQuery()) { throw new UnsupportedOperationException("Unsupported onClause of Base Table!"); }
            VdSynonymMemberLoginCIQ inlineQuery = Inline();
            inlineQuery.xsetOnClause(true);
            return inlineQuery;
        }


        protected ConditionValue _memberLoginId;
        public ConditionValue MemberLoginId {
            get { if (_memberLoginId == null) { _memberLoginId = new ConditionValue(); } return _memberLoginId; }
        }
        protected override ConditionValue getCValueMemberLoginId() { return this.MemberLoginId; }


        public BsVdSynonymMemberLoginCQ AddOrderBy_MemberLoginId_Asc() { regOBA("MEMBER_LOGIN_ID");return this; }
        public BsVdSynonymMemberLoginCQ AddOrderBy_MemberLoginId_Desc() { regOBD("MEMBER_LOGIN_ID");return this; }

        protected ConditionValue _memberId;
        public ConditionValue MemberId {
            get { if (_memberId == null) { _memberId = new ConditionValue(); } return _memberId; }
        }
        protected override ConditionValue getCValueMemberId() { return this.MemberId; }


        protected Map<String, MemberVendorSynonymCQ> _memberId_InScopeSubQuery_MemberVendorSynonymMap;
        public Map<String, MemberVendorSynonymCQ> MemberId_InScopeSubQuery_MemberVendorSynonym { get { return _memberId_InScopeSubQuery_MemberVendorSynonymMap; }}
        public override String keepMemberId_InScopeSubQuery_MemberVendorSynonym(MemberVendorSynonymCQ subQuery) {
            if (_memberId_InScopeSubQuery_MemberVendorSynonymMap == null) { _memberId_InScopeSubQuery_MemberVendorSynonymMap = new LinkedHashMap<String, MemberVendorSynonymCQ>(); }
            String key = "subQueryMapKey" + (_memberId_InScopeSubQuery_MemberVendorSynonymMap.size() + 1);
            _memberId_InScopeSubQuery_MemberVendorSynonymMap.put(key, subQuery); return "MemberId_InScopeSubQuery_MemberVendorSynonym." + key;
        }

        protected Map<String, MemberVendorSynonymCQ> _memberId_NotInScopeSubQuery_MemberVendorSynonymMap;
        public Map<String, MemberVendorSynonymCQ> MemberId_NotInScopeSubQuery_MemberVendorSynonym { get { return _memberId_NotInScopeSubQuery_MemberVendorSynonymMap; }}
        public override String keepMemberId_NotInScopeSubQuery_MemberVendorSynonym(MemberVendorSynonymCQ subQuery) {
            if (_memberId_NotInScopeSubQuery_MemberVendorSynonymMap == null) { _memberId_NotInScopeSubQuery_MemberVendorSynonymMap = new LinkedHashMap<String, MemberVendorSynonymCQ>(); }
            String key = "subQueryMapKey" + (_memberId_NotInScopeSubQuery_MemberVendorSynonymMap.size() + 1);
            _memberId_NotInScopeSubQuery_MemberVendorSynonymMap.put(key, subQuery); return "MemberId_NotInScopeSubQuery_MemberVendorSynonym." + key;
        }

        public BsVdSynonymMemberLoginCQ AddOrderBy_MemberId_Asc() { regOBA("MEMBER_ID");return this; }
        public BsVdSynonymMemberLoginCQ AddOrderBy_MemberId_Desc() { regOBD("MEMBER_ID");return this; }

        protected ConditionValue _loginDatetime;
        public ConditionValue LoginDatetime {
            get { if (_loginDatetime == null) { _loginDatetime = new ConditionValue(); } return _loginDatetime; }
        }
        protected override ConditionValue getCValueLoginDatetime() { return this.LoginDatetime; }


        public BsVdSynonymMemberLoginCQ AddOrderBy_LoginDatetime_Asc() { regOBA("LOGIN_DATETIME");return this; }
        public BsVdSynonymMemberLoginCQ AddOrderBy_LoginDatetime_Desc() { regOBD("LOGIN_DATETIME");return this; }

        protected ConditionValue _mobileLoginFlg;
        public ConditionValue MobileLoginFlg {
            get { if (_mobileLoginFlg == null) { _mobileLoginFlg = new ConditionValue(); } return _mobileLoginFlg; }
        }
        protected override ConditionValue getCValueMobileLoginFlg() { return this.MobileLoginFlg; }


        public BsVdSynonymMemberLoginCQ AddOrderBy_MobileLoginFlg_Asc() { regOBA("MOBILE_LOGIN_FLG");return this; }
        public BsVdSynonymMemberLoginCQ AddOrderBy_MobileLoginFlg_Desc() { regOBD("MOBILE_LOGIN_FLG");return this; }

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

        public BsVdSynonymMemberLoginCQ AddOrderBy_LoginMemberStatusCode_Asc() { regOBA("LOGIN_MEMBER_STATUS_CODE");return this; }
        public BsVdSynonymMemberLoginCQ AddOrderBy_LoginMemberStatusCode_Desc() { regOBD("LOGIN_MEMBER_STATUS_CODE");return this; }

        public BsVdSynonymMemberLoginCQ AddSpecifiedDerivedOrderBy_Asc(String aliasName) { registerSpecifiedDerivedOrderBy_Asc(aliasName); return this; }
        public BsVdSynonymMemberLoginCQ AddSpecifiedDerivedOrderBy_Desc(String aliasName) { registerSpecifiedDerivedOrderBy_Desc(aliasName); return this; }

        public override void reflectRelationOnUnionQuery(ConditionQuery baseQueryAsSuper, ConditionQuery unionQueryAsSuper) {
            VdSynonymMemberLoginCQ baseQuery = (VdSynonymMemberLoginCQ)baseQueryAsSuper;
            VdSynonymMemberLoginCQ unionQuery = (VdSynonymMemberLoginCQ)unionQueryAsSuper;
            if (baseQuery.hasConditionQueryMemberVendorSynonym()) {
                unionQuery.QueryMemberVendorSynonym().reflectRelationOnUnionQuery(baseQuery.QueryMemberVendorSynonym(), unionQuery.QueryMemberVendorSynonym());
            }
            if (baseQuery.hasConditionQueryMemberStatus()) {
                unionQuery.QueryMemberStatus().reflectRelationOnUnionQuery(baseQuery.QueryMemberStatus(), unionQuery.QueryMemberStatus());
            }
            if (baseQuery.hasConditionQueryVdSynonymMember()) {
                unionQuery.QueryVdSynonymMember().reflectRelationOnUnionQuery(baseQuery.QueryVdSynonymMember(), unionQuery.QueryVdSynonymMember());
            }
            if (baseQuery.hasConditionQueryVendorSynonymMember()) {
                unionQuery.QueryVendorSynonymMember().reflectRelationOnUnionQuery(baseQuery.QueryVendorSynonymMember(), unionQuery.QueryVendorSynonymMember());
            }

        }
    
        protected MemberVendorSynonymCQ _conditionQueryMemberVendorSynonym;
        public MemberVendorSynonymCQ QueryMemberVendorSynonym() {
            return this.ConditionQueryMemberVendorSynonym;
        }
        public MemberVendorSynonymCQ ConditionQueryMemberVendorSynonym {
            get {
                if (_conditionQueryMemberVendorSynonym == null) {
                    _conditionQueryMemberVendorSynonym = xcreateQueryMemberVendorSynonym();
                    xsetupOuterJoin_MemberVendorSynonym();
                }
                return _conditionQueryMemberVendorSynonym;
            }
        }
        protected MemberVendorSynonymCQ xcreateQueryMemberVendorSynonym() {
            String nrp = resolveNextRelationPathMemberVendorSynonym();
            String jan = resolveJoinAliasName(nrp, xgetNextNestLevel());
            MemberVendorSynonymCQ cq = new MemberVendorSynonymCQ(this, xgetSqlClause(), jan, xgetNextNestLevel());
            cq.xsetForeignPropertyName("memberVendorSynonym"); cq.xsetRelationPath(nrp); return cq;
        }
        public void xsetupOuterJoin_MemberVendorSynonym() {
            MemberVendorSynonymCQ cq = ConditionQueryMemberVendorSynonym;
            Map<String, String> joinOnMap = new LinkedHashMap<String, String>();
            joinOnMap.put("MEMBER_ID", "MEMBER_ID");
            registerOuterJoin(cq, joinOnMap);
        }
        protected String resolveNextRelationPathMemberVendorSynonym() {
            return resolveNextRelationPath("VD_SYNONYM_MEMBER_LOGIN", "memberVendorSynonym");
        }
        public bool hasConditionQueryMemberVendorSynonym() {
            return _conditionQueryMemberVendorSynonym != null;
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
            return resolveNextRelationPath("VD_SYNONYM_MEMBER_LOGIN", "memberStatus");
        }
        public bool hasConditionQueryMemberStatus() {
            return _conditionQueryMemberStatus != null;
        }
        protected VdSynonymMemberCQ _conditionQueryVdSynonymMember;
        public VdSynonymMemberCQ QueryVdSynonymMember() {
            return this.ConditionQueryVdSynonymMember;
        }
        public VdSynonymMemberCQ ConditionQueryVdSynonymMember {
            get {
                if (_conditionQueryVdSynonymMember == null) {
                    _conditionQueryVdSynonymMember = xcreateQueryVdSynonymMember();
                    xsetupOuterJoin_VdSynonymMember();
                }
                return _conditionQueryVdSynonymMember;
            }
        }
        protected VdSynonymMemberCQ xcreateQueryVdSynonymMember() {
            String nrp = resolveNextRelationPathVdSynonymMember();
            String jan = resolveJoinAliasName(nrp, xgetNextNestLevel());
            VdSynonymMemberCQ cq = new VdSynonymMemberCQ(this, xgetSqlClause(), jan, xgetNextNestLevel());
            cq.xsetForeignPropertyName("vdSynonymMember"); cq.xsetRelationPath(nrp); return cq;
        }
        public void xsetupOuterJoin_VdSynonymMember() {
            VdSynonymMemberCQ cq = ConditionQueryVdSynonymMember;
            Map<String, String> joinOnMap = new LinkedHashMap<String, String>();
            joinOnMap.put("MEMBER_ID", "MEMBER_ID");
            registerOuterJoin(cq, joinOnMap);
        }
        protected String resolveNextRelationPathVdSynonymMember() {
            return resolveNextRelationPath("VD_SYNONYM_MEMBER_LOGIN", "vdSynonymMember");
        }
        public bool hasConditionQueryVdSynonymMember() {
            return _conditionQueryVdSynonymMember != null;
        }
        protected VendorSynonymMemberCQ _conditionQueryVendorSynonymMember;
        public VendorSynonymMemberCQ QueryVendorSynonymMember() {
            return this.ConditionQueryVendorSynonymMember;
        }
        public VendorSynonymMemberCQ ConditionQueryVendorSynonymMember {
            get {
                if (_conditionQueryVendorSynonymMember == null) {
                    _conditionQueryVendorSynonymMember = xcreateQueryVendorSynonymMember();
                    xsetupOuterJoin_VendorSynonymMember();
                }
                return _conditionQueryVendorSynonymMember;
            }
        }
        protected VendorSynonymMemberCQ xcreateQueryVendorSynonymMember() {
            String nrp = resolveNextRelationPathVendorSynonymMember();
            String jan = resolveJoinAliasName(nrp, xgetNextNestLevel());
            VendorSynonymMemberCQ cq = new VendorSynonymMemberCQ(this, xgetSqlClause(), jan, xgetNextNestLevel());
            cq.xsetForeignPropertyName("vendorSynonymMember"); cq.xsetRelationPath(nrp); return cq;
        }
        public void xsetupOuterJoin_VendorSynonymMember() {
            VendorSynonymMemberCQ cq = ConditionQueryVendorSynonymMember;
            Map<String, String> joinOnMap = new LinkedHashMap<String, String>();
            joinOnMap.put("MEMBER_ID", "MEMBER_ID");
            registerOuterJoin(cq, joinOnMap);
        }
        protected String resolveNextRelationPathVendorSynonymMember() {
            return resolveNextRelationPath("VD_SYNONYM_MEMBER_LOGIN", "vendorSynonymMember");
        }
        public bool hasConditionQueryVendorSynonymMember() {
            return _conditionQueryVendorSynonymMember != null;
        }


	    // ===============================================================================
	    //                                                                 Scalar SubQuery
	    //                                                                 ===============
	    protected Map<String, VdSynonymMemberLoginCQ> _scalarSubQueryMap;
	    public Map<String, VdSynonymMemberLoginCQ> ScalarSubQuery { get { return _scalarSubQueryMap; } }
	    public override String keepScalarSubQuery(VdSynonymMemberLoginCQ subQuery) {
	        if (_scalarSubQueryMap == null) { _scalarSubQueryMap = new LinkedHashMap<String, VdSynonymMemberLoginCQ>(); }
	        String key = "subQueryMapKey" + (_scalarSubQueryMap.size() + 1);
	        _scalarSubQueryMap.put(key, subQuery); return "ScalarSubQuery." + key;
	    }

        // ===============================================================================
        //                                                         Myself InScope SubQuery
        //                                                         =======================
        protected Map<String, VdSynonymMemberLoginCQ> _myselfInScopeSubQueryMap;
        public Map<String, VdSynonymMemberLoginCQ> MyselfInScopeSubQuery { get { return _myselfInScopeSubQueryMap; } }
        public override String keepMyselfInScopeSubQuery(VdSynonymMemberLoginCQ subQuery) {
            if (_myselfInScopeSubQueryMap == null) { _myselfInScopeSubQueryMap = new LinkedHashMap<String, VdSynonymMemberLoginCQ>(); }
            String key = "subQueryMapKey" + (_myselfInScopeSubQueryMap.size() + 1);
            _myselfInScopeSubQueryMap.put(key, subQuery); return "MyselfInScopeSubQuery." + key;
        }
    }
}
