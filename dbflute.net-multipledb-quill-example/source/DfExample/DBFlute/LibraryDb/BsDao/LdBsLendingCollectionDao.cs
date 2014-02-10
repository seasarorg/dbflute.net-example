
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
    [Bean(typeof(LdLendingCollection))]
    public partial interface LdLendingCollectionDao : LdDaoWritable {
		void InitializeDaoMetaData(String methodName);// Very Internal Method!

        int SelectCount(LdLendingCollectionCB cb);
        IList<LdLendingCollection> SelectList(LdLendingCollectionCB cb);

        int Insert(LdLendingCollection entity);
        int UpdateModifiedOnly(LdLendingCollection entity);
        int UpdateNonstrictModifiedOnly(LdLendingCollection entity);
        int Delete(LdLendingCollection entity);
        int DeleteNonstrict(LdLendingCollection entity);
    }
}
