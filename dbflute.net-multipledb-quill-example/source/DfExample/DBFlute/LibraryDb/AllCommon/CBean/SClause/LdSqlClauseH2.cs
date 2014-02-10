
using System;

namespace DfExample.DBFlute.LibraryDb.AllCommon.CBean.SClause {

[System.Serializable]
public class LdSqlClauseH2 : LdAbstractSqlClause {

    protected String _fetchScopeSqlSuffix = "";
    protected String _lockSqlSuffix = "";

    public LdSqlClauseH2(String tableName)
        : base(tableName) {}

	protected override OrderByNullsSetupper createOrderByNullsSetupper() {
	    return new OrderByNullsSetupperByCaseWhen();
	}
	
    protected override void doFetchFirst() {
        doFetchPage();
    }

    protected override void doFetchPage() {
        _fetchScopeSqlSuffix = " limit " + this.getFetchSize() + " offset " + this.getPageStartIndex();;
    }

    protected override void doClearFetchPageClause() {
        _fetchScopeSqlSuffix = "";
    }

    public override LdSqlClause lockForUpdate() {
        _lockSqlSuffix = " for update";
        return this;
    }

    protected override String createSelectHint() {
        return "";
    }

    protected override String createFromBaseTableHint() {
        return "";
    }

    protected override String createFromHint() {
        return "";
    }

    protected override String createSqlSuffix() {
        return _fetchScopeSqlSuffix + _lockSqlSuffix;
    }
}
	
}
