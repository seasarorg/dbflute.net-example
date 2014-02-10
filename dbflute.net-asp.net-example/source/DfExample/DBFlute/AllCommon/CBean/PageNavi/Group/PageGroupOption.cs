
using System;
using DfExample.DBFlute.AllCommon.JavaLike;

namespace DfExample.DBFlute.AllCommon.CBean.PageNavi.Group {

[System.Serializable]
public class PageGroupOption {

    // ===================================================================================
    //                                                                           Attribute
    //                                                                           =========
    public int _pageGroupSize;
    public int PageGroupSize { get { return _pageGroupSize; } set { _pageGroupSize = value; } }

    // ===================================================================================
    //                                                                      Basic Override
    //                                                                      ==============
    public override String ToString() {
        StringBuilder sb = new StringBuilder();
        sb.append("{");
        sb.append("pageGroupSize=").append(PageGroupSize);
        sb.append("}");
        return sb.toString();
    }
}

}
