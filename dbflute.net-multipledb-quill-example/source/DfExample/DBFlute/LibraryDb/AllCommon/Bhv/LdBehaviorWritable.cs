
using System;
using System.Collections;

using DfExample.DBFlute.LibraryDb.AllCommon;

namespace DfExample.DBFlute.LibraryDb.AllCommon.Bhv {

    public interface LdBehaviorWritable : LdBehaviorReadable {

        /// <summary>
        /// Create entity.
        /// </summary>
        /// <param name="entity">Entity. (NotNull)</param>
        void Create(LdEntity entity);

        /// <summary>
        /// Modify entity.
        /// </summary>
        /// <param name="entity">Entity. (NotNull)</param>
        /// <exception cref="DfExample.DBFlute.LibraryDb.AllCommon.Exp.LdEntityAlreadyUpdatedException">When the entity has already been updated by other thread.</exception>
        /// <exception cref="DfExample.DBFlute.LibraryDb.AllCommon.Exp.LdEntityAlreadyDeletedException">When the entity has already been deleted by other thread.</exception>
        /// <exception cref="DfExample.DBFlute.LibraryDb.AllCommon.Exp.LdEntityDuplicatedException">When the entity has been duplicated.</exception>
        void Modify(LdEntity entity);

        /// <summary>
        /// Remove entity.
        /// </summary>
        /// <param name="entity">Entity. (NotNull)</param>
        /// <exception cref="DfExample.DBFlute.LibraryDb.AllCommon.Exp.LdEntityAlreadyUpdatedException">When the entity has already been updated by other thread.</exception>
        /// <exception cref="DfExample.DBFlute.LibraryDb.AllCommon.Exp.LdEntityAlreadyDeletedException">When the entity has already been deleted by other thread.</exception>
        /// <exception cref="DfExample.DBFlute.LibraryDb.AllCommon.Exp.LdEntityDuplicatedException">When the entity has been duplicated.</exception>
        void Remove(LdEntity entity);
    }
}
