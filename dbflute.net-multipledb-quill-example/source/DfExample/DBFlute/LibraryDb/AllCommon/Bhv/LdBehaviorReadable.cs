
using System;
using System.Collections.Generic;

using DfExample.DBFlute.LibraryDb.AllCommon;
using DfExample.DBFlute.LibraryDb.AllCommon.CBean;
using DfExample.DBFlute.LibraryDb.AllCommon.Dbm;

namespace DfExample.DBFlute.LibraryDb.AllCommon.Bhv {

    public interface LdBehaviorReadable {

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
        LdDBMeta DBMeta { get; }

        // ===============================================================================
        //                                                                    New Instance
        //                                                                    ============
        LdEntity NewEntity();
        LdConditionBean NewConditionBean();

        // ===============================================================================
        //                                                                    Basic Select
        //                                                                    ============
        /// <summary>
        /// Read count.
        /// </summary>
        /// <param name="cb">Condition-bean. (NotNull)</param>
        /// <returns>Read count.</returns>
        int ReadCount(LdConditionBean cb);

        /// <summary>
        /// Read entity.
        /// </summary>
        /// <param name="cb">Condition-bean. (NotNull)</param>
        /// <returns>Read entity. (NullAllowed)</returns>
        /// <exception cref="DfExample.DBFlute.LibraryDb.AllCommon.Exp.LdEntityDuplicatedException">When the entity has been duplicated.</exception>
        LdEntity ReadEntity(LdConditionBean cb);

        /// <summary>
        /// Read entity with deleted check.
        /// </summary>
        /// <param name="cb">Condition-bean. (NotNull)</param>
        /// <returns>Read entity. (NotNull)</returns>
        /// <exception cref="DfExample.DBFlute.LibraryDb.AllCommon.Exp.LdEntityAlreadyDeletedException">When the entity has been deleted by other thread.</exception>
        /// <exception cref="DfExample.DBFlute.LibraryDb.AllCommon.Exp.LdEntityDuplicatedException">When the entity has been duplicated.</exception>
        LdEntity ReadEntityWithDeletedCheck(LdConditionBean cb);

        // unsupported for generic problem
        //LdListResultBean<LdEntity> ReadList(LdConditionBean cb);

        // unsupported for generic problem
        //LdPagingResultBean<LdEntity> ReadPage(LdConditionBean cb);
    }
}
