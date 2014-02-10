
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
    [Bean(typeof(WhiteMyselfCheck))]
    public partial interface WhiteMyselfCheckDao : DaoWritable {
		void InitializeDaoMetaData(String methodName);// Very Internal Method!

        int SelectCount(WhiteMyselfCheckCB cb);
        IList<WhiteMyselfCheck> SelectList(WhiteMyselfCheckCB cb);

        int Insert(WhiteMyselfCheck entity);
        int UpdateModifiedOnly(WhiteMyselfCheck entity);
        int UpdateNonstrictModifiedOnly(WhiteMyselfCheck entity);
        int UpdateByQuery(WhiteMyselfCheckCB cb, WhiteMyselfCheck entity);
        int Delete(WhiteMyselfCheck entity);
        int DeleteNonstrict(WhiteMyselfCheck entity);
        int DeleteByQuery(WhiteMyselfCheckCB cb);// {DBFlute-0.7.9}
    }
}
