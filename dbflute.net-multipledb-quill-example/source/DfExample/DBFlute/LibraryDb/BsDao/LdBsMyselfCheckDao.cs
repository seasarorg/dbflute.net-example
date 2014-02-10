
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
    [Bean(typeof(LdMyselfCheck))]
    public partial interface LdMyselfCheckDao : LdDaoWritable {
		void InitializeDaoMetaData(String methodName);// Very Internal Method!

        int SelectCount(LdMyselfCheckCB cb);
        IList<LdMyselfCheck> SelectList(LdMyselfCheckCB cb);

        int Insert(LdMyselfCheck entity);
        int UpdateModifiedOnly(LdMyselfCheck entity);
        int UpdateNonstrictModifiedOnly(LdMyselfCheck entity);
        int UpdateByQuery(LdMyselfCheckCB cb, LdMyselfCheck entity);
        int Delete(LdMyselfCheck entity);
        int DeleteNonstrict(LdMyselfCheck entity);
        int DeleteByQuery(LdMyselfCheckCB cb);// {DBFlute-0.7.9}
    }
}
