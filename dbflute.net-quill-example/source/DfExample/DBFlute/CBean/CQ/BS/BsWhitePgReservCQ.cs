
using System;

using DfExample.DBFlute.AllCommon.CBean;
using DfExample.DBFlute.AllCommon.CBean.CValue;
using DfExample.DBFlute.AllCommon.CBean.SClause;
using DfExample.DBFlute.AllCommon.JavaLike;
using DfExample.DBFlute.CBean.CQ;
using DfExample.DBFlute.CBean.CQ.Ciq;

namespace DfExample.DBFlute.CBean.CQ.BS {

    [System.Serializable]
    public class BsWhitePgReservCQ : AbstractBsWhitePgReservCQ {

        protected WhitePgReservCIQ _inlineQuery;

        public BsWhitePgReservCQ(ConditionQuery childQuery, SqlClause sqlClause, String aliasName, int nestLevel)
            : base(childQuery, sqlClause, aliasName, nestLevel) {}

        public WhitePgReservCIQ Inline() {
            if (_inlineQuery == null) {
                _inlineQuery = new WhitePgReservCIQ(xgetReferrerQuery(), xgetSqlClause(), xgetAliasName(), xgetNestLevel(), this);
            }
            _inlineQuery.xsetOnClause(false);
            return _inlineQuery;
        }
        
        public WhitePgReservCIQ On() {
            if (isBaseQuery()) { throw new UnsupportedOperationException("Unsupported onClause of Base Table!"); }
            WhitePgReservCIQ inlineQuery = Inline();
            inlineQuery.xsetOnClause(true);
            return inlineQuery;
        }


        protected ConditionValue _classSynonym;
        public ConditionValue ClassSynonym {
            get { if (_classSynonym == null) { _classSynonym = new ConditionValue(); } return _classSynonym; }
        }
        protected override ConditionValue getCValueClassSynonym() { return this.ClassSynonym; }


        protected Map<String, WhitePgReservRefCQ> _classSynonym_ExistsSubQuery_WhitePgReservRefListMap;
        public Map<String, WhitePgReservRefCQ> ClassSynonym_ExistsSubQuery_WhitePgReservRefList { get { return _classSynonym_ExistsSubQuery_WhitePgReservRefListMap; }}
        public override String keepClassSynonym_ExistsSubQuery_WhitePgReservRefList(WhitePgReservRefCQ subQuery) {
            if (_classSynonym_ExistsSubQuery_WhitePgReservRefListMap == null) { _classSynonym_ExistsSubQuery_WhitePgReservRefListMap = new LinkedHashMap<String, WhitePgReservRefCQ>(); }
            String key = "subQueryMapKey" + (_classSynonym_ExistsSubQuery_WhitePgReservRefListMap.size() + 1);
            _classSynonym_ExistsSubQuery_WhitePgReservRefListMap.put(key, subQuery); return "ClassSynonym_ExistsSubQuery_WhitePgReservRefList." + key;
        }

        protected Map<String, WhitePgReservRefCQ> _classSynonym_NotExistsSubQuery_WhitePgReservRefListMap;
        public Map<String, WhitePgReservRefCQ> ClassSynonym_NotExistsSubQuery_WhitePgReservRefList { get { return _classSynonym_NotExistsSubQuery_WhitePgReservRefListMap; }}
        public override String keepClassSynonym_NotExistsSubQuery_WhitePgReservRefList(WhitePgReservRefCQ subQuery) {
            if (_classSynonym_NotExistsSubQuery_WhitePgReservRefListMap == null) { _classSynonym_NotExistsSubQuery_WhitePgReservRefListMap = new LinkedHashMap<String, WhitePgReservRefCQ>(); }
            String key = "subQueryMapKey" + (_classSynonym_NotExistsSubQuery_WhitePgReservRefListMap.size() + 1);
            _classSynonym_NotExistsSubQuery_WhitePgReservRefListMap.put(key, subQuery); return "ClassSynonym_NotExistsSubQuery_WhitePgReservRefList." + key;
        }

        protected Map<String, WhitePgReservRefCQ> _classSynonym_InScopeSubQuery_WhitePgReservRefListMap;
        public Map<String, WhitePgReservRefCQ> ClassSynonym_InScopeSubQuery_WhitePgReservRefList { get { return _classSynonym_InScopeSubQuery_WhitePgReservRefListMap; }}
        public override String keepClassSynonym_InScopeSubQuery_WhitePgReservRefList(WhitePgReservRefCQ subQuery) {
            if (_classSynonym_InScopeSubQuery_WhitePgReservRefListMap == null) { _classSynonym_InScopeSubQuery_WhitePgReservRefListMap = new LinkedHashMap<String, WhitePgReservRefCQ>(); }
            String key = "subQueryMapKey" + (_classSynonym_InScopeSubQuery_WhitePgReservRefListMap.size() + 1);
            _classSynonym_InScopeSubQuery_WhitePgReservRefListMap.put(key, subQuery); return "ClassSynonym_InScopeSubQuery_WhitePgReservRefList." + key;
        }

        protected Map<String, WhitePgReservRefCQ> _classSynonym_NotInScopeSubQuery_WhitePgReservRefListMap;
        public Map<String, WhitePgReservRefCQ> ClassSynonym_NotInScopeSubQuery_WhitePgReservRefList { get { return _classSynonym_NotInScopeSubQuery_WhitePgReservRefListMap; }}
        public override String keepClassSynonym_NotInScopeSubQuery_WhitePgReservRefList(WhitePgReservRefCQ subQuery) {
            if (_classSynonym_NotInScopeSubQuery_WhitePgReservRefListMap == null) { _classSynonym_NotInScopeSubQuery_WhitePgReservRefListMap = new LinkedHashMap<String, WhitePgReservRefCQ>(); }
            String key = "subQueryMapKey" + (_classSynonym_NotInScopeSubQuery_WhitePgReservRefListMap.size() + 1);
            _classSynonym_NotInScopeSubQuery_WhitePgReservRefListMap.put(key, subQuery); return "ClassSynonym_NotInScopeSubQuery_WhitePgReservRefList." + key;
        }

        protected Map<String, WhitePgReservRefCQ> _classSynonym_SpecifyDerivedReferrer_WhitePgReservRefListMap;
        public Map<String, WhitePgReservRefCQ> ClassSynonym_SpecifyDerivedReferrer_WhitePgReservRefList { get { return _classSynonym_SpecifyDerivedReferrer_WhitePgReservRefListMap; }}
        public override String keepClassSynonym_SpecifyDerivedReferrer_WhitePgReservRefList(WhitePgReservRefCQ subQuery) {
            if (_classSynonym_SpecifyDerivedReferrer_WhitePgReservRefListMap == null) { _classSynonym_SpecifyDerivedReferrer_WhitePgReservRefListMap = new LinkedHashMap<String, WhitePgReservRefCQ>(); }
            String key = "subQueryMapKey" + (_classSynonym_SpecifyDerivedReferrer_WhitePgReservRefListMap.size() + 1);
            _classSynonym_SpecifyDerivedReferrer_WhitePgReservRefListMap.put(key, subQuery); return "ClassSynonym_SpecifyDerivedReferrer_WhitePgReservRefList." + key;
        }

        protected Map<String, WhitePgReservRefCQ> _classSynonym_QueryDerivedReferrer_WhitePgReservRefListMap;
        public Map<String, WhitePgReservRefCQ> ClassSynonym_QueryDerivedReferrer_WhitePgReservRefList { get { return _classSynonym_QueryDerivedReferrer_WhitePgReservRefListMap; } }
        public override String keepClassSynonym_QueryDerivedReferrer_WhitePgReservRefList(WhitePgReservRefCQ subQuery) {
            if (_classSynonym_QueryDerivedReferrer_WhitePgReservRefListMap == null) { _classSynonym_QueryDerivedReferrer_WhitePgReservRefListMap = new LinkedHashMap<String, WhitePgReservRefCQ>(); }
            String key = "subQueryMapKey" + (_classSynonym_QueryDerivedReferrer_WhitePgReservRefListMap.size() + 1);
            _classSynonym_QueryDerivedReferrer_WhitePgReservRefListMap.put(key, subQuery); return "ClassSynonym_QueryDerivedReferrer_WhitePgReservRefList." + key;
        }
        protected Map<String, Object> _classSynonym_QueryDerivedReferrer_WhitePgReservRefListParameterMap;
        public Map<String, Object> ClassSynonym_QueryDerivedReferrer_WhitePgReservRefListParameter { get { return _classSynonym_QueryDerivedReferrer_WhitePgReservRefListParameterMap; } }
        public override String keepClassSynonym_QueryDerivedReferrer_WhitePgReservRefListParameter(Object parameterValue) {
            if (_classSynonym_QueryDerivedReferrer_WhitePgReservRefListParameterMap == null) { _classSynonym_QueryDerivedReferrer_WhitePgReservRefListParameterMap = new LinkedHashMap<String, Object>(); }
            String key = "subQueryParameterKey" + (_classSynonym_QueryDerivedReferrer_WhitePgReservRefListParameterMap.size() + 1);
            _classSynonym_QueryDerivedReferrer_WhitePgReservRefListParameterMap.put(key, parameterValue); return "ClassSynonym_QueryDerivedReferrer_WhitePgReservRefListParameter." + key;
        }

        public BsWhitePgReservCQ AddOrderBy_ClassSynonym_Asc() { regOBA("CLASS");return this; }
        public BsWhitePgReservCQ AddOrderBy_ClassSynonym_Desc() { regOBD("CLASS");return this; }

        protected ConditionValue _case;
        public ConditionValue Case {
            get { if (_case == null) { _case = new ConditionValue(); } return _case; }
        }
        protected override ConditionValue getCValueCase() { return this.Case; }


        public BsWhitePgReservCQ AddOrderBy_Case_Asc() { regOBA("CASE");return this; }
        public BsWhitePgReservCQ AddOrderBy_Case_Desc() { regOBD("CASE");return this; }

        protected ConditionValue _package;
        public ConditionValue Package {
            get { if (_package == null) { _package = new ConditionValue(); } return _package; }
        }
        protected override ConditionValue getCValuePackage() { return this.Package; }


        public BsWhitePgReservCQ AddOrderBy_Package_Asc() { regOBA("PACKAGE");return this; }
        public BsWhitePgReservCQ AddOrderBy_Package_Desc() { regOBD("PACKAGE");return this; }

        protected ConditionValue _default;
        public ConditionValue Default {
            get { if (_default == null) { _default = new ConditionValue(); } return _default; }
        }
        protected override ConditionValue getCValueDefault() { return this.Default; }


        public BsWhitePgReservCQ AddOrderBy_Default_Asc() { regOBA("DEFAULT");return this; }
        public BsWhitePgReservCQ AddOrderBy_Default_Desc() { regOBD("DEFAULT");return this; }

        protected ConditionValue _new;
        public ConditionValue New {
            get { if (_new == null) { _new = new ConditionValue(); } return _new; }
        }
        protected override ConditionValue getCValueNew() { return this.New; }


        public BsWhitePgReservCQ AddOrderBy_New_Asc() { regOBA("NEW");return this; }
        public BsWhitePgReservCQ AddOrderBy_New_Desc() { regOBD("NEW");return this; }

        protected ConditionValue _native;
        public ConditionValue Native {
            get { if (_native == null) { _native = new ConditionValue(); } return _native; }
        }
        protected override ConditionValue getCValueNative() { return this.Native; }


        public BsWhitePgReservCQ AddOrderBy_Native_Asc() { regOBA("NATIVE");return this; }
        public BsWhitePgReservCQ AddOrderBy_Native_Desc() { regOBD("NATIVE");return this; }

        protected ConditionValue _void;
        public ConditionValue Void {
            get { if (_void == null) { _void = new ConditionValue(); } return _void; }
        }
        protected override ConditionValue getCValueVoid() { return this.Void; }


        public BsWhitePgReservCQ AddOrderBy_Void_Asc() { regOBA("VOID");return this; }
        public BsWhitePgReservCQ AddOrderBy_Void_Desc() { regOBD("VOID");return this; }

        protected ConditionValue _public;
        public ConditionValue Public {
            get { if (_public == null) { _public = new ConditionValue(); } return _public; }
        }
        protected override ConditionValue getCValuePublic() { return this.Public; }


        public BsWhitePgReservCQ AddOrderBy_Public_Asc() { regOBA("PUBLIC");return this; }
        public BsWhitePgReservCQ AddOrderBy_Public_Desc() { regOBD("PUBLIC");return this; }

        protected ConditionValue _protected;
        public ConditionValue Protected {
            get { if (_protected == null) { _protected = new ConditionValue(); } return _protected; }
        }
        protected override ConditionValue getCValueProtected() { return this.Protected; }


        public BsWhitePgReservCQ AddOrderBy_Protected_Asc() { regOBA("PROTECTED");return this; }
        public BsWhitePgReservCQ AddOrderBy_Protected_Desc() { regOBD("PROTECTED");return this; }

        protected ConditionValue _private;
        public ConditionValue Private {
            get { if (_private == null) { _private = new ConditionValue(); } return _private; }
        }
        protected override ConditionValue getCValuePrivate() { return this.Private; }


        public BsWhitePgReservCQ AddOrderBy_Private_Asc() { regOBA("PRIVATE");return this; }
        public BsWhitePgReservCQ AddOrderBy_Private_Desc() { regOBD("PRIVATE");return this; }

        protected ConditionValue _interface;
        public ConditionValue Interface {
            get { if (_interface == null) { _interface = new ConditionValue(); } return _interface; }
        }
        protected override ConditionValue getCValueInterface() { return this.Interface; }


        public BsWhitePgReservCQ AddOrderBy_Interface_Asc() { regOBA("INTERFACE");return this; }
        public BsWhitePgReservCQ AddOrderBy_Interface_Desc() { regOBD("INTERFACE");return this; }

        protected ConditionValue _abstract;
        public ConditionValue Abstract {
            get { if (_abstract == null) { _abstract = new ConditionValue(); } return _abstract; }
        }
        protected override ConditionValue getCValueAbstract() { return this.Abstract; }


        public BsWhitePgReservCQ AddOrderBy_Abstract_Asc() { regOBA("ABSTRACT");return this; }
        public BsWhitePgReservCQ AddOrderBy_Abstract_Desc() { regOBD("ABSTRACT");return this; }

        protected ConditionValue _final;
        public ConditionValue Final {
            get { if (_final == null) { _final = new ConditionValue(); } return _final; }
        }
        protected override ConditionValue getCValueFinal() { return this.Final; }


        public BsWhitePgReservCQ AddOrderBy_Final_Asc() { regOBA("FINAL");return this; }
        public BsWhitePgReservCQ AddOrderBy_Final_Desc() { regOBD("FINAL");return this; }

        protected ConditionValue _finally;
        public ConditionValue Finally {
            get { if (_finally == null) { _finally = new ConditionValue(); } return _finally; }
        }
        protected override ConditionValue getCValueFinally() { return this.Finally; }


        public BsWhitePgReservCQ AddOrderBy_Finally_Asc() { regOBA("FINALLY");return this; }
        public BsWhitePgReservCQ AddOrderBy_Finally_Desc() { regOBD("FINALLY");return this; }

        protected ConditionValue _return;
        public ConditionValue Return {
            get { if (_return == null) { _return = new ConditionValue(); } return _return; }
        }
        protected override ConditionValue getCValueReturn() { return this.Return; }


        public BsWhitePgReservCQ AddOrderBy_Return_Asc() { regOBA("RETURN");return this; }
        public BsWhitePgReservCQ AddOrderBy_Return_Desc() { regOBD("RETURN");return this; }

        protected ConditionValue _double;
        public ConditionValue Double {
            get { if (_double == null) { _double = new ConditionValue(); } return _double; }
        }
        protected override ConditionValue getCValueDouble() { return this.Double; }


        public BsWhitePgReservCQ AddOrderBy_Double_Asc() { regOBA("DOUBLE");return this; }
        public BsWhitePgReservCQ AddOrderBy_Double_Desc() { regOBD("DOUBLE");return this; }

        protected ConditionValue _float;
        public ConditionValue Float {
            get { if (_float == null) { _float = new ConditionValue(); } return _float; }
        }
        protected override ConditionValue getCValueFloat() { return this.Float; }


        public BsWhitePgReservCQ AddOrderBy_Float_Asc() { regOBA("FLOAT");return this; }
        public BsWhitePgReservCQ AddOrderBy_Float_Desc() { regOBD("FLOAT");return this; }

        protected ConditionValue _short;
        public ConditionValue Short {
            get { if (_short == null) { _short = new ConditionValue(); } return _short; }
        }
        protected override ConditionValue getCValueShort() { return this.Short; }


        public BsWhitePgReservCQ AddOrderBy_Short_Asc() { regOBA("SHORT");return this; }
        public BsWhitePgReservCQ AddOrderBy_Short_Desc() { regOBD("SHORT");return this; }

        protected ConditionValue _type;
        public ConditionValue Type {
            get { if (_type == null) { _type = new ConditionValue(); } return _type; }
        }
        protected override ConditionValue getCValueType() { return this.Type; }


        public BsWhitePgReservCQ AddOrderBy_Type_Asc() { regOBA("TYPE");return this; }
        public BsWhitePgReservCQ AddOrderBy_Type_Desc() { regOBD("TYPE");return this; }

        protected ConditionValue _reservName;
        public ConditionValue ReservName {
            get { if (_reservName == null) { _reservName = new ConditionValue(); } return _reservName; }
        }
        protected override ConditionValue getCValueReservName() { return this.ReservName; }


        public BsWhitePgReservCQ AddOrderBy_ReservName_Asc() { regOBA("RESERV_NAME");return this; }
        public BsWhitePgReservCQ AddOrderBy_ReservName_Desc() { regOBD("RESERV_NAME");return this; }

        public BsWhitePgReservCQ AddSpecifiedDerivedOrderBy_Asc(String aliasName) { registerSpecifiedDerivedOrderBy_Asc(aliasName); return this; }
        public BsWhitePgReservCQ AddSpecifiedDerivedOrderBy_Desc(String aliasName) { registerSpecifiedDerivedOrderBy_Desc(aliasName); return this; }

        public override void reflectRelationOnUnionQuery(ConditionQuery baseQueryAsSuper, ConditionQuery unionQueryAsSuper) {

        }
    


	    // ===============================================================================
	    //                                                                 Scalar SubQuery
	    //                                                                 ===============
	    protected Map<String, WhitePgReservCQ> _scalarSubQueryMap;
	    public Map<String, WhitePgReservCQ> ScalarSubQuery { get { return _scalarSubQueryMap; } }
	    public override String keepScalarSubQuery(WhitePgReservCQ subQuery) {
	        if (_scalarSubQueryMap == null) { _scalarSubQueryMap = new LinkedHashMap<String, WhitePgReservCQ>(); }
	        String key = "subQueryMapKey" + (_scalarSubQueryMap.size() + 1);
	        _scalarSubQueryMap.put(key, subQuery); return "ScalarSubQuery." + key;
	    }

        // ===============================================================================
        //                                                         Myself InScope SubQuery
        //                                                         =======================
        protected Map<String, WhitePgReservCQ> _myselfInScopeSubQueryMap;
        public Map<String, WhitePgReservCQ> MyselfInScopeSubQuery { get { return _myselfInScopeSubQueryMap; } }
        public override String keepMyselfInScopeSubQuery(WhitePgReservCQ subQuery) {
            if (_myselfInScopeSubQueryMap == null) { _myselfInScopeSubQueryMap = new LinkedHashMap<String, WhitePgReservCQ>(); }
            String key = "subQueryMapKey" + (_myselfInScopeSubQueryMap.size() + 1);
            _myselfInScopeSubQueryMap.put(key, subQuery); return "MyselfInScopeSubQuery." + key;
        }
    }
}
