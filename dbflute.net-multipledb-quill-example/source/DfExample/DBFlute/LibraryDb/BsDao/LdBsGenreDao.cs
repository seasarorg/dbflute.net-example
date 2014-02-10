
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
    [Bean(typeof(LdGenre))]
    public partial interface LdGenreDao : LdDaoWritable {
		void InitializeDaoMetaData(String methodName);// Very Internal Method!

        int SelectCount(LdGenreCB cb);
        IList<LdGenre> SelectList(LdGenreCB cb);

        int Insert(LdGenre entity);
        int UpdateModifiedOnly(LdGenre entity);
        int UpdateNonstrictModifiedOnly(LdGenre entity);
        int UpdateByQuery(LdGenreCB cb, LdGenre entity);
        int Delete(LdGenre entity);
        int DeleteNonstrict(LdGenre entity);
        int DeleteByQuery(LdGenreCB cb);// {DBFlute-0.7.9}
    }
}
