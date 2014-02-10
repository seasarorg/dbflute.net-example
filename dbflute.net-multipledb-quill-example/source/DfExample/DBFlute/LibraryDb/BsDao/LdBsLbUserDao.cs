
using System;
using System.Collections.Generic;

using Seasar.Quill.Attrs;
using Seasar.Dao.Attrs;

using DfExample.DBFlute.LibraryDb.AllCommon;
using DfExample.DBFlute.LibraryDb.AllCommon.S2Dao;
using DfExample.DBFlute.LibraryDb.ExEntity;
using DfExample.DBFlute.LibraryDb.CBean;

namespace DfExample.DBFlute.LibraryDb.ExDao {

    [Implementation]
    [S2Dao(typeof(LdS2DaoSetting))]
    [Bean(typeof(LdLbUser))]
    public partial interface LdLbUserDao : LdDaoWritable {
		void InitializeDaoMetaData(String methodName);// Very Internal Method!

        int SelectCount(LdLbUserCB cb);
        IList<LdLbUser> SelectList(LdLbUserCB cb);

        int Insert(LdLbUser entity);
        int UpdateModifiedOnly(LdLbUser entity);
        int UpdateNonstrictModifiedOnly(LdLbUser entity);
        int UpdateByQuery(LdLbUserCB cb, LdLbUser entity);
        int Delete(LdLbUser entity);
        int DeleteNonstrict(LdLbUser entity);
        int DeleteByQuery(LdLbUserCB cb);// {DBFlute-0.7.9}
    }
}
