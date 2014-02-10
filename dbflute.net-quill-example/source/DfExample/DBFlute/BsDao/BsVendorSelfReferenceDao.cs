
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
    [Bean(typeof(VendorSelfReference))]
    public partial interface VendorSelfReferenceDao : DaoWritable {
		void InitializeDaoMetaData(String methodName);// Very Internal Method!

        int SelectCount(VendorSelfReferenceCB cb);
        IList<VendorSelfReference> SelectList(VendorSelfReferenceCB cb);

        int Insert(VendorSelfReference entity);
        int UpdateModifiedOnly(VendorSelfReference entity);
        int UpdateNonstrictModifiedOnly(VendorSelfReference entity);
        int UpdateByQuery(VendorSelfReferenceCB cb, VendorSelfReference entity);
        int Delete(VendorSelfReference entity);
        int DeleteNonstrict(VendorSelfReference entity);
        int DeleteByQuery(VendorSelfReferenceCB cb);// {DBFlute-0.7.9}
    }
}
