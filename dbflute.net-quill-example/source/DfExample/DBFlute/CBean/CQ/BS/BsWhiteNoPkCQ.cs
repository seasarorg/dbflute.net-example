
using System;

using DfExample.DBFlute.AllCommon.CBean;
using DfExample.DBFlute.AllCommon.CBean.CValue;
using DfExample.DBFlute.AllCommon.CBean.SClause;
using DfExample.DBFlute.AllCommon.JavaLike;
using DfExample.DBFlute.CBean.CQ;
using DfExample.DBFlute.CBean.CQ.Ciq;

namespace DfExample.DBFlute.CBean.CQ.BS {

    [System.Serializable]
    public class BsWhiteNoPkCQ : AbstractBsWhiteNoPkCQ {

        protected WhiteNoPkCIQ _inlineQuery;

        public BsWhiteNoPkCQ(ConditionQuery childQuery, SqlClause sqlClause, String aliasName, int nestLevel)
            : base(childQuery, sqlClause, aliasName, nestLevel) {}

        public WhiteNoPkCIQ Inline() {
            if (_inlineQuery == null) {
                _inlineQuery = new WhiteNoPkCIQ(xgetReferrerQuery(), xgetSqlClause(), xgetAliasName(), xgetNestLevel(), this);
            }
            _inlineQuery.xsetOnClause(false);
            return _inlineQuery;
        }
        
        public WhiteNoPkCIQ On() {
            if (isBaseQuery()) { throw new UnsupportedOperationException("Unsupported onClause of Base Table!"); }
            WhiteNoPkCIQ inlineQuery = Inline();
            inlineQuery.xsetOnClause(true);
            return inlineQuery;
        }


        protected ConditionValue _noPkId;
        public ConditionValue NoPkId {
            get { if (_noPkId == null) { _noPkId = new ConditionValue(); } return _noPkId; }
        }
        protected override ConditionValue getCValueNoPkId() { return this.NoPkId; }


        public BsWhiteNoPkCQ AddOrderBy_NoPkId_Asc() { regOBA("NO_PK_ID");return this; }
        public BsWhiteNoPkCQ AddOrderBy_NoPkId_Desc() { regOBD("NO_PK_ID");return this; }

        protected ConditionValue _noPkName;
        public ConditionValue NoPkName {
            get { if (_noPkName == null) { _noPkName = new ConditionValue(); } return _noPkName; }
        }
        protected override ConditionValue getCValueNoPkName() { return this.NoPkName; }


        public BsWhiteNoPkCQ AddOrderBy_NoPkName_Asc() { regOBA("NO_PK_NAME");return this; }
        public BsWhiteNoPkCQ AddOrderBy_NoPkName_Desc() { regOBD("NO_PK_NAME");return this; }

        protected ConditionValue _noPkInteger;
        public ConditionValue NoPkInteger {
            get { if (_noPkInteger == null) { _noPkInteger = new ConditionValue(); } return _noPkInteger; }
        }
        protected override ConditionValue getCValueNoPkInteger() { return this.NoPkInteger; }


        public BsWhiteNoPkCQ AddOrderBy_NoPkInteger_Asc() { regOBA("NO_PK_INTEGER");return this; }
        public BsWhiteNoPkCQ AddOrderBy_NoPkInteger_Desc() { regOBD("NO_PK_INTEGER");return this; }

        public BsWhiteNoPkCQ AddSpecifiedDerivedOrderBy_Asc(String aliasName) { registerSpecifiedDerivedOrderBy_Asc(aliasName); return this; }
        public BsWhiteNoPkCQ AddSpecifiedDerivedOrderBy_Desc(String aliasName) { registerSpecifiedDerivedOrderBy_Desc(aliasName); return this; }

        public override void reflectRelationOnUnionQuery(ConditionQuery baseQueryAsSuper, ConditionQuery unionQueryAsSuper) {

        }
    

    }
}
