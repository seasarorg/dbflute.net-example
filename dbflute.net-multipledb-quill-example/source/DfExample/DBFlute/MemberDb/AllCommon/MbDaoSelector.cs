
using System;

using Seasar.Quill.Attrs;

namespace DfExample.DBFlute.MemberDb.AllCommon {

    [Implementation(typeof(MbCacheDaoSelector))]
    public interface MbDaoSelector {
        DAO Select<DAO>() where DAO : MbDaoReadable;
        MbDaoReadable ByName(String tableFlexibleName);
    }
}
