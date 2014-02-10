
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
    [Bean(typeof(WhitePgReserv))]
    public partial interface WhitePgReservDao : DaoWritable {
		void InitializeDaoMetaData(String methodName);// Very Internal Method!

        int SelectCount(WhitePgReservCB cb);
        IList<WhitePgReserv> SelectList(WhitePgReservCB cb);

        int Insert(WhitePgReserv entity);
        int UpdateModifiedOnly(WhitePgReserv entity);
        int UpdateNonstrictModifiedOnly(WhitePgReserv entity);
        int UpdateByQuery(WhitePgReservCB cb, WhitePgReserv entity);
        int Delete(WhitePgReserv entity);
        int DeleteNonstrict(WhitePgReserv entity);
        int DeleteByQuery(WhitePgReservCB cb);// {DBFlute-0.7.9}
    }
}
