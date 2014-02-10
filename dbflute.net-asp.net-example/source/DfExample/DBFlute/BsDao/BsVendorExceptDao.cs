
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
    [Bean(typeof(VendorExcept))]
    public partial interface VendorExceptDao : DaoWritable {
		void InitializeDaoMetaData(String methodName);// Very Internal Method!

        int SelectCount(VendorExceptCB cb);
        IList<VendorExcept> SelectList(VendorExceptCB cb);

        int Insert(VendorExcept entity);
        int UpdateModifiedOnly(VendorExcept entity);
        int UpdateNonstrictModifiedOnly(VendorExcept entity);
        int UpdateByQuery(VendorExceptCB cb, VendorExcept entity);
        int Delete(VendorExcept entity);
        int DeleteNonstrict(VendorExcept entity);
        int DeleteByQuery(VendorExceptCB cb);// {DBFlute-0.7.9}
    }
}
