
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
    [Bean(typeof(MbVendorSelfReference))]
    public partial interface MbVendorSelfReferenceDao : MbDaoWritable {
		void InitializeDaoMetaData(String methodName);// Very Internal Method!

        int SelectCount(MbVendorSelfReferenceCB cb);
        IList<MbVendorSelfReference> SelectList(MbVendorSelfReferenceCB cb);

        int Insert(MbVendorSelfReference entity);
        int UpdateModifiedOnly(MbVendorSelfReference entity);
        int UpdateNonstrictModifiedOnly(MbVendorSelfReference entity);
        int UpdateByQuery(MbVendorSelfReferenceCB cb, MbVendorSelfReference entity);
        int Delete(MbVendorSelfReference entity);
        int DeleteNonstrict(MbVendorSelfReference entity);
        int DeleteByQuery(MbVendorSelfReferenceCB cb);// {DBFlute-0.7.9}
    }
}
