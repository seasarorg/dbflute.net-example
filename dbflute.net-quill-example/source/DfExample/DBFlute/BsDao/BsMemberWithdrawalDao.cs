
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
    [Bean(typeof(MemberWithdrawal))]
    public partial interface MemberWithdrawalDao : DaoWritable {
		void InitializeDaoMetaData(String methodName);// Very Internal Method!

        int SelectCount(MemberWithdrawalCB cb);
        IList<MemberWithdrawal> SelectList(MemberWithdrawalCB cb);

        int Insert(MemberWithdrawal entity);
        int UpdateModifiedOnly(MemberWithdrawal entity);
        int UpdateNonstrictModifiedOnly(MemberWithdrawal entity);
        int UpdateByQuery(MemberWithdrawalCB cb, MemberWithdrawal entity);
        int Delete(MemberWithdrawal entity);
        int DeleteNonstrict(MemberWithdrawal entity);
        int DeleteByQuery(MemberWithdrawalCB cb);// {DBFlute-0.7.9}
    }
}
