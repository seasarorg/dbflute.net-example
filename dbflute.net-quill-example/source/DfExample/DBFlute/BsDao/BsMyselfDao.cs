
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
    [Bean(typeof(Myself))]
    public partial interface MyselfDao : DaoWritable {
		void InitializeDaoMetaData(String methodName);// Very Internal Method!

        int SelectCount(MyselfCB cb);
        IList<Myself> SelectList(MyselfCB cb);

        int Insert(Myself entity);
        int UpdateModifiedOnly(Myself entity);
        int UpdateNonstrictModifiedOnly(Myself entity);
        int UpdateByQuery(MyselfCB cb, Myself entity);
        int Delete(Myself entity);
        int DeleteNonstrict(Myself entity);
        int DeleteByQuery(MyselfCB cb);// {DBFlute-0.7.9}
    }
}
