
using System;

using DfExample.DBFlute.LibraryDb.AllCommon.CBean.CValue;
using DfExample.DBFlute.LibraryDb.AllCommon.CBean.COption;
using DfExample.DBFlute.LibraryDb.AllCommon.JavaLike;

namespace DfExample.DBFlute.LibraryDb.AllCommon.CBean.CKey {

public class LdConditionKeyGreaterThan : LdConditionKey {

    private static readonly log4net.ILog _log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

    public LdConditionKeyGreaterThan() {
        _conditionKey = "greaterThan";
        _operand = ">";
    }

    public override bool isValidRegistration(LdConditionValue conditionValue, Object value, String callerName) {
        if (value == null) {
            return false;
        }
        if (conditionValue.HasGreaterThan) {
            if (conditionValue.EqualGreaterThan(value)) {
                _log.Debug("The value has already registered at " + callerName + ": value=" + value);
                return false;
            } else {
                conditionValue.OverrideGreaterThan(value);
                return false;
            }
        }
        return true;
    }

    protected override void doAddWhereClause(List<String> conditionList, String columnName, LdConditionValue value) {
        if (value.GreaterThan == null) {
            return;
        }
        Object valueObject = value.GreaterThan;
        conditionList.add(buildBindClause(columnName, value.getGreaterThanLocation()));
    }

    protected override void doAddWhereClause(List<String> conditionList, String columnName, LdConditionValue value, LdConditionOption option) {
        throw new UnsupportedOperationException("doAddWhereClause that has ConditionOption is unsupported!!!");
    }

    protected override void doSetupConditionValue(LdConditionValue conditionValue, Object value, String location) {
        conditionValue.GreaterThan = value;
        conditionValue.setGreaterThanLocation(location);
    }

    protected override void doSetupConditionValue(LdConditionValue conditionValue, Object value, String location, LdConditionOption option) {
        throw new UnsupportedOperationException("doSetupConditionValue with condition-option is unsupported!!!");
    }
}

}
