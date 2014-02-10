
using System;
using Seasar.Dao;

namespace DfExample.DBFlute.MemberDb.AllCommon.Exp {

    /// <summary>
    /// The exception of when the entity has already been updated by other thread.
    /// Author: DBFlute(AutoGenerator)
    /// </summary>
    public class MbEntityAlreadyUpdatedException : NotSingleRowUpdatedRuntimeException {

        public MbEntityAlreadyUpdatedException(Object bean, int rows)
        : base(bean, rows) {}

        public MbEntityAlreadyUpdatedException(NotSingleRowUpdatedRuntimeException e)
        : base(e.Bean, e.Rows) {}
    }
}
