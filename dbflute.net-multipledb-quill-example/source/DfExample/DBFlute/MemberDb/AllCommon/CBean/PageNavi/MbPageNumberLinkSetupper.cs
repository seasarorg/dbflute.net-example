
using System;

namespace DfExample.DBFlute.MemberDb.AllCommon.CBean.PageNavi {

    public delegate LINK MbPageNumberLinkSetupper<LINK>(int pageNumberElement, bool current) where LINK : MbPageNumberLink;
}

