
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
    [Bean(typeof(VendorRefExcept))]
    public partial interface VendorRefExceptDao : DaoWritable {
		void InitializeDaoMetaData(String methodName);// Very Internal Method!

        int SelectCount(VendorRefExceptCB cb);
        IList<VendorRefExcept> SelectList(VendorRefExceptCB cb);

        int Insert(VendorRefExcept entity);
        int UpdateModifiedOnly(VendorRefExcept entity);
        int UpdateNonstrictModifiedOnly(VendorRefExcept entity);
        int UpdateByQuery(VendorRefExceptCB cb, VendorRefExcept entity);
        int Delete(VendorRefExcept entity);
        int DeleteNonstrict(VendorRefExcept entity);
        int DeleteByQuery(VendorRefExceptCB cb);// {DBFlute-0.7.9}
    }
}
