
using System;

namespace DfExample.DBFlute.LibraryDb.AllCommon.S2Dao.Internal.SqlLog {

    public class LdInternalSqlLog {

        // ===============================================================================
        //                                                                       Attribute
        //                                                                       =========
        private String rawSql;
        private String completeSql;
        private Object[] bindArgs;
        private Type[] bindArgTypes;

        // ===============================================================================
        //                                                                        Accessor
        //                                                                        ========
        public String RawSql { get {
            return rawSql;
        } set {
            rawSql = value;
        }}

        public String CompleteSql { get {
            return completeSql;
        } set {
            completeSql = value;
        }}

        public Object[] BindArgs { get {
            return bindArgs;
        } set {
            bindArgs = value;
        }}

        public Type[] BindArgTypes { get {
            return bindArgTypes;
        } set {
            bindArgTypes = value;
        }}
    }
}
