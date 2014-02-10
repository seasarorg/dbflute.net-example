
using System;

namespace DfExample.DBFlute.MemberDb.AllCommon.Ado {

    public delegate void MbSqlLogHandler(String executedSql, String displaySql, Object[] args, Type[] argTypes);
}
