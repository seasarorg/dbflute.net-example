
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
    [Bean(typeof(MyselfCheck))]
    public partial interface MyselfCheckDao : DaoWritable {
		void InitializeDaoMetaData(String methodName);// Very Internal Method!

        int SelectCount(MyselfCheckCB cb);
        IList<MyselfCheck> SelectList(MyselfCheckCB cb);

        int Insert(MyselfCheck entity);
        int UpdateModifiedOnly(MyselfCheck entity);
        int UpdateNonstrictModifiedOnly(MyselfCheck entity);
        int UpdateByQuery(MyselfCheckCB cb, MyselfCheck entity);
        int Delete(MyselfCheck entity);
        int DeleteNonstrict(MyselfCheck entity);
        int DeleteByQuery(MyselfCheckCB cb);// {DBFlute-0.7.9}
    }
}
