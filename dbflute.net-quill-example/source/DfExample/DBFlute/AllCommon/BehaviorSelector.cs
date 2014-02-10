
using System;

using Seasar.Quill.Attrs;
using DfExample.DBFlute.AllCommon.Bhv;

namespace DfExample.DBFlute.AllCommon {

    [Implementation(typeof(CacheBehaviorSelector))]
    public interface BehaviorSelector {
        void InitializeConditionBeanMetaData();
        BEHAVIOR Select<BEHAVIOR>() where BEHAVIOR : BehaviorReadable;
        BehaviorReadable ByName(String tableFlexibleName);
    }
}
