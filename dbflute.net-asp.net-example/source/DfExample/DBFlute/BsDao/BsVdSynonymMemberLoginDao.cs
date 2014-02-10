
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
    [Bean(typeof(VdSynonymMemberLogin))]
    public partial interface VdSynonymMemberLoginDao : DaoWritable {
		void InitializeDaoMetaData(String methodName);// Very Internal Method!

        int SelectCount(VdSynonymMemberLoginCB cb);
        IList<VdSynonymMemberLogin> SelectList(VdSynonymMemberLoginCB cb);

        int Insert(VdSynonymMemberLogin entity);
        int UpdateModifiedOnly(VdSynonymMemberLogin entity);
        int UpdateNonstrictModifiedOnly(VdSynonymMemberLogin entity);
        int UpdateByQuery(VdSynonymMemberLoginCB cb, VdSynonymMemberLogin entity);
        int Delete(VdSynonymMemberLogin entity);
        int DeleteNonstrict(VdSynonymMemberLogin entity);
        int DeleteByQuery(VdSynonymMemberLoginCB cb);// {DBFlute-0.7.9}
    }
}
