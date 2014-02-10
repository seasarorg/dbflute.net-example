
using System;

namespace DfExample.DBFlute.LibraryDb.AllCommon.CBean.Grouping {

public class LdGroupingOption<ENTITY> {

    // =====================================================================================
    //                                                                             Attribute
    //                                                                             =========
    protected int _elementCount;

    protected LdGroupingRowEndDeterminer<ENTITY> _groupingRowEndDeterminer;

    // =====================================================================================
    //                                                                           Constructor
    //                                                                           ===========
    /**
     * Constructor. You should set the determiner of grouping row end after you create the instance.
     */
    public LdGroupingOption() {
    }

    /**
     * Constructor.
     * @param elementCount The count of row element in a group.
     */
    public LdGroupingOption(int elementCount) {
        _elementCount = elementCount;
    }

    // =====================================================================================
    //                                                                              Accessor
    //                                                                              ========
    public int ElementCount { get {
        return this._elementCount;
    }}

    public LdGroupingRowEndDeterminer<ENTITY> GroupingRowEndDeterminer { get {
        return this._groupingRowEndDeterminer;
    } set {
        this._groupingRowEndDeterminer = value;
    }}
}

}
