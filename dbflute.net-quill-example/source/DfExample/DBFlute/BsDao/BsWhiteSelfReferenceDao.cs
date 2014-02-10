
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
    [Bean(typeof(WhiteSelfReference))]
    public partial interface WhiteSelfReferenceDao : DaoWritable {
		void InitializeDaoMetaData(String methodName);// Very Internal Method!

        int SelectCount(WhiteSelfReferenceCB cb);
        IList<WhiteSelfReference> SelectList(WhiteSelfReferenceCB cb);

        int Insert(WhiteSelfReference entity);
        int UpdateModifiedOnly(WhiteSelfReference entity);
        int UpdateNonstrictModifiedOnly(WhiteSelfReference entity);
        int UpdateByQuery(WhiteSelfReferenceCB cb, WhiteSelfReference entity);
        int Delete(WhiteSelfReference entity);
        int DeleteNonstrict(WhiteSelfReference entity);
        int DeleteByQuery(WhiteSelfReferenceCB cb);// {DBFlute-0.7.9}
    }
}
