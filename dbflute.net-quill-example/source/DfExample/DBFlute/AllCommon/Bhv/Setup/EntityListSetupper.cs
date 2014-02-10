
using System;
using System.Collections.Generic;

using DfExample.DBFlute.AllCommon;

namespace DfExample.DBFlute.AllCommon.Bhv.Setup {

    public delegate void EntityListSetupper<ENTITY>(IList<ENTITY> entityList) where ENTITY : Entity;
}
