
using System;
using System.Collections.Generic;

namespace DfExample.DBFlute.AllCommon.CBean {

    public delegate void UnionQuery<UNION_CB>(UNION_CB unionCB) where UNION_CB : ConditionBean;
}
