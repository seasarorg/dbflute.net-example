
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
    [Bean(typeof(MbMemberLogin))]
    public partial interface MbMemberLoginDao : MbDaoWritable {
		void InitializeDaoMetaData(String methodName);// Very Internal Method!

        int SelectCount(MbMemberLoginCB cb);
        IList<MbMemberLogin> SelectList(MbMemberLoginCB cb);

        int Insert(MbMemberLogin entity);
        int UpdateModifiedOnly(MbMemberLogin entity);
        int UpdateNonstrictModifiedOnly(MbMemberLogin entity);
        int UpdateByQuery(MbMemberLoginCB cb, MbMemberLogin entity);
        int Delete(MbMemberLogin entity);
        int DeleteNonstrict(MbMemberLogin entity);
        int DeleteByQuery(MbMemberLoginCB cb);// {DBFlute-0.7.9}
    }
}
