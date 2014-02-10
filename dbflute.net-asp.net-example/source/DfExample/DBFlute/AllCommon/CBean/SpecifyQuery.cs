
using System;
using System.Collections.Generic;

namespace DfExample.DBFlute.AllCommon.CBean {

    public delegate void SpecifyQuery<CB>(CB cb) where CB : ConditionBean;
}
