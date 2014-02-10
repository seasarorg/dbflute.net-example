
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
    [Bean(typeof(VendorLargeName901234567890))]
    public partial interface VendorLargeName901234567890Dao : DaoWritable {
		void InitializeDaoMetaData(String methodName);// Very Internal Method!

        int SelectCount(VendorLargeName901234567890CB cb);
        IList<VendorLargeName901234567890> SelectList(VendorLargeName901234567890CB cb);

        int Insert(VendorLargeName901234567890 entity);
        int UpdateModifiedOnly(VendorLargeName901234567890 entity);
        int UpdateNonstrictModifiedOnly(VendorLargeName901234567890 entity);
        int UpdateByQuery(VendorLargeName901234567890CB cb, VendorLargeName901234567890 entity);
        int Delete(VendorLargeName901234567890 entity);
        int DeleteNonstrict(VendorLargeName901234567890 entity);
        int DeleteByQuery(VendorLargeName901234567890CB cb);// {DBFlute-0.7.9}
    }
}
