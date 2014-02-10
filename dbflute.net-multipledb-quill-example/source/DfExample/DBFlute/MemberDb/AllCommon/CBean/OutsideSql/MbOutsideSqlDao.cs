
using System;
using System.Collections.Generic;

using Seasar.Quill.Attrs;
using Seasar.Dao.Attrs;

using DfExample.DBFlute.MemberDb.AllCommon;
using DfExample.DBFlute.MemberDb.AllCommon.Ado;
using DfExample.DBFlute.MemberDb.AllCommon.S2Dao;

namespace DfExample.DBFlute.MemberDb.AllCommon.CBean.OutsideSql {

    [Implementation]
    [S2Dao(typeof(MbS2DaoSetting))]
    [Bean(typeof(OutsideSqlDaoDummyEntity))]
    public interface MbOutsideSqlDao : MbDaoReadable {

        // ===================================================================================
        //                                                                              Select
        //                                                                              ======
        System.Collections.IList SelectList(String path, Object pmb, MbOutsideSqlOption option, Type entityType);

        Object SelectCursor(String path, Object pmb, MbOutsideSqlOption option, MbCursorHandler handler);

        int Execute(String path, Object pmb, MbOutsideSqlOption option);

		// Not implemented yet!
        // int[] batchExecute(String path, List<Object> pmb, MbOutsideSqlOption option);

        // [DBFlute-0.8.0]
        // ===================================================================================
        //                                                                                Call
        //                                                                                ====
        void Call(String path, Object pmb, MbOutsideSqlOption option);
    }

    public class OutsideSqlDaoDummyEntity {
    }
}
