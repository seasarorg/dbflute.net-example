
using System;

using DfExample.DBFlute.MemberDb.AllCommon.CBean.CValue;
using DfExample.DBFlute.MemberDb.AllCommon.CBean.COption;
using DfExample.DBFlute.MemberDb.AllCommon.JavaLike;

namespace DfExample.DBFlute.MemberDb.AllCommon.CBean.CKey {

public class MbConditionKeyEqual : MbConditionKey {

    private static readonly log4net.ILog _log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

    public MbConditionKeyEqual() {
        _conditionKey = "equal";
        _operand = "=";
    }

    public override bool isValidRegistration(MbConditionValue conditionValue, Object value, String callerName) {
        if (value == null) {
            return false;
        }
        if (conditionValue.HasEqual) {
            if (conditionValue.EqualEqual(value)) {
                _log.Debug("The value has already registered at " + callerName + ": value=" + value);
                return false;
            } else {
                conditionValue.OverrideEqual(value);
                return false;
            }
        }
        return true;
    }

    protected override void doAddWhereClause(List<String> conditionList, String columnName, MbConditionValue value) {
        if (value.Equal == null) {
            return;
        }
        Object valueObject = value.Equal;
        conditionList.add(buildBindClause(columnName, value.getEqualLocation()));
    }
	
    protected override void doAddWhereClause(List<String> conditionList, String columnName, MbConditionValue value, MbConditionOption option) {
        throw new UnsupportedOperationException("doAddWhereClause with condition-option is unsupported!!!");
    }

    protected override void doSetupConditionValue(MbConditionValue conditionValue, Object value, String location) {
        conditionValue.Equal = value;
        conditionValue.setEqualLocation(location);
    }
	
    protected override void doSetupConditionValue(MbConditionValue conditionValue, Object value, String location, MbConditionOption option) {
        throw new UnsupportedOperationException("doSetupConditionValue with condition-option is unsupported!!!");
    }
}
	
}
