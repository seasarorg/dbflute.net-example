
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
    [Bean(typeof(Product))]
    public partial interface ProductDao : DaoWritable {
		void InitializeDaoMetaData(String methodName);// Very Internal Method!

        int SelectCount(ProductCB cb);
        IList<Product> SelectList(ProductCB cb);

        int Insert(Product entity);
        int UpdateModifiedOnly(Product entity);
        int UpdateNonstrictModifiedOnly(Product entity);
        int UpdateByQuery(ProductCB cb, Product entity);
        int Delete(Product entity);
        int DeleteNonstrict(Product entity);
        int DeleteByQuery(ProductCB cb);// {DBFlute-0.7.9}

        long? SelectNextVal();
    }
}
