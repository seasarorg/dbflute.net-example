
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
    [Bean(typeof(LdCollection))]
    public partial interface LdCollectionDao : LdDaoWritable {
		void InitializeDaoMetaData(String methodName);// Very Internal Method!

        int SelectCount(LdCollectionCB cb);
        IList<LdCollection> SelectList(LdCollectionCB cb);

        int Insert(LdCollection entity);
        int UpdateModifiedOnly(LdCollection entity);
        int UpdateNonstrictModifiedOnly(LdCollection entity);
        int UpdateByQuery(LdCollectionCB cb, LdCollection entity);
        int Delete(LdCollection entity);
        int DeleteNonstrict(LdCollection entity);
        int DeleteByQuery(LdCollectionCB cb);// {DBFlute-0.7.9}
    }
}
