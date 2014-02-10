
using System;
using System.Collections.Generic;

namespace DfExample.DBFlute.LibraryDb.AllCommon.CBean {

    public interface LdPagingHandler<ENTITY> {

        LdPagingBean PagingBean { get; }
        int Count();
        IList<ENTITY> Paging();
    }
}
