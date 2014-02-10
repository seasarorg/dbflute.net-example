
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
    [Bean(typeof(LdMyself))]
    public partial interface LdMyselfDao : LdDaoWritable {
		void InitializeDaoMetaData(String methodName);// Very Internal Method!

        int SelectCount(LdMyselfCB cb);
        IList<LdMyself> SelectList(LdMyselfCB cb);

        int Insert(LdMyself entity);
        int UpdateModifiedOnly(LdMyself entity);
        int UpdateNonstrictModifiedOnly(LdMyself entity);
        int UpdateByQuery(LdMyselfCB cb, LdMyself entity);
        int Delete(LdMyself entity);
        int DeleteNonstrict(LdMyself entity);
        int DeleteByQuery(LdMyselfCB cb);// {DBFlute-0.7.9}
    }
}
