
using System;
using System.Collections.Generic;

namespace DfExample.DBFlute.MemberDb.AllCommon.CBean {

    public delegate void MbOrQuery<OR_CB>(OR_CB orCB) where OR_CB : MbConditionBean;
}
