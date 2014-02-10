
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
    [Bean(typeof(LdLibraryUser))]
    public partial interface LdLibraryUserDao : LdDaoWritable {
		void InitializeDaoMetaData(String methodName);// Very Internal Method!

        int SelectCount(LdLibraryUserCB cb);
        IList<LdLibraryUser> SelectList(LdLibraryUserCB cb);

        int Insert(LdLibraryUser entity);
        int UpdateModifiedOnly(LdLibraryUser entity);
        int UpdateNonstrictModifiedOnly(LdLibraryUser entity);
        int Delete(LdLibraryUser entity);
        int DeleteNonstrict(LdLibraryUser entity);
    }
}
