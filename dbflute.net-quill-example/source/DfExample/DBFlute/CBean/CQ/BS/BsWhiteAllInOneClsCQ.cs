
using System;

using DfExample.DBFlute.AllCommon.CBean;
using DfExample.DBFlute.AllCommon.CBean.CValue;
using DfExample.DBFlute.AllCommon.CBean.SClause;
using DfExample.DBFlute.AllCommon.JavaLike;
using DfExample.DBFlute.CBean.CQ;
using DfExample.DBFlute.CBean.CQ.Ciq;

namespace DfExample.DBFlute.CBean.CQ.BS {

    [System.Serializable]
    public class BsWhiteAllInOneClsCQ : AbstractBsWhiteAllInOneClsCQ {

        protected WhiteAllInOneClsCIQ _inlineQuery;

        public BsWhiteAllInOneClsCQ(ConditionQuery childQuery, SqlClause sqlClause, String aliasName, int nestLevel)
            : base(childQuery, sqlClause, aliasName, nestLevel) {}

        public WhiteAllInOneClsCIQ Inline() {
            if (_inlineQuery == null) {
                _inlineQuery = new WhiteAllInOneClsCIQ(xgetReferrerQuery(), xgetSqlClause(), xgetAliasName(), xgetNestLevel(), this);
            }
            _inlineQuery.xsetOnClause(false);
            return _inlineQuery;
        }
        
        public WhiteAllInOneClsCIQ On() {
            if (isBaseQuery()) { throw new UnsupportedOperationException("Unsupported onClause of Base Table!"); }
            WhiteAllInOneClsCIQ inlineQuery = Inline();
            inlineQuery.xsetOnClause(true);
            return inlineQuery;
        }


        protected ConditionValue _clsCategoryCode;
        public ConditionValue ClsCategoryCode {
            get { if (_clsCategoryCode == null) { _clsCategoryCode = new ConditionValue(); } return _clsCategoryCode; }
        }
        protected override ConditionValue getCValueClsCategoryCode() { return this.ClsCategoryCode; }


        public BsWhiteAllInOneClsCQ AddOrderBy_ClsCategoryCode_Asc() { regOBA("CLS_CATEGORY_CODE");return this; }
        public BsWhiteAllInOneClsCQ AddOrderBy_ClsCategoryCode_Desc() { regOBD("CLS_CATEGORY_CODE");return this; }

        protected ConditionValue _clsElementCode;
        public ConditionValue ClsElementCode {
            get { if (_clsElementCode == null) { _clsElementCode = new ConditionValue(); } return _clsElementCode; }
        }
        protected override ConditionValue getCValueClsElementCode() { return this.ClsElementCode; }


        public BsWhiteAllInOneClsCQ AddOrderBy_ClsElementCode_Asc() { regOBA("CLS_ELEMENT_CODE");return this; }
        public BsWhiteAllInOneClsCQ AddOrderBy_ClsElementCode_Desc() { regOBD("CLS_ELEMENT_CODE");return this; }

        protected ConditionValue _attributeExp;
        public ConditionValue AttributeExp {
            get { if (_attributeExp == null) { _attributeExp = new ConditionValue(); } return _attributeExp; }
        }
        protected override ConditionValue getCValueAttributeExp() { return this.AttributeExp; }


        public BsWhiteAllInOneClsCQ AddOrderBy_AttributeExp_Asc() { regOBA("ATTRIBUTE_EXP");return this; }
        public BsWhiteAllInOneClsCQ AddOrderBy_AttributeExp_Desc() { regOBD("ATTRIBUTE_EXP");return this; }

        public BsWhiteAllInOneClsCQ AddSpecifiedDerivedOrderBy_Asc(String aliasName) { registerSpecifiedDerivedOrderBy_Asc(aliasName); return this; }
        public BsWhiteAllInOneClsCQ AddSpecifiedDerivedOrderBy_Desc(String aliasName) { registerSpecifiedDerivedOrderBy_Desc(aliasName); return this; }

        public override void reflectRelationOnUnionQuery(ConditionQuery baseQueryAsSuper, ConditionQuery unionQueryAsSuper) {

        }
    

    }
}
