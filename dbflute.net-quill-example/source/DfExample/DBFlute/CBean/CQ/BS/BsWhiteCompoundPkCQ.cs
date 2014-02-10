
using System;

using DfExample.DBFlute.AllCommon.CBean;
using DfExample.DBFlute.AllCommon.CBean.CValue;
using DfExample.DBFlute.AllCommon.CBean.SClause;
using DfExample.DBFlute.AllCommon.JavaLike;
using DfExample.DBFlute.CBean.CQ;
using DfExample.DBFlute.CBean.CQ.Ciq;

namespace DfExample.DBFlute.CBean.CQ.BS {

    [System.Serializable]
    public class BsWhiteCompoundPkCQ : AbstractBsWhiteCompoundPkCQ {

        protected WhiteCompoundPkCIQ _inlineQuery;

        public BsWhiteCompoundPkCQ(ConditionQuery childQuery, SqlClause sqlClause, String aliasName, int nestLevel)
            : base(childQuery, sqlClause, aliasName, nestLevel) {}

        public WhiteCompoundPkCIQ Inline() {
            if (_inlineQuery == null) {
                _inlineQuery = new WhiteCompoundPkCIQ(xgetReferrerQuery(), xgetSqlClause(), xgetAliasName(), xgetNestLevel(), this);
            }
            _inlineQuery.xsetOnClause(false);
            return _inlineQuery;
        }
        
        public WhiteCompoundPkCIQ On() {
            if (isBaseQuery()) { throw new UnsupportedOperationException("Unsupported onClause of Base Table!"); }
            WhiteCompoundPkCIQ inlineQuery = Inline();
            inlineQuery.xsetOnClause(true);
            return inlineQuery;
        }


        protected ConditionValue _pkFirstId;
        public ConditionValue PkFirstId {
            get { if (_pkFirstId == null) { _pkFirstId = new ConditionValue(); } return _pkFirstId; }
        }
        protected override ConditionValue getCValuePkFirstId() { return this.PkFirstId; }


        public BsWhiteCompoundPkCQ AddOrderBy_PkFirstId_Asc() { regOBA("PK_FIRST_ID");return this; }
        public BsWhiteCompoundPkCQ AddOrderBy_PkFirstId_Desc() { regOBD("PK_FIRST_ID");return this; }

        protected ConditionValue _pkSecondId;
        public ConditionValue PkSecondId {
            get { if (_pkSecondId == null) { _pkSecondId = new ConditionValue(); } return _pkSecondId; }
        }
        protected override ConditionValue getCValuePkSecondId() { return this.PkSecondId; }


        public BsWhiteCompoundPkCQ AddOrderBy_PkSecondId_Asc() { regOBA("PK_SECOND_ID");return this; }
        public BsWhiteCompoundPkCQ AddOrderBy_PkSecondId_Desc() { regOBD("PK_SECOND_ID");return this; }

        protected ConditionValue _pkName;
        public ConditionValue PkName {
            get { if (_pkName == null) { _pkName = new ConditionValue(); } return _pkName; }
        }
        protected override ConditionValue getCValuePkName() { return this.PkName; }


        public BsWhiteCompoundPkCQ AddOrderBy_PkName_Asc() { regOBA("PK_NAME");return this; }
        public BsWhiteCompoundPkCQ AddOrderBy_PkName_Desc() { regOBD("PK_NAME");return this; }

        public BsWhiteCompoundPkCQ AddSpecifiedDerivedOrderBy_Asc(String aliasName) { registerSpecifiedDerivedOrderBy_Asc(aliasName); return this; }
        public BsWhiteCompoundPkCQ AddSpecifiedDerivedOrderBy_Desc(String aliasName) { registerSpecifiedDerivedOrderBy_Desc(aliasName); return this; }

        public override void reflectRelationOnUnionQuery(ConditionQuery baseQueryAsSuper, ConditionQuery unionQueryAsSuper) {

        }
    

    }
}
