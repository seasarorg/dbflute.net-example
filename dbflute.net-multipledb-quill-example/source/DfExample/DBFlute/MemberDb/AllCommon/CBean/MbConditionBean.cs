
using System;
using System.Collections;
using DfExample.DBFlute.MemberDb.AllCommon.Dbm;
using DfExample.DBFlute.MemberDb.AllCommon.CBean.SClause;
using DfExample.DBFlute.MemberDb.AllCommon.Ado;

namespace DfExample.DBFlute.MemberDb.AllCommon.CBean {

    public interface MbConditionBean : MbPagingBean {

        // ===============================================================================
        //                                                                      Table Name
        //                                                                      ==========
        String TableDbName { get; }

        // ===============================================================================
        //                                                                          DBMeta
        //                                                                          ======
        MbDBMeta DBMeta { get; }

        // ===============================================================================
        //                                                                       SqlClause
        //                                                                       =========
        MbSqlClause SqlClause { get; }
        String GetClause();

        // ===============================================================================
        //                                                             PrimaryKey Handling
        //                                                             ===================
        MbConditionBean AddOrderBy_PK_Asc();
        MbConditionBean AddOrderBy_PK_Desc();
		
        // ===============================================================================
        //                                                                           Query
        //                                                                           =====
        MbConditionQuery LocalCQ { get; }

        // ===============================================================================
        //                                                                    Lock Setting
        //                                                                    ============
        MbConditionBean LockForUpdate();

        // ===============================================================================
        //                                                                    Select Count
        //                                                                    ============
        MbConditionBean xsetupSelectCountIgnoreFetchScope();
        MbConditionBean xafterCareSelectCountIgnoreFetchScope();
        bool IsSelectCountIgnoreFetchScope();

        // ===============================================================================
        //                                                                    InvalidQuery
        //                                                                    ============
        void CheckInvalidQuery();

        // ===============================================================================
        //                                                                Statement Config
        //                                                                ================
        void Configure(MbStatementConfig statementConfig);
        MbStatementConfig StatementConfig { get; }

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
        void xregisterUnionQuerySynchronizer(MbUnionQuery<MbConditionBean> unionQuerySynchronizer);
    }
}
