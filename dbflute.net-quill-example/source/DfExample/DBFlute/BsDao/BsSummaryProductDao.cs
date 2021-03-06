
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
    [Bean(typeof(SummaryProduct))]
    public partial interface SummaryProductDao : DaoWritable {
		void InitializeDaoMetaData(String methodName);// Very Internal Method!

        int SelectCount(SummaryProductCB cb);
        IList<SummaryProduct> SelectList(SummaryProductCB cb);

        int Insert(SummaryProduct entity);
        int UpdateModifiedOnly(SummaryProduct entity);
        int UpdateNonstrictModifiedOnly(SummaryProduct entity);
        int UpdateByQuery(SummaryProductCB cb, SummaryProduct entity);
        int Delete(SummaryProduct entity);
        int DeleteNonstrict(SummaryProduct entity);
        int DeleteByQuery(SummaryProductCB cb);// {DBFlute-0.7.9}
    }
}
