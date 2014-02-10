
using System;
using System.Collections.Generic;

namespace DfExample.DBFlute.MemberDb.AllCommon.CBean {

    public delegate void MbSubQuery<SUB_CB>(SUB_CB subCB) where SUB_CB : MbConditionBean;
}
