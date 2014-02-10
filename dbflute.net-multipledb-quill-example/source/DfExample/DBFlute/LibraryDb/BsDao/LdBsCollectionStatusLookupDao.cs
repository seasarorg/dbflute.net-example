
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
    [Bean(typeof(LdCollectionStatusLookup))]
    public partial interface LdCollectionStatusLookupDao : LdDaoWritable {
		void InitializeDaoMetaData(String methodName);// Very Internal Method!

        int SelectCount(LdCollectionStatusLookupCB cb);
        IList<LdCollectionStatusLookup> SelectList(LdCollectionStatusLookupCB cb);

        int Insert(LdCollectionStatusLookup entity);
        int UpdateModifiedOnly(LdCollectionStatusLookup entity);
        int UpdateNonstrictModifiedOnly(LdCollectionStatusLookup entity);
        int UpdateByQuery(LdCollectionStatusLookupCB cb, LdCollectionStatusLookup entity);
        int Delete(LdCollectionStatusLookup entity);
        int DeleteNonstrict(LdCollectionStatusLookup entity);
        int DeleteByQuery(LdCollectionStatusLookupCB cb);// {DBFlute-0.7.9}
    }
}
