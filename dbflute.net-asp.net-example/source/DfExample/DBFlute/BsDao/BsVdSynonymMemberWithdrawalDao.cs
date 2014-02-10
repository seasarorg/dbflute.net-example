
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
    [Bean(typeof(VdSynonymMemberWithdrawal))]
    public partial interface VdSynonymMemberWithdrawalDao : DaoWritable {
		void InitializeDaoMetaData(String methodName);// Very Internal Method!

        int SelectCount(VdSynonymMemberWithdrawalCB cb);
        IList<VdSynonymMemberWithdrawal> SelectList(VdSynonymMemberWithdrawalCB cb);

        int Insert(VdSynonymMemberWithdrawal entity);
        int UpdateModifiedOnly(VdSynonymMemberWithdrawal entity);
        int UpdateNonstrictModifiedOnly(VdSynonymMemberWithdrawal entity);
        int UpdateByQuery(VdSynonymMemberWithdrawalCB cb, VdSynonymMemberWithdrawal entity);
        int Delete(VdSynonymMemberWithdrawal entity);
        int DeleteNonstrict(VdSynonymMemberWithdrawal entity);
        int DeleteByQuery(VdSynonymMemberWithdrawalCB cb);// {DBFlute-0.7.9}
    }
}
