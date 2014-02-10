
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
    [Bean(typeof(Purchase))]
    public partial interface PurchaseDao : DaoWritable {
		void InitializeDaoMetaData(String methodName);// Very Internal Method!

        int SelectCount(PurchaseCB cb);
        IList<Purchase> SelectList(PurchaseCB cb);

        int Insert(Purchase entity);
        int UpdateModifiedOnly(Purchase entity);
        int UpdateNonstrictModifiedOnly(Purchase entity);
        int UpdateByQuery(PurchaseCB cb, Purchase entity);
        int Delete(Purchase entity);
        int DeleteNonstrict(Purchase entity);
        int DeleteByQuery(PurchaseCB cb);// {DBFlute-0.7.9}
    }
}
