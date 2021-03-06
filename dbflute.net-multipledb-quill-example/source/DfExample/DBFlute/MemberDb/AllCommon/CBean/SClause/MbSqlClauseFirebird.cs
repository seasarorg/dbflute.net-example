
using System;

namespace DfExample.DBFlute.MemberDb.AllCommon.CBean.SClause {

[System.Serializable]
public class MbSqlClauseFirebird : MbAbstractSqlClause {

    protected String _fetchScopeSelectHint = "";
    protected String _lockSqlSuffix = "";

    public MbSqlClauseFirebird(String tableName)
        : base(tableName) {}

    protected override void doFetchFirst() {
        if (this.isFetchSizeSupported()) {
            _fetchScopeSelectHint = " first " + this.getFetchSize();
        }
    }

    protected override void doFetchPage() {
        if (this.isFetchStartIndexSupported() && this.isFetchSizeSupported()) {
            _fetchScopeSelectHint = " first " + this.getFetchSize() + " skip " + this.getPageStartIndex();
        }
        if (this.isFetchStartIndexSupported() && !this.isFetchSizeSupported()) {
            _fetchScopeSelectHint = " skip " + this.getPageStartIndex();
        }
        if (!this.isFetchStartIndexSupported() && this.isFetchSizeSupported()) {
            _fetchScopeSelectHint = " first " + this.getPageEndIndex();
        }
    }

    protected override void doClearFetchPageClause() {
        _fetchScopeSelectHint = "";
    }

    public override MbSqlClause lockForUpdate() {
        _lockSqlSuffix = " for update with lock";
        return this;
    }

    protected override String createSelectHint() {
        return _fetchScopeSelectHint;
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
