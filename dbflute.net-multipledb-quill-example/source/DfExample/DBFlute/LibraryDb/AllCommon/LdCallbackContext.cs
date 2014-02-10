
using System;
using System.Threading;

using DfExample.DBFlute.LibraryDb.AllCommon.Ado;

namespace DfExample.DBFlute.LibraryDb.AllCommon {

    public class LdCallbackContext {

        private static LocalDataStoreSlot _slot = Thread.AllocateDataSlot();

        public static LdCallbackContext GetCallbackContextOnThread() {
            return (LdCallbackContext)Thread.GetData(_slot);
        }

        public static void SetCallbackContextOnThread(LdCallbackContext context) {
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

		protected LdSqlLogHandler _sqlLogHandler;
		protected LdSqlResultHandler _sqlResultHandler;

		public LdSqlLogHandler SqlLogHandler {
		    get { return _sqlLogHandler; }
			set { _sqlLogHandler = value; }
		}
		public LdSqlResultHandler SqlResultHandler {
		    get { return _sqlResultHandler; }
			set { _sqlResultHandler = value; }
		}
    }
}
