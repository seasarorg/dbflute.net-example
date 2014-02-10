
using System;
using System.Collections.Generic;

using Seasar.Quill.Attrs;

using DfExample.DBFlute.MemberDb.AllCommon.S2Dao;

namespace DfExample.DBFlute.MemberDb.AllCommon.Ado {

    [Implementation(typeof(MbSqlLogRegistryLatestSqlProvider))]
    public interface MbLatestSqlProvider {
        String GetDisplaySql();
        IList<String> ExtractDisplaySqlList();
	    void ClearSqlCache();
    }
}
