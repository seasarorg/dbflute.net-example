
using System;

namespace DfExample.DBFlute.MemberDb.AllCommon.CBean.CKey {

public class MbConditionKeyNotEqualTradition : MbConditionKeyNotEqual {

    protected override String defineOperand() {
        return "!="; // DBFlute has used for a long time
    }
}
	
}
