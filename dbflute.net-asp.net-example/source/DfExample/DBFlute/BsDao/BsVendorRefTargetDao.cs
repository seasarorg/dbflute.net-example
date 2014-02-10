
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
    [Bean(typeof(VendorRefTarget))]
    public partial interface VendorRefTargetDao : DaoWritable {
		void InitializeDaoMetaData(String methodName);// Very Internal Method!

        int SelectCount(VendorRefTargetCB cb);
        IList<VendorRefTarget> SelectList(VendorRefTargetCB cb);

        int Insert(VendorRefTarget entity);
        int UpdateModifiedOnly(VendorRefTarget entity);
        int UpdateNonstrictModifiedOnly(VendorRefTarget entity);
        int UpdateByQuery(VendorRefTargetCB cb, VendorRefTarget entity);
        int Delete(VendorRefTarget entity);
        int DeleteNonstrict(VendorRefTarget entity);
        int DeleteByQuery(VendorRefTargetCB cb);// {DBFlute-0.7.9}
    }
}
