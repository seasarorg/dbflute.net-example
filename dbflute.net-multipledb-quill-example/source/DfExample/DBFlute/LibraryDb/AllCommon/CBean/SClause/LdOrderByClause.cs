

using System;

using DfExample.DBFlute.LibraryDb.AllCommon.JavaLike;

namespace DfExample.DBFlute.LibraryDb.AllCommon.CBean.SClause {

[System.Serializable]
public class LdOrderByClause {

    // ===================================================================================
    //                                                                           Attribute
    //                                                                           =========
    protected List<LdOrderByElement> _orderByList = new ArrayList<LdOrderByElement>();

    // ===================================================================================
    //                                                                         Main Method
    //                                                                         ===========
    public void addOrderByElement(LdOrderByElement value) {
        _orderByList.add(value);
    }

    public void reverseAll() {
        foreach (LdOrderByElement element in _orderByList) {
            element.reverse();
        }
    }

    public void exchangeFirstOrderByElementForLastOne() {
        if (_orderByList.size() > 1) {
            LdOrderByElement first = _orderByList.get(0);
            LdOrderByElement last = _orderByList.get(_orderByList.size() - 1);
            _orderByList.set(0, last);
            _orderByList.set(_orderByList.size() - 1, first);
        }
    }

	public void addNullsFirstToPreviousOrderByElement(OrderByNullsSetupper filter) {
	    if (_orderByList.isEmpty()) {
		    return;
		}
		LdOrderByElement last = _orderByList.get(_orderByList.size() - 1);
		last.setOrderByNullsSetupper(filter, true);
	}
	
	public void addNullsLastToPreviousOrderByElement(OrderByNullsSetupper filter) {
	    if (_orderByList.isEmpty()) {
		    return;
		}
		LdOrderByElement last = _orderByList.get(_orderByList.size() - 1);
		last.setOrderByNullsSetupper(filter, false);
	}

    public List<LdOrderByElement> getOrderByList() {
        return _orderByList;
    }

    public String getOrderByClause() {
	    return getOrderByClause(null);
    }
	
    public String getOrderByClause(Map<String, String> selectClauseRealColumnAliasMap) {
        if (_orderByList.isEmpty()) {
            return "";
        }
        StringBuilder sb = new StringBuilder();
        String delimiter = ", ";
        for (Iterator<LdOrderByElement> ite = _orderByList.iterator(); ite.hasNext(); ) {
            LdOrderByElement element = ite.next();
            sb.append(delimiter);
			if (selectClauseRealColumnAliasMap != null) {
			    sb.append(element.getElementClause(selectClauseRealColumnAliasMap));
			} else {
			    sb.append(element.getElementClause());
			}
        }
        sb.delete(0, delimiter.Length).insert(0, "order by ");
        return sb.toString();
    }

    public String GetFirstElementColumnFullName() {
        if (isEmpty()) {
            String msg = "This order-by clause is empty: " + ToString();
            throw new IllegalStateException(msg);
        }
        LdOrderByElement element = (LdOrderByElement)_orderByList.get(0);
        return element.getColumnFullName();
    }

    public String getFirstElementRegisteredColumnFullName() {
        if (isEmpty()) {
            String msg = "This order-by clause is empty: " + ToString();
            throw new IllegalStateException(msg);
        }
        LdOrderByElement element = (LdOrderByElement)_orderByList.get(0);
        return element.getRegisteredColumnFullName();
    }

    public bool isSameOrderByColumn(String columnFullName) {
        String[] columnFullNameArray = columnFullName.Split('/');
        if (_orderByList.size() != columnFullNameArray.Length) {
            return false;
        }
        int count = 0;
        foreach (String columnFullNameElement in columnFullNameArray) {
            LdOrderByElement element = (LdOrderByElement)_orderByList.get(count);
            if (!element.getColumnFullName().ToLower().Equals(columnFullNameElement.ToLower())) {
                return false;
            }
            count++;
        }
        return true;
    }

    public bool isFirstElementAsc() {
        if (isEmpty()) {
            String msg = "This order-by clause is empty: " + ToString();
            throw new IllegalStateException(msg);
        }
        LdOrderByElement element = (LdOrderByElement)_orderByList.get(0);
        return element.isAsc();
    }

    public bool isFirstElementDesc() {
        return !isFirstElementAsc();
    }

    public bool isSameAsFirstElementAliasName(String expectedAliasName) {
        if (isEmpty()) {
            String msg = "This order-by clause is empty: " + ToString();
            throw new IllegalStateException(msg);
        }
        LdOrderByElement element = (LdOrderByElement)_orderByList.get(0);
        String actualAliasName = element.getAliasName();
        if (actualAliasName != null && expectedAliasName != null) {
            return actualAliasName.Equals(expectedAliasName);
        } else {
            return false;
        }
    }

    public bool isSameAsFirstElementColumnName(String expectedColumnName) {
        if (isEmpty()) {
            String msg = "This order-by clause is empty: " + ToString();
            throw new IllegalStateException(msg);
        }
        LdOrderByElement element = (LdOrderByElement)_orderByList.get(0);
        String actualColumnName = element.getColumnName();
        if (actualColumnName != null && expectedColumnName != null) {
            return actualColumnName.Equals(expectedColumnName);
        } else {
            return false;
        }
    }

    public bool isSameAsFirstElementRegisteredAliasName(String expectedRegisteredAliasName) {
        if (isEmpty()) {
            String msg = "This order-by clause is empty: " + ToString();
            throw new IllegalStateException(msg);
        }
        LdOrderByElement element = (LdOrderByElement)_orderByList.get(0);
        String actualRegisteredAliasName = element.getRegisteredAliasName();
        if (actualRegisteredAliasName != null && expectedRegisteredAliasName != null) {
            return actualRegisteredAliasName.Equals(expectedRegisteredAliasName);
        } else {
            return false;
        }
    }

    public bool isSameAsFirstElementRegisteredColumnName(String expectedRegisteredColumnName) {
        if (isEmpty()) {
            String msg = "This order-by clause is empty: " + ToString();
            throw new IllegalStateException(msg);
        }
        LdOrderByElement element = (LdOrderByElement)_orderByList.get(0);
        String actualRegisteredColumnName = element.getRegisteredColumnName();
        if (actualRegisteredColumnName != null && expectedRegisteredColumnName != null) {
            return actualRegisteredColumnName.Equals(expectedRegisteredColumnName);
        } else {
            return false;
        }
    }

    public bool isEmpty() {
        return _orderByList.isEmpty();
    }

    public void clear() {
        _orderByList.clear();
    }

    // ===================================================================================
    //                                                                      Basic Override
    //                                                                      ==============
    public override String ToString() {
        return _orderByList.toString();
    }
}

public interface OrderByNullsSetupper {
    String setup(String columnName, String orderByElementClause, bool nullsFirst);
}

}
