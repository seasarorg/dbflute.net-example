
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
    [Bean(typeof(LdLending))]
    public partial interface LdLendingDao : LdDaoWritable {
		void InitializeDaoMetaData(String methodName);// Very Internal Method!

        int SelectCount(LdLendingCB cb);
        IList<LdLending> SelectList(LdLendingCB cb);

        int Insert(LdLending entity);
        int UpdateModifiedOnly(LdLending entity);
        int UpdateNonstrictModifiedOnly(LdLending entity);
        int Delete(LdLending entity);
        int DeleteNonstrict(LdLending entity);
    }
}
