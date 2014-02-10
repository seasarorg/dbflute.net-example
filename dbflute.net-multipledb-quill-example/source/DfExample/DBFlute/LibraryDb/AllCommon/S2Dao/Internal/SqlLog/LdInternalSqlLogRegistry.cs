
using System;
using System.Collections.Generic;
using System.Threading;

namespace DfExample.DBFlute.LibraryDb.AllCommon.S2Dao.Internal.SqlLog {

    public class LdInternalSqlLogRegistry {

        // ===============================================================================
        //                                                                      Definition
        //                                                                      ==========
        private static readonly int DEFAULT_LIMIT_SIZE = 3;

        // ===============================================================================
        //                                                                       Attribute
        //                                                                       =========
        [ThreadStatic]
        private LinkedList<LdInternalSqlLog> _sqlLogList = new LinkedList<LdInternalSqlLog>();
        private int limitSize;

        // ===============================================================================
        //                                                                     Constructor
        //                                                                     ===========
        public LdInternalSqlLogRegistry() {
            this.limitSize = DEFAULT_LIMIT_SIZE;
        }

        public LdInternalSqlLogRegistry(int limitSize) {
            this.limitSize = limitSize;
        }

        // ===============================================================================
        //                                                                        Accessor
        //                                                                        ========
        public int LimitSize { get {
            return limitSize;
        }}

        public int Size { get {
            return SqlLogList.Count;
        }}

        public bool IsEmpty { get {
            return Size == 0;
        }}

        public LdInternalSqlLog Last { get {
            return IsEmpty ? null : SqlLogList.Last.Value;
        }}

        public void Add(LdInternalSqlLog sqlLog) {
            if (limitSize <= 0) {
                return;
            }
            LinkedList<LdInternalSqlLog> list = SqlLogList;
            list.AddLast(sqlLog);
            if (list.Count > limitSize) {
                list.RemoveFirst();
            }
        }

        public void Clear() {
            SqlLogList.Clear();
        }

        public LinkedList<LdInternalSqlLog> SqlLogList { get {
            return _sqlLogList;
        }}
    }
}
