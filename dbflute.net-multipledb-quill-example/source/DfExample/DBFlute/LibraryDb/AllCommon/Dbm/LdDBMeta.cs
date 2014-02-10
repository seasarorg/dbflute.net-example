
using System;

using DfExample.DBFlute.LibraryDb.AllCommon;
using DfExample.DBFlute.LibraryDb.AllCommon.CBean;
using DfExample.DBFlute.LibraryDb.AllCommon.Dbm.Info;
using DfExample.DBFlute.LibraryDb.AllCommon.JavaLike;

namespace DfExample.DBFlute.LibraryDb.AllCommon.Dbm {

    public interface LdDBMeta {

        // ===============================================================================
        //                                                                      Table Info
        //                                                                      ==========
        String TableDbName { get; }
        String TablePropertyName { get; }
        String TableSqlName { get; }
        String TableAlias { get; }
        String TableComment { get; }

        // ===============================================================================
        //                                                                     Column Info
        //                                                                     ===========
        List<LdColumnInfo> ColumnInfoList { get; }
        bool HasColumn(String columnFlexibleName);
        LdColumnInfo FindColumnInfo(String columnFlexibleName);

        // ===============================================================================
        //                                                                     Unique Info
        //                                                                     ===========
        LdUniqueInfo PrimaryUniqueInfo { get; }
        bool HasPrimaryKey { get; }
        bool HasCompoundPrimaryKey { get; }

        // ===============================================================================
        //                                                                   Relation Info
        //                                                                   =============
        // -------------------------------------------------
        //                                  Relation Element
        //                                  ----------------
        LdRelationInfo FindRelationInfo(String relationPropertyName);

        // -------------------------------------------------
        //                                   Foreign Element
        //                                   ---------------
        bool HasForeign(String foreignPropName);
        LdDBMeta FindForeignDBMeta(String foreignPropName);
        LdForeignInfo FindForeignInfo(String foreignPropName);
        List<LdForeignInfo> ForeignInfoList { get; }

        // -------------------------------------------------
        //                                  Referrer Element
        //                                  ----------------
        bool HasReferrer(String referrerPropertyName);
        LdDBMeta FindReferrerDBMeta(String referrerPropertyName);
        LdReferrerInfo FindReferrerInfo(String referrerPropertyName);
        List<LdReferrerInfo> ReferrerInfoList { get; }

        // ===============================================================================
        //                                                                   Identity Info
        //                                                                   =============
        bool HasIdentity { get; }

        // ===============================================================================
        //                                                                   Sequence Info
        //                                                                   =============
        bool HasSequence { get; }
        String SequenceName { get; }
        String SequenceNextValSql { get; }
        int? SequenceIncrementSize { get; }
        int? SequenceCacheSize { get; }

        // ===============================================================================
        //                                                            Optimistic Lock Info
        //                                                            ====================
        bool HasVersionNo { get; }
        LdColumnInfo VersionNoColumnInfo { get; }
        bool HasUpdateDate { get; }
        LdColumnInfo UpdateDateColumnInfo { get; }

        // ===============================================================================
        //                                                              Common Column Info
        //                                                              ==================
        bool HasCommonColumn { get; }

        // ===============================================================================
        //                                                                   Name Handling
        //                                                                   =============
        bool HasFlexibleName(String flexibleName);
        String FindDbName(String flexibleName);
        String FindPropertyName(String flexibleName);

        // ===============================================================================
        //                                                                        Name Map
        //                                                                        ========
        Map<String, String> DbNamePropertyNameKeyToLowerMap { get; }
        Map<String, String> PropertyNameDbNameKeyToLowerMap { get; }

        // ===============================================================================
        //                                                                       Type Name
        //                                                                       =========
        String EntityTypeName { get; }
        String DaoTypeName { get; }
        String ConditionBeanTypeName { get; }
        String BehaviorTypeName { get; }

        // ===============================================================================
        //                                                                     Object Type
        //                                                                     ===========
        Type EntityType { get; }

        // ===============================================================================
        //                                                                 Object Instance
        //                                                                 ===============
        LdEntity NewEntity();
        LdConditionBean NewConditionBean();

        // ===============================================================================
        //                                                           Entity Property Setup
        //                                                           =====================
		bool HasEntityPropertySetupper(String propertyName);
        void SetupEntityProperty(String propertyName, Object entity, Object value);
    }

    public interface EntityPropertySetupper<ENTITY> where ENTITY : LdEntity {
        void Setup(ENTITY entity, Object value);
    }

    public enum OptimisticLockType {
        NONE, VERSION_NO, UPDATE_DATE
    }
}
