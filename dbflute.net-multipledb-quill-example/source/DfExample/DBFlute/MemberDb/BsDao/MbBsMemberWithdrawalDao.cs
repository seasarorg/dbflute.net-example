
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
    [Bean(typeof(MbMemberWithdrawal))]
    public partial interface MbMemberWithdrawalDao : MbDaoWritable {
		void InitializeDaoMetaData(String methodName);// Very Internal Method!

        int SelectCount(MbMemberWithdrawalCB cb);
        IList<MbMemberWithdrawal> SelectList(MbMemberWithdrawalCB cb);

        int Insert(MbMemberWithdrawal entity);
        int UpdateModifiedOnly(MbMemberWithdrawal entity);
        int UpdateNonstrictModifiedOnly(MbMemberWithdrawal entity);
        int UpdateByQuery(MbMemberWithdrawalCB cb, MbMemberWithdrawal entity);
        int Delete(MbMemberWithdrawal entity);
        int DeleteNonstrict(MbMemberWithdrawal entity);
        int DeleteByQuery(MbMemberWithdrawalCB cb);// {DBFlute-0.7.9}
    }
}
