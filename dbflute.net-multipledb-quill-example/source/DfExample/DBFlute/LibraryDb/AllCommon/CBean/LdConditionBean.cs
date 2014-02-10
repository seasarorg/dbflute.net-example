
using System;
using System.Collections;
using DfExample.DBFlute.LibraryDb.AllCommon.Dbm;
using DfExample.DBFlute.LibraryDb.AllCommon.CBean.SClause;
using DfExample.DBFlute.LibraryDb.AllCommon.Ado;

namespace DfExample.DBFlute.LibraryDb.AllCommon.CBean {

    public interface LdConditionBean : LdPagingBean {

        // ===============================================================================
        //                                                                      Table Name
        //                                                                      ==========
        String TableDbName { get; }

        // ===============================================================================
        //                                                                          DBMeta
        //                                                                          ======
        LdDBMeta DBMeta { get; }

        // ===============================================================================
        //                                                                       SqlClause
        //                                                                       =========
        LdSqlClause SqlClause { get; }
        String GetClause();

        // ===============================================================================
        //                                                             PrimaryKey Handling
        //                                                             ===================
        LdConditionBean AddOrderBy_PK_Asc();
        LdConditionBean AddOrderBy_PK_Desc();
		
        // ===============================================================================
        //                                                                           Query
        //                                                                           =====
        LdConditionQuery LocalCQ { get; }

        // ===============================================================================
        //                                                                    Lock Setting
        //                                                                    ============
        LdConditionBean LockForUpdate();

        // ===============================================================================
        //                                                                    Select Count
        //                                                                    ============
        LdConditionBean xsetupSelectCountIgnoreFetchScope();
        LdConditionBean xafterCareSelectCountIgnoreFetchScope();
        bool IsSelectCountIgnoreFetchScope();

        // ===============================================================================
        //                                                                    InvalidQuery
        //                                                                    ============
        void CheckInvalidQuery();

        // ===============================================================================
        //                                                                Statement Config
        //                                                                ================
        void Configure(LdStatementConfig statementConfig);
        LdStatementConfig StatementConfig { get; }

        // ===============================================================================
        //                                                                  Entity Mapping
        //                                                                  ==============
        void DisableRelationMappingCache();
        bool CanRelationMappingCache();

        // ===============================================================================
        //                                                                     Display SQL
        //                                                                     ===========
    	String ToDisplaySql();

        // ===============================================================================
        //                                                      Basic Status Determination
        //                                                      ==========================
    	bool HasWhereClause();
    	bool HasOrderByClause();
        bool HasUnionQueryOrUnionAllQuery();
        
        // ===============================================================================
        //                                                              Query Synchronizer
        //                                                              ==================
        void xregisterUnionQuerySynchronizer(LdUnionQuery<LdConditionBean> unionQuerySynchronizer);
    }
}
