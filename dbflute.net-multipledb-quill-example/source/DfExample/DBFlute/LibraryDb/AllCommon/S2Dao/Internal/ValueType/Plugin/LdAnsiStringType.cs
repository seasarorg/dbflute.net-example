
using System;
using System.Data;

using Seasar.Extension.ADO.Types;

namespace DfExample.DBFlute.LibraryDb.AllCommon.S2Dao.Internal.ValueType.Plugin {

    public class LdAnsiStringType : StringType {

        public override void BindValue(IDbCommand cmd, String columnName, Object value) {
            BindValue(cmd, columnName, value, DbType.AnsiString);
        }
    }
}
