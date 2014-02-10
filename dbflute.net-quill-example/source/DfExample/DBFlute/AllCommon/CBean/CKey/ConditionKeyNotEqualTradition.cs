
using System;

namespace DfExample.DBFlute.AllCommon.CBean.CKey {

public class ConditionKeyNotEqualTradition : ConditionKeyNotEqual {

    protected override String defineOperand() {
        return "!="; // DBFlute has used for a long time
    }
}
	
}
