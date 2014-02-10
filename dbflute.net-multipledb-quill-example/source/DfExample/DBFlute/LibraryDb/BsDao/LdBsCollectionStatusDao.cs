
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
    [Bean(typeof(LdCollectionStatus))]
    public partial interface LdCollectionStatusDao : LdDaoWritable {
		void InitializeDaoMetaData(String methodName);// Very Internal Method!

        int SelectCount(LdCollectionStatusCB cb);
        IList<LdCollectionStatus> SelectList(LdCollectionStatusCB cb);

        int Insert(LdCollectionStatus entity);
        int UpdateModifiedOnly(LdCollectionStatus entity);
        int UpdateNonstrictModifiedOnly(LdCollectionStatus entity);
        int UpdateByQuery(LdCollectionStatusCB cb, LdCollectionStatus entity);
        int Delete(LdCollectionStatus entity);
        int DeleteNonstrict(LdCollectionStatus entity);
        int DeleteByQuery(LdCollectionStatusCB cb);// {DBFlute-0.7.9}
    }
}
