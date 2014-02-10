
using System;
using DfExample.DBFlute.LibraryDb.AllCommon.JavaLike;

namespace DfExample.DBFlute.LibraryDb.AllCommon.CBean.SClause {

[System.Serializable]
public class LdSqlClauseSqlServer : LdAbstractSqlClause {

    protected String _fetchFirstSelectHint = "";
    protected String _lockFromHint = "";

    public LdSqlClauseSqlServer(String tableName)
        : base(tableName) {}

    protected override bool isUnionNormalSelectEnclosingRequired() {
        return true;
    }

    protected override void appendSelectHint(StringBuilder sb) {
        if (needsUnionNormalSelectEnclosing()) {
            return; // because clause should be enclosed when union normal select
        }
        base.appendSelectHint(sb);
    }

	protected override OrderByNullsSetupper createOrderByNullsSetupper() {
	    return new OrderByNullsSetupperByCaseWhen();
	}
	
    protected override void doFetchFirst() {
        if (this.isFetchSizeSupported()) {
            _fetchFirstSelectHint = " top " + this.getFetchSize();
        }
    }

    protected override void doFetchPage() {
        if (this.isFetchSizeSupported()) {
            if (this.isFetchStartIndexSupported()) {
                _fetchFirstSelectHint = " top " + this.getFetchSize();
            } else {
                _fetchFirstSelectHint = " top " + this.getPageEndIndex();
            }
        }
    }

    protected override void doClearFetchPageClause() {
        _fetchFirstSelectHint = "";
    }

    public override bool isFetchStartIndexSupported() {
        return false; // Default
    }

    public override LdSqlClause lockForUpdate() {
        _lockFromHint = " with (updlock)";
        return this;
    }

    protected override String createSelectHint() {
        return _fetchFirstSelectHint;
    }

    protected override String createFromBaseTableHint() {
        return _lockFromHint;
    }

    protected override String createFromHint() {
        return "";
    }

    protected override String createSqlSuffix() {
        return "";
    }
}

}
