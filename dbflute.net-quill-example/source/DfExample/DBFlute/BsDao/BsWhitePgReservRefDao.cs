
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
    [Bean(typeof(WhitePgReservRef))]
    public partial interface WhitePgReservRefDao : DaoWritable {
		void InitializeDaoMetaData(String methodName);// Very Internal Method!

        int SelectCount(WhitePgReservRefCB cb);
        IList<WhitePgReservRef> SelectList(WhitePgReservRefCB cb);

        int Insert(WhitePgReservRef entity);
        int UpdateModifiedOnly(WhitePgReservRef entity);
        int UpdateNonstrictModifiedOnly(WhitePgReservRef entity);
        int UpdateByQuery(WhitePgReservRefCB cb, WhitePgReservRef entity);
        int Delete(WhitePgReservRef entity);
        int DeleteNonstrict(WhitePgReservRef entity);
        int DeleteByQuery(WhitePgReservRefCB cb);// {DBFlute-0.7.9}
    }
}
