
using System;

using Seasar.Quill.Attrs;
using DfExample.DBFlute.LibraryDb.AllCommon.Bhv;

namespace DfExample.DBFlute.LibraryDb.AllCommon {

    [Implementation(typeof(LdCacheBehaviorSelector))]
    public interface LdBehaviorSelector {
        void InitializeConditionBeanMetaData();
        BEHAVIOR Select<BEHAVIOR>() where BEHAVIOR : LdBehaviorReadable;
        LdBehaviorReadable ByName(String tableFlexibleName);
    }
}
