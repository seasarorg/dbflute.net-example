
using System;
using System.Collections.Generic;

namespace DfExample.DBFlute.LibraryDb.AllCommon.CBean {

    public delegate void LdOrQuery<OR_CB>(OR_CB orCB) where OR_CB : LdConditionBean;
}
