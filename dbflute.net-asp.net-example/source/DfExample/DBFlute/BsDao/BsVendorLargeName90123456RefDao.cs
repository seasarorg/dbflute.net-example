
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
    [Bean(typeof(VendorLargeName90123456Ref))]
    public partial interface VendorLargeName90123456RefDao : DaoWritable {
		void InitializeDaoMetaData(String methodName);// Very Internal Method!

        int SelectCount(VendorLargeName90123456RefCB cb);
        IList<VendorLargeName90123456Ref> SelectList(VendorLargeName90123456RefCB cb);

        int Insert(VendorLargeName90123456Ref entity);
        int UpdateModifiedOnly(VendorLargeName90123456Ref entity);
        int UpdateNonstrictModifiedOnly(VendorLargeName90123456Ref entity);
        int UpdateByQuery(VendorLargeName90123456RefCB cb, VendorLargeName90123456Ref entity);
        int Delete(VendorLargeName90123456Ref entity);
        int DeleteNonstrict(VendorLargeName90123456Ref entity);
        int DeleteByQuery(VendorLargeName90123456RefCB cb);// {DBFlute-0.7.9}
    }
}
