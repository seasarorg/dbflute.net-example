
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
    [Bean(typeof(VdSynonymProductStatus))]
    public partial interface VdSynonymProductStatusDao : DaoWritable {
		void InitializeDaoMetaData(String methodName);// Very Internal Method!

        int SelectCount(VdSynonymProductStatusCB cb);
        IList<VdSynonymProductStatus> SelectList(VdSynonymProductStatusCB cb);

        int Insert(VdSynonymProductStatus entity);
        int UpdateModifiedOnly(VdSynonymProductStatus entity);
        int UpdateNonstrictModifiedOnly(VdSynonymProductStatus entity);
        int UpdateByQuery(VdSynonymProductStatusCB cb, VdSynonymProductStatus entity);
        int Delete(VdSynonymProductStatus entity);
        int DeleteNonstrict(VdSynonymProductStatus entity);
        int DeleteByQuery(VdSynonymProductStatusCB cb);// {DBFlute-0.7.9}
    }
}
