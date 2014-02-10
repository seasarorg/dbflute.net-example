
using System;
using System.Collections.Generic;
using System.Threading;

namespace DfExample.DBFlute.MemberDb.AllCommon.S2Dao.Internal.SqlLog {

    public class MbInternalSqlLogRegistry {

        // ===============================================================================
        //                                                                      Definition
        //                                                                      ==========
        private static readonly int DEFAULT_LIMIT_SIZE = 3;

        // ===============================================================================
        //                                                                       Attribute
        //                                                                       =========
        [ThreadStatic]
        private LinkedList<MbInternalSqlLog> _sqlLogList = new LinkedList<MbInternalSqlLog>();
        private int limitSize;

        // ===============================================================================
        //                                                                     Constructor
        //                                                                     ===========
        public MbInternalSqlLogRegistry() {
            this.limitSize = DEFAULT_LIMIT_SIZE;
        }

        public MbInternalSqlLogRegistry(int limitSize) {
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

        public MbInternalSqlLog Last { get {
            return IsEmpty ? null : SqlLogList.Last.Value;
        }}

        public void Add(MbInternalSqlLog sqlLog) {
            if (limitSize <= 0) {
                return;
            }
            LinkedList<MbInternalSqlLog> list = SqlLogList;
            list.AddLast(sqlLog);
            if (list.Count > limitSize) {
                list.RemoveFirst();
            }
        }

        public void Clear() {
            SqlLogList.Clear();
        }

        public LinkedList<MbInternalSqlLog> SqlLogList { get {
            return _sqlLogList;
        }}
    }
}
