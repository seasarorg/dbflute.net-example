
using System;

using DfExample.DBFlute.MemberDb.AllCommon.CBean.CValue;
using DfExample.DBFlute.MemberDb.AllCommon.CBean.COption;
using DfExample.DBFlute.MemberDb.AllCommon.JavaLike;

namespace DfExample.DBFlute.MemberDb.AllCommon.CBean.CKey {

public class MbConditionKeyIsNull : MbConditionKey {

    private static readonly log4net.ILog _log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
	
    public MbConditionKeyIsNull() {
        _conditionKey = "isNull";
        _operand = "is null";
    }

    public override bool isValidRegistration(MbConditionValue conditionValue, Object value, String callerName) {
        if (conditionValue.HasIsNull) {
            _log.Debug("The value has already registered at " + _conditionKey + ": " + value);
            return false;
        }
        return true;
    }

    protected override void doAddWhereClause(List<String> conditionList, String columnName, MbConditionValue value) {
        if (value.IsNull == null) {
            return;
        }
        conditionList.add(buildClauseWithoutValue(columnName));
    }

    protected override void doAddWhereClause(List<String> conditionList, String columnName, MbConditionValue value, MbConditionOption option) {
        throw new UnsupportedOperationException("doAddWhereClause that has ConditionOption is unsupported!!!");
    }

    protected override void doSetupConditionValue(MbConditionValue conditionValue, Object value, String location) {
        conditionValue.IsNull = DUMMY_OBJECT;
        conditionValue.setIsNullLocation(location);
    }

    protected override void doSetupConditionValue(MbConditionValue conditionValue, Object value, String location, MbConditionOption option) {
        throw new UnsupportedOperationException("doSetupConditionValue with condition-option is unsupported!!!");
    }
}
	
}
