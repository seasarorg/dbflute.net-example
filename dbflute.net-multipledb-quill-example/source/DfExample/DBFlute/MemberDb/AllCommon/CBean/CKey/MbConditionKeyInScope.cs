
using System;

using DfExample.DBFlute.MemberDb.AllCommon.CBean.CValue;
using DfExample.DBFlute.MemberDb.AllCommon.CBean.COption;
using DfExample.DBFlute.MemberDb.AllCommon.JavaLike;

namespace DfExample.DBFlute.MemberDb.AllCommon.CBean.CKey {

public class MbConditionKeyInScope : MbConditionKey {

    private static readonly log4net.ILog _log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

    public MbConditionKeyInScope() {
        _conditionKey = "inScope";
        _operand = "in";
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
        if (value.InScope == null) {
            return;
        }
        System.Collections.IList valueList = value.InScope;
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
        conditionList.add(buildBindClause(columnName, value.getInScopeLocation(), "('a1', 'a2')"));
    }

    protected override void doAddWhereClause(List<String> conditionList, String columnName, MbConditionValue value, MbConditionOption option) {
        throw new UnsupportedOperationException("doAddWhereClause with condition-option is unsupported!!!");
    }

    protected override void doSetupConditionValue(MbConditionValue conditionValue, Object value, String location) {
        conditionValue.InScope = (System.Collections.IList)value;
        conditionValue.setInScopeLocation(location);
    }

    protected override void doSetupConditionValue(MbConditionValue conditionValue, Object value, String location, MbConditionOption option) {
        throw new UnsupportedOperationException("doSetupConditionValue with condition-option is unsupported!!!");
    }
}

}
