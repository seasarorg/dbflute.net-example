
using System;
using System.Collections.Generic;

namespace DfExample.DBFlute.LibraryDb.AllCommon.CBean {

    public delegate void LdScalarQuery<CB>(CB cb) where CB : LdConditionBean;
}
