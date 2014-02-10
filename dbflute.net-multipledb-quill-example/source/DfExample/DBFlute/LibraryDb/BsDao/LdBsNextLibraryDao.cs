
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
    [Bean(typeof(LdNextLibrary))]
    public partial interface LdNextLibraryDao : LdDaoWritable {
		void InitializeDaoMetaData(String methodName);// Very Internal Method!

        int SelectCount(LdNextLibraryCB cb);
        IList<LdNextLibrary> SelectList(LdNextLibraryCB cb);

        int Insert(LdNextLibrary entity);
        int UpdateModifiedOnly(LdNextLibrary entity);
        int UpdateNonstrictModifiedOnly(LdNextLibrary entity);
        int Delete(LdNextLibrary entity);
        int DeleteNonstrict(LdNextLibrary entity);
    }
}
