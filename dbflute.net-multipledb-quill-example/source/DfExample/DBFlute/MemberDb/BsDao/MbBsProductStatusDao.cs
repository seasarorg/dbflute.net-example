
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
    [Bean(typeof(MbProductStatus))]
    public partial interface MbProductStatusDao : MbDaoWritable {
		void InitializeDaoMetaData(String methodName);// Very Internal Method!

        int SelectCount(MbProductStatusCB cb);
        IList<MbProductStatus> SelectList(MbProductStatusCB cb);

        int Insert(MbProductStatus entity);
        int UpdateModifiedOnly(MbProductStatus entity);
        int UpdateNonstrictModifiedOnly(MbProductStatus entity);
        int UpdateByQuery(MbProductStatusCB cb, MbProductStatus entity);
        int Delete(MbProductStatus entity);
        int DeleteNonstrict(MbProductStatus entity);
        int DeleteByQuery(MbProductStatusCB cb);// {DBFlute-0.7.9}
    }
}
