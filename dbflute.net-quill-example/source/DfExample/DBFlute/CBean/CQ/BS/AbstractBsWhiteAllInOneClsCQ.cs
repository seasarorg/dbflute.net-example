
using System;
using System.Collections.Generic;

using DfExample.DBFlute.AllCommon;
using DfExample.DBFlute.AllCommon.CBean;
using DfExample.DBFlute.AllCommon.CBean.CKey;
using DfExample.DBFlute.AllCommon.CBean.COption;
using DfExample.DBFlute.AllCommon.CBean.CValue;
using DfExample.DBFlute.AllCommon.CBean.SClause;

namespace DfExample.DBFlute.CBean.CQ.BS {

    [System.Serializable]
    public abstract class AbstractBsWhiteAllInOneClsCQ : AbstractConditionQuery {

        public AbstractBsWhiteAllInOneClsCQ(ConditionQuery childQuery, SqlClause sqlClause, String aliasName, int nestLevel)
            : base(childQuery, sqlClause, aliasName, nestLevel) {}

        public override String getTableDbName() { return "white_all_in_one_cls"; }
        public override String getTableSqlName() { return "white_all_in_one_cls"; }

        public void SetClsCategoryCode_Equal(String v) { DoSetClsCategoryCode_Equal(fRES(v)); }
        protected void DoSetClsCategoryCode_Equal(String v) { regClsCategoryCode(CK_EQ, v); }
        public void SetClsCategoryCode_NotEqual(String v) { DoSetClsCategoryCode_NotEqual(fRES(v)); }
        protected void DoSetClsCategoryCode_NotEqual(String v) { regClsCategoryCode(CK_NES, v); }
        public void SetClsCategoryCode_InScope(IList<String> ls) { regINS<String>(CK_INS, cTL<String>(ls), getCValueClsCategoryCode(), "CLS_CATEGORY_CODE"); }
        public void SetClsCategoryCode_NotInScope(IList<String> ls) { regINS<String>(CK_NINS, cTL<String>(ls), getCValueClsCategoryCode(), "CLS_CATEGORY_CODE"); }
        public void SetClsCategoryCode_PrefixSearch(String v) { SetClsCategoryCode_LikeSearch(v, cLSOP()); }
        public void SetClsCategoryCode_LikeSearch(String v, LikeSearchOption option)
        { regLSQ(CK_LS, fRES(v), getCValueClsCategoryCode(), "CLS_CATEGORY_CODE", option); }
        public void SetClsCategoryCode_NotLikeSearch(String v, LikeSearchOption option)
        { regLSQ(CK_NLS, fRES(v), getCValueClsCategoryCode(), "CLS_CATEGORY_CODE", option); }
        public void SetClsCategoryCode_IsNull() { regClsCategoryCode(CK_ISN, DUMMY_OBJECT); }
        public void SetClsCategoryCode_IsNotNull() { regClsCategoryCode(CK_ISNN, DUMMY_OBJECT); }
        protected void regClsCategoryCode(ConditionKey k, Object v) { regQ(k, v, getCValueClsCategoryCode(), "CLS_CATEGORY_CODE"); }
        protected abstract ConditionValue getCValueClsCategoryCode();

        public void SetClsElementCode_Equal(String v) { DoSetClsElementCode_Equal(fRES(v)); }
        protected void DoSetClsElementCode_Equal(String v) { regClsElementCode(CK_EQ, v); }
        public void SetClsElementCode_NotEqual(String v) { DoSetClsElementCode_NotEqual(fRES(v)); }
        protected void DoSetClsElementCode_NotEqual(String v) { regClsElementCode(CK_NES, v); }
        public void SetClsElementCode_InScope(IList<String> ls) { regINS<String>(CK_INS, cTL<String>(ls), getCValueClsElementCode(), "CLS_ELEMENT_CODE"); }
        public void SetClsElementCode_NotInScope(IList<String> ls) { regINS<String>(CK_NINS, cTL<String>(ls), getCValueClsElementCode(), "CLS_ELEMENT_CODE"); }
        public void SetClsElementCode_PrefixSearch(String v) { SetClsElementCode_LikeSearch(v, cLSOP()); }
        public void SetClsElementCode_LikeSearch(String v, LikeSearchOption option)
        { regLSQ(CK_LS, fRES(v), getCValueClsElementCode(), "CLS_ELEMENT_CODE", option); }
        public void SetClsElementCode_NotLikeSearch(String v, LikeSearchOption option)
        { regLSQ(CK_NLS, fRES(v), getCValueClsElementCode(), "CLS_ELEMENT_CODE", option); }
        public void SetClsElementCode_IsNull() { regClsElementCode(CK_ISN, DUMMY_OBJECT); }
        public void SetClsElementCode_IsNotNull() { regClsElementCode(CK_ISNN, DUMMY_OBJECT); }
        protected void regClsElementCode(ConditionKey k, Object v) { regQ(k, v, getCValueClsElementCode(), "CLS_ELEMENT_CODE"); }
        protected abstract ConditionValue getCValueClsElementCode();

        public void SetAttributeExp_Equal(String v) { DoSetAttributeExp_Equal(fRES(v)); }
        protected void DoSetAttributeExp_Equal(String v) { regAttributeExp(CK_EQ, v); }
        public void SetAttributeExp_NotEqual(String v) { DoSetAttributeExp_NotEqual(fRES(v)); }
        protected void DoSetAttributeExp_NotEqual(String v) { regAttributeExp(CK_NES, v); }
        public void SetAttributeExp_InScope(IList<String> ls) { regINS<String>(CK_INS, cTL<String>(ls), getCValueAttributeExp(), "ATTRIBUTE_EXP"); }
        public void SetAttributeExp_NotInScope(IList<String> ls) { regINS<String>(CK_NINS, cTL<String>(ls), getCValueAttributeExp(), "ATTRIBUTE_EXP"); }
        public void SetAttributeExp_PrefixSearch(String v) { SetAttributeExp_LikeSearch(v, cLSOP()); }
        public void SetAttributeExp_LikeSearch(String v, LikeSearchOption option)
        { regLSQ(CK_LS, fRES(v), getCValueAttributeExp(), "ATTRIBUTE_EXP", option); }
        public void SetAttributeExp_NotLikeSearch(String v, LikeSearchOption option)
        { regLSQ(CK_NLS, fRES(v), getCValueAttributeExp(), "ATTRIBUTE_EXP", option); }
        protected void regAttributeExp(ConditionKey k, Object v) { regQ(k, v, getCValueAttributeExp(), "ATTRIBUTE_EXP"); }
        protected abstract ConditionValue getCValueAttributeExp();

        public override String ToString() { return xgetSqlClause().getClause(); }
    }
}
