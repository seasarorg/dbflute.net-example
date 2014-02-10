
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
    [Bean(typeof(SummaryMemberPurchase))]
    public partial interface SummaryMemberPurchaseDao : DaoReadable {
		void InitializeDaoMetaData(String methodName);// Very Internal Method!

        int SelectCount(SummaryMemberPurchaseCB cb);
        IList<SummaryMemberPurchase> SelectList(SummaryMemberPurchaseCB cb);

    }
}
