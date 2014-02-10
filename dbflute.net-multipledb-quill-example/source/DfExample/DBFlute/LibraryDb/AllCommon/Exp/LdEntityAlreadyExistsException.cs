
using System;

namespace DfExample.DBFlute.LibraryDb.AllCommon.Exp {

    /// <summary>
    /// The exception of when the entity already exists on the database.
    /// Author: DBFlute(AutoGenerator)
    /// </summary>
    public class LdEntityAlreadyExistsException : LdSQLFailureException {

        public LdEntityAlreadyExistsException(String msg, Exception e)
        : base(msg,e) {}
    }
}
