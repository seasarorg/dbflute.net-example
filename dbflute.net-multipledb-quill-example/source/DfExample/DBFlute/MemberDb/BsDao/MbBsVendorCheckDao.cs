
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
    [Bean(typeof(MbVendorCheck))]
    public partial interface MbVendorCheckDao : MbDaoWritable {
		void InitializeDaoMetaData(String methodName);// Very Internal Method!

        int SelectCount(MbVendorCheckCB cb);
        IList<MbVendorCheck> SelectList(MbVendorCheckCB cb);

        int Insert(MbVendorCheck entity);
        int UpdateModifiedOnly(MbVendorCheck entity);
        int UpdateNonstrictModifiedOnly(MbVendorCheck entity);
        int UpdateByQuery(MbVendorCheckCB cb, MbVendorCheck entity);
        int Delete(MbVendorCheck entity);
        int DeleteNonstrict(MbVendorCheck entity);
        int DeleteByQuery(MbVendorCheckCB cb);// {DBFlute-0.7.9}
    }
}
