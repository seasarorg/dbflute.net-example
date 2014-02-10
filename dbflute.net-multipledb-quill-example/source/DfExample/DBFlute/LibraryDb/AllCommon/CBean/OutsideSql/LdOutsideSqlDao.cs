
using System;
using System.Collections.Generic;

using Seasar.Quill.Attrs;
using Seasar.Dao.Attrs;

using DfExample.DBFlute.LibraryDb.AllCommon;
using DfExample.DBFlute.LibraryDb.AllCommon.Ado;
using DfExample.DBFlute.LibraryDb.AllCommon.S2Dao;

namespace DfExample.DBFlute.LibraryDb.AllCommon.CBean.OutsideSql {

    [Implementation]
    [S2Dao(typeof(LdS2DaoSetting))]
    [Bean(typeof(OutsideSqlDaoDummyEntity))]
    public interface LdOutsideSqlDao : LdDaoReadable {

        // ===================================================================================
        //                                                                              Select
        //                                                                              ======
        System.Collections.IList SelectList(String path, Object pmb, LdOutsideSqlOption option, Type entityType);

        Object SelectCursor(String path, Object pmb, LdOutsideSqlOption option, LdCursorHandler handler);

        int Execute(String path, Object pmb, LdOutsideSqlOption option);

		// Not implemented yet!
        // int[] batchExecute(String path, List<Object> pmb, LdOutsideSqlOption option);

        // [DBFlute-0.8.0]
        // ===================================================================================
        //                                                                                Call
        //                                                                                ====
        void Call(String path, Object pmb, LdOutsideSqlOption option);
    }

    public class OutsideSqlDaoDummyEntity {
    }
}
