
using System;
using System.Collections.Generic;

using DfExample.DBFlute.MemberDb.AllCommon;
using DfExample.DBFlute.MemberDb.AllCommon.CBean;
using DfExample.DBFlute.MemberDb.AllCommon.Dbm;

namespace DfExample.DBFlute.MemberDb.AllCommon.Bhv {

    public interface MbBehaviorReadable {

        // ===============================================================================
        //                                                                Initialized Mark
        //                                                                ================
        bool IsInitialized { get; }

        // ===============================================================================
        //                                                                      Table Name
        //                                                                      ==========
        String TableDbName { get; }

        // ===============================================================================
        //                                                                          DBMeta
        //                                                                          ======
        MbDBMeta DBMeta { get; }

        // ===============================================================================
        //                                                                    New Instance
        //                                                                    ============
        MbEntity NewEntity();
        MbConditionBean NewConditionBean();

        // ===============================================================================
        //                                                                    Basic Select
        //                                                                    ============
        /// <summary>
        /// Read count.
        /// </summary>
        /// <param name="cb">Condition-bean. (NotNull)</param>
        /// <returns>Read count.</returns>
        int ReadCount(MbConditionBean cb);

        /// <summary>
        /// Read entity.
        /// </summary>
        /// <param name="cb">Condition-bean. (NotNull)</param>
        /// <returns>Read entity. (NullAllowed)</returns>
        /// <exception cref="DfExample.DBFlute.MemberDb.AllCommon.Exp.MbEntityDuplicatedException">When the entity has been duplicated.</exception>
        MbEntity ReadEntity(MbConditionBean cb);

        /// <summary>
        /// Read entity with deleted check.
        /// </summary>
        /// <param name="cb">Condition-bean. (NotNull)</param>
        /// <returns>Read entity. (NotNull)</returns>
        /// <exception cref="DfExample.DBFlute.MemberDb.AllCommon.Exp.MbEntityAlreadyDeletedException">When the entity has been deleted by other thread.</exception>
        /// <exception cref="DfExample.DBFlute.MemberDb.AllCommon.Exp.MbEntityDuplicatedException">When the entity has been duplicated.</exception>
        MbEntity ReadEntityWithDeletedCheck(MbConditionBean cb);

        // unsupported for generic problem
        //MbListResultBean<MbEntity> ReadList(MbConditionBean cb);

        // unsupported for generic problem
        //MbPagingResultBean<MbEntity> ReadPage(MbConditionBean cb);
    }
}
