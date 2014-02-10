
using System;

using DfExample.DBFlute.MemberDb.AllCommon.CBean.CValue;
using DfExample.DBFlute.MemberDb.AllCommon.CBean.COption;
using DfExample.DBFlute.MemberDb.AllCommon.JavaLike;

namespace DfExample.DBFlute.MemberDb.AllCommon.CBean.CKey {

public class MbConditionKeyNotInScope : MbConditionKey {

    private static readonly log4net.ILog _log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

    public MbConditionKeyNotInScope() {
        _conditionKey = "notInScope";
        _operand = "not in";
    }

    public override bool isValidRegistration(MbConditionValue conditionValue, Object value, String callerName) {
        if (value == null) {
            return false;
        }
        if (value is System.Collections.IList && ((System.Collections.IList)value).Count == 0) {
            return false;
        }
        return true;
    }

    protected override void doAddWhereClause(List<String> conditionList, String columnName, MbConditionValue value) {
        if (value.NotInScope == null) {
            return;
        }
        System.Collections.IList valueList = value.NotInScope;
        System.Collections.IList checkedValueList = new System.Collections.Generic.List<Object>();
        foreach (Object checkTargetValue in valueList) {
            if (checkTargetValue == null) {
                continue;
            }
            checkedValueList.Add(checkTargetValue);
        }
        if (checkedValueList.Count == 0) {
            return;
        }
        conditionList.add(buildBindClause(columnName, value.getNotInScopeLocation(), "('a1', 'a2')"));
    }

    protected override void doAddWhereClause(List<String> conditionList, String columnName, MbConditionValue value, MbConditionOption option) {
        throw new UnsupportedOperationException("doAddWhereClause with condition-option is unsupported!!!");
    }

    protected override void doSetupConditionValue(MbConditionValue conditionValue, Object value, String location) {
        conditionValue.NotInScope = ((System.Collections.IList)value);
        conditionValue.setNotInScopeLocation(location);
    }
	
    protected override void doSetupConditionValue(MbConditionValue conditionValue, Object value, String location, MbConditionOption option) {
        throw new UnsupportedOperationException("doSetupConditionValue with condition-option is unsupported!!!");
    }
}
	
}
