
using System;
using System.Collections.Generic;

using Seasar.Quill.Attrs;
using Seasar.Dao.Attrs;

using DfExample.DBFlute.MemberDb.AllCommon;
using DfExample.DBFlute.MemberDb.AllCommon.S2Dao;
using DfExample.DBFlute.MemberDb.ExEntity;
using DfExample.DBFlute.MemberDb.CBean;

namespace DfExample.DBFlute.MemberDb.ExDao {

    [Implementation]
    [S2Dao(typeof(MbS2DaoSetting))]
    [Bean(typeof(MbPurchase))]
    public partial interface MbPurchaseDao : MbDaoWritable {
		void InitializeDaoMetaData(String methodName);// Very Internal Method!

        int SelectCount(MbPurchaseCB cb);
        IList<MbPurchase> SelectList(MbPurchaseCB cb);

        int Insert(MbPurchase entity);
        int UpdateModifiedOnly(MbPurchase entity);
        int UpdateNonstrictModifiedOnly(MbPurchase entity);
        int UpdateByQuery(MbPurchaseCB cb, MbPurchase entity);
        int Delete(MbPurchase entity);
        int DeleteNonstrict(MbPurchase entity);
        int DeleteByQuery(MbPurchaseCB cb);// {DBFlute-0.7.9}
    }
}
