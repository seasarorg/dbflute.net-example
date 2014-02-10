
using System;

namespace DfExample.DBFlute.AllCommon.CBean.PageNavi {

    public delegate LINK PageNumberLinkSetupper<LINK>(int pageNumberElement, bool current) where LINK : PageNumberLink;
}

