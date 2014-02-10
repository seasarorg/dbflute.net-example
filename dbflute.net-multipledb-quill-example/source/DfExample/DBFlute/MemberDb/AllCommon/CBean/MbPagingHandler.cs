
using System;
using System.Collections.Generic;

namespace DfExample.DBFlute.MemberDb.AllCommon.CBean {

    public interface MbPagingHandler<ENTITY> {

        MbPagingBean PagingBean { get; }
        int Count();
        IList<ENTITY> Paging();
    }
}
