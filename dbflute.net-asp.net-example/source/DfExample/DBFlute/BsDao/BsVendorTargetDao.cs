
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
    [Bean(typeof(VendorTarget))]
    public partial interface VendorTargetDao : DaoWritable {
		void InitializeDaoMetaData(String methodName);// Very Internal Method!

        int SelectCount(VendorTargetCB cb);
        IList<VendorTarget> SelectList(VendorTargetCB cb);

        int Insert(VendorTarget entity);
        int UpdateModifiedOnly(VendorTarget entity);
        int UpdateNonstrictModifiedOnly(VendorTarget entity);
        int UpdateByQuery(VendorTargetCB cb, VendorTarget entity);
        int Delete(VendorTarget entity);
        int DeleteNonstrict(VendorTarget entity);
        int DeleteByQuery(VendorTargetCB cb);// {DBFlute-0.7.9}
    }
}
