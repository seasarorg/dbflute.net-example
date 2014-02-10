
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
    [Bean(typeof(VdSynonymVendorRefTarget))]
    public partial interface VdSynonymVendorRefTargetDao : DaoWritable {
		void InitializeDaoMetaData(String methodName);// Very Internal Method!

        int SelectCount(VdSynonymVendorRefTargetCB cb);
        IList<VdSynonymVendorRefTarget> SelectList(VdSynonymVendorRefTargetCB cb);

        int Insert(VdSynonymVendorRefTarget entity);
        int UpdateModifiedOnly(VdSynonymVendorRefTarget entity);
        int UpdateNonstrictModifiedOnly(VdSynonymVendorRefTarget entity);
        int UpdateByQuery(VdSynonymVendorRefTargetCB cb, VdSynonymVendorRefTarget entity);
        int Delete(VdSynonymVendorRefTarget entity);
        int DeleteNonstrict(VdSynonymVendorRefTarget entity);
        int DeleteByQuery(VdSynonymVendorRefTargetCB cb);// {DBFlute-0.7.9}
    }
}
