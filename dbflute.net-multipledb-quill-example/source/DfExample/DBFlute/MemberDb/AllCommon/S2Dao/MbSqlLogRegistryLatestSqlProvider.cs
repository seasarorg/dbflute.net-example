
using System;
using System.Collections.Generic;

using DfExample.DBFlute.MemberDb.AllCommon.Ado;
using DfExample.DBFlute.MemberDb.AllCommon.S2Dao.Internal.SqlLog;

namespace DfExample.DBFlute.MemberDb.AllCommon.S2Dao {

    public class MbSqlLogRegistryLatestSqlProvider : MbLatestSqlProvider {

        public String GetDisplaySql() {
            return GetLastCompleteSql();
        }

        protected String GetLastCompleteSql() {
            try {
                MbInternalSqlLogRegistry sqlLogRegistry = FindMbInternalSqlLogRegistry();
                if (sqlLogRegistry == null) {
                    return null;
                }
                MbInternalSqlLog sqlLog = sqlLogRegistry.Last;
                if (sqlLog == null) {
                    return null;
                }
                return sqlLog.CompleteSql;
            } catch (Exception) {
                return null;
            }
        }

        public IList<String> ExtractDisplaySqlList() {
            MbInternalSqlLogRegistry sqlLogRegistry = FindMbInternalSqlLogRegistry();
            if (sqlLogRegistry == null) {
                return new List<String>();
            }
	        IList<String> sqlList = new List<String>();
	        foreach (MbInternalSqlLog sqlLog in sqlLogRegistry.SqlLogList) {
	            sqlList.Add(sqlLog.CompleteSql);
	        }
	        return sqlList;
	    }

    	public void ClearSqlCache() {
            MbInternalSqlLogRegistry sqlLogRegistry = FindMbInternalSqlLogRegistry();
            if (sqlLogRegistry == null) {
                return;
            }
            sqlLogRegistry.Clear();
        }

    	protected MbInternalSqlLogRegistry FindMbInternalSqlLogRegistry() {
            return MbInternalSqlLogRegistryLocator.Instance;
        }
    }
}
