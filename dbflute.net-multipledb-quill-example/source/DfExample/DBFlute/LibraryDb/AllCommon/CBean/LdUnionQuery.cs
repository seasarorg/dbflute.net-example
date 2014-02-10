
using System;
using System.Collections.Generic;

namespace DfExample.DBFlute.LibraryDb.AllCommon.CBean {

    public delegate void LdUnionQuery<UNION_CB>(UNION_CB unionCB) where UNION_CB : LdConditionBean;
}
