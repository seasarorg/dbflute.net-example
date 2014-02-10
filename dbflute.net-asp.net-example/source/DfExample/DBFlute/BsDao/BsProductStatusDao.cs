
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
    [Bean(typeof(ProductStatus))]
    public partial interface ProductStatusDao : DaoWritable {
		void InitializeDaoMetaData(String methodName);// Very Internal Method!

        int SelectCount(ProductStatusCB cb);
        IList<ProductStatus> SelectList(ProductStatusCB cb);

        int Insert(ProductStatus entity);
        int UpdateModifiedOnly(ProductStatus entity);
        int UpdateNonstrictModifiedOnly(ProductStatus entity);
        int UpdateByQuery(ProductStatusCB cb, ProductStatus entity);
        int Delete(ProductStatus entity);
        int DeleteNonstrict(ProductStatus entity);
        int DeleteByQuery(ProductStatusCB cb);// {DBFlute-0.7.9}
    }
}
