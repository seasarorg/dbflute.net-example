
using System;

using DfExample.DBFlute.LibraryDb.AllCommon.CBean.CValue;
using DfExample.DBFlute.LibraryDb.AllCommon.CBean.COption;
using DfExample.DBFlute.LibraryDb.AllCommon.JavaLike;

namespace DfExample.DBFlute.LibraryDb.AllCommon.CBean.CKey {

public class LdConditionKeyIsNotNull : LdConditionKey {

    private static readonly log4net.ILog _log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

    public LdConditionKeyIsNotNull() {
        _conditionKey = "isNotNull";
        _operand = "is not null";
    }

    public override bool isValidRegistration(LdConditionValue conditionValue, Object value, String callerName) {
        if (conditionValue.HasIsNotNull) {
            _log.Debug("The value has already registered at " + _conditionKey + ": " + value);
            return false;
        }
        return true;
    }

    protected override void doAddWhereClause(List<String> conditionList, String columnName, LdConditionValue value) {
        if (value.IsNotNull == null) {
            return;
        }
        conditionList.add(buildClauseWithoutValue(columnName));
    }

    protected override void doAddWhereClause(List<String> conditionList, String columnName, LdConditionValue value, LdConditionOption option) {
        throw new UnsupportedOperationException("doAddWhereClause that has ConditionOption is unsupported!!!");
    }

    protected override void doSetupConditionValue(LdConditionValue conditionValue, Object value, String location) {
        conditionValue.IsNotNull = DUMMY_OBJECT;
        conditionValue.setIsNotNullLocation(location);
    }

    protected override void doSetupConditionValue(LdConditionValue conditionValue, Object value, String location, LdConditionOption option) {
        throw new UnsupportedOperationException("doSetupConditionValue with condition-option is unsupported!!!");
    }
}

}
