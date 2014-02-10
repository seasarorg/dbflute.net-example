
using System;

namespace DfExample.DBFlute.LibraryDb.AllCommon.CBean.CKey {

public class LdConditionKeyNotEqualStandard : LdConditionKeyNotEqual {

    protected override String defineOperand() {
        return "<>"; // is SQL standard operand
    }
}
	
}
