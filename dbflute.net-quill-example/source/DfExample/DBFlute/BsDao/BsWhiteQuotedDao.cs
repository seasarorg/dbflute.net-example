
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
    [Bean(typeof(WhiteQuoted))]
    public partial interface WhiteQuotedDao : DaoWritable {
		void InitializeDaoMetaData(String methodName);// Very Internal Method!

        int SelectCount(WhiteQuotedCB cb);
        IList<WhiteQuoted> SelectList(WhiteQuotedCB cb);

        int Insert(WhiteQuoted entity);
        int UpdateModifiedOnly(WhiteQuoted entity);
        int UpdateNonstrictModifiedOnly(WhiteQuoted entity);
        int UpdateByQuery(WhiteQuotedCB cb, WhiteQuoted entity);
        int Delete(WhiteQuoted entity);
        int DeleteNonstrict(WhiteQuoted entity);
        int DeleteByQuery(WhiteQuotedCB cb);// {DBFlute-0.7.9}
    }
}
