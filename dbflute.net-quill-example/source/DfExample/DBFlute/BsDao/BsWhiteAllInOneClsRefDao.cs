
using System;
using System.Collections.Generic;

using Seasar.Quill.Attrs;
using Seasar.Dao.Attrs;

using DfExample.DBFlute.AllCommon;
using DfExample.DBFlute.AllCommon.S2Dao;
using DfExample.DBFlute.ExEntity;
using DfExample.DBFlute.CBean;

namespace DfExample.DBFlute.ExDao {

    [Implementation]
    [S2Dao(typeof(S2DaoSetting))]
    [Bean(typeof(WhiteAllInOneClsRef))]
    public partial interface WhiteAllInOneClsRefDao : DaoWritable {
		void InitializeDaoMetaData(String methodName);// Very Internal Method!

        int SelectCount(WhiteAllInOneClsRefCB cb);
        IList<WhiteAllInOneClsRef> SelectList(WhiteAllInOneClsRefCB cb);

        int Insert(WhiteAllInOneClsRef entity);
        int UpdateModifiedOnly(WhiteAllInOneClsRef entity);
        int UpdateNonstrictModifiedOnly(WhiteAllInOneClsRef entity);
        int UpdateByQuery(WhiteAllInOneClsRefCB cb, WhiteAllInOneClsRef entity);
        int Delete(WhiteAllInOneClsRef entity);
        int DeleteNonstrict(WhiteAllInOneClsRef entity);
        int DeleteByQuery(WhiteAllInOneClsRefCB cb);// {DBFlute-0.7.9}
    }
}
