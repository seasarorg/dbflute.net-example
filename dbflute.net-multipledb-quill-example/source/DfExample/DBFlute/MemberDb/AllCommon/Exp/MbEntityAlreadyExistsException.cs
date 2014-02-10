
using System;

namespace DfExample.DBFlute.MemberDb.AllCommon.Exp {

    /// <summary>
    /// The exception of when the entity already exists on the database.
    /// Author: DBFlute(AutoGenerator)
    /// </summary>
    public class MbEntityAlreadyExistsException : MbSQLFailureException {

        public MbEntityAlreadyExistsException(String msg, Exception e)
        : base(msg,e) {}
    }
}
