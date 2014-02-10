
using System;

using Seasar.Quill.Attrs;

namespace DfExample.DBFlute.LibraryDb.AllCommon {

    [Implementation(typeof(LdCacheDaoSelector))]
    public interface LdDaoSelector {
        DAO Select<DAO>() where DAO : LdDaoReadable;
        LdDaoReadable ByName(String tableFlexibleName);
    }
}
