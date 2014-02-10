
using System;

using DfExample.DBFlute.AllCommon.CBean;
using DfExample.DBFlute.AllCommon.CBean.CValue;
using DfExample.DBFlute.AllCommon.CBean.SClause;
using DfExample.DBFlute.AllCommon.JavaLike;
using DfExample.DBFlute.CBean.CQ;
using DfExample.DBFlute.CBean.CQ.Ciq;

namespace DfExample.DBFlute.CBean.CQ.BS {

    [System.Serializable]
    public class BsWhiteCompoundPkRefCQ : AbstractBsWhiteCompoundPkRefCQ {

        protected WhiteCompoundPkRefCIQ _inlineQuery;

        public BsWhiteCompoundPkRefCQ(ConditionQuery childQuery, SqlClause sqlClause, String aliasName, int nestLevel)
            : base(childQuery, sqlClause, aliasName, nestLevel) {}

        public WhiteCompoundPkRefCIQ Inline() {
            if (_inlineQuery == null) {
                _inlineQuery = new WhiteCompoundPkRefCIQ(xgetReferrerQuery(), xgetSqlClause(), xgetAliasName(), xgetNestLevel(), this);
            }
            _inlineQuery.xsetOnClause(false);
            return _inlineQuery;
        }
        
        public WhiteCompoundPkRefCIQ On() {
            if (isBaseQuery()) { throw new UnsupportedOperationException("Unsupported onClause of Base Table!"); }
            WhiteCompoundPkRefCIQ inlineQuery = Inline();
            inlineQuery.xsetOnClause(true);
            return inlineQuery;
        }


        protected ConditionValue _multipleFirstId;
        public ConditionValue MultipleFirstId {
            get { if (_multipleFirstId == null) { _multipleFirstId = new ConditionValue(); } return _multipleFirstId; }
        }
        protected override ConditionValue getCValueMultipleFirstId() { return this.MultipleFirstId; }


        public BsWhiteCompoundPkRefCQ AddOrderBy_MultipleFirstId_Asc() { regOBA("MULTIPLE_FIRST_ID");return this; }
        public BsWhiteCompoundPkRefCQ AddOrderBy_MultipleFirstId_Desc() { regOBD("MULTIPLE_FIRST_ID");return this; }

        protected ConditionValue _multipleSecondId;
        public ConditionValue MultipleSecondId {
            get { if (_multipleSecondId == null) { _multipleSecondId = new ConditionValue(); } return _multipleSecondId; }
        }
        protected override ConditionValue getCValueMultipleSecondId() { return this.MultipleSecondId; }


        public BsWhiteCompoundPkRefCQ AddOrderBy_MultipleSecondId_Asc() { regOBA("MULTIPLE_SECOND_ID");return this; }
        public BsWhiteCompoundPkRefCQ AddOrderBy_MultipleSecondId_Desc() { regOBD("MULTIPLE_SECOND_ID");return this; }

        protected ConditionValue _refFirstId;
        public ConditionValue RefFirstId {
            get { if (_refFirstId == null) { _refFirstId = new ConditionValue(); } return _refFirstId; }
        }
        protected override ConditionValue getCValueRefFirstId() { return this.RefFirstId; }


        public BsWhiteCompoundPkRefCQ AddOrderBy_RefFirstId_Asc() { regOBA("REF_FIRST_ID");return this; }
        public BsWhiteCompoundPkRefCQ AddOrderBy_RefFirstId_Desc() { regOBD("REF_FIRST_ID");return this; }

        protected ConditionValue _refSecondId;
        public ConditionValue RefSecondId {
            get { if (_refSecondId == null) { _refSecondId = new ConditionValue(); } return _refSecondId; }
        }
        protected override ConditionValue getCValueRefSecondId() { return this.RefSecondId; }


        public BsWhiteCompoundPkRefCQ AddOrderBy_RefSecondId_Asc() { regOBA("REF_SECOND_ID");return this; }
        public BsWhiteCompoundPkRefCQ AddOrderBy_RefSecondId_Desc() { regOBD("REF_SECOND_ID");return this; }

        public BsWhiteCompoundPkRefCQ AddSpecifiedDerivedOrderBy_Asc(String aliasName) { registerSpecifiedDerivedOrderBy_Asc(aliasName); return this; }
        public BsWhiteCompoundPkRefCQ AddSpecifiedDerivedOrderBy_Desc(String aliasName) { registerSpecifiedDerivedOrderBy_Desc(aliasName); return this; }

        public override void reflectRelationOnUnionQuery(ConditionQuery baseQueryAsSuper, ConditionQuery unionQueryAsSuper) {
            WhiteCompoundPkRefCQ baseQuery = (WhiteCompoundPkRefCQ)baseQueryAsSuper;
            WhiteCompoundPkRefCQ unionQuery = (WhiteCompoundPkRefCQ)unionQueryAsSuper;
            if (baseQuery.hasConditionQueryWhiteCompoundPk()) {
                unionQuery.QueryWhiteCompoundPk().reflectRelationOnUnionQuery(baseQuery.QueryWhiteCompoundPk(), unionQuery.QueryWhiteCompoundPk());
            }

        }
    
        protected WhiteCompoundPkCQ _conditionQueryWhiteCompoundPk;
        public WhiteCompoundPkCQ QueryWhiteCompoundPk() {
            return this.ConditionQueryWhiteCompoundPk;
        }
        public WhiteCompoundPkCQ ConditionQueryWhiteCompoundPk {
            get {
                if (_conditionQueryWhiteCompoundPk == null) {
                    _conditionQueryWhiteCompoundPk = xcreateQueryWhiteCompoundPk();
                    xsetupOuterJoin_WhiteCompoundPk();
                }
                return _conditionQueryWhiteCompoundPk;
            }
        }
        protected WhiteCompoundPkCQ xcreateQueryWhiteCompoundPk() {
            String nrp = resolveNextRelationPathWhiteCompoundPk();
            String jan = resolveJoinAliasName(nrp, xgetNextNestLevel());
            WhiteCompoundPkCQ cq = new WhiteCompoundPkCQ(this, xgetSqlClause(), jan, xgetNextNestLevel());
            cq.xsetForeignPropertyName("whiteCompoundPk"); cq.xsetRelationPath(nrp); return cq;
        }
        public void xsetupOuterJoin_WhiteCompoundPk() {
            WhiteCompoundPkCQ cq = ConditionQueryWhiteCompoundPk;
            Map<String, String> joinOnMap = new LinkedHashMap<String, String>();
            joinOnMap.put("REF_FIRST_ID", "PK_FIRST_ID");
            joinOnMap.put("REF_SECOND_ID", "PK_SECOND_ID");
            registerOuterJoin(cq, joinOnMap);
        }
        protected String resolveNextRelationPathWhiteCompoundPk() {
            return resolveNextRelationPath("white_compound_pk_ref", "whiteCompoundPk");
        }
        public bool hasConditionQueryWhiteCompoundPk() {
            return _conditionQueryWhiteCompoundPk != null;
        }

    }
}
