
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
    [Bean(typeof(LdBook))]
    public partial interface LdBookDao : LdDaoWritable {
		void InitializeDaoMetaData(String methodName);// Very Internal Method!

        int SelectCount(LdBookCB cb);
        IList<LdBook> SelectList(LdBookCB cb);

        int Insert(LdBook entity);
        int UpdateModifiedOnly(LdBook entity);
        int UpdateNonstrictModifiedOnly(LdBook entity);
        int UpdateByQuery(LdBookCB cb, LdBook entity);
        int Delete(LdBook entity);
        int DeleteNonstrict(LdBook entity);
        int DeleteByQuery(LdBookCB cb);// {DBFlute-0.7.9}
    }
}
