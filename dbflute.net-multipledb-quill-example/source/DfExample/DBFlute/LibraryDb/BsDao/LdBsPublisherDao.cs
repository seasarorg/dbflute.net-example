
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
    [Bean(typeof(LdPublisher))]
    public partial interface LdPublisherDao : LdDaoWritable {
		void InitializeDaoMetaData(String methodName);// Very Internal Method!

        int SelectCount(LdPublisherCB cb);
        IList<LdPublisher> SelectList(LdPublisherCB cb);

        int Insert(LdPublisher entity);
        int UpdateModifiedOnly(LdPublisher entity);
        int UpdateNonstrictModifiedOnly(LdPublisher entity);
        int UpdateByQuery(LdPublisherCB cb, LdPublisher entity);
        int Delete(LdPublisher entity);
        int DeleteNonstrict(LdPublisher entity);
        int DeleteByQuery(LdPublisherCB cb);// {DBFlute-0.7.9}
    }
}
