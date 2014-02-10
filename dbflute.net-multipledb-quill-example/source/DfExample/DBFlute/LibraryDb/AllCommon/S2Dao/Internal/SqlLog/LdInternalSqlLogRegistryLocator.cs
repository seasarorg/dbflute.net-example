
using System;

namespace DfExample.DBFlute.LibraryDb.AllCommon.S2Dao.Internal.SqlLog {

    public class LdInternalSqlLogRegistryLocator {
        protected static LdInternalSqlLogRegistry instance;
        public static LdInternalSqlLogRegistry Instance { get {
            return instance;
        } set {
            instance = value;
        }}
    }
}
