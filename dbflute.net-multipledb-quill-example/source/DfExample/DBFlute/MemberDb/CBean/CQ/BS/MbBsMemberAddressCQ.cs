
using System;

using DfExample.DBFlute.MemberDb.AllCommon.CBean;
using DfExample.DBFlute.MemberDb.AllCommon.CBean.CValue;
using DfExample.DBFlute.MemberDb.AllCommon.CBean.SClause;
using DfExample.DBFlute.MemberDb.AllCommon.JavaLike;
using DfExample.DBFlute.MemberDb.CBean.CQ;
using DfExample.DBFlute.MemberDb.CBean.CQ.Ciq;

namespace DfExample.DBFlute.MemberDb.CBean.CQ.BS {

    [System.Serializable]
    public class MbBsMemberAddressCQ : MbAbstractBsMemberAddressCQ {

        protected MbMemberAddressCIQ _inlineQuery;

        public MbBsMemberAddressCQ(MbConditionQuery childQuery, MbSqlClause sqlClause, String aliasName, int nestLevel)
            : base(childQuery, sqlClause, aliasName, nestLevel) {}

        public MbMemberAddressCIQ Inline() {
            if (_inlineQuery == null) {
                _inlineQuery = new MbMemberAddressCIQ(xgetReferrerQuery(), xgetSqlClause(), xgetAliasName(), xgetNestLevel(), this);
            }
            _inlineQuery.xsetOnClause(false);
            return _inlineQuery;
        }
        
        public MbMemberAddressCIQ On() {
            if (isBaseQuery()) { throw new UnsupportedOperationException("Unsupported onClause of Base Table!"); }
            MbMemberAddressCIQ inlineQuery = Inline();
            inlineQuery.xsetOnClause(true);
            return inlineQuery;
        }


        protected MbConditionValue _memberAddressId;
        public MbConditionValue MemberAddressId {
            get { if (_memberAddressId == null) { _memberAddressId = new MbConditionValue(); } return _memberAddressId; }
        }
        protected override MbConditionValue getCValueMemberAddressId() { return this.MemberAddressId; }


        public MbBsMemberAddressCQ AddOrderBy_MemberAddressId_Asc() { regOBA("MEMBER_ADDRESS_ID");return this; }
        public MbBsMemberAddressCQ AddOrderBy_MemberAddressId_Desc() { regOBD("MEMBER_ADDRESS_ID");return this; }

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

        public MbBsMemberAddressCQ AddOrderBy_MemberId_Asc() { regOBA("MEMBER_ID");return this; }
        public MbBsMemberAddressCQ AddOrderBy_MemberId_Desc() { regOBD("MEMBER_ID");return this; }

        protected MbConditionValue _validBeginDate;
        public MbConditionValue ValidBeginDate {
            get { if (_validBeginDate == null) { _validBeginDate = new MbConditionValue(); } return _validBeginDate; }
        }
        protected override MbConditionValue getCValueValidBeginDate() { return this.ValidBeginDate; }


        public MbBsMemberAddressCQ AddOrderBy_ValidBeginDate_Asc() { regOBA("VALID_BEGIN_DATE");return this; }
        public MbBsMemberAddressCQ AddOrderBy_ValidBeginDate_Desc() { regOBD("VALID_BEGIN_DATE");return this; }

        protected MbConditionValue _validEndDate;
        public MbConditionValue ValidEndDate {
            get { if (_validEndDate == null) { _validEndDate = new MbConditionValue(); } return _validEndDate; }
        }
        protected override MbConditionValue getCValueValidEndDate() { return this.ValidEndDate; }


        public MbBsMemberAddressCQ AddOrderBy_ValidEndDate_Asc() { regOBA("VALID_END_DATE");return this; }
        public MbBsMemberAddressCQ AddOrderBy_ValidEndDate_Desc() { regOBD("VALID_END_DATE");return this; }

        protected MbConditionValue _address;
        public MbConditionValue Address {
            get { if (_address == null) { _address = new MbConditionValue(); } return _address; }
        }
        protected override MbConditionValue getCValueAddress() { return this.Address; }


        public MbBsMemberAddressCQ AddOrderBy_Address_Asc() { regOBA("ADDRESS");return this; }
        public MbBsMemberAddressCQ AddOrderBy_Address_Desc() { regOBD("ADDRESS");return this; }

        protected MbConditionValue _registerDatetime;
        public MbConditionValue RegisterDatetime {
            get { if (_registerDatetime == null) { _registerDatetime = new MbConditionValue(); } return _registerDatetime; }
        }
        protected override MbConditionValue getCValueRegisterDatetime() { return this.RegisterDatetime; }


        public MbBsMemberAddressCQ AddOrderBy_RegisterDatetime_Asc() { regOBA("REGISTER_DATETIME");return this; }
        public MbBsMemberAddressCQ AddOrderBy_RegisterDatetime_Desc() { regOBD("REGISTER_DATETIME");return this; }

        protected MbConditionValue _registerProcess;
        public MbConditionValue RegisterProcess {
            get { if (_registerProcess == null) { _registerProcess = new MbConditionValue(); } return _registerProcess; }
        }
        protected override MbConditionValue getCValueRegisterProcess() { return this.RegisterProcess; }


        public MbBsMemberAddressCQ AddOrderBy_RegisterProcess_Asc() { regOBA("REGISTER_PROCESS");return this; }
        public MbBsMemberAddressCQ AddOrderBy_RegisterProcess_Desc() { regOBD("REGISTER_PROCESS");return this; }

        protected MbConditionValue _registerUser;
        public MbConditionValue RegisterUser {
            get { if (_registerUser == null) { _registerUser = new MbConditionValue(); } return _registerUser; }
        }
        protected override MbConditionValue getCValueRegisterUser() { return this.RegisterUser; }


        public MbBsMemberAddressCQ AddOrderBy_RegisterUser_Asc() { regOBA("REGISTER_USER");return this; }
        public MbBsMemberAddressCQ AddOrderBy_RegisterUser_Desc() { regOBD("REGISTER_USER");return this; }

        protected MbConditionValue _updateDatetime;
        public MbConditionValue UpdateDatetime {
            get { if (_updateDatetime == null) { _updateDatetime = new MbConditionValue(); } return _updateDatetime; }
        }
        protected override MbConditionValue getCValueUpdateDatetime() { return this.UpdateDatetime; }


        public MbBsMemberAddressCQ AddOrderBy_UpdateDatetime_Asc() { regOBA("UPDATE_DATETIME");return this; }
        public MbBsMemberAddressCQ AddOrderBy_UpdateDatetime_Desc() { regOBD("UPDATE_DATETIME");return this; }

        protected MbConditionValue _updateProcess;
        public MbConditionValue UpdateProcess {
            get { if (_updateProcess == null) { _updateProcess = new MbConditionValue(); } return _updateProcess; }
        }
        protected override MbConditionValue getCValueUpdateProcess() { return this.UpdateProcess; }


        public MbBsMemberAddressCQ AddOrderBy_UpdateProcess_Asc() { regOBA("UPDATE_PROCESS");return this; }
        public MbBsMemberAddressCQ AddOrderBy_UpdateProcess_Desc() { regOBD("UPDATE_PROCESS");return this; }

        protected MbConditionValue _updateUser;
        public MbConditionValue UpdateUser {
            get { if (_updateUser == null) { _updateUser = new MbConditionValue(); } return _updateUser; }
        }
        protected override MbConditionValue getCValueUpdateUser() { return this.UpdateUser; }


        public MbBsMemberAddressCQ AddOrderBy_UpdateUser_Asc() { regOBA("UPDATE_USER");return this; }
        public MbBsMemberAddressCQ AddOrderBy_UpdateUser_Desc() { regOBD("UPDATE_USER");return this; }

        protected MbConditionValue _versionNo;
        public MbConditionValue VersionNo {
            get { if (_versionNo == null) { _versionNo = new MbConditionValue(); } return _versionNo; }
        }
        protected override MbConditionValue getCValueVersionNo() { return this.VersionNo; }


        public MbBsMemberAddressCQ AddOrderBy_VersionNo_Asc() { regOBA("VERSION_NO");return this; }
        public MbBsMemberAddressCQ AddOrderBy_VersionNo_Desc() { regOBD("VERSION_NO");return this; }

        public MbBsMemberAddressCQ AddSpecifiedDerivedOrderBy_Asc(String aliasName) { registerSpecifiedDerivedOrderBy_Asc(aliasName); return this; }
        public MbBsMemberAddressCQ AddSpecifiedDerivedOrderBy_Desc(String aliasName) { registerSpecifiedDerivedOrderBy_Desc(aliasName); return this; }

        public override void reflectRelationOnUnionQuery(MbConditionQuery baseQueryAsSuper, MbConditionQuery unionQueryAsSuper) {
            MbMemberAddressCQ baseQuery = (MbMemberAddressCQ)baseQueryAsSuper;
            MbMemberAddressCQ unionQuery = (MbMemberAddressCQ)unionQueryAsSuper;
            if (baseQuery.hasConditionQueryMember()) {
                unionQuery.QueryMember().reflectRelationOnUnionQuery(baseQuery.QueryMember(), unionQuery.QueryMember());
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
            return resolveNextRelationPath("member_address", "member");
        }
        public bool hasConditionQueryMember() {
            return _conditionQueryMember != null;
        }


	    // ===============================================================================
	    //                                                                 Scalar SubQuery
	    //                                                                 ===============
	    protected Map<String, MbMemberAddressCQ> _scalarSubQueryMap;
	    public Map<String, MbMemberAddressCQ> ScalarSubQuery { get { return _scalarSubQueryMap; } }
	    public override String keepScalarSubQuery(MbMemberAddressCQ subQuery) {
	        if (_scalarSubQueryMap == null) { _scalarSubQueryMap = new LinkedHashMap<String, MbMemberAddressCQ>(); }
	        String key = "subQueryMapKey" + (_scalarSubQueryMap.size() + 1);
	        _scalarSubQueryMap.put(key, subQuery); return "ScalarSubQuery." + key;
	    }

        // ===============================================================================
        //                                                         Myself InScope SubQuery
        //                                                         =======================
        protected Map<String, MbMemberAddressCQ> _myselfInScopeSubQueryMap;
        public Map<String, MbMemberAddressCQ> MyselfInScopeSubQuery { get { return _myselfInScopeSubQueryMap; } }
        public override String keepMyselfInScopeSubQuery(MbMemberAddressCQ subQuery) {
            if (_myselfInScopeSubQueryMap == null) { _myselfInScopeSubQueryMap = new LinkedHashMap<String, MbMemberAddressCQ>(); }
            String key = "subQueryMapKey" + (_myselfInScopeSubQueryMap.size() + 1);
            _myselfInScopeSubQueryMap.put(key, subQuery); return "MyselfInScopeSubQuery." + key;
        }
    }
}
