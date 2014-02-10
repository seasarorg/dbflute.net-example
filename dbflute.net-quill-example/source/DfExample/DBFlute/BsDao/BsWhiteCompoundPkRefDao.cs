
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
    [Bean(typeof(WhiteCompoundPkRef))]
    public partial interface WhiteCompoundPkRefDao : DaoWritable {
		void InitializeDaoMetaData(String methodName);// Very Internal Method!

        int SelectCount(WhiteCompoundPkRefCB cb);
        IList<WhiteCompoundPkRef> SelectList(WhiteCompoundPkRefCB cb);

        int Insert(WhiteCompoundPkRef entity);
        int UpdateModifiedOnly(WhiteCompoundPkRef entity);
        int UpdateNonstrictModifiedOnly(WhiteCompoundPkRef entity);
        int Delete(WhiteCompoundPkRef entity);
        int DeleteNonstrict(WhiteCompoundPkRef entity);
    }
}
