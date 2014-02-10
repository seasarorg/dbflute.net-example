
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
    [Bean(typeof(LdLibraryTypeLookup))]
    public partial interface LdLibraryTypeLookupDao : LdDaoWritable {
		void InitializeDaoMetaData(String methodName);// Very Internal Method!

        int SelectCount(LdLibraryTypeLookupCB cb);
        IList<LdLibraryTypeLookup> SelectList(LdLibraryTypeLookupCB cb);

        int Insert(LdLibraryTypeLookup entity);
        int UpdateModifiedOnly(LdLibraryTypeLookup entity);
        int UpdateNonstrictModifiedOnly(LdLibraryTypeLookup entity);
        int UpdateByQuery(LdLibraryTypeLookupCB cb, LdLibraryTypeLookup entity);
        int Delete(LdLibraryTypeLookup entity);
        int DeleteNonstrict(LdLibraryTypeLookup entity);
        int DeleteByQuery(LdLibraryTypeLookupCB cb);// {DBFlute-0.7.9}
    }
}
