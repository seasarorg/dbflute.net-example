
using System;
using System.Collections.Generic;

namespace DfExample.DBFlute.LibraryDb.AllCommon.CBean {

    public delegate void LdSubQuery<SUB_CB>(SUB_CB subCB) where SUB_CB : LdConditionBean;
}
