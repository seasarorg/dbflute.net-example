
using System;

using Seasar.Quill.Attrs;
using DfExample.DBFlute.MemberDb.AllCommon.Bhv;

namespace DfExample.DBFlute.MemberDb.AllCommon {

    [Implementation(typeof(MbCacheBehaviorSelector))]
    public interface MbBehaviorSelector {
        void InitializeConditionBeanMetaData();
        BEHAVIOR Select<BEHAVIOR>() where BEHAVIOR : MbBehaviorReadable;
        MbBehaviorReadable ByName(String tableFlexibleName);
    }
}
