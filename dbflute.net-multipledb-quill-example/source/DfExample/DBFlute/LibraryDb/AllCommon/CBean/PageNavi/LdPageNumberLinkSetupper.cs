
using System;

namespace DfExample.DBFlute.LibraryDb.AllCommon.CBean.PageNavi {

    public delegate LINK LdPageNumberLinkSetupper<LINK>(int pageNumberElement, bool current) where LINK : LdPageNumberLink;
}

