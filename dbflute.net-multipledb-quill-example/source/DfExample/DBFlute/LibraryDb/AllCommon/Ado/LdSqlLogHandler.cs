
using System;

namespace DfExample.DBFlute.LibraryDb.AllCommon.Ado {

    public delegate void LdSqlLogHandler(String executedSql, String displaySql, Object[] args, Type[] argTypes);
}
