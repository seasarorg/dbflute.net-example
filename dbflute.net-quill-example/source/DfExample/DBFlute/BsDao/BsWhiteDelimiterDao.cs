
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
    [Bean(typeof(WhiteDelimiter))]
    public partial interface WhiteDelimiterDao : DaoWritable {
		void InitializeDaoMetaData(String methodName);// Very Internal Method!

        int SelectCount(WhiteDelimiterCB cb);
        IList<WhiteDelimiter> SelectList(WhiteDelimiterCB cb);

        int Insert(WhiteDelimiter entity);
        int UpdateModifiedOnly(WhiteDelimiter entity);
        int UpdateNonstrictModifiedOnly(WhiteDelimiter entity);
        int UpdateByQuery(WhiteDelimiterCB cb, WhiteDelimiter entity);
        int Delete(WhiteDelimiter entity);
        int DeleteNonstrict(WhiteDelimiter entity);
        int DeleteByQuery(WhiteDelimiterCB cb);// {DBFlute-0.7.9}
    }
}
