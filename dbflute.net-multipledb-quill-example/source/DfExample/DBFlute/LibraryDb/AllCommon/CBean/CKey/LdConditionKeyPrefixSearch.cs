
using System;

using DfExample.DBFlute.LibraryDb.AllCommon.CBean.CValue;
using DfExample.DBFlute.LibraryDb.AllCommon.CBean.COption;
using DfExample.DBFlute.LibraryDb.AllCommon.JavaLike;

namespace DfExample.DBFlute.LibraryDb.AllCommon.CBean.CKey {

public class LdConditionKeyPrefixSearch : LdConditionKey {

    private static readonly log4net.ILog _log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

    public LdConditionKeyPrefixSearch() {
        _conditionKey = "prefixSearch";
        _operand = "like";
    }

    public override bool isValidRegistration(LdConditionValue conditionValue, Object value, String callerName) {
        if (value == null) {
            return false;
        }
        if (conditionValue.HasPrefixSearch) {
            if (conditionValue.EqualPrefixSearch(value + getWildCard())) {
                _log.Debug("The value has already registered at " + callerName + ": value=" + value);
                return false;
            } else {
                conditionValue.OverridePrefixSearch(value);
                return false;
            }
        }
        return true;
    }

    protected override void doAddWhereClause(List<String> conditionList, String columnName, LdConditionValue value) {
        if (value.PrefixSearch == null) {
            return;
        }
        Object valueObject = value.PrefixSearch;
        conditionList.add(buildBindClause(columnName, value.getPrefixSearchLocation()));
    }

    protected override void doAddWhereClause(List<String> conditionList, String columnName, LdConditionValue value, LdConditionOption option) {
        throw new UnsupportedOperationException("doAddWhereClause with condition-option is unsupported!!!");
    }

    protected override void doSetupConditionValue(LdConditionValue conditionValue, Object value, String location) {
        conditionValue.PrefixSearch = (value != null ? value + getWildCard() : null);
        conditionValue.setPrefixSearchLocation(location);
    }
	
    protected override void doSetupConditionValue(LdConditionValue conditionValue, Object value, String location, LdConditionOption option) {
        throw new UnsupportedOperationException("doSetupConditionValue with condition-option is unsupported!!!");
    }
}
	
}
