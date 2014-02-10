
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
    [Bean(typeof(MbMemberStatus))]
    public partial interface MbMemberStatusDao : MbDaoWritable {
		void InitializeDaoMetaData(String methodName);// Very Internal Method!

        int SelectCount(MbMemberStatusCB cb);
        IList<MbMemberStatus> SelectList(MbMemberStatusCB cb);

        int Insert(MbMemberStatus entity);
        int UpdateModifiedOnly(MbMemberStatus entity);
        int UpdateNonstrictModifiedOnly(MbMemberStatus entity);
        int UpdateByQuery(MbMemberStatusCB cb, MbMemberStatus entity);
        int Delete(MbMemberStatus entity);
        int DeleteNonstrict(MbMemberStatus entity);
        int DeleteByQuery(MbMemberStatusCB cb);// {DBFlute-0.7.9}
    }
}
