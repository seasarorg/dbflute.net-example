
using System;
using DfExample.DBFlute.AllCommon.Dbm;
using DfExample.DBFlute.AllCommon.JavaLike;

namespace DfExample.DBFlute.AllCommon.Dbm.Info {
    
    public interface RelationInfo {

        String RelationPropertyName { get; }
        DBMeta LocalDBMeta { get; }
        DBMeta TargetDBMeta { get; }
        Map<ColumnInfo,ColumnInfo> LocalTargetColumnInfoMap { get; }
        bool IsOneToOne { get; }
        bool IsReferrer { get; }
    }
}
