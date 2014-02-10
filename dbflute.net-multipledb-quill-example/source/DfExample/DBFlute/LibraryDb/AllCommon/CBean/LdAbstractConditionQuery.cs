
using System;
using System.Reflection;

using DfExample.DBFlute.LibraryDb.AllCommon.CBean.CKey;
using DfExample.DBFlute.LibraryDb.AllCommon.CBean.CHelper;
using DfExample.DBFlute.LibraryDb.AllCommon.CBean.COption;
using DfExample.DBFlute.LibraryDb.AllCommon.CBean.CValue;
using DfExample.DBFlute.LibraryDb.AllCommon.Dbm;
using DfExample.DBFlute.LibraryDb.AllCommon.Dbm.Info;
using DfExample.DBFlute.LibraryDb.AllCommon.Exp;
using DfExample.DBFlute.LibraryDb.AllCommon.CBean.SClause;
using DfExample.DBFlute.LibraryDb.AllCommon.JavaLike;
using DfExample.DBFlute.LibraryDb.AllCommon.Util;

namespace DfExample.DBFlute.LibraryDb.AllCommon.CBean {

// JavaLike
[System.Serializable]
public abstract class LdAbstractConditionQuery : LdConditionQuery {

    // ===================================================================================
    //                                                                          Definition
    //                                                                          ==========
    protected static readonly LdConditionKey CK_EQ = LdConditionKey.CK_EQUAL;
    protected static readonly LdConditionKey CK_NES = LdConditionKey.CK_NOT_EQUAL_STANDARD;
    protected static readonly LdConditionKey CK_NET = LdConditionKey.CK_NOT_EQUAL_TRADITION;
    protected static readonly LdConditionKey CK_GE = LdConditionKey.CK_GREATER_EQUAL;
    protected static readonly LdConditionKey CK_GT = LdConditionKey.CK_GREATER_THAN;
    protected static readonly LdConditionKey CK_LE = LdConditionKey.CK_LESS_EQUAL;
    protected static readonly LdConditionKey CK_LT = LdConditionKey.CK_LESS_THAN;
    protected static readonly LdConditionKey CK_INS = LdConditionKey.CK_IN_SCOPE;
    protected static readonly LdConditionKey CK_NINS = LdConditionKey.CK_NOT_IN_SCOPE;
    protected static readonly LdConditionKey CK_LS = LdConditionKey.CK_LIKE_SEARCH;
    protected static readonly LdConditionKey CK_NLS = LdConditionKey.CK_NOT_LIKE_SEARCH;
    protected static readonly LdConditionKey CK_ISN = LdConditionKey.CK_IS_NULL;
    protected static readonly LdConditionKey CK_ISNN = LdConditionKey.CK_IS_NOT_NULL;

    protected static readonly LdConditionValue DUMMY_CONDITION_VALUE = new LdConditionValue();
    protected static readonly Object DUMMY_OBJECT = new Object();
	protected static readonly String CQ_PROPERTY = "ConditionQuery";
	
    // ===================================================================================
    //                                                                           Attribute
    //                                                                           =========
    protected readonly LdSqlClause _sqlClause;
    protected readonly String _aliasName;
    protected readonly int _nestLevel;
	protected int _subQueryLevel;

    // -----------------------------------------------------
    //                                          Foreign Info
    //                                          ------------
    protected String _foreignPropertyName;
    protected String _relationPath;
    protected readonly LdConditionQuery _referrerQuery;

    // -----------------------------------------------------
    //                                                Inline
    //                                                ------
	protected bool _onClause;

    // ===================================================================================
    //                                                                         Constructor
    //                                                                         ===========
    public LdAbstractConditionQuery(LdConditionQuery childQuery, LdSqlClause sqlClause, String aliasName, int nestLevel) {
        _referrerQuery = childQuery;
        _sqlClause = sqlClause;
        _aliasName = aliasName;
        _nestLevel = nestLevel;
    }

    // ===================================================================================
    //                                                                     DBMeta Provider
    //                                                                     ===============
    protected DBMetaProvider xgetDBMetaProvider() {
        return LdDBMetaInstanceHandler.getProvider();
    }

    protected LdDBMeta findDBMeta(String tableFlexibleName) {
        return LdDBMetaInstanceHandler.FindDBMeta(tableFlexibleName);
    }

    // ===================================================================================
    //                                                                          Table Name
    //                                                                          ==========
    public abstract String getTableDbName();
    public abstract String getTableSqlName();

    // ===================================================================================
    //                                                                  Important Accessor
    //                                                                  ==================
    public LdConditionQuery xgetReferrerQuery() {
        return _referrerQuery;
    }

    public LdSqlClause xgetSqlClause() {
        return _sqlClause;
    }

    public String xgetAliasName() {
        return _aliasName;
    }

    public int xgetNestLevel() {
        return _nestLevel;
    }

    public int xgetNextNestLevel() {
        return _nestLevel+1;
    }

    public bool isBaseQuery() {
        return (xgetReferrerQuery() == null);
    }

    // -----------------------------------------------------
    //                                             Real Name
    //                                             ---------
    public String toColumnRealName(String columnDbName) {
        assertColumnName(columnDbName);
        return buildRealColumnName(xgetAliasName(), toColumnSqlName(columnDbName));
    }

	protected String buildRealColumnName(String aliasName, String columnDbName) {
        return aliasName + "." + columnDbName;
    }

    public String toColumnSqlName(String columnDbName) {
        return findDBMeta(getTableDbName()).FindColumnInfo(columnDbName).ColumnSqlName;
    }

    // -----------------------------------------------------
    //                                          Foreign Info
    //                                          ------------
    public String xgetForeignPropertyName() {
        return _foreignPropertyName;
    }

    public void xsetForeignPropertyName(String foreignPropertyName) {
        this._foreignPropertyName = foreignPropertyName;
    }

    public String xgetRelationPath() {
        return _relationPath;
    }

    public void xsetRelationPath(String relationPath) {
        this._relationPath = relationPath;
    }

    // -----------------------------------------------------
    //                                                Inline
    //                                                ------
	public void xsetOnClause(bool onClause) {
	    _onClause = onClause;
	}

    // -----------------------------------------------------
    //                                              Location
    //                                              --------
    public String xgetLocationBase() {
        StringBuilder sb = new StringBuilder();
        LdConditionQuery query = this;
        while (true) {
            if (query.isBaseQuery()) {
                sb.insert(0, CQ_PROPERTY + ".");
                break;
            } else {
                String foreignPropertyName = query.xgetForeignPropertyName();
                if (foreignPropertyName == null) {
                    String msg = "The foreignPropertyName of the query should not be null:";
                    msg = msg + " query=" + query;
                    throw new IllegalStateException(msg);
                }
                sb.insert(0, CQ_PROPERTY + initCap(foreignPropertyName) + ".");
            }
            query = query.xgetReferrerQuery();
        }
        return sb.toString();
    }

    protected String getLocation(String columnPropertyName, LdConditionKey key) {
        return xgetLocationBase(columnPropertyName) + "." + key.getConditionKey();
    }

    protected String xgetLocationBase(String columnPropertyName) {
        return xgetLocationBase() + columnPropertyName;
    }

    // ===================================================================================
    //                                                                  Nested SetupSelect
    //                                                                  ==================
    public void doNss(NssCall callback) { // Very Internal
        String foreignPropertyName = callback.Invoke().xgetForeignPropertyName();
        String foreignTableAliasName = callback.Invoke().xgetAliasName();
        xgetSqlClause().registerSelectedSelectColumn(foreignTableAliasName, getTableDbName(), foreignPropertyName, xgetRelationPath());
        xgetSqlClause().registerSelectedForeignInfo(callback.Invoke().xgetRelationPath(), foreignPropertyName);
    }
    
    public delegate LdConditionQuery NssCall(); // Very Internal

    // ===================================================================================
    //                                                                           OuterJoin
    //                                                                           =========
    protected virtual void registerOuterJoin(LdConditionQuery foreignCQ, Map<String, String> joinOnResourceMap) {
        registerOuterJoin(foreignCQ, joinOnResourceMap, null);
    }

    protected virtual void registerOuterJoin(LdConditionQuery foreignCQ, Map<String, String> joinOnResourceMap, String fixedCondition) {
        // translate join-on map using column real name
        Map<String, String> joinOnMap = new LinkedHashMap<String, String>();
        Set<Entry<String, String>> entrySet = joinOnResourceMap.entrySet();
        foreach (Entry<String, String> entry in entrySet) {
            String local = entry.getKey();
            String foreign = entry.getValue();
            joinOnMap.put(toColumnRealName(local), foreignCQ.toColumnRealName(foreign));
        }
        String localDbName = getTableDbName();
        String foreignDbName = foreignCQ.getTableDbName();
        String foreignAliasName = foreignCQ.xgetAliasName();
        FixedConditionResolver resolver = createFixedConditionResolver(foreignCQ, joinOnMap);
        xgetSqlClause().registerOuterJoin(localDbName, foreignDbName, foreignAliasName, joinOnMap, fixedCondition, resolver);
    }

    protected FixedConditionResolver createFixedConditionResolver(LdConditionQuery foreignCQ,
            Map<String, String> joinOnMap) {
        return new LdHpFixedConditionQueryResolver(this, foreignCQ, xgetDBMetaProvider());
    }

    // ===================================================================================
    //                                                                         Union Query
    //                                                                         ===========
    protected Map<String, LdConditionQuery> _unionQueryMap;

    public Map<String, LdConditionQuery> getUnionQueryMap() {// for Internal
		if (_unionQueryMap == null) {
		    _unionQueryMap = new LinkedHashMap<String, LdConditionQuery>();
		}
        return _unionQueryMap;
    }

	public Map<String, LdConditionQuery> UnionQueryMap {// for SQL-Comment
        get { return getUnionQueryMap(); }
    }

    public void xsetUnionQuery(LdConditionQuery unionQuery) {
        xsetupUnion(unionQuery, false, getUnionQueryMap());
    }

    protected Map<String, LdConditionQuery> _unionAllQueryMap;

    public Map<String, LdConditionQuery> getUnionAllQueryMap() {// for Internal
		if (_unionAllQueryMap == null) {
		    _unionAllQueryMap = new LinkedHashMap<String, LdConditionQuery>();
		}
        return _unionAllQueryMap;
    }

	public Map<String, LdConditionQuery> UnionAllQueryMap {// for SQL-Comment
        get { return getUnionAllQueryMap(); }
    }

    public void xsetUnionAllQuery(LdConditionQuery unionAllQuery) {
        xsetupUnion(unionAllQuery, true, getUnionAllQueryMap());
    }

    protected void xsetupUnion(LdConditionQuery unionQuery, bool unionAll, Map<String, LdConditionQuery> unionQueryMap) {
        if (unionQuery == null) {
            String msg = "The argument[unionQuery] should not be null.";
            throw new IllegalArgumentException(msg);
        }
        reflectRelationOnUnionQuery(this, unionQuery); // Reflect Relation!
        String key = (unionAll ? "unionAllQuery" : "unionQuery") + unionQueryMap.size();
        unionQueryMap.put(key, unionQuery);
        registerUnionQuery(unionQuery, unionAll, (unionAll ? "UnionAllQueryMap" : "UnionQueryMap") + "." + key);// If CSharp, The property of 'Union' should be 'InitCap'.
    }
	
    abstract public void reflectRelationOnUnionQuery(LdConditionQuery baseQueryAsSuper, LdConditionQuery unionQueryAsSuper);

    public bool hasUnionQueryOrUnionAllQuery() {
        return (_unionQueryMap != null && !_unionQueryMap.isEmpty()) || (_unionAllQueryMap != null && !_unionAllQueryMap.isEmpty());
    }

    public List<LdConditionQuery> getUnionQueryList() {
		if (_unionQueryMap == null) { return new ArrayList<LdConditionQuery>(); }
        return new ArrayList<LdConditionQuery>(_unionQueryMap.values());
    }

    public List<LdConditionQuery> getUnionAllQueryList() {
		if (_unionAllQueryMap == null) { return new ArrayList<LdConditionQuery>(); }
        return new ArrayList<LdConditionQuery>(_unionAllQueryMap.values());
    }

    // ===================================================================================
    //                                                                            Register
    //                                                                            ========
    // -----------------------------------------------------
    //                                          Normal Query
    //                                          ------------
    protected virtual void regQ(LdConditionKey key, Object value, LdConditionValue cvalue, String colName) {
        if (!isValidQuery(key, value, cvalue, colName)) {
            return;
        }
        setupConditionValueAndRegisterWhereClause(key, value, cvalue, colName);
    }
	
	protected virtual void regQ(LdConditionKey key, Object value, LdConditionValue cvalue, String colName, LdConditionOption option) {
        if (!isValidQuery(key, value, cvalue, colName)) {
            return;
        }
        setupConditionValueAndRegisterWhereClause(key, value, cvalue, colName, option);
    }

    protected virtual bool isValidQuery(LdConditionKey key, Object value, LdConditionValue cvalue, String colName) {
        String realColumnName = toColumnRealName(colName);
        if (key.isValidRegistration(cvalue, value, realColumnName)) {
            return true;
        } else {
            if (xgetSqlClause().isCheckInvalidQuery()) {
                throwInvalidQueryRegisteredException(key, cvalue, realColumnName);
                return false; // unreachable
            } else {
                xgetSqlClause().registerInvalidQueryColumn(realColumnName, key);
                return false;
            }
        }
    }

    protected void throwInvalidQueryRegisteredException(LdConditionKey key, Object value, String realColumnName) {
        String msg = "Look! Read the message below." + ln();
        msg = msg + "/* * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * *" + ln();
        msg = msg + "An invalid query was registered. (check is working)" + ln();
        msg = msg + ln();
        msg = msg + "[Advice]" + ln();
        msg = msg + "You should not set an invalid query when you set the check valid."  + ln();
        msg = msg + "For example:"  + ln();
        msg = msg + "  (x):"  + ln();
        msg = msg + "    MemberCB cb = new MemberCB();"  + ln();
        msg = msg + "    cb.CheckInvalidQuery();"  + ln();
        msg = msg + "    cb.Query().SetMemberId_Equal(null); // exception"  + ln();
        msg = msg + "  (o):"  + ln();
        msg = msg + "    MemberCB cb = new MemberCB();"  + ln();
        msg = msg + "    cb.CheckInvalidQuery();"  + ln();
        msg = msg + "    cb.Query().SetMemberId_Equal(3);"  + ln();
        msg = msg + "  (o):"  + ln();
        msg = msg + "    MemberCB cb = new MemberCB();"  + ln();
        msg = msg + "    cb.Query().SetMemberId_Equal(null);"  + ln();
        msg = msg + ln();
        msg = msg + "[Column]" + ln();
        msg = msg + realColumnName + ln();
        msg = msg + ln();
        msg = msg + "[Condition Key]" + ln();
        msg = msg + key.getConditionKey() + ln();
        msg = msg + ln();
        msg = msg + "[Registered Value]" + ln();
        msg = msg + value + ln();
        msg = msg + "* * * * * * * * * */";
        throw new LdInvalidQueryRegisteredException(msg);
    }

    // -----------------------------------------------------
    //                                         InScope Query
    //                                         -------------
    protected void regINS<ELEMENT>(LdConditionKey key, System.Collections.IList value, LdConditionValue cvalue, String colName) {
        if (!isValidQuery(key, value, cvalue, colName)) {
            return;
        }
        int inScopeLimit = xgetSqlClause().getInScopeLimit();
        if (inScopeLimit > 0 && value.Count > inScopeLimit) {
            // if the key is for inScope, it should be split as 'or'
            // (if the key is for notInScope, it should be split as 'and')
            bool alreadyOrScopeQuery = xgetSqlClause().isOrScopeQueryEffective();
            if (isConditionKeyInScope(key)) {
                // if or-scope query has already been effective, create new or-scope
                xgetSqlClause().makeOrScopeQueryEffective();
            } else {
                if (alreadyOrScopeQuery) {
                    xgetSqlClause().beginOrScopeQueryAndPart();
                }
            }

            try {
                // split the condition
                List<Object> objectList = convertToJavaList(value);
                List<List<Object>> valueList = splitByLimit(objectList, inScopeLimit);
                for (int i = 0; i < valueList.size(); i++) {
                    System.Collections.IList currentValue = convertToEmbeddedList<ELEMENT>(valueList.get(i));
                    if (i == 0) {
                        setupConditionValueAndRegisterWhereClause(key, currentValue, cvalue, colName);
                    } else {
                        invokeQuery(colName, key.getConditionKey(), currentValue);
                    }
                }
            } finally {
                if (isConditionKeyInScope(key)) {
                    xgetSqlClause().closeOrScopeQuery();
                } else {
                    if (alreadyOrScopeQuery) {
                        xgetSqlClause().endOrScopeQueryAndPart();
                    }
                }
            }
        } else {
            setupConditionValueAndRegisterWhereClause(key, value, cvalue, colName);
        }
    }

    static bool isConditionKeyInScope(LdConditionKey key) { // default scope for test 
        return typeof(LdConditionKeyInScope).IsAssignableFrom(key.GetType());
    }

    private static List<Object> convertToJavaList(System.Collections.IList list) {
        List<Object> resultList = new ArrayList<Object>();
        foreach (Object element in list) {
            resultList.add(element);
        }
        return resultList;
    }

    private static System.Collections.IList convertToEmbeddedList<ELEMENT>(List<Object> list) {
        System.Collections.IList resultList = new System.Collections.Generic.List<ELEMENT>();
        foreach (Object element in list) {
            resultList.Add(element);
        }
        return resultList;
    }

    private static List<List<ELEMENT>> splitByLimit<ELEMENT>(List<ELEMENT> elementList, int limit) {
        List<List<ELEMENT>> valueList = new ArrayList<List<ELEMENT>>();
        int valueSize = elementList.size();
        int index = 0;
        int remainderSize = valueSize;
        do {
            int beginIndex = limit * index;
            int endPoint = beginIndex + limit;
            int endIndex = limit <= remainderSize ? endPoint : valueSize;
            List<ELEMENT> splitList = new ArrayList<ELEMENT>();
            splitList.addAll(elementList.subList(beginIndex, endIndex));
            valueList.add(splitList);
            remainderSize = valueSize - endIndex;
            ++index;
        } while (remainderSize > 0);
        return valueList;
    }

    // -----------------------------------------------------
    //                                          FromTo Query
    //                                          ------------
    protected void regFTQ(DateTime? fromDate, DateTime? toDate, LdConditionValue cvalue, String colName, LdFromToOption option) {
        {
            LdConditionKey fromKey = option.getFromDateConditionKey();
            DateTime? filteredFromDate = option.filterFromDate(fromDate);
            if (isValidQuery(fromKey, filteredFromDate, cvalue, colName)) {
                setupConditionValueAndRegisterWhereClause(fromKey, filteredFromDate, cvalue, colName);
            }
        }
        {
            LdConditionKey toKey = option.getToDateConditionKey();
            DateTime? filteredToDate = option.filterToDate(toDate);
            if (isValidQuery(toKey, filteredToDate, cvalue, colName)) {
                setupConditionValueAndRegisterWhereClause(toKey, filteredToDate, cvalue, colName);
            }
        }
    }
	
    // -----------------------------------------------------
    //                                      LikeSearch Query
    //                                      ----------------
    protected void regLSQ(LdConditionKey key
                        , String value
                        , LdConditionValue cvalue
                        , String colName
                        , LdLikeSearchOption option) {
        registerLikeSearchQuery(key, value, cvalue, colName, option);
    }

    protected void registerLikeSearchQuery(LdConditionKey key
                                         , String value
                                         , LdConditionValue cvalue
                                         , String colName
                                         , LdLikeSearchOption option) {
        if (option == null) {
            throwLikeSearchOptionNotFoundException(colName, value);
            return;// Unreachable!
        }
        if (!isValidQuery(key, value, cvalue, colName)) {
            return;
        }
        if (xsuppressEscape()) {
            option.NotEscape();
        }
        if (value == null || !option.isSplit()) {
            // As Normal Condition.
            setupConditionValueAndRegisterWhereClause(key, value, cvalue, colName, option);
            return;
        }
        // - - - - - - - - -
        // Use splitByXxx().
        // - - - - - - - - -
        throw new UnsupportedOperationException("The method 'splitByXxx()' have been unsupported yet!");
    }
    
    protected virtual bool xsuppressEscape() { // for override
        return false; // as default
    }

    protected void throwLikeSearchOptionNotFoundException(String colName, String value) {
        LdDBMeta dbmeta = LdDBMetaInstanceHandler.FindDBMeta(getTableDbName());
        String propertyName = dbmeta.FindPropertyName(colName);
        String capPropName = initCap(propertyName);
        String msg = "Look! Read the message below." + ln();
        msg = msg + "/* * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * *" + ln();
        msg = msg + "The likeSearchOption was Not Found! (Should not be null!)" + ln();
        msg = msg + ln();
        msg = msg + "[Advice]" + ln();
        msg = msg + "Please confirm your method call:"  + ln();
        String beanName = GetType().Name;
        String methodName = "set" + capPropName + "_LikeSearch('" + value + "', likeSearchOption);";
        msg = msg + "    " + beanName + "." + methodName + ln();
        msg = msg + "* * * * * * * * * */";
        throw new LdRequiredOptionNotFoundException(msg);
    }

    // -----------------------------------------------------
    //                                          Inline Query
    //                                          ------------
    protected virtual void regIQ(LdConditionKey key, Object value, LdConditionValue cvalue, String colName) {
        if (!isValidQuery(key, value, cvalue, colName)) {
            return;
        }
        LdDBMeta dbmeta = LdDBMetaInstanceHandler.FindDBMeta(getTableDbName());
        String propertyName = dbmeta.FindPropertyName(colName);
        String capPropName = initCap(propertyName);
        key.setupConditionValue(cvalue, value, getLocation(capPropName, key));// If CSharp, it is necessary to use capPropName!
        if (isBaseQuery()) {
            xgetSqlClause().registerBaseTableInlineWhereClause(colName, key, cvalue);
        } else {
            xgetSqlClause().registerOuterJoinInlineWhereClause(xgetAliasName(), colName, key, cvalue, _onClause);
        }
    }

    protected virtual void regIQ(LdConditionKey key, Object value, LdConditionValue cvalue
                               , String colName, LdConditionOption option) {
        if (!isValidQuery(key, value, cvalue, colName)) {
            return;
        }
        LdDBMeta dbmeta = LdDBMetaInstanceHandler.FindDBMeta(getTableDbName());
        String propertyName = dbmeta.FindPropertyName(colName);
        String capPropName = initCap(propertyName);
        key.setupConditionValue(cvalue, value, getLocation(capPropName, key), option);// If CSharp, it is necessary to use capPropName!
        if (isBaseQuery()) {
            xgetSqlClause().registerBaseTableInlineWhereClause(colName, key, cvalue, option);
        } else {
			xgetSqlClause().registerOuterJoinInlineWhereClause(xgetAliasName(), colName, key, cvalue, option, _onClause);
        }
    }

    // -----------------------------------------------------
    //                                       InScopeSubQuery
    //                                       ---------------
    protected virtual void registerInScopeSubQuery(LdConditionQuery subQuery
                                 , String columnName, String relatedColumnName, String propertyName) {
        registerInScopeSubQuery(subQuery, columnName, relatedColumnName, propertyName, null);
    }

    protected virtual void registerNotInScopeSubQuery(LdConditionQuery subQuery
                                 , String columnName, String relatedColumnName, String propertyName) {
        registerInScopeSubQuery(subQuery, columnName, relatedColumnName, propertyName, "not");
    }

    protected virtual void registerInScopeSubQuery(LdConditionQuery subQuery
                                 , String columnName, String relatedColumnName, String propertyName
                                 , String inScopeOption) {
        assertObjectNotNull("InScopeSubQyery(" + columnName + ")", subQuery);
        inScopeOption = inScopeOption != null ? inScopeOption + " " : "";
        String realColumnName = getInScopeSubQueryRealColumnName(columnName);
        String subQueryClause = getInScopeSubQueryClause(subQuery, relatedColumnName, propertyName);
        int subQueryLevel = subQuery.xgetSqlClause().getSubQueryLevel();
        String subQueryIdentity = propertyName + "[" + subQueryLevel + "]";
        String beginMark = subQuery.xgetSqlClause().resolveSubQueryBeginMark(subQueryIdentity) + ln();
        String endMark = subQuery.xgetSqlClause().resolveSubQueryEndMark(subQueryIdentity);
        String endIndent = "       ";
        String clause = realColumnName + " " + inScopeOption
                     + "in (" + beginMark + subQueryClause + ln() + endIndent + ")" + endMark;
        registerWhereClause(clause);
    }

    protected virtual String getInScopeSubQueryRealColumnName(String columnName) {
        return toColumnRealName(columnName);
    }

    protected virtual String getInScopeSubQueryClause(LdConditionQuery subQuery
                                 , String relatedColumnName, String propertyName) {
        String tableAliasName = subQuery.xgetSqlClause().getBasePointAliasName();
        String selectClause = "select " + tableAliasName + "." + relatedColumnName;
        String fromWhereClause = buildPlainSubQueryFromWhereClause(subQuery, relatedColumnName, propertyName
                                                                 , selectClause, tableAliasName);
        return selectClause + " " + fromWhereClause;
    }

    // -----------------------------------------------------
    //                                        ExistsSubQuery
    //                                        --------------
    protected virtual void registerExistsSubQuery(LdConditionQuery subQuery
                                 , String columnName, String relatedColumnName, String propertyName) {
        registerExistsSubQuery(subQuery, columnName, relatedColumnName, propertyName, null);
    }

    protected virtual void registerNotExistsSubQuery(LdConditionQuery subQuery
                                 , String columnName, String relatedColumnName, String propertyName) {
        registerExistsSubQuery(subQuery, columnName, relatedColumnName, propertyName, "not");
    }

    protected virtual void registerExistsSubQuery(LdConditionQuery subQuery
                                 , String columnName, String relatedColumnName, String propertyName
                                 , String existsOption) {
        assertObjectNotNull("ExistsSubQyery(" + columnName + ")", subQuery);
        existsOption = existsOption != null ? existsOption + " " : "";
        String realColumnName = getExistsSubQueryRealColumnName(columnName);
        String subQueryClause = getExistsSubQueryClause(subQuery, realColumnName, relatedColumnName, propertyName);
        int subQueryLevel = subQuery.xgetSqlClause().getSubQueryLevel();
        String subQueryIdentity = propertyName + "[" + subQueryLevel + "]";
        String beginMark = subQuery.xgetSqlClause().resolveSubQueryBeginMark(subQueryIdentity) + ln();
        String endMark = subQuery.xgetSqlClause().resolveSubQueryEndMark(subQueryIdentity);
        String endIndent = "       ";
        String clause = existsOption + "exists (" + beginMark + subQueryClause + ln() + endIndent + ")" + endMark;
        registerWhereClause(clause);
    }

    // - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - 
    // *Unsupport ExistsSubQuery as inline because it's so dangerous.
    // - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - 

    protected virtual String getExistsSubQueryRealColumnName(String columnName) {
        return toColumnRealName(columnName);
    }

    protected virtual String getExistsSubQueryClause(LdConditionQuery subQuery
                                 , String realColumnName, String relatedColumnName, String propertyName) {
		int subQueryLevel = subQuery.xgetSqlClause().getSubQueryLevel();
		String tableAliasName = subQuery.xgetSqlClause().getBasePointAliasName();
        String selectClause = "select " + tableAliasName + "." + relatedColumnName;
        String fromWhereClause = buildCorrelationSubQueryFromWhereClause(subQuery, relatedColumnName, propertyName
                                                                       , selectClause, tableAliasName, realColumnName);
		return selectClause + " " + fromWhereClause;
    }

    // [DBFlute-0.7.9]
    // -----------------------------------------------------
    //                              (Specify)DerivedReferrer
    //                              ------------------------
    protected void registerSpecifyDerivedReferrer(String function, LdConditionQuery subQuery
                                                , String columnName, String relatedColumnName
                                                , String propertyName, String aliasName) {
        assertObjectNotNull("DerivedReferrerSubQuery(function)", function);
        assertObjectNotNull("DerivedReferrerSubQuery(" + columnName + ")", subQuery);
        String realColumnName = getSpecifyDerivedReferrerRealColumnName(columnName);
        String subQueryClause = getSpecifyDerivedReferrerSubQueryClause(function, subQuery, realColumnName
                                                                      , relatedColumnName, propertyName, aliasName);
        int subQueryLevel = subQuery.xgetSqlClause().getSubQueryLevel();
        String subQueryIdentity = propertyName + "[" + subQueryLevel + "]";
        String beginMark = subQuery.xgetSqlClause().resolveSubQueryBeginMark(subQueryIdentity) + ln();
        String endMark = subQuery.xgetSqlClause().resolveSubQueryEndMark(subQueryIdentity);
        String endIndent = "       ";
        String clause = "(" + beginMark + subQueryClause + ln() + endIndent + ") as " + aliasName + endMark;
        xgetSqlClause().specifyDeriveSubQuery(aliasName, clause);
    }

    protected String getSpecifyDerivedReferrerRealColumnName(String columnName) {
        return toColumnRealName(columnName);
    }

    protected String getSpecifyDerivedReferrerSubQueryClause(String function, LdConditionQuery subQuery
                                                           , String realColumnName, String relatedColumnName
                                                           , String propertyName, String aliasName) {
        int subQueryLevel = subQuery.xgetSqlClause().getSubQueryLevel();
        String tableAliasName = subQuery.xgetSqlClause().getBasePointAliasName();
        String deriveColumnName = subQuery.xgetSqlClause().getSpecifiedColumnNameAsOne();
        if (deriveColumnName == null || deriveColumnName.Trim().Length == 0) {
            throwSpecifyDerivedReferrerInvalidColumnSpecificationException(function, aliasName);
        }
        assertSpecifyDerivedReferrerColumnType(function, subQuery, deriveColumnName);
        subQuery.xgetSqlClause().clearSpecifiedSelectColumn();
        String connect = xbuildFunctionConnector(function);
        if (subQuery.xgetSqlClause().hasUnionQuery()) {
            String subQueryIdentity = propertyName + "[" + subQueryLevel + ":subquerymain]";
            String beginMark = subQuery.xgetSqlClause().resolveSubQueryBeginMark(subQueryIdentity) + ln();
            String endMark = subQuery.xgetSqlClause().resolveSubQueryEndMark(subQueryIdentity);
            LdDBMeta dbmeta = LdDBMetaInstanceHandler.FindDBMeta(subQuery.getTableDbName());
            if (!dbmeta.HasPrimaryKey || dbmeta.HasCompoundPrimaryKey) {
                String msg = "The derived-referrer is unsupported when no primary key or two-or-more primary keys:";
                msg = msg + " table=" + subQuery.getTableDbName();
                throw new NotSupportedException(msg);
            }
            String primaryKeyName = dbmeta.PrimaryUniqueInfo.FirstColumn.ColumnDbName;
            String selectClause = "select " + tableAliasName + "." + primaryKeyName 
                                     + ", " + tableAliasName + "." + relatedColumnName
                                     + ", " + tableAliasName + "." + deriveColumnName;
            String fromWhereClause = buildPlainSubQueryFromWhereClause(subQuery, relatedColumnName, propertyName
                                                                     , selectClause, tableAliasName);
            String mainSql = selectClause + " " + fromWhereClause;
            String joinCondition = "dfsubquerymain." + relatedColumnName + " = " + realColumnName;
            return "select " + function + connect + "dfsubquerymain." + deriveColumnName + ")" + ln()
                 + "  from (" + beginMark
                 + mainSql + ln()
                 + "       ) dfsubquerymain" + endMark + ln() + " where " + joinCondition;
        } else {
            String selectClause = "select " + function + connect + tableAliasName + "." + deriveColumnName + ")";
            String fromWhereClause = buildCorrelationSubQueryFromWhereClause(subQuery, relatedColumnName, propertyName
                                                                           , selectClause, tableAliasName, realColumnName);
            return selectClause + " " + fromWhereClause;
        }
    }

    protected void throwSpecifyDerivedReferrerInvalidColumnSpecificationException(String function, String aliasName) {
        String method = xconvertFunctionToMethod(function);
        String msg = "Look! Read the message below." + ln();
        msg = msg + "/* * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * *" + ln();
        msg = msg + "The specified the column for derived-referrer was Invalid!" + ln();
        msg = msg + ln();
        msg = msg + "[Advice]" + ln();
        msg = msg + " You should call specify().column[TargetColumn]() only once." + ln();
        msg = msg + "  For example:" + ln();
        msg = msg + "    " + ln();
        msg = msg + "    [Wrong]" + ln();
        msg = msg + "    /- - - - - - - - - - - - - - - - - - - - " + ln();
        msg = msg + "    MemberCB cb = new MemberCB();" + ln();
        msg = msg + "    cb.specify().derivePurchaseList()." + method + "(new SubQuery<PurchaseCB>() {" + ln();
        msg = msg + "        public void query(PurchaseCB subCB) {" + ln();
        msg = msg + "            // *No! It's empty!" + ln();
        msg = msg + "        }" + ln();
        msg = msg + "    }, \"LATEST_PURCHASE_DATETIME\");" + ln();
        msg = msg + "    - - - - - - - - - -/" + ln();
        msg = msg + "    " + ln();
        msg = msg + "    [Wrong]" + ln();
        msg = msg + "    /- - - - - - - - - - - - - - - - - - - - " + ln();
        msg = msg + "    MemberCB cb = new MemberCB();" + ln();
        msg = msg + "    cb.specify().derivePurchaseList()." + method + "(new SubQuery<PurchaseCB>() {" + ln();
        msg = msg + "        public void query(PurchaseCB subCB) {" + ln();
        msg = msg + "            subCB.specify().columnPurchaseDatetime();" + ln();
        msg = msg + "            subCB.specify().columnPurchaseCount(); // *No! It's duplicated!" + ln();
        msg = msg + "        }" + ln();
        msg = msg + "    }, \"LATEST_PURCHASE_DATETIME\");" + ln();
        msg = msg + "    - - - - - - - - - -/" + ln();
        msg = msg + "    " + ln();
        msg = msg + "    [Good!]" + ln();
        msg = msg + "    /- - - - - - - - - - - - - - - - - - - - " + ln();
        msg = msg + "    MemberCB cb = new MemberCB();" + ln();
        msg = msg + "    cb.specify().derivePurchaseList()." + method + "(new SubQuery<PurchaseCB>() {" + ln();
        msg = msg + "        public void query(PurchaseCB subCB) {" + ln();
        msg = msg + "            subCB.specify().columnPurchaseDatetime(); // *Point!" + ln();
        msg = msg + "        }" + ln();
        msg = msg + "    }, \"LATEST_PURCHASE_DATETIME\");" + ln();
        msg = msg + "    - - - - - - - - - -/" + ln();
        msg = msg + ln();
        msg = msg + "[Alias Name]" + ln() + aliasName + ln();
        msg = msg + "* * * * * * * * * */";
        throw new SpecifyDerivedReferrerInvalidColumnSpecificationException(msg);
    }

    public class SpecifyDerivedReferrerInvalidColumnSpecificationException : SystemException {
        public SpecifyDerivedReferrerInvalidColumnSpecificationException(String msg) : base(msg) {
        }
    }
    
    protected void assertSpecifyDerivedReferrerColumnType(String function, LdConditionQuery subQuery, String deriveColumnName) {
        LdDBMeta dbmeta = LdDBMetaInstanceHandler.FindDBMeta(subQuery.getTableDbName());
        Type deriveColumnType = dbmeta.FindColumnInfo(deriveColumnName).PropertyType;
        if ("sum".Equals(function.ToLower()) || "avg".Equals(function.ToLower())) {
            // Determine as not string and not date because CSharp does not have abstract class of number.
            if (typeof(String).IsAssignableFrom(deriveColumnType) || typeof(DateTime).IsAssignableFrom(deriveColumnType)) {
                throwSpecifyDerivedReferrerUnmatchedColumnTypeException(function, deriveColumnName, deriveColumnType);
            }
        }
    }

    protected void throwSpecifyDerivedReferrerUnmatchedColumnTypeException(String function, String deriveColumnName, Type deriveColumnType) {
        String msg = "Look! Read the message below." + ln();
        msg = msg + "/* * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * *" + ln();
        msg = msg + "The type of the specified the column unmatched with the function!" + ln();
        msg = msg + ln();
        msg = msg + "[Advice]" + ln();
        msg = msg + "You should confirm the list as follow:" + ln();
        msg = msg + "    max()   : String, Number, Date" + ln();
        msg = msg + "    min()   : String, Number, Date" + ln();
        msg = msg + "    sum()   : Number" + ln();
        msg = msg + "    avg()   : Number" + ln();
        msg = msg + "    count() : String, Number, Date" + ln();
        msg = msg + ln();
        msg = msg + "[Function]" + ln() + function + ln();
        msg = msg + ln();
        msg = msg + "[Derive Column]" + ln() + deriveColumnName + "(" + deriveColumnType.Name + ")" + ln();
        msg = msg + "* * * * * * * * * */";
        throw new SpecifyDerivedReferrerUnmatchedColumnTypeException(msg);
    }

    public class SpecifyDerivedReferrerUnmatchedColumnTypeException : SystemException {
        public SpecifyDerivedReferrerUnmatchedColumnTypeException(String msg) : base(msg) {
        }
    }

    // [DBFlute-0.8.9.2]
    // -----------------------------------------------------
    //                                (Query)DerivedReferrer
    //                                ----------------------
    protected void registerQueryDerivedReferrer(String function, LdConditionQuery subQuery
                                              , String columnName, String relatedColumnName, String propertyName
                                              , String operand, Object value, String parameterPropertyName) {
        assertObjectNotNull("QueryDerivedReferrer(function)", function);
        assertObjectNotNull("QueryDerivedReferrer(" + columnName + ")", subQuery);
        String realColumnName = getQueryDerivedReferrerRealColumnName(columnName);
        String subQueryClause = getQueryDerivedReferrerSubQueryClause(function, subQuery, realColumnName
                                                                    , relatedColumnName, propertyName, value);
        int subQueryLevel = subQuery.xgetSqlClause().getSubQueryLevel();
        String subQueryIdentity = propertyName + "[" + subQueryLevel + "]";
        String beginMark = subQuery.xgetSqlClause().resolveSubQueryBeginMark(subQueryIdentity) + ln();
        String endMark = subQuery.xgetSqlClause().resolveSubQueryEndMark(subQueryIdentity);
        String endIndent = "       ";
        String parameter = "/*pmb." + xgetLocationBase(parameterPropertyName) + "*/null";
        String clause = "(" + beginMark
                      + subQueryClause + ln() + endIndent
                      + ") " + operand + " " + parameter + " " + endMark;
        registerWhereClause(clause);
    }

    protected String getQueryDerivedReferrerRealColumnName(String columnName) {
        return toColumnRealName(columnName);
    }

    protected String getQueryDerivedReferrerSubQueryClause(String function, LdConditionQuery subQuery
                                                         , String realColumnName, String relatedColumnName
                                                         , String propertyName, Object value) {
        int subQueryLevel = subQuery.xgetSqlClause().getSubQueryLevel();
        String tableAliasName = subQuery.xgetSqlClause().getBasePointAliasName();
        String deriveColumnName = subQuery.xgetSqlClause().getSpecifiedColumnNameAsOne();
        if (deriveColumnName == null || deriveColumnName.Trim().Length == 0) {
            throwQueryDerivedReferrerInvalidColumnSpecificationException(function);
        }
        assertQueryDerivedReferrerColumnType(function, subQuery, deriveColumnName, value);
        subQuery.xgetSqlClause().clearSpecifiedSelectColumn(); // specified columns disappear at this timing
        String connect = xbuildFunctionConnector(function);
        if (subQuery.xgetSqlClause().hasUnionQuery()) {
            String subQueryIdentity = propertyName + "[" + subQueryLevel + ":subquerymain]";
            String beginMark = subQuery.xgetSqlClause().resolveSubQueryBeginMark(subQueryIdentity) + ln();
            String endMark = subQuery.xgetSqlClause().resolveSubQueryEndMark(subQueryIdentity);
            LdDBMeta dbmeta = findDBMeta(subQuery.getTableDbName());
            if (!dbmeta.HasPrimaryKey || dbmeta.HasCompoundPrimaryKey) {
                String msg = "The derived-referrer is unsupported when no primary key or two-or-more primary keys:";
                msg = msg + " table=" + subQuery.getTableDbName();
                throw new UnsupportedOperationException(msg);
            }
            String primaryKeyName = dbmeta.PrimaryUniqueInfo.FirstColumn.ColumnDbName;
            String selectClause = "select " + tableAliasName + "." + primaryKeyName 
                                     + ", " + tableAliasName + "." + relatedColumnName
                                     + ", " + tableAliasName + "." + deriveColumnName;
            String fromWhereClause = buildPlainSubQueryFromWhereClause(subQuery, relatedColumnName, propertyName
                                                                     , selectClause, tableAliasName);
            String mainSql = selectClause + " " + fromWhereClause;
            String joinCondition = "dfsubquerymain." + relatedColumnName + " = " + realColumnName;
            return "select " + function + connect + "dfsubquerymain." + deriveColumnName + ")" + ln()
                 + "  from (" + beginMark
                 + mainSql + ln()
                 + "       ) dfsubquerymain" + endMark + ln() + " where " + joinCondition;
        } else {
            String selectClause = "select " + function + connect + tableAliasName + "." + deriveColumnName + ")";
            String fromWhereClause = buildCorrelationSubQueryFromWhereClause(subQuery, relatedColumnName, propertyName
                                                                           , selectClause, tableAliasName, realColumnName);
            return selectClause + " " + fromWhereClause;
        }
    }

    protected void throwQueryDerivedReferrerInvalidColumnSpecificationException(String function) {
        LdConditionBeanContext.ThrowQueryDerivedReferrerInvalidColumnSpecificationException(function);
    }

    protected void assertQueryDerivedReferrerColumnType(String function, LdConditionQuery subQuery, String deriveColumnName, Object value) {
        LdDBMeta dbmeta = findDBMeta(subQuery.getTableDbName());
        Type deriveColumnType = dbmeta.FindColumnInfo(deriveColumnName).PropertyType;
        if ("sum".Equals(function.ToLower()) || "avg".Equals(function.ToLower())) {
            // Determine as not string and not date because CSharp does not have abstract class of number.
            if (typeof(String).IsAssignableFrom(deriveColumnType) || typeof(DateTime).IsAssignableFrom(deriveColumnType)) {
                throwQueryDerivedReferrerUnmatchedColumnTypeException(function, deriveColumnName, deriveColumnType, value);
            }
        }
        if (value != null) {
            Type parameterType = value.GetType();
            if (typeof(String).IsAssignableFrom(deriveColumnType)) {
                if (!typeof(String).IsAssignableFrom(parameterType)) {
                    throwQueryDerivedReferrerUnmatchedColumnTypeException(function, deriveColumnName, deriveColumnType, value);
                }
            }

            // Check main number type only because CSharp does not have abstract class of number.
            if (typeof(int).IsAssignableFrom(deriveColumnType)) {
                if (!typeof(int).IsAssignableFrom(parameterType)) {
                    throwQueryDerivedReferrerUnmatchedColumnTypeException(function, deriveColumnName, deriveColumnType, value);
                }
            }
            if (typeof(decimal).IsAssignableFrom(deriveColumnType)) {
                if (!typeof(decimal).IsAssignableFrom(parameterType)) {
                    throwQueryDerivedReferrerUnmatchedColumnTypeException(function, deriveColumnName, deriveColumnType, value);
                }
            }

            if (typeof(DateTime).IsAssignableFrom(deriveColumnType)) {
                if (!typeof(DateTime).IsAssignableFrom(parameterType)) {
                    throwQueryDerivedReferrerUnmatchedColumnTypeException(function, deriveColumnName, deriveColumnType, value);
                }
            }
        }
    }

    protected void throwQueryDerivedReferrerUnmatchedColumnTypeException(String function, String deriveColumnName, Type deriveColumnType, Object value) {
        LdConditionBeanContext.ThrowQueryDerivedReferrerUnmatchedColumnTypeException(function, deriveColumnName, deriveColumnType, value);
    }

    public class QDRFunction<CB> where CB : LdConditionBean { // Internal
        protected QDRSetupper<CB> _setupper;
        public QDRFunction(QDRSetupper<CB> setupper) {
            _setupper = setupper;
        }
        
        /**
         * Set up the sub query of referrer for the scalar 'count'.
         * <pre>
         * cb.query().scalarPurchaseList().count(new SubQuery&lt;PurchaseCB&gt;() {
         *     public void query(PurchaseCB subCB) {
         *         subCB.specify().columnPurchaseId(); // *Point!
         *         subCB.query().setPaymentCompleteFlg_Equal_True();
         *     }
         * }).greaterEqual(123); // *Don't forget the parameter!
         * </pre> 
         * @param subQuery The sub query of referrer. (NotNull) 
         * @return The parameter for comparing with scalar. (NotNull)
         */
        public QDRParameter<CB, int> Count(LdSubQuery<CB> subQuery) {
            return new QDRParameter<CB, int>("count", subQuery, _setupper);
        }
        
        /**
         * Set up the sub query of referrer for the scalar 'count(with distinct)'.
         * <pre>
         * cb.query().scalarPurchaseList().countDistinct(new SubQuery&lt;PurchaseCB&gt;() {
         *     public void query(PurchaseCB subCB) {
         *         subCB.specify().columnPurchasePrice(); // *Point!
         *         subCB.query().setPaymentCompleteFlg_Equal_True();
         *     }
         * }).greaterEqual(123); // *Don't forget the parameter!
         * </pre> 
         * @param subQuery The sub query of referrer. (NotNull) 
         * @return The parameter for comparing with scalar. (NotNull)
         */
        public QDRParameter<CB, int> CountDistinct(LdSubQuery<CB> subQuery) {
            return new QDRParameter<CB, int>("count(distinct", subQuery, _setupper);
        }

        /**
         * Set up the sub query of referrer for the scalar 'max'.
         * <pre>
         * cb.query().scalarPurchaseList().max(new SubQuery&lt;PurchaseCB&gt;() {
         *     public void query(PurchaseCB subCB) {
         *         subCB.specify().columnPurchasePrice(); // *Point!
         *         subCB.query().setPaymentCompleteFlg_Equal_True();
         *     }
         * }).greaterEqual(123); // *Don't forget the parameter!
         * </pre> 
         * @param subQuery The sub query of referrer. (NotNull) 
         * @return The parameter for comparing with scalar. (NotNull)
         */
        public QDRParameter<CB, Object> Max(LdSubQuery<CB> subQuery) {
            return new QDRParameter<CB, Object>("max", subQuery, _setupper);
        }
        
        /**
         * Set up the sub query of referrer for the scalar 'min'.
         * <pre>
         * cb.query().scalarPurchaseList().min(new SubQuery&lt;PurchaseCB&gt;() {
         *     public void query(PurchaseCB subCB) {
         *         subCB.specify().columnPurchasePrice(); // *Point!
         *         subCB.query().setPaymentCompleteFlg_Equal_True();
         *     }
         * }).greaterEqual(123); // *Don't forget the parameter!
         * </pre> 
         * @param subQuery The sub query of referrer. (NotNull) 
         * @return The parameter for comparing with scalar. (NotNull)
         */
        public QDRParameter<CB, Object> Min(LdSubQuery<CB> subQuery) {
            return new QDRParameter<CB, Object>("min", subQuery, _setupper);
        }
        
        /**
         * Set up the sub query of referrer for the scalar 'sum'.
         * <pre>
         * cb.query().scalarPurchaseList().sum(new SubQuery&lt;PurchaseCB&gt;() {
         *     public void query(PurchaseCB subCB) {
         *         subCB.specify().columnPurchasePrice(); // *Point!
         *         subCB.query().setPaymentCompleteFlg_Equal_True();
         *     }
         * }).greaterEqual(123); // *Don't forget the parameter!
         * </pre> 
         * @param subQuery The sub query of referrer. (NotNull) 
         * @return The parameter for comparing with scalar. (NotNull)
         */
        public QDRParameter<CB, Object> Sum(LdSubQuery<CB> subQuery) {
            return new QDRParameter<CB, Object>("sum", subQuery, _setupper);
        }
        
        /**
         * Set up the sub query of referrer for the scalar 'avg'.
         * <pre>
         * cb.query().scalarPurchaseList().avg(new SubQuery&lt;PurchaseCB&gt;() {
         *     public void query(PurchaseCB subCB) {
         *         subCB.specify().columnPurchasePrice(); // *Point!
         *         subCB.query().setPaymentCompleteFlg_Equal_True();
         *     }
         * }).greaterEqual(123); // *Don't forget the parameter!
         * </pre> 
         * @param subQuery The sub query of referrer. (NotNull) 
         * @return The parameter for comparing with scalar. (NotNull)
         */
        public QDRParameter<CB, Object> Avg(LdSubQuery<CB> subQuery) {
            return new QDRParameter<CB, Object>("avg", subQuery, _setupper);
        }
    }

    public delegate void QDRSetupper<CB>(String function
                                       , LdSubQuery<CB> subQuery
                                       , String operand
                                       , Object value) where CB : LdConditionBean;

    public class QDRParameter<CB, PARAMETER> where CB : LdConditionBean { // Internal
        protected String _function;
        protected LdSubQuery<CB> _subQuery;
        protected QDRSetupper<CB> _setupper;
        public QDRParameter(String function, LdSubQuery<CB> subQuery, QDRSetupper<CB> setupper) {
            _function = function;
            _subQuery = subQuery;
            _setupper = setupper;
        }

        /**
         * Set up the operand 'equal' and the value of parameter. <br />
         * The type of the parameter should be same as the type of target column. 
         * <pre>
         * cb.query().scalarPurchaseList().max(new SubQuery&lt;PurchaseCB&gt;() {
         *     public void query(PurchaseCB subCB) {
         *         subCB.specify().columnPurchasePrice(); // If the type is Integer...
         *         subCB.query().setPaymentCompleteFlg_Equal_True();
         *     }
         * }).equal(123); // This parameter should be Integer!
         * </pre> 
         * @param value The value of parameter. (NotNull) 
         */
        public void Equal(PARAMETER value) {
            _setupper.Invoke(_function, _subQuery, "=", value);
        }
        
        /**
         * Set up the operand 'greaterThan' and the value of parameter. <br />
         * The type of the parameter should be same as the type of target column. 
         * <pre>
         * cb.query().scalarPurchaseList().max(new SubQuery&lt;PurchaseCB&gt;() {
         *     public void query(PurchaseCB subCB) {
         *         subCB.specify().columnPurchasePrice(); // If the type is Integer...
         *         subCB.query().setPaymentCompleteFlg_Equal_True();
         *     }
         * }).greaterThan(123); // This parameter should be Integer!
         * </pre> 
         * @param value The value of parameter. (NotNull) 
         */
        public void GreaterThan(PARAMETER value) {
            _setupper.Invoke(_function, _subQuery, ">", value);
        }
        
        /**
         * Set up the operand 'lessThan' and the value of parameter. <br />
         * The type of the parameter should be same as the type of target column. 
         * <pre>
         * cb.query().scalarPurchaseList().max(new SubQuery&lt;PurchaseCB&gt;() {
         *     public void query(PurchaseCB subCB) {
         *         subCB.specify().columnPurchasePrice(); // If the type is Integer...
         *         subCB.query().setPaymentCompleteFlg_Equal_True();
         *     }
         * }).lessThan(123); // This parameter should be Integer!
         * </pre> 
         * @param value The value of parameter. (NotNull) 
         */
        public void LessThan(PARAMETER value) {
            _setupper.Invoke(_function, _subQuery, "<", value);
        }
        
        /**
         * Set up the operand 'greaterEqual' and the value of parameter. <br />
         * The type of the parameter should be same as the type of target column. 
         * <pre>
         * cb.query().scalarPurchaseList().max(new SubQuery&lt;PurchaseCB&gt;() {
         *     public void query(PurchaseCB subCB) {
         *         subCB.specify().columnPurchasePrice(); // If the type is Integer...
         *         subCB.query().setPaymentCompleteFlg_Equal_True();
         *     }
         * }).greaterEqual(123); // This parameter should be Integer!
         * </pre> 
         * @param value The value of parameter. (NotNull) 
         */
        public void GreaterEqual(PARAMETER value) {
            _setupper.Invoke(_function, _subQuery, ">=", value);
        }
        
        /**
         * Set up the operand 'lessEqual' and the value of parameter. <br />
         * The type of the parameter should be same as the type of target column. 
         * <pre>
         * cb.query().scalarPurchaseList().max(new SubQuery&lt;PurchaseCB&gt;() {
         *     public void query(PurchaseCB subCB) {
         *         subCB.specify().columnPurchasePrice(); // If the type is Integer...
         *         subCB.query().setPaymentCompleteFlg_Equal_True();
         *     }
         * }).lessEqual(123); // This parameter should be Integer!
         * </pre> 
         * @param value The value of parameter. (NotNull) 
         */
        public void LessEqual(PARAMETER value) {
            _setupper.Invoke(_function, _subQuery, "<=", value);
        }
    }

    // [DBFlute-0.8.8]
    // -----------------------------------------------------
    //                                        ScalarSubQuery
    //                                        --------------
    protected void registerScalarSubQuery(String function, LdConditionQuery subQuery
                                        , String propertyName, String operand) {
        assertObjectNotNull("ScalarSubQuery(" + propertyName + ")", subQuery);
        
        // Get the specified column before it disappears at sub-query making.
        String deriveRealColumnName;
        {
            String deriveColumnName = subQuery.xgetSqlClause().getSpecifiedColumnNameAsOne();
            if (deriveColumnName == null || deriveColumnName.Trim().Length == 0) {
                throwScalarSubQueryInvalidColumnSpecificationException(function);
            }
            deriveRealColumnName = getScalarSubQueryRealColumnName(deriveColumnName);
        }

        String subQueryClause = getScalarSubQueryClause(function, subQuery, propertyName);
        int subQueryLevel = subQuery.xgetSqlClause().getSubQueryLevel();
        String subQueryIdentity = propertyName + "[" + subQueryLevel + "]";
        String beginMark = subQuery.xgetSqlClause().resolveSubQueryBeginMark(subQueryIdentity) + ln();
        String endMark = subQuery.xgetSqlClause().resolveSubQueryEndMark(subQueryIdentity);
        String endIndent = "       ";
        String clause = deriveRealColumnName + " " + operand + " ("
                      + beginMark + subQueryClause + ln() + endIndent
                      + ") " + endMark;
        registerWhereClause(clause);
    }

    protected String getScalarSubQueryRealColumnName(String columnName) {
        return toColumnRealName(columnName);
    }

    protected String getScalarSubQueryClause(String function, LdConditionQuery subQuery
                                           , String propertyName) {
        int subQueryLevel = subQuery.xgetSqlClause().getSubQueryLevel();
        String tableAliasName = subQuery.xgetSqlClause().getBasePointAliasName();
        String deriveColumnName = subQuery.xgetSqlClause().getSpecifiedColumnNameAsOne();
        if (deriveColumnName == null || deriveColumnName.Trim().Length == 0) {
            throwScalarSubQueryInvalidColumnSpecificationException(function);
        }
        assertScalarSubQueryColumnType(function, subQuery, deriveColumnName);
        subQuery.xgetSqlClause().clearSpecifiedSelectColumn(); // specified columns disappear at this timing
        LdDBMeta dbmeta = findDBMeta(subQuery.getTableDbName());
        if (!dbmeta.HasPrimaryKey || dbmeta.HasCompoundPrimaryKey) {
            String msg = "The scalar-sub-query is unsupported when no primary key or two-or-more primary keys:";
            msg = msg + " table=" + subQuery.getTableDbName();
            throw new UnsupportedOperationException(msg);
        }
        String primaryKeyName = dbmeta.PrimaryUniqueInfo.FirstColumn.ColumnDbName;
        if (subQuery.xgetSqlClause().hasUnionQuery()) {
            String subQueryIdentity = propertyName + "[" + subQueryLevel + ":subquerymain]";
            String beginMark = xgetSqlClause().resolveSubQueryBeginMark(subQueryIdentity) + ln();
            String endMark = xgetSqlClause().resolveSubQueryEndMark(subQueryIdentity);
            String selectClause = "select " + tableAliasName + "." + primaryKeyName
                                     + ", " + tableAliasName + "." + deriveColumnName;
            String fromWhereClause = buildPlainSubQueryFromWhereClause(subQuery, primaryKeyName, propertyName
                                                                     , selectClause, tableAliasName);
            String mainSql = selectClause + " " + fromWhereClause;
            return "select " + function + "(dfsubquerymain." + deriveColumnName + ")" + ln()
                 + "  from (" + beginMark
                 + mainSql + ln()
                 + "       ) dfsubquerymain" + endMark;
        } else {
            String selectClause = "select " + function + "(" + tableAliasName + "." + deriveColumnName + ")";
            String fromWhereClause = buildPlainSubQueryFromWhereClause(subQuery, primaryKeyName, propertyName
                                                                     , selectClause, tableAliasName);
            return selectClause + " " + fromWhereClause;
        }
    }

    protected void throwScalarSubQueryInvalidColumnSpecificationException(String function) {
        LdConditionBeanContext.ThrowScalarSubQueryInvalidColumnSpecificationException(function);
    }

    protected void assertScalarSubQueryColumnType(String function, LdConditionQuery subQuery, String deriveColumnName) {
        LdDBMeta dbmeta = findDBMeta(subQuery.getTableDbName());
        Type deriveColumnType = dbmeta.FindColumnInfo(deriveColumnName).PropertyType;
        if ("sum".Equals(function.ToLower()) || "avg".Equals(function.ToLower())) {
            // Determine as not string and not date because CSharp does not have abstract class of number.
            if (typeof(String).IsAssignableFrom(deriveColumnType) || typeof(DateTime).IsAssignableFrom(deriveColumnType)) {
                throwScalarSubQueryUnmatchedColumnTypeException(function, deriveColumnName, deriveColumnType);
            }
        }
    }

    protected void throwScalarSubQueryUnmatchedColumnTypeException(String function, String deriveColumnName, Type deriveColumnType) {
        LdConditionBeanContext.ThrowScalarSubQueryUnmatchedColumnTypeException(function, deriveColumnName, deriveColumnType);
    }

    public class SSQFunction<CB> where CB : LdConditionBean { // Internal
        protected SSQSetupper<CB> _setupper;
        public SSQFunction(SSQSetupper<CB> setupper) {
            _setupper = setupper;
        }

        /**
         * Set up the sub query of myself for the scalar 'max'.
         * <pre>
         * cb.query().scalar_Equal().max(new SubQuery&lt;PurchaseCB&gt;() {
         *     public void query(PurchaseCB subCB) {
         *         subCB.specify().columnPurchasePrice(); // *Point!
         *         subCB.query().setPaymentCompleteFlg_Equal_True();
         *     }
         * });
         * </pre> 
         * @param subQuery The sub query of myself. (NotNull) 
         */
        public void Max(LdSubQuery<CB> subQuery) {
            _setupper.Invoke("max", subQuery);
        }

        /**
         * Set up the sub query of myself for the scalar 'min'.
         * <pre>
         * cb.query().scalar_Equal().min(new SubQuery&lt;PurchaseCB&gt;() {
         *     public void query(PurchaseCB subCB) {
         *         subCB.specify().columnPurchasePrice(); // *Point!
         *         subCB.query().setPaymentCompleteFlg_Equal_True();
         *     }
         * });
         * </pre> 
         * @param subQuery The sub query of myself. (NotNull) 
         */
        public void Min(LdSubQuery<CB> subQuery) {
            _setupper.Invoke("min", subQuery);
        }

        /**
         * Set up the sub query of myself for the scalar 'sum'.
         * <pre>
         * cb.query().scalar_Equal().sum(new SubQuery&lt;PurchaseCB&gt;() {
         *     public void query(PurchaseCB subCB) {
         *         subCB.specify().columnPurchasePrice(); // *Point!
         *         subCB.query().setPaymentCompleteFlg_Equal_True();
         *     }
         * });
         * </pre> 
         * @param subQuery The sub query of myself. (NotNull) 
         */
        public void Sum(LdSubQuery<CB> subQuery) {
            _setupper.Invoke("sum", subQuery);
        }

        /**
         * Set up the sub query of myself for the scalar 'avg'.
         * <pre>
         * cb.query().scalar_Equal().avg(new SubQuery&lt;PurchaseCB&gt;() {
         *     public void query(PurchaseCB subCB) {
         *         subCB.specify().columnPurchasePrice(); // *Point!
         *         subCB.query().setPaymentCompleteFlg_Equal_True();
         *     }
         * });
         * </pre> 
         * @param subQuery The sub query of myself. (NotNull) 
         */
        public void Avg(LdSubQuery<CB> subQuery) {
            _setupper.Invoke("avg", subQuery);
        }
    }

    public delegate void SSQSetupper<CB>(String function
                                       , LdSubQuery<CB> subQuery)
                                       where CB : LdConditionBean; // Internal

    // -----------------------------------------------------
    //                                       SubQuery Common
    //                                       ---------------
    protected String buildPlainSubQueryFromWhereClause(LdConditionQuery subQuery
                                                     , String relatedColumnName
                                                     , String propertyName
                                                     , String selectClause
                                                     , String tableAliasName) {
        String fromWhereClause = subQuery.xgetSqlClause().getClauseFromWhereWithUnionTemplate();

        // Resolve the location path for the condition-query of sub-query. 
        fromWhereClause = replaceString(fromWhereClause, "." + CQ_PROPERTY + ".", "." + xgetLocationBase(propertyName) + ".");

		// Replace template marks. These are very important!
		fromWhereClause = replaceString(fromWhereClause, subQuery.xgetSqlClause().getUnionSelectClauseMark(), selectClause);
		fromWhereClause = replaceString(fromWhereClause, subQuery.xgetSqlClause().getUnionWhereClauseMark(), "");
		fromWhereClause = replaceString(fromWhereClause, subQuery.xgetSqlClause().getUnionWhereFirstConditionMark(), "");
		return fromWhereClause;
    }

    protected String buildCorrelationSubQueryFromWhereClause(LdConditionQuery subQuery
                                                           , String relatedColumnName
                                                           , String propertyName
                                                           , String selectClause
                                                           , String tableAliasName
                                                           , String realColumnName) {
        String fromWhereClause = subQuery.xgetSqlClause().getClauseFromWhereWithWhereUnionTemplate();

        // Resolve the location path for the condition-query of sub-query. 
        fromWhereClause = replaceString(fromWhereClause, "." + CQ_PROPERTY + ".", "." + xgetLocationBase(propertyName) + ".");

        String joinCondition = tableAliasName + "." + relatedColumnName + " = " + realColumnName;
        String firstConditionAfter = ln() + "   and ";
        
        // Replace template marks. These are very important!
        fromWhereClause = replaceString(fromWhereClause, subQuery.xgetSqlClause().getWhereClauseMark(), "where " + joinCondition);
        fromWhereClause = replaceString(fromWhereClause, subQuery.xgetSqlClause().getWhereFirstConditionMark(), joinCondition + firstConditionAfter);
        fromWhereClause = replaceString(fromWhereClause, subQuery.xgetSqlClause().getUnionSelectClauseMark(), selectClause);
        fromWhereClause = replaceString(fromWhereClause, subQuery.xgetSqlClause().getUnionWhereClauseMark(), "where " + joinCondition);
        fromWhereClause = replaceString(fromWhereClause, subQuery.xgetSqlClause().getUnionWhereFirstConditionMark(), joinCondition + firstConditionAfter);
        return fromWhereClause;
    }

    protected String xbuildFunctionConnector(String function) {
        if (function != null && function.EndsWith("(distinct")) { // For example 'count(distinct'
            return " ";
        } else {
            return "(";
        }
    }

    protected String xconvertFunctionToMethod(String function) {
        if (function != null && function.Contains("(")) { // For example 'count(distinct'
            int index = function.IndexOf("(");
            String front = function.Substring(0, index);
            if (function.Length > front.Length + "(".Length) {
                String rear = function.Substring(index + "(".Length);
                function = front + initCap(rear);
            } else {
                function = front;
            }
        }
        return function;
    }

    // -----------------------------------------------------
    //                                          Where Clause
    //                                          ------------
    protected virtual void setupConditionValueAndRegisterWhereClause(LdConditionKey key, Object value, LdConditionValue cvalue, String colName) {
        LdDBMeta dbmeta = LdDBMetaInstanceHandler.FindDBMeta(getTableDbName());
        String propertyName = dbmeta.FindPropertyName(colName);
        String capPropName = initCap(propertyName);
        // If CSharp, it is necessary to use capPropName!
        key.setupConditionValue(cvalue, value, getLocation(capPropName, key));
        xgetSqlClause().registerWhereClause(toColumnRealName(colName), key, cvalue);
    }

    protected virtual void setupConditionValueAndRegisterWhereClause(LdConditionKey key, Object value, LdConditionValue cvalue
                                                                   , String colName, LdConditionOption option) {
        LdDBMeta dbmeta = LdDBMetaInstanceHandler.FindDBMeta(getTableDbName());
        String propertyName = dbmeta.FindPropertyName(colName);
        String capPropName = initCap(propertyName);
        // If CSharp, it is necessary to use capPropName!
        key.setupConditionValue(cvalue, value, getLocation(capPropName, key), option);
        xgetSqlClause().registerWhereClause(toColumnRealName(colName), key, cvalue, option);
    }
	
    protected virtual void registerWhereClause(String whereClause) {
        xgetSqlClause().registerWhereClause(whereClause);
    }

    protected virtual void registerInlineWhereClause(String whereClause) {
        if (isBaseQuery()) {
            xgetSqlClause().registerBaseTableInlineWhereClause(whereClause);
        } else {
            xgetSqlClause().registerOuterJoinInlineWhereClause(xgetAliasName(), whereClause, _onClause);
        }
    }

    // -----------------------------------------------------
    //                                           Union Query
    //                                           -----------
    public void registerUnionQuery(LdConditionQuery unionQuery, bool unionAll, String unionQueryPropertyName) {
        String unionQueryClause = getUnionQuerySql(unionQuery, unionQueryPropertyName);
		
		// At the future, building SQL will be moved to sqlClause.
        xgetSqlClause().registerUnionQuery(unionQueryClause, unionAll);
    }

    protected String getUnionQuerySql(LdConditionQuery unionQuery, String unionQueryPropertyName) {
	    String fromClause = unionQuery.xgetSqlClause().getFromClause();
		String whereClause = unionQuery.xgetSqlClause().getWhereClause();
		String unionQueryClause;
		if (whereClause.Trim().Length <= 0) {
		    unionQueryClause = fromClause + " " + xgetSqlClause().getUnionWhereClauseMark();
		} else {
		    int whereIndex = whereClause.IndexOf("where ");
		    if (whereIndex < 0) {
				String msg = "The whereClause should have 'where' string: " + whereClause;
			    throw new IllegalStateException(msg);
			}
			int clauseIndex = whereIndex + "where ".Length;
			String mark = xgetSqlClause().getUnionWhereFirstConditionMark();
			String markedClause = whereClause.Substring(0, clauseIndex) + mark + whereClause.Substring(clauseIndex);
			unionQueryClause = fromClause + " " + markedClause;
		}
        String oldStr = "." + CQ_PROPERTY + ".";
        String newStr = "." + CQ_PROPERTY + "." + unionQueryPropertyName + ".";
        return replaceString(unionQueryClause, oldStr, newStr); // Very Important!
    }

    // -----------------------------------------------------
    //                                            Inner Join
    //                                            ----------
    public void InnerJoin() {
        if (isBaseQuery()) {
            String msg = "Look! Read the message below." + ln();
            msg = msg + "/* * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * *" + ln();
            msg = msg + "The method 'InnerJoin()' should be called for a relation query!" + ln();
            msg = msg + ln();
            msg = msg + "[Advice]" + ln();
            msg = msg + "Please confirm your program. " + ln();
            msg = msg + "  For example:" + ln();
            msg = msg + "    (x) - cb.Query().InnerJoin();" + ln();
            msg = msg + "    (o) - cb.Query().QueryMemberStatusCode().InnerJoin();" + ln();
            msg = msg + "* * * * * * * * * */";
            throw new IllegalStateException(msg);
        }
        xgetSqlClause().changeToInnerJoin(xgetAliasName());
    }

    // -----------------------------------------------------
    //                                               OrderBy
    //                                               -------
	public void WithNullsFirst() {// is User Public!
	    xgetSqlClause().addNullsFirstToPreviousOrderBy();
	}
	
	public void WithNullsLast() {// is User Public!
	    xgetSqlClause().addNullsLastToPreviousOrderBy();
	}

    protected void registerSpecifiedDerivedOrderBy_Asc(String aliasName) {
        if (!xgetSqlClause().hasSpecifiedDeriveSubQuery(aliasName)) {
            throwSpecifiedDerivedOrderByAliasNameNotFoundException(aliasName);
        }
        xgetSqlClause().registerOrderBy(aliasName, null, true);
    }

    protected void registerSpecifiedDerivedOrderBy_Desc(String aliasName) {
        if (!xgetSqlClause().hasSpecifiedDeriveSubQuery(aliasName)) {
            throwSpecifiedDerivedOrderByAliasNameNotFoundException(aliasName);
        }
        xgetSqlClause().registerOrderBy(aliasName, null, false);
    }

    protected void throwSpecifiedDerivedOrderByAliasNameNotFoundException(String aliasName) {
        String msg = "Look! Read the message below." + ln();
        msg = msg + "/* * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * *" + ln();
        msg = msg + "The aliasName was Not Found in specified alias names." + ln();
        msg = msg + ln();
        msg = msg + "[Advice]" + ln();
        msg = msg + "You should specified an alias name that is the same as one in specify-derived-referrer." + ln();
        msg = msg + "  For example:" + ln();
        msg = msg + "    " + ln();
        msg = msg + "    [Wrong]" + ln();
        msg = msg + "    /- - - - - - - - - - - - - - - - - - - - " + ln();
        msg = msg + "    MemberCB cb = new MemberCB();" + ln();
        msg = msg + "    cb.specify().derivePurchaseList().max(new SubQuery<PurchaseCB>() {" + ln();
        msg = msg + "        public void query(PurchaseCB subCB) {" + ln();
        msg = msg + "            subCB.specify().specifyProduct().columnProductName(); // *No!" + ln();
        msg = msg + "        }" + ln();
        msg = msg + "    }, \"LATEST_PURCHASE_DATETIME\");" + ln();
        msg = msg + "    cb.query().addSpecifiedDerivedOrderBy_Desc(\"WRONG_NAME_DATETIME\");" + ln();
        msg = msg + "    - - - - - - - - - -/" + ln();
        msg = msg + "    " + ln();
        msg = msg + "    [Good!]" + ln();
        msg = msg + "    /- - - - - - - - - - - - - - - - - - - - " + ln();
        msg = msg + "    MemberCB cb = new MemberCB();" + ln();
        msg = msg + "    cb.specify().derivePurchaseList().max(new SubQuery<PurchaseCB>() {" + ln();
        msg = msg + "        public void query(PurchaseCB subCB) {" + ln();
        msg = msg + "            subCB.specify().columnPurchaseDatetime();// *Point!" + ln();
        msg = msg + "        }" + ln();
        msg = msg + "    }, \"LATEST_PURCHASE_DATETIME\");" + ln();
        msg = msg + "    cb.query().addSpecifiedDerivedOrderBy_Desc(\"LATEST_PURCHASE_DATETIME\");" + ln();
        msg = msg + "    - - - - - - - - - -/" + ln();
        msg = msg + ln();
        msg = msg + "[Not Found Alias Name]" + ln() + aliasName + ln();
        msg = msg + "* * * * * * * * * */";
        throw new SpecifiedDerivedOrderByAliasNameNotFoundException(msg);
    }

    public class SpecifiedDerivedOrderByAliasNameNotFoundException : SystemException {
        public SpecifiedDerivedOrderByAliasNameNotFoundException(String msg) : base(msg) {
        }
    }

    public void registerOrderBy(String columnName, bool ascOrDesc) {
        xgetSqlClause().registerOrderBy(toColumnRealName(columnName), null, ascOrDesc);
    }

    protected void regOBA(String columnName) {
        registerOrderBy(columnName, true);
    }

    protected void regOBD(String columnName) {
        registerOrderBy(columnName, false);
    }

    // ===================================================================================
    //                                                                       Name Resolver
    //                                                                       =============
    protected String resolveJoinAliasName(String relationPath, int nestLevel) {
        return xgetSqlClause().resolveJoinAliasName(relationPath, nestLevel);
    }

	protected String resolveNextRelationPath(String tableName, String relationPropertyName) {
	    int relationNo = xgetSqlClause().resolveRelationNo(tableName, relationPropertyName);
        String nextRelationPath = "_" + relationNo;
        if (_relationPath != null) {
            nextRelationPath = _relationPath + nextRelationPath;
        }
		return nextRelationPath;
	}

    // ===================================================================================
    //                                                                 Reflection Invoking
    //                                                                 ===================
    public LdConditionValue invokeValue(String columnFlexibleName) {
        assertStringNotNullAndNotTrimmedEmpty("columnFlexibleName", columnFlexibleName);
        LdDBMeta dbmeta = LdDBMetaInstanceHandler.FindDBMeta(getTableDbName());
        String columnCapPropName = initCap(dbmeta.FindPropertyName(columnFlexibleName));
        String propertyName = columnCapPropName;
        PropertyInfo property = helpGettingCQProperty(this, propertyName);
        return (LdConditionValue)helpInvokingCQProperty(this, property);
    }

    public void invokeQuery(String columnFlexibleName, String conditionKeyName, Object value) {
        assertStringNotNullAndNotTrimmedEmpty("columnFlexibleName", columnFlexibleName);
        assertStringNotNullAndNotTrimmedEmpty("conditionKeyName", conditionKeyName);
        if (value == null) {
            return;
        }
        PropertyNameCQContainer container = helpExtractingPropertyNameCQContainer(columnFlexibleName);
        String propertyName = container.getPropertyName();
        LdConditionQuery cq = container.getConditionQuery();
        LdDBMeta dbmeta = LdDBMetaInstanceHandler.FindDBMeta(cq.getTableDbName());
        String columnCapPropName = initCap(dbmeta.FindPropertyName(propertyName));
        String methodName = "Set" + columnCapPropName + "_" + initCap(conditionKeyName);
        Type type = value.GetType();
        // QQQ Does it need to convert IList if an implementation of IList?
        MethodInfo method = helpGettingCQMethod(cq, methodName, new Type[]{type}, propertyName);
        helpInvokingCQMethod(cq, method, new Object[]{value});
    }

    public void invokeOrderBy(String columnFlexibleName, bool isAsc) {
        assertStringNotNullAndNotTrimmedEmpty("columnFlexibleName", columnFlexibleName);
        PropertyNameCQContainer container = helpExtractingPropertyNameCQContainer(columnFlexibleName);
        String propertyName = container.getPropertyName();
        LdConditionQuery cq = container.getConditionQuery();
        String ascDesc = isAsc ? "Asc" : "Desc";
        LdDBMeta dbmeta = LdDBMetaInstanceHandler.FindDBMeta(cq.getTableDbName());
        String columnCapPropName = initCap(dbmeta.FindPropertyName(propertyName));
        String methodName = "AddOrderBy_" + columnCapPropName + "_" + ascDesc;
        MethodInfo method = helpGettingCQMethod(cq, methodName, new Type[]{}, propertyName);
        helpInvokingCQMethod(cq, method, new Object[]{});
    }

    public LdConditionQuery invokeForeignCQ(String foreignPropertyName) {
        assertStringNotNullAndNotTrimmedEmpty("foreignPropertyName", foreignPropertyName);
        String[] splitList = foreignPropertyName.Split('.');
        LdConditionQuery foreignCQ = this;
        foreach (String elementName in splitList) {
            foreignCQ = doInvokeForeignCQ(foreignCQ, elementName);
        }
        return foreignCQ;
    }

    protected LdConditionQuery doInvokeForeignCQ(LdConditionQuery cq, String foreignPropertyName) {
        assertStringNotNullAndNotTrimmedEmpty("foreignPropertyName", foreignPropertyName);
        String methodName = "Query" + initCap(foreignPropertyName);
        MethodInfo method = helpGettingCQMethod(cq, methodName, new Type[]{}, foreignPropertyName);
        return (LdConditionQuery)helpInvokingCQMethod(cq, method, new Object[]{});
    }

    public bool invokeHasForeignCQ(String foreignPropertyName) {
        assertStringNotNullAndNotTrimmedEmpty("foreignPropertyName", foreignPropertyName);
        String[] splitList = foreignPropertyName.Split('.');
        LdConditionQuery foreignCQ = this;
        int splitLength = splitList.Length;
        int index = 0;
        foreach (String elementName in splitList) {
            if (!doInvokeHasForeignCQ(foreignCQ, elementName)) {
                return false;
            }
            if ((index + 1) < splitLength) { // not last loop
                foreignCQ = foreignCQ.invokeForeignCQ(elementName);
            }
            ++index;
        }
        return true;
    }

    protected bool doInvokeHasForeignCQ(LdConditionQuery cq, String foreignPropertyName) {
        assertStringNotNullAndNotTrimmedEmpty("foreignPropertyName", foreignPropertyName);
        String methodName = "hasConditionQuery" + initCap(foreignPropertyName);
        MethodInfo method = helpGettingCQMethod(cq, methodName, new Type[]{}, foreignPropertyName);
        return (bool)helpInvokingCQMethod(cq, method, new Object[]{});
    }

    private PropertyNameCQContainer helpExtractingPropertyNameCQContainer(String name) {
        String[] strings = name.Split('.');
        int length = strings.Length;
        String propertyName = null;
        LdConditionQuery cq = this;
        int index = 0;
        foreach (String element in strings) {
            if (length == (index+1)) { // at last loop!
                propertyName = element;
                break;
            }
            cq = cq.invokeForeignCQ(element);
            ++index;
        }
        return new PropertyNameCQContainer(propertyName, cq);
    }

    private class PropertyNameCQContainer {
        protected String _propertyName;
        protected LdConditionQuery _cq;
        public PropertyNameCQContainer(String propertyName, LdConditionQuery cq) {
            this._propertyName = propertyName;
            this._cq = cq;
        }
        public String getPropertyName() {
            return _propertyName;
        }
        public LdConditionQuery getConditionQuery() {
            return _cq;
        }
    }

    private PropertyInfo helpGettingCQProperty(LdConditionQuery cq, String propertyName) {
        PropertyInfo property = cq.GetType().GetProperty(propertyName);
        if (property == null) {
            String msg = "The property is not existing:";
            msg = msg + " propertyName=" + propertyName;
            msg = msg + " tableName=" + cq.getTableDbName();
            throw new IllegalStateException(msg);
        }
        return property;
    }

    private Object helpInvokingCQProperty(LdConditionQuery cq, PropertyInfo property) {
        return property.GetValue(cq, null);
    }

    private MethodInfo helpGettingCQMethod(LdConditionQuery cq, String methodName, Type[] argTypes, String property) {
        MethodInfo method = cq.GetType().GetMethod(methodName, argTypes);
        if (method == null) {
            method = cq.GetType().GetMethod(methodName);
            if (method == null) {
                String msg = "The method is not existing:";
                msg = msg + " methodName=" + methodName;
                msg = msg + " argTypes=" + convertObjectArrayToStringView(argTypes);
                msg = msg + " tableName=" + cq.getTableDbName();
                msg = msg + " property=" + property;
                throw new IllegalStateException(msg);
            }
        }
        return method;
    }

    private Object helpInvokingCQMethod(LdConditionQuery cq, MethodInfo method, Object[] args) {
        return method.Invoke(cq, args);
    }

    // ===================================================================================
    //                                                                       Assist Helper
    //                                                                       =============
    protected String fRES(String value) {
        return filterRemoveEmptyString(value);
    }

    private String filterRemoveEmptyString(String value) {
        return ((value != null && !"".Equals(value)) ? value : null);
    }
    
    protected LdLikeSearchOption cLSOP() {
        return new LdLikeSearchOption().LikePrefix();
    }

    protected System.Collections.IList cTL<PROPERTY_TYPE>(System.Collections.Generic.ICollection<PROPERTY_TYPE> col) {
        return convertToList(col);
    }

    private System.Collections.IList convertToList<PROPERTY_TYPE>(System.Collections.Generic.ICollection<PROPERTY_TYPE> col) {
        if (col == null) {
            return null;
        }
		if (col is System.Collections.IList) {
		    return filterRemoveNullOrEmptyValueFromList((System.Collections.IList)col);
		}
		System.Collections.IList resultList = new System.Collections.ArrayList();
		foreach (PROPERTY_TYPE value in col) {
		    resultList.Add(value);
		}
        return filterRemoveNullOrEmptyValueFromList(resultList);
    }

    private System.Collections.IList filterRemoveNullOrEmptyValueFromList(System.Collections.IList ls) {
        if (ls == null) {
            return null;
        }
        System.Collections.IList newList = new System.Collections.ArrayList();
		foreach (Object element in ls) {
			if (element == null) {
			    continue;
			}
			if (element is String) {
                if ("".Equals((String)element)) {
                    continue;
                }
            }
		    newList.Add(element);
		}
        return newList;
    }

    // ===================================================================================
    //                                                                      General Helper
    //                                                                      ==============
    protected String ln() {
        return LdSimpleSystemUtil.GetLineSeparator();
    }

    protected String replaceString(String text, String fromText, String toText) {
	    return LdSimpleStringUtil.Replace(text, fromText, toText);
    }

    protected String initCap(String str) {
	    return LdSimpleStringUtil.InitCap(str);
    }

    protected String initUncap(String str) {
	    return LdSimpleStringUtil.InitUncap(str);
    }

    protected String convertObjectArrayToStringView(Object[] objArray) {
	    return LdTraceViewUtil.ConvertObjectArrayToStringView(objArray);
    }

    // -----------------------------------------------------
    //                                         Assert Object
    //                                         -------------
    protected void assertObjectNotNull(String variableName, Object value) {
	    LdSimpleAssertUtil.AssertObjectNotNull(variableName, value);
    }

    protected void assertColumnName(String columnName) {
        if (columnName == null) {
            String msg = "The columnName should not be null.";
            throw new IllegalArgumentException(msg);
        }
        if (columnName.Trim().Length == 0) {
            String msg = "The columnName should not be empty-string.";
            throw new IllegalArgumentException(msg);
        }
        if (columnName.IndexOf(",") >= 0) {
            String msg = "The columnName should not contain comma ',': " + columnName;
            throw new IllegalArgumentException(msg);
        }
    }

    protected void assertAliasName(String aliasName) {
        if (aliasName == null) {
            String msg = "The aliasName should not be null.";
            throw new IllegalArgumentException(msg);
        }
        if (aliasName.Trim().Length == 0) {
            String msg = "The aliasName should not be empty-string.";
            throw new IllegalArgumentException(msg);
        }
        if (aliasName.IndexOf(",") >= 0) {
            String msg = "The aliasName should not contain comma ',': " + aliasName;
            throw new IllegalArgumentException(msg);
        }
    }

    // -----------------------------------------------------
    //                                         Assert String
    //                                         -------------
    protected void assertStringNotNullAndNotTrimmedEmpty(String variableName, String value) {
	    LdSimpleAssertUtil.AssertStringNotNullAndNotTrimmedEmpty(variableName, value);
    }
	
    // ===================================================================================
    //                                                                      Basic Override
    //                                                                      ==============
    public override String ToString() {
        return GetType().Name + ":{aliasName=" + _aliasName + ", nestLevel=" + _nestLevel
		     + ", subQueryLevel=" + _subQueryLevel + ", foreignPropertyName=" + _foreignPropertyName
			 + ", relationPath=" + _relationPath + ", onClause=" + _onClause + "}";
    }
}

}
