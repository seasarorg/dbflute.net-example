
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
    [Bean(typeof(VendorCheck))]
    public partial interface VendorCheckDao : DaoWritable {
		void InitializeDaoMetaData(String methodName);// Very Internal Method!

        int SelectCount(VendorCheckCB cb);
        IList<VendorCheck> SelectList(VendorCheckCB cb);

        int Insert(VendorCheck entity);
        int UpdateModifiedOnly(VendorCheck entity);
        int UpdateNonstrictModifiedOnly(VendorCheck entity);
        int UpdateByQuery(VendorCheckCB cb, VendorCheck entity);
        int Delete(VendorCheck entity);
        int DeleteNonstrict(VendorCheck entity);
        int DeleteByQuery(VendorCheckCB cb);// {DBFlute-0.7.9}
    }
}
