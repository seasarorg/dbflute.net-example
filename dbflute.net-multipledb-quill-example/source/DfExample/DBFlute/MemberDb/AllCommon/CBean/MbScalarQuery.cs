
using System;
using System.Collections.Generic;

namespace DfExample.DBFlute.MemberDb.AllCommon.CBean {

    public delegate void MbScalarQuery<CB>(CB cb) where CB : MbConditionBean;
}
