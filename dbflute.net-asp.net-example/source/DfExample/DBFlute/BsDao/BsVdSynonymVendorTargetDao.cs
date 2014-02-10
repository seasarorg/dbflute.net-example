
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
    [Bean(typeof(VdSynonymVendorTarget))]
    public partial interface VdSynonymVendorTargetDao : DaoWritable {
		void InitializeDaoMetaData(String methodName);// Very Internal Method!

        int SelectCount(VdSynonymVendorTargetCB cb);
        IList<VdSynonymVendorTarget> SelectList(VdSynonymVendorTargetCB cb);

        int Insert(VdSynonymVendorTarget entity);
        int UpdateModifiedOnly(VdSynonymVendorTarget entity);
        int UpdateNonstrictModifiedOnly(VdSynonymVendorTarget entity);
        int UpdateByQuery(VdSynonymVendorTargetCB cb, VdSynonymVendorTarget entity);
        int Delete(VdSynonymVendorTarget entity);
        int DeleteNonstrict(VdSynonymVendorTarget entity);
        int DeleteByQuery(VdSynonymVendorTargetCB cb);// {DBFlute-0.7.9}
    }
}
