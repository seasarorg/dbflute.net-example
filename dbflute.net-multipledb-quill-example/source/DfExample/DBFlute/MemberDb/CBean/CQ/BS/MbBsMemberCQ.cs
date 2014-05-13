
using System;

using DfExample.DBFlute.MemberDb.AllCommon.CBean;
using DfExample.DBFlute.MemberDb.AllCommon.CBean.CValue;
using DfExample.DBFlute.MemberDb.AllCommon.CBean.SClause;
using DfExample.DBFlute.MemberDb.AllCommon.JavaLike;
using DfExample.DBFlute.MemberDb.CBean.CQ;
using DfExample.DBFlute.MemberDb.CBean.CQ.Ciq;

namespace DfExample.DBFlute.MemberDb.CBean.CQ.BS {

    [System.Serializable]
    public class MbBsMemberCQ : MbAbstractBsMemberCQ {

        protected MbMemberCIQ _inlineQuery;

        public MbBsMemberCQ(MbConditionQuery childQuery, MbSqlClause sqlClause, String aliasName, int nestLevel)
            : base(childQuery, sqlClause, aliasName, nestLevel) {}

        public MbMemberCIQ Inline() {
            if (_inlineQuery == null) {
                _inlineQuery = new MbMemberCIQ(xgetReferrerQuery(), xgetSqlClause(), xgetAliasName(), xgetNestLevel(), this);
            }
            _inlineQuery.xsetOnClause(false);
            return _inlineQuery;
        }
        
        public MbMemberCIQ On() {
            if (isBaseQuery()) { throw new UnsupportedOperationException("Unsupported onClause of Base Table!"); }
            MbMemberCIQ inlineQuery = Inline();
            inlineQuery.xsetOnClause(true);
            return inlineQuery;
        }


        protected MbConditionValue _memberId;
        public MbConditionValue MemberId {
            get { if (_memberId == null) { _memberId = new MbConditionValue(); } return _memberId; }
        }
        protected override MbConditionValue getCValueMemberId() { return this.MemberId; }


        protected Map<String, MbMemberAddressCQ> _memberId_ExistsSubQuery_MemberAddressListMap;
        public Map<String, MbMemberAddressCQ> MemberId_ExistsSubQuery_MemberAddressList { get { return _memberId_ExistsSubQuery_MemberAddressListMap; }}
        public override String keepMemberId_ExistsSubQuery_MemberAddressList(MbMemberAddressCQ subQuery) {
            if (_memberId_ExistsSubQuery_MemberAddressListMap == null) { _memberId_ExistsSubQuery_MemberAddressListMap = new LinkedHashMap<String, MbMemberAddressCQ>(); }
            String key = "subQueryMapKey" + (_memberId_ExistsSubQuery_MemberAddressListMap.size() + 1);
            _memberId_ExistsSubQuery_MemberAddressListMap.put(key, subQuery); return "MemberId_ExistsSubQuery_MemberAddressList." + key;
        }

        protected Map<String, MbMemberLoginCQ> _memberId_ExistsSubQuery_MemberLoginListMap;
        public Map<String, MbMemberLoginCQ> MemberId_ExistsSubQuery_MemberLoginList { get { return _memberId_ExistsSubQuery_MemberLoginListMap; }}
        public override String keepMemberId_ExistsSubQuery_MemberLoginList(MbMemberLoginCQ subQuery) {
            if (_memberId_ExistsSubQuery_MemberLoginListMap == null) { _memberId_ExistsSubQuery_MemberLoginListMap = new LinkedHashMap<String, MbMemberLoginCQ>(); }
            String key = "subQueryMapKey" + (_memberId_ExistsSubQuery_MemberLoginListMap.size() + 1);
            _memberId_ExistsSubQuery_MemberLoginListMap.put(key, subQuery); return "MemberId_ExistsSubQuery_MemberLoginList." + key;
        }

        protected Map<String, MbMemberSecurityCQ> _memberId_ExistsSubQuery_MemberSecurityAsOneMap;
        public Map<String, MbMemberSecurityCQ> MemberId_ExistsSubQuery_MemberSecurityAsOne { get { return _memberId_ExistsSubQuery_MemberSecurityAsOneMap; }}
        public override String keepMemberId_ExistsSubQuery_MemberSecurityAsOne(MbMemberSecurityCQ subQuery) {
            if (_memberId_ExistsSubQuery_MemberSecurityAsOneMap == null) { _memberId_ExistsSubQuery_MemberSecurityAsOneMap = new LinkedHashMap<String, MbMemberSecurityCQ>(); }
            String key = "subQueryMapKey" + (_memberId_ExistsSubQuery_MemberSecurityAsOneMap.size() + 1);
            _memberId_ExistsSubQuery_MemberSecurityAsOneMap.put(key, subQuery); return "MemberId_ExistsSubQuery_MemberSecurityAsOne." + key;
        }

        protected Map<String, MbMemberWithdrawalCQ> _memberId_ExistsSubQuery_MemberWithdrawalAsOneMap;
        public Map<String, MbMemberWithdrawalCQ> MemberId_ExistsSubQuery_MemberWithdrawalAsOne { get { return _memberId_ExistsSubQuery_MemberWithdrawalAsOneMap; }}
        public override String keepMemberId_ExistsSubQuery_MemberWithdrawalAsOne(MbMemberWithdrawalCQ subQuery) {
            if (_memberId_ExistsSubQuery_MemberWithdrawalAsOneMap == null) { _memberId_ExistsSubQuery_MemberWithdrawalAsOneMap = new LinkedHashMap<String, MbMemberWithdrawalCQ>(); }
            String key = "subQueryMapKey" + (_memberId_ExistsSubQuery_MemberWithdrawalAsOneMap.size() + 1);
            _memberId_ExistsSubQuery_MemberWithdrawalAsOneMap.put(key, subQuery); return "MemberId_ExistsSubQuery_MemberWithdrawalAsOne." + key;
        }

        protected Map<String, MbPurchaseCQ> _memberId_ExistsSubQuery_PurchaseListMap;
        public Map<String, MbPurchaseCQ> MemberId_ExistsSubQuery_PurchaseList { get { return _memberId_ExistsSubQuery_PurchaseListMap; }}
        public override String keepMemberId_ExistsSubQuery_PurchaseList(MbPurchaseCQ subQuery) {
            if (_memberId_ExistsSubQuery_PurchaseListMap == null) { _memberId_ExistsSubQuery_PurchaseListMap = new LinkedHashMap<String, MbPurchaseCQ>(); }
            String key = "subQueryMapKey" + (_memberId_ExistsSubQuery_PurchaseListMap.size() + 1);
            _memberId_ExistsSubQuery_PurchaseListMap.put(key, subQuery); return "MemberId_ExistsSubQuery_PurchaseList." + key;
        }

        protected Map<String, MbMemberAddressCQ> _memberId_NotExistsSubQuery_MemberAddressListMap;
        public Map<String, MbMemberAddressCQ> MemberId_NotExistsSubQuery_MemberAddressList { get { return _memberId_NotExistsSubQuery_MemberAddressListMap; }}
        public override String keepMemberId_NotExistsSubQuery_MemberAddressList(MbMemberAddressCQ subQuery) {
            if (_memberId_NotExistsSubQuery_MemberAddressListMap == null) { _memberId_NotExistsSubQuery_MemberAddressListMap = new LinkedHashMap<String, MbMemberAddressCQ>(); }
            String key = "subQueryMapKey" + (_memberId_NotExistsSubQuery_MemberAddressListMap.size() + 1);
            _memberId_NotExistsSubQuery_MemberAddressListMap.put(key, subQuery); return "MemberId_NotExistsSubQuery_MemberAddressList." + key;
        }

        protected Map<String, MbMemberLoginCQ> _memberId_NotExistsSubQuery_MemberLoginListMap;
        public Map<String, MbMemberLoginCQ> MemberId_NotExistsSubQuery_MemberLoginList { get { return _memberId_NotExistsSubQuery_MemberLoginListMap; }}
        public override String keepMemberId_NotExistsSubQuery_MemberLoginList(MbMemberLoginCQ subQuery) {
            if (_memberId_NotExistsSubQuery_MemberLoginListMap == null) { _memberId_NotExistsSubQuery_MemberLoginListMap = new LinkedHashMap<String, MbMemberLoginCQ>(); }
            String key = "subQueryMapKey" + (_memberId_NotExistsSubQuery_MemberLoginListMap.size() + 1);
            _memberId_NotExistsSubQuery_MemberLoginListMap.put(key, subQuery); return "MemberId_NotExistsSubQuery_MemberLoginList." + key;
        }

        protected Map<String, MbMemberSecurityCQ> _memberId_NotExistsSubQuery_MemberSecurityAsOneMap;
        public Map<String, MbMemberSecurityCQ> MemberId_NotExistsSubQuery_MemberSecurityAsOne { get { return _memberId_NotExistsSubQuery_MemberSecurityAsOneMap; }}
        public override String keepMemberId_NotExistsSubQuery_MemberSecurityAsOne(MbMemberSecurityCQ subQuery) {
            if (_memberId_NotExistsSubQuery_MemberSecurityAsOneMap == null) { _memberId_NotExistsSubQuery_MemberSecurityAsOneMap = new LinkedHashMap<String, MbMemberSecurityCQ>(); }
            String key = "subQueryMapKey" + (_memberId_NotExistsSubQuery_MemberSecurityAsOneMap.size() + 1);
            _memberId_NotExistsSubQuery_MemberSecurityAsOneMap.put(key, subQuery); return "MemberId_NotExistsSubQuery_MemberSecurityAsOne." + key;
        }

        protected Map<String, MbMemberWithdrawalCQ> _memberId_NotExistsSubQuery_MemberWithdrawalAsOneMap;
        public Map<String, MbMemberWithdrawalCQ> MemberId_NotExistsSubQuery_MemberWithdrawalAsOne { get { return _memberId_NotExistsSubQuery_MemberWithdrawalAsOneMap; }}
        public override String keepMemberId_NotExistsSubQuery_MemberWithdrawalAsOne(MbMemberWithdrawalCQ subQuery) {
            if (_memberId_NotExistsSubQuery_MemberWithdrawalAsOneMap == null) { _memberId_NotExistsSubQuery_MemberWithdrawalAsOneMap = new LinkedHashMap<String, MbMemberWithdrawalCQ>(); }
            String key = "subQueryMapKey" + (_memberId_NotExistsSubQuery_MemberWithdrawalAsOneMap.size() + 1);
            _memberId_NotExistsSubQuery_MemberWithdrawalAsOneMap.put(key, subQuery); return "MemberId_NotExistsSubQuery_MemberWithdrawalAsOne." + key;
        }

        protected Map<String, MbPurchaseCQ> _memberId_NotExistsSubQuery_PurchaseListMap;
        public Map<String, MbPurchaseCQ> MemberId_NotExistsSubQuery_PurchaseList { get { return _memberId_NotExistsSubQuery_PurchaseListMap; }}
        public override String keepMemberId_NotExistsSubQuery_PurchaseList(MbPurchaseCQ subQuery) {
            if (_memberId_NotExistsSubQuery_PurchaseListMap == null) { _memberId_NotExistsSubQuery_PurchaseListMap = new LinkedHashMap<String, MbPurchaseCQ>(); }
            String key = "subQueryMapKey" + (_memberId_NotExistsSubQuery_PurchaseListMap.size() + 1);
            _memberId_NotExistsSubQuery_PurchaseListMap.put(key, subQuery); return "MemberId_NotExistsSubQuery_PurchaseList." + key;
        }

        protected Map<String, MbMemberAddressCQ> _memberId_InScopeSubQuery_MemberAddressListMap;
        public Map<String, MbMemberAddressCQ> MemberId_InScopeSubQuery_MemberAddressList { get { return _memberId_InScopeSubQuery_MemberAddressListMap; }}
        public override String keepMemberId_InScopeSubQuery_MemberAddressList(MbMemberAddressCQ subQuery) {
            if (_memberId_InScopeSubQuery_MemberAddressListMap == null) { _memberId_InScopeSubQuery_MemberAddressListMap = new LinkedHashMap<String, MbMemberAddressCQ>(); }
            String key = "subQueryMapKey" + (_memberId_InScopeSubQuery_MemberAddressListMap.size() + 1);
            _memberId_InScopeSubQuery_MemberAddressListMap.put(key, subQuery); return "MemberId_InScopeSubQuery_MemberAddressList." + key;
        }

        protected Map<String, MbMemberLoginCQ> _memberId_InScopeSubQuery_MemberLoginListMap;
        public Map<String, MbMemberLoginCQ> MemberId_InScopeSubQuery_MemberLoginList { get { return _memberId_InScopeSubQuery_MemberLoginListMap; }}
        public override String keepMemberId_InScopeSubQuery_MemberLoginList(MbMemberLoginCQ subQuery) {
            if (_memberId_InScopeSubQuery_MemberLoginListMap == null) { _memberId_InScopeSubQuery_MemberLoginListMap = new LinkedHashMap<String, MbMemberLoginCQ>(); }
            String key = "subQueryMapKey" + (_memberId_InScopeSubQuery_MemberLoginListMap.size() + 1);
            _memberId_InScopeSubQuery_MemberLoginListMap.put(key, subQuery); return "MemberId_InScopeSubQuery_MemberLoginList." + key;
        }

        protected Map<String, MbMemberSecurityCQ> _memberId_InScopeSubQuery_MemberSecurityAsOneMap;
        public Map<String, MbMemberSecurityCQ> MemberId_InScopeSubQuery_MemberSecurityAsOne { get { return _memberId_InScopeSubQuery_MemberSecurityAsOneMap; }}
        public override String keepMemberId_InScopeSubQuery_MemberSecurityAsOne(MbMemberSecurityCQ subQuery) {
            if (_memberId_InScopeSubQuery_MemberSecurityAsOneMap == null) { _memberId_InScopeSubQuery_MemberSecurityAsOneMap = new LinkedHashMap<String, MbMemberSecurityCQ>(); }
            String key = "subQueryMapKey" + (_memberId_InScopeSubQuery_MemberSecurityAsOneMap.size() + 1);
            _memberId_InScopeSubQuery_MemberSecurityAsOneMap.put(key, subQuery); return "MemberId_InScopeSubQuery_MemberSecurityAsOne." + key;
        }

        protected Map<String, MbMemberWithdrawalCQ> _memberId_InScopeSubQuery_MemberWithdrawalAsOneMap;
        public Map<String, MbMemberWithdrawalCQ> MemberId_InScopeSubQuery_MemberWithdrawalAsOne { get { return _memberId_InScopeSubQuery_MemberWithdrawalAsOneMap; }}
        public override String keepMemberId_InScopeSubQuery_MemberWithdrawalAsOne(MbMemberWithdrawalCQ subQuery) {
            if (_memberId_InScopeSubQuery_MemberWithdrawalAsOneMap == null) { _memberId_InScopeSubQuery_MemberWithdrawalAsOneMap = new LinkedHashMap<String, MbMemberWithdrawalCQ>(); }
            String key = "subQueryMapKey" + (_memberId_InScopeSubQuery_MemberWithdrawalAsOneMap.size() + 1);
            _memberId_InScopeSubQuery_MemberWithdrawalAsOneMap.put(key, subQuery); return "MemberId_InScopeSubQuery_MemberWithdrawalAsOne." + key;
        }

        protected Map<String, MbPurchaseCQ> _memberId_InScopeSubQuery_PurchaseListMap;
        public Map<String, MbPurchaseCQ> MemberId_InScopeSubQuery_PurchaseList { get { return _memberId_InScopeSubQuery_PurchaseListMap; }}
        public override String keepMemberId_InScopeSubQuery_PurchaseList(MbPurchaseCQ subQuery) {
            if (_memberId_InScopeSubQuery_PurchaseListMap == null) { _memberId_InScopeSubQuery_PurchaseListMap = new LinkedHashMap<String, MbPurchaseCQ>(); }
            String key = "subQueryMapKey" + (_memberId_InScopeSubQuery_PurchaseListMap.size() + 1);
            _memberId_InScopeSubQuery_PurchaseListMap.put(key, subQuery); return "MemberId_InScopeSubQuery_PurchaseList." + key;
        }

        protected Map<String, MbMemberAddressCQ> _memberId_NotInScopeSubQuery_MemberAddressListMap;
        public Map<String, MbMemberAddressCQ> MemberId_NotInScopeSubQuery_MemberAddressList { get { return _memberId_NotInScopeSubQuery_MemberAddressListMap; }}
        public override String keepMemberId_NotInScopeSubQuery_MemberAddressList(MbMemberAddressCQ subQuery) {
            if (_memberId_NotInScopeSubQuery_MemberAddressListMap == null) { _memberId_NotInScopeSubQuery_MemberAddressListMap = new LinkedHashMap<String, MbMemberAddressCQ>(); }
            String key = "subQueryMapKey" + (_memberId_NotInScopeSubQuery_MemberAddressListMap.size() + 1);
            _memberId_NotInScopeSubQuery_MemberAddressListMap.put(key, subQuery); return "MemberId_NotInScopeSubQuery_MemberAddressList." + key;
        }

        protected Map<String, MbMemberLoginCQ> _memberId_NotInScopeSubQuery_MemberLoginListMap;
        public Map<String, MbMemberLoginCQ> MemberId_NotInScopeSubQuery_MemberLoginList { get { return _memberId_NotInScopeSubQuery_MemberLoginListMap; }}
        public override String keepMemberId_NotInScopeSubQuery_MemberLoginList(MbMemberLoginCQ subQuery) {
            if (_memberId_NotInScopeSubQuery_MemberLoginListMap == null) { _memberId_NotInScopeSubQuery_MemberLoginListMap = new LinkedHashMap<String, MbMemberLoginCQ>(); }
            String key = "subQueryMapKey" + (_memberId_NotInScopeSubQuery_MemberLoginListMap.size() + 1);
            _memberId_NotInScopeSubQuery_MemberLoginListMap.put(key, subQuery); return "MemberId_NotInScopeSubQuery_MemberLoginList." + key;
        }

        protected Map<String, MbMemberSecurityCQ> _memberId_NotInScopeSubQuery_MemberSecurityAsOneMap;
        public Map<String, MbMemberSecurityCQ> MemberId_NotInScopeSubQuery_MemberSecurityAsOne { get { return _memberId_NotInScopeSubQuery_MemberSecurityAsOneMap; }}
        public override String keepMemberId_NotInScopeSubQuery_MemberSecurityAsOne(MbMemberSecurityCQ subQuery) {
            if (_memberId_NotInScopeSubQuery_MemberSecurityAsOneMap == null) { _memberId_NotInScopeSubQuery_MemberSecurityAsOneMap = new LinkedHashMap<String, MbMemberSecurityCQ>(); }
            String key = "subQueryMapKey" + (_memberId_NotInScopeSubQuery_MemberSecurityAsOneMap.size() + 1);
            _memberId_NotInScopeSubQuery_MemberSecurityAsOneMap.put(key, subQuery); return "MemberId_NotInScopeSubQuery_MemberSecurityAsOne." + key;
        }

        protected Map<String, MbMemberWithdrawalCQ> _memberId_NotInScopeSubQuery_MemberWithdrawalAsOneMap;
        public Map<String, MbMemberWithdrawalCQ> MemberId_NotInScopeSubQuery_MemberWithdrawalAsOne { get { return _memberId_NotInScopeSubQuery_MemberWithdrawalAsOneMap; }}
        public override String keepMemberId_NotInScopeSubQuery_MemberWithdrawalAsOne(MbMemberWithdrawalCQ subQuery) {
            if (_memberId_NotInScopeSubQuery_MemberWithdrawalAsOneMap == null) { _memberId_NotInScopeSubQuery_MemberWithdrawalAsOneMap = new LinkedHashMap<String, MbMemberWithdrawalCQ>(); }
            String key = "subQueryMapKey" + (_memberId_NotInScopeSubQuery_MemberWithdrawalAsOneMap.size() + 1);
            _memberId_NotInScopeSubQuery_MemberWithdrawalAsOneMap.put(key, subQuery); return "MemberId_NotInScopeSubQuery_MemberWithdrawalAsOne." + key;
        }

        protected Map<String, MbPurchaseCQ> _memberId_NotInScopeSubQuery_PurchaseListMap;
        public Map<String, MbPurchaseCQ> MemberId_NotInScopeSubQuery_PurchaseList { get { return _memberId_NotInScopeSubQuery_PurchaseListMap; }}
        public override String keepMemberId_NotInScopeSubQuery_PurchaseList(MbPurchaseCQ subQuery) {
            if (_memberId_NotInScopeSubQuery_PurchaseListMap == null) { _memberId_NotInScopeSubQuery_PurchaseListMap = new LinkedHashMap<String, MbPurchaseCQ>(); }
            String key = "subQueryMapKey" + (_memberId_NotInScopeSubQuery_PurchaseListMap.size() + 1);
            _memberId_NotInScopeSubQuery_PurchaseListMap.put(key, subQuery); return "MemberId_NotInScopeSubQuery_PurchaseList." + key;
        }

        protected Map<String, MbMemberAddressCQ> _memberId_SpecifyDerivedReferrer_MemberAddressListMap;
        public Map<String, MbMemberAddressCQ> MemberId_SpecifyDerivedReferrer_MemberAddressList { get { return _memberId_SpecifyDerivedReferrer_MemberAddressListMap; }}
        public override String keepMemberId_SpecifyDerivedReferrer_MemberAddressList(MbMemberAddressCQ subQuery) {
            if (_memberId_SpecifyDerivedReferrer_MemberAddressListMap == null) { _memberId_SpecifyDerivedReferrer_MemberAddressListMap = new LinkedHashMap<String, MbMemberAddressCQ>(); }
            String key = "subQueryMapKey" + (_memberId_SpecifyDerivedReferrer_MemberAddressListMap.size() + 1);
            _memberId_SpecifyDerivedReferrer_MemberAddressListMap.put(key, subQuery); return "MemberId_SpecifyDerivedReferrer_MemberAddressList." + key;
        }

        protected Map<String, MbMemberLoginCQ> _memberId_SpecifyDerivedReferrer_MemberLoginListMap;
        public Map<String, MbMemberLoginCQ> MemberId_SpecifyDerivedReferrer_MemberLoginList { get { return _memberId_SpecifyDerivedReferrer_MemberLoginListMap; }}
        public override String keepMemberId_SpecifyDerivedReferrer_MemberLoginList(MbMemberLoginCQ subQuery) {
            if (_memberId_SpecifyDerivedReferrer_MemberLoginListMap == null) { _memberId_SpecifyDerivedReferrer_MemberLoginListMap = new LinkedHashMap<String, MbMemberLoginCQ>(); }
            String key = "subQueryMapKey" + (_memberId_SpecifyDerivedReferrer_MemberLoginListMap.size() + 1);
            _memberId_SpecifyDerivedReferrer_MemberLoginListMap.put(key, subQuery); return "MemberId_SpecifyDerivedReferrer_MemberLoginList." + key;
        }

        protected Map<String, MbPurchaseCQ> _memberId_SpecifyDerivedReferrer_PurchaseListMap;
        public Map<String, MbPurchaseCQ> MemberId_SpecifyDerivedReferrer_PurchaseList { get { return _memberId_SpecifyDerivedReferrer_PurchaseListMap; }}
        public override String keepMemberId_SpecifyDerivedReferrer_PurchaseList(MbPurchaseCQ subQuery) {
            if (_memberId_SpecifyDerivedReferrer_PurchaseListMap == null) { _memberId_SpecifyDerivedReferrer_PurchaseListMap = new LinkedHashMap<String, MbPurchaseCQ>(); }
            String key = "subQueryMapKey" + (_memberId_SpecifyDerivedReferrer_PurchaseListMap.size() + 1);
            _memberId_SpecifyDerivedReferrer_PurchaseListMap.put(key, subQuery); return "MemberId_SpecifyDerivedReferrer_PurchaseList." + key;
        }

        protected Map<String, MbMemberAddressCQ> _memberId_QueryDerivedReferrer_MemberAddressListMap;
        public Map<String, MbMemberAddressCQ> MemberId_QueryDerivedReferrer_MemberAddressList { get { return _memberId_QueryDerivedReferrer_MemberAddressListMap; } }
        public override String keepMemberId_QueryDerivedReferrer_MemberAddressList(MbMemberAddressCQ subQuery) {
            if (_memberId_QueryDerivedReferrer_MemberAddressListMap == null) { _memberId_QueryDerivedReferrer_MemberAddressListMap = new LinkedHashMap<String, MbMemberAddressCQ>(); }
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

        protected Map<String, MbMemberLoginCQ> _memberId_QueryDerivedReferrer_MemberLoginListMap;
        public Map<String, MbMemberLoginCQ> MemberId_QueryDerivedReferrer_MemberLoginList { get { return _memberId_QueryDerivedReferrer_MemberLoginListMap; } }
        public override String keepMemberId_QueryDerivedReferrer_MemberLoginList(MbMemberLoginCQ subQuery) {
            if (_memberId_QueryDerivedReferrer_MemberLoginListMap == null) { _memberId_QueryDerivedReferrer_MemberLoginListMap = new LinkedHashMap<String, MbMemberLoginCQ>(); }
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

        protected Map<String, MbPurchaseCQ> _memberId_QueryDerivedReferrer_PurchaseListMap;
        public Map<String, MbPurchaseCQ> MemberId_QueryDerivedReferrer_PurchaseList { get { return _memberId_QueryDerivedReferrer_PurchaseListMap; } }
        public override String keepMemberId_QueryDerivedReferrer_PurchaseList(MbPurchaseCQ subQuery) {
            if (_memberId_QueryDerivedReferrer_PurchaseListMap == null) { _memberId_QueryDerivedReferrer_PurchaseListMap = new LinkedHashMap<String, MbPurchaseCQ>(); }
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

        public MbBsMemberCQ AddOrderBy_MemberId_Asc() { regOBA("MEMBER_ID");return this; }
        public MbBsMemberCQ AddOrderBy_MemberId_Desc() { regOBD("MEMBER_ID");return this; }

        protected MbConditionValue _memberName;
        public MbConditionValue MemberName {
            get { if (_memberName == null) { _memberName = new MbConditionValue(); } return _memberName; }
        }
        protected override MbConditionValue getCValueMemberName() { return this.MemberName; }


        public MbBsMemberCQ AddOrderBy_MemberName_Asc() { regOBA("MEMBER_NAME");return this; }
        public MbBsMemberCQ AddOrderBy_MemberName_Desc() { regOBD("MEMBER_NAME");return this; }

        protected MbConditionValue _memberAccount;
        public MbConditionValue MemberAccount {
            get { if (_memberAccount == null) { _memberAccount = new MbConditionValue(); } return _memberAccount; }
        }
        protected override MbConditionValue getCValueMemberAccount() { return this.MemberAccount; }


        public MbBsMemberCQ AddOrderBy_MemberAccount_Asc() { regOBA("MEMBER_ACCOUNT");return this; }
        public MbBsMemberCQ AddOrderBy_MemberAccount_Desc() { regOBD("MEMBER_ACCOUNT");return this; }

        protected MbConditionValue _memberStatusCode;
        public MbConditionValue MemberStatusCode {
            get { if (_memberStatusCode == null) { _memberStatusCode = new MbConditionValue(); } return _memberStatusCode; }
        }
        protected override MbConditionValue getCValueMemberStatusCode() { return this.MemberStatusCode; }


        protected Map<String, MbMemberStatusCQ> _memberStatusCode_InScopeSubQuery_MemberStatusMap;
        public Map<String, MbMemberStatusCQ> MemberStatusCode_InScopeSubQuery_MemberStatus { get { return _memberStatusCode_InScopeSubQuery_MemberStatusMap; }}
        public override String keepMemberStatusCode_InScopeSubQuery_MemberStatus(MbMemberStatusCQ subQuery) {
            if (_memberStatusCode_InScopeSubQuery_MemberStatusMap == null) { _memberStatusCode_InScopeSubQuery_MemberStatusMap = new LinkedHashMap<String, MbMemberStatusCQ>(); }
            String key = "subQueryMapKey" + (_memberStatusCode_InScopeSubQuery_MemberStatusMap.size() + 1);
            _memberStatusCode_InScopeSubQuery_MemberStatusMap.put(key, subQuery); return "MemberStatusCode_InScopeSubQuery_MemberStatus." + key;
        }

        protected Map<String, MbMemberStatusCQ> _memberStatusCode_NotInScopeSubQuery_MemberStatusMap;
        public Map<String, MbMemberStatusCQ> MemberStatusCode_NotInScopeSubQuery_MemberStatus { get { return _memberStatusCode_NotInScopeSubQuery_MemberStatusMap; }}
        public override String keepMemberStatusCode_NotInScopeSubQuery_MemberStatus(MbMemberStatusCQ subQuery) {
            if (_memberStatusCode_NotInScopeSubQuery_MemberStatusMap == null) { _memberStatusCode_NotInScopeSubQuery_MemberStatusMap = new LinkedHashMap<String, MbMemberStatusCQ>(); }
            String key = "subQueryMapKey" + (_memberStatusCode_NotInScopeSubQuery_MemberStatusMap.size() + 1);
            _memberStatusCode_NotInScopeSubQuery_MemberStatusMap.put(key, subQuery); return "MemberStatusCode_NotInScopeSubQuery_MemberStatus." + key;
        }

        public MbBsMemberCQ AddOrderBy_MemberStatusCode_Asc() { regOBA("MEMBER_STATUS_CODE");return this; }
        public MbBsMemberCQ AddOrderBy_MemberStatusCode_Desc() { regOBD("MEMBER_STATUS_CODE");return this; }

        protected MbConditionValue _formalizedDatetime;
        public MbConditionValue FormalizedDatetime {
            get { if (_formalizedDatetime == null) { _formalizedDatetime = new MbConditionValue(); } return _formalizedDatetime; }
        }
        protected override MbConditionValue getCValueFormalizedDatetime() { return this.FormalizedDatetime; }


        public MbBsMemberCQ AddOrderBy_FormalizedDatetime_Asc() { regOBA("FORMALIZED_DATETIME");return this; }
        public MbBsMemberCQ AddOrderBy_FormalizedDatetime_Desc() { regOBD("FORMALIZED_DATETIME");return this; }

        protected MbConditionValue _birthdate;
        public MbConditionValue Birthdate {
            get { if (_birthdate == null) { _birthdate = new MbConditionValue(); } return _birthdate; }
        }
        protected override MbConditionValue getCValueBirthdate() { return this.Birthdate; }


        public MbBsMemberCQ AddOrderBy_Birthdate_Asc() { regOBA("BIRTHDATE");return this; }
        public MbBsMemberCQ AddOrderBy_Birthdate_Desc() { regOBD("BIRTHDATE");return this; }

        protected MbConditionValue _registerDatetime;
        public MbConditionValue RegisterDatetime {
            get { if (_registerDatetime == null) { _registerDatetime = new MbConditionValue(); } return _registerDatetime; }
        }
        protected override MbConditionValue getCValueRegisterDatetime() { return this.RegisterDatetime; }


        public MbBsMemberCQ AddOrderBy_RegisterDatetime_Asc() { regOBA("REGISTER_DATETIME");return this; }
        public MbBsMemberCQ AddOrderBy_RegisterDatetime_Desc() { regOBD("REGISTER_DATETIME");return this; }

        protected MbConditionValue _registerUser;
        public MbConditionValue RegisterUser {
            get { if (_registerUser == null) { _registerUser = new MbConditionValue(); } return _registerUser; }
        }
        protected override MbConditionValue getCValueRegisterUser() { return this.RegisterUser; }


        public MbBsMemberCQ AddOrderBy_RegisterUser_Asc() { regOBA("REGISTER_USER");return this; }
        public MbBsMemberCQ AddOrderBy_RegisterUser_Desc() { regOBD("REGISTER_USER");return this; }

        protected MbConditionValue _registerProcess;
        public MbConditionValue RegisterProcess {
            get { if (_registerProcess == null) { _registerProcess = new MbConditionValue(); } return _registerProcess; }
        }
        protected override MbConditionValue getCValueRegisterProcess() { return this.RegisterProcess; }


        public MbBsMemberCQ AddOrderBy_RegisterProcess_Asc() { regOBA("REGISTER_PROCESS");return this; }
        public MbBsMemberCQ AddOrderBy_RegisterProcess_Desc() { regOBD("REGISTER_PROCESS");return this; }

        protected MbConditionValue _updateDatetime;
        public MbConditionValue UpdateDatetime {
            get { if (_updateDatetime == null) { _updateDatetime = new MbConditionValue(); } return _updateDatetime; }
        }
        protected override MbConditionValue getCValueUpdateDatetime() { return this.UpdateDatetime; }


        public MbBsMemberCQ AddOrderBy_UpdateDatetime_Asc() { regOBA("UPDATE_DATETIME");return this; }
        public MbBsMemberCQ AddOrderBy_UpdateDatetime_Desc() { regOBD("UPDATE_DATETIME");return this; }

        protected MbConditionValue _updateUser;
        public MbConditionValue UpdateUser {
            get { if (_updateUser == null) { _updateUser = new MbConditionValue(); } return _updateUser; }
        }
        protected override MbConditionValue getCValueUpdateUser() { return this.UpdateUser; }


        public MbBsMemberCQ AddOrderBy_UpdateUser_Asc() { regOBA("UPDATE_USER");return this; }
        public MbBsMemberCQ AddOrderBy_UpdateUser_Desc() { regOBD("UPDATE_USER");return this; }

        protected MbConditionValue _updateProcess;
        public MbConditionValue UpdateProcess {
            get { if (_updateProcess == null) { _updateProcess = new MbConditionValue(); } return _updateProcess; }
        }
        protected override MbConditionValue getCValueUpdateProcess() { return this.UpdateProcess; }


        public MbBsMemberCQ AddOrderBy_UpdateProcess_Asc() { regOBA("UPDATE_PROCESS");return this; }
        public MbBsMemberCQ AddOrderBy_UpdateProcess_Desc() { regOBD("UPDATE_PROCESS");return this; }

        protected MbConditionValue _versionNo;
        public MbConditionValue VersionNo {
            get { if (_versionNo == null) { _versionNo = new MbConditionValue(); } return _versionNo; }
        }
        protected override MbConditionValue getCValueVersionNo() { return this.VersionNo; }


        public MbBsMemberCQ AddOrderBy_VersionNo_Asc() { regOBA("VERSION_NO");return this; }
        public MbBsMemberCQ AddOrderBy_VersionNo_Desc() { regOBD("VERSION_NO");return this; }

        public MbBsMemberCQ AddSpecifiedDerivedOrderBy_Asc(String aliasName) { registerSpecifiedDerivedOrderBy_Asc(aliasName); return this; }
        public MbBsMemberCQ AddSpecifiedDerivedOrderBy_Desc(String aliasName) { registerSpecifiedDerivedOrderBy_Desc(aliasName); return this; }

        public override void reflectRelationOnUnionQuery(MbConditionQuery baseQueryAsSuper, MbConditionQuery unionQueryAsSuper) {
            MbMemberCQ baseQuery = (MbMemberCQ)baseQueryAsSuper;
            MbMemberCQ unionQuery = (MbMemberCQ)unionQueryAsSuper;
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
            if (baseQuery.hasConditionQueryMemberSecurityAsOne()) {
                unionQuery.QueryMemberSecurityAsOne().reflectRelationOnUnionQuery(baseQuery.QueryMemberSecurityAsOne(), unionQuery.QueryMemberSecurityAsOne());
            }
            if (baseQuery.hasConditionQueryMemberWithdrawalAsOne()) {
                unionQuery.QueryMemberWithdrawalAsOne().reflectRelationOnUnionQuery(baseQuery.QueryMemberWithdrawalAsOne(), unionQuery.QueryMemberWithdrawalAsOne());
            }

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
            joinOnMap.put("MEMBER_STATUS_CODE", "MEMBER_STATUS_CODE");
            registerOuterJoin(cq, joinOnMap);
        }
        protected String resolveNextRelationPathMemberStatus() {
            return resolveNextRelationPath("member", "memberStatus");
        }
        public bool hasConditionQueryMemberStatus() {
            return _conditionQueryMemberStatus != null;
        }
        protected MbMemberLoginCQ _conditionQueryMemberLoginAsLatest;
        public MbMemberLoginCQ QueryMemberLoginAsLatest() {
            return this.ConditionQueryMemberLoginAsLatest;
        }
        public MbMemberLoginCQ ConditionQueryMemberLoginAsLatest {
            get {
                if (_conditionQueryMemberLoginAsLatest == null) {
                    _conditionQueryMemberLoginAsLatest = xcreateQueryMemberLoginAsLatest();
                    xsetupOuterJoin_MemberLoginAsLatest();
                }
                return _conditionQueryMemberLoginAsLatest;
            }
        }
        protected MbMemberLoginCQ xcreateQueryMemberLoginAsLatest() {
            String nrp = resolveNextRelationPathMemberLoginAsLatest();
            String jan = resolveJoinAliasName(nrp, xgetNextNestLevel());
            MbMemberLoginCQ cq = new MbMemberLoginCQ(this, xgetSqlClause(), jan, xgetNextNestLevel());
            cq.xsetForeignPropertyName("memberLoginAsLatest"); cq.xsetRelationPath(nrp); return cq;
        }
        public void xsetupOuterJoin_MemberLoginAsLatest() {
            MbMemberLoginCQ cq = ConditionQueryMemberLoginAsLatest;
            Map<String, String> joinOnMap = new LinkedHashMap<String, String>();
            joinOnMap.put("MEMBER_ID", "MEMBER_ID");
            registerOuterJoin(cq, joinOnMap, "$$foreignAlias$$.LOGIN_DATETIME = (select max(LOGIN_DATETIME) from MEMBER_LOGIN where MEMBER_ID = $$localAlias$$.MEMBER_ID)");
        }
        protected String resolveNextRelationPathMemberLoginAsLatest() {
            return resolveNextRelationPath("member", "memberLoginAsLatest");
        }
        public bool hasConditionQueryMemberLoginAsLatest() {
            return _conditionQueryMemberLoginAsLatest != null;
        }
        protected MbMemberAddressCQ _conditionQueryMemberAddressAsValid;
        public MbMemberAddressCQ QueryMemberAddressAsValid(DateTime targetDate) {
            Map<String, Object> parameterMap = parameterMapMemberAddressAsValid;
            parameterMap.put("targetDate", targetDate);
            return this.ConditionQueryMemberAddressAsValid;
        }
        public MbMemberAddressCQ ConditionQueryMemberAddressAsValid {
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
        protected MbMemberAddressCQ xcreateQueryMemberAddressAsValid() {
            String nrp = resolveNextRelationPathMemberAddressAsValid();
            String jan = resolveJoinAliasName(nrp, xgetNextNestLevel());
            MbMemberAddressCQ cq = new MbMemberAddressCQ(this, xgetSqlClause(), jan, xgetNextNestLevel());
            cq.xsetForeignPropertyName("memberAddressAsValid"); cq.xsetRelationPath(nrp); return cq;
        }
        public void xsetupOuterJoin_MemberAddressAsValid() {
            MbMemberAddressCQ cq = ConditionQueryMemberAddressAsValid;
            Map<String, String> joinOnMap = new LinkedHashMap<String, String>();
            joinOnMap.put("MEMBER_ID", "MEMBER_ID");
            registerOuterJoin(cq, joinOnMap, "$$foreignAlias$$.VALID_BEGIN_DATE <= /*$$locationBase$$.parameterMapMemberAddressAsValid.targetDate*/null\n     and $$foreignAlias$$.VALID_END_DATE >= /*$$locationBase$$.parameterMapMemberAddressAsValid.targetDate*/null");
        }
        protected String resolveNextRelationPathMemberAddressAsValid() {
            return resolveNextRelationPath("member", "memberAddressAsValid");
        }
        public bool hasConditionQueryMemberAddressAsValid() {
            return _conditionQueryMemberAddressAsValid != null;
        }


        protected MbMemberSecurityCQ _conditionQueryMemberSecurityAsOne;
        public MbMemberSecurityCQ ConditionQueryMemberSecurityAsOne {
            get {
                if (_conditionQueryMemberSecurityAsOne == null) {
                    _conditionQueryMemberSecurityAsOne = createQueryMemberSecurityAsOne();
                    xsetupOuterJoin_MemberSecurityAsOne();
                }
                return _conditionQueryMemberSecurityAsOne;
            }
        }
        public MbMemberSecurityCQ QueryMemberSecurityAsOne() { return this.ConditionQueryMemberSecurityAsOne; }
        protected MbMemberSecurityCQ createQueryMemberSecurityAsOne() {
            String nrp = resolveNextRelationPathMemberSecurityAsOne();
            String jan = resolveJoinAliasName(nrp, xgetNextNestLevel());
            MbMemberSecurityCQ cq = new MbMemberSecurityCQ(this, xgetSqlClause(), jan, xgetNextNestLevel());
            cq.xsetForeignPropertyName("memberSecurityAsOne"); cq.xsetRelationPath(nrp); return cq;
        }
        public void xsetupOuterJoin_MemberSecurityAsOne() {
            MbMemberSecurityCQ cq = ConditionQueryMemberSecurityAsOne;
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

        protected MbMemberWithdrawalCQ _conditionQueryMemberWithdrawalAsOne;
        public MbMemberWithdrawalCQ ConditionQueryMemberWithdrawalAsOne {
            get {
                if (_conditionQueryMemberWithdrawalAsOne == null) {
                    _conditionQueryMemberWithdrawalAsOne = createQueryMemberWithdrawalAsOne();
                    xsetupOuterJoin_MemberWithdrawalAsOne();
                }
                return _conditionQueryMemberWithdrawalAsOne;
            }
        }
        public MbMemberWithdrawalCQ QueryMemberWithdrawalAsOne() { return this.ConditionQueryMemberWithdrawalAsOne; }
        protected MbMemberWithdrawalCQ createQueryMemberWithdrawalAsOne() {
            String nrp = resolveNextRelationPathMemberWithdrawalAsOne();
            String jan = resolveJoinAliasName(nrp, xgetNextNestLevel());
            MbMemberWithdrawalCQ cq = new MbMemberWithdrawalCQ(this, xgetSqlClause(), jan, xgetNextNestLevel());
            cq.xsetForeignPropertyName("memberWithdrawalAsOne"); cq.xsetRelationPath(nrp); return cq;
        }
        public void xsetupOuterJoin_MemberWithdrawalAsOne() {
            MbMemberWithdrawalCQ cq = ConditionQueryMemberWithdrawalAsOne;
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
	    protected Map<String, MbMemberCQ> _scalarSubQueryMap;
	    public Map<String, MbMemberCQ> ScalarSubQuery { get { return _scalarSubQueryMap; } }
	    public override String keepScalarSubQuery(MbMemberCQ subQuery) {
	        if (_scalarSubQueryMap == null) { _scalarSubQueryMap = new LinkedHashMap<String, MbMemberCQ>(); }
	        String key = "subQueryMapKey" + (_scalarSubQueryMap.size() + 1);
	        _scalarSubQueryMap.put(key, subQuery); return "ScalarSubQuery." + key;
	    }

        // ===============================================================================
        //                                                         Myself InScope SubQuery
        //                                                         =======================
        protected Map<String, MbMemberCQ> _myselfInScopeSubQueryMap;
        public Map<String, MbMemberCQ> MyselfInScopeSubQuery { get { return _myselfInScopeSubQueryMap; } }
        public override String keepMyselfInScopeSubQuery(MbMemberCQ subQuery) {
            if (_myselfInScopeSubQueryMap == null) { _myselfInScopeSubQueryMap = new LinkedHashMap<String, MbMemberCQ>(); }
            String key = "subQueryMapKey" + (_myselfInScopeSubQueryMap.size() + 1);
            _myselfInScopeSubQueryMap.put(key, subQuery); return "MyselfInScopeSubQuery." + key;
        }
    }
}
