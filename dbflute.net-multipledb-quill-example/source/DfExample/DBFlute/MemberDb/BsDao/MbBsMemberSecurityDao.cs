
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
    [Bean(typeof(MbMemberSecurity))]
    public partial interface MbMemberSecurityDao : MbDaoWritable {
		void InitializeDaoMetaData(String methodName);// Very Internal Method!

        int SelectCount(MbMemberSecurityCB cb);
        IList<MbMemberSecurity> SelectList(MbMemberSecurityCB cb);

        int Insert(MbMemberSecurity entity);
        int UpdateModifiedOnly(MbMemberSecurity entity);
        int UpdateNonstrictModifiedOnly(MbMemberSecurity entity);
        int UpdateByQuery(MbMemberSecurityCB cb, MbMemberSecurity entity);
        int Delete(MbMemberSecurity entity);
        int DeleteNonstrict(MbMemberSecurity entity);
        int DeleteByQuery(MbMemberSecurityCB cb);// {DBFlute-0.7.9}
    }
}
