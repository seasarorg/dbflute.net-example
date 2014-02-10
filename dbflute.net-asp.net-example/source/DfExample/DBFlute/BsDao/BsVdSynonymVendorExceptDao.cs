
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
    [Bean(typeof(VdSynonymVendorExcept))]
    public partial interface VdSynonymVendorExceptDao : DaoWritable {
		void InitializeDaoMetaData(String methodName);// Very Internal Method!

        int SelectCount(VdSynonymVendorExceptCB cb);
        IList<VdSynonymVendorExcept> SelectList(VdSynonymVendorExceptCB cb);

        int Insert(VdSynonymVendorExcept entity);
        int UpdateModifiedOnly(VdSynonymVendorExcept entity);
        int UpdateNonstrictModifiedOnly(VdSynonymVendorExcept entity);
        int UpdateByQuery(VdSynonymVendorExceptCB cb, VdSynonymVendorExcept entity);
        int Delete(VdSynonymVendorExcept entity);
        int DeleteNonstrict(VdSynonymVendorExcept entity);
        int DeleteByQuery(VdSynonymVendorExceptCB cb);// {DBFlute-0.7.9}
    }
}
