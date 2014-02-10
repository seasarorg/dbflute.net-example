
using System;

using DfExample.DBFlute.AllCommon.CBean;
using DfExample.DBFlute.AllCommon.CBean.CValue;
using DfExample.DBFlute.AllCommon.CBean.SClause;
using DfExample.DBFlute.AllCommon.JavaLike;
using DfExample.DBFlute.CBean.CQ;
using DfExample.DBFlute.CBean.CQ.Ciq;

namespace DfExample.DBFlute.CBean.CQ.BS {

    [System.Serializable]
    public class BsVendorTokenCQ : AbstractBsVendorTokenCQ {

        protected VendorTokenCIQ _inlineQuery;

        public BsVendorTokenCQ(ConditionQuery childQuery, SqlClause sqlClause, String aliasName, int nestLevel)
            : base(childQuery, sqlClause, aliasName, nestLevel) {}

        public VendorTokenCIQ Inline() {
            if (_inlineQuery == null) {
                _inlineQuery = new VendorTokenCIQ(xgetReferrerQuery(), xgetSqlClause(), xgetAliasName(), xgetNestLevel(), this);
            }
            _inlineQuery.xsetOnClause(false);
            return _inlineQuery;
        }
        
        public VendorTokenCIQ On() {
            if (isBaseQuery()) { throw new UnsupportedOperationException("Unsupported onClause of Base Table!"); }
            VendorTokenCIQ inlineQuery = Inline();
            inlineQuery.xsetOnClause(true);
            return inlineQuery;
        }


        protected ConditionValue _vendorTokenId;
        public ConditionValue VendorTokenId {
            get { if (_vendorTokenId == null) { _vendorTokenId = new ConditionValue(); } return _vendorTokenId; }
        }
        protected override ConditionValue getCValueVendorTokenId() { return this.VendorTokenId; }


        public BsVendorTokenCQ AddOrderBy_VendorTokenId_Asc() { regOBA("VENDOR_TOKEN_ID");return this; }
        public BsVendorTokenCQ AddOrderBy_VendorTokenId_Desc() { regOBD("VENDOR_TOKEN_ID");return this; }

        protected ConditionValue _tokenNumber;
        public ConditionValue TokenNumber {
            get { if (_tokenNumber == null) { _tokenNumber = new ConditionValue(); } return _tokenNumber; }
        }
        protected override ConditionValue getCValueTokenNumber() { return this.TokenNumber; }


        public BsVendorTokenCQ AddOrderBy_TokenNumber_Asc() { regOBA("TOKEN_NUMBER");return this; }
        public BsVendorTokenCQ AddOrderBy_TokenNumber_Desc() { regOBD("TOKEN_NUMBER");return this; }

        protected ConditionValue _tokenName;
        public ConditionValue TokenName {
            get { if (_tokenName == null) { _tokenName = new ConditionValue(); } return _tokenName; }
        }
        protected override ConditionValue getCValueTokenName() { return this.TokenName; }


        public BsVendorTokenCQ AddOrderBy_TokenName_Asc() { regOBA("TOKEN_NAME");return this; }
        public BsVendorTokenCQ AddOrderBy_TokenName_Desc() { regOBD("TOKEN_NAME");return this; }

        public BsVendorTokenCQ AddSpecifiedDerivedOrderBy_Asc(String aliasName) { registerSpecifiedDerivedOrderBy_Asc(aliasName); return this; }
        public BsVendorTokenCQ AddSpecifiedDerivedOrderBy_Desc(String aliasName) { registerSpecifiedDerivedOrderBy_Desc(aliasName); return this; }

        public override void reflectRelationOnUnionQuery(ConditionQuery baseQueryAsSuper, ConditionQuery unionQueryAsSuper) {

        }
    


	    // ===============================================================================
	    //                                                                 Scalar SubQuery
	    //                                                                 ===============
	    protected Map<String, VendorTokenCQ> _scalarSubQueryMap;
	    public Map<String, VendorTokenCQ> ScalarSubQuery { get { return _scalarSubQueryMap; } }
	    public override String keepScalarSubQuery(VendorTokenCQ subQuery) {
	        if (_scalarSubQueryMap == null) { _scalarSubQueryMap = new LinkedHashMap<String, VendorTokenCQ>(); }
	        String key = "subQueryMapKey" + (_scalarSubQueryMap.size() + 1);
	        _scalarSubQueryMap.put(key, subQuery); return "ScalarSubQuery." + key;
	    }

        // ===============================================================================
        //                                                         Myself InScope SubQuery
        //                                                         =======================
        protected Map<String, VendorTokenCQ> _myselfInScopeSubQueryMap;
        public Map<String, VendorTokenCQ> MyselfInScopeSubQuery { get { return _myselfInScopeSubQueryMap; } }
        public override String keepMyselfInScopeSubQuery(VendorTokenCQ subQuery) {
            if (_myselfInScopeSubQueryMap == null) { _myselfInScopeSubQueryMap = new LinkedHashMap<String, VendorTokenCQ>(); }
            String key = "subQueryMapKey" + (_myselfInScopeSubQueryMap.size() + 1);
            _myselfInScopeSubQueryMap.put(key, subQuery); return "MyselfInScopeSubQuery." + key;
        }
    }
}
