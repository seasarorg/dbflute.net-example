
using System;
using System.Collections.Generic;

namespace DfExample.DBFlute.AllCommon.CBean {

    public interface PagingHandler<ENTITY> {

        PagingBean PagingBean { get; }
        int Count();
        IList<ENTITY> Paging();
    }
}
