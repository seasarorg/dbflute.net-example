
using System;
using Seasar.Dao;

namespace DfExample.DBFlute.LibraryDb.AllCommon.Exp {

    /// <summary>
    /// The exception of when the entity has already been updated by other thread.
    /// Author: DBFlute(AutoGenerator)
    /// </summary>
    public class LdEntityAlreadyUpdatedException : NotSingleRowUpdatedRuntimeException {

        public LdEntityAlreadyUpdatedException(Object bean, int rows)
        : base(bean, rows) {}

        public LdEntityAlreadyUpdatedException(NotSingleRowUpdatedRuntimeException e)
        : base(e.Bean, e.Rows) {}
    }
}
