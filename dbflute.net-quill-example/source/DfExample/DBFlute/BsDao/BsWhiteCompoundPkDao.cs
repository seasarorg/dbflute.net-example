
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
    [Bean(typeof(WhiteCompoundPk))]
    public partial interface WhiteCompoundPkDao : DaoWritable {
		void InitializeDaoMetaData(String methodName);// Very Internal Method!

        int SelectCount(WhiteCompoundPkCB cb);
        IList<WhiteCompoundPk> SelectList(WhiteCompoundPkCB cb);

        int Insert(WhiteCompoundPk entity);
        int UpdateModifiedOnly(WhiteCompoundPk entity);
        int UpdateNonstrictModifiedOnly(WhiteCompoundPk entity);
        int Delete(WhiteCompoundPk entity);
        int DeleteNonstrict(WhiteCompoundPk entity);
    }
}
