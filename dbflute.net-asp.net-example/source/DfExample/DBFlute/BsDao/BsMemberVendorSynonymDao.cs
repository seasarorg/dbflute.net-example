
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
    [Bean(typeof(MemberVendorSynonym))]
    public partial interface MemberVendorSynonymDao : DaoWritable {
		void InitializeDaoMetaData(String methodName);// Very Internal Method!

        int SelectCount(MemberVendorSynonymCB cb);
        IList<MemberVendorSynonym> SelectList(MemberVendorSynonymCB cb);

        int Insert(MemberVendorSynonym entity);
        int UpdateModifiedOnly(MemberVendorSynonym entity);
        int UpdateNonstrictModifiedOnly(MemberVendorSynonym entity);
        int UpdateByQuery(MemberVendorSynonymCB cb, MemberVendorSynonym entity);
        int Delete(MemberVendorSynonym entity);
        int DeleteNonstrict(MemberVendorSynonym entity);
        int DeleteByQuery(MemberVendorSynonymCB cb);// {DBFlute-0.7.9}
    }
}
