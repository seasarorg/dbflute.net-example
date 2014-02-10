
using System;

using DfExample.DBFlute.AllCommon.CBean;
using DfExample.DBFlute.AllCommon.CBean.CValue;
using DfExample.DBFlute.AllCommon.CBean.SClause;
using DfExample.DBFlute.AllCommon.JavaLike;
using DfExample.DBFlute.CBean.CQ;
using DfExample.DBFlute.CBean.CQ.Ciq;

namespace DfExample.DBFlute.CBean.CQ.BS {

    [System.Serializable]
    public class BsMemberAddressCQ : AbstractBsMemberAddressCQ {

        protected MemberAddressCIQ _inlineQuery;

        public BsMemberAddressCQ(ConditionQuery childQuery, SqlClause sqlClause, String aliasName, int nestLevel)
            : base(childQuery, sqlClause, aliasName, nestLevel) {}

        public MemberAddressCIQ Inline() {
            if (_inlineQuery == null) {
                _inlineQuery = new MemberAddressCIQ(xgetReferrerQuery(), xgetSqlClause(), xgetAliasName(), xgetNestLevel(), this);
            }
            _inlineQuery.xsetOnClause(false);
            return _inlineQuery;
        }
        
        public MemberAddressCIQ On() {
            if (isBaseQuery()) { throw new UnsupportedOperationException("Unsupported onClause of Base Table!"); }
            MemberAddressCIQ inlineQuery = Inline();
            inlineQuery.xsetOnClause(true);
            return inlineQuery;
        }


        protected ConditionValue _memberAddressId;
        public ConditionValue MemberAddressId {
            get { if (_memberAddressId == null) { _memberAddressId = new ConditionValue(); } return _memberAddressId; }
        }
        protected override ConditionValue getCValueMemberAddressId() { return this.MemberAddressId; }


        public BsMemberAddressCQ AddOrderBy_MemberAddressId_Asc() { regOBA("MEMBER_ADDRESS_ID");return this; }
        public BsMemberAddressCQ AddOrderBy_MemberAddressId_Desc() { regOBD("MEMBER_ADDRESS_ID");return this; }

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

        public BsMemberAddressCQ AddOrderBy_MemberId_Asc() { regOBA("MEMBER_ID");return this; }
        public BsMemberAddressCQ AddOrderBy_MemberId_Desc() { regOBD("MEMBER_ID");return this; }

        protected ConditionValue _validBeginDate;
        public ConditionValue ValidBeginDate {
            get { if (_validBeginDate == null) { _validBeginDate = new ConditionValue(); } return _validBeginDate; }
        }
        protected override ConditionValue getCValueValidBeginDate() { return this.ValidBeginDate; }


        public BsMemberAddressCQ AddOrderBy_ValidBeginDate_Asc() { regOBA("VALID_BEGIN_DATE");return this; }
        public BsMemberAddressCQ AddOrderBy_ValidBeginDate_Desc() { regOBD("VALID_BEGIN_DATE");return this; }

        protected ConditionValue _validEndDate;
        public ConditionValue ValidEndDate {
            get { if (_validEndDate == null) { _validEndDate = new ConditionValue(); } return _validEndDate; }
        }
        protected override ConditionValue getCValueValidEndDate() { return this.ValidEndDate; }


        public BsMemberAddressCQ AddOrderBy_ValidEndDate_Asc() { regOBA("VALID_END_DATE");return this; }
        public BsMemberAddressCQ AddOrderBy_ValidEndDate_Desc() { regOBD("VALID_END_DATE");return this; }

        protected ConditionValue _address;
        public ConditionValue Address {
            get { if (_address == null) { _address = new ConditionValue(); } return _address; }
        }
        protected override ConditionValue getCValueAddress() { return this.Address; }


        public BsMemberAddressCQ AddOrderBy_Address_Asc() { regOBA("ADDRESS");return this; }
        public BsMemberAddressCQ AddOrderBy_Address_Desc() { regOBD("ADDRESS");return this; }

        protected ConditionValue _registerDatetime;
        public ConditionValue RegisterDatetime {
            get { if (_registerDatetime == null) { _registerDatetime = new ConditionValue(); } return _registerDatetime; }
        }
        protected override ConditionValue getCValueRegisterDatetime() { return this.RegisterDatetime; }


        public BsMemberAddressCQ AddOrderBy_RegisterDatetime_Asc() { regOBA("REGISTER_DATETIME");return this; }
        public BsMemberAddressCQ AddOrderBy_RegisterDatetime_Desc() { regOBD("REGISTER_DATETIME");return this; }

        protected ConditionValue _registerProcess;
        public ConditionValue RegisterProcess {
            get { if (_registerProcess == null) { _registerProcess = new ConditionValue(); } return _registerProcess; }
        }
        protected override ConditionValue getCValueRegisterProcess() { return this.RegisterProcess; }


        public BsMemberAddressCQ AddOrderBy_RegisterProcess_Asc() { regOBA("REGISTER_PROCESS");return this; }
        public BsMemberAddressCQ AddOrderBy_RegisterProcess_Desc() { regOBD("REGISTER_PROCESS");return this; }

        protected ConditionValue _registerUser;
        public ConditionValue RegisterUser {
            get { if (_registerUser == null) { _registerUser = new ConditionValue(); } return _registerUser; }
        }
        protected override ConditionValue getCValueRegisterUser() { return this.RegisterUser; }


        public BsMemberAddressCQ AddOrderBy_RegisterUser_Asc() { regOBA("REGISTER_USER");return this; }
        public BsMemberAddressCQ AddOrderBy_RegisterUser_Desc() { regOBD("REGISTER_USER");return this; }

        protected ConditionValue _updateDatetime;
        public ConditionValue UpdateDatetime {
            get { if (_updateDatetime == null) { _updateDatetime = new ConditionValue(); } return _updateDatetime; }
        }
        protected override ConditionValue getCValueUpdateDatetime() { return this.UpdateDatetime; }


        public BsMemberAddressCQ AddOrderBy_UpdateDatetime_Asc() { regOBA("UPDATE_DATETIME");return this; }
        public BsMemberAddressCQ AddOrderBy_UpdateDatetime_Desc() { regOBD("UPDATE_DATETIME");return this; }

        protected ConditionValue _updateProcess;
        public ConditionValue UpdateProcess {
            get { if (_updateProcess == null) { _updateProcess = new ConditionValue(); } return _updateProcess; }
        }
        protected override ConditionValue getCValueUpdateProcess() { return this.UpdateProcess; }


        public BsMemberAddressCQ AddOrderBy_UpdateProcess_Asc() { regOBA("UPDATE_PROCESS");return this; }
        public BsMemberAddressCQ AddOrderBy_UpdateProcess_Desc() { regOBD("UPDATE_PROCESS");return this; }

        protected ConditionValue _updateUser;
        public ConditionValue UpdateUser {
            get { if (_updateUser == null) { _updateUser = new ConditionValue(); } return _updateUser; }
        }
        protected override ConditionValue getCValueUpdateUser() { return this.UpdateUser; }


        public BsMemberAddressCQ AddOrderBy_UpdateUser_Asc() { regOBA("UPDATE_USER");return this; }
        public BsMemberAddressCQ AddOrderBy_UpdateUser_Desc() { regOBD("UPDATE_USER");return this; }

        protected ConditionValue _versionNo;
        public ConditionValue VersionNo {
            get { if (_versionNo == null) { _versionNo = new ConditionValue(); } return _versionNo; }
        }
        protected override ConditionValue getCValueVersionNo() { return this.VersionNo; }


        public BsMemberAddressCQ AddOrderBy_VersionNo_Asc() { regOBA("VERSION_NO");return this; }
        public BsMemberAddressCQ AddOrderBy_VersionNo_Desc() { regOBD("VERSION_NO");return this; }

        public BsMemberAddressCQ AddSpecifiedDerivedOrderBy_Asc(String aliasName) { registerSpecifiedDerivedOrderBy_Asc(aliasName); return this; }
        public BsMemberAddressCQ AddSpecifiedDerivedOrderBy_Desc(String aliasName) { registerSpecifiedDerivedOrderBy_Desc(aliasName); return this; }

        public override void reflectRelationOnUnionQuery(ConditionQuery baseQueryAsSuper, ConditionQuery unionQueryAsSuper) {
            MemberAddressCQ baseQuery = (MemberAddressCQ)baseQueryAsSuper;
            MemberAddressCQ unionQuery = (MemberAddressCQ)unionQueryAsSuper;
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
            return resolveNextRelationPath("member_address", "member");
        }
        public bool hasConditionQueryMember() {
            return _conditionQueryMember != null;
        }


	    // ===============================================================================
	    //                                                                 Scalar SubQuery
	    //                                                                 ===============
	    protected Map<String, MemberAddressCQ> _scalarSubQueryMap;
	    public Map<String, MemberAddressCQ> ScalarSubQuery { get { return _scalarSubQueryMap; } }
	    public override String keepScalarSubQuery(MemberAddressCQ subQuery) {
	        if (_scalarSubQueryMap == null) { _scalarSubQueryMap = new LinkedHashMap<String, MemberAddressCQ>(); }
	        String key = "subQueryMapKey" + (_scalarSubQueryMap.size() + 1);
	        _scalarSubQueryMap.put(key, subQuery); return "ScalarSubQuery." + key;
	    }

        // ===============================================================================
        //                                                         Myself InScope SubQuery
        //                                                         =======================
        protected Map<String, MemberAddressCQ> _myselfInScopeSubQueryMap;
        public Map<String, MemberAddressCQ> MyselfInScopeSubQuery { get { return _myselfInScopeSubQueryMap; } }
        public override String keepMyselfInScopeSubQuery(MemberAddressCQ subQuery) {
            if (_myselfInScopeSubQueryMap == null) { _myselfInScopeSubQueryMap = new LinkedHashMap<String, MemberAddressCQ>(); }
            String key = "subQueryMapKey" + (_myselfInScopeSubQueryMap.size() + 1);
            _myselfInScopeSubQueryMap.put(key, subQuery); return "MyselfInScopeSubQuery." + key;
        }
    }
}
