
using System;

namespace DfExample.DBFlute.AllCommon.Ado {

    public delegate void SqlLogHandler(String executedSql, String displaySql, Object[] args, Type[] argTypes);
}
