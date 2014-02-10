
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
    [Bean(typeof(MbMember))]
    public partial interface MbMemberDao : MbDaoWritable {
		void InitializeDaoMetaData(String methodName);// Very Internal Method!

        int SelectCount(MbMemberCB cb);
        IList<MbMember> SelectList(MbMemberCB cb);

        int Insert(MbMember entity);
        int UpdateModifiedOnly(MbMember entity);
        int UpdateNonstrictModifiedOnly(MbMember entity);
        int UpdateByQuery(MbMemberCB cb, MbMember entity);
        int Delete(MbMember entity);
        int DeleteNonstrict(MbMember entity);
        int DeleteByQuery(MbMemberCB cb);// {DBFlute-0.7.9}
    }
}
