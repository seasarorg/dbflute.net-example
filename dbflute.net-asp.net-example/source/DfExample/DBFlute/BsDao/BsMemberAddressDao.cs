
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
    [Bean(typeof(MemberAddress))]
    public partial interface MemberAddressDao : DaoWritable {
		void InitializeDaoMetaData(String methodName);// Very Internal Method!

        int SelectCount(MemberAddressCB cb);
        IList<MemberAddress> SelectList(MemberAddressCB cb);

        int Insert(MemberAddress entity);
        int UpdateModifiedOnly(MemberAddress entity);
        int UpdateNonstrictModifiedOnly(MemberAddress entity);
        int UpdateByQuery(MemberAddressCB cb, MemberAddress entity);
        int Delete(MemberAddress entity);
        int DeleteNonstrict(MemberAddress entity);
        int DeleteByQuery(MemberAddressCB cb);// {DBFlute-0.7.9}
    }
}
