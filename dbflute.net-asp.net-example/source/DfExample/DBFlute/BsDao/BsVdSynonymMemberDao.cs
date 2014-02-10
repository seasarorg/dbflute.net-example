
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
    [Bean(typeof(VdSynonymMember))]
    public partial interface VdSynonymMemberDao : DaoWritable {
		void InitializeDaoMetaData(String methodName);// Very Internal Method!

        int SelectCount(VdSynonymMemberCB cb);
        IList<VdSynonymMember> SelectList(VdSynonymMemberCB cb);

        int Insert(VdSynonymMember entity);
        int UpdateModifiedOnly(VdSynonymMember entity);
        int UpdateNonstrictModifiedOnly(VdSynonymMember entity);
        int UpdateByQuery(VdSynonymMemberCB cb, VdSynonymMember entity);
        int Delete(VdSynonymMember entity);
        int DeleteNonstrict(VdSynonymMember entity);
        int DeleteByQuery(VdSynonymMemberCB cb);// {DBFlute-0.7.9}
    }
}
