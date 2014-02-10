
using System;

namespace DfExample.DBFlute.MemberDb.AllCommon.CBean.SClause {

[System.Serializable]
public class MbSqlClauseDb2 : MbAbstractSqlClause {

    protected String _fetchFirstSqlSuffix = "";
    protected String _lockSqlSuffix = "";

    public MbSqlClauseDb2(String tableName)
        : base(tableName) {}

	protected override OrderByNullsSetupper createOrderByNullsSetupper() {
	    return new OrderByNullsSetupperByCaseWhen();
	}
	
    protected override void doFetchFirst() {
        if (isFetchSizeSupported()) {
            _fetchFirstSqlSuffix = " fetch first " + getFetchSize() + " rows only";
        }
    }

    protected override void doFetchPage() {
        if (isFetchSizeSupported()) {
            if (isFetchStartIndexSupported()) {
                _fetchFirstSqlSuffix = " fetch first " + this.getFetchSize() + " rows only";
            } else {
                _fetchFirstSqlSuffix = " fetch first " + this.getPageEndIndex() + " rows only";
            }
        }
    }

    protected override void doClearFetchPageClause() {
        _fetchFirstSqlSuffix = "";
    }

    public override bool isFetchStartIndexSupported() {
        return false; // Default
    }

    public override MbSqlClause lockForUpdate() {
        _lockSqlSuffix = " for update with RS";
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
        return _fetchFirstSqlSuffix + _lockSqlSuffix;;
    }
}

}
