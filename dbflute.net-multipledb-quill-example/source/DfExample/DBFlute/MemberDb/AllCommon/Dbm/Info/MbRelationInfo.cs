
using System;
using DfExample.DBFlute.MemberDb.AllCommon.Dbm;
using DfExample.DBFlute.MemberDb.AllCommon.JavaLike;

namespace DfExample.DBFlute.MemberDb.AllCommon.Dbm.Info {
    
    public interface MbRelationInfo {

        String RelationPropertyName { get; }
        MbDBMeta LocalDBMeta { get; }
        MbDBMeta TargetDBMeta { get; }
        Map<MbColumnInfo,MbColumnInfo> LocalTargetColumnInfoMap { get; }
        bool IsOneToOne { get; }
        bool IsReferrer { get; }
    }
}
