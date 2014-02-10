
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
    [Bean(typeof(Member))]
    public partial interface MemberDao : DaoWritable {
		void InitializeDaoMetaData(String methodName);// Very Internal Method!

        int SelectCount(MemberCB cb);
        IList<Member> SelectList(MemberCB cb);

        int Insert(Member entity);
        int UpdateModifiedOnly(Member entity);
        int UpdateNonstrictModifiedOnly(Member entity);
        int UpdateByQuery(MemberCB cb, Member entity);
        int Delete(Member entity);
        int DeleteNonstrict(Member entity);
        int DeleteByQuery(MemberCB cb);// {DBFlute-0.7.9}
    }
}
