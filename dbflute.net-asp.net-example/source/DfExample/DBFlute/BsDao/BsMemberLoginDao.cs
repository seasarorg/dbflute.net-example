
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
    [Bean(typeof(MemberLogin))]
    public partial interface MemberLoginDao : DaoWritable {
		void InitializeDaoMetaData(String methodName);// Very Internal Method!

        int SelectCount(MemberLoginCB cb);
        IList<MemberLogin> SelectList(MemberLoginCB cb);

        int Insert(MemberLogin entity);
        int UpdateModifiedOnly(MemberLogin entity);
        int UpdateNonstrictModifiedOnly(MemberLogin entity);
        int UpdateByQuery(MemberLoginCB cb, MemberLogin entity);
        int Delete(MemberLogin entity);
        int DeleteNonstrict(MemberLogin entity);
        int DeleteByQuery(MemberLoginCB cb);// {DBFlute-0.7.9}

        long? SelectNextVal();
    }
}
