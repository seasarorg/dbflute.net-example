
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
    [Bean(typeof(WhiteMyself))]
    public partial interface WhiteMyselfDao : DaoWritable {
		void InitializeDaoMetaData(String methodName);// Very Internal Method!

        int SelectCount(WhiteMyselfCB cb);
        IList<WhiteMyself> SelectList(WhiteMyselfCB cb);

        int Insert(WhiteMyself entity);
        int UpdateModifiedOnly(WhiteMyself entity);
        int UpdateNonstrictModifiedOnly(WhiteMyself entity);
        int UpdateByQuery(WhiteMyselfCB cb, WhiteMyself entity);
        int Delete(WhiteMyself entity);
        int DeleteNonstrict(WhiteMyself entity);
        int DeleteByQuery(WhiteMyselfCB cb);// {DBFlute-0.7.9}
    }
}
