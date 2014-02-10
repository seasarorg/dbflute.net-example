
using System;

namespace DfExample.DBFlute.MemberDb.AllCommon.S2Dao.Internal.SqlLog {

    public class MbInternalSqlLogRegistryLocator {
        protected static MbInternalSqlLogRegistry instance;
        public static MbInternalSqlLogRegistry Instance { get {
            return instance;
        } set {
            instance = value;
        }}
    }
}
