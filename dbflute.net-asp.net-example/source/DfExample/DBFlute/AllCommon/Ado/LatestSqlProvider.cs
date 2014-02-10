
using System;
using System.Collections.Generic;

using Seasar.Quill.Attrs;

using DfExample.DBFlute.AllCommon.S2Dao;

namespace DfExample.DBFlute.AllCommon.Ado {

    [Implementation(typeof(SqlLogRegistryLatestSqlProvider))]
    public interface LatestSqlProvider {
        String GetDisplaySql();
        IList<String> ExtractDisplaySqlList();
	    void ClearSqlCache();
    }
}
