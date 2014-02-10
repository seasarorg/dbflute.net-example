
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
    [Bean(typeof(LdBlackAction))]
    public partial interface LdBlackActionDao : LdDaoWritable {
		void InitializeDaoMetaData(String methodName);// Very Internal Method!

        int SelectCount(LdBlackActionCB cb);
        IList<LdBlackAction> SelectList(LdBlackActionCB cb);

        int Insert(LdBlackAction entity);
        int UpdateModifiedOnly(LdBlackAction entity);
        int UpdateNonstrictModifiedOnly(LdBlackAction entity);
        int UpdateByQuery(LdBlackActionCB cb, LdBlackAction entity);
        int Delete(LdBlackAction entity);
        int DeleteNonstrict(LdBlackAction entity);
        int DeleteByQuery(LdBlackActionCB cb);// {DBFlute-0.7.9}
    }
}
