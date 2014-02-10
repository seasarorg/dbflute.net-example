
using System;

using DfExample.DBFlute.LibraryDb.AllCommon.CBean.CValue;
using DfExample.DBFlute.LibraryDb.AllCommon.CBean.COption;
using DfExample.DBFlute.LibraryDb.AllCommon.JavaLike;

namespace DfExample.DBFlute.LibraryDb.AllCommon.CBean.CKey {

public class LdConditionKeyLikeSearch : LdConditionKey {

    public LdConditionKeyLikeSearch() {
        _conditionKey = "likeSearch";
        _operand = "like";
    }

    public override bool isValidRegistration(LdConditionValue conditionValue, Object value, String callerName) {
        if (value == null) {
            return false;
        }
        return true;
    }

    protected override void doAddWhereClause(List<String> conditionList, String columnName, LdConditionValue value) {
        throw new UnsupportedOperationException("doAddWhereClause without condition-option is unsupported!!!");
    }

    protected override void doAddWhereClause(List<String> conditionList, String columnName, LdConditionValue value, LdConditionOption option) {
        if (option == null) {
            String msg = "The argument[option] should not be null: columnName=" + columnName + " value=" + value;
            throw new IllegalArgumentException(msg);
        }
        if (!(option is LdLikeSearchOption)) {
            String msg = "The argument[option] should be LdLikeSearchOption: columnName=" + columnName + " value=" + value;
            throw new IllegalArgumentException(msg);
        }
        LdLikeSearchOption myOption = (LdLikeSearchOption)option;
        conditionList.add(buildBindClauseWithRearOption(columnName, value.getLikeSearchLocation(), myOption.getRearOption()));
    }

    protected override void doSetupConditionValue(LdConditionValue conditionValue, Object value, String location) {
        throw new UnsupportedOperationException("doSetupConditionValue without condition-option is unsupported!!!");
    }

    protected override void doSetupConditionValue(LdConditionValue conditionValue, Object value, String location, LdConditionOption option) {
        conditionValue.setLikeSearch((String)value, (LdLikeSearchOption)option).setLikeSearchLocation(location);
    }
}
	
}
