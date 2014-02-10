
using System;
using System.Collections.Generic;

using DfExample.DBFlute.LibraryDb.AllCommon.Ado;
using DfExample.DBFlute.LibraryDb.AllCommon.S2Dao.Internal.SqlLog;

namespace DfExample.DBFlute.LibraryDb.AllCommon.S2Dao {

    public class LdSqlLogRegistryLatestSqlProvider : LdLatestSqlProvider {

        public String GetDisplaySql() {
            return GetLastCompleteSql();
        }

        protected String GetLastCompleteSql() {
            try {
                LdInternalSqlLogRegistry sqlLogRegistry = FindLdInternalSqlLogRegistry();
                if (sqlLogRegistry == null) {
                    return null;
                }
                LdInternalSqlLog sqlLog = sqlLogRegistry.Last;
                if (sqlLog == null) {
                    return null;
                }
                return sqlLog.CompleteSql;
            } catch (Exception) {
                return null;
            }
        }

        public IList<String> ExtractDisplaySqlList() {
            LdInternalSqlLogRegistry sqlLogRegistry = FindLdInternalSqlLogRegistry();
            if (sqlLogRegistry == null) {
                return new List<String>();
            }
	        IList<String> sqlList = new List<String>();
	        foreach (LdInternalSqlLog sqlLog in sqlLogRegistry.SqlLogList) {
	            sqlList.Add(sqlLog.CompleteSql);
	        }
	        return sqlList;
	    }

    	public void ClearSqlCache() {
            LdInternalSqlLogRegistry sqlLogRegistry = FindLdInternalSqlLogRegistry();
            if (sqlLogRegistry == null) {
                return;
            }
            sqlLogRegistry.Clear();
        }

    	protected LdInternalSqlLogRegistry FindLdInternalSqlLogRegistry() {
            return LdInternalSqlLogRegistryLocator.Instance;
        }
    }
}
