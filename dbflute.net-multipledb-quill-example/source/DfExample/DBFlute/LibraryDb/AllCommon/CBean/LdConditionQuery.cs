
using System;
using DfExample.DBFlute.LibraryDb.AllCommon.CBean.CValue;
using DfExample.DBFlute.LibraryDb.AllCommon.CBean.SClause;

namespace DfExample.DBFlute.LibraryDb.AllCommon.CBean {

// JavaLike
public interface LdConditionQuery {

    // ===================================================================================
    //                                                                          Table Name
    //                                                                          ==========
    String getTableDbName();
    String getTableSqlName();
	
    // ===================================================================================
    //                                                                  Important Accessor
    //                                                                  ==================
    LdConditionQuery xgetReferrerQuery();
    LdSqlClause xgetSqlClause();
    String xgetAliasName();
    String toColumnRealName(String columnName);
    int xgetNestLevel();
    int xgetNextNestLevel();
    bool isBaseQuery();
	String xgetForeignPropertyName();
    String xgetRelationPath();
    String xgetLocationBase();
	
    // ===================================================================================
    //                                                                 Reflection Invoking
    //                                                                 ===================
    LdConditionValue invokeValue(String columnFlexibleName);
    void invokeQuery(String columnFlexibleName, String conditionKeyName, Object value);
    void invokeOrderBy(String columnFlexibleName, bool isAsc);
    LdConditionQuery invokeForeignCQ(String foreignPropertyName);
    bool invokeHasForeignCQ(String foreignPropertyName);
}

}
