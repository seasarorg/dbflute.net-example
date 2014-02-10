
using System;
using System.Collections.Generic;

namespace DfExample.DBFlute.AllCommon.CBean {

    public delegate void SubQuery<SUB_CB>(SUB_CB subCB) where SUB_CB : ConditionBean;
}
