
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
    [Bean(typeof(WhiteAllInOneCls))]
    public partial interface WhiteAllInOneClsDao : DaoWritable {
		void InitializeDaoMetaData(String methodName);// Very Internal Method!

        int SelectCount(WhiteAllInOneClsCB cb);
        IList<WhiteAllInOneCls> SelectList(WhiteAllInOneClsCB cb);

        int Insert(WhiteAllInOneCls entity);
        int UpdateModifiedOnly(WhiteAllInOneCls entity);
        int UpdateNonstrictModifiedOnly(WhiteAllInOneCls entity);
        int Delete(WhiteAllInOneCls entity);
        int DeleteNonstrict(WhiteAllInOneCls entity);
    }
}
