
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
    [Bean(typeof(LdBlackList))]
    public partial interface LdBlackListDao : LdDaoWritable {
		void InitializeDaoMetaData(String methodName);// Very Internal Method!

        int SelectCount(LdBlackListCB cb);
        IList<LdBlackList> SelectList(LdBlackListCB cb);

        int Insert(LdBlackList entity);
        int UpdateModifiedOnly(LdBlackList entity);
        int UpdateNonstrictModifiedOnly(LdBlackList entity);
        int UpdateByQuery(LdBlackListCB cb, LdBlackList entity);
        int Delete(LdBlackList entity);
        int DeleteNonstrict(LdBlackList entity);
        int DeleteByQuery(LdBlackListCB cb);// {DBFlute-0.7.9}
    }
}
