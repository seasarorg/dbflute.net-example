
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
    [Bean(typeof(MemberSecurity))]
    public partial interface MemberSecurityDao : DaoWritable {
		void InitializeDaoMetaData(String methodName);// Very Internal Method!

        int SelectCount(MemberSecurityCB cb);
        IList<MemberSecurity> SelectList(MemberSecurityCB cb);

        int Insert(MemberSecurity entity);
        int UpdateModifiedOnly(MemberSecurity entity);
        int UpdateNonstrictModifiedOnly(MemberSecurity entity);
        int UpdateByQuery(MemberSecurityCB cb, MemberSecurity entity);
        int Delete(MemberSecurity entity);
        int DeleteNonstrict(MemberSecurity entity);
        int DeleteByQuery(MemberSecurityCB cb);// {DBFlute-0.7.9}
    }
}
