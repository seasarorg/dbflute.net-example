
using System;
using System.Collections.Generic;

namespace DfExample.DBFlute.MemberDb.AllCommon.CBean {

    public delegate void MbUnionQuery<UNION_CB>(UNION_CB unionCB) where UNION_CB : MbConditionBean;
}
