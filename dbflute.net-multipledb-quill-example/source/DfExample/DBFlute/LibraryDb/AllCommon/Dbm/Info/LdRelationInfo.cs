
using System;
using DfExample.DBFlute.LibraryDb.AllCommon.Dbm;
using DfExample.DBFlute.LibraryDb.AllCommon.JavaLike;

namespace DfExample.DBFlute.LibraryDb.AllCommon.Dbm.Info {
    
    public interface LdRelationInfo {

        String RelationPropertyName { get; }
        LdDBMeta LocalDBMeta { get; }
        LdDBMeta TargetDBMeta { get; }
        Map<LdColumnInfo,LdColumnInfo> LocalTargetColumnInfoMap { get; }
        bool IsOneToOne { get; }
        bool IsReferrer { get; }
    }
}
