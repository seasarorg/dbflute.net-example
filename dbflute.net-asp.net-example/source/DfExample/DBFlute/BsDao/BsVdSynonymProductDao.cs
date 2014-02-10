
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
    [Bean(typeof(VdSynonymProduct))]
    public partial interface VdSynonymProductDao : DaoWritable {
		void InitializeDaoMetaData(String methodName);// Very Internal Method!

        int SelectCount(VdSynonymProductCB cb);
        IList<VdSynonymProduct> SelectList(VdSynonymProductCB cb);

        int Insert(VdSynonymProduct entity);
        int UpdateModifiedOnly(VdSynonymProduct entity);
        int UpdateNonstrictModifiedOnly(VdSynonymProduct entity);
        int UpdateByQuery(VdSynonymProductCB cb, VdSynonymProduct entity);
        int Delete(VdSynonymProduct entity);
        int DeleteNonstrict(VdSynonymProduct entity);
        int DeleteByQuery(VdSynonymProductCB cb);// {DBFlute-0.7.9}
    }
}
