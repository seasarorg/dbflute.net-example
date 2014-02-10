
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
    [Bean(typeof(MbWithdrawalReason))]
    public partial interface MbWithdrawalReasonDao : MbDaoWritable {
		void InitializeDaoMetaData(String methodName);// Very Internal Method!

        int SelectCount(MbWithdrawalReasonCB cb);
        IList<MbWithdrawalReason> SelectList(MbWithdrawalReasonCB cb);

        int Insert(MbWithdrawalReason entity);
        int UpdateModifiedOnly(MbWithdrawalReason entity);
        int UpdateNonstrictModifiedOnly(MbWithdrawalReason entity);
        int UpdateByQuery(MbWithdrawalReasonCB cb, MbWithdrawalReason entity);
        int Delete(MbWithdrawalReason entity);
        int DeleteNonstrict(MbWithdrawalReason entity);
        int DeleteByQuery(MbWithdrawalReasonCB cb);// {DBFlute-0.7.9}
    }
}
