
using System;

using DfExample.DBFlute.AllCommon.CBean;
using DfExample.DBFlute.AllCommon.CBean.CValue;
using DfExample.DBFlute.AllCommon.CBean.SClause;
using DfExample.DBFlute.AllCommon.JavaLike;
using DfExample.DBFlute.CBean.CQ;
using DfExample.DBFlute.CBean.CQ.Ciq;

namespace DfExample.DBFlute.CBean.CQ.BS {

    [System.Serializable]
    public class BsMemberCQ : AbstractBsMemberCQ {

        protected MemberCIQ _inlineQuery;

        public BsMemberCQ(ConditionQuery childQuery, SqlClause sqlClause, String aliasName, int nestLevel)
            : base(childQuery, sqlClause, aliasName, nestLevel) {}

        public MemberCIQ Inline() {
            if (_inlineQuery == null) {
                _inlineQuery = new MemberCIQ(xgetReferrerQuery(), xgetSqlClause(), xgetAliasName(), xgetNestLevel(), this);
            }
            _inlineQuery.xsetOnClause(false);
            return _inlineQuery;
        }
        
        public MemberCIQ On() {
            if (isBaseQuery()) { throw new UnsupportedOperationException("Unsupported onClause of Base Table!"); }
            MemberCIQ inlineQuery = Inline();
            inlineQuery.xsetOnClause(true);
            return inlineQuery;
        }


        protected ConditionValue _memberId;
        public ConditionValue MemberId {
            get { if (_memberId == null) { _memberId = new ConditionValue(); } return _memberId; }
        }
        protected override ConditionValue getCValueMemberId() { return this.MemberId; }


        protected Map<String, MemberAddressCQ> _memberId_ExistsSubQuery_MemberAddressListMap;
        public Map<String, MemberAddressCQ> MemberId_ExistsSubQuery_MemberAddressList { get { return _memberId_ExistsSubQuery_MemberAddressListMap; }}
        public override String keepMemberId_ExistsSubQuery_MemberAddressList(MemberAddressCQ subQuery) {
            if (_memberId_ExistsSubQuery_MemberAddressListMap == null) { _memberId_ExistsSubQuery_MemberAddressListMap = new LinkedHashMap<String, MemberAddressCQ>(); }
            String key = "subQueryMapKey" + (_memberId_ExistsSubQuery_MemberAddressListMap.size() + 1);
            _memberId_ExistsSubQuery_MemberAddressListMap.put(key, subQuery); return "MemberId_ExistsSubQuery_MemberAddressList." + key;
        }

        protected Map<String, MemberLoginCQ> _memberId_ExistsSubQuery_MemberLoginListMap;
        public Map<String, MemberLoginCQ> MemberId_ExistsSubQuery_MemberLoginList { get { return _memberId_ExistsSubQuery_MemberLoginListMap; }}
        public override String keepMemberId_ExistsSubQuery_MemberLoginList(MemberLoginCQ subQuery) {
            if (_memberId_ExistsSubQuery_MemberLoginListMap == null) { _memberId_ExistsSubQuery_MemberLoginListMap = new LinkedHashMap<String, MemberLoginCQ>(); }
            String key = "subQueryMapKey" + (_memberId_ExistsSubQuery_MemberLoginListMap.size() + 1);
            _memberId_ExistsSubQuery_MemberLoginListMap.put(key, subQuery); return "MemberId_ExistsSubQuery_MemberLoginList." + key;
        }

        protected Map<String, MemberSecurityCQ> _memberId_ExistsSubQuery_MemberSecurityAsOneMap;
        public Map<String, MemberSecurityCQ> MemberId_ExistsSubQuery_MemberSecurityAsOne { get { return _memberId_ExistsSubQuery_MemberSecurityAsOneMap; }}
        public override String keepMemberId_ExistsSubQuery_MemberSecurityAsOne(MemberSecurityCQ subQuery) {
            if (_memberId_ExistsSubQuery_MemberSecurityAsOneMap == null) { _memberId_ExistsSubQuery_MemberSecurityAsOneMap = new LinkedHashMap<String, MemberSecurityCQ>(); }
            String key = "subQueryMapKey" + (_memberId_ExistsSubQuery_MemberSecurityAsOneMap.size() + 1);
            _memberId_ExistsSubQuery_MemberSecurityAsOneMap.put(key, subQuery); return "MemberId_ExistsSubQuery_MemberSecurityAsOne." + key;
        }

        protected Map<String, MemberWithdrawalCQ> _memberId_ExistsSubQuery_MemberWithdrawalAsOneMap;
        public Map<String, MemberWithdrawalCQ> MemberId_ExistsSubQuery_MemberWithdrawalAsOne { get { return _memberId_ExistsSubQuery_MemberWithdrawalAsOneMap; }}
        public override String keepMemberId_ExistsSubQuery_MemberWithdrawalAsOne(MemberWithdrawalCQ subQuery) {
            if (_memberId_ExistsSubQuery_MemberWithdrawalAsOneMap == null) { _memberId_ExistsSubQuery_MemberWithdrawalAsOneMap = new LinkedHashMap<String, MemberWithdrawalCQ>(); }
            String key = "subQueryMapKey" + (_memberId_ExistsSubQuery_MemberWithdrawalAsOneMap.size() + 1);
            _memberId_ExistsSubQuery_MemberWithdrawalAsOneMap.put(key, subQuery); return "MemberId_ExistsSubQuery_MemberWithdrawalAsOne." + key;
        }

        protected Map<String, PurchaseCQ> _memberId_ExistsSubQuery_PurchaseListMap;
        public Map<String, PurchaseCQ> MemberId_ExistsSubQuery_PurchaseList { get { return _memberId_ExistsSubQuery_PurchaseListMap; }}
        public override String keepMemberId_ExistsSubQuery_PurchaseList(PurchaseCQ subQuery) {
            if (_memberId_ExistsSubQuery_PurchaseListMap == null) { _memberId_ExistsSubQuery_PurchaseListMap = new LinkedHashMap<String, PurchaseCQ>(); }
            String key = "subQueryMapKey" + (_memberId_ExistsSubQuery_PurchaseListMap.size() + 1);
            _memberId_ExistsSubQuery_PurchaseListMap.put(key, subQuery); return "MemberId_ExistsSubQuery_PurchaseList." + key;
        }

        protected Map<String, MemberAddressCQ> _memberId_NotExistsSubQuery_MemberAddressListMap;
        public Map<String, MemberAddressCQ> MemberId_NotExistsSubQuery_MemberAddressList { get { return _memberId_NotExistsSubQuery_MemberAddressListMap; }}
        public override String keepMemberId_NotExistsSubQuery_MemberAddressList(MemberAddressCQ subQuery) {
            if (_memberId_NotExistsSubQuery_MemberAddressListMap == null) { _memberId_NotExistsSubQuery_MemberAddressListMap = new LinkedHashMap<String, MemberAddressCQ>(); }
            String key = "subQueryMapKey" + (_memberId_NotExistsSubQuery_MemberAddressListMap.size() + 1);
            _memberId_NotExistsSubQuery_MemberAddressListMap.put(key, subQuery); return "MemberId_NotExistsSubQuery_MemberAddressList." + key;
        }

        protected Map<String, MemberLoginCQ> _memberId_NotExistsSubQuery_MemberLoginListMap;
        public Map<String, MemberLoginCQ> MemberId_NotExistsSubQuery_MemberLoginList { get { return _memberId_NotExistsSubQuery_MemberLoginListMap; }}
        public override String keepMemberId_NotExistsSubQuery_MemberLoginList(MemberLoginCQ subQuery) {
            if (_memberId_NotExistsSubQuery_MemberLoginListMap == null) { _memberId_NotExistsSubQuery_MemberLoginListMap = new LinkedHashMap<String, MemberLoginCQ>(); }
            String key = "subQueryMapKey" + (_memberId_NotExistsSubQuery_MemberLoginListMap.size() + 1);
            _memberId_NotExistsSubQuery_MemberLoginListMap.put(key, subQuery); return "MemberId_NotExistsSubQuery_MemberLoginList." + key;
        }

        protected Map<String, MemberSecurityCQ> _memberId_NotExistsSubQuery_MemberSecurityAsOneMap;
        public Map<String, MemberSecurityCQ> MemberId_NotExistsSubQuery_MemberSecurityAsOne { get { return _memberId_NotExistsSubQuery_MemberSecurityAsOneMap; }}
        public override String keepMemberId_NotExistsSubQuery_MemberSecurityAsOne(MemberSecurityCQ subQuery) {
            if (_memberId_NotExistsSubQuery_MemberSecurityAsOneMap == null) { _memberId_NotExistsSubQuery_MemberSecurityAsOneMap = new LinkedHashMap<String, MemberSecurityCQ>(); }
            String key = "subQueryMapKey" + (_memberId_NotExistsSubQuery_MemberSecurityAsOneMap.size() + 1);
            _memberId_NotExistsSubQuery_MemberSecurityAsOneMap.put(key, subQuery); return "MemberId_NotExistsSubQuery_MemberSecurityAsOne." + key;
        }

        protected Map<String, MemberWithdrawalCQ> _memberId_NotExistsSubQuery_MemberWithdrawalAsOneMap;
        public Map<String, MemberWithdrawalCQ> MemberId_NotExistsSubQuery_MemberWithdrawalAsOne { get { return _memberId_NotExistsSubQuery_MemberWithdrawalAsOneMap; }}
        public override String keepMemberId_NotExistsSubQuery_MemberWithdrawalAsOne(MemberWithdrawalCQ subQuery) {
            if (_memberId_NotExistsSubQuery_MemberWithdrawalAsOneMap == null) { _memberId_NotExistsSubQuery_MemberWithdrawalAsOneMap = new LinkedHashMap<String, MemberWithdrawalCQ>(); }
            String key = "subQueryMapKey" + (_memberId_NotExistsSubQuery_MemberWithdrawalAsOneMap.size() + 1);
            _memberId_NotExistsSubQuery_MemberWithdrawalAsOneMap.put(key, subQuery); return "MemberId_NotExistsSubQuery_MemberWithdrawalAsOne." + key;
        }

        protected Map<String, PurchaseCQ> _memberId_NotExistsSubQuery_PurchaseListMap;
        public Map<String, PurchaseCQ> MemberId_NotExistsSubQuery_PurchaseList { get { return _memberId_NotExistsSubQuery_PurchaseListMap; }}
        public override String keepMemberId_NotExistsSubQuery_PurchaseList(PurchaseCQ subQuery) {
            if (_memberId_NotExistsSubQuery_PurchaseListMap == null) { _memberId_NotExistsSubQuery_PurchaseListMap = new LinkedHashMap<String, PurchaseCQ>(); }
            String key = "subQueryMapKey" + (_memberId_NotExistsSubQuery_PurchaseListMap.size() + 1);
            _memberId_NotExistsSubQuery_PurchaseListMap.put(key, subQuery); return "MemberId_NotExistsSubQuery_PurchaseList." + key;
        }

        protected Map<String, MemberAddressCQ> _memberId_InScopeSubQuery_MemberAddressListMap;
        public Map<String, MemberAddressCQ> MemberId_InScopeSubQuery_MemberAddressList { get { return _memberId_InScopeSubQuery_MemberAddressListMap; }}
        public override String keepMemberId_InScopeSubQuery_MemberAddressList(MemberAddressCQ subQuery) {
            if (_memberId_InScopeSubQuery_MemberAddressListMap == null) { _memberId_InScopeSubQuery_MemberAddressListMap = new LinkedHashMap<String, MemberAddressCQ>(); }
            String key = "subQueryMapKey" + (_memberId_InScopeSubQuery_MemberAddressListMap.size() + 1);
            _memberId_InScopeSubQuery_MemberAddressListMap.put(key, subQuery); return "MemberId_InScopeSubQuery_MemberAddressList." + key;
        }

        protected Map<String, MemberLoginCQ> _memberId_InScopeSubQuery_MemberLoginListMap;
        public Map<String, MemberLoginCQ> MemberId_InScopeSubQuery_MemberLoginList { get { return _memberId_InScopeSubQuery_MemberLoginListMap; }}
        public override String keepMemberId_InScopeSubQuery_MemberLoginList(MemberLoginCQ subQuery) {
            if (_memberId_InScopeSubQuery_MemberLoginListMap == null) { _memberId_InScopeSubQuery_MemberLoginListMap = new LinkedHashMap<String, MemberLoginCQ>(); }
            String key = "subQueryMapKey" + (_memberId_InScopeSubQuery_MemberLoginListMap.size() + 1);
            _memberId_InScopeSubQuery_MemberLoginListMap.put(key, subQuery); return "MemberId_InScopeSubQuery_MemberLoginList." + key;
        }

        protected Map<String, MemberSecurityCQ> _memberId_InScopeSubQuery_MemberSecurityAsOneMap;
        public Map<String, MemberSecurityCQ> MemberId_InScopeSubQuery_MemberSecurityAsOne { get { return _memberId_InScopeSubQuery_MemberSecurityAsOneMap; }}
        public override String keepMemberId_InScopeSubQuery_MemberSecurityAsOne(MemberSecurityCQ subQuery) {
            if (_memberId_InScopeSubQuery_MemberSecurityAsOneMap == null) { _memberId_InScopeSubQuery_MemberSecurityAsOneMap = new LinkedHashMap<String, MemberSecurityCQ>(); }
            String key = "subQueryMapKey" + (_memberId_InScopeSubQuery_MemberSecurityAsOneMap.size() + 1);
            _memberId_InScopeSubQuery_MemberSecurityAsOneMap.put(key, subQuery); return "MemberId_InScopeSubQuery_MemberSecurityAsOne." + key;
        }

        protected Map<String, MemberWithdrawalCQ> _memberId_InScopeSubQuery_MemberWithdrawalAsOneMap;
        public Map<String, MemberWithdrawalCQ> MemberId_InScopeSubQuery_MemberWithdrawalAsOne { get { return _memberId_InScopeSubQuery_MemberWithdrawalAsOneMap; }}
        public override String keepMemberId_InScopeSubQuery_MemberWithdrawalAsOne(MemberWithdrawalCQ subQuery) {
            if (_memberId_InScopeSubQuery_MemberWithdrawalAsOneMap == null) { _memberId_InScopeSubQuery_MemberWithdrawalAsOneMap = new LinkedHashMap<String, MemberWithdrawalCQ>(); }
            String key = "subQueryMapKey" + (_memberId_InScopeSubQuery_MemberWithdrawalAsOneMap.size() + 1);
            _memberId_InScopeSubQuery_MemberWithdrawalAsOneMap.put(key, subQuery); return "MemberId_InScopeSubQuery_MemberWithdrawalAsOne." + key;
        }

        protected Map<String, PurchaseCQ> _memberId_InScopeSubQuery_PurchaseListMap;
        public Map<String, PurchaseCQ> MemberId_InScopeSubQuery_PurchaseList { get { return _memberId_InScopeSubQuery_PurchaseListMap; }}
        public override String keepMemberId_InScopeSubQuery_PurchaseList(PurchaseCQ subQuery) {
            if (_memberId_InScopeSubQuery_PurchaseListMap == null) { _memberId_InScopeSubQuery_PurchaseListMap = new LinkedHashMap<String, PurchaseCQ>(); }
            String key = "subQueryMapKey" + (_memberId_InScopeSubQuery_PurchaseListMap.size() + 1);
            _memberId_InScopeSubQuery_PurchaseListMap.put(key, subQuery); return "MemberId_InScopeSubQuery_PurchaseList." + key;
        }

        protected Map<String, MemberAddressCQ> _memberId_NotInScopeSubQuery_MemberAddressListMap;
        public Map<String, MemberAddressCQ> MemberId_NotInScopeSubQuery_MemberAddressList { get { return _memberId_NotInScopeSubQuery_MemberAddressListMap; }}
        public override String keepMemberId_NotInScopeSubQuery_MemberAddressList(MemberAddressCQ subQuery) {
            if (_memberId_NotInScopeSubQuery_MemberAddressListMap == null) { _memberId_NotInScopeSubQuery_MemberAddressListMap = new LinkedHashMap<String, MemberAddressCQ>(); }
            String key = "subQueryMapKey" + (_memberId_NotInScopeSubQuery_MemberAddressListMap.size() + 1);
            _memberId_NotInScopeSubQuery_MemberAddressListMap.put(key, subQuery); return "MemberId_NotInScopeSubQuery_MemberAddressList." + key;
        }

        protected Map<String, MemberLoginCQ> _memberId_NotInScopeSubQuery_MemberLoginListMap;
        public Map<String, MemberLoginCQ> MemberId_NotInScopeSubQuery_MemberLoginList { get { return _memberId_NotInScopeSubQuery_MemberLoginListMap; }}
        public override String keepMemberId_NotInScopeSubQuery_MemberLoginList(MemberLoginCQ subQuery) {
            if (_memberId_NotInScopeSubQuery_MemberLoginListMap == null) { _memberId_NotInScopeSubQuery_MemberLoginListMap = new LinkedHashMap<String, MemberLoginCQ>(); }
            String key = "subQueryMapKey" + (_memberId_NotInScopeSubQuery_MemberLoginListMap.size() + 1);
            _memberId_NotInScopeSubQuery_MemberLoginListMap.put(key, subQuery); return "MemberId_NotInScopeSubQuery_MemberLoginList." + key;
        }

        protected Map<String, MemberSecurityCQ> _memberId_NotInScopeSubQuery_MemberSecurityAsOneMap;
        public Map<String, MemberSecurityCQ> MemberId_NotInScopeSubQuery_MemberSecurityAsOne { get { return _memberId_NotInScopeSubQuery_MemberSecurityAsOneMap; }}
        public override String keepMemberId_NotInScopeSubQuery_MemberSecurityAsOne(MemberSecurityCQ subQuery) {
            if (_memberId_NotInScopeSubQuery_MemberSecurityAsOneMap == null) { _memberId_NotInScopeSubQuery_MemberSecurityAsOneMap = new LinkedHashMap<String, MemberSecurityCQ>(); }
            String key = "subQueryMapKey" + (_memberId_NotInScopeSubQuery_MemberSecurityAsOneMap.size() + 1);
            _memberId_NotInScopeSubQuery_MemberSecurityAsOneMap.put(key, subQuery); return "MemberId_NotInScopeSubQuery_MemberSecurityAsOne." + key;
        }

        protected Map<String, MemberWithdrawalCQ> _memberId_NotInScopeSubQuery_MemberWithdrawalAsOneMap;
        public Map<String, MemberWithdrawalCQ> MemberId_NotInScopeSubQuery_MemberWithdrawalAsOne { get { return _memberId_NotInScopeSubQuery_MemberWithdrawalAsOneMap; }}
        public override String keepMemberId_NotInScopeSubQuery_MemberWithdrawalAsOne(MemberWithdrawalCQ subQuery) {
            if (_memberId_NotInScopeSubQuery_MemberWithdrawalAsOneMap == null) { _memberId_NotInScopeSubQuery_MemberWithdrawalAsOneMap = new LinkedHashMap<String, MemberWithdrawalCQ>(); }
            String key = "subQueryMapKey" + (_memberId_NotInScopeSubQuery_MemberWithdrawalAsOneMap.size() + 1);
            _memberId_NotInScopeSubQuery_MemberWithdrawalAsOneMap.put(key, subQuery); return "MemberId_NotInScopeSubQuery_MemberWithdrawalAsOne." + key;
        }

        protected Map<String, PurchaseCQ> _memberId_NotInScopeSubQuery_PurchaseListMap;
        public Map<String, PurchaseCQ> MemberId_NotInScopeSubQuery_PurchaseList { get { return _memberId_NotInScopeSubQuery_PurchaseListMap; }}
        public override String keepMemberId_NotInScopeSubQuery_PurchaseList(PurchaseCQ subQuery) {
            if (_memberId_NotInScopeSubQuery_PurchaseListMap == null) { _memberId_NotInScopeSubQuery_PurchaseListMap = new LinkedHashMap<String, PurchaseCQ>(); }
            String key = "subQueryMapKey" + (_memberId_NotInScopeSubQuery_PurchaseListMap.size() + 1);
            _memberId_NotInScopeSubQuery_PurchaseListMap.put(key, subQuery); return "MemberId_NotInScopeSubQuery_PurchaseList." + key;
        }

        protected Map<String, MemberAddressCQ> _memberId_SpecifyDerivedReferrer_MemberAddressListMap;
        public Map<String, MemberAddressCQ> MemberId_SpecifyDerivedReferrer_MemberAddressList { get { return _memberId_SpecifyDerivedReferrer_MemberAddressListMap; }}
        public override String keepMemberId_SpecifyDerivedReferrer_MemberAddressList(MemberAddressCQ subQuery) {
            if (_memberId_SpecifyDerivedReferrer_MemberAddressListMap == null) { _memberId_SpecifyDerivedReferrer_MemberAddressListMap = new LinkedHashMap<String, MemberAddressCQ>(); }
            String key = "subQueryMapKey" + (_memberId_SpecifyDerivedReferrer_MemberAddressListMap.size() + 1);
            _memberId_SpecifyDerivedReferrer_MemberAddressListMap.put(key, subQuery); return "MemberId_SpecifyDerivedReferrer_MemberAddressList." + key;
        }

        protected Map<String, MemberLoginCQ> _memberId_SpecifyDerivedReferrer_MemberLoginListMap;
        public Map<String, MemberLoginCQ> MemberId_SpecifyDerivedReferrer_MemberLoginList { get { return _memberId_SpecifyDerivedReferrer_MemberLoginListMap; }}
        public override String keepMemberId_SpecifyDerivedReferrer_MemberLoginList(MemberLoginCQ subQuery) {
            if (_memberId_SpecifyDerivedReferrer_MemberLoginListMap == null) { _memberId_SpecifyDerivedReferrer_MemberLoginListMap = new LinkedHashMap<String, MemberLoginCQ>(); }
            String key = "subQueryMapKey" + (_memberId_SpecifyDerivedReferrer_MemberLoginListMap.size() + 1);
            _memberId_SpecifyDerivedReferrer_MemberLoginListMap.put(key, subQuery); return "MemberId_SpecifyDerivedReferrer_MemberLoginList." + key;
        }

        protected Map<String, PurchaseCQ> _memberId_SpecifyDerivedReferrer_PurchaseListMap;
        public Map<String, PurchaseCQ> MemberId_SpecifyDerivedReferrer_PurchaseList { get { return _memberId_SpecifyDerivedReferrer_PurchaseListMap; }}
        public override String keepMemberId_SpecifyDerivedReferrer_PurchaseList(PurchaseCQ subQuery) {
            if (_memberId_SpecifyDerivedReferrer_PurchaseListMap == null) { _memberId_SpecifyDerivedReferrer_PurchaseListMap = new LinkedHashMap<String, PurchaseCQ>(); }
            String key = "subQueryMapKey" + (_memberId_SpecifyDerivedReferrer_PurchaseListMap.size() + 1);
            _memberId_SpecifyDerivedReferrer_PurchaseListMap.put(key, subQuery); return "MemberId_SpecifyDerivedReferrer_PurchaseList." + key;
        }

        protected Map<String, MemberAddressCQ> _memberId_QueryDerivedReferrer_MemberAddressListMap;
        public Map<String, MemberAddressCQ> MemberId_QueryDerivedReferrer_MemberAddressList { get { return _memberId_QueryDerivedReferrer_MemberAddressListMap; } }
        public override String keepMemberId_QueryDerivedReferrer_MemberAddressList(MemberAddressCQ subQuery) {
            if (_memberId_QueryDerivedReferrer_MemberAddressListMap == null) { _memberId_QueryDerivedReferrer_MemberAddressListMap = new LinkedHashMap<String, MemberAddressCQ>(); }
            String key = "subQueryMapKey" + (_memberId_QueryDerivedReferrer_MemberAddressListMap.size() + 1);
            _memberId_QueryDerivedReferrer_MemberAddressListMap.put(key, subQuery); return "MemberId_QueryDerivedReferrer_MemberAddressList." + key;
        }
        protected Map<String, Object> _memberId_QueryDerivedReferrer_MemberAddressListParameterMap;
        public Map<String, Object> MemberId_QueryDerivedReferrer_MemberAddressListParameter { get { return _memberId_QueryDerivedReferrer_MemberAddressListParameterMap; } }
        public override String keepMemberId_QueryDerivedReferrer_MemberAddressListParameter(Object parameterValue) {
            if (_memberId_QueryDerivedReferrer_MemberAddressListParameterMap == null) { _memberId_QueryDerivedReferrer_MemberAddressListParameterMap = new LinkedHashMap<String, Object>(); }
            String key = "subQueryParameterKey" + (_memberId_QueryDerivedReferrer_MemberAddressListParameterMap.size() + 1);
            _memberId_QueryDerivedReferrer_MemberAddressListParameterMap.put(key, parameterValue); return "MemberId_QueryDerivedReferrer_MemberAddressListParameter." + key;
        }

        protected Map<String, MemberLoginCQ> _memberId_QueryDerivedReferrer_MemberLoginListMap;
        public Map<String, MemberLoginCQ> MemberId_QueryDerivedReferrer_MemberLoginList { get { return _memberId_QueryDerivedReferrer_MemberLoginListMap; } }
        public override String keepMemberId_QueryDerivedReferrer_MemberLoginList(MemberLoginCQ subQuery) {
            if (_memberId_QueryDerivedReferrer_MemberLoginListMap == null) { _memberId_QueryDerivedReferrer_MemberLoginListMap = new LinkedHashMap<String, MemberLoginCQ>(); }
            String key = "subQueryMapKey" + (_memberId_QueryDerivedReferrer_MemberLoginListMap.size() + 1);
            _memberId_QueryDerivedReferrer_MemberLoginListMap.put(key, subQuery); return "MemberId_QueryDerivedReferrer_MemberLoginList." + key;
        }
        protected Map<String, Object> _memberId_QueryDerivedReferrer_MemberLoginListParameterMap;
        public Map<String, Object> MemberId_QueryDerivedReferrer_MemberLoginListParameter { get { return _memberId_QueryDerivedReferrer_MemberLoginListParameterMap; } }
        public override String keepMemberId_QueryDerivedReferrer_MemberLoginListParameter(Object parameterValue) {
            if (_memberId_QueryDerivedReferrer_MemberLoginListParameterMap == null) { _memberId_QueryDerivedReferrer_MemberLoginListParameterMap = new LinkedHashMap<String, Object>(); }
            String key = "subQueryParameterKey" + (_memberId_QueryDerivedReferrer_MemberLoginListParameterMap.size() + 1);
            _memberId_QueryDerivedReferrer_MemberLoginListParameterMap.put(key, parameterValue); return "MemberId_QueryDerivedReferrer_MemberLoginListParameter." + key;
        }

        protected Map<String, PurchaseCQ> _memberId_QueryDerivedReferrer_PurchaseListMap;
        public Map<String, PurchaseCQ> MemberId_QueryDerivedReferrer_PurchaseList { get { return _memberId_QueryDerivedReferrer_PurchaseListMap; } }
        public override String keepMemberId_QueryDerivedReferrer_PurchaseList(PurchaseCQ subQuery) {
            if (_memberId_QueryDerivedReferrer_PurchaseListMap == null) { _memberId_QueryDerivedReferrer_PurchaseListMap = new LinkedHashMap<String, PurchaseCQ>(); }
            String key = "subQueryMapKey" + (_memberId_QueryDerivedReferrer_PurchaseListMap.size() + 1);
            _memberId_QueryDerivedReferrer_PurchaseListMap.put(key, subQuery); return "MemberId_QueryDerivedReferrer_PurchaseList." + key;
        }
        protected Map<String, Object> _memberId_QueryDerivedReferrer_PurchaseListParameterMap;
        public Map<String, Object> MemberId_QueryDerivedReferrer_PurchaseListParameter { get { return _memberId_QueryDerivedReferrer_PurchaseListParameterMap; } }
        public override String keepMemberId_QueryDerivedReferrer_PurchaseListParameter(Object parameterValue) {
            if (_memberId_QueryDerivedReferrer_PurchaseListParameterMap == null) { _memberId_QueryDerivedReferrer_PurchaseListParameterMap = new LinkedHashMap<String, Object>(); }
            String key = "subQueryParameterKey" + (_memberId_QueryDerivedReferrer_PurchaseListParameterMap.size() + 1);
            _memberId_QueryDerivedReferrer_PurchaseListParameterMap.put(key, parameterValue); return "MemberId_QueryDerivedReferrer_PurchaseListParameter." + key;
        }

        public BsMemberCQ AddOrderBy_MemberId_Asc() { regOBA("MEMBER_ID");return this; }
        public BsMemberCQ AddOrderBy_MemberId_Desc() { regOBD("MEMBER_ID");return this; }

        protected ConditionValue _memberName;
        public ConditionValue MemberName {
            get { if (_memberName == null) { _memberName = new ConditionValue(); } return _memberName; }
        }
        protected override ConditionValue getCValueMemberName() { return this.MemberName; }


        public BsMemberCQ AddOrderBy_MemberName_Asc() { regOBA("MEMBER_NAME");return this; }
        public BsMemberCQ AddOrderBy_MemberName_Desc() { regOBD("MEMBER_NAME");return this; }

        protected ConditionValue _memberAccount;
        public ConditionValue MemberAccount {
            get { if (_memberAccount == null) { _memberAccount = new ConditionValue(); } return _memberAccount; }
        }
        protected override ConditionValue getCValueMemberAccount() { return this.MemberAccount; }


        public BsMemberCQ AddOrderBy_MemberAccount_Asc() { regOBA("MEMBER_ACCOUNT");return this; }
        public BsMemberCQ AddOrderBy_MemberAccount_Desc() { regOBD("MEMBER_ACCOUNT");return this; }

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

        public BsMemberCQ AddOrderBy_MemberStatusCode_Asc() { regOBA("MEMBER_STATUS_CODE");return this; }
        public BsMemberCQ AddOrderBy_MemberStatusCode_Desc() { regOBD("MEMBER_STATUS_CODE");return this; }

        protected ConditionValue _formalizedDatetime;
        public ConditionValue FormalizedDatetime {
            get { if (_formalizedDatetime == null) { _formalizedDatetime = new ConditionValue(); } return _formalizedDatetime; }
        }
        protected override ConditionValue getCValueFormalizedDatetime() { return this.FormalizedDatetime; }


        public BsMemberCQ AddOrderBy_FormalizedDatetime_Asc() { regOBA("FORMALIZED_DATETIME");return this; }
        public BsMemberCQ AddOrderBy_FormalizedDatetime_Desc() { regOBD("FORMALIZED_DATETIME");return this; }

        protected ConditionValue _birthdate;
        public ConditionValue Birthdate {
            get { if (_birthdate == null) { _birthdate = new ConditionValue(); } return _birthdate; }
        }
        protected override ConditionValue getCValueBirthdate() { return this.Birthdate; }


        public BsMemberCQ AddOrderBy_Birthdate_Asc() { regOBA("BIRTHDATE");return this; }
        public BsMemberCQ AddOrderBy_Birthdate_Desc() { regOBD("BIRTHDATE");return this; }

        protected ConditionValue _registerDatetime;
        public ConditionValue RegisterDatetime {
            get { if (_registerDatetime == null) { _registerDatetime = new ConditionValue(); } return _registerDatetime; }
        }
        protected override ConditionValue getCValueRegisterDatetime() { return this.RegisterDatetime; }


        public BsMemberCQ AddOrderBy_RegisterDatetime_Asc() { regOBA("REGISTER_DATETIME");return this; }
        public BsMemberCQ AddOrderBy_RegisterDatetime_Desc() { regOBD("REGISTER_DATETIME");return this; }

        protected ConditionValue _registerUser;
        public ConditionValue RegisterUser {
            get { if (_registerUser == null) { _registerUser = new ConditionValue(); } return _registerUser; }
        }
        protected override ConditionValue getCValueRegisterUser() { return this.RegisterUser; }


        public BsMemberCQ AddOrderBy_RegisterUser_Asc() { regOBA("REGISTER_USER");return this; }
        public BsMemberCQ AddOrderBy_RegisterUser_Desc() { regOBD("REGISTER_USER");return this; }

        protected ConditionValue _registerProcess;
        public ConditionValue RegisterProcess {
            get { if (_registerProcess == null) { _registerProcess = new ConditionValue(); } return _registerProcess; }
        }
        protected override ConditionValue getCValueRegisterProcess() { return this.RegisterProcess; }


        public BsMemberCQ AddOrderBy_RegisterProcess_Asc() { regOBA("REGISTER_PROCESS");return this; }
        public BsMemberCQ AddOrderBy_RegisterProcess_Desc() { regOBD("REGISTER_PROCESS");return this; }

        protected ConditionValue _updateDatetime;
        public ConditionValue UpdateDatetime {
            get { if (_updateDatetime == null) { _updateDatetime = new ConditionValue(); } return _updateDatetime; }
        }
        protected override ConditionValue getCValueUpdateDatetime() { return this.UpdateDatetime; }


        public BsMemberCQ AddOrderBy_UpdateDatetime_Asc() { regOBA("UPDATE_DATETIME");return this; }
        public BsMemberCQ AddOrderBy_UpdateDatetime_Desc() { regOBD("UPDATE_DATETIME");return this; }

        protected ConditionValue _updateUser;
        public ConditionValue UpdateUser {
            get { if (_updateUser == null) { _updateUser = new ConditionValue(); } return _updateUser; }
        }
        protected override ConditionValue getCValueUpdateUser() { return this.UpdateUser; }


        public BsMemberCQ AddOrderBy_UpdateUser_Asc() { regOBA("UPDATE_USER");return this; }
        public BsMemberCQ AddOrderBy_UpdateUser_Desc() { regOBD("UPDATE_USER");return this; }

        protected ConditionValue _updateProcess;
        public ConditionValue UpdateProcess {
            get { if (_updateProcess == null) { _updateProcess = new ConditionValue(); } return _updateProcess; }
        }
        protected override ConditionValue getCValueUpdateProcess() { return this.UpdateProcess; }


        public BsMemberCQ AddOrderBy_UpdateProcess_Asc() { regOBA("UPDATE_PROCESS");return this; }
        public BsMemberCQ AddOrderBy_UpdateProcess_Desc() { regOBD("UPDATE_PROCESS");return this; }

        protected ConditionValue _versionNo;
        public ConditionValue VersionNo {
            get { if (_versionNo == null) { _versionNo = new ConditionValue(); } return _versionNo; }
        }
        protected override ConditionValue getCValueVersionNo() { return this.VersionNo; }


        public BsMemberCQ AddOrderBy_VersionNo_Asc() { regOBA("VERSION_NO");return this; }
        public BsMemberCQ AddOrderBy_VersionNo_Desc() { regOBD("VERSION_NO");return this; }

        public BsMemberCQ AddSpecifiedDerivedOrderBy_Asc(String aliasName) { registerSpecifiedDerivedOrderBy_Asc(aliasName); return this; }
        public BsMemberCQ AddSpecifiedDerivedOrderBy_Desc(String aliasName) { registerSpecifiedDerivedOrderBy_Desc(aliasName); return this; }

        public override void reflectRelationOnUnionQuery(ConditionQuery baseQueryAsSuper, ConditionQuery unionQueryAsSuper) {
            MemberCQ baseQuery = (MemberCQ)baseQueryAsSuper;
            MemberCQ unionQuery = (MemberCQ)unionQueryAsSuper;
            if (baseQuery.hasConditionQueryMemberStatus()) {
                unionQuery.QueryMemberStatus().reflectRelationOnUnionQuery(baseQuery.QueryMemberStatus(), unionQuery.QueryMemberStatus());
            }
            if (baseQuery.hasConditionQueryMemberLoginAsLatest()) {
                unionQuery.QueryMemberLoginAsLatest().reflectRelationOnUnionQuery(baseQuery.QueryMemberLoginAsLatest(), unionQuery.QueryMemberLoginAsLatest());
            }
            if (baseQuery.hasConditionQueryMemberAddressAsValid()) {
                unionQuery.xsetParameterMapMemberAddressAsValid(baseQuery.parameterMapMemberAddressAsValid);
                unionQuery.ConditionQueryMemberAddressAsValid.reflectRelationOnUnionQuery(baseQuery.ConditionQueryMemberAddressAsValid, unionQuery.ConditionQueryMemberAddressAsValid);
            }
            if (baseQuery.hasConditionQueryMemberLoginAsLocalForeignOverTest()) {
                unionQuery.QueryMemberLoginAsLocalForeignOverTest().reflectRelationOnUnionQuery(baseQuery.QueryMemberLoginAsLocalForeignOverTest(), unionQuery.QueryMemberLoginAsLocalForeignOverTest());
            }
            if (baseQuery.hasConditionQueryMemberLoginAsForeignForeignOverTest()) {
                unionQuery.QueryMemberLoginAsForeignForeignOverTest().reflectRelationOnUnionQuery(baseQuery.QueryMemberLoginAsForeignForeignOverTest(), unionQuery.QueryMemberLoginAsForeignForeignOverTest());
            }
            if (baseQuery.hasConditionQueryMemberLoginAsForeignForeignParameterOverTest()) {
                unionQuery.xsetParameterMapMemberLoginAsForeignForeignParameterOverTest(baseQuery.parameterMapMemberLoginAsForeignForeignParameterOverTest);
                unionQuery.ConditionQueryMemberLoginAsForeignForeignParameterOverTest.reflectRelationOnUnionQuery(baseQuery.ConditionQueryMemberLoginAsForeignForeignParameterOverTest, unionQuery.ConditionQueryMemberLoginAsForeignForeignParameterOverTest);
            }
            if (baseQuery.hasConditionQueryMemberLoginAsForeignForeignVariousOverTest()) {
                unionQuery.QueryMemberLoginAsForeignForeignVariousOverTest().reflectRelationOnUnionQuery(baseQuery.QueryMemberLoginAsForeignForeignVariousOverTest(), unionQuery.QueryMemberLoginAsForeignForeignVariousOverTest());
            }
            if (baseQuery.hasConditionQueryMemberLoginAsReferrerOverTest()) {
                unionQuery.QueryMemberLoginAsReferrerOverTest().reflectRelationOnUnionQuery(baseQuery.QueryMemberLoginAsReferrerOverTest(), unionQuery.QueryMemberLoginAsReferrerOverTest());
            }
            if (baseQuery.hasConditionQueryMemberLoginAsReferrerForeignOverTest()) {
                unionQuery.QueryMemberLoginAsReferrerForeignOverTest().reflectRelationOnUnionQuery(baseQuery.QueryMemberLoginAsReferrerForeignOverTest(), unionQuery.QueryMemberLoginAsReferrerForeignOverTest());
            }
            if (baseQuery.hasConditionQueryMemberSecurityAsOne()) {
                unionQuery.QueryMemberSecurityAsOne().reflectRelationOnUnionQuery(baseQuery.QueryMemberSecurityAsOne(), unionQuery.QueryMemberSecurityAsOne());
            }
            if (baseQuery.hasConditionQueryMemberWithdrawalAsOne()) {
                unionQuery.QueryMemberWithdrawalAsOne().reflectRelationOnUnionQuery(baseQuery.QueryMemberWithdrawalAsOne(), unionQuery.QueryMemberWithdrawalAsOne());
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
            return resolveNextRelationPath("member", "memberStatus");
        }
        public bool hasConditionQueryMemberStatus() {
            return _conditionQueryMemberStatus != null;
        }
        protected MemberLoginCQ _conditionQueryMemberLoginAsLatest;
        public MemberLoginCQ QueryMemberLoginAsLatest() {
            return this.ConditionQueryMemberLoginAsLatest;
        }
        public MemberLoginCQ ConditionQueryMemberLoginAsLatest {
            get {
                if (_conditionQueryMemberLoginAsLatest == null) {
                    _conditionQueryMemberLoginAsLatest = xcreateQueryMemberLoginAsLatest();
                    xsetupOuterJoin_MemberLoginAsLatest();
                }
                return _conditionQueryMemberLoginAsLatest;
            }
        }
        protected MemberLoginCQ xcreateQueryMemberLoginAsLatest() {
            String nrp = resolveNextRelationPathMemberLoginAsLatest();
            String jan = resolveJoinAliasName(nrp, xgetNextNestLevel());
            MemberLoginCQ cq = new MemberLoginCQ(this, xgetSqlClause(), jan, xgetNextNestLevel());
            cq.xsetForeignPropertyName("memberLoginAsLatest"); cq.xsetRelationPath(nrp); return cq;
        }
        public void xsetupOuterJoin_MemberLoginAsLatest() {
            MemberLoginCQ cq = ConditionQueryMemberLoginAsLatest;
            Map<String, String> joinOnMap = new LinkedHashMap<String, String>();
            joinOnMap.put("MEMBER_ID", "MEMBER_ID");
            registerOuterJoin(cq, joinOnMap, "$$foreignAlias$$.LOGIN_DATETIME = (select max(LOGIN_DATETIME)\n                                     from MEMBER_LOGIN\n                                    where MEMBER_ID = $$localAlias$$.MEMBER_ID\n                                  )");
        }
        protected String resolveNextRelationPathMemberLoginAsLatest() {
            return resolveNextRelationPath("member", "memberLoginAsLatest");
        }
        public bool hasConditionQueryMemberLoginAsLatest() {
            return _conditionQueryMemberLoginAsLatest != null;
        }
        protected MemberAddressCQ _conditionQueryMemberAddressAsValid;
        public MemberAddressCQ QueryMemberAddressAsValid(DateTime targetDate) {
            Map<String, Object> parameterMap = parameterMapMemberAddressAsValid;
            parameterMap.put("targetDate", targetDate);
            return this.ConditionQueryMemberAddressAsValid;
        }
        public MemberAddressCQ ConditionQueryMemberAddressAsValid {
            get {
                if (_conditionQueryMemberAddressAsValid == null) {
                    _conditionQueryMemberAddressAsValid = xcreateQueryMemberAddressAsValid();
                    xsetupOuterJoin_MemberAddressAsValid();
                }
                return _conditionQueryMemberAddressAsValid;
            }
        }
        protected Map<String, Object> _parameterMapMemberAddressAsValid;
        public Map<String, Object> parameterMapMemberAddressAsValid { get {
            if (_parameterMapMemberAddressAsValid == null) {
                _parameterMapMemberAddressAsValid = new LinkedHashMap<String, Object>();
            }
            return _parameterMapMemberAddressAsValid;
        }}
        public void xsetParameterMapMemberAddressAsValid(Map<String, Object> parameterMap) {
            _parameterMapMemberAddressAsValid = parameterMap; // for UnionQuery
        }
        protected MemberAddressCQ xcreateQueryMemberAddressAsValid() {
            String nrp = resolveNextRelationPathMemberAddressAsValid();
            String jan = resolveJoinAliasName(nrp, xgetNextNestLevel());
            MemberAddressCQ cq = new MemberAddressCQ(this, xgetSqlClause(), jan, xgetNextNestLevel());
            cq.xsetForeignPropertyName("memberAddressAsValid"); cq.xsetRelationPath(nrp); return cq;
        }
        public void xsetupOuterJoin_MemberAddressAsValid() {
            MemberAddressCQ cq = ConditionQueryMemberAddressAsValid;
            Map<String, String> joinOnMap = new LinkedHashMap<String, String>();
            joinOnMap.put("MEMBER_ID", "MEMBER_ID");
            registerOuterJoin(cq, joinOnMap, "$$foreignAlias$$.VALID_BEGIN_DATE <= /*$$locationBase$$.parameterMapMemberAddressAsValid.targetDate*/null\n         and $$foreignAlias$$.VALID_END_DATE >= /*$$locationBase$$.parameterMapMemberAddressAsValid.targetDate*/null");
        }
        protected String resolveNextRelationPathMemberAddressAsValid() {
            return resolveNextRelationPath("member", "memberAddressAsValid");
        }
        public bool hasConditionQueryMemberAddressAsValid() {
            return _conditionQueryMemberAddressAsValid != null;
        }
        protected MemberLoginCQ _conditionQueryMemberLoginAsLocalForeignOverTest;
        public MemberLoginCQ QueryMemberLoginAsLocalForeignOverTest() {
            return this.ConditionQueryMemberLoginAsLocalForeignOverTest;
        }
        public MemberLoginCQ ConditionQueryMemberLoginAsLocalForeignOverTest {
            get {
                if (_conditionQueryMemberLoginAsLocalForeignOverTest == null) {
                    _conditionQueryMemberLoginAsLocalForeignOverTest = xcreateQueryMemberLoginAsLocalForeignOverTest();
                    xsetupOuterJoin_MemberLoginAsLocalForeignOverTest();
                }
                return _conditionQueryMemberLoginAsLocalForeignOverTest;
            }
        }
        protected MemberLoginCQ xcreateQueryMemberLoginAsLocalForeignOverTest() {
            String nrp = resolveNextRelationPathMemberLoginAsLocalForeignOverTest();
            String jan = resolveJoinAliasName(nrp, xgetNextNestLevel());
            MemberLoginCQ cq = new MemberLoginCQ(this, xgetSqlClause(), jan, xgetNextNestLevel());
            cq.xsetForeignPropertyName("memberLoginAsLocalForeignOverTest"); cq.xsetRelationPath(nrp); return cq;
        }
        public void xsetupOuterJoin_MemberLoginAsLocalForeignOverTest() {
            MemberLoginCQ cq = ConditionQueryMemberLoginAsLocalForeignOverTest;
            Map<String, String> joinOnMap = new LinkedHashMap<String, String>();
            joinOnMap.put("MEMBER_ID", "MEMBER_ID");
            registerOuterJoin(cq, joinOnMap, "$$foreignAlias$$.LOGIN_MEMBER_STATUS_CODE = $$over($localTable.memberStatus)$$.MEMBER_STATUS_NAME");
        }
        protected String resolveNextRelationPathMemberLoginAsLocalForeignOverTest() {
            return resolveNextRelationPath("member", "memberLoginAsLocalForeignOverTest");
        }
        public bool hasConditionQueryMemberLoginAsLocalForeignOverTest() {
            return _conditionQueryMemberLoginAsLocalForeignOverTest != null;
        }
        protected MemberLoginCQ _conditionQueryMemberLoginAsForeignForeignOverTest;
        public MemberLoginCQ QueryMemberLoginAsForeignForeignOverTest() {
            return this.ConditionQueryMemberLoginAsForeignForeignOverTest;
        }
        public MemberLoginCQ ConditionQueryMemberLoginAsForeignForeignOverTest {
            get {
                if (_conditionQueryMemberLoginAsForeignForeignOverTest == null) {
                    _conditionQueryMemberLoginAsForeignForeignOverTest = xcreateQueryMemberLoginAsForeignForeignOverTest();
                    xsetupOuterJoin_MemberLoginAsForeignForeignOverTest();
                }
                return _conditionQueryMemberLoginAsForeignForeignOverTest;
            }
        }
        protected MemberLoginCQ xcreateQueryMemberLoginAsForeignForeignOverTest() {
            String nrp = resolveNextRelationPathMemberLoginAsForeignForeignOverTest();
            String jan = resolveJoinAliasName(nrp, xgetNextNestLevel());
            MemberLoginCQ cq = new MemberLoginCQ(this, xgetSqlClause(), jan, xgetNextNestLevel());
            cq.xsetForeignPropertyName("memberLoginAsForeignForeignOverTest"); cq.xsetRelationPath(nrp); return cq;
        }
        public void xsetupOuterJoin_MemberLoginAsForeignForeignOverTest() {
            MemberLoginCQ cq = ConditionQueryMemberLoginAsForeignForeignOverTest;
            Map<String, String> joinOnMap = new LinkedHashMap<String, String>();
            joinOnMap.put("MEMBER_ID", "MEMBER_ID");
            registerOuterJoin(cq, joinOnMap, "$$over($localTable.memberStatus)$$.DISPLAY_ORDER = $$over($foreignTable.memberStatus)$$.DISPLAY_ORDER");
        }
        protected String resolveNextRelationPathMemberLoginAsForeignForeignOverTest() {
            return resolveNextRelationPath("member", "memberLoginAsForeignForeignOverTest");
        }
        public bool hasConditionQueryMemberLoginAsForeignForeignOverTest() {
            return _conditionQueryMemberLoginAsForeignForeignOverTest != null;
        }
        protected MemberLoginCQ _conditionQueryMemberLoginAsForeignForeignParameterOverTest;
        public MemberLoginCQ QueryMemberLoginAsForeignForeignParameterOverTest(DateTime targetDate) {
            Map<String, Object> parameterMap = parameterMapMemberLoginAsForeignForeignParameterOverTest;
            parameterMap.put("targetDate", targetDate);
            return this.ConditionQueryMemberLoginAsForeignForeignParameterOverTest;
        }
        public MemberLoginCQ ConditionQueryMemberLoginAsForeignForeignParameterOverTest {
            get {
                if (_conditionQueryMemberLoginAsForeignForeignParameterOverTest == null) {
                    _conditionQueryMemberLoginAsForeignForeignParameterOverTest = xcreateQueryMemberLoginAsForeignForeignParameterOverTest();
                    xsetupOuterJoin_MemberLoginAsForeignForeignParameterOverTest();
                }
                return _conditionQueryMemberLoginAsForeignForeignParameterOverTest;
            }
        }
        protected Map<String, Object> _parameterMapMemberLoginAsForeignForeignParameterOverTest;
        public Map<String, Object> parameterMapMemberLoginAsForeignForeignParameterOverTest { get {
            if (_parameterMapMemberLoginAsForeignForeignParameterOverTest == null) {
                _parameterMapMemberLoginAsForeignForeignParameterOverTest = new LinkedHashMap<String, Object>();
            }
            return _parameterMapMemberLoginAsForeignForeignParameterOverTest;
        }}
        public void xsetParameterMapMemberLoginAsForeignForeignParameterOverTest(Map<String, Object> parameterMap) {
            _parameterMapMemberLoginAsForeignForeignParameterOverTest = parameterMap; // for UnionQuery
        }
        protected MemberLoginCQ xcreateQueryMemberLoginAsForeignForeignParameterOverTest() {
            String nrp = resolveNextRelationPathMemberLoginAsForeignForeignParameterOverTest();
            String jan = resolveJoinAliasName(nrp, xgetNextNestLevel());
            MemberLoginCQ cq = new MemberLoginCQ(this, xgetSqlClause(), jan, xgetNextNestLevel());
            cq.xsetForeignPropertyName("memberLoginAsForeignForeignParameterOverTest"); cq.xsetRelationPath(nrp); return cq;
        }
        public void xsetupOuterJoin_MemberLoginAsForeignForeignParameterOverTest() {
            MemberLoginCQ cq = ConditionQueryMemberLoginAsForeignForeignParameterOverTest;
            Map<String, String> joinOnMap = new LinkedHashMap<String, String>();
            joinOnMap.put("MEMBER_ID", "MEMBER_ID");
            registerOuterJoin(cq, joinOnMap, "$$over($localTable.memberStatus)$$.DISPLAY_ORDER = $$over($foreignTable.memberStatus, DISPLAY_ORDER)$$.STATUS_ORDER\n         and $$localAlias$$.BIRTHDATE > /*$$locationBase$$.parameterMapMemberLoginAsForeignForeignParameterOverTest.targetDate*/null");
        }
        protected String resolveNextRelationPathMemberLoginAsForeignForeignParameterOverTest() {
            return resolveNextRelationPath("member", "memberLoginAsForeignForeignParameterOverTest");
        }
        public bool hasConditionQueryMemberLoginAsForeignForeignParameterOverTest() {
            return _conditionQueryMemberLoginAsForeignForeignParameterOverTest != null;
        }
        protected MemberLoginCQ _conditionQueryMemberLoginAsForeignForeignVariousOverTest;
        public MemberLoginCQ QueryMemberLoginAsForeignForeignVariousOverTest() {
            return this.ConditionQueryMemberLoginAsForeignForeignVariousOverTest;
        }
        public MemberLoginCQ ConditionQueryMemberLoginAsForeignForeignVariousOverTest {
            get {
                if (_conditionQueryMemberLoginAsForeignForeignVariousOverTest == null) {
                    _conditionQueryMemberLoginAsForeignForeignVariousOverTest = xcreateQueryMemberLoginAsForeignForeignVariousOverTest();
                    xsetupOuterJoin_MemberLoginAsForeignForeignVariousOverTest();
                }
                return _conditionQueryMemberLoginAsForeignForeignVariousOverTest;
            }
        }
        protected MemberLoginCQ xcreateQueryMemberLoginAsForeignForeignVariousOverTest() {
            String nrp = resolveNextRelationPathMemberLoginAsForeignForeignVariousOverTest();
            String jan = resolveJoinAliasName(nrp, xgetNextNestLevel());
            MemberLoginCQ cq = new MemberLoginCQ(this, xgetSqlClause(), jan, xgetNextNestLevel());
            cq.xsetForeignPropertyName("memberLoginAsForeignForeignVariousOverTest"); cq.xsetRelationPath(nrp); return cq;
        }
        public void xsetupOuterJoin_MemberLoginAsForeignForeignVariousOverTest() {
            MemberLoginCQ cq = ConditionQueryMemberLoginAsForeignForeignVariousOverTest;
            Map<String, String> joinOnMap = new LinkedHashMap<String, String>();
            joinOnMap.put("MEMBER_ID", "MEMBER_ID");
            registerOuterJoin(cq, joinOnMap, "$$over($foreignTable.member.memberStatus)$$.DISPLAY_ORDER is not null\n         and $$over($foreignTable.member.memberWithdrawalAsOne)$$.WITHDRAWAL_DATETIME is not null\n         and $$over($foreignTable.memberStatus, DISPLAY_ORDER)$$.STATUS_ORDER is not null\n         and $$over($foreignTable.member.memberWithdrawalAsOne.withdrawalReason, DISPLAY_ORDER)$$.REASON_ORDER is not null\n         and $$over($foreignTable.memberStatus)$$.MEMBER_STATUS_NAME is not null\n         and $$over(PURCHASE.product.productStatus)$$.PRODUCT_STATUS_NAME is not null");
        }
        protected String resolveNextRelationPathMemberLoginAsForeignForeignVariousOverTest() {
            return resolveNextRelationPath("member", "memberLoginAsForeignForeignVariousOverTest");
        }
        public bool hasConditionQueryMemberLoginAsForeignForeignVariousOverTest() {
            return _conditionQueryMemberLoginAsForeignForeignVariousOverTest != null;
        }
        protected MemberLoginCQ _conditionQueryMemberLoginAsReferrerOverTest;
        public MemberLoginCQ QueryMemberLoginAsReferrerOverTest() {
            return this.ConditionQueryMemberLoginAsReferrerOverTest;
        }
        public MemberLoginCQ ConditionQueryMemberLoginAsReferrerOverTest {
            get {
                if (_conditionQueryMemberLoginAsReferrerOverTest == null) {
                    _conditionQueryMemberLoginAsReferrerOverTest = xcreateQueryMemberLoginAsReferrerOverTest();
                    xsetupOuterJoin_MemberLoginAsReferrerOverTest();
                }
                return _conditionQueryMemberLoginAsReferrerOverTest;
            }
        }
        protected MemberLoginCQ xcreateQueryMemberLoginAsReferrerOverTest() {
            String nrp = resolveNextRelationPathMemberLoginAsReferrerOverTest();
            String jan = resolveJoinAliasName(nrp, xgetNextNestLevel());
            MemberLoginCQ cq = new MemberLoginCQ(this, xgetSqlClause(), jan, xgetNextNestLevel());
            cq.xsetForeignPropertyName("memberLoginAsReferrerOverTest"); cq.xsetRelationPath(nrp); return cq;
        }
        public void xsetupOuterJoin_MemberLoginAsReferrerOverTest() {
            MemberLoginCQ cq = ConditionQueryMemberLoginAsReferrerOverTest;
            Map<String, String> joinOnMap = new LinkedHashMap<String, String>();
            joinOnMap.put("MEMBER_ID", "MEMBER_ID");
            registerOuterJoin(cq, joinOnMap, "$$foreignAlias$$.LOGIN_DATETIME > $$over(PURCHASE)$$.PURCHASE_DATETIME");
        }
        protected String resolveNextRelationPathMemberLoginAsReferrerOverTest() {
            return resolveNextRelationPath("member", "memberLoginAsReferrerOverTest");
        }
        public bool hasConditionQueryMemberLoginAsReferrerOverTest() {
            return _conditionQueryMemberLoginAsReferrerOverTest != null;
        }
        protected MemberLoginCQ _conditionQueryMemberLoginAsReferrerForeignOverTest;
        public MemberLoginCQ QueryMemberLoginAsReferrerForeignOverTest() {
            return this.ConditionQueryMemberLoginAsReferrerForeignOverTest;
        }
        public MemberLoginCQ ConditionQueryMemberLoginAsReferrerForeignOverTest {
            get {
                if (_conditionQueryMemberLoginAsReferrerForeignOverTest == null) {
                    _conditionQueryMemberLoginAsReferrerForeignOverTest = xcreateQueryMemberLoginAsReferrerForeignOverTest();
                    xsetupOuterJoin_MemberLoginAsReferrerForeignOverTest();
                }
                return _conditionQueryMemberLoginAsReferrerForeignOverTest;
            }
        }
        protected MemberLoginCQ xcreateQueryMemberLoginAsReferrerForeignOverTest() {
            String nrp = resolveNextRelationPathMemberLoginAsReferrerForeignOverTest();
            String jan = resolveJoinAliasName(nrp, xgetNextNestLevel());
            MemberLoginCQ cq = new MemberLoginCQ(this, xgetSqlClause(), jan, xgetNextNestLevel());
            cq.xsetForeignPropertyName("memberLoginAsReferrerForeignOverTest"); cq.xsetRelationPath(nrp); return cq;
        }
        public void xsetupOuterJoin_MemberLoginAsReferrerForeignOverTest() {
            MemberLoginCQ cq = ConditionQueryMemberLoginAsReferrerForeignOverTest;
            Map<String, String> joinOnMap = new LinkedHashMap<String, String>();
            joinOnMap.put("MEMBER_ID", "MEMBER_ID");
            registerOuterJoin(cq, joinOnMap, "$$foreignAlias$$.LOGIN_MEMBER_STATUS_CODE = $$over(PURCHASE.product.productStatus)$$.PRODUCT_STATUS_NAME");
        }
        protected String resolveNextRelationPathMemberLoginAsReferrerForeignOverTest() {
            return resolveNextRelationPath("member", "memberLoginAsReferrerForeignOverTest");
        }
        public bool hasConditionQueryMemberLoginAsReferrerForeignOverTest() {
            return _conditionQueryMemberLoginAsReferrerForeignOverTest != null;
        }


        protected MemberSecurityCQ _conditionQueryMemberSecurityAsOne;
        public MemberSecurityCQ ConditionQueryMemberSecurityAsOne {
            get {
                if (_conditionQueryMemberSecurityAsOne == null) {
                    _conditionQueryMemberSecurityAsOne = createQueryMemberSecurityAsOne();
                    xsetupOuterJoin_MemberSecurityAsOne();
                }
                return _conditionQueryMemberSecurityAsOne;
            }
        }
        public MemberSecurityCQ QueryMemberSecurityAsOne() { return this.ConditionQueryMemberSecurityAsOne; }
        protected MemberSecurityCQ createQueryMemberSecurityAsOne() {
            String nrp = resolveNextRelationPathMemberSecurityAsOne();
            String jan = resolveJoinAliasName(nrp, xgetNextNestLevel());
            MemberSecurityCQ cq = new MemberSecurityCQ(this, xgetSqlClause(), jan, xgetNextNestLevel());
            cq.xsetForeignPropertyName("memberSecurityAsOne"); cq.xsetRelationPath(nrp); return cq;
        }
        public void xsetupOuterJoin_MemberSecurityAsOne() {
            MemberSecurityCQ cq = ConditionQueryMemberSecurityAsOne;
            Map<String, String> joinOnMap = new LinkedHashMap<String, String>();
            joinOnMap.put("MEMBER_ID", "MEMBER_ID");
            registerOuterJoin(cq, joinOnMap);
        }
        protected String resolveNextRelationPathMemberSecurityAsOne() {
            return resolveNextRelationPath("member", "memberSecurityAsOne");
        }
        public bool hasConditionQueryMemberSecurityAsOne() {
            return _conditionQueryMemberSecurityAsOne != null;
        }

        protected MemberWithdrawalCQ _conditionQueryMemberWithdrawalAsOne;
        public MemberWithdrawalCQ ConditionQueryMemberWithdrawalAsOne {
            get {
                if (_conditionQueryMemberWithdrawalAsOne == null) {
                    _conditionQueryMemberWithdrawalAsOne = createQueryMemberWithdrawalAsOne();
                    xsetupOuterJoin_MemberWithdrawalAsOne();
                }
                return _conditionQueryMemberWithdrawalAsOne;
            }
        }
        public MemberWithdrawalCQ QueryMemberWithdrawalAsOne() { return this.ConditionQueryMemberWithdrawalAsOne; }
        protected MemberWithdrawalCQ createQueryMemberWithdrawalAsOne() {
            String nrp = resolveNextRelationPathMemberWithdrawalAsOne();
            String jan = resolveJoinAliasName(nrp, xgetNextNestLevel());
            MemberWithdrawalCQ cq = new MemberWithdrawalCQ(this, xgetSqlClause(), jan, xgetNextNestLevel());
            cq.xsetForeignPropertyName("memberWithdrawalAsOne"); cq.xsetRelationPath(nrp); return cq;
        }
        public void xsetupOuterJoin_MemberWithdrawalAsOne() {
            MemberWithdrawalCQ cq = ConditionQueryMemberWithdrawalAsOne;
            Map<String, String> joinOnMap = new LinkedHashMap<String, String>();
            joinOnMap.put("MEMBER_ID", "MEMBER_ID");
            registerOuterJoin(cq, joinOnMap);
        }
        protected String resolveNextRelationPathMemberWithdrawalAsOne() {
            return resolveNextRelationPath("member", "memberWithdrawalAsOne");
        }
        public bool hasConditionQueryMemberWithdrawalAsOne() {
            return _conditionQueryMemberWithdrawalAsOne != null;
        }

	    // ===============================================================================
	    //                                                                 Scalar SubQuery
	    //                                                                 ===============
	    protected Map<String, MemberCQ> _scalarSubQueryMap;
	    public Map<String, MemberCQ> ScalarSubQuery { get { return _scalarSubQueryMap; } }
	    public override String keepScalarSubQuery(MemberCQ subQuery) {
	        if (_scalarSubQueryMap == null) { _scalarSubQueryMap = new LinkedHashMap<String, MemberCQ>(); }
	        String key = "subQueryMapKey" + (_scalarSubQueryMap.size() + 1);
	        _scalarSubQueryMap.put(key, subQuery); return "ScalarSubQuery." + key;
	    }

        // ===============================================================================
        //                                                         Myself InScope SubQuery
        //                                                         =======================
        protected Map<String, MemberCQ> _myselfInScopeSubQueryMap;
        public Map<String, MemberCQ> MyselfInScopeSubQuery { get { return _myselfInScopeSubQueryMap; } }
        public override String keepMyselfInScopeSubQuery(MemberCQ subQuery) {
            if (_myselfInScopeSubQueryMap == null) { _myselfInScopeSubQueryMap = new LinkedHashMap<String, MemberCQ>(); }
            String key = "subQueryMapKey" + (_myselfInScopeSubQueryMap.size() + 1);
            _myselfInScopeSubQueryMap.put(key, subQuery); return "MyselfInScopeSubQuery." + key;
        }
    }
}
