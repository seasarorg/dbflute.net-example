
using System;
using System.Collections.Generic;

using Seasar.Quill.Attrs;
using Seasar.Dao.Attrs;

using DfExample.DBFlute.LibraryDb.AllCommon;
using DfExample.DBFlute.LibraryDb.AllCommon.S2Dao;
using DfExample.DBFlute.LibraryDb.ExEntity;
using DfExample.DBFlute.LibraryDb.CBean;

namespace DfExample.DBFlute.LibraryDb.ExDao {

    [Implementation]
    [S2Dao(typeof(LdS2DaoSetting))]
    [Bean(typeof(LdBlackActionLookup))]
    public partial interface LdBlackActionLookupDao : LdDaoWritable {
		void InitializeDaoMetaData(String methodName);// Very Internal Method!

        int SelectCount(LdBlackActionLookupCB cb);
        IList<LdBlackActionLookup> SelectList(LdBlackActionLookupCB cb);

        int Insert(LdBlackActionLookup entity);
        int UpdateModifiedOnly(LdBlackActionLookup entity);
        int UpdateNonstrictModifiedOnly(LdBlackActionLookup entity);
        int UpdateByQuery(LdBlackActionLookupCB cb, LdBlackActionLookup entity);
        int Delete(LdBlackActionLookup entity);
        int DeleteNonstrict(LdBlackActionLookup entity);
        int DeleteByQuery(LdBlackActionLookupCB cb);// {DBFlute-0.7.9}
    }
}
