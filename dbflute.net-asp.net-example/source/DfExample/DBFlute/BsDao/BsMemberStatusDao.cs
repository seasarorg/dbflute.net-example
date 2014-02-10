
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
    [Bean(typeof(MemberStatus))]
    public partial interface MemberStatusDao : DaoWritable {
		void InitializeDaoMetaData(String methodName);// Very Internal Method!

        int SelectCount(MemberStatusCB cb);
        IList<MemberStatus> SelectList(MemberStatusCB cb);

        int Insert(MemberStatus entity);
        int UpdateModifiedOnly(MemberStatus entity);
        int UpdateNonstrictModifiedOnly(MemberStatus entity);
        int UpdateByQuery(MemberStatusCB cb, MemberStatus entity);
        int Delete(MemberStatus entity);
        int DeleteNonstrict(MemberStatus entity);
        int DeleteByQuery(MemberStatusCB cb);// {DBFlute-0.7.9}
    }
}
