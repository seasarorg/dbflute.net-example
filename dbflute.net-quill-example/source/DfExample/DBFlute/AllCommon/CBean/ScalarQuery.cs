
using System;
using System.Collections.Generic;

namespace DfExample.DBFlute.AllCommon.CBean {

    public delegate void ScalarQuery<CB>(CB cb) where CB : ConditionBean;
}
