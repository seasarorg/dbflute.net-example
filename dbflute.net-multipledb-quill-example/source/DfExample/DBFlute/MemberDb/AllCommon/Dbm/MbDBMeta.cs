
using System;

using DfExample.DBFlute.MemberDb.AllCommon;
using DfExample.DBFlute.MemberDb.AllCommon.CBean;
using DfExample.DBFlute.MemberDb.AllCommon.Dbm.Info;
using DfExample.DBFlute.MemberDb.AllCommon.JavaLike;

namespace DfExample.DBFlute.MemberDb.AllCommon.Dbm {

    public interface MbDBMeta {

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
        List<MbColumnInfo> ColumnInfoList { get; }
        bool HasColumn(String columnFlexibleName);
        MbColumnInfo FindColumnInfo(String columnFlexibleName);

        // ===============================================================================
        //                                                                     Unique Info
        //                                                                     ===========
        MbUniqueInfo PrimaryUniqueInfo { get; }
        bool HasPrimaryKey { get; }
        bool HasCompoundPrimaryKey { get; }

        // ===============================================================================
        //                                                                   Relation Info
        //                                                                   =============
        // -------------------------------------------------
        //                                  Relation Element
        //                                  ----------------
        MbRelationInfo FindRelationInfo(String relationPropertyName);

        // -------------------------------------------------
        //                                   Foreign Element
        //                                   ---------------
        bool HasForeign(String foreignPropName);
        MbDBMeta FindForeignDBMeta(String foreignPropName);
        MbForeignInfo FindForeignInfo(String foreignPropName);
        List<MbForeignInfo> ForeignInfoList { get; }

        // -------------------------------------------------
        //                                  Referrer Element
        //                                  ----------------
        bool HasReferrer(String referrerPropertyName);
        MbDBMeta FindReferrerDBMeta(String referrerPropertyName);
        MbReferrerInfo FindReferrerInfo(String referrerPropertyName);
        List<MbReferrerInfo> ReferrerInfoList { get; }

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
        MbColumnInfo VersionNoColumnInfo { get; }
        bool HasUpdateDate { get; }
        MbColumnInfo UpdateDateColumnInfo { get; }

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
        MbEntity NewEntity();
        MbConditionBean NewConditionBean();

        // ===============================================================================
        //                                                           Entity Property Setup
        //                                                           =====================
		bool HasEntityPropertySetupper(String propertyName);
        void SetupEntityProperty(String propertyName, Object entity, Object value);
    }

    public interface EntityPropertySetupper<ENTITY> where ENTITY : MbEntity {
        void Setup(ENTITY entity, Object value);
    }

    public enum OptimisticLockType {
        NONE, VERSION_NO, UPDATE_DATE
    }
}
