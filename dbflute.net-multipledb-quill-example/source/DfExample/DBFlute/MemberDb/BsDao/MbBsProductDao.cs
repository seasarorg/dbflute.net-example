
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
    [Bean(typeof(MbProduct))]
    public partial interface MbProductDao : MbDaoWritable {
		void InitializeDaoMetaData(String methodName);// Very Internal Method!

        int SelectCount(MbProductCB cb);
        IList<MbProduct> SelectList(MbProductCB cb);

        int Insert(MbProduct entity);
        int UpdateModifiedOnly(MbProduct entity);
        int UpdateNonstrictModifiedOnly(MbProduct entity);
        int UpdateByQuery(MbProductCB cb, MbProduct entity);
        int Delete(MbProduct entity);
        int DeleteNonstrict(MbProduct entity);
        int DeleteByQuery(MbProductCB cb);// {DBFlute-0.7.9}
    }
}
