
using System;
using System.Collections.Generic;

using Seasar.Quill.Attrs;

using DfExample.DBFlute.LibraryDb.AllCommon.S2Dao;

namespace DfExample.DBFlute.LibraryDb.AllCommon.Ado {

    [Implementation(typeof(LdSqlLogRegistryLatestSqlProvider))]
    public interface LdLatestSqlProvider {
        String GetDisplaySql();
        IList<String> ExtractDisplaySqlList();
	    void ClearSqlCache();
    }
}
