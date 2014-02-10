
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
    [Bean(typeof(LdLibrary))]
    public partial interface LdLibraryDao : LdDaoWritable {
		void InitializeDaoMetaData(String methodName);// Very Internal Method!

        int SelectCount(LdLibraryCB cb);
        IList<LdLibrary> SelectList(LdLibraryCB cb);

        int Insert(LdLibrary entity);
        int UpdateModifiedOnly(LdLibrary entity);
        int UpdateNonstrictModifiedOnly(LdLibrary entity);
        int UpdateByQuery(LdLibraryCB cb, LdLibrary entity);
        int Delete(LdLibrary entity);
        int DeleteNonstrict(LdLibrary entity);
        int DeleteByQuery(LdLibraryCB cb);// {DBFlute-0.7.9}
    }
}
