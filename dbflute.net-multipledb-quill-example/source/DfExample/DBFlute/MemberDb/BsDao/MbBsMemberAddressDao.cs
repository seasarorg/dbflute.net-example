
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
    [Bean(typeof(MbMemberAddress))]
    public partial interface MbMemberAddressDao : MbDaoWritable {
		void InitializeDaoMetaData(String methodName);// Very Internal Method!

        int SelectCount(MbMemberAddressCB cb);
        IList<MbMemberAddress> SelectList(MbMemberAddressCB cb);

        int Insert(MbMemberAddress entity);
        int UpdateModifiedOnly(MbMemberAddress entity);
        int UpdateNonstrictModifiedOnly(MbMemberAddress entity);
        int UpdateByQuery(MbMemberAddressCB cb, MbMemberAddress entity);
        int Delete(MbMemberAddress entity);
        int DeleteNonstrict(MbMemberAddress entity);
        int DeleteByQuery(MbMemberAddressCB cb);// {DBFlute-0.7.9}
    }
}
