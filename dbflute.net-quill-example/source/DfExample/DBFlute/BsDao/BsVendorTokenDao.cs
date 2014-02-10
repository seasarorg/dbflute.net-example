
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
    [Bean(typeof(VendorToken))]
    public partial interface VendorTokenDao : DaoWritable {
		void InitializeDaoMetaData(String methodName);// Very Internal Method!

        int SelectCount(VendorTokenCB cb);
        IList<VendorToken> SelectList(VendorTokenCB cb);

        int Insert(VendorToken entity);
        int UpdateModifiedOnly(VendorToken entity);
        int UpdateNonstrictModifiedOnly(VendorToken entity);
        int UpdateByQuery(VendorTokenCB cb, VendorToken entity);
        int Delete(VendorToken entity);
        int DeleteNonstrict(VendorToken entity);
        int DeleteByQuery(VendorTokenCB cb);// {DBFlute-0.7.9}
    }
}
