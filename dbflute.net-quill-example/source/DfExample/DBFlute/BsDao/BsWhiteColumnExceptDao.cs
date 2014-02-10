
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
    [Bean(typeof(WhiteColumnExcept))]
    public partial interface WhiteColumnExceptDao : DaoWritable {
		void InitializeDaoMetaData(String methodName);// Very Internal Method!

        int SelectCount(WhiteColumnExceptCB cb);
        IList<WhiteColumnExcept> SelectList(WhiteColumnExceptCB cb);

        int Insert(WhiteColumnExcept entity);
        int UpdateModifiedOnly(WhiteColumnExcept entity);
        int UpdateNonstrictModifiedOnly(WhiteColumnExcept entity);
        int UpdateByQuery(WhiteColumnExceptCB cb, WhiteColumnExcept entity);
        int Delete(WhiteColumnExcept entity);
        int DeleteNonstrict(WhiteColumnExcept entity);
        int DeleteByQuery(WhiteColumnExceptCB cb);// {DBFlute-0.7.9}
    }
}
