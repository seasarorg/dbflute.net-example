
using System;

using DfExample.DBFlute.MemberDb.AllCommon.CBean.CValue;
using DfExample.DBFlute.MemberDb.AllCommon.CBean.COption;
using DfExample.DBFlute.MemberDb.AllCommon.JavaLike;

namespace DfExample.DBFlute.MemberDb.AllCommon.CBean.CKey {

public class MbConditionKeyGreaterEqual : MbConditionKey {

    private static readonly log4net.ILog _log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

    public MbConditionKeyGreaterEqual() {
        _conditionKey = "greaterEqual";
        _operand = ">=";
    }

    public override bool isValidRegistration(MbConditionValue conditionValue, Object value, String callerName) {
        if (value == null) {
            return false;
        }
        if (conditionValue.HasGreaterEqual) {
            if (conditionValue.EqualGreaterEqual(value)) {
                _log.Debug("The value has already registered at " + callerName + ": value=" + value);
                return false;
            } else {
                conditionValue.OverrideGreaterEqual(value);
                return false;
            }
        }
        return true;
    }

    protected override void doAddWhereClause(List<String> conditionList, String columnName, MbConditionValue value) {
        if (value.GreaterEqual == null) {
            return;
        }
        Object valueObject = value.GreaterEqual;
        conditionList.add(buildBindClause(columnName, value.getGreaterEqualLocation()));
    }

    protected override void doAddWhereClause(List<String> conditionList, String columnName, MbConditionValue value, MbConditionOption option) {
        throw new UnsupportedOperationException("doAddWhereClause that has ConditionOption is unsupported!!!");
    }

    protected override void doSetupConditionValue(MbConditionValue conditionValue, Object value, String location) {
        conditionValue.GreaterEqual = value;
        conditionValue.setGreaterEqualLocation(location);
    }

    protected override void doSetupConditionValue(MbConditionValue conditionValue, Object value, String location, MbConditionOption option) {
        throw new UnsupportedOperationException("doSetupConditionValue with condition-option is unsupported!!!");
    }
}
	
}
