
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
    [Bean(typeof(WhiteCompoundPkRefNest))]
    public partial interface WhiteCompoundPkRefNestDao : DaoWritable {
		void InitializeDaoMetaData(String methodName);// Very Internal Method!

        int SelectCount(WhiteCompoundPkRefNestCB cb);
        IList<WhiteCompoundPkRefNest> SelectList(WhiteCompoundPkRefNestCB cb);

        int Insert(WhiteCompoundPkRefNest entity);
        int UpdateModifiedOnly(WhiteCompoundPkRefNest entity);
        int UpdateNonstrictModifiedOnly(WhiteCompoundPkRefNest entity);
        int UpdateByQuery(WhiteCompoundPkRefNestCB cb, WhiteCompoundPkRefNest entity);
        int Delete(WhiteCompoundPkRefNest entity);
        int DeleteNonstrict(WhiteCompoundPkRefNest entity);
        int DeleteByQuery(WhiteCompoundPkRefNestCB cb);// {DBFlute-0.7.9}
    }
}
