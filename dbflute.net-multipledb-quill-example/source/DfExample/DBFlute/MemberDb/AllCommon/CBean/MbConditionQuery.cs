
using System;
using DfExample.DBFlute.MemberDb.AllCommon.CBean.CValue;
using DfExample.DBFlute.MemberDb.AllCommon.CBean.SClause;

namespace DfExample.DBFlute.MemberDb.AllCommon.CBean {

// JavaLike
public interface MbConditionQuery {

    // ===================================================================================
    //                                                                          Table Name
    //                                                                          ==========
    String getTableDbName();
    String getTableSqlName();
	
    // ===================================================================================
    //                                                                  Important Accessor
    //                                                                  ==================
    MbConditionQuery xgetReferrerQuery();
    MbSqlClause xgetSqlClause();
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
    MbConditionValue invokeValue(String columnFlexibleName);
    void invokeQuery(String columnFlexibleName, String conditionKeyName, Object value);
    void invokeOrderBy(String columnFlexibleName, bool isAsc);
    MbConditionQuery invokeForeignCQ(String foreignPropertyName);
    bool invokeHasForeignCQ(String foreignPropertyName);
}

}
