
using System;

namespace DfExample.DBFlute.MemberDb.AllCommon.CBean.SClause {

[System.Serializable]
public class MbSqlClauseDerby : MbAbstractSqlClause {

    protected String _lockSqlSuffix = "";

    public MbSqlClauseDerby(String tableName)
        : base(tableName) {}

	protected override OrderByNullsSetupper createOrderByNullsSetupper() {
	    return new OrderByNullsSetupperByCaseWhen();
	}
	
    protected override void doFetchFirst() {
    }

    protected override void doFetchPage() {
    }

    protected override void doClearFetchPageClause() {
    }

    public override bool isFetchStartIndexSupported() {
        return false; // Default
    }

    public override bool isFetchSizeSupported() {
        return false; // Default
    }

    public override MbSqlClause lockForUpdate() {
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
        return _lockSqlSuffix;
    }
}

}
