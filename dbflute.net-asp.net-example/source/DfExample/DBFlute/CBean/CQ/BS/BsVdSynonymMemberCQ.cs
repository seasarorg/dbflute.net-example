
using System;

using DfExample.DBFlute.AllCommon.CBean;
using DfExample.DBFlute.AllCommon.CBean.CValue;
using DfExample.DBFlute.AllCommon.CBean.SClause;
using DfExample.DBFlute.AllCommon.JavaLike;
using DfExample.DBFlute.CBean.CQ;
using DfExample.DBFlute.CBean.CQ.Ciq;

namespace DfExample.DBFlute.CBean.CQ.BS {

    [System.Serializable]
    public class BsVdSynonymMemberCQ : AbstractBsVdSynonymMemberCQ {

        protected VdSynonymMemberCIQ _inlineQuery;

        public BsVdSynonymMemberCQ(ConditionQuery childQuery, SqlClause sqlClause, String aliasName, int nestLevel)
            : base(childQuery, sqlClause, aliasName, nestLevel) {}

        public VdSynonymMemberCIQ Inline() {
            if (_inlineQuery == null) {
                _inlineQuery = new VdSynonymMemberCIQ(xgetReferrerQuery(), xgetSqlClause(), xgetAliasName(), xgetNestLevel(), this);
            }
            _inlineQuery.xsetOnClause(false);
            return _inlineQuery;
        }
        
        public VdSynonymMemberCIQ On() {
            if (isBaseQuery()) { throw new UnsupportedOperationException("Unsupported onClause of Base Table!"); }
            VdSynonymMemberCIQ inlineQuery = Inline();
            inlineQuery.xsetOnClause(true);
            return inlineQuery;
        }


        protected ConditionValue _memberId;
        public ConditionValue MemberId {
            get { if (_memberId == null) { _memberId = new ConditionValue(); } return _memberId; }
        }
        protected override ConditionValue getCValueMemberId() { return this.MemberId; }


        protected Map<String, VdSynonymMemberLoginCQ> _memberId_ExistsSubQuery_VdSynonymMemberLoginListMap;
        public Map<String, VdSynonymMemberLoginCQ> MemberId_ExistsSubQuery_VdSynonymMemberLoginList { get { return _memberId_ExistsSubQuery_VdSynonymMemberLoginListMap; }}
        public override String keepMemberId_ExistsSubQuery_VdSynonymMemberLoginList(VdSynonymMemberLoginCQ subQuery) {
            if (_memberId_ExistsSubQuery_VdSynonymMemberLoginListMap == null) { _memberId_ExistsSubQuery_VdSynonymMemberLoginListMap = new LinkedHashMap<String, VdSynonymMemberLoginCQ>(); }
            String key = "subQueryMapKey" + (_memberId_ExistsSubQuery_VdSynonymMemberLoginListMap.size() + 1);
            _memberId_ExistsSubQuery_VdSynonymMemberLoginListMap.put(key, subQuery); return "MemberId_ExistsSubQuery_VdSynonymMemberLoginList." + key;
        }

        protected Map<String, VdSynonymMemberWithdrawalCQ> _memberId_ExistsSubQuery_VdSynonymMemberWithdrawalAsOneMap;
        public Map<String, VdSynonymMemberWithdrawalCQ> MemberId_ExistsSubQuery_VdSynonymMemberWithdrawalAsOne { get { return _memberId_ExistsSubQuery_VdSynonymMemberWithdrawalAsOneMap; }}
        public override String keepMemberId_ExistsSubQuery_VdSynonymMemberWithdrawalAsOne(VdSynonymMemberWithdrawalCQ subQuery) {
            if (_memberId_ExistsSubQuery_VdSynonymMemberWithdrawalAsOneMap == null) { _memberId_ExistsSubQuery_VdSynonymMemberWithdrawalAsOneMap = new LinkedHashMap<String, VdSynonymMemberWithdrawalCQ>(); }
            String key = "subQueryMapKey" + (_memberId_ExistsSubQuery_VdSynonymMemberWithdrawalAsOneMap.size() + 1);
            _memberId_ExistsSubQuery_VdSynonymMemberWithdrawalAsOneMap.put(key, subQuery); return "MemberId_ExistsSubQuery_VdSynonymMemberWithdrawalAsOne." + key;
        }

        protected Map<String, VdSynonymMemberLoginCQ> _memberId_NotExistsSubQuery_VdSynonymMemberLoginListMap;
        public Map<String, VdSynonymMemberLoginCQ> MemberId_NotExistsSubQuery_VdSynonymMemberLoginList { get { return _memberId_NotExistsSubQuery_VdSynonymMemberLoginListMap; }}
        public override String keepMemberId_NotExistsSubQuery_VdSynonymMemberLoginList(VdSynonymMemberLoginCQ subQuery) {
            if (_memberId_NotExistsSubQuery_VdSynonymMemberLoginListMap == null) { _memberId_NotExistsSubQuery_VdSynonymMemberLoginListMap = new LinkedHashMap<String, VdSynonymMemberLoginCQ>(); }
            String key = "subQueryMapKey" + (_memberId_NotExistsSubQuery_VdSynonymMemberLoginListMap.size() + 1);
            _memberId_NotExistsSubQuery_VdSynonymMemberLoginListMap.put(key, subQuery); return "MemberId_NotExistsSubQuery_VdSynonymMemberLoginList." + key;
        }

        protected Map<String, VdSynonymMemberWithdrawalCQ> _memberId_NotExistsSubQuery_VdSynonymMemberWithdrawalAsOneMap;
        public Map<String, VdSynonymMemberWithdrawalCQ> MemberId_NotExistsSubQuery_VdSynonymMemberWithdrawalAsOne { get { return _memberId_NotExistsSubQuery_VdSynonymMemberWithdrawalAsOneMap; }}
        public override String keepMemberId_NotExistsSubQuery_VdSynonymMemberWithdrawalAsOne(VdSynonymMemberWithdrawalCQ subQuery) {
            if (_memberId_NotExistsSubQuery_VdSynonymMemberWithdrawalAsOneMap == null) { _memberId_NotExistsSubQuery_VdSynonymMemberWithdrawalAsOneMap = new LinkedHashMap<String, VdSynonymMemberWithdrawalCQ>(); }
            String key = "subQueryMapKey" + (_memberId_NotExistsSubQuery_VdSynonymMemberWithdrawalAsOneMap.size() + 1);
            _memberId_NotExistsSubQuery_VdSynonymMemberWithdrawalAsOneMap.put(key, subQuery); return "MemberId_NotExistsSubQuery_VdSynonymMemberWithdrawalAsOne." + key;
        }

        protected Map<String, VdSynonymMemberLoginCQ> _memberId_InScopeSubQuery_VdSynonymMemberLoginListMap;
        public Map<String, VdSynonymMemberLoginCQ> MemberId_InScopeSubQuery_VdSynonymMemberLoginList { get { return _memberId_InScopeSubQuery_VdSynonymMemberLoginListMap; }}
        public override String keepMemberId_InScopeSubQuery_VdSynonymMemberLoginList(VdSynonymMemberLoginCQ subQuery) {
            if (_memberId_InScopeSubQuery_VdSynonymMemberLoginListMap == null) { _memberId_InScopeSubQuery_VdSynonymMemberLoginListMap = new LinkedHashMap<String, VdSynonymMemberLoginCQ>(); }
            String key = "subQueryMapKey" + (_memberId_InScopeSubQuery_VdSynonymMemberLoginListMap.size() + 1);
            _memberId_InScopeSubQuery_VdSynonymMemberLoginListMap.put(key, subQuery); return "MemberId_InScopeSubQuery_VdSynonymMemberLoginList." + key;
        }

        protected Map<String, VdSynonymMemberWithdrawalCQ> _memberId_InScopeSubQuery_VdSynonymMemberWithdrawalAsOneMap;
        public Map<String, VdSynonymMemberWithdrawalCQ> MemberId_InScopeSubQuery_VdSynonymMemberWithdrawalAsOne { get { return _memberId_InScopeSubQuery_VdSynonymMemberWithdrawalAsOneMap; }}
        public override String keepMemberId_InScopeSubQuery_VdSynonymMemberWithdrawalAsOne(VdSynonymMemberWithdrawalCQ subQuery) {
            if (_memberId_InScopeSubQuery_VdSynonymMemberWithdrawalAsOneMap == null) { _memberId_InScopeSubQuery_VdSynonymMemberWithdrawalAsOneMap = new LinkedHashMap<String, VdSynonymMemberWithdrawalCQ>(); }
            String key = "subQueryMapKey" + (_memberId_InScopeSubQuery_VdSynonymMemberWithdrawalAsOneMap.size() + 1);
            _memberId_InScopeSubQuery_VdSynonymMemberWithdrawalAsOneMap.put(key, subQuery); return "MemberId_InScopeSubQuery_VdSynonymMemberWithdrawalAsOne." + key;
        }

        protected Map<String, VdSynonymMemberLoginCQ> _memberId_NotInScopeSubQuery_VdSynonymMemberLoginListMap;
        public Map<String, VdSynonymMemberLoginCQ> MemberId_NotInScopeSubQuery_VdSynonymMemberLoginList { get { return _memberId_NotInScopeSubQuery_VdSynonymMemberLoginListMap; }}
        public override String keepMemberId_NotInScopeSubQuery_VdSynonymMemberLoginList(VdSynonymMemberLoginCQ subQuery) {
            if (_memberId_NotInScopeSubQuery_VdSynonymMemberLoginListMap == null) { _memberId_NotInScopeSubQuery_VdSynonymMemberLoginListMap = new LinkedHashMap<String, VdSynonymMemberLoginCQ>(); }
            String key = "subQueryMapKey" + (_memberId_NotInScopeSubQuery_VdSynonymMemberLoginListMap.size() + 1);
            _memberId_NotInScopeSubQuery_VdSynonymMemberLoginListMap.put(key, subQuery); return "MemberId_NotInScopeSubQuery_VdSynonymMemberLoginList." + key;
        }

        protected Map<String, VdSynonymMemberWithdrawalCQ> _memberId_NotInScopeSubQuery_VdSynonymMemberWithdrawalAsOneMap;
        public Map<String, VdSynonymMemberWithdrawalCQ> MemberId_NotInScopeSubQuery_VdSynonymMemberWithdrawalAsOne { get { return _memberId_NotInScopeSubQuery_VdSynonymMemberWithdrawalAsOneMap; }}
        public override String keepMemberId_NotInScopeSubQuery_VdSynonymMemberWithdrawalAsOne(VdSynonymMemberWithdrawalCQ subQuery) {
            if (_memberId_NotInScopeSubQuery_VdSynonymMemberWithdrawalAsOneMap == null) { _memberId_NotInScopeSubQuery_VdSynonymMemberWithdrawalAsOneMap = new LinkedHashMap<String, VdSynonymMemberWithdrawalCQ>(); }
            String key = "subQueryMapKey" + (_memberId_NotInScopeSubQuery_VdSynonymMemberWithdrawalAsOneMap.size() + 1);
            _memberId_NotInScopeSubQuery_VdSynonymMemberWithdrawalAsOneMap.put(key, subQuery); return "MemberId_NotInScopeSubQuery_VdSynonymMemberWithdrawalAsOne." + key;
        }

        protected Map<String, VdSynonymMemberLoginCQ> _memberId_SpecifyDerivedReferrer_VdSynonymMemberLoginListMap;
        public Map<String, VdSynonymMemberLoginCQ> MemberId_SpecifyDerivedReferrer_VdSynonymMemberLoginList { get { return _memberId_SpecifyDerivedReferrer_VdSynonymMemberLoginListMap; }}
        public override String keepMemberId_SpecifyDerivedReferrer_VdSynonymMemberLoginList(VdSynonymMemberLoginCQ subQuery) {
            if (_memberId_SpecifyDerivedReferrer_VdSynonymMemberLoginListMap == null) { _memberId_SpecifyDerivedReferrer_VdSynonymMemberLoginListMap = new LinkedHashMap<String, VdSynonymMemberLoginCQ>(); }
            String key = "subQueryMapKey" + (_memberId_SpecifyDerivedReferrer_VdSynonymMemberLoginListMap.size() + 1);
            _memberId_SpecifyDerivedReferrer_VdSynonymMemberLoginListMap.put(key, subQuery); return "MemberId_SpecifyDerivedReferrer_VdSynonymMemberLoginList." + key;
        }

        protected Map<String, VdSynonymMemberLoginCQ> _memberId_QueryDerivedReferrer_VdSynonymMemberLoginListMap;
        public Map<String, VdSynonymMemberLoginCQ> MemberId_QueryDerivedReferrer_VdSynonymMemberLoginList { get { return _memberId_QueryDerivedReferrer_VdSynonymMemberLoginListMap; } }
        public override String keepMemberId_QueryDerivedReferrer_VdSynonymMemberLoginList(VdSynonymMemberLoginCQ subQuery) {
            if (_memberId_QueryDerivedReferrer_VdSynonymMemberLoginListMap == null) { _memberId_QueryDerivedReferrer_VdSynonymMemberLoginListMap = new LinkedHashMap<String, VdSynonymMemberLoginCQ>(); }
            String key = "subQueryMapKey" + (_memberId_QueryDerivedReferrer_VdSynonymMemberLoginListMap.size() + 1);
            _memberId_QueryDerivedReferrer_VdSynonymMemberLoginListMap.put(key, subQuery); return "MemberId_QueryDerivedReferrer_VdSynonymMemberLoginList." + key;
        }
        protected Map<String, Object> _memberId_QueryDerivedReferrer_VdSynonymMemberLoginListParameterMap;
        public Map<String, Object> MemberId_QueryDerivedReferrer_VdSynonymMemberLoginListParameter { get { return _memberId_QueryDerivedReferrer_VdSynonymMemberLoginListParameterMap; } }
        public override String keepMemberId_QueryDerivedReferrer_VdSynonymMemberLoginListParameter(Object parameterValue) {
            if (_memberId_QueryDerivedReferrer_VdSynonymMemberLoginListParameterMap == null) { _memberId_QueryDerivedReferrer_VdSynonymMemberLoginListParameterMap = new LinkedHashMap<String, Object>(); }
            String key = "subQueryParameterKey" + (_memberId_QueryDerivedReferrer_VdSynonymMemberLoginListParameterMap.size() + 1);
            _memberId_QueryDerivedReferrer_VdSynonymMemberLoginListParameterMap.put(key, parameterValue); return "MemberId_QueryDerivedReferrer_VdSynonymMemberLoginListParameter." + key;
        }

        public BsVdSynonymMemberCQ AddOrderBy_MemberId_Asc() { regOBA("MEMBER_ID");return this; }
        public BsVdSynonymMemberCQ AddOrderBy_MemberId_Desc() { regOBD("MEMBER_ID");return this; }

        protected ConditionValue _memberName;
        public ConditionValue MemberName {
            get { if (_memberName == null) { _memberName = new ConditionValue(); } return _memberName; }
        }
        protected override ConditionValue getCValueMemberName() { return this.MemberName; }


        public BsVdSynonymMemberCQ AddOrderBy_MemberName_Asc() { regOBA("MEMBER_NAME");return this; }
        public BsVdSynonymMemberCQ AddOrderBy_MemberName_Desc() { regOBD("MEMBER_NAME");return this; }

        protected ConditionValue _memberAccount;
        public ConditionValue MemberAccount {
            get { if (_memberAccount == null) { _memberAccount = new ConditionValue(); } return _memberAccount; }
        }
        protected override ConditionValue getCValueMemberAccount() { return this.MemberAccount; }


        public BsVdSynonymMemberCQ AddOrderBy_MemberAccount_Asc() { regOBA("MEMBER_ACCOUNT");return this; }
        public BsVdSynonymMemberCQ AddOrderBy_MemberAccount_Desc() { regOBD("MEMBER_ACCOUNT");return this; }

        protected ConditionValue _memberStatusCode;
        public ConditionValue MemberStatusCode {
            get { if (_memberStatusCode == null) { _memberStatusCode = new ConditionValue(); } return _memberStatusCode; }
        }
        protected override ConditionValue getCValueMemberStatusCode() { return this.MemberStatusCode; }


        protected Map<String, MemberStatusCQ> _memberStatusCode_InScopeSubQuery_MemberStatusMap;
        public Map<String, MemberStatusCQ> MemberStatusCode_InScopeSubQuery_MemberStatus { get { return _memberStatusCode_InScopeSubQuery_MemberStatusMap; }}
        public override String keepMemberStatusCode_InScopeSubQuery_MemberStatus(MemberStatusCQ subQuery) {
            if (_memberStatusCode_InScopeSubQuery_MemberStatusMap == null) { _memberStatusCode_InScopeSubQuery_MemberStatusMap = new LinkedHashMap<String, MemberStatusCQ>(); }
            String key = "subQueryMapKey" + (_memberStatusCode_InScopeSubQuery_MemberStatusMap.size() + 1);
            _memberStatusCode_InScopeSubQuery_MemberStatusMap.put(key, subQuery); return "MemberStatusCode_InScopeSubQuery_MemberStatus." + key;
        }

        protected Map<String, MemberStatusCQ> _memberStatusCode_NotInScopeSubQuery_MemberStatusMap;
        public Map<String, MemberStatusCQ> MemberStatusCode_NotInScopeSubQuery_MemberStatus { get { return _memberStatusCode_NotInScopeSubQuery_MemberStatusMap; }}
        public override String keepMemberStatusCode_NotInScopeSubQuery_MemberStatus(MemberStatusCQ subQuery) {
            if (_memberStatusCode_NotInScopeSubQuery_MemberStatusMap == null) { _memberStatusCode_NotInScopeSubQuery_MemberStatusMap = new LinkedHashMap<String, MemberStatusCQ>(); }
            String key = "subQueryMapKey" + (_memberStatusCode_NotInScopeSubQuery_MemberStatusMap.size() + 1);
            _memberStatusCode_NotInScopeSubQuery_MemberStatusMap.put(key, subQuery); return "MemberStatusCode_NotInScopeSubQuery_MemberStatus." + key;
        }

        public BsVdSynonymMemberCQ AddOrderBy_MemberStatusCode_Asc() { regOBA("MEMBER_STATUS_CODE");return this; }
        public BsVdSynonymMemberCQ AddOrderBy_MemberStatusCode_Desc() { regOBD("MEMBER_STATUS_CODE");return this; }

        protected ConditionValue _formalizedDatetime;
        public ConditionValue FormalizedDatetime {
            get { if (_formalizedDatetime == null) { _formalizedDatetime = new ConditionValue(); } return _formalizedDatetime; }
        }
        protected override ConditionValue getCValueFormalizedDatetime() { return this.FormalizedDatetime; }


        public BsVdSynonymMemberCQ AddOrderBy_FormalizedDatetime_Asc() { regOBA("FORMALIZED_DATETIME");return this; }
        public BsVdSynonymMemberCQ AddOrderBy_FormalizedDatetime_Desc() { regOBD("FORMALIZED_DATETIME");return this; }

        protected ConditionValue _birthdate;
        public ConditionValue Birthdate {
            get { if (_birthdate == null) { _birthdate = new ConditionValue(); } return _birthdate; }
        }
        protected override ConditionValue getCValueBirthdate() { return this.Birthdate; }


        public BsVdSynonymMemberCQ AddOrderBy_Birthdate_Asc() { regOBA("BIRTHDATE");return this; }
        public BsVdSynonymMemberCQ AddOrderBy_Birthdate_Desc() { regOBD("BIRTHDATE");return this; }

        protected ConditionValue _registerDatetime;
        public ConditionValue RegisterDatetime {
            get { if (_registerDatetime == null) { _registerDatetime = new ConditionValue(); } return _registerDatetime; }
        }
        protected override ConditionValue getCValueRegisterDatetime() { return this.RegisterDatetime; }


        public BsVdSynonymMemberCQ AddOrderBy_RegisterDatetime_Asc() { regOBA("REGISTER_DATETIME");return this; }
        public BsVdSynonymMemberCQ AddOrderBy_RegisterDatetime_Desc() { regOBD("REGISTER_DATETIME");return this; }

        protected ConditionValue _registerUser;
        public ConditionValue RegisterUser {
            get { if (_registerUser == null) { _registerUser = new ConditionValue(); } return _registerUser; }
        }
        protected override ConditionValue getCValueRegisterUser() { return this.RegisterUser; }


        public BsVdSynonymMemberCQ AddOrderBy_RegisterUser_Asc() { regOBA("REGISTER_USER");return this; }
        public BsVdSynonymMemberCQ AddOrderBy_RegisterUser_Desc() { regOBD("REGISTER_USER");return this; }

        protected ConditionValue _registerProcess;
        public ConditionValue RegisterProcess {
            get { if (_registerProcess == null) { _registerProcess = new ConditionValue(); } return _registerProcess; }
        }
        protected override ConditionValue getCValueRegisterProcess() { return this.RegisterProcess; }


        public BsVdSynonymMemberCQ AddOrderBy_RegisterProcess_Asc() { regOBA("REGISTER_PROCESS");return this; }
        public BsVdSynonymMemberCQ AddOrderBy_RegisterProcess_Desc() { regOBD("REGISTER_PROCESS");return this; }

        protected ConditionValue _updateDatetime;
        public ConditionValue UpdateDatetime {
            get { if (_updateDatetime == null) { _updateDatetime = new ConditionValue(); } return _updateDatetime; }
        }
        protected override ConditionValue getCValueUpdateDatetime() { return this.UpdateDatetime; }


        public BsVdSynonymMemberCQ AddOrderBy_UpdateDatetime_Asc() { regOBA("UPDATE_DATETIME");return this; }
        public BsVdSynonymMemberCQ AddOrderBy_UpdateDatetime_Desc() { regOBD("UPDATE_DATETIME");return this; }

        protected ConditionValue _updateUser;
        public ConditionValue UpdateUser {
            get { if (_updateUser == null) { _updateUser = new ConditionValue(); } return _updateUser; }
        }
        protected override ConditionValue getCValueUpdateUser() { return this.UpdateUser; }


        public BsVdSynonymMemberCQ AddOrderBy_UpdateUser_Asc() { regOBA("UPDATE_USER");return this; }
        public BsVdSynonymMemberCQ AddOrderBy_UpdateUser_Desc() { regOBD("UPDATE_USER");return this; }

        protected ConditionValue _updateProcess;
        public ConditionValue UpdateProcess {
            get { if (_updateProcess == null) { _updateProcess = new ConditionValue(); } return _updateProcess; }
        }
        protected override ConditionValue getCValueUpdateProcess() { return this.UpdateProcess; }


        public BsVdSynonymMemberCQ AddOrderBy_UpdateProcess_Asc() { regOBA("UPDATE_PROCESS");return this; }
        public BsVdSynonymMemberCQ AddOrderBy_UpdateProcess_Desc() { regOBD("UPDATE_PROCESS");return this; }

        protected ConditionValue _versionNo;
        public ConditionValue VersionNo {
            get { if (_versionNo == null) { _versionNo = new ConditionValue(); } return _versionNo; }
        }
        protected override ConditionValue getCValueVersionNo() { return this.VersionNo; }


        public BsVdSynonymMemberCQ AddOrderBy_VersionNo_Asc() { regOBA("VERSION_NO");return this; }
        public BsVdSynonymMemberCQ AddOrderBy_VersionNo_Desc() { regOBD("VERSION_NO");return this; }

        public BsVdSynonymMemberCQ AddSpecifiedDerivedOrderBy_Asc(String aliasName) { registerSpecifiedDerivedOrderBy_Asc(aliasName); return this; }
        public BsVdSynonymMemberCQ AddSpecifiedDerivedOrderBy_Desc(String aliasName) { registerSpecifiedDerivedOrderBy_Desc(aliasName); return this; }

        public override void reflectRelationOnUnionQuery(ConditionQuery baseQueryAsSuper, ConditionQuery unionQueryAsSuper) {
            VdSynonymMemberCQ baseQuery = (VdSynonymMemberCQ)baseQueryAsSuper;
            VdSynonymMemberCQ unionQuery = (VdSynonymMemberCQ)unionQueryAsSuper;
            if (baseQuery.hasConditionQueryMemberStatus()) {
                unionQuery.QueryMemberStatus().reflectRelationOnUnionQuery(baseQuery.QueryMemberStatus(), unionQuery.QueryMemberStatus());
            }
            if (baseQuery.hasConditionQueryVdSynonymMemberWithdrawalAsOne()) {
                unionQuery.QueryVdSynonymMemberWithdrawalAsOne().reflectRelationOnUnionQuery(baseQuery.QueryVdSynonymMemberWithdrawalAsOne(), unionQuery.QueryVdSynonymMemberWithdrawalAsOne());
            }

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
            joinOnMap.put("MEMBER_STATUS_CODE", "MEMBER_STATUS_CODE");
            registerOuterJoin(cq, joinOnMap);
        }
        protected String resolveNextRelationPathMemberStatus() {
            return resolveNextRelationPath("VD_SYNONYM_MEMBER", "memberStatus");
        }
        public bool hasConditionQueryMemberStatus() {
            return _conditionQueryMemberStatus != null;
        }


        protected VdSynonymMemberWithdrawalCQ _conditionQueryVdSynonymMemberWithdrawalAsOne;
        public VdSynonymMemberWithdrawalCQ ConditionQueryVdSynonymMemberWithdrawalAsOne {
            get {
                if (_conditionQueryVdSynonymMemberWithdrawalAsOne == null) {
                    _conditionQueryVdSynonymMemberWithdrawalAsOne = createQueryVdSynonymMemberWithdrawalAsOne();
                    xsetupOuterJoin_VdSynonymMemberWithdrawalAsOne();
                }
                return _conditionQueryVdSynonymMemberWithdrawalAsOne;
            }
        }
        public VdSynonymMemberWithdrawalCQ QueryVdSynonymMemberWithdrawalAsOne() { return this.ConditionQueryVdSynonymMemberWithdrawalAsOne; }
        protected VdSynonymMemberWithdrawalCQ createQueryVdSynonymMemberWithdrawalAsOne() {
            String nrp = resolveNextRelationPathVdSynonymMemberWithdrawalAsOne();
            String jan = resolveJoinAliasName(nrp, xgetNextNestLevel());
            VdSynonymMemberWithdrawalCQ cq = new VdSynonymMemberWithdrawalCQ(this, xgetSqlClause(), jan, xgetNextNestLevel());
            cq.xsetForeignPropertyName("vdSynonymMemberWithdrawalAsOne"); cq.xsetRelationPath(nrp); return cq;
        }
        public void xsetupOuterJoin_VdSynonymMemberWithdrawalAsOne() {
            VdSynonymMemberWithdrawalCQ cq = ConditionQueryVdSynonymMemberWithdrawalAsOne;
            Map<String, String> joinOnMap = new LinkedHashMap<String, String>();
            joinOnMap.put("MEMBER_ID", "MEMBER_ID");
            registerOuterJoin(cq, joinOnMap);
        }
        protected String resolveNextRelationPathVdSynonymMemberWithdrawalAsOne() {
            return resolveNextRelationPath("VD_SYNONYM_MEMBER", "vdSynonymMemberWithdrawalAsOne");
        }
        public bool hasConditionQueryVdSynonymMemberWithdrawalAsOne() {
            return _conditionQueryVdSynonymMemberWithdrawalAsOne != null;
        }

	    // ===============================================================================
	    //                                                                 Scalar SubQuery
	    //                                                                 ===============
	    protected Map<String, VdSynonymMemberCQ> _scalarSubQueryMap;
	    public Map<String, VdSynonymMemberCQ> ScalarSubQuery { get { return _scalarSubQueryMap; } }
	    public override String keepScalarSubQuery(VdSynonymMemberCQ subQuery) {
	        if (_scalarSubQueryMap == null) { _scalarSubQueryMap = new LinkedHashMap<String, VdSynonymMemberCQ>(); }
	        String key = "subQueryMapKey" + (_scalarSubQueryMap.size() + 1);
	        _scalarSubQueryMap.put(key, subQuery); return "ScalarSubQuery." + key;
	    }

        // ===============================================================================
        //                                                         Myself InScope SubQuery
        //                                                         =======================
        protected Map<String, VdSynonymMemberCQ> _myselfInScopeSubQueryMap;
        public Map<String, VdSynonymMemberCQ> MyselfInScopeSubQuery { get { return _myselfInScopeSubQueryMap; } }
        public override String keepMyselfInScopeSubQuery(VdSynonymMemberCQ subQuery) {
            if (_myselfInScopeSubQueryMap == null) { _myselfInScopeSubQueryMap = new LinkedHashMap<String, VdSynonymMemberCQ>(); }
            String key = "subQueryMapKey" + (_myselfInScopeSubQueryMap.size() + 1);
            _myselfInScopeSubQueryMap.put(key, subQuery); return "MyselfInScopeSubQuery." + key;
        }
    }
}
