
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
    [Bean(typeof(VendorSynonymMember))]
    public partial interface VendorSynonymMemberDao : DaoWritable {
		void InitializeDaoMetaData(String methodName);// Very Internal Method!

        int SelectCount(VendorSynonymMemberCB cb);
        IList<VendorSynonymMember> SelectList(VendorSynonymMemberCB cb);

        int Insert(VendorSynonymMember entity);
        int UpdateModifiedOnly(VendorSynonymMember entity);
        int UpdateNonstrictModifiedOnly(VendorSynonymMember entity);
        int UpdateByQuery(VendorSynonymMemberCB cb, VendorSynonymMember entity);
        int Delete(VendorSynonymMember entity);
        int DeleteNonstrict(VendorSynonymMember entity);
        int DeleteByQuery(VendorSynonymMemberCB cb);// {DBFlute-0.7.9}
    }
}
