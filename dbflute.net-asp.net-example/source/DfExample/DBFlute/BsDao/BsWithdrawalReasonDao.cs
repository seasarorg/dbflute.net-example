
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
    [Bean(typeof(WithdrawalReason))]
    public partial interface WithdrawalReasonDao : DaoWritable {
		void InitializeDaoMetaData(String methodName);// Very Internal Method!

        int SelectCount(WithdrawalReasonCB cb);
        IList<WithdrawalReason> SelectList(WithdrawalReasonCB cb);

        int Insert(WithdrawalReason entity);
        int UpdateModifiedOnly(WithdrawalReason entity);
        int UpdateNonstrictModifiedOnly(WithdrawalReason entity);
        int UpdateByQuery(WithdrawalReasonCB cb, WithdrawalReason entity);
        int Delete(WithdrawalReason entity);
        int DeleteNonstrict(WithdrawalReason entity);
        int DeleteByQuery(WithdrawalReasonCB cb);// {DBFlute-0.7.9}
    }
}
