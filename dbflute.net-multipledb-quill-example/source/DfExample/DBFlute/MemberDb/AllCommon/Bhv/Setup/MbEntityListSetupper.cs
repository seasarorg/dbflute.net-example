
using System;
using System.Collections.Generic;

using DfExample.DBFlute.MemberDb.AllCommon;

namespace DfExample.DBFlute.MemberDb.AllCommon.Bhv.Setup {

    public delegate void MbEntityListSetupper<ENTITY>(IList<ENTITY> entityList) where ENTITY : MbEntity;
}
