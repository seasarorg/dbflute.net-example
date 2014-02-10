
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
    [Bean(typeof(LdGarbagePlus))]
    public partial interface LdGarbagePlusDao : LdDaoReadable {
		void InitializeDaoMetaData(String methodName);// Very Internal Method!

        int SelectCount(LdGarbagePlusCB cb);
        IList<LdGarbagePlus> SelectList(LdGarbagePlusCB cb);

    }
}
