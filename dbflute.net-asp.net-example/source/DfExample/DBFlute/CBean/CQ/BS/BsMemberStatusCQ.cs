
using System;

using DfExample.DBFlute.AllCommon.CBean;
using DfExample.DBFlute.AllCommon.CBean.CValue;
using DfExample.DBFlute.AllCommon.CBean.SClause;
using DfExample.DBFlute.AllCommon.JavaLike;
using DfExample.DBFlute.CBean.CQ;
using DfExample.DBFlute.CBean.CQ.Ciq;

namespace DfExample.DBFlute.CBean.CQ.BS {

    [System.Serializable]
    public class BsMemberStatusCQ : AbstractBsMemberStatusCQ {

        protected MemberStatusCIQ _inlineQuery;

        public BsMemberStatusCQ(ConditionQuery childQuery, SqlClause sqlClause, String aliasName, int nestLevel)
            : base(childQuery, sqlClause, aliasName, nestLevel) {}

        public MemberStatusCIQ Inline() {
            if (_inlineQuery == null) {
                _inlineQuery = new MemberStatusCIQ(xgetReferrerQuery(), xgetSqlClause(), xgetAliasName(), xgetNestLevel(), this);
            }
            _inlineQuery.xsetOnClause(false);
            return _inlineQuery;
        }
        
        public MemberStatusCIQ On() {
            if (isBaseQuery()) { throw new UnsupportedOperationException("Unsupported onClause of Base Table!"); }
            MemberStatusCIQ inlineQuery = Inline();
            inlineQuery.xsetOnClause(true);
            return inlineQuery;
        }


        protected ConditionValue _memberStatusCode;
        public ConditionValue MemberStatusCode {
            get { if (_memberStatusCode == null) { _memberStatusCode = new ConditionValue(); } return _memberStatusCode; }
        }
        protected override ConditionValue getCValueMemberStatusCode() { return this.MemberStatusCode; }


        protected Map<String, MemberCQ> _memberStatusCode_ExistsSubQuery_MemberListMap;
        public Map<String, MemberCQ> MemberStatusCode_ExistsSubQuery_MemberList { get { return _memberStatusCode_ExistsSubQuery_MemberListMap; }}
        public override String keepMemberStatusCode_ExistsSubQuery_MemberList(MemberCQ subQuery) {
            if (_memberStatusCode_ExistsSubQuery_MemberListMap == null) { _memberStatusCode_ExistsSubQuery_MemberListMap = new LinkedHashMap<String, MemberCQ>(); }
            String key = "subQueryMapKey" + (_memberStatusCode_ExistsSubQuery_MemberListMap.size() + 1);
            _memberStatusCode_ExistsSubQuery_MemberListMap.put(key, subQuery); return "MemberStatusCode_ExistsSubQuery_MemberList." + key;
        }

        protected Map<String, MemberLoginCQ> _memberStatusCode_ExistsSubQuery_MemberLoginListMap;
        public Map<String, MemberLoginCQ> MemberStatusCode_ExistsSubQuery_MemberLoginList { get { return _memberStatusCode_ExistsSubQuery_MemberLoginListMap; }}
        public override String keepMemberStatusCode_ExistsSubQuery_MemberLoginList(MemberLoginCQ subQuery) {
            if (_memberStatusCode_ExistsSubQuery_MemberLoginListMap == null) { _memberStatusCode_ExistsSubQuery_MemberLoginListMap = new LinkedHashMap<String, MemberLoginCQ>(); }
            String key = "subQueryMapKey" + (_memberStatusCode_ExistsSubQuery_MemberLoginListMap.size() + 1);
            _memberStatusCode_ExistsSubQuery_MemberLoginListMap.put(key, subQuery); return "MemberStatusCode_ExistsSubQuery_MemberLoginList." + key;
        }

        protected Map<String, MemberVendorSynonymCQ> _memberStatusCode_ExistsSubQuery_MemberVendorSynonymListMap;
        public Map<String, MemberVendorSynonymCQ> MemberStatusCode_ExistsSubQuery_MemberVendorSynonymList { get { return _memberStatusCode_ExistsSubQuery_MemberVendorSynonymListMap; }}
        public override String keepMemberStatusCode_ExistsSubQuery_MemberVendorSynonymList(MemberVendorSynonymCQ subQuery) {
            if (_memberStatusCode_ExistsSubQuery_MemberVendorSynonymListMap == null) { _memberStatusCode_ExistsSubQuery_MemberVendorSynonymListMap = new LinkedHashMap<String, MemberVendorSynonymCQ>(); }
            String key = "subQueryMapKey" + (_memberStatusCode_ExistsSubQuery_MemberVendorSynonymListMap.size() + 1);
            _memberStatusCode_ExistsSubQuery_MemberVendorSynonymListMap.put(key, subQuery); return "MemberStatusCode_ExistsSubQuery_MemberVendorSynonymList." + key;
        }

        protected Map<String, VdSynonymMemberCQ> _memberStatusCode_ExistsSubQuery_VdSynonymMemberListMap;
        public Map<String, VdSynonymMemberCQ> MemberStatusCode_ExistsSubQuery_VdSynonymMemberList { get { return _memberStatusCode_ExistsSubQuery_VdSynonymMemberListMap; }}
        public override String keepMemberStatusCode_ExistsSubQuery_VdSynonymMemberList(VdSynonymMemberCQ subQuery) {
            if (_memberStatusCode_ExistsSubQuery_VdSynonymMemberListMap == null) { _memberStatusCode_ExistsSubQuery_VdSynonymMemberListMap = new LinkedHashMap<String, VdSynonymMemberCQ>(); }
            String key = "subQueryMapKey" + (_memberStatusCode_ExistsSubQuery_VdSynonymMemberListMap.size() + 1);
            _memberStatusCode_ExistsSubQuery_VdSynonymMemberListMap.put(key, subQuery); return "MemberStatusCode_ExistsSubQuery_VdSynonymMemberList." + key;
        }

        protected Map<String, VdSynonymMemberLoginCQ> _memberStatusCode_ExistsSubQuery_VdSynonymMemberLoginListMap;
        public Map<String, VdSynonymMemberLoginCQ> MemberStatusCode_ExistsSubQuery_VdSynonymMemberLoginList { get { return _memberStatusCode_ExistsSubQuery_VdSynonymMemberLoginListMap; }}
        public override String keepMemberStatusCode_ExistsSubQuery_VdSynonymMemberLoginList(VdSynonymMemberLoginCQ subQuery) {
            if (_memberStatusCode_ExistsSubQuery_VdSynonymMemberLoginListMap == null) { _memberStatusCode_ExistsSubQuery_VdSynonymMemberLoginListMap = new LinkedHashMap<String, VdSynonymMemberLoginCQ>(); }
            String key = "subQueryMapKey" + (_memberStatusCode_ExistsSubQuery_VdSynonymMemberLoginListMap.size() + 1);
            _memberStatusCode_ExistsSubQuery_VdSynonymMemberLoginListMap.put(key, subQuery); return "MemberStatusCode_ExistsSubQuery_VdSynonymMemberLoginList." + key;
        }

        protected Map<String, VendorSynonymMemberCQ> _memberStatusCode_ExistsSubQuery_VendorSynonymMemberListMap;
        public Map<String, VendorSynonymMemberCQ> MemberStatusCode_ExistsSubQuery_VendorSynonymMemberList { get { return _memberStatusCode_ExistsSubQuery_VendorSynonymMemberListMap; }}
        public override String keepMemberStatusCode_ExistsSubQuery_VendorSynonymMemberList(VendorSynonymMemberCQ subQuery) {
            if (_memberStatusCode_ExistsSubQuery_VendorSynonymMemberListMap == null) { _memberStatusCode_ExistsSubQuery_VendorSynonymMemberListMap = new LinkedHashMap<String, VendorSynonymMemberCQ>(); }
            String key = "subQueryMapKey" + (_memberStatusCode_ExistsSubQuery_VendorSynonymMemberListMap.size() + 1);
            _memberStatusCode_ExistsSubQuery_VendorSynonymMemberListMap.put(key, subQuery); return "MemberStatusCode_ExistsSubQuery_VendorSynonymMemberList." + key;
        }

        protected Map<String, MemberCQ> _memberStatusCode_NotExistsSubQuery_MemberListMap;
        public Map<String, MemberCQ> MemberStatusCode_NotExistsSubQuery_MemberList { get { return _memberStatusCode_NotExistsSubQuery_MemberListMap; }}
        public override String keepMemberStatusCode_NotExistsSubQuery_MemberList(MemberCQ subQuery) {
            if (_memberStatusCode_NotExistsSubQuery_MemberListMap == null) { _memberStatusCode_NotExistsSubQuery_MemberListMap = new LinkedHashMap<String, MemberCQ>(); }
            String key = "subQueryMapKey" + (_memberStatusCode_NotExistsSubQuery_MemberListMap.size() + 1);
            _memberStatusCode_NotExistsSubQuery_MemberListMap.put(key, subQuery); return "MemberStatusCode_NotExistsSubQuery_MemberList." + key;
        }

        protected Map<String, MemberLoginCQ> _memberStatusCode_NotExistsSubQuery_MemberLoginListMap;
        public Map<String, MemberLoginCQ> MemberStatusCode_NotExistsSubQuery_MemberLoginList { get { return _memberStatusCode_NotExistsSubQuery_MemberLoginListMap; }}
        public override String keepMemberStatusCode_NotExistsSubQuery_MemberLoginList(MemberLoginCQ subQuery) {
            if (_memberStatusCode_NotExistsSubQuery_MemberLoginListMap == null) { _memberStatusCode_NotExistsSubQuery_MemberLoginListMap = new LinkedHashMap<String, MemberLoginCQ>(); }
            String key = "subQueryMapKey" + (_memberStatusCode_NotExistsSubQuery_MemberLoginListMap.size() + 1);
            _memberStatusCode_NotExistsSubQuery_MemberLoginListMap.put(key, subQuery); return "MemberStatusCode_NotExistsSubQuery_MemberLoginList." + key;
        }

        protected Map<String, MemberVendorSynonymCQ> _memberStatusCode_NotExistsSubQuery_MemberVendorSynonymListMap;
        public Map<String, MemberVendorSynonymCQ> MemberStatusCode_NotExistsSubQuery_MemberVendorSynonymList { get { return _memberStatusCode_NotExistsSubQuery_MemberVendorSynonymListMap; }}
        public override String keepMemberStatusCode_NotExistsSubQuery_MemberVendorSynonymList(MemberVendorSynonymCQ subQuery) {
            if (_memberStatusCode_NotExistsSubQuery_MemberVendorSynonymListMap == null) { _memberStatusCode_NotExistsSubQuery_MemberVendorSynonymListMap = new LinkedHashMap<String, MemberVendorSynonymCQ>(); }
            String key = "subQueryMapKey" + (_memberStatusCode_NotExistsSubQuery_MemberVendorSynonymListMap.size() + 1);
            _memberStatusCode_NotExistsSubQuery_MemberVendorSynonymListMap.put(key, subQuery); return "MemberStatusCode_NotExistsSubQuery_MemberVendorSynonymList." + key;
        }

        protected Map<String, VdSynonymMemberCQ> _memberStatusCode_NotExistsSubQuery_VdSynonymMemberListMap;
        public Map<String, VdSynonymMemberCQ> MemberStatusCode_NotExistsSubQuery_VdSynonymMemberList { get { return _memberStatusCode_NotExistsSubQuery_VdSynonymMemberListMap; }}
        public override String keepMemberStatusCode_NotExistsSubQuery_VdSynonymMemberList(VdSynonymMemberCQ subQuery) {
            if (_memberStatusCode_NotExistsSubQuery_VdSynonymMemberListMap == null) { _memberStatusCode_NotExistsSubQuery_VdSynonymMemberListMap = new LinkedHashMap<String, VdSynonymMemberCQ>(); }
            String key = "subQueryMapKey" + (_memberStatusCode_NotExistsSubQuery_VdSynonymMemberListMap.size() + 1);
            _memberStatusCode_NotExistsSubQuery_VdSynonymMemberListMap.put(key, subQuery); return "MemberStatusCode_NotExistsSubQuery_VdSynonymMemberList." + key;
        }

        protected Map<String, VdSynonymMemberLoginCQ> _memberStatusCode_NotExistsSubQuery_VdSynonymMemberLoginListMap;
        public Map<String, VdSynonymMemberLoginCQ> MemberStatusCode_NotExistsSubQuery_VdSynonymMemberLoginList { get { return _memberStatusCode_NotExistsSubQuery_VdSynonymMemberLoginListMap; }}
        public override String keepMemberStatusCode_NotExistsSubQuery_VdSynonymMemberLoginList(VdSynonymMemberLoginCQ subQuery) {
            if (_memberStatusCode_NotExistsSubQuery_VdSynonymMemberLoginListMap == null) { _memberStatusCode_NotExistsSubQuery_VdSynonymMemberLoginListMap = new LinkedHashMap<String, VdSynonymMemberLoginCQ>(); }
            String key = "subQueryMapKey" + (_memberStatusCode_NotExistsSubQuery_VdSynonymMemberLoginListMap.size() + 1);
            _memberStatusCode_NotExistsSubQuery_VdSynonymMemberLoginListMap.put(key, subQuery); return "MemberStatusCode_NotExistsSubQuery_VdSynonymMemberLoginList." + key;
        }

        protected Map<String, VendorSynonymMemberCQ> _memberStatusCode_NotExistsSubQuery_VendorSynonymMemberListMap;
        public Map<String, VendorSynonymMemberCQ> MemberStatusCode_NotExistsSubQuery_VendorSynonymMemberList { get { return _memberStatusCode_NotExistsSubQuery_VendorSynonymMemberListMap; }}
        public override String keepMemberStatusCode_NotExistsSubQuery_VendorSynonymMemberList(VendorSynonymMemberCQ subQuery) {
            if (_memberStatusCode_NotExistsSubQuery_VendorSynonymMemberListMap == null) { _memberStatusCode_NotExistsSubQuery_VendorSynonymMemberListMap = new LinkedHashMap<String, VendorSynonymMemberCQ>(); }
            String key = "subQueryMapKey" + (_memberStatusCode_NotExistsSubQuery_VendorSynonymMemberListMap.size() + 1);
            _memberStatusCode_NotExistsSubQuery_VendorSynonymMemberListMap.put(key, subQuery); return "MemberStatusCode_NotExistsSubQuery_VendorSynonymMemberList." + key;
        }

        protected Map<String, MemberCQ> _memberStatusCode_InScopeSubQuery_MemberListMap;
        public Map<String, MemberCQ> MemberStatusCode_InScopeSubQuery_MemberList { get { return _memberStatusCode_InScopeSubQuery_MemberListMap; }}
        public override String keepMemberStatusCode_InScopeSubQuery_MemberList(MemberCQ subQuery) {
            if (_memberStatusCode_InScopeSubQuery_MemberListMap == null) { _memberStatusCode_InScopeSubQuery_MemberListMap = new LinkedHashMap<String, MemberCQ>(); }
            String key = "subQueryMapKey" + (_memberStatusCode_InScopeSubQuery_MemberListMap.size() + 1);
            _memberStatusCode_InScopeSubQuery_MemberListMap.put(key, subQuery); return "MemberStatusCode_InScopeSubQuery_MemberList." + key;
        }

        protected Map<String, MemberLoginCQ> _memberStatusCode_InScopeSubQuery_MemberLoginListMap;
        public Map<String, MemberLoginCQ> MemberStatusCode_InScopeSubQuery_MemberLoginList { get { return _memberStatusCode_InScopeSubQuery_MemberLoginListMap; }}
        public override String keepMemberStatusCode_InScopeSubQuery_MemberLoginList(MemberLoginCQ subQuery) {
            if (_memberStatusCode_InScopeSubQuery_MemberLoginListMap == null) { _memberStatusCode_InScopeSubQuery_MemberLoginListMap = new LinkedHashMap<String, MemberLoginCQ>(); }
            String key = "subQueryMapKey" + (_memberStatusCode_InScopeSubQuery_MemberLoginListMap.size() + 1);
            _memberStatusCode_InScopeSubQuery_MemberLoginListMap.put(key, subQuery); return "MemberStatusCode_InScopeSubQuery_MemberLoginList." + key;
        }

        protected Map<String, MemberVendorSynonymCQ> _memberStatusCode_InScopeSubQuery_MemberVendorSynonymListMap;
        public Map<String, MemberVendorSynonymCQ> MemberStatusCode_InScopeSubQuery_MemberVendorSynonymList { get { return _memberStatusCode_InScopeSubQuery_MemberVendorSynonymListMap; }}
        public override String keepMemberStatusCode_InScopeSubQuery_MemberVendorSynonymList(MemberVendorSynonymCQ subQuery) {
            if (_memberStatusCode_InScopeSubQuery_MemberVendorSynonymListMap == null) { _memberStatusCode_InScopeSubQuery_MemberVendorSynonymListMap = new LinkedHashMap<String, MemberVendorSynonymCQ>(); }
            String key = "subQueryMapKey" + (_memberStatusCode_InScopeSubQuery_MemberVendorSynonymListMap.size() + 1);
            _memberStatusCode_InScopeSubQuery_MemberVendorSynonymListMap.put(key, subQuery); return "MemberStatusCode_InScopeSubQuery_MemberVendorSynonymList." + key;
        }

        protected Map<String, VdSynonymMemberCQ> _memberStatusCode_InScopeSubQuery_VdSynonymMemberListMap;
        public Map<String, VdSynonymMemberCQ> MemberStatusCode_InScopeSubQuery_VdSynonymMemberList { get { return _memberStatusCode_InScopeSubQuery_VdSynonymMemberListMap; }}
        public override String keepMemberStatusCode_InScopeSubQuery_VdSynonymMemberList(VdSynonymMemberCQ subQuery) {
            if (_memberStatusCode_InScopeSubQuery_VdSynonymMemberListMap == null) { _memberStatusCode_InScopeSubQuery_VdSynonymMemberListMap = new LinkedHashMap<String, VdSynonymMemberCQ>(); }
            String key = "subQueryMapKey" + (_memberStatusCode_InScopeSubQuery_VdSynonymMemberListMap.size() + 1);
            _memberStatusCode_InScopeSubQuery_VdSynonymMemberListMap.put(key, subQuery); return "MemberStatusCode_InScopeSubQuery_VdSynonymMemberList." + key;
        }

        protected Map<String, VdSynonymMemberLoginCQ> _memberStatusCode_InScopeSubQuery_VdSynonymMemberLoginListMap;
        public Map<String, VdSynonymMemberLoginCQ> MemberStatusCode_InScopeSubQuery_VdSynonymMemberLoginList { get { return _memberStatusCode_InScopeSubQuery_VdSynonymMemberLoginListMap; }}
        public override String keepMemberStatusCode_InScopeSubQuery_VdSynonymMemberLoginList(VdSynonymMemberLoginCQ subQuery) {
            if (_memberStatusCode_InScopeSubQuery_VdSynonymMemberLoginListMap == null) { _memberStatusCode_InScopeSubQuery_VdSynonymMemberLoginListMap = new LinkedHashMap<String, VdSynonymMemberLoginCQ>(); }
            String key = "subQueryMapKey" + (_memberStatusCode_InScopeSubQuery_VdSynonymMemberLoginListMap.size() + 1);
            _memberStatusCode_InScopeSubQuery_VdSynonymMemberLoginListMap.put(key, subQuery); return "MemberStatusCode_InScopeSubQuery_VdSynonymMemberLoginList." + key;
        }

        protected Map<String, VendorSynonymMemberCQ> _memberStatusCode_InScopeSubQuery_VendorSynonymMemberListMap;
        public Map<String, VendorSynonymMemberCQ> MemberStatusCode_InScopeSubQuery_VendorSynonymMemberList { get { return _memberStatusCode_InScopeSubQuery_VendorSynonymMemberListMap; }}
        public override String keepMemberStatusCode_InScopeSubQuery_VendorSynonymMemberList(VendorSynonymMemberCQ subQuery) {
            if (_memberStatusCode_InScopeSubQuery_VendorSynonymMemberListMap == null) { _memberStatusCode_InScopeSubQuery_VendorSynonymMemberListMap = new LinkedHashMap<String, VendorSynonymMemberCQ>(); }
            String key = "subQueryMapKey" + (_memberStatusCode_InScopeSubQuery_VendorSynonymMemberListMap.size() + 1);
            _memberStatusCode_InScopeSubQuery_VendorSynonymMemberListMap.put(key, subQuery); return "MemberStatusCode_InScopeSubQuery_VendorSynonymMemberList." + key;
        }

        protected Map<String, MemberCQ> _memberStatusCode_NotInScopeSubQuery_MemberListMap;
        public Map<String, MemberCQ> MemberStatusCode_NotInScopeSubQuery_MemberList { get { return _memberStatusCode_NotInScopeSubQuery_MemberListMap; }}
        public override String keepMemberStatusCode_NotInScopeSubQuery_MemberList(MemberCQ subQuery) {
            if (_memberStatusCode_NotInScopeSubQuery_MemberListMap == null) { _memberStatusCode_NotInScopeSubQuery_MemberListMap = new LinkedHashMap<String, MemberCQ>(); }
            String key = "subQueryMapKey" + (_memberStatusCode_NotInScopeSubQuery_MemberListMap.size() + 1);
            _memberStatusCode_NotInScopeSubQuery_MemberListMap.put(key, subQuery); return "MemberStatusCode_NotInScopeSubQuery_MemberList." + key;
        }

        protected Map<String, MemberLoginCQ> _memberStatusCode_NotInScopeSubQuery_MemberLoginListMap;
        public Map<String, MemberLoginCQ> MemberStatusCode_NotInScopeSubQuery_MemberLoginList { get { return _memberStatusCode_NotInScopeSubQuery_MemberLoginListMap; }}
        public override String keepMemberStatusCode_NotInScopeSubQuery_MemberLoginList(MemberLoginCQ subQuery) {
            if (_memberStatusCode_NotInScopeSubQuery_MemberLoginListMap == null) { _memberStatusCode_NotInScopeSubQuery_MemberLoginListMap = new LinkedHashMap<String, MemberLoginCQ>(); }
            String key = "subQueryMapKey" + (_memberStatusCode_NotInScopeSubQuery_MemberLoginListMap.size() + 1);
            _memberStatusCode_NotInScopeSubQuery_MemberLoginListMap.put(key, subQuery); return "MemberStatusCode_NotInScopeSubQuery_MemberLoginList." + key;
        }

        protected Map<String, MemberVendorSynonymCQ> _memberStatusCode_NotInScopeSubQuery_MemberVendorSynonymListMap;
        public Map<String, MemberVendorSynonymCQ> MemberStatusCode_NotInScopeSubQuery_MemberVendorSynonymList { get { return _memberStatusCode_NotInScopeSubQuery_MemberVendorSynonymListMap; }}
        public override String keepMemberStatusCode_NotInScopeSubQuery_MemberVendorSynonymList(MemberVendorSynonymCQ subQuery) {
            if (_memberStatusCode_NotInScopeSubQuery_MemberVendorSynonymListMap == null) { _memberStatusCode_NotInScopeSubQuery_MemberVendorSynonymListMap = new LinkedHashMap<String, MemberVendorSynonymCQ>(); }
            String key = "subQueryMapKey" + (_memberStatusCode_NotInScopeSubQuery_MemberVendorSynonymListMap.size() + 1);
            _memberStatusCode_NotInScopeSubQuery_MemberVendorSynonymListMap.put(key, subQuery); return "MemberStatusCode_NotInScopeSubQuery_MemberVendorSynonymList." + key;
        }

        protected Map<String, VdSynonymMemberCQ> _memberStatusCode_NotInScopeSubQuery_VdSynonymMemberListMap;
        public Map<String, VdSynonymMemberCQ> MemberStatusCode_NotInScopeSubQuery_VdSynonymMemberList { get { return _memberStatusCode_NotInScopeSubQuery_VdSynonymMemberListMap; }}
        public override String keepMemberStatusCode_NotInScopeSubQuery_VdSynonymMemberList(VdSynonymMemberCQ subQuery) {
            if (_memberStatusCode_NotInScopeSubQuery_VdSynonymMemberListMap == null) { _memberStatusCode_NotInScopeSubQuery_VdSynonymMemberListMap = new LinkedHashMap<String, VdSynonymMemberCQ>(); }
            String key = "subQueryMapKey" + (_memberStatusCode_NotInScopeSubQuery_VdSynonymMemberListMap.size() + 1);
            _memberStatusCode_NotInScopeSubQuery_VdSynonymMemberListMap.put(key, subQuery); return "MemberStatusCode_NotInScopeSubQuery_VdSynonymMemberList." + key;
        }

        protected Map<String, VdSynonymMemberLoginCQ> _memberStatusCode_NotInScopeSubQuery_VdSynonymMemberLoginListMap;
        public Map<String, VdSynonymMemberLoginCQ> MemberStatusCode_NotInScopeSubQuery_VdSynonymMemberLoginList { get { return _memberStatusCode_NotInScopeSubQuery_VdSynonymMemberLoginListMap; }}
        public override String keepMemberStatusCode_NotInScopeSubQuery_VdSynonymMemberLoginList(VdSynonymMemberLoginCQ subQuery) {
            if (_memberStatusCode_NotInScopeSubQuery_VdSynonymMemberLoginListMap == null) { _memberStatusCode_NotInScopeSubQuery_VdSynonymMemberLoginListMap = new LinkedHashMap<String, VdSynonymMemberLoginCQ>(); }
            String key = "subQueryMapKey" + (_memberStatusCode_NotInScopeSubQuery_VdSynonymMemberLoginListMap.size() + 1);
            _memberStatusCode_NotInScopeSubQuery_VdSynonymMemberLoginListMap.put(key, subQuery); return "MemberStatusCode_NotInScopeSubQuery_VdSynonymMemberLoginList." + key;
        }

        protected Map<String, VendorSynonymMemberCQ> _memberStatusCode_NotInScopeSubQuery_VendorSynonymMemberListMap;
        public Map<String, VendorSynonymMemberCQ> MemberStatusCode_NotInScopeSubQuery_VendorSynonymMemberList { get { return _memberStatusCode_NotInScopeSubQuery_VendorSynonymMemberListMap; }}
        public override String keepMemberStatusCode_NotInScopeSubQuery_VendorSynonymMemberList(VendorSynonymMemberCQ subQuery) {
            if (_memberStatusCode_NotInScopeSubQuery_VendorSynonymMemberListMap == null) { _memberStatusCode_NotInScopeSubQuery_VendorSynonymMemberListMap = new LinkedHashMap<String, VendorSynonymMemberCQ>(); }
            String key = "subQueryMapKey" + (_memberStatusCode_NotInScopeSubQuery_VendorSynonymMemberListMap.size() + 1);
            _memberStatusCode_NotInScopeSubQuery_VendorSynonymMemberListMap.put(key, subQuery); return "MemberStatusCode_NotInScopeSubQuery_VendorSynonymMemberList." + key;
        }

        protected Map<String, MemberCQ> _memberStatusCode_SpecifyDerivedReferrer_MemberListMap;
        public Map<String, MemberCQ> MemberStatusCode_SpecifyDerivedReferrer_MemberList { get { return _memberStatusCode_SpecifyDerivedReferrer_MemberListMap; }}
        public override String keepMemberStatusCode_SpecifyDerivedReferrer_MemberList(MemberCQ subQuery) {
            if (_memberStatusCode_SpecifyDerivedReferrer_MemberListMap == null) { _memberStatusCode_SpecifyDerivedReferrer_MemberListMap = new LinkedHashMap<String, MemberCQ>(); }
            String key = "subQueryMapKey" + (_memberStatusCode_SpecifyDerivedReferrer_MemberListMap.size() + 1);
           _memberStatusCode_SpecifyDerivedReferrer_MemberListMap.put(key, subQuery); return "MemberStatusCode_SpecifyDerivedReferrer_MemberList." + key;
        }

        protected Map<String, MemberLoginCQ> _memberStatusCode_SpecifyDerivedReferrer_MemberLoginListMap;
        public Map<String, MemberLoginCQ> MemberStatusCode_SpecifyDerivedReferrer_MemberLoginList { get { return _memberStatusCode_SpecifyDerivedReferrer_MemberLoginListMap; }}
        public override String keepMemberStatusCode_SpecifyDerivedReferrer_MemberLoginList(MemberLoginCQ subQuery) {
            if (_memberStatusCode_SpecifyDerivedReferrer_MemberLoginListMap == null) { _memberStatusCode_SpecifyDerivedReferrer_MemberLoginListMap = new LinkedHashMap<String, MemberLoginCQ>(); }
            String key = "subQueryMapKey" + (_memberStatusCode_SpecifyDerivedReferrer_MemberLoginListMap.size() + 1);
           _memberStatusCode_SpecifyDerivedReferrer_MemberLoginListMap.put(key, subQuery); return "MemberStatusCode_SpecifyDerivedReferrer_MemberLoginList." + key;
        }

        protected Map<String, MemberVendorSynonymCQ> _memberStatusCode_SpecifyDerivedReferrer_MemberVendorSynonymListMap;
        public Map<String, MemberVendorSynonymCQ> MemberStatusCode_SpecifyDerivedReferrer_MemberVendorSynonymList { get { return _memberStatusCode_SpecifyDerivedReferrer_MemberVendorSynonymListMap; }}
        public override String keepMemberStatusCode_SpecifyDerivedReferrer_MemberVendorSynonymList(MemberVendorSynonymCQ subQuery) {
            if (_memberStatusCode_SpecifyDerivedReferrer_MemberVendorSynonymListMap == null) { _memberStatusCode_SpecifyDerivedReferrer_MemberVendorSynonymListMap = new LinkedHashMap<String, MemberVendorSynonymCQ>(); }
            String key = "subQueryMapKey" + (_memberStatusCode_SpecifyDerivedReferrer_MemberVendorSynonymListMap.size() + 1);
           _memberStatusCode_SpecifyDerivedReferrer_MemberVendorSynonymListMap.put(key, subQuery); return "MemberStatusCode_SpecifyDerivedReferrer_MemberVendorSynonymList." + key;
        }

        protected Map<String, VdSynonymMemberCQ> _memberStatusCode_SpecifyDerivedReferrer_VdSynonymMemberListMap;
        public Map<String, VdSynonymMemberCQ> MemberStatusCode_SpecifyDerivedReferrer_VdSynonymMemberList { get { return _memberStatusCode_SpecifyDerivedReferrer_VdSynonymMemberListMap; }}
        public override String keepMemberStatusCode_SpecifyDerivedReferrer_VdSynonymMemberList(VdSynonymMemberCQ subQuery) {
            if (_memberStatusCode_SpecifyDerivedReferrer_VdSynonymMemberListMap == null) { _memberStatusCode_SpecifyDerivedReferrer_VdSynonymMemberListMap = new LinkedHashMap<String, VdSynonymMemberCQ>(); }
            String key = "subQueryMapKey" + (_memberStatusCode_SpecifyDerivedReferrer_VdSynonymMemberListMap.size() + 1);
           _memberStatusCode_SpecifyDerivedReferrer_VdSynonymMemberListMap.put(key, subQuery); return "MemberStatusCode_SpecifyDerivedReferrer_VdSynonymMemberList." + key;
        }

        protected Map<String, VdSynonymMemberLoginCQ> _memberStatusCode_SpecifyDerivedReferrer_VdSynonymMemberLoginListMap;
        public Map<String, VdSynonymMemberLoginCQ> MemberStatusCode_SpecifyDerivedReferrer_VdSynonymMemberLoginList { get { return _memberStatusCode_SpecifyDerivedReferrer_VdSynonymMemberLoginListMap; }}
        public override String keepMemberStatusCode_SpecifyDerivedReferrer_VdSynonymMemberLoginList(VdSynonymMemberLoginCQ subQuery) {
            if (_memberStatusCode_SpecifyDerivedReferrer_VdSynonymMemberLoginListMap == null) { _memberStatusCode_SpecifyDerivedReferrer_VdSynonymMemberLoginListMap = new LinkedHashMap<String, VdSynonymMemberLoginCQ>(); }
            String key = "subQueryMapKey" + (_memberStatusCode_SpecifyDerivedReferrer_VdSynonymMemberLoginListMap.size() + 1);
           _memberStatusCode_SpecifyDerivedReferrer_VdSynonymMemberLoginListMap.put(key, subQuery); return "MemberStatusCode_SpecifyDerivedReferrer_VdSynonymMemberLoginList." + key;
        }

        protected Map<String, VendorSynonymMemberCQ> _memberStatusCode_SpecifyDerivedReferrer_VendorSynonymMemberListMap;
        public Map<String, VendorSynonymMemberCQ> MemberStatusCode_SpecifyDerivedReferrer_VendorSynonymMemberList { get { return _memberStatusCode_SpecifyDerivedReferrer_VendorSynonymMemberListMap; }}
        public override String keepMemberStatusCode_SpecifyDerivedReferrer_VendorSynonymMemberList(VendorSynonymMemberCQ subQuery) {
            if (_memberStatusCode_SpecifyDerivedReferrer_VendorSynonymMemberListMap == null) { _memberStatusCode_SpecifyDerivedReferrer_VendorSynonymMemberListMap = new LinkedHashMap<String, VendorSynonymMemberCQ>(); }
            String key = "subQueryMapKey" + (_memberStatusCode_SpecifyDerivedReferrer_VendorSynonymMemberListMap.size() + 1);
           _memberStatusCode_SpecifyDerivedReferrer_VendorSynonymMemberListMap.put(key, subQuery); return "MemberStatusCode_SpecifyDerivedReferrer_VendorSynonymMemberList." + key;
        }

        protected Map<String, MemberCQ> _memberStatusCode_QueryDerivedReferrer_MemberListMap;
        public Map<String, MemberCQ> MemberStatusCode_QueryDerivedReferrer_MemberList { get { return _memberStatusCode_QueryDerivedReferrer_MemberListMap; } }
        public override String keepMemberStatusCode_QueryDerivedReferrer_MemberList(MemberCQ subQuery) {
            if (_memberStatusCode_QueryDerivedReferrer_MemberListMap == null) { _memberStatusCode_QueryDerivedReferrer_MemberListMap = new LinkedHashMap<String, MemberCQ>(); }
            String key = "subQueryMapKey" + (_memberStatusCode_QueryDerivedReferrer_MemberListMap.size() + 1);
            _memberStatusCode_QueryDerivedReferrer_MemberListMap.put(key, subQuery); return "MemberStatusCode_QueryDerivedReferrer_MemberList." + key;
        }
        protected Map<String, Object> _memberStatusCode_QueryDerivedReferrer_MemberListParameterMap;
        public Map<String, Object> MemberStatusCode_QueryDerivedReferrer_MemberListParameter { get { return _memberStatusCode_QueryDerivedReferrer_MemberListParameterMap; } }
        public override String keepMemberStatusCode_QueryDerivedReferrer_MemberListParameter(Object parameterValue) {
            if (_memberStatusCode_QueryDerivedReferrer_MemberListParameterMap == null) { _memberStatusCode_QueryDerivedReferrer_MemberListParameterMap = new LinkedHashMap<String, Object>(); }
            String key = "subQueryParameterKey" + (_memberStatusCode_QueryDerivedReferrer_MemberListParameterMap.size() + 1);
            _memberStatusCode_QueryDerivedReferrer_MemberListParameterMap.put(key, parameterValue); return "MemberStatusCode_QueryDerivedReferrer_MemberListParameter." + key;
        }

        protected Map<String, MemberLoginCQ> _memberStatusCode_QueryDerivedReferrer_MemberLoginListMap;
        public Map<String, MemberLoginCQ> MemberStatusCode_QueryDerivedReferrer_MemberLoginList { get { return _memberStatusCode_QueryDerivedReferrer_MemberLoginListMap; } }
        public override String keepMemberStatusCode_QueryDerivedReferrer_MemberLoginList(MemberLoginCQ subQuery) {
            if (_memberStatusCode_QueryDerivedReferrer_MemberLoginListMap == null) { _memberStatusCode_QueryDerivedReferrer_MemberLoginListMap = new LinkedHashMap<String, MemberLoginCQ>(); }
            String key = "subQueryMapKey" + (_memberStatusCode_QueryDerivedReferrer_MemberLoginListMap.size() + 1);
            _memberStatusCode_QueryDerivedReferrer_MemberLoginListMap.put(key, subQuery); return "MemberStatusCode_QueryDerivedReferrer_MemberLoginList." + key;
        }
        protected Map<String, Object> _memberStatusCode_QueryDerivedReferrer_MemberLoginListParameterMap;
        public Map<String, Object> MemberStatusCode_QueryDerivedReferrer_MemberLoginListParameter { get { return _memberStatusCode_QueryDerivedReferrer_MemberLoginListParameterMap; } }
        public override String keepMemberStatusCode_QueryDerivedReferrer_MemberLoginListParameter(Object parameterValue) {
            if (_memberStatusCode_QueryDerivedReferrer_MemberLoginListParameterMap == null) { _memberStatusCode_QueryDerivedReferrer_MemberLoginListParameterMap = new LinkedHashMap<String, Object>(); }
            String key = "subQueryParameterKey" + (_memberStatusCode_QueryDerivedReferrer_MemberLoginListParameterMap.size() + 1);
            _memberStatusCode_QueryDerivedReferrer_MemberLoginListParameterMap.put(key, parameterValue); return "MemberStatusCode_QueryDerivedReferrer_MemberLoginListParameter." + key;
        }

        protected Map<String, MemberVendorSynonymCQ> _memberStatusCode_QueryDerivedReferrer_MemberVendorSynonymListMap;
        public Map<String, MemberVendorSynonymCQ> MemberStatusCode_QueryDerivedReferrer_MemberVendorSynonymList { get { return _memberStatusCode_QueryDerivedReferrer_MemberVendorSynonymListMap; } }
        public override String keepMemberStatusCode_QueryDerivedReferrer_MemberVendorSynonymList(MemberVendorSynonymCQ subQuery) {
            if (_memberStatusCode_QueryDerivedReferrer_MemberVendorSynonymListMap == null) { _memberStatusCode_QueryDerivedReferrer_MemberVendorSynonymListMap = new LinkedHashMap<String, MemberVendorSynonymCQ>(); }
            String key = "subQueryMapKey" + (_memberStatusCode_QueryDerivedReferrer_MemberVendorSynonymListMap.size() + 1);
            _memberStatusCode_QueryDerivedReferrer_MemberVendorSynonymListMap.put(key, subQuery); return "MemberStatusCode_QueryDerivedReferrer_MemberVendorSynonymList." + key;
        }
        protected Map<String, Object> _memberStatusCode_QueryDerivedReferrer_MemberVendorSynonymListParameterMap;
        public Map<String, Object> MemberStatusCode_QueryDerivedReferrer_MemberVendorSynonymListParameter { get { return _memberStatusCode_QueryDerivedReferrer_MemberVendorSynonymListParameterMap; } }
        public override String keepMemberStatusCode_QueryDerivedReferrer_MemberVendorSynonymListParameter(Object parameterValue) {
            if (_memberStatusCode_QueryDerivedReferrer_MemberVendorSynonymListParameterMap == null) { _memberStatusCode_QueryDerivedReferrer_MemberVendorSynonymListParameterMap = new LinkedHashMap<String, Object>(); }
            String key = "subQueryParameterKey" + (_memberStatusCode_QueryDerivedReferrer_MemberVendorSynonymListParameterMap.size() + 1);
            _memberStatusCode_QueryDerivedReferrer_MemberVendorSynonymListParameterMap.put(key, parameterValue); return "MemberStatusCode_QueryDerivedReferrer_MemberVendorSynonymListParameter." + key;
        }

        protected Map<String, VdSynonymMemberCQ> _memberStatusCode_QueryDerivedReferrer_VdSynonymMemberListMap;
        public Map<String, VdSynonymMemberCQ> MemberStatusCode_QueryDerivedReferrer_VdSynonymMemberList { get { return _memberStatusCode_QueryDerivedReferrer_VdSynonymMemberListMap; } }
        public override String keepMemberStatusCode_QueryDerivedReferrer_VdSynonymMemberList(VdSynonymMemberCQ subQuery) {
            if (_memberStatusCode_QueryDerivedReferrer_VdSynonymMemberListMap == null) { _memberStatusCode_QueryDerivedReferrer_VdSynonymMemberListMap = new LinkedHashMap<String, VdSynonymMemberCQ>(); }
            String key = "subQueryMapKey" + (_memberStatusCode_QueryDerivedReferrer_VdSynonymMemberListMap.size() + 1);
            _memberStatusCode_QueryDerivedReferrer_VdSynonymMemberListMap.put(key, subQuery); return "MemberStatusCode_QueryDerivedReferrer_VdSynonymMemberList." + key;
        }
        protected Map<String, Object> _memberStatusCode_QueryDerivedReferrer_VdSynonymMemberListParameterMap;
        public Map<String, Object> MemberStatusCode_QueryDerivedReferrer_VdSynonymMemberListParameter { get { return _memberStatusCode_QueryDerivedReferrer_VdSynonymMemberListParameterMap; } }
        public override String keepMemberStatusCode_QueryDerivedReferrer_VdSynonymMemberListParameter(Object parameterValue) {
            if (_memberStatusCode_QueryDerivedReferrer_VdSynonymMemberListParameterMap == null) { _memberStatusCode_QueryDerivedReferrer_VdSynonymMemberListParameterMap = new LinkedHashMap<String, Object>(); }
            String key = "subQueryParameterKey" + (_memberStatusCode_QueryDerivedReferrer_VdSynonymMemberListParameterMap.size() + 1);
            _memberStatusCode_QueryDerivedReferrer_VdSynonymMemberListParameterMap.put(key, parameterValue); return "MemberStatusCode_QueryDerivedReferrer_VdSynonymMemberListParameter." + key;
        }

        protected Map<String, VdSynonymMemberLoginCQ> _memberStatusCode_QueryDerivedReferrer_VdSynonymMemberLoginListMap;
        public Map<String, VdSynonymMemberLoginCQ> MemberStatusCode_QueryDerivedReferrer_VdSynonymMemberLoginList { get { return _memberStatusCode_QueryDerivedReferrer_VdSynonymMemberLoginListMap; } }
        public override String keepMemberStatusCode_QueryDerivedReferrer_VdSynonymMemberLoginList(VdSynonymMemberLoginCQ subQuery) {
            if (_memberStatusCode_QueryDerivedReferrer_VdSynonymMemberLoginListMap == null) { _memberStatusCode_QueryDerivedReferrer_VdSynonymMemberLoginListMap = new LinkedHashMap<String, VdSynonymMemberLoginCQ>(); }
            String key = "subQueryMapKey" + (_memberStatusCode_QueryDerivedReferrer_VdSynonymMemberLoginListMap.size() + 1);
            _memberStatusCode_QueryDerivedReferrer_VdSynonymMemberLoginListMap.put(key, subQuery); return "MemberStatusCode_QueryDerivedReferrer_VdSynonymMemberLoginList." + key;
        }
        protected Map<String, Object> _memberStatusCode_QueryDerivedReferrer_VdSynonymMemberLoginListParameterMap;
        public Map<String, Object> MemberStatusCode_QueryDerivedReferrer_VdSynonymMemberLoginListParameter { get { return _memberStatusCode_QueryDerivedReferrer_VdSynonymMemberLoginListParameterMap; } }
        public override String keepMemberStatusCode_QueryDerivedReferrer_VdSynonymMemberLoginListParameter(Object parameterValue) {
            if (_memberStatusCode_QueryDerivedReferrer_VdSynonymMemberLoginListParameterMap == null) { _memberStatusCode_QueryDerivedReferrer_VdSynonymMemberLoginListParameterMap = new LinkedHashMap<String, Object>(); }
            String key = "subQueryParameterKey" + (_memberStatusCode_QueryDerivedReferrer_VdSynonymMemberLoginListParameterMap.size() + 1);
            _memberStatusCode_QueryDerivedReferrer_VdSynonymMemberLoginListParameterMap.put(key, parameterValue); return "MemberStatusCode_QueryDerivedReferrer_VdSynonymMemberLoginListParameter." + key;
        }

        protected Map<String, VendorSynonymMemberCQ> _memberStatusCode_QueryDerivedReferrer_VendorSynonymMemberListMap;
        public Map<String, VendorSynonymMemberCQ> MemberStatusCode_QueryDerivedReferrer_VendorSynonymMemberList { get { return _memberStatusCode_QueryDerivedReferrer_VendorSynonymMemberListMap; } }
        public override String keepMemberStatusCode_QueryDerivedReferrer_VendorSynonymMemberList(VendorSynonymMemberCQ subQuery) {
            if (_memberStatusCode_QueryDerivedReferrer_VendorSynonymMemberListMap == null) { _memberStatusCode_QueryDerivedReferrer_VendorSynonymMemberListMap = new LinkedHashMap<String, VendorSynonymMemberCQ>(); }
            String key = "subQueryMapKey" + (_memberStatusCode_QueryDerivedReferrer_VendorSynonymMemberListMap.size() + 1);
            _memberStatusCode_QueryDerivedReferrer_VendorSynonymMemberListMap.put(key, subQuery); return "MemberStatusCode_QueryDerivedReferrer_VendorSynonymMemberList." + key;
        }
        protected Map<String, Object> _memberStatusCode_QueryDerivedReferrer_VendorSynonymMemberListParameterMap;
        public Map<String, Object> MemberStatusCode_QueryDerivedReferrer_VendorSynonymMemberListParameter { get { return _memberStatusCode_QueryDerivedReferrer_VendorSynonymMemberListParameterMap; } }
        public override String keepMemberStatusCode_QueryDerivedReferrer_VendorSynonymMemberListParameter(Object parameterValue) {
            if (_memberStatusCode_QueryDerivedReferrer_VendorSynonymMemberListParameterMap == null) { _memberStatusCode_QueryDerivedReferrer_VendorSynonymMemberListParameterMap = new LinkedHashMap<String, Object>(); }
            String key = "subQueryParameterKey" + (_memberStatusCode_QueryDerivedReferrer_VendorSynonymMemberListParameterMap.size() + 1);
            _memberStatusCode_QueryDerivedReferrer_VendorSynonymMemberListParameterMap.put(key, parameterValue); return "MemberStatusCode_QueryDerivedReferrer_VendorSynonymMemberListParameter." + key;
        }

        public BsMemberStatusCQ AddOrderBy_MemberStatusCode_Asc() { regOBA("MEMBER_STATUS_CODE");return this; }
        public BsMemberStatusCQ AddOrderBy_MemberStatusCode_Desc() { regOBD("MEMBER_STATUS_CODE");return this; }

        protected ConditionValue _memberStatusName;
        public ConditionValue MemberStatusName {
            get { if (_memberStatusName == null) { _memberStatusName = new ConditionValue(); } return _memberStatusName; }
        }
        protected override ConditionValue getCValueMemberStatusName() { return this.MemberStatusName; }


        public BsMemberStatusCQ AddOrderBy_MemberStatusName_Asc() { regOBA("MEMBER_STATUS_NAME");return this; }
        public BsMemberStatusCQ AddOrderBy_MemberStatusName_Desc() { regOBD("MEMBER_STATUS_NAME");return this; }

        protected ConditionValue _displayOrder;
        public ConditionValue DisplayOrder {
            get { if (_displayOrder == null) { _displayOrder = new ConditionValue(); } return _displayOrder; }
        }
        protected override ConditionValue getCValueDisplayOrder() { return this.DisplayOrder; }


        public BsMemberStatusCQ AddOrderBy_DisplayOrder_Asc() { regOBA("DISPLAY_ORDER");return this; }
        public BsMemberStatusCQ AddOrderBy_DisplayOrder_Desc() { regOBD("DISPLAY_ORDER");return this; }

        public BsMemberStatusCQ AddSpecifiedDerivedOrderBy_Asc(String aliasName) { registerSpecifiedDerivedOrderBy_Asc(aliasName); return this; }
        public BsMemberStatusCQ AddSpecifiedDerivedOrderBy_Desc(String aliasName) { registerSpecifiedDerivedOrderBy_Desc(aliasName); return this; }

        public override void reflectRelationOnUnionQuery(ConditionQuery baseQueryAsSuper, ConditionQuery unionQueryAsSuper) {

        }
    


	    // ===============================================================================
	    //                                                                 Scalar SubQuery
	    //                                                                 ===============
	    protected Map<String, MemberStatusCQ> _scalarSubQueryMap;
	    public Map<String, MemberStatusCQ> ScalarSubQuery { get { return _scalarSubQueryMap; } }
	    public override String keepScalarSubQuery(MemberStatusCQ subQuery) {
	        if (_scalarSubQueryMap == null) { _scalarSubQueryMap = new LinkedHashMap<String, MemberStatusCQ>(); }
	        String key = "subQueryMapKey" + (_scalarSubQueryMap.size() + 1);
	        _scalarSubQueryMap.put(key, subQuery); return "ScalarSubQuery." + key;
	    }

        // ===============================================================================
        //                                                         Myself InScope SubQuery
        //                                                         =======================
        protected Map<String, MemberStatusCQ> _myselfInScopeSubQueryMap;
        public Map<String, MemberStatusCQ> MyselfInScopeSubQuery { get { return _myselfInScopeSubQueryMap; } }
        public override String keepMyselfInScopeSubQuery(MemberStatusCQ subQuery) {
            if (_myselfInScopeSubQueryMap == null) { _myselfInScopeSubQueryMap = new LinkedHashMap<String, MemberStatusCQ>(); }
            String key = "subQueryMapKey" + (_myselfInScopeSubQueryMap.size() + 1);
            _myselfInScopeSubQueryMap.put(key, subQuery); return "MyselfInScopeSubQuery." + key;
        }
    }
}
