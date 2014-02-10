
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
    [Bean(typeof(LdAuthor))]
    public partial interface LdAuthorDao : LdDaoWritable {
		void InitializeDaoMetaData(String methodName);// Very Internal Method!

        int SelectCount(LdAuthorCB cb);
        IList<LdAuthor> SelectList(LdAuthorCB cb);

        int Insert(LdAuthor entity);
        int UpdateModifiedOnly(LdAuthor entity);
        int UpdateNonstrictModifiedOnly(LdAuthor entity);
        int UpdateByQuery(LdAuthorCB cb, LdAuthor entity);
        int Delete(LdAuthor entity);
        int DeleteNonstrict(LdAuthor entity);
        int DeleteByQuery(LdAuthorCB cb);// {DBFlute-0.7.9}
    }
}
