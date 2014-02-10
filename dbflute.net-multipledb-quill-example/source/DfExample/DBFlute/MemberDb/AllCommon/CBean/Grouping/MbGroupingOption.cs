
using System;

namespace DfExample.DBFlute.MemberDb.AllCommon.CBean.Grouping {

public class MbGroupingOption<ENTITY> {

    // =====================================================================================
    //                                                                             Attribute
    //                                                                             =========
    protected int _elementCount;

    protected MbGroupingRowEndDeterminer<ENTITY> _groupingRowEndDeterminer;

    // =====================================================================================
    //                                                                           Constructor
    //                                                                           ===========
    /**
     * Constructor. You should set the determiner of grouping row end after you create the instance.
     */
    public MbGroupingOption() {
    }

    /**
     * Constructor.
     * @param elementCount The count of row element in a group.
     */
    public MbGroupingOption(int elementCount) {
        _elementCount = elementCount;
    }

    // =====================================================================================
    //                                                                              Accessor
    //                                                                              ========
    public int ElementCount { get {
        return this._elementCount;
    }}

    public MbGroupingRowEndDeterminer<ENTITY> GroupingRowEndDeterminer { get {
        return this._groupingRowEndDeterminer;
    } set {
        this._groupingRowEndDeterminer = value;
    }}
}

}
