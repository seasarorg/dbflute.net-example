
using System;
using System.Collections.Generic;

using DfExample.DBFlute.LibraryDb.AllCommon;

namespace DfExample.DBFlute.LibraryDb.AllCommon.Bhv.Setup {

    public delegate void LdEntityListSetupper<ENTITY>(IList<ENTITY> entityList) where ENTITY : LdEntity;
}
