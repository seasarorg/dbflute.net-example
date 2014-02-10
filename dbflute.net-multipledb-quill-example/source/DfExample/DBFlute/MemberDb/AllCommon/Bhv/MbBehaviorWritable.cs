
using System;
using System.Collections;

using DfExample.DBFlute.MemberDb.AllCommon;

namespace DfExample.DBFlute.MemberDb.AllCommon.Bhv {

    public interface MbBehaviorWritable : MbBehaviorReadable {

        /// <summary>
        /// Create entity.
        /// </summary>
        /// <param name="entity">Entity. (NotNull)</param>
        void Create(MbEntity entity);

        /// <summary>
        /// Modify entity.
        /// </summary>
        /// <param name="entity">Entity. (NotNull)</param>
        /// <exception cref="DfExample.DBFlute.MemberDb.AllCommon.Exp.MbEntityAlreadyUpdatedException">When the entity has already been updated by other thread.</exception>
        /// <exception cref="DfExample.DBFlute.MemberDb.AllCommon.Exp.MbEntityAlreadyDeletedException">When the entity has already been deleted by other thread.</exception>
        /// <exception cref="DfExample.DBFlute.MemberDb.AllCommon.Exp.MbEntityDuplicatedException">When the entity has been duplicated.</exception>
        void Modify(MbEntity entity);

        /// <summary>
        /// Remove entity.
        /// </summary>
        /// <param name="entity">Entity. (NotNull)</param>
        /// <exception cref="DfExample.DBFlute.MemberDb.AllCommon.Exp.MbEntityAlreadyUpdatedException">When the entity has already been updated by other thread.</exception>
        /// <exception cref="DfExample.DBFlute.MemberDb.AllCommon.Exp.MbEntityAlreadyDeletedException">When the entity has already been deleted by other thread.</exception>
        /// <exception cref="DfExample.DBFlute.MemberDb.AllCommon.Exp.MbEntityDuplicatedException">When the entity has been duplicated.</exception>
        void Remove(MbEntity entity);
    }
}
