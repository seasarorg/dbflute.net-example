
using System;
using System.Collections.Generic;

namespace DfExample.DBFlute.AllCommon.CBean {

    public delegate void OrQuery<OR_CB>(OR_CB orCB) where OR_CB : ConditionBean;
}
