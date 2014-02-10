
using System;
using System.Threading;

using DfExample.DBFlute.MemberDb.AllCommon.Ado;

namespace DfExample.DBFlute.MemberDb.AllCommon {

    public class MbCallbackContext {

        private static LocalDataStoreSlot _slot = Thread.AllocateDataSlot();

        public static MbCallbackContext GetCallbackContextOnThread() {
            return (MbCallbackContext)Thread.GetData(_slot);
        }

        public static void SetCallbackContextOnThread(MbCallbackContext context) {
            if (context == null) {
                String msg = "The argument[context] must not be null.";
                throw new ArgumentNullException(msg);
            }
            Thread.SetData(_slot, context);
        }

        public static void ClearCallbackContextOnThread() {
            Thread.SetData(_slot, null);
        }

        public static bool IsExistCallbackContextOnThread() {
            return (Thread.GetData(_slot) != null);
        }

		protected MbSqlLogHandler _sqlLogHandler;
		protected MbSqlResultHandler _sqlResultHandler;

		public MbSqlLogHandler SqlLogHandler {
		    get { return _sqlLogHandler; }
			set { _sqlLogHandler = value; }
		}
		public MbSqlResultHandler SqlResultHandler {
		    get { return _sqlResultHandler; }
			set { _sqlResultHandler = value; }
		}
    }
}
