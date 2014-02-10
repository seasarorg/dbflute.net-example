
using System;

using DfExample.DBFlute.LibraryDb.AllCommon.CBean.COption;
using DfExample.DBFlute.LibraryDb.AllCommon.CBean.CValue;
using DfExample.DBFlute.LibraryDb.AllCommon.JavaLike;

namespace DfExample.DBFlute.LibraryDb.AllCommon.CBean.CKey {

public abstract class LdConditionKey {

    // ===================================================================================
    //                                                                          Definition
    //                                                                          ==========
    /** The condition key of equal. */
    public static readonly LdConditionKey CK_EQUAL = new LdConditionKeyEqual();

    /** The condition key of notEqual as standard. */
    public static readonly LdConditionKey CK_NOT_EQUAL_STANDARD = new LdConditionKeyNotEqualStandard();

    /** The condition key of notEqual as tradition. */
    public static readonly LdConditionKey CK_NOT_EQUAL_TRADITION = new LdConditionKeyNotEqualTradition();

    /** The condition key of greaterThan. */
    public static readonly LdConditionKey CK_GREATER_THAN = new LdConditionKeyGreaterThan();

    /** The condition key of lessrThan. */
    public static readonly LdConditionKey CK_LESS_THAN = new LdConditionKeyLessThan();

    /** The condition key of greaterEqual. */
    public static readonly LdConditionKey CK_GREATER_EQUAL = new LdConditionKeyGreaterEqual();

    /** The condition key of lessEqual. */
    public static readonly LdConditionKey CK_LESS_EQUAL = new LdConditionKeyLessEqual();

    /** The condition key of prefixSearch. */
    public static readonly LdConditionKey CK_PREFIX_SEARCH = new LdConditionKeyPrefixSearch();

    /** The condition key of inScope. */
    public static readonly LdConditionKey CK_IN_SCOPE = new LdConditionKeyInScope();

    /** The condition key of notInScope. */
    public static readonly LdConditionKey CK_NOT_IN_SCOPE = new LdConditionKeyNotInScope();

    /** The condition key of likeSearch. */
    public static readonly LdConditionKey CK_LIKE_SEARCH = new LdConditionKeyLikeSearch();

    /** The condition key of notLikeSearch. */
    public static readonly LdConditionKey CK_NOT_LIKE_SEARCH = new LdConditionKeyNotLikeSearch();

    /** The condition key of isNull. */
    public static readonly LdConditionKey CK_IS_NULL = new LdConditionKeyIsNull();

    /** The condition key of isNotNull. */
    public static readonly LdConditionKey CK_IS_NOT_NULL = new LdConditionKeyIsNotNull();

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

    abstract public bool isValidRegistration(LdConditionValue conditionValue, Object value, String callerName);

    public LdConditionKey addWhereClause(List<String> conditionList, String columnName, LdConditionValue value) {
        if (value == null) {
            String msg = "Argument[value] must not be null:";
            throw new IllegalArgumentException(msg + " value=" + value + " this.ToString()=" + ToString());
        }
        doAddWhereClause(conditionList, columnName, value);
        return this;
    }

    public LdConditionKey addWhereClause(List<String> conditionList, String columnName, LdConditionValue value, LdConditionOption option) {
        if (value == null) {
            String msg = "Argument[value] must not be null:";
            throw new IllegalArgumentException(msg + " value=" + value + " this.ToString()=" + ToString());
        }
        doAddWhereClause(conditionList, columnName, value, option);
        return this;
    }
	
    abstract protected void doAddWhereClause(List<String> conditionList, String columnName, LdConditionValue value);
    abstract protected void doAddWhereClause(List<String> conditionList, String columnName, LdConditionValue value, LdConditionOption option);

    public LdConditionValue setupConditionValue(LdConditionValue conditionValue, Object value, String location) {
        if (conditionValue == null) {
            String msg = "Argument[conditionValue] must not be null:";
            throw new IllegalArgumentException(msg + " value=" + value + " this.ToString()=" + ToString());
        }
        doSetupConditionValue(conditionValue, value, location);
        return conditionValue;
    }

    public LdConditionValue setupConditionValue(LdConditionValue conditionValue, Object value, String location, LdConditionOption option) {
        if (conditionValue == null) {
            String msg = "Argument[conditionValue] must not be null:";
            throw new IllegalArgumentException(msg + " value=" + value + " this.ToString()=" + ToString());
        }
        doSetupConditionValue(conditionValue, value, location, option);
        return conditionValue;
    }
	
    abstract protected void doSetupConditionValue(LdConditionValue conditionValue, Object value, String location);
    abstract protected void doSetupConditionValue(LdConditionValue conditionValue, Object value, String location, LdConditionOption option);

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
        if (other is LdConditionKey) {
            if (this.getConditionKey().Equals(((LdConditionKey)other).getConditionKey())) {
                return true;
            }
        }
        return false;
    }

    public override String ToString() {
        return "LdConditionKey: " + getConditionKey() + " " + getOperand() + " wild-card=[" + getWildCard() + "]";
    }
}
}
