
using System;

using DfExample.DBFlute.MemberDb.AllCommon.CBean.COption;
using DfExample.DBFlute.MemberDb.AllCommon.CBean.CValue;
using DfExample.DBFlute.MemberDb.AllCommon.JavaLike;

namespace DfExample.DBFlute.MemberDb.AllCommon.CBean.CKey {

public abstract class MbConditionKey {

    // ===================================================================================
    //                                                                          Definition
    //                                                                          ==========
    /** The condition key of equal. */
    public static readonly MbConditionKey CK_EQUAL = new MbConditionKeyEqual();

    /** The condition key of notEqual as standard. */
    public static readonly MbConditionKey CK_NOT_EQUAL_STANDARD = new MbConditionKeyNotEqualStandard();

    /** The condition key of notEqual as tradition. */
    public static readonly MbConditionKey CK_NOT_EQUAL_TRADITION = new MbConditionKeyNotEqualTradition();

    /** The condition key of greaterThan. */
    public static readonly MbConditionKey CK_GREATER_THAN = new MbConditionKeyGreaterThan();

    /** The condition key of lessrThan. */
    public static readonly MbConditionKey CK_LESS_THAN = new MbConditionKeyLessThan();

    /** The condition key of greaterEqual. */
    public static readonly MbConditionKey CK_GREATER_EQUAL = new MbConditionKeyGreaterEqual();

    /** The condition key of lessEqual. */
    public static readonly MbConditionKey CK_LESS_EQUAL = new MbConditionKeyLessEqual();

    /** The condition key of prefixSearch. */
    public static readonly MbConditionKey CK_PREFIX_SEARCH = new MbConditionKeyPrefixSearch();

    /** The condition key of inScope. */
    public static readonly MbConditionKey CK_IN_SCOPE = new MbConditionKeyInScope();

    /** The condition key of notInScope. */
    public static readonly MbConditionKey CK_NOT_IN_SCOPE = new MbConditionKeyNotInScope();

    /** The condition key of likeSearch. */
    public static readonly MbConditionKey CK_LIKE_SEARCH = new MbConditionKeyLikeSearch();

    /** The condition key of notLikeSearch. */
    public static readonly MbConditionKey CK_NOT_LIKE_SEARCH = new MbConditionKeyNotLikeSearch();

    /** The condition key of isNull. */
    public static readonly MbConditionKey CK_IS_NULL = new MbConditionKeyIsNull();

    /** The condition key of isNotNull. */
    public static readonly MbConditionKey CK_IS_NOT_NULL = new MbConditionKeyIsNotNull();

    /** Dummy-object for IsNull and IsNotNull and so on... */
    protected static readonly Object DUMMY_OBJECT = new Object();

    // ===================================================================================
    //                                                                           Attribute
    //                                                                           =========
    /** Condition-key. */
    protected String _conditionKey;

    /** Operand. */
    protected String _operand;

    // ===================================================================================
    //                                                                         Main Method
    //                                                                         ===========
    public String getConditionKey() {
        // Because initial charactor of property name is capital in dotNet world.
        return (_conditionKey != null ? _conditionKey.Substring(0, 1).ToUpper() + _conditionKey.Substring(1) : null);
    }

    public String getOperand() {
        return _operand;
    }

    abstract public bool isValidRegistration(MbConditionValue conditionValue, Object value, String callerName);

    public MbConditionKey addWhereClause(List<String> conditionList, String columnName, MbConditionValue value) {
        if (value == null) {
            String msg = "Argument[value] must not be null:";
            throw new IllegalArgumentException(msg + " value=" + value + " this.ToString()=" + ToString());
        }
        doAddWhereClause(conditionList, columnName, value);
        return this;
    }

    public MbConditionKey addWhereClause(List<String> conditionList, String columnName, MbConditionValue value, MbConditionOption option) {
        if (value == null) {
            String msg = "Argument[value] must not be null:";
            throw new IllegalArgumentException(msg + " value=" + value + " this.ToString()=" + ToString());
        }
        doAddWhereClause(conditionList, columnName, value, option);
        return this;
    }
	
    abstract protected void doAddWhereClause(List<String> conditionList, String columnName, MbConditionValue value);
    abstract protected void doAddWhereClause(List<String> conditionList, String columnName, MbConditionValue value, MbConditionOption option);

    public MbConditionValue setupConditionValue(MbConditionValue conditionValue, Object value, String location) {
        if (conditionValue == null) {
            String msg = "Argument[conditionValue] must not be null:";
            throw new IllegalArgumentException(msg + " value=" + value + " this.ToString()=" + ToString());
        }
        doSetupConditionValue(conditionValue, value, location);
        return conditionValue;
    }

    public MbConditionValue setupConditionValue(MbConditionValue conditionValue, Object value, String location, MbConditionOption option) {
        if (conditionValue == null) {
            String msg = "Argument[conditionValue] must not be null:";
            throw new IllegalArgumentException(msg + " value=" + value + " this.ToString()=" + ToString());
        }
        doSetupConditionValue(conditionValue, value, location, option);
        return conditionValue;
    }
	
    abstract protected void doSetupConditionValue(MbConditionValue conditionValue, Object value, String location);
    abstract protected void doSetupConditionValue(MbConditionValue conditionValue, Object value, String location, MbConditionOption option);

    protected String buildBindClause(String columnName, String location) {
        return columnName + " " + getOperand() + " " + "/*pmb." + location + "*/null";
    }

    protected String buildBindClauseWithRearOption(String columnName, String location, String rearOption) {
        return columnName + " " + getOperand() + " " + "/*pmb." + location + "*/null" + rearOption;
    }

    protected String buildBindClause(String columnName, String location, String dummyValue) {
        return columnName + " " + getOperand() + " " + "/*pmb." + location + "*/" + dummyValue;
    }

    protected String buildClauseWithoutValue(String columnName) {
        return columnName + " " + getOperand();
    }

    protected String getWildCard() {
        return "%";
    }

    // ===================================================================================
    //                                                                      Basic Override
    //                                                                      ==============
    public override int GetHashCode() {
        return getConditionKey().GetHashCode();
    }

    public override bool Equals(Object other) {
        if (other is MbConditionKey) {
            if (this.getConditionKey().Equals(((MbConditionKey)other).getConditionKey())) {
                return true;
            }
        }
        return false;
    }

    public override String ToString() {
        return "MbConditionKey: " + getConditionKey() + " " + getOperand() + " wild-card=[" + getWildCard() + "]";
    }
}
}
