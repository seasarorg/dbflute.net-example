
using System;

using DfExample.DBFlute.AllCommon.CBean;
using DfExample.DBFlute.AllCommon.CBean.CValue;
using DfExample.DBFlute.AllCommon.CBean.SClause;
using DfExample.DBFlute.AllCommon.JavaLike;
using DfExample.DBFlute.CBean.CQ;
using DfExample.DBFlute.CBean.CQ.Ciq;

namespace DfExample.DBFlute.CBean.CQ.BS {

    [System.Serializable]
    public class BsVdSynonymMemberWithdrawalCQ : AbstractBsVdSynonymMemberWithdrawalCQ {

        protected VdSynonymMemberWithdrawalCIQ _inlineQuery;

        public BsVdSynonymMemberWithdrawalCQ(ConditionQuery childQuery, SqlClause sqlClause, String aliasName, int nestLevel)
            : base(childQuery, sqlClause, aliasName, nestLevel) {}

        public VdSynonymMemberWithdrawalCIQ Inline() {
            if (_inlineQuery == null) {
                _inlineQuery = new VdSynonymMemberWithdrawalCIQ(xgetReferrerQuery(), xgetSqlClause(), xgetAliasName(), xgetNestLevel(), this);
            }
            _inlineQuery.xsetOnClause(false);
            return _inlineQuery;
        }
        
        public VdSynonymMemberWithdrawalCIQ On() {
            if (isBaseQuery()) { throw new UnsupportedOperationException("Unsupported onClause of Base Table!"); }
            VdSynonymMemberWithdrawalCIQ inlineQuery = Inline();
            inlineQuery.xsetOnClause(true);
            return inlineQuery;
        }


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

        public BsVdSynonymMemberWithdrawalCQ AddOrderBy_MemberId_Asc() { regOBA("MEMBER_ID");return this; }
        public BsVdSynonymMemberWithdrawalCQ AddOrderBy_MemberId_Desc() { regOBD("MEMBER_ID");return this; }

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

        public BsVdSynonymMemberWithdrawalCQ AddOrderBy_WithdrawalReasonCode_Asc() { regOBA("WITHDRAWAL_REASON_CODE");return this; }
        public BsVdSynonymMemberWithdrawalCQ AddOrderBy_WithdrawalReasonCode_Desc() { regOBD("WITHDRAWAL_REASON_CODE");return this; }

        protected ConditionValue _withdrawalReasonInputText;
        public ConditionValue WithdrawalReasonInputText {
            get { if (_withdrawalReasonInputText == null) { _withdrawalReasonInputText = new ConditionValue(); } return _withdrawalReasonInputText; }
        }
        protected override ConditionValue getCValueWithdrawalReasonInputText() { return this.WithdrawalReasonInputText; }


        public BsVdSynonymMemberWithdrawalCQ AddOrderBy_WithdrawalReasonInputText_Asc() { regOBA("WITHDRAWAL_REASON_INPUT_TEXT");return this; }
        public BsVdSynonymMemberWithdrawalCQ AddOrderBy_WithdrawalReasonInputText_Desc() { regOBD("WITHDRAWAL_REASON_INPUT_TEXT");return this; }

        protected ConditionValue _withdrawalDatetime;
        public ConditionValue WithdrawalDatetime {
            get { if (_withdrawalDatetime == null) { _withdrawalDatetime = new ConditionValue(); } return _withdrawalDatetime; }
        }
        protected override ConditionValue getCValueWithdrawalDatetime() { return this.WithdrawalDatetime; }


        public BsVdSynonymMemberWithdrawalCQ AddOrderBy_WithdrawalDatetime_Asc() { regOBA("WITHDRAWAL_DATETIME");return this; }
        public BsVdSynonymMemberWithdrawalCQ AddOrderBy_WithdrawalDatetime_Desc() { regOBD("WITHDRAWAL_DATETIME");return this; }

        protected ConditionValue _registerDatetime;
        public ConditionValue RegisterDatetime {
            get { if (_registerDatetime == null) { _registerDatetime = new ConditionValue(); } return _registerDatetime; }
        }
        protected override ConditionValue getCValueRegisterDatetime() { return this.RegisterDatetime; }


        public BsVdSynonymMemberWithdrawalCQ AddOrderBy_RegisterDatetime_Asc() { regOBA("REGISTER_DATETIME");return this; }
        public BsVdSynonymMemberWithdrawalCQ AddOrderBy_RegisterDatetime_Desc() { regOBD("REGISTER_DATETIME");return this; }

        protected ConditionValue _registerProcess;
        public ConditionValue RegisterProcess {
            get { if (_registerProcess == null) { _registerProcess = new ConditionValue(); } return _registerProcess; }
        }
        protected override ConditionValue getCValueRegisterProcess() { return this.RegisterProcess; }


        public BsVdSynonymMemberWithdrawalCQ AddOrderBy_RegisterProcess_Asc() { regOBA("REGISTER_PROCESS");return this; }
        public BsVdSynonymMemberWithdrawalCQ AddOrderBy_RegisterProcess_Desc() { regOBD("REGISTER_PROCESS");return this; }

        protected ConditionValue _registerUser;
        public ConditionValue RegisterUser {
            get { if (_registerUser == null) { _registerUser = new ConditionValue(); } return _registerUser; }
        }
        protected override ConditionValue getCValueRegisterUser() { return this.RegisterUser; }


        public BsVdSynonymMemberWithdrawalCQ AddOrderBy_RegisterUser_Asc() { regOBA("REGISTER_USER");return this; }
        public BsVdSynonymMemberWithdrawalCQ AddOrderBy_RegisterUser_Desc() { regOBD("REGISTER_USER");return this; }

        protected ConditionValue _updateDatetime;
        public ConditionValue UpdateDatetime {
            get { if (_updateDatetime == null) { _updateDatetime = new ConditionValue(); } return _updateDatetime; }
        }
        protected override ConditionValue getCValueUpdateDatetime() { return this.UpdateDatetime; }


        public BsVdSynonymMemberWithdrawalCQ AddOrderBy_UpdateDatetime_Asc() { regOBA("UPDATE_DATETIME");return this; }
        public BsVdSynonymMemberWithdrawalCQ AddOrderBy_UpdateDatetime_Desc() { regOBD("UPDATE_DATETIME");return this; }

        protected ConditionValue _updateProcess;
        public ConditionValue UpdateProcess {
            get { if (_updateProcess == null) { _updateProcess = new ConditionValue(); } return _updateProcess; }
        }
        protected override ConditionValue getCValueUpdateProcess() { return this.UpdateProcess; }


        public BsVdSynonymMemberWithdrawalCQ AddOrderBy_UpdateProcess_Asc() { regOBA("UPDATE_PROCESS");return this; }
        public BsVdSynonymMemberWithdrawalCQ AddOrderBy_UpdateProcess_Desc() { regOBD("UPDATE_PROCESS");return this; }

        protected ConditionValue _updateUser;
        public ConditionValue UpdateUser {
            get { if (_updateUser == null) { _updateUser = new ConditionValue(); } return _updateUser; }
        }
        protected override ConditionValue getCValueUpdateUser() { return this.UpdateUser; }


        public BsVdSynonymMemberWithdrawalCQ AddOrderBy_UpdateUser_Asc() { regOBA("UPDATE_USER");return this; }
        public BsVdSynonymMemberWithdrawalCQ AddOrderBy_UpdateUser_Desc() { regOBD("UPDATE_USER");return this; }

        protected ConditionValue _versionNo;
        public ConditionValue VersionNo {
            get { if (_versionNo == null) { _versionNo = new ConditionValue(); } return _versionNo; }
        }
        protected override ConditionValue getCValueVersionNo() { return this.VersionNo; }


        public BsVdSynonymMemberWithdrawalCQ AddOrderBy_VersionNo_Asc() { regOBA("VERSION_NO");return this; }
        public BsVdSynonymMemberWithdrawalCQ AddOrderBy_VersionNo_Desc() { regOBD("VERSION_NO");return this; }

        public BsVdSynonymMemberWithdrawalCQ AddSpecifiedDerivedOrderBy_Asc(String aliasName) { registerSpecifiedDerivedOrderBy_Asc(aliasName); return this; }
        public BsVdSynonymMemberWithdrawalCQ AddSpecifiedDerivedOrderBy_Desc(String aliasName) { registerSpecifiedDerivedOrderBy_Desc(aliasName); return this; }

        public override void reflectRelationOnUnionQuery(ConditionQuery baseQueryAsSuper, ConditionQuery unionQueryAsSuper) {
            VdSynonymMemberWithdrawalCQ baseQuery = (VdSynonymMemberWithdrawalCQ)baseQueryAsSuper;
            VdSynonymMemberWithdrawalCQ unionQuery = (VdSynonymMemberWithdrawalCQ)unionQueryAsSuper;
            if (baseQuery.hasConditionQueryMemberVendorSynonym()) {
                unionQuery.QueryMemberVendorSynonym().reflectRelationOnUnionQuery(baseQuery.QueryMemberVendorSynonym(), unionQuery.QueryMemberVendorSynonym());
            }
            if (baseQuery.hasConditionQueryWithdrawalReason()) {
                unionQuery.QueryWithdrawalReason().reflectRelationOnUnionQuery(baseQuery.QueryWithdrawalReason(), unionQuery.QueryWithdrawalReason());
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
            return resolveNextRelationPath("VD_SYNONYM_MEMBER_WITHDRAWAL", "memberVendorSynonym");
        }
        public bool hasConditionQueryMemberVendorSynonym() {
            return _conditionQueryMemberVendorSynonym != null;
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
            return resolveNextRelationPath("VD_SYNONYM_MEMBER_WITHDRAWAL", "withdrawalReason");
        }
        public bool hasConditionQueryWithdrawalReason() {
            return _conditionQueryWithdrawalReason != null;
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
            return resolveNextRelationPath("VD_SYNONYM_MEMBER_WITHDRAWAL", "vdSynonymMember");
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
            return resolveNextRelationPath("VD_SYNONYM_MEMBER_WITHDRAWAL", "vendorSynonymMember");
        }
        public bool hasConditionQueryVendorSynonymMember() {
            return _conditionQueryVendorSynonymMember != null;
        }


	    // ===============================================================================
	    //                                                                 Scalar SubQuery
	    //                                                                 ===============
	    protected Map<String, VdSynonymMemberWithdrawalCQ> _scalarSubQueryMap;
	    public Map<String, VdSynonymMemberWithdrawalCQ> ScalarSubQuery { get { return _scalarSubQueryMap; } }
	    public override String keepScalarSubQuery(VdSynonymMemberWithdrawalCQ subQuery) {
	        if (_scalarSubQueryMap == null) { _scalarSubQueryMap = new LinkedHashMap<String, VdSynonymMemberWithdrawalCQ>(); }
	        String key = "subQueryMapKey" + (_scalarSubQueryMap.size() + 1);
	        _scalarSubQueryMap.put(key, subQuery); return "ScalarSubQuery." + key;
	    }

        // ===============================================================================
        //                                                         Myself InScope SubQuery
        //                                                         =======================
        protected Map<String, VdSynonymMemberWithdrawalCQ> _myselfInScopeSubQueryMap;
        public Map<String, VdSynonymMemberWithdrawalCQ> MyselfInScopeSubQuery { get { return _myselfInScopeSubQueryMap; } }
        public override String keepMyselfInScopeSubQuery(VdSynonymMemberWithdrawalCQ subQuery) {
            if (_myselfInScopeSubQueryMap == null) { _myselfInScopeSubQueryMap = new LinkedHashMap<String, VdSynonymMemberWithdrawalCQ>(); }
            String key = "subQueryMapKey" + (_myselfInScopeSubQueryMap.size() + 1);
            _myselfInScopeSubQueryMap.put(key, subQuery); return "MyselfInScopeSubQuery." + key;
        }
    }
}
