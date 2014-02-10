
using System;
using System.Data.Common;

namespace DfExample.DBFlute.MemberDb.AllCommon.Exp {

    /// <summary>
    /// The exception of when the SQL failed to execute.
    /// Author: DBFlute(AutoGenerator)
    /// </summary>
    public class MbSQLFailureException : SystemException {

        protected DbException _causeDbException;

        public MbSQLFailureException(String msg, Exception e)
        : base(msg,e) {
            SetupCauseDbException(e);
        }

        protected void SetupCauseDbException(Exception e) {
            if (e is DbException) {
                _causeDbException = (DbException)e;
                return;
            }
            if (e == null) { return; }
            e = e.InnerException;
            if (e is DbException) {
                _causeDbException = (DbException)e;
                return;
            }
            if (e == null) { return; }
            e = e.InnerException;
            if (e is DbException) {
                _causeDbException = (DbException)e;
                return;
            }
            if (e == null) { return; }
            e = e.InnerException;
            if (e is DbException) {
                _causeDbException = (DbException)e;
                return;
            }
            if (e == null) { return; }
            e = e.InnerException;
            if (e is DbException) {
                _causeDbException = (DbException)e;
                return;
            }
            // It doesn't use recursive call by design because ADO.NET is unpredictable fellow.
        }

        public DbException CauseDbException { get { return _causeDbException; } }
    }
}
