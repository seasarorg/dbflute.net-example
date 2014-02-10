
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
    [Bean(typeof(VdSynonymVendorRefExcept))]
    public partial interface VdSynonymVendorRefExceptDao : DaoWritable {
		void InitializeDaoMetaData(String methodName);// Very Internal Method!

        int SelectCount(VdSynonymVendorRefExceptCB cb);
        IList<VdSynonymVendorRefExcept> SelectList(VdSynonymVendorRefExceptCB cb);

        int Insert(VdSynonymVendorRefExcept entity);
        int UpdateModifiedOnly(VdSynonymVendorRefExcept entity);
        int UpdateNonstrictModifiedOnly(VdSynonymVendorRefExcept entity);
        int UpdateByQuery(VdSynonymVendorRefExceptCB cb, VdSynonymVendorRefExcept entity);
        int Delete(VdSynonymVendorRefExcept entity);
        int DeleteNonstrict(VdSynonymVendorRefExcept entity);
        int DeleteByQuery(VdSynonymVendorRefExceptCB cb);// {DBFlute-0.7.9}
    }
}
